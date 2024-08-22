Public Class TransactionDetails
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
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblDryCleaningBill As System.Windows.Forms.Label
    Friend WithEvents lblElectricityBill As System.Windows.Forms.Label
    Friend WithEvents lblMaintainanceBill As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents editCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents editDryCleaningBill As System.Windows.Forms.TextBox
    Friend WithEvents editElectricityBill As System.Windows.Forms.TextBox
    Friend WithEvents editMaintainanceBill As System.Windows.Forms.TextBox
    Friend WithEvents editMonth As System.Windows.Forms.TextBox
    Friend WithEvents editName As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomNo As System.Windows.Forms.Label
    Friend WithEvents lblTotalBill As System.Windows.Forms.Label
    Friend WithEvents lblTransactionDate As System.Windows.Forms.Label
    Friend WithEvents lblTransactionID As System.Windows.Forms.Label
    Friend WithEvents lblWaterBill As System.Windows.Forms.Label
    Friend WithEvents editRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents editTotalBill As System.Windows.Forms.TextBox
    Friend WithEvents editTransactionDate As System.Windows.Forms.TextBox
    Friend WithEvents editTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents editWaterBill As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrent As System.Windows.Forms.TextBox
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Objtransactionset1 As CondoManagement.objtransactionset
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TransactionDetails))
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.lblCustomerID = New System.Windows.Forms.Label
        Me.lblDryCleaningBill = New System.Windows.Forms.Label
        Me.lblElectricityBill = New System.Windows.Forms.Label
        Me.lblMaintainanceBill = New System.Windows.Forms.Label
        Me.lblMonth = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.editCustomerID = New System.Windows.Forms.TextBox
        Me.editDryCleaningBill = New System.Windows.Forms.TextBox
        Me.editElectricityBill = New System.Windows.Forms.TextBox
        Me.editMaintainanceBill = New System.Windows.Forms.TextBox
        Me.editMonth = New System.Windows.Forms.TextBox
        Me.editName = New System.Windows.Forms.TextBox
        Me.lblRoomNo = New System.Windows.Forms.Label
        Me.lblTotalBill = New System.Windows.Forms.Label
        Me.lblTransactionDate = New System.Windows.Forms.Label
        Me.lblTransactionID = New System.Windows.Forms.Label
        Me.lblWaterBill = New System.Windows.Forms.Label
        Me.editRoomNo = New System.Windows.Forms.TextBox
        Me.editTotalBill = New System.Windows.Forms.TextBox
        Me.editTransactionDate = New System.Windows.Forms.TextBox
        Me.editTransactionID = New System.Windows.Forms.TextBox
        Me.editWaterBill = New System.Windows.Forms.TextBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtrent = New System.Windows.Forms.TextBox
        Me.btncalculate = New System.Windows.Forms.Button
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Objtransactionset1 = New CondoManagement.objtransactionset
        CType(Me.Objtransactionset1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "RoomTransaction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("DryCleaningBill", "DryCleaningBill"), New System.Data.Common.DataColumnMapping("ElectricityBill", "ElectricityBill"), New System.Data.Common.DataColumnMapping("MaintainanceBill", "MaintainanceBill"), New System.Data.Common.DataColumnMapping("Month", "Month"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("RoomNo", "RoomNo"), New System.Data.Common.DataColumnMapping("TotalBill", "TotalBill"), New System.Data.Common.DataColumnMapping("TransactionDate", "TransactionDate"), New System.Data.Common.DataColumnMapping("TransactionID", "TransactionID"), New System.Data.Common.DataColumnMapping("WaterBill", "WaterBill"), New System.Data.Common.DataColumnMapping("RentExpense", "RentExpense")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(48, 288)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(168, 32)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update/save"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(16, 128)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(96, 16)
        Me.lblCustomerID.TabIndex = 3
        Me.lblCustomerID.Text = "CustomerID"
        '
        'lblDryCleaningBill
        '
        Me.lblDryCleaningBill.Location = New System.Drawing.Point(240, 112)
        Me.lblDryCleaningBill.Name = "lblDryCleaningBill"
        Me.lblDryCleaningBill.TabIndex = 4
        Me.lblDryCleaningBill.Text = "DryCleaningBill"
        '
        'lblElectricityBill
        '
        Me.lblElectricityBill.Location = New System.Drawing.Point(240, 168)
        Me.lblElectricityBill.Name = "lblElectricityBill"
        Me.lblElectricityBill.TabIndex = 5
        Me.lblElectricityBill.Text = "ElectricityBill"
        '
        'lblMaintainanceBill
        '
        Me.lblMaintainanceBill.Location = New System.Drawing.Point(232, 200)
        Me.lblMaintainanceBill.Name = "lblMaintainanceBill"
        Me.lblMaintainanceBill.TabIndex = 6
        Me.lblMaintainanceBill.Text = "MaintainanceBill"
        '
        'lblMonth
        '
        Me.lblMonth.Location = New System.Drawing.Point(8, 224)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(96, 16)
        Me.lblMonth.TabIndex = 7
        Me.lblMonth.Text = "Month"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(8, 160)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(96, 16)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'editCustomerID
        '
        Me.editCustomerID.Location = New System.Drawing.Point(128, 128)
        Me.editCustomerID.Name = "editCustomerID"
        Me.editCustomerID.TabIndex = 9
        Me.editCustomerID.Text = ""
        '
        'editDryCleaningBill
        '
        Me.editDryCleaningBill.Location = New System.Drawing.Point(344, 112)
        Me.editDryCleaningBill.Name = "editDryCleaningBill"
        Me.editDryCleaningBill.TabIndex = 10
        Me.editDryCleaningBill.Text = ""
        '
        'editElectricityBill
        '
        Me.editElectricityBill.Location = New System.Drawing.Point(344, 168)
        Me.editElectricityBill.Name = "editElectricityBill"
        Me.editElectricityBill.TabIndex = 11
        Me.editElectricityBill.Text = ""
        '
        'editMaintainanceBill
        '
        Me.editMaintainanceBill.Location = New System.Drawing.Point(344, 200)
        Me.editMaintainanceBill.Name = "editMaintainanceBill"
        Me.editMaintainanceBill.TabIndex = 12
        Me.editMaintainanceBill.Text = ""
        '
        'editMonth
        '
        Me.editMonth.Location = New System.Drawing.Point(120, 224)
        Me.editMonth.Name = "editMonth"
        Me.editMonth.TabIndex = 13
        Me.editMonth.Text = ""
        '
        'editName
        '
        Me.editName.Location = New System.Drawing.Point(128, 160)
        Me.editName.Name = "editName"
        Me.editName.TabIndex = 14
        Me.editName.Text = ""
        '
        'lblRoomNo
        '
        Me.lblRoomNo.Location = New System.Drawing.Point(16, 192)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(96, 16)
        Me.lblRoomNo.TabIndex = 15
        Me.lblRoomNo.Text = "RoomNo"
        '
        'lblTotalBill
        '
        Me.lblTotalBill.Location = New System.Drawing.Point(232, 240)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.TabIndex = 16
        Me.lblTotalBill.Text = "TotalBill"
        '
        'lblTransactionDate
        '
        Me.lblTransactionDate.Location = New System.Drawing.Point(16, 104)
        Me.lblTransactionDate.Name = "lblTransactionDate"
        Me.lblTransactionDate.Size = New System.Drawing.Size(96, 16)
        Me.lblTransactionDate.TabIndex = 17
        Me.lblTransactionDate.Text = "TransactionDate"
        '
        'lblTransactionID
        '
        Me.lblTransactionID.Location = New System.Drawing.Point(16, 80)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(96, 16)
        Me.lblTransactionID.TabIndex = 18
        Me.lblTransactionID.Text = "TransactionID"
        '
        'lblWaterBill
        '
        Me.lblWaterBill.Location = New System.Drawing.Point(240, 136)
        Me.lblWaterBill.Name = "lblWaterBill"
        Me.lblWaterBill.TabIndex = 19
        Me.lblWaterBill.Text = "WaterBill"
        '
        'editRoomNo
        '
        Me.editRoomNo.Location = New System.Drawing.Point(120, 192)
        Me.editRoomNo.Name = "editRoomNo"
        Me.editRoomNo.TabIndex = 20
        Me.editRoomNo.Text = ""
        '
        'editTotalBill
        '
        Me.editTotalBill.Location = New System.Drawing.Point(344, 240)
        Me.editTotalBill.Name = "editTotalBill"
        Me.editTotalBill.TabIndex = 21
        Me.editTotalBill.Text = ""
        '
        'editTransactionDate
        '
        Me.editTransactionDate.Location = New System.Drawing.Point(128, 104)
        Me.editTransactionDate.Name = "editTransactionDate"
        Me.editTransactionDate.TabIndex = 22
        Me.editTransactionDate.Text = ""
        '
        'editTransactionID
        '
        Me.editTransactionID.Location = New System.Drawing.Point(128, 80)
        Me.editTransactionID.Name = "editTransactionID"
        Me.editTransactionID.TabIndex = 23
        Me.editTransactionID.Text = ""
        '
        'editWaterBill
        '
        Me.editWaterBill.Location = New System.Drawing.Point(344, 136)
        Me.editWaterBill.Name = "editWaterBill"
        Me.editWaterBill.TabIndex = 24
        Me.editWaterBill.Text = ""
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(280, 288)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(168, 32)
        Me.btnclose.TabIndex = 25
        Me.btnclose.Text = "Close"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Rent Expense"
        '
        'txtrent
        '
        Me.txtrent.Location = New System.Drawing.Point(344, 80)
        Me.txtrent.Name = "txtrent"
        Me.txtrent.TabIndex = 27
        Me.txtrent.Text = ""
        '
        'btncalculate
        '
        Me.btncalculate.Image = CType(resources.GetObject("btncalculate.Image"), System.Drawing.Image)
        Me.btncalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncalculate.Location = New System.Drawing.Point(448, 136)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(120, 48)
        Me.btncalculate.TabIndex = 28
        Me.btncalculate.Text = "Calculate Total"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CustomerID, DryCleaningBill, ElectricityBill, MaintainanceBill, Month, Nam" & _
        "e, RoomNo, TotalBill, TransactionDate, TransactionID, WaterBill, RentExpense FRO" & _
        "M RoomTransaction"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO RoomTransaction(CustomerID, DryCleaningBill, ElectricityBill, Maintai" & _
        "nanceBill, Month, Name, RoomNo, TotalBill, TransactionDate, WaterBill, RentExpen" & _
        "se) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DryCleaningBill", System.Data.OleDb.OleDbType.Currency, 0, "DryCleaningBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ElectricityBill", System.Data.OleDb.OleDbType.Currency, 0, "ElectricityBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MaintainanceBill", System.Data.OleDb.OleDbType.Currency, 0, "MaintainanceBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Month", System.Data.OleDb.OleDbType.VarWChar, 50, "Month"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalBill", System.Data.OleDb.OleDbType.Currency, 0, "TotalBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TransactionDate", System.Data.OleDb.OleDbType.VarWChar, 50, "TransactionDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("WaterBill", System.Data.OleDb.OleDbType.Currency, 0, "WaterBill"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RentExpense", System.Data.OleDb.OleDbType.Currency, 0, "RentExpense"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE RoomTransaction SET CustomerID = ?, DryCleaningBill = ?, ElectricityBill =" & _
        " ?, MaintainanceBill = ?, Month = ?, Name = ?, RoomNo = ?, TotalBill = ?, Transa" & _
        "ctionDate = ?, WaterBill = ?, RentExpense = ? WHERE (TransactionID = ?) AND (Cus" & _
        "tomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (DryCleaningBill = ? OR ? I" & _
        "S NULL AND DryCleaningBill IS NULL) AND (ElectricityBill = ? OR ? IS NULL AND El" & _
        "ectricityBill IS NULL) AND (MaintainanceBill = ? OR ? IS NULL AND MaintainanceBi" & _
        "ll IS NULL) AND (Month = ? OR ? IS NULL AND Month IS NULL) AND (Name = ? OR ? IS" & _
        " NULL AND Name IS NULL) AND (RentExpense = ? OR ? IS NULL AND RentExpense IS NUL" & _
        "L) AND (RoomNo = ? OR ? IS NULL AND RoomNo IS NULL) AND (TotalBill = ? OR ? IS N" & _
        "ULL AND TotalBill IS NULL) AND (TransactionDate = ? OR ? IS NULL AND Transaction" & _
        "Date IS NULL) AND (WaterBill = ? OR ? IS NULL AND WaterBill IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DryCleaningBill", System.Data.OleDb.OleDbType.Currency, 0, "DryCleaningBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ElectricityBill", System.Data.OleDb.OleDbType.Currency, 0, "ElectricityBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MaintainanceBill", System.Data.OleDb.OleDbType.Currency, 0, "MaintainanceBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Month", System.Data.OleDb.OleDbType.VarWChar, 50, "Month"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalBill", System.Data.OleDb.OleDbType.Currency, 0, "TotalBill"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TransactionDate", System.Data.OleDb.OleDbType.VarWChar, 50, "TransactionDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("WaterBill", System.Data.OleDb.OleDbType.Currency, 0, "WaterBill"))
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
        'Objtransactionset1
        '
        Me.Objtransactionset1.DataSetName = "objtransactionset"
        Me.Objtransactionset1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'TransactionDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 374)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txtrent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblDryCleaningBill)
        Me.Controls.Add(Me.lblElectricityBill)
        Me.Controls.Add(Me.lblMaintainanceBill)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.editCustomerID)
        Me.Controls.Add(Me.editDryCleaningBill)
        Me.Controls.Add(Me.editElectricityBill)
        Me.Controls.Add(Me.editMaintainanceBill)
        Me.Controls.Add(Me.editMonth)
        Me.Controls.Add(Me.editName)
        Me.Controls.Add(Me.lblRoomNo)
        Me.Controls.Add(Me.lblTotalBill)
        Me.Controls.Add(Me.lblTransactionDate)
        Me.Controls.Add(Me.lblTransactionID)
        Me.Controls.Add(Me.lblWaterBill)
        Me.Controls.Add(Me.editRoomNo)
        Me.Controls.Add(Me.editTotalBill)
        Me.Controls.Add(Me.editTransactionDate)
        Me.Controls.Add(Me.editTransactionID)
        Me.Controls.Add(Me.editWaterBill)
        Me.Name = "TransactionDetails"
        Me.Text = "TransactionDetails"
        CType(Me.Objtransactionset1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.BindingContext(objtransactionset, "RoomTransaction").CancelCurrentEdit()
        'Me.Objtransactionset_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (Me.BindingContext(objtransactionset, "RoomTransaction").Count > 0) Then
        '    Me.BindingContext(objtransactionset, "RoomTransaction").RemoveAt(Me.BindingContext(objtransactionset, "RoomTransaction").Position)
        '    Me.Objtransactionset_PositionChanged()
        'End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    'Clear out the current edits
        '    Me.BindingContext(objtransactionset, "RoomTransaction").EndCurrentEdit()
        '    Me.BindingContext(objtransactionset, "RoomTransaction").AddNew()
        'Catch eEndEdit As System.Exception
        '    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        'End Try
        'Me.Objtransactionset_PositionChanged()

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
        Me.Objtransactionset_PositionChanged()

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
        Me.Objtransactionset_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.BindingContext(Objtransactionset, "RoomTransaction").Position = 0
        'Me.Objtransactionset_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.BindingContext(Objtransactionset, "RoomTransaction").Position = (Me.Objtransactionset.Tables("RoomTransaction").Rows.Count - 1)
        'Me.Objtransactionset_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.BindingContext(Objtransactionset, "RoomTransaction").Position = (Me.BindingContext(Objtransactionset, "RoomTransaction").Position - 1)
        'Me.Objtransactionset_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.BindingContext(Objtransactionset, "RoomTransaction").Position = (Me.BindingContext(Objtransactionset, "RoomTransaction").Position + 1)
        'Me.Objtransactionset_PositionChanged()

    End Sub
    Private Sub Objtransactionset_PositionChanged()
        'Me.lblNavLocation.Text = (((Me.BindingContext(Objtransactionset, "RoomTransaction").Position + 1).ToString + " of  ") _
        '            + Me.BindingContext(Objtransactionset, "RoomTransaction").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Objtransactionset.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As CondoManagement.objtransactionset = New CondoManagement.objtransactionset
        'Stop any current edits.
        Me.BindingContext(Me.Objtransactionset1, "RoomTransaction").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(Me.Objtransactionset1.GetChanges, CondoManagement.objtransactionset)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                Me.Objtransactionset1.Merge(objDataSetChanges)
                Me.Objtransactionset1.AcceptChanges()
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
        Dim objDataSetTemp As CondoManagement.objtransactionset
        objDataSetTemp = New CondoManagement.objtransactionset
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            Me.Objtransactionset1.Clear()
            'Merge the records into the main dataset.
            Me.Objtransactionset1.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As CondoManagement.objtransactionset)
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
    Public Sub FillDataSet(ByVal dataSet As CondoManagement.objtransactionset)
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
            sql = " SELECT * FROM RoomTransaction where TransactionID=" & Int32.Parse(index.transactionad)
            Dim cmdAdapter As New OleDb.OleDbDataAdapter
            Dim cmd As New OleDb.OleDbCommand

            cmd = New OleDb.OleDbCommand(sql, Me.OleDbConnection1)
            cmdAdapter.SelectCommand = cmd
            cmdAdapter.SelectCommand.CommandType = CommandType.Text
            'Me.OleDbConnection1.Open()
            Me.Objtransactionset1.Clear()
            'fill in klantds1 dataset
            cmdAdapter.Fill(Me.Objtransactionset1, "RoomTransaction")
            'Me.OleDbConnection1.Close()

            'Me.OleDbDataAdapter4.Fill(Me.Verzebasisds1, "Verzekeringsbasis")
            Me.OleDbDataAdapter1.Fill(Me.Objtransactionset1, "RoomTransaction")

        Catch EX As System.Exception

            'VarModuleName = ClientForm.vb
            'VarProcedureName = passklant
            MsgBox("Could not find Room")

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
            'Me.editCustomerID.Enabled = False
            'Me.btnAdd.Visible = False


            Try
                'Clear out the current edits
                Me.BindingContext(Me.Objtransactionset1, "RoomTransaction").EndCurrentEdit()
                Me.BindingContext(Me.Objtransactionset1, "RoomTransaction").AddNew()
                Me.OleDbDataAdapter1.Update(Me.Objtransactionset1)
            Catch eEndEdit As System.Exception
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        Catch EX As System.Exception

            MsgBox(EX.Message)

        End Try

    End Function

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        Dim rent As Integer
        Dim electric As Integer
        Dim dry As Integer
        Dim main As Integer


    End Sub

    Private Sub TransactionDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Objtransactionset
    End Sub
End Class
