'Name developer: kamal.k.trood
'Dt:17/08/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class Cust_Member
    Inherits System.Windows.Forms.Form
    Dim recmode As EnuRecstatus   '  To findout record status
    Dim w As Boolean

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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtarrdetpfldetails As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents dtparrdepttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtparrdeptdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtarrafldetails As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtparrarrivaldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtparrarrivaltime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents grbpersonaldetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents grbpersonalinfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpexpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpassportno As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpannivdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cobmaritalstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grbph As System.Windows.Forms.GroupBox
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtwphone As System.Windows.Forms.TextBox
    Friend WithEvents txthphone As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grbaddress As System.Windows.Forms.GroupBox
    Friend WithEvents txtzip As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cobcity As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cobstate As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cobcountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grbinsurance As System.Windows.Forms.GroupBox
    Friend WithEvents txtcompany As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtpolicyno As System.Windows.Forms.TextBox
    Friend WithEvents rbno As System.Windows.Forms.RadioButton
    Friend WithEvents rbyes As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtnotes As System.Windows.Forms.TextBox
    Friend WithEvents grbbookingdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtgroup As System.Windows.Forms.TextBox
    Friend WithEvents labelgroupname As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents cobgender As System.Windows.Forms.ComboBox
    Friend WithEvents grbdeptdetails As System.Windows.Forms.GroupBox
    Friend WithEvents grbarrdetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmddatego As System.Windows.Forms.Button
    Friend WithEvents cmdcustidgo As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dbgsearch As System.Windows.Forms.DataGrid
    Friend WithEvents dtpsearchfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpsearchto As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcustidsearch As System.Windows.Forms.TextBox
    Friend WithEvents grbsearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cobmainperson As System.Windows.Forms.ComboBox
    Friend WithEvents txtbookingid As System.Windows.Forms.TextBox
    Friend WithEvents grbarrival As System.Windows.Forms.GroupBox
    Friend WithEvents grbdepartures As System.Windows.Forms.GroupBox
    Friend WithEvents dbgarr As System.Windows.Forms.DataGrid
    Friend WithEvents dbgdep As System.Windows.Forms.DataGrid
    Friend WithEvents cmdarrupdate As System.Windows.Forms.Button
    Friend WithEvents cmdarrcancel As System.Windows.Forms.Button
    Friend WithEvents cmddepcancel As System.Windows.Forms.Button
    Friend WithEvents cmddepupdate As System.Windows.Forms.Button
    Friend WithEvents txtsysrefno As System.Windows.Forms.TextBox
    Friend WithEvents cmdviewall As System.Windows.Forms.Button
    Friend WithEvents cmdgocustid As System.Windows.Forms.Button
    Friend WithEvents cmdgodate As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents dtptodateview As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfromdateview As System.Windows.Forms.DateTimePicker
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtbookingidview As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cust_Member))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label31 = New System.Windows.Forms.Label
        Me.cmdviewall = New System.Windows.Forms.Button
        Me.cmdgocustid = New System.Windows.Forms.Button
        Me.txtbookingidview = New System.Windows.Forms.TextBox
        Me.cmdgodate = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.dtptodateview = New System.Windows.Forms.DateTimePicker
        Me.dtpfromdateview = New System.Windows.Forms.DateTimePicker
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grbdepartures = New System.Windows.Forms.GroupBox
        Me.dbgdep = New System.Windows.Forms.DataGrid
        Me.cmddepcancel = New System.Windows.Forms.Button
        Me.cmddepupdate = New System.Windows.Forms.Button
        Me.grbarrival = New System.Windows.Forms.GroupBox
        Me.dbgarr = New System.Windows.Forms.DataGrid
        Me.cmdarrcancel = New System.Windows.Forms.Button
        Me.cmdarrupdate = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.grbdeptdetails = New System.Windows.Forms.GroupBox
        Me.txtarrdetpfldetails = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.dtparrdepttime = New System.Windows.Forms.DateTimePicker
        Me.dtparrdeptdate = New System.Windows.Forms.DateTimePicker
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.grbarrdetails = New System.Windows.Forms.GroupBox
        Me.txtarrafldetails = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.dtparrarrivaldate = New System.Windows.Forms.DateTimePicker
        Me.dtparrarrivaltime = New System.Windows.Forms.DateTimePicker
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.grbpersonaldetails = New System.Windows.Forms.GroupBox
        Me.grbsearch = New System.Windows.Forms.GroupBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdcustidgo = New System.Windows.Forms.Button
        Me.txtcustidsearch = New System.Windows.Forms.TextBox
        Me.dbgsearch = New System.Windows.Forms.DataGrid
        Me.cmddatego = New System.Windows.Forms.Button
        Me.dtpsearchto = New System.Windows.Forms.DateTimePicker
        Me.dtpsearchfrom = New System.Windows.Forms.DateTimePicker
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtsysrefno = New System.Windows.Forms.TextBox
        Me.cobmainperson = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.cobgender = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtage = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.grbpersonalinfo = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpexpdate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtpassportno = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtpannivdate = New System.Windows.Forms.DateTimePicker
        Me.cobmaritalstatus = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpdob = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.grbph = New System.Windows.Forms.GroupBox
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtfax = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtwphone = New System.Windows.Forms.TextBox
        Me.txthphone = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.grbaddress = New System.Windows.Forms.GroupBox
        Me.txtzip = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cobcity = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cobstate = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cobcountry = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmname = New System.Windows.Forms.TextBox
        Me.txtlname = New System.Windows.Forms.TextBox
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grbbookingdetails = New System.Windows.Forms.GroupBox
        Me.txtbookingid = New System.Windows.Forms.TextBox
        Me.txtcustid = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtgroup = New System.Windows.Forms.TextBox
        Me.labelgroupname = New System.Windows.Forms.Label
        Me.grbinsurance = New System.Windows.Forms.GroupBox
        Me.txtcompany = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtpolicyno = New System.Windows.Forms.TextBox
        Me.rbno = New System.Windows.Forms.RadioButton
        Me.rbyes = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtnotes = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.grbdepartures.SuspendLayout()
        CType(Me.dbgdep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbarrival.SuspendLayout()
        CType(Me.dbgarr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.grbdeptdetails.SuspendLayout()
        Me.grbarrdetails.SuspendLayout()
        Me.grbpersonaldetails.SuspendLayout()
        Me.grbsearch.SuspendLayout()
        CType(Me.dbgsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbpersonalinfo.SuspendLayout()
        Me.grbph.SuspendLayout()
        Me.grbaddress.SuspendLayout()
        Me.grbbookingdetails.SuspendLayout()
        Me.grbinsurance.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(672, 464)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.cmdviewall)
        Me.TabPage1.Controls.Add(Me.cmdgocustid)
        Me.TabPage1.Controls.Add(Me.txtbookingidview)
        Me.TabPage1.Controls.Add(Me.cmdgodate)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.dtptodateview)
        Me.TabPage1.Controls.Add(Me.dtpfromdateview)
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(664, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(472, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(58, 13)
        Me.Label31.TabIndex = 18
        Me.Label31.Text = "Booking Id"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdviewall
        '
        Me.cmdviewall.Location = New System.Drawing.Point(376, 24)
        Me.cmdviewall.Name = "cmdviewall"
        Me.cmdviewall.Size = New System.Drawing.Size(75, 23)
        Me.cmdviewall.TabIndex = 17
        Me.cmdviewall.Text = "View All"
        '
        'cmdgocustid
        '
        Me.cmdgocustid.Location = New System.Drawing.Point(652, 64)
        Me.cmdgocustid.Name = "cmdgocustid"
        Me.cmdgocustid.Size = New System.Drawing.Size(32, 23)
        Me.cmdgocustid.TabIndex = 16
        Me.cmdgocustid.Text = "GO"
        '
        'txtbookingidview
        '
        Me.txtbookingidview.Location = New System.Drawing.Point(540, 64)
        Me.txtbookingidview.MaxLength = 10
        Me.txtbookingidview.Name = "txtbookingidview"
        Me.txtbookingidview.Size = New System.Drawing.Size(100, 20)
        Me.txtbookingidview.TabIndex = 15
        '
        'cmdgodate
        '
        Me.cmdgodate.Location = New System.Drawing.Point(312, 64)
        Me.cmdgodate.Name = "cmdgodate"
        Me.cmdgodate.Size = New System.Drawing.Size(32, 23)
        Me.cmdgodate.TabIndex = 14
        Me.cmdgodate.Text = "GO"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(184, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(20, 13)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "To"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(24, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 13)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "From"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtptodateview
        '
        Me.dtptodateview.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptodateview.Location = New System.Drawing.Point(216, 64)
        Me.dtptodateview.Name = "dtptodateview"
        Me.dtptodateview.Size = New System.Drawing.Size(88, 20)
        Me.dtptodateview.TabIndex = 11
        '
        'dtpfromdateview
        '
        Me.dtpfromdateview.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfromdateview.Location = New System.Drawing.Point(72, 64)
        Me.dtpfromdateview.Name = "dtpfromdateview"
        Me.dtpfromdateview.Size = New System.Drawing.Size(88, 20)
        Me.dtpfromdateview.TabIndex = 10
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(12, 104)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.Size = New System.Drawing.Size(700, 352)
        Me.dbgview.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grbdepartures)
        Me.TabPage2.Controls.Add(Me.grbarrival)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.grbpersonaldetails)
        Me.TabPage2.Controls.Add(Me.grbbookingdetails)
        Me.TabPage2.Controls.Add(Me.grbinsurance)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(664, 438)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'grbdepartures
        '
        Me.grbdepartures.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbdepartures.Controls.Add(Me.dbgdep)
        Me.grbdepartures.Controls.Add(Me.cmddepcancel)
        Me.grbdepartures.Controls.Add(Me.cmddepupdate)
        Me.grbdepartures.Location = New System.Drawing.Point(344, 232)
        Me.grbdepartures.Name = "grbdepartures"
        Me.grbdepartures.Size = New System.Drawing.Size(304, 184)
        Me.grbdepartures.TabIndex = 99
        Me.grbdepartures.TabStop = False
        Me.grbdepartures.Text = "Departure Details"
        Me.grbdepartures.Visible = False
        '
        'dbgdep
        '
        Me.dbgdep.CaptionVisible = False
        Me.dbgdep.DataMember = ""
        Me.dbgdep.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgdep.Location = New System.Drawing.Point(12, 24)
        Me.dbgdep.Name = "dbgdep"
        Me.dbgdep.Size = New System.Drawing.Size(276, 128)
        Me.dbgdep.TabIndex = 1
        '
        'cmddepcancel
        '
        Me.cmddepcancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddepcancel.Location = New System.Drawing.Point(204, 160)
        Me.cmddepcancel.Name = "cmddepcancel"
        Me.cmddepcancel.Size = New System.Drawing.Size(56, 23)
        Me.cmddepcancel.TabIndex = 13
        Me.cmddepcancel.Text = "Cancel"
        '
        'cmddepupdate
        '
        Me.cmddepupdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddepupdate.Location = New System.Drawing.Point(76, 160)
        Me.cmddepupdate.Name = "cmddepupdate"
        Me.cmddepupdate.Size = New System.Drawing.Size(64, 23)
        Me.cmddepupdate.TabIndex = 12
        Me.cmddepupdate.Text = "Update"
        '
        'grbarrival
        '
        Me.grbarrival.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbarrival.Controls.Add(Me.dbgarr)
        Me.grbarrival.Controls.Add(Me.cmdarrcancel)
        Me.grbarrival.Controls.Add(Me.cmdarrupdate)
        Me.grbarrival.Location = New System.Drawing.Point(16, 224)
        Me.grbarrival.Name = "grbarrival"
        Me.grbarrival.Size = New System.Drawing.Size(312, 184)
        Me.grbarrival.TabIndex = 98
        Me.grbarrival.TabStop = False
        Me.grbarrival.Text = "Arrival Details"
        Me.grbarrival.Visible = False
        '
        'dbgarr
        '
        Me.dbgarr.CaptionVisible = False
        Me.dbgarr.DataMember = ""
        Me.dbgarr.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgarr.Location = New System.Drawing.Point(8, 40)
        Me.dbgarr.Name = "dbgarr"
        Me.dbgarr.Size = New System.Drawing.Size(296, 128)
        Me.dbgarr.TabIndex = 0
        '
        'cmdarrcancel
        '
        Me.cmdarrcancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdarrcancel.Location = New System.Drawing.Point(204, 160)
        Me.cmdarrcancel.Name = "cmdarrcancel"
        Me.cmdarrcancel.Size = New System.Drawing.Size(56, 23)
        Me.cmdarrcancel.TabIndex = 11
        Me.cmdarrcancel.Text = "Cancel"
        '
        'cmdarrupdate
        '
        Me.cmdarrupdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdarrupdate.Location = New System.Drawing.Point(76, 160)
        Me.cmdarrupdate.Name = "cmdarrupdate"
        Me.cmdarrupdate.Size = New System.Drawing.Size(64, 23)
        Me.cmdarrupdate.TabIndex = 10
        Me.cmdarrupdate.Text = "Update"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grbdeptdetails)
        Me.GroupBox3.Controls.Add(Me.grbarrdetails)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 352)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(664, 80)
        Me.GroupBox3.TabIndex = 305
        Me.GroupBox3.TabStop = False
        '
        'grbdeptdetails
        '
        Me.grbdeptdetails.Controls.Add(Me.txtarrdetpfldetails)
        Me.grbdeptdetails.Controls.Add(Me.Label40)
        Me.grbdeptdetails.Controls.Add(Me.dtparrdepttime)
        Me.grbdeptdetails.Controls.Add(Me.dtparrdeptdate)
        Me.grbdeptdetails.Controls.Add(Me.Label38)
        Me.grbdeptdetails.Controls.Add(Me.Label37)
        Me.grbdeptdetails.Location = New System.Drawing.Point(352, 8)
        Me.grbdeptdetails.Name = "grbdeptdetails"
        Me.grbdeptdetails.Size = New System.Drawing.Size(304, 72)
        Me.grbdeptdetails.TabIndex = 307
        Me.grbdeptdetails.TabStop = False
        Me.grbdeptdetails.Text = "Departure Details"
        '
        'txtarrdetpfldetails
        '
        Me.txtarrdetpfldetails.BackColor = System.Drawing.Color.Gainsboro
        Me.txtarrdetpfldetails.Location = New System.Drawing.Point(88, 48)
        Me.txtarrdetpfldetails.Name = "txtarrdetpfldetails"
        Me.txtarrdetpfldetails.Size = New System.Drawing.Size(96, 20)
        Me.txtarrdetpfldetails.TabIndex = 34
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 48)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(67, 13)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "Flight Details"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtparrdepttime
        '
        Me.dtparrdepttime.CustomFormat = "HH:mm"
        Me.dtparrdepttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtparrdepttime.Location = New System.Drawing.Point(232, 24)
        Me.dtparrdepttime.Name = "dtparrdepttime"
        Me.dtparrdepttime.ShowUpDown = True
        Me.dtparrdepttime.Size = New System.Drawing.Size(56, 20)
        Me.dtparrdepttime.TabIndex = 33
        '
        'dtparrdeptdate
        '
        Me.dtparrdeptdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtparrdeptdate.Location = New System.Drawing.Point(88, 24)
        Me.dtparrdeptdate.Name = "dtparrdeptdate"
        Me.dtparrdeptdate.ShowCheckBox = True
        Me.dtparrdeptdate.Size = New System.Drawing.Size(96, 20)
        Me.dtparrdeptdate.TabIndex = 32
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(192, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(30, 13)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Time"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(8, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(80, 13)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Departure Date"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbarrdetails
        '
        Me.grbarrdetails.Controls.Add(Me.txtarrafldetails)
        Me.grbarrdetails.Controls.Add(Me.Label39)
        Me.grbarrdetails.Controls.Add(Me.dtparrarrivaldate)
        Me.grbarrdetails.Controls.Add(Me.dtparrarrivaltime)
        Me.grbarrdetails.Controls.Add(Me.Label36)
        Me.grbarrdetails.Controls.Add(Me.Label35)
        Me.grbarrdetails.Location = New System.Drawing.Point(8, 8)
        Me.grbarrdetails.Name = "grbarrdetails"
        Me.grbarrdetails.Size = New System.Drawing.Size(344, 72)
        Me.grbarrdetails.TabIndex = 306
        Me.grbarrdetails.TabStop = False
        Me.grbarrdetails.Text = "Arrival Details"
        '
        'txtarrafldetails
        '
        Me.txtarrafldetails.BackColor = System.Drawing.Color.Gainsboro
        Me.txtarrafldetails.Location = New System.Drawing.Point(96, 48)
        Me.txtarrafldetails.Name = "txtarrafldetails"
        Me.txtarrafldetails.Size = New System.Drawing.Size(112, 20)
        Me.txtarrafldetails.TabIndex = 31
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(16, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(67, 13)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "Flight Details"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtparrarrivaldate
        '
        Me.dtparrarrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtparrarrivaldate.Location = New System.Drawing.Point(96, 24)
        Me.dtparrarrivaldate.Name = "dtparrarrivaldate"
        Me.dtparrarrivaldate.ShowCheckBox = True
        Me.dtparrarrivaldate.Size = New System.Drawing.Size(112, 20)
        Me.dtparrarrivaldate.TabIndex = 29
        '
        'dtparrarrivaltime
        '
        Me.dtparrarrivaltime.CustomFormat = "HH:mm"
        Me.dtparrarrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtparrarrivaltime.Location = New System.Drawing.Point(264, 24)
        Me.dtparrarrivaltime.Name = "dtparrarrivaltime"
        Me.dtparrarrivaltime.ShowUpDown = True
        Me.dtparrarrivaltime.Size = New System.Drawing.Size(56, 20)
        Me.dtparrarrivaltime.TabIndex = 30
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(224, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(30, 13)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Time"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(16, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Arrival Date"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbpersonaldetails
        '
        Me.grbpersonaldetails.Controls.Add(Me.grbsearch)
        Me.grbpersonaldetails.Controls.Add(Me.txtsysrefno)
        Me.grbpersonaldetails.Controls.Add(Me.cobmainperson)
        Me.grbpersonaldetails.Controls.Add(Me.Label27)
        Me.grbpersonaldetails.Controls.Add(Me.cobgender)
        Me.grbpersonaldetails.Controls.Add(Me.Label22)
        Me.grbpersonaldetails.Controls.Add(Me.txtage)
        Me.grbpersonaldetails.Controls.Add(Me.Label20)
        Me.grbpersonaldetails.Controls.Add(Me.grbpersonalinfo)
        Me.grbpersonaldetails.Controls.Add(Me.grbph)
        Me.grbpersonaldetails.Controls.Add(Me.grbaddress)
        Me.grbpersonaldetails.Controls.Add(Me.txtmname)
        Me.grbpersonaldetails.Controls.Add(Me.txtlname)
        Me.grbpersonaldetails.Controls.Add(Me.txtfname)
        Me.grbpersonaldetails.Controls.Add(Me.Label3)
        Me.grbpersonaldetails.Controls.Add(Me.Label1)
        Me.grbpersonaldetails.Controls.Add(Me.Label2)
        Me.grbpersonaldetails.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbpersonaldetails.Location = New System.Drawing.Point(0, 48)
        Me.grbpersonaldetails.Name = "grbpersonaldetails"
        Me.grbpersonaldetails.Size = New System.Drawing.Size(648, 208)
        Me.grbpersonaldetails.TabIndex = 300
        Me.grbpersonaldetails.TabStop = False
        '
        'grbsearch
        '
        Me.grbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbsearch.Controls.Add(Me.Label26)
        Me.grbsearch.Controls.Add(Me.cmdclose)
        Me.grbsearch.Controls.Add(Me.cmdupdate)
        Me.grbsearch.Controls.Add(Me.cmdcustidgo)
        Me.grbsearch.Controls.Add(Me.txtcustidsearch)
        Me.grbsearch.Controls.Add(Me.dbgsearch)
        Me.grbsearch.Controls.Add(Me.cmddatego)
        Me.grbsearch.Controls.Add(Me.dtpsearchto)
        Me.grbsearch.Controls.Add(Me.dtpsearchfrom)
        Me.grbsearch.Controls.Add(Me.Label25)
        Me.grbsearch.Controls.Add(Me.Label24)
        Me.grbsearch.Location = New System.Drawing.Point(104, 14)
        Me.grbsearch.Name = "grbsearch"
        Me.grbsearch.Size = New System.Drawing.Size(504, 224)
        Me.grbsearch.TabIndex = 98
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
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(296, 200)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(56, 23)
        Me.cmdclose.TabIndex = 9
        Me.cmdclose.Text = "Cancel"
        '
        'cmdupdate
        '
        Me.cmdupdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(168, 202)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(64, 23)
        Me.cmdupdate.TabIndex = 8
        Me.cmdupdate.Text = "Update"
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
        'txtsysrefno
        '
        Me.txtsysrefno.Location = New System.Drawing.Point(592, 32)
        Me.txtsysrefno.Name = "txtsysrefno"
        Me.txtsysrefno.Size = New System.Drawing.Size(40, 21)
        Me.txtsysrefno.TabIndex = 101
        Me.txtsysrefno.Visible = False
        '
        'cobmainperson
        '
        Me.cobmainperson.Items.AddRange(New Object() {"Yes", "No"})
        Me.cobmainperson.Location = New System.Drawing.Point(520, 32)
        Me.cobmainperson.Name = "cobmainperson"
        Me.cobmainperson.Size = New System.Drawing.Size(72, 21)
        Me.cobmainperson.TabIndex = 8
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(432, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(83, 13)
        Me.Label27.TabIndex = 100
        Me.Label27.Text = "Main Person*"
        '
        'cobgender
        '
        Me.cobgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cobgender.Location = New System.Drawing.Point(288, 32)
        Me.cobgender.Name = "cobgender"
        Me.cobgender.Size = New System.Drawing.Size(96, 21)
        Me.cobgender.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(232, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 13)
        Me.Label22.TabIndex = 84
        Me.Label22.Text = "Gender *"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(80, 32)
        Me.txtage.MaxLength = 3
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(40, 21)
        Me.txtage.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 13)
        Me.Label20.TabIndex = 82
        Me.Label20.Text = "Age"
        '
        'grbpersonalinfo
        '
        Me.grbpersonalinfo.Controls.Add(Me.Label13)
        Me.grbpersonalinfo.Controls.Add(Me.dtpexpdate)
        Me.grbpersonalinfo.Controls.Add(Me.Label9)
        Me.grbpersonalinfo.Controls.Add(Me.txtpassportno)
        Me.grbpersonalinfo.Controls.Add(Me.Label17)
        Me.grbpersonalinfo.Controls.Add(Me.dtpannivdate)
        Me.grbpersonalinfo.Controls.Add(Me.cobmaritalstatus)
        Me.grbpersonalinfo.Controls.Add(Me.Label18)
        Me.grbpersonalinfo.Controls.Add(Me.dtpdob)
        Me.grbpersonalinfo.Controls.Add(Me.Label10)
        Me.grbpersonalinfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbpersonalinfo.Location = New System.Drawing.Point(408, 56)
        Me.grbpersonalinfo.Name = "grbpersonalinfo"
        Me.grbpersonalinfo.Size = New System.Drawing.Size(232, 144)
        Me.grbpersonalinfo.TabIndex = 303
        Me.grbpersonalinfo.TabStop = False
        Me.grbpersonalinfo.Text = "Personal Info"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Expiry Date"
        '
        'dtpexpdate
        '
        Me.dtpexpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpexpdate.Location = New System.Drawing.Point(104, 120)
        Me.dtpexpdate.Name = "dtpexpdate"
        Me.dtpexpdate.ShowCheckBox = True
        Me.dtpexpdate.Size = New System.Drawing.Size(120, 21)
        Me.dtpexpdate.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Passport No"
        '
        'txtpassportno
        '
        Me.txtpassportno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassportno.Location = New System.Drawing.Point(104, 96)
        Me.txtpassportno.MaxLength = 30
        Me.txtpassportno.Name = "txtpassportno"
        Me.txtpassportno.Size = New System.Drawing.Size(120, 21)
        Me.txtpassportno.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 13)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Annivarsary Date"
        '
        'dtpannivdate
        '
        Me.dtpannivdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpannivdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpannivdate.Location = New System.Drawing.Point(104, 72)
        Me.dtpannivdate.Name = "dtpannivdate"
        Me.dtpannivdate.ShowCheckBox = True
        Me.dtpannivdate.Size = New System.Drawing.Size(120, 21)
        Me.dtpannivdate.TabIndex = 21
        '
        'cobmaritalstatus
        '
        Me.cobmaritalstatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobmaritalstatus.Items.AddRange(New Object() {"Married", "Unmarried"})
        Me.cobmaritalstatus.Location = New System.Drawing.Point(104, 48)
        Me.cobmaritalstatus.Name = "cobmaritalstatus"
        Me.cobmaritalstatus.Size = New System.Drawing.Size(120, 21)
        Me.cobmaritalstatus.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Marital Status"
        '
        'dtpdob
        '
        Me.dtpdob.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdob.Location = New System.Drawing.Point(104, 24)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.ShowCheckBox = True
        Me.dtpdob.Size = New System.Drawing.Size(120, 21)
        Me.dtpdob.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Birth Date"
        '
        'grbph
        '
        Me.grbph.Controls.Add(Me.txtmobile)
        Me.grbph.Controls.Add(Me.Label19)
        Me.grbph.Controls.Add(Me.Label21)
        Me.grbph.Controls.Add(Me.txtemail)
        Me.grbph.Controls.Add(Me.Label15)
        Me.grbph.Controls.Add(Me.txtfax)
        Me.grbph.Controls.Add(Me.Label11)
        Me.grbph.Controls.Add(Me.txtwphone)
        Me.grbph.Controls.Add(Me.txthphone)
        Me.grbph.Controls.Add(Me.Label14)
        Me.grbph.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbph.Location = New System.Drawing.Point(208, 56)
        Me.grbph.Name = "grbph"
        Me.grbph.Size = New System.Drawing.Size(200, 144)
        Me.grbph.TabIndex = 302
        Me.grbph.TabStop = False
        Me.grbph.Text = "Phone  Email"
        '
        'txtmobile
        '
        Me.txtmobile.Location = New System.Drawing.Point(80, 72)
        Me.txtmobile.MaxLength = 12
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(104, 21)
        Me.txtmobile.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Mobile No"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Email Id"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(80, 120)
        Me.txtemail.MaxLength = 25
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(104, 21)
        Me.txtemail.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Fax No"
        '
        'txtfax
        '
        Me.txtfax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfax.Location = New System.Drawing.Point(80, 96)
        Me.txtfax.MaxLength = 12
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(104, 21)
        Me.txtfax.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Work Phone"
        '
        'txtwphone
        '
        Me.txtwphone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwphone.Location = New System.Drawing.Point(80, 48)
        Me.txtwphone.MaxLength = 12
        Me.txtwphone.Name = "txtwphone"
        Me.txtwphone.Size = New System.Drawing.Size(104, 21)
        Me.txtwphone.TabIndex = 15
        '
        'txthphone
        '
        Me.txthphone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthphone.Location = New System.Drawing.Point(80, 24)
        Me.txthphone.MaxLength = 12
        Me.txthphone.Name = "txthphone"
        Me.txthphone.Size = New System.Drawing.Size(104, 21)
        Me.txthphone.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Home Phone"
        '
        'grbaddress
        '
        Me.grbaddress.Controls.Add(Me.txtzip)
        Me.grbaddress.Controls.Add(Me.Label8)
        Me.grbaddress.Controls.Add(Me.cobcity)
        Me.grbaddress.Controls.Add(Me.Label7)
        Me.grbaddress.Controls.Add(Me.cobstate)
        Me.grbaddress.Controls.Add(Me.Label6)
        Me.grbaddress.Controls.Add(Me.cobcountry)
        Me.grbaddress.Controls.Add(Me.Label5)
        Me.grbaddress.Controls.Add(Me.txtaddress)
        Me.grbaddress.Controls.Add(Me.Label4)
        Me.grbaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbaddress.Location = New System.Drawing.Point(8, 56)
        Me.grbaddress.Name = "grbaddress"
        Me.grbaddress.Size = New System.Drawing.Size(200, 144)
        Me.grbaddress.TabIndex = 301
        Me.grbaddress.TabStop = False
        Me.grbaddress.Text = "Address"
        '
        'txtzip
        '
        Me.txtzip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtzip.Location = New System.Drawing.Point(64, 120)
        Me.txtzip.MaxLength = 7
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(128, 21)
        Me.txtzip.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "ZIP"
        '
        'cobcity
        '
        Me.cobcity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcity.ItemHeight = 13
        Me.cobcity.Location = New System.Drawing.Point(64, 96)
        Me.cobcity.Name = "cobcity"
        Me.cobcity.Size = New System.Drawing.Size(128, 21)
        Me.cobcity.Sorted = True
        Me.cobcity.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Country*"
        '
        'cobstate
        '
        Me.cobstate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobstate.ItemHeight = 13
        Me.cobstate.Location = New System.Drawing.Point(64, 72)
        Me.cobstate.Name = "cobstate"
        Me.cobstate.Size = New System.Drawing.Size(128, 21)
        Me.cobstate.Sorted = True
        Me.cobstate.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "State*"
        '
        'cobcountry
        '
        Me.cobcountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcountry.ItemHeight = 13
        Me.cobcountry.Location = New System.Drawing.Point(64, 48)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(128, 21)
        Me.cobcountry.Sorted = True
        Me.cobcountry.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "City*"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(64, 24)
        Me.txtaddress.MaxLength = 150
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(128, 21)
        Me.txtaddress.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Address"
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(512, 8)
        Me.txtmname.MaxLength = 15
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(120, 21)
        Me.txtmname.TabIndex = 5
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(288, 8)
        Me.txtlname.MaxLength = 15
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(128, 21)
        Me.txtlname.TabIndex = 4
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(80, 8)
        Me.txtfname.MaxLength = 15
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(128, 21)
        Me.txtfname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Middle Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "First Name*"
        '
        'grbbookingdetails
        '
        Me.grbbookingdetails.Controls.Add(Me.txtbookingid)
        Me.grbbookingdetails.Controls.Add(Me.txtcustid)
        Me.grbbookingdetails.Controls.Add(Me.Label23)
        Me.grbbookingdetails.Controls.Add(Me.cmdsearch)
        Me.grbbookingdetails.Controls.Add(Me.Label16)
        Me.grbbookingdetails.Controls.Add(Me.txtgroup)
        Me.grbbookingdetails.Controls.Add(Me.labelgroupname)
        Me.grbbookingdetails.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbbookingdetails.Location = New System.Drawing.Point(0, 0)
        Me.grbbookingdetails.Name = "grbbookingdetails"
        Me.grbbookingdetails.Size = New System.Drawing.Size(648, 48)
        Me.grbbookingdetails.TabIndex = 96
        Me.grbbookingdetails.TabStop = False
        Me.grbbookingdetails.Text = "Booking Details"
        '
        'txtbookingid
        '
        Me.txtbookingid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookingid.Location = New System.Drawing.Point(88, 16)
        Me.txtbookingid.MaxLength = 20
        Me.txtbookingid.Name = "txtbookingid"
        Me.txtbookingid.Size = New System.Drawing.Size(88, 21)
        Me.txtbookingid.TabIndex = 0
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(304, 17)
        Me.txtcustid.MaxLength = 10
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.ReadOnly = True
        Me.txtcustid.Size = New System.Drawing.Size(104, 21)
        Me.txtcustid.TabIndex = 95
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(240, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 94
        Me.Label23.Text = "Client Id *"
        '
        'cmdsearch
        '
        Me.cmdsearch.Location = New System.Drawing.Point(176, 16)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(56, 24)
        Me.cmdsearch.TabIndex = 1
        Me.cmdsearch.Text = "Search"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Booking Id *"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtgroup
        '
        Me.txtgroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgroup.Location = New System.Drawing.Point(504, 16)
        Me.txtgroup.MaxLength = 20
        Me.txtgroup.Name = "txtgroup"
        Me.txtgroup.Size = New System.Drawing.Size(120, 21)
        Me.txtgroup.TabIndex = 2
        '
        'labelgroupname
        '
        Me.labelgroupname.AutoSize = True
        Me.labelgroupname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelgroupname.Location = New System.Drawing.Point(432, 16)
        Me.labelgroupname.Name = "labelgroupname"
        Me.labelgroupname.Size = New System.Drawing.Size(79, 13)
        Me.labelgroupname.TabIndex = 87
        Me.labelgroupname.Text = "Group Name"
        Me.labelgroupname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbinsurance
        '
        Me.grbinsurance.BackColor = System.Drawing.SystemColors.Control
        Me.grbinsurance.Controls.Add(Me.txtcompany)
        Me.grbinsurance.Controls.Add(Me.Label32)
        Me.grbinsurance.Controls.Add(Me.Label29)
        Me.grbinsurance.Controls.Add(Me.txtpolicyno)
        Me.grbinsurance.Controls.Add(Me.rbno)
        Me.grbinsurance.Controls.Add(Me.rbyes)
        Me.grbinsurance.Controls.Add(Me.Label12)
        Me.grbinsurance.Controls.Add(Me.txtnotes)
        Me.grbinsurance.Location = New System.Drawing.Point(0, 256)
        Me.grbinsurance.Name = "grbinsurance"
        Me.grbinsurance.Size = New System.Drawing.Size(656, 96)
        Me.grbinsurance.TabIndex = 304
        Me.grbinsurance.TabStop = False
        Me.grbinsurance.Text = "Insurance Policy Taken"
        '
        'txtcompany
        '
        Me.txtcompany.Location = New System.Drawing.Point(80, 72)
        Me.txtcompany.MaxLength = 50
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.Size = New System.Drawing.Size(104, 20)
        Me.txtcompany.TabIndex = 27
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 72)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(54, 13)
        Me.Label32.TabIndex = 5
        Me.Label32.Text = "Company "
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(16, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 16)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Policy No"
        '
        'txtpolicyno
        '
        Me.txtpolicyno.Location = New System.Drawing.Point(80, 48)
        Me.txtpolicyno.MaxLength = 30
        Me.txtpolicyno.Name = "txtpolicyno"
        Me.txtpolicyno.Size = New System.Drawing.Size(104, 20)
        Me.txtpolicyno.TabIndex = 26
        '
        'rbno
        '
        Me.rbno.Location = New System.Drawing.Point(120, 24)
        Me.rbno.Name = "rbno"
        Me.rbno.Size = New System.Drawing.Size(40, 16)
        Me.rbno.TabIndex = 25
        Me.rbno.Text = "No"
        '
        'rbyes
        '
        Me.rbyes.Checked = True
        Me.rbyes.Location = New System.Drawing.Point(16, 16)
        Me.rbyes.Name = "rbyes"
        Me.rbyes.Size = New System.Drawing.Size(88, 24)
        Me.rbyes.TabIndex = 24
        Me.rbyes.TabStop = True
        Me.rbyes.Text = "Yes Taken"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(216, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Additional Notes"
        '
        'txtnotes
        '
        Me.txtnotes.Location = New System.Drawing.Point(328, 16)
        Me.txtnotes.MaxLength = 250
        Me.txtnotes.Multiline = True
        Me.txtnotes.Name = "txtnotes"
        Me.txtnotes.Size = New System.Drawing.Size(312, 72)
        Me.txtnotes.TabIndex = 28
        '
        'Cust_Member
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 469)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cust_Member"
        Me.Text = "Client Arrival Departure"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.grbdepartures.ResumeLayout(False)
        CType(Me.dbgdep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbarrival.ResumeLayout(False)
        CType(Me.dbgarr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.grbdeptdetails.ResumeLayout(False)
        Me.grbdeptdetails.PerformLayout()
        Me.grbarrdetails.ResumeLayout(False)
        Me.grbarrdetails.PerformLayout()
        Me.grbpersonaldetails.ResumeLayout(False)
        Me.grbpersonaldetails.PerformLayout()
        Me.grbsearch.ResumeLayout(False)
        Me.grbsearch.PerformLayout()
        CType(Me.dbgsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbpersonalinfo.ResumeLayout(False)
        Me.grbpersonalinfo.PerformLayout()
        Me.grbph.ResumeLayout(False)
        Me.grbph.PerformLayout()
        Me.grbaddress.ResumeLayout(False)
        Me.grbaddress.PerformLayout()
        Me.grbbookingdetails.ResumeLayout(False)
        Me.grbbookingdetails.PerformLayout()
        Me.grbinsurance.ResumeLayout(False)
        Me.grbinsurance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'opens entry/edit page on pageload
        TabControl1.SelectedTab = TabPage2

        'fills the combobox from country master table
        combofill1(cobcountry, "select * from countrymaster")

        ' locks the controls in entry/edit tabpage 
        lock()

        'restricting dates 
        Dim n As Date
        n = FormatDateTime(Now.Date, DateFormat.ShortDate)
        dtpdob.MaxDate = DateAdd(DateInterval.Day, -1, n)
        dtpannivdate.MaxDate = FormatDateTime(Now.Date, DateFormat.ShortDate)
        dtpfromdateview.MaxDate = DateAdd(DateInterval.Day, -1, Now.Date)
    End Sub
    Public Sub lock()
        ' locks the controls in entry/edit tabpage 
        cmdsearch.Enabled = False
        txtbookingid.ReadOnly = True
        txtcustid.ReadOnly = True
        txtgroup.ReadOnly = True
        txtfname.ReadOnly = True
        txtlname.ReadOnly = True
        txtmname.ReadOnly = True
        txtage.ReadOnly = True
        cobgender.Enabled = False
        cobmainperson.Enabled = False
        txtaddress.ReadOnly = True
        cobcountry.Enabled = False
        cobstate.Enabled = False
        cobcity.Enabled = False
        txtzip.ReadOnly = True
        txthphone.ReadOnly = True
        txtwphone.ReadOnly = True
        txtmobile.ReadOnly = True
        txtfax.ReadOnly = True
        txtemail.ReadOnly = True
        dtpdob.Enabled = False
        cobmaritalstatus.Enabled = False
        dtpannivdate.Enabled = False
        txtpassportno.ReadOnly = True
        dtpexpdate.Enabled = False
        rbyes.Enabled = False
        rbno.Enabled = False
        txtpolicyno.ReadOnly = True
        txtcompany.ReadOnly = True
        txtnotes.ReadOnly = True
        dtparrarrivaldate.Enabled = False
        dtparrarrivaltime.Enabled = False
        txtarrafldetails.ReadOnly = True
        dtparrdeptdate.Enabled = False
        dtparrdepttime.Enabled = False
        txtarrdetpfldetails.ReadOnly = True
    End Sub
    'Clears the controls on the form
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.grbbookingdetails.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbpersonaldetails.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbaddress.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbph.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbpersonalinfo.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbinsurance.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        txtarrafldetails.Text = ""
        txtarrdetpfldetails.Text = ""
    End Sub
    'It enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        'clears the controls
        clearproc()
        ' unlocks the controls
        cmdsearch.Enabled = True
        txtbookingid.ReadOnly = False
        txtgroup.ReadOnly = False
        txtfname.ReadOnly = False
        txtlname.ReadOnly = False
        txtmname.ReadOnly = False
        txtage.ReadOnly = False
        cobgender.Enabled = True
        cobmainperson.Enabled = True
        txtaddress.ReadOnly = False
        cobcountry.Enabled = True
        cobstate.Enabled = True
        cobcity.Enabled = True
        txtzip.ReadOnly = False
        txthphone.ReadOnly = False
        txtwphone.ReadOnly = False
        txtmobile.ReadOnly = False
        txtfax.ReadOnly = False
        txtemail.ReadOnly = False
        dtpdob.Enabled = True
        cobmaritalstatus.Enabled = True
        dtpannivdate.Enabled = True
        txtpassportno.ReadOnly = False
        dtpexpdate.Enabled = True
        rbyes.Enabled = True
        rbno.Enabled = True
        rbno.Checked = True
        'txtpolicyno.ReadOnly = False
        'txtcompany.ReadOnly = False
        txtnotes.ReadOnly = False
        dtparrarrivaldate.Enabled = True
        dtparrarrivaltime.Enabled = True
        txtarrafldetails.ReadOnly = False
        dtparrdeptdate.Enabled = True
        dtparrdepttime.Enabled = True
        txtarrdetpfldetails.ReadOnly = False
        'checkboxes present in datepicker are in unchecked mode
        If dtpannivdate.Checked = True Then
            dtpannivdate.Checked = False
        End If
        If dtpdob.Checked = True Then
            dtpdob.Checked = False
        End If
        If dtpexpdate.Checked = True Then
            dtpexpdate.Checked = False
        End If
        If dtparrarrivaldate.Checked = True Then
            dtparrarrivaldate.Checked = False
        End If
        If dtparrdeptdate.Checked = True Then
            dtparrdeptdate.Checked = False
        End If
        'cursor gets into countryid textbox
        TabControl1.SelectedTab = TabPage2
        cmdsearch.Focus()
    End Sub
    'opens a groupbox which helps for searching
    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        If txtbookingid.Text = "" Then
            grbsearch.Visible = True
            cmdupdate.Enabled = False
        Else
            'showing all cust names with the name given in textbox
            Dim str As String
            str = "%" + txtbookingid.Text + "%"
            da = New OleDbDataAdapter("select BookingId,CustId,status,FPSch_id, PackageId,EnteredDt from booking_itinary where BookingId like '" & str & "'", con)
            da.Fill(ds, "search_bookingid")
            dbgsearch.DataSource = ds.Tables("search_bookingid")
            'dbgsearch.DataMember = "search"
            grbsearch.Visible = True
            cmdupdate.Enabled = True
            da.Dispose()
        End If
    End Sub
    'fills the required input controls
    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        Dim i As Byte
        i = dbgsearch.CurrentRowIndex
        txtbookingid.Text = dbgsearch.Item(i, 0)
        txtcustid.Text = dbgsearch.Item(i, 1)
        grbsearch.Visible = False
    End Sub
    'closes the groupbox
    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        grbsearch.Visible = False
    End Sub
    'searching based on dates     
    Private Sub cmddatego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddatego.Click
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        If dtpsearchfrom.Value > dtpsearchto.Value Then
            MsgBox("From Date Must Be Less Than To Date", MsgBoxStyle.OKOnly, Prjtitle)
            dtpsearchto.Focus()
            Exit Sub
        End If
        da = New OleDbDataAdapter("select BookingId,CustId,status,FPSch_id, PackageId,EnteredDt from booking_itinary where entereddt between #" & dtpsearchfrom.Text & "# and #" & dtpsearchto.Text & "#", con)
        da.Fill(ds, "search_date")
        dbgsearch.DataSource = ds.Tables("search_date")
        da.Dispose()
        cmdupdate.Enabled = True
    End Sub
    'searching based on customer id
    Private Sub cmdcustidgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcustidgo.Click
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim str As String
        str = "%" + txtcustidsearch.Text + "%"
        da = New OleDbDataAdapter("select BookingId,CustId,status,FPSch_id, PackageId,EnteredDt from booking_itinary where custId like '" & str & "'", con)
        da.Fill(ds, "search_custid")
        dbgsearch.DataSource = ds.Tables("search_custid")
        da.Dispose()
        cmdupdate.Enabled = True
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        Dim cmd1, cmd2 As OleDbCommand
        Dim t, t1 As OleDbTransaction
        Dim sysrefno, x, y, count, memid As Integer
        Dim a, b, c, d, e, f, dob, anniv, exp, arrdt, arrtime, depdt, deptime, str, use, dat As String
        'check for the compulsory fields
        If txtbookingid.Text = "" Then
            MsgBox("Enter Booking Id", MsgBoxStyle.OKOnly, Prjtitle)
            txtbookingid.Focus()
            Exit Sub
        End If
        If txtfname.Text = "" Then
            MsgBox("Enter First Name", MsgBoxStyle.OKOnly, Prjtitle)
            txtfname.Focus()
            Exit Sub
        End If
        If cobgender.Text = "" Then
            MsgBox("Enter Gender", MsgBoxStyle.OKOnly, Prjtitle)
            cobgender.Focus()
            Exit Sub
        End If
        If cobmainperson.Text = "" Then
            MsgBox("Enter Main Person r Not", MsgBoxStyle.OKOnly, Prjtitle)
            cobmainperson.Focus()
            Exit Sub
        End If
        If cobcountry.Text = "" Then
            MsgBox("Enter Country", MsgBoxStyle.OKOnly, Prjtitle)
            cobcountry.Focus()
            Exit Sub
        End If
        If cobstate.Text = "" Then
            MsgBox("Enter State", MsgBoxStyle.OKOnly, Prjtitle)
            cobstate.Focus()
            Exit Sub
        End If
        If cobcity.Text = "" Then
            MsgBox("Enter City", MsgBoxStyle.OKOnly, Prjtitle)
            cobcity.Focus()
            Exit Sub
        End If
        'saves data before the "-" country id combobox 
        a = cobcountry.Text
        b = (a.Substring(0, a.IndexOf("-")))
        'saves data before the "-" state id combobox 
        c = cobstate.Text
        d = (c.Substring(0, c.IndexOf("-")))
        'saves data before the "-" city id combobox 
        e = cobcity.Text
        f = (e.Substring(0, e.IndexOf("-")))
        'converts the date value into short date string and to dob
        dob = dtpdob.Value.ToShortDateString
        'converts the date value into short date string and to anniv
        anniv = dtpannivdate.Value.ToShortDateString
        'converts the date value into short date string and to exp
        exp = dtpexpdate.Value.ToShortDateString
        'converts the date value into short date string and to arrdt
        arrdt = dtparrarrivaldate.Value.ToShortDateString
        'converts the date value into short date string and to arrtime
        arrtime = dtparrarrivaltime.Value.ToShortTimeString
        'converts the date value into short date string and to depdt
        depdt = dtparrdeptdate.Value.ToShortDateString
        'converts the date value into short date string and to deptime
        deptime = dtparrarrivaltime.Value.ToShortTimeString
        If rbyes.Checked = True Then
            str = "Yes"
        ElseIf rbno.Checked = True Then
            str = "No"
        End If
        use = Muserid
        dat = Now.Date
        '********** For Inserting A Record **********
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                'assigning member id by checking with the booking id
                cmd1 = New OleDbCommand("select count(*) from memb_master where bookingid='" & txtbookingid.Text & "'", con)
                count = cmd1.ExecuteScalar
                cmd1.Dispose()
                If count >= 1 Then
                    cmd1 = New OleDbCommand("select max(memid) from memb_master where bookingid='" & txtbookingid.Text & "'", con)
                    memid = cmd1.ExecuteScalar
                    cmd1.Dispose()
                End If
                'incrementing member id
                memid = memid + 1
                'initializing sysrefno for first time when rows in table are zero
                cmd1 = New OleDb.OleDbCommand("select count(*) from memb_master", con)
                sysrefno = cmd1.ExecuteScalar
                cmd1.Dispose()
                If sysrefno >= 1 Then
                    ' retrieving sysrefno
                    cmd1 = New OleDb.OleDbCommand("select max(sysrefno) from memb_master ", con)
                    sysrefno = cmd1.ExecuteScalar
                    cmd1.Dispose()
                End If
                ' incrementing sysrefno
                sysrefno = sysrefno + 1
                t = con.BeginTransaction
                cmd1 = New OleDbCommand("insert into memb_master values('" & sysrefno & "','" & txtcustid.Text & "','" & txtbookingid.Text & "','" & memid & "','" & cobmainperson.Text & "','" & IIf(txtfname.Text = "", 0, txtfname.Text) & "','" & IIf(txtlname.Text = "", 0, txtlname.Text) & "','" & IIf(txtmname.Text = "", 0, txtmname.Text) & "','" & IIf(txtgroup.Text = "", 0, txtgroup.Text) & "'," & IIf(txtage.Text = "", 0, txtage.Text) & ",'" & cobgender.Text & "','" & IIf(txtaddress.Text = "", 0, txtaddress.Text) & "','" & f & "','" & d & "','" & b & "'," & IIf(txtzip.Text = "", 0, txtzip.Text) & "," & IIf(txthphone.Text = "", 0, txthphone.Text) & "," & IIf(txtwphone.Text = "", 0, txtwphone.Text) & "," & IIf(txtmobile.Text = "", 0, txtmobile.Text) & "," & IIf(txtfax.Text = "", 0, txtfax.Text) & ",'" & IIf(txtemail.Text = "", 0, txtemail.Text) & "','" & use & "','" & dat & "')", con)
                cmd1.Transaction = t
                x = cmd1.ExecuteNonQuery()
                cmd1.Dispose()
                If x = 1 Then
                    cmd1 = New OleDbCommand("insert into memb_info values('" & sysrefno & "'," & IIf(dtpdob.Checked = False, "null", "'" & dob & "'") & ",'" & IIf(cobmaritalstatus.Text = "", 0, cobmaritalstatus.Text) & "'," & IIf(dtpannivdate.Checked = False, "null", "'" & anniv & "'") & ",'" & IIf(txtpassportno.Text = "", 0, txtpassportno.Text) & "'," & IIf(dtpexpdate.Checked = False, "null", "'" & exp & "'") & ",'" & str & "','" & IIf(txtpolicyno.Text = "", 0, txtpolicyno.Text) & "','" & IIf(txtcompany.Text = "", 0, txtcompany.Text) & "','" & IIf(txtnotes.Text = "", 0, txtnotes.Text) & "')", con)
                    cmd1.Transaction = t
                    x = cmd1.ExecuteNonQuery
                    cmd1.Dispose()
                    If x = 1 Then
                        cmd1 = New OleDbCommand("insert into memb_arriv_depar values('" & sysrefno & "','" & txtcustid.Text & "','" & IIf(txtfname.Text = "", 0, txtfname.Text) & "', " & IIf(txtage.Text = "", 0, txtage.Text) & ",'" & cobgender.Text & "'," & IIf(dtparrarrivaldate.Checked = False, "null", "'" & arrdt & "'") & ",'" & arrtime & "','" & IIf(txtarrafldetails.Text = "", 0, txtarrafldetails.Text) & "'," & IIf(dtparrdeptdate.Checked = False, "null", "'" & depdt & "'") & ",'" & deptime & "','" & IIf(txtarrdetpfldetails.Text = "", 0, txtarrdetpfldetails.Text) & "','" & use & "','" & dat & "')", con)
                        cmd1.Transaction = t
                        x = cmd1.ExecuteNonQuery
                        cmd1.Dispose()
                        If x = 1 Then
                            t.Commit()
                            'Displays the updated message in messagebox
                            MsgSav()
                            'clears the controls
                            clearproc()
                            ' locks the controls
                            lock()
                        Else
                            t.Rollback()
                        End If
                    Else
                        t.Rollback()
                    End If
                Else
                    t.Rollback()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            t.Rollback()
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
        '********** For Editing A Record **********
        Try
            If recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                t1 = con.BeginTransaction
                cmd2 = New OleDbCommand("update memb_master set main_person='" & IIf(cobmainperson.Text = "", 0, cobmainperson.Text) & "',fname='" & IIf(txtfname.Text = "", 0, txtfname.Text) & "',lname='" & IIf(txtlname.Text = "", 0, txtlname.Text) & "',mname='" & IIf(txtmname.Text = "", 0, txtmname.Text) & "',groupname='" & IIf(txtgroup.Text = "", 0, txtgroup.Text) & "',cust_age=" & IIf(txtage.Text = "", 0, txtage.Text) & ",cust_gender='" & IIf(cobgender.Text = "", 0, cobgender.Text) & "',address='" & IIf(txtaddress.Text = "", 0, txtaddress.Text) & "',cityid='" & f & "',stateid='" & d & "',countryid='" & b & "',zip=" & IIf(txtzip.Text = "", 0, txtzip.Text) & ",hphone=" & IIf(txthphone.Text = "", 0, txthphone.Text) & ",wphone=" & IIf(txtwphone.Text = "", 0, txtwphone.Text) & ",mphone=" & IIf(txtmobile.Text = "", 0, txtmobile.Text) & ",faxno=" & IIf(txtfax.Text = "", 0, txtfax.Text) & ",email='" & IIf(txtemail.Text = "", 0, txtemail.Text) & "',userid='" & use & "',entereddt='" & dat & "' where sysrefno=" & txtsysrefno.Text & "", con)
                cmd2.Transaction = t1
                y = cmd2.ExecuteNonQuery()
                cmd2.Dispose()
                If y = 1 Then
                    'y = 0
                    cmd2 = New OleDbCommand("update memb_info set dob=" & IIf(dtpdob.Checked = False, "null", dob) & ",mstatus='" & IIf(cobmaritalstatus.Text = "", 0, cobmaritalstatus.Text) & "',anniv_date=" & IIf(dtpannivdate.Checked = False, "null", anniv) & ",passportno='" & IIf(txtpassportno.Text = "", 0, txtpassportno.Text) & "',exp_date=" & IIf(dtpexpdate.Checked = False, "null", exp) & ",insur_taken='" & str & "',policy_no='" & IIf(txtpolicyno.Text = "", 0, txtpolicyno.Text) & "',insur_comp='" & IIf(txtcompany.Text = "", 0, txtcompany.Text) & "',notes='" & IIf(txtnotes.Text = "", 0, txtnotes.Text) & "' where sysrefno=" & txtsysrefno.Text & "", con)
                    cmd2.Transaction = t1
                    y = cmd2.ExecuteNonQuery
                    cmd2.Dispose()
                    If y = 1 Then
                        cmd2 = New OleDbCommand("update memb_arriv_depar set custname='" & IIf(txtfname.Text = "", 0, txtfname.Text) & "',custage=" & IIf(txtage.Text = "", 0, txtage.Text) & ",custgender='" & cobgender.Text & "',arriv_dt=" & IIf(dtparrarrivaldate.Checked = False, "null", arrdt) & ",arriv_time='" & arrtime & "',ATransId='" & IIf(txtarrafldetails.Text = "", 0, txtarrafldetails.Text) & "',dep_dt=" & IIf(dtparrdeptdate.Checked = False, "null", depdt) & ",dep_time='" & deptime & "',DTransId='" & IIf(txtarrdetpfldetails.Text = "", 0, txtarrdetpfldetails.Text) & "',userid='" & use & "',entereddt='" & dat & "' where sysrefno=" & txtsysrefno.Text & "", con)
                        cmd2.Transaction = t1
                        y = cmd2.ExecuteNonQuery
                        cmd2.Dispose()
                        If y = 1 Then
                            t1.Commit()
                            'Displays the updated message in messagebox
                            MsgSav()
                            'clears the controls
                            clearproc()
                            ' locks the controls
                            lock()
                        Else
                            t1.Rollback()
                        End If
                    Else
                        t.Rollback()
                    End If
                Else
                    t1.Rollback()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            t.Rollback()
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        ' unlocks the controls
        txtgroup.ReadOnly = False
        txtfname.ReadOnly = False
        txtlname.ReadOnly = False
        txtmname.ReadOnly = False
        txtage.ReadOnly = False
        cobgender.Enabled = True
        cobmainperson.Enabled = True
        txtaddress.ReadOnly = False
        cobcountry.Enabled = True
        cobstate.Enabled = True
        cobcity.Enabled = True
        txtzip.ReadOnly = False
        txthphone.ReadOnly = False
        txtwphone.ReadOnly = False
        txtmobile.ReadOnly = False
        txtfax.ReadOnly = False
        txtemail.ReadOnly = False
        dtpdob.Enabled = True
        cobmaritalstatus.Enabled = True
        dtpannivdate.Enabled = True
        txtpassportno.ReadOnly = False
        dtpexpdate.Enabled = True
        rbyes.Enabled = True
        rbno.Enabled = True
        txtpolicyno.ReadOnly = False
        txtcompany.ReadOnly = False
        txtnotes.ReadOnly = False
        dtparrarrivaldate.Enabled = True
        dtparrarrivaltime.Enabled = True
        txtarrafldetails.ReadOnly = False
        dtparrdeptdate.Enabled = True
        dtparrdepttime.Enabled = True
        txtarrdetpfldetails.ReadOnly = False
        'cursor gets into groupname textbox
        txtgroup.Focus()
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes the particular record
    Public Sub delproc()
        Dim cmd As OleDbCommand
        Dim t As OleDbTransaction
        Dim i As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            t = con.BeginTransaction
            cmd = New OleDbCommand("delete from memb_master where sysrefno='" & txtsysrefno.Text & "'", con)
            cmd.Transaction = t
            i = cmd.ExecuteNonQuery()
            cmd.Dispose()
            If i > 0 Then
                cmd = New OleDbCommand("delete from memb_info where sysrefno='" & txtsysrefno.Text & "'", con)
                cmd.Transaction = t
                i = cmd.ExecuteNonQuery
                cmd.Dispose()
                If i > 0 Then
                    cmd = New OleDbCommand("delete from memb_arriv_depar where sysrefno='" & txtsysrefno.Text & "'", con)
                    cmd.Transaction = t
                    i = cmd.ExecuteNonQuery
                    cmd.Dispose()
                    If i > 0 Then
                        t.Commit()
                        'displays the dlelted message in messagebox
                        MsgDel()
                        'clears the controls
                        clearproc()
                    Else
                        t.Rollback()
                    End If
                Else
                    t.Rollback()
                End If
            Else
                t.Rollback()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            t.Rollback()
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'states in that particular country will be filled in state combo
    ' when a country is selectedfrom country combo
    Private Sub cobcountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobcountry.SelectedIndexChanged
        Dim b, c As String
        cobstate.Items.Clear()
        b = cobcountry.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobstate, "select stateid,state from statemaster where countryid='" & c & "'")
    End Sub
    'cities in that particular state will be filled in city combo
    ' when a state is selected from state combo
    Private Sub cobstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobstate.SelectedIndexChanged
        Dim b, c As String
        cobcity.Items.Clear()
        b = cobstate.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobcity, "select cityid,city from citymaster where stateid='" & c & "'")
    End Sub
    Private Sub rbyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbyes.CheckedChanged
        txtpolicyno.ReadOnly = False
        txtcompany.ReadOnly = False
    End Sub
    Private Sub rbno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbno.CheckedChanged
        txtpolicyno.ReadOnly = True
        txtcompany.ReadOnly = True
        txtpolicyno.Text = ""
        txtcompany.Text = ""
    End Sub
    Private Sub txtarrafldetails_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtarrafldetails.GotFocus
        Dim da As OleDbDataAdapter
        Dim ds1 As New DataSet
        grbarrival.Visible = True
        Openconnection()
        da = New OleDbDataAdapter("select transid,flightno,flightcode,flightname,airlines from flight_details where flight_arrdep='Arr'", con)
        da.Fill(ds1, "arrivals")
        dbgarr.DataSource = ds1.Tables("arrivals")
    End Sub
    Private Sub cmdarrupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdarrupdate.Click
        Dim i As Byte
        i = dbgarr.CurrentRowIndex
        txtarrafldetails.Text = dbgarr.Item(i, 0)
        grbarrival.Visible = False
        dtparrdeptdate.Focus()
    End Sub
    Private Sub cmdarrcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdarrcancel.Click
        grbarrival.Visible = False
    End Sub
    Private Sub txtarrdetpfldetails_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtarrdetpfldetails.GotFocus
        Dim da As OleDbDataAdapter
        Dim ds1 As New DataSet
        grbdepartures.Visible = True
        Openconnection()
        da = New OleDbDataAdapter("select transid,flightno,flightcode,flightname,airlines from flight_details where flight_arrdep='Dep'", con)
        da.Fill(ds1, "departures")
        dbgdep.DataSource = ds1.Tables("departures")
    End Sub
    Private Sub cmddepupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddepupdate.Click
        Dim i As Byte
        i = dbgdep.CurrentRowIndex
        txtarrdetpfldetails.Text = dbgdep.Item(i, 0)
        grbdepartures.Visible = False
    End Sub
    Private Sub cmddepcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddepcancel.Click
        grbdepartures.Visible = False
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        'It clears the dataset 
        ds.Clear()
        'Data in the table cust_addr,cust_info and cust_master will be displayed 
        'in datagrid on click in view tab page
        Try
            If TabControl1.SelectedTab.Text = "View" Then
                da = New OleDbDataAdapter("select a.sysrefno,a.custid,a.bookingid,a.memid,a.fname,a.lname,a.address,a.cityid,a.stateid,a.countryid,a.mphone,a.email,c.Arriv_Dt,c.Dep_Dt from memb_master a,memb_info b,memb_arriv_depar c where a.sysrefno=b.sysrefno and b.sysrefno=c.sysrefno", con)
                da.Fill(ds, "cust")
                dbgview.DataSource = ds.Tables("cust")
                dbgview.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdviewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdviewall.Click
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        ds.Clear()
        da = New OleDbDataAdapter("select a.sysrefno,a.custid,a.bookingid,a.memid,a.address,a.cityid,a.stateid,a.countryid,a.mphone,a.email,a.fname,a.lname,c.Arriv_Dt,c.Dep_Dt from memb_master a,memb_info b,memb_arriv_depar c where a.sysrefno=b.sysrefno and b.sysrefno=c.sysrefno", con)
        da.Fill(ds, "cust")
        dbgview.Refresh()
        dbgview.DataSource = ds.Tables("cust")
        dbgview.ReadOnly = True
    End Sub
    Private Sub cmdgodate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgodate.Click
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Try
            ds.Clear()
            If dtpfromdateview.Value > dtptodateview.Value Then
                MsgBox("From Date Must Be Less Then To Date", MsgBoxStyle.OKOnly, Prjtitle)
                dtptodateview.Focus()
                Exit Sub
            Else
                Dim p As Integer = 0
                Openconnection()
                cmd = New OleDbCommand("select count(*) from memb_master where entereddt between #" & dtpfromdateview.Text & "# and #" & dtptodateview.Text & "#", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    da = New OleDbDataAdapter("select sysrefno,custid,bookingid,memid,address,cityid,stateid,countryid,mphone,email,fname,lname from memb_master where entereddt between #" & dtpfromdateview.Text & "# and #" & dtptodateview.Text & "#", con)
                    da.Fill(ds, "cust")
                    dbgview.Refresh()
                    dbgview.DataSource = ds.Tables("cust")
                Else
                    MsgBox("Records Doesn't Exsist In Between Selected Dates", MsgBoxStyle.OKOnly, Prjtitle)
                End If
            End If
            dbgview.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub cmdgocustid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgocustid.Click
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Try
            'ds.Tables("cust").Clear()
            ds.Clear()
            Dim p As Integer = 0
            Openconnection()
            cmd = New OleDbCommand("select count(*) from memb_master where bookingid='" & txtbookingidview.Text & "'", con)
            p = cmd.ExecuteScalar
            If p <> 0 Then
                da = New OleDbDataAdapter("select sysrefno,custid,bookingid,memid,address,cityid,stateid,countryid,mphone,email,fname,lname from memb_master where bookingid='" & txtbookingidview.Text & "'", con)
                da.Fill(ds, "cust")
                dbgview.Refresh()
                dbgview.DataSource = ds.Tables("cust")
            Else
                MsgBox("Customer Id Entered Doesn't Exsist", MsgBoxStyle.OKOnly, Prjtitle)
            End If
            dbgview.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub dbgview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim cmd, cmd1, cmd2, cmd3 As OleDbCommand
        'Dim da As OleDbDataAdapter
        Dim i, cou, stat, cit, country, state, city, x, y, z As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        Dim ds1 As New DataSet
        ' locks the controls
        lock()
        'clears the combobox
        cobmaritalstatus.Text = ""
        cobgender.Text = ""
        cobmainperson.Text = ""
        cobcountry.Text = ""
        cobstate.Text = ""
        cobcity.Text = ""
        'fills the current row index number in k
        k = dbgview.CurrentRowIndex
        'fills the value of row in i
        i = dbgview.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select a.sysrefno,a.custid,a.bookingid,a.main_person,a.fname,a.lname,a.mname,a.groupname,a.cust_age,a.cust_gender,a.address,a.cityid,a.stateid,a.countryid,a.zip,a.hphone,a.wphone,a.mphone,a.faxno,a.email,b.dob,b.mstatus,b.anniv_date,b.passportno,b.exp_date,b.insur_taken,b.policy_no,b.insur_comp,b.notes,c.arriv_dt,c.arriv_time,c.atransid,c.dep_dt,c.dep_time,c.dtransid from memb_master a,memb_info b,memb_arriv_depar c where a.sysrefno=" & i & " and a.sysrefno=b.sysrefno and b.sysrefno=c.sysrefno", con)
        Try
            dr = cmd.ExecuteReader
            While dr.Read()
                txtsysrefno.Text = dr(0)
                txtcustid.Text = dr(1)
                txtbookingid.Text = dr(2)
                cobmainperson.Text = dr(3)
                txtfname.Text = dr(4)
                txtlname.Text = dr(5)
                txtmname.Text = dr(6)
                txtgroup.Text = dr(7)
                txtage.Text = dr(8)
                cobgender.Text = dr(9)
                txtaddress.Text = dr(10)
                'cobcity
                z = dr(11)
                'cobstate
                y = dr(12)
                'cobcountry
                x = dr(13)
                comboselet(cobcountry, x)
                comboselet(cobstate, y)
                comboselet(cobcity, z)
                txtzip.Text = dr(14)
                txthphone.Text = dr(15)
                txtwphone.Text = dr(16)
                txtmobile.Text = dr(17)
                txtfax.Text = dr(18)
                txtemail.Text = dr(19)
                'dtpdob.Text = dr(20)
                If IsDBNull(dr(20)) = True Then
                    dtpdob.Checked = False
                    dtpdob.Enabled = False
                Else
                    dtpdob.Checked = True
                    dtpdob.Text = dr(20)
                End If
                cobmaritalstatus.SelectedText = dr(21)
                'dtpannivdate.Text = dr(22)
                If IsDBNull(dr(22)) = True Then
                    dtpannivdate.Checked = False
                    dtpannivdate.Enabled = False
                Else
                    dtpannivdate.Checked = True
                    dtpannivdate.Text = dr(22)
                End If
                txtpassportno.Text = dr(23)
                'dtpexpdate.Text = dr(24)
                If IsDBNull(dr(24)) = True Then
                    dtpexpdate.Checked = False
                    dtpexpdate.Enabled = False
                Else
                    dtpexpdate.Checked = True
                    dtpexpdate.Text = dr(24)
                End If
                If dr(25) = "Yes" Then
                    rbyes.Checked = True
                    txtpolicyno.ReadOnly = True
                    txtcompany.ReadOnly = True
                ElseIf dr(25) = "No" Then
                    rbno.Checked = True
                    txtpolicyno.ReadOnly = True
                    txtcompany.ReadOnly = True
                End If
                txtpolicyno.Text = dr(26)
                txtcompany.Text = dr(27)
                txtnotes.Text = dr(28)
                'dtparrarrivaldate.Text = dr(29)
                If IsDBNull(dr(29)) = True Then
                    dtparrarrivaldate.Checked = False
                    dtparrarrivaldate.Enabled = False
                Else
                    dtparrarrivaldate.Checked = True
                    dtparrarrivaldate.Text = dr(29)
                End If
                dtparrarrivaltime.Text = dr(30)
                txtarrafldetails.Text = dr(31)
                'dtparrdeptdate.Text = dr(32)
                If IsDBNull(dr(32)) = True Then
                    dtparrdeptdate.Checked = False
                    dtparrdeptdate.Enabled = False
                Else
                    dtparrdeptdate.Checked = True
                    dtparrdeptdate.Text = dr(32)
                End If
                dtparrdepttime.Text = dr(33)
                txtarrdetpfldetails.Text = dr(34)
            End While
            dr.Close()
            CloseConnection()
            ''country
            'Openconnection()
            'cmd1 = New OleDbCommand("select country from countrymaster where countryid='" & x & "'", con)
            'country = cmd1.ExecuteScalar
            'cou = x & "-" & country
            'cobcountry.SelectedText = cou
            ''cmd1.Dispose()
            'CloseConnection()
            ''state
            'Openconnection()
            'cmd2 = New OleDbCommand("select state from statemaster where stateid='" & y & "'", con)
            'state = cmd2.ExecuteScalar
            'stat = y & "-" & state
            'cobstate.SelectedText = stat
            'CloseConnection()
            ''city
            'Openconnection()
            'cmd3 = New OleDbCommand("select city from citymaster where cityid='" & z & "'", con)
            'city = cmd3.ExecuteScalar
            'cit = z & "-" & city
            'cobcity.SelectedText = cit

            'displays on entry/edit tabpage
            TabControl1.SelectedTab = TabPage2
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
    Private Sub cobgender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobgender.KeyPress, cobmainperson.KeyPress, cobmaritalstatus.KeyPress, cobcity.KeyPress, cobcountry.KeyPress, cobstate.KeyPress
        combo(e)
    End Sub
    Private Sub txtage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress, txtzip.KeyPress, txtfax.KeyPress, txthphone.KeyPress, txtmobile.KeyPress, txtwphone.KeyPress
        numberonly(e)
    End Sub
    Private Sub txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress, txtlname.KeyPress, txtmname.KeyPress
        textonly(e)
    End Sub
    Private Sub txtpassportno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassportno.KeyPress, txtpolicyno.KeyPress
        textandnumbers(e)
    End Sub
    Private Sub txtemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        email(txtemail)
    End Sub
    Private Sub txtcompany_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcompany.Leave
        firstcap(txtcompany)
    End Sub
    Private Sub txtfname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.Leave
        firstcap(txtfname)
    End Sub
    Private Sub txtgroup_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgroup.Leave
        firstcap(txtgroup)
    End Sub
    Private Sub txtlname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlname.Leave
        firstcap(txtlname)
    End Sub
    Private Sub txtmname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmname.Leave
        firstcap(txtmname)
    End Sub
    Private Sub dtpdob_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpdob.TextChanged
        dtpannivdate.MinDate = FormatDateTime(dtpdob.Text, DateFormat.ShortDate)
    End Sub
    Private Sub cobmaritalstatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobmaritalstatus.TextChanged
        If cobmaritalstatus.Text = "Unmarried" Then
            dtpannivdate.Checked = False
            dtpannivdate.Enabled = False
        ElseIf cobmaritalstatus.Text = "Married" Then
            dtpannivdate.Enabled = True
        End If
    End Sub
    Private Sub dtparrarrivaldate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtparrarrivaldate.TextChanged
        dtparrdeptdate.MinDate = FormatDateTime(dtparrarrivaldate.Text, DateFormat.ShortDate)
    End Sub
    Private Sub dtpsearchfrom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpsearchfrom.TextChanged
        dtpsearchto.MinDate = FormatDateTime(dtpsearchfrom.Text, DateFormat.ShortDate)
    End Sub
    Private Sub dtpfromdateview_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpfromdateview.TextChanged
        Dim d As Date
        d = FormatDateTime(dtpfromdateview.Text, DateFormat.ShortDate)
        dtptodateview.MinDate = DateAdd(DateInterval.Day, 1, d)
        'dtptodateview.MinDate = FormatDateTime(dtpfromdateview.Text, DateFormat.ShortDate)
    End Sub
End Class
