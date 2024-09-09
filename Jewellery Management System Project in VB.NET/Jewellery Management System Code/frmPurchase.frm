VERSION 5.00
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Begin VB.Form frmPurchase 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Purchase item"
   ClientHeight    =   7815
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   10545
   Icon            =   "frmPurchase.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7815
   ScaleWidth      =   10545
   StartUpPosition =   2  'CenterScreen
   Begin VB.Data db_PurchaseContainer 
      Caption         =   "db_PurchaseContainer"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   5400
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "tblPurchase_Container"
      Top             =   8040
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.CommandButton cmd_Select_PurchaseItem 
      Caption         =   "&Select"
      Enabled         =   0   'False
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Top             =   6600
      Width           =   3735
   End
   Begin VB.TextBox txt_PurchaseCode 
      Alignment       =   2  'Center
      BackColor       =   &H00CCE7FB&
      Height          =   315
      Left            =   5715
      TabIndex        =   31
      Top             =   240
      Width           =   1215
   End
   Begin VB.Data db_Purchase 
      Caption         =   "db_Purchase"
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
      Top             =   8640
      Visible         =   0   'False
      Width           =   2415
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
      Top             =   7920
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
      Top             =   8640
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
      Top             =   8280
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
      Left            =   120
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7920
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
      Left            =   2760
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "tblProduct"
      Top             =   8280
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.CommandButton cmd_Purchase_PurchaseItem 
      Caption         =   "&Purchase"
      Height          =   495
      Left            =   9000
      TabIndex        =   29
      Top             =   7200
      Width           =   1335
   End
   Begin VB.CommandButton cmd_Remove_PurchaseItem 
      Caption         =   "&Remove Last Entry"
      Height          =   495
      Left            =   5640
      TabIndex        =   28
      Top             =   7200
      Width           =   1335
   End
   Begin VB.CommandButton cmd_Add_PurchaseItem 
      Caption         =   "&Add"
      Default         =   -1  'True
      Height          =   495
      Left            =   4200
      TabIndex        =   27
      Top             =   7200
      Width           =   1335
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "List of Purchases"
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
      Height          =   3015
      Index           =   3
      Left            =   4200
      TabIndex        =   16
      Top             =   3960
      Width           =   6135
      Begin MSDBGrid.DBGrid DBGrid2 
         Bindings        =   "frmPurchase.frx":08CA
         Height          =   2055
         Left            =   120
         OleObjectBlob   =   "frmPurchase.frx":08ED
         TabIndex        =   17
         Top             =   360
         Width           =   5895
      End
      Begin VB.Label lbl_TotalAmount 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "0.00"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000C0&
         Height          =   285
         Left            =   5490
         TabIndex        =   36
         Top             =   2520
         Width           =   525
      End
      Begin VB.Label Label6 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Total amount (PhP)"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   195
         Left            =   2160
         TabIndex        =   26
         Top             =   2640
         Width           =   1650
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Details"
      Enabled         =   0   'False
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
      Height          =   1575
      Index           =   2
      Left            =   4200
      TabIndex        =   15
      Top             =   2280
      Width           =   6135
      Begin VB.TextBox txt_cOst 
         Alignment       =   1  'Right Justify
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   4320
         TabIndex        =   25
         Text            =   "0.00"
         Top             =   720
         Width           =   1695
      End
      Begin VB.TextBox txt_Quantity 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   24
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000001&
         Height          =   675
         Left            =   1320
         TabIndex        =   24
         Text            =   "0"
         Top             =   720
         Width           =   1695
      End
      Begin VB.Label lbl_Amount 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00CCE7FB&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "0.00"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   4320
         TabIndex        =   34
         Top             =   1080
         Width           =   1695
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Amount"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   1
         Left            =   3480
         TabIndex        =   33
         Top             =   1080
         Width           =   660
      End
      Begin VB.Label lbl_ItemDescription 
         BackColor       =   &H00CCE7FB&
         BorderStyle     =   1  'Fixed Single
         Height          =   315
         Left            =   1320
         TabIndex        =   21
         Top             =   360
         Width           =   4695
      End
      Begin VB.Label Label5 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Unit Price"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   3360
         TabIndex        =   20
         Top             =   720
         Width           =   810
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Quantity"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   0
         Left            =   480
         TabIndex        =   19
         Top             =   720
         Width           =   705
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   0
         Left            =   240
         TabIndex        =   18
         Top             =   360
         Width           =   945
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Supplier"
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
      Height          =   1455
      Index           =   1
      Left            =   4200
      TabIndex        =   11
      Top             =   720
      Width           =   6135
      Begin VB.TextBox txt_SupplierName 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   2520
         TabIndex        =   14
         Top             =   480
         Width           =   3495
      End
      Begin VB.TextBox txt_SupplierAddress 
         Height          =   315
         Left            =   2520
         MultiLine       =   -1  'True
         TabIndex        =   13
         Top             =   840
         Width           =   3495
      End
      Begin VB.CommandButton cmd_supplierfind 
         Caption         =   "Supplier"
         Height          =   670
         Left            =   120
         Picture         =   "frmPurchase.frx":161C
         Style           =   1  'Graphical
         TabIndex        =   12
         Top             =   480
         Width           =   735
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Supplier Address"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   2
         Left            =   1005
         TabIndex        =   23
         Top             =   840
         Width           =   1455
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Supplier Name"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   1
         Left            =   1200
         TabIndex        =   22
         Top             =   480
         Width           =   1260
      End
   End
   Begin VB.TextBox txt_datePurchased 
      Alignment       =   2  'Center
      BackColor       =   &H00CCE7FB&
      Height          =   315
      Left            =   8640
      TabIndex        =   10
      Top             =   240
      Width           =   1695
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
      TabIndex        =   5
      Top             =   120
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
         TabIndex        =   9
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
         TabIndex        =   8
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
         Caption         =   "Division"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   3
         Left            =   315
         TabIndex        =   6
         Top             =   1560
         Width           =   555
      End
   End
   Begin MSDBGrid.DBGrid DBGrid1 
      Bindings        =   "frmPurchase.frx":1926
      Height          =   4215
      Left            =   120
      OleObjectBlob   =   "frmPurchase.frx":193F
      TabIndex        =   35
      Top             =   2280
      Width           =   3735
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Purchase Code:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   4
      Left            =   4260
      TabIndex        =   32
      Top             =   240
      Width           =   1350
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Date Purchased:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   3
      Left            =   7125
      TabIndex        =   30
      Top             =   240
      Width           =   1410
   End
End
Attribute VB_Name = "frmPurchase"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim rec_count, i, X


Private Sub cmd_Add_PurchaseItem_Click()
check_Validity_PurchaseCOde
If txt_PurchaseCode.Text = "" Then
    MsgBox "Please enter purchase code number.", vbExclamation, "Purchase code is missing"
    txt_PurchaseCode.SetFocus
    Exit Sub
End If
If txt_datePurchased.Text = "" Then
    MsgBox "Please enter purchase date.", vbExclamation, "Date purchased is missing"
    txt_datePurchased.SetFocus
    Exit Sub
End If
If IsDate(txt_datePurchased.Text) = False Then
    MsgBox "The date you entered is invalid, please enter a valid date.", vbExclamation, "Date purchased is invalid"
    txt_datePurchased.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If txt_SupplierName.Text = "" Then
    MsgBox "Please choose your supplier.", vbExclamation, "Supplier is missing"
    txt_SupplierName.SetFocus
    Exit Sub
End If
If lbl_ItemDescription.Caption = "" Then
    MsgBox "Please choose your product to be procured.", vbExclamation, "Product name is missing"
    Exit Sub
End If
If txt_cOst.Text = "" Then
    MsgBox "Please enter cost of product.", vbExclamation, "Cost of product is missing"
    txt_cOst.SetFocus
    Exit Sub
End If
If Val(txt_cOst) < 1 Then
    MsgBox "You cannot have a zero cost of product.Please enter numbers more than zero(0).", vbExclamation, "Zero amount is invalid"
    txt_cOst.SetFocus
    Exit Sub
End If
If txt_Quantity.Text = "" Then
    MsgBox "Please enter quantity number.", vbExclamation, "Quantity is missing"
    txt_Quantity.SetFocus
    Exit Sub
End If
If Val(txt_Quantity) < 1 Then
    MsgBox "Invalid quantity. Less than one(1) cannot be accepted in quantity." & Chr(13) & _
    "Deafault amount of quantity is one(1).", vbExclamation, "Invalid quantity"
    txt_Quantity.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
With db_PurchaseContainer.Recordset
    .AddNew
        !category = Combo_CaTegory.Text
        !unit = Combo_Unit.Text
        !Type = Combo_Type.Text
        !division = Combo_Division.Text
        !Item_Description = lbl_ItemDescription.Caption
        !Qty = txt_Quantity.Text
        !cost = txt_cOst.Text
        !Supplier_Name = txt_SupplierName.Text
        !Supplier_Address = txt_SupplierAddress.Text
        !Date_purchased = txt_datePurchased.Text
        !amounT = lbl_Amount.Caption
        !purchase_code = txt_PurchaseCode.Text
    .Update
    lbl_TotalAmount.Caption = Val(Format(lbl_TotalAmount, "#########.00")) + Val(Format(lbl_Amount, "#########.00"))
    lbl_TotalAmount.Caption = Format(lbl_TotalAmount, "###,###,###.00")
    lbl_ItemDescription.Caption = ""
    txt_Quantity.Text = "0"
    txt_cOst.Text = "0.00"
    lbl_Amount.Caption = "0.00"
End With
End Sub

Private Sub cmd_Purchase_PurchaseItem_Click()
If MsgBox("Do you really want to purchase the product?", vbQuestion + vbYesNo) = vbYes Then
    
    With db_PurchaseContainer
        .Refresh
        If .Recordset.RecordCount <> 0 Then
        .Recordset.MoveLast
        rec_count = .Recordset.RecordCount
        .Recordset.MoveFirst
        For i = 1 To rec_count
            db_Purchase.Recordset.AddNew
                db_Purchase.Recordset.Fields("Category") = .Recordset.Fields("Category")
                db_Purchase.Recordset.Fields("Unit") = .Recordset.Fields("Unit")
                db_Purchase.Recordset.Fields("Type") = .Recordset.Fields("Type")
                db_Purchase.Recordset.Fields("Division") = .Recordset.Fields("Division")
                db_Purchase.Recordset.Fields("Item_Description") = .Recordset.Fields("Item_Description")
                db_Purchase.Recordset.Fields("Qty") = .Recordset.Fields("Qty")
                db_Purchase.Recordset.Fields("Cost") = .Recordset.Fields("Cost")
                db_Purchase.Recordset.Fields("Supplier_Name") = .Recordset.Fields("Supplier_Name")
                db_Purchase.Recordset.Fields("Supplier_Address") = .Recordset.Fields("Supplier_Address")
                db_Purchase.Recordset.Fields("Date_Purchased") = .Recordset.Fields("Date_Purchased")
                db_Purchase.Recordset.Fields("Amount") = .Recordset.Fields("Amount")
                db_Purchase.Recordset.Fields("Purchase_Code") = .Recordset.Fields("Purchase_Code")
            db_Purchase.Recordset.Update
            db_Purchase.Refresh
            db_Product.RecordSource = "Select * from tblproduct where " & "category" & " LIKE '" & .Recordset.Fields("Category") & _
                        "*' AND " & "Unit" & " LIKE '" & .Recordset.Fields("Unit") & _
                        "*' AND " & "Type" & " LIKE '" & .Recordset.Fields("Type") & _
                        "*' AND " & "Division" & " LIKE '" & .Recordset.Fields("Division") & _
                        "*' AND " & "Item_Description" & " LIKE '" & .Recordset.Fields("Item_Description") & "*'"
            db_Product.Refresh
            If db_Product.Recordset.RecordCount <> 0 Then
                db_Product.Recordset.Edit
                    db_Product.Recordset.Fields("Qty") = Val(db_Product.Recordset.Fields("Qty")) + Val(.Recordset.Fields("Qty"))
                db_Product.Recordset.Update
            Else
                MsgBox "Sorry, I cannot find this product.", vbCritical, "Error"
                Exit Sub
            End If
            .Recordset.MoveNext
        Next
        MsgBox "Product/s has been purchase.", vbInformation, "Purchased"
        delete_aLL_In_Container
        clear_ALL
        Else
        MsgBox "Sorry, but there is no product in your list to purchase.", vbCritical, "No product to purchase"
        End If
    End With
Else

End If
End Sub

Private Sub cmd_Remove_PurchaseItem_Click()
Dim amounT
If MsgBox("Do you really want to delete the last entry?", vbQuestion + vbYesNo, "Confirm Delete") = vbYes Then
With db_PurchaseContainer
    .Refresh
    If .Recordset.RecordCount <> 0 Then
    .Recordset.MoveLast
    amounT = .Recordset.Fields("Amount")
    lbl_TotalAmount.Caption = Val(Format(lbl_TotalAmount, "#########.00")) - Val(Format(amounT, "#########.00"))
    lbl_TotalAmount.Caption = Format(lbl_TotalAmount, "###,###,###.00")
    .Recordset.Delete
    .Refresh
    Else
        MsgBox "Sorry but there is no record to delete.", vbInformation
        Exit Sub
    End If
End With
Else
    MsgBox "Delete Last Entry has been aborted.", vbInformation, "Delete Last Entry aborted"
End If

End Sub

Private Sub cmd_Select_PurchaseItem_Click()
With db_Product.Recordset
    lbl_ItemDescription.Caption = !Item_Description
    txt_cOst.Text = !Unit_Price
End With
txt_Quantity.SetFocus
SendKeys "{home}" & "+{end}"
End Sub

Private Sub cmd_supplierfind_Click()
frmSupplierFind.Show vbModal
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

db_Purchase.DatabaseName = App.Path & "\CMJ.mdb"
db_Purchase.RecordSource = "select * from tblPurchase"
db_Purchase.Refresh

db_PurchaseContainer.DatabaseName = App.Path & "\CMJ.mdb"
db_PurchaseContainer.RecordSource = "select * from tblPurchase_Container"
db_PurchaseContainer.Refresh

delete_aLL_In_Container
End Sub

Private Sub txt_date_LostFocus()
'If IsDate(txt_Date.Text) = False Then
'    MsgBox "Please enter a valid date.", vbExclamation, "Invalid date"
'    txt_Date.SetFocus
'    SendKeys "{home}" & "{end}"
'End If
End Sub

Private Sub filter_Product()
'DBGrid1.DataSource = "db_Product"
db_Product.RecordSource = "Select * from tblproduct where " & "category" & " LIKE '" & Combo_CaTegory.Text & _
                    "*' AND " & "Unit" & " LIKE '" & Combo_Unit.Text & _
                    "*' AND " & "Type" & " LIKE '" & Combo_Type.Text & _
                    "*' AND " & "Division" & " LIKE '" & Combo_Division.Text & "*'"
db_Product.Refresh
If db_Product.Recordset.RecordCount = 0 Or Combo_CaTegory.Text = "" Or Combo_Unit.Text = "" Or Combo_Type.Text = "" Or Combo_Division.Text = "" Then
    cmd_Select_PurchaseItem.Enabled = False
    Frame1(2).Enabled = False
Else
    cmd_Select_PurchaseItem.Enabled = True
    Frame1(2).Enabled = True
End If
End Sub

Private Sub txt_cOst_Change()
If IsNumeric(txt_cOst.Text) = False Then
    MsgBox "Invalid cost, enter a valid cost of product (Numbers only).", vbExclamation, "Invalid cost amout"
    SendKeys "{home}" & "+{end}"
Else
    lbl_Amount.Caption = Val(txt_Quantity.Text) * Val(Format(txt_cOst, "############.00"))
    lbl_Amount.Caption = Format(lbl_Amount, "###,###,###,###.00")

End If
End Sub

Private Sub txt_PurchaseCode_LostFocus()
check_Validity_PurchaseCOde
End Sub
Private Sub check_Validity_PurchaseCOde()
With db_Purchase
    .RecordSource = "select * from tblpurchase where Purchase_Code ='" & txt_PurchaseCode.Text & "'"
    .Refresh
    If .Recordset.RecordCount <> 0 Then
        MsgBox "Your purchase code already exist. Please enter a valid Purchase code." & Chr(13) & _
        "To avoid seeing this warning enter a new Purchase code.", vbExclamation, "Purchase code already exist."
        'txt_PurchaseCode.SetFocus
        'SendKeys "{home}" & "+{end}"
        Exit Sub
    End If
End With
End Sub
Private Sub txt_Quantity_Change()
lbl_Amount.Caption = Val(txt_Quantity.Text) * Val(Format(txt_cOst, "############.00"))
lbl_Amount.Caption = Format(lbl_Amount, "###,###,###,###.00")
End Sub

Private Sub txt_Quantity_GotFocus()
SendKeys "{home}" & "+{end}"
End Sub

Private Sub delete_aLL_In_Container()
With db_PurchaseContainer
    .Refresh
    If .Recordset.RecordCount <> 0 Then
        .Recordset.MoveLast
        rec_count = .Recordset.RecordCount
        .Recordset.MoveFirst
        For i = 1 To rec_count
            .Recordset.Delete
            .Recordset.MoveNext
        Next
    End If
    .Refresh
End With
End Sub

Private Sub clear_ALL()
txt_PurchaseCode.Text = ""
txt_datePurchased.Text = ""
txt_SupplierName.Text = ""
txt_SupplierAddress.Text = ""
lbl_ItemDescription.Caption = ""
txt_Quantity.Text = "0"
txt_cOst.Text = "0.00"
lbl_Amount.Caption = "0.00"
lbl_TotalAmount.Caption = "0.00"
End Sub
