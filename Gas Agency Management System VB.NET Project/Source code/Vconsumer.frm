VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form ConsumerV 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Consumer View"
   ClientHeight    =   6045
   ClientLeft      =   45
   ClientTop       =   495
   ClientWidth     =   8670
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6045
   ScaleWidth      =   8670
   Begin VB.Frame Frame1 
      Height          =   4335
      Left            =   360
      TabIndex        =   0
      Top             =   1200
      Width           =   7935
      Begin MSComCtl2.DTPicker DTPicker2 
         Height          =   375
         Left            =   5400
         TabIndex        =   25
         Top             =   2160
         Width           =   1935
         _ExtentX        =   3413
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16449537
         CurrentDate     =   40855
      End
      Begin VB.Frame Frame2 
         Height          =   495
         Left            =   5280
         TabIndex        =   22
         Top             =   2640
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
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   5400
         MaxLength       =   6
         TabIndex        =   20
         Top             =   360
         Width           =   1935
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
         Left            =   5400
         TabIndex        =   19
         Top             =   1560
         Width           =   1935
         _ExtentX        =   3413
         _ExtentY        =   661
         _Version        =   393216
         CustomFormat    =   "dd.MM.yyyy"
         Format          =   16449537
         CurrentDate     =   40851
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Delete"
         Height          =   495
         Left            =   3000
         TabIndex        =   18
         Top             =   3480
         Width           =   1215
      End
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   1440
         TabIndex        =   8
         Top             =   360
         Width           =   1695
      End
      Begin VB.TextBox Text2 
         Height          =   375
         Left            =   1440
         MaxLength       =   19
         TabIndex        =   7
         Top             =   960
         Width           =   1695
      End
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   1440
         MaxLength       =   19
         TabIndex        =   6
         Top             =   1560
         Width           =   1695
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   1440
         MaxLength       =   49
         TabIndex        =   5
         Top             =   2160
         Width           =   1695
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   1440
         MaxLength       =   49
         TabIndex        =   4
         Top             =   2760
         Width           =   1695
      End
      Begin VB.TextBox Text7 
         Height          =   375
         Left            =   5400
         MaxLength       =   11
         TabIndex        =   3
         Top             =   960
         Width           =   1935
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Update"
         Height          =   495
         Left            =   1200
         TabIndex        =   2
         Top             =   3480
         Width           =   1455
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   4440
         TabIndex        =   1
         Top             =   3480
         Width           =   1335
      End
      Begin VB.Label Label1 
         Caption         =   "Last Booking"
         Height          =   375
         Left            =   4200
         TabIndex        =   26
         Top             =   2160
         Width           =   975
      End
      Begin VB.Label Label7 
         Caption         =   "Pin"
         Height          =   255
         Left            =   4800
         TabIndex        =   21
         Top             =   480
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "Consumer No:"
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   480
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "First Name"
         Height          =   255
         Left            =   240
         TabIndex        =   15
         Top             =   1080
         Width           =   975
      End
      Begin VB.Label Label4 
         Caption         =   "Address Line1"
         Height          =   255
         Left            =   120
         TabIndex        =   14
         Top             =   2280
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "Address Line2"
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   2880
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Phone"
         Height          =   255
         Left            =   4560
         TabIndex        =   12
         Top             =   1080
         Width           =   615
      End
      Begin VB.Label Label8 
         Caption         =   "Date of Connection"
         Height          =   255
         Left            =   3840
         TabIndex        =   11
         Top             =   1560
         Width           =   1455
      End
      Begin VB.Label Label9 
         Caption         =   "Cylinder Type"
         Height          =   255
         Left            =   4200
         TabIndex        =   10
         Top             =   2760
         Width           =   975
      End
      Begin VB.Label Label11 
         Caption         =   "Last Name"
         Height          =   255
         Left            =   240
         TabIndex        =   9
         Top             =   1680
         Width           =   855
      End
   End
   Begin VB.Label Vconsumer 
      Caption         =   "Consumer"
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
      TabIndex        =   17
      Top             =   480
      Width           =   1935
   End
End
Attribute VB_Name = "ConsumerV"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Command1_Click()
If (Text1.Text = "" Or Text2.Text = "" Or Text3.Text = "" Or Text4.Text = "" Or Text5.Text = "" Or Text6.Text = "" Or Text7.Text = "") Then
MsgBox "Enter all Fields", vbOKOnly, "Error"
Else
rs(0) = Text1.Text
rs(1) = Text2.Text
rs(2) = Text3.Text
rs(3) = Text4.Text
rs(4) = Text5.Text
rs(5) = Text6.Text
rs(6) = Text7.Text
rs(7) = DTPicker1.Value
If Option1.Value = True Then
rs(9) = Option1.Caption
Else
rs(9) = Option2.Caption
End If
rs.Update
MsgBox "Record updated Sucessfully", vbOKOnly, "Update"
End If
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command3_Click()
If (Text1.Text = "") Then
MsgBox "No Consumer", vbOKOnly, "Error"
Else
rs(10) = "Deleted"
rs.Update
MsgBox "Consumer deleted", vbOKOnly, "Delete"
Unload Me
End If
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = n) Then
Text1.Text = rs(0)
Text2.Text = rs(1)
Text3.Text = rs(2)
Text4.Text = rs(3)
Text5.Text = rs(4)
Text6.Text = rs(5)
Text7.Text = rs(6)
DTPicker1.Value = rs(7)
If (rs(8) = "No") Then
Label11.Enabled = False
Else
DTPicker2.Value = rs(8)
End If
If (rs(9) = "Commercial") Then
Option2.Value = True
End If
Exit Do
End If
rs.MoveNext
Loop
Text1.Enabled = False
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

Private Sub Form_Unload(Cancel As Integer)

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
