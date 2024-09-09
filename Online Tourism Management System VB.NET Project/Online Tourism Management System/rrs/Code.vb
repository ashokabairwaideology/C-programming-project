'Name developer: baskar.ch
'Dt:24/07/06
'Purpose :
'Version :1

Imports System.Data.OleDb
Public Class Code
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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dbg1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtremrks As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrol1 As System.Windows.Forms.TabControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Code))
        Me.tabcontrol1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dbg1 = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.txtremrks = New System.Windows.Forms.TextBox
        Me.tabcontrol1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabcontrol1
        '
        Me.tabcontrol1.Controls.Add(Me.TabPage1)
        Me.tabcontrol1.Controls.Add(Me.TabPage2)
        Me.tabcontrol1.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrol1.Name = "tabcontrol1"
        Me.tabcontrol1.SelectedIndex = 0
        Me.tabcontrol1.Size = New System.Drawing.Size(320, 216)
        Me.tabcontrol1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dbg1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(312, 190)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'dbg1
        '
        Me.dbg1.CaptionVisible = False
        Me.dbg1.DataMember = ""
        Me.dbg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg1.Location = New System.Drawing.Point(8, 8)
        Me.dbg1.Name = "dbg1"
        Me.dbg1.ReadOnly = True
        Me.dbg1.Size = New System.Drawing.Size(296, 176)
        Me.dbg1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(312, 190)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.txtremrks)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(96, 24)
        Me.txtcode.MaxLength = 5
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(64, 18)
        Me.txtcode.TabIndex = 0
        Me.txtcode.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description *"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Remarks"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(96, 56)
        Me.txtdescription.MaxLength = 25
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(184, 18)
        Me.txtdescription.TabIndex = 1
        Me.txtdescription.Text = ""
        '
        'txtremrks
        '
        Me.txtremrks.Location = New System.Drawing.Point(96, 88)
        Me.txtremrks.MaxLength = 50
        Me.txtremrks.Multiline = True
        Me.txtremrks.Name = "txtremrks"
        Me.txtremrks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremrks.Size = New System.Drawing.Size(184, 80)
        Me.txtremrks.TabIndex = 2
        Me.txtremrks.Text = ""
        '
        'Code
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(320, 221)
        Me.Controls.Add(Me.tabcontrol1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Code"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Code"
        Me.tabcontrol1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim cmd, cmd1, cmd2 As OleDbCommand
    'Dim da As New OleDbDataAdapter("select * from cust_code", con)
    'Dim ds As New DataSet
    Dim frmstatus As EnuRecstatus

    Private Sub Code_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load
        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()
        tabcontrol1.SelectedTab = TabPage2
        lock()
    End Sub
    Public Sub lock()
        ' after loading the form all form fileds are in diable mode
        txtcode.ReadOnly = True
        txtremrks.ReadOnly = True
        txtdescription.ReadOnly = True
    End Sub
    'it clears all form fields
    Public Sub clearproc()
        Dim ctrl As Control

        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        lock()
    End Sub
    'It enables the enables the input controls to insert data
    Public Sub newproc()

        frmstatus = Module1.EnuRecstatus.Recnew  'form status as new mode
        txtcode.ReadOnly = False ' unlocks the controls
        txtremrks.ReadOnly = False
        txtdescription.ReadOnly = False
        tabcontrol1.SelectedTab = TabPage2
        txtcode.Focus() 'cursor gets into countryid textbox

    End Sub
    'it saves the record into data base
    Public Sub saveproc()



        If txtcode.Text = "" Then
            MsgBox(" Enter Customer code", MsgBoxStyle.OKOnly, Prjtitle)
            txtcode.Focus()
            Exit Sub
        End If
        If txtdescription.Text = "" Then
            MsgBox(" Enter Description", MsgBoxStyle.OKOnly, Prjtitle)
            txtdescription.Focus()
            Exit Sub
        End If
        Label1.Focus()
        Try
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0
                Dim cmd, cmd1 As OleDbCommand

                cmd = New OleDbCommand("select count(*) from cust_code where cust_code='" & txtcode.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    MsgRecexist()
                Else
                    cmd1 = New OleDbCommand("insert into cust_code values('" & txtcode.Text & "','" & txtdescription.Text & "','" & IIf(txtremrks.Text = "", 0, txtremrks.Text) & "')", con)
                    cmd1.ExecuteNonQuery()
                End If
            ElseIf frmstatus = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                Dim cmd2 As OleDbCommand
                cmd2 = New OleDbCommand("update cust_code set Descript='" & txtdescription.Text & "',Remarks='" & IIf(txtremrks.Text = "", " null", txtremrks.Text) & "'  where cust_code='" & txtcode.Text & "'", con)
                cmd2.ExecuteNonQuery()
            End If
            'Displays the updated message in messagebox
            MsgSav()
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
    'assigining form status for updating
    Public Sub editproc()

        frmstatus = Module1.EnuRecstatus.Recedit   'form status as edit mode
        txtcode.ReadOnly = True 'locks the control
        txtdescription.ReadOnly = False 'unlocks the control
        txtremrks.ReadOnly = False
    End Sub
    Public Sub printproc()

        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)

    End Sub
    'deleting the record
    Public Sub delproc()


        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim cmd As OleDbCommand
            Dim str As String = "delete from cust_code where cust_code='" & txtcode.Text & "'"
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            'calls function from module
            MsgDel()
            'clears the controls
            clearproc()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
        Finally
            CloseConnection()
        End Try

    End Sub
    'when tab control changes the index it goes to next tab

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabcontrol1.SelectedIndexChanged
        Dim da As New OleDbDataAdapter("select * from cust_code", con)
        Dim ds As New DataSet
        ds.Clear()
        If tabcontrol1.SelectedTab.Text = "View" Then
            da.Fill(ds, "cust_code")
            dbg1.DataSource = ds.Tables("cust_code")
        End If

    End Sub
    'when we doble click datagrid data will be displayed into selected form fields
    Private Sub dbg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbg1.DoubleClick

        Dim i As String
        Dim k As Integer
        Dim cmd As OleDbCommand
        Dim dr As OleDb.OleDbDataReader 'on click values of record in the datagrid comes on the form
        lock()
        k = dbg1.CurrentRowIndex
        i = dbg1.Item(k, 0)
        Openconnection()
        Try
            cmd = New OleDbCommand("select * from cust_code where cust_code='" & i & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            txtcode.Text = dr(0)
            txtdescription.Text = dr(1)
            txtremrks.Text = dr(2)
            tabcontrol1.SelectedTab = TabPage2
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
    ' uses to enter the first letter as capital letter
    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcode.Leave
        firstcap(txtcode)
    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtdescription_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdescription.Leave
        firstcap(txtdescription)
    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtremrks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtremrks.Leave
        firstcap(txtremrks)
    End Sub
    ' uses to enter number and text in textbox
    Private Sub txtcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcode.KeyPress
        textandnumbers(e)
    End Sub
End Class
