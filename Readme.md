<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/HiddenLabelsSample/Form1.cs) (VB: [Form1.vb](./VB/HiddenLabelsSample/Form1.vb))**
<!-- default file list end -->
# How to: Hide an Individual Series Label


This example demonstrates how to hide an individual series label.


<h3>Description</h3>

<p>Handle the&nbsp;<a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.CustomDrawSeriesPoint.event">ChartControl.CustomDrawSeriesPoint</a>&nbsp;event to conditionally hide series labels. In the event handler, change the&nbsp;<a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Charts.CustomDrawSeriesPointEventArgs.LabelText.property">CustomDrawSeriesPointEventArgs.LabelText</a>&nbsp;property value to&nbsp;<strong>String.Empty</strong>&nbsp;to hide a label.</p>
<p>Note that to perform the same&nbsp;for the Chart Control for ASP.NET, it is necessary to handle the&nbsp;<a href="https://documentation.devexpress.com/AspNet/DevExpress.XtraCharts.Web.WebChartControl.CustomDrawSeriesPoint.event">WebChartControl.CustomDrawSeriesPoint</a>&nbsp;event.</p>
<p>&nbsp;</p>

<br/>


