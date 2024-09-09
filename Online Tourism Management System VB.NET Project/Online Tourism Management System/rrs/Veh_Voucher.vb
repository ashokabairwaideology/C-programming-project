'ch.shiva kumar
'3/08/2006
Imports System.Data.OleDb
Public Class Veh_Voucher
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
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tabsafari As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtvouexpences As System.Windows.Forms.TextBox
    Friend WithEvents txtvounoofdays As System.Windows.Forms.TextBox
    Friend WithEvents txtextraperkm As System.Windows.Forms.TextBox
    Friend WithEvents txtextramtrs As System.Windows.Forms.TextBox
    Friend WithEvents txtstndingperdy As System.Windows.Forms.TextBox
    Friend WithEvents txtkilomtrs As System.Windows.Forms.TextBox
    Friend WithEvents txtbasicrate As System.Windows.Forms.TextBox
    Friend WithEvents txtvoutariffcode As System.Windows.Forms.TextBox
    Friend WithEvents txtkilometrs As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofhrs As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofdays As System.Windows.Forms.TextBox
    Friend WithEvents txtgrgooutmeterred As System.Windows.Forms.TextBox
    Friend WithEvents txtdrivernm As System.Windows.Forms.TextBox
    Friend WithEvents txtvehid As System.Windows.Forms.TextBox
    Friend WithEvents txttariffcode As System.Windows.Forms.TextBox
    Friend WithEvents txtfuelamt As System.Windows.Forms.TextBox
    Friend WithEvents txtfuelfilled As System.Windows.Forms.TextBox
    Friend WithEvents txttravelexp As System.Windows.Forms.TextBox
    Friend WithEvents txtvehparlfee As System.Windows.Forms.TextBox
    Friend WithEvents txtclntparkfee As System.Windows.Forms.TextBox
    Friend WithEvents txtotherexp As System.Windows.Forms.TextBox
    Friend WithEvents txtimprestpaid As System.Windows.Forms.TextBox
    Friend WithEvents txtimprestused As System.Windows.Forms.TextBox
    Friend WithEvents txtimprestretired As System.Windows.Forms.TextBox
    Friend WithEvents txtfuelfronttnk As System.Windows.Forms.TextBox
    Friend WithEvents txtfuelreartnk As System.Windows.Forms.TextBox
    Friend WithEvents txtgrageinmetred As System.Windows.Forms.TextBox
    Friend WithEvents dtpcltarrivaltime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpgrgindate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcltexitmeterred As System.Windows.Forms.TextBox
    Friend WithEvents txtcltarrivalmetred As System.Windows.Forms.TextBox
    Friend WithEvents dtpclienexitdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpcltarrivldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtclienname As System.Windows.Forms.TextBox
    Friend WithEvents combousage As System.Windows.Forms.ComboBox
    Friend WithEvents txtdtpslpno As System.Windows.Forms.TextBox
    Friend WithEvents txtbookid As System.Windows.Forms.TextBox
    Friend WithEvents txtpassngrs As System.Windows.Forms.TextBox
    Friend WithEvents dtpslpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpgargintime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttotalvoucheramt As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents dtpsafaritodt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpsafarifromdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsaffuelamt As System.Windows.Forms.TextBox
    Friend WithEvents txtsaffuellts As System.Windows.Forms.TextBox
    Friend WithEvents txtsafkmsin As System.Windows.Forms.TextBox
    Friend WithEvents txtsaftotkms As System.Windows.Forms.TextBox
    Friend WithEvents txtsafkmsout As System.Windows.Forms.TextBox
    Friend WithEvents combosfatrinights As System.Windows.Forms.ComboBox
    Friend WithEvents combosafaridays As System.Windows.Forms.ComboBox
    Friend WithEvents dtpclientexittime As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbogeneral As System.Windows.Forms.RadioButton
    Friend WithEvents rbosafari As System.Windows.Forms.RadioButton
    Friend WithEvents DGVIEW As System.Windows.Forms.DataGrid
    Friend WithEvents dgsafari As System.Windows.Forms.DataGrid
    Friend WithEvents dtpsafdate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tabview = New System.Windows.Forms.TabPage
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.DGVIEW = New System.Windows.Forms.DataGrid
        Me.Tabentry = New System.Windows.Forms.TabPage
        Me.txttotalvoucheramt = New System.Windows.Forms.TextBox
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtvouexpences = New System.Windows.Forms.TextBox
        Me.txtvounoofdays = New System.Windows.Forms.TextBox
        Me.txtextraperkm = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtextramtrs = New System.Windows.Forms.TextBox
        Me.txtstndingperdy = New System.Windows.Forms.TextBox
        Me.txtkilomtrs = New System.Windows.Forms.TextBox
        Me.txtbasicrate = New System.Windows.Forms.TextBox
        Me.txtvoutariffcode = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtkilometrs = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtnoofhrs = New System.Windows.Forms.TextBox
        Me.txtnoofdays = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtgrgooutmeterred = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtdrivernm = New System.Windows.Forms.TextBox
        Me.txtvehid = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txttariffcode = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtfuelamt = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtfuelfilled = New System.Windows.Forms.TextBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txttravelexp = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtvehparlfee = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtclntparkfee = New System.Windows.Forms.TextBox
        Me.txtotherexp = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtimprestpaid = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtimprestused = New System.Windows.Forms.TextBox
        Me.txtimprestretired = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtfuelfronttnk = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtfuelreartnk = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.TextBox34 = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtgrageinmetred = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpcltarrivaltime = New System.Windows.Forms.DateTimePicker
        Me.dtpclientexittime = New System.Windows.Forms.DateTimePicker
        Me.dtpgargintime = New System.Windows.Forms.DateTimePicker
        Me.dtpgrgindate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcltexitmeterred = New System.Windows.Forms.TextBox
        Me.txtcltarrivalmetred = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.dtpclienexitdt = New System.Windows.Forms.DateTimePicker
        Me.dtpcltarrivldate = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtclienname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.combousage = New System.Windows.Forms.ComboBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.rbogeneral = New System.Windows.Forms.RadioButton
        Me.rbosafari = New System.Windows.Forms.RadioButton
        Me.txtdtpslpno = New System.Windows.Forms.TextBox
        Me.txtbookid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtpassngrs = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.dtpslpdate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tabsafari = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dtpsafdate = New System.Windows.Forms.DateTimePicker
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.dtpsafaritodt = New System.Windows.Forms.DateTimePicker
        Me.dtpsafarifromdt = New System.Windows.Forms.DateTimePicker
        Me.Label42 = New System.Windows.Forms.Label
        Me.dgsafari = New System.Windows.Forms.DataGrid
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtsaffuelamt = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtsaffuellts = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtsafkmsin = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtsaftotkms = New System.Windows.Forms.TextBox
        Me.txtsafkmsout = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.combosfatrinights = New System.Windows.Forms.ComboBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.combosafaridays = New System.Windows.Forms.ComboBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.Tabview.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.DGVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabentry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tabsafari.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgsafari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tabview)
        Me.TabControl1.Controls.Add(Me.Tabentry)
        Me.TabControl1.Controls.Add(Me.Tabsafari)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 528)
        Me.TabControl1.TabIndex = 1
        '
        'Tabview
        '
        Me.Tabview.Controls.Add(Me.GroupBox13)
        Me.Tabview.Location = New System.Drawing.Point(4, 22)
        Me.Tabview.Name = "Tabview"
        Me.Tabview.Size = New System.Drawing.Size(656, 502)
        Me.Tabview.TabIndex = 0
        Me.Tabview.Text = "View"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.DGVIEW)
        Me.GroupBox13.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(664, 352)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        '
        'DGVIEW
        '
        Me.DGVIEW.CaptionVisible = False
        Me.DGVIEW.DataMember = ""
        Me.DGVIEW.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVIEW.Location = New System.Drawing.Point(24, 40)
        Me.DGVIEW.Name = "DGVIEW"
        Me.DGVIEW.ReadOnly = True
        Me.DGVIEW.Size = New System.Drawing.Size(576, 280)
        Me.DGVIEW.TabIndex = 0
        '
        'Tabentry
        '
        Me.Tabentry.Controls.Add(Me.txttotalvoucheramt)
        Me.Tabentry.Controls.Add(Me.txtdesc)
        Me.Tabentry.Controls.Add(Me.Label10)
        Me.Tabentry.Controls.Add(Me.Label9)
        Me.Tabentry.Controls.Add(Me.GroupBox2)
        Me.Tabentry.Controls.Add(Me.GroupBox6)
        Me.Tabentry.Controls.Add(Me.GroupBox3)
        Me.Tabentry.Controls.Add(Me.GroupBox7)
        Me.Tabentry.Controls.Add(Me.GroupBox1)
        Me.Tabentry.Location = New System.Drawing.Point(4, 22)
        Me.Tabentry.Name = "Tabentry"
        Me.Tabentry.Size = New System.Drawing.Size(656, 502)
        Me.Tabentry.TabIndex = 1
        Me.Tabentry.Text = "Entry / Edit"
        Me.Tabentry.Visible = False
        '
        'txttotalvoucheramt
        '
        Me.txttotalvoucheramt.BackColor = System.Drawing.Color.Gainsboro
        Me.txttotalvoucheramt.Location = New System.Drawing.Point(568, 472)
        Me.txttotalvoucheramt.Name = "txttotalvoucheramt"
        Me.txttotalvoucheramt.Size = New System.Drawing.Size(80, 21)
        Me.txttotalvoucheramt.TabIndex = 68787
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(104, 464)
        Me.txtdesc.MaxLength = 50
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(344, 32)
        Me.txtdesc.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(456, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Voucher Amount"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 472)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Description"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtvouexpences)
        Me.GroupBox2.Controls.Add(Me.txtvounoofdays)
        Me.GroupBox2.Controls.Add(Me.txtextraperkm)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.txtextramtrs)
        Me.GroupBox2.Controls.Add(Me.txtstndingperdy)
        Me.GroupBox2.Controls.Add(Me.txtkilomtrs)
        Me.GroupBox2.Controls.Add(Me.txtbasicrate)
        Me.GroupBox2.Controls.Add(Me.txtvoutariffcode)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.Label60)
        Me.GroupBox2.Controls.Add(Me.Label59)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 88)
        Me.GroupBox2.TabIndex = 9997
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Voucher Amount"
        '
        'txtvouexpences
        '
        Me.txtvouexpences.BackColor = System.Drawing.Color.Gainsboro
        Me.txtvouexpences.Location = New System.Drawing.Point(512, 64)
        Me.txtvouexpences.Name = "txtvouexpences"
        Me.txtvouexpences.Size = New System.Drawing.Size(72, 21)
        Me.txtvouexpences.TabIndex = 87678
        '
        'txtvounoofdays
        '
        Me.txtvounoofdays.BackColor = System.Drawing.Color.Gainsboro
        Me.txtvounoofdays.Location = New System.Drawing.Point(576, 40)
        Me.txtvounoofdays.Name = "txtvounoofdays"
        Me.txtvounoofdays.Size = New System.Drawing.Size(56, 21)
        Me.txtvounoofdays.TabIndex = 786
        '
        'txtextraperkm
        '
        Me.txtextraperkm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtextraperkm.Location = New System.Drawing.Point(360, 64)
        Me.txtextraperkm.Name = "txtextraperkm"
        Me.txtextraperkm.Size = New System.Drawing.Size(72, 21)
        Me.txtextraperkm.TabIndex = 8767
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(224, 64)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(129, 13)
        Me.Label41.TabIndex = 38
        Me.Label41.Text = "Extra Per Km Charge"
        '
        'txtextramtrs
        '
        Me.txtextramtrs.BackColor = System.Drawing.Color.Gainsboro
        Me.txtextramtrs.Location = New System.Drawing.Point(360, 40)
        Me.txtextramtrs.Name = "txtextramtrs"
        Me.txtextramtrs.Size = New System.Drawing.Size(40, 21)
        Me.txtextramtrs.TabIndex = 876
        '
        'txtstndingperdy
        '
        Me.txtstndingperdy.BackColor = System.Drawing.Color.Gainsboro
        Me.txtstndingperdy.Location = New System.Drawing.Point(576, 17)
        Me.txtstndingperdy.Name = "txtstndingperdy"
        Me.txtstndingperdy.Size = New System.Drawing.Size(56, 21)
        Me.txtstndingperdy.TabIndex = 678
        '
        'txtkilomtrs
        '
        Me.txtkilomtrs.BackColor = System.Drawing.Color.Gainsboro
        Me.txtkilomtrs.Location = New System.Drawing.Point(360, 17)
        Me.txtkilomtrs.Name = "txtkilomtrs"
        Me.txtkilomtrs.Size = New System.Drawing.Size(40, 21)
        Me.txtkilomtrs.TabIndex = 76
        '
        'txtbasicrate
        '
        Me.txtbasicrate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbasicrate.Location = New System.Drawing.Point(216, 17)
        Me.txtbasicrate.Name = "txtbasicrate"
        Me.txtbasicrate.Size = New System.Drawing.Size(64, 21)
        Me.txtbasicrate.TabIndex = 678
        '
        'txtvoutariffcode
        '
        Me.txtvoutariffcode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtvoutariffcode.Location = New System.Drawing.Point(80, 17)
        Me.txtvoutariffcode.Name = "txtvoutariffcode"
        Me.txtvoutariffcode.Size = New System.Drawing.Size(56, 21)
        Me.txtvoutariffcode.TabIndex = 8678
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(504, 40)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(68, 13)
        Me.Label48.TabIndex = 32
        Me.Label48.Text = "No of days"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(440, 64)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(61, 13)
        Me.Label62.TabIndex = 7
        Me.Label62.Text = "Expenses"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(408, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(159, 13)
        Me.Label61.TabIndex = 6
        Me.Label61.Text = "Standing Charges Per Day"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(288, 40)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(58, 13)
        Me.Label60.TabIndex = 5
        Me.Label60.Text = "Extra KM"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(288, 16)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(70, 13)
        Me.Label59.TabIndex = 4
        Me.Label59.Text = "Kilo Meters"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(152, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(67, 13)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Basic Rate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Tariff code"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtkilometrs)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.txtnoofhrs)
        Me.GroupBox6.Controls.Add(Me.txtnoofdays)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtgrgooutmeterred)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.txtdrivernm)
        Me.GroupBox6.Controls.Add(Me.txtvehid)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txttariffcode)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 144)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(656, 72)
        Me.GroupBox6.TabIndex = 8888
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Billing Details"
        '
        'txtkilometrs
        '
        Me.txtkilometrs.BackColor = System.Drawing.Color.Gainsboro
        Me.txtkilometrs.Location = New System.Drawing.Point(568, 40)
        Me.txtkilometrs.Name = "txtkilometrs"
        Me.txtkilometrs.Size = New System.Drawing.Size(80, 21)
        Me.txtkilometrs.TabIndex = 78
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(504, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Kilometers"
        '
        'txtnoofhrs
        '
        Me.txtnoofhrs.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnoofhrs.Location = New System.Drawing.Point(440, 40)
        Me.txtnoofhrs.Name = "txtnoofhrs"
        Me.txtnoofhrs.Size = New System.Drawing.Size(56, 21)
        Me.txtnoofhrs.TabIndex = 786
        '
        'txtnoofdays
        '
        Me.txtnoofdays.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnoofdays.Location = New System.Drawing.Point(272, 40)
        Me.txtnoofdays.Name = "txtnoofdays"
        Me.txtnoofdays.Size = New System.Drawing.Size(72, 21)
        Me.txtnoofdays.TabIndex = 897
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(360, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "No Of Hours"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "No of Days"
        '
        'txtgrgooutmeterred
        '
        Me.txtgrgooutmeterred.BackColor = System.Drawing.Color.Gainsboro
        Me.txtgrgooutmeterred.Location = New System.Drawing.Point(552, 16)
        Me.txtgrgooutmeterred.Name = "txtgrgooutmeterred"
        Me.txtgrgooutmeterred.Size = New System.Drawing.Size(96, 21)
        Me.txtgrgooutmeterred.TabIndex = 89
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(392, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(159, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Garage Out Meter Reading"
        '
        'txtdrivernm
        '
        Me.txtdrivernm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtdrivernm.Location = New System.Drawing.Point(272, 16)
        Me.txtdrivernm.Name = "txtdrivernm"
        Me.txtdrivernm.Size = New System.Drawing.Size(112, 21)
        Me.txtdrivernm.TabIndex = 89
        '
        'txtvehid
        '
        Me.txtvehid.BackColor = System.Drawing.Color.Gainsboro
        Me.txtvehid.Location = New System.Drawing.Point(96, 16)
        Me.txtvehid.Name = "txtvehid"
        Me.txtvehid.Size = New System.Drawing.Size(80, 21)
        Me.txtvehid.TabIndex = 89
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(184, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Driver Name"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Vehicle Id *"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Tariff Code *"
        '
        'txttariffcode
        '
        Me.txttariffcode.BackColor = System.Drawing.Color.Gainsboro
        Me.txttariffcode.Location = New System.Drawing.Point(96, 40)
        Me.txttariffcode.Name = "txttariffcode"
        Me.txttariffcode.Size = New System.Drawing.Size(56, 21)
        Me.txttariffcode.TabIndex = 867
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox11)
        Me.GroupBox3.Controls.Add(Me.GroupBox9)
        Me.GroupBox3.Controls.Add(Me.GroupBox10)
        Me.GroupBox3.Controls.Add(Me.GroupBox12)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.TextBox34)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(656, 152)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label43)
        Me.GroupBox11.Controls.Add(Me.txtfuelamt)
        Me.GroupBox11.Controls.Add(Me.Label40)
        Me.GroupBox11.Controls.Add(Me.txtfuelfilled)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(144, 72)
        Me.GroupBox11.TabIndex = 17
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Fuel Filled In"
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 40)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(56, 16)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "Amount"
        '
        'txtfuelamt
        '
        Me.txtfuelamt.Location = New System.Drawing.Point(72, 40)
        Me.txtfuelamt.MaxLength = 6
        Me.txtfuelamt.Name = "txtfuelamt"
        Me.txtfuelamt.Size = New System.Drawing.Size(64, 21)
        Me.txtfuelamt.TabIndex = 15
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 16)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 13)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Filled Lts"
        '
        'txtfuelfilled
        '
        Me.txtfuelfilled.Location = New System.Drawing.Point(72, 16)
        Me.txtfuelfilled.MaxLength = 3
        Me.txtfuelfilled.Name = "txtfuelfilled"
        Me.txtfuelfilled.Size = New System.Drawing.Size(64, 21)
        Me.txtfuelfilled.TabIndex = 14
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txttravelexp)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Controls.Add(Me.txtvehparlfee)
        Me.GroupBox9.Controls.Add(Me.Label33)
        Me.GroupBox9.Controls.Add(Me.Label34)
        Me.GroupBox9.Controls.Add(Me.txtclntparkfee)
        Me.GroupBox9.Controls.Add(Me.txtotherexp)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(640, 64)
        Me.GroupBox9.TabIndex = 999
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Expenses"
        '
        'txttravelexp
        '
        Me.txttravelexp.Location = New System.Drawing.Point(312, 32)
        Me.txttravelexp.MaxLength = 5
        Me.txttravelexp.Name = "txttravelexp"
        Me.txttravelexp.Size = New System.Drawing.Size(72, 21)
        Me.txttravelexp.TabIndex = 23
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(16, 40)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(286, 13)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Driver/Crew traveling expense /Night allowance "
        '
        'txtvehparlfee
        '
        Me.txtvehparlfee.Location = New System.Drawing.Point(312, 8)
        Me.txtvehparlfee.MaxLength = 4
        Me.txtvehparlfee.Name = "txtvehparlfee"
        Me.txtvehparlfee.Size = New System.Drawing.Size(72, 21)
        Me.txtvehparlfee.TabIndex = 21
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(192, 8)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(110, 13)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = "Vehicle Park fees "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(416, 8)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(102, 13)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Client park fees "
        '
        'txtclntparkfee
        '
        Me.txtclntparkfee.Location = New System.Drawing.Point(528, 8)
        Me.txtclntparkfee.MaxLength = 5
        Me.txtclntparkfee.Name = "txtclntparkfee"
        Me.txtclntparkfee.Size = New System.Drawing.Size(80, 21)
        Me.txtclntparkfee.TabIndex = 22
        '
        'txtotherexp
        '
        Me.txtotherexp.Location = New System.Drawing.Point(528, 32)
        Me.txtotherexp.MaxLength = 5
        Me.txtotherexp.Name = "txtotherexp"
        Me.txtotherexp.Size = New System.Drawing.Size(80, 21)
        Me.txtotherexp.TabIndex = 24
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(424, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(97, 13)
        Me.Label36.TabIndex = 9
        Me.Label36.Text = "Other Expenses"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Controls.Add(Me.txtimprestpaid)
        Me.GroupBox10.Controls.Add(Me.Label45)
        Me.GroupBox10.Controls.Add(Me.txtimprestused)
        Me.GroupBox10.Controls.Add(Me.txtimprestretired)
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Location = New System.Drawing.Point(344, 8)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(304, 72)
        Me.GroupBox10.TabIndex = 14
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Imprest"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Paid"
        '
        'txtimprestpaid
        '
        Me.txtimprestpaid.Location = New System.Drawing.Point(56, 16)
        Me.txtimprestpaid.MaxLength = 5
        Me.txtimprestpaid.Name = "txtimprestpaid"
        Me.txtimprestpaid.Size = New System.Drawing.Size(64, 21)
        Me.txtimprestpaid.TabIndex = 18
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(8, 40)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(35, 13)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "Used"
        '
        'txtimprestused
        '
        Me.txtimprestused.Location = New System.Drawing.Point(56, 40)
        Me.txtimprestused.MaxLength = 5
        Me.txtimprestused.Name = "txtimprestused"
        Me.txtimprestused.Size = New System.Drawing.Size(64, 21)
        Me.txtimprestused.TabIndex = 19
        '
        'txtimprestretired
        '
        Me.txtimprestretired.Location = New System.Drawing.Point(208, 40)
        Me.txtimprestretired.MaxLength = 5
        Me.txtimprestretired.Name = "txtimprestretired"
        Me.txtimprestretired.Size = New System.Drawing.Size(64, 21)
        Me.txtimprestretired.TabIndex = 20
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(136, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 13)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Retired"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label24)
        Me.GroupBox12.Controls.Add(Me.txtfuelfronttnk)
        Me.GroupBox12.Controls.Add(Me.Label25)
        Me.GroupBox12.Controls.Add(Me.txtfuelreartnk)
        Me.GroupBox12.Location = New System.Drawing.Point(168, 8)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(168, 72)
        Me.GroupBox12.TabIndex = 12
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Fuel Balance"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 13)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Front Tank"
        '
        'txtfuelfronttnk
        '
        Me.txtfuelfronttnk.Location = New System.Drawing.Point(80, 16)
        Me.txtfuelfronttnk.MaxLength = 3
        Me.txtfuelfronttnk.Name = "txtfuelfronttnk"
        Me.txtfuelfronttnk.Size = New System.Drawing.Size(64, 21)
        Me.txtfuelfronttnk.TabIndex = 16
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Rear Tank"
        '
        'txtfuelreartnk
        '
        Me.txtfuelreartnk.Location = New System.Drawing.Point(80, 40)
        Me.txtfuelreartnk.MaxLength = 3
        Me.txtfuelreartnk.Name = "txtfuelreartnk"
        Me.txtfuelreartnk.Size = New System.Drawing.Size(64, 21)
        Me.txtfuelreartnk.TabIndex = 17
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(16, 280)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 16)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = "Signature Of Driver"
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(232, 280)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(32, 16)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "Date"
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(288, 280)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(96, 21)
        Me.TextBox34.TabIndex = 7
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtgrageinmetred)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.dtpcltarrivaltime)
        Me.GroupBox7.Controls.Add(Me.dtpclientexittime)
        Me.GroupBox7.Controls.Add(Me.dtpgargintime)
        Me.GroupBox7.Controls.Add(Me.dtpgrgindate)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtcltexitmeterred)
        Me.GroupBox7.Controls.Add(Me.txtcltarrivalmetred)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.dtpclienexitdt)
        Me.GroupBox7.Controls.Add(Me.dtpcltarrivldate)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Location = New System.Drawing.Point(0, 56)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(656, 88)
        Me.GroupBox7.TabIndex = 777
        Me.GroupBox7.TabStop = False
        '
        'txtgrageinmetred
        '
        Me.txtgrageinmetred.Location = New System.Drawing.Point(552, 64)
        Me.txtgrageinmetred.MaxLength = 10
        Me.txtgrageinmetred.Name = "txtgrageinmetred"
        Me.txtgrageinmetred.Size = New System.Drawing.Size(88, 21)
        Me.txtgrageinmetred.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(376, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Garage In Meter Reading"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(240, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Time"
        '
        'dtpcltarrivaltime
        '
        Me.dtpcltarrivaltime.CustomFormat = "HH:mm"
        Me.dtpcltarrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpcltarrivaltime.Location = New System.Drawing.Point(280, 17)
        Me.dtpcltarrivaltime.Name = "dtpcltarrivaltime"
        Me.dtpcltarrivaltime.ShowUpDown = True
        Me.dtpcltarrivaltime.Size = New System.Drawing.Size(80, 21)
        Me.dtpcltarrivaltime.TabIndex = 6
        '
        'dtpclientexittime
        '
        Me.dtpclientexittime.CustomFormat = "HH:mm"
        Me.dtpclientexittime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpclientexittime.Location = New System.Drawing.Point(280, 40)
        Me.dtpclientexittime.Name = "dtpclientexittime"
        Me.dtpclientexittime.ShowUpDown = True
        Me.dtpclientexittime.Size = New System.Drawing.Size(80, 21)
        Me.dtpclientexittime.TabIndex = 9
        '
        'dtpgargintime
        '
        Me.dtpgargintime.CustomFormat = "HH:mm"
        Me.dtpgargintime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpgargintime.Location = New System.Drawing.Point(280, 64)
        Me.dtpgargintime.Name = "dtpgargintime"
        Me.dtpgargintime.ShowUpDown = True
        Me.dtpgargintime.Size = New System.Drawing.Size(80, 21)
        Me.dtpgargintime.TabIndex = 12
        '
        'dtpgrgindate
        '
        Me.dtpgrgindate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpgrgindate.Location = New System.Drawing.Point(136, 64)
        Me.dtpgrgindate.Name = "dtpgrgindate"
        Me.dtpgrgindate.ShowCheckBox = True
        Me.dtpgrgindate.Size = New System.Drawing.Size(96, 21)
        Me.dtpgrgindate.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Garage In Date"
        '
        'txtcltexitmeterred
        '
        Me.txtcltexitmeterred.Location = New System.Drawing.Point(552, 40)
        Me.txtcltexitmeterred.MaxLength = 10
        Me.txtcltexitmeterred.Name = "txtcltexitmeterred"
        Me.txtcltexitmeterred.Size = New System.Drawing.Size(88, 21)
        Me.txtcltexitmeterred.TabIndex = 10
        '
        'txtcltarrivalmetred
        '
        Me.txtcltarrivalmetred.Location = New System.Drawing.Point(552, 16)
        Me.txtcltarrivalmetred.MaxLength = 10
        Me.txtcltarrivalmetred.Name = "txtcltarrivalmetred"
        Me.txtcltarrivalmetred.Size = New System.Drawing.Size(88, 21)
        Me.txtcltarrivalmetred.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(376, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(151, 13)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Client Exit Meter Reading"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(376, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(168, 13)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Client Arrival Meter Reading"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(240, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Time"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(240, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(35, 13)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Time"
        '
        'dtpclienexitdt
        '
        Me.dtpclienexitdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpclienexitdt.Location = New System.Drawing.Point(136, 40)
        Me.dtpclienexitdt.Name = "dtpclienexitdt"
        Me.dtpclienexitdt.ShowCheckBox = True
        Me.dtpclienexitdt.Size = New System.Drawing.Size(96, 21)
        Me.dtpclienexitdt.TabIndex = 8
        '
        'dtpcltarrivldate
        '
        Me.dtpcltarrivldate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcltarrivldate.Location = New System.Drawing.Point(136, 16)
        Me.dtpcltarrivldate.Name = "dtpcltarrivldate"
        Me.dtpcltarrivldate.ShowCheckBox = True
        Me.dtpcltarrivldate.Size = New System.Drawing.Size(96, 21)
        Me.dtpcltarrivldate.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Client Exit Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Client Arrival Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtclienname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.combousage)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.rbogeneral)
        Me.GroupBox1.Controls.Add(Me.rbosafari)
        Me.GroupBox1.Controls.Add(Me.txtdtpslpno)
        Me.GroupBox1.Controls.Add(Me.txtbookid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtpassngrs)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.dtpslpdate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 56)
        Me.GroupBox1.TabIndex = 876
        Me.GroupBox1.TabStop = False
        '
        'txtclienname
        '
        Me.txtclienname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtclienname.Location = New System.Drawing.Point(464, 32)
        Me.txtclienname.Name = "txtclienname"
        Me.txtclienname.Size = New System.Drawing.Size(184, 21)
        Me.txtclienname.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Client Name *"
        '
        'combousage
        '
        Me.combousage.Items.AddRange(New Object() {"pickup ", "drop ", "site seeing"})
        Me.combousage.Location = New System.Drawing.Point(280, 32)
        Me.combousage.Name = "combousage"
        Me.combousage.Size = New System.Drawing.Size(88, 21)
        Me.combousage.TabIndex = 4
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(200, 32)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(42, 13)
        Me.Label58.TabIndex = 4
        Me.Label58.Text = "Usage"
        '
        'rbogeneral
        '
        Me.rbogeneral.Location = New System.Drawing.Point(96, 32)
        Me.rbogeneral.Name = "rbogeneral"
        Me.rbogeneral.Size = New System.Drawing.Size(96, 16)
        Me.rbogeneral.TabIndex = 3
        Me.rbogeneral.Text = "For Generall"
        '
        'rbosafari
        '
        Me.rbosafari.Location = New System.Drawing.Point(11, 32)
        Me.rbosafari.Name = "rbosafari"
        Me.rbosafari.Size = New System.Drawing.Size(88, 16)
        Me.rbosafari.TabIndex = 2
        Me.rbosafari.Text = "For Safari"
        '
        'txtdtpslpno
        '
        Me.txtdtpslpno.Location = New System.Drawing.Point(96, 8)
        Me.txtdtpslpno.MaxLength = 6
        Me.txtdtpslpno.Name = "txtdtpslpno"
        Me.txtdtpslpno.Size = New System.Drawing.Size(88, 21)
        Me.txtdtpslpno.TabIndex = 0
        '
        'txtbookid
        '
        Me.txtbookid.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbookid.Location = New System.Drawing.Point(440, 8)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(72, 21)
        Me.txtbookid.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Booking Id"
        '
        'txtpassngrs
        '
        Me.txtpassngrs.BackColor = System.Drawing.Color.Gainsboro
        Me.txtpassngrs.Location = New System.Drawing.Point(600, 8)
        Me.txtpassngrs.Name = "txtpassngrs"
        Me.txtpassngrs.Size = New System.Drawing.Size(40, 21)
        Me.txtpassngrs.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(528, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 13)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Passengers"
        '
        'dtpslpdate
        '
        Me.dtpslpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpslpdate.Location = New System.Drawing.Point(280, 8)
        Me.dtpslpdate.Name = "dtpslpdate"
        Me.dtpslpdate.ShowCheckBox = True
        Me.dtpslpdate.Size = New System.Drawing.Size(88, 21)
        Me.dtpslpdate.TabIndex = 1
        Me.dtpslpdate.Value = New Date(2006, 8, 3, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Duty Slip Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Duty Slip No *"
        '
        'Tabsafari
        '
        Me.Tabsafari.Controls.Add(Me.GroupBox4)
        Me.Tabsafari.Location = New System.Drawing.Point(4, 22)
        Me.Tabsafari.Name = "Tabsafari"
        Me.Tabsafari.Size = New System.Drawing.Size(656, 502)
        Me.Tabsafari.TabIndex = 2
        Me.Tabsafari.Text = "Safari Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpsafdate)
        Me.GroupBox4.Controls.Add(Me.Label57)
        Me.GroupBox4.Controls.Add(Me.Label44)
        Me.GroupBox4.Controls.Add(Me.dtpsafaritodt)
        Me.GroupBox4.Controls.Add(Me.dtpsafarifromdt)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.dgsafari)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label47)
        Me.GroupBox4.Controls.Add(Me.combosfatrinights)
        Me.GroupBox4.Controls.Add(Me.Label49)
        Me.GroupBox4.Controls.Add(Me.combosafaridays)
        Me.GroupBox4.Controls.Add(Me.Label50)
        Me.GroupBox4.Controls.Add(Me.Label51)
        Me.GroupBox4.Controls.Add(Me.Label52)
        Me.GroupBox4.Controls.Add(Me.Label53)
        Me.GroupBox4.Controls.Add(Me.Label54)
        Me.GroupBox4.Controls.Add(Me.Label55)
        Me.GroupBox4.Controls.Add(Me.Label56)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(656, 416)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'dtpsafdate
        '
        Me.dtpsafdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsafdate.Location = New System.Drawing.Point(16, 168)
        Me.dtpsafdate.Name = "dtpsafdate"
        Me.dtpsafdate.Size = New System.Drawing.Size(96, 21)
        Me.dtpsafdate.TabIndex = 26
        Me.dtpsafdate.Value = New Date(2006, 8, 23, 0, 0, 0, 0)
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(312, 56)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(52, 13)
        Me.Label57.TabIndex = 25
        Me.Label57.Text = "To Date"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(120, 56)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(67, 13)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "From Date"
        '
        'dtpsafaritodt
        '
        Me.dtpsafaritodt.Checked = False
        Me.dtpsafaritodt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsafaritodt.Location = New System.Drawing.Point(368, 56)
        Me.dtpsafaritodt.Name = "dtpsafaritodt"
        Me.dtpsafaritodt.ShowCheckBox = True
        Me.dtpsafaritodt.Size = New System.Drawing.Size(112, 21)
        Me.dtpsafaritodt.TabIndex = 3
        '
        'dtpsafarifromdt
        '
        Me.dtpsafarifromdt.Checked = False
        Me.dtpsafarifromdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsafarifromdt.Location = New System.Drawing.Point(192, 56)
        Me.dtpsafarifromdt.Name = "dtpsafarifromdt"
        Me.dtpsafarifromdt.ShowCheckBox = True
        Me.dtpsafarifromdt.Size = New System.Drawing.Size(112, 21)
        Me.dtpsafarifromdt.TabIndex = 2
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(464, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 16)
        Me.Label42.TabIndex = 21
        Me.Label42.Text = "Km Per Day"
        '
        'dgsafari
        '
        Me.dgsafari.CaptionVisible = False
        Me.dgsafari.DataMember = ""
        Me.dgsafari.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgsafari.Location = New System.Drawing.Point(16, 136)
        Me.dgsafari.Name = "dgsafari"
        Me.dgsafari.Size = New System.Drawing.Size(624, 176)
        Me.dgsafari.TabIndex = 4
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.txtsaffuelamt)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.txtsaffuellts)
        Me.GroupBox8.Location = New System.Drawing.Point(48, 320)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(288, 64)
        Me.GroupBox8.TabIndex = 19
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Fuel Filled In"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(152, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Amount"
        '
        'txtsaffuelamt
        '
        Me.txtsaffuelamt.Location = New System.Drawing.Point(216, 24)
        Me.txtsaffuelamt.Name = "txtsaffuelamt"
        Me.txtsaffuelamt.Size = New System.Drawing.Size(64, 21)
        Me.txtsaffuelamt.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fuel Lts"
        '
        'txtsaffuellts
        '
        Me.txtsaffuellts.Location = New System.Drawing.Point(80, 24)
        Me.txtsaffuellts.Name = "txtsaffuellts"
        Me.txtsaffuellts.Size = New System.Drawing.Size(48, 21)
        Me.txtsaffuellts.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtsafkmsin)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.txtsaftotkms)
        Me.GroupBox5.Controls.Add(Me.txtsafkmsout)
        Me.GroupBox5.Location = New System.Drawing.Point(400, 320)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(208, 72)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kms"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 16)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Out"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(112, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(16, 16)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "In"
        '
        'txtsafkmsin
        '
        Me.txtsafkmsin.Location = New System.Drawing.Point(144, 16)
        Me.txtsafkmsin.Name = "txtsafkmsin"
        Me.txtsafkmsin.Size = New System.Drawing.Size(48, 21)
        Me.txtsafkmsin.TabIndex = 8
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(32, 48)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(56, 16)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Total Kms"
        '
        'txtsaftotkms
        '
        Me.txtsaftotkms.Location = New System.Drawing.Point(112, 48)
        Me.txtsaftotkms.Name = "txtsaftotkms"
        Me.txtsaftotkms.Size = New System.Drawing.Size(88, 21)
        Me.txtsaftotkms.TabIndex = 9
        '
        'txtsafkmsout
        '
        Me.txtsafkmsout.Location = New System.Drawing.Point(48, 16)
        Me.txtsafkmsout.Name = "txtsafkmsout"
        Me.txtsafkmsout.Size = New System.Drawing.Size(48, 21)
        Me.txtsafkmsout.TabIndex = 7
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(16, 80)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(88, 16)
        Me.Label47.TabIndex = 9
        Me.Label47.Text = "Safari Details"
        '
        'combosfatrinights
        '
        Me.combosfatrinights.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", ""})
        Me.combosfatrinights.Location = New System.Drawing.Point(304, 24)
        Me.combosfatrinights.Name = "combosfatrinights"
        Me.combosfatrinights.Size = New System.Drawing.Size(64, 21)
        Me.combosfatrinights.TabIndex = 8
        Me.combosfatrinights.Text = " "
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(168, 24)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(88, 16)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "Safari Duration:"
        '
        'combosafaridays
        '
        Me.combosafaridays.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.combosafaridays.Location = New System.Drawing.Point(400, 24)
        Me.combosafaridays.Name = "combosafaridays"
        Me.combosafaridays.Size = New System.Drawing.Size(72, 21)
        Me.combosafaridays.TabIndex = 1
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(32, 96)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(34, 13)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Date"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(96, 96)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(70, 13)
        Me.Label51.TabIndex = 2
        Me.Label51.Text = "From place"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(192, 96)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(21, 13)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "To"
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(368, 24)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(32, 16)
        Me.Label53.TabIndex = 1
        Me.Label53.Text = "Days"
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(256, 24)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(40, 16)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "Nights"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(248, 96)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(56, 13)
        Me.Label55.TabIndex = 2
        Me.Label55.Text = "KMS Out"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(344, 96)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(48, 13)
        Me.Label56.TabIndex = 2
        Me.Label56.Text = "KMS In"
        '
        'Veh_Voucher
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(666, 527)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Veh_Voucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Voucher"
        Me.TabControl1.ResumeLayout(False)
        Me.Tabview.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.DGVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabentry.ResumeLayout(False)
        Me.Tabentry.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tabsafari.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgsafari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim userid As String
    Dim intcol, introw As Integer
    ' Dim t As New OleDbTransaction
    Dim rakhrs, rakexhrsrt, noofhrs As Integer
    Dim ti, ti2, d1, t1 As Date

    Dim dr As OleDbDataReader
    Dim ds As New DataSet
    Dim dtslpno, vbookid, transid As Integer
    Dim extrshrs As Integer
    Dim t As OleDbTransaction

    Dim custid, custbookid, vehtypeid, regno, safaritype, type, pacid As String

    Dim grgoutdt, grgouttime, dtt As Date
    Dim driveid As Integer

    Dim totamt, vehchrgs, totexpen As Long

    Dim dt As New DataTable
    Dim c1 As New DataColumn("Date")
    Dim c2 As New DataColumn("From Place")
    Dim c3 As New DataColumn("To Place")
    Dim c4 As New DataColumn("KMs Out")
    Dim c5 As New DataColumn("KMs In")
    Dim c6 As New DataColumn("KMs Per Day")
    Dim rec As New EnuRecstatus
    Dim i As Integer

    Public Sub delproc()
        If txtdtpslpno.Text = "" Then
            MsgBox("Enter Duty Slip No")
            txtdtpslpno.Focus()
            Exit Sub
        End If

        If MsgDelAlert() = vbYes Then
            'Openconnection()
            'cmd = New OleDbCommand("update veh_voucher set actflag='N'", con)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            'CloseConnection()
            'MsgDel()

        End If


    End Sub
    Public Sub saveproc()

        If rbogeneral.Checked = True Then
            safaritype = "GENERAL"
        End If
        If rbosafari.Checked = True Then
            safaritype = "SAFARI"
        End If
        Dim type As String  'to store the type wheather it is safari or general

        dtt = Date.Now
        userid = Muserid  'to store the user name

        Dim boli As Boolean = 0
        If txtdtpslpno.Text = "" Then
            MsgBox("Enter Duty Slip No")
            Exit Sub
        End If

        If txtgrageinmetred.Text = "" Then
            MsgBox("Enter Garage In MeterReading")
            Exit Sub
        End If
        If combousage.SelectedItem = "" Then
            MsgBox("Select The Usage ")
            Exit Sub

        End If
        Dim maxno As Long

        If rec = Module1.EnuRecstatus.Recnew Then
            Try
                Dim intstatus As Integer
                Openconnection()
               
                ' To Check Wheather voucher  Already Generate or not for duty slip

                Dim x As Integer
                cmd = New OleDbCommand("select count(*) from veh_voucher where DtyslpNo=" & dtslpno & " and BookingId=" & vbookid & "", con)
                intstatus = cmd.ExecuteNonQuery()

                If intstatus = 0 Then
                    cmd.Dispose()


                    '************To Check The maximum no  In The Datarecord****************


                    cmd = New OleDbCommand("select count(*) from Veh_Voucher ", con)
                    maxno = cmd.ExecuteScalar
                    cmd.Dispose()
                    If maxno = 0 Then
                        maxno = 1
                    Else
                        cmd = New OleDbCommand("select  max(Veh_VouchNo)+1 from veh_voucher ", con)
                        maxno = cmd.ExecuteScalar
                        cmd.Dispose()
                    End If

                    '
                    '*************to insert the record into the veh fuel table************

                    t = con.BeginTransaction

                    cmd = New OleDbCommand("insert into veh_fuel values(" & maxno & "," & txtdtpslpno.Text & ",'" & regno & "','" & IIf(txtfuelfilled.Text = "", " ", txtfuelfilled.Text) & "','" & IIf(txtfuelamt.Text = "", " ", txtfuelamt.Text) & "','" & IIf(txtfuelfronttnk.Text = "", " ", txtfuelfronttnk.Text) & "','" & IIf(txtfuelreartnk.Text = "", " ", txtfuelreartnk.Text) & "')", con)

                    cmd.Transaction = t
                    x = cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    '1st transaction
                    If x = 1 Then



                        '
                        'To insert The Record Into the Veh Expences

                        cmd = New OleDbCommand("insert into veh_expens values(" & maxno & "," & txtdtpslpno.Text & "," & regno & "," & IIf(txtimprestpaid.Text = "", 0, txtimprestpaid.Text) & "," & IIf(txtimprestused.Text = "", 0, txtimprestused.Text) & "," & IIf(txtimprestretired.Text = "", 0, txtimprestused.Text) & "," & IIf(txtvehparlfee.Text = "", 0, txtvehparlfee.Text) & "," & IIf(txtclntparkfee.Text = "", 0, txtclntparkfee.Text) & " ," & IIf(txttravelexp.Text = "", 0, txttravelexp.Text) & "," & IIf(txtotherexp.Text = "", 0, txtotherexp.Text) & "," & totexpen & ")", con)
                        cmd.Transaction = t

                        x = cmd.ExecuteNonQuery
                        cmd.Dispose()
                        '2nd trans
                        If x = 1 Then

                            '
                            'To Update The Garage fuel Meter Reading 
                            cmd = New OleDbCommand("update veh_dutyslip set GaroutMilread=" & txtgrageinmetred.Text & " where DtyslpNo=" & txtdtpslpno.Text & "", con)
                            cmd.Transaction = t
                            x = cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            '3rd trans

                            If x = 1 Then
                                '
                                '***********To Insret to the vehicle voucher database table

                                cmd = New OleDbCommand("insert into veh_voucher values(" & maxno & ",'" & FormatDateTime(dtpslpdate.Text, DateFormat.ShortDate) & "'," & totamt & "," & txtbookid.Text & "," & txtdtpslpno.Text & ",'" & txttariffcode.Text & "','" & safaritype & "','" & combousage.SelectedItem & "','" & FormatDateTime(grgoutdt, DateFormat.ShortDate) & "','" & FormatDateTime(grgouttime, DateFormat.ShortTime) & "'," & txtgrgooutmeterred.Text & ",'" & FormatDateTime(dtpgrgindate.Text, DateFormat.ShortDate) & "','" & FormatDateTime(dtpgargintime.Text, DateFormat.ShortTime) & "'," & txtgrageinmetred.Text & ",'" & dtpcltarrivldate.Text & "','" & FormatDateTime(dtpcltarrivaltime.Text, DateFormat.ShortTime) & "'," & IIf(txtcltarrivalmetred.Text = "", 0, txtcltarrivalmetred.Text) & ",'" & FormatDateTime(dtpclienexitdt.Text, DateFormat.ShortDate) & "','" & FormatDateTime(dtpclientexittime.Text, DateFormat.ShortTime) & "'," & IIf(txtcltexitmeterred.Text = "", 0, txtcltexitmeterred.Text) & "," & totexpen & "," & IIf(txtnoofdays.Text = "", 0, txtnoofdays.Text) & "," & IIf(txtnoofhrs.Text = "", 0, txtnoofhrs.Text) & ",'" & IIf(txtdesc.Text = "", " ", txtdesc.Text) & "','Y','" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "','" & pacid & "')", con)

                                cmd.Transaction = t
                                x = cmd.ExecuteNonQuery()
                                cmd.Dispose()
                                '4rth transid

                                If x = 1 Then
                                    '
                                    ' ************To insert into vehicle amount details**************

                                    'cmd = New OleDbCommand("insert into Veh_VouchAmt values(" & maxno & "," & txtdtpslpno.Text & ",'" & txttariffcode.Text & "'," & txtbasicrate.Text & "," & txtkilometrs.Text& "," &  txtextramtrs.Text "," & txtextraperkm.Text& "," & txtvouexpences.Text & "," & txtnoofdays.Text & "," & txtstndingperdy.Text & "," & txttotalvoucheramt.Text & ",'" & Muserid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "')", con)

                                    cmd = New OleDbCommand("insert into veh_vouchamt values(" & maxno & "," & txtdtpslpno.Text & ",'" & txttariffcode.Text & "'," & IIf(txtbasicrate.Text = "", 0, txtbasicrate.Text) & "," & IIf(txtkilometrs.Text = "", 0, txtkilometrs.Text) & "," & IIf(txtextramtrs.Text = "", 0, txtextramtrs.Text) & "," & IIf(txtextraperkm.Text = "", 0, txtextraperkm.Text) & "," & IIf(txtvouexpences.Text = "", 0, txtvouexpences.Text) & "," & IIf(txtnoofdays.Text = "", 0, txtnoofdays.Text) & "," & IIf(txtstndingperdy.Text = "", 0, txtstndingperdy.Text) & "," & IIf(txttotalvoucheramt.Text = "", 0, txttotalvoucheramt.Text) & ",'" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "')", con)
                                    cmd.Transaction = t
                                    x = cmd.ExecuteNonQuery()
                                    cmd.Dispose()
                                    '
                                    '***********CHECK WEATHER SAFARI SELECTED OR NOT*************
                                    '****IF CHECKED ENETER SAFARI DETAILS************



                                    If safaritype = "SAFARI" Then


                                        If combosafaridays.SelectedItem = "" Then
                                            MsgBox("Select No.Of Days")
                                            Exit Sub
                                        End If
                                        If combosfatrinights.SelectedItem = "" Then
                                            MsgBox("Select No Of Nights")
                                            Exit Sub

                                        End If

                                        '***************To Find The Maximum NUmber*******
                                        '
                                        'Dim cmd1 As OleDbCommand
                                        cmd = New OleDbCommand("select count(*) from Veh_Safari", con)
                                        cmd.Transaction = t
                                        transid = cmd.ExecuteScalar
                                        cmd.Dispose()
                                        If transid = 0 Then
                                            transid = 1
                                        Else
                                            cmd = New OleDbCommand("select max(Tranid)+1 from  Veh_Safari", con)
                                            cmd.Transaction = t
                                            transid = cmd.ExecuteScalar
                                            cmd.Dispose()
                                        End If


                                        cmd = New OleDbCommand("insert into Veh_Safari values(" & transid & "," & maxno & " ,'" & txtbookid.Text & "'," & txtdtpslpno.Text & "," & IIf(combosfatrinights.SelectedItem = "", 0, combosfatrinights.SelectedItem) & "," & IIf(combosafaridays.SelectedItem = "", 0, combosafaridays.SelectedItem) & ",'" & FormatDateTime(dtpsafarifromdt.Text, DateFormat.ShortDate) & "','" & FormatDateTime(dtpsafaritodt.Text, DateFormat.ShortDate) & "'," & IIf(txtsaffuellts.Text = "", 0, txtsaffuellts.Text) & "," & IIf(txtsaffuelamt.Text = "", 0, txtsaffuelamt.Text) & "," & IIf(txtsafkmsout.Text = "", 0, txtsafkmsout.Text) & "," & IIf(txtsafkmsin.Text = "", 0, txtsafkmsin.Text) & ")", con)
                                        cmd.Transaction = t
                                        x = cmd.ExecuteNonQuery()
                                        cmd.Dispose()
                                        '6thttarns

                                        If x = 1 Then


                                            '*************To Find Max no for vehicle safari day wise table*****************

                                            cmd = New OleDbCommand("SELECT COUNT(*) FROM Veh_Saf_Day", con)
                                            cmd.Transaction = t

                                            Dim maxno1 As Integer
                                            maxno1 = cmd.ExecuteScalar
                                            If maxno1 = 0 Then
                                                maxno1 = 1

                                            Else
                                                cmd = New OleDbCommand("select max(Sysrefno)+1 from  Veh_Saf_Day", con)
                                                cmd.Transaction = t
                                                maxno1 = cmd.ExecuteScalar
                                                cmd.Dispose()
                                            End If
                                            '
                                            'Read The contents one by one from  the data grid

                                            For i = 0 To combosafaridays.SelectedItem - 1
                                                maxno1 += 1

                                                cmd = New OleDbCommand("insert into Veh_Saf_Day values(" & maxno1 & "," & transid & ",'" & FormatDateTime(dgsafari.Item(i, 0), DateFormat.ShortDate) & "','" & IIf(dgsafari.Item(i, 1) = "", " ", dgsafari.Item(i, 1)) & "','" & IIf(dgsafari.Item(i, 2) = "", " ", dgsafari.Item(i, 2)) & "'," & IIf(dgsafari.Item(i, 3) = "", 0, dgsafari.Item(i, 3)) & "," & IIf(dgsafari.Item(i, 4) = "", 0, dgsafari.Item(i, 4)) & "," & IIf(dgsafari.Item(i, 5) = "", 0, dgsafari.Item(i, 5)) & ")", con)
                                                cmd.Transaction = t
                                                x = cmd.ExecuteNonQuery()
                                                cmd.Dispose()
                                                '
                                                '
                                                'Set the Custmer Vehicle Duty Slip Flag to Y To Say For Vehicle Voucher Generated
                                                '
                                                cmd = New OleDbCommand("update cust_vehicle set DutySlipFlag='Y'", con)
                                                cmd.ExecuteNonQuery()
                                                cmd.Dispose()

                                                If x = 1 Then

                                                Else
                                                    t.Rollback()
                                                End If
                                                '7th trans id

                                            Next



                                        End If
                                        'if x
                                        ' 6 th trans
                                    End If
                                    'If status


                                Else
                                    t.Rollback()
                                End If
                                '5th trans

                            Else
                                t.Rollback()
                            End If
                            '4rth tarns

                        Else
                            t.Rollback()
                        End If
                        '3rd trans

                    Else
                        t.Rollback()
                    End If
                    '2nd traans

                    t.Commit()
                    MsgSav()
                    '1st trans

                Else
                    MsgBox("Voucher Already Generated")
                    Exit Sub
                End If
                'for status


                clearproc()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                CloseConnection()
            End Try
        End If
        'end if for rec status new


        ' when record in the edit mode

        If rec = Module1.EnuRecstatus.Recedit Then
            ' To Update the vehcile fule record
            Try
                Dim x As Integer
                Openconnection()
                t = con.BeginTransaction


                cmd.Transaction = t

                cmd = New OleDbCommand("update veh_fuel set dtyslpno=" & txtdtpslpno.Text & ",regno=" & regno & ",City_Fuel_Lts =" & txtfuelfilled.Text & ",City_Fuel_Amt = " & txtfuelamt.Text & ", Front_TankBal=" & txtfuelfronttnk.Text & ",Rear_TankBal =" & txtfuelreartnk.Text & " where Veh_VouchNo=" & maxno & "", con)
                x = cmd.ExecuteNonQuery()
                cmd.Dispose()
                If x = 1 Then

                '
                    'tO Update the vehicle expences record

                    cmd = New OleDbCommand("update veh_expens set DtyslpNo= " & txtdtpslpno.Text & ", RegNo= " & regno & ",  Imprest_Paid=" & txtimprestpaid.Text & ",   Imprest_Used= " & txtimprestused.Text & ", Imprest_Retr=" & txtimprestretired.Text & ",  Veh_Parkfees=" & txtvehparlfee.Text & ", Client_Parkfees=" & txtclntparkfee.Text & " ,   Driver_Allowa=" & txttravelexp.Text & ",Other_Expens=" & txtotherexp.Text & ",Tot_Expenses=" & totexpen & " where Veh_VouchNo=" & maxno & "", con)
                    cmd.Transaction = t
                    x = cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    If x = 1 Then


                    '
                        'to upodate the  vehicle garage out time

                        cmd = New OleDbCommand("update veh_dutyslip set GaroutMilread=" & txtgrageinmetred.Text & " where DtyslpNo=" & txtdtpslpno.Text & "", con)
                        cmd.Transaction = t
                        x = cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        If x = 1 Then

                            '
                        'to update the vehicle voucher details

                        'cmd = New OleDbCommand("update veh_voucher set Veh_VouchDt='" & FormatDateTime(dtpslpdate.Text, DateFormat.ShortDate) & "', " & _
                        '" Veh_VouchAmt=" & totamt & ", BookingId=" & txtbookid.Text & ", DtyslpNo=" & txtdtpslpno.Text & ", Tariffcode='" & txttariffcode.Text & "', " & _
                        '" Safari_Gene='" & type & "',  Usage='" & combousage.Text & "',   GaroutDt='" & FormatDateTime(grgoutdt, DateFormat.ShortDate) & "', " & _


                        '"GaroutTime='" & FormatDateTime(grgouttime, DateFormat.ShortTime) & "', GaroutMilRead=" & txtgrgooutmeterred.Text & ", GarinDt='" & FormatDateTime(dtpgrgindate.Text, DateFormat.ShortDate) & "'," & _
                        '"GArinTime='" & FormatDateTime(dtpgargintime.Text, DateFormat.ShortTime) & "',  GarinMilRead=" & txtgrageinmetred.Text & ", Client_ArrDt='" & FormatDateTime(dtpcltarrivldate.Text, DateFormat.ShortDate) & "', " & _
                        '"Client_ArrTime ='" & FormatDateTime(dtpcltarrivaltime.Text, DateFormat.ShortTime) & "',  Client_ArrMilRead=" & IIf(txtcltarrivalmetred.Text = "", 0, txtcltarrivalmetred.Text) & "," & _
                        '"Client_ExtDt='" & FormatDateTime(dtpclienexitdt.Text, DateFormat.ShortDate) & "', Client_ExtTime='" & FormatDateTime(dtpclientexittime.Text, DateFormat.ShortTime) & "'," & _

                        '" Client_ExtMilRead=" & IIf(txtcltexitmeterred.Text = "", 0, txtcltexitmeterred.Text) & ",Tot_Expenses=" & totexpen & ", NoofDays=" & IIf(txtnoofdays.Text = "", 0, txtnoofdays.Text) & "," & _
                        '"NoofHours=" & IIf(txtnoofhrs.Text = "", 0, txtnoofhrs.Text) & ",  Descript='" & IIf(txtdesc.Text = "", " ", txtdesc.Text) & "',Actflag='Y', Userid='" & userid & "', EnteredDt='" & FormatDateTime(dtt, DateFormat.ShortDate) & "' " & _
                        '"where Veh_VouchNo=" & maxno & "", con)
                        Dim strwd As String
                        strwd = Trim(CStr(combousage.SelectedItem))


                        cmd = New OleDbCommand("update veh_voucher set Veh_VouchDt='" & FormatDateTime(dtpslpdate.Text, DateFormat.ShortDate) & "',Veh_VouchAmt=" & totamt & ", BookingId=" & txtbookid.Text & ", DtyslpNo=" & txtdtpslpno.Text & ", Tariffcode='" & txttariffcode.Text & "',Safari_Gene='" & safaritype & "' where Veh_VouchNo=" & maxno & " ", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()




                        cmd = New OleDbCommand("update veh_voucher set  GaroutDt='" & FormatDateTime(grgoutdt, DateFormat.ShortDate) & "',GaroutTime='" & FormatDateTime(grgouttime, DateFormat.ShortTime) & "' where Veh_VouchNo=" & maxno & "", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New OleDbCommand("update veh_voucher set GaroutMilRead=" & txtgrgooutmeterred.Text & ", GarinDt='" & FormatDateTime(dtpgrgindate.Text, DateFormat.ShortDate) & "',GArinTime='" & FormatDateTime(dtpgargintime.Text, DateFormat.ShortTime) & "',  GarinMilRead=" & txtgrageinmetred.Text & ", Client_ArrDt='" & FormatDateTime(dtpcltarrivldate.Text, DateFormat.ShortDate) & "',Client_ExtDt='" & FormatDateTime(dtpclienexitdt.Text, DateFormat.ShortDate) & "', Client_ExtTime='" & FormatDateTime(dtpclientexittime.Text, DateFormat.ShortTime) & "',Client_ExtMilRead=" & IIf(txtcltexitmeterred.Text = "", 0, txtcltexitmeterred.Text) & ",Tot_Expenses=" & totexpen & ", NoofDays=" & IIf(txtnoofdays.Text = "", 0, txtnoofdays.Text) & ",NoofHours=" & IIf(txtnoofhrs.Text = "", 0, txtnoofhrs.Text) & ",  Descript='" & IIf(txtdesc.Text = "", " ", txtdesc.Text) & "',Actflag='Y', Userid='" & userid & "', EnteredDt='" & FormatDateTime(dtt, DateFormat.ShortDate) & "'   where Veh_VouchNo=" & maxno & "", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()


                            cmd = New OleDbCommand("update   Veh_VouchAmt  set DtyslpNo=" & txtdtpslpno.Text & ", Tariffcode='" & txttariffcode.Text & "', Base_Price=" & IIf(txtbasicrate.Text = "", 0, txtbasicrate.Text) & ",   Kilometers=" & IIf(txtkilometrs.Text = "", 0, txtkilometrs.Text) & ", Extr_Km= " & IIf(txtextramtrs.Text = "", 0, txtextramtrs.Text) & ",  Extr_KmCharg=" & IIf(txtextraperkm.Text = "", 0, txtextraperkm.Text) & ",Tot_Expenses=" & IIf(txtvouexpences.Text = "", 0, txtvouexpences.Text) & ", NoofDays=" & IIf(txtnoofdays.Text = "", 0, txtnoofdays.Text) & ", Standing_Char=" & IIf(txtstndingperdy.Text = "", 0, txtstndingperdy.Text) & ", Veh_VouchAmt =" & txttotalvoucheramt.Text & ", Userid ='" & Muserid & "', EnteredDt='" & FormatDateTime(dtt, DateFormat.ShortDate) & "'  where Veh_VouchNo= " & maxno & " ", con)
                            cmd.Transaction = t
                            x = cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            If x = 1 Then



                            '
                            'Check Wheather The Status is same or not

                            If safaritype = "SAFARI" Then 'and type = "SAFARI" Then

                                '
                                'To update the vehicle safari details
                                '
                                Dim maxno1 As Integer

                                    cmd = New OleDbCommand("update  Veh_Safari set  Veh_VouchNo= " & maxno & " ,BookingId='" & txtbookid.Text & "',  DtyslpNo=" & txtdtpslpno.Text & ",   Saf_Nights=" & IIf(combosfatrinights.SelectedItem = "", 0, combosfatrinights.SelectedItem) & ",  Saf_Days=" & IIf(combosafaridays.SelectedItem = "", 0, combosafaridays.SelectedItem) & ",  Saf_StDt='" & dtpsafarifromdt.Text & "', Saf_EndDt='" & dtpsafaritodt.Text & "',  Fuel_Lts=" & IIf(txtsaffuellts.Text = "", 0, txtsaffuellts.Text) & ",  Fuel_Amt=" & IIf(txtsaffuelamt.Text = "", 0, txtsaffuelamt.Text) & ", Kmout=" & IIf(txtsafkmsout.Text = "", 0, txtsafkmsout.Text) & ", Kmin=" & IIf(txtsafkmsin.Text = "", 0, txtsafkmsin.Text) & " where Tranid= " & transid & "  ", con)
                                    cmd.Transaction = t

                                    x = cmd.ExecuteNonQuery()
                                    cmd.Dispose()
                                    If x = 1 Then


                                        '*************To Find Records  for vehicle safari day wise table*****************

                                        cmd = New OleDbCommand("SELECT * FROM Veh_Saf_Day where Tranid =" & transid & "", con)

                                        While dr.Read

                                            maxno1 = CInt(dr(0))
                                            'cmd.Transaction = t1
                                            cmd = New OleDbCommand("update  Veh_Saf_Day set    Tranid=" & transid & ",   Trans_Dt='" & FormatDateTime(dgsafari.Item(i, 0), DateFormat.ShortDate) & "',   FromPlace='" & IIf(dgsafari.Item(i, 1) = "", " ", dgsafari.Item(i, 1)) & "',  ToPlace='" & IIf(dgsafari.Item(i, 2) = "", " ", dgsafari.Item(i, 2)) & "', Kmout=" & IIf(dgsafari.Item(i, 3) = "", 0, dgsafari.Item(i, 3)) & ", Kmin=" & IIf(dgsafari.Item(i, 4) = "", 0, dgsafari.Item(i, 4)) & ",Kmperday=" & IIf(dgsafari.Item(i, 5) = "", 0, dgsafari.Item(i, 5)) & " where Sysrefno= " & maxno1 & "", con)
                                            x = cmd.ExecuteNonQuery()
                                            cmd.Dispose()
                                            If x = 1 Then
                                            Else
                                                t.Rollback()
                                            End If
                                        End While
                                    Else
                                        t.Rollback()
                                    End If

                                Else
                                    t.Rollback()
                                End If

                            Else
                                t.Rollback()
                            End If
                        Else
                            t.Rollback()
                        End If
                    Else
                        t.Rollback()
                    End If
                    '1st
                    t.Commit()
                    MsgSav()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                CloseConnection()
            End Try

        End If
        'end if for reco mode edit
    End Sub

    Public Sub newproc()
        enable()

        rec = Module1.EnuRecstatus.Recnew
    End Sub
    Public Sub clearproc()


        ' txtdtpslpno.Text = ""
        dtpslpdate.Text = ""
        combousage.Text = ""
        dtpclienexitdt.Text = ""
        dtpclientexittime.Text = ""
        dtpcltarrivaltime.Text = ""
        dtpcltarrivldate.Text = ""
        dtpgargintime.Text = ""
        dtpgrgindate.Text = ""
        'txtgrageinmetred.Text = ""
        'txtgrgooutmeterred.Text = ""
        'txtcltarrivalmetred.Text = ""
        'txtcltexitmeterred.Text = ""
        'txtfuelfilled.Text = ""
        'txtfuelamt.Text = ""
        'txtfuelfronttnk.Text = ""
        'txtfuelreartnk.Text = ""
        'txtimprestpaid.Text = ""
        'txtimprestretired.Text = ""
        'txtimprestused.Text = ""
        'txtvehparlfee.Text = ""
        'txtvouexpences.Text = ""
        'txttravelexp.Text = ""
        'txtclntparkfee.Text = ""
        'txtotherexp.Text = ""
        'txtdesc.Text = ""
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox6.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.GroupBox11.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.GroupBox9.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.GroupBox2.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next



    End Sub
    Public Sub disable()
        txtdesc.Enabled = False

        'txtdtpslpno.Enabled = False
        'dtpslpdate.Enabled = False
        'combousage.Enabled = False
        'dtpclienexitdt.Enabled = False
        'dtpclientexittime.Enabled = False
        'dtpcltarrivaltime.Enabled = False
        'dtpcltarrivldate.Enabled = False
        'dtpgargintime.Enabled = False
        'dtpgrgindate.Enabled = False
        'txtgrageinmetred.Enabled = False
        'txtgrgooutmeterred.Enabled = False
        'txtcltarrivalmetred.Enabled = False
        'txtcltexitmeterred.Enabled = False
        'txtfuelfilled.Enabled = False
        'txtfuelamt.Enabled = False
        'txtfuelfronttnk.Enabled = False
        'txtfuelreartnk.Enabled = False
        'txtimprestpaid.Enabled = False
        'txtimprestretired.Enabled = False
        'txtimprestused.Enabled = False
        'txtvehparlfee.Enabled = False
        'txtvouexpences.Enabled = False
        'txttravelexp.Enabled = False
        'txtclntparkfee.Enabled = False
        'txtotherexp.Enabled = False
        GroupBox1.Enabled = False

        GroupBox4.Enabled = False
        ' GroupBox13.Enabled = False
        GroupBox7.Enabled = False
        GroupBox6.Enabled = False
        GroupBox3.Enabled = False
        GroupBox2.Enabled = False
        rbogeneral.Enabled = False
        rbosafari.Enabled = False



    End Sub
    Public Sub enable()
        txtdesc.Enabled = True
        rbogeneral.Enabled = True
        rbosafari.Enabled = True
        GroupBox1.Enabled = True
        GroupBox4.Enabled = True
        GroupBox13.Enabled = True
        GroupBox7.Enabled = True
        GroupBox6.Enabled = True
        GroupBox3.Enabled = True
        GroupBox2.Enabled = True

        'txtdtpslpno.Enabled = True
        'dtpslpdate.Enabled = True
        'combousage.Enabled = True
        'dtpclienexitdt.Enabled = True
        'dtpclientexittime.Enabled = True
        'dtpcltarrivaltime.Enabled = True
        'dtpcltarrivldate.Enabled = True
        'dtpgargintime.Enabled = True
        'dtpgrgindate.Enabled = True
        'txtgrageinmetred.Enabled = True
        'txtgrgooutmeterred.Enabled = True
        'txtcltarrivalmetred.Enabled = True
        'txtcltexitmeterred.Enabled = True
        'txtfuelfilled.Enabled = True
        'txtfuelamt.Enabled = True
        'txtfuelfronttnk.Enabled = True
        'txtfuelreartnk.Enabled = True
        'txtimprestpaid.Enabled = True
        'txtimprestretired.Enabled = True
        'txtimprestused.Enabled = True
        'txtvehparlfee.Enabled = True
        'txtvouexpences.Enabled = True
        'txttravelexp.Enabled = True
        'txtclntparkfee.Enabled = True
        'txtotherexp.Enabled = True
    End Sub
    Public Sub editproc()
        enable()
        txtdtpslpno.Enabled = False

        rec = Module1.EnuRecstatus.Recedit
    End Sub
    Private Sub Veh_Voucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'on page load it displays entry/edit tab page
        TabControl1.SelectedTab = Tabentry

        rbogeneral.Checked = True

        GroupBox4.Enabled = False
        dtpsafdate.Visible = False

        dt.Columns.Add(c1)
        dt.Columns.Add(c2)
        dt.Columns.Add(c3)
        dt.Columns.Add(c4)
        dt.Columns.Add(c5)
        dt.Columns.Add(c6)
        dgsafari.DataSource = dt

        disable()
    End Sub
    Private Sub txtdtpslpno_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdtpslpno.Validated
        Openconnection()

        Dim intp As Integer
        If txtdtpslpno.Text = "" Then
            MsgBox("Enter Duty Slip No")
        Else
            dtslpno = txtdtpslpno.Text
            cmd = New OleDbCommand("select count(*) from veh_dutyslip where dtyslpno=" & dtslpno & "", con)
            intp = cmd.ExecuteScalar
            If intp = 0 Then
                MsgBox("No Record Exists")
            Else

                dtslpno = Val(txtdtpslpno.Text)

                '
                'To Fetch The RTecord from the veh_duty slip tablke
                '
                Dim drvnmid As String



                cmd = New OleDbCommand("select * from veh_dutyslip where dtyslpno=" & dtslpno & "", con)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    dtpslpdate.Text = dr(1)
                    txtbookid.Text = dr(2)
                    custid = dr(3)
                    custbookid = dr(4)
                    'd1 = dr(20)
                    'd2 = dr(22)
                    't1 = dr(21)
                    't2 = dr(23)
                    vbookid = dr(2)
                    txttariffcode.Text = dr(7)
                    txtvoutariffcode.Text = dr(7)
                    safaritype = dr(6)
                    vehtypeid = dr(8)
                    drvnmid = dr(12)
                    regno = dr(11)
                    grgoutdt = dr(24)
                    grgouttime = dr(25)
                    txtgrgooutmeterred.Text = dr(26)
                    txtvehid.Text = CStr(dr(11))

                    driveid = CStr(dr(12))

                    txtpassngrs.Text = dr(5)
                End If
                dr.Close()
                cmd.Dispose()
                If safaritype = "GENERAL" Then
                    rbogeneral.Checked = True
                End If
                If safaritype = "SAFARI" Then
                    rbosafari.Checked = True
                End If

                cmd = New OleDbCommand("select fname from cust_master where trim(custid)='" & custid & "'", con)
                txtclienname.Text = cmd.ExecuteScalar
                cmd.Dispose()
                cmd = New OleDbCommand("SELECT firstname from employeemaster where employeeid='" & driveid & "'", con)
                txtdrivernm.Text = cmd.ExecuteScalar
                cmd.Dispose()
                cmd = New OleDbCommand("select * from Veh_Tariff where trim(tariffcode)='" & txttariffcode.Text & "'", con)
                Try
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        txttariffcode.Text = dr(0)
                        txtbasicrate.Text = dr(5)
                        'txtkilometrs.Text = dr(6)
                        txtkilomtrs.Text = dr(6)
                        txtextraperkm.Text = dr(8)
                        txtstndingperdy.Text = dr(9)
                        rakhrs = dr(7)
                        rakexhrsrt = dr(10)

                    End If
                    dr.Close()
                    cmd.Dispose()
                    CloseConnection()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

                Openconnection()
                cmd = New OleDbCommand("select * from cust_vehicle where vbookid=" & vbookid & "", con)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    txtnoofdays.Text = dr(8)
                    d1 = dr(4)
                    t1 = dr(5)
                    pacid = dr(17)
                End If
                Dim i, k, l As Integer
                dr.Close()
                CloseConnection()
                Dim kk As Integer



                

               
                ' txtnoofhrs.Text=i % 24
                'txtkilometrs.Text=
                End If
        End If

    End Sub

    Private Sub txtgrageinmetred_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgrageinmetred.Validated
        If Val(txtgrageinmetred.Text) > Val(txtgrgooutmeterred.Text) Then
            Dim amt As Long
            Dim kilomr As Long

            txtkilometrs.Text = Val(txtgrageinmetred.Text) - Val(txtgrgooutmeterred.Text)



            '
            '**********To Calculate the Total amt for no of kilometers travelled
            '
           
            'To Find the 
            Dim grgintime, grgindt As Date

            grgindt = FormatDateTime(dtpgrgindate.Text, DateFormat.ShortDate)

            grgintime = FormatDateTime(dtpgargintime.Text, DateFormat.ShortTime)

            Dim kk, i As Integer
            ti = FormatDateTime(d1, DateFormat.ShortDate) + " " + FormatDateTime(t1, DateFormat.ShortTime)

            ti2 = FormatDateTime(grgindt, DateFormat.ShortDate) + " " + FormatDateTime(grgintime, DateFormat.ShortTime)

            i = DateDiff(DateInterval.Hour.Hour, ti, ti2)

            txtnoofdays.Text = Int(i / 24)

            txtvounoofdays.Text = Int(i / 24) 'To FInd No Of Days

            kk = Int(i / 24) ' to find no of hours

            txtnoofhrs.Text = i - (kk * 24)
            noofhrs = i - (kk * 24)

            If noofhrs > rakhrs Then
                extrshrs = noofhrs - rakhrs
                txttotalvoucheramt.Text = Val(extrshrs * rakexhrsrt)


            End If

            kilomr = Val(txtkilometrs.Text)
            kilomr = kilomr - Val(txtkilomtrs.Text)
            If kilomr < 0 Then
                txtextramtrs.Text = 0
                vehchrgs = Val(txtbasicrate.Text)
                txttotalvoucheramt.Text += vehchrgs

                vehchrgs += Val(txtstndingperdy.Text) * Val(txtnoofdays.Text)
                txttotalvoucheramt.Text += vehchrgs


            Else
                txtextramtrs.Text = kilomr
                vehchrgs = Val(txtbasicrate.Text)
                vehchrgs += (kilomr * Val(txtextraperkm.Text))

            End If

        Else
            MsgBox("Garage In Meter Reading Should Be Grater Than Out")
            Exit Sub
        End If
    End Sub

    Private Sub txtvehparlfee_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvehparlfee.Validated


        totexpen = Val(txtclntparkfee.Text) + Val(txttravelexp.Text) + Val(txtotherexp.Text) + Val(txtotherexp.Text)
        totamt = totexpen + vehchrgs

        txttotalvoucheramt.Text = totamt
        txtvouexpences.Text = totexpen


    End Sub

    Private Sub txtclntparkfee_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtclntparkfee.Validated


        totexpen = Val(txtclntparkfee.Text) + Val(txttravelexp.Text) + Val(txtotherexp.Text) + Val(txtotherexp.Text)

        txttotalvoucheramt.Text = totamt
        txtvouexpences.Text = totexpen
        totamt = totexpen + vehchrgs
    End Sub

    Private Sub txttravelexp_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttravelexp.Validated
        totexpen = Val(txtclntparkfee.Text) + Val(txttravelexp.Text) + Val(txtotherexp.Text) + Val(txtotherexp.Text)
        totamt = totexpen + vehchrgs
        txttotalvoucheramt.Text = totamt
        txtvouexpences.Text = totexpen

    End Sub

    Private Sub txtotherexp_TextAlignChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtotherexp.Validated


        totexpen = Val(txtclntparkfee.Text) + Val(txttravelexp.Text) + Val(txtotherexp.Text) + Val(txtotherexp.Text)
        totamt = totexpen + vehchrgs
        txttotalvoucheramt.Text = totamt
        txtvouexpences.Text = totexpen

    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedTab.Text = "View" Then
            DGVIEW.TabIndex = 0

            ds.Clear()
            da = New OleDbDataAdapter("select * from veh_voucher where actflag='Y'", con)
            da.Fill(ds, "veh_vou")
            DGVIEW.DataSource = ds.Tables("veh_vou")

        End If
        If TabControl1.SelectedTab.Text = "Safari Details" Then
            combosfatrinights.TabIndex = 0
            If rbosafari.Checked = True Then
                GroupBox4.Enabled = True
            Else
                GroupBox4.Enabled = False
            End If
        End If
    End Sub
    '
    '***************To Set the No of Rows ini datagrid
    '

    Private Sub combosafaridays_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combosafaridays.SelectedIndexChanged
        dt.Rows.Clear()
        Dim days, i As Integer
        days = combosafaridays.SelectedItem

        For i = 0 To days - 1
            Dim dr As DataRow
            dr = dt.NewRow
            dr.Item(0) = ""
            dr.Item(1) = ""
            dr.Item(2) = ""
            dr.Item(3) = ""
            dr.Item(4) = ""
            dr.Item(5) = ""
            dt.Rows.Add(dr)
        Next
    End Sub

    Private Sub dgsafari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsafari.Click, dgsafari.CurrentCellChanged


        intcol = dgsafari.CurrentCell.ColumnNumber
        introw = dgsafari.CurrentCell.RowNumber

        If intcol = 0 Then
            dtpsafdate.Visible = True
            dtpsafdate.Left = dgsafari.Left + dgsafari.GetCurrentCellBounds.Left
            dtpsafdate.Top = dgsafari.Top + dgsafari.GetCurrentCellBounds.Top

            dtpsafdate.Width = dgsafari.GetCurrentCellBounds.Width
            dtpsafdate.Height = dgsafari.GetCurrentCellBounds.Height
        End If
    End Sub

    Private Sub dtpsafdate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpsafdate.TextChanged

        dtpsafdate.Visible = False
        dgsafari.Item(introw, intcol) = dtpsafdate.Text

    End Sub

    Private Sub DGVIEW_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVIEW.DoubleClick
        Dim vouno As Integer
        Dim introw1 As Integer
        introw1 = DGVIEW.CurrentRowIndex
        Openconnection()
        cmd = New OleDbCommand("select * from veh_voucher where Veh_VouchNo=" & DGVIEW.Item(introw1, 0) & " ", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            safaritype = Trim(dr(6))
            vouno = dr(0)
            txtdtpslpno.Text = dr(4)
            dtslpno = dr(4)
            txtbookid.Text = dr(3)
            custbookid = dr(3)
            txttariffcode.Text = CStr(dr(5))
            combousage.SelectedItem = CStr(dr(7))
            txtgrgooutmeterred.Text = CInt(dr(10))
            dtpgrgindate.Text = FormatDateTime(dr(11), DateFormat.ShortDate)
            dtpgargintime.Text = FormatDateTime(dr(12), DateFormat.ShortTime)
            txtgrageinmetred.Text = CInt(dr(13))
            dtpcltarrivldate.Text = FormatDateTime(dr(14), DateFormat.ShortDate)
            dtpcltarrivaltime.Text = FormatDateTime(dr(15), DateFormat.ShortTime)
            txtcltarrivalmetred.Text = CInt(dr(16))
            dtpclienexitdt.Text = FormatDateTime(dr(17), DateFormat.ShortDate)
            dtpclientexittime.Text = FormatDateTime(dr(18), DateFormat.ShortTime)
            txtcltexitmeterred.Text = CInt(dr(19))
            txttotalvoucheramt.Text = dr(2)
            txtnoofdays.Text = CInt(dr(21))
            txtnoofhrs.Text = CInt(dr(22))
        End If
        dr.Close()
        cmd.Dispose()
        cmd = New OleDbCommand("select * from veh_dutyslip where dtyslpno=" & dtslpno & "", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            dtpslpdate.Text = FormatDateTime(dr(1), DateFormat.ShortDate)
            txtbookid.Text = dr(2)
            custid = dr(3)
            custbookid = dr(4)
            'd1 = dr(20)
            'd2 = dr(22)
            't1 = dr(21)
            't2 = dr(23)
            vbookid = dr(2)
            txttariffcode.Text = CStr(dr(7))
            txtvoutariffcode.Text = CStr(dr(7))

            vehtypeid = dr(8)
            'drvnmid = dr(12)
            regno = dr(11)
            grgoutdt = FormatDateTime(dr(24), DateFormat.ShortDate)
            grgouttime = FormatDateTime(dr(25), DateFormat.ShortDate)
            txtgrgooutmeterred.Text = CInt(dr(26))
            txtvehid.Text = dr(11)
            driveid = dr(12)
            txtpassngrs.Text = CInt(dr(5))

        End If
        dr.Close()
        cmd.Dispose()

        cmd = New OleDbCommand("select fname from cust_master where trim(custid)='" & custid & "'", con)
        txtclienname.Text = cmd.ExecuteScalar
        cmd.Dispose()

        cmd = New OleDbCommand("SELECT firstname from employeemaster where employeeid='" & driveid & "'", con)

        txtdrivernm.Text = cmd.ExecuteScalar
        cmd.Dispose()




        cmd = New OleDbCommand("select * from Veh_Tariff where trim(tariffcode)='" & Trim(txttariffcode.Text) & "'", con)
        Try
            dr = cmd.ExecuteReader
            If dr.Read Then
                txttariffcode.Text = Trim(dr(0))
                txtbasicrate.Text = dr(5)
                txtkilometrs.Text = dr(6)
                txtkilomtrs.Text = dr(6)
                txtextraperkm.Text = dr(8)

                txtstndingperdy.Text = dr(9)
            End If
            dr.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        cmd = New OleDbCommand("select * from cust_vehicle where vbookid=" & vbookid & "", con)
        dr = cmd.ExecuteReader

        Dim d1, t1, d2, t2, ti, ti2 As Date

        If dr.Read Then
            pacid = dr(17)
            txtnoofdays.Text = dr(8)
            d1 = dr(4)
            t1 = dr(5)
            d2 = dr(6)
            t2 = dr(7)
        End If
        Dim i, k, l As Integer
        cmd.Dispose()

        dr.Close()

        Dim kk As Integer

        ti = FormatDateTime(d1, DateFormat.ShortDate) + " " + FormatDateTime(t1, DateFormat.ShortTime)
        ti2 = FormatDateTime(d2, DateFormat.ShortDate) + " " + FormatDateTime(t2, DateFormat.ShortTime)
        i = DateDiff(DateInterval.Hour.Hour, ti, ti2)
        txtnoofdays.Text = Int(i / 24)
        txtvounoofdays.Text = Int(i / 24)
        kk = Int(i / 24) ' to find no of hours
        txtnoofhrs.Text = i - (kk * 24)

        '
        'get THe data from the vehicle _expences table

        cmd = New OleDbCommand("select * from Veh_Expens where Veh_VouchNo=" & vouno & "", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txtimprestpaid.Text = dr(2)
            txtimprestused.Text = dr(3)
            txtimprestretired.Text = dr(4)
            txtvehparlfee.Text = dr(5)
            txtclntparkfee.Text = dr(6)
            txttravelexp.Text = dr(7)
            txtotherexp.Text = dr(8)
            txtvouexpences.Text = dr(9)
        End If
        dr.Close()
        cmd.Dispose()
        '
        'Get the data from the vehicle fuel table
        cmd = New OleDbCommand("select * from veh_fuel where Veh_VouchNo=" & vouno & "", con)
        dr = cmd.ExecuteReader
        If dr.Read Then

            txtfuelamt.Text = dr(4)
            txtfuelfilled.Text = dr(3)
            txtfuelfronttnk.Text = dr(5)
            txtfuelreartnk.Text = dr(6)
        End If
        dr.Close()
        cmd.Dispose()
        ''
        '****GEt the contents of safari if it is type if safari
        If safaritype = "SAFARI" Then
            rbosafari.Checked = True


            cmd = New OleDbCommand("select * from veh_safari where Veh_VouchNo=" & vouno & "", con)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                transid = dr(0)

                combosafaridays.SelectedItem = dr(5)
                combosfatrinights.SelectedItem = dr(4)
                combosafaridays.Text = dr(4)
                combosfatrinights.Text = dr(5)
                dtpsafarifromdt.Text = dr(6)
                dtpsafaritodt.Text = dr(7)
                txtsaffuellts.Text = dr(8)
                txtsaffuelamt.Text = dr(9)
                txtsafkmsout.Text = dr(10)
                txtsafkmsin.Text = dr(11)
            End If
            cmd.Dispose()
            dr.Close()

            da = New OleDbDataAdapter("select Trans_Dt,FromPlace,ToPlace,Kmout,Kmin,Kmperday from Veh_Saf_Day where tranid=" & transid & "", con)

            ds.Clear()
            da.Fill(ds, "vehsafdaywise")
            dgsafari.DataSource = ds.Tables("vehsafdaywise")
            dr.Close()
            CloseConnection()


        End If
        disable()
        TabControl1.SelectedTab = Tabentry

    End Sub

    Private Sub txtdtpslpno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdtpslpno.KeyPress, txtgrgooutmeterred.KeyPress, txtgrageinmetred.KeyPress, txtfuelamt.KeyPress, txtbasicrate.KeyPress, txtfuelfilled.KeyPress, txtfuelfronttnk.KeyPress, txtfuelfronttnk.KeyPress, txtfuelreartnk.KeyPress, txtimprestpaid.KeyPress, txtimprestretired.KeyPress, txtimprestused.KeyPress, txtcltarrivalmetred.KeyPress, txtcltexitmeterred.KeyPress, txtvehparlfee.KeyPress, txtclntparkfee.KeyPress, txttravelexp.KeyPress, txtotherexp.KeyPress
        numberonly(e)
    End Sub

    Private Sub combosafaridays_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combosafaridays.KeyPress, combosfatrinights.KeyPress, combousage.KeyPress
        combo(e)
    End Sub
End Class
