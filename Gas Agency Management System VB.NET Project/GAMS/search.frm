VERSION 5.00
Begin VB.Form Form16 
   BackColor       =   &H00FF8080&
   Caption         =   "Form16"
   ClientHeight    =   6675
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7965
   LinkTopic       =   "Form16"
   MinButton       =   0   'False
   ScaleHeight     =   6675
   ScaleWidth      =   7965
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton cmdclear 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Clear"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9000
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   3000
      Width           =   1455
   End
   Begin VB.TextBox cname 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3480
      TabIndex        =   9
      Top             =   2520
      Width           =   3975
   End
   Begin VB.TextBox address 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3480
      TabIndex        =   8
      Top             =   3120
      Width           =   4335
   End
   Begin VB.TextBox phone 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3480
      TabIndex        =   7
      Top             =   3720
      Width           =   1575
   End
   Begin VB.TextBox cylinders 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3480
      TabIndex        =   6
      Top             =   6000
      Width           =   1575
   End
   Begin VB.TextBox flame 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3480
      TabIndex        =   5
      Top             =   6480
      Width           =   1575
   End
   Begin VB.TextBox dateall 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3480
      TabIndex        =   4
      Top             =   5520
      Width           =   1575
   End
   Begin VB.TextBox cno 
      Height          =   285
      Left            =   3480
      TabIndex        =   3
      Top             =   2040
      Width           =   1695
   End
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
      Height          =   495
      Left            =   9000
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   2280
      Width           =   1455
   End
   Begin VB.TextBox regulator 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3480
      TabIndex        =   1
      Top             =   6960
      Width           =   1575
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Back"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9000
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   3720
      Width           =   1455
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
      Left            =   4080
      TabIndex        =   19
      Top             =   480
      Width           =   4410
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Search Window"
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
      Left            =   4800
      TabIndex        =   18
      Top             =   1200
      Width           =   2745
   End
   Begin VB.Label Label3 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Consumer Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1200
      TabIndex        =   17
      Top             =   2520
      Width           =   1815
   End
   Begin VB.Label Label4 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Consumer Address"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1200
      TabIndex        =   16
      Top             =   3120
      Width           =   2055
   End
   Begin VB.Label Label6 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Phone"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1200
      TabIndex        =   15
      Top             =   3720
      Width           =   1575
   End
   Begin VB.Label Label13 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Total Cylinders"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1200
      TabIndex        =   14
      Top             =   6000
      Width           =   1815
   End
   Begin VB.Label Label17 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Flame"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1200
      TabIndex        =   13
      Top             =   6480
      Width           =   1815
   End
   Begin VB.Label Label18 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Connection  Alloted On"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1200
      TabIndex        =   12
      Top             =   5520
      Width           =   2055
   End
   Begin VB.Label Label5 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Cno."
      Height          =   255
      Left            =   1200
      TabIndex        =   11
      Top             =   2040
      Width           =   1575
   End
   Begin VB.Label Label7 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Regulator"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1200
      TabIndex        =   10
      Top             =   6960
      Width           =   1815
   End
   Begin VB.Shape Shape4 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2295
      Left            =   480
      Top             =   5160
      Width           =   11175
   End
   Begin VB.Label Label14 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
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
      Left            =   4080
      TabIndex        =   20
      Top             =   480
      Width           =   4410
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   480
      Top             =   1080
      Width           =   11175
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   4455
      Left            =   480
      Top             =   360
      Width           =   11175
   End
End
Attribute VB_Name = "Form16"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim b As String
Dim t As String

Private Sub Cmdclear_Click()
cno.Text = ""
cname.Text = ""
address.Text = ""
phone.Text = ""
dateall.Text = ""
cylinders.Text = ""
flame.Text = ""
regulator.Text = ""
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

On Error GoTo lb1
Set rst = New Recordset
rst.Open "select *  from consumer_details cd,connection cn where cd.consumer_no = cn.consumer_no and cd.consumer_no=" & CInt(cno.Text), con

If rst.EOF = True And rst.BOF = True Then
    MsgBox "No match found..........."
    cno.Text = ""
    cno.SetFocus
    Exit Sub
Else
cno.Text = rst!consumer_no
cname.Text = rst!c_name
address.Text = rst!address
phone.Text = rst!phone
dateall.Text = rst!date_alloted_on
cylinders.Text = rst!cylinders
flame.Text = rst!flame
regulator.Text = rst!regulator


End If
lb1:
End Sub

Private Sub cno_LostFocus()
b = cno.Text
End Sub

Private Sub Command1_Click()

End Sub

Private Sub Command2_Click()
Load Form1
Form1.Show
Unload Me
End Sub

Private Sub Form_Load()
t = InputBox("Enter record number please")


cno.Text = t
Set con = New Connection
Set rst = New Recordset
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With

If charcheck(t) = 0 Then
    MsgBox "No Record found........"
    'cno.SetFocus
    cno.Text = ""
    Exit Sub
End If


If cno.Text = "" Then
MsgBox " Enter consumer no"
'cno.SetFocus
Exit Sub

End If

On Error GoTo lb9
Set rst = New Recordset
rst.Open "select *  from consumer_details cd,connection cn where cd.consumer_no = cn.consumer_no and cd.consumer_no=" & CInt(cno.Text), con

If rst.EOF = True And rst.BOF = True Then
    MsgBox "No match found..........."
    cno.Text = ""
    'cno.SetFocus
    Exit Sub
Else
cno.Text = rst!consumer_no
cname.Text = rst!c_name
address.Text = rst!address
phone.Text = rst!phone
dateall.Text = rst!date_alloted_on
cylinders.Text = rst!cylinders
flame.Text = rst!flame
regulator.Text = rst!regulator


End If
lb9:
End Sub
