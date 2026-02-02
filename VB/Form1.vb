Imports System
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DynamicDataTable

    Public Partial Class Form1
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
            Dim tablesList As String() = connectionProvider.GetStorageTablesList(False)
            dynamicClasses = New Dictionary(Of String, DynamicDataTableClassInfo)(tablesList.Length)
            cmbTables.Properties.Items.AddRange(tablesList)
            AddHandler cmbTables.SelectedIndexChanged, Sub(ByVal sender, ByVal args) FillGrid(cmbTables.Text)
        End Sub

        Protected Sub FillGrid(ByVal tableName As String)
            If TypeOf grdTableBrowser.DataSource Is IDisposable Then
                CType(grdTableBrowser.DataSource, IDisposable).Dispose()
            End If

            grdTableBrowser.DataSource = Nothing
            gridView1.OptionsBehavior.Editable = False
            gridView1.Columns.Clear()
            Dim dataTable As DataTable = New DataTable(tableName)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(String.Format("SELECT * FROM [{0}]", tableName), connection)
            Try
                adapter.FillSchema(dataTable, SchemaType.Source)
                Dim dataTableClassInfo As DynamicDataTableClassInfo
                If Not dynamicClasses.TryGetValue(tableName, dataTableClassInfo) Then
                    dynamicClasses.Add(tableName, New DynamicDataTableClassInfo(workSession.Dictionary, dataTable))
                End If

                Dim dataSource As XPServerCollectionSource = New XPServerCollectionSource(workSession, dynamicClasses(tableName))
                grdTableBrowser.DataSource = dataSource
                'grdTableBrowser.ServerMode = true;
                grdTableBrowser.ForceInitialize()
            Catch ex As Exception
                Call MessageBox.Show(ex.ToString())
            End Try
        End Sub
    End Class
End Namespace
