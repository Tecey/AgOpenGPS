namespace AgOpenGPS
{
    partial class FormSmoothAB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSmoothAB));
            this.btnSouth = new ProXoft.WinForms.RepeatButton();
            this.btnNorth = new ProXoft.WinForms.RepeatButton();
            this.bntOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSmooth = new System.Windows.Forms.Label();
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
            // bntOK
            // 
            resources.ApplyResources(this.bntOK, "bntOK");
            this.bntOK.FlatAppearance.BorderSize = 0;
            this.bntOK.Image = global::AgOpenGPS.Properties.Resources.FileDontSave;
            this.bntOK.Name = "bntOK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Image = global::AgOpenGPS.Properties.Resources.FileSave;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSmooth
            // 
            resources.ApplyResources(this.lblSmooth, "lblSmooth");
            this.lblSmooth.BackColor = System.Drawing.Color.Transparent;
            this.lblSmooth.Name = "lblSmooth";
            // 
            // FormSmoothAB
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ControlBox = false;
            this.Controls.Add(this.lblSmooth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Name = "FormSmoothAB";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormSmoothAB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProXoft.WinForms.RepeatButton btnSouth;
        private ProXoft.WinForms.RepeatButton btnNorth;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSmooth;
    }
}