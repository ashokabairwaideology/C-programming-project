Imports System
Imports System.Data
Imports System.Data.OleDb



Public Class ZieZoDB
    Public Function Main() As OleDbConnection
        Dim CNStr As String
        'CNStr = "server=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Trading;Data Source=ESC03-L9SXFCY3X";
        CNStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\condo.mdb"
        Dim mCN As OleDbConnection

        mCN = New OleDbConnection(CNStr)
        If (mCN.State = ConnectionState.Open) Then
            mCN.Close()
        End If


        mCN.Open()
        Return mCN
    End Function

    Public Function User(ByVal name As String) As String

        If (name = "Shirajul Alam") Then
            name = "me"
            Return name
        End If
    End Function

    Public Function fDataSet(ByVal pSQL As String, ByVal pTableName As String) As DataSet

        Dim pDS = New DataSet
        Dim mDA = New OleDbDataAdapter

        mDA = fAdapter(pSQL)

        If (pTableName <> "") Then

            mDA.Fill(pDS, pTableName)

        Else

            mDA.Fill(pDS)
        End If
        Return pDS
    End Function


    Public Function fAdapter(ByVal pSQL As String) As OleDbDataAdapter
        Dim oda = New OleDbDataAdapter(pSQL, Main())
        Return oda
    End Function

    Public Function fDataReader(ByVal pSQL As String) As OleDbDataReader
        Dim pOddr As OleDbDataReader
        Dim mCM = New OleDbCommand(pSQL, Main())
        pOddr = mCM.ExecuteReader()
        Return pOddr
    End Function





End Class

