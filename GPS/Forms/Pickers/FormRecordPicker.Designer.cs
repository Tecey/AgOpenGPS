
namespace AgOpenGPS.Forms.Pickers
{
    partial class FormRecordPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecordPicker));
            this.lvLines = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenExistingLv = new System.Windows.Forms.Button();
            this.btnTurnOffRecPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLines
            // 
            resources.ApplyResources(this.lvLines, "lvLines");
            this.lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
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
            // btnDeleteField
            // 
            resources.ApplyResources(this.btnDeleteField, "btnDeleteField");
            this.btnDeleteField.FlatAppearance.BorderSize = 0;
            this.btnDeleteField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteField.Image = global::AgOpenGPS.Properties.Resources.Trash;
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnDeleteAB
            // 
            resources.ApplyResources(this.btnDeleteAB, "btnDeleteAB");
            this.btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAB.FlatAppearance.BorderSize = 0;
            this.btnDeleteAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAB.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnDeleteAB.Name = "btnDeleteAB";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // btnTurnOffRecPath
            // 
            resources.ApplyResources(this.btnTurnOffRecPath, "btnTurnOffRecPath");
            this.btnTurnOffRecPath.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTurnOffRecPath.FlatAppearance.BorderSize = 0;
            this.btnTurnOffRecPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTurnOffRecPath.Image = global::AgOpenGPS.Properties.Resources.SwitchOff;
            this.btnTurnOffRecPath.Name = "btnTurnOffRecPath";
            this.btnTurnOffRecPath.Click += new System.EventHandler(this.btnTurnOffRecPath_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // FormRecordPicker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTurnOffRecPath);
            this.Controls.Add(this.btnOpenExistingLv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteAB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteField);
            this.Controls.Add(this.lvLines);
            this.Name = "FormRecordPicker";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormRecordPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenExistingLv;
        private System.Windows.Forms.Button btnTurnOffRecPath;
        private System.Windows.Forms.Label label3;
    }
}