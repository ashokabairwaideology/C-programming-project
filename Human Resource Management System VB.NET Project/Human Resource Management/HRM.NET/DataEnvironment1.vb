Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Module DataEnvironment_DataEnvironment1_Module
	Friend DataEnvironment1 As DataEnvironment_DataEnvironment1 = New DataEnvironment_DataEnvironment1()
End Module

Friend Class DataEnvironment_DataEnvironment1
	Inherits VB6.BaseDataEnvironment
	Public WithEvents Connection1 As ADODB.Connection
	Public WithEvents rsCommand1 As ADODB.Recordset
	Private m_Command1 As ADODB.Command
	Public WithEvents rsCommand2 As ADODB.Recordset
	Private m_Command2 As ADODB.Command
	Public Sub New()
		MyBase.New()
        'Dim par As ADODB.Parameter
		
		
		Connection1 = New ADODB.Connection()
		Connection1.ConnectionString = "Provider=MSDAORA.1;Password=tiger;User ID=SCOTT;Persist Security Info=True;"
		m_Connections.Add(Connection1, "Connection1")
		m_Command1 = New ADODB.Command()
		rsCommand1 = New ADODB.Recordset()
		m_Command1.Name = "Command1"
		m_Command1.CommandText = "select rNo,rName,Ed,Ex from Resume"
		m_Command1.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsCommand1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsCommand1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsCommand1.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsCommand1.Source = m_Command1
		m_Commands.Add(m_Command1, "Command1")
		m_Recordsets.Add(rsCommand1, "Command1")
		m_Command2 = New ADODB.Command()
		rsCommand2 = New ADODB.Recordset()
		m_Command2.Name = "Command2"
		m_Command2.CommandText = "select * from TrainingSel"
		m_Command2.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsCommand2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsCommand2.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsCommand2.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsCommand2.Source = m_Command2
		m_Commands.Add(m_Command2, "Command2")
		m_Recordsets.Add(rsCommand2, "Command2")
	End Sub
	Public Sub Command1()
		If Connection1.State = ADODB.ObjectStateEnum.adStateClosed Then
			Connection1.Open()
		End If
		If rsCommand1.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsCommand1.Close()
		End If
		m_Command1.ActiveConnection = Connection1
		rsCommand1.Open()
	End Sub
	Public Sub Command2()
		If Connection1.State = ADODB.ObjectStateEnum.adStateClosed Then
			Connection1.Open()
		End If
		If rsCommand2.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsCommand2.Close()
		End If
		m_Command2.ActiveConnection = Connection1
		rsCommand2.Open()
	End Sub
End Class