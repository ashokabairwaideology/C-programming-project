Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class MatchForm
	Inherits System.Windows.Forms.Form
	Dim YVar, Num, N1 As Object
	Dim R1 As Integer
	Dim EdVar As Object
	Dim JName As String
	
	
	
	Private Sub ButClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButClose.Click
        Me.Close()

	End Sub
	
	Private Sub butSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles butSave.Click
		If L1.Text = "" Then
			MsgBox("Please select the Job ")
			Exit Sub
		End If
		Conn.Execute("delete from selList where jNo=" & Val(L1.Text) & "")
		For I = 1 To R1
            If Not MSF1.get_TextMatrix(I, 0) = "" Then
                StrSql = "insert into selList(jNo,jtitle,aNo,aName) values(" & Val(VB.Right(L1.Text, 4)) & ",'" & L2.Text & "'," & MSF1.get_TextMatrix(I, 0) & ",'" & MSF1.get_TextMatrix(I, 1) & "')"
                Conn.Execute(StrSql)
            End If
		Next 
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		If EdVar = "" Then
            MsgBox("Please select the Job")
            Exit Sub
        End If
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("Select rno,rName,Ed,Ex from Resume where ed='" & Trim(EdVar) & "' and ex >= " & YVar & "", Conn)
		MSF1Init()
		I = 1
		Do While Not TempRS.EOF
			MSF1.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
			MSF1.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
			MSF1.set_TextMatrix(I, 2, TempRS.Fields(2).Value)
			MSF1.set_TextMatrix(I, 3, TempRS.Fields(3).Value)
			TempRS.MoveNext()
			I = I + 1
		Loop 
		R1 = I
    End Sub
	Sub MSF1Init()
		MSF1.Clear()
		MSF1.set_ColWidth(0, 600)
		MSF1.set_ColWidth(1, 2400)
		MSF1.set_ColWidth(2, 1200)
		MSF1.set_ColWidth(3, 1200)

		MSF1.set_TextMatrix(0, 0, "App No")
		MSF1.set_TextMatrix(0, 1, "Name")
		MSF1.set_TextMatrix(0, 2, "Education")
		MSF1.set_TextMatrix(0, 3, "Experience")
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select rNO,jTitle,NoPost,Ed,NoYear from JobOpen order by rNo", Conn)
		I = 1
		MSFInit()
		Do While Not TempRS.EOF
			MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
			MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
			MSF.set_TextMatrix(I, 2, TempRS.Fields(2).Value)
			MSF.set_TextMatrix(I, 3, TempRS.Fields(3).Value & "")
			MSF.set_TextMatrix(I, 4, TempRS.Fields(4).Value)
			TempRS.MoveNext()
			I = I + 1
		Loop 
	End Sub
	
	Private Sub Command3_Click()
		Dim DataReport1 As Object
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("Select rno,rName,Ed,Ex from Resume where ed='" & Trim(EdVar) & "' and ex >= " & YVar & "", Conn)
		DataReport1.DataSource = TempRS
		DataReport1.Sections("section4").Controls("L1").Caption = JName
		DataReport1.Sections("section4").Controls("L2").Caption = N1
		DataReport1.Show()
	End Sub
	
	Private Sub MatchForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(10230)
		Me.Height = VB6.TwipsToPixelsY(6975)
		Me.Left = VB6.TwipsToPixelsX(100)
		Me.Top = VB6.TwipsToPixelsY(100)
		Command2_Click(Command2, New System.EventArgs())
	End Sub
	
	Sub MSFInit()
		MSF.Clear()
		MSF.set_ColWidth(0, 600)
		MSF.set_ColWidth(1, 1600)
		MSF.set_ColWidth(2, 1000)
		MSF.set_ColWidth(3, 1200)
		MSF.set_ColWidth(4, 1000)
		MSF.set_TextMatrix(0, 0, "Job No")
		MSF.set_TextMatrix(0, 1, "Post")
		MSF.set_TextMatrix(0, 2, "No of Post")
		MSF.set_TextMatrix(0, 3, "Education")
		MSF.set_TextMatrix(0, 4, "Experience")
	End Sub
	
	Sub DisRec()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select rName,rno from Resume order by rName")
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
		L1.Text = MSF.get_TextMatrix(MSF.Row, 0)
		N1 = Val(MSF.get_TextMatrix(MSF.Row, 0))
		L2.Text = "Post Name : " & MSF.get_TextMatrix(MSF.Row, 1)
		JName = MSF.get_TextMatrix(MSF.Row, 1)
		L3.Text = "Post Nos : " & MSF.get_TextMatrix(MSF.Row, 2)
		L4.Text = "Qualification : " & MSF.get_TextMatrix(MSF.Row, 3)
		L5.Text = "Experience : " & MSF.get_TextMatrix(MSF.Row, 4)
		EdVar = MSF.get_TextMatrix(MSF.Row, 3)
		YVar = Val(MSF.get_TextMatrix(MSF.Row, 4))
	End Sub

    
End Class