VERSION 5.00
Begin VB.Form frmCashOUTCategory 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Cash OUT Category Utility"
   ClientHeight    =   3360
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6165
   Icon            =   "frmCashOUTCategory.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3360
   ScaleWidth      =   6165
   StartUpPosition =   2  'CenterScreen
   Begin VB.ListBox List1 
      Appearance      =   0  'Flat
      BackColor       =   &H00CCE7FB&
      Height          =   3150
      Left            =   120
      Sorted          =   -1  'True
      TabIndex        =   4
      Top             =   120
      Width           =   2535
   End
   Begin VB.Data db_category 
      Caption         =   "db_category"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   1800
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   4320
      Width           =   2775
   End
   Begin VB.CommandButton cmd_Add 
      Caption         =   "Add"
      Default         =   -1  'True
      Height          =   375
      Left            =   4680
      TabIndex        =   3
      Top             =   960
      Width           =   1335
   End
   Begin VB.CommandButton cmd_Delete 
      Caption         =   "Delete"
      Height          =   375
      Left            =   3240
      TabIndex        =   2
      Top             =   960
      Width           =   1335
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Height          =   735
      Left            =   2760
      TabIndex        =   0
      Top             =   120
      Width           =   3255
      Begin VB.TextBox txt_Category 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   3015
      End
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmCashOUTCategory.frx":08CA
      Height          =   855
      Left            =   2760
      TabIndex        =   5
      Top             =   2400
      Width           =   3255
   End
End
Attribute VB_Name = "frmCashOUTCategory"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

End Sub

Private Sub cmd_Add_Click()
If txt_Category.Text = "" Then
    MsgBox "Please enter a category.", vbExclamation, "Category is missing"
    txt_Category.SetFocus
    Exit Sub
End If
With db_category.Recordset
    .AddNew
        !category = txt_Category.Text
    .Update
End With
populate_List
End Sub

Private Sub cmd_Delete_Click()
With db_category
    .RecordSource = "select * from tblcashoutcategory where  category = '" & List1.Text & "'"
    .Refresh
    If .Recordset.RecordCount <> 0 Then
        If MsgBox("Do you really want to delete this category", vbYesNo + vbQuestion) = vbYes Then
            .Recordset.Delete
            .Refresh
            populate_List
        End If
    End If
End With
End Sub

Private Sub Form_Load()
db_category.DatabaseName = App.Path & "\CMJ.mdb"
db_category.RecordSource = "select * from tblCashOUTCategory"
db_category.Refresh
populate_List
End Sub
Private Sub populate_List()
Dim rec_count, i
db_category.DatabaseName = App.Path & "\CMJ.mdb"
db_category.RecordSource = "select * from tblCashOUTCategory"
db_category.Refresh
List1.Clear
With db_category
    .Recordset.MoveLast
    rec_count = .Recordset.RecordCount
    If rec_count <> 0 Then
        .Recordset.MoveFirst
        For i = 1 To rec_count
            List1.AddItem .Recordset.Fields("category")
            .Recordset.MoveNext
        Next
    End If
End With

End Sub
