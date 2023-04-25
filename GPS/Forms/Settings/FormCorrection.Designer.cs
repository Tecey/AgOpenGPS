namespace AgOpenGPS
{
    partial class FormCorrection 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorrection));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rollChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCorrectionDistance = new System.Windows.Forms.Label();
            this.lblEast = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRollDegrees = new System.Windows.Forms.Label();
            this.lblEastOnGraph = new System.Windows.Forms.Label();
            this.btnScroll = new System.Windows.Forms.Button();
            this.btnPoleOrMoving = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rollChart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rollChart
            // 
            resources.ApplyResources(this.rollChart, "rollChart");
            this.rollChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.rollChart.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MaximumAutoSize = 80F;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MaximumAutoSize = 80F;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.rollChart.ChartAreas.Add(chartArea1);
            this.rollChart.Name = "rollChart";
            this.rollChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Ro";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.Lime;
            series2.Name = "Ze";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Color = System.Drawing.Color.Cyan;
            series3.Name = "Oe";
            this.rollChart.Series.Add(series1);
            this.rollChart.Series.Add(series2);
            this.rollChart.Series.Add(series3);
            this.rollChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // lblCorrectionDistance
            // 
            resources.ApplyResources(this.lblCorrectionDistance, "lblCorrectionDistance");
            this.lblCorrectionDistance.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCorrectionDistance.ForeColor = System.Drawing.Color.Red;
            this.lblCorrectionDistance.Name = "lblCorrectionDistance";
            // 
            // lblEast
            // 
            resources.ApplyResources(this.lblEast, "lblEast");
            this.lblEast.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblEast.ForeColor = System.Drawing.Color.Lime;
            this.lblEast.Name = "lblEast";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // lblOst
            // 
            resources.ApplyResources(this.lblOst, "lblOst");
            this.lblOst.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblOst.ForeColor = System.Drawing.Color.Cyan;
            this.lblOst.Name = "lblOst";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.Color.LightSalmon;
            this.label6.Name = "label6";
            // 
            // lblRollDegrees
            // 
            resources.ApplyResources(this.lblRollDegrees, "lblRollDegrees");
            this.lblRollDegrees.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRollDegrees.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblRollDegrees.Name = "lblRollDegrees";
            // 
            // lblEastOnGraph
            // 
            resources.ApplyResources(this.lblEastOnGraph, "lblEastOnGraph");
            this.lblEastOnGraph.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblEastOnGraph.ForeColor = System.Drawing.Color.Lime;
            this.lblEastOnGraph.Name = "lblEastOnGraph";
            // 
            // btnScroll
            // 
            resources.ApplyResources(this.btnScroll, "btnScroll");
            this.btnScroll.BackColor = System.Drawing.Color.Transparent;
            this.btnScroll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScroll.ForeColor = System.Drawing.Color.Lime;
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.UseVisualStyleBackColor = false;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click_1);
            // 
            // btnPoleOrMoving
            // 
            resources.ApplyResources(this.btnPoleOrMoving, "btnPoleOrMoving");
            this.btnPoleOrMoving.BackColor = System.Drawing.Color.Transparent;
            this.btnPoleOrMoving.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPoleOrMoving.ForeColor = System.Drawing.Color.Lime;
            this.btnPoleOrMoving.Name = "btnPoleOrMoving";
            this.btnPoleOrMoving.UseVisualStyleBackColor = false;
            this.btnPoleOrMoving.Click += new System.EventHandler(this.btnPoleOrMoving_Click);
            // 
            // FormCorrection
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnPoleOrMoving);
            this.Controls.Add(this.btnScroll);
            this.Controls.Add(this.lblEastOnGraph);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRollDegrees);
            this.Controls.Add(this.lblOst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCorrectionDistance);
            this.Controls.Add(this.rollChart);
            this.Name = "FormCorrection";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormSteerGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rollChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart rollChart;
        private System.Windows.Forms.Label lblCorrectionDistance;
        private System.Windows.Forms.Label lblEast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRollDegrees;
        private System.Windows.Forms.Label lblEastOnGraph;
        private System.Windows.Forms.Button btnScroll;
        private System.Windows.Forms.Button btnPoleOrMoving;
    }
}