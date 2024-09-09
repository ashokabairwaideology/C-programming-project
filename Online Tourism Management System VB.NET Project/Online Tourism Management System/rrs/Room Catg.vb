'STARTED ON 30-6-2006
'By Anil.N
'/...

Imports System.data.oledb
Public Class Room_catg
    Inherits System.Windows.Forms.Form
    Dim cmd, cmd1, cmd2 As New OleDbCommand
    Dim da As New OleDbDataAdapter("select * from ROOM_CATG", con)
    Dim DS As New DataSet
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_ROOMCAT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CATID As System.Windows.Forms.TextBox
    Friend WithEvents TBC_ROOMCATEGORY As System.Windows.Forms.TabControl
    Friend WithEvents DBG As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Room_catg))
        Me.TBC_ROOMCATEGORY = New System.Windows.Forms.TabControl
        Me.Tabview = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DBG = New System.Windows.Forms.DataGrid
        Me.Tabentry = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TXT_ROOMCAT = New System.Windows.Forms.TextBox
        Me.TXT_CATID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBC_ROOMCATEGORY.SuspendLayout()
        Me.Tabview.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabentry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBC_ROOMCATEGORY
        '
        Me.TBC_ROOMCATEGORY.Controls.Add(Me.Tabview)
        Me.TBC_ROOMCATEGORY.Controls.Add(Me.Tabentry)
        Me.TBC_ROOMCATEGORY.Location = New System.Drawing.Point(0, 0)
        Me.TBC_ROOMCATEGORY.Name = "TBC_ROOMCATEGORY"
        Me.TBC_ROOMCATEGORY.SelectedIndex = 0
        Me.TBC_ROOMCATEGORY.Size = New System.Drawing.Size(224, 112)
        Me.TBC_ROOMCATEGORY.TabIndex = 0
        '
        'Tabview
        '
        Me.Tabview.Controls.Add(Me.GroupBox1)
        Me.Tabview.Location = New System.Drawing.Point(4, 22)
        Me.Tabview.Name = "Tabview"
        Me.Tabview.Size = New System.Drawing.Size(216, 86)
        Me.Tabview.TabIndex = 0
        Me.Tabview.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DBG)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DBG
        '
        Me.DBG.CaptionVisible = False
        Me.DBG.DataMember = ""
        Me.DBG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBG.Location = New System.Drawing.Point(8, 16)
        Me.DBG.Name = "DBG"
        Me.DBG.Size = New System.Drawing.Size(200, 64)
        Me.DBG.TabIndex = 0
        '
        'Tabentry
        '
        Me.Tabentry.Controls.Add(Me.GroupBox2)
        Me.Tabentry.Location = New System.Drawing.Point(4, 22)
        Me.Tabentry.Name = "Tabentry"
        Me.Tabentry.Size = New System.Drawing.Size(216, 86)
        Me.Tabentry.TabIndex = 1
        Me.Tabentry.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_ROOMCAT)
        Me.GroupBox2.Controls.Add(Me.TXT_CATID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 80)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'TXT_ROOMCAT
        '
        Me.TXT_ROOMCAT.Location = New System.Drawing.Point(104, 56)
        Me.TXT_ROOMCAT.MaxLength = 50
        Me.TXT_ROOMCAT.Name = "TXT_ROOMCAT"
        Me.TXT_ROOMCAT.Size = New System.Drawing.Size(96, 20)
        Me.TXT_ROOMCAT.TabIndex = 1
        Me.TXT_ROOMCAT.Text = ""
        '
        'TXT_CATID
        '
        Me.TXT_CATID.Location = New System.Drawing.Point(104, 24)
        Me.TXT_CATID.MaxLength = 50
        Me.TXT_CATID.Name = "TXT_CATID"
        Me.TXT_CATID.Size = New System.Drawing.Size(48, 20)
        Me.TXT_CATID.TabIndex = 0
        Me.TXT_CATID.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Room Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category  Id"
        '
        'Room_catg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(224, 109)
        Me.Controls.Add(Me.TBC_ROOMCATEGORY)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Room_catg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Category"
        Me.TBC_ROOMCATEGORY.ResumeLayout(False)
        Me.Tabview.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabentry.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Room_catg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        TBC_ROOMCATEGORY.SelectedTab = Tabentry
        TXT_CATID.ReadOnly = True
        TXT_ROOMCAT.ReadOnly = True
    End Sub
    Public Sub clearproc()
        'Textboxes clearing
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        TXT_CATID.Text = ""
        TXT_ROOMCAT.Text = ""
        TXT_CATID.Focus()
    End Sub
    Public Sub NEWPROC()
        'Form ststus is new mode
        recmode = Module1.EnuRecstatus.Recnew
        'Clears the controls
        CLEARPROC()
        'Unlock the controls
        TXT_CATID.ReadOnly = False
        TXT_ROOMCAT.ReadOnly = False
        TBC_ROOMCATEGORY.SelectedTab = Tabentry
        TXT_CATID.Focus()
    End Sub
    Public Sub saveproc()
        'Textbox Validations
        If TXT_CATID.Text = "" Then
            MsgBox("YOU MUST ENTER THE AGENT TYPE ID", MsgBoxStyle.OKOnly, Prjtitle)
            TXT_CATID.Focus()
            Exit Sub
        End If
        If TXT_ROOMCAT.Text = "" Then
            MsgBox("YOU MUST ENTER THE AGENT NAME", MsgBoxStyle.OKOnly, Prjtitle)
            TXT_ROOMCAT.Focus()
            Exit Sub
        End If
        Label1.Focus()
        'Database checking whether the record is exist or Not
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim X As Integer = 0
                cmd = New OleDbCommand("SELECT COUNT(*) FROM ROOM_CATG WHERE RCATG_ID='" & TXT_CATID.Text & " '", con)
                X = cmd.ExecuteScalar
                If X <> 0 Then
                    MsgRecexist()
                    clearproc()
                    Exit Sub
                Else
                    cmd1 = New OleDbCommand("insert into ROOM_CATG values('" & TXT_CATID.Text & "','" & TXT_ROOMCAT.Text & "')", con)
                    cmd1.ExecuteNonQuery()
                End If
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update ROOM_CATG set  RCATG_NAME ='" & TXT_ROOMCAT.Text & "' WHERE RCATG_ID='" & TXT_CATID.Text & "'", con)
                cmd2.ExecuteNonQuery()
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
    Public Sub EDITPROC()
        'To edit the record
        recmode = Module1.EnuRecstatus.Recedit
        'Lock the Control
        TXT_CATID.ReadOnly = True
        'Unlock the control
        TXT_ROOMCAT.ReadOnly = False
    End Sub
    Public Sub CLOSEPROC()
        'Closing form
        Me.Close()
    End Sub
    Public Sub DELPROC()
        'Delete the Record
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str1 As String
            Dim x As Integer
            str1 = "select count(*) from room_tariff where rcatg_id='" & TXT_CATID.Text & "'"
            cmd = New OleDbCommand(str1, con)
            x = cmd.ExecuteScalar
            If x >= 1 Then
                MsgRecUsed()
                clearproc()
                Exit Sub
            Else
                Dim str As String = "delete from ROOM_CATG where RCATG_ID='" & TXT_CATID.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgDel()
            End If
            clearproc()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub DBG1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBG.DoubleClick
        'Filling of textboxes
        Dim i As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'Locks the controls
        TXT_CATID.ReadOnly = True
        TXT_ROOMCAT.ReadOnly = True
        k = DBG.CurrentRowIndex
        i = DBG.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from ROOM_CATG where RCATG_ID='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            TXT_CATID.Text = dr(0)
            TXT_ROOMCAT.Text = dr(1)
            TBC_ROOMCATEGORY.SelectedTab = Tabentry
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

    Private Sub TBC_ROOMCATEGORY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBC_ROOMCATEGORY.Click
        DS.Clear()
        'Datagrid filling
         If TBC_ROOMCATEGORY.SelectedTab.Text = "View" Then
            da.Fill(DS, "ROOM_CATG")
            DBG.DataSource = DS.Tables("ROOM_CATG")
        End If
    End Sub

    Private Sub TXT_CATID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_CATID.Leave
        'It converts first letter into caps
        firstcap(TXT_CATID)
    End Sub

    Private Sub TXT_ROOMCAT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_ROOMCAT.Leave
        'It converts first letter into caps
        firstcap(TXT_ROOMCAT)
    End Sub

    Private Sub TXT_CATID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CATID.KeyPress
        'It takes Only Text
        textandnumbers(e)
    End Sub
End Class
