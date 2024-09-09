Imports System.Data.OleDb
Public Class Hotel_Voucher
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
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tabview As System.Windows.Forms.TabPage
    Friend WithEvents Tabentry As System.Windows.Forms.TabPage
    Friend WithEvents Grpfacili As System.Windows.Forms.GroupBox
    Friend WithEvents Txtarrivdetail As System.Windows.Forms.TextBox
    Friend WithEvents Dtpvrndt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtyourvrn As System.Windows.Forms.TextBox
    Friend WithEvents txtvouno As System.Windows.Forms.TextBox
    Friend WithEvents DTPvoudt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Grpmeal As System.Windows.Forms.GroupBox
    Friend WithEvents GrpChildhotel As System.Windows.Forms.GroupBox
    Friend WithEvents txtjuniors As System.Windows.Forms.TextBox
    Friend WithEvents Txtadults As System.Windows.Forms.TextBox
    Friend WithEvents Txtchildren As System.Windows.Forms.TextBox
    Friend WithEvents Txtinfants As System.Windows.Forms.TextBox
    Friend WithEvents Txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Grphotelbook As System.Windows.Forms.GroupBox
    Friend WithEvents Comhotelid As System.Windows.Forms.ComboBox
    Friend WithEvents Txtbookingid As System.Windows.Forms.TextBox
    Friend WithEvents Rbtnreserve As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtncancel As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnamend As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnwait As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnconfirm As System.Windows.Forms.RadioButton
    Friend WithEvents Txtsigned As System.Windows.Forms.TextBox
    Friend WithEvents Txtspereq As System.Windows.Forms.TextBox
    Friend WithEvents Txtconfirm As System.Windows.Forms.TextBox
    Friend WithEvents DTPon As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgfacbook As System.Windows.Forms.DataGrid
    Friend WithEvents dgmealbook As System.Windows.Forms.DataGrid
    Friend WithEvents dghotelchildbook As System.Windows.Forms.DataGrid
    Friend WithEvents dghotelbook As System.Windows.Forms.DataGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgsearch As System.Windows.Forms.DataGrid
    Friend WithEvents GRP1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgview As System.Windows.Forms.DataGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotel_Voucher))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tabview = New System.Windows.Forms.TabPage
        Me.dgview = New System.Windows.Forms.DataGrid
        Me.Tabentry = New System.Windows.Forms.TabPage
        Me.Grpfacili = New System.Windows.Forms.GroupBox
        Me.dgfacbook = New System.Windows.Forms.DataGrid
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GRP1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.dgsearch = New System.Windows.Forms.DataGrid
        Me.Txtarrivdetail = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Dtpvrndt = New System.Windows.Forms.DateTimePicker
        Me.Txtyourvrn = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtvouno = New System.Windows.Forms.TextBox
        Me.DTPvoudt = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grpmeal = New System.Windows.Forms.GroupBox
        Me.dgmealbook = New System.Windows.Forms.DataGrid
        Me.GrpChildhotel = New System.Windows.Forms.GroupBox
        Me.dghotelchildbook = New System.Windows.Forms.DataGrid
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtjuniors = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtadults = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txtchildren = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txtinfants = New System.Windows.Forms.TextBox
        Me.Txtcustomer = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Grphotelbook = New System.Windows.Forms.GroupBox
        Me.dghotelbook = New System.Windows.Forms.DataGrid
        Me.Comhotelid = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Txtbookingid = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Rbtnwait = New System.Windows.Forms.RadioButton
        Me.Rbtnconfirm = New System.Windows.Forms.RadioButton
        Me.Txtsigned = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Txtspereq = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Rbtnamend = New System.Windows.Forms.RadioButton
        Me.Rbtncancel = New System.Windows.Forms.RadioButton
        Me.Rbtnreserve = New System.Windows.Forms.RadioButton
        Me.Txtconfirm = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DTPon = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.Tabview.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabentry.SuspendLayout()
        Me.Grpfacili.SuspendLayout()
        CType(Me.dgfacbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GRP1.SuspendLayout()
        CType(Me.dgsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grpmeal.SuspendLayout()
        CType(Me.dgmealbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpChildhotel.SuspendLayout()
        CType(Me.dghotelchildbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Grphotelbook.SuspendLayout()
        CType(Me.dghotelbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tabview)
        Me.TabControl1.Controls.Add(Me.Tabentry)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(720, 568)
        Me.TabControl1.TabIndex = 1
        '
        'Tabview
        '
        Me.Tabview.Controls.Add(Me.dgview)
        Me.Tabview.Location = New System.Drawing.Point(4, 22)
        Me.Tabview.Name = "Tabview"
        Me.Tabview.Size = New System.Drawing.Size(712, 542)
        Me.Tabview.TabIndex = 0
        Me.Tabview.Text = "View"
        '
        'dgview
        '
        Me.dgview.CaptionVisible = False
        Me.dgview.DataMember = ""
        Me.dgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgview.Location = New System.Drawing.Point(8, 101)
        Me.dgview.Name = "dgview"
        Me.dgview.Size = New System.Drawing.Size(672, 360)
        Me.dgview.TabIndex = 0
        '
        'Tabentry
        '
        Me.Tabentry.Controls.Add(Me.Grpfacili)
        Me.Tabentry.Controls.Add(Me.GroupBox5)
        Me.Tabentry.Controls.Add(Me.GroupBox12)
        Me.Tabentry.Controls.Add(Me.GroupBox1)
        Me.Tabentry.Location = New System.Drawing.Point(4, 22)
        Me.Tabentry.Name = "Tabentry"
        Me.Tabentry.Size = New System.Drawing.Size(712, 542)
        Me.Tabentry.TabIndex = 1
        Me.Tabentry.Text = "Entry / Edit"
        Me.Tabentry.Visible = False
        '
        'Grpfacili
        '
        Me.Grpfacili.Controls.Add(Me.dgfacbook)
        Me.Grpfacili.Location = New System.Drawing.Point(344, 352)
        Me.Grpfacili.Name = "Grpfacili"
        Me.Grpfacili.Size = New System.Drawing.Size(360, 144)
        Me.Grpfacili.TabIndex = 547
        Me.Grpfacili.TabStop = False
        Me.Grpfacili.Text = "Facility Booking"
        '
        'dgfacbook
        '
        Me.dgfacbook.CaptionVisible = False
        Me.dgfacbook.DataMember = ""
        Me.dgfacbook.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgfacbook.Location = New System.Drawing.Point(8, 24)
        Me.dgfacbook.Name = "dgfacbook"
        Me.dgfacbook.ReadOnly = True
        Me.dgfacbook.RowHeadersVisible = False
        Me.dgfacbook.Size = New System.Drawing.Size(344, 112)
        Me.dgfacbook.TabIndex = 654
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GRP1)
        Me.GroupBox5.Controls.Add(Me.Txtarrivdetail)
        Me.GroupBox5.Controls.Add(Me.Label58)
        Me.GroupBox5.Controls.Add(Me.Dtpvrndt)
        Me.GroupBox5.Controls.Add(Me.Txtyourvrn)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtvouno)
        Me.GroupBox5.Controls.Add(Me.DTPvoudt)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Grpmeal)
        Me.GroupBox5.Controls.Add(Me.GrpChildhotel)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.Txtcustomer)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Grphotelbook)
        Me.GroupBox5.Controls.Add(Me.Comhotelid)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Txtbookingid)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(712, 352)
        Me.GroupBox5.TabIndex = 874
        Me.GroupBox5.TabStop = False
        '
        'GRP1
        '
        Me.GRP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GRP1.Controls.Add(Me.Label6)
        Me.GRP1.Controls.Add(Me.Button3)
        Me.GRP1.Controls.Add(Me.Button2)
        Me.GRP1.Controls.Add(Me.dgsearch)
        Me.GRP1.Location = New System.Drawing.Point(72, 96)
        Me.GRP1.Name = "GRP1"
        Me.GRP1.Size = New System.Drawing.Size(480, 232)
        Me.GRP1.TabIndex = 50
        Me.GRP1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Booking  Id  Search"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(264, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(152, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgsearch
        '
        Me.dgsearch.CaptionVisible = False
        Me.dgsearch.DataMember = ""
        Me.dgsearch.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgsearch.Location = New System.Drawing.Point(16, 48)
        Me.dgsearch.Name = "dgsearch"
        Me.dgsearch.ReadOnly = True
        Me.dgsearch.Size = New System.Drawing.Size(456, 120)
        Me.dgsearch.TabIndex = 0
        '
        'Txtarrivdetail
        '
        Me.Txtarrivdetail.Location = New System.Drawing.Point(104, 272)
        Me.Txtarrivdetail.Multiline = True
        Me.Txtarrivdetail.Name = "Txtarrivdetail"
        Me.Txtarrivdetail.Size = New System.Drawing.Size(232, 48)
        Me.Txtarrivdetail.TabIndex = 10
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(8, 272)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(90, 13)
        Me.Label58.TabIndex = 49
        Me.Label58.Text = "Arrival details "
        '
        'Dtpvrndt
        '
        Me.Dtpvrndt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpvrndt.Location = New System.Drawing.Point(240, 248)
        Me.Dtpvrndt.Name = "Dtpvrndt"
        Me.Dtpvrndt.ShowCheckBox = True
        Me.Dtpvrndt.Size = New System.Drawing.Size(96, 21)
        Me.Dtpvrndt.TabIndex = 9
        '
        'Txtyourvrn
        '
        Me.Txtyourvrn.Location = New System.Drawing.Point(104, 248)
        Me.Txtyourvrn.Name = "Txtyourvrn"
        Me.Txtyourvrn.Size = New System.Drawing.Size(56, 21)
        Me.Txtyourvrn.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(176, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "VRN Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Your VRN "
        '
        'txtvouno
        '
        Me.txtvouno.BackColor = System.Drawing.Color.Gainsboro
        Me.txtvouno.Location = New System.Drawing.Point(104, 224)
        Me.txtvouno.Name = "txtvouno"
        Me.txtvouno.ReadOnly = True
        Me.txtvouno.Size = New System.Drawing.Size(72, 21)
        Me.txtvouno.TabIndex = 43
        '
        'DTPvoudt
        '
        Me.DTPvoudt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPvoudt.Location = New System.Drawing.Point(104, 200)
        Me.DTPvoudt.Name = "DTPvoudt"
        Me.DTPvoudt.ShowCheckBox = True
        Me.DTPvoudt.Size = New System.Drawing.Size(96, 21)
        Me.DTPvoudt.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Voucher No. *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Voucher Date *"
        '
        'Grpmeal
        '
        Me.Grpmeal.Controls.Add(Me.dgmealbook)
        Me.Grpmeal.Location = New System.Drawing.Point(344, 232)
        Me.Grpmeal.Name = "Grpmeal"
        Me.Grpmeal.Size = New System.Drawing.Size(360, 112)
        Me.Grpmeal.TabIndex = 40
        Me.Grpmeal.TabStop = False
        Me.Grpmeal.Text = "Meal Booking "
        '
        'dgmealbook
        '
        Me.dgmealbook.CaptionVisible = False
        Me.dgmealbook.DataMember = ""
        Me.dgmealbook.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgmealbook.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgmealbook.Location = New System.Drawing.Point(16, 16)
        Me.dgmealbook.Name = "dgmealbook"
        Me.dgmealbook.ReadOnly = True
        Me.dgmealbook.RowHeadersVisible = False
        Me.dgmealbook.Size = New System.Drawing.Size(336, 88)
        Me.dgmealbook.TabIndex = 65
        '
        'GrpChildhotel
        '
        Me.GrpChildhotel.Controls.Add(Me.dghotelchildbook)
        Me.GrpChildhotel.Location = New System.Drawing.Point(272, 120)
        Me.GrpChildhotel.Name = "GrpChildhotel"
        Me.GrpChildhotel.Size = New System.Drawing.Size(432, 112)
        Me.GrpChildhotel.TabIndex = 39
        Me.GrpChildhotel.TabStop = False
        Me.GrpChildhotel.Text = "Child Hotel Booking "
        '
        'dghotelchildbook
        '
        Me.dghotelchildbook.CaptionVisible = False
        Me.dghotelchildbook.DataMember = ""
        Me.dghotelchildbook.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dghotelchildbook.Location = New System.Drawing.Point(8, 16)
        Me.dghotelchildbook.Name = "dghotelchildbook"
        Me.dghotelchildbook.ReadOnly = True
        Me.dghotelchildbook.RowHeadersVisible = False
        Me.dghotelchildbook.Size = New System.Drawing.Size(416, 88)
        Me.dghotelchildbook.TabIndex = 354
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtjuniors)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Txtadults)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Txtchildren)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Txtinfants)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox4.TabIndex = 254
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "No. of Persons"
        '
        'txtjuniors
        '
        Me.txtjuniors.Location = New System.Drawing.Point(184, 16)
        Me.txtjuniors.Name = "txtjuniors"
        Me.txtjuniors.Size = New System.Drawing.Size(56, 21)
        Me.txtjuniors.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Juniors"
        '
        'Txtadults
        '
        Me.Txtadults.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtadults.Location = New System.Drawing.Point(64, 16)
        Me.Txtadults.Name = "Txtadults"
        Me.Txtadults.Size = New System.Drawing.Size(51, 21)
        Me.Txtadults.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Adults "
        '
        'Txtchildren
        '
        Me.Txtchildren.Location = New System.Drawing.Point(64, 40)
        Me.Txtchildren.Name = "Txtchildren"
        Me.Txtchildren.Size = New System.Drawing.Size(48, 21)
        Me.Txtchildren.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Children"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Infants"
        '
        'Txtinfants
        '
        Me.Txtinfants.Location = New System.Drawing.Point(184, 40)
        Me.Txtinfants.Name = "Txtinfants"
        Me.Txtinfants.Size = New System.Drawing.Size(56, 21)
        Me.Txtinfants.TabIndex = 6
        '
        'Txtcustomer
        '
        Me.Txtcustomer.BackColor = System.Drawing.Color.Gainsboro
        Me.Txtcustomer.Location = New System.Drawing.Point(88, 80)
        Me.Txtcustomer.Name = "Txtcustomer"
        Me.Txtcustomer.ReadOnly = True
        Me.Txtcustomer.Size = New System.Drawing.Size(144, 21)
        Me.Txtcustomer.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Customer *"
        '
        'Grphotelbook
        '
        Me.Grphotelbook.Controls.Add(Me.dghotelbook)
        Me.Grphotelbook.Location = New System.Drawing.Point(272, 8)
        Me.Grphotelbook.Name = "Grphotelbook"
        Me.Grphotelbook.Size = New System.Drawing.Size(432, 112)
        Me.Grphotelbook.TabIndex = 65
        Me.Grphotelbook.TabStop = False
        Me.Grphotelbook.Text = "Hotel Booking "
        '
        'dghotelbook
        '
        Me.dghotelbook.CaptionVisible = False
        Me.dghotelbook.DataMember = ""
        Me.dghotelbook.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dghotelbook.Location = New System.Drawing.Point(8, 16)
        Me.dghotelbook.Name = "dghotelbook"
        Me.dghotelbook.ReadOnly = True
        Me.dghotelbook.RowHeadersVisible = False
        Me.dghotelbook.Size = New System.Drawing.Size(416, 88)
        Me.dghotelbook.TabIndex = 0
        '
        'Comhotelid
        '
        Me.Comhotelid.Location = New System.Drawing.Point(88, 48)
        Me.Comhotelid.Name = "Comhotelid"
        Me.Comhotelid.Size = New System.Drawing.Size(104, 21)
        Me.Comhotelid.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Hotel *"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        '
        'Txtbookingid
        '
        Me.Txtbookingid.Location = New System.Drawing.Point(88, 16)
        Me.Txtbookingid.Name = "Txtbookingid"
        Me.Txtbookingid.Size = New System.Drawing.Size(104, 21)
        Me.Txtbookingid.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Booking Id *"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Rbtnwait)
        Me.GroupBox12.Controls.Add(Me.Rbtnconfirm)
        Me.GroupBox12.Controls.Add(Me.Txtsigned)
        Me.GroupBox12.Controls.Add(Me.Label62)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 496)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(696, 40)
        Me.GroupBox12.TabIndex = 254
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Voucher Status"
        '
        'Rbtnwait
        '
        Me.Rbtnwait.Location = New System.Drawing.Point(184, 16)
        Me.Rbtnwait.Name = "Rbtnwait"
        Me.Rbtnwait.Size = New System.Drawing.Size(112, 16)
        Me.Rbtnwait.TabIndex = 18
        Me.Rbtnwait.Text = "Waiting List"
        '
        'Rbtnconfirm
        '
        Me.Rbtnconfirm.Location = New System.Drawing.Point(32, 16)
        Me.Rbtnconfirm.Name = "Rbtnconfirm"
        Me.Rbtnconfirm.Size = New System.Drawing.Size(120, 16)
        Me.Rbtnconfirm.TabIndex = 17
        Me.Rbtnconfirm.Text = "Confirmed"
        '
        'Txtsigned
        '
        Me.Txtsigned.Location = New System.Drawing.Point(576, 16)
        Me.Txtsigned.Name = "Txtsigned"
        Me.Txtsigned.ReadOnly = True
        Me.Txtsigned.Size = New System.Drawing.Size(100, 21)
        Me.Txtsigned.TabIndex = 654
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(504, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(65, 13)
        Me.Label62.TabIndex = 45
        Me.Label62.Text = "Signed By"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtspereq)
        Me.GroupBox1.Controls.Add(Me.Label56)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Txtconfirm)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DTPon)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 152)
        Me.GroupBox1.TabIndex = 254
        Me.GroupBox1.TabStop = False
        '
        'Txtspereq
        '
        Me.Txtspereq.Location = New System.Drawing.Point(144, 112)
        Me.Txtspereq.Multiline = True
        Me.Txtspereq.Name = "Txtspereq"
        Me.Txtspereq.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtspereq.Size = New System.Drawing.Size(168, 32)
        Me.Txtspereq.TabIndex = 16
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(8, 120)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(135, 13)
        Me.Label56.TabIndex = 46
        Me.Label56.Text = "Special Requirements "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rbtnamend)
        Me.GroupBox3.Controls.Add(Me.Rbtncancel)
        Me.GroupBox3.Controls.Add(Me.Rbtnreserve)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 48)
        Me.GroupBox3.TabIndex = 254
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Type"
        '
        'Rbtnamend
        '
        Me.Rbtnamend.Location = New System.Drawing.Point(120, 16)
        Me.Rbtnamend.Name = "Rbtnamend"
        Me.Rbtnamend.Size = New System.Drawing.Size(64, 24)
        Me.Rbtnamend.TabIndex = 12
        Me.Rbtnamend.Text = "Amend"
        '
        'Rbtncancel
        '
        Me.Rbtncancel.Location = New System.Drawing.Point(240, 16)
        Me.Rbtncancel.Name = "Rbtncancel"
        Me.Rbtncancel.Size = New System.Drawing.Size(64, 24)
        Me.Rbtncancel.TabIndex = 13
        Me.Rbtncancel.Text = "Cancel"
        '
        'Rbtnreserve
        '
        Me.Rbtnreserve.Location = New System.Drawing.Point(8, 17)
        Me.Rbtnreserve.Name = "Rbtnreserve"
        Me.Rbtnreserve.Size = New System.Drawing.Size(72, 23)
        Me.Rbtnreserve.TabIndex = 11
        Me.Rbtnreserve.Text = "Reserve"
        '
        'Txtconfirm
        '
        Me.Txtconfirm.Location = New System.Drawing.Point(208, 64)
        Me.Txtconfirm.Name = "Txtconfirm"
        Me.Txtconfirm.Size = New System.Drawing.Size(100, 21)
        Me.Txtconfirm.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Confirmation of telephone call to "
        '
        'DTPon
        '
        Me.DTPon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPon.Location = New System.Drawing.Point(208, 88)
        Me.DTPon.Name = "DTPon"
        Me.DTPon.ShowCheckBox = True
        Me.DTPon.Size = New System.Drawing.Size(96, 21)
        Me.DTPon.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "On"
        '
        'Hotel_Voucher
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(720, 565)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hotel_Voucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Voucher"
        Me.TabControl1.ResumeLayout(False)
        Me.Tabview.ResumeLayout(False)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabentry.ResumeLayout(False)
        Me.Grpfacili.ResumeLayout(False)
        CType(Me.dgfacbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GRP1.ResumeLayout(False)
        CType(Me.dgsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grpmeal.ResumeLayout(False)
        CType(Me.dgmealbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpChildhotel.ResumeLayout(False)
        CType(Me.dghotelchildbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Grphotelbook.ResumeLayout(False)
        CType(Me.dghotelbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim da As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim hotelvoumaxno, hotelvouroommxno, hotelvouchroommxno, hotvoumaelmaxno, hotelvoufacimaxno As Integer
    Dim dr As OleDbDataReader
    Dim rec As EnuRecstatus
    Dim hid, custid, userid, bookid, voutype, voustatus, pacid As String



    Dim t1, t2 As OleDbTransaction
    Dim roomamt, faciamt, mealamt, croomamt, hotvouamt As Long
    Dim dtt As Date
    Public Sub clearproc()
        Txtadults.Text = ""
        Txtarrivdetail.Text = ""
        Txtbookingid.Text = ""
        Txtchildren.Text = ""
        Txtconfirm.Text = ""
        Txtcustomer.Text = ""
        Txtinfants.Text = ""
        txtjuniors.Text = ""
        Txtsigned.Text = ""
        Txtspereq.Text = ""
        txtvouno.Text = ""
        Txtyourvrn.Text = ""
        Comhotelid.SelectedItem = ""
        Rbtnreserve.Checked = True
        Rbtnconfirm.Checked = True
    End Sub
    Public Sub newproc()
        enable()
        Txtbookingid.Focus()

        rec = Module1.EnuRecstatus.Recnew
    End Sub
    Public Sub editsub()
        enable()
        rec = Module1.EnuRecstatus.Recedit
    End Sub
    Public Sub enable()

        Txtadults.Enabled = True
        Txtarrivdetail.Enabled = True
        Txtbookingid.Enabled = True
        Txtchildren.Enabled = True
        Txtconfirm.Enabled = True
        Txtcustomer.Enabled = True
        Txtinfants.Enabled = True
        txtjuniors.Enabled = True
        Txtsigned.Enabled = True
        Txtspereq.Enabled = True
        txtvouno.Enabled = True
        Txtyourvrn.Enabled = True
        Comhotelid.SelectedItem = True

        Rbtnamend.Enabled = True
        Rbtncancel.Enabled = True
        Rbtnconfirm.Enabled = True
        Rbtnreserve.Enabled = True
        Rbtnwait.Enabled = True

        Rbtnreserve.Checked = True
        Rbtnconfirm.Checked = True
        DTPvoudt.Enabled = True
        Dtpvrndt.Enabled = True
        Comhotelid.Enabled = True
        DTPon.Enabled = True


    End Sub
    Public Sub disable()
        Comhotelid.Enabled = False
        DTPon.Enabled = False

        Txtadults.Enabled = False
        Txtarrivdetail.Enabled = False
        Txtbookingid.Enabled = False
        Txtchildren.Enabled = False
        Txtconfirm.Enabled = False
        Txtcustomer.Enabled = False
        Txtinfants.Enabled = False
        txtjuniors.Enabled = False
        Txtsigned.Enabled = False
        Txtspereq.Enabled = False
        txtvouno.Enabled = False
        Txtyourvrn.Enabled = False
        Comhotelid.SelectedItem = False
        Rbtnamend.Enabled = False
        Rbtncancel.Enabled = False
        Rbtnconfirm.Enabled = False
        Rbtnreserve.Enabled = False
        Rbtnwait.Enabled = False
        DTPvoudt.Enabled = False
        Dtpvrndt.Enabled = False

    End Sub
    Public Sub saveproc()
        dtt = Date.Now
        Dim i As Integer

        Dim x As Integer

        hid = Comhotelid.SelectedItem

        If Txtbookingid.Text = "" Then
            MsgBox("Select Booking Id")
            Exit Sub
        End If
        If Comhotelid.SelectedItem = "" Then
            MsgBox("Select Hotelid")
            Exit Sub
        End If
        If Rbtnamend.Checked = True Then
            voutype = "AMEND"
        End If
        If Rbtncancel.Checked = True Then
            voutype = "CANCEL"
        End If
        If Rbtnreserve.Checked = True Then
            voutype = "RESERVE"
        End If

        If Rbtnwait.Checked = True Then
            voustatus = "WAIT"
        End If
        If Rbtnconfirm.Checked = True Then
            voustatus = "CONFIRM"
        End If


        If rec = Module1.EnuRecstatus.Recnew Then
            Openconnection()
            't1 = con.BeginTransaction

            cmd = New OleDbCommand("select count(*) from Hot_VouAmount ", con)
            ' cmd.Transaction = t1

            hotelvoumaxno = cmd.ExecuteScalar
            cmd.Dispose()
            If hotelvoumaxno = 0 Then
                hotelvoumaxno = 1
            Else
                cmd = New OleDbCommand("select max(Hot_VouchNo)+1 from Hot_VouAmount ", con)
                cmd.Transaction = t1
                hotelvoumaxno = cmd.ExecuteScalar
                cmd.Dispose()
            End If
            '
            '
            '*********************To Store Hotel Voucher Details**************************
            '*****************************************************************************
            '
            '
            '*************** To Check Wheather The Voucher Already Generated Or not*****************
            '***************************************************************************************
            '
            '
            Dim inty As Integer = 0
            cmd = New OleDbCommand("select count(*) from hotel_vouch where bookingid='" & Trim(bookid) & "' and hotelid='" & hid & "'", con)
            inty = cmd.ExecuteScalar()
            cmd.Dispose()
            If inty <> 0 Then
                MsgBox("Voucher Already Generated")
                Exit Sub
            End If

            cmd = New OleDbCommand("insert into hotel_vouch values(" & hotelvoumaxno & ",'" & FormatDateTime(DTPvoudt.Text, DateFormat.ShortDate) & "','" & voutype & "','" & bookid & "','" & hid & "'," & IIf(Txtadults.Text = "", 0, Txtadults.Text) & "," & IIf(txtjuniors.Text = "", 0, txtjuniors.Text) & "," & IIf(Txtchildren.Text = "", 0, Txtchildren.Text) & "," & IIf(Txtinfants.Text = "", 0, Txtinfants.Text) & "," & IIf(Txtconfirm.Text = "", 0, Txtconfirm.Text) & ",'" & FormatDateTime(DTPon.Text, DateFormat.ShortDate) & "','" & IIf(Txtarrivdetail.Text = "", " ", Txtarrivdetail.Text) & "','" & IIf(Txtspereq.Text = "", " ", Txtspereq.Text) & "','" & voustatus & "','" & IIf(Txtyourvrn.Text = "", " ", Txtyourvrn.Text) & "','" & FormatDateTime(Dtpvrndt.Text, DateFormat.ShortDate) & "','" & Txtsigned.Text & "','Y','" & userid & "','" & dtt & "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            '
            '*******To Store the hotel voucer amount details
            '
            cmd = New OleDbCommand("insert into Hot_VouAmount values(" & hotelvoumaxno & ",'" & bookid & "','" & hid & "'," & roomamt & "," & croomamt & "," & mealamt & "," & faciamt & "," & hotvouamt & ",'Y','" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "')", con)
            'cmd.Transaction = t1
            x = cmd.ExecuteNonQuery()
            'If x = 1 Then

            cmd.Dispose()
            '
            '
            '**********************to store hotel room voucher details*****************************
            '**************************************************************************************
            '
            '
            cmd = New OleDbCommand("select count(*) from Hot_VouRoom", con)
            'cmd.Transaction = t1
            hotelvouroommxno = cmd.ExecuteScalar()
            cmd.Dispose()
            If hotelvouroommxno = 0 Then
                hotelvouroommxno = 1
            Else
                cmd = New OleDbCommand("select max(VouRefno)+1 from Hot_VouRoom", con)
                cmd.Transaction = t1

                hotelvouroommxno = cmd.ExecuteScalar
                cmd.Dispose()
            End If


            For i = 0 To ds.Tables("custhotel").Rows.Count - 1
                Try


                    Dim x1, trnid, qua As Integer
                    Dim amt As Long
                    Dim paymtby As String
                    Dim dt As Date


                    x1 = Val(ds.Tables("custhotel").Rows(i).Item(0))
                    trnid = Val(ds.Tables("custhotel").Rows(i).Item(3))
                    qua = Val(ds.Tables("custhotel").Rows(i).Item(4))
                    dt = FormatDateTime(ds.Tables("custhotel").Rows(i).Item(5), DateFormat.ShortDate)
                    amt = Val(ds.Tables("custhotel").Rows(i).Item(6))
                    paymtby = CStr(ds.Tables("custhotel").Rows(i).Item(8))
                    pacid = CStr(ds.Tables("custhotel").Rows(i).Item(9))



                    cmd = New OleDbCommand("insert into Hot_VouRoom values(" & hotelvouroommxno & "," & hotelvoumaxno & ",'" & bookid & "','" & hid & "'," & x1 & " ," & trnid & "," & qua & " ,'" & dt & "'," & amt & " ,'" & paymtby & "','" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "','" & pacid & "')", con)

                    ' cmd.Transaction = t1
                    x = cmd.ExecuteNonQuery
                    cmd.Dispose()

                    'If x = 1 Then
                    'Else
                    '    t1.Rollback()
                    'End If
                    hotelvouroommxno += 1
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                    CloseConnection()
                    Exit Sub

                End Try

            Next
            '
            '
            '**********************to store child room voucher details*****************************
            '***************************************************************************************
            'To find max no in child room voucher
            '
            '
            If ds.Tables("Hot_coucroom").Rows.Count = 0 Then
            Else


                cmd = New OleDbCommand("select count(*) from Hot_VouCroom", con)
                hotelvouchroommxno = cmd.ExecuteNonQuery
                cmd.Dispose()

                If hotelvouchroommxno = 0 Then
                    hotelvouchroommxno = 1
                Else
                    cmd = New OleDbCommand("select max(VouRefno)+1 from Hot_VouCroom", con)
                    hotelvouchroommxno = cmd.ExecuteNonQuery
                    cmd.Dispose()
                End If
                '
                'To Store voucher child room details
                '

                For i = 0 To ds.Tables("hotelchild").Rows.Count - 1
                    Dim hcbookid, ctransid, qua As Integer
                    Dim amt As Long
                    Dim dt As Date
                    Dim paymtby As String
                    pacid = CStr(ds.Tables("hotelchild").Rows(i).Item(8))


                    hcbookid = Val(ds.Tables("hotelchild").Rows(i).Item(0))
                    ctransid = Val(ds.Tables("hotelchild").Rows(i).Item(3))
                    qua = Val(ds.Tables("hotelchild").Rows(i).Item(4))
                    dt = FormatDateTime(ds.Tables("hotelchild").Rows(i).Item(6), DateFormat.ShortDate)
                    paymtby = CStr(ds.Tables("hotelchild").Rows(i).Item(6))

                    cmd = New OleDbCommand("insert into Hot_VouCroom values(" & hotelvouchroommxno & "," & hotelvoumaxno & ",'" & bookid & "','" & hid & "'," & hcbookid & "," & ctransid & "," & qua & ",'" & dt & "'," & amt & ",'" & paymtby & "','" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "','" & pacid & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    hotelvouchroommxno += 1
                Next

            End If

            '**********************to store Hotel  voucher facilites details****************************************
            '
            'To To check Wheather The Facilities Table Is Empty OR not
            '
            If ds.Tables("Hot_vouFacil").Rows.Count = 0 Then


            Else

                Try
                    cmd = New OleDbCommand("select count(*) from Hot_VouFacil", con)
                    hotelvoufacimaxno = cmd.ExecuteNonQuery
                    If hotelvoufacimaxno = 0 Then
                        hotelvoufacimaxno = 1
                    Else
                        cmd = New OleDbCommand("select max(VouRefno)+1 from Hot_VouFacil", con)
                        hotelvoufacimaxno = cmd.ExecuteNonQuery()
                    End If
                    '
                    'To Get the data  from The all the rows inthe data grid
                    For i = 0 To ds.Tables("custfaci").Rows.Count - 1

                        Dim hfbookid, facid, noofpax, unit As Integer
                        Dim facdt As Date
                        Dim ratetype, pymtby As String
                        Dim amt, totamt As Long
                        '
                        'Gets The Data From the Facility Gata grid

                        hfbookid = Val(ds.Tables("custfaci").Rows(i).Item(0))
                        facid = Val(ds.Tables("custfaci").Rows(i).Item(1))
                        noofpax = CInt(ds.Tables("custfaci").Rows(i).Item(3))
                        unit = CInt(ds.Tables("custfaci").Rows(i).Item(5))
                        facdt = FormatDateTime(ds.Tables("custfaci").Rows(i).Item(10), DateFormat.ShortDate)
                        ratetype = CStr(ds.Tables("custfaci").Rows(i).Item(4))
                        amt = Val(ds.Tables("custfaci").Rows(i).Item(6))
                        totamt = Val(ds.Tables("custfaci").Rows(i).Item(7))
                        pymtby = CStr(ds.Tables("custfaci").Rows(i).Item(8))
                        pacid = CStr(ds.Tables("custfaci").Rows(i).Item(9))




                        'hfbookid(, FacilitId, custid, Noof_Pax, Rate_Type, unit, Amount, Total_Amt, PaymentBy, PackageId, Faci_Date)


                        cmd = New OleDbCommand("insert into Hot_VouFacil values(" & hotelvoufacimaxno & "," & hotelvoumaxno & "," & bookid & "," & hid & "," & hfbookid & "," & facid & "," & noofpax & ",'" & facdt & "','" & ratetype & "'," & unit & "," & amt & "," & totamt & ",'" & pymtby & "','" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "' ,'" & pacid & "')", con)

                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        '
                        'Increment Hotel Voucher Facility max no (Primary Key)
                        '
                        hotelvoufacimaxno += 1


                    Next
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                    CloseConnection()
                    Exit Sub
                End Try
            End If


            'end for the loop hotel voucher facilites
            '
            '***********************To Enter hotel Maeal Dertails***************************
            '*******************************************************************************
            '
            'To Check Wheathe the taable Is Empty Or Not
            '
            If ds.Tables("hpt_voumeal").Rows.Count = 0 Then

            Else



                cmd = New OleDbCommand("select count(*) from Hot_Voumeal", con)
                hotvoumaelmaxno = cmd.ExecuteNonQuery
                '
                'To Find the maximum no
                If hotvoumaelmaxno = 0 Then
                    hotvoumaelmaxno = 1
                Else
                    cmd = New OleDbCommand("select max(VouRefno)+1 from Hot_Voumeal", con)
                    hotvoumaelmaxno = cmd.ExecuteNonQuery()
                End If

                For i = 0 To ds.Tables("hotelmeal").Rows.Count - 1


                    Dim hmbookid, custid, mealid, noofpax As Integer
                    Dim amt As Long
                    Dim dt As Date
                    Dim pymtby As String
                    '
                    'To get the Data Form The Datagrid

                    hmbookid = Val(ds.Tables("hotelmeal").Rows(i).Item(0))
                    mealid = Val(ds.Tables("hotelmeal").Rows(i).Item(3))
                    amt = Val(ds.Tables("hotelmeal").Rows(i).Item(6))
                    dt = FormatDateTime(ds.Tables("hotelmeal").Rows(i).Item(4), DateFormat.ShortDate)
                    pymtby = CStr(ds.Tables("hotelmeal").Rows(i).Item(9))
                    pacid = CStr(ds.Tables("hotelmeal").Rows(i).Item(7))


                    cmd = New OleDbCommand("insert into  Hot_Voumeal values(" & hotvoumaelmaxno & "," & hotelvoumaxno & ",'" & bookid & "'," & hid & "," & hmbookid & "," & mealid & "," & noofpax & ",'" & dt & "'," & amt & ",'" & pymtby & "','" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "','" & pacid & "')", con)

                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    '
                    'To Increase the hotelvoucher meal maxno(primary key)
                    hotvoumaelmaxno += 1

                Next

                MsgSav()
                Exit Sub
            End If
        End If
        '
        '*******************************************************************************************************
        '**************************** If Record In Edit Mode****************************************************
        '


        If rec = Module1.EnuRecstatus.Recedit Then


            'To Update the Hotel Voucher Details
            cmd = New OleDbCommand("update  hotel_vouch set  Hot_VouchDt='" & FormatDateTime(DTPvoudt.Text, DateFormat.ShortDate) & "',   Vou_Type ='" & voutype & "',  BookingId='" & bookid & "', HotelId='" & hid & "',Adults=" & IIf(Txtadults.Text = "", 0, Txtadults.Text) & ",Juniors=" & IIf(txtjuniors.Text = "", 0, txtjuniors.Text) & ", Children=" & IIf(Txtchildren.Text = "", 0, Txtchildren.Text) & ", Infants=" & IIf(Txtinfants.Text = "", 0, Txtinfants.Text) & ", CallTo=" & IIf(Txtconfirm.Text = "", 0, Txtconfirm.Text) & ", CallOn='" & FormatDateTime(DTPon.Text, DateFormat.ShortDate) & "', Arrival_Det='" & IIf(Txtarrivdetail.Text = "", " ", Txtarrivdetail.Text) & "', Spec_Req='" & IIf(Txtspereq.Text = "", " ", Txtspereq.Text) & "', Vou_Status='" & voustatus & "', Your_VRNno='" & IIf(Txtyourvrn.Text = "", " ", Txtyourvrn.Text) & "', Your_VRNdt='" & FormatDateTime(Dtpvrndt.Text, DateFormat.ShortDate) & "', SignedBy='" & Txtsigned.Text & "',Userid='" & userid & "', EnteredDt='" & dtt & "' where Hot_VouchNo=  " & hotelvoumaxno & "", con)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            '
            'To uipdate the hotel voucher amount details

            cmd = New OleDbCommand("update Hot_VouAmount set BookingId='" & bookid & "',HotelId='" & hid & "',Room_Amt=" & roomamt & ", CRoom_Amt=" & croomamt & ", Meal_Amt=" & mealamt & ", Facil_Amt=" & faciamt & ", Hot_VouchAmt=" & hotvouamt & ", Userid='" & userid & "',   EnteredDt ='" & FormatDateTime(dtt, DateFormat.ShortDate) & "'  where Hot_VouchNo=  " & hotelvoumaxno & "", con)
            x = cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Dim i As Integer
            '
            'To update the hotel voucher details

            For i = 0 To ds.Tables("custhotel").Rows.Count - 1
                Try


                    Dim x1, trnid, qua As Integer
                    Dim amt As Long
                    Dim paymtby As String
                    Dim dt As Date

                    hotelvouroommxno = Val(ds.Tables("custhotel").Rows(i).Item(0))
                    x1 = Val(ds.Tables("custhotel").Rows(i).Item(1))
                    trnid = Val(ds.Tables("custhotel").Rows(i).Item(4))
                    qua = Val(ds.Tables("custhotel").Rows(i).Item(5))
                    dt = FormatDateTime(ds.Tables("custhotel").Rows(i).Item(6), DateFormat.ShortDate)
                    amt = Val(ds.Tables("custhotel").Rows(i).Item(7))
                    paymtby = CStr(ds.Tables("custhotel").Rows(i).Item(9))



                    ' cmd = New OleDbCommand("update  Hot_VouRoom  set " & hotelvouroommxno & "," & hotelvoumaxno & ",'" & bookid & "','" & hid & "'," & x1 & " ," & trnid & "," & qua & " ,'" & dt & "'," & amt & " ,'" & paymtby & "','" & userid & "','" & FormatDateTime(dtt, DateFormat.ShortDate) & "')", con)
                    ' cmd.Transaction = t1
                    x = cmd.ExecuteNonQuery
                    cmd.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)

                    Exit Sub

                End Try
            Next

        End If



    End Sub
    Public Sub delproc()

    End Sub
    Private Sub voucher_hotel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        TabControl1.SelectedTab = Tabentry
        GRP1.Visible = False
        Txtsigned.Text = Muserid
        Rbtnreserve.Checked = True
        Rbtnconfirm.Checked = True
        disable()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Txtbookingid.Text = "" Then
            MsgBox("Enter Booking Id")
            Txtbookingid.Focus()
            Exit Sub
        End If
        Openconnection()
        Try
            ds.Clear()

            da = New OleDbDataAdapter("select bookingid,custid,Itina_Type,Bkdate,EndDate,TAmount from booking_itinary where BookingId Like '" & "%" & Txtbookingid.Text & "%" & "'", con)

            da.Fill(ds, "bookid")
            dgsearch.DataSource = ds.Tables("bookid")
            dgsearch.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try

        GRP1.Visible = True
        CloseConnection()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GRP1.Visible = False
        Comhotelid.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'update
        Dim valid As Integer
        Try

            Dim x As String

            Dim currow As Integer
            currow = dgsearch.CurrentRowIndex

            x = dgsearch.Item(currow, 0)


            bookid = Trim(x)

            custid = Trim(dgsearch.Item(currow, 1))

            Openconnection()

            cmd = New OleDbCommand("select count(*) from cust_master where trim(custid)='" & custid & "'", con)
            valid = cmd.ExecuteScalar()
            cmd.Dispose()

            If valid >= 1 Then




                cmd = New OleDbCommand("select hotelid from cust_hotel wHere TRIM(bookingid)='" & bookid & "'", con)
                dr = cmd.ExecuteReader
                While dr.Read
                    Comhotelid.Items.Add(dr(0))
                End While
                cmd.Dispose()

                dr.Close()

                cmd = New OleDbCommand("select * from booking_itinary where trim(bookingid)='" & bookid & "'", con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    Txtadults.Text = dr(9)
                    Txtinfants.Text = dr(12)
                    Txtchildren.Text = dr(11)
                    txtjuniors.Text = dr(10)

                End If
                cmd.Dispose()
                dr.Close()

                cmd = New OleDbCommand("select fname from cust_master where trim(custid)='" & custid & "'", con)
                Txtcustomer.Text = cmd.ExecuteScalar()
                cmd.Dispose()

                ds.Clear()
            Else
                MsgBox("No Record Exists")
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()

        End Try
        GRP1.Visible = False

    End Sub

    Private Sub Comhotelid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Comhotelid.SelectedIndexChanged
        Dim i As Integer

        ds.Clear()
        Try

            Openconnection()
            da = New OleDbDataAdapter("select HBookId,CustId,BookingId,TransId,Quanti,Occ_Date,Amount,Statu,PaymentBy,PackageId from cust_hotel where trim(bookingid)='" & bookid & "' and trim(custid)='" & custid & "' AND trim(HOTELID)='" & Comhotelid.SelectedItem & "' ", con)

            da.Fill(ds, "custhotel")
            dghotelbook.DataSource = ds.Tables("custhotel")

            da = New OleDbDataAdapter("select HCBookId,CustId,BookingId,CTransId,Quanti,Amount,Occ_Date,PackageId,HotelId from Cust_Hotel_Child where trim(bookingid)='" & bookid & "' and trim(custid)='" & custid & "'  AND trim(HOTELID)='" & Comhotelid.SelectedItem & "' ", con)
            da.Fill(ds, "hotelchild")
            dghotelchildbook.DataSource = ds.Tables("hotelchild")

            da = New OleDbDataAdapter("select HFBookId,FacilitId,CustId,Noof_Pax,Rate_Type,Unit,Amount,Total_Amt,PaymentBy,PackageId,Faci_Date from Cust_HotFacil where TRIM(bookingid)='" & bookid & "' and TRIM(custid)='" & custid & "'   AND trim(HOTELID)='" & Comhotelid.SelectedItem & "' ", con)

            da.Fill(ds, "custfaci")
            dgfacbook.DataSource = ds.Tables("custfaci")



            da = New OleDbDataAdapter("select HMBookId,CustId,BookingId,Mealid,Meal_Date,Noof_Pax,Amount,PackageId,HotelId,PaymentBy from Cust_Meal where trim(bookingid)='" & bookid & "' and trim(custid)='" & custid & "' and trim(hotelid)='" & Comhotelid.SelectedItem & "'", con)


            da.Fill(ds, "hotelmeal")
            dgmealbook.DataSource = ds.Tables("hotelmeal")

            '
            'To CalCulate the hotel room amount

            For i = 0 To ds.Tables("custhotel").Rows.Count - 1

                roomamt += ds.Tables("custhotel").Rows(i).Item(4)
            Next
            '
            'to calculate the hotel child room amount


            For i = 0 To ds.Tables("hotelchild").Rows.Count - 1
                croomamt += ds.Tables("hotelchild").Rows(i).Item(5)
            Next
            '
            'To Calculate the hotel faciilites room amount

            For i = 0 To ds.Tables("custfaci").Rows.Count - 1
                faciamt += ds.Tables("custfaci").Rows(i).Item(6)
            Next

            '
            'To calcuulate the custmer meal amount

            For i = 0 To ds.Tables("hotelmeal").Rows.Count - 1
                mealamt += ds.Tables("hotelmeal").Rows(i).Item(6)

            Next
            ' MsgBox(roomamt & croomamt & faciamt)
            hotvouamt = roomamt + croomamt + faciamt + mealamt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()


        End Try


    End Sub



    Private Sub Txtinfants_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtinfants.LostFocus
        DTPvoudt.Focus()

    End Sub

    Private Sub Txtarrivdetail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtarrivdetail.LostFocus
        Rbtnreserve.Focus()

    End Sub

    Private Sub dgview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.DoubleClick
        Dim intk As Integer
        intk = dgview.CurrentRowIndex
        hotelvoumaxno = ds.Tables("hotvou").Rows(intk).Item(0)
        Openconnection()

        cmd = New OleDbCommand("select * from Hotel_Vouch where Hot_VouchNo=" & hotelvoumaxno & "", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            DTPvoudt.Text = FormatDateTime(dr(1), DateFormat.ShortDate)
            voutype = Trim(CStr(dr(2)))

            bookid = dr(3)
            Txtbookingid.Text = dr(3)
            hid = dr(4)
            Comhotelid.SelectedItem = dr(4)
            Comhotelid.Text = dr(4)

            Txtadults.Text = dr(5)
            txtjuniors.Text = dr(6)
            Txtchildren.Text = dr(7)
            Txtinfants.Text = dr(8)
            Txtconfirm.Text = dr(9)
            DTPon.Text = dr(10)
            Txtarrivdetail.Text = dr(11)
            Txtspereq.Text = dr(12)
            voustatus = dr(13)
            Txtyourvrn.Text = dr(14)
            Dtpvrndt.Text = dr(15)
            Txtsigned.Text = dr(16)

        End If
        dr.Close()
        cmd.Dispose()
        '
        'To Find TThe Customer Details
        '

        cmd = New OleDbCommand("select custid from Booking_Itinary where trim(BookingId)='" & Trim(bookid) & "'", con)
        custid = cmd.ExecuteScalar
        cmd.Dispose()

        cmd = New OleDbCommand("select fname from Cust_Master where trim(CustId)='" & Trim(custid) & "'", con)
        Txtcustomer.Text = cmd.ExecuteScalar()
        cmd.Dispose()



        '
        'To Set the radio buttons

        If voutype = "AMEN" Then
            Rbtnamend.Checked = True
        End If
        If voutype = "CANCEL" Then
            Rbtncancel.Checked = True
        End If
        If voutype = "RESERVE" Then
            Rbtnreserve.Checked = True
        End If

        If voustatus = "WAIT" Then
            Rbtnwait.Checked = True
        End If
        If voutype = "CONFIRM" Then
            Rbtnconfirm.Checked = True
        End If
        '
        'To Get THE Data from the all The tables hotel room child room,meal tariff,facilites


        da = New OleDbDataAdapter("select HBookId,CustId,BookingId,TransId,Quanti,Occ_Date,Amount,Statu,PaymentBy from cust_hotel where trim(bookingid)='" & bookid & "' and trim(custid)='" & custid & "' AND trim(HOTELID)='" & Trim(hid) & "' ", con)
        da.Fill(ds, "custhotel")
        dghotelbook.DataSource = ds.Tables("custhotel")

        da = New OleDbDataAdapter("select HCBookId,CustId,BookingId,CTransId,Quanti,Amount,Occ_Date,PackageId,HotelId from Cust_Hotel_Child where trim(bookingid)='" & bookid & "' and TRIM(custid)='" & custid & "'   AND trim(HOTELID)='" & Trim(hid) & "' ", con)
        da.Fill(ds, "hotelchild")
        dghotelchildbook.DataSource = ds.Tables("hotelchild")

        da = New OleDbDataAdapter("select HFBookId,FacilitId,CustId,Noof_Pax,Rate_Type,Unit,Amount,Total_Amt,PaymentBy,PackageId,Faci_Date from Cust_HotFacil where TRIM(bookingid)='" & bookid & "' and TRIM(custid)='" & custid & "'   AND trim(HOTELID)='" & Trim(hid) & "' ", con)
        da.Fill(ds, "custfaci")
        dgfacbook.DataSource = ds.Tables("custfaci")


        da = New OleDbDataAdapter("select HMBookId,CustId,BookingId,Mealid,Meal_Date,Noof_Pax,Amount,PackageId,HotelId,PaymentBy from Cust_Meal where trim(bookingid)='" & bookid & "' and trim(custid)='" & custid & "' and trim(hotelid)='" & Trim(hid) & "'", con)
        da.Fill(ds, "hotelmeal")
        dgmealbook.DataSource = ds.Tables("hotelmeal")
        '
        'To Get The Hotel Ids
        '

        cmd = New OleDbCommand("select hotelid from cust_hotel wHere TRIM(bookingid)='" & Trim(bookid) & "'", con)
        dr = cmd.ExecuteReader
        While dr.Read
            Comhotelid.Items.Add(dr(0))
        End While
        cmd.Dispose()
        dr.Close()
        Dim i As Integer


        For i = 0 To ds.Tables("custhotel").Rows.Count - 1

            roomamt += ds.Tables("custhotel").Rows(i).Item(4)
        Next
        '
        'to calculate the hotel child room amount


        For i = 0 To ds.Tables("hotelchild").Rows.Count - 1
            croomamt += ds.Tables("hotelchild").Rows(i).Item(5)
        Next
        '
        'To Calculate the hotel faciilites room amount

        For i = 0 To ds.Tables("custfaci").Rows.Count - 1
            faciamt += ds.Tables("custfaci").Rows(i).Item(6)
        Next

        '
        'To calcuulate the custmer meal amount

        For i = 0 To ds.Tables("hotelmeal").Rows.Count - 1
            mealamt += ds.Tables("hotelmeal").Rows(i).Item(6)

        Next
        ' MsgBox(roomamt & croomamt & faciamt)
        hotvouamt = roomamt + croomamt + faciamt + mealamt




        disable()

        CloseConnection()

        TabControl1.SelectedTab = Tabentry
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedTab.Text = "View" Then
            'ds.Clear()
            Openconnection()
            da = New OleDbDataAdapter("select * from Hotel_Vouch", con)
            da.Fill(ds, "hotvou")
            CloseConnection()
            dgview.DataSource = ds.Tables("hotvou")

        End If
    End Sub

    Private Sub Txtconfirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtconfirm.KeyPress, Txtadults.KeyPress, Txtchildren.KeyPress, Txtinfants.KeyPress, txtjuniors.KeyPress

        numberonly(e)
    End Sub

    Private Sub Tabview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabview.Click

    End Sub

    Private Sub dgview_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgview.Navigate

    End Sub
End Class
