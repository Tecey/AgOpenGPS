namespace AgOpenGPS
{
    partial class FormShiftPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShiftPos));
            this.nudNorth = new System.Windows.Forms.NumericUpDown();
            this.nudEast = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSouth = new ProXoft.WinForms.RepeatButton();
            this.btnNorth = new ProXoft.WinForms.RepeatButton();
            this.btnEast = new ProXoft.WinForms.RepeatButton();
            this.btnWest = new ProXoft.WinForms.RepeatButton();
            this.bntOK = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkOffsetsOn = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEast)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNorth
            // 
            resources.ApplyResources(this.nudNorth, "nudNorth");
            this.nudNorth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudNorth.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.nudNorth.Name = "nudNorth";
            this.nudNorth.Value = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.nudNorth.Click += new System.EventHandler(this.nudNorth_Click);
            // 
            // nudEast
            // 
            resources.ApplyResources(this.nudEast, "nudEast");
            this.nudEast.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudEast.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.nudEast.Name = "nudEast";
            this.nudEast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEast.Click += new System.EventHandler(this.nudEast_Click);
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnSouth
            // 
            resources.ApplyResources(this.btnSouth, "btnSouth");
            this.btnSouth.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSouth_MouseDown);
            // 
            // btnNorth
            // 
            resources.ApplyResources(this.btnNorth, "btnNorth");
            this.btnNorth.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNorth_MouseDown);
            // 
            // btnEast
            // 
            resources.ApplyResources(this.btnEast, "btnEast");
            this.btnEast.Image = global::AgOpenGPS.Properties.Resources.ArrowRight;
            this.btnEast.Name = "btnEast";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEast_MouseDown);
            // 
            // btnWest
            // 
            resources.ApplyResources(this.btnWest, "btnWest");
            this.btnWest.Image = global::AgOpenGPS.Properties.Resources.ArrowLeft;
            this.btnWest.Name = "btnWest";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWest_MouseDown);
            // 
            // bntOK
            // 
            resources.ApplyResources(this.bntOK, "bntOK");
            this.bntOK.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.bntOK.Name = "bntOK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // btnZero
            // 
            resources.ApplyResources(this.btnZero, "btnZero");
            this.btnZero.Name = "btnZero";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // chkOffsetsOn
            // 
            resources.ApplyResources(this.chkOffsetsOn, "chkOffsetsOn");
            this.chkOffsetsOn.BackColor = System.Drawing.Color.AliceBlue;
            this.chkOffsetsOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkOffsetsOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.chkOffsetsOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOffsetsOn.Name = "chkOffsetsOn";
            this.chkOffsetsOn.UseVisualStyleBackColor = false;
            this.chkOffsetsOn.Click += new System.EventHandler(this.chkOffsetsOn_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // FormShiftPos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkOffsetsOn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.nudEast);
            this.Controls.Add(this.nudNorth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShiftPos";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormShiftPos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudNorth;
        private System.Windows.Forms.NumericUpDown nudEast;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ProXoft.WinForms.RepeatButton btnSouth;
        private ProXoft.WinForms.RepeatButton btnNorth;
        private ProXoft.WinForms.RepeatButton btnEast;
        private ProXoft.WinForms.RepeatButton btnWest;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkOffsetsOn;
        private System.Windows.Forms.Label label7;
    }
}