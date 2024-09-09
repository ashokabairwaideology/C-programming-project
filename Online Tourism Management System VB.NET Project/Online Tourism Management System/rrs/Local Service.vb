'Name developer: baskar.ch
'Dt:23/07/06
'Purpose :
'Version :1
Imports System.Data.oledb
Public Class Local_Service
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cobbookingid As System.Windows.Forms.ComboBox
    Friend WithEvents cobveh As System.Windows.Forms.ComboBox
    Friend WithEvents cobdrivername As System.Windows.Forms.ComboBox
    Friend WithEvents cobvehtype As System.Windows.Forms.ComboBox
    Friend WithEvents dbg1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtto As System.Windows.Forms.TextBox
    Friend WithEvents txtfrom As System.Windows.Forms.TextBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents txtserviceproto As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofpass As System.Windows.Forms.TextBox
    Friend WithEvents txtsysref As System.Windows.Forms.TextBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Local_Service))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dbg1 = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.txtsysref = New System.Windows.Forms.TextBox
        Me.cobbookingid = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cobveh = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cobdrivername = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtto = New System.Windows.Forms.TextBox
        Me.txtfrom = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtnoofpass = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtserviceproto = New System.Windows.Forms.TextBox
        Me.cobvehtype = New System.Windows.Forms.ComboBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(48, 18)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(520, 200)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(512, 174)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dbg1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dbg1
        '
        Me.dbg1.CaptionVisible = False
        Me.dbg1.DataMember = ""
        Me.dbg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg1.Location = New System.Drawing.Point(0, 8)
        Me.dbg1.Name = "dbg1"
        Me.dbg1.ReadOnly = True
        Me.dbg1.Size = New System.Drawing.Size(488, 144)
        Me.dbg1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(512, 174)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        Me.TabPage2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp1)
        Me.GroupBox2.Controls.Add(Me.txtsysref)
        Me.GroupBox2.Controls.Add(Me.cobbookingid)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cobveh)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cobdrivername)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtto)
        Me.GroupBox2.Controls.Add(Me.txtfrom)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtrate)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtnoofpass)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtserviceproto)
        Me.GroupBox2.Controls.Add(Me.cobvehtype)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 160)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'dtp1
        '
        Me.dtp1.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp1.Location = New System.Drawing.Point(368, 72)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.ShowCheckBox = True
        Me.dtp1.Size = New System.Drawing.Size(136, 21)
        Me.dtp1.TabIndex = 164
        '
        'txtsysref
        '
        Me.txtsysref.Location = New System.Drawing.Point(296, 136)
        Me.txtsysref.Name = "txtsysref"
        Me.txtsysref.Size = New System.Drawing.Size(32, 18)
        Me.txtsysref.TabIndex = 163
        Me.txtsysref.Text = ""
        Me.txtsysref.Visible = False
        '
        'cobbookingid
        '
        Me.cobbookingid.ItemHeight = 12
        Me.cobbookingid.Location = New System.Drawing.Point(144, 72)
        Me.cobbookingid.Name = "cobbookingid"
        Me.cobbookingid.Size = New System.Drawing.Size(120, 20)
        Me.cobbookingid.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(272, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "Date* "
        '
        'cobveh
        '
        Me.cobveh.ItemHeight = 12
        Me.cobveh.Location = New System.Drawing.Point(368, 96)
        Me.cobveh.Name = "cobveh"
        Me.cobveh.Size = New System.Drawing.Size(136, 20)
        Me.cobveh.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(272, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "Vehicle No "
        '
        'cobdrivername
        '
        Me.cobdrivername.ItemHeight = 12
        Me.cobdrivername.Location = New System.Drawing.Point(144, 120)
        Me.cobdrivername.Name = "cobdrivername"
        Me.cobdrivername.Size = New System.Drawing.Size(120, 20)
        Me.cobdrivername.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "From"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtto
        '
        Me.txtto.AutoSize = False
        Me.txtto.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.txtto.Location = New System.Drawing.Point(368, 48)
        Me.txtto.MaxLength = 25
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(136, 18)
        Me.txtto.TabIndex = 3
        Me.txtto.Text = ""
        '
        'txtfrom
        '
        Me.txtfrom.AutoSize = False
        Me.txtfrom.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.txtfrom.Location = New System.Drawing.Point(144, 48)
        Me.txtfrom.MaxLength = 25
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.Size = New System.Drawing.Size(120, 18)
        Me.txtfrom.TabIndex = 2
        Me.txtfrom.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(272, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 17)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "To"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.txtrate.Location = New System.Drawing.Point(368, 120)
        Me.txtrate.MaxLength = 5
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(136, 18)
        Me.txtrate.TabIndex = 9
        Me.txtrate.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(272, 120)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 17)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "Rate *"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(8, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 17)
        Me.Label25.TabIndex = 143
        Me.Label25.Text = "Vehicle Type "
        '
        'txtnoofpass
        '
        Me.txtnoofpass.AutoSize = False
        Me.txtnoofpass.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.txtnoofpass.Location = New System.Drawing.Point(368, 24)
        Me.txtnoofpass.MaxLength = 2
        Me.txtnoofpass.Name = "txtnoofpass"
        Me.txtnoofpass.Size = New System.Drawing.Size(136, 18)
        Me.txtnoofpass.TabIndex = 1
        Me.txtnoofpass.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(8, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Driver Name "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Booking Id*  "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(272, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Number of Pax "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Service Provided To*"
        '
        'txtserviceproto
        '
        Me.txtserviceproto.AutoSize = False
        Me.txtserviceproto.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.txtserviceproto.Location = New System.Drawing.Point(144, 24)
        Me.txtserviceproto.MaxLength = 25
        Me.txtserviceproto.Name = "txtserviceproto"
        Me.txtserviceproto.Size = New System.Drawing.Size(120, 18)
        Me.txtserviceproto.TabIndex = 0
        Me.txtserviceproto.Text = ""
        '
        'cobvehtype
        '
        Me.cobvehtype.ItemHeight = 12
        Me.cobvehtype.Location = New System.Drawing.Point(144, 96)
        Me.cobvehtype.Name = "cobvehtype"
        Me.cobvehtype.Size = New System.Drawing.Size(120, 20)
        Me.cobvehtype.TabIndex = 6
        '
        'Local_Service
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(528, 197)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Local_Service"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Local Service"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dbg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cmd, cmd1 As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ad As New OleDbDataAdapter("select * from local_service", con)
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim frmstatus As EnuRecstatus
    'in form load all 
    Private Sub Local_Service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        dtp1.Checked = False

        'on page load it displays entry/edit tab page
        TabControl1.SelectedTab = TabPage2
        'it fills the combo box with booking ids
        combofill(cobbookingid, "select BookingId from booking_itinary") 'fills the combobox
        combofill1(cobvehtype, "select VehTypeid,VehType from veh_type")
        combofill1(cobdrivername, "select employeeid,firstname from employeemaster")
        'locks the controls
        lock()
    End Sub
    Public Sub lock()
        'locks the controls
        txtserviceproto.ReadOnly = True
        txtnoofpass.ReadOnly = True
        txtfrom.ReadOnly = True
        txtto.ReadOnly = True
        txtrate.ReadOnly = True
        cobbookingid.Enabled = False
        cobdrivername.Enabled = False
        cobveh.Enabled = False
        cobvehtype.Enabled = False
        dtp1.Enabled = False
    End Sub
    'Clears the controls on the form
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
        ds.Clear()
        lock()
    End Sub
    'It enables the enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        Try
            frmstatus = Module1.EnuRecstatus.Recnew 'form status as new mode
            txtserviceproto.ReadOnly = False
            txtnoofpass.ReadOnly = False
            txtfrom.ReadOnly = False
            txtto.ReadOnly = False
            txtrate.ReadOnly = False
            cobbookingid.Enabled = True
            cobdrivername.Enabled = True
            cobveh.Enabled = True
            cobvehtype.Enabled = True
            dtp1.Enabled = True
            If dtp1.Checked = True Then
                dtp1.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cobvehtype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobvehtype.SelectedIndexChanged
        Dim b, c As String
        If cobvehtype.Text = "" Then Exit Sub
        b = cobvehtype.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill(cobveh, "select regno from OwnVehicleMaster where vehtypeid='" & c & "'")
    End Sub
    'this procedure inserts a new record  or update an existing record
    Public Sub saveproc()
        If txtserviceproto.Text = "" Then
            MsgBox("Select Client name")
            txtserviceproto.Focus()
            Exit Sub
        End If
        If cobbookingid.Text = "" Then
            MsgBox("Select booking id")
            cobbookingid.Focus()
            Exit Sub
        End If
        If txtrate.Text = "" Then
            MsgBox(" Enter rate")
            txtrate.Focus()
            Exit Sub
        End If
        Label1.Focus()
        Try
            Dim a, b, c, d, e, f, g As String
            Dim z As String
            'fills country id combobox from country master
            b = cobvehtype.SelectedItem
            c = (b.Substring(0, b.IndexOf("-")))
            'fills state id combobox from state master
            a = cobdrivername.SelectedItem
            d = (a.Substring(0, a.IndexOf("-")))
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Local_Service where BookingId='" & cobbookingid.Text & "' and  RegNo='" & cobveh.Text & "' and Serv_Date=#" & dtp1.Value & "# and Amount=" & txtrate.Text & "", con)
                p = cmd.ExecuteScalar
                cmd.Dispose()
                If p <> 0 Then
                    MsgRecexist()
                    Exit Sub
                End If
                Dim sysrefno As Integer
                cmd1 = New OleDb.OleDbCommand("select count(*) from Local_Service", con)
                sysrefno = cmd1.ExecuteScalar
                cmd1.Dispose()
                If sysrefno >= 1 Then
                    ' retrieving tansaction id 
                    cmd1 = New OleDb.OleDbCommand("select max(Sysrefno) from Local_Service ", con)
                    sysrefno = cmd1.ExecuteScalar
                    cmd1.Dispose()
                End If
                ' incrementing transaction id
                sysrefno = sysrefno + 1
                Dim strr As String
                cmd = New OleDbCommand("insert into Local_Service values('" & sysrefno & "','" & txtserviceproto.Text & "','" & IIf(txtnoofpass.Text = "", 0, txtnoofpass.Text) & "','" & IIf(txtfrom.Text = "", 0, txtfrom.Text) & "','" & IIf(txtto.Text = "", 0, txtto.Text) & "','" & cobbookingid.Text & "'," & IIf(dtp1.Checked = False, "null", "'" & dtp1.Text & "'") & ",'" & c & "','" & IIf(cobveh.Text = "", 0, cobveh.Text) & "','" & d & "'," & IIf(txtrate.Text = "", 0, txtrate.Text) & ")", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            ElseIf frmstatus = Module1.EnuRecstatus.Recedit Then
                Dim j, i As Integer
                Dim x As String
                Openconnection()
                cmd = New OleDbCommand("update Local_Service set Client_Name='" & txtserviceproto.Text & "',No_Pax='" & txtnoofpass.Text & "',From_Loc='" & txtfrom.Text & "',To_Loc='" & txtto.Text & "',BookingId='" & cobbookingid.Text & "',Serv_Date=" & IIf(dtp1.Checked = False, "null", "'" & dtp1.Text & "'") & ",VehTypeid='" & c & "',RegNo='" & cobveh.Text & "',EmployeeId='" & d & "',Amount='" & txtrate.Text & "' where sysrefno=" & txtsysref.Text & "", con)
                cmd.ExecuteNonQuery()
            End If
            'Displays the updated message in messagebox
            MsgSav()
            'clears the controls
            clearproc()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
        Finally
            CloseConnection()
        End Try
    End Sub
    ' it is used to updating the record
    Public Sub editproc()
        frmstatus = Module1.EnuRecstatus.Recedit  'form status as edit mode
        txtserviceproto.ReadOnly = False
        txtnoofpass.ReadOnly = False
        txtfrom.ReadOnly = False
        txtto.ReadOnly = False
        txtrate.ReadOnly = False
        cobbookingid.Enabled = True
        cobdrivername.Enabled = True
        cobveh.Enabled = True
        cobvehtype.Enabled = True
        dtp1.Enabled = True
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available")
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ds.Clear()
        If TabControl1.SelectedTab.Text = "View" Then
            ad.Fill(ds, "local_service")
            dbg1.DataSource = ds.Tables("local_service")
        End If
    End Sub
    'it uses to delete the record
    Public Sub delproc()
        Dim i As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "delete from local_service where BookingId='" & cobbookingid.Text & "' and  RegNo='" & cobveh.Text & "' and Serv_Date=#" & dtp1.Value & "# and Amount=" & txtrate.Text & ""
            cmd = New OleDbCommand(str, con)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgDel()
                'clears the controls
                clearproc()
            Else
                MsgBox("Record Not Found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'it fills the data of selected row into form fields
    Private Sub dbg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbg1.DoubleClick
        Dim i, x As String
        Dim k As Integer
        Dim str_coun As String
        Dim dr As OleDb.OleDbDataReader 'on click values of record in the datagrid comes on the form
        lock()
        cobbookingid.Text = ""
        cobdrivername.Text = ""
        cobveh.Text = ""
        cobvehtype.Text = ""
        k = dbg1.CurrentRowIndex
        i = dbg1.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from local_service where Sysrefno=" & i & "", con)
        Try
            Dim a, b As String
            'Dim z As DBNull
            dr = cmd.ExecuteReader
            dr.Read()
            txtsysref.Text = dr(0)
            txtserviceproto.Text = dr(1)
            txtnoofpass.Text = dr(2)
            txtfrom.Text = dr(3)
            txtto.Text = dr(4)
            cobbookingid.Text = dr(5)
            'z = dr(6)
            If IsDBNull(dr(6)) = True Then

                dtp1.Checked = False
                dtp1.Enabled = False
            Else
                dtp1.Checked = True
                dtp1.Text = dr(6)
            End If
            'dtp1.Text = dr(6) & ""

            a = dr(7)
            comboselet(cobvehtype, a)
            'cobvehtype.Text = dr(7)
            cobveh.Text = dr(8)
            b = dr(9)
            comboselet(cobdrivername, b)
            'cobdrivername.Text = dr(9)
            txtrate.Text = dr(10)
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
    ' uses to enter the first letter as capital letter
    Private Sub txtfrom_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfrom.Leave
        firstcap(txtfrom)
    End Sub
    'allows to enter text only 
    Private Sub txtserviceproto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserviceproto.KeyPress, txtfrom.KeyPress, txtto.KeyPress
        textandnumbers(e)
    End Sub
    'allows to enter number only 
    Private Sub txtnoofpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnoofpass.KeyPress, txtrate.KeyPress
        numberonly(e)
    End Sub
    Private Sub txtto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtto.Leave
        firstcap(txtto)
    End Sub
    Private Sub txtserviceproto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtserviceproto.Leave
        firstcap(txtserviceproto)
    End Sub

    Private Sub cobbookingid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobbookingid.KeyPress
        combo(e)
    End Sub

    Private Sub cobdrivername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobdrivername.KeyPress
        combo(e)
    End Sub

    Private Sub cobveh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobveh.KeyPress
        combo(e)
    End Sub

    Private Sub cobvehtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobvehtype.KeyPress
        combo(e)
    End Sub
End Class
