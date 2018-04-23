Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace ZoomTrackBarControl_MiddleValue
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim table As New DataTable()
			table.Columns.Add("Column")
			table.Rows.Add(True)
			Me.gridControl1.DataSource = table
		End Sub

	End Class
End Namespace
