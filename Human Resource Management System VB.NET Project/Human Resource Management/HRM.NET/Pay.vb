
Imports System.Data.OleDb
Public Class Pay
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        sql = "insert into Pay(empidno,empfname,emplname,emppos,empstat,wHours,Amount,netPay,payDate) values ('" & TextBox2.Text & _
        "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & _
        TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & DateTimePicker1.Text & "')"

        oledbAdapter.InsertCommand = New OleDbCommand(sql, connection)
        oledbAdapter.InsertCommand.ExecuteNonQuery()
        MsgBox("Payment Detail Inserted Successfully !! ")
        drow()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        TextBox3.Text() = ""
        TextBox4.Text() = ""
        TextBox5.Text() = ""
        TextBox6.Text() = ""
        TextBox7.Text() = ""
        TextBox8.Text() = ""
        TextBox9.Text() = ""
    End Sub

    Private Sub Pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False

        Button4.Enabled = False
        Button1.Enabled = False
        connectiondb()
        drow()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql = "update pay set empfname='" & TextBox3.Text & "',emplname='" & TextBox4.Text & "',emppos='" & TextBox5.Text & "',empstat='" & TextBox6.Text & "',wHours='" & TextBox7.Text & "',Amount=" & TextBox8.Text & ",netPay=" & TextBox9.Text & ",payDate='" & DateTimePicker1.Text & "' where payID = " & TextBox1.Text

        oledbAdapter.UpdateCommand = connection.CreateCommand
        oledbAdapter.UpdateCommand.CommandText = sql
        oledbAdapter.UpdateCommand.ExecuteNonQuery()
        drow()
        MsgBox("Payment is Updated !! ")
        



    End Sub

    

    

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        sql = "delete from  Pay where payID=" & TextBox1.Text
        Try

            oledbAdapter.DeleteCommand = connection.CreateCommand
            oledbAdapter.DeleteCommand.CommandText = sql
            oledbAdapter.DeleteCommand.ExecuteNonQuery()
            MsgBox("Row(s) Deleted !! ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        drow()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub clrTxt()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub
    Private Sub DataGridView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        clrTxt()
        On Error Resume Next
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox8.Text = DataGridView1.CurrentRow.Cells(7).Value
        TextBox9.Text = DataGridView1.CurrentRow.Cells(8).Value
        Button3.Enabled = True
        Button4.Enabled = True

    End Sub

    Public Sub drow()
        cmd = New OleDbCommand("Select * From Pay", connection)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9))
        Loop
    End Sub

End Class