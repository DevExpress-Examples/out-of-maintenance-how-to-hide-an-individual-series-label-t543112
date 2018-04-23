Namespace HiddenLabelsSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim stackedBarSeriesLabel1 As New DevExpress.XtraCharts.StackedBarSeriesLabel()
            Dim stackedBarSeriesView1 As New DevExpress.XtraCharts.StackedBarSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.gspTableAdapter1 = New HiddenLabelsSample.gspDataSetTableAdapters.GSPTableAdapter()
            Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gspDataSet1 = New HiddenLabelsSample.gspDataSet()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(stackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gspDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.DataAdapter = Me.gspTableAdapter1
            Me.chartControl1.DataBindings = Nothing
            Me.chartControl1.DataSource = Me.gSPBindingSource
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.Rotated = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "Year"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Region"
            stackedBarSeriesLabel1.TextPattern = "{V:0.##}"
            Me.chartControl1.SeriesTemplate.Label = stackedBarSeriesLabel1
            Me.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
            Me.chartControl1.SeriesTemplate.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "GSP"
            Me.chartControl1.SeriesTemplate.View = stackedBarSeriesView1
            Me.chartControl1.Size = New System.Drawing.Size(624, 321)
            Me.chartControl1.TabIndex = 0
            ' 
            ' gspTableAdapter1
            ' 
            Me.gspTableAdapter1.ClearBeforeFill = True
            ' 
            ' gSPBindingSource
            ' 
            Me.gSPBindingSource.DataMember = "GSP"
            Me.gSPBindingSource.DataSource = Me.gspDataSet1
            Me.gSPBindingSource.Position = 0
            Me.gSPBindingSource.Sort = ""
            ' 
            ' gspDataSet1
            ' 
            Me.gspDataSet1.DataSetName = "gspDataSet"
            Me.gspDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(stackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gspDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
        Private gspTableAdapter1 As gspDataSetTableAdapters.GSPTableAdapter
        Private gSPBindingSource As System.Windows.Forms.BindingSource
        Private gspDataSet1 As gspDataSet
    End Class
End Namespace

