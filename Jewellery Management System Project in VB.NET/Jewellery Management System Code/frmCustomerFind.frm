VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmCustomerFind 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Find Customer"
   ClientHeight    =   3480
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9435
   Icon            =   "frmCustomerFind.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3480
   ScaleWidth      =   9435
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
      Caption         =   "tbl_Customer"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   1680
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   5760
      Visible         =   0   'False
      Width           =   3015
   End
   Begin VB.CommandButton cmd_select 
      Caption         =   "&Select"
      Enabled         =   0   'False
      Height          =   375
      Left            =   6720
      TabIndex        =   12
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton cmd_cancel 
      Cancel          =   -1  'True
      Caption         =   "&Close"
      Height          =   375
      Left            =   8040
      TabIndex        =   11
      Top             =   2880
      Width           =   1215
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Caption         =   "Search by Name of Customer"
      Height          =   1215
      Left            =   120
      TabIndex        =   6
      Top             =   1080
      Width           =   3135
      Begin VB.TextBox txt_Firstname 
         Height          =   285
         Left            =   1440
         TabIndex        =   8
         Top             =   720
         Width           =   1575
      End
      Begin VB.TextBox txt_Lastname 
         Height          =   285
         Left            =   1440
         TabIndex        =   7
         Top             =   360
         Width           =   1575
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "&First Name"
         Height          =   195
         Left            =   480
         TabIndex        =   10
         Top             =   720
         Width           =   750
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "&Last Name"
         Height          =   195
         Index           =   0
         Left            =   480
         TabIndex        =   9
         Top             =   360
         Width           =   765
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00FEEADA&
      Caption         =   "Search by Customer Number"
      Height          =   855
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   3135
      Begin VB.TextBox txt_CustomerNumber 
         Height          =   285
         Left            =   1440
         TabIndex        =   4
         Top             =   360
         Width           =   1575
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Customer #"
         Height          =   195
         Index           =   1
         Left            =   480
         TabIndex        =   5
         Top             =   360
         Width           =   810
      End
   End
   Begin VB.CommandButton cmd_search 
      Caption         =   "Search"
      Default         =   -1  'True
      Enabled         =   0   'False
      Height          =   375
      Left            =   720
      TabIndex        =   2
      Top             =   2400
      Width           =   1215
   End
   Begin VB.CommandButton cmd_clear 
      Caption         =   "Clea&r"
      Height          =   375
      Left            =   2040
      TabIndex        =   1
      Top             =   2400
      Width           =   1215
   End
   Begin MSComctlLib.ListView lvw_recordsfound 
      Height          =   2415
      Left            =   3360
      TabIndex        =   0
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
      NumItems        =   4
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Customer Number"
         Object.Width           =   2646
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Name"
         Object.Width           =   3528
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Address"
         Object.Width           =   6174
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Contact Number"
         Object.Width           =   2646
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
Attribute VB_Name = "frmCustomerFind"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim l_results As ListItem

Private Sub cmd_AddNew_Click()
frmCustomer.Show vbModal
End Sub

Private Sub cmd_cancel_Click()
Unload Me
End Sub

Private Sub cmd_Clear_Click()
txt_CustomerNumber.Text = ""
txt_firstname.Text = ""
txt_lastname.Text = ""
lvw_recordsfound.ListItems.Clear
cmd_search.Enabled = False
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblCustomer"
Data1.Refresh

End Sub

Private Sub cmd_search_Click()
If txt_CustomerNumber.Text = "" And txt_firstname.Text = "" And txt_lastname.Text = "" Then
    MsgBox "Sorry, cannot search right now. Try to enter a value.", vbExclamation
    Exit Sub
End If

With Data1
    lvw_recordsfound.ListItems.Clear
    'customer number
    If txt_CustomerNumber.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblcustomer where  Cust_Number ='" & Trim(txt_CustomerNumber.Text) & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with customer number: " & Trim(txt_CustomerNumber.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblCustomer"
            .Refresh
            cmd_select.Enabled = False
            Exit Sub
        Else
            'record/s found
            cmd_select.Enabled = True
            Populate_lvw_recordsfound
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblCustomer"
            .Refresh
            Exit Sub
        End If
    End If
    
    lvw_recordsfound.ListItems.Clear
    'first name
    If txt_firstname.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblcustomer where  Cust_firstname ='" & txt_firstname.Text & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with firstname: " & Trim(txt_firstname.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblCustomer"
            .Refresh
            cmd_select.Enabled = False
            Exit Sub
        Else
            'record/s found
            cmd_select.Enabled = True
            Populate_lvw_recordsfound
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblCustomer"
            .Refresh
            Exit Sub
        End If
    End If
    
    lvw_recordsfound.ListItems.Clear
    'lastname name
    If txt_lastname.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblcustomer where  Cust_lastname ='" & Trim(txt_lastname.Text) & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with lastname: " & Trim(txt_lastname.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblCustomer"
            .Refresh
            cmd_select.Enabled = False
            Exit Sub
        Else
            'record/s found
            cmd_select.Enabled = True
            Populate_lvw_recordsfound
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblCustomer"
            .Refresh
            Exit Sub
        End If
    End If

End With

End Sub

Private Sub cmd_select_Click()
frmSales.txt_CustomerName.Text = l_results.SubItems(1)
frmSales.txt_CustomerAddress.Text = l_results.SubItems(2)
Unload Me
End Sub

Private Sub Form_Load()
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblCustomer"
Data1.Refresh
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
    Set l_results = lvw_recordsfound.ListItems.Add(X, , !Cust_Number)
                    l_results.SubItems(1) = !Cust_Firstname & " " & !Cust_MI & " " & !Cust_Lastname
                    l_results.SubItems(2) = !Cust_StreetAddress & ", " & !Cust_City & ", " & !Cust_Province & " " & !Cust_Zip
                    l_results.SubItems(3) = !Cust_ContactNumber
    .MoveNext
    Next
End With
End Sub

Private Sub lvw_recordsfound_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    If lvw_recordsfound.SortOrder = lvwAscending Then
        lvw_recordsfound.SortOrder = lvwDescending
    Else
        lvw_recordsfound.SortOrder = lvwAscending
    End If

End Sub

Private Sub txt_CustomerNumber_Change()
If txt_CustomerNumber.Text <> "" Then
    txt_firstname.Text = ""
    txt_lastname.Text = ""
    cmd_search.Enabled = True
Else
    cmd_search.Enabled = False
End If
End Sub

Private Sub txt_CustomerNumber_GotFocus()
txt_CustomerNumber.Text = "C-"
End Sub

Private Sub txt_Firstname_Change()
If txt_firstname.Text <> "" Then
    txt_lastname.Text = ""
    txt_CustomerNumber.Text = ""
    cmd_search.Enabled = True
Else
    cmd_search.Enabled = False
End If
End Sub

Private Sub txt_Lastname_Change()
If txt_lastname.Text <> "" Then
    txt_firstname.Text = ""
    txt_CustomerNumber.Text = ""
    cmd_search.Enabled = True
Else
    cmd_search.Enabled = False
End If

End Sub
