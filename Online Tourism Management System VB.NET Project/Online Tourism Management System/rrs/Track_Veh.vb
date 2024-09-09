'developed by vasu and raghu 
'date 25\8\2006
'version 1
Imports System.Data.oledb
Public Class Track_Veh
    Inherits System.Windows.Forms.Form
    Dim cmd As OleDbCommand
    Dim ds As DataSet
    Dim da As OleDbDataAdapter

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents com_fillvehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Btsearch As System.Windows.Forms.Button
    Friend WithEvents no_ofseating As System.Windows.Forms.TextBox
    Friend WithEvents registrationno As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Track_Veh))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btsearch = New System.Windows.Forms.Button
        Me.com_fillvehicle = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.no_ofseating = New System.Windows.Forms.TextBox
        Me.registrationno = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btsearch)
        Me.GroupBox1.Controls.Add(Me.com_fillvehicle)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.no_ofseating)
        Me.GroupBox1.Controls.Add(Me.registrationno)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 120)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Btsearch
        '
        Me.Btsearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btsearch.Location = New System.Drawing.Point(520, 80)
        Me.Btsearch.Name = "Btsearch"
        Me.Btsearch.Size = New System.Drawing.Size(72, 32)
        Me.Btsearch.TabIndex = 7
        Me.Btsearch.Text = "Search"
        '
        'com_fillvehicle
        '
        Me.com_fillvehicle.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com_fillvehicle.Location = New System.Drawing.Point(120, 56)
        Me.com_fillvehicle.Name = "com_fillvehicle"
        Me.com_fillvehicle.Size = New System.Drawing.Size(112, 20)
        Me.com_fillvehicle.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 14)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "No. Of Seating :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 14)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Vehicle Type :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'no_ofseating
        '
        Me.no_ofseating.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_ofseating.Location = New System.Drawing.Point(120, 88)
        Me.no_ofseating.Name = "no_ofseating"
        Me.no_ofseating.Size = New System.Drawing.Size(112, 18)
        Me.no_ofseating.TabIndex = 4
        Me.no_ofseating.Text = ""
        '
        'registrationno
        '
        Me.registrationno.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrationno.Location = New System.Drawing.Point(120, 24)
        Me.registrationno.Name = "registrationno"
        Me.registrationno.Size = New System.Drawing.Size(112, 18)
        Me.registrationno.TabIndex = 0
        Me.registrationno.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 14)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Registration No :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 216)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(584, 192)
        Me.DataGrid1.TabIndex = 0
        '
        'Track_Veh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 11)
        Me.ClientSize = New System.Drawing.Size(608, 357)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Track_Veh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tracking Vehicle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Track_Veh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loads data in combobox when form is loaded
        Call fillvehicle()
    End Sub
    Private Sub fillvehicle() 'Procedure for fill com_fillvehicle
        Dim dr As OleDbDataReader
        Dim str1 As String
        Dim str2 As String
        Try
            Openconnection()
            'joining the ownvehicalmaster and ve_type with vehtypeid cloumn
            cmd = New OleDbCommand("Select o.vehtypeid,v.vehtype from  ownvehiclemaster o, veh_type v where o.vehtypeid = v.vehtypeid", con)
            dr = cmd.ExecuteReader
            While dr.Read
                com_fillvehicle.Items.Add(dr(0) + "-" + dr(1)) 'concating the two columns vehtypeid and vehtype in comfillvehicle object

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cmd.Dispose()
        Finally
            CloseConnection()
        End Try
    End Sub

    'searchs the records to fill in datagrid1 
    Private Sub Btsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btsearch.Click
        Dim str As String
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Dim str1 As String
        Openconnection()
        str = Tracking_Search()
        str1 = "select regno,regdate,vehtypeid,seatingcapacity,employeeid from ownvehiclemaster  " & str
        cmd = New OleDbCommand(str1, con)
        cmd.CommandType = CommandType.Text
        da.SelectCommand = cmd
        Try
            da.TableMappings.Add("Table", "ownvehiclemaster")
            da.Fill(ds)
            DataGrid1.SetDataBinding(ds, "ownvehiclemaster")
        Catch ex As Exception
            MsgBox(ex.Message)
            cmd.Dispose()
        Finally
            CloseConnection()
        End Try

    End Sub
    'function for searching records with the combinations
    Function Tracking_Search() As String
        Dim str, str1, str2 As String
        Dim cmdstr(3) As String
        Dim reg_no, veh_id, no_seats As Integer
        reg_no = veh_id = no_seats = 0
        If registrationno.Text = "" Then
            reg_no = 1 'when registrationno.Text is empty then reg_no =1
        Else
            cmdstr(0) = "regno ='" & registrationno.Text & "'" 'registrationno.Text is fill by text then its equal to 0
        End If
        If com_fillvehicle.Text = "" Then
            veh_id = 1
        Else
            Dim t As Integer
            t = InStr(com_fillvehicle.Text, "-")
            cmdstr(1) = "vehtypeid='" & Mid(com_fillvehicle.Text, 1, t - 1) & "'"
        End If
        If no_ofseating.Text = "" Then
            no_seats = 1
        Else
            cmdstr(2) = "seatingcapacity= " & Val(no_ofseating.Text) & ""
        End If
        str1 = CStr(reg_no) + CStr(veh_id) + CStr(no_seats) ' converting strings
        str2 = str1
        Dim str3, str4 As String
        Dim i As Integer
        While str1 <> "" ' if str1 is not equal to empty 
            str4 = Mid(str1, 1, 1) 'value of string starts counting from first position 
            str1 = Mid(str1, 2) 'value of string strarts counting from second position
            If str4 = "0" Then  'it checks object contains value
                If str3 = "" Then ' it checks object contains null
                    str3 = cmdstr(i) 'excutes the command string
                Else
                    str3 = str3 + " and " + cmdstr(i)

                End If
            End If
            i = i + 1
        End While
        If str2 = "111" Then 'if the object values are null 
            str3 = " "
        Else
            str3 = " where " & str3
        End If
        Return str3
    End Function

    Private Sub com_fillvehicle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles com_fillvehicle.KeyPress
        Call combo(e)
    End Sub

    Private Sub no_ofseating_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles no_ofseating.KeyPress, registrationno.KeyPress
        Call numberonly(e)
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    Public Sub delproc()

    End Sub
    Public Sub saveproc()

    End Sub
    Public Sub editproc()

    End Sub
    Public Sub newproc()

    End Sub
    Public Sub clearproc()

    End Sub
End Class
