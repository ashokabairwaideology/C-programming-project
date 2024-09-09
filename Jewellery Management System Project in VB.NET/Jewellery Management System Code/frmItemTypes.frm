VERSION 5.00
Begin VB.Form frmItemTypes 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Item types"
   ClientHeight    =   6135
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6615
   Icon            =   "frmItemTypes.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6135
   ScaleWidth      =   6615
   StartUpPosition =   2  'CenterScreen
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
      Top             =   7440
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
      Top             =   7080
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
      Top             =   6720
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
      Top             =   6360
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Division"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   1335
      Index           =   3
      Left            =   240
      TabIndex        =   15
      Top             =   4560
      Width           =   6255
      Begin VB.TextBox combo_DivisIon 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   16
         Top             =   360
         Width           =   3495
      End
      Begin VB.CommandButton cmd_Cancel_Division 
         Caption         =   "Cancel"
         Enabled         =   0   'False
         Height          =   615
         Left            =   5520
         Picture         =   "frmItemTypes.frx":0442
         Style           =   1  'Graphical
         TabIndex        =   19
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cmd_Delete_Division 
         Caption         =   "Delete"
         Height          =   615
         Left            =   6240
         Picture         =   "frmItemTypes.frx":110C
         Style           =   1  'Graphical
         TabIndex        =   31
         Top             =   360
         Visible         =   0   'False
         Width           =   615
      End
      Begin VB.CommandButton cmd_Add_Division 
         Caption         =   "Add"
         Height          =   615
         Left            =   4800
         Picture         =   "frmItemTypes.frx":1DD6
         Style           =   1  'Graphical
         TabIndex        =   18
         Top             =   360
         Width           =   615
      End
      Begin VB.TextBox txt_Division 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   17
         Top             =   720
         Width           =   3495
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         Height          =   195
         Index           =   7
         Left            =   720
         TabIndex        =   28
         Top             =   360
         Width           =   360
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         Height          =   195
         Index           =   6
         Left            =   240
         TabIndex        =   27
         Top             =   720
         Width           =   795
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Type"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   1335
      Index           =   2
      Left            =   240
      TabIndex        =   10
      Top             =   3120
      Width           =   6255
      Begin VB.TextBox ComBo_Type 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   11
         Top             =   360
         Width           =   3495
      End
      Begin VB.CommandButton cmd_Cancel_Type 
         Caption         =   "Cancel"
         Enabled         =   0   'False
         Height          =   615
         Left            =   5520
         Picture         =   "frmItemTypes.frx":2AA0
         Style           =   1  'Graphical
         TabIndex        =   14
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cmd_Delete_Type 
         Caption         =   "Delete"
         Height          =   615
         Left            =   6240
         Picture         =   "frmItemTypes.frx":376A
         Style           =   1  'Graphical
         TabIndex        =   30
         Top             =   360
         Visible         =   0   'False
         Width           =   615
      End
      Begin VB.CommandButton cmd_Add_Type 
         Caption         =   "Add"
         Height          =   615
         Left            =   4800
         Picture         =   "frmItemTypes.frx":4434
         Style           =   1  'Graphical
         TabIndex        =   13
         Top             =   360
         Width           =   615
      End
      Begin VB.TextBox txt_Type 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   12
         Top             =   720
         Width           =   3495
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         Height          =   195
         Index           =   5
         Left            =   720
         TabIndex        =   26
         Top             =   360
         Width           =   360
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         Height          =   195
         Index           =   4
         Left            =   240
         TabIndex        =   25
         Top             =   720
         Width           =   795
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Unit"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   1335
      Index           =   1
      Left            =   240
      TabIndex        =   5
      Top             =   1680
      Width           =   6255
      Begin VB.TextBox combo_Unit 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   6
         Top             =   360
         Width           =   3495
      End
      Begin VB.CommandButton cmd_Cancel_Unit 
         Caption         =   "Cancel"
         Enabled         =   0   'False
         Height          =   615
         Left            =   5520
         Picture         =   "frmItemTypes.frx":50FE
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cmd_Delete_Unit 
         Caption         =   "Delete"
         Height          =   615
         Left            =   6240
         Picture         =   "frmItemTypes.frx":5DC8
         Style           =   1  'Graphical
         TabIndex        =   29
         Top             =   360
         Visible         =   0   'False
         Width           =   615
      End
      Begin VB.CommandButton cmd_Add_Unit 
         Caption         =   "Add"
         Height          =   615
         Left            =   4800
         Picture         =   "frmItemTypes.frx":6A92
         Style           =   1  'Graphical
         TabIndex        =   8
         Top             =   360
         Width           =   615
      End
      Begin VB.TextBox txt_Unit 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   7
         Top             =   720
         Width           =   3495
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         Height          =   195
         Index           =   3
         Left            =   720
         TabIndex        =   24
         Top             =   360
         Width           =   360
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         Height          =   195
         Index           =   2
         Left            =   240
         TabIndex        =   23
         Top             =   720
         Width           =   795
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Category"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   1335
      Index           =   0
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   6255
      Begin VB.TextBox Combo_Category 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   1
         Top             =   360
         Width           =   3495
      End
      Begin VB.CommandButton cmd_Cancel_Category 
         Caption         =   "Cancel"
         Enabled         =   0   'False
         Height          =   615
         Left            =   5520
         Picture         =   "frmItemTypes.frx":775C
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cmd_Delete_Category 
         Caption         =   "Delete"
         Height          =   615
         Left            =   6240
         Picture         =   "frmItemTypes.frx":8426
         Style           =   1  'Graphical
         TabIndex        =   22
         Top             =   360
         Visible         =   0   'False
         Width           =   615
      End
      Begin VB.CommandButton cmd_Add_Category 
         Caption         =   "Add"
         Height          =   615
         Left            =   4800
         Picture         =   "frmItemTypes.frx":90F0
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   360
         Width           =   615
      End
      Begin VB.TextBox txt_Category 
         Enabled         =   0   'False
         Height          =   315
         Left            =   1200
         TabIndex        =   2
         Top             =   720
         Width           =   3495
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         Height          =   195
         Index           =   1
         Left            =   240
         TabIndex        =   21
         Top             =   720
         Width           =   795
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         Height          =   195
         Index           =   0
         Left            =   720
         TabIndex        =   20
         Top             =   360
         Width           =   360
      End
   End
End
Attribute VB_Name = "frmItemTypes"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmd_Add_Category_Click()
cmd_Cancel_Category.Enabled = True
cmd_Delete_Category.Enabled = False
Frame1(1).Enabled = False
Frame1(2).Enabled = False
Frame1(3).Enabled = False
Combo_CaTegory.Enabled = True
txt_Category.Enabled = True
Combo_CaTegory.SetFocus
If cmd_Add_Category.Caption = "Add" Then
    cmd_Add_Category.Caption = "Save"
    Combo_CaTegory.Text = ""
    txt_Category.Text = ""
Else
    If Combo_CaTegory.Text = "" Then
        MsgBox "Enter type.", vbExclamation, "Type is missing"
        Exit Sub
    End If
    If txt_Category.Text = "" Then
        MsgBox "Enter description.", vbExclamation, "Description is missing"
        Exit Sub
    End If
    With db_Category
        .Recordset.AddNew
            .Recordset.Fields("Type") = Combo_CaTegory.Text
            .Recordset.Fields("Description") = txt_Category.Text
        .Recordset.Update
        MsgBox "Category: " & UCase(Combo_CaTegory.Text) & " has been saved to database.", vbInformation
        Combo_CaTegory.Text = ""
        txt_Category.Text = ""
    End With
    cmd_Add_Category.Caption = "Add"
    cmd_Delete_Category.Enabled = True
    Frame1(1).Enabled = True
    Frame1(2).Enabled = True
    Frame1(3).Enabled = True
    Combo_CaTegory.Text = ""
    txt_Category.Text = ""
    Combo_CaTegory.Enabled = False
    txt_Category.Enabled = False
    cmd_Cancel_Category.Enabled = False
End If
End Sub

Private Sub cmd_Add_Division_Click()
cmd_Cancel_Division.Enabled = True
Frame1(0).Enabled = False
Frame1(1).Enabled = False
Frame1(2).Enabled = False
Combo_Division.Enabled = True
txt_Division.Enabled = True

Combo_Division.SetFocus
If cmd_Add_Division.Caption = "Add" Then
    cmd_Add_Division.Caption = "Save"
    Combo_Division.Text = ""
    txt_Division.Text = ""
Else
    If Combo_Division.Text = "" Then
        MsgBox "Enter type.", vbExclamation, "Type is missing"
        Exit Sub
    End If
    If txt_Division.Text = "" Then
        MsgBox "Enter description.", vbExclamation, "Description is missing"
        Exit Sub
    End If
    With db_Division
        .Recordset.AddNew
            .Recordset.Fields("Type") = Combo_Division.Text
            .Recordset.Fields("Description") = txt_Division.Text
        .Recordset.Update
        MsgBox "Division: " & UCase(Combo_Type.Text) & " has been saved to database.", vbInformation
        Combo_Division.Text = ""
        txt_Division.Text = ""
    End With
    cmd_Add_Division.Caption = "Add"
    cmd_Delete_Division.Enabled = True
    Frame1(0).Enabled = True
    Frame1(1).Enabled = True
    Frame1(2).Enabled = True
    Combo_Division.Text = ""
    txt_Division.Text = ""
    Combo_Division.Enabled = False
    txt_Division.Enabled = False
    cmd_Cancel_Division.Enabled = False
End If

End Sub

Private Sub cmd_Add_Type_Click()
cmd_Cancel_Type.Enabled = True
Frame1(0).Enabled = False
Frame1(1).Enabled = False
Frame1(3).Enabled = False
Combo_Type.Enabled = True
txt_Type.Enabled = True

Combo_Type.SetFocus
If cmd_Add_Type.Caption = "Add" Then
    cmd_Add_Type.Caption = "Save"
    Combo_Type.Text = ""
    txt_Type.Text = ""
Else
    If Combo_Type.Text = "" Then
        MsgBox "Enter type.", vbExclamation, "Type is missing"
        Exit Sub
    End If
    If txt_Type.Text = "" Then
        MsgBox "Enter description.", vbExclamation, "Description is missing"
        Exit Sub
    End If
    With db_Type
        .Recordset.AddNew
            .Recordset.Fields("Type") = Combo_Type.Text
            .Recordset.Fields("Description") = txt_Type.Text
        .Recordset.Update
        MsgBox "Type: " & UCase(Combo_Type.Text) & " has been saved to database.", vbInformation
        Combo_Type.Text = ""
        txt_Type.Text = ""
    End With
    cmd_Add_Type.Caption = "Add"
    cmd_Delete_Type.Enabled = True
    Frame1(0).Enabled = True
    Frame1(1).Enabled = True
    Frame1(3).Enabled = True
    Combo_Type.Text = ""
    txt_Type.Text = ""
    Combo_Type.Enabled = False
    txt_Type.Enabled = False
    cmd_Cancel_Type.Enabled = False

End If

End Sub

Private Sub cmd_Add_Unit_Click()
cmd_Cancel_Unit.Enabled = True
Frame1(0).Enabled = False
Frame1(2).Enabled = False
Frame1(3).Enabled = False
Combo_Unit.Enabled = True
txt_Unit.Enabled = True
Combo_Unit.SetFocus
If cmd_Add_Unit.Caption = "Add" Then
    cmd_Add_Unit.Caption = "Save"
    Combo_Unit.Text = ""
    txt_Unit.Text = ""
Else
    If Combo_Unit.Text = "" Then
        MsgBox "Enter type.", vbExclamation, "Type is missing"
        Exit Sub
    End If
    If txt_Unit.Text = "" Then
        MsgBox "Enter description.", vbExclamation, "Description is missing"
        Exit Sub
    End If
    With db_Unit
        .Recordset.AddNew
            .Recordset.Fields("Type") = Combo_Unit.Text
            .Recordset.Fields("Description") = txt_Unit.Text
        .Recordset.Update
        MsgBox "Unit: " & UCase(Combo_Unit.Text) & " has been saved to database.", vbInformation
        Combo_Unit.Text = ""
        txt_Unit.Text = ""
    End With
    cmd_Add_Unit.Caption = "Add"
    cmd_Delete_Unit.Enabled = True
    Frame1(0).Enabled = True
    Frame1(2).Enabled = True
    Frame1(3).Enabled = True
    Combo_Unit.Text = ""
    txt_Unit.Text = ""
    Combo_Unit.Enabled = False
    txt_Unit.Enabled = False
    cmd_Cancel_Unit.Enabled = False

End If
End Sub

Private Sub cmd_Cancel_Category_Click()
cmd_Add_Category.Caption = "Add"
cmd_Delete_Category.Enabled = True
    Frame1(1).Enabled = True
    Frame1(2).Enabled = True
    Frame1(3).Enabled = True
    Combo_CaTegory.Text = ""
    txt_Category.Text = ""
    Combo_CaTegory.Enabled = False
    txt_Category.Enabled = False
    cmd_Cancel_Category.Enabled = False
End Sub

Private Sub cmd_Cancel_Division_Click()
cmd_Add_Division.Caption = "Add"
cmd_Delete_Division.Enabled = True
    Frame1(0).Enabled = True
    Frame1(1).Enabled = True
    Frame1(2).Enabled = True
    Combo_Division.Text = ""
    txt_Division.Text = ""
    Combo_Division.Enabled = False
    txt_Division.Enabled = False
    cmd_Cancel_Division.Enabled = False
End Sub

Private Sub cmd_Cancel_Type_Click()
cmd_Add_Type.Caption = "Add"
cmd_Delete_Type.Enabled = True
    Frame1(0).Enabled = True
    Frame1(1).Enabled = True
    Frame1(3).Enabled = True
    Combo_Type.Text = ""
    txt_Type.Text = ""
    Combo_Type.Enabled = False
    txt_Type.Enabled = False
    cmd_Cancel_Type.Enabled = False

End Sub

Private Sub cmd_Cancel_Unit_Click()
cmd_Add_Unit.Caption = "Add"
cmd_Delete_Unit.Enabled = True
    Frame1(0).Enabled = True
    Frame1(2).Enabled = True
    Frame1(3).Enabled = True
    Combo_Unit.Text = ""
    txt_Unit.Text = ""
    Combo_Unit.Enabled = False
    txt_Unit.Enabled = False
    cmd_Cancel_Unit.Enabled = False
End Sub

Private Sub Combo_Category_Change()
Combo_CaTegory.Text = UCase(Combo_CaTegory.Text)
SendKeys "{end}"
End Sub

Private Sub combo_DivisIon_Change()
Combo_Division.Text = UCase(Combo_Division.Text)
SendKeys "{end}"
End Sub

Private Sub ComBo_Type_Change()
Combo_Type.Text = UCase(Combo_Type.Text)
SendKeys "{end}"

End Sub

Private Sub combo_Unit_Change()
Combo_Unit.Text = UCase(Combo_Unit.Text)
SendKeys "{end}"
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

End Sub
