VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form Deliveryv 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "View Delivery"
   ClientHeight    =   6345
   ClientLeft      =   45
   ClientTop       =   495
   ClientWidth     =   8520
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6345
   ScaleWidth      =   8520
   Begin VB.Frame Frame1 
      Height          =   5415
      Left            =   360
      TabIndex        =   1
      Top             =   720
      Width           =   7575
      Begin VB.CommandButton Command4 
         Caption         =   "Delete"
         Height          =   375
         Left            =   3840
         TabIndex        =   36
         Top             =   4920
         Width           =   1215
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Print"
         Height          =   375
         Left            =   1800
         TabIndex        =   35
         Top             =   4920
         Width           =   1095
      End
      Begin VB.TextBox Text1 
         Enabled         =   0   'False
         Height          =   375
         Left            =   1320
         TabIndex        =   19
         Top             =   360
         Width           =   1455
      End
      Begin VB.TextBox Text3 
         Enabled         =   0   'False
         Height          =   375
         Left            =   1320
         TabIndex        =   18
         Top             =   960
         Width           =   1455
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   1320
         TabIndex        =   17
         Top             =   1560
         Width           =   1455
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   1320
         TabIndex        =   16
         Top             =   2160
         Width           =   1455
      End
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   1320
         TabIndex        =   15
         Top             =   2760
         Width           =   1455
      End
      Begin VB.TextBox Text7 
         Height          =   375
         Left            =   1320
         TabIndex        =   14
         Top             =   3360
         Width           =   1455
      End
      Begin VB.TextBox Text8 
         Height          =   375
         Left            =   1320
         TabIndex        =   13
         Top             =   3960
         Width           =   1455
      End
      Begin VB.TextBox Text12 
         Enabled         =   0   'False
         Height          =   375
         Left            =   5640
         TabIndex        =   12
         Top             =   3000
         Width           =   1455
      End
      Begin VB.TextBox Text13 
         Enabled         =   0   'False
         Height          =   375
         Left            =   5640
         TabIndex        =   11
         Top             =   3600
         Width           =   1455
      End
      Begin VB.TextBox Text18 
         Enabled         =   0   'False
         Height          =   375
         Left            =   5640
         TabIndex        =   10
         Top             =   4200
         Width           =   1455
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Cancel"
         Height          =   375
         Left            =   6120
         TabIndex        =   9
         Top             =   4920
         Width           =   1215
      End
      Begin VB.Frame Frame2 
         Height          =   495
         Left            =   5280
         TabIndex        =   5
         Top             =   1920
         Width           =   2175
         Begin VB.OptionButton Option2 
            Caption         =   "Commercial"
            Height          =   255
            Left            =   1080
            TabIndex        =   7
            Top             =   120
            Width           =   1215
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Domestic"
            Height          =   255
            Left            =   120
            TabIndex        =   6
            Top             =   120
            Value           =   -1  'True
            Width           =   975
         End
      End
      Begin VB.ComboBox Combo1 
         Enabled         =   0   'False
         Height          =   315
         ItemData        =   "Vdelivery.frx":0000
         Left            =   5640
         List            =   "Vdelivery.frx":0022
         TabIndex        =   4
         Top             =   2520
         Width           =   735
      End
      Begin VB.TextBox Text2 
         Enabled         =   0   'False
         Height          =   375
         Left            =   5640
         TabIndex        =   2
         Top             =   240
         Width           =   1575
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
         Left            =   5640
         TabIndex        =   3
         Top             =   840
         Width           =   1575
         _ExtentX        =   2778
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16580609
         CurrentDate     =   40851
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
         Left            =   5640
         TabIndex        =   8
         Top             =   1440
         Width           =   1575
         _ExtentX        =   2778
         _ExtentY        =   661
         _Version        =   393216
         Format          =   16580609
         CurrentDate     =   40851
      End
      Begin VB.Label Label2 
         Caption         =   "Booking ID"
         Height          =   255
         Left            =   240
         TabIndex        =   34
         Top             =   360
         Width           =   975
      End
      Begin VB.Label Label3 
         Caption         =   "Consumer name"
         Height          =   375
         Left            =   120
         TabIndex        =   33
         Top             =   1560
         Width           =   1215
      End
      Begin VB.Label Label4 
         Caption         =   "Address Line1"
         Height          =   375
         Left            =   120
         TabIndex        =   32
         Top             =   2160
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "Address Line2"
         Height          =   375
         Left            =   120
         TabIndex        =   31
         Top             =   2760
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Pin Code"
         Height          =   255
         Left            =   360
         TabIndex        =   30
         Top             =   3480
         Width           =   735
      End
      Begin VB.Label Label7 
         Caption         =   "Phone"
         Height          =   375
         Left            =   240
         TabIndex        =   29
         Top             =   3960
         Width           =   975
      End
      Begin VB.Label Label8 
         Caption         =   "Consumer No"
         Height          =   375
         Left            =   120
         TabIndex        =   28
         Top             =   960
         Width           =   1095
      End
      Begin VB.Label Label9 
         Caption         =   "Date"
         Height          =   375
         Left            =   4680
         TabIndex        =   27
         Top             =   840
         Width           =   855
      End
      Begin VB.Label Label10 
         Caption         =   "Date of Booking"
         Height          =   375
         Left            =   4320
         TabIndex        =   26
         Top             =   1440
         Width           =   1215
      End
      Begin VB.Label Label11 
         Caption         =   "Cylinder Type"
         Height          =   375
         Left            =   3960
         TabIndex        =   25
         Top             =   2040
         Width           =   1215
      End
      Begin VB.Label Label12 
         Caption         =   "No: of Cylinders"
         Height          =   375
         Left            =   4320
         TabIndex        =   24
         Top             =   2520
         Width           =   1215
      End
      Begin VB.Label Label13 
         Caption         =   "Unit Price"
         Height          =   375
         Left            =   4680
         TabIndex        =   23
         Top             =   3000
         Width           =   855
      End
      Begin VB.Label Label14 
         Caption         =   "Total Price"
         Height          =   255
         Left            =   4560
         TabIndex        =   22
         Top             =   4320
         Width           =   855
      End
      Begin VB.Label Label15 
         Caption         =   "Tax 4 %"
         Height          =   255
         Left            =   4800
         TabIndex        =   21
         Top             =   3720
         Width           =   615
      End
      Begin VB.Label Label16 
         Caption         =   "Invoice No:"
         Height          =   375
         Left            =   4560
         TabIndex        =   20
         Top             =   240
         Width           =   975
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Delivery Invoice"
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
      Left            =   2760
      TabIndex        =   0
      Top             =   120
      Width           =   2895
   End
End
Attribute VB_Name = "Deliveryv"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Command1_Click()
DataReport1.Show
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command3_Click()
If (Text1.Text = "") Then
MsgBox "No Consumer", vbOKOnly, "Error"
Unload Me
Else
rs.Close
rs.Open "delivery", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = n) Then
Exit Do
End If
rs.MoveNext
Loop
rs(0) = Text2.Text
rs(1) = Text1.Text
rs(2) = DTPicker2.Value
rs(3) = Text3.Text
rs(4) = Combo1.Text
rs(5) = Text18.Text
rs.Update
MsgBox "Record Updated", vbOKOnly, "Update"
Unload Me
End If
End Sub

Private Sub Command4_Click()
If (Text1.Text = "") Then
MsgBox "No Consumer", vbOKOnly, "error"
Else
rs.Close
rs.Open "booking", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = Val(Text1.Text)) Then
rs(4) = "Not Delivered"
rs.Update
Exit Do
End If
rs.MoveNext
Loop
rs.Close
rs.Open "stock", cn, adOpenDynamic, adLockOptimistic
c = Val(Combo1.Text)
If (Option1.Value = True) Then
rs(0) = rs(0) + c
rs.Update
Else
rs(1) = rs(1) + c
rs.Update
End If
cn.Close
cn.Open
rs.Open "delivery", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = n) Then
rs.Delete
Exit Do
End If
rs.MoveNext
Loop
MsgBox "Record Deleted", vbOKOnly, "Delete"
End If
Unload Me
End Sub

Private Sub Form_Load()
cn.Open "gas"
rs.Open "delivery", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
Do Until rs.EOF
If (rs(0) = n) Then
Text2.Text = rs(0)
Text1.Text = rs(1)
Text3.Text = rs(3)
DTPicker2.Value = rs(2)
Combo1.Text = rs(4)
Exit Do
End If
rs.MoveNext
Loop
rs.Close
rs.Open "booking", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "No booking exits", vbOKOnly, "Error"
Else
rs.MoveFirst
End If
b = Val(Text1.Text)
Do Until rs.EOF
If (rs(0) = b) Then
Text1.Text = rs(0)
Text3.Text = rs(1)
DTPicker1.Value = rs(2)
Combo1.Text = rs(3)
Exit Do
End If
rs.MoveNext
Loop
rs.Close
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
a = Val(Text3.Text)
Do Until rs.EOF
If (rs(0) = a) Then
Text4.Text = rs(1) + " " + rs(2)
Text5.Text = rs(3)
Text6.Text = rs(4)
Text7.Text = rs(5)
Text8.Text = rs(6)
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
rs.Open "rate", cn, adOpenDynamic, adLockOptimistic
rs.MoveFirst
c = Val(Combo1.Text)
If (Option2.Value = True) Then
Text12.Text = rs(1)
Else
Text12.Text = rs(0)
End If
Text13.Text = (Val(Text12) * 4) / 100
Text18.Text = (Val(Text12.Text) + Val(Text13.Text)) * c
End Sub

Private Sub Form_Unload(Cancel As Integer)
rs.Close
cn.Close
End Sub
