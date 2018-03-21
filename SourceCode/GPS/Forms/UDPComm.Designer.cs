﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Drawing;

namespace AgOpenGPS
{
    public partial class FormGPS
    {
        // Send and Recv socket
        private Socket sendSocket;
        private Socket recvSocket;
        private bool isSendConnected;

        //IP address and port of Auto Steer server
        IPAddress epIP = IPAddress.Parse(Properties.Settings.Default.setIP_autoSteerIP);

        // Data stream
        private byte[] buffer = new byte[1024];

        // Status delegate
        private delegate void UpdateRecvMessageDelegate(string recvMessage);
        private UpdateRecvMessageDelegate updateRecvMessageDelegate = null;

        public void SendUDPMessage(string message)
        {

            if (isSendConnected)
            {
                try
                {
                    IPEndPoint epAutoSteer  = new IPEndPoint(epIP, Properties.Settings.Default.setIP_autoSteerPort);

                    // Get packet as byte array
                    byte[] byteData = Encoding.ASCII.GetBytes(message);

                    if (byteData.Length != 0)

                        // Send packet to the zero
                        sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epAutoSteer, new AsyncCallback(SendData), null);
                }
                catch (Exception e)
                {
                    WriteErrorLog("Sending UDP Message" + e.ToString());

                    MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
 
        private void SendData(IAsyncResult asyncResult)
        {
            try
            {
                sendSocket.EndSend(asyncResult);
            }
            catch (Exception e)
            {
                WriteErrorLog(" UDP Send Data" + e.ToString());

                MessageBox.Show("SendData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveData(IAsyncResult asyncResult)
        {
            try
            {
                // Initialise the IPEndPoint for the client
                EndPoint epSender = new IPEndPoint(IPAddress.Any, 0);
            
                // Receive all data
                int msgLen = recvSocket.EndReceiveFrom(asyncResult, ref epSender);

                byte[] localMsg = new byte[msgLen];
                Array.Copy(buffer, localMsg, msgLen);

                // Listen for more connections again...
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(ReceiveData), epSender);

                string text = Encoding.ASCII.GetString(localMsg);

                // Update status through a delegate
                Invoke(updateRecvMessageDelegate, new object[] { text });
            }
            catch (Exception e)
            {
                WriteErrorLog("UDP Recv data " + e.ToString());

                MessageBox.Show("ReceiveData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UpdateRecvMessage(string recvd)
        {
            recvSentenceSettings = recvd;
            pn.rawBuffer += recvd;
        }

        #region Gesture

        // Private variables used to maintain the state of gestures
        //private DrawingObject _dwo = new DrawingObject();
        private Point _ptFirst = new Point();

        private Point _ptSecond = new Point();
        private int _iArguments = 0;

        // One of the fields in GESTUREINFO structure is type of Int64 (8 bytes).
        // The relevant gesture information is stored in lower 4 bytes. This
        // bit mask is used to get 4 lower bytes from this argument.
        private const Int64 ULL_ARGUMENTS_BIT_MASK = 0x00000000FFFFFFFF;

        //-----------------------------------------------------------------------
        // Multitouch/Touch glue (from winuser.h file)
        // Since the managed layer between C# and WinAPI functions does not
        // exist at the moment for multi-touch related functions this part of
        // code is required to replicate definitions from winuser.h file.
        //-----------------------------------------------------------------------
        // Touch event window message constants [winuser.h]
        private const int WM_GESTURENOTIFY = 0x011A;

        private const int WM_GESTURE = 0x0119;

        private const int GC_ALLGESTURES = 0x00000001;

        // Gesture IDs
        private const int GID_BEGIN = 1;

        private const int GID_END = 2;
        private const int GID_ZOOM = 3;
        private const int GID_PAN = 4;
        private const int GID_ROTATE = 5;
        private const int GID_TWOFINGERTAP = 6;


        private const int GID_PRESSANDTAP = 7;

        // Gesture flags - GESTUREINFO.dwFlags
        private const int GF_BEGIN = 0x00000001;

        private const int GF_INERTIA = 0x00000002;
        private const int GF_END = 0x00000004;

        //
        // Gesture configuration structure
        //   - Used in SetGestureConfig and GetGestureConfig
        //   - Note that any setting not included in either GESTURECONFIG.dwWant
        //     or GESTURECONFIG.dwBlock will use the parent window's preferences
        //     or system defaults.
        //
        // Touch API defined structures [winuser.h]
        [StructLayout(LayoutKind.Sequential)]
        private struct GESTURECONFIG
        {
            public int dwID;    // gesture ID
            public int dwWant;  // settings related to gesture ID that are to be

            // turned on
            public int dwBlock; // settings related to gesture ID that are to be

            // turned off
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINTS
        {
            public short x;
            public short y;
        }

        //
        // Gesture information structure
        //   - Pass the HGESTUREINFO received in the WM_GESTURE message lParam
        //     into the GetGestureInfo function to retrieve this information.
        //   - If cbExtraArgs is non-zero, pass the HGESTUREINFO received in
        //     the WM_GESTURE message lParam into the GetGestureExtraArgs
        //     function to retrieve extended argument information.
        //
        [StructLayout(LayoutKind.Sequential)]
        private struct GESTUREINFO
        {
            public int cbSize;           // size, in bytes, of this structure

            // (including variable length Args
            // field)
            public int dwFlags;          // see GF_* flags

            public int dwID;             // gesture ID, see GID_* defines
            public IntPtr hwndTarget;    // handle to window targeted by this

            // gesture
            [MarshalAs(UnmanagedType.Struct)]
            internal POINTS ptsLocation; // current location of this gesture

            public int dwInstanceID;     // internally used
            public int dwSequenceID;     // internally used
            public Int64 ullArguments;   // arguments for gestures whose

            // arguments fit in 8 BYTES
            public int cbExtraArgs;      // size, in bytes, of extra arguments,

            // if any, that accompany this gesture
        }

        // Currently touch/multitouch access is done through unmanaged code
        // We must p/invoke into user32 [winuser.h]
        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetGestureConfig(IntPtr hWnd, int dwReserved, int cIDs, ref GESTURECONFIG pGestureConfig, int cbSize);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetGestureInfo(IntPtr hGestureInfo, ref GESTUREINFO pGestureInfo);

        // size of GESTURECONFIG structure
        private int _gestureConfigSize;

        // size of GESTUREINFO structure
        private int _gestureInfoSize;

        [SecurityPermission(SecurityAction.Demand)]
        private void SetupStructSizes()
        {
            // Both GetGestureCommandInfo and GetTouchInputInfo need to be
            // passed the size of the structure they will be filling
            // we get the sizes upfront so they can be used later.
            _gestureConfigSize = Marshal.SizeOf(new GESTURECONFIG());
            _gestureInfoSize = Marshal.SizeOf(new GESTUREINFO());
        }

        //-------------------------------------------------------------
        // Since there is no managed layer at the moment that supports
        // event handlers for WM_GESTURENOTIFY and WM_GESTURE
        // messages we have to override WndProc function
        //
        // in
        //   m - Message object
        //-------------------------------------------------------------
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            bool handled = false;

            switch (m.Msg)
            {
                case WM_GESTURENOTIFY:
                    {
                        // This is the right place to define the list of gestures
                        // that this application will support. By populating
                        // GESTURECONFIG structure and calling SetGestureConfig
                        // function. We can choose gestures that we want to
                        // handle in our application. In this app we decide to
                        // handle all gestures.
                        GESTURECONFIG gc = new GESTURECONFIG
                        {
                            dwID = 0,                // gesture ID
                            dwWant = GC_ALLGESTURES, // settings related to gesture
                                                     // ID that are to be turned on
                            dwBlock = 0 // settings related to gesture ID that are
                        };
                        // to be

                        // We must p/invoke into user32 [winuser.h]
                        bool bResult = SetGestureConfig(
                            Handle, // window for which configuration is specified
                            0,      // reserved, must be 0
                            1,      // count of GESTURECONFIG structures
                            ref gc, // array of GESTURECONFIG structures, dwIDs
                                    // will be processed in the order specified
                                    // and repeated occurances will overwrite
                                    // previous ones
                            _gestureConfigSize // sizeof(GESTURECONFIG)
                        );

                        if (!bResult)
                        {
                            throw new Exception("Error in execution of SetGestureConfig");
                        }
                    }
                    handled = true;
                    break;

                case WM_GESTURE:
                    // The gesture processing code is implemented in
                    // the DecodeGesture method
                    handled = DecodeGesture(ref m);
                    break;

                default:
                    handled = false;
                    break;
            }

            // Filter message back up to parents.
            base.WndProc(ref m);

            if (handled)
            {
                // Acknowledge event if handled.
                try
                {
                    m.Result = new System.IntPtr(1);
                }
                catch (Exception)
                {
                }
            }
        }

        // Taken from GCI_ROTATE_ANGLE_FROM_ARGUMENT.
        // Converts from "binary radians" to traditional radians.
        static protected double ArgToRadians(Int64 arg)
        {
            return (arg / 65535.0 * 4.0 * 3.14159265) - (2.0 * 3.14159265);
        }

        // Handler of gestures
        //in:
        //  m - Message object
        private bool DecodeGesture(ref Message m)
        {
            GESTUREINFO gi;

            try
            {
                gi = new GESTUREINFO();
            }
            catch (Exception)
            {
                return false;
            }

            gi.cbSize = _gestureInfoSize;

            // Load the gesture information.
            // We must p/invoke into user32 [winuser.h]
            if (!GetGestureInfo(m.LParam, ref gi))
            {
                return false;
            }

            switch (gi.dwID)
            {
                case GID_BEGIN:
                case GID_END:
                    break;

                case GID_ZOOM:
                    switch (gi.dwFlags)
                    {
                        case GF_BEGIN:
                            _iArguments = (int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                            _ptFirst.X = gi.ptsLocation.x;
                            _ptFirst.Y = gi.ptsLocation.y;
                            _ptFirst = PointToClient(_ptFirst);
                            break;

                        default:
                            // We read here the second point of the gesture. This
                            // is middle point between fingers in this new
                            // position.
                            _ptSecond.X = gi.ptsLocation.x;
                            _ptSecond.Y = gi.ptsLocation.y;
                            _ptSecond = PointToClient(_ptSecond);
                            {
                                // The zoom factor is the ratio of the new
                                // and the old distance. The new distance
                                // between two fingers is stored in
                                // gi.ullArguments (lower 4 bytes) and the old
                                // distance is stored in _iArguments.
                                double k = (double)(_iArguments)
                                            / (double)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                                //lblX.Text = k.ToString();
                                camera.zoomValue *= k;
                                if (camera.zoomValue < 6.0) camera.zoomValue = 6;
                                camera.camSetDistance = camera.zoomValue * camera.zoomValue * -1;
                                SetZoom();
                            }

                            // Now we have to store new information as a starting
                            // information for the next step in this gesture.
                            _ptFirst = _ptSecond;
                            _iArguments = (int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                            break;
                    }
                    break;

                //case GID_PAN:
                //    switch (gi.dwFlags)
                //    {
                //        case GF_BEGIN:
                //            _ptFirst.X = gi.ptsLocation.x;
                //            _ptFirst.Y = gi.ptsLocation.y;
                //            _ptFirst = PointToClient(_ptFirst);
                //            break;

                //        default:
                //            // We read the second point of this gesture. It is a
                //            // middle point between fingers in this new position
                //            _ptSecond.X = gi.ptsLocation.x;
                //            _ptSecond.Y = gi.ptsLocation.y;
                //            _ptSecond = PointToClient(_ptSecond);

                //            // We apply move operation of the object
                //            _dwo.Move(_ptSecond.X - _ptFirst.X, _ptSecond.Y - _ptFirst.Y);

                //            Invalidate();

                //            // We have to copy second point into first one to
                //            // prepare for the next step of this gesture.
                //            _ptFirst = _ptSecond;
                //            break;
                //    }
                //    break;

                case GID_ROTATE:
                    switch (gi.dwFlags)
                    {
                        case GF_BEGIN:
                            _iArguments = 32768;
                            break;

                        default:
                            // Gesture handler returns cumulative rotation angle. However we
                            // have to pass the delta angle to our function responsible
                            // to process the rotation gesture.
                            double k = ((int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK) - _iArguments) * 0.01;
                            camera.camPitch -= k;
                            if (camera.camPitch < -80) camera.camPitch = -80;
                            if (camera.camPitch > 0) camera.camPitch = 0;
                            _iArguments = (int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                            break;
                    }
                    break;

                    //case GID_TWOFINGERTAP:
                    //    // Toggle drawing of diagonals
                    //    _dwo.ToggleDrawDiagonals();
                    //    Invalidate();
                    //    break;

                    //case GID_PRESSANDTAP:
                    //    if (gi.dwFlags == GF_BEGIN)
                    //    {
                    //        // Shift drawing color
                    //        _dwo.ShiftColor();
                    //        Invalidate();
                    //    }
                    //    break;
            }

            return true;
        }

        #endregion Gesture

        //keystrokes for easy and quick startup
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //reset Sim
            if (keyData == Keys.L)
            {
                btnResetSim.PerformClick();
                return true;
            }

            //speed up
            if (keyData == Keys.K)
            {
                sim.stepDistance += 0.05;
                if (sim.stepDistance > 5.8) sim.stepDistance = 5.8;
                tbarStepDistance.Value = (int)(sim.stepDistance * 10.0 * fixUpdateHz);

                return true;
            }

            //Stop
            if (keyData == Keys.J)
            {
                sim.stepDistance = 0;
                tbarStepDistance.Value = 0;
                return true;
            }

            //slow down
            if (keyData == Keys.H)
            {
                sim.stepDistance -= 0.05;
                if (sim.stepDistance < 0) sim.stepDistance = 0;
                tbarStepDistance.Value = (int)(sim.stepDistance * 10.0 * fixUpdateHz);
                return true;
            }

            //turn right
            if (keyData == Keys.M)
            {
                sim.steerAngle++;
                if (sim.steerAngle > 30) sim.steerAngle = 30;
                sim.steerAngleScrollBar = sim.steerAngle;
                lblSteerAngle.Text = sim.steerAngle.ToString();
                tbarSteerAngle.Value = (int)(10 * sim.steerAngle);
                return true;
            }

            //turn left
            if (keyData == Keys.B)
            {
                sim.steerAngle--;
                if (sim.steerAngle < -30) sim.steerAngle = -30;
                sim.steerAngleScrollBar = sim.steerAngle;
                lblSteerAngle.Text = sim.steerAngle.ToString();
                tbarSteerAngle.Value = (int)(10 * sim.steerAngle);
                return true;
            }

            //zero steering
            if (keyData == Keys.N)
            {
                sim.steerAngle = 0.0;
                sim.steerAngleScrollBar = sim.steerAngle;
                lblSteerAngle.Text = sim.steerAngle.ToString();
                tbarSteerAngle.Value = (int)(10 * sim.steerAngle);
                return true;
            }

            if (keyData == (Keys.F))
            {
                JobNewOpenResume();
                return true;    // indicate that you handled this keystroke
            }

            if (keyData == (Keys.A))
            {
                btnAutoSteer.PerformClick();
                return true;    // indicate that you handled this keystroke
            }

            if (keyData == (Keys.D))
            {
                btnSectionOffAutoOn.PerformClick();
                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
