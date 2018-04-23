﻿Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.ConnectionParameters

Namespace Dashboard_OlapDataProvider
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            dashboardDesigner1.CreateRibbon()

'            #Region "#OLAPDataSource"
            Dim awParameters As New OlapConnectionParameters("provider=MSOLAP;" _
                                & ControlChars.CrLf & _
                                "data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" _
                                & ControlChars.CrLf & _
                                "initial catalog=Adventure Works DW Standard Edition;" _
                                & ControlChars.CrLf & _
                                "cube name=Adventure Works;")
            Dim awConnection As New OlapDataConnection("AW connection", awParameters)
            Dim olapProvider As New OlapDataProvider(awConnection)
            Dim olapDataSource As New DataSource("OLAP Data Source", olapProvider)

            dashboardDesigner1.Dashboard.DataSources.Add(olapDataSource)
'            #End Region ' #OLAPDataSource

            InitializeDashboardItems()
        End Sub

        Private Sub InitializeDashboardItems()
            Dim olapDataSource As DataSource = dashboardDesigner1.Dashboard.DataSources(0)

            Dim pivot As New PivotDashboardItem()
            pivot.DataSource = olapDataSource
            pivot.Values.Add(New Measure("[Measures].[Sales Amount]"))
            pivot.Columns.Add(New Dimension("[Sales Channel].[Sales Channel].[Sales Channel]"))
            pivot.Rows.AddRange(New Dimension("[Sales Territory].[Sales Territory].[Group]", 1),
                                New Dimension("[Sales Territory].[Sales Territory].[Country]", 1),
                                New Dimension("[Sales Territory].[Sales Territory].[Region]", 1))
            pivot.AutoExpandRowGroups = True

            Dim chart As New ChartDashboardItem()
            chart.DataSource = olapDataSource
            chart.Arguments.Add(New Dimension("[Sales Territory].[Sales Territory].[Country]"))
            chart.Panes.Add(New ChartPane())
            Dim salesAmountSeries As New SimpleSeries(SimpleSeriesType.Bar)
            salesAmountSeries.Value = New Measure("[Measures].[Sales Amount]")
            chart.Panes(0).Series.Add(salesAmountSeries)

            dashboardDesigner1.Dashboard.Items.AddRange(pivot, chart)
        End Sub
    End Class
End Namespace
