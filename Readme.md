<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128568428/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T377721)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/AdditionalLegendSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AdditionalLegendSample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/AdditionalLegendSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AdditionalLegendSample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Add an Additional Legend to a Chart


This example demonstrates how to add an additional legend to a chart.


<h3>Description</h3>

<p>To do this, add a newly created&nbsp;<strong>Legend</strong>&nbsp;object to the&nbsp;<strong>ChartControl.Legends&nbsp;</strong>collection.&nbsp;<br>Dock it to the required pane or the chart using the&nbsp;<strong>DockTarget&nbsp;</strong>property. Then, position the legend using the&nbsp;<strong>HorizontalPosition</strong>&nbsp;and&nbsp;<strong>VerticalPosition&nbsp;</strong>properties.<br>Assign the legend to a chart&nbsp;element whose legend item should be displayed in the legend, binding the&nbsp;<strong>Legend</strong>&nbsp;property of a series, an indicator, a constant line or a strip to the legend object.<br>Note that a legend will not be visualized until it is bound to any element's&nbsp;<strong>Legend</strong>&nbsp;property.</p>

<br/>


