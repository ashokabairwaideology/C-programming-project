Option Strict Off
Option Explicit On
Friend Class LoginAdmin
	Inherits System.Windows.Forms.Form
    Private Sub ButClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub
    Private Sub butExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles butExit.Click
        End
    End Sub
    Private Sub butSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles butSave.Click
        For I = 1 To 10
            Conn.Execute("update users set username='" & UCase(MSF.get_TextMatrix(I, 0)) & "', Pword='" & MSF.get_TextMatrix(I, 1) & "' where rno = " & I)
        Next
        Conn.Execute("update users set username='" & UCase(Text3.Text) & "', Pword='" & Text2.Text & "' where rno = 0")
    End Sub
    Private Sub LoginAdmin_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Dim RowNo As Object
        Me.Height = VB6.TwipsToPixelsY(6500)
        Me.Width = VB6.TwipsToPixelsX(6000)
        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(MDIForm1.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(MDIForm1.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2 - 400)
        MSF.Clear()
        MSF.set_ColWidth(0, 2500)
        MSF.set_ColWidth(1, 2500)
        MSF.set_TextMatrix(0, 0, "User Name ")
        MSF.set_TextMatrix(0, 1, "Password ")
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select * from users where rno > 0", Conn)

        RowNo = 1
        Do While Not TempRS.EOF
            MSF.set_TextMatrix(RowNo, 0, TempRS.Fields(1).Value & "")
            MSF.set_TextMatrix(RowNo, 1, TempRS.Fields(2).Value & "")
            RowNo = RowNo + 1
            TempRS.MoveNext()
        Loop
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select * from users where rno = 0", Conn)
        Text3.Text = TempRS.Fields(1).Value & ""
        Text2.Text = TempRS.Fields(2).Value & ""
    End Sub
    Private Sub MSF_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.ClickEvent
        Text1.Height = VB6.TwipsToPixelsY(MSF.get_RowHeight(MSF.Row))
        Text1.Width = VB6.TwipsToPixelsX(MSF.get_ColWidth(MSF.Col))
        Text1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(MSF.Top) + MSF.CellTop)
        Text1.Left = VB6.TwipsToPixelsX(MSF.CellLeft + VB6.PixelsToTwipsX(MSF.Left))
        Text1.Text = MSF.get_TextMatrix(MSF.Row, MSF.Col)
        Text1.Visible = True
        Text1.SelectionStart = 0
        Text1.SelectionLength = Len(Text1.Text)
        Text1.Focus()
    End Sub
    Private Sub MSF_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.LeaveCell
        MSF.set_TextMatrix(MSF.Row, MSF.Col, Text1.Text)
        Text1.Visible = False
    End Sub
    Private Sub Text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            MSF.set_TextMatrix(MSF.Row, MSF.Col, Text1.Text)
            Text1.Visible = False
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
End Class