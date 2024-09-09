VERSION 5.00
Begin VB.Form Form13 
   BackColor       =   &H00FF8080&
   Caption         =   "Form13"
   ClientHeight    =   5625
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6960
   ControlBox      =   0   'False
   LinkTopic       =   "Form13"
   ScaleHeight     =   5625
   ScaleWidth      =   6960
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
      Left            =   6360
      Style           =   1  'Graphical
      TabIndex        =   24
      Top             =   7920
      Width           =   1335
   End
   Begin VB.CommandButton Cmdfind 
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
      Left            =   840
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   7920
      Width           =   1335
   End
   Begin VB.TextBox dateapp 
      Enabled         =   0   'False
      Height          =   375
      Left            =   3120
      TabIndex        =   3
      Top             =   4200
      Width           =   1575
   End
   Begin VB.TextBox dateall 
      Enabled         =   0   'False
      Height          =   375
      Left            =   3120
      TabIndex        =   2
      Top             =   3720
      Width           =   1575
   End
   Begin VB.TextBox c_charge 
      Height          =   285
      Left            =   3120
      TabIndex        =   8
      Top             =   6720
      Width           =   1575
   End
   Begin VB.TextBox cylinders 
      Height          =   285
      Left            =   3120
      TabIndex        =   4
      Top             =   4800
      Width           =   1575
   End
   Begin VB.TextBox flame 
      Height          =   285
      Left            =   3120
      TabIndex        =   5
      Top             =   5280
      Width           =   1575
   End
   Begin VB.TextBox regulator 
      Height          =   285
      Left            =   3120
      TabIndex        =   6
      Top             =   5760
      Width           =   1575
   End
   Begin VB.TextBox damt 
      Height          =   285
      Left            =   3120
      TabIndex        =   7
      Top             =   6240
      Width           =   1575
   End
   Begin VB.TextBox sno 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3120
      TabIndex        =   1
      Top             =   2280
      Width           =   1455
   End
   Begin VB.TextBox cno 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3120
      TabIndex        =   0
      Top             =   1920
      Width           =   1455
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
      Left            =   4560
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   7920
      Width           =   1455
   End
   Begin VB.CommandButton Cmdsubmit 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Submit"
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
      Left            =   2640
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   7920
      Width           =   1455
   End
   Begin VB.Label Label3 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Connection Chagres"
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
      Left            =   840
      TabIndex        =   22
      Top             =   6720
      Width           =   1815
   End
   Begin VB.Label Label13 
      BackColor       =   &H00E0E0E0&
      Caption         =   "No. Of Cylinders"
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
      Left            =   840
      TabIndex        =   21
      Top             =   4800
      Width           =   1815
   End
   Begin VB.Label Label12 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Date Applied On"
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
      Left            =   840
      TabIndex        =   20
      Top             =   4320
      Width           =   1815
   End
   Begin VB.Label Label11 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Date Alloted On"
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
      Left            =   840
      TabIndex        =   19
      Top             =   3840
      Width           =   1695
   End
   Begin VB.Label Label7 
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
      Left            =   840
      TabIndex        =   18
      Top             =   5280
      Width           =   1815
   End
   Begin VB.Label Label16 
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
      Left            =   840
      TabIndex        =   17
      Top             =   5760
      Width           =   1815
   End
   Begin VB.Label Label17 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Deposit_amt"
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
      Left            =   840
      TabIndex        =   16
      Top             =   6240
      Width           =   1815
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
      Left            =   2760
      TabIndex        =   10
      Top             =   360
      Width           =   4410
   End
   Begin VB.Label Label15 
      BackColor       =   &H00E0E0E0&
      Caption         =   "C .No."
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
      Left            =   840
      TabIndex        =   15
      Top             =   1920
      Width           =   1575
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Modify Conection Detail"
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
      Left            =   2760
      TabIndex        =   14
      Top             =   1200
      Width           =   4170
   End
   Begin VB.Label Label5 
      BackColor       =   &H00E0E0E0&
      Caption         =   "S.No"
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
      Left            =   840
      TabIndex        =   13
      Top             =   2280
      Width           =   1335
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
      Left            =   2760
      TabIndex        =   12
      Top             =   360
      Width           =   4410
   End
   Begin VB.Shape Shape3 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   4095
      Left            =   -120
      Top             =   3480
      Width           =   11175
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   0
      Top             =   1080
      Width           =   11175
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2895
      Left            =   0
      Top             =   0
      Width           =   11175
   End
End
Attribute VB_Name = "Form13"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim con As Connection
Dim rst  As Recordset
Public C As String

Private Sub Cmdsubmit_Click()
If cno.Text = "" Then
    MsgBox "You must find first"
    Exit Sub
End If

Set con = New Connection
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With


          Dim j As Object
             For Each j In Form13.Controls
                If TypeOf j Is TextBox Then
                    If j.Text = "" Then
                    MsgBox j.Name & "  can't be left blank"
                    j.SetFocus
                    Exit Sub
                    End If
                End If
                
                If TypeOf j Is MaskEdBox Then
                    If j.Text = "--/--/----" Then
                    MsgBox j.Name & "  can't be left blank"
                    j.SetFocus
                    
                    Exit Sub
                    End If
                    
                End If
                
                If TypeOf j Is ComboBox Then
                    If j.Text = "" Then
                    MsgBox j.Name & "  can't be left blank"
                    j.SetFocus
                    Exit Sub
                    End If
                    
                End If
                
                
                
        Next

sql = "update connection set cylinders=" & CInt(cylinders.Text) & ",regulator=" & CInt(regulator.Text) & ",flame=" & CInt(flame.Text) & ",deposit_amt=" & CLng(damt.Text) & ",connection_charge=" & CInt(c_charge.Text) & " where consumer_no=" & CInt(cno.Text) & ""
con.Execute (sql)

Command1.Enabled = False

cno.Text = ""
sno.Text = ""
dateall.Text = "--/--/----"
dateapp.Text = "--/--/----"
cylinders.Text = ""
damt.Text = ""
c_charge.Text = ""
flame.Text = ""
regulator.Text = ""
End Sub

Private Sub Command2_Click()
Unload Me
Load Form6
Form6.Show
End Sub

Private Sub Cmdfind_Click()
On Error GoTo LB2
C = cno.Text
If cno.Text = "" Then
    C = InputBox("Enter Consuner No", "Find to Modify")
    cno.Text = C
    If C = "" Then
        Exit Sub
    End If
    
    If charcheck(C) = 0 Then
        MsgBox "No Record found........"
        cno.Text = ""
        Exit Sub
    End If
Else
    MsgBox "You must to Use Clear button to Empty record  "
    Exit Sub
End If


Set con = New Connection
Set rst = New Recordset
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With
Set rst = New Recordset
rst.Open "select *  from connection  where connection.consumer_no=" & CInt(cno.Text), con
If (rst.BOF = True) And (rst.EOF = True) Then
    MsgBox "record does not exist"
    cno.Text = ""
Else
 
sno.Text = rst!serial_no
cno.Text = rst!consumer_no
dateall.Text = rst!date_alloted_on
dateapp.Text = rst!date_applied_on
cylinders.Text = rst!cylinders
flame.Text = rst!flame
regulator.Text = rst!regulator
damt.Text = rst!deposit_amt
c_charge.Text = rst!connection_charge



End If
LB2:
End Sub

Private Sub Cmdclear_Click()
cno.Text = ""
sno.Text = ""
dateall.Text = "--/--/----"
dateapp.Text = "--/--/----"
cylinders.Text = ""
damt.Text = ""
c_charge.Text = ""
flame.Text = ""
regulator.Text = ""
End Sub

Private Sub Form_Load()

Set con = New Connection
Set rst = New Recordset
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With
Set rst = New Recordset
rst.Open "select *  from connection  where connection.consumer_no=" & CInt(Form6.C), con
If (rst.BOF = True) And (rst.EOF = True) Then
    MsgBox "record does not exist"
    Unload Form13
    Exit Sub
Else
   ' If rst.EOF = True Then
sno.Text = rst!serial_no
cno.Text = rst!consumer_no
dateall.Text = rst!date_alloted_on
dateapp.Text = rst!date_applied_on
cylinders.Text = rst!cylinders
flame.Text = rst!flame
regulator.Text = rst!regulator
damt.Text = rst!deposit_amt
c_charge.Text = rst!connection_charge

'Else

End If
'End If
End Sub


