﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class Customerds
    Inherits DataSet
    
    Private tableCustomer As CustomerDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Customer")) Is Nothing) Then
                Me.Tables.Add(New CustomerDataTable(ds.Tables("Customer")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Customer As CustomerDataTable
        Get
            Return Me.tableCustomer
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As Customerds = CType(MyBase.Clone,Customerds)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Customer")) Is Nothing) Then
            Me.Tables.Add(New CustomerDataTable(ds.Tables("Customer")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableCustomer = CType(Me.Tables("Customer"),CustomerDataTable)
        If (Not (Me.tableCustomer) Is Nothing) Then
            Me.tableCustomer.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "Customerds"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/Customerds.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableCustomer = New CustomerDataTable
        Me.Tables.Add(Me.tableCustomer)
    End Sub
    
    Private Function ShouldSerializeCustomer() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub CustomerRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomerRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CustomerDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCustomerID As DataColumn
        
        Private columnFirstName As DataColumn
        
        Private columnLastName As DataColumn
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private columnZipcode As DataColumn
        
        Private columnCountry As DataColumn
        
        Private columnPhone As DataColumn
        
        Private columnEmail As DataColumn
        
        Friend Sub New()
            MyBase.New("Customer")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property CustomerIDColumn As DataColumn
            Get
                Return Me.columnCustomerID
            End Get
        End Property
        
        Friend ReadOnly Property FirstNameColumn As DataColumn
            Get
                Return Me.columnFirstName
            End Get
        End Property
        
        Friend ReadOnly Property LastNameColumn As DataColumn
            Get
                Return Me.columnLastName
            End Get
        End Property
        
        Friend ReadOnly Property AddressColumn As DataColumn
            Get
                Return Me.columnAddress
            End Get
        End Property
        
        Friend ReadOnly Property CityColumn As DataColumn
            Get
                Return Me.columnCity
            End Get
        End Property
        
        Friend ReadOnly Property ZipcodeColumn As DataColumn
            Get
                Return Me.columnZipcode
            End Get
        End Property
        
        Friend ReadOnly Property CountryColumn As DataColumn
            Get
                Return Me.columnCountry
            End Get
        End Property
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Friend ReadOnly Property EmailColumn As DataColumn
            Get
                Return Me.columnEmail
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As CustomerRow
            Get
                Return CType(Me.Rows(index),CustomerRow)
            End Get
        End Property
        
        Public Event CustomerRowChanged As CustomerRowChangeEventHandler
        
        Public Event CustomerRowChanging As CustomerRowChangeEventHandler
        
        Public Event CustomerRowDeleted As CustomerRowChangeEventHandler
        
        Public Event CustomerRowDeleting As CustomerRowChangeEventHandler
        
        Public Overloads Sub AddCustomerRow(ByVal row As CustomerRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddCustomerRow(ByVal FirstName As String, ByVal LastName As String, ByVal Address As String, ByVal City As String, ByVal Zipcode As String, ByVal Country As String, ByVal Phone As String, ByVal Email As String) As CustomerRow
            Dim rowCustomerRow As CustomerRow = CType(Me.NewRow,CustomerRow)
            rowCustomerRow.ItemArray = New Object() {Nothing, FirstName, LastName, Address, City, Zipcode, Country, Phone, Email}
            Me.Rows.Add(rowCustomerRow)
            Return rowCustomerRow
        End Function
        
        Public Function FindByCustomerID(ByVal CustomerID As Integer) As CustomerRow
            Return CType(Me.Rows.Find(New Object() {CustomerID}),CustomerRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As CustomerDataTable = CType(MyBase.Clone,CustomerDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New CustomerDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCustomerID = Me.Columns("CustomerID")
            Me.columnFirstName = Me.Columns("FirstName")
            Me.columnLastName = Me.Columns("LastName")
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.columnZipcode = Me.Columns("Zipcode")
            Me.columnCountry = Me.Columns("Country")
            Me.columnPhone = Me.Columns("Phone")
            Me.columnEmail = Me.Columns("Email")
        End Sub
        
        Private Sub InitClass()
            Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerID)
            Me.columnFirstName = New DataColumn("FirstName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFirstName)
            Me.columnLastName = New DataColumn("LastName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnLastName)
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.columnZipcode = New DataColumn("Zipcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnZipcode)
            Me.columnCountry = New DataColumn("Country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCountry)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.columnEmail = New DataColumn("Email", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmail)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCustomerID}, true))
            Me.columnCustomerID.AutoIncrement = true
            Me.columnCustomerID.AllowDBNull = false
            Me.columnCustomerID.Unique = true
        End Sub
        
        Public Function NewCustomerRow() As CustomerRow
            Return CType(Me.NewRow,CustomerRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New CustomerRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(CustomerRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CustomerRowChangedEvent) Is Nothing) Then
                RaiseEvent CustomerRowChanged(Me, New CustomerRowChangeEvent(CType(e.Row,CustomerRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CustomerRowChangingEvent) Is Nothing) Then
                RaiseEvent CustomerRowChanging(Me, New CustomerRowChangeEvent(CType(e.Row,CustomerRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CustomerRowDeletedEvent) Is Nothing) Then
                RaiseEvent CustomerRowDeleted(Me, New CustomerRowChangeEvent(CType(e.Row,CustomerRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CustomerRowDeletingEvent) Is Nothing) Then
                RaiseEvent CustomerRowDeleting(Me, New CustomerRowChangeEvent(CType(e.Row,CustomerRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveCustomerRow(ByVal row As CustomerRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CustomerRow
        Inherits DataRow
        
        Private tableCustomer As CustomerDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCustomer = CType(Me.Table,CustomerDataTable)
        End Sub
        
        Public Property CustomerID As Integer
            Get
                Return CType(Me(Me.tableCustomer.CustomerIDColumn),Integer)
            End Get
            Set
                Me(Me.tableCustomer.CustomerIDColumn) = value
            End Set
        End Property
        
        Public Property FirstName As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.FirstNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.FirstNameColumn) = value
            End Set
        End Property
        
        Public Property LastName As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.LastNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.LastNameColumn) = value
            End Set
        End Property
        
        Public Property Address As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.AddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.AddressColumn) = value
            End Set
        End Property
        
        Public Property City As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.CityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.CityColumn) = value
            End Set
        End Property
        
        Public Property Zipcode As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.ZipcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.ZipcodeColumn) = value
            End Set
        End Property
        
        Public Property Country As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.CountryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.CountryColumn) = value
            End Set
        End Property
        
        Public Property Phone As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.PhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.PhoneColumn) = value
            End Set
        End Property
        
        Public Property Email As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomer.EmailColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomer.EmailColumn) = value
            End Set
        End Property
        
        Public Function IsFirstNameNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.FirstNameColumn)
        End Function
        
        Public Sub SetFirstNameNull()
            Me(Me.tableCustomer.FirstNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsLastNameNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.LastNameColumn)
        End Function
        
        Public Sub SetLastNameNull()
            Me(Me.tableCustomer.LastNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAddressNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.AddressColumn)
        End Function
        
        Public Sub SetAddressNull()
            Me(Me.tableCustomer.AddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCityNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.CityColumn)
        End Function
        
        Public Sub SetCityNull()
            Me(Me.tableCustomer.CityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsZipcodeNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.ZipcodeColumn)
        End Function
        
        Public Sub SetZipcodeNull()
            Me(Me.tableCustomer.ZipcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCountryNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.CountryColumn)
        End Function
        
        Public Sub SetCountryNull()
            Me(Me.tableCustomer.CountryColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.PhoneColumn)
        End Function
        
        Public Sub SetPhoneNull()
            Me(Me.tableCustomer.PhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsEmailNull() As Boolean
            Return Me.IsNull(Me.tableCustomer.EmailColumn)
        End Function
        
        Public Sub SetEmailNull()
            Me(Me.tableCustomer.EmailColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CustomerRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As CustomerRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As CustomerRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As CustomerRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
