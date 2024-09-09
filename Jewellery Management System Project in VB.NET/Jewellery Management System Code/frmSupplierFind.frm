VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmSupplierFind 
   BackColor       =   &H00FEEADA&
   Caption         =   "Find Supplier"
   ClientHeight    =   3450
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9465
   Icon            =   "frmSupplierFind.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3450
   ScaleWidth      =   9465
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmd_AddNew 
      Caption         =   "&Add New Record"
      Height          =   375
      Left            =   3360
      TabIndex        =   14
      ToolTipText     =   "Add new record of supplier."
      Top             =   2880
      Width           =   1815
   End
   Begin VB.Data Data1 
      Caption         =   "supplier"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   2400
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   5040
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.CommandButton cmd_clear 
      Caption         =   "Clea&r"
      Height          =   375
      Left            =   2040
      TabIndex        =   11
      Top             =   2400
      Width           =   1215
   End
   Begin VB.CommandButton cmd_search 
      Caption         =   "&Find"
      Default         =   -1  'True
      Enabled         =   0   'False
      Height          =   375
      Left            =   720
      TabIndex        =   10
      Top             =   2400
      Width           =   1215
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00FEEADA&
      Caption         =   "Search by Supplier number"
      Height          =   855
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   3135
      Begin VB.TextBox txt_SupplierNumber 
         Height          =   285
         Left            =   1440
         TabIndex        =   8
         Top             =   360
         Width           =   1575
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Supplier #"
         Height          =   195
         Index           =   1
         Left            =   570
         TabIndex        =   9
         Top             =   360
         Width           =   720
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Caption         =   "Search by Name of Supplier or Contact"
      Height          =   1215
      Left            =   120
      TabIndex        =   2
      Top             =   1080
      Width           =   3135
      Begin VB.TextBox txt_SupplierName 
         Height          =   285
         Left            =   1440
         TabIndex        =   4
         Top             =   360
         Width           =   1575
      End
      Begin VB.TextBox txt_ContactName 
         Height          =   285
         Left            =   1440
         TabIndex        =   3
         Top             =   720
         Width           =   1575
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Supplier Name"
         Height          =   195
         Index           =   0
         Left            =   180
         TabIndex        =   6
         Top             =   360
         Width           =   1035
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Contact Name"
         Height          =   195
         Left            =   165
         TabIndex        =   5
         Top             =   720
         Width           =   1020
      End
   End
   Begin VB.CommandButton cmd_cancel 
      Cancel          =   -1  'True
      Caption         =   "&Close"
      Height          =   375
      Left            =   8040
      TabIndex        =   1
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton cmd_select 
      Caption         =   "&Select"
      Enabled         =   0   'False
      Height          =   375
      Left            =   6720
      TabIndex        =   0
      Top             =   2880
      Width           =   1215
   End
   Begin MSComctlLib.ListView lvw_recordsfound 
      Height          =   2415
      Left            =   3360
      TabIndex        =   12
      Top             =   360
      Width           =   5895
      _ExtentX        =   10398
      _ExtentY        =   4260
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
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Supplier Number"
         Object.Width           =   2646
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Supplier"
         Object.Width           =   6174
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Address"
         Object.Width           =   6174
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Contact Person"
         Object.Width           =   4410
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Contact Number"
         Object.Width           =   3528
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Remarks"
         Object.Width           =   7056
      EndProperty
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Result"
      Height          =   195
      Left            =   3360
      TabIndex        =   13
      Top             =   120
      Width           =   450
   End
End
Attribute VB_Name = "frmSupplierFind"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim l_results As ListItem

Private Sub cmd_AddNew_Click()
frmSupplier.Show vbModal
End Sub

Private Sub cmd_cancel_Click()
Unload Me
End Sub

Private Sub cmd_clear_Click()
lvw_recordsfound.ListItems.Clear
txt_SupplierNumber.Text = ""
txt_SupplierName.Text = ""
txt_ContactName.Text = ""
cmd_search.Enabled = False
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblSupplier"
Data1.Refresh
End Sub

Private Sub cmd_search_Click()
If txt_SupplierNumber.Text = "" And txt_SupplierName.Text = "" And txt_ContactName.Text = "" Or txt_SupplierNumber.Text = " " Or txt_SupplierName.Text = " " Or txt_ContactName.Text = " " Then
    MsgBox "Sorry, cannot search right now. Try to enter a value.", vbExclamation
    Exit Sub
End If
With Data1
    lvw_recordsfound.ListItems.Clear
    'supplier number
    If txt_SupplierNumber.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblsupplier where  sup_Number ='" & Trim(txt_SupplierNumber.Text) & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with supplier number: " & Trim(txt_SupplierNumber.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblsupplier"
            .Refresh
            cmd_select.Enabled = False
            Exit Sub
        Else
            'record/s found
            cmd_select.Enabled = True
            Populate_lvw_recordsfound
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblsupplier"
            .Refresh
            Exit Sub
        End If
    End If
    
    lvw_recordsfound.ListItems.Clear
    'supplier name
    If txt_SupplierName.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblsupplier where  sup_name like '" & Trim(txt_SupplierName.Text) & "*'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with supplier name: " & Trim(txt_SupplierName.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblsupplier"
            .Refresh
            cmd_select.Enabled = False
            Exit Sub
        Else
            'record/s found
            cmd_select.Enabled = True
            Populate_lvw_recordsfound
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblsupplier"
            .Refresh
            Exit Sub
        End If
    End If
    
    lvw_recordsfound.ListItems.Clear
    'contact name
    If txt_ContactName.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblsupplier where  sup_contactperson like '" & Trim(txt_ContactName.Text) & "*'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with contact name: " & Trim(txt_ContactName.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblsupplier"
            .Refresh
            cmd_select.Enabled = False
            Exit Sub
        Else
            'record/s found
            cmd_select.Enabled = True
            Populate_lvw_recordsfound
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblsupplier"
            .Refresh
            Exit Sub
        End If
    End If
End With

End Sub

Private Sub cmd_select_Click()
frmPurchase.txt_SupplierName.Text = l_results.SubItems(1)
frmPurchase.txt_SupplierAddress.Text = l_results.SubItems(2)
Unload Me
End Sub

Private Sub Form_Load()
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblSupplier"
Data1.Refresh
End Sub

Private Sub Form_Resize()
frmSupplierFind.Width = 9585
frmSupplierFind.Height = 3960
End Sub
Private Sub lvw_recordsfound_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    If lvw_recordsfound.SortOrder = lvwAscending Then
        lvw_recordsfound.SortOrder = lvwDescending
    Else
        lvw_recordsfound.SortOrder = lvwAscending
    End If

End Sub

Private Sub txt_ContactName_Change()
If txt_ContactName.Text <> "" Then
    txt_SupplierNumber.Text = ""
    txt_SupplierName.Text = ""
    cmd_search.Enabled = True
Else
    cmd_search.Enabled = False
End If

End Sub

Private Sub txt_SupplierName_Change()
If txt_SupplierName.Text <> "" Then
    txt_SupplierNumber.Text = ""
    txt_ContactName.Text = ""
    cmd_search.Enabled = True
Else
    cmd_search.Enabled = False
End If
End Sub

Private Sub txt_SupplierNumber_Change()
If txt_SupplierNumber.Text <> "" Then
    txt_SupplierName.Text = ""
    txt_ContactName.Text = ""
    cmd_search.Enabled = True
Else
    cmd_search.Enabled = False
End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''
'dito lahat ng pre defined functions
'''''''''''''''''''''''''''''''''''''''''''
Private Sub Populate_lvw_recordsfound()
Dim rec_count, X
With Data1.Recordset
    .MoveLast
    rec_count = .RecordCount
    .MoveFirst
    For X = 1 To rec_count
    Set l_results = lvw_recordsfound.ListItems.Add(X, , !sup_number)
                    l_results.SubItems(1) = !sup_name
                    l_results.SubItems(2) = !sup_StreetAddress & ", " & !sup_City & ", " & !sup_Province & " " & !sup_Zip
                    l_results.SubItems(3) = !sup_Contactperson
                    l_results.SubItems(4) = !sup_contactnumber
                    l_results.SubItems(5) = !sup_remarks
    .MoveNext
    Next
End With
End Sub

Private Sub txt_SupplierNumber_GotFocus()
txt_SupplierNumber.Text = "S-"
SendKeys "{end}"
End Sub
