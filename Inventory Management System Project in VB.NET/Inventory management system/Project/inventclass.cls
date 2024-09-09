VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "inventclass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Dim a As Object
Dim f As Form
Public Sub clr(ByVal f)
For Each a In f.Controls
If TypeOf a Is TextBox Then
a.Text = ""
End If
Next a
End Sub
Public Function nul(ByVal f)
For Each a In f.Controls
        If TypeOf a Is TextBox Then
            If a.Text = "" Then
                MsgBox "Enter values"
                Exit Function
            End If
        End If
Next a
nul = 1
End Function
Public Sub char(KeyAscii)
If KeyAscii >= 65 And KeyAscii <= 90 Or KeyAscii = 8 Then
ElseIf KeyAscii >= 97 And KeyAscii <= 122 Then
    KeyAscii = KeyAscii - 32
Else
  KeyAscii = 0
End If
End Sub
Public Sub num(KeyAscii)
If KeyAscii >= 48 And KeyAscii <= 57 Or KeyAscii = 32 Or KeyAscii = 13 Or KeyAscii = 8 Then
Else
KeyAscii = 0
MsgBox "only numbers"
End If
End Sub
Public Sub enbf(ByVal f)
For Each a In f.Controls
If TypeOf a Is TextBox Then
a.Enabled = False
End If
Next a
End Sub
Public Sub enbt(ByVal f)
For Each a In f.Controls
If TypeOf a Is TextBox Then
a.Enabled = True
End If
Next a
End Sub
Public Sub enbcmdf(ByVal f)
For Each a In f.Controls
If TypeOf a Is CommandButton Then
a.Enabled = False
End If
Next a
End Sub
Public Sub enbcmdt(ByVal f)
For Each a In f.Controls
If TypeOf a Is CommandButton Then
a.CommandButton .Enabled = True
End If
Next a
End Sub
Public Sub clall(ByVal f)
For Each a In f.Controls
If TypeOf a Is TextBox Then
  a.Text = ""
End If
Next a
End Sub

