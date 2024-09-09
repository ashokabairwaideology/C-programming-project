'Name developer: kamal.k.trood
'Dt:03/07/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class Hotelmast
    Inherits System.Windows.Forms.Form
    'Dim cmd, cmd1, cmd2, cmd3 As OleDbCommand
    'Dim da As New OleDbDataAdapter("select * from hotelmaster", con)
    'Dim ds As New DataSet
    Dim recmode As EnuRecstatus   '  To findout record status

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txthotelid As System.Windows.Forms.TextBox
    Friend WithEvents txtmobileno As System.Windows.Forms.TextBox
    Friend WithEvents txtdesignation As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtfacilities As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofrooms As System.Windows.Forms.TextBox
    Friend WithEvents txtadd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents txtzip As System.Windows.Forms.TextBox
    Friend WithEvents txtphone1 As System.Windows.Forms.TextBox
    Friend WithEvents cobcity As System.Windows.Forms.ComboBox
    Friend WithEvents cobstate As System.Windows.Forms.ComboBox
    Friend WithEvents cobcountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txturl As System.Windows.Forms.TextBox
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txthotelname As System.Windows.Forms.TextBox
    Friend WithEvents txthoteltype As System.Windows.Forms.TextBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cobhotelgroup As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hotelmast))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cobhotelgroup = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txthotelid = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtmobileno = New System.Windows.Forms.TextBox
        Me.txtdesignation = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtfacilities = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtnoofrooms = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtadd1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.txtfax = New System.Windows.Forms.TextBox
        Me.txtzip = New System.Windows.Forms.TextBox
        Me.txtphone1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cobcity = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cobstate = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cobcountry = New System.Windows.Forms.ComboBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txturl = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtemailid = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txthotelname = New System.Windows.Forms.TextBox
        Me.txthoteltype = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleDescription = resources.GetString("TabControl1.AccessibleDescription")
        Me.TabControl1.AccessibleName = resources.GetString("TabControl1.AccessibleName")
        Me.TabControl1.Alignment = CType(resources.GetObject("TabControl1.Alignment"), System.Windows.Forms.TabAlignment)
        Me.TabControl1.Anchor = CType(resources.GetObject("TabControl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = CType(resources.GetObject("TabControl1.Appearance"), System.Windows.Forms.TabAppearance)
        Me.TabControl1.BackgroundImage = CType(resources.GetObject("TabControl1.BackgroundImage"), System.Drawing.Image)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = CType(resources.GetObject("TabControl1.Dock"), System.Windows.Forms.DockStyle)
        Me.TabControl1.Enabled = CType(resources.GetObject("TabControl1.Enabled"), Boolean)
        Me.TabControl1.Font = CType(resources.GetObject("TabControl1.Font"), System.Drawing.Font)
        Me.TabControl1.ImeMode = CType(resources.GetObject("TabControl1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabControl1.ItemSize = CType(resources.GetObject("TabControl1.ItemSize"), System.Drawing.Size)
        Me.TabControl1.Location = CType(resources.GetObject("TabControl1.Location"), System.Drawing.Point)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = CType(resources.GetObject("TabControl1.Padding"), System.Drawing.Point)
        Me.TabControl1.RightToLeft = CType(resources.GetObject("TabControl1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = CType(resources.GetObject("TabControl1.ShowToolTips"), Boolean)
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
        Me.TabControl1.TabIndex = CType(resources.GetObject("TabControl1.TabIndex"), Integer)
        Me.TabControl1.Text = resources.GetString("TabControl1.Text")
        Me.TabControl1.Visible = CType(resources.GetObject("TabControl1.Visible"), Boolean)
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
        Me.TabPage1.Controls.Add(Me.dbgview)
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
        Me.TabPage2.Controls.Add(Me.GroupBox4)
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
        'GroupBox4
        '
        Me.GroupBox4.AccessibleDescription = resources.GetString("GroupBox4.AccessibleDescription")
        Me.GroupBox4.AccessibleName = resources.GetString("GroupBox4.AccessibleName")
        Me.GroupBox4.Anchor = CType(resources.GetObject("GroupBox4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.cobhotelgroup)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txthotelid)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.txtfacilities)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtnoofrooms)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtadd1)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtmobile)
        Me.GroupBox4.Controls.Add(Me.txtfax)
        Me.GroupBox4.Controls.Add(Me.txtzip)
        Me.GroupBox4.Controls.Add(Me.txtphone1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cobcity)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cobstate)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cobcountry)
        Me.GroupBox4.Controls.Add(Me.txtadd)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txturl)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtemailid)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtphone)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txthotelname)
        Me.GroupBox4.Controls.Add(Me.txthoteltype)
        Me.GroupBox4.Dock = CType(resources.GetObject("GroupBox4.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox4.Enabled = CType(resources.GetObject("GroupBox4.Enabled"), Boolean)
        Me.GroupBox4.Font = CType(resources.GetObject("GroupBox4.Font"), System.Drawing.Font)
        Me.GroupBox4.ImeMode = CType(resources.GetObject("GroupBox4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox4.Location = CType(resources.GetObject("GroupBox4.Location"), System.Drawing.Point)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = CType(resources.GetObject("GroupBox4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox4.Size = CType(resources.GetObject("GroupBox4.Size"), System.Drawing.Size)
        Me.GroupBox4.TabIndex = CType(resources.GetObject("GroupBox4.TabIndex"), Integer)
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = resources.GetString("GroupBox4.Text")
        Me.GroupBox4.Visible = CType(resources.GetObject("GroupBox4.Visible"), Boolean)
        '
        'cobhotelgroup
        '
        Me.cobhotelgroup.AccessibleDescription = resources.GetString("cobhotelgroup.AccessibleDescription")
        Me.cobhotelgroup.AccessibleName = resources.GetString("cobhotelgroup.AccessibleName")
        Me.cobhotelgroup.Anchor = CType(resources.GetObject("cobhotelgroup.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cobhotelgroup.BackgroundImage = CType(resources.GetObject("cobhotelgroup.BackgroundImage"), System.Drawing.Image)
        Me.cobhotelgroup.Dock = CType(resources.GetObject("cobhotelgroup.Dock"), System.Windows.Forms.DockStyle)
        Me.cobhotelgroup.Enabled = CType(resources.GetObject("cobhotelgroup.Enabled"), Boolean)
        Me.cobhotelgroup.Font = CType(resources.GetObject("cobhotelgroup.Font"), System.Drawing.Font)
        Me.cobhotelgroup.ImeMode = CType(resources.GetObject("cobhotelgroup.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cobhotelgroup.IntegralHeight = CType(resources.GetObject("cobhotelgroup.IntegralHeight"), Boolean)
        Me.cobhotelgroup.ItemHeight = CType(resources.GetObject("cobhotelgroup.ItemHeight"), Integer)
        Me.cobhotelgroup.Location = CType(resources.GetObject("cobhotelgroup.Location"), System.Drawing.Point)
        Me.cobhotelgroup.MaxDropDownItems = CType(resources.GetObject("cobhotelgroup.MaxDropDownItems"), Integer)
        Me.cobhotelgroup.MaxLength = CType(resources.GetObject("cobhotelgroup.MaxLength"), Integer)
        Me.cobhotelgroup.Name = "cobhotelgroup"
        Me.cobhotelgroup.RightToLeft = CType(resources.GetObject("cobhotelgroup.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cobhotelgroup.Size = CType(resources.GetObject("cobhotelgroup.Size"), System.Drawing.Size)
        Me.cobhotelgroup.TabIndex = CType(resources.GetObject("cobhotelgroup.TabIndex"), Integer)
        Me.cobhotelgroup.Text = resources.GetString("cobhotelgroup.Text")
        Me.cobhotelgroup.Visible = CType(resources.GetObject("cobhotelgroup.Visible"), Boolean)
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
        'txthotelid
        '
        Me.txthotelid.AccessibleDescription = resources.GetString("txthotelid.AccessibleDescription")
        Me.txthotelid.AccessibleName = resources.GetString("txthotelid.AccessibleName")
        Me.txthotelid.Anchor = CType(resources.GetObject("txthotelid.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txthotelid.AutoSize = CType(resources.GetObject("txthotelid.AutoSize"), Boolean)
        Me.txthotelid.BackgroundImage = CType(resources.GetObject("txthotelid.BackgroundImage"), System.Drawing.Image)
        Me.txthotelid.Dock = CType(resources.GetObject("txthotelid.Dock"), System.Windows.Forms.DockStyle)
        Me.txthotelid.Enabled = CType(resources.GetObject("txthotelid.Enabled"), Boolean)
        Me.txthotelid.Font = CType(resources.GetObject("txthotelid.Font"), System.Drawing.Font)
        Me.txthotelid.ImeMode = CType(resources.GetObject("txthotelid.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txthotelid.Location = CType(resources.GetObject("txthotelid.Location"), System.Drawing.Point)
        Me.txthotelid.MaxLength = CType(resources.GetObject("txthotelid.MaxLength"), Integer)
        Me.txthotelid.Multiline = CType(resources.GetObject("txthotelid.Multiline"), Boolean)
        Me.txthotelid.Name = "txthotelid"
        Me.txthotelid.PasswordChar = CType(resources.GetObject("txthotelid.PasswordChar"), Char)
        Me.txthotelid.RightToLeft = CType(resources.GetObject("txthotelid.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txthotelid.ScrollBars = CType(resources.GetObject("txthotelid.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txthotelid.Size = CType(resources.GetObject("txthotelid.Size"), System.Drawing.Size)
        Me.txthotelid.TabIndex = CType(resources.GetObject("txthotelid.TabIndex"), Integer)
        Me.txthotelid.Text = resources.GetString("txthotelid.Text")
        Me.txthotelid.TextAlign = CType(resources.GetObject("txthotelid.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txthotelid.Visible = CType(resources.GetObject("txthotelid.Visible"), Boolean)
        Me.txthotelid.WordWrap = CType(resources.GetObject("txthotelid.WordWrap"), Boolean)
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
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription")
        Me.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName")
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtmobileno)
        Me.GroupBox1.Controls.Add(Me.txtdesignation)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
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
        'txtmobileno
        '
        Me.txtmobileno.AccessibleDescription = resources.GetString("txtmobileno.AccessibleDescription")
        Me.txtmobileno.AccessibleName = resources.GetString("txtmobileno.AccessibleName")
        Me.txtmobileno.Anchor = CType(resources.GetObject("txtmobileno.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtmobileno.AutoSize = CType(resources.GetObject("txtmobileno.AutoSize"), Boolean)
        Me.txtmobileno.BackgroundImage = CType(resources.GetObject("txtmobileno.BackgroundImage"), System.Drawing.Image)
        Me.txtmobileno.Dock = CType(resources.GetObject("txtmobileno.Dock"), System.Windows.Forms.DockStyle)
        Me.txtmobileno.Enabled = CType(resources.GetObject("txtmobileno.Enabled"), Boolean)
        Me.txtmobileno.Font = CType(resources.GetObject("txtmobileno.Font"), System.Drawing.Font)
        Me.txtmobileno.ImeMode = CType(resources.GetObject("txtmobileno.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtmobileno.Location = CType(resources.GetObject("txtmobileno.Location"), System.Drawing.Point)
        Me.txtmobileno.MaxLength = CType(resources.GetObject("txtmobileno.MaxLength"), Integer)
        Me.txtmobileno.Multiline = CType(resources.GetObject("txtmobileno.Multiline"), Boolean)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.PasswordChar = CType(resources.GetObject("txtmobileno.PasswordChar"), Char)
        Me.txtmobileno.RightToLeft = CType(resources.GetObject("txtmobileno.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtmobileno.ScrollBars = CType(resources.GetObject("txtmobileno.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtmobileno.Size = CType(resources.GetObject("txtmobileno.Size"), System.Drawing.Size)
        Me.txtmobileno.TabIndex = CType(resources.GetObject("txtmobileno.TabIndex"), Integer)
        Me.txtmobileno.Text = resources.GetString("txtmobileno.Text")
        Me.txtmobileno.TextAlign = CType(resources.GetObject("txtmobileno.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtmobileno.Visible = CType(resources.GetObject("txtmobileno.Visible"), Boolean)
        Me.txtmobileno.WordWrap = CType(resources.GetObject("txtmobileno.WordWrap"), Boolean)
        '
        'txtdesignation
        '
        Me.txtdesignation.AccessibleDescription = resources.GetString("txtdesignation.AccessibleDescription")
        Me.txtdesignation.AccessibleName = resources.GetString("txtdesignation.AccessibleName")
        Me.txtdesignation.Anchor = CType(resources.GetObject("txtdesignation.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtdesignation.AutoSize = CType(resources.GetObject("txtdesignation.AutoSize"), Boolean)
        Me.txtdesignation.BackgroundImage = CType(resources.GetObject("txtdesignation.BackgroundImage"), System.Drawing.Image)
        Me.txtdesignation.Dock = CType(resources.GetObject("txtdesignation.Dock"), System.Windows.Forms.DockStyle)
        Me.txtdesignation.Enabled = CType(resources.GetObject("txtdesignation.Enabled"), Boolean)
        Me.txtdesignation.Font = CType(resources.GetObject("txtdesignation.Font"), System.Drawing.Font)
        Me.txtdesignation.ImeMode = CType(resources.GetObject("txtdesignation.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtdesignation.Location = CType(resources.GetObject("txtdesignation.Location"), System.Drawing.Point)
        Me.txtdesignation.MaxLength = CType(resources.GetObject("txtdesignation.MaxLength"), Integer)
        Me.txtdesignation.Multiline = CType(resources.GetObject("txtdesignation.Multiline"), Boolean)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.PasswordChar = CType(resources.GetObject("txtdesignation.PasswordChar"), Char)
        Me.txtdesignation.RightToLeft = CType(resources.GetObject("txtdesignation.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtdesignation.ScrollBars = CType(resources.GetObject("txtdesignation.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtdesignation.Size = CType(resources.GetObject("txtdesignation.Size"), System.Drawing.Size)
        Me.txtdesignation.TabIndex = CType(resources.GetObject("txtdesignation.TabIndex"), Integer)
        Me.txtdesignation.Text = resources.GetString("txtdesignation.Text")
        Me.txtdesignation.TextAlign = CType(resources.GetObject("txtdesignation.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtdesignation.Visible = CType(resources.GetObject("txtdesignation.Visible"), Boolean)
        Me.txtdesignation.WordWrap = CType(resources.GetObject("txtdesignation.WordWrap"), Boolean)
        '
        'txtname
        '
        Me.txtname.AccessibleDescription = resources.GetString("txtname.AccessibleDescription")
        Me.txtname.AccessibleName = resources.GetString("txtname.AccessibleName")
        Me.txtname.Anchor = CType(resources.GetObject("txtname.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtname.AutoSize = CType(resources.GetObject("txtname.AutoSize"), Boolean)
        Me.txtname.BackgroundImage = CType(resources.GetObject("txtname.BackgroundImage"), System.Drawing.Image)
        Me.txtname.Dock = CType(resources.GetObject("txtname.Dock"), System.Windows.Forms.DockStyle)
        Me.txtname.Enabled = CType(resources.GetObject("txtname.Enabled"), Boolean)
        Me.txtname.Font = CType(resources.GetObject("txtname.Font"), System.Drawing.Font)
        Me.txtname.ImeMode = CType(resources.GetObject("txtname.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtname.Location = CType(resources.GetObject("txtname.Location"), System.Drawing.Point)
        Me.txtname.MaxLength = CType(resources.GetObject("txtname.MaxLength"), Integer)
        Me.txtname.Multiline = CType(resources.GetObject("txtname.Multiline"), Boolean)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = CType(resources.GetObject("txtname.PasswordChar"), Char)
        Me.txtname.RightToLeft = CType(resources.GetObject("txtname.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtname.ScrollBars = CType(resources.GetObject("txtname.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtname.Size = CType(resources.GetObject("txtname.Size"), System.Drawing.Size)
        Me.txtname.TabIndex = CType(resources.GetObject("txtname.TabIndex"), Integer)
        Me.txtname.Text = resources.GetString("txtname.Text")
        Me.txtname.TextAlign = CType(resources.GetObject("txtname.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtname.Visible = CType(resources.GetObject("txtname.Visible"), Boolean)
        Me.txtname.WordWrap = CType(resources.GetObject("txtname.WordWrap"), Boolean)
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
        'Label17
        '
        Me.Label17.AccessibleDescription = resources.GetString("Label17.AccessibleDescription")
        Me.Label17.AccessibleName = resources.GetString("Label17.AccessibleName")
        Me.Label17.Anchor = CType(resources.GetObject("Label17.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = CType(resources.GetObject("Label17.AutoSize"), Boolean)
        Me.Label17.Dock = CType(resources.GetObject("Label17.Dock"), System.Windows.Forms.DockStyle)
        Me.Label17.Enabled = CType(resources.GetObject("Label17.Enabled"), Boolean)
        Me.Label17.Font = CType(resources.GetObject("Label17.Font"), System.Drawing.Font)
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.ImageAlign = CType(resources.GetObject("Label17.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label17.ImageIndex = CType(resources.GetObject("Label17.ImageIndex"), Integer)
        Me.Label17.ImeMode = CType(resources.GetObject("Label17.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label17.Location = CType(resources.GetObject("Label17.Location"), System.Drawing.Point)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = CType(resources.GetObject("Label17.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label17.Size = CType(resources.GetObject("Label17.Size"), System.Drawing.Size)
        Me.Label17.TabIndex = CType(resources.GetObject("Label17.TabIndex"), Integer)
        Me.Label17.Text = resources.GetString("Label17.Text")
        Me.Label17.TextAlign = CType(resources.GetObject("Label17.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label17.Visible = CType(resources.GetObject("Label17.Visible"), Boolean)
        '
        'txtfacilities
        '
        Me.txtfacilities.AccessibleDescription = resources.GetString("txtfacilities.AccessibleDescription")
        Me.txtfacilities.AccessibleName = resources.GetString("txtfacilities.AccessibleName")
        Me.txtfacilities.Anchor = CType(resources.GetObject("txtfacilities.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtfacilities.AutoSize = CType(resources.GetObject("txtfacilities.AutoSize"), Boolean)
        Me.txtfacilities.BackgroundImage = CType(resources.GetObject("txtfacilities.BackgroundImage"), System.Drawing.Image)
        Me.txtfacilities.Dock = CType(resources.GetObject("txtfacilities.Dock"), System.Windows.Forms.DockStyle)
        Me.txtfacilities.Enabled = CType(resources.GetObject("txtfacilities.Enabled"), Boolean)
        Me.txtfacilities.Font = CType(resources.GetObject("txtfacilities.Font"), System.Drawing.Font)
        Me.txtfacilities.ImeMode = CType(resources.GetObject("txtfacilities.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtfacilities.Location = CType(resources.GetObject("txtfacilities.Location"), System.Drawing.Point)
        Me.txtfacilities.MaxLength = CType(resources.GetObject("txtfacilities.MaxLength"), Integer)
        Me.txtfacilities.Multiline = CType(resources.GetObject("txtfacilities.Multiline"), Boolean)
        Me.txtfacilities.Name = "txtfacilities"
        Me.txtfacilities.PasswordChar = CType(resources.GetObject("txtfacilities.PasswordChar"), Char)
        Me.txtfacilities.RightToLeft = CType(resources.GetObject("txtfacilities.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtfacilities.ScrollBars = CType(resources.GetObject("txtfacilities.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtfacilities.Size = CType(resources.GetObject("txtfacilities.Size"), System.Drawing.Size)
        Me.txtfacilities.TabIndex = CType(resources.GetObject("txtfacilities.TabIndex"), Integer)
        Me.txtfacilities.Text = resources.GetString("txtfacilities.Text")
        Me.txtfacilities.TextAlign = CType(resources.GetObject("txtfacilities.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtfacilities.Visible = CType(resources.GetObject("txtfacilities.Visible"), Boolean)
        Me.txtfacilities.WordWrap = CType(resources.GetObject("txtfacilities.WordWrap"), Boolean)
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
        'txtnoofrooms
        '
        Me.txtnoofrooms.AccessibleDescription = resources.GetString("txtnoofrooms.AccessibleDescription")
        Me.txtnoofrooms.AccessibleName = resources.GetString("txtnoofrooms.AccessibleName")
        Me.txtnoofrooms.Anchor = CType(resources.GetObject("txtnoofrooms.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtnoofrooms.AutoSize = CType(resources.GetObject("txtnoofrooms.AutoSize"), Boolean)
        Me.txtnoofrooms.BackgroundImage = CType(resources.GetObject("txtnoofrooms.BackgroundImage"), System.Drawing.Image)
        Me.txtnoofrooms.Dock = CType(resources.GetObject("txtnoofrooms.Dock"), System.Windows.Forms.DockStyle)
        Me.txtnoofrooms.Enabled = CType(resources.GetObject("txtnoofrooms.Enabled"), Boolean)
        Me.txtnoofrooms.Font = CType(resources.GetObject("txtnoofrooms.Font"), System.Drawing.Font)
        Me.txtnoofrooms.ImeMode = CType(resources.GetObject("txtnoofrooms.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtnoofrooms.Location = CType(resources.GetObject("txtnoofrooms.Location"), System.Drawing.Point)
        Me.txtnoofrooms.MaxLength = CType(resources.GetObject("txtnoofrooms.MaxLength"), Integer)
        Me.txtnoofrooms.Multiline = CType(resources.GetObject("txtnoofrooms.Multiline"), Boolean)
        Me.txtnoofrooms.Name = "txtnoofrooms"
        Me.txtnoofrooms.PasswordChar = CType(resources.GetObject("txtnoofrooms.PasswordChar"), Char)
        Me.txtnoofrooms.RightToLeft = CType(resources.GetObject("txtnoofrooms.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtnoofrooms.ScrollBars = CType(resources.GetObject("txtnoofrooms.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtnoofrooms.Size = CType(resources.GetObject("txtnoofrooms.Size"), System.Drawing.Size)
        Me.txtnoofrooms.TabIndex = CType(resources.GetObject("txtnoofrooms.TabIndex"), Integer)
        Me.txtnoofrooms.Text = resources.GetString("txtnoofrooms.Text")
        Me.txtnoofrooms.TextAlign = CType(resources.GetObject("txtnoofrooms.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtnoofrooms.Visible = CType(resources.GetObject("txtnoofrooms.Visible"), Boolean)
        Me.txtnoofrooms.WordWrap = CType(resources.GetObject("txtnoofrooms.WordWrap"), Boolean)
        '
        'Label15
        '
        Me.Label15.AccessibleDescription = resources.GetString("Label15.AccessibleDescription")
        Me.Label15.AccessibleName = resources.GetString("Label15.AccessibleName")
        Me.Label15.Anchor = CType(resources.GetObject("Label15.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = CType(resources.GetObject("Label15.AutoSize"), Boolean)
        Me.Label15.Dock = CType(resources.GetObject("Label15.Dock"), System.Windows.Forms.DockStyle)
        Me.Label15.Enabled = CType(resources.GetObject("Label15.Enabled"), Boolean)
        Me.Label15.Font = CType(resources.GetObject("Label15.Font"), System.Drawing.Font)
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = CType(resources.GetObject("Label15.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label15.ImageIndex = CType(resources.GetObject("Label15.ImageIndex"), Integer)
        Me.Label15.ImeMode = CType(resources.GetObject("Label15.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label15.Location = CType(resources.GetObject("Label15.Location"), System.Drawing.Point)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = CType(resources.GetObject("Label15.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label15.Size = CType(resources.GetObject("Label15.Size"), System.Drawing.Size)
        Me.Label15.TabIndex = CType(resources.GetObject("Label15.TabIndex"), Integer)
        Me.Label15.Text = resources.GetString("Label15.Text")
        Me.Label15.TextAlign = CType(resources.GetObject("Label15.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label15.Visible = CType(resources.GetObject("Label15.Visible"), Boolean)
        '
        'txtadd1
        '
        Me.txtadd1.AccessibleDescription = resources.GetString("txtadd1.AccessibleDescription")
        Me.txtadd1.AccessibleName = resources.GetString("txtadd1.AccessibleName")
        Me.txtadd1.Anchor = CType(resources.GetObject("txtadd1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtadd1.AutoSize = CType(resources.GetObject("txtadd1.AutoSize"), Boolean)
        Me.txtadd1.BackgroundImage = CType(resources.GetObject("txtadd1.BackgroundImage"), System.Drawing.Image)
        Me.txtadd1.Dock = CType(resources.GetObject("txtadd1.Dock"), System.Windows.Forms.DockStyle)
        Me.txtadd1.Enabled = CType(resources.GetObject("txtadd1.Enabled"), Boolean)
        Me.txtadd1.Font = CType(resources.GetObject("txtadd1.Font"), System.Drawing.Font)
        Me.txtadd1.ImeMode = CType(resources.GetObject("txtadd1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtadd1.Location = CType(resources.GetObject("txtadd1.Location"), System.Drawing.Point)
        Me.txtadd1.MaxLength = CType(resources.GetObject("txtadd1.MaxLength"), Integer)
        Me.txtadd1.Multiline = CType(resources.GetObject("txtadd1.Multiline"), Boolean)
        Me.txtadd1.Name = "txtadd1"
        Me.txtadd1.PasswordChar = CType(resources.GetObject("txtadd1.PasswordChar"), Char)
        Me.txtadd1.RightToLeft = CType(resources.GetObject("txtadd1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtadd1.ScrollBars = CType(resources.GetObject("txtadd1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtadd1.Size = CType(resources.GetObject("txtadd1.Size"), System.Drawing.Size)
        Me.txtadd1.TabIndex = CType(resources.GetObject("txtadd1.TabIndex"), Integer)
        Me.txtadd1.Text = resources.GetString("txtadd1.Text")
        Me.txtadd1.TextAlign = CType(resources.GetObject("txtadd1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtadd1.Visible = CType(resources.GetObject("txtadd1.Visible"), Boolean)
        Me.txtadd1.WordWrap = CType(resources.GetObject("txtadd1.WordWrap"), Boolean)
        '
        'Label14
        '
        Me.Label14.AccessibleDescription = resources.GetString("Label14.AccessibleDescription")
        Me.Label14.AccessibleName = resources.GetString("Label14.AccessibleName")
        Me.Label14.Anchor = CType(resources.GetObject("Label14.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = CType(resources.GetObject("Label14.AutoSize"), Boolean)
        Me.Label14.Dock = CType(resources.GetObject("Label14.Dock"), System.Windows.Forms.DockStyle)
        Me.Label14.Enabled = CType(resources.GetObject("Label14.Enabled"), Boolean)
        Me.Label14.Font = CType(resources.GetObject("Label14.Font"), System.Drawing.Font)
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.ImageAlign = CType(resources.GetObject("Label14.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label14.ImageIndex = CType(resources.GetObject("Label14.ImageIndex"), Integer)
        Me.Label14.ImeMode = CType(resources.GetObject("Label14.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label14.Location = CType(resources.GetObject("Label14.Location"), System.Drawing.Point)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = CType(resources.GetObject("Label14.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label14.Size = CType(resources.GetObject("Label14.Size"), System.Drawing.Size)
        Me.Label14.TabIndex = CType(resources.GetObject("Label14.TabIndex"), Integer)
        Me.Label14.Text = resources.GetString("Label14.Text")
        Me.Label14.TextAlign = CType(resources.GetObject("Label14.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label14.Visible = CType(resources.GetObject("Label14.Visible"), Boolean)
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = resources.GetString("Label9.AccessibleDescription")
        Me.Label9.AccessibleName = resources.GetString("Label9.AccessibleName")
        Me.Label9.Anchor = CType(resources.GetObject("Label9.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = CType(resources.GetObject("Label9.AutoSize"), Boolean)
        Me.Label9.Dock = CType(resources.GetObject("Label9.Dock"), System.Windows.Forms.DockStyle)
        Me.Label9.Enabled = CType(resources.GetObject("Label9.Enabled"), Boolean)
        Me.Label9.Font = CType(resources.GetObject("Label9.Font"), System.Drawing.Font)
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = CType(resources.GetObject("Label9.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label9.ImageIndex = CType(resources.GetObject("Label9.ImageIndex"), Integer)
        Me.Label9.ImeMode = CType(resources.GetObject("Label9.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label9.Location = CType(resources.GetObject("Label9.Location"), System.Drawing.Point)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = CType(resources.GetObject("Label9.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label9.Size = CType(resources.GetObject("Label9.Size"), System.Drawing.Size)
        Me.Label9.TabIndex = CType(resources.GetObject("Label9.TabIndex"), Integer)
        Me.Label9.Text = resources.GetString("Label9.Text")
        Me.Label9.TextAlign = CType(resources.GetObject("Label9.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label9.Visible = CType(resources.GetObject("Label9.Visible"), Boolean)
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
        'txtfax
        '
        Me.txtfax.AccessibleDescription = resources.GetString("txtfax.AccessibleDescription")
        Me.txtfax.AccessibleName = resources.GetString("txtfax.AccessibleName")
        Me.txtfax.Anchor = CType(resources.GetObject("txtfax.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtfax.AutoSize = CType(resources.GetObject("txtfax.AutoSize"), Boolean)
        Me.txtfax.BackgroundImage = CType(resources.GetObject("txtfax.BackgroundImage"), System.Drawing.Image)
        Me.txtfax.Dock = CType(resources.GetObject("txtfax.Dock"), System.Windows.Forms.DockStyle)
        Me.txtfax.Enabled = CType(resources.GetObject("txtfax.Enabled"), Boolean)
        Me.txtfax.Font = CType(resources.GetObject("txtfax.Font"), System.Drawing.Font)
        Me.txtfax.ImeMode = CType(resources.GetObject("txtfax.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtfax.Location = CType(resources.GetObject("txtfax.Location"), System.Drawing.Point)
        Me.txtfax.MaxLength = CType(resources.GetObject("txtfax.MaxLength"), Integer)
        Me.txtfax.Multiline = CType(resources.GetObject("txtfax.Multiline"), Boolean)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.PasswordChar = CType(resources.GetObject("txtfax.PasswordChar"), Char)
        Me.txtfax.RightToLeft = CType(resources.GetObject("txtfax.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtfax.ScrollBars = CType(resources.GetObject("txtfax.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtfax.Size = CType(resources.GetObject("txtfax.Size"), System.Drawing.Size)
        Me.txtfax.TabIndex = CType(resources.GetObject("txtfax.TabIndex"), Integer)
        Me.txtfax.Text = resources.GetString("txtfax.Text")
        Me.txtfax.TextAlign = CType(resources.GetObject("txtfax.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtfax.Visible = CType(resources.GetObject("txtfax.Visible"), Boolean)
        Me.txtfax.WordWrap = CType(resources.GetObject("txtfax.WordWrap"), Boolean)
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
        'txtphone1
        '
        Me.txtphone1.AccessibleDescription = resources.GetString("txtphone1.AccessibleDescription")
        Me.txtphone1.AccessibleName = resources.GetString("txtphone1.AccessibleName")
        Me.txtphone1.Anchor = CType(resources.GetObject("txtphone1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtphone1.AutoSize = CType(resources.GetObject("txtphone1.AutoSize"), Boolean)
        Me.txtphone1.BackgroundImage = CType(resources.GetObject("txtphone1.BackgroundImage"), System.Drawing.Image)
        Me.txtphone1.Dock = CType(resources.GetObject("txtphone1.Dock"), System.Windows.Forms.DockStyle)
        Me.txtphone1.Enabled = CType(resources.GetObject("txtphone1.Enabled"), Boolean)
        Me.txtphone1.Font = CType(resources.GetObject("txtphone1.Font"), System.Drawing.Font)
        Me.txtphone1.ImeMode = CType(resources.GetObject("txtphone1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtphone1.Location = CType(resources.GetObject("txtphone1.Location"), System.Drawing.Point)
        Me.txtphone1.MaxLength = CType(resources.GetObject("txtphone1.MaxLength"), Integer)
        Me.txtphone1.Multiline = CType(resources.GetObject("txtphone1.Multiline"), Boolean)
        Me.txtphone1.Name = "txtphone1"
        Me.txtphone1.PasswordChar = CType(resources.GetObject("txtphone1.PasswordChar"), Char)
        Me.txtphone1.RightToLeft = CType(resources.GetObject("txtphone1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtphone1.ScrollBars = CType(resources.GetObject("txtphone1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtphone1.Size = CType(resources.GetObject("txtphone1.Size"), System.Drawing.Size)
        Me.txtphone1.TabIndex = CType(resources.GetObject("txtphone1.TabIndex"), Integer)
        Me.txtphone1.Text = resources.GetString("txtphone1.Text")
        Me.txtphone1.TextAlign = CType(resources.GetObject("txtphone1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtphone1.Visible = CType(resources.GetObject("txtphone1.Visible"), Boolean)
        Me.txtphone1.WordWrap = CType(resources.GetObject("txtphone1.WordWrap"), Boolean)
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = resources.GetString("Label8.AccessibleDescription")
        Me.Label8.AccessibleName = resources.GetString("Label8.AccessibleName")
        Me.Label8.Anchor = CType(resources.GetObject("Label8.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = CType(resources.GetObject("Label8.AutoSize"), Boolean)
        Me.Label8.Dock = CType(resources.GetObject("Label8.Dock"), System.Windows.Forms.DockStyle)
        Me.Label8.Enabled = CType(resources.GetObject("Label8.Enabled"), Boolean)
        Me.Label8.Font = CType(resources.GetObject("Label8.Font"), System.Drawing.Font)
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = CType(resources.GetObject("Label8.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label8.ImageIndex = CType(resources.GetObject("Label8.ImageIndex"), Integer)
        Me.Label8.ImeMode = CType(resources.GetObject("Label8.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label8.Location = CType(resources.GetObject("Label8.Location"), System.Drawing.Point)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = CType(resources.GetObject("Label8.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label8.Size = CType(resources.GetObject("Label8.Size"), System.Drawing.Size)
        Me.Label8.TabIndex = CType(resources.GetObject("Label8.TabIndex"), Integer)
        Me.Label8.Text = resources.GetString("Label8.Text")
        Me.Label8.TextAlign = CType(resources.GetObject("Label8.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label8.Visible = CType(resources.GetObject("Label8.Visible"), Boolean)
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
        'Label6
        '
        Me.Label6.AccessibleDescription = resources.GetString("Label6.AccessibleDescription")
        Me.Label6.AccessibleName = resources.GetString("Label6.AccessibleName")
        Me.Label6.Anchor = CType(resources.GetObject("Label6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = CType(resources.GetObject("Label6.AutoSize"), Boolean)
        Me.Label6.Dock = CType(resources.GetObject("Label6.Dock"), System.Windows.Forms.DockStyle)
        Me.Label6.Enabled = CType(resources.GetObject("Label6.Enabled"), Boolean)
        Me.Label6.Font = CType(resources.GetObject("Label6.Font"), System.Drawing.Font)
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = CType(resources.GetObject("Label6.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label6.ImageIndex = CType(resources.GetObject("Label6.ImageIndex"), Integer)
        Me.Label6.ImeMode = CType(resources.GetObject("Label6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label6.Location = CType(resources.GetObject("Label6.Location"), System.Drawing.Point)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = CType(resources.GetObject("Label6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label6.Size = CType(resources.GetObject("Label6.Size"), System.Drawing.Size)
        Me.Label6.TabIndex = CType(resources.GetObject("Label6.TabIndex"), Integer)
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = CType(resources.GetObject("Label6.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label6.Visible = CType(resources.GetObject("Label6.Visible"), Boolean)
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
        'Label5
        '
        Me.Label5.AccessibleDescription = resources.GetString("Label5.AccessibleDescription")
        Me.Label5.AccessibleName = resources.GetString("Label5.AccessibleName")
        Me.Label5.Anchor = CType(resources.GetObject("Label5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = CType(resources.GetObject("Label5.AutoSize"), Boolean)
        Me.Label5.Dock = CType(resources.GetObject("Label5.Dock"), System.Windows.Forms.DockStyle)
        Me.Label5.Enabled = CType(resources.GetObject("Label5.Enabled"), Boolean)
        Me.Label5.Font = CType(resources.GetObject("Label5.Font"), System.Drawing.Font)
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = CType(resources.GetObject("Label5.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label5.ImageIndex = CType(resources.GetObject("Label5.ImageIndex"), Integer)
        Me.Label5.ImeMode = CType(resources.GetObject("Label5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label5.Location = CType(resources.GetObject("Label5.Location"), System.Drawing.Point)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = CType(resources.GetObject("Label5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label5.Size = CType(resources.GetObject("Label5.Size"), System.Drawing.Size)
        Me.Label5.TabIndex = CType(resources.GetObject("Label5.TabIndex"), Integer)
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = CType(resources.GetObject("Label5.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label5.Visible = CType(resources.GetObject("Label5.Visible"), Boolean)
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
        'txtadd
        '
        Me.txtadd.AccessibleDescription = resources.GetString("txtadd.AccessibleDescription")
        Me.txtadd.AccessibleName = resources.GetString("txtadd.AccessibleName")
        Me.txtadd.Anchor = CType(resources.GetObject("txtadd.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtadd.AutoSize = CType(resources.GetObject("txtadd.AutoSize"), Boolean)
        Me.txtadd.BackgroundImage = CType(resources.GetObject("txtadd.BackgroundImage"), System.Drawing.Image)
        Me.txtadd.Dock = CType(resources.GetObject("txtadd.Dock"), System.Windows.Forms.DockStyle)
        Me.txtadd.Enabled = CType(resources.GetObject("txtadd.Enabled"), Boolean)
        Me.txtadd.Font = CType(resources.GetObject("txtadd.Font"), System.Drawing.Font)
        Me.txtadd.ImeMode = CType(resources.GetObject("txtadd.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtadd.Location = CType(resources.GetObject("txtadd.Location"), System.Drawing.Point)
        Me.txtadd.MaxLength = CType(resources.GetObject("txtadd.MaxLength"), Integer)
        Me.txtadd.Multiline = CType(resources.GetObject("txtadd.Multiline"), Boolean)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.PasswordChar = CType(resources.GetObject("txtadd.PasswordChar"), Char)
        Me.txtadd.RightToLeft = CType(resources.GetObject("txtadd.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtadd.ScrollBars = CType(resources.GetObject("txtadd.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtadd.Size = CType(resources.GetObject("txtadd.Size"), System.Drawing.Size)
        Me.txtadd.TabIndex = CType(resources.GetObject("txtadd.TabIndex"), Integer)
        Me.txtadd.Text = resources.GetString("txtadd.Text")
        Me.txtadd.TextAlign = CType(resources.GetObject("txtadd.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtadd.Visible = CType(resources.GetObject("txtadd.Visible"), Boolean)
        Me.txtadd.WordWrap = CType(resources.GetObject("txtadd.WordWrap"), Boolean)
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
        'Label13
        '
        Me.Label13.AccessibleDescription = resources.GetString("Label13.AccessibleDescription")
        Me.Label13.AccessibleName = resources.GetString("Label13.AccessibleName")
        Me.Label13.Anchor = CType(resources.GetObject("Label13.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = CType(resources.GetObject("Label13.AutoSize"), Boolean)
        Me.Label13.Dock = CType(resources.GetObject("Label13.Dock"), System.Windows.Forms.DockStyle)
        Me.Label13.Enabled = CType(resources.GetObject("Label13.Enabled"), Boolean)
        Me.Label13.Font = CType(resources.GetObject("Label13.Font"), System.Drawing.Font)
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = CType(resources.GetObject("Label13.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label13.ImageIndex = CType(resources.GetObject("Label13.ImageIndex"), Integer)
        Me.Label13.ImeMode = CType(resources.GetObject("Label13.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label13.Location = CType(resources.GetObject("Label13.Location"), System.Drawing.Point)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = CType(resources.GetObject("Label13.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label13.Size = CType(resources.GetObject("Label13.Size"), System.Drawing.Size)
        Me.Label13.TabIndex = CType(resources.GetObject("Label13.TabIndex"), Integer)
        Me.Label13.Text = resources.GetString("Label13.Text")
        Me.Label13.TextAlign = CType(resources.GetObject("Label13.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label13.Visible = CType(resources.GetObject("Label13.Visible"), Boolean)
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
        'txturl
        '
        Me.txturl.AccessibleDescription = resources.GetString("txturl.AccessibleDescription")
        Me.txturl.AccessibleName = resources.GetString("txturl.AccessibleName")
        Me.txturl.Anchor = CType(resources.GetObject("txturl.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txturl.AutoSize = CType(resources.GetObject("txturl.AutoSize"), Boolean)
        Me.txturl.BackgroundImage = CType(resources.GetObject("txturl.BackgroundImage"), System.Drawing.Image)
        Me.txturl.Dock = CType(resources.GetObject("txturl.Dock"), System.Windows.Forms.DockStyle)
        Me.txturl.Enabled = CType(resources.GetObject("txturl.Enabled"), Boolean)
        Me.txturl.Font = CType(resources.GetObject("txturl.Font"), System.Drawing.Font)
        Me.txturl.ImeMode = CType(resources.GetObject("txturl.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txturl.Location = CType(resources.GetObject("txturl.Location"), System.Drawing.Point)
        Me.txturl.MaxLength = CType(resources.GetObject("txturl.MaxLength"), Integer)
        Me.txturl.Multiline = CType(resources.GetObject("txturl.Multiline"), Boolean)
        Me.txturl.Name = "txturl"
        Me.txturl.PasswordChar = CType(resources.GetObject("txturl.PasswordChar"), Char)
        Me.txturl.RightToLeft = CType(resources.GetObject("txturl.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txturl.ScrollBars = CType(resources.GetObject("txturl.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txturl.Size = CType(resources.GetObject("txturl.Size"), System.Drawing.Size)
        Me.txturl.TabIndex = CType(resources.GetObject("txturl.TabIndex"), Integer)
        Me.txturl.Text = resources.GetString("txturl.Text")
        Me.txturl.TextAlign = CType(resources.GetObject("txturl.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txturl.Visible = CType(resources.GetObject("txturl.Visible"), Boolean)
        Me.txturl.WordWrap = CType(resources.GetObject("txturl.WordWrap"), Boolean)
        '
        'Label12
        '
        Me.Label12.AccessibleDescription = resources.GetString("Label12.AccessibleDescription")
        Me.Label12.AccessibleName = resources.GetString("Label12.AccessibleName")
        Me.Label12.Anchor = CType(resources.GetObject("Label12.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = CType(resources.GetObject("Label12.AutoSize"), Boolean)
        Me.Label12.Dock = CType(resources.GetObject("Label12.Dock"), System.Windows.Forms.DockStyle)
        Me.Label12.Enabled = CType(resources.GetObject("Label12.Enabled"), Boolean)
        Me.Label12.Font = CType(resources.GetObject("Label12.Font"), System.Drawing.Font)
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.ImageAlign = CType(resources.GetObject("Label12.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label12.ImageIndex = CType(resources.GetObject("Label12.ImageIndex"), Integer)
        Me.Label12.ImeMode = CType(resources.GetObject("Label12.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label12.Location = CType(resources.GetObject("Label12.Location"), System.Drawing.Point)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = CType(resources.GetObject("Label12.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label12.Size = CType(resources.GetObject("Label12.Size"), System.Drawing.Size)
        Me.Label12.TabIndex = CType(resources.GetObject("Label12.TabIndex"), Integer)
        Me.Label12.Text = resources.GetString("Label12.Text")
        Me.Label12.TextAlign = CType(resources.GetObject("Label12.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label12.Visible = CType(resources.GetObject("Label12.Visible"), Boolean)
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
        'Label11
        '
        Me.Label11.AccessibleDescription = resources.GetString("Label11.AccessibleDescription")
        Me.Label11.AccessibleName = resources.GetString("Label11.AccessibleName")
        Me.Label11.Anchor = CType(resources.GetObject("Label11.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = CType(resources.GetObject("Label11.AutoSize"), Boolean)
        Me.Label11.Dock = CType(resources.GetObject("Label11.Dock"), System.Windows.Forms.DockStyle)
        Me.Label11.Enabled = CType(resources.GetObject("Label11.Enabled"), Boolean)
        Me.Label11.Font = CType(resources.GetObject("Label11.Font"), System.Drawing.Font)
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = CType(resources.GetObject("Label11.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label11.ImageIndex = CType(resources.GetObject("Label11.ImageIndex"), Integer)
        Me.Label11.ImeMode = CType(resources.GetObject("Label11.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label11.Location = CType(resources.GetObject("Label11.Location"), System.Drawing.Point)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = CType(resources.GetObject("Label11.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label11.Size = CType(resources.GetObject("Label11.Size"), System.Drawing.Size)
        Me.Label11.TabIndex = CType(resources.GetObject("Label11.TabIndex"), Integer)
        Me.Label11.Text = resources.GetString("Label11.Text")
        Me.Label11.TextAlign = CType(resources.GetObject("Label11.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label11.Visible = CType(resources.GetObject("Label11.Visible"), Boolean)
        '
        'txtphone
        '
        Me.txtphone.AccessibleDescription = resources.GetString("txtphone.AccessibleDescription")
        Me.txtphone.AccessibleName = resources.GetString("txtphone.AccessibleName")
        Me.txtphone.Anchor = CType(resources.GetObject("txtphone.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtphone.AutoSize = CType(resources.GetObject("txtphone.AutoSize"), Boolean)
        Me.txtphone.BackgroundImage = CType(resources.GetObject("txtphone.BackgroundImage"), System.Drawing.Image)
        Me.txtphone.Dock = CType(resources.GetObject("txtphone.Dock"), System.Windows.Forms.DockStyle)
        Me.txtphone.Enabled = CType(resources.GetObject("txtphone.Enabled"), Boolean)
        Me.txtphone.Font = CType(resources.GetObject("txtphone.Font"), System.Drawing.Font)
        Me.txtphone.ImeMode = CType(resources.GetObject("txtphone.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtphone.Location = CType(resources.GetObject("txtphone.Location"), System.Drawing.Point)
        Me.txtphone.MaxLength = CType(resources.GetObject("txtphone.MaxLength"), Integer)
        Me.txtphone.Multiline = CType(resources.GetObject("txtphone.Multiline"), Boolean)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PasswordChar = CType(resources.GetObject("txtphone.PasswordChar"), Char)
        Me.txtphone.RightToLeft = CType(resources.GetObject("txtphone.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtphone.ScrollBars = CType(resources.GetObject("txtphone.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtphone.Size = CType(resources.GetObject("txtphone.Size"), System.Drawing.Size)
        Me.txtphone.TabIndex = CType(resources.GetObject("txtphone.TabIndex"), Integer)
        Me.txtphone.Text = resources.GetString("txtphone.Text")
        Me.txtphone.TextAlign = CType(resources.GetObject("txtphone.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtphone.Visible = CType(resources.GetObject("txtphone.Visible"), Boolean)
        Me.txtphone.WordWrap = CType(resources.GetObject("txtphone.WordWrap"), Boolean)
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = resources.GetString("Label10.AccessibleDescription")
        Me.Label10.AccessibleName = resources.GetString("Label10.AccessibleName")
        Me.Label10.Anchor = CType(resources.GetObject("Label10.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = CType(resources.GetObject("Label10.AutoSize"), Boolean)
        Me.Label10.Dock = CType(resources.GetObject("Label10.Dock"), System.Windows.Forms.DockStyle)
        Me.Label10.Enabled = CType(resources.GetObject("Label10.Enabled"), Boolean)
        Me.Label10.Font = CType(resources.GetObject("Label10.Font"), System.Drawing.Font)
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = CType(resources.GetObject("Label10.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label10.ImageIndex = CType(resources.GetObject("Label10.ImageIndex"), Integer)
        Me.Label10.ImeMode = CType(resources.GetObject("Label10.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label10.Location = CType(resources.GetObject("Label10.Location"), System.Drawing.Point)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = CType(resources.GetObject("Label10.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label10.Size = CType(resources.GetObject("Label10.Size"), System.Drawing.Size)
        Me.Label10.TabIndex = CType(resources.GetObject("Label10.TabIndex"), Integer)
        Me.Label10.Text = resources.GetString("Label10.Text")
        Me.Label10.TextAlign = CType(resources.GetObject("Label10.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label10.Visible = CType(resources.GetObject("Label10.Visible"), Boolean)
        '
        'txthotelname
        '
        Me.txthotelname.AccessibleDescription = resources.GetString("txthotelname.AccessibleDescription")
        Me.txthotelname.AccessibleName = resources.GetString("txthotelname.AccessibleName")
        Me.txthotelname.Anchor = CType(resources.GetObject("txthotelname.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txthotelname.AutoSize = CType(resources.GetObject("txthotelname.AutoSize"), Boolean)
        Me.txthotelname.BackgroundImage = CType(resources.GetObject("txthotelname.BackgroundImage"), System.Drawing.Image)
        Me.txthotelname.Dock = CType(resources.GetObject("txthotelname.Dock"), System.Windows.Forms.DockStyle)
        Me.txthotelname.Enabled = CType(resources.GetObject("txthotelname.Enabled"), Boolean)
        Me.txthotelname.Font = CType(resources.GetObject("txthotelname.Font"), System.Drawing.Font)
        Me.txthotelname.ImeMode = CType(resources.GetObject("txthotelname.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txthotelname.Location = CType(resources.GetObject("txthotelname.Location"), System.Drawing.Point)
        Me.txthotelname.MaxLength = CType(resources.GetObject("txthotelname.MaxLength"), Integer)
        Me.txthotelname.Multiline = CType(resources.GetObject("txthotelname.Multiline"), Boolean)
        Me.txthotelname.Name = "txthotelname"
        Me.txthotelname.PasswordChar = CType(resources.GetObject("txthotelname.PasswordChar"), Char)
        Me.txthotelname.RightToLeft = CType(resources.GetObject("txthotelname.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txthotelname.ScrollBars = CType(resources.GetObject("txthotelname.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txthotelname.Size = CType(resources.GetObject("txthotelname.Size"), System.Drawing.Size)
        Me.txthotelname.TabIndex = CType(resources.GetObject("txthotelname.TabIndex"), Integer)
        Me.txthotelname.Text = resources.GetString("txthotelname.Text")
        Me.txthotelname.TextAlign = CType(resources.GetObject("txthotelname.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txthotelname.Visible = CType(resources.GetObject("txthotelname.Visible"), Boolean)
        Me.txthotelname.WordWrap = CType(resources.GetObject("txthotelname.WordWrap"), Boolean)
        '
        'txthoteltype
        '
        Me.txthoteltype.AccessibleDescription = resources.GetString("txthoteltype.AccessibleDescription")
        Me.txthoteltype.AccessibleName = resources.GetString("txthoteltype.AccessibleName")
        Me.txthoteltype.Anchor = CType(resources.GetObject("txthoteltype.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txthoteltype.AutoSize = CType(resources.GetObject("txthoteltype.AutoSize"), Boolean)
        Me.txthoteltype.BackgroundImage = CType(resources.GetObject("txthoteltype.BackgroundImage"), System.Drawing.Image)
        Me.txthoteltype.Dock = CType(resources.GetObject("txthoteltype.Dock"), System.Windows.Forms.DockStyle)
        Me.txthoteltype.Enabled = CType(resources.GetObject("txthoteltype.Enabled"), Boolean)
        Me.txthoteltype.Font = CType(resources.GetObject("txthoteltype.Font"), System.Drawing.Font)
        Me.txthoteltype.ImeMode = CType(resources.GetObject("txthoteltype.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txthoteltype.Location = CType(resources.GetObject("txthoteltype.Location"), System.Drawing.Point)
        Me.txthoteltype.MaxLength = CType(resources.GetObject("txthoteltype.MaxLength"), Integer)
        Me.txthoteltype.Multiline = CType(resources.GetObject("txthoteltype.Multiline"), Boolean)
        Me.txthoteltype.Name = "txthoteltype"
        Me.txthoteltype.PasswordChar = CType(resources.GetObject("txthoteltype.PasswordChar"), Char)
        Me.txthoteltype.RightToLeft = CType(resources.GetObject("txthoteltype.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txthoteltype.ScrollBars = CType(resources.GetObject("txthoteltype.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txthoteltype.Size = CType(resources.GetObject("txthoteltype.Size"), System.Drawing.Size)
        Me.txthoteltype.TabIndex = CType(resources.GetObject("txthoteltype.TabIndex"), Integer)
        Me.txthoteltype.Text = resources.GetString("txthoteltype.Text")
        Me.txthoteltype.TextAlign = CType(resources.GetObject("txthoteltype.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txthoteltype.Visible = CType(resources.GetObject("txthoteltype.Visible"), Boolean)
        Me.txthoteltype.WordWrap = CType(resources.GetObject("txthoteltype.WordWrap"), Boolean)
        '
        'Hotelmast
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.TabControl1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "Hotelmast"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Hotelmast_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'opens entry/edit page on pageload
        TabControl1.SelectedTab = TabPage2
        'fills the combobox from hotel_chain table
        combofill1(cobhotelgroup, "select hot_chainid,hot_chain_name from hotel_chain")
        'fills the combobox from country master table
        combofill1(cobcountry, "select * from countrymaster")
        ' locks the controls
        lock()
    End Sub
    Public Sub lock()
        ' locks the controls
        txthotelid.ReadOnly = True
        txthotelname.ReadOnly = True
        cobhotelgroup.Enabled = False
        txthoteltype.ReadOnly = True
        txtnoofrooms.ReadOnly = True
        txtadd.ReadOnly = True
        txtadd1.ReadOnly = True
        cobcountry.Enabled = False
        cobstate.Enabled = False
        cobcity.Enabled = False
        txtzip.ReadOnly = True
        txtphone.ReadOnly = True
        txtphone1.ReadOnly = True
        txtfax.ReadOnly = True
        txtmobile.ReadOnly = True
        txtemailid.ReadOnly = True
        txturl.ReadOnly = True
        txtfacilities.ReadOnly = True
        txtname.ReadOnly = True
        txtdesignation.ReadOnly = True
        txtmobileno.ReadOnly = True
    End Sub
    'Clears the controls on the form
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox4.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    'It enables the enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        'clears the controls
        clearproc()
        ' unlocks the controls
        txthotelid.ReadOnly = False
        txthotelname.ReadOnly = False
        cobhotelgroup.Enabled = True
        txthoteltype.ReadOnly = False
        txtnoofrooms.ReadOnly = False
        txtadd.ReadOnly = False
        txtadd1.ReadOnly = False
        cobcountry.Enabled = True
        cobstate.Enabled = True
        cobcity.Enabled = True
        txtzip.ReadOnly = False
        txtphone.ReadOnly = False
        txtphone1.ReadOnly = False
        txtfax.ReadOnly = False
        txtmobile.ReadOnly = False
        txtemailid.ReadOnly = False
        txturl.ReadOnly = False
        txtfacilities.ReadOnly = False
        txtname.ReadOnly = False
        txtdesignation.ReadOnly = False
        txtmobileno.ReadOnly = False
        'cursor gets into hotelid textbox
        TabControl1.SelectedTab = TabPage2
        txthotelid.Focus()
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        'checks whether the textboxes are empty
        If txthotelid.Text = "" Then
            MsgBox(" Enter Hotel Id", MsgBoxStyle.OKOnly, Prjtitle)
            txthotelid.Focus()
            Exit Sub
        End If
        If txthotelname.Text = "" Then
            MsgBox(" Enter Hotel Name", MsgBoxStyle.OKOnly, Prjtitle)
            txthotelname.Focus()
            Exit Sub
        End If
        If txtnoofrooms.Text = "" Then
            MsgBox(" Enter No. of Rooms", MsgBoxStyle.OKOnly, Prjtitle)
            txtnoofrooms.Focus()
            Exit Sub
        End If
        If txtadd.Text = "" Then
            MsgBox(" Enter Address", MsgBoxStyle.OKOnly, Prjtitle)
            txtadd.Focus()
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
        Label1.Focus()
        Dim cmd, cmd1, cmd2 As OleDbCommand
        Dim a, b, c, d, e, f, g, h As String
        'saves data before the "-" country id combobox 
        a = cobcountry.Text
        b = (a.Substring(0, a.IndexOf("-")))
        'saves data before the "-" state id combobox 
        c = cobstate.Text
        d = (c.Substring(0, c.IndexOf("-")))
        'saves data before the "-" city id combobox 
        e = cobcity.Text
        f = (e.Substring(0, e.IndexOf("-")))
        'saves data before the "-" in hotel group
        If cobhotelgroup.Text <> "" Then
            g = cobhotelgroup.Text
            h = (g.Substring(0, g.IndexOf("-")))
        End If
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from hotelmaster where hotelid='" & txthotelid.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    ' to show the message that record exsisted already
                    MsgRecexist()
                    txthotelid.Focus()
                    Exit Sub
                Else
                    cmd1 = New OleDbCommand("insert into hotelmaster values('" & txthotelid.Text & "','" & txthotelname.Text & "','" & IIf(h = "", 0, h) & "','" & IIf(txthoteltype.Text = "", 0, txthoteltype.Text) & "'," & txtnoofrooms.Text & ",'" & txtadd.Text & "','" & IIf(txtadd1.Text = "", 0, txtadd1.Text) & "','" & b & "','" & d & "','" & f & "'," & IIf(txtzip.Text = "", 0, txtzip.Text) & "," & IIf(txtphone.Text = "", 0, txtphone.Text) & "," & IIf(txtphone1.Text = "", 0, txtphone1.Text) & "," & IIf(txtfax.Text = "", 0, txtfax.Text) & "," & IIf(txtmobile.Text = "", 0, txtmobile.Text) & ",'" & IIf(txtemailid.Text = "", 0, txtemailid.Text) & "','" & IIf(txturl.Text = "", 0, txturl.Text) & "','" & IIf(txtfacilities.Text = "", 0, txtfacilities.Text) & "','" & IIf(txtname.Text = "", 0, txtname.Text) & "','" & IIf(txtdesignation.Text = "", 0, txtdesignation.Text) & "'," & IIf(txtmobileno.Text = "", 0, txtmobileno.Text) & ")", con)
                    cmd1.ExecuteNonQuery()
                End If
                'Displays the updated message in messagebox
                MsgSav()
                'clears the controls
                clearproc()
                ' locks the controls
                lock()
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update hotelmaster set HotelName='" & txthotelname.Text & "',Hot_chainid='" & IIf(cobhotelgroup.SelectedItem = "", 0, cobhotelgroup.SelectedItem) & "',Hoteltype='" & IIf(txthoteltype.Text = "", 0, txthoteltype.Text) & "',NoOfrooms=" & txtnoofrooms.Text & ",Address='" & txtadd.Text & "',Address1='" & IIf(txtadd1.Text = "", 0, txtadd1.Text) & "',CountryId='" & b & "',StateId='" & d & "',CityId='" & f & "',ZIP=" & IIf(txtzip.Text = "", 0, txtzip.Text) & ",Phone=" & IIf(txtphone.Text = "", 0, txtphone.Text) & ",Phone1=" & IIf(txtphone1.Text = "", 0, txtphone1.Text) & ",Fax=" & IIf(txtfax.Text = "", 0, txtfax.Text) & ",Mobile=" & IIf(txtmobile.Text = "", 0, txtmobile.Text) & ",Email='" & IIf(txtemailid.Text = "", 0, txtemailid.Text) & "',Url='" & IIf(txturl.Text = "", 0, txturl.Text) & "',Facilities='" & IIf(txtfacilities.Text = "", 0, txtfacilities.Text) & "',Cont_name='" & IIf(txtname.Text = "", 0, txtname.Text) & "',Cont_desig='" & IIf(txtdesignation.Text = "", 0, txtdesignation.Text) & "',Cont_No=" & IIf(txtmobileno.Text = "", 0, txtmobileno.Text) & " where hotelid='" & txthotelid.Text & "'", con)
                cmd2.ExecuteNonQuery()
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
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        ' locks the controls
        txthotelid.ReadOnly = True
        ' unlocks the controls
        txthotelname.ReadOnly = False
        cobhotelgroup.Enabled = True
        txthoteltype.ReadOnly = False
        txtnoofrooms.ReadOnly = False
        txtadd.ReadOnly = False
        txtadd1.ReadOnly = False
        cobcountry.Enabled = True
        cobstate.Enabled = True
        cobcity.Enabled = True
        txtzip.ReadOnly = False
        txtphone.ReadOnly = False
        txtphone1.ReadOnly = False
        txtfax.ReadOnly = False
        txtmobile.ReadOnly = False
        txtemailid.ReadOnly = False
        txturl.ReadOnly = False
        txtfacilities.ReadOnly = False
        txtname.ReadOnly = False
        txtdesignation.ReadOnly = False
        txtmobileno.ReadOnly = False
        'cursor gets into hotelname textbox
        txthotelname.Focus()
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes the particular record
    Public Sub delproc()
        Dim cmd As OleDbCommand
        Dim i, p, q, r, s As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            cmd = New OleDbCommand("select count(*) from hotel_season where hotelid='" & txthotelid.Text & "'", con)
            p = cmd.ExecuteScalar()
            cmd.Dispose()
            cmd = New OleDbCommand("select count(*) from hotel_surcharg where hotelid='" & txthotelid.Text & "'", con)
            q = cmd.ExecuteScalar()
            cmd.Dispose()
            cmd = New OleDbCommand("select count(*) from room_tariff where hotelid='" & txthotelid.Text & "'", con)
            r = cmd.ExecuteScalar()
            cmd.Dispose()
            cmd = New OleDbCommand("select count(*) from meal_tariff where hotelid='" & txthotelid.Text & "'", con)
            s = cmd.ExecuteScalar()
            cmd.Dispose()
            If p <> 0 Or q <> 0 Or r <> 0 Or s <> 0 Then
                ' to show the message that record exsisted already
                MsgRecexist()
                txthotelid.Focus()
                Exit Sub
            Else
                Dim str As String = "delete from hotelmaster where hotelid='" & txthotelid.Text & "'"
                cmd = New OleDbCommand(str, con)
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgDel()
                    'clears the controls
                    clearproc()
                    ' locks the controls
                    lock()
                Else
                    MsgBox("Record Not Found", MsgBoxStyle.OKOnly, Prjtitle)
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

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim da As New OleDbDataAdapter("select hotelid,hotelname,noofrooms,address,countryid,stateid,cityid,phone,mobile,email from hotelmaster", con)
        Dim ds As New DataSet
        'It clears the dataset 
        ds.Clear()
        'Data in the table hotel master will be displayed 
        'in datagrid on click in view tab page
        If TabControl1.SelectedTab.Text = "View" Then
            da.Fill(ds, "hotelmaster")
            dbgview.DataSource = ds.Tables("hotelmaster")
            dbgview.ReadOnly = True
        End If
    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim cmd,  As OleDbCommand
        Dim i, w, x, y, z As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        ' locks the controls
        lock()
        'clears the combobox
        cobhotelgroup.Text = ""
        cobcountry.Text = ""
        cobstate.Text = ""
        cobcity.Text = ""
        'fills the current row index number in k
        k = dbgview.CurrentRowIndex
        'fills the value of row in i
        i = dbgview.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from hotelmaster where HotelId='" & i & "'", con)
        'con.Open()
        Try
            dr = cmd.ExecuteReader
            While dr.Read()
                txthotelid.Text = dr(0)
                txthotelname.Text = dr(1)
                'cobhotelgroup
                w = dr(2)
                comboselet(cobhotelgroup, w)
                txthoteltype.Text = dr(3)
                txtnoofrooms.Text = dr(4)
                txtadd.Text = dr(5)
                txtadd1.Text = dr(6)
                'cobcountry
                x = dr(7)
                'cobstate
                y = dr(8)
                'cobcity
                z = dr(9)
                comboselet(cobcountry, x)
                comboselet(cobstate, y)
                comboselet(cobcity, z)
                txtzip.Text = dr(10)
                txtphone.Text = dr(11)
                txtphone1.Text = dr(12)
                txtfax.Text = dr(13)
                txtmobile.Text = dr(14)
                txtemailid.Text = dr(15)
                txturl.Text = dr(16)
                txtfacilities.Text = dr(17)
                txtname.Text = dr(18)
                txtdesignation.Text = dr(19)
                txtmobileno.Text = dr(20)
            End While
            con.Close()
            ''hotel group name
            'Openconnection()
            'cmd1 = New OleDbCommand("select hot_chain_name from hotel_chain where hot_chainid='" & w & "'", con)
            'hotgroup = cmd1.ExecuteScalar
            'hot = w & "-" & hotgroup
            'cobhotelgroup.SelectedText = hot
            'cmd1.Dispose()
            'con.Close()
            ''country
            'Openconnection()
            'cmd1 = New OleDbCommand("select country from countrymaster where countryid='" & x & "'", con)
            'country = cmd1.ExecuteScalar
            'cou = x & "-" & country
            'cobcountry.SelectedText = cou
            'con.Close()
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
    Private Sub txthotelid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthotelid.KeyPress
        'allows to enter both text and numbers
        idtextandnumbers(e)
    End Sub
    Private Sub txtzip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtzip.KeyPress, txtphone.KeyPress, txtphone1.KeyPress, txtfax.KeyPress, txtmobile.KeyPress, txtmobileno.KeyPress, txtnoofrooms.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub
    Private Sub txtdesignation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesignation.KeyPress, txtname.KeyPress
        'allows to enter text only 
        textonly(e)
    End Sub
    Private Sub txtdesignation_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdesignation.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtdesignation)
    End Sub
    Private Sub txtfacilities_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfacilities.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtfacilities)
    End Sub
    Private Sub txthotelid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthotelid.Leave
        'makes first letter in textbox as capital letter
        firstcap(txthotelid)
    End Sub
    Private Sub txthotelname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthotelname.Leave
        'makes first letter in textbox as capital letter
        firstcap(txthotelname)
    End Sub
    Private Sub txthoteltype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthoteltype.Leave
        'makes first letter in textbox as capital letter
        firstcap(txthoteltype)
    End Sub
    Private Sub txtname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtname.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtname)
    End Sub
    Private Sub txtemailid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemailid.Leave
        '  this procedure is to check the validity of email id
        email(txtemailid)
    End Sub
    Private Sub txtadd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtadd.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtadd)
    End Sub
    Private Sub txtadd1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtadd1.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtadd1)
    End Sub
    Private Sub cobhotelgroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotelgroup.KeyPress, cobcountry.KeyPress, cobstate.KeyPress, cobcity.KeyPress
        combo(e)
    End Sub
End Class
