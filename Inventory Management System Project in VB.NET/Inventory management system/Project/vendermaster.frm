VERSION 5.00
Begin VB.Form Form7 
   Caption         =   "Form7"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   LinkTopic       =   "Form7"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin VB.TextBox txtvno 
      Height          =   375
      Left            =   4200
      TabIndex        =   0
      Top             =   1680
      Width           =   1575
   End
   Begin VB.TextBox txtvname 
      Height          =   375
      Left            =   4200
      TabIndex        =   1
      Top             =   2400
      Width           =   1575
   End
   Begin VB.TextBox txtvadd 
      Height          =   855
      Left            =   4200
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   2
      Top             =   3120
      Width           =   3135
   End
   Begin VB.CommandButton cmdnew 
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
      Left            =   2520
      TabIndex        =   3
      Top             =   4440
      Width           =   1215
   End
   Begin VB.CommandButton cmdsave 
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
      Left            =   3840
      TabIndex        =   4
      Top             =   4440
      Width           =   1215
   End
   Begin VB.CommandButton cmdmodify 
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
      Left            =   5160
      TabIndex        =   5
      Top             =   4440
      Width           =   1215
   End
   Begin VB.CommandButton cmddel 
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
      Left            =   2520
      TabIndex        =   6
      Top             =   5160
      Width           =   1215
   End
   Begin VB.CommandButton cmdfind 
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
      Left            =   3840
      TabIndex        =   7
      Top             =   5160
      Width           =   1215
   End
   Begin VB.CommandButton cmdexit 
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
      Left            =   5160
      TabIndex        =   9
      Top             =   5160
      Width           =   1215
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Vendor No"
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
      Top             =   1680
      Width           =   1125
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Vendor Name"
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
      Top             =   2520
      Width           =   1440
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Vendor Address"
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
      TabIndex        =   10
      Top             =   3480
      Width           =   1695
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "VENDOR DETAILS FORM"
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
      Left            =   3600
      TabIndex        =   8
      Top             =   0
      Width           =   3660
   End
End
Attribute VB_Name = "Form7"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim ed1%
Dim bool As Boolean
Dim clmod As New inventclass
Private Sub cmddel_Click()
Dim d%, n%
Call cmdfind_Click
If bool = False Then Exit Sub
n = clmod.nul(Me)
If n <> 1 Then
  MsgBox "Fields are null so cannot be delete"
  Exit Sub
End If
d = MsgBox("Dou You want to Delete then Current Record", vbYesNo)
If d = vbYes Then
 venderrs.Delete
 venderrs.Requery
 Call clmod.clall(Me)
End If
End Sub
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
bool = True
f = InputBox("Enter Vendor No that you want Find", vbYesNo)
If Not IsNumeric(f) And f = "" Then Exit Sub
venderrs.MoveFirst
venderrs.Find "vno=" & f
If Not venderrs.EOF Then
  txtvno = venderrs("vno")
  txtvname = venderrs("vname")
  txtvadd = venderrs("vaddr")
Else
   MsgBox "Record Does Not Exists"
   bool = False
   Exit Sub
End If
End Sub
Private Sub cmdmodify_Click()
cmdfind_Click
Call clmod.enbt(Me)
txtvno.Enabled = False
ed1 = 0
End Sub
Private Sub cmdnew_Click()
Call clmod.clall(Me)
Dim a%
If venderrs.RecordCount = 0 Then
   a = 1
Else
   venderrs.MoveLast
   a = venderrs("vno") + 1
End If
txtvno = a
Call clmod.enbt(Me)
txtvno.Enabled = False
txtvname.SetFocus
ed1 = 1
End Sub
Private Sub cmdSAVE_Click()
Dim x%
x = clmod.nul(Me)
If x <> 1 Then Exit Sub
If ed1 = 1 Then
venderrs.AddNew
venrec
ElseIf ed1 = 0 Then
venrec
End If
End Sub
Private Sub Form_Load()
'Form7.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
ed1 = 0
End Sub
Private Sub txtvadd_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtvname_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Sub venrec()
venderrs("vno") = Trim(txtvno)
venderrs("vname") = Trim(txtvname)
venderrs("vaddr") = Trim(txtvadd)
venderrs.Update
MsgBox "updated"
Call clmod.enbf(Me)
End Sub
