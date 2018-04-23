Imports Microsoft.VisualBasic
Imports System
Namespace ZoomTrackBarControl_MiddleValue
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.customRepositoryItem1 = New ZoomTrackBarControl_MiddleValue.CustomRepositoryItem()
			Me.customZoomTrackBar1 = New ZoomTrackBarControl_MiddleValue.CustomZoomTrackBar()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customRepositoryItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customZoomTrackBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(12, 54)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.customRepositoryItem1})
			Me.gridControl1.Size = New System.Drawing.Size(400, 200)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.ColumnEdit = Me.customRepositoryItem1
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' customRepositoryItem1
			' 
			Me.customRepositoryItem1.Maximum = 100
			Me.customRepositoryItem1.Middle = 5
			Me.customRepositoryItem1.MiddleDistance = 50
			Me.customRepositoryItem1.Name = "customRepositoryItem1"
			Me.customRepositoryItem1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.customRepositoryItem1.SnapToMiddleValue = False
			' 
			' customZoomTrackBar1
			' 
			Me.customZoomTrackBar1.EditValue = Nothing
			Me.customZoomTrackBar1.Location = New System.Drawing.Point(12, 12)
			Me.customZoomTrackBar1.Name = "customZoomTrackBar1"
			Me.customZoomTrackBar1.Properties.Maximum = 100
			Me.customZoomTrackBar1.Properties.Middle = 5
			Me.customZoomTrackBar1.Properties.MiddleDistance = 10
			Me.customZoomTrackBar1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.customZoomTrackBar1.Properties.SnapToMiddleValue = False
			Me.customZoomTrackBar1.Size = New System.Drawing.Size(202, 23)
			Me.customZoomTrackBar1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(429, 266)
			Me.Controls.Add(Me.customZoomTrackBar1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customRepositoryItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customZoomTrackBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private customZoomTrackBar1 As CustomZoomTrackBar
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private customRepositoryItem1 As CustomRepositoryItem



	End Class
End Namespace

