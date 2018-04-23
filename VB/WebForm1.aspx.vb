Imports Microsoft.VisualBasic
Imports System
Imports NewProject
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.DashboardCommon
Imports DevExpress.Web

Namespace WebApplication1
	Partial Public Class WebForm1
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Protected Sub ASPxDashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DevExpress.DashboardWeb.DataLoadingWebEventArgs)
			Dim list As List(Of [MyClass]) = CreateDataSource()
			e.Data = list
		End Sub

		Private Shared Function CreateDataSource() As List(Of [MyClass])
			Dim list As New List(Of [MyClass])(10)
			Dim _r As New Random()
			For i As Integer = 0 To 9
				list.Add(New [MyClass]() With {.ID = i, .Name = "Name" & i, .Sales = CSng(_r.NextDouble()), .Date = DateTime.Now.AddDays(i)})
			Next i
			Return list
		End Function
	End Class
End Namespace