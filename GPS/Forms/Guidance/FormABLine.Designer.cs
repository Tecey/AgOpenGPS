namespace AgOpenGPS
{
    partial class FormABLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABLine));
            this.lvLines = new System.Windows.Forms.ListView();
            this.chField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAPlus = new System.Windows.Forms.Panel();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnCancel_APlus = new System.Windows.Forms.Button();
            this.btnEnter_APlus = new System.Windows.Forms.Button();
            this.nudHeading = new System.Windows.Forms.NumericUpDown();
            this.btnAPoint = new System.Windows.Forms.Button();
            this.btnBPoint = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel_Name = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelPick = new System.Windows.Forms.Panel();
            this.btnSwapAB = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnNewABLine = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnListUse = new System.Windows.Forms.Button();
            this.btnListDelete = new System.Windows.Forms.Button();
            this.panelEditName = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTimeEdit = new System.Windows.Forms.Button();
            this.btnSaveEditName = new System.Windows.Forms.Button();
            this.btnCancelEditName = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelAPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeading)).BeginInit();
            this.panelName.SuspendLayout();
            this.panelPick.SuspendLayout();
            this.panelEditName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLines
            // 
            resources.ApplyResources(this.lvLines, "lvLines");
            this.lvLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chField});
            this.lvLines.FullRowSelect = true;
            this.lvLines.HideSelection = false;
            this.lvLines.MultiSelect = false;
            this.lvLines.Name = "lvLines";
            this.lvLines.TileSize = new System.Drawing.Size(350, 35);
            this.lvLines.UseCompatibleStateImageBehavior = false;
            this.lvLines.View = System.Windows.Forms.View.Tile;
            // 
            // chField
            // 
            resources.ApplyResources(this.chField, "chField");
            // 
            // panelAPlus
            // 
            resources.ApplyResources(this.panelAPlus, "panelAPlus");
            this.panelAPlus.BackColor = System.Drawing.Color.Transparent;
            this.panelAPlus.Controls.Add(this.btnManual);
            this.panelAPlus.Controls.Add(this.btnCancel_APlus);
            this.panelAPlus.Controls.Add(this.btnEnter_APlus);
            this.panelAPlus.Controls.Add(this.nudHeading);
            this.panelAPlus.Controls.Add(this.btnAPoint);
            this.panelAPlus.Controls.Add(this.btnBPoint);
            this.panelAPlus.Name = "panelAPlus";
            // 
            // btnManual
            // 
            resources.ApplyResources(this.btnManual, "btnManual");
            this.btnManual.BackColor = System.Drawing.Color.Transparent;
            this.btnManual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.Image = global::AgOpenGPS.Properties.Resources.FileEditName;
            this.btnManual.Name = "btnManual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            this.btnManual.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnManual_HelpRequested);
            // 
            // btnCancel_APlus
            // 
            resources.ApplyResources(this.btnCancel_APlus, "btnCancel_APlus");
            this.btnCancel_APlus.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel_APlus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel_APlus.FlatAppearance.BorderSize = 0;
            this.btnCancel_APlus.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancel_APlus.Name = "btnCancel_APlus";
            this.btnCancel_APlus.UseVisualStyleBackColor = false;
            this.btnCancel_APlus.Click += new System.EventHandler(this.btnCancel_APlus_Click);
            this.btnCancel_APlus.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancel_APlus_HelpRequested);
            // 
            // btnEnter_APlus
            // 
            resources.ApplyResources(this.btnEnter_APlus, "btnEnter_APlus");
            this.btnEnter_APlus.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter_APlus.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnEnter_APlus.FlatAppearance.BorderSize = 0;
            this.btnEnter_APlus.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnEnter_APlus.Name = "btnEnter_APlus";
            this.btnEnter_APlus.UseVisualStyleBackColor = false;
            this.btnEnter_APlus.Click += new System.EventHandler(this.btnEnter_APlus_Click);
            this.btnEnter_APlus.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnEnter_APlus_HelpRequested);
            // 
            // nudHeading
            // 
            resources.ApplyResources(this.nudHeading, "nudHeading");
            this.nudHeading.BackColor = System.Drawing.Color.AliceBlue;
            this.nudHeading.DecimalPlaces = 5;
            this.nudHeading.InterceptArrowKeys = false;
            this.nudHeading.Maximum = new decimal(new int[] {
            817405951,
            838,
            0,
            655360});
            this.nudHeading.Name = "nudHeading";
            this.nudHeading.ReadOnly = true;
            this.nudHeading.Click += new System.EventHandler(this.nudHeading_Click);
            this.nudHeading.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.nudHeading_HelpRequested);
            // 
            // btnAPoint
            // 
            resources.ApplyResources(this.btnAPoint, "btnAPoint");
            this.btnAPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAPoint.FlatAppearance.BorderSize = 0;
            this.btnAPoint.Image = global::AgOpenGPS.Properties.Resources.LetterABlue;
            this.btnAPoint.Name = "btnAPoint";
            this.btnAPoint.UseVisualStyleBackColor = true;
            this.btnAPoint.Click += new System.EventHandler(this.btnAPoint_Click);
            this.btnAPoint.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnAPoint_HelpRequested);
            // 
            // btnBPoint
            // 
            resources.ApplyResources(this.btnBPoint, "btnBPoint");
            this.btnBPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBPoint.FlatAppearance.BorderSize = 0;
            this.btnBPoint.Image = global::AgOpenGPS.Properties.Resources.LetterBBlue;
            this.btnBPoint.Name = "btnBPoint";
            this.btnBPoint.UseVisualStyleBackColor = true;
            this.btnBPoint.Click += new System.EventHandler(this.btnBPoint_Click);
            this.btnBPoint.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnBPoint_HelpRequested);
            // 
            // panelName
            // 
            resources.ApplyResources(this.panelName, "panelName");
            this.panelName.BackColor = System.Drawing.Color.Transparent;
            this.panelName.Controls.Add(this.label1);
            this.panelName.Controls.Add(this.btnAddTime);
            this.panelName.Controls.Add(this.btnAdd);
            this.panelName.Controls.Add(this.btnCancel_Name);
            this.panelName.Controls.Add(this.textBox1);
            this.panelName.Name = "panelName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnAddTime
            // 
            resources.ApplyResources(this.btnAddTime, "btnAddTime");
            this.btnAddTime.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddTime.FlatAppearance.BorderSize = 0;
            this.btnAddTime.Image = global::AgOpenGPS.Properties.Resources.Time;
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.UseVisualStyleBackColor = false;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            this.btnAddTime.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnAddTime_HelpRequested);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnAdd_HelpRequested);
            // 
            // btnCancel_Name
            // 
            resources.ApplyResources(this.btnCancel_Name, "btnCancel_Name");
            this.btnCancel_Name.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel_Name.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel_Name.FlatAppearance.BorderSize = 0;
            this.btnCancel_Name.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancel_Name.Name = "btnCancel_Name";
            this.btnCancel_Name.UseVisualStyleBackColor = false;
            this.btnCancel_Name.Click += new System.EventHandler(this.btnCancel_APlus_Click);
            this.btnCancel_Name.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancel_Name_HelpRequested);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.CausesValidation = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.textBox1_HelpRequested);
            // 
            // panelPick
            // 
            resources.ApplyResources(this.panelPick, "panelPick");
            this.panelPick.BackColor = System.Drawing.Color.Transparent;
            this.panelPick.Controls.Add(this.btnSwapAB);
            this.panelPick.Controls.Add(this.btnEditName);
            this.panelPick.Controls.Add(this.btnDuplicate);
            this.panelPick.Controls.Add(this.lvLines);
            this.panelPick.Controls.Add(this.btnNewABLine);
            this.panelPick.Controls.Add(this.btnCancel);
            this.panelPick.Controls.Add(this.btnListUse);
            this.panelPick.Controls.Add(this.btnListDelete);
            this.panelPick.Name = "panelPick";
            // 
            // btnSwapAB
            // 
            resources.ApplyResources(this.btnSwapAB, "btnSwapAB");
            this.btnSwapAB.BackColor = System.Drawing.Color.Transparent;
            this.btnSwapAB.FlatAppearance.BorderSize = 0;
            this.btnSwapAB.Image = global::AgOpenGPS.Properties.Resources.ABSwapPoints;
            this.btnSwapAB.Name = "btnSwapAB";
            this.btnSwapAB.UseVisualStyleBackColor = false;
            this.btnSwapAB.Click += new System.EventHandler(this.btnSwapAB_Click);
            this.btnSwapAB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSwapAB_HelpRequested);
            // 
            // btnEditName
            // 
            resources.ApplyResources(this.btnEditName, "btnEditName");
            this.btnEditName.BackColor = System.Drawing.Color.Transparent;
            this.btnEditName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditName.FlatAppearance.BorderSize = 0;
            this.btnEditName.Image = global::AgOpenGPS.Properties.Resources.FileEditName;
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.UseVisualStyleBackColor = false;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            this.btnEditName.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnEditName_HelpRequested);
            // 
            // btnDuplicate
            // 
            resources.ApplyResources(this.btnDuplicate, "btnDuplicate");
            this.btnDuplicate.BackColor = System.Drawing.Color.Transparent;
            this.btnDuplicate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDuplicate.FlatAppearance.BorderSize = 0;
            this.btnDuplicate.Image = global::AgOpenGPS.Properties.Resources.FileCopy;
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.UseVisualStyleBackColor = false;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            this.btnDuplicate.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDuplicate_HelpRequested);
            // 
            // btnNewABLine
            // 
            resources.ApplyResources(this.btnNewABLine, "btnNewABLine");
            this.btnNewABLine.BackColor = System.Drawing.Color.Transparent;
            this.btnNewABLine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewABLine.FlatAppearance.BorderSize = 0;
            this.btnNewABLine.Image = global::AgOpenGPS.Properties.Resources.AddNew;
            this.btnNewABLine.Name = "btnNewABLine";
            this.btnNewABLine.UseVisualStyleBackColor = false;
            this.btnNewABLine.Click += new System.EventHandler(this.BtnNewABLine_Click);
            this.btnNewABLine.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnNewABLine_HelpRequested);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.SwitchOff;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancel_HelpRequested);
            // 
            // btnListUse
            // 
            resources.ApplyResources(this.btnListUse, "btnListUse");
            this.btnListUse.BackColor = System.Drawing.Color.Transparent;
            this.btnListUse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListUse.FlatAppearance.BorderSize = 0;
            this.btnListUse.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnListUse.Name = "btnListUse";
            this.btnListUse.UseVisualStyleBackColor = false;
            this.btnListUse.Click += new System.EventHandler(this.btnListUse_Click);
            this.btnListUse.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnListUse_HelpRequested);
            // 
            // btnListDelete
            // 
            resources.ApplyResources(this.btnListDelete, "btnListDelete");
            this.btnListDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnListDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListDelete.FlatAppearance.BorderSize = 0;
            this.btnListDelete.Image = global::AgOpenGPS.Properties.Resources.ABLineDelete;
            this.btnListDelete.Name = "btnListDelete";
            this.btnListDelete.UseVisualStyleBackColor = false;
            this.btnListDelete.Click += new System.EventHandler(this.btnListDelete_Click);
            this.btnListDelete.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnListDelete_HelpRequested);
            // 
            // panelEditName
            // 
            resources.ApplyResources(this.panelEditName, "panelEditName");
            this.panelEditName.BackColor = System.Drawing.Color.Transparent;
            this.panelEditName.Controls.Add(this.label3);
            this.panelEditName.Controls.Add(this.label2);
            this.panelEditName.Controls.Add(this.btnAddTimeEdit);
            this.panelEditName.Controls.Add(this.btnSaveEditName);
            this.panelEditName.Controls.Add(this.btnCancelEditName);
            this.panelEditName.Controls.Add(this.textBox2);
            this.panelEditName.Name = "panelEditName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnAddTimeEdit
            // 
            resources.ApplyResources(this.btnAddTimeEdit, "btnAddTimeEdit");
            this.btnAddTimeEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTimeEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddTimeEdit.FlatAppearance.BorderSize = 0;
            this.btnAddTimeEdit.Image = global::AgOpenGPS.Properties.Resources.Time;
            this.btnAddTimeEdit.Name = "btnAddTimeEdit";
            this.btnAddTimeEdit.UseVisualStyleBackColor = false;
            this.btnAddTimeEdit.Click += new System.EventHandler(this.btnAddTimeEdit_Click);
            // 
            // btnSaveEditName
            // 
            resources.ApplyResources(this.btnSaveEditName, "btnSaveEditName");
            this.btnSaveEditName.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveEditName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveEditName.FlatAppearance.BorderSize = 0;
            this.btnSaveEditName.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnSaveEditName.Name = "btnSaveEditName";
            this.btnSaveEditName.UseVisualStyleBackColor = false;
            this.btnSaveEditName.Click += new System.EventHandler(this.btnSaveEditName_Click);
            this.btnSaveEditName.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnSaveEditName_HelpRequested);
            // 
            // btnCancelEditName
            // 
            resources.ApplyResources(this.btnCancelEditName, "btnCancelEditName");
            this.btnCancelEditName.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelEditName.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEditName.FlatAppearance.BorderSize = 0;
            this.btnCancelEditName.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancelEditName.Name = "btnCancelEditName";
            this.btnCancelEditName.UseVisualStyleBackColor = false;
            this.btnCancelEditName.Click += new System.EventHandler(this.btnCancel_APlus_Click);
            this.btnCancelEditName.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancelEditName_HelpRequested);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.CausesValidation = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.textBox2_HelpRequested);
            // 
            // FormABLine
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelEditName);
            this.Controls.Add(this.panelPick);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.panelAPlus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormABLine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormABLine_FormClosing);
            this.Load += new System.EventHandler(this.FormABLine_Load);
            this.panelAPlus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeading)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelPick.ResumeLayout(false);
            this.panelEditName.ResumeLayout(false);
            this.panelEditName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBPoint;
        private System.Windows.Forms.Button btnAPoint;
        private System.Windows.Forms.Button btnListUse;
        private System.Windows.Forms.Button btnNewABLine;
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chField;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelAPlus;
        private System.Windows.Forms.Button btnCancel_APlus;
        private System.Windows.Forms.Button btnEnter_APlus;
        private System.Windows.Forms.NumericUpDown nudHeading;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnListDelete;
        private System.Windows.Forms.Panel panelPick;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.Panel panelEditName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTimeEdit;
        private System.Windows.Forms.Button btnSaveEditName;
        private System.Windows.Forms.Button btnCancelEditName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSwapAB;
        private System.Windows.Forms.Button btnManual;
    }
}