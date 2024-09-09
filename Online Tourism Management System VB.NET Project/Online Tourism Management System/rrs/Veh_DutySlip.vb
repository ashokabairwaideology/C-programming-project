'ch.shiva kumar
'30/07/2006

Imports System.Data.OleDb
Public Class Veh_DutySlip
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
    Friend WithEvents Tabview As System.Windows.Forms.TabPage
    Friend WithEvents Tabentry As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtoutmileage As System.Windows.Forms.TextBox
    Friend WithEvents dtpgarageouttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpgarageotedt As System.Windows.Forms.DateTimePicker
    Friend WithEvents combotravelsid As System.Windows.Forms.ComboBox
    Friend WithEvents txtdrivername As System.Windows.Forms.TextBox
    Friend WithEvents txtvehid As System.Windows.Forms.TextBox
    Friend WithEvents rbohiredveh As System.Windows.Forms.RadioButton
    Friend WithEvents rboownveh As System.Windows.Forms.RadioButton
    Friend WithEvents combodrivername As System.Windows.Forms.ComboBox
    Friend WithEvents combovehid As System.Windows.Forms.ComboBox
    Friend WithEvents txtariffcode As System.Windows.Forms.TextBox
    Friend WithEvents rbochaffur As System.Windows.Forms.RadioButton
    Friend WithEvents rboselfdri As System.Windows.Forms.RadioButton
    Friend WithEvents combovehtype As System.Windows.Forms.ComboBox
    Friend WithEvents combovehbookid As System.Windows.Forms.ComboBox
    Friend WithEvents txtitinabookid As System.Windows.Forms.TextBox
    Friend WithEvents combocode As System.Windows.Forms.ComboBox
    Friend WithEvents txtpassengers As System.Windows.Forms.TextBox
    Friend WithEvents dtpdutyslipdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdutyslip As System.Windows.Forms.TextBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents combocountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpexcetedtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpreportingtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpexpetddt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtdurahrs As System.Windows.Forms.TextBox
    Friend WithEvents txtduradays As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpreportingdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtphone1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents combocity As System.Windows.Forms.ComboBox
    Friend WithEvents txtmoblie As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtguestname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents grpbx1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfromsrch As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptosrch As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGrid
    Friend WithEvents dgview As System.Windows.Forms.DataGrid
    Friend WithEvents Label31 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tabview = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.dgview = New System.Windows.Forms.DataGrid
        Me.Tabentry = New System.Windows.Forms.TabPage
        Me.grpbx1 = New System.Windows.Forms.GroupBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.btngo = New System.Windows.Forms.Button
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.dtptosrch = New System.Windows.Forms.DateTimePicker
        Me.dtpfromsrch = New System.Windows.Forms.DateTimePicker
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.dg1 = New System.Windows.Forms.DataGrid
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtoutmileage = New System.Windows.Forms.TextBox
        Me.dtpgarageouttime = New System.Windows.Forms.DateTimePicker
        Me.dtpgarageotedt = New System.Windows.Forms.DateTimePicker
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtvehid = New System.Windows.Forms.TextBox
        Me.txtdrivername = New System.Windows.Forms.TextBox
        Me.combotravelsid = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbohiredveh = New System.Windows.Forms.RadioButton
        Me.rboownveh = New System.Windows.Forms.RadioButton
        Me.combodrivername = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.combovehid = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtariffcode = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbochaffur = New System.Windows.Forms.RadioButton
        Me.rboselfdri = New System.Windows.Forms.RadioButton
        Me.combovehtype = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.combocountry = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtpexcetedtime = New System.Windows.Forms.DateTimePicker
        Me.dtpreportingtime = New System.Windows.Forms.DateTimePicker
        Me.dtpexpetddt = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtdurahrs = New System.Windows.Forms.TextBox
        Me.txtduradays = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpreportingdt = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtphone1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.combocity = New System.Windows.Forms.ComboBox
        Me.txtmoblie = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtguestname = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.combovehbookid = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtitinabookid = New System.Windows.Forms.TextBox
        Me.combocode = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtpassengers = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.dtpdutyslipdt = New System.Windows.Forms.DateTimePicker
        Me.txtdutyslip = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.Tabview.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabentry.SuspendLayout()
        Me.grpbx1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tabview)
        Me.TabControl1.Controls.Add(Me.Tabentry)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 408)
        Me.TabControl1.TabIndex = 0
        '
        'Tabview
        '
        Me.Tabview.Controls.Add(Me.GroupBox7)
        Me.Tabview.Location = New System.Drawing.Point(4, 22)
        Me.Tabview.Name = "Tabview"
        Me.Tabview.Size = New System.Drawing.Size(656, 382)
        Me.Tabview.TabIndex = 0
        Me.Tabview.Text = "View"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dgview)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(624, 304)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        '
        'dgview
        '
        Me.dgview.CaptionVisible = False
        Me.dgview.DataMember = ""
        Me.dgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgview.Location = New System.Drawing.Point(24, 48)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.Size = New System.Drawing.Size(576, 208)
        Me.dgview.TabIndex = 0
        '
        'Tabentry
        '
        Me.Tabentry.Controls.Add(Me.grpbx1)
        Me.Tabentry.Controls.Add(Me.GroupBox4)
        Me.Tabentry.Controls.Add(Me.GroupBox2)
        Me.Tabentry.Controls.Add(Me.GroupBox1)
        Me.Tabentry.Location = New System.Drawing.Point(4, 22)
        Me.Tabentry.Name = "Tabentry"
        Me.Tabentry.Size = New System.Drawing.Size(656, 382)
        Me.Tabentry.TabIndex = 1
        Me.Tabentry.Text = "Entry / Edit"
        '
        'grpbx1
        '
        Me.grpbx1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.grpbx1.Controls.Add(Me.Label31)
        Me.grpbx1.Controls.Add(Me.btngo)
        Me.grpbx1.Controls.Add(Me.Label30)
        Me.grpbx1.Controls.Add(Me.Label29)
        Me.grpbx1.Controls.Add(Me.dtptosrch)
        Me.grpbx1.Controls.Add(Me.dtpfromsrch)
        Me.grpbx1.Controls.Add(Me.Button3)
        Me.grpbx1.Controls.Add(Me.Button2)
        Me.grpbx1.Controls.Add(Me.dg1)
        Me.grpbx1.Location = New System.Drawing.Point(32, 32)
        Me.grpbx1.Name = "grpbx1"
        Me.grpbx1.Size = New System.Drawing.Size(552, 264)
        Me.grpbx1.TabIndex = 3
        Me.grpbx1.TabStop = False
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(192, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(136, 23)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Booking Id Search"
        '
        'btngo
        '
        Me.btngo.BackColor = System.Drawing.Color.White
        Me.btngo.Location = New System.Drawing.Point(376, 48)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(56, 23)
        Me.btngo.TabIndex = 4
        Me.btngo.Text = "Go"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(216, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 23)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "To"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(56, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 23)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "From"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtptosrch
        '
        Me.dtptosrch.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtptosrch.Location = New System.Drawing.Point(264, 48)
        Me.dtptosrch.Name = "dtptosrch"
        Me.dtptosrch.Size = New System.Drawing.Size(96, 21)
        Me.dtptosrch.TabIndex = 3
        '
        'dtpfromsrch
        '
        Me.dtpfromsrch.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfromsrch.Location = New System.Drawing.Point(112, 48)
        Me.dtpfromsrch.Name = "dtpfromsrch"
        Me.dtpfromsrch.Size = New System.Drawing.Size(96, 21)
        Me.dtpfromsrch.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(272, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Close"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(152, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Update"
        '
        'dg1
        '
        Me.dg1.BackgroundColor = System.Drawing.Color.Silver
        Me.dg1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.dg1.CaptionForeColor = System.Drawing.Color.Black
        Me.dg1.CaptionVisible = False
        Me.dg1.DataMember = ""
        Me.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg1.Location = New System.Drawing.Point(8, 80)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(528, 136)
        Me.dg1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtoutmileage)
        Me.GroupBox4.Controls.Add(Me.dtpgarageouttime)
        Me.GroupBox4.Controls.Add(Me.dtpgarageotedt)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.txtariffcode)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.combovehtype)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(344, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(312, 296)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Vehicle And Tariff Details"
        '
        'txtoutmileage
        '
        Me.txtoutmileage.Location = New System.Drawing.Point(176, 264)
        Me.txtoutmileage.MaxLength = 10
        Me.txtoutmileage.Name = "txtoutmileage"
        Me.txtoutmileage.Size = New System.Drawing.Size(120, 21)
        Me.txtoutmileage.TabIndex = 22
        Me.txtoutmileage.Text = ""
        '
        'dtpgarageouttime
        '
        Me.dtpgarageouttime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpgarageouttime.Location = New System.Drawing.Point(176, 240)
        Me.dtpgarageouttime.Name = "dtpgarageouttime"
        Me.dtpgarageouttime.ShowUpDown = True
        Me.dtpgarageouttime.Size = New System.Drawing.Size(112, 21)
        Me.dtpgarageouttime.TabIndex = 21
        '
        'dtpgarageotedt
        '
        Me.dtpgarageotedt.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpgarageotedt.Location = New System.Drawing.Point(176, 216)
        Me.dtpgarageotedt.Name = "dtpgarageotedt"
        Me.dtpgarageotedt.Size = New System.Drawing.Size(112, 21)
        Me.dtpgarageotedt.TabIndex = 20
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 272)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(159, 17)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Garage out milage Reading"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 248)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 17)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Garage Out Time"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 216)
        Me.Label23.Name = "Label23"
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Garage Out Date"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtvehid)
        Me.GroupBox6.Controls.Add(Me.txtdrivername)
        Me.GroupBox6.Controls.Add(Me.combotravelsid)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.rbohiredveh)
        Me.GroupBox6.Controls.Add(Me.rboownveh)
        Me.GroupBox6.Controls.Add(Me.combodrivername)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.combovehid)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(296, 120)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Duty Slip Billing Details"
        '
        'txtvehid
        '
        Me.txtvehid.Location = New System.Drawing.Point(112, 40)
        Me.txtvehid.MaxLength = 5
        Me.txtvehid.Name = "txtvehid"
        Me.txtvehid.Size = New System.Drawing.Size(112, 21)
        Me.txtvehid.TabIndex = 17
        Me.txtvehid.Text = ""
        '
        'txtdrivername
        '
        Me.txtdrivername.Location = New System.Drawing.Point(112, 72)
        Me.txtdrivername.MaxLength = 15
        Me.txtdrivername.Name = "txtdrivername"
        Me.txtdrivername.Size = New System.Drawing.Size(136, 21)
        Me.txtdrivername.TabIndex = 18
        Me.txtdrivername.Text = ""
        '
        'combotravelsid
        '
        Me.combotravelsid.Location = New System.Drawing.Point(112, 96)
        Me.combotravelsid.Name = "combotravelsid"
        Me.combotravelsid.Size = New System.Drawing.Size(168, 21)
        Me.combotravelsid.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Travels Id *"
        '
        'rbohiredveh
        '
        Me.rbohiredveh.Location = New System.Drawing.Point(176, 17)
        Me.rbohiredveh.Name = "rbohiredveh"
        Me.rbohiredveh.Size = New System.Drawing.Size(112, 16)
        Me.rbohiredveh.TabIndex = 16
        Me.rbohiredveh.Text = "Hired Vehicle"
        '
        'rboownveh
        '
        Me.rboownveh.Checked = True
        Me.rboownveh.Location = New System.Drawing.Point(16, 17)
        Me.rboownveh.Name = "rboownveh"
        Me.rboownveh.Size = New System.Drawing.Size(112, 16)
        Me.rboownveh.TabIndex = 15
        Me.rboownveh.TabStop = True
        Me.rboownveh.Text = "Own Vehicle"
        '
        'combodrivername
        '
        Me.combodrivername.Location = New System.Drawing.Point(112, 72)
        Me.combodrivername.Name = "combodrivername"
        Me.combodrivername.Size = New System.Drawing.Size(168, 21)
        Me.combodrivername.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 17)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Driver Name"
        '
        'combovehid
        '
        Me.combovehid.Location = New System.Drawing.Point(112, 40)
        Me.combovehid.Name = "combovehid"
        Me.combovehid.Size = New System.Drawing.Size(168, 21)
        Me.combovehid.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Vehicle Id *"
        '
        'txtariffcode
        '
        Me.txtariffcode.BackColor = System.Drawing.Color.Silver
        Me.txtariffcode.Location = New System.Drawing.Point(256, 16)
        Me.txtariffcode.Name = "txtariffcode"
        Me.txtariffcode.ReadOnly = True
        Me.txtariffcode.Size = New System.Drawing.Size(48, 21)
        Me.txtariffcode.TabIndex = 5
        Me.txtariffcode.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(176, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 17)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Tariff Code *"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbochaffur)
        Me.GroupBox5.Controls.Add(Me.rboselfdri)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(288, 40)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Drive"
        '
        'rbochaffur
        '
        Me.rbochaffur.Location = New System.Drawing.Point(152, 17)
        Me.rbochaffur.Name = "rbochaffur"
        Me.rbochaffur.Size = New System.Drawing.Size(104, 16)
        Me.rbochaffur.TabIndex = 14
        Me.rbochaffur.Text = "Chauffeur"
        '
        'rboselfdri
        '
        Me.rboselfdri.Checked = True
        Me.rboselfdri.Location = New System.Drawing.Point(32, 17)
        Me.rboselfdri.Name = "rboselfdri"
        Me.rboselfdri.Size = New System.Drawing.Size(80, 16)
        Me.rboselfdri.TabIndex = 13
        Me.rboselfdri.TabStop = True
        Me.rboselfdri.Text = "Self Drive"
        '
        'combovehtype
        '
        Me.combovehtype.BackColor = System.Drawing.Color.Gainsboro
        Me.combovehtype.Location = New System.Drawing.Point(88, 16)
        Me.combovehtype.Name = "combovehtype"
        Me.combovehtype.Size = New System.Drawing.Size(72, 21)
        Me.combovehtype.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 17)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Vehicle Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combocountry)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtphone1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.combocity)
        Me.GroupBox2.Controls.Add(Me.txtmoblie)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtguestname)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 280)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guest And Reporting Perticulars"
        '
        'combocountry
        '
        Me.combocountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocountry.ItemHeight = 13
        Me.combocountry.Location = New System.Drawing.Point(80, 80)
        Me.combocountry.Name = "combocountry"
        Me.combocountry.Size = New System.Drawing.Size(88, 21)
        Me.combocountry.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Country *"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpexcetedtime)
        Me.GroupBox3.Controls.Add(Me.dtpreportingtime)
        Me.GroupBox3.Controls.Add(Me.dtpexpetddt)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtdurahrs)
        Me.GroupBox3.Controls.Add(Me.txtduradays)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpreportingdt)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 120)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reporting Details"
        '
        'dtpexcetedtime
        '
        Me.dtpexcetedtime.CustomFormat = "HH:mm"
        Me.dtpexcetedtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexcetedtime.Location = New System.Drawing.Point(232, 88)
        Me.dtpexcetedtime.Name = "dtpexcetedtime"
        Me.dtpexcetedtime.ShowUpDown = True
        Me.dtpexcetedtime.Size = New System.Drawing.Size(56, 21)
        Me.dtpexcetedtime.TabIndex = 12
        Me.dtpexcetedtime.Value = New Date(2006, 7, 19, 14, 1, 36, 562)
        '
        'dtpreportingtime
        '
        Me.dtpreportingtime.CustomFormat = "HH:mm"
        Me.dtpreportingtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpreportingtime.Location = New System.Drawing.Point(232, 24)
        Me.dtpreportingtime.Name = "dtpreportingtime"
        Me.dtpreportingtime.ShowUpDown = True
        Me.dtpreportingtime.Size = New System.Drawing.Size(56, 21)
        Me.dtpreportingtime.TabIndex = 10
        Me.dtpreportingtime.Value = New Date(2006, 7, 19, 14, 1, 36, 578)
        '
        'dtpexpetddt
        '
        Me.dtpexpetddt.AccessibleDescription = ""
        Me.dtpexpetddt.CalendarMonthBackground = System.Drawing.Color.Gainsboro
        Me.dtpexpetddt.CalendarTitleForeColor = System.Drawing.Color.Gainsboro
        Me.dtpexpetddt.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpexpetddt.Location = New System.Drawing.Point(104, 88)
        Me.dtpexpetddt.Name = "dtpexpetddt"
        Me.dtpexpetddt.Size = New System.Drawing.Size(88, 21)
        Me.dtpexpetddt.TabIndex = 11
        Me.dtpexpetddt.Value = New Date(2006, 7, 19, 14, 1, 36, 578)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(192, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 17)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 17)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Expected Date"
        '
        'txtdurahrs
        '
        Me.txtdurahrs.Location = New System.Drawing.Point(232, 56)
        Me.txtdurahrs.Name = "txtdurahrs"
        Me.txtdurahrs.ReadOnly = True
        Me.txtdurahrs.Size = New System.Drawing.Size(56, 21)
        Me.txtdurahrs.TabIndex = 9
        Me.txtdurahrs.Text = ""
        '
        'txtduradays
        '
        Me.txtduradays.Location = New System.Drawing.Point(104, 56)
        Me.txtduradays.Name = "txtduradays"
        Me.txtduradays.ReadOnly = True
        Me.txtduradays.Size = New System.Drawing.Size(72, 21)
        Me.txtduradays.TabIndex = 8
        Me.txtduradays.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(192, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 17)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Hours"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(64, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 17)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Days"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 17)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Duration"
        '
        'dtpreportingdt
        '
        Me.dtpreportingdt.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpreportingdt.Location = New System.Drawing.Point(104, 24)
        Me.dtpreportingdt.Name = "dtpreportingdt"
        Me.dtpreportingdt.Size = New System.Drawing.Size(80, 21)
        Me.dtpreportingdt.TabIndex = 9
        Me.dtpreportingdt.Value = New Date(2006, 7, 19, 14, 1, 36, 656)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(192, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Time *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Reporting Date *"
        '
        'txtphone1
        '
        Me.txtphone1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone1.Location = New System.Drawing.Point(80, 112)
        Me.txtphone1.MaxLength = 12
        Me.txtphone1.Name = "txtphone1"
        Me.txtphone1.Size = New System.Drawing.Size(88, 21)
        Me.txtphone1.TabIndex = 7
        Me.txtphone1.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Phone2"
        '
        'combocity
        '
        Me.combocity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocity.ItemHeight = 13
        Me.combocity.Location = New System.Drawing.Point(232, 80)
        Me.combocity.Name = "combocity"
        Me.combocity.Size = New System.Drawing.Size(88, 21)
        Me.combocity.TabIndex = 6
        '
        'txtmoblie
        '
        Me.txtmoblie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmoblie.Location = New System.Drawing.Point(232, 112)
        Me.txtmoblie.MaxLength = 12
        Me.txtmoblie.Name = "txtmoblie"
        Me.txtmoblie.Size = New System.Drawing.Size(88, 21)
        Me.txtmoblie.TabIndex = 8
        Me.txtmoblie.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(184, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Mobile"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "City *"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(80, 48)
        Me.txtaddress.MaxLength = 25
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(240, 21)
        Me.txtaddress.TabIndex = 4
        Me.txtaddress.Text = ""
        '
        'txtguestname
        '
        Me.txtguestname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguestname.Location = New System.Drawing.Point(80, 16)
        Me.txtguestname.MaxLength = 20
        Me.txtguestname.Name = "txtguestname"
        Me.txtguestname.Size = New System.Drawing.Size(240, 21)
        Me.txtguestname.TabIndex = 3
        Me.txtguestname.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Address *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Guest Name *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combovehbookid)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtitinabookid)
        Me.GroupBox1.Controls.Add(Me.combocode)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtpassengers)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.dtpdutyslipdt)
        Me.GroupBox1.Controls.Add(Me.txtdutyslip)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcustname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking"
        '
        'combovehbookid
        '
        Me.combovehbookid.Location = New System.Drawing.Point(568, 17)
        Me.combovehbookid.Name = "combovehbookid"
        Me.combovehbookid.Size = New System.Drawing.Size(88, 21)
        Me.combovehbookid.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(464, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 17)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "Veh Booking ID *"
        '
        'txtitinabookid
        '
        Me.txtitinabookid.Location = New System.Drawing.Point(120, 16)
        Me.txtitinabookid.MaxLength = 10
        Me.txtitinabookid.Name = "txtitinabookid"
        Me.txtitinabookid.Size = New System.Drawing.Size(88, 21)
        Me.txtitinabookid.TabIndex = 0
        Me.txtitinabookid.Text = ""
        '
        'combocode
        '
        Me.combocode.Location = New System.Drawing.Point(568, 40)
        Me.combocode.Name = "combocode"
        Me.combocode.Size = New System.Drawing.Size(72, 21)
        Me.combocode.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(512, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(33, 17)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Code"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        '
        'txtpassengers
        '
        Me.txtpassengers.Location = New System.Drawing.Point(440, 40)
        Me.txtpassengers.Name = "txtpassengers"
        Me.txtpassengers.ReadOnly = True
        Me.txtpassengers.Size = New System.Drawing.Size(56, 21)
        Me.txtpassengers.TabIndex = 11
        Me.txtpassengers.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(368, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 17)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Passengers"
        '
        'dtpdutyslipdt
        '
        Me.dtpdutyslipdt.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpdutyslipdt.Location = New System.Drawing.Point(272, 40)
        Me.dtpdutyslipdt.Name = "dtpdutyslipdt"
        Me.dtpdutyslipdt.Size = New System.Drawing.Size(96, 21)
        Me.dtpdutyslipdt.TabIndex = 1
        '
        'txtdutyslip
        '
        Me.txtdutyslip.BackColor = System.Drawing.Color.Gainsboro
        Me.txtdutyslip.Location = New System.Drawing.Point(88, 40)
        Me.txtdutyslip.Name = "txtdutyslip"
        Me.txtdutyslip.ReadOnly = True
        Me.txtdutyslip.Size = New System.Drawing.Size(80, 21)
        Me.txtdutyslip.TabIndex = 8
        Me.txtdutyslip.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Duty Slip Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Duty Slip No"
        '
        'txtcustname
        '
        Me.txtcustname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcustname.Location = New System.Drawing.Point(336, 16)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(104, 21)
        Me.txtcustname.TabIndex = 3
        Me.txtcustname.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking ID *"
        '
        'Veh_DutySlip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(664, 405)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Veh_DutySlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Allocation"
        Me.TabControl1.ResumeLayout(False)
        Me.Tabview.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabentry.ResumeLayout(False)
        Me.grpbx1.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim CUSTID As String
    Dim int_vbookingid As Integer
    Dim recstatus As EnuRecstatus
    Dim dr As OleDbDataReader
    Dim int_passngrs As Integer = 0
    Dim int_dtslp As Integer
    Dim dt As Date
    Dim str_regsno, str_userid As String
    Dim str_tariffcode As String
    Dim str_VEHTYPEID As String
    Dim str_drive As String
    Dim str_typeofveh, str_drivernm, str_travelsid, str_countryid, str_cityid As String


    Public Sub enable()
        combocode.Enabled = True
        combotravelsid.Enabled = True
        combovehbookid.Enabled = True
        combovehid.Enabled = True
        combovehtype.Enabled = True
        rbochaffur.Enabled = True
        rbohiredveh.Enabled = True
        rboownveh.Enabled = True
        rboselfdri.Enabled = True
        dtpgarageouttime.Enabled = True


        txtitinabookid.Enabled = True
        txtpassengers.Enabled = True
        txtguestname.Enabled = True
        txtdrivername.Enabled = True
        txtaddress.Enabled = True
        txtariffcode.Enabled = True
        txtduradays.Enabled = True
        txtdurahrs.Enabled = True
        txtdutyslip.Enabled = True
        txtmoblie.Enabled = True
        txtoutmileage.Enabled = True
        txtphone1.Enabled = True
        txtvehid.Enabled = True
        combocity.Enabled = True
        combocountry.Enabled = True
        combodrivername.Enabled = True
        dtpdutyslipdt.Enabled = True
        dtpexcetedtime.Enabled = True
        dtpexpetddt.Enabled = True
        dtpfromsrch.Enabled = True
        dtpgarageotedt.Enabled = True
        dtpreportingtime.Enabled = True
        dtpreportingdt.Enabled = True
        dtptosrch.Enabled = True

    End Sub
    Public Sub disable()
        combocode.Enabled = False
        combotravelsid.Enabled = False
        dtpgarageouttime.Enabled = False

        combovehbookid.Enabled = False
        combovehid.Enabled = False
        combovehtype.Enabled = False
        rbochaffur.Enabled = False
        rbohiredveh.Enabled = False
        rboownveh.Enabled = False
        rboselfdri.Enabled = False

        txtitinabookid.Enabled = False
        txtpassengers.Enabled = False
        txtguestname.Enabled = False
        txtdrivername.Enabled = False
        txtaddress.Enabled = False
        txtariffcode.Enabled = False
        txtduradays.Enabled = False
        txtdurahrs.Enabled = False
        txtdutyslip.Enabled = False
        txtmoblie.Enabled = False
        txtoutmileage.Enabled = False
        txtphone1.Enabled = False
        txtvehid.Enabled = False
        combocity.Enabled = False
        combocountry.Enabled = False
        combodrivername.Enabled = False
        dtpdutyslipdt.Enabled = False
        dtpexcetedtime.Enabled = False
        dtpexpetddt.Enabled = False
        dtpfromsrch.Enabled = False
        dtpgarageotedt.Enabled = False
        dtpreportingtime.Enabled = False
        dtpreportingdt.Enabled = False
        dtptosrch.Enabled = False



    End Sub
    Public Sub CLEARPROC()


        combovehbookid.SelectedItem = ""
        combovehbookid.Text = ""
        combocode.SelectedItem = ""
        combocode.Text = ""
        combotravelsid.SelectedItem = ""
        txtitinabookid.Text = ""
        txtpassengers.Text = ""
        txtguestname.Text = ""
        txtdrivername.Text = ""
        txtaddress.Text = ""
        txtariffcode.Text = ""
        txtduradays.Text = ""
        txtdurahrs.Text = ""
        txtdutyslip.Text = ""
        txtmoblie.Text = ""
        txtoutmileage.Text = ""
        txtphone1.Text = ""
        txtvehid.Text = ""
        txtcustname.Text = ""
        combocity.SelectedItem = ""
        combocity.Text = ""
        combocountry.Text = ""
        combocountry.SelectedItem = ""
        combodrivername.SelectedItem = ""
        combovehbookid.SelectedItem = ""

    End Sub

    Public Sub newproc()
        enable()
        txtitinabookid.Focus()
        CLEARPROC()
        recstatus = Module1.EnuRecstatus.Recnew
        TabControl1.SelectedTab = Tabentry
    End Sub
    Public Sub editproc()
        txtitinabookid.ReadOnly = True
        'combodrivername.Enabled = True
        enable()
        recstatus = Module1.EnuRecstatus.Recedit
    End Sub

    Public Sub saveproc()
        Dim p As Integer = 0

        str_userid = ""
        str_regsno = 1
        dt = Date.Now

        If combocode.SelectedItem = "" Then
            MsgBox("Select The Code", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If

        If combocity.SelectedItem = "" Then
            MsgBox("Enter City", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        If combocountry.SelectedItem = "" Then
            MsgBox("Enter Country", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub

        End If
        If txtoutmileage.Text = "" Then
            MsgBox("Enter Out Mileage Reading", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        Dim a, b, c As String
        a = combocity.SelectedItem
        str_cityid = (a.Substring(0, a.IndexOf("-")))

        b = combocountry.SelectedItem
        str_countryid = (b.Substring(0, b.IndexOf("-")))


        'If Chaffur Selected 
        If rbochaffur.Checked = True Then
            str_drive = "CHAFFUR"
            If rbohiredveh.Checked = True Then
                str_drivernm = txtdrivername.Text
                str_VEHTYPEID = txtvehid.Text
                str_typeofveh = "HIRED"
                CloseConnection()
            End If

            If rboownveh.Checked = True Then
                Dim str_bb, str_cc As String
                str_bb = combovehid.SelectedItem
                str_VEHTYPEID = (b.Substring(0, b.IndexOf("-")))

                'ombovehid.SelectedItem

                c = combodrivername.SelectedItem
                str_drivernm = (c.Substring(0, c.IndexOf("-")))
                Try


                    Openconnection()
                    cmd = New OleDbCommand("select regno from ownvehiclemaster where TRIM(vehtypeid)='" & str_VEHTYPEID & "'", con)


                    str_regsno = cmd.ExecuteScalar
                Catch ex As Exception
                    MsgBox(EX.Message)
                End Try
                str_typeofveh = "OWN"
            End If

        End If
        ' if self drive selected and own vehicle

        If rboownveh.Checked = True And rboselfdri.Checked = True Then
            Dim str_bb As String

            str_drive = "SELF"
            'c = combodrivername.SelectedItem
            'drivernm = (c.Substring(0, c.IndexOf("-")))
            str_drivernm = ""
            str_bb = combovehid.SelectedItem
            str_VEHTYPEID = (b.Substring(0, b.IndexOf("-")))
            str_typeofveh = "HIRED"
            'Else
            '    drivernm = txtdrivername.Text
        End If
        '
        'if self drive selected and hired vwhicle
        '
        If rbohiredveh.Checked = True And rboselfdri.Checked = True Then
            str_drive = "SELF"
            str_drivernm = ""
            str_VEHTYPEID = txtvehid.Text
            str_typeofveh = "HIRED"

        End If
        str_travelsid = combotravelsid.SelectedItem
        Openconnection()

        Try

            '******************************************************************************************
            '**********************WHEN RECORD NEW RECORD INSERTED*************************************

            If recstatus = Module1.EnuRecstatus.Recnew Then
                Dim maxno, vid As Integer


                '*********************To Find The Maximum No *********************
                cmd = New OleDbCommand("select count(*) from veh_dutyslip", con)
                maxno = cmd.ExecuteScalar()
                cmd.Dispose()
                If maxno = 0 Then
                    vid = 1
                Else
                    cmd = New OleDbCommand("select max(dtyslpno)+1 from veh_dutyslip", con)
                    vid = cmd.ExecuteScalar
                    cmd.Dispose()
                End If
                '****************************TO Check Weather The Duty Slip already Generated Or Not*************
                '************************************************************************************************
                'Openconnection()
                cmd = New OleDbCommand("select count(*) from veh_dutyslip where trim(custid)='" & CUSTID & "' and vbookid=" & combovehbookid.SelectedItem & "", con)
                p = cmd.ExecuteScalar
                'CloseConnection()
                cmd.Dispose()
                If p = 0 Then
                    ' Openconnection()
                    '*******************Insert Into The Database When It IS New Record**************
                    '
                    cmd = New OleDbCommand("insert into veh_dutyslip values(" & vid & ",'" & FormatDateTime(dtpdutyslipdt.Text, DateFormat.ShortDate) & "','" & combovehbookid.SelectedItem & "','" & CUSTID & "','" & txtitinabookid.Text & "'," & int_passngrs & ",'" & combocode.SelectedItem & "','" & IIf(txtariffcode.Text = "", 0, txtariffcode.Text) & "','" & str_VEHTYPEID & "','" & str_drive & "','" & str_typeofveh & "'," & str_regsno & ", '" & str_drivernm & "','" & str_travelsid & "','" & IIf(txtguestname.Text = "", " ", txtguestname.Text) & "','" & IIf(txtaddress.Text = "", " ", txtaddress.Text) & "','" & str_countryid & "','" & str_cityid & "'," & IIf(txtphone1.Text = "", 0, txtphone1.Text) & "," & IIf(txtmoblie.Text = "", 0, txtmoblie.Text) & ",'" & Format(dtpreportingdt.Value, "mm/dd/yyyy") & "','" & dtpreportingtime.Text & "','" & FormatDateTime(dtpexpetddt.Text, DateFormat.ShortDate) & "','" & dtpexcetedtime.Text & "','" & FormatDateTime(dtpgarageotedt.Text, DateFormat.ShortDate) & "','" & dtpgarageouttime.Text & "'," & IIf(txtoutmileage.Text = "", 0, txtoutmileage.Text) & ",'Y','Y','" & str_userid & "','" & FormatDateTime(dt, DateFormat.ShortDate) & "')", con)
                    cmd.ExecuteNonQuery()
                    '
                    'To Update the custmer vehicle table duty slip flag to Y
                    'to in dicate the Voucher generated
                    cmd = New OleDbCommand("update cust_vehicle set DutySlipFlag='Y'", con)
                    cmd.ExecuteNonQuery()
                    'CloseConnection()
                    MsgSav()
                    CLEARPROC()
                    cmd.Dispose()
                Else
                    MsgBox("Duty Slip Already Generated", MsgBoxStyle.OKOnly, Prjtitle)
                End If

            End If
            'End if New record

            If recstatus = Module1.EnuRecstatus.Recedit Then

                cmd = New OleDbCommand("update veh_dutyslip set dtyslpdt='" & FormatDateTime(dtpdutyslipdt.Text, DateFormat.ShortDate) & "',bookingid='" & txtitinabookid.Text & "',pax_nos=" & int_passngrs & ",cust_code='" & combocode.SelectedItem & "',Tariffcode=" & txtariffcode.Text & ",VehTypeid='" & combovehid.SelectedItem & "',Veh_Own_Hir='" & str_typeofveh & "',RegNo='" & str_regsno & "',EmployeeId='" & str_drivernm & "',TravelsId=" & combotravelsid.SelectedItem & ",Gust_Name='" & txtguestname.Text & "',Gust_Addr='" & txtaddress.Text & "',CountryId='" & str_countryid & "',CityId='" & str_cityid & "',Phone=" & txtphone1.Text & ",Mobile=" & txtmoblie.Text & ",RepDt='" & dtpreportingdt.Value & "',RepTime='" & dtpreportingtime.Value & "',ExpDt='" & dtpexpetddt.Value & "',exptime='" & dtpexcetedtime.Value & "',GaroutDt='" & dtpgarageotedt.Value & "',GaroutTime='" & dtpgarageouttime.Value & "',GaroutMilread=" & txtoutmileage.Text & ",Billflag='Y',actflag='Y',userid='" & Muserid & "',entereddt='" & FormatDateTime(dt, DateFormat.ShortDate) & "' where dtyslpno=" & txtdutyslip.Text & "", con)



                Try

                    cmd.ExecuteNonQuery()
                    MsgSav()
                    CLEARPROC()
                    cmd.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                    CloseConnection()
                    Exit Sub
                Finally
                    CloseConnection()
                End Try

            End If
            'end if for a Record in Edit mode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub dgview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.DoubleClick
        disable()
        Dim n, i, bkid As Integer
        i = dgview.CurrentRowIndex
        Dim drnm, vehid As String

        int_dtslp = dgview.Item(i, 0)
        Openconnection()
        Dim str1, str2, str3 As String
        cmd = New OleDbCommand("select * from veh_dutyslip where dtyslpno=" & int_dtslp & "", con)
        Try
            dr = cmd.ExecuteReader

            txtdutyslip.Text = int_dtslp
            If dr.Read Then
                dtpdutyslipdt.Value = dr(1)
                bkid = dr(2)
                combovehbookid.SelectedItem = bkid
                CUSTID = dr(3)
                txtitinabookid.Text = dr(4)

                txtpassengers.Text = dr(5)
                combocode.SelectedItem = dr(6)
                combocode.Text = dr(6)
                txtariffcode.Text = dr(7)
                str_VEHTYPEID = dr(8)
                str_drive = Convert.ToString(dr(9))
                str_typeofveh = Trim(dr(10))

                str_regsno = dr(11)

                drnm = Convert.ToString(dr(12))

                combotravelsid.SelectedItem = dr(13)
                txtguestname.Text = dr(14)
                txtaddress.Text = dr(15)
                str_countryid = dr(16)
                combocountry.SelectedItem = dr(16)
                combocountry.Text = dr(16)

                str_cityid = dr(17)
                combocity.SelectedItem = dr(17)
                combocity.Text = dr(17)

                txtphone1.Text = dr(18)
                txtmoblie.Text = dr(19)
                dtpreportingdt.Text = FormatDateTime(dr(20), DateFormat.ShortDate)
                str1 = FormatDateTime(dr(21), DateFormat.ShortTime)
                str2 = FormatDateTime(dr(23), DateFormat.ShortTime)
                str3 = FormatDateTime(dr(25), DateFormat.ShortTime)


                dtpreportingtime.Text = str1
                dtpexpetddt.Text = FormatDateTime(dr(22), DateFormat.ShortDate)
                dtpexcetedtime.Text = str2
                dtpgarageotedt.Text = FormatDateTime(dr(24), DateFormat.ShortDate)
                dtpgarageouttime.Text = str3
                txtoutmileage.Text = dr(26)
                TabControl1.SelectedTab = Tabentry
            End If
            cmd.Dispose()


            dr.Close()
            CloseConnection()
            Openconnection()

            cmd = New OleDbCommand("select * from countrymaster where countryid='" & str_countryid & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                combocountry.SelectedItem = dr(0) & "-" & dr(1)
            End If
            dr.Close()
            cmd.Dispose()
            CloseConnection()
            Openconnection()
            cmd = New OleDbCommand("select * from citymaster where cityid='" & str_cityid & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                combocity.SelectedItem = dr(0) & "-" & dr(1)
            End If
            dr.Close()
            cmd.Dispose()
            CloseConnection()
            If str_drive = "SELF" Then
                rboselfdri.Checked = True
                If str_typeofveh = "OWN" Then
                    rboownveh.Checked = True
                    txtvehid.Visible = False
                    txtdrivername.Visible = False
                    combovehid.Visible = True
                    combovehid.SelectedItem = str_VEHTYPEID
                    combodrivername.Visible = True
                    combodrivername.SelectedItem = drnm


                    'combodrivername.Enabled = False
                End If
                If str_typeofveh = "HIRED" Then
                    rbohiredveh.Checked = True
                    txtvehid.Visible = True
                    txtvehid.Text = str_VEHTYPEID
                    txtdrivername.Text = drnm
                    combodrivername.Visible = False
                    combovehid.Visible = False
                End If
            End If
            If str_drive = "CHAFFER" Then
                rbochaffur.Checked = True
                If str_typeofveh = "OWN" Then
                    combovehid.Visible = True
                    combovehid.SelectedItem = str_VEHTYPEID
                    combodrivername.Visible = True
                    combodrivername.SelectedItem = drnm
                    txtvehid.Visible = False
                    txtdrivername.Visible = False
                End If
                If str_typeofveh = "HIRED" Then
                    rbohiredveh.Checked = True
                    combovehid.Visible = False
                    combodrivername.Visible = False

                    txtvehid.Visible = True
                    txtdrivername.Visible = True
                    txtdrivername.Text = drnm

                    txtvehid.Text = str_VEHTYPEID
                End If
            End If
            combofill(combovehbookid, "select vbookid from cust_vehicle where trim(custid)='" & CUSTID & "'")
            cmd.Dispose()
            Openconnection()
            cmd = New OleDbCommand("select days from cust_vehicle where vbookid=" & bkid & "", con)
            txtduradays.Text = cmd.ExecuteScalar
            cmd.Dispose()

            cmd = New OleDbCommand("select fname from cust_master where custid='" & CUSTID & "'", con)
            txtcustname.Text = cmd.ExecuteScalar
            cmd.Dispose()


            CloseConnection()
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
    Public Sub delproc()
        int_dtslp = txtdutyslip.Text
        If MsgDelAlert() = vbYes Then
            Try

                Openconnection()
                cmd = New OleDbCommand("update veh_dutyslip  set actflag='N' where dtyslpno=" & int_dtslp & "", con)
                cmd.ExecuteNonQuery()
                MsgDel()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                CloseConnection()
                Exit Sub
            Finally
                CloseConnection()

            End Try
        End If
    End Sub

    Private Sub Veh_DutySlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        ' Tool Bar buttons enabled and  disabled  while form load
        '

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        disable()

        grpbx1.Visible = False
        TabControl1.SelectedTab = Tabentry
        txtvehid.Visible = False
        txtdrivername.Visible = False
        rbochaffur.Checked = True
        rbohiredveh.Checked = True
        combofill1(combocountry, "select * from countrymaster")
        ' combofill(combovehtype, "select vehtypeid  from veh_type ")
        combofill1(combodrivername, "select employeeid,firstname from employeemaster")
        combofill1(combovehid, "select VehTypeid,VehType from veh_type")
        combofill(combotravelsid, "select travelsid from travels_mast")
        combofill(combocode, "select cust_code from cust_code")
        dt = Date.Now

    End Sub

    Private Sub rboownveh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rboownveh.Click
        If rboselfdri.Checked = True Then
            txtvehid.Visible = False
            txtdrivername.Visible = False
            'txtdrivername.Enabled = True
            'txtdrivername.Enabled = False
            combodrivername.Visible = True
            combovehid.Visible = True
            combovehid.Focus()
            combodrivername.Enabled = False
        End If
        If rbochaffur.Checked = True Then
            txtvehid.Visible = False
            txtdrivername.Visible = False
            'txtdrivername.Enabled = True
            'txtdrivername.Enabled = False
            combodrivername.Visible = True
            combovehid.Visible = True
            combodrivername.Enabled = True
        End If
    End Sub

    Private Sub rbohiredveh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbohiredveh.Click
        'If rbohiredveh.Checked = True Then


        If rboselfdri.Checked = True Then
            txtvehid.Visible = True
            txtvehid.Focus()
            txtdrivername.Visible = True
            txtdrivername.Enabled = False
            'txtdrivername.ReadOnly = True
            combodrivername.Visible = False
            combovehid.Visible = False
        End If
        If rbochaffur.Checked = True Then

            txtvehid.Visible = True
            txtvehid.Focus()
            txtdrivername.Visible = True
            txtdrivername.Enabled = True
            txtdrivername.TabIndex = 1

            ' txtdrivername.Enabled = False
            'txtdrivername.ReadOnly = True
            combodrivername.Visible = False
            combodrivername.Enabled = True
            combovehid.Visible = False
        End If

        ' End If
    End Sub
    'Private Sub rboselfdri_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rboselfdri.Click

    '    If rbohiredveh.Checked = True Then
    '        combodrivername.Visible = False
    '        combovehid.Visible = False
    '        txtdrivername.Visible = True
    '        txtdrivername.Enabled = False
    '        txtvehid.Visible = True
    '    End If
    'End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'search button
        ds.Clear()
        If txtitinabookid.Text = "" Then
            Button2.Enabled = False

            grpbx1.Visible = True
            dtpfromsrch.Focus()
        Else
            Try
                Openconnection()
                Dim int_k As Integer
                cmd = New OleDbCommand("select count(*) from booking_itinary where trim(bookingid) Like '" & "%" & txtitinabookid.Text & "%" & "'", con)


                int_k = cmd.ExecuteScalar
                If int_k <> 0 Then



                    da = New OleDbDataAdapter("select SysRefNo,BookingId,CustId,Itina_Type,Bkdate,StDate,EndDate,TAmount,Gross_Amount from booking_itinary where trim(bookingid)='" & Trim(txtitinabookid.Text) & "'", con)
                    da.Fill(ds, "custvehi")
                    'If ds.Tables("custvehi").Rows.Count >= 1 Then

                    dg1.DataSource = ds.Tables("custvehi")
                    grpbx1.Visible = True
                    Button2.Enabled = True
                    dtpfromsrch.Focus()

                Else
                    MsgBox("No Record Exists With This Data")
                    Button2.Enabled = False
                    grpbx1.Visible = True
                    dtpfromsrch.Focus()

                End If
                ' da.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                CloseConnection()
                Exit Sub
            Finally
                CloseConnection()
            End Try

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        grpbx1.Visible = False
    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click
        'GO BUTTON CLICK

        ds.Clear()
        Try
            da = New OleDbDataAdapter("select SysRefNo,BookingId,CustId,Itina_Type,Bkdate,StDate,EndDate,TAmount,Gross_Amount from Booking_itinary where stdate between  #" & dtpfromsrch.Text & "# and  #" & dtptosrch.Text & "# ", con)


            Openconnection()
            da.Fill(ds, "custvehi")
            If ds.Tables("custvehi").Rows.Count >= 1 Then
                dg1.DataSource = ds.Tables("custvehi")

            Else
                MsgBox("No Record Exists With In The Dates")

                Button2.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
            ' da.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'UPDATE BUTTON CLICK






        Dim i As Integer
        int_passngrs = 0

        Dim str As String
        i = dg1.CurrentRowIndex
        txtitinabookid.Text = dg1.Item(i, 1)
        CUSTID = dg1.Item(i, 2)
        'To fill the combo 
        '
        Openconnection()
        cmd = New OleDbCommand("select fname from cust_master where trim(custid)='" & Trim(CUSTID) & "'", con)
        Try

            txtcustname.Text = cmd.ExecuteScalar

            'dr = cmd.ExecuteScalar
            '    'If dr.Read Then
            '    txtcustname.Text = dr(0)
            '    tariffcode = dr(1)
            '    'End If
            'dr.Close()

            cmd.Dispose()

            '
            'To Fill The ComboBox With The Vehicles he has booked 

            combofill(combovehbookid, "select vbookid from cust_vehicle where trim(custid)='" & Trim(CUSTID) & "'")
            grpbx1.Visible = False
            '
            'To Find The no of passengers travelling
            Openconnection()

            'cmd = New OleDbCommand("select adults,Juniors,childrens,infants  from  booking_itinary  where  BookingId='"  bookid & "'", con)
            cmd = New OleDbCommand("select adults,juniors,childrens,infants from booking_itinary where bookingid='" & bookid & "'", con)


            dr = cmd.ExecuteReader
            If dr.Read Then
                int_passngrs += Val(dr(0))
                int_passngrs += Val(dr(1))
                int_passngrs += Val(dr(2))
            End If
            dr.Close()
            cmd.Dispose()
            txtpassengers.Text = int_passngrs




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally

            CloseConnection()
            combovehbookid.Focus()
        End Try



    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Try
            ds.Clear()

            Openconnection()
            da = New OleDbDataAdapter("select DtyslpNo,DtyslpDt,VBookId,CustId,BookingId,Pax_Nos,Drive,RegNo from veh_dutyslip", con)
            da.Fill(ds, "vehduty")
            dgview.DataSource = ds.Tables("vehduty")
            'ds.Tables("vehduty").Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub



    Private Sub combocountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combocountry.SelectedIndexChanged
        Dim setitem, str As String
        str = combocountry.SelectedItem
        setitem = (str.Substring(0, str.IndexOf("-")))
        combofill1(combocity, "select cityid,city FROM citymaster where trim(countryid)='" & setitem & "'")
    End Sub

    Private Sub combovehtype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combovehtype.SelectedIndexChanged
        'Dim st As String
        'st = combovehtype.SelectedItem
        'combofill(combovehid, "select regno from ownvehiclemaster where vehtypeid='" & st & "')")

    End Sub
    Private Sub combovehbookid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combovehbookid.SelectedIndexChanged
        Openconnection()
        Dim d1, d2, t1, t2 As Date

        Dim intid As Integer
        intid = combovehbookid.SelectedItem
        cmd = New OleDbCommand("select tariffcode from cust_vehicle where vbookid=" & intid & "", con)
        Try
            str_tariffcode = cmd.ExecuteScalar
            txtariffcode.Text = str_tariffcode

            cmd.Dispose()
            cmd = New OleDbCommand("select vehtypeid from veh_tariff where trim(tariffcode)='" & str_tariffcode & "'", con)

            combovehtype.Text = cmd.ExecuteScalar
            'combovehtype.SelectedItem = cmd.ExecuteScalar
            cmd.Dispose()

            cmd = New OleDbCommand("select * from cust_vehicle where vbookid=" & combovehbookid.SelectedItem & "", con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                d1 = FormatDateTime(dr(4), DateFormat.ShortDate)
                t1 = FormatDateTime(dr(5), DateFormat.ShortTime)
                d2 = FormatDateTime(dr(6), DateFormat.ShortDate)
                t2 = FormatDateTime(dr(7), DateFormat.ShortTime)
            End If
            Dim ti, ti2 As Date
            Dim i, kk As Integer
            ti = FormatDateTime(d1, DateFormat.ShortDate) + " " + FormatDateTime(t1, DateFormat.ShortTime)
            ti2 = FormatDateTime(d2, DateFormat.ShortDate) + " " + FormatDateTime(t2, DateFormat.ShortTime)
            i = DateDiff(DateInterval.Hour.Hour, ti, ti2)
            txtduradays.Text = Int(i / 24)
            kk = Int(i / 24) ' to find no of hours
            txtdurahrs.Text = i - (kk * 24)

            dr.Close()
            cmd.Dispose()

            Try
                Dim p, k As Integer
                k = combovehbookid.SelectedItem

                cmd = New OleDbCommand("select tariffcode from cust_vehicle where vbookid=" & k & "", con)

                p = cmd.ExecuteScalar

                combofill(combovehid, "select regno from ownvehiclemaster where trim(vehtypeid)='" & p & "'")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try

    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress, txtguestname.KeyPress, txtdrivername.KeyPress, txtvehid.KeyPress
        textandnumbers(e)
    End Sub


    Private Sub txtmoblie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmoblie.KeyPress, txtphone1.KeyPress, txtoutmileage.KeyPress
        numberonly(e)
    End Sub

    Private Sub combovehbookid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combovehbookid.LostFocus
        combocode.Focus()
    End Sub

    Private Sub combocode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles combocode.LostFocus
        txtaddress.Focus()

    End Sub

    Private Sub combocity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combocity.KeyPress, combocode.KeyPress, combocountry.KeyPress, combodrivername.KeyPress, combotravelsid.KeyPress, combotravelsid.KeyPress, combovehbookid.KeyPress, combovehid.KeyPress, combovehtype.KeyPress

        combo(e)
    End Sub
End Class
