'Name developer: Emma Christeena.B
'Dt:18/07/2006
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class Hotel_Surcharg
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Grbchild As System.Windows.Forms.GroupBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents dtptodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cobhotel As System.Windows.Forms.ComboBox
    Friend WithEvents tabpage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents chkchild As System.Windows.Forms.CheckBox
    Friend WithEvents cobhotel1 As System.Windows.Forms.ComboBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcorprate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtjuniorrr As System.Windows.Forms.TextBox
    Friend WithEvents txtchildcr As System.Windows.Forms.TextBox
    Friend WithEvents txtchildrr As System.Windows.Forms.TextBox
    Friend WithEvents txtjuniorcr As System.Windows.Forms.TextBox
    Friend WithEvents txtsurcharge As System.Windows.Forms.TextBox
    Friend WithEvents txttrans As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hotel_Surcharg))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabpage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.cobhotel1 = New System.Windows.Forms.ComboBox
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txttrans = New System.Windows.Forms.TextBox
        Me.txtcorprate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkchild = New System.Windows.Forms.CheckBox
        Me.Grbchild = New System.Windows.Forms.GroupBox
        Me.txtjuniorcr = New System.Windows.Forms.TextBox
        Me.txtjuniorrr = New System.Windows.Forms.TextBox
        Me.txtchildcr = New System.Windows.Forms.TextBox
        Me.txtchildrr = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtsurcharge = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtptodate = New System.Windows.Forms.DateTimePicker
        Me.dtpfromdate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cobhotel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tabpage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Grbchild.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpage1)
        Me.TabControl1.Controls.Add(Me.tabpage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 416)
        Me.TabControl1.TabIndex = 0
        '
        'tabpage1
        '
        Me.tabpage1.Controls.Add(Me.GroupBox1)
        Me.tabpage1.Location = New System.Drawing.Point(4, 22)
        Me.tabpage1.Name = "tabpage1"
        Me.tabpage1.Size = New System.Drawing.Size(464, 390)
        Me.tabpage1.TabIndex = 0
        Me.tabpage1.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dbgview)
        Me.GroupBox1.Controls.Add(Me.cobhotel1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(32, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "hotel id"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(40, 88)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.Size = New System.Drawing.Size(344, 280)
        Me.dbgview.TabIndex = 2
        '
        'cobhotel1
        '
        Me.cobhotel1.Location = New System.Drawing.Point(144, 40)
        Me.cobhotel1.Name = "cobhotel1"
        Me.cobhotel1.TabIndex = 1
        '
        'tabpage2
        '
        Me.tabpage2.Controls.Add(Me.GroupBox2)
        Me.tabpage2.Location = New System.Drawing.Point(4, 22)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Size = New System.Drawing.Size(464, 390)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttrans)
        Me.GroupBox2.Controls.Add(Me.txtcorprate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.chkchild)
        Me.GroupBox2.Controls.Add(Me.Grbchild)
        Me.GroupBox2.Controls.Add(Me.txtsurcharge)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtrate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtptodate)
        Me.GroupBox2.Controls.Add(Me.dtpfromdate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cobhotel)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 384)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txttrans
        '
        Me.txttrans.Location = New System.Drawing.Point(304, 200)
        Me.txttrans.Name = "txttrans"
        Me.txttrans.Size = New System.Drawing.Size(40, 21)
        Me.txttrans.TabIndex = 15
        Me.txttrans.Text = ""
        Me.txttrans.Visible = False
        '
        'txtcorprate
        '
        Me.txtcorprate.Location = New System.Drawing.Point(344, 80)
        Me.txtcorprate.MaxLength = 5
        Me.txtcorprate.Name = "txtcorprate"
        Me.txtcorprate.Size = New System.Drawing.Size(104, 21)
        Me.txtcorprate.TabIndex = 3
        Me.txtcorprate.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(232, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Corporate Rate *"
        '
        'chkchild
        '
        Me.chkchild.Location = New System.Drawing.Point(8, 192)
        Me.chkchild.Name = "chkchild"
        Me.chkchild.Size = New System.Drawing.Size(224, 24)
        Me.chkchild.TabIndex = 8
        Me.chkchild.Text = "Childrens Has Different Surcharge"
        '
        'Grbchild
        '
        Me.Grbchild.Controls.Add(Me.txtjuniorcr)
        Me.Grbchild.Controls.Add(Me.txtjuniorrr)
        Me.Grbchild.Controls.Add(Me.txtchildcr)
        Me.Grbchild.Controls.Add(Me.txtchildrr)
        Me.Grbchild.Controls.Add(Me.Label14)
        Me.Grbchild.Controls.Add(Me.Label13)
        Me.Grbchild.Controls.Add(Me.Label12)
        Me.Grbchild.Controls.Add(Me.Label11)
        Me.Grbchild.Location = New System.Drawing.Point(8, 232)
        Me.Grbchild.Name = "Grbchild"
        Me.Grbchild.Size = New System.Drawing.Size(440, 144)
        Me.Grbchild.TabIndex = 13
        Me.Grbchild.TabStop = False
        Me.Grbchild.Text = "Children Surcharge"
        '
        'txtjuniorcr
        '
        Me.txtjuniorcr.Location = New System.Drawing.Point(344, 80)
        Me.txtjuniorcr.MaxLength = 5
        Me.txtjuniorcr.Name = "txtjuniorcr"
        Me.txtjuniorcr.Size = New System.Drawing.Size(80, 21)
        Me.txtjuniorcr.TabIndex = 12
        Me.txtjuniorcr.Text = ""
        '
        'txtjuniorrr
        '
        Me.txtjuniorrr.Location = New System.Drawing.Point(344, 40)
        Me.txtjuniorrr.MaxLength = 5
        Me.txtjuniorrr.Name = "txtjuniorrr"
        Me.txtjuniorrr.Size = New System.Drawing.Size(80, 21)
        Me.txtjuniorrr.TabIndex = 11
        Me.txtjuniorrr.Text = ""
        '
        'txtchildcr
        '
        Me.txtchildcr.Location = New System.Drawing.Point(128, 80)
        Me.txtchildcr.MaxLength = 5
        Me.txtchildcr.Name = "txtchildcr"
        Me.txtchildcr.Size = New System.Drawing.Size(80, 21)
        Me.txtchildcr.TabIndex = 10
        Me.txtchildcr.Text = ""
        '
        'txtchildrr
        '
        Me.txtchildrr.Location = New System.Drawing.Point(128, 40)
        Me.txtchildrr.MaxLength = 5
        Me.txtchildrr.Name = "txtchildrr"
        Me.txtchildrr.Size = New System.Drawing.Size(80, 21)
        Me.txtchildrr.TabIndex = 9
        Me.txtchildrr.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(224, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Junior corporate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(224, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Junior Rack Rate *"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Child Corporate Rate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Child Rack Rate *"
        '
        'txtsurcharge
        '
        Me.txtsurcharge.Location = New System.Drawing.Point(88, 48)
        Me.txtsurcharge.MaxLength = 5
        Me.txtsurcharge.Name = "txtsurcharge"
        Me.txtsurcharge.Size = New System.Drawing.Size(360, 21)
        Me.txtsurcharge.TabIndex = 1
        Me.txtsurcharge.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Surcharge * "
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(88, 80)
        Me.txtrate.MaxLength = 5
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(136, 21)
        Me.txtrate.TabIndex = 2
        Me.txtrate.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Rack Rate *"
        '
        'dtptodate
        '
        Me.dtptodate.Checked = False
        Me.dtptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtptodate.Location = New System.Drawing.Point(248, 152)
        Me.dtptodate.Name = "dtptodate"
        Me.dtptodate.ShowCheckBox = True
        Me.dtptodate.Size = New System.Drawing.Size(120, 21)
        Me.dtptodate.TabIndex = 5
        '
        'dtpfromdate
        '
        Me.dtpfromdate.Checked = False
        Me.dtpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfromdate.Location = New System.Drawing.Point(80, 152)
        Me.dtpfromdate.Name = "dtpfromdate"
        Me.dtpfromdate.ShowCheckBox = True
        Me.dtpfromdate.Size = New System.Drawing.Size(120, 21)
        Me.dtpfromdate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To Date *"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(104, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From Date *"
        '
        'cobhotel
        '
        Me.cobhotel.Location = New System.Drawing.Point(88, 16)
        Me.cobhotel.Name = "cobhotel"
        Me.cobhotel.Size = New System.Drawing.Size(360, 21)
        Me.cobhotel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotel *"
        '
        'Hotel_Surcharg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(472, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hotel_Surcharg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Surcharge"
        Me.TabControl1.ResumeLayout(False)
        Me.tabpage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Grbchild.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cmd As OleDbCommand
    Dim da As New OleDbDataAdapter("select * from Hotel_Surcharg ", con)
    Dim ds As New DataSet
    Dim transid, k, o, vtransid As Integer
    Dim dt, dt1 As New DataTable
    Dim recmode As EnuRecstatus 'To findout record status
    Dim dtp1, dtp2 As String
    Dim flag As Boolean
    Private Sub Hotel_Surcharg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'on page load it displays entry/edit tab page
        TabControl1.SelectedTab = tabpage2

        lock()
        '------below code brings data from hotelmaster table and fill in the combo box------'
        combofill1(cobhotel, "select * from HotelMaster")
    End Sub
    Public Sub lock()
        'locks the controls
        txtsurcharge.ReadOnly = True
        txtrate.ReadOnly = True
        txtcorprate.ReadOnly = True
        cobhotel.Enabled = False
        dtpfromdate.Enabled = False
        dtpfromdate.Checked = False
        dtptodate.Checked = False
        dtptodate.Enabled = False
        chkchild.Enabled = False
        txtchildrr.ReadOnly = True
        txtchildcr.ReadOnly = True
        txtjuniorrr.ReadOnly = True
        txtjuniorcr.ReadOnly = True
        dbgview.ReadOnly = True
    End Sub
    '  this procedure clears the all text boxes and combo boxes
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox2.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.Grbchild.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        chkchild.Checked = False
        dtpfromdate.Checked = False
        dtptodate.Checked = False
        cobhotel.Focus()
        dt.Clear()
        dt1.Clear()
        lock()
    End Sub
    'this procedure checks the form status and set it to new mode
    Public Sub newproc()
        recmode = Module1.EnuRecstatus.Recnew
        txtsurcharge.ReadOnly = False
        txtrate.ReadOnly = False
        txtcorprate.ReadOnly = False
        cobhotel.Enabled = True
        dtpfromdate.Enabled = True
        dtptodate.Enabled = True
        chkchild.Enabled = True
        txtsurcharge.Text = ""
        txtrate.Text = ""
    End Sub
    'this procedure deletes data from data base
    Public Sub delproc()
        Dim byt, byt1 As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "delete from Hotel_Surcharg where transid=" & vtransid & ""
            cmd = New OleDbCommand(str, con)
            byt = cmd.ExecuteNonQuery()
            cmd.Dispose()
            If chkchild.Checked = True Then
                Dim str1 As String = "delete from Hotel_Chi_Surch where transid=" & vtransid & ""
                cmd = New OleDbCommand(str1, con)
                byt1 = cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            MsgDel()
            clearproc()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
        Finally
            con.Close()
        End Try
    End Sub
    'for validation
    Public Sub valid()
        flag = False
        If cobhotel.Text = "" Then
            MsgBox(" Select hotel id", MsgBoxStyle.OKOnly, Prjtitle)
            cobhotel.Focus()
            Exit Sub
        End If
        If txtsurcharge.Text = "" Then
            MsgBox(" enter subcharge", MsgBoxStyle.OKOnly, Prjtitle)
            txtsurcharge.Focus()
            Exit Sub
        End If
        If txtrate.Text = "" Then
            MsgBox(" Enter rate", MsgBoxStyle.OKOnly, Prjtitle)
            txtrate.Focus()
            Exit Sub
        End If
        If txtcorprate.Text = "" Then
            MsgBox(" Enter rate", MsgBoxStyle.OKOnly, Prjtitle)
            txtcorprate.Focus()
            Exit Sub
        End If
        If dtpfromdate.Checked = False Then
            MsgBox("enter  from date and time", MsgBoxStyle.OKOnly, Prjtitle)
            dtpfromdate.Focus()
            Exit Sub
        End If
        If dtptodate.Checked = False Then
            MsgBox("enter  from to and time", MsgBoxStyle.OKOnly, Prjtitle)
            dtptodate.Focus()
            Exit Sub
        End If
        If chkchild.Checked Then
            If txtchildrr.Text = "" Then
                MsgBox("enter child rack rate", MsgBoxStyle.OKOnly, Prjtitle)
                txtchildrr.Focus()
            End If
            If txtjuniorrr.Text = "" Then
                MsgBox("enter junior rack rate", MsgBoxStyle.OKOnly, Prjtitle)
                txtjuniorrr.Focus()
            End If
        End If
        flag = True
    End Sub
    'this procedure inserts a new record  or update an existing record
    Public Sub saveproc()
        valid()
        Dim i As Integer
        Dim b, c As String
        b = cobhotel.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        If flag = False Then Exit Sub

        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Dim dt1, dt2, dt3, dt4, dt5, dt6 As Date
                Dim x1, x2, x3, x4, x5 As Integer
                Dim drt As OleDbDataReader
                Dim cmdt As OleDbCommand
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                cmdt = New OleDbCommand("select fromdt,todt from hotel_surcharg where hotelid='" & c & "'", con)
                drt = cmdt.ExecuteReader
                dt3 = dtpfromdate.Text
                dt4 = dtptodate.Text
                While drt.Read
                    'this date is retrieved from database FromDate
                    dt1 = FormatDateTime(drt(0), DateFormat.ShortDate)
                    'this date is retrieved from database ToDate
                    dt2 = FormatDateTime(drt(1), DateFormat.ShortDate)
                    'gives the difference b/w FromDate and ToDate
                    x1 = DateDiff(DateInterval.Day, dt1, dt2)
                    x3 = DateDiff(DateInterval.Day, dt3, dt4)
                    'it is used to check whether the selected date lies between database dates
                    dt5 = dt1
                    ' this loop check whether selected from date lies between database dates
                    For x2 = 0 To x1
                        If dt3 = dt5 Or dt4 = dt5 Then
                            MsgBox("selected date " & dt5 & " lies  between data base dates,select another date", MsgBoxStyle.OKOnly, Prjtitle)
                            Exit Sub
                        End If
                        dt5 = DateAdd(DateInterval.Day, 1, dt5)
                    Next
                    dt6 = dt3
                    x4 = DateDiff(DateInterval.Day, dt3, dt4)
                    'it is used to check whether the database date lies between selected dates
                    For x5 = 0 To x4
                        If dt1 = dt6 Then
                            MsgBox("selected date " & dt6 & " lies  between the dates in the data base, select  another date", MsgBoxStyle.OKOnly, Prjtitle)
                            Exit Sub
                        End If
                        dt6 = DateAdd(DateInterval.Day, 1, dt6)
                    Next
                End While
                con.Close()

                Openconnection()
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Hotel_Surcharg where HotelId='" & cobhotel.Text & "'", con)
                p = cmd.ExecuteScalar
                cmd.Dispose()
                If p <> 0 Then
                    MsgRecexist()
                    cobhotel.Focus()
                    Exit Sub
                End If
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                'initializing transid for first time when rows in table are zero
                cmd = New OleDb.OleDbCommand("select count(*) from Hotel_Surcharg", con)
                transid = cmd.ExecuteScalar
                cmd.Dispose()
                If transid >= 1 Then
                    ' retrieving tansaction id 
                    cmd = New OleDb.OleDbCommand("select max(TransId) from Hotel_Surcharg ", con)
                    transid = cmd.ExecuteScalar
                    cmd.Dispose()
                End If
                ' incrementing transaction id
                transid = transid + 1
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                cmd = New OleDbCommand("insert into Hotel_Surcharg values('" & transid & "','" & c & "','" & txtsurcharge.Text & "','" & dt3 & "','" & dt4 & "','" & txtrate.Text & "','" & txtcorprate.Text & "')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                If chkchild.Checked Then
                    If con.State <> ConnectionState.Open Then
                        Openconnection()
                    End If
                    cmd = New OleDbCommand("insert into Hotel_Chi_Surch values('" & transid & "','" & c & "','" & txtsurcharge.Text & "','" & dt3 & "','" & dt4 & "','" & txtchildrr.Text & "','" & txtchildcr.Text & "','" & txtjuniorrr.Text & "','" & txtjuniorcr.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cobhotel.Focus()
                End If
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                Dim p1, q As String
                Dim j As Integer
                Dim dt1, dt2, dt3, dt4, dt5, dt6 As Date
                Dim x1, x2, x3, x4, x5, transid As Integer
                Dim drt As OleDbDataReader
                Dim cmdt As OleDbCommand
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                cmdt = New OleDbCommand("select fromdt,todt,transid from hotel_surcharg where hotelid='" & c & "'", con)
                drt = cmdt.ExecuteReader
                dt3 = dtpfromdate.Text
                dt4 = dtptodate.Text
                While drt.Read
                    transid = drt(2)
                    'this date is retrieved from database from date
                    dt1 = FormatDateTime(drt(0), DateFormat.ShortDate)
                    'this date is retrieved to database from date
                    dt2 = FormatDateTime(drt(1), DateFormat.ShortDate)
                    'gives the difference b/w FromDate and ToDate
                    x1 = DateDiff(DateInterval.Day, dt1, dt2)
                    x3 = DateDiff(DateInterval.Day, dt3, dt4)
                    'it is used to skip the present record
                    If transid <> vtransid Then
                        'it is used to check whether the selected date lies between database dates
                        dt5 = dt1
                        ' this loop check whether selecte from date lies between database dates
                        For x2 = 0 To x1
                            If dt3 = dt5 Or dt4 = dt5 Then
                                MsgBox("selected date " & dt5 & " lies  between data base dates,select another date", MsgBoxStyle.OKOnly, Prjtitle)
                                Exit Sub
                            End If
                            dt5 = DateAdd(DateInterval.Day, 1, dt5)
                        Next
                        dt6 = dt3
                        x4 = DateDiff(DateInterval.Day, dt3, dt4)
                        'it is used to check whether the database date lies between selected dates
                        For x5 = 0 To x4
                            If dt1 = dt6 Then
                                MsgBox("selected date " & dt6 & " lies  between the dates in the data base, select  another date", MsgBoxStyle.OKOnly, Prjtitle)
                                Exit Sub
                            End If
                            dt6 = DateAdd(DateInterval.Day, 1, dt6)
                        Next
                    End If
                End While
                con.Close()
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                cmd = New OleDbCommand("update Hotel_Surcharg set Surcharge='" & txtsurcharge.Text & "', FromDt='" & dt3 & "',todt='" & dt4 & "',Rack_Rate='" & txtrate.Text & "',Corp_Rate='" & txtcorprate.Text & "' where TransId=" & vtransid & " ", con)
                j = cmd.ExecuteNonQuery()
                cmd.Dispose()
                ' o = dbgview.Item(dbgview.CurrentCell.RowNumber, 0)
                cmd = New OleDbCommand("delete * from Hotel_Chi_Surch where transid=" & vtransid & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                cmd = New OleDbCommand("insert into Hotel_Chi_Surch  values(" & vtransid & ",'" & c & "','" & txtsurcharge.Text & "','" & dt3 & "','" & dt4 & "','" & txtchildrr.Text & "','" & txtchildcr.Text & "','" & txtjuniorrr.Text & "','" & txtjuniorcr.Text & "')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
        Finally
            con.Close()
        End Try
        MsgSav()
        clearproc()
    End Sub
    Public Sub editproc()
        'form status as edit mode
        Dim i, k As String
        Dim dr1, dr As OleDbDataReader
        recmode = Module1.EnuRecstatus.Recedit
        cobhotel.Enabled = False
        txtsurcharge.ReadOnly = False
        txtrate.ReadOnly = False
        txtcorprate.ReadOnly = False
        dtpfromdate.Enabled = True
        dtptodate.Enabled = True
        chkchild.Enabled = True
        If chkchild.Checked = True Then
            txtchildrr.ReadOnly = False
            txtchildcr.ReadOnly = False
            txtjuniorrr.ReadOnly = False
            txtjuniorcr.ReadOnly = False
        End If
        con.Close()
    End Sub
    'fills hotel id information into combobox in view tab page
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ds.Clear()
        combofill1(cobhotel1, "select  distinct(hotelid),hotelname from hotelmaster")
    End Sub
    'get  selecteditem information from data base and places records in data grid
    Private Sub cobhotel1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobhotel1.SelectedIndexChanged
        Dim b, c As String
        ds.Clear()
        b = cobhotel1.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        Dim da1 As New OleDbDataAdapter("select * from Hotel_Surcharg where hotelid='" & c & "'", con)
        da1.Fill(ds, "Hotel_Surcharg")
        dbgview.DataSource = ds.Tables("Hotel_Surcharg")
    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        dt.Clear()
        dt1.Clear()
        Dim i As Integer
        Dim k As Integer
        Dim dr, dr1 As OleDb.OleDbDataReader
        'locks the controls
        lock()
        'fills the current row index number in k
        k = dbgview.CurrentCell.RowNumber
        'fills the value of row in i 
        vtransid = dbgview.Item(k, 0)
        If con.State <> ConnectionState.Open Then
            Openconnection()
        End If
        cmd = New OleDbCommand("select * from Hotel_Surcharg where transid=" & vtransid & "", con)
        Try
            dr = cmd.ExecuteReader
            cmd.Dispose()
            Dim a As String
            While dr.Read()

                a = dr(1)
                comboselet(cobhotel, a)
                txtsurcharge.Text = dr(2)
                txtrate.Text = dr(5)
                txtcorprate.Text = dr(6)
                dtpfromdate.Text = dr(3)
                dtpfromdate.Checked = True
                dtptodate.Text = dr(4)
                dtptodate.Checked = True
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        Finally
            con.Close()
        End Try
        Try
            If con.State <> ConnectionState.Open Then
                Openconnection()
            End If
            cmd = New OleDbCommand("select * from Hotel_Chi_Surch where transid=" & vtransid & "", con)
            dr1 = cmd.ExecuteReader
            cmd.Dispose()
            While dr1.Read
                chkchild.Checked = True
                txtchildrr.Text = dr1(5)
                txtchildcr.Text = dr1(6)
                txtjuniorrr.Text = dr1(7)
                txtjuniorcr.Text = dr1(8)
            End While
            dr1.Close()
            con.Close()
            TabControl1.SelectedTab = tabpage2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End Try
        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()
    End Sub
    'allows to enter text only 
    Private Sub txtsubcharge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsurcharge.KeyPress
        textonly(e)
    End Sub
    'allows  to enter numbers only
    Private Sub txtrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        numberonly(e)
    End Sub
    'enables controls when check box is checked
    Private Sub chkchild_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkchild.MouseUp
        If chkchild.Checked = False Then
            txtchildrr.ReadOnly = True
            txtchildcr.ReadOnly = True
            txtjuniorrr.ReadOnly = True
            txtjuniorcr.ReadOnly = True
        Else
            txtchildrr.ReadOnly = False
            txtchildcr.ReadOnly = False
            txtjuniorrr.ReadOnly = False
            txtjuniorcr.ReadOnly = False
        End If
    End Sub
    'doesnt allow ToDate less than FromDate
    Private Sub dtpfromdate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpfromdate.TextChanged
        Dim d, a As Date
        d = FormatDateTime(dtpfromdate.Text, DateFormat.ShortDate)
        a = DateAdd(DateInterval.Day, 1, d)
        dtptodate.MinDate = a
    End Sub
    'doesnt allow to type data directly in the combo boxes
    Private Sub cobhotel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotel.KeyPress
        combo(e)
    End Sub
    'dosent allow to type data directly in the combo boxes
    Private Sub cobhotel1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotel1.KeyPress
        combo(e)
    End Sub
    'allows  to enter numbers only
    Private Sub txtcorprate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorprate.KeyPress
        numberonly(e)
    End Sub
    Private Sub txtchildcr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchildcr.KeyPress
        'allows  to enter numbers only
        numberonly(e)
    End Sub
    Private Sub txtchildrr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchildrr.KeyPress
        'allows  to enter numbers only
        numberonly(e)
    End Sub
    Private Sub txtjuniorcr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjuniorcr.KeyPress
        'allows  to enter numbers only
        numberonly(e)
    End Sub
    Private Sub txtjuniorrr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjuniorrr.KeyPress
        'allows  to enter numbers only
        numberonly(e)
    End Sub
    'places child rack rate value in child corporate rate when txtchildcr is empty
    Private Sub txtchildcr_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtchildcr.Leave
        If txtchildcr.Text = "" Then
            txtchildcr.Text = txtchildrr.Text
        End If
    End Sub
    'places junior rack rate value in junior corporate rate when txtjuniorcr is empty
    Private Sub txtjuniorcr_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtjuniorcr.Leave
        cobhotel.Focus()
        If txtjuniorcr.Text = "" Then
            txtjuniorcr.Text = txtjuniorrr.Text
        End If
    End Sub
    'it uses to convert the first letter as cap letter  
    Private Sub txtsurcharge_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsurcharge.Leave
        firstcap(txtsurcharge)
    End Sub
End Class
