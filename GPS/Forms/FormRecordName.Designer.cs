
namespace AgOpenGPS.Forms
{
    partial class FormRecordName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecordName));
            this.lblFilename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFieldName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxRecordAddTime = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxRecordAddDate = new System.Windows.Forms.CheckBox();
            this.buttonRecordCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilename
            // 
            resources.ApplyResources(this.lblFilename, "lblFilename");
            this.lblFilename.BackColor = System.Drawing.Color.Transparent;
            this.lblFilename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFilename.Name = "lblFilename";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Name = "label5";
            // 
            // checkBoxRecordAddTime
            // 
            resources.ApplyResources(this.checkBoxRecordAddTime, "checkBoxRecordAddTime");
            this.checkBoxRecordAddTime.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRecordAddTime.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBoxRecordAddTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.checkBoxRecordAddTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxRecordAddTime.Image = global::AgOpenGPS.Properties.Resources.JobNameTime;
            this.checkBoxRecordAddTime.Name = "checkBoxRecordAddTime";
            this.checkBoxRecordAddTime.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxRecordAddDate
            // 
            resources.ApplyResources(this.checkBoxRecordAddDate, "checkBoxRecordAddDate");
            this.checkBoxRecordAddDate.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRecordAddDate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBoxRecordAddDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.checkBoxRecordAddDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxRecordAddDate.Image = global::AgOpenGPS.Properties.Resources.JobNameCalendar;
            this.checkBoxRecordAddDate.Name = "checkBoxRecordAddDate";
            this.checkBoxRecordAddDate.UseVisualStyleBackColor = false;
            // 
            // buttonRecordCancel
            // 
            resources.ApplyResources(this.buttonRecordCancel, "buttonRecordCancel");
            this.buttonRecordCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonRecordCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRecordCancel.FlatAppearance.BorderSize = 0;
            this.buttonRecordCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRecordCancel.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.buttonRecordCancel.Name = "buttonRecordCancel";
            this.buttonRecordCancel.UseVisualStyleBackColor = false;
            this.buttonRecordCancel.Click += new System.EventHandler(this.buttonRecordCancel_Click);
            // 
            // FormRecordName
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ControlBox = false;
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxFieldName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxRecordAddTime);
            this.Controls.Add(this.buttonRecordCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxRecordAddDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecordName";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormRecordName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFieldName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxRecordAddTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxRecordAddDate;
        private System.Windows.Forms.Button buttonRecordCancel;
    }
}