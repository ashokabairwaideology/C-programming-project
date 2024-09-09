'written by P.R.Sudhakar Reddy
'Version 1
'date: 16 Aug 2006


Public Class edit_cust_Veh
    Inherits System.Windows.Forms.Form
    Dim bid, season, cuid As String
    Dim cmd As OleDb.OleDbCommand
    Dim ord As OleDb.OleDbDataReader
    Dim ds As New DataSet
    Dim recmode As Module1.EnuRecstatus
    Dim dr As DataRow
    Dim vbid(20), crid As Integer

    'data table for vehicle
    Dim dt3 As New DataTable("veh")
    Dim dt3c0 As New DataColumn("vbookid")
    Dim dt3c1 As New DataColumn("From Date")
    Dim dt3c2 As New DataColumn("From Time")
    Dim dt3c3 As New DataColumn(" To Date ")
    Dim dt3c4 As New DataColumn(" To Time ")
    Dim dt3c5 As New DataColumn(" Vehicle")
    Dim dt3c6 As New DataColumn("No OF Veh")
    Dim dt3c7 As New DataColumn("Base Price")
    Dim dt3c8 As New DataColumn("Kms")
    Dim dt3c9 As New DataColumn("Hours")
    Dim dt3c10 As New DataColumn("Extra Rate")
    Dim dt3c11 As New DataColumn(" Payment ")
    Dim dt3c12 As New DataColumn(" Comments ")
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
    Friend WithEvents gbvehicle As System.Windows.Forms.GroupBox
    Friend WithEvents label25 As System.Windows.Forms.Label
    Friend WithEvents txt_veh_erate As System.Windows.Forms.TextBox
    Friend WithEvents Txt_veh_Bkms As System.Windows.Forms.TextBox
    Friend WithEvents txt_Veh_Brate As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Veh_cmts As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents label13 As System.Windows.Forms.Label
    Friend WithEvents txt_VehBid As System.Windows.Forms.TextBox
    Friend WithEvents txt_vqty As System.Windows.Forms.TextBox
    Friend WithEvents cob_Vehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents cob_vehpay As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmd_new As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents cmd_del As System.Windows.Forms.Button
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents dtptt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpft As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfd As System.Windows.Forms.DateTimePicker
    Friend WithEvents cob_drive As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_hrs As System.Windows.Forms.TextBox
    Friend WithEvents txt_status As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbvehicle = New System.Windows.Forms.GroupBox
        Me.txt_status = New System.Windows.Forms.TextBox
        Me.txt_hrs = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.label25 = New System.Windows.Forms.Label
        Me.cob_drive = New System.Windows.Forms.ComboBox
        Me.txt_veh_erate = New System.Windows.Forms.TextBox
        Me.Txt_veh_Bkms = New System.Windows.Forms.TextBox
        Me.txt_Veh_Brate = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_Veh_cmts = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.label13 = New System.Windows.Forms.Label
        Me.txt_VehBid = New System.Windows.Forms.TextBox
        Me.txt_vqty = New System.Windows.Forms.TextBox
        Me.cob_Vehicle = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.label9 = New System.Windows.Forms.Label
        Me.cob_vehpay = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtptt = New System.Windows.Forms.DateTimePicker
        Me.dtptd = New System.Windows.Forms.DateTimePicker
        Me.dtpft = New System.Windows.Forms.DateTimePicker
        Me.dtpfd = New System.Windows.Forms.DateTimePicker
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cmd_new = New System.Windows.Forms.Button
        Me.cmd_save = New System.Windows.Forms.Button
        Me.cmd_del = New System.Windows.Forms.Button
        Me.cmd_close = New System.Windows.Forms.Button
        Me.gbvehicle.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbvehicle
        '
        Me.gbvehicle.Controls.Add(Me.txt_status)
        Me.gbvehicle.Controls.Add(Me.txt_hrs)
        Me.gbvehicle.Controls.Add(Me.Label1)
        Me.gbvehicle.Controls.Add(Me.label25)
        Me.gbvehicle.Controls.Add(Me.cob_drive)
        Me.gbvehicle.Controls.Add(Me.txt_veh_erate)
        Me.gbvehicle.Controls.Add(Me.Txt_veh_Bkms)
        Me.gbvehicle.Controls.Add(Me.txt_Veh_Brate)
        Me.gbvehicle.Controls.Add(Me.Label24)
        Me.gbvehicle.Controls.Add(Me.Label23)
        Me.gbvehicle.Controls.Add(Me.Label16)
        Me.gbvehicle.Controls.Add(Me.txt_Veh_cmts)
        Me.gbvehicle.Controls.Add(Me.Label14)
        Me.gbvehicle.Controls.Add(Me.label13)
        Me.gbvehicle.Controls.Add(Me.txt_VehBid)
        Me.gbvehicle.Controls.Add(Me.txt_vqty)
        Me.gbvehicle.Controls.Add(Me.cob_Vehicle)
        Me.gbvehicle.Controls.Add(Me.Label12)
        Me.gbvehicle.Controls.Add(Me.Label11)
        Me.gbvehicle.Controls.Add(Me.Label10)
        Me.gbvehicle.Controls.Add(Me.label9)
        Me.gbvehicle.Controls.Add(Me.cob_vehpay)
        Me.gbvehicle.Controls.Add(Me.Label8)
        Me.gbvehicle.Controls.Add(Me.Label7)
        Me.gbvehicle.Controls.Add(Me.Label6)
        Me.gbvehicle.Controls.Add(Me.Label4)
        Me.gbvehicle.Controls.Add(Me.dtptt)
        Me.gbvehicle.Controls.Add(Me.dtptd)
        Me.gbvehicle.Controls.Add(Me.dtpft)
        Me.gbvehicle.Controls.Add(Me.dtpfd)
        Me.gbvehicle.Location = New System.Drawing.Point(0, 200)
        Me.gbvehicle.Name = "gbvehicle"
        Me.gbvehicle.Size = New System.Drawing.Size(632, 192)
        Me.gbvehicle.TabIndex = 31
        Me.gbvehicle.TabStop = False
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(527, 75)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.ReadOnly = True
        Me.txt_status.Size = New System.Drawing.Size(88, 20)
        Me.txt_status.TabIndex = 32
        Me.txt_status.Text = ""
        '
        'txt_hrs
        '
        Me.txt_hrs.Location = New System.Drawing.Point(400, 39)
        Me.txt_hrs.Name = "txt_hrs"
        Me.txt_hrs.ReadOnly = True
        Me.txt_hrs.Size = New System.Drawing.Size(48, 20)
        Me.txt_hrs.TabIndex = 31
        Me.txt_hrs.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Basic Hrs"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Location = New System.Drawing.Point(196, 114)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(31, 16)
        Me.label25.TabIndex = 29
        Me.label25.Text = "Drive"
        '
        'cob_drive
        '
        Me.cob_drive.Items.AddRange(New Object() {"Self", "Driver"})
        Me.cob_drive.Location = New System.Drawing.Point(232, 112)
        Me.cob_drive.Name = "cob_drive"
        Me.cob_drive.Size = New System.Drawing.Size(96, 21)
        Me.cob_drive.TabIndex = 28
        '
        'txt_veh_erate
        '
        Me.txt_veh_erate.Location = New System.Drawing.Point(401, 115)
        Me.txt_veh_erate.Name = "txt_veh_erate"
        Me.txt_veh_erate.ReadOnly = True
        Me.txt_veh_erate.Size = New System.Drawing.Size(48, 20)
        Me.txt_veh_erate.TabIndex = 27
        Me.txt_veh_erate.Text = ""
        '
        'Txt_veh_Bkms
        '
        Me.Txt_veh_Bkms.Location = New System.Drawing.Point(401, 78)
        Me.Txt_veh_Bkms.Name = "Txt_veh_Bkms"
        Me.Txt_veh_Bkms.ReadOnly = True
        Me.Txt_veh_Bkms.Size = New System.Drawing.Size(48, 20)
        Me.Txt_veh_Bkms.TabIndex = 26
        Me.Txt_veh_Bkms.Text = ""
        '
        'txt_Veh_Brate
        '
        Me.txt_Veh_Brate.Location = New System.Drawing.Point(232, 150)
        Me.txt_Veh_Brate.Name = "txt_Veh_Brate"
        Me.txt_Veh_Brate.ReadOnly = True
        Me.txt_Veh_Brate.Size = New System.Drawing.Size(96, 20)
        Me.txt_Veh_Brate.TabIndex = 25
        Me.txt_Veh_Brate.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(342, 116)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 16)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Extra Rate"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(342, 79)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 16)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Basic Kms"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(168, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Basic Rate"
        '
        'txt_Veh_cmts
        '
        Me.txt_Veh_cmts.Location = New System.Drawing.Point(402, 150)
        Me.txt_Veh_cmts.Name = "txt_Veh_cmts"
        Me.txt_Veh_cmts.Size = New System.Drawing.Size(216, 20)
        Me.txt_Veh_cmts.TabIndex = 19
        Me.txt_Veh_cmts.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(342, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Comments"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(467, 40)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(58, 16)
        Me.label13.TabIndex = 17
        Me.label13.Text = "Booking Id"
        '
        'txt_VehBid
        '
        Me.txt_VehBid.Location = New System.Drawing.Point(528, 38)
        Me.txt_VehBid.Name = "txt_VehBid"
        Me.txt_VehBid.ReadOnly = True
        Me.txt_VehBid.Size = New System.Drawing.Size(88, 20)
        Me.txt_VehBid.TabIndex = 16
        Me.txt_VehBid.Text = ""
        '
        'txt_vqty
        '
        Me.txt_vqty.Location = New System.Drawing.Point(233, 77)
        Me.txt_vqty.Name = "txt_vqty"
        Me.txt_vqty.Size = New System.Drawing.Size(93, 20)
        Me.txt_vqty.TabIndex = 15
        Me.txt_vqty.Text = ""
        '
        'cob_Vehicle
        '
        Me.cob_Vehicle.Location = New System.Drawing.Point(233, 37)
        Me.cob_Vehicle.Name = "cob_Vehicle"
        Me.cob_Vehicle.Size = New System.Drawing.Size(93, 21)
        Me.cob_Vehicle.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(188, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Vehicle"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(183, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(462, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "PaymentBy"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(485, 79)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(36, 16)
        Me.label9.TabIndex = 10
        Me.label9.Text = "Status"
        '
        'cob_vehpay
        '
        Me.cob_vehpay.Items.AddRange(New Object() {"Client", "We"})
        Me.cob_vehpay.Location = New System.Drawing.Point(527, 113)
        Me.cob_vehpay.Name = "cob_vehpay"
        Me.cob_vehpay.Size = New System.Drawing.Size(93, 21)
        Me.cob_vehpay.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ToTime"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FromDate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ToDate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "FromTime"
        '
        'dtptt
        '
        Me.dtptt.CustomFormat = "HH:mm"
        Me.dtptt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptt.Location = New System.Drawing.Point(76, 149)
        Me.dtptt.Name = "dtptt"
        Me.dtptt.ShowUpDown = True
        Me.dtptt.Size = New System.Drawing.Size(55, 20)
        Me.dtptt.TabIndex = 3
        '
        'dtptd
        '
        Me.dtptd.CustomFormat = "dd/MM/yyyy"
        Me.dtptd.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtptd.Location = New System.Drawing.Point(76, 110)
        Me.dtptd.Name = "dtptd"
        Me.dtptd.Size = New System.Drawing.Size(87, 20)
        Me.dtptd.TabIndex = 2
        '
        'dtpft
        '
        Me.dtpft.CustomFormat = "HH:mm"
        Me.dtpft.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpft.Location = New System.Drawing.Point(76, 74)
        Me.dtpft.Name = "dtpft"
        Me.dtpft.ShowUpDown = True
        Me.dtpft.Size = New System.Drawing.Size(55, 20)
        Me.dtpft.TabIndex = 1
        '
        'dtpfd
        '
        Me.dtpfd.CustomFormat = "dd/MM/yyyy"
        Me.dtpfd.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfd.Location = New System.Drawing.Point(75, 38)
        Me.dtpfd.Name = "dtpfd"
        Me.dtpfd.Size = New System.Drawing.Size(87, 20)
        Me.dtpfd.TabIndex = 0
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(632, 200)
        Me.DataGrid1.TabIndex = 32
        '
        'cmd_new
        '
        Me.cmd_new.Location = New System.Drawing.Point(72, 416)
        Me.cmd_new.Name = "cmd_new"
        Me.cmd_new.TabIndex = 33
        Me.cmd_new.Text = "New"
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(200, 416)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.TabIndex = 34
        Me.cmd_save.Text = "Save"
        '
        'cmd_del
        '
        Me.cmd_del.Location = New System.Drawing.Point(320, 416)
        Me.cmd_del.Name = "cmd_del"
        Me.cmd_del.TabIndex = 35
        Me.cmd_del.Text = "Delete"
        '
        'cmd_close
        '
        Me.cmd_close.Location = New System.Drawing.Point(448, 416)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.TabIndex = 36
        Me.cmd_close.Text = "Close"
        '
        'edit_cust_Veh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.cmd_del)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.cmd_new)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.gbvehicle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "edit_cust_Veh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edit_cust_Veh"
        Me.gbvehicle.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub edit_cust_Veh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Tables.Add(dt3)
        dt3.Columns.Add(dt3c0)
        dt3.Columns.Add(dt3c1)
        dt3.Columns.Add(dt3c2)
        dt3.Columns.Add(dt3c3)
        dt3.Columns.Add(dt3c4)
        dt3.Columns.Add(dt3c5)
        dt3.Columns.Add(dt3c6)
        dt3.Columns.Add(dt3c7)
        dt3.Columns.Add(dt3c8)
        dt3.Columns.Add(dt3c9)
        dt3.Columns.Add(dt3c10)
        dt3.Columns.Add(dt3c11)
        dt3.Columns.Add(dt3c12)
        datafill()
    End Sub

    Private Sub cmd_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub

    Private Sub cmd_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_new.Click
        recmode = Module1.EnuRecstatus.Recnew
        Openconnection()
        cmd = New OleDb.OleDbCommand("select VehType from Veh_Type", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_Vehicle.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub cob_drive_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_drive.SelectedIndexChanged
        Dim vtid As String
        Openconnection()
        cmd = New OleDb.OleDbCommand("select VehTypeid from Veh_Type where VehType='" & cob_Vehicle.Text & "'", con)
        vtid = cmd.ExecuteScalar
        cmd.Dispose()

        cmd = New OleDb.OleDbCommand("select Rack_Base_Price,Rack_Kilometers,Rack_Hours,Rack_Extra_KmRate from veh_Tariff where Drive='" & cob_drive.Text & "' and VehTypeid='" & vtid & "'", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            txt_Veh_Brate.Text = ord(0)
            Txt_veh_Bkms.Text = ord(1)
            txt_hrs.Text = ord(2)
            txt_veh_erate.Text = ord(3)
        End If
        ord.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        Dim vtid, tc As String
        Dim bp, i, VbookId, diff, am As Integer
        Openconnection()
        cmd = New OleDb.OleDbCommand("select VehTypeid from Veh_Type where VehType='" & cob_Vehicle.Text & "'", con)
        vtid = cmd.ExecuteScalar
        cmd.Dispose()
        cmd = New OleDb.OleDbCommand("select Rack_Base_Price,Tariffcode from veh_Tariff where Drive='" & cob_drive.Text & "' and VehTypeid='" & vtid & "'", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            bp = ord(0)
            tc = ord(1)
        End If
        ord.Close()
        cmd.Dispose()
        diff = DateDiff(DateInterval.Day, dtpfd.Value, dtptd.Value)
        If diff = 0 Then
            diff = 1
        End If
        am = bp * diff



        If recmode = Module1.EnuRecstatus.Recnew Then
            If txt_status.Text = "Quotation" Then
                cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Vehicle", con)
                i = cmd.ExecuteScalar
                cmd.Dispose()
                If i >= 1 Then
                    cmd = New OleDb.OleDbCommand("select max(VBookId) from  Enq_Cust_Vehicle", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        VbookId = ord(0)
                    End If
                    cmd.Dispose()
                    ord.Close()
                    VbookId = VbookId + 1
                Else
                    VbookId = 1
                End If

                cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Vehicle values(" & VbookId & ",'" & cuid & "','" & bid & "','" & tc & "','" & dtpfd.Text & "','" & dtpft.Text & "','" & dtptd.Text & "','" & dtptt.Text & "'," & diff & "," & Val(txt_vqty.Text) & "," & am & ",'N','" & cob_vehpay.Text & "','" & txt_Veh_cmts.Text & "','N','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','',)", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If
            If txt_status.Text = "Confirm" Then
                cmd = New OleDb.OleDbCommand("select count(*) from Cust_Vehicle", con)
                i = cmd.ExecuteScalar
                cmd.Dispose()
                If i >= 1 Then
                    cmd = New OleDb.OleDbCommand("select max(VBookId) from  Cust_Vehicle", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        VbookId = ord(0)
                    End If
                    cmd.Dispose()
                    ord.Close()
                    VbookId = VbookId + 1
                Else
                    VbookId = 1
                End If
                cmd = New OleDb.OleDbCommand("insert into Cust_Vehicle values(" & VbookId & ",'" & cuid & "','" & bid & "','" & tc & "','" & dtpfd.Text & "','" & dtpft.Text & "','" & dtptd.Text & "','" & dtptt.Text & "'," & diff & "," & Val(txt_vqty.Text) & "," & am & ",'N','" & cob_vehpay.Text & "','" & txt_Veh_cmts.Text & "','N','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','',)", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If

            dr = dt3.NewRow
            dr(0) = VbookId
            dr(1) = FormatDateTime(dtpfd.Value, DateFormat.ShortDate)
            dr(2) = Format(dtpft.Text, "HH:MM")
            dr(3) = FormatDateTime(dtptd.Value, DateFormat.ShortDate)
            dr(4) = Format(dtptt.Text, "HH:MM")
            dr(5) = cob_Vehicle.Text
            dr(6) = txt_vqty.Text
            dr(7) = txt_Veh_Brate.Text
            dr(8) = Txt_veh_Bkms.Text
            dr(9) = txt_hrs.Text
            dr(10) = txt_veh_erate.Text
            dr(11) = cob_vehpay.Text
            dr(12) = txt_Veh_cmts.Text
            dt3.Rows.Add(dr)
            DataGrid1.DataSource = ds.Tables("veh")
            MsgSav()
        End If


        If recmode = Module1.EnuRecstatus.Recedit Then

            Openconnection()
            If txt_status.Text = "Quotation" Then
                cmd = New OleDb.OleDbCommand("update Enq_Cust_Vehicle set Tariffcode='" & tc & "',FromDt='" & dtpfd.Text & "',FromTime='" & dtpft.Text & "',ToDt='" & dtptd.Text & "',ToTime='" & dtptt.Text & "',Days=" & diff & ",NoOfVeh=" & Val(txt_vqty.Text) & ",Amount=" & am & ",ActFlag='N',PaymentBy='" & cob_vehpay.Text & "',Comments='" & txt_Veh_cmts.Text & "',Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',DutySlipFlag ='N' where VBookId=" & Val(DataGrid1.Item(crid, 0)) & " ", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If
            If txt_status.Text = "Confirm" Then
                cmd = New OleDb.OleDbCommand("update Cust_Vehicle set Tariffcode='" & tc & "',FromDt='" & dtpfd.Text & "',FromTime='" & dtpft.Text & "',ToDt='" & dtptd.Text & "',ToTime='" & dtptt.Text & "',Days=" & diff & ",NoOfVeh=" & Val(txt_vqty.Text) & ",Amount=" & am & ",ActFlag='N',PaymentBy='" & cob_vehpay.Text & "',Comments='" & txt_Veh_cmts.Text & "',Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',DutySlipFlag ='N' where VBookId=" & Val(DataGrid1.Item(crid, 0)) & " ", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If

            DataGrid1.Item(crid, 0) = vbid(crid)
            DataGrid1.Item(crid, 1) = FormatDateTime(dtpfd.Value, DateFormat.ShortDate)
            DataGrid1.Item(crid, 2) = dtpft.Text
            DataGrid1.Item(crid, 3) = FormatDateTime(dtptd.Value, DateFormat.ShortDate)
            DataGrid1.Item(crid, 4) = dtptt.Text
            DataGrid1.Item(crid, 5) = cob_Vehicle.Text
            DataGrid1.Item(crid, 6) = txt_vqty.Text
            DataGrid1.Item(crid, 7) = txt_Veh_Brate.Text
            DataGrid1.Item(crid, 8) = Txt_veh_Bkms.Text
            DataGrid1.Item(crid, 9) = txt_hrs.Text
            DataGrid1.Item(crid, 10) = txt_veh_erate.Text
            DataGrid1.Item(crid, 11) = cob_vehpay.Text
            DataGrid1.Item(crid, 12) = txt_Veh_cmts.Text
            ds.Tables("veh").AcceptChanges()
            MsgSav()
        End If
        clearproc()
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        crid = i
        Openconnection()
        cmd = New OleDb.OleDbCommand("select VehType from Veh_Type", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_Vehicle.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
        cmd = New OleDb.OleDbCommand("select v.drive from Enq_Cust_Vehicle e,Veh_Tariff v where e.Tariffcode=v.Tariffcode and e.VBookId =" & vbid(i) & "", con)
        cob_drive.Text = cmd.ExecuteScalar
        cmd.Dispose()
        con.Close()


        dtpfd.Text = DataGrid1.Item(i, 1)
        dtpft.Text = DataGrid1.Item(i, 2)
        dtptd.Text = DataGrid1.Item(i, 3)
        dtptt.Text = DataGrid1.Item(i, 4)
        cob_Vehicle.Text = DataGrid1.Item(i, 5)
        txt_vqty.Text = DataGrid1.Item(i, 6)
        txt_Veh_Brate.Text = DataGrid1.Item(i, 7)
        Txt_veh_Bkms.Text = DataGrid1.Item(i, 8)
        txt_hrs.Text = DataGrid1.Item(i, 9)
        txt_veh_erate.Text = DataGrid1.Item(i, 10)
        cob_vehpay.Text = DataGrid1.Item(i, 11)
        txt_Veh_cmts.Text = DataGrid1.Item(i, 12)
        recmode = Module1.EnuRecstatus.Recedit
    End Sub
    Public Sub datafill()
        bid = bookid
        txt_VehBid.Text = bid
        Dim str As String
        str = Mid(bid, 1, 1)
        If edit_item = "vehicle" Then
            Dim tc(20), pay(20), cmts(20), veh(20) As String
            Dim fd(20), td(20), ft(20), tt(20), da1, da2, sda, eda As Date
            Dim nov(20), i, x, vtid(20), bp(20), kms(20), hrs(20), xkms(20) As Integer
            Openconnection()
            If str = "E" Then
                txt_status.Text = "Quotation"
                cmd = New OleDb.OleDbCommand("select CustId,Stdate,EndDate from Enq_Booking_Itinary where BookingId ='" & bid & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    cuid = ord(0)
                    sda = ord(1)
                    eda = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
                sda = FormatDateTime(sda, DateFormat.ShortDate)
                eda = FormatDateTime(eda, DateFormat.ShortDate)
                da1 = DateAdd(DateInterval.Day, -1, sda)
                da1 = FormatDateTime(da1, DateFormat.ShortDate)
                da2 = DateAdd(DateInterval.Day, 1, eda)
                da2 = FormatDateTime(da2, DateFormat.ShortDate)
                dtpfd.MinDate = da1
                dtpfd.MaxDate = da2
                dtptd.MinDate = da1
                dtptd.MaxDate = da2
                cmd = New OleDb.OleDbCommand("select VBookId from Enq_Cust_Vehicle where bookingId='" & bid & "' and FromDt between #" & da1 & "# and #" & da2 & "# ", con)
                ord = cmd.ExecuteReader
                i = 0
                While ord.Read
                    vbid(i) = ord(0)
                    i = i + 1
                End While
                ord.Close()
                cmd.Dispose()
                Try
                    For x = 0 To i - 1
                        cmd = New OleDb.OleDbCommand("select Tariffcode,FromDt,FromTime,ToDt,ToTime,NoOfVeh,PaymentBy,Comments from Enq_Cust_Vehicle  where VBookId=" & vbid(x) & "", con)
                        ord = cmd.ExecuteReader
                        If ord.Read Then
                            tc(x) = ord(0)
                            fd(x) = FormatDateTime(ord(1), DateFormat.ShortDate)
                            ft(x) = ord(2)
                            td(x) = FormatDateTime(ord(3), DateFormat.ShortDate)
                            tt(x) = ord(4)
                            nov(x) = ord(5)
                            pay(x) = ord(6)
                            cmts(x) = ord(7)
                        End If

                        ord.Close()
                        cmd.Dispose()
                    Next
                Catch es As Exception
                    MsgBox(es.Message)
                End Try
                For x = 0 To i - 1
                    cmd = New OleDb.OleDbCommand("select VehTypeid,Rack_Base_Price,Rack_Kilometers,Rack_Hours,Rack_Extra_KmRate from Veh_Tariff where Tariffcode='" & tc(x) & "'", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        vtid(x) = ord(0)
                        bp(x) = ord(1)
                        kms(x) = ord(2)
                        hrs(x) = ord(3)
                        xkms(x) = ord(4)
                    End If
                    ord.Close()
                    cmd.Dispose()
                Next

                For x = 0 To i - 1
                    cmd = New OleDb.OleDbCommand("select VehType from Veh_Type where VehTypeid='" & vtid(x) & "'", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        veh(x) = ord(0)
                    End If
                    ord.Close()
                    cmd.Dispose()
                Next
            End If

            If str = "C" Then
                txt_status.Text = "Confirm"
                cmd = New OleDb.OleDbCommand("select CustId,Stdate,EndDate from Booking_Itinary where BookingId ='" & bid & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    cuid = ord(0)
                    sda = ord(1)
                    eda = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
                sda = FormatDateTime(sda, DateFormat.ShortDate)
                eda = FormatDateTime(eda, DateFormat.ShortDate)
                da1 = DateAdd(DateInterval.Day, -1, sda)
                da1 = FormatDateTime(da1, DateFormat.ShortDate)
                da2 = DateAdd(DateInterval.Day, 1, eda)
                da2 = FormatDateTime(da2, DateFormat.ShortDate)

                cmd = New OleDb.OleDbCommand("select VBookId from Cust_Vehicle where bookingId='" & bid & "' and FromDt between #" & da1 & "# and #" & da2 & "# ", con)
                ord = cmd.ExecuteReader
                i = 0
                While ord.Read
                    vbid(i) = ord(0)
                    i = i + 1
                End While
                ord.Close()
                cmd.Dispose()

                For x = 0 To i - 1
                    cmd = New OleDb.OleDbCommand("select Tariffcode,FromDt,FromTime,ToDt,ToTime,NoOfVeh,PaymentBy,Comments from Cust_Vehicle  where VBookId=" & vbid(x) & "", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        tc(x) = ord(0)
                        fd(x) = ord(1)
                        ft(x) = ord(2)
                        td(x) = ord(3)
                        tt(x) = ord(4)
                        nov(x) = ord(5)
                        pay(x) = ord(6)
                        cmts(x) = ord(7)
                    End If
                    ord.Close()
                    cmd.Dispose()
                Next

                For x = 0 To i - 1
                    cmd = New OleDb.OleDbCommand("select VehTypeid,Rack_Base_Price,Rack_Kilometers,Rack_Hours,Rack_Extra_KmRate from Veh_Tariff where Tariffcode='" & tc(x) & "'", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        vtid(x) = ord(0)
                        bp(x) = ord(1)
                        kms(x) = ord(2)
                        hrs(x) = ord(3)
                        xkms(x) = ord(4)
                    End If
                    ord.Close()
                    cmd.Dispose()
                Next

                For x = 0 To i - 1
                    cmd = New OleDb.OleDbCommand("select VehType from Veh_Type where VehTypeid='" & vtid(x) & "'", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        veh(x) = ord(0)
                    End If
                    ord.Close()
                    cmd.Dispose()
                Next

            End If

            For x = 0 To i - 1
                dr = dt3.NewRow
                dr(0) = vbid(x)
                dr(1) = FormatDateTime(fd(x), DateFormat.ShortDate)
                dr(2) = Format(ft(x), "HH:MM")
                dr(3) = FormatDateTime(td(x), DateFormat.ShortDate)
                dr(4) = Format(tt(x), "HH:MM")
                dr(5) = veh(x)
                dr(6) = nov(x)
                dr(7) = bp(x)
                dr(8) = kms(x)
                dr(9) = hrs(x)
                dr(10) = xkms(x)
                dr(11) = pay(x)
                dr(12) = cmts(x)
                dt3.Rows.Add(dr)
            Next
            DataGrid1.DataSource = ds.Tables("veh")

        End If
    End Sub
    Private Sub cob_Vehicle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_Vehicle.SelectedIndexChanged
        If recmode = Module1.EnuRecstatus.Recedit Then
            Dim vtid As String
            Openconnection()
            cmd = New OleDb.OleDbCommand("select VehTypeid from Veh_Type where VehType='" & cob_Vehicle.Text & "'", con)
            vtid = cmd.ExecuteScalar
            cmd.Dispose()

            cmd = New OleDb.OleDbCommand("select Rack_Base_Price,Rack_Kilometers,Rack_Hours,Rack_Extra_KmRate from veh_Tariff where Drive='" & cob_drive.Text & "' and VehTypeid='" & vtid & "'", con)
            ord = cmd.ExecuteReader
            If ord.Read Then
                txt_Veh_Brate.Text = ord(0)
                Txt_veh_Bkms.Text = ord(1)
                txt_hrs.Text = ord(2)
                txt_veh_erate.Text = ord(3)
            End If
            ord.Close()
            cmd.Dispose()
            con.Close()
        End If
    End Sub

    Private Sub cmd_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_del.Click
        Dim yesno As String
        yesno = MsgDelAlert()
        If yesno = vbYes Then
            If txt_status.Text = "Quotation" Then
                Openconnection()
                cmd = New OleDb.OleDbCommand("delete from Enq_Cust_Vehicle where VbookId=" & vbid(crid) & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                MsgDel()
            End If
            If txt_status.Text = "Confirm" Then
                Openconnection()
                cmd = New OleDb.OleDbCommand("delete from Cust_Vehicle where VbookId=" & vbid(crid) & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                MsgDel()
            End If
        Else
            Exit Sub
        End If
        ds.Tables("veh").Rows(crid).Delete()
        DataGrid1.DataSource = ds.Tables("veh")
        clearproc()
    End Sub
    Public Sub clearproc()
        Dim x As Object
        For Each x In Me.gbvehicle.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
            If TypeOf (x) Is ComboBox Then
                x.text = ""
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.Refresh()
            End If
        Next
        txt_VehBid.Text = bid
        Dim Str As String = Mid(bid, 1, 1)
        If Str = "E" Then
            txt_status.Text = "Quotation"
        ElseIf Str = "C" Then
            txt_status.Text = "Confirm"
        End If
    End Sub
End Class

