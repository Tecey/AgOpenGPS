namespace AgOpenGPS
{
    partial class FormBoundaryPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoundaryPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPausePlay = new System.Windows.Forms.Button();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lblOffset = new System.Windows.Forms.Label();
            this.btnLeftRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblArea
            // 
            resources.ApplyResources(this.lblArea, "lblArea");
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.Name = "lblArea";
            // 
            // lblPoints
            // 
            resources.ApplyResources(this.lblPoints, "lblPoints");
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPoints.Name = "lblPoints";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // btnRestart
            // 
            resources.ApplyResources(this.btnRestart, "btnRestart");
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRestart.Image = global::AgOpenGPS.Properties.Resources.BoundaryDelete;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnRestart_HelpRequested);
            // 
            // btnDeleteLast
            // 
            resources.ApplyResources(this.btnDeleteLast, "btnDeleteLast");
            this.btnDeleteLast.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLast.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteLast.Image = global::AgOpenGPS.Properties.Resources.PointDelete;
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.UseVisualStyleBackColor = false;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            this.btnDeleteLast.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDeleteLast_HelpRequested);
            // 
            // btnAddPoint
            // 
            resources.ApplyResources(this.btnAddPoint, "btnAddPoint");
            this.btnAddPoint.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPoint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddPoint.Image = global::AgOpenGPS.Properties.Resources.PointAdd;
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.UseVisualStyleBackColor = false;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            this.btnAddPoint.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnAddPoint_HelpRequested);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnStop_HelpRequested);
            // 
            // btnPausePlay
            // 
            resources.ApplyResources(this.btnPausePlay, "btnPausePlay");
            this.btnPausePlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPausePlay.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPausePlay.Image = global::AgOpenGPS.Properties.Resources.BoundaryRecord;
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.UseVisualStyleBackColor = false;
            this.btnPausePlay.Click += new System.EventHandler(this.btnPausePlay_Click);
            this.btnPausePlay.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnPausePlay_HelpRequested);
            // 
            // nudOffset
            // 
            resources.ApplyResources(this.nudOffset, "nudOffset");
            this.nudOffset.BackColor = System.Drawing.Color.AliceBlue;
            this.nudOffset.DecimalPlaces = 2;
            this.nudOffset.Maximum = new decimal(new int[] {
            4999,
            0,
            0,
            131072});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.ReadOnly = true;
            this.nudOffset.Value = new decimal(new int[] {
            4999,
            0,
            0,
            131072});
            this.nudOffset.Click += new System.EventHandler(this.nudOffset_Click);
            this.nudOffset.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nudOffset_HelpRequested);
            // 
            // lblOffset
            // 
            resources.ApplyResources(this.lblOffset, "lblOffset");
            this.lblOffset.BackColor = System.Drawing.Color.Transparent;
            this.lblOffset.ForeColor = System.Drawing.Color.Black;
            this.lblOffset.Name = "lblOffset";
            // 
            // btnLeftRight
            // 
            resources.ApplyResources(this.btnLeftRight, "btnLeftRight");
            this.btnLeftRight.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLeftRight.Image = global::AgOpenGPS.Properties.Resources.BoundaryLeft;
            this.btnLeftRight.Name = "btnLeftRight";
            this.btnLeftRight.UseVisualStyleBackColor = true;
            this.btnLeftRight.Click += new System.EventHandler(this.btnLeftRight_Click);
            this.btnLeftRight.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnLeftRight_HelpRequested);
            // 
            // FormBoundaryPlayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnLeftRight);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPausePlay);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudOffset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBoundaryPlayer";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBoundaryPlayer_FormClosing);
            this.Load += new System.EventHandler(this.FormBoundaryPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Button btnLeftRight;
        private System.Windows.Forms.Label lblOffset;
    }
}