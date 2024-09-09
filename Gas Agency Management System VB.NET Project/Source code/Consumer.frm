VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form Consumers 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Consumer Entry"
   ClientHeight    =   5880
   ClientLeft      =   5325
   ClientTop       =   4080
   ClientWidth     =   8175
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5880
   ScaleWidth      =   8175
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   6120
      Top             =   480
   End
   Begin VB.Frame Frame1 
      Height          =   4335
      Left            =   240
      TabIndex        =   1
      Top             =   1200
      Width           =   7575
      Begin VB.Frame Frame2 
         Height          =   495
         Left            =   5040
         TabIndex        =   20
         Top             =   2040
         Width           =   2415
         Begin VB.OptionButton Option2 
            Caption         =   "Commercial"
            Height          =   255
            Left            =   1080
            TabIndex        =   22
            Top             =   120
            Width           =   1215
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Domestic"
            Height          =   255
            Left            =   120
            TabIndex        =   21
            Top             =   120
            Value           =   -1  'True
            Width           =   1095
         End
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   4440
         TabIndex        =   19
         Top             =   3480
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Add"
         Height          =   495
         Left            =   1200
         TabIndex        =   18
         Top             =   3480
         Width           =   1455
      End
      Begin VB.TextBox Text7 
         Height          =   375
         Left            =   5040
         MaxLength       =   11
         TabIndex        =   16
         Top             =   960
         Width           =   2175
      End
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   5040
         MaxLength       =   6
         TabIndex        =   15
         Top             =   360
         Width           =   2175
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   1440
         MaxLength       =   49
         TabIndex        =   14
         Top             =   2760
         Width           =   1695
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   1440
         MaxLength       =   49
         TabIndex        =   13
         Top             =   2160
         Width           =   1695
      End
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   1440
         MaxLength       =   19
         TabIndex        =   12
         Top             =   1560
         Width           =   1695
      End
      Begin VB.TextBox Text2 
         BeginProperty DataFormat 
            Type            =   1
            Format          =   """ABCDEFGHIJKLMNOPQRSTUVXYZ"" ""abcdefghijklmnopqrstuvxyz"""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
         Height          =   375
         Left            =   1440
         MaxLength       =   19
         TabIndex        =   11
         Top             =   960
         Width           =   1695
      End
      Begin VB.TextBox Text1 
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "0"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   1
         EndProperty
         Height          =   375
         Left            =   1440
         MaxLength       =   6
         TabIndex        =   10
         Top             =   360
         Width           =   1695
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "M/d/yyyy"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   3
         EndProperty
         Height          =   375
         Left            =   5040
         TabIndex        =   23
         Top             =   1560
         Width           =   2175
         _ExtentX        =   3836
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16580609
         CurrentDate     =   40851
      End
      Begin VB.Label Label11 
         Caption         =   "Last Name"
         Height          =   255
         Left            =   240
         TabIndex        =   17
         Top             =   1680
         Width           =   855
      End
      Begin VB.Label Label9 
         Caption         =   "Cylinder Type"
         Height          =   255
         Left            =   3600
         TabIndex        =   9
         Top             =   2160
         Width           =   975
      End
      Begin VB.Label Label8 
         Caption         =   "Date of Connection"
         Height          =   255
         Left            =   3480
         TabIndex        =   8
         Top             =   1680
         Width           =   1455
      End
      Begin VB.Label Label7 
         Caption         =   "Pin Code"
         Height          =   255
         Left            =   3480
         TabIndex        =   7
         Top             =   480
         Width           =   735
      End
      Begin VB.Label Label6 
         Caption         =   "Phone"
         Height          =   255
         Left            =   3480
         TabIndex        =   6
         Top             =   1080
         Width           =   615
      End
      Begin VB.Label Label5 
         Caption         =   "Address Line2"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   2880
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "Address Line1"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   2280
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "First Name"
         Height          =   255
         Left            =   240
         TabIndex        =   3
         Top             =   1080
         Width           =   975
      End
      Begin VB.Label Label2 
         Caption         =   "Consumer No:"
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Consumer Entry"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2520
      TabIndex        =   0
      Top             =   240
      Width           =   2895
   End
End
Attribute VB_Name = "Consumers"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset


Private Sub Command1_Click()
If (Text2.Text = "" Or Text3.Text = "" Or Text4.Text = "" Or Text6.Text = "" Or Text7.Text = "") Then
MsgBox "Enter all fields", vbOKOnly, "Error"
Else
rs.AddNew
rs(0) = Text1.Text
rs(1) = Text2.Text
rs(2) = Text3.Text
rs(3) = Text4.Text
rs(4) = Text5.Text
rs(5) = Text6.Text
rs(6) = Text7.Text
rs(7) = DTPicker1.Value
rs(8) = "No"
If Option1.Value = True Then
rs(9) = Option1.Caption
Else
rs(9) = Option2.Caption
End If
rs(10) = "Active"
rs.Update
a = Val(Text1.Text)
clear
MsgBox "Consumer entered", vbOKOnly, "Saved"
Unload Me
End If
End Sub
Public Sub clear()
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
Text4.Text = ""
Text5.Text = ""
Text6.Text = ""
Text7.Text = ""
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
Text1.Text = 1
Else
rs.MoveLast
Text1.Text = rs(0) + 1
End If
Text1.Enabled = False
DTPicker1.Value = Date
End Sub


Private Sub Form_Unload(Cancel As Integer)
rs.Close
cn.Close
End Sub



Private Sub Text2_KeyUp(KeyCode As Integer, Shift As Integer)
If (KeyCode = 190 Or KeyCode = 110) Then
Else
If (KeyCode > 47 And KeyCode < 58) Or (KeyCode > 95 And KeyCode < 112) Or (KeyCode > 185 And KeyCode < 193 Or (KeyCode > 218 And KeyCode < 223)) Then
MsgBox "Invalid entry, field support only alphabets", vbOKOnly, "Error"
Text2.Text = ""
End If
End If
End Sub



Private Sub Text3_KeyUp(KeyCode As Integer, Shift As Integer)
If (KeyCode = 190 Or KeyCode = 110) Then
Else
If (KeyCode > 47 And KeyCode < 58) Or (KeyCode > 95 And KeyCode < 112) Or (KeyCode > 185 And KeyCode < 193 Or (KeyCode > 218 And KeyCode < 223)) Then
MsgBox "Invalid entry, field support only alphabets", vbOKOnly, "Error"
Text3.Text = ""
End If
End If
End Sub




Private Sub Text6_KeyUp(KeyCode As Integer, Shift As Integer)
If (KeyCode > 63 And KeyCode < 91) Or (KeyCode > 105 And KeyCode < 112) Or (KeyCode > 185 And KeyCode < 193 Or (KeyCode > 218 And KeyCode < 223)) Then
MsgBox "Invalid entry, field support only numbers", vbOKOnly, "Error"
Text6.Text = ""
End If
End Sub

Private Sub Text7_KeyUp(KeyCode As Integer, Shift As Integer)
If (KeyCode > 63 And KeyCode < 91) Or (KeyCode > 105 And KeyCode < 112) Or (KeyCode > 185 And KeyCode < 193 Or (KeyCode > 218 And KeyCode < 223)) Then
MsgBox "Invalid entry, field support only numbers", vbOKOnly, "Error"
Text7.Text = ""
End If
End Sub
