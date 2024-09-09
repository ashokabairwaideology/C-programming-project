'written by P.R.Sudhakar Reddy
'Version 1
'date: 22 Aug 2006

Public Class edit_cust_Activ
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents gbactivity As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents cmd_del As System.Windows.Forms.Button
    Friend WithEvents cmd_new As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_hrs_days As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_unit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cob_activity As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_bid As System.Windows.Forms.TextBox
    Friend WithEvents txt_status As System.Windows.Forms.TextBox
    Friend WithEvents txt_cmts As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_rtype As System.Windows.Forms.TextBox
    Friend WithEvents dtp_act As System.Windows.Forms.DateTimePicker
    Friend WithEvents cob_Payment As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Arate As System.Windows.Forms.TextBox
    Friend WithEvents txt_NAdults As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_jrate As System.Windows.Forms.TextBox
    Friend WithEvents txt_crate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_NJuniors As System.Windows.Forms.TextBox
    Friend WithEvents txt_NChilds As System.Windows.Forms.TextBox
    Friend WithEvents txt_location As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.gbactivity = New System.Windows.Forms.GroupBox
        Me.txt_NChilds = New System.Windows.Forms.TextBox
        Me.txt_NJuniors = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_crate = New System.Windows.Forms.TextBox
        Me.txt_jrate = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_rtype = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_cmts = New System.Windows.Forms.TextBox
        Me.txt_status = New System.Windows.Forms.TextBox
        Me.txt_bid = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cob_Payment = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Arate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_unit = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_hrs_days = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_NAdults = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_act = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cob_activity = New System.Windows.Forms.ComboBox
        Me.cmd_close = New System.Windows.Forms.Button
        Me.cmd_del = New System.Windows.Forms.Button
        Me.cmd_new = New System.Windows.Forms.Button
        Me.cmd_save = New System.Windows.Forms.Button
        Me.txt_location = New System.Windows.Forms.TextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbactivity.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(4, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(596, 216)
        Me.DataGrid1.TabIndex = 0
        '
        'gbactivity
        '
        Me.gbactivity.Controls.Add(Me.txt_location)
        Me.gbactivity.Controls.Add(Me.txt_NChilds)
        Me.gbactivity.Controls.Add(Me.txt_NJuniors)
        Me.gbactivity.Controls.Add(Me.Label16)
        Me.gbactivity.Controls.Add(Me.Label15)
        Me.gbactivity.Controls.Add(Me.txt_crate)
        Me.gbactivity.Controls.Add(Me.txt_jrate)
        Me.gbactivity.Controls.Add(Me.Label14)
        Me.gbactivity.Controls.Add(Me.Label13)
        Me.gbactivity.Controls.Add(Me.Label12)
        Me.gbactivity.Controls.Add(Me.txt_rtype)
        Me.gbactivity.Controls.Add(Me.Label11)
        Me.gbactivity.Controls.Add(Me.txt_cmts)
        Me.gbactivity.Controls.Add(Me.txt_status)
        Me.gbactivity.Controls.Add(Me.txt_bid)
        Me.gbactivity.Controls.Add(Me.Label10)
        Me.gbactivity.Controls.Add(Me.Label9)
        Me.gbactivity.Controls.Add(Me.Label8)
        Me.gbactivity.Controls.Add(Me.cob_Payment)
        Me.gbactivity.Controls.Add(Me.Label7)
        Me.gbactivity.Controls.Add(Me.txt_Arate)
        Me.gbactivity.Controls.Add(Me.Label6)
        Me.gbactivity.Controls.Add(Me.txt_unit)
        Me.gbactivity.Controls.Add(Me.Label5)
        Me.gbactivity.Controls.Add(Me.txt_hrs_days)
        Me.gbactivity.Controls.Add(Me.Label4)
        Me.gbactivity.Controls.Add(Me.txt_NAdults)
        Me.gbactivity.Controls.Add(Me.Label3)
        Me.gbactivity.Controls.Add(Me.dtp_act)
        Me.gbactivity.Controls.Add(Me.Label2)
        Me.gbactivity.Controls.Add(Me.Label1)
        Me.gbactivity.Controls.Add(Me.cob_activity)
        Me.gbactivity.Location = New System.Drawing.Point(8, 216)
        Me.gbactivity.Name = "gbactivity"
        Me.gbactivity.Size = New System.Drawing.Size(600, 232)
        Me.gbactivity.TabIndex = 1
        Me.gbactivity.TabStop = False
        '
        'txt_NChilds
        '
        Me.txt_NChilds.Location = New System.Drawing.Point(271, 113)
        Me.txt_NChilds.Name = "txt_NChilds"
        Me.txt_NChilds.Size = New System.Drawing.Size(97, 20)
        Me.txt_NChilds.TabIndex = 31
        Me.txt_NChilds.Text = ""
        '
        'txt_NJuniors
        '
        Me.txt_NJuniors.Location = New System.Drawing.Point(272, 84)
        Me.txt_NJuniors.Name = "txt_NJuniors"
        Me.txt_NJuniors.Size = New System.Drawing.Size(97, 20)
        Me.txt_NJuniors.TabIndex = 30
        Me.txt_NJuniors.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(200, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "No Of Childs"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(195, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 16)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "No Of Juniors"
        '
        'txt_crate
        '
        Me.txt_crate.Location = New System.Drawing.Point(78, 201)
        Me.txt_crate.Name = "txt_crate"
        Me.txt_crate.ReadOnly = True
        Me.txt_crate.Size = New System.Drawing.Size(97, 20)
        Me.txt_crate.TabIndex = 27
        Me.txt_crate.Text = ""
        '
        'txt_jrate
        '
        Me.txt_jrate.Location = New System.Drawing.Point(78, 170)
        Me.txt_jrate.Name = "txt_jrate"
        Me.txt_jrate.ReadOnly = True
        Me.txt_jrate.Size = New System.Drawing.Size(95, 20)
        Me.txt_jrate.TabIndex = 26
        Me.txt_jrate.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Child Rate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Juniors Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Location"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_rtype
        '
        Me.txt_rtype.Location = New System.Drawing.Point(78, 112)
        Me.txt_rtype.Name = "txt_rtype"
        Me.txt_rtype.ReadOnly = True
        Me.txt_rtype.Size = New System.Drawing.Size(94, 20)
        Me.txt_rtype.TabIndex = 21
        Me.txt_rtype.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Rate Type"
        '
        'txt_cmts
        '
        Me.txt_cmts.Location = New System.Drawing.Point(272, 176)
        Me.txt_cmts.MaxLength = 50
        Me.txt_cmts.Multiline = True
        Me.txt_cmts.Name = "txt_cmts"
        Me.txt_cmts.Size = New System.Drawing.Size(304, 48)
        Me.txt_cmts.TabIndex = 19
        Me.txt_cmts.Text = ""
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(483, 59)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.ReadOnly = True
        Me.txt_status.Size = New System.Drawing.Size(88, 20)
        Me.txt_status.TabIndex = 18
        Me.txt_status.Text = ""
        '
        'txt_bid
        '
        Me.txt_bid.Location = New System.Drawing.Point(482, 27)
        Me.txt_bid.Name = "txt_bid"
        Me.txt_bid.ReadOnly = True
        Me.txt_bid.Size = New System.Drawing.Size(89, 20)
        Me.txt_bid.TabIndex = 17
        Me.txt_bid.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(209, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Comments"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(438, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Booking Id"
        '
        'cob_Payment
        '
        Me.cob_Payment.Items.AddRange(New Object() {"Client", "we"})
        Me.cob_Payment.Location = New System.Drawing.Point(482, 93)
        Me.cob_Payment.Name = "cob_Payment"
        Me.cob_Payment.Size = New System.Drawing.Size(91, 21)
        Me.cob_Payment.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Payment By"
        '
        'txt_Arate
        '
        Me.txt_Arate.Location = New System.Drawing.Point(78, 141)
        Me.txt_Arate.Name = "txt_Arate"
        Me.txt_Arate.ReadOnly = True
        Me.txt_Arate.Size = New System.Drawing.Size(95, 20)
        Me.txt_Arate.TabIndex = 11
        Me.txt_Arate.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Adult Rate"
        '
        'txt_unit
        '
        Me.txt_unit.Location = New System.Drawing.Point(271, 27)
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.ReadOnly = True
        Me.txt_unit.Size = New System.Drawing.Size(97, 20)
        Me.txt_unit.TabIndex = 9
        Me.txt_unit.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Unit"
        '
        'txt_hrs_days
        '
        Me.txt_hrs_days.Location = New System.Drawing.Point(270, 143)
        Me.txt_hrs_days.Name = "txt_hrs_days"
        Me.txt_hrs_days.Size = New System.Drawing.Size(97, 20)
        Me.txt_hrs_days.TabIndex = 7
        Me.txt_hrs_days.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(224, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hours"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NAdults
        '
        Me.txt_NAdults.Location = New System.Drawing.Point(272, 56)
        Me.txt_NAdults.Name = "txt_NAdults"
        Me.txt_NAdults.Size = New System.Drawing.Size(95, 20)
        Me.txt_NAdults.TabIndex = 5
        Me.txt_NAdults.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No of Adults"
        '
        'dtp_act
        '
        Me.dtp_act.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_act.Location = New System.Drawing.Point(79, 52)
        Me.dtp_act.Name = "dtp_act"
        Me.dtp_act.Size = New System.Drawing.Size(96, 20)
        Me.dtp_act.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = " Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Activity"
        '
        'cob_activity
        '
        Me.cob_activity.Location = New System.Drawing.Point(80, 21)
        Me.cob_activity.Name = "cob_activity"
        Me.cob_activity.Size = New System.Drawing.Size(96, 21)
        Me.cob_activity.Sorted = True
        Me.cob_activity.TabIndex = 0
        '
        'cmd_close
        '
        Me.cmd_close.Location = New System.Drawing.Point(445, 463)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.TabIndex = 4
        Me.cmd_close.Text = "Close"
        '
        'cmd_del
        '
        Me.cmd_del.Location = New System.Drawing.Point(325, 463)
        Me.cmd_del.Name = "cmd_del"
        Me.cmd_del.TabIndex = 3
        Me.cmd_del.Text = "Delete"
        '
        'cmd_new
        '
        Me.cmd_new.Location = New System.Drawing.Point(85, 463)
        Me.cmd_new.Name = "cmd_new"
        Me.cmd_new.TabIndex = 0
        Me.cmd_new.Text = "New"
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(210, 463)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.TabIndex = 2
        Me.cmd_save.Text = "Save"
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(79, 81)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.ReadOnly = True
        Me.txt_location.Size = New System.Drawing.Size(94, 20)
        Me.txt_location.TabIndex = 32
        Me.txt_location.Text = ""
        '
        'edit_cust_Activ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(602, 511)
        Me.Controls.Add(Me.gbactivity)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.cmd_del)
        Me.Controls.Add(Me.cmd_new)
        Me.Controls.Add(Me.cmd_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "edit_cust_Activ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edit_cust_Activ"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbactivity.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim bid, cuid As String
    Dim cmd As OleDb.OleDbCommand
    Dim ord As OleDb.OleDbDataReader
    Dim ds As New DataSet
    Dim recmode As Module1.EnuRecstatus
    Dim dr As DataRow
    Dim abid(20), crid As Integer
    Dim str As String
    Dim dt5 As New DataTable("Act")
    Dim dt5c0 As New DataColumn("ABookId")
    Dim dt5c1 As New DataColumn("Activity")
    Dim dt5c2 As New DataColumn("date")
    Dim dt5c20 As New DataColumn("Location")
    Dim dt5c21 As New DataColumn("Rate Type")
    Dim dt5c3 As New DataColumn("Hrs/Days")
    Dim dt5c4 As New DataColumn("Unit")
    Dim dt5c5 As New DataColumn("No of Adults")
    Dim dt5c50 As New DataColumn("No of Jrs")
    Dim dt5c51 As New DataColumn("No Of Childs")
    Dim dt5c6 As New DataColumn("Amount")
    Dim dt5c7 As New DataColumn("PaymentBy")
    Dim dt5c8 As New DataColumn("Comments")

    Private Sub edit_cust_Activ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim abid(20), qty(20), unit(20), amt(20), ar(20), jr(20), cr(20), i, x, ad(20), ju(20), child(20) As Integer
        Dim actid(20), Act(20), hrday(20), pay(20), cmts(20), rtype(20), loc(20) As String
        Dim da(20), sda, eda As Date

        recmode = Module1.EnuRecstatus.Recnew

        ds.Tables.Add(dt5)
        dt5.Columns.Add(dt5c0)
        dt5.Columns.Add(dt5c1)
        dt5.Columns.Add(dt5c2)
        dt5.Columns.Add(dt5c20)
        dt5.Columns.Add(dt5c21)
        dt5.Columns.Add(dt5c3)
        dt5.Columns.Add(dt5c4)
        dt5.Columns.Add(dt5c5)
        dt5.Columns.Add(dt5c50)
        dt5.Columns.Add(dt5c51)
        dt5.Columns.Add(dt5c6)
        dt5.Columns.Add(dt5c7)
        dt5.Columns.Add(dt5c8)
        txt_bid.Text = bookid
        bid = bookid

        str = Mid(bid, 1, 1)

        If str = "E" Then
            txt_status.Text = "Quotation"
            Openconnection()
            cmd = New OleDb.OleDbCommand("select CustId,StDate,Enddate from Enq_Booking_Itinary where BookingId ='" & bid & "'", con)
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

            cmd = New OleDb.OleDbCommand("select ABookId from Enq_Cust_Activity where bookingId='" & bid & "' and Acti_Date between #" & sda & "# and #" & eda & "# ", con)
            ord = cmd.ExecuteReader
            i = 0
            While ord.Read
                abid(i) = ord(0)
                i = i + 1
            End While
            ord.Close()
            cmd.Dispose()
            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select Activ_Id,Noof_Pax,Acti_date,Hrs_Days,Unit,adults,junior,children,PaymentBy,Comments from Enq_Cust_Activity  where ABookId=" & abid(x) & "", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    actid(x) = ord(0)
                    qty(x) = ord(1)
                    da(x) = FormatDateTime(ord(2), DateFormat.ShortDate)
                    hrday(x) = ord(3)
                    unit(x) = ord(4)
                    ad(x) = ord(5)
                    ju(x) = ord(6)
                    child(x) = ord(7)
                    pay(x) = ord(8)
                    cmts(x) = ord(9)
                End If
                ord.Close()
                cmd.Dispose()
            Next

            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select Activity,Rate_Type,locationID from Activity where Activ_ID='" & actid(x) & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    Act(x) = ord(0)
                    rtype(x) = ord(1)
                    loc(x) = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
            Next
            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select RackRate_Adult,RackRate_Juni,RacRate_Child from Activity where Activ_ID='" & actid(x) & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    ar(x) = ord(0)
                    jr(x) = ord(1)
                    cr(x) = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
            Next

            For x = 0 To i - 1
                amt(x) = (ar(0) * ad(x)) + (jr(x) + ju(x)) + (cr(x) * child(x))
            Next

            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select Location from LocationMaster where LocationID ='" & loc(x) & "'", con)
                loc(x) = cmd.ExecuteScalar
                cmd.Dispose()
            Next
            con.Close()
            For x = 0 To i - 1
                dr = dt5.NewRow
                dr(0) = abid(x)
                dr(1) = Act(x)
                dr(2) = FormatDateTime(da(x), DateFormat.ShortDate)
                dr(3) = loc(x)
                dr(4) = rtype(x)
                dr(5) = hrday(x)
                dr(6) = unit(x)
                dr(7) = qty(x)
                dr(8) = ad(x)
                dr(9) = ju(x)
                dr(10) = child(x)
                dr(11) = amt(x)
                dr(12) = pay(x)
                dr(13) = cmts(x)
                dt5.Rows.Add(dr)
            Next
            DataGrid1.DataSource = ds.Tables("Act")
        End If

        If str = "C" Then
            txt_status.Text = "Confirm"
            Openconnection()
            cmd = New OleDb.OleDbCommand("select CustId,StDate,Enddate from Booking_Itinary where BookingId ='" & bid & "'", con)
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

            cmd = New OleDb.OleDbCommand("select ABookId from Cust_Activity where bookingId='" & bid & "' and Acti_Date between #" & sda & "# and #" & eda & "# ", con)
            ord = cmd.ExecuteReader
            i = 0
            While ord.Read
                abid(i) = ord(0)
                i = i + 1
            End While
            ord.Close()
            cmd.Dispose()
            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select Activ_Id,Noof_Pax,Acti_date,Hrs_Days,Unit,adults,junior,children,PaymentBy,Comments from Cust_Activity  where ABookId=" & abid(x) & "", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    actid(x) = ord(0)
                    qty(x) = ord(1)
                    da(x) = FormatDateTime(ord(2), DateFormat.ShortDate)
                    hrday(x) = ord(3)
                    unit(x) = ord(4)
                    ad(x) = ord(5)
                    ju(x) = ord(6)
                    child(x) = ord(7)
                    pay(x) = ord(8)
                    cmts(x) = ord(9)
                End If
                ord.Close()
                cmd.Dispose()
            Next

            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select Activity,Rate_Type,locationID from Activity where Activ_ID='" & actid(x) & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    Act(x) = ord(0)
                    rtype(x) = ord(1)
                    loc(x) = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
            Next
            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select RackRate_Adult,RackRate_Juni,RacRate_Child from Activity where Activ_ID='" & actid(x) & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    ar(x) = ord(0)
                    jr(x) = ord(1)
                    cr(x) = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
            Next

            For x = 0 To i - 1
                amt(x) = (ar(0) * ad(x)) + (jr(x) + ju(x)) + (cr(x) * child(x))
            Next

            For x = 0 To i - 1
                cmd = New OleDb.OleDbCommand("select Location from LocationMaster where LocationID ='" & loc(x) & "'", con)
                loc(x) = cmd.ExecuteScalar
                cmd.Dispose()
            Next
            con.Close()
            For x = 0 To i - 1
                dr = dt5.NewRow
                dr(0) = abid(x)
                dr(1) = Act(x)
                dr(2) = FormatDateTime(da(x), DateFormat.ShortDate)
                dr(3) = loc(x)
                dr(4) = rtype(x)
                dr(5) = hrday(x)
                dr(6) = unit(x)
                dr(7) = ad(x)
                dr(8) = ju(x)
                dr(9) = child(x)
                dr(10) = amt(x)
                dr(11) = pay(x)
                dr(12) = cmts(x)
                dt5.Rows.Add(dr)
            Next
            DataGrid1.DataSource = ds.Tables("Act")
        End If
    End Sub

    Private Sub cmd_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_new.Click
        Openconnection()
        cmd = New OleDb.OleDbCommand("select ActiV_ID,Activity from Activity", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_activity.Items.Add(ord(0) + "--" + ord(1))
        End While
        ord.Close()
        cmd.Dispose()
        con.Close()
        recmode = Module1.EnuRecstatus.Recnew
    End Sub

    Private Sub cob_activity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_activity.SelectedIndexChanged
        Dim temp As String
        Dim i As Integer
        temp = cob_activity.Text
        i = InStr(temp, "-")
        temp = Mid(temp, 1, i - 1)
        Openconnection()
        cmd = New OleDb.OleDbCommand("select l.location,a.Rate_Type,a.Unit,a.RackRate_Adult,a.RackRate_juni,RackRate_Child from Activity a,Locationmaster l where a.Activ_ID ='" & temp & "' and l.LocationID = a.LocationID", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            txt_location.Text = ord(0)
            txt_rtype.Text = ord(1)
            txt_unit.Text = ord(2)
            txt_Arate.Text = ord(3)
            txt_jrate.Text = ord(4)
            txt_crate.Text = ord(5)
        End If
        ord.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        Dim i, AbookId, total, nopersons, nu As Integer
        Dim temp_aid, nu1, temp_act As String
        i = InStr(cob_activity.Text, "-")
        temp_aid = Mid(cob_activity.Text, 1, i - 1)
        temp_act = Mid(cob_activity.Text, i + 2)


        nu = Val(txt_hrs_days.Text) / Val(txt_unit.Text)
        nu1 = CStr(nu)
        i = InStr(nu1, ".")
        If i = 0 Then
            nu = CInt(nu1)
        Else
            nu = CInt(nu1)
            nu = Int(nu) + 1
        End If
        nopersons = Val(txt_NAdults.Text) + Val(txt_NJuniors.Text) + Val(txt_NChilds.Text)
        total = (Val(txt_NAdults.Text) * Val(txt_Arate.Text) * nu) + (Val(txt_NJuniors.Text) * Val(txt_jrate.Text) * nu) + (Val(txt_NChilds.Text) * Val(txt_crate.Text) * nu)


        Openconnection()
        If recmode = Module1.EnuRecstatus.Recnew Then
            If txt_status.Text = "Quotation" Then
                cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Activity", con)
                i = cmd.ExecuteScalar
                cmd.Dispose()
                If i >= 1 Then
                    cmd = New OleDb.OleDbCommand("select max(ABookId) from  Enq_Cust_Activity", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        AbookId = ord(0)
                    End If
                    cmd.Dispose()
                    ord.Close()
                    AbookId = AbookId + 1
                Else
                    AbookId = 1
                End If

                cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Activity values(" & AbookId & ",'" & cuid & "','" & bid & "','" & temp_aid & "'," & nopersons & "," & Val(txt_NAdults.Text) & "," & Val(txt_NJuniors.Text) & "," & Val(txt_NChilds.Text) & ",'" & dtp_act.Text & "','" & txt_rtype.Text & "'," & Val(txt_hrs_days.Text) & "," & Val(txt_Arate.Text) & "," & Val(txt_jrate.Text) & "," & Val(txt_crate.Text) & "," & total & ",'" & cob_Payment.Text & "','" & txt_cmts.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If
            If txt_status.Text = "Confirm" Then
                cmd = New OleDb.OleDbCommand("select count(*) from Cust_Activity", con)
                i = cmd.ExecuteScalar
                cmd.Dispose()
                If i >= 1 Then
                    cmd = New OleDb.OleDbCommand("select max(ABookId) from  Cust_Activity", con)
                    ord = cmd.ExecuteReader
                    If ord.Read Then
                        AbookId = ord(0)
                    End If
                    cmd.Dispose()
                    ord.Close()
                    AbookId = AbookId + 1
                Else
                    AbookId = 1
                End If
                cmd = New OleDb.OleDbCommand("insert into Cust_Activity values(" & AbookId & ",'" & cuid & "','" & bid & "','" & temp_aid & "'," & nopersons & "," & Val(txt_NAdults.Text) & "," & Val(txt_NJuniors.Text) & "," & Val(txt_NChilds.Text) & ",'" & dtp_act.Text & "','" & txt_rtype.Text & "'," & Val(txt_hrs_days.Text) & "," & Val(txt_Arate.Text) & "," & Val(txt_jrate.Text) & "," & Val(txt_crate.Text) & "," & total & ",'" & cob_Payment.Text & "','" & txt_cmts.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If

            dr = dt5.NewRow
            dr(0) = AbookId
            dr(1) = temp_act
            dr(2) = FormatDateTime(dtp_act.Text, DateFormat.ShortDate)
            dr(3) = txt_location.Text
            dr(4) = txt_rtype.Text
            dr(5) = txt_hrs_days.Text
            dr(6) = txt_unit.Text
            dr(7) = txt_NAdults.Text
            dr(8) = txt_NJuniors.Text
            dr(9) = txt_NChilds.Text
            dr(10) = total
            dr(11) = cob_Payment.Text
            dr(12) = txt_cmts.Text
            dt5.Rows.Add(dr)
            DataGrid1.DataSource = ds.Tables("Act")
            MsgSav()
        End If

        If recmode = Module1.EnuRecstatus.Recedit Then
            If txt_status.Text = "Quotation" Then
                AbookId = DataGrid1.Item(crid, 0)
                cmd = New OleDb.OleDbCommand("update Enq_Cust_Activity set Activ_ID='" & temp_aid & "',Noof_Pax=" & nopersons & ",Adults=" & Val(txt_NAdults.Text) & ",Junior=" & Val(txt_NJuniors.Text) & ",Children=" & Val(txt_NChilds.Text) & ",Acti_Date='" & dtp_act.Text & "',Rate_Type='" & txt_rtype.Text & "',Unit=" & Val(txt_hrs_days.Text) & ",Adult_Rate=" & Val(txt_Arate.Text) & ",Junor_Rate=" & Val(txt_jrate.Text) & ",Child_Rate=" & Val(txt_crate.Text) & ",Total_Amt=" & total & ",PaymentBy='" & cob_Payment.Text & "',Comments='" & txt_cmts.Text & "',Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',VouFlag='N',PackageId='' Where AbookId =" & DataGrid1.Item(crid, 0) & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            If txt_status.Text = "Confirm" Then
                cmd = New OleDb.OleDbCommand("update Cust_Activity set Activ_ID='" & temp_aid & "',Noof_Pax=" & nopersons & ",Adults=" & Val(txt_NAdults.Text) & ",Junior=" & Val(txt_NJuniors.Text) & ",Children=" & Val(txt_NChilds.Text) & ",Acti_Date='" & dtp_act.Text & "',Rate_Type='" & txt_rtype.Text & "',Unit=" & Val(txt_hrs_days.Text) & ",Adult_Rate=" & Val(txt_Arate.Text) & ",Junor_Rate=" & Val(txt_jrate.Text) & ",Child_Rate=" & Val(txt_crate.Text) & ",Total_Amt=" & total & ",PaymentBy='" & cob_Payment.Text & "',Comments='" & txt_cmts.Text & "',Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',VouFlag='N',PackageId=''Where AbookId =" & DataGrid1.Item(crid, 0) & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

            DataGrid1.Item(crid, 0) = AbookId
            DataGrid1.Item(crid, 1) = temp_act
            DataGrid1.Item(crid, 2) = dtp_act.Text
            DataGrid1.Item(crid, 3) = txt_location.Text
            DataGrid1.Item(crid, 4) = txt_rtype.Text
            DataGrid1.Item(crid, 5) = txt_hrs_days.Text
            DataGrid1.Item(crid, 6) = txt_unit.Text
            DataGrid1.Item(crid, 7) = txt_NAdults.Text
            DataGrid1.Item(crid, 8) = txt_NJuniors.Text
            DataGrid1.Item(crid, 9) = txt_NChilds.Text
            DataGrid1.Item(crid, 10) = total
            DataGrid1.Item(crid, 11) = cob_Payment.Text
            DataGrid1.Item(crid, 12) = txt_cmts.Text
            ds.Tables("Act").AcceptChanges()
            MsgSav()
        End If
        recmode = Module1.EnuRecstatus.Recnew
        clearproc()
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        crid = DataGrid1.CurrentRowIndex
        Openconnection()
        cmd = New OleDb.OleDbCommand("select ActiV_ID,Activity from Activity", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_activity.Items.Add(ord(0) + "--" + ord(1))
        End While
        ord.Close()
        cmd.Dispose()
        con.Close()

        cob_activity.Text = DataGrid1.Item(crid, 1)
        dtp_act.Text = DataGrid1.Item(crid, 2)
        txt_location.Text = DataGrid1.Item(crid, 3)
        txt_rtype.Text = DataGrid1.Item(crid, 4)
        txt_hrs_days.Text = DataGrid1.Item(crid, 5)
        txt_unit.Text = DataGrid1.Item(crid, 6)
        txt_NAdults.Text = DataGrid1.Item(crid, 7)
        txt_NJuniors.Text = DataGrid1.Item(crid, 8)
        txt_NChilds.Text = DataGrid1.Item(crid, 9)
        cob_Payment.Text = DataGrid1.Item(crid, 11)
        txt_cmts.Text = DataGrid1.Item(crid, 12)
        recmode = Module1.EnuRecstatus.Recedit


    End Sub

    Private Sub cmd_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_del.Click
        Dim yesno As String
        yesno = MsgDelAlert()
        If yesno = vbNo Then
            Exit Sub
        ElseIf yesno = vbYes Then
            If str = "E" Then
                Openconnection()
                cmd = New OleDb.OleDbCommand("delete from Enq_Cust_Activity where ABookId =" & Val(DataGrid1.Item(crid, 0)) & "", con)
                cmd.ExecuteNonQuery()
                dt5.Rows(crid).Delete()
                DataGrid1.DataSource = ds.Tables("Act")
                MsgDel()
            End If
            If str = "C" Then
                Openconnection()
                cmd = New OleDb.OleDbCommand("delete from Cust_Activity where ABookId =" & Val(DataGrid1.Item(crid, 0)) & "", con)
                cmd.ExecuteNonQuery()
                dt5.Rows(crid).Delete()
                DataGrid1.DataSource = ds.Tables("Act")
                MsgDel()
            End If
            clearproc()
        End If
    End Sub

    Private Sub cmd_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub
    Public Sub clearproc()
        Dim x As Object
        For Each x In Me.gbactivity.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
            If TypeOf (x) Is ComboBox Then
                x.text = ""
            End If
            If TypeOf (x) Is DateTimePicker Then
                x.refresh()
            End If
        Next
        txt_bid.Text = bid
        If str = "E" Then
            txt_status.Text = "Quotation"
        ElseIf str = "C" Then
            txt_status.Text = "Confirm"
        End If
    End Sub

End Class
