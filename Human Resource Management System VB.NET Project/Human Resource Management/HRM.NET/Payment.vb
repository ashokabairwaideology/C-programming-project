Imports System.Data.OleDb
Public Class Payment

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "insert into Employe(PayDate) values('" & DateTimePicker1.Text & "')"

        oledbAdapter.InsertCommand = New OleDbCommand(sql, connection)
        oledbAdapter.InsertCommand.ExecuteNonQuery()
        MsgBox("Payment Date is Inserted Successfully !! ")

        drow()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql = "update Employee set Sal='" & TextBox4.Text & "'where EmpNo = " & TextBox1.Text
        sql = "update Employe set PayDate='" & DateTimePicker1.Text & "'where EmpNo = " & TextBox1.Text
        oledbAdapter.UpdateCommand = connection.CreateCommand
        oledbAdapter.UpdateCommand.CommandText = sql
        oledbAdapter.UpdateCommand.ExecuteNonQuery()
        drow()
        MsgBox("Payment is Updated !! ")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        sql = "delete from  Employee where EmpNo=" & TextBox1.Text
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Public Sub drow()
        cmd = New OleDbCommand("Select EmpNo,eName,Job,Sal,DOJ From Employee", connection)

        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4))
        Loop
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value


        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value

        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button4.Enabled = False
        Button2.Enabled = False
        connectiondb()
        drow()
    End Sub
End Class