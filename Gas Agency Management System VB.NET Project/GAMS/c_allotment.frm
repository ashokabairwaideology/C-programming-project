VERSION 5.00
Begin VB.Form Form10 
   BackColor       =   &H00FF8080&
   Caption         =   "Form10"
   ClientHeight    =   8385
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11880
   ControlBox      =   0   'False
   FillColor       =   &H80000004&
   FillStyle       =   0  'Solid
   LinkTopic       =   "Form10"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8385
   ScaleWidth      =   11880
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
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
      Left            =   8760
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   3840
      Width           =   1455
   End
   Begin VB.TextBox regulator 
      Height          =   285
      Left            =   3240
      TabIndex        =   11
      Top             =   7080
      Width           =   1575
   End
   Begin VB.CommandButton cmdsave 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Save"
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
      Left            =   8760
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   3120
      Width           =   1455
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Next"
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
      Left            =   8760
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   2280
      Width           =   1455
   End
   Begin VB.TextBox sno 
      Height          =   285
      Left            =   3240
      TabIndex        =   0
      Top             =   1800
      Width           =   1695
   End
   Begin VB.TextBox cno 
      Height          =   285
      Left            =   3240
      TabIndex        =   2
      Top             =   2520
      Width           =   1695
   End
   Begin VB.TextBox cao 
      Height          =   285
      Left            =   3240
      TabIndex        =   8
      Top             =   5880
      Width           =   1575
   End
   Begin VB.TextBox flame 
      Height          =   285
      Left            =   3240
      TabIndex        =   10
      Top             =   6720
      Width           =   1575
   End
   Begin VB.TextBox total 
      Height          =   285
      Left            =   3240
      TabIndex        =   9
      Top             =   6360
      Width           =   1575
   End
   Begin VB.TextBox capp 
      Height          =   285
      Left            =   3240
      TabIndex        =   7
      Top             =   5520
      Width           =   1575
   End
   Begin VB.TextBox zcode 
      Height          =   285
      Left            =   3240
      TabIndex        =   4
      Top             =   3720
      Width           =   1575
   End
   Begin VB.TextBox city 
      Height          =   285
      Left            =   3240
      TabIndex        =   6
      Top             =   4560
      Width           =   1575
   End
   Begin VB.TextBox phone 
      Height          =   285
      Left            =   3240
      TabIndex        =   5
      Top             =   4200
      Width           =   1575
   End
   Begin VB.TextBox cadd 
      Height          =   285
      Left            =   3240
      TabIndex        =   3
      Top             =   3240
      Width           =   4335
   End
   Begin VB.TextBox cname 
      Height          =   285
      Left            =   3240
      TabIndex        =   1
      Top             =   2160
      Width           =   3975
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
      Left            =   960
      TabIndex        =   28
      Top             =   7080
      Width           =   1815
   End
   Begin VB.Label Label5 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Cno."
      Height          =   255
      Left            =   960
      TabIndex        =   27
      Top             =   2520
      Width           =   1575
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
      Left            =   960
      TabIndex        =   26
      Top             =   5880
      Width           =   2055
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
      Left            =   960
      TabIndex        =   25
      Top             =   6720
      Width           =   1815
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
      Left            =   960
      TabIndex        =   23
      Top             =   6360
      Width           =   1815
   End
   Begin VB.Label Label12 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Connection  Applied On"
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
      Left            =   960
      TabIndex        =   22
      Top             =   5520
      Width           =   2175
   End
   Begin VB.Label Label10 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Zip Code"
      Height          =   255
      Left            =   960
      TabIndex        =   21
      Top             =   3720
      Width           =   1695
   End
   Begin VB.Label Label8 
      BackColor       =   &H00E0E0E0&
      Caption         =   "City"
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
      Left            =   960
      TabIndex        =   20
      Top             =   4560
      Width           =   1815
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
      Left            =   960
      TabIndex        =   19
      Top             =   4200
      Width           =   1575
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
      Left            =   960
      TabIndex        =   18
      Top             =   3240
      Width           =   2055
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
      Left            =   960
      TabIndex        =   17
      Top             =   2160
      Width           =   1815
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Connection Allotment"
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
      Left            =   4080
      TabIndex        =   16
      Top             =   1080
      Width           =   3735
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
      Left            =   3480
      TabIndex        =   15
      Top             =   360
      Width           =   4410
   End
   Begin VB.Label Label15 
      BackColor       =   &H00E0E0E0&
      Caption         =   "S.No."
      Height          =   255
      Left            =   960
      TabIndex        =   14
      Top             =   1800
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
      Left            =   3480
      TabIndex        =   24
      Top             =   360
      Width           =   4410
   End
   Begin VB.Shape Shape3 
      BackColor       =   &H00E0E0E0&
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2055
      Left            =   240
      Top             =   3000
      Width           =   11175
   End
   Begin VB.Shape Shape4 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2415
      Left            =   240
      Top             =   5160
      Width           =   11175
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   240
      Top             =   960
      Width           =   11175
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2655
      Left            =   240
      Top             =   240
      Width           =   11175
   End
End
Attribute VB_Name = "Form10"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim con As Connection
Dim rst As Recordset
Dim cmd As Command

Private Sub cmdsave_Click()
If cno.Text = "" Then
MsgBox "Enter consumer number"
cno.SetFocus
Exit Sub
End If

If flame.Text = "" Then
MsgBox "Enter flame"
flame.SetFocus
Exit Sub
End If

If regulator.Text = "" Then
MsgBox "Enter regulator"
regulator.SetFocus
Exit Sub
End If
Set cmd = New Command
cmd.ActiveConnection = con
cmd.CommandText = "update connection cn,consumer_details cd set cn.consumer_no=" & CInt(cno.Text) & ",cd.consumer_no=" & CInt(cno.Text) & ",date_alloted_on='" & cao.Text & "',cylinders=" & CLng(total.Text) & ",regulator=" & CInt(regulator.Text) & ",flame=" & CLng(flame.Text) & " where cd.serial_no=" & CInt(sno.Text) & " and cn.serial_no=" & CInt(sno.Text)
cmd.CommandType = adCmdText
cmd.Execute
rst.Requery
sno.Text = ""
cno.Text = ""
cname.Text = ""
cadd.Text = ""
zcode.Text = ""
phone.Text = ""
city.Text = ""
capp.Text = ""
cao.Text = ""
total.Text = ""
flame.Text = ""
regulator.Text = ""
End Sub

Private Sub Command1_Click()


If rst.EOF = True And rst.BOF = True Then
    MsgBox "No records.................."
    Exit Sub
End If

If rst.EOF = True Then
MsgBox "no more record"
    rst.MoveFirst
sno.Text = rst!serial_no
cname = rst!c_name
cadd.Text = rst!address
zcode.Text = rst!zipcode
phone.Text = rst!phone
city.Text = rst!city
capp.Text = rst!date_applied_on
cao.Text = Date
rst.MoveNext
Else
'MsgBox "rst.eof=false"

sno.Text = rst!serial_no
cname = rst!c_name
cadd.Text = rst!address
zcode.Text = rst!zipcode
phone.Text = rst!phone
city.Text = rst!city
capp.Text = rst!date_applied_on
cao.Text = Date
rst.MoveNext

End If


End Sub

Private Sub Command2_Click()
Unload Me
Load Form2
Form2.Show
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

rst.Open "select *  from consumer_details cs ,connection cn  " & _
"Where cs.serial_no = cn.serial_no And cs.consumer_no Is Null" & _
" and datediff(" & "'y',cn.date_applied_on,now())>=15", con



sno.Text = rst!serial_no
cname = rst!c_name
cadd.Text = rst!address
zcode.Text = rst!zipcode
phone.Text = rst!phone
city.Text = rst!city
capp.Text = rst!date_applied_on
cao.Text = Date
total.Text = rst!cylinders


End Sub


