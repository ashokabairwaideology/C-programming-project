Imports System
Imports System.Data
Imports System.Data.OleDb




Public Class CustomerForm
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Customerds1 As CondoManagement.Customerds
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Customerds1 = New CondoManagement.Customerds
        Me.btnadd = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnview = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customerds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Customer"
        '
        'btnsearch
        '
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(472, 16)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(120, 32)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"CustomerID", "FirstName", "LastName"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(304, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.Customerds1.Customer
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 80)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(664, 192)
        Me.DataGrid1.TabIndex = 1
        '
        'Customerds1
        '
        Me.Customerds1.DataSetName = "Customerds"
        Me.Customerds1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(32, 288)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(128, 23)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "ADD NEW"
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(192, 288)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(144, 23)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "DELETE"
        '
        'btnview
        '
        Me.btnview.Image = CType(resources.GetObject("btnview.Image"), System.Drawing.Image)
        Me.btnview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnview.Location = New System.Drawing.Point(368, 288)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(136, 23)
        Me.btnview.TabIndex = 4
        Me.btnview.Text = "VIEW"
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(528, 288)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(136, 24)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "CLOSE"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Zipcode", "Zipcode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Email", "Email")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Customer WHERE (CustomerID = ?) AND (Address = ? OR ? IS NULL AND Add" & _
        "ress IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Country = ? OR ?" & _
        " IS NULL AND Country IS NULL) AND (Email = ? OR ? IS NULL AND Email IS NULL) AND" & _
        " (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NU" & _
        "LL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (Zip" & _
        "code = ? OR ? IS NULL AND Zipcode IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zipcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zipcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zipcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source="".\condo.mdb"";Jet OLEDB:Engine Type=5;Provider=""Micros" & _
        "oft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist securi" & _
        "ty info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Databa" & _
        "se=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on C" & _
        "ompact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OL" & _
        "EDB:Global Bulk Transactions=1"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(FirstName, LastName, Address, City, Zipcode, Country, Phone," & _
        " Email) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.VarWChar, 50, "Zipcode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CustomerID, FirstName, LastName, Address, City, Zipcode, Country, Phone, E" & _
        "mail FROM Customer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Customer SET FirstName = ?, LastName = ?, Address = ?, City = ?, Zipcode =" & _
        " ?, Country = ?, Phone = ?, Email = ? WHERE (CustomerID = ?) AND (Address = ? OR" & _
        " ? IS NULL AND Address IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND" & _
        " (Country = ? OR ? IS NULL AND Country IS NULL) AND (Email = ? OR ? IS NULL AND " & _
        "Email IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastN" & _
        "ame = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone" & _
        " IS NULL) AND (Zipcode = ? OR ? IS NULL AND Zipcode IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.VarWChar, 50, "Zipcode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zipcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zipcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zipcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'CustomerForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 342)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customerds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbDataAdapter1.Fill(Me.Customerds1)
        Me.btndelete.Enabled = False
        Me.btnview.Enabled = False



    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseUp
        Dim pt = New Point(e.X, e.Y)
        Dim hit As DataGrid.HitTestInfo = DataGrid1.HitTest(pt)
        Dim index As New CommonClass
        If hit.Type = Windows.Forms.DataGrid.HitTestType.Cell Then
            'DataGrid1.CurrentCell = New DataGridCell(1, 1)
            'DataGrid1.Select(hit.Row)
            index.custad = CType(Me.Customerds1.Tables(0).Rows(hit.Row).Item("CustomerID"), String)

            MsgBox(index.custad)
            Me.btnview.Enabled = True
            Me.btndelete.Enabled = True


        End If

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If Me.ComboBox1.Text = "" Then
            MessageBox.Show("Please Select a Search Field!", "Empty Search Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                Dim cmdAdapter As New OleDb.OleDbDataAdapter
                Dim cmd As New OleDb.OleDbCommand
                Dim query As String
                Dim dset As New DataSet
                query = "SELECT * FROM Customer WHERE(" + Me.ComboBox1.SelectedItem + ")LIKE('%" + Me.TextBox1.Text + "%');"

                cmd = New OleDb.OleDbCommand(query, Me.OleDbConnection1)
                cmdAdapter.SelectCommand = cmd
                cmdAdapter.SelectCommand.CommandType = CommandType.Text
                Me.OleDbConnection1.Open()
                Me.Customerds1.Clear()
                cmdAdapter.Fill(Me.Customerds1, "Customer")
                Me.DataGrid1.DataSource = Me.Customerds1.Customer
                
                Me.OleDbConnection1.Close()


            Catch ex As OleDbException
                MsgBox("Customer Not found" + ex.Message)
            End Try


        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.Customerds1.Clear()
        Me.OleDbDataAdapter1.Fill(Me.Customerds1)

    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        'Dim index As New CommonClass
        'If index.custad = Nothing Then
        '    MsgBox("choose the Customer Row")
        '    Exit Sub
        'End If
        Dim ins As New CustomerDetails
        ins.MdiParent = MainMenu.ActiveForm()
        ins.passklant()
        ins.Show()
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        'Dim index As New CommonClass
        'If index.custad = Nothing Then
        '    MsgBox("choose the Customer Row")
        '    Exit Sub
        'End If

        Dim ind As New CustomerDetails
        ind.MdiParent = MainMenu.ActiveForm()
        ind.addnew()
        ind.Show()
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MessageBox.Show("Do you really want to Delete this Record?", _
              "Delete", MessageBoxButtons.YesNo, _
             MessageBoxIcon.Warning) = DialogResult.No Then


            MsgBox("Operation Cancelled")
            Exit Sub

        Else



            Try

                Dim ind As New CommonClass
                Dim DeleteCommand As New OleDb.OleDbCommand
                DeleteCommand.Connection = Me.OleDbConnection1
                DeleteCommand.CommandText = "DELETE FROM Customer where CustomerID= " & Int32.Parse(ind.custad)
                DeleteCommand.CommandType = CommandType.Text
                Me.OleDbConnection1.Open()
                DeleteCommand.ExecuteNonQuery()
                Me.OleDbConnection1.Close()


                Me.OleDbDataAdapter1.Fill(Me.Customerds1, "Customer")

                Dim psql As String
                psql = " SELECT * FROM Customer"
                Dim cmdAdapter As New OleDb.OleDbDataAdapter
                Dim cmd As New OleDb.OleDbCommand

                cmd = New OleDb.OleDbCommand(psql, Me.OleDbConnection1)
                cmdAdapter.SelectCommand = cmd
                cmdAdapter.SelectCommand.CommandType = CommandType.Text
                ' Me.OleDbConnection1.Open()
                Me.Customerds1.Clear()
                'fill in klantds1 dataset
                cmdAdapter.Fill(Me.Customerds1, "Customer")
                Me.DataGrid1.DataSource = Me.Customerds1.Customer





            Catch ex As OleDbException
                MsgBox(ex.Message)

            End Try
        End If



    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class
