'Name developer: Emma Christeena.B
'Dt:29/07/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class Activity
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cobunit As System.Windows.Forms.ComboBox
    Friend WithEvents cobloc As System.Windows.Forms.ComboBox
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents txtact As System.Windows.Forms.TextBox
    Friend WithEvents cobratetype As System.Windows.Forms.ComboBox
    Friend WithEvents txtactcode As System.Windows.Forms.TextBox
    Friend WithEvents cobactpro As System.Windows.Forms.ComboBox
    Friend WithEvents tabpage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents Grprate As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtcorpchild As System.Windows.Forms.TextBox
    Friend WithEvents txtcorpjunior As System.Windows.Forms.TextBox
    Friend WithEvents txtcorpadult As System.Windows.Forms.TextBox
    Friend WithEvents txtrackjunior As System.Windows.Forms.TextBox
    Friend WithEvents txtrackadult As System.Windows.Forms.TextBox
    Friend WithEvents txtrackchild As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Activity))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabpage1 = New System.Windows.Forms.TabPage
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Grprate = New System.Windows.Forms.GroupBox
        Me.txtcorpchild = New System.Windows.Forms.TextBox
        Me.txtcorpjunior = New System.Windows.Forms.TextBox
        Me.txtcorpadult = New System.Windows.Forms.TextBox
        Me.txtrackchild = New System.Windows.Forms.TextBox
        Me.txtrackjunior = New System.Windows.Forms.TextBox
        Me.txtrackadult = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cobunit = New System.Windows.Forms.ComboBox
        Me.cobloc = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdes = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtact = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cobratetype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtactcode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cobactpro = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tabpage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Grprate.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpage1)
        Me.TabControl1.Controls.Add(Me.tabpage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(536, 336)
        Me.TabControl1.TabIndex = 0
        '
        'tabpage1
        '
        Me.tabpage1.Controls.Add(Me.dbgview)
        Me.tabpage1.Location = New System.Drawing.Point(4, 22)
        Me.tabpage1.Name = "tabpage1"
        Me.tabpage1.Size = New System.Drawing.Size(528, 310)
        Me.tabpage1.TabIndex = 0
        Me.tabpage1.Text = "View"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.Dock = System.Windows.Forms.DockStyle.Top
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(0, 0)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.Size = New System.Drawing.Size(528, 288)
        Me.dbgview.TabIndex = 0
        '
        'tabpage2
        '
        Me.tabpage2.Controls.Add(Me.GroupBox1)
        Me.tabpage2.Location = New System.Drawing.Point(4, 22)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Size = New System.Drawing.Size(528, 310)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "Entry / Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Grprate)
        Me.GroupBox1.Controls.Add(Me.cobunit)
        Me.GroupBox1.Controls.Add(Me.cobloc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtact)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cobratetype)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtactcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cobactpro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 304)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Grprate
        '
        Me.Grprate.Controls.Add(Me.txtcorpchild)
        Me.Grprate.Controls.Add(Me.txtcorpjunior)
        Me.Grprate.Controls.Add(Me.txtcorpadult)
        Me.Grprate.Controls.Add(Me.txtrackchild)
        Me.Grprate.Controls.Add(Me.txtrackjunior)
        Me.Grprate.Controls.Add(Me.txtrackadult)
        Me.Grprate.Controls.Add(Me.Label16)
        Me.Grprate.Controls.Add(Me.Label15)
        Me.Grprate.Controls.Add(Me.Label14)
        Me.Grprate.Controls.Add(Me.Label13)
        Me.Grprate.Controls.Add(Me.Label12)
        Me.Grprate.Controls.Add(Me.Label11)
        Me.Grprate.Controls.Add(Me.Label10)
        Me.Grprate.Controls.Add(Me.Label9)
        Me.Grprate.Location = New System.Drawing.Point(8, 120)
        Me.Grprate.Name = "Grprate"
        Me.Grprate.Size = New System.Drawing.Size(496, 128)
        Me.Grprate.TabIndex = 7
        Me.Grprate.TabStop = False
        '
        'txtcorpchild
        '
        Me.txtcorpchild.Location = New System.Drawing.Point(360, 96)
        Me.txtcorpchild.MaxLength = 8
        Me.txtcorpchild.Name = "txtcorpchild"
        Me.txtcorpchild.Size = New System.Drawing.Size(80, 21)
        Me.txtcorpchild.TabIndex = 13
        '
        'txtcorpjunior
        '
        Me.txtcorpjunior.Location = New System.Drawing.Point(360, 64)
        Me.txtcorpjunior.MaxLength = 8
        Me.txtcorpjunior.Name = "txtcorpjunior"
        Me.txtcorpjunior.Size = New System.Drawing.Size(80, 21)
        Me.txtcorpjunior.TabIndex = 12
        '
        'txtcorpadult
        '
        Me.txtcorpadult.Location = New System.Drawing.Point(360, 32)
        Me.txtcorpadult.MaxLength = 8
        Me.txtcorpadult.Name = "txtcorpadult"
        Me.txtcorpadult.Size = New System.Drawing.Size(80, 21)
        Me.txtcorpadult.TabIndex = 11
        '
        'txtrackchild
        '
        Me.txtrackchild.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrackchild.Location = New System.Drawing.Point(88, 96)
        Me.txtrackchild.MaxLength = 8
        Me.txtrackchild.Name = "txtrackchild"
        Me.txtrackchild.Size = New System.Drawing.Size(80, 21)
        Me.txtrackchild.TabIndex = 10
        '
        'txtrackjunior
        '
        Me.txtrackjunior.Location = New System.Drawing.Point(88, 64)
        Me.txtrackjunior.MaxLength = 8
        Me.txtrackjunior.Name = "txtrackjunior"
        Me.txtrackjunior.Size = New System.Drawing.Size(80, 21)
        Me.txtrackjunior.TabIndex = 9
        '
        'txtrackadult
        '
        Me.txtrackadult.Location = New System.Drawing.Point(88, 36)
        Me.txtrackadult.MaxLength = 8
        Me.txtrackadult.Name = "txtrackadult"
        Me.txtrackadult.Size = New System.Drawing.Size(80, 21)
        Me.txtrackadult.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(312, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Child"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(312, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Junior"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(312, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Adult *"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(288, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Activity Corporate Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Child"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(40, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Junior"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Adult *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Activity Rack Rate "
        '
        'cobunit
        '
        Me.cobunit.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cobunit.Location = New System.Drawing.Point(360, 80)
        Me.cobunit.Name = "cobunit"
        Me.cobunit.Size = New System.Drawing.Size(56, 21)
        Me.cobunit.TabIndex = 6
        '
        'cobloc
        '
        Me.cobloc.Location = New System.Drawing.Point(360, 48)
        Me.cobloc.Name = "cobloc"
        Me.cobloc.Size = New System.Drawing.Size(144, 21)
        Me.cobloc.Sorted = True
        Me.cobloc.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Location"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "No of Hours or days"
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(104, 256)
        Me.txtdes.MaxLength = 50
        Me.txtdes.Multiline = True
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(368, 40)
        Me.txtdes.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Description"
        '
        'txtact
        '
        Me.txtact.Location = New System.Drawing.Point(120, 48)
        Me.txtact.MaxLength = 25
        Me.txtact.Name = "txtact"
        Me.txtact.Size = New System.Drawing.Size(136, 21)
        Me.txtact.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Activity *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Unit *"
        '
        'cobratetype
        '
        Me.cobratetype.Items.AddRange(New Object() {"Day", "Hour"})
        Me.cobratetype.Location = New System.Drawing.Point(120, 80)
        Me.cobratetype.Name = "cobratetype"
        Me.cobratetype.Size = New System.Drawing.Size(136, 21)
        Me.cobratetype.Sorted = True
        Me.cobratetype.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rate Type *"
        '
        'txtactcode
        '
        Me.txtactcode.Location = New System.Drawing.Point(360, 16)
        Me.txtactcode.MaxLength = 5
        Me.txtactcode.Name = "txtactcode"
        Me.txtactcode.Size = New System.Drawing.Size(144, 21)
        Me.txtactcode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Activity Code *"
        '
        'cobactpro
        '
        Me.cobactpro.Location = New System.Drawing.Point(120, 16)
        Me.cobactpro.Name = "cobactpro"
        Me.cobactpro.Size = New System.Drawing.Size(136, 21)
        Me.cobactpro.Sorted = True
        Me.cobactpro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activity Provider *"
        '
        'Activity
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(536, 341)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Activity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity Configuration"
        Me.TabControl1.ResumeLayout(False)
        Me.tabpage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Grprate.ResumeLayout(False)
        Me.Grprate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim bolvali As Boolean ' to chk validations r correct or not
    Dim recmode As EnuRecstatus '  To findout record status
    Private Sub Activity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form Load()

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'opens entry/edit page on pageload
        TabControl1.SelectedTab = tabpage2
        '------below code brings data from location master, activity provider tables and fill in the combo boxe------'
        combofill1(cobloc, "select * from LocationMaster")
        combofill1(cobactpro, "select * from Activity_Provider")
        ' locks the controls
        lock()

    End Sub
    Public Sub lock()
        cobactpro.Enabled = False
        txtact.ReadOnly = True
        txtactcode.ReadOnly = True
        cobloc.Enabled = False
        cobratetype.Enabled = False
        cobunit.Enabled = False
        txtrackadult.ReadOnly = True
        txtrackjunior.ReadOnly = True
        txtrackchild.ReadOnly = True
        txtcorpadult.ReadOnly = True
        txtcorpjunior.ReadOnly = True
        txtcorpchild.ReadOnly = True
        txtdes.ReadOnly = True
    End Sub
    '  this procedure clears the all text boxes and combo boxes
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.Grprate.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    'this procedure checks the form status and set it to new mode
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        clearproc()
        ' unlocks the controls
        cobactpro.Enabled = True
        txtact.ReadOnly = False
        txtactcode.ReadOnly = False
        cobloc.Enabled = True
        cobratetype.Enabled = True
        cobunit.Enabled = True
        txtrackadult.ReadOnly = False
        txtrackjunior.ReadOnly = False
        txtrackchild.ReadOnly = False
        txtcorpadult.ReadOnly = False
        txtcorpjunior.ReadOnly = False
        txtcorpchild.ReadOnly = False
        txtdes.ReadOnly = False
        'cursor gets into activity provider combobox
        TabControl1.SelectedTab = tabpage2
        cobactpro.Focus()
    End Sub
    'To save or update a record 
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        'locks the controls
        txtactcode.ReadOnly = True
        cobactpro.Enabled = False
        'unlocks the controls
        txtact.ReadOnly = False
        cobloc.Enabled = True
        cobratetype.Enabled = True
        cobunit.Enabled = True
        txtrackadult.ReadOnly = False
        txtrackjunior.ReadOnly = False
        txtrackchild.ReadOnly = False
        txtcorpadult.ReadOnly = False
        txtcorpjunior.ReadOnly = False
        txtcorpchild.ReadOnly = False
        txtdes.ReadOnly = False
    End Sub
    Public Sub valid()

        bolvali = False
        If cobactpro.Text = "" Then
            MsgBox(" Enter activity provider Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobactpro.Focus()
            Exit Sub
        End If
        If txtactcode.Text = "" Then
            MsgBox(" Enter activity code", MsgBoxStyle.OKOnly, Prjtitle)
            txtactcode.Focus()
            Exit Sub
        End If
        If txtact.Text = "" Then
            MsgBox(" Enter activity", MsgBoxStyle.OKOnly, Prjtitle)
            txtact.Focus()
            Exit Sub
        End If
        If cobratetype.Text = "" Then
            MsgBox(" Enter rate type", MsgBoxStyle.OKOnly, Prjtitle)
            cobratetype.Focus()
            Exit Sub
        End If
        If cobunit.Text = "" Then
            MsgBox(" Enter units", MsgBoxStyle.OKOnly, Prjtitle)
            cobunit.Focus()
            Exit Sub
        End If
        bolvali = True
    End Sub
    Public Sub saveproc()
        valid()
        If bolvali = False Then Exit Sub
        Dim str1, str2 As String
        'saves data before the "-" activity provider  combobox
        str1 = cobactpro.Text
        str2 = (str1.Substring(0, str1.IndexOf("-")))
        Dim b, c As String
        b = cobloc.Text
        c = (b.Substring(0, b.IndexOf("-")))
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Activity where Activ_ID='" & cobactpro.Text & "' ", con)
                p = cmd.ExecuteScalar
                cmd.Dispose()
                If p <> 0 Then
                    MsgBox("Record  already exists", MsgBoxStyle.OKOnly, Prjtitle)
                Else
                    cmd = New OleDbCommand("insert into Activity values('" & txtactcode.Text & "','" & txtact.Text & "','" & str2 & "','" & c & "','" & cobratetype.Text & "','" & cobunit.Text & "','" & txtrackadult.Text & "','" & IIf(txtrackjunior.Text = "", 0, txtrackjunior.Text) & "','" & IIf(txtrackchild.Text = "", 0, txtrackchild.Text) & "','" & txtcorpadult.Text & "','" & IIf(txtcorpjunior.Text = "", 0, txtcorpjunior.Text) & "','" & IIf(txtcorpchild.Text = "", 0, txtcorpchild.Text) & "','" & txtdes.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    'Displays the updated message in messagebox
                    MsgSav()
                    'clears the controls
                    clearproc()
                    ' locks the controls
                    lock()
                End If
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd = New OleDbCommand("update Activity set Activity='" & txtact.Text & "',Activ_ProvId='" & str2 & "',LocationID='" & c & "',Rate_Type='" & cobratetype.Text & "',Unit='" & cobunit.Text & "',RackRate_Adult='" & txtrackadult.Text & "',RackRate_Juni='" & IIf(txtrackjunior.Text = "", 0, txtrackjunior.Text) & "',RackRate_Child='" & IIf(txtrackchild.Text = "", 0, txtrackchild.Text) & "',CorpRate_Adult='" & txtcorpadult.Text & "',CorpRate_Juni='" & IIf(txtcorpjunior.Text = "", 0, txtcorpjunior.Text) & "',CorpRate_Child='" & IIf(txtcorpchild.Text = "", 0, txtcorpchild.Text) & "',Descript='" & txtdes.Text & "' where Activ_ID='" & txtactcode.Text & "'", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'Displays the updated message in messagebox
                MsgSav()
                'clears the controls
                clearproc()
                ' locks the controls
                lock()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'deletes the particular record
    Public Sub delproc()
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "delete from Activity where Activ_ID='" & txtactcode.Text & "'"
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Displays record deleted message in messagebox
            MsgDel()
            'clears the controls
            clearproc()
            ' locks the controls
            lock()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim da As New OleDbDataAdapter("select * from Activity", con)
        ds.Clear()
        If TabControl1.SelectedTab.Text = "View" Then
            da.Fill(ds, "activity")
            dbgview.DataSource = ds.Tables("activity")
        End If
    End Sub
    Private Sub dbgview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim str, a As String
        Dim int As Integer
        Dim dr As OleDb.OleDbDataReader
        ' locks the controls
        lock()
        'fills the current row index number in int
        int = dbgview.CurrentRowIndex
        'fills the value of row in str
        str = dbgview.Item(int, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from Activity where Activ_ID='" & str & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            a = dr(2)
            comboselet(cobactpro, a)
            txtactcode.Text = dr(0)
            txtact.Text = dr(1)
            Dim b As String
            b = dr(3)
            comboselet(cobloc, b)
            cobratetype.Text = dr(4)
            cobunit.Text = dr(5)
            txtrackadult.Text = dr(6)
            txtrackjunior.Text = dr(7)
            txtrackchild.Text = dr(8)
            txtcorpadult.Text = dr(9)
            txtcorpjunior.Text = dr(10)
            txtcorpchild.Text = dr(11)
            txtdes.Text = dr(12)
            'displays on entry/edit tabpage
            TabControl1.SelectedTab = tabpage2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()

    End Sub
    'makes first letter in textbox as capital letter
    Private Sub txtdes_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdes.Leave
        firstcap(txtdes)
    End Sub
    'makes first letter in textbox as capital letter
    Private Sub txtact_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtact.Leave
        firstcap(txtact)
    End Sub
    'makes first letter in textbox as capital letter
    Private Sub txtactcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtactcode.Leave
        firstcap(txtactcode)
    End Sub
    Private Sub txtactcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtactcode.KeyPress
        'allows to enter both text and numbers
        textandnumbers(e)
    End Sub
    Private Sub cobactpro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobactpro.KeyPress
        combo(e)
    End Sub
    Private Sub cobloc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobloc.KeyPress
        combo(e)
    End Sub
    Private Sub cobratetype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobratetype.KeyPress
        combo(e)
    End Sub
    Private Sub cobunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobunit.KeyPress
        combo(e)
    End Sub
    Private Sub txtact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtact.KeyPress
        ''allows to enter text only 
        textonly(e)
    End Sub
    Private Sub txtcorpadult_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorpadult.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub

    Private Sub txtcorpchild_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorpchild.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub

    Private Sub txtcorpjunior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorpjunior.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub
    Private Sub txtrackadult_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrackadult.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub
    Private Sub txtrackchild_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrackchild.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub
    Private Sub txtrackjunior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrackjunior.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
