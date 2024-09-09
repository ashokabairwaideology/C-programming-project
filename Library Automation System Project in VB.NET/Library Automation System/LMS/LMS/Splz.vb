Imports System.Management
Public Class Splz

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Settings.ThisMachineID = "" Then

            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + 2
                If ProgressBar1.Value < 10 Then
                    Label1.Text = "Loading Environment..."
                ElseIf ProgressBar1.Value > 10 And ProgressBar1.Value < 80 Then
                    Label1.Text = "Please wait..."
                    'Here Let's extract the Machine ID
                    Try
                        Dim obj As ManagementObject
                        Dim objsrc As New ManagementObjectSearcher("select * from Win32_Processor")
                        Dim col As ManagementObjectCollection
                        col = objsrc.Get
                        For Each obj In col
                            My.Settings.ThisMachineID = obj.Item("ProcessorID")
                            My.Settings.Save()
                        Next
                    Catch ex As Exception

                    End Try

                ElseIf ProgressBar1.Value > 80 Then
                    Label1.Text = "Machine Verifying Done..."
                End If
            Else
                Timer1.Enabled = False
                Me.Hide()
                MainForm.Show()
            End If
        Else
            ProgressBar1.Value = 100
            Timer1.Enabled = False
            Me.Hide()
            MainForm.Show()
        End If
    End Sub

    Private Sub Splz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Style = ProgressBarStyle.Continuous
        Timer1.Enabled = True
    End Sub
End Class