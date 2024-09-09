VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "MONEY ORDER FORM"
   ClientHeight    =   7470
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8145
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   7470
   ScaleWidth      =   8145
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton Command8 
      Caption         =   "REPORT"
      Height          =   495
      Left            =   5040
      TabIndex        =   17
      Top             =   6600
      Width           =   1215
   End
   Begin VB.CommandButton Command7 
      Caption         =   "CLEAR"
      Height          =   495
      Left            =   5040
      TabIndex        =   15
      Top             =   6120
      Width           =   1215
   End
   Begin VB.CommandButton Command6 
      Caption         =   "BACK"
      Height          =   495
      Left            =   5040
      TabIndex        =   14
      Top             =   5640
      Width           =   1215
   End
   Begin VB.CommandButton Command5 
      Caption         =   "SAVE"
      Height          =   495
      Left            =   5040
      TabIndex        =   13
      Top             =   5160
      Width           =   1215
   End
   Begin VB.CommandButton Command4 
      Caption         =   "ADD"
      Height          =   495
      Left            =   5040
      TabIndex        =   12
      Top             =   4680
      Width           =   1215
   End
   Begin VB.CommandButton Command3 
      Caption         =   "END"
      Height          =   495
      Left            =   5040
      TabIndex        =   16
      Top             =   4200
      Width           =   1215
   End
   Begin VB.Frame Frame2 
      Caption         =   "TO ADDRESS"
      Height          =   3255
      Left            =   360
      TabIndex        =   23
      Top             =   4080
      Width           =   4335
      Begin VB.TextBox Text4 
         Height          =   405
         Left            =   2280
         TabIndex        =   5
         Top             =   1560
         Width           =   1575
      End
      Begin VB.TextBox Text3 
         Height          =   405
         Left            =   2280
         TabIndex        =   4
         Text            =   " "
         Top             =   960
         Width           =   1575
      End
      Begin VB.TextBox Text2 
         Height          =   405
         Left            =   2280
         TabIndex        =   3
         Text            =   " "
         Top             =   360
         Width           =   1575
      End
      Begin VB.TextBox Text6 
         Height          =   405
         Left            =   2280
         TabIndex        =   7
         Text            =   " "
         Top             =   2640
         Width           =   1575
      End
      Begin VB.TextBox Text5 
         Height          =   405
         Left            =   2280
         TabIndex        =   6
         Text            =   " "
         Top             =   2160
         Width           =   1575
      End
      Begin VB.Label Label11 
         Caption         =   "PINCODE"
         Height          =   255
         Left            =   240
         TabIndex        =   29
         Top             =   2760
         Width           =   1215
      End
      Begin VB.Label Label6 
         Caption         =   "COUNTRY"
         Height          =   255
         Left            =   240
         TabIndex        =   27
         Top             =   2160
         Width           =   1215
      End
      Begin VB.Label Label5 
         Caption         =   "CITY"
         Height          =   255
         Left            =   240
         TabIndex        =   26
         Top             =   1680
         Width           =   1215
      End
      Begin VB.Label Label4 
         Caption         =   "AREA"
         Height          =   255
         Left            =   240
         TabIndex        =   25
         Top             =   1080
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "NAME"
         Height          =   255
         Left            =   240
         TabIndex        =   24
         Top             =   480
         Width           =   1215
      End
   End
   Begin VB.Frame Frame1 
      Height          =   3495
      Left            =   360
      TabIndex        =   0
      Top             =   360
      Width           =   4335
      Begin VB.TextBox Text7 
         Height          =   405
         Left            =   2280
         TabIndex        =   8
         Text            =   " "
         Top             =   1440
         Width           =   1575
      End
      Begin VB.TextBox Text8 
         Height          =   405
         Left            =   2280
         TabIndex        =   9
         Top             =   1920
         Width           =   1575
      End
      Begin VB.TextBox Text9 
         Height          =   405
         Left            =   2280
         TabIndex        =   10
         Text            =   " "
         Top             =   2400
         Width           =   1575
      End
      Begin VB.TextBox Text10 
         Height          =   405
         Left            =   2280
         TabIndex        =   11
         Text            =   " "
         Top             =   2880
         Width           =   1575
      End
      Begin VB.TextBox Text1 
         Height          =   405
         Left            =   2280
         TabIndex        =   2
         Text            =   " "
         Top             =   960
         Width           =   1575
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2280
         TabIndex        =   1
         Text            =   " "
         Top             =   480
         Width           =   1575
      End
      Begin VB.Label Label10 
         Caption         =   "COUNT"
         Height          =   255
         Left            =   240
         TabIndex        =   28
         Top             =   3000
         Width           =   1815
      End
      Begin VB.Label Label9 
         Caption         =   "TOTAL AMOUNT"
         Height          =   255
         Left            =   240
         TabIndex        =   22
         Top             =   2520
         Width           =   1815
      End
      Begin VB.Label Label8 
         Caption         =   "COMMISSION"
         Height          =   255
         Left            =   240
         TabIndex        =   21
         Top             =   2040
         Width           =   1815
      End
      Begin VB.Label Label7 
         Caption         =   "AMOUNT"
         Height          =   255
         Left            =   240
         TabIndex        =   20
         Top             =   1560
         Width           =   1815
      End
      Begin VB.Label Label2 
         Caption         =   "DATE"
         Height          =   255
         Left            =   240
         TabIndex        =   19
         Top             =   1080
         Width           =   1815
      End
      Begin VB.Label Label1 
         Caption         =   "SERIAL NUMBER"
         Height          =   255
         Left            =   240
         TabIndex        =   18
         Top             =   600
         Width           =   1815
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim db As Database
Dim rs, rs1 As Recordset
Dim a, k As Integer

Private Sub Combo1_Click()
rs.MoveFirst
While Not rs.EOF
If Combo1.Text = rs(0) Then
Call data
End If
rs.MoveNext
Wend
End Sub

Private Sub Command5_Click()
Call save
rs.MoveLast
Combo1.AddItem rs(0)
MsgBox "record saved"
Call clear
End Sub

Private Sub Command4_Click()
rs.MoveLast
a = rs(0)
Call clear
Combo1.Text = a + 1
Text1.Text = Date
Text2.SetFocus
Command5.Enabled = True
End Sub

Private Sub Command3_Click()
End
End Sub

Private Sub Command6_Click()
Form6.Show
Load Form6
End Sub

Private Sub Command7_Click()
Call clear
End Sub

Private Sub Form_Load()
Set db = OpenDatabase("c:\program files\microsoft visual studio\vb98\vijay\postoff.mdb")
Set rs = db.OpenRecordset("moneyorder")
rs.MoveFirst
While Not rs.EOF
Combo1.AddItem rs(0)
rs.MoveNext
Wend
End Sub

Private Sub Text7_lostfocus()
Dim l, i, J As Integer
If ((Text5.Text = "india" Or Text5.Text = "INDIA") And Text7.Text <= 5000) Then
l = 5
J = 1
For i = 1 To Val(Text7.Text)
Text8.Text = l
J = J + 1
i = J * 100
l = l + 5
Next
Text9.Text = Val(Text7.Text) + Val(Text8.Text)
ElseIf ((Text5.Text = "india" Or Text5.Text = "INDIA") And Text7.Text > 5000) Then
MsgBox "AMOUNT SHOULD BE <5000"
Text7.Text = ""
Text7.SetFocus
ElseIf ((Text5.Text <> "india" Or Text5.Text <> "INDIA") And Text7.Text <= 50000) Then
l = 15
J = 1
For i = 1 To Val(Text7.Text)
Text8.Text = l
J = J + 1
i = J * 100
l = l + 15
Next
Text9.Text = Val(Text7.Text) + Val(Text8.Text)
ElseIf ((Text5.Text <> "india" Or Text5.Text <> "INDIA") And Text7.Text > 50000) Then
MsgBox "AMOUNT SHOULD BE <50000"
Text7.Text = ""
Text7.SetFocus
End If
rs.MoveLast
If Text1.Text = rs(1) Then
k = rs(10)
Text10.Text = k + 1
Else
Text10.Text = 1
End If
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
Text8.Text = ""
Text9.Text = ""
Text10.Text = ""
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
rs(8) = Text8.Text
rs(9) = Text9.Text
rs(10) = Text10.Text
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
Text8.Text = rs(8)
Text9.Text = rs(9)
Text10.Text = rs(10)
End Sub
