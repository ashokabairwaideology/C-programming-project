'Name developer: kamal.k.trood
'Dt:18/07/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class Customer
    Inherits System.Windows.Forms.Form
    Dim recmode As EnuRecstatus   '  To findout record status
    Dim custid, sysrefno As Integer
    'Dim dt As New DataTable
    'Dim x, y As Byte
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnotes As System.Windows.Forms.TextBox
    Friend WithEvents txtpassportno As System.Windows.Forms.TextBox
    Friend WithEvents cobmaritalstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents txtwphone As System.Windows.Forms.TextBox
    Friend WithEvents txthphone As System.Windows.Forms.TextBox
    Friend WithEvents txtzip As System.Windows.Forms.TextBox
    Friend WithEvents cobcity As System.Windows.Forms.ComboBox
    Friend WithEvents cobstate As System.Windows.Forms.ComboBox
    Friend WithEvents cobcountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents dtpexpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpannivdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents cobagentname As System.Windows.Forms.ComboBox
    Friend WithEvents grbinsurance As System.Windows.Forms.GroupBox
    Friend WithEvents grbpersonaldetails As System.Windows.Forms.GroupBox
    Friend WithEvents grbpersonalinfo As System.Windows.Forms.GroupBox
    Friend WithEvents grbph As System.Windows.Forms.GroupBox
    Friend WithEvents grbaddress As System.Windows.Forms.GroupBox
    Friend WithEvents grbbookingdetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtcustidview As System.Windows.Forms.TextBox
    Friend WithEvents cmdgodate As System.Windows.Forms.Button
    Friend WithEvents cmdgocustid As System.Windows.Forms.Button
    Friend WithEvents cmdviewall As System.Windows.Forms.Button
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents dtptodateview As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfromdateview As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpjoiningdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcompany As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtpolicyno As System.Windows.Forms.TextBox
    Friend WithEvents rbno As System.Windows.Forms.RadioButton
    Friend WithEvents rbyes As System.Windows.Forms.RadioButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtbillzip As System.Windows.Forms.TextBox
    Friend WithEvents cobbillcity As System.Windows.Forms.ComboBox
    Friend WithEvents cobbillstate As System.Windows.Forms.ComboBox
    Friend WithEvents cobbillcountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtbilladdress As System.Windows.Forms.TextBox
    Friend WithEvents grbbilladd As System.Windows.Forms.GroupBox
    Friend WithEvents grbinspolicy As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Customer))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabView = New System.Windows.Forms.TabPage
        Me.cmdviewall = New System.Windows.Forms.Button
        Me.cmdgocustid = New System.Windows.Forms.Button
        Me.txtcustidview = New System.Windows.Forms.TextBox
        Me.cmdgodate = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.dtptodateview = New System.Windows.Forms.DateTimePicker
        Me.dtpfromdateview = New System.Windows.Forms.DateTimePicker
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabEntry = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grbinsurance = New System.Windows.Forms.GroupBox
        Me.grbbilladd = New System.Windows.Forms.GroupBox
        Me.txtbillzip = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cobbillcity = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.cobbillstate = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cobbillcountry = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtbilladdress = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.grbinspolicy = New System.Windows.Forms.GroupBox
        Me.txtcompany = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtpolicyno = New System.Windows.Forms.TextBox
        Me.rbno = New System.Windows.Forms.RadioButton
        Me.rbyes = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtnotes = New System.Windows.Forms.TextBox
        Me.grbpersonaldetails = New System.Windows.Forms.GroupBox
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
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtcustid = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.cobagentname = New System.Windows.Forms.ComboBox
        Me.dtpjoiningdate = New System.Windows.Forms.DateTimePicker
        Me.Label28 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabView.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEntry.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbinsurance.SuspendLayout()
        Me.grbbilladd.SuspendLayout()
        Me.grbinspolicy.SuspendLayout()
        Me.grbpersonaldetails.SuspendLayout()
        Me.grbpersonalinfo.SuspendLayout()
        Me.grbph.SuspendLayout()
        Me.grbaddress.SuspendLayout()
        Me.grbbookingdetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabView)
        Me.TabControl1.Controls.Add(Me.TabEntry)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 440)
        Me.TabControl1.TabIndex = 100
        '
        'TabView
        '
        Me.TabView.Controls.Add(Me.cmdviewall)
        Me.TabView.Controls.Add(Me.cmdgocustid)
        Me.TabView.Controls.Add(Me.txtcustidview)
        Me.TabView.Controls.Add(Me.cmdgodate)
        Me.TabView.Controls.Add(Me.Label22)
        Me.TabView.Controls.Add(Me.Label20)
        Me.TabView.Controls.Add(Me.dtptodateview)
        Me.TabView.Controls.Add(Me.dtpfromdateview)
        Me.TabView.Controls.Add(Me.dbgview)
        Me.TabView.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabView.Location = New System.Drawing.Point(4, 22)
        Me.TabView.Name = "TabView"
        Me.TabView.Size = New System.Drawing.Size(728, 414)
        Me.TabView.TabIndex = 0
        Me.TabView.Text = "View"
        '
        'cmdviewall
        '
        Me.cmdviewall.Location = New System.Drawing.Point(416, 8)
        Me.cmdviewall.Name = "cmdviewall"
        Me.cmdviewall.TabIndex = 8
        Me.cmdviewall.Text = "View All"
        '
        'cmdgocustid
        '
        Me.cmdgocustid.Location = New System.Drawing.Point(648, 40)
        Me.cmdgocustid.Name = "cmdgocustid"
        Me.cmdgocustid.Size = New System.Drawing.Size(32, 23)
        Me.cmdgocustid.TabIndex = 7
        Me.cmdgocustid.Text = "GO"
        '
        'txtcustidview
        '
        Me.txtcustidview.Location = New System.Drawing.Point(536, 40)
        Me.txtcustidview.MaxLength = 10
        Me.txtcustidview.Name = "txtcustidview"
        Me.txtcustidview.TabIndex = 6
        Me.txtcustidview.Text = ""
        '
        'cmdgodate
        '
        Me.cmdgodate.Location = New System.Drawing.Point(320, 40)
        Me.cmdgodate.Name = "cmdgodate"
        Me.cmdgodate.Size = New System.Drawing.Size(32, 23)
        Me.cmdgodate.TabIndex = 5
        Me.cmdgodate.Text = "GO"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(192, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 17)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "To"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(40, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 17)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "From"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtptodateview
        '
        Me.dtptodateview.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtptodateview.Location = New System.Drawing.Point(224, 40)
        Me.dtptodateview.Name = "dtptodateview"
        Me.dtptodateview.Size = New System.Drawing.Size(88, 21)
        Me.dtptodateview.TabIndex = 2
        '
        'dtpfromdateview
        '
        Me.dtpfromdateview.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfromdateview.Location = New System.Drawing.Point(88, 40)
        Me.dtpfromdateview.Name = "dtpfromdateview"
        Me.dtpfromdateview.Size = New System.Drawing.Size(88, 21)
        Me.dtpfromdateview.TabIndex = 1
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 72)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.Size = New System.Drawing.Size(712, 304)
        Me.dbgview.TabIndex = 0
        '
        'TabEntry
        '
        Me.TabEntry.Controls.Add(Me.GroupBox1)
        Me.TabEntry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabEntry.Location = New System.Drawing.Point(4, 22)
        Me.TabEntry.Name = "TabEntry"
        Me.TabEntry.Size = New System.Drawing.Size(728, 414)
        Me.TabEntry.TabIndex = 1
        Me.TabEntry.Text = "Entry / Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grbinsurance)
        Me.GroupBox1.Controls.Add(Me.grbpersonaldetails)
        Me.GroupBox1.Controls.Add(Me.grbbookingdetails)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 408)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'grbinsurance
        '
        Me.grbinsurance.BackColor = System.Drawing.SystemColors.Control
        Me.grbinsurance.Controls.Add(Me.grbbilladd)
        Me.grbinsurance.Controls.Add(Me.grbinspolicy)
        Me.grbinsurance.Controls.Add(Me.Label12)
        Me.grbinsurance.Controls.Add(Me.txtnotes)
        Me.grbinsurance.Location = New System.Drawing.Point(8, 232)
        Me.grbinsurance.Name = "grbinsurance"
        Me.grbinsurance.Size = New System.Drawing.Size(712, 168)
        Me.grbinsurance.TabIndex = 2535
        Me.grbinsurance.TabStop = False
        '
        'grbbilladd
        '
        Me.grbbilladd.Controls.Add(Me.txtbillzip)
        Me.grbbilladd.Controls.Add(Me.Label23)
        Me.grbbilladd.Controls.Add(Me.cobbillcity)
        Me.grbbilladd.Controls.Add(Me.Label24)
        Me.grbbilladd.Controls.Add(Me.cobbillstate)
        Me.grbbilladd.Controls.Add(Me.Label25)
        Me.grbbilladd.Controls.Add(Me.cobbillcountry)
        Me.grbbilladd.Controls.Add(Me.Label26)
        Me.grbbilladd.Controls.Add(Me.txtbilladdress)
        Me.grbbilladd.Controls.Add(Me.Label27)
        Me.grbbilladd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbbilladd.Location = New System.Drawing.Point(8, 8)
        Me.grbbilladd.Name = "grbbilladd"
        Me.grbbilladd.Size = New System.Drawing.Size(216, 152)
        Me.grbbilladd.TabIndex = 53
        Me.grbbilladd.TabStop = False
        Me.grbbilladd.Text = "Billing Address"
        '
        'txtbillzip
        '
        Me.txtbillzip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillzip.Location = New System.Drawing.Point(64, 120)
        Me.txtbillzip.MaxLength = 7
        Me.txtbillzip.Name = "txtbillzip"
        Me.txtbillzip.Size = New System.Drawing.Size(136, 21)
        Me.txtbillzip.TabIndex = 25
        Me.txtbillzip.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 17)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "ZIP"
        '
        'cobbillcity
        '
        Me.cobbillcity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobbillcity.ItemHeight = 13
        Me.cobbillcity.Location = New System.Drawing.Point(64, 96)
        Me.cobbillcity.Name = "cobbillcity"
        Me.cobbillcity.Size = New System.Drawing.Size(136, 21)
        Me.cobbillcity.Sorted = True
        Me.cobbillcity.TabIndex = 24
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 17)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Country"
        '
        'cobbillstate
        '
        Me.cobbillstate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobbillstate.ItemHeight = 13
        Me.cobbillstate.Location = New System.Drawing.Point(64, 72)
        Me.cobbillstate.Name = "cobbillstate"
        Me.cobbillstate.Size = New System.Drawing.Size(136, 21)
        Me.cobbillstate.Sorted = True
        Me.cobbillstate.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 17)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "State"
        '
        'cobbillcountry
        '
        Me.cobbillcountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobbillcountry.ItemHeight = 13
        Me.cobbillcountry.Location = New System.Drawing.Point(64, 48)
        Me.cobbillcountry.Name = "cobbillcountry"
        Me.cobbillcountry.Size = New System.Drawing.Size(136, 21)
        Me.cobbillcountry.Sorted = True
        Me.cobbillcountry.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 96)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 17)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "City"
        '
        'txtbilladdress
        '
        Me.txtbilladdress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbilladdress.Location = New System.Drawing.Point(64, 24)
        Me.txtbilladdress.MaxLength = 150
        Me.txtbilladdress.Name = "txtbilladdress"
        Me.txtbilladdress.Size = New System.Drawing.Size(136, 21)
        Me.txtbilladdress.TabIndex = 21
        Me.txtbilladdress.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 17)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "Address"
        '
        'grbinspolicy
        '
        Me.grbinspolicy.Controls.Add(Me.txtcompany)
        Me.grbinspolicy.Controls.Add(Me.Label32)
        Me.grbinspolicy.Controls.Add(Me.Label29)
        Me.grbinspolicy.Controls.Add(Me.txtpolicyno)
        Me.grbinspolicy.Controls.Add(Me.rbno)
        Me.grbinspolicy.Controls.Add(Me.rbyes)
        Me.grbinspolicy.Location = New System.Drawing.Point(232, 8)
        Me.grbinspolicy.Name = "grbinspolicy"
        Me.grbinspolicy.Size = New System.Drawing.Size(216, 152)
        Me.grbinspolicy.TabIndex = 54
        Me.grbinspolicy.TabStop = False
        Me.grbinspolicy.Text = "Insurance Policy Taken"
        '
        'txtcompany
        '
        Me.txtcompany.Location = New System.Drawing.Point(88, 82)
        Me.txtcompany.MaxLength = 50
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.Size = New System.Drawing.Size(104, 21)
        Me.txtcompany.TabIndex = 29
        Me.txtcompany.Text = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(24, 82)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 17)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "Company "
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(24, 50)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 16)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Policy No"
        '
        'txtpolicyno
        '
        Me.txtpolicyno.Location = New System.Drawing.Point(88, 50)
        Me.txtpolicyno.MaxLength = 30
        Me.txtpolicyno.Name = "txtpolicyno"
        Me.txtpolicyno.Size = New System.Drawing.Size(104, 21)
        Me.txtpolicyno.TabIndex = 28
        Me.txtpolicyno.Text = ""
        '
        'rbno
        '
        Me.rbno.Location = New System.Drawing.Point(128, 24)
        Me.rbno.Name = "rbno"
        Me.rbno.Size = New System.Drawing.Size(40, 16)
        Me.rbno.TabIndex = 27
        Me.rbno.Text = "No"
        '
        'rbyes
        '
        Me.rbyes.Checked = True
        Me.rbyes.Location = New System.Drawing.Point(24, 18)
        Me.rbyes.Name = "rbyes"
        Me.rbyes.Size = New System.Drawing.Size(88, 24)
        Me.rbyes.TabIndex = 26
        Me.rbyes.TabStop = True
        Me.rbyes.Text = "Yes Taken"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(552, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Additional Notes"
        '
        'txtnotes
        '
        Me.txtnotes.Location = New System.Drawing.Point(472, 40)
        Me.txtnotes.MaxLength = 250
        Me.txtnotes.Multiline = True
        Me.txtnotes.Name = "txtnotes"
        Me.txtnotes.Size = New System.Drawing.Size(232, 120)
        Me.txtnotes.TabIndex = 55
        Me.txtnotes.Text = ""
        '
        'grbpersonaldetails
        '
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
        Me.grbpersonaldetails.Location = New System.Drawing.Point(8, 48)
        Me.grbpersonaldetails.Name = "grbpersonaldetails"
        Me.grbpersonaldetails.Size = New System.Drawing.Size(712, 184)
        Me.grbpersonaldetails.TabIndex = 35
        Me.grbpersonaldetails.TabStop = False
        Me.grbpersonaldetails.Text = "Personal Details"
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
        Me.grbpersonalinfo.Location = New System.Drawing.Point(456, 40)
        Me.grbpersonalinfo.Name = "grbpersonalinfo"
        Me.grbpersonalinfo.Size = New System.Drawing.Size(248, 136)
        Me.grbpersonalinfo.TabIndex = 81
        Me.grbpersonalinfo.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 17)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Expiry Date"
        '
        'dtpexpdate
        '
        Me.dtpexpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpexpdate.Location = New System.Drawing.Point(120, 112)
        Me.dtpexpdate.Name = "dtpexpdate"
        Me.dtpexpdate.ShowCheckBox = True
        Me.dtpexpdate.Size = New System.Drawing.Size(120, 21)
        Me.dtpexpdate.TabIndex = 20
        Me.dtpexpdate.Value = New Date(2006, 8, 30, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Passport No"
        '
        'txtpassportno
        '
        Me.txtpassportno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassportno.Location = New System.Drawing.Point(120, 88)
        Me.txtpassportno.MaxLength = 30
        Me.txtpassportno.Name = "txtpassportno"
        Me.txtpassportno.Size = New System.Drawing.Size(120, 21)
        Me.txtpassportno.TabIndex = 19
        Me.txtpassportno.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 17)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Annivarsary Date"
        '
        'dtpannivdate
        '
        Me.dtpannivdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpannivdate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpannivdate.Location = New System.Drawing.Point(120, 64)
        Me.dtpannivdate.Name = "dtpannivdate"
        Me.dtpannivdate.ShowCheckBox = True
        Me.dtpannivdate.Size = New System.Drawing.Size(120, 21)
        Me.dtpannivdate.TabIndex = 18
        Me.dtpannivdate.Value = New Date(2006, 8, 30, 0, 0, 0, 0)
        '
        'cobmaritalstatus
        '
        Me.cobmaritalstatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobmaritalstatus.Items.AddRange(New Object() {"Married", "Unmarried"})
        Me.cobmaritalstatus.Location = New System.Drawing.Point(120, 40)
        Me.cobmaritalstatus.Name = "cobmaritalstatus"
        Me.cobmaritalstatus.Size = New System.Drawing.Size(120, 21)
        Me.cobmaritalstatus.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 17)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Marital Status"
        '
        'dtpdob
        '
        Me.dtpdob.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpdob.Location = New System.Drawing.Point(120, 16)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.ShowCheckBox = True
        Me.dtpdob.Size = New System.Drawing.Size(120, 21)
        Me.dtpdob.TabIndex = 16
        Me.dtpdob.Value = New Date(2006, 8, 30, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
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
        Me.grbph.Location = New System.Drawing.Point(232, 40)
        Me.grbph.Name = "grbph"
        Me.grbph.Size = New System.Drawing.Size(216, 136)
        Me.grbph.TabIndex = 80
        Me.grbph.TabStop = False
        '
        'txtmobile
        '
        Me.txtmobile.Location = New System.Drawing.Point(96, 64)
        Me.txtmobile.MaxLength = 12
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(112, 21)
        Me.txtmobile.TabIndex = 13
        Me.txtmobile.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 17)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Mobile No"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 17)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Email Id"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(96, 112)
        Me.txtemail.MaxLength = 25
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(112, 21)
        Me.txtemail.TabIndex = 15
        Me.txtemail.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 17)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Fax No"
        '
        'txtfax
        '
        Me.txtfax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfax.Location = New System.Drawing.Point(96, 88)
        Me.txtfax.MaxLength = 12
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(112, 21)
        Me.txtfax.TabIndex = 14
        Me.txtfax.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Work Phone"
        '
        'txtwphone
        '
        Me.txtwphone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwphone.Location = New System.Drawing.Point(96, 40)
        Me.txtwphone.MaxLength = 12
        Me.txtwphone.Name = "txtwphone"
        Me.txtwphone.Size = New System.Drawing.Size(112, 21)
        Me.txtwphone.TabIndex = 12
        Me.txtwphone.Text = ""
        '
        'txthphone
        '
        Me.txthphone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthphone.Location = New System.Drawing.Point(96, 16)
        Me.txthphone.MaxLength = 12
        Me.txthphone.Name = "txthphone"
        Me.txthphone.Size = New System.Drawing.Size(112, 21)
        Me.txthphone.TabIndex = 11
        Me.txthphone.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
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
        Me.grbaddress.Location = New System.Drawing.Point(8, 39)
        Me.grbaddress.Name = "grbaddress"
        Me.grbaddress.Size = New System.Drawing.Size(216, 137)
        Me.grbaddress.TabIndex = 79
        Me.grbaddress.TabStop = False
        '
        'txtzip
        '
        Me.txtzip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtzip.Location = New System.Drawing.Point(64, 112)
        Me.txtzip.MaxLength = 7
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(136, 21)
        Me.txtzip.TabIndex = 10
        Me.txtzip.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "ZIP"
        '
        'cobcity
        '
        Me.cobcity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcity.ItemHeight = 13
        Me.cobcity.Location = New System.Drawing.Point(64, 88)
        Me.cobcity.Name = "cobcity"
        Me.cobcity.Size = New System.Drawing.Size(136, 21)
        Me.cobcity.Sorted = True
        Me.cobcity.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Country*"
        '
        'cobstate
        '
        Me.cobstate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobstate.ItemHeight = 13
        Me.cobstate.Location = New System.Drawing.Point(64, 64)
        Me.cobstate.Name = "cobstate"
        Me.cobstate.Size = New System.Drawing.Size(136, 21)
        Me.cobstate.Sorted = True
        Me.cobstate.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "State*"
        '
        'cobcountry
        '
        Me.cobcountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcountry.ItemHeight = 13
        Me.cobcountry.Location = New System.Drawing.Point(64, 40)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(136, 21)
        Me.cobcountry.Sorted = True
        Me.cobcountry.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "City*"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(64, 16)
        Me.txtaddress.MaxLength = 150
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(136, 21)
        Me.txtaddress.TabIndex = 6
        Me.txtaddress.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Address*"
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(544, 16)
        Me.txtmname.MaxLength = 15
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(144, 21)
        Me.txtmname.TabIndex = 5
        Me.txtmname.Text = ""
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(312, 16)
        Me.txtlname.MaxLength = 15
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(128, 21)
        Me.txtlname.TabIndex = 4
        Me.txtlname.Text = ""
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(88, 16)
        Me.txtfname.MaxLength = 15
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(136, 21)
        Me.txtfname.TabIndex = 3
        Me.txtfname.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(464, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Middle Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "First Name *"
        '
        'grbbookingdetails
        '
        Me.grbbookingdetails.Controls.Add(Me.Label16)
        Me.grbbookingdetails.Controls.Add(Me.txtcustid)
        Me.grbbookingdetails.Controls.Add(Me.Label30)
        Me.grbbookingdetails.Controls.Add(Me.cobagentname)
        Me.grbbookingdetails.Controls.Add(Me.dtpjoiningdate)
        Me.grbbookingdetails.Controls.Add(Me.Label28)
        Me.grbbookingdetails.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbbookingdetails.Location = New System.Drawing.Point(8, 8)
        Me.grbbookingdetails.Name = "grbbookingdetails"
        Me.grbbookingdetails.Size = New System.Drawing.Size(712, 40)
        Me.grbbookingdetails.TabIndex = 33
        Me.grbbookingdetails.TabStop = False
        Me.grbbookingdetails.Text = "Booking Details"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Client Id"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcustid
        '
        Me.txtcustid.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtcustid.Location = New System.Drawing.Point(72, 16)
        Me.txtcustid.MaxLength = 10
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.ReadOnly = True
        Me.txtcustid.Size = New System.Drawing.Size(104, 21)
        Me.txtcustid.TabIndex = 0
        Me.txtcustid.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(432, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 17)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Agent Name"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cobagentname
        '
        Me.cobagentname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobagentname.Location = New System.Drawing.Point(520, 16)
        Me.cobagentname.Name = "cobagentname"
        Me.cobagentname.Size = New System.Drawing.Size(144, 21)
        Me.cobagentname.TabIndex = 2
        '
        'dtpjoiningdate
        '
        Me.dtpjoiningdate.CustomFormat = "dd/MM/yyyyy"
        Me.dtpjoiningdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpjoiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpjoiningdate.Location = New System.Drawing.Point(296, 16)
        Me.dtpjoiningdate.Name = "dtpjoiningdate"
        Me.dtpjoiningdate.ShowCheckBox = True
        Me.dtpjoiningdate.Size = New System.Drawing.Size(104, 21)
        Me.dtpjoiningdate.TabIndex = 1
        Me.dtpjoiningdate.Value = New Date(2006, 8, 23, 0, 0, 0, 0)
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(208, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 17)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Joining Date"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Customer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(738, 441)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Profile"
        Me.TabControl1.ResumeLayout(False)
        Me.TabView.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEntry.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grbinsurance.ResumeLayout(False)
        Me.grbbilladd.ResumeLayout(False)
        Me.grbinspolicy.ResumeLayout(False)
        Me.grbpersonaldetails.ResumeLayout(False)
        Me.grbpersonalinfo.ResumeLayout(False)
        Me.grbph.ResumeLayout(False)
        Me.grbaddress.ResumeLayout(False)
        Me.grbbookingdetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'opens entry/edit page on pageload
        TabControl1.SelectedTab = TabEntry

        'fills the combobox from country master table
        combofill1(cobcountry, "select * from countrymaster")

        'fills the combobox from country master table
        combofill1(cobbillcountry, "select * from countrymaster")

        'fills the combobox with agent id from agent master table
        combofill(cobagentname, "select agentid from agentmaster")

        ' locks the controls in entry/edit tabpage 
        lock()

        'restricting dates 
        dtpjoiningdate.MinDate = FormatDateTime(Now.Date, DateFormat.ShortDate)
        'dtpjoiningdate.MaxDate = Now.Date
        Dim n As Date
        n = FormatDateTime(Now.Date, DateFormat.ShortDate)
        dtpdob.MaxDate = DateAdd(DateInterval.Day, -1, n)
        dtpannivdate.MaxDate = FormatDateTime(Now.Date, DateFormat.ShortDate)
        dtpfromdateview.MaxDate = DateAdd(DateInterval.Day, -1, Now.Date)

    End Sub
    Public Sub lock()
        ' locks the controls in entry/edit tabpage 
        dtpjoiningdate.Enabled = False
        cobagentname.Enabled = False
        txtfname.ReadOnly = True
        txtlname.ReadOnly = True
        txtmname.ReadOnly = True
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
        txtbilladdress.ReadOnly = True
        cobbillcountry.Enabled = False
        cobbillstate.Enabled = False
        cobbillcity.Enabled = False
        txtbillzip.ReadOnly = True
        rbyes.Enabled = False
        rbno.Enabled = False
        txtpolicyno.ReadOnly = True
        txtcompany.ReadOnly = True
        txtnotes.ReadOnly = True
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
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbinsurance.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbbilladd.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbpersonalinfo.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grbinspolicy.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    'It enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        'clears the controls
        clearproc()
        ' unlocks the controls
        dtpjoiningdate.Enabled = True
        cobagentname.Enabled = True
        txtfname.ReadOnly = False
        txtlname.ReadOnly = False
        txtmname.ReadOnly = False
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
        txtbilladdress.ReadOnly = False
        cobbillcountry.Enabled = True
        cobbillstate.Enabled = True
        cobbillcity.Enabled = True
        txtbillzip.ReadOnly = False
        rbyes.Enabled = True
        rbno.Enabled = True
        rbno.Checked = True
        'txtpolicyno.ReadOnly = False
        'txtcompany.ReadOnly = False
        txtnotes.ReadOnly = False
        'checkboxes present in datepicker are in unchecked mode
        If dtpjoiningdate.Checked = True Then
            dtpjoiningdate.Checked = False
        End If
        If dtpannivdate.Checked = True Then
            dtpannivdate.Checked = False
        End If
        If dtpdob.Checked = True Then
            dtpdob.Checked = False
        End If
        If dtpexpdate.Checked = True Then
            dtpexpdate.Checked = False
        End If
        'cursor gets into joining date 
        TabControl1.SelectedTab = TabEntry
        dtpjoiningdate.Focus()
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        'validations for compulsory fields
        If dtpjoiningdate.Checked = False Then
            MsgBox("Ener The joining Date", MsgBoxStyle.OKOnly, Prjtitle)
            dtpjoiningdate.Focus()
            Exit Sub
        End If
        If txtfname.Text = "" Then
            MsgBox(" Enter First Name", MsgBoxStyle.OKOnly, Prjtitle)
            txtfname.Focus()
            Exit Sub
        End If
        If txtaddress.Text = "" Then
            MsgBox(" Enter Address", MsgBoxStyle.OKOnly, Prjtitle)
            txtaddress.Focus()
            Exit Sub
        End If
        If cobcountry.Text = "" Then
            MsgBox(" Enter Country", MsgBoxStyle.OKOnly, Prjtitle)
            cobcountry.Focus()
            Exit Sub
        End If
        If cobstate.Text = "" Then
            MsgBox(" Enter State", MsgBoxStyle.OKOnly, Prjtitle)
            cobstate.Focus()
            Exit Sub
        End If
        If cobcity.Text = "" Then
            MsgBox(" Enter City", MsgBoxStyle.OKOnly, Prjtitle)
            cobcity.Focus()
            Exit Sub
        End If
        'If cobmaritalstatus.Text = "" Then
        '    MsgBox(" Enter Your MaritalStatus", MsgBoxStyle.OKOnly, Prjtitle)
        '    cobmaritalstatus.Focus()
        '    Exit Sub
        'End If
        Label1.Focus()
        Dim cmd1, cmd2 As OleDbCommand
        Dim t, t1 As OleDbTransaction
        Dim i, x, y As Byte
        Dim a, b, c, d, e, f, a1, b1, c1, d1, e1, f1, str, use, dat As String
        Dim joining, dob, anniv, exp As Date
        'saves data before the "-" country id combobox 
        a = cobcountry.Text
        b = (a.Substring(0, a.IndexOf("-")))
        'saves data before the "-" state id combobox 
        c = cobstate.Text
        d = (c.Substring(0, c.IndexOf("-")))
        'saves data before the "-" city id combobox 
        e = cobcity.Text
        f = (e.Substring(0, e.IndexOf("-")))
        'saves data before the "-" country id combobox 
        If cobbillcountry.Text <> "" Then
            a1 = cobbillcountry.Text
            b1 = (a1.Substring(0, a1.IndexOf("-")))
        End If
        'saves data before the "-" state id combobox 
        If cobbillstate.Text <> "" Then
            c1 = cobbillstate.Text
            d1 = (c1.Substring(0, c1.IndexOf("-")))
        End If
        'saves data before the "-" city id combobox 
        If cobbillcity.Text <> "" Then
            e1 = cobbillcity.Text
            f1 = (e1.Substring(0, e1.IndexOf("-")))
        End If
        'converts the date value into short date string and to joining
        joining = dtpjoiningdate.Text
        'converts the date value into short date string and to dob
        dob = dtpdob.Text
        'converts the date value into short date string and to anniv
        anniv = dtpannivdate.Text
        'converts the date value into short date string and to exp
        exp = dtpexpdate.Text
        If rbyes.Checked = True Then
            str = "Yes"
        ElseIf rbno.Checked = True Then
            str = "No"
        End If
        use = Muserid
        dat = Now.Date
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                'initializing customer id for first time when rows in table are zero
                cmd1 = New OleDb.OleDbCommand("select count(*) from cust_master", con)
                custid = cmd1.ExecuteScalar
                cmd1.Dispose()
                If custid >= 1 Then
                    ' retrieving customer id 
                    cmd1 = New OleDb.OleDbCommand("select max(custId) from cust_master ", con)
                    custid = cmd1.ExecuteScalar
                    cmd1.Dispose()
                End If
                ' incrementing customer id
                custid = custid + 1
                t = con.BeginTransaction
                cmd1 = New OleDbCommand("insert into cust_master values('" & custid & "','" & IIf(txtfname.Text = "", 0, txtfname.Text) & "','" & IIf(txtlname.Text = "", 0, txtlname.Text) & "','" & IIf(txtmname.Text = "", 0, txtmname.Text) & "'," & IIf(dtpjoiningdate.Checked = False, "null", "'" & joining & "'") & ",'" & cobagentname.Text & "','" & txtaddress.Text & "','" & f & "','" & d & "','" & b & "'," & IIf(txtzip.Text = "", 0, txtzip.Text) & "," & IIf(txthphone.Text = "", 0, txthphone.Text) & "," & IIf(txtwphone.Text = "", 0, txtwphone.Text) & "," & IIf(txtmobile.Text = "", 0, txtmobile.Text) & "," & IIf(txtfax.Text = "", 0, txtfax.Text) & ",'" & IIf(txtemail.Text = "", 0, txtemail.Text) & "','" & IIf(txtbilladdress.Text = "", txtaddress.Text, txtbilladdress.Text) & "','" & IIf(f1 = "", f, f1) & "','" & IIf(d1 = "", d, d1) & "','" & IIf(b1 = "", b, b1) & "'," & IIf(txtbillzip.Text = "", 0, txtbillzip.Text) & ",'" & use & "','" & dat & "')", con)
                cmd1.Transaction = t
                x = cmd1.ExecuteNonQuery()
                cmd1.Dispose()
                If x = 1 Then
                    cmd1 = New OleDbCommand("insert into cust_info values('" & custid & "'," & IIf(dtpdob.Checked = False, "null", "'" & dob & "'") & ",'" & IIf(cobmaritalstatus.Text = "", 0, cobmaritalstatus.Text) & "'," & IIf(dtpannivdate.Checked = False, "null", "'" & anniv & "'") & ",'" & IIf(txtpassportno.Text = "", 0, txtpassportno.Text) & "'," & IIf(dtpexpdate.Checked = False, "null", "'" & exp & "'") & ",'" & str & "','" & IIf(txtpolicyno.Text = "", 0, txtpolicyno.Text) & "','" & IIf(txtcompany.Text = "", 0, txtcompany.Text) & "','" & IIf(txtnotes.Text = "", 0, txtnotes.Text) & "')", con)
                    cmd1.Transaction = t
                    x = cmd1.ExecuteNonQuery
                    cmd1.Dispose()
                    If x = 1 Then
                        t.Commit()
                        'Displays the updated message in messagebox
                        MsgSav()
                        MsgBox("Customer Id : " & custid, MsgBoxStyle.OKOnly, Prjtitle)
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
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                t1 = con.BeginTransaction
                cmd2 = New OleDbCommand("update cust_master set fname='" & IIf(txtfname.Text = "", 0, txtfname.Text) & "',lname='" & IIf(txtlname.Text = "", 0, txtlname.Text) & "',mname='" & IIf(txtmname.Text = "", 0, txtmname.Text) & "',Cust_JDate=" & IIf(dtpjoiningdate.Checked = False, "null", "'" & joining & "'") & ",agentid='" & IIf(cobagentname.Text = "", 0, cobagentname.Text) & "',address='" & txtaddress.Text & "',cityid='" & f & "',stateid='" & d & "',countryid='" & b & "',zip='" & IIf(txtzip.Text = "", 0, txtzip.Text) & "',hphone='" & IIf(txthphone.Text = "", 0, txthphone.Text) & "',wphone='" & IIf(txtwphone.Text = "", 0, txtwphone.Text) & "',mphone='" & IIf(txtmobile.Text = "", 0, txtmobile.Text) & "',faxno='" & IIf(txtfax.Text = "", 0, txtfax.Text) & "',email='" & IIf(txtemail.Text = "", 0, txtemail.Text) & "',bill_address='" & IIf(txtbilladdress.Text = "", txtaddress.Text, txtbilladdress.Text) & "',bill_cityid='" & IIf(f1 = "", f, f1) & "',bill_stateid='" & IIf(d1 = "", d, d1) & "',bill_countryid='" & IIf(b1 = "", b, b1) & "',bill_zip='" & IIf(txtbillzip.Text = "", 0, txtbillzip.Text) & "',userid='" & use & "',entereddt='" & dat & "' where custid='" & txtcustid.Text & "'", con)
                cmd2.Transaction = t1
                y = cmd2.ExecuteNonQuery()
                cmd2.Dispose()
                If y = 1 Then
                    y = 0
                    cmd2 = New OleDbCommand("update cust_info set dob=" & IIf(dtpdob.Checked = False, "null", "'" & dob & "'") & ",mstatus='" & IIf(cobmaritalstatus.Text = "", 0, cobmaritalstatus.Text) & "',anniv_date=" & IIf(dtpannivdate.Checked = False, "null", "'" & anniv & "'") & ",passportno='" & IIf(txtpassportno.Text = "", 0, txtpassportno.Text) & "',exp_date=" & IIf(dtpexpdate.Checked = False, "null", "'" & exp & "'") & ",insur_taken='" & str & "',policy_no='" & IIf(txtpolicyno.Text = "", 0, txtpolicyno.Text) & "',insur_comp='" & IIf(txtcompany.Text = "", 0, txtcompany.Text) & "',notes='" & IIf(txtnotes.Text = "", 0, txtnotes.Text) & "' where custid='" & txtcustid.Text & "'", con)
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
        'dtpjoiningdate.Enabled = True
        cobagentname.Enabled = True
        txtfname.ReadOnly = False
        txtlname.ReadOnly = False
        txtmname.ReadOnly = False
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
        txtbilladdress.ReadOnly = False
        cobbillcountry.Enabled = True
        cobbillstate.Enabled = True
        cobbillcity.Enabled = True
        txtbillzip.ReadOnly = False
        rbyes.Enabled = True
        rbno.Enabled = True
        txtpolicyno.ReadOnly = False
        txtcompany.ReadOnly = False
        txtnotes.ReadOnly = False
        'cursor gets into joining date
        dtpjoiningdate.Focus()
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
            cmd = New OleDbCommand("delete from cust_master where custid='" & txtcustid.Text & "'", con)
            cmd.Transaction = t
            i = cmd.ExecuteNonQuery()
            cmd.Dispose()
            If i > 0 Then
                cmd = New OleDbCommand("delete from cust_info where custid='" & txtcustid.Text & "'", con)
                cmd.Transaction = t
                i = cmd.ExecuteNonQuery
                cmd.Dispose()
                If i > 0 Then
                    t.Commit()
                    MsgDel()
                    'clears the controls
                    clearproc()
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
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        'It clears the dataset 
        ds.Clear()
        'Data in the table cust_addr,cust_info and cust_master will be displayed 
        'in datagrid on click in view tab page
        Try
            If TabControl1.SelectedTab.Text = "View" Then
                da = New OleDbDataAdapter("select a.custid,a.fname,a.lname,a.Cust_JDate,a.agentid,a.address,a.cityid,a.stateid,a.countryid,a.mphone,a.email from cust_master a,cust_info b where a.custid=b.custid", con)
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
        da = New OleDbDataAdapter("select a.custid,a.fname,a.lname,a.Cust_JDate,a.agentid,a.address,a.cityid,a.stateid,a.countryid,a.mphone,a.email from cust_master a,cust_info b where a.custid=b.custid", con)
        da.Fill(ds, "cust")
        dbgview.Refresh()
        dbgview.DataSource = ds.Tables("cust")
        dbgview.ReadOnly = True
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
            cmd = New OleDbCommand("select count(*) from cust_master where custid='" & txtcustidview.Text & "'", con)
            p = cmd.ExecuteScalar
            If p <> 0 Then
                da = New OleDbDataAdapter("select a.custid,a.fname,a.lname,a.Cust_JDate,a.agentid,a.address,a.cityid,a.stateid,a.countryid,a.mphone,a.email from cust_master a,cust_info b where a.custid='" & txtcustidview.Text & "' and a.custid=b.custid", con)
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
                cmd = New OleDbCommand("select count(*) from cust_master where Cust_JDate between #" & dtpfromdateview.Text & "# and #" & dtptodateview.Text & "#", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    da = New OleDbDataAdapter("select a.custid,a.fname,a.lname,a.Cust_JDate,a.agentid,a.address,a.cityid,a.stateid,a.countryid,a.mphone,a.email from cust_master a,cust_info b where a.Cust_JDate between #" & dtpfromdateview.Text & "# and #" & dtptodateview.Text & "# and a.custid=b.custid", con)
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
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim cmd, cmd1, cmd2, cmd3 As OleDbCommand
        'Dim da As OleDbDataAdapter
        Dim a, b, c, i, cou, stat, cit, country, state, city, x, y, z, str As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        Dim ds1 As New DataSet
        ' locks the controls
        lock()
        'clears the combobox
        cobmaritalstatus.Text = ""
        cobagentname.Text = ""
        cobcountry.Text = ""
        cobstate.Text = ""
        cobcity.Text = ""
        'fills the current row index number in k
        k = dbgview.CurrentRowIndex
        'fills the value of row in i
        i = dbgview.Item(k, 0)
        Openconnection()
        Str = "select a.custid,a.address,a.cityid,a.stateid,a.countryid,a.zip,a.hphone,a.wphone,a.mphone,a.faxno,a.email,a.bill_address,a.bill_cityid,a.bill_stateid,a.bill_countryid,a.bill_zip,b.dob,b.mstatus,b.anniv_date,b.passportno,b.exp_date,b.insur_taken,b.policy_no,b.insur_comp,b.notes,a.fname,a.lname,a.mname,a.Cust_JDate,a.agentid from cust_master a,cust_info b where a.custid='" & i & "' and a.custid=b.custid"
        cmd = New OleDbCommand("select a.custid,a.address,a.cityid,a.stateid,a.countryid,a.zip,a.hphone,a.wphone,a.mphone,a.faxno,a.email,a.bill_address,a.bill_cityid,a.bill_stateid,a.bill_countryid,a.bill_zip,b.dob,b.mstatus,b.anniv_date,b.passportno,b.exp_date,b.insur_taken,b.policy_no,b.insur_comp,b.notes,a.fname,a.lname,a.mname,a.Cust_JDate,a.agentid from cust_master a,cust_info b where a.custid='" & i & "' and a.custid=b.custid", con)
        Try
            dr = cmd.ExecuteReader
            While dr.Read()
                txtcustid.Text = dr(0)
                txtaddress.Text = dr(1)
                'cobcity
                z = dr(2)
                'cobstate
                y = dr(3)
                'cobcountry
                x = dr(4)
                comboselet(cobcountry, x)
                comboselet(cobstate, y)
                comboselet(cobcity, z)
                txtbillzip.Text = dr(15)
                txtzip.Text = dr(5)
                txthphone.Text = dr(6)
                txtwphone.Text = dr(7)
                txtmobile.Text = dr(8)
                txtfax.Text = dr(9)
                txtemail.Text = dr(10)
                txtbilladdress.Text = dr(11)
                c = dr(12)
                b = dr(13)
                a = dr(14)
                comboselet(cobbillcountry, a)
                comboselet(cobbillstate, b)
                comboselet(cobbillcity, c)
                txtbillzip.Text = dr(15)
                'dtpdob.Text = dr(16)
                If IsDBNull(dr(16)) = True Then
                    dtpdob.Checked = False
                    dtpdob.Enabled = False
                Else
                    dtpdob.Checked = True
                    dtpdob.Text = dr(16)
                End If
                cobmaritalstatus.SelectedText = dr(17)
                'dtpannivdate.Text = dr(18)
                If IsDBNull(dr(18)) = True Then
                    dtpannivdate.Checked = False
                    dtpannivdate.Enabled = False
                Else
                    dtpannivdate.Checked = True
                    dtpannivdate.Text = dr(18)
                End If
                txtpassportno.Text = dr(19)
                'dtpexpdate.Text = dr(20)
                If IsDBNull(dr(20)) = True Then
                    dtpexpdate.Checked = False
                    dtpexpdate.Enabled = False
                Else
                    dtpexpdate.Checked = True
                    dtpexpdate.Text = dr(20)
                End If
                If dr(21) = "Yes" Then
                    rbyes.Checked = True
                    txtpolicyno.ReadOnly = True
                    txtcompany.ReadOnly = True
                ElseIf dr(21) = "No" Then
                    rbno.Checked = True
                    txtpolicyno.ReadOnly = True
                    txtcompany.ReadOnly = True
                End If
                txtpolicyno.Text = dr(22)
                txtcompany.Text = dr(23)
                txtnotes.Text = dr(24)
                txtfname.Text = dr(25)
                txtlname.Text = dr(26)
                txtmname.Text = dr(27)
                'dtpjoiningdate.Text = dr(28)
                If IsDBNull(dr(28)) = True Then
                    dtpjoiningdate.Checked = False
                    dtpjoiningdate.Enabled = False
                Else
                    dtpjoiningdate.Checked = True
                    dtpjoiningdate.Text = dr(28)
                End If
                cobagentname.SelectedText = dr(29)
            End While
            dr.Close()
            'CloseConnection()
            ''country
            'Openconnection()
            'cmd1 = New OleDbCommand("select country from countrymaster where countryid='" & x & "'", con)
            'country = cmd1.ExecuteScalar
            'cou = x & "-" & country
            'cobcountry.SelectedText = cou
            'CloseConnection()
            ''state
            'Openconnection()
            'cmd2 = New OleDbCommand("select state from statemaster where stateid='" & y & "'", con)
            'state = cmd2.ExecuteScalar
            'stat = y & "-" & state
            'cobstate.SelectedText = stat
            'con.Close()
            ''city
            'Openconnection()
            'cmd3 = New OleDbCommand("select city from citymaster where cityid='" & z & "'", con)
            'city = cmd3.ExecuteScalar
            'cit = z & "-" & city
            'cobcity.SelectedText = cit

            'displays on entry/edit tabpage
            TabControl1.SelectedTab = TabEntry
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
    Private Sub cobcountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobcountry.SelectedIndexChanged
        Dim b, c As String
        cobstate.Items.Clear()
        b = cobcountry.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobstate, "select stateid,state from statemaster where countryid='" & c & "'")
    End Sub
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
    Private Sub cobbillcountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobbillcountry.SelectedIndexChanged
        Dim b, c As String
        cobbillstate.Items.Clear()
        b = cobbillcountry.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobbillstate, "select stateid,state from statemaster where countryid='" & c & "'")
    End Sub
    Private Sub cobbillstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobbillstate.SelectedIndexChanged
        Dim b, c As String
        cobbillcity.Items.Clear()
        b = cobbillstate.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobbillcity, "select cityid,city from citymaster where stateid='" & c & "'")
    End Sub
    Private Sub txtnoadults_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtzip.KeyPress, txthphone.KeyPress, txtwphone.KeyPress, txtmobile.KeyPress, txtfax.KeyPress, txtbillzip.KeyPress
        numberonly(e)
    End Sub
    Private Sub txtfname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress, txtlname.KeyPress, txtmname.KeyPress
        textonly(e)
    End Sub
    Private Sub txtpassportno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassportno.KeyPress
        textandnumbers(e)
    End Sub
    Private Sub txtemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        email(txtemail)
    End Sub
    Private Sub txtfname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.Leave
        firstcap(txtfname)
    End Sub
    Private Sub txtlname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlname.Leave
        firstcap(txtlname)
    End Sub
    Private Sub txtmname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmname.Leave
        firstcap(txtmname)
    End Sub
    Private Sub txtnotes_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnotes.Leave
        firstcap(txtnotes)
    End Sub
    Private Sub cobcity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcity.KeyPress, cobstate.KeyPress, cobcountry.KeyPress, cobagentname.KeyPress, cobmaritalstatus.KeyPress, cobbillcity.KeyPress, cobbillcountry.KeyPress, cobbillstate.KeyPress
        combo(e)
    End Sub
    Private Sub dtpdob_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpdob.TextChanged
        dtpannivdate.MinDate = FormatDateTime(dtpdob.Text, DateFormat.ShortDate)
    End Sub
    Private Sub dtpfromdateview_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfromdateview.TextChanged
        Dim d As Date
        d = FormatDateTime(dtpfromdateview.Text, DateFormat.ShortDate)
        dtptodateview.MinDate = DateAdd(DateInterval.Day, 1, d)
    End Sub
    Private Sub cobmaritalstatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobmaritalstatus.TextChanged
        If cobmaritalstatus.Text = "Unmarried" Then
            dtpannivdate.Checked = False
            dtpannivdate.Enabled = False
        ElseIf cobmaritalstatus.Text = "Married" Then
            dtpannivdate.Enabled = True
        End If
    End Sub

End Class
