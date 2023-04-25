namespace AgOpenGPS
{
    partial class FormSaveAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaveAs));
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFieldName = new System.Windows.Forms.TextBox();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.lblTemplateChosen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkApplied = new System.Windows.Forms.CheckBox();
            this.chkHeadland = new System.Windows.Forms.CheckBox();
            this.chkGuidanceLines = new System.Windows.Forms.CheckBox();
            this.chkFlags = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // tboxFieldName
            // 
            resources.ApplyResources(this.tboxFieldName, "tboxFieldName");
            this.tboxFieldName.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxFieldName.Name = "tboxFieldName";
            this.tboxFieldName.Click += new System.EventHandler(this.tboxFieldName_Click);
            this.tboxFieldName.TextChanged += new System.EventHandler(this.tboxFieldName_TextChanged);
            // 
            // btnSerialCancel
            // 
            resources.ApplyResources(this.btnSerialCancel, "btnSerialCancel");
            this.btnSerialCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialCancel.FlatAppearance.BorderSize = 0;
            this.btnSerialCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSerialCancel.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.UseVisualStyleBackColor = false;
            this.btnSerialCancel.Click += new System.EventHandler(this.btnSerialCancel_Click);
            // 
            // lblTemplateChosen
            // 
            resources.ApplyResources(this.lblTemplateChosen, "lblTemplateChosen");
            this.lblTemplateChosen.BackColor = System.Drawing.Color.Transparent;
            this.lblTemplateChosen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTemplateChosen.Name = "lblTemplateChosen";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Name = "label3";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkApplied
            // 
            resources.ApplyResources(this.chkApplied, "chkApplied");
            this.chkApplied.BackColor = System.Drawing.Color.Transparent;
            this.chkApplied.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkApplied.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkApplied.ForeColor = System.Drawing.Color.White;
            this.chkApplied.Image = global::AgOpenGPS.Properties.Resources.SectionMasterOn;
            this.chkApplied.Name = "chkApplied";
            this.chkApplied.UseVisualStyleBackColor = false;
            // 
            // chkHeadland
            // 
            resources.ApplyResources(this.chkHeadland, "chkHeadland");
            this.chkHeadland.BackColor = System.Drawing.Color.Transparent;
            this.chkHeadland.Checked = true;
            this.chkHeadland.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHeadland.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkHeadland.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkHeadland.ForeColor = System.Drawing.Color.White;
            this.chkHeadland.Image = global::AgOpenGPS.Properties.Resources.HeadlandMenu;
            this.chkHeadland.Name = "chkHeadland";
            this.chkHeadland.UseVisualStyleBackColor = false;
            // 
            // chkGuidanceLines
            // 
            resources.ApplyResources(this.chkGuidanceLines, "chkGuidanceLines");
            this.chkGuidanceLines.BackColor = System.Drawing.Color.Transparent;
            this.chkGuidanceLines.Checked = true;
            this.chkGuidanceLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGuidanceLines.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkGuidanceLines.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkGuidanceLines.ForeColor = System.Drawing.Color.White;
            this.chkGuidanceLines.Image = global::AgOpenGPS.Properties.Resources.ABLineEdit;
            this.chkGuidanceLines.Name = "chkGuidanceLines";
            this.chkGuidanceLines.UseVisualStyleBackColor = false;
            // 
            // chkFlags
            // 
            resources.ApplyResources(this.chkFlags, "chkFlags");
            this.chkFlags.BackColor = System.Drawing.Color.Transparent;
            this.chkFlags.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkFlags.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkFlags.ForeColor = System.Drawing.Color.White;
            this.chkFlags.Image = global::AgOpenGPS.Properties.Resources.FlagRed;
            this.chkFlags.Name = "chkFlags";
            this.chkFlags.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Name = "label8";
            // 
            // btnAddDate
            // 
            resources.ApplyResources(this.btnAddDate, "btnAddDate");
            this.btnAddDate.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDate.FlatAppearance.BorderSize = 0;
            this.btnAddDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddDate.Image = global::AgOpenGPS.Properties.Resources.JobNameCalendar;
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.UseVisualStyleBackColor = false;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // btnAddTime
            // 
            resources.ApplyResources(this.btnAddTime, "btnAddTime");
            this.btnAddTime.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTime.FlatAppearance.BorderSize = 0;
            this.btnAddTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTime.Image = global::AgOpenGPS.Properties.Resources.JobNameTime;
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.UseVisualStyleBackColor = false;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // FormSaveAs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ControlBox = false;
            this.Controls.Add(this.btnAddDate);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxFieldName);
            this.Controls.Add(this.chkHeadland);
            this.Controls.Add(this.chkGuidanceLines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkFlags);
            this.Controls.Add(this.lblTemplateChosen);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.chkApplied);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSaveAs";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormSaveAs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFieldName;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Label lblTemplateChosen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkApplied;
        private System.Windows.Forms.CheckBox chkHeadland;
        private System.Windows.Forms.CheckBox chkGuidanceLines;
        private System.Windows.Forms.CheckBox chkFlags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.Button btnAddTime;
    }
}