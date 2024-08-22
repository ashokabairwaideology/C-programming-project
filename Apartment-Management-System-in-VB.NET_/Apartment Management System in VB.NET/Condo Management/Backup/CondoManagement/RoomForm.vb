Imports System
Imports System.Data
Imports System.Data.OleDb



Public Class RoomForm
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
    Friend WithEvents Roomds1 As CondoManagement.roomds
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Roomds1 = New CondoManagement.roomds
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
        CType(Me.Roomds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Search"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(424, 24)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(120, 32)
        Me.btnsearch.TabIndex = 3
        Me.btnsearch.Text = "Search"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"RoomNo", "Floor"})
        Me.ComboBox1.Location = New System.Drawing.Point(184, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(312, 24)
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
        Me.DataGrid1.DataSource = Me.Roomds1.Room
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 80)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(584, 184)
        Me.DataGrid1.TabIndex = 1
        '
        'Roomds1
        '
        Me.Roomds1.DataSetName = "roomds"
        Me.Roomds1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(8, 280)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(120, 23)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "ADD NEW"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(144, 280)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(136, 23)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "DELETE"
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(296, 280)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(136, 23)
        Me.btnview.TabIndex = 4
        Me.btnview.Text = "VIEW"
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(448, 280)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(136, 23)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "CLOSE"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Room", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RoomNo", "RoomNo"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("RentDate", "RentDate"), New System.Data.Common.DataColumnMapping("LeavingDate", "LeavingDate"), New System.Data.Common.DataColumnMapping("Floor", "Floor"), New System.Data.Common.DataColumnMapping("Contract", "Contract")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Room(RoomNo, CustomerID, Name, RentDate, LeavingDate, Floor, Contract" & _
        ") VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RentDate", System.Data.OleDb.OleDbType.DBDate, 0, "RentDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LeavingDate", System.Data.OleDb.OleDbType.DBDate, 0, "LeavingDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Floor", System.Data.OleDb.OleDbType.Integer, 0, "Floor"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contract", System.Data.OleDb.OleDbType.VarWChar, 50, "Contract"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT RoomNo, CustomerID, Name, RentDate, LeavingDate, Floor, Contract FROM Room" & _
        ""
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Room SET RoomNo = ?, CustomerID = ?, Name = ?, RentDate = ?, LeavingDate =" & _
        " ?, Floor = ?, Contract = ? WHERE (RoomNo = ?) AND (Contract = ? OR ? IS NULL AN" & _
        "D Contract IS NULL) AND (CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND" & _
        " (Floor = ? OR ? IS NULL AND Floor IS NULL) AND (LeavingDate = ? OR ? IS NULL AN" & _
        "D LeavingDate IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (RentDat" & _
        "e = ? OR ? IS NULL AND RentDate IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RoomNo", System.Data.OleDb.OleDbType.Integer, 0, "RoomNo"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.VarWChar, 50, "Name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RentDate", System.Data.OleDb.OleDbType.DBDate, 0, "RentDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LeavingDate", System.Data.OleDb.OleDbType.DBDate, 0, "LeavingDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Floor", System.Data.OleDb.OleDbType.Integer, 0, "Floor"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Contract", System.Data.OleDb.OleDbType.VarWChar, 50, "Contract"))
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
        'RoomForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 326)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RoomForm"
        Me.Text = "RoomForm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roomds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If Me.ComboBox1.Text = "" Then
            MessageBox.Show("Please select a search field!", "Empty search field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                Dim cmdAdapter As New OleDb.OleDbDataAdapter
                Dim cmd As New OleDb.OleDbCommand
                Dim query As String
                Dim dset As New DataSet
                query = "SELECT * FROM Room WHERE(" + Me.ComboBox1.SelectedItem + ")LIKE('%" + Me.TextBox1.Text + "%');"

                cmd = New OleDb.OleDbCommand(query, Me.OleDbConnection1)
                cmdAdapter.SelectCommand = cmd
                cmdAdapter.SelectCommand.CommandType = CommandType.Text
                Me.OleDbConnection1.Open()
                Me.Roomds1.Clear()
                cmdAdapter.Fill(Me.Roomds1, "Room")
                Me.DataGrid1.DataSource = Me.Roomds1.Room
                'Me.Label2.DataBindings.Clear()
                'Me.Label2.DataBindings.Add("Text", dset, "Klantbest.Klantnummer")
                Me.OleDbConnection1.Close()
            Catch ex As OleDbException
                MsgBox("Customer Not found" + ex.Message)
            End Try


        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.Roomds1.Clear()
        Me.OleDbDataAdapter1.Fill(Me.Roomds1, "Room")

    End Sub

    Private Sub RoomForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbDataAdapter1.Fill(Me.Roomds1, "Room")
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
            index.roomad = CType(Me.Roomds1.Tables(0).Rows(hit.Row).Item("RoomNo"), String)

            MsgBox(index.roomad)
            Me.btnview.Enabled = True
            Me.btndelete.Enabled = True


        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        'Dim index As New CommonClass
        'If index.custad = Nothing Then
        '    MsgBox("choose the  Row")
        '    Exit Sub
        'End If

        Dim ind As New RoomDetails
        ind.MdiParent = MainMenu.ActiveForm()
        ind.addnew()
        ind.Show()
        Me.Close()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        'Dim index As New CommonClass
        'If index.custad = Nothing Then
        '    MsgBox("choose the  Row")
        '    Exit Sub
        'End If
        Dim ins As New RoomDetails
        ins.MdiParent = MainMenu.ActiveForm()
        ins.passklant()
        ins.Show()
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
                DeleteCommand.CommandText = "DELETE FROM Room where RoomNo= " & Int32.Parse(ind.roomad)
                DeleteCommand.CommandType = CommandType.Text
                Me.OleDbConnection1.Open()
                DeleteCommand.ExecuteNonQuery()
                Me.OleDbConnection1.Close()


                Me.OleDbDataAdapter1.Fill(Me.Roomds1, "Room")

                Dim psql As String
                psql = " SELECT * FROM Room"
                Dim cmdAdapter As New OleDb.OleDbDataAdapter
                Dim cmd As New OleDb.OleDbCommand

                cmd = New OleDb.OleDbCommand(psql, Me.OleDbConnection1)
                cmdAdapter.SelectCommand = cmd
                cmdAdapter.SelectCommand.CommandType = CommandType.Text
                ' Me.OleDbConnection1.Open()
                Me.Roomds1.Clear()
                'fill in klantds1 dataset
                cmdAdapter.Fill(Me.Roomds1, "Room")
                Me.DataGrid1.DataSource = Me.Roomds1.Room





            Catch ex As OleDbException
                MsgBox(ex.Message)

            End Try
        End If

    End Sub
End Class
