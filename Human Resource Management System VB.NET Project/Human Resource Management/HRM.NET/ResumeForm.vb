Option Strict Off
Option Explicit On
Friend Class ResumeForm
	Inherits System.Windows.Forms.Form
	Dim MemIDVar, RNoVar As Object
	Dim VNoVar As Integer
	Dim OpVar As Object
	Dim NameVar As String
	Private Sub Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button.Click
		Dim Index As Short = Button.GetIndex(eventSender)
		Select Case Index
			Case 0
                ClearTxtControls(Me, Module1.CtrlType.TextBox)
				If TempRS.State = 1 Then TempRS.Close()
				TempRS.Open("select max(RNo) from Resume", Conn)


                RNoVar = IIf(IsDBNull(TempRS.Fields(0).Value), 1, TempRS.Fields(0).Value) + 1
				Text1.Focus()
				Button(0).Enabled = False
				Button(1).Enabled = True
			Case 1
				If Text1.Text = "" Then
					MsgBox("Please enter the Name")
					Text1.Focus()
					Exit Sub
				Else
					NameVar = Text1.Text
					opt()
                    If TempRS.State = 1 Then TempRS.Close()
                    StrSql = "insert into Resume(RNo,RName,PName,Add1,Add2,Add3,Pin,phone,EMail,gender,DOB,Lang,Ed,Ex) values(" & Val(RNoVar) & ",'" & UCase(NameVar) & "','" & UCase(Text2.Text) & "', '" & Text3.Text & "' , '" & Text4.Text & "', '" & Text5.Text & "', '" & Text6.Text & "', '" & Text7.Text & "', '" & Text8.Text & "','" & OpVar & "','" & DateFormat(DOB) & "','" & Text9.Text & "','" & Combo1.Text & "'," & Val(Text10.Text) & ")"
                    Conn.Execute(StrSql)
                    MsgBox("Resume Uploaded Successfully!!!", MsgBoxStyle.Information)
					Button(0).Enabled = True
					Button(1).Enabled = False
					Button(0).Focus()
				End If
				NameDis()
			Case 2
				If Text1.Text = "" Then
					MsgBox("Please enter the Name")
					Text1.Focus()
					Exit Sub
				Else
					opt()
                    Conn.Execute("update Resume set PName= '" & UCase(Text2.Text) & "',Add1= '" & Text3.Text & "',Add2= '" & Text4.Text & "',Add3= '" & Text5.Text & "',Pin= '" & Text6.Text & "',Phone= '" & Text7.Text & "',EMail= '" & Text8.Text & "',Gender='" & OpVar & "' ,DOB='" & DateFormat(DOB) & "',Lang=' " & Text9.Text & "',Ed=' " & Combo1.Text & "',Ex=" & Val(Text10.Text) & " where RName='" & Text1.Text & "'")

                    NameDis()
					Button(0).Enabled = True
					Button(1).Enabled = False
					Button(2).Enabled = False
					Button(3).Enabled = False
				End If
			Case 3
                If MsgBoxResult.No = MsgBox(" Do you want delete record ", MsgBoxStyle.YesNo) Then Exit Sub
				Conn.Execute("delete from resume where RName='" & Text1.Text & "'")
				NameDis()
				ClearTxtControls(Me, Module1.CtrlType.TextBox)
				MSF.set_TextMatrix(MSF.Row, 0, "")
				Button(0).Enabled = True
				Button(1).Enabled = False
				Button(2).Enabled = False
				Button(3).Enabled = False
			Case 4
				Me.Close()
				
		End Select
	End Sub
	Sub MSFInit()
		MSF.Clear()
		MSF.set_ColWidth(0, 2000)
		MSF.set_TextMatrix(0, 0, "Name")
	End Sub
	Private Sub DOB_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DOB.DropDown
		Text9.Focus()
	End Sub
	Private Sub DOB_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComCtl2.DDTPickerEvents_KeyPressEvent) Handles DOB.KeyPressEvent
		If eventArgs.KeyAscii = 13 Then
			Text9.Focus()
		End If
	End Sub
	Private Sub DOB_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DOB.Leave
		Text9.Focus()
	End Sub
	Private Sub ResumeForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(9285)
		Me.Height = VB6.TwipsToPixelsY(6975)
		Me.Left = VB6.TwipsToPixelsX(100)
		Me.Top = VB6.TwipsToPixelsY(100)
		MSFInit()
		NameDis()
        If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select Cname from MasEd order by cName")
		Combo1.Items.Clear()
		Do While Not TempRS.EOF
			Combo1.Items.Add((TempRS.Fields(0).Value))
			TempRS.MoveNext()
		Loop 
    End Sub
	Private Sub MSF_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.DblClick
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select * from Resume where RName='" & MSF.get_TextMatrix(MSF.Row, 0) & "'", Conn)
		If Not TempRS.EOF Then
			Text1.Text = TempRS.Fields(1).Value & ""
			Text2.Text = TempRS.Fields(2).Value & ""
			Text3.Text = TempRS.Fields(3).Value & ""
			Text4.Text = TempRS.Fields(4).Value & ""
			Text5.Text = TempRS.Fields(5).Value & ""
			Text6.Text = TempRS.Fields(6).Value & ""
			Text7.Text = TempRS.Fields(7).Value & ""
			Text8.Text = TempRS.Fields(8).Value & ""
			If TempRS.Fields(9).Value = "Male" Then
				Option1.Checked = True
			Else
				Option2.Checked = True
			End If
			DOB._Value = TempRS.Fields(10).Value
			Text9.Text = TempRS.Fields(11).Value & ""
			Combo1.Text = TempRS.Fields(12).Value & ""
			Text10.Text = TempRS.Fields(13).Value & ""
		End If
		Button(0).Enabled = False
		Button(1).Enabled = False
		Button(2).Enabled = True
		Button(3).Enabled = True
	End Sub
	Private Sub Text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Text2.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.Leave
		Text1.Text = UCase(Text1.Text)
	End Sub
	Private Sub Text2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Text3.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text2.Leave
		Text2.Text = UCase(Text2.Text)
	End Sub
	Private Sub Text3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text3.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Text4.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text4.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Text5.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text5_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text5.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Text6.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub Text6_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text6.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Text7.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
    End Sub

    Private Sub Text7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Text7.KeyDown
        checknumericval(e)
    End Sub
	Private Sub Text7_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text7.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Text8.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text8_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text8.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			DOB.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text9_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text9.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			If Button(1).Enabled = True Then
				Button(1).Focus()
			End If
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Text9_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text9.Leave
		Text9.Text = UCase(Text9.Text)
	End Sub
	Sub NameDis()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select RName from Resume ", Conn)
		K = 1
		Do While Not TempRS.EOF
			MSF.set_TextMatrix(K, 0, TempRS.Fields(0).Value)
			TempRS.MoveNext()
			K = K + 1
		Loop 
	End Sub
	Sub opt()
		If Option1.Checked = True Then

			OpVar = "Male"
		Else

			OpVar = "Female"
		End If
	End Sub

   
    Private Sub Text7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text7.TextChanged

    End Sub
End Class