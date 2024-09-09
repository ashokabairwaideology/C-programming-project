Option Strict Off
Option Explicit On
Friend Class TrainingSelForm
	Inherits System.Windows.Forms.Form
	Dim N1, Num, YVar, R1 As Object
	Dim RVar As Integer
	Dim EdVar As Object
	Dim JName As String
	
	
	
	Private Sub ButClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ButClose.Click
		Me.Close()
	End Sub
	
    Private Sub butPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub
	
	Private Sub butSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles butSave.Click
		If Combo1.Text = "" Then
			MsgBox("Please select the Training Name ")
			Exit Sub
        End If
        'Conn.Execute("update trainingSel set let='y'")
		For I = 1 To RVar
            If Not MSF1.get_TextMatrix(I, 0) = "" Then
                StrSql = "insert into trainingSel(batchNo,empNo,eName,job,tName,FromDate,toDate) values('" & Text2.Text & "'," & MSF1.get_TextMatrix(I, 1) & ",'" & MSF1.get_TextMatrix(I, 2) & "','" & MSF1.get_TextMatrix(I, 3) & "','" & Combo1.Text & "','" & DateFormat(Fromdate) & "','" & DateFormat(toDate) & "')"
                Conn.Execute(StrSql)
            End If
        Next
        MsgBox("Training batch is saved!!!", MsgBoxStyle.Information)
        'butPrint.Enabled = True
	End Sub
    Private Sub TrainingSelForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Width = VB6.TwipsToPixelsX(10230)
        Me.Height = VB6.TwipsToPixelsY(6975)
        Me.Left = VB6.TwipsToPixelsX(100)
        Me.Top = VB6.TwipsToPixelsY(100)
        DisRec()
        RVar = 1
       
        If TempRS.State = 1 Then TempRS.Close()
        TempRS.Open("select tName from Training order by tName")
        Combo1.Items.Clear()
        Do While Not TempRS.EOF
            Combo1.Items.Add((TempRS.Fields(0).Value))
            TempRS.MoveNext()
        Loop
        MSF1Init()

    End Sub
	
	Sub MSFInit()
		MSF.Clear()
		MSF.set_ColWidth(0, 600)
		MSF.set_ColWidth(1, 1600)
		MSF.set_ColWidth(2, 1000)
		MSF.set_ColWidth(3, 1200)
		MSF.set_ColWidth(4, 1000)
		MSF.set_TextMatrix(0, 0, "Emp No")
		MSF.set_TextMatrix(0, 1, "Name")
		MSF.set_TextMatrix(0, 2, "Job")
	End Sub
	Sub MSF1Init()
		MSF1.Clear()
		MSF1.set_ColWidth(0, 600)
		MSF1.set_ColWidth(1, 600)
		MSF1.set_ColWidth(2, 1200)
		MSF1.set_ColWidth(3, 1200)
		MSF1.set_ColWidth(4, 1000)
		MSF1.set_TextMatrix(0, 0, "SlNo")
		MSF1.set_TextMatrix(0, 1, "Emp No")
		MSF1.set_TextMatrix(0, 2, "Name")
		MSF1.set_TextMatrix(0, 3, "Job")
		MSF1.set_TextMatrix(0, 4, "program")
	End Sub
	Sub DisRec()
		If TempRS.State = 1 Then TempRS.Close()
		TempRS.Open("select empNo,eName,Job from Employee order by eName")
		MSFInit()

		I = 1
		Do While Not TempRS.EOF

			MSF.set_TextMatrix(I, 0, TempRS.Fields(0).Value)

			MSF.set_TextMatrix(I, 1, TempRS.Fields(1).Value)

			MSF.set_TextMatrix(I, 2, TempRS.Fields(2).Value)

			I = I + 1
			TempRS.MoveNext()
		Loop 
		
	End Sub
	
	Private Sub MSF_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSF.DblClick
		If MSF.get_TextMatrix(MSF.Row, 0) = "" Then Exit Sub
        MSF1.set_TextMatrix(RVar, 0, RVar)
		MSF1.set_TextMatrix(RVar, 1, MSF.get_TextMatrix(MSF.Row, 0))
		MSF1.set_TextMatrix(RVar, 2, MSF.get_TextMatrix(MSF.Row, 1))
		MSF1.set_TextMatrix(RVar, 3, MSF.get_TextMatrix(MSF.Row, 2))
		MSF1.set_TextMatrix(RVar, 4, Combo1.Text)
		RVar = RVar + 1
	End Sub

    Private Sub MSF_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSF.Enter

    End Sub

    Private Sub Fromdate_CallbackKeyDown(ByVal sender As System.Object, ByVal e As AxMSComCtl2.DDTPickerEvents_CallbackKeyDownEvent) Handles Fromdate.CallbackKeyDown

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TrainigPrint.Show()
    End Sub
End Class