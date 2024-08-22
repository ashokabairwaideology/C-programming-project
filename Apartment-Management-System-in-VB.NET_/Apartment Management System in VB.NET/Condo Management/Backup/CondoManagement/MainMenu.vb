Public Class MainMenu
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainMenu))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem8, Me.MenuItem11})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem1.Text = "File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem2.Text = "Open"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Customer"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Room"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "Transactions"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "AboutCondo management"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "Exit"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem10})
        Me.MenuItem8.Text = "Administration"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Login"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "Calculator"
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(744, 42)
        Me.ToolBar1.TabIndex = 1
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "Customer"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Text = "Rooms"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.Text = "Transaction"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 3
        Me.ToolBarButton4.Text = "Exit"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem13})
        Me.MenuItem11.Text = "Reports"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "Customer report"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Text = "Transaction report"
        '
        'MainMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 446)
        Me.Controls.Add(Me.ToolBar1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MainMenu"
        Me.Text = "Condo Management System version 1.1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim cust As New CustomerForm
        cust.MdiParent = Me
        cust.Show()

    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainMenu_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            Dim dialog As New DialogResult
            dialog = MessageBox.Show("Are You Sure You want to Exit " + "  " + Me.Text + " ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (dialog = DialogResult.Yes) Then
                '
                'Log the event
                '

                '
                'End of Log
                '
                Application.Exit()
            Else
                e.Cancel = True
            End If
        Catch EX As System.Exception

            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button.Text = "Customer" Then
            Dim cust As New CustomerForm
            cust.MdiParent = Me
            cust.Show()
        End If
        If e.Button.Text = "Rooms" Then

            Dim room As New RoomForm
            room.MdiParent = Me
            room.Show()
        End If

        If e.Button.Text = "Transaction" Then
            Dim trans As New RoomTransaction
            trans.MdiParent = Me
            trans.Show()
        End If

        If e.Button.Text = "Exit" Then
            Try
                Dim dialog As New DialogResult
                dialog = MessageBox.Show("Are You Sure You want to Exit " + "  " + Me.Text + " ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If (dialog = DialogResult.Yes) Then
                    '
                    'Log the event
                    '

                    '
                    'End of Log
                    '
                    Application.Exit()
                Else
                    Exit Sub
                End If
            Catch EX As System.Exception

                MsgBox(EX.Message)
            End Try
        End If


     




    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim room As New RoomForm
        room.MdiParent = Me
        room.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim trans As New RoomTransaction
        trans.MdiParent = Me
        trans.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim log As New LoginTable
        log.MdiParent = Me
        log.Show()

    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim rep1 As New CustomerReport
        rep1.MdiParent = Me
        rep1.Show()

    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Dim rep2 As New TransactionReport
        rep2.MdiParent = Me
        rep2.Show()

    End Sub
End Class
