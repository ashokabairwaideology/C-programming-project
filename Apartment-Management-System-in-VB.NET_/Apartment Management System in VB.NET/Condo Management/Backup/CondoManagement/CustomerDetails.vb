Public Class CustomerDetails
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
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents objobjcustset As CondoManagement.objcustset
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents editAddress As System.Windows.Forms.TextBox
    Friend WithEvents editCity As System.Windows.Forms.TextBox
    Friend WithEvents editCountry As System.Windows.Forms.TextBox
    Friend WithEvents editCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents editEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblZipcode As System.Windows.Forms.Label
    Friend WithEvents editFirstName As System.Windows.Forms.TextBox
    Friend WithEvents editLastName As System.Windows.Forms.TextBox
    Friend WithEvents editPhone As System.Windows.Forms.TextBox
    Friend WithEvents editZipcode As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerDetails))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.objobjcustset = New CondoManagement.objcustset
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.lblCustomerID = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.editAddress = New System.Windows.Forms.TextBox
        Me.editCity = New System.Windows.Forms.TextBox
        Me.editCountry = New System.Windows.Forms.TextBox
        Me.editCustomerID = New System.Windows.Forms.TextBox
        Me.editEmail = New System.Windows.Forms.TextBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblLastName = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblZipcode = New System.Windows.Forms.Label
        Me.editFirstName = New System.Windows.Forms.TextBox
        Me.editLastName = New System.Windows.Forms.TextBox
        Me.editPhone = New System.Windows.Forms.TextBox
        Me.editZipcode = New System.Windows.Forms.TextBox
        Me.btnclose = New System.Windows.Forms.Button
        CType(Me.objobjcustset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Address, City, Country, CustomerID, Email, FirstName, LastName, Phone, Zip" & _
        "code FROM Customer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source="".\condo.mdb"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global" & _
        " Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System databas" & _
        "e=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Sha" & _
        "re Deny None;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale " & _
        "on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Je" & _
        "t OLEDB:Encrypt Database=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(Address, City, Country, Email, FirstName, LastName, Phone, Z" & _
        "ipcode) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.VarWChar, 50, "Zipcode"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Customer SET Address = ?, City = ?, Country = ?, Email = ?, FirstName = ?," & _
        " LastName = ?, Phone = ?, Zipcode = ? WHERE (CustomerID = ?) AND (Address = ? OR" & _
        " ? IS NULL AND Address IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND" & _
        " (Country = ? OR ? IS NULL AND Country IS NULL) AND (Email = ? OR ? IS NULL AND " & _
        "Email IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastN" & _
        "ame = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone" & _
        " IS NULL) AND (Zipcode = ? OR ? IS NULL AND Zipcode IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 50, "Phone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.VarWChar, 50, "Zipcode"))
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
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Zipcode", "Zipcode")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'objobjcustset
        '
        Me.objobjcustset.DataSetName = "objcustset"
        Me.objobjcustset.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(48, 296)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 32)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update/save"
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(16, 112)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(16, 144)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City"
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(16, 176)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.TabIndex = 5
        Me.lblCountry.Text = "Country"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(8, 40)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.TabIndex = 6
        Me.lblCustomerID.Text = "CustomerID"
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(10, 208)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email"
        '
        'editAddress
        '
        Me.editAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.Address"))
        Me.editAddress.Location = New System.Drawing.Point(120, 112)
        Me.editAddress.Name = "editAddress"
        Me.editAddress.TabIndex = 8
        Me.editAddress.Text = ""
        '
        'editCity
        '
        Me.editCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.City"))
        Me.editCity.Location = New System.Drawing.Point(120, 144)
        Me.editCity.Name = "editCity"
        Me.editCity.TabIndex = 9
        Me.editCity.Text = ""
        '
        'editCountry
        '
        Me.editCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.Country"))
        Me.editCountry.Location = New System.Drawing.Point(120, 176)
        Me.editCountry.Name = "editCountry"
        Me.editCountry.TabIndex = 10
        Me.editCountry.Text = ""
        '
        'editCustomerID
        '
        Me.editCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.CustomerID"))
        Me.editCustomerID.Location = New System.Drawing.Point(120, 40)
        Me.editCustomerID.Name = "editCustomerID"
        Me.editCustomerID.TabIndex = 11
        Me.editCustomerID.Text = ""
        '
        'editEmail
        '
        Me.editEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.Email"))
        Me.editEmail.Location = New System.Drawing.Point(120, 208)
        Me.editEmail.Name = "editEmail"
        Me.editEmail.TabIndex = 12
        Me.editEmail.Text = ""
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(16, 72)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.TabIndex = 13
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(224, 80)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.TabIndex = 14
        Me.lblLastName.Text = "LastName"
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(230, 112)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Phone"
        '
        'lblZipcode
        '
        Me.lblZipcode.Location = New System.Drawing.Point(232, 144)
        Me.lblZipcode.Name = "lblZipcode"
        Me.lblZipcode.TabIndex = 16
        Me.lblZipcode.Text = "Zipcode"
        '
        'editFirstName
        '
        Me.editFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.FirstName"))
        Me.editFirstName.Location = New System.Drawing.Point(120, 72)
        Me.editFirstName.Name = "editFirstName"
        Me.editFirstName.TabIndex = 17
        Me.editFirstName.Text = ""
        '
        'editLastName
        '
        Me.editLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.LastName"))
        Me.editLastName.Location = New System.Drawing.Point(336, 80)
        Me.editLastName.Name = "editLastName"
        Me.editLastName.TabIndex = 18
        Me.editLastName.Text = ""
        '
        'editPhone
        '
        Me.editPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.Phone"))
        Me.editPhone.Location = New System.Drawing.Point(336, 112)
        Me.editPhone.Name = "editPhone"
        Me.editPhone.TabIndex = 19
        Me.editPhone.Text = ""
        '
        'editZipcode
        '
        Me.editZipcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjcustset, "Customer.Zipcode"))
        Me.editZipcode.Location = New System.Drawing.Point(336, 144)
        Me.editZipcode.Name = "editZipcode"
        Me.editZipcode.TabIndex = 20
        Me.editZipcode.Text = ""
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(216, 296)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(96, 32)
        Me.btnclose.TabIndex = 21
        Me.btnclose.Text = "Close"
        '
        'CustomerDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 390)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.editAddress)
        Me.Controls.Add(Me.editCity)
        Me.Controls.Add(Me.editCountry)
        Me.Controls.Add(Me.editCustomerID)
        Me.Controls.Add(Me.editEmail)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblZipcode)
        Me.Controls.Add(Me.editFirstName)
        Me.Controls.Add(Me.editLastName)
        Me.Controls.Add(Me.editPhone)
        Me.Controls.Add(Me.editZipcode)
        Me.Name = "CustomerDetails"
        Me.Text = "CustomerDetails"
        CType(Me.objobjcustset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjcustset, "Customer").CancelCurrentEdit()
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Me.BindingContext(objobjcustset, "Customer").Count > 0) Then
            Me.BindingContext(objobjcustset, "Customer").RemoveAt(Me.BindingContext(objobjcustset, "Customer").Position)
            Me.objobjcustset_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Clear out the current edits
            Me.BindingContext(objobjcustset, "Customer").EndCurrentEdit()
            Me.BindingContext(objobjcustset, "Customer").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjcustset, "Customer").Position = 0
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjcustset, "Customer").Position = (Me.objobjcustset.Tables("Customer").Rows.Count - 1)
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjcustset, "Customer").Position = (Me.BindingContext(objobjcustset, "Customer").Position - 1)
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjcustset, "Customer").Position = (Me.BindingContext(objobjcustset, "Customer").Position + 1)
        Me.objobjcustset_PositionChanged()

    End Sub
    Private Sub objobjcustset_PositionChanged()
        'Me.lblNavLocation.Text = (((Me.BindingContext(objobjcustset, "Customer").Position + 1).ToString + " of  ") _
        '            + Me.BindingContext(objobjcustset, "Customer").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.objobjcustset.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As CondoManagement.objcustset = New CondoManagement.objcustset
        'Stop any current edits.
        Me.BindingContext(objobjcustset, "Customer").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objobjcustset.GetChanges, CondoManagement.objcustset)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objobjcustset.Merge(objDataSetChanges)
                objobjcustset.AcceptChanges()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
        End If

    End Sub
    Public Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        Dim objDataSetTemp As CondoManagement.objcustset
        objDataSetTemp = New CondoManagement.objcustset
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objobjcustset.Clear()
            'Merge the records into the main dataset.
            objobjcustset.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As CondoManagement.objcustset)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleDbConnection1.Open()
                'Attempt to update the data source.
                OleDbDataAdapter1.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As CondoManagement.objcustset)
        'Turn off constraint checking before the dataset is filled.
        'This allows the adapters to fill the dataset without concern
        'for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            'Open the connection.
            Me.OleDbConnection1.Open()
            'Attempt to fill the dataset through the OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
        Catch fillException As System.Exception
            'Add your error handling code here.
            Throw fillException
        Finally
            'Turn constraint checking back on.
            dataSet.EnforceConstraints = True
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
    Public Function passklant()

        Try

            'btnaddk.Visible = False

            Dim index As New CommonClass
            'sql calling from the Klantbest table
            Dim sql As String
            sql = " SELECT * FROM Customer where CustomerID=" & index.custad
            Dim cmdAdapter As New OleDb.OleDbDataAdapter
            Dim cmd As New OleDb.OleDbCommand

            cmd = New OleDb.OleDbCommand(sql, Me.OleDbConnection1)
            cmdAdapter.SelectCommand = cmd
            cmdAdapter.SelectCommand.CommandType = CommandType.Text
            'Me.OleDbConnection1.Open()
            Me.objobjcustset.Clear()
            'fill in klantds1 dataset
            cmdAdapter.Fill(Me.objobjcustset, "Customer")
            'Me.OleDbConnection1.Close()

            'Me.OleDbDataAdapter4.Fill(Me.Verzebasisds1, "Verzekeringsbasis")
            Me.OleDbDataAdapter1.Fill(Me.objobjcustset, "Customer")

        Catch EX As System.Exception

            'VarModuleName = ClientForm.vb
            'VarProcedureName = passklant
            MsgBox("Could not find customer")

            'Dim errmsg As New ErrorPopup
            'errmsg.Show()
            'errmsg.geterrors("ClientForm.vb", "passklant", Err.Number)
        End Try



    End Function
    Public Function addnew()
        Try
            'Me.btnorderview.Visible = False
            'Me.btnAddCustomerDetails.Visible = True
            'Me.btndeleteAddCustomerDetails.Visible = False
            'Me.btnUpdateAddCustomerDetails.Visible = False
            Me.editCustomerID.Enabled = False
            'Me.btnAdd.Visible = False


            Try
                'Clear out the current edits
                Me.BindingContext(Me.objobjcustset, "Customer").EndCurrentEdit()
                Me.BindingContext(Me.objobjcustset, "Customer").AddNew()
                Me.OleDbDataAdapter1.Update(Me.objobjcustset)
            Catch eEndEdit As System.Exception
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        Catch EX As System.Exception

            MsgBox(EX.Message)

        End Try

    End Function

End Class
