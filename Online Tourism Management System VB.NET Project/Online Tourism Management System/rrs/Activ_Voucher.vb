'Name developer: baskar.ch
'Dt:17/07/06
'Purpose :
'Version :1
Imports System.Data.oledb
Public Class Activ_Voucher
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
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents txtsignedby As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirmedby As System.Windows.Forms.TextBox
    Friend WithEvents txtpickpoint As System.Windows.Forms.TextBox
    Friend WithEvents dtppicktime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpactvoucdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtactvoucno As System.Windows.Forms.TextBox
    Friend WithEvents cobactbookid As System.Windows.Forms.ComboBox
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtbookingid As System.Windows.Forms.TextBox
    Friend WithEvents cmdserch As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents cobactvnoview As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_go As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grbsearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmd_ccan As System.Windows.Forms.Button
    Friend WithEvents cmd_cup As System.Windows.Forms.Button
    Friend WithEvents cmdcustidgo As System.Windows.Forms.Button
    Friend WithEvents txtcustidsearch As System.Windows.Forms.TextBox
    Friend WithEvents dbgsearch As System.Windows.Forms.DataGrid
    Friend WithEvents cmddatego As System.Windows.Forms.Button
    Friend WithEvents dtpsearchto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpsearchfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Activ_Voucher))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cmd_go = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.cobactvnoview = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grbsearch = New System.Windows.Forms.GroupBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.cmd_ccan = New System.Windows.Forms.Button
        Me.cmd_cup = New System.Windows.Forms.Button
        Me.cmdcustidgo = New System.Windows.Forms.Button
        Me.txtcustidsearch = New System.Windows.Forms.TextBox
        Me.dbgsearch = New System.Windows.Forms.DataGrid
        Me.cmddatego = New System.Windows.Forms.Button
        Me.dtpsearchto = New System.Windows.Forms.DateTimePicker
        Me.dtpsearchfrom = New System.Windows.Forms.DateTimePicker
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtsignedby = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtconfirmedby = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtpickpoint = New System.Windows.Forms.TextBox
        Me.dtppicktime = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.dtpactvoucdt = New System.Windows.Forms.DateTimePicker
        Me.txtactvoucno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cobactbookid = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcustomer = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdserch = New System.Windows.Forms.Button
        Me.txtbookingid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.grbsearch.SuspendLayout()
        CType(Me.dbgsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(544, 384)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmd_go)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Controls.Add(Me.cobactvnoview)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(536, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'cmd_go
        '
        Me.cmd_go.Location = New System.Drawing.Point(440, 88)
        Me.cmd_go.Name = "cmd_go"
        Me.cmd_go.Size = New System.Drawing.Size(32, 24)
        Me.cmd_go.TabIndex = 13
        Me.cmd_go.Text = "Go"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(322, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker1.TabIndex = 12
        Me.DateTimePicker1.Value = New Date(2006, 7, 21, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(266, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "To Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(78, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "From Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(164, 88)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowCheckBox = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker2.TabIndex = 9
        Me.DateTimePicker2.Value = New Date(2006, 7, 21, 0, 0, 0, 0)
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 160)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(520, 160)
        Me.dbgview.TabIndex = 8
        '
        'cobactvnoview
        '
        Me.cobactvnoview.Location = New System.Drawing.Point(248, 40)
        Me.cobactvnoview.Name = "cobactvnoview"
        Me.cobactvnoview.Size = New System.Drawing.Size(120, 21)
        Me.cobactvnoview.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(168, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Activity Id "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grbsearch)
        Me.TabPage2.Controls.Add(Me.txtsignedby)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtconfirmedby)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtpickpoint)
        Me.TabPage2.Controls.Add(Me.dtppicktime)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.dbg)
        Me.TabPage2.Controls.Add(Me.dtpactvoucdt)
        Me.TabPage2.Controls.Add(Me.txtactvoucno)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(536, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'grbsearch
        '
        Me.grbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbsearch.Controls.Add(Me.Label26)
        Me.grbsearch.Controls.Add(Me.cmd_ccan)
        Me.grbsearch.Controls.Add(Me.cmd_cup)
        Me.grbsearch.Controls.Add(Me.cmdcustidgo)
        Me.grbsearch.Controls.Add(Me.txtcustidsearch)
        Me.grbsearch.Controls.Add(Me.dbgsearch)
        Me.grbsearch.Controls.Add(Me.cmddatego)
        Me.grbsearch.Controls.Add(Me.dtpsearchto)
        Me.grbsearch.Controls.Add(Me.dtpsearchfrom)
        Me.grbsearch.Controls.Add(Me.Label25)
        Me.grbsearch.Controls.Add(Me.Label24)
        Me.grbsearch.Location = New System.Drawing.Point(16, 109)
        Me.grbsearch.Name = "grbsearch"
        Me.grbsearch.Size = New System.Drawing.Size(504, 224)
        Me.grbsearch.TabIndex = 99
        Me.grbsearch.TabStop = False
        Me.grbsearch.Text = "Search"
        Me.grbsearch.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(160, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 13)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Customer Id"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_ccan
        '
        Me.cmd_ccan.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ccan.Location = New System.Drawing.Point(296, 200)
        Me.cmd_ccan.Name = "cmd_ccan"
        Me.cmd_ccan.Size = New System.Drawing.Size(56, 23)
        Me.cmd_ccan.TabIndex = 9
        Me.cmd_ccan.Text = "Cancel"
        '
        'cmd_cup
        '
        Me.cmd_cup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cup.Location = New System.Drawing.Point(168, 200)
        Me.cmd_cup.Name = "cmd_cup"
        Me.cmd_cup.Size = New System.Drawing.Size(64, 23)
        Me.cmd_cup.TabIndex = 8
        Me.cmd_cup.Text = "Update"
        '
        'cmdcustidgo
        '
        Me.cmdcustidgo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcustidgo.Location = New System.Drawing.Point(336, 56)
        Me.cmdcustidgo.Name = "cmdcustidgo"
        Me.cmdcustidgo.Size = New System.Drawing.Size(32, 23)
        Me.cmdcustidgo.TabIndex = 7
        Me.cmdcustidgo.Text = "Go"
        '
        'txtcustidsearch
        '
        Me.txtcustidsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustidsearch.Location = New System.Drawing.Point(248, 56)
        Me.txtcustidsearch.Name = "txtcustidsearch"
        Me.txtcustidsearch.Size = New System.Drawing.Size(80, 21)
        Me.txtcustidsearch.TabIndex = 1
        '
        'dbgsearch
        '
        Me.dbgsearch.CaptionVisible = False
        Me.dbgsearch.DataMember = ""
        Me.dbgsearch.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgsearch.Location = New System.Drawing.Point(16, 80)
        Me.dbgsearch.Name = "dbgsearch"
        Me.dbgsearch.Size = New System.Drawing.Size(480, 112)
        Me.dbgsearch.TabIndex = 5
        '
        'cmddatego
        '
        Me.cmddatego.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddatego.Location = New System.Drawing.Point(352, 16)
        Me.cmddatego.Name = "cmddatego"
        Me.cmddatego.Size = New System.Drawing.Size(32, 23)
        Me.cmddatego.TabIndex = 4
        Me.cmddatego.Text = "Go"
        '
        'dtpsearchto
        '
        Me.dtpsearchto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsearchto.Location = New System.Drawing.Point(240, 16)
        Me.dtpsearchto.Name = "dtpsearchto"
        Me.dtpsearchto.Size = New System.Drawing.Size(96, 21)
        Me.dtpsearchto.TabIndex = 3
        '
        'dtpsearchfrom
        '
        Me.dtpsearchfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsearchfrom.Location = New System.Drawing.Point(88, 16)
        Me.dtpsearchfrom.Name = "dtpsearchfrom"
        Me.dtpsearchfrom.Size = New System.Drawing.Size(96, 21)
        Me.dtpsearchfrom.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(184, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "To Date"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "From Date"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsignedby
        '
        Me.txtsignedby.Location = New System.Drawing.Point(416, 320)
        Me.txtsignedby.Name = "txtsignedby"
        Me.txtsignedby.Size = New System.Drawing.Size(104, 21)
        Me.txtsignedby.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Signed By"
        '
        'txtconfirmedby
        '
        Me.txtconfirmedby.Location = New System.Drawing.Point(152, 288)
        Me.txtconfirmedby.Name = "txtconfirmedby"
        Me.txtconfirmedby.Size = New System.Drawing.Size(104, 21)
        Me.txtconfirmedby.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Confirmed By"
        '
        'txtpickpoint
        '
        Me.txtpickpoint.Location = New System.Drawing.Point(416, 256)
        Me.txtpickpoint.Name = "txtpickpoint"
        Me.txtpickpoint.Size = New System.Drawing.Size(104, 21)
        Me.txtpickpoint.TabIndex = 9
        '
        'dtppicktime
        '
        Me.dtppicktime.CustomFormat = "HH:mm"
        Me.dtppicktime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtppicktime.Location = New System.Drawing.Point(152, 256)
        Me.dtppicktime.Name = "dtppicktime"
        Me.dtppicktime.ShowUpDown = True
        Me.dtppicktime.Size = New System.Drawing.Size(104, 21)
        Me.dtppicktime.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pickup Point"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Pickup Time"
        '
        'dbg
        '
        Me.dbg.CaptionVisible = False
        Me.dbg.DataMember = ""
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(8, 96)
        Me.dbg.Name = "dbg"
        Me.dbg.ReadOnly = True
        Me.dbg.Size = New System.Drawing.Size(520, 104)
        Me.dbg.TabIndex = 5
        '
        'dtpactvoucdt
        '
        Me.dtpactvoucdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpactvoucdt.Location = New System.Drawing.Point(416, 224)
        Me.dtpactvoucdt.Name = "dtpactvoucdt"
        Me.dtpactvoucdt.ShowCheckBox = True
        Me.dtpactvoucdt.Size = New System.Drawing.Size(104, 21)
        Me.dtpactvoucdt.TabIndex = 4
        '
        'txtactvoucno
        '
        Me.txtactvoucno.BackColor = System.Drawing.Color.Gainsboro
        Me.txtactvoucno.Location = New System.Drawing.Point(152, 224)
        Me.txtactvoucno.Name = "txtactvoucno"
        Me.txtactvoucno.Size = New System.Drawing.Size(104, 21)
        Me.txtactvoucno.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Activity Voucher Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Activity Voucher No *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cobactbookid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcustomer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdserch)
        Me.GroupBox1.Controls.Add(Me.txtbookingid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activity Booking ID"
        '
        'cobactbookid
        '
        Me.cobactbookid.Location = New System.Drawing.Point(400, 24)
        Me.cobactbookid.Name = "cobactbookid"
        Me.cobactbookid.Size = New System.Drawing.Size(120, 21)
        Me.cobactbookid.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Activity booking Id *"
        '
        'txtcustomer
        '
        Me.txtcustomer.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcustomer.Location = New System.Drawing.Point(104, 56)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(96, 21)
        Me.txtcustomer.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer *"
        '
        'cmdserch
        '
        Me.cmdserch.Location = New System.Drawing.Point(208, 24)
        Me.cmdserch.Name = "cmdserch"
        Me.cmdserch.Size = New System.Drawing.Size(64, 24)
        Me.cmdserch.TabIndex = 2
        Me.cmdserch.Text = "Search"
        '
        'txtbookingid
        '
        Me.txtbookingid.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbookingid.Location = New System.Drawing.Point(104, 24)
        Me.txtbookingid.Name = "txtbookingid"
        Me.txtbookingid.Size = New System.Drawing.Size(96, 21)
        Me.txtbookingid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking Id *"
        '
        'Activ_Voucher
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(544, 381)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Activ_Voucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity Voucher"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.grbsearch.ResumeLayout(False)
        Me.grbsearch.PerformLayout()
        CType(Me.dbgsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim frmstatus As EnuRecstatus
    Private Sub Activ_Voucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form  Load()
        TabControl1.SelectedTab = TabPage2
        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()
        ' enabling the controls after form load
        txtbookingid.ReadOnly = True  ''''' sriram  txtbookingid.ReadOnly = True
        txtactvoucno.ReadOnly = True
        txtbookingid.ReadOnly = True
        txtconfirmedby.ReadOnly = True
        txtcustomer.ReadOnly = True
        txtpickpoint.ReadOnly = True
        txtsignedby.ReadOnly = True
        
    End Sub
    'it clears the all controls in the form
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

    End Sub
    'It enables the enables the input controls to insert data
    Public Sub newproc()
        Try
            frmstatus = Module1.EnuRecstatus.Recnew  'form status as new mode
            clearproc() 'clears the controls
            txtbookingid.Focus()
            txtbookingid.ReadOnly = False   ''''' sriram  txtbookingid.ReadOnly = false
            txtactvoucno.ReadOnly = True
            txtbookingid.ReadOnly = False
            txtconfirmedby.ReadOnly = False
            txtcustomer.ReadOnly = False
            txtpickpoint.ReadOnly = False
            txtsignedby.ReadOnly = False
            dtpactvoucdt.Checked = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Prjtitle)
        End Try
    End Sub
   
   

    'it searches the record basing on booking ids
    Private Sub cmdserch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdserch.Click
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        If txtbookingid.Text = "" Then
            grbsearch.Visible = True
            cmd_cup.Enabled = False
        Else
            'showing all cust names with the name given in textbox
            Dim str As String
            str = "%" + txtbookingid.Text + "%"
            da = New OleDbDataAdapter("select BookingId,CustId,Itina_Type,bkdate,agentid,EnteredDt from booking_itinary where BookingId like '" & str & "'", con)
            da.Fill(ds, "search_bookingid")
            dbgsearch.DataSource = ds.Tables("search_bookingid")
            'dbgsearch.DataMember = "search"
            grbsearch.Visible = True
            cmd_cup.Enabled = True
            da.Dispose()
        End If
    End Sub
    'it doesnt allows any values in the combobox
    Private Sub cobactbookid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobactbookid.KeyPress
        combo(e)
    End Sub
    'it fills the datagrid on the entry form basing on activity booking id
    Private Sub cobactbookid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobactbookid.SelectedIndexChanged

        Dim ds1 As New DataSet
        Dim str As String
        Try
            Dim da1 As New OleDbDataAdapter("select * from Cust_Activity where ABookId=" & cobactbookid.Text & "", con)
            str = "select * from Cust_Activity where ABookId=" & cobactbookid.Text & ""
            da1.Fill(ds1, "cust_activity")
            dbg.DataSource = ds1.Tables("cust_activity")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Prjtitle)
        End Try
    End Sub
    'this procedure inserts a new record  or update an existing record
    Public Sub saveproc()
        Dim sysrefno, chk1, chk2 As Integer

        Dim cmd1, cmd, cmd4, cmd5 As OleDbCommand
        Try

            'actvo = dtpactvoucdt.Value.ToShortDateString
            'pic = dtppicktime.Value.ToShortDateString
            If IsDBNull(dbg.Item(0, 0)) = True Then
                dbg.Item(0, 0) = "null"
            Else
                dbg.Item(0, 0) = dbg.Item(0, 0)
            End If
            If IsDBNull(dbg.Item(0, 3)) = True Then
                dbg.Item(0, 3) = "null"
            Else
                dbg.Item(0, 3) = dbg.Item(0, 3)
            End If
            If IsDBNull(dbg.Item(0, 4)) = True Then
                dbg.Item(0, 4) = "null"
            Else
                dbg.Item(0, 4) = dbg.Item(0, 4)
            End If
            If IsDBNull(dbg.Item(0, 5)) = True Then
                dbg.Item(0, 5) = "null"
            Else
                dbg.Item(0, 5) = dbg.Item(0, 5)
            End If
            If IsDBNull(dbg.Item(0, 6)) = True Then
                dbg.Item(0, 6) = "null"
            Else
                dbg.Item(0, 6) = dbg.Item(0, 6)
            End If
            If IsDBNull(dbg.Item(0, 7)) = True Then
                dbg.Item(0, 7) = "null"
            Else
                dbg.Item(0, 7) = dbg.Item(0, 7)
            End If
            If IsDBNull(dbg.Item(0, 8)) = True Then
                chk1 = 1
            Else
                dbg.Item(0, 8) = dbg.Item(0, 8)
            End If
            If IsDBNull(dbg.Item(0, 9)) = True Then
                dbg.Item(0, 9) = "null"
            Else
                dbg.Item(0, 9) = dbg.Item(0, 9)
            End If
            If IsDBNull(dbg.Item(0, 10)) = True Then
                dbg.Item(0, 10) = "null"
            Else
                dbg.Item(0, 10) = dbg.Item(0, 10)
            End If
            If IsDBNull(dbg.Item(0, 11)) = True Then
                dbg.Item(0, 11) = "null"
            Else
                dbg.Item(0, 11) = dbg.Item(0, 11)
            End If
            If IsDBNull(dbg.Item(0, 12)) = True Then
                dbg.Item(0, 12) = "null"
            Else
                dbg.Item(0, 12) = dbg.Item(0, 12)
            End If
            If IsDBNull(dbg.Item(0, 13)) = True Then
                dbg.Item(0, 13) = "null"
            Else
                dbg.Item(0, 13) = dbg.Item(0, 13)
            End If
            If IsDBNull(dbg.Item(0, 14)) = True Then
                dbg.Item(0, 14) = "null"
            Else
                dbg.Item(0, 14) = dbg.Item(0, 14)
            End If
            If IsDBNull(dbg.Item(0, 15)) = True Then
                dbg.Item(0, 15) = "null"
            Else
                dbg.Item(0, 15) = dbg.Item(0, 15)
            End If

            If IsDBNull(dbg.Item(0, 16)) = True Then
                dbg.Item(0, 16) = "null"
            Else
                dbg.Item(0, 16) = dbg.Item(0, 16)
            End If
            If IsDBNull(dbg.Item(0, 17)) = True Then
                dbg.Item(0, 17) = "null"
            Else
                dbg.Item(0, 17) = dbg.Item(0, 17)
            End If
            If IsDBNull(dbg.Item(0, 18)) = True Then
                chk2 = 1
            Else
                dbg.Item(0, 18) = dbg.Item(0, 18)
            End If
            If IsDBNull(dbg.Item(0, 20)) = True Then
                dbg.Item(0, 20) = "null"
            Else
                dbg.Item(0, 20) = dbg.Item(0, 20)
            End If

            If con.State <> ConnectionState.Open Then
                Openconnection()
            End If
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                cmd4 = New OleDb.OleDbCommand("select count(*) from Activ_Voucher", con)
                sysrefno = cmd4.ExecuteScalar
                cmd4.Dispose()
                If sysrefno >= 1 Then
                    ' retrieving tansaction id 
                    cmd5 = New OleDb.OleDbCommand("select max(ActVouNo) from Activ_Voucher ", con)
                    sysrefno = cmd5.ExecuteScalar
                    cmd5.Dispose()
                End If
                ' incrementing transaction id
                sysrefno = sysrefno + 1
                txtactvoucno.Text = sysrefno
                ' str = "insert into Activity_Voucher values(" & txtactvoucno.Text & "," & IIf(dtpfd.Checked = False, "null", "'" & dtpfd.Text & "'") & ",'" & txtbookingid.Text & "','" & IIf(dbg.Item(0, 3) = "", 0, dbg.Item(0, 3)) & "','" & IIf(dbg.Item(0, 4) = "", 0, dbg.Item(0, 4)) & "','" & IIf(dbg.Item(0, 5) = "", 0, dbg.Item(0, 5)) & "','" & IIf(dbg.Item(0, 6) = "", 0, dbg.Item(0, 6)) & "','" & IIf(dbg.Item(0, 7) = "", 0, dbg.Item(0, 7)) & "','" & IIf(dbg.Item(0, 8) = "", 0, dbg.Item(0, 8)) & "','" & IIf(dbg.Item(0, 9) = "", 0, dbg.Item(0, 9)) & "','" & IIf(dbg.Item(0, 10) = "", 0, dbg.Item(0, 10)) & "'," & IIf(dtppicktime.Checked = False, "null", "'" & dtppicktime.Text & "'") & ",'" & IIf(txtpickpoint.Text = "", 0, txtpickpoint.Text) & "','" & IIf(txtconfirmedby.Text = "", 0, txtconfirmedby.Text) & "','" & IIf(txtsignedby.Text = "", 0, txtsignedby.Text) & "','" & IIf(dbg.Item(0, 16) = "", 0, dbg.Item(0, 16)) & "','" & IIf(dbg.Item(0, 17) = "", 0, dbg.Item(0, 17)) & "','" & IIf(dbg.Item(0, 18) = "", 0, dbg.Item(0, 18)) & "')"
                cmd = New OleDbCommand("insert into Activ_Voucher values(" & txtactvoucno.Text & "," & IIf(dtpactvoucdt.Checked = False, "null", "'" & dtpactvoucdt.Text & "'") & ",'" & txtbookingid.Text & "'," & dbg.Item(0, 0) & ",'" & dbg.Item(0, 3) & "'," & dbg.Item(0, 4) & "," & dbg.Item(0, 5) & "," & dbg.Item(0, 6) & "," & dbg.Item(0, 7) & "," & IIf(chk1 = 1, "null", "'" & dbg.Item(0, 8) & "'") & ",'" & dbg.Item(0, 9) & "','" & dbg.Item(0, 10) & "'," & IIf(dtppicktime.Checked = False, "null", "'" & dtppicktime.Text & "'") & ",'" & IIf(txtpickpoint.Text = "", 0, txtpickpoint.Text) & "','" & IIf(txtconfirmedby.Text = "", 0, txtconfirmedby.Text) & "','" & IIf(txtsignedby.Text = "", 0, txtsignedby.Text) & "','" & dbg.Item(0, 16) & "','" & dbg.Item(0, 17) & "'," & IIf(chk2 = 1, "null", "'" & dbg.Item(0, 18) & "'") & ",'" & dbg.Item(0, 20) & "')", con)
                cmd.ExecuteNonQuery()

                cmd1 = New OleDbCommand("insert into Activ_VouAmt values(" & txtactvoucno.Text & ",'" & txtbookingid.Text & "','" & dbg.Item(0, 3) & "'," & dbg.Item(0, 4) & "," & dbg.Item(0, 5) & "," & dbg.Item(0, 6) & "," & dbg.Item(0, 7) & "," & IIf(chk1 = 1, "null", "'" & dbg.Item(0, 8) & "'") & ",'" & dbg.Item(0, 9) & "','" & dbg.Item(0, 10) & "'," & dbg.Item(0, 11) & "," & dbg.Item(0, 12) & "," & dbg.Item(0, 13) & "," & dbg.Item(0, 14) & ",'" & dbg.Item(0, 15) & "','Y','" & dbg.Item(0, 17) & "'," & IIf(chk2 = 1, "null", "'" & dbg.Item(0, 18) & "'") & ",'" & dbg.Item(0, 20) & "')", con)
                cmd1.ExecuteNonQuery()

                'cmd2 = New OleDbCommand("insert into Act_VouBookvalues(" & txtactvoucno.Text & "," & txtactvoucno.Text & "," & IIf(dtpactvoucdt.Checked = False, "null", "'" & dtpactvoucdt.Text & "'") & ",'" & txtbookingid.Text & "'," & dbg.Item(0, 0) & ",'" & dbg.Item(0, 3) & "'," & dbg.Item(0, 4) & "," & dbg.Item(0, 5) & "," & dbg.Item(0, 6) & "," & dbg.Item(0, 7) & "," & IIf(chk1 = 1, "null", "'" & dbg.Item(0, 8) & "'") & ",'" & dbg.Item(0, 9) & "','" & dbg.Item(0, 10) & "'," & dbg.Item(0, 11) & "," & dbg.Item(0, 12) & "," & dbg.Item(0, 13) & "," & dbg.Item(0, 14) & ",'" & dbg.Item(0, 15) & "','" & dbg.Item(0, 17) & "'," & IIf(chk2 = 1, "null", "'" & dbg.Item(0, 18) & "'") & ",'" & dbg.Item(0, 20) & "')", con)
                'cmd2.ExecuteNonQuery()

                cmd1.Dispose()
                cmd.Dispose()

            Else
                cmd = New OleDbCommand("update activ_voucher set ActVouDt=" & IIf(dtpactvoucdt.Checked = False, "null", "'" & dtpactvoucdt.Text & "'") & ",'" & txtbookingid.Text & "',BookingId='" & txtbookingid.Text & "',Activ_ID='" & dbg.Item(0, 3) & "',Noof_Pax=" & dbg.Item(0, 4) & ",Adults=" & dbg.Item(0, 5) & ",Junior=" & dbg.Item(0, 6) & ",Children=" & dbg.Item(0, 7) & ",Acti_Date=" & IIf(chk1 = 1, "null", "'" & dbg.Item(0, 8) & "'") & ",Rate_Type='" & dbg.Item(0, 9) & "',Unit='" & dbg.Item(0, 10) & "',Pickuptime=" & IIf(dtppicktime.Checked = False, "null", "'" & dtppicktime.Text & "'") & ",Pickuppoint='" & IIf(txtpickpoint.Text = "", 0, txtpickpoint.Text) & "',confirmedby='" & IIf(txtconfirmedby.Text = "", 0, txtconfirmedby.Text) & "',Signedby='" & IIf(txtsignedby.Text = "", 0, txtsignedby.Text) & "',Comments='" & dbg.Item(0, 16) & "',Userid='" & dbg.Item(0, 17) & "',EnteredDt=" & IIf(chk2 = 1, "null", "'" & dbg.Item(0, 18) & "'") & ",PackageId='" & dbg.Item(0, 20) & "' where ActVouNo=" & txtactvoucno.Text & ")", con)
            End If
            MsgSav()
            'clears the controls
            clearproc()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Prjtitle)
        Finally
            con.Close()
        End Try
    End Sub
    'after change the tab page combobox filled wth activity voucher numbers
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "View" Then
            combofill(cobactvnoview, "select ActVouNo from activ_voucher")
        End If
    End Sub
    'it fills the data in datagrid in view page basing on activity voucher numbers
    Private Sub cobactbidview_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobactvnoview.SelectedIndexChanged

       
        Dim dsv As New DataSet

        Try
            Dim dav As New OleDbDataAdapter("select * from activ_voucher where ActVouNo=" & cobactvnoview.Text & "", con)
            'str = "select * from Cust_Activity where ABookId=" & cobactbidview.Text & ""
            dav.Fill(dsv, "activ_voucher")
            dbgview.DataSource = dsv.Tables("activ_voucher")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Prjtitle)
        End Try

    End Sub
    'it allows to enter numbers and text only
    Private Sub txtbookingid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbookingid.KeyPress
        textandnumbers(e)
    End Sub
    'it allows to enter text only
    Private Sub txtconfirmedby_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconfirmedby.KeyPress
        textonly(e)
    End Sub
    'it allows to enter text only
    Private Sub txtpickpoint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpickpoint.KeyPress
        textonly(e)
    End Sub
    'it allows to enter text only
    Private Sub txtsignedby_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsignedby.KeyPress
        textonly(e)
    End Sub
  
    
    Private Sub cmd_ccan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ccan.Click
        grbsearch.Visible = False
    End Sub

    
    Private Sub cmd_cup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cup.Click
        'it fills the form controls  on the entry form

        Dim i As Byte
        i = dbgview.CurrentRowIndex
        txtbookingid.Text = dbgview.Item(i, 0)
        txtcustomer.Text = dbgview.Item(i, 1)
        grbsearch.Visible = False
        combofill(cobactbookid, "select * from cust_activity where bookingid='" & txtbookingid.Text & "'")

    End Sub

    
    Private Sub cmdcustidgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcustidgo.Click
        'it searches the records on selected criteria

        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim str As String
        str = "%" + txtcustidsearch.Text + "%"        '''''  sriram  str = "%" + txt_scid.Text + "%"
        da = New OleDbDataAdapter("select BookingId,CustId,Itina_Type,bkdate,agentid,EnteredDt from booking_itinary where custId like '" & str & "'", con)
        da.Fill(ds, "search_custid")

        dbgsearch.DataSource = ds.Tables("search_custid")
        da.Dispose()
        cmd_cup.Enabled = True   'update button
    End Sub
    ' for view tab.
    Private Sub cmd_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_go.Click
        'it searches the records on selected criteria for viewing ( view tab)

        Dim da As OleDbDataAdapter
        Dim ds As New DataSet

        If DateTimePicker2.Checked = True Then
            da = New OleDbDataAdapter("select BookingId,CustId,Itina_Type,bkdate,agentid,EnteredDt from booking_itinary where entereddt between #" & DateTimePicker2.Text & "# and #" & DateTimePicker1.Text & "#", con)
            da.Fill(ds, "search_date")

            dbgview.DataSource = ds.Tables("search_date")
            da.Dispose()
        Else
            MsgBox("Select dates", MsgBoxStyle.OkOnly, Prjtitle)
        End If

        cmd_cup.Enabled = True
    End Sub

    Private Sub cmddatego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddatego.Click
        'searching based on dates     

        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        If dtpsearchfrom.Value > dtpsearchto.Value Then
            MsgBox("From Date Must Be Less Than To Date", MsgBoxStyle.OkOnly, Prjtitle)
            dtpsearchto.Focus()
            Exit Sub
        End If
        da = New OleDbDataAdapter("select BookingId,CustId,Itina_Type,bkdate,agentid,EnteredDt from booking_itinary where entereddt between #" & dtpsearchfrom.Text & "# and #" & dtpsearchto.Text & "#", con)
        da.Fill(ds, "search_date")
        dbgsearch.DataSource = ds.Tables("search_date")
        da.Dispose()
        cmd_cup.Enabled = True

    End Sub
End Class
