Option Strict Off
Option Explicit On
Friend Class IntViewForm
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
            MsgBox("Please select the Job ")
            Exit Sub
        End If

        If Text2.Text = "" Then
            MsgBox("Please enter the Applicact No")
            Exit Sub
        End If

        Conn.Execute("delete from InterView where jNo=" & Val(Combo1.Text) & " and aNo=" & Val(Text2.Text) & "")
        StrSql = "insert into Interview(jNo,aNo,aName,intDate,IntTime,remark,totMarks,ScoMarks) values(" & Val(Combo1.Text) & "," & Val(Text2.Text) & ",'" & Text3.Text & "','" & DateFormat((DTPicker1.Value)) & "','" & VB6.Format(DTPicker1.Value, "HH:MM PM") & "','" & Text1.Text & "'," & Val(Text4.Text) & "," & Val(Text5.Text) & ")"
        Conn.Execute(StrSql)
        MsgBox("Interview record Saved Successfully!!!", MsgBoxStyle.Information)
    End Sub





	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("Select aNo,aName from selList where jNo=" & Val(Combo1.Text) & " order by aName", Conn)
		I = 1
		MSF.Clear()
		MSF.set_TextMatrix(0, 0, "App No")
		MSF.set_TextMatrix(0, 1, "App Name")
		Do While Not TempRS.EOF
			MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
            MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
			TempRS.MoveNext()
			I = I + 1
		Loop 
	End Sub
	
	Private Sub IntViewForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select distinct jno from selList order by jNo", Conn)
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

    Private Sub MSF_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSF.Enter

    End Sub
End Class