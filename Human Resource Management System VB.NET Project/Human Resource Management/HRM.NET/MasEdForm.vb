Option Strict Off
Option Explicit On
Friend Class MasEdForm
	Inherits System.Windows.Forms.Form
    Dim cNameVar As String
	
	Private Sub Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button.Click
		Dim Index As Short = Button.GetIndex(eventSender)
		Select Case Index
			Case 0
                ClearTxtControls(Me, Module1.CtrlType.TextBox)
				Button(1).Enabled = True
				Button(0).Enabled = False
			Case 1
                StrSql = "insert into MasEd(cName,Years) values ('" & Text1.Text & "','" & Text2.Text & "')"
                Conn.Execute(StrSql)
                MsgBox("New Course is Added!!", MsgBoxStyle.Information)
				Button(1).Enabled = False
				Button(0).Enabled = True
				DisRec()
			Case 2
				If MsgBoxResult.Yes = MsgBox("Do you want to Modify this Record", MsgBoxStyle.YesNo) Then
					Conn.Execute("update MasEd set cName='" & Text1.Text & "',Years='" & Text2.Text & "' where cName='" & cNameVar & "'")
					DisRec()
				End If
			Case 3
                If MsgBoxResult.Yes = MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo) Then
                    Conn.Execute("delete from  MasEd where CName='" & cNameVar & "'")
                    DisRec()
                End If
            Case 4
                Me.Close()

        End Select
		
	End Sub
    Private Sub MasEdForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        DisRec()
    End Sub
	
	Sub MSFInit()
		MSF.Clear()
        MSF.set_TextMatrix(0, 0, "Name")
		MSF.set_TextMatrix(0, 1, "App No")
		
	End Sub
	
	Sub DisRec()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select cName,Years from MasEd order by cName")
		MSFInit()
        I = 1
		Do While Not TempRS.EOF
            MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
            MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
            I = I + 1
			TempRS.MoveNext()
		Loop 
    End Sub
	
	Private Sub MSF_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.DblClick
		If MSF.get_TextMatrix(MSF.Row, 0) = "" Then Exit Sub
        cNameVar = MSF.get_TextMatrix(MSF.Row, 0)
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select * from MasEd where cName='" & cNameVar & "' ", Conn)
		Text1.Text = TempRS.Fields(0).Value
		Text2.Text = TempRS.Fields(1).Value
        Button(2).Enabled = True
		Button(3).Enabled = True
	End Sub

 
End Class