VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmDailyCashFLow 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Cash Flow Report"
   ClientHeight    =   4830
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6705
   Icon            =   "frmDailyCashFLow.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4830
   ScaleWidth      =   6705
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmd_Net 
      Caption         =   "Net"
      Height          =   375
      Left            =   7200
      TabIndex        =   21
      Top             =   4080
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.CommandButton cmd_cashOUt 
      Caption         =   "cashOUT"
      Height          =   375
      Left            =   7200
      TabIndex        =   20
      Top             =   3600
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.CommandButton cmd_cashin 
      Caption         =   "cashIN"
      Height          =   375
      Left            =   7200
      TabIndex        =   19
      Top             =   3120
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.CommandButton cmd_purchases 
      Caption         =   "purchases"
      Height          =   375
      Left            =   7200
      TabIndex        =   18
      Top             =   2640
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.CommandButton cmd_sales 
      Caption         =   "sales"
      Height          =   375
      Left            =   7200
      TabIndex        =   17
      Top             =   2160
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.CommandButton cmd_asset 
      Caption         =   "asset"
      Height          =   375
      Left            =   7200
      TabIndex        =   16
      Top             =   1680
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.Data db_CashOUT 
      Caption         =   "db_CashOUT"
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
      Top             =   7320
      Width           =   2895
   End
   Begin VB.Data db_CashIN 
      Caption         =   "db_CashIN"
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
      Top             =   6960
      Width           =   2895
   End
   Begin VB.Data db_Purchases 
      Caption         =   "db_Purchases"
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
      Top             =   6600
      Width           =   2895
   End
   Begin VB.Data db_Sales 
      Caption         =   "db_Sales"
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
      Top             =   6240
      Width           =   2895
   End
   Begin VB.Data db_Products 
      Caption         =   "db_Products"
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
      Top             =   5880
      Width           =   2895
   End
   Begin VB.CommandButton Command2 
      Caption         =   "View Formula of Computation"
      Height          =   495
      Left            =   4560
      TabIndex        =   15
      Top             =   5640
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Height          =   3255
      Left            =   120
      TabIndex        =   2
      Top             =   1440
      Width           =   6495
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Net"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   375
         Index           =   6
         Left            =   3000
         TabIndex        =   14
         Top             =   2640
         Width           =   375
      End
      Begin VB.Label Label7 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   375
         Left            =   3720
         TabIndex        =   13
         Top             =   2640
         Width           =   2655
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   375
         Left            =   3720
         TabIndex        =   12
         Top             =   2160
         Width           =   2655
      End
      Begin VB.Label Label5 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   375
         Left            =   3720
         TabIndex        =   11
         Top             =   1680
         Width           =   2655
      End
      Begin VB.Label Label4 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   375
         Left            =   3720
         TabIndex        =   10
         Top             =   1200
         Width           =   2655
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   375
         Left            =   3720
         TabIndex        =   9
         Top             =   720
         Width           =   2655
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   375
         Left            =   3720
         TabIndex        =   8
         Top             =   240
         Width           =   2655
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Total Sales"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   1
         Left            =   2280
         TabIndex        =   7
         Top             =   720
         Width           =   1080
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Total Purchases"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   2
         Left            =   1800
         TabIndex        =   6
         Top             =   1200
         Width           =   1560
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Total Cash OUT"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   3
         Left            =   1920
         TabIndex        =   5
         Top             =   2160
         Width           =   1470
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Total Cash IN"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   4
         Left            =   2040
         TabIndex        =   4
         Top             =   1680
         Width           =   1305
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Total value of Products Inventory"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   5
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   3300
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Search Report"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6495
      Begin VB.CommandButton Command1 
         Caption         =   "Generate"
         Height          =   495
         Left            =   4440
         TabIndex        =   1
         Top             =   360
         Width           =   1935
      End
      Begin MSComCtl2.DTPicker DT_Start 
         Height          =   315
         Left            =   1170
         TabIndex        =   22
         Top             =   360
         Width           =   2055
         _ExtentX        =   3625
         _ExtentY        =   556
         _Version        =   393216
         Format          =   65339393
         CurrentDate     =   38534
      End
      Begin MSComCtl2.DTPicker DT_End 
         Height          =   315
         Left            =   1170
         TabIndex        =   23
         Top             =   720
         Width           =   2055
         _ExtentX        =   3625
         _ExtentY        =   556
         _Version        =   393216
         Format          =   65339393
         CurrentDate     =   38575
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Start Date"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   8
         Left            =   240
         TabIndex        =   25
         Top             =   360
         Width           =   720
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "End Date"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   7
         Left            =   285
         TabIndex        =   24
         Top             =   720
         Width           =   675
      End
   End
End
Attribute VB_Name = "frmDailyCashFLow"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim aSSet
Dim rec_count, i
Dim unitprice
Dim StartStg As String
Dim EndStg As String
Dim s


Private Sub cmd_asset_Click()
aSSet = 0
With db_Products
    rec_count = .Recordset.RecordCount
    .Recordset.MoveFirst
    For i = 1 To rec_count
        unitprice = Format(.Recordset.Fields("Unit_Price"), "#########.00")
        aSSet = (Val(unitprice) * Val(.Recordset.Fields("Qty"))) + Val(aSSet)
        .Recordset.MoveNext
    Next
End With
Label2.Caption = Format(aSSet, "###,###,###.00")

End Sub

Private Sub cmd_cashin_Click()
StartStg = DT_Start.Value
EndStg = DT_End.Value
db_CashIN.DatabaseName = App.Path & "\CMJ.mdb"
db_CashIN.RecordSource = "select * from tblcashin"
db_CashIN.Refresh
With db_CashIN
 .RecordSource = "select * from tblcashin WHERE (((tblcashin.Date) Between # " + StartStg + " # And # " + EndStg + " #)) "
 .Refresh
 .Recordset.MoveLast
 rec_count = .Recordset.RecordCount
 Label5.Caption = "0.00"
 
 If rec_count <> 0 Then
    .Recordset.MoveFirst
    For i = 1 To rec_count
        s = Format(.Recordset.Fields("Amount"), "#########.00")
        Label5.Caption = Val(s) + Val(Label5.Caption)
        .Recordset.MoveNext
    Next
 End If
 Label5.Caption = Format(Label5, "###,###,###,###.00")
End With
End Sub

Private Sub cmd_cashOUt_Click()
StartStg = DT_Start.Value
EndStg = DT_End.Value
db_CashOUT.DatabaseName = App.Path & "\CMJ.mdb"
db_CashOUT.RecordSource = "select * from tblcashout"
db_CashOUT.Refresh
With db_CashOUT
 .RecordSource = "select * from tblcashout WHERE (((tblcashout.Date) Between # " + StartStg + " # And # " + EndStg + " #)) "
 .Refresh
 .Recordset.MoveLast
 rec_count = .Recordset.RecordCount
 Label6.Caption = "0.00"
 
 If rec_count <> 0 Then
    .Recordset.MoveFirst
    For i = 1 To rec_count
        s = Format(.Recordset.Fields("Amount"), "#########.00")
        Label6.Caption = Val(s) + Val(Label6.Caption)
        .Recordset.MoveNext
    Next
 End If
 Label6.Caption = Format(Label6, "###,###,###,###.00")
End With

End Sub

Private Sub cmd_Net_Click()
Dim net
'(label2+label3+label5)-(label4+label6)
net = (Val(Format(Label2, "#########.00")) + Val(Format(Label3, "#########.00")) + Val(Format(Label5, "#########.00"))) - (Val(Format(Label4, "#########.00")) + Val(Format(Label6, "#########.00")))
Label7.Caption = Val(Format(net, "###,###,###.00"))
End Sub

Private Sub cmd_purchases_Click()
StartStg = DT_Start.Value
EndStg = DT_End.Value
db_Purchases.DatabaseName = App.Path & "\CMJ.mdb"
db_Purchases.RecordSource = "select * from tblpurchase"
db_Purchases.Refresh
With db_Purchases
 .RecordSource = "select * from tblPurchase WHERE (((tblPurchase.Date_Purchased) Between # " + StartStg + " # And # " + EndStg + " #)) "
 .Refresh
 .Recordset.MoveLast
 rec_count = .Recordset.RecordCount
 Label4.Caption = "0.00"
 

 If rec_count <> 0 Then
    .Recordset.MoveFirst
    For i = 1 To rec_count
        s = Format(.Recordset.Fields("Amount"), "#########.00")
        Label4.Caption = Val(s) + Val(Label4.Caption)
        .Recordset.MoveNext
    Next
 End If
 Label4.Caption = Format(Label4, "###,###,###,###.00")
End With
End Sub

Private Sub cmd_sales_Click()
StartStg = DT_Start.Value
EndStg = DT_End.Value
 
rec_count = 0
db_Sales.DatabaseName = App.Path & "\CMJ.mdb"
db_Sales.RecordSource = "select * from tblsales"
db_Sales.Refresh

With db_Sales
 .RecordSource = "select * from tblsales WHERE (((tblsales.Date_Sold) Between # " + StartStg + " # And # " + EndStg + " #)) "
 .Refresh
 .Recordset.MoveLast
 rec_count = .Recordset.RecordCount
 Label3.Caption = "0.00"

 If rec_count <> 0 Then
    .Recordset.MoveFirst
    For i = 1 To rec_count
        s = Format(.Recordset.Fields("Amount"), "#########.00")
        Label3.Caption = Val(s) + Val(Label3.Caption)
        .Recordset.MoveNext
    Next
 End If
 Label3.Caption = Format(Label3, "###,###,###,###.00")
End With
End Sub

Private Sub Command1_Click()
cmd_asset_Click
cmd_sales_Click
cmd_purchases_Click
cmd_cashin_Click
cmd_cashOUt_Click
cmd_Net_Click
End Sub

Private Sub Form_Load()
'db_Products
db_Products.DatabaseName = App.Path & "\CMJ.mdb"
db_Products.RecordSource = "select * from tblProduct"
db_Products.Refresh
'db_Sales
db_Sales.DatabaseName = App.Path & "\CMJ.mdb"
db_Sales.RecordSource = "select * from tblsales"
db_Sales.Refresh
'db_Purchases
db_Purchases.DatabaseName = App.Path & "\CMJ.mdb"
db_Purchases.RecordSource = "select * from tblpurchase"
db_Purchases.Refresh
'db_CashOUT
db_CashOUT.DatabaseName = App.Path & "\CMJ.mdb"
db_CashOUT.RecordSource = "select * from tblcashout"
db_CashOUT.Refresh
'db_CashIN
db_CashIN.DatabaseName = App.Path & "\CMJ.mdb"
db_CashIN.RecordSource = "select * from tblcashin"
db_CashIN.Refresh

End Sub

Private Sub txt_Date_Change()

End Sub

