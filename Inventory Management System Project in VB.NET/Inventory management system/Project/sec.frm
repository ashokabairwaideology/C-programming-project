VERSION 5.00
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H8000000C&
   Caption         =   "MDIForm1"
   ClientHeight    =   5970
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   9165
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.PictureBox ENQCR 
      Align           =   1  'Align Top
      Height          =   480
      Left            =   0
      ScaleHeight     =   420
      ScaleWidth      =   9105
      TabIndex        =   0
      Top             =   0
      Width           =   9165
   End
   Begin VB.Menu ppur 
      Caption         =   "&Purchase"
      Begin VB.Menu vven 
         Caption         =   "&Vendormaster"
      End
      Begin VB.Menu iitem 
         Caption         =   "&Item code master"
      End
      Begin VB.Menu iitemindent 
         Caption         =   "&Item Indent"
         Begin VB.Menu nnewindent 
            Caption         =   "New Indent"
         End
         Begin VB.Menu imodifydelete 
            Caption         =   "Modify/Delete"
            Index           =   1
         End
      End
      Begin VB.Menu iitemenq 
         Caption         =   "&Item Enquiry"
         Begin VB.Menu nnewenquery 
            Caption         =   "New Enquiry"
         End
         Begin VB.Menu emmodifydelete 
            Caption         =   "Modify/Delete"
         End
      End
      Begin VB.Menu qquatation 
         Caption         =   "&Quatation"
         Begin VB.Menu newquatation 
            Caption         =   "New Quatation"
         End
         Begin VB.Menu qmmodifydelete 
            Caption         =   "Modify/Delete"
         End
      End
      Begin VB.Menu ppurchaseorder 
         Caption         =   "&Purchase Order"
      End
   End
   Begin VB.Menu sstores 
      Caption         =   "&Stores"
      Begin VB.Menu iitemreceipt 
         Caption         =   "&Item Receipt"
      End
      Begin VB.Menu iitemissues 
         Caption         =   "&Item Issues"
      End
      Begin VB.Menu iitemreturns 
         Caption         =   "&Item Returns"
      End
   End
   Begin VB.Menu rreports 
      Caption         =   "&Reports"
      Begin VB.Menu iindentdetails 
         Caption         =   "&Indent Details"
         Begin VB.Menu iindentnumberwise 
            Caption         =   "Indent Number wise"
         End
         Begin VB.Menu iindentdatewise 
            Caption         =   "Indent Date wise"
         End
      End
      Begin VB.Menu eenquerydetails 
         Caption         =   "&Enquiry Details"
         Begin VB.Menu eenqurynumberwise 
            Caption         =   "Enquiry Number wise"
         End
         Begin VB.Menu eenqurydatewise 
            Caption         =   "Enquiry Date wise"
         End
      End
      Begin VB.Menu qquatatindatils 
         Caption         =   "&Quatation Details"
         Begin VB.Menu qquatationnumberwise 
            Caption         =   "Quatation Number wise"
         End
      End
      Begin VB.Menu ppurchasedetails 
         Caption         =   "&Purchase Details"
      End
      Begin VB.Menu rreceiptdetails 
         Caption         =   "&Receipt Details"
      End
      Begin VB.Menu iissuedetails 
         Caption         =   "&Issue Details"
      End
      Begin VB.Menu rreturndetails 
         Caption         =   "&Return Details"
      End
      Begin VB.Menu sstockstatusdetails 
         Caption         =   "&Stock Status Details"
      End
      Begin VB.Menu ttransactiondetails 
         Caption         =   "&Transaction Details"
      End
   End
   Begin VB.Menu eexit 
      Caption         =   "&Exit"
   End
End
Attribute VB_Name = "MDIForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub eenqurydatewise_Click()
ItemEnquiryReportByDateWise.Show
End Sub
Private Sub eenqurynumberwise_Click()
ItemEnquiryReportByNumberWise.Show
End Sub
Private Sub eexit_Click()
Call closing
End
End Sub
Private Sub iindentdatewise_Click()
ItemIndentReportbydatewise.Show
End Sub

Private Sub iindentnumberwise_Click()
ItemIndenReport.Show
End Sub
Private Sub iissuedetails_Click()
ItemIssueReport.Show
End Sub
Private Sub iitem_Click()
Form8.Show
End Sub
Private Sub iitemissues_Click()
Form11.Show
End Sub
Private Sub iitemreceipt_Click()
form10.Show
End Sub
Private Sub iitemreturns_Click()
Form12.Show
End Sub

Private Sub MDIForm_Load()
MDIForm1.Caption = "SEC INDUSTRIES" & "   " & Date & "  " & Time
End Sub

Private Sub newquatation_Click()
Form5.Show
End Sub
Private Sub nnewenquery_Click()
Form3.Show
End Sub
Private Sub nnewindent_Click()
Form1.Show
End Sub
Private Sub ppurchasedetails_Click()
PurchaseDetailsReport.Show
End Sub
Private Sub ppurchaseorder_Click()
form15.Show
End Sub
Private Sub qquatationdatewise_Click()

End Sub


Private Sub qquatationnumberwise_Click()
QuatationReportByNoWise.Show
End Sub
Private Sub rreceiptdetails_Click()
ItemReceiptReport.Show

End Sub
Private Sub rreturndetails_Click()
ItemReturnReport.Show
End Sub
Private Sub sstockstatusdetails_Click()
stockstatusreport.Show
End Sub

Private Sub ttransactiondetails_Click()
itemtransactionreport.Show
End Sub

Private Sub vven_Click()
Form7.Show
End Sub
