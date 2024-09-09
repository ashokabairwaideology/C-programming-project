VERSION 5.00
Begin VB.Form Vrate 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Cylinder Rates"
   ClientHeight    =   4665
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4800
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   4665
   ScaleWidth      =   4800
   Begin VB.Frame Frame1 
      Height          =   3375
      Left            =   600
      TabIndex        =   0
      Top             =   960
      Width           =   3855
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   1920
         TabIndex        =   7
         Top             =   2640
         Width           =   1455
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Update"
         Height          =   495
         Left            =   360
         TabIndex        =   6
         Top             =   2640
         Width           =   1335
      End
      Begin VB.TextBox Text2 
         Height          =   615
         Left            =   1560
         MaxLength       =   7
         TabIndex        =   2
         Top             =   1440
         Width           =   1455
      End
      Begin VB.TextBox Text1 
         Height          =   615
         Left            =   1560
         MaxLength       =   6
         TabIndex        =   1
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label Label2 
         Caption         =   "Comersial"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   4
         Top             =   1560
         Width           =   1215
      End
      Begin VB.Label Label1 
         Caption         =   "Domestic"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
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
   Begin VB.Label Label3 
      Caption         =   "Current Rates"
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
      Left            =   1200
      TabIndex        =   5
      Top             =   360
      Width           =   2415
   End
End
Attribute VB_Name = "Vrate"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Command1_Click()
If Text1.Text = "" Then
MsgBox "Enter Rate", vbOKOnly, "Error"
Else
If rs.EOF Then
rs.AddNew
Else
rs.MoveFirst
End If
rs(0) = Text1.Text
rs(1) = Text2.Text
rs.Update
MsgBox "Rate updated Succesfully", vbOKOnly, "Rate"
End If
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "rate", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
Else
rs.MoveFirst
Text1.Text = rs(0)
Text2.Text = rs(1)
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
rs.Close
cn.Close
End Sub


Private Sub Text1_KeyUp(KeyCode As Integer, Shift As Integer)
If (KeyCode > 63 And KeyCode < 91) Or (KeyCode > 105 And KeyCode < 112) Or (KeyCode > 185 And KeyCode < 193 Or (KeyCode > 218 And KeyCode < 223)) Then
MsgBox "Invalid entry, field support only numbers", vbOKOnly, "Error"
Text1.Text = ""
End If
End Sub

Private Sub Text2_KeyUp(KeyCode As Integer, Shift As Integer)
If (KeyCode > 63 And KeyCode < 91) Or (KeyCode > 105 And KeyCode < 112) Or (KeyCode > 185 And KeyCode < 193 Or (KeyCode > 218 And KeyCode < 223)) Then
MsgBox "Invalid entry, field support only numbers", vbOKOnly, "Error"
Text2.Text = ""
End If
End Sub


