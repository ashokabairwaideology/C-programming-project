Option Strict Off
Option Explicit On
Friend Class TrainytestForm
	Inherits System.Windows.Forms.Form
	Dim YVar, Num, N1 As Object
	Dim R1 As Integer
	Dim EdVar As Object
	Dim JName As String
	
	
	
	Private Sub ButClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButClose.Click
		Me.Close()
	End Sub
	
	Private Sub butSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles butSave.Click
		If Combo1.Text = "" Then
			MsgBox("Please select the Batch No ")
			Exit Sub
		End If
		
		If Text2.Text = "" Then
			MsgBox("Please enter the employee")
			Exit Sub
		End If
        StrSql = "update TrainingSel set scoMarks=" & Val(Text5.Text) & ",remark='" & Text1.Text & "' where empno=" & Text2.Text & " and batchno='" & Combo1.Text & "'"
		Conn.Execute(StrSql)
        MsgBox("Entry is saved successfully!!!!!", MsgBoxStyle.Information)
    End Sub
	
	
	
	
	
	
	
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("Select empNo,eName from TrainingSel where batchNo='" & Combo1.Text & "' order by eName", Conn)

		I = 1
		MSF.Clear()
		MSF.set_TextMatrix(0, 0, "empNo No")
		MSF.set_TextMatrix(0, 1, "Name")
		Do While Not TempRS.EOF

			MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)

			MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
			TempRS.MoveNext()

			I = I + 1
		Loop 
	End Sub
	
	Private Sub TrainytestForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(10230)
		Me.Height = VB6.TwipsToPixelsY(6975)
		Me.Left = VB6.TwipsToPixelsX(100)
		Me.Top = VB6.TwipsToPixelsY(100)
		
		
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select distinct batchNo from trainingSel order by batchNo", Conn)
		Combo1.Items.Clear()
		Do While Not TempRS.EOF
			Combo1.Items.Add(TempRS.Fields(0).Value)
			TempRS.MoveNext()
		Loop 
	End Sub
	
	
	
	
	Private Sub MSF_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.DblClick
		If Not MSF.get_TextMatrix(MSF.Row, 0) = "" Then
			Text2.Text = MSF.get_TextMatrix(MSF.Row, 0)
			Text3.Text = MSF.get_TextMatrix(MSF.Row, 1)
		End If
	End Sub
End Class