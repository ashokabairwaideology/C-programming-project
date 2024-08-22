Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class CommonClass
    Private Shared userid As String ' keep the userid of teh user loging in for admin purpose.
    Private Shared custid As String ' keep the customer id value in global variable 
    Private Shared roomid As String 'keep the room id value in global variable 
    Private Shared transactionid As String 'keep the transaction id in global variable

    Property roomad() As String
        Get
            Return Me.roomid
        End Get
        Set(ByVal Value As String)
            Me.roomid = Value
        End Set
    End Property

    Property transactionad() As String
        Get
            Return Me.transactionid
        End Get
        Set(ByVal Value As String)
            Me.transactionid = Value
        End Set
    End Property


    Property custad() As String
        Get
            Return Me.custid
        End Get
        Set(ByVal Value As String)
            Me.custid = Value
        End Set
    End Property

    Property userad() As String
        Get
            Return Me.userid
        End Get
        Set(ByVal Value As String)
            Me.userid = Value
        End Set
    End Property


End Class
