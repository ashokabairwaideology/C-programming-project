VERSION 5.00
Begin VB.Form Form7 
   Caption         =   "Form7"
   ClientHeight    =   4785
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6390
   LinkTopic       =   "Form7"
   ScaleHeight     =   4785
   ScaleWidth      =   6390
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command6 
      Caption         =   "Exit"
      Height          =   495
      Left            =   1080
      TabIndex        =   5
      Top             =   3840
      Width           =   4695
   End
   Begin VB.CommandButton Command5 
      Caption         =   "date wise speedpost details "
      Height          =   495
      Left            =   1080
      TabIndex        =   4
      Top             =   3120
      Width           =   4695
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Datewise Sales Details"
      Height          =   495
      Left            =   1080
      TabIndex        =   3
      Top             =   2400
      Width           =   4695
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Citywise Register Details"
      Height          =   495
      Left            =   1080
      TabIndex        =   2
      Top             =   1680
      Width           =   4695
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Datewise Recurring"
      Height          =   495
      Left            =   1080
      TabIndex        =   1
      Top             =   960
      Width           =   4695
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Datewise Money Order "
      Height          =   495
      Left            =   1080
      TabIndex        =   0
      Top             =   240
      Width           =   4695
   End
End
Attribute VB_Name = "Form7"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
x = InputBox("Enter The Date")
DataEnvironment1.Command1 x
DataReport1.Show
End Sub

Private Sub Command2_Click()
x = InputBox("Enter The Date")
DataEnvironment1.Command2 x
DataReport2.Show
End Sub

Private Sub Command3_Click()
x = InputBox("Enter The City Name")
DataEnvironment1.Command3 x
DataReport3.Show
End Sub

Private Sub Command4_Click()
x = InputBox("Enter The Date")
DataEnvironment1.Command4 x
DataReport4.Show
End Sub

Private Sub Command5_Click()
x = InputBox("Enter The Date")
DataEnvironment1.Command5 x
DataReport5.Show
End Sub

Private Sub Command6_Click()
End
End Sub
