VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmEmployeeFind 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Find Employee"
   ClientHeight    =   5925
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6135
   Icon            =   "frmEmployeeFind.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5925
   ScaleWidth      =   6135
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   1
      Left            =   6120
      Top             =   840
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Height          =   2535
      Left            =   3480
      TabIndex        =   15
      Top             =   2760
      Width           =   2535
      Begin VB.Image Img_Emp 
         Height          =   2175
         Left            =   120
         Stretch         =   -1  'True
         Top             =   240
         Width           =   2295
      End
   End
   Begin VB.CommandButton cmd_Cancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   4800
      TabIndex        =   7
      Top             =   5400
      Width           =   1215
   End
   Begin VB.CommandButton cmd_clear 
      Caption         =   "Clea&r"
      Height          =   375
      Left            =   1440
      TabIndex        =   5
      Top             =   5400
      Width           =   1215
   End
   Begin VB.CommandButton cmd_search 
      Caption         =   "Search"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   5400
      Width           =   1215
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00FEEADA&
      Caption         =   "Search by Employee Code"
      Height          =   855
      Left            =   120
      TabIndex        =   12
      Top             =   2760
      Width           =   3135
      Begin VB.TextBox txt_employeecode 
         Height          =   285
         Left            =   1440
         TabIndex        =   1
         Top             =   360
         Width           =   1575
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Employee Code"
         Height          =   195
         Index           =   1
         Left            =   120
         TabIndex        =   13
         Top             =   360
         Width           =   1110
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Caption         =   "Search by Name of Employee"
      Height          =   1575
      Left            =   120
      TabIndex        =   9
      Top             =   3720
      Width           =   3135
      Begin VB.TextBox txt_NickName 
         Height          =   285
         Left            =   1440
         TabIndex        =   2
         Top             =   360
         Width           =   1575
      End
      Begin VB.TextBox txt_lastname 
         Height          =   285
         Left            =   1440
         TabIndex        =   3
         Top             =   720
         Width           =   1575
      End
      Begin VB.TextBox txt_firstname 
         Height          =   285
         Left            =   1440
         TabIndex        =   4
         Top             =   1080
         Width           =   1575
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "&Nick Name"
         Height          =   195
         Index           =   1
         Left            =   480
         TabIndex        =   14
         Top             =   360
         Width           =   795
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "&Last Name"
         Height          =   195
         Index           =   0
         Left            =   480
         TabIndex        =   11
         Top             =   720
         Width           =   765
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "&First Name"
         Height          =   195
         Left            =   480
         TabIndex        =   10
         Top             =   1080
         Width           =   750
      End
   End
   Begin VB.CommandButton cmd_Select 
      Caption         =   "Select"
      Height          =   375
      Left            =   3480
      TabIndex        =   6
      Top             =   5400
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "D:\CMJ Inventory\CMJ.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   960
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "tblEmployee"
      Top             =   7800
      Visible         =   0   'False
      Width           =   2295
   End
   Begin MSComctlLib.ListView lvw_recordsfound 
      Height          =   2535
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   5895
      _ExtentX        =   10398
      _ExtentY        =   4471
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
      NumItems        =   5
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Employee Number"
         Object.Width           =   2646
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Nick Name"
         Object.Width           =   1764
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Name"
         Object.Width           =   3528
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Address"
         Object.Width           =   5292
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Contact Number"
         Object.Width           =   2646
      EndProperty
   End
End
Attribute VB_Name = "frmEmployeeFind"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim l_results As ListItem

Private Sub cmd_cancel_Click()
cmd_Clear_Click
Unload Me
End Sub

Private Sub cmd_Clear_Click()
Timer1.Enabled = False
lvw_recordsfound.ListItems.Clear
txt_employeecode.Text = ""
txt_NickName.Text = ""
txt_firstname.Text = ""
txt_lastname.Text = ""
cmd_search.Enabled = False
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblEmployee"
Data1.Refresh
cmd_search.Enabled = True
End Sub

Private Sub cmd_search_Click()

If txt_employeecode.Text = "" And txt_NickName.Text = "" And txt_firstname.Text = "" And txt_lastname.Text = "" Then
    MsgBox "Sorry, cannot search right now. Try to enter a value.", vbExclamation
    cmd_search.Enabled = True
    Exit Sub
Else
    cmd_search.Enabled = False
End If
lvw_recordsfound.ListItems.Clear

With Data1
    
    'employee code
    If txt_employeecode.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblEmployee where  Emp_Number ='" & Trim(txt_employeecode.Text) & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with employee code: " & Trim(txt_employeecode.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            Exit Sub
        Else
            'record/s found
            'cmd_search.Enabled = False
            Populate_lvw_recordsfound
            Timer1.Enabled = True
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            
        End If
    End If
    
    'nick name
    If txt_NickName.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblEmployee where  Emp_Nick_Name = '" & Trim(txt_NickName.Text) & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with Nickname: " & UCase(txt_NickName.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            Exit Sub
        Else
            'record/s found
            'cmd_search.Enabled = False
            Populate_lvw_recordsfound
            Timer1.Enabled = True
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            
        End If
    End If
    
    'first name
    If txt_firstname.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblEmployee where  Emp_FirstName = '" & Trim(txt_firstname.Text) & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with Firstname: " & UCase(txt_firstname.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            Exit Sub
        Else
            'record/s found
            'cmd_search.Enabled = False
            Populate_lvw_recordsfound
            Timer1.Enabled = True
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            
        End If
    End If
    
    'last name
    If txt_lastname.Text <> "" Then
        'no record found
        .RecordSource = "select * from tblEmployee where  Emp_LastName = '" & Trim(txt_lastname.Text) & "'"
        .Refresh
        If .Recordset.RecordCount = 0 Then
            MsgBox "No record found with Lastname: " & UCase(txt_lastname.Text) & "."
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            Exit Sub
        Else
            'record/s found
            'cmd_search.Enabled = False
            Populate_lvw_recordsfound
            Timer1.Enabled = True
            .DatabaseName = App.Path & "\CMJ.mdb"
            .RecordSource = "select * from tblEmployee"
            .Refresh
            
        End If
    End If
    

End With
End Sub

Private Sub Populate_lvw_recordsfound()
Dim rec_count, X
On Err GoTo hell

'Timer1.Enabled = True
With Data1.Recordset
    .MoveLast
    rec_count = .RecordCount
    .MoveFirst
    For X = 1 To rec_count
    Set l_results = lvw_recordsfound.ListItems.Add(X, , !Emp_Number)
                    l_results.SubItems(1) = !Emp_Nick_Name
                    l_results.SubItems(2) = !Emp_FirstName & " " & !Emp_MI & " " & !Emp_LastName
                    l_results.SubItems(3) = !Emp_StreetAddress & ", " & !Emp_City & ", " & !Emp_Province & " " & !Emp_Zip
                    l_results.SubItems(4) = !Emp_ContactNumber
                  
    .MoveNext
    Next
End With
hell:
'    MsgBox "Cannot function well. Stupid user is in use.", vbCritical, "STUPID USER"
'    Exit Sub

End Sub

Private Sub Command1_Click()

End Sub


Private Sub Command3_Click()

End Sub

Private Sub cmd_select_Click()
MsgBox lvw_recordsfound.SelectedItem & " " & l_results.SubItems(1)
End Sub

Private Sub Form_Load()
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblEmployee"
Data1.Refresh

End Sub

Private Sub lvw_recordsfound_Click()
'MsgBox lvw_recordsfound.SelectedItem
End Sub

Private Sub lvw_recordsfound_ColumnClick(ByVal ColumnHeader As MSComctlLib.ColumnHeader)
    If lvw_recordsfound.SortOrder = lvwAscending Then
        lvw_recordsfound.SortOrder = lvwDescending
    Else
        lvw_recordsfound.SortOrder = lvwAscending
    End If
End Sub

Private Sub Timer1_Timer()

If lvw_recordsfound.SelectedItem <> "" Or lvw_recordsfound.SelectedItem <> Null Then
    With Data1.Recordset
       Data1.RecordSource = "select * from tblEmployee where  Emp_Number = '" & lvw_recordsfound.SelectedItem & "'"
        Data1.Refresh
        If .RecordCount <> 0 Then
                On Error Resume Next
                Img_Emp.Picture = LoadPicture(!emp_pic)
                If Img_Emp.Picture = 0 Then
                    Img_Emp.Picture = LoadPicture()
                Else
                    If !emp_pic <> "" Or !emp_pic <> Null Then
                        Img_Emp.Picture = LoadPicture(!emp_pic)
                    Else
                        Img_Emp.Picture = LoadPicture()
                    End If
                End If
        Else
            Img_Emp.Picture = LoadPicture()
        End If
    End With
Else
    Exit Sub
End If
End Sub

Private Sub txt_employeecode_Change()
'If txt_employeecode.Text <> "" Then
'    txt_NickName.Text = ""
'    txt_Firstname.Text = ""
'    txt_Lastname.Text = ""
'    cmd_search.Enabled = True
'Else
'    cmd_search.Enabled = False
'End If
End Sub

Private Sub txt_employeecode_GotFocus()
txt_employeecode.Text = "CMJ-Emp-"
txt_employeecode.SetFocus

End Sub

Private Sub txt_Firstname_Change()
'If txt_Firstname.Text <> "" Then
'    txt_employeecode.Text = ""
'    txt_NickName.Text = ""
'    txt_Lastname.Text = ""
'    cmd_search.Enabled = True
'Else
'    cmd_search.Enabled = False
'End If
End Sub

Private Sub txt_Lastname_Change()
'If txt_Lastname.Text <> "" Then
'    txt_employeecode.Text = ""
'    txt_NickName.Text = ""
'    txt_Firstname.Text = ""
'    cmd_search.Enabled = True
'Else
'    cmd_search.Enabled = False
'End If
End Sub

Private Sub txt_NickName_Change()
'If txt_NickName.Text <> "" Then
'    txt_employeecode.Text = ""
'    txt_Firstname.Text = ""
'    txt_Lastname.Text = ""
'    cmd_search.Enabled = True
'Else
'    cmd_search.Enabled = False
'End If
End Sub
