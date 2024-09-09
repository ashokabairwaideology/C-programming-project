VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form5 
   Caption         =   "Form5"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   LinkTopic       =   "Form5"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin MSAdodcLib.Adodc Adodc3 
      Height          =   375
      Left            =   360
      Top             =   5520
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
      CommandType     =   8
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
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   "Adodc3"
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
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   375
      Left            =   360
      Top             =   5040
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
      CommandType     =   8
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
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   "Adodc2"
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
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   360
      Top             =   4560
      Visible         =   0   'False
      Width           =   1320
      _ExtentX        =   2328
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
      RecordSource    =   "ENQ_HDR"
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
      Left            =   6600
      TabIndex        =   12
      Top             =   5520
      Width           =   1095
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
      Left            =   5400
      TabIndex        =   11
      Top             =   5520
      Width           =   1095
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
      Left            =   7800
      TabIndex        =   10
      Top             =   4920
      Width           =   1095
   End
   Begin VB.TextBox txtcode 
      Height          =   375
      Left            =   840
      TabIndex        =   4
      Top             =   3600
      Width           =   1575
   End
   Begin VB.TextBox txtqty 
      Height          =   375
      Left            =   2880
      TabIndex        =   5
      Top             =   3600
      Width           =   1575
   End
   Begin VB.TextBox txtrate 
      Height          =   375
      Left            =   4920
      TabIndex        =   6
      Top             =   3600
      Width           =   1575
   End
   Begin VB.TextBox txtdreq 
      Height          =   375
      Left            =   6960
      TabIndex        =   7
      Top             =   3600
      Width           =   1575
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Bindings        =   "quoatation2.frx":0000
      DataField       =   "ENQNO"
      DataSource      =   "Adodc1"
      Height          =   315
      Left            =   4680
      TabIndex        =   1
      Top             =   1560
      Width           =   1695
      _ExtentX        =   2990
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "ENQNO"
      Text            =   "DataCombo1"
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
      Left            =   7800
      TabIndex        =   14
      Top             =   5520
      Width           =   1095
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
      Left            =   5400
      TabIndex        =   8
      Top             =   4920
      Width           =   1095
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
      Left            =   6600
      TabIndex        =   9
      Top             =   4920
      Width           =   1095
   End
   Begin VB.TextBox txtvno 
      Height          =   375
      Left            =   4680
      TabIndex        =   3
      Top             =   2520
      Width           =   1695
   End
   Begin VB.TextBox txtdate 
      Height          =   375
      Left            =   4680
      TabIndex        =   2
      Top             =   2040
      Width           =   1695
   End
   Begin VB.TextBox txtqno 
      Height          =   375
      Left            =   1920
      TabIndex        =   0
      Top             =   720
      Width           =   1215
   End
   Begin VB.Label Label13 
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
      Left            =   1080
      TabIndex        =   22
      Top             =   3240
      Width           =   1065
   End
   Begin VB.Label Label12 
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
      Left            =   3120
      TabIndex        =   21
      Top             =   3240
      Width           =   855
   End
   Begin VB.Label Label11 
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
      Left            =   5400
      TabIndex        =   20
      Top             =   3240
      Width           =   510
   End
   Begin VB.Label Label10 
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
      Height          =   240
      Left            =   6840
      TabIndex        =   19
      Top             =   3240
      Width           =   1695
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY ITEMS QUOTATION"
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
      Left            =   2400
      TabIndex        =   18
      Top             =   0
      Width           =   4740
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Quation No"
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
      Left            =   600
      TabIndex        =   17
      Top             =   840
      Width           =   1170
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Enquiry Date"
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
      Left            =   3000
      TabIndex        =   16
      Top             =   2040
      Width           =   1350
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Enquiry No"
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
      Left            =   3000
      TabIndex        =   15
      Top             =   1560
      Width           =   1155
   End
   Begin VB.Label Label4 
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
      Left            =   3000
      TabIndex        =   13
      Top             =   2640
      Width           =   1125
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   9480
      Y1              =   1320
      Y2              =   1320
   End
End
Attribute VB_Name = "Form5"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim ed1%
Dim clmod As New inventclass
Dim bool As Boolean
Private Sub cmddelete_Click()
Dim d%
cmdfind_Click
If bool = False Then Exit Sub
d = MsgBox("Dou You want to Delete then Current Record", vbYesNo)
If d = vbYes Then
 qutnrs.Delete
 qutnrs.Requery
 Call clmod.clall(Me)
End If
End Sub
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
bool = True
f = InputBox("Enter Quation No that you want Find", vbYesNo)
If Not IsNumeric(i) And i = "" Then Exit Sub
qutnrs.MoveFirst
qutnrs.Find "qutno=" & f
If Not qutnrs.EOF Then
 txtqno = qutnrs("qutno")
 DataCombo1.Text = qutnrs("enqno")
 txtDATE = qutnrs("enqdate")
 txtvno = qutnrs("vno")
 txtCODE = qutnrs("itemcode")
 txtQTY = qutnrs("qty")
 txtRATE = qutnrs("rate")
 txtdreq = qutnrs("dt_req")
Else
   MsgBox "Record Does Not Exists"
   bool = False
   Exit Sub
End If
End Sub
Private Sub cmdmodify_Click()
cmdfind_Click
Call clmod.enbt(Me)
txtqno.Enabled = False
ed1 = 0
End Sub
Private Sub cmdnew_Click()
Call clmod.clall(Me)
Dim a%
If qutnrs.RecordCount = 0 Then
a = 101
Else
qutnrs.MoveLast
a = qutnrs("qutno") + 1
End If
txtqno = a
Call clmod.enbt(Me)
txtqno.Enabled = False
DataCombo1.SetFocus
ed1 = 1
End Sub
Private Sub cmdSAVE_Click()
Dim x%
x = clmod.nul(Me)
If x <> 1 Then Exit Sub
If ed1 = 1 Then
qutnrs.AddNew
qutrec
ElseIf ed1 = 0 Then
qutrec
End If
End Sub
Private Sub DataCombo1_Click(Area As Integer)
Dim ino#
If DataCombo1.MatchedWithList = True Then
  enqrs.MoveFirst
  enqrs.Find "enqno=" & DataCombo1
   If Not enqrs.EOF Then
       ino = enqrs("indentno")
       txtDATE = enqrs("enqdate")
       txtvno = enqrs("vno")
       txtCODE = enqrs("itemcode")
       txtQTY = enqrs("qty")
       txtdreq = enqrs("dt_req")
       indrs.MoveFirst
       indrs.Find "indantno=" & ino
If Not indrs.EOF Then
txtRATE = indrs("rate")
End If
End If
End If
Call clmod.enbf(Me)
End Sub
Private Sub Form_Load()
'Form5.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
ed1 = 0
End Sub
Private Sub txtdreq_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtqno_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtqty_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtrate_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Sub qutrec()
qutnrs("qutno") = txtqno
qutnrs("enqno") = DataCombo1.Text
qutnrs("enqdate") = txtDATE
qutnrs("vno") = txtvno
qutnrs("itemcode") = txtCODE
qutnrs("qty") = txtQTY
qutnrs("rate") = txtRATE
qutnrs("dt_req") = txtdreq
qutnrs.Update
MsgBox "updated"
Call clmod.enbf(Me)
End Sub
