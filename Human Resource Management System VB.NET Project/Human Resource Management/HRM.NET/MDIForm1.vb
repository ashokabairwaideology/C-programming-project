Option Strict Off
Option Explicit On
Friend Class MDIForm1
	Inherits System.Windows.Forms.Form
	Dim DbPath As Object
	Dim GetConn As String
	
	
	Public Sub BrMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BrMenu.Click
        'MasBrForm.Show()
        Form1.Show()
	End Sub
	
	Public Sub CouMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CouMenu.Click
		MasEdForm.Show()
	End Sub
	
	Private Sub EducationMenu_Click()
		EdForm.Show()
	End Sub
	
	Public Sub edDetMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles edDetMenu.Click
		EdForm.Show()
	End Sub
	
	Public Sub empTrainMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles empTrainMenu.Click
		TrainingForm.Show()
	End Sub
	
	Public Sub ExDetMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ExDetMenu.Click
		ExpForm.Show()
	End Sub
	
	Public Sub ExitMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ExitMenu.Click
		End
		
	End Sub
	
	Private Sub ExperienceMenu_Click()
		ExpForm.Show()
	End Sub
	
    Public Sub IntViewLetMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub
	
	Public Sub IntViewMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles IntViewMenu.Click

	End Sub
	
	Public Sub JobOpeningsMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles JobOpeningsMenu.Click
		JobOpenForm.Show()
	End Sub
	
	Private Sub MDIForm1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        LoginForm1.Hide()
    End Sub
	
	Private Sub PgMenu_Click()
		MasPgForm.Show()
	End Sub
	
	Public Sub RecruitMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RecruitMenu.Click
		RecruitForm.Show()
	End Sub
	
	Public Sub ResDetMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ResDetMenu.Click
		ResumeForm.Show()
	End Sub
	
	Public Sub ResMatMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ResMatMenu.Click
		MatchForm.Show()
	End Sub
	
	Public Sub skillMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles skillMenu.Click
		MasSkillForm.Show()
	End Sub
	
	Private Sub SkillsMenu_Click()
		SkillForm.Show()
	End Sub
	
	Public Sub TrainSelMenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TrainSelMenu.Click
		TrainingSelForm.Show()
	End Sub
	
	Public Sub TrainyTestmenu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TrainyTestmenu.Click
        TrainytestForm.Show()
	End Sub

    Private Sub _SBar_Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SBar_Panel2.Click

    End Sub

    Private Sub SBar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles SBar.ItemClicked

    End Sub

    Private Sub EmployeeDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailToolStripMenuItem.Click
        empdetail.show()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsToolStripMenuItem.Click
        Payment.Show()
    End Sub

    Private Sub InterviewDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterviewDetailsToolStripMenuItem.Click
        IntViewForm.Show()
    End Sub

    Private Sub InterViewLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterViewLetterToolStripMenuItem.Click
        IntViewLetForm.Show()
    End Sub

 
    Private Sub MasterMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterMenu.Click

    End Sub
End Class