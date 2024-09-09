VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form12 
   Caption         =   "Form12"
   ClientHeight    =   6240
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9210
   ControlBox      =   0   'False
   LinkTopic       =   "Form12"
   MDIChild        =   -1  'True
   ScaleHeight     =   6240
   ScaleWidth      =   9210
   WindowState     =   2  'Maximized
   Begin VB.TextBox txticode 
      Height          =   375
      Left            =   1440
      TabIndex        =   6
      Text            =   " "
      Top             =   3960
      Width           =   1335
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Bindings        =   "isuereturns.frx":0000
      DataField       =   "ISUNO"
      DataSource      =   "Adodc1"
      Height          =   315
      Left            =   3600
      TabIndex        =   2
      Top             =   1800
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "ISUNO"
      Text            =   "DataCombo1"
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   600
      Top             =   4920
      Visible         =   0   'False
      Width           =   1455
      _ExtentX        =   2566
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
      RecordSource    =   "ISUE_HDR"
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
      Left            =   6000
      TabIndex        =   12
      Top             =   4560
      Width           =   855
   End
   Begin VB.TextBox txtREM 
      Height          =   375
      Left            =   6240
      TabIndex        =   9
      Top             =   3960
      Width           =   1575
   End
   Begin VB.TextBox txtVAL 
      Height          =   375
      Left            =   4680
      TabIndex        =   8
      Top             =   3960
      Width           =   1335
   End
   Begin VB.TextBox txtQTY 
      Height          =   375
      Left            =   3000
      TabIndex        =   7
      Top             =   3960
      Width           =   1455
   End
   Begin VB.TextBox txtRNO 
      Height          =   375
      Left            =   1920
      TabIndex        =   0
      Top             =   600
      Width           =   1215
   End
   Begin VB.TextBox txtRDATE 
      Height          =   375
      Left            =   3600
      TabIndex        =   1
      Top             =   1320
      Width           =   1575
   End
   Begin VB.TextBox txtDEPT 
      Height          =   375
      Left            =   3600
      TabIndex        =   3
      Top             =   2160
      Width           =   2055
   End
   Begin VB.TextBox txtRETUNB 
      Height          =   375
      Left            =   3600
      TabIndex        =   4
      Top             =   2640
      Width           =   2055
   End
   Begin VB.TextBox txtRETUNT 
      Height          =   375
      Left            =   3600
      TabIndex        =   5
      Top             =   3120
      Width           =   2055
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
      Left            =   3840
      TabIndex        =   10
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmdSAVE1 
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
      Left            =   4920
      TabIndex        =   11
      Top             =   4560
      Width           =   855
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
      Left            =   4920
      TabIndex        =   14
      Top             =   5160
      Width           =   855
   End
   Begin VB.Label Label10 
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
      Left            =   6600
      TabIndex        =   24
      Top             =   3600
      Width           =   945
   End
   Begin VB.Label Label9 
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
      Left            =   5160
      TabIndex        =   23
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label8 
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
      TabIndex        =   22
      Top             =   3600
      Width           =   855
   End
   Begin VB.Label Label7 
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
      Left            =   1560
      TabIndex        =   21
      Top             =   3600
      Width           =   1065
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Return No"
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
      TabIndex        =   20
      Top             =   720
      Width           =   1050
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Return Date"
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
      Left            =   1800
      TabIndex        =   19
      Top             =   1440
      Width           =   1245
   End
   Begin VB.Label Label3 
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
      Left            =   1800
      TabIndex        =   18
      Top             =   1800
      Width           =   930
   End
   Begin VB.Label Label4 
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
      Height          =   240
      Left            =   1800
      TabIndex        =   17
      Top             =   2160
      Width           =   1215
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "Returned_By"
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
      Left            =   1800
      TabIndex        =   16
      Top             =   2520
      Width           =   1350
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      Caption         =   "Returned_To"
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
      Left            =   1800
      TabIndex        =   15
      Top             =   3000
      Width           =   1365
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   9480
      Y1              =   1080
      Y2              =   1080
   End
   Begin VB.Label Label11 
      AutoSize        =   -1  'True
      Caption         =   "INVENTORY ITEM RETURN REPORT"
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
      Left            =   2040
      TabIndex        =   13
      Top             =   0
      Width           =   5325
   End
End
Attribute VB_Name = "Form12"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim clmod As New inventclass
Dim rate%, ioqty%
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
f = InputBox("Enter Return No that you want Find", vbYesNo)
If Not IsNumeric(i) And i = "" Then Exit Sub
retunrs.MoveFirst
retunrs.Find "retno=" & f
If Not retunrs.EOF Then
 txtRNO = retunrs("retno")
 txtRDATE = retunrs("rtdat")
DataCombo1.Text = retunrs("isuno")
 txtRETUNT = retunrs("retn_to")
 txtRETUNB = retunrs("retn_by")
 txticode = retunrs("itemcode")
 txtQTY = retunrs("qty")
 txtVAL = retunrs("val")
 txtREM = retunrs("remks")
 txtDEPT = retunrs("dept")
Else
   MsgBox "Record Does Not Exists"
   Exit Sub
End If
End Sub
Private Sub cmdmodify_Click()
cmdfind_Click
Call clmod.enat(Me)
txtRNO.Enabled = False
End Sub
Private Sub cmdnew_Click()
Call clmod.clr(Me)
Dim a%
If retunrs.RecordCount = 0 Then
a = 101
Else
retunrs.MoveLast
a = retunrs("retno") + 1
End If
txtRNO = a
txtRDATE = Date
txtRNO.Enabled = False
txtRDATE.Enabled = False
End Sub
Private Sub cmdsave1_Click()
Dim k%
k = clmod.nul(Me)
If k <> 1 Then Exit Sub
stockrs.MoveFirst
stockrs.Find "itemcode=" & txticode
If Not stockrs.EOF Then
   oqty = stockrs("qty")
   dval = stockrs("sdate")
Else
   MsgBox "Corresponding Item Code does not Exists"
   Exit Sub
End If
   nqty = oqty + Val(txtQTY)
   stockrs("itemcode") = txticode
   stockrs("des") = itemrs("description")
   stockrs("rate") = itemrs("rate")
   stockrs("qty") = nqty
   stockrs("val") = nqty * (itemrs("rate"))
   stockrs("sdate") = Date
   stockrs("transaction") = "Returns"
   stockrs.Update
   MsgBox "stock updated"
retunrs.AddNew
retunrs("retno") = txtRNO
retunrs("rtdat") = txtRDATE
retunrs("dept") = txtDEPT
retunrs("isuno") = DataCombo1.Text
retunrs("retn_to") = txtRETUNT
retunrs("retn_by") = txtRETUNB
retunrs("itemcode") = txticode
retunrs("qty") = txtQTY
retunrs("val") = txtVAL
retunrs("remks") = txtREM
retunrs.Update
MsgBox "RECORD SAVED"
End Sub
Private Sub DataCombo1_Click(Area As Integer)
If DataCombo1.MatchedWithList = True Then
  isuers.MoveFirst
  isuers.Find "isuno=" & DataCombo1
  If Not isuers.EOF Then
     txtDEPT = isuers("dept")
     ioqty = isuers("qty")
     txticode = isuers("itemcode")
     
  End If
     txticode.Enabled = False
     txtDEPT.Enabled = False
     txtQTY.SetFocus
End If
End Sub

Private Sub Form_Load()
'Form12.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
End Sub

Private Sub txtdept_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txticode_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtqty_Change()
itemrs.MoveFirst
  itemrs.Find "itemcode=" & txticode
'  If Not itemrs.EOF Then
'     rate = itemrs("rate")
'     txtVAL = Val(txtQTY) * rate
'  End If
txtVAL.Enabled = False
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
If txtQTY > ioqty Then
      MsgBox " returns are more then isues"
      txtQTY.SetFocus
      Exit Sub
End If
End Sub
Private Sub txtREM_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtRETUNB_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtRETUNT_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtRNO_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtVAL_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
