'written by P.R.Sudhakar Reddy
'Version 1
'date: 11 july 2006

Public Class FerryDetails
    Inherits System.Windows.Forms.Form
    Dim int_transid As Integer
    Dim cmd As OleDb.OleDbCommand
    Dim ord As OleDb.OleDbDataReader
    Dim dad As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim recmode As EnuRecstatus

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
    Friend WithEvents Groupbox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rb_dep As System.Windows.Forms.RadioButton
    Friend WithEvents rb_arr As System.Windows.Forms.RadioButton
    Friend WithEvents txt_fno As System.Windows.Forms.TextBox
    Friend WithEvents lst_ffreq As System.Windows.Forms.ListBox
    Friend WithEvents lst_days As System.Windows.Forms.ListBox
    Friend WithEvents cob_fcity As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tsport As System.Windows.Forms.TextBox
    Friend WithEvents txt_fcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_fown As System.Windows.Forms.TextBox
    Friend WithEvents txt_fsport As System.Windows.Forms.TextBox
    Friend WithEvents cob_tcity As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_rem As System.Windows.Forms.Button
    Friend WithEvents cmd_add As System.Windows.Forms.Button
    Friend WithEvents txt_rmks As System.Windows.Forms.TextBox
    Friend WithEvents rb_vdep As System.Windows.Forms.RadioButton
    Friend WithEvents rb_varr As System.Windows.Forms.RadioButton
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents tabview As System.Windows.Forms.TabPage
    Friend WithEvents tabentry As System.Windows.Forms.TabPage
    Friend WithEvents dtptime As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FerryDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabview = New System.Windows.Forms.TabPage
        Me.Groupbox3 = New System.Windows.Forms.GroupBox
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.rb_vdep = New System.Windows.Forms.RadioButton
        Me.rb_varr = New System.Windows.Forms.RadioButton
        Me.tabentry = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtptime = New System.Windows.Forms.DateTimePicker
        Me.txt_rmks = New System.Windows.Forms.TextBox
        Me.cmd_rem = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lst_ffreq = New System.Windows.Forms.ListBox
        Me.cmd_add = New System.Windows.Forms.Button
        Me.lst_days = New System.Windows.Forms.ListBox
        Me.rb_dep = New System.Windows.Forms.RadioButton
        Me.rb_arr = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.cob_fcity = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_tsport = New System.Windows.Forms.TextBox
        Me.txt_fno = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_fcode = New System.Windows.Forms.TextBox
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_fown = New System.Windows.Forms.TextBox
        Me.txt_fsport = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cob_tcity = New System.Windows.Forms.ComboBox
        Me.TabControl1.SuspendLayout()
        Me.tabview.SuspendLayout()
        Me.Groupbox3.SuspendLayout()
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabentry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabview)
        Me.TabControl1.Controls.Add(Me.tabentry)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(600, 360)
        Me.TabControl1.TabIndex = 0
        '
        'tabview
        '
        Me.tabview.Controls.Add(Me.Groupbox3)
        Me.tabview.Location = New System.Drawing.Point(4, 22)
        Me.tabview.Name = "tabview"
        Me.tabview.Size = New System.Drawing.Size(592, 334)
        Me.tabview.TabIndex = 0
        Me.tabview.Text = "View"
        '
        'Groupbox3
        '
        Me.Groupbox3.Controls.Add(Me.dbg)
        Me.Groupbox3.Controls.Add(Me.rb_vdep)
        Me.Groupbox3.Controls.Add(Me.rb_varr)
        Me.Groupbox3.Location = New System.Drawing.Point(0, 0)
        Me.Groupbox3.Name = "Groupbox3"
        Me.Groupbox3.Size = New System.Drawing.Size(592, 328)
        Me.Groupbox3.TabIndex = 0
        Me.Groupbox3.TabStop = False
        '
        'dbg
        '
        Me.dbg.DataMember = ""
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(16, 56)
        Me.dbg.Name = "dbg"
        Me.dbg.ReadOnly = True
        Me.dbg.Size = New System.Drawing.Size(536, 248)
        Me.dbg.TabIndex = 2
        '
        'rb_vdep
        '
        Me.rb_vdep.Location = New System.Drawing.Point(264, 24)
        Me.rb_vdep.Name = "rb_vdep"
        Me.rb_vdep.Size = New System.Drawing.Size(88, 16)
        Me.rb_vdep.TabIndex = 1
        Me.rb_vdep.Text = "Departures"
        '
        'rb_varr
        '
        Me.rb_varr.Checked = True
        Me.rb_varr.Location = New System.Drawing.Point(160, 24)
        Me.rb_varr.Name = "rb_varr"
        Me.rb_varr.Size = New System.Drawing.Size(72, 16)
        Me.rb_varr.TabIndex = 0
        Me.rb_varr.TabStop = True
        Me.rb_varr.Text = "Arrivals"
        '
        'tabentry
        '
        Me.tabentry.Controls.Add(Me.GroupBox2)
        Me.tabentry.Location = New System.Drawing.Point(4, 22)
        Me.tabentry.Name = "tabentry"
        Me.tabentry.Size = New System.Drawing.Size(592, 334)
        Me.tabentry.TabIndex = 1
        Me.tabentry.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtptime)
        Me.GroupBox2.Controls.Add(Me.txt_rmks)
        Me.GroupBox2.Controls.Add(Me.cmd_rem)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lst_ffreq)
        Me.GroupBox2.Controls.Add(Me.cmd_add)
        Me.GroupBox2.Controls.Add(Me.lst_days)
        Me.GroupBox2.Controls.Add(Me.rb_dep)
        Me.GroupBox2.Controls.Add(Me.rb_arr)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cob_fcity)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txt_tsport)
        Me.GroupBox2.Controls.Add(Me.txt_fno)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_fcode)
        Me.GroupBox2.Controls.Add(Me.txt_fname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_fown)
        Me.GroupBox2.Controls.Add(Me.txt_fsport)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cob_tcity)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 328)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dtptime
        '
        Me.dtptime.CustomFormat = "HH:mm"
        Me.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptime.Location = New System.Drawing.Point(256, 144)
        Me.dtptime.Name = "dtptime"
        Me.dtptime.ShowUpDown = True
        Me.dtptime.Size = New System.Drawing.Size(64, 21)
        Me.dtptime.TabIndex = 10
        Me.dtptime.Value = New Date(2006, 7, 18, 0, 0, 0, 0)
        '
        'txt_rmks
        '
        Me.txt_rmks.Location = New System.Drawing.Point(88, 280)
        Me.txt_rmks.Multiline = True
        Me.txt_rmks.Name = "txt_rmks"
        Me.txt_rmks.Size = New System.Drawing.Size(456, 40)
        Me.txt_rmks.TabIndex = 17
        Me.txt_rmks.Text = ""
        '
        'cmd_rem
        '
        Me.cmd_rem.Location = New System.Drawing.Point(352, 240)
        Me.cmd_rem.Name = "cmd_rem"
        Me.cmd_rem.Size = New System.Drawing.Size(64, 24)
        Me.cmd_rem.TabIndex = 16
        Me.cmd_rem.Text = "Remove <"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Flight Frequency"
        '
        'lst_ffreq
        '
        Me.lst_ffreq.Location = New System.Drawing.Point(432, 176)
        Me.lst_ffreq.Name = "lst_ffreq"
        Me.lst_ffreq.Size = New System.Drawing.Size(112, 95)
        Me.lst_ffreq.TabIndex = 15
        '
        'cmd_add
        '
        Me.cmd_add.Location = New System.Drawing.Point(208, 200)
        Me.cmd_add.Name = "cmd_add"
        Me.cmd_add.Size = New System.Drawing.Size(64, 24)
        Me.cmd_add.TabIndex = 14
        Me.cmd_add.Text = "Add >"
        '
        'lst_days
        '
        Me.lst_days.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.lst_days.Location = New System.Drawing.Point(88, 176)
        Me.lst_days.Name = "lst_days"
        Me.lst_days.Size = New System.Drawing.Size(104, 95)
        Me.lst_days.TabIndex = 12
        '
        'rb_dep
        '
        Me.rb_dep.Location = New System.Drawing.Point(304, 8)
        Me.rb_dep.Name = "rb_dep"
        Me.rb_dep.TabIndex = 10
        Me.rb_dep.Text = "Departures"
        '
        'rb_arr
        '
        Me.rb_arr.Checked = True
        Me.rb_arr.Location = New System.Drawing.Point(176, 8)
        Me.rb_arr.Name = "rb_arr"
        Me.rb_arr.Size = New System.Drawing.Size(88, 24)
        Me.rb_arr.TabIndex = 1
        Me.rb_arr.TabStop = True
        Me.rb_arr.Text = "Arrivals"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(24, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Remarks"
        '
        'cob_fcity
        '
        Me.cob_fcity.Location = New System.Drawing.Point(264, 72)
        Me.cob_fcity.Name = "cob_fcity"
        Me.cob_fcity.Size = New System.Drawing.Size(104, 21)
        Me.cob_fcity.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(392, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Seaport"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(192, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "To City"
        '
        'txt_tsport
        '
        Me.txt_tsport.Location = New System.Drawing.Point(472, 104)
        Me.txt_tsport.Name = "txt_tsport"
        Me.txt_tsport.TabIndex = 9
        Me.txt_tsport.Text = ""
        '
        'txt_fno
        '
        Me.txt_fno.Location = New System.Drawing.Point(88, 40)
        Me.txt_fno.Name = "txt_fno"
        Me.txt_fno.TabIndex = 2
        Me.txt_fno.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ferry No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ferry Code"
        '
        'txt_fcode
        '
        Me.txt_fcode.Location = New System.Drawing.Point(264, 40)
        Me.txt_fcode.Name = "txt_fcode"
        Me.txt_fcode.TabIndex = 3
        Me.txt_fcode.Text = ""
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(472, 40)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.TabIndex = 4
        Me.txt_fname.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(392, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Ferry Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(392, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Seaport"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ferry Owner"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(192, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "From City"
        '
        'txt_fown
        '
        Me.txt_fown.Location = New System.Drawing.Point(88, 72)
        Me.txt_fown.Name = "txt_fown"
        Me.txt_fown.TabIndex = 5
        Me.txt_fown.Text = ""
        '
        'txt_fsport
        '
        Me.txt_fsport.Location = New System.Drawing.Point(472, 72)
        Me.txt_fsport.Name = "txt_fsport"
        Me.txt_fsport.TabIndex = 7
        Me.txt_fsport.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Days"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(136, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Arrival  / Depart Time *"
        '
        'cob_tcity
        '
        Me.cob_tcity.Location = New System.Drawing.Point(264, 104)
        Me.cob_tcity.Name = "cob_tcity"
        Me.cob_tcity.Size = New System.Drawing.Size(104, 21)
        Me.cob_tcity.TabIndex = 8
        '
        'FerryDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(600, 365)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FerryDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ferry Details"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.tabview.ResumeLayout(False)
        Me.Groupbox3.ResumeLayout(False)
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabentry.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FerryDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        TabControl1.SelectedTab = tabentry 'opens entry/edit page on pageload
        'setting arrival radio button as default
        rb_arr.Checked = True
        'loading comboboxs
        cobload()
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
            If TypeOf (x) Is ListBox Then
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
            If TypeOf (x) Is ListBox Then
                x.enabled = True
            End If
        Next
    End Sub
    Public Sub clearproc()
        ' procedure for clearing all text in textboxs,comboboxs,listboxs
        Dim x As Object
        For Each x In Me.GroupBox2.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
            If TypeOf (x) Is ComboBox Then
                x.text = ""
            End If
        Next
        lst_ffreq.Items.Clear()
    End Sub
    Public Sub delproc()
        'procedure for deleting record from ferry_details 
        Dim YESNO As String
        YESNO = MsgDelAlert()
        If YESNO = vbNo Then
            Exit Sub
        End If
        If YESNO = vbYes Then
            Openconnection()
            cmd = New OleDb.OleDbCommand("delete from Ferry_Details where transid=" & int_transid & "", con)
            cmd.ExecuteNonQuery()
            MsgDel()
            con.Close()
        End If
    End Sub
    ' procedure for loading the city comboboxs with data from city master
    Public Sub cobload()
        Openconnection()
        cmd = New OleDb.OleDbCommand("select City from CityMaster", con)
        ord = cmd.ExecuteReader()
        cob_fcity.Items.Clear()
        cob_tcity.Items.Clear()
        While ord.Read
            cob_fcity.Items.Add(ord(0))
            cob_tcity.Items.Add(ord(0))
        End While
        con.Close()
        ord.Close()
        cmd.Dispose()
    End Sub
    Private Sub cmd_rem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_rem.Click
        ' removing selected day from lst_ffreq 
        If lst_ffreq.SelectedIndex < 0 Then
            MsgBox("You have not selected the day to be removed")
        Else
            lst_ffreq.Items.Remove(lst_ffreq.SelectedItem())
        End If
    End Sub
    Private Sub cmd_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_add.Click
        ' adding selected day from lst_days to lst_ffreq 
        Dim int_i As Integer
        If lst_days.SelectedIndex < 0 Then
            MsgBox("you have not selected day to be added")
        Else
            If lst_ffreq.Items.Contains(lst_days.SelectedItem) Then
                MsgBox("you have already selected the day")
            Else
                lst_ffreq.Items.Add(lst_days.SelectedItem)
            End If
        End If
    End Sub
    Public Sub newproc()
        enproc()
        recmode = Module1.EnuRecstatus.Recnew
        'clearing objects in the form
        clearproc()
        TabControl1.SelectedTab = tabentry 'opens entry/edit page on pageload
        'loading comboboxs
        cobload()

    End Sub
    Public Sub editproc()
        enproc()
        txt_fno.Enabled = False
        recmode = Module1.EnuRecstatus.Recedit
        'loading comboboxs
        cobload()
    End Sub
    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click, TabControl1.TabIndexChanged
        ' loading datagrid when view tab is selected
        If TabControl1.SelectedTab Is tabview Then
            ds = New DataSet
            If rb_varr.Checked = True Then
                dad = New OleDb.OleDbDataAdapter("select TransId,FerryNo,FerryName,FerryOwner,FromPort,ToPort from Ferry_Details where Ferry_ArrDep = 'Arr'", con)
                dad.Fill(ds, "afm")
                dbg.Refresh()
                dbg.DataSource = ds
                dbg.DataMember = "afm"
                dbg.ReadOnly = True
            End If
            If rb_vdep.Checked = True Then
                ds = New DataSet
                dad = New OleDb.OleDbDataAdapter("select TransId,FerryNo,FerryName,FerryOwner,FromPort,ToPort from Ferry_Details where Ferry_ArrDep = 'Dep'", con)
                dad.Fill(ds, "dfm")
                dbg.Refresh()
                dbg.DataSource = ds
                dbg.DataMember = "dfm"
                dbg.ReadOnly = True
            End If
        End If
        If TabControl1.SelectedTab Is tabentry Then
            cobload()
        End If
    End Sub
    Private Sub rb_varr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_varr.Click
        ' loading datagrid with arrival data when radio button is clicked
        ds = New DataSet
        dad = New OleDb.OleDbDataAdapter("select TransId,FerryNo,FerryName,FerryOwner,FromPort,ToPort from Ferry_Details where Ferry_ArrDep = 'Arr'", con)
        dad.Fill(ds, "afm")
        dbg.Refresh()
        dbg.DataSource = ds
        dbg.DataMember = "afm"
        dbg.ReadOnly = True
    End Sub

    Private Sub rb_vdep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_vdep.Click
        ' loading datagrid with departure data when radio button is clicked
        ds = New DataSet
        dad = New OleDb.OleDbDataAdapter("select TransId,FerryNo,FerryName,FerryOwner,FromPort,ToPort from Ferry_Details where Ferry_ArrDep = 'Dep'", con)
        dad.Fill(ds, "dfm")
        dbg.Refresh()
        dbg.DataSource = ds
        dbg.DataMember = "dfm"
        dbg.ReadOnly = True
    End Sub
    Private Sub dbg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbg.DoubleClick
        Dim str_cif As String
        Dim str_cit As String
        Dim str_freq As String
        Dim str_ti As String
        If rb_varr.Checked = True Then
            rb_arr.Checked = True
        Else
            rb_dep.Checked = True
        End If

        Openconnection()
        'loading textboxs, comboboxs, listboxs with appropriate data when datagrid is doble clicked on particular row  
        cmd = New OleDb.OleDbCommand("select * from Ferry_Details where TransId=" & dbg.Item(dbg.CurrentRowIndex, 0) & "", con)
        ord = cmd.ExecuteReader
        While ord.Read
            int_transid = ord(0)
            txt_fno.Text = ord(2)
            txt_fcode.Text = ord(3)
            txt_fname.Text = ord(4)
            txt_fown.Text = ord(5)
            str_cif = ord(6)
            txt_fsport.Text = ord(7)
            str_cit = ord(8)
            txt_tsport.Text = ord(9)
            str_freq = ord(10)
            str_ti = ord(11)
            txt_rmks.Text = ord(12)
        End While
        cmd.Dispose()
        ord.Close()
        ' retrieving city name using cityid from city master for fromcity combobox
        cmd = New OleDb.OleDbCommand("select City from CityMaster where CityId='" & str_cif & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_fcity.SelectedItem = ord(0)
        End While
        cmd.Dispose()
        ord.Close()
        ' retrieving city name using cityid from city master for tocity combobox
        cmd = New OleDb.OleDbCommand("select City from CityMaster where CityId='" & str_cit & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_tcity.SelectedItem = ord(0)
        End While
        cmd.Dispose()
        ord.Close()
        con.Close()
        'splitting concatinated days string into single days and loading into listbox
        lst_ffreq.Items.Clear()
        Dim tfreq As String
        tfreq = str_freq
        Dim int_i As Integer
        int_i = 1
        While int_i > 0
            int_i = InStr(str_freq, ",")
            If int_i > 0 Then
                tfreq = Mid(str_freq, 1, int_i - 1)
                lst_ffreq.Items.Add(tfreq)
                str_freq = Mid(str_freq, int_i + 1)
            End If
        End While
        lst_ffreq.Items.Add(str_freq)

        'showing time
        dtptime.Text = str_ti

        'showing entry after filling the data
        TabControl1.SelectedTab = tabentry
        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()

    End Sub
    'procedure for saving entry form
    Public Sub saveproc()
        Dim str_ti As String
        Dim str_freq As String
        Dim int_lcount As Integer
        Dim int_i As Integer
        Dim str_ad As String
        Dim str_fci As String
        Dim str_tci As String
        Dim int_tid As Integer
        'Atleast one day to be selected    
        If lst_ffreq.Items.Count = 0 Then
            MsgBox("select atleast one day")
            Exit Sub
        End If
        'ferry number should not be empty
        If txt_fno.Text = "" Then
            MsgBox(" FERRY NUMBER SHOULD NOT BE EMPTY")
            txt_fno.Focus()
            Exit Sub
        End If
        firstcap(txt_fno)
        'ferry name should not be empty
        If txt_fname.Text = "" Then
            MsgBox(" FERRY NAME SHOULD NOT BE EMPTY")
            txt_fname.Focus()
            Exit Sub
        End If
        firstcap(txt_fname)
        'ferry code should not be empty
        If txt_fcode.Text = "" Then
            MsgBox(" FERRY CODE SHOULD NOT BE EMPTY")
            txt_fcode.Focus()
            Exit Sub
        End If
        firstcap(txt_fcode)
        'from sea port should not be empty
        If txt_fsport.Text = "" Then
            MsgBox(" FROM SEAPORT SHOULD NOT BE EMPTY")
            txt_fsport.Focus()
            Exit Sub
        End If
        firstcap(txt_fsport)
        'to sea port should not be empty
        If txt_tsport.Text = "" Then
            MsgBox(" FROM SEAPORT SHOULD NOT BE EMPTY")
            txt_tsport.Focus()
            Exit Sub
        End If
        firstcap(txt_tsport)
        'ferry owner should not be empty
        If txt_fown.Text = "" Then
            MsgBox(" FERRY OWNER SHOULD NOT BE EMPTY")
            txt_fown.Focus()
            Exit Sub
        End If
        firstcap(txt_fown)
        'FROM CITY SHOULD NOT BE EMPTY
        If cob_fcity.Text = "" Then
            MsgBox(" FROM CITY SHOULD NOT BE EMPTY")
            cob_fcity.Focus()
            Exit Sub
        End If
        'to CITY SHOULD NOT BE EMPTY
        If cob_tcity.Text = "" Then
            MsgBox(" TO CITY SHOULD NOT BE EMPTY")
            cob_tcity.Focus()
            Exit Sub
        End If


        cmd.Dispose()
        Openconnection()
        ' retrieving  from city name using cityid
        cmd = New OleDb.OleDbCommand("select CityId from CityMaster where City ='" & cob_fcity.Text & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            str_fci = ord(0)
        End While
        cmd.Dispose()
        ord.Close()
        ' retrieving to city name using cityid
        cmd = New OleDb.OleDbCommand("select CityId from CityMaster where City ='" & cob_tcity.Text & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            str_tci = ord(0)
        End While
        cmd.Dispose()
        ord.Close()
        'initializing transid for first time when rows in table are zero
        cmd = New OleDb.OleDbCommand("select count(*) from Ferry_Details", con)
        int_tid = cmd.ExecuteScalar
        cmd.Dispose()
        If int_tid >= 1 Then
            ' retrieving tansaction id 
            cmd = New OleDb.OleDbCommand("select max(TransId) from Ferry_Details ", con)
            int_tid = cmd.ExecuteScalar
            cmd.Dispose()
        End If
        ' incrementing transaction id
        int_tid = int_tid + 1

        str_ti = dtptime.Text

        'concatting selected days in listbox 
        int_lcount = lst_ffreq.Items.Count
        For int_i = 0 To int_lcount - 1
            If int_i < int_lcount - 1 Then
                str_freq = str_freq + lst_ffreq.Items.Item(int_i) + ","
            Else
                str_freq = str_freq + lst_ffreq.Items.Item(int_i)
            End If

        Next
        'checking where radio button is checked and assining relavent value
        If recmode = Module1.EnuRecstatus.Recnew Then
            If rb_arr.Checked = True Then
                str_ad = "Arr"
            End If
            If rb_dep.Checked = True Then
                str_ad = "Dep"
            End If
            ' inserting into Ferry_details table
            cmd = New OleDb.OleDbCommand("insert into ferry_details values(" & int_tid & ",'" & str_ad & "','" & txt_fno.Text & "','" & txt_fcode.Text & "','" & txt_fname.Text & "','" & txt_fown.Text & "','" & str_fci & "','" & txt_fsport.Text & "','" & str_tci & "','" & txt_tsport.Text & "','" & str_freq & "','" & str_ti & "','" & txt_rmks.Text & "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            CloseConnection()
        End If
        'updating table Ferry_details table
        If recmode = Module1.EnuRecstatus.Recedit Then
            If rb_arr.Checked = True Then
                str_ad = "Arr"
            End If
            If rb_dep.Checked = True Then
                str_ad = "Dep"
            End If
            cmd = New OleDb.OleDbCommand("update Ferry_Details set Ferry_ArrDep='" & str_ad & "',FerryNo='" & txt_fno.Text & "',FerryCode='" & txt_fcode.Text & "',FerryName='" & txt_fname.Text & "',FerryOwner='" & txt_fown.Text & "',FromCityId='" & str_fci & "',FromPort='" & txt_fsport.Text & "',ToCityId='" & str_tci & "',ToPort='" & txt_tsport.Text & "',Frequency='" & str_freq & "',ArrdepTime='" & str_ti & "',Remarks='" & txt_rmks.Text & "'Where TransId=" & int_transid & "", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            CloseConnection()
        End If
        MsgSav()
        clearproc()
        disproc()
    End Sub

End Class
