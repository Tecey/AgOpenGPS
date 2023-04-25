namespace AgOpenGPS
{
    partial class FormMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMap));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbTileServers = new System.Windows.Forms.ComboBox();
            this.mapControl = new System.Windows.Forms.MapControl();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnGray = new System.Windows.Forms.Button();
            this.cboxDrawMap = new System.Windows.Forms.CheckBox();
            this.cboxEnableLineDraw = new System.Windows.Forms.CheckBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnAddFence = new System.Windows.Forms.Button();
            this.btnDeletePoint = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.gboxField = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxBoundary = new System.Windows.Forms.GroupBox();
            this.lblBnds = new System.Windows.Forms.Label();
            this.btnReCenter = new System.Windows.Forms.Button();
            this.gboxField.SuspendLayout();
            this.gboxBoundary.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbTileServers
            // 
            resources.ApplyResources(this.cmbTileServers, "cmbTileServers");
            this.cmbTileServers.AllowDrop = true;
            this.cmbTileServers.DisplayMember = "Name";
            this.cmbTileServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTileServers.FormattingEnabled = true;
            this.cmbTileServers.Name = "cmbTileServers";
            this.cmbTileServers.Tag = "";
            this.cmbTileServers.SelectedIndexChanged += new System.EventHandler(this.cmbTileServers_SelectedIndexChanged);
            // 
            // mapControl
            // 
            resources.ApplyResources(this.mapControl, "mapControl");
            this.mapControl.BackColor = System.Drawing.Color.White;
            this.mapControl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mapControl.ErrorColor = System.Drawing.Color.Red;
            this.mapControl.FitToBounds = true;
            this.mapControl.ForeColor = System.Drawing.Color.Black;
            this.mapControl.Name = "mapControl";
            this.mapControl.ShowThumbnails = true;
            this.mapControl.ThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mapControl.ThumbnailForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.mapControl.ThumbnailText = "Downloading...";
            this.mapControl.TileImageAttributes = null;
            this.mapControl.ZoomLevel = 2;
            this.mapControl.Click += new System.EventHandler(this.mapControl_Click);
            this.mapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseMove);
            this.mapControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseWheel);
            // 
            // lblPoints
            // 
            resources.ApplyResources(this.lblPoints, "lblPoints");
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPoints.Name = "lblPoints";
            // 
            // btnGray
            // 
            resources.ApplyResources(this.btnGray, "btnGray");
            this.btnGray.BackColor = System.Drawing.Color.Transparent;
            this.btnGray.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGray.FlatAppearance.BorderSize = 0;
            this.btnGray.Image = global::AgOpenGPS.Properties.Resources.MapColor;
            this.btnGray.Name = "btnGray";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // cboxDrawMap
            // 
            resources.ApplyResources(this.cboxDrawMap, "cboxDrawMap");
            this.cboxDrawMap.BackColor = System.Drawing.Color.Transparent;
            this.cboxDrawMap.FlatAppearance.BorderSize = 0;
            this.cboxDrawMap.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxDrawMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxDrawMap.Image = global::AgOpenGPS.Properties.Resources.MappingOff;
            this.cboxDrawMap.Name = "cboxDrawMap";
            this.cboxDrawMap.UseVisualStyleBackColor = false;
            this.cboxDrawMap.Click += new System.EventHandler(this.cboxDrawMap_Click);
            // 
            // cboxEnableLineDraw
            // 
            resources.ApplyResources(this.cboxEnableLineDraw, "cboxEnableLineDraw");
            this.cboxEnableLineDraw.BackColor = System.Drawing.Color.Transparent;
            this.cboxEnableLineDraw.FlatAppearance.BorderSize = 0;
            this.cboxEnableLineDraw.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            this.cboxEnableLineDraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxEnableLineDraw.Image = global::AgOpenGPS.Properties.Resources.Boundary;
            this.cboxEnableLineDraw.Name = "cboxEnableLineDraw";
            this.cboxEnableLineDraw.UseVisualStyleBackColor = false;
            this.cboxEnableLineDraw.Click += new System.EventHandler(this.cboxEnableLineDraw_Click);
            // 
            // btnDeleteAll
            // 
            resources.ApplyResources(this.btnDeleteAll, "btnDeleteAll");
            this.btnDeleteAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.Image = global::AgOpenGPS.Properties.Resources.BoundaryDelete;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnAddFence
            // 
            resources.ApplyResources(this.btnAddFence, "btnAddFence");
            this.btnAddFence.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFence.FlatAppearance.BorderSize = 0;
            this.btnAddFence.Image = global::AgOpenGPS.Properties.Resources.BoundaryOuter;
            this.btnAddFence.Name = "btnAddFence";
            this.btnAddFence.UseVisualStyleBackColor = false;
            this.btnAddFence.Click += new System.EventHandler(this.btnAddFence_Click);
            // 
            // btnDeletePoint
            // 
            resources.ApplyResources(this.btnDeletePoint, "btnDeletePoint");
            this.btnDeletePoint.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePoint.FlatAppearance.BorderSize = 0;
            this.btnDeletePoint.Image = global::AgOpenGPS.Properties.Resources.PointDelete;
            this.btnDeletePoint.Name = "btnDeletePoint";
            this.btnDeletePoint.UseVisualStyleBackColor = false;
            this.btnDeletePoint.Click += new System.EventHandler(this.btnDeletePoint_Click);
            // 
            // btnGo
            // 
            resources.ApplyResources(this.btnGo, "btnGo");
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.Image = global::AgOpenGPS.Properties.Resources.FlagGrn;
            this.btnGo.Name = "btnGo";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnZoomIn
            // 
            resources.ApplyResources(this.btnZoomIn, "btnZoomIn");
            this.btnZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomIn.BackgroundImage = global::AgOpenGPS.Properties.Resources.ZoomIn48;
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            resources.ApplyResources(this.btnZoomOut, "btnZoomOut");
            this.btnZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomOut.BackgroundImage = global::AgOpenGPS.Properties.Resources.ZoomOut48;
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnSaveImage
            // 
            resources.ApplyResources(this.btnSaveImage, "btnSaveImage");
            this.btnSaveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveImage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveImage.FlatAppearance.BorderSize = 0;
            this.btnSaveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveImage.Image = global::AgOpenGPS.Properties.Resources.FileSave;
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // gboxField
            // 
            resources.ApplyResources(this.gboxField, "gboxField");
            this.gboxField.Controls.Add(this.label1);
            this.gboxField.Controls.Add(this.cboxDrawMap);
            this.gboxField.Controls.Add(this.btnSaveImage);
            this.gboxField.Controls.Add(this.btnGray);
            this.gboxField.Name = "gboxField";
            this.gboxField.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gboxBoundary
            // 
            resources.ApplyResources(this.gboxBoundary, "gboxBoundary");
            this.gboxBoundary.Controls.Add(this.lblBnds);
            this.gboxBoundary.Controls.Add(this.cboxEnableLineDraw);
            this.gboxBoundary.Controls.Add(this.btnAddFence);
            this.gboxBoundary.Controls.Add(this.btnDeleteAll);
            this.gboxBoundary.Controls.Add(this.lblPoints);
            this.gboxBoundary.Controls.Add(this.btnDeletePoint);
            this.gboxBoundary.Name = "gboxBoundary";
            this.gboxBoundary.TabStop = false;
            // 
            // lblBnds
            // 
            resources.ApplyResources(this.lblBnds, "lblBnds");
            this.lblBnds.BackColor = System.Drawing.Color.Transparent;
            this.lblBnds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBnds.Name = "lblBnds";
            // 
            // btnReCenter
            // 
            resources.ApplyResources(this.btnReCenter, "btnReCenter");
            this.btnReCenter.BackColor = System.Drawing.Color.Transparent;
            this.btnReCenter.FlatAppearance.BorderSize = 0;
            this.btnReCenter.Image = global::AgOpenGPS.Properties.Resources.WindowRestore;
            this.btnReCenter.Name = "btnReCenter";
            this.btnReCenter.UseVisualStyleBackColor = false;
            this.btnReCenter.Click += new System.EventHandler(this.btnReCenter_Click);
            // 
            // FormMap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ControlBox = false;
            this.Controls.Add(this.btnReCenter);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gboxField);
            this.Controls.Add(this.cmbTileServers);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.gboxBoundary);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMap";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHeadland_FormClosing);
            this.Load += new System.EventHandler(this.FormHeadland_Load);
            this.gboxField.ResumeLayout(false);
            this.gboxField.PerformLayout();
            this.gboxBoundary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbTileServers;
        private System.Windows.Forms.MapControl mapControl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDeletePoint;
        private System.Windows.Forms.Button btnAddFence;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.CheckBox cboxEnableLineDraw;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.CheckBox cboxDrawMap;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.GroupBox gboxField;
        private System.Windows.Forms.GroupBox gboxBoundary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBnds;
        private System.Windows.Forms.Button btnReCenter;
    }
}