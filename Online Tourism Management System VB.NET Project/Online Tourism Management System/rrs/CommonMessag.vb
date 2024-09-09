Imports System.Data.OleDb
Imports System.Data
Module CommonMessag

    Public Prjtitle As String   ' Project title to display in message box and else where
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Travelz.mdb;")   ' for connection to data base
    Public Muserid As String   ' for user who is useing the software





    Public Sub dataconect()
        'It will load in as login page 
        'For database connection.

        'con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Travelz.mdb;")
        Openconnection()
        Prjtitle = "TravelZ"
        Muserid = "Admin"


    End Sub
    'it uses to open the connection
    Public Sub Openconnection()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Travelz.mdb;")
        con.Open()
    End Sub
    'it uses to close the connection
    Public Sub CloseConnection()
        con.Close()
    End Sub
    Public Sub MsgSav()
        'To show message saved
        MsgBox("Record Updated", MsgBoxStyle.OKOnly, Prjtitle)

    End Sub
    Public Sub MsgDel()
        ' To show message record Deleted
        MsgBox("Record Deleted", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub

    Public Sub MsgRecexist()
        ' to show the message that record exsisted already
        MsgBox("Record Already Existing", MsgBoxStyle.OKOnly, Prjtitle)

    End Sub

    Public Sub MsgRecUsed()
        ' to show the message that Deleted record is used in child tables
        MsgBox("Record Mapped in Transaction, Record can not be Deleted", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub

    Function MsgDelAlert() As String


        ' to show the laert before deleting
        Dim strmsgdel As String
        strmsgdel = MsgBox("Do you want to delete the Record", MsgBoxStyle.YesNo, Prjtitle)

        MsgDelAlert = strmsgdel


        ' If msgdelalert = vbNo Then Exit Sub  ( this has to write in form level, after this
        ' comment it will go in to code.


    End Function


End Module
