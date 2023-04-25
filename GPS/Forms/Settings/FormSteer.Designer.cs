namespace AgOpenGPS
{
    partial class FormSteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSteer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.lblSteerAngleActual = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPWMDisplay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalcSteerAngleInner = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.pbarSensor = new System.Windows.Forms.ProgressBar();
            this.lblPercentFS = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSteer = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.lblMaxSteerAngle = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hsbarAckerman = new System.Windows.Forms.HScrollBar();
            this.hsbarMaxSteerAngle = new System.Windows.Forms.HScrollBar();
            this.lblAckerman = new System.Windows.Forms.Label();
            this.pbarRight = new System.Windows.Forms.ProgressBar();
            this.pbarLeft = new System.Windows.Forms.ProgressBar();
            this.lblActualSteerAngleUpper = new System.Windows.Forms.Label();
            this.btnZeroWAS = new System.Windows.Forms.Button();
            this.hsbarCountsPerDegree = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCountsPerDegree = new System.Windows.Forms.Label();
            this.hsbarWasOffset = new System.Windows.Forms.HScrollBar();
            this.lblSteerAngleSensorZero = new System.Windows.Forms.Label();
            this.tabGain = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hsbarMinPWM = new System.Windows.Forms.HScrollBar();
            this.hsbarProportionalGain = new System.Windows.Forms.HScrollBar();
            this.lblProportionalGain = new System.Windows.Forms.Label();
            this.lblHighSteerPWM = new System.Windows.Forms.Label();
            this.lblMinPWM = new System.Windows.Forms.Label();
            this.hsbarHighSteerPWM = new System.Windows.Forms.HScrollBar();
            this.tabStan = new System.Windows.Forms.TabPage();
            this.lblIntegralPercent = new System.Windows.Forms.Label();
            this.hsbarIntegral = new System.Windows.Forms.HScrollBar();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblHeadingErrorGain = new System.Windows.Forms.Label();
            this.lblStanleyGain = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hsbarStanleyGain = new System.Windows.Forms.HScrollBar();
            this.hsbarHeadingErrorGain = new System.Windows.Forms.HScrollBar();
            this.tabInt = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.lblHoldLookAhead = new System.Windows.Forms.Label();
            this.hsbarHoldLookAhead = new System.Windows.Forms.HScrollBar();
            this.lblPureIntegral = new System.Windows.Forms.Label();
            this.hsbarIntegralPurePursuit = new System.Windows.Forms.HScrollBar();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.hsbarLookAheadMult = new System.Windows.Forms.HScrollBar();
            this.lblLookAhead = new System.Windows.Forms.Label();
            this.lblLookAheadMult = new System.Windows.Forms.Label();
            this.hsbarLookAhead = new System.Windows.Forms.HScrollBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblSideHillComp = new System.Windows.Forms.Label();
            this.hsbarSideHillComp = new System.Windows.Forms.HScrollBar();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.labelPressureTurnSensor = new System.Windows.Forms.Label();
            this.labelCurrentTurnSensor = new System.Windows.Forms.Label();
            this.labelEncoder = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.cboxMotorDrive = new System.Windows.Forms.ComboBox();
            this.cboxSteerEnable = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.cboxConv = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.nudMaxCounts = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartSA = new System.Windows.Forms.Button();
            this.btnFreeDriveZero = new System.Windows.Forms.Button();
            this.btnSteerAngleUp = new ProXoft.WinForms.RepeatButton();
            this.btnFreeDrive = new System.Windows.Forms.Button();
            this.btnSteerAngleDown = new ProXoft.WinForms.RepeatButton();
            this.hsbarSensor = new System.Windows.Forms.HScrollBar();
            this.lblhsbarSensor = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudPanicStopSpeed = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cboxCurrentSensor = new System.Windows.Forms.CheckBox();
            this.cboxPressureSensor = new System.Windows.Forms.CheckBox();
            this.pboxSendSteer = new System.Windows.Forms.PictureBox();
            this.cboxDanfoss = new System.Windows.Forms.CheckBox();
            this.chkSteerInvertRelays = new System.Windows.Forms.CheckBox();
            this.chkInvertSteer = new System.Windows.Forms.CheckBox();
            this.cboxEncoder = new System.Windows.Forms.CheckBox();
            this.chkInvertWAS = new System.Windows.Forms.CheckBox();
            this.btnSendSteerConfigPGN = new System.Windows.Forms.Button();
            this.cboxXY = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSteer.SuspendLayout();
            this.tabGain.SuspendLayout();
            this.tabStan.SuspendLayout();
            this.tabInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCounts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanicStopSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendSteer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblSteerAngle
            // 
            resources.ApplyResources(this.lblSteerAngle, "lblSteerAngle");
            this.lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngle.ForeColor = System.Drawing.Color.Black;
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // lblSteerAngleActual
            // 
            resources.ApplyResources(this.lblSteerAngleActual, "lblSteerAngleActual");
            this.lblSteerAngleActual.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngleActual.ForeColor = System.Drawing.Color.Black;
            this.lblSteerAngleActual.Name = "lblSteerAngleActual";
            this.lblSteerAngleActual.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Name = "lblError";
            this.lblError.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // lblPWMDisplay
            // 
            resources.ApplyResources(this.lblPWMDisplay, "lblPWMDisplay");
            this.lblPWMDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblPWMDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPWMDisplay.Name = "lblPWMDisplay";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Name = "label13";
            this.label13.Click += new System.EventHandler(this.expandWindow_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Name = "label14";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Name = "label8";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // lblCalcSteerAngleInner
            // 
            resources.ApplyResources(this.lblCalcSteerAngleInner, "lblCalcSteerAngleInner");
            this.lblCalcSteerAngleInner.BackColor = System.Drawing.Color.Transparent;
            this.lblCalcSteerAngleInner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalcSteerAngleInner.Name = "lblCalcSteerAngleInner";
            // 
            // lblDiameter
            // 
            resources.ApplyResources(this.lblDiameter, "lblDiameter");
            this.lblDiameter.BackColor = System.Drawing.Color.Transparent;
            this.lblDiameter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiameter.Name = "lblDiameter";
            // 
            // pbarSensor
            // 
            resources.ApplyResources(this.pbarSensor, "pbarSensor");
            this.pbarSensor.Maximum = 255;
            this.pbarSensor.Name = "pbarSensor";
            this.pbarSensor.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblPercentFS
            // 
            resources.ApplyResources(this.lblPercentFS, "lblPercentFS");
            this.lblPercentFS.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentFS.ForeColor = System.Drawing.Color.Black;
            this.lblPercentFS.Name = "lblPercentFS";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabSteer);
            this.tabControl1.Controls.Add(this.tabGain);
            this.tabControl1.Controls.Add(this.tabStan);
            this.tabControl1.Controls.Add(this.tabInt);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabSteer
            // 
            resources.ApplyResources(this.tabSteer, "tabSteer");
            this.tabSteer.BackColor = System.Drawing.Color.Gainsboro;
            this.tabSteer.BackgroundImage = global::AgOpenGPS.Properties.Resources.Sf_SteerTab;
            this.tabSteer.Controls.Add(this.label23);
            this.tabSteer.Controls.Add(this.lblMaxSteerAngle);
            this.tabSteer.Controls.Add(this.label17);
            this.tabSteer.Controls.Add(this.label7);
            this.tabSteer.Controls.Add(this.hsbarAckerman);
            this.tabSteer.Controls.Add(this.hsbarMaxSteerAngle);
            this.tabSteer.Controls.Add(this.lblAckerman);
            this.tabSteer.Controls.Add(this.pbarRight);
            this.tabSteer.Controls.Add(this.pbarLeft);
            this.tabSteer.Controls.Add(this.lblActualSteerAngleUpper);
            this.tabSteer.Controls.Add(this.btnZeroWAS);
            this.tabSteer.Controls.Add(this.hsbarCountsPerDegree);
            this.tabSteer.Controls.Add(this.label10);
            this.tabSteer.Controls.Add(this.lblCountsPerDegree);
            this.tabSteer.Controls.Add(this.hsbarWasOffset);
            this.tabSteer.Controls.Add(this.lblSteerAngleSensorZero);
            this.tabSteer.Name = "tabSteer";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Name = "label23";
            // 
            // lblMaxSteerAngle
            // 
            resources.ApplyResources(this.lblMaxSteerAngle, "lblMaxSteerAngle");
            this.lblMaxSteerAngle.ForeColor = System.Drawing.Color.Black;
            this.lblMaxSteerAngle.Name = "lblMaxSteerAngle";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Name = "label17";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // hsbarAckerman
            // 
            resources.ApplyResources(this.hsbarAckerman, "hsbarAckerman");
            this.hsbarAckerman.LargeChange = 1;
            this.hsbarAckerman.Maximum = 200;
            this.hsbarAckerman.Minimum = 1;
            this.hsbarAckerman.Name = "hsbarAckerman";
            this.hsbarAckerman.Value = 100;
            this.hsbarAckerman.ValueChanged += new System.EventHandler(this.hsbarAckerman_ValueChanged);
            this.hsbarAckerman.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarAckerman_HelpRequested);
            // 
            // hsbarMaxSteerAngle
            // 
            resources.ApplyResources(this.hsbarMaxSteerAngle, "hsbarMaxSteerAngle");
            this.hsbarMaxSteerAngle.LargeChange = 1;
            this.hsbarMaxSteerAngle.Maximum = 80;
            this.hsbarMaxSteerAngle.Minimum = 10;
            this.hsbarMaxSteerAngle.Name = "hsbarMaxSteerAngle";
            this.hsbarMaxSteerAngle.Value = 10;
            this.hsbarMaxSteerAngle.ValueChanged += new System.EventHandler(this.hsbarMaxSteerAngle_ValueChanged);
            this.hsbarMaxSteerAngle.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarMaxSteerAngle_HelpRequested);
            // 
            // lblAckerman
            // 
            resources.ApplyResources(this.lblAckerman, "lblAckerman");
            this.lblAckerman.ForeColor = System.Drawing.Color.Black;
            this.lblAckerman.Name = "lblAckerman";
            // 
            // pbarRight
            // 
            resources.ApplyResources(this.pbarRight, "pbarRight");
            this.pbarRight.Maximum = 50;
            this.pbarRight.Name = "pbarRight";
            // 
            // pbarLeft
            // 
            resources.ApplyResources(this.pbarLeft, "pbarLeft");
            this.pbarLeft.Maximum = 50;
            this.pbarLeft.Name = "pbarLeft";
            // 
            // lblActualSteerAngleUpper
            // 
            resources.ApplyResources(this.lblActualSteerAngleUpper, "lblActualSteerAngleUpper");
            this.lblActualSteerAngleUpper.BackColor = System.Drawing.Color.Transparent;
            this.lblActualSteerAngleUpper.ForeColor = System.Drawing.Color.Black;
            this.lblActualSteerAngleUpper.Name = "lblActualSteerAngleUpper";
            // 
            // btnZeroWAS
            // 
            resources.ApplyResources(this.btnZeroWAS, "btnZeroWAS");
            this.btnZeroWAS.FlatAppearance.BorderSize = 0;
            this.btnZeroWAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZeroWAS.Image = global::AgOpenGPS.Properties.Resources.SteerZero;
            this.btnZeroWAS.Name = "btnZeroWAS";
            this.btnZeroWAS.UseVisualStyleBackColor = true;
            this.btnZeroWAS.Click += new System.EventHandler(this.btnZeroWAS_Click);
            this.btnZeroWAS.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnZeroWAS_HelpRequested);
            // 
            // hsbarCountsPerDegree
            // 
            resources.ApplyResources(this.hsbarCountsPerDegree, "hsbarCountsPerDegree");
            this.hsbarCountsPerDegree.LargeChange = 1;
            this.hsbarCountsPerDegree.Maximum = 255;
            this.hsbarCountsPerDegree.Minimum = 1;
            this.hsbarCountsPerDegree.Name = "hsbarCountsPerDegree";
            this.hsbarCountsPerDegree.Value = 20;
            this.hsbarCountsPerDegree.ValueChanged += new System.EventHandler(this.hsbarCountsPerDegree_ValueChanged);
            this.hsbarCountsPerDegree.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarCountsPerDegree_HelpRequested);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Name = "label10";
            // 
            // lblCountsPerDegree
            // 
            resources.ApplyResources(this.lblCountsPerDegree, "lblCountsPerDegree");
            this.lblCountsPerDegree.ForeColor = System.Drawing.Color.Black;
            this.lblCountsPerDegree.Name = "lblCountsPerDegree";
            // 
            // hsbarWasOffset
            // 
            resources.ApplyResources(this.hsbarWasOffset, "hsbarWasOffset");
            this.hsbarWasOffset.LargeChange = 20;
            this.hsbarWasOffset.Maximum = 4000;
            this.hsbarWasOffset.Minimum = -4000;
            this.hsbarWasOffset.Name = "hsbarWasOffset";
            this.hsbarWasOffset.SmallChange = 2;
            this.hsbarWasOffset.ValueChanged += new System.EventHandler(this.hsbarSteerAngleSensorZero_ValueChanged);
            this.hsbarWasOffset.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarWasOffset_HelpRequested);
            // 
            // lblSteerAngleSensorZero
            // 
            resources.ApplyResources(this.lblSteerAngleSensorZero, "lblSteerAngleSensorZero");
            this.lblSteerAngleSensorZero.ForeColor = System.Drawing.Color.Black;
            this.lblSteerAngleSensorZero.Name = "lblSteerAngleSensorZero";
            // 
            // tabGain
            // 
            resources.ApplyResources(this.tabGain, "tabGain");
            this.tabGain.BackColor = System.Drawing.Color.Gainsboro;
            this.tabGain.BackgroundImage = global::AgOpenGPS.Properties.Resources.Sf_GainTab;
            this.tabGain.Controls.Add(this.label6);
            this.tabGain.Controls.Add(this.label15);
            this.tabGain.Controls.Add(this.label4);
            this.tabGain.Controls.Add(this.label2);
            this.tabGain.Controls.Add(this.hsbarMinPWM);
            this.tabGain.Controls.Add(this.hsbarProportionalGain);
            this.tabGain.Controls.Add(this.lblProportionalGain);
            this.tabGain.Controls.Add(this.lblHighSteerPWM);
            this.tabGain.Controls.Add(this.lblMinPWM);
            this.tabGain.Controls.Add(this.hsbarHighSteerPWM);
            this.tabGain.Name = "tabGain";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Name = "label15";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // hsbarMinPWM
            // 
            resources.ApplyResources(this.hsbarMinPWM, "hsbarMinPWM");
            this.hsbarMinPWM.LargeChange = 1;
            this.hsbarMinPWM.Name = "hsbarMinPWM";
            this.hsbarMinPWM.Value = 10;
            this.hsbarMinPWM.ValueChanged += new System.EventHandler(this.hsbarMinPWM_ValueChanged);
            this.hsbarMinPWM.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarMinPWM_HelpRequested);
            // 
            // hsbarProportionalGain
            // 
            resources.ApplyResources(this.hsbarProportionalGain, "hsbarProportionalGain");
            this.hsbarProportionalGain.LargeChange = 1;
            this.hsbarProportionalGain.Maximum = 200;
            this.hsbarProportionalGain.Name = "hsbarProportionalGain";
            this.hsbarProportionalGain.Value = 4;
            this.hsbarProportionalGain.ValueChanged += new System.EventHandler(this.hsbarProportionalGain_ValueChanged);
            this.hsbarProportionalGain.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarProportionalGain_HelpRequested);
            // 
            // lblProportionalGain
            // 
            resources.ApplyResources(this.lblProportionalGain, "lblProportionalGain");
            this.lblProportionalGain.ForeColor = System.Drawing.Color.Black;
            this.lblProportionalGain.Name = "lblProportionalGain";
            // 
            // lblHighSteerPWM
            // 
            resources.ApplyResources(this.lblHighSteerPWM, "lblHighSteerPWM");
            this.lblHighSteerPWM.ForeColor = System.Drawing.Color.Black;
            this.lblHighSteerPWM.Name = "lblHighSteerPWM";
            // 
            // lblMinPWM
            // 
            resources.ApplyResources(this.lblMinPWM, "lblMinPWM");
            this.lblMinPWM.ForeColor = System.Drawing.Color.Black;
            this.lblMinPWM.Name = "lblMinPWM";
            // 
            // hsbarHighSteerPWM
            // 
            resources.ApplyResources(this.hsbarHighSteerPWM, "hsbarHighSteerPWM");
            this.hsbarHighSteerPWM.LargeChange = 2;
            this.hsbarHighSteerPWM.Maximum = 255;
            this.hsbarHighSteerPWM.Name = "hsbarHighSteerPWM";
            this.hsbarHighSteerPWM.Value = 50;
            this.hsbarHighSteerPWM.ValueChanged += new System.EventHandler(this.hsbarHighSteerPWM_ValueChanged);
            this.hsbarHighSteerPWM.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarHighSteerPWM_HelpRequested);
            // 
            // tabStan
            // 
            resources.ApplyResources(this.tabStan, "tabStan");
            this.tabStan.BackColor = System.Drawing.Color.Gainsboro;
            this.tabStan.BackgroundImage = global::AgOpenGPS.Properties.Resources.Sf_Stanley;
            this.tabStan.Controls.Add(this.lblIntegralPercent);
            this.tabStan.Controls.Add(this.hsbarIntegral);
            this.tabStan.Controls.Add(this.label27);
            this.tabStan.Controls.Add(this.label25);
            this.tabStan.Controls.Add(this.lblHeadingErrorGain);
            this.tabStan.Controls.Add(this.lblStanleyGain);
            this.tabStan.Controls.Add(this.label5);
            this.tabStan.Controls.Add(this.label3);
            this.tabStan.Controls.Add(this.hsbarStanleyGain);
            this.tabStan.Controls.Add(this.hsbarHeadingErrorGain);
            this.tabStan.Name = "tabStan";
            // 
            // lblIntegralPercent
            // 
            resources.ApplyResources(this.lblIntegralPercent, "lblIntegralPercent");
            this.lblIntegralPercent.ForeColor = System.Drawing.Color.Black;
            this.lblIntegralPercent.Name = "lblIntegralPercent";
            // 
            // hsbarIntegral
            // 
            resources.ApplyResources(this.hsbarIntegral, "hsbarIntegral");
            this.hsbarIntegral.LargeChange = 1;
            this.hsbarIntegral.Name = "hsbarIntegral";
            this.hsbarIntegral.Value = 5;
            this.hsbarIntegral.ValueChanged += new System.EventHandler(this.hsbarIntegral_ValueChanged);
            this.hsbarIntegral.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarIntegral_HelpRequested);
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Name = "label27";
            this.label27.UseCompatibleTextRendering = true;
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.ForeColor = System.Drawing.Color.Chocolate;
            this.label25.Name = "label25";
            // 
            // lblHeadingErrorGain
            // 
            resources.ApplyResources(this.lblHeadingErrorGain, "lblHeadingErrorGain");
            this.lblHeadingErrorGain.ForeColor = System.Drawing.Color.Black;
            this.lblHeadingErrorGain.Name = "lblHeadingErrorGain";
            // 
            // lblStanleyGain
            // 
            resources.ApplyResources(this.lblStanleyGain, "lblStanleyGain");
            this.lblStanleyGain.ForeColor = System.Drawing.Color.Black;
            this.lblStanleyGain.Name = "lblStanleyGain";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // hsbarStanleyGain
            // 
            resources.ApplyResources(this.hsbarStanleyGain, "hsbarStanleyGain");
            this.hsbarStanleyGain.LargeChange = 1;
            this.hsbarStanleyGain.Maximum = 40;
            this.hsbarStanleyGain.Minimum = 1;
            this.hsbarStanleyGain.Name = "hsbarStanleyGain";
            this.hsbarStanleyGain.Value = 10;
            this.hsbarStanleyGain.ValueChanged += new System.EventHandler(this.hsbarStanleyGain_ValueChanged);
            this.hsbarStanleyGain.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarStanleyGain_HelpRequested);
            // 
            // hsbarHeadingErrorGain
            // 
            resources.ApplyResources(this.hsbarHeadingErrorGain, "hsbarHeadingErrorGain");
            this.hsbarHeadingErrorGain.LargeChange = 1;
            this.hsbarHeadingErrorGain.Maximum = 15;
            this.hsbarHeadingErrorGain.Minimum = 1;
            this.hsbarHeadingErrorGain.Name = "hsbarHeadingErrorGain";
            this.hsbarHeadingErrorGain.Value = 10;
            this.hsbarHeadingErrorGain.ValueChanged += new System.EventHandler(this.hsbarHeadingErrorGain_ValueChanged);
            this.hsbarHeadingErrorGain.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarHeadingErrorGain_HelpRequested);
            // 
            // tabInt
            // 
            resources.ApplyResources(this.tabInt, "tabInt");
            this.tabInt.BackColor = System.Drawing.Color.Gainsboro;
            this.tabInt.BackgroundImage = global::AgOpenGPS.Properties.Resources.Sf_PP;
            this.tabInt.Controls.Add(this.label32);
            this.tabInt.Controls.Add(this.lblHoldLookAhead);
            this.tabInt.Controls.Add(this.hsbarHoldLookAhead);
            this.tabInt.Controls.Add(this.lblPureIntegral);
            this.tabInt.Controls.Add(this.hsbarIntegralPurePursuit);
            this.tabInt.Controls.Add(this.label26);
            this.tabInt.Controls.Add(this.label24);
            this.tabInt.Controls.Add(this.label21);
            this.tabInt.Controls.Add(this.label20);
            this.tabInt.Controls.Add(this.label19);
            this.tabInt.Controls.Add(this.label18);
            this.tabInt.Controls.Add(this.hsbarLookAheadMult);
            this.tabInt.Controls.Add(this.lblLookAhead);
            this.tabInt.Controls.Add(this.lblLookAheadMult);
            this.tabInt.Controls.Add(this.hsbarLookAhead);
            this.tabInt.ForeColor = System.Drawing.Color.Black;
            this.tabInt.Name = "tabInt";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Name = "label32";
            // 
            // lblHoldLookAhead
            // 
            resources.ApplyResources(this.lblHoldLookAhead, "lblHoldLookAhead");
            this.lblHoldLookAhead.ForeColor = System.Drawing.Color.Black;
            this.lblHoldLookAhead.Name = "lblHoldLookAhead";
            // 
            // hsbarHoldLookAhead
            // 
            resources.ApplyResources(this.hsbarHoldLookAhead, "hsbarHoldLookAhead");
            this.hsbarHoldLookAhead.LargeChange = 1;
            this.hsbarHoldLookAhead.Maximum = 50;
            this.hsbarHoldLookAhead.Minimum = 10;
            this.hsbarHoldLookAhead.Name = "hsbarHoldLookAhead";
            this.hsbarHoldLookAhead.Value = 25;
            this.hsbarHoldLookAhead.ValueChanged += new System.EventHandler(this.hsbarHoldLookAhead_ValueChanged);
            // 
            // lblPureIntegral
            // 
            resources.ApplyResources(this.lblPureIntegral, "lblPureIntegral");
            this.lblPureIntegral.ForeColor = System.Drawing.Color.Black;
            this.lblPureIntegral.Name = "lblPureIntegral";
            // 
            // hsbarIntegralPurePursuit
            // 
            resources.ApplyResources(this.hsbarIntegralPurePursuit, "hsbarIntegralPurePursuit");
            this.hsbarIntegralPurePursuit.LargeChange = 1;
            this.hsbarIntegralPurePursuit.Name = "hsbarIntegralPurePursuit";
            this.hsbarIntegralPurePursuit.Value = 5;
            this.hsbarIntegralPurePursuit.ValueChanged += new System.EventHandler(this.hsbarIntegralPurePursuit_ValueChanged);
            this.hsbarIntegralPurePursuit.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarIntegralPurePursuit_HelpRequested);
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.ForeColor = System.Drawing.Color.SteelBlue;
            this.label26.Name = "label26";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Name = "label24";
            this.label24.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Name = "label19";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Name = "label18";
            // 
            // hsbarLookAheadMult
            // 
            resources.ApplyResources(this.hsbarLookAheadMult, "hsbarLookAheadMult");
            this.hsbarLookAheadMult.LargeChange = 1;
            this.hsbarLookAheadMult.Maximum = 30;
            this.hsbarLookAheadMult.Minimum = 5;
            this.hsbarLookAheadMult.Name = "hsbarLookAheadMult";
            this.hsbarLookAheadMult.Value = 6;
            this.hsbarLookAheadMult.ValueChanged += new System.EventHandler(this.hsbarLookAheadMult_ValueChanged);
            this.hsbarLookAheadMult.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarLookAheadMult_HelpRequested);
            // 
            // lblLookAhead
            // 
            resources.ApplyResources(this.lblLookAhead, "lblLookAhead");
            this.lblLookAhead.ForeColor = System.Drawing.Color.Black;
            this.lblLookAhead.Name = "lblLookAhead";
            // 
            // lblLookAheadMult
            // 
            resources.ApplyResources(this.lblLookAheadMult, "lblLookAheadMult");
            this.lblLookAheadMult.ForeColor = System.Drawing.Color.Black;
            this.lblLookAheadMult.Name = "lblLookAheadMult";
            // 
            // hsbarLookAhead
            // 
            resources.ApplyResources(this.hsbarLookAhead, "hsbarLookAhead");
            this.hsbarLookAhead.LargeChange = 1;
            this.hsbarLookAhead.Maximum = 50;
            this.hsbarLookAhead.Minimum = 10;
            this.hsbarLookAhead.Name = "hsbarLookAhead";
            this.hsbarLookAhead.Value = 25;
            this.hsbarLookAhead.ValueChanged += new System.EventHandler(this.hsbarLookAhead_ValueChanged);
            this.hsbarLookAhead.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarLookAhead_HelpRequested);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ST_SteerTab.png");
            this.imageList1.Images.SetKeyName(1, "ST_GainTab.png");
            this.imageList1.Images.SetKeyName(2, "ST_StanleyTab.png");
            this.imageList1.Images.SetKeyName(3, "Sf_PPTab.png");
            this.imageList1.Images.SetKeyName(4, "Sf_XTE2.png");
            // 
            // lblSideHillComp
            // 
            resources.ApplyResources(this.lblSideHillComp, "lblSideHillComp");
            this.lblSideHillComp.ForeColor = System.Drawing.Color.Black;
            this.lblSideHillComp.Name = "lblSideHillComp";
            // 
            // hsbarSideHillComp
            // 
            resources.ApplyResources(this.hsbarSideHillComp, "hsbarSideHillComp");
            this.hsbarSideHillComp.LargeChange = 1;
            this.hsbarSideHillComp.Name = "hsbarSideHillComp";
            this.hsbarSideHillComp.Value = 5;
            this.hsbarSideHillComp.ValueChanged += new System.EventHandler(this.hsbarSideHillComp_ValueChanged);
            this.hsbarSideHillComp.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hsbarSideHillComp_HelpRequested);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Name = "label22";
            this.label22.UseCompatibleTextRendering = true;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Name = "label28";
            // 
            // labelPressureTurnSensor
            // 
            resources.ApplyResources(this.labelPressureTurnSensor, "labelPressureTurnSensor");
            this.labelPressureTurnSensor.ForeColor = System.Drawing.Color.Black;
            this.labelPressureTurnSensor.Name = "labelPressureTurnSensor";
            // 
            // labelCurrentTurnSensor
            // 
            resources.ApplyResources(this.labelCurrentTurnSensor, "labelCurrentTurnSensor");
            this.labelCurrentTurnSensor.ForeColor = System.Drawing.Color.Black;
            this.labelCurrentTurnSensor.Name = "labelCurrentTurnSensor";
            // 
            // labelEncoder
            // 
            resources.ApplyResources(this.labelEncoder, "labelEncoder");
            this.labelEncoder.ForeColor = System.Drawing.Color.Black;
            this.labelEncoder.Name = "labelEncoder";
            // 
            // label70
            // 
            resources.ApplyResources(this.label70, "label70");
            this.label70.ForeColor = System.Drawing.Color.Black;
            this.label70.Name = "label70";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Name = "label29";
            // 
            // label68
            // 
            resources.ApplyResources(this.label68, "label68");
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Name = "label68";
            // 
            // cboxMotorDrive
            // 
            resources.ApplyResources(this.cboxMotorDrive, "cboxMotorDrive");
            this.cboxMotorDrive.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxMotorDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMotorDrive.FormattingEnabled = true;
            this.cboxMotorDrive.Items.AddRange(new object[] {
            resources.GetString("cboxMotorDrive.Items"),
            resources.GetString("cboxMotorDrive.Items1")});
            this.cboxMotorDrive.Name = "cboxMotorDrive";
            this.cboxMotorDrive.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxMotorDrive.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxMotorDrive_HelpRequested);
            // 
            // cboxSteerEnable
            // 
            resources.ApplyResources(this.cboxSteerEnable, "cboxSteerEnable");
            this.cboxSteerEnable.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxSteerEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSteerEnable.FormattingEnabled = true;
            this.cboxSteerEnable.Items.AddRange(new object[] {
            resources.GetString("cboxSteerEnable.Items"),
            resources.GetString("cboxSteerEnable.Items1"),
            resources.GetString("cboxSteerEnable.Items2")});
            this.cboxSteerEnable.Name = "cboxSteerEnable";
            this.cboxSteerEnable.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxSteerEnable.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxSteerEnable_HelpRequested);
            // 
            // label62
            // 
            resources.ApplyResources(this.label62, "label62");
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Name = "label62";
            // 
            // cboxConv
            // 
            resources.ApplyResources(this.cboxConv, "cboxConv");
            this.cboxConv.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxConv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxConv.FormattingEnabled = true;
            this.cboxConv.Items.AddRange(new object[] {
            resources.GetString("cboxConv.Items"),
            resources.GetString("cboxConv.Items1")});
            this.cboxConv.Name = "cboxConv";
            this.cboxConv.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxConv.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxConv_HelpRequested);
            // 
            // label63
            // 
            resources.ApplyResources(this.label63, "label63");
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.ForeColor = System.Drawing.Color.Black;
            this.label63.Name = "label63";
            // 
            // label64
            // 
            resources.ApplyResources(this.label64, "label64");
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.ForeColor = System.Drawing.Color.Black;
            this.label64.Name = "label64";
            // 
            // label61
            // 
            resources.ApplyResources(this.label61, "label61");
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.ForeColor = System.Drawing.Color.Black;
            this.label61.Name = "label61";
            // 
            // nudMaxCounts
            // 
            resources.ApplyResources(this.nudMaxCounts, "nudMaxCounts");
            this.nudMaxCounts.BackColor = System.Drawing.Color.AliceBlue;
            this.nudMaxCounts.InterceptArrowKeys = false;
            this.nudMaxCounts.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMaxCounts.Name = "nudMaxCounts";
            this.nudMaxCounts.ReadOnly = true;
            this.nudMaxCounts.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMaxCounts.Click += new System.EventHandler(this.nudMaxCounts_Click);
            this.nudMaxCounts.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nudMaxCounts_HelpRequested);
            // 
            // label55
            // 
            resources.ApplyResources(this.label55, "label55");
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Name = "label55";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Name = "label30";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblSteerAngle);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblSteerAngleActual);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblPWMDisplay);
            this.panel1.Controls.Add(this.btnStartSA);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnFreeDriveZero);
            this.panel1.Controls.Add(this.btnSteerAngleUp);
            this.panel1.Controls.Add(this.btnFreeDrive);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSteerAngleDown);
            this.panel1.Controls.Add(this.lblCalcSteerAngleInner);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblDiameter);
            this.panel1.Name = "panel1";
            // 
            // btnStartSA
            // 
            resources.ApplyResources(this.btnStartSA, "btnStartSA");
            this.btnStartSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartSA.Image = global::AgOpenGPS.Properties.Resources.BoundaryRecord;
            this.btnStartSA.Name = "btnStartSA";
            this.btnStartSA.UseVisualStyleBackColor = true;
            this.btnStartSA.Click += new System.EventHandler(this.btnStartSA_Click);
            this.btnStartSA.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnStartSA_HelpRequested);
            // 
            // btnFreeDriveZero
            // 
            resources.ApplyResources(this.btnFreeDriveZero, "btnFreeDriveZero");
            this.btnFreeDriveZero.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFreeDriveZero.ForeColor = System.Drawing.Color.White;
            this.btnFreeDriveZero.Image = global::AgOpenGPS.Properties.Resources.SteerZeroSmall;
            this.btnFreeDriveZero.Name = "btnFreeDriveZero";
            this.btnFreeDriveZero.UseVisualStyleBackColor = true;
            this.btnFreeDriveZero.Click += new System.EventHandler(this.btnFreeDriveZero_Click);
            this.btnFreeDriveZero.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnFreeDriveZero_HelpRequested);
            // 
            // btnSteerAngleUp
            // 
            resources.ApplyResources(this.btnSteerAngleUp, "btnSteerAngleUp");
            this.btnSteerAngleUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSteerAngleUp.Image = global::AgOpenGPS.Properties.Resources.ArrowRight;
            this.btnSteerAngleUp.Name = "btnSteerAngleUp";
            this.btnSteerAngleUp.UseVisualStyleBackColor = true;
            this.btnSteerAngleUp.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSteerAngleUp_HelpRequested);
            this.btnSteerAngleUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleUp_MouseDown);
            // 
            // btnFreeDrive
            // 
            resources.ApplyResources(this.btnFreeDrive, "btnFreeDrive");
            this.btnFreeDrive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFreeDrive.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFreeDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFreeDrive.Image = global::AgOpenGPS.Properties.Resources.SteerDriveOff;
            this.btnFreeDrive.Name = "btnFreeDrive";
            this.btnFreeDrive.UseVisualStyleBackColor = false;
            this.btnFreeDrive.Click += new System.EventHandler(this.btnFreeDrive_Click);
            this.btnFreeDrive.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnFreeDrive_HelpRequested);
            // 
            // btnSteerAngleDown
            // 
            resources.ApplyResources(this.btnSteerAngleDown, "btnSteerAngleDown");
            this.btnSteerAngleDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSteerAngleDown.Image = global::AgOpenGPS.Properties.Resources.ArrowLeft;
            this.btnSteerAngleDown.Name = "btnSteerAngleDown";
            this.btnSteerAngleDown.UseVisualStyleBackColor = true;
            this.btnSteerAngleDown.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSteerAngleDown_HelpRequested);
            this.btnSteerAngleDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleDown_MouseDown);
            // 
            // hsbarSensor
            // 
            resources.ApplyResources(this.hsbarSensor, "hsbarSensor");
            this.hsbarSensor.LargeChange = 1;
            this.hsbarSensor.Maximum = 255;
            this.hsbarSensor.Name = "hsbarSensor";
            this.hsbarSensor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbarSensor_Scroll);
            // 
            // lblhsbarSensor
            // 
            resources.ApplyResources(this.lblhsbarSensor, "lblhsbarSensor");
            this.lblhsbarSensor.BackColor = System.Drawing.Color.Transparent;
            this.lblhsbarSensor.ForeColor = System.Drawing.Color.Black;
            this.lblhsbarSensor.Name = "lblhsbarSensor";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Name = "label16";
            // 
            // nudPanicStopSpeed
            // 
            resources.ApplyResources(this.nudPanicStopSpeed, "nudPanicStopSpeed");
            this.nudPanicStopSpeed.BackColor = System.Drawing.Color.AliceBlue;
            this.nudPanicStopSpeed.InterceptArrowKeys = false;
            this.nudPanicStopSpeed.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudPanicStopSpeed.Name = "nudPanicStopSpeed";
            this.nudPanicStopSpeed.ReadOnly = true;
            this.nudPanicStopSpeed.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudPanicStopSpeed.Click += new System.EventHandler(this.nudPanicStopSpeed_Click);
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Name = "label31";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Name = "label37";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.button2.Image = global::AgOpenGPS.Properties.Resources.Reset_Default;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnVehicleReset_Click);
            // 
            // cboxCurrentSensor
            // 
            resources.ApplyResources(this.cboxCurrentSensor, "cboxCurrentSensor");
            this.cboxCurrentSensor.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxCurrentSensor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxCurrentSensor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxCurrentSensor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxCurrentSensor.Image = global::AgOpenGPS.Properties.Resources.ConSt_TurnSensorCurrent;
            this.cboxCurrentSensor.Name = "cboxCurrentSensor";
            this.cboxCurrentSensor.UseVisualStyleBackColor = false;
            this.cboxCurrentSensor.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxCurrentSensor.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxCurrentSensor_HelpRequested);
            // 
            // cboxPressureSensor
            // 
            resources.ApplyResources(this.cboxPressureSensor, "cboxPressureSensor");
            this.cboxPressureSensor.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxPressureSensor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxPressureSensor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxPressureSensor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxPressureSensor.Image = global::AgOpenGPS.Properties.Resources.ConSt_TurnSensorPressure;
            this.cboxPressureSensor.Name = "cboxPressureSensor";
            this.cboxPressureSensor.UseVisualStyleBackColor = false;
            this.cboxPressureSensor.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxPressureSensor.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxPressureSensor_HelpRequested);
            // 
            // pboxSendSteer
            // 
            resources.ApplyResources(this.pboxSendSteer, "pboxSendSteer");
            this.pboxSendSteer.BackgroundImage = global::AgOpenGPS.Properties.Resources.ConSt_Mandatory1;
            this.pboxSendSteer.Name = "pboxSendSteer";
            this.pboxSendSteer.TabStop = false;
            this.pboxSendSteer.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.pboxSendSteer_HelpRequested);
            // 
            // cboxDanfoss
            // 
            resources.ApplyResources(this.cboxDanfoss, "cboxDanfoss");
            this.cboxDanfoss.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxDanfoss.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxDanfoss.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxDanfoss.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxDanfoss.Image = global::AgOpenGPS.Properties.Resources.ConSt_Danfoss;
            this.cboxDanfoss.Name = "cboxDanfoss";
            this.cboxDanfoss.UseVisualStyleBackColor = false;
            this.cboxDanfoss.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxDanfoss.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxDanfoss_HelpRequested);
            // 
            // chkSteerInvertRelays
            // 
            resources.ApplyResources(this.chkSteerInvertRelays, "chkSteerInvertRelays");
            this.chkSteerInvertRelays.BackColor = System.Drawing.Color.AliceBlue;
            this.chkSteerInvertRelays.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkSteerInvertRelays.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkSteerInvertRelays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSteerInvertRelays.Image = global::AgOpenGPS.Properties.Resources.ConSt_InvertRelay;
            this.chkSteerInvertRelays.Name = "chkSteerInvertRelays";
            this.chkSteerInvertRelays.UseVisualStyleBackColor = false;
            this.chkSteerInvertRelays.Click += new System.EventHandler(this.EnableAlert_Click);
            this.chkSteerInvertRelays.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.chkSteerInvertRelays_HelpRequested);
            // 
            // chkInvertSteer
            // 
            resources.ApplyResources(this.chkInvertSteer, "chkInvertSteer");
            this.chkInvertSteer.BackColor = System.Drawing.Color.AliceBlue;
            this.chkInvertSteer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkInvertSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkInvertSteer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkInvertSteer.Image = global::AgOpenGPS.Properties.Resources.ConSt_InvertDirection;
            this.chkInvertSteer.Name = "chkInvertSteer";
            this.chkInvertSteer.UseVisualStyleBackColor = false;
            this.chkInvertSteer.Click += new System.EventHandler(this.EnableAlert_Click);
            this.chkInvertSteer.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.chkInvertSteer_HelpRequested);
            // 
            // cboxEncoder
            // 
            resources.ApplyResources(this.cboxEncoder, "cboxEncoder");
            this.cboxEncoder.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxEncoder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxEncoder.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxEncoder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxEncoder.Image = global::AgOpenGPS.Properties.Resources.ConSt_TurnSensor;
            this.cboxEncoder.Name = "cboxEncoder";
            this.cboxEncoder.UseVisualStyleBackColor = false;
            this.cboxEncoder.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxEncoder.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxEncoder_HelpRequested);
            // 
            // chkInvertWAS
            // 
            resources.ApplyResources(this.chkInvertWAS, "chkInvertWAS");
            this.chkInvertWAS.BackColor = System.Drawing.Color.AliceBlue;
            this.chkInvertWAS.Checked = true;
            this.chkInvertWAS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInvertWAS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkInvertWAS.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkInvertWAS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkInvertWAS.Image = global::AgOpenGPS.Properties.Resources.ConSt_InvertWAS;
            this.chkInvertWAS.Name = "chkInvertWAS";
            this.chkInvertWAS.UseVisualStyleBackColor = false;
            this.chkInvertWAS.Click += new System.EventHandler(this.EnableAlert_Click);
            this.chkInvertWAS.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.chkInvertWAS_HelpRequested);
            // 
            // btnSendSteerConfigPGN
            // 
            resources.ApplyResources(this.btnSendSteerConfigPGN, "btnSendSteerConfigPGN");
            this.btnSendSteerConfigPGN.BackColor = System.Drawing.Color.Transparent;
            this.btnSendSteerConfigPGN.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSendSteerConfigPGN.Image = global::AgOpenGPS.Properties.Resources.ToolAcceptChange;
            this.btnSendSteerConfigPGN.Name = "btnSendSteerConfigPGN";
            this.btnSendSteerConfigPGN.UseVisualStyleBackColor = false;
            this.btnSendSteerConfigPGN.Click += new System.EventHandler(this.btnSendSteerConfigPGN_Click);
            this.btnSendSteerConfigPGN.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.pboxSendSteer_HelpRequested);
            // 
            // cboxXY
            // 
            resources.ApplyResources(this.cboxXY, "cboxXY");
            this.cboxXY.BackColor = System.Drawing.Color.AliceBlue;
            this.cboxXY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxXY.FormattingEnabled = true;
            this.cboxXY.Items.AddRange(new object[] {
            resources.GetString("cboxXY.Items"),
            resources.GetString("cboxXY.Items1")});
            this.cboxXY.Name = "cboxXY";
            this.cboxXY.Click += new System.EventHandler(this.EnableAlert_Click);
            this.cboxXY.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxXY_HelpRequested);
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Name = "label33";
            // 
            // FormSteer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cboxXY);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.lblSideHillComp);
            this.Controls.Add(this.hsbarSideHillComp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.nudPanicStopSpeed);
            this.Controls.Add(this.lblhsbarSensor);
            this.Controls.Add(this.hsbarSensor);
            this.Controls.Add(this.lblPercentFS);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.pbarSensor);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.labelPressureTurnSensor);
            this.Controls.Add(this.labelCurrentTurnSensor);
            this.Controls.Add(this.labelEncoder);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.cboxMotorDrive);
            this.Controls.Add(this.cboxSteerEnable);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.cboxConv);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.nudMaxCounts);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.cboxCurrentSensor);
            this.Controls.Add(this.cboxPressureSensor);
            this.Controls.Add(this.pboxSendSteer);
            this.Controls.Add(this.cboxDanfoss);
            this.Controls.Add(this.chkSteerInvertRelays);
            this.Controls.Add(this.chkInvertSteer);
            this.Controls.Add(this.cboxEncoder);
            this.Controls.Add(this.chkInvertWAS);
            this.Controls.Add(this.btnSendSteerConfigPGN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSteer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSteer_FormClosing);
            this.Load += new System.EventHandler(this.FormSteer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSteer.ResumeLayout(false);
            this.tabSteer.PerformLayout();
            this.tabGain.ResumeLayout(false);
            this.tabGain.PerformLayout();
            this.tabStan.ResumeLayout(false);
            this.tabInt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCounts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanicStopSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendSteer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.Label lblHighSteerPWM;
        private System.Windows.Forms.HScrollBar hsbarHighSteerPWM;
        private System.Windows.Forms.Label lblProportionalGain;
        private System.Windows.Forms.HScrollBar hsbarProportionalGain;
        private System.Windows.Forms.Label lblLookAhead;
        private System.Windows.Forms.HScrollBar hsbarLookAhead;
        private System.Windows.Forms.Label lblMinPWM;
        private System.Windows.Forms.HScrollBar hsbarMinPWM;
        private System.Windows.Forms.Label lblMaxSteerAngle;
        private System.Windows.Forms.HScrollBar hsbarMaxSteerAngle;
        private System.Windows.Forms.HScrollBar hsbarLookAheadMult;
        private System.Windows.Forms.Label lblLookAheadMult;
        private System.Windows.Forms.HScrollBar hsbarHeadingErrorGain;
        private System.Windows.Forms.Label lblStanleyGain;
        private System.Windows.Forms.HScrollBar hsbarStanleyGain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeadingErrorGain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Label lblSteerAngleActual;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFreeDriveZero;
        private ProXoft.WinForms.RepeatButton btnSteerAngleDown;
        private ProXoft.WinForms.RepeatButton btnSteerAngleUp;
        private System.Windows.Forms.Label lblPWMDisplay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGain;
        private System.Windows.Forms.TabPage tabStan;
        private System.Windows.Forms.TabPage tabInt;
        private System.Windows.Forms.Button btnStartSA;
        private System.Windows.Forms.Label lblCalcSteerAngleInner;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabSteer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar hsbarAckerman;
        private System.Windows.Forms.Label lblAckerman;
        private System.Windows.Forms.ProgressBar pbarRight;
        private System.Windows.Forms.ProgressBar pbarLeft;
        private System.Windows.Forms.Label lblActualSteerAngleUpper;
        private System.Windows.Forms.Button btnZeroWAS;
        private System.Windows.Forms.HScrollBar hsbarCountsPerDegree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCountsPerDegree;
        private System.Windows.Forms.HScrollBar hsbarWasOffset;
        private System.Windows.Forms.Label lblSteerAngleSensorZero;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.HScrollBar hsbarIntegral;
        private System.Windows.Forms.HScrollBar hsbarIntegralPurePursuit;
        private System.Windows.Forms.Label lblIntegralPercent;
        private System.Windows.Forms.Label lblPureIntegral;
        private System.Windows.Forms.Label lblSideHillComp;
        private System.Windows.Forms.HScrollBar hsbarSideHillComp;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ProgressBar pbarSensor;
        private System.Windows.Forms.Label lblPercentFS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelPressureTurnSensor;
        private System.Windows.Forms.Label labelCurrentTurnSensor;
        private System.Windows.Forms.Label labelEncoder;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.ComboBox cboxMotorDrive;
        private System.Windows.Forms.ComboBox cboxSteerEnable;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox cboxConv;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown nudMaxCounts;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.CheckBox cboxCurrentSensor;
        private System.Windows.Forms.CheckBox cboxPressureSensor;
        private System.Windows.Forms.PictureBox pboxSendSteer;
        private System.Windows.Forms.CheckBox cboxDanfoss;
        private System.Windows.Forms.CheckBox chkSteerInvertRelays;
        private System.Windows.Forms.CheckBox chkInvertSteer;
        private System.Windows.Forms.CheckBox cboxEncoder;
        private System.Windows.Forms.CheckBox chkInvertWAS;
        private System.Windows.Forms.Button btnSendSteerConfigPGN;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hsbarSensor;
        private System.Windows.Forms.Label lblhsbarSensor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudPanicStopSpeed;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblHoldLookAhead;
        private System.Windows.Forms.HScrollBar hsbarHoldLookAhead;
        private System.Windows.Forms.ComboBox cboxXY;
        private System.Windows.Forms.Label label33;
    }
}