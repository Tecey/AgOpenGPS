namespace AgOpenGPS
{
    partial class FormFieldDir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFieldDir));
            this.tboxFieldName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxFieldName
            // 
            resources.ApplyResources(this.tboxFieldName, "tboxFieldName");
            this.tboxFieldName.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxFieldName.Name = "tboxFieldName";
            this.tboxFieldName.Click += new System.EventHandler(this.tboxFieldName_Click);
            this.tboxFieldName.TextChanged += new System.EventHandler(this.tboxFieldName_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
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
            // FormFieldDir
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ControlBox = false;
            this.Controls.Add(this.btnAddDate);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxFieldName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSerialCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFieldDir";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormFieldDir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxFieldName;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnAddDate;
    }
}