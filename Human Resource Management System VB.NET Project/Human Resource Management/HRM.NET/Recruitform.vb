Option Strict Off
Option Explicit On
Friend Class RecruitForm
	Inherits System.Windows.Forms.Form
	
	
	
	
	Private Sub ButClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButClose.Click
		Me.Close()
	End Sub
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim Var1 As Object
        If Text1.Text = "" Then
            MsgBox("AppNo shud not be blank!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Text3.Text = "" Then
            MsgBox("Salary field shud not be blank!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Combo2.Text = "" Then
            MsgBox("Education field shud not be blank!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Combo3.Text = "" Then
            MsgBox("Job field shud not be blank!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Option1.Checked = True Then
            Var1 = "male"
        Else
            Var1 = "female"
        End If
        StrSql = "insert into Employee values(" & Val(Text1.Text) & ",'" & UCase(Text2.Text) & "','" & Var1 & "','" & DateFormat(DOB) & "','" & Combo2.Text & "','" & Combo3.Text & "','" & Val(Text3.Text) & "','" & DateFormat(Jdate) & "')"
        Conn.Execute(StrSql)
        MsgBox("This record is saved successfully")
    End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("Select aNo,aName,totMarks,ScoMarks,Remark from Interview where jNo=" & Val(Combo1.Text) & " order by totMarks,ScoMarks", Conn)
        I = 1
		MSF.Clear()
		MSF.set_TextMatrix(0, 0, "App No")
		MSF.set_TextMatrix(0, 1, "App Name")
		MSF.set_TextMatrix(0, 2, "Tot Marks")
		MSF.set_TextMatrix(0, 3, "Sco Marks")
		MSF.set_TextMatrix(0, 4, "Remark")
		MSF.set_ColWidth(4, 2400)
		Do While Not TempRS.EOF
            MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
			MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
			MSF.set_TextMatrix(I, 2, TempRS.Fields(2).Value)
			MSF.set_TextMatrix(I, 3, TempRS.Fields(3).Value)
			MSF.set_TextMatrix(I, 4, TempRS.Fields(4).Value)
			TempRS.MoveNext()
			I = I + 1
		Loop 
	End Sub
	
	Private Sub RecruitForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(10230)
		Me.Height = VB6.TwipsToPixelsY(6975)
		Me.Left = VB6.TwipsToPixelsX(100)
		Me.Top = VB6.TwipsToPixelsY(100)
		
		If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select distinct Cname from MasEd order by cName")
		Combo2.Items.Clear()
		Do While Not TempRS.EOF
			Combo2.Items.Add((TempRS.Fields(0).Value))
			TempRS.MoveNext()
		Loop 
		
		If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select distinct jTitle from jobOpen order by jTitle")
		Combo3.Items.Clear()
		Do While Not TempRS.EOF
			Combo3.Items.Add((TempRS.Fields(0).Value))
			TempRS.MoveNext()
		Loop 
		
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select distinct jno from selList order by jNo", Conn)
		Combo1.Items.Clear()
		Do While Not TempRS.EOF
			Combo1.Items.Add(TempRS.Fields(0).Value)
			TempRS.MoveNext()
		Loop 
	End Sub
	
	Private Sub MSF_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.DblClick
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select * from Resume where RName='" & MSF.get_TextMatrix(MSF.Row, 1) & "'", Conn)
		If Not TempRS.EOF Then
			Text1.Text = TempRS.Fields(0).Value & ""
			Text2.Text = TempRS.Fields(1).Value & ""
			If TempRS.Fields(9).Value = "Male" Then
				Option1.Checked = True
			Else
				Option2.Checked = True
			End If
			DOB._Value = TempRS.Fields(10).Value
			Combo2.Text = TempRS.Fields(12).Value
			
		End If
	End Sub

   
End Class