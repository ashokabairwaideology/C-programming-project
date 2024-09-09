VERSION 5.00
Begin VB.Form Form4 
   BackColor       =   &H00FF8080&
   Caption         =   "Indian Gas Service"
   ClientHeight    =   8595
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11880
   ControlBox      =   0   'False
   LinkTopic       =   "Form4"
   ScaleHeight     =   8595
   ScaleWidth      =   11880
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.TextBox date1 
      Enabled         =   0   'False
      Height          =   375
      Left            =   2880
      TabIndex        =   9
      Top             =   6480
      Width           =   1575
   End
   Begin VB.TextBox add 
      Enabled         =   0   'False
      Height          =   375
      Left            =   2880
      TabIndex        =   8
      Top             =   6000
      Width           =   4335
   End
   Begin VB.TextBox C_name 
      Enabled         =   0   'False
      Height          =   375
      Left            =   2880
      TabIndex        =   7
      Top             =   5520
      Width           =   2655
   End
   Begin VB.CommandButton cmdfind 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Find"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3360
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   7080
      Width           =   1695
   End
   Begin VB.CommandButton cmdcancel 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Back"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   7920
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   7080
      Width           =   1695
   End
   Begin VB.CommandButton cmdsubmit 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Submit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   5640
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   7080
      Width           =   1695
   End
   Begin VB.TextBox cno 
      Height          =   375
      Left            =   2880
      TabIndex        =   6
      Top             =   5040
      Width           =   1695
   End
   Begin VB.CheckBox LQ 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Low Quantity of LPG"
      Height          =   255
      Left            =   720
      TabIndex        =   5
      Top             =   4200
      Width           =   2175
   End
   Begin VB.CheckBox WQ 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Water Quantity In Cylinder"
      Height          =   375
      Left            =   720
      TabIndex        =   4
      Top             =   3720
      Width           =   3255
   End
   Begin VB.CheckBox CL 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Cylinder  Leakage"
      Height          =   375
      Left            =   720
      TabIndex        =   3
      Top             =   3240
      Width           =   2415
   End
   Begin VB.CheckBox LBF 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Low Burning Flame"
      Height          =   255
      Left            =   720
      TabIndex        =   2
      Top             =   2760
      Width           =   2655
   End
   Begin VB.CheckBox RRT 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Replacing Rubber Tube"
      Height          =   375
      Left            =   720
      TabIndex        =   1
      Top             =   2160
      Width           =   2775
   End
   Begin VB.Label Label9 
      BackStyle       =   0  'Transparent
      Caption         =   "Date"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Left            =   720
      TabIndex        =   18
      Top             =   6480
      Width           =   1335
   End
   Begin VB.Label Label5 
      BackColor       =   &H0080C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "Address"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   495
      Left            =   720
      TabIndex        =   16
      Top             =   6000
      Width           =   1815
   End
   Begin VB.Label Label4 
      BackColor       =   &H0080C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "Name"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Left            =   720
      TabIndex        =   15
      Top             =   5520
      Width           =   1815
   End
   Begin VB.Label Label3 
      BackColor       =   &H0080C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "Connection No."
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Left            =   720
      TabIndex        =   14
      Top             =   5040
      Width           =   1815
   End
   Begin VB.Label Label2 
      BackColor       =   &H00008000&
      Caption         =   "Complaint Recieve Window"
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
      Height          =   375
      Left            =   2880
      TabIndex        =   13
      Top             =   1320
      Width           =   5175
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
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   480
      Top             =   1200
      Width           =   9495
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
      TabIndex        =   17
      Top             =   480
      Width           =   4410
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   4335
      Left            =   480
      Top             =   360
      Width           =   9495
   End
   Begin VB.Shape Shape3 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   3135
      Left            =   480
      Top             =   4800
      Width           =   9495
   End
End
Attribute VB_Name = "Form4"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim rrt1, wq1, cl1, lq1, lbf1, b As String
Private Sub Command1_Click()

End Sub

Private Sub cancel_Click()

End Sub

Private Sub Cmdcancel_Click()
Load Form8
Form8.Show
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
If cno.Text = "" Then
MsgBox "Enter connection nummber"
cno.SetFocus
c_name.Text = ""
add.Text = ""
date1.Text = ""
Exit Sub
End If
If charcheck(b) = 0 Then
    MsgBox "No Match found........"
    
    cno.Text = ""
    c_name.Text = ""
    add.Text = ""
    date1.Text = ""
    cno.SetFocus
    Exit Sub
End If


Set rst = New Recordset
rst.Open "select *  from consumer_details where consumer_details.consumer_no=" & CInt(cno.Text), con
If rst.EOF = True And rst.BOF = True Then
    MsgBox "No match found..........."
    cno.Text = ""
    c_name.Text = ""
    add.Text = ""
    date1.Text = ""
    cno.SetFocus
    Exit Sub
Else
c_name.Text = rst!c_name
add.Text = rst!address
date1.Text = Date
End If

End Sub

Private Sub Cmdsubmit_Click()
Set con = New Connection
Set rst = New Recordset
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With
If cno.Text = "" Then
MsgBox "find connection num"
Exit Sub
End If
If c_name.Text = "" Then
MsgBox "find connection num"
Exit Sub
End If

If rrt.Value = 0 And lbf.Value = 0 And cl.Value = 0 And wq.Value = 0 And lq.Value = 0 Then
MsgBox "Pease check type complaint "
Exit Sub
End If


If rrt.Value = 1 Then
    rrt1 = "true"
End If

If lbf.Value = 1 Then
    lbf1 = "true"
End If

If cl.Value = 1 Then
    cl1 = "true"
End If

If wq.Value = 1 Then
    wq1 = "true"
End If

If lq.Value = 1 Then
    lq1 = "true"
End If

sql = "insert into complaint(consumer_no,date_comp_rec,rep_rubber_tube,low_burning,water_quantity,low_lpg,c_leakage)values(" & CLng(cno.Text) & ",'" & Trim(date1.Text) & "'," & rrt1 & "," & lbf1 & "," & wq1 & "," & lq1 & "," & cl1 & ")"

con.Execute (sql)


cno.Text = ""
c_name.Text = ""
add.Text = ""
date1.Text = ""
rrt.Value = 0
lbf.Value = 0
cl.Value = 0
wq.Value = 0
lq.Value = 0
End Sub

Private Sub cno_LostFocus()
b = cno.Text
End Sub

Private Sub Form_Load()
    rrt1 = "false"
    lbf1 = "false"
    cl1 = "false"
    wq1 = "false"
    lq1 = "false"



End Sub
