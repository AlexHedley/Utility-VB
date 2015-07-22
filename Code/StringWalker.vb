Public Class StringWalker
	Private ReadOnly _s As String

	Public Property Index() As Integer
		Get
			Return m_Index
		End Get
		Private Set
			m_Index = Value
		End Set
	End Property
	Private m_Index As Integer
	Public Property IsEscaped() As Boolean
		Get
			Return m_IsEscaped
		End Get
		Private Set
			m_IsEscaped = Value
		End Set
	End Property
	Private m_IsEscaped As Boolean
	Public Property CurrentChar() As Char
		Get
			Return m_CurrentChar
		End Get
		Private Set
			m_CurrentChar = Value
		End Set
	End Property
	Private m_CurrentChar As Char

	Public Sub New(s As String)
		_s = s
		Me.Index = -1
	End Sub

	Public Function MoveNext() As Boolean
		If Me.Index = _s.Length - 1 Then
			Return False
		End If

		If IsEscaped = False Then
			IsEscaped = CurrentChar = "\"C
		Else
			IsEscaped = False
		End If
		Me.Index += 1
		CurrentChar = _s(Index)
		Return True
	End Function
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================