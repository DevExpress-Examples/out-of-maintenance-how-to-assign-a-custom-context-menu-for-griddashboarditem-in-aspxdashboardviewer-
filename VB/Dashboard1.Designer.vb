Imports Microsoft.VisualBasic
Imports System
Namespace WebApplication1
	Partial Public Class Dashboard1
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.dashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
			CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' dashboardObjectDataSource1
			' 
			Me.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1"
			Me.dashboardObjectDataSource1.DataSource = GetType(NewProject.MyClass)
			Me.dashboardObjectDataSource1.Name = "Object Data Source 1"
			' 
			' gridDashboardItem1
			' 
			measure1.DataMember = "Sales"
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn1.AddDataItem("Measure", measure1)
			dimension1.DataMember = "Date"
			dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension1)
			Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridMeasureColumn1, gridDimensionColumn1})
			Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
			Me.gridDashboardItem1.DataItemRepository.Clear()
			Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.gridDashboardItem1.DataSource = Me.dashboardObjectDataSource1
			Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridDashboardItem1.Name = "Grid 1"
			Me.gridDashboardItem1.ShowCaption = True
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
			CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region
		Private dashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
		Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
	End Class
End Namespace
