namespace AgOpenGPS
{
    partial class FormSimCoords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimCoords));
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntOK
            // 
            resources.ApplyResources(this.bntOK, "bntOK");
            this.bntOK.BackColor = System.Drawing.Color.Transparent;
            this.bntOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntOK.FlatAppearance.BorderSize = 0;
            this.bntOK.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.bntOK.Name = "bntOK";
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // nudLongitude
            // 
            resources.ApplyResources(this.nudLongitude, "nudLongitude");
            this.nudLongitude.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLongitude.DecimalPlaces = 7;
            this.nudLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudLongitude.Name = "nudLongitude";
            this.nudLongitude.ReadOnly = true;
            this.nudLongitude.Value = new decimal(new int[] {
            1781234567,
            0,
            0,
            -2147024896});
            this.nudLongitude.Click += new System.EventHandler(this.nud_Click);
            // 
            // nudLatitude
            // 
            resources.ApplyResources(this.nudLatitude, "nudLatitude");
            this.nudLatitude.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLatitude.DecimalPlaces = 7;
            this.nudLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudLatitude.Name = "nudLatitude";
            this.nudLatitude.ReadOnly = true;
            this.nudLatitude.Value = new decimal(new int[] {
            881234567,
            0,
            0,
            -2147024896});
            this.nudLatitude.Click += new System.EventHandler(this.nud_Click);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // FormSimCoords
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgOpenGPS.Properties.Resources.LatLon;
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.nudLatitude);
            this.Controls.Add(this.nudLongitude);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntOK);
            this.Name = "FormSimCoords";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormSimCoords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.NumericUpDown nudLongitude;
        private System.Windows.Forms.NumericUpDown nudLatitude;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}