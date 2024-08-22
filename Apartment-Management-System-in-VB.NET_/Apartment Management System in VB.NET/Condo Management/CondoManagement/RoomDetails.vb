Public Class RoomDetails
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
    Friend WithEvents objobjroomset As CondoManagement.objroomset
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblContract As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblLeavingDate As System.Windows.Forms.Label
    Friend WithEvents editContract As System.Windows.Forms.TextBox
    Friend WithEvents editCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents editFloor As System.Windows.Forms.TextBox
    Friend WithEvents editLeavingDate As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblRentDate As System.Windows.Forms.Label
    Friend WithEvents lblRoomNo As System.Windows.Forms.Label
    Friend WithEvents editName As System.Windows.Forms.TextBox
    Friend WithEvents editRentDate As System.Windows.Forms.TextBox
    Friend WithEvents editRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RoomDetails))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.objobjroomset = New CondoManagement.objroomset
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.lblContract = New System.Windows.Forms.Label
        Me.lblCustomerID = New System.Windows.Forms.Label
        Me.lblFloor = New System.Windows.Forms.Label
        Me.lblLeavingDate = New System.Windows.Forms.Label
        Me.editContract = New System.Windows.Forms.TextBox
        Me.editCustomerID = New System.Windows.Forms.TextBox
        Me.editFloor = New System.Windows.Forms.TextBox
        Me.editLeavingDate = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblRentDate = New System.Windows.Forms.Label
        Me.lblRoomNo = New System.Windows.Forms.Label
        Me.editName = New System.Windows.Forms.TextBox
        Me.editRentDate = New System.Windows.Forms.TextBox
        Me.editRoomNo = New System.Windows.Forms.TextBox
        Me.btnclose = New System.Windows.Forms.Button
        CType(Me.objobjroomset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Contract, CustomerID, Floor, LeavingDate, Name, RentDate, RoomNo FROM Room" & _
        ""
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Room(Contract, CustomerID, Floor, LeavingDate, Name, RentDate, RoomNo" & _
        ") VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contract", System.Data.OleDb.OleDbType.VarWChar, 50, "Contract"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Floor", System.Data.OleDb.OleDbType.Integer, 0, "Floor"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LeavingDate", System.Data.OleDb.OleDbType.DBDate, 0, "LeavingDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RentDate", System.Data.OleDb.OleDbType.DBDate, 0, "RentDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Room SET Contract = ?, CustomerID = ?, Floor = ?, LeavingDate = ?, Name = " & _
        "?, RentDate = ?, RoomNo = ? WHERE (RoomNo = ?) AND (Contract = ? OR ? IS NULL AN" & _
        "D Contract IS NULL) AND (CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND" & _
        " (Floor = ? OR ? IS NULL AND Floor IS NULL) AND (LeavingDate = ? OR ? IS NULL AN" & _
        "D LeavingDate IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (RentDat" & _
        "e = ? OR ? IS NULL AND RentDate IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contract", System.Data.OleDb.OleDbType.VarWChar, 50, "Contract"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Floor", System.Data.OleDb.OleDbType.Integer, 0, "Floor"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LeavingDate", System.Data.OleDb.OleDbType.DBDate, 0, "LeavingDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RentDate", System.Data.OleDb.OleDbType.DBDate, 0, "RentDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RoomNo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoomNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contract", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contract", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contract1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contract", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Floor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Floor", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Floor1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Floor", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LeavingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeavingDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LeavingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeavingDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentDate", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Room WHERE (RoomNo = ?) AND (Contract = ? OR ? IS NULL AND Contract I" & _
        "S NULL) AND (CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (Floor = ? " & _
        "OR ? IS NULL AND Floor IS NULL) AND (LeavingDate = ? OR ? IS NULL AND LeavingDat" & _
        "e IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (RentDate = ? OR ? I" & _
        "S NULL AND RentDate IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RoomNo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RoomNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contract", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contract", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Contract1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contract", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Floor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Floor", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Floor1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Floor", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LeavingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeavingDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LeavingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LeavingDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Name1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RentDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RentDate", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Room", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Contract", "Contract"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("Floor", "Floor"), New System.Data.Common.DataColumnMapping("LeavingDate", "LeavingDate"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("RentDate", "RentDate"), New System.Data.Common.DataColumnMapping("RoomNo", "RoomNo")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'objobjroomset
        '
        Me.objobjroomset.DataSetName = "objroomset"
        Me.objobjroomset.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(64, 224)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(144, 32)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update/save"
        '
        'lblContract
        '
        Me.lblContract.Location = New System.Drawing.Point(240, 128)
        Me.lblContract.Name = "lblContract"
        Me.lblContract.TabIndex = 3
        Me.lblContract.Text = "Contract"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(16, 48)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.TabIndex = 4
        Me.lblCustomerID.Text = "CustomerID"
        '
        'lblFloor
        '
        Me.lblFloor.Location = New System.Drawing.Point(16, 120)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.TabIndex = 5
        Me.lblFloor.Text = "Floor"
        '
        'lblLeavingDate
        '
        Me.lblLeavingDate.Location = New System.Drawing.Point(16, 152)
        Me.lblLeavingDate.Name = "lblLeavingDate"
        Me.lblLeavingDate.TabIndex = 6
        Me.lblLeavingDate.Text = "LeavingDate"
        '
        'editContract
        '
        Me.editContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjroomset, "Room.Contract"))
        Me.editContract.Location = New System.Drawing.Point(344, 128)
        Me.editContract.Name = "editContract"
        Me.editContract.Size = New System.Drawing.Size(192, 20)
        Me.editContract.TabIndex = 7
        Me.editContract.Text = ""
        '
        'editCustomerID
        '
        Me.editCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjroomset, "Room.CustomerID"))
        Me.editCustomerID.Location = New System.Drawing.Point(128, 40)
        Me.editCustomerID.Name = "editCustomerID"
        Me.editCustomerID.TabIndex = 8
        Me.editCustomerID.Text = ""
        '
        'editFloor
        '
        Me.editFloor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjroomset, "Room.Floor"))
        Me.editFloor.Location = New System.Drawing.Point(128, 120)
        Me.editFloor.Name = "editFloor"
        Me.editFloor.TabIndex = 9
        Me.editFloor.Text = ""
        '
        'editLeavingDate
        '
        Me.editLeavingDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjroomset, "Room.LeavingDate"))
        Me.editLeavingDate.Location = New System.Drawing.Point(128, 152)
        Me.editLeavingDate.Name = "editLeavingDate"
        Me.editLeavingDate.TabIndex = 10
        Me.editLeavingDate.Text = ""
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(240, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 23)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name"
        '
        'lblRentDate
        '
        Me.lblRentDate.Location = New System.Drawing.Point(16, 88)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.TabIndex = 12
        Me.lblRentDate.Text = "RentDate"
        '
        'lblRoomNo
        '
        Me.lblRoomNo.Location = New System.Drawing.Point(24, 8)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.TabIndex = 13
        Me.lblRoomNo.Text = "RoomNo"
        '
        'editName
        '
        Me.editName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjroomset, "Room.Name"))
        Me.editName.Location = New System.Drawing.Point(304, 40)
        Me.editName.Name = "editName"
        Me.editName.Size = New System.Drawing.Size(232, 20)
        Me.editName.TabIndex = 14
        Me.editName.Text = ""
        '
        'editRentDate
        '
        Me.editRentDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjroomset, "Room.RentDate"))
        Me.editRentDate.Location = New System.Drawing.Point(128, 88)
        Me.editRentDate.Name = "editRentDate"
        Me.editRentDate.Size = New System.Drawing.Size(168, 20)
        Me.editRentDate.TabIndex = 15
        Me.editRentDate.Text = ""
        '
        'editRoomNo
        '
        Me.editRoomNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objobjroomset, "Room.RoomNo"))
        Me.editRoomNo.Location = New System.Drawing.Point(128, 8)
        Me.editRoomNo.Name = "editRoomNo"
        Me.editRoomNo.TabIndex = 16
        Me.editRoomNo.Text = ""
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(272, 224)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(120, 32)
        Me.btnclose.TabIndex = 17
        Me.btnclose.Text = "Close"
        '
        'RoomDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(568, 282)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblContract)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblFloor)
        Me.Controls.Add(Me.lblLeavingDate)
        Me.Controls.Add(Me.editContract)
        Me.Controls.Add(Me.editCustomerID)
        Me.Controls.Add(Me.editFloor)
        Me.Controls.Add(Me.editLeavingDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRentDate)
        Me.Controls.Add(Me.lblRoomNo)
        Me.Controls.Add(Me.editName)
        Me.Controls.Add(Me.editRentDate)
        Me.Controls.Add(Me.editRoomNo)
        Me.Name = "RoomDetails"
        Me.Text = "RoomDetails"
        CType(Me.objobjroomset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjroomset, "Room").CancelCurrentEdit()
        Me.objobjroomset_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Me.BindingContext(objobjroomset, "Room").Count > 0) Then
            Me.BindingContext(objobjroomset, "Room").RemoveAt(Me.BindingContext(objobjroomset, "Room").Position)
            Me.objobjroomset_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Clear out the current edits
            Me.BindingContext(objobjroomset, "Room").EndCurrentEdit()
            Me.BindingContext(objobjroomset, "Room").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objobjroomset_PositionChanged()

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
        Me.objobjroomset_PositionChanged()

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
        Me.objobjroomset_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjroomset, "Room").Position = 0
        Me.objobjroomset_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjroomset, "Room").Position = (Me.objobjroomset.Tables("Room").Rows.Count - 1)
        Me.objobjroomset_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjroomset, "Room").Position = (Me.BindingContext(objobjroomset, "Room").Position - 1)
        Me.objobjroomset_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BindingContext(objobjroomset, "Room").Position = (Me.BindingContext(objobjroomset, "Room").Position + 1)
        Me.objobjroomset_PositionChanged()

    End Sub
    Private Sub objobjroomset_PositionChanged()
        'Me.lblNavLocation.Text = (((Me.BindingContext(objobjroomset, "Room").Position + 1).ToString + " of  ") _
        '            + Me.BindingContext(objobjroomset, "Room").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.objobjroomset.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As CondoManagement.objroomset = New CondoManagement.objroomset
        'Stop any current edits.
        Me.BindingContext(objobjroomset, "Room").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objobjroomset.GetChanges, CondoManagement.objroomset)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objobjroomset.Merge(objDataSetChanges)
                objobjroomset.AcceptChanges()
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
        Dim objDataSetTemp As CondoManagement.objroomset
        objDataSetTemp = New CondoManagement.objroomset
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objobjroomset.Clear()
            'Merge the records into the main dataset.
            objobjroomset.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As CondoManagement.objroomset)
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
    Public Sub FillDataSet(ByVal dataSet As CondoManagement.objroomset)
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

    Private Sub RoomDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Function passklant()

        Try

            'btnaddk.Visible = False

            Dim index As New CommonClass
            'sql calling from the Klantbest table
            Dim sql As String
            sql = " SELECT * FROM Room where RoomNo=" & index.roomad
            Dim cmdAdapter As New OleDb.OleDbDataAdapter
            Dim cmd As New OleDb.OleDbCommand

            cmd = New OleDb.OleDbCommand(sql, Me.OleDbConnection1)
            cmdAdapter.SelectCommand = cmd
            cmdAdapter.SelectCommand.CommandType = CommandType.Text
            'Me.OleDbConnection1.Open()
            Me.objobjroomset.Clear()
            'fill in klantds1 dataset
            cmdAdapter.Fill(Me.objobjroomset, "Room")
            'Me.OleDbConnection1.Close()

            'Me.OleDbDataAdapter4.Fill(Me.Verzebasisds1, "Verzekeringsbasis")
            Me.OleDbDataAdapter1.Fill(Me.objobjroomset, "Room")

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
                Me.BindingContext(Me.objobjroomset, "Room").EndCurrentEdit()
                Me.BindingContext(Me.objobjroomset, "Room").AddNew()
                Me.OleDbDataAdapter1.Update(Me.objobjroomset)
            Catch eEndEdit As System.Exception
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        Catch EX As System.Exception

            MsgBox(EX.Message)

        End Try

    End Function
End Class
