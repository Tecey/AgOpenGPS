namespace AgOpenGPS
{
    partial class FormEditAB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAB));
            this.label1 = new System.Windows.Forms.Label();
            this.lblHalfSnapFtM = new System.Windows.Forms.Label();
            this.lblHalfWidth = new System.Windows.Forms.Label();
            this.btnNoSave = new System.Windows.Forms.Button();
            this.btnLeftHalfWidth = new System.Windows.Forms.Button();
            this.btnRightHalfWidth = new System.Windows.Forms.Button();
            this.btnContourPriority = new System.Windows.Forms.Button();
            this.btnSwapAB = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAdjLeft = new System.Windows.Forms.Button();
            this.btnAdjRight = new System.Windows.Forms.Button();
            this.tboxHeading = new System.Windows.Forms.TextBox();
            this.cboxDegrees = new System.Windows.Forms.ComboBox();
            this.nudMinTurnRadius = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTurnRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblHalfSnapFtM
            // 
            resources.ApplyResources(this.lblHalfSnapFtM, "lblHalfSnapFtM");
            this.lblHalfSnapFtM.Name = "lblHalfSnapFtM";
            // 
            // lblHalfWidth
            // 
            resources.ApplyResources(this.lblHalfWidth, "lblHalfWidth");
            this.lblHalfWidth.Name = "lblHalfWidth";
            // 
            // btnNoSave
            // 
            resources.ApplyResources(this.btnNoSave, "btnNoSave");
            this.btnNoSave.FlatAppearance.BorderSize = 0;
            this.btnNoSave.Image = global::AgOpenGPS.Properties.Resources.FileDontSave;
            this.btnNoSave.Name = "btnNoSave";
            this.btnNoSave.UseVisualStyleBackColor = true;
            this.btnNoSave.Click += new System.EventHandler(this.btnNoSave_Click);
            this.btnNoSave.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnNoSave_HelpRequested);
            // 
            // btnLeftHalfWidth
            // 
            resources.ApplyResources(this.btnLeftHalfWidth, "btnLeftHalfWidth");
            this.btnLeftHalfWidth.BackColor = System.Drawing.Color.Transparent;
            this.btnLeftHalfWidth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnLeftHalfWidth.FlatAppearance.BorderSize = 0;
            this.btnLeftHalfWidth.Image = global::AgOpenGPS.Properties.Resources.SnapLeftHalf;
            this.btnLeftHalfWidth.Name = "btnLeftHalfWidth";
            this.btnLeftHalfWidth.UseVisualStyleBackColor = false;
            this.btnLeftHalfWidth.Click += new System.EventHandler(this.btnLeftHalfWidth_Click);
            // 
            // btnRightHalfWidth
            // 
            resources.ApplyResources(this.btnRightHalfWidth, "btnRightHalfWidth");
            this.btnRightHalfWidth.BackColor = System.Drawing.Color.Transparent;
            this.btnRightHalfWidth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnRightHalfWidth.FlatAppearance.BorderSize = 0;
            this.btnRightHalfWidth.Image = global::AgOpenGPS.Properties.Resources.SnapRightHalf;
            this.btnRightHalfWidth.Name = "btnRightHalfWidth";
            this.btnRightHalfWidth.UseVisualStyleBackColor = false;
            this.btnRightHalfWidth.Click += new System.EventHandler(this.btnRightHalfWidth_Click);
            // 
            // btnContourPriority
            // 
            resources.ApplyResources(this.btnContourPriority, "btnContourPriority");
            this.btnContourPriority.BackColor = System.Drawing.Color.Transparent;
            this.btnContourPriority.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnContourPriority.FlatAppearance.BorderSize = 0;
            this.btnContourPriority.Image = global::AgOpenGPS.Properties.Resources.SnapToPivot;
            this.btnContourPriority.Name = "btnContourPriority";
            this.btnContourPriority.UseVisualStyleBackColor = false;
            this.btnContourPriority.Click += new System.EventHandler(this.btnContourPriority_Click);
            this.btnContourPriority.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnContourPriority_HelpRequested);
            // 
            // btnSwapAB
            // 
            resources.ApplyResources(this.btnSwapAB, "btnSwapAB");
            this.btnSwapAB.FlatAppearance.BorderSize = 0;
            this.btnSwapAB.Image = global::AgOpenGPS.Properties.Resources.ABSwapPoints;
            this.btnSwapAB.Name = "btnSwapAB";
            this.btnSwapAB.UseVisualStyleBackColor = true;
            this.btnSwapAB.Click += new System.EventHandler(this.btnSwapAB_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.back_button;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancel_HelpRequested);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Image = global::AgOpenGPS.Properties.Resources.FileSave;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.bntOk_Click);
            this.btnOK.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnOK_HelpRequested);
            // 
            // btnAdjLeft
            // 
            resources.ApplyResources(this.btnAdjLeft, "btnAdjLeft");
            this.btnAdjLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnAdjLeft.FlatAppearance.BorderSize = 0;
            this.btnAdjLeft.Image = global::AgOpenGPS.Properties.Resources.SnapLeft;
            this.btnAdjLeft.Name = "btnAdjLeft";
            this.btnAdjLeft.UseVisualStyleBackColor = false;
            this.btnAdjLeft.Click += new System.EventHandler(this.btnAdjLeft_Click);
            // 
            // btnAdjRight
            // 
            resources.ApplyResources(this.btnAdjRight, "btnAdjRight");
            this.btnAdjRight.BackColor = System.Drawing.Color.Transparent;
            this.btnAdjRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnAdjRight.FlatAppearance.BorderSize = 0;
            this.btnAdjRight.Image = global::AgOpenGPS.Properties.Resources.SnapRight;
            this.btnAdjRight.Name = "btnAdjRight";
            this.btnAdjRight.UseVisualStyleBackColor = false;
            this.btnAdjRight.Click += new System.EventHandler(this.btnAdjRight_Click);
            // 
            // tboxHeading
            // 
            resources.ApplyResources(this.tboxHeading, "tboxHeading");
            this.tboxHeading.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxHeading.Name = "tboxHeading";
            this.tboxHeading.Click += new System.EventHandler(this.tboxHeading_Click);
            // 
            // cboxDegrees
            // 
            resources.ApplyResources(this.cboxDegrees, "cboxDegrees");
            this.cboxDegrees.BackColor = System.Drawing.Color.Lavender;
            this.cboxDegrees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDegrees.FormattingEnabled = true;
            this.cboxDegrees.Items.AddRange(new object[] {
            resources.GetString("cboxDegrees.Items"),
            resources.GetString("cboxDegrees.Items1"),
            resources.GetString("cboxDegrees.Items2"),
            resources.GetString("cboxDegrees.Items3")});
            this.cboxDegrees.Name = "cboxDegrees";
            this.cboxDegrees.SelectedIndexChanged += new System.EventHandler(this.cboxDegrees_SelectedIndexChanged);
            // 
            // nudMinTurnRadius
            // 
            resources.ApplyResources(this.nudMinTurnRadius, "nudMinTurnRadius");
            this.nudMinTurnRadius.BackColor = System.Drawing.Color.AliceBlue;
            this.nudMinTurnRadius.DecimalPlaces = 1;
            this.nudMinTurnRadius.InterceptArrowKeys = false;
            this.nudMinTurnRadius.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinTurnRadius.Name = "nudMinTurnRadius";
            this.nudMinTurnRadius.ReadOnly = true;
            this.nudMinTurnRadius.Value = new decimal(new int[] {
            888,
            0,
            0,
            0});
            this.nudMinTurnRadius.ValueChanged += new System.EventHandler(this.nudMinTurnRadius_ValueChanged);
            this.nudMinTurnRadius.Click += new System.EventHandler(this.nudMinTurnRadius_Click);
            // 
            // FormEditAB
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cboxDegrees);
            this.Controls.Add(this.tboxHeading);
            this.Controls.Add(this.lblHalfSnapFtM);
            this.Controls.Add(this.lblHalfWidth);
            this.Controls.Add(this.btnNoSave);
            this.Controls.Add(this.btnLeftHalfWidth);
            this.Controls.Add(this.btnRightHalfWidth);
            this.Controls.Add(this.btnContourPriority);
            this.Controls.Add(this.btnSwapAB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdjLeft);
            this.Controls.Add(this.btnAdjRight);
            this.Controls.Add(this.nudMinTurnRadius);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditAB";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditAB_FormClosing);
            this.Load += new System.EventHandler(this.FormEditAB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTurnRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdjRight;
        private System.Windows.Forms.Button btnAdjLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSwapAB;
        public System.Windows.Forms.Button btnContourPriority;
        private System.Windows.Forms.Button btnLeftHalfWidth;
        private System.Windows.Forms.Button btnRightHalfWidth;
        private System.Windows.Forms.Button btnNoSave;
        private System.Windows.Forms.Label lblHalfSnapFtM;
        private System.Windows.Forms.Label lblHalfWidth;
        private System.Windows.Forms.TextBox tboxHeading;
        private System.Windows.Forms.ComboBox cboxDegrees;
        private System.Windows.Forms.NumericUpDown nudMinTurnRadius;
    }
}