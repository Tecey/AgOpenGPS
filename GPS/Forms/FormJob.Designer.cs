namespace AgOpenGPS
{
    partial class FormJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJob));
            this.btnJobOpen = new System.Windows.Forms.Button();
            this.btnJobNew = new System.Windows.Forms.Button();
            this.btnDeleteAB = new System.Windows.Forms.Button();
            this.btnJobResume = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInField = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSatsTracked = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFixQuality = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.btnFromKML = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJobOpen
            // 
            resources.ApplyResources(this.btnJobOpen, "btnJobOpen");
            this.btnJobOpen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJobOpen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJobOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJobOpen.Image = global::AgOpenGPS.Properties.Resources.FileOpen;
            this.btnJobOpen.Name = "btnJobOpen";
            this.btnJobOpen.UseVisualStyleBackColor = false;
            this.btnJobOpen.Click += new System.EventHandler(this.btnJobOpen_Click);
            // 
            // btnJobNew
            // 
            resources.ApplyResources(this.btnJobNew, "btnJobNew");
            this.btnJobNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJobNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJobNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJobNew.Image = global::AgOpenGPS.Properties.Resources.FileNew;
            this.btnJobNew.Name = "btnJobNew";
            this.btnJobNew.UseVisualStyleBackColor = false;
            this.btnJobNew.Click += new System.EventHandler(this.btnJobNew_Click);
            // 
            // btnDeleteAB
            // 
            resources.ApplyResources(this.btnDeleteAB, "btnDeleteAB");
            this.btnDeleteAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAB.FlatAppearance.BorderSize = 0;
            this.btnDeleteAB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteAB.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnDeleteAB.Name = "btnDeleteAB";
            this.btnDeleteAB.UseVisualStyleBackColor = false;
            // 
            // btnJobResume
            // 
            resources.ApplyResources(this.btnJobResume, "btnJobResume");
            this.btnJobResume.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJobResume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJobResume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJobResume.Image = global::AgOpenGPS.Properties.Resources.FilePrevious;
            this.btnJobResume.Name = "btnJobResume";
            this.btnJobResume.UseVisualStyleBackColor = false;
            this.btnJobResume.Click += new System.EventHandler(this.btnJobResume_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Name = "textBox1";
            // 
            // btnInField
            // 
            resources.ApplyResources(this.btnInField, "btnInField");
            this.btnInField.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInField.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInField.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInField.Image = global::AgOpenGPS.Properties.Resources.AutoManualIsAuto;
            this.btnInField.Name = "btnInField";
            this.btnInField.UseVisualStyleBackColor = false;
            this.btnInField.Click += new System.EventHandler(this.btnInField_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.lblSatsTracked);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblAltitude);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFixQuality);
            this.panel1.Controls.Add(this.lblLatitude);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblLongitude);
            this.panel1.Controls.Add(this.btnJobNew);
            this.panel1.Controls.Add(this.btnInField);
            this.panel1.Controls.Add(this.btnJobResume);
            this.panel1.Controls.Add(this.btnJobOpen);
            this.panel1.Controls.Add(this.btnFromKML);
            this.panel1.Controls.Add(this.btnDeleteAB);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Name = "panel1";
            // 
            // lblSatsTracked
            // 
            resources.ApplyResources(this.lblSatsTracked, "lblSatsTracked");
            this.lblSatsTracked.BackColor = System.Drawing.Color.Transparent;
            this.lblSatsTracked.ForeColor = System.Drawing.Color.White;
            this.lblSatsTracked.Name = "lblSatsTracked";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // lblAltitude
            // 
            resources.ApplyResources(this.lblAltitude, "lblAltitude");
            this.lblAltitude.BackColor = System.Drawing.Color.Transparent;
            this.lblAltitude.ForeColor = System.Drawing.Color.White;
            this.lblAltitude.Name = "lblAltitude";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // lblFixQuality
            // 
            resources.ApplyResources(this.lblFixQuality, "lblFixQuality");
            this.lblFixQuality.BackColor = System.Drawing.Color.Transparent;
            this.lblFixQuality.ForeColor = System.Drawing.Color.White;
            this.lblFixQuality.Name = "lblFixQuality";
            // 
            // lblLatitude
            // 
            resources.ApplyResources(this.lblLatitude, "lblLatitude");
            this.lblLatitude.ForeColor = System.Drawing.Color.White;
            this.lblLatitude.Name = "lblLatitude";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // lblLongitude
            // 
            resources.ApplyResources(this.lblLongitude, "lblLongitude");
            this.lblLongitude.ForeColor = System.Drawing.Color.White;
            this.lblLongitude.Name = "lblLongitude";
            // 
            // btnFromKML
            // 
            resources.ApplyResources(this.btnFromKML, "btnFromKML");
            this.btnFromKML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFromKML.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFromKML.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFromKML.Image = global::AgOpenGPS.Properties.Resources.BoundaryLoadFromGE;
            this.btnFromKML.Name = "btnFromKML";
            this.btnFromKML.UseVisualStyleBackColor = false;
            this.btnFromKML.Click += new System.EventHandler(this.btnFromKML_Click);
            // 
            // FormJob
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJob";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormJob_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJobOpen;
        private System.Windows.Forms.Button btnJobNew;
        private System.Windows.Forms.Button btnJobResume;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFromKML;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFixQuality;
        private System.Windows.Forms.Label lblSatsTracked;
        private System.Windows.Forms.Label label3;
    }
}