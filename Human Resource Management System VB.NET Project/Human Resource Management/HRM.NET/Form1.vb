Option Explicit On
Option Strict Off
Public Class Form1
    Inherits System.Windows.Forms.Form
    Public cNameVar As Object
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = VB6.TwipsToPixelsX(10230)
        Me.Height = VB6.TwipsToPixelsY(6975)
        Me.Left = VB6.TwipsToPixelsX(100)
        Me.Top = VB6.TwipsToPixelsY(100)
        DisRec()
    End Sub

    Sub MSF1Init()
        MSF1.Clear()
        MSF1.set_ColWidth(0, 1600)
        MSF1.set_ColWidth(1, 800)
        MSF1.set_TextMatrix(0, 0, "Course")
        MSF1.set_TextMatrix(0, 1, "Year")

    End Sub

    Sub DisRec()
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select cName,years from MasBr order by cName")
        MSF1Init()
        I = 1
        Do While Not TempRS.EOF
            MSF1.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
            MSF1.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
            I = I + 1
            TempRS.MoveNext()
        Loop
    End Sub

    Private Sub MSF1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF1.DblClick
        If MSF1.get_TextMatrix(MSF1.Row, 0) = "" Then Exit Sub
        cNameVar = MSF1.get_TextMatrix(MSF1.Row, 0)
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select * from MasBr where cName='" & cNameVar & "' ", Conn)
        TextBox1.Text = TempRS.Fields(0).Value
        TextBox2.Text = TempRS.Fields(1).Value
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        ClearTxtControls(Me, Module1.CtrlType.TextBox)
        Button1.Enabled = True
        Button0.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StrSql = "insert into MasBr(cName,Years) values ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        Conn.Execute(StrSql)
        MsgBox("New Course is Added!!", MsgBoxStyle.Information)
        Button1.Enabled = False
        Button0.Enabled = True
        DisRec()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBoxResult.Yes = MsgBox("Do you want to Modify this Record", MsgBoxStyle.YesNo) Then
            Conn.Execute("update MasBr set cName='" & TextBox1.Text & "',Years='" & TextBox2.Text & "' where cName='" & cNameVar & "'")
            DisRec()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBoxResult.Yes = MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo) Then
            Conn.Execute("delete from  MasBr where CName='" & cNameVar & "'")
            DisRec()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
