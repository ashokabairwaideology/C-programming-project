VERSION 5.00
Begin VB.Form Form5 
   Caption         =   "SALES FORM"
   ClientHeight    =   6510
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7200
   LinkTopic       =   "Form5"
   ScaleHeight     =   6510
   ScaleWidth      =   7200
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton Command7 
      Caption         =   "EDIT"
      Height          =   495
      Left            =   4920
      TabIndex        =   13
      Top             =   2880
      Width           =   1215
   End
   Begin VB.CommandButton Command6 
      Caption         =   "END"
      Height          =   495
      Left            =   4920
      TabIndex        =   16
      Top             =   4785
      Width           =   1215
   End
   Begin VB.CommandButton Command5 
      Caption         =   "REPORT"
      Height          =   495
      Left            =   4920
      TabIndex        =   15
      Top             =   4155
      Width           =   1215
   End
   Begin VB.CommandButton Command4 
      Caption         =   "DELETE"
      Height          =   495
      Left            =   4920
      TabIndex        =   14
      Top             =   3540
      Width           =   1215
   End
   Begin VB.CommandButton Command3 
      Caption         =   "SAVE"
      Height          =   495
      Left            =   4920
      TabIndex        =   12
      Top             =   2205
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "ADD"
      Height          =   495
      Left            =   4920
      TabIndex        =   11
      Top             =   1575
      Width           =   1215
   End
   Begin VB.CommandButton Command1 
      Caption         =   "SHOW"
      Height          =   495
      Left            =   4920
      TabIndex        =   10
      Top             =   960
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Height          =   5175
      Left            =   480
      TabIndex        =   0
      Top             =   600
      Width           =   3615
      Begin VB.TextBox Text6 
         Height          =   405
         Left            =   1920
         TabIndex        =   9
         Text            =   " "
         Top             =   4560
         Width           =   1335
      End
      Begin VB.ComboBox Combo3 
         Height          =   315
         Left            =   1920
         TabIndex        =   5
         Text            =   " "
         Top             =   2385
         Width           =   1335
      End
      Begin VB.TextBox Text5 
         Height          =   405
         Left            =   1920
         TabIndex        =   8
         Text            =   " "
         Top             =   3960
         Width           =   1335
      End
      Begin VB.TextBox Text4 
         Height          =   405
         Left            =   1920
         TabIndex        =   7
         Text            =   " "
         Top             =   3405
         Width           =   1335
      End
      Begin VB.TextBox Text3 
         Height          =   405
         Left            =   1920
         TabIndex        =   6
         Text            =   " "
         Top             =   2850
         Width           =   1335
      End
      Begin VB.TextBox Text2 
         Height          =   405
         Left            =   1920
         TabIndex        =   4
         Text            =   " "
         Top             =   1830
         Width           =   1335
      End
      Begin VB.TextBox Text1 
         Height          =   405
         Left            =   1920
         TabIndex        =   2
         Text            =   " "
         Top             =   825
         Width           =   1335
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   1920
         TabIndex        =   3
         Top             =   1380
         Width           =   1335
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   1920
         TabIndex        =   1
         Text            =   " "
         Top             =   360
         Width           =   1335
      End
      Begin VB.Label Label15 
         Caption         =   "COUNT"
         Height          =   255
         Left            =   240
         TabIndex        =   25
         Top             =   4560
         Width           =   1455
      End
      Begin VB.Label Label8 
         Caption         =   "AMOUNT"
         Height          =   255
         Left            =   240
         TabIndex        =   24
         Top             =   4035
         Width           =   1335
      End
      Begin VB.Label Label7 
         Caption         =   "REQ NUMBER"
         Height          =   255
         Left            =   240
         TabIndex        =   23
         Top             =   3510
         Width           =   1335
      End
      Begin VB.Label Label6 
         Caption         =   "RATE"
         Height          =   255
         Left            =   240
         TabIndex        =   22
         Top             =   2985
         Width           =   1335
      End
      Begin VB.Label Label5 
         Caption         =   "POSTCARD"
         Height          =   255
         Left            =   240
         TabIndex        =   21
         Top             =   2460
         Width           =   1335
      End
      Begin VB.Label Label4 
         Caption         =   "SRNUMBER"
         Height          =   255
         Left            =   240
         TabIndex        =   20
         Top             =   1935
         Width           =   1335
      End
      Begin VB.Label Label3 
         Caption         =   "STAMPS"
         Height          =   255
         Left            =   240
         TabIndex        =   19
         Top             =   1410
         Width           =   1335
      End
      Begin VB.Label Label2 
         Caption         =   "DATE"
         Height          =   255
         Left            =   240
         TabIndex        =   18
         Top             =   885
         Width           =   1335
      End
      Begin VB.Label Label1 
         Caption         =   "SERIAL NO"
         Height          =   255
         Left            =   240
         TabIndex        =   17
         Top             =   360
         Width           =   1335
      End
   End
End
Attribute VB_Name = "Form5"
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
Combo2.Text = rs(2)
Text2.Text = rs(3)
Combo3.Text = rs(4)
Text3.Text = rs(5)
Text4.Text = rs(6)
Text5.Text = rs(7)
Text6.Text = rs(8)
End If
rs.MoveNext
Wend
Command3.Enabled = False
End Sub

Private Sub Combo3_lostfocus()
If Combo3.Text = "single" Then
Text3.Text = 0.5
ElseIf Combo3.Text = "reply" Then
Text3.Text = 1
ElseIf Combo3.Text = "print" Then
Text3.Text = 3
ElseIf Combo3.Text = "competition" Then
Text3.Text = 5
ElseIf Combo3.Text = "envolop" Then
Text3.Text = 3
ElseIf Combo3.Text = "englandcover" Then
Text3.Text = 2
End If
Text4.SetFocus
End Sub

Private Sub Command2_Click()
rs.MoveLast
a = rs(0)
Combo1.Text = a + 1
Text1.Text = Date
Combo2.Text = ""
Text2.Text = ""
Combo3.Text = ""
Text3.Text = ""
Text4.Text = ""
Text5.Text = ""
Text6.Text = ""
Combo2.SetFocus
Command3.Enabled = True
End Sub

Private Sub Command3_Click()
rs.AddNew
rs(0) = Combo1.Text
rs(1) = Text1.Text
rs(2) = Combo2.Text
rs(3) = Text2.Text
rs(4) = Combo3.Text
rs(5) = Text3.Text
rs(6) = Text4.Text
rs(7) = Text5.Text
rs(8) = Text6.Text
rs.Update
MsgBox "record saved"
rs.MoveLast
Combo1.AddItem rs(0)
Command3.Enabled = False
End Sub

Private Sub Command6_Click()
End
End Sub

Private Sub Form_Load()
Set db = OpenDatabase("c:\program files\microsoft visual studio\vb98\vijay\postoff.mdb")
Set rs = db.OpenRecordset("sales")
Command1.Visible = False
Command4.Visible = False
Command7.Visible = False
Command3.Enabled = False
rs.MoveFirst
While Not rs.EOF
Combo1.AddItem (rs(0))
rs.MoveNext
Wend
Command3.Enabled = False
End Sub

Private Sub Text4_LostFocus()
Dim k As Integer
Text5.Text = Val(Combo2.Text) * Val(Text2.Text) + Val(Text3.Text) * Val(Text4.Text)
rs.MoveLast
If Text1.Text = rs(1) Then
k = rs(8)
Text6.Text = k + 1
Else
Text6.Text = 1
End If
End Sub
