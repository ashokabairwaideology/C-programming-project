VERSION 5.00
Begin VB.Form frmNewItem 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "New Product Item"
   ClientHeight    =   5130
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6105
   Icon            =   "frmNewItem.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5130
   ScaleWidth      =   6105
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Data db_Product 
      Caption         =   "db_Product"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7920
      Width           =   2535
   End
   Begin VB.CommandButton cmd_Clear_NewItem 
      Caption         =   "&Clear"
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   4560
      Width           =   1095
   End
   Begin VB.Data db_Category 
      Caption         =   "db_Category"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6480
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Data db_Unit 
      Caption         =   "db_Unit"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6840
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Data db_Type 
      Caption         =   "db_Type"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7200
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Data db_Division 
      Caption         =   "db_Division"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7560
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.CommandButton cmd_Cancel_NewItem 
      Caption         =   "Close"
      Height          =   375
      Left            =   4920
      TabIndex        =   10
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton cmd_Add_NewItem 
      Caption         =   "Add"
      Default         =   -1  'True
      Height          =   375
      Left            =   3720
      TabIndex        =   9
      Top             =   4560
      Width           =   1095
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Caption         =   "Detail"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   1935
      Left            =   120
      TabIndex        =   15
      Top             =   2400
      Width           =   5895
      Begin VB.TextBox txt_UnitPRice 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1560
         TabIndex        =   6
         Text            =   "0.00"
         Top             =   720
         Width           =   1095
      End
      Begin VB.TextBox txt_Remarks 
         Height          =   675
         Left            =   1560
         MultiLine       =   -1  'True
         TabIndex        =   7
         Top             =   1080
         Width           =   4095
      End
      Begin VB.TextBox txt_ItemDescription 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1560
         TabIndex        =   5
         Top             =   360
         Width           =   4095
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Unit Price"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   6
         Left            =   690
         TabIndex        =   22
         Top             =   720
         Width           =   690
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Remark"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   5
         Left            =   840
         TabIndex        =   17
         Top             =   1080
         Width           =   555
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Item Description"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   4
         Left            =   240
         TabIndex        =   16
         Top             =   360
         Width           =   1140
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Item type"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   2175
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5895
      Begin VB.ComboBox Combo_Division 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   4
         Top             =   1680
         Width           =   1455
      End
      Begin VB.ComboBox Combo_Type 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   3
         Top             =   1320
         Width           =   1455
      End
      Begin VB.ComboBox Combo_Unit 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   2
         Top             =   960
         Width           =   1455
      End
      Begin VB.ComboBox Combo_CaTegory 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   1
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label lbl_Division 
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   1  'Fixed Single
         Height          =   315
         Left            =   2640
         TabIndex        =   21
         Top             =   1680
         Width           =   3015
      End
      Begin VB.Label lbl_Type 
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   1  'Fixed Single
         Height          =   315
         Left            =   2640
         TabIndex        =   20
         Top             =   1320
         Width           =   3015
      End
      Begin VB.Label lbl_Unit 
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   1  'Fixed Single
         Height          =   315
         Left            =   2640
         TabIndex        =   19
         Top             =   960
         Width           =   3015
      End
      Begin VB.Label lbl_Category 
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   1  'Fixed Single
         Height          =   315
         Left            =   2640
         TabIndex        =   18
         Top             =   480
         Width           =   3015
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Division"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   3
         Left            =   315
         TabIndex        =   14
         Top             =   1680
         Width           =   555
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   2
         Left            =   510
         TabIndex        =   13
         Top             =   1320
         Width           =   360
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Unit"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   1
         Left            =   585
         TabIndex        =   12
         Top             =   960
         Width           =   285
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Category"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   0
         Left            =   240
         TabIndex        =   11
         Top             =   480
         Width           =   630
      End
   End
End
Attribute VB_Name = "frmNewItem"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim rec_count, x

Private Sub cmd_Add_NewItem_Click()
If Combo_CaTegory.Text = "" Then
    MsgBox "Please provide the item's category.", vbExclamation, "Category is missing"
    Exit Sub
End If
If Combo_Unit.Text = "" Then
    MsgBox "Please provide the item's unit.", vbExclamation, "Unit is missing"
    Exit Sub
End If
If Combo_Type.Text = "" Then
    MsgBox "Please provide the item's type.", vbExclamation, "Type is missing"
    Exit Sub
End If
If Combo_Division.Text = "" Then
    MsgBox "Please provide the item's Division.", vbExclamation, "Division is missing"
    Exit Sub
End If
If txt_ItemDescription.Text = "" Then
    MsgBox "Please provide the item's description.", vbExclamation, "Item Description is missing"
    Exit Sub
End If
If Val(txt_UnitPRice.Text) < 1 Then
    MsgBox "The system cannot accept less than one peso value of an item.", vbExclamation, "Invalid amount"
    Exit Sub
End If
If MsgBox("Do you really want to add the new item?: " & Chr(13) & _
            "Category: " & Combo_CaTegory.Text & Chr(13) & _
            "Unit: " & Combo_Unit.Text & Chr(13) & _
            "Type: " & Combo_Type.Text & Chr(13) & _
            "Division: " & Combo_Division.Text & Chr(13) & _
            "Item Description: " & txt_ItemDescription.Text & Chr(13) & _
            "Unit Price: " & txt_UnitPRice.Text & Chr(13) & _
            "Remarks: " & txt_Remarks.Text, vbYesNo + vbQuestion, "Confirm add new item") = vbYes Then
    With db_Product.Recordset
        .AddNew
            !Category = Combo_CaTegory.Text
            !Unit = Combo_Unit.Text
            !Type = Combo_Type.Text
            !Division = Combo_Division.Text
            !Item_Description = txt_ItemDescription.Text
            !Unit_Price = Format(txt_UnitPRice.Text, "###,###,###,###.00")
            !Qty = "0"
            !remarks = txt_Remarks.Text
        .Update
        MsgBox "The item " & txt_ItemDescription.Text & " has been saved to records.", vbInformation
        cmd_Clear_NewItem_Click
    End With
End If

End Sub

Private Sub cmd_Cancel_NewItem_Click()
cmd_Clear_NewItem_Click
Unload Me
End Sub

Private Sub cmd_Clear_NewItem_Click()
Combo_CaTegory.Text = ""
Combo_Unit.Text = ""
Combo_Type.Text = ""
Combo_Division.Text = ""
lbl_Category.Caption = ""
lbl_Unit.Caption = ""
lbl_Type.Caption = ""
lbl_Division.Caption = ""
txt_ItemDescription.Text = ""
txt_UnitPRice.Text = "0.00"
txt_Remarks.Text = ""
End Sub

Private Sub Combo_Category_Change()
'If Combo_CaTegory.Text = "" Then
 '   lbl_Category.Caption = ""
'End If
End Sub

Private Sub Combo_CaTegory_Click()
With db_Category
    .RecordSource = "select * from tblcategory where type  = '" & Combo_CaTegory.Text & "'"
    .Refresh
    lbl_Category.Caption = .Recordset.Fields("Description")
End With
End Sub

Private Sub Combo_CaTegory_GotFocus()
db_Category.DatabaseName = App.Path & "\CMJ.mdb"
db_Category.RecordSource = "select * from tblcategory order by type"
db_Category.Refresh
Combo_CaTegory.Clear
With db_Category
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For x = 1 To rec_count
        Combo_CaTegory.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With

End Sub

Private Sub Combo_Division_Click()
With db_Division
    .RecordSource = "select * from tbldivision where type  = '" & Combo_Division.Text & "'"
    .Refresh
    lbl_Division.Caption = .Recordset.Fields("Description")
End With

End Sub

Private Sub Combo_Division_GotFocus()
db_Division.DatabaseName = App.Path & "\CMJ.mdb"
db_Division.RecordSource = "select * from tblDivision order by type"
db_Division.Refresh
Combo_Division.Clear
With db_Division
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For x = 1 To rec_count
        Combo_Division.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With
End Sub

Private Sub Combo_Type_Click()
With db_Type
    .RecordSource = "select * from tblType where type  = '" & Combo_Type.Text & "'"
    .Refresh
    lbl_Type.Caption = .Recordset.Fields("Description")
End With

End Sub

Private Sub Combo_Type_GotFocus()
db_Type.DatabaseName = App.Path & "\CMJ.mdb"
db_Type.RecordSource = "select * from tbltype order by type"
db_Type.Refresh
Combo_Type.Clear
With db_Type
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For x = 1 To rec_count
        Combo_Type.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With
End Sub

Private Sub Combo_Unit_Click()
With db_Unit
    .RecordSource = "select * from tblunit where type  = '" & Combo_Unit.Text & "'"
    .Refresh
    lbl_Unit.Caption = .Recordset.Fields("Description")
End With

End Sub

Private Sub Combo_Unit_GotFocus()
db_Unit.DatabaseName = App.Path & "\CMJ.mdb"
db_Unit.RecordSource = "select * from tblunit order by type"
db_Unit.Refresh
Combo_Unit.Clear
With db_Unit
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For x = 1 To rec_count
        Combo_Unit.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With
End Sub

Private Sub Command1_Click()

End Sub

Private Sub Form_Load()
db_Category.DatabaseName = App.Path & "\CMJ.mdb"
db_Category.RecordSource = "select * from tblcategory order by type"
db_Category.Refresh

db_Type.DatabaseName = App.Path & "\CMJ.mdb"
db_Type.RecordSource = "select * from tbltype order by type"
db_Type.Refresh

db_Unit.DatabaseName = App.Path & "\CMJ.mdb"
db_Unit.RecordSource = "select * from tblunit order by type"
db_Unit.Refresh

db_Division.DatabaseName = App.Path & "\CMJ.mdb"
db_Division.RecordSource = "select * from tbldivision order by type"
db_Division.Refresh

db_Product.DatabaseName = App.Path & "\CMJ.mdb"
db_Product.RecordSource = "select * from tblproduct order by type"
db_Product.Refresh

End Sub

Private Sub txt_UnitPRice_GotFocus()
SendKeys "{home}" & "+{end}"
End Sub
