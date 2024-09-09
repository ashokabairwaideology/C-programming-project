'Name developer: Emma Christeena.B
'Dt:28/06/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class Child_Room_Tarif
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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cobhotel As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbohalfboard As System.Windows.Forms.RadioButton
    Friend WithEvents rbnofullbord As System.Windows.Forms.RadioButton
    Friend WithEvents cobbedtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcorprate As System.Windows.Forms.TextBox
    Friend WithEvents txtrackrate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cobroomcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cobhotelid As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents radioown As System.Windows.Forms.RadioButton
    Friend WithEvents radioshared As System.Windows.Forms.RadioButton
    Friend WithEvents txtamount1 As System.Windows.Forms.TextBox
    Friend WithEvents txtpercor As System.Windows.Forms.TextBox
    Friend WithEvents radiolow As System.Windows.Forms.RadioButton
    Friend WithEvents radiohigh As System.Windows.Forms.RadioButton
    Friend WithEvents radiopeak As System.Windows.Forms.RadioButton
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtperrackrate As System.Windows.Forms.TextBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents txttransid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cobchildorjr As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Child_Room_Tarif))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cobhotel = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txttransid = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cobchildorjr = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.radioown = New System.Windows.Forms.RadioButton
        Me.radioshared = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbohalfboard = New System.Windows.Forms.RadioButton
        Me.rbnofullbord = New System.Windows.Forms.RadioButton
        Me.cobbedtype = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtamount1 = New System.Windows.Forms.TextBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtpercor = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtperrackrate = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcorprate = New System.Windows.Forms.TextBox
        Me.txtrackrate = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.radiolow = New System.Windows.Forms.RadioButton
        Me.radiohigh = New System.Windows.Forms.RadioButton
        Me.radiopeak = New System.Windows.Forms.RadioButton
        Me.cobroomcat = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cobhotelid = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 296)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cobhotel)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(520, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'cobhotel
        '
        Me.cobhotel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobhotel.Location = New System.Drawing.Point(192, 8)
        Me.cobhotel.Name = "cobhotel"
        Me.cobhotel.Size = New System.Drawing.Size(144, 21)
        Me.cobhotel.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Hotel"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 48)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(504, 216)
        Me.dbgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(520, 270)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        Me.TabPage2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttransid)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.cobbedtype)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.cobroomcat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cobhotelid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 264)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'txttransid
        '
        Me.txttransid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransid.Location = New System.Drawing.Point(104, 224)
        Me.txttransid.Name = "txttransid"
        Me.txttransid.Size = New System.Drawing.Size(40, 21)
        Me.txttransid.TabIndex = 22
        Me.txttransid.Text = ""
        Me.txttransid.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cobchildorjr)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.radioown)
        Me.GroupBox3.Controls.Add(Me.radioshared)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 96)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Children"
        '
        'cobchildorjr
        '
        Me.cobchildorjr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobchildorjr.Items.AddRange(New Object() {"Children", "Junior"})
        Me.cobchildorjr.Location = New System.Drawing.Point(104, 48)
        Me.cobchildorjr.Name = "cobchildorjr"
        Me.cobchildorjr.Size = New System.Drawing.Size(112, 21)
        Me.cobchildorjr.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Child / Junior *"
        '
        'radioown
        '
        Me.radioown.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioown.Location = New System.Drawing.Point(128, 24)
        Me.radioown.Name = "radioown"
        Me.radioown.Size = New System.Drawing.Size(88, 16)
        Me.radioown.TabIndex = 1
        Me.radioown.Text = "Own Room"
        '
        'radioshared
        '
        Me.radioshared.Checked = True
        Me.radioshared.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioshared.Location = New System.Drawing.Point(16, 24)
        Me.radioshared.Name = "radioshared"
        Me.radioshared.Size = New System.Drawing.Size(104, 16)
        Me.radioshared.TabIndex = 0
        Me.radioshared.TabStop = True
        Me.radioshared.Text = "Shared Room"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbohalfboard)
        Me.GroupBox1.Controls.Add(Me.rbnofullbord)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(240, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 48)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Board"
        '
        'rbohalfboard
        '
        Me.rbohalfboard.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbohalfboard.Location = New System.Drawing.Point(144, 24)
        Me.rbohalfboard.Name = "rbohalfboard"
        Me.rbohalfboard.Size = New System.Drawing.Size(88, 16)
        Me.rbohalfboard.TabIndex = 11
        Me.rbohalfboard.Text = "Half Board"
        '
        'rbnofullbord
        '
        Me.rbnofullbord.Checked = True
        Me.rbnofullbord.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnofullbord.Location = New System.Drawing.Point(40, 24)
        Me.rbnofullbord.Name = "rbnofullbord"
        Me.rbnofullbord.Size = New System.Drawing.Size(88, 16)
        Me.rbnofullbord.TabIndex = 10
        Me.rbnofullbord.TabStop = True
        Me.rbnofullbord.Text = "Full Board"
        '
        'cobbedtype
        '
        Me.cobbedtype.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobbedtype.Items.AddRange(New Object() {"Queen + Extra Bed", "Queen Bed", "Single Bed", "Tripple Bed", "Twin Bed"})
        Me.cobbedtype.Location = New System.Drawing.Point(104, 184)
        Me.cobbedtype.Name = "cobbedtype"
        Me.cobbedtype.Size = New System.Drawing.Size(120, 21)
        Me.cobbedtype.Sorted = True
        Me.cobbedtype.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Bed Type "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtamount1)
        Me.GroupBox5.Controls.Add(Me.txtamount)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtpercor)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtperrackrate)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtcorprate)
        Me.GroupBox5.Controls.Add(Me.txtrackrate)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(240, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(272, 144)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rate"
        '
        'txtamount1
        '
        Me.txtamount1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount1.Location = New System.Drawing.Point(200, 80)
        Me.txtamount1.Name = "txtamount1"
        Me.txtamount1.Size = New System.Drawing.Size(64, 21)
        Me.txtamount1.TabIndex = 16
        Me.txtamount1.Text = ""
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(200, 16)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(64, 21)
        Me.txtamount.TabIndex = 13
        Me.txtamount.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(144, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(144, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Amount"
        '
        'txtpercor
        '
        Me.txtpercor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpercor.Location = New System.Drawing.Point(104, 80)
        Me.txtpercor.MaxLength = 2
        Me.txtpercor.Name = "txtpercor"
        Me.txtpercor.Size = New System.Drawing.Size(32, 21)
        Me.txtpercor.TabIndex = 15
        Me.txtpercor.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Percentage Of  "
        '
        'txtperrackrate
        '
        Me.txtperrackrate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperrackrate.Location = New System.Drawing.Point(104, 16)
        Me.txtperrackrate.MaxLength = 2
        Me.txtperrackrate.Name = "txtperrackrate"
        Me.txtperrackrate.Size = New System.Drawing.Size(32, 21)
        Me.txtperrackrate.TabIndex = 12
        Me.txtperrackrate.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Percentage Of  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Corporate Rate"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rack Rate"
        '
        'txtcorprate
        '
        Me.txtcorprate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtcorprate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcorprate.Location = New System.Drawing.Point(104, 112)
        Me.txtcorprate.Name = "txtcorprate"
        Me.txtcorprate.Size = New System.Drawing.Size(104, 21)
        Me.txtcorprate.TabIndex = 17
        Me.txtcorprate.Text = ""
        '
        'txtrackrate
        '
        Me.txtrackrate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtrackrate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrackrate.Location = New System.Drawing.Point(104, 48)
        Me.txtrackrate.Name = "txtrackrate"
        Me.txtrackrate.Size = New System.Drawing.Size(104, 21)
        Me.txtrackrate.TabIndex = 14
        Me.txtrackrate.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radiolow)
        Me.GroupBox4.Controls.Add(Me.radiohigh)
        Me.GroupBox4.Controls.Add(Me.radiopeak)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(240, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(272, 48)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Season"
        '
        'radiolow
        '
        Me.radiolow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiolow.Location = New System.Drawing.Point(176, 16)
        Me.radiolow.Name = "radiolow"
        Me.radiolow.Size = New System.Drawing.Size(48, 16)
        Me.radiolow.TabIndex = 9
        Me.radiolow.Text = "Low"
        '
        'radiohigh
        '
        Me.radiohigh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiohigh.Location = New System.Drawing.Point(120, 16)
        Me.radiohigh.Name = "radiohigh"
        Me.radiohigh.Size = New System.Drawing.Size(56, 16)
        Me.radiohigh.TabIndex = 8
        Me.radiohigh.Text = "High"
        '
        'radiopeak
        '
        Me.radiopeak.Checked = True
        Me.radiopeak.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiopeak.Location = New System.Drawing.Point(48, 16)
        Me.radiopeak.Name = "radiopeak"
        Me.radiopeak.Size = New System.Drawing.Size(56, 16)
        Me.radiopeak.TabIndex = 7
        Me.radiopeak.TabStop = True
        Me.radiopeak.Text = "Peak"
        '
        'cobroomcat
        '
        Me.cobroomcat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobroomcat.Location = New System.Drawing.Point(104, 152)
        Me.cobroomcat.Name = "cobroomcat"
        Me.cobroomcat.Size = New System.Drawing.Size(120, 21)
        Me.cobroomcat.Sorted = True
        Me.cobroomcat.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Room Category "
        '
        'cobhotelid
        '
        Me.cobhotelid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobhotelid.Location = New System.Drawing.Point(104, 120)
        Me.cobhotelid.Name = "cobhotelid"
        Me.cobhotelid.Size = New System.Drawing.Size(120, 21)
        Me.cobhotelid.Sorted = True
        Me.cobhotelid.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hotel Id *"
        '
        'Child_Room_Tarif
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(530, 295)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Child_Room_Tarif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Child Room Tariff"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cmd, cmd1 As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim recmode As EnuRecstatus
    Dim bolvali As Boolean
    Private Sub Child_Room_Tarif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load
        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'opens entry/edit page on pageload
        TabControl1.SelectedTab = TabPage2
        '------below code brings data from hotelmaster,roommaster tables and fill in the combo boxe------'
        combofill1(cobhotelid, "select * from HotelMaster")
        combofill1(cobroomcat, "select * from Room_Catg") 'fills the combobox
        'locks the controls
        Lock()
    End Sub
    Public Sub lock()
        'locks the controls
        radioshared.Enabled = False
        radioown.Enabled = False
        cobchildorjr.Enabled = False
        cobhotelid.Enabled = False
        cobroomcat.Enabled = False
        cobbedtype.Enabled = False
        radiopeak.Enabled = False
        radiohigh.Enabled = False
        radiolow.Enabled = False
        rbnofullbord.Enabled = False
        rbohalfboard.Enabled = False
        txtperrackrate.ReadOnly = True
        txtamount.ReadOnly = True
        txtrackrate.ReadOnly = True
        txtpercor.ReadOnly = True
        txtamount1.ReadOnly = True
        txtcorprate.ReadOnly = True
    End Sub
    '  this procedure clears the all text boxes and combo boxes
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox2.Controls
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.GroupBox3.Controls
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.GroupBox5.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    'this procedure checks the form status and set it to new mode
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        ' unlocks the controls
        radioshared.Enabled = True
        radioown.Enabled = True
        cobchildorjr.Enabled = True
        cobhotelid.Enabled = True
        cobroomcat.Enabled = True
        cobbedtype.Enabled = True
        radiopeak.Enabled = True
        radiohigh.Enabled = True
        radiolow.Enabled = True
        rbnofullbord.Enabled = True
        rbohalfboard.Enabled = True
        txtperrackrate.ReadOnly = False
        txtamount.ReadOnly = False
        txtrackrate.ReadOnly = False
        txtpercor.ReadOnly = False
        txtamount1.ReadOnly = False
        txtcorprate.ReadOnly = False
        cobchildorjr.Focus()
    End Sub
    'calculates percentage 
    Private Sub txtamount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount.Leave
        Dim a, b As Double
        a = Val(txtperrackrate.Text) / 100
        b = Val(txtamount.Text)
        txtrackrate.Text = a * b
    End Sub
    'calculates percentage
    Private Sub txtamount1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount1.Leave
        Dim a, b As Double
        a = Val(txtpercor.Text) / 100
        b = Val(txtamount1.Text)
        txtcorprate.Text = a * b
    End Sub
    'form status as edit mode
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        'locks the control
        cobhotelid.Enabled = False
        'unlocks the controls
        radioshared.Enabled = True
        radioown.Enabled = True
        cobchildorjr.Enabled = True
        cobroomcat.Enabled = True
        cobbedtype.Enabled = True
        radiopeak.Enabled = True
        radiohigh.Enabled = True
        radiolow.Enabled = True
        rbnofullbord.Enabled = True
        rbohalfboard.Enabled = True
        txtperrackrate.ReadOnly = False
        txtamount.ReadOnly = False
        txtrackrate.ReadOnly = False
        txtpercor.ReadOnly = False
        txtamount1.ReadOnly = False
        txtcorprate.ReadOnly = False
        'cursor gets into cobfromage combo box
        cobchildorjr.Focus()
    End Sub
    'to check the validations
    Public Sub valid()
        bolvali = False
        If cobchildorjr.Text = "" Then
            MsgBox(" enter child/junior", MsgBoxStyle.OKOnly, Prjtitle)
            cobchildorjr.Focus()
            Exit Sub
        End If
        If cobhotelid.Text = "" Then
            MsgBox(" Hotel Name SHOULD NOT BE EMPTY", MsgBoxStyle.OKOnly, Prjtitle)
            cobhotelid.Focus()
            Exit Sub
        End If
        bolvali = True
    End Sub
    'inserts or updates arecord
    Public Sub saveproc()
        Dim ctransid As Integer
        Dim actflag As String
        valid()
        If bolvali = False Then Exit Sub
        Try
            Label1.Focus()
            Dim childroom As String
            If radioshared.Checked = True Then
                childroom = "Shared"
            Else
                radioown.Checked = True
                childroom = "Own"
            End If
            Dim season As String
            If radiohigh.Checked = True Then
                season = "High"
            ElseIf radiolow.Checked = True Then
                season = "Low"
            ElseIf radiopeak.Checked = True Then
                season = "Peak"
            End If
            Dim board As String
            If rbnofullbord.Checked = True Then
                board = "FullBoard"
            Else
                rbohalfboard.Checked = True
                board = "HalfBoard"
            End If
            If recmode = Module1.EnuRecstatus.Recnew Then
                Dim b, c As String
                b = cobhotelid.SelectedItem
                c = (b.Substring(0, b.IndexOf("-")))
                Dim d, e As String
                d = cobroomcat.Text
                e = (d.Substring(0, d.IndexOf("-")))
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Room_Tarif_Child where HotelId='" & cobhotelid.Text & "' ", con)
                p = cmd.ExecuteScalar
                cmd.Dispose()
                If p <> 0 Then
                    MsgRecexist()
                Else
                    cmd1 = New OleDb.OleDbCommand("select count(*) from Room_Tarif_Child", con)
                    ctransid = cmd1.ExecuteScalar
                    cmd1.Dispose()
                    If ctransid >= 1 Then
                        ' retrieving tansaction id 
                        cmd1 = New OleDb.OleDbCommand("select max(ctransid) from Room_Tarif_Child ", con)
                        ctransid = cmd1.ExecuteScalar
                        cmd1.Dispose()
                    End If
                    ' incrementing transaction id
                    ctransid = ctransid + 1
                    Dim dt, dt1 As DateTime
                    dt = System.DateTime.Now
                    Openconnection()
                    Dim str As String = "insert into Room_Tarif_Child values('" & ctransid & "','" & c & "','" & e & "','" & cobbedtype.Text & "','" & season & "','" & board & "','" & txtperrackrate.Text & "','" & txtamount.Text & "','" & txtrackrate.Text & "','" & txtpercor.Text & "','" & txtamount1.Text & "','" & txtcorprate.Text & "','" & childroom & "','" & cobchildorjr.Text & "','Y','" & Muserid & "',#" & dt & "#)"
                    cmd = New OleDbCommand(str, con)
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
                Dim d, e As String
                d = cobroomcat.Text
                e = (d.Substring(0, d.IndexOf("-")))
                Dim b, c As String
                b = cobhotelid.SelectedItem
                c = (b.Substring(0, b.IndexOf("-")))
                Openconnection()
                cmd = New OleDbCommand("update Room_Tarif_Child set RCatg_id='" & e & "',Bed_Type='" & cobbedtype.Text & "',Season='" & season & "',Board='" & board & "',RPercentage='" & txtperrackrate.Text & "',RAmount='" & txtamount.Text & "',RackRate='" & txtrackrate.Text & "',CPercentage='" & txtpercor.Text & "',CAmount='" & txtamount1.Text & "',CropRate='" & txtcorprate.Text & "',Basis='" & childroom & "',Chil_Type='" & cobchildorjr.Text & "' where ctransid=" & txttransid.Text & "", con)
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
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'it deletes the records
    Public Sub delproc()
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "update Room_Tarif_Child set Actflag='N' where CTransId=" & txttransid.Text & ""
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            'Displays record deleted message in messagebox
            MsgDel()
            'clears the controls
            clearproc()
            'locks the controls
            lock()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'when tab control changes the index it goes to next tab
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        combofill1(cobhotel, "select  distinct(HotelId),hotelname from hotelmaster")
        ds.Clear()
    End Sub
    Private Sub cobhotel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobhotel.SelectedIndexChanged
        Dim b, c As String
        ds.Clear()
        b = cobhotel.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        'Data in the table child room tarrif will be displayed in datagrid on click in view tab page
        da = New OleDbDataAdapter("select * from Room_Tarif_Child where hotelid='" & c & "'", con)
        da.Fill(ds, "hotel")
        dbgview.DataSource = ds
        dbgview.DataMember = "hotel"
    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim str, str2 As String
        Dim k, int As Integer
        Dim dr As OleDb.OleDbDataReader
        ' locks the controls
        lock()
        'fills the current row index number in int
        int = dbgview.CurrentRowIndex
        'fills the value of row in str
        str = dbgview.Item(int, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from Room_Tarif_Child where CTransId=" & str & "", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            Dim x, y, z, q, w As String
            txttransid.Text = dr(0)
            x = dr(1)
            comboselet(cobhotelid, x)
            y = dr(2)
            comboselet(cobroomcat, y)
            cobbedtype.Text = dr(3)
            z = dr(4)
            If z = "Peak" Then
                radiopeak.Checked = True
            ElseIf z = "High" Then
                radiohigh.Checked = True
            Else
                radiolow.Checked = True
            End If
            q = dr(5)
            If q = "FullBoard" Then
                rbnofullbord.Checked = True
            Else
                rbohalfboard.Checked = True
            End If
            txtperrackrate.Text = dr(6)
            txtamount.Text = dr(7)
            txtrackrate.Text = dr(8)
            txtpercor.Text = dr(9)
            txtamount1.Text = dr(10)
            txtcorprate.Text = dr(11)
            w = dr(12)
            If w = "Shared" Then
                radioshared.Checked = True
            Else
                radioown.Checked = True
            End If
            cobchildorjr.Text = dr(13)
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
    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub txtamount1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount1.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub txtcorprate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorprate.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub txtpercor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpercor.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub txtperrackrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtperrackrate.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub txtrackrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrackrate.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub cobbedtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobbedtype.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub
    Private Sub cobhotel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotel.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub
    Private Sub cobhotelid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotelid.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub
    Private Sub cobroomcat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobroomcat.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub
    Private Sub cobchildorjr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobchildorjr.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub
End Class
