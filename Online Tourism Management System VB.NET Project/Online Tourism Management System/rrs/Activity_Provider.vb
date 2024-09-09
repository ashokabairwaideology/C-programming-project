'written by P.R.Sudhakar Reddy
'Version 1
'date: 25 july 2006
Public Class Activity_Provider
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
    Friend WithEvents Tabcontrol1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtagentcode As System.Windows.Forms.TextBox
    Friend WithEvents txtfaxno As System.Windows.Forms.TextBox
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents txtworkphone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtzip As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cobcountry As System.Windows.Forms.ComboBox
    Friend WithEvents cobcity As System.Windows.Forms.ComboBox
    Friend WithEvents cobstate As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Tabcontrol1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtagentcode = New System.Windows.Forms.TextBox
        Me.txtfaxno = New System.Windows.Forms.TextBox
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.txtworkphone = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtzip = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cobcountry = New System.Windows.Forms.ComboBox
        Me.cobcity = New System.Windows.Forms.ComboBox
        Me.cobstate = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtemailid = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtaddress1 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtfirstname = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Tabcontrol1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabcontrol1
        '
        Me.Tabcontrol1.Controls.Add(Me.TabPage1)
        Me.Tabcontrol1.Controls.Add(Me.TabPage2)
        Me.Tabcontrol1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabcontrol1.ItemSize = New System.Drawing.Size(89, 19)
        Me.Tabcontrol1.Location = New System.Drawing.Point(0, 0)
        Me.Tabcontrol1.Name = "Tabcontrol1"
        Me.Tabcontrol1.SelectedIndex = 0
        Me.Tabcontrol1.Size = New System.Drawing.Size(504, 288)
        Me.Tabcontrol1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(496, 261)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dbg)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 248)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dbg
        '
        Me.dbg.DataMember = ""
        Me.dbg.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(8, 16)
        Me.dbg.Name = "dbg"
        Me.dbg.ReadOnly = True
        Me.dbg.Size = New System.Drawing.Size(464, 224)
        Me.dbg.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(496, 261)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Entry /Edit"
        Me.TabPage2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtagentcode)
        Me.GroupBox2.Controls.Add(Me.txtfaxno)
        Me.GroupBox2.Controls.Add(Me.txtremarks)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtmobile)
        Me.GroupBox2.Controls.Add(Me.txtworkphone)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtzip)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cobcountry)
        Me.GroupBox2.Controls.Add(Me.cobcity)
        Me.GroupBox2.Controls.Add(Me.cobstate)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtemailid)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtaddress1)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtfirstname)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 248)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(16, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Fax No"
        '
        'txtagentcode
        '
        Me.txtagentcode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagentcode.Location = New System.Drawing.Point(88, 32)
        Me.txtagentcode.MaxLength = 6
        Me.txtagentcode.Name = "txtagentcode"
        Me.txtagentcode.Size = New System.Drawing.Size(144, 21)
        Me.txtagentcode.TabIndex = 1
        Me.txtagentcode.Text = ""
        '
        'txtfaxno
        '
        Me.txtfaxno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfaxno.Location = New System.Drawing.Point(88, 152)
        Me.txtfaxno.MaxLength = 11
        Me.txtfaxno.Name = "txtfaxno"
        Me.txtfaxno.Size = New System.Drawing.Size(144, 21)
        Me.txtfaxno.TabIndex = 11
        Me.txtfaxno.Text = ""
        '
        'txtremarks
        '
        Me.txtremarks.AutoSize = False
        Me.txtremarks.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Location = New System.Drawing.Point(88, 176)
        Me.txtremarks.MaxLength = 30
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremarks.Size = New System.Drawing.Size(144, 64)
        Me.txtremarks.TabIndex = 13
        Me.txtremarks.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(248, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Email Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(16, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Remarks"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(88, 128)
        Me.txtmobile.MaxLength = 11
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(144, 21)
        Me.txtmobile.TabIndex = 9
        Me.txtmobile.Text = ""
        '
        'txtworkphone
        '
        Me.txtworkphone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtworkphone.Location = New System.Drawing.Point(328, 128)
        Me.txtworkphone.MaxLength = 11
        Me.txtworkphone.Name = "txtworkphone"
        Me.txtworkphone.Size = New System.Drawing.Size(144, 21)
        Me.txtworkphone.TabIndex = 10
        Me.txtworkphone.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(16, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Mobile"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(248, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 17)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Work-Phone"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtzip
        '
        Me.txtzip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtzip.Location = New System.Drawing.Point(328, 104)
        Me.txtzip.MaxLength = 6
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(144, 21)
        Me.txtzip.TabIndex = 8
        Me.txtzip.Text = ""
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(248, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 16)
        Me.Label19.TabIndex = 86
        Me.Label19.Text = "State *"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(16, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 17)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Country *"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cobcountry
        '
        Me.cobcountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcountry.ItemHeight = 13
        Me.cobcountry.Location = New System.Drawing.Point(88, 80)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(144, 21)
        Me.cobcountry.TabIndex = 5
        '
        'cobcity
        '
        Me.cobcity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcity.ItemHeight = 13
        Me.cobcity.Location = New System.Drawing.Point(88, 104)
        Me.cobcity.Name = "cobcity"
        Me.cobcity.Size = New System.Drawing.Size(144, 21)
        Me.cobcity.TabIndex = 7
        '
        'cobstate
        '
        Me.cobstate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobstate.ItemHeight = 13
        Me.cobstate.Location = New System.Drawing.Point(328, 80)
        Me.cobstate.Name = "cobstate"
        Me.cobstate.Size = New System.Drawing.Size(144, 21)
        Me.cobstate.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(16, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 83
        Me.Label21.Text = "City*"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtemailid
        '
        Me.txtemailid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemailid.Location = New System.Drawing.Point(328, 152)
        Me.txtemailid.MaxLength = 15
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(144, 21)
        Me.txtemailid.TabIndex = 12
        Me.txtemailid.Text = ""
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(88, 56)
        Me.txtaddress.MaxLength = 30
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(144, 21)
        Me.txtaddress.TabIndex = 3
        Me.txtaddress.Text = ""
        '
        'txtaddress1
        '
        Me.txtaddress1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress1.Location = New System.Drawing.Point(328, 56)
        Me.txtaddress1.MaxLength = 30
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.Size = New System.Drawing.Size(144, 21)
        Me.txtaddress1.TabIndex = 4
        Me.txtaddress1.Text = ""
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(16, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "Address  *"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(248, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 17)
        Me.Label25.TabIndex = 81
        Me.Label25.Text = "Address 1"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(248, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 17)
        Me.Label28.TabIndex = 80
        Me.Label28.Text = "Name *"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(16, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 24)
        Me.Label29.TabIndex = 79
        Me.Label29.Text = "Activity Provider Id *"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtfirstname
        '
        Me.txtfirstname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(328, 32)
        Me.txtfirstname.MaxLength = 20
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(144, 21)
        Me.txtfirstname.TabIndex = 2
        Me.txtfirstname.Text = ""
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(248, 104)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(24, 16)
        Me.Label30.TabIndex = 84
        Me.Label30.Text = "ZIP"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Activity_Provider
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(504, 293)
        Me.Controls.Add(Me.Tabcontrol1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Activity_Provider"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activity Provider"
        Me.Tabcontrol1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cmd As OleDb.OleDbCommand
    Dim ord As OleDb.OleDbDataReader
    Dim dad As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim recmode As EnuRecstatus
    Private Sub Activity_Provider_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        Tabcontrol1.SelectedTab = TabPage2
        cob_load()
        disproc()
    End Sub
    Public Sub disproc()
        ' procedure to disable all textboxs and comboboxs
        Dim x As Object
        For Each x In GroupBox2.Controls
            If TypeOf (x) Is TextBox Then
                x.enabled = False
            End If
            If TypeOf (x) Is ComboBox Then
                x.enabled = False
            End If
        Next

    End Sub
    Public Sub enproc()
        Dim x As Object
        'procedure to enable all textboxs and comboboxs
        For Each x In GroupBox2.Controls
            If TypeOf (x) Is TextBox Then
                x.enabled = True
            End If
            If TypeOf (x) Is ComboBox Then
                x.enabled = True
            End If
        Next
    End Sub
    Public Sub saveproc()
        Dim str_ci As String
        Dim str_st As String
        Dim str_co As String


        If txtagentcode.Text = "" Then
            MsgBox(" ACTIVITY PROVIDER ID MUST NOT BE EMPTY")
            Exit Sub
            txtagentcode.Focus()
        End If
        If txtfirstname.Text = "" Then
            MsgBox(" NAME SHOULD NOT BE EMPTY")
            Exit Sub
            txtfirstname.Focus()
        End If
        If txtaddress.Text = "" Then
            MsgBox("ADDRESS SHOULD NOT BE EMPTY")
            Exit Sub
            txtaddress.Focus()
        End If
        If cobcountry.Text = "" Then
            MsgBox(" COUNTRY SHOULD NOT BE EMPTY")
            Exit Sub
            cobcountry.Focus()
        End If
        If cobstate.Text = "" Then
            MsgBox("STATE SHOULD NOT BE EMPTY")
            Exit Sub
            cobstate.Focus()
        End If
        If cobcity.Text = "" Then
            MsgBox("CITY SHOULD NOT BE EMPTY")
            Exit Sub
            cobcity.Focus()
        End If

        Openconnection()
        Dim count As Integer
        cmd = New OleDb.OleDbCommand("select count(*) from Activity_Provider where Activ_ProvId ='" & txtagentcode.Text & "'", con)
        count = cmd.ExecuteScalar
        cmd.Dispose()
        If count >= 1 Then
            con.Close()
            MsgBox(" Record already exists with this ActivityProviderId ")
            Exit Sub
        End If
        Try
            cmd = New OleDb.OleDbCommand("select c.CityId, s.StateId, co.CountryId from CityMaster c,StateMaster s,CountryMaster co where c.City='" & cobcity.Text & "' and c.StateId = s.StateId and s.CountryId = co.CountryId", con)
            ord = cmd.ExecuteReader
            While ord.Read
                str_ci = ord(0)
                str_st = ord(1)
                str_co = ord(2)
            End While
            ord.Close()
            cmd.Dispose()
            If recmode = Module1.EnuRecstatus.Recnew Then
                cmd = New OleDb.OleDbCommand("insert into Activity_Provider values('" & txtagentcode.Text & "','" & txtfirstname.Text & "','" & txtaddress.Text & "','" & txtaddress1.Text & "','" & str_ci & "','" & str_st & "','" & str_co & "'," & Val(txtzip.Text) & "," & Val(txtworkphone.Text) & "," & Val(txtmobile.Text) & "," & Val(txtfaxno.Text) & ",'" & txtemailid.Text & "','" & txtremarks.Text & "')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                CloseConnection()
                MsgSav()
            End If
            If recmode = Module1.EnuRecstatus.Recedit Then
                cmd = New OleDb.OleDbCommand("update Activity_Provider set Name='" & txtfirstname.Text & "',Address='" & txtaddress.Text & "',Address1='" & txtaddress1.Text & "',CityId='" & str_ci & "',StateId='" & str_st & "',CountryId='" & str_co & "',ZIP=" & Val(txtzip.Text) & ",WorkPhone=" & Val(txtworkphone.Text) & ",Mobile=" & Val(txtmobile.Text) & ",Fax=" & Val(txtfaxno.Text) & ",Email='" & txtemailid.Text & "',Remarks='" & txtremarks.Text & "' where Activ_ProvId='" & txtagentcode.Text & "'", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                CloseConnection()
                txtagentcode.Enabled = True
                MsgSav()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub

        End Try
        clearproc()
    End Sub
    Public Sub newproc()
        enproc()
        recmode = Module1.EnuRecstatus.Recnew
        clearproc()
        cob_load()
        Tabcontrol1.SelectedTab = TabPage2
        txtagentcode.Focus()
    End Sub
    Public Sub cob_load()
        cobcountry.Items.Clear()
        Openconnection()
        cmd = New OleDb.OleDbCommand("select country from CountryMaster", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cobcountry.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub
    Public Sub clearproc()
        Dim x As Object
        For Each x In Me.GroupBox2.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
            If TypeOf (x) Is ComboBox Then
                x.text = ""
            End If
        Next
    End Sub
    Public Sub editproc()
        enproc()
        txtagentcode.Enabled = False
        recmode = Module1.EnuRecstatus.Recedit
        cob_load()
    End Sub
    Public Sub delproc()
        Dim yesno As String
        yesno = MsgDelAlert()
        If yesno = vbNo Then
            Exit Sub
        Else
            Openconnection()
            cmd = New OleDb.OleDbCommand("delete from Activity_Provider where Activ_ProvId='" & txtagentcode.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgDel()
            clearproc()
            cmd.Dispose()
            CloseConnection()
        End If
    End Sub

    Private Sub dbg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbg.DoubleClick, dbg.CurrentCellChanged
        Dim str_ci As String
        Dim str_st As String
        Dim str_co As String
        Dim ord1 As OleDb.OleDbDataReader
        Dim cmd1 As New OleDb.OleDbCommand
        Openconnection()
        cmd = New OleDb.OleDbCommand("select * from Activity_Provider where Activ_ProvId='" & dbg.Item(dbg.CurrentRowIndex, 0) & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            txtagentcode.Text = ord(0)
            txtfirstname.Text = ord(1)
            txtaddress.Text = ord(2)
            txtaddress1.Text = ord(3)
            str_ci = ord(4)
            str_st = ord(5)
            str_co = ord(6)
            txtzip.Text = ord(7)
            txtworkphone.Text = ord(8)
            txtmobile.Text = ord(9)
            txtfaxno.Text = ord(10)
            txtemailid.Text = ord(11)
            txtremarks.Text = ord(12)
        End While
        ord.Close()
        cmd.Dispose()
        cmd = New OleDb.OleDbCommand(" select City from CityMaster where CityId='" & str_ci & "' and  StateId = '" & str_st & "' and CountryId = '" & str_co & "' ", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cobcity.Text = ord(0)
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand(" select state from StateMaster where  StateId = '" & str_st & "' and CountryId = '" & str_co & "' ", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cobstate.Text = ord(0)
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand(" select Country from CountryMaster where CountryId = '" & str_co & "' ", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            cobcountry.Text = ord(0)
        End If
        ord.Close()
        cmd.Dispose()

        CloseConnection()
        disproc()
        Tabcontrol1.SelectedTab = TabPage2
        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()

    End Sub
    Private Sub Tabcontrol1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabcontrol1.Click
        ds = New DataSet
        If Tabcontrol1.SelectedTab Is TabPage1 Then
            dad = New OleDb.OleDbDataAdapter("select * from Activity_Provider", con)
            dad.Fill(ds, "trm")
            dbg.DataSource = ds
            dbg.DataMember = "trm"
        End If
        If Tabcontrol1.SelectedTab Is TabPage2 Then
            cob_load()
        End If
    End Sub

    Private Sub txtemailid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemailid.Leave
        email(txtemailid)
    End Sub

    Private Sub txtaddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.Leave
        firstcap(txtaddress)
    End Sub

    Private Sub txtaddress1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress1.Leave
        firstcap(txtaddress1)
    End Sub

    Private Sub txtagentcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtagentcode.Leave
        Dim i As Integer
        Openconnection()
        cmd = New OleDb.OleDbCommand("select count(*) from Activity_Provider where Activ_ProvId='" & txtagentcode.Text & "'", con)
        i = cmd.ExecuteScalar
        If i >= 1 Then
            MsgBox(" ACTIVITY PROVIDER ID ALREADY EXISTS !!")
            txtagentcode.Focus()
            cmd.Dispose()
            con.Close()
            Exit Sub
        End If
        cmd.Dispose()
        CloseConnection()
        firstcap(txtagentcode)
    End Sub

    Private Sub txtfirstname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfirstname.Leave
        firstcap(txtfirstname)
    End Sub

    Private Sub txtfaxno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfaxno.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtworkphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtworkphone.KeyPress
        numberonly(e)
    End Sub

    Private Sub txtzip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtzip.KeyPress
        numberonly(e)
    End Sub

    Private Sub cobcountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobcountry.SelectedIndexChanged
        cobstate.Items.Clear()
        con.Close()
        Openconnection()
        cmd = New OleDb.OleDbCommand("select s.State from StateMaster s, CountryMaster co where s.CountryID = co.CountryId and co.Country='" & cobcountry.SelectedItem & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cobstate.Items.Add(ord(0))
        End While
        cmd.Dispose()
        ord.Close()
        CloseConnection()
    End Sub

    Private Sub cobstate_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobstate.SelectedIndexChanged
        cobcity.Items.Clear()
        Openconnection()
        cmd = New OleDb.OleDbCommand(" select c.city from CityMaster c, StateMaster s where c.StateId = s.StateId and s.State='" & cobstate.SelectedItem & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cobcity.Items.Add(ord(0))
        End While
        cmd.Dispose()
        ord.Close()
        CloseConnection()
    End Sub

    Private Sub cobcountry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcountry.KeyPress
        combo(e)
    End Sub

    Private Sub cobstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobstate.KeyPress
        combo(e)
    End Sub

    Private Sub cobcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcity.KeyPress
        combo(e)
    End Sub
End Class
