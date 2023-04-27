namespace AgOpenGPS
{
    partial class FormFilePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilePicker));
            this.lvLines = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnByDistance = new System.Windows.Forms.Button();
            this.btnOpenExistingLv = new System.Windows.Forms.Button();
            this.btnDeleteAB = new System.Windows.Forms.Button();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLines
            // 
            resources.ApplyResources(this.lvLines, "lvLines");
            this.lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chDistance,
            this.chArea});
            this.lvLines.FullRowSelect = true;
            this.lvLines.GridLines = true;
            this.lvLines.HideSelection = false;
            this.lvLines.MultiSelect = false;
            this.lvLines.Name = "lvLines";
            this.lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvLines.UseCompatibleStateImageBehavior = false;
            this.lvLines.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            resources.ApplyResources(this.chName, "chName");
            // 
            // chDistance
            // 
            resources.ApplyResources(this.chDistance, "chDistance");
            // 
            // chArea
            // 
            resources.ApplyResources(this.chArea, "chArea");
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // btnByDistance
            // 
            resources.ApplyResources(this.btnByDistance, "btnByDistance");
            this.btnByDistance.BackColor = System.Drawing.Color.Transparent;
            this.btnByDistance.Image = global::AgOpenGPS.Properties.Resources.Sort;
            this.btnByDistance.Name = "btnByDistance";
            this.btnByDistance.UseVisualStyleBackColor = false;
            this.btnByDistance.Click += new System.EventHandler(this.btnByDistance_Click);
            // 
            // btnOpenExistingLv
            // 
            resources.ApplyResources(this.btnOpenExistingLv, "btnOpenExistingLv");
            this.btnOpenExistingLv.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenExistingLv.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOpenExistingLv.Image = global::AgOpenGPS.Properties.Resources.FileOpen;
            this.btnOpenExistingLv.Name = "btnOpenExistingLv";
            this.btnOpenExistingLv.UseVisualStyleBackColor = false;
            this.btnOpenExistingLv.Click += new System.EventHandler(this.btnOpenExistingLv_Click);
            // 
            // btnDeleteAB
            // 
            resources.ApplyResources(this.btnDeleteAB, "btnDeleteAB");
            this.btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAB.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnDeleteAB.Name = "btnDeleteAB";
            this.btnDeleteAB.Click += new System.EventHandler(this.btnDeleteAB_Click);
            // 
            // btnDeleteField
            // 
            resources.ApplyResources(this.btnDeleteField, "btnDeleteField");
            this.btnDeleteField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteField.Image = global::AgOpenGPS.Properties.Resources.skull;
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // FormFilePicker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteField);
            this.Controls.Add(this.btnByDistance);
            this.Controls.Add(this.btnOpenExistingLv);
            this.Controls.Add(this.btnDeleteAB);
            this.Controls.Add(this.lvLines);
            this.Name = "FormFilePicker";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormFilePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.Button btnByDistance;
        private System.Windows.Forms.Button btnOpenExistingLv;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader chArea;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}