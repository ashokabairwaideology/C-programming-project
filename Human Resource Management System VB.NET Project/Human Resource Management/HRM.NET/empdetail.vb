Imports System.Data.OleDb
Public Class empdetail

    Dim gen As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            gen = "Male"
        Else
            gen = "Female"
        End If
        sql = "insert into Employee(eName,Gender,DOB,ED,Job,DOJ) values ('" & TextBox2.Text & _
              "','" & gen & "','" & DateTimePicker2.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Text & "')"


        oledbAdapter.InsertCommand = New OleDbCommand(sql, connection)
        oledbAdapter.InsertCommand.ExecuteNonQuery()
        MsgBox("Employee Detail Inserted Successfully !! ")

        drow()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        TextBox5.Text() = ""
        TextBox6.Text() = ""


    End Sub

    

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

  
   
    Private Sub empdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button4.Enabled = False
        Button2.Enabled = False
        connectiondb()
        drow()

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
    Public Sub drow()
        cmd = New OleDbCommand("Select * From Employee", connection)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
        Loop
    End Sub


    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
       
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            gen = "Male"
        Else
            gen = "Female"
        End If
        sql = "update Employee set eName='" & TextBox2.Text & "',Gender='" & gen & "', DOB='" & DateTimePicker2.Text & "',ED='" & TextBox5.Text & "',Job='" & TextBox6.Text & "',DOJ='" & DateTimePicker1.Text & "' where EmpNo = " & TextBox1.Text

        oledbAdapter.UpdateCommand = connection.CreateCommand
        oledbAdapter.UpdateCommand.CommandText = sql
        oledbAdapter.UpdateCommand.ExecuteNonQuery()
        drow()
        MsgBox("Employee is Updated !! ")

    End Sub

   


    Private Sub DataGridView1_DoubleClick2(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value


        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value

        Button3.Enabled = True
        Button4.Enabled = True
    End Sub
End Class