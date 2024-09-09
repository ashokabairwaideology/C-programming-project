VERSION 5.00
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Begin VB.Form frmFindProduct 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Find Product"
   ClientHeight    =   6195
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   10320
   Icon            =   "frmFindProduct.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6195
   ScaleWidth      =   10320
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Products"
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
      Height          =   5295
      Index           =   2
      Left            =   3960
      TabIndex        =   21
      Top             =   240
      Width           =   6255
      Begin MSDBGrid.DBGrid DBGrid1 
         Bindings        =   "frmFindProduct.frx":08CA
         Height          =   4935
         Left            =   120
         OleObjectBlob   =   "frmFindProduct.frx":08E3
         TabIndex        =   22
         Top             =   240
         Width           =   6015
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Close"
      Height          =   375
      Left            =   8640
      TabIndex        =   5
      Top             =   5640
      Width           =   1575
   End
   Begin VB.Data db_Division 
      Caption         =   "db_Division"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   8040
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
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7680
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
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7320
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Data db_Category 
      Caption         =   "db_Category"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6960
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
      Height          =   375
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "tblProduct"
      Top             =   8400
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.CommandButton cmd_Select_PurchaseItem 
      Caption         =   "&Select"
      Default         =   -1  'True
      Enabled         =   0   'False
      Height          =   375
      Left            =   6960
      TabIndex        =   4
      Top             =   5640
      Width           =   1575
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
      TabIndex        =   16
      Top             =   240
      Width           =   3735
      Begin VB.ComboBox Combo_CaTegory 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   0
         Top             =   480
         Width           =   2535
      End
      Begin VB.ComboBox Combo_Unit 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   1
         Top             =   840
         Width           =   2535
      End
      Begin VB.ComboBox Combo_Type 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   2
         Top             =   1200
         Width           =   2535
      End
      Begin VB.ComboBox Combo_Division 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   1080
         TabIndex        =   3
         Top             =   1560
         Width           =   2535
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
         TabIndex        =   20
         Top             =   480
         Width           =   630
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
         TabIndex        =   19
         Top             =   840
         Width           =   285
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
         TabIndex        =   18
         Top             =   1200
         Width           =   360
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
         TabIndex        =   17
         Top             =   1560
         Width           =   555
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Product Information"
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
      Height          =   3615
      Index           =   1
      Left            =   120
      TabIndex        =   6
      Top             =   2400
      Width           =   3735
      Begin VB.Frame Frame2 
         BackColor       =   &H00FEEADA&
         BorderStyle     =   0  'None
         Enabled         =   0   'False
         Height          =   3255
         Left            =   960
         TabIndex        =   7
         Top             =   240
         Width           =   2655
         Begin VB.TextBox Text8 
            DataField       =   "Division"
            DataSource      =   "db_Product"
            Height          =   315
            Left            =   120
            TabIndex        =   30
            Top             =   1200
            Width           =   2535
         End
         Begin VB.TextBox Text7 
            DataField       =   "type"
            DataSource      =   "db_Product"
            Height          =   315
            Left            =   120
            TabIndex        =   29
            Top             =   840
            Width           =   2535
         End
         Begin VB.TextBox Text6 
            DataField       =   "unit"
            DataSource      =   "db_Product"
            Height          =   315
            Left            =   120
            TabIndex        =   28
            Top             =   480
            Width           =   2535
         End
         Begin VB.TextBox Text5 
            DataField       =   "category"
            DataSource      =   "db_Product"
            Height          =   315
            Left            =   120
            TabIndex        =   27
            Top             =   120
            Width           =   2535
         End
         Begin VB.TextBox Text4 
            DataField       =   "Remarks"
            DataSource      =   "db_Product"
            Height          =   615
            Left            =   120
            MultiLine       =   -1  'True
            TabIndex        =   11
            Top             =   2640
            Width           =   2535
         End
         Begin VB.TextBox Text3 
            DataField       =   "Qty"
            DataSource      =   "db_Product"
            Height          =   315
            Left            =   120
            TabIndex        =   10
            Top             =   2280
            Width           =   2535
         End
         Begin VB.TextBox Text2 
            DataField       =   "Unit_Price"
            DataSource      =   "db_Product"
            Height          =   315
            Left            =   120
            TabIndex        =   9
            Top             =   1920
            Width           =   2535
         End
         Begin VB.TextBox Text1 
            DataField       =   "Item_Description"
            DataSource      =   "db_Product"
            Height          =   315
            Left            =   120
            TabIndex        =   8
            Top             =   1560
            Width           =   2535
         End
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
         Index           =   11
         Left            =   315
         TabIndex        =   26
         Top             =   1440
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
         Index           =   10
         Left            =   510
         TabIndex        =   25
         Top             =   1080
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
         Index           =   9
         Left            =   585
         TabIndex        =   24
         Top             =   720
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
         Index           =   8
         Left            =   240
         TabIndex        =   23
         Top             =   360
         Width           =   630
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Remarks:"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   4
         Left            =   195
         TabIndex        =   15
         Top             =   2880
         Width           =   675
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Qty Avail.:"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   5
         Left            =   150
         TabIndex        =   14
         Top             =   2520
         Width           =   720
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "UnitPrice:"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   6
         Left            =   180
         TabIndex        =   13
         Top             =   2160
         Width           =   690
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Item Desc.:"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   7
         Left            =   60
         TabIndex        =   12
         Top             =   1800
         Width           =   810
      End
   End
End
Attribute VB_Name = "frmFindProduct"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmd_Select_PurchaseItem_Click()
With db_Product.Recordset
    frmSales.lbl_ItemDescription.Caption = !Item_Description
    frmSales.txt_cOst.Text = !Unit_Price
    frmSales.txt_Category.Text = !Category
    frmSales.txt_Unit.Text = !Unit
    frmSales.txt_Type.Text = !Type
    frmSales.txt_Division.Text = !Division
    frmSales.txt_Availability.Text = !Qty
End With
Unload Me
frmSales.txt_Quantity.SetFocus
SendKeys "{home}" & "+{end}"

End Sub

Private Sub Command1_Click()
Unload Me
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
db_Product.RecordSource = "select * from tblProduct order by type"
db_Product.Refresh
End Sub
Private Sub filter_Product()
db_Product.RecordSource = "Select * from tblproduct where " & "category" & " LIKE '" & Combo_CaTegory.Text & _
                    "*' AND " & "Unit" & " LIKE '" & Combo_Unit.Text & _
                    "*' AND " & "Type" & " LIKE '" & Combo_Type.Text & _
                    "*' AND " & "Division" & " LIKE '" & Combo_Division.Text & "*'"
db_Product.Refresh
If db_Product.Recordset.RecordCount = 0 Or Combo_CaTegory.Text = "" Or Combo_Unit.Text = "" Or Combo_Type.Text = "" Or Combo_Division.Text = "" Then
    cmd_Select_PurchaseItem.Enabled = False

Else
    cmd_Select_PurchaseItem.Enabled = True

End If
End Sub
Private Sub Combo_CaTegory_Click()
filter_Product
End Sub

Private Sub Combo_CaTegory_GotFocus()
db_Category.DatabaseName = App.Path & "\CMJ.mdb"
db_Category.RecordSource = "select * from tblcategory order by type"
db_Category.Refresh
Combo_CaTegory.Clear
With db_Category
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For i = 1 To rec_count
        Combo_CaTegory.AddItem .Recordset.Fields("type")
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



