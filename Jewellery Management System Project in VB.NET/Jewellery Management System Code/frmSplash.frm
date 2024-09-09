VERSION 5.00
Begin VB.Form frmSplash 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   7755
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   8265
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "frmSplash.frx":0000
   ScaleHeight     =   7755
   ScaleWidth      =   8265
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txt_dbPassword 
      DataField       =   "password"
      DataSource      =   "Data1"
      Height          =   285
      Left            =   3000
      TabIndex        =   2
      Top             =   7080
      Width           =   2295
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   480
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   7080
      Visible         =   0   'False
      Width           =   2415
   End
   Begin VB.Timer Timer1 
      Interval        =   200
      Left            =   480
      Top             =   6000
   End
   Begin VB.TextBox txt_Password 
      Alignment       =   2  'Center
      BackColor       =   &H80000004&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Wingdings"
         Size            =   12
         Charset         =   2
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00A88637&
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   1200
      PasswordChar    =   "l"
      TabIndex        =   1
      Top             =   3360
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Press Esc to terminate system."
      Height          =   195
      Left            =   120
      TabIndex        =   4
      Top             =   5040
      Width           =   2145
   End
   Begin VB.Label lbl_EnterPassword 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "Enter Password"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   195
      Left            =   1200
      TabIndex        =   3
      Top             =   3120
      Visible         =   0   'False
      Width           =   1320
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Loading"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   1200
      TabIndex        =   0
      Top             =   3360
      Width           =   750
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim a As Integer
Dim counter

Private Sub Form_KeyPress(KeyAscii As Integer)
If KeyAscii = 27 Then
    End
End If
End Sub

Private Sub Form_Load()
frmSplash.Width = 8190
frmSplash.Height = 5385
a = 1
counter = 0

Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblPassword"
Data1.Refresh

End Sub

Private Sub Text1_Change()

End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)

End Sub

Private Sub Timer1_Timer()

Label1.Caption = Label1.Caption & "."
a = a + 1
If a = 7 Then
    Timer1.Enabled = False
    Label1.Visible = False
    txt_Password.Visible = True
    txt_Password.SetFocus
    lbl_EnterPassword.Visible = True
End If
End Sub

Private Sub txt_Password_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then
    If UCase(txt_Password) = UCase(txt_dbPassword) Then
        Unload Me
        CMJ_Main.Enabled = True
        'unlock database here
    Else
        MsgBox "Invalid password.", vbExclamation
        txt_Password.SetFocus
        SendKeys "{home}" & "+{end}"
        counter = counter + 1
        If counter = 3 Then
            MsgBox "You have reached the maximum tries to enter your password." & Chr(13) & _
                "System is terminating.", vbExclamation
            End
        End If
    End If
End If
If KeyAscii = 27 Then
    End
End If
End Sub
