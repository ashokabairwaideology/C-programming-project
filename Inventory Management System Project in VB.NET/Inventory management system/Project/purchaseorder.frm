VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form Form9 
   Caption         =   "Form9"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   LinkTopic       =   "Form9"
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.TextBox Text3 
      Height          =   495
      Left            =   3000
      TabIndex        =   28
      Text            =   "Text3"
      Top             =   4440
      Width           =   1935
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   3000
      TabIndex        =   27
      Text            =   "Text2"
      Top             =   3960
      Width           =   1575
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   3000
      TabIndex        =   26
      Text            =   "Text1"
      Top             =   3360
      Width           =   1455
   End
   Begin VB.CommandButton cmdsave 
      Caption         =   "&Save"
      Height          =   375
      Index           =   1
      Left            =   7200
      TabIndex        =   25
      Top             =   4800
      Width           =   735
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Height          =   315
      Left            =   3000
      TabIndex        =   21
      Top             =   1440
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   556
      _Version        =   393216
      Text            =   "DataCombo1"
   End
   Begin VB.TextBox txtpono 
      Height          =   375
      Left            =   3000
      TabIndex        =   14
      Top             =   720
      Width           =   1575
   End
   Begin VB.TextBox txtpodate 
      Height          =   375
      Left            =   3000
      TabIndex        =   13
      Top             =   1920
      Width           =   1695
   End
   Begin VB.TextBox txtvend 
      Height          =   375
      Left            =   3000
      TabIndex        =   12
      Top             =   2400
      Width           =   1575
   End
   Begin VB.TextBox txtitemno 
      Height          =   375
      Left            =   3000
      TabIndex        =   11
      Top             =   2880
      Width           =   1575
   End
   Begin VB.Frame Frame1 
      Height          =   1815
      Left            =   5640
      TabIndex        =   2
      Top             =   6840
      Width           =   6495
      Begin VB.TextBox txtcode 
         Height          =   375
         Left            =   360
         TabIndex        =   7
         Top             =   720
         Width           =   1455
      End
      Begin VB.TextBox txtqty 
         Height          =   375
         Left            =   2640
         TabIndex        =   6
         Top             =   600
         Width           =   1455
      End
      Begin VB.TextBox txtrate 
         Height          =   375
         Left            =   4560
         TabIndex        =   5
         Top             =   1000
         Width           =   6000
      End
      Begin VB.CommandButton cmdnext 
         Caption         =   "Next"
         Height          =   375
         Left            =   4080
         TabIndex        =   4
         Top             =   1320
         Width           =   855
      End
      Begin VB.CommandButton cmdsave 
         Caption         =   "Save"
         Height          =   375
         Index           =   0
         Left            =   4920
         TabIndex        =   3
         Top             =   1320
         Width           =   855
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         Caption         =   "ItemCode"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   480
         TabIndex        =   10
         Top             =   240
         Width           =   1185
      End
      Begin VB.Label Label7 
         AutoSize        =   -1  'True
         Caption         =   "Quantity"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   2880
         TabIndex        =   9
         Top             =   240
         Width           =   1020
      End
      Begin VB.Label Label8 
         AutoSize        =   -1  'True
         Caption         =   "Rate"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   5040
         TabIndex        =   8
         Top             =   240
         Width           =   600
      End
   End
   Begin VB.CommandButton cmdNEW 
      Caption         =   "New"
      Height          =   375
      Left            =   6120
      TabIndex        =   1
      Top             =   4800
      Width           =   855
   End
   Begin VB.CommandButton cmdexit 
      Caption         =   "Exit"
      Height          =   375
      Left            =   8160
      TabIndex        =   0
      Top             =   4800
      Width           =   855
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "pohdr"
      Top             =   5280
      Visible         =   0   'False
      Width           =   2175
   End
   Begin VB.Data Data2 
      Caption         =   "Data2"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "podtl"
      Top             =   6240
      Visible         =   0   'False
      Width           =   2175
   End
   Begin VB.Data Data3 
      Caption         =   "Data3"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "qutnhdr"
      Top             =   5760
      Visible         =   0   'False
      Width           =   2055
   End
   Begin VB.Data Data4 
      Caption         =   "Data4"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   2400
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "qutndtl"
      Top             =   5760
      Visible         =   0   'False
      Width           =   2055
   End
   Begin VB.Data Data5 
      Caption         =   "Data5"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   2400
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "itemcode"
      Top             =   5280
      Visible         =   0   'False
      Width           =   1740
   End
   Begin VB.Label Label12 
      AutoSize        =   -1  'True
      Caption         =   "ItemCode"
      Height          =   195
      Left            =   1200
      TabIndex        =   24
      Top             =   3000
      Width           =   675
   End
   Begin VB.Label Label11 
      AutoSize        =   -1  'True
      Caption         =   "Rate"
      Height          =   195
      Left            =   1200
      TabIndex        =   23
      Top             =   3480
      Width           =   345
   End
   Begin VB.Label Label10 
      AutoSize        =   -1  'True
      Caption         =   "Quantity"
      Height          =   195
      Left            =   1200
      TabIndex        =   22
      Top             =   3960
      Width           =   585
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Purchase order Number"
      Height          =   195
      Left            =   960
      TabIndex        =   20
      Top             =   840
      Width           =   1680
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Quatation Number"
      Height          =   195
      Left            =   1200
      TabIndex        =   19
      Top             =   1560
      Width           =   1290
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Purchase Order Date"
      Height          =   195
      Left            =   1200
      TabIndex        =   18
      Top             =   2040
      Width           =   1500
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "Vendor"
      Height          =   195
      Left            =   1200
      TabIndex        =   17
      Top             =   2520
      Width           =   510
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "Purchase Order Value"
      Height          =   195
      Left            =   1200
      TabIndex        =   16
      Top             =   4440
      Width           =   1560
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   120
      X2              =   9600
      Y1              =   1200
      Y2              =   1200
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      Caption         =   "Purchase Order"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   3360
      TabIndex        =   15
      Top             =   120
      Width           =   2550
   End
End
Attribute VB_Name = "Form9"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdexit_Click()
Unload Me
'MDIForm1.WindowState = 2
End Sub
Private Sub cmdnew_Click()
'Call clr(Me)
Dim a%
If pors.RecordCount = 0 Then
a = 101
txtINO = a
Else
pors.MoveLast
'If Not pors.EOF Then
a = pors("INDENTNO") + 1
txtINO = a
txtindor.SetFocus
txtdate.Text = Date

'End If
End If
End Sub
Private Sub cmdsave_Click()
Call nul(Me)
If nul(Me) = 0 Then Exit Sub
If pors.BOF = True Then
ed1 = 1
Else
pors.MoveFirst
pors.Find "venno=" & txtvenno
If Not pors.EOF Then
   MsgBox "Record Exists"
   Exit Sub
End If
End If
If ed1 = 1 Then
    pors.AddNew
    ex1 = 0
End If
pors("INDENTNO") = txtINO
pors("INDATE") = txtindate
pors("INDENTOR") = txtindor
pors("TOT_EST_VAL") = txttotval
pors.Update
MsgBox "updated"
Call clmod.enablef(Me)
End Sub

Private Sub Form_Load()

End Sub
