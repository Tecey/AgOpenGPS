namespace AgOpenGPS
{
    partial class Form_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Help));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelGit = new System.Windows.Forms.LinkLabel();
            this.linkLabelCombineForum = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // linkLabelGit
            // 
            resources.ApplyResources(this.linkLabelGit, "linkLabelGit");
            this.linkLabelGit.Name = "linkLabelGit";
            this.linkLabelGit.TabStop = true;
            this.linkLabelGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGit_LinkClicked);
            // 
            // linkLabelCombineForum
            // 
            resources.ApplyResources(this.linkLabelCombineForum, "linkLabelCombineForum");
            this.linkLabelCombineForum.Name = "linkLabelCombineForum";
            this.linkLabelCombineForum.TabStop = true;
            this.linkLabelCombineForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCombineForum_LinkClicked);
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AgOpenGPS.Properties.Resources.AgOpenYouTubeChannel;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnManual
            // 
            resources.ApplyResources(this.btnManual, "btnManual");
            this.btnManual.BackColor = System.Drawing.Color.Transparent;
            this.btnManual.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.Image = global::AgOpenGPS.Properties.Resources.OpManual;
            this.btnManual.Name = "btnManual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnVideo
            // 
            resources.ApplyResources(this.btnVideo, "btnVideo");
            this.btnVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnVideo.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.Image = global::AgOpenGPS.Properties.Resources.Webcam;
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Help
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelGit);
            this.Controls.Add(this.linkLabelCombineForum);
            this.Controls.Add(this.button1);
            this.MinimizeBox = false;
            this.Name = "Form_Help";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form_About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelGit;
        private System.Windows.Forms.LinkLabel linkLabelCombineForum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}