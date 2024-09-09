VERSION 5.00
Begin VB.Form Form5 
   BackColor       =   &H00FF8080&
   Caption         =   "Indian Gas Service"
   ClientHeight    =   7830
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11850
   ControlBox      =   0   'False
   LinkTopic       =   "Form5"
   ScaleHeight     =   7830
   ScaleWidth      =   11850
   WhatsThisHelp   =   -1  'True
   WindowState     =   2  'Maximized
   Begin VB.CommandButton cmdfind 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Find"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   3720
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   5760
      Width           =   1935
   End
   Begin VB.TextBox phone 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3960
      TabIndex        =   5
      Top             =   4560
      Width           =   1815
   End
   Begin VB.TextBox address 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3960
      TabIndex        =   4
      Top             =   4080
      Width           =   4215
   End
   Begin VB.TextBox cname 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3960
      TabIndex        =   9
      Top             =   3600
      Width           =   3015
   End
   Begin VB.TextBox bookdate 
      Enabled         =   0   'False
      Height          =   285
      Left            =   7800
      TabIndex        =   2
      Top             =   3000
      Width           =   1215
   End
   Begin VB.CommandButton cmdbook 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Book"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   6120
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   5760
      Width           =   1935
   End
   Begin VB.CommandButton cmdcancel 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Back "
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   8520
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   5760
      Width           =   1935
   End
   Begin VB.TextBox cno 
      Height          =   285
      Left            =   2400
      TabIndex        =   1
      Top             =   3000
      Width           =   1215
   End
   Begin VB.Label Label16 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Refill Booking"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   435
      Left            =   4200
      TabIndex        =   19
      Top             =   1920
      Width           =   2475
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   615
      Left            =   1440
      Top             =   1920
      Width           =   9135
   End
   Begin VB.Label Label15 
      BackStyle       =   0  'Transparent
      Caption         =   "260 Rs/-"
      Height          =   255
      Left            =   6720
      TabIndex        =   18
      Top             =   5040
      Width           =   2775
   End
   Begin VB.Label Label14 
      BackStyle       =   0  'Transparent
      Caption         =   "Refill Charges"
      Height          =   255
      Left            =   2400
      TabIndex        =   17
      Top             =   5040
      Width           =   1935
   End
   Begin VB.Label Label12 
      BackStyle       =   0  'Transparent
      Caption         =   "Phone"
      Height          =   255
      Left            =   2400
      TabIndex        =   16
      Top             =   4560
      Width           =   1455
   End
   Begin VB.Label Label11 
      BackStyle       =   0  'Transparent
      Caption         =   "  2200777"
      Height          =   255
      Left            =   9480
      TabIndex        =   15
      Top             =   1320
      Width           =   975
   End
   Begin VB.Label Label10 
      BackStyle       =   0  'Transparent
      Caption         =   "Ph .   :  2200666"
      Height          =   375
      Left            =   9000
      TabIndex        =   14
      Top             =   1080
      Width           =   1335
   End
   Begin VB.Line Line2 
      X1              =   6600
      X2              =   6600
      Y1              =   4920
      Y2              =   5400
   End
   Begin VB.Line Line1 
      X1              =   1440
      X2              =   10560
      Y1              =   4920
      Y2              =   4920
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Dated"
      Height          =   375
      Left            =   6960
      TabIndex        =   13
      Top             =   3000
      Width           =   855
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Address"
      Height          =   255
      Left            =   2400
      TabIndex        =   12
      Top             =   4080
      Width           =   2295
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Consumer Name"
      Height          =   255
      Left            =   2400
      TabIndex        =   11
      Top             =   3600
      Width           =   2055
   End
   Begin VB.Label Label2 
      BackColor       =   &H80000004&
      BackStyle       =   0  'Transparent
      Caption         =   "C.No"
      Height          =   375
      Left            =   1680
      TabIndex        =   10
      Top             =   3000
      Width           =   615
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "INDIAN GAS SERVICES"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   555
      Left            =   3000
      TabIndex        =   0
      Top             =   1080
      Width           =   5475
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      BorderStyle     =   1  'Fixed Single
      Caption         =   "INDIAN GAS SERVICES"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   555
      Left            =   3000
      TabIndex        =   3
      Top             =   1080
      Width           =   5475
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   4575
      Left            =   1440
      Top             =   840
      Width           =   9135
   End
End
Attribute VB_Name = "Form5"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim b As String
Private Sub cmdbook_Click()
Set con = New Connection
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With
If cno.Text = "" Then
MsgBox " Find record "
cno.SetFocus
Exit Sub
End If

If cname.Text = "" Then
MsgBox " Find record "
cno.SetFocus
Exit Sub
End If
sql = "insert into refill(consumer_no,bookdate)values(" & CInt(Trim(cno.Text)) & ",'" & bookdate.Text & "')"

con.BeginTrans
con.Execute (sql)
con.CommitTrans
'Command1.Enabled = False

cno.Text = ""
cname.Text = ""
address.Text = ""
phone.Text = ""
bookdate.Text = ""
End Sub

Private Sub Cmdcancel_Click()
Load Form1
Form1.Show
Unload Me
End Sub

Private Sub Cmdfind_Click()
Set con = New Connection
Set rst = New Recordset
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With

If charcheck(b) = 0 Then
    MsgBox "No Record found........"
    cno.SetFocus
    Exit Sub
End If


If cno.Text = "" Then
MsgBox " Enter consumer no"
cno.SetFocus
Exit Sub
End If




Set rst = New Recordset
rst.Open "select *  from consumer_details where consumer_details.consumer_no=" & CInt(cno.Text), con
If rst.EOF = True And rst.BOF = True Then
    MsgBox "No records.................."
    cno.SetFocus
    Exit Sub
End If


If rst.EOF = True Then
cname = rst!c_name
address.Text = rst!address
phone.Text = rst!phone
bookdate.Text = Date
Else
cname = rst!c_name
address.Text = rst!address
phone.Text = rst!phone
bookdate.Text = Date
End If

End Sub

Private Sub Command7_Click()

End Sub

Private Sub cno_LostFocus()
b = cno.Text
End Sub
