Option Strict Off
Option Explicit On
Friend Class MasSkillForm
	Inherits System.Windows.Forms.Form
	Dim Num As Integer
	Dim cNameVar As String
	
	Private Sub Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button.Click
		Dim Index As Short = Button.GetIndex(eventSender)
		Select Case Index
			Case 0
				
				Num = 1
				ClearTxtControls(Me, Module1.CtrlType.TextBox)
				Button(1).Enabled = True
				Button(0).Enabled = False
			Case 1
				

				StrSql = "insert into MasSkill(cName,Det) values "

				StrSql = StrSql & " ('" & Text1.Text & "','" & Text2.Text & "')"

				Conn.Execute(StrSql)
				Button(1).Enabled = False
				Button(0).Enabled = True
				DisRec()
			Case 2
				If MsgBoxResult.Yes = MsgBox("Do you want to Modify this Record", MsgBoxStyle.YesNo) Then
					Conn.Execute("update MasSkill set cName='" & Text1.Text & "',Det='" & Text2.Text & "' where cName='" & cNameVar & "'")
					DisRec()
				End If
			Case 3
				
				If MsgBoxResult.Yes = MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo) Then
					Conn.Execute("delete from  MasSkill where CName='" & cNameVar & "'")
					DisRec()
				End If
				
			Case 4
				Me.Close()
				
		End Select
		
	End Sub
	
	Private Sub Command1_Click()
        'Dim Text5 As Object
        'Dim Text4 As Object
        'Dim Text3 As Object
        'Dim MSF1 As Object

        'MSF1.TextMatrix(Num, 0) = Num

        '	MSF1.TextMatrix(Num, 1) = Text2.Text


        'MSF1.TextMatrix(Num, 2) = Text3


        '	MSF1.TextMatrix(Num, 3) = Text4


        'MSF1.TextMatrix(Num, 4) = Text5
		Num = Num + 1
		
		ClearTxtControls(Me, Module1.CtrlType.TextBox)
	End Sub
	
	Private Sub MasSkillForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
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
		MSF.set_TextMatrix(0, 1, "Details")
		
	End Sub
	
	Sub DisRec()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select cName,Det from MasSkill order by cName")
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
		TempRS.Open("select * from MasSkill where cName='" & cNameVar & "' ", Conn)
		Text1.Text = TempRS.Fields(0).Value
		Text2.Text = TempRS.Fields(1).Value
		
		
		Button(2).Enabled = True
		Button(3).Enabled = True
	End Sub

   
End Class