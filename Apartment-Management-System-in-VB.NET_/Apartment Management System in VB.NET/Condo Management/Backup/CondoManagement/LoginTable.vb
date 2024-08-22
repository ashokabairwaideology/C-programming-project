Public Class LoginTable
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
    Friend WithEvents objloginsetds As CondoManagement.loginsetds
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents editID As System.Windows.Forms.TextBox
    Friend WithEvents editpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents editusername As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.objloginsetds = New CondoManagement.loginsetds
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.lblpassword = New System.Windows.Forms.Label
        Me.editID = New System.Windows.Forms.TextBox
        Me.editpassword = New System.Windows.Forms.TextBox
        Me.lblusername = New System.Windows.Forms.Label
        Me.editusername = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.objloginsetds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ID, [password], username FROM TableUser"
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO TableUser([password], username) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("password", System.Data.OleDb.OleDbType.VarWChar, 50, "password"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("username", System.Data.OleDb.OleDbType.VarWChar, 50, "username"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE TableUser SET [password] = ?, username = ? WHERE (ID = ?) AND ([password] " & _
        "= ? OR ? IS NULL AND [password] IS NULL) AND (username = ? OR ? IS NULL AND user" & _
        "name IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("password", System.Data.OleDb.OleDbType.VarWChar, 50, "password"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("username", System.Data.OleDb.OleDbType.VarWChar, 50, "username"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_password", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "password", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_password1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "password", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_username", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "username", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_username1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "username", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM TableUser WHERE (ID = ?) AND ([password] = ? OR ? IS NULL AND [passwo" & _
        "rd] IS NULL) AND (username = ? OR ? IS NULL AND username IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_password", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "password", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_password1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "password", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_username", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "username", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_username1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "username", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TableUser", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("password", "password"), New System.Data.Common.DataColumnMapping("username", "username")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'objloginsetds
        '
        Me.objloginsetds.DataSetName = "loginsetds"
        Me.objloginsetds.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(40, 224)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(152, 224)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(8, 48)
        Me.lblID.Name = "lblID"
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "ID"
        '
        'lblpassword
        '
        Me.lblpassword.Location = New System.Drawing.Point(10, 109)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.TabIndex = 4
        Me.lblpassword.Text = "password"
        '
        'editID
        '
        Me.editID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objloginsetds, "TableUser.ID"))
        Me.editID.Location = New System.Drawing.Point(120, 56)
        Me.editID.Name = "editID"
        Me.editID.TabIndex = 5
        Me.editID.Text = ""
        '
        'editpassword
        '
        Me.editpassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objloginsetds, "TableUser.password"))
        Me.editpassword.Location = New System.Drawing.Point(120, 109)
        Me.editpassword.Name = "editpassword"
        Me.editpassword.TabIndex = 6
        Me.editpassword.Text = ""
        '
        'lblusername
        '
        Me.lblusername.Location = New System.Drawing.Point(8, 80)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.TabIndex = 7
        Me.lblusername.Text = "username"
        '
        'editusername
        '
        Me.editusername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objloginsetds, "TableUser.username"))
        Me.editusername.Location = New System.Drawing.Point(120, 80)
        Me.editusername.Name = "editusername"
        Me.editusername.TabIndex = 8
        Me.editusername.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(24, 160)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 9
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(64, 160)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 10
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(104, 160)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 11
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(200, 160)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 12
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(232, 160)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 13
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 192)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Add"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(112, 192)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(200, 192)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "&Cancel"
        '
        'LoginTable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 254)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.editID)
        Me.Controls.Add(Me.editpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.editusername)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "LoginTable"
        Me.Text = "LoginTable"
        CType(Me.objloginsetds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objloginsetds, "TableUser").CancelCurrentEdit()
        Me.objloginsetds_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objloginsetds, "TableUser").Count > 0) Then
            Me.BindingContext(objloginsetds, "TableUser").RemoveAt(Me.BindingContext(objloginsetds, "TableUser").Position)
            Me.objloginsetds_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objloginsetds, "TableUser").EndCurrentEdit()
            Me.BindingContext(objloginsetds, "TableUser").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objloginsetds_PositionChanged()

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
        Me.objloginsetds_PositionChanged()

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
        Me.objloginsetds_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objloginsetds, "TableUser").Position = 0
        Me.objloginsetds_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objloginsetds, "TableUser").Position = (Me.objloginsetds.Tables("TableUser").Rows.Count - 1)
        Me.objloginsetds_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objloginsetds, "TableUser").Position = (Me.BindingContext(objloginsetds, "TableUser").Position - 1)
        Me.objloginsetds_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objloginsetds, "TableUser").Position = (Me.BindingContext(objloginsetds, "TableUser").Position + 1)
        Me.objloginsetds_PositionChanged()

    End Sub
    Private Sub objloginsetds_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objloginsetds, "TableUser").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objloginsetds, "TableUser").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objloginsetds.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As CondoManagement.loginsetds = New CondoManagement.loginsetds
        'Stop any current edits.
        Me.BindingContext(objloginsetds, "TableUser").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objloginsetds.GetChanges, CondoManagement.loginsetds)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objloginsetds.Merge(objDataSetChanges)
                objloginsetds.AcceptChanges()
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
        Dim objDataSetTemp As CondoManagement.loginsetds
        objDataSetTemp = New CondoManagement.loginsetds
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objloginsetds.Clear()
            'Merge the records into the main dataset.
            objloginsetds.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As CondoManagement.loginsetds)
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
    Public Sub FillDataSet(ByVal dataSet As CondoManagement.loginsetds)
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

    Private Sub LoginTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objloginsetds_PositionChanged()
    End Sub
End Class
