'developed by: vasu and raghu
'date:30/08/2006
'version1
Imports System.Data.oledb
Public Class CustomerTracking
    Inherits System.Windows.Forms.Form
    Dim ds As DataSet
    Dim da As New OleDbDataAdapter
    Dim cmd As OleDbCommand
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cob_country As System.Windows.Forms.ComboBox
    Friend WithEvents text_mname As System.Windows.Forms.TextBox
    Friend WithEvents text_fname As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cob_city As System.Windows.Forms.ComboBox
    Friend WithEvents cob_year As System.Windows.Forms.ComboBox
    Friend WithEvents text_lname As System.Windows.Forms.TextBox
    Friend WithEvents bt_customersearch As System.Windows.Forms.Button
    Friend WithEvents cob_agentwise As System.Windows.Forms.ComboBox
    Friend WithEvents text_customerid As System.Windows.Forms.TextBox
    Friend WithEvents cob_month As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerTracking))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cob_city = New System.Windows.Forms.ComboBox
        Me.cob_country = New System.Windows.Forms.ComboBox
        Me.cob_year = New System.Windows.Forms.ComboBox
        Me.text_lname = New System.Windows.Forms.TextBox
        Me.bt_customersearch = New System.Windows.Forms.Button
        Me.cob_agentwise = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.text_customerid = New System.Windows.Forms.TextBox
        Me.cob_month = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.text_mname = New System.Windows.Forms.TextBox
        Me.text_fname = New System.Windows.Forms.TextBox
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
        Me.GroupBox1.Controls.Add(Me.cob_city)
        Me.GroupBox1.Controls.Add(Me.cob_country)
        Me.GroupBox1.Controls.Add(Me.cob_year)
        Me.GroupBox1.Controls.Add(Me.text_lname)
        Me.GroupBox1.Controls.Add(Me.bt_customersearch)
        Me.GroupBox1.Controls.Add(Me.cob_agentwise)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.text_customerid)
        Me.GroupBox1.Controls.Add(Me.cob_month)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.text_mname)
        Me.GroupBox1.Controls.Add(Me.text_fname)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Criteria"
        '
        'cob_city
        '
        Me.cob_city.Location = New System.Drawing.Point(312, 48)
        Me.cob_city.Name = "cob_city"
        Me.cob_city.Size = New System.Drawing.Size(104, 21)
        Me.cob_city.TabIndex = 9
        '
        'cob_country
        '
        Me.cob_country.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_country.Location = New System.Drawing.Point(104, 48)
        Me.cob_country.Name = "cob_country"
        Me.cob_country.Size = New System.Drawing.Size(104, 21)
        Me.cob_country.TabIndex = 7
        '
        'cob_year
        '
        Me.cob_year.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_year.Items.AddRange(New Object() {"1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013"})
        Me.cob_year.Location = New System.Drawing.Point(104, 80)
        Me.cob_year.Name = "cob_year"
        Me.cob_year.Size = New System.Drawing.Size(104, 21)
        Me.cob_year.TabIndex = 13
        '
        'text_lname
        '
        Me.text_lname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_lname.Location = New System.Drawing.Point(512, 16)
        Me.text_lname.Name = "text_lname"
        Me.text_lname.Size = New System.Drawing.Size(104, 21)
        Me.text_lname.TabIndex = 5
        Me.text_lname.Text = ""
        '
        'bt_customersearch
        '
        Me.bt_customersearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_customersearch.Location = New System.Drawing.Point(528, 104)
        Me.bt_customersearch.Name = "bt_customersearch"
        Me.bt_customersearch.Size = New System.Drawing.Size(72, 32)
        Me.bt_customersearch.TabIndex = 18
        Me.bt_customersearch.Text = "Search"
        '
        'cob_agentwise
        '
        Me.cob_agentwise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_agentwise.Location = New System.Drawing.Point(512, 40)
        Me.cob_agentwise.Name = "cob_agentwise"
        Me.cob_agentwise.Size = New System.Drawing.Size(104, 21)
        Me.cob_agentwise.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Agent Wise :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(424, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Customer Id :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_customerid
        '
        Me.text_customerid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_customerid.Location = New System.Drawing.Point(512, 72)
        Me.text_customerid.Name = "text_customerid"
        Me.text_customerid.Size = New System.Drawing.Size(104, 21)
        Me.text_customerid.TabIndex = 17
        Me.text_customerid.Text = ""
        '
        'cob_month
        '
        Me.cob_month.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_month.Items.AddRange(New Object() {"1-Jan", "2-Feb", "3-Mar", "4-Apr", "5-May", "6-Jun", "7-Jul", "8-Aug", "9-Sep", "10-Oct", "11-Nov", "12-Dec"})
        Me.cob_month.Location = New System.Drawing.Point(312, 80)
        Me.cob_month.Name = "cob_month"
        Me.cob_month.Size = New System.Drawing.Size(104, 21)
        Me.cob_month.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "In The Year :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(224, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "In The Month :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(224, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "From City :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From Country :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(224, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 14)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Middle Name :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(424, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 14)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Last Name :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_mname
        '
        Me.text_mname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_mname.Location = New System.Drawing.Point(312, 16)
        Me.text_mname.Name = "text_mname"
        Me.text_mname.Size = New System.Drawing.Size(104, 21)
        Me.text_mname.TabIndex = 3
        Me.text_mname.Text = ""
        '
        'text_fname
        '
        Me.text_fname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_fname.Location = New System.Drawing.Point(104, 16)
        Me.text_fname.Name = "text_fname"
        Me.text_fname.Size = New System.Drawing.Size(104, 21)
        Me.text_fname.TabIndex = 1
        Me.text_fname.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 14)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "First Name :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 216)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Result"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(24, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(584, 160)
        Me.DataGrid1.TabIndex = 0
        '
        'CustomerTracking
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(640, 365)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerTracking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerTracking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'fills country from country master
    Private Sub cob_countryfill()
        Try
            Openconnection()
            cmd = New OleDbCommand(" select countryid,country from countrymaster", con)
            dr = cmd.ExecuteReader

            While dr.Read
                cob_country.Items.Add(dr(0) + "-" + dr(1))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.Message)
            dr.Close()
            cmd.Dispose()
        Finally
            CloseConnection()
        End Try
    End Sub
    'fills city from citymaster with relevent country
    Private Sub cob_cityfill()

        Try
            cob_city.Items.Clear()
            Dim i As Integer
            Dim s As String
            i = InStr(cob_country.Text, "-")
            s = Mid(cob_country.Text, 1, i - 1)
            Openconnection()
            cmd = New OleDbCommand("Select Cityid,City from CityMaster where Countryid= '" & s & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cob_city.Items.Add(dr(0) + "-" + dr(1))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cmd.Dispose()
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub CustomerTracking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cob_countryfill()
        Call cob_agentwisefill()
        Call clearproc()
    End Sub
    'filling of agentid from agentmaster
    Private Sub cob_agentwisefill()
        Try
            Openconnection()
            cmd = New OleDbCommand("Select agentid from agentmaster", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cob_agentwise.Items.Add(dr(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cmd.Dispose()
        Finally
            CloseConnection()
        End Try
    End Sub
    'search record and fills datagrid1
    Private Sub bt_customersearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_customersearch.Click
        Try
            Dim str As String
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter
            Dim str1 As String
            Openconnection()
            str = customertracking()
            str1 = "select custid,fname,mname,lname,countryid,cityid,cust_jdate,agentid from cust_master " & str
            cmd = New OleDbCommand(str1, con)
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.TableMappings.Add("Table", "cust_master")
            da.Fill(ds, "cust_master")
            DataGrid1.SetDataBinding(ds, "cust_master")
        Catch ex As Exception
            MsgBox(ex.Message)
            cmd.Dispose()
        Finally
            CloseConnection()
        End Try
    End Sub
    'function for searching the records with combinations
    Function customertracking() As String
        Dim str1, str2 As String
        Dim cmdstr(10) As String
        Dim fn, mn, ln, fco, fci, ye, mont, aw, cid As Integer
        fn = mn = ln = fco = fci = ye = mont = aw = cid = 0

        If text_fname.Text = "" Then 'when text_fname is empty then fname =1
            fn = 1
        Else
            cmdstr(0) = "fname like '%" & text_fname.Text & "%'"
        End If

        If text_mname.Text = "" Then 'when text_mname is empty then mname=1
            mn = 1
        Else
            cmdstr(1) = "mname like '%" & text_mname.Text & "%'"
        End If

        If text_lname.Text = "" Then 'when text_lname is empty then lname =1
            ln = 1
        Else
            cmdstr(2) = "lname like '%" & text_lname.Text & "%'"
        End If

        If cob_country.Text = "" Then 'when cob_country is empty then country =1
            fco = 1
        Else
            Dim t As Integer      'when country is selected automatically city is selected
            t = InStr(cob_country.Text, "-")
            cmdstr(3) = "countryid='" & Mid(cob_country.Text, 1, t - 1) & "'"
        End If

        If cob_city.Text = "" Then 'when cob_city is empty then city=1
            fci = 1
        Else
            Dim ct As Integer
            ct = InStr(cob_city.Text, "-")
            cmdstr(4) = "cityid='" & Mid(cob_city.Text, 1, ct - 1) & "'"
        End If

        If cob_year.Text = "" Then 'when cob_year is empty then year=1
            ye = 1
        Else
            cmdstr(5) = "year(cust_jdate)='" & cob_year.Text & "'"
        End If

        If cob_month.Text = "" Then 'when cob_month is empty then month=1
            mont = 1
        Else
            Dim mt As Integer    '
            mt = InStr(cob_month.Text, "-")
            cmdstr(6) = "month(cust_jdate)='" & Mid(cob_month.Text, 1, mt - 1) & "'"
        End If

        If cob_agentwise.Text = "" Then
            aw = 1
        Else
            cmdstr(7) = "agentid = '" & cob_agentwise.Text & "'"
        End If

        If text_customerid.Text = "" Then
            cid = 1
        Else
            cmdstr(8) = "custid = '" & text_customerid.Text & "'"
        End If
        ' converting into string and concating them
        str1 = CStr(fn) + CStr(mn) + CStr(ln) + CStr(fco) + CStr(fci) + CStr(ye) + CStr(mont) + CStr(aw) + CStr(cid)
        str2 = str1

        Dim str3, str4 As String
        Dim i As Integer
        While str1 <> ""                    ' if str1 is not equal to empty 
            str4 = Mid(str1, 1, 1)         'value of string starts counting from first position 
            str1 = Mid(str1, 2)           'value of string strarts counting from second position
            If str4 = "0" Then           'it checks  string contains 0 
                If str3 = "" Then              ' if string is empty it takes cmdstr(i)
                    str3 = cmdstr(i)
                Else
                    str3 = str3 + " and " + cmdstr(i) ' if string is not empty it cheks condition str3 value and cmdstr(i) values
                End If
            End If
            i = i + 1                              'increaments up to length of string
        End While
        If str2 = "111111111" Then                          'if the str2 values are null 
            str3 = ""                                       'str3 = empty
        Else
            str3 = " where " & str3

        End If
        Return str3

    End Function

    Private Sub cob_country_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob_country.SelectedIndexChanged
        Call cob_cityfill()
    End Sub

    Private Sub text_lname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_lname.KeyPress, text_mname.KeyPress, text_fname.KeyPress

        Call textonly(e)
    End Sub

    Private Sub text_customerid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_customerid.KeyPress
        Call idtextandnumbers(e)
    End Sub

    Private Sub cob_agentwise_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cob_agentwise.KeyPress, cob_city.KeyPress, cob_country.KeyPress, cob_month.KeyPress, cob_year.KeyPress
        Call combo(e)
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    Public Sub delproc()
        Try
            Dim str As String
            str = "delete * from "
        Catch ex As Exception

        End Try
    End Sub
    Public Sub saveproc()

    End Sub
    Public Sub editproc()

    End Sub
    Public Sub newproc()

    End Sub
    Public Sub clearproc()
        text_fname.Text = ""
        text_mname.Text = ""
        text_lname.Text = ""
        text_customerid.Text = ""
        cob_agentwise.Text = ""
        cob_city.Text = ""
        cob_country.Text = ""
        cob_year.Text = ""
        cob_month.Text = ""
    End Sub

   
End Class
