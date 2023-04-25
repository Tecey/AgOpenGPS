namespace AgOpenGPS
{
    partial class FormHeadland
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeadland));
            this.oglSelf = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.btnDeletePoints = new System.Windows.Forms.Button();
            this.btnMakeFixedHeadland = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nudSetDistance = new System.Windows.Forms.NumericUpDown();
            this.btnSetDistance = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTurnOffHeadland = new System.Windows.Forms.Button();
            this.cboxToolWidths = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeadlandWidth = new System.Windows.Forms.Label();
            this.lblWidthUnits = new System.Windows.Forms.Label();
            this.cboxIsSectionControlled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // oglSelf
            // 
            resources.ApplyResources(this.oglSelf, "oglSelf");
            this.oglSelf.BackColor = System.Drawing.Color.Black;
            this.oglSelf.Cursor = System.Windows.Forms.Cursors.Cross;
            this.oglSelf.Name = "oglSelf";
            this.oglSelf.VSync = false;
            this.oglSelf.Load += new System.EventHandler(this.oglSelf_Load);
            this.oglSelf.Paint += new System.Windows.Forms.PaintEventHandler(this.oglSelf_Paint);
            this.oglSelf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oglSelf_MouseDown);
            this.oglSelf.Resize += new System.EventHandler(this.oglSelf_Resize);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nudDistance
            // 
            resources.ApplyResources(this.nudDistance, "nudDistance");
            this.nudDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.nudDistance.DecimalPlaces = 1;
            this.nudDistance.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.ReadOnly = true;
            this.nudDistance.Click += new System.EventHandler(this.nudDistance_Click);
            this.nudDistance.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nudDistance_HelpRequested);
            // 
            // btnDeletePoints
            // 
            resources.ApplyResources(this.btnDeletePoints, "btnDeletePoints");
            this.btnDeletePoints.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePoints.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeletePoints.Image = global::AgOpenGPS.Properties.Resources.HeadlandDeletePoints;
            this.btnDeletePoints.Name = "btnDeletePoints";
            this.btnDeletePoints.UseVisualStyleBackColor = false;
            this.btnDeletePoints.Click += new System.EventHandler(this.btnDeletePoints_Click);
            this.btnDeletePoints.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDeletePoints_HelpRequested);
            // 
            // btnMakeFixedHeadland
            // 
            resources.ApplyResources(this.btnMakeFixedHeadland, "btnMakeFixedHeadland");
            this.btnMakeFixedHeadland.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeFixedHeadland.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnMakeFixedHeadland.FlatAppearance.BorderSize = 0;
            this.btnMakeFixedHeadland.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnMakeFixedHeadland.Name = "btnMakeFixedHeadland";
            this.btnMakeFixedHeadland.UseVisualStyleBackColor = false;
            this.btnMakeFixedHeadland.Click += new System.EventHandler(this.btnMakeFixedHeadland_Click);
            this.btnMakeFixedHeadland.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnMakeFixedHeadland_HelpRequested);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnExit_HelpRequested);
            // 
            // nudSetDistance
            // 
            resources.ApplyResources(this.nudSetDistance, "nudSetDistance");
            this.nudSetDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSetDistance.DecimalPlaces = 1;
            this.nudSetDistance.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudSetDistance.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.nudSetDistance.Name = "nudSetDistance";
            this.nudSetDistance.ReadOnly = true;
            this.nudSetDistance.Click += new System.EventHandler(this.nudSetDistance_Click);
            this.nudSetDistance.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nudSetDistance_HelpRequested);
            // 
            // btnSetDistance
            // 
            resources.ApplyResources(this.btnSetDistance, "btnSetDistance");
            this.btnSetDistance.BackColor = System.Drawing.Color.Transparent;
            this.btnSetDistance.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSetDistance.Image = global::AgOpenGPS.Properties.Resources.HeadlandTouchSave;
            this.btnSetDistance.Name = "btnSetDistance";
            this.btnSetDistance.UseVisualStyleBackColor = false;
            this.btnSetDistance.Click += new System.EventHandler(this.btnSetDistance_Click);
            this.btnSetDistance.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSetDistance_HelpRequested);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = global::AgOpenGPS.Properties.Resources.back_button;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnReset_HelpRequested);
            // 
            // btnTurnOffHeadland
            // 
            resources.ApplyResources(this.btnTurnOffHeadland, "btnTurnOffHeadland");
            this.btnTurnOffHeadland.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnOffHeadland.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnTurnOffHeadland.FlatAppearance.BorderSize = 0;
            this.btnTurnOffHeadland.Image = global::AgOpenGPS.Properties.Resources.SwitchOff;
            this.btnTurnOffHeadland.Name = "btnTurnOffHeadland";
            this.btnTurnOffHeadland.UseVisualStyleBackColor = false;
            this.btnTurnOffHeadland.Click += new System.EventHandler(this.btnTurnOffHeadland_Click);
            this.btnTurnOffHeadland.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnTurnOffHeadland_HelpRequested);
            // 
            // cboxToolWidths
            // 
            resources.ApplyResources(this.cboxToolWidths, "cboxToolWidths");
            this.cboxToolWidths.BackColor = System.Drawing.Color.Lavender;
            this.cboxToolWidths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxToolWidths.FormattingEnabled = true;
            this.cboxToolWidths.Items.AddRange(new object[] {
            resources.GetString("cboxToolWidths.Items"),
            resources.GetString("cboxToolWidths.Items1"),
            resources.GetString("cboxToolWidths.Items2"),
            resources.GetString("cboxToolWidths.Items3"),
            resources.GetString("cboxToolWidths.Items4"),
            resources.GetString("cboxToolWidths.Items5"),
            resources.GetString("cboxToolWidths.Items6"),
            resources.GetString("cboxToolWidths.Items7"),
            resources.GetString("cboxToolWidths.Items8"),
            resources.GetString("cboxToolWidths.Items9"),
            resources.GetString("cboxToolWidths.Items10"),
            resources.GetString("cboxToolWidths.Items11"),
            resources.GetString("cboxToolWidths.Items12"),
            resources.GetString("cboxToolWidths.Items13"),
            resources.GetString("cboxToolWidths.Items14")});
            this.cboxToolWidths.Name = "cboxToolWidths";
            this.cboxToolWidths.SelectedIndexChanged += new System.EventHandler(this.cboxToolWidths_SelectedIndexChanged);
            this.cboxToolWidths.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxToolWidths_HelpRequested);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // lblHeadlandWidth
            // 
            resources.ApplyResources(this.lblHeadlandWidth, "lblHeadlandWidth");
            this.lblHeadlandWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadlandWidth.ForeColor = System.Drawing.Color.Black;
            this.lblHeadlandWidth.Name = "lblHeadlandWidth";
            // 
            // lblWidthUnits
            // 
            resources.ApplyResources(this.lblWidthUnits, "lblWidthUnits");
            this.lblWidthUnits.BackColor = System.Drawing.Color.Transparent;
            this.lblWidthUnits.ForeColor = System.Drawing.Color.Black;
            this.lblWidthUnits.Name = "lblWidthUnits";
            // 
            // cboxIsSectionControlled
            // 
            resources.ApplyResources(this.cboxIsSectionControlled, "cboxIsSectionControlled");
            this.cboxIsSectionControlled.BackColor = System.Drawing.Color.Transparent;
            this.cboxIsSectionControlled.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cboxIsSectionControlled.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.cboxIsSectionControlled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxIsSectionControlled.Image = global::AgOpenGPS.Properties.Resources.SectionMasterOff;
            this.cboxIsSectionControlled.Name = "cboxIsSectionControlled";
            this.cboxIsSectionControlled.UseVisualStyleBackColor = false;
            this.cboxIsSectionControlled.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cboxIsSectionControlled_HelpRequested);
            // 
            // FormHeadland
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.cboxIsSectionControlled);
            this.Controls.Add(this.lblWidthUnits);
            this.Controls.Add(this.lblHeadlandWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxToolWidths);
            this.Controls.Add(this.btnTurnOffHeadland);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSetDistance);
            this.Controls.Add(this.nudSetDistance);
            this.Controls.Add(this.btnDeletePoints);
            this.Controls.Add(this.btnMakeFixedHeadland);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.oglSelf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHeadland";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHeadland_FormClosing);
            this.Load += new System.EventHandler(this.FormHeadland_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Button btnMakeFixedHeadland;
        private System.Windows.Forms.Button btnDeletePoints;
        private System.Windows.Forms.NumericUpDown nudSetDistance;
        private System.Windows.Forms.Button btnSetDistance;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTurnOffHeadland;
        private System.Windows.Forms.ComboBox cboxToolWidths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeadlandWidth;
        private System.Windows.Forms.Label lblWidthUnits;
        private System.Windows.Forms.CheckBox cboxIsSectionControlled;
    }
}