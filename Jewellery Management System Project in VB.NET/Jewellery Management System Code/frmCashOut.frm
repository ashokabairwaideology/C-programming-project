VERSION 5.00
Begin VB.Form frmCashOut 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Cash OUT"
   ClientHeight    =   4575
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5160
   Icon            =   "frmCashOut.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4575
   ScaleWidth      =   5160
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmd_Category 
      Caption         =   "Add Category"
      Height          =   375
      Left            =   1560
      TabIndex        =   16
      Top             =   4080
      Width           =   1335
   End
   Begin VB.Data db_Category 
      Caption         =   "db_Category"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   5760
      Width           =   2655
   End
   Begin VB.Data db_CashOUT 
      Caption         =   "db_CashOUT"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   5280
      Width           =   2655
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Height          =   2175
      Left            =   120
      TabIndex        =   10
      Top             =   120
      Width           =   4935
      Begin VB.ComboBox Combo_Category 
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
      Begin VB.TextBox txt_GivenBy 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   2
         Top             =   960
         Width           =   3495
      End
      Begin VB.TextBox txt_ReceivedBy 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   3
         Top             =   1320
         Width           =   3495
      End
      Begin VB.TextBox txt_Amount 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1245
         TabIndex        =   4
         Top             =   1680
         Width           =   2055
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Category"
         Height          =   195
         Index           =   5
         Left            =   510
         TabIndex        =   15
         Top             =   600
         Width           =   630
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Date"
         Height          =   255
         Index           =   1
         Left            =   765
         TabIndex        =   14
         Top             =   240
         Width           =   375
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Given by"
         Height          =   255
         Index           =   0
         Left            =   405
         TabIndex        =   13
         Top             =   960
         Width           =   735
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Received by"
         Height          =   195
         Index           =   2
         Left            =   240
         TabIndex        =   12
         Top             =   1320
         Width           =   900
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Amount"
         Height          =   195
         Index           =   3
         Left            =   600
         TabIndex        =   11
         Top             =   1680
         Width           =   540
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Height          =   1575
      Left            =   120
      TabIndex        =   8
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
         TabIndex        =   9
         Top             =   240
         Width           =   630
      End
   End
   Begin VB.CommandButton cmd_receive 
      Caption         =   "Release"
      Default         =   -1  'True
      Height          =   375
      Left            =   3720
      TabIndex        =   7
      Top             =   4080
      Width           =   1335
   End
   Begin VB.CommandButton cmd_Clear 
      Caption         =   "Clear"
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   4080
      Width           =   1335
   End
End
Attribute VB_Name = "frmCashOut"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmd_Category_Click()
frmCashOUTCategory.Show vbModal
End Sub

Private Sub cmd_Clear_Click()
txt_Date.Text = ""
txt_GivenBy.Text = ""
txt_ReceivedBy.Text = ""
txt_Amount.Text = ""
Txt_Remarks.Text = ""
Combo_CaTegory.Text = ""
End Sub

Private Sub cmd_receive_Click()
If txt_Date.Text = "" Then
    MsgBox "Please enter a valid date.", vbExclamation, "Date is missing"
    txt_Date.SetFocus
    Exit Sub
End If
If IsDate(txt_Date) = False Then
    MsgBox "You have an invalid date format. Please enter a valid date.", vbExclamation, "Invalid date format"
    txt_Date.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If

If Combo_CaTegory.Text = "" Then
    MsgBox "Please choose category of Cash OUT.", vbExclamation, "Category is missing"
    Combo_CaTegory.SetFocus
    Exit Sub
End If
If txt_GivenBy.Text = "" Then
    MsgBox "Please enter where the money came from.", vbExclamation, "Given by is missing"
    txt_GivenBy.SetFocus
    Exit Sub
End If
If txt_ReceivedBy.Text = "" Then
    MsgBox "Please enter who released the money.", vbExclamation, "Received by is missing"
    txt_ReceivedBy.SetFocus
    Exit Sub
End If
If txt_Amount.Text = "" Then
    MsgBox "Please enter the amount value for release.", vbExclamation, "Amount received is missing"
    txt_Amount.SetFocus
    Exit Sub
End If
If IsNumeric(txt_Amount) = False Then
    MsgBox "Invalid amount format. Please enter number only.", vbExclamation, "Invalid amount"
    txt_Amount.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If Txt_Remarks = "" Then
    MsgBox "Please enter remarks.", vbExclamation, "Remarks is missing"
    Txt_Remarks.SetFocus
    Exit Sub
End If
If MsgBox("Please confirm releasing this amount", vbYesNo + vbQuestion) = vbYes Then
    'dito yung add sa database
    With db_CashOUT.Recordset
        .AddNew
        !Date = txt_Date.Text
        !givenby = txt_GivenBy.Text
        !receivedby = txt_ReceivedBy.Text
        !amounT = txt_Amount.Text
        !Remarks = Txt_Remarks.Text
        !Category = Combo_CaTegory.Text
        .Update
    End With
    MsgBox "Cash have been released.", vbInformation
    cmd_Clear_Click
Else
    MsgBox "Cash OUT have been aborted."
End If
End Sub

Private Sub Combo_Category_GotFocus()
Dim rec_count, i
db_Category.DatabaseName = App.Path & "\CMJ.mdb"
db_Category.RecordSource = "select * from tblCashOUTCategory"
db_Category.Refresh
Combo_CaTegory.Clear
With db_Category
    .Recordset.MoveLast
    rec_count = .Recordset.RecordCount
    If rec_count <> 0 Then
        .Recordset.MoveFirst
        For i = 1 To rec_count
            Combo_CaTegory.AddItem .Recordset.Fields("category")
            .Recordset.MoveNext
        Next
    End If
End With
End Sub

Private Sub Form_Load()
db_CashOUT.DatabaseName = App.Path & "\CMJ.mdb"
db_CashOUT.RecordSource = "select * from tblCashout"
db_CashOUT.Refresh

db_Category.DatabaseName = App.Path & "\CMJ.mdb"
db_Category.RecordSource = "select * from tblCashOUTCategory"
db_Category.Refresh
End Sub
