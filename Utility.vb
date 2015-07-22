Imports System.Media
Imports System.Drawing
Imports System.Globalization

Imports System.IO
Imports System.Net
Imports System.Net.WebUtility

Imports System.Xml
'Imports System.Xml.XmlWriter
'Imports System.Xml.XmlTextWriter

Imports Microsoft.VisualBasic

Public Class frmUtility

    Private Sub frmUtility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelpProvider1.HelpNamespace = Application.StartupPath & "\Utility.chm"

        'Set the Combo for SQL Builder
        'cboWrapper.ListIndex = 0
        cboWrapper.SelectedIndex = 0
    End Sub

    ' ---------------------
    ' Tool Strip Menu Item
    ' ---------------------
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'MessageBox.Show("© Alex Hedley 2015", "About")
        AboutBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Me.Close()
        Application.Exit()
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Help.ShowHelp(Me, Application.StartupPath & "\Utility.chm")
        'Help.ShowHelpIndex(Me, Application.StartupPath & "\Utility.chm")
    End Sub

    ' -----------
    ' HEX to RGB
    ' -----------

    Private Sub cmdSplit_Click(sender As Object, e As EventArgs) Handles cmdSplit.Click
        Dim HexColor As String
        HexColor = txtHexColour.Text
        HexColor = Replace(HexColor, "#", "")

        Dim Red As Integer
        Dim Green As Integer
        Dim Blue As Integer
        Red = Val("&H" & Mid(HexColor, 1, 2))
        Green = Val("&H" & Mid(HexColor, 3, 2))
        Blue = Val("&H" & Mid(HexColor, 5, 2))

        txtRed.Text = Red
        txtGreen.Text = Green
        txtBlue.Text = Blue

        Dim RedDec As Decimal
        Dim GreenDec As Decimal
        Dim BlueDec As Decimal
        RedDec = Red / 255
        GreenDec = Green / 255
        BlueDec = Blue / 255

        txtRedDec.Text = RedDec
        txtGreenDec.Text = GreenDec
        txtBlueDec.Text = BlueDec

        'txtHexColour.BackColor = Color.FromArgb(Red, Green, Blue)
        pnlColour.BackColor = Color.FromArgb(Red, Green, Blue)

        lbltssMainStatus.Text = "HEX Colour has been split"
    End Sub

    ' -------------------
    ' URL Encode/Decode
    ' -------------------

    'http://meyerweb.com/eric/tools/dencoder/

    Private Sub cmdURLEncode_Click(sender As Object, e As EventArgs) Handles cmdURLEncode.Click
        If Len(txtUrlEncode.Text) = 0 Then
            MsgBox("Please add a URL")
            txtUrlEncode.Focus()
            Exit Sub
        End If

        ' Encode it as url.
        Dim strEncoded As String
        strEncoded = WebUtility.UrlEncode(txtUrlEncode.Text)
        txtURLDecode.Text = strEncoded

        lbltssMainStatus.Text = "HTML Encoded"
    End Sub

    Private Sub cmdURLDecode_Click(sender As Object, e As EventArgs) Handles cmdURLDecode.Click
        If Len(txtURLDecode.Text) = 0 Then
            MsgBox("Please add a URL")
            txtURLDecode.Focus()
            Exit Sub
        End If

        Dim strDecoded As String
        strDecoded = WebUtility.UrlDecode(txtURLDecode.Text)
        txtUrlEncode.Text = strDecoded

        lbltssMainStatus.Text = "HTML Decoded"
    End Sub

    ' -------------------
    ' HTML Encode/Decode
    ' -------------------
    Private Sub cmdHTMLEncode_Click(sender As Object, e As EventArgs) Handles cmdHTMLEncode.Click
        Dim myEncodedString As String
        ' Encode the string.
        myEncodedString = HtmlEncode(txtOutput.Text)
        txtInput.Text = myEncodedString

        lbltssMainStatus.Text = "HTML Encoded"
    End Sub

    Private Sub cmdHTMLDecode_Click(sender As Object, e As EventArgs) Handles cmdHTMLDecode.Click
        lblCount.Text = Len(txtInput.Text)

        Dim myWriter As New StringWriter()
        ' Decode the encoded string.
        HtmlDecode(txtInput.Text, myWriter)
        txtOutput.Text = myWriter.ToString()
        wbOutput.DocumentText = myWriter.ToString()

        lbltssMainStatus.Text = "HTML Decoded"
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtOutput.Text = ""
        txtInput.Text = ""
        wbOutput.DocumentText = ""

        lbltssMainStatus.Text = "Cleared"
    End Sub

    'Ctrl+A
    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    'Ctrl+A
    Private Sub txtOutput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOutput.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    ' ------------
    ' SQL Builder
    ' ------------

    Private Sub cmdParse_Click(sender As Object, e As EventArgs) Handles cmdParse.Click
        Dim strParsedSQL As String
        strParsedSQL = ""

        'Clear the previous value
        txtSQLParsed.Text = ""
        Dim arr() As String
        arr = Split(txtSQLList.Text, vbNewLine)

        'Wrap the values
        Dim itm As Object
        For Each itm In arr
            If Not String.IsNullOrEmpty(itm) Then
                'If itm <> "" Or itm IsNot Nothing Then
                strParsedSQL = strParsedSQL + cboWrapper.SelectedItem.ToString + itm.ToString & cboWrapper.SelectedItem.ToString + ","
            End If
        Next itm

        Dim intSSLen As Integer
        intSSLen = Len(strParsedSQL)

        'Remove the last ","
        If (intSSLen) <> 0 Then
            strParsedSQL = Microsoft.VisualBasic.Left(strParsedSQL, intSSLen - 1)
            'Wrap in ()
            strParsedSQL = "IN (" + strParsedSQL + ")"
            txtSQLParsed.Text = strParsedSQL
            'Update the Status Bar
            lbltssMainStatus.Text = "Parsed"
        Else
            'Update the Status Bar
            lbltssMainStatus.Text = "No values to be parsed"
        End If

    End Sub

    Private Sub txtSQLList_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSQLList.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub txtSQLParsed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSQLParsed.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub cmdCopySQL_Click(sender As Object, e As EventArgs) Handles cmdCopySQL.Click
        My.Computer.Clipboard.SetText(txtSQLParsed.Text)
        lbltssMainStatus.Text = "Parsed SQL has been copied to the Clipboard"
    End Sub

    Private Sub cmdClearSQL_Click(sender As Object, e As EventArgs) Handles cmdClearSQL.Click
        txtSQLList.Text = ""
        'txtSQLList.Clear
        lbltssMainStatus.Text = "Cleared"
    End Sub

    ' -----
    ' Guid
    ' -----

    Private Sub cmdGuidZeroCopy_Click(sender As Object, e As EventArgs) Handles cmdGuidZeroCopy.Click
        My.Computer.Clipboard.SetText(txtGuidZero.Text)
        lbltssMainStatus.Text = "A zero Guid has been copied to the Clipboard"
    End Sub

    Private Sub txtGuidZero_Enter(sender As Object, e As EventArgs) Handles txtGuidZero.Enter
        BeginInvoke(DirectCast(Sub() sender.SelectAll(), Action))
    End Sub

    Private Sub cmdGuidNewCopy_Click(sender As Object, e As EventArgs) Handles cmdGuidNewCopy.Click
        My.Computer.Clipboard.SetText(txtGuidNew.Text)
        lbltssMainStatus.Text = "A new Guid has been copied to the Clipboard"
    End Sub

    Private Sub txtGuidNew_Enter(sender As Object, e As EventArgs) Handles txtGuidNew.Enter
        BeginInvoke(DirectCast(Sub() sender.SelectAll(), Action))
    End Sub

    Private Sub cmdGuidGenerate_Click(sender As Object, e As EventArgs) Handles cmdGuidGenerate.Click
        Dim g As Guid
        ' Create and display the value of two GUIDs.
        g = Guid.NewGuid()
        txtGuidNew.Text = g.ToString
    End Sub

    ' -----------------
    ' XML Pretty Print
    ' -----------------

    Private Sub cmdXMLPrettyPrint_Click(sender As Object, e As EventArgs) Handles cmdXMLPrettyPrint.Click
        txtXML.Text = PrettyXML(txtXML.Text)
        lbltssMainStatus.Text = "XML has been prettied"
    End Sub

    Private Sub txtXML_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtXML.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub cmdCopyXML_Click(sender As Object, e As EventArgs) Handles cmdCopyXML.Click
        My.Computer.Clipboard.SetText(txtXML.Text)
        lbltssMainStatus.Text = "Parsed XML has been copied to the Clipboard"
    End Sub

    'http://thechriskent.com/2012/05/01/prettify-your-xml-in-net/
    Private Function PrettyXML(XMLString As String) As String
        Dim sw As New StringWriter()
        Dim xw As New XmlTextWriter(sw)
        xw.Formatting = Formatting.Indented
        xw.Indentation = 4
        Dim doc As New XmlDocument
        doc.LoadXml(XMLString)
        doc.Save(xw)
        Return sw.ToString()
    End Function

    ' ------------------
    ' JSON Pretty Print
    ' ------------------

    ' http://www.limilabs.com/blog/json-net-formatter
    ' Converted by http://converter.telerik.com/

    Private Sub cmdJSONPrettyPrint_Click(sender As Object, e As EventArgs) Handles cmdJSONPrettyPrint.Click
        'Console.WriteLine(new JsonFormatter(@"{""parameter"" : ""value"" , { ""parameter2"" : ""value2"" },{ ""parameter3"" : ""value3"" } }").Format());
        txtJSON.Text = New JsonFormatter(txtJSON.Text).Format()
        lbltssMainStatus.Text = "JSON has been prettied"
    End Sub

    Private Sub txtJSON_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJSON.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub cmdCopyJSON_Click(sender As Object, e As EventArgs) Handles cmdCopyJSON.Click
        My.Computer.Clipboard.SetText(txtJSON.Text)
        lbltssMainStatus.Text = "Parsed JSON has been copied to the Clipboard"
    End Sub
End Class
