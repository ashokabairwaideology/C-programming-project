VERSION 5.00
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form3 
   BackColor       =   &H00FF8080&
   Caption         =   "Indian Gas Service"
   ClientHeight    =   8595
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10605
   ControlBox      =   0   'False
   FillStyle       =   0  'Solid
   LinkTopic       =   "Form3"
   ScaleHeight     =   8595
   ScaleWidth      =   10605
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.TextBox Text2 
      DataField       =   "Expr1000"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   1920
      TabIndex        =   29
      Text            =   "hi"
      Top             =   8160
      Visible         =   0   'False
      Width           =   615
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   480
      Top             =   8160
      Visible         =   0   'False
      Width           =   1200
      _ExtentX        =   2117
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   1
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=MSDASQL.1;Persist Security Info=False;Data Source=gasdata;Initial Catalog=E:\GAS\consumer"
      OLEDBString     =   "Provider=MSDASQL.1;Persist Security Info=False;Data Source=gasdata;Initial Catalog=E:\GAS\consumer"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select max(serial_no) from consumer_details"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.TextBox Text1 
      Height          =   495
      Left            =   9000
      TabIndex        =   28
      Text            =   "Text1"
      Top             =   120
      Width           =   975
   End
   Begin MSMask.MaskEdBox date_applied_on 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "MM/dd/yyyy"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   3
      EndProperty
      Height          =   375
      Left            =   3000
      TabIndex        =   9
      Top             =   6120
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   661
      _Version        =   393216
      AllowPrompt     =   -1  'True
      MaxLength       =   10
      Format          =   "mm-dd-yyyy"
      Mask            =   "##/##/####"
      PromptChar      =   "-"
   End
   Begin VB.CommandButton Command3 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Refresh"
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
      Left            =   10080
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   1800
      Width           =   1455
   End
   Begin VB.TextBox connection_charge 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3000
      TabIndex        =   12
      Text            =   "700"
      Top             =   7560
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
      Left            =   10080
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   3720
      Width           =   1455
   End
   Begin VB.CommandButton Command1 
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
      Left            =   10080
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   2760
      Width           =   1455
   End
   Begin VB.TextBox deposit_amt 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3000
      TabIndex        =   11
      Top             =   7080
      Width           =   1575
   End
   Begin VB.TextBox cylinders 
      Height          =   285
      Left            =   3000
      TabIndex        =   10
      Top             =   6600
      Width           =   1575
   End
   Begin VB.TextBox f_member 
      Height          =   285
      Left            =   3000
      TabIndex        =   4
      Top             =   2520
      Width           =   1575
   End
   Begin VB.TextBox zipcode 
      Height          =   285
      Left            =   3000
      TabIndex        =   6
      Top             =   4200
      Width           =   1575
   End
   Begin VB.TextBox city 
      Height          =   285
      Left            =   3000
      TabIndex        =   8
      Top             =   5160
      Width           =   1575
   End
   Begin VB.TextBox phone 
      Height          =   285
      Left            =   3000
      TabIndex        =   7
      Top             =   4680
      Width           =   1575
   End
   Begin VB.ComboBox sex 
      Height          =   315
      ItemData        =   "c_detail.frx":0000
      Left            =   3000
      List            =   "c_detail.frx":000A
      TabIndex        =   3
      Top             =   2040
      Width           =   1575
   End
   Begin VB.TextBox caddress 
      Height          =   285
      Left            =   3000
      TabIndex        =   5
      Top             =   3720
      Width           =   4335
   End
   Begin VB.TextBox occupation 
      Height          =   285
      Left            =   3000
      TabIndex        =   2
      Top             =   1560
      Width           =   3975
   End
   Begin VB.TextBox c_name 
      Height          =   285
      Left            =   3000
      TabIndex        =   1
      Top             =   1080
      Width           =   3975
   End
   Begin VB.Label Label15 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Connection Charge"
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
      Left            =   720
      TabIndex        =   27
      Top             =   7560
      Width           =   1455
   End
   Begin VB.Label Label14 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Deposit Amount"
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
      Left            =   720
      TabIndex        =   26
      Top             =   7080
      Width           =   1935
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
      Left            =   720
      TabIndex        =   25
      Top             =   6600
      Width           =   2175
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
      Left            =   720
      TabIndex        =   24
      Top             =   6120
      Width           =   2175
   End
   Begin VB.Shape Shape3 
      BackColor       =   &H00E0E0E0&
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2175
      Left            =   480
      Top             =   5880
      Width           =   9255
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
      Left            =   720
      TabIndex        =   23
      Top             =   2520
      Width           =   1695
   End
   Begin VB.Label Label10 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Zip Code"
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
      Left            =   720
      TabIndex        =   22
      Top             =   4200
      Width           =   1695
   End
   Begin VB.Label Label9 
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
      Height          =   375
      Left            =   720
      TabIndex        =   21
      Top             =   2040
      Width           =   1335
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
      Left            =   720
      TabIndex        =   20
      Top             =   5160
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
      Left            =   720
      TabIndex        =   19
      Top             =   4680
      Width           =   1695
   End
   Begin VB.Label Label5 
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
      Height          =   375
      Left            =   720
      TabIndex        =   18
      Top             =   1560
      Width           =   1935
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
      Left            =   720
      TabIndex        =   17
      Top             =   3720
      Width           =   1935
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
      Left            =   720
      TabIndex        =   16
      Top             =   1080
      Width           =   1935
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Form For New Connection "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   435
      Left            =   480
      TabIndex        =   0
      Top             =   120
      Width           =   4170
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H00E0E0E0&
      BorderColor     =   &H80000007&
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2655
      Left            =   480
      Top             =   720
      Width           =   9255
   End
   Begin VB.Shape address 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2295
      Left            =   480
      Top             =   3480
      Width           =   9255
   End
End
Attribute VB_Name = "Form3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim con As Connection
Dim rst As Recordset
Dim rst1 As Recordset
Dim com As Command

Private Sub Command1_Click()

          Dim j As Object
             For Each j In Form3.Controls
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
sql = "insert into consumer_details(serial_no,c_name,occupation,f_member,address,zipcode,phone,city,sex )" & _
" values(" & CInt(Text1.Text) & ",'" & Trim(c_name.Text) & "','" & Trim(occupation.Text) & "'," & CLng(f_member.Text) & ",'" & Trim(caddress.Text) & "'," & CLng(zipcode.Text) & "," & CLng(phone.Text) & ",'" & Trim(city.Text) & "','" & Trim(sex.Text) & "')"

sql1 = "insert into connection(serial_no,date_applied_on,cylinders,deposit_amt,connection_charge)" & _
"values (" & CInt(Text1.Text) & ",'" & date_applied_on.Text & "'," & CLng(cylinders.Text) & "," & CLng(deposit_amt) & "," & CLng(connection_charge.Text) & ")"

con.Execute (sql)
con.Execute (sql1)

c_name.Text = ""
occupation.Text = ""
sex.Text = ""
f_member.Text = ""
caddress.Text = ""
zipcode.Text = ""
phone.Text = ""
city.Text = ""
date_applied_on.Text = "--/--/----"
cylinders.Text = ""
deposit_amt.Text = ""
connection_charge.Text = ""
End Sub

Private Sub Command2_Click()
Load Form2
Form2.Show
Unload Me
End Sub

Private Sub Command3_Click()
Command1.Enabled = True
connection_charge.Text = "700"
Text1.Refresh
Unload Me
Load Form3
Form3.Show
End Sub

Private Sub cylinders_LostFocus()
If cylinders.Text = "" Then
    MsgBox "Enter number of cylinders :"
    Exit Sub
Else
deposit_amt.Text = CInt(cylinders.Text) * CInt(connection_charge.Text) + 2000
End If
End Sub

Private Sub Form_Load()
Set con = New Connection
Set rst = New Recordset

With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL.1"
.Open
End With

rst.Open "select * from consumer_details", con, adOpenDynamic


    If rst.EOF = True And rst.BOF = True Then
    MsgBox "less"
        Text1.Text = 1
        Text2.Text = 1
    Else
        num = Text2.Text
        num = CInt(num) + 1
        Text1.Text = num
    End If
End Sub
