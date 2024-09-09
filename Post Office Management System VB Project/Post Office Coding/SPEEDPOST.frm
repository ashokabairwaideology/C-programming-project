VERSION 5.00
Begin VB.Form Form3 
   Caption         =   "SPEED POST FORM"
   ClientHeight    =   7230
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8010
   LinkTopic       =   "Form3"
   ScaleHeight     =   7230
   ScaleWidth      =   8010
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Frame Frame1 
      Caption         =   "RECEIPT"
      Height          =   5415
      Left            =   0
      TabIndex        =   26
      Top             =   360
      Width           =   3975
      Begin VB.TextBox Text15 
         Height          =   375
         Left            =   2160
         TabIndex        =   38
         Top             =   4800
         Width           =   1215
      End
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   2160
         TabIndex        =   2
         Top             =   960
         Width           =   1215
      End
      Begin VB.TextBox Text14 
         Height          =   375
         Left            =   2160
         TabIndex        =   15
         Top             =   4320
         Width           =   1215
      End
      Begin VB.TextBox Text8 
         Height          =   375
         Left            =   2160
         TabIndex        =   9
         Top             =   1440
         Width           =   1215
      End
      Begin VB.TextBox Text9 
         Height          =   375
         Left            =   2160
         TabIndex        =   10
         Top             =   1920
         Width           =   1215
      End
      Begin VB.TextBox Text10 
         Height          =   375
         Left            =   2160
         TabIndex        =   11
         Top             =   2400
         Width           =   1215
      End
      Begin VB.TextBox Text11 
         Height          =   375
         Left            =   2160
         TabIndex        =   12
         Top             =   2880
         Width           =   1215
      End
      Begin VB.TextBox Text12 
         Height          =   375
         Left            =   2160
         TabIndex        =   13
         Top             =   3360
         Width           =   1215
      End
      Begin VB.TextBox Text13 
         Height          =   375
         Left            =   2160
         TabIndex        =   14
         Top             =   3840
         Width           =   1215
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2160
         TabIndex        =   1
         Top             =   480
         Width           =   1215
      End
      Begin VB.Label Label16 
         Caption         =   "COUNT"
         Height          =   255
         Left            =   360
         TabIndex        =   37
         Top             =   4800
         Width           =   1815
      End
      Begin VB.Label Label1 
         Caption         =   " SERIAL NO"
         Height          =   375
         Left            =   360
         TabIndex        =   35
         Top             =   480
         Width           =   1335
      End
      Begin VB.Label Label2 
         Caption         =   "DATE"
         Height          =   375
         Left            =   360
         TabIndex        =   34
         Top             =   960
         Width           =   1335
      End
      Begin VB.Label Label8 
         Caption         =   "PREPAID"
         Height          =   375
         Left            =   360
         TabIndex        =   33
         Top             =   1440
         Width           =   1335
      End
      Begin VB.Label Label14 
         Caption         =   "NET AMOUNT"
         Height          =   375
         Left            =   360
         TabIndex        =   32
         Top             =   4320
         Width           =   1335
      End
      Begin VB.Label Label13 
         Caption         =   "TOTAL AMOUNT"
         Height          =   375
         Left            =   360
         TabIndex        =   31
         Top             =   3840
         Width           =   1335
      End
      Begin VB.Label Label12 
         Caption         =   "ACK DUE"
         Height          =   375
         Left            =   360
         TabIndex        =   30
         Top             =   3360
         Width           =   1335
      End
      Begin VB.Label Label11 
         Caption         =   "FEE"
         Height          =   375
         Left            =   360
         TabIndex        =   29
         Top             =   2880
         Width           =   1335
      End
      Begin VB.Label Label10 
         Caption         =   "POSTAGE"
         Height          =   375
         Left            =   360
         TabIndex        =   28
         Top             =   2400
         Width           =   1335
      End
      Begin VB.Label Label9 
         Caption         =   "WEIGHT"
         Height          =   375
         Left            =   360
         TabIndex        =   27
         Top             =   1920
         Width           =   1335
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "TO ADDRESS"
      Height          =   3495
      Left            =   4200
      TabIndex        =   20
      Top             =   360
      Width           =   3255
      Begin VB.TextBox Text7 
         Height          =   375
         Left            =   1800
         TabIndex        =   8
         Top             =   2880
         Width           =   1215
      End
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   1800
         TabIndex        =   7
         Top             =   2400
         Width           =   1215
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   1800
         TabIndex        =   5
         Top             =   1440
         Width           =   1215
      End
      Begin VB.TextBox Text2 
         Height          =   375
         Left            =   1800
         TabIndex        =   3
         Top             =   480
         Width           =   1215
      End
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   1800
         TabIndex        =   4
         Top             =   960
         Width           =   1215
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   1800
         TabIndex        =   6
         Top             =   1920
         Width           =   1215
      End
      Begin VB.Label Label15 
         Caption         =   "DISTANCE"
         Height          =   375
         Left            =   120
         TabIndex        =   36
         Top             =   3000
         Width           =   1335
      End
      Begin VB.Label Label7 
         Caption         =   "PINCODE"
         Height          =   375
         Left            =   120
         TabIndex        =   25
         Top             =   2520
         Width           =   1335
      End
      Begin VB.Label Label6 
         Caption         =   "COUNTRY"
         Height          =   375
         Left            =   120
         TabIndex        =   24
         Top             =   2040
         Width           =   1335
      End
      Begin VB.Label Label5 
         Caption         =   "CITY"
         Height          =   375
         Left            =   120
         TabIndex        =   23
         Top             =   1560
         Width           =   1335
      End
      Begin VB.Label Label4 
         Caption         =   "AREA"
         Height          =   375
         Left            =   120
         TabIndex        =   22
         Top             =   1080
         Width           =   1335
      End
      Begin VB.Label Label3 
         Caption         =   "NAME"
         Height          =   375
         Left            =   120
         TabIndex        =   21
         Top             =   600
         Width           =   1335
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "ADD"
      Height          =   495
      Left            =   1200
      TabIndex        =   19
      Top             =   6120
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "SAVE"
      Height          =   495
      Left            =   2400
      TabIndex        =   16
      Top             =   6120
      Width           =   1215
   End
   Begin VB.CommandButton Command3 
      Caption         =   "END"
      Height          =   495
      Left            =   3600
      TabIndex        =   17
      Top             =   6120
      Width           =   1215
   End
   Begin VB.CommandButton Command4 
      Caption         =   "DELETE"
      Height          =   495
      Left            =   4800
      TabIndex        =   18
      Top             =   6120
      Width           =   1215
   End
   Begin VB.CommandButton Command5 
      Caption         =   "REPORT"
      Height          =   495
      Left            =   6000
      TabIndex        =   0
      Top             =   6120
      Width           =   1215
   End
End
Attribute VB_Name = "Form3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim db As Database
Dim rs As Recordset
Dim a As Integer

Private Sub Combo1_Click()
rs.MoveFirst
While Not rs.EOF
If Combo1.Text = rs(0) Then
Text1.Text = rs(1)
Text2.Text = rs(2)
Text3.Text = rs(3)
Text4.Text = rs(4)
Text5.Text = rs(5)
Text6.Text = rs(6)
Text7.Text = rs(7)
Text8.Text = rs(8)
Text9.Text = rs(9)
Text10.Text = rs(10)
Text11.Text = rs(11)
Text12.Text = rs(12)
Text13.Text = rs(13)
Text14.Text = rs(14)
Text15.Text = rs(15)
End If
rs.MoveNext
Wend
End Sub

Private Sub Command2_Click()
rs.AddNew
rs(0) = Combo1.Text
rs(1) = Text1.Text
rs(2) = Text2.Text
rs(3) = Text3.Text
rs(4) = Text4.Text
rs(5) = Text5.Text
rs(6) = Text6.Text
rs(7) = Text7.Text
rs(8) = Text8.Text
rs(9) = Text9.Text
rs(10) = Text10.Text
rs(11) = Text11.Text
rs(12) = Text12.Text
rs(13) = Text13.Text
rs(14) = Text14.Text
rs(15) = Text15.Text
rs.Update
rs.MoveLast
Combo1.AddItem rs(0)
MsgBox "record saved"
Command2.Enabled = False
End Sub

Private Sub Command1_Click()
If Not rs.BOF Then
rs.MoveLast
a = rs(0)
Combo1.Text = a + 1
Text1.Text = Date
Text2.Text = ""
Text3.Text = ""
Text4.Text = ""
Text5.Text = ""
Text6.Text = ""
Text7.Text = ""
Text8.Text = ""
Text9.Text = ""
Text10.Text = ""
Text11.Text = ""
Text12.Text = ""
Text13.Text = ""
Text14.Text = ""
Text15.Text = ""
Else
Combo1.Text = 101
Text2.SetFocus
End If
Command2.Enabled = True
End Sub

Private Sub Command3_Click()
End
End Sub

Private Sub Form_Load()
Set db = OpenDatabase("c:\seshu\postoff.mdb")
Set rs = db.OpenRecordset("speedpost")
If rs.BOF Then
MsgBox "no record exists"
Else
rs.MoveFirst
While Not rs.EOF
Combo1.AddItem rs(0)
rs.MoveNext
Wend
End If
Command2.Enabled = False
Command4.Visible = False
Command5.Visible = False
End Sub

Private Sub Text9_lostfocus()
Dim k As Integer

If Text5.Text = "india" Then
If Text7.Text <= 50 And Text9.Text <= 50 Then
Text10.Text = 15
ElseIf Text7.Text <= 200 And Text9.Text <= 50 Then
Text10.Text = 20
ElseIf Text7.Text <= 500 And Text9.Text <= 50 Then
Text10.Text = 30
ElseIf Text7.Text > 500 And Text9.Text <= 50 Then
Text10.Text = 45
ElseIf Text7.Text <= 50 And Text9.Text <= 200 Then
Text10.Text = 20
ElseIf Text7.Text <= 200 And Text9.Text <= 200 Then
Text10.Text = 30
ElseIf Text7.Text <= 500 And Text9.Text <= 200 Then
Text10.Text = 35
ElseIf Text7.Text > 500 And Text9.Text <= 200 Then
Text10.Text = 50
ElseIf Text7.Text <= 50 And Text9.Text <= 500 Then
Text10.Text = 25
ElseIf Text7.Text <= 200 And Text9.Text <= 500 Then
Text10.Text = 40
ElseIf Text7.Text <= 500 And Text9.Text <= 500 Then
Text10.Text = 45
ElseIf Text7.Text > 500 And Text9.Text <= 500 Then
Text10.Text = 55
End If
Else
If Text9.Text <= 50 Then
Text10.Text = 50
ElseIf Text9.Text <= 200 Then
Text10.Text = 60
ElseIf Text9.Text <= 500 Then
Text10.Text = 80
ElseIf Text9.Text <= 1000 Then
Text10.Text = 100
ElseIf Text9.Text > 1000 Then
MsgBox " not possible "
End If
End If
Text11.Text = 25
Text12.Text = 5
Text13.Text = Val(Text10.Text) + Val(Text11.Text) + Val(Text12.Text)
Text14.Text = Val(Text13.Text) - Val(Text8.Text)
rs.MoveLast
If Text1.Text = rs(1) Then
k = rs(15)
Text15.Text = k + 1
Else
Text15.Text = 1
End If
End Sub

