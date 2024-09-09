VERSION 5.00
Begin VB.Form Form8 
   Caption         =   "Form8"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   LinkTopic       =   "Form8"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin VB.TextBox txtCODE 
      Height          =   375
      Left            =   4320
      TabIndex        =   0
      Top             =   1440
      Width           =   1935
   End
   Begin VB.TextBox txtIDES 
      Height          =   375
      Left            =   4320
      TabIndex        =   1
      Top             =   2160
      Width           =   1935
   End
   Begin VB.CommandButton cmdNEW 
      Caption         =   "&New"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2040
      TabIndex        =   3
      Top             =   4320
      Width           =   1095
   End
   Begin VB.CommandButton cmdSAVE 
      Caption         =   "&Save"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3240
      TabIndex        =   4
      Top             =   4320
      Width           =   1095
   End
   Begin VB.CommandButton cmdMODIFY 
      Caption         =   "&Modify"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4440
      TabIndex        =   5
      Top             =   4320
      Width           =   1095
   End
   Begin VB.CommandButton cmdDEL 
      Caption         =   "&Delete"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2040
      TabIndex        =   6
      Top             =   4920
      Width           =   1095
   End
   Begin VB.CommandButton cmdFIND 
      Caption         =   "&Find"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3240
      TabIndex        =   7
      Top             =   4920
      Width           =   1095
   End
   Begin VB.CommandButton cmdEXIT 
      Caption         =   "&Exit"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4440
      TabIndex        =   9
      Top             =   4920
      Width           =   1095
   End
   Begin VB.TextBox txtRATE 
      Height          =   375
      Left            =   4320
      TabIndex        =   2
      Top             =   2880
      Width           =   1575
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Item Code"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   2160
      TabIndex        =   12
      Top             =   1440
      Width           =   1065
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Item Description"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   2160
      TabIndex        =   11
      Top             =   2160
      Width           =   1695
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "ITEM CODE MASTER"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   3120
      TabIndex        =   10
      Top             =   0
      Width           =   3075
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "Rate"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   2160
      TabIndex        =   8
      Top             =   2880
      Width           =   510
   End
End
Attribute VB_Name = "Form8"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim ed1%
Dim bool As Boolean
Dim clmod As New inventclass
Private Sub cmddel_Click()
Dim d%, n%
cmdfind_Click
If bool = False Then Exit Sub
n = clmod.nul(Me)
If n <> 1 Then
  MsgBox "Fields are null so cannot be delete"
  Exit Sub
End If
d = MsgBox("Dou You want to Delete the Current Record", vbYesNo)
If d = vbYes Then
 itemrs.Delete
 itemrs.Requery
 Call clmod.clall(Me)
End If
End Sub
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
bool = True
Dim f$
f = InputBox("Enter Item Code that you want Find", vbYesNo)
If Not IsNumeric(i) And i = "" Then Exit Sub
itemrs.MoveFirst
itemrs.Find "itemcode=" & f
If Not itemrs.EOF Then
  txtcode = itemrs("itemcode")
  txtIDES = itemrs("description")
  txtrate = itemrs("rate")
Else
   MsgBox "Record Does Not Exists"
   bool = False
   Exit Sub
End If
End Sub
Private Sub cmdmodify_Click()
cmdfind_Click
Call clmod.enbt(Me)
txtcode.Enabled = False
ed1 = 0
End Sub
Private Sub cmdnew_Click()
Call clmod.clall(Me)
Dim a%
If itemrs.RecordCount = 0 Then
a = 1001
Else
itemrs.MoveLast
a = itemrs("itemcode") + 1
End If
txtcode = a
Call clmod.enbt(Me)
txtcode.Enabled = False
txtIDES.SetFocus
ed1 = 1
End Sub
Private Sub cmdSAVE_Click()
Dim x%
x = clmod.nul(Me)
If x <> 1 Then Exit Sub
If ed1 = 1 Then
itemrs.AddNew
itemrec
ElseIf ed1 = 0 Then
itemrec
End If
End Sub
Private Sub Form_Load()
'Form8.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
ed1 = 0
End Sub
Private Sub txtIDES_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtrate_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Sub itemrec()
itemrs("itemcode") = Trim(txtcode)
itemrs("description") = Trim(txtIDES)
itemrs("rate") = Trim(txtrate)
itemrs.Update
MsgBox "updated"
Call clmod.enbf(Me)
End Sub
