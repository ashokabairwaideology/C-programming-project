'Name developer: kamal.k.trood
'Dt:14/07/06
'Purpose :
'Version :1

Imports System.Data.OleDb
Public Class Hotel_Meal_Tariff
    Inherits System.Windows.Forms.Form
    Dim cmd, cmd1, cmd2 As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim recmode As EnuRecstatus   '  To findout record status
    Dim mealid As Integer
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcorporaterate As System.Windows.Forms.TextBox
    Friend WithEvents txtrackrate As System.Windows.Forms.TextBox
    Friend WithEvents cobmealplan As System.Windows.Forms.ComboBox
    Friend WithEvents cobhotelid As System.Windows.Forms.ComboBox
    Friend WithEvents cobhotelidfilter As System.Windows.Forms.ComboBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    Friend WithEvents txtmealid As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hotel_Meal_Tariff))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cobhotelidfilter = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtmealid = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtcorporaterate = New System.Windows.Forms.TextBox
        Me.txtrackrate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cobmealplan = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cobhotelid = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 192)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cobhotelidfilter)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(464, 167)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'cobhotelidfilter
        '
        Me.cobhotelidfilter.Location = New System.Drawing.Point(144, 16)
        Me.cobhotelidfilter.Name = "cobhotelidfilter"
        Me.cobhotelidfilter.Size = New System.Drawing.Size(144, 20)
        Me.cobhotelidfilter.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Hotel Id"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 48)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.Size = New System.Drawing.Size(448, 112)
        Me.dbgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(464, 167)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry/Edit"
        Me.TabPage2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtmealid)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.cobmealplan)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cobhotelid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 152)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'txtmealid
        '
        Me.txtmealid.Location = New System.Drawing.Point(296, 80)
        Me.txtmealid.Name = "txtmealid"
        Me.txtmealid.TabIndex = 14
        Me.txtmealid.Text = ""
        Me.txtmealid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcorporaterate)
        Me.GroupBox1.Controls.Add(Me.txtrackrate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 96)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rates"
        '
        'txtcorporaterate
        '
        Me.txtcorporaterate.Location = New System.Drawing.Point(96, 64)
        Me.txtcorporaterate.MaxLength = 5
        Me.txtcorporaterate.Name = "txtcorporaterate"
        Me.txtcorporaterate.Size = New System.Drawing.Size(104, 18)
        Me.txtcorporaterate.TabIndex = 3
        Me.txtcorporaterate.Text = ""
        '
        'txtrackrate
        '
        Me.txtrackrate.Location = New System.Drawing.Point(96, 32)
        Me.txtrackrate.MaxLength = 5
        Me.txtrackrate.Name = "txtrackrate"
        Me.txtrackrate.Size = New System.Drawing.Size(104, 18)
        Me.txtrackrate.TabIndex = 2
        Me.txtrackrate.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Corporate Rate *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rack Rate *"
        '
        'cobmealplan
        '
        Me.cobmealplan.Items.AddRange(New Object() {"BB", "HB", "FB"})
        Me.cobmealplan.Location = New System.Drawing.Point(296, 16)
        Me.cobmealplan.Name = "cobmealplan"
        Me.cobmealplan.Size = New System.Drawing.Size(144, 20)
        Me.cobmealplan.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Meal Plan *"
        '
        'cobhotelid
        '
        Me.cobhotelid.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobhotelid.Location = New System.Drawing.Point(64, 16)
        Me.cobhotelid.Name = "cobhotelid"
        Me.cobhotelid.Size = New System.Drawing.Size(144, 20)
        Me.cobhotelid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hotel Id *"
        '
        'Hotel_Meal_Tariff
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 197)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hotel_Meal_Tariff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Meal Tariff"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Hotel_Meal_Tariff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        'opens entry/edit page on pageload
        TabControl1.SelectedTab = TabPage2
        'fills the combobox from hotel_chain table
        combofill1(cobhotelid, "select hotelid,hotelname from hotelmaster")
        ' locks the controls
        lock()
    End Sub
    Public Sub lock()
        ' locks the controls
        cobhotelid.Enabled = False
        cobmealplan.Enabled = False
        txtrackrate.ReadOnly = True
        txtcorporaterate.ReadOnly = True
    End Sub
    'Clears the controls on the form
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
        cobhotelid.Enabled = True
        cobmealplan.Enabled = True
        txtrackrate.ReadOnly = False
        txtcorporaterate.ReadOnly = False
        'cursor gets into hotelid combobox
        TabControl1.SelectedTab = TabPage2
        cobhotelid.Focus()
    End Sub
    'To save or update a record 
    Public Sub saveproc()
        'checks whether the textboxes are empty
        If cobhotelid.Text = "" Then
            MsgBox(" Enter Hotel Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobhotelid.Focus()
            Exit Sub
        End If
        If cobmealplan.Text = "" Then
            MsgBox(" Enter Meal Plan", MsgBoxStyle.OKOnly, Prjtitle)
            cobmealplan.Focus()
            Exit Sub
        End If
        If txtrackrate.Text = "" Then
            MsgBox(" Enter Rack Rate", MsgBoxStyle.OKOnly, Prjtitle)
            txtrackrate.Focus()
            Exit Sub
        End If
        If txtcorporaterate.Text = "" Then
            MsgBox(" Enter Corporate Rate", MsgBoxStyle.OKOnly, Prjtitle)
            txtcorporaterate.Focus()
            Exit Sub
        End If
        Label1.Focus()
        Dim a, b As String
        'fills country id combobox from country master
        a = cobhotelid.Text
        b = (a.Substring(0, a.IndexOf("-")))
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                'initializing meal id for first time when rows in table are zero
                    cmd1 = New OleDb.OleDbCommand("select count(*) from meal_tariff", con)
                    mealid = cmd1.ExecuteScalar
                    cmd1.Dispose()
                    If mealid >= 1 Then
                        ' retrieving meal id 
                        cmd1 = New OleDb.OleDbCommand("select max(mealId) from meal_tariff ", con)
                        mealid = cmd1.ExecuteScalar
                        cmd1.Dispose()
                    End If
                    ' incrementing meal id
                    mealid = mealid + 1
                cmd1 = New OleDbCommand("insert into meal_tariff values(" & mealid & ",'" & b & "','" & cobmealplan.SelectedItem & "'," & txtrackrate.Text & "," & txtcorporaterate.Text & ")", con)
                    cmd1.ExecuteNonQuery()
                'Displays the updated message in messagebox
                MsgSav()
                'clears the controls
                clearproc()
                ' locks the controls
                lock()
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update meal_tariff set rate=" & txtrackrate.Text & ",corp_rate=" & txtcorporaterate.Text & " where mealid=" & txtmealid.Text & "", con)
                cmd2.ExecuteNonQuery()
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
    Public Sub editproc()
        'form status as edit mode
        recmode = Module1.EnuRecstatus.Recedit
        ' locks the controls
        cobhotelid.Enabled = False
        cobmealplan.Enabled = False
        ' unlocks the controls
        txtrackrate.ReadOnly = False
        txtcorporaterate.ReadOnly = False
        'cursor gets into rackrate textbox
        txtrackrate.Focus()
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    'deletes the particular record
    Public Sub delproc()
        Dim i As Byte
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str As String = "delete from meal_traiff where hotelid='" & cobhotelid.SelectedItem & "' and meal_plan='" & cobmealplan.SelectedItem & "'"
            cmd = New OleDbCommand(str, con)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgDel()
                'clears the controls
                clearproc()
                ' locks the controls
                lock()
            Else
                MsgBox("Record Not Found", MsgBoxStyle.OKOnly, Prjtitle)
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
        ds.Clear()
        If TabControl1.SelectedTab.Text = "View" Then
            da = New OleDbDataAdapter("select * from meal_tariff", con)
            da.Fill(ds, "meal_tariff")
            dbgview.DataSource = ds.Tables("meal_tariff")
            'fills the combobox in tabpage view with hotel id
            combofill1(cobhotelidfilter, "select hotelid,hotelname from hotelmaster")
            dbgview.ReadOnly = True
        End If
    End Sub
    'on click values of record in the datagrid comes on the form input controls
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick
        Dim x, hotel, hot As String
        Dim i, k As Integer
        Dim dr As OleDb.OleDbDataReader
        ' locks the controls
        lock()
        'clears the combobox
        cobhotelid.Text = ""
        cobmealplan.Text = ""
        'fills the current row index number in k
        k = dbgview.CurrentRowIndex
        'fills the value of row in i
        i = dbgview.Item(k, 0)
        'j = dbgview.Item(k, 1)
        Openconnection()
        cmd = New OleDbCommand("select * from meal_tariff where mealid=" & i & "", con)
        Try
            dr = cmd.ExecuteReader
            While dr.Read()
                txtmealid.Text = dr(0)
                x = dr(1)
                cobmealplan.Text = dr(2)
                txtrackrate.Text = dr(3)
                txtcorporaterate.Text = dr(4)

            End While
            con.Close()
            'hotel
            Openconnection()
            cmd1 = New OleDbCommand("select hotelname from hotelmaster where hotelid='" & x & "'", con)
            hotel = cmd1.ExecuteScalar
            hot = x & "-" & hotel
            cobhotelid.SelectedText = hot
            con.Close()
            'displays on entry/edit tabpage
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
    Private Sub cobhotelidfilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobhotelidfilter.SelectedIndexChanged
        ds.Clear()
        Dim a, b As String
        'fills country id combobox from country master
        a = cobhotelidfilter.Text
        b = (a.Substring(0, a.IndexOf("-")))
        da = New OleDbDataAdapter("select * from meal_tariff where hotelid='" & b & "'", con)
        da.Fill(ds, "meal_tariff")
        dbgview.DataSource = ds.Tables("meal_tariff")
    End Sub
    Private Sub txtrackrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrackrate.KeyPress
        Numb_Digit_Only(txtrackrate.Text, e)
    End Sub
    Private Sub txtcorporaterate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorporaterate.KeyPress
        Numb_Digit_Only(txtcorporaterate.Text, e)
    End Sub
    Private Sub cobhotelid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobhotelid.KeyPress, cobmealplan.KeyPress, cobhotelidfilter.KeyPress
        combo(e)
    End Sub
End Class
