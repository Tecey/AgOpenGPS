namespace AgOpenGPS
{
    partial class FormFlags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlags));
            this.btnSouth = new ProXoft.WinForms.RepeatButton();
            this.btnNorth = new ProXoft.WinForms.RepeatButton();
            this.lblFlagSelected = new System.Windows.Forms.Label();
            this.lblLonStart = new System.Windows.Forms.Label();
            this.lblLatStart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEasting = new System.Windows.Forms.Label();
            this.lblNorthing = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFlagNotes = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteFlag = new System.Windows.Forms.Button();
            this.btnDriveToFlag = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblDistanceToFlag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSouth
            // 
            resources.ApplyResources(this.btnSouth, "btnSouth");
            this.btnSouth.FlatAppearance.BorderSize = 0;
            this.btnSouth.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSouth_MouseDown);
            // 
            // btnNorth
            // 
            resources.ApplyResources(this.btnNorth, "btnNorth");
            this.btnNorth.FlatAppearance.BorderSize = 0;
            this.btnNorth.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNorth_MouseDown);
            // 
            // lblFlagSelected
            // 
            resources.ApplyResources(this.lblFlagSelected, "lblFlagSelected");
            this.lblFlagSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblFlagSelected.Name = "lblFlagSelected";
            // 
            // lblLonStart
            // 
            resources.ApplyResources(this.lblLonStart, "lblLonStart");
            this.lblLonStart.Name = "lblLonStart";
            // 
            // lblLatStart
            // 
            resources.ApplyResources(this.lblLatStart, "lblLatStart");
            this.lblLatStart.Name = "lblLatStart";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblEasting
            // 
            resources.ApplyResources(this.lblEasting, "lblEasting");
            this.lblEasting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEasting.Name = "lblEasting";
            // 
            // lblNorthing
            // 
            resources.ApplyResources(this.lblNorthing, "lblNorthing");
            this.lblNorthing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNorthing.Name = "lblNorthing";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // tboxFlagNotes
            // 
            resources.ApplyResources(this.tboxFlagNotes, "tboxFlagNotes");
            this.tboxFlagNotes.Name = "tboxFlagNotes";
            this.tboxFlagNotes.Click += new System.EventHandler(this.tboxFlagNotes_Click);
            this.tboxFlagNotes.TextChanged += new System.EventHandler(this.tboxFlagNotes_TextChanged);
            this.tboxFlagNotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxFlagNotes_KeyPress);
            this.tboxFlagNotes.Leave += new System.EventHandler(this.tboxFlagNotes_Leave);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteFlag
            // 
            resources.ApplyResources(this.btnDeleteFlag, "btnDeleteFlag");
            this.btnDeleteFlag.FlatAppearance.BorderSize = 0;
            this.btnDeleteFlag.Image = global::AgOpenGPS.Properties.Resources.FlagDelete;
            this.btnDeleteFlag.Name = "btnDeleteFlag";
            this.btnDeleteFlag.UseVisualStyleBackColor = true;
            this.btnDeleteFlag.Click += new System.EventHandler(this.btnDeleteFlag_Click);
            // 
            // btnDriveToFlag
            // 
            resources.ApplyResources(this.btnDriveToFlag, "btnDriveToFlag");
            this.btnDriveToFlag.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDriveToFlag.FlatAppearance.BorderSize = 0;
            this.btnDriveToFlag.Image = global::AgOpenGPS.Properties.Resources.AutoSteerConf;
            this.btnDriveToFlag.Name = "btnDriveToFlag";
            this.btnDriveToFlag.UseVisualStyleBackColor = true;
            this.btnDriveToFlag.Click += new System.EventHandler(this.btnDriveToFlag_Click);
            // 
            // lblHeading
            // 
            resources.ApplyResources(this.lblHeading, "lblHeading");
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeading.Name = "lblHeading";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Name = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblDistanceToFlag
            // 
            resources.ApplyResources(this.lblDistanceToFlag, "lblDistanceToFlag");
            this.lblDistanceToFlag.Name = "lblDistanceToFlag";
            // 
            // FormFlags
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblDistanceToFlag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDriveToFlag);
            this.Controls.Add(this.btnDeleteFlag);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tboxFlagNotes);
            this.Controls.Add(this.lblEasting);
            this.Controls.Add(this.lblNorthing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLonStart);
            this.Controls.Add(this.lblLatStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFlagSelected);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormFlags";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormFlags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProXoft.WinForms.RepeatButton btnSouth;
        private ProXoft.WinForms.RepeatButton btnNorth;
        private System.Windows.Forms.Label lblFlagSelected;
        private System.Windows.Forms.Label lblLonStart;
        private System.Windows.Forms.Label lblLatStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEasting;
        private System.Windows.Forms.Label lblNorthing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFlagNotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteFlag;
        private System.Windows.Forms.Button btnDriveToFlag;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDistanceToFlag;
    }
}