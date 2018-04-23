namespace HiddenLabelsSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.StackedBarSeriesLabel stackedBarSeriesLabel1 = new DevExpress.XtraCharts.StackedBarSeriesLabel();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gspTableAdapter1 = new HiddenLabelsSample.gspDataSetTableAdapters.GSPTableAdapter();
            this.gSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gspDataSet1 = new HiddenLabelsSample.gspDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.gspTableAdapter1;
            this.chartControl1.DataBindings = null;
            this.chartControl1.DataSource = this.gSPBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Year";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Region";
            stackedBarSeriesLabel1.TextPattern = "{V:0.##}";
            this.chartControl1.SeriesTemplate.Label = stackedBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            this.chartControl1.SeriesTemplate.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "GSP";
            this.chartControl1.SeriesTemplate.View = stackedBarSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(624, 321);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.OnCustomDrawSeriesPoint);
            // 
            // gspTableAdapter1
            // 
            this.gspTableAdapter1.ClearBeforeFill = true;
            // 
            // gSPBindingSource
            // 
            this.gSPBindingSource.DataMember = "GSP";
            this.gSPBindingSource.DataSource = this.gspDataSet1;
            this.gSPBindingSource.Position = 0;
            this.gSPBindingSource.Sort = "";
            // 
            // gspDataSet1
            // 
            this.gspDataSet1.DataSetName = "gspDataSet";
            this.gspDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private gspDataSetTableAdapters.GSPTableAdapter gspTableAdapter1;
        private System.Windows.Forms.BindingSource gSPBindingSource;
        private gspDataSet gspDataSet1;
    }
}

