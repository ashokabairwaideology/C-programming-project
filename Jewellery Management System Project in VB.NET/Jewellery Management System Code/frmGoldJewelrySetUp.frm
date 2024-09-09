VERSION 5.00
Begin VB.Form frmGoldJewelrySetUp 
   BackColor       =   &H00FEEADA&
   Caption         =   "Gold Jewelry Set Up"
   ClientHeight    =   5475
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6105
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5475
   ScaleWidth      =   6105
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame4 
      BackColor       =   &H00FEEADA&
      Caption         =   "Division"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   240
      TabIndex        =   21
      Top             =   4080
      Width           =   5655
      Begin VB.ComboBox Combo4 
         Height          =   315
         Left            =   1200
         TabIndex        =   25
         Top             =   360
         Width           =   3255
      End
      Begin VB.TextBox Text4 
         Height          =   315
         Left            =   1200
         TabIndex        =   24
         Top             =   720
         Width           =   3255
      End
      Begin VB.CommandButton Command8 
         Caption         =   "Add"
         Height          =   375
         Left            =   4680
         TabIndex        =   23
         Top             =   240
         Width           =   855
      End
      Begin VB.CommandButton Command7 
         Caption         =   "Delete"
         Height          =   375
         Left            =   4680
         TabIndex        =   22
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   8
         Left            =   720
         TabIndex        =   27
         Top             =   360
         Width           =   360
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   7
         Left            =   285
         TabIndex        =   26
         Top             =   720
         Width           =   795
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00FEEADA&
      Caption         =   "Type"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   240
      TabIndex        =   14
      Top             =   2760
      Width           =   5655
      Begin VB.ComboBox Combo3 
         Height          =   315
         Left            =   1200
         TabIndex        =   18
         Top             =   360
         Width           =   3255
      End
      Begin VB.TextBox Text3 
         Height          =   315
         Left            =   1200
         TabIndex        =   17
         Top             =   720
         Width           =   3255
      End
      Begin VB.CommandButton Command6 
         Caption         =   "Add"
         Height          =   375
         Left            =   4680
         TabIndex        =   16
         Top             =   240
         Width           =   855
      End
      Begin VB.CommandButton Command5 
         Caption         =   "Delete"
         Height          =   375
         Left            =   4680
         TabIndex        =   15
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   6
         Left            =   720
         TabIndex        =   20
         Top             =   360
         Width           =   360
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   5
         Left            =   285
         TabIndex        =   19
         Top             =   720
         Width           =   795
      End
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Caption         =   "Unit"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   240
      TabIndex        =   7
      Top             =   1440
      Width           =   5655
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   1200
         TabIndex        =   11
         Top             =   360
         Width           =   3255
      End
      Begin VB.TextBox Text2 
         Height          =   315
         Left            =   1200
         TabIndex        =   10
         Top             =   720
         Width           =   3255
      End
      Begin VB.CommandButton Command4 
         Caption         =   "Add"
         Height          =   375
         Left            =   4680
         TabIndex        =   9
         Top             =   240
         Width           =   855
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Delete"
         Height          =   375
         Left            =   4680
         TabIndex        =   8
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   4
         Left            =   720
         TabIndex        =   13
         Top             =   360
         Width           =   360
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   3
         Left            =   285
         TabIndex        =   12
         Top             =   720
         Width           =   795
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Caption         =   "Category"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   5655
      Begin VB.CommandButton Command2 
         Caption         =   "Delete"
         Height          =   375
         Left            =   4680
         TabIndex        =   6
         Top             =   720
         Width           =   855
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Add"
         Height          =   375
         Left            =   4680
         TabIndex        =   5
         Top             =   240
         Width           =   855
      End
      Begin VB.TextBox Text1 
         Height          =   315
         Left            =   1200
         TabIndex        =   4
         Top             =   720
         Width           =   3255
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   1200
         TabIndex        =   1
         Top             =   360
         Width           =   3255
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Description"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   2
         Left            =   285
         TabIndex        =   3
         Top             =   720
         Width           =   795
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Type"
         ForeColor       =   &H80000008&
         Height          =   195
         Index           =   1
         Left            =   720
         TabIndex        =   2
         Top             =   360
         Width           =   360
      End
   End
End
Attribute VB_Name = "frmGoldJewelrySetUp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

End Sub
