Option Strict Off
Option Explicit On
Friend Class TrainingForm
	Inherits System.Windows.Forms.Form
	Dim Num As Integer
	Dim tNameVar As String
	
	Private Sub Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button.Click
		Dim Index As Short = Button.GetIndex(eventSender)
		Select Case Index
			Case 0
				
				Num = 1
				ClearTxtControls(Me, Module1.CtrlType.TextBox)
				Button(1).Enabled = True
				Button(0).Enabled = False
			Case 1
				

                StrSql = "insert into Training(tName,tDays,det) values "

                StrSql = StrSql & " ('" & Text1.Text & "','" & Text2.Text & "','" & Text3.Text & "')"

				Conn.Execute(StrSql)
				Button(1).Enabled = False
				Button(0).Enabled = True
				DisRec()
			Case 2
				If MsgBoxResult.Yes = MsgBox("Do you want to Modify this Record", MsgBoxStyle.YesNo) Then
                    Conn.Execute("update Training set tName='" & Text1.Text & "',tDays='" & Text2.Text & "',det='" & Text3.Text & "' where tName='" & tNameVar & "'")
					DisRec()
				End If
			Case 3
				
				If MsgBoxResult.Yes = MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo) Then
					Conn.Execute("delete from  Training where tName='" & tNameVar & "'")
					DisRec()
				End If
				
			Case 4
				Me.Close()
				
		End Select
		
	End Sub
	
	
	Private Sub TrainingForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(10230)
		Me.Height = VB6.TwipsToPixelsY(6975)
		Me.Left = VB6.TwipsToPixelsX(100)
		Me.Top = VB6.TwipsToPixelsY(100)
		DisRec()
	End Sub
	
	Sub MSFInit()
		MSF.Clear()
		MSF.set_ColWidth(0, 1600)
		MSF.set_ColWidth(1, 800)
		MSF.set_TextMatrix(0, 0, "Name")
        MSF.set_TextMatrix(0, 1, "Duration")
		
	End Sub
	
	Sub DisRec()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select tName,tDays from Training order by tName")
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
		
		tNameVar = MSF.get_TextMatrix(MSF.Row, 0)
        If TempRS.State = 1 Then TempRS.Close()
        Button(2).Enabled = True
        Button(3).Enabled = True
		TempRS.Open("select * from Training where tName='" & tNameVar & "' ", Conn)
		Text1.Text = TempRS.Fields(0).Value
        Text2.Text = TempRS.Fields(1).Value
        Text3.Text = ""
        Text3.Text = TempRS.Fields(2).Value
     
	End Sub

  
End Class