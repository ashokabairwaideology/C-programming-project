'ch.shiv akumar
'date:25/07/2006

Imports System.Data.OleDb
Public Class FixItiner_Booking
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents Tabfixiti As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents txtbookingdate As System.Windows.Forms.TextBox
    Friend WithEvents txtenddate As System.Windows.Forms.TextBox
    Friend WithEvents txtstrtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtagentname As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofinfants As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofchlids As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofadults As System.Windows.Forms.TextBox
    Friend WithEvents dtppaydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents txtdetails As System.Windows.Forms.TextBox
    Friend WithEvents combomodeofpay As System.Windows.Forms.ComboBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtagentcomm As System.Windows.Forms.TextBox
    Friend WithEvents txtperperson As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtextradiscou As System.Windows.Forms.TextBox
    Friend WithEvents combopacsch As System.Windows.Forms.ComboBox
    Friend WithEvents combopacid As System.Windows.Forms.ComboBox
    Friend WithEvents txtgroupname As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofdays As System.Windows.Forms.TextBox
    Friend WithEvents txttodate As System.Windows.Forms.TextBox
    Friend WithEvents txtfromdate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents combostatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtreceiamt As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents combopacidview As System.Windows.Forms.ComboBox
    Friend WithEvents combostatusview As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btngosearch As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpenddate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpstdate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabView = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.combostatusview = New System.Windows.Forms.ComboBox
        Me.combopacidview = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.TabEntry = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btngosearch = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpenddate1 = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpstdate1 = New System.Windows.Forms.DateTimePicker
        Me.btnupdate = New System.Windows.Forms.Button
        Me.dg1 = New System.Windows.Forms.DataGrid
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.combostatus = New System.Windows.Forms.ComboBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbookingdate = New System.Windows.Forms.TextBox
        Me.txtenddate = New System.Windows.Forms.TextBox
        Me.txtstrtdate = New System.Windows.Forms.TextBox
        Me.txtagentname = New System.Windows.Forms.TextBox
        Me.txtnoofinfants = New System.Windows.Forms.TextBox
        Me.txtnoofchlids = New System.Windows.Forms.TextBox
        Me.txtnoofadults = New System.Windows.Forms.TextBox
        Me.txtgroupname = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.dtppaydate = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.txtreceiamt = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.txtdetails = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.combomodeofpay = New System.Windows.Forms.ComboBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtagentcomm = New System.Windows.Forms.TextBox
        Me.txtperperson = New System.Windows.Forms.TextBox
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtextradiscou = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.Tabfixiti = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.txtnoofdays = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txttodate = New System.Windows.Forms.TextBox
        Me.txtfromdate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.combopacsch = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.combopacid = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabView.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEntry.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.Tabfixiti.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabView)
        Me.TabControl1.Controls.Add(Me.TabEntry)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(688, 568)
        Me.TabControl1.TabIndex = 0
        '
        'TabView
        '
        Me.TabView.Controls.Add(Me.Button2)
        Me.TabView.Controls.Add(Me.combostatusview)
        Me.TabView.Controls.Add(Me.combopacidview)
        Me.TabView.Controls.Add(Me.Label16)
        Me.TabView.Controls.Add(Me.Label13)
        Me.TabView.Controls.Add(Me.GroupBox4)
        Me.TabView.Location = New System.Drawing.Point(4, 22)
        Me.TabView.Name = "TabView"
        Me.TabView.Size = New System.Drawing.Size(680, 542)
        Me.TabView.TabIndex = 0
        Me.TabView.Text = "View"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(464, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Go"
        '
        'combostatusview
        '
        Me.combostatusview.Items.AddRange(New Object() {"Confirm", "Enquiry"})
        Me.combostatusview.Location = New System.Drawing.Point(328, 32)
        Me.combostatusview.Name = "combostatusview"
        Me.combostatusview.Size = New System.Drawing.Size(120, 21)
        Me.combostatusview.TabIndex = 5
        Me.combostatusview.Text = "--Select Status--"
        '
        'combopacidview
        '
        Me.combopacidview.Location = New System.Drawing.Point(144, 32)
        Me.combopacidview.Name = "combopacidview"
        Me.combopacidview.Size = New System.Drawing.Size(112, 21)
        Me.combopacidview.TabIndex = 4
        Me.combopacidview.Text = "--Select  pack--"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(264, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Status"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(64, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Packageid"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGrid2)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(664, 392)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(24, 32)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(632, 312)
        Me.DataGrid2.TabIndex = 0
        '
        'TabEntry
        '
        Me.TabEntry.Controls.Add(Me.GroupBox1)
        Me.TabEntry.Controls.Add(Me.GroupBox5)
        Me.TabEntry.Controls.Add(Me.GroupBox10)
        Me.TabEntry.Controls.Add(Me.GroupBox3)
        Me.TabEntry.Controls.Add(Me.GroupBox2)
        Me.TabEntry.Location = New System.Drawing.Point(4, 22)
        Me.TabEntry.Name = "TabEntry"
        Me.TabEntry.Size = New System.Drawing.Size(680, 542)
        Me.TabEntry.TabIndex = 1
        Me.TabEntry.Text = "Entry / Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btngosearch)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtpenddate1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dtpstdate1)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.dg1)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 248)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Close"
        '
        'btngosearch
        '
        Me.btngosearch.Location = New System.Drawing.Point(336, 24)
        Me.btngosearch.Name = "btngosearch"
        Me.btngosearch.Size = New System.Drawing.Size(56, 23)
        Me.btngosearch.TabIndex = 7
        Me.btngosearch.Text = "Go"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(184, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 23)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "To"
        '
        'dtpenddate1
        '
        Me.dtpenddate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpenddate1.Location = New System.Drawing.Point(224, 24)
        Me.dtpenddate1.Name = "dtpenddate1"
        Me.dtpenddate1.Size = New System.Drawing.Size(96, 21)
        Me.dtpenddate1.TabIndex = 6
        Me.dtpenddate1.Value = New Date(2006, 7, 6, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 23)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "From"
        '
        'dtpstdate1
        '
        Me.dtpstdate1.CustomFormat = ""
        Me.dtpstdate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstdate1.Location = New System.Drawing.Point(72, 24)
        Me.dtpstdate1.Name = "dtpstdate1"
        Me.dtpstdate1.Size = New System.Drawing.Size(96, 21)
        Me.dtpstdate1.TabIndex = 5
        Me.dtpstdate1.Value = New Date(2006, 7, 20, 0, 0, 0, 0)
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(88, 216)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 9
        Me.btnupdate.Text = "Update"
        '
        'dg1
        '
        Me.dg1.CaptionVisible = False
        Me.dg1.DataMember = ""
        Me.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg1.Location = New System.Drawing.Point(16, 64)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(400, 144)
        Me.dg1.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.combostatus)
        Me.GroupBox5.Controls.Add(Me.btnsearch)
        Me.GroupBox5.Controls.Add(Me.txtcustname)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txtbookingdate)
        Me.GroupBox5.Controls.Add(Me.txtenddate)
        Me.GroupBox5.Controls.Add(Me.txtstrtdate)
        Me.GroupBox5.Controls.Add(Me.txtagentname)
        Me.GroupBox5.Controls.Add(Me.txtnoofinfants)
        Me.GroupBox5.Controls.Add(Me.txtnoofchlids)
        Me.GroupBox5.Controls.Add(Me.txtnoofadults)
        Me.GroupBox5.Controls.Add(Me.txtgroupname)
        Me.GroupBox5.Controls.Add(Me.Label75)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(680, 112)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Customer"
        '
        'combostatus
        '
        Me.combostatus.Items.AddRange(New Object() {"Enquiry          ", "Confirm"})
        Me.combostatus.Location = New System.Drawing.Point(392, 17)
        Me.combostatus.Name = "combostatus"
        Me.combostatus.Size = New System.Drawing.Size(96, 21)
        Me.combostatus.TabIndex = 2
        Me.combostatus.Text = "SelectStatus "
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(280, 16)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(56, 24)
        Me.btnsearch.TabIndex = 1
        Me.btnsearch.Text = "Search"
        '
        'txtcustname
        '
        Me.txtcustname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcustname.Location = New System.Drawing.Point(72, 16)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(208, 21)
        Me.txtcustname.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Status *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Customer"
        '
        'txtbookingdate
        '
        Me.txtbookingdate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbookingdate.Location = New System.Drawing.Point(96, 48)
        Me.txtbookingdate.Name = "txtbookingdate"
        Me.txtbookingdate.ReadOnly = True
        Me.txtbookingdate.Size = New System.Drawing.Size(80, 21)
        Me.txtbookingdate.TabIndex = 3
        '
        'txtenddate
        '
        Me.txtenddate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtenddate.Location = New System.Drawing.Point(400, 48)
        Me.txtenddate.Name = "txtenddate"
        Me.txtenddate.ReadOnly = True
        Me.txtenddate.Size = New System.Drawing.Size(88, 21)
        Me.txtenddate.TabIndex = 94
        '
        'txtstrtdate
        '
        Me.txtstrtdate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtstrtdate.Location = New System.Drawing.Point(256, 48)
        Me.txtstrtdate.Name = "txtstrtdate"
        Me.txtstrtdate.ReadOnly = True
        Me.txtstrtdate.Size = New System.Drawing.Size(72, 21)
        Me.txtstrtdate.TabIndex = 4
        '
        'txtagentname
        '
        Me.txtagentname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtagentname.Location = New System.Drawing.Point(568, 24)
        Me.txtagentname.Name = "txtagentname"
        Me.txtagentname.ReadOnly = True
        Me.txtagentname.Size = New System.Drawing.Size(104, 21)
        Me.txtagentname.TabIndex = 92
        '
        'txtnoofinfants
        '
        Me.txtnoofinfants.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnoofinfants.Location = New System.Drawing.Point(512, 80)
        Me.txtnoofinfants.Name = "txtnoofinfants"
        Me.txtnoofinfants.ReadOnly = True
        Me.txtnoofinfants.Size = New System.Drawing.Size(80, 21)
        Me.txtnoofinfants.TabIndex = 91
        '
        'txtnoofchlids
        '
        Me.txtnoofchlids.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnoofchlids.Location = New System.Drawing.Point(312, 80)
        Me.txtnoofchlids.Name = "txtnoofchlids"
        Me.txtnoofchlids.ReadOnly = True
        Me.txtnoofchlids.Size = New System.Drawing.Size(80, 21)
        Me.txtnoofchlids.TabIndex = 90
        '
        'txtnoofadults
        '
        Me.txtnoofadults.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnoofadults.Location = New System.Drawing.Point(104, 80)
        Me.txtnoofadults.Name = "txtnoofadults"
        Me.txtnoofadults.ReadOnly = True
        Me.txtnoofadults.Size = New System.Drawing.Size(88, 21)
        Me.txtnoofadults.TabIndex = 89
        '
        'txtgroupname
        '
        Me.txtgroupname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtgroupname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgroupname.Location = New System.Drawing.Point(568, 48)
        Me.txtgroupname.Name = "txtgroupname"
        Me.txtgroupname.ReadOnly = True
        Me.txtgroupname.Size = New System.Drawing.Size(104, 21)
        Me.txtgroupname.TabIndex = 88
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(488, 48)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(79, 13)
        Me.Label75.TabIndex = 87
        Me.Label75.Text = "Group Name"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(488, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 13)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Agent Name"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 13)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Booking Date"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(200, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "No. of Children"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 13)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "No. Adults"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(184, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Start Date"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(336, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 13)
        Me.Label26.TabIndex = 26
        Me.Label26.Text = " End Date"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(400, 80)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 13)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "No. of Infants"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.dtppaydate)
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Controls.Add(Me.txtremarks)
        Me.GroupBox10.Controls.Add(Me.Label60)
        Me.GroupBox10.Controls.Add(Me.txtreceiamt)
        Me.GroupBox10.Controls.Add(Me.Label62)
        Me.GroupBox10.Controls.Add(Me.txtdetails)
        Me.GroupBox10.Controls.Add(Me.Label64)
        Me.GroupBox10.Controls.Add(Me.combomodeofpay)
        Me.GroupBox10.Controls.Add(Me.Label72)
        Me.GroupBox10.Controls.Add(Me.txtbalance)
        Me.GroupBox10.Controls.Add(Me.Label11)
        Me.GroupBox10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(4, 456)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(676, 72)
        Me.GroupBox10.TabIndex = 38
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Payment Details"
        '
        'dtppaydate
        '
        Me.dtppaydate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtppaydate.Location = New System.Drawing.Point(240, 40)
        Me.dtppaydate.Name = "dtppaydate"
        Me.dtppaydate.Size = New System.Drawing.Size(120, 21)
        Me.dtppaydate.TabIndex = 4
        Me.dtppaydate.Value = New Date(2006, 7, 19, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(192, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Date"
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(456, 16)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(200, 21)
        Me.txtremarks.TabIndex = 2
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
        'txtreceiamt
        '
        Me.txtreceiamt.Location = New System.Drawing.Point(96, 40)
        Me.txtreceiamt.MaxLength = 12
        Me.txtreceiamt.Name = "txtreceiamt"
        Me.txtreceiamt.Size = New System.Drawing.Size(88, 21)
        Me.txtreceiamt.TabIndex = 3
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
        'txtdetails
        '
        Me.txtdetails.Location = New System.Drawing.Point(240, 16)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Size = New System.Drawing.Size(104, 21)
        Me.txtdetails.TabIndex = 1
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
        'combomodeofpay
        '
        Me.combomodeofpay.Items.AddRange(New Object() {"Cash", "Credit Card", "Cheque", "DD"})
        Me.combomodeofpay.Location = New System.Drawing.Point(96, 16)
        Me.combomodeofpay.Name = "combomodeofpay"
        Me.combomodeofpay.Size = New System.Drawing.Size(96, 21)
        Me.combomodeofpay.TabIndex = 0
        Me.combomodeofpay.Text = "SelectMode"
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
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbalance.Location = New System.Drawing.Point(456, 40)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(104, 21)
        Me.txtbalance.TabIndex = 5
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
        Me.GroupBox3.Controls.Add(Me.txtagentcomm)
        Me.GroupBox3.Controls.Add(Me.txtperperson)
        Me.GroupBox3.Controls.Add(Me.txttotal)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtextradiscou)
        Me.GroupBox3.Controls.Add(Me.Label61)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(676, 48)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Amount"
        '
        'txtagentcomm
        '
        Me.txtagentcomm.Location = New System.Drawing.Point(448, 16)
        Me.txtagentcomm.MaxLength = 5
        Me.txtagentcomm.Name = "txtagentcomm"
        Me.txtagentcomm.Size = New System.Drawing.Size(32, 21)
        Me.txtagentcomm.TabIndex = 0
        '
        'txtperperson
        '
        Me.txtperperson.Location = New System.Drawing.Point(216, 16)
        Me.txtperperson.MaxLength = 3
        Me.txtperperson.Name = "txtperperson"
        Me.txtperperson.ReadOnly = True
        Me.txtperperson.Size = New System.Drawing.Size(88, 21)
        Me.txtperperson.TabIndex = 1
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(48, 16)
        Me.txttotal.MaxLength = 12
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(72, 21)
        Me.txttotal.TabIndex = 0
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
        Me.Label9.Location = New System.Drawing.Point(136, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Per Person "
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
        'txtextradiscou
        '
        Me.txtextradiscou.Location = New System.Drawing.Point(592, 16)
        Me.txtextradiscou.MaxLength = 5
        Me.txtextradiscou.Name = "txtextradiscou"
        Me.txtextradiscou.Size = New System.Drawing.Size(64, 21)
        Me.txtextradiscou.TabIndex = 1
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl2)
        Me.GroupBox2.Controls.Add(Me.txtnoofdays)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txttodate)
        Me.GroupBox2.Controls.Add(Me.txtfromdate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.combopacsch)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.combopacid)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 232)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fixed Itineraries"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.Tabfixiti)
        Me.TabControl2.Location = New System.Drawing.Point(8, 72)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(664, 200)
        Me.TabControl2.TabIndex = 11
        '
        'Tabfixiti
        '
        Me.Tabfixiti.Controls.Add(Me.DataGrid1)
        Me.Tabfixiti.Location = New System.Drawing.Point(4, 22)
        Me.Tabfixiti.Name = "Tabfixiti"
        Me.Tabfixiti.Size = New System.Drawing.Size(656, 174)
        Me.Tabfixiti.TabIndex = 0
        Me.Tabfixiti.Text = "Fixed Itinary"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(648, 160)
        Me.DataGrid1.TabIndex = 0
        '
        'txtnoofdays
        '
        Me.txtnoofdays.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnoofdays.Location = New System.Drawing.Point(496, 48)
        Me.txtnoofdays.Name = "txtnoofdays"
        Me.txtnoofdays.Size = New System.Drawing.Size(80, 21)
        Me.txtnoofdays.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "No. Of Days"
        '
        'txttodate
        '
        Me.txttodate.BackColor = System.Drawing.Color.Gainsboro
        Me.txttodate.Location = New System.Drawing.Point(272, 48)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(112, 21)
        Me.txttodate.TabIndex = 8
        '
        'txtfromdate
        '
        Me.txtfromdate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtfromdate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfromdate.Location = New System.Drawing.Point(80, 48)
        Me.txtfromdate.Name = "txtfromdate"
        Me.txtfromdate.Size = New System.Drawing.Size(112, 21)
        Me.txtfromdate.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "To Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "From Date"
        '
        'combopacsch
        '
        Me.combopacsch.Location = New System.Drawing.Point(400, 16)
        Me.combopacsch.Name = "combopacsch"
        Me.combopacsch.Size = New System.Drawing.Size(176, 21)
        Me.combopacsch.TabIndex = 1
        Me.combopacsch.Text = "---Select Schedule---"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(280, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Package Schedule *"
        '
        'combopacid
        '
        Me.combopacid.Location = New System.Drawing.Point(80, 16)
        Me.combopacid.Name = "combopacid"
        Me.combopacid.Size = New System.Drawing.Size(184, 21)
        Me.combopacid.TabIndex = 0
        Me.combopacid.Text = "---Select Package--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Package *"
        '
        'FixItiner_Booking
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(680, 565)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FixItiner_Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed Itinery"
        Me.TabControl1.ResumeLayout(False)
        Me.TabView.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEntry.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.Tabfixiti.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim custid, bookingid As String
    Dim status As String

    ' Dim con As New OleDbConnection("provider=Microsoft.jet.oledb.4.0;data source=d:\shiva\bin\travelz.mdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sysno As String

    Dim ds As New DataSet
    Dim grossamt, netamt As Long
    Dim dt As Date

    Dim recstatus As EnuRecstatus
    Dim pacid As String
    Dim g, rec As Long
    Dim disc As Integer
    Dim noofper As Integer
    Dim dtp11 As New DateTimePicker


    Private Sub FixItiner_Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        disable()
        GroupBox1.Visible = False

        Openconnection()

        Dim cmd As New OleDbCommand("select packageid from fixeditineraries", con)
        Dim dr As OleDbDataReader


        'openconnection()()
        Try
            dr = cmd.ExecuteReader
            While dr.Read
                combopacid.Items.Add(dr(0))
                combopacidview.Items.Add(dr(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub

        Finally

            CloseConnection()
        End Try
        TabControl1.SelectedTab = TabEntry


    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        dtpstdate1.Focus()
        ds.Clear()
        If txtcustname.Text = "" Then
            GroupBox1.Visible = True
            btnupdate.Enabled = False
        Else
            Try
                Dim da As New OleDbDataAdapter("select * from cust_master where trim(fname)='" & Trim(txtcustname.Text) & "'", con)
                'Dim cmd As New OleDbCommand("select count(*) from cust_master where fname='" & txtcustname.Text & "'", con)
                'Openconnection()
                'Dim p As Integer
                'p = cmd.ExecuteScalar()
                'closeconnection()()
                'MsgBox(p)

                da.Fill(ds, "cust")
                GroupBox1.Visible = True
                dg1.DataSource = ds.Tables("cust")
                btnupdate.Enabled = True
                ' dim cmd as New OleDbCommand("select * from cust_master where trim(fname)=
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)

                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Dim p As Integer
        p = dg1.CurrentCell.RowNumber
        Dim str, stragentid, stragenname As String

        str = dg1.Item(p, 0)
        custid = dg1.Item(p, 0)
        Openconnection()
        Dim cmd As New OleDbCommand("select * from cust_master where custid='" & Trim(str) & "'", con)
        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader
        If dr.Read Then
            custid = dr(0)
            txtstrtdate.Text = dr(4)
            txtenddate.Text = dr(5)
            stragentid = dr(6)
            txtgroupname.Text = dr(7)
            txtnoofadults.Text = Convert.ToString(dr(8))

            txtnoofchlids.Text = dr(9)
            txtnoofinfants.Text = dr(10)
            txtbookingdate.Text = Convert.ToString(dr(12))
            noofper = Val(txtnoofchlids.Text) + Val(txtnoofadults.Text) + Val(txtnoofinfants.Text)
            ' txtperperson.Text = noofper
        End If
        CloseConnection()
        Openconnection()
        Dim cmd1 As New OleDbCommand("select firstname from agentmaster where agentid='" & stragentid & "'", con)

        stragenname = cmd1.ExecuteScalar

        CloseConnection()
        txtagentname.Text = stragenname
        GroupBox1.Visible = False
    End Sub


    Private Sub btngosearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngosearch.Click

        If dtpstdate1.Value > dtpenddate1.Value Then
            MsgBox("From Date Should Not be Less Then To date")
        Else
            ds.Clear()
            Dim da As New OleDbDataAdapter("select CustId, Fname, Lname, Cust_JDate from Cust_Master where Cust_JDate between #" & dtpstdate1.Text & "# and #" & dtpenddate1.Text & "#", con)
            Try
                da.Fill(ds, "cust_master")
                dg1.DataSource = ds
                dg1.DataMember = "cust_master"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dg1.DataSource = ds.Tables("ee")
            btnupdate.Enabled = True
        End If
    End Sub

    Private Sub combopacid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combopacid.SelectedIndexChanged
        Dim totamtr As Long
        Dim dtd As New Date
        dt = Now.Date
        dtd = DateAdd(DateInterval.Month, -1, dt)
        ds.Clear()
        Dim str As String
        pacid = combopacid.SelectedItem
        str = combopacid.SelectedItem
        Dim intp As Integer
        Try

            If txtcustname.Text = "" Then
                MessageBox.Show(" Select the Customer")
                Exit Sub
            End If
            Openconnection()
            Dim cmd1 As New OleDbCommand("select noofdays from FixedItineraries where packageid='" & Trim(str) & "'", con)
            intp = cmd1.ExecuteScalar

            CloseConnection()
            cmd1.Dispose()
            Openconnection()
            cmd1 = New OleDbCommand("select Rate from FixedItineraries where packageid='" & Trim(str) & "'", con)

            totamtr = cmd1.ExecuteScalar()
            CloseConnection()

            txtnoofdays.Text = intp
            combopacsch.Items.Clear()

            Openconnection()
            ' this will fill the schedule details after start date only.
            Dim cmd As New OleDbCommand("select * from fp_schedule where packageid='" & Trim(str) & "' and sch_stdate > #" & dtd & "#", con)

            Dim dr As OleDbDataReader


            dr = cmd.ExecuteReader

            If dr.HasRows = False Then

                MessageBox.Show("Itenary schedule is not entered (  schedule date should be greater than Start Dt.)")


            End If
            While dr.Read
                combopacsch.Items.Add(dr(0))
            End While

            CloseConnection()
            Openconnection()
            Dim da As New OleDbDataAdapter("select * from FixedItinera_Det where trim(packageid)='" & pacid & "'", con)
            da.Fill(ds, "AA")
            CloseConnection()
            DataGrid1.DataSource = ds.Tables("AA")
            txttotal.Text = noofper * totamtr
            txtperperson.Text = Val(txttotal.Text) / noofper


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub combopacsch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combopacsch.SelectedIndexChanged
        Dim str As String
        Dim date1, date2 As Date

        str = combopacsch.SelectedItem
        Openconnection()
        Dim cmd As New OleDbCommand("select * from FP_Schedule where FPSch_id= '" & Trim(str) & "'", con)
        Dim dr As OleDbDataReader

        Try
            'Openconnection()

            dr = cmd.ExecuteReader
            If dr.Read Then
                date1 = dr(2)
                date2 = dr(3)
            End If
            CloseConnection()
            txtfromdate.Text = Format(date1, "mm/dd/yyyy")
            txttodate.Text = Format(date2, "mm/dd/yyyy")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        GroupBox1.Visible = False
    End Sub
    Public Sub saveproc()
        Dim p, maxno, recexists As Integer

        Dim bookid As String
        Dim boli As Boolean = 0
        dt = Now.Date
        If txtextradiscou.Text = "" Then
            disc = 0
        Else
            disc = txtextradiscou.Text
        End If
        If txtreceiamt.Text = "" Then
            rec = 0
        Else
            rec = txtreceiamt.Text
        End If

        g = Val(txttotal.Text) - (Val(txttotal.Text) * (disc / 100))
        netamt = g - rec
        txtbalance.Text = netamt

        grossamt = Val(txttotal.Text)

        Dim cmd As OleDbCommand

        If txtcustname.Text = "" Then
            MsgBox("Select The Customer")
            boli = 1
        End If
        If combostatus.SelectedItem = "" Then
            MsgBox("Select The Status First")
            boli = 1
        End If
        If txttotal.Text = "" Then
            MsgBox("Enter Total Amount")
            boli = 1
        End If
        If txtperperson.Text = "" Then
            MsgBox("Enter No Of Persons")
            boli = 1

        End If

        If boli = 0 Then
            Try

                If recstatus = Module1.EnuRecstatus.Recnew Then

                    status = Trim(StrConv(combostatus.SelectedItem, VbStrConv.UpperCase))

                    '
                    'To Check The Record Exists In The Table Or NOt
                    'if p=0 then no record exists so set the maxno to zero
                    Try
                        'enter the record when the status in the Enquiry mode
                        If status = "ENQUIRY" Then
                            Openconnection()
                            cmd = New OleDbCommand("select count(*) from enq_booking_itinary ", con)
                            ' Openconnection()

                            p = cmd.ExecuteScalar
                            CloseConnection()
                            cmd.Dispose()

                            If p = 0 Then
                                maxno = 0
                            Else
                                maxno = p + 1

                                'else find the maxno in the database table

                            End If


                            Dim s As String = " "
                            Openconnection()
                            cmd = New OleDbCommand("insert into enq_booking_itinary values(" & maxno & ",'" & s & "','" & custid & "','" & status & "','" & combopacsch.SelectedItem & "','" & combopacid.SelectedItem & "'," & txttotal.Text & "," & IIf(txtperperson.Text = "", 0, txtperperson.Text) & "," & IIf(txtextradiscou.Text = "", 0, txtextradiscou.Text) & ", " & grossamt & "," & IIf(txtagentcomm.Text = "", 0, txtagentcomm.Text) & ",'y','" & Muserid & "','" & dt & "')", con)

                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            Openconnection()
                            cmd = New OleDbCommand("insert into enq_booking_amount values(" & maxno & "," & maxno & ",'" & s & "','" & FormatDateTime(dtppaydate.Text, DateFormat.ShortDate) & "','" & combomodeofpay.SelectedItem & "','" & IIf(txtdetails.Text = "", " ", txtdetails.Text) & "','" & IIf(txtremarks.Text = "", " ", txtremarks.Text) & "'," & grossamt & "," & IIf(txtreceiamt.Text = "", 0, txtreceiamt.Text) & "," & netamt & ",'" & Muserid & "','" & dt & "')", con)
                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            
                            MsgSav()
                        End If
                        'Enter The record into the booking amount table when status is Confirm
                        '
                        If status = "CONFIRM" Then

                            Openconnection()
                            cmd = New OleDbCommand("select count(*) from booking_itinary ", con)
                            ' Openconnection()

                            p = cmd.ExecuteScalar
                            CloseConnection()

                            If p = 0 Then
                                maxno = 0
                            Else
                                maxno = p + 1

                                'else find the maxno in the database table

                            End If

                            'SAve The Record in the Confirmation mode
                            bookid = "FI" & maxno
                            Openconnection()
                            cmd = New OleDbCommand("insert into booking_itinary values('" & maxno & " ','" & bookid & "','" & custid & "','" & status & "','" & combopacsch.SelectedItem & "','" & combopacid.SelectedItem & "'," & IIf(txttotal.Text = "", 0, txttotal.Text) & "," & IIf(txtperperson.Text = "", 0, txtperperson.Text) & "," & IIf(txtextradiscou.Text = "", 0, txtextradiscou.Text) & ", " & grossamt & "," & IIf(txtagentcomm.Text = "", 0, txtagentcomm.Text) & ",'y','" & Muserid & "','" & dt & "')", con)

                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()

                            'insert The Record into the bookingamount table
                            Openconnection()
                            cmd.CommandText = "insert into booking_amount values(" & maxno & "," & maxno & ",'" & bookid & "','" & dtppaydate.Value & "','" & combomodeofpay.SelectedItem & "','" & IIf(txtdetails.Text = "", " ", txtdetails.Text) & "','" & IIf(txtremarks.Text = "", 0, txtremarks.Text) & "'," & grossamt & "," & IIf(txtreceiamt.Text = "", 0, txtreceiamt.Text) & "," & netamt & ",'" & Muserid & "','" & dt & "')"
                            cmd.Connection = con

                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            MsgSav()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                        CloseConnection()
                        Exit Sub
                    Finally
                        CloseConnection()
                    End Try
                End If

                '
                'Up date THe Record When the Record Status in The Edit maodeEdit Mode
                '
                If recstatus = Module1.EnuRecstatus.Recedit Then
                    '
                    'up date the booking itinary and booking Aount when status in Enquery
                    '
                    Dim st As String
                    st = combostatus.SelectedItem()

                    If status = "Enquiry" And st = "Enquiry" Then

                        Try
                            Dim s As String = " "
                            '
                            'To uodate the Booking itinary details
                            Openconnection()
                            cmd = New OleDbCommand("update  Enq_booking_itinary set custid='" & custid & "',status='" & st & "',fpsch_id='" & combopacsch.SelectedItem & "',packageid='" & combopacid.SelectedItem & "',tamount=" & txttotal.Text & ",perperson=" & txtperperson.Text & ",discount=" & IIf(txtextradiscou.Text = "", 0, txtextradiscou.Text) & ", gross_amount= " & grossamt & ",agent_commi=" & IIf(txtagentcomm.Text = "", 0, txtagentcomm.Text) & ",userid='" & Muserid & "',entereddt='" & dt & "' where sysrefno=" & sysno & " ", con)
                            '
                            'Update booking amount details
                            '
                            'Openconnection()


                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            '
                            'To update the booking Amount details
                            Openconnection()
                            cmd = New OleDbCommand(" update Enq_booking_amount set rec_date='" & FormatDateTime(dtppaydate.Text, DateFormat.ShortDate) & "',mode_payment='" & combomodeofpay.SelectedItem & "',details ='" & txtdetails.Text & "',remarks='" & txtremarks.Text & "',gross_amount=" & grossamt & ",received_amount=" & txtreceiamt.Text & ",net_amount=" & netamt & ",userid='" & Muserid & "',entereddt='" & dt & "' where sysrefno=" & sysno & "", con)
                            'Openconnection()


                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            MsgSav()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                            CloseConnection()
                            Exit Sub
                        Finally
                            CloseConnection()

                        End Try
                    End If
                    'end if for status enquiry
                    '
                    'update the booking amount and booking itinary when status is confirmation
                    '
                    If status = "Confirm" And st = "Confirm" Then
                        Try
                            Openconnection()
                            cmd = New OleDbCommand("update  booking_itinary set bookingid='" & bookingid & "',custid='" & custid & "',status='" & st & "',fpsch_id='" & combopacsch.SelectedItem & "',packageid='" & combopacid.SelectedItem & "',tamount=" & txttotal.Text & ",perperson=" & txtperperson.Text & ",discount=" & txtextradiscou.Text & ", gross_amount= " & grossamt & ",agent_commi=" & txtagentcomm.Text & ",userid='" & Muserid & "',entereddt='" & dt & "' where sysrefno=" & sysno & "", con)

                            '
                            'Update booking amount details
                            '
                            'Openconnection()

                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            '
                            'To update the booking Amount details

                            Openconnection()
                            cmd = New OleDbCommand(" update booking_amount set bookingid='" & bookingid & "',rec_date='" & FormatDateTime(dtppaydate.Text, DateFormat.ShortDate) & "',mode_payment='" & combomodeofpay.SelectedItem & "',details ='" & txtdetails.Text & "',remarks='" & txtremarks.Text & "',gross_amount=" & grossamt & ",received_amount=" & txtreceiamt.Text & ",net_amount=" & netamt & ",userid='" & Muserid & "',entereddt='" & dt & "' where sysrefno=" & sysno & "", con)
                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            MsgSav()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                            CloseConnection()
                            Exit Sub
                        End Try

                    End If
                    'endif status confirm
                    '
                    'if condi. Status enquiry changed to confirm then insert the record into the booking itinary table 
                    'and delete the record inthe enquiry table
                    If status = "Enquiry" And st = "Confirm" Then
                        Try

                            Openconnection()
                            cmd = New OleDbCommand("select count(*) from booking_itinary ", con)
                            ' Openconnection()

                            p = cmd.ExecuteScalar
                            CloseConnection()
                            cmd.Dispose()

                            If p = 0 Then
                                maxno = 0
                            Else
                                maxno = p + 1
                                '
                                'else find the maxno in the database table

                            End If


                            'SAve The Record in the Confirmation mode
                            bookid = "FI" & maxno
                            Openconnection()
                            cmd = New OleDbCommand("insert into booking_itinary values('" & maxno & " ','" & bookid & "','" & custid & "','" & st & "','" & combopacsch.SelectedItem & "','" & combopacid.SelectedItem & "'," & IIf(txttotal.Text = "", 0, txttotal.Text) & "," & IIf(txtperperson.Text = "", 0, txtperperson.Text) & "," & IIf(txtextradiscou.Text = "", 0, txtextradiscou.Text) & ", " & grossamt & "," & IIf(txtagentcomm.Text = "", 0, txtagentcomm.Text) & ",'y','" & Muserid & "','" & dt & "')", con)
                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()


                            'insert The Record into the bookingamount table
                            '
                            Openconnection()
                            cmd.CommandText = "insert into booking_amount values(" & maxno & "," & maxno & ",'" & bookid & "','" & dtppaydate.Value & "','" & combomodeofpay.SelectedItem & "','" & IIf(txtdetails.Text = "", " ", txtdetails.Text) & "','" & IIf(txtremarks.Text = "", 0, txtremarks.Text) & "'," & grossamt & "," & IIf(txtreceiamt.Text = "", 0, txtreceiamt.Text) & "," & netamt & ",'" & Muserid & "','" & dt & "')"
                            cmd.Connection = con

                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            Openconnection()
                            cmd = New OleDbCommand("delete * from enq_booking_amount where sysrefno=" & sysno & "", con)

                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            Openconnection()
                            cmd = New OleDbCommand("delete * from enq_booking_itinary where sysrefno=" & sysno & " ", con)

                            cmd.ExecuteNonQuery()
                            CloseConnection()
                            cmd.Dispose()
                            MsgSav()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                            CloseConnection()
                            Exit Sub
                        Finally
                            CloseConnection()
                        End Try
                    End If
                    'if status changed



                End If
                'End of recstatus Edit mode
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                CloseConnection()
                Exit Sub
            Finally
                CloseConnection()
            End Try

        End If

    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click


        If TabControl1.SelectedTab.Text = "View" Then

            Try
                ds.Clear()
                Openconnection()
                Dim da As New OleDbDataAdapter("select  * from booking_itinary ", con)
                da.Fill(ds, "ee")
                DataGrid2.DataSource = ds.Tables("ee")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                CloseConnection()
                Exit Sub
            Finally
                CloseConnection()

            End Try
        End If
    End Sub


    Private Sub txtreceiamt_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtreceiamt.Validated, txtreceiamt.Leave
        
        If txtextradiscou.Text = "" Then
            disc = 0
        Else
            disc = txtextradiscou.Text
        End If
        If txtreceiamt.Text = "" Then
            rec = 0
        Else
            rec = txtreceiamt.Text
        End If

        g = Val(txttotal.Text) - (Val(txttotal.Text) * (disc / 100))
        netamt = g - rec

        txtbalance.Text = netamt

    End Sub

    Private Sub combomodeofpay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combomodeofpay.KeyPress
        combo(e)
    End Sub

    Private Sub DataGrid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.DoubleClick

        disable()
        Dim stra, strb, strc, strd, stre, custname As String
        Dim dr As OleDbDataReader
        Dim i As Integer

        i = DataGrid2.CurrentCell.RowNumber
        Dim cmd As New OleDbCommand

        'To Retireve Customer name
        stre = CStr(DataGrid2.Item(i, 3))

        combostatus.SelectedItem = stre

        sysno = DataGrid2.Item(i, 0)
        bookingid = DataGrid2.Item(i, 1)


        stra = DataGrid2.Item(i, 2)
        custid = stra
        status = DataGrid2.Item(i, 3)
        Openconnection()
        cmd.CommandText = "select * from cust_master where custid='" & Trim(stra) & "'"
        cmd.Connection = con
        'Openconnection()

        dr = cmd.ExecuteReader
        If dr.Read Then

            txtcustname.Text = dr(1)
            txtstrtdate.Text = dr(4)
            txtenddate.Text = dr(5)
            txtagentname.Text = dr(6)
            txtnoofadults.Text = Convert.ToString(dr(8))
            txtnoofchlids.Text = dr(9)
            txtnoofinfants.Text = dr(10)
            noofper = Val(txtnoofadults.Text) + Val(txtnoofchlids.Text) + Val(txtnoofinfants.Text)
            txtperperson.Text = noofper
        End If
        dr.Close()
        CloseConnection()
        cmd.Dispose()
        Openconnection()

        cmd = New OleDbCommand("select * from booking_amount where transid=" & sysno & "", con)

        dr = cmd.ExecuteReader
        While dr.Read
            txtreceiamt.Text = dr(7)
            txtextradiscou.Text = Val(DataGrid2.Item(i, 8))
            txttotal.Text = Val(DataGrid2.Item(i, 6))
            txtdetails.Text = dr(5)
            txtremarks.Text = dr(6)
            combomodeofpay.SelectedItem = dr(4)
            dtppaydate.Value = dr(3)
            txttotal.Text = dr(7)
            txtreceiamt.Text = dr(8)
            txtbalance.Text = dr(9)
        End While
        dr.Close()
        CloseConnection()
        cmd.Dispose()


        txtperperson.Text = Val(DataGrid2.Item(i, 7))
        txtagentcomm.Text = Val(DataGrid2.Item(i, 10))
        'combopacid.Enabled = False
        'combopacsch.Enabled = False
        'combostatus.Enabled = False
        '
        'To Retirvew Schedule Start Date and End Date
        '

        strb = DataGrid2.Item(i, 4)
        combopacsch.SelectedItem = strb

        '        combopacsch.Text = strb
        Openconnection()
        cmd.CommandText = "select sch_stdate,sch_enddate from fp_schedule where trim(fpsch_id)='" & Trim(strb) & "'"
        cmd.Connection = con
        'Openconnection()

        dr = cmd.ExecuteReader
        If dr.Read() Then
            txtfromdate.Text = dr(0)
            txttodate.Text = dr(1)
        End If
        dr.Close()
        cmd.Dispose()
        CloseConnection()

        'Dim da1 As New OleDbDataAdapter("select * from fp_schedule where fpsch_id='" & Trim(strb) & "'", con)
        'da1.Fill(ds, "fpsch")
        'DataGrid1.DataSource = ds.Tables("fpsch")

        '
        'To Retriew Noof Days From Fixed Itinararies
        '

        strc = DataGrid2.Item(i, 5)
        combopacid.SelectedItem = strc
        Openconnection()

        cmd = New OleDbCommand("select noofdays from FixedItineraries where packageid='" & strc & "'", con)
        'Openconnection()
        txtnoofdays.Text = cmd.ExecuteScalar
        'CloseConnection()
        cmd.Dispose()
        'Openconnection()
        cmd.CommandText = "select Rate from FixedItineraries where packageid='" & strc & "'"
        cmd.Connection = con
        'Openconnection()


        txttotal.Text = cmd.ExecuteScalar
        'CloseConnection()
        cmd.Dispose()
        ' Openconnection()
        ' cmd.CommandText="select * from 
        ds.Clear()
        Dim da As New OleDbDataAdapter("select * from FixedItinera_Det where packageid='" & strc & "'", con)
        da.Fill(ds, "fxd")
        DataGrid1.DataSource = ds.Tables("fxd")
        CloseConnection()
        TabControl1.SelectedTab = TabEntry

        combostatus.Enabled = False

    End Sub
    Public Sub delproc()
        Dim st As String

        If MsgDelAlert() = vbYes Then
            Try


                If status = "Enquiry" Then

                    Openconnection()
                    cmd = New OleDbCommand("delete * from enq_booking_itinary where sysrefno=" & sysno & " ", con)

                    cmd.ExecuteNonQuery()
                    CloseConnection()
                    cmd.Dispose()
                    Openconnection()
                    cmd = New OleDbCommand("delete * from enq_booking_amount where sysrefno=" & sysno & "", con)

                    cmd.ExecuteNonQuery()
                    CloseConnection()
                    cmd.Dispose()
                    MsgSav()
                ElseIf status = "Confirm" Then
                    Openconnection()
                    cmd = New OleDbCommand("update booking_itinary set actflag='N' where sysrefno=" & sysno & "", con)

                    cmd.ExecuteNonQuery()
                    CloseConnection()
                    MsgSav()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                CloseConnection()
                Exit Sub
            Finally
                CloseConnection()
            End Try
            clearproc()


        End If
    End Sub

    Public Sub newproc()
        clearproc()
        txtcustname.Focus()
        enable()
        recstatus = Module1.EnuRecstatus.Recnew

    End Sub
    Public Sub disable()
        txtagentcomm.Enabled = False
        txtagentname.Enabled = False
        txtbalance.Enabled = False
        txtdetails.Enabled = False
        txtextradiscou.Enabled = False
        txtperperson.Enabled = False
        txtreceiamt.Enabled = False
        combostatus.Enabled = False
        combopacid.Enabled = False
        combopacsch.Enabled = False
        combomodeofpay.Enabled = False
        dtppaydate.Enabled = False
        btnsearch.Enabled = False
        txtremarks.Enabled = False
    End Sub


    Public Sub enable()
        dtppaydate.Enabled = True
        txtremarks.Enabled = True
        btnsearch.Enabled = True


        combopacid.Enabled = True
        combopacsch.Enabled = True
        combostatus.Enabled = True
        txtagentcomm.Enabled = True
        txtagentname.Enabled = True
        txtbalance.Enabled = True
        txtdetails.Enabled = True
        txtextradiscou.Enabled = True
        txtperperson.Enabled = True
        txtreceiamt.Enabled = True
        combostatus.Enabled = True
        combomodeofpay.Enabled = True
        dtppaydate.Enabled = True
        btnsearch.Enabled = True
        clearproc()
    End Sub


    Public Sub editproc()
        If status = "Enquiry" Then
            combostatus.Enabled = True
        End If
        enable()

        recstatus = Module1.EnuRecstatus.Recedit
    End Sub

    Private Sub FixItiner_Booking_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ds.Dispose()
    End Sub
    Public Sub clearproc()
        txttotal.Text = ""
        txtagentcomm.Text = ""
        txtagentname.Text = ""
        txtbalance.Text = ""
        txtbookingdate.Text = ""
        txtcustname.Text = ""
        txtdetails.Text = ""
        txtenddate.Text = ""
        txtextradiscou.Text = ""
        txtfromdate.Text = ""
        txtgroupname.Text = ""
        txtnoofadults.Text = ""
        txtnoofchlids.Text = ""
        txtnoofdays.Text = ""
        txtnoofinfants.Text = ""
        txtperperson.Text = ""
        txtreceiamt.Text = ""
        txtremarks.Text = ""
        txtstrtdate.Text = ""
        combostatus.SelectedItem = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim boli As Boolean = 0
        Dim da As OleDbDataAdapter

        If combostatusview.SelectedItem = "" Then
            MsgBox("Select Status First")
            boli = 1
        End If
        If combopacidview.SelectedItem = "" Then
            MsgBox("Select packageid")
            boli = 1
        End If
        Try

            Openconnection()
            If boli = 0 Then
                If combostatusview.SelectedItem = "Confirm" Then
                    da = New OleDbDataAdapter("select * from booking_itinary where trim(packageid)='" & combopacidview.SelectedItem & "'", con)
                End If
                If combostatusview.SelectedItem = "Enquiry" Then
                    da = New OleDbDataAdapter("select * from enq_booking_itinary where trim(packageid)='" & combopacidview.SelectedItem & "' ", con)
                End If
                ds.Clear()

                da.Fill(ds, "bookitiview")
                DataGrid2.DataSource = ds.Tables("bookitiview")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub txtreceiamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreceiamt.KeyPress, txtagentcomm.KeyPress, txtextradiscou.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtremarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtremarks.KeyPress, txtdetails.KeyPress
        textandnumbers(e)
    End Sub

End Class
