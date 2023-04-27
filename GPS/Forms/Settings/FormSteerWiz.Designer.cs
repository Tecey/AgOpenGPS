namespace AgOpenGPS
{
    partial class FormSteerWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSteerWiz));
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
            this.hsbarLowSteerPWM = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLowSteerPWM = new System.Windows.Forms.Label();
            this.tabGain = new System.Windows.Forms.TabPage();
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
            this.lblSideHillComp = new System.Windows.Forms.Label();
            this.hsbarSideHillComp = new System.Windows.Forms.HScrollBar();
            this.label22 = new System.Windows.Forms.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hsbarMinPWM = new System.Windows.Forms.HScrollBar();
            this.hsbarProportionalGain = new System.Windows.Forms.HScrollBar();
            this.lblProportionalGain = new System.Windows.Forms.Label();
            this.lblHighSteerPWM = new System.Windows.Forms.Label();
            this.lblMinPWM = new System.Windows.Forms.Label();
            this.hsbarHighSteerPWM = new System.Windows.Forms.HScrollBar();
            this.lblMaxSteerAngle = new System.Windows.Forms.Label();
            this.hsbarMaxSteerAngle = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.hsbarCountsPerDegree = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCountsPerDegree = new System.Windows.Forms.Label();
            this.hsbarWasOffset = new System.Windows.Forms.HScrollBar();
            this.lblSteerAngleSensorZero = new System.Windows.Forms.Label();
            this.pbarRight = new System.Windows.Forms.ProgressBar();
            this.pbarLeft = new System.Windows.Forms.ProgressBar();
            this.label28 = new System.Windows.Forms.Label();
            this.labelPressureTurnSensor = new System.Windows.Forms.Label();
            this.labelCurrentTurnSensor = new System.Windows.Forms.Label();
            this.labelEncoder = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
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
            this.btnSteerStatus = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label38 = new System.Windows.Forms.Label();
            this.btnFreeDriveZero = new System.Windows.Forms.Button();
            this.btnSteerAngleUp = new ProXoft.WinForms.RepeatButton();
            this.btnFreeDrive = new System.Windows.Forms.Button();
            this.btnSteerAngleDown = new ProXoft.WinForms.RepeatButton();
            this.hsbarSensor = new System.Windows.Forms.HScrollBar();
            this.lblhsbarSensor = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudPanicStopSpeed = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.tabWiz = new System.Windows.Forms.TabControl();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.btnStartWizard = new System.Windows.Forms.Button();
            this.tabLoadDef = new System.Windows.Forms.TabPage();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.btnOkNext_LoadDefault = new System.Windows.Forms.Button();
            this.btnLoadDefaults = new System.Windows.Forms.Button();
            this.tabWheelBase = new System.Windows.Forms.TabPage();
            this.label89 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label90 = new System.Windows.Forms.Label();
            this.nudWheelbase = new System.Windows.Forms.NumericUpDown();
            this.label91 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabWheelTrack = new System.Windows.Forms.TabPage();
            this.label96 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label94 = new System.Windows.Forms.Label();
            this.nudVehicleTrack = new System.Windows.Forms.NumericUpDown();
            this.label95 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.tabAntennaDistance = new System.Windows.Forms.TabPage();
            this.label100 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label98 = new System.Windows.Forms.Label();
            this.nudAntennaPivot = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.label99 = new System.Windows.Forms.Label();
            this.tabAntennaHeight = new System.Windows.Forms.TabPage();
            this.label114 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label92 = new System.Windows.Forms.Label();
            this.nudAntennaHeight = new System.Windows.Forms.NumericUpDown();
            this.label93 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.tabAntennaOffset = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.label102 = new System.Windows.Forms.Label();
            this.nudAntennaOffset = new System.Windows.Forms.NumericUpDown();
            this.label104 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label103 = new System.Windows.Forms.Label();
            this.tabButtonSwitch = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.btnOkNext_ButtonSwitch = new System.Windows.Forms.Button();
            this.tabA2DConv = new System.Windows.Forms.TabPage();
            this.btnPrev_A2D = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.btnOkNext_A2D = new System.Windows.Forms.Button();
            this.tabMotorDriver = new System.Windows.Forms.TabPage();
            this.btnPrev_MotorDriver = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.btnOkNext_MotorDriver = new System.Windows.Forms.Button();
            this.tabInvertRelays = new System.Windows.Forms.TabPage();
            this.label59 = new System.Windows.Forms.Label();
            this.btnPrev_InvertRelays = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.btnOkNext_InvertRelays = new System.Windows.Forms.Button();
            this.chkSteerInvertRelays = new System.Windows.Forms.CheckBox();
            this.tabDanfoss = new System.Windows.Forms.TabPage();
            this.btnPrev_Danfoss = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.btnOkNext_Danfoss = new System.Windows.Forms.Button();
            this.cboxDanfoss = new System.Windows.Forms.CheckBox();
            this.tabRollInv = new System.Windows.Forms.TabPage();
            this.label115 = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cboxDataInvertRoll = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.label107 = new System.Windows.Forms.Label();
            this.tabRollZero = new System.Windows.Forms.TabPage();
            this.lblRoll2 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.lblRollZeroOffset = new System.Windows.Forms.Label();
            this.btnZeroRoll = new System.Windows.Forms.Button();
            this.btnRemoveZeroOffset = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.tabWAS = new System.Windows.Forms.TabPage();
            this.label45 = new System.Windows.Forms.Label();
            this.btnPrev_InvertWAS = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.btnOkWAS = new System.Windows.Forms.Button();
            this.chkInvertWAS = new System.Windows.Forms.CheckBox();
            this.tabWAS_Zero = new System.Windows.Forms.TabPage();
            this.label112 = new System.Windows.Forms.Label();
            this.lblCurrentHeading = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRemoveWasOffset = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.btnOkNext_WAS_Zero = new System.Windows.Forms.Button();
            this.btnZeroWAS = new System.Windows.Forms.Button();
            this.tabMotorDirection = new System.Windows.Forms.TabPage();
            this.label58 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnPrev_MotorDirection = new System.Windows.Forms.Button();
            this.btnOkNext_MotorDirection = new System.Windows.Forms.Button();
            this.btnSteerLeft = new System.Windows.Forms.Button();
            this.btnSteerRight = new System.Windows.Forms.Button();
            this.chkInvertSteer = new System.Windows.Forms.CheckBox();
            this.tabCPD_Setup = new System.Windows.Forms.TabPage();
            this.label60 = new System.Windows.Forms.Label();
            this.btnPrev_CountsPerDegree = new System.Windows.Forms.Button();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.btnSkipCPD_Setup = new System.Windows.Forms.Button();
            this.btnOKNext_CPDSetup = new System.Windows.Forms.Button();
            this.tabCountsPerDeg = new System.Windows.Forms.TabPage();
            this.label109 = new System.Windows.Forms.Label();
            this.lblRightStartAngle = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCPDError = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btnOkNext_CountsPerDeg = new System.Windows.Forms.Button();
            this.btnStartSA = new System.Windows.Forms.Button();
            this.tabAckCPD = new System.Windows.Forms.TabPage();
            this.btnAckReset = new System.Windows.Forms.Button();
            this.label101 = new System.Windows.Forms.Label();
            this.lblStartAngleLeft = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.hsbarAckerman = new System.Windows.Forms.HScrollBar();
            this.lblAckerman = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.lblAckermannError = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.lblDiameterLeft = new System.Windows.Forms.Label();
            this.lblCalcSteerAngleLeft = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.btnStartSA_Left = new System.Windows.Forms.Button();
            this.tabMaxSteerAngle = new System.Windows.Forms.TabPage();
            this.label113 = new System.Windows.Forms.Label();
            this.btnOkSetMaximumSteerAngle = new System.Windows.Forms.Button();
            this.label73 = new System.Windows.Forms.Label();
            this.btnPrev_MaxSteerAngle = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnOkNextMaxSteerAngle = new System.Windows.Forms.Button();
            this.tabCancelGuidance = new System.Windows.Forms.TabPage();
            this.btnPrev_CancelGuidance = new System.Windows.Forms.Button();
            this.btnOkNextCancelGuidance = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.cboxPressureSensor = new System.Windows.Forms.CheckBox();
            this.cboxEncoder = new System.Windows.Forms.CheckBox();
            this.cboxCurrentSensor = new System.Windows.Forms.CheckBox();
            this.tabPanicStop = new System.Windows.Forms.TabPage();
            this.label82 = new System.Windows.Forms.Label();
            this.btnPrev_Panic = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.btnOkNext_PanicStop = new System.Windows.Forms.Button();
            this.tab_MinimumGain = new System.Windows.Forms.TabPage();
            this.label72 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.btnMinGainLeft = new System.Windows.Forms.Button();
            this.btnZeroMinMovementSetting = new System.Windows.Forms.Button();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.btnMinGainRight = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.btnPrev_Gain = new System.Windows.Forms.Button();
            this.btnOK_Next = new System.Windows.Forms.Button();
            this.tabPGain = new System.Windows.Forms.TabPage();
            this.label88 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.btnLeftPGain = new System.Windows.Forms.Button();
            this.btnZeroPGain = new System.Windows.Forms.Button();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.btnRightPGain = new System.Windows.Forms.Button();
            this.label87 = new System.Windows.Forms.Label();
            this.btnPrev_PGain = new System.Windows.Forms.Button();
            this.btnNext_PGain = new System.Windows.Forms.Button();
            this.tabEnd = new System.Windows.Forms.TabPage();
            this.label116 = new System.Windows.Forms.Label();
            this.btnRestartWizard = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.btnPrev_End = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStopWizard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.label71 = new System.Windows.Forms.Label();
            this.lblBarCPD = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.lblBarAck = new System.Windows.Forms.Label();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.label67 = new System.Windows.Forms.Label();
            this.lblBarWasOffset = new System.Windows.Forms.Label();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSteer.SuspendLayout();
            this.tabStan.SuspendLayout();
            this.tabInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCounts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanicStopSpeed)).BeginInit();
            this.tabWiz.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.tabLoadDef.SuspendLayout();
            this.tabWheelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelbase)).BeginInit();
            this.tabWheelTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleTrack)).BeginInit();
            this.tabAntennaDistance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaPivot)).BeginInit();
            this.tabAntennaHeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaHeight)).BeginInit();
            this.tabAntennaOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaOffset)).BeginInit();
            this.tabButtonSwitch.SuspendLayout();
            this.tabA2DConv.SuspendLayout();
            this.tabMotorDriver.SuspendLayout();
            this.tabInvertRelays.SuspendLayout();
            this.tabDanfoss.SuspendLayout();
            this.tabRollInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tabRollZero.SuspendLayout();
            this.tabWAS.SuspendLayout();
            this.tabWAS_Zero.SuspendLayout();
            this.tabMotorDirection.SuspendLayout();
            this.tabCPD_Setup.SuspendLayout();
            this.tabCountsPerDeg.SuspendLayout();
            this.tabAckCPD.SuspendLayout();
            this.tabMaxSteerAngle.SuspendLayout();
            this.tabCancelGuidance.SuspendLayout();
            this.tabPanicStop.SuspendLayout();
            this.tab_MinimumGain.SuspendLayout();
            this.tabPGain.SuspendLayout();
            this.tabEnd.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // 
            // lblSteerAngleActual
            // 
            resources.ApplyResources(this.lblSteerAngleActual, "lblSteerAngleActual");
            this.lblSteerAngleActual.BackColor = System.Drawing.Color.Transparent;
            this.lblSteerAngleActual.ForeColor = System.Drawing.Color.Black;
            this.lblSteerAngleActual.Name = "lblSteerAngleActual";
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Name = "lblError";
            // 
            // lblPWMDisplay
            // 
            resources.ApplyResources(this.lblPWMDisplay, "lblPWMDisplay");
            this.lblPWMDisplay.BackColor = System.Drawing.Color.White;
            this.lblPWMDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPWMDisplay.Name = "lblPWMDisplay";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Name = "label13";
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
            this.tabSteer.Controls.Add(this.hsbarLowSteerPWM);
            this.tabSteer.Controls.Add(this.label6);
            this.tabSteer.Controls.Add(this.lblLowSteerPWM);
            this.tabSteer.Name = "tabSteer";
            // 
            // hsbarLowSteerPWM
            // 
            resources.ApplyResources(this.hsbarLowSteerPWM, "hsbarLowSteerPWM");
            this.hsbarLowSteerPWM.LargeChange = 1;
            this.hsbarLowSteerPWM.Maximum = 255;
            this.hsbarLowSteerPWM.Name = "hsbarLowSteerPWM";
            this.hsbarLowSteerPWM.Value = 1;
            this.hsbarLowSteerPWM.ValueChanged += new System.EventHandler(this.hsbarLowSteerPWM_ValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // lblLowSteerPWM
            // 
            resources.ApplyResources(this.lblLowSteerPWM, "lblLowSteerPWM");
            this.lblLowSteerPWM.ForeColor = System.Drawing.Color.Black;
            this.lblLowSteerPWM.Name = "lblLowSteerPWM";
            // 
            // tabGain
            // 
            resources.ApplyResources(this.tabGain, "tabGain");
            this.tabGain.BackColor = System.Drawing.Color.Gainsboro;
            this.tabGain.BackgroundImage = global::AgOpenGPS.Properties.Resources.Sf_GainTab;
            this.tabGain.Name = "tabGain";
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
            this.label25.ForeColor = System.Drawing.Color.SandyBrown;
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
            // 
            // tabInt
            // 
            resources.ApplyResources(this.tabInt, "tabInt");
            this.tabInt.BackColor = System.Drawing.Color.Gainsboro;
            this.tabInt.BackgroundImage = global::AgOpenGPS.Properties.Resources.Sf_PP;
            this.tabInt.Controls.Add(this.lblSideHillComp);
            this.tabInt.Controls.Add(this.hsbarSideHillComp);
            this.tabInt.Controls.Add(this.label22);
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
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Name = "label22";
            this.label22.UseCompatibleTextRendering = true;
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
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ST_SteerTab.png");
            this.imageList1.Images.SetKeyName(1, "ST_GainTab.png");
            this.imageList1.Images.SetKeyName(2, "ST_StanleyTab.png");
            this.imageList1.Images.SetKeyName(3, "Sf_PPTab.png");
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
            // 
            // hsbarProportionalGain
            // 
            resources.ApplyResources(this.hsbarProportionalGain, "hsbarProportionalGain");
            this.hsbarProportionalGain.LargeChange = 1;
            this.hsbarProportionalGain.Maximum = 200;
            this.hsbarProportionalGain.Name = "hsbarProportionalGain";
            this.hsbarProportionalGain.Value = 4;
            this.hsbarProportionalGain.ValueChanged += new System.EventHandler(this.hsbarProportionalGain_ValueChanged);
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
            // 
            // lblMaxSteerAngle
            // 
            resources.ApplyResources(this.lblMaxSteerAngle, "lblMaxSteerAngle");
            this.lblMaxSteerAngle.ForeColor = System.Drawing.Color.Black;
            this.lblMaxSteerAngle.Name = "lblMaxSteerAngle";
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
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
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
            // 
            // lblSteerAngleSensorZero
            // 
            resources.ApplyResources(this.lblSteerAngleSensorZero, "lblSteerAngleSensorZero");
            this.lblSteerAngleSensorZero.ForeColor = System.Drawing.Color.Black;
            this.lblSteerAngleSensorZero.Name = "lblSteerAngleSensorZero";
            // 
            // pbarRight
            // 
            resources.ApplyResources(this.pbarRight, "pbarRight");
            this.pbarRight.Name = "pbarRight";
            // 
            // pbarLeft
            // 
            resources.ApplyResources(this.pbarLeft, "pbarLeft");
            this.pbarLeft.Name = "pbarLeft";
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
            this.cboxMotorDrive.SelectedIndexChanged += new System.EventHandler(this.cboxMotorDrive_SelectedIndexChanged);
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
            this.cboxSteerEnable.SelectedIndexChanged += new System.EventHandler(this.cboxSteerEnable_SelectedIndexChanged);
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
            this.cboxConv.SelectedIndexChanged += new System.EventHandler(this.cboxConv_SelectedIndexChanged);
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
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSteerStatus);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblSteerAngle);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblPWMDisplay);
            this.panel2.Controls.Add(this.lblSteerAngleActual);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pbarLeft);
            this.panel2.Controls.Add(this.pbarRight);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Name = "panel2";
            // 
            // btnSteerStatus
            // 
            resources.ApplyResources(this.btnSteerStatus, "btnSteerStatus");
            this.btnSteerStatus.BackColor = System.Drawing.Color.White;
            this.btnSteerStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnSteerStatus.FlatAppearance.BorderSize = 0;
            this.btnSteerStatus.Image = global::AgOpenGPS.Properties.Resources.WizSteerDot;
            this.btnSteerStatus.Name = "btnSteerStatus";
            this.btnSteerStatus.UseVisualStyleBackColor = false;
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label35.Name = "label35";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label34.Name = "label34";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.btnFreeDriveZero);
            this.panel1.Controls.Add(this.btnSteerAngleUp);
            this.panel1.Controls.Add(this.btnFreeDrive);
            this.panel1.Controls.Add(this.btnSteerAngleDown);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Name = "panel1";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label38.Name = "label38";
            // 
            // btnFreeDriveZero
            // 
            resources.ApplyResources(this.btnFreeDriveZero, "btnFreeDriveZero");
            this.btnFreeDriveZero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFreeDriveZero.FlatAppearance.BorderSize = 0;
            this.btnFreeDriveZero.ForeColor = System.Drawing.Color.White;
            this.btnFreeDriveZero.Image = global::AgOpenGPS.Properties.Resources.SteerZeroSmall;
            this.btnFreeDriveZero.Name = "btnFreeDriveZero";
            this.btnFreeDriveZero.UseVisualStyleBackColor = true;
            this.btnFreeDriveZero.Click += new System.EventHandler(this.btnFreeDriveZero_Click);
            // 
            // btnSteerAngleUp
            // 
            resources.ApplyResources(this.btnSteerAngleUp, "btnSteerAngleUp");
            this.btnSteerAngleUp.FlatAppearance.BorderSize = 0;
            this.btnSteerAngleUp.Image = global::AgOpenGPS.Properties.Resources.SteerRight;
            this.btnSteerAngleUp.Name = "btnSteerAngleUp";
            this.btnSteerAngleUp.UseVisualStyleBackColor = true;
            this.btnSteerAngleUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleUp_MouseDown);
            // 
            // btnFreeDrive
            // 
            resources.ApplyResources(this.btnFreeDrive, "btnFreeDrive");
            this.btnFreeDrive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFreeDrive.FlatAppearance.BorderSize = 0;
            this.btnFreeDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFreeDrive.Image = global::AgOpenGPS.Properties.Resources.SteerDriveOff;
            this.btnFreeDrive.Name = "btnFreeDrive";
            this.btnFreeDrive.UseVisualStyleBackColor = false;
            this.btnFreeDrive.Click += new System.EventHandler(this.btnFreeDrive_Click);
            // 
            // btnSteerAngleDown
            // 
            resources.ApplyResources(this.btnSteerAngleDown, "btnSteerAngleDown");
            this.btnSteerAngleDown.FlatAppearance.BorderSize = 0;
            this.btnSteerAngleDown.Image = global::AgOpenGPS.Properties.Resources.SteerLeft;
            this.btnSteerAngleDown.Name = "btnSteerAngleDown";
            this.btnSteerAngleDown.UseVisualStyleBackColor = true;
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
            // tabWiz
            // 
            resources.ApplyResources(this.tabWiz, "tabWiz");
            this.tabWiz.Controls.Add(this.tabStart);
            this.tabWiz.Controls.Add(this.tabLoadDef);
            this.tabWiz.Controls.Add(this.tabWheelBase);
            this.tabWiz.Controls.Add(this.tabWheelTrack);
            this.tabWiz.Controls.Add(this.tabAntennaDistance);
            this.tabWiz.Controls.Add(this.tabAntennaHeight);
            this.tabWiz.Controls.Add(this.tabAntennaOffset);
            this.tabWiz.Controls.Add(this.tabButtonSwitch);
            this.tabWiz.Controls.Add(this.tabA2DConv);
            this.tabWiz.Controls.Add(this.tabMotorDriver);
            this.tabWiz.Controls.Add(this.tabInvertRelays);
            this.tabWiz.Controls.Add(this.tabDanfoss);
            this.tabWiz.Controls.Add(this.tabRollInv);
            this.tabWiz.Controls.Add(this.tabRollZero);
            this.tabWiz.Controls.Add(this.tabWAS);
            this.tabWiz.Controls.Add(this.tabWAS_Zero);
            this.tabWiz.Controls.Add(this.tabMotorDirection);
            this.tabWiz.Controls.Add(this.tabCPD_Setup);
            this.tabWiz.Controls.Add(this.tabCountsPerDeg);
            this.tabWiz.Controls.Add(this.tabAckCPD);
            this.tabWiz.Controls.Add(this.tabMaxSteerAngle);
            this.tabWiz.Controls.Add(this.tabCancelGuidance);
            this.tabWiz.Controls.Add(this.tabPanicStop);
            this.tabWiz.Controls.Add(this.tab_MinimumGain);
            this.tabWiz.Controls.Add(this.tabPGain);
            this.tabWiz.Controls.Add(this.tabEnd);
            this.tabWiz.Name = "tabWiz";
            this.tabWiz.SelectedIndex = 0;
            // 
            // tabStart
            // 
            resources.ApplyResources(this.tabStart, "tabStart");
            this.tabStart.BackColor = System.Drawing.Color.White;
            this.tabStart.Controls.Add(this.btnStartWizard);
            this.tabStart.Name = "tabStart";
            // 
            // btnStartWizard
            // 
            resources.ApplyResources(this.btnStartWizard, "btnStartWizard");
            this.btnStartWizard.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStartWizard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnStartWizard.FlatAppearance.BorderSize = 2;
            this.btnStartWizard.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnStartWizard.Name = "btnStartWizard";
            this.btnStartWizard.UseVisualStyleBackColor = false;
            this.btnStartWizard.Click += new System.EventHandler(this.btnStartWizard_Click);
            // 
            // tabLoadDef
            // 
            resources.ApplyResources(this.tabLoadDef, "tabLoadDef");
            this.tabLoadDef.BackColor = System.Drawing.Color.White;
            this.tabLoadDef.Controls.Add(this.label81);
            this.tabLoadDef.Controls.Add(this.label80);
            this.tabLoadDef.Controls.Add(this.btnOkNext_LoadDefault);
            this.tabLoadDef.Controls.Add(this.btnLoadDefaults);
            this.tabLoadDef.Name = "tabLoadDef";
            // 
            // label81
            // 
            resources.ApplyResources(this.label81, "label81");
            this.label81.BackColor = System.Drawing.Color.Transparent;
            this.label81.ForeColor = System.Drawing.Color.Black;
            this.label81.Name = "label81";
            // 
            // label80
            // 
            resources.ApplyResources(this.label80, "label80");
            this.label80.ForeColor = System.Drawing.Color.Black;
            this.label80.Name = "label80";
            // 
            // btnOkNext_LoadDefault
            // 
            resources.ApplyResources(this.btnOkNext_LoadDefault, "btnOkNext_LoadDefault");
            this.btnOkNext_LoadDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_LoadDefault.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_LoadDefault.FlatAppearance.BorderSize = 0;
            this.btnOkNext_LoadDefault.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_LoadDefault.Name = "btnOkNext_LoadDefault";
            this.btnOkNext_LoadDefault.UseVisualStyleBackColor = false;
            this.btnOkNext_LoadDefault.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // btnLoadDefaults
            // 
            resources.ApplyResources(this.btnLoadDefaults, "btnLoadDefaults");
            this.btnLoadDefaults.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLoadDefaults.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadDefaults.FlatAppearance.BorderSize = 2;
            this.btnLoadDefaults.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnLoadDefaults.Name = "btnLoadDefaults";
            this.btnLoadDefaults.UseVisualStyleBackColor = false;
            this.btnLoadDefaults.Click += new System.EventHandler(this.btnLoadDefaults_Click);
            // 
            // tabWheelBase
            // 
            resources.ApplyResources(this.tabWheelBase, "tabWheelBase");
            this.tabWheelBase.BackColor = System.Drawing.Color.White;
            this.tabWheelBase.BackgroundImage = global::AgOpenGPS.Properties.Resources.RadiusWheelBase;
            this.tabWheelBase.Controls.Add(this.label89);
            this.tabWheelBase.Controls.Add(this.button1);
            this.tabWheelBase.Controls.Add(this.label90);
            this.tabWheelBase.Controls.Add(this.nudWheelbase);
            this.tabWheelBase.Controls.Add(this.label91);
            this.tabWheelBase.Controls.Add(this.button2);
            this.tabWheelBase.Name = "tabWheelBase";
            // 
            // label89
            // 
            resources.ApplyResources(this.label89, "label89");
            this.label89.BackColor = System.Drawing.Color.White;
            this.label89.ForeColor = System.Drawing.Color.Black;
            this.label89.Name = "label89";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label90
            // 
            resources.ApplyResources(this.label90, "label90");
            this.label90.BackColor = System.Drawing.Color.Transparent;
            this.label90.ForeColor = System.Drawing.Color.Black;
            this.label90.Name = "label90";
            // 
            // nudWheelbase
            // 
            resources.ApplyResources(this.nudWheelbase, "nudWheelbase");
            this.nudWheelbase.BackColor = System.Drawing.Color.AliceBlue;
            this.nudWheelbase.InterceptArrowKeys = false;
            this.nudWheelbase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudWheelbase.Name = "nudWheelbase";
            this.nudWheelbase.ReadOnly = true;
            this.nudWheelbase.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.nudWheelbase.Click += new System.EventHandler(this.nudWheelbase_Click);
            // 
            // label91
            // 
            resources.ApplyResources(this.label91, "label91");
            this.label91.BackColor = System.Drawing.Color.Linen;
            this.label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label91.ForeColor = System.Drawing.Color.Black;
            this.label91.Name = "label91";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabWheelTrack
            // 
            resources.ApplyResources(this.tabWheelTrack, "tabWheelTrack");
            this.tabWheelTrack.BackColor = System.Drawing.Color.White;
            this.tabWheelTrack.BackgroundImage = global::AgOpenGPS.Properties.Resources.RadiusWheelBase;
            this.tabWheelTrack.Controls.Add(this.label96);
            this.tabWheelTrack.Controls.Add(this.button7);
            this.tabWheelTrack.Controls.Add(this.label94);
            this.tabWheelTrack.Controls.Add(this.nudVehicleTrack);
            this.tabWheelTrack.Controls.Add(this.label95);
            this.tabWheelTrack.Controls.Add(this.button8);
            this.tabWheelTrack.Name = "tabWheelTrack";
            // 
            // label96
            // 
            resources.ApplyResources(this.label96, "label96");
            this.label96.BackColor = System.Drawing.Color.White;
            this.label96.ForeColor = System.Drawing.Color.Black;
            this.label96.Name = "label96";
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label94
            // 
            resources.ApplyResources(this.label94, "label94");
            this.label94.BackColor = System.Drawing.Color.Transparent;
            this.label94.ForeColor = System.Drawing.Color.Black;
            this.label94.Name = "label94";
            // 
            // nudVehicleTrack
            // 
            resources.ApplyResources(this.nudVehicleTrack, "nudVehicleTrack");
            this.nudVehicleTrack.BackColor = System.Drawing.Color.AliceBlue;
            this.nudVehicleTrack.InterceptArrowKeys = false;
            this.nudVehicleTrack.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudVehicleTrack.Name = "nudVehicleTrack";
            this.nudVehicleTrack.ReadOnly = true;
            this.nudVehicleTrack.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.nudVehicleTrack.Click += new System.EventHandler(this.nudVehicleTrack_Click);
            // 
            // label95
            // 
            resources.ApplyResources(this.label95, "label95");
            this.label95.BackColor = System.Drawing.Color.Linen;
            this.label95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label95.ForeColor = System.Drawing.Color.Black;
            this.label95.Name = "label95";
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabAntennaDistance
            // 
            resources.ApplyResources(this.tabAntennaDistance, "tabAntennaDistance");
            this.tabAntennaDistance.BackColor = System.Drawing.Color.White;
            this.tabAntennaDistance.BackgroundImage = global::AgOpenGPS.Properties.Resources.AntennaTractor;
            this.tabAntennaDistance.Controls.Add(this.label100);
            this.tabAntennaDistance.Controls.Add(this.button9);
            this.tabAntennaDistance.Controls.Add(this.label98);
            this.tabAntennaDistance.Controls.Add(this.nudAntennaPivot);
            this.tabAntennaDistance.Controls.Add(this.button10);
            this.tabAntennaDistance.Controls.Add(this.label99);
            this.tabAntennaDistance.Name = "tabAntennaDistance";
            // 
            // label100
            // 
            resources.ApplyResources(this.label100, "label100");
            this.label100.BackColor = System.Drawing.Color.White;
            this.label100.ForeColor = System.Drawing.Color.Black;
            this.label100.Name = "label100";
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label98
            // 
            resources.ApplyResources(this.label98, "label98");
            this.label98.BackColor = System.Drawing.Color.Transparent;
            this.label98.ForeColor = System.Drawing.Color.Black;
            this.label98.Name = "label98";
            // 
            // nudAntennaPivot
            // 
            resources.ApplyResources(this.nudAntennaPivot, "nudAntennaPivot");
            this.nudAntennaPivot.BackColor = System.Drawing.Color.AliceBlue;
            this.nudAntennaPivot.InterceptArrowKeys = false;
            this.nudAntennaPivot.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAntennaPivot.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.nudAntennaPivot.Name = "nudAntennaPivot";
            this.nudAntennaPivot.ReadOnly = true;
            this.nudAntennaPivot.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.nudAntennaPivot.Click += new System.EventHandler(this.nudAntennaPivot_Click);
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // label99
            // 
            resources.ApplyResources(this.label99, "label99");
            this.label99.BackColor = System.Drawing.Color.Linen;
            this.label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label99.ForeColor = System.Drawing.Color.Black;
            this.label99.Name = "label99";
            // 
            // tabAntennaHeight
            // 
            resources.ApplyResources(this.tabAntennaHeight, "tabAntennaHeight");
            this.tabAntennaHeight.BackColor = System.Drawing.Color.White;
            this.tabAntennaHeight.BackgroundImage = global::AgOpenGPS.Properties.Resources.AntennaTractor;
            this.tabAntennaHeight.Controls.Add(this.label114);
            this.tabAntennaHeight.Controls.Add(this.label97);
            this.tabAntennaHeight.Controls.Add(this.button13);
            this.tabAntennaHeight.Controls.Add(this.label92);
            this.tabAntennaHeight.Controls.Add(this.nudAntennaHeight);
            this.tabAntennaHeight.Controls.Add(this.label93);
            this.tabAntennaHeight.Controls.Add(this.button14);
            this.tabAntennaHeight.Name = "tabAntennaHeight";
            // 
            // label114
            // 
            resources.ApplyResources(this.label114, "label114");
            this.label114.BackColor = System.Drawing.Color.White;
            this.label114.ForeColor = System.Drawing.Color.Black;
            this.label114.Name = "label114";
            // 
            // label97
            // 
            resources.ApplyResources(this.label97, "label97");
            this.label97.BackColor = System.Drawing.Color.White;
            this.label97.ForeColor = System.Drawing.Color.Black;
            this.label97.Name = "label97";
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label92
            // 
            resources.ApplyResources(this.label92, "label92");
            this.label92.BackColor = System.Drawing.Color.Transparent;
            this.label92.ForeColor = System.Drawing.Color.Black;
            this.label92.Name = "label92";
            // 
            // nudAntennaHeight
            // 
            resources.ApplyResources(this.nudAntennaHeight, "nudAntennaHeight");
            this.nudAntennaHeight.BackColor = System.Drawing.Color.AliceBlue;
            this.nudAntennaHeight.InterceptArrowKeys = false;
            this.nudAntennaHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAntennaHeight.Name = "nudAntennaHeight";
            this.nudAntennaHeight.ReadOnly = true;
            this.nudAntennaHeight.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.nudAntennaHeight.Click += new System.EventHandler(this.nudAntennaHeight_Click);
            // 
            // label93
            // 
            resources.ApplyResources(this.label93, "label93");
            this.label93.BackColor = System.Drawing.Color.Linen;
            this.label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label93.ForeColor = System.Drawing.Color.Black;
            this.label93.Name = "label93";
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabAntennaOffset
            // 
            resources.ApplyResources(this.tabAntennaOffset, "tabAntennaOffset");
            this.tabAntennaOffset.BackColor = System.Drawing.Color.White;
            this.tabAntennaOffset.BackgroundImage = global::AgOpenGPS.Properties.Resources.AntennaTractor;
            this.tabAntennaOffset.Controls.Add(this.button11);
            this.tabAntennaOffset.Controls.Add(this.label102);
            this.tabAntennaOffset.Controls.Add(this.nudAntennaOffset);
            this.tabAntennaOffset.Controls.Add(this.label104);
            this.tabAntennaOffset.Controls.Add(this.button12);
            this.tabAntennaOffset.Controls.Add(this.label103);
            this.tabAntennaOffset.Name = "tabAntennaOffset";
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label102
            // 
            resources.ApplyResources(this.label102, "label102");
            this.label102.BackColor = System.Drawing.Color.Transparent;
            this.label102.ForeColor = System.Drawing.Color.Black;
            this.label102.Name = "label102";
            // 
            // nudAntennaOffset
            // 
            resources.ApplyResources(this.nudAntennaOffset, "nudAntennaOffset");
            this.nudAntennaOffset.BackColor = System.Drawing.Color.AliceBlue;
            this.nudAntennaOffset.InterceptArrowKeys = false;
            this.nudAntennaOffset.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAntennaOffset.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.nudAntennaOffset.Name = "nudAntennaOffset";
            this.nudAntennaOffset.ReadOnly = true;
            this.nudAntennaOffset.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.nudAntennaOffset.Click += new System.EventHandler(this.nudAntennaOffset_Click);
            // 
            // label104
            // 
            resources.ApplyResources(this.label104, "label104");
            this.label104.BackColor = System.Drawing.Color.Transparent;
            this.label104.ForeColor = System.Drawing.Color.Black;
            this.label104.Name = "label104";
            // 
            // button12
            // 
            resources.ApplyResources(this.button12, "button12");
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // label103
            // 
            resources.ApplyResources(this.label103, "label103");
            this.label103.BackColor = System.Drawing.Color.Linen;
            this.label103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label103.ForeColor = System.Drawing.Color.Black;
            this.label103.Name = "label103";
            // 
            // tabButtonSwitch
            // 
            resources.ApplyResources(this.tabButtonSwitch, "tabButtonSwitch");
            this.tabButtonSwitch.BackColor = System.Drawing.Color.White;
            this.tabButtonSwitch.Controls.Add(this.button15);
            this.tabButtonSwitch.Controls.Add(this.label53);
            this.tabButtonSwitch.Controls.Add(this.cboxSteerEnable);
            this.tabButtonSwitch.Controls.Add(this.label28);
            this.tabButtonSwitch.Controls.Add(this.label62);
            this.tabButtonSwitch.Controls.Add(this.btnOkNext_ButtonSwitch);
            this.tabButtonSwitch.Name = "tabButtonSwitch";
            // 
            // button15
            // 
            resources.ApplyResources(this.button15, "button15");
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Name = "label53";
            // 
            // btnOkNext_ButtonSwitch
            // 
            resources.ApplyResources(this.btnOkNext_ButtonSwitch, "btnOkNext_ButtonSwitch");
            this.btnOkNext_ButtonSwitch.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_ButtonSwitch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_ButtonSwitch.FlatAppearance.BorderSize = 0;
            this.btnOkNext_ButtonSwitch.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_ButtonSwitch.Name = "btnOkNext_ButtonSwitch";
            this.btnOkNext_ButtonSwitch.UseVisualStyleBackColor = false;
            this.btnOkNext_ButtonSwitch.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabA2DConv
            // 
            resources.ApplyResources(this.tabA2DConv, "tabA2DConv");
            this.tabA2DConv.BackColor = System.Drawing.Color.White;
            this.tabA2DConv.Controls.Add(this.btnPrev_A2D);
            this.tabA2DConv.Controls.Add(this.label52);
            this.tabA2DConv.Controls.Add(this.cboxConv);
            this.tabA2DConv.Controls.Add(this.label64);
            this.tabA2DConv.Controls.Add(this.btnOkNext_A2D);
            this.tabA2DConv.Name = "tabA2DConv";
            // 
            // btnPrev_A2D
            // 
            resources.ApplyResources(this.btnPrev_A2D, "btnPrev_A2D");
            this.btnPrev_A2D.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_A2D.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_A2D.FlatAppearance.BorderSize = 0;
            this.btnPrev_A2D.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_A2D.Name = "btnPrev_A2D";
            this.btnPrev_A2D.UseVisualStyleBackColor = false;
            this.btnPrev_A2D.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Name = "label52";
            // 
            // btnOkNext_A2D
            // 
            resources.ApplyResources(this.btnOkNext_A2D, "btnOkNext_A2D");
            this.btnOkNext_A2D.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_A2D.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_A2D.FlatAppearance.BorderSize = 0;
            this.btnOkNext_A2D.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_A2D.Name = "btnOkNext_A2D";
            this.btnOkNext_A2D.UseVisualStyleBackColor = false;
            this.btnOkNext_A2D.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabMotorDriver
            // 
            resources.ApplyResources(this.tabMotorDriver, "tabMotorDriver");
            this.tabMotorDriver.BackColor = System.Drawing.Color.White;
            this.tabMotorDriver.Controls.Add(this.btnPrev_MotorDriver);
            this.tabMotorDriver.Controls.Add(this.label43);
            this.tabMotorDriver.Controls.Add(this.cboxMotorDrive);
            this.tabMotorDriver.Controls.Add(this.label63);
            this.tabMotorDriver.Controls.Add(this.btnOkNext_MotorDriver);
            this.tabMotorDriver.Name = "tabMotorDriver";
            // 
            // btnPrev_MotorDriver
            // 
            resources.ApplyResources(this.btnPrev_MotorDriver, "btnPrev_MotorDriver");
            this.btnPrev_MotorDriver.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_MotorDriver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_MotorDriver.FlatAppearance.BorderSize = 0;
            this.btnPrev_MotorDriver.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_MotorDriver.Name = "btnPrev_MotorDriver";
            this.btnPrev_MotorDriver.UseVisualStyleBackColor = false;
            this.btnPrev_MotorDriver.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Name = "label43";
            // 
            // btnOkNext_MotorDriver
            // 
            resources.ApplyResources(this.btnOkNext_MotorDriver, "btnOkNext_MotorDriver");
            this.btnOkNext_MotorDriver.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_MotorDriver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_MotorDriver.FlatAppearance.BorderSize = 0;
            this.btnOkNext_MotorDriver.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_MotorDriver.Name = "btnOkNext_MotorDriver";
            this.btnOkNext_MotorDriver.UseVisualStyleBackColor = false;
            this.btnOkNext_MotorDriver.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabInvertRelays
            // 
            resources.ApplyResources(this.tabInvertRelays, "tabInvertRelays");
            this.tabInvertRelays.BackColor = System.Drawing.Color.White;
            this.tabInvertRelays.Controls.Add(this.label59);
            this.tabInvertRelays.Controls.Add(this.btnPrev_InvertRelays);
            this.tabInvertRelays.Controls.Add(this.label51);
            this.tabInvertRelays.Controls.Add(this.label29);
            this.tabInvertRelays.Controls.Add(this.btnOkNext_InvertRelays);
            this.tabInvertRelays.Controls.Add(this.chkSteerInvertRelays);
            this.tabInvertRelays.Name = "tabInvertRelays";
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label59.Name = "label59";
            // 
            // btnPrev_InvertRelays
            // 
            resources.ApplyResources(this.btnPrev_InvertRelays, "btnPrev_InvertRelays");
            this.btnPrev_InvertRelays.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_InvertRelays.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_InvertRelays.FlatAppearance.BorderSize = 0;
            this.btnPrev_InvertRelays.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_InvertRelays.Name = "btnPrev_InvertRelays";
            this.btnPrev_InvertRelays.UseVisualStyleBackColor = false;
            this.btnPrev_InvertRelays.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Name = "label51";
            // 
            // btnOkNext_InvertRelays
            // 
            resources.ApplyResources(this.btnOkNext_InvertRelays, "btnOkNext_InvertRelays");
            this.btnOkNext_InvertRelays.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_InvertRelays.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_InvertRelays.FlatAppearance.BorderSize = 0;
            this.btnOkNext_InvertRelays.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_InvertRelays.Name = "btnOkNext_InvertRelays";
            this.btnOkNext_InvertRelays.UseVisualStyleBackColor = false;
            this.btnOkNext_InvertRelays.Click += new System.EventHandler(this.btnOkNext_Click);
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
            this.chkSteerInvertRelays.CheckedChanged += new System.EventHandler(this.chkSteerInvertRelays_CheckedChanged);
            // 
            // tabDanfoss
            // 
            resources.ApplyResources(this.tabDanfoss, "tabDanfoss");
            this.tabDanfoss.BackColor = System.Drawing.Color.White;
            this.tabDanfoss.Controls.Add(this.btnPrev_Danfoss);
            this.tabDanfoss.Controls.Add(this.label50);
            this.tabDanfoss.Controls.Add(this.label55);
            this.tabDanfoss.Controls.Add(this.btnOkNext_Danfoss);
            this.tabDanfoss.Controls.Add(this.cboxDanfoss);
            this.tabDanfoss.Name = "tabDanfoss";
            // 
            // btnPrev_Danfoss
            // 
            resources.ApplyResources(this.btnPrev_Danfoss, "btnPrev_Danfoss");
            this.btnPrev_Danfoss.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_Danfoss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_Danfoss.FlatAppearance.BorderSize = 0;
            this.btnPrev_Danfoss.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_Danfoss.Name = "btnPrev_Danfoss";
            this.btnPrev_Danfoss.UseVisualStyleBackColor = false;
            this.btnPrev_Danfoss.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Name = "label50";
            // 
            // btnOkNext_Danfoss
            // 
            resources.ApplyResources(this.btnOkNext_Danfoss, "btnOkNext_Danfoss");
            this.btnOkNext_Danfoss.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_Danfoss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_Danfoss.FlatAppearance.BorderSize = 0;
            this.btnOkNext_Danfoss.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_Danfoss.Name = "btnOkNext_Danfoss";
            this.btnOkNext_Danfoss.UseVisualStyleBackColor = false;
            this.btnOkNext_Danfoss.Click += new System.EventHandler(this.btnOkNext_Click);
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
            this.cboxDanfoss.CheckedChanged += new System.EventHandler(this.cboxDanfoss_CheckedChanged);
            // 
            // tabRollInv
            // 
            resources.ApplyResources(this.tabRollInv, "tabRollInv");
            this.tabRollInv.BackColor = System.Drawing.Color.White;
            this.tabRollInv.Controls.Add(this.label115);
            this.tabRollInv.Controls.Add(this.lblRoll);
            this.tabRollInv.Controls.Add(this.pictureBox9);
            this.tabRollInv.Controls.Add(this.cboxDataInvertRoll);
            this.tabRollInv.Controls.Add(this.label36);
            this.tabRollInv.Controls.Add(this.button4);
            this.tabRollInv.Controls.Add(this.label46);
            this.tabRollInv.Controls.Add(this.button18);
            this.tabRollInv.Controls.Add(this.label107);
            this.tabRollInv.Name = "tabRollInv";
            // 
            // label115
            // 
            resources.ApplyResources(this.label115, "label115");
            this.label115.BackColor = System.Drawing.Color.Transparent;
            this.label115.ForeColor = System.Drawing.Color.Black;
            this.label115.Name = "label115";
            // 
            // lblRoll
            // 
            resources.ApplyResources(this.lblRoll, "lblRoll");
            this.lblRoll.BackColor = System.Drawing.Color.Transparent;
            this.lblRoll.ForeColor = System.Drawing.Color.Black;
            this.lblRoll.Name = "lblRoll";
            // 
            // pictureBox9
            // 
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.BackgroundImage = global::AgOpenGPS.Properties.Resources.ConD_RollHelper;
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // cboxDataInvertRoll
            // 
            resources.ApplyResources(this.cboxDataInvertRoll, "cboxDataInvertRoll");
            this.cboxDataInvertRoll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxDataInvertRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboxDataInvertRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxDataInvertRoll.ForeColor = System.Drawing.Color.Black;
            this.cboxDataInvertRoll.Image = global::AgOpenGPS.Properties.Resources.ConDa_InvertRoll;
            this.cboxDataInvertRoll.Name = "cboxDataInvertRoll";
            this.cboxDataInvertRoll.UseVisualStyleBackColor = false;
            this.cboxDataInvertRoll.Click += new System.EventHandler(this.cboxDataInvertRoll_Click);
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Name = "label36";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Name = "label46";
            // 
            // button18
            // 
            resources.ApplyResources(this.button18, "button18");
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // label107
            // 
            resources.ApplyResources(this.label107, "label107");
            this.label107.BackColor = System.Drawing.Color.Transparent;
            this.label107.ForeColor = System.Drawing.Color.Black;
            this.label107.Name = "label107";
            // 
            // tabRollZero
            // 
            resources.ApplyResources(this.tabRollZero, "tabRollZero");
            this.tabRollZero.BackColor = System.Drawing.Color.White;
            this.tabRollZero.Controls.Add(this.lblRoll2);
            this.tabRollZero.Controls.Add(this.label110);
            this.tabRollZero.Controls.Add(this.label47);
            this.tabRollZero.Controls.Add(this.label57);
            this.tabRollZero.Controls.Add(this.lblRollZeroOffset);
            this.tabRollZero.Controls.Add(this.btnZeroRoll);
            this.tabRollZero.Controls.Add(this.btnRemoveZeroOffset);
            this.tabRollZero.Controls.Add(this.label48);
            this.tabRollZero.Controls.Add(this.button3);
            this.tabRollZero.Controls.Add(this.label56);
            this.tabRollZero.Controls.Add(this.button19);
            this.tabRollZero.Name = "tabRollZero";
            // 
            // lblRoll2
            // 
            resources.ApplyResources(this.lblRoll2, "lblRoll2");
            this.lblRoll2.BackColor = System.Drawing.Color.Transparent;
            this.lblRoll2.ForeColor = System.Drawing.Color.Black;
            this.lblRoll2.Name = "lblRoll2";
            // 
            // label110
            // 
            resources.ApplyResources(this.label110, "label110");
            this.label110.BackColor = System.Drawing.Color.Transparent;
            this.label110.ForeColor = System.Drawing.Color.Black;
            this.label110.Name = "label110";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Name = "label47";
            // 
            // label57
            // 
            resources.ApplyResources(this.label57, "label57");
            this.label57.ForeColor = System.Drawing.Color.Black;
            this.label57.Name = "label57";
            // 
            // lblRollZeroOffset
            // 
            resources.ApplyResources(this.lblRollZeroOffset, "lblRollZeroOffset");
            this.lblRollZeroOffset.ForeColor = System.Drawing.Color.Black;
            this.lblRollZeroOffset.Name = "lblRollZeroOffset";
            // 
            // btnZeroRoll
            // 
            resources.ApplyResources(this.btnZeroRoll, "btnZeroRoll");
            this.btnZeroRoll.BackColor = System.Drawing.Color.Transparent;
            this.btnZeroRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZeroRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnZeroRoll.ForeColor = System.Drawing.Color.Black;
            this.btnZeroRoll.Image = global::AgOpenGPS.Properties.Resources.ConDa_RollSetZero;
            this.btnZeroRoll.Name = "btnZeroRoll";
            this.btnZeroRoll.UseVisualStyleBackColor = false;
            this.btnZeroRoll.Click += new System.EventHandler(this.btnZeroRoll_Click);
            // 
            // btnRemoveZeroOffset
            // 
            resources.ApplyResources(this.btnRemoveZeroOffset, "btnRemoveZeroOffset");
            this.btnRemoveZeroOffset.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveZeroOffset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveZeroOffset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnRemoveZeroOffset.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveZeroOffset.Image = global::AgOpenGPS.Properties.Resources.ConDa_RemoveOffset;
            this.btnRemoveZeroOffset.Name = "btnRemoveZeroOffset";
            this.btnRemoveZeroOffset.UseVisualStyleBackColor = false;
            this.btnRemoveZeroOffset.Click += new System.EventHandler(this.btnRemoveZeroOffset_Click);
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Name = "label48";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label56
            // 
            resources.ApplyResources(this.label56, "label56");
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Name = "label56";
            // 
            // button19
            // 
            resources.ApplyResources(this.button19, "button19");
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button19.Name = "button19";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabWAS
            // 
            resources.ApplyResources(this.tabWAS, "tabWAS");
            this.tabWAS.BackColor = System.Drawing.Color.White;
            this.tabWAS.Controls.Add(this.label45);
            this.tabWAS.Controls.Add(this.btnPrev_InvertWAS);
            this.tabWAS.Controls.Add(this.label42);
            this.tabWAS.Controls.Add(this.label30);
            this.tabWAS.Controls.Add(this.btnOkWAS);
            this.tabWAS.Controls.Add(this.chkInvertWAS);
            this.tabWAS.Name = "tabWAS";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label45.Name = "label45";
            // 
            // btnPrev_InvertWAS
            // 
            resources.ApplyResources(this.btnPrev_InvertWAS, "btnPrev_InvertWAS");
            this.btnPrev_InvertWAS.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_InvertWAS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_InvertWAS.FlatAppearance.BorderSize = 0;
            this.btnPrev_InvertWAS.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_InvertWAS.Name = "btnPrev_InvertWAS";
            this.btnPrev_InvertWAS.UseVisualStyleBackColor = false;
            this.btnPrev_InvertWAS.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Name = "label42";
            // 
            // btnOkWAS
            // 
            resources.ApplyResources(this.btnOkWAS, "btnOkWAS");
            this.btnOkWAS.BackColor = System.Drawing.Color.Transparent;
            this.btnOkWAS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkWAS.FlatAppearance.BorderSize = 0;
            this.btnOkWAS.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkWAS.Name = "btnOkWAS";
            this.btnOkWAS.UseVisualStyleBackColor = false;
            this.btnOkWAS.Click += new System.EventHandler(this.btnOkNext_Click);
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
            this.chkInvertWAS.CheckedChanged += new System.EventHandler(this.chkInvertWAS_CheckedChanged);
            // 
            // tabWAS_Zero
            // 
            resources.ApplyResources(this.tabWAS_Zero, "tabWAS_Zero");
            this.tabWAS_Zero.BackColor = System.Drawing.Color.White;
            this.tabWAS_Zero.Controls.Add(this.label112);
            this.tabWAS_Zero.Controls.Add(this.lblCurrentHeading);
            this.tabWAS_Zero.Controls.Add(this.label37);
            this.tabWAS_Zero.Controls.Add(this.button6);
            this.tabWAS_Zero.Controls.Add(this.btnRemoveWasOffset);
            this.tabWAS_Zero.Controls.Add(this.label40);
            this.tabWAS_Zero.Controls.Add(this.hsbarWasOffset);
            this.tabWAS_Zero.Controls.Add(this.lblSteerAngleSensorZero);
            this.tabWAS_Zero.Controls.Add(this.label10);
            this.tabWAS_Zero.Controls.Add(this.btnOkNext_WAS_Zero);
            this.tabWAS_Zero.Controls.Add(this.btnZeroWAS);
            this.tabWAS_Zero.Name = "tabWAS_Zero";
            // 
            // label112
            // 
            resources.ApplyResources(this.label112, "label112");
            this.label112.BackColor = System.Drawing.Color.Transparent;
            this.label112.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label112.Name = "label112";
            // 
            // lblCurrentHeading
            // 
            resources.ApplyResources(this.lblCurrentHeading, "lblCurrentHeading");
            this.lblCurrentHeading.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentHeading.Name = "lblCurrentHeading";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Name = "label37";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnRemoveWasOffset
            // 
            resources.ApplyResources(this.btnRemoveWasOffset, "btnRemoveWasOffset");
            this.btnRemoveWasOffset.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveWasOffset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveWasOffset.Image = global::AgOpenGPS.Properties.Resources.WizWasZeroReset;
            this.btnRemoveWasOffset.Name = "btnRemoveWasOffset";
            this.btnRemoveWasOffset.UseVisualStyleBackColor = true;
            this.btnRemoveWasOffset.Click += new System.EventHandler(this.btnRemoveWasOffset_Click);
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Name = "label40";
            // 
            // btnOkNext_WAS_Zero
            // 
            resources.ApplyResources(this.btnOkNext_WAS_Zero, "btnOkNext_WAS_Zero");
            this.btnOkNext_WAS_Zero.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_WAS_Zero.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_WAS_Zero.FlatAppearance.BorderSize = 0;
            this.btnOkNext_WAS_Zero.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_WAS_Zero.Name = "btnOkNext_WAS_Zero";
            this.btnOkNext_WAS_Zero.UseVisualStyleBackColor = false;
            this.btnOkNext_WAS_Zero.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // btnZeroWAS
            // 
            resources.ApplyResources(this.btnZeroWAS, "btnZeroWAS");
            this.btnZeroWAS.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnZeroWAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZeroWAS.Image = global::AgOpenGPS.Properties.Resources.SteerZeroSmall;
            this.btnZeroWAS.Name = "btnZeroWAS";
            this.btnZeroWAS.UseVisualStyleBackColor = true;
            this.btnZeroWAS.Click += new System.EventHandler(this.btnZeroWAS_Click);
            // 
            // tabMotorDirection
            // 
            resources.ApplyResources(this.tabMotorDirection, "tabMotorDirection");
            this.tabMotorDirection.BackColor = System.Drawing.Color.White;
            this.tabMotorDirection.Controls.Add(this.label58);
            this.tabMotorDirection.Controls.Add(this.label41);
            this.tabMotorDirection.Controls.Add(this.label17);
            this.tabMotorDirection.Controls.Add(this.label33);
            this.tabMotorDirection.Controls.Add(this.label70);
            this.tabMotorDirection.Controls.Add(this.btnPrev_MotorDirection);
            this.tabMotorDirection.Controls.Add(this.btnOkNext_MotorDirection);
            this.tabMotorDirection.Controls.Add(this.btnSteerLeft);
            this.tabMotorDirection.Controls.Add(this.btnSteerRight);
            this.tabMotorDirection.Controls.Add(this.chkInvertSteer);
            this.tabMotorDirection.Name = "tabMotorDirection";
            this.tabMotorDirection.Enter += new System.EventHandler(this.tabMotorDirection_Enter);
            this.tabMotorDirection.Leave += new System.EventHandler(this.tabMotorDirection_Leave);
            // 
            // label58
            // 
            resources.ApplyResources(this.label58, "label58");
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label58.Name = "label58";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Name = "label41";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Name = "label17";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label33.Name = "label33";
            // 
            // btnPrev_MotorDirection
            // 
            resources.ApplyResources(this.btnPrev_MotorDirection, "btnPrev_MotorDirection");
            this.btnPrev_MotorDirection.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_MotorDirection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_MotorDirection.FlatAppearance.BorderSize = 0;
            this.btnPrev_MotorDirection.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_MotorDirection.Name = "btnPrev_MotorDirection";
            this.btnPrev_MotorDirection.UseVisualStyleBackColor = false;
            this.btnPrev_MotorDirection.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnOkNext_MotorDirection
            // 
            resources.ApplyResources(this.btnOkNext_MotorDirection, "btnOkNext_MotorDirection");
            this.btnOkNext_MotorDirection.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_MotorDirection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_MotorDirection.FlatAppearance.BorderSize = 0;
            this.btnOkNext_MotorDirection.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_MotorDirection.Name = "btnOkNext_MotorDirection";
            this.btnOkNext_MotorDirection.UseVisualStyleBackColor = false;
            this.btnOkNext_MotorDirection.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // btnSteerLeft
            // 
            resources.ApplyResources(this.btnSteerLeft, "btnSteerLeft");
            this.btnSteerLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnSteerLeft.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSteerLeft.Image = global::AgOpenGPS.Properties.Resources.SteerLeft;
            this.btnSteerLeft.Name = "btnSteerLeft";
            this.btnSteerLeft.UseVisualStyleBackColor = false;
            this.btnSteerLeft.Click += new System.EventHandler(this.btnSteerLeft_Click);
            // 
            // btnSteerRight
            // 
            resources.ApplyResources(this.btnSteerRight, "btnSteerRight");
            this.btnSteerRight.BackColor = System.Drawing.Color.Transparent;
            this.btnSteerRight.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSteerRight.Image = global::AgOpenGPS.Properties.Resources.SteerRight;
            this.btnSteerRight.Name = "btnSteerRight";
            this.btnSteerRight.UseVisualStyleBackColor = false;
            this.btnSteerRight.Click += new System.EventHandler(this.btnSteerRight_Click);
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
            this.chkInvertSteer.CheckedChanged += new System.EventHandler(this.chkInvertSteer_CheckedChanged);
            // 
            // tabCPD_Setup
            // 
            resources.ApplyResources(this.tabCPD_Setup, "tabCPD_Setup");
            this.tabCPD_Setup.BackColor = System.Drawing.Color.White;
            this.tabCPD_Setup.Controls.Add(this.label60);
            this.tabCPD_Setup.Controls.Add(this.btnPrev_CountsPerDegree);
            this.tabCPD_Setup.Controls.Add(this.label74);
            this.tabCPD_Setup.Controls.Add(this.label75);
            this.tabCPD_Setup.Controls.Add(this.btnSkipCPD_Setup);
            this.tabCPD_Setup.Controls.Add(this.btnOKNext_CPDSetup);
            this.tabCPD_Setup.Name = "tabCPD_Setup";
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.ForeColor = System.Drawing.Color.Black;
            this.label60.Name = "label60";
            // 
            // btnPrev_CountsPerDegree
            // 
            resources.ApplyResources(this.btnPrev_CountsPerDegree, "btnPrev_CountsPerDegree");
            this.btnPrev_CountsPerDegree.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_CountsPerDegree.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrev_CountsPerDegree.FlatAppearance.BorderSize = 0;
            this.btnPrev_CountsPerDegree.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_CountsPerDegree.Name = "btnPrev_CountsPerDegree";
            this.btnPrev_CountsPerDegree.UseVisualStyleBackColor = false;
            this.btnPrev_CountsPerDegree.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label74
            // 
            resources.ApplyResources(this.label74, "label74");
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Name = "label74";
            // 
            // label75
            // 
            resources.ApplyResources(this.label75, "label75");
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.ForeColor = System.Drawing.Color.Black;
            this.label75.Name = "label75";
            // 
            // btnSkipCPD_Setup
            // 
            resources.ApplyResources(this.btnSkipCPD_Setup, "btnSkipCPD_Setup");
            this.btnSkipCPD_Setup.BackColor = System.Drawing.Color.Transparent;
            this.btnSkipCPD_Setup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnSkipCPD_Setup.FlatAppearance.BorderSize = 0;
            this.btnSkipCPD_Setup.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnSkipCPD_Setup.Name = "btnSkipCPD_Setup";
            this.btnSkipCPD_Setup.UseVisualStyleBackColor = false;
            this.btnSkipCPD_Setup.Click += new System.EventHandler(this.btnSkipCPD_Setup_Click);
            // 
            // btnOKNext_CPDSetup
            // 
            resources.ApplyResources(this.btnOKNext_CPDSetup, "btnOKNext_CPDSetup");
            this.btnOKNext_CPDSetup.BackColor = System.Drawing.Color.Transparent;
            this.btnOKNext_CPDSetup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOKNext_CPDSetup.FlatAppearance.BorderSize = 0;
            this.btnOKNext_CPDSetup.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOKNext_CPDSetup.Name = "btnOKNext_CPDSetup";
            this.btnOKNext_CPDSetup.UseVisualStyleBackColor = false;
            this.btnOKNext_CPDSetup.Click += new System.EventHandler(this.btnOKNext_CPDSetup_Click);
            // 
            // tabCountsPerDeg
            // 
            resources.ApplyResources(this.tabCountsPerDeg, "tabCountsPerDeg");
            this.tabCountsPerDeg.BackColor = System.Drawing.Color.White;
            this.tabCountsPerDeg.Controls.Add(this.label109);
            this.tabCountsPerDeg.Controls.Add(this.lblRightStartAngle);
            this.tabCountsPerDeg.Controls.Add(this.button5);
            this.tabCountsPerDeg.Controls.Add(this.lblCPDError);
            this.tabCountsPerDeg.Controls.Add(this.label39);
            this.tabCountsPerDeg.Controls.Add(this.hsbarCountsPerDegree);
            this.tabCountsPerDeg.Controls.Add(this.label8);
            this.tabCountsPerDeg.Controls.Add(this.lblCountsPerDegree);
            this.tabCountsPerDeg.Controls.Add(this.label7);
            this.tabCountsPerDeg.Controls.Add(this.lblDiameter);
            this.tabCountsPerDeg.Controls.Add(this.lblCalcSteerAngleInner);
            this.tabCountsPerDeg.Controls.Add(this.label1);
            this.tabCountsPerDeg.Controls.Add(this.btnOkNext_CountsPerDeg);
            this.tabCountsPerDeg.Controls.Add(this.btnStartSA);
            this.tabCountsPerDeg.Name = "tabCountsPerDeg";
            // 
            // label109
            // 
            resources.ApplyResources(this.label109, "label109");
            this.label109.BackColor = System.Drawing.Color.Transparent;
            this.label109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label109.Name = "label109";
            // 
            // lblRightStartAngle
            // 
            resources.ApplyResources(this.lblRightStartAngle, "lblRightStartAngle");
            this.lblRightStartAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblRightStartAngle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRightStartAngle.Name = "lblRightStartAngle";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblCPDError
            // 
            resources.ApplyResources(this.lblCPDError, "lblCPDError");
            this.lblCPDError.BackColor = System.Drawing.Color.Transparent;
            this.lblCPDError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPDError.Name = "lblCPDError";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Name = "label39";
            // 
            // btnOkNext_CountsPerDeg
            // 
            resources.ApplyResources(this.btnOkNext_CountsPerDeg, "btnOkNext_CountsPerDeg");
            this.btnOkNext_CountsPerDeg.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_CountsPerDeg.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_CountsPerDeg.FlatAppearance.BorderSize = 0;
            this.btnOkNext_CountsPerDeg.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_CountsPerDeg.Name = "btnOkNext_CountsPerDeg";
            this.btnOkNext_CountsPerDeg.UseVisualStyleBackColor = false;
            this.btnOkNext_CountsPerDeg.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // btnStartSA
            // 
            resources.ApplyResources(this.btnStartSA, "btnStartSA");
            this.btnStartSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartSA.Image = global::AgOpenGPS.Properties.Resources.BoundaryRecord;
            this.btnStartSA.Name = "btnStartSA";
            this.btnStartSA.UseVisualStyleBackColor = true;
            this.btnStartSA.Click += new System.EventHandler(this.btnStartSA_Click);
            // 
            // tabAckCPD
            // 
            resources.ApplyResources(this.tabAckCPD, "tabAckCPD");
            this.tabAckCPD.BackColor = System.Drawing.Color.White;
            this.tabAckCPD.Controls.Add(this.btnAckReset);
            this.tabAckCPD.Controls.Add(this.label101);
            this.tabAckCPD.Controls.Add(this.lblStartAngleLeft);
            this.tabAckCPD.Controls.Add(this.label32);
            this.tabAckCPD.Controls.Add(this.hsbarAckerman);
            this.tabAckCPD.Controls.Add(this.lblAckerman);
            this.tabAckCPD.Controls.Add(this.button16);
            this.tabAckCPD.Controls.Add(this.lblAckermannError);
            this.tabAckCPD.Controls.Add(this.label105);
            this.tabAckCPD.Controls.Add(this.label106);
            this.tabAckCPD.Controls.Add(this.label108);
            this.tabAckCPD.Controls.Add(this.lblDiameterLeft);
            this.tabAckCPD.Controls.Add(this.lblCalcSteerAngleLeft);
            this.tabAckCPD.Controls.Add(this.label111);
            this.tabAckCPD.Controls.Add(this.button17);
            this.tabAckCPD.Controls.Add(this.btnStartSA_Left);
            this.tabAckCPD.Name = "tabAckCPD";
            // 
            // btnAckReset
            // 
            resources.ApplyResources(this.btnAckReset, "btnAckReset");
            this.btnAckReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAckReset.Name = "btnAckReset";
            this.btnAckReset.UseVisualStyleBackColor = true;
            this.btnAckReset.Click += new System.EventHandler(this.btnAckReset_Click);
            // 
            // label101
            // 
            resources.ApplyResources(this.label101, "label101");
            this.label101.BackColor = System.Drawing.Color.Transparent;
            this.label101.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label101.Name = "label101";
            // 
            // lblStartAngleLeft
            // 
            resources.ApplyResources(this.lblStartAngleLeft, "lblStartAngleLeft");
            this.lblStartAngleLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblStartAngleLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStartAngleLeft.Name = "lblStartAngleLeft";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Name = "label32";
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
            // 
            // lblAckerman
            // 
            resources.ApplyResources(this.lblAckerman, "lblAckerman");
            this.lblAckerman.ForeColor = System.Drawing.Color.Black;
            this.lblAckerman.Name = "lblAckerman";
            // 
            // button16
            // 
            resources.ApplyResources(this.button16, "button16");
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.button16.Name = "button16";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblAckermannError
            // 
            resources.ApplyResources(this.lblAckermannError, "lblAckermannError");
            this.lblAckermannError.BackColor = System.Drawing.Color.Transparent;
            this.lblAckermannError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAckermannError.Name = "lblAckermannError";
            // 
            // label105
            // 
            resources.ApplyResources(this.label105, "label105");
            this.label105.ForeColor = System.Drawing.Color.Black;
            this.label105.Name = "label105";
            // 
            // label106
            // 
            resources.ApplyResources(this.label106, "label106");
            this.label106.BackColor = System.Drawing.Color.Transparent;
            this.label106.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label106.Name = "label106";
            // 
            // label108
            // 
            resources.ApplyResources(this.label108, "label108");
            this.label108.ForeColor = System.Drawing.Color.Black;
            this.label108.Name = "label108";
            // 
            // lblDiameterLeft
            // 
            resources.ApplyResources(this.lblDiameterLeft, "lblDiameterLeft");
            this.lblDiameterLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblDiameterLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiameterLeft.Name = "lblDiameterLeft";
            // 
            // lblCalcSteerAngleLeft
            // 
            resources.ApplyResources(this.lblCalcSteerAngleLeft, "lblCalcSteerAngleLeft");
            this.lblCalcSteerAngleLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblCalcSteerAngleLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalcSteerAngleLeft.Name = "lblCalcSteerAngleLeft";
            // 
            // label111
            // 
            resources.ApplyResources(this.label111, "label111");
            this.label111.BackColor = System.Drawing.Color.Transparent;
            this.label111.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label111.Name = "label111";
            // 
            // button17
            // 
            resources.ApplyResources(this.button17, "button17");
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.button17.Name = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // btnStartSA_Left
            // 
            resources.ApplyResources(this.btnStartSA_Left, "btnStartSA_Left");
            this.btnStartSA_Left.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartSA_Left.Image = global::AgOpenGPS.Properties.Resources.BoundaryRecord;
            this.btnStartSA_Left.Name = "btnStartSA_Left";
            this.btnStartSA_Left.UseVisualStyleBackColor = true;
            this.btnStartSA_Left.Click += new System.EventHandler(this.btnStartSA_Left_Click);
            // 
            // tabMaxSteerAngle
            // 
            resources.ApplyResources(this.tabMaxSteerAngle, "tabMaxSteerAngle");
            this.tabMaxSteerAngle.BackColor = System.Drawing.Color.White;
            this.tabMaxSteerAngle.Controls.Add(this.label113);
            this.tabMaxSteerAngle.Controls.Add(this.btnOkSetMaximumSteerAngle);
            this.tabMaxSteerAngle.Controls.Add(this.label73);
            this.tabMaxSteerAngle.Controls.Add(this.btnPrev_MaxSteerAngle);
            this.tabMaxSteerAngle.Controls.Add(this.label49);
            this.tabMaxSteerAngle.Controls.Add(this.label23);
            this.tabMaxSteerAngle.Controls.Add(this.lblMaxSteerAngle);
            this.tabMaxSteerAngle.Controls.Add(this.hsbarMaxSteerAngle);
            this.tabMaxSteerAngle.Controls.Add(this.btnOkNextMaxSteerAngle);
            this.tabMaxSteerAngle.Name = "tabMaxSteerAngle";
            // 
            // label113
            // 
            resources.ApplyResources(this.label113, "label113");
            this.label113.BackColor = System.Drawing.Color.Transparent;
            this.label113.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label113.Name = "label113";
            // 
            // btnOkSetMaximumSteerAngle
            // 
            resources.ApplyResources(this.btnOkSetMaximumSteerAngle, "btnOkSetMaximumSteerAngle");
            this.btnOkSetMaximumSteerAngle.BackColor = System.Drawing.Color.Transparent;
            this.btnOkSetMaximumSteerAngle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOkSetMaximumSteerAngle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOkSetMaximumSteerAngle.FlatAppearance.BorderSize = 0;
            this.btnOkSetMaximumSteerAngle.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnOkSetMaximumSteerAngle.Name = "btnOkSetMaximumSteerAngle";
            this.btnOkSetMaximumSteerAngle.UseVisualStyleBackColor = false;
            this.btnOkSetMaximumSteerAngle.Click += new System.EventHandler(this.btnOkSetMaximumSteerAngle_Click);
            // 
            // label73
            // 
            resources.ApplyResources(this.label73, "label73");
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.ForeColor = System.Drawing.Color.Black;
            this.label73.Name = "label73";
            // 
            // btnPrev_MaxSteerAngle
            // 
            resources.ApplyResources(this.btnPrev_MaxSteerAngle, "btnPrev_MaxSteerAngle");
            this.btnPrev_MaxSteerAngle.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_MaxSteerAngle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_MaxSteerAngle.FlatAppearance.BorderSize = 0;
            this.btnPrev_MaxSteerAngle.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_MaxSteerAngle.Name = "btnPrev_MaxSteerAngle";
            this.btnPrev_MaxSteerAngle.UseVisualStyleBackColor = false;
            this.btnPrev_MaxSteerAngle.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Name = "label49";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Name = "label23";
            // 
            // btnOkNextMaxSteerAngle
            // 
            resources.ApplyResources(this.btnOkNextMaxSteerAngle, "btnOkNextMaxSteerAngle");
            this.btnOkNextMaxSteerAngle.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNextMaxSteerAngle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOkNextMaxSteerAngle.FlatAppearance.BorderSize = 0;
            this.btnOkNextMaxSteerAngle.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNextMaxSteerAngle.Name = "btnOkNextMaxSteerAngle";
            this.btnOkNextMaxSteerAngle.UseVisualStyleBackColor = false;
            this.btnOkNextMaxSteerAngle.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabCancelGuidance
            // 
            resources.ApplyResources(this.tabCancelGuidance, "tabCancelGuidance");
            this.tabCancelGuidance.BackColor = System.Drawing.Color.White;
            this.tabCancelGuidance.Controls.Add(this.btnPrev_CancelGuidance);
            this.tabCancelGuidance.Controls.Add(this.btnOkNextCancelGuidance);
            this.tabCancelGuidance.Controls.Add(this.label44);
            this.tabCancelGuidance.Controls.Add(this.labelEncoder);
            this.tabCancelGuidance.Controls.Add(this.labelCurrentTurnSensor);
            this.tabCancelGuidance.Controls.Add(this.labelPressureTurnSensor);
            this.tabCancelGuidance.Controls.Add(this.pbarSensor);
            this.tabCancelGuidance.Controls.Add(this.nudMaxCounts);
            this.tabCancelGuidance.Controls.Add(this.label61);
            this.tabCancelGuidance.Controls.Add(this.hsbarSensor);
            this.tabCancelGuidance.Controls.Add(this.lblPercentFS);
            this.tabCancelGuidance.Controls.Add(this.lblhsbarSensor);
            this.tabCancelGuidance.Controls.Add(this.cboxPressureSensor);
            this.tabCancelGuidance.Controls.Add(this.cboxEncoder);
            this.tabCancelGuidance.Controls.Add(this.cboxCurrentSensor);
            this.tabCancelGuidance.Name = "tabCancelGuidance";
            // 
            // btnPrev_CancelGuidance
            // 
            resources.ApplyResources(this.btnPrev_CancelGuidance, "btnPrev_CancelGuidance");
            this.btnPrev_CancelGuidance.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_CancelGuidance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_CancelGuidance.FlatAppearance.BorderSize = 0;
            this.btnPrev_CancelGuidance.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_CancelGuidance.Name = "btnPrev_CancelGuidance";
            this.btnPrev_CancelGuidance.UseVisualStyleBackColor = false;
            this.btnPrev_CancelGuidance.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnOkNextCancelGuidance
            // 
            resources.ApplyResources(this.btnOkNextCancelGuidance, "btnOkNextCancelGuidance");
            this.btnOkNextCancelGuidance.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNextCancelGuidance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNextCancelGuidance.FlatAppearance.BorderSize = 0;
            this.btnOkNextCancelGuidance.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNextCancelGuidance.Name = "btnOkNextCancelGuidance";
            this.btnOkNextCancelGuidance.UseVisualStyleBackColor = false;
            this.btnOkNextCancelGuidance.Click += new System.EventHandler(this.btnOkNextCancelGuidance_Click);
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Name = "label44";
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
            this.cboxPressureSensor.Click += new System.EventHandler(this.cboxCancelGuidance_Click);
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
            this.cboxEncoder.Click += new System.EventHandler(this.cboxCancelGuidance_Click);
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
            this.cboxCurrentSensor.Click += new System.EventHandler(this.cboxCancelGuidance_Click);
            // 
            // tabPanicStop
            // 
            resources.ApplyResources(this.tabPanicStop, "tabPanicStop");
            this.tabPanicStop.BackColor = System.Drawing.Color.White;
            this.tabPanicStop.Controls.Add(this.label82);
            this.tabPanicStop.Controls.Add(this.btnPrev_Panic);
            this.tabPanicStop.Controls.Add(this.label54);
            this.tabPanicStop.Controls.Add(this.nudPanicStopSpeed);
            this.tabPanicStop.Controls.Add(this.label16);
            this.tabPanicStop.Controls.Add(this.label31);
            this.tabPanicStop.Controls.Add(this.btnOkNext_PanicStop);
            this.tabPanicStop.Name = "tabPanicStop";
            // 
            // label82
            // 
            resources.ApplyResources(this.label82, "label82");
            this.label82.BackColor = System.Drawing.Color.Transparent;
            this.label82.ForeColor = System.Drawing.Color.Black;
            this.label82.Name = "label82";
            // 
            // btnPrev_Panic
            // 
            resources.ApplyResources(this.btnPrev_Panic, "btnPrev_Panic");
            this.btnPrev_Panic.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_Panic.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_Panic.FlatAppearance.BorderSize = 0;
            this.btnPrev_Panic.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_Panic.Name = "btnPrev_Panic";
            this.btnPrev_Panic.UseVisualStyleBackColor = false;
            this.btnPrev_Panic.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.ForeColor = System.Drawing.Color.Black;
            this.label54.Name = "label54";
            // 
            // btnOkNext_PanicStop
            // 
            resources.ApplyResources(this.btnOkNext_PanicStop, "btnOkNext_PanicStop");
            this.btnOkNext_PanicStop.BackColor = System.Drawing.Color.Transparent;
            this.btnOkNext_PanicStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnOkNext_PanicStop.FlatAppearance.BorderSize = 0;
            this.btnOkNext_PanicStop.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOkNext_PanicStop.Name = "btnOkNext_PanicStop";
            this.btnOkNext_PanicStop.UseVisualStyleBackColor = false;
            this.btnOkNext_PanicStop.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tab_MinimumGain
            // 
            resources.ApplyResources(this.tab_MinimumGain, "tab_MinimumGain");
            this.tab_MinimumGain.BackColor = System.Drawing.Color.White;
            this.tab_MinimumGain.Controls.Add(this.label72);
            this.tab_MinimumGain.Controls.Add(this.label79);
            this.tab_MinimumGain.Controls.Add(this.label78);
            this.tab_MinimumGain.Controls.Add(this.btnMinGainLeft);
            this.tab_MinimumGain.Controls.Add(this.btnZeroMinMovementSetting);
            this.tab_MinimumGain.Controls.Add(this.label77);
            this.tab_MinimumGain.Controls.Add(this.label76);
            this.tab_MinimumGain.Controls.Add(this.btnMinGainRight);
            this.tab_MinimumGain.Controls.Add(this.label68);
            this.tab_MinimumGain.Controls.Add(this.label15);
            this.tab_MinimumGain.Controls.Add(this.btnPrev_Gain);
            this.tab_MinimumGain.Controls.Add(this.btnOK_Next);
            this.tab_MinimumGain.Controls.Add(this.hsbarMinPWM);
            this.tab_MinimumGain.Controls.Add(this.lblMinPWM);
            this.tab_MinimumGain.Name = "tab_MinimumGain";
            this.tab_MinimumGain.Enter += new System.EventHandler(this.tab_MinimumGain_Enter);
            this.tab_MinimumGain.Leave += new System.EventHandler(this.tab_MinimumGain_Leave);
            // 
            // label72
            // 
            resources.ApplyResources(this.label72, "label72");
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label72.Name = "label72";
            // 
            // label79
            // 
            resources.ApplyResources(this.label79, "label79");
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label79.Name = "label79";
            // 
            // label78
            // 
            resources.ApplyResources(this.label78, "label78");
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label78.Name = "label78";
            // 
            // btnMinGainLeft
            // 
            resources.ApplyResources(this.btnMinGainLeft, "btnMinGainLeft");
            this.btnMinGainLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnMinGainLeft.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMinGainLeft.Image = global::AgOpenGPS.Properties.Resources.SteerLeft;
            this.btnMinGainLeft.Name = "btnMinGainLeft";
            this.btnMinGainLeft.UseVisualStyleBackColor = false;
            this.btnMinGainLeft.Click += new System.EventHandler(this.btnMinGainLeft_Click);
            // 
            // btnZeroMinMovementSetting
            // 
            resources.ApplyResources(this.btnZeroMinMovementSetting, "btnZeroMinMovementSetting");
            this.btnZeroMinMovementSetting.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnZeroMinMovementSetting.ForeColor = System.Drawing.Color.White;
            this.btnZeroMinMovementSetting.Image = global::AgOpenGPS.Properties.Resources.SteerZeroSmall;
            this.btnZeroMinMovementSetting.Name = "btnZeroMinMovementSetting";
            this.btnZeroMinMovementSetting.UseVisualStyleBackColor = true;
            this.btnZeroMinMovementSetting.Click += new System.EventHandler(this.btnZeroMinMovementSetting_Click);
            // 
            // label77
            // 
            resources.ApplyResources(this.label77, "label77");
            this.label77.ForeColor = System.Drawing.Color.Black;
            this.label77.Name = "label77";
            // 
            // label76
            // 
            resources.ApplyResources(this.label76, "label76");
            this.label76.ForeColor = System.Drawing.Color.Black;
            this.label76.Name = "label76";
            // 
            // btnMinGainRight
            // 
            resources.ApplyResources(this.btnMinGainRight, "btnMinGainRight");
            this.btnMinGainRight.BackColor = System.Drawing.Color.Transparent;
            this.btnMinGainRight.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMinGainRight.Image = global::AgOpenGPS.Properties.Resources.SteerRight;
            this.btnMinGainRight.Name = "btnMinGainRight";
            this.btnMinGainRight.UseVisualStyleBackColor = false;
            this.btnMinGainRight.Click += new System.EventHandler(this.btnMinGainRight_Click);
            // 
            // label68
            // 
            resources.ApplyResources(this.label68, "label68");
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Name = "label68";
            // 
            // btnPrev_Gain
            // 
            resources.ApplyResources(this.btnPrev_Gain, "btnPrev_Gain");
            this.btnPrev_Gain.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_Gain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_Gain.FlatAppearance.BorderSize = 0;
            this.btnPrev_Gain.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_Gain.Name = "btnPrev_Gain";
            this.btnPrev_Gain.UseVisualStyleBackColor = false;
            this.btnPrev_Gain.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnOK_Next
            // 
            resources.ApplyResources(this.btnOK_Next, "btnOK_Next");
            this.btnOK_Next.BackColor = System.Drawing.Color.Transparent;
            this.btnOK_Next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOK_Next.FlatAppearance.BorderSize = 0;
            this.btnOK_Next.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnOK_Next.Name = "btnOK_Next";
            this.btnOK_Next.UseVisualStyleBackColor = false;
            this.btnOK_Next.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabPGain
            // 
            resources.ApplyResources(this.tabPGain, "tabPGain");
            this.tabPGain.BackColor = System.Drawing.Color.White;
            this.tabPGain.Controls.Add(this.label88);
            this.tabPGain.Controls.Add(this.label83);
            this.tabPGain.Controls.Add(this.label84);
            this.tabPGain.Controls.Add(this.label4);
            this.tabPGain.Controls.Add(this.btnLeftPGain);
            this.tabPGain.Controls.Add(this.btnZeroPGain);
            this.tabPGain.Controls.Add(this.label2);
            this.tabPGain.Controls.Add(this.label85);
            this.tabPGain.Controls.Add(this.label86);
            this.tabPGain.Controls.Add(this.btnRightPGain);
            this.tabPGain.Controls.Add(this.label87);
            this.tabPGain.Controls.Add(this.hsbarHighSteerPWM);
            this.tabPGain.Controls.Add(this.btnPrev_PGain);
            this.tabPGain.Controls.Add(this.btnNext_PGain);
            this.tabPGain.Controls.Add(this.hsbarProportionalGain);
            this.tabPGain.Controls.Add(this.lblProportionalGain);
            this.tabPGain.Controls.Add(this.lblHighSteerPWM);
            this.tabPGain.Name = "tabPGain";
            this.tabPGain.Enter += new System.EventHandler(this.tabPGain_Enter);
            this.tabPGain.Leave += new System.EventHandler(this.tabPGain_Leave);
            // 
            // label88
            // 
            resources.ApplyResources(this.label88, "label88");
            this.label88.BackColor = System.Drawing.Color.Transparent;
            this.label88.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label88.Name = "label88";
            // 
            // label83
            // 
            resources.ApplyResources(this.label83, "label83");
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label83.Name = "label83";
            // 
            // label84
            // 
            resources.ApplyResources(this.label84, "label84");
            this.label84.BackColor = System.Drawing.Color.Transparent;
            this.label84.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label84.Name = "label84";
            // 
            // btnLeftPGain
            // 
            resources.ApplyResources(this.btnLeftPGain, "btnLeftPGain");
            this.btnLeftPGain.BackColor = System.Drawing.Color.Transparent;
            this.btnLeftPGain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnLeftPGain.FlatAppearance.BorderSize = 0;
            this.btnLeftPGain.Image = global::AgOpenGPS.Properties.Resources.SteerLeft;
            this.btnLeftPGain.Name = "btnLeftPGain";
            this.btnLeftPGain.UseVisualStyleBackColor = false;
            this.btnLeftPGain.Click += new System.EventHandler(this.btnLeftPGain_Click);
            // 
            // btnZeroPGain
            // 
            resources.ApplyResources(this.btnZeroPGain, "btnZeroPGain");
            this.btnZeroPGain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZeroPGain.FlatAppearance.BorderSize = 0;
            this.btnZeroPGain.ForeColor = System.Drawing.Color.White;
            this.btnZeroPGain.Image = global::AgOpenGPS.Properties.Resources.SteerZeroSmall;
            this.btnZeroPGain.Name = "btnZeroPGain";
            this.btnZeroPGain.UseVisualStyleBackColor = true;
            this.btnZeroPGain.Click += new System.EventHandler(this.btnZeroPGain_Click);
            // 
            // label85
            // 
            resources.ApplyResources(this.label85, "label85");
            this.label85.ForeColor = System.Drawing.Color.Black;
            this.label85.Name = "label85";
            // 
            // label86
            // 
            resources.ApplyResources(this.label86, "label86");
            this.label86.ForeColor = System.Drawing.Color.Black;
            this.label86.Name = "label86";
            // 
            // btnRightPGain
            // 
            resources.ApplyResources(this.btnRightPGain, "btnRightPGain");
            this.btnRightPGain.BackColor = System.Drawing.Color.Transparent;
            this.btnRightPGain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnRightPGain.FlatAppearance.BorderSize = 0;
            this.btnRightPGain.Image = global::AgOpenGPS.Properties.Resources.SteerRight;
            this.btnRightPGain.Name = "btnRightPGain";
            this.btnRightPGain.UseVisualStyleBackColor = false;
            this.btnRightPGain.Click += new System.EventHandler(this.btnRightPGain_Click);
            // 
            // label87
            // 
            resources.ApplyResources(this.label87, "label87");
            this.label87.BackColor = System.Drawing.Color.Transparent;
            this.label87.ForeColor = System.Drawing.Color.Black;
            this.label87.Name = "label87";
            // 
            // btnPrev_PGain
            // 
            resources.ApplyResources(this.btnPrev_PGain, "btnPrev_PGain");
            this.btnPrev_PGain.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_PGain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_PGain.FlatAppearance.BorderSize = 0;
            this.btnPrev_PGain.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_PGain.Name = "btnPrev_PGain";
            this.btnPrev_PGain.UseVisualStyleBackColor = false;
            this.btnPrev_PGain.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext_PGain
            // 
            resources.ApplyResources(this.btnNext_PGain, "btnNext_PGain");
            this.btnNext_PGain.BackColor = System.Drawing.Color.Transparent;
            this.btnNext_PGain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext_PGain.FlatAppearance.BorderSize = 0;
            this.btnNext_PGain.Image = global::AgOpenGPS.Properties.Resources.Next;
            this.btnNext_PGain.Name = "btnNext_PGain";
            this.btnNext_PGain.UseVisualStyleBackColor = false;
            this.btnNext_PGain.Click += new System.EventHandler(this.btnOkNext_Click);
            // 
            // tabEnd
            // 
            resources.ApplyResources(this.tabEnd, "tabEnd");
            this.tabEnd.BackColor = System.Drawing.Color.White;
            this.tabEnd.Controls.Add(this.label116);
            this.tabEnd.Controls.Add(this.btnRestartWizard);
            this.tabEnd.Controls.Add(this.label69);
            this.tabEnd.Controls.Add(this.btnPrev_End);
            this.tabEnd.Controls.Add(this.btnExit);
            this.tabEnd.Name = "tabEnd";
            // 
            // label116
            // 
            resources.ApplyResources(this.label116, "label116");
            this.label116.BackColor = System.Drawing.Color.Transparent;
            this.label116.ForeColor = System.Drawing.Color.Black;
            this.label116.Name = "label116";
            // 
            // btnRestartWizard
            // 
            resources.ApplyResources(this.btnRestartWizard, "btnRestartWizard");
            this.btnRestartWizard.BackColor = System.Drawing.Color.LightBlue;
            this.btnRestartWizard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnRestartWizard.FlatAppearance.BorderSize = 0;
            this.btnRestartWizard.Name = "btnRestartWizard";
            this.btnRestartWizard.UseVisualStyleBackColor = false;
            this.btnRestartWizard.Click += new System.EventHandler(this.btnRestartWizard_Click);
            // 
            // label69
            // 
            resources.ApplyResources(this.label69, "label69");
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.ForeColor = System.Drawing.Color.Black;
            this.label69.Name = "label69";
            // 
            // btnPrev_End
            // 
            resources.ApplyResources(this.btnPrev_End, "btnPrev_End");
            this.btnPrev_End.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev_End.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev_End.FlatAppearance.BorderSize = 0;
            this.btnPrev_End.Image = global::AgOpenGPS.Properties.Resources.Previous;
            this.btnPrev_End.Name = "btnPrev_End";
            this.btnPrev_End.UseVisualStyleBackColor = false;
            this.btnPrev_End.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStopWizard
            // 
            resources.ApplyResources(this.btnStopWizard, "btnStopWizard");
            this.btnStopWizard.BackColor = System.Drawing.Color.LightCoral;
            this.btnStopWizard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnStopWizard.Name = "btnStopWizard";
            this.btnStopWizard.UseVisualStyleBackColor = false;
            this.btnStopWizard.Click += new System.EventHandler(this.btnStopWizard_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tabWiz);
            this.panel3.Name = "panel3";
            // 
            // pbarProgress
            // 
            resources.ApplyResources(this.pbarProgress, "pbarProgress");
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Step = 1;
            // 
            // label71
            // 
            resources.ApplyResources(this.label71, "label71");
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.ForeColor = System.Drawing.Color.Black;
            this.label71.Name = "label71";
            // 
            // lblBarCPD
            // 
            resources.ApplyResources(this.lblBarCPD, "lblBarCPD");
            this.lblBarCPD.ForeColor = System.Drawing.Color.Black;
            this.lblBarCPD.Name = "lblBarCPD";
            // 
            // label66
            // 
            resources.ApplyResources(this.label66, "label66");
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label66.Name = "label66";
            // 
            // label65
            // 
            resources.ApplyResources(this.label65, "label65");
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label65.Name = "label65";
            // 
            // lblBarAck
            // 
            resources.ApplyResources(this.lblBarAck, "lblBarAck");
            this.lblBarAck.ForeColor = System.Drawing.Color.Black;
            this.lblBarAck.Name = "lblBarAck";
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Enabled = true;
            this.sideBarTimer.Interval = 1000;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // label67
            // 
            resources.ApplyResources(this.label67, "label67");
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label67.Name = "label67";
            // 
            // lblBarWasOffset
            // 
            resources.ApplyResources(this.lblBarWasOffset, "lblBarWasOffset");
            this.lblBarWasOffset.ForeColor = System.Drawing.Color.Black;
            this.lblBarWasOffset.Name = "lblBarWasOffset";
            // 
            // btnCloseAll
            // 
            resources.ApplyResources(this.btnCloseAll, "btnCloseAll");
            this.btnCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCloseAll.Image = global::AgOpenGPS.Properties.Resources.boundaryStop;
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.UseVisualStyleBackColor = false;
            this.btnCloseAll.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSteerWiz
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.lblBarWasOffset);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.lblBarAck);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.lblBarCPD);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.pbarProgress);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnStopWizard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MinimizeBox = false;
            this.Name = "FormSteerWiz";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSteer_FormClosing);
            this.Load += new System.EventHandler(this.FormSteer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSteer.ResumeLayout(false);
            this.tabSteer.PerformLayout();
            this.tabStan.ResumeLayout(false);
            this.tabInt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCounts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanicStopSpeed)).EndInit();
            this.tabWiz.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabLoadDef.ResumeLayout(false);
            this.tabLoadDef.PerformLayout();
            this.tabWheelBase.ResumeLayout(false);
            this.tabWheelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWheelbase)).EndInit();
            this.tabWheelTrack.ResumeLayout(false);
            this.tabWheelTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleTrack)).EndInit();
            this.tabAntennaDistance.ResumeLayout(false);
            this.tabAntennaDistance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaPivot)).EndInit();
            this.tabAntennaHeight.ResumeLayout(false);
            this.tabAntennaHeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaHeight)).EndInit();
            this.tabAntennaOffset.ResumeLayout(false);
            this.tabAntennaOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntennaOffset)).EndInit();
            this.tabButtonSwitch.ResumeLayout(false);
            this.tabButtonSwitch.PerformLayout();
            this.tabA2DConv.ResumeLayout(false);
            this.tabA2DConv.PerformLayout();
            this.tabMotorDriver.ResumeLayout(false);
            this.tabMotorDriver.PerformLayout();
            this.tabInvertRelays.ResumeLayout(false);
            this.tabInvertRelays.PerformLayout();
            this.tabDanfoss.ResumeLayout(false);
            this.tabDanfoss.PerformLayout();
            this.tabRollInv.ResumeLayout(false);
            this.tabRollInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tabRollZero.ResumeLayout(false);
            this.tabRollZero.PerformLayout();
            this.tabWAS.ResumeLayout(false);
            this.tabWAS.PerformLayout();
            this.tabWAS_Zero.ResumeLayout(false);
            this.tabWAS_Zero.PerformLayout();
            this.tabMotorDirection.ResumeLayout(false);
            this.tabMotorDirection.PerformLayout();
            this.tabCPD_Setup.ResumeLayout(false);
            this.tabCPD_Setup.PerformLayout();
            this.tabCountsPerDeg.ResumeLayout(false);
            this.tabCountsPerDeg.PerformLayout();
            this.tabAckCPD.ResumeLayout(false);
            this.tabAckCPD.PerformLayout();
            this.tabMaxSteerAngle.ResumeLayout(false);
            this.tabMaxSteerAngle.PerformLayout();
            this.tabCancelGuidance.ResumeLayout(false);
            this.tabCancelGuidance.PerformLayout();
            this.tabPanicStop.ResumeLayout(false);
            this.tabPanicStop.PerformLayout();
            this.tab_MinimumGain.ResumeLayout(false);
            this.tab_MinimumGain.PerformLayout();
            this.tabPGain.ResumeLayout(false);
            this.tabPGain.PerformLayout();
            this.tabEnd.ResumeLayout(false);
            this.tabEnd.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.Label lblHighSteerPWM;
        private System.Windows.Forms.HScrollBar hsbarHighSteerPWM;
        private System.Windows.Forms.Label lblLowSteerPWM;
        private System.Windows.Forms.HScrollBar hsbarLowSteerPWM;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabSteer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbarRight;
        private System.Windows.Forms.ProgressBar pbarLeft;
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
        private System.Windows.Forms.CheckBox cboxDanfoss;
        private System.Windows.Forms.CheckBox chkSteerInvertRelays;
        private System.Windows.Forms.CheckBox chkInvertSteer;
        private System.Windows.Forms.CheckBox cboxEncoder;
        private System.Windows.Forms.CheckBox chkInvertWAS;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hsbarSensor;
        private System.Windows.Forms.Label lblhsbarSensor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudPanicStopSpeed;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TabControl tabWiz;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.TabPage tabMotorDriver;
        private System.Windows.Forms.TabPage tabMotorDirection;
        private System.Windows.Forms.Button btnSteerLeft;
        private System.Windows.Forms.Button btnSteerRight;
        private System.Windows.Forms.TabPage tabWAS;
        private System.Windows.Forms.TabPage tabButtonSwitch;
        private System.Windows.Forms.Button btnStartWizard;
        private System.Windows.Forms.Button btnStopWizard;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabCancelGuidance;
        private System.Windows.Forms.TabPage tabWAS_Zero;
        private System.Windows.Forms.TabPage tabCountsPerDeg;
        private System.Windows.Forms.Button btnOkWAS;
        private System.Windows.Forms.Button btnOkNext_MotorDriver;
        private System.Windows.Forms.Button btnOkNext_MotorDirection;
        private System.Windows.Forms.Button btnOkNext_WAS_Zero;
        private System.Windows.Forms.Button btnOkNext_CountsPerDeg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOkNext_ButtonSwitch;
        private System.Windows.Forms.TabPage tabMaxSteerAngle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnOkNextMaxSteerAngle;
        private System.Windows.Forms.TabPage tabA2DConv;
        private System.Windows.Forms.Button btnOkNext_A2D;
        private System.Windows.Forms.TabPage tabInvertRelays;
        private System.Windows.Forms.TabPage tabDanfoss;
        private System.Windows.Forms.Button btnOkNext_InvertRelays;
        private System.Windows.Forms.Button btnOkNext_Danfoss;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btnOkNextCancelGuidance;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button btnSteerStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPanicStop;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button btnOkNext_PanicStop;
        private System.Windows.Forms.Button btnPrev_A2D;
        private System.Windows.Forms.Button btnPrev_MotorDriver;
        private System.Windows.Forms.Button btnPrev_InvertRelays;
        private System.Windows.Forms.Button btnPrev_Danfoss;
        private System.Windows.Forms.Button btnPrev_InvertWAS;
        private System.Windows.Forms.Button btnPrev_MotorDirection;
        private System.Windows.Forms.Button btnPrev_CountsPerDegree;
        private System.Windows.Forms.Button btnPrev_MaxSteerAngle;
        private System.Windows.Forms.Button btnPrev_CancelGuidance;
        private System.Windows.Forms.Button btnPrev_Panic;
        private System.Windows.Forms.TabPage tabEnd;
        private System.Windows.Forms.Button btnPrev_End;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TabPage tabCPD_Setup;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Button btnSkipCPD_Setup;
        private System.Windows.Forms.Button btnOKNext_CPDSetup;
        private System.Windows.Forms.Button btnRestartWizard;
        private System.Windows.Forms.Button btnRemoveWasOffset;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button btnLoadDefaults;
        private System.Windows.Forms.Label lblBarCPD;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lblBarAck;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label lblBarWasOffset;
        private System.Windows.Forms.Label lblCPDError;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TabPage tab_MinimumGain;
        private System.Windows.Forms.Button btnPrev_Gain;
        private System.Windows.Forms.Button btnOK_Next;
        private System.Windows.Forms.Button btnMinGainRight;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button btnOkSetMaximumSteerAngle;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button btnZeroMinMovementSetting;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Button btnMinGainLeft;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TabPage tabLoadDef;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Button btnOkNext_LoadDefault;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TabPage tabPGain;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Button btnLeftPGain;
        private System.Windows.Forms.Button btnZeroPGain;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Button btnRightPGain;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Button btnPrev_PGain;
        private System.Windows.Forms.Button btnNext_PGain;
        private System.Windows.Forms.TabPage tabWheelBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.NumericUpDown nudWheelbase;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabWheelTrack;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.NumericUpDown nudVehicleTrack;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage tabAntennaDistance;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.NumericUpDown nudAntennaPivot;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage tabAntennaOffset;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.NumericUpDown nudAntennaOffset;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabPage tabAntennaHeight;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.NumericUpDown nudAntennaHeight;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TabPage tabRollInv;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TabPage tabAckCPD;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label lblAckermannError;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label lblDiameterLeft;
        private System.Windows.Forms.Label lblCalcSteerAngleLeft;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnStartSA_Left;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.HScrollBar hsbarAckerman;
        private System.Windows.Forms.Label lblAckerman;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label lblStartAngleLeft;
        private System.Windows.Forms.Button btnAckReset;
        private System.Windows.Forms.Label lblCurrentHeading;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.CheckBox cboxDataInvertRoll;
        private System.Windows.Forms.TabPage tabRollZero;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label lblRoll2;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label lblRollZeroOffset;
        private System.Windows.Forms.Button btnZeroRoll;
        private System.Windows.Forms.Button btnRemoveZeroOffset;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label lblRightStartAngle;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
    }
}