'STARTED ON 11-07-2006
'Anil.N

Imports System.Data.OleDb
Public Class UserMaster
    Inherits System.Windows.Forms.Form
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter("select userid,employeeid,enab  from user_master where enab='Y' ", con)
    Dim ds As New DataSet
    Dim dr As OleDb.OleDbDataReader
    Dim str_rab As Char
    Dim prepswrd As String 'To Store Previous Password in Edit Mode



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
    Friend WithEvents TabView As System.Windows.Forms.TabPage
    Friend WithEvents TabEntry As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grpentry As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cob_empid As System.Windows.Forms.ComboBox
    Friend WithEvents txt_userid As System.Windows.Forms.TextBox
    Friend WithEvents tbc_usermaster As System.Windows.Forms.TabControl
    Friend WithEvents grb_usermaster As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_PSW As System.Windows.Forms.TextBox
    Friend WithEvents txt_cpsw As System.Windows.Forms.TextBox
    Friend WithEvents rabenabled As System.Windows.Forms.RadioButton
    Friend WithEvents rabdisabled As System.Windows.Forms.RadioButton
    Friend WithEvents DBG_USERMASTER As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UserMaster))
        Me.tbc_usermaster = New System.Windows.Forms.TabControl
        Me.TabView = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DBG_USERMASTER = New System.Windows.Forms.DataGrid
        Me.TabEntry = New System.Windows.Forms.TabPage
        Me.Grpentry = New System.Windows.Forms.GroupBox
        Me.rabenabled = New System.Windows.Forms.RadioButton
        Me.rabdisabled = New System.Windows.Forms.RadioButton
        Me.txt_cpsw = New System.Windows.Forms.TextBox
        Me.TXT_PSW = New System.Windows.Forms.TextBox
        Me.grb_usermaster = New System.Windows.Forms.GroupBox
        Me.cob_empid = New System.Windows.Forms.ComboBox
        Me.txt_userid = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbc_usermaster.SuspendLayout()
        Me.TabView.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBG_USERMASTER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEntry.SuspendLayout()
        Me.Grpentry.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbc_usermaster
        '
        Me.tbc_usermaster.Controls.Add(Me.TabView)
        Me.tbc_usermaster.Controls.Add(Me.TabEntry)
        Me.tbc_usermaster.Location = New System.Drawing.Point(0, 0)
        Me.tbc_usermaster.Name = "tbc_usermaster"
        Me.tbc_usermaster.SelectedIndex = 0
        Me.tbc_usermaster.Size = New System.Drawing.Size(312, 264)
        Me.tbc_usermaster.TabIndex = 0
        '
        'TabView
        '
        Me.TabView.Controls.Add(Me.GroupBox1)
        Me.TabView.Location = New System.Drawing.Point(4, 22)
        Me.TabView.Name = "TabView"
        Me.TabView.Size = New System.Drawing.Size(304, 238)
        Me.TabView.TabIndex = 0
        Me.TabView.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DBG_USERMASTER)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DBG_USERMASTER
        '
        Me.DBG_USERMASTER.CaptionVisible = False
        Me.DBG_USERMASTER.DataMember = ""
        Me.DBG_USERMASTER.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBG_USERMASTER.Location = New System.Drawing.Point(8, 24)
        Me.DBG_USERMASTER.Name = "DBG_USERMASTER"
        Me.DBG_USERMASTER.ReadOnly = True
        Me.DBG_USERMASTER.Size = New System.Drawing.Size(288, 200)
        Me.DBG_USERMASTER.TabIndex = 0
        '
        'TabEntry
        '
        Me.TabEntry.Controls.Add(Me.Grpentry)
        Me.TabEntry.Location = New System.Drawing.Point(4, 22)
        Me.TabEntry.Name = "TabEntry"
        Me.TabEntry.Size = New System.Drawing.Size(304, 238)
        Me.TabEntry.TabIndex = 1
        Me.TabEntry.Text = "Entry / Edit"
        '
        'Grpentry
        '
        Me.Grpentry.Controls.Add(Me.rabenabled)
        Me.Grpentry.Controls.Add(Me.rabdisabled)
        Me.Grpentry.Controls.Add(Me.txt_cpsw)
        Me.Grpentry.Controls.Add(Me.TXT_PSW)
        Me.Grpentry.Controls.Add(Me.grb_usermaster)
        Me.Grpentry.Controls.Add(Me.cob_empid)
        Me.Grpentry.Controls.Add(Me.txt_userid)
        Me.Grpentry.Controls.Add(Me.Label4)
        Me.Grpentry.Controls.Add(Me.Label3)
        Me.Grpentry.Controls.Add(Me.Label2)
        Me.Grpentry.Controls.Add(Me.Label1)
        Me.Grpentry.ImeMode = System.Windows.Forms.ImeMode.On
        Me.Grpentry.Location = New System.Drawing.Point(0, 0)
        Me.Grpentry.Name = "Grpentry"
        Me.Grpentry.Size = New System.Drawing.Size(304, 240)
        Me.Grpentry.TabIndex = 0
        Me.Grpentry.TabStop = False
        '
        'rabenabled
        '
        Me.rabenabled.Checked = True
        Me.rabenabled.Location = New System.Drawing.Point(80, 200)
        Me.rabenabled.Name = "rabenabled"
        Me.rabenabled.Size = New System.Drawing.Size(72, 24)
        Me.rabenabled.TabIndex = 5
        Me.rabenabled.TabStop = True
        Me.rabenabled.Text = "Enabled"
        '
        'rabdisabled
        '
        Me.rabdisabled.Location = New System.Drawing.Point(184, 200)
        Me.rabdisabled.Name = "rabdisabled"
        Me.rabdisabled.Size = New System.Drawing.Size(72, 24)
        Me.rabdisabled.TabIndex = 4
        Me.rabdisabled.Text = "Disabled"
        '
        'txt_cpsw
        '
        Me.txt_cpsw.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpsw.Location = New System.Drawing.Point(144, 144)
        Me.txt_cpsw.MaxLength = 10
        Me.txt_cpsw.Name = "txt_cpsw"
        Me.txt_cpsw.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txt_cpsw.Size = New System.Drawing.Size(152, 21)
        Me.txt_cpsw.TabIndex = 3
        Me.txt_cpsw.Text = ""
        '
        'TXT_PSW
        '
        Me.TXT_PSW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PSW.Location = New System.Drawing.Point(144, 104)
        Me.TXT_PSW.MaxLength = 10
        Me.TXT_PSW.Name = "TXT_PSW"
        Me.TXT_PSW.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PSW.Size = New System.Drawing.Size(152, 21)
        Me.TXT_PSW.TabIndex = 2
        Me.TXT_PSW.Text = ""
        '
        'grb_usermaster
        '
        Me.grb_usermaster.Location = New System.Drawing.Point(16, 184)
        Me.grb_usermaster.Name = "grb_usermaster"
        Me.grb_usermaster.Size = New System.Drawing.Size(280, 48)
        Me.grb_usermaster.TabIndex = 9
        Me.grb_usermaster.TabStop = False
        Me.grb_usermaster.Text = "Status"
        '
        'cob_empid
        '
        Me.cob_empid.Enabled = False
        Me.cob_empid.Location = New System.Drawing.Point(144, 64)
        Me.cob_empid.Name = "cob_empid"
        Me.cob_empid.Size = New System.Drawing.Size(152, 21)
        Me.cob_empid.TabIndex = 1
        '
        'txt_userid
        '
        Me.txt_userid.Location = New System.Drawing.Point(144, 24)
        Me.txt_userid.MaxLength = 10
        Me.txt_userid.Name = "txt_userid"
        Me.txt_userid.Size = New System.Drawing.Size(152, 21)
        Me.txt_userid.TabIndex = 0
        Me.txt_userid.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirm Password *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Staff  Id *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Id *"
        '
        'UserMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(312, 261)
        Me.Controls.Add(Me.tbc_usermaster)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Master"
        Me.tbc_usermaster.ResumeLayout(False)
        Me.TabView.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DBG_USERMASTER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEntry.ResumeLayout(False)
        Me.Grpentry.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub UserMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'Lock the controls
        tbc_usermaster.SelectedTab = TabEntry
        txt_userid.Enabled = False
        cob_empid.Enabled = False
        TXT_PSW.Enabled = False
        txt_cpsw.Enabled = False
        rabenabled.Enabled = False
        rabdisabled.Enabled = False
    End Sub
    Public Sub cob_load()
        'Combobox Filling from Employee Master
        Openconnection()
        cmd = New OleDb.OleDbCommand("select employeeid from employeemaster", con)
        dr = cmd.ExecuteReader()
        cob_empid.Items.Clear()
        While dr.Read
            cob_empid.Items.Add(dr(0))
        End While
        dr.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub
    Public Sub clearproc()
        'Textboxes Clearing
        Dim ctrl As Control
        For Each ctrl In Me.Grpentry.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        cob_empid.Text = ""
    End Sub
    Public Sub newproc()
        'Form Status Is new Mode
        recmode = Module1.EnuRecstatus.Recnew
        clearproc()
        'Unlock The Controls
        txt_userid.Enabled = True
        cob_empid.Enabled = True
        TXT_PSW.Enabled = True
        txt_cpsw.Enabled = True
        rabenabled.Enabled = True
        rabenabled.Checked = True
        rabdisabled.Enabled = True
        txt_userid.Focus()
        cob_load()
        tbc_usermaster.SelectedTab = TabEntry
        txt_userid.Focus()
    End Sub
    Public Sub saveproc()
        'Textbox Validations
        If txt_userid.Text = "" Then
            MsgBox("Enter User ID", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
            txt_userid.Focus()
        End If
        If cob_empid.Text = "" Then
            MsgBox("Select Employee ID", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        If TXT_PSW.Text = "" Then
            MsgBox("Enter Password", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        If txt_cpsw.Text = "" Then
            MsgBox("Enter Confirm Password", MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End If
        If TXT_PSW.Text <> txt_cpsw.Text Then
            MsgBox("PassWord Must Be Same", MsgBoxStyle.OKOnly, Prjtitle)
            txt_cpsw.Focus()
            Exit Sub
        End If
        'DataBAse checking record is exist or not
        Try
            '***************if record sattus is new*************
            If recmode = Module1.EnuRecstatus.Recnew Then
                If rabenabled.Checked = True Then
                    str_rab = "Y"
                End If
                If rabdisabled.Checked = True Then
                    str_rab = "N"
                End If
                Openconnection()
                Dim X As Integer = 0
                cmd = New OleDbCommand("SELECT COUNT(*) FROM user_master WHERE userID='" & txt_userid.Text & " '", con)
                X = cmd.ExecuteScalar
                cmd.Dispose()
                If X <> 0 Then
                    MsgRecexist()
                    clearproc()
                    Exit Sub
                Else
                    cmd = New OleDbCommand("insert into user_master values('" & txt_userid.Text & "','" & cob_empid.Text & "','" & TXT_PSW.Text & "','" & txt_cpsw.Text & "', '" & Today & "','" & str_rab & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                End If

                '*******If Record status is edit***************
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then

                ' Openconnection()
                cmd = New OleDbCommand("update user_master set curpassword ='" & TXT_PSW.Text & "',prvpassword='" & prepswrd & "' WHERE trim(userid)='" & txt_userid.Text & "' and trim(employeeid)='" & cob_empid.Text & "'", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            End If
            MsgSav()
            clearproc()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Sub editproc()
         recmode = Module1.EnuRecstatus.Recedit
        'Lock the controls
        cob_empid.Enabled = False
        txt_userid.Enabled = False
        'Unlock the Controls
        TXT_PSW.Enabled = True
        txt_cpsw.Enabled = True
    End Sub
    Public Sub delproc()
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "update user_master set enab='N' where trim(userid)='" & Trim(txt_userid.Text) & "'"
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            MsgDel()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            'CloseConnection()
            Exit Sub
        Finally
            clearproc()
            CloseConnection()
        End Try

    End Sub
    Public Sub closeproc()
        'Form Will close
        Me.Close()
    End Sub

    Private Sub tbc_usermaster_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbc_usermaster.Click
         ds.Clear()
        'Data Filling
        If tbc_usermaster.SelectedTab.Text = "View" Then
            da.Fill(ds, "USER_MASTER")
            DBG_USERMASTER.DataSource = ds.Tables("USER_MASTER")
        End If
    End Sub

    Private Sub DBG_USERMASTER_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBG_USERMASTER.DoubleClick
        Dim i As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'Lock the controls
        txt_userid.Enabled = False
        cob_empid.Enabled = False
        TXT_PSW.Enabled = False
        txt_cpsw.Enabled = False
         k = DBG_USERMASTER.CurrentRowIndex
         i = DBG_USERMASTER.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from USER_MASTER where trim(userid)='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            If dr.Read() Then


                txt_userid.Text = dr(0)
                cob_empid.Text = dr(1)
                TXT_PSW.Text = dr(2)
                txt_cpsw.Text = dr(3)
                prepswrd = dr(2)
            End If
            dr.Close()
            cmd.Dispose()



            tbc_usermaster.SelectedTab = TabEntry
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            'CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try

    End Sub

    Private Sub cob_empid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_empid.KeyPress
        'Combobox lock
        combo(e)
    End Sub
    Private Sub txt_userid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_userid.Leave
        'It convert sfirst letter into caps
        firstcap(txt_userid)
    End Sub

End Class
