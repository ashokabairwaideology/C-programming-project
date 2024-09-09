VERSION 5.00
Begin VB.Form Form13 
   Caption         =   "Form13"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   LinkTopic       =   "Form13"
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin VB.CommandButton cmdEXIT 
      Caption         =   "EXIT"
      Height          =   735
      Left            =   4440
      TabIndex        =   3
      Top             =   4080
      Width           =   1815
   End
   Begin VB.CommandButton cmdLOGIN 
      Caption         =   "LOGIN"
      Height          =   735
      Left            =   2160
      TabIndex        =   2
      Top             =   4080
      Width           =   1815
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "SEC INDUSTRIES PVT LTD"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   29.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   690
      Left            =   840
      TabIndex        =   1
      Top             =   1560
      Width           =   7995
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "HYDERABAD"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   29.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   690
      Left            =   1920
      TabIndex        =   0
      Top             =   2760
      Width           =   3900
   End
End
Attribute VB_Name = "Form13"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdexit_Click()
Call closing
End
End Sub
Private Sub cmdLOGIN_Click()
Form14.Show
Form14.txtID.SetFocus
Unload Me
End Sub
Private Sub Form_Load()
Form13.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
End Sub
