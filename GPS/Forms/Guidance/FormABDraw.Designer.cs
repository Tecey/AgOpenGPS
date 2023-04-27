namespace AgOpenGPS
{
    partial class FormABDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABDraw));
            this.oglSelf = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNumCu = new System.Windows.Forms.Label();
            this.lblNumAB = new System.Windows.Forms.Label();
            this.lblABSelected = new System.Windows.Forms.Label();
            this.lblCurveSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxNameCurve = new System.Windows.Forms.TextBox();
            this.tboxNameLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFlipOffset = new System.Windows.Forms.Button();
            this.btnMakeBoundaryCurve = new System.Windows.Forms.Button();
            this.btnDrawSections = new System.Windows.Forms.Button();
            this.btnCancelTouch = new System.Windows.Forms.Button();
            this.btnDeleteABLine = new System.Windows.Forms.Button();
            this.btnDeleteCurve = new System.Windows.Forms.Button();
            this.btnSelectABLine = new System.Windows.Forms.Button();
            this.btnSelectCurve = new System.Windows.Forms.Button();
            this.btnMakeCurve = new System.Windows.Forms.Button();
            this.btnMakeABLine = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCmInch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
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
            this.oglSelf.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.oglSelf_HelpRequested);
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
            // lblNumCu
            // 
            resources.ApplyResources(this.lblNumCu, "lblNumCu");
            this.lblNumCu.ForeColor = System.Drawing.Color.Black;
            this.lblNumCu.Name = "lblNumCu";
            // 
            // lblNumAB
            // 
            resources.ApplyResources(this.lblNumAB, "lblNumAB");
            this.lblNumAB.ForeColor = System.Drawing.Color.Black;
            this.lblNumAB.Name = "lblNumAB";
            // 
            // lblABSelected
            // 
            resources.ApplyResources(this.lblABSelected, "lblABSelected");
            this.lblABSelected.ForeColor = System.Drawing.Color.Black;
            this.lblABSelected.Name = "lblABSelected";
            // 
            // lblCurveSelected
            // 
            resources.ApplyResources(this.lblCurveSelected, "lblCurveSelected");
            this.lblCurveSelected.ForeColor = System.Drawing.Color.Black;
            this.lblCurveSelected.Name = "lblCurveSelected";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // nudDistance
            // 
            resources.ApplyResources(this.nudDistance, "nudDistance");
            this.nudDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.nudDistance.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudDistance.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.ReadOnly = true;
            this.nudDistance.Click += new System.EventHandler(this.nudDistance_Click);
            this.nudDistance.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nudDistance_HelpRequested);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // tboxNameCurve
            // 
            resources.ApplyResources(this.tboxNameCurve, "tboxNameCurve");
            this.tboxNameCurve.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tboxNameCurve.CausesValidation = false;
            this.tboxNameCurve.Name = "tboxNameCurve";
            this.tboxNameCurve.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.tboxNameCurve_HelpRequested);
            this.tboxNameCurve.Enter += new System.EventHandler(this.tboxNameCurve_Enter);
            this.tboxNameCurve.Leave += new System.EventHandler(this.tboxNameCurve_Leave);
            // 
            // tboxNameLine
            // 
            resources.ApplyResources(this.tboxNameLine, "tboxNameLine");
            this.tboxNameLine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tboxNameLine.CausesValidation = false;
            this.tboxNameLine.Name = "tboxNameLine";
            this.tboxNameLine.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.tboxNameLine_HelpRequested);
            this.tboxNameLine.Enter += new System.EventHandler(this.tboxNameLine_Enter);
            this.tboxNameLine.Leave += new System.EventHandler(this.tboxNameLine_Leave);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // btnFlipOffset
            // 
            resources.ApplyResources(this.btnFlipOffset, "btnFlipOffset");
            this.btnFlipOffset.BackColor = System.Drawing.Color.Transparent;
            this.btnFlipOffset.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnFlipOffset.FlatAppearance.BorderSize = 0;
            this.btnFlipOffset.Image = global::AgOpenGPS.Properties.Resources.ABSwapPoints;
            this.btnFlipOffset.Name = "btnFlipOffset";
            this.btnFlipOffset.UseVisualStyleBackColor = false;
            this.btnFlipOffset.Click += new System.EventHandler(this.btnFlipOffset_Click);
            this.btnFlipOffset.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnFlipOffset_HelpRequested);
            // 
            // btnMakeBoundaryCurve
            // 
            resources.ApplyResources(this.btnMakeBoundaryCurve, "btnMakeBoundaryCurve");
            this.btnMakeBoundaryCurve.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeBoundaryCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnMakeBoundaryCurve.FlatAppearance.BorderSize = 0;
            this.btnMakeBoundaryCurve.Image = global::AgOpenGPS.Properties.Resources.BoundaryCurveLine;
            this.btnMakeBoundaryCurve.Name = "btnMakeBoundaryCurve";
            this.btnMakeBoundaryCurve.UseVisualStyleBackColor = false;
            this.btnMakeBoundaryCurve.Click += new System.EventHandler(this.btnMakeBoundaryCurve_Click);
            this.btnMakeBoundaryCurve.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnMakeBoundaryCurve_HelpRequested);
            // 
            // btnDrawSections
            // 
            resources.ApplyResources(this.btnDrawSections, "btnDrawSections");
            this.btnDrawSections.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawSections.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDrawSections.FlatAppearance.BorderSize = 0;
            this.btnDrawSections.Image = global::AgOpenGPS.Properties.Resources.MappingOff;
            this.btnDrawSections.Name = "btnDrawSections";
            this.btnDrawSections.UseVisualStyleBackColor = false;
            this.btnDrawSections.Click += new System.EventHandler(this.btnDrawSections_Click);
            this.btnDrawSections.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDrawSections_HelpRequested);
            // 
            // btnCancelTouch
            // 
            resources.ApplyResources(this.btnCancelTouch, "btnCancelTouch");
            this.btnCancelTouch.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelTouch.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelTouch.FlatAppearance.BorderSize = 0;
            this.btnCancelTouch.Image = global::AgOpenGPS.Properties.Resources.HeadlandDeletePoints;
            this.btnCancelTouch.Name = "btnCancelTouch";
            this.btnCancelTouch.UseVisualStyleBackColor = false;
            this.btnCancelTouch.Click += new System.EventHandler(this.btnCancelTouch_Click);
            this.btnCancelTouch.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancelTouch_HelpRequested);
            // 
            // btnDeleteABLine
            // 
            resources.ApplyResources(this.btnDeleteABLine, "btnDeleteABLine");
            this.btnDeleteABLine.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteABLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteABLine.FlatAppearance.BorderSize = 0;
            this.btnDeleteABLine.Image = global::AgOpenGPS.Properties.Resources.ABLineDelete;
            this.btnDeleteABLine.Name = "btnDeleteABLine";
            this.btnDeleteABLine.UseVisualStyleBackColor = false;
            this.btnDeleteABLine.Click += new System.EventHandler(this.btnDeleteABLine_Click);
            this.btnDeleteABLine.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDeleteABLine_HelpRequested);
            // 
            // btnDeleteCurve
            // 
            resources.ApplyResources(this.btnDeleteCurve, "btnDeleteCurve");
            this.btnDeleteCurve.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteCurve.FlatAppearance.BorderSize = 0;
            this.btnDeleteCurve.Image = global::AgOpenGPS.Properties.Resources.HideContour;
            this.btnDeleteCurve.Name = "btnDeleteCurve";
            this.btnDeleteCurve.UseVisualStyleBackColor = false;
            this.btnDeleteCurve.Click += new System.EventHandler(this.btnDeleteCurve_Click);
            this.btnDeleteCurve.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDeleteCurve_HelpRequested);
            // 
            // btnSelectABLine
            // 
            resources.ApplyResources(this.btnSelectABLine, "btnSelectABLine");
            this.btnSelectABLine.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectABLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectABLine.FlatAppearance.BorderSize = 0;
            this.btnSelectABLine.Image = global::AgOpenGPS.Properties.Resources.ABLineCycle;
            this.btnSelectABLine.Name = "btnSelectABLine";
            this.btnSelectABLine.UseVisualStyleBackColor = false;
            this.btnSelectABLine.Click += new System.EventHandler(this.btnSelectABLine_Click);
            this.btnSelectABLine.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSelectABLine_HelpRequested);
            // 
            // btnSelectCurve
            // 
            resources.ApplyResources(this.btnSelectCurve, "btnSelectCurve");
            this.btnSelectCurve.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectCurve.FlatAppearance.BorderSize = 0;
            this.btnSelectCurve.Image = global::AgOpenGPS.Properties.Resources.ABLineCycle;
            this.btnSelectCurve.Name = "btnSelectCurve";
            this.btnSelectCurve.UseVisualStyleBackColor = false;
            this.btnSelectCurve.Click += new System.EventHandler(this.btnSelectCurve_Click);
            this.btnSelectCurve.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSelectCurve_HelpRequested);
            // 
            // btnMakeCurve
            // 
            resources.ApplyResources(this.btnMakeCurve, "btnMakeCurve");
            this.btnMakeCurve.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnMakeCurve.FlatAppearance.BorderSize = 0;
            this.btnMakeCurve.Image = global::AgOpenGPS.Properties.Resources.CurveOn;
            this.btnMakeCurve.Name = "btnMakeCurve";
            this.btnMakeCurve.UseVisualStyleBackColor = false;
            this.btnMakeCurve.Click += new System.EventHandler(this.BtnMakeCurve_Click);
            this.btnMakeCurve.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnMakeCurve_HelpRequested);
            // 
            // btnMakeABLine
            // 
            resources.ApplyResources(this.btnMakeABLine, "btnMakeABLine");
            this.btnMakeABLine.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeABLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnMakeABLine.FlatAppearance.BorderSize = 0;
            this.btnMakeABLine.Image = global::AgOpenGPS.Properties.Resources.ABLineOn;
            this.btnMakeABLine.Name = "btnMakeABLine";
            this.btnMakeABLine.UseVisualStyleBackColor = false;
            this.btnMakeABLine.Click += new System.EventHandler(this.BtnMakeABLine_Click);
            this.btnMakeABLine.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnMakeABLine_HelpRequested);
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
            // lblCmInch
            // 
            resources.ApplyResources(this.lblCmInch, "lblCmInch");
            this.lblCmInch.ForeColor = System.Drawing.Color.Black;
            this.lblCmInch.Name = "lblCmInch";
            // 
            // FormABDraw
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnFlipOffset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxNameLine);
            this.Controls.Add(this.tboxNameCurve);
            this.Controls.Add(this.btnMakeBoundaryCurve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDrawSections);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.btnCancelTouch);
            this.Controls.Add(this.lblABSelected);
            this.Controls.Add(this.lblCurveSelected);
            this.Controls.Add(this.lblNumAB);
            this.Controls.Add(this.lblNumCu);
            this.Controls.Add(this.btnDeleteABLine);
            this.Controls.Add(this.btnDeleteCurve);
            this.Controls.Add(this.btnSelectABLine);
            this.Controls.Add(this.btnSelectCurve);
            this.Controls.Add(this.btnMakeCurve);
            this.Controls.Add(this.btnMakeABLine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.oglSelf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCmInch);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormABDraw";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormABDraw_FormClosing);
            this.Load += new System.EventHandler(this.FormABDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakeABLine;
        private System.Windows.Forms.Button btnMakeCurve;
        private System.Windows.Forms.Button btnSelectCurve;
        private System.Windows.Forms.Button btnSelectABLine;
        private System.Windows.Forms.Button btnDeleteCurve;
        private System.Windows.Forms.Button btnDeleteABLine;
        private System.Windows.Forms.Label lblNumCu;
        private System.Windows.Forms.Label lblNumAB;
        private System.Windows.Forms.Label lblABSelected;
        private System.Windows.Forms.Label lblCurveSelected;
        private System.Windows.Forms.Button btnCancelTouch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDrawSections;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMakeBoundaryCurve;
        private System.Windows.Forms.TextBox tboxNameCurve;
        private System.Windows.Forms.TextBox tboxNameLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFlipOffset;
        private System.Windows.Forms.Label lblCmInch;
    }
}