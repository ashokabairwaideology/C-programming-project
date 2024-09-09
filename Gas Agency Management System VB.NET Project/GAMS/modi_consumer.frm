VERSION 5.00
Begin VB.Form Form12 
   BackColor       =   &H00FF8080&
   Caption         =   "Form12"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   ControlBox      =   0   'False
   LinkTopic       =   "Form12"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton CMDCLEAR 
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
      Left            =   6720
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   7800
      Width           =   1335
   End
   Begin VB.CommandButton Cmdfind 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&FIND"
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
      Left            =   1320
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   7800
      Width           =   1335
   End
   Begin VB.TextBox sex 
      Height          =   285
      Left            =   3480
      TabIndex        =   9
      Top             =   6600
      Width           =   1575
   End
   Begin VB.TextBox occu 
      Height          =   285
      Left            =   3480
      TabIndex        =   8
      Top             =   6240
      Width           =   1575
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
      Left            =   3120
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   7800
      Width           =   1455
   End
   Begin VB.CommandButton Cmdback 
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
      Left            =   5040
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   7800
      Width           =   1455
   End
   Begin VB.TextBox f_member 
      Height          =   285
      Left            =   3480
      TabIndex        =   7
      Top             =   5880
      Width           =   1575
   End
   Begin VB.TextBox zipcode 
      Height          =   285
      Left            =   3480
      TabIndex        =   4
      Top             =   4800
      Width           =   1575
   End
   Begin VB.TextBox city 
      Height          =   285
      Left            =   3480
      TabIndex        =   6
      Top             =   5520
      Width           =   1575
   End
   Begin VB.TextBox phone 
      Height          =   285
      Left            =   3480
      TabIndex        =   5
      Top             =   5160
      Width           =   1575
   End
   Begin VB.TextBox caddress 
      Height          =   285
      Left            =   3480
      TabIndex        =   3
      Top             =   4440
      Width           =   4335
   End
   Begin VB.TextBox c_name 
      Height          =   285
      Left            =   3600
      TabIndex        =   2
      Top             =   3120
      Width           =   3975
   End
   Begin VB.TextBox cno 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3600
      TabIndex        =   0
      Top             =   2400
      Width           =   1455
   End
   Begin VB.TextBox sno 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3600
      TabIndex        =   1
      Top             =   2760
      Width           =   1455
   End
   Begin VB.Label Label9 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Occupation"
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
      TabIndex        =   24
      Top             =   6240
      Width           =   1695
   End
   Begin VB.Label Label7 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Sex"
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
      TabIndex        =   23
      Top             =   6600
      Width           =   1695
   End
   Begin VB.Label Label11 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Family Member"
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
      TabIndex        =   22
      Top             =   5880
      Width           =   1695
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
      Left            =   3120
      TabIndex        =   13
      Top             =   840
      Width           =   4410
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
      Left            =   3120
      TabIndex        =   21
      Top             =   840
      Width           =   4410
   End
   Begin VB.Label Label10 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Zip Code"
      Height          =   255
      Left            =   1200
      TabIndex        =   20
      Top             =   4800
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
      Left            =   1200
      TabIndex        =   19
      Top             =   5520
      Width           =   1455
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
      TabIndex        =   18
      Top             =   5160
      Width           =   1455
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
      Left            =   1320
      TabIndex        =   17
      Top             =   2760
      Width           =   1335
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
      Top             =   4440
      Width           =   1815
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
      Left            =   1320
      TabIndex        =   15
      Top             =   3120
      Width           =   1575
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Modify Consumer Detail"
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
      Left            =   3240
      TabIndex        =   14
      Top             =   1680
      Width           =   4185
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
      Left            =   1320
      TabIndex        =   12
      Top             =   2400
      Width           =   1575
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   480
      Top             =   1560
      Width           =   11175
   End
   Begin VB.Shape Shape3 
      BackColor       =   &H00E0E0E0&
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   3375
      Left            =   480
      Top             =   3960
      Width           =   11175
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H00E0E0E0&
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   3255
      Left            =   480
      Top             =   480
      Width           =   11175
   End
End
Attribute VB_Name = "Form12"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim con As Connection
Dim rst  As Recordset
Dim cmd As Command
Dim e As String
Public b As String


Private Sub Cmdclear_Click()
cno.Text = ""
sno.Text = ""
c_name.Text = ""
occu.Text = ""
sex.Text = ""
f_member.Text = ""
caddress.Text = ""
zipcode.Text = ""
phone.Text = ""
city.Text = ""
End Sub

Private Sub Command1_Click()


End Sub

Private Sub Cmdsubmit_Click()
If cno.Text = "" Then
    MsgBox "You must find first"
    Exit Sub
End If

Dim j As Object
             For Each j In Form12.Controls
                If TypeOf j Is TextBox Then
                    If j.Text = "" Then
                    MsgBox j.Name & "  can't be left blank"
                    j.SetFocus
                    Exit Sub
                    End If
                End If
             Next
Set cmd = New Command
cmd.ActiveConnection = con

cmd.CommandText = "update consumer_details  set consumer_no=" & CInt(cno.Text) & ",c_name='" & Trim(c_name.Text) & "',address='" & Trim(caddress.Text) & "', zipcode= " & CLng(Trim(zipcode.Text)) & ",phone=" & CLng(phone.Text) & ",city='" & Trim(city.Text) & "',f_member = " & CLng(f_member.Text) & ",occupation= '" & Trim(occu.Text) & "',sex='" & Trim(sex.Text) & "' where consumer_no=" & CInt(cno.Text) & ""
cmd.CommandType = adCmdText
cmd.Execute

cno.Text = ""
sno.Text = ""
c_name.Text = ""
occu.Text = ""
sex.Text = ""
f_member.Text = ""
caddress.Text = ""
zipcode.Text = ""
phone.Text = ""
city.Text = ""

End Sub

Private Sub Cmdback_Click()
Load Form6
Form6.Show
Unload Me
End Sub



Private Sub Cmdfind_Click()
On Error GoTo LB1
b = cno.Text
If cno.Text = "" Then
    b = InputBox("Enter consumer number.....")
    cno.Text = b
    
    If b = "" Then
        
        Exit Sub
    End If
    
   If charcheck(b) = 0 Then
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


rst.Open "select *  from consumer_details where consumer_details.consumer_no=" & CInt(cno.Text), con
If (rst.BOF = True) And (rst.EOF = True) Then
    MsgBox "record does not exist"
    cno.Text = ""
Else
    If rst.EOF = True Then
        sno.Text = rst!serial_no
        cno.Text = rst!consumer_no
        c_name.Text = rst!c_name
        caddress.Text = rst!address
        zipcode.Text = rst!zipcode
        phone.Text = rst!phone
        city.Text = rst!city
        occu.Text = rst!occupation
        sex.Text = rst!sex
        f_member.Text = rst!f_member
    Else
        sno.Text = rst!serial_no
        cno.Text = rst!consumer_no
        c_name.Text = rst!c_name
        caddress.Text = rst!address
        zipcode.Text = rst!zipcode
        phone.Text = rst!phone
        city.Text = rst!city
        occu.Text = rst!occupation
        sex.Text = rst!sex
        f_member.Text = rst!f_member
    End If
End If
LB1:
End Sub

Private Sub Form_Load()

Set con = New Connection
Set rst = New Recordset
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With


rst.Open "select *  from consumer_details where consumer_details.consumer_no=" & CInt(Form6.b), con
If (rst.BOF = True) And (rst.EOF = True) Then
    MsgBox "record does not exist"
    Unload Form12
    Exit Sub
Else
    If rst.EOF = True Then
        sno.Text = rst!serial_no
        cno.Text = rst!consumer_no
        c_name.Text = rst!c_name
        caddress.Text = rst!address
        zipcode.Text = rst!zipcode
        phone.Text = rst!phone
        city.Text = rst!city
        occu.Text = rst!occupation
        sex.Text = rst!sex
        f_member.Text = rst!f_member
    Else
        sno.Text = rst!serial_no
        cno.Text = rst!consumer_no
        c_name.Text = rst!c_name
        caddress.Text = rst!address
        zipcode.Text = rst!zipcode
        phone.Text = rst!phone
        city.Text = rst!city
        occu.Text = rst!occupation
        sex.Text = rst!sex
        f_member.Text = rst!f_member
    End If
End If
End Sub


