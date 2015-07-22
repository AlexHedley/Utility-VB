Imports System.Text

Public Class IndentWriter
    Private ReadOnly _result As New StringBuilder()
    Private _indentLevel As Integer

    Public Sub Indent()
        _indentLevel += 1
    End Sub

    Public Sub UnIndent()
        If _indentLevel > 0 Then
            _indentLevel -= 1
        End If
    End Sub

    Public Sub WriteLine(line As String)
        _result.AppendLine(CreateIndent() & line)
    End Sub

    Private Function CreateIndent() As String
        Dim indent As New StringBuilder()
        For i As Integer = 0 To _indentLevel - 1
            indent.Append("    ")
        Next
        Return indent.ToString()
    End Function

    Public Overrides Function ToString() As String
        Return _result.ToString()
    End Function
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
