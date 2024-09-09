'Date:03/07/2006
'shiva kumar

Imports System.Data.OleDb
Public Class VEHICLE_Mast
    Inherits System.Windows.Forms.Form
    Dim recmode As EnuRecstatus
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtchasisno As System.Windows.Forms.TextBox
    Friend WithEvents txtstndmilg As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofsets As System.Windows.Forms.TextBox
    Friend WithEvents txtnooftyrs As System.Windows.Forms.TextBox
    Friend WithEvents txtengine As System.Windows.Forms.TextBox
    Friend WithEvents txtmeterred As System.Windows.Forms.TextBox
    Friend WithEvents txttnkcap As System.Windows.Forms.TextBox
    Friend WithEvents txtregsno As System.Windows.Forms.TextBox
    Friend WithEvents txtfrnttnkcap As System.Windows.Forms.TextBox
    Friend WithEvents txtreartnkcap As System.Windows.Forms.TextBox
    Friend WithEvents txtfueltype As System.Windows.Forms.TextBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cobvehtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cobdriver As System.Windows.Forms.ComboBox
    Friend WithEvents cobvehtyp As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(VEHICLE_Mast))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cobvehtype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cobdriver = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.cobvehtyp = New System.Windows.Forms.ComboBox
        Me.txtchasisno = New System.Windows.Forms.TextBox
        Me.txtstndmilg = New System.Windows.Forms.TextBox
        Me.txtnoofsets = New System.Windows.Forms.TextBox
        Me.txtnooftyrs = New System.Windows.Forms.TextBox
        Me.txtengine = New System.Windows.Forms.TextBox
        Me.txtmeterred = New System.Windows.Forms.TextBox
        Me.txttnkcap = New System.Windows.Forms.TextBox
        Me.txtregsno = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtfrnttnkcap = New System.Windows.Forms.TextBox
        Me.txtreartnkcap = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtfueltype = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(520, 256)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(512, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrid1)
        Me.GroupBox1.Controls.Add(Me.cobvehtype)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 216)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 56)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(472, 152)
        Me.DataGrid1.TabIndex = 6
        '
        'cobvehtype
        '
        Me.cobvehtype.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobvehtype.Location = New System.Drawing.Point(224, 24)
        Me.cobvehtype.Name = "cobvehtype"
        Me.cobvehtype.Size = New System.Drawing.Size(136, 21)
        Me.cobvehtype.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vehicle Type"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(512, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cobdriver)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dtp1)
        Me.GroupBox3.Controls.Add(Me.cobvehtyp)
        Me.GroupBox3.Controls.Add(Me.txtchasisno)
        Me.GroupBox3.Controls.Add(Me.txtstndmilg)
        Me.GroupBox3.Controls.Add(Me.txtnoofsets)
        Me.GroupBox3.Controls.Add(Me.txtnooftyrs)
        Me.GroupBox3.Controls.Add(Me.txtengine)
        Me.GroupBox3.Controls.Add(Me.txtmeterred)
        Me.GroupBox3.Controls.Add(Me.txttnkcap)
        Me.GroupBox3.Controls.Add(Me.txtregsno)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.txtfrnttnkcap)
        Me.GroupBox3.Controls.Add(Me.txtreartnkcap)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.txtfueltype)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, -1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 232)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'cobdriver
        '
        Me.cobdriver.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobdriver.Location = New System.Drawing.Point(384, 208)
        Me.cobdriver.Name = "cobdriver"
        Me.cobdriver.Size = New System.Drawing.Size(112, 21)
        Me.cobdriver.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Driver *"
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp1.Location = New System.Drawing.Point(384, 17)
        Me.dtp1.MaxDate = New Date(2080, 12, 31, 0, 0, 0, 0)
        Me.dtp1.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(112, 21)
        Me.dtp1.TabIndex = 1
        Me.dtp1.Value = New Date(2006, 8, 11, 0, 0, 0, 0)
        '
        'cobvehtyp
        '
        Me.cobvehtyp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobvehtyp.Location = New System.Drawing.Point(128, 48)
        Me.cobvehtyp.Name = "cobvehtyp"
        Me.cobvehtyp.Size = New System.Drawing.Size(112, 21)
        Me.cobvehtyp.TabIndex = 2
        '
        'txtchasisno
        '
        Me.txtchasisno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchasisno.Location = New System.Drawing.Point(384, 144)
        Me.txtchasisno.MaxLength = 20
        Me.txtchasisno.Name = "txtchasisno"
        Me.txtchasisno.Size = New System.Drawing.Size(112, 21)
        Me.txtchasisno.TabIndex = 9
        Me.txtchasisno.Text = ""
        '
        'txtstndmilg
        '
        Me.txtstndmilg.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstndmilg.Location = New System.Drawing.Point(384, 112)
        Me.txtstndmilg.MaxLength = 4
        Me.txtstndmilg.Name = "txtstndmilg"
        Me.txtstndmilg.Size = New System.Drawing.Size(112, 21)
        Me.txtstndmilg.TabIndex = 7
        Me.txtstndmilg.Text = ""
        '
        'txtnoofsets
        '
        Me.txtnoofsets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofsets.Location = New System.Drawing.Point(128, 208)
        Me.txtnoofsets.MaxLength = 2
        Me.txtnoofsets.Name = "txtnoofsets"
        Me.txtnoofsets.Size = New System.Drawing.Size(104, 21)
        Me.txtnoofsets.TabIndex = 12
        Me.txtnoofsets.Text = ""
        '
        'txtnooftyrs
        '
        Me.txtnooftyrs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnooftyrs.Location = New System.Drawing.Point(128, 176)
        Me.txtnooftyrs.MaxLength = 2
        Me.txtnooftyrs.Name = "txtnooftyrs"
        Me.txtnooftyrs.Size = New System.Drawing.Size(104, 21)
        Me.txtnooftyrs.TabIndex = 10
        Me.txtnooftyrs.Text = ""
        '
        'txtengine
        '
        Me.txtengine.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtengine.Location = New System.Drawing.Point(128, 144)
        Me.txtengine.MaxLength = 20
        Me.txtengine.Name = "txtengine"
        Me.txtengine.Size = New System.Drawing.Size(104, 21)
        Me.txtengine.TabIndex = 8
        Me.txtengine.Text = ""
        '
        'txtmeterred
        '
        Me.txtmeterred.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmeterred.Location = New System.Drawing.Point(128, 112)
        Me.txtmeterred.MaxLength = 10
        Me.txtmeterred.Name = "txtmeterred"
        Me.txtmeterred.Size = New System.Drawing.Size(104, 21)
        Me.txtmeterred.TabIndex = 6
        Me.txtmeterred.Text = ""
        '
        'txttnkcap
        '
        Me.txttnkcap.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttnkcap.Location = New System.Drawing.Point(384, 48)
        Me.txttnkcap.MaxLength = 4
        Me.txttnkcap.Name = "txttnkcap"
        Me.txttnkcap.Size = New System.Drawing.Size(112, 21)
        Me.txttnkcap.TabIndex = 3
        Me.txttnkcap.Text = ""
        '
        'txtregsno
        '
        Me.txtregsno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregsno.Location = New System.Drawing.Point(128, 16)
        Me.txtregsno.MaxLength = 15
        Me.txtregsno.Name = "txtregsno"
        Me.txtregsno.Size = New System.Drawing.Size(104, 21)
        Me.txtregsno.TabIndex = 0
        Me.txtregsno.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Fuel Type"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(256, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Chassis No."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(256, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Standard Milage"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(256, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 17)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Registration Date"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 208)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 17)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "No. Of Seating"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 17)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "No. Of Tyres"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 144)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 17)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Engine No."
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 112)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 17)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Meter Reading"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(256, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 17)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Tank Capacity"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 17)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Vehicle Type *"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 17)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "Registration No *"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtfrnttnkcap
        '
        Me.txtfrnttnkcap.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrnttnkcap.Location = New System.Drawing.Point(128, 80)
        Me.txtfrnttnkcap.MaxLength = 4
        Me.txtfrnttnkcap.Name = "txtfrnttnkcap"
        Me.txtfrnttnkcap.Size = New System.Drawing.Size(104, 21)
        Me.txtfrnttnkcap.TabIndex = 4
        Me.txtfrnttnkcap.Text = ""
        '
        'txtreartnkcap
        '
        Me.txtreartnkcap.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreartnkcap.Location = New System.Drawing.Point(384, 80)
        Me.txtreartnkcap.MaxLength = 4
        Me.txtreartnkcap.Name = "txtreartnkcap"
        Me.txtreartnkcap.Size = New System.Drawing.Size(112, 21)
        Me.txtreartnkcap.TabIndex = 5
        Me.txtreartnkcap.Text = ""
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 80)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(118, 17)
        Me.Label38.TabIndex = 16
        Me.Label38.Text = "Front Tank Capacity"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(256, 80)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(115, 17)
        Me.Label39.TabIndex = 21
        Me.Label39.Text = "Rear Tank Capacity"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtfueltype
        '
        Me.txtfueltype.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfueltype.Location = New System.Drawing.Point(384, 176)
        Me.txtfueltype.MaxLength = 15
        Me.txtfueltype.Name = "txtfueltype"
        Me.txtfueltype.Size = New System.Drawing.Size(112, 21)
        Me.txtfueltype.TabIndex = 11
        Me.txtfueltype.Text = ""
        '
        'VEHICLE_Mast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(520, 253)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VEHICLE_Mast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub saveproc()

        If txtregsno.Text = "" Then
            MsgBox("Enter Registration Number", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        
        If cobdriver.SelectedItem = "" Or cobdriver.Text = "" Then
            MsgBox("Select Driver", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If

        If cobvehtyp.Text = "" Or cobvehtyp.SelectedItem = "" Then

            MsgBox("Select Vehicle Type", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If

        Dim p As Integer = 0
        Dim k, l, str, str1 As String
        k = cobvehtyp.SelectedItem
        str = (k.Substring(0, k.IndexOf("-")))
        l = cobdriver.SelectedItem
        str1 = (l.Substring(0, l.IndexOf("-")))

        If recmode = Module1.EnuRecstatus.Recnew Then

            Try

                Openconnection()

                Dim cmd1 As New OleDbCommand("select count(*) from ownvehiclemaster where trim(regno)='" & Trim(txtregsno.Text) & "'", con)
                p = cmd1.ExecuteScalar
                If p = 0 Then
                    Dim cmd As New OleDbCommand("insert into ownvehiclemaster values('" & txtregsno.Text & " ','" & dtp1.Text & "'," & IIf(txttnkcap.Text = "", 0, txttnkcap.Text) & ",'" & str & "'," & IIf(txtfrnttnkcap.Text = "", 0, txtfrnttnkcap.Text) & "," & IIf(txtreartnkcap.Text = "", 0, txtreartnkcap.Text) & ",'" & IIf(txtmeterred.Text = "", 0, txtmeterred.Text) & "'," & IIf(txtstndmilg.Text = "", 0, txtstndmilg.Text) & ",'" & txtengine.Text & "','" & IIf(txtchasisno.Text = "", 0, txtchasisno.Text) & "'," & IIf(txtnooftyrs.Text = "", 0, txtnooftyrs.Text) & ",'" & txtfueltype.Text & "'," & IIf(txtnoofsets.Text = "", 0, txtnoofsets.Text) & ",'" & str1 & "','Y','Y')", con)
                    cmd.ExecuteNonQuery()
                    MsgSav()
                    clearproc()
                Else
                    MsgRecexist()
                    clearproc()
                    txtregsno.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
                CloseConnection()
            Finally
                CloseConnection()
            End Try
        End If

        If recmode = Module1.EnuRecstatus.Recedit Then

            If cobvehtyp.SelectedItem = "" Then
                k = cobvehtyp.Text
            Else
                k = cobvehtyp.SelectedItem
            End If

            str = (k.Substring(0, k.IndexOf("-")))

            p = txtstndmilg.Text
            If MsgBox("DoU Want To Edit The Record", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                Openconnection()
                Dim cmd As New OleDbCommand("update OwnVehicleMaster set Regdate='" & dtp1.Text & "',tankcapacity=" & txttnkcap.Text & " ,vehtypeid='" & str & "',fronttankcap=" & txtfrnttnkcap.Text & " ,reartankcap=" & txtreartnkcap.Text & ",meterreading=" & txtmeterred.Text & ",Enginenumber='" & txtengine.Text & "',chasisnumber='" & txtchasisno.Text & "',Numberoftyres=" & txtnooftyrs.Text & ", fueltype='" & txtfueltype.Text & "',seatingcapacity=" & txtnoofsets.Text & ",standardmileage='" & txtstndmilg.Text & "',EmployeeId='" & str1 & "' where trim(regno)='" & Trim(txtregsno.Text) & "' ", con)
                Try

                    cmd.ExecuteNonQuery()
                    clearproc()
                    MsgSav()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                    CloseConnection()
                    Exit Sub
                Finally
                    CloseConnection()
                End Try
            End If
        End If
    End Sub

    Public Sub clearproc()

        txtchasisno.Text = ""
        txtengine.Text = ""
        txtfrnttnkcap.Text = ""
        txtfueltype.Text = ""
        txtmeterred.Text = ""
        txtnoofsets.Text = ""
        txtnooftyrs.Text = ""
        txtreartnkcap.Text = ""
        txtregsno.Text = ""
        txtregsno.ReadOnly = False
        txtstndmilg.Text = ""
        txttnkcap.Text = ""
        dtp1.Text = ""
        cobvehtyp.Text = ""
        cobdriver.Text = ""
        TabControl1.SelectedTab = TabPage2

    End Sub
    Public Sub delproc()
        If txtregsno.Text = "" Then
            MsgBox("Enter Regstartion No", MsgBoxStyle.OKOnly, Prjtitle)
            txtregsno.Focus()
        End If

        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim cmd As New OleDbCommand("update ownvehiclemaster set  Availab_Flag='N',Activ_Flag='N'where trim(regno)='" & Trim(txtregsno.Text) & "' ", con)

            Dim i As Byte
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgDel()
                'clears the controls
                clearproc()
            Else
                MsgBox("Record Not Found", MsgBoxStyle.OKOnly, Prjtitle)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try

    End Sub

    Public Sub editproc()

        txtchasisno.Enabled = True
        txtengine.Enabled = True
        txtfrnttnkcap.ReadOnly = True
        txtfrnttnkcap.Enabled = True
        txtfueltype.Enabled = True
        txtmeterred.Enabled = True
        txtnoofsets.Enabled = True
        txtnooftyrs.Enabled = True
        txtreartnkcap.Enabled = True
        txtregsno.ReadOnly = True
        txtstndmilg.Enabled = True
        txttnkcap.Enabled = True
        dtp1.Enabled = True
        cobvehtyp.Enabled = True
        cobdriver.Enabled = True
        'cobvehtyp = True
        'cobvehtype.Enabled = True
        recmode = Module1.EnuRecstatus.Recedit

    End Sub
    Public Sub newproc()
        txtengine.Enabled = True
        txtchasisno.Enabled = True
        txtengine.Enabled = True
        txtfrnttnkcap.Enabled = True
        txtfueltype.Enabled = True
        txtmeterred.Enabled = True
        txtnoofsets.Enabled = True
        txtnooftyrs.Enabled = True
        txtreartnkcap.Enabled = True
        txtregsno.Enabled = True
        txtregsno.ReadOnly = False
        txtstndmilg.Enabled = True
        txttnkcap.Enabled = True
        dtp1.Enabled = True
        cobvehtyp.Enabled = True
        cobvehtype.Enabled = True
        cobdriver.Enabled = True
        recmode = Module1.EnuRecstatus.Recnew
        TabControl1.SelectedTab = TabPage2
        txtregsno.Focus()

    End Sub

    Private Sub txtfrnttnkcap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfrnttnkcap.KeyPress, txtreartnkcap.KeyPress, txttnkcap.KeyPress, txtstndmilg.KeyPress, txtnoofsets.KeyPress, txtnooftyrs.KeyPress
        numberonly(e)
    End Sub
    Private Sub VEHICLE_Mast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        TabControl1.SelectedTab = TabPage2
        cobvehtype.Enabled = False
        txtengine.Enabled = False
        txtchasisno.Enabled = False
        txtengine.Enabled = False
        txtfrnttnkcap.Enabled = False
        txtfueltype.Enabled = False
        txtmeterred.Enabled = False
        txtnoofsets.Enabled = False
        txtnooftyrs.Enabled = False
        txtreartnkcap.Enabled = False
        txtregsno.Enabled = False
        txtstndmilg.Enabled = False
        txttnkcap.Enabled = False
        dtp1.Enabled = False
        cobvehtyp.Enabled = False
        cobdriver.Enabled = False
        'fills the driver combobox with employeeid and first name from employee master 
        combofill1(cobdriver, "select employeeid,firstname from employeemaster where department='Driver'")
        'fills the driver combobox with employeeid and first name from employee master 
        combofill1(cobvehtyp, "select vehtypeid,vehtype from veh_type")
        combofill1(cobvehtype, "select vehtypeid,vehtype from veh_type")

    End Sub

    Private Sub TabControl1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        ' Loads the data into the datagrid
        Openconnection()
        Dim da As New OleDbDataAdapter("select RegNo,RegDate,TankCapacity,VehTypeid,EngineNumber,ChasisNumber,EmployeeId from ownvehiclemaster where trim(Activ_Flag)='Y'", con)
        Dim ds As New DataSet
        Try
            da.Fill(ds, "vehi")
            DataGrid1.DataSource = ds.Tables("vehi")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub

        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub datagrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick

        'To display the selected reord in to the tabcontrols

        Dim j, k, driver, drivername As String
        k = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        Openconnection()
        Dim cmd As New OleDbCommand("select * from ownvehiclemaster where regno= '" & LTrim(k) & "'", con)
        Dim dr As OleDbDataReader

        Try
            dr = cmd.ExecuteReader
            While dr.Read

                txtchasisno.Text = dr(9) & ""
                txtengine.Text = dr(8) & ""
                txtfrnttnkcap.Text = dr(4) & ""
                txtfueltype.Text = dr(11) & ""
                txtmeterred.Text = dr(6) & ""
                txtnoofsets.Text = dr(12) & ""
                txtnooftyrs.Text = dr(10) & ""
                txtreartnkcap.Text = dr(5) & ""
                txtregsno.Text = dr(0)
                txtstndmilg.Text = dr(7) & ""
                txttnkcap.Text = dr(2) & ""
                dtp1.Text = dr(1)

                j = dr(13)


            End While
            CloseConnection()
            Dim intp As String = DataGrid1.Item(DataGrid1.CurrentRowIndex, 3)
            Dim str As String
            Openconnection()
            Dim cmd1 As New OleDbCommand("select vehtype from veh_type where vehtypeid='" & intp & " ' ", con)

            dr = cmd1.ExecuteReader
            cmd1.Dispose()
            If dr.Read Then
                cobvehtyp.Text = intp & "-" & dr(0)
                cobvehtyp.SelectedItem = intp & "-" & dr(0)

            End If
            CloseConnection()
            Openconnection()
            cmd1 = New OleDbCommand("select firstname from employeemaster where employeeid='" & j & "'", con)

            drivername = cmd1.ExecuteScalar
            driver = j & "-" & drivername
            cobdriver.SelectedText = driver
            cobdriver.Text = driver

            cmd1.Dispose()
            CloseConnection()


            txtchasisno.Enabled = False
            txtengine.Enabled = False
            txtfrnttnkcap.Enabled = False
            txtfueltype.Enabled = False
            txtmeterred.Enabled = False
            txtnoofsets.Enabled = False
            txtnooftyrs.Enabled = False
            txtreartnkcap.Enabled = False
            txtregsno.Enabled = False
            txtstndmilg.Enabled = False
            txttnkcap.Enabled = False

            dtp1.Enabled = False
            cobvehtyp.Enabled = False
            cobdriver.Enabled = False
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

    Private Sub cobvehtype_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobvehtype.SelectedValueChanged
        Dim str, b As String
        b = cobvehtype.SelectedItem
        str = (b.Substring(0, b.IndexOf("-")))
        Openconnection()
        Dim da As New OleDbDataAdapter("select RegNo,RegDate,TankCapacity,VehTypeid,EngineNumber,ChasisNumber,EmployeeId from ownvehiclemaster where ltrim(vehtypeid)= '" & str & " ' ", con)
        Dim ds As New DataSet
        Try
            da.Fill(ds, "v")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub

        Finally
            CloseConnection()

        End Try
        DataGrid1.DataSource = ds.Tables("v")
    End Sub

    Private Sub txtregsno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtregsno.KeyPress, txtmeterred.KeyPress, txtengine.KeyPress, txtchasisno.KeyPress, txtfueltype.KeyPress
        textandnumbers(e)
    End Sub

    Private Sub cobvehtyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobvehtyp.SelectedIndexChanged

    End Sub

    Private Sub cobvehtyp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobvehtyp.KeyPress
        combo(e)
    End Sub
End Class
