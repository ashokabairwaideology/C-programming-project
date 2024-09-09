'Name developer: Emma Christeena.B
'Dt:03/07/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class FixedItineraries
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
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtpackremarks As System.Windows.Forms.TextBox
    Friend WithEvents dbgdaywise As System.Windows.Forms.DataGrid
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents txtnights As System.Windows.Forms.TextBox
    Friend WithEvents txtpackname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cobtoloc As System.Windows.Forms.ComboBox
    Friend WithEvents cobfromloc As System.Windows.Forms.ComboBox
    Friend WithEvents txtpackid As System.Windows.Forms.TextBox
    Friend WithEvents txtdays As System.Windows.Forms.TextBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents grpdescript As System.Windows.Forms.GroupBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FixedItineraries))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtpackremarks = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grpdescript = New System.Windows.Forms.GroupBox
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.dbgdaywise = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cobtoloc = New System.Windows.Forms.ComboBox
        Me.cobfromloc = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtnights = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtpackname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtpackid = New System.Windows.Forms.TextBox
        Me.txtdays = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpdescript.SuspendLayout()
        CType(Me.dbgdaywise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(576, 416)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(568, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(16, 24)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(504, 336)
        Me.dbgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtpackremarks)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(568, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Package Remarks"
        '
        'txtpackremarks
        '
        Me.txtpackremarks.Location = New System.Drawing.Point(128, 360)
        Me.txtpackremarks.MaxLength = 148
        Me.txtpackremarks.Name = "txtpackremarks"
        Me.txtpackremarks.Size = New System.Drawing.Size(432, 21)
        Me.txtpackremarks.TabIndex = 12
        Me.txtpackremarks.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grpdescript)
        Me.GroupBox2.Controls.Add(Me.dbgdaywise)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 192)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Day Wise Schedule"
        '
        'grpdescript
        '
        Me.grpdescript.BackColor = System.Drawing.SystemColors.Info
        Me.grpdescript.Controls.Add(Me.cmdcancel)
        Me.grpdescript.Controls.Add(Me.cmdupdate)
        Me.grpdescript.Controls.Add(Me.txtdesc)
        Me.grpdescript.Location = New System.Drawing.Point(64, 32)
        Me.grpdescript.Name = "grpdescript"
        Me.grpdescript.Size = New System.Drawing.Size(400, 144)
        Me.grpdescript.TabIndex = 9
        Me.grpdescript.TabStop = False
        Me.grpdescript.Text = "description"
        Me.grpdescript.Visible = False
        '
        'cmdcancel
        '
        Me.cmdcancel.Location = New System.Drawing.Point(232, 104)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.TabIndex = 11
        Me.cmdcancel.Text = "cancel"
        '
        'cmdupdate
        '
        Me.cmdupdate.Location = New System.Drawing.Point(112, 104)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.TabIndex = 10
        Me.cmdupdate.Text = "update"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(8, 16)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(392, 72)
        Me.txtdesc.TabIndex = 9
        Me.txtdesc.Text = ""
        '
        'dbgdaywise
        '
        Me.dbgdaywise.CaptionVisible = False
        Me.dbgdaywise.DataMember = ""
        Me.dbgdaywise.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgdaywise.Location = New System.Drawing.Point(8, 24)
        Me.dbgdaywise.Name = "dbgdaywise"
        Me.dbgdaywise.Size = New System.Drawing.Size(544, 160)
        Me.dbgdaywise.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cobtoloc)
        Me.GroupBox1.Controls.Add(Me.cobfromloc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.txtrate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnights)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtpackname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtpackid)
        Me.GroupBox1.Controls.Add(Me.txtdays)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 160)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cobtoloc
        '
        Me.cobtoloc.Location = New System.Drawing.Point(304, 80)
        Me.cobtoloc.Name = "cobtoloc"
        Me.cobtoloc.Size = New System.Drawing.Size(96, 21)
        Me.cobtoloc.TabIndex = 6
        '
        'cobfromloc
        '
        Me.cobfromloc.Location = New System.Drawing.Point(112, 80)
        Me.cobfromloc.Name = "cobfromloc"
        Me.cobfromloc.Size = New System.Drawing.Size(96, 21)
        Me.cobfromloc.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "To Location"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "From Location"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Description"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(112, 112)
        Me.txtdescription.MaxLength = 198
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(440, 40)
        Me.txtdescription.TabIndex = 7
        Me.txtdescription.Text = ""
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(456, 48)
        Me.txtrate.MaxLength = 5
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(104, 21)
        Me.txtrate.TabIndex = 4
        Me.txtrate.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Rate"
        '
        'txtnights
        '
        Me.txtnights.Location = New System.Drawing.Point(304, 48)
        Me.txtnights.MaxLength = 2
        Me.txtnights.Name = "txtnights"
        Me.txtnights.Size = New System.Drawing.Size(40, 21)
        Me.txtnights.TabIndex = 3
        Me.txtnights.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(256, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nights"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Package Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Package Id *"
        '
        'txtpackname
        '
        Me.txtpackname.Location = New System.Drawing.Point(304, 16)
        Me.txtpackname.MaxLength = 30
        Me.txtpackname.Name = "txtpackname"
        Me.txtpackname.Size = New System.Drawing.Size(256, 21)
        Me.txtpackname.TabIndex = 1
        Me.txtpackname.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(72, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Days"
        '
        'txtpackid
        '
        Me.txtpackid.Location = New System.Drawing.Point(112, 16)
        Me.txtpackid.MaxLength = 5
        Me.txtpackid.Name = "txtpackid"
        Me.txtpackid.Size = New System.Drawing.Size(72, 21)
        Me.txtpackid.TabIndex = 0
        Me.txtpackid.Text = ""
        '
        'txtdays
        '
        Me.txtdays.Location = New System.Drawing.Point(112, 48)
        Me.txtdays.MaxLength = 2
        Me.txtdays.Name = "txtdays"
        Me.txtdays.Size = New System.Drawing.Size(40, 21)
        Me.txtdays.TabIndex = 2
        Me.txtdays.Text = ""
        '
        'FixedItineraries
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(576, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FixedItineraries"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed Itineraries"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grpdescript.ResumeLayout(False)
        CType(Me.dbgdaywise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim kk, cid, rid As Integer
    Dim cmd, cmd1, cmd2, cmd3, cmd4, cmd5, cmd6 As OleDbCommand
    Dim dv As New DataView
    Dim ds, ds1 As New DataSet
    Dim dt1, dt2 As New DataTable
    Dim c1 As New DataColumn("Days")
    Dim c2 As New DataColumn("Description")
    Dim c3 As New DataColumn("Remarks")
    Dim c4 As New DataColumn("Mode")
    Dim frmstatus As EnuRecstatus '  To findout record status
    Dim bolvali As Boolean ' to chk validations
    Private Sub FixedItineraries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'on page load it displays entry/edit tab page
        TabControl1.SelectedTab = TabPage2

        lock()
        dt1.Columns.Add(c1)
        dt1.Columns.Add(c2)
        dt1.Columns.Add(c3)
        dt1.Columns.Add(c4)
        ds1.Clear()
        'fills the combo boxes from location master
        combofill1(cobfromloc, "select * from locationmaster")
        combofill1(cobtoloc, "select * from locationmaster")
    End Sub
    Public Sub lock()
        'locks the controls
        txtpackid.ReadOnly = True
        txtpackname.ReadOnly = True
        txtdays.ReadOnly = True
        txtnights.ReadOnly = True
        txtrate.ReadOnly = True
        cobfromloc.Enabled = False
        cobtoloc.Enabled = False
        txtdescription.ReadOnly = True
        txtpackremarks.ReadOnly = True
        dbgdaywise.ReadOnly = True
    End Sub
    'Clears the controls on the form
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        dt1.Clear()
        txtpackremarks.Text = ""
        lock()
    End Sub
    'It enables the enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        frmstatus = Module1.EnuRecstatus.Recnew
        'clears the controls
        clearproc()
        ' unlocks the controls
        txtpackid.ReadOnly = False
        txtpackname.ReadOnly = False
        txtdays.ReadOnly = False
        txtnights.ReadOnly = False
        txtrate.ReadOnly = False
        cobfromloc.Enabled = True
        cobtoloc.Enabled = True
        txtdescription.ReadOnly = False
        txtpackremarks.ReadOnly = False
        dbgdaywise.ReadOnly = False
        'cursor gets into countryid textbox
        TabControl1.SelectedTab = TabPage2
        txtpackid.Focus()
    End Sub
    Public Sub editproc()
        'form status as edit mode
        Dim i, k As String
        Dim dr1 As OleDbDataReader
        'form status as edit mode
        frmstatus = Module1.EnuRecstatus.Recedit
        'lock the control
        txtpackid.ReadOnly = True
        'unlocks the controls
        txtpackname.ReadOnly = False
        txtdays.ReadOnly = False
        txtnights.ReadOnly = False
        txtrate.ReadOnly = False
        cobfromloc.Enabled = True
        cobtoloc.Enabled = True
        txtdescription.ReadOnly = False
        txtpackremarks.ReadOnly = False
        dbgdaywise.ReadOnly = False
        'clears the data table
        dt1.Clear()
        dt2.Clear()
        Try
            Openconnection()
            'loads the data into data table
            i = txtpackid.Text
            cmd = New OleDbCommand("select * from FixedItinera_Det where PackageId='" & i & "'", con)
            dr1 = cmd.ExecuteReader
            While dr1.Read
                Dim r1 As DataRow = dt1.NewRow
                r1.Item(0) = dr1(1)
                r1.Item(1) = dr1(2)
                r1.Item(2) = dr1(3)
                r1.Item(3) = dr1(4)
                dt1.Rows.Add(r1)
            End While
            dr1.Close()
            dbgdaywise.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        CloseConnection()
        kk = txtdays.Text
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes a particular record from fixed itineraries table using package id
    Public Sub delproc()
        Dim k As Integer
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            cmd = New OleDbCommand("select count(*) from FP_Schedule where PackageId='" & txtpackid.Text & "'", con)
            k = cmd.ExecuteScalar()
            cmd.Dispose()
            If k >= 1 Then
                MsgRecUsed()
            Else

                Dim str As String = "delete from fixeditineraries where packageid='" & txtpackid.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                fun()
                dt1.Clear()
                MsgDel()
                'clears the controls
                clearproc()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'deletes fixed itineraries day details from table using pagkage id
    Public Sub fun()
        Dim s As String = "delete from FixedItinera_Det where packageid='" & txtpackid.Text & "'"
        cmd = New OleDbCommand(s, con)
        Dim x As Byte
        x = cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    'dynamically generates rows in the data grid with respect to days at run time
    Private Sub txtdays_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdays.Leave
        Dim c As Integer
        Dim ds1 As New DataSet
        If txtdays.Text = "" Then Exit Sub
        c = CInt(txtdays.Text)
        If frmstatus = Module1.EnuRecstatus.Recedit Then
            For i As Integer = 1 To c - kk
                Dim r1 As DataRow = dt1.NewRow
                r1.Item(0) = i + kk
                r1.Item(1) = ""
                r1.Item(2) = ""
                r1.Item(3) = ""
                dt1.Rows.Add(r1)
            Next
        Else
            dt1.Clear()
            For i As Integer = 1 To c
                Dim r1 As DataRow = dt1.NewRow
                r1.Item(0) = i
                r1.Item(1) = ""
                r1.Item(2) = ""
                r1.Item(3) = ""
                dt1.Rows.Add(r1)
            Next
        End If
        dt1.Columns(0).ReadOnly = True
        dbgdaywise.DataSource = dt1
        'adjusting width of the columns in the data grid
        Dim TSModule As New DataGridTableStyle
        TSModule.MappingName = dt1.TableName
        dbgdaywise.TableStyles.Add(TSModule)
        Dim myColumnStyle As DataGridColumnStyle
        myColumnStyle = TSModule.GridColumnStyles.Item(0)
        myColumnStyle.Width = 35
        myColumnStyle = TSModule.GridColumnStyles.Item(1)
        myColumnStyle.Width = 250
        myColumnStyle = TSModule.GridColumnStyles.Item(2)
        myColumnStyle.Width = 150
        myColumnStyle = TSModule.GridColumnStyles.Item(3)
        myColumnStyle.Width = 65
        'doesnt allow last free row in the data grid
        Dim dv As DataView = dt1.DefaultView
        dv.AllowNew = False
    End Sub
    Public Sub valid()
        'checks whether the textboxes are empty
        bolvali = False
        txtpackremarks.Focus()  ' to set the focus in last text box , to fire grid events ( event of cell is not firing because the foucs is in the same cell ( it is not recognisign the cell value)
        If txtpackid.Text = "" Then
            MsgBox(" Enter package Id", MsgBoxStyle.OKOnly, Prjtitle)
            txtpackid.Focus()
            Exit Sub
        End If
        If txtpackname.Text = "" Then
            MsgBox(" Enter package name", MsgBoxStyle.OKOnly, Prjtitle)
            txtpackname.Focus()
            Exit Sub
        End If
        If txtdays.Text = "" Then
            MsgBox(" Enter no of days", MsgBoxStyle.OKOnly, Prjtitle)
            txtdays.Focus()
            Exit Sub
        End If
        If txtnights.Text = "" Then
            MsgBox(" Enter no of nights", MsgBoxStyle.OKOnly, Prjtitle)
            txtnights.Focus()
            Exit Sub
        End If
        If txtrate.Text = "" Then
            MsgBox(" Enter rate", MsgBoxStyle.OKOnly, Prjtitle)
            txtrate.Focus()
            Exit Sub
        End If
        If cobfromloc.Text = "" Then
            MsgBox(" Select from location", MsgBoxStyle.OKOnly, Prjtitle)
            cobfromloc.Focus()
            Exit Sub
        End If
        If cobtoloc.Text = "" Then
            MsgBox(" Select to location", MsgBoxStyle.OKOnly, Prjtitle)
            cobtoloc.Focus()
            Exit Sub
        End If
        Dim k As Integer
        For k = 0 To dt1.Rows.Count - 1
            If dbgdaywise.Item(k, 1) = "" Then
                MsgBox("Enter Description of the Day " & k + 1, MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            End If
        Next k
        bolvali = True
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        valid()
        If bolvali = False Then Exit Sub

        Dim b, c As String
        b = cobfromloc.Text
        c = (b.Substring(0, b.IndexOf("-")))
        Dim d, e As String
        d = cobtoloc.Text
        e = (d.Substring(0, d.IndexOf("-")))
        Try
            'checks the form status
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from FixedItineraries where PackageId='" & txtpackid.Text & "' ", con)
                p = cmd.ExecuteScalar
                cmd.Dispose()
                If p <> 0 Then
                    MsgRecexist()
                    Exit Sub
                Else
                    cmd = New OleDbCommand("insert into FixedItineraries values('" & txtpackid.Text & "','" & txtpackname.Text & "','" & txtdays.Text & "','" & txtnights.Text & "','" & txtrate.Text & "','" & c & "','" & e & "','" & IIf(txtdescription.Text = "", "", txtdescription.Text) & "','" & IIf(txtpackremarks.Text = "", "", txtpackremarks.Text) & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    f1() 'insert into fixed itenaries details table
                End If
            ElseIf frmstatus = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update FixedItineraries set PackageName='" & txtpackname.Text & "', NoofDays='" & txtdays.Text & " ', NoofNights='" & txtnights.Text & " ', Rate='" & txtrate.Text & " ', fromlocation='" & c & "', tolocation='" & e & "', description='" & IIf(txtdescription.Text = "", 0, txtdescription.Text) & "', remarks='" & IIf(txtpackremarks.Text = "", 0, txtpackremarks.Text) & "' where PackageId='" & txtpackid.Text & "'", con)
                cmd4 = New OleDbCommand("delete * from FixedItinera_Det where PackageId='" & txtpackid.Text & "'", con)
                cmd2.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                f1()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        Finally
            CloseConnection()
        End Try
        MsgSav()
        clearproc()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim da As New OleDbDataAdapter("select * from fixeditineraries", con)
        'It clears the dataset 
        dt2.Clear()
        ds1.Clear()
        'Data in the table FixedItineraries will be displayed in datagrid on click in view tab page
        If TabControl1.SelectedTab.Text = "View" Then
            da.Fill(ds1, "FixedItineraries")
            dbgview.DataSource = ds1.Tables("FixedItineraries")
            dbgview.ReadOnly = True
        End If
    End Sub
    Private Sub txtpackid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'allows to enter text and numbers  only 
        textandnumbers(e)
    End Sub
    Private Sub txtpackname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpackname.KeyPress
        'allows to enter text only 
        textonly(e)
    End Sub
    Private Sub txtdays_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdays.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub txtnights_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnights.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    Private Sub txtrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        'allows to enter number only 
        numberonly(e)
    End Sub
    'inserts record into fixed itineraries day table
    Public Sub f1()
        Dim a, b, c, d As String
        Dim i As Integer
        If con.State <> ConnectionState.Open Then
            Openconnection()
        End If
        For i = 0 To dt1.Rows.Count - 1
            a = dbgdaywise.Item(i, 0)
            b = dbgdaywise.Item(i, 1)
            c = dbgdaywise.Item(i, 2)
            d = dbgdaywise.Item(i, 3)
            cmd = New OleDbCommand("insert into FixedItinera_det values('" & txtpackid.Text & "','" & IIf(a = "", "", a) & "','" & IIf(b = "", "", b) & "','" & IIf(c = "", "", c) & "','" & IIf(d = "", "", d) & "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next i
    End Sub
    Private Sub dbgview_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        dt1.Clear()
        Dim str As String
        Dim int As Integer
        Dim dr, dr1 As OleDb.OleDbDataReader
        cobfromloc.Text = ""
        cobtoloc.Text = ""
        'locks the controls
        lock()
        'fills the current row index number in int
        int = dbgview.CurrentRowIndex
        'fills the value of row in str
        str = dbgview.Item(int, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from FixedItineraries where PackageId='" & str & "'", con)
        Try
            dr = cmd.ExecuteReader
            cmd.Dispose()
            While dr.Read()
                txtpackid.Text = dr(0)
                txtpackname.Text = dr(1)
                txtdays.Text = dr(2)
                txtnights.Text = dr(3)
                txtrate.Text = dr(4)
                Dim a, b As String
                a = dr(5)
                comboselet(cobfromloc, a)
                b = dr(6)
                comboselet(cobtoloc, b)
                txtdescription.Text = dr(7)
                txtpackremarks.Text = dr(8)
                TabControl1.SelectedTab = TabPage2
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
        Try
            If con.State <> ConnectionState.Open Then
                Openconnection()
            End If
            cmd = New OleDbCommand("select * from FixedItinera_Det where PackageId='" & str & "'", con)
            dr1 = cmd.ExecuteReader
            cmd.Dispose()
            While dr1.Read
                Dim r1 As DataRow = dt1.NewRow
                r1.Item(0) = dr1(1)
                r1.Item(1) = dr1(2)
                r1.Item(2) = dr1(3)
                r1.Item(3) = dr1(4)
                dt1.Rows.Add(r1)
            End While
            dr1.Close()
            dbgdaywise.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        CloseConnection()
        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()
    End Sub
    'sets first letter capital
    Private Sub txtpackid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpackid.Leave
        firstcap(txtpackid)
    End Sub
    'sets first letter capital
    Private Sub txtpackname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpackname.Leave
        firstcap(txtpackname)
    End Sub
    'sets first letter capital
    Private Sub txtpackremarks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpackremarks.Leave
        firstcap(txtpackremarks)
        Label1.Focus()
    End Sub
    'sets first letter capital
    Private Sub txtdescription_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdescription.Leave
        firstcap(txtdescription)
    End Sub
    Private Sub cobfromloc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobfromloc.KeyPress
        'doesnt allow to enter text in the combo box
        combo(e)
    End Sub
    Private Sub cobtoloc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobtoloc.KeyPress
        'doesnt allow to enter text in the combo box
        combo(e)
    End Sub
    'fires when data in the two combo boxes are same
    Private Sub cobtoloc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobtoloc.Leave
        If cobfromloc.SelectedItem = cobtoloc.SelectedItem Then
            MsgBox("From Location and To location should not be same", MsgBoxStyle.OKOnly, Prjtitle)
            cobtoloc.Focus()
            Exit Sub
        End If
    End Sub
    'to find the column no and row no of description group box
    Private Sub dbgdaywise_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgdaywise.Click, dbgdaywise.CurrentCellChanged
        cid = dbgdaywise.CurrentCell.ColumnNumber
        rid = dbgdaywise.CurrentCell.RowNumber
        If cid = 1 Then
            grpdescript.Visible = True
        End If
    End Sub
    'to insert text into the description group box
    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        dbgdaywise.Item(rid, cid) = txtdesc.Text
        grpdescript.Visible = False
        txtdesc.Text = ""
        dbgdaywise.Focus()
    End Sub
    'to close the description group box 
    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        grpdescript.Visible = False
    End Sub
End Class
