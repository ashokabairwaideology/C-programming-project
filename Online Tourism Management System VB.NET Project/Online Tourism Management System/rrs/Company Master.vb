'Name developer: R.Rajesh,ch.shiva,Kamal.K.Trood
'Dt:05/07/06
'Purpose :
'Version :1

Imports System.Data.OleDb
Public Class company_master
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtphone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtzip As System.Windows.Forms.TextBox
    Friend WithEvents combocountry As System.Windows.Forms.ComboBox
    Friend WithEvents combocity As System.Windows.Forms.ComboBox
    Friend WithEvents combostate As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcompid As System.Windows.Forms.TextBox
    Friend WithEvents txtcompname As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchid As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchfax As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchemailid As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchremarks As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchphone As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchphone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchzip As System.Windows.Forms.TextBox
    Friend WithEvents combobranchcountry As System.Windows.Forms.ComboBox
    Friend WithEvents combobranchcity As System.Windows.Forms.ComboBox
    Friend WithEvents combobranchstate As System.Windows.Forms.ComboBox
    Friend WithEvents txtbranchaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchaddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchname As System.Windows.Forms.TextBox
    Friend WithEvents txtcompregid As System.Windows.Forms.TextBox
    Friend WithEvents txtvatno As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txttinno As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dgview As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(company_master))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txttinno = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtcompregid = New System.Windows.Forms.TextBox
        Me.txtvatno = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtfax = New System.Windows.Forms.TextBox
        Me.txtemailid = New System.Windows.Forms.TextBox
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.txtphone2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtzip = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.combocountry = New System.Windows.Forms.ComboBox
        Me.combocity = New System.Windows.Forms.ComboBox
        Me.combostate = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtaddress1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtcompid = New System.Windows.Forms.TextBox
        Me.txtcompname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtbranchid = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtbranchfax = New System.Windows.Forms.TextBox
        Me.txtbranchemailid = New System.Windows.Forms.TextBox
        Me.txtbranchremarks = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtbranchphone = New System.Windows.Forms.TextBox
        Me.txtbranchphone2 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtbranchzip = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.combobranchcountry = New System.Windows.Forms.ComboBox
        Me.combobranchcity = New System.Windows.Forms.ComboBox
        Me.combobranchstate = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtbranchaddress = New System.Windows.Forms.TextBox
        Me.txtbranchaddress1 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtbranchname = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(504, 344)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(496, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgview)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 272)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgview
        '
        Me.dgview.CaptionVisible = False
        Me.dgview.DataMember = ""
        Me.dgview.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgview.Location = New System.Drawing.Point(8, 16)
        Me.dgview.Name = "dgview"
        Me.dgview.Size = New System.Drawing.Size(472, 248)
        Me.dgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txttinno)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.txtcompregid)
        Me.TabPage2.Controls.Add(Me.txtvatno)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.txtcompid)
        Me.TabPage2.Controls.Add(Me.txtcompname)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(496, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'txttinno
        '
        Me.txttinno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinno.Location = New System.Drawing.Point(408, 40)
        Me.txttinno.MaxLength = 20
        Me.txttinno.Name = "txttinno"
        Me.txttinno.Size = New System.Drawing.Size(80, 21)
        Me.txttinno.TabIndex = 4
        Me.txttinno.Text = ""
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(328, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 16)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Tin Number"
        '
        'txtcompregid
        '
        Me.txtcompregid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompregid.Location = New System.Drawing.Point(104, 40)
        Me.txtcompregid.MaxLength = 20
        Me.txtcompregid.Name = "txtcompregid"
        Me.txtcompregid.Size = New System.Drawing.Size(80, 21)
        Me.txtcompregid.TabIndex = 2
        Me.txtcompregid.Text = ""
        '
        'txtvatno
        '
        Me.txtvatno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvatno.Location = New System.Drawing.Point(240, 40)
        Me.txtvatno.MaxLength = 20
        Me.txtvatno.Name = "txtvatno"
        Me.txtvatno.Size = New System.Drawing.Size(80, 21)
        Me.txtvatno.TabIndex = 3
        Me.txtvatno.Text = ""
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(192, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 16)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Vat No"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(0, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 16)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Company Reg Id "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtfax)
        Me.GroupBox2.Controls.Add(Me.txtemailid)
        Me.GroupBox2.Controls.Add(Me.txtremarks)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtphone)
        Me.GroupBox2.Controls.Add(Me.txtphone2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtzip)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.combocountry)
        Me.GroupBox2.Controls.Add(Me.combocity)
        Me.GroupBox2.Controls.Add(Me.combostate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtaddress1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 248)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 17)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Fax"
        '
        'txtfax
        '
        Me.txtfax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfax.Location = New System.Drawing.Point(72, 144)
        Me.txtfax.MaxLength = 12
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(152, 21)
        Me.txtfax.TabIndex = 13
        Me.txtfax.Text = ""
        '
        'txtemailid
        '
        Me.txtemailid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemailid.Location = New System.Drawing.Point(328, 144)
        Me.txtemailid.MaxLength = 50
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(144, 21)
        Me.txtemailid.TabIndex = 14
        Me.txtemailid.Text = ""
        '
        'txtremarks
        '
        Me.txtremarks.AutoSize = False
        Me.txtremarks.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Location = New System.Drawing.Point(72, 176)
        Me.txtremarks.MaxLength = 50
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremarks.Size = New System.Drawing.Size(152, 64)
        Me.txtremarks.TabIndex = 15
        Me.txtremarks.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(256, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Email Id"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(16, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Remarks"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(72, 112)
        Me.txtphone.MaxLength = 12
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(152, 21)
        Me.txtphone.TabIndex = 11
        Me.txtphone.Text = ""
        '
        'txtphone2
        '
        Me.txtphone2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone2.Location = New System.Drawing.Point(328, 112)
        Me.txtphone2.MaxLength = 12
        Me.txtphone2.Name = "txtphone2"
        Me.txtphone2.Size = New System.Drawing.Size(144, 21)
        Me.txtphone2.TabIndex = 12
        Me.txtphone2.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Phone1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(256, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Phone 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtzip
        '
        Me.txtzip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtzip.Location = New System.Drawing.Point(328, 80)
        Me.txtzip.MaxLength = 7
        Me.txtzip.Name = "txtzip"
        Me.txtzip.Size = New System.Drawing.Size(144, 21)
        Me.txtzip.TabIndex = 10
        Me.txtzip.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(256, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "State"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(16, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Country"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'combocountry
        '
        Me.combocountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocountry.ItemHeight = 13
        Me.combocountry.Location = New System.Drawing.Point(72, 48)
        Me.combocountry.Name = "combocountry"
        Me.combocountry.Size = New System.Drawing.Size(152, 21)
        Me.combocountry.Sorted = True
        Me.combocountry.TabIndex = 7
        '
        'combocity
        '
        Me.combocity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocity.ItemHeight = 13
        Me.combocity.Location = New System.Drawing.Point(72, 80)
        Me.combocity.Name = "combocity"
        Me.combocity.Size = New System.Drawing.Size(152, 21)
        Me.combocity.Sorted = True
        Me.combocity.TabIndex = 9
        '
        'combostate
        '
        Me.combostate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combostate.ItemHeight = 13
        Me.combostate.Location = New System.Drawing.Point(328, 48)
        Me.combostate.Name = "combostate"
        Me.combostate.Size = New System.Drawing.Size(144, 21)
        Me.combostate.Sorted = True
        Me.combostate.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(16, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "City"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(72, 16)
        Me.txtaddress.MaxLength = 30
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(152, 21)
        Me.txtaddress.TabIndex = 5
        Me.txtaddress.Text = ""
        '
        'txtaddress1
        '
        Me.txtaddress1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress1.Location = New System.Drawing.Point(328, 16)
        Me.txtaddress1.MaxLength = 30
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.Size = New System.Drawing.Size(144, 21)
        Me.txtaddress1.TabIndex = 6
        Me.txtaddress1.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(16, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 17)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Address "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(256, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Address 1"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(256, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 16)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "ZIP"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcompid
        '
        Me.txtcompid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompid.Location = New System.Drawing.Point(104, 16)
        Me.txtcompid.MaxLength = 5
        Me.txtcompid.Name = "txtcompid"
        Me.txtcompid.Size = New System.Drawing.Size(56, 21)
        Me.txtcompid.TabIndex = 0
        Me.txtcompid.Text = ""
        '
        'txtcompname
        '
        Me.txtcompname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompname.Location = New System.Drawing.Point(288, 16)
        Me.txtcompname.MaxLength = 30
        Me.txtcompname.Name = "txtcompname"
        Me.txtcompname.Size = New System.Drawing.Size(200, 21)
        Me.txtcompname.TabIndex = 1
        Me.txtcompname.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Company Name *"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Id *"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtbranchid)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.txtbranchname)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(496, 318)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Branch Details"
        '
        'txtbranchid
        '
        Me.txtbranchid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchid.Location = New System.Drawing.Point(80, 16)
        Me.txtbranchid.MaxLength = 5
        Me.txtbranchid.Name = "txtbranchid"
        Me.txtbranchid.Size = New System.Drawing.Size(64, 21)
        Me.txtbranchid.TabIndex = 0
        Me.txtbranchid.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 17)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Branch Id"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtbranchfax)
        Me.GroupBox3.Controls.Add(Me.txtbranchemailid)
        Me.GroupBox3.Controls.Add(Me.txtbranchremarks)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtbranchphone)
        Me.GroupBox3.Controls.Add(Me.txtbranchphone2)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtbranchzip)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.combobranchcountry)
        Me.GroupBox3.Controls.Add(Me.combobranchcity)
        Me.GroupBox3.Controls.Add(Me.combobranchstate)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtbranchaddress)
        Me.GroupBox3.Controls.Add(Me.txtbranchaddress1)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 264)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Fax No"
        '
        'txtbranchfax
        '
        Me.txtbranchfax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchfax.Location = New System.Drawing.Point(72, 144)
        Me.txtbranchfax.MaxLength = 12
        Me.txtbranchfax.Name = "txtbranchfax"
        Me.txtbranchfax.Size = New System.Drawing.Size(152, 21)
        Me.txtbranchfax.TabIndex = 8
        Me.txtbranchfax.Text = ""
        '
        'txtbranchemailid
        '
        Me.txtbranchemailid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchemailid.Location = New System.Drawing.Point(328, 144)
        Me.txtbranchemailid.MaxLength = 50
        Me.txtbranchemailid.Name = "txtbranchemailid"
        Me.txtbranchemailid.Size = New System.Drawing.Size(144, 21)
        Me.txtbranchemailid.TabIndex = 9
        Me.txtbranchemailid.Text = ""
        '
        'txtbranchremarks
        '
        Me.txtbranchremarks.AutoSize = False
        Me.txtbranchremarks.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchremarks.Location = New System.Drawing.Point(72, 176)
        Me.txtbranchremarks.MaxLength = 50
        Me.txtbranchremarks.Multiline = True
        Me.txtbranchremarks.Name = "txtbranchremarks"
        Me.txtbranchremarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbranchremarks.Size = New System.Drawing.Size(152, 64)
        Me.txtbranchremarks.TabIndex = 10
        Me.txtbranchremarks.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(264, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Email Id"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(16, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 17)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Remarks"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbranchphone
        '
        Me.txtbranchphone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchphone.Location = New System.Drawing.Point(72, 112)
        Me.txtbranchphone.MaxLength = 12
        Me.txtbranchphone.Name = "txtbranchphone"
        Me.txtbranchphone.Size = New System.Drawing.Size(152, 21)
        Me.txtbranchphone.TabIndex = 6
        Me.txtbranchphone.Text = ""
        '
        'txtbranchphone2
        '
        Me.txtbranchphone2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchphone2.Location = New System.Drawing.Point(328, 112)
        Me.txtbranchphone2.MaxLength = 12
        Me.txtbranchphone2.Name = "txtbranchphone2"
        Me.txtbranchphone2.Size = New System.Drawing.Size(144, 21)
        Me.txtbranchphone2.TabIndex = 7
        Me.txtbranchphone2.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(16, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 17)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Phone1"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(264, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 17)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Phone 2"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbranchzip
        '
        Me.txtbranchzip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchzip.Location = New System.Drawing.Point(328, 80)
        Me.txtbranchzip.MaxLength = 7
        Me.txtbranchzip.Name = "txtbranchzip"
        Me.txtbranchzip.Size = New System.Drawing.Size(144, 21)
        Me.txtbranchzip.TabIndex = 5
        Me.txtbranchzip.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(264, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 17)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "State"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(16, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 17)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Country"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'combobranchcountry
        '
        Me.combobranchcountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobranchcountry.ItemHeight = 13
        Me.combobranchcountry.Location = New System.Drawing.Point(72, 48)
        Me.combobranchcountry.Name = "combobranchcountry"
        Me.combobranchcountry.Size = New System.Drawing.Size(152, 21)
        Me.combobranchcountry.Sorted = True
        Me.combobranchcountry.TabIndex = 2
        '
        'combobranchcity
        '
        Me.combobranchcity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobranchcity.ItemHeight = 13
        Me.combobranchcity.Location = New System.Drawing.Point(72, 80)
        Me.combobranchcity.Name = "combobranchcity"
        Me.combobranchcity.Size = New System.Drawing.Size(152, 21)
        Me.combobranchcity.Sorted = True
        Me.combobranchcity.TabIndex = 4
        '
        'combobranchstate
        '
        Me.combobranchstate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobranchstate.ItemHeight = 13
        Me.combobranchstate.Location = New System.Drawing.Point(328, 48)
        Me.combobranchstate.Name = "combobranchstate"
        Me.combobranchstate.Size = New System.Drawing.Size(144, 21)
        Me.combobranchstate.Sorted = True
        Me.combobranchstate.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(16, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(26, 17)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "City"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbranchaddress
        '
        Me.txtbranchaddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchaddress.Location = New System.Drawing.Point(72, 16)
        Me.txtbranchaddress.MaxLength = 30
        Me.txtbranchaddress.Name = "txtbranchaddress"
        Me.txtbranchaddress.Size = New System.Drawing.Size(152, 21)
        Me.txtbranchaddress.TabIndex = 0
        Me.txtbranchaddress.Text = ""
        '
        'txtbranchaddress1
        '
        Me.txtbranchaddress1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchaddress1.Location = New System.Drawing.Point(328, 16)
        Me.txtbranchaddress1.MaxLength = 30
        Me.txtbranchaddress1.Name = "txtbranchaddress1"
        Me.txtbranchaddress1.Size = New System.Drawing.Size(144, 21)
        Me.txtbranchaddress1.TabIndex = 1
        Me.txtbranchaddress1.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(16, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 17)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Address "
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(264, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 17)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Address 1"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(264, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(24, 16)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "ZIP"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbranchname
        '
        Me.txtbranchname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchname.Location = New System.Drawing.Point(296, 16)
        Me.txtbranchname.MaxLength = 30
        Me.txtbranchname.Name = "txtbranchname"
        Me.txtbranchname.Size = New System.Drawing.Size(176, 21)
        Me.txtbranchname.TabIndex = 1
        Me.txtbranchname.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(208, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 17)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Branch Name"
        '
        'company_master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(504, 341)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "company_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim recmode As EnuRecstatus   '  To findout record status
    Dim t, t1 As OleDbTransaction
    ' Dim con As New OleDbConnection("provider=Microsoft.jet.oledb.4.0;data source=E:\TRAVELZ30-JUNE\travelz.mdb")
    Private Sub company_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'Opens entry/edit page on pageload
        TabControl1.SelectedTab = TabPage2
        'fills the combobox from country master table
        combofill1(combocountry, "select * from countrymaster")
        'fills the combobox from country master table
        combofill1(combobranchcountry, "select * from countrymaster")
        'locks the controls in the form 
        lock()
    End Sub
    Public Sub lock()
        'Locks the controls in entry/edit tabpage
        txtcompid.ReadOnly = True
        txtcompname.ReadOnly = True
        txtcompregid.ReadOnly = True
        txtvatno.ReadOnly = True
        txttinno.ReadOnly = True
        txtaddress.ReadOnly = True
        txtaddress1.ReadOnly = True
        txtzip.ReadOnly = True
        combocountry.Enabled = False
        combocity.Enabled = False
        combostate.Enabled = False
        txtphone.ReadOnly = True
        txtphone2.ReadOnly = True
        txtfax.ReadOnly = True
        txtemailid.ReadOnly = True
        txtremarks.ReadOnly = True
        'Locks the controls in branch details tabpage
        txtbranchid.ReadOnly = True
        txtbranchname.ReadOnly = True
        txtbranchaddress.ReadOnly = True
        txtbranchaddress1.ReadOnly = True
        combobranchcountry.Enabled = False
        combobranchcity.Enabled = False
        combobranchstate.Enabled = False
        txtbranchzip.ReadOnly = True
        txtbranchphone.ReadOnly = True
        txtbranchphone2.ReadOnly = True
        txtbranchfax.ReadOnly = True
        txtbranchemailid.ReadOnly = True
        txtbranchremarks.ReadOnly = True
    End Sub
    'Clears the controls on the form
    Public Sub clearproc()
        Dim ctrl As Control
        'Entry Edit
        txtcompid.Text = ""
        txtcompname.Text = ""
        txtcompregid.Text = ""
        txtvatno.Text = ""
        txttinno.Text = ""

        'Branch 
        txtbranchid.Text = ""
        txtbranchname.Text = ""

        For Each ctrl In Me.GroupBox2.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next

        For Each ctrl In Me.GroupBox3.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    'It enables the enables the input controls to insert a new record
    Public Sub newproc()
        Dim cmd As OleDbCommand
        'Form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        Try
            Openconnection()
            Dim p As Integer = 0
            cmd = New OleDbCommand("select count(*) from CompanyMaster", con)
            p = cmd.ExecuteScalar
            If p = 1 Then
                MsgBox("Record Already Exists,You Cant Enter Another Record", MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
        'Clears the controls
        clearproc()
        ' Unlocks the controls in entry/edit tabpage
        txtcompid.ReadOnly = False
        txtcompname.ReadOnly = False
        txtcompregid.ReadOnly = False
        txtvatno.ReadOnly = False
        txttinno.ReadOnly = False
        txtaddress.ReadOnly = False
        txtaddress1.ReadOnly = False
        txtzip.ReadOnly = False
        txtphone.ReadOnly = False
        txtphone2.ReadOnly = False
        combocountry.Enabled = True
        combocity.Enabled = True
        combostate.Enabled = True
        txtfax.ReadOnly = False
        txtemailid.ReadOnly = False
        txtremarks.ReadOnly = False
        'Unlocks the controls in branch details tabpage
        txtbranchid.ReadOnly = False
        txtbranchname.ReadOnly = False
        txtbranchaddress.ReadOnly = False
        txtbranchaddress1.ReadOnly = False
        combobranchcountry.Enabled = True
        combobranchcity.Enabled = True
        combobranchstate.Enabled = True
        txtbranchzip.ReadOnly = False
        txtbranchphone.ReadOnly = False
        txtbranchphone2.ReadOnly = False
        txtbranchfax.ReadOnly = False
        txtbranchemailid.ReadOnly = False
        txtbranchremarks.ReadOnly = False
        'Cursor gets into countryid textbox
        TabControl1.SelectedTab = TabPage2
        txtcompid.Focus()
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        Dim cmd, cmd1, cmd2 As OleDbCommand
        'checks whether the textboxes are empty
        If txtcompid.Text = "" Then
            MsgBox(" Enter Company Id", MsgBoxStyle.OKOnly, Prjtitle)
            txtcompid.Focus()
            Exit Sub
        End If
        If txtcompname.Text = "" Then
            MsgBox(" Enter Company Name", MsgBoxStyle.OKOnly, Prjtitle)
            txtcompname.Focus()
            Exit Sub
        End If
        If combocountry.Text = "" Then
            MsgBox(" Enter Country Id", MsgBoxStyle.OKOnly, Prjtitle)
            combocountry.Focus()
            Exit Sub
        End If
        If combostate.Text = "" Then
            MsgBox(" Enter State Id", MsgBoxStyle.OKOnly, Prjtitle)
            combostate.Focus()
            Exit Sub
        End If
        If combocity.Text = "" Then
            MsgBox(" Enter City Id", MsgBoxStyle.OKOnly, Prjtitle)
            combocity.Focus()
            Exit Sub
        End If
        Label1.Focus()
        Try
            Dim x, y As Byte
            Dim i, j As Byte
            Dim comcou, comstate, comcity, combrancoun, combracity, combrastate As String
            Dim a, b, c, d, e, f As String
            'saves data before the "-" country id combobox 
            comcou = combocountry.Text
            a = (comcou.Substring(0, comcou.IndexOf("-")))
            'saves data before the "-" state id combobox
            comstate = combostate.Text
            b = (comstate.Substring(0, comstate.IndexOf("-")))
            'saves data before the "-" city id combobox 
            comcity = combocity.Text
            c = (comcity.Substring(0, comcity.IndexOf("-")))
            'checks whether it is new mode or edit mode
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                t = con.BeginTransaction
                'Dim p As Integer
                'p = 0
                'cmd = New OleDbCommand("select count(*) from CompanyMaster", con)
                ''cmd = New OleDbCommand("select count(*) from CompanyMaster where companyid='" & Trim(txtcompid.Text) & "'", con)
                ''cmd1 = New OleDbCommand("select count(*) from Comp_Branch where companyid='" & Trim(txtcompid.Text) & "'", con)
                'p = cmd.ExecuteScalar
                ''q = cmd1.ExecuteScalar
                ''cmd1.Dispose()
                'If p = 1 Then
                '    ' to show the message that record exsisted already
                '    'MsgRecexist()
                '    MsgBox("Record Already Exists,You Cant Enter Another Record", MsgBoxStyle.OKOnly, Prjtitle)
                '    txtcompid.Focus()
                '    clearproc()
                '    Exit Sub
                'Else
                    Try
                        cmd1 = New OleDbCommand("insert into CompanyMaster values('" & txtcompid.Text & "','" & txtcompname.Text & "','" & IIf(txtcompregid.Text = "", 0, txtcompregid.Text) & "','" & IIf(txtvatno.Text = "", 0, txtvatno.Text) & "','" & IIf(txttinno.Text = "", 0, txttinno.Text) & "','" & IIf(txtaddress.Text = "", 0, txtaddress.Text) & "','" & IIf(txtaddress1.Text = "", 0, txtaddress1.Text) & "','" & c & "','" & b & "','" & a & "'," & IIf(txtzip.Text = "", 0, txtzip.Text) & "," & IIf(txtphone.Text = "", 0, txtphone.Text) & "," & IIf(txtphone2.Text = "", 0, txtphone2.Text) & "," & IIf(txtfax.Text = "", 0, txtfax.Text) & ",'" & IIf(txtemailid.Text = "", 0, txtemailid.Text) & "','" & IIf(txtremarks.Text = "", 0, txtremarks.Text) & "')", con)
                        cmd1.Transaction = t
                        x = cmd1.ExecuteNonQuery()
                        cmd1.Dispose()
                        If txtbranchid.Text <> "" And txtbranchname.Text <> "" Then
                            If x = 1 Then
                                'saves data before the "-" country id combobox
                                combrancoun = combobranchcountry.SelectedItem
                                d = (combrancoun.Substring(0, combrancoun.IndexOf("-")))
                                'saves data before the "-" city id combobox 
                                combracity = combobranchcity.SelectedItem
                                e = (combracity.Substring(0, combracity.IndexOf("-")))
                                'saves data before the "-" state id combobox 
                                combrastate = combobranchstate.SelectedItem
                                f = (combrastate.Substring(0, combrastate.IndexOf("-")))
                                cmd1 = New OleDbCommand("insert into Comp_Branch values('" & txtcompid.Text & "','" & txtbranchid.Text & "','" & txtbranchname.Text & "','" & IIf(txtbranchaddress.Text = "", 0, txtbranchaddress.Text) & "','" & IIf(txtbranchaddress1.Text = "", 0, txtbranchaddress1.Text) & "','" & e & "','" & f & "','" & d & "'," & IIf(txtbranchzip.Text = "", 0, txtbranchzip.Text) & "," & IIf(txtbranchphone.Text = "", 0, txtbranchphone.Text) & "," & IIf(txtbranchphone2.Text = "", 0, txtbranchphone2.Text) & "," & IIf(txtbranchfax.Text = "", 0, txtbranchfax.Text) & ",'" & IIf(txtbranchemailid.Text = "", 0, txtbranchemailid.Text) & "','" & IIf(txtbranchremarks.Text = "", 0, txtbranchremarks.Text) & "')", con)
                                cmd1.Transaction = t
                                x = cmd1.ExecuteNonQuery()
                                cmd1.Dispose()
                                If x = 1 Then
                                    t.Commit()
                                    'Displays the updated message in messagebox
                                    MsgSav()
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
                        Else
                            t.Commit()
                            'Displays the updated message in messagebox
                            MsgSav()
                            'clears the controls
                            clearproc()
                            ' locks the controls
                            lock()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                        t.Rollback()
                    Finally
                        con.Close()
                    End Try
                'End If
            End If
            If recmode = Module1.EnuRecstatus.Recedit Then
                Dim z As Boolean = False
                Try
                    Openconnection()
                    t1 = con.BeginTransaction
                    cmd2 = New OleDbCommand("update CompanyMaster set CompanyName='" & txtcompname.Text & "',Com_Regist_No ='" & IIf(txtcompregid.Text = "", 0, txtcompregid.Text) & "',Vat_No= '" & IIf(txtvatno.Text = "", 0, txtvatno.Text) & "',Tin_No='" & IIf(txttinno.Text = "", 0, txttinno.Text) & "',Address='" & IIf(txtaddress.Text = "", 0, txtaddress.Text) & "',Address1='" & IIf(txtaddress1.Text = "", 0, txtaddress1.Text) & "',CityId='" & c & "',StateId='" & b & "',CountryId='" & a & "',Zip=" & IIf(txtzip.Text = "", 0, txtzip.Text) & ",Phone1=" & IIf(txtphone.Text = "", 0, txtphone.Text) & ",Phone2=" & IIf(txtphone2.Text = "", 0, txtphone2.Text) & ",Fax=" & IIf(txtfax.Text = "", 0, txtfax.Text) & ",Email= '" & IIf(txtemailid.Text = "", 0, txtemailid.Text) & "',Remarks=  '" & IIf(txtremarks.Text = "", 0, txtremarks.Text) & "' where CompanyID='" & txtcompid.Text & "'", con)
                    cmd2.Transaction = t1
                    y = cmd2.ExecuteNonQuery()
                    cmd2.Dispose()
                    Dim q As Byte
                    cmd2 = New OleDbCommand("select count(*) from comp_branch", con)
                    cmd2.Transaction = t1
                    q = cmd2.ExecuteScalar
                    cmd2.Dispose()
                    If txtbranchid.Text <> "" And txtbranchname.Text <> "" Then
                        If q = 1 Then
                            If y = 1 Then
                                'saves data before the "-" country id combobox
                                combrancoun = combobranchcountry.SelectedItem
                                d = (combrancoun.Substring(0, combrancoun.IndexOf("-")))
                                'saves data before the "-" city id combobox 
                                combracity = combobranchcity.SelectedItem
                                e = (combracity.Substring(0, combracity.IndexOf("-")))
                                'saves data before the "-" state id combobox 
                                combrastate = combobranchstate.SelectedItem
                                f = (combrastate.Substring(0, combrastate.IndexOf("-")))
                                cmd2 = New OleDbCommand("update Comp_Branch set Branchid ='" & txtbranchid.Text & "',Branchname= '" & txtbranchname.Text & "',Address='" & IIf(txtbranchaddress.Text = "", 0, txtbranchaddress.Text) & "',Address1='" & IIf(txtbranchaddress1.Text = "", 0, txtbranchaddress1.Text) & "',CityId='" & e & "',StateId='" & f & "',CountryId='" & d & "',Zip=" & IIf(txtbranchzip.Text = "", 0, txtbranchzip.Text) & ",Phone1=" & IIf(txtbranchphone.Text = "", 0, txtbranchphone.Text) & ",Phone2=" & IIf(txtbranchphone2.Text = "", 0, txtbranchphone2.Text) & ",Fax=" & IIf(txtbranchfax.Text = "", 0, txtbranchfax.Text) & ",Email= '" & IIf(txtbranchemailid.Text = "", 0, txtbranchemailid.Text) & "',Remarks=  '" & IIf(txtbranchremarks.Text = "", 0, txtbranchremarks.Text) & "' where companyid='" & txtcompid.Text & "'", con)
                                cmd2.Transaction = t1
                                y = cmd2.ExecuteNonQuery()
                                cmd2.Dispose()
                                If y = 1 Then
                                    z = True
                                    t1.Commit()
                                    ''Displays the updated message in messagebox
                                    'MsgSav()
                                    ''clears the controls
                                    'clearproc()
                                    '' locks the controls
                                    'lock()
                                Else
                                    t1.Rollback()
                                End If
                            Else
                                t1.Rollback()
                            End If
                        Else
                            MsgBox("You Cannot Add Branch Details", MsgBoxStyle.OKOnly, Prjtitle)
                        End If
                    End If
                    If z = False Then
                        t1.Commit()
                    End If
                    'Displays the updated message in messagebox
                    MsgSav()
                    'clears the controls
                    clearproc()
                    ' locks the controls
                    lock()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                    
                    t1.Rollback()
                    CloseConnection()
                    Exit Sub
                Finally
                    CloseConnection()
                End Try
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
        'locks the control
        txtcompid.ReadOnly = True
        ' Unlocks the controls in entry/edit tabpage
        txtcompname.ReadOnly = False
        txtcompregid.ReadOnly = False
        txtvatno.ReadOnly = False
        txttinno.ReadOnly = False
        txtaddress.ReadOnly = False
        txtaddress1.ReadOnly = False
        txtzip.ReadOnly = False
        txtphone.ReadOnly = False
        txtphone2.ReadOnly = False
        combocountry.Enabled = True
        combocity.Enabled = True
        combostate.Enabled = True
        txtfax.ReadOnly = False
        txtemailid.ReadOnly = False
        txtremarks.ReadOnly = False
        'cursor gets into joining date
        txtcompname.Focus()
        'Unlocks the controls in branch details tabpage
        txtbranchid.ReadOnly = False
        txtbranchname.ReadOnly = False
        txtbranchaddress.ReadOnly = False
        txtbranchaddress1.ReadOnly = False
        combobranchcity.Enabled = True
        combobranchcountry.Enabled = True
        combobranchstate.Enabled = True
        txtbranchzip.ReadOnly = False
        txtbranchphone.ReadOnly = False
        txtbranchphone2.ReadOnly = False
        txtbranchfax.ReadOnly = False
        txtbranchemailid.ReadOnly = False
        txtbranchremarks.ReadOnly = False
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes the particular record
    Public Sub delproc()
        Dim p As Byte
        Dim cmd, cmd1 As OleDbCommand
        'Dim  As New OleDbCommand
        Dim i As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "delete from CompanyMaster where CompanyId='" & txtcompid.Text & "'"
            cmd1 = New OleDbCommand("select count(*) from Comp_Branch where companyid='" & Trim(txtcompid.Text) & "'", con)
            p = cmd1.ExecuteScalar
            cmd1.Dispose()
            If p <> 0 Then
                Dim str1 As String = "delete from Comp_Branch where companyid='" & txtcompid.Text & "'"
                cmd1 = New OleDbCommand(str1, con)
                cmd1.ExecuteNonQuery()
            End If
            cmd = New OleDbCommand(str, con)
            i = cmd.ExecuteNonQuery()
            con.Close()
            If i > 0 Then
                MsgDel()
                'clears the controls
                clearproc()
                'Else
                '    MsgBox("Record Not Found", MsgBoxStyle.OKOnly, Prjtitle)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Dim da As New OleDbDataAdapter("select * from CompanyMaster", con)
        Dim ds As New DataSet
        'It clears the dataset 
        ds.Clear()
        'Data in the table country master will be displayed 
        'in datagrid on click in view tab page
        da.Fill(ds, "compmaster")
        dgview.Refresh()
        dgview.DataSource = ds.Tables("CompMaster")
        dgview.ReadOnly = True
    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgview.DoubleClick
        Dim i As String
        Dim k, p As Integer
        Dim dr As OleDb.OleDbDataReader
        Dim cmd, cmd1 As OleDbCommand
        Dim x, y, z, cit, stat, cou, city, state, country As String
        Dim a, b, c, co, st, ci, cobr, stbr, cibr As String
        'locks the controls in the form 
        lock()
        'clears the combobox
        combocountry.Text = ""
        combostate.Text = ""
        combocity.Text = ""
        'fills the current row index number in k
        k = dgview.CurrentRowIndex
        Dim dr1 As OleDbDataReader
        'fills the value of row in i
        i = dgview.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from CompanyMaster where CompanyId='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtcompid.Text = dr(0)
                txtcompname.Text = dr(1)
                txtcompregid.Text = dr(2)
                txtvatno.Text = dr(3)
                txttinno.Text = dr(4)
                txtaddress.Text = dr(5)
                txtaddress1.Text = dr(6)
                'combocity.Text = dr(7)-assigns value into z
                z = dr(7)
                'combostate.Text = dr(8)-assigns value into y
                y = dr(8)
                'combocountry.Text = dr(9)-assigns value into x
                x = dr(9)
                txtzip.Text = dr(10)
                txtphone.Text = dr(11)
                txtphone2.Text = dr(12)
                txtfax.Text = dr(13)
                txtemailid.Text = dr(14)
                txtremarks.Text = dr(15)
                
            End If
            CloseConnection()
            'country
            Openconnection()
            cmd1 = New OleDbCommand("select country from countrymaster where countryid='" & x & "'", con)
            country = cmd1.ExecuteScalar
            cmd1.Dispose()
            cou = x & "-" & country
            combocountry.SelectedText = cou
            CloseConnection()
            'state
            Openconnection()
            cmd1 = New OleDbCommand("select state from statemaster where stateid='" & y & "'", con)
            state = cmd1.ExecuteScalar
            cmd1.Dispose()
            stat = y & "-" & state
            combostate.SelectedText = stat
            CloseConnection()
            'city
            Openconnection()
            cmd1 = New OleDbCommand("select city from citymaster where cityid='" & z & "'", con)
            city = cmd1.ExecuteScalar
            cmd1.Dispose()
            cit = z & "-" & city
            combocity.SelectedText = cit
            CloseConnection()
            'if record exsists in company branch
            Openconnection()
            cmd1 = New OleDbCommand("select count(*) from Comp_Branch where companyid='" & i & "'", con)
            p = cmd1.ExecuteScalar
            cmd1.Dispose()
            If p <> 0 Then
                'clears the combobox
                combobranchcountry.Text = ""
                combobranchstate.Text = ""
                combobranchcity.Text = ""
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                cmd1 = New OleDbCommand("select * from comp_branch where companyid='" & i & "'", con)
                dr1 = cmd1.ExecuteReader
                If dr1.Read Then
                    txtbranchid.Text = dr1(1)
                    txtbranchname.Text = dr1(2)
                    txtbranchaddress.Text = dr1(3)
                    txtbranchaddress1.Text = dr1(4)
                    'combobranchcity.Text = dr1(5)-assigns value into a
                    a = dr1(5)
                    ' combobranchstate.Text = dr1(6)-assigns value into b
                    b = dr1(6)
                    'combobranchcountry.Text = dr1(7)-assigns value into c
                    c = dr1(7)
                    txtbranchzip.Text = dr1(8)
                    txtbranchphone.Text = dr1(9)
                    txtbranchphone2.Text = dr1(10)
                    txtbranchfax.Text = dr1(11)
                    txtbranchemailid.Text = dr1(12)
                    txtbranchremarks.Text = dr1(13)
                    
                End If
                dr1.Close()
                cmd1.Dispose()
                CloseConnection()
                'country
                Openconnection()
                cmd1 = New OleDbCommand("select country from countrymaster where countryid='" & c & "'", con)
                cobr = cmd1.ExecuteScalar
                cmd1.Dispose()
                CloseConnection()
                co = c & "-" & cobr
                combobranchcountry.Text = co
                'state
                Openconnection()
                cmd1 = New OleDbCommand("select state from statemaster where stateid='" & b & "'", con)
                stbr = cmd1.ExecuteScalar
                cmd1.Dispose()
                CloseConnection()
                st = b & "-" & stbr
                combobranchstate.Text = st
                'city
                Openconnection()
                cmd1 = New OleDbCommand("select city from citymaster where cityid='" & a & "'", con)
                cibr = cmd1.ExecuteScalar
                cmd1.Dispose()
                CloseConnection()
                ci = a & "-" & cibr
                combobranchcity.Text = ci
            Else
                If txtbranchid.Text <> "" Or txtbranchname.Text <> "" Then
                    Dim ctrl As Control
                    'Branch 
                    txtbranchid.Text = ""
                    txtbranchname.Text = ""
                    For Each ctrl In Me.GroupBox3.Controls
                        If TypeOf ctrl Is TextBox Then
                            ctrl.Text = ""
                        End If
                        If TypeOf ctrl Is ComboBox Then
                            ctrl.Text = ""
                        End If
                    Next
                End If
            End If

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
    Private Sub combocountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combocountry.SelectedIndexChanged
        Dim b, c As String
        combostate.Items.Clear()
        b = combocountry.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(combostate, "select stateid,state from statemaster where countryid='" & c & "'")
    End Sub
    Private Sub combostate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combostate.SelectedIndexChanged
        Dim b, c As String
        combocity.Items.Clear()
        b = combostate.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(combocity, "select cityid,city from citymaster where stateid='" & c & "'")
    End Sub
    Private Sub combobranchcountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobranchcountry.SelectedIndexChanged
        Dim b, c As String
        combobranchstate.Items.Clear()
        b = combobranchcountry.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(combobranchstate, "select stateid,state from statemaster where countryid='" & c & "'")
    End Sub
    Private Sub combobranchstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobranchstate.SelectedIndexChanged
        Dim b, c As String
        combobranchcity.Items.Clear()
        b = combobranchstate.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(combobranchcity, "select cityid,city from citymaster where stateid='" & c & "'")
    End Sub
    Private Sub txtcompid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcompid.KeyPress, txtbranchid.KeyPress
        'allows to enter both text and numbers wihtout any spaces
        idtextandnumbers(e)
    End Sub
    Private Sub txtcompregid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcompregid.KeyPress, txtvatno.KeyPress, txttinno.KeyPress, txtbranchname.KeyPress
        'allows to enter both text and numbers
        textandnumbers(e)
    End Sub
    Private Sub combocountry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combocountry.KeyPress, combostate.KeyPress, combocity.KeyPress
        combo(e)
    End Sub
    Private Sub txtzip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtzip.KeyPress, txtphone.KeyPress, txtphone2.KeyPress, txtfax.KeyPress, txtbranchfax.KeyPress, txtbranchphone.KeyPress, txtbranchphone2.KeyPress, txtbranchzip.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub
    Private Sub txtemailid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemailid.Leave
        email(txtemailid)
    End Sub
    Private Sub txtcompid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcompid.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtcompid)
    End Sub
    Private Sub txtcompname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcompname.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtcompname)
    End Sub
    Private Sub txtremarks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtremarks.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtremarks)
    End Sub
    Private Sub txtaddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtaddress)
    End Sub
    Private Sub txtaddress1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaddress1.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtaddress1)
    End Sub
    Private Sub txtbranchemailid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbranchemailid.Leave
        email(txtbranchemailid)
    End Sub
    Private Sub combobranchcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combobranchcity.KeyPress, combobranchcountry.KeyPress, combobranchstate.KeyPress
        combo(e)
    End Sub
    Private Sub txtbranchaddress_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbranchaddress.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtbranchaddress)
    End Sub
    Private Sub txtbranchaddress1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbranchaddress1.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtbranchaddress1)
    End Sub
    Private Sub txtbranchid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbranchid.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtbranchid)
    End Sub
    Private Sub txtbranchname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbranchname.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtbranchname)
    End Sub
    Private Sub txtbranchremarks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbranchremarks.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtbranchremarks)
    End Sub
End Class
