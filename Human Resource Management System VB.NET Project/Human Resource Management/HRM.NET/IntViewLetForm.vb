
Option Strict Off
Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine

Imports Crystaldecisions.reportsource
Imports Crystaldecisions.shared
Imports Crystaldecisions.windows.forms

Friend Class IntViewLetForm
    Inherits System.Windows.Forms.Form
    Dim YVar, Num, N1 As Object
    Dim R1 As Integer
    Dim EdVar As Object
    Dim JName As String
    Private Sub ButClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButClose.Click
        Me.Close()
    End Sub

    Private Sub butSave_Click()

    End Sub

   


    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("Select aNo,aName from selList where jNo=" & Val(Combo1.Text) & " order by aName", Conn)
        I = 1
        MSF.Clear()
        MSF.set_TextMatrix(0, 0, "App No")
        MSF.set_TextMatrix(0, 1, "App Name")
        Do While Not TempRS.EOF
            MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
            MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
            TempRS.MoveNext()
            I = I + 1
        Loop
    End Sub

    Private Sub IntViewLetForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Width = VB6.TwipsToPixelsX(10230)
        Me.Height = VB6.TwipsToPixelsY(6975)
        Me.Left = VB6.TwipsToPixelsX(100)
        Me.Top = VB6.TwipsToPixelsY(100)
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select distinct jno from selList order by jNo", Conn)
        Combo1.Items.Clear()
        Do While Not TempRS.EOF
            Combo1.Items.Add(TempRS.Fields(0).Value)
            TempRS.MoveNext()
        Loop
        iappno = 0
        iname = ""
        iaddress = ""
        imsg = ""
        idate = ""
        itime = ""
    End Sub

  


    Private Sub MSF_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.DblClick
        If Not MSF.get_TextMatrix(MSF.Row, 0) = "" Then
            Text2.Text = MSF.get_TextMatrix(MSF.Row, 0)
            Text3.Text = MSF.get_TextMatrix(MSF.Row, 1)
        End If
    End Sub

    Private Sub butSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSend.Click
        Conn.Execute("delete from intlet")
        Dim k As String

        k = Format(DTPicker2.Value, "HH:mm:ss")

        Conn.Execute("insert into intlet(appno,name,msg,intDate,inttime) values (" & Val(Text2.Text) & ",'" & Text3.Text & "','" & Text1.Text & "','" & DTPicker1.Value & "','" & k & "')")
        MessageBox.Show("Letter is Sent")
        IntLetRep.Show()
        Me.Close()
    End Sub
End Class