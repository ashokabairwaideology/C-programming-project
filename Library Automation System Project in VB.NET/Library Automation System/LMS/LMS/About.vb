Public Class About

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label4.Text = My.Settings.LicenseTo
            Label1.Text = My.Settings.CompanyName
            Me.Height = 200
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Me.Height = 200 Then
                Me.Height = 327
                Button2.Text = "^"
            Else
                Me.Height = 200
                Button2.Text = "V"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Process.Start("mailto:zosoftnet@gmail.com?Subject=Library Management System&body=ZoSoft Corporation,")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:zosoftnet@gmail.com?Subject=Library Management System&body=ZoSoft Corporation,")
    End Sub
End Class