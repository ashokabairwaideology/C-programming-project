VERSION 5.00
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form Form14 
   BackColor       =   &H00FF8080&
   Caption         =   "Form14"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   ControlBox      =   0   'False
   LinkTopic       =   "Form14"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.TextBox tr 
      Height          =   495
      Left            =   3600
      TabIndex        =   10
      Top             =   5880
      Width           =   4455
   End
   Begin VB.TextBox ta 
      Height          =   285
      Left            =   3600
      TabIndex        =   8
      Top             =   5040
      Width           =   2895
   End
   Begin VB.TextBox address 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3600
      TabIndex        =   4
      Top             =   3960
      Width           =   4335
   End
   Begin VB.TextBox phone 
      Enabled         =   0   'False
      Height          =   285
      Left            =   8400
      TabIndex        =   6
      Top             =   4320
      Width           =   1575
   End
   Begin VB.TextBox city 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3600
      TabIndex        =   7
      Top             =   4680
      Width           =   1575
   End
   Begin VB.TextBox zipcode 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3600
      TabIndex        =   5
      Top             =   4320
      Width           =   1575
   End
   Begin VB.CommandButton Cmdcancel 
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
      Left            =   5160
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   7320
      Width           =   1455
   End
   Begin VB.CommandButton Cmdtransfer 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Transfer"
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
      Left            =   3240
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   7320
      Width           =   1455
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
      Left            =   1320
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   7320
      Width           =   1455
   End
   Begin VB.TextBox sno 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3720
      TabIndex        =   1
      Top             =   2400
      Width           =   1455
   End
   Begin VB.TextBox cno 
      Height          =   285
      Left            =   3720
      TabIndex        =   0
      Top             =   2040
      Width           =   1455
   End
   Begin VB.TextBox cname 
      Enabled         =   0   'False
      Height          =   285
      Left            =   3720
      TabIndex        =   3
      Top             =   2760
      Width           =   3975
   End
   Begin MSMask.MaskEdBox t_on 
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
      Left            =   3600
      TabIndex        =   9
      Top             =   5400
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
   Begin VB.Label Label11 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Transfered reason"
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
      TabIndex        =   25
      Top             =   5760
      Width           =   2175
   End
   Begin VB.Label Label9 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Transfered on"
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
      TabIndex        =   24
      Top             =   5400
      Width           =   1935
   End
   Begin VB.Label Label7 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Transfered at"
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
      TabIndex        =   23
      Top             =   5040
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
      Left            =   1320
      TabIndex        =   22
      Top             =   3960
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
      Left            =   6600
      TabIndex        =   21
      Top             =   4320
      Width           =   1455
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
      Left            =   1320
      TabIndex        =   20
      Top             =   4680
      Width           =   1455
   End
   Begin VB.Label Label10 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Zip Code"
      Height          =   255
      Left            =   1320
      TabIndex        =   19
      Top             =   4320
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
      Left            =   3360
      TabIndex        =   2
      Top             =   480
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
      Left            =   1440
      TabIndex        =   18
      Top             =   2040
      Width           =   1575
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00008000&
      Caption         =   "Connection Transfer"
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
      Left            =   3720
      TabIndex        =   17
      Top             =   1320
      Width           =   3570
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
      Left            =   1440
      TabIndex        =   16
      Top             =   2760
      Width           =   1575
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
      Left            =   1440
      TabIndex        =   15
      Top             =   2400
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
      Left            =   3360
      TabIndex        =   14
      Top             =   480
      Width           =   4410
   End
   Begin VB.Shape Shape3 
      BackColor       =   &H00E0E0E0&
      BackStyle       =   1  'Opaque
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   3375
      Left            =   600
      Top             =   3480
      Width           =   11175
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   600
      Top             =   1200
      Width           =   11175
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H00E0E0E0&
      BackStyle       =   1  'Opaque
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   3255
      Left            =   600
      Top             =   120
      Width           =   11175
   End
End
Attribute VB_Name = "Form14"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim b As String
Private Sub Command1_Click()

End Sub

Private Sub Command3_Click()
End Sub

Private Sub Cmdcancel_Click()
Load Form1
Form1.Show
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

If charcheck(b) = 0 Then
    MsgBox "No Record found........"
    cno.SetFocus
    Exit Sub
End If


If cno.Text = "" Then
'cno.Text = InputBox("Enter consumer no")
MsgBox " Please Enter consumer no"
cno.SetFocus
Exit Sub
End If

'On Error GoTo LB1
Set rst = New Recordset
rst.Open "select *  from consumer_details where consumer_details.consumer_no=" & CInt(cno.Text), con

If rst.EOF = True And rst.BOF = True Then
    MsgBox "No match found..........."
    Exit Sub
Else
sno.Text = rst!serial_no
cname.Text = rst!c_name
address.Text = rst!address
phone.Text = rst!phone
city.Text = rst!city
zipcode.Text = rst!zipcode

End If

End Sub

Private Sub Cmdtransfer_Click()
Set con = New Connection
Set smd = New Command
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With
If cname.Text = "" Then
MsgBox "Please find  record"
cno.SetFocus
Exit Sub

Else
Dim j As Object
             For Each j In Form14.Controls
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
                
      Next
  End If
sql = "insert into transfer(serial_no,consumer_no,c_name,address,zipcode,phone,city,transfered_at,transfered_on,transfered_reason)values(" & CLng(sno.Text) & "," & CLng(cno.Text) & ",'" & Trim(cname.Text) & "','" & Trim(address.Text) & "'," & CLng(zipcode.Text) & "," & CLng(phone.Text) & ",'" & Trim(city.Text) & "','" & Trim(ta.Text) & "','" & t_on.Text & "','" & Trim(tr.Text) & "')"
con.BeginTrans
con.Execute (sql)
con.CommitTrans

'*****************delete record from conjumer_details,connection,complaint,refill**********
'cno.Refresh
a = cno.Text
sql = "DELETE from consumer_details  where consumer_no=" & CInt(a)
sql1 = "DELETE from connection  where consumer_no=" & CInt(a)
sql2 = "DELETE from complaint  where consumer_no=" & CInt(a)
sql3 = "DELETE from refill where consumer_no=" & CInt(a)

con.Execute (sql)
con.Execute (sql1)
con.Execute (sql2)
con.Execute (sql3)


sno.Text = ""
cno.Text = ""
cname.Text = ""
address.Text = ""
phone.Text = ""
city.Text = ""
zipcode.Text = ""
t_on.Text = "--/--/----"
tr.Text = ""
ta.Text = ""

End Sub

Private Sub cno_Change()
b = cno.Text
End Sub
