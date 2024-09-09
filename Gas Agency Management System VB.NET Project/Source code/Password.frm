VERSION 5.00
Begin VB.Form Password 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Password"
   ClientHeight    =   4845
   ClientLeft      =   45
   ClientTop       =   495
   ClientWidth     =   6465
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   4845
   ScaleWidth      =   6465
   Begin VB.Frame Frame1 
      Height          =   3255
      Left            =   1200
      TabIndex        =   1
      Top             =   1200
      Width           =   4455
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   2400
         TabIndex        =   6
         Top             =   2640
         Width           =   1095
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Change"
         Height          =   495
         Left            =   600
         TabIndex        =   5
         Top             =   2640
         Width           =   1095
      End
      Begin VB.TextBox Text3 
         Height          =   495
         IMEMode         =   3  'DISABLE
         Left            =   1560
         MaxLength       =   9
         PasswordChar    =   "*"
         TabIndex        =   4
         Top             =   1920
         Width           =   2175
      End
      Begin VB.TextBox Text2 
         Height          =   495
         IMEMode         =   3  'DISABLE
         Left            =   1560
         MaxLength       =   9
         PasswordChar    =   "*"
         TabIndex        =   3
         Top             =   1200
         Width           =   2175
      End
      Begin VB.TextBox Text1 
         Height          =   495
         IMEMode         =   3  'DISABLE
         Left            =   1560
         MaxLength       =   9
         PasswordChar    =   "*"
         TabIndex        =   2
         Top             =   480
         Width           =   2175
      End
      Begin VB.Label Label4 
         Caption         =   "Confirm Password"
         Height          =   375
         Left            =   120
         TabIndex        =   9
         Top             =   2040
         Width           =   1335
      End
      Begin VB.Label Label3 
         Caption         =   "New Password"
         Height          =   375
         Left            =   240
         TabIndex        =   8
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Label2 
         Caption         =   "Current Password"
         Height          =   375
         Left            =   120
         TabIndex        =   7
         Top             =   600
         Width           =   1335
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Change Password"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1680
      TabIndex        =   0
      Top             =   240
      Width           =   3375
   End
End
Attribute VB_Name = "Password"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Command1_Click()
If (Text2.Text <> Text3.Text) Then
MsgBox "Confirm and new password should be same", vbOKOnly, "Password"
Else
If rs.EOF Then
rs.AddNew
rs(0) = Text2.Text
rs.Update
MsgBox "Password Updated sucessfully", vbOKOnly, "Password"
Login.Show
Unload Me
Else
rs.MoveFirst
If (rs(0) = Text1.Text) Then
rs(0) = Text2.Text
rs.Update
MsgBox "Password Updated sucessfully", vbOKOnly, "Password"
Login.Show
Unload Me
Else
MsgBox "current password is wrong", vbOKOnly, "Password"
End If
End If
End If
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "password", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
Text1.Enabled = False
Label2.Enabled = False
End If
End Sub


Private Sub Form_Unload(Cancel As Integer)
rs.Close
cn.Close
End Sub
