VERSION 5.00
Begin VB.Form Report 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View Report"
   ClientHeight    =   5310
   ClientLeft      =   45
   ClientTop       =   495
   ClientWidth     =   5985
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5310
   ScaleWidth      =   5985
   Begin VB.Frame Frame1 
      Height          =   3375
      Left            =   1200
      TabIndex        =   0
      Top             =   1080
      Width           =   3615
      Begin VB.CommandButton Report 
         Caption         =   "View"
         Height          =   375
         Left            =   720
         TabIndex        =   5
         Top             =   2760
         Width           =   975
      End
      Begin VB.OptionButton Option3 
         Caption         =   "Delivery"
         Height          =   375
         Left            =   600
         TabIndex        =   4
         Top             =   1200
         Width           =   1095
      End
      Begin VB.OptionButton Option2 
         Caption         =   "Booking"
         Height          =   375
         Left            =   600
         TabIndex        =   3
         Top             =   1920
         Width           =   975
      End
      Begin VB.OptionButton Option1 
         Caption         =   "Consumer"
         Height          =   375
         Left            =   600
         TabIndex        =   2
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Report"
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
      Left            =   1920
      TabIndex        =   1
      Top             =   360
      Width           =   1215
   End
End
Attribute VB_Name = "Report"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Report_Click()
If Option1.Value = True Then
Conreport.Show
ElseIf Option2.Value = True Then
Bookreport.Show
ElseIf Option3.Value = True Then
Delreport.Show
End If
End Sub
