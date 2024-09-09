'SHIVA KUMAR    
'DATE 11/07/2006
Imports System.Data.OleDb
Public Class Hotel_Room_Tariff
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter("select * from Room_Tariff", con)
    Dim transid As Integer
    Dim dt As Date
    Dim dr As OleDbDataReader
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cobhotel As System.Windows.Forms.ComboBox
    Friend WithEvents dg2 As System.Windows.Forms.DataGrid
    Friend WithEvents txtroomfaci As System.Windows.Forms.TextBox
    Friend WithEvents cobroomcat As System.Windows.Forms.ComboBox
    Friend WithEvents cobhotelid As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cobbedtype As System.Windows.Forms.ComboBox
    Friend WithEvents rbppeak As System.Windows.Forms.RadioButton
    Friend WithEvents rbolow As System.Windows.Forms.RadioButton
    Friend WithEvents rbohigh As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcorprate As System.Windows.Forms.TextBox
    Friend WithEvents txtrackrate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbohalfboard As System.Windows.Forms.RadioButton
    Friend WithEvents rbnofullbord As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hotel_Room_Tariff))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cobhotel = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dg2 = New System.Windows.Forms.DataGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbohalfboard = New System.Windows.Forms.RadioButton
        Me.rbnofullbord = New System.Windows.Forms.RadioButton
        Me.cobbedtype = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcorprate = New System.Windows.Forms.TextBox
        Me.txtrackrate = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbolow = New System.Windows.Forms.RadioButton
        Me.rbohigh = New System.Windows.Forms.RadioButton
        Me.rbppeak = New System.Windows.Forms.RadioButton
        Me.txtroomfaci = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cobroomcat = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cobhotelid = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(520, 328)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cobhotel)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dg2)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(512, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View"
        '
        'cobhotel
        '
        Me.cobhotel.Location = New System.Drawing.Point(136, 16)
        Me.cobhotel.Name = "cobhotel"
        Me.cobhotel.Size = New System.Drawing.Size(144, 20)
        Me.cobhotel.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Hotel"
        '
        'dg2
        '
        Me.dg2.CaptionVisible = False
        Me.dg2.DataMember = ""
        Me.dg2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg2.Location = New System.Drawing.Point(8, 48)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.Size = New System.Drawing.Size(496, 232)
        Me.dg2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(512, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entry / Edit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.cobbedtype)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.txtroomfaci)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cobroomcat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cobhotelid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 288)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbohalfboard)
        Me.GroupBox1.Controls.Add(Me.rbnofullbord)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 56)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Board"
        '
        'rbohalfboard
        '
        Me.rbohalfboard.Location = New System.Drawing.Point(120, 24)
        Me.rbohalfboard.Name = "rbohalfboard"
        Me.rbohalfboard.Size = New System.Drawing.Size(80, 16)
        Me.rbohalfboard.TabIndex = 1
        Me.rbohalfboard.Text = "Half Board"
        '
        'rbnofullbord
        '
        Me.rbnofullbord.Checked = True
        Me.rbnofullbord.Location = New System.Drawing.Point(16, 24)
        Me.rbnofullbord.Name = "rbnofullbord"
        Me.rbnofullbord.Size = New System.Drawing.Size(72, 16)
        Me.rbnofullbord.TabIndex = 0
        Me.rbnofullbord.TabStop = True
        Me.rbnofullbord.Text = "Full Board"
        '
        'cobbedtype
        '
        Me.cobbedtype.Items.AddRange(New Object() {"Single Bed", "Twin Bed", "Queen Bed", "Tripple Bed", "Queen + Extra Bed"})
        Me.cobbedtype.Location = New System.Drawing.Point(96, 80)
        Me.cobbedtype.Name = "cobbedtype"
        Me.cobbedtype.Size = New System.Drawing.Size(120, 20)
        Me.cobbedtype.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Bed Type *"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtcorprate)
        Me.GroupBox5.Controls.Add(Me.txtrackrate)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(256, 104)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rate"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(40, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Corporate Rate"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(64, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rack Rate"
        '
        'txtcorprate
        '
        Me.txtcorprate.Location = New System.Drawing.Point(128, 56)
        Me.txtcorprate.Name = "txtcorprate"
        Me.txtcorprate.Size = New System.Drawing.Size(104, 18)
        Me.txtcorprate.TabIndex = 1
        Me.txtcorprate.Text = ""
        '
        'txtrackrate
        '
        Me.txtrackrate.Location = New System.Drawing.Point(128, 16)
        Me.txtrackrate.Name = "txtrackrate"
        Me.txtrackrate.Size = New System.Drawing.Size(104, 18)
        Me.txtrackrate.TabIndex = 0
        Me.txtrackrate.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbolow)
        Me.GroupBox4.Controls.Add(Me.rbohigh)
        Me.GroupBox4.Controls.Add(Me.rbppeak)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 56)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Season"
        '
        'rbolow
        '
        Me.rbolow.Location = New System.Drawing.Point(176, 24)
        Me.rbolow.Name = "rbolow"
        Me.rbolow.Size = New System.Drawing.Size(56, 16)
        Me.rbolow.TabIndex = 2
        Me.rbolow.Text = "Low"
        '
        'rbohigh
        '
        Me.rbohigh.Location = New System.Drawing.Point(96, 24)
        Me.rbohigh.Name = "rbohigh"
        Me.rbohigh.Size = New System.Drawing.Size(56, 16)
        Me.rbohigh.TabIndex = 1
        Me.rbohigh.Text = "High"
        '
        'rbppeak
        '
        Me.rbppeak.Checked = True
        Me.rbppeak.Location = New System.Drawing.Point(24, 24)
        Me.rbppeak.Name = "rbppeak"
        Me.rbppeak.Size = New System.Drawing.Size(48, 16)
        Me.rbppeak.TabIndex = 0
        Me.rbppeak.TabStop = True
        Me.rbppeak.Text = "Peak"
        '
        'txtroomfaci
        '
        Me.txtroomfaci.Location = New System.Drawing.Point(288, 192)
        Me.txtroomfaci.Multiline = True
        Me.txtroomfaci.Name = "txtroomfaci"
        Me.txtroomfaci.Size = New System.Drawing.Size(192, 88)
        Me.txtroomfaci.TabIndex = 3
        Me.txtroomfaci.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Room Facilities"
        '
        'cobroomcat
        '
        Me.cobroomcat.Location = New System.Drawing.Point(96, 48)
        Me.cobroomcat.Name = "cobroomcat"
        Me.cobroomcat.Size = New System.Drawing.Size(120, 20)
        Me.cobroomcat.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Room Category *"
        '
        'cobhotelid
        '
        Me.cobhotelid.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobhotelid.Location = New System.Drawing.Point(96, 16)
        Me.cobhotelid.Name = "cobhotelid"
        Me.cobhotelid.Size = New System.Drawing.Size(120, 20)
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
        'Hotel_Room_Tariff
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 325)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hotel_Room_Tariff"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Room Tariff"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim recmode As EnuRecstatus
    Public Sub clearproc()
        cobhotelid.SelectedItem = ""
        cobhotelid.Text = ""
        txtroomfaci.Text = ""
        rbppeak.Checked = True
        cobroomcat.SelectedItem = ""
        cobroomcat.Text = ""
        cobbedtype.SelectedItem = ""
        cobbedtype.Text = ""

        txtrackrate.Text = ""
        txtcorprate.Text = ""
       
    End Sub
    Public Sub enable()
        txtcorprate.Enabled = True
        txtrackrate.Enabled = True
        cobbedtype.Enabled = True
        cobhotel.Enabled = True
        cobhotelid.Enabled = True
        cobroomcat.Enabled = True
        rbnofullbord.Enabled = True
        rbohalfboard.Enabled = True
        rbohigh.Enabled = True
        rbolow.Enabled = True
        rbppeak.Enabled = True
        txtroomfaci.Enabled = True

    End Sub


    Public Sub disable()
        txtroomfaci.Enabled = False

        cobhotelid.Enabled = False
        cobroomcat.Enabled = False
        cobbedtype.Enabled = False
        txtrackrate.Enabled = False
        txtcorprate.Enabled = False
        txtroomfaci.Enabled = False
        rbnofullbord.Enabled = False
        rbohalfboard.Enabled = False
        rbohigh.Enabled = False
        rbolow.Enabled = False
        rbppeak.Enabled = False
    End Sub
    Public Sub newproc()
        enable()

        'dg2.Enabled = True

        txtroomfaci.Text = ""
        txtcorprate.Text = ""
        txtrackrate.Text = ""

        cobbedtype.SelectedItem = ""
        cobhotel.SelectedItem = ""
        cobhotelid.SelectedItem = ""

        cobbedtype.Text = ""
        cobhotel.Text = ""
        cobhotelid.Text = ""

        recmode = Module1.EnuRecstatus.Recnew
    End Sub
    Public Sub saveproc()
        Dim a, b, season As String
        Dim strboard As String

        Dim l As Integer = 0
        Dim maxno As Integer
        If cobhotelid.Text = "" Then
            MsgBox("Enter Hotel Id")
            Exit Sub
        End If
        If cobroomcat.Text = "" Then
            MsgBox("Enter Room Catagory")
            Exit Sub
        End If


        If cobbedtype.Text = "" Then
            MsgBox("Enter Bed Type")
            Exit Sub
        End If


        If txtrackrate.Text = "" Then
            MsgBox("Enter Rack Rate")
            Exit Sub
        End If
        If txtcorprate.Text = "" Then
            MsgBox("Enter Corporate Rate")
            Exit Sub
        End If


        If rbohalfboard.Checked = True Then
            strboard = "HalfBoard"
        End If
        If rbnofullbord.Checked = True Then
            strboard = "FullBoard"
        End If
        If recmode = Module1.EnuRecstatus.Recnew Then
            '
            'To select the Unique Transid for the record
            '
            Openconnection()
            Dim cd As New OleDbCommand("select count(*) from room_tariff", con)
            Try

                l = cd.ExecuteScalar()
                If l = 0 Then
                    maxno = 1
                Else
                    maxno = l + 1
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                CloseConnection()
                Exit Sub
            Finally
                CloseConnection()
            End Try

            Dim i As Integer
            Dim hid, rcat, bedtype, custype As String

            b = cobhotelid.SelectedItem
            hid = (b.Substring(0, b.IndexOf("-")))

            rcat = Trim(cobroomcat.SelectedItem)
            bedtype = Trim(cobbedtype.SelectedItem)

            If rbppeak.Checked = True Then
                season = "Peak"
            End If
            If rbohigh.Checked = True Then
                season = "High"
            End If
            If rbolow.Checked = True Then
                season = "Low"
            End If
            Dim p As Integer = 0
            '
            'search for the record already exists or not with same data
            'Return 1 if exists else return 0
            Openconnection()
            Dim cmd1 As New OleDbCommand("select count(*) from room_tariff where hotelid='" & Trim(hid) & "' and Rcatg_id='" & rcat & "' and bed_type='" & bedtype & "' and season='" & season & "' and board='" & Trim(strboard) & "'", con)

            p = cmd1.ExecuteScalar()
            CloseConnection()
            If p = 0 Then

                'insert the record if it is not exists
                '
                Try
                    Openconnection()
                    Dim cmd2 As New OleDbCommand("insert into Room_Tariff  values(" & maxno & ",'" & hid & "','" & rcat & "','" & bedtype & "','" & season & "','" & strboard & "'," & IIf(txtrackrate.Text = "", 0, txtrackrate.Text) & "," & IIf(txtcorprate.Text = "", 0, txtcorprate.Text) & ",'" & IIf(txtroomfaci.Text = "", " ", txtroomfaci.Text) & "','" & dt & "','Y','" & Muserid & "','" & dt & "' )", con)

                    cmd2.ExecuteNonQuery()
                    MsgSav()
                    clearproc()

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                    CloseConnection()
                    Exit Sub
                Finally
                    CloseConnection()
                End Try
            Else
                MsgRecexist()
            End If

        End If
        '
        'if record mode is in edit this will execute
        '
        If recmode = Module1.EnuRecstatus.Recedit Then

            If rbppeak.Checked = True Then
                season = "Peak"
            End If
            If rbohigh.Checked = True Then
                season = "High"
            End If
            If rbolow.Checked = True Then
                season = "Low"
            End If
            a = cobhotelid.SelectedItem
            b = (a.Substring(0, a.IndexOf("-")))
            Openconnection()
            Dim cmd3 As New OleDbCommand("update Room_Tariff Set Hotelid='" & b & "',Rcatg_id='" & cobroomcat.SelectedItem & "',Bed_Type='" & cobbedtype.SelectedItem & "',Season='" & season & "' where transid=" & transid & " and board='" & strboard & "'", con)


            Dim cmd4 As New OleDbCommand("update Room_Tariff Set RackRate=" & CInt(txtrackrate.Text) & ",CropRate=" & CInt(txtcorprate.Text) & ",facilites='" & txtroomfaci.Text & "' where transid=" & transid & "and Board='" & strboard & "' ", con)
            Try

                cmd3.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                MsgSav()
                clearproc()

                cobhotelid.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
                CloseConnection()
                Exit Sub

            End Try
            CloseConnection()
        End If


    End Sub
    Public Sub delproc()
        '
        'To Delete the Record with Hotel id
        '
        Dim season As String
        If rbppeak.Checked = True Then
            season = "Peak"
        End If
        If rbohigh.Checked = True Then
            season = "High"
        End If
        If rbolow.Checked = True Then
            season = "Low"
        End If
        Try
            Dim exists As Integer

            Openconnection()

            If MsgDelAlert() = vbNo Then Exit Sub
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("select count(*) from Cust_Hotel where trim(TransId)='" & Trim(transid) & "'", con)
            exists = cmd.ExecuteScalar()
            cmd.Dispose()
            If exists > 0 Then
                cmd = New OleDbCommand("update room_tariff set  effect_upto='" & dt & "', actflag= 'N' where trim(transid)='" & Trim(transid) & "'", con)
                MsgBox("Record Cannot Be Deleted")
                Exit Sub
            Else

                cmd = New OleDbCommand("delete * from room_Tariff where transid=" & transid & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgDel()
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
    Private Sub Hotel_Room_Tariff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        disable()

        ' Tool Bar buttons enabled and  disabled  while form load

        Dim objfrmmdi As Object
        objfrmmdi = Me.MdiParent
        objfrmmdi.setfrmload()

        dt = Now.Date

        Try

            Openconnection()
            Dim cmd As New OleDbCommand("select * from room_catg", con)
            Dim dr As OleDbDataReader

            dr = cmd.ExecuteReader
            While dr.Read
                cobroomcat.Items.Add(dr(1))
            End While
            dr.Close()
            CloseConnection()
            '
            'To Store data into the hotel combobox in tabpage 1
            '
            combofill1(cobhotelid, "select * from hotelmaster")




            cobhotelid.Enabled = False
            cobroomcat.Enabled = False
            TabControl1.SelectedTab = TabPage2
            'da = New OleDbDataAdapter("select TransId,Hotelid,RCatg_id,Bed_Type,Season,Board,RackRate,CropRate,Actflag from room_tariff", con)
            'da.Fill(ds, "roomtariff")
            'dg2.DataSource = ds.Tables("roomtariff")
            ''dg2.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
    End Sub
    Private Sub cobhotel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cobhotel.SelectedIndexChanged
        Dim a, b As String
        a = cobhotel.SelectedItem
        b = (a.Substring(0, a.IndexOf("-")))

        Dim str As String
        ds.Clear()
        Openconnection()
        str = cobhotel.SelectedItem
        Dim da As New OleDbDataAdapter("select TransId,Hotelid,RCatg_id,Bed_Type,Season,Board,RackRate,CropRate,Actflag from Room_Tariff where trim(Hotelid)='" & b & "'", con)


        da.Fill(ds, "roomtariff")
        CloseConnection()
        dg2.DataSource = ds.Tables("roomtariff")
    End Sub

    Private Sub dg2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg2.DoubleClick
        'Dim p As String
        disable()

        Dim hid As String
        transid = Trim(dg2.Item(dg2.CurrentCell.RowNumber, 0))
        Openconnection()
        Dim cmd As New OleDbCommand("select * from Room_Tariff where Transid=" & transid & "", con)
        Try

            Dim dr As OleDbDataReader

            dr = cmd.ExecuteReader
            While dr.Read
                transid = dr(0)
                hid = dr(1)

                cobroomcat.SelectedItem = dr(2)
                cobroomcat.Text = dr(2)
                cobbedtype.SelectedItem = dr(3)
                cobbedtype.Text = dr(3)

                If dr(4) = "Peak" Then
                    rbppeak.Checked = True
                End If
                If dr(4) = "Low" Then
                    rbolow.Checked = True
                End If
                If dr(4) = "High" Then
                    rbohigh.Checked = True
                End If
                If dr(5) = "FullBoard" Then
                    rbnofullbord.Checked = True
                End If
                If dr(5) = "HalfBoard" Then
                    rbohalfboard.Checked = True
                End If
                txtrackrate.Text = dr(6)
                txtcorprate.Text = dr(7)
                txtroomfaci.Text = dr(8)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        Finally
            CloseConnection()
        End Try
        Openconnection()
        cmd = New OleDbCommand("select hotelid,hotelname from hotelmaster where trim(hotelid)='" & hid & "'", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            cobhotelid.SelectedItem = dr(0) & "-" & dr(1)
            cobhotelid.Text = dr(0) & "-" & dr(1)

        End If
        dr.Close()
        CloseConnection()

        'Tool Bar buttons enabled and  disabled  while viewing the record.
        Dim objfrmmdi1 As Object
        objfrmmdi1 = Me.MdiParent
        objfrmmdi1.setdblclick()
        TabControl1.SelectedTab = TabPage2


    End Sub
    Public Sub editproc()
        enable()
        cobhotelid.Enabled = False


        recmode = Module1.EnuRecstatus.Recedit
    End Sub
    Private Sub txtcorprate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorprate.KeyPress, txtrackrate.KeyPress
        numberonly(e)
    End Sub
    Private Sub txtroomfaci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtroomfaci.KeyPress
        textandnumbers(e)
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click, TabControl1.TabIndexChanged




        If TabControl1.SelectedTab.Text = "View" Then
            Dim colarrynm(15) As String
            Dim colarrywth(8) As String

            ReDim Preserve colarrynm(8)
            colarrynm(0) = "Trans Id"
            colarrywth(0) = "20"
            colarrynm(1) = "Hotel Id"
            colarrywth(1) = "20"
            colarrynm(2) = "Room Catogory"
            colarrywth(2) = "25"
            colarrynm(3) = "Bed Type"
            colarrywth(3) = "25"
            colarrynm(4) = "Season"
            colarrywth(4) = "15"
            colarrynm(5) = "Board"
            colarrywth(5) = "15"
            colarrynm(6) = "Rack Rate"
            colarrywth(6) = "10"
            colarrynm(7) = "Corp Rate"
            colarrywth(7) = "10"
            colarrynm(8) = "Active Flag"
            colarrywth(8) = "5"






            'ds.Clear()

            ' colname("select TransId,Hotelid,RCatg_id,Bed_Type,Season,Board,RackRate,CropRate,Actflag from room_tariff", dg2, colarrynm)
            ''colwidth(

            'Openconnection()
            'da = New OleDbDataAdapter("select TransId,Hotelid,RCatg_id,Bed_Type,Season,Board,RackRate,CropRate,Actflag from room_tariff", con)
            'da.Fill(ds, "roomtariff")
            'CloseConnection()
            'dg2.DataSource = ds.Tables("roomtariff")
        End If

    End Sub

    Private Sub dg2_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dg2.Navigate

    End Sub

    Private Sub cobbedtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobbedtype.KeyPress, cobhotel.KeyPress, cobhotelid.KeyPress, cobroomcat.KeyPress

        combo(e)
    End Sub
End Class
