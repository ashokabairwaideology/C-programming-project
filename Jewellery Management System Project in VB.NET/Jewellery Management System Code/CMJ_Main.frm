VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.MDIForm CMJ_Main 
   BackColor       =   &H8000000C&
   Caption         =   "Rajadhani Jewelleries"
   ClientHeight    =   9990
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   15870
   Icon            =   "CMJ_Main.frx":0000
   LinkTopic       =   "MDIForm1"
   Picture         =   "CMJ_Main.frx":0E42
   StartUpPosition =   2  'CenterScreen
   WindowState     =   2  'Maximized
   Begin MSComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   495
      Left            =   0
      TabIndex        =   6
      Top             =   9495
      Width           =   15870
      _ExtentX        =   27993
      _ExtentY        =   873
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   2
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   1
            Object.Width           =   23892
            Picture         =   "CMJ_Main.frx":11AE5
            Text            =   "Inventory System Version 1.0"
            TextSave        =   "Inventory System Version 1.0"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   2
            Object.Width           =   3545
            Text            =   "Bacterium_ph@yahoo.com"
            TextSave        =   "Bacterium_ph@yahoo.com"
            Object.ToolTipText     =   "E-mail address of the programmer."
         EndProperty
      EndProperty
   End
   Begin VB.PictureBox Picture1 
      Align           =   3  'Align Left
      BackColor       =   &H00FDE1BB&
      Height          =   9495
      Left            =   0
      ScaleHeight     =   9435
      ScaleWidth      =   2955
      TabIndex        =   0
      Top             =   0
      Width           =   3015
      Begin VB.Frame Frame1 
         BackColor       =   &H00FDE1BB&
         Height          =   9495
         Index           =   0
         Left            =   120
         TabIndex        =   1
         Top             =   0
         Width           =   2775
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Add New Item"
            Height          =   195
            Index           =   6
            Left            =   720
            TabIndex        =   14
            Top             =   6840
            Width           =   1005
         End
         Begin VB.Image img_AddNewItemOfJewelry 
            Height          =   480
            Left            =   960
            Picture         =   "CMJ_Main.frx":12937
            Top             =   6360
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Item Types"
            Height          =   195
            Index           =   5
            Left            =   840
            TabIndex        =   13
            Top             =   5880
            Width           =   780
         End
         Begin VB.Image img_AddNewJewelryItemTypes 
            Height          =   480
            Left            =   960
            Picture         =   "CMJ_Main.frx":12C41
            Stretch         =   -1  'True
            Top             =   5400
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Add New Supplier"
            Height          =   195
            Index           =   4
            Left            =   600
            TabIndex        =   12
            Top             =   4920
            Width           =   1275
         End
         Begin VB.Image img_AddNewSupplier 
            Height          =   480
            Left            =   960
            Picture         =   "CMJ_Main.frx":13083
            Top             =   4440
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Add New Customer"
            Height          =   195
            Index           =   3
            Left            =   480
            TabIndex        =   11
            Top             =   3960
            Width           =   1365
         End
         Begin VB.Image img_AddNewCustomer 
            Height          =   480
            Left            =   960
            Picture         =   "CMJ_Main.frx":1394D
            Top             =   3480
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Add New Employee"
            Height          =   195
            Index           =   2
            Left            =   600
            TabIndex        =   10
            Top             =   3000
            Width           =   1395
         End
         Begin VB.Image img_AddNewEmployee 
            Height          =   480
            Left            =   960
            Picture         =   "CMJ_Main.frx":14217
            Top             =   2520
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Change Password"
            Height          =   195
            Index           =   1
            Left            =   600
            TabIndex        =   9
            Top             =   2040
            Width           =   1290
         End
         Begin VB.Image img_ChangePassword 
            Height          =   480
            Left            =   960
            Picture         =   "CMJ_Main.frx":14AE1
            Top             =   1560
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Back Up Database"
            Height          =   195
            Index           =   0
            Left            =   600
            TabIndex        =   8
            Top             =   1200
            Width           =   1365
         End
         Begin VB.Image img_BackUP 
            Height          =   480
            Left            =   960
            Picture         =   "CMJ_Main.frx":16263
            Top             =   720
            Width           =   480
         End
         Begin VB.Label Label4 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Help"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   0
            Left            =   720
            TabIndex        =   5
            Top             =   9000
            Width           =   1935
         End
         Begin VB.Image Image4 
            Height          =   480
            Index           =   0
            Left            =   120
            Picture         =   "CMJ_Main.frx":16B2D
            Top             =   8880
            Width           =   480
         End
         Begin VB.Label Label3 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Reports"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   0
            Left            =   720
            TabIndex        =   4
            Top             =   8400
            Width           =   1935
         End
         Begin VB.Image Image3 
            Height          =   480
            Index           =   0
            Left            =   120
            Picture         =   "CMJ_Main.frx":18827
            Top             =   8280
            Width           =   480
         End
         Begin VB.Label Label2 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Transactions"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   0
            Left            =   720
            TabIndex        =   3
            Top             =   7800
            Width           =   1935
         End
         Begin VB.Image Image2 
            Height          =   480
            Index           =   0
            Left            =   120
            Picture         =   "CMJ_Main.frx":190F1
            Top             =   7680
            Width           =   480
         End
         Begin VB.Label Label1 
            Alignment       =   2  'Center
            AutoSize        =   -1  'True
            BackColor       =   &H000040C0&
            Caption         =   "Utilities"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   0
            Left            =   720
            TabIndex        =   2
            Top             =   240
            Width           =   1935
         End
         Begin VB.Image Image1 
            Height          =   480
            Index           =   0
            Left            =   120
            Picture         =   "CMJ_Main.frx":199BB
            Top             =   120
            Width           =   480
         End
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00FDE1BB&
         Height          =   9495
         Index           =   3
         Left            =   120
         TabIndex        =   33
         Top             =   0
         Width           =   2775
         Begin VB.Image Image14 
            Height          =   480
            Left            =   120
            Picture         =   "CMJ_Main.frx":1A7FD
            Top             =   0
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Purchases"
            Height          =   195
            Index           =   16
            Left            =   0
            TabIndex        =   39
            Top             =   480
            Width           =   750
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "About the System"
            Height          =   195
            Index           =   18
            Left            =   600
            TabIndex        =   38
            Top             =   3000
            Width           =   1245
         End
         Begin VB.Image Image16 
            Height          =   465
            Left            =   960
            Picture         =   "CMJ_Main.frx":1B0C7
            Stretch         =   -1  'True
            Top             =   2400
            Width           =   480
         End
         Begin VB.Label Label4 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Help"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   3
            Left            =   720
            TabIndex        =   37
            Top             =   2040
            Width           =   1935
         End
         Begin VB.Label Label3 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Reports"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   3
            Left            =   720
            TabIndex        =   36
            Top             =   1440
            Width           =   1935
         End
         Begin VB.Label Label2 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Transactions"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   3
            Left            =   720
            TabIndex        =   35
            Top             =   840
            Width           =   1935
         End
         Begin VB.Label Label1 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Utilities"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   3
            Left            =   720
            TabIndex        =   34
            Top             =   240
            Width           =   1935
         End
         Begin VB.Image Image1 
            Height          =   480
            Index           =   3
            Left            =   120
            Picture         =   "CMJ_Main.frx":1BD91
            Top             =   120
            Width           =   480
         End
         Begin VB.Image Image2 
            Height          =   480
            Index           =   3
            Left            =   120
            Picture         =   "CMJ_Main.frx":1CBD3
            Top             =   720
            Width           =   480
         End
         Begin VB.Image Image3 
            Height          =   480
            Index           =   3
            Left            =   120
            Picture         =   "CMJ_Main.frx":1D49D
            Top             =   1320
            Width           =   480
         End
         Begin VB.Image Image4 
            Height          =   480
            Index           =   3
            Left            =   120
            Picture         =   "CMJ_Main.frx":1DD67
            Top             =   1920
            Width           =   480
         End
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00FDE1BB&
         Height          =   9495
         Index           =   2
         Left            =   120
         TabIndex        =   23
         Top             =   0
         Width           =   2775
         Begin VB.Image Image17 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":1FA61
            Top             =   6480
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Cash Flow"
            Height          =   195
            Index           =   19
            Left            =   600
            TabIndex        =   41
            Top             =   6960
            Width           =   735
         End
         Begin VB.Image Image15 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":1FD6B
            Top             =   2880
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Purchase Report"
            Height          =   195
            Index           =   17
            Left            =   600
            TabIndex        =   40
            Top             =   3360
            Width           =   1200
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Cash OUT Report"
            Height          =   195
            Index           =   15
            Left            =   600
            TabIndex        =   32
            Top             =   6000
            Width           =   1275
         End
         Begin VB.Image Image13 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":20635
            Top             =   5520
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Cash IN Report"
            Height          =   195
            Index           =   11
            Left            =   600
            TabIndex        =   31
            Top             =   5160
            Width           =   1095
         End
         Begin VB.Image Image9 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":20EFF
            Top             =   4680
            Width           =   480
         End
         Begin VB.Image Image4 
            Height          =   480
            Index           =   2
            Left            =   120
            Picture         =   "CMJ_Main.frx":217C9
            Top             =   8880
            Width           =   480
         End
         Begin VB.Image Image3 
            Height          =   480
            Index           =   2
            Left            =   120
            Picture         =   "CMJ_Main.frx":234C3
            Top             =   1320
            Width           =   480
         End
         Begin VB.Image Image2 
            Height          =   480
            Index           =   2
            Left            =   120
            Picture         =   "CMJ_Main.frx":23D8D
            Top             =   720
            Width           =   480
         End
         Begin VB.Image Image1 
            Height          =   480
            Index           =   2
            Left            =   120
            Picture         =   "CMJ_Main.frx":24657
            Top             =   120
            Width           =   480
         End
         Begin VB.Label Label1 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Utilities"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   2
            Left            =   720
            TabIndex        =   30
            Top             =   240
            Width           =   1935
         End
         Begin VB.Label Label2 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Transactions"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   2
            Left            =   720
            TabIndex        =   29
            Top             =   840
            Width           =   1935
         End
         Begin VB.Label Label3 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Reports"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   2
            Left            =   720
            TabIndex        =   28
            Top             =   1440
            Width           =   1935
         End
         Begin VB.Label Label4 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Help"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   2
            Left            =   720
            TabIndex        =   27
            Top             =   9000
            Width           =   1935
         End
         Begin VB.Image Image12 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":25499
            Top             =   1920
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Sales Report"
            Height          =   195
            Index           =   14
            Left            =   600
            TabIndex        =   26
            Top             =   2400
            Width           =   915
         End
         Begin VB.Image Image11 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":25D63
            Top             =   3720
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Inventory Report"
            Height          =   195
            Index           =   13
            Left            =   600
            TabIndex        =   25
            Top             =   4200
            Width           =   1185
         End
         Begin VB.Image Image10 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":261A5
            Top             =   8160
            Visible         =   0   'False
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Graph Report"
            Height          =   195
            Index           =   12
            Left            =   600
            TabIndex        =   24
            Top             =   8640
            Visible         =   0   'False
            Width           =   960
         End
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00FDE1BB&
         Height          =   9495
         Index           =   1
         Left            =   120
         TabIndex        =   7
         Top             =   0
         Width           =   2775
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Cash OUT"
            Height          =   195
            Index           =   10
            Left            =   720
            TabIndex        =   22
            Top             =   4920
            Width           =   750
         End
         Begin VB.Image Image8 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":26A6F
            Top             =   4320
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Cash IN"
            Height          =   195
            Index           =   9
            Left            =   720
            TabIndex        =   21
            Top             =   3840
            Width           =   570
         End
         Begin VB.Image Image7 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":27339
            Top             =   3360
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Sales"
            Height          =   195
            Index           =   8
            Left            =   720
            TabIndex        =   20
            Top             =   2880
            Width           =   390
         End
         Begin VB.Image Image6 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":27C03
            Top             =   2280
            Width           =   480
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "Purchases"
            Height          =   195
            Index           =   7
            Left            =   720
            TabIndex        =   19
            Top             =   1800
            Width           =   750
         End
         Begin VB.Image Image5 
            Height          =   480
            Left            =   840
            Picture         =   "CMJ_Main.frx":27F0D
            Top             =   1320
            Width           =   480
         End
         Begin VB.Label Label4 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Help"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   1
            Left            =   720
            TabIndex        =   18
            Top             =   9000
            Width           =   1935
         End
         Begin VB.Label Label3 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Reports"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   1
            Left            =   720
            TabIndex        =   17
            Top             =   8400
            Width           =   1935
         End
         Begin VB.Label Label2 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Transactions"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   1
            Left            =   720
            TabIndex        =   16
            Top             =   840
            Width           =   1935
         End
         Begin VB.Label Label1 
            Alignment       =   2  'Center
            BackColor       =   &H000040C0&
            Caption         =   "Utilities"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00FFFFFF&
            Height          =   195
            Index           =   1
            Left            =   720
            TabIndex        =   15
            Top             =   240
            Width           =   1935
         End
         Begin VB.Image Image1 
            Height          =   480
            Index           =   1
            Left            =   120
            Picture         =   "CMJ_Main.frx":287D7
            Top             =   120
            Width           =   480
         End
         Begin VB.Image Image2 
            Height          =   480
            Index           =   1
            Left            =   120
            Picture         =   "CMJ_Main.frx":29619
            Top             =   720
            Width           =   480
         End
         Begin VB.Image Image3 
            Height          =   480
            Index           =   1
            Left            =   120
            Picture         =   "CMJ_Main.frx":29EE3
            Top             =   8280
            Width           =   480
         End
         Begin VB.Image Image4 
            Height          =   480
            Index           =   1
            Left            =   120
            Picture         =   "CMJ_Main.frx":2A7AD
            Top             =   8880
            Width           =   480
         End
      End
   End
   Begin VB.Menu Files 
      Caption         =   "Utilities"
      Begin VB.Menu DatabaseOptions 
         Caption         =   "Database Option"
         Begin VB.Menu BackUp 
            Caption         =   "Back-Up"
         End
         Begin VB.Menu Restore 
            Caption         =   "Restore"
            Enabled         =   0   'False
            Visible         =   0   'False
         End
      End
      Begin VB.Menu d2 
         Caption         =   "-"
      End
      Begin VB.Menu Options 
         Caption         =   "Options"
         Begin VB.Menu ChangePassword 
            Caption         =   "Change System Password"
         End
         Begin VB.Menu d10 
            Caption         =   "-"
         End
         Begin VB.Menu Employee 
            Caption         =   "Employees..."
            Begin VB.Menu AddNewEmployee 
               Caption         =   "Add New Employee's Profile"
            End
            Begin VB.Menu FindEmployee 
               Caption         =   "Find Employee..."
            End
         End
         Begin VB.Menu d3 
            Caption         =   "-"
         End
         Begin VB.Menu Customer 
            Caption         =   "Customers..."
            Begin VB.Menu AddNewCustomerProfile 
               Caption         =   "Add New Customer's Profile"
            End
            Begin VB.Menu FindCustomer 
               Caption         =   "Find Customer..."
            End
         End
         Begin VB.Menu D7 
            Caption         =   "-"
         End
         Begin VB.Menu Suppliers 
            Caption         =   "Suppliers"
            Begin VB.Menu AddNewSupplierProfile 
               Caption         =   "Add New Supplier's Profile"
            End
            Begin VB.Menu FindSupplier 
               Caption         =   "Find Supplier..."
            End
         End
      End
      Begin VB.Menu d6 
         Caption         =   "-"
      End
      Begin VB.Menu JewelrySetUp 
         Caption         =   "Jewelry Set-Up"
         Begin VB.Menu ItemTYpes 
            Caption         =   "Item types..."
         End
         Begin VB.Menu NewItem 
            Caption         =   "New Item"
         End
      End
      Begin VB.Menu d4 
         Caption         =   "-"
      End
      Begin VB.Menu Misc 
         Caption         =   "Miscellaneous"
         Begin VB.Menu CasHOutCategory 
            Caption         =   "Cash Out Category"
         End
      End
      Begin VB.Menu a1 
         Caption         =   "-"
      End
      Begin VB.Menu Exit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu Transactions 
      Caption         =   "Transactions"
      Begin VB.Menu Purchases 
         Caption         =   "Purchases..."
      End
      Begin VB.Menu d1 
         Caption         =   "-"
      End
      Begin VB.Menu Sales 
         Caption         =   "Sales..."
      End
      Begin VB.Menu d5 
         Caption         =   "-"
      End
      Begin VB.Menu CashIn 
         Caption         =   "Cash IN"
      End
      Begin VB.Menu CasHOut 
         Caption         =   "Cash OUT"
      End
   End
   Begin VB.Menu Reports 
      Caption         =   "Reports"
      Begin VB.Menu Report_Sales 
         Caption         =   "Sales"
      End
      Begin VB.Menu Purchase 
         Caption         =   "Purchases"
      End
      Begin VB.Menu Report_Inventory 
         Caption         =   "Inventory"
      End
      Begin VB.Menu GraphReport 
         Caption         =   "Graph Report"
      End
      Begin VB.Menu d9 
         Caption         =   "-"
      End
      Begin VB.Menu CashInReport 
         Caption         =   "Cash IN Report"
      End
      Begin VB.Menu CashOUtReport 
         Caption         =   "Cash OUT Report"
      End
      Begin VB.Menu a11 
         Caption         =   "-"
      End
      Begin VB.Menu DailyCashFlow 
         Caption         =   "Cash Flow"
      End
   End
   Begin VB.Menu Help 
      Caption         =   "Help"
      Begin VB.Menu InventoryHelp 
         Caption         =   "Inventory Help"
         Visible         =   0   'False
      End
      Begin VB.Menu AboutInventory 
         Caption         =   "About Inventory"
      End
   End
End
Attribute VB_Name = "CMJ_Main"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub AboutInventory_Click()
frmAbout.Show vbModal
End Sub

Private Sub AddNewCustomerProfile_Click()
frmCustomer.Show vbModal
End Sub

Private Sub AddNewEmployee_Click()
frmEmployee.Show vbModal
End Sub

Private Sub AddNewSupplierProfile_Click()
frmSupplier.Show vbModal
End Sub

Private Sub BackUp_Click()
frmBackUp.Show vbModal
End Sub

Private Sub CashIn_Click()
frmCashIN.Show vbModal
End Sub

Private Sub CashInReport_Click()
frmReportCashIn.Show vbModal
End Sub

Private Sub CasHOut_Click()
frmCashOut.Show vbModal
End Sub

Private Sub CasHOutCategory_Click()
frmCashOUTCategory.Show vbModal
End Sub

Private Sub CashOUtReport_Click()
frmReportCashOUT.Show vbModal
End Sub

Private Sub ChangePassword_Click()
frmChangePassword.Show vbModal
End Sub

Private Sub DailyCashFlow_Click()
frmDailyCashFLow.Show vbModal
End Sub

Private Sub Exit_Click()
Dim ans
ans = MsgBox("Do you really want to terminate the system?", vbQuestion + vbYesNo)
If ans = vbYes Then
    'Unload Me
    End
    'frmSplash.Show
Else
    Exit Sub
End If


End Sub

Private Sub FindCustomer_Click()
frmCustomerFind.Show vbModal
End Sub

Private Sub FindEmployee_Click()
frmEmployeeFind.Show vbModal
End Sub

Private Sub FindSupplier_Click()
frmSupplierFind.Show vbModal
End Sub

Private Sub Image1_Click(Index As Integer)
Frame1(0).Visible = True
Frame1(1).Visible = False
Frame1(2).Visible = False
Frame1(3).Visible = False
End Sub

Private Sub Image11_Click()
Report_Inventory_Click
End Sub

Private Sub Image12_Click()
Report_Sales_Click
End Sub

Private Sub Image13_Click()
CashOUtReport_Click
End Sub

Private Sub Image15_Click()
Purchase_Click
End Sub

Private Sub Image16_Click()
AboutInventory_Click
End Sub

Private Sub Image17_Click()
DailyCashFlow_Click
End Sub

Private Sub Image2_Click(Index As Integer)
Frame1(0).Visible = False
Frame1(1).Visible = True
Frame1(2).Visible = False
Frame1(3).Visible = False

End Sub

Private Sub Image3_Click(Index As Integer)
Frame1(0).Visible = False
Frame1(1).Visible = False
Frame1(2).Visible = True
Frame1(3).Visible = False

End Sub

Private Sub Image4_Click(Index As Integer)
Frame1(0).Visible = False
Frame1(1).Visible = False
Frame1(2).Visible = False
Frame1(3).Visible = True
End Sub

Private Sub Image5_Click()
Purchases_Click
End Sub

Private Sub Image6_Click()
Sales_Click
End Sub

Private Sub Image7_Click()
CashIn_Click
End Sub

Private Sub Image8_Click()
CasHOut_Click
End Sub

Private Sub Image9_Click()
CashInReport_Click
End Sub

Private Sub img_AddNewCustomer_Click()
AddNewCustomerProfile_Click
End Sub

Private Sub img_AddNewEmployee_Click()
AddNewEmployee_Click
End Sub

Private Sub img_AddNewItemOfJewelry_Click()
NewItem_Click
End Sub

Private Sub img_AddNewJewelryItemTypes_Click()
ItemTYpes_Click
End Sub

Private Sub img_AddNewSupplier_Click()
AddNewSupplierProfile_Click
End Sub

Private Sub img_BackUP_Click()
BackUp_Click
End Sub

Private Sub img_ChangePassword_Click()
ChangePassword_Click
End Sub

Private Sub ItemTYpes_Click()
frmItemTypes.Show vbModal
End Sub

Private Sub Label1_Click(Index As Integer)
Frame1(0).Visible = True
Frame1(1).Visible = False
Frame1(2).Visible = False
Frame1(3).Visible = False
End Sub

Private Sub Label2_Click(Index As Integer)
Frame1(0).Visible = False
Frame1(1).Visible = True
Frame1(2).Visible = False
Frame1(3).Visible = False

End Sub

Private Sub Label3_Click(Index As Integer)
Frame1(0).Visible = False
Frame1(1).Visible = False
Frame1(2).Visible = True
Frame1(3).Visible = False

End Sub

Private Sub Label4_Click(Index As Integer)
Frame1(0).Visible = False
Frame1(1).Visible = False
Frame1(2).Visible = False
Frame1(3).Visible = True

End Sub

Private Sub MDIForm_Load()
CMJ_Main.Show
CMJ_Main.Enabled = False
frmSplash.Show vbModal

End Sub

Private Sub MDIForm_Unload(Cancel As Integer)
Cancel = 1
Exit_Click
End Sub

Private Sub NewItem_Click()
frmNewItem.Show vbModal
End Sub

Private Sub Purchase_Click()
frmReportPurchase.Show vbModal
End Sub

Private Sub Purchases_Click()
frmPurchase.Show vbModal
End Sub

Private Sub Report_Inventory_Click()
frmReportInventory.Show vbModal
End Sub

Private Sub Report_Sales_Click()
frmReportSales.Show vbModal
End Sub

Private Sub Sales_Click()
frmSales.Show vbModal
End Sub
