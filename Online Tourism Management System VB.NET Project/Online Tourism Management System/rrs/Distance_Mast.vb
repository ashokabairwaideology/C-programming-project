'Name developer: Emma Christeena.B
'Dt:28/06/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Class Distance_Mast
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cobtoloc As System.Windows.Forms.ComboBox
    Friend WithEvents cobfromloc As System.Windows.Forms.ComboBox
    Friend WithEvents txtkms As System.Windows.Forms.TextBox
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents tabpage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Distance_Mast))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabpage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cobtoloc = New System.Windows.Forms.ComboBox
        Me.cobfromloc = New System.Windows.Forms.ComboBox
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.txtkms = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.TabControl1.Size = New System.Drawing.Size(344, 256)
        Me.TabControl1.TabIndex = 0
        '
        'tabpage1
        '
        Me.tabpage1.Controls.Add(Me.GroupBox1)
        Me.tabpage1.Location = New System.Drawing.Point(4, 22)
        Me.tabpage1.Name = "tabpage1"
        Me.tabpage1.Size = New System.Drawing.Size(336, 230)
        Me.tabpage1.TabIndex = 0
        Me.tabpage1.Text = "View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dbgview)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 16)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(312, 200)
        Me.dbgview.TabIndex = 0
        '
        'tabpage2
        '
        Me.tabpage2.Controls.Add(Me.GroupBox2)
        Me.tabpage2.Location = New System.Drawing.Point(4, 22)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Size = New System.Drawing.Size(336, 230)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cobtoloc)
        Me.GroupBox2.Controls.Add(Me.cobfromloc)
        Me.GroupBox2.Controls.Add(Me.txtremarks)
        Me.GroupBox2.Controls.Add(Me.txtkms)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 224)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'cobtoloc
        '
        Me.cobtoloc.Location = New System.Drawing.Point(112, 72)
        Me.cobtoloc.Name = "cobtoloc"
        Me.cobtoloc.Size = New System.Drawing.Size(168, 21)
        Me.cobtoloc.TabIndex = 1
        '
        'cobfromloc
        '
        Me.cobfromloc.Location = New System.Drawing.Point(112, 24)
        Me.cobfromloc.Name = "cobfromloc"
        Me.cobfromloc.Size = New System.Drawing.Size(168, 21)
        Me.cobfromloc.TabIndex = 0
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(112, 160)
        Me.txtremarks.MaxLength = 40
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(168, 56)
        Me.txtremarks.TabIndex = 3
        Me.txtremarks.Text = ""
        '
        'txtkms
        '
        Me.txtkms.Location = New System.Drawing.Point(112, 112)
        Me.txtkms.MaxLength = 4
        Me.txtkms.Name = "txtkms"
        Me.txtkms.Size = New System.Drawing.Size(168, 20)
        Me.txtkms.TabIndex = 2
        Me.txtkms.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "kms *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Location *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From Location *"
        '
        'Distance_Mast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 261)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Distance_Mast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distance Master"
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
    Dim da As New OleDbDataAdapter("select * from Distance", con)
    Dim dv As New DataView
    Dim ds As New DataSet
    Dim recmode As EnuRecstatus
    Dim flag As Boolean
    Private Sub Distance_Mast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load
        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        TabControl1.SelectedTab = tabpage2
        lock()
        'fills the combo boxes from location master
        combofill1(cobfromloc, "select * from locationmaster")
        combofill1(cobtoloc, "select * from locationmaster")
    End Sub
    Public Sub lock()
        'locks the controls
        cobfromloc.Enabled = False
        cobtoloc.Enabled = False
        txtkms.ReadOnly = True
        txtremarks.ReadOnly = True
    End Sub
    '  this procedure clears the all text boxes and combo boxes
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox2.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        lock()
        cobfromloc.Focus()
    End Sub
    'this procedure checks the form status and set it to new mode
    Public Sub newproc()
        recmode = Module1.EnuRecstatus.Recnew
        clearproc()
        cobfromloc.Enabled = True
        cobtoloc.Enabled = True

        txtkms.ReadOnly = False
        txtremarks.ReadOnly = False
        TabControl1.SelectedTab = tabpage2
        cobfromloc.Focus()
    End Sub
    'for validation
    Public Sub valid()
        flag = False
        If cobfromloc.Text = "" Then
            MsgBox(" Select from location", MsgBoxStyle.OKOnly, Prjtitle)
            cobfromloc.Focus()
            Exit Sub
        End If
        If cobtoloc.Text = "" Then
            MsgBox(" Select to location", MsgBoxStyle.OKOnly, Prjtitle)
            cobtoloc.Focus()
            Exit Sub
        End If
        If txtkms.Text = "" Then
            MsgBox(" Enter kms", MsgBoxStyle.OKOnly, Prjtitle)
            txtkms.Focus()
            Exit Sub
        End If
        flag = True
    End Sub
    'this procedure inserts a new record  or update an existing record
    Public Sub saveproc()
        valid()

        Dim byt1, byt2 As Byte
        Dim b, c As String
        b = cobfromloc.Text
        c = (b.Substring(0, b.IndexOf("-")))
        Dim d, e As String
        d = cobtoloc.Text
        e = (d.Substring(0, d.IndexOf("-")))
        If flag = False Then Exit Sub
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Distance where FLocationID='" & c & "' and TLocationID='" & e & "' ", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    MsgRecexist()
                Else
                    cmd1 = New OleDbCommand("insert into Distance values('" & c & "','" & e & "','" & txtkms.Text & "','" & txtremarks.Text & "')", con)
                    byt1 = cmd1.ExecuteNonQuery()
                    cmd1.Dispose()
                    MsgSav()
                End If
            Else
                recmode = Module1.EnuRecstatus.Recedit
                Openconnection()
                cmd2 = New OleDbCommand("update Distance set Kms=" & txtkms.Text & ",remarks='" & txtremarks.Text & "'  where FLocationID='" & c & "' and TLocationID='" & e & "'", con)
                byt2 = cmd2.ExecuteNonQuery()
                MsgSav()
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
    ' this procedure enables fields and set form status as edit mode
    Public Sub editproc()
        recmode = Module1.EnuRecstatus.Recedit
        cobfromloc.Enabled = False
        cobtoloc.Enabled = False
        txtkms.ReadOnly = False
        txtremarks.ReadOnly = False
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'this procedure deletes a record
    Public Sub delproc()
        Dim byt As Byte
        Try
            Dim b, c As String
            b = cobfromloc.Text
            c = (b.Substring(0, b.IndexOf("-")))
            Dim d, e As String
            d = cobtoloc.Text
            e = (d.Substring(0, d.IndexOf("-")))
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "delete from Distance where FLocationID='" & c & "' and TLocationID='" & e & "'"
            cmd = New OleDbCommand(str, con)
            byt = cmd.ExecuteNonQuery()
            If byt > 0 Then
                MsgDel()
            Else
                MsgBox("Record Not Found", MsgBoxStyle.OKOnly, Prjtitle)
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
    'this procedure calls from module and uses o fill textboxes with numbers only
    Private Sub txtkms_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkms.KeyPress
        numberonly(e)

    End Sub
    'when tab control changes the index it goes to next tab
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ds.Clear()
        If TabControl1.SelectedTab.Text = "View" Then
            da.Fill(ds, "distance")
            dbgview.DataSource = ds.Tables("distance")
        End If
    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim str1, str2 As String
        Dim int As Integer
        Dim dr As OleDb.OleDbDataReader
        cobfromloc.Enabled = False
        cobtoloc.Enabled = False
        txtkms.ReadOnly = True
        txtremarks.ReadOnly = True
        'fills the current row index number in int
        int = dbgview.CurrentRowIndex
        str1 = dbgview.Item(int, 0)
        str2 = dbgview.Item(int, 1)
        Openconnection()
        cmd = New OleDbCommand("select * from Distance where FLocationID='" & str1 & "' and TLocationID='" & str2 & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            Dim a, b As String
            a = dr(0)
            comboselet(cobfromloc, a)
            b = dr(1)
            comboselet(cobtoloc, b)
            txtkms.Text = dr(2)
            txtremarks.Text = dr(3)
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
    Private Sub txtremarks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtremarks.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtremarks)
    End Sub

    Private Sub cobfromloc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobfromloc.KeyPress
        'allows to enter text only 
        textonly(e)
        combo(e)
    End Sub

    Private Sub cobtoloc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobtoloc.KeyPress
        'allows to enter text only 
        textonly(e)
        'doesnt allow to type data directly in the combo boxes
        combo(e)
    End Sub
    'fires a msgbox when both combo boxes have the same data
    Private Sub cobtoloc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobtoloc.Leave
        If cobfromloc.Text = cobtoloc.Text Then
            MsgBox("FROM location and TO location cannot be same", MsgBoxStyle.OKOnly, Prjtitle)
            cobtoloc.Focus()
        End If
    End Sub
End Class
