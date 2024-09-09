'Name developer: kamal.k.trood
'Dt:26/06/06
'Purpose :
'Version :1

Imports System.Data.OleDb
Public Class Location_Master
    Inherits System.Windows.Forms.Form
    Dim cmd, cmd1, cmd2 As OleDbCommand
    Dim da As New OleDbDataAdapter("select * from Locationmaster", con)
    Dim ds As New DataSet
    Dim recmode As EnuRecstatus   '  To findout record status
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlocationid As System.Windows.Forms.TextBox
    Friend WithEvents cobcountry As System.Windows.Forms.ComboBox
    Friend WithEvents cobstate As System.Windows.Forms.ComboBox
    Friend WithEvents cobcity As System.Windows.Forms.ComboBox
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Location_Master))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cobcountry = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cobstate = New System.Windows.Forms.ComboBox
        Me.cobcity = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtlocation = New System.Windows.Forms.TextBox
        Me.txtlocationid = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(248, 216)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 191)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dbgview)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 192)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 16)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.Size = New System.Drawing.Size(224, 168)
        Me.dbgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(240, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry/Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cobcountry)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cobstate)
        Me.GroupBox1.Controls.Add(Me.cobcity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtlocation)
        Me.GroupBox1.Controls.Add(Me.txtlocationid)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 192)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'cobcountry
        '
        Me.cobcountry.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcountry.Items.AddRange(New Object() {"--select--"})
        Me.cobcountry.Location = New System.Drawing.Point(96, 24)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(112, 20)
        Me.cobcountry.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Country Id *"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cobstate
        '
        Me.cobstate.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobstate.Items.AddRange(New Object() {"--select--"})
        Me.cobstate.Location = New System.Drawing.Point(96, 56)
        Me.cobstate.Name = "cobstate"
        Me.cobstate.Size = New System.Drawing.Size(112, 20)
        Me.cobstate.TabIndex = 1
        '
        'cobcity
        '
        Me.cobcity.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobcity.Items.AddRange(New Object() {"--select--"})
        Me.cobcity.Location = New System.Drawing.Point(96, 88)
        Me.cobcity.Name = "cobcity"
        Me.cobcity.Size = New System.Drawing.Size(112, 20)
        Me.cobcity.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "State Id *"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 14)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "City Id*"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 14)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Location*"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(96, 152)
        Me.txtlocation.MaxLength = 15
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(112, 18)
        Me.txtlocation.TabIndex = 4
        Me.txtlocation.Text = ""
        '
        'txtlocationid
        '
        Me.txtlocationid.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocationid.Location = New System.Drawing.Point(96, 120)
        Me.txtlocationid.MaxLength = 5
        Me.txtlocationid.Name = "txtlocationid"
        Me.txtlocationid.Size = New System.Drawing.Size(112, 18)
        Me.txtlocationid.TabIndex = 3
        Me.txtlocationid.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 14)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Location Id* "
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Location_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 11)
        Me.ClientSize = New System.Drawing.Size(248, 213)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Location_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Location_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()


        '  To findout record status
        TabControl1.SelectedTab = TabPage2
        'fills the combobox from country master table
        combofill1(cobcountry, "select * from countrymaster")
        'locks the controls
        lock()
    End Sub
    Public Sub lock()
        'locks the controls
        txtlocationid.ReadOnly = True
        txtlocation.ReadOnly = True
        cobcity.Enabled = False
        cobstate.Enabled = False
        cobcountry.Enabled = False
    End Sub
    'Clears the controls on the form
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
    End Sub
    'It enables the enables the input controls to insert a new record
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        'clears the controls
        clearproc()
        'unlocks the controls
        txtlocationid.ReadOnly = False
        txtlocation.ReadOnly = False
        cobcity.Enabled = True
        cobstate.Enabled = True
        cobcountry.Enabled = True
        '  To findout record status
        TabControl1.SelectedTab = TabPage2
        'cursor gets into countryid combobox
        TabControl1.SelectedTab = TabPage2
        cobcountry.Focus()
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        'checks whether the textboxes are empty
        If txtlocationid.Text = "" Then
            MsgBox(" Enter Location Id", MsgBoxStyle.OKOnly, Prjtitle)
            txtlocationid.Focus()
            Exit Sub
        End If
        If txtlocation.Text = "" Then
            MsgBox(" Enter Location", MsgBoxStyle.OKOnly, Prjtitle)
            txtlocation.Focus()
            Exit Sub
        End If
        If cobcity.Text = "" Then
            MsgBox(" Select City Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobcity.Focus()
            Exit Sub
        End If
        If cobstate.Text = "" Then
            MsgBox(" Select State Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobstate.Focus()
            Exit Sub
        End If
        If cobcountry.Text = "" Then
            MsgBox(" Select Country Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobcountry.Focus()
            Exit Sub
        End If
        Label1.Focus()
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Dim a, b, c, d, e, f As String
                'fills country id combobox from country master
                b = cobcountry.SelectedItem
                c = (b.Substring(0, b.IndexOf("-")))
                'fills state id combobox from state master
                a = cobstate.SelectedItem
                d = (a.Substring(0, a.IndexOf("-")))
                'fills city id combobox from city master
                e = cobcity.SelectedItem
                f = (e.Substring(0, e.IndexOf("-")))
                Openconnection()
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Locationmaster where LocationID='" & txtlocationid.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    ' to show the message that record exsisted already
                    MsgRecexist()
                    txtlocationid.Focus()
                    Exit Sub
                Else
                    cmd1 = New OleDbCommand("insert into Locationmaster values('" & txtlocationid.Text & "','" & txtlocation.Text & "','" & f & "','" & d & "','" & c & "')", con)
                    cmd1.ExecuteNonQuery()
                    'Displays the updated message in messagebox
                    MsgSav()
                    'clears the controls
                    clearproc()
                    'locks the controls
                    lock()
                End If
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update Locationmaster set location='" & txtlocation.Text & "' where LocationID='" & txtlocationid.Text & "'", con)
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
            CloseConnection()
        End Try
    End Sub
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        'locks the control
        txtlocationid.ReadOnly = True
        'locks the control
        cobstate.Enabled = False
        cobstate.Enabled = False
        cobcountry.Enabled = False
        'unlocks the control
        txtlocation.ReadOnly = False
        'cursor gets into location textbox
        txtlocation.Focus()
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes the particular record
    Public Sub delproc()
        Dim i, p, q As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            cmd = New OleDbCommand("select count(*) from distance where FLocationID='" & txtlocationid.Text & "'", con)
            p = cmd.ExecuteScalar
            cmd.Dispose()
            cmd = New OleDbCommand("select count(*) from distance where FLocationID='" & txtlocationid.Text & "'", con)
            q = cmd.ExecuteScalar
            cmd.Dispose()
            If p <> 0 Or q <> 0 Then
                MsgRecUsed()
            Else
                Dim str As String = "delete from Locationmaster where LocationID='" & txtlocationid.Text & "'"
                cmd = New OleDbCommand(str, con)
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgDel()
                    'clears the controls
                    clearproc()
                    'locks the controls
                    lock()
                Else
                    MsgBox("Record Not Found", MsgBoxStyle.OKOnly, Prjtitle)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        'It clears the dataset 
        ds.Clear()
        'Data in the table location master will be displayed 
        'in datagrid on click in view tab page
        If TabControl1.SelectedTab.Text = "View" Then
            da.Fill(ds, "Locationmaster")
            dbgview.DataSource = ds.Tables("Locationmaster")
            dbgview.ReadOnly = True
        End If
    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim i As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'locks the controls
        lock()
        'clears the combobox
        cobcountry.Text = ""
        cobstate.Text = ""
        cobcity.Text = ""
        'fills the current row index number in k
        k = dbgview.CurrentRowIndex
        'fills the value of row in i
        i = dbgview.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from Locationmaster where LocationID='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            txtlocationid.Text = dr(0)
            txtlocation.Text = dr(1)
            cobcity.SelectedText = dr(2)
            cobstate.SelectedText = dr(3)
            cobcountry.SelectedText = dr(4)
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
    Private Sub cobcountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobcountry.SelectedIndexChanged
        Dim b, c As String
        cobstate.Items.Clear()
        b = cobcountry.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobstate, "select stateid,state from statemaster where countryid='" & c & "'")
    End Sub
    Private Sub cobstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobstate.SelectedIndexChanged
        Dim b, c As String
        cobcity.Items.Clear()
        b = cobstate.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        combofill1(cobcity, "select cityid,city from citymaster where stateid='" & c & "'")
    End Sub
    Private Sub txtlocationid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlocationid.KeyPress
        'allows to enter both text and numbers
        idtextandnumbers(e)
    End Sub
    Private Sub txtlocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlocation.KeyPress
        'allows to enter text only 
        textonly(e)
    End Sub
    Private Sub txtlocationid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlocationid.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtlocationid)
        minchars(txtlocationid, 3)
    End Sub
    Private Sub txtlocation_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlocation.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtlocation)
    End Sub
    Private Sub cobcountry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcountry.KeyPress, cobstate.KeyPress, cobcity.KeyPress
        combo(e)
    End Sub
    Private Sub cobstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobstate.KeyPress
        combo(e)
    End Sub
    Private Sub cobcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcity.KeyPress
        combo(e)
    End Sub
End Class
