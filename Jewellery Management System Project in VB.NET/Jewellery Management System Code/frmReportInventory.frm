VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmReportInventory 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Inventory Report"
   ClientHeight    =   6315
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9150
   Icon            =   "frmReportInventory.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6315
   ScaleWidth      =   9150
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmd_Asset 
      Caption         =   "Compute Assets on hand"
      Height          =   315
      Left            =   120
      TabIndex        =   15
      Top             =   5880
      Width           =   1935
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Caption         =   "Total value of Products in Inventory"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3960
      TabIndex        =   12
      Top             =   120
      Width           =   5055
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "0.00"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   26.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000080&
         Height          =   600
         Left            =   3840
         TabIndex        =   13
         Top             =   360
         Width           =   1005
      End
   End
   Begin VB.CommandButton cmd_PreviewReport 
      Caption         =   "Preview All Products"
      Height          =   315
      Left            =   6840
      TabIndex        =   11
      Top             =   5880
      Width           =   2175
   End
   Begin VB.CommandButton cmd_Select_PurchaseItem 
      Caption         =   "&Select"
      Enabled         =   0   'False
      Height          =   375
      Left            =   5400
      TabIndex        =   9
      Top             =   6960
      Width           =   3735
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
      Top             =   6840
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
      Top             =   7200
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
      Top             =   7560
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
      Left            =   2760
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6840
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Data db_Product 
      Caption         =   "db_Product"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   2760
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7200
      Width           =   2415
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Filter"
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
      Height          =   2055
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3735
      Begin VB.ComboBox Combo_Division 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   4
         Top             =   1560
         Width           =   2535
      End
      Begin VB.ComboBox Combo_Type 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   3
         Top             =   1200
         Width           =   2535
      End
      Begin VB.ComboBox Combo_Unit 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   2
         Top             =   840
         Width           =   2535
      End
      Begin VB.ComboBox Combo_CaTegory 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   1
         Top             =   480
         Width           =   2535
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
         TabIndex        =   8
         Top             =   1560
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
         TabIndex        =   7
         Top             =   1200
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
         TabIndex        =   6
         Top             =   840
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
         TabIndex        =   5
         Top             =   480
         Width           =   630
      End
   End
   Begin MSComctlLib.ListView lvw_recordsfound 
      Height          =   3495
      Left            =   120
      TabIndex        =   10
      Top             =   2280
      Width           =   8895
      _ExtentX        =   15690
      _ExtentY        =   6165
      View            =   3
      LabelEdit       =   1
      Sorted          =   -1  'True
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      AllowReorder    =   -1  'True
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483647
      BackColor       =   16777215
      Appearance      =   1
      NumItems        =   8
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Item Description"
         Object.Width           =   5292
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Category"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Unit"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Type"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Division"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   1
         SubItemIndex    =   5
         Text            =   "Unit Price"
         Object.Width           =   1764
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   2
         SubItemIndex    =   6
         Text            =   "Qty"
         Object.Width           =   1058
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Text            =   "Remarks"
         Object.Width           =   7056
      EndProperty
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmReportInventory.frx":0442
      Height          =   855
      Left            =   3960
      TabIndex        =   14
      Top             =   1320
      Width           =   5055
   End
End
Attribute VB_Name = "frmReportInventory"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim StartStg As String
Dim Endstg As String
Dim l_results As ListItem
Dim Total_Purchases
Dim rec_count, i, X
Dim amt

Private Sub cmd_Asset_Click()
Dim aSSet
Dim unitPrice
db_Product.DatabaseName = App.Path & "\CMJ.mdb"
db_Product.RecordSource = "select * from tblProduct order by type"
db_Product.Refresh
aSSet = 0
With db_Product
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For i = 1 To rec_count
        unitPrice = Format(.Recordset.Fields("Unit_Price"), "#########.00")
        aSSet = (Val(unitPrice) * Val(.Recordset.Fields("Qty"))) + Val(aSSet)
        .Recordset.MoveNext
    Next
End With
Label2.Caption = Format(aSSet, "###,###,###.00")
End Sub

Private Sub cmd_PreviewReport_Click()
cmd_Asset_Click
 
If DataEnvironment1.rsCommand_Product.State = adStateClosed Then DataEnvironment1.rsCommand_Product.Open
    DataEnvironment1.rsCommand_Product.Requery
    DataEnvironment1.rsCommand_Product.Requery
    Load Rpt_Products
    Rpt_Products.Sections(5).Controls("label22").Caption = Format(Label2, "###,###,###.00")
    Rpt_Products.Show vbModal
If DataEnvironment1.rsCommand_Product.State = adStateOpen Then DataEnvironment1.rsCommand_Product.Close

End Sub

Private Sub Combo_CaTegory_Click()
filter_Product
End Sub

Private Sub Combo_Category_GotFocus()
db_category.DatabaseName = App.Path & "\CMJ.mdb"
db_category.RecordSource = "select * from tblcategory order by type"
db_category.Refresh
Combo_Category.Clear
With db_category
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For i = 1 To rec_count
        Combo_Category.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With
End Sub

Private Sub Combo_Division_Click()
filter_Product
End Sub

Private Sub Combo_Division_GotFocus()
db_Division.DatabaseName = App.Path & "\CMJ.mdb"
db_Division.RecordSource = "select * from tblDivision order by type"
db_Division.Refresh
Combo_Division.Clear
With db_Division
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For X = 1 To rec_count
        Combo_Division.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With

End Sub

Private Sub Combo_Type_Click()
filter_Product
End Sub

Private Sub Combo_Type_GotFocus()
db_Type.DatabaseName = App.Path & "\CMJ.mdb"
db_Type.RecordSource = "select * from tbltype order by type"
db_Type.Refresh
Combo_Type.Clear
With db_Type
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For X = 1 To rec_count
        Combo_Type.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With
End Sub

Private Sub Combo_Unit_Click()
filter_Product
End Sub

Private Sub Combo_Unit_GotFocus()
db_Unit.DatabaseName = App.Path & "\CMJ.mdb"
db_Unit.RecordSource = "select * from tblunit order by type"
db_Unit.Refresh
Combo_Unit.Clear
With db_Unit
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For X = 1 To rec_count
        Combo_Unit.AddItem .Recordset.Fields("type")
        .Recordset.MoveNext
    Next
End With

End Sub

Private Sub Command1_Click()

End Sub

Private Sub Form_Load()
db_Product.DatabaseName = App.Path & "\CMJ.mdb"
db_Product.RecordSource = "select * from tblProduct order by type"
db_Product.Refresh

db_category.DatabaseName = App.Path & "\CMJ.mdb"
db_category.RecordSource = "select * from tblcategory order by type"
db_category.Refresh

db_Type.DatabaseName = App.Path & "\CMJ.mdb"
db_Type.RecordSource = "select * from tbltype order by type"
db_Type.Refresh

db_Unit.DatabaseName = App.Path & "\CMJ.mdb"
db_Unit.RecordSource = "select * from tblunit order by type"
db_Unit.Refresh

db_Division.DatabaseName = App.Path & "\CMJ.mdb"
db_Division.RecordSource = "select * from tbldivision order by type"
db_Division.Refresh

End Sub
Private Sub filter_Product()
lvw_recordsfound.ListItems.Clear
db_Product.RecordSource = "Select * from tblproduct where " & "category" & " LIKE '" & Combo_Category.Text & _
                    "*' AND " & "Unit" & " LIKE '" & Combo_Unit.Text & _
                    "*' AND " & "Type" & " LIKE '" & Combo_Type.Text & _
                    "*' AND " & "Division" & " LIKE '" & Combo_Division.Text & "*'"
db_Product.Refresh
If db_Product.Recordset.RecordCount <> 0 Then
    Populate_lvw_recordsfound
End If
If db_Product.Recordset.RecordCount = 0 Or Combo_Category.Text = "" Or Combo_Unit.Text = "" Or Combo_Type.Text = "" Or Combo_Division.Text = "" Then
    cmd_Select_PurchaseItem.Enabled = False
    'Frame1(2).Enabled = False
Else
    cmd_Select_PurchaseItem.Enabled = True
    
    'Frame1(2).Enabled = True
End If
End Sub

Private Sub Populate_lvw_recordsfound()
Dim rec_count, X
On Err GoTo hell

With db_Product.Recordset
    .MoveLast
    rec_count = .RecordCount
    .MoveFirst
    For X = 1 To rec_count
    
    Set l_results = lvw_recordsfound.ListItems.Add(X, , !Item_Description)
                    l_results.SubItems(1) = !category
                    l_results.SubItems(2) = !unit
                    l_results.SubItems(3) = !Type
                    l_results.SubItems(4) = !division
                    l_results.SubItems(5) = !Unit_Price
                    l_results.SubItems(6) = !Qty
                    l_results.SubItems(7) = !Remarks
                  
    .MoveNext
    Next
End With
hell:
'    MsgBox "Cannot function well. Stupid user is in use.", vbCritical, "STUPID USER"
'    Exit Sub

End Sub
