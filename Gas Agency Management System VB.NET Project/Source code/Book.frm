VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form Booking 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Book"
   ClientHeight    =   6480
   ClientLeft      =   4500
   ClientTop       =   4080
   ClientWidth     =   8580
   LinkTopic       =   "Form5"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6480
   ScaleWidth      =   8580
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   6120
      Top             =   120
   End
   Begin VB.Frame Frame1 
      Height          =   5415
      Left            =   360
      TabIndex        =   1
      Top             =   840
      Width           =   7935
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   5640
         TabIndex        =   26
         Top             =   360
         Width           =   2055
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         ItemData        =   "Book.frx":0000
         Left            =   5760
         List            =   "Book.frx":0022
         TabIndex        =   25
         Text            =   "1"
         Top             =   3240
         Width           =   735
      End
      Begin VB.Frame Frame2 
         Height          =   495
         Left            =   5280
         TabIndex        =   22
         Top             =   2520
         Width           =   2535
         Begin VB.OptionButton Option1 
            Caption         =   "Domestic"
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   120
            Value           =   -1  'True
            Width           =   1095
         End
         Begin VB.OptionButton Option2 
            Caption         =   "Commercial"
            Height          =   255
            Left            =   1200
            TabIndex        =   23
            Top             =   120
            Width           =   1215
         End
      End
      Begin MSComCtl2.DTPicker DTPicker2 
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "dd.MM.yyyy"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   3
         EndProperty
         Height          =   375
         Left            =   5760
         TabIndex        =   21
         Top             =   1800
         Width           =   1935
         _ExtentX        =   3413
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16646145
         CurrentDate     =   36526
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "dd.MM.yyyy"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   3
         EndProperty
         Height          =   375
         Left            =   5760
         TabIndex        =   20
         Top             =   1080
         Width           =   1935
         _ExtentX        =   3413
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16646145
         CurrentDate     =   40851
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   3840
         TabIndex        =   19
         Top             =   4800
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Book"
         Height          =   495
         Left            =   1800
         TabIndex        =   18
         Top             =   4800
         Width           =   1215
      End
      Begin VB.TextBox Text10 
         Height          =   495
         Left            =   1440
         TabIndex        =   17
         Top             =   4080
         Width           =   1815
      End
      Begin VB.TextBox Text9 
         Height          =   495
         Left            =   1440
         TabIndex        =   16
         Top             =   3360
         Width           =   1815
      End
      Begin VB.TextBox Text8 
         Height          =   495
         Left            =   1440
         TabIndex        =   15
         Top             =   2640
         Width           =   1815
      End
      Begin VB.TextBox Text7 
         Height          =   495
         Left            =   1440
         TabIndex        =   14
         Top             =   1920
         Width           =   1815
      End
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   1440
         TabIndex        =   13
         Top             =   1200
         Width           =   1815
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   1440
         TabIndex        =   12
         Top             =   360
         Width           =   1815
      End
      Begin VB.Label Label12 
         Caption         =   "Book ID"
         Height          =   255
         Left            =   4680
         TabIndex        =   27
         Top             =   480
         Width           =   735
      End
      Begin VB.Label Label11 
         Caption         =   "Last Booking"
         Height          =   375
         Left            =   4320
         TabIndex        =   11
         Top             =   1920
         Width           =   1095
      End
      Begin VB.Label Label10 
         Caption         =   "No of Cylinder"
         Height          =   375
         Left            =   4320
         TabIndex        =   10
         Top             =   3360
         Width           =   1095
      End
      Begin VB.Label Label9 
         Caption         =   "Cylinder Type"
         Height          =   255
         Left            =   4320
         TabIndex        =   9
         Top             =   2760
         Width           =   975
      End
      Begin VB.Label Label8 
         Caption         =   "Date"
         Height          =   375
         Left            =   4560
         TabIndex        =   8
         Top             =   1200
         Width           =   855
      End
      Begin VB.Label Label7 
         Caption         =   "Phone"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   4200
         Width           =   615
      End
      Begin VB.Label Label6 
         Caption         =   "City"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   3480
         Width           =   495
      End
      Begin VB.Label Label5 
         Caption         =   "Address Line2"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   2760
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "Address Line1"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   2040
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "Consumer Name"
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Label2 
         Caption         =   "Consumer No:"
         Height          =   375
         Left            =   120
         TabIndex        =   2
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Booking"
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
      Left            =   3240
      TabIndex        =   0
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "Booking"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Command1_Click()
If (Option1.Value = True) And (Val(Combo1.Text) > 1) Then
MsgBox "Domestic consumers cannot book more than 1 cylinder", vbOKOnly, "Error"
Else
d = DateDiff("d", DTPicker2.Value, DTPicker1.Value)
If (Option2.Value = True) Then
d = 50
End If
If (d <= 45) Then
MsgBox "Last delivery less than 45days", vbOKOnly, "Error"
Else
If (Text1.Text = "") Then
MsgBox "No Consumer", vbOKOnly, "Error"
Else
rs.AddNew
rs(0) = Val(Text1.Text)
rs(1) = Val(Text5.Text)
rs(2) = DTPicker1.Value
rs(3) = Combo1.Text
rs(4) = "Not delivered"
rs.Update
rs.Close
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
Do Until rs.EOF
If (rs(0) = Val(Text5.Text)) Then
rs(8) = DTPicker1.Value
rs.Update
Exit Do
End If
rs.MoveNext
Loop
MsgBox "Booking entered", vbOKOnly, "Saved"
Unload Me
End If
End If
End If
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = n) Then
Text5.Text = rs(0)
Text5.Enabled = False
Text6.Text = rs(1)
Text6.Text = Text6.Text + " " + rs(2)
Text7.Text = rs(3)
Text8.Text = rs(4)
Text9.Text = rs(5)
Text10.Text = rs(6)
If (rs(8) = "No") Then
Label11.Enabled = False
Else
DTPicker2.Value = rs(8)
End If
DTPicker2.Enabled = False
If (rs(9) = "Commercial") Then
Option2.Value = True
Option1.Enabled = False
Else
Option2.Enabled = False
End If
Exit Do
End If
rs.MoveNext
Loop
rs.Close
rs.Open "booking", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
Text1.Text = 1
Else
rs.MoveLast
Text1.Text = rs(0) + 1
End If
Text1.Enabled = fale
DTPicker1.Value = Date
End Sub


Private Sub Text2_KeyUp(KeyCode As Integer, Shift As Integer)
If (KeyCode > 47 And KeyCode < 58) Or (KeyCode > 95 And KeyCode < 112) Or (KeyCode > 185 And KeyCode < 193 Or (KeyCode > 218 And KeyCode < 223)) Then
MsgBox "Invalid entry, field support only alphabets", vbOKOnly, "Error"
Text2.Text = ""
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
cn.Close
End Sub
