namespace AgOpenGPS
{
    partial class FormTram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTram));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSmallSnapRight = new System.Windows.Forms.Label();
            this.nudPasses = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnTriggerDistanceDn = new ProXoft.WinForms.RepeatButton();
            this.btnTriggerDistanceUp = new ProXoft.WinForms.RepeatButton();
            this.btnSwapAB = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdjLeft = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdjRight = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToolWidthHalf = new System.Windows.Forms.Label();
            this.lblTramWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSmallSnapRight
            // 
            resources.ApplyResources(this.lblSmallSnapRight, "lblSmallSnapRight");
            this.lblSmallSnapRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSmallSnapRight.ForeColor = System.Drawing.Color.Black;
            this.lblSmallSnapRight.Name = "lblSmallSnapRight";
            // 
            // nudPasses
            // 
            resources.ApplyResources(this.nudPasses, "nudPasses");
            this.nudPasses.BackColor = System.Drawing.Color.AliceBlue;
            this.nudPasses.InterceptArrowKeys = false;
            this.nudPasses.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPasses.Name = "nudPasses";
            this.nudPasses.ReadOnly = true;
            this.nudPasses.Value = new decimal(new int[] {
            777,
            0,
            0,
            0});
            this.nudPasses.Click += new System.EventHandler(this.nudPasses_Click);
            this.nudPasses.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nudPasses_HelpRequested);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // btnMode
            // 
            resources.ApplyResources(this.btnMode, "btnMode");
            this.btnMode.BackColor = System.Drawing.Color.Transparent;
            this.btnMode.FlatAppearance.BorderSize = 0;
            this.btnMode.ForeColor = System.Drawing.Color.White;
            this.btnMode.Image = global::AgOpenGPS.Properties.Resources.TramOff;
            this.btnMode.Name = "btnMode";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            this.btnMode.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnMode_HelpRequested);
            // 
            // btnLeft
            // 
            resources.ApplyResources(this.btnLeft, "btnLeft");
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImage = global::AgOpenGPS.Properties.Resources.SnapLeft;
            this.btnLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnLeft_HelpRequested);
            // 
            // btnRight
            // 
            resources.ApplyResources(this.btnRight, "btnRight");
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BackgroundImage = global::AgOpenGPS.Properties.Resources.SnapRight;
            this.btnRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Name = "btnRight";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnRight_HelpRequested);
            // 
            // btnTriggerDistanceDn
            // 
            resources.ApplyResources(this.btnTriggerDistanceDn, "btnTriggerDistanceDn");
            this.btnTriggerDistanceDn.BackColor = System.Drawing.Color.Transparent;
            this.btnTriggerDistanceDn.FlatAppearance.BorderSize = 0;
            this.btnTriggerDistanceDn.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnTriggerDistanceDn.Name = "btnTriggerDistanceDn";
            this.btnTriggerDistanceDn.UseVisualStyleBackColor = false;
            this.btnTriggerDistanceDn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTriggerDistanceDn_MouseDown);
            // 
            // btnTriggerDistanceUp
            // 
            resources.ApplyResources(this.btnTriggerDistanceUp, "btnTriggerDistanceUp");
            this.btnTriggerDistanceUp.BackColor = System.Drawing.Color.Transparent;
            this.btnTriggerDistanceUp.FlatAppearance.BorderSize = 0;
            this.btnTriggerDistanceUp.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnTriggerDistanceUp.Name = "btnTriggerDistanceUp";
            this.btnTriggerDistanceUp.UseVisualStyleBackColor = false;
            this.btnTriggerDistanceUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTriggerDistanceUp_MouseDown);
            // 
            // btnSwapAB
            // 
            resources.ApplyResources(this.btnSwapAB, "btnSwapAB");
            this.btnSwapAB.BackColor = System.Drawing.Color.Transparent;
            this.btnSwapAB.FlatAppearance.BorderSize = 0;
            this.btnSwapAB.ForeColor = System.Drawing.Color.White;
            this.btnSwapAB.Image = global::AgOpenGPS.Properties.Resources.ABSwapPoints;
            this.btnSwapAB.Name = "btnSwapAB";
            this.btnSwapAB.UseVisualStyleBackColor = false;
            this.btnSwapAB.Click += new System.EventHandler(this.btnSwapAB_Click);
            this.btnSwapAB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSwapAB_HelpRequested);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.SwitchOff;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancel_HelpRequested);
            // 
            // btnAdjLeft
            // 
            resources.ApplyResources(this.btnAdjLeft, "btnAdjLeft");
            this.btnAdjLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjLeft.BackgroundImage = global::AgOpenGPS.Properties.Resources.SnapLeftHalf;
            this.btnAdjLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnAdjLeft.FlatAppearance.BorderSize = 0;
            this.btnAdjLeft.ForeColor = System.Drawing.Color.White;
            this.btnAdjLeft.Name = "btnAdjLeft";
            this.btnAdjLeft.UseVisualStyleBackColor = false;
            this.btnAdjLeft.Click += new System.EventHandler(this.btnAdjLeft_Click);
            this.btnAdjLeft.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnAdjLeft_HelpRequested);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::AgOpenGPS.Properties.Resources.FileSave;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnExit_HelpRequested);
            // 
            // btnAdjRight
            // 
            resources.ApplyResources(this.btnAdjRight, "btnAdjRight");
            this.btnAdjRight.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjRight.BackgroundImage = global::AgOpenGPS.Properties.Resources.SnapRightHalf;
            this.btnAdjRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnAdjRight.FlatAppearance.BorderSize = 0;
            this.btnAdjRight.ForeColor = System.Drawing.Color.White;
            this.btnAdjRight.Name = "btnAdjRight";
            this.btnAdjRight.UseVisualStyleBackColor = false;
            this.btnAdjRight.Click += new System.EventHandler(this.btnAdjRight_Click);
            this.btnAdjRight.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnAdjRight_HelpRequested);
            // 
            // lblTrack
            // 
            resources.ApplyResources(this.lblTrack, "lblTrack");
            this.lblTrack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTrack.ForeColor = System.Drawing.Color.Black;
            this.lblTrack.Name = "lblTrack";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // lblToolWidthHalf
            // 
            resources.ApplyResources(this.lblToolWidthHalf, "lblToolWidthHalf");
            this.lblToolWidthHalf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblToolWidthHalf.ForeColor = System.Drawing.Color.Black;
            this.lblToolWidthHalf.Name = "lblToolWidthHalf";
            // 
            // lblTramWidth
            // 
            resources.ApplyResources(this.lblTramWidth, "lblTramWidth");
            this.lblTramWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTramWidth.ForeColor = System.Drawing.Color.Black;
            this.lblTramWidth.Name = "lblTramWidth";
            // 
            // FormTram
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.nudPasses);
            this.Controls.Add(this.btnTriggerDistanceDn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnAdjLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTriggerDistanceUp);
            this.Controls.Add(this.btnSwapAB);
            this.Controls.Add(this.btnAdjRight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSmallSnapRight);
            this.Controls.Add(this.lblToolWidthHalf);
            this.Controls.Add(this.lblTramWidth);
            this.Controls.Add(this.btnMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTram";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTram_FormClosing);
            this.Load += new System.EventHandler(this.FormTram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdjLeft;
        private System.Windows.Forms.Button btnAdjRight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSmallSnapRight;
        private System.Windows.Forms.NumericUpDown nudPasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSwapAB;
        private ProXoft.WinForms.RepeatButton btnTriggerDistanceDn;
        private ProXoft.WinForms.RepeatButton btnTriggerDistanceUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Label lblTramWidth;
        private System.Windows.Forms.Label lblToolWidthHalf;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Label label6;
    }
}