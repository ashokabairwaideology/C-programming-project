'Name developer: baskar.ch
'Dt:21/06/06
'Purpose :
'Version :1

Imports System.Data.OleDb
Public Class City_Master
    Inherits System.Windows.Forms.Form
   
    Dim frmstatus As EnuRecstatus

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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cobstateid As System.Windows.Forms.ComboBox
    Friend WithEvents txtcityname As System.Windows.Forms.TextBox
    Friend WithEvents cobcountryid As System.Windows.Forms.ComboBox
    Friend WithEvents txtcityid As System.Windows.Forms.TextBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(City_Master))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cobstateid = New System.Windows.Forms.ComboBox
        Me.txtcityname = New System.Windows.Forms.TextBox
        Me.cobcountryid = New System.Windows.Forms.ComboBox
        Me.txtcityid = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(280, 208)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(272, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 16)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(256, 152)
        Me.dbgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(272, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        Me.TabPage2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cobstateid)
        Me.GroupBox1.Controls.Add(Me.txtcityname)
        Me.GroupBox1.Controls.Add(Me.cobcountryid)
        Me.GroupBox1.Controls.Add(Me.txtcityid)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 176)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Country Id *"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "City Id *"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "State Id *"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "City Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cobstateid
        '
        Me.cobstateid.Location = New System.Drawing.Point(112, 56)
        Me.cobstateid.Name = "cobstateid"
        Me.cobstateid.Size = New System.Drawing.Size(136, 21)
        Me.cobstateid.Sorted = True
        Me.cobstateid.TabIndex = 1
        '
        'txtcityname
        '
        Me.txtcityname.Location = New System.Drawing.Point(112, 120)
        Me.txtcityname.MaxLength = 15
        Me.txtcityname.Name = "txtcityname"
        Me.txtcityname.Size = New System.Drawing.Size(136, 21)
        Me.txtcityname.TabIndex = 3
        Me.txtcityname.Text = ""
        '
        'cobcountryid
        '
        Me.cobcountryid.Location = New System.Drawing.Point(112, 24)
        Me.cobcountryid.Name = "cobcountryid"
        Me.cobcountryid.Size = New System.Drawing.Size(136, 21)
        Me.cobcountryid.Sorted = True
        Me.cobcountryid.TabIndex = 0
        '
        'txtcityid
        '
        Me.txtcityid.Location = New System.Drawing.Point(112, 88)
        Me.txtcityid.MaxLength = 5
        Me.txtcityid.Name = "txtcityid"
        Me.txtcityid.Size = New System.Drawing.Size(136, 21)
        Me.txtcityid.TabIndex = 2
        Me.txtcityid.Text = ""
        '
        'City_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(280, 205)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "City_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "City Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub city_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        TabControl1.SelectedTab = TabPage2
        combofill1(cobcountryid, "select * from countrymaster") 'fills the combobox
        lock()
        cobcountryid.Focus()
    End Sub
    Public Sub lock()
        ' after loading the form all form fileds are in disable mode
        txtcityid.ReadOnly = True
        txtcityname.ReadOnly = True
        cobstateid.Enabled = False
        cobcountryid.Enabled = False
    End Sub
    'it clears all form fields
    Public Sub clearproc()

        Dim ctrl As Control

        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        lock()
    End Sub
    'It enables the enables the input controls to insert data
    Public Sub newproc()

        frmstatus = Module1.EnuRecstatus.Recnew  'form status as new mode
        txtcityid.ReadOnly = False ' unlocks the controls
        txtcityname.ReadOnly = False
        cobstateid.Enabled = True
        cobcountryid.Enabled = True
        cobcountryid.Focus() 'cursor gets into countryid combobox

    End Sub
    'it updates and saves the record into data base
    Public Sub saveproc()

        If txtcityid.Text = "" Then
            MsgBox(" Enter City Id", MsgBoxStyle.OKOnly, Prjtitle)
            txtcityid.Focus()
            Exit Sub
        End If
        If txtcityname.Text = "" Then
            MsgBox(" Enter City Name", MsgBoxStyle.OKOnly, Prjtitle)
            txtcityname.Focus()
            Exit Sub
        End If
        If cobstateid.Text = "" Then
            MsgBox(" Select State Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobstateid.Focus()
            Exit Sub
        End If
        If cobcountryid.Text = "" Then
            MsgBox(" Select Country Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobcountryid.Focus()
            Exit Sub
        End If
        Label1.Focus()
        Dim i, j As Byte
        Dim a, b, c, d As String
        b = cobcountryid.Text
        c = (b.Substring(0, b.IndexOf("-")))
        a = cobstateid.Text
        d = (a.Substring(0, a.IndexOf("-")))
        Try
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0
                Dim cmd, cmd1 As OleDbCommand
                cmd = New OleDbCommand("select count(*) from Citymaster where cityid='" & txtcityid.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    MsgRecexist()
                Else
                    cmd1 = New OleDbCommand("insert into Citymaster values('" & txtcityid.Text & "','" & txtcityname.Text & "','" & d & "','" & c & "')", con)
                    i = cmd1.ExecuteNonQuery()
                    'Displays the updated message in messagebox
                    MsgSav()
                    'clears the controls
                    clearproc()
                End If
            ElseIf frmstatus = Module1.EnuRecstatus.Recedit Then
                Dim cmd2 As OleDbCommand
                Openconnection()
                cmd2 = New OleDbCommand("update Citymaster set city='" & txtcityname.Text & "' where cityid='" & txtcityid.Text & "'", con)
                j = cmd2.ExecuteNonQuery()
                'Displays the updated message in messagebox
                MsgSav()
                'clears the controls
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

        frmstatus = Module1.EnuRecstatus.Recedit   'form status as edit mode
        txtcityid.ReadOnly = True 'locks the control
        txtcityname.ReadOnly = False 'unlocks the control
        cobstateid.Enabled = False
        cobcountryid.Enabled = False

    End Sub
    Public Sub printproc()

        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)

    End Sub
    'deleting the record
    Public Sub delproc()

        Dim i, k As Integer
        Dim cmd As OleDbCommand
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            cmd = New OleDbCommand("select count(*) from LocationMaster where CityId='" & txtcityid.Text & "'", con)
            k = cmd.ExecuteScalar()
            cmd.Dispose()
            If k >= 1 Then
                MsgRecUsed()
            Else
                Dim str As String = "delete from Citymaster where cityid='" & txtcityid.Text & "'"
                cmd = New OleDbCommand(str, con)
                i = cmd.ExecuteNonQuery()
                'calls function from module
                MsgDel()
                'clears the controls
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
    'allows to enter both text and numbers
    Private Sub txtcityid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcityid.KeyPress

        textandnumbers(e)

    End Sub
    'allows to enter text only 
    Private Sub txtcityname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcityname.KeyPress

        textonly(e)

    End Sub
    'when tab control changes the index it goes to next tab

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter("select * from Citymaster", con)
        ds.Clear()
        If TabControl1.SelectedTab.Text = "View" Then
            'da.Fill(ds, "Citymaster")
            'dbgview.DataSource = ds.Tables("Citymaster")
            'fun(ds, da, "citymaster", dbgview)
        End If

    End Sub

    'when we doble click datagrid data will be displayed into selected form fields
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick

        Dim i As String
        Dim k As Integer
        Dim st_id, con_id As String
        Dim cmd As OleDbCommand
        Dim dr As OleDb.OleDbDataReader 'on click values of record in the datagrid comes on the form

        txtcityid.ReadOnly = True 'locks the control
        txtcityname.ReadOnly = True
        cobstateid.Enabled = False
        cobcountryid.Enabled = False
        cobcountryid.Text = ""
        cobstateid.Text = ""
        k = dbgview.CurrentRowIndex
        i = dbgview.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from Citymaster where cityid='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            txtcityid.Text = dr(0)
            txtcityname.Text = dr(1)
            st_id = dr(2)
            con_id = dr(3)
            comboselet(cobcountryid, con_id) ' country selection
            comboselet(cobstateid, st_id)
            TabControl1.SelectedTab = TabPage2
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
    'it fills the state combo box
    Private Sub cobcountryid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobcountryid.SelectedIndexChanged

        Dim b, c As String

        If cobcountryid.Text = "" Then Exit Sub
        b = cobcountryid.Text
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobstateid, "select stateid,state from statemaster where countryid='" & c & "'")

    End Sub
    'it uses to convert the first letter as cap letter
    Private Sub txtcityid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcityid.Leave

        firstcap(txtcityid)

    End Sub
    'it uses to convert the first letter as cap letter  
    Private Sub txtcityname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcityname.Leave
        firstcap(txtcityname)
    End Sub

    Private Sub cobcountryid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcountryid.KeyPress
        combo(e)
    End Sub

    Private Sub cobstateid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobstateid.KeyPress
        combo(e)
    End Sub

End Class


