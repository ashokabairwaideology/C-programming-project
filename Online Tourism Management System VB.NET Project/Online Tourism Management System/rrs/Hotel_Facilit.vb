'Name developer: Emma Christeena.B
'Dt:28/06/06
'Purpose :
'Version :1
Imports System.Data.OleDb
Public Class Hotel_Facilit
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
    Friend WithEvents tabpage1 As System.Windows.Forms.TabPage
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cobunit As System.Windows.Forms.ComboBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cobratetype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfacility As System.Windows.Forms.TextBox
    Friend WithEvents txtfacilitycode As System.Windows.Forms.TextBox
    Friend WithEvents cobhotel As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hotel_Facilit))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabpage1 = New System.Windows.Forms.TabPage
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cobunit = New System.Windows.Forms.ComboBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdes = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtfacility = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cobratetype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtfacilitycode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cobhotel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tabpage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpage1)
        Me.TabControl1.Controls.Add(Me.tabpage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 224)
        Me.TabControl1.TabIndex = 1
        '
        'tabpage1
        '
        Me.tabpage1.Controls.Add(Me.dbgview)
        Me.tabpage1.Location = New System.Drawing.Point(4, 22)
        Me.tabpage1.Name = "tabpage1"
        Me.tabpage1.Size = New System.Drawing.Size(520, 198)
        Me.tabpage1.TabIndex = 0
        Me.tabpage1.Text = "View"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.Dock = System.Windows.Forms.DockStyle.Top
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(0, 0)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(520, 224)
        Me.dbgview.TabIndex = 0
        '
        'tabpage2
        '
        Me.tabpage2.Controls.Add(Me.GroupBox1)
        Me.tabpage2.Location = New System.Drawing.Point(4, 22)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Size = New System.Drawing.Size(520, 198)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "Entry / Edit"
        Me.tabpage2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cobunit)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtfacility)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cobratetype)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtfacilitycode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cobhotel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cobunit
        '
        Me.cobunit.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cobunit.Location = New System.Drawing.Point(80, 80)
        Me.cobunit.Name = "cobunit"
        Me.cobunit.Size = New System.Drawing.Size(56, 21)
        Me.cobunit.TabIndex = 5
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(80, 112)
        Me.txtamount.MaxLength = 5
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(136, 21)
        Me.txtamount.TabIndex = 6
        Me.txtamount.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Amount * "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "No of Hours or days"
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(360, 120)
        Me.txtdes.MaxLength = 50
        Me.txtdes.Multiline = True
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(144, 64)
        Me.txtdes.TabIndex = 7
        Me.txtdes.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Description"
        '
        'txtfacility
        '
        Me.txtfacility.Location = New System.Drawing.Point(80, 48)
        Me.txtfacility.MaxLength = 20
        Me.txtfacility.Name = "txtfacility"
        Me.txtfacility.Size = New System.Drawing.Size(136, 21)
        Me.txtfacility.TabIndex = 3
        Me.txtfacility.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Facility *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Unit *"
        '
        'cobratetype
        '
        Me.cobratetype.Items.AddRange(New Object() {"Day", "Hour"})
        Me.cobratetype.Location = New System.Drawing.Point(360, 48)
        Me.cobratetype.Name = "cobratetype"
        Me.cobratetype.Size = New System.Drawing.Size(144, 21)
        Me.cobratetype.Sorted = True
        Me.cobratetype.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rate Type *"
        '
        'txtfacilitycode
        '
        Me.txtfacilitycode.Location = New System.Drawing.Point(360, 16)
        Me.txtfacilitycode.MaxLength = 6
        Me.txtfacilitycode.Name = "txtfacilitycode"
        Me.txtfacilitycode.Size = New System.Drawing.Size(144, 21)
        Me.txtfacilitycode.TabIndex = 2
        Me.txtfacilitycode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Facility Code *"
        '
        'cobhotel
        '
        Me.cobhotel.Location = New System.Drawing.Point(80, 16)
        Me.cobhotel.MaxLength = 5
        Me.cobhotel.Name = "cobhotel"
        Me.cobhotel.Size = New System.Drawing.Size(136, 21)
        Me.cobhotel.Sorted = True
        Me.cobhotel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotel *"
        '
        'Hotel_Facilit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(530, 229)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hotel_Facilit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Facilities"
        Me.TabControl1.ResumeLayout(False)
        Me.tabpage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cmd, cmd1 As OleDbCommand
    Dim dr As OleDbDataReader
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim bolvali As Boolean
    Dim recmode As EnuRecstatus
    Private Sub Hotel_Facilit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load
        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'opens entry/edit page on pageload
        TabControl1.SelectedTab = tabpage2
        '------below code brings data from hotelmaster table and fill in the combo boxe------'
        combofill1(cobhotel, "select * from HotelMaster")
        ' locks the controls
        Lock()
    End Sub
    'locks the controls
    Public Sub lock()
        cobhotel.Enabled = False
        cobunit.Enabled = False
        cobratetype.Enabled = False
        txtfacilitycode.ReadOnly = True
        txtamount.ReadOnly = True
        txtfacility.ReadOnly = True
        txtdes.ReadOnly = True
    End Sub
    '  this procedure clears the all text boxes and combo boxes
    Public Sub clearproc()
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        lock()
    End Sub
    'this procedure checks the form status and set it to new mode
    Public Sub newproc()
        'form status as new mode
        recmode = Module1.EnuRecstatus.Recnew
        ' unlocks the controls
        cobhotel.Enabled = True
        cobunit.Enabled = True
        cobratetype.Enabled = True
        txtfacilitycode.ReadOnly = False
        txtamount.ReadOnly = False
        txtfacility.ReadOnly = False
        txtdes.ReadOnly = False
        'opens entry/edit page on pageload
        TabControl1.SelectedTab = tabpage2

        'cursor gets into hotelid combobox
        cobhotel.Focus()
    End Sub
    'To save or update a record 
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        'locks the controls
        cobhotel.Enabled = False
        txtfacilitycode.ReadOnly = True
        'unlocks the controls
        cobunit.Enabled = True
        cobratetype.Enabled = True
        txtamount.ReadOnly = False
        txtfacility.ReadOnly = False
        txtdes.ReadOnly = False
    End Sub
    'to check the validations
    Public Sub valid()
        bolvali = False
        If cobhotel.Text = "" Then
            MsgBox(" Enter hotel Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobhotel.Focus()
            Exit Sub
        End If
        If txtfacilitycode.Text = "" Then
            MsgBox(" Enter facility code", MsgBoxStyle.OKOnly, Prjtitle)
            txtfacilitycode.Focus()
            Exit Sub
        End If
        If txtfacility.Text = "" Then
            MsgBox(" Enter facility", MsgBoxStyle.OKOnly, Prjtitle)
            txtfacility.Focus()
            Exit Sub
        End If
        If cobratetype.Text = "" Then
            MsgBox(" Enter rate type", MsgBoxStyle.OKOnly, Prjtitle)
            cobratetype.Focus()
            Exit Sub
        End If
        If cobunit.Text = "" Then
            MsgBox(" Enter units", MsgBoxStyle.OKOnly, Prjtitle)
            cobunit.Focus()
            Exit Sub
        End If
        If txtamount.Text = "" Then
            MsgBox(" Enter amount", MsgBoxStyle.OKOnly, Prjtitle)
            txtamount.Focus()
            Exit Sub
        End If
        bolvali = True
    End Sub
    'inserts or updates a record
    Public Sub saveproc()
        valid()
        If bolvali = False Then Exit Sub
        Dim str1, str2 As String
        'saves data before the "-" hotel id combobox
        str1 = cobhotel.Text
        str2 = (str1.Substring(0, str1.IndexOf("-")))
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Hotel_Facilit where FacilitId='" & txtfacilitycode.Text & "'", con)
                p = cmd.ExecuteScalar
                cmd.Dispose()
                If p <> 0 Then
                    MsgBox("Record  already exists", MsgBoxStyle.OKOnly, Prjtitle)
                Else
                    cmd = New OleDbCommand("insert into Hotel_Facilit values('" & txtfacilitycode.Text & "','" & txtfacility.Text & "','" & str2 & "','" & cobratetype.Text & "','" & cobunit.Text & "','" & txtamount.Text & "','" & txtdes.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    'Displays the updated message in messagebox
                    MsgSav()
                    'clears the controls
                    clearproc()
                    ' locks the controls
                    lock()
                End If
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                If con.State <> ConnectionState.Open Then
                    Openconnection()
                End If
                cmd = New OleDbCommand("update Hotel_Facilit set Facility='" & txtfacility.Text & "',HotelId='" & str2 & "',Rate_Type='" & cobratetype.Text & "',Unit='" & cobunit.Text & "',Amount='" & txtamount.Text & "',Descript='" & txtdes.Text & "' where FacilitId='" & txtfacilitycode.Text & "'", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'Displays the updated message in messagebox
                MsgSav()
                'clears the controls
                clearproc()
                ' locks the controls
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
    'deletes the particular record
    Public Sub delproc()
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "delete from Hotel_Facilit where FacilitId='" & txtfacilitycode.Text & "'"
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Displays record deleted message in messagebox
            MsgDel()
            'clears the controls
            clearproc()
            ' locks the controls
            lock()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    'when tab control changes the index it goes to next tab
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim da As New OleDbDataAdapter("select * from Hotel_Facilit", con)
        ds.Clear()
        If TabControl1.SelectedTab.Text = "View" Then
            da.Fill(ds, "Hotel_Facilit")
            dbgview.DataSource = ds.Tables("Hotel_Facilit")
        End If
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    Private Sub dbgview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim str, a As String
        Dim int As Integer
        Dim dr As OleDb.OleDbDataReader
        ' locks the controls
        lock()
        'fills the current row index number in int
        int = dbgview.CurrentRowIndex
        'fills the value of row in str
        str = dbgview.Item(int, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from Hotel_Facilit where FacilitId='" & str & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            a = dr(2)
            comboselet(cobhotel, a)
            txtfacilitycode.Text = dr(0)
            txtfacility.Text = dr(1)
            cobratetype.Text = dr(3)
            cobunit.Text = dr(4)
            txtamount.Text = dr(5)
            txtdes.Text = dr(6)
            'displays on entry/edit tabpage
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
    Private Sub cobhotel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotel.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub
    Private Sub cobratetype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobratetype.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub
    Private Sub cobunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobunit.KeyPress
        'doesnt allow to type data in the combo box
        combo(e)
    End Sub

    Private Sub txtdes_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdes.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtdes)
    End Sub

    Private Sub txtfacility_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfacility.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtfacility)
    End Sub

    Private Sub txtfacilitycode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfacilitycode.Leave
        'makes first letter in textbox as capital letter
        firstcap(txtfacilitycode)
    End Sub

    Private Sub txtfacility_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfacility.KeyPress
        'allows to enter text only 
        textonly(e)
    End Sub

    Private Sub txtfacilitycode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfacilitycode.KeyPress
        'allows to enter both text and numbers
        textandnumbers(e)
    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        'allows to enter numbers only 
        numberonly(e)
    End Sub
End Class
