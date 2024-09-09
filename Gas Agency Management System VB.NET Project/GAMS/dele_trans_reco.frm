VERSION 5.00
Begin VB.Form Form15 
   BackColor       =   &H00FF8080&
   Caption         =   "Form15"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form15"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton Command1 
      Caption         =   "&Transfered Record"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   6720
      TabIndex        =   2
      Top             =   3240
      Width           =   2775
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Previous  Record"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   2640
      TabIndex        =   1
      Top             =   3240
      Width           =   2775
   End
   Begin VB.CommandButton Command7 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Back to Main Menu"
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
      Left            =   4800
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   5040
      Width           =   2775
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
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
      Height          =   495
      Left            =   3960
      TabIndex        =   3
      Top             =   960
      Width           =   4410
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
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
      Height          =   495
      Left            =   3960
      TabIndex        =   5
      Top             =   960
      Width           =   4410
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Deletion Menu"
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
      Left            =   5040
      TabIndex        =   4
      Top             =   1920
      Width           =   2550
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   2280
      Top             =   1800
      Width           =   7575
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   6255
      Left            =   2280
      Top             =   720
      Width           =   7575
   End
End
Attribute VB_Name = "Form15"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command2_Click()
a = InputBox("Enter Record No", "Find to Delete")
If a = "" Then
Exit Sub
End If
Set con = New Connection
Set cmd = New Command
With con
.Provider = "MSDASQL"
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Open
End With
On Error GoTo LB1
sql = "DELETE from consumer_details where consumer_details.consumer_no=" & CInt(a)
m = con.Execute(sql, l)



If l = 0 Then
    MsgBox "record does not exist"
    Exit Sub
End If
sql1 = "DELETE from connection where connection.consumer_no=" & CInt(a)

con.Execute (sql1)
Exit Sub
LB1:
MsgBox "record  does not exist"
Exit Sub

'cmd.ActiveConnection = con

'cmd.CommandType = adCmdText
'cmd.CommandText = sql
'cmd.Execute
End Sub

Private Sub Command7_Click()
Load Form1
Form1.Show
Unload Me
End Sub
