'Name developer: baskar.ch
'Dt:30/06/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class AgentMaster
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
    Friend WithEvents Cobagenttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cobagentype As System.Windows.Forms.ComboBox
    Friend WithEvents txtagentcode As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
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
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AgentMaster))
        Me.Tabcontrol1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cobagenttype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.cobagentype = New System.Windows.Forms.ComboBox
        Me.txtagentcode = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtlastname = New System.Windows.Forms.TextBox
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
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtfirstname = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Tabcontrol1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabcontrol1
        '
        Me.Tabcontrol1.AccessibleDescription = resources.GetString("Tabcontrol1.AccessibleDescription")
        Me.Tabcontrol1.AccessibleName = resources.GetString("Tabcontrol1.AccessibleName")
        Me.Tabcontrol1.Alignment = CType(resources.GetObject("Tabcontrol1.Alignment"), System.Windows.Forms.TabAlignment)
        Me.Tabcontrol1.Anchor = CType(resources.GetObject("Tabcontrol1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Tabcontrol1.Appearance = CType(resources.GetObject("Tabcontrol1.Appearance"), System.Windows.Forms.TabAppearance)
        Me.Tabcontrol1.BackgroundImage = CType(resources.GetObject("Tabcontrol1.BackgroundImage"), System.Drawing.Image)
        Me.Tabcontrol1.Controls.Add(Me.TabPage1)
        Me.Tabcontrol1.Controls.Add(Me.TabPage2)
        Me.Tabcontrol1.Dock = CType(resources.GetObject("Tabcontrol1.Dock"), System.Windows.Forms.DockStyle)
        Me.Tabcontrol1.Enabled = CType(resources.GetObject("Tabcontrol1.Enabled"), Boolean)
        Me.Tabcontrol1.Font = CType(resources.GetObject("Tabcontrol1.Font"), System.Drawing.Font)
        Me.Tabcontrol1.ImeMode = CType(resources.GetObject("Tabcontrol1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Tabcontrol1.ItemSize = CType(resources.GetObject("Tabcontrol1.ItemSize"), System.Drawing.Size)
        Me.Tabcontrol1.Location = CType(resources.GetObject("Tabcontrol1.Location"), System.Drawing.Point)
        Me.Tabcontrol1.Name = "Tabcontrol1"
        Me.Tabcontrol1.Padding = CType(resources.GetObject("Tabcontrol1.Padding"), System.Drawing.Point)
        Me.Tabcontrol1.RightToLeft = CType(resources.GetObject("Tabcontrol1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Tabcontrol1.SelectedIndex = 0
        Me.Tabcontrol1.ShowToolTips = CType(resources.GetObject("Tabcontrol1.ShowToolTips"), Boolean)
        Me.Tabcontrol1.Size = CType(resources.GetObject("Tabcontrol1.Size"), System.Drawing.Size)
        Me.Tabcontrol1.TabIndex = CType(resources.GetObject("Tabcontrol1.TabIndex"), Integer)
        Me.Tabcontrol1.Text = resources.GetString("Tabcontrol1.Text")
        Me.Tabcontrol1.Visible = CType(resources.GetObject("Tabcontrol1.Visible"), Boolean)
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleDescription = resources.GetString("TabPage1.AccessibleDescription")
        Me.TabPage1.AccessibleName = resources.GetString("TabPage1.AccessibleName")
        Me.TabPage1.Anchor = CType(resources.GetObject("TabPage1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage1.AutoScroll = CType(resources.GetObject("TabPage1.AutoScroll"), Boolean)
        Me.TabPage1.AutoScrollMargin = CType(resources.GetObject("TabPage1.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage1.AutoScrollMinSize = CType(resources.GetObject("TabPage1.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Dock = CType(resources.GetObject("TabPage1.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage1.Enabled = CType(resources.GetObject("TabPage1.Enabled"), Boolean)
        Me.TabPage1.Font = CType(resources.GetObject("TabPage1.Font"), System.Drawing.Font)
        Me.TabPage1.ImageIndex = CType(resources.GetObject("TabPage1.ImageIndex"), Integer)
        Me.TabPage1.ImeMode = CType(resources.GetObject("TabPage1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage1.Location = CType(resources.GetObject("TabPage1.Location"), System.Drawing.Point)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.RightToLeft = CType(resources.GetObject("TabPage1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage1.Size = CType(resources.GetObject("TabPage1.Size"), System.Drawing.Size)
        Me.TabPage1.TabIndex = CType(resources.GetObject("TabPage1.TabIndex"), Integer)
        Me.TabPage1.Text = resources.GetString("TabPage1.Text")
        Me.TabPage1.ToolTipText = resources.GetString("TabPage1.ToolTipText")
        Me.TabPage1.Visible = CType(resources.GetObject("TabPage1.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription")
        Me.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName")
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Cobagenttype)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dbgview)
        Me.GroupBox1.Dock = CType(resources.GetObject("GroupBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox1.Enabled = CType(resources.GetObject("GroupBox1.Enabled"), Boolean)
        Me.GroupBox1.Font = CType(resources.GetObject("GroupBox1.Font"), System.Drawing.Font)
        Me.GroupBox1.ImeMode = CType(resources.GetObject("GroupBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox1.Location = CType(resources.GetObject("GroupBox1.Location"), System.Drawing.Point)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = CType(resources.GetObject("GroupBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox1.Size = CType(resources.GetObject("GroupBox1.Size"), System.Drawing.Size)
        Me.GroupBox1.TabIndex = CType(resources.GetObject("GroupBox1.TabIndex"), Integer)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = resources.GetString("GroupBox1.Text")
        Me.GroupBox1.Visible = CType(resources.GetObject("GroupBox1.Visible"), Boolean)
        '
        'Cobagenttype
        '
        Me.Cobagenttype.AccessibleDescription = resources.GetString("Cobagenttype.AccessibleDescription")
        Me.Cobagenttype.AccessibleName = resources.GetString("Cobagenttype.AccessibleName")
        Me.Cobagenttype.Anchor = CType(resources.GetObject("Cobagenttype.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Cobagenttype.BackgroundImage = CType(resources.GetObject("Cobagenttype.BackgroundImage"), System.Drawing.Image)
        Me.Cobagenttype.Dock = CType(resources.GetObject("Cobagenttype.Dock"), System.Windows.Forms.DockStyle)
        Me.Cobagenttype.Enabled = CType(resources.GetObject("Cobagenttype.Enabled"), Boolean)
        Me.Cobagenttype.Font = CType(resources.GetObject("Cobagenttype.Font"), System.Drawing.Font)
        Me.Cobagenttype.ImeMode = CType(resources.GetObject("Cobagenttype.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Cobagenttype.IntegralHeight = CType(resources.GetObject("Cobagenttype.IntegralHeight"), Boolean)
        Me.Cobagenttype.ItemHeight = CType(resources.GetObject("Cobagenttype.ItemHeight"), Integer)
        Me.Cobagenttype.Location = CType(resources.GetObject("Cobagenttype.Location"), System.Drawing.Point)
        Me.Cobagenttype.MaxDropDownItems = CType(resources.GetObject("Cobagenttype.MaxDropDownItems"), Integer)
        Me.Cobagenttype.MaxLength = CType(resources.GetObject("Cobagenttype.MaxLength"), Integer)
        Me.Cobagenttype.Name = "Cobagenttype"
        Me.Cobagenttype.RightToLeft = CType(resources.GetObject("Cobagenttype.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Cobagenttype.Size = CType(resources.GetObject("Cobagenttype.Size"), System.Drawing.Size)
        Me.Cobagenttype.TabIndex = CType(resources.GetObject("Cobagenttype.TabIndex"), Integer)
        Me.Cobagenttype.Text = resources.GetString("Cobagenttype.Text")
        Me.Cobagenttype.Visible = CType(resources.GetObject("Cobagenttype.Visible"), Boolean)
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = resources.GetString("Label3.AccessibleDescription")
        Me.Label3.AccessibleName = resources.GetString("Label3.AccessibleName")
        Me.Label3.Anchor = CType(resources.GetObject("Label3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = CType(resources.GetObject("Label3.AutoSize"), Boolean)
        Me.Label3.Dock = CType(resources.GetObject("Label3.Dock"), System.Windows.Forms.DockStyle)
        Me.Label3.Enabled = CType(resources.GetObject("Label3.Enabled"), Boolean)
        Me.Label3.Font = CType(resources.GetObject("Label3.Font"), System.Drawing.Font)
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = CType(resources.GetObject("Label3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label3.ImageIndex = CType(resources.GetObject("Label3.ImageIndex"), Integer)
        Me.Label3.ImeMode = CType(resources.GetObject("Label3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label3.Location = CType(resources.GetObject("Label3.Location"), System.Drawing.Point)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = CType(resources.GetObject("Label3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label3.Size = CType(resources.GetObject("Label3.Size"), System.Drawing.Size)
        Me.Label3.TabIndex = CType(resources.GetObject("Label3.TabIndex"), Integer)
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = CType(resources.GetObject("Label3.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label3.Visible = CType(resources.GetObject("Label3.Visible"), Boolean)
        '
        'dbgview
        '
        Me.dbgview.AccessibleDescription = resources.GetString("dbgview.AccessibleDescription")
        Me.dbgview.AccessibleName = resources.GetString("dbgview.AccessibleName")
        Me.dbgview.Anchor = CType(resources.GetObject("dbgview.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.dbgview.BackgroundImage = CType(resources.GetObject("dbgview.BackgroundImage"), System.Drawing.Image)
        Me.dbgview.CaptionFont = CType(resources.GetObject("dbgview.CaptionFont"), System.Drawing.Font)
        Me.dbgview.CaptionText = resources.GetString("dbgview.CaptionText")
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.Dock = CType(resources.GetObject("dbgview.Dock"), System.Windows.Forms.DockStyle)
        Me.dbgview.Enabled = CType(resources.GetObject("dbgview.Enabled"), Boolean)
        Me.dbgview.Font = CType(resources.GetObject("dbgview.Font"), System.Drawing.Font)
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.ImeMode = CType(resources.GetObject("dbgview.ImeMode"), System.Windows.Forms.ImeMode)
        Me.dbgview.Location = CType(resources.GetObject("dbgview.Location"), System.Drawing.Point)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.RightToLeft = CType(resources.GetObject("dbgview.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.dbgview.Size = CType(resources.GetObject("dbgview.Size"), System.Drawing.Size)
        Me.dbgview.TabIndex = CType(resources.GetObject("dbgview.TabIndex"), Integer)
        Me.dbgview.Visible = CType(resources.GetObject("dbgview.Visible"), Boolean)
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleDescription = resources.GetString("TabPage2.AccessibleDescription")
        Me.TabPage2.AccessibleName = resources.GetString("TabPage2.AccessibleName")
        Me.TabPage2.Anchor = CType(resources.GetObject("TabPage2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage2.AutoScroll = CType(resources.GetObject("TabPage2.AutoScroll"), Boolean)
        Me.TabPage2.AutoScrollMargin = CType(resources.GetObject("TabPage2.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage2.AutoScrollMinSize = CType(resources.GetObject("TabPage2.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.cobagentype)
        Me.TabPage2.Controls.Add(Me.txtagentcode)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtlastname)
        Me.TabPage2.Controls.Add(Me.txtfaxno)
        Me.TabPage2.Controls.Add(Me.txtremarks)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtmobile)
        Me.TabPage2.Controls.Add(Me.txtworkphone)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.txtzip)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cobcountry)
        Me.TabPage2.Controls.Add(Me.cobcity)
        Me.TabPage2.Controls.Add(Me.cobstate)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txtemailid)
        Me.TabPage2.Controls.Add(Me.txtaddress)
        Me.TabPage2.Controls.Add(Me.txtaddress1)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.txtfirstname)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Dock = CType(resources.GetObject("TabPage2.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage2.Enabled = CType(resources.GetObject("TabPage2.Enabled"), Boolean)
        Me.TabPage2.Font = CType(resources.GetObject("TabPage2.Font"), System.Drawing.Font)
        Me.TabPage2.ImageIndex = CType(resources.GetObject("TabPage2.ImageIndex"), Integer)
        Me.TabPage2.ImeMode = CType(resources.GetObject("TabPage2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage2.Location = CType(resources.GetObject("TabPage2.Location"), System.Drawing.Point)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.RightToLeft = CType(resources.GetObject("TabPage2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage2.Size = CType(resources.GetObject("TabPage2.Size"), System.Drawing.Size)
        Me.TabPage2.TabIndex = CType(resources.GetObject("TabPage2.TabIndex"), Integer)
        Me.TabPage2.Text = resources.GetString("TabPage2.Text")
        Me.TabPage2.ToolTipText = resources.GetString("TabPage2.ToolTipText")
        Me.TabPage2.Visible = CType(resources.GetObject("TabPage2.Visible"), Boolean)
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = resources.GetString("Label4.AccessibleDescription")
        Me.Label4.AccessibleName = resources.GetString("Label4.AccessibleName")
        Me.Label4.Anchor = CType(resources.GetObject("Label4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = CType(resources.GetObject("Label4.AutoSize"), Boolean)
        Me.Label4.Dock = CType(resources.GetObject("Label4.Dock"), System.Windows.Forms.DockStyle)
        Me.Label4.Enabled = CType(resources.GetObject("Label4.Enabled"), Boolean)
        Me.Label4.Font = CType(resources.GetObject("Label4.Font"), System.Drawing.Font)
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = CType(resources.GetObject("Label4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label4.ImageIndex = CType(resources.GetObject("Label4.ImageIndex"), Integer)
        Me.Label4.ImeMode = CType(resources.GetObject("Label4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label4.Location = CType(resources.GetObject("Label4.Location"), System.Drawing.Point)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = CType(resources.GetObject("Label4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label4.Size = CType(resources.GetObject("Label4.Size"), System.Drawing.Size)
        Me.Label4.TabIndex = CType(resources.GetObject("Label4.TabIndex"), Integer)
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = CType(resources.GetObject("Label4.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label4.Visible = CType(resources.GetObject("Label4.Visible"), Boolean)
        '
        'cobagentype
        '
        Me.cobagentype.AccessibleDescription = resources.GetString("cobagentype.AccessibleDescription")
        Me.cobagentype.AccessibleName = resources.GetString("cobagentype.AccessibleName")
        Me.cobagentype.Anchor = CType(resources.GetObject("cobagentype.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cobagentype.BackgroundImage = CType(resources.GetObject("cobagentype.BackgroundImage"), System.Drawing.Image)
        Me.cobagentype.Dock = CType(resources.GetObject("cobagentype.Dock"), System.Windows.Forms.DockStyle)
        Me.cobagentype.Enabled = CType(resources.GetObject("cobagentype.Enabled"), Boolean)
        Me.cobagentype.Font = CType(resources.GetObject("cobagentype.Font"), System.Drawing.Font)
        Me.cobagentype.ImeMode = CType(resources.GetObject("cobagentype.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cobagentype.IntegralHeight = CType(resources.GetObject("cobagentype.IntegralHeight"), Boolean)
        Me.cobagentype.ItemHeight = CType(resources.GetObject("cobagentype.ItemHeight"), Integer)
        Me.cobagentype.Location = CType(resources.GetObject("cobagentype.Location"), System.Drawing.Point)
        Me.cobagentype.MaxDropDownItems = CType(resources.GetObject("cobagentype.MaxDropDownItems"), Integer)
        Me.cobagentype.MaxLength = CType(resources.GetObject("cobagentype.MaxLength"), Integer)
        Me.cobagentype.Name = "cobagentype"
        Me.cobagentype.RightToLeft = CType(resources.GetObject("cobagentype.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cobagentype.Size = CType(resources.GetObject("cobagentype.Size"), System.Drawing.Size)
        Me.cobagentype.TabIndex = CType(resources.GetObject("cobagentype.TabIndex"), Integer)
        Me.cobagentype.Text = resources.GetString("cobagentype.Text")
        Me.cobagentype.Visible = CType(resources.GetObject("cobagentype.Visible"), Boolean)
        '
        'txtagentcode
        '
        Me.txtagentcode.AccessibleDescription = resources.GetString("txtagentcode.AccessibleDescription")
        Me.txtagentcode.AccessibleName = resources.GetString("txtagentcode.AccessibleName")
        Me.txtagentcode.Anchor = CType(resources.GetObject("txtagentcode.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtagentcode.AutoSize = CType(resources.GetObject("txtagentcode.AutoSize"), Boolean)
        Me.txtagentcode.BackgroundImage = CType(resources.GetObject("txtagentcode.BackgroundImage"), System.Drawing.Image)
        Me.txtagentcode.Dock = CType(resources.GetObject("txtagentcode.Dock"), System.Windows.Forms.DockStyle)
        Me.txtagentcode.Enabled = CType(resources.GetObject("txtagentcode.Enabled"), Boolean)
        Me.txtagentcode.Font = CType(resources.GetObject("txtagentcode.Font"), System.Drawing.Font)
        Me.txtagentcode.ImeMode = CType(resources.GetObject("txtagentcode.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtagentcode.Location = CType(resources.GetObject("txtagentcode.Location"), System.Drawing.Point)
        Me.txtagentcode.MaxLength = CType(resources.GetObject("txtagentcode.MaxLength"), Integer)
        Me.txtagentcode.Multiline = CType(resources.GetObject("txtagentcode.Multiline"), Boolean)
        Me.txtagentcode.Name = "txtagentcode"
        Me.txtagentcode.PasswordChar = CType(resources.GetObject("txtagentcode.PasswordChar"), Char)
        Me.txtagentcode.RightToLeft = CType(resources.GetObject("txtagentcode.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtagentcode.ScrollBars = CType(resources.GetObject("txtagentcode.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtagentcode.Size = CType(resources.GetObject("txtagentcode.Size"), System.Drawing.Size)
        Me.txtagentcode.TabIndex = CType(resources.GetObject("txtagentcode.TabIndex"), Integer)
        Me.txtagentcode.Text = resources.GetString("txtagentcode.Text")
        Me.txtagentcode.TextAlign = CType(resources.GetObject("txtagentcode.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtagentcode.Visible = CType(resources.GetObject("txtagentcode.Visible"), Boolean)
        Me.txtagentcode.WordWrap = CType(resources.GetObject("txtagentcode.WordWrap"), Boolean)
        '
        'Label16
        '
        Me.Label16.AccessibleDescription = resources.GetString("Label16.AccessibleDescription")
        Me.Label16.AccessibleName = resources.GetString("Label16.AccessibleName")
        Me.Label16.Anchor = CType(resources.GetObject("Label16.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = CType(resources.GetObject("Label16.AutoSize"), Boolean)
        Me.Label16.Dock = CType(resources.GetObject("Label16.Dock"), System.Windows.Forms.DockStyle)
        Me.Label16.Enabled = CType(resources.GetObject("Label16.Enabled"), Boolean)
        Me.Label16.Font = CType(resources.GetObject("Label16.Font"), System.Drawing.Font)
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.ImageAlign = CType(resources.GetObject("Label16.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label16.ImageIndex = CType(resources.GetObject("Label16.ImageIndex"), Integer)
        Me.Label16.ImeMode = CType(resources.GetObject("Label16.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label16.Location = CType(resources.GetObject("Label16.Location"), System.Drawing.Point)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = CType(resources.GetObject("Label16.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label16.Size = CType(resources.GetObject("Label16.Size"), System.Drawing.Size)
        Me.Label16.TabIndex = CType(resources.GetObject("Label16.TabIndex"), Integer)
        Me.Label16.Text = resources.GetString("Label16.Text")
        Me.Label16.TextAlign = CType(resources.GetObject("Label16.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label16.Visible = CType(resources.GetObject("Label16.Visible"), Boolean)
        '
        'txtlastname
        '
        Me.txtlastname.AccessibleDescription = resources.GetString("txtlastname.AccessibleDescription")
        Me.txtlastname.AccessibleName = resources.GetString("txtlastname.AccessibleName")
        Me.txtlastname.Anchor = CType(resources.GetObject("txtlastname.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtlastname.AutoSize = CType(resources.GetObject("txtlastname.AutoSize"), Boolean)
        Me.txtlastname.BackgroundImage = CType(resources.GetObject("txtlastname.BackgroundImage"), System.Drawing.Image)
        Me.txtlastname.Dock = CType(resources.GetObject("txtlastname.Dock"), System.Windows.Forms.DockStyle)
        Me.txtlastname.Enabled = CType(resources.GetObject("txtlastname.Enabled"), Boolean)
        Me.txtlastname.Font = CType(resources.GetObject("txtlastname.Font"), System.Drawing.Font)
        Me.txtlastname.ImeMode = CType(resources.GetObject("txtlastname.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtlastname.Location = CType(resources.GetObject("txtlastname.Location"), System.Drawing.Point)
        Me.txtlastname.MaxLength = CType(resources.GetObject("txtlastname.MaxLength"), Integer)
        Me.txtlastname.Multiline = CType(resources.GetObject("txtlastname.Multiline"), Boolean)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = CType(resources.GetObject("txtlastname.PasswordChar"), Char)
        Me.txtlastname.RightToLeft = CType(resources.GetObject("txtlastname.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtlastname.ScrollBars = CType(resources.GetObject("txtlastname.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtlastname.Size = CType(resources.GetObject("txtlastname.Size"), System.Drawing.Size)
        Me.txtlastname.TabIndex = CType(resources.GetObject("txtlastname.TabIndex"), Integer)
        Me.txtlastname.Text = resources.GetString("txtlastname.Text")
        Me.txtlastname.TextAlign = CType(resources.GetObject("txtlastname.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtlastname.Visible = CType(resources.GetObject("txtlastname.Visible"), Boolean)
        Me.txtlastname.WordWrap = CType(resources.GetObject("txtlastname.WordWrap"), Boolean)
        '
        'txtfaxno
        '
        Me.txtfaxno.AccessibleDescription = resources.GetString("txtfaxno.AccessibleDescription")
        Me.txtfaxno.AccessibleName = resources.GetString("txtfaxno.AccessibleName")
        Me.txtfaxno.Anchor = CType(resources.GetObject("txtfaxno.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtfaxno.AutoSize = CType(resources.GetObject("txtfaxno.AutoSize"), Boolean)
        Me.txtfaxno.BackgroundImage = CType(resources.GetObject("txtfaxno.BackgroundImage"), System.Drawing.Image)
        Me.txtfaxno.Dock = CType(resources.GetObject("txtfaxno.Dock"), System.Windows.Forms.DockStyle)
        Me.txtfaxno.Enabled = CType(resources.GetObject("txtfaxno.Enabled"), Boolean)
        Me.txtfaxno.Font = CType(resources.GetObject("txtfaxno.Font"), System.Drawing.Font)
        Me.txtfaxno.ImeMode = CType(resources.GetObject("txtfaxno.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtfaxno.Location = CType(resources.GetObject("txtfaxno.Location"), System.Drawing.Point)
        Me.txtfaxno.MaxLength = CType(resources.GetObject("txtfaxno.MaxLength"), Integer)
        Me.txtfaxno.Multiline = CType(resources.GetObject("txtfaxno.Multiline"), Boolean)
        Me.txtfaxno.Name = "txtfaxno"
        Me.txtfaxno.PasswordChar = CType(resources.GetObject("txtfaxno.PasswordChar"), Char)
        Me.txtfaxno.RightToLeft = CType(resources.GetObject("txtfaxno.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtfaxno.ScrollBars = CType(resources.GetObject("txtfaxno.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtfaxno.Size = CType(resources.GetObject("txtfaxno.Size"), System.Drawing.Size)
        Me.txtfaxno.TabIndex = CType(resources.GetObject("txtfaxno.TabIndex"), Integer)
        Me.txtfaxno.Text = resources.GetString("txtfaxno.Text")
        Me.txtfaxno.TextAlign = CType(resources.GetObject("txtfaxno.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtfaxno.Visible = CType(resources.GetObject("txtfaxno.Visible"), Boolean)
        Me.txtfaxno.WordWrap = CType(resources.GetObject("txtfaxno.WordWrap"), Boolean)
        '
        'txtremarks
        '
        Me.txtremarks.AccessibleDescription = resources.GetString("txtremarks.AccessibleDescription")
        Me.txtremarks.AccessibleName = resources.GetString("txtremarks.AccessibleName")
        Me.txtremarks.Anchor = CType(resources.GetObject("txtremarks.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtremarks.AutoSize = CType(resources.GetObject("txtremarks.AutoSize"), Boolean)
        Me.txtremarks.BackgroundImage = CType(resources.GetObject("txtremarks.BackgroundImage"), System.Drawing.Image)
        Me.txtremarks.Dock = CType(resources.GetObject("txtremarks.Dock"), System.Windows.Forms.DockStyle)
        Me.txtremarks.Enabled = CType(resources.GetObject("txtremarks.Enabled"), Boolean)
        Me.txtremarks.Font = CType(resources.GetObject("txtremarks.Font"), System.Drawing.Font)
        Me.txtremarks.ImeMode = CType(resources.GetObject("txtremarks.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtremarks.Location = CType(resources.GetObject("txtremarks.Location"), System.Drawing.Point)
        Me.txtremarks.MaxLength = CType(resources.GetObject("txtremarks.MaxLength"), Integer)
        Me.txtremarks.Multiline = CType(resources.GetObject("txtremarks.Multiline"), Boolean)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.PasswordChar = CType(resources.GetObject("txtremarks.PasswordChar"), Char)
        Me.txtremarks.RightToLeft = CType(resources.GetObject("txtremarks.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtremarks.ScrollBars = CType(resources.GetObject("txtremarks.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtremarks.Size = CType(resources.GetObject("txtremarks.Size"), System.Drawing.Size)
        Me.txtremarks.TabIndex = CType(resources.GetObject("txtremarks.TabIndex"), Integer)
        Me.txtremarks.Text = resources.GetString("txtremarks.Text")
        Me.txtremarks.TextAlign = CType(resources.GetObject("txtremarks.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtremarks.Visible = CType(resources.GetObject("txtremarks.Visible"), Boolean)
        Me.txtremarks.WordWrap = CType(resources.GetObject("txtremarks.WordWrap"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription")
        Me.Label2.AccessibleName = resources.GetString("Label2.AccessibleName")
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'txtmobile
        '
        Me.txtmobile.AccessibleDescription = resources.GetString("txtmobile.AccessibleDescription")
        Me.txtmobile.AccessibleName = resources.GetString("txtmobile.AccessibleName")
        Me.txtmobile.Anchor = CType(resources.GetObject("txtmobile.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtmobile.AutoSize = CType(resources.GetObject("txtmobile.AutoSize"), Boolean)
        Me.txtmobile.BackgroundImage = CType(resources.GetObject("txtmobile.BackgroundImage"), System.Drawing.Image)
        Me.txtmobile.Dock = CType(resources.GetObject("txtmobile.Dock"), System.Windows.Forms.DockStyle)
        Me.txtmobile.Enabled = CType(resources.GetObject("txtmobile.Enabled"), Boolean)
        Me.txtmobile.Font = CType(resources.GetObject("txtmobile.Font"), System.Drawing.Font)
        Me.txtmobile.ImeMode = CType(resources.GetObject("txtmobile.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtmobile.Location = CType(resources.GetObject("txtmobile.Location"), System.Drawing.Point)
        Me.txtmobile.MaxLength = CType(resources.GetObject("txtmobile.MaxLength"), Integer)
        Me.txtmobile.Multiline = CType(resources.GetObject("txtmobile.Multiline"), Boolean)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.PasswordChar = CType(resources.GetObject("txtmobile.PasswordChar"), Char)
        Me.txtmobile.RightToLeft = CType(resources.GetObject("txtmobile.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtmobile.ScrollBars = CType(resources.GetObject("txtmobile.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtmobile.Size = CType(resources.GetObject("txtmobile.Size"), System.Drawing.Size)
        Me.txtmobile.TabIndex = CType(resources.GetObject("txtmobile.TabIndex"), Integer)
        Me.txtmobile.Text = resources.GetString("txtmobile.Text")
        Me.txtmobile.TextAlign = CType(resources.GetObject("txtmobile.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtmobile.Visible = CType(resources.GetObject("txtmobile.Visible"), Boolean)
        Me.txtmobile.WordWrap = CType(resources.GetObject("txtmobile.WordWrap"), Boolean)
        '
        'txtworkphone
        '
        Me.txtworkphone.AccessibleDescription = resources.GetString("txtworkphone.AccessibleDescription")
        Me.txtworkphone.AccessibleName = resources.GetString("txtworkphone.AccessibleName")
        Me.txtworkphone.Anchor = CType(resources.GetObject("txtworkphone.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtworkphone.AutoSize = CType(resources.GetObject("txtworkphone.AutoSize"), Boolean)
        Me.txtworkphone.BackgroundImage = CType(resources.GetObject("txtworkphone.BackgroundImage"), System.Drawing.Image)
        Me.txtworkphone.Dock = CType(resources.GetObject("txtworkphone.Dock"), System.Windows.Forms.DockStyle)
        Me.txtworkphone.Enabled = CType(resources.GetObject("txtworkphone.Enabled"), Boolean)
        Me.txtworkphone.Font = CType(resources.GetObject("txtworkphone.Font"), System.Drawing.Font)
        Me.txtworkphone.ImeMode = CType(resources.GetObject("txtworkphone.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtworkphone.Location = CType(resources.GetObject("txtworkphone.Location"), System.Drawing.Point)
        Me.txtworkphone.MaxLength = CType(resources.GetObject("txtworkphone.MaxLength"), Integer)
        Me.txtworkphone.Multiline = CType(resources.GetObject("txtworkphone.Multiline"), Boolean)
        Me.txtworkphone.Name = "txtworkphone"
        Me.txtworkphone.PasswordChar = CType(resources.GetObject("txtworkphone.PasswordChar"), Char)
        Me.txtworkphone.RightToLeft = CType(resources.GetObject("txtworkphone.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtworkphone.ScrollBars = CType(resources.GetObject("txtworkphone.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtworkphone.Size = CType(resources.GetObject("txtworkphone.Size"), System.Drawing.Size)
        Me.txtworkphone.TabIndex = CType(resources.GetObject("txtworkphone.TabIndex"), Integer)
        Me.txtworkphone.Text = resources.GetString("txtworkphone.Text")
        Me.txtworkphone.TextAlign = CType(resources.GetObject("txtworkphone.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtworkphone.Visible = CType(resources.GetObject("txtworkphone.Visible"), Boolean)
        Me.txtworkphone.WordWrap = CType(resources.GetObject("txtworkphone.WordWrap"), Boolean)
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = resources.GetString("Label7.AccessibleDescription")
        Me.Label7.AccessibleName = resources.GetString("Label7.AccessibleName")
        Me.Label7.Anchor = CType(resources.GetObject("Label7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = CType(resources.GetObject("Label7.AutoSize"), Boolean)
        Me.Label7.Dock = CType(resources.GetObject("Label7.Dock"), System.Windows.Forms.DockStyle)
        Me.Label7.Enabled = CType(resources.GetObject("Label7.Enabled"), Boolean)
        Me.Label7.Font = CType(resources.GetObject("Label7.Font"), System.Drawing.Font)
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = CType(resources.GetObject("Label7.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label7.ImageIndex = CType(resources.GetObject("Label7.ImageIndex"), Integer)
        Me.Label7.ImeMode = CType(resources.GetObject("Label7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label7.Location = CType(resources.GetObject("Label7.Location"), System.Drawing.Point)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = CType(resources.GetObject("Label7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label7.Size = CType(resources.GetObject("Label7.Size"), System.Drawing.Size)
        Me.Label7.TabIndex = CType(resources.GetObject("Label7.TabIndex"), Integer)
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = CType(resources.GetObject("Label7.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label7.Visible = CType(resources.GetObject("Label7.Visible"), Boolean)
        '
        'Label18
        '
        Me.Label18.AccessibleDescription = resources.GetString("Label18.AccessibleDescription")
        Me.Label18.AccessibleName = resources.GetString("Label18.AccessibleName")
        Me.Label18.Anchor = CType(resources.GetObject("Label18.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = CType(resources.GetObject("Label18.AutoSize"), Boolean)
        Me.Label18.Dock = CType(resources.GetObject("Label18.Dock"), System.Windows.Forms.DockStyle)
        Me.Label18.Enabled = CType(resources.GetObject("Label18.Enabled"), Boolean)
        Me.Label18.Font = CType(resources.GetObject("Label18.Font"), System.Drawing.Font)
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.ImageAlign = CType(resources.GetObject("Label18.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label18.ImageIndex = CType(resources.GetObject("Label18.ImageIndex"), Integer)
        Me.Label18.ImeMode = CType(resources.GetObject("Label18.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label18.Location = CType(resources.GetObject("Label18.Location"), System.Drawing.Point)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = CType(resources.GetObject("Label18.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label18.Size = CType(resources.GetObject("Label18.Size"), System.Drawing.Size)
        Me.Label18.TabIndex = CType(resources.GetObject("Label18.TabIndex"), Integer)
        Me.Label18.Text = resources.GetString("Label18.Text")
        Me.Label18.TextAlign = CType(resources.GetObject("Label18.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label18.Visible = CType(resources.GetObject("Label18.Visible"), Boolean)
        '
        'txtzip
        '
        Me.txtzip.AccessibleDescription = resources.GetString("txtzip.AccessibleDescription")
        Me.txtzip.AccessibleName = resources.GetString("txtzip.AccessibleName")
        Me.txtzip.Anchor = CType(resources.GetObject("txtzip.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtzip.AutoSize = CType(resources.GetObject("txtzip.AutoSize"), Boolean)
        Me.txtzip.BackgroundImage = CType(resources.GetObject("txtzip.BackgroundImage"), System.Drawing.Image)
        Me.txtzip.Dock = CType(resources.GetObject("txtzip.Dock"), System.Windows.Forms.DockStyle)
        Me.txtzip.Enabled = CType(resources.GetObject("txtzip.Enabled"), Boolean)
        Me.txtzip.Font = CType(resources.GetObject("txtzip.Font"), System.Drawing.Font)
        Me.txtzip.ImeMode = CType(resources.GetObject("txtzip.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtzip.Location = CType(resources.GetObject("txtzip.Location"), System.Drawing.Point)
        Me.txtzip.MaxLength = CType(resources.GetObject("txtzip.MaxLength"), Integer)
        Me.txtzip.Multiline = CType(resources.GetObject("txtzip.Multiline"), Boolean)
        Me.txtzip.Name = "txtzip"
        Me.txtzip.PasswordChar = CType(resources.GetObject("txtzip.PasswordChar"), Char)
        Me.txtzip.RightToLeft = CType(resources.GetObject("txtzip.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtzip.ScrollBars = CType(resources.GetObject("txtzip.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtzip.Size = CType(resources.GetObject("txtzip.Size"), System.Drawing.Size)
        Me.txtzip.TabIndex = CType(resources.GetObject("txtzip.TabIndex"), Integer)
        Me.txtzip.Text = resources.GetString("txtzip.Text")
        Me.txtzip.TextAlign = CType(resources.GetObject("txtzip.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtzip.Visible = CType(resources.GetObject("txtzip.Visible"), Boolean)
        Me.txtzip.WordWrap = CType(resources.GetObject("txtzip.WordWrap"), Boolean)
        '
        'Label19
        '
        Me.Label19.AccessibleDescription = resources.GetString("Label19.AccessibleDescription")
        Me.Label19.AccessibleName = resources.GetString("Label19.AccessibleName")
        Me.Label19.Anchor = CType(resources.GetObject("Label19.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = CType(resources.GetObject("Label19.AutoSize"), Boolean)
        Me.Label19.Dock = CType(resources.GetObject("Label19.Dock"), System.Windows.Forms.DockStyle)
        Me.Label19.Enabled = CType(resources.GetObject("Label19.Enabled"), Boolean)
        Me.Label19.Font = CType(resources.GetObject("Label19.Font"), System.Drawing.Font)
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = CType(resources.GetObject("Label19.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label19.ImageIndex = CType(resources.GetObject("Label19.ImageIndex"), Integer)
        Me.Label19.ImeMode = CType(resources.GetObject("Label19.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label19.Location = CType(resources.GetObject("Label19.Location"), System.Drawing.Point)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = CType(resources.GetObject("Label19.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label19.Size = CType(resources.GetObject("Label19.Size"), System.Drawing.Size)
        Me.Label19.TabIndex = CType(resources.GetObject("Label19.TabIndex"), Integer)
        Me.Label19.Text = resources.GetString("Label19.Text")
        Me.Label19.TextAlign = CType(resources.GetObject("Label19.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label19.Visible = CType(resources.GetObject("Label19.Visible"), Boolean)
        '
        'Label20
        '
        Me.Label20.AccessibleDescription = resources.GetString("Label20.AccessibleDescription")
        Me.Label20.AccessibleName = resources.GetString("Label20.AccessibleName")
        Me.Label20.Anchor = CType(resources.GetObject("Label20.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = CType(resources.GetObject("Label20.AutoSize"), Boolean)
        Me.Label20.Dock = CType(resources.GetObject("Label20.Dock"), System.Windows.Forms.DockStyle)
        Me.Label20.Enabled = CType(resources.GetObject("Label20.Enabled"), Boolean)
        Me.Label20.Font = CType(resources.GetObject("Label20.Font"), System.Drawing.Font)
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.ImageAlign = CType(resources.GetObject("Label20.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label20.ImageIndex = CType(resources.GetObject("Label20.ImageIndex"), Integer)
        Me.Label20.ImeMode = CType(resources.GetObject("Label20.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label20.Location = CType(resources.GetObject("Label20.Location"), System.Drawing.Point)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = CType(resources.GetObject("Label20.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label20.Size = CType(resources.GetObject("Label20.Size"), System.Drawing.Size)
        Me.Label20.TabIndex = CType(resources.GetObject("Label20.TabIndex"), Integer)
        Me.Label20.Text = resources.GetString("Label20.Text")
        Me.Label20.TextAlign = CType(resources.GetObject("Label20.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label20.Visible = CType(resources.GetObject("Label20.Visible"), Boolean)
        '
        'cobcountry
        '
        Me.cobcountry.AccessibleDescription = resources.GetString("cobcountry.AccessibleDescription")
        Me.cobcountry.AccessibleName = resources.GetString("cobcountry.AccessibleName")
        Me.cobcountry.Anchor = CType(resources.GetObject("cobcountry.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cobcountry.BackgroundImage = CType(resources.GetObject("cobcountry.BackgroundImage"), System.Drawing.Image)
        Me.cobcountry.Dock = CType(resources.GetObject("cobcountry.Dock"), System.Windows.Forms.DockStyle)
        Me.cobcountry.Enabled = CType(resources.GetObject("cobcountry.Enabled"), Boolean)
        Me.cobcountry.Font = CType(resources.GetObject("cobcountry.Font"), System.Drawing.Font)
        Me.cobcountry.ImeMode = CType(resources.GetObject("cobcountry.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cobcountry.IntegralHeight = CType(resources.GetObject("cobcountry.IntegralHeight"), Boolean)
        Me.cobcountry.ItemHeight = CType(resources.GetObject("cobcountry.ItemHeight"), Integer)
        Me.cobcountry.Location = CType(resources.GetObject("cobcountry.Location"), System.Drawing.Point)
        Me.cobcountry.MaxDropDownItems = CType(resources.GetObject("cobcountry.MaxDropDownItems"), Integer)
        Me.cobcountry.MaxLength = CType(resources.GetObject("cobcountry.MaxLength"), Integer)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.RightToLeft = CType(resources.GetObject("cobcountry.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cobcountry.Size = CType(resources.GetObject("cobcountry.Size"), System.Drawing.Size)
        Me.cobcountry.TabIndex = CType(resources.GetObject("cobcountry.TabIndex"), Integer)
        Me.cobcountry.Text = resources.GetString("cobcountry.Text")
        Me.cobcountry.Visible = CType(resources.GetObject("cobcountry.Visible"), Boolean)
        '
        'cobcity
        '
        Me.cobcity.AccessibleDescription = resources.GetString("cobcity.AccessibleDescription")
        Me.cobcity.AccessibleName = resources.GetString("cobcity.AccessibleName")
        Me.cobcity.Anchor = CType(resources.GetObject("cobcity.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cobcity.BackgroundImage = CType(resources.GetObject("cobcity.BackgroundImage"), System.Drawing.Image)
        Me.cobcity.Dock = CType(resources.GetObject("cobcity.Dock"), System.Windows.Forms.DockStyle)
        Me.cobcity.Enabled = CType(resources.GetObject("cobcity.Enabled"), Boolean)
        Me.cobcity.Font = CType(resources.GetObject("cobcity.Font"), System.Drawing.Font)
        Me.cobcity.ImeMode = CType(resources.GetObject("cobcity.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cobcity.IntegralHeight = CType(resources.GetObject("cobcity.IntegralHeight"), Boolean)
        Me.cobcity.ItemHeight = CType(resources.GetObject("cobcity.ItemHeight"), Integer)
        Me.cobcity.Location = CType(resources.GetObject("cobcity.Location"), System.Drawing.Point)
        Me.cobcity.MaxDropDownItems = CType(resources.GetObject("cobcity.MaxDropDownItems"), Integer)
        Me.cobcity.MaxLength = CType(resources.GetObject("cobcity.MaxLength"), Integer)
        Me.cobcity.Name = "cobcity"
        Me.cobcity.RightToLeft = CType(resources.GetObject("cobcity.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cobcity.Size = CType(resources.GetObject("cobcity.Size"), System.Drawing.Size)
        Me.cobcity.TabIndex = CType(resources.GetObject("cobcity.TabIndex"), Integer)
        Me.cobcity.Text = resources.GetString("cobcity.Text")
        Me.cobcity.Visible = CType(resources.GetObject("cobcity.Visible"), Boolean)
        '
        'cobstate
        '
        Me.cobstate.AccessibleDescription = resources.GetString("cobstate.AccessibleDescription")
        Me.cobstate.AccessibleName = resources.GetString("cobstate.AccessibleName")
        Me.cobstate.Anchor = CType(resources.GetObject("cobstate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cobstate.BackgroundImage = CType(resources.GetObject("cobstate.BackgroundImage"), System.Drawing.Image)
        Me.cobstate.Dock = CType(resources.GetObject("cobstate.Dock"), System.Windows.Forms.DockStyle)
        Me.cobstate.Enabled = CType(resources.GetObject("cobstate.Enabled"), Boolean)
        Me.cobstate.Font = CType(resources.GetObject("cobstate.Font"), System.Drawing.Font)
        Me.cobstate.ImeMode = CType(resources.GetObject("cobstate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cobstate.IntegralHeight = CType(resources.GetObject("cobstate.IntegralHeight"), Boolean)
        Me.cobstate.ItemHeight = CType(resources.GetObject("cobstate.ItemHeight"), Integer)
        Me.cobstate.Location = CType(resources.GetObject("cobstate.Location"), System.Drawing.Point)
        Me.cobstate.MaxDropDownItems = CType(resources.GetObject("cobstate.MaxDropDownItems"), Integer)
        Me.cobstate.MaxLength = CType(resources.GetObject("cobstate.MaxLength"), Integer)
        Me.cobstate.Name = "cobstate"
        Me.cobstate.RightToLeft = CType(resources.GetObject("cobstate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cobstate.Size = CType(resources.GetObject("cobstate.Size"), System.Drawing.Size)
        Me.cobstate.TabIndex = CType(resources.GetObject("cobstate.TabIndex"), Integer)
        Me.cobstate.Text = resources.GetString("cobstate.Text")
        Me.cobstate.Visible = CType(resources.GetObject("cobstate.Visible"), Boolean)
        '
        'Label21
        '
        Me.Label21.AccessibleDescription = resources.GetString("Label21.AccessibleDescription")
        Me.Label21.AccessibleName = resources.GetString("Label21.AccessibleName")
        Me.Label21.Anchor = CType(resources.GetObject("Label21.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = CType(resources.GetObject("Label21.AutoSize"), Boolean)
        Me.Label21.Dock = CType(resources.GetObject("Label21.Dock"), System.Windows.Forms.DockStyle)
        Me.Label21.Enabled = CType(resources.GetObject("Label21.Enabled"), Boolean)
        Me.Label21.Font = CType(resources.GetObject("Label21.Font"), System.Drawing.Font)
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.ImageAlign = CType(resources.GetObject("Label21.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label21.ImageIndex = CType(resources.GetObject("Label21.ImageIndex"), Integer)
        Me.Label21.ImeMode = CType(resources.GetObject("Label21.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label21.Location = CType(resources.GetObject("Label21.Location"), System.Drawing.Point)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = CType(resources.GetObject("Label21.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label21.Size = CType(resources.GetObject("Label21.Size"), System.Drawing.Size)
        Me.Label21.TabIndex = CType(resources.GetObject("Label21.TabIndex"), Integer)
        Me.Label21.Text = resources.GetString("Label21.Text")
        Me.Label21.TextAlign = CType(resources.GetObject("Label21.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label21.Visible = CType(resources.GetObject("Label21.Visible"), Boolean)
        '
        'txtemailid
        '
        Me.txtemailid.AccessibleDescription = resources.GetString("txtemailid.AccessibleDescription")
        Me.txtemailid.AccessibleName = resources.GetString("txtemailid.AccessibleName")
        Me.txtemailid.Anchor = CType(resources.GetObject("txtemailid.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtemailid.AutoSize = CType(resources.GetObject("txtemailid.AutoSize"), Boolean)
        Me.txtemailid.BackgroundImage = CType(resources.GetObject("txtemailid.BackgroundImage"), System.Drawing.Image)
        Me.txtemailid.Dock = CType(resources.GetObject("txtemailid.Dock"), System.Windows.Forms.DockStyle)
        Me.txtemailid.Enabled = CType(resources.GetObject("txtemailid.Enabled"), Boolean)
        Me.txtemailid.Font = CType(resources.GetObject("txtemailid.Font"), System.Drawing.Font)
        Me.txtemailid.ImeMode = CType(resources.GetObject("txtemailid.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtemailid.Location = CType(resources.GetObject("txtemailid.Location"), System.Drawing.Point)
        Me.txtemailid.MaxLength = CType(resources.GetObject("txtemailid.MaxLength"), Integer)
        Me.txtemailid.Multiline = CType(resources.GetObject("txtemailid.Multiline"), Boolean)
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.PasswordChar = CType(resources.GetObject("txtemailid.PasswordChar"), Char)
        Me.txtemailid.RightToLeft = CType(resources.GetObject("txtemailid.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtemailid.ScrollBars = CType(resources.GetObject("txtemailid.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtemailid.Size = CType(resources.GetObject("txtemailid.Size"), System.Drawing.Size)
        Me.txtemailid.TabIndex = CType(resources.GetObject("txtemailid.TabIndex"), Integer)
        Me.txtemailid.Text = resources.GetString("txtemailid.Text")
        Me.txtemailid.TextAlign = CType(resources.GetObject("txtemailid.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtemailid.Visible = CType(resources.GetObject("txtemailid.Visible"), Boolean)
        Me.txtemailid.WordWrap = CType(resources.GetObject("txtemailid.WordWrap"), Boolean)
        '
        'txtaddress
        '
        Me.txtaddress.AccessibleDescription = resources.GetString("txtaddress.AccessibleDescription")
        Me.txtaddress.AccessibleName = resources.GetString("txtaddress.AccessibleName")
        Me.txtaddress.Anchor = CType(resources.GetObject("txtaddress.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtaddress.AutoSize = CType(resources.GetObject("txtaddress.AutoSize"), Boolean)
        Me.txtaddress.BackgroundImage = CType(resources.GetObject("txtaddress.BackgroundImage"), System.Drawing.Image)
        Me.txtaddress.Dock = CType(resources.GetObject("txtaddress.Dock"), System.Windows.Forms.DockStyle)
        Me.txtaddress.Enabled = CType(resources.GetObject("txtaddress.Enabled"), Boolean)
        Me.txtaddress.Font = CType(resources.GetObject("txtaddress.Font"), System.Drawing.Font)
        Me.txtaddress.ImeMode = CType(resources.GetObject("txtaddress.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtaddress.Location = CType(resources.GetObject("txtaddress.Location"), System.Drawing.Point)
        Me.txtaddress.MaxLength = CType(resources.GetObject("txtaddress.MaxLength"), Integer)
        Me.txtaddress.Multiline = CType(resources.GetObject("txtaddress.Multiline"), Boolean)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = CType(resources.GetObject("txtaddress.PasswordChar"), Char)
        Me.txtaddress.RightToLeft = CType(resources.GetObject("txtaddress.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtaddress.ScrollBars = CType(resources.GetObject("txtaddress.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtaddress.Size = CType(resources.GetObject("txtaddress.Size"), System.Drawing.Size)
        Me.txtaddress.TabIndex = CType(resources.GetObject("txtaddress.TabIndex"), Integer)
        Me.txtaddress.Text = resources.GetString("txtaddress.Text")
        Me.txtaddress.TextAlign = CType(resources.GetObject("txtaddress.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtaddress.Visible = CType(resources.GetObject("txtaddress.Visible"), Boolean)
        Me.txtaddress.WordWrap = CType(resources.GetObject("txtaddress.WordWrap"), Boolean)
        '
        'txtaddress1
        '
        Me.txtaddress1.AccessibleDescription = resources.GetString("txtaddress1.AccessibleDescription")
        Me.txtaddress1.AccessibleName = resources.GetString("txtaddress1.AccessibleName")
        Me.txtaddress1.Anchor = CType(resources.GetObject("txtaddress1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtaddress1.AutoSize = CType(resources.GetObject("txtaddress1.AutoSize"), Boolean)
        Me.txtaddress1.BackgroundImage = CType(resources.GetObject("txtaddress1.BackgroundImage"), System.Drawing.Image)
        Me.txtaddress1.Dock = CType(resources.GetObject("txtaddress1.Dock"), System.Windows.Forms.DockStyle)
        Me.txtaddress1.Enabled = CType(resources.GetObject("txtaddress1.Enabled"), Boolean)
        Me.txtaddress1.Font = CType(resources.GetObject("txtaddress1.Font"), System.Drawing.Font)
        Me.txtaddress1.ImeMode = CType(resources.GetObject("txtaddress1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtaddress1.Location = CType(resources.GetObject("txtaddress1.Location"), System.Drawing.Point)
        Me.txtaddress1.MaxLength = CType(resources.GetObject("txtaddress1.MaxLength"), Integer)
        Me.txtaddress1.Multiline = CType(resources.GetObject("txtaddress1.Multiline"), Boolean)
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.PasswordChar = CType(resources.GetObject("txtaddress1.PasswordChar"), Char)
        Me.txtaddress1.RightToLeft = CType(resources.GetObject("txtaddress1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtaddress1.ScrollBars = CType(resources.GetObject("txtaddress1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtaddress1.Size = CType(resources.GetObject("txtaddress1.Size"), System.Drawing.Size)
        Me.txtaddress1.TabIndex = CType(resources.GetObject("txtaddress1.TabIndex"), Integer)
        Me.txtaddress1.Text = resources.GetString("txtaddress1.Text")
        Me.txtaddress1.TextAlign = CType(resources.GetObject("txtaddress1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtaddress1.Visible = CType(resources.GetObject("txtaddress1.Visible"), Boolean)
        Me.txtaddress1.WordWrap = CType(resources.GetObject("txtaddress1.WordWrap"), Boolean)
        '
        'Label22
        '
        Me.Label22.AccessibleDescription = resources.GetString("Label22.AccessibleDescription")
        Me.Label22.AccessibleName = resources.GetString("Label22.AccessibleName")
        Me.Label22.Anchor = CType(resources.GetObject("Label22.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = CType(resources.GetObject("Label22.AutoSize"), Boolean)
        Me.Label22.Dock = CType(resources.GetObject("Label22.Dock"), System.Windows.Forms.DockStyle)
        Me.Label22.Enabled = CType(resources.GetObject("Label22.Enabled"), Boolean)
        Me.Label22.Font = CType(resources.GetObject("Label22.Font"), System.Drawing.Font)
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.ImageAlign = CType(resources.GetObject("Label22.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label22.ImageIndex = CType(resources.GetObject("Label22.ImageIndex"), Integer)
        Me.Label22.ImeMode = CType(resources.GetObject("Label22.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label22.Location = CType(resources.GetObject("Label22.Location"), System.Drawing.Point)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = CType(resources.GetObject("Label22.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label22.Size = CType(resources.GetObject("Label22.Size"), System.Drawing.Size)
        Me.Label22.TabIndex = CType(resources.GetObject("Label22.TabIndex"), Integer)
        Me.Label22.Text = resources.GetString("Label22.Text")
        Me.Label22.TextAlign = CType(resources.GetObject("Label22.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label22.Visible = CType(resources.GetObject("Label22.Visible"), Boolean)
        '
        'Label24
        '
        Me.Label24.AccessibleDescription = resources.GetString("Label24.AccessibleDescription")
        Me.Label24.AccessibleName = resources.GetString("Label24.AccessibleName")
        Me.Label24.Anchor = CType(resources.GetObject("Label24.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = CType(resources.GetObject("Label24.AutoSize"), Boolean)
        Me.Label24.Dock = CType(resources.GetObject("Label24.Dock"), System.Windows.Forms.DockStyle)
        Me.Label24.Enabled = CType(resources.GetObject("Label24.Enabled"), Boolean)
        Me.Label24.Font = CType(resources.GetObject("Label24.Font"), System.Drawing.Font)
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.ImageAlign = CType(resources.GetObject("Label24.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label24.ImageIndex = CType(resources.GetObject("Label24.ImageIndex"), Integer)
        Me.Label24.ImeMode = CType(resources.GetObject("Label24.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label24.Location = CType(resources.GetObject("Label24.Location"), System.Drawing.Point)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = CType(resources.GetObject("Label24.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label24.Size = CType(resources.GetObject("Label24.Size"), System.Drawing.Size)
        Me.Label24.TabIndex = CType(resources.GetObject("Label24.TabIndex"), Integer)
        Me.Label24.Text = resources.GetString("Label24.Text")
        Me.Label24.TextAlign = CType(resources.GetObject("Label24.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label24.Visible = CType(resources.GetObject("Label24.Visible"), Boolean)
        '
        'Label25
        '
        Me.Label25.AccessibleDescription = resources.GetString("Label25.AccessibleDescription")
        Me.Label25.AccessibleName = resources.GetString("Label25.AccessibleName")
        Me.Label25.Anchor = CType(resources.GetObject("Label25.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = CType(resources.GetObject("Label25.AutoSize"), Boolean)
        Me.Label25.Dock = CType(resources.GetObject("Label25.Dock"), System.Windows.Forms.DockStyle)
        Me.Label25.Enabled = CType(resources.GetObject("Label25.Enabled"), Boolean)
        Me.Label25.Font = CType(resources.GetObject("Label25.Font"), System.Drawing.Font)
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.ImageAlign = CType(resources.GetObject("Label25.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label25.ImageIndex = CType(resources.GetObject("Label25.ImageIndex"), Integer)
        Me.Label25.ImeMode = CType(resources.GetObject("Label25.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label25.Location = CType(resources.GetObject("Label25.Location"), System.Drawing.Point)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = CType(resources.GetObject("Label25.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label25.Size = CType(resources.GetObject("Label25.Size"), System.Drawing.Size)
        Me.Label25.TabIndex = CType(resources.GetObject("Label25.TabIndex"), Integer)
        Me.Label25.Text = resources.GetString("Label25.Text")
        Me.Label25.TextAlign = CType(resources.GetObject("Label25.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label25.Visible = CType(resources.GetObject("Label25.Visible"), Boolean)
        '
        'Label28
        '
        Me.Label28.AccessibleDescription = resources.GetString("Label28.AccessibleDescription")
        Me.Label28.AccessibleName = resources.GetString("Label28.AccessibleName")
        Me.Label28.Anchor = CType(resources.GetObject("Label28.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = CType(resources.GetObject("Label28.AutoSize"), Boolean)
        Me.Label28.Dock = CType(resources.GetObject("Label28.Dock"), System.Windows.Forms.DockStyle)
        Me.Label28.Enabled = CType(resources.GetObject("Label28.Enabled"), Boolean)
        Me.Label28.Font = CType(resources.GetObject("Label28.Font"), System.Drawing.Font)
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.ImageAlign = CType(resources.GetObject("Label28.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label28.ImageIndex = CType(resources.GetObject("Label28.ImageIndex"), Integer)
        Me.Label28.ImeMode = CType(resources.GetObject("Label28.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label28.Location = CType(resources.GetObject("Label28.Location"), System.Drawing.Point)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = CType(resources.GetObject("Label28.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label28.Size = CType(resources.GetObject("Label28.Size"), System.Drawing.Size)
        Me.Label28.TabIndex = CType(resources.GetObject("Label28.TabIndex"), Integer)
        Me.Label28.Text = resources.GetString("Label28.Text")
        Me.Label28.TextAlign = CType(resources.GetObject("Label28.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label28.Visible = CType(resources.GetObject("Label28.Visible"), Boolean)
        '
        'Label29
        '
        Me.Label29.AccessibleDescription = resources.GetString("Label29.AccessibleDescription")
        Me.Label29.AccessibleName = resources.GetString("Label29.AccessibleName")
        Me.Label29.Anchor = CType(resources.GetObject("Label29.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = CType(resources.GetObject("Label29.AutoSize"), Boolean)
        Me.Label29.Dock = CType(resources.GetObject("Label29.Dock"), System.Windows.Forms.DockStyle)
        Me.Label29.Enabled = CType(resources.GetObject("Label29.Enabled"), Boolean)
        Me.Label29.Font = CType(resources.GetObject("Label29.Font"), System.Drawing.Font)
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.ImageAlign = CType(resources.GetObject("Label29.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label29.ImageIndex = CType(resources.GetObject("Label29.ImageIndex"), Integer)
        Me.Label29.ImeMode = CType(resources.GetObject("Label29.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label29.Location = CType(resources.GetObject("Label29.Location"), System.Drawing.Point)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = CType(resources.GetObject("Label29.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label29.Size = CType(resources.GetObject("Label29.Size"), System.Drawing.Size)
        Me.Label29.TabIndex = CType(resources.GetObject("Label29.TabIndex"), Integer)
        Me.Label29.Text = resources.GetString("Label29.Text")
        Me.Label29.TextAlign = CType(resources.GetObject("Label29.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label29.Visible = CType(resources.GetObject("Label29.Visible"), Boolean)
        '
        'txtfirstname
        '
        Me.txtfirstname.AccessibleDescription = resources.GetString("txtfirstname.AccessibleDescription")
        Me.txtfirstname.AccessibleName = resources.GetString("txtfirstname.AccessibleName")
        Me.txtfirstname.Anchor = CType(resources.GetObject("txtfirstname.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtfirstname.AutoSize = CType(resources.GetObject("txtfirstname.AutoSize"), Boolean)
        Me.txtfirstname.BackgroundImage = CType(resources.GetObject("txtfirstname.BackgroundImage"), System.Drawing.Image)
        Me.txtfirstname.Dock = CType(resources.GetObject("txtfirstname.Dock"), System.Windows.Forms.DockStyle)
        Me.txtfirstname.Enabled = CType(resources.GetObject("txtfirstname.Enabled"), Boolean)
        Me.txtfirstname.Font = CType(resources.GetObject("txtfirstname.Font"), System.Drawing.Font)
        Me.txtfirstname.ImeMode = CType(resources.GetObject("txtfirstname.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtfirstname.Location = CType(resources.GetObject("txtfirstname.Location"), System.Drawing.Point)
        Me.txtfirstname.MaxLength = CType(resources.GetObject("txtfirstname.MaxLength"), Integer)
        Me.txtfirstname.Multiline = CType(resources.GetObject("txtfirstname.Multiline"), Boolean)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = CType(resources.GetObject("txtfirstname.PasswordChar"), Char)
        Me.txtfirstname.RightToLeft = CType(resources.GetObject("txtfirstname.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtfirstname.ScrollBars = CType(resources.GetObject("txtfirstname.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtfirstname.Size = CType(resources.GetObject("txtfirstname.Size"), System.Drawing.Size)
        Me.txtfirstname.TabIndex = CType(resources.GetObject("txtfirstname.TabIndex"), Integer)
        Me.txtfirstname.Text = resources.GetString("txtfirstname.Text")
        Me.txtfirstname.TextAlign = CType(resources.GetObject("txtfirstname.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtfirstname.Visible = CType(resources.GetObject("txtfirstname.Visible"), Boolean)
        Me.txtfirstname.WordWrap = CType(resources.GetObject("txtfirstname.WordWrap"), Boolean)
        '
        'Label30
        '
        Me.Label30.AccessibleDescription = resources.GetString("Label30.AccessibleDescription")
        Me.Label30.AccessibleName = resources.GetString("Label30.AccessibleName")
        Me.Label30.Anchor = CType(resources.GetObject("Label30.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = CType(resources.GetObject("Label30.AutoSize"), Boolean)
        Me.Label30.Dock = CType(resources.GetObject("Label30.Dock"), System.Windows.Forms.DockStyle)
        Me.Label30.Enabled = CType(resources.GetObject("Label30.Enabled"), Boolean)
        Me.Label30.Font = CType(resources.GetObject("Label30.Font"), System.Drawing.Font)
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.ImageAlign = CType(resources.GetObject("Label30.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label30.ImageIndex = CType(resources.GetObject("Label30.ImageIndex"), Integer)
        Me.Label30.ImeMode = CType(resources.GetObject("Label30.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label30.Location = CType(resources.GetObject("Label30.Location"), System.Drawing.Point)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = CType(resources.GetObject("Label30.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label30.Size = CType(resources.GetObject("Label30.Size"), System.Drawing.Size)
        Me.Label30.TabIndex = CType(resources.GetObject("Label30.TabIndex"), Integer)
        Me.Label30.Text = resources.GetString("Label30.Text")
        Me.Label30.TextAlign = CType(resources.GetObject("Label30.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label30.Visible = CType(resources.GetObject("Label30.Visible"), Boolean)
        '
        'AgentMaster
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.Tabcontrol1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "AgentMaster"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TopMost = True
        Me.Tabcontrol1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim frmstatus As EnuRecstatus  '  To findout record status
    Private Sub AgentMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        Tabcontrol1.SelectedTab = TabPage2
        lock()
        'fills the combobox from country master table and agent_type table
        combofill1(cobcountry, "select * from countrymaster")
        combofill(cobagentype, "select Agenttypeid from Agent_type")

    End Sub
    Public Sub lock()
        ' after loading the form all form fileds are in diable mode
        txtaddress.ReadOnly = True
        txtaddress1.ReadOnly = True
        txtagentcode.ReadOnly = True
        txtemailid.ReadOnly = True
        txtfaxno.ReadOnly = True
        txtfirstname.ReadOnly = True
        txtlastname.ReadOnly = True
        txtmobile.ReadOnly = True
        txtremarks.ReadOnly = True
        txtworkphone.ReadOnly = True
        txtzip.ReadOnly = True
        cobagentype.Enabled = False
        cobcity.Enabled = False
        cobcountry.Enabled = False
        cobstate.Enabled = False
    End Sub
    'Clears the controls on the form
    Public Sub clearproc()

        Dim ctrl As Control
        For Each ctrl In Me.TabPage2.Controls

            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        cobcity.Items.Clear()
        cobstate.Items.Clear()
        lock()
    End Sub
    'It enables the enables the input controls to insert data
    Public Sub newproc()

        'form status as new mode
        frmstatus = Module1.EnuRecstatus.Recnew
        'unlocks the controls
        txtaddress.ReadOnly = False
        txtaddress1.ReadOnly = False
        txtagentcode.ReadOnly = False
        txtemailid.ReadOnly = False
        txtfaxno.ReadOnly = False
        txtfirstname.ReadOnly = False
        txtlastname.ReadOnly = False
        txtmobile.ReadOnly = False
        txtremarks.ReadOnly = False
        txtworkphone.ReadOnly = False
        txtzip.ReadOnly = False
        cobagentype.Enabled = True
        cobcity.Enabled = True
        cobcountry.Enabled = True
        cobstate.Enabled = True
        txtagentcode.Focus()
    End Sub
    'To save or update a record 
    Public Sub saveproc()

        'checks whether the textboxes are empty
        If txtagentcode.Text = "" Then
            MsgBox(" Enter Agent code", MsgBoxStyle.OKOnly, Prjtitle)
            txtagentcode.Focus()
            Exit Sub
        End If
        If cobagentype.Text = "" Then
            MsgBox(" Select State Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobagentype.Focus()
            Exit Sub
        End If
        If txtfirstname.Text = "" Then
            MsgBox(" Enter Agent First name", MsgBoxStyle.OKOnly, Prjtitle)
            txtfirstname.Focus()
            Exit Sub
        End If


        If txtaddress.Text = "" Then
            MsgBox(" Enter Agent Address", MsgBoxStyle.OKOnly, Prjtitle)
            txtaddress.Focus()
            Exit Sub
        End If

        If cobcountry.Text = "" Then
            MsgBox(" Select country", MsgBoxStyle.OKOnly, Prjtitle)
            cobcountry.Focus()
            Exit Sub
        End If

        If cobstate.Text = "" Then
            MsgBox(" Select State ", MsgBoxStyle.OKOnly, Prjtitle)
            cobstate.Focus()
            Exit Sub
        End If
        If cobcity.Text = "" Then
            MsgBox(" Select city", MsgBoxStyle.OKOnly, Prjtitle)
            cobcity.Focus()
            Exit Sub

        End If

        Label1.Focus()
        Dim i, j As Byte
        Try
            Dim a, b, c, d, e, f, g As String
            'fills country id combobox from country master
            b = cobcountry.Text
            c = (b.Substring(0, b.IndexOf("-")))
            'fills state id combobox from state master
            a = cobstate.Text
            d = (a.Substring(0, a.IndexOf("-")))
            'fills city id combobox from city master
            e = cobcity.Text
            f = (e.Substring(0, e.IndexOf("-")))
            Dim cmd, cmd1, cmd2 As OleDbCommand
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0

                cmd = New OleDbCommand("select count(*) from Agentmaster where agentid='" & txtagentcode.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    MsgRecexist()
                    Exit Sub
                Else
                    cmd1 = New OleDbCommand("insert into Agentmaster values('" & txtagentcode.Text & "','" & cobagentype.Text & "','" & txtfirstname.Text & "','" & IIf(txtlastname.Text = "", 0, txtlastname.Text) & "','" & txtaddress.Text & "','" & IIf(txtaddress1.Text = "", 0, txtaddress1.Text) & "','" & f & "','" & d & "','" & c & "','" & IIf(txtzip.Text = "", 0, txtzip.Text) & "','" & IIf(txtmobile.Text = "", 0, txtmobile.Text) & "','" & IIf(txtworkphone.Text = "", 0, txtworkphone.Text) & "','" & IIf(txtfaxno.Text = "", 0, txtfaxno.Text) & "','" & IIf(txtemailid.Text = "", 0, txtemailid.Text) & "','" & 0 & "','" & IIf(txtremarks.Text = "", 0, txtremarks.Text) & "')", con)
                    i = cmd1.ExecuteNonQuery()
                    'Displays the updated message in messagebox
                End If
            Else
                'frmstatus = Module1.EnuRecstatus.Recedit
                Openconnection()
                cmd2 = New OleDbCommand("update Agentmaster set agenttypeid='" & cobagentype.Text & "',FirstName='" & txtfirstname.Text & "',LastName='" & IIf(txtlastname.Text = "", 0, txtlastname.Text) & "',Address='" & IIf(txtaddress.Text = "", 0, txtaddress.Text) & "',Address1='" & IIf(txtaddress1.Text = "", 0, txtaddress1.Text) & "',CityId='" & f & "',StateId='" & d & "',CountryId='" & c & "',ZIP='" & IIf(txtzip.Text = "", 0, txtzip.Text) & "',WorkPhone='" & IIf(txtworkphone.Text = "", 0, txtworkphone.Text) & "',Mobile='" & IIf(txtmobile.Text = "", 0, txtmobile.Text) & "',Fax='" & IIf(txtfaxno.Text = "", 0, txtfaxno.Text) & "',Email='" & IIf(txtemailid.Text = "", 0, txtemailid.Text) & "',Commission='" & 0 & "',Remarks='" & IIf(txtremarks.Text = "", 0, txtremarks.Text) & "' where agentid='" & txtagentcode.Text & "'", con)
                j = cmd2.ExecuteNonQuery()
            End If
            'Displays the updated message in messagebox
            MsgSav()
            'clears the controls
            clearproc()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try

    End Sub
    ' it is used to updating the record
    Public Sub editproc()

        'form status as edit mode
        frmstatus = Module1.EnuRecstatus.Recedit
        'locks the control
        txtaddress.ReadOnly = False
        txtaddress1.ReadOnly = False
        txtagentcode.ReadOnly = True 'unlocks the control
        txtemailid.ReadOnly = False
        txtfaxno.ReadOnly = False
        txtfirstname.ReadOnly = False
        txtlastname.ReadOnly = False
        txtmobile.ReadOnly = False
        txtremarks.ReadOnly = False
        txtworkphone.ReadOnly = False
        txtzip.ReadOnly = False
        cobagentype.Enabled = True
        cobcity.Enabled = True
        cobcountry.Enabled = True
        cobstate.Enabled = True

    End Sub
    Public Sub printproc()

        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)

    End Sub
    'deletes the particular record
    Public Sub delproc()

        Dim i As Byte

        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim cmd As OleDbCommand
            Dim str As String = "delete from Agentmaster where Agentid='" & txtagentcode.Text & "'"
            cmd = New OleDbCommand(str, con)
            i = cmd.ExecuteNonQuery()
            MsgDel()
            'clears the controls
            clearproc()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub

        Finally
            CloseConnection()
        End Try

    End Sub
    ' after changing the tab index agenttypeid fills the aagent combo box
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabcontrol1.SelectedIndexChanged
        Dim ds As New DataSet
        'It clears the dataset 
        ds.Clear()
        'Data in the table agent master will be displayed 
        'in datagrid on click in view tab page
        Cobagenttype.Text = ""
        Try
            combofill(Cobagenttype, "select Agenttypeid from Agent_type")
            ds.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub

        End Try

    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick

        Dim i, a, b, c As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader 'on click values of record in the datagrid comes on the form

        'locks the controls
        lock()
        cobagentype.Text = ""
        cobcity.Text = ""
        cobcountry.Text = ""
        cobstate.Text = ""
        'fills the current row index number in k
        k = dbgview.CurrentRowIndex
        'fills the value of row in i
        i = dbgview.Item(k, 0)
        Try
            'Openconnection()()
            Openconnection()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("select * from Agentmaster where AgentId='" & i & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            txtagentcode.Text = dr(0)
            cobagentype.SelectedText = dr(1)
            txtfirstname.Text = dr(2)
            txtlastname.Text = dr(3)
            txtaddress.Text = dr(4)
            txtaddress1.Text = dr(5)
            a = dr(8)
            b = dr(7)
            c = dr(6)
            comboselet(cobcountry, a)
            comboselet(cobstate, b)
            comboselet(cobcity, c)
            txtzip.Text = dr(9)
            txtworkphone.Text = dr(10)
            txtmobile.Text = dr(11)
            txtfaxno.Text = dr(12)
            txtemailid.Text = dr(13)
            txtremarks.Text = dr(15)

            Tabcontrol1.SelectedTab = TabPage2
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
    'it fills the states combo box based on country id
    Private Sub cobcountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobcountry.SelectedIndexChanged

        Dim b, c As String
        cobstate.Items.Clear()
        cobcity.Items.Clear()
        cobstate.Text = ""
        cobcity.Text = ""
        b = cobcountry.Text
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobstate, "select stateid,state from statemaster where countryid='" & c & "'")

    End Sub
    ' it fills the city id based on state id
    Private Sub cobstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobstate.SelectedIndexChanged

        Dim b, c As String
        cobcity.Items.Clear()
        b = cobstate.Text
        cobcity.Text = ""
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobcity, "select cityid,city from citymaster where stateid='" & c & "'")

    End Sub
    ' uses to enter number and text in textbox
    Private Sub txtagentcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtagentcode.KeyPress

        textandnumbers(e)

    End Sub
    ' uses to enter text only in textbox
    Private Sub txtfirstname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirstname.KeyPress

        textonly(e)

    End Sub
    ' uses to enter text only in textbox
    Private Sub txtlastname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlastname.KeyPress

        textonly(e)

    End Sub
    ' uses to enter number only in textbox
    Private Sub txtfaxno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfaxno.KeyPress

        numberonly(e)

    End Sub
    ' uses to enter number only in textbox
    Private Sub txtmobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress

        numberonly(e)

    End Sub

    ' uses to enter number only in textbox
    Private Sub txtworkphone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtworkphone.KeyPress

        numberonly(e)

    End Sub

    ' uses to enter number only in textbox
    Private Sub txtzip_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtzip.KeyPress

        numberonly(e)

    End Sub

    ' uses to enter the first letter as capital letter
    Private Sub txtaddress1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress1.Leave

        firstcap(txtaddress1)

    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtagentcode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtagentcode.Leave

        firstcap(txtagentcode)

    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtfirstname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfirstname.Leave

        firstcap(txtfirstname)

    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtlastname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlastname.Leave

        firstcap(txtlastname)

    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtremarks_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtremarks.Leave

        firstcap(txtremarks)

    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtaddress_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.Leave

        firstcap(txtaddress)

    End Sub
    'use to enter correct format of mail id
    Private Sub txtemailid_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemailid.Leave
        email(txtemailid)
    End Sub
    ' uses to fill datagrid based on agenttypeid selected from agentcombo box
    Private Sub Cobagenttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cobagenttype.SelectedIndexChanged
        Dim ds As New DataSet
        Dim p As Integer = 0
        ds.Clear()
        Openconnection()
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand("select count(*) from agentmaster where agenttypeid='" & Cobagenttype.Text & "'", con)
        p = cmd.ExecuteScalar()
        If p <> 0 Then
            Dim da1 As New OleDbDataAdapter("select * from Agentmaster where agenttypeid='" & Cobagenttype.Text & "'", con)
            da1.Fill(ds, "agentmaster")
            dbgview.DataSource = ds.Tables("agentmaster")
        Else
            MsgBox("Records are not found for selected criteria", MsgBoxStyle.OKOnly, Prjtitle)
        End If
        CloseConnection()
    End Sub
    'it doesnt allows any values in the combo box
    Private Sub Cobagenttype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cobagenttype.KeyPress
        combo(e)
    End Sub
    'it doesnt allows any values in the combo box
    Private Sub cobagentype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobagentype.KeyPress
        combo(e)
    End Sub
    'it doesnt allows any values in the combo box
    Private Sub cobcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcity.KeyPress
        combo(e)
    End Sub
    'it doesnt allows any values in the combo box
    Private Sub cobcountry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcountry.KeyPress
        combo(e)
    End Sub
    'it doesnt allows any values in the combo box
    Private Sub cobstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobstate.KeyPress
        combo(e)
    End Sub
End Class
