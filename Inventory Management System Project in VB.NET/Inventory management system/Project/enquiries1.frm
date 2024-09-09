VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form Form4 
   Caption         =   "Form4"
   ClientHeight    =   6210
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9210
   LinkTopic       =   "Form4"
   MDIChild        =   -1  'True
   ScaleHeight     =   6210
   ScaleWidth      =   9210
   WindowState     =   2  'Maximized
   Begin MSDataListLib.DataCombo DataCombo1 
      Height          =   315
      Left            =   1440
      TabIndex        =   21
      Top             =   840
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   556
      _Version        =   393216
      Text            =   "DataCombo1"
   End
   Begin VB.CommandButton Command3 
      Caption         =   "DELETE"
      Height          =   375
      Left            =   5400
      TabIndex        =   15
      Top             =   5760
      Width           =   975
   End
   Begin VB.CommandButton Command2 
      Caption         =   "EXIT"
      Height          =   375
      Left            =   6360
      TabIndex        =   14
      Top             =   5760
      Width           =   855
   End
   Begin VB.CommandButton Command1 
      Caption         =   "MODIFY"
      Height          =   375
      Left            =   4440
      TabIndex        =   13
      Top             =   5760
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
      RecordSource    =   "enqdtl"
      Top             =   5280
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.Data Data1 
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   1680
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "enqhdr"
      Top             =   5280
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.TextBox txtino 
      Height          =   375
      Left            =   1440
      TabIndex        =   12
      Top             =   1560
      Width           =   2655
   End
   Begin VB.TextBox txtdate 
      Height          =   375
      Left            =   1440
      TabIndex        =   11
      Top             =   2040
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Height          =   2055
      Left            =   960
      TabIndex        =   1
      Top             =   3000
      Width           =   5895
      Begin VB.TextBox txtcode 
         Height          =   375
         Left            =   480
         TabIndex        =   7
         Top             =   840
         Width           =   1215
      End
      Begin VB.TextBox txtqty 
         Height          =   375
         Left            =   2280
         TabIndex        =   6
         Top             =   840
         Width           =   1335
      End
      Begin VB.TextBox txtdtreq 
         Height          =   375
         Left            =   4200
         TabIndex        =   5
         Top             =   840
         Width           =   1335
      End
      Begin VB.CommandButton Command4 
         Caption         =   "Next"
         Height          =   375
         Left            =   3480
         TabIndex        =   4
         Top             =   1560
         Width           =   735
      End
      Begin VB.CommandButton Command5 
         Caption         =   "Modify"
         Height          =   375
         Left            =   4200
         TabIndex        =   3
         Top             =   1560
         Width           =   855
      End
      Begin VB.CommandButton Command6 
         Caption         =   "Delete"
         Height          =   375
         Left            =   5040
         TabIndex        =   2
         Top             =   1560
         Width           =   735
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         Caption         =   "Item_code"
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
         Top             =   360
         Width           =   1290
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
         Left            =   2400
         TabIndex        =   9
         Top             =   360
         Width           =   1020
      End
      Begin VB.Label Label8 
         AutoSize        =   -1  'True
         Caption         =   "Date_req"
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
         Left            =   4200
         TabIndex        =   8
         Top             =   360
         Width           =   1140
      End
   End
   Begin VB.TextBox txtvend 
      Height          =   375
      Left            =   1440
      TabIndex        =   0
      Top             =   2520
      Width           =   1455
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   9360
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
      Left            =   720
      TabIndex        =   20
      Top             =   2520
      Width           =   645
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Enqdate"
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
      Left            =   360
      TabIndex        =   19
      Top             =   2040
      Width           =   1035
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Indentno"
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
      Left            =   315
      TabIndex        =   18
      Top             =   1560
      Width           =   1095
   End
   Begin VB.Label Label1 
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
      Left            =   255
      TabIndex        =   17
      Top             =   840
      Width           =   795
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY ITEMS INDENT"
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
      TabIndex        =   16
      Top             =   0
      Width           =   4770
   End
End
Attribute VB_Name = "Form4"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
