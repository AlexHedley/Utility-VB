Imports System.Text

Public Class JsonFormatter
    Private ReadOnly _walker As StringWalker
    Private ReadOnly _writer As New IndentWriter()
    Private ReadOnly _currentLine As New StringBuilder()
    Private _quoted As Boolean

    Public Sub New(json As String)
        _walker = New StringWalker(json)
        ResetLine()
    End Sub

    Public Sub ResetLine()
        _currentLine.Length = 0
    End Sub

    Public Function Format() As String
        While MoveNextChar()
            If Me._quoted = False AndAlso Me.IsOpenBracket() Then
                Me.WriteCurrentLine()
                Me.AddCharToLine()
                Me.WriteCurrentLine()
                _writer.Indent()
            ElseIf Me._quoted = False AndAlso Me.IsCloseBracket() Then
                Me.WriteCurrentLine()
                _writer.UnIndent()
                Me.AddCharToLine()
            ElseIf Me._quoted = False AndAlso Me.IsColon() Then
                Me.AddCharToLine()
                Me.WriteCurrentLine()
            Else
                AddCharToLine()
            End If
        End While
        Me.WriteCurrentLine()
        Return _writer.ToString()
    End Function

    Private Function MoveNextChar() As Boolean
        Dim success As Boolean = _walker.MoveNext()
        If Me.IsApostrophe() Then
            Me._quoted = Not _quoted
        End If
        Return success
    End Function

    Public Function IsApostrophe() As Boolean
        Return Me._walker.CurrentChar = """"c AndAlso Me._walker.IsEscaped = False
    End Function

    Public Function IsOpenBracket() As Boolean
        Return Me._walker.CurrentChar = "{"c OrElse Me._walker.CurrentChar = "["c
    End Function

    Public Function IsCloseBracket() As Boolean
        Return Me._walker.CurrentChar = "}"c OrElse Me._walker.CurrentChar = "]"c
    End Function

    Public Function IsColon() As Boolean
        Return Me._walker.CurrentChar = ","c
    End Function

    Private Sub AddCharToLine()
        Me._currentLine.Append(_walker.CurrentChar)
    End Sub

    Private Sub WriteCurrentLine()
        Dim line As String = Me._currentLine.ToString().Trim()
        If line.Length > 0 Then
            _writer.WriteLine(line)
        End If
        Me.ResetLine()
    End Sub
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================