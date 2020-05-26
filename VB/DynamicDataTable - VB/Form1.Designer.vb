Namespace DynamicDataTable
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
			Me.cmbTables = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblTables = New DevExpress.XtraEditors.LabelControl()
			Me.pnlTables = New DevExpress.XtraEditors.PanelControl()
			Me.grdTableBrowser = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.cmbTables.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlTables, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlTables.SuspendLayout()
			CType(Me.grdTableBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cmbTables
			' 
			Me.cmbTables.Location = New System.Drawing.Point(136, 8)
			Me.cmbTables.Name = "cmbTables"
			Me.cmbTables.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbTables.Properties.Sorted = True
			Me.cmbTables.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbTables.Size = New System.Drawing.Size(198, 20)
			Me.cmbTables.TabIndex = 0
			' 
			' lblTables
			' 
			Me.lblTables.Location = New System.Drawing.Point(12, 11)
			Me.lblTables.Name = "lblTables"
			Me.lblTables.Size = New System.Drawing.Size(118, 13)
			Me.lblTables.TabIndex = 1
			Me.lblTables.Text = "Choose table to browse:"
			' 
			' pnlTables
			' 
			Me.pnlTables.Controls.Add(Me.lblTables)
			Me.pnlTables.Controls.Add(Me.cmbTables)
			Me.pnlTables.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlTables.Location = New System.Drawing.Point(0, 0)
			Me.pnlTables.Name = "pnlTables"
			Me.pnlTables.Size = New System.Drawing.Size(664, 36)
			Me.pnlTables.TabIndex = 2
			' 
			' grdTableBrowser
			' 
			Me.grdTableBrowser.Dock = System.Windows.Forms.DockStyle.Fill
			Me.grdTableBrowser.Location = New System.Drawing.Point(0, 36)
			Me.grdTableBrowser.MainView = Me.gridView1
			Me.grdTableBrowser.Name = "grdTableBrowser"
			Me.grdTableBrowser.Size = New System.Drawing.Size(664, 445)
			Me.grdTableBrowser.TabIndex = 3
			Me.grdTableBrowser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.grdTableBrowser
			Me.gridView1.Name = "gridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(664, 481)
			Me.Controls.Add(Me.grdTableBrowser)
			Me.Controls.Add(Me.pnlTables)
			Me.Name = "Form1"
			Me.Text = "Northwind Browser"
			CType(Me.cmbTables.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlTables, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlTables.ResumeLayout(False)
			Me.pnlTables.PerformLayout()
			CType(Me.grdTableBrowser, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cmbTables As DevExpress.XtraEditors.ComboBoxEdit
		Private lblTables As DevExpress.XtraEditors.LabelControl
		Private pnlTables As DevExpress.XtraEditors.PanelControl
		Private grdTableBrowser As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace

