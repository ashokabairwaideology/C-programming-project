VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form Vbook 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View Booking"
   ClientHeight    =   7260
   ClientLeft      =   45
   ClientTop       =   495
   ClientWidth     =   8985
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   7260
   ScaleWidth      =   8985
   Begin VB.Frame Frame1 
      Height          =   5415
      Left            =   360
      TabIndex        =   0
      Top             =   1200
      Width           =   8175
      Begin VB.TextBox Text2 
         Enabled         =   0   'False
         Height          =   375
         Left            =   5520
         TabIndex        =   29
         Top             =   3960
         Width           =   2175
      End
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   5640
         TabIndex        =   27
         Top             =   360
         Width           =   1935
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         ItemData        =   "Vbook.frx":0000
         Left            =   5520
         List            =   "Vbook.frx":0022
         TabIndex        =   26
         Top             =   3240
         Width           =   735
      End
      Begin VB.Frame Frame2 
         Height          =   495
         Left            =   5520
         TabIndex        =   23
         Top             =   2520
         Width           =   2295
         Begin VB.OptionButton Option1 
            Caption         =   "Domestic"
            Height          =   255
            Left            =   120
            TabIndex        =   25
            Top             =   120
            Value           =   -1  'True
            Width           =   975
         End
         Begin VB.OptionButton Option2 
            Caption         =   "Commercial"
            Height          =   255
            Left            =   1080
            TabIndex        =   24
            Top             =   120
            Width           =   1215
         End
      End
      Begin MSComCtl2.DTPicker DTPicker2 
         Height          =   375
         Left            =   5640
         TabIndex        =   22
         Top             =   1800
         Width           =   1935
         _ExtentX        =   3413
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16580609
         CurrentDate     =   40851
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         Height          =   375
         Left            =   5640
         TabIndex        =   21
         Top             =   1080
         Width           =   1935
         _ExtentX        =   3413
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16580609
         CurrentDate     =   40851
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Cancel Booking"
         Height          =   495
         Left            =   3240
         TabIndex        =   20
         Top             =   4800
         Width           =   1575
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   1440
         TabIndex        =   8
         Top             =   360
         Width           =   1815
      End
      Begin VB.TextBox Text6 
         Height          =   495
         Left            =   1440
         TabIndex        =   7
         Top             =   1200
         Width           =   1815
      End
      Begin VB.TextBox Text7 
         Height          =   495
         Left            =   1440
         TabIndex        =   6
         Top             =   1920
         Width           =   1815
      End
      Begin VB.TextBox Text8 
         Height          =   495
         Left            =   1440
         TabIndex        =   5
         Top             =   2640
         Width           =   1815
      End
      Begin VB.TextBox Text9 
         Height          =   495
         Left            =   1440
         TabIndex        =   4
         Top             =   3360
         Width           =   1815
      End
      Begin VB.TextBox Text10 
         Height          =   495
         Left            =   1440
         TabIndex        =   3
         Top             =   4080
         Width           =   1815
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Update"
         Height          =   495
         Left            =   1680
         TabIndex        =   2
         Top             =   4800
         Width           =   1215
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   495
         Left            =   5040
         TabIndex        =   1
         Top             =   4800
         Width           =   1335
      End
      Begin VB.Label Label13 
         Caption         =   "Delivery Status"
         Height          =   375
         Left            =   4320
         TabIndex        =   30
         Top             =   3960
         Width           =   1095
      End
      Begin VB.Label Label12 
         Caption         =   "Book ID"
         Height          =   255
         Left            =   4800
         TabIndex        =   28
         Top             =   480
         Width           =   735
      End
      Begin VB.Label Label2 
         Caption         =   "Consumer No:"
         Height          =   375
         Left            =   120
         TabIndex        =   18
         Top             =   480
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "Consumer Name"
         Height          =   255
         Left            =   120
         TabIndex        =   17
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Label4 
         Caption         =   "Address Line1"
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   2040
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "Address Line2"
         Height          =   255
         Left            =   120
         TabIndex        =   15
         Top             =   2760
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Pin"
         Height          =   255
         Left            =   720
         TabIndex        =   14
         Top             =   3480
         Width           =   495
      End
      Begin VB.Label Label7 
         Caption         =   "Phone"
         Height          =   255
         Left            =   600
         TabIndex        =   13
         Top             =   4200
         Width           =   615
      End
      Begin VB.Label Label8 
         Caption         =   "Date"
         Height          =   375
         Left            =   4920
         TabIndex        =   12
         Top             =   1080
         Width           =   495
      End
      Begin VB.Label Label9 
         Caption         =   "Cylinder Type"
         Height          =   255
         Left            =   4440
         TabIndex        =   11
         Top             =   2640
         Width           =   975
      End
      Begin VB.Label Label10 
         Caption         =   "No of Cylinder"
         Height          =   375
         Left            =   4440
         TabIndex        =   10
         Top             =   3240
         Width           =   1095
      End
      Begin VB.Label Label11 
         Caption         =   "Last Delivery"
         Height          =   375
         Left            =   4440
         TabIndex        =   9
         Top             =   1800
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
      Left            =   3120
      TabIndex        =   19
      Top             =   360
      Width           =   1455
   End
End
Attribute VB_Name = "Vbook"
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
If (Text1.Text = "") Then
MsgBox "Enter all fileds", vbOKOnly, "Error"
Else
rs(0) = Text1.Text
rs(2) = DTPicker1.Value
rs(3) = Combo1.Text
rs.Update
MsgBox "Booking updated Sucessfully", vbOKOnly, "Booking"
End If
End If
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command3_Click()
If (Text1.Text = "") Then
MsgBox "No Consumer", vbOKOnly, "Error"
Else
rs.Close
rs.Open "booking", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = n) Then
rs(4) = "Canceled"
rs.Update
Exit Do
End If
rs.MoveNext
Loop
If (Option1.Enabled = True) Then
rs.Close
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
n = Val(Text5.Text)
Do Until rs.EOF
If (rs(0) = n) Then
rs(8) = "11/11/2005"
rs.Update
Exit Do
End If
rs.MoveNext
Loop
End If
MsgBox "Booking canceled", vbOKOnly, "Cancel"
End If
Unload Me
End Sub
Public Sub clear()
Text1.Text = ""
Text5.Text = ""
Text6.Text = ""
Text7.Text = ""
Text8.Text = ""
Text9.Text = ""
Text10.Text = ""
Combo1.Text = ""
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "booking", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = n) Then
Text1.Text = rs(0)
Text5.Text = rs(1)
DTPicker1.Value = rs(2)
Text2.Text = rs(4)
If (rs(4) = "Delivered") Then
Command3.Enabled = False
End If
Combo1.Text = rs(3)
Exit Do
End If
rs.MoveNext
Loop
If rs.EOF Then
MsgBox ("Sorry")
rs.MoveFirst
End If
rs.Close
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
a = Val(Text5.Text)
Do Until rs.EOF
If (rs(0) = a) Then
Text6.Text = rs(1) + " " + rs(2)
Text7.Text = rs(3)
Text8.Text = rs(4)
Text9.Text = rs(5)
Text10.Text = rs(6)
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
Text5.Enabled = False
Text1.Enabled = False
End Sub



Private Sub Form_Unload(Cancel As Integer)
cn.Close
End Sub
