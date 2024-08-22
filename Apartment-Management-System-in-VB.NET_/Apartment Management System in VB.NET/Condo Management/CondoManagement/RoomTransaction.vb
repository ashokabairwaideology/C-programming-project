
Imports System
Imports System.Data
Imports System.Data.OleDb



Public Class RoomTransaction
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Transactionds1 As CondoManagement.transactionds
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnadd = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnview = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Transactionds1 = New CondoManagement.transactionds
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactionds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Transaction"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(432, 24)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 32)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Search"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"TransactionID", "RoomNo", "CustomerID"})
        Me.ComboBox1.Location = New System.Drawing.Point(192, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(320, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.Transactionds1.RoomTransaction
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 80)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(624, 192)
        Me.DataGrid1.TabIndex = 1
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(16, 288)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(128, 23)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "ADD NEW"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(168, 288)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(144, 23)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "DELETE"
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(328, 288)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(136, 23)
        Me.btnview.TabIndex = 4
        Me.btnview.Text = "VIEW"
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(488, 288)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(144, 23)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "CLOSE"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RoomTransaction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TransactionID", "TransactionID"), New System.Data.Common.DataColumnMapping("TransactionDate", "TransactionDate"), New System.Data.Common.DataColumnMapping("RoomNo", "RoomNo"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Month", "Month"), New System.Data.Common.DataColumnMapping("ElectricityBill", "ElectricityBill"), New System.Data.Common.DataColumnMapping("WaterBill", "WaterBill"), New System.Data.Common.DataColumnMapping("DryCleaningBill", "DryCleaningBill"), New System.Data.Common.DataColumnMapping("MaintainanceBill", "MaintainanceBill"), New System.Data.Common.DataColumnMapping("TotalBill", "TotalBill"), New System.Data.Common.DataColumnMapping("RentExpense", "RentExpense")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
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
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT TransactionID, TransactionDate, RoomNo, CustomerID, Name, Month, Electrici" & _
        "tyBill, WaterBill, DryCleaningBill, MaintainanceBill, TotalBill, RentExpense FRO" & _
        "M RoomTransaction"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO RoomTransaction(TransactionDate, RoomNo, CustomerID, Name, Month, Ele" & _
        "ctricityBill, WaterBill, DryCleaningBill, MaintainanceBill, TotalBill, RentExpen" & _
        "se) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TransactionDate", System.Data.OleDb.OleDbType.VarWChar, 50, "TransactionDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Month", System.Data.OleDb.OleDbType.VarWChar, 50, "Month"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ElectricityBill", System.Data.OleDb.OleDbType.Currency, 0, "ElectricityBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("WaterBill", System.Data.OleDb.OleDbType.Currency, 0, "WaterBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DryCleaningBill", System.Data.OleDb.OleDbType.Currency, 0, "DryCleaningBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MaintainanceBill", System.Data.OleDb.OleDbType.Currency, 0, "MaintainanceBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalBill", System.Data.OleDb.OleDbType.Currency, 0, "TotalBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RentExpense", System.Data.OleDb.OleDbType.Currency, 0, "RentExpense"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE RoomTransaction SET TransactionDate = ?, RoomNo = ?, CustomerID = ?, Name " & _
        "= ?, Month = ?, ElectricityBill = ?, WaterBill = ?, DryCleaningBill = ?, Maintai" & _
        "nanceBill = ?, TotalBill = ?, RentExpense = ? WHERE (TransactionID = ?) AND (Cus" & _
        "tomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (DryCleaningBill = ? OR ? I" & _
        "S NULL AND DryCleaningBill IS NULL) AND (ElectricityBill = ? OR ? IS NULL AND El" & _
        "ectricityBill IS NULL) AND (MaintainanceBill = ? OR ? IS NULL AND MaintainanceBi" & _
        "ll IS NULL) AND (Month = ? OR ? IS NULL AND Month IS NULL) AND (Name = ? OR ? IS" & _
        " NULL AND Name IS NULL) AND (RentExpense = ? OR ? IS NULL AND RentExpense IS NUL" & _
        "L) AND (RoomNo = ? OR ? IS NULL AND RoomNo IS NULL) AND (TotalBill = ? OR ? IS N" & _
        "ULL AND TotalBill IS NULL) AND (TransactionDate = ? OR ? IS NULL AND Transaction" & _
        "Date IS NULL) AND (WaterBill = ? OR ? IS NULL AND WaterBill IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TransactionDate", System.Data.OleDb.OleDbType.VarWChar, 50, "TransactionDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Month", System.Data.OleDb.OleDbType.VarWChar, 50, "Month"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ElectricityBill", System.Data.OleDb.OleDbType.Currency, 0, "ElectricityBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("WaterBill", System.Data.OleDb.OleDbType.Currency, 0, "WaterBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DryCleaningBill", System.Data.OleDb.OleDbType.Currency, 0, "DryCleaningBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MaintainanceBill", System.Data.OleDb.OleDbType.Currency, 0, "MaintainanceBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalBill", System.Data.OleDb.OleDbType.Currency, 0, "TotalBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RentExpense", System.Data.OleDb.OleDbType.Currency, 0, "RentExpense"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransactionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransactionID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DryCleaningBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DryCleaningBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DryCleaningBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DryCleaningBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ElectricityBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ElectricityBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ElectricityBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ElectricityBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaintainanceBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaintainanceBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaintainanceBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaintainanceBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Month", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Month", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Month1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Month", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentExpense", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentExpense", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentExpense1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentExpense", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RoomNo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoomNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RoomNo1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoomNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransactionDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransactionDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransactionDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransactionDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_WaterBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WaterBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_WaterBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WaterBill", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM RoomTransaction WHERE (TransactionID = ?) AND (CustomerID = ? OR ? IS" & _
        " NULL AND CustomerID IS NULL) AND (DryCleaningBill = ? OR ? IS NULL AND DryClean" & _
        "ingBill IS NULL) AND (ElectricityBill = ? OR ? IS NULL AND ElectricityBill IS NU" & _
        "LL) AND (MaintainanceBill = ? OR ? IS NULL AND MaintainanceBill IS NULL) AND (Mo" & _
        "nth = ? OR ? IS NULL AND Month IS NULL) AND (Name = ? OR ? IS NULL AND Name IS N" & _
        "ULL) AND (RentExpense = ? OR ? IS NULL AND RentExpense IS NULL) AND (RoomNo = ? " & _
        "OR ? IS NULL AND RoomNo IS NULL) AND (TotalBill = ? OR ? IS NULL AND TotalBill I" & _
        "S NULL) AND (TransactionDate = ? OR ? IS NULL AND TransactionDate IS NULL) AND (" & _
        "WaterBill = ? OR ? IS NULL AND WaterBill IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransactionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransactionID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DryCleaningBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DryCleaningBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DryCleaningBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DryCleaningBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ElectricityBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ElectricityBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ElectricityBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ElectricityBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaintainanceBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaintainanceBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MaintainanceBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaintainanceBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Month", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Month", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Month1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Month", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentExpense", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentExpense", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentExpense1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentExpense", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RoomNo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoomNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RoomNo1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoomNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransactionDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransactionDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TransactionDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TransactionDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_WaterBill", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WaterBill", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_WaterBill1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WaterBill", System.Data.DataRowVersion.Original, Nothing))
        '
        'Transactionds1
        '
        Me.Transactionds1.DataSetName = "transactionds"
        Me.Transactionds1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'RoomTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 334)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RoomTransaction"
        Me.Text = "RoomTransaction"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactionds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseUp
        Dim pt = New Point(e.X, e.Y)
        Dim hit As DataGrid.HitTestInfo = DataGrid1.HitTest(pt)
        Dim index As New CommonClass
        If hit.Type = Windows.Forms.DataGrid.HitTestType.Cell Then
            'DataGrid1.CurrentCell = New DataGridCell(1, 1)
            'DataGrid1.Select(hit.Row)
            index.transactionad = CType(Me.Transactionds1.Tables(0).Rows(hit.Row).Item("TransactionID"), String)

            MsgBox(index.custad)
            Me.btnview.Enabled = True
            Me.btndelete.Enabled = True


        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.ComboBox1.Text = "" Then
            MessageBox.Show("Please Select a Search Field!", "Empty Search Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                Dim cmdAdapter As New OleDb.OleDbDataAdapter
                Dim cmd As New OleDb.OleDbCommand
                Dim query As String
                Dim dset As New DataSet
                query = "SELECT * FROM RoomTransaction WHERE(" + Me.ComboBox1.SelectedItem + ")LIKE('%" + Me.TextBox1.Text + "%');"

                cmd = New OleDb.OleDbCommand(query, Me.OleDbConnection1)
                cmdAdapter.SelectCommand = cmd
                cmdAdapter.SelectCommand.CommandType = CommandType.Text
                Me.OleDbConnection1.Open()
                Me.Transactionds1.Clear()
                cmdAdapter.Fill(Me.Transactionds1, "RoomTransaction")
                Me.DataGrid1.DataSource = Me.Transactionds1.RoomTransaction

                Me.OleDbConnection1.Close()


            Catch ex As OleDbException
                MsgBox("Customer Not found" + ex.Message)
            End Try


        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim ind As New TransactionDetails
        ind.MdiParent = MainMenu.ActiveForm()
        ind.addnew()
        ind.Show()
        Me.Close()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Dim ins As New TransactionDetails
        ins.MdiParent = MainMenu.ActiveForm()
        ins.passklant()
        ins.Show()
        Me.Close()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
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
                DeleteCommand.CommandText = "DELETE FROM RoomTransaction where TransactionID= " & Int32.Parse(ind.transactionad)
                DeleteCommand.CommandType = CommandType.Text
                Me.OleDbConnection1.Open()
                DeleteCommand.ExecuteNonQuery()
                Me.OleDbConnection1.Close()


                Me.OleDbDataAdapter1.Fill(Me.Transactionds1, "RoomTransaction")

                Dim psql As String
                psql = " SELECT * FROM RoomTransaction"
                Dim cmdAdapter As New OleDb.OleDbDataAdapter
                Dim cmd As New OleDb.OleDbCommand

                cmd = New OleDb.OleDbCommand(psql, Me.OleDbConnection1)
                cmdAdapter.SelectCommand = cmd
                cmdAdapter.SelectCommand.CommandType = CommandType.Text
                ' Me.OleDbConnection1.Open()
                Me.Transactionds1.Clear()
                'fill in klantds1 dataset
                cmdAdapter.Fill(Me.Transactionds1, "RoomTransaction")
                Me.DataGrid1.DataSource = Me.Transactionds1.RoomTransaction







            Catch ex As OleDbException
                MsgBox(ex.Message)

            End Try
        End If

    End Sub

    Private Sub RoomTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
