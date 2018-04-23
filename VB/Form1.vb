Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DynamicDataTable
	Partial Public Class Form1
		Inherits Form
		Private ReadOnly connectionString As String = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
		Private connection As SqlConnection
		Private connectionProvider As MSSqlConnectionProvider
		Private workSession As Session
		Private dynamicClasses As Dictionary(Of String, DynamicDataTableClassInfo)
		Public Sub New()
			InitializeComponent()
			Init()
		End Sub
		Protected Sub Init()
			connection = New SqlConnection(connectionString)
			connectionProvider = New MSSqlConnectionProvider(connection, AutoCreateOption.None)
			Dim dal As IDataLayer = New SimpleDataLayer(connectionProvider)
			workSession = New Session(dal)
			Dim tablesList() As String = connectionProvider.GetStorageTablesList()
			dynamicClasses = New Dictionary(Of String, DynamicDataTableClassInfo)(tablesList.Length)
			cmbTables.Properties.Items.AddRange(tablesList)
			AddHandler cmbTables.SelectedIndexChanged, AddressOf AnonymousMethod1
		End Sub
		
		Private Sub AnonymousMethod1(ByVal sender As Object, ByVal args As EventArgs)
			FillGrid(cmbTables.Text)
		End Sub
		Protected Sub FillGrid(ByVal tableName As String)
			grdTableBrowser.DataSource = Nothing
			gridView1.OptionsBehavior.Editable = False
			gridView1.Columns.Clear()
			Dim adapter As New SqlDataAdapter(String.Format("SELECT * FROM [{0}]", tableName), connection)
			Dim dataTable As New DataTable(tableName)
			adapter.FillSchema(dataTable, SchemaType.Source)
			Dim dataTableClassInfo As DynamicDataTableClassInfo = Nothing
			If (Not dynamicClasses.TryGetValue(tableName, dataTableClassInfo)) Then
				dynamicClasses.Add(tableName, New DynamicDataTableClassInfo(workSession.Dictionary, dataTable))
			End If
			Dim dataSource As New XPServerCollectionSource(workSession, dynamicClasses(tableName))
			grdTableBrowser.DataSource = dataSource
			'grdTableBrowser.ServerMode = True
			grdTableBrowser.ForceInitialize()
		End Sub
	End Class
End Namespace