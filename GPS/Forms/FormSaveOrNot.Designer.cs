namespace AgOpenGPS
{
    partial class FormSaveOrNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaveOrNot));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            resources.ApplyResources(this.lblQuestion, "lblQuestion");
            this.lblQuestion.Name = "lblQuestion";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSaveAs);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Name = "panel1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // btnSaveAs
            // 
            resources.ApplyResources(this.btnSaveAs, "btnSaveAs");
            this.btnSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.Image = global::AgOpenGPS.Properties.Resources.FileSaveAs;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.Image = global::AgOpenGPS.Properties.Resources.ExitAOG;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReturn
            // 
            resources.ApplyResources(this.btnReturn, "btnReturn");
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.Image = global::AgOpenGPS.Properties.Resources.back_button;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormSaveOrNot
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSaveOrNot";
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}