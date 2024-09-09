Public Class LoginForm1
    Inherits System.Windows.Forms.Form
    Dim LNo As Byte
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select * from users where username='" & UCase(UsernameTextBox.Text) & "' and pword = '" & PasswordTextBox.Text & "'", Conn)
        If TempRS.EOF = True Then
            MsgBox("The entered UserName or Password is not Correct")
            UsernameTextBox.Focus()
            LNo = 1
        Else
            If TempRS.State = 1 Then TempRS.Close()
            TempRS.Open("select * from users where username='ADMIN' and pword = '" & PasswordTextBox.Text & "'", Conn)
            If Not TempRS.EOF = True Then
                UserNameVar = "ADMIN"
            End If
            MDIForm1.Show()

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        LNo = 1
        Me.Close()
        End
    End Sub

    Private Sub UsernameTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.Enter
        UsernameTextBox.SelectionStart = 0
        UsernameTextBox.SelectionLength = Len(UsernameTextBox.Text)
    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        Dim KeyAscii As Short = Asc(EventArgs.KeyChar)
        If KeyAscii = 13 Then PasswordTextBox.Focus()
        EventArgs.KeyChar = Chr(KeyAscii)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LNo = 2
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select * from users where UserName = 'ADMIN' and pword = '" & PasswordTextBox.Text & "' and rno=0", Conn)
        If TempRS.EOF = True Then
            MsgBox("The entered UserName or Password is not Correct")
            UsernameTextBox.Focus()
            LNo = 1
        Else
            UserNameVar = "ADMIN"
            LoginAdmin.Show()
        End If
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatabasePath = My.Application.Info.DirectoryPath & "\HRMS.mdb"
        Conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info = False; Data Source=" & DatabasePath & ""
        Conn.Open(Conn.ConnectionString, "Admin")


    End Sub

  
End Class
