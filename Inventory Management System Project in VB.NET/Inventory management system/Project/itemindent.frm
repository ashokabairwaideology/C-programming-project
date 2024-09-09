VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   240
      Top             =   5040
      Visible         =   0   'False
      Width           =   1815
      _ExtentX        =   3201
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   3
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "DSN=inventory"
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   "inventory"
      OtherAttributes =   ""
      UserName        =   "scott"
      Password        =   "tiger"
      RecordSource    =   "ITEM"
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
   Begin VB.CommandButton cmdfind 
      Caption         =   "&Find"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5520
      TabIndex        =   13
      Top             =   5400
      Width           =   1215
   End
   Begin VB.CommandButton cmddelete 
      Caption         =   "&Delete"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4200
      TabIndex        =   12
      Top             =   5400
      Width           =   1215
   End
   Begin VB.CommandButton cmdmodify 
      Caption         =   "&Modify"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6840
      TabIndex        =   11
      Top             =   4680
      Width           =   1095
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Bindings        =   "itemindent.frx":0000
      DataField       =   "ITEMCODE"
      DataSource      =   "Adodc1"
      Height          =   315
      Left            =   840
      TabIndex        =   5
      Top             =   3720
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "ITEMCODE"
      Text            =   ""
   End
   Begin VB.TextBox txtdreq 
      Height          =   375
      Left            =   6960
      TabIndex        =   8
      Top             =   3720
      Width           =   1575
   End
   Begin VB.TextBox txtrate 
      Height          =   375
      Left            =   4680
      TabIndex        =   7
      Top             =   3720
      Width           =   1575
   End
   Begin VB.TextBox txtqty 
      Height          =   375
      Left            =   2640
      TabIndex        =   6
      Top             =   3720
      Width           =   1575
   End
   Begin VB.TextBox txtdept 
      Height          =   375
      Left            =   6480
      TabIndex        =   1
      Top             =   840
      Width           =   1695
   End
   Begin VB.TextBox txtino 
      Height          =   375
      Left            =   2040
      TabIndex        =   0
      Top             =   840
      Width           =   1455
   End
   Begin VB.TextBox txtindor 
      Height          =   375
      Left            =   4080
      TabIndex        =   2
      Top             =   1560
      Width           =   1695
   End
   Begin VB.TextBox txtindate 
      Height          =   375
      Left            =   4080
      TabIndex        =   3
      Top             =   2040
      Width           =   1695
   End
   Begin VB.TextBox txttotval 
      Height          =   375
      Left            =   4080
      TabIndex        =   4
      Top             =   2520
      Width           =   1695
   End
   Begin VB.CommandButton cmdSAVE 
      Caption         =   "&Save"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5520
      TabIndex        =   10
      Top             =   4680
      Width           =   1215
   End
   Begin VB.CommandButton cmdNEW 
      Caption         =   "&New"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4200
      TabIndex        =   9
      Top             =   4680
      Width           =   1215
   End
   Begin VB.CommandButton cmdEXIT 
      Caption         =   "&Exit"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6840
      TabIndex        =   14
      Top             =   5400
      Width           =   1095
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      Caption         =   "Date of Request"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   6960
      TabIndex        =   24
      Top             =   3240
      Width           =   1695
   End
   Begin VB.Label Label8 
      AutoSize        =   -1  'True
      Caption         =   "Rate"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   5160
      TabIndex        =   23
      Top             =   3240
      Width           =   510
   End
   Begin VB.Label Label7 
      AutoSize        =   -1  'True
      Caption         =   "Quantity"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   2880
      TabIndex        =   22
      Top             =   3240
      Width           =   855
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      Caption         =   "Item Code"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   960
      TabIndex        =   21
      Top             =   3240
      Width           =   1065
   End
   Begin VB.Label Label10 
      AutoSize        =   -1  'True
      Caption         =   "Department"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   5040
      TabIndex        =   20
      Top             =   840
      Width           =   1215
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   9480
      Y1              =   1320
      Y2              =   1320
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "Total Estimated Value"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   1680
      TabIndex        =   19
      Top             =   2640
      Width           =   2310
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Indent Date"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   1680
      TabIndex        =   18
      Top             =   2040
      Width           =   1200
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Indentor"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   1680
      TabIndex        =   17
      Top             =   1560
      Width           =   855
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Indent No"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   600
      TabIndex        =   16
      Top             =   840
      Width           =   1005
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY ITEMS INDENT"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   360
      Left            =   2400
      TabIndex        =   15
      Top             =   0
      Width           =   4050
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim clmod As New inventclass
Dim bool As Boolean
Dim ed1%
Private Sub cmddelete_Click()
Dim d%
cmdfind_Click
If bool = False Then Exit Sub
d = MsgBox("Dou You want to Delete then Current Record", vbYesNo)
If d = vbYes Then
 indrs.Delete
 indrs.Requery
 Call clmod.clr(Me)
 txtINO.Enabled = False
 txtindate.Enabled = False
 txttotval.Enabled = False
End If
End Sub
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
bool = True
Dim f$
f = InputBox("Enter Indent No that you want Find", vbYesNo)
If Not IsNumeric(f) And f = "" Then Exit Sub
indrs.MoveFirst
indrs.Find "indantno=" & f
If Not indrs.EOF Then
 txtINO = indrs("INDaNTNO")
 txtindate = indrs("INDATE")
 txtindor = indrs("INDENTOR")
 txttotval = indrs("TOT_EST_VAL")
 txtDEPT = indrs("dept")
 DataCombo1.Text = indrs("itemcode")
 txtqty = indrs("qty")
 txtdreq = indrs("dt_req")
 txtrate = indrs("rate")
Else
   MsgBox "Record Does Not Exists"
   bool = False
   Exit Sub
End If
End Sub
Private Sub cmdmodify_Click()
cmdfind_Click
Call clmod.enbt(Me)
txtINO.Enabled = False
txtindate.Enabled = False
txttotval.Enabled = False
ed1 = 0
End Sub
Private Sub cmdnew_Click()
Call clmod.clall(Me)
Dim a%
If indrs.RecordCount = 0 Then
a = 101
Else
indrs.MoveLast
a = indrs("INDaNTNO") + 1
End If
txtINO = a
txtindate.Text = Date
Call clmod.enbt(Me)
txtINO.Enabled = False
txtindate.Enabled = False
txttotval.Enabled = False
txtDEPT.SetFocus
ed1 = 1
End Sub
Private Sub cmdSAVE_Click()
Dim x%
x = clmod.nul(Me)
If x <> 1 Then Exit Sub
If ed1 = 1 Then
indrs.AddNew
indentrec
ElseIf ed1 = 0 Then
indentrec
End If
End Sub
Private Sub Form_Load()
'Form1.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
ed1 = 0
txtindate = Date
txtINO.Enabled = False
txtindate.Enabled = False
txttotval.Enabled = False
End Sub
Private Sub txtdept_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
If KeyAscii = 13 Then
  If txtDEPT = "PRODUCTION" Or txtDEPT = "MAINTENANCE" Then
       txtindor.SetFocus
  Else
      MsgBox "Give the department as 'PRODUCTION' or 'MAINTENANCE'"
  End If
End If
End Sub
Private Sub txtdept_LostFocus()
If txtDEPT = "PRODUCTION" Or txtDEPT = "MAINTENANCE" Then
       txtindor.SetFocus
  Else
      MsgBox "Give the department as 'PRODUCTION' or 'MAINTENANCE'"
  End If
End Sub
Private Sub txtdreq_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then txttotval.SetFocus
End Sub
Private Sub txtindate_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then txttotval.SetFocus
End Sub
Private Sub txtindor_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
If KeyAscii >= 97 And KeyAscii <= 122 Then
      KeyAscii = KeyAscii - 32
End If
If KeyAscii = 13 Then txtindate.SetFocus
End Sub
Private Sub txtINO_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then txtDEPT.SetFocus
End Sub
Private Sub txtqty_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
If KeyAscii = 13 Then txtrate.SetFocus
End Sub
Private Sub txtrate_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
If KeyAscii = 13 Then
    If txtqty = "" Then
       MsgBox "the quantity cannot be null"
       txtqty.SetFocus
       Exit Sub
    Else
        txttotval = txtqty * txtrate
        txtdreq.SetFocus
    End If
End If
End Sub
Private Sub txttotval_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
If KeyAscii = 13 Then cmdsave.SetFocus
End Sub
Private Sub txtrate_LostFocus()
If txtqty = "" Then
       MsgBox "the quantity cannot be null"
       txtqty.SetFocus
       Exit Sub
    Else
        txttotval = txtqty * txtrate
        txtdreq.SetFocus
    End If
End Sub
Sub indentrec()
indrs("INDaNTNO") = txtINO
indrs("INDATE") = txtindate
indrs("INDENTOR") = txtindor
indrs("TOT_EST_VAL") = txttotval
indrs("dept") = txtDEPT
indrs("itemcode") = DataCombo1.Text
indrs("qty") = txtqty
indrs("dt_req") = txtdreq
indrs("rate") = txtrate
indrs.Update
MsgBox "RECORD SAVED"
Call clmod.enbf(Me)
End Sub
