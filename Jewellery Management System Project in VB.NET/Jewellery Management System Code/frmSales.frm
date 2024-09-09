VERSION 5.00
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Begin VB.Form frmSales 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Sales"
   ClientHeight    =   7710
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6585
   Icon            =   "frmSales.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7710
   ScaleWidth      =   6585
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
      Left            =   6720
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "tblProduct"
      Top             =   1440
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Data db_Sales 
      Caption         =   "db_Sales"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   6720
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   960
      Visible         =   0   'False
      Width           =   2775
   End
   Begin VB.Data db_SalesCOntainer 
      Caption         =   "db_SalesCOntainer"
      Connect         =   "Access"
      DatabaseName    =   "D:\CMJ Inventory\CMJ.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   6720
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "tblSalesContainer"
      Top             =   480
      Visible         =   0   'False
      Width           =   2775
   End
   Begin VB.CommandButton cmd_Add_SellItem 
      Caption         =   "&Add"
      Default         =   -1  'True
      Height          =   495
      Left            =   240
      TabIndex        =   25
      Top             =   7080
      Width           =   1335
   End
   Begin VB.CommandButton cmd_Remove_SellItem 
      Caption         =   "&Remove Last Entry"
      Height          =   495
      Left            =   1680
      TabIndex        =   24
      Top             =   7080
      Width           =   1335
   End
   Begin VB.CommandButton cmd_Sold 
      Caption         =   "&Sold"
      Height          =   495
      Left            =   5040
      TabIndex        =   23
      Top             =   7080
      Width           =   1335
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "List of Items"
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
      Height          =   2895
      Index           =   4
      Left            =   240
      TabIndex        =   19
      Top             =   3960
      Width           =   6135
      Begin MSDBGrid.DBGrid DBGrid2 
         Bindings        =   "frmSales.frx":030A
         Height          =   1935
         Left            =   120
         OleObjectBlob   =   "frmSales.frx":032A
         TabIndex        =   20
         Top             =   360
         Width           =   5895
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
         TabIndex        =   22
         Top             =   2520
         Width           =   1650
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
         ForeColor       =   &H000040C0&
         Height          =   285
         Left            =   5490
         TabIndex        =   21
         Top             =   2400
         Width           =   525
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Details"
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
      Index           =   3
      Left            =   240
      TabIndex        =   10
      Top             =   2280
      Width           =   6135
      Begin VB.TextBox txt_Availability 
         Height          =   285
         Left            =   8880
         TabIndex        =   36
         Top             =   240
         Width           =   615
      End
      Begin VB.TextBox txt_Division 
         Height          =   285
         Left            =   7320
         TabIndex        =   34
         Top             =   1320
         Width           =   615
      End
      Begin VB.TextBox txt_Type 
         Height          =   285
         Left            =   7320
         TabIndex        =   33
         Top             =   960
         Width           =   615
      End
      Begin VB.TextBox txt_Unit 
         Height          =   285
         Left            =   7320
         TabIndex        =   32
         Top             =   600
         Width           =   615
      End
      Begin VB.TextBox txt_Category 
         Height          =   285
         Left            =   7320
         TabIndex        =   31
         Top             =   240
         Width           =   615
      End
      Begin VB.CommandButton cmd_productfind 
         Caption         =   "Product"
         Height          =   795
         Left            =   120
         Picture         =   "frmSales.frx":1069
         Style           =   1  'Graphical
         TabIndex        =   26
         TabStop         =   0   'False
         Top             =   360
         Width           =   855
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
         Left            =   2520
         TabIndex        =   12
         Text            =   "0"
         Top             =   720
         Width           =   1095
      End
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
         Left            =   4680
         TabIndex        =   11
         Text            =   "0.00"
         Top             =   720
         Width           =   1335
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Availability"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   0
         Left            =   8040
         TabIndex        =   35
         Top             =   120
         Width           =   735
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
         Left            =   6480
         TabIndex        =   30
         Top             =   120
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
         Index           =   9
         Left            =   6825
         TabIndex        =   29
         Top             =   480
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
         Index           =   10
         Left            =   6750
         TabIndex        =   28
         Top             =   840
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
         Index           =   11
         Left            =   6555
         TabIndex        =   27
         Top             =   1200
         Width           =   555
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
         Left            =   1440
         TabIndex        =   18
         Top             =   360
         Width           =   945
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
         Left            =   1680
         TabIndex        =   17
         Top             =   720
         Width           =   705
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
         Left            =   3720
         TabIndex        =   16
         Top             =   720
         Width           =   810
      End
      Begin VB.Label lbl_ItemDescription 
         BackColor       =   &H00CCE7FB&
         BorderStyle     =   1  'Fixed Single
         Height          =   315
         Left            =   2520
         TabIndex        =   15
         Top             =   360
         Width           =   3495
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
         Left            =   3840
         TabIndex        =   14
         Top             =   1080
         Width           =   660
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
         Left            =   4680
         TabIndex        =   13
         Top             =   1080
         Width           =   1335
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Customer"
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
      Index           =   2
      Left            =   240
      TabIndex        =   4
      Top             =   720
      Width           =   6135
      Begin VB.CommandButton cmd_find 
         Caption         =   "Customer"
         Height          =   795
         Left            =   120
         Picture         =   "frmSales.frx":1933
         Style           =   1  'Graphical
         TabIndex        =   9
         TabStop         =   0   'False
         Top             =   360
         Width           =   855
      End
      Begin VB.TextBox txt_CustomerAddress 
         Height          =   315
         Left            =   2520
         MultiLine       =   -1  'True
         TabIndex        =   6
         Top             =   840
         Width           =   3495
      End
      Begin VB.TextBox txt_CustomerName 
         BackColor       =   &H00CCE7FB&
         Height          =   315
         Left            =   2520
         TabIndex        =   5
         Top             =   480
         Width           =   3495
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Customer Name"
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
         Left            =   1080
         TabIndex        =   8
         Top             =   480
         Width           =   1380
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Cust. Address"
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
         Left            =   1275
         TabIndex        =   7
         Top             =   840
         Width           =   1185
      End
   End
   Begin VB.TextBox txt_dateSold 
      Alignment       =   2  'Center
      BackColor       =   &H00CCE7FB&
      Height          =   315
      Left            =   4620
      TabIndex        =   1
      Top             =   240
      Width           =   1695
   End
   Begin VB.TextBox txt_ORNumber 
      Alignment       =   2  'Center
      BackColor       =   &H00CCE7FB&
      Height          =   315
      Left            =   1695
      TabIndex        =   0
      Top             =   240
      Width           =   1215
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
      Left            =   3105
      TabIndex        =   3
      Top             =   240
      Width           =   1410
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "OR Number"
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
      Left            =   600
      TabIndex        =   2
      Top             =   240
      Width           =   990
   End
End
Attribute VB_Name = "frmSales"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub cmd_Add_SellItem_Click()
If txt_ORNumber.Text = "" Then
    MsgBox "Please enter a valid OR number.", vbExclamation, "OR number is missing"
    txt_ORNumber.SetFocus
    Exit Sub
End If
If IsNumeric(txt_ORNumber) = False Then
    MsgBox "Invalid OR number. Please enter a valid OR number.", vbExclamation, "Invalid OR number"
    txt_ORNumber.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If txt_dateSold.Text = "" Then
    MsgBox "Please enter a valid date.", vbExclamation, "Date is missing"
    txt_dateSold.SetFocus
    Exit Sub
End If
If IsDate(txt_dateSold) = False Then
    MsgBox "Invalid date. Please enter a valid date.", vbExclamation, "Invalid date"
    txt_dateSold.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If txt_CustomerName.Text = "" Then
    MsgBox "Please enter customer's name.", vbExclamation, "Customer's name is missing"
    Exit Sub
End If
If txt_CustomerAddress.Text = "" Then
    MsgBox "Please enter customer's address.", vbExclamation, "Customer's address is missing"
    Exit Sub
End If
If lbl_ItemDescription.Caption = "" Then
    MsgBox "Please choose a product to be sold.", vbExclamation, "Product name is missing"
    cmd_productfind.SetFocus
    Exit Sub
End If
If IsNumeric(txt_Quantity) = False Then
    MsgBox "Invalid quantity. Please enter a valid quantity. Numbers only.", vbExclamation, "Invalid quantity"
    txt_Quantity.SetFocus
    SendKeys "{home}" & "+{end}"
    Exit Sub
End If
If Val(txt_Quantity) < 1 Then
    MsgBox "Please enter a valid quantity.", vbExclamation, "Invalid quantity"
    Exit Sub
End If
If Val(lbl_Amount) < 1 Then
    MsgBox "Invalid amount. Please choose a product.", vbExclamation, "Invalid amount"
    Exit Sub
End If

With db_SalesCOntainer.Recordset
    .AddNew
        !OR_Number = txt_ORNumber.Text
        !Date_Sold = txt_dateSold.Text
        !Customer_Name = txt_CustomerName.Text
        !Customer_Address = txt_CustomerAddress.Text
        !Category = txt_Category.Text
        !Unit = txt_Unit.Text
        !Type = txt_Type.Text
        !Division = txt_Division.Text
        !Item_Description = lbl_ItemDescription.Caption
        !Qty = txt_Quantity.Text
        !Unit_Price = txt_cOst.Text
        !amounT = lbl_Amount.Caption
    .Update
    lbl_TotalAmount.Caption = Val(Format(lbl_TotalAmount, "#########.00")) + Val(Format(lbl_Amount, "#########.00"))
    lbl_TotalAmount.Caption = Format(lbl_TotalAmount, "###,###,###.00")
    lbl_ItemDescription.Caption = ""
    txt_Quantity.Text = "0"
    txt_cOst.Text = "0.00"
    lbl_Amount.Caption = "0.00"
End With
End Sub
Private Sub cmd_find_Click()
frmCustomerFind.Show vbModal
End Sub

Private Sub cmd_productfind_Click()
frmFindProduct.Show vbModal
End Sub

Private Sub cmd_Remove_SellItem_Click()
Dim amounT
If MsgBox("Do you really want to delete the last entry?", vbQuestion + vbYesNo, "Confirm Delete") = vbYes Then
With db_SalesCOntainer
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

Private Sub cmd_Sold_Click()
If MsgBox("Do you really want to sell the product?", vbQuestion + vbYesNo) = vbYes Then
    
    With db_SalesCOntainer
        .Refresh
        If .Recordset.RecordCount <> 0 Then
        .Recordset.MoveLast
        rec_count = .Recordset.RecordCount
        .Recordset.MoveFirst
        For i = 1 To rec_count
            db_Sales.Recordset.AddNew
                db_Sales.Recordset.Fields("OR_Number") = .Recordset.Fields("OR_Number")
                db_Sales.Recordset.Fields("Date_Sold") = .Recordset.Fields("Date_Sold")
                db_Sales.Recordset.Fields("Customer_Name") = .Recordset.Fields("Customer_Name")
                db_Sales.Recordset.Fields("Customer_Address") = .Recordset.Fields("Customer_Address")
                db_Sales.Recordset.Fields("Category") = .Recordset.Fields("Category")
                db_Sales.Recordset.Fields("Unit") = .Recordset.Fields("Unit")
                db_Sales.Recordset.Fields("Type") = .Recordset.Fields("Type")
                db_Sales.Recordset.Fields("Division") = .Recordset.Fields("Division")
                db_Sales.Recordset.Fields("Item_Description") = .Recordset.Fields("Item_Description")
                db_Sales.Recordset.Fields("Qty") = .Recordset.Fields("Qty")
                db_Sales.Recordset.Fields("Unit_Price") = .Recordset.Fields("Unit_Price")
                db_Sales.Recordset.Fields("Amount") = .Recordset.Fields("Amount")
            db_Sales.Recordset.Update
            db_Sales.Refresh
            
            db_Product.RecordSource = "Select * from tblproduct where " & "category" & " LIKE '" & .Recordset.Fields("Category") & _
                        "*' AND " & "Unit" & " LIKE '" & .Recordset.Fields("Unit") & _
                        "*' AND " & "Type" & " LIKE '" & .Recordset.Fields("Type") & _
                        "*' AND " & "Division" & " LIKE '" & .Recordset.Fields("Division") & _
                        "*' AND " & "Item_Description" & " LIKE '" & .Recordset.Fields("Item_Description") & "*'"
            db_Product.Refresh
            If db_Product.Recordset.RecordCount <> 0 Then
                db_Product.Recordset.Edit
                    db_Product.Recordset.Fields("Qty") = Val(db_Product.Recordset.Fields("Qty")) - Val(.Recordset.Fields("Qty"))
                db_Product.Recordset.Update
            Else
                MsgBox "Sorry, I cannot find this product.", vbCritical, "Error"
                Exit Sub
            End If
            .Recordset.MoveNext
        Next
        MsgBox "Product/s has been sold.", vbInformation, "Purchased"
        delete_aLL_In_Container
        clear_ALL
        Else
        MsgBox "Sorry, but there is no product in your list to be sold.", vbCritical, "No product to purchase"
        End If
    End With
Else

End If
End Sub

Private Sub Form_Load()
'db_SalesContainer
db_SalesCOntainer.DatabaseName = App.Path & "\CMJ.mdb"
db_SalesCOntainer.RecordSource = "select * from tblSalesContainer"
db_SalesCOntainer.Refresh
'db_sales
db_Sales.DatabaseName = App.Path & "\CMJ.mdb"
db_Sales.RecordSource = "select * from tblsales"
db_Sales.Refresh

db_Product.DatabaseName = App.Path & "\CMJ.mdb"
db_Product.RecordSource = "select * from tblProduct order by type"
db_Product.Refresh

delete_aLL_In_Container
End Sub

Private Sub txt_cOst_Change()
lbl_Amount.Caption = Val(txt_Quantity.Text) * Val(Format(txt_cOst, "############.00"))
lbl_Amount.Caption = Format(lbl_Amount, "###,###,###,###.00")

End Sub

Private Sub txt_Quantity_Change()
If Val(txt_Quantity) > Val(txt_Availability) Then
    MsgBox "Sorry, but your stock for this product is only limited to " & txt_Availability.Text & " only.", vbExclamation, "Stock is not enough"
    txt_Quantity.Text = "0"
    txt_Quantity.SetFocus
    SendKeys "{home}" & "+{end}"
End If
lbl_Amount.Caption = Val(txt_Quantity.Text) * Val(Format(txt_cOst, "############.00"))
lbl_Amount.Caption = Format(lbl_Amount, "###,###,###,###.00")

End Sub
Private Sub delete_aLL_In_Container()
With db_SalesCOntainer
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
txt_ORNumber.Text = ""
txt_dateSold.Text = ""
txt_CustomerName.Text = ""
txt_CustomerAddress.Text = ""
lbl_ItemDescription.Caption = ""
txt_Quantity.Text = "0"
txt_cOst.Text = "0.00"
lbl_Amount.Caption = "0.00"
lbl_TotalAmount.Caption = "0.00"
End Sub
