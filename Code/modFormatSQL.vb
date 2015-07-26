Imports System.IO

' si_the_geek (http://www.vbforums.com/member.php?34875-si_the_geek)
' http://www.vbforums.com/showthread.php?369957-VB-SQL-Select-statement-formatter-checker&p=4134712#post4134712
' davidcarta (http://www.vbforums.com/member.php?60894-davidcarta)

Module modFormatSQL

  '
  '*  SQL "Select" statement formatter/checker
  '
  '*  Author:  Si_the_geek of VBForums.com
  '
  '
  '* Example usage:
  '
  'Dim sSQL as String
  '  sSQL = "SELECT field1 FROM table1"
  '  sSQL = FormatSelect(sSQL)
  '  MsgBox sSQL


  Public Function FormatSelect(ByVal sInput As String, _
                               Optional ByVal bShowSpacerLines As Boolean = True, _
                               Optional ByVal lIndentSize As Integer = 10, _
                               Optional ByVal lIndentSubquerySize As Integer = 13) _
                               As String
    'Format an SQL "select" statement for easier reading

    'Also lists a few obvious errors if found, eg:
    '  - Sections (eg: FROM, WHERE) in the wrong order;
    '  - Wrong number of quotes, ie: a string/date is not closed properly;
    '  - Wrong number of brackets, ie: more ( than ) , or vice versa.

    'Current known omissions:
    '  does not start a new line for CASE WHEN (or other DBMS specific code)

    Dim sError As String = ""

    FormatSelect = FormatSelect_Worker(sInput, _
                                       sError, _
                                       bShowSpacerLines, _
                                       lIndentSize, _
                                       lIndentSubquerySize)

    If sError <> "" Then
      MsgBox("The following problems were found:" & vbCrLf & vbCrLf & sError, vbExclamation)
    End If

  End Function


  '* the following are helper functions for FormatSelect *


  Private Function FormatSelect_Worker(ByVal sInput As String, _
                                       ByRef ret_sWarnings As String, _
                                       Optional ByVal bSpacerLines As Boolean = True, _
                                       Optional ByVal lIndentSize As Integer = 10, _
                                       Optional ByVal lIndentSubquerySize As Integer = 13) _
                                       As String
    '(helper function for FormatSelect)

    'Format an SQL "select" statement for easier reading (also lists a few obvious errors)


    'Create keyword list array
    'Dim aKeywords As Object
    'aKeywords = Array("SELECT", "FROM", "WHERE", "GROUP BY", "HAVING", "ORDER BY")

    Dim aKeywords() As String = {"SELECT", "FROM", "WHERE", "GROUP BY", "HAVING", "ORDER BY"}

    'Setup variables
    Dim sRetString As String        'Text to return
    Dim sWarning As String          'Warning messages
    Dim sTempWarning As String = ""      'Potential warning messages froom sub queries
    Dim sText As String             '"Clean" text to work with
    Dim sIndent As String           'Space to indent 'normal' text by
    Dim sIndentSub As String        'Space to indent subqueries by
    Dim sTemp As String = ""            'Temporary text
    Dim aStrings(,) As String        'Strings within the SQL (temporarily removed, in case keywords found)
    Dim bGotStrings As Boolean      'Have we got any strings?
    Dim aSubQueries() As String     'Sub-queries within the SQL (temp. removed to aid formatting & simplify code)
    Dim bGotSubqueries As Boolean   'Have we got any sub-queries?
    Dim lCurrPos As Integer            'The current position within sText
    Dim lTempPos As Integer            'Position of text we just searched for
    Dim lTempPos2 As Integer           'Position of text we just searched for
    Dim lThisSectionType As Integer    'The type of section (from aKeywords) we are working with
    Dim lLastSectionType As Integer    'The type of the previous section (to show warnings)
    Dim lThisSectionStart As Integer   'The start position of this section
    Dim lNextSectionStart As Integer   'The start position of the next section (so we stop before it)
    Dim lCount As Integer              'Loop counter
    Dim bInQuotes As Boolean        'Are we currently inside single quotes? (for removing strings)
    sWarning = ""
    sRetString = ""
    sText = sInput
    sIndent = Space(lIndentSize)
    sIndentSub = Space(lIndentSubquerySize)

    'move all strings to array (so we dont find keywords in them)
    lCount = (Len(sText) - Len(Replace(Replace(Replace(sText, "'", ""), """", ""), "#", "")))
    'ReDim aStrings(1, lCount \ 2 + 1) As String
    ReDim aStrings(1, 0 To lCount \ 2 + 1)

    lCount = 0
    lCurrPos = 0
    bInQuotes = False
    lTempPos = InStr(1, sText, "'")
    lTempPos2 = InStr(1, sText, """")
    If (lTempPos = 0) Or (lTempPos2 > 0 And lTempPos2 < lTempPos) Then lTempPos = lTempPos2
    lTempPos2 = InStr(1, sText, "#")
    If (lTempPos = 0) Or (lTempPos2 > 0 And lTempPos2 < lTempPos) Then lTempPos = lTempPos2
    Do While (lTempPos > 0)
      sTemp = Mid$(sText, lTempPos, 1)
      aStrings(0, lCount) = sTemp
      If bInQuotes And (sTemp <> "#") Then
        Do While Mid$(sText, lTempPos, 2) = New String(sTemp, 2) 'String(2, sTemp)
          lTempPos = InStr(lTempPos + 2, sText, sTemp)
          If lTempPos = 0 Then Exit Do
        Loop
      End If
      If lTempPos = 0 Then Exit Do
      If bInQuotes Then
        aStrings(1, lCount) = Mid$(sText, lCurrPos, lTempPos - lCurrPos)
        sText = Left$(sText, lCurrPos - 1) & Mid$(sText, lTempPos)
        lCount = lCount + 1
        lTempPos = InStr(lCurrPos + 2, sText, "'")
        lTempPos2 = InStr(lCurrPos + 2, sText, """")
        If (lTempPos = 0) Or (lTempPos2 > 0 And lTempPos2 < lTempPos) Then lTempPos = lTempPos2
        lTempPos2 = InStr(lCurrPos + 2, sText, "#")
        If (lTempPos = 0) Or (lTempPos2 > 0 And lTempPos2 < lTempPos) Then lTempPos = lTempPos2
      Else
        lCurrPos = lTempPos + 1
        lTempPos = InStr(lTempPos + 1, sText, sTemp)
      End If
      bInQuotes = Not (bInQuotes)
    Loop
    If bInQuotes Then
      sWarning = sWarning _
               & "Incorrect number of quote (" & sTemp & " characters), a string/date is not closed!" _
               & vbCrLf & vbCrLf
    End If
    If lCount = 0 Then
      Erase aStrings
    Else
      ' ReDim Preserve aStrings(1, lCount - 1) As String
      ReDim Preserve aStrings(1, 0 To lCount - 1)

      bGotStrings = True
    End If

    'tidy input text
    sText = Trim$(Replace(Replace(sText, vbCr, " "), vbLf, " "))
    sText = Replace(sText, vbTab, " ")
    sTemp = "=<>+-/*"
    For lCount = 1 To Len(sTemp)
      sText = Replace(sText, Mid$(sTemp, lCount, 1), " " & Mid$(sTemp, lCount, 1) & " ")
    Next lCount
    sText = Replace(sText, ",", ", ")
    sText = Replace(Replace(sText, "(", " ( "), ")", " ) ")
    Do While InStr(sText, "  ")
      sText = Replace(sText, "  ", " ")
    Loop
    sText = Trim$(Replace(sText, " ,", ","))

    'move all subqueries to array (better formatting, and so we dont split on the wrong keywords)
    ' ReDim aSubQueries((Len(sText) - Len(Replace(sText, "( SELECT ", "", compare:=vbTextCompare))) \ 8 + 1) As String
    ReDim aSubQueries((Len(sText) - Len(Replace(sText, "( SELECT ", "", Compare:=vbTextCompare))) \ 8 + 1)

    lCount = 0
    lCurrPos = InStr(1, sText, "( SELECT ", vbTextCompare)
    Do While (lCurrPos > 0)
      lTempPos = FindCloseBracket(sText, lCurrPos)
      sTemp = FormatSelect_Worker(Mid$(sText, lCurrPos + 1, lTempPos - lCurrPos - 1), _
                                  sTempWarning, _
                                  bSpacerLines, _
                                  lIndentSize, _
                                  lIndentSubquerySize)
      If sTempWarning <> "" Then
        sWarning = sWarning _
                 & "(in sub-query: " _
                 & vbCrLf _
                 & "  " & Replace(sTempWarning, vbCrLf, vbCrLf & "  ") _
                 & ")" _
                 & vbCrLf & vbCrLf
      End If
      sTemp = vbCrLf _
            & sIndentSub _
            & Replace(sTemp, vbCrLf, vbCrLf & sIndentSub)
      aSubQueries(lCount) = sTemp
      sText = Left$(sText, lCurrPos) _
            & vbCrLf _
            & sIndentSub _
            & Mid$(sText, lTempPos)
      lCount = lCount + 1
      lCurrPos = InStr(lCurrPos + 1, sText, "( SELECT ", vbTextCompare)
    Loop
    If lCount = 0 Then
      Erase aSubQueries
    Else
      ' ReDim Preserve aSubQueries(lCount - 1) As String
      ReDim Preserve aSubQueries(lCount - 1)

      bGotSubqueries = True
    End If

    'count brackets to ensure a match
    lCount = (Len(sText) - Len(Replace(sText, "(", "")))
    lCount = lCount - (Len(sText) - Len(Replace(sText, ")", "")))
    Select Case Math.Sign(lCount)
      Case 1
        sWarning = sWarning _
                 & "You have " & lCount & " more open brackets: ( than close brackets: )  This may make any subqueries be invalid!" _
                 & vbCrLf & vbCrLf
      Case -1
        sWarning = sWarning _
                 & "You have " & Math.Abs(lCount) & " more close brackets: ) than open brackets: (  This may make any subqueries be invalid!" _
                 & vbCrLf & vbCrLf
    End Select


    'work with text...
    lCurrPos = 1
    lThisSectionType = -1
    Do While lCurrPos < Len(sInput)
      'find current section type & position
      lLastSectionType = lThisSectionType
      lThisSectionStart = FindFirstByArray(sText, aKeywords, lCurrPos, lThisSectionType)
      'if any "incorrect" text, add it to a new line
      If lThisSectionStart > lCurrPos Then
        sRetString = sRetString _
                   & Mid$(sText, lCurrPos, lThisSectionStart - lCurrPos - 1) _
                   & vbCrLf
        sWarning = sWarning _
                 & "Unexpected text: " _
                 & Mid$(sText, lCurrPos, lThisSectionStart - lCurrPos - 1) _
                 & vbCrLf & vbCrLf
      End If
      'if reached end of text, exit!
      If lThisSectionStart >= Len(sText) Then Exit Do
      'if sections ordered wrong, add to warning
      If lLastSectionType > lThisSectionType Then
        sWarning = sWarning _
                 & "Incorrect section ordering: " _
                 & aKeywords(lThisSectionType) _
                 & " should be before " _
                 & aKeywords(lLastSectionType) _
                 & vbCrLf & vbCrLf
      End If

      If bSpacerLines Then
        'add blank lines between sections
        If (lCurrPos > 1) Then
          sRetString = sRetString _
                     & vbCrLf
        End If
      End If

      'add keyword (Ucase), and spaces to indent
      If Len(aKeywords(lThisSectionType)) >= lIndentSize Then
        sRetString = sRetString & aKeywords(lThisSectionType) & " "
      Else
        sRetString = sRetString & aKeywords(lThisSectionType) & Space(Len(sIndent) - Len(aKeywords(lThisSectionType)))
      End If
      lCurrPos = lCurrPos + Len(aKeywords(lThisSectionType)) + 1
      lThisSectionStart = lThisSectionStart + Len(aKeywords(lThisSectionType)) + 1
      'find end of current section
      lNextSectionStart = FindFirstByArray(sText, aKeywords, lCurrPos)

      'work on each section...
      Dim lBracketStart As Integer
      Dim lBracketEnd As Integer
      'Dim aTempArray As Object
      Dim aTempArray() As String
      Dim lTempIndex As Integer
      Dim lTempLen As Integer
      Dim lTempInc As Integer
      Select Case aKeywords(lThisSectionType)

        Case "SELECT", "GROUP BY", "ORDER BY"
          lTempPos = lCurrPos
          Do
            Do
              lBracketStart = InStr(lTempPos, sText, "(")
              lTempPos = InStr(lTempPos, sText, ",")
              If (lBracketStart > 0) And (lBracketStart < lTempPos) And (lBracketStart < lNextSectionStart) Then
                lBracketEnd = FindCloseBracket(sText, lBracketStart)
                If lBracketEnd < lNextSectionStart Then
                  lTempPos = lBracketEnd - 1
                Else
                  lBracketStart = 0
                End If
              Else
                lBracketStart = 0
              End If
            Loop While (lBracketStart > 0) And (lTempPos > 0)
            If (lTempPos = 0) Or (lTempPos >= lNextSectionStart) Then lTempPos = lNextSectionStart - 1
            If (lTempPos > lCurrPos) Then
              sRetString = sRetString _
                         & Trim$(Mid$(sText, lCurrPos, lTempPos - lCurrPos + 1)) _
                         & vbCrLf
              If (lTempPos < lNextSectionStart - 1) Then
                sRetString = sRetString _
                           & sIndent
              End If
            End If
            lCurrPos = lTempPos + 1
            lTempPos = lCurrPos
          Loop While (lTempPos < lNextSectionStart) And (lCurrPos < lNextSectionStart)

        Case "FROM"
          'aTempArray = Array("INNER JOIN", "LEFT OUTER JOIN", "RIGHT OUTER JOIN", _
          '                   "LEFT JOIN", "RIGHT JOIN", "OUTER JOIN", "OUTER", _
          '                   "CROSS JOIN", "JOIN")


          aTempArray = {"INNER JOIN", "LEFT OUTER JOIN", "RIGHT OUTER JOIN", _
                             "LEFT JOIN", "RIGHT JOIN", "OUTER JOIN", "OUTER", _
                             "CROSS JOIN", "JOIN"}
          Do
            lTempPos = FindFirstByArray(sText, aTempArray, lCurrPos, lTempIndex)
            If (lTempPos < Len(sText)) And (lTempPos < lNextSectionStart) Then
              lTempLen = Len(aTempArray(lTempIndex))
              sRetString = sRetString _
                         & Trim$(Mid$(sText, lCurrPos, lTempPos - lCurrPos - 1)) _
                         & vbCrLf _
                         & sIndent _
                         & aTempArray(lTempIndex) _
                         & " "
              lCurrPos = lTempPos + lTempLen
            End If
          Loop While (lTempPos < Len(sText)) And (lTempPos < lNextSectionStart)
          If (lCurrPos < lNextSectionStart) Then
            sRetString = sRetString _
                       & Trim$(Mid$(sText, lCurrPos, lNextSectionStart - lCurrPos)) _
                       & vbCrLf
          End If

        Case "WHERE", "HAVING"
          aTempArray = {"AND", "OR", "BETWEEN"}
          Do
            lTempInc = 0
            Do
              lTempPos = FindFirstByArray(sText, aTempArray, lCurrPos + lTempInc, lTempIndex)
              'need to skip the 'And' in a Between clause
              If (lTempIndex = 2) Then
                lTempInc = InStr(lTempPos, sText, "AND", vbTextCompare) + 1 - lCurrPos
                If lTempInc < 0 Then lTempInc = 7
              End If
            Loop While (lTempIndex = 2)
            If (lTempPos < Len(sText)) And (lTempPos < lNextSectionStart) Then
              lTempLen = Len(aTempArray(lTempIndex))
              sRetString = sRetString _
                         & Trim$(Mid$(sText, lCurrPos, lTempPos - lCurrPos)) _
                         & vbCrLf _
                         & sIndent _
                         & aTempArray(lTempIndex) _
                         & " "
              lCurrPos = lTempPos + lTempLen
            End If
          Loop While (lTempPos < Len(sText)) And (lTempPos < lNextSectionStart)
          If (lCurrPos < lNextSectionStart) Then
            sRetString = sRetString _
                       & Trim$(Mid$(sText, lCurrPos, lNextSectionStart - lCurrPos)) _
                       & vbCrLf
          End If

        Case Else     'a section not coded for - just paste the text!
          sRetString = sRetString _
                     & sIndent _
                     & Trim$(Mid$(sText, lCurrPos, lNextSectionStart - lCurrPos)) _
                     & vbCrLf
      End Select

      lCurrPos = lNextSectionStart
    Loop

    '(main statement finished)

    're-insert the sub-queries we removed at the start
    If bGotSubqueries Then
      If bSpacerLines Then
        For lCount = 0 To UBound(aSubQueries)
          sRetString = Replace(sRetString, _
                               "(" & vbCrLf & sIndentSub & ")", _
                               "(" & vbCrLf & aSubQueries(lCount) & vbCrLf & vbCrLf & sIndentSub & ")", _
                               1, _
                               1)
        Next lCount
      Else
        For lCount = 0 To UBound(aSubQueries)
          sRetString = Replace(sRetString, _
                               "(" & vbCrLf & sIndentSub & ")", _
                               "(" & aSubQueries(lCount) & vbCrLf & sIndentSub & ")", _
                               1, _
                               1)
        Next lCount
      End If
    End If

    're-insert the strings we removed at the start
    If bGotStrings Then
      For lCount = 0 To UBound(aStrings, 2)
        'sRetString = Replace(sRetString, _
        '                     String(2, aStrings(0, lCount)), _
        '                     aStrings(0, lCount) & aStrings(1, lCount) & aStrings(0, lCount), _
        '                     1, _
        '                     1)

        sRetString = Replace(sRetString, _
                             New String(aStrings(0, lCount), 2), _
                             aStrings(0, lCount) & aStrings(1, lCount) & aStrings(0, lCount), _
                             1, _
                             1)


      Next lCount
    End If

    'return any warning messages
    If sWarning <> "" Then
      ret_sWarnings = sWarning
    End If

    'return formatted text
    FormatSelect_Worker = Left$(sRetString, Len(sRetString) - Len(vbCrLf))

  End Function


  Private Function FindCloseBracket(sText As String, _
                                    Optional lStartPos As Integer = 1) _
                                    As Integer
    '(helper function for FormatSelect)

    'Returns the position of the closing bracket to match the opening bracket at the position 'lStartPos',
    '(or length of string+1 if not found)

    Dim lCurrPos As Integer
    Dim lOpenPos As Integer
    Dim lClosePos As Integer
    Dim lOpenCount As Integer

    lOpenCount = 1
    lCurrPos = lStartPos + 1
    FindCloseBracket = Len(sText) + 1

    lOpenPos = InStr(lCurrPos, sText, "(")
    lClosePos = InStr(lCurrPos, sText, ")")
    Do While (lOpenPos > 0) Or (lClosePos > 0)
      If (lOpenPos > 0 And lOpenPos < lClosePos) Or (lClosePos = 0) Then
        lOpenCount = lOpenCount + 1
        lCurrPos = lOpenPos + 1
        lOpenPos = InStr(lCurrPos, sText, "(")
      Else
        lOpenCount = lOpenCount - 1
        If lOpenCount = 0 Then
          FindCloseBracket = lClosePos
          Exit Do
        End If
        lCurrPos = lClosePos + 1
        lClosePos = InStr(lCurrPos, sText, ")")
      End If
    Loop

  End Function

  '                                  vArray() As string, _

  Private Function FindFirstByArray(sText As String, _
                                    vArray() As String, _
                                    Optional lStartPos As Integer = 1, _
                                    Optional ByRef retArrayIndex As Integer = -1) _
                                    As Integer
    '(helper function for FormatSelect)

    'Returns the position of first instance in the string of any array item (or length of string+1 if none found)
    'nb: must be after some kind of punctuation as listed below

    Const csPunctuation = " '""#()=<>[]+-/*"

    Dim lFirstPos As Integer
    Dim lArrayIndex As Integer
    Dim lTempPos As Integer
    Dim lCount As Integer
    Dim bOK As Boolean

    lFirstPos = Len(sText) + 1
    lArrayIndex = 0

    For lCount = 0 To UBound(vArray)
      lTempPos = InStr(lStartPos, sText, vArray(lCount), vbTextCompare)
      Do While (lTempPos >= lStartPos)
        bOK = False    'check prev char is punctuation/start
        If (lTempPos = lStartPos) Then
          bOK = True
        Else
          If InStr(csPunctuation, Mid$(sText, lTempPos - 1, 1)) Then
            bOK = True
          End If
        End If
        If bOK Then    'check next char is punctuation/end
          If lTempPos + Len(vArray(lCount)) > Len(sText) Then Exit Do
          If InStr(csPunctuation, Mid$(sText, lTempPos + Len(vArray(lCount)), 1)) Then Exit Do
        End If
        lTempPos = InStr(lTempPos + 1, sText, vArray(lCount), vbTextCompare)
      Loop
      If (lTempPos > 0) And (lTempPos < lFirstPos) Then
        lFirstPos = lTempPos
        lArrayIndex = lCount
      End If
    Next lCount

    retArrayIndex = IIf(lFirstPos = Len(sText), -1, lArrayIndex)
    FindFirstByArray = lFirstPos

  End Function
End Module
