namespace AgOpenGPS
{
    partial class FormEnterAB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnterAB));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.nudLatitudeB = new System.Windows.Forms.NumericUpDown();
            this.nudLongitudeB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHeading = new System.Windows.Forms.NumericUpDown();
            this.btnChooseType = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnterManual = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitudeB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitudeB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeading)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
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
            this.nudLatitude.Click += new System.EventHandler(this.nudLatitude_Click);
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
            this.nudLongitude.Click += new System.EventHandler(this.nudLongitude_Click);
            // 
            // nudLatitudeB
            // 
            resources.ApplyResources(this.nudLatitudeB, "nudLatitudeB");
            this.nudLatitudeB.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLatitudeB.DecimalPlaces = 7;
            this.nudLatitudeB.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudLatitudeB.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudLatitudeB.Name = "nudLatitudeB";
            this.nudLatitudeB.ReadOnly = true;
            this.nudLatitudeB.Click += new System.EventHandler(this.nudLatitudeB_Click);
            // 
            // nudLongitudeB
            // 
            resources.ApplyResources(this.nudLongitudeB, "nudLongitudeB");
            this.nudLongitudeB.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLongitudeB.DecimalPlaces = 7;
            this.nudLongitudeB.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudLongitudeB.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudLongitudeB.Name = "nudLongitudeB";
            this.nudLongitudeB.ReadOnly = true;
            this.nudLongitudeB.Click += new System.EventHandler(this.nudLongitudeB_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nudHeading
            // 
            resources.ApplyResources(this.nudHeading, "nudHeading");
            this.nudHeading.BackColor = System.Drawing.Color.AliceBlue;
            this.nudHeading.DecimalPlaces = 6;
            this.nudHeading.InterceptArrowKeys = false;
            this.nudHeading.Maximum = new decimal(new int[] {
            817405951,
            838,
            0,
            655360});
            this.nudHeading.Name = "nudHeading";
            this.nudHeading.ReadOnly = true;
            this.nudHeading.Click += new System.EventHandler(this.nudHeading_Click);
            // 
            // btnChooseType
            // 
            resources.ApplyResources(this.btnChooseType, "btnChooseType");
            this.btnChooseType.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChooseType.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChooseType.FlatAppearance.BorderSize = 2;
            this.btnChooseType.Name = "btnChooseType";
            this.btnChooseType.UseVisualStyleBackColor = false;
            this.btnChooseType.Click += new System.EventHandler(this.btnChooseType_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnEnterManual
            // 
            resources.ApplyResources(this.btnEnterManual, "btnEnterManual");
            this.btnEnterManual.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterManual.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnterManual.FlatAppearance.BorderSize = 0;
            this.btnEnterManual.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnEnterManual.Name = "btnEnterManual";
            this.btnEnterManual.UseVisualStyleBackColor = false;
            this.btnEnterManual.Click += new System.EventHandler(this.btnEnterManual_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.CausesValidation = false;
            this.textBox1.Name = "textBox1";
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
            // FormEnterAB
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEnterManual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChooseType);
            this.Controls.Add(this.nudHeading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLatitudeB);
            this.Controls.Add(this.nudLongitudeB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.nudLatitude);
            this.Controls.Add(this.nudLongitude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEnterAB";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormEnterAB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitudeB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitudeB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudLatitude;
        private System.Windows.Forms.NumericUpDown nudLongitude;
        private System.Windows.Forms.NumericUpDown nudLatitudeB;
        private System.Windows.Forms.NumericUpDown nudLongitudeB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHeading;
        private System.Windows.Forms.Button btnChooseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnterManual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}