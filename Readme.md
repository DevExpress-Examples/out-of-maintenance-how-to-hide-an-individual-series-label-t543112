<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574766/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T543112)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


