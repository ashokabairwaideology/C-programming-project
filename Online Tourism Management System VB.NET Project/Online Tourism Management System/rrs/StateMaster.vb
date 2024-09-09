'Name developer: baskar.ch
'Dt:26/06/06
'Purpose :
'Version :1

Imports System.Data.OleDb
Public Class StateMaster
    Inherits System.Windows.Forms.Form
    'Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0;user id=admin;data source=f:\kamal\travelz.mdb")
    Dim cmd, cmd1, cmd2 As OleDbCommand
    Dim da As New OleDbDataAdapter("select * from Statemaster", con)
    Dim ds As New DataSet
    Dim frmstatus As EnuRecstatus
   
    Dim dr1 As OleDbDataReader
    Dim dt1 As New DataTable
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstateid As System.Windows.Forms.TextBox
    Friend WithEvents txtstatename As System.Windows.Forms.TextBox
    Friend WithEvents cobcountry As System.Windows.Forms.ComboBox
    Friend WithEvents dbgview As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(StateMaster))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dbgview = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.cobcountry = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtstatename = New System.Windows.Forms.TextBox
        Me.txtstateid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(232, 136)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dbgview)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(224, 110)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'dbgview
        '
        Me.dbgview.CaptionVisible = False
        Me.dbgview.DataMember = ""
        Me.dbgview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgview.Location = New System.Drawing.Point(8, 8)
        Me.dbgview.Name = "dbgview"
        Me.dbgview.ReadOnly = True
        Me.dbgview.Size = New System.Drawing.Size(208, 96)
        Me.dbgview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cobcountry)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtstatename)
        Me.TabPage2.Controls.Add(Me.txtstateid)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(224, 110)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'cobcountry
        '
        Me.cobcountry.Location = New System.Drawing.Point(88, 72)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(116, 21)
        Me.cobcountry.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Country"
        '
        'txtstatename
        '
        Me.txtstatename.Location = New System.Drawing.Point(88, 40)
        Me.txtstatename.MaxLength = 25
        Me.txtstatename.Name = "txtstatename"
        Me.txtstatename.Size = New System.Drawing.Size(116, 21)
        Me.txtstatename.TabIndex = 1
        Me.txtstatename.Text = ""
        '
        'txtstateid
        '
        Me.txtstateid.Location = New System.Drawing.Point(88, 8)
        Me.txtstateid.MaxLength = 4
        Me.txtstateid.Name = "txtstateid"
        Me.txtstateid.Size = New System.Drawing.Size(116, 21)
        Me.txtstateid.TabIndex = 0
        Me.txtstateid.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "State ID *"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "State Name *"
        '
        'StateMaster
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(232, 133)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StateMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "State Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dbgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' after loading the form all form fileds are in diable mode
    Private Sub StateMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        
        TabControl1.SelectedTab = TabPage2
        'fills the combobox
        combofill1(cobcountry, "select * from countrymaster")
        'locks the controls
        lock()

    End Sub
    Public Sub lock()
        txtstateid.ReadOnly = True 'locks the controls
        txtstatename.ReadOnly = True
        cobcountry.Enabled = False
    End Sub
    'it clears all form fields
    Public Sub clearproc()

        Dim ctrl As Control
        For Each ctrl In Me.TabPage2.Controls
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

        txtstateid.ReadOnly = False ' unlocks the controls
        txtstatename.ReadOnly = False
        cobcountry.Enabled = True
        TabControl1.SelectedTab = TabPage2
        txtstateid.Focus() 'cursor gets into countryid textbox

    End Sub
    'To save or update a record 
    Public Sub saveproc()

        If txtstateid.Text = "" Then
            MsgBox(" Enter State Id", MsgBoxStyle.OKOnly, Prjtitle)
            txtstateid.Focus()
            Exit Sub
        End If
        If txtstatename.Text = "" Then
            MsgBox(" Enter State Name", MsgBoxStyle.OKOnly, Prjtitle)
            txtstatename.Focus()
            Exit Sub
        End If
        If cobcountry.Text = "" Then
            MsgBox(" Select Country Id", MsgBoxStyle.OKOnly, Prjtitle)
            cobcountry.Focus()
            Exit Sub
            Label1.Focus()
        End If

        Dim b, c As String
        b = cobcountry.SelectedItem
        c = (b.Substring(0, b.IndexOf("-")))
        Try
            If frmstatus = Module1.EnuRecstatus.Recnew Then
                Openconnection()

                Dim p As Integer = 0
                cmd = New OleDbCommand("select count(*) from Statemaster where stateid='" & txtstateid.Text & "'", con)
                p = cmd.ExecuteScalar
                If p <> 0 Then
                    MsgRecexist()
                Else
                    cmd1 = New OleDbCommand("insert into Statemaster values('" & txtstateid.Text & "','" & txtstatename.Text & "','" & c & "')", con)
                    cmd1.ExecuteNonQuery()
                End If

            ElseIf frmstatus = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update Statemaster set state='" & txtstatename.Text & "' where stateid='" & txtstateid.Text & "'", con)
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
    ' it is used to updating the record
    Public Sub editproc()

        frmstatus = Module1.EnuRecstatus.Recedit  'form status as edit mode
        txtstateid.ReadOnly = True  'locks the control
        txtstatename.ReadOnly = False 'unlocks the control
        cobcountry.Enabled = False

    End Sub
    Public Sub printproc()

        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)

    End Sub
    'deletes the particular record
    Public Sub delproc()

        Dim i, k As Integer

        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            cmd = New OleDbCommand("select count(*) from CityMaster where StateId='" & txtstateid.Text & "'", con)
            k = cmd.ExecuteScalar()
            cmd.Dispose()
            If k >= 1 Then
                MsgRecUsed()
            Else
                Dim str As String = "delete from Statemaster where stateid='" & txtstateid.Text & "'"
                cmd = New OleDbCommand(str, con)
                i = cmd.ExecuteNonQuery()

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
    Private Sub txtstateid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstateid.KeyPress

        textandnumbers(e)

    End Sub
    'allows to enter text only 
    Private Sub txtstatename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstatename.KeyPress

        textonly(e)

    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtstateid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstateid.Leave

        firstcap(txtstateid)

    End Sub
    ' uses to enter the first letter as capital letter
    Private Sub txtstatename_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstatename.Leave

        firstcap(txtstatename)

    End Sub
    'it fills the data into datagrid 
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            If TabControl1.SelectedTab.Text = "View" Then
                ReDim Preserve ar(2)
                ReDim Preserve wid(2)

                ar(0) = "StateId"
                wid(0) = 65

                ar(1) = "StateName"
                wid(1) = 100

                ar(2) = "CountryId"
                wid(2) = 65
                '
                'To  The Coloumn Name
                '
                colname("select * from statemaster", dbgview, ar)
                '
                'To The Coloumn Width
                '
                colwidth("select * from statemaster", dbgview, wid)





            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        con.Close()

    End Sub
    'it fills the data of selected row into form fields
    Private Sub dbgview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbgview.DoubleClick

        Dim i As String
        Dim k As Integer
        Dim str_coun As String
        Dim dr As OleDb.OleDbDataReader 'on click values of record in the datagrid comes on the form
        lock()
        cobcountry.Text = ""
        k = dbgview.CurrentRowIndex
        i = dbgview.Item(k, 0)
        If con.State <> ConnectionState.Open Then
            Openconnection()
        End If
        cmd = New OleDbCommand("select * from Statemaster where stateid='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            txtstateid.Text = dr(0)
            txtstatename.Text = dr(1)
            str_coun = dr(2)
            comboselet(cobcountry, str_coun)
            TabControl1.SelectedTab = TabPage2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
        ' enabling and disabling of tool bar  butoons when viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()

    End Sub


    Private Sub cobcountry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobcountry.KeyPress
        combo(e)
    End Sub
End Class
