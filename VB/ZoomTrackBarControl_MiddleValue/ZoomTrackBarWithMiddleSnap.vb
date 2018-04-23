Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ZoomTrackBarControl_MiddleValue

	<UserRepositoryItem("Register")> _
	Public Class CustomRepositoryItem
		Inherits RepositoryItemZoomTrackBar
		Shared Sub New()
			Register()
		End Sub

		Public Sub New()
		End Sub

		Friend Const EditorName As String = "CustomZoomTrackBar"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(CustomZoomTrackBar), GetType(CustomRepositoryItem), GetType(CustomViewInfo), New ZoomTrackBarPainter(), Nothing))
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Private _SnapToMiddleValue As Boolean
		Public Property SnapToMiddleValue() As Boolean
			Get
				Return _SnapToMiddleValue
			End Get
			Set(ByVal value As Boolean)
				_SnapToMiddleValue = value
			End Set
		End Property

		Private _MiddleDistance As Integer
		Public Property MiddleDistance() As Integer
			Get
				If _MiddleDistance > 100 OrElse _MiddleDistance <= 0 Then
					_MiddleDistance = 10
				End If
				Return _MiddleDistance
			End Get
			Set(ByVal value As Integer)
				_MiddleDistance = value
			End Set
		End Property

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As CustomRepositoryItem = TryCast(item, CustomRepositoryItem)
				If source Is Nothing Then
					Return
				End If
				SnapToMiddleValue = source.SnapToMiddleValue
				MiddleDistance = source.MiddleDistance
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class

	<ToolboxItem(True)> _
	Public Class CustomZoomTrackBar
		Inherits ZoomTrackBarControl
		Shared Sub New()
			CustomRepositoryItem.Register()
		End Sub

		Public Sub New()
		End Sub


		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomRepositoryItem.EditorName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As CustomRepositoryItem
			Get
				Return TryCast(MyBase.Properties, CustomRepositoryItem)
			End Get
		End Property

	End Class

	Public Class CustomViewInfo
		Inherits ZoomTrackBarViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public Overrides Function ValueFromPoint(ByVal p As Point) As Integer
			Dim customItem As CustomRepositoryItem = CType(Me.Item, CustomRepositoryItem)
			Dim middle As Integer = If((customItem.AllowUseMiddleValue), customItem.Middle, (customItem.Minimum + customItem.Maximum) / 2)
			Dim value As Integer = MyBase.ValueFromPoint(p)
			Dim middleDistance As Integer = (customItem.Minimum + customItem.Maximum) / customItem.MiddleDistance

			If value >= middle - middleDistance AndAlso value <= middle + middleDistance Then
				Return middle
			End If
			Return value
		End Function

	End Class

End Namespace
