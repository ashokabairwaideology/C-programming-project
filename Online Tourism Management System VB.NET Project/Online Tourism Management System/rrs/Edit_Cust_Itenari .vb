'written by P.R.Sudhakar Reddy
'Version 1
'date: 3 Aug 2006
Public Class Edit_Cust_Itenari_
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
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_enew As System.Windows.Forms.Button
    Friend WithEvents cmd_edel As System.Windows.Forms.Button
    Friend WithEvents Cob_EBasis As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Txt_NPers As System.Windows.Forms.TextBox
    Friend WithEvents txt_NChild As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cob_ePay As System.Windows.Forms.ComboBox
    Friend WithEvents cob_ecrtype As System.Windows.Forms.ComboBox
    Friend WithEvents cob_eRType As System.Windows.Forms.ComboBox
    Friend WithEvents cob_Ehotel As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_comments As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid10 As System.Windows.Forms.DataGrid
    Friend WithEvents cmd_ecancel As System.Windows.Forms.Button
    Friend WithEvents cmd_esave As System.Windows.Forms.Button
    Friend WithEvents dtpdate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cob_Age As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cob_btype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents txt_bid As System.Windows.Forms.TextBox
    Friend WithEvents cob_Estatus As System.Windows.Forms.ComboBox
    Friend WithEvents cob_cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbhotel As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.Cmd_enew = New System.Windows.Forms.Button
        Me.cmd_edel = New System.Windows.Forms.Button
        Me.gbhotel = New System.Windows.Forms.GroupBox
        Me.cob_Estatus = New System.Windows.Forms.ComboBox
        Me.txt_bid = New System.Windows.Forms.TextBox
        Me.Status = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cob_btype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cob_Age = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpdate1 = New System.Windows.Forms.DateTimePicker
        Me.Cob_EBasis = New System.Windows.Forms.ComboBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Txt_NPers = New System.Windows.Forms.TextBox
        Me.txt_NChild = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cob_ePay = New System.Windows.Forms.ComboBox
        Me.cob_ecrtype = New System.Windows.Forms.ComboBox
        Me.cob_eRType = New System.Windows.Forms.ComboBox
        Me.cob_Ehotel = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_comments = New System.Windows.Forms.TextBox
        Me.cob_cbtype = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGrid10 = New System.Windows.Forms.DataGrid
        Me.cmd_ecancel = New System.Windows.Forms.Button
        Me.cmd_esave = New System.Windows.Forms.Button
        Me.GroupBox16.SuspendLayout()
        Me.gbhotel.SuspendLayout()
        CType(Me.DataGrid10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Cmd_enew)
        Me.GroupBox16.Controls.Add(Me.cmd_edel)
        Me.GroupBox16.Controls.Add(Me.gbhotel)
        Me.GroupBox16.Controls.Add(Me.DataGrid10)
        Me.GroupBox16.Controls.Add(Me.cmd_ecancel)
        Me.GroupBox16.Controls.Add(Me.cmd_esave)
        Me.GroupBox16.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(664, 464)
        Me.GroupBox16.TabIndex = 16
        Me.GroupBox16.TabStop = False
        '
        'Cmd_enew
        '
        Me.Cmd_enew.BackColor = System.Drawing.Color.LightSalmon
        Me.Cmd_enew.Location = New System.Drawing.Point(120, 428)
        Me.Cmd_enew.Name = "Cmd_enew"
        Me.Cmd_enew.Size = New System.Drawing.Size(64, 24)
        Me.Cmd_enew.TabIndex = 6
        Me.Cmd_enew.Text = "New"
        '
        'cmd_edel
        '
        Me.cmd_edel.BackColor = System.Drawing.Color.LightSalmon
        Me.cmd_edel.Location = New System.Drawing.Point(256, 429)
        Me.cmd_edel.Name = "cmd_edel"
        Me.cmd_edel.Size = New System.Drawing.Size(64, 24)
        Me.cmd_edel.TabIndex = 5
        Me.cmd_edel.Text = "Delete"
        '
        'gbhotel
        '
        Me.gbhotel.Controls.Add(Me.cob_Estatus)
        Me.gbhotel.Controls.Add(Me.txt_bid)
        Me.gbhotel.Controls.Add(Me.Status)
        Me.gbhotel.Controls.Add(Me.Label3)
        Me.gbhotel.Controls.Add(Me.cob_btype)
        Me.gbhotel.Controls.Add(Me.Label2)
        Me.gbhotel.Controls.Add(Me.cob_Age)
        Me.gbhotel.Controls.Add(Me.Label1)
        Me.gbhotel.Controls.Add(Me.dtpdate1)
        Me.gbhotel.Controls.Add(Me.Cob_EBasis)
        Me.gbhotel.Controls.Add(Me.Label32)
        Me.gbhotel.Controls.Add(Me.Label31)
        Me.gbhotel.Controls.Add(Me.Label29)
        Me.gbhotel.Controls.Add(Me.Txt_NPers)
        Me.gbhotel.Controls.Add(Me.txt_NChild)
        Me.gbhotel.Controls.Add(Me.Label22)
        Me.gbhotel.Controls.Add(Me.Label21)
        Me.gbhotel.Controls.Add(Me.Label20)
        Me.gbhotel.Controls.Add(Me.Label19)
        Me.gbhotel.Controls.Add(Me.cob_ePay)
        Me.gbhotel.Controls.Add(Me.cob_ecrtype)
        Me.gbhotel.Controls.Add(Me.cob_eRType)
        Me.gbhotel.Controls.Add(Me.cob_Ehotel)
        Me.gbhotel.Controls.Add(Me.Label18)
        Me.gbhotel.Controls.Add(Me.Label17)
        Me.gbhotel.Controls.Add(Me.txt_comments)
        Me.gbhotel.Controls.Add(Me.cob_cbtype)
        Me.gbhotel.Controls.Add(Me.Label5)
        Me.gbhotel.Location = New System.Drawing.Point(24, 224)
        Me.gbhotel.Name = "gbhotel"
        Me.gbhotel.Size = New System.Drawing.Size(632, 184)
        Me.gbhotel.TabIndex = 4
        Me.gbhotel.TabStop = False
        '
        'cob_Estatus
        '
        Me.cob_Estatus.Items.AddRange(New Object() {"Quotation", "Confirm"})
        Me.cob_Estatus.Location = New System.Drawing.Point(528, 16)
        Me.cob_Estatus.Name = "cob_Estatus"
        Me.cob_Estatus.Size = New System.Drawing.Size(96, 21)
        Me.cob_Estatus.TabIndex = 27
        '
        'txt_bid
        '
        Me.txt_bid.Location = New System.Drawing.Point(335, 18)
        Me.txt_bid.Name = "txt_bid"
        Me.txt_bid.ReadOnly = True
        Me.txt_bid.Size = New System.Drawing.Size(96, 20)
        Me.txt_bid.TabIndex = 26
        Me.txt_bid.Text = ""
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(489, 21)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(36, 16)
        Me.Status.TabIndex = 25
        Me.Status.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Booking Id"
        '
        'cob_btype
        '
        Me.cob_btype.Location = New System.Drawing.Point(104, 109)
        Me.cob_btype.Name = "cob_btype"
        Me.cob_btype.Size = New System.Drawing.Size(96, 21)
        Me.cob_btype.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Bed Type"
        '
        'cob_Age
        '
        Me.cob_Age.Location = New System.Drawing.Point(336, 79)
        Me.cob_Age.Name = "cob_Age"
        Me.cob_Age.Size = New System.Drawing.Size(97, 21)
        Me.cob_Age.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Child Type"
        '
        'dtpdate1
        '
        Me.dtpdate1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpdate1.Location = New System.Drawing.Point(105, 16)
        Me.dtpdate1.Name = "dtpdate1"
        Me.dtpdate1.Size = New System.Drawing.Size(96, 20)
        Me.dtpdate1.TabIndex = 19
        Me.dtpdate1.Value = New Date(2006, 8, 7, 0, 0, 0, 0)
        '
        'Cob_EBasis
        '
        Me.Cob_EBasis.Items.AddRange(New Object() {"Shared", "Own", "None"})
        Me.Cob_EBasis.Location = New System.Drawing.Point(336, 48)
        Me.Cob_EBasis.Name = "Cob_EBasis"
        Me.Cob_EBasis.Size = New System.Drawing.Size(96, 21)
        Me.Cob_EBasis.TabIndex = 18
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(288, 50)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(32, 16)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Basis"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(59, 18)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(28, 16)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Date"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(265, 142)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "Comments"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_NPers
        '
        Me.Txt_NPers.Location = New System.Drawing.Point(104, 140)
        Me.Txt_NPers.Name = "Txt_NPers"
        Me.Txt_NPers.Size = New System.Drawing.Size(95, 20)
        Me.Txt_NPers.TabIndex = 12
        Me.Txt_NPers.Text = ""
        '
        'txt_NChild
        '
        Me.txt_NChild.Location = New System.Drawing.Point(528, 78)
        Me.txt_NChild.Name = "txt_NChild"
        Me.txt_NChild.Size = New System.Drawing.Size(95, 20)
        Me.txt_NChild.TabIndex = 11
        Me.txt_NChild.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(462, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 16)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "No Of Childs"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 140)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 16)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "No Of  Persons"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(463, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Payment By"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(233, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 16)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Child Room Type"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cob_ePay
        '
        Me.cob_ePay.Items.AddRange(New Object() {"Client", "We"})
        Me.cob_ePay.Location = New System.Drawing.Point(528, 110)
        Me.cob_ePay.Name = "cob_ePay"
        Me.cob_ePay.Size = New System.Drawing.Size(96, 21)
        Me.cob_ePay.TabIndex = 6
        '
        'cob_ecrtype
        '
        Me.cob_ecrtype.Location = New System.Drawing.Point(336, 111)
        Me.cob_ecrtype.Name = "cob_ecrtype"
        Me.cob_ecrtype.Size = New System.Drawing.Size(96, 21)
        Me.cob_ecrtype.TabIndex = 5
        '
        'cob_eRType
        '
        Me.cob_eRType.Location = New System.Drawing.Point(104, 77)
        Me.cob_eRType.Name = "cob_eRType"
        Me.cob_eRType.Size = New System.Drawing.Size(96, 21)
        Me.cob_eRType.TabIndex = 4
        '
        'cob_Ehotel
        '
        Me.cob_Ehotel.Location = New System.Drawing.Point(104, 45)
        Me.cob_Ehotel.Name = "cob_Ehotel"
        Me.cob_Ehotel.Size = New System.Drawing.Size(96, 21)
        Me.cob_Ehotel.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Room Type"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(57, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Hotel"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_comments
        '
        Me.txt_comments.Location = New System.Drawing.Point(336, 141)
        Me.txt_comments.Name = "txt_comments"
        Me.txt_comments.Size = New System.Drawing.Size(288, 20)
        Me.txt_comments.TabIndex = 14
        Me.txt_comments.Text = ""
        '
        'cob_cbtype
        '
        Me.cob_cbtype.Location = New System.Drawing.Point(528, 48)
        Me.cob_cbtype.Name = "cob_cbtype"
        Me.cob_cbtype.Size = New System.Drawing.Size(96, 21)
        Me.cob_cbtype.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(448, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Child Bed Type"
        '
        'DataGrid10
        '
        Me.DataGrid10.DataMember = ""
        Me.DataGrid10.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid10.Location = New System.Drawing.Point(16, 16)
        Me.DataGrid10.Name = "DataGrid10"
        Me.DataGrid10.ReadOnly = True
        Me.DataGrid10.Size = New System.Drawing.Size(640, 208)
        Me.DataGrid10.TabIndex = 3
        '
        'cmd_ecancel
        '
        Me.cmd_ecancel.BackColor = System.Drawing.Color.LightSalmon
        Me.cmd_ecancel.Location = New System.Drawing.Point(512, 427)
        Me.cmd_ecancel.Name = "cmd_ecancel"
        Me.cmd_ecancel.Size = New System.Drawing.Size(64, 24)
        Me.cmd_ecancel.TabIndex = 2
        Me.cmd_ecancel.Text = "Close"
        '
        'cmd_esave
        '
        Me.cmd_esave.BackColor = System.Drawing.Color.LightSalmon
        Me.cmd_esave.Location = New System.Drawing.Point(384, 427)
        Me.cmd_esave.Name = "cmd_esave"
        Me.cmd_esave.Size = New System.Drawing.Size(64, 24)
        Me.cmd_esave.TabIndex = 1
        Me.cmd_esave.Text = "Save"
        '
        'Edit_Cust_Itenari_
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 471)
        Me.Controls.Add(Me.GroupBox16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Edit_Cust_Itenari_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Cust_Itenari_"
        Me.GroupBox16.ResumeLayout(False)
        Me.gbhotel.ResumeLayout(False)
        CType(Me.DataGrid10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim bid, season, cuid, type As String
    Dim sda, eda, da As Date
    Dim cmd As OleDb.OleDbCommand
    Dim ord As OleDb.OleDbDataReader
    Dim ds As New DataSet
    Dim recmode As Module1.EnuRecstatus
    Dim dr As DataRow
    'data table for hotel
    Dim dt As New DataTable("hbook")
    Dim c1 As New DataColumn("   Date  ")
    Dim c2 As New DataColumn("  HotelId  ")
    Dim c3 As New DataColumn("Room Tariff")
    Dim c4 As New DataColumn("  Amount  ")
    Dim C5 As New DataColumn("   Basis  ")
    Dim c6 As New DataColumn("  C-Room  ")
    Dim c7 As New DataColumn("  C-Amount ")
    Dim c8 As New DataColumn("  Payment  ")
    Dim c9 As New DataColumn("  Comments ")

    Private Sub Edit_Cust_Itenari__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        type = "edit"
        bid = bookid
        txt_bid.Text = bid
        Dim str As String
        str = Mid(bid, 1, 1)
        If str = "E" Then
            cob_Estatus.Text = "Quotation"
        ElseIf str = "C" Then
            cob_Estatus.Text = "Confirm"
        End If
        If str = "C" Then
            'cmd_CQ.Visible = False
        End If
        Openconnection()
        If edit_item = "hotel" Then
            If str = "E" Then
                cmd = New OleDb.OleDbCommand("select CustId,Stdate,EndDate from Enq_Booking_Itinary where BookingId ='" & bid & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    cuid = ord(0)
                    sda = ord(1)
                    eda = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
                con.Close()
                sda = FormatDateTime(sda, DateFormat.ShortDate)
                eda = FormatDateTime(eda, DateFormat.ShortDate)

                'data table for hotel booking   
                ds.Tables.Add(dt)
                dt.Columns.Add(c1)
                dt.Columns.Add(c2)
                dt.Columns.Add(c3)
                dt.Columns.Add(c4)
                dt.Columns.Add(C5)
                dt.Columns.Add(c6)
                dt.Columns.Add(c7)
                dt.Columns.Add(c8)
                dt.Columns.Add(c9)
                bid = bookid
                Dim hi(50), ba(50), py(50), cm(50) As String
                Dim tid(50), am(50), cam(50), j, diff, z, i, a As Integer
                Dim qty(50), ctid(50), cqty(50), rt, crt As String
                da = FormatDateTime(sda, DateFormat.ShortDate)
                diff = DateDiff(DateInterval.Day, sda, eda)
                Openconnection()

                For z = 0 To diff
                    da = FormatDateTime(da, DateFormat.ShortDate)
                    cmd = New OleDb.OleDbCommand("select count(*) from Enq_Cust_Hotel where BookingId='" & bid & "' and Occ_Date = #" & da & "#", con)
                    j = cmd.ExecuteScalar
                    cmd.Dispose()
                    i = 0
                    If j >= 1 Then
                        cmd = New OleDb.OleDbCommand("select TransId,Quanti,Amount,PaymentBy,Comments from Enq_Cust_Hotel where BookingId='" & bid & "'  and Occ_Date=#" & da & "#", con)
                        ord = cmd.ExecuteReader
                        While ord.Read
                            tid(i) = ord(0)
                            qty(i) = CStr(ord(1))
                            am(i) = ord(2)
                            py(i) = ord(3)
                            cm(i) = ord(4)
                            i += 1
                        End While
                        cmd.Dispose()
                        ord.Close()
                        For j = 0 To i - 1
                            Try
                                cmd = New OleDb.OleDbCommand("select c.CTransId,c.Quanti,c.Amount from Enq_Cust_Hotel_Child c,Enq_Cust_Hotel e,Room_Tarif_Child r where e.TransId=" & tid(j) & " and  c.BookingId = e.BookingId and c.BookingId='" & bid & "' and c.Occ_date=#" & da & "# and r.Basis <> 'None' and r.CTransId = c.CTransId", con)
                                ord = cmd.ExecuteReader
                                While ord.Read
                                    ctid(j) = ord(0)
                                    cqty(j) = CStr(ord(1))
                                    cam(j) = ord(2)
                                End While
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                            cmd.Dispose()
                            ord.Close()
                        Next
                        For j = 0 To i - 1
                            a = tid(j)
                            cmd = New OleDb.OleDbCommand("select HotelId from Room_Tariff where TransId = " & a & "", con)
                            hi(j) = cmd.ExecuteScalar
                            cmd.Dispose()
                            If ctid(j) <> "" Then
                                cmd = New OleDb.OleDbCommand("select Basis from Room_Tarif_Child where CTransId=" & ctid(j) & "", con)
                                ba(j) = cmd.ExecuteScalar
                                cmd.Dispose()
                            End If
                        Next
                    End If
                    For j = 0 To i - 1
                        Dim date1 As String
                        date1 = da.ToShortDateString
                        rt = CStr(tid(j)) + "-" + qty(j)
                        crt = ctid(j) + "-" + cqty(j)
                        dr = dt.NewRow
                        dr(0) = date1
                        dr(1) = hi(j)
                        dr(2) = rt
                        dr(3) = am(j)
                        dr(4) = ba(j)
                        dr(5) = crt
                        dr(6) = cam(j)
                        dr(7) = py(j)
                        dr(8) = cm(j)
                        dt.Rows.Add(dr)
                    Next
                    da = DateAdd(DateInterval.Day, 1, da)
                Next
                DataGrid10.DataSource = ds.Tables("hbook")
                DataGrid10.ReadOnly = True
                con.Close()
            End If
            If str = "C" Then
                cmd = New OleDb.OleDbCommand("select CustId,Stdate,EndDate from Booking_Itinary where BookingId ='" & bid & "'", con)
                ord = cmd.ExecuteReader
                If ord.Read Then
                    cuid = ord(0)
                    sda = ord(1)
                    eda = ord(2)
                End If
                ord.Close()
                cmd.Dispose()
                con.Close()
                sda = FormatDateTime(sda, DateFormat.ShortDate)
                eda = FormatDateTime(eda, DateFormat.ShortDate)
                'data table for hotel booking   
                ds.Tables.Add(dt)
                dt.Columns.Add(c1)
                dt.Columns.Add(c2)
                dt.Columns.Add(c3)
                dt.Columns.Add(c4)
                dt.Columns.Add(C5)
                dt.Columns.Add(c6)
                dt.Columns.Add(c7)
                dt.Columns.Add(c8)
                dt.Columns.Add(c9)
                bid = bookid
                Dim hi(50), ba(50), py(50), cm(50) As String
                Dim tid(50), am(50), cam(50), j, diff, z, i, a As Integer
                Dim qty(50), ctid(50), cqty(50), rt, crt As String
                da = FormatDateTime(sda, DateFormat.ShortDate)
                diff = DateDiff(DateInterval.Day, sda, eda)
                Openconnection()

                For z = 0 To diff
                    da = FormatDateTime(da, DateFormat.ShortDate)
                    cmd = New OleDb.OleDbCommand("select count(*) from Cust_Hotel where BookingId='" & bid & "' and Occ_Date = #" & da & "#", con)
                    j = cmd.ExecuteScalar
                    cmd.Dispose()
                    i = 0
                    If j >= 1 Then
                        cmd = New OleDb.OleDbCommand("select TransId,Quanti,Amount,PaymentBy,Comments from Cust_Hotel where BookingId='" & bid & "'  and Occ_Date=#" & da & "#", con)
                        ord = cmd.ExecuteReader
                        While ord.Read
                            tid(i) = ord(0)
                            qty(i) = CStr(ord(1))
                            am(i) = ord(2)
                            py(i) = ord(3)
                            cm(i) = ord(4)
                            i += 1
                        End While
                        cmd.Dispose()
                        ord.Close()
                        For j = 0 To i - 1
                            Try
                                cmd = New OleDb.OleDbCommand("select c.CTransId,c.Quanti,c.Amount from Cust_Hotel_Child c,Cust_Hotel e,Room_Tarif_Child r where e.TransId=" & tid(j) & " and  c.BookingId = e.BookingId and c.BookingId='" & bid & "' and c.Occ_date=#" & da & "# and r.Basis <> 'None' and r.CTransId = c.CTransId", con)
                                ord = cmd.ExecuteReader
                                While ord.Read
                                    ctid(j) = ord(0)
                                    cqty(j) = CStr(ord(1))
                                    cam(j) = ord(2)
                                End While
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                            cmd.Dispose()
                            ord.Close()
                        Next
                        For j = 0 To i - 1
                            a = tid(j)
                            cmd = New OleDb.OleDbCommand("select HotelId from Room_Tariff where TransId = " & a & "", con)
                            hi(j) = cmd.ExecuteScalar
                            cmd.Dispose()
                            If ctid(j) <> "" Then
                                cmd = New OleDb.OleDbCommand("select Basis from Room_Tarif_Child where CTransId=" & ctid(j) & "", con)
                                ba(j) = cmd.ExecuteScalar
                                cmd.Dispose()
                            End If
                        Next
                    End If
                    For j = 0 To i - 1
                        Dim date1 As String
                        date1 = da.ToShortDateString
                        rt = CStr(tid(j)) + "-" + qty(j)
                        crt = ctid(j) + "-" + cqty(j)
                        dr = dt.NewRow
                        dr(0) = date1
                        dr(1) = hi(j)
                        dr(2) = rt
                        dr(3) = am(j)
                        dr(4) = ba(j)
                        dr(5) = crt
                        dr(6) = cam(j)
                        dr(7) = py(j)
                        dr(8) = cm(j)
                        dt.Rows.Add(dr)
                    Next
                    da = DateAdd(DateInterval.Day, 1, da)
                Next
                DataGrid10.DataSource = ds.Tables("hbook")
                DataGrid10.ReadOnly = True
                con.Close()
            End If
            gbhotel.Visible = True
        End If

    End Sub

    Private Sub Cmd_enew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_enew.Click
        type = "new"
        clearproc()
        Openconnection()
        cob_Ehotel.Items.Clear()
        cmd = New OleDb.OleDbCommand("Select HotelId,HotelName from HotelMaster", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_Ehotel.Items.Add(ord(0) + "--" + ord(1))
        End While
        cmd.Dispose()
        ord.Close()
        cob_eRType.Items.Clear()
        cmd = New OleDb.OleDbCommand("select RCatg_Name from Room_Catg", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_eRType.Items.Add(ord(0))
        End While
        cmd.Dispose()
        ord.Close()
        con.Close()
        txt_bid.Text = bid

    End Sub

    Private Sub DataGrid10_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid10.DoubleClick
        type = "edit"
        Dim tid, i, qty, ctid, cqty As Integer
        Dim hotel, basis, hi As String
        basis = DataGrid10.Item(DataGrid10.CurrentRowIndex, 4)
        i = InStr(DataGrid10.Item(DataGrid10.CurrentRowIndex, 2), "-")
        tid = CInt(Mid(DataGrid10.Item(DataGrid10.CurrentRowIndex, 2), 1, i - 1))
        qty = CInt(Mid(DataGrid10.Item(DataGrid10.CurrentRowIndex, 2), i + 1))
        i = InStr(DataGrid10.Item(DataGrid10.CurrentRowIndex, 5), "-")
        ctid = CInt(Mid(DataGrid10.Item(DataGrid10.CurrentRowIndex, 5), 1, i - 1))
        cqty = CInt(Mid(DataGrid10.Item(DataGrid10.CurrentRowIndex, 5), i + 1))
        Openconnection()
        cob_Ehotel.Items.Clear()
        cmd = New OleDb.OleDbCommand("Select HotelId,HotelName from HotelMaster", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_Ehotel.Items.Add(ord(0) + "--" + ord(1))
        End While
        cmd.Dispose()
        ord.Close()

        cmd = New OleDb.OleDbCommand("select h.HotelId,h.HotelName from HotelMaster h,Room_Tariff r where h.HotelId=r.HotelId and r.TransId=" & tid & "", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            cob_Ehotel.Text = ord(0) + "--" + ord(1)
        End If
        cmd.Dispose()

        Txt_NPers.Text = qty
        Openconnection()
        cmd = New OleDb.OleDbCommand("select Bed_Type from Room_Tariff where TransId=" & tid & "", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            cob_btype.Text = ord(0)
        End If
        cmd.Dispose()
        ord.Close()

        cob_eRType.Items.Clear()
        Openconnection()
        cmd = New OleDb.OleDbCommand("select RCatg_Name from Room_Catg", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_eRType.Items.Add(ord(0))
        End While
        cmd.Dispose()
        ord.Close()
        Openconnection()
        cmd = New OleDb.OleDbCommand("select r.RCatg_Name from Room_Catg r,Room_Tariff t where r.RCatg_Id = t.RCatg_Id and t.TransId= " & tid & "", con)
        cob_eRType.Text = cmd.ExecuteScalar
        cmd.Dispose()

        Cob_EBasis.Text = basis

        txt_NChild.Text = cqty
        Openconnection()
        cmd = New OleDb.OleDbCommand("select Chil_Type from Room_Tarif_Child where CTransId=" & ctid & "", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            cob_Age.Text = ord(0)
        End If
        cmd.Dispose()
        ord.Close()

        Openconnection()
        cmd = New OleDb.OleDbCommand("select Bed_Type from Room_Tarif_Child where CTransId=" & ctid & "", con)
        ord = cmd.ExecuteReader
        If ord.Read Then
            cob_cbtype.Text = ord(0)
        End If
        cmd.Dispose()
        ord.Close()
        Openconnection()
        cmd = New OleDb.OleDbCommand("select r.RCatg_Name from Room_Catg r,Room_Tarif_Child c where r.Rcatg_Id = c.RCatg_Id and c.CTransId =" & ctid & "", con)
        cob_ecrtype.Text = cmd.ExecuteScalar
        cmd.Dispose()


        cob_ePay.Text = DataGrid10.Item(DataGrid10.CurrentRowIndex, 7)
        txt_comments.Text = DataGrid10.Item(DataGrid10.CurrentRowIndex, 8)
        dtpdate1.Text = FormatDateTime(DataGrid10.Item(DataGrid10.CurrentRowIndex, 0), DateFormat.ShortDate)
        con.Close()

        dtpdate1.Enabled = False
        cob_Ehotel.Enabled = False
        cob_Estatus.Enabled = False
    End Sub

    Private Sub Cob_EBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cob_EBasis.SelectedIndexChanged
        If Cob_EBasis.SelectedItem = "None" Then
            txt_NChild.Enabled = False
            cob_ecrtype.Enabled = False
        Else
            Dim hi As String
            Dim i As Integer
            i = InStr(cob_Ehotel.Text, "-")
            hi = Mid(cob_Ehotel.Text, 1, i - 1)
            Openconnection()
            cmd = New OleDb.OleDbCommand("select c.Chil_Type from Room_Tarif_Child c,HotelMaster h where c.Basis ='" & Cob_EBasis.SelectedItem & "' and  h.HotelId ='" & hi & "'", con)
            ord = cmd.ExecuteReader
            While ord.Read
                cob_Age.Items.Add(CStr(ord(0)))
            End While
            cmd.Dispose()
            con.Close()
        End If
    End Sub

    Private Sub cmd_esave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_esave.Click
        Dim hi, comphi As String
        Dim cda As Date
        Dim diff, i, tid, ctid, hbookid, chbookid, am, rate, crate, fa, ta, cam As Integer
        Dim t, x, y As OleDb.OleDbTransaction


        '********************************************************************************************
        '********************* new ***** saving into hotel tables ***********************************
        '*******************************   quotation ************************************************
        '********************************************************************************************



        If cob_Estatus.Text = "Quotation" And edit_item = "hotel" And type = "new" Then
            i = InStr(cob_Ehotel.Text, "-")
            hi = Mid(cob_Ehotel.Text, 1, i - 1)
            Openconnection()
            Dim compdate As Integer
            diff = DateDiff(DateInterval.Day, sda, eda)
            cda = FormatDateTime(sda, DateFormat.ShortDate)

            t = con.BeginTransaction
            compdate = Date.Compare(FormatDateTime(dtpdate1.Text, DateFormat.ShortDate), eda)
            If compdate >= 1 Then
                cmd = New OleDb.OleDbCommand("update Enq_Booking_Itinary set EndDate='" & dtpdate1.Text & "' where BookingId ='" & bid & "'", con)
                cmd.Transaction = t
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


            compdate = Date.Compare(FormatDateTime(dtpdate1.Text, DateFormat.ShortDate), sda)
            If compdate <= -1 Then
                cmd = New OleDb.OleDbCommand("update Booking_Itinary  set StDate='" & dtpdate1.Text & "' where BookingId ='" & bid & "'", con)
                cmd.Transaction = t
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            cmd = New OleDb.OleDbCommand("select r.TransId,r.RackRate from Room_Tariff r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_eRType.Text & "' and r.Bed_Type='" & cob_btype.Text & "' and r.Season='" & season & "'", con)
            ord = cmd.ExecuteReader
            While ord.Read
                tid = ord(0)
                rate = ord(1)
            End While
            ord.Close()
            cmd.Dispose()

            am = CInt(rate) * CInt(Txt_NPers.Text)


            cmd = New OleDb.OleDbCommand("select max(HbookId) from Enq_Cust_Hotel ", con)
            hbookid = cmd.ExecuteScalar
            cmd.Dispose()
            hbookid = hbookid + 1

            y = con.BeginTransaction
            cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Hotel values(" & hbookid & ",'" & cuid & "','" & bid & "'," & tid & "," & Val(Txt_NPers.Text) & ",'" & dtpdate1.Text & "'," & am & ",'" & cob_Estatus.Text & "','" & cob_ePay.Text & "','" & txt_comments.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','','" & hi & "')", con)
            cmd.Transaction = y
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            If Cob_EBasis.Text <> "None" Then

                i = InStr(cob_Age.Text, "-")
                fa = CInt(Mid(cob_Age.Text, 1, i - 1))
                ta = CInt(Mid(cob_Age.Text, i + 1))
                cmd = New OleDb.OleDbCommand("select r.CTransId,r.RackRate from Room_Tarif_Child r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_ecrtype.Text & "' and r.Bed_Type='" & cob_cbtype.Text & "' and r.Season='" & season & "'and r.Basis ='" & Cob_EBasis.SelectedItem & "' and r.FromAge = " & fa & " and r.ToAge =" & ta & "", con)
                ord = cmd.ExecuteReader
                While ord.Read
                    ctid = ord(0)
                    crate = ord(1)
                End While
                ord.Close()
                cmd.Dispose()

                cam = CInt(crate) * CInt(txt_NChild.Text)
                x = con.BeginTransaction
                cmd = New OleDb.OleDbCommand("select max(HCBookId) from Enq_Cust_Hotel_Child ", con)
                chbookid = cmd.ExecuteScalar
                cmd.Dispose()
                chbookid = chbookid + 1
                cmd = New OleDb.OleDbCommand("insert into Enq_Cust_Hotel_Child values(" & chbookid & ",'" & cuid & "','" & bid & "'," & ctid & "," & Val(txt_NChild.Text) & ",'" & dtpdate1.Text & "'," & cam & ",'" & cob_Estatus.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','','" & hi & "')", con)
                cmd.Transaction = x
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                x.Commit()

            End If
            y.Commit()
            t.Commit()
            con.Close()


            dr = dt.NewRow
            dr(0) = dtpdate1.Text
            dr(1) = hi
            dr(2) = CStr(tid) + "-" + Txt_NPers.Text
            dr(3) = am
            dr(4) = Cob_EBasis.Text
            dr(5) = CStr(ctid) + "-" + txt_NChild.Text
            dr(6) = cam
            dr(7) = cob_ePay.Text
            dr(8) = txt_comments.Text
            dt.Rows.Add(dr)
            DataGrid10.DataSource = ds.Tables("hbook")
        End If



        '********************************************************************************************  
        '********************************* new *** Hotel status  Confirm *******************************************
        '********************************************************************************************



        If cob_Estatus.Text = "Confirm" And edit_item = "hotel" And type = "new" Then
            i = InStr(cob_Ehotel.Text, "-")
            hi = Mid(cob_Ehotel.Text, 1, i - 1)
            Openconnection()
            Dim compdate As Integer
            diff = DateDiff(DateInterval.Day, sda, eda)
            cda = FormatDateTime(sda, DateFormat.ShortDate)
            compdate = Date.Compare(FormatDateTime(dtpdate1.Text, DateFormat.ShortDate), eda)
            If compdate >= 1 Then
                cmd = New OleDb.OleDbCommand("update Booking_Itinary set EndDate='" & dtpdate1.Text & "' where BookingId ='" & bid & "'", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            compdate = Date.Compare(FormatDateTime(dtpdate1.Text, DateFormat.ShortDate), sda)
            If compdate <= -1 Then
                cmd = New OleDb.OleDbCommand("update Booking_Itinary set StDate='" & dtpdate1.Text & "' where BookingId ='" & bid & "'", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            cmd = New OleDb.OleDbCommand("select r.TransId,r.RackRate from Room_Tariff r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_eRType.Text & "' and r.Bed_Type='" & cob_btype.Text & "' and r.Season='" & season & "'", con)
            ord = cmd.ExecuteReader
            While ord.Read
                tid = ord(0)
                rate = ord(1)
            End While
            ord.Close()
            cmd.Dispose()

            am = CInt(rate) * CInt(Txt_NPers.Text)


            cmd = New OleDb.OleDbCommand("select max(HbookId) from Cust_Hotel ", con)
            hbookid = cmd.ExecuteScalar
            cmd.Dispose()
            hbookid = hbookid + 1


            i = InStr(cob_Age.Text, "-")
            fa = CInt(Mid(cob_Age.Text, 1, i - 1))
            ta = CInt(Mid(cob_Age.Text, i + 1))
            cmd = New OleDb.OleDbCommand("select r.CTransId,r.RackRate from Room_Tarif_Child r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_ecrtype.Text & "' and r.Bed_Type='" & cob_cbtype.Text & "' and r.Season='" & season & "'and r.Basis ='" & Cob_EBasis.SelectedItem & "' and r.FromAge = " & fa & " and r.ToAge =" & ta & "", con)
            ord = cmd.ExecuteReader
            While ord.Read
                ctid = ord(0)
                crate = ord(1)
            End While
            ord.Close()
            cmd.Dispose()
            cam = CInt(crate) * CInt(txt_NChild.Text)

            dr = dt.NewRow
            dr(0) = dtpdate1.Text
            dr(1) = hi
            dr(2) = CStr(tid) + "-" + Txt_NPers.Text
            dr(3) = am
            dr(4) = Cob_EBasis.Text
            dr(5) = CStr(ctid) + "-" + txt_NChild.Text
            dr(6) = cam
            dr(7) = cob_ePay.Text
            dr(8) = txt_comments.Text
            dt.Rows.Add(dr)
            DataGrid10.DataSource = ds.Tables("hbook")


            cmd = New OleDb.OleDbCommand("insert into Cust_Hotel values(" & hbookid & ",'" & cuid & "','" & bid & "'," & tid & "," & Val(Txt_NPers.Text) & ",'" & dtpdate1.Text & "'," & am & ",'" & cob_Estatus.Text & "','" & cob_ePay.Text & "','" & txt_comments.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','','" & hi & "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            If Cob_EBasis.Text <> "None" Then

                cmd = New OleDb.OleDbCommand("select max(HCBookId) from Cust_Hotel_Child ", con)
                chbookid = cmd.ExecuteScalar
                cmd.Dispose()
                chbookid = chbookid + 1
                cmd = New OleDb.OleDbCommand("insert into Cust_Hotel_Child values(" & chbookid & ",'" & cuid & "','" & bid & "'," & ctid & "," & Val(txt_NChild.Text) & ",'" & dtpdate1.Text & "'," & cam & ",'" & cob_Estatus.Text & "','" & Muserid & "','" & FormatDateTime(Now, DateFormat.GeneralDate) & "','N','','" & hi & "')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If
        End If



        '********************************************************************************************
        '                    ************** edit***********                      
        '******************************* saving into hotel tables ***********************************
        '*******************************   quotation ************************************************
        '********************************************************************************************



        If cob_Estatus.Text = "Quotation" And edit_item = "hotel" And type = "edit" Then
            i = InStr(cob_Ehotel.Text, "-")
            hi = Mid(cob_Ehotel.Text, 1, i - 1)

            Openconnection()
            cmd = New OleDb.OleDbCommand("select r.TransId,r.RackRate from Room_Tariff r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_eRType.Text & "' and r.Bed_Type='" & cob_btype.Text & "' and r.Season='" & season & "'", con)
            ord = cmd.ExecuteReader
            While ord.Read
                tid = ord(0)
                rate = ord(1)
            End While
            ord.Close()
            cmd.Dispose()

            am = CInt(rate) * CInt(Txt_NPers.Text)


            cmd = New OleDb.OleDbCommand("select HbookId from Enq_Cust_Hotel where BookingId = '" & bid & "' and Occ_Date = #" & dtpdate1.Text & "#", con)
            hbookid = cmd.ExecuteScalar
            cmd.Dispose()


            i = InStr(cob_Age.Text, "-")
            fa = CInt(Mid(cob_Age.Text, 1, i - 1))
            ta = CInt(Mid(cob_Age.Text, i + 1))
            cmd = New OleDb.OleDbCommand("select r.CTransId,r.RackRate from Room_Tarif_Child r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_ecrtype.Text & "' and r.Bed_Type='" & cob_cbtype.Text & "' and r.Season='" & season & "'and r.Basis ='" & Cob_EBasis.SelectedItem & "' and r.FromAge = " & fa & " and r.ToAge =" & ta & "", con)
            ord = cmd.ExecuteReader
            While ord.Read
                ctid = ord(0)
                crate = ord(1)
            End While
            ord.Close()
            cmd.Dispose()
            cam = CInt(crate) * CInt(txt_NChild.Text)

            DataGrid10.Item(DataGrid10.CurrentRowIndex, 0) = dtpdate1.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 1) = hi
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 2) = CStr(tid) + "-" + Txt_NPers.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 3) = am
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 4) = Cob_EBasis.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 5) = CStr(ctid) + "-" + txt_NChild.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 6) = cam
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 7) = cob_ePay.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 8) = txt_comments.Text

            Try
                cmd = New OleDb.OleDbCommand("update Enq_Cust_Hotel set TransId=" & tid & ",Quanti= " & Val(Txt_NPers.Text) & ",Amount=" & am & ",PaymentBy='" & cob_ePay.Text & "',Comments='" & txt_comments.Text & "',Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',VouFlag='N',PackageId='',HotelId='" & hi & "'where HBookId =" & hbookid & "", con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            cmd.Dispose()

            If Cob_EBasis.Text <> "None" Then

                cmd = New OleDb.OleDbCommand("select HCBookId from Enq_Cust_Hotel_Child where BookingId = '" & bid & "' and Occ_Date = #" & dtpdate1.Text & "#", con)
                chbookid = cmd.ExecuteScalar
                cmd.Dispose()
                cmd = New OleDb.OleDbCommand("update Enq_Cust_Hotel_Child  set CTransId =" & ctid & ",Quanti=" & Val(txt_NChild.Text) & ",Amount=" & cam & ",Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',VouFlag='N',PackageId='',HotelId='" & hi & "' where HCBookId=" & chbookid & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If
        End If



        '********************************************************************************************  
        '************************* edit *** Hotel status  Confirm ***********************************
        '********************************************************************************************



        If cob_Estatus.Text = "Confirm" And edit_item = "hotel" And type = "edit" Then
            i = InStr(cob_Ehotel.Text, "-")
            hi = Mid(cob_Ehotel.Text, 1, i - 1)
            Openconnection()

            cmd = New OleDb.OleDbCommand("select r.TransId,r.RackRate from Room_Tariff r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_eRType.Text & "' and r.Bed_Type='" & cob_btype.Text & "' and r.Season='" & season & "'", con)
            ord = cmd.ExecuteReader
            While ord.Read
                tid = ord(0)
                rate = ord(1)
            End While
            ord.Close()
            cmd.Dispose()

            am = CInt(rate) * CInt(Txt_NPers.Text)

            cmd = New OleDb.OleDbCommand("select HbookId from Cust_Hotel  where BookingId = '" & bid & "' and Occ_Date = #" & dtpdate1.Text & "#", con)
            hbookid = cmd.ExecuteScalar
            cmd.Dispose()

            i = InStr(cob_Age.Text, "-")
            fa = CInt(Mid(cob_Age.Text, 1, i - 1))
            ta = CInt(Mid(cob_Age.Text, i + 1))
            cmd = New OleDb.OleDbCommand("select r.CTransId,r.RackRate from Room_Tarif_Child r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_ecrtype.Text & "' and r.Bed_Type='" & cob_cbtype.Text & "' and r.Season='" & season & "'and r.Basis ='" & Cob_EBasis.SelectedItem & "' and r.FromAge = " & fa & " and r.ToAge =" & ta & "", con)
            ord = cmd.ExecuteReader
            While ord.Read
                ctid = ord(0)
                crate = ord(1)
            End While
            ord.Close()
            cmd.Dispose()
            cam = CInt(crate) * CInt(txt_NChild.Text)


            DataGrid10.Item(DataGrid10.CurrentRowIndex, 0) = dtpdate1.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 1) = hi
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 2) = CStr(tid) + "-" + Txt_NPers.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 3) = am
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 4) = Cob_EBasis.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 5) = CStr(ctid) + "-" + txt_NChild.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 6) = cam
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 7) = cob_ePay.Text
            DataGrid10.Item(DataGrid10.CurrentRowIndex, 8) = txt_comments.Text

            cmd = New OleDb.OleDbCommand("update Cust_Hotel set TransId=" & tid & ",Quanti= " & Val(Txt_NPers.Text) & ",Amount=" & am & ",PaymentBy='" & cob_ePay.Text & "',Comments='" & txt_comments.Text & "',Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',VouFlag='N',PackageId='',HotelId='" & hi & "' where HBookId =" & hbookid & "", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            If Cob_EBasis.Text <> "None" Then

                cmd = New OleDb.OleDbCommand("select HCBookId from Cust_Hotel_Child where BookingId = '" & bid & "' and Occ_Date = #" & dtpdate1.Text & "#", con)
                chbookid = cmd.ExecuteScalar
                cmd.Dispose()
                cmd = New OleDb.OleDbCommand("update Cust_Hotel_Child  set CTransId =" & ctid & ",Quanti=" & Val(txt_NChild.Text) & ",Amount=" & cam & ",Userid='" & Muserid & "',EnteredDt='" & FormatDateTime(Now, DateFormat.GeneralDate) & "',VouFlag='N',PackageId='',HotelId='" & hi & "' where HCBookId=" & chbookid & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            End If
        End If
        MsgSav()
    End Sub

    Private Sub cmd_ecancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ecancel.Click
        Me.Close()
    End Sub
    Public Sub clearproc()
        Dim x As Object
        For Each x In Me.gbhotel.Controls
            If TypeOf (x) Is TextBox Then
                x.text = ""
            End If
            If TypeOf (x) Is ComboBox Then
                x.text = ""
            End If
        Next
    End Sub

    Private Sub cob_Age_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_Age.SelectedIndexChanged
        If Cob_EBasis.SelectedItem = "None" Then
            txt_NChild.Enabled = False
            cob_ecrtype.Enabled = False
        Else
            Dim hi As String
            Dim i As Integer
            Dim fa As Integer
            Dim ta As Integer
            i = InStr(cob_Ehotel.SelectedItem, "-")
            hi = Mid(cob_Ehotel.SelectedItem, 1, i - 1)
            Openconnection()
            cmd = New OleDb.OleDbCommand("select r.RCatg_Name from Room_Catg r,Room_Tarif_Child c,HotelMaster h where r.Rcatg_Id = c.RCatg_Id and c.Basis ='" & Cob_EBasis.SelectedItem & "' and  h.HotelId ='" & hi & "' and c.Chil_Type='" & cob_Age.Text & "'", con)
            ord = cmd.ExecuteReader
            While ord.Read
                cob_ecrtype.Items.Add(ord(0))
            End While
            cmd.Dispose()
            con.Close()
        End If
    End Sub

    Private Sub cob_eRType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_eRType.SelectedIndexChanged
        Dim hi As String
        Dim i As Integer
        i = InStr(cob_Ehotel.Text, "-")
        hi = Mid(cob_Ehotel.Text, 1, i - 1)
        Openconnection()
        cmd = New OleDb.OleDbCommand("select r.Bed_Type from Room_Tariff r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_eRType.Text & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_btype.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
    End Sub

    Private Sub cob_ecrtype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_ecrtype.SelectedIndexChanged
        Dim hi As String
        Dim i As Integer
        i = InStr(cob_Ehotel.Text, "-")
        hi = Mid(cob_Ehotel.Text, 1, i - 1)
        i = InStr(cob_Age.Text, "-")
        Openconnection()
        cmd = New OleDb.OleDbCommand("select r.Bed_Type from Room_Tarif_child r, Room_Catg rc where r.HotelId='" & hi & "' and r.RCatg_Id = rc.RCatg_Id and rc.RCatg_Name ='" & cob_ecrtype.Text & "' and r.Basis ='" & Cob_EBasis.SelectedItem & "'and r.season='" & season & "' and r.Chil_Type ='" & cob_Age.Text & "'", con)
        ord = cmd.ExecuteReader
        While ord.Read
            cob_cbtype.Items.Add(ord(0))
        End While
        ord.Close()
        cmd.Dispose()
    End Sub
    Private Sub cob_Ehotel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_Ehotel.SelectedIndexChanged
        Dim hi As String
        Dim i As Integer
        i = InStr(cob_Ehotel.Text, "-")
        hi = Mid(cob_Ehotel.Text, 1, i - 1)
        Openconnection()
        Try
            cmd = New OleDb.OleDbCommand("select Season from Hotel_Season where HotelId='" & hi & "' and #" & dtpdate1.Text & "# between FromDt and ToDt", con)
            season = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub cmd_edel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edel.Click

    End Sub
End Class
