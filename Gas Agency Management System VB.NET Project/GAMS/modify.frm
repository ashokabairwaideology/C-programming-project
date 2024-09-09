VERSION 5.00
Begin VB.Form Form6 
   BackColor       =   &H00FF8080&
   Caption         =   "Indian Gas Service"
   ClientHeight    =   8595
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11130
   ControlBox      =   0   'False
   LinkTopic       =   "Form6"
   ScaleHeight     =   8595
   ScaleWidth      =   11130
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton Command1 
      Caption         =   "&Consumer Detail"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   2520
      TabIndex        =   1
      Top             =   3240
      Width           =   2775
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Connection Detail"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   6360
      TabIndex        =   2
      Top             =   3240
      Width           =   2775
   End
   Begin VB.CommandButton Command7 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Back to Main Menu"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   4440
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   4800
      Width           =   2775
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "INDIAN GAS SERVICES"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   495
      Left            =   3600
      TabIndex        =   4
      Top             =   960
      Width           =   4410
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "INDIAN GAS SERVICES"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   495
      Left            =   3600
      TabIndex        =   5
      Top             =   960
      Width           =   4410
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Modify Window"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   435
      Left            =   4560
      TabIndex        =   0
      Top             =   1920
      Width           =   2670
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   1920
      Top             =   1800
      Width           =   7575
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   6975
      Left            =   1920
      Top             =   720
      Width           =   7575
   End
End
Attribute VB_Name = "Form6"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public b As String
Public C As String

Private Sub Command1_Click()
On Error GoTo LB1
b = InputBox("Enter Consuner No", "Find to Modify")
If b = "" Then
Exit Sub
End If

If charcheck(b) = 0 Then
    MsgBox "No Record found........"
    Exit Sub
End If


Load Form12
Form12.Show
Unload Me
LB1:
End Sub

Private Sub Command2_Click()
On Error GoTo LB2
C = InputBox("Enter Consuner No", "Find to Modify")
If C = "" Then
Exit Sub
End If

If charcheck(C) = 0 Then
    MsgBox "No Record found........"
    Exit Sub
End If

Load Form13
Form13.Show
Unload Me
LB2:
End Sub

Private Sub Command7_Click()
Load Form1
Form1.Show
Unload Me
End Sub

