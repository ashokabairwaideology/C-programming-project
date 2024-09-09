Public Class LicenseForm

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox3.Text <> "" Then
                If TextBox3.Text = String.Concat("%" & TextBox1.Text & "%", TextBox2.Text & "%") Then
                    My.Settings.LicenseTo = TextBox1.Text
                    My.Settings.LicenseKey = TextBox3.Text
                    My.Settings.Save()
                    MsgBox("Register Successfully!", MsgBoxStyle.Information, "")
                Else
                    MsgBox("Invalid License Key!", MsgBoxStyle.Exclamation, "")
                End If
            Else
                MsgBox("Please enter the License Key!", MsgBoxStyle.Exclamation, "")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LicenseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TextBox2.Text = My.Settings.ThisMachineID

            If My.Settings.LicenseKey = "" Then

                'Now Verify the key is ok or not
                'If it is not OK then Just Change the Registration Process

            Else
                TextBox1.Text = My.Settings.LicenseTo
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Text = My.Settings.LicenseKey
                TextBox3.Enabled = False
                Button1.Visible = False
                Button2.Visible = False
                Label3.Visible = False
                TextBox3.Visible = False
                Me.Height = 170

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class