namespace AgOpenGPS
{
    partial class FormColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColor));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bntOK = new System.Windows.Forms.Button();
            this.btnFrameDay = new System.Windows.Forms.Button();
            this.btnFrameNight = new System.Windows.Forms.Button();
            this.btnFieldNight = new System.Windows.Forms.Button();
            this.btnFieldDay = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnDayText = new System.Windows.Forms.Button();
            this.btnNightText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSmoothCam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hsbarSmooth = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // bntOK
            // 
            resources.ApplyResources(this.bntOK, "bntOK");
            this.bntOK.FlatAppearance.BorderSize = 0;
            this.bntOK.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.bntOK.Name = "bntOK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // btnFrameDay
            // 
            resources.ApplyResources(this.btnFrameDay, "btnFrameDay");
            this.btnFrameDay.BackColor = System.Drawing.Color.Transparent;
            this.btnFrameDay.FlatAppearance.BorderSize = 0;
            this.btnFrameDay.Name = "btnFrameDay";
            this.btnFrameDay.UseVisualStyleBackColor = false;
            this.btnFrameDay.Click += new System.EventHandler(this.btnFrameDay_Click);
            // 
            // btnFrameNight
            // 
            resources.ApplyResources(this.btnFrameNight, "btnFrameNight");
            this.btnFrameNight.BackColor = System.Drawing.Color.Transparent;
            this.btnFrameNight.FlatAppearance.BorderSize = 0;
            this.btnFrameNight.Name = "btnFrameNight";
            this.btnFrameNight.UseVisualStyleBackColor = false;
            this.btnFrameNight.Click += new System.EventHandler(this.btnFrameNight_Click);
            // 
            // btnFieldNight
            // 
            resources.ApplyResources(this.btnFieldNight, "btnFieldNight");
            this.btnFieldNight.BackColor = System.Drawing.Color.Transparent;
            this.btnFieldNight.FlatAppearance.BorderSize = 0;
            this.btnFieldNight.Name = "btnFieldNight";
            this.btnFieldNight.UseVisualStyleBackColor = false;
            this.btnFieldNight.Click += new System.EventHandler(this.btnFieldNight_Click);
            // 
            // btnFieldDay
            // 
            resources.ApplyResources(this.btnFieldDay, "btnFieldDay");
            this.btnFieldDay.BackColor = System.Drawing.Color.Transparent;
            this.btnFieldDay.FlatAppearance.BorderSize = 0;
            this.btnFieldDay.Name = "btnFieldDay";
            this.btnFieldDay.UseVisualStyleBackColor = false;
            this.btnFieldDay.Click += new System.EventHandler(this.btnFieldDay_Click);
            // 
            // btnSwap
            // 
            resources.ApplyResources(this.btnSwap, "btnSwap");
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.Image = global::AgOpenGPS.Properties.Resources.ConD_AutoDayNight;
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnDayText
            // 
            resources.ApplyResources(this.btnDayText, "btnDayText");
            this.btnDayText.BackColor = System.Drawing.Color.Transparent;
            this.btnDayText.FlatAppearance.BorderSize = 0;
            this.btnDayText.Name = "btnDayText";
            this.btnDayText.UseVisualStyleBackColor = false;
            this.btnDayText.Click += new System.EventHandler(this.btnDayText_Click);
            // 
            // btnNightText
            // 
            resources.ApplyResources(this.btnNightText, "btnNightText");
            this.btnNightText.BackColor = System.Drawing.Color.Transparent;
            this.btnNightText.FlatAppearance.BorderSize = 0;
            this.btnNightText.Name = "btnNightText";
            this.btnNightText.UseVisualStyleBackColor = false;
            this.btnNightText.Click += new System.EventHandler(this.btnNightText_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // lblSmoothCam
            // 
            resources.ApplyResources(this.lblSmoothCam, "lblSmoothCam");
            this.lblSmoothCam.ForeColor = System.Drawing.Color.Black;
            this.lblSmoothCam.Name = "lblSmoothCam";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // hsbarSmooth
            // 
            resources.ApplyResources(this.hsbarSmooth, "hsbarSmooth");
            this.hsbarSmooth.LargeChange = 1;
            this.hsbarSmooth.Minimum = 2;
            this.hsbarSmooth.Name = "hsbarSmooth";
            this.hsbarSmooth.Value = 50;
            this.hsbarSmooth.ValueChanged += new System.EventHandler(this.hsbarSmooth_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // FormColor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::AgOpenGPS.Properties.Resources.ColorBackGnd;
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSmoothCam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hsbarSmooth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNightText);
            this.Controls.Add(this.btnDayText);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnFieldNight);
            this.Controls.Add(this.btnFieldDay);
            this.Controls.Add(this.btnFrameNight);
            this.Controls.Add(this.btnFrameDay);
            this.Controls.Add(this.bntOK);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColor";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormDisplaySettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnFrameDay;
        private System.Windows.Forms.Button btnFrameNight;
        private System.Windows.Forms.Button btnFieldNight;
        private System.Windows.Forms.Button btnFieldDay;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnDayText;
        private System.Windows.Forms.Button btnNightText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSmoothCam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsbarSmooth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}