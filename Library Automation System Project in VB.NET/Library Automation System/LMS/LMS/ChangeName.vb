Public Class ChangeName

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            My.Settings.CompanyName = Me.TextBox1.Text
            My.Settings.Save()
            MainForm.Text = My.Settings.CompanyName & " Management System"
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChangeName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.TextBox1.Text = My.Settings.CompanyName
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        Try
            Dim a, b As Integer
            Dim NameTO, NameFrm As String
            a = TextBox1.Text.Length
            NameFrm = TextBox1.Text
            NameTO = ""
            For b = 0 To a - 1
                If b = 0 Then
                    If Char.IsLower(NameFrm(0)) Then
                        NameTO = Char.ToUpper(NameFrm(0))
                    Else
                        NameTO = NameFrm(0)
                    End If
                Else
                    If NameFrm(b - 1) = " " Then
                        NameTO = NameTO + Char.ToUpper(NameFrm(b))
                    Else
                        NameTO = NameTO + NameFrm(b)
                    End If
                End If
            Next
            TextBox1.Text = NameTO
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        Try
            Dim a, b As Integer
            Dim NameTO, NameFrm As String
            a = TextBox1.Text.Length
            NameFrm = TextBox1.Text
            NameTo = ""
            For b = 0 To a - 1
                If b = 0 Then
                    If Char.IsLower(NameFrm(0)) Then
                        NameTo = Char.ToUpper(NameFrm(0))
                    Else
                        NameTo = NameFrm(0)
                    End If
                Else
                    If NameFrm(b - 1) = " " Then
                        NameTo = NameTo + Char.ToUpper(NameFrm(b))
                    Else
                        NameTo = NameTo + NameFrm(b)
                    End If
                End If
            Next
            TextBox1.Text = NameTO
        Catch ex As Exception

        End Try
    End Sub
End Class