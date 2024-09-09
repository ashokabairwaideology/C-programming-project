'Name:shiva kumar
'Date:06/07/2006
Imports System.Data.OleDb
Public Class FixItiner_Sched
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents TabView As System.Windows.Forms.TabPage
    Friend WithEvents TabEntry As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dg1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtremrks As System.Windows.Forms.TextBox
    Friend WithEvents txttriff As System.Windows.Forms.TextBox
    Friend WithEvents dtpendtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpstrttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpschenddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpschstrtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSchid As System.Windows.Forms.TextBox
    Friend WithEvents cobpacid As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabView = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dg1 = New System.Windows.Forms.DataGrid
        Me.TabEntry = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtremrks = New System.Windows.Forms.TextBox
        Me.txttriff = New System.Windows.Forms.TextBox
        Me.dtpendtime = New System.Windows.Forms.DateTimePicker
        Me.dtpstrttime = New System.Windows.Forms.DateTimePicker
        Me.dtpschenddate = New System.Windows.Forms.DateTimePicker
        Me.dtpschstrtdate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSchid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cobpacid = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabView.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEntry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabView)
        Me.TabControl1.Controls.Add(Me.TabEntry)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 288)
        Me.TabControl1.TabIndex = 0
        '
        'TabView
        '
        Me.TabView.Controls.Add(Me.GroupBox1)
        Me.TabView.Location = New System.Drawing.Point(4, 22)
        Me.TabView.Name = "TabView"
        Me.TabView.Size = New System.Drawing.Size(520, 262)
        Me.TabView.TabIndex = 0
        Me.TabView.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dg1
        '
        Me.dg1.CaptionVisible = False
        Me.dg1.DataMember = ""
        Me.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg1.Location = New System.Drawing.Point(16, 16)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(464, 224)
        Me.dg1.TabIndex = 0
        '
        'TabEntry
        '
        Me.TabEntry.Controls.Add(Me.GroupBox2)
        Me.TabEntry.Location = New System.Drawing.Point(4, 22)
        Me.TabEntry.Name = "TabEntry"
        Me.TabEntry.Size = New System.Drawing.Size(520, 262)
        Me.TabEntry.TabIndex = 1
        Me.TabEntry.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtremrks)
        Me.GroupBox2.Controls.Add(Me.txttriff)
        Me.GroupBox2.Controls.Add(Me.dtpendtime)
        Me.GroupBox2.Controls.Add(Me.dtpstrttime)
        Me.GroupBox2.Controls.Add(Me.dtpschenddate)
        Me.GroupBox2.Controls.Add(Me.dtpschstrtdate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSchid)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cobpacid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 248)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtremrks
        '
        Me.txtremrks.Location = New System.Drawing.Point(144, 176)
        Me.txtremrks.MaxLength = 50
        Me.txtremrks.Multiline = True
        Me.txtremrks.Name = "txtremrks"
        Me.txtremrks.Size = New System.Drawing.Size(352, 64)
        Me.txtremrks.TabIndex = 7
        Me.txtremrks.Text = ""
        '
        'txttriff
        '
        Me.txttriff.Location = New System.Drawing.Point(144, 136)
        Me.txttriff.MaxLength = 7
        Me.txttriff.Name = "txttriff"
        Me.txttriff.Size = New System.Drawing.Size(104, 21)
        Me.txttriff.TabIndex = 6
        Me.txttriff.Text = ""
        '
        'dtpendtime
        '
        Me.dtpendtime.CustomFormat = "HH:mm"
        Me.dtpendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpendtime.Location = New System.Drawing.Point(376, 96)
        Me.dtpendtime.Name = "dtpendtime"
        Me.dtpendtime.ShowUpDown = True
        Me.dtpendtime.Size = New System.Drawing.Size(96, 21)
        Me.dtpendtime.TabIndex = 5
        '
        'dtpstrttime
        '
        Me.dtpstrttime.CustomFormat = "HH:mm"
        Me.dtpstrttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpstrttime.Location = New System.Drawing.Point(144, 96)
        Me.dtpstrttime.Name = "dtpstrttime"
        Me.dtpstrttime.ShowUpDown = True
        Me.dtpstrttime.Size = New System.Drawing.Size(96, 21)
        Me.dtpstrttime.TabIndex = 4
        Me.dtpstrttime.Value = New Date(2006, 7, 18, 0, 0, 0, 0)
        '
        'dtpschenddate
        '
        Me.dtpschenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpschenddate.Location = New System.Drawing.Point(376, 56)
        Me.dtpschenddate.Name = "dtpschenddate"
        Me.dtpschenddate.Size = New System.Drawing.Size(96, 21)
        Me.dtpschenddate.TabIndex = 3
        '
        'dtpschstrtdate
        '
        Me.dtpschstrtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpschstrtdate.Location = New System.Drawing.Point(144, 56)
        Me.dtpschstrtdate.Name = "dtpschstrtdate"
        Me.dtpschstrtdate.Size = New System.Drawing.Size(96, 21)
        Me.dtpschstrtdate.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tariff"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "End Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Start Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Schedule End Date *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Schedule Start Date *"
        '
        'txtSchid
        '
        Me.txtSchid.Location = New System.Drawing.Point(144, 16)
        Me.txtSchid.Name = "txtSchid"
        Me.txtSchid.Size = New System.Drawing.Size(96, 21)
        Me.txtSchid.TabIndex = 0
        Me.txtSchid.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Schedule Id *"
        '
        'cobpacid
        '
        Me.cobpacid.Location = New System.Drawing.Point(376, 16)
        Me.cobpacid.Name = "cobpacid"
        Me.cobpacid.Size = New System.Drawing.Size(96, 21)
        Me.cobpacid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Package Id *"
        '
        'FixItiner_Sched
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(522, 285)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FixItiner_Sched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed Itinerarie Schedule"
        Me.TabControl1.ResumeLayout(False)
        Me.TabView.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEntry.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' Dim con As New OleDbConnection("provider=Microsoft.jet.oledb.4.0;data source=d:\shiva\bin\travelz.mdb")
    Public Sub clearproc()
        txtremrks.Text = ""
        txtremrks.ReadOnly = False
        txtSchid.Text = ""
        txtSchid.ReadOnly = False
        txttriff.Text = ""
        dtpendtime.Text = ""
        dtpschenddate.Text = ""
        dtpschstrtdate.Text = ""
        dtpstrttime.Text = ""
        cobpacid.Text = ""
        recmode = Module1.EnuRecstatus.Recnew
    End Sub

    Private Sub FixItiner_Sched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'on page load it displays entry/edit tab page
        TabControl1.SelectedTab = TabEntry

        txtremrks.Enabled = False
        txtSchid.Enabled = False
        txttriff.Enabled = False
        cobpacid.Enabled = False
        dtpendtime.Enabled = False
        dtpschenddate.Enabled = False
        dtpschstrtdate.Enabled = False
        dtpstrttime.Enabled = False
        TabControl1.SelectedTab = TabEntry
        Openconnection()
        Dim cmd As New OleDbCommand("select * from FixedItineraries", con)
        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader

        While dr.Read
            cobpacid.Items.Add(dr(0))
        End While
        dr.Close()

        CloseConnection()
    End Sub

    Public Sub saveproc()
        Dim boli As Boolean = 0
        'If txtremrks.Text = "" Then
        '    MsgBox("Enter Remarks")
        '    txtremrks.Focus()
        '    boli = 1
        'End If


        If txtSchid.Text = "" Then
            MsgBox("Enter Schedule Id")
            txtSchid.Focus()
            boli = 1
        End If

        If txttriff.Text = "" Then
            MsgBox(" Enter Tariiff")
            txttriff.Focus()
            boli = 1
        End If
        If cobpacid.SelectedItem = "" Then
            MsgBox("Select The package Id")
            boli = 1
        End If
        'Dim dt As TimeZone
        'dt=dtpstrttime.

        If boli = 0 Then

            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()


                Dim cmd As New OleDbCommand("select count(*) from FP_Schedule where trim(Fpsch_id)='" & Trim(txtSchid.Text) & "'", con)
                Try

                    '
                    'To Check Wheather Record Already Exist Or Not
                    '

                    Dim intp As Integer
                    intp = cmd.ExecuteScalar
                    CloseConnection()
                    If intp = 0 Then
                        'Insert data InTo the database
                        Openconnection()
                        Dim cmd1 As New OleDbCommand("insert into FP_Schedule values('" & txtSchid.Text & "','" & cobpacid.SelectedItem & "','" & dtpschstrtdate.Value & "','" & dtpschenddate.Value & "','" & FormatDateTime(dtpstrttime.Value, DateFormat.ShortTime) & "','" & FormatDateTime(dtpendtime.Value, DateFormat.ShortTime) & "','" & txttriff.Text & "','" & IIf(txtremrks.Text = "", 0, txtremrks.Text) & "')", con)
                        cmd1.ExecuteNonQuery()
                        CloseConnection()
                        clearproc()
                        MsgSav()
                    Else
                        MsgRecexist()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    CloseConnection()
                End Try
            End If

            '
            'To Update the record In the database 
            'if recomde=edit is in Edit
            '

            If recmode = Module1.EnuRecstatus.Recedit Then

                Openconnection()
                Dim cmd As New OleDbCommand("update FP_Schedule set fpsch_id='" & txtSchid.Text & "',packageid='" & cobpacid.SelectedItem & "',sch_stdate='" & dtpschstrtdate.Text & "',sch_enddate='" & dtpschenddate.Text & "',sch_sttime='" & dtpstrttime.Text & "',sch_endtime='" & dtpendtime.Text & "', sch_tariff ='" & txttriff.Text & "', sch_remarks='" & txtremrks.Text & "' where fpsch_id='" & txtSchid.Text & "'", con)
                Try

                    cmd.ExecuteNonQuery()
                    MsgSav()
                    clearproc()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    CloseConnection()

                End Try
            End If
        End If
    End Sub

    Public Sub editproc()
        txtSchid.ReadOnly = True
        cobpacid.Enabled = True
        dtpschstrtdate.Enabled = True
        dtpschenddate.Enabled = True
        dtpendtime.Enabled = True
        dtpstrttime.Enabled = True
        txtremrks.ReadOnly = False
        txttriff.ReadOnly = False

        recmode = Module1.EnuRecstatus.Recedit

    End Sub
    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Openconnection()
        Dim da As New OleDbDataAdapter("select * from FP_Schedule", con)
        Dim ds As New DataSet
        Try
            da.Fill(ds, "ee")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
        End Try
        dg1.DataSource = ds.Tables("ee")
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick

        '
        'To See the Selected Data in To The Fields tabpage2
        '

        Dim r As New Integer
        Dim strschid As String
        r = dg1.CurrentRowIndex
        strschid = dg1.Item(r, 0)
        Try
            Openconnection()
            Dim cmd As New OleDbCommand("select * from FP_Schedule where Fpsch_id='" & strschid & "'", con)
            Dim dr As OleDbDataReader

            dr = cmd.ExecuteReader()
            While dr.Read
                txtSchid.Text = dr(0)
                cobpacid.Text = dr(1)
                dtpschstrtdate.Text = dr(2)
                dtpschenddate.Text = dr(3)
                dtpendtime.Text = dr(5)
                dtpstrttime.Text = dr(4)
                txtremrks.Text = dr(7)
                txttriff.Text = dr(6)
            End While
            CloseConnection()
            txtSchid.ReadOnly = True
            cobpacid.Enabled = False
            dtpschstrtdate.Enabled = False
            dtpschenddate.Enabled = False
            dtpendtime.Enabled = False
            dtpstrttime.Enabled = False
            txtremrks.ReadOnly = True
            txttriff.ReadOnly = True
            TabControl1.SelectedTab = TabEntry

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub delproc()
        '
        'To delete  the record from the database 
        'input is the FIxedscheduleId
        '
        Openconnection()
        Dim cmd As New OleDbCommand("delete * from FP_Schedule where Fpsch_id='" & txtSchid.Text & "'", con)
        Try
            If MsgDelAlert() = vbNo Then Exit Sub

            cmd.ExecuteNonQuery()
            clearproc()
            MsgDel()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Public Sub newproc()
        txtSchid.Focus()
        txtremrks.Enabled = True
        txtremrks.ReadOnly = False
        txtSchid.Enabled = True
        txtSchid.ReadOnly = False
        txttriff.Enabled = True
        cobpacid.Enabled = True
        dtpendtime.Enabled = True
        dtpschenddate.Enabled = True
        dtpschstrtdate.Enabled = True
        dtpstrttime.Enabled = True
        txtSchid.Text = ""
        cobpacid.Text = ""
        dtpschstrtdate.Text = ""
        dtpschenddate.Text = ""
        dtpendtime.Text = ""
        dtpstrttime.Text = ""
        txtremrks.Text = ""
        txttriff.Text = ""
        recmode = Module1.EnuRecstatus.Recnew
        ' it displays entry/edit tab page
        TabControl1.SelectedTab = TabEntry
    End Sub

    Private Sub txtSchid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSchid.KeyPress, txttriff.KeyPress
        textandnumbers(e)
    End Sub

    Private Sub cobpacid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobpacid.KeyPress
        combo(e)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub dtpschenddate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpschenddate.LostFocus
        If FormatDateTime(dtpschstrtdate.Text, DateFormat.ShortDate) > FormatDateTime(dtpschenddate.Text, DateFormat.ShortDate) Then
            MsgBox("End Date Should Be Grater Than Start Date", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
    End Sub
End Class
