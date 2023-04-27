namespace AgOpenGPS
{
    partial class FormEditCurve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCurve));
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinTurnRadius = new System.Windows.Forms.NumericUpDown();
            this.lblHalfWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNoSave = new System.Windows.Forms.Button();
            this.btnLeftHalfWidth = new System.Windows.Forms.Button();
            this.btnRightHalfWidth = new System.Windows.Forms.Button();
            this.btnContourPriority = new System.Windows.Forms.Button();
            this.btnSwapAB = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bthOK = new System.Windows.Forms.Button();
            this.btnAdjLeft = new System.Windows.Forms.Button();
            this.btnAdjRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTurnRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nudMinTurnRadius
            // 
            resources.ApplyResources(this.nudMinTurnRadius, "nudMinTurnRadius");
            this.nudMinTurnRadius.BackColor = System.Drawing.Color.AliceBlue;
            this.nudMinTurnRadius.InterceptArrowKeys = false;
            this.nudMinTurnRadius.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinTurnRadius.Name = "nudMinTurnRadius";
            this.nudMinTurnRadius.ReadOnly = true;
            this.nudMinTurnRadius.Value = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            this.nudMinTurnRadius.ValueChanged += new System.EventHandler(this.nudMinTurnRadius_ValueChanged);
            this.nudMinTurnRadius.Click += new System.EventHandler(this.nudMinTurnRadius_Click);
            // 
            // lblHalfWidth
            // 
            resources.ApplyResources(this.lblHalfWidth, "lblHalfWidth");
            this.lblHalfWidth.Name = "lblHalfWidth";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnNoSave
            // 
            resources.ApplyResources(this.btnNoSave, "btnNoSave");
            this.btnNoSave.FlatAppearance.BorderSize = 0;
            this.btnNoSave.Image = global::AgOpenGPS.Properties.Resources.FileDontSave;
            this.btnNoSave.Name = "btnNoSave";
            this.btnNoSave.UseVisualStyleBackColor = true;
            this.btnNoSave.Click += new System.EventHandler(this.btnNosave_Click);
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
            // bthOK
            // 
            resources.ApplyResources(this.bthOK, "bthOK");
            this.bthOK.BackColor = System.Drawing.Color.Transparent;
            this.bthOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bthOK.FlatAppearance.BorderSize = 0;
            this.bthOK.Image = global::AgOpenGPS.Properties.Resources.FileSave;
            this.bthOK.Name = "bthOK";
            this.bthOK.UseVisualStyleBackColor = false;
            this.bthOK.Click += new System.EventHandler(this.bntOk_Click);
            this.bthOK.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnOK_HelpRequested);
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
            // FormEditCurve
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNoSave);
            this.Controls.Add(this.lblHalfWidth);
            this.Controls.Add(this.btnLeftHalfWidth);
            this.Controls.Add(this.btnRightHalfWidth);
            this.Controls.Add(this.btnContourPriority);
            this.Controls.Add(this.btnSwapAB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bthOK);
            this.Controls.Add(this.btnAdjLeft);
            this.Controls.Add(this.btnAdjRight);
            this.Controls.Add(this.nudMinTurnRadius);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditCurve";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditCurve_FormClosing);
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
        private System.Windows.Forms.Button bthOK;
        private System.Windows.Forms.Button btnSwapAB;
        private System.Windows.Forms.NumericUpDown nudMinTurnRadius;
        public System.Windows.Forms.Button btnContourPriority;
        private System.Windows.Forms.Button btnLeftHalfWidth;
        private System.Windows.Forms.Button btnRightHalfWidth;
        private System.Windows.Forms.Label lblHalfWidth;
        private System.Windows.Forms.Button btnNoSave;
        private System.Windows.Forms.Label label2;
    }
}