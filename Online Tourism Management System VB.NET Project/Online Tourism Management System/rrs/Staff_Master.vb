'written by P.R.Sudhakar Reddy
'Version 1
'date: 27 june 2006
'verson 2
'date: 7 aug 2006
'(date of join has been added)

Public Class Staff_Master
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
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents txt_wph As System.Windows.Forms.TextBox
    Friend WithEvents txt_mob As System.Windows.Forms.TextBox
    Friend WithEvents txt_add As System.Windows.Forms.TextBox
    Friend WithEvents txt_area As System.Windows.Forms.TextBox
    Friend WithEvents txt_str As System.Windows.Forms.TextBox
    Friend WithEvents txt_eid As System.Windows.Forms.TextBox
    Friend WithEvents txt_zip As System.Windows.Forms.TextBox
    Friend WithEvents cob_coun As System.Windows.Forms.ComboBox
    Friend WithEvents cob_sta As System.Windows.Forms.ComboBox
    Friend WithEvents cob_city As System.Windows.Forms.ComboBox
    Friend WithEvents txt_bgr As System.Windows.Forms.TextBox
    Friend WithEvents txt_hph As System.Windows.Forms.TextBox
    Friend WithEvents txt_qual As System.Windows.Forms.TextBox
    Friend WithEvents txt_loc As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents txt_sal As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents txt_empid As System.Windows.Forms.TextBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cob_dept As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_doj As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Staff_Master))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.txt_wph = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_mob = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_add = New System.Windows.Forms.TextBox
        Me.txt_area = New System.Windows.Forms.TextBox
        Me.txt_str = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_eid = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_zip = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cob_coun = New System.Windows.Forms.ComboBox
        Me.cob_sta = New System.Windows.Forms.ComboBox
        Me.cob_city = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_bgr = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_hph = New System.Windows.Forms.TextBox
        Me.txt_qual = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtp_doj = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.cob_dept = New System.Windows.Forms.ComboBox
        Me.txt_loc = New System.Windows.Forms.TextBox
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.txt_sal = New System.Windows.Forms.TextBox
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.txt_des = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_empid = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
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
        Me.ToolTip1.SetToolTip(Me.TabControl1, resources.GetString("TabControl1.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.TabControl1, resources.GetString("TabControl1.ToolTip1"))
        Me.TabControl1.Visible = CType(resources.GetObject("TabControl1.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.TabPage2, resources.GetString("TabPage2.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.TabPage2, resources.GetString("TabPage2.ToolTip1"))
        Me.TabPage2.ToolTipText = resources.GetString("TabPage2.ToolTipText")
        Me.TabPage2.Visible = CType(resources.GetObject("TabPage2.Visible"), Boolean)
        '
        'GroupBox4
        '
        Me.GroupBox4.AccessibleDescription = resources.GetString("GroupBox4.AccessibleDescription")
        Me.GroupBox4.AccessibleName = resources.GetString("GroupBox4.AccessibleName")
        Me.GroupBox4.Anchor = CType(resources.GetObject("GroupBox4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.dbg)
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
        Me.ToolTip2.SetToolTip(Me.GroupBox4, resources.GetString("GroupBox4.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.GroupBox4, resources.GetString("GroupBox4.ToolTip1"))
        Me.GroupBox4.Visible = CType(resources.GetObject("GroupBox4.Visible"), Boolean)
        '
        'dbg
        '
        Me.dbg.AccessibleDescription = resources.GetString("dbg.AccessibleDescription")
        Me.dbg.AccessibleName = resources.GetString("dbg.AccessibleName")
        Me.dbg.Anchor = CType(resources.GetObject("dbg.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.dbg.BackgroundImage = CType(resources.GetObject("dbg.BackgroundImage"), System.Drawing.Image)
        Me.dbg.CaptionFont = CType(resources.GetObject("dbg.CaptionFont"), System.Drawing.Font)
        Me.dbg.CaptionText = resources.GetString("dbg.CaptionText")
        Me.dbg.DataMember = ""
        Me.dbg.Dock = CType(resources.GetObject("dbg.Dock"), System.Windows.Forms.DockStyle)
        Me.dbg.Enabled = CType(resources.GetObject("dbg.Enabled"), Boolean)
        Me.dbg.Font = CType(resources.GetObject("dbg.Font"), System.Drawing.Font)
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.ImeMode = CType(resources.GetObject("dbg.ImeMode"), System.Windows.Forms.ImeMode)
        Me.dbg.Location = CType(resources.GetObject("dbg.Location"), System.Drawing.Point)
        Me.dbg.Name = "dbg"
        Me.dbg.ReadOnly = True
        Me.dbg.RightToLeft = CType(resources.GetObject("dbg.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.dbg.Size = CType(resources.GetObject("dbg.Size"), System.Drawing.Size)
        Me.dbg.TabIndex = CType(resources.GetObject("dbg.TabIndex"), Integer)
        Me.ToolTip2.SetToolTip(Me.dbg, resources.GetString("dbg.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.dbg, resources.GetString("dbg.ToolTip1"))
        Me.dbg.Visible = CType(resources.GetObject("dbg.Visible"), Boolean)
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
        Me.TabPage1.Controls.Add(Me.GroupBox3)
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
        Me.ToolTip2.SetToolTip(Me.TabPage1, resources.GetString("TabPage1.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.TabPage1, resources.GetString("TabPage1.ToolTip1"))
        Me.TabPage1.ToolTipText = resources.GetString("TabPage1.ToolTipText")
        Me.TabPage1.Visible = CType(resources.GetObject("TabPage1.Visible"), Boolean)
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = resources.GetString("GroupBox3.AccessibleDescription")
        Me.GroupBox3.AccessibleName = resources.GetString("GroupBox3.AccessibleName")
        Me.GroupBox3.Anchor = CType(resources.GetObject("GroupBox3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.dtp1)
        Me.GroupBox3.Controls.Add(Me.txt_wph)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_mob)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_add)
        Me.GroupBox3.Controls.Add(Me.txt_area)
        Me.GroupBox3.Controls.Add(Me.txt_str)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_eid)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txt_zip)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cob_coun)
        Me.GroupBox3.Controls.Add(Me.cob_sta)
        Me.GroupBox3.Controls.Add(Me.cob_city)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_bgr)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_hph)
        Me.GroupBox3.Controls.Add(Me.txt_qual)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Dock = CType(resources.GetObject("GroupBox3.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox3.Enabled = CType(resources.GetObject("GroupBox3.Enabled"), Boolean)
        Me.GroupBox3.Font = CType(resources.GetObject("GroupBox3.Font"), System.Drawing.Font)
        Me.GroupBox3.ImeMode = CType(resources.GetObject("GroupBox3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox3.Location = CType(resources.GetObject("GroupBox3.Location"), System.Drawing.Point)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = CType(resources.GetObject("GroupBox3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox3.Size = CType(resources.GetObject("GroupBox3.Size"), System.Drawing.Size)
        Me.GroupBox3.TabIndex = CType(resources.GetObject("GroupBox3.TabIndex"), Integer)
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = resources.GetString("GroupBox3.Text")
        Me.ToolTip1.SetToolTip(Me.GroupBox3, resources.GetString("GroupBox3.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.GroupBox3, resources.GetString("GroupBox3.ToolTip1"))
        Me.GroupBox3.Visible = CType(resources.GetObject("GroupBox3.Visible"), Boolean)
        '
        'dtp1
        '
        Me.dtp1.AccessibleDescription = resources.GetString("dtp1.AccessibleDescription")
        Me.dtp1.AccessibleName = resources.GetString("dtp1.AccessibleName")
        Me.dtp1.Anchor = CType(resources.GetObject("dtp1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.dtp1.BackgroundImage = CType(resources.GetObject("dtp1.BackgroundImage"), System.Drawing.Image)
        Me.dtp1.CalendarFont = CType(resources.GetObject("dtp1.CalendarFont"), System.Drawing.Font)
        Me.dtp1.CustomFormat = ""
        Me.dtp1.Dock = CType(resources.GetObject("dtp1.Dock"), System.Windows.Forms.DockStyle)
        Me.dtp1.DropDownAlign = CType(resources.GetObject("dtp1.DropDownAlign"), System.Windows.Forms.LeftRightAlignment)
        Me.dtp1.Enabled = CType(resources.GetObject("dtp1.Enabled"), Boolean)
        Me.dtp1.Font = CType(resources.GetObject("dtp1.Font"), System.Drawing.Font)
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp1.ImeMode = CType(resources.GetObject("dtp1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.dtp1.Location = CType(resources.GetObject("dtp1.Location"), System.Drawing.Point)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.RightToLeft = CType(resources.GetObject("dtp1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.dtp1.Size = CType(resources.GetObject("dtp1.Size"), System.Drawing.Size)
        Me.dtp1.TabIndex = CType(resources.GetObject("dtp1.TabIndex"), Integer)
        Me.ToolTip2.SetToolTip(Me.dtp1, resources.GetString("dtp1.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.dtp1, resources.GetString("dtp1.ToolTip1"))
        Me.dtp1.Value = New Date(2006, 6, 21, 0, 0, 0, 0)
        Me.dtp1.Visible = CType(resources.GetObject("dtp1.Visible"), Boolean)
        '
        'txt_wph
        '
        Me.txt_wph.AccessibleDescription = resources.GetString("txt_wph.AccessibleDescription")
        Me.txt_wph.AccessibleName = resources.GetString("txt_wph.AccessibleName")
        Me.txt_wph.Anchor = CType(resources.GetObject("txt_wph.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_wph.AutoSize = CType(resources.GetObject("txt_wph.AutoSize"), Boolean)
        Me.txt_wph.BackgroundImage = CType(resources.GetObject("txt_wph.BackgroundImage"), System.Drawing.Image)
        Me.txt_wph.Dock = CType(resources.GetObject("txt_wph.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_wph.Enabled = CType(resources.GetObject("txt_wph.Enabled"), Boolean)
        Me.txt_wph.Font = CType(resources.GetObject("txt_wph.Font"), System.Drawing.Font)
        Me.txt_wph.ImeMode = CType(resources.GetObject("txt_wph.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_wph.Location = CType(resources.GetObject("txt_wph.Location"), System.Drawing.Point)
        Me.txt_wph.MaxLength = CType(resources.GetObject("txt_wph.MaxLength"), Integer)
        Me.txt_wph.Multiline = CType(resources.GetObject("txt_wph.Multiline"), Boolean)
        Me.txt_wph.Name = "txt_wph"
        Me.txt_wph.PasswordChar = CType(resources.GetObject("txt_wph.PasswordChar"), Char)
        Me.txt_wph.RightToLeft = CType(resources.GetObject("txt_wph.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_wph.ScrollBars = CType(resources.GetObject("txt_wph.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_wph.Size = CType(resources.GetObject("txt_wph.Size"), System.Drawing.Size)
        Me.txt_wph.TabIndex = CType(resources.GetObject("txt_wph.TabIndex"), Integer)
        Me.txt_wph.Text = resources.GetString("txt_wph.Text")
        Me.txt_wph.TextAlign = CType(resources.GetObject("txt_wph.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_wph, resources.GetString("txt_wph.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_wph, resources.GetString("txt_wph.ToolTip1"))
        Me.txt_wph.Visible = CType(resources.GetObject("txt_wph.Visible"), Boolean)
        Me.txt_wph.WordWrap = CType(resources.GetObject("txt_wph.WordWrap"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip1"))
        Me.Label13.Visible = CType(resources.GetObject("Label13.Visible"), Boolean)
        '
        'txt_mob
        '
        Me.txt_mob.AccessibleDescription = resources.GetString("txt_mob.AccessibleDescription")
        Me.txt_mob.AccessibleName = resources.GetString("txt_mob.AccessibleName")
        Me.txt_mob.Anchor = CType(resources.GetObject("txt_mob.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_mob.AutoSize = CType(resources.GetObject("txt_mob.AutoSize"), Boolean)
        Me.txt_mob.BackgroundImage = CType(resources.GetObject("txt_mob.BackgroundImage"), System.Drawing.Image)
        Me.txt_mob.Dock = CType(resources.GetObject("txt_mob.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_mob.Enabled = CType(resources.GetObject("txt_mob.Enabled"), Boolean)
        Me.txt_mob.Font = CType(resources.GetObject("txt_mob.Font"), System.Drawing.Font)
        Me.txt_mob.ImeMode = CType(resources.GetObject("txt_mob.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_mob.Location = CType(resources.GetObject("txt_mob.Location"), System.Drawing.Point)
        Me.txt_mob.MaxLength = CType(resources.GetObject("txt_mob.MaxLength"), Integer)
        Me.txt_mob.Multiline = CType(resources.GetObject("txt_mob.Multiline"), Boolean)
        Me.txt_mob.Name = "txt_mob"
        Me.txt_mob.PasswordChar = CType(resources.GetObject("txt_mob.PasswordChar"), Char)
        Me.txt_mob.RightToLeft = CType(resources.GetObject("txt_mob.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_mob.ScrollBars = CType(resources.GetObject("txt_mob.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_mob.Size = CType(resources.GetObject("txt_mob.Size"), System.Drawing.Size)
        Me.txt_mob.TabIndex = CType(resources.GetObject("txt_mob.TabIndex"), Integer)
        Me.txt_mob.Text = resources.GetString("txt_mob.Text")
        Me.txt_mob.TextAlign = CType(resources.GetObject("txt_mob.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_mob, resources.GetString("txt_mob.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_mob, resources.GetString("txt_mob.ToolTip1"))
        Me.txt_mob.Visible = CType(resources.GetObject("txt_mob.Visible"), Boolean)
        Me.txt_mob.WordWrap = CType(resources.GetObject("txt_mob.WordWrap"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip1"))
        Me.Label11.Visible = CType(resources.GetObject("Label11.Visible"), Boolean)
        '
        'txt_add
        '
        Me.txt_add.AccessibleDescription = resources.GetString("txt_add.AccessibleDescription")
        Me.txt_add.AccessibleName = resources.GetString("txt_add.AccessibleName")
        Me.txt_add.Anchor = CType(resources.GetObject("txt_add.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_add.AutoSize = CType(resources.GetObject("txt_add.AutoSize"), Boolean)
        Me.txt_add.BackgroundImage = CType(resources.GetObject("txt_add.BackgroundImage"), System.Drawing.Image)
        Me.txt_add.Dock = CType(resources.GetObject("txt_add.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_add.Enabled = CType(resources.GetObject("txt_add.Enabled"), Boolean)
        Me.txt_add.Font = CType(resources.GetObject("txt_add.Font"), System.Drawing.Font)
        Me.txt_add.ImeMode = CType(resources.GetObject("txt_add.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_add.Location = CType(resources.GetObject("txt_add.Location"), System.Drawing.Point)
        Me.txt_add.MaxLength = CType(resources.GetObject("txt_add.MaxLength"), Integer)
        Me.txt_add.Multiline = CType(resources.GetObject("txt_add.Multiline"), Boolean)
        Me.txt_add.Name = "txt_add"
        Me.txt_add.PasswordChar = CType(resources.GetObject("txt_add.PasswordChar"), Char)
        Me.txt_add.RightToLeft = CType(resources.GetObject("txt_add.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_add.ScrollBars = CType(resources.GetObject("txt_add.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_add.Size = CType(resources.GetObject("txt_add.Size"), System.Drawing.Size)
        Me.txt_add.TabIndex = CType(resources.GetObject("txt_add.TabIndex"), Integer)
        Me.txt_add.Text = resources.GetString("txt_add.Text")
        Me.txt_add.TextAlign = CType(resources.GetObject("txt_add.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_add, resources.GetString("txt_add.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_add, resources.GetString("txt_add.ToolTip1"))
        Me.txt_add.Visible = CType(resources.GetObject("txt_add.Visible"), Boolean)
        Me.txt_add.WordWrap = CType(resources.GetObject("txt_add.WordWrap"), Boolean)
        '
        'txt_area
        '
        Me.txt_area.AccessibleDescription = resources.GetString("txt_area.AccessibleDescription")
        Me.txt_area.AccessibleName = resources.GetString("txt_area.AccessibleName")
        Me.txt_area.Anchor = CType(resources.GetObject("txt_area.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_area.AutoSize = CType(resources.GetObject("txt_area.AutoSize"), Boolean)
        Me.txt_area.BackgroundImage = CType(resources.GetObject("txt_area.BackgroundImage"), System.Drawing.Image)
        Me.txt_area.Dock = CType(resources.GetObject("txt_area.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_area.Enabled = CType(resources.GetObject("txt_area.Enabled"), Boolean)
        Me.txt_area.Font = CType(resources.GetObject("txt_area.Font"), System.Drawing.Font)
        Me.txt_area.ImeMode = CType(resources.GetObject("txt_area.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_area.Location = CType(resources.GetObject("txt_area.Location"), System.Drawing.Point)
        Me.txt_area.MaxLength = CType(resources.GetObject("txt_area.MaxLength"), Integer)
        Me.txt_area.Multiline = CType(resources.GetObject("txt_area.Multiline"), Boolean)
        Me.txt_area.Name = "txt_area"
        Me.txt_area.PasswordChar = CType(resources.GetObject("txt_area.PasswordChar"), Char)
        Me.txt_area.RightToLeft = CType(resources.GetObject("txt_area.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_area.ScrollBars = CType(resources.GetObject("txt_area.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_area.Size = CType(resources.GetObject("txt_area.Size"), System.Drawing.Size)
        Me.txt_area.TabIndex = CType(resources.GetObject("txt_area.TabIndex"), Integer)
        Me.txt_area.Text = resources.GetString("txt_area.Text")
        Me.txt_area.TextAlign = CType(resources.GetObject("txt_area.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_area, resources.GetString("txt_area.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_area, resources.GetString("txt_area.ToolTip1"))
        Me.txt_area.Visible = CType(resources.GetObject("txt_area.Visible"), Boolean)
        Me.txt_area.WordWrap = CType(resources.GetObject("txt_area.WordWrap"), Boolean)
        '
        'txt_str
        '
        Me.txt_str.AccessibleDescription = resources.GetString("txt_str.AccessibleDescription")
        Me.txt_str.AccessibleName = resources.GetString("txt_str.AccessibleName")
        Me.txt_str.Anchor = CType(resources.GetObject("txt_str.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_str.AutoSize = CType(resources.GetObject("txt_str.AutoSize"), Boolean)
        Me.txt_str.BackgroundImage = CType(resources.GetObject("txt_str.BackgroundImage"), System.Drawing.Image)
        Me.txt_str.Dock = CType(resources.GetObject("txt_str.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_str.Enabled = CType(resources.GetObject("txt_str.Enabled"), Boolean)
        Me.txt_str.Font = CType(resources.GetObject("txt_str.Font"), System.Drawing.Font)
        Me.txt_str.ImeMode = CType(resources.GetObject("txt_str.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_str.Location = CType(resources.GetObject("txt_str.Location"), System.Drawing.Point)
        Me.txt_str.MaxLength = CType(resources.GetObject("txt_str.MaxLength"), Integer)
        Me.txt_str.Multiline = CType(resources.GetObject("txt_str.Multiline"), Boolean)
        Me.txt_str.Name = "txt_str"
        Me.txt_str.PasswordChar = CType(resources.GetObject("txt_str.PasswordChar"), Char)
        Me.txt_str.RightToLeft = CType(resources.GetObject("txt_str.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_str.ScrollBars = CType(resources.GetObject("txt_str.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_str.Size = CType(resources.GetObject("txt_str.Size"), System.Drawing.Size)
        Me.txt_str.TabIndex = CType(resources.GetObject("txt_str.TabIndex"), Integer)
        Me.txt_str.Text = resources.GetString("txt_str.Text")
        Me.txt_str.TextAlign = CType(resources.GetObject("txt_str.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_str, resources.GetString("txt_str.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_str, resources.GetString("txt_str.ToolTip1"))
        Me.txt_str.Visible = CType(resources.GetObject("txt_str.Visible"), Boolean)
        Me.txt_str.WordWrap = CType(resources.GetObject("txt_str.WordWrap"), Boolean)
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
        Me.ToolTip1.SetToolTip(Me.Label15, resources.GetString("Label15.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.Label15, resources.GetString("Label15.ToolTip1"))
        Me.Label15.Visible = CType(resources.GetObject("Label15.Visible"), Boolean)
        '
        'txt_eid
        '
        Me.txt_eid.AccessibleDescription = resources.GetString("txt_eid.AccessibleDescription")
        Me.txt_eid.AccessibleName = resources.GetString("txt_eid.AccessibleName")
        Me.txt_eid.Anchor = CType(resources.GetObject("txt_eid.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_eid.AutoSize = CType(resources.GetObject("txt_eid.AutoSize"), Boolean)
        Me.txt_eid.BackgroundImage = CType(resources.GetObject("txt_eid.BackgroundImage"), System.Drawing.Image)
        Me.txt_eid.Dock = CType(resources.GetObject("txt_eid.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_eid.Enabled = CType(resources.GetObject("txt_eid.Enabled"), Boolean)
        Me.txt_eid.Font = CType(resources.GetObject("txt_eid.Font"), System.Drawing.Font)
        Me.txt_eid.ImeMode = CType(resources.GetObject("txt_eid.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_eid.Location = CType(resources.GetObject("txt_eid.Location"), System.Drawing.Point)
        Me.txt_eid.MaxLength = CType(resources.GetObject("txt_eid.MaxLength"), Integer)
        Me.txt_eid.Multiline = CType(resources.GetObject("txt_eid.Multiline"), Boolean)
        Me.txt_eid.Name = "txt_eid"
        Me.txt_eid.PasswordChar = CType(resources.GetObject("txt_eid.PasswordChar"), Char)
        Me.txt_eid.RightToLeft = CType(resources.GetObject("txt_eid.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_eid.ScrollBars = CType(resources.GetObject("txt_eid.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_eid.Size = CType(resources.GetObject("txt_eid.Size"), System.Drawing.Size)
        Me.txt_eid.TabIndex = CType(resources.GetObject("txt_eid.TabIndex"), Integer)
        Me.txt_eid.Text = resources.GetString("txt_eid.Text")
        Me.txt_eid.TextAlign = CType(resources.GetObject("txt_eid.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_eid, resources.GetString("txt_eid.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_eid, resources.GetString("txt_eid.ToolTip1"))
        Me.txt_eid.Visible = CType(resources.GetObject("txt_eid.Visible"), Boolean)
        Me.txt_eid.WordWrap = CType(resources.GetObject("txt_eid.WordWrap"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label18, resources.GetString("Label18.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label18, resources.GetString("Label18.ToolTip1"))
        Me.Label18.Visible = CType(resources.GetObject("Label18.Visible"), Boolean)
        '
        'txt_zip
        '
        Me.txt_zip.AccessibleDescription = resources.GetString("txt_zip.AccessibleDescription")
        Me.txt_zip.AccessibleName = resources.GetString("txt_zip.AccessibleName")
        Me.txt_zip.Anchor = CType(resources.GetObject("txt_zip.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_zip.AutoSize = CType(resources.GetObject("txt_zip.AutoSize"), Boolean)
        Me.txt_zip.BackgroundImage = CType(resources.GetObject("txt_zip.BackgroundImage"), System.Drawing.Image)
        Me.txt_zip.Dock = CType(resources.GetObject("txt_zip.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_zip.Enabled = CType(resources.GetObject("txt_zip.Enabled"), Boolean)
        Me.txt_zip.Font = CType(resources.GetObject("txt_zip.Font"), System.Drawing.Font)
        Me.txt_zip.ImeMode = CType(resources.GetObject("txt_zip.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_zip.Location = CType(resources.GetObject("txt_zip.Location"), System.Drawing.Point)
        Me.txt_zip.MaxLength = CType(resources.GetObject("txt_zip.MaxLength"), Integer)
        Me.txt_zip.Multiline = CType(resources.GetObject("txt_zip.Multiline"), Boolean)
        Me.txt_zip.Name = "txt_zip"
        Me.txt_zip.PasswordChar = CType(resources.GetObject("txt_zip.PasswordChar"), Char)
        Me.txt_zip.RightToLeft = CType(resources.GetObject("txt_zip.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_zip.ScrollBars = CType(resources.GetObject("txt_zip.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_zip.Size = CType(resources.GetObject("txt_zip.Size"), System.Drawing.Size)
        Me.txt_zip.TabIndex = CType(resources.GetObject("txt_zip.TabIndex"), Integer)
        Me.txt_zip.Text = resources.GetString("txt_zip.Text")
        Me.txt_zip.TextAlign = CType(resources.GetObject("txt_zip.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_zip, resources.GetString("txt_zip.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_zip, resources.GetString("txt_zip.ToolTip1"))
        Me.txt_zip.Visible = CType(resources.GetObject("txt_zip.Visible"), Boolean)
        Me.txt_zip.WordWrap = CType(resources.GetObject("txt_zip.WordWrap"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label20, resources.GetString("Label20.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label20, resources.GetString("Label20.ToolTip1"))
        Me.Label20.Visible = CType(resources.GetObject("Label20.Visible"), Boolean)
        '
        'cob_coun
        '
        Me.cob_coun.AccessibleDescription = resources.GetString("cob_coun.AccessibleDescription")
        Me.cob_coun.AccessibleName = resources.GetString("cob_coun.AccessibleName")
        Me.cob_coun.Anchor = CType(resources.GetObject("cob_coun.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cob_coun.BackgroundImage = CType(resources.GetObject("cob_coun.BackgroundImage"), System.Drawing.Image)
        Me.cob_coun.Dock = CType(resources.GetObject("cob_coun.Dock"), System.Windows.Forms.DockStyle)
        Me.cob_coun.Enabled = CType(resources.GetObject("cob_coun.Enabled"), Boolean)
        Me.cob_coun.Font = CType(resources.GetObject("cob_coun.Font"), System.Drawing.Font)
        Me.cob_coun.ImeMode = CType(resources.GetObject("cob_coun.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cob_coun.IntegralHeight = CType(resources.GetObject("cob_coun.IntegralHeight"), Boolean)
        Me.cob_coun.ItemHeight = CType(resources.GetObject("cob_coun.ItemHeight"), Integer)
        Me.cob_coun.Location = CType(resources.GetObject("cob_coun.Location"), System.Drawing.Point)
        Me.cob_coun.MaxDropDownItems = CType(resources.GetObject("cob_coun.MaxDropDownItems"), Integer)
        Me.cob_coun.MaxLength = CType(resources.GetObject("cob_coun.MaxLength"), Integer)
        Me.cob_coun.Name = "cob_coun"
        Me.cob_coun.RightToLeft = CType(resources.GetObject("cob_coun.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cob_coun.Size = CType(resources.GetObject("cob_coun.Size"), System.Drawing.Size)
        Me.cob_coun.Sorted = True
        Me.cob_coun.TabIndex = CType(resources.GetObject("cob_coun.TabIndex"), Integer)
        Me.cob_coun.Text = resources.GetString("cob_coun.Text")
        Me.ToolTip1.SetToolTip(Me.cob_coun, resources.GetString("cob_coun.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.cob_coun, resources.GetString("cob_coun.ToolTip1"))
        Me.cob_coun.Visible = CType(resources.GetObject("cob_coun.Visible"), Boolean)
        '
        'cob_sta
        '
        Me.cob_sta.AccessibleDescription = resources.GetString("cob_sta.AccessibleDescription")
        Me.cob_sta.AccessibleName = resources.GetString("cob_sta.AccessibleName")
        Me.cob_sta.Anchor = CType(resources.GetObject("cob_sta.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cob_sta.BackgroundImage = CType(resources.GetObject("cob_sta.BackgroundImage"), System.Drawing.Image)
        Me.cob_sta.Dock = CType(resources.GetObject("cob_sta.Dock"), System.Windows.Forms.DockStyle)
        Me.cob_sta.Enabled = CType(resources.GetObject("cob_sta.Enabled"), Boolean)
        Me.cob_sta.Font = CType(resources.GetObject("cob_sta.Font"), System.Drawing.Font)
        Me.cob_sta.ImeMode = CType(resources.GetObject("cob_sta.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cob_sta.IntegralHeight = CType(resources.GetObject("cob_sta.IntegralHeight"), Boolean)
        Me.cob_sta.ItemHeight = CType(resources.GetObject("cob_sta.ItemHeight"), Integer)
        Me.cob_sta.Location = CType(resources.GetObject("cob_sta.Location"), System.Drawing.Point)
        Me.cob_sta.MaxDropDownItems = CType(resources.GetObject("cob_sta.MaxDropDownItems"), Integer)
        Me.cob_sta.MaxLength = CType(resources.GetObject("cob_sta.MaxLength"), Integer)
        Me.cob_sta.Name = "cob_sta"
        Me.cob_sta.RightToLeft = CType(resources.GetObject("cob_sta.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cob_sta.Size = CType(resources.GetObject("cob_sta.Size"), System.Drawing.Size)
        Me.cob_sta.Sorted = True
        Me.cob_sta.TabIndex = CType(resources.GetObject("cob_sta.TabIndex"), Integer)
        Me.cob_sta.Text = resources.GetString("cob_sta.Text")
        Me.ToolTip1.SetToolTip(Me.cob_sta, resources.GetString("cob_sta.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.cob_sta, resources.GetString("cob_sta.ToolTip1"))
        Me.cob_sta.Visible = CType(resources.GetObject("cob_sta.Visible"), Boolean)
        '
        'cob_city
        '
        Me.cob_city.AccessibleDescription = resources.GetString("cob_city.AccessibleDescription")
        Me.cob_city.AccessibleName = resources.GetString("cob_city.AccessibleName")
        Me.cob_city.Anchor = CType(resources.GetObject("cob_city.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cob_city.BackgroundImage = CType(resources.GetObject("cob_city.BackgroundImage"), System.Drawing.Image)
        Me.cob_city.Dock = CType(resources.GetObject("cob_city.Dock"), System.Windows.Forms.DockStyle)
        Me.cob_city.Enabled = CType(resources.GetObject("cob_city.Enabled"), Boolean)
        Me.cob_city.Font = CType(resources.GetObject("cob_city.Font"), System.Drawing.Font)
        Me.cob_city.ImeMode = CType(resources.GetObject("cob_city.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cob_city.IntegralHeight = CType(resources.GetObject("cob_city.IntegralHeight"), Boolean)
        Me.cob_city.ItemHeight = CType(resources.GetObject("cob_city.ItemHeight"), Integer)
        Me.cob_city.Location = CType(resources.GetObject("cob_city.Location"), System.Drawing.Point)
        Me.cob_city.MaxDropDownItems = CType(resources.GetObject("cob_city.MaxDropDownItems"), Integer)
        Me.cob_city.MaxLength = CType(resources.GetObject("cob_city.MaxLength"), Integer)
        Me.cob_city.Name = "cob_city"
        Me.cob_city.RightToLeft = CType(resources.GetObject("cob_city.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cob_city.Size = CType(resources.GetObject("cob_city.Size"), System.Drawing.Size)
        Me.cob_city.Sorted = True
        Me.cob_city.TabIndex = CType(resources.GetObject("cob_city.TabIndex"), Integer)
        Me.cob_city.Text = resources.GetString("cob_city.Text")
        Me.ToolTip1.SetToolTip(Me.cob_city, resources.GetString("cob_city.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.cob_city, resources.GetString("cob_city.ToolTip1"))
        Me.cob_city.Visible = CType(resources.GetObject("cob_city.Visible"), Boolean)
        '
        'Label23
        '
        Me.Label23.AccessibleDescription = resources.GetString("Label23.AccessibleDescription")
        Me.Label23.AccessibleName = resources.GetString("Label23.AccessibleName")
        Me.Label23.Anchor = CType(resources.GetObject("Label23.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = CType(resources.GetObject("Label23.AutoSize"), Boolean)
        Me.Label23.Dock = CType(resources.GetObject("Label23.Dock"), System.Windows.Forms.DockStyle)
        Me.Label23.Enabled = CType(resources.GetObject("Label23.Enabled"), Boolean)
        Me.Label23.Font = CType(resources.GetObject("Label23.Font"), System.Drawing.Font)
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.ImageAlign = CType(resources.GetObject("Label23.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label23.ImageIndex = CType(resources.GetObject("Label23.ImageIndex"), Integer)
        Me.Label23.ImeMode = CType(resources.GetObject("Label23.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label23.Location = CType(resources.GetObject("Label23.Location"), System.Drawing.Point)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = CType(resources.GetObject("Label23.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label23.Size = CType(resources.GetObject("Label23.Size"), System.Drawing.Size)
        Me.Label23.TabIndex = CType(resources.GetObject("Label23.TabIndex"), Integer)
        Me.Label23.Text = resources.GetString("Label23.Text")
        Me.Label23.TextAlign = CType(resources.GetObject("Label23.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip2.SetToolTip(Me.Label23, resources.GetString("Label23.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label23, resources.GetString("Label23.ToolTip1"))
        Me.Label23.Visible = CType(resources.GetObject("Label23.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label24, resources.GetString("Label24.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label24, resources.GetString("Label24.ToolTip1"))
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
        Me.ToolTip2.SetToolTip(Me.Label25, resources.GetString("Label25.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label25, resources.GetString("Label25.ToolTip1"))
        Me.Label25.Visible = CType(resources.GetObject("Label25.Visible"), Boolean)
        '
        'Label26
        '
        Me.Label26.AccessibleDescription = resources.GetString("Label26.AccessibleDescription")
        Me.Label26.AccessibleName = resources.GetString("Label26.AccessibleName")
        Me.Label26.Anchor = CType(resources.GetObject("Label26.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = CType(resources.GetObject("Label26.AutoSize"), Boolean)
        Me.Label26.Dock = CType(resources.GetObject("Label26.Dock"), System.Windows.Forms.DockStyle)
        Me.Label26.Enabled = CType(resources.GetObject("Label26.Enabled"), Boolean)
        Me.Label26.Font = CType(resources.GetObject("Label26.Font"), System.Drawing.Font)
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.ImageAlign = CType(resources.GetObject("Label26.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label26.ImageIndex = CType(resources.GetObject("Label26.ImageIndex"), Integer)
        Me.Label26.ImeMode = CType(resources.GetObject("Label26.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label26.Location = CType(resources.GetObject("Label26.Location"), System.Drawing.Point)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = CType(resources.GetObject("Label26.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label26.Size = CType(resources.GetObject("Label26.Size"), System.Drawing.Size)
        Me.Label26.TabIndex = CType(resources.GetObject("Label26.TabIndex"), Integer)
        Me.Label26.Text = resources.GetString("Label26.Text")
        Me.Label26.TextAlign = CType(resources.GetObject("Label26.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip2.SetToolTip(Me.Label26, resources.GetString("Label26.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label26, resources.GetString("Label26.ToolTip1"))
        Me.Label26.Visible = CType(resources.GetObject("Label26.Visible"), Boolean)
        '
        'Label39
        '
        Me.Label39.AccessibleDescription = resources.GetString("Label39.AccessibleDescription")
        Me.Label39.AccessibleName = resources.GetString("Label39.AccessibleName")
        Me.Label39.Anchor = CType(resources.GetObject("Label39.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = CType(resources.GetObject("Label39.AutoSize"), Boolean)
        Me.Label39.Dock = CType(resources.GetObject("Label39.Dock"), System.Windows.Forms.DockStyle)
        Me.Label39.Enabled = CType(resources.GetObject("Label39.Enabled"), Boolean)
        Me.Label39.Font = CType(resources.GetObject("Label39.Font"), System.Drawing.Font)
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.ImageAlign = CType(resources.GetObject("Label39.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label39.ImageIndex = CType(resources.GetObject("Label39.ImageIndex"), Integer)
        Me.Label39.ImeMode = CType(resources.GetObject("Label39.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label39.Location = CType(resources.GetObject("Label39.Location"), System.Drawing.Point)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = CType(resources.GetObject("Label39.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label39.Size = CType(resources.GetObject("Label39.Size"), System.Drawing.Size)
        Me.Label39.TabIndex = CType(resources.GetObject("Label39.TabIndex"), Integer)
        Me.Label39.Text = resources.GetString("Label39.Text")
        Me.Label39.TextAlign = CType(resources.GetObject("Label39.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.Label39, resources.GetString("Label39.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.Label39, resources.GetString("Label39.ToolTip1"))
        Me.Label39.Visible = CType(resources.GetObject("Label39.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label19, resources.GetString("Label19.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label19, resources.GetString("Label19.ToolTip1"))
        Me.Label19.Visible = CType(resources.GetObject("Label19.Visible"), Boolean)
        '
        'txt_bgr
        '
        Me.txt_bgr.AccessibleDescription = resources.GetString("txt_bgr.AccessibleDescription")
        Me.txt_bgr.AccessibleName = resources.GetString("txt_bgr.AccessibleName")
        Me.txt_bgr.Anchor = CType(resources.GetObject("txt_bgr.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_bgr.AutoSize = CType(resources.GetObject("txt_bgr.AutoSize"), Boolean)
        Me.txt_bgr.BackgroundImage = CType(resources.GetObject("txt_bgr.BackgroundImage"), System.Drawing.Image)
        Me.txt_bgr.Dock = CType(resources.GetObject("txt_bgr.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_bgr.Enabled = CType(resources.GetObject("txt_bgr.Enabled"), Boolean)
        Me.txt_bgr.Font = CType(resources.GetObject("txt_bgr.Font"), System.Drawing.Font)
        Me.txt_bgr.ImeMode = CType(resources.GetObject("txt_bgr.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_bgr.Location = CType(resources.GetObject("txt_bgr.Location"), System.Drawing.Point)
        Me.txt_bgr.MaxLength = CType(resources.GetObject("txt_bgr.MaxLength"), Integer)
        Me.txt_bgr.Multiline = CType(resources.GetObject("txt_bgr.Multiline"), Boolean)
        Me.txt_bgr.Name = "txt_bgr"
        Me.txt_bgr.PasswordChar = CType(resources.GetObject("txt_bgr.PasswordChar"), Char)
        Me.txt_bgr.RightToLeft = CType(resources.GetObject("txt_bgr.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_bgr.ScrollBars = CType(resources.GetObject("txt_bgr.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_bgr.Size = CType(resources.GetObject("txt_bgr.Size"), System.Drawing.Size)
        Me.txt_bgr.TabIndex = CType(resources.GetObject("txt_bgr.TabIndex"), Integer)
        Me.txt_bgr.Text = resources.GetString("txt_bgr.Text")
        Me.txt_bgr.TextAlign = CType(resources.GetObject("txt_bgr.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_bgr, resources.GetString("txt_bgr.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_bgr, resources.GetString("txt_bgr.ToolTip1"))
        Me.txt_bgr.Visible = CType(resources.GetObject("txt_bgr.Visible"), Boolean)
        Me.txt_bgr.WordWrap = CType(resources.GetObject("txt_bgr.WordWrap"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip1"))
        Me.Label12.Visible = CType(resources.GetObject("Label12.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label10, resources.GetString("Label10.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label10, resources.GetString("Label10.ToolTip1"))
        Me.Label10.Visible = CType(resources.GetObject("Label10.Visible"), Boolean)
        '
        'txt_hph
        '
        Me.txt_hph.AccessibleDescription = resources.GetString("txt_hph.AccessibleDescription")
        Me.txt_hph.AccessibleName = resources.GetString("txt_hph.AccessibleName")
        Me.txt_hph.Anchor = CType(resources.GetObject("txt_hph.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_hph.AutoSize = CType(resources.GetObject("txt_hph.AutoSize"), Boolean)
        Me.txt_hph.BackgroundImage = CType(resources.GetObject("txt_hph.BackgroundImage"), System.Drawing.Image)
        Me.txt_hph.Dock = CType(resources.GetObject("txt_hph.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_hph.Enabled = CType(resources.GetObject("txt_hph.Enabled"), Boolean)
        Me.txt_hph.Font = CType(resources.GetObject("txt_hph.Font"), System.Drawing.Font)
        Me.txt_hph.ImeMode = CType(resources.GetObject("txt_hph.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_hph.Location = CType(resources.GetObject("txt_hph.Location"), System.Drawing.Point)
        Me.txt_hph.MaxLength = CType(resources.GetObject("txt_hph.MaxLength"), Integer)
        Me.txt_hph.Multiline = CType(resources.GetObject("txt_hph.Multiline"), Boolean)
        Me.txt_hph.Name = "txt_hph"
        Me.txt_hph.PasswordChar = CType(resources.GetObject("txt_hph.PasswordChar"), Char)
        Me.txt_hph.RightToLeft = CType(resources.GetObject("txt_hph.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_hph.ScrollBars = CType(resources.GetObject("txt_hph.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_hph.Size = CType(resources.GetObject("txt_hph.Size"), System.Drawing.Size)
        Me.txt_hph.TabIndex = CType(resources.GetObject("txt_hph.TabIndex"), Integer)
        Me.txt_hph.Text = resources.GetString("txt_hph.Text")
        Me.txt_hph.TextAlign = CType(resources.GetObject("txt_hph.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_hph, resources.GetString("txt_hph.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_hph, resources.GetString("txt_hph.ToolTip1"))
        Me.txt_hph.Visible = CType(resources.GetObject("txt_hph.Visible"), Boolean)
        Me.txt_hph.WordWrap = CType(resources.GetObject("txt_hph.WordWrap"), Boolean)
        '
        'txt_qual
        '
        Me.txt_qual.AccessibleDescription = resources.GetString("txt_qual.AccessibleDescription")
        Me.txt_qual.AccessibleName = resources.GetString("txt_qual.AccessibleName")
        Me.txt_qual.Anchor = CType(resources.GetObject("txt_qual.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_qual.AutoSize = CType(resources.GetObject("txt_qual.AutoSize"), Boolean)
        Me.txt_qual.BackgroundImage = CType(resources.GetObject("txt_qual.BackgroundImage"), System.Drawing.Image)
        Me.txt_qual.Dock = CType(resources.GetObject("txt_qual.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_qual.Enabled = CType(resources.GetObject("txt_qual.Enabled"), Boolean)
        Me.txt_qual.Font = CType(resources.GetObject("txt_qual.Font"), System.Drawing.Font)
        Me.txt_qual.ImeMode = CType(resources.GetObject("txt_qual.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_qual.Location = CType(resources.GetObject("txt_qual.Location"), System.Drawing.Point)
        Me.txt_qual.MaxLength = CType(resources.GetObject("txt_qual.MaxLength"), Integer)
        Me.txt_qual.Multiline = CType(resources.GetObject("txt_qual.Multiline"), Boolean)
        Me.txt_qual.Name = "txt_qual"
        Me.txt_qual.PasswordChar = CType(resources.GetObject("txt_qual.PasswordChar"), Char)
        Me.txt_qual.RightToLeft = CType(resources.GetObject("txt_qual.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_qual.ScrollBars = CType(resources.GetObject("txt_qual.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_qual.Size = CType(resources.GetObject("txt_qual.Size"), System.Drawing.Size)
        Me.txt_qual.TabIndex = CType(resources.GetObject("txt_qual.TabIndex"), Integer)
        Me.txt_qual.Text = resources.GetString("txt_qual.Text")
        Me.txt_qual.TextAlign = CType(resources.GetObject("txt_qual.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_qual, resources.GetString("txt_qual.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_qual, resources.GetString("txt_qual.ToolTip1"))
        Me.txt_qual.Visible = CType(resources.GetObject("txt_qual.Visible"), Boolean)
        Me.txt_qual.WordWrap = CType(resources.GetObject("txt_qual.WordWrap"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label17, resources.GetString("Label17.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label17, resources.GetString("Label17.ToolTip1"))
        Me.Label17.Visible = CType(resources.GetObject("Label17.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription")
        Me.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName")
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.dtp_doj)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cob_dept)
        Me.GroupBox1.Controls.Add(Me.txt_loc)
        Me.GroupBox1.Controls.Add(Me.txt_lname)
        Me.GroupBox1.Controls.Add(Me.txt_sal)
        Me.GroupBox1.Controls.Add(Me.txt_fname)
        Me.GroupBox1.Controls.Add(Me.txt_des)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_empid)
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
        Me.ToolTip2.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip1"))
        Me.GroupBox1.Visible = CType(resources.GetObject("GroupBox1.Visible"), Boolean)
        '
        'dtp_doj
        '
        Me.dtp_doj.AccessibleDescription = resources.GetString("dtp_doj.AccessibleDescription")
        Me.dtp_doj.AccessibleName = resources.GetString("dtp_doj.AccessibleName")
        Me.dtp_doj.Anchor = CType(resources.GetObject("dtp_doj.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.dtp_doj.BackgroundImage = CType(resources.GetObject("dtp_doj.BackgroundImage"), System.Drawing.Image)
        Me.dtp_doj.CalendarFont = CType(resources.GetObject("dtp_doj.CalendarFont"), System.Drawing.Font)
        Me.dtp_doj.Dock = CType(resources.GetObject("dtp_doj.Dock"), System.Windows.Forms.DockStyle)
        Me.dtp_doj.DropDownAlign = CType(resources.GetObject("dtp_doj.DropDownAlign"), System.Windows.Forms.LeftRightAlignment)
        Me.dtp_doj.Enabled = CType(resources.GetObject("dtp_doj.Enabled"), Boolean)
        Me.dtp_doj.Font = CType(resources.GetObject("dtp_doj.Font"), System.Drawing.Font)
        Me.dtp_doj.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_doj.ImeMode = CType(resources.GetObject("dtp_doj.ImeMode"), System.Windows.Forms.ImeMode)
        Me.dtp_doj.Location = CType(resources.GetObject("dtp_doj.Location"), System.Drawing.Point)
        Me.dtp_doj.Name = "dtp_doj"
        Me.dtp_doj.RightToLeft = CType(resources.GetObject("dtp_doj.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.dtp_doj.Size = CType(resources.GetObject("dtp_doj.Size"), System.Drawing.Size)
        Me.dtp_doj.TabIndex = CType(resources.GetObject("dtp_doj.TabIndex"), Integer)
        Me.ToolTip2.SetToolTip(Me.dtp_doj, resources.GetString("dtp_doj.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.dtp_doj, resources.GetString("dtp_doj.ToolTip1"))
        Me.dtp_doj.Value = New Date(2006, 8, 7, 0, 0, 0, 0)
        Me.dtp_doj.Visible = CType(resources.GetObject("dtp_doj.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip1"))
        Me.Label6.Visible = CType(resources.GetObject("Label6.Visible"), Boolean)
        '
        'cob_dept
        '
        Me.cob_dept.AccessibleDescription = resources.GetString("cob_dept.AccessibleDescription")
        Me.cob_dept.AccessibleName = resources.GetString("cob_dept.AccessibleName")
        Me.cob_dept.Anchor = CType(resources.GetObject("cob_dept.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cob_dept.BackgroundImage = CType(resources.GetObject("cob_dept.BackgroundImage"), System.Drawing.Image)
        Me.cob_dept.Dock = CType(resources.GetObject("cob_dept.Dock"), System.Windows.Forms.DockStyle)
        Me.cob_dept.Enabled = CType(resources.GetObject("cob_dept.Enabled"), Boolean)
        Me.cob_dept.Font = CType(resources.GetObject("cob_dept.Font"), System.Drawing.Font)
        Me.cob_dept.ImeMode = CType(resources.GetObject("cob_dept.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cob_dept.IntegralHeight = CType(resources.GetObject("cob_dept.IntegralHeight"), Boolean)
        Me.cob_dept.ItemHeight = CType(resources.GetObject("cob_dept.ItemHeight"), Integer)
        Me.cob_dept.Items.AddRange(New Object() {resources.GetString("cob_dept.Items"), resources.GetString("cob_dept.Items1"), resources.GetString("cob_dept.Items2"), resources.GetString("cob_dept.Items3"), resources.GetString("cob_dept.Items4")})
        Me.cob_dept.Location = CType(resources.GetObject("cob_dept.Location"), System.Drawing.Point)
        Me.cob_dept.MaxDropDownItems = CType(resources.GetObject("cob_dept.MaxDropDownItems"), Integer)
        Me.cob_dept.MaxLength = CType(resources.GetObject("cob_dept.MaxLength"), Integer)
        Me.cob_dept.Name = "cob_dept"
        Me.cob_dept.RightToLeft = CType(resources.GetObject("cob_dept.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cob_dept.Size = CType(resources.GetObject("cob_dept.Size"), System.Drawing.Size)
        Me.cob_dept.TabIndex = CType(resources.GetObject("cob_dept.TabIndex"), Integer)
        Me.cob_dept.Text = resources.GetString("cob_dept.Text")
        Me.ToolTip1.SetToolTip(Me.cob_dept, resources.GetString("cob_dept.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.cob_dept, resources.GetString("cob_dept.ToolTip1"))
        Me.cob_dept.Visible = CType(resources.GetObject("cob_dept.Visible"), Boolean)
        '
        'txt_loc
        '
        Me.txt_loc.AccessibleDescription = resources.GetString("txt_loc.AccessibleDescription")
        Me.txt_loc.AccessibleName = resources.GetString("txt_loc.AccessibleName")
        Me.txt_loc.Anchor = CType(resources.GetObject("txt_loc.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_loc.AutoSize = CType(resources.GetObject("txt_loc.AutoSize"), Boolean)
        Me.txt_loc.BackgroundImage = CType(resources.GetObject("txt_loc.BackgroundImage"), System.Drawing.Image)
        Me.txt_loc.Dock = CType(resources.GetObject("txt_loc.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_loc.Enabled = CType(resources.GetObject("txt_loc.Enabled"), Boolean)
        Me.txt_loc.Font = CType(resources.GetObject("txt_loc.Font"), System.Drawing.Font)
        Me.txt_loc.ImeMode = CType(resources.GetObject("txt_loc.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_loc.Location = CType(resources.GetObject("txt_loc.Location"), System.Drawing.Point)
        Me.txt_loc.MaxLength = CType(resources.GetObject("txt_loc.MaxLength"), Integer)
        Me.txt_loc.Multiline = CType(resources.GetObject("txt_loc.Multiline"), Boolean)
        Me.txt_loc.Name = "txt_loc"
        Me.txt_loc.PasswordChar = CType(resources.GetObject("txt_loc.PasswordChar"), Char)
        Me.txt_loc.RightToLeft = CType(resources.GetObject("txt_loc.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_loc.ScrollBars = CType(resources.GetObject("txt_loc.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_loc.Size = CType(resources.GetObject("txt_loc.Size"), System.Drawing.Size)
        Me.txt_loc.TabIndex = CType(resources.GetObject("txt_loc.TabIndex"), Integer)
        Me.txt_loc.Text = resources.GetString("txt_loc.Text")
        Me.txt_loc.TextAlign = CType(resources.GetObject("txt_loc.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_loc, resources.GetString("txt_loc.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_loc, resources.GetString("txt_loc.ToolTip1"))
        Me.txt_loc.Visible = CType(resources.GetObject("txt_loc.Visible"), Boolean)
        Me.txt_loc.WordWrap = CType(resources.GetObject("txt_loc.WordWrap"), Boolean)
        '
        'txt_lname
        '
        Me.txt_lname.AccessibleDescription = resources.GetString("txt_lname.AccessibleDescription")
        Me.txt_lname.AccessibleName = resources.GetString("txt_lname.AccessibleName")
        Me.txt_lname.Anchor = CType(resources.GetObject("txt_lname.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_lname.AutoSize = CType(resources.GetObject("txt_lname.AutoSize"), Boolean)
        Me.txt_lname.BackgroundImage = CType(resources.GetObject("txt_lname.BackgroundImage"), System.Drawing.Image)
        Me.txt_lname.Dock = CType(resources.GetObject("txt_lname.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_lname.Enabled = CType(resources.GetObject("txt_lname.Enabled"), Boolean)
        Me.txt_lname.Font = CType(resources.GetObject("txt_lname.Font"), System.Drawing.Font)
        Me.txt_lname.ImeMode = CType(resources.GetObject("txt_lname.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_lname.Location = CType(resources.GetObject("txt_lname.Location"), System.Drawing.Point)
        Me.txt_lname.MaxLength = CType(resources.GetObject("txt_lname.MaxLength"), Integer)
        Me.txt_lname.Multiline = CType(resources.GetObject("txt_lname.Multiline"), Boolean)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.PasswordChar = CType(resources.GetObject("txt_lname.PasswordChar"), Char)
        Me.txt_lname.RightToLeft = CType(resources.GetObject("txt_lname.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_lname.ScrollBars = CType(resources.GetObject("txt_lname.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_lname.Size = CType(resources.GetObject("txt_lname.Size"), System.Drawing.Size)
        Me.txt_lname.TabIndex = CType(resources.GetObject("txt_lname.TabIndex"), Integer)
        Me.txt_lname.Text = resources.GetString("txt_lname.Text")
        Me.txt_lname.TextAlign = CType(resources.GetObject("txt_lname.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_lname, resources.GetString("txt_lname.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_lname, resources.GetString("txt_lname.ToolTip1"))
        Me.txt_lname.Visible = CType(resources.GetObject("txt_lname.Visible"), Boolean)
        Me.txt_lname.WordWrap = CType(resources.GetObject("txt_lname.WordWrap"), Boolean)
        '
        'txt_sal
        '
        Me.txt_sal.AccessibleDescription = resources.GetString("txt_sal.AccessibleDescription")
        Me.txt_sal.AccessibleName = resources.GetString("txt_sal.AccessibleName")
        Me.txt_sal.Anchor = CType(resources.GetObject("txt_sal.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_sal.AutoSize = CType(resources.GetObject("txt_sal.AutoSize"), Boolean)
        Me.txt_sal.BackgroundImage = CType(resources.GetObject("txt_sal.BackgroundImage"), System.Drawing.Image)
        Me.txt_sal.Dock = CType(resources.GetObject("txt_sal.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_sal.Enabled = CType(resources.GetObject("txt_sal.Enabled"), Boolean)
        Me.txt_sal.Font = CType(resources.GetObject("txt_sal.Font"), System.Drawing.Font)
        Me.txt_sal.ImeMode = CType(resources.GetObject("txt_sal.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_sal.Location = CType(resources.GetObject("txt_sal.Location"), System.Drawing.Point)
        Me.txt_sal.MaxLength = CType(resources.GetObject("txt_sal.MaxLength"), Integer)
        Me.txt_sal.Multiline = CType(resources.GetObject("txt_sal.Multiline"), Boolean)
        Me.txt_sal.Name = "txt_sal"
        Me.txt_sal.PasswordChar = CType(resources.GetObject("txt_sal.PasswordChar"), Char)
        Me.txt_sal.RightToLeft = CType(resources.GetObject("txt_sal.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_sal.ScrollBars = CType(resources.GetObject("txt_sal.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_sal.Size = CType(resources.GetObject("txt_sal.Size"), System.Drawing.Size)
        Me.txt_sal.TabIndex = CType(resources.GetObject("txt_sal.TabIndex"), Integer)
        Me.txt_sal.Text = resources.GetString("txt_sal.Text")
        Me.txt_sal.TextAlign = CType(resources.GetObject("txt_sal.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_sal, resources.GetString("txt_sal.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_sal, resources.GetString("txt_sal.ToolTip1"))
        Me.txt_sal.Visible = CType(resources.GetObject("txt_sal.Visible"), Boolean)
        Me.txt_sal.WordWrap = CType(resources.GetObject("txt_sal.WordWrap"), Boolean)
        '
        'txt_fname
        '
        Me.txt_fname.AccessibleDescription = resources.GetString("txt_fname.AccessibleDescription")
        Me.txt_fname.AccessibleName = resources.GetString("txt_fname.AccessibleName")
        Me.txt_fname.Anchor = CType(resources.GetObject("txt_fname.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_fname.AutoSize = CType(resources.GetObject("txt_fname.AutoSize"), Boolean)
        Me.txt_fname.BackgroundImage = CType(resources.GetObject("txt_fname.BackgroundImage"), System.Drawing.Image)
        Me.txt_fname.Dock = CType(resources.GetObject("txt_fname.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_fname.Enabled = CType(resources.GetObject("txt_fname.Enabled"), Boolean)
        Me.txt_fname.Font = CType(resources.GetObject("txt_fname.Font"), System.Drawing.Font)
        Me.txt_fname.ImeMode = CType(resources.GetObject("txt_fname.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_fname.Location = CType(resources.GetObject("txt_fname.Location"), System.Drawing.Point)
        Me.txt_fname.MaxLength = CType(resources.GetObject("txt_fname.MaxLength"), Integer)
        Me.txt_fname.Multiline = CType(resources.GetObject("txt_fname.Multiline"), Boolean)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.PasswordChar = CType(resources.GetObject("txt_fname.PasswordChar"), Char)
        Me.txt_fname.RightToLeft = CType(resources.GetObject("txt_fname.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_fname.ScrollBars = CType(resources.GetObject("txt_fname.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_fname.Size = CType(resources.GetObject("txt_fname.Size"), System.Drawing.Size)
        Me.txt_fname.TabIndex = CType(resources.GetObject("txt_fname.TabIndex"), Integer)
        Me.txt_fname.Text = resources.GetString("txt_fname.Text")
        Me.txt_fname.TextAlign = CType(resources.GetObject("txt_fname.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_fname, resources.GetString("txt_fname.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_fname, resources.GetString("txt_fname.ToolTip1"))
        Me.txt_fname.Visible = CType(resources.GetObject("txt_fname.Visible"), Boolean)
        Me.txt_fname.WordWrap = CType(resources.GetObject("txt_fname.WordWrap"), Boolean)
        '
        'txt_des
        '
        Me.txt_des.AccessibleDescription = resources.GetString("txt_des.AccessibleDescription")
        Me.txt_des.AccessibleName = resources.GetString("txt_des.AccessibleName")
        Me.txt_des.Anchor = CType(resources.GetObject("txt_des.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_des.AutoSize = CType(resources.GetObject("txt_des.AutoSize"), Boolean)
        Me.txt_des.BackgroundImage = CType(resources.GetObject("txt_des.BackgroundImage"), System.Drawing.Image)
        Me.txt_des.Dock = CType(resources.GetObject("txt_des.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_des.Enabled = CType(resources.GetObject("txt_des.Enabled"), Boolean)
        Me.txt_des.Font = CType(resources.GetObject("txt_des.Font"), System.Drawing.Font)
        Me.txt_des.ImeMode = CType(resources.GetObject("txt_des.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_des.Location = CType(resources.GetObject("txt_des.Location"), System.Drawing.Point)
        Me.txt_des.MaxLength = CType(resources.GetObject("txt_des.MaxLength"), Integer)
        Me.txt_des.Multiline = CType(resources.GetObject("txt_des.Multiline"), Boolean)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.PasswordChar = CType(resources.GetObject("txt_des.PasswordChar"), Char)
        Me.txt_des.RightToLeft = CType(resources.GetObject("txt_des.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_des.ScrollBars = CType(resources.GetObject("txt_des.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_des.Size = CType(resources.GetObject("txt_des.Size"), System.Drawing.Size)
        Me.txt_des.TabIndex = CType(resources.GetObject("txt_des.TabIndex"), Integer)
        Me.txt_des.Text = resources.GetString("txt_des.Text")
        Me.txt_des.TextAlign = CType(resources.GetObject("txt_des.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_des, resources.GetString("txt_des.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_des, resources.GetString("txt_des.ToolTip1"))
        Me.txt_des.Visible = CType(resources.GetObject("txt_des.Visible"), Boolean)
        Me.txt_des.WordWrap = CType(resources.GetObject("txt_des.WordWrap"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip1"))
        Me.Label7.Visible = CType(resources.GetObject("Label7.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip1"))
        Me.Label5.Visible = CType(resources.GetObject("Label5.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip1"))
        Me.Label4.Visible = CType(resources.GetObject("Label4.Visible"), Boolean)
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
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        Me.ToolTip2.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip1"))
        Me.Label3.Visible = CType(resources.GetObject("Label3.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip1"))
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label8, resources.GetString("Label8.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label8, resources.GetString("Label8.ToolTip1"))
        Me.Label8.Visible = CType(resources.GetObject("Label8.Visible"), Boolean)
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
        Me.ToolTip2.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip1"))
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'txt_empid
        '
        Me.txt_empid.AccessibleDescription = resources.GetString("txt_empid.AccessibleDescription")
        Me.txt_empid.AccessibleName = resources.GetString("txt_empid.AccessibleName")
        Me.txt_empid.Anchor = CType(resources.GetObject("txt_empid.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txt_empid.AutoSize = CType(resources.GetObject("txt_empid.AutoSize"), Boolean)
        Me.txt_empid.BackgroundImage = CType(resources.GetObject("txt_empid.BackgroundImage"), System.Drawing.Image)
        Me.txt_empid.Dock = CType(resources.GetObject("txt_empid.Dock"), System.Windows.Forms.DockStyle)
        Me.txt_empid.Enabled = CType(resources.GetObject("txt_empid.Enabled"), Boolean)
        Me.txt_empid.Font = CType(resources.GetObject("txt_empid.Font"), System.Drawing.Font)
        Me.txt_empid.ImeMode = CType(resources.GetObject("txt_empid.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txt_empid.Location = CType(resources.GetObject("txt_empid.Location"), System.Drawing.Point)
        Me.txt_empid.MaxLength = CType(resources.GetObject("txt_empid.MaxLength"), Integer)
        Me.txt_empid.Multiline = CType(resources.GetObject("txt_empid.Multiline"), Boolean)
        Me.txt_empid.Name = "txt_empid"
        Me.txt_empid.PasswordChar = CType(resources.GetObject("txt_empid.PasswordChar"), Char)
        Me.txt_empid.RightToLeft = CType(resources.GetObject("txt_empid.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txt_empid.ScrollBars = CType(resources.GetObject("txt_empid.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txt_empid.Size = CType(resources.GetObject("txt_empid.Size"), System.Drawing.Size)
        Me.txt_empid.TabIndex = CType(resources.GetObject("txt_empid.TabIndex"), Integer)
        Me.txt_empid.Text = resources.GetString("txt_empid.Text")
        Me.txt_empid.TextAlign = CType(resources.GetObject("txt_empid.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip2.SetToolTip(Me.txt_empid, resources.GetString("txt_empid.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.txt_empid, resources.GetString("txt_empid.ToolTip1"))
        Me.txt_empid.Visible = CType(resources.GetObject("txt_empid.Visible"), Boolean)
        Me.txt_empid.WordWrap = CType(resources.GetObject("txt_empid.WordWrap"), Boolean)
        '
        'Staff_Master
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.TabControl1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "Staff_Master"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.ToolTip2.SetToolTip(Me, resources.GetString("$this.ToolTip1"))
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ord As OleDb.OleDbDataReader
    Dim d_adp As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDb.OleDbCommand
    Dim cmd1 As OleDb.OleDbCommand
    Dim recmode As EnuRecstatus


    Private Sub Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()
        'selecting tabpage1 as default page
        TabControl1.SelectedTab = TabPage1
        'loading comboboxs as with relavent data
        load_cob()
        disproc()
        dtp1.MaxDate = Now.Date
    End Sub

    Public Sub saveproc()
        If txt_add.Text = "" Then
            MsgBox("address should not be empty")
            txt_add.Focus()
            Exit Sub
        End If

        If txt_fname.Text = "" Then
            MsgBox(" first name should not be empty")
            txt_fname.Focus()
            Exit Sub
        End If

        If txt_empid.Text = "" Then
            MsgBox(" employee id should not be empty")
            txt_empid.Focus()
            Exit Sub
        End If

        If txt_loc.Text = "" Then
            MsgBox("location should not be empty")
            txt_loc.Focus()
            Exit Sub
        End If

        If txt_lname.Text = "" Then
            MsgBox(" last name should not be empty")
            txt_lname.Focus()
            Exit Sub
        End If

        If txt_des.Text = "" Then
            MsgBox("designation should not be empty")
            txt_des.Focus()
            Exit Sub
        End If

        If cob_dept.Text = "" Then
            MsgBox("department name should not empty")
            cob_dept.Focus()
            Exit Sub
        End If

        If recmode = Module1.EnuRecstatus.Recnew Then
            insproc()
            clearproc()
            disproc()
        ElseIf recmode = Module1.EnuRecstatus.Recedit Then
            updproc()
            clearproc()
            disproc()
        End If
    End Sub

    Public Sub delproc()
        Dim str_eid As String
        Dim int_p As Integer
        Dim str_yesno As String
        str_eid = txt_empid.Text
        Openconnection()
        ' checking for employee details in UserMaster
        cmd = New OleDb.OleDbCommand("select count(*) from UserMaster Where EmployeeId='" & str_eid & "'", con)
        int_p = cmd.ExecuteScalar
        cmd.Dispose()
        If int_p >= 1 Then
            MsgBox(txt_empid.Text & " " & "details are in UserMaster")
            MsgBox("Delete from UserMaster")
            Exit Sub
        End If
        'Checking For Employee Details in OwnVehicleMaster 
        cmd = New OleDb.OleDbCommand("select count(*) from OwnVehicleMaster Where EmployeeId='" & str_eid & "'", con)
        int_p = cmd.ExecuteScalar
        cmd.Dispose()
        If int_p >= 1 Then
            MsgBox(txt_empid.Text & " " & "details are in OwnVehicleMaster")
            MsgBox("Delete from OwnVehicleMaster")
            Exit Sub
        End If

        'confirming the delete
        str_yesno = MsgDelAlert()
        If str_yesno = vbYes Then
            cmd = New OleDb.OleDbCommand("delete from EmployeeMaster where EmployeeId='" & str_eid & "'", con)
            cmd1 = New OleDb.OleDbCommand("  delete from EmpPersonaMaster where EmployeeId='" & str_eid & "'", con)
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            cmd.Dispose()
            cmd1.Dispose()
            con.Close()
            MsgDel()
        ElseIf str_yesno = vbNo Then
            Exit Sub
        End If
    End Sub
    ' procedure for clearing the object in the form
    Public Sub clearproc()
        Dim obj As Object
        Dim obj1 As Object

        For Each obj In Me.GroupBox1.Controls
            If TypeOf (obj) Is TextBox Then
                obj.text = ""
            End If
            If TypeOf (obj) Is ComboBox Then
                obj.text = ""
            End If
            If TypeOf (obj) Is DateTimePicker Then
                obj.Refresh()
            End If
        Next

        For Each obj1 In Me.GroupBox3.Controls
            If TypeOf (obj1) Is TextBox Then
                obj1.text = ""
            End If
            If TypeOf (obj1) Is ComboBox Then
                obj1.text = ""
            End If
            If TypeOf (obj1) Is DateTimePicker Then
                obj1.Refresh()
            End If
        Next
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        ' loading data to view data from tabes
        ds = New DataSet
        If TabControl1.SelectedTab Is TabPage2 Then
            d_adp = New OleDb.OleDbDataAdapter("select m.employeeid, m.firstname, m.lastname, m.department, m.location, m.designation, m.salary,p.DateofBirth,p.Qualification,p.Address1,p.Street,p.Area,p.CityId,p.StateId,p.CountryId,p.ZIP,p.MobileNO, p.WorkPhone, p.HomePhone, p.EmailId, p.BloodGroup from employeemaster m, EmpPersonaMaster p where m.employeeid = p.employeeid ", con)

            ds.Reset()
            d_adp.Fill(ds, "empm")
            dbg.DataSource = ds.Tables("empm")
            dbg.ReadOnly = True

        End If


        ' loading data into city, state, country combo boxs
        If TabControl1.SelectedTab Is TabPage1 Then
            cob_clr()
            load_cob()

        End If
    End Sub
    Public Sub cob_clr()
        'procedure  for clearing the comboboxs
        cob_city.Items.Clear()
        cob_sta.Items.Clear()
        cob_coun.Items.Clear()
    End Sub
    Public Sub load_cob()
        'loading comboboxs with relavent data from citymaster,statemaster,country master
        Openconnection()
        cmd = New OleDb.OleDbCommand("select country from CountryMaster", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_coun.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
        con.Close()
    End Sub
    Public Sub insproc()
        'procedure for inserting the new values in employeemaster,emppersonamaster
        Dim int_p As Integer
        Dim str_ci As String
        Dim str_st As String
        Dim str_con As String
        Dim str_str As String
        Dim str_ciT As String
        Dim str_stT As String
        Dim str_conT As String

        Openconnection()
        str_ci = cob_city.Text
        str_st = cob_sta.Text
        str_con = cob_coun.Text

        ' getting relative data of cityid,stateid,countryid

        cmd = New OleDb.OleDbCommand("select c.CityId,s.StateId,CO.CountryId from CityMaster C, CountryMaster CO,StateMaster s where C.City ='" & str_ci & "' and CO.Country ='" & str_con & "' and s.state='" & str_st & "'", con)

        ord = cmd.ExecuteReader
        While ord.Read
            str_ciT = ord(0)
            str_stT = ord(1)
            str_conT = ord(2)
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("select EmployeeId from EmployeeMaster where EmployeeId = '" & txt_empid.Text & "'", con)
        int_p = cmd.ExecuteScalar
        If int_p >= 1 Then
            MsgBox(" duplicate employee id")
            cmd.Dispose()
            con.Close()
            Exit Sub
            'txt_empid.Focus()
        End If
        Try
            ' inserting data into empmaster and emppersonamaster
            cmd = New OleDb.OleDbCommand("insert into EmployeeMaster values( '" & txt_empid.Text & "','" & txt_fname.Text & "','" & txt_lname.Text & "','" & cob_dept.Text & "','" & txt_loc.Text & "','" & txt_des.Text & "'," & Val(txt_sal.Text) & ",'" & dtp_doj.Value & "')", con)
            cmd1 = New OleDb.OleDbCommand("insert into EmpPersonaMaster values( '" & txt_empid.Text & "','" & dtp1.Value & "','" & txt_qual.Text & "','" & txt_add.Text & "','" & txt_str.Text & "','" & txt_area.Text & "','" & str_ciT & "' ,'" & str_stT & "' ,'" & str_conT & "' ," & Val(txt_zip.Text) & "," & Val(txt_mob.Text) & "," & Val(txt_wph.Text) & ", " & Val(txt_hph.Text) & ",'" & txt_eid.Text & "','" & txt_bgr.Text & "' )", con)
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        cmd.Dispose()
        cmd1.Dispose()
        CloseConnection()
        MsgSav()
    End Sub
    Public Sub newproc()
        'procedure for new entry values
        enproc()
        txt_empid.ReadOnly = False

        recmode = Module1.EnuRecstatus.Recnew
        cob_clr()
        clearproc()
        load_cob()
        'selecting tabpage1 as default page
        TabControl1.SelectedTab = TabPage1
        txt_empid.Focus()
    End Sub
    Public Sub editproc()
        'procedure for editting values
        enproc()
        txt_empid.ReadOnly = True
        recmode = Module1.EnuRecstatus.Recedit
        cob_clr()
        load_cob()
    End Sub

    Public Sub updproc()
        'procedure for updating
        Dim str_ci As String
        Dim str_st As String
        Dim str_con As String
        Dim str_str As String
        Dim str_ciT As String
        Dim str_stT As String
        Dim str_conT As String
        Openconnection()
        str_ci = cob_city.Text
        str_st = cob_sta.Text
        str_con = cob_coun.Text

        ' getting relative data of cityid,stateid,countryid

        cmd = New OleDb.OleDbCommand("select c.CityId,s.StateId,CO.CountryId from CityMaster C, CountryMaster CO,StateMaster s where C.City ='" & str_ci & "' and CO.Country ='" & str_con & "' and s.state='" & str_st & "'", con)

        ord = cmd.ExecuteReader
        While ord.Read
            str_ciT = ord(0)
            str_stT = ord(1)
            str_conT = ord(2)
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("update EmployeeMaster set Firstname ='" & txt_fname.Text & "',Lastname ='" & txt_lname.Text & "',Department='" & cob_dept.Text & "',Location='" & txt_loc.Text & "',Designation='" & txt_des.Text & "',Salary=" & Val(txt_sal.Text) & ",DOJ='" & dtp_doj.Value & "' where EmployeeID='" & txt_empid.Text & "'", con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("update EmpPersonaMaster set DateofBirth='" & dtp1.Value & "',Qualification='" & txt_qual.Text & "',Address1='" & txt_add.Text & "',Street='" & txt_str.Text & "',Area='" & txt_area.Text & "',CityId='" & str_ciT & "',StateId='" & str_stT & "',CountryId='" & str_conT & "',ZIP=" & Val(txt_zip.Text) & ",MobileNo=" & Val(txt_mob.Text) & ",WorkPhone=" & Val(txt_wph.Text) & ",HomePhone=" & Val(txt_hph.Text) & ",EmailId='" & txt_eid.Text & "',BloodGroup='" & txt_bgr.Text & "' where EmployeeId='" & txt_empid.Text & "'", con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgSav()
        con.Close()
    End Sub

    Private Sub dbg_dclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbg.DoubleClick
        'passing values from datagrid to relavent textboxs when double clicked on datagrid
        Dim str_str As String
        str_str = dbg.Item(dbg.CurrentRowIndex, 0)
        Dim cmd As OleDb.OleDbCommand
        Dim ord As OleDb.OleDbDataReader
        Dim str_ci As String
        Dim str_si As String
        Dim str_coi As String

        Openconnection()
        cmd = New OleDb.OleDbCommand("select * from EmployeeMaster where EmployeeId='" & str_str & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            txt_empid.Text = ord(0)
            txt_empid.ReadOnly = True
            txt_fname.Text = ord(1)
            txt_lname.Text = ord(2)
            cob_dept.Text = ord(3)
            txt_loc.Text = ord(4)
            txt_des.Text = ord(5)
            txt_sal.Text = ord(6)
            dtp_doj.Text = ord(7)
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("select * from EmpPersonaMaster where EmployeeId='" & str_str & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            dtp1.Value = ord(1)
            txt_qual.Text = ord(2)
            txt_add.Text = ord(3)
            txt_str.Text = ord(4)
            txt_area.Text = ord(5)
            str_ci = ord(6)
            str_si = ord(7)
            str_coi = ord(8)
            txt_zip.Text = ord(9)
            txt_mob.Text = ord(10)
            txt_wph.Text = ord(11)
            txt_hph.Text = ord(12)
            txt_eid.Text = ord(13)
            txt_bgr.Text = ord(14)
        End While
        ord.Close()
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("select c.city, s.state, co.country  from CityMaster c,StateMaster s,CountryMaster co where C.CityId = '" & str_ci & "' and c.StateId = s.StateId and c.CountryId = co.CountryId", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_city.Text = ord(0)
            cob_sta.Text = ord(1)
            cob_coun.Text = ord(2)
        End While
        ord.Close()
        cmd.Dispose()
        CloseConnection()
        TabControl1.SelectedTab = TabPage1
        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()
    End Sub


    Private Sub txt_sal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sal.KeyPress
        Numb_Digit_Only(txt_sal.Text, e)

    End Sub

    Private Sub txt_wph_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_wph.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_mob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mob.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_hph_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hph.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_zip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_zip.KeyPress
        numberonly(e)
    End Sub

    Private Sub txt_add_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_add.Leave

        firstcap(txt_add)
    End Sub

    Private Sub txt_area_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_area.Leave
        firstcap(txt_area)
    End Sub

    Private Sub txt_bgr_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bgr.Leave
        firstcap(txt_bgr)
    End Sub
    Private Sub txt_des_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_des.Leave

        firstcap(txt_des)
    End Sub

    Private Sub txt_lname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_lname.Leave

        firstcap(txt_lname)
    End Sub

    Private Sub txt_loc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_loc.Leave

        firstcap(txt_loc)
    End Sub

    Private Sub txt_qual_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_qual.Leave
        firstcap(txt_qual)
    End Sub

    Private Sub txt_str_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_str.Leave
        firstcap(txt_str)
    End Sub

    Private Sub txt_fname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_fname.Leave

        firstcap(txt_fname)
    End Sub

    Private Sub txt_empid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_empid.Leave
        firstcap(txt_empid)
    End Sub

    Private Sub txt_eid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_eid.Leave
        email(txt_eid)
    End Sub

    Private Sub txt_loc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_loc.TextChanged
    End Sub
    Public Sub disproc()
        ' procedure to disable all textboxs and comboboxs
        Dim x As Object
        For Each x In GroupBox3.Controls
            If TypeOf (x) Is TextBox Then
                x.enabled = False
            End If
            If TypeOf (x) Is ComboBox Then
                x.enabled = False
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.enabled = False
            End If
        Next
        For Each x In GroupBox1.Controls
            If TypeOf (x) Is TextBox Then
                x.enabled = False
            End If
            If TypeOf (x) Is ComboBox Then
                x.enabled = False
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.enabled = False
            End If
        Next

    End Sub
    Public Sub enproc()
        Dim x As Object
        'procedure to enable all textboxs and comboboxs
        For Each x In GroupBox3.Controls
            If TypeOf (x) Is TextBox Then
                x.enabled = True
            End If
            If TypeOf (x) Is ComboBox Then
                x.enabled = True
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.enabled = True
            End If
        Next
        For Each x In GroupBox1.Controls
            If TypeOf (x) Is TextBox Then
                x.enabled = True
            End If
            If TypeOf (x) Is ComboBox Then
                x.enabled = True
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.enabled = True
            End If
        Next
    End Sub

    Private Sub cob_coun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_coun.SelectedIndexChanged
        Openconnection()
        cmd = New OleDb.OleDbCommand("select state from StateMaster s,CountryMaster co where co.CountryId = s.CountryId and co.Country = '" & cob_coun.SelectedItem & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_sta.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub cob_sta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_sta.SelectedIndexChanged
        Openconnection()
        cmd = New OleDb.OleDbCommand(" select city from CityMaster c, StateMaster s where c.StateId = s.StateId and s.State = '" & cob_sta.SelectedItem & "' ", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_city.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub cob_city_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_city.KeyPress
        combo(e)
    End Sub

    Private Sub cob_coun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_coun.KeyPress
        combo(e)
    End Sub

    Private Sub txt_fname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fname.KeyPress
        textonly(e)
    End Sub
    Private Sub cob_sta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_sta.KeyPress
        combo(e)
    End Sub
    Private Sub cob_dept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_dept.KeyPress
        combo(e)
    End Sub

    Private Sub txt_lname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lname.KeyPress
        textonly(e)
    End Sub

    Private Sub txt_sal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sal.Leave
        Dim s As String
        s = Mid(txt_sal.Text, 1, 2)
        If s = "0" Then
            MsgBox("Salary Should not start with ZERO")
            txt_sal.Focus()
            Exit Sub
        End If
    End Sub
End Class

