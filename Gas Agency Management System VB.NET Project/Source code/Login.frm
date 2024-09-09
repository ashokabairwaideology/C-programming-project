VERSION 5.00
Begin VB.Form Login 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Login"
   ClientHeight    =   4050
   ClientLeft      =   4560
   ClientTop       =   4575
   ClientWidth     =   4845
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   4050
   ScaleWidth      =   4845
   Begin VB.Frame Frame1 
      Height          =   2535
      Left            =   480
      TabIndex        =   1
      Top             =   1200
      Width           =   3975
      Begin VB.CommandButton Command2 
         Caption         =   "Exit"
         Height          =   495
         Left            =   2280
         TabIndex        =   5
         Top             =   1680
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Login"
         Height          =   495
         Left            =   960
         TabIndex        =   4
         Top             =   1680
         Width           =   1215
      End
      Begin VB.TextBox Text1 
         Height          =   495
         IMEMode         =   3  'DISABLE
         Left            =   1560
         PasswordChar    =   "*"
         TabIndex        =   2
         Top             =   600
         Width           =   1935
      End
      Begin VB.Label Label2 
         Caption         =   "Password "
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   3
         Top             =   600
         Width           =   1335
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Login "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   2280
      TabIndex        =   0
      Top             =   240
      Width           =   1095
   End
End
Attribute VB_Name = "Login"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset
Private Sub Command1_Click()
If Text1.Text = rs(0) Then
MDIForm1.add = True
MDIForm1.bookings = True
MDIForm1.view = True
Unload Me
ElseIf (Text1.Text = "") Then
MsgBox "Enter Password", vbOKOnly, "Password"
Else
MsgBox "Incorrect password", vbOKOnly, "Password"
Text1.Text = ""
End If
End Sub

Private Sub Command2_Click()
Unload MDIForm1
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "password", cn, adOpenDynamic, adLockOptimistic
End Sub


Private Sub Form_Unload(Cancel As Integer)
rs.Close
cn.Close
End Sub
