VERSION 5.00
Begin VB.Form Form4 
   BackColor       =   &H80000001&
   Caption         =   "Indian Gas Service"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form4"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   2880
      TabIndex        =   12
      Top             =   6120
      Width           =   4335
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   2880
      TabIndex        =   11
      Top             =   5640
      Width           =   2655
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   2880
      TabIndex        =   10
      Top             =   5040
      Width           =   1695
   End
   Begin VB.CheckBox Check5 
      Caption         =   "Low Quantity of LPG"
      Height          =   255
      Left            =   720
      TabIndex        =   6
      Top             =   4200
      Width           =   2175
   End
   Begin VB.CheckBox Check4 
      Caption         =   "Water Quantity In Cylinder"
      Height          =   375
      Left            =   720
      TabIndex        =   5
      Top             =   3720
      Width           =   3255
   End
   Begin VB.CheckBox Check3 
      Caption         =   "Cylinder  Leakage"
      Height          =   375
      Left            =   720
      TabIndex        =   4
      Top             =   3240
      Width           =   2415
   End
   Begin VB.CheckBox Check2 
      Caption         =   "Low Burning Flame"
      Height          =   255
      Left            =   720
      TabIndex        =   3
      Top             =   2760
      Width           =   2655
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Replacing Rubber Tube"
      Height          =   375
      Left            =   720
      TabIndex        =   2
      Top             =   2160
      Width           =   2775
   End
   Begin VB.Label Label5 
      BackColor       =   &H0080C0FF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Address"
      Height          =   495
      Left            =   600
      TabIndex        =   9
      Top             =   6120
      Width           =   1815
   End
   Begin VB.Label Label4 
      BackColor       =   &H0080C0FF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Name"
      Height          =   375
      Left            =   600
      TabIndex        =   8
      Top             =   5640
      Width           =   1815
   End
   Begin VB.Label Label3 
      BackColor       =   &H0080C0FF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Connection No."
      Height          =   375
      Left            =   600
      TabIndex        =   7
      Top             =   5040
      Width           =   1815
   End
   Begin VB.Label Label2 
      Caption         =   "Technical && Mechanical Complaints"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   375
      Left            =   3120
      TabIndex        =   1
      Top             =   1320
      Width           =   4695
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H8000000B&
      BackStyle       =   0  'Transparent
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
      Height          =   375
      Left            =   3120
      TabIndex        =   0
      Top             =   480
      Width           =   4410
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H80000004&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   600
      Top             =   1200
      Width           =   9375
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H80000004&
      FillStyle       =   0  'Solid
      Height          =   3495
      Left            =   600
      Top             =   1200
      Width           =   9375
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      BackColor       =   &H8000000B&
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
      ForeColor       =   &H0080FFFF&
      Height          =   495
      Left            =   3120
      TabIndex        =   13
      Top             =   480
      Width           =   4410
   End
End
Attribute VB_Name = "Form4"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
