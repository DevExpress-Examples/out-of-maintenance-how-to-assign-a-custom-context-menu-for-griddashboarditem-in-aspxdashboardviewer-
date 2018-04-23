Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.Data

Namespace NewProject
	Public Class [MyClass]
		Public Sub New()

		End Sub

		' Fields...
		Private _Date As DateTime
		Private _Sales As Single
		Private _ID As Integer

		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property

		' Fields...
		Private _Name As String

		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property


		Public Property Sales() As Single
			Get
				Return _Sales
			End Get
			Set(ByVal value As Single)
				_Sales = value
			End Set
		End Property


		Public Property [Date]() As DateTime
			Get
				Return _Date
			End Get
			Set(ByVal value As DateTime)
				_Date = value
			End Set
		End Property
	End Class
End Namespace
