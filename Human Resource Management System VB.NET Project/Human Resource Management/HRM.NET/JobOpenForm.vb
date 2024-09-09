Option Strict Off
Option Explicit On
Friend Class JobOpenForm
	Inherits System.Windows.Forms.Form
    Dim Num As Integer
    Private Sub Button_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Button.Click
        Dim Index As Short = Button.GetIndex(eventSender)
        Select Case Index
            Case 0
                Num = 1
                ClearTxtControls(Me, Module1.CtrlType.TextBox)
                Button(1).Enabled = True
                Button(0).Enabled = False
                Button(2).Enabled = False
                Button(3).Enabled = False
            Case 1
                On Error GoTo r
                If TempRS.State = 1 Then TempRS.Close()
                TempRS.Open("select * from jobopen where rno=" & Text1.Text & "", Conn)
                If TempRS.EOF = True Then
                    StrSql = "insert into JobOpen(Rno,jTitle,NoPost,ed,Noyear) values "
                    StrSql = StrSql & " (" & Text1.Text & ",'" & Text2.Text & "'," & Text3.Text & ",'" & Text4.Text & "'," & Text5.Text & ")"
                    Conn.Execute(StrSql)
                    Button(1).Enabled = False
                    Button(0).Enabled = True
                    DisRec()
                    MsgBox("Entry Saved!!", MsgBoxStyle.Information)
                    ClearTxtControls(Me, Module1.CtrlType.TextBox)
                Else
                    MsgBox("This JobNo is already present please check")
                End If
                Exit Sub
r:
                MsgBox("Error in value Entered", MsgBoxStyle.Critical, "Error in Insert")

            Case 2
                On Error GoTo k
                If MsgBoxResult.Yes = MsgBox("Do you want to Modify this Record", MsgBoxStyle.YesNo) Then
                    Conn.Execute("update jobOpen set jtitle='" & Text2.Text & "',NoPost=" & Val(Text3.Text) & ",ed='" & Text4.Text & "',noyear=" & Val(Text5.Text) & " where rNo=" & AppNo & "")
                    DisRec()
                End If
                Exit Sub
k:
                MsgBox("Error in Entry!!", MsgBoxStyle.Critical, "Error")
            Case 3

                If MsgBoxResult.Yes = MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo) Then
                    Conn.Execute("delete from  jobOpen where rno=" & AppNo & "")
                    DisRec()
                End If

            Case 4
                Me.Close()

        End Select

    End Sub
	
	Private Sub Command1_Click()
		Dim MSF1 As Object
        MSF1.TextMatrix(Num, 0) = Num
        MSF1.TextMatrix(Num, 1) = Text2.Text
		MSF1.TextMatrix(Num, 2) = Text3.Text
		MSF1.TextMatrix(Num, 3) = Text4.Text
		MSF1.TextMatrix(Num, 4) = Text5.Text
		Num = Num + 1
        ClearTxtControls(Me, Module1.CtrlType.TextBox)
	End Sub
	
	Private Sub JobOpenForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Width = VB6.TwipsToPixelsX(10230)
		Me.Height = VB6.TwipsToPixelsY(6975)
		Me.Left = VB6.TwipsToPixelsX(100)
		Me.Top = VB6.TwipsToPixelsY(100)
		DisRec()
		DisRecEd()
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
		TempRS.Open("select jtitle,rno from jobOpen order by jTitle")
		MSFInit()
		I = 1
		Do While Not TempRS.EOF
			MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)
			MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)
			I = I + 1
			TempRS.MoveNext()
		Loop 
    End Sub
	
	Sub DisRecEd()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select cName from MasEd ")
        Text4.Items.Clear()
		Do While Not TempRS.EOF
			Text4.Items.Add(TempRS.Fields(0).Value)
			TempRS.MoveNext()
		Loop 
		
	End Sub
	Private Sub MSF_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.DblClick
		Dim LblName As Object
		Dim LblNo As Object
		If MSF.get_TextMatrix(MSF.Row, 0) = "" Then Exit Sub
		LblNo = MSF.get_TextMatrix(MSF.Row, 1)
		AppNo = CInt(MSF.get_TextMatrix(MSF.Row, 1))
		LblName = MSF.get_TextMatrix(MSF.Row, 0)
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select * from jobOpen where rno=" & AppNo & " ", Conn)
		Text1.Text = TempRS.Fields(0).Value
		Text2.Text = TempRS.Fields(1).Value
		Text3.Text = TempRS.Fields(2).Value
		Text4.Text = TempRS.Fields(3).Value
		Text5.Text = TempRS.Fields(4).Value
        Button(1).Enabled = False
        Button(2).Enabled = True
        Button(3).Enabled = True
        Button(0).Enabled = True
	End Sub

   
End Class