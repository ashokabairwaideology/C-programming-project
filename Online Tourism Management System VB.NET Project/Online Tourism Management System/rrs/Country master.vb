'Name developer: kamal.k.trood
'Dt:20/06/06
'Purpose :
'Version :1

Imports System.Data.OleDb

Public Class Country_master

    Inherits System.Windows.Forms.Form
    'Dim cmd, cmd1, cmd2 As OleDbCommand
    'Dim da As New OleDbDataAdapter("select * from countrymaster", con)
    'Dim ds As New DataSet
    'Dim t As New Form1
    Dim recmode As EnuRecstatus   '  To findout record status
    Dim c1 As New DataColumn("con")
    Dim c2 As New DataColumn("contr")
    Dim dt1 As New DataTable
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim ar(15) As String
    Dim wid(15) As Integer


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
    Friend WithEvents txtcountryid As System.Windows.Forms.TextBox
    Friend WithEvents txtcountryname As System.Windows.Forms.TextBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Country_master))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtcountryname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcountryid = New System.Windows.Forms.TextBox
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
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(304, 136)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(296, 110)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(32, 16)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.Size = New System.Drawing.Size(240, 80)
        Me.dbgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(296, 110)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry/Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcountryname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcountryid)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.On
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtcountryname
        '
        Me.txtcountryname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcountryname.Location = New System.Drawing.Point(152, 64)
        Me.txtcountryname.MaxLength = 25
        Me.txtcountryname.Name = "txtcountryname"
        Me.txtcountryname.Size = New System.Drawing.Size(128, 21)
        Me.txtcountryname.TabIndex = 2
        Me.txtcountryname.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Country Name*"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Country Id*"
        '
        'txtcountryid
        '
        Me.txtcountryid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcountryid.Location = New System.Drawing.Point(152, 32)
        Me.txtcountryid.MaxLength = 3
        Me.txtcountryid.Name = "txtcountryid"
        Me.txtcountryid.Size = New System.Drawing.Size(48, 21)
        Me.txtcountryid.TabIndex = 1
        Me.txtcountryid.Text = ""
        '
        'Country_master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(304, 133)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Country_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Country Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Country_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'on page load it displays entry/edit tab page
        TabControl1.SelectedTab = TabPage2

        'locks the controls
        lock()
        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()
        
        'dt1.Columns.Add(c1)
        'dt1.Columns.Add(c2)

    End Sub
    Public Sub lock()
        'locks the controls
        txtcountryid.ReadOnly = True
        txtcountryname.ReadOnly = True
    End Sub
    'Clears the controls on the form
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    'It enables the enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        'clears the controls
        clearproc()
        ' unlocks the controls
        txtcountryid.ReadOnly = False
        txtcountryname.ReadOnly = False
        'cursor gets into countryid textbox
        TabControl1.SelectedTab = TabPage2
        txtcountryid.Focus()
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        'checks whether the textboxes are empty
        If txtcountryid.Text = "" Then
            MsgBox(" Enter CountryId Of Minimum 3 Characters", MsgBoxStyle.OKOnly, Prjtitle)
            txtcountryid.Focus()
            Exit Sub
        End If
        If txtcountryname.Text = "" Then
            MsgBox(" Enter Country Name", MsgBoxStyle.OKOnly, Prjtitle)
            txtcountryname.Focus()
            Exit Sub
        End If
        Label1.Focus()
        Dim cmd, cmd1, cmd2 As OleDbCommand
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from countrymaster where countryid='" & txtcountryid.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    MsgRecexist()
                    txtcountryid.Focus()
                    Exit Sub
                Else
                    cmd1 = New OleDbCommand("insert into countrymaster values('" & txtcountryid.Text & "','" & txtcountryname.Text & "')", con)
                    cmd1.ExecuteNonQuery()
                End If
                'Displays the updated message in messagebox
                MsgSav()
                'clears the controls
                clearproc()
                'locks the controls
                lock()
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update countrymaster set country='" & txtcountryname.Text & "' where countryid='" & txtcountryid.Text & "'", con)
                cmd2.ExecuteNonQuery()
                'Displays the updated message in messagebox
                MsgSav()
                'clears the controls
                clearproc()
                'locks the controls
                lock()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        'locks the control
        txtcountryid.ReadOnly = True
        'unlocks the control
        txtcountryname.ReadOnly = False
        'cursor gets into countryname textbox
        txtcountryname.Focus()
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes the particular record
    Public Sub delproc()
        Dim cmd As OleDbCommand
        Dim i, p As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            cmd = New OleDbCommand("select count(*) from statemaster where countryid='" & txtcountryid.Text & "'", con)
            p = cmd.ExecuteScalar
            cmd.Dispose()
            If p <> 0 Then
                MsgRecUsed()
            Else
                Dim str As String = "delete from countrymaster where countryid='" & txtcountryid.Text & "'"
                cmd = New OleDbCommand(str, con)
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgDel()
                    'clears the controls
                    clearproc()
                    'locks the controls
                    lock()
                    'Else
                    '    MsgBox("Record Not Found", MsgBoxStyle.OKOnly, Prjtitle)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim da As New OleDbDataAdapter("select * from countrymaster", con)
        ' Dim ds As New DataSet
        'It clears the dataset 
        'ds.Clear()
        'Data in the table country master will be displayed 
        'in datagrid on click in view tab page
        'Dim width(0) As Integer
        Dim dt As New DataTable
        Try
            If TabControl1.SelectedTab.Text = "View" Then
                ReDim Preserve ar(1)
                ReDim Preserve wid(1)

                ar(0) = "Country Id"
                wid(0) = 75

                ar(1) = "Country Name"
                wid(1) = 100
                '
                'To  set Coloumn Name
                '
                colname("select * from countrymaster", dbgview, ar)
                
                'To set Coloumn Width
                '
                colwidth("select * from countrymaster", dbgview, wid)





            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        con.Close()

    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim cmd As OleDbCommand
        Dim i, str As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'locks the controls
        lock()
        'fills the current row index number in k
        k = dbgview.CurrentRowIndex
        'fills the value of row in i
        i = dbgview.Item(k, 0)
        Openconnection()
        str = "select * from countrymaster where countryid='" & i & "'"
        cmd = New OleDbCommand("select * from countrymaster where countryid='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            txtcountryid.Text = dr(0)
            txtcountryname.Text = dr(1)
            TabControl1.SelectedTab = TabPage2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            con.Close()
        End Try
        ' Enabling and disabling of tool bar  butoons when record viewing
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()



    End Sub
    Private Sub txtcountryid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcountryid.KeyPress
        'doesn't allow spaces 
        idtextonly(e)
    End Sub
    Private Sub txtcountryname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcountryname.KeyPress
        'allows to enter text only 
        textonly(e)
    End Sub
    Private Sub txtcountryid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcountryid.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtcountryid)
        If txtcountryname.Focus = True Then
            minchars(txtcountryid, 3)
        End If
        'txtcountryid.Focus()
    End Sub
    Private Sub txtcountryname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcountryname.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtcountryname)
    End Sub
End Class
