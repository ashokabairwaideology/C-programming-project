VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form form10 
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
      Height          =   330
      Left            =   240
      Top             =   4920
      Visible         =   0   'False
      Width           =   1335
      _ExtentX        =   2355
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
      UserName        =   "scott"
      Password        =   "tiger"
      RecordSource    =   "PO_HDR"
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
      Caption         =   "Find"
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
      Top             =   4800
      Width           =   855
   End
   Begin VB.TextBox txtrem 
      Height          =   375
      Left            =   6360
      TabIndex        =   9
      Text            =   " "
      Top             =   3960
      Width           =   1815
   End
   Begin VB.TextBox txtchk 
      Height          =   375
      Left            =   4440
      TabIndex        =   8
      Text            =   " "
      Top             =   3960
      Width           =   1695
   End
   Begin VB.TextBox txtval 
      Height          =   375
      Left            =   3000
      TabIndex        =   7
      Text            =   " "
      Top             =   3960
      Width           =   1215
   End
   Begin VB.TextBox txtqty 
      Height          =   375
      Left            =   1560
      TabIndex        =   6
      Text            =   " "
      Top             =   3960
      Width           =   1215
   End
   Begin VB.TextBox txtCODE 
      Height          =   375
      Left            =   0
      TabIndex        =   5
      Text            =   " "
      Top             =   3960
      Width           =   1335
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Bindings        =   "itemreceipt1.frx":0000
      DataField       =   "PONO"
      DataSource      =   "Adodc1"
      Height          =   315
      Left            =   4080
      TabIndex        =   2
      Top             =   1680
      Width           =   1455
      _ExtentX        =   2566
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "PONO"
      Text            =   "DataCombo1"
   End
   Begin VB.TextBox txtRNO 
      Height          =   375
      Left            =   1800
      TabIndex        =   0
      Text            =   " "
      Top             =   600
      Width           =   1215
   End
   Begin VB.TextBox txtDATE 
      Height          =   375
      Left            =   4080
      TabIndex        =   1
      Text            =   " "
      Top             =   1200
      Width           =   1455
   End
   Begin VB.TextBox txtSUPP 
      Height          =   375
      Left            =   4080
      TabIndex        =   3
      Text            =   " "
      Top             =   2040
      Width           =   2415
   End
   Begin VB.TextBox txtRECD 
      Height          =   375
      Left            =   4080
      TabIndex        =   4
      Text            =   " "
      Top             =   2520
      Width           =   2415
   End
   Begin VB.CommandButton cmdNEW 
      Caption         =   "&New "
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
      Top             =   4800
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
      Top             =   4800
      Width           =   975
   End
   Begin VB.CommandButton cmdEXIT 
      Caption         =   "Exit"
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
      Top             =   5400
      Width           =   975
   End
   Begin VB.Label Label10 
      AutoSize        =   -1  'True
      Caption         =   "Remark"
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
      Left            =   6600
      TabIndex        =   24
      Top             =   3480
      Width           =   825
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      Caption         =   "Cheked By"
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
      Left            =   4680
      TabIndex        =   23
      Top             =   3480
      Width           =   1140
   End
   Begin VB.Label Label8 
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
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   3360
      TabIndex        =   22
      Top             =   3480
      Width           =   615
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
      Left            =   1800
      TabIndex        =   21
      Top             =   3480
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
      Left            =   240
      TabIndex        =   20
      Top             =   3480
      Width           =   1065
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Recpt No"
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
      Left            =   480
      TabIndex        =   19
      Top             =   720
      Width           =   990
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Receipt Date"
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
      Left            =   1800
      TabIndex        =   18
      Top             =   1320
      Width           =   1380
   End
   Begin VB.Label Label3 
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
      ForeColor       =   &H00000000&
      Height          =   240
      Left            =   1800
      TabIndex        =   17
      Top             =   1680
      Width           =   1995
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "Supplied By"
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
      Left            =   1800
      TabIndex        =   16
      Top             =   2160
      Width           =   1275
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "Received By"
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
      Left            =   1800
      TabIndex        =   15
      Top             =   2640
      Width           =   1350
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
      Caption         =   "INVENTORY ITEMS RECEIPT"
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
      Left            =   2760
      TabIndex        =   13
      Top             =   0
      Width           =   4215
   End
End
Attribute VB_Name = "form10"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim clmod As New inventclass
Dim bool As Boolean
Private Sub cmddel_Click()
Dim d%
cmdfind_Click
If bool = False Then Exit Sub
d = MsgBox("Dou You want to Delete then Current Record", vbYesNo)
If d = vbYes Then
 recptrs.Delete
 recptrs.Requery
 Call clmod.clall(Me)
End If
End Sub
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
bool = True
f = InputBox("Enter Receipt No that you want Find", vbYesNo)
If Not IsNumeric(f) And f = "" Then Exit Sub
recptrs.MoveFirst
recptrs.Find "rp_no=" & f
If Not recptrs.EOF Then
 txtRNO = recptrs("rp_no")
 DataCombo1.Text = recptrs("pono")
 txtDATE = recptrs("rdate")
 txtSUPP = recptrs("sup_by")
 txtRECD = recptrs("recd_by")
 txtCODE = recptrs("itemcode")
 txtQTY = recptrs("qty")
 txtVAL = recptrs("val")
 txtchk = recptrs("chk_by")
 txtREM = recptrs("remks")
 Else
   MsgBox "Record Does Not Exists"
   bool = False
   Exit Sub
End If
Call clmod.enbf(Me)
End Sub
Private Sub cmdmodify_Click()
cmdfind_Click
Call clmod.enbt(Me)
txtRNO.Enabled = False
txtDATE.Enabled = False
End Sub
Private Sub cmdnew_Click()
Call clmod.clall(Me)
Dim a%
If recptrs.RecordCount = 0 Then
a = 101
Else
recptrs.MoveLast
a = recptrs("rp_no") + 1
End If
txtRNO = a
txtDATE.Text = Date
Call clmod.enbt(Me)
txtRNO.Enabled = False
txtDATE.Enabled = False
End Sub
Private Sub cmdsave1_Click()
Dim x%, oqty%
oqty = 0
x = clmod.nul(Me)
If x <> 1 Then Exit Sub
recptrs.AddNew
reciprec
If stockrs.BOF = True Then
 stockrs.AddNew
 stockrec (oqty)
Else
stockrs.MoveFirst
stockrs.Find "itemcode=" & txtCODE
    If Not stockrs.EOF Then
       oqty = stockrs("qty")
       stockrec (oqty)
    Else
      stockrs.AddNew
      stockrec (oqty)
   End If
End If
End Sub
Private Sub DataCombo1_Click(Area As Integer)
If DataCombo1.MatchedWithList = True Then
  pors.MoveFirst
  pors.Find "pono=" & DataCombo1
  If Not pors.EOF Then
     txtCODE = pors("itemcode")
     txtQTY = pors("qty")
     txtVAL = pors("poval")
   End If
End If
     txtCODE.Enabled = False
     txtQTY.Enabled = False
     txtVAL.Enabled = False
End Sub

Private Sub Form_Load()
'form10.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
End Sub

Private Sub txtchk_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtCODE_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtDATE_LostFocus()
If txtDATE <> Date Then
  MsgBox " enter todays date"
  txtDATE.SetFocus
  Exit Sub
End If
End Sub
Private Sub txtqty_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtRECD_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtREM_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtRNO_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtSUPP_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txtVAL_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
 Sub reciprec()
  recptrs("rp_no") = txtRNO
  recptrs("rdate") = txtDATE
  recptrs("pono") = DataCombo1.Text
  recptrs("sup_by") = txtSUPP
  recptrs("recd_by") = txtRECD
  recptrs("itemcode") = txtCODE
  recptrs("qty") = txtQTY
  recptrs("val") = txtVAL
  recptrs("chk_by") = txtchk
  recptrs("remks") = txtREM
  recptrs.Update
  MsgBox "RECORD SAVED"
  Call clmod.enbf(Me)
 End Sub
Sub stockrec(ByVal oqty)
Dim nqty%
nqty = (oqty + Val(txtQTY))
stockrs("itemcode") = txtCODE
stockrs("des") = itemrs("description")
stockrs("rate") = itemrs("rate")
stockrs("qty") = nqty
stockrs("val") = nqty * (itemrs("rate"))
stockrs("sdate") = txtDATE
stockrs("transaction") = "Receipt"
stockrs.Update
MsgBox "stock updated"
End Sub
