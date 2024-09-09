'Name developer: baskar.ch
'Dt:17/07/06
'Purpose :
'Version :1
Imports System.Data.oledb
Public Class Hotel_Season
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cobhotid As System.Windows.Forms.ComboBox
    Friend WithEvents Tabpage1 As System.Windows.Forms.TabPage
    Friend WithEvents Tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmdbtn_show As System.Windows.Forms.Button
    Friend WithEvents cobvseason As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cobseason As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dbg1 As System.Windows.Forms.DataGrid
    Friend WithEvents cobhotel As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdbtn_remove As System.Windows.Forms.Button
    Friend WithEvents cmdbtn_add As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpf As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hotel_Season))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tabpage1 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cobvseason = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdbtn_show = New System.Windows.Forms.Button
        Me.cobhotid = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Tabpage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cobseason = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dbg1 = New System.Windows.Forms.DataGrid
        Me.cobhotel = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdbtn_remove = New System.Windows.Forms.Button
        Me.cmdbtn_add = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpt = New System.Windows.Forms.DateTimePicker
        Me.dtpf = New System.Windows.Forms.DateTimePicker
        Me.TabControl1.SuspendLayout()
        Me.Tabpage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Tabpage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dbg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tabpage1)
        Me.TabControl1.Controls.Add(Me.Tabpage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 242)
        Me.TabControl1.TabIndex = 0
        '
        'Tabpage1
        '
        Me.Tabpage1.Controls.Add(Me.GroupBox5)
        Me.Tabpage1.Location = New System.Drawing.Point(4, 22)
        Me.Tabpage1.Name = "Tabpage1"
        Me.Tabpage1.Size = New System.Drawing.Size(584, 216)
        Me.Tabpage1.TabIndex = 0
        Me.Tabpage1.Text = "View"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cobvseason)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.cmdbtn_show)
        Me.GroupBox5.Controls.Add(Me.cobhotid)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(584, 216)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'cobvseason
        '
        Me.cobvseason.Items.AddRange(New Object() {"Peak", "High", "Low"})
        Me.cobvseason.Location = New System.Drawing.Point(224, 56)
        Me.cobvseason.Name = "cobvseason"
        Me.cobvseason.Size = New System.Drawing.Size(96, 21)
        Me.cobvseason.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Season *"
        '
        'cmdbtn_show
        '
        Me.cmdbtn_show.Location = New System.Drawing.Point(256, 112)
        Me.cmdbtn_show.Name = "cmdbtn_show"
        Me.cmdbtn_show.TabIndex = 2
        Me.cmdbtn_show.Text = "Show"
        '
        'cobhotid
        '
        Me.cobhotid.Location = New System.Drawing.Point(224, 24)
        Me.cobhotid.Name = "cobhotid"
        Me.cobhotid.Size = New System.Drawing.Size(232, 21)
        Me.cobhotid.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Hotel Id *"
        '
        'Tabpage2
        '
        Me.Tabpage2.Controls.Add(Me.GroupBox2)
        Me.Tabpage2.Location = New System.Drawing.Point(4, 22)
        Me.Tabpage2.Name = "Tabpage2"
        Me.Tabpage2.Size = New System.Drawing.Size(584, 216)
        Me.Tabpage2.TabIndex = 1
        Me.Tabpage2.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cobseason)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dbg1)
        Me.GroupBox2.Controls.Add(Me.cobhotel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmdbtn_remove)
        Me.GroupBox2.Controls.Add(Me.cmdbtn_add)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpt)
        Me.GroupBox2.Controls.Add(Me.dtpf)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 216)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cobseason
        '
        Me.cobseason.Items.AddRange(New Object() {"Peak", "High", "Low"})
        Me.cobseason.Location = New System.Drawing.Point(384, 16)
        Me.cobseason.Name = "cobseason"
        Me.cobseason.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Season *"
        '
        'dbg1
        '
        Me.dbg1.CaptionVisible = False
        Me.dbg1.DataMember = ""
        Me.dbg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg1.Location = New System.Drawing.Point(368, 64)
        Me.dbg1.Name = "dbg1"
        Me.dbg1.RowHeaderWidth = 15
        Me.dbg1.Size = New System.Drawing.Size(168, 80)
        Me.dbg1.TabIndex = 21
        '
        'cobhotel
        '
        Me.cobhotel.Location = New System.Drawing.Point(64, 16)
        Me.cobhotel.Name = "cobhotel"
        Me.cobhotel.Size = New System.Drawing.Size(216, 21)
        Me.cobhotel.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Hotel"
        '
        'cmdbtn_remove
        '
        Me.cmdbtn_remove.Enabled = False
        Me.cmdbtn_remove.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbtn_remove.Location = New System.Drawing.Point(408, 152)
        Me.cmdbtn_remove.Name = "cmdbtn_remove"
        Me.cmdbtn_remove.Size = New System.Drawing.Size(96, 24)
        Me.cmdbtn_remove.TabIndex = 5
        Me.cmdbtn_remove.Text = "<< Remove"
        '
        'cmdbtn_add
        '
        Me.cmdbtn_add.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbtn_add.Location = New System.Drawing.Point(288, 104)
        Me.cmdbtn_add.Name = "cmdbtn_add"
        Me.cmdbtn_add.Size = New System.Drawing.Size(72, 24)
        Me.cmdbtn_add.TabIndex = 4
        Me.cmdbtn_add.Text = "ADD >>"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To *"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From *"
        '
        'dtpt
        '
        Me.dtpt.Checked = False
        Me.dtpt.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpt.Location = New System.Drawing.Point(224, 72)
        Me.dtpt.Name = "dtpt"
        Me.dtpt.ShowCheckBox = True
        Me.dtpt.Size = New System.Drawing.Size(96, 21)
        Me.dtpt.TabIndex = 3
        '
        'dtpf
        '
        Me.dtpf.Checked = False
        Me.dtpf.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpf.Location = New System.Drawing.Point(64, 72)
        Me.dtpf.Name = "dtpf"
        Me.dtpf.ShowCheckBox = True
        Me.dtpf.Size = New System.Drawing.Size(88, 21)
        Me.dtpf.TabIndex = 2
        '
        'Hotel_Season
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 243)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hotel_Season"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Season"
        Me.TabControl1.ResumeLayout(False)
        Me.Tabpage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.Tabpage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dbg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dt As New DataTable
    Dim frmstatus As EnuRecstatus
    Dim ds As New DataSet
    Dim c1 As New DataColumn("From")
    Dim c2 As New DataColumn("To")
    Dim flag As Boolean
    Private Sub Hotel_Season_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'on page load it displays entry/edit tab page
        TabControl1.SelectedTab = Tabpage2
        'it fills the combo box with hotel ids
        combofill1(cobhotel, "select * from HotelMaster") 'fills the combobox
        lock()
        dt.Columns.Add(c1)
        dt.Columns.Add(c2)
        dbg1.ReadOnly = True
    End Sub
    Public Sub lock()
        'locks the controls
        cobhotel.Enabled = False
        cobseason.Enabled = False
        cmdbtn_add.Enabled = False
        dtpf.Enabled = False
        dtpt.Enabled = False
    End Sub
    'Clears the controls on the form
    Public Sub clearproc()
        Dim ctrl As Control
        Dim i, j As Integer
        For Each ctrl In Me.GroupBox2.Controls
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        dtpf.Checked = False
        dtpt.Checked = False
        dt.Clear()
        ds.Clear()
        lock()
    End Sub
    'It enables the enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        frmstatus = Module1.EnuRecstatus.Recnew 'form status as new mode
        'clears the controls
        clearproc()
        cobhotel.Enabled = True
        cobseason.Enabled = True
        cmdbtn_add.Enabled = True
        dtpf.Enabled = True
        dtpt.Enabled = True
        dtpf.Checked = False
        dtpt.Checked = False
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        Try
            Dim i, transid, rno As Integer
            If cobhotel.Text = "" Then
                MsgBox(" Hotel Name SHOULD NOT BE EMPTY", MsgBoxStyle.OKOnly, Prjtitle)
                cobhotel.Focus()
                Exit Sub
            End If
            If dt.Rows.Count = 0 Then
                MsgBox("Select and add dates", MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            End If
            Label1.Focus()
            frmstatus = Module1.EnuRecstatus.Recnew
            Dim str1, str2 As String
            Dim int, int1, int2 As Integer
            For int1 = 0 To dt.Rows.Count - 1
                'it is used to send the trim value of hotelid
                str1 = cobhotel.Text
                str2 = (str1.Substring(0, str1.IndexOf("-")))
                Dim cmd3, cmd4 As OleDbCommand
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                'it checks the current dates already exists or not in the database
                Dim dt1, dt2, dt3, dt4, dt5 As Date
                Dim cmdt As OleDbCommand
                Dim drt As OleDbDataReader
                Dim x1, x2, x3, x4, x5 As Integer
                'it retrieves dates from database table
                cmdt = New OleDbCommand("select fromdt,todt from hotel_season where hotelid='" & str2 & "'", con)
                drt = cmdt.ExecuteReader
                'this loop repeats no of record times in the database
                While drt.Read
                    dt1 = FormatDateTime(drt(0), DateFormat.ShortDate) 'this date is retrieved from database from date
                    dt2 = FormatDateTime(drt(1), DateFormat.ShortDate) 'this date is retrieved to database from date
                    dt3 = dbg1.Item(int1, 0) 'this is selected from date from datetime picker
                    dt4 = dbg1.Item(int1, 1) 'this is selected to date from datetime picker
                    x1 = DateDiff(DateInterval.Day, dt1, dt2)
                    x3 = DateDiff(DateInterval.Day, dt3, dt4)
                    'it is used to chek whether the selected date lies between database dates
                    dt5 = dt1
                    ' this loop check whether selecte from date lies between database dates
                    For x2 = 0 To x1
                        If dt3 = dt5 Or dt4 = dt5 Then
                            MsgBox("selected date " & dt5 & " lies between another season", MsgBoxStyle.OKOnly, Prjtitle)
                            dbg1.Item(int1, 0) = ""
                            dbg1.Item(int1, 1) = ""
                            dt.Rows.RemoveAt(int1)
                            Exit Sub
                        End If
                        dt5 = DateAdd(DateInterval.Day, 1, dt5)
                    Next
                    x4 = DateDiff(DateInterval.Day, dt3, dt4)
                    'it is used to chek whether the database date lies between selected dates
                    For x5 = 0 To x4
                        If dt1 = dt3 Then
                            MsgBox("selected date " & dt3 & " lies between another season", MsgBoxStyle.OKOnly, Prjtitle)
                            dbg1.Item(int1, 0) = ""
                            dbg1.Item(int1, 1) = ""
                            dt.Rows.RemoveAt(int1)
                            Exit Sub
                        End If
                        dt3 = DateAdd(DateInterval.Day, 1, dt3)
                    Next
                End While
                CloseConnection()
            Next
            For i = 0 To dt.Rows.Count - 1
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                Dim p As Integer = 0
                Dim cmd, cmd1 As OleDbCommand
                cmd = New OleDbCommand("select count(*) from Hotel_Season where HotelId='" & str2 & "' and  Season='" & cobseason.Text & "' and FromDt=#" & dbg1.Item(i, 0) & "# and ToDt=#" & dbg1.Item(i, 1) & "#", con)
                p = cmd.ExecuteScalar
                cmd.Dispose()
                If p <> 0 Then
                    MsgRecexist()
                    Exit Sub
                Else
                    cmd1 = New OleDb.OleDbCommand("select count(*) from Hotel_season", con)
                    transid = cmd1.ExecuteScalar
                    cmd1.Dispose()
                    If transid >= 1 Then
                        ' retrieving tansaction id 
                        cmd1 = New OleDb.OleDbCommand("select max(TransId) from Hotel_season ", con)
                        transid = cmd1.ExecuteScalar
                        cmd1.Dispose()
                    End If
                    ' incrementing transaction id
                    transid = transid + 1
                    cmd = New OleDbCommand("insert into Hotel_Season values('" & transid & "','" & str2 & "','" & cobseason.Text & "','" & dbg1.Item(i, 0) & "','" & dbg1.Item(i, 1) & "')", con)
                    cmd.ExecuteNonQuery()
                    MsgSav()
                End If
            Next
            'clears the controls
            clearproc()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'editing the record
    Public Sub editproc()
        'form status as edit mode
        frmstatus = Module1.EnuRecstatus.Recedit   'form status as edit mode
        dbg1.ReadOnly = True
        cobhotel.Enabled = False
        cobseason.Enabled = False
        cmdbtn_add.Enabled = False
        MsgBox("Record cant be edited.Do you want to delete the record", MsgBoxStyle.OKCancel, Prjtitle)
        delproc()
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'when tab control changes the index it goes to next tab
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "View" Then
            combofill1(cobhotid, "select * from HotelMaster")
            cobhotid.Enabled = True
        End If
    End Sub
    'it deletes the records
    Public Sub delproc()
        Dim cmd As OleDbCommand
        Dim i, k As Integer
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str1, str2 As String
            'it is used to send the trim value of hotelid
            str1 = cobhotel.Text
            str2 = (str1.Substring(0, str1.IndexOf("-")))
            cmd = New OleDbCommand("select count(*) from Room_Tariff where Season='" & cobseason.Text & "'", con)
            k = cmd.ExecuteScalar()
            cmd.Dispose()
            cmd = New OleDbCommand("select count(*) from Room_Tarif_Child where Season='" & cobseason.Text & "'", con)
            i = cmd.ExecuteScalar()
            cmd.Dispose()
            If i >= 1 Or k >= 1 Then
                MsgRecUsed()
            Else
                Dim str As String = "delete from hotel_season where hotelid='" & str2 & "'"
                cmd = New OleDbCommand(str, con)
                i = cmd.ExecuteNonQuery()
                MsgDel()
            End If
            'clears the controls
            clearproc()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'it adds the dates to the data grid
    Private Sub cmdbtn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_add.Click
        Dim i, a As Integer
        If dtpf.Checked = True Then
            Try
                'it uses to put the selected dates in first row
                If dt.Rows.Count = 0 Then
                    Dim r1 As DataRow = dt.NewRow
                    r1.Item(0) = ""
                    r1.Item(1) = ""
                    dt.Rows.Add(r1)
                    dbg1.DataSource = dt
                    'it puts the from date value and to date value in datagrid
                    dbg1.Item(0, 0) = dtpf.Value.ToShortDateString
                    dbg1.Item(0, 1) = dtpt.Value.ToShortDateString
                    FormatDateTime(dbg1.Item(0, 0), DateFormat.ShortDate)
                    FormatDateTime(dbg1.Item(0, 1), DateFormat.ShortDate)
                Else
                    Dim r1 As DataRow = dt.NewRow
                    Dim da1, da, da2, da3, da4 As Date
                    Dim int1 As Integer
                    For i = 0 To dt.Rows.Count - 1 'it repeats the loop for no of rows in datagrid
                        da = FormatDateTime(dbg1.Item(i, 0), DateFormat.ShortDate)
                        da2 = FormatDateTime(dbg1.Item(i, 1), DateFormat.ShortDate)
                        int1 = DateDiff(DateInterval.Day, da, da2)
                        For x As Integer = 0 To int1 'it repeats the loop for no. of days between from date and to date
                            da3 = FormatDateTime(dtpf.Value, DateFormat.ShortDate)
                            'it checks whether the selected from date is in between the before selected dates
                            If Format(da3, "dd/MM/yyyy") = Format(da, "dd/MM/yyyy") Then
                                MsgBox("selected date " & da3 & " lies between another season", MsgBoxStyle.OKOnly, Prjtitle)
                                Exit Sub
                            End If
                            'it checks whether the selected to date is in between the before selected dates
                            da4 = FormatDateTime(dtpt.Value, DateFormat.ShortDate)
                            If Format(da4, "dd/MM/yyyy") = Format(da, "dd/MM/yyyy") Then
                                MsgBox("selected date " & da3 & " lies between another season", MsgBoxStyle.OKOnly, Prjtitle)
                                dbg1.Item(i, 0) = ""
                                dbg1.Item(i, i) = ""
                                Exit Sub
                            End If
                            da = DateAdd(DateInterval.Day, 1, da)
                        Next
                    Next
                    'it puts the from date value and to date value in datagrid
                    r1.Item(0) = ""
                    r1.Item(1) = ""
                    dt.Rows.Add(r1)
                    dbg1.DataSource = dt
                    dbg1.Item(i, 0) = dtpf.Value.ToShortDateString
                    dbg1.Item(i, 1) = dtpt.Value.ToShortDateString
                    FormatDateTime(dbg1.Item(i, 0), DateFormat.ShortDate)
                    FormatDateTime(dbg1.Item(i, 1), DateFormat.ShortDate)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)

                Exit Sub
            End Try
        Else
            MsgBox("Select from and to dates", MsgBoxStyle.OKOnly, Prjtitle)
        End If
    End Sub
    'it enables the button
    Private Sub dbg1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdbtn_remove.Enabled = True
    End Sub
    'it removes selected dates
    Private Sub cmdbtn_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim i As Integer
            'it gives the current row index to remove the row
            i = dbg1.CurrentRowIndex
            dt.Rows.RemoveAt(i)
            cmdbtn_remove.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End Try
    End Sub
    'it fills the form fields
    Private Sub cmdbtn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_show.Click
        'It clears the dataset 
        flag = True
        ds.Clear()
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim season As String

        Openconnection()
        Dim str1, str2 As String
        Dim ad As OleDbDataAdapter
        'to disable the controls
        cmdbtn_add.Enabled = False
        cmdbtn_remove.Enabled = False
        cobhotel.Enabled = False
        cobseason.Enabled = False
        dtpf.Enabled = False
        dtpt.Enabled = False
        'it is used to send the trim value of hotelid
        str1 = cobhotid.Text
        str2 = (str1.Substring(0, str1.IndexOf("-")))
        cmd = New OleDbCommand("select hotelid,season from hotel_season  where hotelid='" & str2 & "' and season='" & cobvseason.Text & "'", con)
        'it fills the datagrid with appropiate dates
        ad = New OleDbDataAdapter("select fromdt,todt from hotel_season where hotelid='" & str2 & "' and season='" & cobvseason.Text & "'", con)
        ad.Fill(ds, "hotel_season")
        dbg1.DataSource = ds.Tables("hotel_season")
        'it uses to fill the form fields
        Try
            dr = cmd.ExecuteReader
            Dim p As Byte
            Dim str As String
            If dr.Read() Then
                str = dr(0)
                comboselet(cobhotel, str)
                cobseason.Text = dr(1)
                TabControl1.SelectedTab = Tabpage2
            Else
                MsgBox("Records not found for selected criteria", MsgBoxStyle.OKOnly, Prjtitle)
            End If
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

    'it is used to set minimum date for to date time picker which is not lessthan from date 
    Private Sub dtpf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpf.TextChanged
        Dim d As Date

        d = FormatDateTime(dtpf.Text, DateFormat.ShortDate)
        d = DateAdd(DateInterval.Day, 1, d)
        dtpt.MinDate = d

    End Sub
    'it should not enter any charecters in combo box
    Private Sub cobhotel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotel.KeyPress
        combo(e)
    End Sub
    'it should not enter any charecters in combo box
    Private Sub cobhotid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotid.KeyPress
        combo(e)
    End Sub

End Class
