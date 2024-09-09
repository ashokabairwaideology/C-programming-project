Option Strict Off
Option Explicit On
Friend Class EdForm
	Inherits System.Windows.Forms.Form
	Dim Num As Integer
	
	Private Sub Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button.Click
		Dim Index As Short = Button.GetIndex(eventSender)
		Select Case Index
			Case 0
				Num = 1
				MSF1Init()
				Button(1).Enabled = True
				Button(0).Enabled = False
			Case 1
				If Num <= 1 Then MsgBox("Experience is not entered Please Check") : Exit Sub
				For I = 1 To Num
                    StrSql = "insert into AppEd values "
					StrSql = StrSql & " (" & Val(LblNo.Text) & ",'" & LblName.Text & "'," & I & ",'" & MSF1.get_TextMatrix(I, 1) & "','" & MSF1.get_TextMatrix(I, 2) & "','" & MSF1.get_TextMatrix(I, 3) & "','" & MSF1.get_TextMatrix(I, 4) & "','" & MSF1.get_TextMatrix(I, 5) & "')"
                    Conn.Execute(StrSql)
				Next 
				DisRec()
				Button(1).Enabled = False
				Button(0).Enabled = True
				
			Case 2
				If MsgBoxResult.Yes = MsgBox("Do you want to Modify this Record", MsgBoxStyle.YesNo) Then
                    Conn.Execute("delete from  appEd where rno=" & AppNo & "")
					For I = 1 To Num
                        If Not MSF1.get_TextMatrix(I, 1) = "" Then
                            StrSql = "insert into AppEd values "
                            StrSql = StrSql & " (" & Val(LblNo.Text) & ",'" & LblName.Text & "'," & I & ",'" & MSF1.get_TextMatrix(I, 1) & "','" & MSF1.get_TextMatrix(I, 2) & "','" & MSF1.get_TextMatrix(I, 3) & "','" & MSF1.get_TextMatrix(I, 4) & "','" & MSF1.get_TextMatrix(I, 5) & "')"
                            Conn.Execute(StrSql)
                        End If
					Next 
					DisRec()
				End If
			Case 3
				If MsgBoxResult.Yes = MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo) Then
					Conn.Execute("delete from  appEd where rno=" & AppNo & "")
					DisRec()
				End If
				
			Case 4
				Me.Close()
		End Select
		Num = 1
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        MSF1.set_TextMatrix(Num, 0, Num)
        MSF1.set_TextMatrix(Num, 1, Text1.Text)
        MSF1.set_TextMatrix(Num, 2, Text2.Text)
        MSF1.set_TextMatrix(Num, 3, Text3.Text)
        MSF1.set_TextMatrix(Num, 4, Text4.Text)
        MSF1.set_TextMatrix(Num, 5, Text5.Text)
        Num = Num + 1
		ClearTxtControls(Me, Module1.CtrlType.TextBox)
	End Sub
	Sub MSF1Init()
		MSF1.Clear()
		MSF1.set_ColWidth(0, 600)
		MSF1.set_ColWidth(1, 1000)
		MSF1.set_ColWidth(2, 1000)
		MSF1.set_ColWidth(3, 1600)
		MSF1.set_ColWidth(4, 800)
		MSF1.set_ColWidth(5, 600)
		MSF1.set_TextMatrix(0, 0, "SlNO")
		MSF1.set_TextMatrix(0, 1, "Degree")
		MSF1.set_TextMatrix(0, 2, "Branch")
		MSF1.set_TextMatrix(0, 3, "School/College")
		MSF1.set_TextMatrix(0, 4, "Year")
		MSF1.set_TextMatrix(0, 5, "%")
	End Sub
	Private Sub EdForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(10230)
		Me.Height = VB6.TwipsToPixelsY(6975)
		Me.Left = VB6.TwipsToPixelsX(100)
		Me.Top = VB6.TwipsToPixelsY(100)
		DisRec()
		Degree()
		Branch()
	End Sub
	
	Sub MSFInit()
		MSF.Clear()
		MSF.set_ColWidth(0, 1600)
		MSF.set_ColWidth(1, 800)
		MSF.set_TextMatrix(0, 0, "Name")
		MSF.set_TextMatrix(0, 1, "App No")
		
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
		LblNo.Text = MSF.get_TextMatrix(MSF.Row, 1)
		AppNo = CInt(MSF.get_TextMatrix(MSF.Row, 1))
		LblName.Text = MSF.get_TextMatrix(MSF.Row, 0)
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select * from AppEd where rno=" & AppNo & " order by slno ", Conn)
        I = 1
		MSF1Init()

        Do While Not TempRS.EOF
            MSF1.set_TextMatrix(I, 0, I)
            MSF1.set_TextMatrix(I, 1, TempRS.Fields(3).Value & "")
            MSF1.set_TextMatrix(I, 2, TempRS.Fields(4).Value & "")
            MSF1.set_TextMatrix(I, 3, TempRS.Fields(5).Value & "")
            MSF1.set_TextMatrix(I, 4, TempRS.Fields(6).Value & "")
            MSF1.set_TextMatrix(I, 5, TempRS.Fields(7).Value & "")
            MSF1.set_TextMatrix(I, 6, TempRS.Fields(8).Value & "")
            TempRS.MoveNext()
            I = I + 1
        Loop

        Num = I
        Button(2).Enabled = True
		Button(3).Enabled = True
	End Sub
	
	Sub Degree()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select Cname from MasEd order by cName")
		Do While Not TempRS.EOF
			Text1.Items.Add((TempRS.Fields(0).Value))
			TempRS.MoveNext()
		Loop 
		
	End Sub
	Sub Branch()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select Cname from MasBr order by cName")
		Do While Not TempRS.EOF
			Text2.Items.Add((TempRS.Fields(0).Value))
			TempRS.MoveNext()
		Loop 
	End Sub

   

    Private Sub _Button_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Button_0.Click

    End Sub
End Class