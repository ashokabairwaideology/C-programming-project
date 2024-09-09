VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form3 
   Caption         =   "form3"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   LinkTopic       =   "Form3"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   405
      Left            =   720
      Top             =   4800
      Visible         =   0   'False
      Width           =   1335
      _ExtentX        =   2355
      _ExtentY        =   714
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
      RecordSource    =   "VENDOR"
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
      Left            =   720
      Top             =   4320
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
      RecordSource    =   "IND_HDR"
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
      Left            =   5400
      TabIndex        =   11
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
      Left            =   4080
      TabIndex        =   10
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
      Left            =   6720
      TabIndex        =   9
      Top             =   4800
      Width           =   1095
   End
   Begin VB.TextBox txtdreq 
      Height          =   375
      Left            =   6600
      TabIndex        =   6
      Top             =   3600
      Width           =   1575
   End
   Begin VB.TextBox txtqty 
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   4080
      TabIndex        =   5
      Top             =   3600
      Width           =   1575
   End
   Begin VB.TextBox txtcode 
      Height          =   375
      Left            =   1440
      TabIndex        =   4
      Top             =   3600
      Width           =   1575
   End
   Begin MSDataListLib.DataCombo DataCombo2 
      Bindings        =   "enquiries.frx":0000
      DataField       =   "VNO"
      DataSource      =   "Adodc2"
      Height          =   315
      Left            =   4440
      TabIndex        =   3
      Top             =   2640
      Width           =   1695
      _ExtentX        =   2990
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "VNO"
      BoundColumn     =   "VNO"
      Text            =   "DataCombo2"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Bindings        =   "enquiries.frx":0015
      DataField       =   "INDANTNO"
      DataSource      =   "Adodc1"
      Height          =   315
      Left            =   4440
      TabIndex        =   1
      Top             =   1560
      Width           =   1695
      _ExtentX        =   2990
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "INDANTNO"
      BoundColumn     =   "INDANTNO"
      Text            =   ""
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
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
      Left            =   6720
      TabIndex        =   13
      Top             =   5400
      Width           =   1095
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
      Left            =   4080
      TabIndex        =   7
      Top             =   4800
      Width           =   1215
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
      Left            =   5400
      TabIndex        =   8
      Top             =   4800
      Width           =   1215
   End
   Begin VB.TextBox txtDATE 
      Height          =   375
      Left            =   4440
      TabIndex        =   2
      Text            =   " "
      Top             =   2040
      Width           =   1695
   End
   Begin VB.TextBox txtENO 
      Height          =   375
      Left            =   1920
      TabIndex        =   0
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label Label11 
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
      Left            =   6480
      TabIndex        =   20
      Top             =   3240
      Width           =   1755
   End
   Begin VB.Label Label10 
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
      Left            =   4320
      TabIndex        =   19
      Top             =   3240
      Width           =   855
   End
   Begin VB.Label Label8 
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
      Left            =   1680
      TabIndex        =   18
      Top             =   3240
      Width           =   1065
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY ITEMS ENQUIRIES"
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
      TabIndex        =   17
      Top             =   0
      Width           =   4560
   End
   Begin VB.Label Label1 
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
      Left            =   480
      TabIndex        =   16
      Top             =   840
      Width           =   1155
   End
   Begin VB.Label Label2 
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
      Height          =   240
      Left            =   2520
      TabIndex        =   15
      Top             =   1680
      Width           =   1005
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Enqiry Date"
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
      Left            =   2520
      TabIndex        =   14
      Top             =   2160
      Width           =   1230
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
      Left            =   2520
      TabIndex        =   12
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
Attribute VB_Name = "Form3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim ed1%
Dim clmod As New inventclass
Dim bool As Boolean
Private Sub cmddelete_Click()
Dim d%
cmdfind_Click
If bool = False Then Exit Sub
d = MsgBox("Dou You want to Delete then Current Record", vbYesNo)
If d = vbYes Then
 enqrs.Delete
 enqrs.Requery
 Call clmod.clall(Me)
 txtENO.Enabled = False
 txtDATE.Enabled = False
End If
End Sub
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
f = InputBox("Enter Enquiry No that you want Find", vbYesNo)
If Not IsNumeric(f) And f = "" Then Exit Sub
enqrs.MoveFirst
enqrs.Find "enqno=" & f
If Not enqrs.EOF Then
  txtENO = enqrs("enqno")
  txtDATE = enqrs("enqdate")
  DataCombo1.Text = enqrs("indentno")
  DataCombo2.Text = enqrs("vno")
  txtQTY = enqrs("qty")
  txtdreq = enqrs("dt_req")
  txtCODE = enqrs("itemcode")
Else
   MsgBox "Record Does Not Exists"
   bool = False
   Exit Sub
End If
End Sub
Private Sub cmdmodify_Click()
cmdfind_Click
Call clmod.enbt(Me)
txtENO.Enabled = False
txtDATE.Enabled = False
ed1 = 0
End Sub
Private Sub cmdnew_Click()
Call clmod.clall(Me)
Dim a%
If enqrs.RecordCount = 0 Then
a = 101
Else
enqrs.MoveLast
a = enqrs("enqno") + 1
End If
txtENO = a
txtDATE.Text = Date
Call clmod.enbt(Me)
txtENO.Enabled = False
txtDATE.Enabled = False
ed1 = 1
End Sub
Private Sub cmdSAVE_Click()
Call clmod.nul(Me)
If clmod.nul(Me) = 0 Then Exit Sub
If ed1 = 1 Then
enqrs.AddNew
enqrec
ElseIf ed1 = 0 Then
enqrec
End If
End Sub
Private Sub DataCombo1_Click(Area As Integer)
If DataCombo1.MatchedWithList = True Then
  indrs.MoveFirst
  indrs.Find "indantno=" & DataCombo1
  If Not indrs.EOF Then
       txtCODE = indrs("itemcode")
       txtQTY = indrs("qty")
       txtdreq = indrs("dt_req")
   End If
End If
 txtCODE.Enabled = False
       txtQTY.Enabled = False
       txtdreq.Enabled = False
End Sub
Private Sub Form_Load()
'Form3.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
ed1 = 0
txtENO.Enabled = False
txtDATE.Enabled = False
End Sub
Private Sub txtCODE_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtDATE_LostFocus()
If txtDATE <> Date Then
   MsgBox "ENTER TODAY'S DATE"
   Exit Sub
End If
End Sub
Private Sub txtENO_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtqty_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Sub enqrec()
enqrs("enqno") = txtENO
enqrs("enqdate") = txtDATE
enqrs("indentno") = DataCombo1.Text
enqrs("vno") = DataCombo2.Text
enqrs("qty") = txtQTY
enqrs("dt_req") = txtdreq
enqrs("itemcode") = txtCODE
enqrs.Update
MsgBox "updated"
Call clmod.enbf(Me)
End Sub
