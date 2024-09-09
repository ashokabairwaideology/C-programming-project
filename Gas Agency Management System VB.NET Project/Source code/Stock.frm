VERSION 5.00
Begin VB.Form Stock 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Stock"
   ClientHeight    =   5235
   ClientLeft      =   45
   ClientTop       =   495
   ClientWidth     =   5895
   LinkTopic       =   "Form4"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5235
   ScaleWidth      =   5895
   Begin VB.Frame Frame1 
      Height          =   3375
      Left            =   600
      TabIndex        =   1
      Top             =   1440
      Width           =   4815
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   2640
         TabIndex        =   7
         Top             =   2640
         Width           =   1215
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Update"
         Height          =   495
         Left            =   960
         TabIndex        =   6
         Top             =   2640
         Width           =   1095
      End
      Begin VB.TextBox Text2 
         Height          =   495
         Left            =   1800
         MaxLength       =   3
         TabIndex        =   5
         Top             =   1680
         Width           =   1215
      End
      Begin VB.TextBox Text1 
         Height          =   495
         Left            =   1800
         MaxLength       =   3
         TabIndex        =   4
         Top             =   720
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "Comercial"
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
         Top             =   1800
         Width           =   1455
      End
      Begin VB.Label Label2 
         Caption         =   "Domestic"
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
         TabIndex        =   2
         Top             =   840
         Width           =   1455
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Stock Status"
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
      Left            =   2160
      TabIndex        =   0
      Top             =   480
      Width           =   2175
   End
End
Attribute VB_Name = "Stock"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Command1_Click()
If (Text1.Text = "") Then
MsgBox "Enter stock", vbOKOnly, "Error"
Else
If rs.EOF Then
rs.AddNew
Else
rs.MoveFirst
End If
rs(0) = Text1.Text
rs(1) = Text2.Text
rs.Update
MsgBox "Stock updated Succesfully", vbOKOnly, "Stock"
End If
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "stock", cn, adOpenDynamic, adLockOptimistic
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
