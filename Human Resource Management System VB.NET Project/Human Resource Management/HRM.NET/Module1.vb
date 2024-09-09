
Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Module Module1
    Public connetionString As String
    Public connection As OleDbConnection
    Public oledbAdapter As New OleDbDataAdapter
    Public cmd As New OleDbCommand
    Public reader As OleDbDataReader

    Public sql As String
    Public Conn As New ADODB.Connection
    Public RS As New ADODB.Recordset
    Public TempRS As New ADODB.Recordset
    Public TempRS1 As New ADODB.Recordset
    Public RNo As Object
    Public RNoVar As Integer
    Public I, J As Object
    Public K As Integer
    Public CatVar, StrSql, MsgVar, ItemVar As Object
    Public TranMain As String
    Public BGColor, VTVar, UserNameVar As Object
    Public DatabasePath As String
    Public AppNo As Integer
    Public iappno As Integer
    Public iname As String
    Public iaddress As String
    Public imsg As String
    Public idate As String
    Public itime As String

    Enum CtrlType
        TextBox = 1
        ComboBox = 2
    End Enum
    Public Sub connectiondb()
        connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\HRMS.mdb;"
        connection = New OleDbConnection(connetionString)
        connection.Open()
    End Sub
    Public Sub ClearTxtControls(ByRef frm As Object, ByRef ControlType As CtrlType, Optional ByRef Tagstr As Object = Nothing)
        Dim Contrl As Object
        For Each Contrl In frm.Controls
            If Not (IsNothing(Tagstr)) Then
                If Trim(UCase(Contrl.Tag)) = Trim(UCase(Tagstr)) Then
                    Contrl.Text = ""
                    Exit For
                End If
            Else
                Select Case ControlType
                    Case CtrlType.ComboBox
                        If TypeOf Contrl Is System.Windows.Forms.ComboBox Then Contrl.Text = ""
                    Case CtrlType.TextBox
                        If TypeOf Contrl Is System.Windows.Forms.TextBox Then Contrl.Text = ""
                End Select
            End If
        Next Contrl
        Contrl = Nothing
    End Sub




    Public Function CheckChar(ByRef CharString As Object) As String
        Dim Con1, L1, sinchar As Object


        L1 = Len(CharString)

        CharString = UCase(Left(CharString, 1)) & Right(CharString, L1 - 1)

        For I = 1 To L1
            If Con1 = True Then CharString = Mid(CharString, 1, I - 1) & UCase(Mid(CharString, I, 1)) & Mid(CharString, I + 1, L1)

            If sinchar = " " Then

                Con1 = True
            Else

                Con1 = False
            End If
        Next I


        CheckChar = CharString
    End Function

    Function CheckNum(ByRef KeyNum As Object) As Object


        If KeyNum = 8 Then

            CheckNum = KeyNum : Exit Function
        End If

        If KeyNum < 46 Or KeyNum > 57 Then

            CheckNum = 0
            MsgBox("Please Enter Numbers Only")
        Else
            CheckNum = KeyNum
        End If
    End Function

    Function DateFormat(ByRef vdate1 As Object) As Object

        DateFormat = VB6.Format(vdate1, "dd-MMM-yyyy")
    End Function

    Function DateFormat1(ByRef vdate1 As Object) As Object

        DateFormat1 = VB6.Format(vdate1, "dd-MMM-yy")
    End Function



    Function forCur(ByRef Var1 As Object) As Object

        forCur = VB6.Format(Var1, "###,##,###.00")
    End Function
    Function checknumericval(ByVal e As KeyEventArgs)
        If (e.KeyCode < 48 Or e.KeyCode > 57) And e.KeyCode <> 8 Then
            MessageBox.Show("Please Enter Numeric ")
            e.SuppressKeyPress = True
        End If
        Return 0
    End Function

    'Public Function NoofDays(ByRef MonthVar As Object) As Object
    '    Select Case MonthVar
    '        Case 1, 3, 5, 7, 8, 10, 12

    '            NoofDays = 31
    '        Case 4, 6, 9, 11

    '            NoofDays = 30
    '        Case 2
    '            If Year(Today) Mod 4 = 0 Then

    '                NoofDays = 29
    '            Else

    '                NoofDays = 28
    '            End If
    '    End Select
    'End Function


    'Public Function MonthName_Renamed(ByRef MVar As Object) As Object
    '    Select Case MVar
    '        Case 1

    '            MonthName_Renamed = "Jan"
    '        Case 2

    '            MonthName_Renamed = "Feb"
    '        Case 3

    '            MonthName_Renamed = "Mar"
    '        Case 4

    '            MonthName_Renamed = "Apr"
    '        Case 5

    '            MonthName_Renamed = "May"
    '        Case 6

    '            MonthName_Renamed = "Jun"
    '        Case 7

    '            MonthName_Renamed = "Jul"
    '        Case 8

    '            MonthName_Renamed = "Aug"
    '        Case 9

    '            MonthName_Renamed = "Sep"
    '        Case 10

    '            MonthName_Renamed = "Oct"
    '        Case 11

    '            MonthName_Renamed = "Nov"
    '        Case 12

    '            MonthName_Renamed = "Dec"
    '    End Select
    'End Function


    'Public Function weekDay_Renamed(ByRef Dvar As Object) As Object
    '    Select Case Dvar
    '        Case 1

    '            weekDay_Renamed = "Sun"
    '        Case 2

    '            weekDay_Renamed = "Mon"
    '        Case 3

    '            weekDay_Renamed = "Tue"
    '        Case 4

    '            weekDay_Renamed = "Wed"
    '        Case 5

    '            weekDay_Renamed = "The"
    '        Case 6

    '            weekDay_Renamed = "Fri"
    '        Case 7

    '            weekDay_Renamed = "Sat"
    '    End Select
    'End Function


End Module