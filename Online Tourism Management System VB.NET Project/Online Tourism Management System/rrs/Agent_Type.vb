' STARTED ON 29-JUNE-2006
' DEVELOPED BY  Anil.N
' /...
Imports System.data.oledb
Public Class Agent_Type
    Inherits System.Windows.Forms.Form
    Dim cmd, cmd1, cmd2 As New OleDbCommand
    Dim da As New OleDbDataAdapter("select * from agent_type", con)
    Dim ds As New DataSet
    Dim t As New Form1
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
    Friend WithEvents Tabview As System.Windows.Forms.TabPage
    Friend WithEvents Tabentry As System.Windows.Forms.TabPage
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents TXT_AGENTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXT_AGENTID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbc_agenttypemaster As System.Windows.Forms.TabControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Agent_Type))
        Me.tbc_agenttypemaster = New System.Windows.Forms.TabControl
        Me.Tabview = New System.Windows.Forms.TabPage
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.Tabentry = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_AGENTNAME = New System.Windows.Forms.TextBox
        Me.TXT_AGENTID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbc_agenttypemaster.SuspendLayout()
        Me.Tabview.SuspendLayout()
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabentry.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbc_agenttypemaster
        '
        Me.tbc_agenttypemaster.Controls.Add(Me.Tabview)
        Me.tbc_agenttypemaster.Controls.Add(Me.Tabentry)
        Me.tbc_agenttypemaster.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc_agenttypemaster.Location = New System.Drawing.Point(0, 0)
        Me.tbc_agenttypemaster.Name = "tbc_agenttypemaster"
        Me.tbc_agenttypemaster.SelectedIndex = 0
        Me.tbc_agenttypemaster.Size = New System.Drawing.Size(272, 136)
        Me.tbc_agenttypemaster.TabIndex = 3
        '
        'Tabview
        '
        Me.Tabview.Controls.Add(Me.dbg)
        Me.Tabview.Location = New System.Drawing.Point(4, 22)
        Me.Tabview.Name = "Tabview"
        Me.Tabview.Size = New System.Drawing.Size(264, 110)
        Me.Tabview.TabIndex = 0
        Me.Tabview.Text = "View"
        '
        'dbg
        '
        Me.dbg.CaptionVisible = False
        Me.dbg.DataMember = ""
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(8, 8)
        Me.dbg.Name = "dbg"
        Me.dbg.ReadOnly = True
        Me.dbg.Size = New System.Drawing.Size(248, 80)
        Me.dbg.TabIndex = 0
        '
        'Tabentry
        '
        Me.Tabentry.Controls.Add(Me.GroupBox1)
        Me.Tabentry.Location = New System.Drawing.Point(4, 22)
        Me.Tabentry.Name = "Tabentry"
        Me.Tabentry.Size = New System.Drawing.Size(264, 110)
        Me.Tabentry.TabIndex = 1
        Me.Tabentry.Text = "Entry / Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_AGENTNAME)
        Me.GroupBox1.Controls.Add(Me.TXT_AGENTID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TXT_AGENTNAME
        '
        Me.TXT_AGENTNAME.Location = New System.Drawing.Point(128, 64)
        Me.TXT_AGENTNAME.MaxLength = 25
        Me.TXT_AGENTNAME.Name = "TXT_AGENTNAME"
        Me.TXT_AGENTNAME.Size = New System.Drawing.Size(128, 21)
        Me.TXT_AGENTNAME.TabIndex = 1
        Me.TXT_AGENTNAME.Text = ""
        '
        'TXT_AGENTID
        '
        Me.TXT_AGENTID.Location = New System.Drawing.Point(128, 24)
        Me.TXT_AGENTID.MaxLength = 5
        Me.TXT_AGENTID.Name = "TXT_AGENTID"
        Me.TXT_AGENTID.Size = New System.Drawing.Size(48, 21)
        Me.TXT_AGENTID.TabIndex = 0
        Me.TXT_AGENTID.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agent Type Name *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agent Type Id *"
        '
        'Agent_Type
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 133)
        Me.Controls.Add(Me.tbc_agenttypemaster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Agent_Type"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agent Type "
        Me.tbc_agenttypemaster.ResumeLayout(False)
        Me.Tabview.ResumeLayout(False)
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabentry.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Agent_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        '*****************************Form Load*****************
        tbc_agenttypemaster.SelectedTab = Tabentry
        TXT_AGENTID.ReadOnly = True
        TXT_AGENTNAME.ReadOnly = True
    End Sub
    Public Sub lock()
        'Locks The Controls
        TXT_AGENTID.ReadOnly = True
        TXT_AGENTNAME.ReadOnly = True
    End Sub
    Public Sub clearproc()
        '**********************Textboxes Clearing***************
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    Public Sub NEWPROC()
        '**********************Form Status As New Mode**********
        recmode = Module1.EnuRecstatus.Recnew
        '**********************Clears The Controls**************
        clearproc()
        '**********************Unlock The Controls**************
        TXT_AGENTID.ReadOnly = False
        TXT_AGENTNAME.ReadOnly = False
        TXT_AGENTID.Focus()
    End Sub
    Public Sub saveproc()
        If TXT_AGENTID.Text = "" Then
            MsgBox("YOU MUST ENTER THE AGENT TYPE ID", MsgBoxStyle.OKOnly, Prjtitle)
            TXT_AGENTID.Focus()
            Exit Sub
        End If
        If TXT_AGENTNAME.Text = "" Then
            MsgBox("YOU MUST ENTER THE AGENT NAME", MsgBoxStyle.OKOnly, Prjtitle)
            TXT_AGENTNAME.Focus()
            Exit Sub
        End If
        Label1.Focus()
        '********Database Checking Record is Exist or Not*******
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim X As Integer = 0
                cmd = New OleDbCommand("SELECT COUNT(*) FROM AGENT_TYPE WHERE AGENTTYPEID='" & TXT_AGENTID.Text & " '", con)
                X = cmd.ExecuteScalar
                If X <> 0 Then
                    MsgRecexist()
                    clearproc()
                    lock()
                    Exit Sub
                Else
                    cmd1 = New OleDbCommand("insert into agent_type values('" & TXT_AGENTID.Text & "','" & TXT_AGENTNAME.Text & "')", con)
                    cmd1.ExecuteNonQuery()
                    lock()
                End If
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update Agent_Type set  agenttypname ='" & TXT_AGENTNAME.Text & "' WHERE AGENTTYPEID='" & TXT_AGENTID.Text & "'", con)
                cmd2.ExecuteNonQuery()
                lock()
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
        '************************To Edit Record*****************
        recmode = Module1.EnuRecstatus.Recedit
        'Lock Controls
        TXT_AGENTID.ReadOnly = True
        'Unlock Control
        TXT_AGENTNAME.ReadOnly = False

    End Sub
    Public Sub delproc()
        '************************To Delete Record***************
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Dim x As Integer
            Openconnection()
            Dim str1 As String
            str1 = "select count(*) from agentmaster where agenttypeid='" & TXT_AGENTID.Text & "'"
            cmd = New OleDb.OleDbCommand(str1, con)
            x = cmd.ExecuteScalar
            If x >= 1 Then
                'Record is Mapped in Master Table
                MsgRecUsed()
                Exit Sub
            Else
                Dim str As String = "delete from agent_type where agenttypeid='" & TXT_AGENTID.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgDel()
                lock()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            clearproc()
            CloseConnection()
        End Try
    End Sub

    Public Sub CLOSEPROC()
        'Form Closing
        Me.Close()
    End Sub
    Private Sub Tbc_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbc_agenttypemaster.Click
        ds.Clear()
        'Data Grid Filling
        If tbc_agenttypemaster.SelectedTab.Text = "View" Then
            da.Fill(ds, "AGENT_TYPE")
            dbg.DataSource = ds.Tables("AGENT_TYPE")
        End If
    End Sub
    Private Sub dbg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbg.DoubleClick
        'Filling Of TextBoxes
        Dim i As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'Lock The Controls
        TXT_AGENTID.ReadOnly = True
        TXT_AGENTNAME.ReadOnly = True
        k = dbg.CurrentRowIndex
        i = dbg.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from agent_type where agenttypeid='" & i & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        TXT_AGENTID.Text = dr(0)
        TXT_AGENTNAME.Text = dr(1)
        tbc_agenttypemaster.SelectedTab = Tabentry
        CloseConnection()
        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()

    End Sub

    Private Sub TXT_AGENTID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_AGENTID.KeyPress
        'TextBox takes only Text and Number
        textandnumbers(e)
    End Sub

    Private Sub TXT_AGENTNAME_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_AGENTNAME.KeyPress
        'It Takes only text
        textonly(e)
    End Sub

    Private Sub TXT_AGENTID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_AGENTID.Leave
        'Converts First letter into Caps
        firstcap(TXT_AGENTID)
    End Sub

    Private Sub TXT_AGENTNAME_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_AGENTNAME.Leave
        'Converts First letter into Caps
        firstcap(TXT_AGENTNAME)
    End Sub
End Class
