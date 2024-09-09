VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form12 
   Caption         =   "Form12"
   ClientHeight    =   6240
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9210
   LinkTopic       =   "Form12"
   ScaleHeight     =   6240
   ScaleWidth      =   9210
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin MSDataListLib.DataCombo DataCombo1 
      Bindings        =   "returns.frx":0000
      DataField       =   "ISUNO"
      DataSource      =   "Adodc1"
      Height          =   315
      Left            =   1920
      TabIndex        =   25
      Top             =   1680
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
      Connect         =   "DSN=anbu"
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   "anbu"
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
      Caption         =   "FIND"
      Height          =   375
      Left            =   4320
      TabIndex        =   24
      Top             =   5160
      Width           =   855
   End
   Begin VB.CommandButton cmdmodify 
      Caption         =   "MODIFY"
      Height          =   375
      Left            =   6000
      TabIndex        =   23
      Top             =   4560
      Width           =   855
   End
   Begin VB.TextBox txtREM 
      Height          =   375
      Left            =   5880
      TabIndex        =   18
      Top             =   3840
      Width           =   1815
   End
   Begin VB.TextBox txtVAL 
      Height          =   375
      Left            =   4680
      TabIndex        =   17
      Top             =   3840
      Width           =   975
   End
   Begin VB.TextBox txtQTY 
      Height          =   375
      Left            =   3000
      TabIndex        =   16
      Top             =   3840
      Width           =   1455
   End
   Begin VB.TextBox txtICODE 
      Height          =   375
      Left            =   1440
      TabIndex        =   15
      Top             =   3840
      Width           =   1335
   End
   Begin VB.TextBox txtRNO 
      Height          =   375
      Left            =   1920
      TabIndex        =   7
      Top             =   720
      Width           =   1215
   End
   Begin VB.TextBox txtRDATE 
      Height          =   375
      Left            =   1920
      TabIndex        =   6
      Top             =   1320
      Width           =   1455
   End
   Begin VB.TextBox txtDEPT 
      Height          =   375
      Left            =   1920
      TabIndex        =   5
      Top             =   2040
      Width           =   2055
   End
   Begin VB.TextBox txtRETUNB 
      Height          =   375
      Left            =   1920
      TabIndex        =   4
      Top             =   2400
      Width           =   3255
   End
   Begin VB.TextBox txtRETUNT 
      Height          =   375
      Left            =   1920
      TabIndex        =   3
      Top             =   2760
      Width           =   3375
   End
   Begin VB.CommandButton cmdNEW 
      Caption         =   "NEW"
      Height          =   375
      Left            =   3840
      TabIndex        =   2
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmdSAVE1 
      Caption         =   "SAVE"
      Height          =   375
      Left            =   4920
      TabIndex        =   1
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmdEXIT 
      Caption         =   "EXIT"
      Height          =   375
      Left            =   5400
      TabIndex        =   0
      Top             =   5160
      Width           =   855
   End
   Begin VB.Label Label10 
      AutoSize        =   -1  'True
      Caption         =   "REMARKS"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   6360
      TabIndex        =   22
      Top             =   3600
      Width           =   915
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      Caption         =   "VALUE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   4800
      TabIndex        =   21
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label8 
      AutoSize        =   -1  'True
      Caption         =   "QUANTITY"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   3240
      TabIndex        =   20
      Top             =   3600
      Width           =   960
   End
   Begin VB.Label Label7 
      AutoSize        =   -1  'True
      Caption         =   "ITEM_CODE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   1560
      TabIndex        =   19
      Top             =   3600
      Width           =   1080
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "RETURN NO"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   765
      TabIndex        =   14
      Top             =   840
      Width           =   1125
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "RETURN DATE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   540
      TabIndex        =   13
      Top             =   1440
      Width           =   1350
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "ISSUE NO"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   990
      TabIndex        =   12
      Top             =   1800
      Width           =   900
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "DEPARTMENT"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   600
      TabIndex        =   11
      Top             =   2160
      Width           =   1290
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "RETURNED_BY"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   495
      TabIndex        =   10
      Top             =   2520
      Width           =   1395
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      Caption         =   "RETURNED_TO"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   480
      TabIndex        =   9
      Top             =   2880
      Width           =   1410
   End
   Begin VB.Line Line1 
      BorderWidth     =   3
      X1              =   0
      X2              =   8280
      Y1              =   1200
      Y2              =   1200
   End
   Begin VB.Label Label11 
      AutoSize        =   -1  'True
      Caption         =   "Inventory Item Return Report"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   2040
      TabIndex        =   8
      Top             =   0
      Width           =   4560
   End
End
Attribute VB_Name = "Form12"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim clmod As New inventclass
Private Sub cmdexit_Click()
Unload Me
End Sub
Private Sub cmdfind_Click()
Dim f$
f = InputBox("Enter Return No that you want Find", vbYesNo)
If Not IsNumeric(i) And i = "" Then Exit Sub
retunrs.MoveFirst
retunrs.Find "venno=" & f
If Not retunrs.EOF Then
 txtRNO = retunrs("retno")
 txtRDATE = retunrs("rtdat")
 Combo1.Text = retunrs("isuno")
 txtRETUNT = retunrs("retn_to")
 txtRETUNB = retunrs("retn_by")
 txtICODE = retunrs("itemcode")
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
txtRNO.Enabled = False
txtRDATE.SetFocus
End Sub
Private Sub cmdsave1_Click()
Call clmod.nul(Me)
If nul(Me) = 0 Then Exit Sub
stockrs.MoveFirst
stockrs.Find "itemcode=" & DataCombo1
If Not stockrs.EOF Then
   oqty = stockrs("qty")
   dval = stockrs("sdate")
   nqty = oqty + Val(txtQTY)
   stockrs("itemcode") = DataCombo1
   stockrs("des") = itemrs("description")
   stockrs("rate") = itemrs("rate")
   stockrs("qty") = nqty
   stockrs("val") = nqty * (itemrs("rate"))
   stockrs("sdate") = Date
   stockrs("transaction") = "Returns"
   stockrs.Update
   MsgBox "stock updated"
Else
   MsgBox "Corresponding Item Code does not Exists"
   Exit Sub
End If
retunrs.AddNew
retunrs("retno") = txtRNO
retunrs("rtdat") = txtDATE
retunrs("isuno") = Combo1.Text
retunrs("retn_to") = txtRETUNT
retunrs("retn_by") = txtRETUNB
retunrs("itemcode") = txtICODE
retunrs("qty") = txtQTY
retunrs("val") = txtVAL
retunrs("remks") = txtREM
retunrs.Update
MsgBox "RECORD SAVED"
End Sub
Private Sub txtdept_KeyPress(KeyAscii As Integer)
Call clmod.char(KeyAscii)
End Sub
Private Sub txticode_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
End Sub
Private Sub txtqty_KeyPress(KeyAscii As Integer)
Call clmod.num(KeyAscii)
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
