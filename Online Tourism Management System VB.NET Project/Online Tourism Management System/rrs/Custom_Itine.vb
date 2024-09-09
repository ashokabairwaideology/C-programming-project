'written by P.R.Sudhakar Reddy
'Version 1
'date: 19 july 2006
Public Class Custom_Itine
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
    Friend WithEvents TabView As System.Windows.Forms.TabPage
    Friend WithEvents TabEntry As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabHotel As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TabVeh As System.Windows.Forms.TabPage
    Friend WithEvents Tabflight As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents TabActiv As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents dtpsd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtped As System.Windows.Forms.DateTimePicker
    Friend WithEvents lst1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cob_status As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_search As System.Windows.Forms.Button
    Friend WithEvents txt_cust As System.Windows.Forms.TextBox
    Friend WithEvents txt_aname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_cup As System.Windows.Forms.Button
    Friend WithEvents cmd_ccan As System.Windows.Forms.Button
    Friend WithEvents cmd_go As System.Windows.Forms.Button
    Friend WithEvents dtp_rd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_rmks As System.Windows.Forms.TextBox
    Friend WithEvents txt_ramt As System.Windows.Forms.TextBox
    Friend WithEvents txt_details As System.Windows.Forms.TextBox
    Friend WithEvents cob_pay As System.Windows.Forms.ComboBox
    Friend WithEvents txt_bal As System.Windows.Forms.TextBox
    Friend WithEvents txt_ac As System.Windows.Forms.TextBox
    Friend WithEvents txt_pp As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_edic As System.Windows.Forms.TextBox
    Friend WithEvents txt_infants As System.Windows.Forms.TextBox
    Friend WithEvents txt_childs As System.Windows.Forms.TextBox
    Friend WithEvents txt_adults As System.Windows.Forms.TextBox
    Friend WithEvents txt_gname As System.Windows.Forms.TextBox
    Friend WithEvents dtptd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_cgo As System.Windows.Forms.Button
    Friend WithEvents txt_scid As System.Windows.Forms.TextBox
    Friend WithEvents cob_child As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cob_payment As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dtptime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_vupd As System.Windows.Forms.Button
    Friend WithEvents cmd_vcac As System.Windows.Forms.Button
    Friend WithEvents DataGrid5 As System.Windows.Forms.DataGrid
    Friend WithEvents cob_vtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents cob_vpayment As System.Windows.Forms.ComboBox
    Friend WithEvents cob_act As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGrid6 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid7 As System.Windows.Forms.DataGrid
    Friend WithEvents cmd_Acancel As System.Windows.Forms.Button
    Friend WithEvents cmd_AUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents cob_apayment As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_act As System.Windows.Forms.DateTimePicker
    Friend WithEvents cob_vstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_vsearch As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpvfd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpvtd As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid8 As System.Windows.Forms.DataGrid
    Friend WithEvents cmd_vOk As System.Windows.Forms.Button
    Friend WithEvents cmd_vcan As System.Windows.Forms.Button
    Friend WithEvents DataGrid9 As System.Windows.Forms.DataGrid
    Friend WithEvents txt_bid As System.Windows.Forms.TextBox
    Friend WithEvents cmd_eVehicle As System.Windows.Forms.Button
    Friend WithEvents cmd_eActivity As System.Windows.Forms.Button
    Friend WithEvents cmd_eflight As System.Windows.Forms.Button
    Friend WithEvents cmd_EHotel As System.Windows.Forms.Button
    Friend WithEvents cmd_Confirm As System.Windows.Forms.Button
    Friend WithEvents dtpbd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txt_Juniors As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Txt_cuid As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabView = New System.Windows.Forms.TabPage
        Me.cmd_Confirm = New System.Windows.Forms.Button
        Me.cmd_EHotel = New System.Windows.Forms.Button
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.cmd_vcan = New System.Windows.Forms.Button
        Me.cmd_vOk = New System.Windows.Forms.Button
        Me.DataGrid8 = New System.Windows.Forms.DataGrid
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpvtd = New System.Windows.Forms.DateTimePicker
        Me.dtpvfd = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_bid = New System.Windows.Forms.TextBox
        Me.cmd_vsearch = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.DataGrid9 = New System.Windows.Forms.DataGrid
        Me.cob_vstatus = New System.Windows.Forms.ComboBox
        Me.cmd_eActivity = New System.Windows.Forms.Button
        Me.cmd_eVehicle = New System.Windows.Forms.Button
        Me.cmd_eflight = New System.Windows.Forms.Button
        Me.TabEntry = New System.Windows.Forms.TabPage
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.dtp_rd = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_rmks = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.txt_ramt = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.txt_details = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.cob_pay = New System.Windows.Forms.ComboBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.txt_bal = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_ac = New System.Windows.Forms.TextBox
        Me.txt_pp = New System.Windows.Forms.TextBox
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_edic = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabHotel = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_scid = New System.Windows.Forms.TextBox
        Me.cmd_cgo = New System.Windows.Forms.Button
        Me.cmd_go = New System.Windows.Forms.Button
        Me.dtptd = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpfd = New System.Windows.Forms.DateTimePicker
        Me.cmd_ccan = New System.Windows.Forms.Button
        Me.cmd_cup = New System.Windows.Forms.Button
        Me.DataGrid4 = New System.Windows.Forms.DataGrid
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cob_payment = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cob_child = New System.Windows.Forms.ComboBox
        Me.lst1 = New System.Windows.Forms.ListBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TabVeh = New System.Windows.Forms.TabPage
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.cob_vpayment = New System.Windows.Forms.ComboBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cob_vtype = New System.Windows.Forms.ComboBox
        Me.DataGrid5 = New System.Windows.Forms.DataGrid
        Me.cmd_vcac = New System.Windows.Forms.Button
        Me.cmd_vupd = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.dtptime = New System.Windows.Forms.DateTimePicker
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.Tabflight = New System.Windows.Forms.TabPage
        Me.TabActiv = New System.Windows.Forms.TabPage
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.dtp_act = New System.Windows.Forms.DateTimePicker
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.cob_apayment = New System.Windows.Forms.ComboBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.cmd_Acancel = New System.Windows.Forms.Button
        Me.cmd_AUpdate = New System.Windows.Forms.Button
        Me.DataGrid7 = New System.Windows.Forms.DataGrid
        Me.DataGrid6 = New System.Windows.Forms.DataGrid
        Me.Label7 = New System.Windows.Forms.Label
        Me.cob_act = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Txt_cuid = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Txt_Juniors = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtpbd = New System.Windows.Forms.DateTimePicker
        Me.dtped = New System.Windows.Forms.DateTimePicker
        Me.dtpsd = New System.Windows.Forms.DateTimePicker
        Me.cob_status = New System.Windows.Forms.ComboBox
        Me.cmd_search = New System.Windows.Forms.Button
        Me.txt_cust = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_aname = New System.Windows.Forms.TextBox
        Me.txt_infants = New System.Windows.Forms.TextBox
        Me.txt_childs = New System.Windows.Forms.TextBox
        Me.txt_adults = New System.Windows.Forms.TextBox
        Me.txt_gname = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabView.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEntry.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabHotel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVeh.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabActiv.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DataGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabView)
        Me.TabControl1.Controls.Add(Me.TabEntry)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 504)
        Me.TabControl1.TabIndex = 1
        '
        'TabView
        '
        Me.TabView.Controls.Add(Me.cmd_Confirm)
        Me.TabView.Controls.Add(Me.cmd_EHotel)
        Me.TabView.Controls.Add(Me.GroupBox15)
        Me.TabView.Controls.Add(Me.Label16)
        Me.TabView.Controls.Add(Me.Label15)
        Me.TabView.Controls.Add(Me.dtpvtd)
        Me.TabView.Controls.Add(Me.dtpvfd)
        Me.TabView.Controls.Add(Me.Label14)
        Me.TabView.Controls.Add(Me.txt_bid)
        Me.TabView.Controls.Add(Me.cmd_vsearch)
        Me.TabView.Controls.Add(Me.Label13)
        Me.TabView.Controls.Add(Me.DataGrid9)
        Me.TabView.Controls.Add(Me.cob_vstatus)
        Me.TabView.Controls.Add(Me.cmd_eActivity)
        Me.TabView.Controls.Add(Me.cmd_eVehicle)
        Me.TabView.Controls.Add(Me.cmd_eflight)
        Me.TabView.Location = New System.Drawing.Point(4, 22)
        Me.TabView.Name = "TabView"
        Me.TabView.Size = New System.Drawing.Size(728, 478)
        Me.TabView.TabIndex = 0
        Me.TabView.Text = "View"
        '
        'cmd_Confirm
        '
        Me.cmd_Confirm.BackColor = System.Drawing.Color.LightPink
        Me.cmd_Confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Confirm.Location = New System.Drawing.Point(208, 440)
        Me.cmd_Confirm.Name = "cmd_Confirm"
        Me.cmd_Confirm.Size = New System.Drawing.Size(240, 40)
        Me.cmd_Confirm.TabIndex = 17
        Me.cmd_Confirm.Text = "Confirm the Quotation"
        Me.cmd_Confirm.UseVisualStyleBackColor = False
        Me.cmd_Confirm.Visible = False
        '
        'cmd_EHotel
        '
        Me.cmd_EHotel.BackColor = System.Drawing.SystemColors.Info
        Me.cmd_EHotel.Location = New System.Drawing.Point(56, 392)
        Me.cmd_EHotel.Name = "cmd_EHotel"
        Me.cmd_EHotel.Size = New System.Drawing.Size(88, 32)
        Me.cmd_EHotel.TabIndex = 11
        Me.cmd_EHotel.Text = "Edit Hotel"
        Me.cmd_EHotel.UseVisualStyleBackColor = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.cmd_vcan)
        Me.GroupBox15.Controls.Add(Me.cmd_vOk)
        Me.GroupBox15.Controls.Add(Me.DataGrid8)
        Me.GroupBox15.Location = New System.Drawing.Point(136, 152)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(368, 232)
        Me.GroupBox15.TabIndex = 9
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Visible = False
        '
        'cmd_vcan
        '
        Me.cmd_vcan.Location = New System.Drawing.Point(264, 200)
        Me.cmd_vcan.Name = "cmd_vcan"
        Me.cmd_vcan.Size = New System.Drawing.Size(64, 24)
        Me.cmd_vcan.TabIndex = 2
        Me.cmd_vcan.Text = "Cancel"
        '
        'cmd_vOk
        '
        Me.cmd_vOk.Location = New System.Drawing.Point(160, 200)
        Me.cmd_vOk.Name = "cmd_vOk"
        Me.cmd_vOk.Size = New System.Drawing.Size(64, 24)
        Me.cmd_vOk.TabIndex = 1
        Me.cmd_vOk.Text = "OK"
        '
        'DataGrid8
        '
        Me.DataGrid8.CaptionVisible = False
        Me.DataGrid8.DataMember = ""
        Me.DataGrid8.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid8.Location = New System.Drawing.Point(0, 8)
        Me.DataGrid8.Name = "DataGrid8"
        Me.DataGrid8.ReadOnly = True
        Me.DataGrid8.Size = New System.Drawing.Size(360, 176)
        Me.DataGrid8.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(120, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "From Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(336, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "To Date"
        '
        'dtpvtd
        '
        Me.dtpvtd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpvtd.Location = New System.Drawing.Point(384, 88)
        Me.dtpvtd.Name = "dtpvtd"
        Me.dtpvtd.Size = New System.Drawing.Size(96, 21)
        Me.dtpvtd.TabIndex = 6
        Me.dtpvtd.Value = New Date(2006, 8, 7, 0, 0, 0, 0)
        '
        'dtpvfd
        '
        Me.dtpvfd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpvfd.Location = New System.Drawing.Point(200, 88)
        Me.dtpvfd.Name = "dtpvfd"
        Me.dtpvfd.Size = New System.Drawing.Size(88, 21)
        Me.dtpvfd.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(128, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Booking Id"
        '
        'txt_bid
        '
        Me.txt_bid.Location = New System.Drawing.Point(200, 32)
        Me.txt_bid.Name = "txt_bid"
        Me.txt_bid.Size = New System.Drawing.Size(88, 21)
        Me.txt_bid.TabIndex = 3
        '
        'cmd_vsearch
        '
        Me.cmd_vsearch.Location = New System.Drawing.Point(280, 128)
        Me.cmd_vsearch.Name = "cmd_vsearch"
        Me.cmd_vsearch.Size = New System.Drawing.Size(72, 24)
        Me.cmd_vsearch.TabIndex = 2
        Me.cmd_vsearch.Text = "Search"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(336, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Status"
        '
        'DataGrid9
        '
        Me.DataGrid9.CaptionVisible = False
        Me.DataGrid9.DataMember = ""
        Me.DataGrid9.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid9.Location = New System.Drawing.Point(8, 168)
        Me.DataGrid9.Name = "DataGrid9"
        Me.DataGrid9.ReadOnly = True
        Me.DataGrid9.Size = New System.Drawing.Size(656, 168)
        Me.DataGrid9.TabIndex = 10
        '
        'cob_vstatus
        '
        Me.cob_vstatus.Items.AddRange(New Object() {"Quotation", "Confirm"})
        Me.cob_vstatus.Location = New System.Drawing.Point(384, 32)
        Me.cob_vstatus.Name = "cob_vstatus"
        Me.cob_vstatus.Size = New System.Drawing.Size(96, 21)
        Me.cob_vstatus.TabIndex = 0
        '
        'cmd_eActivity
        '
        Me.cmd_eActivity.BackColor = System.Drawing.SystemColors.Info
        Me.cmd_eActivity.Location = New System.Drawing.Point(512, 392)
        Me.cmd_eActivity.Name = "cmd_eActivity"
        Me.cmd_eActivity.Size = New System.Drawing.Size(88, 32)
        Me.cmd_eActivity.TabIndex = 13
        Me.cmd_eActivity.Text = "Edit Activity"
        Me.cmd_eActivity.UseVisualStyleBackColor = False
        '
        'cmd_eVehicle
        '
        Me.cmd_eVehicle.BackColor = System.Drawing.SystemColors.Info
        Me.cmd_eVehicle.Location = New System.Drawing.Point(360, 392)
        Me.cmd_eVehicle.Name = "cmd_eVehicle"
        Me.cmd_eVehicle.Size = New System.Drawing.Size(88, 32)
        Me.cmd_eVehicle.TabIndex = 12
        Me.cmd_eVehicle.Text = "Edit Vehicle"
        Me.cmd_eVehicle.UseVisualStyleBackColor = False
        '
        'cmd_eflight
        '
        Me.cmd_eflight.BackColor = System.Drawing.SystemColors.Info
        Me.cmd_eflight.Location = New System.Drawing.Point(208, 392)
        Me.cmd_eflight.Name = "cmd_eflight"
        Me.cmd_eflight.Size = New System.Drawing.Size(88, 32)
        Me.cmd_eflight.TabIndex = 16
        Me.cmd_eflight.Text = "Edit Flight"
        Me.cmd_eflight.UseVisualStyleBackColor = False
        '
        'TabEntry
        '
        Me.TabEntry.Controls.Add(Me.GroupBox10)
        Me.TabEntry.Controls.Add(Me.GroupBox3)
        Me.TabEntry.Controls.Add(Me.TabControl2)
        Me.TabEntry.Controls.Add(Me.GroupBox5)
        Me.TabEntry.Location = New System.Drawing.Point(4, 22)
        Me.TabEntry.Name = "TabEntry"
        Me.TabEntry.Size = New System.Drawing.Size(728, 478)
        Me.TabEntry.TabIndex = 1
        Me.TabEntry.Text = "Entry / Edit"
        Me.TabEntry.Visible = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.dtp_rd)
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Controls.Add(Me.txt_rmks)
        Me.GroupBox10.Controls.Add(Me.Label60)
        Me.GroupBox10.Controls.Add(Me.txt_ramt)
        Me.GroupBox10.Controls.Add(Me.Label62)
        Me.GroupBox10.Controls.Add(Me.txt_details)
        Me.GroupBox10.Controls.Add(Me.Label64)
        Me.GroupBox10.Controls.Add(Me.cob_pay)
        Me.GroupBox10.Controls.Add(Me.Label72)
        Me.GroupBox10.Controls.Add(Me.txt_bal)
        Me.GroupBox10.Controls.Add(Me.Label11)
        Me.GroupBox10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(0, 408)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(720, 64)
        Me.GroupBox10.TabIndex = 41
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Payment Details"
        '
        'dtp_rd
        '
        Me.dtp_rd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_rd.Location = New System.Drawing.Point(240, 40)
        Me.dtp_rd.Name = "dtp_rd"
        Me.dtp_rd.Size = New System.Drawing.Size(120, 21)
        Me.dtp_rd.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(192, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Date"
        '
        'txt_rmks
        '
        Me.txt_rmks.Location = New System.Drawing.Point(456, 16)
        Me.txt_rmks.Name = "txt_rmks"
        Me.txt_rmks.Size = New System.Drawing.Size(200, 21)
        Me.txt_rmks.TabIndex = 19
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(360, 16)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(48, 16)
        Me.Label60.TabIndex = 54
        Me.Label60.Text = "Remarks"
        '
        'txt_ramt
        '
        Me.txt_ramt.Location = New System.Drawing.Point(96, 40)
        Me.txt_ramt.Name = "txt_ramt"
        Me.txt_ramt.Size = New System.Drawing.Size(80, 21)
        Me.txt_ramt.TabIndex = 20
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(8, 40)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(93, 12)
        Me.Label62.TabIndex = 49
        Me.Label62.Text = "Received Amount"
        '
        'txt_details
        '
        Me.txt_details.Location = New System.Drawing.Point(240, 16)
        Me.txt_details.Name = "txt_details"
        Me.txt_details.Size = New System.Drawing.Size(104, 21)
        Me.txt_details.TabIndex = 18
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(192, 16)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(40, 16)
        Me.Label64.TabIndex = 45
        Me.Label64.Text = "Details"
        '
        'cob_pay
        '
        Me.cob_pay.Items.AddRange(New Object() {"Cash", "Credit Card", "Cheque", "DD"})
        Me.cob_pay.Location = New System.Drawing.Point(96, 16)
        Me.cob_pay.Name = "cob_pay"
        Me.cob_pay.Size = New System.Drawing.Size(72, 21)
        Me.cob_pay.TabIndex = 17
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(8, 16)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(88, 16)
        Me.Label72.TabIndex = 44
        Me.Label72.Text = "Mode of Payment"
        '
        'txt_bal
        '
        Me.txt_bal.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_bal.Location = New System.Drawing.Point(456, 40)
        Me.txt_bal.Name = "txt_bal"
        Me.txt_bal.ReadOnly = True
        Me.txt_bal.Size = New System.Drawing.Size(104, 21)
        Me.txt_bal.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(368, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Balance"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_ac)
        Me.GroupBox3.Controls.Add(Me.txt_pp)
        Me.GroupBox3.Controls.Add(Me.txt_total)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_edic)
        Me.GroupBox3.Controls.Add(Me.Label61)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 48)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Amount"
        '
        'txt_ac
        '
        Me.txt_ac.Location = New System.Drawing.Point(448, 16)
        Me.txt_ac.Name = "txt_ac"
        Me.txt_ac.Size = New System.Drawing.Size(32, 21)
        Me.txt_ac.TabIndex = 15
        '
        'txt_pp
        '
        Me.txt_pp.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_pp.Location = New System.Drawing.Point(216, 16)
        Me.txt_pp.Name = "txt_pp"
        Me.txt_pp.ReadOnly = True
        Me.txt_pp.Size = New System.Drawing.Size(88, 21)
        Me.txt_pp.TabIndex = 14
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_total.Location = New System.Drawing.Point(56, 16)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(72, 21)
        Me.txt_total.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Agent Commission %"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(144, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Per Person"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total"
        '
        'txt_edic
        '
        Me.txt_edic.Location = New System.Drawing.Point(592, 16)
        Me.txt_edic.Name = "txt_edic"
        Me.txt_edic.Size = New System.Drawing.Size(64, 21)
        Me.txt_edic.TabIndex = 16
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(488, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(96, 16)
        Me.Label61.TabIndex = 52
        Me.Label61.Text = "Extra Discount %"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabHotel)
        Me.TabControl2.Controls.Add(Me.TabVeh)
        Me.TabControl2.Controls.Add(Me.Tabflight)
        Me.TabControl2.Controls.Add(Me.TabActiv)
        Me.TabControl2.Location = New System.Drawing.Point(8, 104)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(720, 256)
        Me.TabControl2.TabIndex = 12
        '
        'TabHotel
        '
        Me.TabHotel.Controls.Add(Me.GroupBox1)
        Me.TabHotel.Controls.Add(Me.GroupBox2)
        Me.TabHotel.Controls.Add(Me.GroupBox6)
        Me.TabHotel.Controls.Add(Me.GroupBox4)
        Me.TabHotel.Controls.Add(Me.lst1)
        Me.TabHotel.Controls.Add(Me.DataGrid1)
        Me.TabHotel.Location = New System.Drawing.Point(4, 22)
        Me.TabHotel.Name = "TabHotel"
        Me.TabHotel.Size = New System.Drawing.Size(712, 230)
        Me.TabHotel.TabIndex = 0
        Me.TabHotel.Text = "Hotel Booking"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmd_cancel)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DataGrid3)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 168)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Location = New System.Drawing.Point(320, 136)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(72, 24)
        Me.cmd_cancel.TabIndex = 4
        Me.cmd_cancel.Text = "Cancel"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update"
        '
        'DataGrid3
        '
        Me.DataGrid3.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGrid3.CaptionVisible = False
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(0, 8)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.Size = New System.Drawing.Size(568, 120)
        Me.DataGrid3.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_scid)
        Me.GroupBox2.Controls.Add(Me.cmd_cgo)
        Me.GroupBox2.Controls.Add(Me.cmd_go)
        Me.GroupBox2.Controls.Add(Me.dtptd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpfd)
        Me.GroupBox2.Controls.Add(Me.cmd_ccan)
        Me.GroupBox2.Controls.Add(Me.cmd_cup)
        Me.GroupBox2.Controls.Add(Me.DataGrid4)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 200)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Customer Id"
        '
        'txt_scid
        '
        Me.txt_scid.Location = New System.Drawing.Point(96, 41)
        Me.txt_scid.Name = "txt_scid"
        Me.txt_scid.Size = New System.Drawing.Size(81, 21)
        Me.txt_scid.TabIndex = 9
        '
        'cmd_cgo
        '
        Me.cmd_cgo.BackColor = System.Drawing.Color.LightCoral
        Me.cmd_cgo.Location = New System.Drawing.Point(192, 40)
        Me.cmd_cgo.Name = "cmd_cgo"
        Me.cmd_cgo.Size = New System.Drawing.Size(46, 24)
        Me.cmd_cgo.TabIndex = 8
        Me.cmd_cgo.Text = "Go"
        Me.cmd_cgo.UseVisualStyleBackColor = False
        '
        'cmd_go
        '
        Me.cmd_go.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_go.Location = New System.Drawing.Point(344, 10)
        Me.cmd_go.Name = "cmd_go"
        Me.cmd_go.Size = New System.Drawing.Size(40, 24)
        Me.cmd_go.TabIndex = 7
        Me.cmd_go.Text = "Go"
        Me.cmd_go.UseVisualStyleBackColor = False
        '
        'dtptd
        '
        Me.dtptd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptd.Location = New System.Drawing.Point(242, 12)
        Me.dtptd.Name = "dtptd"
        Me.dtptd.Size = New System.Drawing.Size(96, 21)
        Me.dtptd.TabIndex = 6
        Me.dtptd.Value = New Date(2006, 7, 21, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From Date"
        '
        'dtpfd
        '
        Me.dtpfd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfd.Location = New System.Drawing.Point(92, 13)
        Me.dtpfd.Name = "dtpfd"
        Me.dtpfd.Size = New System.Drawing.Size(96, 21)
        Me.dtpfd.TabIndex = 3
        Me.dtpfd.Value = New Date(2006, 7, 21, 0, 0, 0, 0)
        '
        'cmd_ccan
        '
        Me.cmd_ccan.Location = New System.Drawing.Point(295, 176)
        Me.cmd_ccan.Name = "cmd_ccan"
        Me.cmd_ccan.Size = New System.Drawing.Size(72, 24)
        Me.cmd_ccan.TabIndex = 2
        Me.cmd_ccan.Text = "Cancel"
        '
        'cmd_cup
        '
        Me.cmd_cup.Location = New System.Drawing.Point(200, 176)
        Me.cmd_cup.Name = "cmd_cup"
        Me.cmd_cup.Size = New System.Drawing.Size(72, 24)
        Me.cmd_cup.TabIndex = 1
        Me.cmd_cup.Text = "Update"
        '
        'DataGrid4
        '
        Me.DataGrid4.CaptionVisible = False
        Me.DataGrid4.DataMember = ""
        Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid4.Location = New System.Drawing.Point(0, 64)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.ReadOnly = True
        Me.DataGrid4.Size = New System.Drawing.Size(400, 104)
        Me.DataGrid4.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cob_payment)
        Me.GroupBox6.Location = New System.Drawing.Point(280, 107)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(104, 24)
        Me.GroupBox6.TabIndex = 100
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'cob_payment
        '
        Me.cob_payment.Items.AddRange(New Object() {"Client", "We"})
        Me.cob_payment.Location = New System.Drawing.Point(0, 0)
        Me.cob_payment.Name = "cob_payment"
        Me.cob_payment.Size = New System.Drawing.Size(104, 21)
        Me.cob_payment.TabIndex = 98
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cob_child)
        Me.GroupBox4.Location = New System.Drawing.Point(112, 24)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 24)
        Me.GroupBox4.TabIndex = 99
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'cob_child
        '
        Me.cob_child.Items.AddRange(New Object() {"Shared", "Own", "None"})
        Me.cob_child.Location = New System.Drawing.Point(0, 0)
        Me.cob_child.Name = "cob_child"
        Me.cob_child.Size = New System.Drawing.Size(104, 21)
        Me.cob_child.TabIndex = 98
        '
        'lst1
        '
        Me.lst1.Location = New System.Drawing.Point(408, 48)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(152, 108)
        Me.lst1.TabIndex = 1
        Me.lst1.Visible = False
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(712, 216)
        Me.DataGrid1.TabIndex = 0
        '
        'TabVeh
        '
        Me.TabVeh.Controls.Add(Me.GroupBox11)
        Me.TabVeh.Controls.Add(Me.GroupBox9)
        Me.TabVeh.Controls.Add(Me.GroupBox8)
        Me.TabVeh.Controls.Add(Me.GroupBox7)
        Me.TabVeh.Controls.Add(Me.DataGrid2)
        Me.TabVeh.Location = New System.Drawing.Point(4, 22)
        Me.TabVeh.Name = "TabVeh"
        Me.TabVeh.Size = New System.Drawing.Size(712, 230)
        Me.TabVeh.TabIndex = 1
        Me.TabVeh.Text = "Vehicle Booking"
        Me.TabVeh.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cob_vpayment)
        Me.GroupBox11.Location = New System.Drawing.Point(552, 160)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(104, 24)
        Me.GroupBox11.TabIndex = 101
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Visible = False
        '
        'cob_vpayment
        '
        Me.cob_vpayment.Items.AddRange(New Object() {"Client", "We"})
        Me.cob_vpayment.Location = New System.Drawing.Point(0, 0)
        Me.cob_vpayment.Name = "cob_vpayment"
        Me.cob_vpayment.Size = New System.Drawing.Size(104, 21)
        Me.cob_vpayment.TabIndex = 98
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.cob_vtype)
        Me.GroupBox9.Controls.Add(Me.DataGrid5)
        Me.GroupBox9.Controls.Add(Me.cmd_vcac)
        Me.GroupBox9.Controls.Add(Me.cmd_vupd)
        Me.GroupBox9.Location = New System.Drawing.Point(32, 16)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(600, 200)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Vehicle Type"
        '
        'cob_vtype
        '
        Me.cob_vtype.Location = New System.Drawing.Point(168, 16)
        Me.cob_vtype.Name = "cob_vtype"
        Me.cob_vtype.Size = New System.Drawing.Size(128, 21)
        Me.cob_vtype.TabIndex = 3
        Me.cob_vtype.Text = "--select vehicle--"
        '
        'DataGrid5
        '
        Me.DataGrid5.CaptionVisible = False
        Me.DataGrid5.DataMember = ""
        Me.DataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid5.Location = New System.Drawing.Point(0, 48)
        Me.DataGrid5.Name = "DataGrid5"
        Me.DataGrid5.Size = New System.Drawing.Size(600, 112)
        Me.DataGrid5.TabIndex = 2
        '
        'cmd_vcac
        '
        Me.cmd_vcac.Location = New System.Drawing.Point(336, 168)
        Me.cmd_vcac.Name = "cmd_vcac"
        Me.cmd_vcac.Size = New System.Drawing.Size(88, 24)
        Me.cmd_vcac.TabIndex = 1
        Me.cmd_vcac.Text = "cancel"
        '
        'cmd_vupd
        '
        Me.cmd_vupd.Location = New System.Drawing.Point(216, 168)
        Me.cmd_vupd.Name = "cmd_vupd"
        Me.cmd_vupd.Size = New System.Drawing.Size(88, 24)
        Me.cmd_vupd.TabIndex = 0
        Me.cmd_vupd.Text = "update"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.dtpdate)
        Me.GroupBox8.Location = New System.Drawing.Point(280, 88)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(96, 24)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Visible = False
        '
        'dtpdate
        '
        Me.dtpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(3, 0)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.ShowUpDown = True
        Me.dtpdate.Size = New System.Drawing.Size(90, 21)
        Me.dtpdate.TabIndex = 0
        Me.dtpdate.Value = New Date(2006, 7, 19, 0, 0, 0, 0)
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dtptime)
        Me.GroupBox7.Location = New System.Drawing.Point(160, 96)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(72, 24)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'dtptime
        '
        Me.dtptime.CustomFormat = "HH:mm"
        Me.dtptime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptime.Location = New System.Drawing.Point(3, 0)
        Me.dtptime.Name = "dtptime"
        Me.dtptime.ShowUpDown = True
        Me.dtptime.Size = New System.Drawing.Size(66, 21)
        Me.dtptime.TabIndex = 0
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.PreferredColumnWidth = 125
        Me.DataGrid2.Size = New System.Drawing.Size(696, 216)
        Me.DataGrid2.TabIndex = 0
        '
        'Tabflight
        '
        Me.Tabflight.Location = New System.Drawing.Point(4, 22)
        Me.Tabflight.Name = "Tabflight"
        Me.Tabflight.Size = New System.Drawing.Size(712, 230)
        Me.Tabflight.TabIndex = 2
        Me.Tabflight.Text = "Flight Booking"
        Me.Tabflight.Visible = False
        '
        'TabActiv
        '
        Me.TabActiv.Controls.Add(Me.GroupBox14)
        Me.TabActiv.Controls.Add(Me.GroupBox13)
        Me.TabActiv.Controls.Add(Me.GroupBox12)
        Me.TabActiv.Controls.Add(Me.DataGrid6)
        Me.TabActiv.Controls.Add(Me.Label7)
        Me.TabActiv.Controls.Add(Me.cob_act)
        Me.TabActiv.Location = New System.Drawing.Point(4, 22)
        Me.TabActiv.Name = "TabActiv"
        Me.TabActiv.Size = New System.Drawing.Size(712, 230)
        Me.TabActiv.TabIndex = 5
        Me.TabActiv.Text = "Activity Booking"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.dtp_act)
        Me.GroupBox14.Location = New System.Drawing.Point(48, 8)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(96, 24)
        Me.GroupBox14.TabIndex = 5
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Visible = False
        '
        'dtp_act
        '
        Me.dtp_act.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_act.Location = New System.Drawing.Point(0, 0)
        Me.dtp_act.Name = "dtp_act"
        Me.dtp_act.Size = New System.Drawing.Size(96, 21)
        Me.dtp_act.TabIndex = 0
        Me.dtp_act.Value = New Date(2006, 7, 19, 0, 0, 0, 0)
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.cob_apayment)
        Me.GroupBox13.Location = New System.Drawing.Point(64, 32)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(96, 24)
        Me.GroupBox13.TabIndex = 4
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Visible = False
        '
        'cob_apayment
        '
        Me.cob_apayment.Items.AddRange(New Object() {"Client", "We"})
        Me.cob_apayment.Location = New System.Drawing.Point(0, 0)
        Me.cob_apayment.Name = "cob_apayment"
        Me.cob_apayment.Size = New System.Drawing.Size(96, 21)
        Me.cob_apayment.TabIndex = 0
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox12.Controls.Add(Me.cmd_Acancel)
        Me.GroupBox12.Controls.Add(Me.cmd_AUpdate)
        Me.GroupBox12.Controls.Add(Me.DataGrid7)
        Me.GroupBox12.Location = New System.Drawing.Point(80, 24)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(512, 192)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Visible = False
        '
        'cmd_Acancel
        '
        Me.cmd_Acancel.Location = New System.Drawing.Point(296, 160)
        Me.cmd_Acancel.Name = "cmd_Acancel"
        Me.cmd_Acancel.Size = New System.Drawing.Size(72, 24)
        Me.cmd_Acancel.TabIndex = 2
        Me.cmd_Acancel.Text = "Cancel"
        '
        'cmd_AUpdate
        '
        Me.cmd_AUpdate.Location = New System.Drawing.Point(192, 160)
        Me.cmd_AUpdate.Name = "cmd_AUpdate"
        Me.cmd_AUpdate.Size = New System.Drawing.Size(72, 24)
        Me.cmd_AUpdate.TabIndex = 1
        Me.cmd_AUpdate.Text = "Update"
        '
        'DataGrid7
        '
        Me.DataGrid7.CaptionVisible = False
        Me.DataGrid7.DataMember = ""
        Me.DataGrid7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid7.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid7.Name = "DataGrid7"
        Me.DataGrid7.ReadOnly = True
        Me.DataGrid7.Size = New System.Drawing.Size(512, 144)
        Me.DataGrid7.TabIndex = 0
        '
        'DataGrid6
        '
        Me.DataGrid6.CaptionVisible = False
        Me.DataGrid6.DataMember = ""
        Me.DataGrid6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid6.Location = New System.Drawing.Point(8, 48)
        Me.DataGrid6.Name = "DataGrid6"
        Me.DataGrid6.Size = New System.Drawing.Size(696, 168)
        Me.DataGrid6.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Activity"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cob_act
        '
        Me.cob_act.Location = New System.Drawing.Point(256, 16)
        Me.cob_act.Name = "cob_act"
        Me.cob_act.Size = New System.Drawing.Size(112, 21)
        Me.cob_act.TabIndex = 0
        Me.cob_act.Text = "-- select --"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.Txt_cuid)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Txt_Juniors)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.dtpbd)
        Me.GroupBox5.Controls.Add(Me.dtped)
        Me.GroupBox5.Controls.Add(Me.dtpsd)
        Me.GroupBox5.Controls.Add(Me.cob_status)
        Me.GroupBox5.Controls.Add(Me.cmd_search)
        Me.GroupBox5.Controls.Add(Me.txt_cust)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txt_aname)
        Me.GroupBox5.Controls.Add(Me.txt_infants)
        Me.GroupBox5.Controls.Add(Me.txt_childs)
        Me.GroupBox5.Controls.Add(Me.txt_adults)
        Me.GroupBox5.Controls.Add(Me.txt_gname)
        Me.GroupBox5.Controls.Add(Me.Label75)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(724, 104)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Customer"
        '
        'Txt_cuid
        '
        Me.Txt_cuid.Location = New System.Drawing.Point(91, 45)
        Me.Txt_cuid.Name = "Txt_cuid"
        Me.Txt_cuid.ReadOnly = True
        Me.Txt_cuid.Size = New System.Drawing.Size(88, 21)
        Me.Txt_cuid.TabIndex = 102
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 13)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Customer ID"
        '
        'Txt_Juniors
        '
        Me.Txt_Juniors.Location = New System.Drawing.Point(399, 73)
        Me.Txt_Juniors.Name = "Txt_Juniors"
        Me.Txt_Juniors.Size = New System.Drawing.Size(44, 21)
        Me.Txt_Juniors.TabIndex = 100
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(313, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "No.of Juniors"
        '
        'dtpbd
        '
        Me.dtpbd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbd.Location = New System.Drawing.Point(286, 45)
        Me.dtpbd.Name = "dtpbd"
        Me.dtpbd.Size = New System.Drawing.Size(88, 21)
        Me.dtpbd.TabIndex = 98
        Me.dtpbd.Value = New Date(2006, 7, 31, 0, 0, 0, 0)
        '
        'dtped
        '
        Me.dtped.CalendarTitleForeColor = System.Drawing.Color.Gainsboro
        Me.dtped.CustomFormat = ""
        Me.dtped.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtped.Location = New System.Drawing.Point(629, 44)
        Me.dtped.Name = "dtped"
        Me.dtped.Size = New System.Drawing.Size(88, 21)
        Me.dtped.TabIndex = 7
        Me.dtped.Value = New Date(2006, 7, 31, 0, 0, 0, 0)
        '
        'dtpsd
        '
        Me.dtpsd.CustomFormat = ""
        Me.dtpsd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsd.Location = New System.Drawing.Point(460, 44)
        Me.dtpsd.Name = "dtpsd"
        Me.dtpsd.Size = New System.Drawing.Size(88, 21)
        Me.dtpsd.TabIndex = 6
        Me.dtpsd.Value = New Date(2006, 7, 31, 0, 0, 0, 0)
        '
        'cob_status
        '
        Me.cob_status.Items.AddRange(New Object() {"Quotation", "Confirm"})
        Me.cob_status.Location = New System.Drawing.Point(420, 17)
        Me.cob_status.Name = "cob_status"
        Me.cob_status.Size = New System.Drawing.Size(88, 21)
        Me.cob_status.TabIndex = 3
        '
        'cmd_search
        '
        Me.cmd_search.Location = New System.Drawing.Point(290, 16)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(56, 24)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "Search"
        '
        'txt_cust
        '
        Me.txt_cust.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_cust.Location = New System.Drawing.Point(73, 17)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.Size = New System.Drawing.Size(208, 21)
        Me.txt_cust.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(364, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Status *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Customer"
        '
        'txt_aname
        '
        Me.txt_aname.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_aname.Location = New System.Drawing.Point(607, 16)
        Me.txt_aname.Name = "txt_aname"
        Me.txt_aname.ReadOnly = True
        Me.txt_aname.Size = New System.Drawing.Size(104, 21)
        Me.txt_aname.TabIndex = 4
        '
        'txt_infants
        '
        Me.txt_infants.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_infants.Location = New System.Drawing.Point(679, 73)
        Me.txt_infants.Name = "txt_infants"
        Me.txt_infants.Size = New System.Drawing.Size(39, 21)
        Me.txt_infants.TabIndex = 11
        '
        'txt_childs
        '
        Me.txt_childs.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_childs.Location = New System.Drawing.Point(544, 72)
        Me.txt_childs.Name = "txt_childs"
        Me.txt_childs.Size = New System.Drawing.Size(45, 21)
        Me.txt_childs.TabIndex = 10
        '
        'txt_adults
        '
        Me.txt_adults.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_adults.Location = New System.Drawing.Point(266, 73)
        Me.txt_adults.Name = "txt_adults"
        Me.txt_adults.Size = New System.Drawing.Size(45, 21)
        Me.txt_adults.TabIndex = 9
        '
        'txt_gname
        '
        Me.txt_gname.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_gname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gname.Location = New System.Drawing.Point(87, 73)
        Me.txt_gname.Name = "txt_gname"
        Me.txt_gname.Size = New System.Drawing.Size(109, 21)
        Me.txt_gname.TabIndex = 8
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(8, 76)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(79, 13)
        Me.Label75.TabIndex = 87
        Me.Label75.Text = "Group Name"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(522, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 13)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Agent Name"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(200, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 13)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Booking Date"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(449, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "No. of Children"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(201, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 13)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "No. Adults"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(392, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Start Date"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(562, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 13)
        Me.Label26.TabIndex = 26
        Me.Label26.Text = " End Date"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(594, 75)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 13)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "No. of Infants"
        '
        'Custom_Itine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(736, 501)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Custom_Itine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Itineraries"
        Me.TabControl1.ResumeLayout(False)
        Me.TabView.ResumeLayout(False)
        Me.TabView.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEntry.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabHotel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVeh.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabActiv.ResumeLayout(False)
        Me.TabActiv.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DataGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cmd As OleDb.OleDbCommand
    Dim ord As OleDb.OleDbDataReader
    Dim ds As New DataSet
    Dim dad As OleDb.OleDbDataAdapter
    'data table for hotel booking
    Dim dt As New DataTable("hbook")
    Dim c1 As New DataColumn("   Date  ")
    Dim c2 As New DataColumn("  HotelId  ")
    Dim c3 As New DataColumn("Room Tariff")
    Dim c4 As New DataColumn("  Amount  ")
    Dim C5 As New DataColumn("   Basis  ")
    Dim c6 As New DataColumn("  C-Room  ")
    Dim c7 As New DataColumn("  C-Amount ")
    Dim c8 As New DataColumn("  Payment  ")
    Dim c9 As New DataColumn("  Comments ")
    'data table for room tariff
    Dim dt1 As New DataTable("room")
    Dim dc As New DataColumn("  TransId ")
    Dim dc1 As New DataColumn("RoomCatId")
    Dim dc2 As New DataColumn(" Bed Type")
    Dim dc3 As New DataColumn("  Season ")
    Dim dc4 As New DataColumn("   Rate  ")
    Dim dc5 As New DataColumn("   Qty  ")
    'data table for child room tariff
    Dim dt2 As New DataTable("c-room")
    Dim dt2c As New DataColumn(" CTransId ")
    Dim dt2c1 As New DataColumn("RoomCatId")
    Dim dt2c2 As New DataColumn(" Bed Type")
    Dim dt2c3 As New DataColumn("  Season ")
    Dim dt2c4 As New DataColumn("   Rate  ")
    Dim dt2c5 As New DataColumn("   Qty   ")
    Dim dt2c6 As New DataColumn("child type")
    'data table for vehicle booking
    Dim dt3 As New DataTable("veh")
    Dim dt3c1 As New DataColumn("From Date")
    Dim dt3c2 As New DataColumn("From Time")
    Dim dt3c3 As New DataColumn(" To Date ")
    Dim dt3c4 As New DataColumn(" To Time ")
    Dim dt3c5 As New DataColumn(" Vehicle Tariff")
    Dim dt3c6 As New DataColumn(" Payment ")
    Dim dt3c7 As New DataColumn(" Comments ")
    Dim dt3c8 As New DataColumn(" Booking ")
    'data table for vehicle type
    Dim dt4 As New DataTable("veh-type")
    Dim dt4c1 As New DataColumn("Tariff Code")
    Dim dt4c2 As New DataColumn(" Drive ")
    Dim dt4c3 As New DataColumn("Base Price")
    Dim dt4c4 As New DataColumn("KiloMeters")
    Dim dt4c5 As New DataColumn("  Hours ")
    Dim dt4c6 As New DataColumn("Extra KM Rate")
    Dim dt4c7 As New DataColumn(" Qty ")
    'data table for activity
    Dim dt5 As New DataTable("Act")
    Dim dt5c1 As New DataColumn("Activity")
    Dim dt5c2 As New DataColumn("date")
    Dim dt5c3 As New DataColumn("Hrs/Days")
    Dim dt5c4 As New DataColumn("No Adults")
    Dim dt5c40 As New DataColumn("No Juniors")
    Dim dt5c41 As New DataColumn("No Childs")
    Dim dt5c5 As New DataColumn("Amount")
    Dim dt5c6 As New DataColumn("PaymentBy")
    Dim dt5c7 As New DataColumn("Comments")
    Dim dt5c8 As New DataColumn("Booking")
    'data table for view
    Dim vdt As New DataTable("view")
    Dim vdtc1 As New DataColumn("Date")
    Dim vdtc2 As New DataColumn("Hotel")
    Dim vdtc3 As New DataColumn("No Occupents ")
    Dim vdtc4 As New DataColumn("Vehicle")
    Dim vdtc5 As New DataColumn("No Vehicle")
    Dim vdtc6 As New DataColumn("Activity")
    Dim vdtc7 As New DataColumn("No Person")
    Dim dr As DataRow
    Dim cid, rid, vcid, vrid, acid, arid, search As Integer
    Dim amount As Integer = 0
    Dim atid As String
    Dim aqty As Integer
    Dim cuid, agtid As String
    Dim actbook As String = "y"
    Dim recmode As Module1.EnuRecstatus
    Private Sub Custom_Itine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'data table for hotel booking   
        ds.Tables.Add(dt)
        dt.Columns.Add(c1)
        dt.Columns.Add(c2)
        dt.Columns.Add(c3)
        dt.Columns.Add(C4)
        dt.Columns.Add(C5)
        dt.Columns.Add(c6)
        dt.Columns.Add(c7)
        dt.Columns.Add(c8)
        dt.Columns.Add(c9)
        'data table for room tariff
        ds.Tables.Add(dt1)
        dt1.Columns.Add(dc)
        dt1.Columns.Add(dc1)
        dt1.Columns.Add(dc2)
        dt1.Columns.Add(dc3)
        dt1.Columns.Add(dc4)
        dt1.Columns.Add(dc5)
        'data table for child room tariff
        ds.Tables.Add(dt2)
        dt2.Columns.Add(dt2c)
        dt2.Columns.Add(dt2c1)
        dt2.Columns.Add(dt2c2)
        dt2.Columns.Add(dt2c3)
        dt2.Columns.Add(dt2c4)
        dt2.Columns.Add(dt2c6)
        dt2.Columns.Add(dt2c5)
        'data table for vehicle Booking
        ds.Tables.Add(dt3)
        dt3.Columns.Add(dt3c1)
        dt3.Columns.Add(dt3c2)
        dt3.Columns.Add(dt3c3)
        dt3.Columns.Add(dt3c4)
        dt3.Columns.Add(dt3c5)
        dt3.Columns.Add(dt3c6)
        dt3.Columns.Add(dt3c7)
        dt3.Columns.Add(dt3c8)
        'data table for vehicle type
        ds.Tables.Add(dt4)
        dt4.Columns.Add(dt4c1)
        dt4.Columns.Add(dt4c2)
        dt4.Columns.Add(dt4c3)
        dt4.Columns.Add(dt4c4)
        dt4.Columns.Add(dt4c5)
        dt4.Columns.Add(dt4c6)
        dt4.Columns.Add(dt4c7)
        'data table for activity 
        ds.Tables.Add(dt5)
        dt5.Columns.Add(dt5c1)
        dt5.Columns.Add(dt5c2)
        dt5.Columns.Add(dt5c3)
        dt5.Columns.Add(dt5c4)
        dt5.Columns.Add(dt5c40)
        dt5.Columns.Add(dt5c41)
        dt5.Columns.Add(dt5c5)
        dt5.Columns.Add(dt5c6)
        dt5.Columns.Add(dt5c7)
        dt5.Columns.Add(dt5c8)
        'data table for view
        ds.Tables.Add(vdt)
        vdt.Columns.Add(vdtc1)
        vdt.Columns.Add(vdtc2)
        vdt.Columns.Add(vdtc3)
        vdt.Columns.Add(vdtc4)
        vdt.Columns.Add(vdtc5)
        vdt.Columns.Add(vdtc6)
        vdt.Columns.Add(vdtc7)
        dtped.MinDate = dtpsd.Value
        TabControl1.SelectedTab = TabEntry
        disable()
        ds.Tables.Add("search")
        ds.Tables.Add("search1")
        ds.Tables.Add("search2")
        dtpbd.Value = Date.Now
        dtpsd.Value = Date.Now
        dtped.Value = Date.Now
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        '*********************************************************************************************  
        ' datagrid belongs to hotel tab
        '*********************************************************************************************
        Dim season As String
        Dim i, rowcount, count As Integer
        i = 0
        cid = DataGrid1.CurrentCell.ColumnNumber
        rid = DataGrid1.CurrentCell.RowNumber
        rowcount = dt.Rows.Count
        If cid = 0 Then
            If rid <= rowcount Then
                DataGrid1.Item(rid, 0) = dt.Rows(rid).Item(0)
            End If
        End If
        If cid = 1 Then
            ' showing list of hotels in listbox  
            Openconnection()
            cmd = New OleDb.OleDbCommand("select count(*) from HotelMaster", con)
            count = cmd.ExecuteScalar
            cmd.Dispose()
            If count = 0 Then
                MsgBox("Hotel Data Not Available", MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            End If
            cmd = New OleDb.OleDbCommand("select HotelId, HotelName from HotelMaster", con)
            ord = cmd.ExecuteReader
            lst1.Items.Clear()
            While ord.Read
                lst1.Items.Add(ord(0) + "--" + ord(1))
            End While
            cmd.Dispose()
            ord.Close()
            con.Close()
            lst1.Top = DataGrid1.Top + DataGrid1.GetCurrentCellBounds.Top + DataGrid1.GetCurrentCellBounds.Height
            lst1.Left = DataGrid1.Left + DataGrid1.GetCurrentCellBounds.Left + DataGrid1.GetCurrentCellBounds.Width
            lst1.Visible = True
        End If
        If cid = 2 Then

            'showing list of rooms in hotel selected above from RoomTariff

            lst1.Visible = False
            If DataGrid1.Item(rid, 1) = " " Or DataGrid1.Item(rid, 1) = "" Then
                MsgBox("Select Hotel", MsgBoxStyle.OKOnly, Prjtitle)
                GroupBox1.Visible = False
                cid = 0
                Exit Sub
            End If
            Openconnection()
            ds.Tables("room").Clear()
            DataGrid3.Refresh()
            cmd = New OleDb.OleDbCommand("select season from Hotel_Season where HotelId='" & DataGrid1.Item(rid, 1) & "' and  #" & FormatDateTime(DataGrid1.Item(rid, 0), DateFormat.ShortDate) & "# between FromDt AND ToDt", con)
            ord = cmd.ExecuteReader
            While ord.Read
                season = ord(0)
            End While
            cmd.Dispose()
            ord.Close()

            cmd = New OleDb.OleDbCommand("select count(*) from Room_Tariff where HotelId='" & DataGrid1.Item(rid, 1) & "' and Season='" & season & "'", con)
            count = cmd.ExecuteScalar
            cmd.Dispose()
            If count = 0 Then
                MsgBox("Room Data Not Available For The Selected Hotel", MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            End If
            cmd = New OleDb.OleDbCommand("select TransId,RCatg_id, Bed_Type,Season,RackRate from Room_Tariff where HotelId='" & DataGrid1.Item(rid, 1) & "' and Season='" & season & "'", con)
            ord = cmd.ExecuteReader
            While ord.Read
                dr = dt1.NewRow
                dr(0) = ord(0)
                dr(1) = ord(1)
                dr(2) = ord(2)
                dr(3) = ord(3)
                dr(4) = ord(4)
                dr(5) = " "
                dt1.Rows.Add(dr)

            End While

            Dim q As Integer
            For q = 0 To 4
                dt1.Columns(q).ReadOnly = True
            Next
            DataGrid3.DataSource = ds
            DataGrid3.DataMember = "room"
            GroupBox1.Visible = True
            con.Close()

        End If
        If cid = 3 Then
            GroupBox1.Visible = False
        End If
        If cid = 4 Then

            'this select where child shared the same room or they have ther own room or no children
            If DataGrid1.Item(rid, 1) = " " Or DataGrid1.Item(rid, 1) = "" Then
                MsgBox("Select Hotel", MsgBoxStyle.OKOnly, Prjtitle)
                GroupBox1.Visible = False
                cid = 0
                Exit Sub
            End If
            GroupBox4.Top = DataGrid1.Top + DataGrid1.GetCurrentCellBounds.Top
            GroupBox4.Left = DataGrid1.Left + DataGrid1.GetCurrentCellBounds.Left
            GroupBox4.Height = DataGrid1.GetCurrentCellBounds.Height
            GroupBox4.Width = DataGrid1.GetCurrentCellBounds.Width
            cob_child.Height = DataGrid1.GetCurrentCellBounds.Height
            cob_child.Width = DataGrid1.GetCurrentCellBounds.Width
            GroupBox4.Visible = True
        End If
        If cid = 5 Then

            'if basis is selected as Shared or own then according to selection the rooms are shown

            Dim str As String
            If DataGrid1.Item(rid, 4) = " " Or DataGrid1.Item(rid, 4) = "" Then
                GroupBox1.Visible = False
                Exit Sub
            Else
                str = Mid(DataGrid1.Item(rid, 4), 1, 4)
            End If
            'showing list of rooms in hotel selected above from RoomTariff
            If str = "None" Then
                GroupBox1.Visible = False
                Exit Sub
            Else
                Openconnection()
                ds.Tables("c-room").Clear()
                DataGrid3.Refresh()
                cmd = New OleDb.OleDbCommand("select season from Hotel_Season where HotelId='" & DataGrid1.Item(rid, 1) & "' and  #" & FormatDateTime(DataGrid1.Item(rid, 0), DateFormat.ShortDate) & "# between FromDt AND ToDt", con)
                ord = cmd.ExecuteReader
                While ord.Read
                    season = ord(0)
                End While
                cmd.Dispose()
                ord.Close()
                Try
                    cmd = New OleDb.OleDbCommand("select count(*) from Room_Tarif_Child where HotelId='" & DataGrid1.Item(rid, 1) & "' and Season='" & season & "' and Basis='" & DataGrid1.Item(rid, 4) & "' ", con)
                    count = cmd.ExecuteScalar
                    cmd.Dispose()
                    If count = 0 Then
                        MsgBox("Children Room Data Not Available For The Selected Hotel", MsgBoxStyle.OKOnly, Prjtitle)
                        Exit Sub
                    End If
                    cmd = New OleDb.OleDbCommand("select CTransId,RCatg_id, Bed_Type,Season,RackRate,Chil_Type from Room_Tarif_Child where HotelId='" & DataGrid1.Item(rid, 1) & "' and Season='" & season & "' and Basis='" & DataGrid1.Item(rid, 4) & "' ", con)
                    ord = cmd.ExecuteReader
                    While ord.Read
                        dr = dt2.NewRow
                        dr(0) = ord(0)
                        dr(1) = ord(1)
                        dr(2) = ord(2)
                        dr(3) = ord(3)
                        dr(4) = ord(4)
                        dr(5) = ord(5)
                        dr(6) = " "
                        dt2.Rows.Add(dr)
                    End While
                    DataGrid3.DataSource = ds
                    DataGrid3.DataMember = "c-room"
                    GroupBox1.Visible = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                con.Close()
            End If
        End If
        If cid = 7 Then

            'paymentby is selected here for the hotel

            GroupBox6.Top = DataGrid1.Top + DataGrid1.GetCurrentCellBounds.Top
            GroupBox6.Left = DataGrid1.Left + DataGrid1.GetCurrentCellBounds.Left
            GroupBox6.Height = DataGrid1.GetCurrentCellBounds.Height
            GroupBox6.Width = DataGrid1.GetCurrentCellBounds.Width
            cob_payment.Height = DataGrid1.GetCurrentCellBounds.Height
            cob_payment.Width = DataGrid1.GetCurrentCellBounds.Width
            GroupBox6.Visible = True
        End If

    End Sub

    Private Sub lst1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst1.Click
        Dim temp As String
        Dim i As Integer
        'when a hotel is clicked it is updated in hotelbooking datatable
        temp = lst1.SelectedItem
        i = InStr(temp, "-")
        temp = Mid(temp, 1, i - 1)
        dt.Rows(rid).Item(cid) = temp
        dt.Rows(rid).AcceptChanges()
        lst1.Visible = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String
        Dim i As Integer
        Dim rate As Integer
        Dim ramount As Integer = 0


        'when update button clicked this procedure will concatinate the transid and qty of the hotel and 
        ' update in hotel booking data table 
        If cid = 2 Then
            i = dt1.Rows.Count
            For j As Integer = 0 To i - 1
                If dt1.Rows(j).Item(5) <> " " Then
                    If j < i - 1 Then
                        str = str + dt1.Rows(j).Item(0) + "-" + dt1.Rows(j).Item(5) + ","
                        'getting rate of selected room from data base
                        Openconnection()
                        cmd = New OleDb.OleDbCommand("select RackRate from Room_Tariff where TransId=" & dt1.Rows(j).Item(0) & "", con)
                        ord = cmd.ExecuteReader
                        While ord.Read
                            rate = ord(0)
                        End While
                        cmd.Dispose()
                        ord.Close()
                        con.Close()
                        'total qty
                        Try
                            aqty = aqty + CInt(dt1.Rows(j).Item(5))
                            'total amount
                            ramount = ramount + (rate * CInt(dt1.Rows(j).Item(5)))
                        Catch ex As Exception
                            MsgBox("Enter Only Numbers In Quantity Column", MsgBoxStyle.OKOnly, Prjtitle)
                            Exit Sub
                        End Try
                    Else
                        str = str + dt1.Rows(j).Item(0) + "-" + dt1.Rows(j).Item(5)
                        Openconnection()
                        'getting rate of selected room from data base
                        cmd = New OleDb.OleDbCommand("select RackRate from Room_Tariff where TransId=" & dt1.Rows(j).Item(0) & "", con)
                        ord = cmd.ExecuteReader
                        While ord.Read
                            rate = ord(0)
                        End While
                        cmd.Dispose()
                        ord.Close()
                        con.Close()
                        'total qty
                        Try
                            aqty = aqty + CInt(dt1.Rows(j).Item(5))
                            'total amount
                            ramount = ramount + (rate * CInt(dt1.Rows(j).Item(5)))
                        Catch ex As Exception
                            MsgBox("Enter Only Numbers In Quantity Column", MsgBoxStyle.OKOnly, Prjtitle)
                            Exit Sub
                        End Try
                    End If
                End If
            Next
        End If
        If cid = 5 Then
            i = dt2.Rows.Count
            For j As Integer = 0 To i - 1
                Try
                    If dt2.Rows(j).Item(6) <> " " Then
                        If j < i - 1 Then
                            str = str + dt2.Rows(j).Item(0) + "-" + dt2.Rows(j).Item(6) + ","
                            'getting rate of selected room from data base
                            Openconnection()
                            cmd = New OleDb.OleDbCommand("select RackRate from Room_Tarif_Child where CTransId=" & dt2.Rows(j).Item(0) & "", con)
                            ord = cmd.ExecuteReader
                            While ord.Read
                                rate = ord(0)
                            End While
                            cmd.Dispose()
                            ord.Close()
                            con.Close()
                            'total qty
                            Try
                                aqty = aqty + CInt(dt2.Rows(j).Item(6))
                                'total amount
                                ramount = ramount + (rate * CInt(dt2.Rows(j).Item(6)))
                            Catch ex As Exception
                                MsgBox("Enter Only Numbers In Quantity Column", MsgBoxStyle.OKOnly, Prjtitle)
                                Exit Sub
                            End Try
                        Else
                            str = str + dt2.Rows(j).Item(0) + "-" + dt2.Rows(j).Item(6)
                            Openconnection()
                            'getting rate of selected room from data base
                            cmd = New OleDb.OleDbCommand("select RackRate from Room_Tarif_Child where CTransId=" & dt2.Rows(j).Item(0) & "", con)
                            ord = cmd.ExecuteReader
                            While ord.Read
                                rate = ord(0)
                            End While
                            cmd.Dispose()
                            ord.Close()
                            con.Close()
                            'total qty
                            Try
                                aqty = aqty + CInt(dt2.Rows(j).Item(6))
                                'total amount
                                ramount = ramount + (rate * CInt(dt2.Rows(j).Item(6)))
                            Catch ex As Exception
                                MsgBox("Enter Only Numbers In Quantity Column", MsgBoxStyle.OKOnly, Prjtitle)
                                Exit Sub
                            End Try
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If
        dt.Rows(rid).Item(cid) = str
        dt.Rows(rid).Item(cid + 1) = ramount
        dt.Rows(rid).AcceptChanges()
        GroupBox1.Visible = False
        'displaying total amount
        amount = amount + ramount
        txt_total.Text = amount
        ' calculating amount for per person
        txt_pp.Text = amount / aqty
    End Sub

    Private Sub cmd_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_search.Click
        search = 1
        If txt_cust.Text = "" Then
            'when cust name is empty poping up a groupbox to search with dates or cust id
            GroupBox2.Visible = True
            cmd_cup.Enabled = False
        Else
            'showing all cust names with the name given in textbox
            Dim str As String
            str = "%" + txt_cust.Text + "%"
            dad = New OleDb.OleDbDataAdapter("select CustId, Fname, Lname,Cust_JDate from Cust_Master where Fname like '" & str & "' or Lname like '" & str & "'", con)

            If ds.Tables("search").Rows.Count > 0 Then
                ds.Tables("search").Clear()
            End If

            dad.Fill(ds, "search")
            DataGrid4.DataSource = ds
            DataGrid4.DataMember = "search"
            GroupBox2.Visible = True
            dad.Dispose()
        End If

    End Sub

    Private Sub cmd_ccan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ccan.Click
        GroupBox2.Visible = False
        If ds.Tables("search").Rows.Count > 0 Then
            ds.Tables("search").Clear()
        End If
        If ds.Tables("search1").Rows.Count > 0 Then
            ds.Tables("search1").Clear()
        End If
        If ds.Tables("search2").Rows.Count > 0 Then
            ds.Tables("search2").Clear()
        End If
    End Sub

    Private Sub cmd_cup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cup.Click
        ' after selecting cust id this procedure will update the cust daetails in the form    
        Dim str As String
        cuid = DataGrid4.Item(DataGrid4.CurrentRowIndex, 0)
        Txt_cuid.Text = cuid
        Openconnection()
        cmd = New OleDb.OleDbCommand("select Fname, Lname, AgentId from Cust_Master where CustId='" & DataGrid4.Item(DataGrid4.CurrentRowIndex, 0) & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            txt_cust.Text = ord(0) + " " + ord(1)
            agtid = ord(2)
        End While
        cmd.Dispose()
        ord.Close()
        cmd = New OleDb.OleDbCommand(" select FirstName, LastName  from AgentMaster where AgentId='" & agtid & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            str = ord(0) + " " + ord(1)
        End While
        con.Close()
        txt_aname.Text = str
        If search = 1 Then
            ds.Tables("search").Clear()
        End If
        If search = 2 Then
            ds.Tables("search1").Clear()
        End If
        If search = 3 Then
            ds.Tables("search2").Clear()
        End If

        GroupBox2.Visible = False
    End Sub

    Private Sub cmd_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_go.Click
        ' this procedure to search cust details between dates 
        search = 2
        dad = New OleDb.OleDbDataAdapter("select CustId, Fname, Lname, Cust_JDate from Cust_Master where Cust_JDate between #" & dtpfd.Text & "# and #" & dtptd.Text & "#", con)
        If ds.Tables("search1").Rows.Count > 0 Then
            ds.Tables("search1").Clear()
        End If
        dad.Fill(ds, "search1")
        DataGrid4.DataSource = ds
        DataGrid4.DataMember = "search1"
        cmd_cup.Enabled = True
        dad.Dispose()

    End Sub

    Private Sub cmd_cgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cgo.Click
        ' this procedure to search cust details using cust id

        search = 3
        dad = New OleDb.OleDbDataAdapter("select CustId, Fname, Lname, Cust_JDate from Cust_Master where CustId like '" & "%" & txt_scid.Text & "%" & "'", con)

        If ds.Tables("search2").Rows.Count > 0 Then
            ds.Tables("search2").Clear()
        End If

        dad.Fill(ds, "search2")
        DataGrid4.DataSource = ds
        DataGrid4.DataMember = "search2"
        cmd_cup.Enabled = True
        dad.Dispose()

    End Sub
    Public Sub saveproc()

        Dim rc As Integer
        Dim str(rc) As String
        Dim x As Integer
        Dim str1 As String
        Dim tstr As String
        Dim qstr As String
        Dim occ_date As String
        Dim rate As Integer
        Dim am As Integer
        Dim null As String
        null = "NULL"
        Dim i As Integer
        Dim HBookId As String
        Dim Sysrefno, na As Integer
        Dim bi As String
        If cob_status.Text = "" Then
            MsgBox(" STATUS SHOULD NOT BE EMPTY", MsgBoxStyle.OKOnly, Prjtitle)
            cob_status.Focus()
            Exit Sub
        End If
        If txt_cust.Text = "" Then
            MsgBox("Customer Has Not Been Selected", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        If txt_adults.Text = "" Then
            If Txt_Juniors.Text = "" Then

                MsgBox("Enter No of Pax ", MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            End If
        End If
        If recmode = Module1.EnuRecstatus.Recnew Then
            Openconnection()
            ' when cust asks for quotqtion updating Enq_Booking_Itinary  
            '********************************************************************************************************
            '              ******** Booking Itinary Number *************

            If cob_status.Text = "Quotation" Then
                ' setting value for sysrefno 
                cmd = New OleDb.OleDbCommand("select count(*) from Enq_Booking_Itinary", con)
                i = cmd.ExecuteScalar
                cmd.Dispose()
                If i >= 1 Then
                    cmd = New OleDb.OleDbCommand("select max(SysRefNo) from  Enq_Booking_Itinary", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        Sysrefno = ord(0)
                    End If
                    cmd.Dispose()
                    ord.Close()
                    Sysrefno = Sysrefno + 1
                Else
                    Sysrefno = 1
                End If

                ' setting booking id to null 
                bi = "ECI" + CStr(Sysrefno)

                'net amount
                If txt_edic.Text = "" Then
                    txt_edic.Text = 0
                End If

                'cmd = New OleDb.OleDbCommand("insert into Enq_Booking_Itinary values(" & Sysrefno & ",'" & bi & "','" & cuid & "','Custom','" & dtpbd.Text & "','" & dtpsd.Text & "','" & dtped.Text & "','" & agtid & "','" & txt_gname.Text & "'," & Val(txt_adults.Text) & "," & Val(txt_childs.Text) & "," & Val(txt_infants.Text) & "," & amount & "," & Int(CInt(txt_pp.Text)) & "," & CInt(txt_edic.Text) & "," & na & "," & CInt(txt_ac.Text) & ",'Y','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "',' ')", con)
                'cmd.ExecuteNonQuery()
                'cmd.Dispose()

            End If

            ' when cust confirms the booking then updating into Booking_Intinary
            If cob_status.Text = "Confirm" Then
                'generating sysrefno
                cmd = New OleDb.OleDbCommand("select count(*) from Booking_Itinary", con)
                i = cmd.ExecuteScalar
                cmd.Dispose()
                If i >= 1 Then
                    cmd = New OleDb.OleDbCommand("select max(SysRefNo) from  Booking_Itinary", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        Sysrefno = ord(0)
                    End If
                    cmd.Dispose()
                    ord.Close()
                    Sysrefno = Sysrefno + 1
                Else
                    Sysrefno = 1
                End If

                'booking id
                bi = "CCI" + CStr(Sysrefno)

                'net amount
                If txt_edic.Text = "" Then
                    txt_edic.Text = 0
                End If

                'cmd = New OleDb.OleDbCommand("insert into Booking_Itinary values(" & Sysrefno & ",'" & bi & "','" & cuid & "','Custom','" & dtpbd.Text & "','" & dtpsd.Text & "','" & dtped.Text & "','" & agtid & "','" & txt_gname.Text & "'," & Val(txt_adults.Text) & "," & Val(txt_childs.Text) & "," & Val(txt_infants.Text) & "," & amount & "," & Int(CInt(txt_pp.Text)) & "," & CInt(txt_edic.Text) & "," & na & "," & CInt(txt_ac.Text) & ",'N','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "',' ','" & FormatDateTime(Now, DateFormat.GeneralDate) & "')", con)
                'cmd.ExecuteNonQuery()
                'cmd.Dispose()
            End If


            '*********************************************************************************************
            '                      ********* Hotel Booking Number **************
hotel:

            'quotation for updating Enq_Booking_Itinary
            ' row count
            rc = ds.Tables("hbook").Rows.Count
            If rc = 0 Then
                GoTo veh
            End If

                For z As Integer = 0 To rc - 1
                    ' spliting transid and qty
                    am = 0
                    occ_date = FormatDateTime(ds.Tables("hbook").Rows(z).Item(0), DateFormat.ShortDate)
                    str1 = ds.Tables("hbook").Rows(z).Item(2)
                While str1 <> ""
                    If str1 <> " " Then
                        x = InStr(str1, ",")
                        If x > 3 Then
                            tstr = Mid(str1, 1, x - 1)
                            str1 = Mid(str1, x + 1)
                        Else
                            tstr = str1
                            str1 = ""
                        End If
                        x = InStr(tstr, "-")
                        qstr = Mid(tstr, x + 1)
                        tstr = Mid(tstr, 1, x - 1)

                        'selecting rate for room from room tariff 
                        cmd = New OleDb.OleDbCommand("select RackRate from Room_Tariff where TransId=" & CInt(tstr) & "", con)
                        ord = cmd.ExecuteReader
                        If ord.Read Then
                            rate = ord(0)
                        End If
                        ord.Close()
                        cmd.Dispose()
                        am = rate * CInt(qstr)
                        amount = amount + am
                        If cob_status.Text = "Quotation" Then
                            'generating hotel booking id 
                            cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Hotel", con)
                            i = cmd.ExecuteScalar
                            cmd.Dispose()
                            If i >= 1 Then
                                cmd = New OleDb.OleDbCommand("select max(HBookId) from Enq_Cust_Hotel", con)
                                ord = cmd.ExecuteReader
                                If ord.Read Then
                                    HBookId = ord(0)
                                    HBookId = HBookId + 1
                                End If
                                cmd.Dispose()
                                ord.Close()
                            Else
                                HBookId = 1
                            End If
                            If cob_payment.Text = "" Then
                                cob_payment.Text = "We"
                            End If

                            '*****    updating Enq_cust_hotel table 
                            cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Hotel values(" & HBookId & ",'" & cuid & "','" & bi & "'," & CInt(tstr) & "," & CInt(qstr) & ",'" & occ_date & "'," & am & ",'" & cob_status.Text & "','" & cob_payment.Text & "','" & ds.Tables("hbook").Rows(z).Item(8) & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','','" & ds.Tables("hbook").Rows(z).Item(1) & "')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        End If

                        If cob_status.Text = "Confirm" Then
                            'generating hotel booking id 
                            cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel", con)
                            i = cmd.ExecuteScalar
                            cmd.Dispose()
                            If i >= 1 Then
                                cmd = New OleDb.OleDbCommand("select max(HBookId) from Cust_Hotel", con)
                                ord = cmd.ExecuteReader
                                If ord.Read Then
                                    HBookId = ord(0)
                                    HBookId = HBookId + 1
                                End If
                                cmd.Dispose()
                                ord.Close()
                            Else
                                HBookId = 1
                            End If
                            If cob_payment.Text = "" Then
                                cob_payment.Text = "We"
                            End If
                            'updating cust_hotel table 
                            cmd = New OleDb.OleDbCommand("insert into Cust_Hotel values(" & HBookId & ",'" & cuid & "','" & bi & "'," & CInt(tstr) & "," & CInt(qstr) & ",'" & occ_date & "'," & am & ",'" & cob_status.Text & "','" & cob_payment.Text & "','" & ds.Tables("hbook").Rows(z).Item(8) & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','','" & ds.Tables("hbook").Rows(z).Item(1) & "')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                    End If
                End While
                '**********************       updating Hotel_child   *************************************

                If Trim(dt.Rows(z).Item(4)) = "Shared" Or Trim(dt.Rows(z).Item(4)) = "Own" Then
                    Dim crstr As String
                    Dim cqstr As String
                    crstr = dt.Rows(z).Item(5)
                    While crstr <> ""
                        x = InStr(crstr, ",")
                        If x > 3 Then
                            tstr = Mid(crstr, 1, x - 1)
                            crstr = Mid(crstr, x + 1)
                        Else
                            tstr = crstr
                            crstr = ""
                        End If
                        x = InStr(tstr, "-")
                        cqstr = Mid(tstr, x + 1)
                        tstr = Mid(tstr, 1, x - 1)

                        cmd = New OleDb.OleDbCommand("select RackRate from Room_Tarif_Child where CTransId=" & CInt(tstr) & "", con)
                        ord = cmd.ExecuteReader
                        If ord.Read Then
                            rate = ord(0)
                        End If
                        ord.Close()
                        cmd.Dispose()
                        am = rate * CInt(cqstr)
                        amount = amount + am

                        If cob_status.Text = "Quotation" Then
                            Dim HCBookId As Integer
                            cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Hotel_Child", con)
                            i = cmd.ExecuteScalar
                            cmd.Dispose()
                            If i >= 1 Then
                                cmd = New OleDb.OleDbCommand("select max(HCBookId) from Enq_Cust_Hotel_Child", con)
                                ord = cmd.ExecuteReader
                                If ord.Read Then
                                    HCBookId = ord(0)
                                    HCBookId = HCBookId + 1
                                End If
                                cmd.Dispose()
                                ord.Close()
                            Else
                                HCBookId = 1
                            End If
                            If cob_payment.Text = "" Then
                                cob_payment.Text = "We"
                            End If
                            cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Hotel_Child values(" & HCBookId & ",'" & cuid & "','" & bi & "'," & CInt(tstr) & "," & CInt(cqstr) & ",'" & occ_date & "'," & am & ",'" & cob_status.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','','" & ds.Tables("hbook").Rows(z).Item(1) & "','" & cob_payment.Text & "')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                        If cob_status.Text = "Confirm" Then
                            Dim HCBookId As Integer
                            cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel_Child", con)
                            i = cmd.ExecuteScalar
                            cmd.Dispose()
                            If i >= 1 Then
                                cmd = New OleDb.OleDbCommand("select max(HCBookId) from Cust_Hotel_Child", con)
                                ord = cmd.ExecuteReader
                                If ord.Read Then
                                    HCBookId = ord(0)
                                    HCBookId = HCBookId + 1
                                End If
                                cmd.Dispose()
                                ord.Close()
                            Else
                                HCBookId = 1
                            End If
                            If cob_payment.Text = "" Then
                                cob_payment.Text = "We"
                            End If
                            cmd = New OleDb.OleDbCommand("insert into Cust_Hotel_Child values(" & HCBookId & ",'" & cuid & "','" & bi & "'," & CInt(tstr) & "," & CInt(cqstr) & ",'" & occ_date & "'," & am & ",'" & cob_status.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','Y','','" & ds.Tables("hbook").Rows(z).Item(1) & "','" & cob_payment.Text & "')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                    End While
                End If
            Next


                '*******************************************************************************************************
                '                                **************vehicle*****************
                'calculating days of vehicle booking
veh:
                Dim fd As String
                Dim td As String
                Dim fdate As Date
                Dim tdate As Date
                Dim diffdays As String
                'net amount 
                Dim b_price As Integer
                Dim hrs As Integer
                ' row count
                rc = ds.Tables("veh").Rows.Count
                If rc = 0 Then
                    GoTo act
                End If
                For z As Integer = 0 To rc - 1
                    am = 0
                    fd = FormatDateTime(dt3.Rows(z).Item(0), DateFormat.ShortDate)
                    td = FormatDateTime(dt3.Rows(z).Item(2), DateFormat.ShortDate)
                    fdate = FormatDateTime(fdate, DateFormat.ShortDate)
                    tdate = FormatDateTime(tdate, DateFormat.ShortDate)
                    diffdays = DateDiff(DateInterval.Day, fdate, tdate) + 1

                    ' spliting transid and qty
                    str1 = ds.Tables("veh").Rows(z).Item(4)
                    x = InStr(str1, "-")
                    str1 = Mid(str1, x + 1)
                    While str1 <> ""
                        x = InStr(str1, ",")
                        If x > 3 Then
                            tstr = Mid(str1, 1, x - 1)
                            str1 = Mid(str1, x + 1)
                        Else
                            tstr = str1
                            str1 = ""
                        End If

                        x = InStr(tstr, "-")
                        qstr = Mid(tstr, x + 1)
                        tstr = Mid(tstr, 1, x - 1)

                        'selecting rate for room from room tariff 
                        cmd = New OleDb.OleDbCommand("select Rack_Base_Price,Rack_Hours from Veh_Tariff where Tariffcode='" & tstr & "'", con)
                        ord = cmd.ExecuteReader
                        If ord.Read Then
                            b_price = ord(0)
                            hrs = ord(1)
                        End If
                        ord.Close()
                        cmd.Dispose()
                        hrs = Int((diffdays * 24) / hrs)
                        am = (b_price * hrs) * CInt(qstr)
                        amount = amount + am
                        Dim VbookId As Integer
                        If cob_status.Text = "Quotation" Then
                            'generating Vehicle booking id 
                            cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Vehicle", con)
                            i = cmd.ExecuteScalar
                            cmd.Dispose()
                            If i >= 1 Then
                                cmd = New OleDb.OleDbCommand("select max(VBookId) from  Enq_Cust_Vehicle", con)
                                ord = cmd.ExecuteReader
                                If ord.Read Then
                                    VbookId = ord(0)
                                End If
                                cmd.Dispose()
                                ord.Close()
                                VbookId = VbookId + 1
                            Else
                                VbookId = 1
                            End If
                            If cob_vpayment.Text = "" Then
                                cob_vpayment.Text = "We"
                            End If
                            'updating Enq_cust_Vehicle table 
                            cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Vehicle values(" & VbookId & ",'" & cuid & "','" & bi & "','" & tstr & "','" & dt3.Rows(z).Item(0) & "','" & dt3.Rows(z).Item(1) & "','" & dt3.Rows(z).Item(2) & "','" & dt3.Rows(z).Item(3) & "'," & diffdays & "," & CInt(qstr) & "," & am & ",'Y','" & cob_vpayment.Text & "','" & dt3.Rows(z).Item(6) & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If

                        If cob_status.Text = "Confirm" Then
                            'generating vehicle booking id 
                            cmd = New OleDb.OleDbCommand("select count(*) from Cust_Vehicle", con)
                            i = cmd.ExecuteScalar
                            cmd.Dispose()
                            If i >= 1 Then
                                cmd = New OleDb.OleDbCommand("select max(VbookId) from Cust_Vehicle", con)
                                ord = cmd.ExecuteReader
                                If ord.Read Then
                                    VbookId = ord(0)
                                    VbookId = VbookId + 1
                                End If
                                cmd.Dispose()
                                ord.Close()
                            Else
                                VbookId = 1
                            End If
                            If cob_payment.Text = "" Then
                                cob_payment.Text = "We"
                            End If
                            'updating cust_vehicle table 
                            cmd = New OleDb.OleDbCommand("insert into Cust_Vehicle values(" & VbookId & ",'" & cuid & "','" & bi & "','" & tstr & "','" & dt3.Rows(z).Item(0) & "','" & dt3.Rows(z).Item(1) & "','" & dt3.Rows(z).Item(2) & "','" & dt3.Rows(z).Item(3) & "'," & diffdays & "," & CInt(qstr) & "," & am & ",'Y','" & cob_vpayment.Text & "','" & dt3.Rows(z).Item(6) & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','Y','')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                    End While
                Next

                '****************************************************************************************************
                '                ************* Activity Booking Number ******************
act:
                Dim AbookId As Integer
                rc = dt5.Rows.Count
                If rc = 0 Then
                    GoTo endsave
                End If
                For z As Integer = 0 To rc - 1
                    Dim actid, Ratetype As String
                    Dim unit As Integer
                    Dim eamt, rad, rjr, rch As Integer
                    actid = dt5.Rows(z).Item(0)
                    i = InStr(actid, "-")
                    actid = Mid(actid, 1, i - 1)
                    cmd = New OleDb.OleDbCommand("select Rate_Type,unit,RackRate_Adult,RackRate_Juni,RackRate_Child from Activity where Activ_Id='" & actid & "'", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        Ratetype = ord(0)
                        unit = ord(1)
                        rad = ord(2)
                        rjr = ord(3)
                        rch = ord(4)
                    End If
                    ord.Close()
                    cmd.Dispose()
                    Dim cmts As String = DataGrid6.Item(z, 6)
                    eamt = (rad * Val(DataGrid6.Item(z, 3))) + (rjr * Val(DataGrid6.Item(z, 4))) + (rch * Val(DataGrid6.Item(z, 5)))
                    amount = amount + eamt
                    Dim nopersons As Integer = Val(DataGrid6.Item(z, 3)) + Val(DataGrid6.Item(z, 4)) + Val(DataGrid6.Item(z, 5))
                    If cob_status.Text = "Quotation" Then
                        'generating Activity booking id 
                        cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Activity", con)
                        i = cmd.ExecuteScalar
                        cmd.Dispose()
                        If i >= 1 Then
                            cmd = New OleDb.OleDbCommand("select max(ABookId) from  Enq_Cust_Activity", con)
                            ord = cmd.ExecuteReader
                            If ord.Read Then
                                AbookId = ord(0)
                            End If
                            cmd.Dispose()
                            ord.Close()
                            AbookId = AbookId + 1
                        Else
                            AbookId = 1
                        End If


                        cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Activity values(" & AbookId & ",'" & cuid & "','" & bi & "','" & actid & "'," & nopersons & "," & Val(DataGrid6.Item(z, 3)) & "," & Val(DataGrid6.Item(z, 4)) & "," & Val(DataGrid6.Item(z, 5)) & ",'" & dt5.Rows(z).Item(1) & "','" & Ratetype & "','" & dt5.Rows(z).Item(2) & "'," & rad & "," & rjr & "," & rch & "," & eamt & ",'" & DataGrid6.Item(z, 7) & "','" & cmts & "','" & Muserid & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N',' ')", con)
                        cmd.ExecuteNonQuery()

                    End If



                    If cob_status.Text = "Confirm" Then
                        'generating Activity booking id 
                        cmd = New OleDb.OleDbCommand("select count(*) from Cust_Activity", con)
                        i = cmd.ExecuteScalar
                        cmd.Dispose()
                        If i >= 1 Then
                            cmd = New OleDb.OleDbCommand("select max(ABookId) from  Cust_Activity", con)
                            ord = cmd.ExecuteReader
                            If ord.Read Then
                                AbookId = ord(0)
                            End If
                            cmd.Dispose()
                            ord.Close()
                            AbookId = AbookId + 1
                        Else
                            AbookId = 1
                        End If
                        cmd = New OleDb.OleDbCommand("insert into Cust_Activity values(" & AbookId & ",'" & cuid & "','" & bi & "','" & actid & "'," & nopersons & "," & Val(DataGrid6.Item(z, 3)) & "," & Val(DataGrid6.Item(z, 4)) & "," & Val(DataGrid6.Item(z, 5)) & ",'" & dt5.Rows(z).Item(1) & "','" & Ratetype & "'," & Val(dt5.Rows(z).Item(2)) & "," & rad & "," & rjr & "," & rch & "," & eamt & ",'" & DataGrid6.Item(z, 7) & "','" & cmts & "','" & Muserid & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N',' ')", con)
                        cmd.ExecuteNonQuery()
                    End If
                Next

endsave:
                If txt_adults.Text = "" Then
                    txt_adults.Text = "0"
                End If
                If Txt_Juniors.Text = "" Then
                    Txt_Juniors.Text = "0"
                End If
                If txt_childs.Text = "" Then
                    txt_childs.Text = "0"
                End If
                If txt_infants.Text = "" Then
                    txt_infants.Text = "0"
                End If
                If txt_edic.Text = "" Then
                    txt_edic.Text = "0"
                End If
                If txt_ac.Text = "" Then
                    txt_ac.Text = "0"
                End If
                na = Int((amount * Val(txt_edic.Text)) / 100)
                If cob_status.Text = "Quotation" Then
                    cmd = New OleDb.OleDbCommand("insert into Enq_Booking_Itinary values(" & Sysrefno & ",'" & bi & "','" & cuid & "','Custom','" & dtpbd.Text & "','" & dtpsd.Text & "','" & dtped.Text & "','" & agtid & "','" & txt_gname.Text & "'," & Val(txt_adults.Text) & "," & Val(Txt_Juniors.Text) & "," & Val(txt_childs.Text) & "," & Val(txt_infants.Text) & "," & amount & "," & Int(Val(txt_pp.Text)) & "," & Val(txt_edic.Text) & "," & na & "," & Val(txt_ac.Text) & ",'Y','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "',' ')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
                If cob_status.Text = "Confirm" Then
                    cmd = New OleDb.OleDbCommand("insert into Booking_Itinary values(" & Sysrefno & ",'" & bi & "','" & cuid & "','Custom','" & dtpbd.Text & "','" & dtpsd.Text & "','" & dtped.Text & "','" & agtid & "','" & txt_gname.Text & "'," & Val(txt_adults.Text) & "," & Val(Txt_Juniors.Text) & "," & Val(txt_childs.Text) & "," & Val(txt_infants.Text) & "," & amount & "," & Int(CInt(txt_pp.Text)) & "," & CInt(txt_edic.Text) & "," & na & "," & CInt(txt_ac.Text) & ",'Y','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "',' ','" & FormatDateTime(Now, DateFormat.GeneralDate) & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
                con.Close()
                ds.Clear()
                clearproc()
                MsgSav()
        End If

    End Sub
    Public Sub clearproc()
        Dim x As Object
        For Each x In Me.GroupBox5.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
            If TypeOf (x) Is ComboBox Then
                x.text = ""
            End If
        Next
        For Each x In Me.GroupBox3.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
        Next
        For Each x In Me.GroupBox10.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
        Next
    End Sub
    Public Sub editproc()
        recmode = Module1.EnuRecstatus.Recedit
    End Sub
    Public Sub newproc()
        recmode = Module1.EnuRecstatus.Recnew
        clearproc()
        enable()
    End Sub
    Public Sub enable()
        Dim x As Object
        For Each x In Me.GroupBox5.Controls
            If TypeOf (x) Is TextBox Then
                x.Enabled = True
            End If
            If TypeOf (x) Is ComboBox Then
                x.Enabled = True
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.Enabled = True
            End If
            If TypeOf (x) Is Button Then
                x.Enabled = True
            End If
        Next
        For Each x In Me.GroupBox3.Controls
            If TypeOf (x) Is TextBox Then
                x.Enabled = True
            End If
        Next
        For Each x In Me.GroupBox10.Controls
            If TypeOf (x) Is TextBox Then
                x.Enabled = True
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.Enabled = True
            End If
            If TypeOf (x) Is ComboBox Then
                x.Enabled = True
            End If
        Next
    End Sub
    Public Sub disable()
        Dim x As Object
        For Each x In Me.GroupBox5.Controls
            If TypeOf (x) Is TextBox Then
                x.Enabled = False
            End If
            If TypeOf (x) Is ComboBox Then
                x.Enabled = False
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.Enabled = False
            End If
            If TypeOf (x) Is Button Then
                x.Enabled = False
            End If
        Next
        For Each x In Me.GroupBox3.Controls
            If TypeOf (x) Is TextBox Then
                x.Enabled = False
            End If
        Next
        For Each x In Me.GroupBox10.Controls
            If TypeOf (x) Is TextBox Then
                x.Enabled = False
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.Enabled = False
            End If
            If TypeOf (x) Is ComboBox Then
                x.Enabled = False
            End If
        Next
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub cob_child_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_child.SelectedIndexChanged
        'this combo is to select Shared,Own,None Rooms for child 

        dt.Rows(rid).Item(4) = cob_child.Text
        dt.Rows(rid).AcceptChanges()
        GroupBox4.Visible = False
    End Sub

    Private Sub cob_payment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_payment.SelectedIndexChanged
        'payment of hotel is selected using this combo box
        dt.Rows(rid).Item(7) = cob_payment.Text
        dt.Rows(rid).AcceptChanges()
        GroupBox6.Visible = False
    End Sub

    Private Sub TabControl2_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.TabIndexChanged, TabControl2.Click
        'when vehicle booking is selected
        If TabControl2.SelectedTab Is TabVeh Then

            If DataGrid2.VisibleRowCount < 2 Then
                Dim dt_sdate As Date
                Dim dt_edate As Date
                dt_sdate = FormatDateTime(dtpsd.Text, DateFormat.ShortDate)
                dt_sdate = DateAdd(DateInterval.Day, -1, dt_sdate)
                dtpdate.MinDate = dt_sdate
                dt_edate = FormatDateTime(dtped.Text, DateFormat.ShortDate)
                dt_edate = DateAdd(DateInterval.Day, 1, dt_edate)
                dtpdate.MaxDate = dt_edate
                dr = dt3.NewRow
                dr(0) = " "
                dr(1) = " "
                dr(2) = " "
                dr(3) = " "
                dr(4) = " "
                dr(5) = " "
                dr(6) = " "
                dr(7) = "Next Booking"
                dt3.Rows.Add(dr)
                DataGrid2.DataSource = ds.Tables("veh")
            End If
        End If
        If TabControl2.SelectedTab Is TabActiv Then
            Openconnection()
            If cob_act.Items.Count >= 1 Then
                cob_act.Items.Clear()
                cmd = New OleDb.OleDbCommand("select Activ_ID,Activity from Activity", con)
                ord = cmd.ExecuteReader
                While ord.Read
                    cob_act.Items.Add(ord(0) + "-" + ord(1))
                End While
                ord.Close()
                cmd.Dispose()
                con.Close()
            Else
                cmd = New OleDb.OleDbCommand("select Activ_ID,Activity from Activity", con)
                ord = cmd.ExecuteReader
                While ord.Read
                    cob_act.Items.Add(ord(0) + "-" + ord(1))
                End While
                ord.Close()
                cmd.Dispose()
                con.Close()
            End If
        End If
    End Sub

    Private Sub DataGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.Click, DataGrid2.CurrentCellChanged
        Try
            vcid = DataGrid2.CurrentCell.ColumnNumber
            vrid = DataGrid2.CurrentCell.RowNumber
            If vcid = 0 Then
                'from date column
                GroupBox8.Top = DataGrid2.Top + DataGrid2.GetCurrentCellBounds.Top
                GroupBox8.Left = DataGrid2.Left + DataGrid2.GetCurrentCellBounds.Left
                GroupBox8.Height = DataGrid2.GetCurrentCellBounds.Height
                GroupBox8.Width = DataGrid2.GetCurrentCellBounds.Width
                dtpdate.Height = DataGrid2.GetCurrentCellBounds.Height
                dtpdate.Width = DataGrid1.GetCurrentCellBounds.Width
                GroupBox8.Visible = True
            End If
            If vcid = 1 Then
                'from time column
                dt3.Rows(vrid).Item(vcid - 1) = dtpdate.Text
                dt3.AcceptChanges()
                GroupBox8.Visible = False
                GroupBox7.Top = DataGrid2.Top + DataGrid2.GetCurrentCellBounds.Top
                GroupBox7.Left = DataGrid2.Left + DataGrid2.GetCurrentCellBounds.Left
                GroupBox7.Height = DataGrid2.GetCurrentCellBounds.Height
                GroupBox7.Width = DataGrid2.GetCurrentCellBounds.Width
                dtptime.Height = DataGrid2.GetCurrentCellBounds.Height
                dtptime.Width = DataGrid1.GetCurrentCellBounds.Width
                GroupBox7.Visible = True
            End If
            If vcid = 2 Then
                'to date column
                dt3.Rows(vrid).Item(vcid - 1) = dtptime.Text
                dt3.AcceptChanges()
                GroupBox7.Visible = False
                GroupBox8.Top = DataGrid2.Top + DataGrid2.GetCurrentCellBounds.Top
                GroupBox8.Left = DataGrid2.Left + DataGrid2.GetCurrentCellBounds.Left
                GroupBox8.Height = DataGrid2.GetCurrentCellBounds.Height
                GroupBox8.Width = DataGrid2.GetCurrentCellBounds.Width
                dtpdate.Height = DataGrid2.GetCurrentCellBounds.Height
                dtpdate.Width = DataGrid1.GetCurrentCellBounds.Width
                GroupBox8.Visible = True
            End If
            If vcid = 3 Then
                'to time column
                dt3.Rows(vrid).Item(vcid - 1) = dtpdate.Text
                dt3.AcceptChanges()
                GroupBox8.Visible = False
                GroupBox7.Top = DataGrid2.Top + DataGrid2.GetCurrentCellBounds.Top
                GroupBox7.Left = DataGrid2.Left + DataGrid2.GetCurrentCellBounds.Left
                GroupBox7.Height = DataGrid2.GetCurrentCellBounds.Height
                GroupBox7.Width = DataGrid2.GetCurrentCellBounds.Width
                dtptime.Height = DataGrid2.GetCurrentCellBounds.Height
                dtptime.Width = DataGrid1.GetCurrentCellBounds.Width
                GroupBox7.Visible = True
            End If
            If vcid = 4 Then
                'vehicle tariff column
                dt3.Rows(vrid).Item(vcid - 1) = dtptime.Text
                dt3.AcceptChanges()
                GroupBox7.Visible = False
                cob_vtype.Items.Clear()
                Openconnection()
                cmd = New OleDb.OleDbCommand("select VehType from Veh_Type", con)
                ord = cmd.ExecuteReader
                While ord.Read
                    cob_vtype.Items.Add(ord(0))
                End While
                cmd.Dispose()
                ord.Close()
                con.Close()
                'clearing previous data in data table (veh type)
                If DataGrid5.VisibleRowCount > 1 Then
                    dt4.Clear()
                End If
                GroupBox9.Visible = True
            End If
            If vcid = 5 Then
                'payment column
                GroupBox11.Top = DataGrid2.Top + DataGrid2.GetCurrentCellBounds.Top
                GroupBox11.Left = DataGrid2.Left + DataGrid2.GetCurrentCellBounds.Left
                GroupBox11.Height = DataGrid2.GetCurrentCellBounds.Height
                GroupBox11.Width = DataGrid2.GetCurrentCellBounds.Width
                cob_vpayment.Height = DataGrid2.GetCurrentCellBounds.Height
                cob_vpayment.Width = DataGrid2.GetCurrentCellBounds.Width
                GroupBox11.Visible = True
            End If
            If vcid = 7 Then
                'Dim yesno As DialogResult
                If MsgBox("want to book  another vehicle ", MsgBoxStyle.YesNo, Prjtitle) = MsgBoxResult.Yes Then
                    If DataGrid2.Item(vrid, vcid - 3) = " " Then
                        MsgBox("select vehicle for the date entered")
                    Else
                        Dim dt_sdate As Date
                        Dim dt_edate As Date
                        dt_sdate = FormatDateTime(dtpsd.Text, DateFormat.ShortDate)
                        dt_sdate = DateAdd(DateInterval.Day, -1, dt_sdate)
                        dtpdate.MinDate = dt_sdate
                        dt_edate = FormatDateTime(dtped.Text, DateFormat.ShortDate)
                        dt_edate = DateAdd(DateInterval.Day, 1, dt_edate)
                        dtpdate.MaxDate = dt_edate
                        dr = dt3.NewRow
                        dr(0) = " "
                        dr(1) = " "
                        dr(2) = " "
                        dr(3) = " "
                        dr(4) = " "
                        dr(5) = " "
                        dr(6) = " "
                        dr(7) = "Next Booking"
                        dt3.Rows.Add(dr)
                        DataGrid2.DataSource = ds.Tables("veh")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cob_vtype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_vtype.SelectedIndexChanged
        'clearing previous data in data table (veh type)
        If DataGrid5.VisibleRowCount > 1 Then
            dt4.Clear()
        End If
        'creating data table for vehicle type
        Openconnection()
        cmd = New OleDb.OleDbCommand("select Tariffcode, Drive, Rack_Base_Price, Rack_Kilometers, Rack_Hours, Rack_Extra_KmRate  from Veh_Tariff vt ,Veh_Type ty where vt.VehTypeId = ty.VehTypeId and ty.VehType ='" & cob_vtype.Text & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            dr = dt4.NewRow
            dr(0) = ord(0)
            dr(1) = ord(1)
            dr(2) = ord(2)
            dr(3) = ord(3)
            dr(4) = ord(4)
            dr(5) = ord(5)
            dr(6) = " "
            dt4.Rows.Add(dr)
        End While
        cmd.Dispose()
        ord.Close()
        con.Close()
        DataGrid5.DataSource = ds
        DataGrid5.DataMember = "veh-type"
    End Sub

    Private Sub cmd_vcac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vcac.Click
        'clearing previous data in data table (veh type)
        If DataGrid5.VisibleRowCount > 1 Then
            dt4.Clear()
        End If
        GroupBox9.Visible = False
    End Sub

    Private Sub cmd_vupd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vupd.Click
        Dim str As String
        Dim i As Integer

        Dim ramount As Integer = 0

        'when update button clicked this procedure will concatinate the tariffcode and qty of the Vehicle and 
        ' update in vehicle Booking data table 
        i = dt4.Rows.Count
        For j As Integer = 0 To i - 1

            If dt4.Rows(j).Item(6) = " " Or dt4.Rows(j).Item(6) = "" Then
                MsgBox("Quantity should only be number", MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            Else
                Try
                    Dim testint As Integer
                    testint = CInt(dt4.Rows(j).Item(6))
                Catch ex As Exception
                    MsgBox(" Enter only NUMBERS in Quantity Column ", MsgBoxStyle.OKOnly, Prjtitle)
                    Exit Sub
                End Try
                If j < i - 1 Then
                    str = str + dt4.Rows(j).Item(0) + "-" + dt4.Rows(j).Item(6) + ","
                Else
                    str = str + dt4.Rows(j).Item(0) + "-" + dt4.Rows(j).Item(6)
                End If
            End If
        Next
        str = cob_vtype.Text + "-" + str
        dt3.Rows(vrid).Item(4) = str
        dt3.AcceptChanges()
        GroupBox9.Visible = False
    End Sub

    Private Sub cob_vpayment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_vpayment.SelectedIndexChanged
        'payment mode for vehicle
        dt3.Rows(vrid).Item(vcid) = cob_vpayment.SelectedItem
        dt3.Rows(vrid).AcceptChanges()
        GroupBox11.Visible = False
    End Sub

    Private Sub cob_act_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_act.SelectedIndexChanged
        If actbook = "y" Then

            Dim str As String
            Dim i As Integer
            str = cob_act.SelectedItem
            i = InStr(str, "-")
            str = Mid(str, 1, i - 1)
            dad = New OleDb.OleDbDataAdapter("select A.Activity,l.Location, A.Rate_Type,A.Unit,A.RackRate_Adult,A.RackRate_Juni,A.RackRate_Child,A.Descript from Activity A,LocationMaster l where A.Activ_ID='" & str & "' and A.locationid = l.locationid", con)
            dad.Fill(ds, "actview")
            DataGrid7.DataSource = ds.Tables("actview")
            GroupBox12.Visible = True
        End If
        If actbook = "n" Then
            MsgBox(" CLICK ON NEXT BOOKING", MsgBoxStyle.OKOnly, Prjtitle)
        End If
        actbook = "n"
    End Sub

    Private Sub DataGrid6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid6.Click, DataGrid6.CurrentCellChanged
        acid = DataGrid6.CurrentCell.ColumnNumber
        arid = DataGrid6.CurrentCell.RowNumber
        Dim i As Integer
        Dim str As String

        str = cob_act.Text
        i = InStr(str, "-")
        str = Mid(str, 1, i - 1)
        If acid = 1 Then
            'to select activity date
            GroupBox14.Top = DataGrid6.Top + DataGrid6.GetCurrentCellBounds.Top
            GroupBox14.Left = DataGrid6.Left + DataGrid6.GetCurrentCellBounds.Left
            GroupBox14.Height = DataGrid6.GetCurrentCellBounds.Height
            GroupBox14.Width = DataGrid6.GetCurrentCellBounds.Width
            dtp_act.Height = DataGrid6.GetCurrentCellBounds.Height
            dtp_act.Width = DataGrid6.GetCurrentCellBounds.Width
            GroupBox14.Visible = True
        End If
        If acid = 2 Then
            dt5.Rows(arid).Item(1) = FormatDateTime(dtp_act.Text, DateFormat.ShortDate)
            dt5.AcceptChanges()


            ' to select number of hours or days

            GroupBox14.Visible = False
            Dim type As String
            Openconnection()
            cmd = New OleDb.OleDbCommand("select Rate_Type from Activity where Activ_ID='" & str & "'", con)
            type = cmd.ExecuteScalar
            cmd.Dispose()
            con.Close()
            MsgBox("Enter Number of " & type, MsgBoxStyle.OKOnly, Prjtitle)
        End If
        If acid = 3 Then
            ' validating entered hours or days in previous column are integers or not  
            Dim int1 As Integer
            If DataGrid6.Item(arid, 2) = "" Or DataGrid6.Item(arid, 2) = " " Then

            Else
                Try
                    int1 = CInt(DataGrid6.Item(arid, 2))
                Catch ex As Exception
                    MsgBox(" Enter only numbers at Hours/Days column", MsgBoxStyle.OKOnly, Prjtitle)
                    Exit Sub
                End Try
            End If
        End If

        If acid = 4 Then
            ' validating no of adults in previous column are integers or not  
            Dim int1 As Integer
            If DataGrid6.Item(arid, 3) = "" Or DataGrid6.Item(arid, 3) = " " Then

            Else
                Try
                    int1 = CInt(DataGrid6.Item(arid, 3))
                Catch ex As Exception
                    MsgBox(" Enter only numbers at No Adults column", MsgBoxStyle.OKOnly, Prjtitle)
                    Exit Sub
                End Try
            End If
        End If
        If acid = 5 Then

            ' validating no of juniors in previous column are integers or not  
            Dim int1 As Integer
            If DataGrid6.Item(arid, 4) = "" Or DataGrid6.Item(arid, 4) = " " Then

            Else
                Try
                    int1 = CInt(DataGrid6.Item(arid, 4))
                Catch ex As Exception
                    MsgBox(" Enter only numbers at No Juniors column", MsgBoxStyle.OKOnly, Prjtitle)
                    Exit Sub
                End Try
            End If
        End If
        If acid = 6 Then

            ' validating no childs in previous column are integers or not  
            Dim int1 As Integer
            If DataGrid6.Item(arid, 5) = "" Or DataGrid6.Item(arid, 5) = " " Then

            Else
                Try
                    int1 = CInt(DataGrid6.Item(arid, 5))
                Catch ex As Exception
                    MsgBox(" Enter only numbers at No children column", MsgBoxStyle.OKOnly, Prjtitle)
                    Exit Sub
                End Try
            End If

            ' calculating the amount for the activity selected for adults,children,juniors
            Dim unit As Integer
            Dim arate, jrate, crate As Integer
            Dim nad, najr, nach, total As Integer
            Dim nu As Integer
            dt5.Rows(arid).Item(2) = DataGrid6.Item(arid, 2)
            dt5.Rows(arid).Item(3) = DataGrid6.Item(arid, 3)
            Openconnection()
            cmd = New OleDb.OleDbCommand("select unit,RackRate_Adult,RackRate_Juni,RackRate_Child from Activity where Activ_ID='" & str & "'", con)
            ord = cmd.ExecuteReader
            If ord.Read Then
                unit = ord(0)
                arate = ord(1)
                jrate = ord(2)
                crate = ord(3)
            End If
            ord.Close()
            cmd.Dispose()
            con.Close()

            nu = (DataGrid6.Item(arid, 2) / unit)
            nu = CStr(nu)
            i = InStr(nu, ".")
            If i >= 1 Then
                nu = Int(nu)
                nu = nu + 1
            Else
                nu = Int(nu)
            End If
            nad = nu * arate
            najr = nu * jrate
            nach = nu * crate
            total = nad + najr + nach
            dt5.Rows(arid).Item(6) = total
            dt5.AcceptChanges()
        End If
        If acid = 7 Then
            ' selecting payment mode for activity
            GroupBox13.Top = DataGrid6.Top + DataGrid6.GetCurrentCellBounds.Top
            GroupBox13.Left = DataGrid6.Left + DataGrid6.GetCurrentCellBounds.Left
            GroupBox13.Height = DataGrid6.GetCurrentCellBounds.Height
            GroupBox13.Width = DataGrid6.GetCurrentCellBounds.Width
            cob_apayment.Height = DataGrid6.GetCurrentCellBounds.Height
            cob_apayment.Width = DataGrid6.GetCurrentCellBounds.Width
            GroupBox13.Visible = True
        End If
        If acid = 9 And arid = DataGrid6.VisibleRowCount - 2 Then
            If DataGrid6.Item(arid, 1) = " " Or DataGrid6.Item(arid, 2) = " " Or DataGrid6.Item(arid, 3) = " " Then
                MsgBox("Enter All Details for Current Activity", MsgBoxStyle.OKOnly, Prjtitle)
            Else
                actbook = "y"
                MsgBox("Select Another Activity", MsgBoxStyle.OKOnly, Prjtitle)
            End If
        End If
    End Sub

    Private Sub cmd_Acancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Acancel.Click
        GroupBox12.Visible = False
        actbook = "y"
        ds.Tables("actview").Clear()
    End Sub

    Private Sub cmd_AUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AUpdate.Click
        dr = dt5.NewRow
        dr(0) = cob_act.Text
        dr(1) = " "
        dr(2) = " "
        dr(3) = " "
        dr(4) = " "
        dr(5) = " "
        dr(6) = " "
        dr(7) = " "
        dr(8) = " "
        dr(9) = "Next Booking"
        dt5.Rows.Add(dr)
        GroupBox12.Visible = False
        DataGrid6.DataSource = ds.Tables("Act")
        ds.Tables("actview").Clear()
    End Sub

    Private Sub cob_apayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cob_apayment.SelectedIndexChanged
        dt5.Rows(arid).Item(acid) = cob_apayment.SelectedItem
        dt5.Rows(arid).AcceptChanges()
        GroupBox13.Visible = False
    End Sub

    '*****************************************************************************************

    '***************************           VIEW           ****************************

    Dim vhotel As String
    Dim vhno As Integer
    Dim vvehicle As String
    Dim vvno As Integer
    Dim vactivity As String
    Dim vano As Integer
    Dim vsdate As Date
    Dim vedate As Date


    Private Sub cmd_vsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vsearch.Click
        If cob_vstatus.Text = "" Then
            MsgBox(" select the status ", MsgBoxStyle.OKOnly, Prjtitle)
            cob_vstatus.Focus()
            Exit Sub
        End If

        If txt_bid.Text = "" Then
            If cob_vstatus.Text = "Quotation" Then

                dad = New OleDb.OleDbDataAdapter("select Distinct(e.BookingId),e.custid,c.Fname,c.Lname,e.stdate,e.Enddate from Enq_Booking_Itinary e,Cust_Master c where e.custid = c.custid and e.stdate between #" & dtpvfd.Text & "# and #" & dtpvtd.Text & "#", con)
                dad.Fill(ds, "vsearch")
                DataGrid8.DataSource = ds.Tables("vsearch")
                GroupBox15.Visible = True
            End If
            If cob_vstatus.Text = "Confirm" Then

                dad = New OleDb.OleDbDataAdapter("select Distinct(e.BookingId),e.custid,c.Fname,c.Lname,e.stdate,e.Enddate from Booking_Itinary e,Cust_Master c where e.custid = c.custid and e.stdate between #" & dtpvfd.Text & "# and #" & dtpvtd.Text & "#", con)
                dad.Fill(ds, "vsearch")
                DataGrid8.DataSource = ds.Tables("vsearch")
                GroupBox15.Visible = True
            End If
        Else
            If cob_vstatus.Text = "Quotation" Then
                dad = New OleDb.OleDbDataAdapter("select Distinct(e.BookingId),e.custid,c.Fname,c.Lname,e.stdate,e.Enddate from Enq_Booking_Itinary e,Cust_Master c where e.custid = c.custid and e.BookingId Like '" & "%" & txt_bid.Text & "%" & "'", con)
                dad.Fill(ds, "vsearch")
                DataGrid8.DataSource = ds.Tables("vsearch")
                GroupBox15.Visible = True
            End If
            If cob_vstatus.Text = "Confirm" Then
                dad = New OleDb.OleDbDataAdapter("select Distinct(e.BookingId),e.custid,c.Fname,e.Lname,c.stdate,e.Enddate from Enq_Booking_Itinary e,Cust_Master c where e.custid = c.custid and e.BookingId Like '" & "%" & txt_bid.Text & "%" & "'", con)
                dad.Fill(ds, "vsearch")
                DataGrid8.DataSource = ds.Tables("vsearch")
                GroupBox15.Visible = True
            End If
        End If


    End Sub

    Private Sub cmd_vOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vOk.Click
        txt_bid.Text = DataGrid8.Item(DataGrid8.CurrentRowIndex, 0)
        viewfill()
        If ds.Tables("vsearch").Rows(0).Item(0) = "" Then
        Else
            ds.Tables("vsearch").Clear()
        End If
        If cob_vstatus.Text = "Quotation" Then
            cmd_Confirm.Visible = True
        End If
    End Sub

    Private Sub cmd_vcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vcan.Click
        GroupBox15.Visible = False

        If ds.Tables("vsearch").Rows.Count = 0 Then
        Else
            ds.Tables("vsearch").Clear()
        End If
    End Sub

    Private Sub cmd_EditHotel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EHotel.Click
        bookid = txt_bid.Text
        edit_item = "hotel"
        Dim frm As New Edit_Cust_Itenari_
        frm.ShowDialog()
        ds.Tables("view").Clear()
        viewfill()
    End Sub
    Private Sub cmd_eVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eVehicle.Click
        bookid = txt_bid.Text
        edit_item = "vehicle"
        Dim frm As New edit_cust_Veh
        frm.ShowDialog()
        ds.Tables("view").Clear()
        viewfill()
    End Sub
    Private Sub cmd_Confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Confirm.Click
        Dim bid As String
        bid = txt_bid.Text
        Dim tbid As String
        Dim i, am, HBookId, rc As Integer
        am = 0
        tbid = Mid(bid, 2)
        tbid = "C" + tbid

        rc = DataGrid9.VisibleRowCount - 1
        Openconnection()
        cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel where BookingId='" & tbid & "'", con)
        i = cmd.ExecuteScalar
        cmd.Dispose()
        If i >= 1 Then
            MsgBox(" YOU HAVE ALREADY CONFIRMED THE QUOTATION", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        cmd = New OleDb.OleDbCommand("select Amount from Enq_Cust_Hotel where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            am = am + CInt(ord(0))
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("select Amount from Enq_Cust_Hotel_Child where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            am = am + CInt(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
        cmd = New OleDb.OleDbCommand("select Amount from Enq_Cust_Vehicle where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            am = am + CInt(ord(0))
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("select Total_Amt from Enq_Cust_Activity where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            am = am + CInt(ord(0))
        End While
        ord.Close()
        cmd.Dispose()


        Dim cuid, tid(50), pay(50), cmts(50), HId(50) As String
        Dim qty(50), amt(50) As Integer
        Dim occ_date(50), od As Date
        i = 0
        cmd = New OleDb.OleDbCommand("select CustId,TransId,Quanti,Occ_Date,Amount,PaymentBy,Comments,HotelId from Enq_Cust_Hotel where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cuid = ord(0)
            tid(i) = ord(1)
            qty(i) = ord(2)
            od = ord(3)
            amt(i) = ord(4)
            pay(i) = ord(5)
            cmts(i) = ord(6)
            HId(i) = ord(7)
            occ_date(i) = FormatDateTime(od, DateFormat.ShortDate)
            i = i + 1
        End While
        cmd.Dispose()
        ord.Close()
        Dim j As Integer


        For x As Integer = 0 To i - 1
            'generating hotel booking id 
            cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel", con)
            j = cmd.ExecuteScalar
            cmd.Dispose()
            If j >= 1 Then
                cmd = New OleDb.OleDbCommand("select max(HBookId) from Cust_Hotel", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    HBookId = ord(0)
                    HBookId = HBookId + 1
                End If
                cmd.Dispose()
                ord.Close()
            Else
                HBookId = 1
            End If
            'updating cust_hotel table 

            cmd = New OleDb.OleDbCommand("insert into Cust_Hotel values(" & HBookId & ",'" & cuid & "','" & tbid & "'," & CInt(tid(x)) & "," & qty(x) & ",'" & occ_date(x) & "'," & amt(x) & ",'Confirm','" & pay(x) & "','" & cmts(x) & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N',' ','" & HId(x) & "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next

        '**********************       updating Hotel_child   *************************************


        cmd = New OleDb.OleDbCommand("select CustId,CTransId,Quanti,Occ_Date,Amount,HotelId,PaymentBy from Enq_Cust_Hotel_Child where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader
        i = 0
        While ord.Read
            cuid = ord(0)
            tid(i) = ord(1)
            qty(i) = ord(2)
            od = ord(3)
            amt(i) = ord(4)
            HId(i) = ord(5)
            pay(i) = ord(6)
            occ_date(i) = FormatDateTime(od, DateFormat.ShortDate)
            i = i + 1
        End While
        cmd.Dispose()
        ord.Close()

        For x As Integer = 0 To i - 1
            Dim HCBookId As Integer
            cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel_Child", con)
            j = cmd.ExecuteScalar
            cmd.Dispose()
            If j >= 1 Then
                cmd = New OleDb.OleDbCommand("select max(HCBookId) from Cust_Hotel_Child", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    HCBookId = ord(0)
                    HCBookId = HCBookId + 1
                End If
                cmd.Dispose()
                ord.Close()
            Else
                HCBookId = 1
            End If
            cmd = New OleDb.OleDbCommand("insert into Cust_Hotel_Child values(" & HCBookId & ",'" & cuid & "','" & tbid & "'," & CInt(tid(x)) & "," & qty(x) & ",'" & occ_date(x) & "'," & amt(x) & ",'Confirm','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N',' ','" & HId(x) & "','" & pay(x) & "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next



        '*********************************** vehicle *********************************************


        Dim tc(50) As String
        Dim fd(50), td(50), ft(50), tt(50), temp As Date
        Dim days(50), nov(50) As Integer
        cmd = New OleDb.OleDbCommand("select Tariffcode,FromDt,FromTime,ToDt,ToTime,Days,NoOfVeh,Amount,PaymentBy,Comments from Enq_Cust_Vehicle where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader
        i = 0
        While ord.Read
            tc(i) = ord(0)
            temp = ord(1)
            fd(i) = FormatDateTime(temp, DateFormat.ShortDate)
            temp = ord(2)
            ft(i) = FormatDateTime(temp, DateFormat.ShortTime)
            temp = ord(3)
            td(i) = FormatDateTime(temp, DateFormat.ShortDate)
            temp = ord(4)
            tt(i) = FormatDateTime(temp, DateFormat.ShortTime)
            days(i) = ord(5)
            nov(i) = ord(6)
            amt(i) = ord(7)
            pay(i) = ord(8)
            cmts(i) = ord(9)
            i = i + 1
        End While
        cmd.Dispose()
        ord.Close()

        Dim VbookId As Integer
        For x As Integer = 0 To i - 1
            cmd = New OleDb.OleDbCommand("select count(*) from Cust_Vehicle", con)
            j = cmd.ExecuteScalar
            cmd.Dispose()
            If j >= 1 Then
                cmd = New OleDb.OleDbCommand("select max(VbookId) from Cust_Vehicle", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    VbookId = ord(0)
                    VbookId = VbookId + 1
                End If
                cmd.Dispose()
                ord.Close()
            Else
                VbookId = 1
            End If
            Try
                'updating cust_vehicle table 
                cmd = New OleDb.OleDbCommand("insert into Cust_Vehicle values(" & VbookId & ",'" & cuid & "','" & tbid & "','" & tc(x) & "','" & fd(x) & "','" & ft(x) & "','" & td(x) & "','" & tt(x) & "'," & days(x) & "," & nov(x) & "," & amt(x) & ",'Y','" & pay(x) & "','" & cmts(x) & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N',' ')", con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            cmd.Dispose()
        Next


        '******************************************  Activity *************************************************

        Dim AbookId As Integer
        Dim ai(50), hd(50) As String
        Dim ad1, ad(50) As Date
        Dim npers(50), unit(50), tamt(50), adult(50), jr(50), ch(50), arate(50), jrate(50), crate(50) As Integer
        i = 0

        cmd = New OleDb.OleDbCommand("select Activ_ID,Noof_Pax,Adults,Junior,Children,Acti_Date,Rate_Type,Unit,Adult_Rate,Junior_Rate,Child_Rate,Total_Amt,PaymentBy,Comments from Enq_Cust_Activity where BookingId='" & bid & "'", con)
        ord = cmd.ExecuteReader


        While ord.Read
            ai(i) = ord(0)
            npers(i) = ord(1)
            adult(i) = ord(2)
            jr(i) = ord(3)
            ch(i) = ord(4)
            ad1 = ord(5)
            ad(i) = FormatDateTime(ad1, DateFormat.ShortDate)
            hd(i) = ord(6)
            unit(i) = ord(7)
            arate(i) = ord(8)
            jrate(i) = ord(9)
            crate(i) = ord(10)
            tamt(i) = ord(11)
            pay(i) = ord(12)
            cmts(i) = ord(13)
            i = i + 1
        End While
        cmd.Dispose()
        ord.Close()

        For x As Integer = 0 To i - 1
            cmd = New OleDb.OleDbCommand("select count(*) from Cust_Activity", con)
            j = cmd.ExecuteScalar
            cmd.Dispose()
            If j >= 1 Then
                cmd = New OleDb.OleDbCommand("select max(ABookId) from  Cust_Activity", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    AbookId = ord(0)
                End If
                cmd.Dispose()
                ord.Close()
                AbookId = AbookId + 1
            Else
                AbookId = 1
            End If

            cmd = New OleDb.OleDbCommand("insert into Cust_Activity values(" & AbookId & ",'" & cuid & "','" & tbid & "','" & ai(x) & "'," & npers(x) & "," & adult(x) & "," & jr(x) & "," & ch(x) & ",'" & ad(x) & "','" & hd(x) & "'," & unit(x) & "," & arate(x) & "," & jrate(x) & "," & crate(x) & ", " & tamt(x) & ",'" & pay(x) & "','" & cmts(x) & "','" & Muserid & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N',' ')", con)
            cmd.ExecuteNonQuery()
        Next

        MsgSav()
        con.Close()
    End Sub
    Public Sub viewfill()
        vdt.Clear()
        Dim tid As Integer
        Dim ctid As Integer
        Dim qty As Integer
        Dim cqty As Integer
        Dim hotel As String
        Dim tariffcade As String
        Dim actid As String
        Dim da As Date
        Dim diff As Integer
        Dim j As Integer
        Dim vcuid As String
        Dim vbid As String
        vbid = txt_bid.Text
        Openconnection()

        If cob_vstatus.Text = "Quotation" Then
            cmd = New OleDb.OleDbCommand("select CustId,StDate,EndDate from Enq_Booking_Itinary where BookingId='" & vbid & "'", con)
            ord = cmd.ExecuteReader
            If ord.Read Then
                vcuid = ord(0)
                vsdate = ord(1)
                vedate = ord(2)
            End If
            cmd.Dispose()
            ord.Close()
        End If
        If cob_vstatus.Text = "Confirm" Then
            cmd = New OleDb.OleDbCommand("select CustId,StDate,EndDate from Booking_Itinary where BookingId='" & vbid & "'", con)
            ord = cmd.ExecuteReader
            If ord.Read Then
                vcuid = ord(0)
                vsdate = ord(1)
                vedate = ord(2)
            End If
            cmd.Dispose()
            ord.Close()
        End If


        da = FormatDateTime(DateAdd(DateInterval.Day, -1, vsdate), DateFormat.ShortDate)
        diff = DateDiff(DateInterval.Day, vsdate, vedate)
        If cob_vstatus.Text = "Quotation" Then
            For i As Integer = 0 To diff + 2
                cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Hotel where BookingId='" & vbid & "' and Occ_Date = #" & da & "#", con)
                j = cmd.ExecuteScalar
                cmd.Dispose()
                If j >= 1 Then
                    cmd = New OleDb.OleDbCommand("select TransId,Quanti from Enq_Cust_Hotel where BookingId='" & vbid & "' and Occ_Date=#" & da & "# ", con)
                    ord = cmd.ExecuteReader
                    While ord.Read
                        tid = ord(0)
                        qty = ord(1)
                    End While
                    cmd.Dispose()
                    ord.Close()
                    cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Hotel_Child where BookingId='" & vbid & "' and Occ_Date = #" & da & "#", con)
                    j = cmd.ExecuteScalar
                    cmd.Dispose()
                    If j >= 1 Then
                        cmd = New OleDb.OleDbCommand("select CTransId,Quanti from Enq_Cust_Hotel_Child where BookingId='" & vbid & "' and Occ_date=#" & da & "#  ", con)
                        ord = cmd.ExecuteReader
                        While ord.Read
                            ctid = ord(0)
                            cqty = ord(1)
                        End While
                        cmd.Dispose()
                        ord.Close()
                    End If

                    cmd = New OleDb.OleDbCommand("select h.HotelName from HotelMaster h,Room_Tariff r where h.HotelId=r.HotelId and r.TransId=" & tid & "", con)
                    hotel = cmd.ExecuteScalar
                    cmd.Dispose()
                    qty = qty + cqty
                    vhotel = hotel
                    vhno = qty
                Else
                    vhotel = " "
                    vhno = 0
                End If
                cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Vehicle where  BookingId='" & vbid & "' and FromDt= #" & da & "#", con)
                j = cmd.ExecuteScalar
                cmd.Dispose()
                Dim tfcode As String
                If j >= 1 Then
                    cmd = New OleDb.OleDbCommand("select Tariffcode,Quanti from Enq_Cust_Vehicle where BookingId='" & vbid & "' and FromDt= #" & da & "#", con)
                    ord = cmd.ExecuteReader
                    While ord.Read
                        tfcode = ord(0)
                        vvno = ord(1)
                    End While
                    cmd.Dispose()
                    ord.Close()
                    cmd = New OleDb.OleDbCommand("select v.VehType from Veh_Type v, Veh_Tariff vt where vt.TariffCode='" & tfcode & "' and vt.VehTypeId=v.VehTypeId", con)
                    vvehicle = cmd.ExecuteScalar
                    cmd.Dispose()
                Else
                    vvehicle = " "
                    vvno = 0
                End If
                cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Activity where  BookingId='" & vbid & "' and Acti_Date =#" & da & "#", con)
                j = cmd.ExecuteScalar
                cmd.Dispose()
                If j >= 1 Then
                    cmd = New OleDb.OleDbCommand("select a.Activity,e.Noof_Pax from  Enq_Cust_Activity e,Activity a  where e.BookingId='" & vbid & "' and e.Acti_Date =#" & da & "# and e.Activ_Id = a.Activ_Id", con)
                    ord = cmd.ExecuteReader
                    While ord.Read
                        vactivity = ord(0)
                        vano = ord(1)
                    End While
                    cmd.Dispose()
                    ord.Close()
                Else
                    vactivity = ""
                    vano = 0
                End If
                dr = vdt.NewRow
                dr(0) = da
                dr(1) = vhotel
                dr(2) = vhno
                dr(3) = vvehicle
                dr(4) = vvno
                dr(5) = vactivity
                dr(6) = vano
                vdt.Rows.Add(dr)
                da = FormatDateTime(DateAdd(DateInterval.Day, 1, da), DateFormat.ShortDate)

            Next
        End If
        If cob_vstatus.Text = "Confirm" Then
            For i As Integer = 0 To diff + 2
                cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel where BookingId='" & vbid & "' and Occ_Date = #" & da & "#", con)
                j = cmd.ExecuteScalar
                cmd.Dispose()
                If j >= 1 Then
                    cmd = New OleDb.OleDbCommand("select TransId,Quanti from Cust_Hotel where BookingId='" & vbid & "' and Occ_Date=#" & da & "# ", con)
                    ord = cmd.ExecuteReader
                    While ord.Read
                        tid = ord(0)
                        qty = ord(1)
                    End While
                    cmd.Dispose()
                    ord.Close()
                    cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel_Child where BookingId='" & vbid & "' and Occ_Date = #" & da & "#", con)
                    j = cmd.ExecuteScalar
                    cmd.Dispose()
                    If j >= 1 Then
                        cmd = New OleDb.OleDbCommand("select CTransId,Quanti from Cust_Hotel_Child where BookingId='" & vbid & "' and Occ_date=#" & da & "#  ", con)
                        ord = cmd.ExecuteReader
                        While ord.Read
                            ctid = ord(0)
                            cqty = ord(1)
                        End While
                        cmd.Dispose()
                        ord.Close()
                    End If

                    cmd = New OleDb.OleDbCommand("select h.HotelName from HotelMaster h,Room_Tariff r where h.HotelId=r.HotelId and r.TransId=" & tid & "", con)
                    hotel = cmd.ExecuteScalar
                    cmd.Dispose()
                    qty = qty + cqty
                    vhotel = hotel
                    vhno = qty
                Else
                    vhotel = " "
                    vhno = 0
                End If
                cmd = New OleDb.OleDbCommand("select count(*) from Cust_Vehicle where  BookingId='" & vbid & "' and FromDt= #" & da & "#", con)
                j = cmd.ExecuteScalar
                cmd.Dispose()
                Dim tfcode As String
                If j >= 1 Then
                    cmd = New OleDb.OleDbCommand("select Tariffcode,Quanti from Cust_Vehicle where BookingId='" & vbid & "' and FromDt= #" & da & "#", con)
                    ord = cmd.ExecuteReader
                    While ord.Read
                        tfcode = ord(0)
                        vvno = ord(1)
                    End While
                    cmd.Dispose()
                    ord.Close()
                    cmd = New OleDb.OleDbCommand("select v.VehType from Veh_Type v, Veh_Tariff vt where vt.TariffCode='" & tfcode & "' and vt.VehTypeId=v.VehTypeId", con)
                    vvehicle = cmd.ExecuteScalar
                    cmd.Dispose()
                Else
                    vvehicle = " "
                    vvno = 0
                End If
                cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Activity where  BookingId='" & vbid & "' and Acti_Date =#" & da & "#", con)
                j = cmd.ExecuteScalar
                cmd.Dispose()
                If j >= 1 Then
                    cmd = New OleDb.OleDbCommand("select a.Activity,e.Noof_Pax from  Cust_Activity e,Activity a  where e.BookingId='" & vbid & "' and e.Acti_Date =#" & da & "# and e.Activ_Id = a.Activ_Id", con)
                    ord = cmd.ExecuteReader
                    While ord.Read
                        vactivity = ord(0)
                        vano = ord(1)
                    End While
                    cmd.Dispose()
                    ord.Close()
                Else
                    vactivity = ""
                    vano = 0
                End If
                dr = vdt.NewRow
                dr(0) = da
                dr(1) = vhotel
                dr(2) = vhno
                dr(3) = vvehicle
                dr(4) = vvno
                dr(5) = vactivity
                dr(6) = vano
                vdt.Rows.Add(dr)
                da = FormatDateTime(DateAdd(DateInterval.Day, 1, da), DateFormat.ShortDate)

            Next
        End If
        con.Close()
        GroupBox15.Visible = False
        DataGrid9.DataSource = ds
        DataGrid9.DataMember = "view"
    End Sub

    Private Sub cmd_eActivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eActivity.Click
        bookid = txt_bid.Text
        edit_item = "Activity"
        Dim frm As New edit_cust_Activ
        frm.ShowDialog()
        ds.Tables("view").Clear()
        viewfill()
    End Sub

    Private Sub dtpbd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpbd.TextChanged
        dtpsd.MinDate = dtpbd.Text
        dtped.MinDate = dtpbd.Text
    End Sub

    Private Sub dtpsd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpsd.TextChanged
        dtped.MinDate = dtpsd.Text
    End Sub

    Private Sub dtpfd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpfd.TextChanged
        dtptd.MinDate = dtpfd.Text
    End Sub

    Private Sub txt_gname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_gname.KeyPress
        textandnumbers(e)
    End Sub

    Private Sub txt_adults_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_adults.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_childs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_childs.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_infants_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_infants.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_cust_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cust.KeyPress
        textonly(e)
    End Sub

    Private Sub txt_scid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_scid.KeyPress
        textandnumbers(e)
    End Sub

    Private Sub dtped_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtped.Leave
        Dim i As Integer
        Dim str As Date
        Dim j, count As Integer
        Dim v_mindate, v_maxdate As Date
        If txt_cust.Text = "" Then
            MsgBox(" Select Customer Before Selecting Dates ", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        v_mindate = DateAdd(DateInterval.Day, -1, dtpsd.Value)
        v_maxdate = DateAdd(DateInterval.Day, 1, dtped.Value)
        dtpdate.MaxDate = FormatDateTime(v_maxdate, DateFormat.ShortDate)
        dtpdate.MinDate = FormatDateTime(v_mindate, DateFormat.ShortDate)
        dtp_act.MinDate = dtpsd.Value
        dtp_act.MaxDate = dtped.Value
        Openconnection()
        ' cmd = New OleDb.OleDbCommand("select count(*) from Hotel_Season where #" & dtped.Text & "#  >= FromDt and toDt >= #" & dtped.Text & "#", con)
        cmd = New OleDb.OleDbCommand("select count(*) from Hotel_Season where #" & dtped.Text & "#  between FromDt and toDt ", con)
        count = cmd.ExecuteScalar
        con.Close()
        If count = 0 Then
            MsgBox(" No Season Data Available For The Selected Date ", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If

        If ds.Tables("hbook").Rows.Count > 0 Then
            ds.Tables("hbook").Clear()
        End If

        ' calculating date difference and inserting into hotelbooking data table 
        If TabControl2.SelectedTab Is TabHotel Then
            i = DateDiff(DateInterval.Day, dtpsd.Value, dtped.Value)
            str = FormatDateTime(dtpsd.Text, DateFormat.ShortDate)
            For j = 0 To i
                dr = dt.NewRow
                dr.Item(0) = str
                dr.Item(1) = " "
                dr.Item(2) = " "
                dr.Item(3) = " "
                dr.Item(4) = " "
                dr.Item(5) = " "
                dr.Item(6) = " "
                dr.Item(7) = " "
                dr.Item(8) = " "
                dt.Rows.Add(dr)
                str = DateAdd(DateInterval.Day, 1, str)
                str = FormatDateTime(str, DateFormat.ShortDate)
            Next
            DataGrid1.DataSource = ds
            DataGrid1.DataMember = "hbook"
        End If
    End Sub

    Private Sub txt_ac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ac.KeyPress
        Numb_Digit_Only(txt_ac.Text, e)
    End Sub

    Private Sub txt_edic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_edic.KeyPress
        Numb_Digit_Only(txt_edic.Text, e)
    End Sub

    Private Sub Txt_Juniors_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Juniors.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_cust_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cust.Leave
        If txt_cust.Text <> "" Then
            Dim fn, ln, name As String
            Dim count As Integer
            count = InStr(txt_cust.Text, " ")
            If count >= 1 Then
                fn = Mid(txt_cust.Text, 1, count - 1)
                ln = Mid(txt_cust.Text, count + 1)
                Openconnection()
                cmd = New OleDb.OleDbCommand("select count(*) from Cust_Master where Fname like '" & fn & "' And lname like '" & ln & "'", con)
                count = cmd.ExecuteScalar
                cmd.Dispose()
                con.Close()
            Else
                fn = txt_cust.Text & "%"
                ln = txt_cust.Text & "%"
                Openconnection()
                cmd = New OleDb.OleDbCommand("select count(*) from Cust_Master where Fname like '" & fn & "' or lname like '" & ln & "'", con)
                count = cmd.ExecuteScalar
                cmd.Dispose()
                con.Close()
            End If
            
            If count >= 2 Then
                MsgBox(" More Than One Custmer Exists With This Name Search For Approprate Custmer Id", MsgBoxStyle.OKOnly, Prjtitle)
                txt_cust.Text = ""
                txt_cust.Focus()
                Exit Sub
            End If
            If count = 0 Then
                MsgBox(" No Custmer Exists With This Name Search For Approprate Custmer", MsgBoxStyle.OKOnly, Prjtitle)
                txt_cust.Text = ""
                txt_cust.Focus()
                Exit Sub
            End If
            If count = 1 Then
                Dim i As Integer
                Dim agid, agfname, aglname As String

                i = InStr(fn, "%")
                If i >= 1 Then
                    Openconnection()
                    cmd = New OleDb.OleDbCommand("select CustId, Fname, Lname,AgentId from Cust_Master where Fname like '" & fn & "' or lname like '" & ln & "'", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        cuid = ord(0)
                        name = ord(1) & " " & ord(2)
                        agid = ord(3)
                    End If
                    cmd.Dispose()
                    con.Close()
                Else
                    Openconnection()
                    cmd = New OleDb.OleDbCommand("select CustId, Fname, Lname,AgentId from Cust_Master where Fname like '" & fn & "' And lname like '" & ln & "'", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        cuid = ord(0)
                        name = ord(1) & " " & ord(2)
                        agid = ord(3)
                    End If
                    cmd.Dispose()
                    con.Close()
                End If
                Openconnection()
                cmd = New OleDb.OleDbCommand(" Select FirstName,LastName from AgentMaster where AgentId='" & agid & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    agfname = ord(0)
                    aglname = ord(1)
                End If
                ord.Close()
                cmd.Dispose()
                con.Close()
                txt_aname.Text = agfname & " " & aglname
                Txt_cuid.Text = cuid
                txt_cust.Text = name
            End If
        End If
    End Sub

End Class
