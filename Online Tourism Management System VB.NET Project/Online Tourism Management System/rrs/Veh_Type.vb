'Name developer: Emma Christeena.B
'Dt:28/06/06
'Purpose :
'Version :1

Imports System.Data.OleDb
Public Class Veh_Type
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents txtvehtype As System.Windows.Forms.TextBox
    Friend WithEvents txtvehtypeid As System.Windows.Forms.TextBox
    Friend WithEvents tabpage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Veh_Type))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabpage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.txtvehtype = New System.Windows.Forms.TextBox
        Me.txtvehtypeid = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tabpage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpage1)
        Me.TabControl1.Controls.Add(Me.tabpage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(376, 256)
        Me.TabControl1.TabIndex = 0
        '
        'tabpage1
        '
        Me.tabpage1.Controls.Add(Me.GroupBox1)
        Me.tabpage1.Location = New System.Drawing.Point(4, 22)
        Me.tabpage1.Name = "tabpage1"
        Me.tabpage1.Size = New System.Drawing.Size(368, 230)
        Me.tabpage1.TabIndex = 0
        Me.tabpage1.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dbgview)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 8)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(336, 176)
        Me.dbgview.TabIndex = 0
        '
        'tabpage2
        '
        Me.tabpage2.Controls.Add(Me.GroupBox2)
        Me.tabpage2.Location = New System.Drawing.Point(4, 22)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Size = New System.Drawing.Size(368, 230)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtremarks)
        Me.GroupBox2.Controls.Add(Me.txtvehtype)
        Me.GroupBox2.Controls.Add(Me.txtvehtypeid)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 192)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(136, 112)
        Me.txtremarks.MaxLength = 50
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(176, 72)
        Me.txtremarks.TabIndex = 2
        Me.txtremarks.Text = ""
        '
        'txtvehtype
        '
        Me.txtvehtype.Location = New System.Drawing.Point(136, 72)
        Me.txtvehtype.MaxLength = 20
        Me.txtvehtype.Name = "txtvehtype"
        Me.txtvehtype.Size = New System.Drawing.Size(176, 20)
        Me.txtvehtype.TabIndex = 1
        Me.txtvehtype.Text = ""
        '
        'txtvehtypeid
        '
        Me.txtvehtypeid.Location = New System.Drawing.Point(136, 32)
        Me.txtvehtypeid.MaxLength = 5
        Me.txtvehtypeid.Name = "txtvehtypeid"
        Me.txtvehtypeid.Size = New System.Drawing.Size(176, 20)
        Me.txtvehtypeid.TabIndex = 0
        Me.txtvehtypeid.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vehicle Type *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle Type Id *"
        '
        'Veh_Type
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 221)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Veh_Type"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Type Master"
        Me.TabControl1.ResumeLayout(False)
        Me.tabpage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Dim cmd, cmd1, cmd2 As OleDbCommand
    Dim da As New OleDbDataAdapter("select * from Veh_type", con)
    Dim ds As New DataSet
    Dim frmstatus As EnuRecstatus '  To findout record status
    Dim bolvali As Boolean

    Private Sub Veh_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load
        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        TabControl1.SelectedTab = tabpage2
        lock()
    End Sub
    Public Sub lock()
        'locks hte controls
        txtvehtypeid.ReadOnly = True
        txtvehtype.ReadOnly = True
        txtremarks.ReadOnly = True
    End Sub
    Public Sub clearproc()
        'clears all the controls
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox2.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        lock()
    End Sub
    'It enables the enables the input controls to insert data
    Public Sub newproc()
        frmstatus = Module1.EnuRecstatus.Recnew
        clearproc()
        txtvehtypeid.ReadOnly = False
        txtvehtype.ReadOnly = False
        txtremarks.ReadOnly = False
        TabControl1.SelectedTab = tabpage2
        txtvehtypeid.Focus()
    End Sub
    'for validations
    Public Sub valid()
        bolvali = False
        If txtvehtypeid.Text = "" Then
            MsgBox(" Enter vehicle type Id", MsgBoxStyle.OKOnly, Prjtitle)
            txtvehtypeid.Focus()
            Exit Sub
        End If
        If txtvehtype.Text = "" Then
            MsgBox(" Enter vehicle type", MsgBoxStyle.OKOnly, Prjtitle)
            txtvehtype.Focus()
            Exit Sub
        End If
        Label1.Focus()
        bolvali = True
    End Sub
    'inserts or updates a record
    Public Sub saveproc()
        Dim i, j As Byte
        valid()
        If bolvali = False Then Exit Sub

        Try
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from veh_type where VehTypeid='" & txtvehtypeid.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    MsgRecexist()
                    txtvehtypeid.Focus()
                Else
                    cmd1 = New OleDbCommand("insert into veh_type values('" & txtvehtypeid.Text & "','" & txtvehtype.Text & "','" & IIf(txtremarks.Text = "", 0, txtremarks.Text) & "')", con)
                    i = cmd1.ExecuteNonQuery()
                    MsgSav()
                End If

                clearproc()
            ElseIf frmstatus = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update veh_type set VehType='" & txtvehtype.Text & "',Remarks='" & txtremarks.Text & "' where VehTypeid='" & txtvehtypeid.Text & "'", con)
                j = cmd2.ExecuteNonQuery()
                MsgSav()
                clearproc()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'updating the record
    Public Sub editproc()
        frmstatus = Module1.EnuRecstatus.Recedit
        txtvehtypeid.ReadOnly = True
        txtvehtype.ReadOnly = False
        txtremarks.ReadOnly = False
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes a record
    Public Sub delproc()
        Dim i, k As Integer
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            cmd = New OleDbCommand("select count(*) from OwnVehicleMaster where VehTypeid='" & txtvehtypeid.Text & "'", con)
            i = cmd.ExecuteScalar()
            cmd.Dispose()
            cmd = New OleDbCommand("select count(*) from Veh_Dutyslip where VehTypeid='" & txtvehtypeid.Text & "'", con)
            k = cmd.ExecuteScalar()
            cmd.Dispose()
            If k >= 1 Then
                MsgRecUsed()
            ElseIf i >= 1 Then
                MsgRecUsed()
            Else
                Dim str As String = "delete from veh_type where VehTypeid='" & txtvehtypeid.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgDel()
                'clears the controls
                clearproc()
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
    'allows to enter both text and numbers
    Private Sub txtvehtypeid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvehtypeid.KeyPress
        textandnumbers(e)
    End Sub
    'allows to enter both text and numbers
    Private Sub txtvehtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvehtype.KeyPress
        textandnumbers(e)
    End Sub
    'when tab control changes the index it goes to next tab
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ds.Clear()
        If TabControl1.SelectedTab.Text = "View" Then
            da.Fill(ds, "veh_type")
            dbgview.DataSource = ds.Tables("veh_type")
        End If
    End Sub
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim i As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'locks the controls
        lock()
        k = dbgview.CurrentRowIndex
        i = dbgview.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from veh_type where VehTypeid='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            txtvehtypeid.Text = dr(0)
            txtvehtype.Text = dr(1)
            txtremarks.Text = dr(2)
            TabControl1.SelectedTab = tabpage2
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
    'it uses to convert the first letter as cap letter
    Private Sub txtvehtypeid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvehtypeid.Leave
        firstcap(txtvehtypeid)
    End Sub
    'it uses to convert the first letter as cap letter
    Private Sub txtvehtype_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvehtype.Leave
        firstcap(txtvehtype)
    End Sub
    Private Sub txtremarks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtremarks.Leave
        'it uses to convert the first letter as cap letter
        firstcap(txtremarks)
        txtvehtype.Focus()
    End Sub
End Class
