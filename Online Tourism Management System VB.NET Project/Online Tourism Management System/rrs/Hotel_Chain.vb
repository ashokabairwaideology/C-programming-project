'STARTED ON 11-07-2006
'By Anil.N

Imports System.Data.OLEDB
Public Class Hotel_Chain
    Inherits System.Windows.Forms.Form
    Dim cmd, cmd1, cmd2 As New OleDbCommand
    Dim ds As New DataSet
    Dim t As New Form1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_hcname As System.Windows.Forms.TextBox
    Friend WithEvents txt_hcid As System.Windows.Forms.TextBox
    Friend WithEvents TBC_CHAINOFHOTELS As System.Windows.Forms.TabControl
    Friend WithEvents DBG As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotel_Chain))
        Me.TBC_CHAINOFHOTELS = New System.Windows.Forms.TabControl
        Me.Tabview = New System.Windows.Forms.TabPage
        Me.DBG = New System.Windows.Forms.DataGrid
        Me.Tabentry = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_remarks = New System.Windows.Forms.TextBox
        Me.txt_hcname = New System.Windows.Forms.TextBox
        Me.txt_hcid = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBC_CHAINOFHOTELS.SuspendLayout()
        Me.Tabview.SuspendLayout()
        CType(Me.DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabentry.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBC_CHAINOFHOTELS
        '
        Me.TBC_CHAINOFHOTELS.Controls.Add(Me.Tabview)
        Me.TBC_CHAINOFHOTELS.Controls.Add(Me.Tabentry)
        Me.TBC_CHAINOFHOTELS.Location = New System.Drawing.Point(0, 0)
        Me.TBC_CHAINOFHOTELS.Name = "TBC_CHAINOFHOTELS"
        Me.TBC_CHAINOFHOTELS.SelectedIndex = 0
        Me.TBC_CHAINOFHOTELS.Size = New System.Drawing.Size(328, 216)
        Me.TBC_CHAINOFHOTELS.TabIndex = 0
        '
        'Tabview
        '
        Me.Tabview.Controls.Add(Me.DBG)
        Me.Tabview.Location = New System.Drawing.Point(4, 22)
        Me.Tabview.Name = "Tabview"
        Me.Tabview.Size = New System.Drawing.Size(320, 190)
        Me.Tabview.TabIndex = 0
        Me.Tabview.Text = "View"
        '
        'DBG
        '
        Me.DBG.CaptionVisible = False
        Me.DBG.DataMember = ""
        Me.DBG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBG.Location = New System.Drawing.Point(3, 11)
        Me.DBG.Name = "DBG"
        Me.DBG.ReadOnly = True
        Me.DBG.Size = New System.Drawing.Size(304, 168)
        Me.DBG.TabIndex = 2
        '
        'Tabentry
        '
        Me.Tabentry.Controls.Add(Me.GroupBox1)
        Me.Tabentry.Location = New System.Drawing.Point(4, 22)
        Me.Tabentry.Name = "Tabentry"
        Me.Tabentry.Size = New System.Drawing.Size(320, 190)
        Me.Tabentry.TabIndex = 1
        Me.Tabentry.Text = "Entry / Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_remarks)
        Me.GroupBox1.Controls.Add(Me.txt_hcname)
        Me.GroupBox1.Controls.Add(Me.txt_hcid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(144, 112)
        Me.txt_remarks.MaxLength = 60
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(152, 56)
        Me.txt_remarks.TabIndex = 5
        '
        'txt_hcname
        '
        Me.txt_hcname.Location = New System.Drawing.Point(144, 72)
        Me.txt_hcname.MaxLength = 30
        Me.txt_hcname.Name = "txt_hcname"
        Me.txt_hcname.Size = New System.Drawing.Size(152, 21)
        Me.txt_hcname.TabIndex = 4
        '
        'txt_hcid
        '
        Me.txt_hcid.Location = New System.Drawing.Point(144, 32)
        Me.txt_hcid.MaxLength = 6
        Me.txt_hcid.Name = "txt_hcid"
        Me.txt_hcid.Size = New System.Drawing.Size(72, 21)
        Me.txt_hcid.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Remarks"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hotel Chain Name *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotel Chain Id *"
        '
        'Hotel_Chain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(328, 213)
        Me.Controls.Add(Me.TBC_CHAINOFHOTELS)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hotel_Chain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chain Of Hotel"
        Me.TBC_CHAINOFHOTELS.ResumeLayout(False)
        Me.Tabview.ResumeLayout(False)
        CType(Me.DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabentry.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
Private Sub Hotel_Chain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        '******************Form Load************************
        TBC_CHAINOFHOTELS.SelectedTab = Tabentry
        'Lock The controls
        txt_hcid.ReadOnly = True
        txt_hcname.ReadOnly = True
        txt_remarks.ReadOnly = True
    End Sub
    Public Sub clearproc()
        'Clears The Controls
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        txt_hcid.Focus()
    End Sub
    Public Sub lock()
        'To Lock The Controls
        txt_hcid.ReadOnly = True
        txt_hcname.ReadOnly = True
        txt_remarks.ReadOnly = True
    End Sub
    Public Sub newproc()
        'Form Status as New Mode
        recmode = Module1.EnuRecstatus.Recnew
        'Clears the Controls
        clearproc()
        'Unlock the controls
        txt_hcid.ReadOnly = False
        txt_hcname.ReadOnly = False
        txt_remarks.ReadOnly = False
        TBC_CHAINOFHOTELS.SelectedTab = Tabentry
        txt_hcid.Focus()
    End Sub
    Public Sub saveproc()
        'Textbox Validations
        If txt_hcid.Text = "" Then
            MsgBox("Enter Hotel Chain Id")
            txt_hcid.Focus()
            Exit Sub
        End If
        If txt_hcname.Text = "" Then
            MsgBox("Enter Hotel Chain Name")
            txt_hcname.Focus()
            Exit Sub
        End If
        Label1.Focus()
        'Data Base Checking Record is Exist or Not
        Try
            If recmode = Module1.EnuRecstatus.Recnew Then
                Openconnection()
                Dim X As Integer = 0
                cmd = New OleDbCommand("SELECT COUNT(*) FROM hotel_chain WHERE hot_chainid='" & txt_hcid.Text & " '", con)
                X = cmd.ExecuteScalar
                If X <> 0 Then
                    MsgRecexist()
                    clearproc()
                    lock()
                    Exit Sub
                Else
                    cmd1 = New OleDbCommand("insert into hotel_chain values('" & txt_hcid.Text & "','" & txt_hcname.Text & "','" & IIf(txt_remarks.Text = "", 0, txt_remarks.Text) & "')", con)
                    cmd1.ExecuteNonQuery()
                    lock()
                End If
            ElseIf recmode = Module1.EnuRecstatus.Recedit Then
                Openconnection()
                cmd2 = New OleDbCommand("update hotel_chain set  hot_chain_name ='" & txt_hcname.Text & "',remarks='" & txt_remarks.Text & "' WHERE hot_chainid='" & IIf(txt_hcid.Text = "", 0, txt_hcid.Text) & "'", con)
                cmd2.ExecuteNonQuery()
            End If
            MsgSav()
            clearproc()
            lock()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Sub editproc()
        'Edit Thr Record
        recmode = Module1.EnuRecstatus.Recedit
        'Lock The Control
        txt_hcid.ReadOnly = True
        'Unlock The Control
        txt_hcname.ReadOnly = False
        txt_remarks.ReadOnly = False
    End Sub
    Public Sub delproc()
        'Delete The Record
        Try
            If MsgDelAlert() = vbNo Then Exit Sub
            Openconnection()
            Dim str1 As String
            Dim x, y As Integer
            str1 = "select count(*) from hotelmaster where hot_chainid='" & txt_hcid.Text & "'"
            cmd = New OleDbCommand(str1, con)
            x = cmd.ExecuteScalar
            If x >= 1 Then
                MsgRecUsed()
                lock()
            Else
                Dim str As String = "delete from hotel_chain where hot_chainid='" & txt_hcid.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgDel()
                lock()
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
    Public Sub closeproc()
        'Form Closing
        Me.Close()
    End Sub
    Private Sub TBC_CHAINOFHOTELS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBC_CHAINOFHOTELS.Click
        ds.Clear()
        'Data Grid Filling
         Try
            Dim da As New OleDbDataAdapter("select * from hotel_chain", con)
            da.Fill(ds, "hotel_chain")
            DBG.DataSource = ds.Tables("hotel_chain")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            Exit Sub
        End Try
    End Sub

    Private Sub DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBG.DoubleClick
        'Filling Textboxes while clicking on datagrid
        Dim i As String
        Dim k As Integer
        Dim dr As OleDb.OleDbDataReader
        'Locks the controls
        txt_hcid.ReadOnly = True
        txt_hcname.ReadOnly = True
        txt_remarks.ReadOnly = True
        k = DBG.CurrentRowIndex
        i = DBG.Item(k, 0)
        Openconnection()
        cmd = New OleDbCommand("select * from hotel_chain where hot_chainid='" & i & "'", con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            txt_hcid.Text = dr(0)
            txt_hcname.Text = dr(1)
            txt_remarks.Text = dr(2)
            TBC_CHAINOFHOTELS.SelectedTab = Tabentry
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

    Private Sub txt_hcid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_hcid.Leave
        'Change the first letter into caps
        firstcap(txt_hcid)
    End Sub

    Private Sub txt_hcname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_hcname.Leave
        'Change the first letter into caps
        firstcap(txt_hcname)

    End Sub

    Private Sub txt_remarks_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_remarks.Leave
        'Change the first letter into caps
        firstcap(txt_remarks)
    End Sub

    Private Sub txt_hcname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hcname.KeyPress, txt_hcid.KeyPress
        'It takes only text and numbers
        textandnumbers(e)
    End Sub

    Private Sub DBG_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DBG.Navigate

    End Sub
End Class
