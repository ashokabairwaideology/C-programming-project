VERSION 5.00
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H8000000C&
   Caption         =   "MDIForm1"
   ClientHeight    =   5520
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   6675
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Data Data1 
      Align           =   1  'Align Top
      Caption         =   "Data1"
      Connect         =   "Access"
      DatabaseName    =   "C:\srinu\inventory.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   495
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "indhdr"
      Top             =   0
      Visible         =   0   'False
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport9 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   0
      Top             =   3855
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport8 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   1
      Top             =   3375
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport7 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   2
      Top             =   2415
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport6 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   3
      Top             =   4335
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport5 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   4
      Top             =   2895
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport4 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   5
      Top             =   1935
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport3 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   6
      Top             =   1455
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport2 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   7
      Top             =   975
      Width           =   6675
   End
   Begin VB.PictureBox CrystalReport1 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   6615
      TabIndex        =   8
      Top             =   495
      Width           =   6675
   End
   Begin VB.Menu MASTER 
      Caption         =   "Purchase"
      Begin VB.Menu vender 
         Caption         =   "&Vender Master"
      End
      Begin VB.Menu item 
         Caption         =   "&Item Code Master"
      End
      Begin VB.Menu INVENTORY 
         Caption         =   "Item Indent"
         Begin VB.Menu ad 
            Caption         =   "&New Indent"
         End
         Begin VB.Menu md 
            Caption         =   "&Modify/Delete"
         End
      End
      Begin VB.Menu ITEMENQURY 
         Caption         =   "Item Enqury"
         Begin VB.Menu AD1 
            Caption         =   "&New Enqury"
         End
         Begin VB.Menu MD1 
            Caption         =   "&Modify/Delete"
         End
      End
      Begin VB.Menu quatati 
         Caption         =   "Quatation"
         Begin VB.Menu ad2 
            Caption         =   "&New Quatation"
         End
         Begin VB.Menu md2 
            Caption         =   "&Modify/Delete"
         End
      End
      Begin VB.Menu pur 
         Caption         =   "purchase order"
      End
   End
   Begin VB.Menu trans 
      Caption         =   "Stores"
      Begin VB.Menu itemrep 
         Caption         =   "Item Receipt"
      End
      Begin VB.Menu itemissu 
         Caption         =   "Item Issues"
      End
      Begin VB.Menu itemsretu 
         Caption         =   "Items Returns"
      End
   End
   Begin VB.Menu REP 
      Caption         =   "Reports"
      Begin VB.Menu in 
         Caption         =   "Indent Details"
         Begin VB.Menu indent 
            Caption         =   "Indent Number Wise"
         End
         Begin VB.Menu indent1 
            Caption         =   "Indate Date Wise"
         End
      End
      Begin VB.Menu in1 
         Caption         =   "Enquiry Details"
         Begin VB.Menu enquiry 
            Caption         =   "Enquiry Number Wise"
         End
         Begin VB.Menu enquiry1 
            Caption         =   "Enquiry Date Wise"
         End
      End
      Begin VB.Menu in2 
         Caption         =   "Quatation Details"
         Begin VB.Menu quatation 
            Caption         =   "Quatation Number Wise"
         End
         Begin VB.Menu quatation1 
            Caption         =   "Quatation Date wise"
         End
      End
      Begin VB.Menu in3 
         Caption         =   "Purchase Details"
      End
      Begin VB.Menu in4 
         Caption         =   "Receipt Details"
      End
      Begin VB.Menu in5 
         Caption         =   "Issue Details"
      End
      Begin VB.Menu in6 
         Caption         =   "Returns Details"
      End
      Begin VB.Menu in7 
         Caption         =   "Stock Status Details"
      End
      Begin VB.Menu in8 
         Caption         =   "Transaction Details"
      End
   End
   Begin VB.Menu exit 
      Caption         =   "Exit"
   End
End
Attribute VB_Name = "MDIForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub AD_Click()
Form1.Show
Form1.WindowState = 2
End Sub
Private Sub AD1_Click()
Form3.Show
Form3.WindowState = 2
End Sub
Private Sub ad2_Click()
Form5.Show
Form5.WindowState = 2
End Sub
Private Sub enquiry_Click()
Dim k As String
k = InputBox(" Enter enquiry Receipt Memo  Number", "Descrepancy Report")
CrystalReport2.ReportFileName = App.Path & "\enquiry1.rpt"
CrystalReport2.SelectionFormula = "{enqhdr.enqno}='" & k & "'"
CrystalReport2.Destination = crptToWindow
CrystalReport2.WindowState = crptMaximized
CrystalReport2.Action = 1
End Sub
Private Sub enquiry1_Click()
Dim x As Date
x = InputBox("Enter any date")
CrystalReport2.ReportFileName = App.Path & "\enquiry1.rpt"
CrystalReport2.SelectionFormula = " day({enqhdr.enqdate})=" & Day(x) & "and month({enqhdr.enqdate})=" & Month(x) & "and year({enqhdr.enqdate})=" & Year(x)
CrystalReport2.Destination = crptToWindow
CrystalReport2.WindowState = crptMaximized
CrystalReport2.Action = 1
End Sub
Private Sub exit_Click()
Unload Me
End Sub
Private Sub in3_Click()
CrystalReport4.Action = 1
End Sub
Private Sub in4_Click()
CrystalReport5.Action = 1
End Sub
Private Sub in5_Click()
CrystalReport6.Action = 1
End Sub
Private Sub in6_Click()
CrystalReport7.Action = 1
End Sub
Private Sub in7_Click()
CrystalReport8.Action = 1
End Sub
Private Sub in8_Click()
CrystalReport9.Action = 1
End Sub
Private Sub indent_Click()
Dim k As String
k = InputBox(" Enter Indent Receipt Memo  Number", "Descrepancy Report")
CrystalReport1.ReportFileName = App.Path & "\indent.rpt"
CrystalReport1.SelectionFormula = "{indhdr.indentno}='" & k & "'"
CrystalReport1.Destination = crptToWindow
CrystalReport1.WindowState = crptMaximized
CrystalReport1.Action = 1
End Sub
Private Sub indent1_Click()
Dim k As String
k = InputBox(" Enter Goods Receipt Memo  Number", "Descrepancy Report")
CrystalReport1.ReportFileName = App.Path & "\indent.rpt"
CrystalReport1.SelectionFormula = "{indhdr.indentno}='" & k & "'"
CrystalReport1.Destination = crptToWindow
CrystalReport1.WindowState = crptMaximized
CrystalReport1.Action = 1
End Sub
Private Sub item_Click()
Form8.Show
End Sub
Private Sub itemissu_Click()
Form11.Show
Form11.WindowState = 2
End Sub
Private Sub itemrep_Click()
Form10.Show
Form10.WindowState = 2
End Sub
Private Sub itemsretu_Click()
Form12.Show
Form12.WindowState = 2
End Sub
Private Sub MD_Click()
Form2.Show
Form2.WindowState = 2
End Sub
Private Sub MD1_Click()
Form4.Show
Form4.WindowState = 2
End Sub
Private Sub md2_Click()
Form6.Show
Form6.WindowState = 2
End Sub
Private Sub MDIForm_Load()
MDIForm1.Caption = "NAGARJUNA FERTILIZERS AND CHEMICALS LIMITED" + "  " & Date & "   " & Time
End Sub
Private Sub pur_Click()
Form9.Show
Form9.WindowState = 2
End Sub
Private Sub quatation_Click()
Dim k As String
k = InputBox(" Enter quatation Receipt Memo  Number", "Descrepancy Report")
CrystalReport3.ReportFileName = App.Path & "\quatation.rpt"
CrystalReport3.SelectionFormula = "{qutnhdr.qutno}='" & k & "'"
CrystalReport3.Destination = crptToWindow
CrystalReport3.WindowState = crptMaximized
CrystalReport3.Action = 1
End Sub
Private Sub quatation1_Click()
Dim x As Date
x = InputBox("Enter any date")
CrystalReport3.ReportFileName = App.Path & "\quatation.rpt"
CrystalReport3.SelectionFormula = " day({qutnhdr.reqdate})=" & Day(x) & "and month({qutnhdr.reqdate})=" & Month(x) & "and year({qutnhdr.reqdate})=" & Year(x)
CrystalReport3.Destination = crptToWindow
CrystalReport3.WindowState = crptMaximized
CrystalReport3.Action = 1
End Sub
Private Sub vender_Click()
Form7.Show
End Sub
