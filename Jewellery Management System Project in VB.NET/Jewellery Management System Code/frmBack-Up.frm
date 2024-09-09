VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form frmBackUp 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   " Back Up Database"
   ClientHeight    =   4395
   ClientLeft      =   45
   ClientTop       =   210
   ClientWidth     =   3705
   Icon            =   "frmBack-Up.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4395
   ScaleWidth      =   3705
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command1 
      Caption         =   "&Close"
      Height          =   315
      Left            =   2400
      TabIndex        =   6
      Top             =   3960
      Width           =   1215
   End
   Begin VB.CommandButton cmdsave 
      Caption         =   "&Save"
      Height          =   315
      Left            =   1080
      TabIndex        =   5
      Top             =   3960
      Width           =   1215
   End
   Begin RichTextLib.RichTextBox rtbdatabase 
      Height          =   375
      Left            =   120
      TabIndex        =   3
      Top             =   6480
      Visible         =   0   'False
      Width           =   1545
      _ExtentX        =   2725
      _ExtentY        =   661
      _Version        =   393217
      Enabled         =   -1  'True
      Appearance      =   0
      TextRTF         =   $"frmBack-Up.frx":08CA
   End
   Begin VB.DriveListBox drivelist 
      Height          =   315
      Left            =   120
      TabIndex        =   1
      Top             =   360
      Width           =   3495
   End
   Begin VB.DirListBox dirlist 
      Appearance      =   0  'Flat
      Height          =   2790
      Left            =   120
      TabIndex        =   0
      Top             =   1080
      Width           =   3495
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Directory:"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Index           =   1
      Left            =   120
      TabIndex        =   4
      Top             =   840
      Width           =   975
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Look In:"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Index           =   0
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   795
   End
End
Attribute VB_Name = "frmBackUp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit



Private Sub cmdSave_Click()
    'saves a back-up copy of the library system database
    On Error Resume Next
    Dim directory, Database
    'get path
    directory = dirlist.Path
    'if in root directory remove "\"
    If Right(directory, 1) = Chr(92) Then directory = Left(directory, (Len(directory) - 1))
    rtbdatabase.FileName = App.Path + "\CMJ.mdb"
    'write the database file to disk
    Database = FreeFile
    Open directory + "\CMJ_BackUP.mdb" For Output As Database
    Print #1, rtbdatabase.Text
    Close Database
    MsgBox "The back-up file was created."
    'unload this form from memory
    'Unload Me
End Sub

Private Sub Command1_Click()
Unload Me
End Sub

Private Sub drivelist_Change()
    dirlist = drivelist
End Sub

Private Sub Form_Load()
    Me.Top = 0
    Me.Left = 0
End Sub

Private Sub Image4_Click()
Unload Me
End Sub
