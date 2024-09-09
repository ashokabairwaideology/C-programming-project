VERSION 5.00
Begin VB.Form Form4 
   Caption         =   "MONEY SAVINGS FORM"
   ClientHeight    =   6900
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7695
   LinkTopic       =   "Form4"
   ScaleHeight     =   6900
   ScaleWidth      =   7695
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Frame Frame2 
      Caption         =   " "
      Height          =   6015
      Left            =   3960
      TabIndex        =   29
      Top             =   240
      Width           =   3615
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   2160
         TabIndex        =   9
         Text            =   " "
         Top             =   840
         Width           =   1215
      End
      Begin VB.TextBox Text15 
         Height          =   375
         Left            =   2160
         TabIndex        =   17
         Top             =   5400
         Width           =   1215
      End
      Begin VB.TextBox Text14 
         Height          =   375
         Left            =   2160
         TabIndex        =   16
         Top             =   4920
         Width           =   1215
      End
      Begin VB.TextBox Text8 
         Height          =   375
         Left            =   2160
         TabIndex        =   10
         Top             =   1320
         Width           =   1215
      End
      Begin VB.TextBox Text9 
         Height          =   375
         Left            =   2160
         TabIndex        =   11
         Top             =   1920
         Width           =   1215
      End
      Begin VB.TextBox Text10 
         Height          =   375
         Left            =   2160
         TabIndex        =   12
         Top             =   2520
         Width           =   1215
      End
      Begin VB.TextBox Text11 
         Height          =   375
         Left            =   2160
         TabIndex        =   13
         Top             =   3120
         Width           =   1215
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2160
         TabIndex        =   0
         Text            =   " "
         Top             =   240
         Width           =   1215
      End
      Begin VB.TextBox Text12 
         Height          =   375
         Left            =   2160
         TabIndex        =   14
         Top             =   3720
         Width           =   1215
      End
      Begin VB.TextBox Text13 
         Height          =   375
         Left            =   2160
         TabIndex        =   15
         Top             =   4320
         Width           =   1215
      End
      Begin VB.Label Label17 
         Caption         =   "COUNT"
         Height          =   255
         Left            =   360
         TabIndex        =   39
         Top             =   5520
         Width           =   1455
      End
      Begin VB.Label Label8 
         Caption         =   "TOTAL AMOUNT"
         Height          =   255
         Left            =   360
         TabIndex        =   38
         Top             =   4920
         Width           =   1455
      End
      Begin VB.Label Label14 
         Caption         =   "MONTHLY AMOUNT"
         Height          =   375
         Left            =   240
         TabIndex        =   37
         Top             =   3120
         Width           =   1575
      End
      Begin VB.Label Label16 
         Caption         =   "LAST DATE"
         Height          =   255
         Left            =   360
         TabIndex        =   36
         Top             =   4320
         Width           =   1455
      End
      Begin VB.Label Label9 
         Caption         =   "YEARS"
         Height          =   375
         Left            =   240
         TabIndex        =   35
         Top             =   840
         Width           =   1455
      End
      Begin VB.Label Label10 
         Caption         =   "INTEREST RATE"
         Height          =   375
         Left            =   240
         TabIndex        =   34
         Top             =   1320
         Width           =   1455
      End
      Begin VB.Label Label11 
         Caption         =   "START DATE"
         Height          =   375
         Left            =   240
         TabIndex        =   33
         Top             =   1920
         Width           =   1455
      End
      Begin VB.Label Label12 
         Caption         =   "AMOUNT"
         Height          =   375
         Left            =   240
         TabIndex        =   32
         Top             =   2520
         Width           =   1455
      End
      Begin VB.Label Label13 
         Caption         =   " TOTAL INTEREST"
         Height          =   375
         Left            =   240
         TabIndex        =   31
         Top             =   3720
         Width           =   1455
      End
      Begin VB.Label Label15 
         Caption         =   "ACCOUNT NO"
         Height          =   375
         Left            =   240
         TabIndex        =   30
         Top             =   240
         Width           =   1335
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "ADDRESS"
      Height          =   4695
      Left            =   360
      TabIndex        =   21
      Top             =   240
      Width           =   3495
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   1920
         TabIndex        =   2
         Top             =   480
         Width           =   1215
      End
      Begin VB.TextBox Text2 
         Height          =   375
         Left            =   1920
         TabIndex        =   3
         Top             =   1080
         Width           =   1215
      End
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   1920
         TabIndex        =   4
         Top             =   1680
         Width           =   1215
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   1920
         TabIndex        =   5
         Top             =   2280
         Width           =   1215
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   1920
         TabIndex        =   6
         Top             =   2880
         Width           =   1215
      End
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   1920
         TabIndex        =   7
         Top             =   3480
         Width           =   1215
      End
      Begin VB.TextBox Text7 
         Height          =   375
         Left            =   1920
         TabIndex        =   8
         Top             =   4080
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "STREET"
         Height          =   375
         Left            =   240
         TabIndex        =   28
         Top             =   1680
         Width           =   1335
      End
      Begin VB.Label Label4 
         Caption         =   "AREA"
         Height          =   375
         Left            =   240
         TabIndex        =   27
         Top             =   2280
         Width           =   1335
      End
      Begin VB.Label Label5 
         Caption         =   "CITY"
         Height          =   375
         Left            =   240
         TabIndex        =   26
         Top             =   2880
         Width           =   1335
      End
      Begin VB.Label Label6 
         Caption         =   "COUNTRY"
         Height          =   375
         Left            =   240
         TabIndex        =   25
         Top             =   3480
         Width           =   1335
      End
      Begin VB.Label Label7 
         Caption         =   "PINCODE"
         Height          =   375
         Left            =   240
         TabIndex        =   24
         Top             =   4080
         Width           =   1335
      End
      Begin VB.Label Label1 
         Caption         =   "NAME"
         Height          =   375
         Left            =   240
         TabIndex        =   23
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label Label2 
         Caption         =   "DOOR NO"
         Height          =   375
         Left            =   240
         TabIndex        =   22
         Top             =   1080
         Width           =   1455
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "END"
      Height          =   495
      Left            =   480
      TabIndex        =   20
      Top             =   5280
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "ADD"
      Height          =   495
      Left            =   1680
      TabIndex        =   1
      Top             =   5280
      Width           =   1215
   End
   Begin VB.CommandButton Command3 
      Caption         =   "UPDATE"
      Height          =   495
      Left            =   480
      TabIndex        =   19
      Top             =   5760
      Width           =   1215
   End
   Begin VB.CommandButton Command4 
      Caption         =   "CLEAR"
      Height          =   495
      Left            =   1680
      TabIndex        =   18
      Top             =   5760
      Width           =   1215
   End
End
Attribute VB_Name = "Form4"
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
Call data
End If
rs.MoveNext
Wend
End Sub

Private Sub Combo2_LostFocus()
Text8.Text = 9.8
Text9.Text = Date
End Sub

Private Sub Command1_Click()
End
End Sub

Private Sub Command2_Click()
If Not rs.BOF Then
rs.MoveLast
a = rs(0)
Call clear
Combo1.Text = a + 1
Else
Combo1.Text = 101
End If
Text9.Text = Date
Text1.SetFocus
Command3.Enabled = True
End Sub

Private Sub Command3_Click()
Call save
rs.MoveLast
Combo1.AddItem rs(0)
MsgBox "record saved"
Call clear
Command3.Enabled = False
End Sub

Private Sub Command4_Click()
Call clear
End Sub

Private Sub Form_Load()
Set db = OpenDatabase("c:\program files\microsoft visual studio\vb98\vijay\postoff.mdb")
Set rs = db.OpenRecordset("moneysavings")
If rs.BOF And rs.EOF Then
MsgBox "no record exists"
Else
rs.MoveFirst
While Not rs.EOF
Combo1.AddItem rs(0)
rs.MoveNext
Wend
End If
Command3.Enabled = False
End Sub

Public Sub clear()
Combo1.Text = ""
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
Text4.Text = ""
Text5.Text = ""
Text6.Text = ""
Text7.Text = ""
Combo2.Text = ""
Text8.Text = ""
Text9.Text = ""
Text10.Text = ""
Text11.Text = ""
Text12.Text = ""
Text13.Text = ""
Text14.Text = ""
Text15.Text = ""
End Sub

Public Sub save()
rs.AddNew
rs(0) = Combo1.Text
rs(1) = Text1.Text
rs(2) = Text2.Text
rs(3) = Text3.Text
rs(4) = Text4.Text
rs(5) = Text5.Text
rs(6) = Text6.Text
rs(7) = Text7.Text
rs(8) = Combo2.Text
rs(9) = Text8.Text
rs(10) = Text9.Text
rs(11) = Text10.Text
rs(12) = Text11.Text
rs(13) = Text12.Text
rs(14) = Text13.Text
rs(15) = Text14.Text
rs(16) = Text15.Text
rs.Update
End Sub

Public Sub data()
Combo1.Text = rs(0)
Text1.Text = rs(1)
Text2.Text = rs(2)
Text3.Text = rs(3)
Text4.Text = rs(4)
Text5.Text = rs(5)
Text6.Text = rs(6)
Text7.Text = rs(7)
Combo2.Text = rs(8)
Text8.Text = rs(9)
Text9.Text = rs(10)
Text10.Text = rs(11)
Text11.Text = rs(12)
Text12.Text = rs(13)
Text13.Text = rs(14)
Text14.Text = rs(15)
Text15.Text = rs(16)
End Sub

Private Sub Text10_lostfocus()
Dim i, k As Integer
Dim amt, inte As Double
If Text10.Text > 5000 Then
If Combo2.Text = "1YEAR" Then
Text11.Text = Round(Val(Text10.Text) / 12)
a = 12
Text13.Text = DateAdd("m", 12, Date)
ElseIf Combo2.Text = "2YEARS" Then
Text11.Text = Round(Val(Text10.Text) / 24)
a = 24
Text13.Text = DateAdd("m", 24, Date)
ElseIf Combo2.Text = "3YEARS" Then
Text11.Text = Round(Val(Text10.Text) / 36)
a = 36
Text13.Text = DateAdd("m", 36, Date)
ElseIf Combo2.Text = "5YEARS" Then
Text11.Text = Round(Val(Text10.Text) / 60)
a = 60
Text13.Text = DateAdd("m", 60, Date)
End If
Else
MsgBox " minimum deposited amount should be 5000Rs."
Text10.Text = ""
Text11.Text = ""
End If
inte = 0
amt = Val(Text11.Text)

For i = 1 To a
inte = Round((amt + inte) * (1.01))
'MsgBox inte
'MsgBox i
Next

Text12.Text = inte - Val(Text10.Text)
Text14.Text = inte

rs.MoveLast
If Text9.Text = rs(10) Then
k = rs(16)
Text15.Text = k + 1
Else
Text15.Text = 1
End If
End Sub

