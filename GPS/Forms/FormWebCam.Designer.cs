namespace AgOpenGPS
{
    partial class FormWebCam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWebCam));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.webCameraControl1 = new WebEye.Controls.WinForms.WebCameraControl.WebCameraControl();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.BackgroundImage = global::AgOpenGPS.Properties.Resources.Stop;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click_1);
            // 
            // webCameraControl1
            // 
            resources.ApplyResources(this.webCameraControl1, "webCameraControl1");
            this.webCameraControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.webCameraControl1.Name = "webCameraControl1";
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.BackgroundImage = global::AgOpenGPS.Properties.Resources.Play;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // FormWebCam
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.webCameraControl1);
            this.Name = "FormWebCam";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormWebCam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private WebEye.Controls.WinForms.WebCameraControl.WebCameraControl webCameraControl1;
    }
}