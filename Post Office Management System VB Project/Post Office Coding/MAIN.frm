VERSION 5.00
Begin VB.Form Form6 
   Caption         =   "Form6"
   ClientHeight    =   6120
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   8025
   LinkTopic       =   "Form6"
   ScaleHeight     =   6120
   ScaleWidth      =   8025
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Menu pd 
      Caption         =   "&PostalDetails"
      Index           =   0
      Begin VB.Menu rp 
         Caption         =   "&Registerpost"
      End
      Begin VB.Menu sp 
         Caption         =   "&SpeedPost"
      End
      Begin VB.Menu mo 
         Caption         =   "&Moneyorder"
      End
      Begin VB.Menu s 
         Caption         =   "&Sales"
      End
      Begin VB.Menu ms 
         Caption         =   "&MoneySavings"
      End
   End
End
Attribute VB_Name = "Form6"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Form_Load()

End Sub

Private Sub mo_Click()
Load Form1
Form1.Show
End Sub

Private Sub ms_Click()
Load Form4
Form4.Show
End Sub

Private Sub rp_Click()
Load Form2
Form2.Show
End Sub

Private Sub s_Click()
Load Form5
Form5.Show
End Sub

Private Sub sp_Click()
Load Form3
Form3.Show
End Sub
