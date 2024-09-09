'Staretd on 18-july-2006
'Anil.N

Imports System.Data.OleDb
Public Class Veh_Tariff
    Inherits System.Windows.Forms.Form
    Dim cmd, cmd1, cmd2, cmd3, cmd4, cmd5 As New OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim str_rab, str_rad1 As String
    Dim da, dt As Date
    Dim recmode As EnuRecstatus
    Dim number As Integer = 0

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Rad_hired As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_own As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_chuffeur As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_self As System.Windows.Forms.RadioButton
    Friend WithEvents txt_tarcode As System.Windows.Forms.TextBox
    Friend WithEvents cob_vt As System.Windows.Forms.ComboBox
    Friend WithEvents cob_travelspartyid As System.Windows.Forms.ComboBox
    Friend WithEvents grb_vehicle As System.Windows.Forms.GroupBox
    Friend WithEvents Dbg_vehicletariff As System.Windows.Forms.DataGrid
    Friend WithEvents Tbc_vehicletariff As System.Windows.Forms.TabControl
    Friend WithEvents Tabview As System.Windows.Forms.TabPage
    Friend WithEvents Tabentry As System.Windows.Forms.TabPage
    Friend WithEvents cob_vt1 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_km As System.Windows.Forms.TextBox
    Friend WithEvents txt_hours As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txt_baseprice As System.Windows.Forms.TextBox
    Friend WithEvents txt_charges As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_extrakm As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grb_ct As System.Windows.Forms.GroupBox
    Friend WithEvents grb_rt As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ehr As System.Windows.Forms.TextBox
    Friend WithEvents txt_ehrct As System.Windows.Forms.TextBox
    Friend WithEvents txt_scpdct As System.Windows.Forms.TextBox
    Friend WithEvents txt_ekmct As System.Windows.Forms.TextBox
    Friend WithEvents txt_kmct As System.Windows.Forms.TextBox
    Friend WithEvents txt_hct As System.Windows.Forms.TextBox
    Friend WithEvents txt_bpct As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Veh_Tariff))
        Me.Tbc_vehicletariff = New System.Windows.Forms.TabControl
        Me.Tabview = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cob_vt1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Dbg_vehicletariff = New System.Windows.Forms.DataGrid
        Me.Tabentry = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.grb_ct = New System.Windows.Forms.GroupBox
        Me.txt_ehrct = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_scpdct = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_ekmct = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_kmct = New System.Windows.Forms.TextBox
        Me.txt_hct = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_bpct = New System.Windows.Forms.TextBox
        Me.grb_rt = New System.Windows.Forms.GroupBox
        Me.txt_ehr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_charges = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_extrakm = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_km = New System.Windows.Forms.TextBox
        Me.txt_hours = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txt_baseprice = New System.Windows.Forms.TextBox
        Me.cob_travelspartyid = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grb_vehicle = New System.Windows.Forms.GroupBox
        Me.Rad_hired = New System.Windows.Forms.RadioButton
        Me.Rad_own = New System.Windows.Forms.RadioButton
        Me.Rad_chuffeur = New System.Windows.Forms.RadioButton
        Me.Rad_self = New System.Windows.Forms.RadioButton
        Me.cob_vt = New System.Windows.Forms.ComboBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txt_tarcode = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Tbc_vehicletariff.SuspendLayout()
        Me.Tabview.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dbg_vehicletariff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabentry.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grb_ct.SuspendLayout()
        Me.grb_rt.SuspendLayout()
        Me.grb_vehicle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tbc_vehicletariff
        '
        Me.Tbc_vehicletariff.Controls.Add(Me.Tabview)
        Me.Tbc_vehicletariff.Controls.Add(Me.Tabentry)
        Me.Tbc_vehicletariff.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbc_vehicletariff.Location = New System.Drawing.Point(0, 0)
        Me.Tbc_vehicletariff.Name = "Tbc_vehicletariff"
        Me.Tbc_vehicletariff.SelectedIndex = 0
        Me.Tbc_vehicletariff.Size = New System.Drawing.Size(496, 368)
        Me.Tbc_vehicletariff.TabIndex = 2
        '
        'Tabview
        '
        Me.Tabview.Controls.Add(Me.GroupBox2)
        Me.Tabview.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabview.Location = New System.Drawing.Point(4, 22)
        Me.Tabview.Name = "Tabview"
        Me.Tabview.Size = New System.Drawing.Size(488, 342)
        Me.Tabview.TabIndex = 0
        Me.Tabview.Text = "View"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cob_vt1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Dbg_vehicletariff)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 336)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cob_vt1
        '
        Me.cob_vt1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_vt1.Location = New System.Drawing.Point(232, 16)
        Me.cob_vt1.Name = "cob_vt1"
        Me.cob_vt1.Size = New System.Drawing.Size(152, 21)
        Me.cob_vt1.TabIndex = 2
        Me.cob_vt1.Text = "Select Vehicle Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Vehicle Type"
        '
        'Dbg_vehicletariff
        '
        Me.Dbg_vehicletariff.DataMember = ""
        Me.Dbg_vehicletariff.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dbg_vehicletariff.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dbg_vehicletariff.Location = New System.Drawing.Point(16, 48)
        Me.Dbg_vehicletariff.Name = "Dbg_vehicletariff"
        Me.Dbg_vehicletariff.ReadOnly = True
        Me.Dbg_vehicletariff.Size = New System.Drawing.Size(464, 280)
        Me.Dbg_vehicletariff.TabIndex = 0
        '
        'Tabentry
        '
        Me.Tabentry.Controls.Add(Me.GroupBox4)
        Me.Tabentry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabentry.Location = New System.Drawing.Point(4, 22)
        Me.Tabentry.Name = "Tabentry"
        Me.Tabentry.Size = New System.Drawing.Size(488, 342)
        Me.Tabentry.TabIndex = 1
        Me.Tabentry.Text = "Entry/Edit"
        Me.Tabentry.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grb_ct)
        Me.GroupBox4.Controls.Add(Me.grb_rt)
        Me.GroupBox4.Controls.Add(Me.cob_travelspartyid)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.grb_vehicle)
        Me.GroupBox4.Controls.Add(Me.Rad_chuffeur)
        Me.GroupBox4.Controls.Add(Me.Rad_self)
        Me.GroupBox4.Controls.Add(Me.cob_vt)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.txt_tarcode)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 336)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'grb_ct
        '
        Me.grb_ct.Controls.Add(Me.txt_ehrct)
        Me.grb_ct.Controls.Add(Me.Label5)
        Me.grb_ct.Controls.Add(Me.txt_scpdct)
        Me.grb_ct.Controls.Add(Me.Label6)
        Me.grb_ct.Controls.Add(Me.txt_ekmct)
        Me.grb_ct.Controls.Add(Me.Label7)
        Me.grb_ct.Controls.Add(Me.txt_kmct)
        Me.grb_ct.Controls.Add(Me.txt_hct)
        Me.grb_ct.Controls.Add(Me.Label8)
        Me.grb_ct.Controls.Add(Me.Label9)
        Me.grb_ct.Controls.Add(Me.Label10)
        Me.grb_ct.Controls.Add(Me.txt_bpct)
        Me.grb_ct.Location = New System.Drawing.Point(240, 120)
        Me.grb_ct.Name = "grb_ct"
        Me.grb_ct.Size = New System.Drawing.Size(248, 216)
        Me.grb_ct.TabIndex = 45
        Me.grb_ct.TabStop = False
        Me.grb_ct.Text = "Corporate Tariff"
        '
        'txt_ehrct
        '
        Me.txt_ehrct.Location = New System.Drawing.Point(144, 144)
        Me.txt_ehrct.Name = "txt_ehrct"
        Me.txt_ehrct.Size = New System.Drawing.Size(72, 21)
        Me.txt_ehrct.TabIndex = 49
        Me.txt_ehrct.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Extra Hour Rate *"
        '
        'txt_scpdct
        '
        Me.txt_scpdct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_scpdct.Location = New System.Drawing.Point(144, 176)
        Me.txt_scpdct.Name = "txt_scpdct"
        Me.txt_scpdct.Size = New System.Drawing.Size(72, 21)
        Me.txt_scpdct.TabIndex = 50
        Me.txt_scpdct.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 31)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Standing Charges Per Day"
        '
        'txt_ekmct
        '
        Me.txt_ekmct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ekmct.Location = New System.Drawing.Point(144, 112)
        Me.txt_ekmct.Name = "txt_ekmct"
        Me.txt_ekmct.Size = New System.Drawing.Size(72, 21)
        Me.txt_ekmct.TabIndex = 48
        Me.txt_ekmct.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Extra k.M Rate *"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_kmct
        '
        Me.txt_kmct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kmct.Location = New System.Drawing.Point(144, 48)
        Me.txt_kmct.Name = "txt_kmct"
        Me.txt_kmct.Size = New System.Drawing.Size(96, 21)
        Me.txt_kmct.TabIndex = 46
        Me.txt_kmct.Text = ""
        '
        'txt_hct
        '
        Me.txt_hct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hct.Location = New System.Drawing.Point(144, 80)
        Me.txt_hct.Name = "txt_hct"
        Me.txt_hct.Size = New System.Drawing.Size(96, 21)
        Me.txt_hct.TabIndex = 47
        Me.txt_hct.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Hours *"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Base Price *"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "K.M's *"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_bpct
        '
        Me.txt_bpct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bpct.Location = New System.Drawing.Point(144, 19)
        Me.txt_bpct.Name = "txt_bpct"
        Me.txt_bpct.Size = New System.Drawing.Size(96, 21)
        Me.txt_bpct.TabIndex = 45
        Me.txt_bpct.Text = ""
        '
        'grb_rt
        '
        Me.grb_rt.Controls.Add(Me.txt_ehr)
        Me.grb_rt.Controls.Add(Me.Label1)
        Me.grb_rt.Controls.Add(Me.txt_charges)
        Me.grb_rt.Controls.Add(Me.Label2)
        Me.grb_rt.Controls.Add(Me.txt_extrakm)
        Me.grb_rt.Controls.Add(Me.Label28)
        Me.grb_rt.Controls.Add(Me.txt_km)
        Me.grb_rt.Controls.Add(Me.txt_hours)
        Me.grb_rt.Controls.Add(Me.Label29)
        Me.grb_rt.Controls.Add(Me.Label30)
        Me.grb_rt.Controls.Add(Me.Label31)
        Me.grb_rt.Controls.Add(Me.txt_baseprice)
        Me.grb_rt.Location = New System.Drawing.Point(8, 120)
        Me.grb_rt.Name = "grb_rt"
        Me.grb_rt.Size = New System.Drawing.Size(224, 216)
        Me.grb_rt.TabIndex = 44
        Me.grb_rt.TabStop = False
        Me.grb_rt.Text = "Rack Tariff"
        '
        'txt_ehr
        '
        Me.txt_ehr.Location = New System.Drawing.Point(128, 144)
        Me.txt_ehr.Name = "txt_ehr"
        Me.txt_ehr.Size = New System.Drawing.Size(72, 21)
        Me.txt_ehr.TabIndex = 43
        Me.txt_ehr.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Extra Hour Rate *"
        '
        'txt_charges
        '
        Me.txt_charges.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_charges.Location = New System.Drawing.Point(128, 176)
        Me.txt_charges.Name = "txt_charges"
        Me.txt_charges.Size = New System.Drawing.Size(72, 21)
        Me.txt_charges.TabIndex = 44
        Me.txt_charges.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 32)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Standing Charges Per Day"
        '
        'txt_extrakm
        '
        Me.txt_extrakm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_extrakm.Location = New System.Drawing.Point(128, 112)
        Me.txt_extrakm.Name = "txt_extrakm"
        Me.txt_extrakm.Size = New System.Drawing.Size(72, 21)
        Me.txt_extrakm.TabIndex = 42
        Me.txt_extrakm.Text = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 112)
        Me.Label28.Name = "Label28"
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Extra k.M Rate *"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_km
        '
        Me.txt_km.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_km.Location = New System.Drawing.Point(128, 42)
        Me.txt_km.Name = "txt_km"
        Me.txt_km.Size = New System.Drawing.Size(88, 21)
        Me.txt_km.TabIndex = 20
        Me.txt_km.Text = ""
        '
        'txt_hours
        '
        Me.txt_hours.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hours.Location = New System.Drawing.Point(128, 72)
        Me.txt_hours.Name = "txt_hours"
        Me.txt_hours.Size = New System.Drawing.Size(88, 21)
        Me.txt_hours.TabIndex = 21
        Me.txt_hours.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 17)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Hours *"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 17)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "Base Price *"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(16, 42)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(46, 17)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "K.M's *"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_baseprice
        '
        Me.txt_baseprice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_baseprice.Location = New System.Drawing.Point(128, 16)
        Me.txt_baseprice.Name = "txt_baseprice"
        Me.txt_baseprice.Size = New System.Drawing.Size(88, 21)
        Me.txt_baseprice.TabIndex = 19
        Me.txt_baseprice.Text = ""
        '
        'cob_travelspartyid
        '
        Me.cob_travelspartyid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_travelspartyid.Location = New System.Drawing.Point(208, 88)
        Me.cob_travelspartyid.Name = "cob_travelspartyid"
        Me.cob_travelspartyid.Size = New System.Drawing.Size(152, 21)
        Me.cob_travelspartyid.TabIndex = 7
        Me.cob_travelspartyid.Text = "Select Travels Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Travels / Party Id"
        '
        'grb_vehicle
        '
        Me.grb_vehicle.Controls.Add(Me.Rad_hired)
        Me.grb_vehicle.Controls.Add(Me.Rad_own)
        Me.grb_vehicle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_vehicle.Location = New System.Drawing.Point(16, 9)
        Me.grb_vehicle.Name = "grb_vehicle"
        Me.grb_vehicle.Size = New System.Drawing.Size(216, 39)
        Me.grb_vehicle.TabIndex = 42
        Me.grb_vehicle.TabStop = False
        Me.grb_vehicle.Text = "Vehicle"
        '
        'Rad_hired
        '
        Me.Rad_hired.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_hired.Location = New System.Drawing.Point(104, 16)
        Me.Rad_hired.Name = "Rad_hired"
        Me.Rad_hired.Size = New System.Drawing.Size(104, 16)
        Me.Rad_hired.TabIndex = 1
        Me.Rad_hired.Text = "Hired Vehicle"
        '
        'Rad_own
        '
        Me.Rad_own.Checked = True
        Me.Rad_own.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_own.Location = New System.Drawing.Point(8, 16)
        Me.Rad_own.Name = "Rad_own"
        Me.Rad_own.Size = New System.Drawing.Size(96, 16)
        Me.Rad_own.TabIndex = 0
        Me.Rad_own.TabStop = True
        Me.Rad_own.Text = "Own Vehicle"
        '
        'Rad_chuffeur
        '
        Me.Rad_chuffeur.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_chuffeur.Location = New System.Drawing.Point(352, 16)
        Me.Rad_chuffeur.Name = "Rad_chuffeur"
        Me.Rad_chuffeur.Size = New System.Drawing.Size(80, 16)
        Me.Rad_chuffeur.TabIndex = 12
        Me.Rad_chuffeur.Text = "Chauffeur"
        '
        'Rad_self
        '
        Me.Rad_self.Checked = True
        Me.Rad_self.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad_self.Location = New System.Drawing.Point(248, 16)
        Me.Rad_self.Name = "Rad_self"
        Me.Rad_self.Size = New System.Drawing.Size(80, 16)
        Me.Rad_self.TabIndex = 11
        Me.Rad_self.TabStop = True
        Me.Rad_self.Text = "Self Drive"
        '
        'cob_vt
        '
        Me.cob_vt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_vt.Location = New System.Drawing.Point(272, 56)
        Me.cob_vt.Name = "cob_vt"
        Me.cob_vt.Size = New System.Drawing.Size(152, 21)
        Me.cob_vt.TabIndex = 8
        Me.cob_vt.Text = "Select Vehicle Type"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(176, 56)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(87, 17)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "Vehicle Type *"
        '
        'txt_tarcode
        '
        Me.txt_tarcode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tarcode.Location = New System.Drawing.Point(88, 56)
        Me.txt_tarcode.MaxLength = 6
        Me.txt_tarcode.Name = "txt_tarcode"
        Me.txt_tarcode.Size = New System.Drawing.Size(72, 21)
        Me.txt_tarcode.TabIndex = 2
        Me.txt_tarcode.Text = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 17)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Tariff Code *"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Veh_Tariff
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(490, 359)
        Me.Controls.Add(Me.Tbc_vehicletariff)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Veh_Tariff"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Tariff"
        Me.Tbc_vehicletariff.ResumeLayout(False)
        Me.Tabview.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dbg_vehicletariff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabentry.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.grb_ct.ResumeLayout(False)
        Me.grb_rt.ResumeLayout(False)
        Me.grb_vehicle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Veh_Tariff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()
        Tbc_vehicletariff.SelectedTab = Tabentry
        '****************************From Disabled**************
        disable()
        combofill1(cob_vt, "select vehtypeid,vehtype from veh_type")
        combofill1(cob_travelspartyid, "select travelsid,name from travels_mast")
        Rad_hired.Checked = True
        cob_travelspartyid.Enabled = False

    End Sub
    
    Public Sub clearproc()
        '***************Clears All the Controls*****************
        txt_tarcode.Text = ""
        grb_vehicle.Text = ""
        grb_rt.Text = ""
        grb_rt.Text = ""
        cob_travelspartyid.Text = ""
        cob_vt.Text = ""
        txt_baseprice.Text = ""
        txt_km.Text = ""
        txt_hours.Text = ""
        txt_extrakm.Text = ""
        txt_ehr.Text = ""
        txt_charges.Text = ""
        txt_bpct.Text = ""
        txt_ehrct.Text = ""
        txt_ekmct.Text = ""
        txt_hct.Text = ""
        txt_scpdct.Text = ""
        txt_kmct.Text = ""
    End Sub
    Public Sub newproc()
        recmode = Module1.EnuRecstatus.Recnew
        '******************Enable's the controls****************
        enable()
        Tbc_vehicletariff.SelectedTab = Tabentry
        'cob_travelspartyid.Enabled = False
       End Sub
    Public Sub enable()
        txt_baseprice.Enabled = True
        txt_charges.Enabled = True
        txt_extrakm.Enabled = True
        txt_hours.Enabled = True
        txt_km.Enabled = True
        txt_tarcode.Enabled = True
        cob_vt.Enabled = True
        cob_travelspartyid.Enabled = True
        grb_ct.Enabled = True
        grb_rt.Enabled = True
        Rad_own.Enabled = True
        Rad_hired.Enabled = True
        Rad_chuffeur.Enabled = True
        Rad_self.Enabled = True
        txt_ehr.Enabled = True
        txt_bpct.Enabled = True
        txt_ehrct.Enabled = True
        txt_ekmct.Enabled = True
        txt_hct.Enabled = True
        txt_kmct.Enabled = True
        txt_hct.Enabled = True
        txt_scpdct.Enabled = True
    End Sub
    Public Sub disable()
        txt_baseprice.Enabled = False
        txt_charges.Enabled = False
        txt_extrakm.Enabled = False
        txt_hours.Enabled = False
        txt_km.Enabled = False
        txt_tarcode.Enabled = False
        cob_vt.Enabled = False
        cob_travelspartyid.Enabled = False
        Rad_own.Enabled = False
        Rad_hired.Enabled = False
        Rad_chuffeur.Enabled = False
        Rad_self.Enabled = False
        txt_ehr.Enabled = False
        grb_ct.Enabled = False
    End Sub
    Public Sub grbrt()
        txt_baseprice.Enabled = True
        txt_charges.Enabled = True
        txt_extrakm.Enabled = True
        txt_hours.Enabled = True
        txt_km.Enabled = True
        txt_tarcode.Enabled = True
        cob_vt.Enabled = True
        cob_travelspartyid.Enabled = True
        grb_vehicle.Enabled = True
        Rad_chuffeur.Enabled = True
        Rad_self.Enabled = True
        txt_ehr.Enabled = True
    End Sub
    Public Sub grbct()
        txt_bpct.Enabled = True
        txt_ehrct.Enabled = True
        txt_ekmct.Enabled = True
        txt_hct.Enabled = True
        txt_kmct.Enabled = True
        txt_hct.Enabled = True
        txt_scpdct.Enabled = True
    End Sub
    Public Sub enabledfalse()
        txt_bpct.Enabled = False
        txt_ehrct.Enabled = False
        txt_ekmct.Enabled = False
        txt_hct.Enabled = False
        txt_kmct.Enabled = False
        txt_hct.Enabled = False
        txt_scpdct.Enabled = False
        txt_baseprice.Enabled = False
        txt_charges.Enabled = False
        txt_extrakm.Enabled = False
        txt_hours.Enabled = False
        txt_km.Enabled = False
        txt_tarcode.Enabled = False
        txt_ehr.Enabled = False
    End Sub
    Public Sub saveproc()
        '********************Validations************************
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                If Rad_own.Checked = True Then
                    str_rab = "OWN"
                    If txt_tarcode.Text = "" Then
                        MsgBox("Enter Tariff Code", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_tarcode.Focus()
                        Exit Sub
                    End If
                    If cob_vt.Text = "" Then
                        MsgBox("Choose Vehicle Type", MsgBoxStyle.OKOnly, Prjtitle)
                        cob_vt.Focus()
                        Exit Sub
                    End If
                    If txt_baseprice.Text = "" Then
                        MsgBox("Enter Base Price", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_baseprice.Focus()
                        Exit Sub
                    End If
                    If txt_km.Text = "" Then
                        MsgBox("Enter Kilometers", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_km.Focus()
                        Exit Sub
                    End If
                    If txt_hours.Text = "" Then
                        MsgBox("Enter Hours", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_hours.Focus()
                        Exit Sub
                    End If

                    If txt_extrakm.Text = "" Then
                        MsgBox("Enter Extra Kilometer Price", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_extrakm.Focus()
                        Exit Sub
                    End If
                    If txt_ehr.Text = "" Then
                        MsgBox("Enter Extra Hour Rate", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_ehr.Focus()
                        Exit Sub
                    End If
                    If txt_charges.Text = "" Then
                        MsgBox("Enter Charges", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_charges.Focus()
                        Exit Sub
                    End If
                End If
                If Rad_hired.Checked = True Then
                    str_rab = "HIRED"
                    If txt_tarcode.Text = "" Then
                        MsgBox("Enter Tariff Code", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_tarcode.Focus()
                        Exit Sub
                    End If
                    If cob_travelspartyid.Text = "" Then
                        MsgBox("Choose Travels Id ", MsgBoxStyle.OKOnly, Prjtitle)
                        cob_travelspartyid.Focus()
                        Exit Sub
                    End If
                    If cob_vt.Text = "" Then
                        MsgBox("Choose Vehicle Type", MsgBoxStyle.OKOnly, Prjtitle)
                        cob_vt.Focus()
                        Exit Sub
                    End If
                    If txt_bpct.Text = "" Then
                        MsgBox("Enter Base Price", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_bpct.Focus()
                        Exit Sub
                    End If
                    If txt_kmct.Text = "" Then
                        MsgBox("Enter Kilometers", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_kmct.Focus()
                        Exit Sub
                    End If
                    If txt_hct.Text = "" Then
                        MsgBox("Enter Hours", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_hct.Focus()
                        Exit Sub
                    End If
                    If txt_ekmct.Text = "" Then
                        MsgBox("Enter Extra Kilometer Rate", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_ekmct.Focus()
                        Exit Sub
                    End If
                    If txt_ehrct.Text = "" Then
                        MsgBox("Enter Extra Hour Rate", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_ehrct.Focus()
                        Exit Sub
                    End If
                    If txt_scpdct.Text = "" Then
                        MsgBox("Enter Standing Charges", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_scpdct.Focus()
                    End If

                    str_rab = "OWN"
                    If txt_tarcode.Text = "" Then
                        MsgBox("Enter Tariff Code", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_tarcode.Focus()
                        Exit Sub
                    End If
                    If cob_vt.Text = "" Then
                        MsgBox("Choose Vehicle Type", MsgBoxStyle.OKOnly, Prjtitle)
                        cob_vt.Focus()
                        Exit Sub
                    End If
                    If txt_baseprice.Text = "" Then
                        MsgBox("Enter Base Price", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_baseprice.Focus()
                        Exit Sub
                    End If
                    If txt_km.Text = "" Then
                        MsgBox("Enter Kilometers", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_km.Focus()
                        Exit Sub
                    End If
                    If txt_hours.Text = "" Then
                        MsgBox("Enter Hours", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_hours.Focus()
                        Exit Sub
                    End If

                    If txt_extrakm.Text = "" Then
                        MsgBox("Enter Extra Kilometer Price", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_extrakm.Focus()
                        Exit Sub
                    End If
                    If txt_ehr.Text = "" Then
                        MsgBox("Enter Extra Hour Rate", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_ehr.Focus()
                        Exit Sub
                    End If
                    If txt_charges.Text = "" Then
                        MsgBox("Enter Charges", MsgBoxStyle.OKOnly, Prjtitle)
                        txt_charges.Focus()
                        Exit Sub
                    End If

                End If
                If Rad_self.Checked = True Then
                    str_rad1 = "SELF"
                End If
                If Rad_chuffeur.Checked = True Then
                    str_rad1 = "CHUFFEUR"
                End If
                Dim a, b, c, d As String
                Openconnection()
                Dim X1 As Integer = 0
                cmd4 = New OleDbCommand("SELECT COUNT(*) FROM veh_tariff WHERE Tariffcode='" & txt_tarcode.Text & " '", con)
                Openconnection()
                Dim str As String
                Dim i As Integer
                'Adding Two String's of Vehicle Type and Name
                str = cob_vt.SelectedItem
                i = InStr(str, "-")
                str = Mid(str, 1, i - 1)
                Dim str1 As String
                'Adding two string of travelsid,name
                If Rad_hired.Checked = True Then
                    Dim i1 As Integer
                    str1 = cob_travelspartyid.SelectedItem
                    i1 = InStr(str1, "-")
                    str1 = Mid(str1, 1, i1 - 1)
                End If
                X1 = cmd4.ExecuteScalar
                If X1 <> 0 Then
                    MsgRecexist()
                    disable()
                    Exit Sub
                Else
                    cmd2 = New OleDbCommand("insert into veh_tariff values('" & txt_tarcode.Text & "','" & str_rab & "','" & str1 & "','" & str_rad1 & "','" & str & "'," & IIf(txt_baseprice.Text = "", 0, txt_baseprice.Text) & "," & IIf(txt_km.Text = "", 0, txt_km.Text) & "," & IIf(txt_hours.Text = "", 0, txt_hours.Text) & "," & IIf(txt_extrakm.Text = "", 0, txt_extrakm.Text) & " ," & IIf(txt_ehr.Text = "", 0, txt_ehr.Text) & "," & IIf(txt_charges.Text = "", 0, txt_charges.Text) & "," & IIf(txt_bpct.Text = "", 0, txt_bpct.Text) & "," & IIf(txt_kmct.Text = "", 0, txt_kmct.Text) & ", " & IIf(txt_hct.Text = "", 0, txt_hct.Text) & " ," & IIf(txt_ekmct.Text = "", 0, txt_ekmct.Text) & "," & IIf(txt_ehrct.Text = "", 0, txt_ehrct.Text) & "," & IIf(txt_scpdct.Text = "", 0, txt_scpdct.Text) & ",'" & Today & "','Y','" & Muserid & "','" & Today & "' )", con)
                    cmd2.ExecuteNonQuery()
                    MsgSav()
                    clearproc()
                    disable()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Sub EDITPROC()
        recmode = Module1.EnuRecstatus.Recedit
        MsgBox("Cannot Edit the Record", MsgBoxStyle.OKOnly, Prjtitle)
           End Sub
    Public Sub DELPROC()
        Dim actflag As String
        If MsgDelAlert() = vbNo Then Exit Sub
        Openconnection()
        Dim str As String
        Dim x, y As Integer
        str = "select count(*)from cust_vehicle where Tariffcode='" & txt_tarcode.Text & "'"
        cmd = New OleDbCommand(str, con)
        x = cmd.ExecuteScalar()
        If x >= 1 Then
            MsgRecUsed()  ' record mapped in transaction table , can not be deleted.
            Exit Sub
        Else
            Dim str1 As String = ("update veh_tariff set  effect_upto='" & Today & "', actflag= 'N' where tariffcode='" & txt_tarcode.Text & "'")
            Dim cmd As New OleDbCommand(str1, con)
            y = cmd.ExecuteNonQuery()
            If y > 0 Then
                MsgDel()
                clearproc()
                CloseConnection()
            End If
        End If
    End Sub
    Public Sub closeproc()
        Me.Close()
    End Sub
    Private Sub Tbc_vehicletariff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbc_vehicletariff.Click
        'Form Filling
        If Tbc_vehicletariff.SelectedTab.Text = "View" Then
            combofill1(cob_vt1, "select vehtypeid,vehtype from veh_type")
        End If
    End Sub
    Private Sub Dbg_vehicletariff_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dbg_vehicletariff.DoubleClick
        Dim i As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'Fills the current row index i.e K
        k = Dbg_vehicletariff.CurrentRowIndex
        i = Dbg_vehicletariff.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from veh_tariff where tariffcode='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            txt_tarcode.Text = dr(0)
            grb_vehicle.Text = dr(1)
            cob_travelspartyid.Text = dr(2)
            cob_vt.Text = dr(4)
            txt_baseprice.Text = dr(5)
            txt_km.Text = dr(6)
            txt_hours.Text = dr(7)
            txt_extrakm.Text = dr(8)
            txt_ehr.Text = dr(9)
            txt_charges.Text = dr(10)
            txt_bpct.Text = dr(11)
            txt_kmct.Text = dr(12)
            txt_hct.Text = dr(13)
            txt_ekmct.Text = dr(14)
            txt_ehrct.Text = dr(15)
            txt_scpdct.Text = dr(16)
            Tbc_vehicletariff.SelectedTab = Tabentry
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
    Private Sub Rad_hired_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rad_hired.CheckedChanged
         cob_travelspartyid.Enabled = True
    End Sub

    Private Sub Rad_own_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rad_own.CheckedChanged
         cob_travelspartyid.Enabled = False
    End Sub
    Private Sub txt_tarcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_tarcode.Leave
        firstcap(txt_tarcode)
    End Sub

    Private Sub txt_baseprice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_baseprice.KeyPress
         numberonly(e)
    End Sub
    Private Sub txt_bpct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_bpct.KeyPress
         numberonly(e)
    End Sub
    Private Sub txt_charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_charges.KeyPress
         numberonly(e)
    End Sub
   Private Sub txt_extrakm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_extrakm.KeyPress
         numberonly(e)
    End Sub
    Private Sub txt_ekmct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ekmct.KeyPress
         numberonly(e)
    End Sub

    Private Sub txt_hours_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hours.KeyPress
        numberonly(e)
    End Sub
    Private Sub txt_hct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hct.KeyPress
         numberonly(e)
    End Sub

    Private Sub txt_ehr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ehr.KeyPress
         numberonly(e)
    End Sub
    Private Sub txt_ehrct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ehrct.KeyPress
         numberonly(e)
    End Sub

    Private Sub txt_km_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_km.KeyPress
         numberonly(e)
    End Sub
    Private Sub txt_kmct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kmct.KeyPress
        numberonly(e)
    End Sub
    Private Sub txt_scpdct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_scpdct.KeyPress
        numberonly(e)
    End Sub

    Private Sub cob_vt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_vt.KeyPress
         combo(e)
    End Sub

    Private Sub cob_travelspartyid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_travelspartyid.KeyPress
         combo(e)
    End Sub

    Private Sub cob_vt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_vt1.KeyPress
         combo(e)
    End Sub

    Private Sub cob_vt1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_vt1.SelectedIndexChanged
         Dim str As String
        Dim i As Integer
        Dim ds As New DataSet
        str = cob_vt1.SelectedItem
        i = InStr(str, "-")
        str = Mid(str, 1, i - 1)
        If number > 0 Then
            ds.Clear()
        End If
        Dim da As New OleDbDataAdapter("select tariffcode,drive,travelsid,vehtypeid,entereddt from veh_tariff where vehtypeid ='" & str & "' and actflag= 'Y'", con)
        da.Fill(ds, "veh_tariff")
        Dbg_vehicletariff.Refresh()
        Dbg_vehicletariff.DataSource = ds.Tables("veh_tariff")
        number += 1
    End Sub

    Private Sub Rad_own_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rad_own.Click
        grb_ct.Enabled = False

    End Sub

    Private Sub Rad_hired_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rad_hired.Click
        grb_ct.Enabled = True

    End Sub
End Class
