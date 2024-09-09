VERSION 5.00
Begin VB.Form frmCashIN 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Cash IN"
   ClientHeight    =   4590
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5205
   Icon            =   "frmCashIN.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4590
   ScaleWidth      =   5205
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmd_Clear 
      Caption         =   "Clear"
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   4080
      Width           =   1335
   End
   Begin VB.Data db_CashIN 
      Caption         =   "db_CashIN"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   360
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   5760
      Width           =   1935
   End
   Begin VB.CommandButton cmd_receive 
      Caption         =   "Receive"
      Default         =   -1  'True
      Height          =   375
      Left            =   3720
      TabIndex        =   7
      Top             =   4080
      Width           =   1335
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Height          =   1575
      Left            =   120
      TabIndex        =   13
      Top             =   2400
      Width           =   4935
      Begin VB.TextBox Txt_Remarks 
         BackColor       =   &H00CCE7FB&
         Height          =   1155
         Left            =   840
         TabIndex        =   5
         Top             =   240
         Width           =   3900
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Remarks"
         Height          =   195
         Index           =   4
         Left            =   120
         TabIndex        =   14
         Top             =   240
         Width           =   630
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Height          =   2175
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   4935
      Begin VB.TextBox Text1 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   4
         Top             =   1680
         Width           =   2055
      End
      Begin VB.TextBox txt_Amount 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   3
         Top             =   1320
         Width           =   2055
      End
      Begin VB.TextBox txt_ReceivedBy 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   2
         Top             =   960
         Width           =   3495
      End
      Begin VB.TextBox txt_GivenBy 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   1
         Top             =   600
         Width           =   3495
      End
      Begin VB.TextBox txt_Date 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   0
         Top             =   240
         Width           =   1575
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "OR Number"
         Height          =   195
         Index           =   5
         Left            =   300
         TabIndex        =   15
         Top             =   1680
         Width           =   840
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Amount"
         Height          =   195
         Index           =   3
         Left            =   600
         TabIndex        =   12
         Top             =   1320
         Width           =   540
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Received by"
         Height          =   195
         Index           =   2
         Left            =   240
         TabIndex        =   11
         Top             =   960
         Width           =   900
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Given by"
         Height          =   255
         Index           =   0
         Left            =   405
         TabIndex        =   10
         Top             =   600
         Width           =   735
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Date"
         Height          =   255
         Index           =   1
         Left            =   765
         TabIndex        =   9
         Top             =   240
         Width           =   375
      End
   End
End
Attribute VB_Name = "frmCashIN"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

End Sub

Private Sub cmd_Clear_Click()
txt_Date.Text = ""
txt_GivenBy.Text = ""
txt_ReceivedBy.Text = ""
txt_Amount.Text = ""
Txt_Remarks.Text = ""
Text1.Text = ""
End Sub

Private Sub cmd_receive_Click()
If IsDate(txt_Date) = False Then
    MsgBox "You have an invalid date format. Please enter a valid date.", vbExclamation, "Invalid date format"
    txt_Date.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If txt_Date.Text = "" Then
    MsgBox "Please enter a valid date.", vbExclamation, "Date is missing"
    txt_Date.SetFocus
    Exit Sub
End If
If txt_GivenBy.Text = "" Then
    MsgBox "Please enter where the money came from.", vbExclamation, "Given by is missing"
    txt_GivenBy.SetFocus
    Exit Sub
End If
If txt_ReceivedBy.Text = "" Then
    MsgBox "Please enter who received the money.", vbExclamation, "Received by is missing"
    txt_ReceivedBy.SetFocus
    Exit Sub
End If
If txt_Amount.Text = "" Then
    MsgBox "Please enter the amount value received.", vbExclamation, "Amount received is missing"
    txt_Amount.SetFocus
    Exit Sub
End If

If IsNumeric(txt_Amount) = False Then
    MsgBox "Invalid amount format. Please enter number only.", vbExclamation, "Invalid amount"
    txt_Amount.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If IsNumeric(Text1) = False Then
    MsgBox "Invalid Official Receipt number. Please enter numbers only.", vbExclamation, "Invalid OR Number"
    Text1.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If Txt_Remarks = "" Then
    MsgBox "Please enter remarks.", vbExclamation, "Remarks is missing"
    Txt_Remarks.SetFocus
    Exit Sub
End If
If Text1.Text <> "" Then
With db_CashIN
    .RecordSource = "select * from tblcashin where  OR ='" & Text1.Text & "'"
    .Refresh
    If .Recordset.RecordCount <> 0 Then
        MsgBox "OR Number already in used. Please enter a new one."
        Exit Sub
    End If
End With
End If

If MsgBox("Please confirm receiving this amount", vbYesNo + vbQuestion) = vbYes Then
    'dito yung add sa database
    With db_CashIN.Recordset
        .AddNew
        !Date = txt_Date.Text
        !givenby = txt_GivenBy.Text
        !receivedby = txt_ReceivedBy.Text
        !amounT = txt_Amount.Text
        !Remarks = Txt_Remarks.Text
        !OR = Text1.Text
        .Update
    End With
    MsgBox "Cash have been received.", vbInformation
    cmd_Clear_Click
Else
    MsgBox "Cash in have been aborted."
End If
End Sub

Private Sub Form_Load()
db_CashIN.DatabaseName = App.Path & "\CMJ.mdb"
db_CashIN.RecordSource = "select * from tblCashIN"
db_CashIN.Refresh
End Sub

