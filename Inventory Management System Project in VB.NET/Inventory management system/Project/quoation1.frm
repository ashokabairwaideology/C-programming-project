VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form Form6 
   Caption         =   "Form6"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   LinkTopic       =   "Form6"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin MSDataListLib.DataCombo DataCombo1 
      Height          =   315
      Left            =   1320
      TabIndex        =   22
      Top             =   840
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   556
      _Version        =   393216
      Text            =   "DataCombo1"
   End
   Begin VB.CommandButton cmddel1 
      Caption         =   "DELETE"
      Height          =   375
      Left            =   6960
      TabIndex        =   12
      Top             =   6000
      Width           =   975
   End
   Begin VB.CommandButton cmdexit 
      Caption         =   "EXIT"
      Height          =   375
      Left            =   7920
      TabIndex        =   11
      Top             =   6000
      Width           =   855
   End
   Begin VB.CommandButton cmdmodify1 
      Caption         =   "MODIFY"
      Height          =   375
      Left            =   6000
      TabIndex        =   10
      Top             =   6000
      Width           =   975
   End
   Begin VB.Data Data2 
      Caption         =   "Data2"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   360
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "qutndtl"
      Top             =   5760
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   360
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "qutnhdr"
      Top             =   6120
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.TextBox txtdate 
      Height          =   375
      Left            =   1440
      TabIndex        =   9
      Top             =   1560
      Width           =   2655
   End
   Begin VB.TextBox txteqno 
      Height          =   375
      Left            =   1440
      TabIndex        =   8
      Top             =   2040
      Width           =   1215
   End
   Begin VB.TextBox txtvend 
      Height          =   375
      Left            =   1440
      TabIndex        =   7
      Top             =   2520
      Width           =   1455
   End
   Begin VB.TextBox txtcode 
      Height          =   375
      Left            =   840
      TabIndex        =   6
      Top             =   3840
      Width           =   1215
   End
   Begin VB.TextBox txtqty 
      Height          =   375
      Left            =   2880
      TabIndex        =   5
      Top             =   3840
      Width           =   1095
   End
   Begin VB.TextBox txtrate 
      Height          =   375
      Left            =   4560
      TabIndex        =   4
      Top             =   3840
      Width           =   975
   End
   Begin VB.TextBox txtreq 
      Height          =   375
      Left            =   6240
      TabIndex        =   3
      Top             =   3840
      Width           =   1455
   End
   Begin VB.CommandButton cmdnext 
      Caption         =   "Next"
      Height          =   375
      Left            =   5520
      TabIndex        =   2
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmdmodify 
      Caption         =   "Modify"
      Height          =   375
      Left            =   6360
      TabIndex        =   1
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmddel 
      Caption         =   "Delete"
      Height          =   375
      Left            =   7200
      TabIndex        =   0
      Top             =   4560
      Width           =   855
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   8280
      Y1              =   1320
      Y2              =   1320
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "Vend"
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
      Left            =   600
      TabIndex        =   21
      Top             =   2520
      Width           =   645
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Enqno"
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
      Left            =   555
      TabIndex        =   20
      Top             =   2040
      Width           =   795
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Enq date"
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
      Left            =   240
      TabIndex        =   19
      Top             =   1560
      Width           =   1110
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Qutno"
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
      Left            =   255
      TabIndex        =   18
      Top             =   840
      Width           =   750
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY ITEMS QUATATION"
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
      Left            =   1800
      TabIndex        =   17
      Top             =   0
      Width           =   5520
   End
   Begin VB.Line Line2 
      BorderColor     =   &H80000001&
      BorderWidth     =   4
      X1              =   480
      X2              =   8280
      Y1              =   3120
      Y2              =   3120
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      Caption         =   "Item_cd"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   960
      TabIndex        =   16
      Top             =   3480
      Width           =   870
   End
   Begin VB.Label Label7 
      AutoSize        =   -1  'True
      Caption         =   "Quantity"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   3000
      TabIndex        =   15
      Top             =   3480
      Width           =   885
   End
   Begin VB.Label Label8 
      AutoSize        =   -1  'True
      Caption         =   "Rate"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   4800
      TabIndex        =   14
      Top             =   3480
      Width           =   525
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      Caption         =   "Date of Require"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   6120
      TabIndex        =   13
      Top             =   3480
      Width           =   1695
   End
   Begin VB.Line Line3 
      BorderColor     =   &H80000001&
      BorderWidth     =   4
      X1              =   480
      X2              =   480
      Y1              =   3120
      Y2              =   5160
   End
   Begin VB.Line Line4 
      BorderColor     =   &H00808000&
      BorderWidth     =   4
      X1              =   8280
      X2              =   8280
      Y1              =   3120
      Y2              =   5160
   End
   Begin VB.Line Line5 
      BorderColor     =   &H80000001&
      BorderWidth     =   4
      X1              =   480
      X2              =   8280
      Y1              =   5160
      Y2              =   5160
   End
End
Attribute VB_Name = "Form6"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdexit_Click()
Unload Me
MDIForm1.WindowState = 2
End Sub
