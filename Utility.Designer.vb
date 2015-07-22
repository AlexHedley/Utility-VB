<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtility
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtility))
        Me.txtHexColour = New System.Windows.Forms.TextBox()
        Me.lblHex = New System.Windows.Forms.Label()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.cmdSplit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRedDec = New System.Windows.Forms.TextBox()
        Me.txtGreenDec = New System.Windows.Forms.TextBox()
        Me.txtBlueDec = New System.Windows.Forms.TextBox()
        Me.txtUrlEncode = New System.Windows.Forms.TextBox()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.cmdURLEncode = New System.Windows.Forms.Button()
        Me.cmdURLDecode = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpHTMLDecodeEncode = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.wbOutput = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmdHTMLEncode = New System.Windows.Forms.Button()
        Me.cmdHTMLDecode = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.tpURLEncode = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtURLDecode = New System.Windows.Forms.TextBox()
        Me.tpHEXtoRGB = New System.Windows.Forms.TabPage()
        Me.pnlColour = New System.Windows.Forms.Panel()
        Me.tpSQLBuilder = New System.Windows.Forms.TabPage()
        Me.cmdClearSQL = New System.Windows.Forms.Button()
        Me.cmdCopySQL = New System.Windows.Forms.Button()
        Me.cmdParse = New System.Windows.Forms.Button()
        Me.txtSQLParsed = New System.Windows.Forms.TextBox()
        Me.cboWrapper = New System.Windows.Forms.ComboBox()
        Me.lblWrapper = New System.Windows.Forms.Label()
        Me.txtSQLList = New System.Windows.Forms.TextBox()
        Me.tpGuid = New System.Windows.Forms.TabPage()
        Me.cmdGuidNewCopy = New System.Windows.Forms.Button()
        Me.lblGuidNew = New System.Windows.Forms.Label()
        Me.txtGuidNew = New System.Windows.Forms.TextBox()
        Me.cmdGuidGenerate = New System.Windows.Forms.Button()
        Me.cmdGuidZeroCopy = New System.Windows.Forms.Button()
        Me.lblZeros = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGuidZero = New System.Windows.Forms.TextBox()
        Me.tpXMLPrettyPrint = New System.Windows.Forms.TabPage()
        Me.cmdXMLPrettyPrint = New System.Windows.Forms.Button()
        Me.txtXML = New System.Windows.Forms.TextBox()
        Me.tpJSONPrettyPrint = New System.Windows.Forms.TabPage()
        Me.cmdJSONPrettyPrint = New System.Windows.Forms.Button()
        Me.txtJSON = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbltssMainStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdCopyXML = New System.Windows.Forms.Button()
        Me.cmdCopyJSON = New System.Windows.Forms.Button()
        Me.lblXML = New System.Windows.Forms.Label()
        Me.lblJSON = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpHTMLDecodeEncode.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tpURLEncode.SuspendLayout()
        Me.tpHEXtoRGB.SuspendLayout()
        Me.tpSQLBuilder.SuspendLayout()
        Me.tpGuid.SuspendLayout()
        Me.tpXMLPrettyPrint.SuspendLayout()
        Me.tpJSONPrettyPrint.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHexColour
        '
        Me.txtHexColour.Location = New System.Drawing.Point(52, 6)
        Me.txtHexColour.Name = "txtHexColour"
        Me.txtHexColour.Size = New System.Drawing.Size(64, 20)
        Me.txtHexColour.TabIndex = 0
        Me.txtHexColour.Text = "26264C"
        '
        'lblHex
        '
        Me.lblHex.AutoSize = True
        Me.lblHex.Location = New System.Drawing.Point(9, 9)
        Me.lblHex.Name = "lblHex"
        Me.lblHex.Size = New System.Drawing.Size(26, 13)
        Me.lblHex.TabIndex = 2
        Me.lblHex.Text = "Hex"
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(52, 61)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(41, 20)
        Me.txtRed.TabIndex = 5
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(9, 64)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(27, 13)
        Me.lblRed.TabIndex = 6
        Me.lblRed.Text = "Red"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlue.Location = New System.Drawing.Point(9, 116)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(28, 13)
        Me.lblBlue.TabIndex = 8
        Me.lblBlue.Text = "Blue"
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(52, 113)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(41, 20)
        Me.txtBlue.TabIndex = 7
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGreen.Location = New System.Drawing.Point(9, 90)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(36, 13)
        Me.lblGreen.TabIndex = 10
        Me.lblGreen.Text = "Green"
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(52, 87)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(41, 20)
        Me.txtGreen.TabIndex = 9
        '
        'cmdSplit
        '
        Me.cmdSplit.Location = New System.Drawing.Point(52, 32)
        Me.cmdSplit.Name = "cmdSplit"
        Me.cmdSplit.Size = New System.Drawing.Size(50, 23)
        Me.cmdSplit.TabIndex = 11
        Me.cmdSplit.Text = "Split"
        Me.cmdSplit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "/255"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "/255"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "/255"
        '
        'txtRedDec
        '
        Me.txtRedDec.Location = New System.Drawing.Point(135, 61)
        Me.txtRedDec.Name = "txtRedDec"
        Me.txtRedDec.Size = New System.Drawing.Size(122, 20)
        Me.txtRedDec.TabIndex = 15
        '
        'txtGreenDec
        '
        Me.txtGreenDec.Location = New System.Drawing.Point(135, 87)
        Me.txtGreenDec.Name = "txtGreenDec"
        Me.txtGreenDec.Size = New System.Drawing.Size(122, 20)
        Me.txtGreenDec.TabIndex = 16
        '
        'txtBlueDec
        '
        Me.txtBlueDec.Location = New System.Drawing.Point(135, 113)
        Me.txtBlueDec.Name = "txtBlueDec"
        Me.txtBlueDec.Size = New System.Drawing.Size(122, 20)
        Me.txtBlueDec.TabIndex = 17
        '
        'txtUrlEncode
        '
        Me.txtUrlEncode.Location = New System.Drawing.Point(44, 6)
        Me.txtUrlEncode.Name = "txtUrlEncode"
        Me.txtUrlEncode.Size = New System.Drawing.Size(742, 20)
        Me.txtUrlEncode.TabIndex = 18
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(9, 9)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(29, 13)
        Me.lblURL.TabIndex = 19
        Me.lblURL.Text = "URL"
        '
        'cmdURLEncode
        '
        Me.cmdURLEncode.Location = New System.Drawing.Point(726, 32)
        Me.cmdURLEncode.Name = "cmdURLEncode"
        Me.cmdURLEncode.Size = New System.Drawing.Size(60, 23)
        Me.cmdURLEncode.TabIndex = 20
        Me.cmdURLEncode.Text = "Encode"
        Me.cmdURLEncode.UseVisualStyleBackColor = True
        '
        'cmdURLDecode
        '
        Me.cmdURLDecode.Location = New System.Drawing.Point(726, 88)
        Me.cmdURLDecode.Name = "cmdURLDecode"
        Me.cmdURLDecode.Size = New System.Drawing.Size(60, 23)
        Me.cmdURLDecode.TabIndex = 22
        Me.cmdURLDecode.Text = "Decode"
        Me.cmdURLDecode.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpHTMLDecodeEncode)
        Me.TabControl1.Controls.Add(Me.tpURLEncode)
        Me.TabControl1.Controls.Add(Me.tpHEXtoRGB)
        Me.TabControl1.Controls.Add(Me.tpSQLBuilder)
        Me.TabControl1.Controls.Add(Me.tpGuid)
        Me.TabControl1.Controls.Add(Me.tpXMLPrettyPrint)
        Me.TabControl1.Controls.Add(Me.tpJSONPrettyPrint)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 600)
        Me.TabControl1.TabIndex = 23
        '
        'tpHTMLDecodeEncode
        '
        Me.tpHTMLDecodeEncode.Controls.Add(Me.GroupBox1)
        Me.tpHTMLDecodeEncode.Controls.Add(Me.Panel1)
        Me.tpHTMLDecodeEncode.Controls.Add(Me.txtOutput)
        Me.tpHTMLDecodeEncode.Controls.Add(Me.txtInput)
        Me.tpHTMLDecodeEncode.Location = New System.Drawing.Point(4, 22)
        Me.tpHTMLDecodeEncode.Name = "tpHTMLDecodeEncode"
        Me.tpHTMLDecodeEncode.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHTMLDecodeEncode.Size = New System.Drawing.Size(792, 574)
        Me.tpHTMLDecodeEncode.TabIndex = 3
        Me.tpHTMLDecodeEncode.Text = "HTML Decode/Encode"
        Me.tpHTMLDecodeEncode.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.wbOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 216)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HTML"
        '
        'wbOutput
        '
        Me.wbOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbOutput.Location = New System.Drawing.Point(6, 19)
        Me.wbOutput.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOutput.Name = "wbOutput"
        Me.wbOutput.Size = New System.Drawing.Size(768, 191)
        Me.wbOutput.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cmdClear)
        Me.Panel1.Controls.Add(Me.lblCount)
        Me.Panel1.Controls.Add(Me.cmdHTMLEncode)
        Me.Panel1.Controls.Add(Me.cmdHTMLDecode)
        Me.Panel1.Location = New System.Drawing.Point(3, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 28)
        Me.Panel1.TabIndex = 13
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClear.Location = New System.Drawing.Point(3, 4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(51, 20)
        Me.cmdClear.TabIndex = 8
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCount.Location = New System.Drawing.Point(664, 8)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(35, 13)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "Count"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdHTMLEncode
        '
        Me.cmdHTMLEncode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdHTMLEncode.Location = New System.Drawing.Point(583, 5)
        Me.cmdHTMLEncode.Name = "cmdHTMLEncode"
        Me.cmdHTMLEncode.Size = New System.Drawing.Size(75, 20)
        Me.cmdHTMLEncode.TabIndex = 5
        Me.cmdHTMLEncode.Text = "Encode"
        Me.cmdHTMLEncode.UseVisualStyleBackColor = True
        '
        'cmdHTMLDecode
        '
        Me.cmdHTMLDecode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHTMLDecode.Location = New System.Drawing.Point(705, 3)
        Me.cmdHTMLDecode.Name = "cmdHTMLDecode"
        Me.cmdHTMLDecode.Size = New System.Drawing.Size(75, 22)
        Me.cmdHTMLDecode.TabIndex = 6
        Me.cmdHTMLDecode.Text = "Decode"
        Me.cmdHTMLDecode.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(3, 196)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(783, 150)
        Me.txtOutput.TabIndex = 11
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(6, 6)
        Me.txtInput.MaxLength = 0
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(780, 150)
        Me.txtInput.TabIndex = 10
        '
        'tpURLEncode
        '
        Me.tpURLEncode.Controls.Add(Me.Label1)
        Me.tpURLEncode.Controls.Add(Me.txtURLDecode)
        Me.tpURLEncode.Controls.Add(Me.txtUrlEncode)
        Me.tpURLEncode.Controls.Add(Me.cmdURLDecode)
        Me.tpURLEncode.Controls.Add(Me.lblURL)
        Me.tpURLEncode.Controls.Add(Me.cmdURLEncode)
        Me.tpURLEncode.Location = New System.Drawing.Point(4, 22)
        Me.tpURLEncode.Name = "tpURLEncode"
        Me.tpURLEncode.Padding = New System.Windows.Forms.Padding(3)
        Me.tpURLEncode.Size = New System.Drawing.Size(792, 574)
        Me.tpURLEncode.TabIndex = 2
        Me.tpURLEncode.Text = "URL Encode"
        Me.tpURLEncode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "URL"
        '
        'txtURLDecode
        '
        Me.txtURLDecode.Location = New System.Drawing.Point(44, 62)
        Me.txtURLDecode.Name = "txtURLDecode"
        Me.txtURLDecode.Size = New System.Drawing.Size(742, 20)
        Me.txtURLDecode.TabIndex = 21
        '
        'tpHEXtoRGB
        '
        Me.tpHEXtoRGB.Controls.Add(Me.pnlColour)
        Me.tpHEXtoRGB.Controls.Add(Me.txtHexColour)
        Me.tpHEXtoRGB.Controls.Add(Me.lblHex)
        Me.tpHEXtoRGB.Controls.Add(Me.txtBlueDec)
        Me.tpHEXtoRGB.Controls.Add(Me.txtRed)
        Me.tpHEXtoRGB.Controls.Add(Me.txtGreenDec)
        Me.tpHEXtoRGB.Controls.Add(Me.lblRed)
        Me.tpHEXtoRGB.Controls.Add(Me.txtRedDec)
        Me.tpHEXtoRGB.Controls.Add(Me.txtBlue)
        Me.tpHEXtoRGB.Controls.Add(Me.Label4)
        Me.tpHEXtoRGB.Controls.Add(Me.lblBlue)
        Me.tpHEXtoRGB.Controls.Add(Me.Label3)
        Me.tpHEXtoRGB.Controls.Add(Me.txtGreen)
        Me.tpHEXtoRGB.Controls.Add(Me.Label2)
        Me.tpHEXtoRGB.Controls.Add(Me.lblGreen)
        Me.tpHEXtoRGB.Controls.Add(Me.cmdSplit)
        Me.tpHEXtoRGB.Location = New System.Drawing.Point(4, 22)
        Me.tpHEXtoRGB.Name = "tpHEXtoRGB"
        Me.tpHEXtoRGB.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHEXtoRGB.Size = New System.Drawing.Size(792, 574)
        Me.tpHEXtoRGB.TabIndex = 1
        Me.tpHEXtoRGB.Text = "HEX to RGB"
        Me.tpHEXtoRGB.UseVisualStyleBackColor = True
        '
        'pnlColour
        '
        Me.pnlColour.Location = New System.Drawing.Point(122, 6)
        Me.pnlColour.Name = "pnlColour"
        Me.pnlColour.Size = New System.Drawing.Size(19, 20)
        Me.pnlColour.TabIndex = 19
        '
        'tpSQLBuilder
        '
        Me.tpSQLBuilder.Controls.Add(Me.cmdClearSQL)
        Me.tpSQLBuilder.Controls.Add(Me.cmdCopySQL)
        Me.tpSQLBuilder.Controls.Add(Me.cmdParse)
        Me.tpSQLBuilder.Controls.Add(Me.txtSQLParsed)
        Me.tpSQLBuilder.Controls.Add(Me.cboWrapper)
        Me.tpSQLBuilder.Controls.Add(Me.lblWrapper)
        Me.tpSQLBuilder.Controls.Add(Me.txtSQLList)
        Me.tpSQLBuilder.Location = New System.Drawing.Point(4, 22)
        Me.tpSQLBuilder.Name = "tpSQLBuilder"
        Me.tpSQLBuilder.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSQLBuilder.Size = New System.Drawing.Size(792, 574)
        Me.tpSQLBuilder.TabIndex = 4
        Me.tpSQLBuilder.Text = "SQL Builder"
        Me.tpSQLBuilder.UseVisualStyleBackColor = True
        '
        'cmdClearSQL
        '
        Me.cmdClearSQL.Location = New System.Drawing.Point(736, 162)
        Me.cmdClearSQL.Name = "cmdClearSQL"
        Me.cmdClearSQL.Size = New System.Drawing.Size(50, 23)
        Me.cmdClearSQL.TabIndex = 17
        Me.cmdClearSQL.Text = "Clear"
        Me.cmdClearSQL.UseVisualStyleBackColor = True
        '
        'cmdCopySQL
        '
        Me.cmdCopySQL.Location = New System.Drawing.Point(736, 363)
        Me.cmdCopySQL.Name = "cmdCopySQL"
        Me.cmdCopySQL.Size = New System.Drawing.Size(50, 23)
        Me.cmdCopySQL.TabIndex = 16
        Me.cmdCopySQL.Text = "&Copy"
        Me.cmdCopySQL.UseVisualStyleBackColor = True
        '
        'cmdParse
        '
        Me.cmdParse.Location = New System.Drawing.Point(134, 180)
        Me.cmdParse.Name = "cmdParse"
        Me.cmdParse.Size = New System.Drawing.Size(75, 23)
        Me.cmdParse.TabIndex = 15
        Me.cmdParse.Text = "Parse"
        Me.cmdParse.UseVisualStyleBackColor = True
        '
        'txtSQLParsed
        '
        Me.txtSQLParsed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQLParsed.Location = New System.Drawing.Point(6, 207)
        Me.txtSQLParsed.MaxLength = 0
        Me.txtSQLParsed.Multiline = True
        Me.txtSQLParsed.Name = "txtSQLParsed"
        Me.txtSQLParsed.Size = New System.Drawing.Size(780, 150)
        Me.txtSQLParsed.TabIndex = 14
        '
        'cboWrapper
        '
        Me.cboWrapper.FormattingEnabled = True
        Me.cboWrapper.Items.AddRange(New Object() {"", "'"})
        Me.cboWrapper.Location = New System.Drawing.Point(6, 180)
        Me.cboWrapper.Name = "cboWrapper"
        Me.cboWrapper.Size = New System.Drawing.Size(121, 21)
        Me.cboWrapper.TabIndex = 13
        '
        'lblWrapper
        '
        Me.lblWrapper.AutoSize = True
        Me.lblWrapper.Location = New System.Drawing.Point(7, 163)
        Me.lblWrapper.Name = "lblWrapper"
        Me.lblWrapper.Size = New System.Drawing.Size(48, 13)
        Me.lblWrapper.TabIndex = 12
        Me.lblWrapper.Text = "Wrapper"
        '
        'txtSQLList
        '
        Me.txtSQLList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQLList.Location = New System.Drawing.Point(6, 6)
        Me.txtSQLList.MaxLength = 0
        Me.txtSQLList.Multiline = True
        Me.txtSQLList.Name = "txtSQLList"
        Me.txtSQLList.Size = New System.Drawing.Size(780, 150)
        Me.txtSQLList.TabIndex = 11
        '
        'tpGuid
        '
        Me.tpGuid.Controls.Add(Me.cmdGuidNewCopy)
        Me.tpGuid.Controls.Add(Me.lblGuidNew)
        Me.tpGuid.Controls.Add(Me.txtGuidNew)
        Me.tpGuid.Controls.Add(Me.cmdGuidGenerate)
        Me.tpGuid.Controls.Add(Me.cmdGuidZeroCopy)
        Me.tpGuid.Controls.Add(Me.lblZeros)
        Me.tpGuid.Controls.Add(Me.Label5)
        Me.tpGuid.Controls.Add(Me.txtGuidZero)
        Me.tpGuid.Location = New System.Drawing.Point(4, 22)
        Me.tpGuid.Name = "tpGuid"
        Me.tpGuid.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGuid.Size = New System.Drawing.Size(792, 574)
        Me.tpGuid.TabIndex = 5
        Me.tpGuid.Text = "Guid"
        Me.tpGuid.UseVisualStyleBackColor = True
        '
        'cmdGuidNewCopy
        '
        Me.cmdGuidNewCopy.Location = New System.Drawing.Point(286, 84)
        Me.cmdGuidNewCopy.Name = "cmdGuidNewCopy"
        Me.cmdGuidNewCopy.Size = New System.Drawing.Size(58, 23)
        Me.cmdGuidNewCopy.TabIndex = 7
        Me.cmdGuidNewCopy.Text = "Copy"
        Me.cmdGuidNewCopy.UseVisualStyleBackColor = True
        '
        'lblGuidNew
        '
        Me.lblGuidNew.AutoSize = True
        Me.lblGuidNew.Location = New System.Drawing.Point(12, 90)
        Me.lblGuidNew.Name = "lblGuidNew"
        Me.lblGuidNew.Size = New System.Drawing.Size(29, 13)
        Me.lblGuidNew.TabIndex = 6
        Me.lblGuidNew.Text = "New"
        '
        'txtGuidNew
        '
        Me.txtGuidNew.Location = New System.Drawing.Point(47, 87)
        Me.txtGuidNew.Name = "txtGuidNew"
        Me.txtGuidNew.ReadOnly = True
        Me.txtGuidNew.Size = New System.Drawing.Size(233, 20)
        Me.txtGuidNew.TabIndex = 5
        '
        'cmdGuidGenerate
        '
        Me.cmdGuidGenerate.Location = New System.Drawing.Point(47, 58)
        Me.cmdGuidGenerate.Name = "cmdGuidGenerate"
        Me.cmdGuidGenerate.Size = New System.Drawing.Size(69, 23)
        Me.cmdGuidGenerate.TabIndex = 4
        Me.cmdGuidGenerate.Text = "Generate"
        Me.cmdGuidGenerate.UseVisualStyleBackColor = True
        '
        'cmdGuidZeroCopy
        '
        Me.cmdGuidZeroCopy.Location = New System.Drawing.Point(286, 30)
        Me.cmdGuidZeroCopy.Name = "cmdGuidZeroCopy"
        Me.cmdGuidZeroCopy.Size = New System.Drawing.Size(58, 23)
        Me.cmdGuidZeroCopy.TabIndex = 3
        Me.cmdGuidZeroCopy.Text = "Copy"
        Me.cmdGuidZeroCopy.UseVisualStyleBackColor = True
        '
        'lblZeros
        '
        Me.lblZeros.AutoSize = True
        Me.lblZeros.Location = New System.Drawing.Point(7, 35)
        Me.lblZeros.Name = "lblZeros"
        Me.lblZeros.Size = New System.Drawing.Size(34, 13)
        Me.lblZeros.TabIndex = 2
        Me.lblZeros.Text = "Zeros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Guids"
        '
        'txtGuidZero
        '
        Me.txtGuidZero.Location = New System.Drawing.Point(47, 32)
        Me.txtGuidZero.Name = "txtGuidZero"
        Me.txtGuidZero.ReadOnly = True
        Me.txtGuidZero.Size = New System.Drawing.Size(233, 20)
        Me.txtGuidZero.TabIndex = 0
        Me.txtGuidZero.Text = "00000000-0000-0000-0000-000000000000"
        '
        'tpXMLPrettyPrint
        '
        Me.tpXMLPrettyPrint.Controls.Add(Me.lblXML)
        Me.tpXMLPrettyPrint.Controls.Add(Me.cmdCopyXML)
        Me.tpXMLPrettyPrint.Controls.Add(Me.cmdXMLPrettyPrint)
        Me.tpXMLPrettyPrint.Controls.Add(Me.txtXML)
        Me.tpXMLPrettyPrint.Location = New System.Drawing.Point(4, 22)
        Me.tpXMLPrettyPrint.Name = "tpXMLPrettyPrint"
        Me.tpXMLPrettyPrint.Padding = New System.Windows.Forms.Padding(3)
        Me.tpXMLPrettyPrint.Size = New System.Drawing.Size(792, 574)
        Me.tpXMLPrettyPrint.TabIndex = 6
        Me.tpXMLPrettyPrint.Text = "XML Pretty Print"
        Me.tpXMLPrettyPrint.UseVisualStyleBackColor = True
        '
        'cmdXMLPrettyPrint
        '
        Me.cmdXMLPrettyPrint.Location = New System.Drawing.Point(711, 6)
        Me.cmdXMLPrettyPrint.Name = "cmdXMLPrettyPrint"
        Me.cmdXMLPrettyPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdXMLPrettyPrint.TabIndex = 1
        Me.cmdXMLPrettyPrint.Text = "Pretty"
        Me.cmdXMLPrettyPrint.UseVisualStyleBackColor = True
        '
        'txtXML
        '
        Me.txtXML.Location = New System.Drawing.Point(7, 35)
        Me.txtXML.Multiline = True
        Me.txtXML.Name = "txtXML"
        Me.txtXML.Size = New System.Drawing.Size(779, 504)
        Me.txtXML.TabIndex = 0
        '
        'tpJSONPrettyPrint
        '
        Me.tpJSONPrettyPrint.Controls.Add(Me.lblJSON)
        Me.tpJSONPrettyPrint.Controls.Add(Me.cmdCopyJSON)
        Me.tpJSONPrettyPrint.Controls.Add(Me.cmdJSONPrettyPrint)
        Me.tpJSONPrettyPrint.Controls.Add(Me.txtJSON)
        Me.tpJSONPrettyPrint.Location = New System.Drawing.Point(4, 22)
        Me.tpJSONPrettyPrint.Name = "tpJSONPrettyPrint"
        Me.tpJSONPrettyPrint.Padding = New System.Windows.Forms.Padding(3)
        Me.tpJSONPrettyPrint.Size = New System.Drawing.Size(792, 574)
        Me.tpJSONPrettyPrint.TabIndex = 7
        Me.tpJSONPrettyPrint.Text = "JSON Pretty Print"
        Me.tpJSONPrettyPrint.UseVisualStyleBackColor = True
        '
        'cmdJSONPrettyPrint
        '
        Me.cmdJSONPrettyPrint.Location = New System.Drawing.Point(711, 6)
        Me.cmdJSONPrettyPrint.Name = "cmdJSONPrettyPrint"
        Me.cmdJSONPrettyPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdJSONPrettyPrint.TabIndex = 3
        Me.cmdJSONPrettyPrint.Text = "Pretty"
        Me.cmdJSONPrettyPrint.UseVisualStyleBackColor = True
        '
        'txtJSON
        '
        Me.txtJSON.Location = New System.Drawing.Point(7, 35)
        Me.txtJSON.Multiline = True
        Me.txtJSON.Name = "txtJSON"
        Me.txtJSON.Size = New System.Drawing.Size(779, 504)
        Me.txtJSON.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbltssMainStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(821, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbltssMainStatus
        '
        Me.lbltssMainStatus.Name = "lbltssMainStatus"
        Me.lbltssMainStatus.Size = New System.Drawing.Size(0, 17)
        '
        'cmdCopyXML
        '
        Me.cmdCopyXML.Location = New System.Drawing.Point(711, 545)
        Me.cmdCopyXML.Name = "cmdCopyXML"
        Me.cmdCopyXML.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopyXML.TabIndex = 2
        Me.cmdCopyXML.Text = "&Copy"
        Me.cmdCopyXML.UseVisualStyleBackColor = True
        '
        'cmdCopyJSON
        '
        Me.cmdCopyJSON.Location = New System.Drawing.Point(711, 545)
        Me.cmdCopyJSON.Name = "cmdCopyJSON"
        Me.cmdCopyJSON.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopyJSON.TabIndex = 4
        Me.cmdCopyJSON.Text = "&Copy"
        Me.cmdCopyJSON.UseVisualStyleBackColor = True
        '
        'lblXML
        '
        Me.lblXML.AutoSize = True
        Me.lblXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXML.Location = New System.Drawing.Point(6, 16)
        Me.lblXML.Name = "lblXML"
        Me.lblXML.Size = New System.Drawing.Size(29, 13)
        Me.lblXML.TabIndex = 3
        Me.lblXML.Text = "XML"
        '
        'lblJSON
        '
        Me.lblJSON.AutoSize = True
        Me.lblJSON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJSON.Location = New System.Drawing.Point(6, 16)
        Me.lblJSON.Name = "lblJSON"
        Me.lblJSON.Size = New System.Drawing.Size(35, 13)
        Me.lblJSON.TabIndex = 5
        Me.lblJSON.Text = "JSON"
        '
        'frmUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 662)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProvider1.SetHelpKeyword(Me, "index")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmUtility"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utility"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpHTMLDecodeEncode.ResumeLayout(False)
        Me.tpHTMLDecodeEncode.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.tpURLEncode.ResumeLayout(False)
        Me.tpURLEncode.PerformLayout()
        Me.tpHEXtoRGB.ResumeLayout(False)
        Me.tpHEXtoRGB.PerformLayout()
        Me.tpSQLBuilder.ResumeLayout(False)
        Me.tpSQLBuilder.PerformLayout()
        Me.tpGuid.ResumeLayout(False)
        Me.tpGuid.PerformLayout()
        Me.tpXMLPrettyPrint.ResumeLayout(False)
        Me.tpXMLPrettyPrint.PerformLayout()
        Me.tpJSONPrettyPrint.ResumeLayout(False)
        Me.tpJSONPrettyPrint.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHexColour As System.Windows.Forms.TextBox
    Friend WithEvents lblHex As System.Windows.Forms.Label
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents cmdSplit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRedDec As System.Windows.Forms.TextBox
    Friend WithEvents txtGreenDec As System.Windows.Forms.TextBox
    Friend WithEvents txtBlueDec As System.Windows.Forms.TextBox
    Friend WithEvents txtUrlEncode As System.Windows.Forms.TextBox
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents cmdURLEncode As System.Windows.Forms.Button
    Friend WithEvents cmdURLDecode As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpURLEncode As System.Windows.Forms.TabPage
    Friend WithEvents tpHEXtoRGB As System.Windows.Forms.TabPage
    Friend WithEvents tpHTMLDecodeEncode As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents cmdHTMLEncode As System.Windows.Forms.Button
    Friend WithEvents cmdHTMLDecode As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents wbOutput As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtURLDecode As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbltssMainStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlColour As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents tpSQLBuilder As System.Windows.Forms.TabPage
    Friend WithEvents cboWrapper As System.Windows.Forms.ComboBox
    Friend WithEvents lblWrapper As System.Windows.Forms.Label
    Friend WithEvents txtSQLList As System.Windows.Forms.TextBox
    Friend WithEvents cmdParse As System.Windows.Forms.Button
    Friend WithEvents txtSQLParsed As System.Windows.Forms.TextBox
    Friend WithEvents cmdCopySQL As System.Windows.Forms.Button
    Friend WithEvents cmdClearSQL As System.Windows.Forms.Button
    Friend WithEvents tpGuid As System.Windows.Forms.TabPage
    Friend WithEvents cmdGuidZeroCopy As System.Windows.Forms.Button
    Friend WithEvents lblZeros As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGuidZero As System.Windows.Forms.TextBox
    Friend WithEvents txtGuidNew As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuidGenerate As System.Windows.Forms.Button
    Friend WithEvents lblGuidNew As System.Windows.Forms.Label
    Friend WithEvents cmdGuidNewCopy As System.Windows.Forms.Button
    Friend WithEvents tpXMLPrettyPrint As System.Windows.Forms.TabPage
    Friend WithEvents cmdXMLPrettyPrint As System.Windows.Forms.Button
    Friend WithEvents txtXML As System.Windows.Forms.TextBox
    Friend WithEvents tpJSONPrettyPrint As System.Windows.Forms.TabPage
    Friend WithEvents cmdJSONPrettyPrint As System.Windows.Forms.Button
    Friend WithEvents txtJSON As System.Windows.Forms.TextBox
    Friend WithEvents cmdCopyXML As System.Windows.Forms.Button
    Friend WithEvents cmdCopyJSON As System.Windows.Forms.Button
    Friend WithEvents lblXML As System.Windows.Forms.Label
    Friend WithEvents lblJSON As System.Windows.Forms.Label

End Class
