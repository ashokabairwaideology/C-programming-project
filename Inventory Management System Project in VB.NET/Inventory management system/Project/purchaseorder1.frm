VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form form15 
   Caption         =   "Form15"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   LinkTopic       =   "Form15"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   360
      Top             =   5280
      Visible         =   0   'False
      Width           =   1335
      _ExtentX        =   2355
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
      RecordSource    =   "QUTN_HDR"
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
   Begin VB.CommandButton cmdexit 
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
      Left            =   6600
      TabIndex        =   15
      Top             =   5280
      Width           =   975
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
      TabIndex        =   14
      Top             =   5280
      Width           =   975
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
      Left            =   6600
      TabIndex        =   12
      Top             =   4680
      Width           =   975
   End
   Begin VB.CommandButton cmdsave 
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
      TabIndex        =   11
      Top             =   4680
      Width           =   975
   End
   Begin VB.CommandButton cmdnew 
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
      Left            =   4440
      TabIndex        =   10
      Top             =   4680
      Width           =   975
   End
   Begin VB.TextBox txtdreq 
      Height          =   375
      Left            =   6840
      TabIndex        =   9
      Top             =   3960
      Width           =   1575
   End
   Begin VB.TextBox txtrate 
      Height          =   375
      Left            =   4800
      TabIndex        =   8
      Top             =   3960
      Width           =   1575
   End
   Begin VB.TextBox txtqty 
      Height          =   375
      Left            =   2880
      TabIndex        =   7
      Top             =   3960
      Width           =   1575
   End
   Begin VB.TextBox txticode 
      Height          =   375
      Left            =   840
      TabIndex        =   6
      Top             =   3960
      Width           =   1695
   End
   Begin VB.TextBox txtpoval 
      Height          =   375
      Left            =   5640
      TabIndex        =   5
      Top             =   3000
      Width           =   1695
   End
   Begin VB.TextBox txtvno 
      Height          =   375
      Left            =   5640
      TabIndex        =   4
      Top             =   2400
      Width           =   1695
   End
   Begin VB.TextBox txtpodate 
      Height          =   375
      Left            =   5640
      TabIndex        =   3
      Top             =   1800
      Width           =   1695
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Bindings        =   "purchaseorder1.frx":0000
      DataField       =   "QUTNO"
      DataSource      =   "Adodc1"
      Height          =   315
      Left            =   5640
      TabIndex        =   2
      Top             =   1320
      Width           =   1695
      _ExtentX        =   2990
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "QUTNO"
      Text            =   "DataCombo1"
   End
   Begin VB.TextBox txtpono 
      Height          =   375
      Left            =   2640
      TabIndex        =   1
      Top             =   600
      Width           =   1215
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   9480
      Y1              =   1080
      Y2              =   1080
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY PURCHASE ORDER"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   2280
      TabIndex        =   23
      Top             =   0
      Width           =   4725
   End
   Begin VB.Label label10 
      AutoSize        =   -1  'True
      Caption         =   "Date of Request "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   6720
      TabIndex        =   22
      Top             =   3600
      Width           =   1755
   End
   Begin VB.Label label8 
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
      Height          =   240
      Left            =   5280
      TabIndex        =   21
      Top             =   3600
      Width           =   510
   End
   Begin VB.Label label7 
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
      Height          =   240
      Left            =   3240
      TabIndex        =   20
      Top             =   3600
      Width           =   855
   End
   Begin VB.Label label6 
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
      Height          =   240
      Left            =   1200
      TabIndex        =   19
      Top             =   3600
      Width           =   1065
   End
   Begin VB.Label label5 
      AutoSize        =   -1  'True
      Caption         =   "Purchase Order Value"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   3240
      TabIndex        =   18
      Top             =   3000
      Width           =   2295
   End
   Begin VB.Label label4 
      AutoSize        =   -1  'True
      Caption         =   "Vendor No"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   3240
      TabIndex        =   17
      Top             =   2400
      Width           =   1125
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Purchase Order Date"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   3240
      TabIndex        =   16
      Top             =   1920
      Width           =   2190
   End
   Begin VB.Label label2 
      AutoSize        =   -1  'True
      Caption         =   "Quatation No"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   3240
      TabIndex        =   13
      Top             =   1320
      Width           =   1365
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Purchase Order No"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   480
      TabIndex        =   0
      Top             =   720
      Width           =   1995
   End
End
Attribute VB_Name = "form15"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim ed1%
Dim clmod As New inventclass
Dim bool As Boolean
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
bool = True
f = InputBox("Enter Purchase No To Find?", vbYesNo)
If Not IsNumeric(f) And f = "" Then Exit Sub
pors.MoveFirst
pors.Find "pono=" & f
If Not pors.EOF Then
txtpono = pors("pono")
 DataCombo1.Text = pors("qutno")
 txtpodate = pors("qutno")
txtvno = pors("vno")
 txticode = pors("itemcode")
 txtqty = pors("qty")
 txtrate = pors("rate")
 txtdreq = pors("dt_req")
 txtpoval = pors("poval")
Else
MsgBox "RECORD DOESNOT EXIT"
bool = False
End If
End Sub
Private Sub cmdmodify_Click()
Call cmdfind_Click
txtpono.Enabled = False
txtpodate.Enabled = False
ed1 = 0
End Sub
Private Sub cmdnew_Click()
Dim a%
Call clmod.clall(Me)
If pors.RecordCount = 0 Then
a = 101
Else
pors.MoveLast
a = pors("pono") + 1
End If
txtpono = a
txtpodate.Text = Date
Call clmod.enbt(Me)
txtpono.Enabled = False
txtpodate.Enabled = False
ed1 = 1
End Sub
Private Sub cmdSAVE_Click()
Dim k%
k = clmod.nul(Me)
If k <> 1 Then Exit Sub
If ed1 = 1 Then
pors.AddNew
porec
ElseIf ed1 = 0 Then
porec
End If
End Sub
Private Sub DataCombo1_Click(Area As Integer)
If DataCombo1.MatchedWithList = True Then
  qutnrs.MoveFirst
  qutnrs.Find "qutno=" & DataCombo1
  If Not qutnrs.EOF Then
       txticode = qutnrs("itemcode")
       txtqty = qutnrs("qty")
   txtrate = qutnrs("rate")
       txtvno = qutnrs("vno")
       txtdreq = qutnrs("dt_req")
       txtpoval = Val(txtrate) * Val(txtqty)
   End If
End If
Call clmod.enbf(Me)
End Sub
Private Sub Form_Load()
'form15.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
ed1 = 0
txtpono.Enabled = False
txtpodate.Enabled = False
End Sub
Private Sub txticode_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtpno_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtpodate_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtpoval_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtqty_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtrate_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtvno_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Sub porec()
pors("pono") = txtpono
pors("qutno") = DataCombo1.Text
pors("podate") = txtpodate
pors("vno") = txtvno
pors("itemcode") = txticode
pors("qty") = txtqty
pors("rate") = txtrate
pors("dt_req") = txtdreq
pors("poval") = txtpoval
pors.Update
MsgBox "updated"
Call clmod.enbf(Me)
End Sub
