VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmReportPurchase 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Purchase Report"
   ClientHeight    =   5820
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   8460
   Icon            =   "frmReportPurchase.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5820
   ScaleWidth      =   8460
   StartUpPosition =   2  'CenterScreen
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
      TabIndex        =   1
      Top             =   120
      Width           =   4935
      Begin VB.CommandButton cmdSearch 
         Caption         =   "Search"
         Height          =   315
         Left            =   3360
         TabIndex        =   3
         Top             =   360
         Width           =   1215
      End
      Begin VB.CommandButton cmdClear 
         Caption         =   "Clear"
         Height          =   315
         Left            =   3360
         TabIndex        =   2
         Top             =   720
         Width           =   1215
      End
      Begin MSComCtl2.DTPicker DT_Start 
         Height          =   315
         Left            =   1320
         TabIndex        =   4
         Top             =   360
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   556
         _Version        =   393216
         Format          =   64946177
         CurrentDate     =   38534
      End
      Begin MSComCtl2.DTPicker DT_End 
         Height          =   315
         Left            =   1320
         TabIndex        =   5
         Top             =   720
         Width           =   1695
         _ExtentX        =   2990
         _ExtentY        =   556
         _Version        =   393216
         Format          =   64946177
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
         Index           =   0
         Left            =   390
         TabIndex        =   7
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
         Index           =   1
         Left            =   435
         TabIndex        =   6
         Top             =   720
         Width           =   675
      End
   End
   Begin VB.CommandButton cmd_PreviewReport 
      Caption         =   "Preview Report"
      Enabled         =   0   'False
      Height          =   315
      Left            =   6960
      TabIndex        =   0
      Top             =   5400
      Width           =   1335
   End
   Begin VB.Data db_Purchase 
      Caption         =   "db_Purchase"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   2040
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6720
      Width           =   2535
   End
   Begin MSComctlLib.ListView lvw_recordsfound 
      Height          =   3855
      Left            =   120
      TabIndex        =   8
      Top             =   1440
      Width           =   8175
      _ExtentX        =   14420
      _ExtentY        =   6800
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
      NumItems        =   11
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "PC #"
         Object.Width           =   1058
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Date"
         Object.Width           =   1764
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Supplier Name"
         Object.Width           =   5292
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Category"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Unit"
         Object.Width           =   1764
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Type"
         Object.Width           =   1764
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "Division"
         Object.Width           =   1764
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Text            =   "Item Description"
         Object.Width           =   5292
      EndProperty
      BeginProperty ColumnHeader(9) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   2
         SubItemIndex    =   8
         Text            =   "Qty"
         Object.Width           =   882
      EndProperty
      BeginProperty ColumnHeader(10) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   1
         SubItemIndex    =   9
         Text            =   "Cost Per Unit"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(11) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Alignment       =   1
         SubItemIndex    =   10
         Text            =   "Amount"
         Object.Width           =   2540
      EndProperty
   End
End
Attribute VB_Name = "frmReportPurchase"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim StartStg As String
Dim Endstg As String
Dim l_results As ListItem
Dim Total_Purchases
Dim rec_count, i
Dim amt

Private Sub cmd_PreviewReport_Click()
StartStg = DT_Start.Value
 Endstg = DT_End.Value
If DataEnvironment1.rsCommand_Purchases.State = adStateClosed Then DataEnvironment1.rsCommand_Purchases.Open
    DataEnvironment1.rsCommand_Purchases.Requery
    DataEnvironment1.rsCommand_Purchases.Requery
    DataEnvironment1.Commands(2).CommandText = "select * from tblpurchase WHERE (((tblpurchase.Date_purchased) Between # " + StartStg + " # And # " + Endstg + " #)) "
    DataEnvironment1.Commands(2).Execute
    DataEnvironment1.rsCommand_Purchases.Requery
    DataEnvironment1.rsCommand_Purchases.Requery
    Load Rpt_Purchases
    Rpt_Purchases.Sections(1).Controls("Label5").Caption = "Date of report: " & StartStg & " to " & Endstg
    Rpt_Purchases.Sections(5).Controls("label22").Caption = Format(Total_Purchases, "###,###,###.00")
    Rpt_Purchases.Show vbModal
If DataEnvironment1.rsCommand_Purchases.State = adStateOpen Then DataEnvironment1.rsCommand_Purchases.Close

End Sub

Private Sub cmdClear_Click()
lvw_recordsfound.ListItems.Clear
cmd_PreviewReport.Enabled = False
End Sub

Private Sub cmdSearch_Click()
 StartStg = DT_Start.Value
 Endstg = DT_End.Value
 lvw_recordsfound.ListItems.Clear
 Total_Purchases = 0
With db_Purchase
    .RecordSource = "select * from tblpurchase WHERE (((tblpurchase.Date_purchased) Between # " + StartStg + " # And # " + Endstg + " #)) "
    .Refresh
    rec_count = .Recordset.RecordCount
    If .Recordset.RecordCount <> 0 Then
        Populate_lvw_recordsfound
             
        cmd_PreviewReport.Enabled = True
    Else
        cmd_PreviewReport.Enabled = False
    End If
End With
End Sub

Private Sub Form_Load()
db_Purchase.DatabaseName = App.Path & "\CMJ.mdb"
db_Purchase.RecordSource = "select * from tblpurchase"
db_Purchase.Refresh

End Sub
Private Sub Populate_lvw_recordsfound()
Dim rec_count, X
On Err GoTo hell

'Timer1.Enabled = True
With db_Purchase.Recordset
    .MoveLast
    rec_count = .RecordCount
    .MoveFirst
    For X = 1 To rec_count
    amt = Format(!amounT, "#########.00")
    Total_Purchases = Total_Purchases + Val(amt)
    Set l_results = lvw_recordsfound.ListItems.Add(X, , !purchase_code)
                    l_results.SubItems(1) = !Date_purchased
                    l_results.SubItems(2) = !Supplier_Name
                    l_results.SubItems(3) = !category
                    l_results.SubItems(4) = !unit
                    l_results.SubItems(5) = !Type
                    l_results.SubItems(6) = !division
                    l_results.SubItems(7) = !Item_Description
                    l_results.SubItems(8) = !Qty
                    l_results.SubItems(9) = !cost
                    l_results.SubItems(10) = !amounT
                  
    .MoveNext
    Next
End With
hell:
'    MsgBox "Cannot function well. Stupid user is in use.", vbCritical, "STUPID USER"
'    Exit Sub

End Sub
Private Sub lvw_recordsfound_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    If lvw_recordsfound.SortOrder = lvwAscending Then
        lvw_recordsfound.SortOrder = lvwDescending
    Else
        lvw_recordsfound.SortOrder = lvwAscending
    End If
End Sub

