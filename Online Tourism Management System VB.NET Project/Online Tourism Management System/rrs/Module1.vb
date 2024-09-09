
Imports System.Data.OleDb
Imports System.Data


Module Module1
    ' for current user in login
    Public currentuser As String
    Public coldt, dt1 As DataTable

    'for current bookingid in Cust_itenary 
    Public bookid As String 'booking id
    Public edit_item As String 'editing item (hotel,vehicle,activity,flight)

    Public Enum EnuRecstatus

        ' To find out the record status  i.e edit mode,  newmode
        ' To be declared in each form  in    Dim recmode As EnuRecstatus  
        'output = recnew, recedit

        Recnew = 1
        Recedit = 2


    End Enum



    'Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Travelz.mdb;")

    'Public Sub frmload(ByRef x As Form1)
    '    'MsgBox("disable buttons")
    '    'x.ToolBar1.Buttons(1).Enabled = False
    '    't.ToolBar1.Buttons(1).Enabled = False
    '    't.ToolBar1.Buttons(2).Enabled = False
    '    't.ToolBar1.Buttons(3).Enabled = False
    '    't.ToolBar1.Buttons(4).Enabled = False
    '    't.ToolBar1.Buttons(5).Enabled = False
    '    ' t.ToolBar1.Buttons(6).Enabled = False
    'End Sub

    'Public Sub tbnew()
    '    'MsgBox("module")
    '    t.ToolBar1.Buttons(1).Enabled = True
    '    t.ToolBar1.Buttons(3).Enabled = True
    '    t.ToolBar1.Buttons(4).Enabled = True
    'End Sub
    Public Sub ClearForm(ByVal frm As Form)
        Dim ctrl As Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    'allows numbers and backspace to key-in in a particular control
    '(should be called in keypress event) 
    Public Sub numberonly(ByVal e As Object)
        Select Case Asc(e.keychar)
            Case 48 To 57, 8       '48 to 57-numbers from 0 to 9,
                e.Handled = False  '8-backspace
            Case Else
                e.Handled = True
        End Select
    End Sub
    'allows text,numbers,space and backspace to key-in in a particular control
    '(should be called in keypress event)
    Public Sub textandnumbers(ByVal e As Object)
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 96 To 122, 48 To 57, 8, 32 '65 to 90-alphabets from a to z,
                e.Handled = False                     '96 to 122-alphabets from A to Z,
            Case Else                                 '48 to 57-numbers from 0 to 9,
                e.Handled = True                      '8-backspace,
        End Select                                    '32-space
    End Sub
    'allows only text,space and backspace to key-in in a particular control
    '(should be called in keypress event)
    Public Sub textonly(ByVal e As Object)
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 96 To 122, 8, 32 '65 to 90-alphabets from a to z,
                e.Handled = False           '96 to 122-alphabets from A to Z,
            Case Else                       '8-backspace,
                e.Handled = True            '32-space
        End Select
    End Sub
    'doesn't allow anything to key-in  in comboboxs(except up,down arrow and tab keys)
    '(should be called in keypress event)
    Public Sub combo(ByVal e As Object)
        Select Case Asc(e.KeyChar)
            Case 9, 38, 40        '9-tab,
                e.Handled = False '38,40-up and down arrows
            Case Else
                e.Handled = True
        End Select
    End Sub
    'allows only text to key-in in id's present in a form
    '(should be called in keypress event)
    Public Sub idtextonly(ByVal e As Object)
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 96 To 122, 8 '65 to 90-alphabets from a to z,
                e.Handled = False       '96 to 122-alphabets from A to Z,
            Case Else                   '8-backspace
                e.Handled = True
        End Select
    End Sub
    'allows text and numbers to key-in in id's present in a form
    '(should be called in keypress event)
    Public Sub idtextandnumbers(ByVal e As Object)
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 96 To 122, 48 To 57, 8 '65 to 90-alphabets from a to z,
                e.Handled = False                 '96 to 122-alphabets from A to Z,
            Case Else                             '48 to 57-numbers from 0 to 9,
                e.Handled = True                  '8-backspace
        End Select
    End Sub
    'minimum of 2 characters must be entered
    '(should be called in textbox leave) 
    Public Sub minchars(ByVal txt As TextBox, ByVal i As Integer)
        Dim len As Integer
        Dim str As String
        str = txt.Text
        len = str.Length
        If len = 0 Then
            Exit Sub
        End If
        If len < i Then
            MsgBox("Minimum " & i & " characters Must Be Entered", MsgBoxStyle.OKOnly, Prjtitle)
            txt.Text = ""
            txt.Focus()
            Exit Sub
        End If
    End Sub
    ' this  changes first character to capital
    Public Sub firstcap(ByVal txt As TextBox)
        Dim len As Integer
        Dim str As String
        Dim temp As String
        str = txt.Text
        len = str.Length
        If len > 1 Then
            temp = Mid(str, 1, 1)
            temp = temp.ToUpper
            str = Mid(str, 2)
            txt.Text = temp + str
        End If
    End Sub

    '  this procedure is to check the validity of email id
    Public Sub email(ByVal tx1 As TextBox)
        If tx1.Text <> "" Then
            Dim str As String
            Dim tstr As String
            Dim tstr1 As String
            Dim inchar() As String = {"~", "!", "#", "$", "%", "^", "&", "*", "(", ")", "+", "`", ",", ":", "-", "=", "|", "\", "<", ">", "'"}
            str = Trim(tx1.Text)
            Dim ck As Integer
            Dim i As Integer
            Dim len As Integer
            len = str.Length
            ck = 0

            ' to check the that string length is greater than min len of a mail id
            If len < 5 Then
                GoTo aa
            End If

            'to check the in valid chars
            For i = 0 To UBound(inchar)
                If InStr(1, str, inchar(i)) > 0 Then
                    GoTo aa
                End If
            Next

            ' to check the that string  contains  "@" and it is atleast on the 2nd postion
            If InStr(2, str, "@") <= 0 Then
                GoTo aa
            End If

            ' to check the that string doesn't contain  ".."
            If InStr(1, str, "..") > 0 Then
                GoTo aa
            End If

            ' to check for atleast one "."
            If InStr(str, ".") <= 0 Then
                GoTo aa
            End If

            ' to check that there is only one @
            i = InStr(str, "@")
            tstr = Mid(str, i + 1)
            If (InStr(tstr, "@") > 0) Then
                GoTo aa
            End If

            'there is no spaces in the string 
            If InStr(str, " ") > 0 Then
                GoTo aa
            End If

            'there no . at first position
            i = InStr(str, ".")
            If i = 1 Then
                GoTo aa
            End If

            'there is atleast one "." after @
            If InStr(tstr, ".") <= 0 Then
                GoTo aa
            End If


            'there is atleast one char after "."
            i = InStr(tstr, ".")
            tstr1 = Mid(tstr, i + 1)
            len = tstr1.Length
            If len < 1 Then
                GoTo aa
            End If
            ck = 1


aa:

            If ck < 1 Then
                MsgBox("invaild mail id", MsgBoxStyle.OKOnly, Prjtitle)
                tx1.Focus()
            End If
        End If
    End Sub

    Public Sub combofill(ByVal selcombo As ComboBox, ByVal str As String)
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Try
            selcombo.Items.Clear()
            'Openconnection()
            Openconnection()
            cmd = New OleDbCommand(str, con)
            dr = cmd.ExecuteReader
            While dr.Read()
                selcombo.Items.Add(dr(0)) 'This is for the first Combobox i.e Stuname 
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
            'con.Close()
            'cmd.Dispose()
        End Try
    End Sub

    Public Sub combofill1(ByVal selcombo As ComboBox, ByVal str As String)
        'if 2 fields r  required with - concatination.
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Try
            selcombo.Items.Clear()
            Openconnection()
            'Openconnection()
            cmd = New OleDbCommand(str, con)
            dr = cmd.ExecuteReader
            While dr.Read()
                selcombo.Items.Add(dr(0) & "-" & dr(1)) 'This is for the first Combobox i.e for two fields 
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'con.Close()
            'cmd.Dispose()
            CloseConnection()

        End Try
    End Sub

    Public Sub comboselet(ByVal selcombo As ComboBox, ByVal Str As String)
        ' to retrieve from the combo . based on ID
        'if it has  -
        Try
            If Str = "" Then Exit Sub
            Dim i As Integer
            Dim int1 As Integer
            Dim str_co As String
            Dim Check
            For i = 0 To selcombo.Items.Count - 1
                selcombo.Items.IndexOf(i)
                str_co = selcombo.Items.Item(i)
                Check = Split(str_co, "-")
                If StrComp(UCase(Str), UCase(Check(0))) = 0 Then
                    selcombo.Text = str_co
                    Exit Sub
                End If
            Next i
            selcombo.Items.IndexOf(-1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'allows numbers with digits for rs/ emount entry  to key-in in a particular control
    Public Sub Numb_Digit_Only(ByVal GivenString As String, ByVal e As Object)
        Select Case Asc(e.keychar)
            Case 48 To 57, 8
                e.Handled = False
            Case 46
                If InStr(GivenString, ".") = 0 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case Else
                e.Handled = True
                Exit Sub
        End Select

        If InStr(GivenString, ".") <> 0 Then
            If Len(Mid$(GivenString, InStr(GivenString, ".") + 1)) = 2 Then
                If Asc(e.keychar) <> 8 Then
                    e.Handled = True
                Else
                    e.Handled = False

                End If
            Else
                e.Handled = False

            End If
        Else
            e.Handled = False

        End If

    End Sub
    'it used to fill data in dagrid in view page
    'for this function we pass three parameters
    'one is query string,datagrid,array of strings
    Public Sub colname(ByVal str1 As String, ByVal dg As DataGrid, ByVal name As Array)

        Dim da As New OleDbDataAdapter(str1, con) 'str1 is nothing but query string 
        Dim ds As New DataSet

        da.Fill(ds, "str")

        dt1 = ds.Tables("str")

        For i As Integer = 0 To UBound(name)
            dt1.Columns(i).ColumnName = name(i)
            'dt1.Columns(i).ColumnName.PadRight(3)
        Next

        dg.DataSource = dt1


    End Sub
    '
    'Use when u Want to set the Width of the Coloumns
    '

    Public Sub colwidth(ByVal str1 As String, ByVal dggrid As DataGrid, ByVal wid As Array)

        Try
            Dim da As New OleDbDataAdapter(str1, con)
            Dim ds As New DataSet
            Dim dgts As New DataGridTableStyle


            'dgts.MappingName = "str"
            dgts.MappingName = dt1.TableName
            dggrid.TableStyles.Clear() 'it clears the datagrid table styles
            dggrid.TableStyles.Add(dgts)

            Dim dgcs As DataGridColumnStyle

            For i As Integer = 0 To UBound(wid)
                dgcs = dgts.GridColumnStyles.Item(i)
                dgcs.Width = wid(i)
            Next


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Public Function getid(ByVal cobname As ComboBox)
        Dim a, b As String
        a = cobname.Text
        If a <> "" Then
            b = (a.Substring(0, a.IndexOf("-")))
            Return b
        End If
    End Function

End Module

