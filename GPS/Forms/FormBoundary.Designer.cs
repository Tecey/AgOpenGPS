namespace AgOpenGPS
{
    partial class FormBoundary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoundary));
            this.Boundary = new System.Windows.Forms.Label();
            this.Thru = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBingMaps = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpenGoogleEarth = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelChoose = new System.Windows.Forms.Panel();
            this.btnCancelChoose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetKML = new System.Windows.Forms.Button();
            this.btnDriveOrExt = new System.Windows.Forms.Button();
            this.panelKML = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelKML = new System.Windows.Forms.Button();
            this.btnLoadBoundaryFromGE = new System.Windows.Forms.Button();
            this.btnLoadMultiBoundaryFromGE = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelChoose.SuspendLayout();
            this.panelKML.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boundary
            // 
            resources.ApplyResources(this.Boundary, "Boundary");
            this.Boundary.BackColor = System.Drawing.Color.Transparent;
            this.Boundary.ForeColor = System.Drawing.Color.Black;
            this.Boundary.Name = "Boundary";
            // 
            // Thru
            // 
            resources.ApplyResources(this.Thru, "Thru");
            this.Thru.BackColor = System.Drawing.Color.Transparent;
            this.Thru.ForeColor = System.Drawing.Color.Black;
            this.Thru.Name = "Thru";
            // 
            // Area
            // 
            resources.ApplyResources(this.Area, "Area");
            this.Area.BackColor = System.Drawing.Color.Transparent;
            this.Area.ForeColor = System.Drawing.Color.Black;
            this.Area.Name = "Area";
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMain.Controls.Add(this.btnBingMaps);
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.Area);
            this.panelMain.Controls.Add(this.Thru);
            this.panelMain.Controls.Add(this.Boundary);
            this.panelMain.Controls.Add(this.btnOpenGoogleEarth);
            this.panelMain.Controls.Add(this.btnDeleteAll);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Name = "panelMain";
            // 
            // btnBingMaps
            // 
            resources.ApplyResources(this.btnBingMaps, "btnBingMaps");
            this.btnBingMaps.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnBingMaps.FlatAppearance.BorderSize = 0;
            this.btnBingMaps.Image = global::AgOpenGPS.Properties.Resources.bing1;
            this.btnBingMaps.Name = "btnBingMaps";
            this.btnBingMaps.UseVisualStyleBackColor = true;
            this.btnBingMaps.Click += new System.EventHandler(this.btnBingMaps_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Image = global::AgOpenGPS.Properties.Resources.AddNew;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnAdd_HelpRequested);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnCancel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnCancel_HelpRequested);
            // 
            // btnOpenGoogleEarth
            // 
            resources.ApplyResources(this.btnOpenGoogleEarth, "btnOpenGoogleEarth");
            this.btnOpenGoogleEarth.FlatAppearance.BorderSize = 0;
            this.btnOpenGoogleEarth.Image = global::AgOpenGPS.Properties.Resources.GoogleEarth;
            this.btnOpenGoogleEarth.Name = "btnOpenGoogleEarth";
            this.btnOpenGoogleEarth.UseVisualStyleBackColor = true;
            this.btnOpenGoogleEarth.Click += new System.EventHandler(this.btnOpenGoogleEarth_Click);
            this.btnOpenGoogleEarth.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnOpenGoogleEarth_HelpRequested);
            // 
            // btnDeleteAll
            // 
            resources.ApplyResources(this.btnDeleteAll, "btnDeleteAll");
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.Image = global::AgOpenGPS.Properties.Resources.BoundaryDeleteAll;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            this.btnDeleteAll.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDeleteAll_HelpRequested);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Image = global::AgOpenGPS.Properties.Resources.BoundaryDelete;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDelete_HelpRequested);
            // 
            // panelChoose
            // 
            resources.ApplyResources(this.panelChoose, "panelChoose");
            this.panelChoose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelChoose.Controls.Add(this.btnCancelChoose);
            this.panelChoose.Controls.Add(this.label4);
            this.panelChoose.Controls.Add(this.btnGetKML);
            this.panelChoose.Controls.Add(this.btnDriveOrExt);
            this.panelChoose.Name = "panelChoose";
            // 
            // btnCancelChoose
            // 
            resources.ApplyResources(this.btnCancelChoose, "btnCancelChoose");
            this.btnCancelChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelChoose.FlatAppearance.BorderSize = 0;
            this.btnCancelChoose.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancelChoose.Name = "btnCancelChoose";
            this.btnCancelChoose.UseVisualStyleBackColor = false;
            this.btnCancelChoose.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // btnGetKML
            // 
            resources.ApplyResources(this.btnGetKML, "btnGetKML");
            this.btnGetKML.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGetKML.FlatAppearance.BorderSize = 0;
            this.btnGetKML.Image = global::AgOpenGPS.Properties.Resources.BoundaryLoadFromGE;
            this.btnGetKML.Name = "btnGetKML";
            this.btnGetKML.UseVisualStyleBackColor = true;
            this.btnGetKML.Click += new System.EventHandler(this.btnGetKML_Click);
            this.btnGetKML.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnGetKML_HelpRequested);
            // 
            // btnDriveOrExt
            // 
            resources.ApplyResources(this.btnDriveOrExt, "btnDriveOrExt");
            this.btnDriveOrExt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDriveOrExt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDriveOrExt.FlatAppearance.BorderSize = 0;
            this.btnDriveOrExt.Image = global::AgOpenGPS.Properties.Resources.SteerRight;
            this.btnDriveOrExt.Name = "btnDriveOrExt";
            this.btnDriveOrExt.UseVisualStyleBackColor = true;
            this.btnDriveOrExt.Click += new System.EventHandler(this.btnDriveOrExt_Click);
            this.btnDriveOrExt.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnDriveOrExt_HelpRequested);
            // 
            // panelKML
            // 
            resources.ApplyResources(this.panelKML, "panelKML");
            this.panelKML.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelKML.Controls.Add(this.label5);
            this.panelKML.Controls.Add(this.label3);
            this.panelKML.Controls.Add(this.btnCancelKML);
            this.panelKML.Controls.Add(this.btnLoadBoundaryFromGE);
            this.panelKML.Controls.Add(this.btnLoadMultiBoundaryFromGE);
            this.panelKML.Name = "panelKML";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // btnCancelKML
            // 
            resources.ApplyResources(this.btnCancelKML, "btnCancelKML");
            this.btnCancelKML.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelKML.FlatAppearance.BorderSize = 0;
            this.btnCancelKML.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancelKML.Name = "btnCancelKML";
            this.btnCancelKML.UseVisualStyleBackColor = false;
            this.btnCancelKML.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLoadBoundaryFromGE
            // 
            resources.ApplyResources(this.btnLoadBoundaryFromGE, "btnLoadBoundaryFromGE");
            this.btnLoadBoundaryFromGE.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadBoundaryFromGE.FlatAppearance.BorderSize = 0;
            this.btnLoadBoundaryFromGE.Image = global::AgOpenGPS.Properties.Resources.BoundaryLoadFromGE;
            this.btnLoadBoundaryFromGE.Name = "btnLoadBoundaryFromGE";
            this.btnLoadBoundaryFromGE.UseVisualStyleBackColor = true;
            this.btnLoadBoundaryFromGE.Click += new System.EventHandler(this.btnLoadBoundaryFromGE_Click);
            this.btnLoadBoundaryFromGE.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnLoadBoundaryFromGE_HelpRequested);
            // 
            // btnLoadMultiBoundaryFromGE
            // 
            resources.ApplyResources(this.btnLoadMultiBoundaryFromGE, "btnLoadMultiBoundaryFromGE");
            this.btnLoadMultiBoundaryFromGE.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadMultiBoundaryFromGE.FlatAppearance.BorderSize = 0;
            this.btnLoadMultiBoundaryFromGE.Image = global::AgOpenGPS.Properties.Resources.BoundaryLoadMultiFromGE;
            this.btnLoadMultiBoundaryFromGE.Name = "btnLoadMultiBoundaryFromGE";
            this.btnLoadMultiBoundaryFromGE.UseVisualStyleBackColor = true;
            this.btnLoadMultiBoundaryFromGE.Click += new System.EventHandler(this.btnLoadBoundaryFromGE_Click);
            this.btnLoadMultiBoundaryFromGE.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.btnLoadMultiBoundaryFromGE_HelpRequested);
            // 
            // FormBoundary
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.panelChoose);
            this.Controls.Add(this.panelKML);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBoundary";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBoundary_FormClosing);
            this.Load += new System.EventHandler(this.FormBoundary_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelChoose.ResumeLayout(false);
            this.panelChoose.PerformLayout();
            this.panelKML.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label Boundary;
        private System.Windows.Forms.Label Thru;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoadMultiBoundaryFromGE;
        private System.Windows.Forms.Button btnLoadBoundaryFromGE;
        private System.Windows.Forms.Button btnDriveOrExt;
        private System.Windows.Forms.Button btnOpenGoogleEarth;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelKML;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetKML;
        private System.Windows.Forms.Button btnCancelKML;
        private System.Windows.Forms.Button btnCancelChoose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBingMaps;
    }
}