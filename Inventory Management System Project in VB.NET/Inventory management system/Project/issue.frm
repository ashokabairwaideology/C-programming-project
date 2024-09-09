VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form11 
   Caption         =   "Form11"
   ClientHeight    =   6795
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form11"
   MDIChild        =   -1  'True
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   WindowState     =   2  'Maximized
   Begin VB.TextBox txticode 
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Text            =   " "
      Top             =   3600
      Width           =   1335
   End
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   330
      Left            =   720
      Top             =   4800
      Visible         =   0   'False
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   582
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
      UserName        =   "SCOTT"
      Password        =   "TIGER"
      RecordSource    =   "IND_HDR"
      Caption         =   "Adodc2"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin MSDataListLib.DataCombo DataCombo2 
      Bindings        =   "issue.frx":0000
      DataField       =   "INDANTNO"
      DataSource      =   "Adodc2"
      Height          =   360
      Left            =   4080
      TabIndex        =   2
      Top             =   1800
      Width           =   1815
      _ExtentX        =   3201
      _ExtentY        =   635
      _Version        =   393216
      ListField       =   "INDANTNO"
      Text            =   "DataCombo2"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
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
      Left            =   7200
      TabIndex        =   12
      Top             =   4560
      Width           =   975
   End
   Begin VB.TextBox txtREM 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6840
      TabIndex        =   9
      Top             =   3600
      Width           =   1455
   End
   Begin VB.TextBox txtHAND 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4800
      TabIndex        =   8
      Top             =   3600
      Width           =   1935
   End
   Begin VB.TextBox txtVAL 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3240
      Locked          =   -1  'True
      TabIndex        =   7
      Top             =   3600
      Width           =   1455
   End
   Begin VB.TextBox txtQTY 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1680
      TabIndex        =   6
      Top             =   3600
      Width           =   1455
   End
   Begin VB.TextBox txtINO 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   2280
      Locked          =   -1  'True
      TabIndex        =   0
      Top             =   600
      Width           =   1095
   End
   Begin VB.TextBox txtIDATE 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4080
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   1320
      Width           =   1815
   End
   Begin VB.TextBox txtDEPT 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4080
      TabIndex        =   3
      Top             =   2280
      Width           =   1815
   End
   Begin VB.TextBox txtISDBY 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4080
      TabIndex        =   4
      Top             =   2760
      Width           =   1815
   End
   Begin VB.CommandButton cmdNEW1 
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
      Left            =   5040
      TabIndex        =   10
      Top             =   4560
      Width           =   975
   End
   Begin VB.CommandButton cmdsave1 
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
      Left            =   6120
      TabIndex        =   11
      Top             =   4560
      Width           =   975
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
      Left            =   6120
      TabIndex        =   14
      Top             =   5160
      Width           =   975
   End
   Begin VB.Label Label11 
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
      Left            =   2280
      TabIndex        =   24
      Top             =   1920
      Width           =   1005
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      Caption         =   "Remarks"
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
      Left            =   7080
      TabIndex        =   23
      Top             =   3240
      Width           =   945
   End
   Begin VB.Label Label8 
      AutoSize        =   -1  'True
      Caption         =   "Handovered To"
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
      Left            =   4920
      TabIndex        =   22
      Top             =   3240
      Width           =   1650
   End
   Begin VB.Label Label7 
      AutoSize        =   -1  'True
      Caption         =   "Value"
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
      Left            =   3720
      TabIndex        =   21
      Top             =   3240
      Width           =   615
   End
   Begin VB.Label Label6 
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
      Left            =   1920
      TabIndex        =   20
      Top             =   3240
      Width           =   855
   End
   Begin VB.Label Label5 
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
      Left            =   360
      TabIndex        =   19
      Top             =   3240
      Width           =   1065
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Issue No"
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
      Left            =   840
      TabIndex        =   18
      Top             =   720
      Width           =   930
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Issue Date"
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
      Left            =   2280
      TabIndex        =   17
      Top             =   1440
      Width           =   1125
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Departement"
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
      Left            =   2280
      TabIndex        =   16
      Top             =   2400
      Width           =   1350
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "Issued By"
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
      Left            =   2280
      TabIndex        =   15
      Top             =   2880
      Width           =   1035
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   9480
      Y1              =   1080
      Y2              =   1080
   End
   Begin VB.Label Label10 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY ITEM ISSUE "
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
      Left            =   2640
      TabIndex        =   13
      Top             =   0
      Width           =   3690
   End
End
Attribute VB_Name = "Form11"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim clmod As New inventclass
Dim bool  As Boolean
Dim rate!
Private Sub cmddelete_Click()
Dim d%
cmdfind_Click
If bool = False Then Exit Sub
d = MsgBox("Dou You want to Delete then Current Record", vbYesNo)
If d = vbYes Then
 isuers.Delete
 isuers.Requery
 Call clmod.clr(Me)
End If
End Sub
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
bool = True
f = InputBox("Enter Issue No that you want Find", vbYesNo)
If Not IsNumeric(f) And f = "" Then Exit Sub
isuers.MoveFirst
isuers.Find "isuno=" & f
If Not isuers.EOF Then
 txtINO = isuers("isuno")
 txtIDATE = isuers("isdat")
 txtDEPT = isuers("dept")
 txtisdb = isuers("isu_by")
 txticode = isuers("itemcode")
 txtQTY = isuers("qty")
 txtVAL = isuers("val")
 txtHAND = isuers("handovr_to")
 txtREM = isuers("remak")
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
txtIDATE.Enabled = False
End Sub
Private Sub cmdnew1_Click()
Dim a%
Call clmod.clall(Me)
If isuers.RecordCount = 0 Then
a = 101
Else
isuers.MoveLast
a = isuers("isuno") + 1
End If
txtINO = a
txtIDATE.Text = Date
Call clmod.enbt(Me)
txtIDATE.Enabled = False
txtINO.Enabled = False
End Sub
Private Sub cmdsave1_Click()
Dim k%, oqty%, nqty%
k = clmod.nul(Me)
If k <> 1 Then Exit Sub
stockrs.MoveFirst
stockrs.Find "itemcode=" & txticode
If Not stockrs.EOF Then
   oqty = stockrs("qty")
   dval = stockrs("sdate")
          If txtQTY > oqty Then
              MsgBox "STOCK NOT AVAILABLE"
              txtQTY = ""
              txtQTY.Enabled = True
              txtqty_Change
              Exit Sub
          End If
Else
   MsgBox "Corresponding ItemCode does not Exists"
   Exit Sub
End If
isuers.AddNew
isuers("isuno") = txtINO
isuers("isdat") = txtIDATE
isuers("dept") = txtDEPT
isuers("isu_by") = txtISDBY
isuers("itemcode") = txticode
isuers("qty") = txtQTY
isuers("val") = txtVAL
isuers("handovr_to") = txtHAND
isuers("remak") = txtREM
isuers.Update
MsgBox "RECORD SAVED"
Call invent(oqty)
Call clmod.enbf(Me)
End Sub
Private Sub DataCombo2_Click(Area As Integer)
If DataCombo2.MatchedWithList = True Then
  indrs.MoveFirst
  indrs.Find "indantno=" & DataCombo2
  If Not indrs.EOF Then
     txtDEPT = indrs("dept")
     txticode = indrs("itemcode")
     txtQTY = indrs("qty")
  End If
End If
itemrs.MoveFirst
  itemrs.Find "itemcode=" & txticode
  If Not itemrs.EOF Then
     rate = itemrs("rate")
     txtVAL = Val(txtQTY) * rate
   End If

txtDEPT.Enabled = False
txticode.Enabled = False
txtVAL.Enabled = False
txtQTY.Enabled = False
End Sub


Private Sub Form_Load()
'Form11.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
End Sub

Private Sub txtdept_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtHAND_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txticode_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtINO_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtISDBY_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
If KeyAscii = 13 Then txtQTY.SetFocus
End Sub

Private Sub txtqty_Change()
itemrs.MoveFirst
'  itemrs.Find "itemcode=" & txticode
'  If Not itemrs.EOF Then
'     rate = itemrs("rate")
'     txtVAL = Val(txtQTY) * rate
'   End If
End Sub

Private Sub txtqty_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub

Private Sub txtQTY_LostFocus()
If Trim(txtQTY) = "" And Val(txtQTY) = 0 Then
      MsgBox "Enter Quantity"
      txtQTY.SetFocus
      Exit Sub
End If

End Sub

Private Sub txtREM_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtVAL_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Public Sub invent(ByVal oqty)
   nqty = oqty - Val(txtQTY)
   stockrs("itemcode") = txticode
   stockrs("des") = itemrs("description")
   stockrs("rate") = itemrs("rate")
   stockrs("qty") = nqty
   stockrs("val") = nqty * (itemrs("rate"))
   stockrs("sdate") = Date
   stockrs("transaction") = "Issue"
   stockrs.Update
   MsgBox "stock updated"
End Sub

