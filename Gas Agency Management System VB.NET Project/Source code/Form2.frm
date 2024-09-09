VERSION 5.00
Begin VB.Form Consumer 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Consumer Entry"
   ClientHeight    =   5715
   ClientLeft      =   45
   ClientTop       =   495
   ClientWidth     =   8130
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5715
   ScaleWidth      =   8130
   Begin VB.Frame Frame1 
      Height          =   4335
      Left            =   240
      TabIndex        =   1
      Top             =   1080
      Width           =   7575
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   4440
         TabIndex        =   23
         Top             =   3480
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Add"
         Height          =   495
         Left            =   1200
         TabIndex        =   22
         Top             =   3480
         Width           =   1455
      End
      Begin VB.TextBox Text10 
         Height          =   375
         Left            =   1440
         TabIndex        =   20
         Top             =   1560
         Width           =   1695
      End
      Begin VB.TextBox Text9 
         Height          =   375
         Left            =   5400
         TabIndex        =   19
         Top             =   2880
         Width           =   1935
      End
      Begin VB.TextBox Text8 
         Height          =   375
         Left            =   5400
         TabIndex        =   18
         Top             =   2160
         Width           =   1935
      End
      Begin VB.TextBox Text7 
         Height          =   375
         Left            =   5400
         TabIndex        =   17
         Top             =   1560
         Width           =   1935
      End
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   5400
         TabIndex        =   16
         Top             =   960
         Width           =   1935
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   5400
         TabIndex        =   15
         Top             =   360
         Width           =   1935
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   1440
         TabIndex        =   14
         Top             =   2760
         Width           =   1695
      End
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   1440
         TabIndex        =   13
         Top             =   2160
         Width           =   1695
      End
      Begin VB.TextBox Text2 
         Height          =   375
         Left            =   1440
         TabIndex        =   12
         Top             =   960
         Width           =   1695
      End
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   1440
         TabIndex        =   11
         Top             =   360
         Width           =   1695
      End
      Begin VB.Label Label11 
         Caption         =   "Last Name"
         Height          =   255
         Left            =   240
         TabIndex        =   21
         Top             =   1680
         Width           =   855
      End
      Begin VB.Label Label10 
         Caption         =   "No: of Cylinder"
         Height          =   255
         Left            =   4080
         TabIndex        =   10
         Top             =   2880
         Width           =   1095
      End
      Begin VB.Label Label9 
         Caption         =   "Cylinder Type"
         Height          =   255
         Left            =   4200
         TabIndex        =   9
         Top             =   2160
         Width           =   975
      End
      Begin VB.Label Label8 
         Caption         =   "Date of Connection"
         Height          =   255
         Left            =   3840
         TabIndex        =   8
         Top             =   1560
         Width           =   1455
      End
      Begin VB.Label Label7 
         Caption         =   "City"
         Height          =   255
         Left            =   4800
         TabIndex        =   7
         Top             =   480
         Width           =   375
      End
      Begin VB.Label Label6 
         Caption         =   "Phone"
         Height          =   255
         Left            =   4560
         TabIndex        =   6
         Top             =   1080
         Width           =   615
      End
      Begin VB.Label Label5 
         Caption         =   "Address Line2"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   2880
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "Address Line1"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   2280
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "First Name"
         Height          =   255
         Left            =   240
         TabIndex        =   3
         Top             =   1080
         Width           =   975
      End
      Begin VB.Label Label2 
         Caption         =   "Consumer No:"
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Consumer Entry"
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
      Left            =   2520
      TabIndex        =   0
      Top             =   240
      Width           =   2895
   End
End
Attribute VB_Name = "Consumer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command2_Click()
Unload Me
End Sub
