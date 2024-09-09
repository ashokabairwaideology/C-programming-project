VERSION 5.00
Begin VB.Form frmSupplier 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Supplier Name"
   ClientHeight    =   5445
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6060
   Icon            =   "frmSupplier.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5445
   ScaleWidth      =   6060
   StartUpPosition =   2  'CenterScreen
   Begin VB.Data Data1 
      Caption         =   "db_Supplier"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   2400
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   5880
      Visible         =   0   'False
      Width           =   2775
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add"
      Height          =   375
      Left            =   1680
      TabIndex        =   21
      Top             =   4920
      Width           =   975
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "Save"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2760
      TabIndex        =   20
      Top             =   4920
      Width           =   975
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3840
      TabIndex        =   19
      Top             =   4920
      Width           =   975
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Height          =   375
      Left            =   4920
      TabIndex        =   18
      Top             =   4920
      Width           =   975
   End
   Begin VB.Frame fra_s 
      BackColor       =   &H00FEEADA&
      Enabled         =   0   'False
      Height          =   1485
      Index           =   1
      Left            =   120
      TabIndex        =   6
      Top             =   3240
      Width           =   5775
      Begin VB.TextBox txt_Remarks 
         Height          =   1005
         Left            =   1080
         MultiLine       =   -1  'True
         TabIndex        =   17
         Top             =   240
         Width           =   4455
      End
      Begin VB.Label Label9 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Remarks"
         Height          =   195
         Left            =   240
         TabIndex        =   7
         Top             =   240
         Width           =   630
      End
   End
   Begin VB.Frame fra_s 
      BackColor       =   &H00FEEADA&
      Enabled         =   0   'False
      Height          =   2490
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   600
      Width           =   5775
      Begin VB.TextBox txt_ContactNumber2 
         Height          =   285
         Left            =   1800
         TabIndex        =   22
         Top             =   2040
         Width           =   1575
      End
      Begin VB.TextBox txt_ContactNumber 
         Height          =   285
         Left            =   1800
         TabIndex        =   16
         Top             =   1680
         Width           =   1575
      End
      Begin VB.TextBox txt_ContactPerson 
         Height          =   285
         Left            =   1800
         TabIndex        =   15
         Top             =   1320
         Width           =   3735
      End
      Begin VB.TextBox txt_Zip 
         Height          =   285
         Left            =   4920
         TabIndex        =   14
         Top             =   960
         Width           =   615
      End
      Begin VB.TextBox txt_Province 
         Height          =   285
         Left            =   3480
         TabIndex        =   13
         Top             =   960
         Width           =   1335
      End
      Begin VB.TextBox txt_City 
         Height          =   285
         Left            =   1800
         TabIndex        =   12
         Top             =   960
         Width           =   1575
      End
      Begin VB.TextBox txt_StreetAddress 
         Height          =   285
         Left            =   1800
         TabIndex        =   11
         Top             =   600
         Width           =   3735
      End
      Begin VB.TextBox txt_Supplier 
         Height          =   285
         Left            =   1800
         TabIndex        =   10
         Top             =   240
         Width           =   3735
      End
      Begin VB.Label Label6 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Contact Number (CP)"
         Height          =   195
         Left            =   120
         TabIndex        =   23
         Top             =   2040
         Width           =   1500
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Supplier"
         Height          =   195
         Left            =   1065
         TabIndex        =   5
         Top             =   240
         Width           =   570
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Street Address"
         Height          =   195
         Left            =   600
         TabIndex        =   4
         Top             =   600
         Width           =   1035
      End
      Begin VB.Label Label4 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "City, Prov., Zip"
         Height          =   195
         Left            =   600
         TabIndex        =   3
         Top             =   960
         Width           =   1035
      End
      Begin VB.Label Label5 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Contact Number (Tel.)"
         Height          =   195
         Left            =   120
         TabIndex        =   2
         Top             =   1680
         Width           =   1560
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Contact Person"
         Height          =   195
         Left            =   540
         TabIndex        =   1
         Top             =   1320
         Width           =   1095
      End
   End
   Begin VB.Label lbl_SupplierNumber 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "XXXXX"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   285
      Left            =   2400
      TabIndex        =   9
      Top             =   120
      Width           =   825
   End
   Begin VB.Label Label11 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Supplier Number:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   2025
   End
End
Attribute VB_Name = "frmSupplier"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAdd_Click()
clear_all_fields
'frame
fra_s(0).Enabled = True
fra_s(1).Enabled = True
txt_Supplier.SetFocus
'controls
cmdAdd.Enabled = False
cmdSave.Enabled = True
cmdCancel.Enabled = True
Supplier_Number
End Sub

Private Sub cmdCancel_Click()
'frame
fra_s(0).Enabled = False
fra_s(1).Enabled = False
'controls
cmdAdd.Enabled = True
cmdSave.Enabled = False
cmdCancel.Enabled = False
clear_all_fields

End Sub

Private Sub cmdClose_Click()
Unload Me
End Sub

''''''''''''''''''''''''''''''''''''''''''''''''''
'Dito lahat ng pre-defined procedures
''''''''''''''''''''''''''''''''''''''''''''''''''

Private Sub clear_all_fields()
txt_Supplier.Text = ""
txt_StreetAddress.Text = ""
txt_City.Text = ""
txt_Province.Text = ""
txt_Zip.Text = ""
txt_ContactPerson.Text = ""
txt_ContactNumber.Text = ""
txt_Remarks.Text = ""
lbl_SupplierNumber.Caption = "XXXXX"
txt_ContactNumber2.Text = ""
End Sub

Private Sub Supplier_Number()
Dim container1
Dim SupCode
SupCode = "S-0"
SupCode = "S-" & Int(Mid(SupCode, 3)) + 1
Data1.RecordSource = "select * from tblSupplier where  Sup_Number = '" & SupCode & "'"
Data1.Refresh
While Data1.Recordset.RecordCount <> 0
        If Data1.Recordset.RecordCount <> 0 Then
            SupCode = "S-" & Int(Mid(SupCode, 3)) + 1
        End If
        Data1.RecordSource = "select * from tblSupplier where  Sup_Number= '" & SupCode & "'"
        Data1.Refresh
Wend
    lbl_SupplierNumber = SupCode
    Data1.DatabaseName = App.Path & "\CMJ.mdb"
    Data1.RecordSource = "select * from tblSupplier order by Sup_Number"
    Data1.Refresh
End Sub

Private Sub cmdSave_Click()
If txt_Supplier = "" Then
    MsgBox "Cannot save if supplier name is empty.", vbExclamation, "Supplier name is missing"
    txt_Supplier.SetFocus
    Exit Sub
End If

If txt_StreetAddress = "" Then
    MsgBox "Cannot save if street address is empty.", vbExclamation, "Street address name is missing"
    txt_StreetAddress.SetFocus
    Exit Sub
End If
If txt_StreetAddress = "" Then
    MsgBox "Cannot save if Street Address is empty.", vbExclamation, "Street Address is missing"
    txt_StreetAddress.SetFocus
    Exit Sub
End If
If txt_City = "" Then
    MsgBox "Cannot save if City or Town is empty.", vbExclamation, "City or Town is missing"
    txt_City.SetFocus
    Exit Sub
End If
If txt_Province = "" Then
    MsgBox "Cannot save if Province is empty.", vbExclamation, "Province is missing"
    txt_Province.SetFocus
    Exit Sub
End If
If txt_Zip.Text <> "" Then
    If IsNumeric(txt_Zip) = False Then
        MsgBox "Invalid Zip Code. Numbers only.", vbExclamation, "Invalid Zip Code"
        txt_Zip.SetFocus
        SendKeys "{home}" & "{end}"
        Exit Sub
    End If
End If
'If txt_ContactNumber <> "" Then
 If IsNumeric(txt_ContactNumber) = False Then
        MsgBox "Invalid Contact number. Numbers only.", vbExclamation, "Invalid contact number"
        txt_ContactNumber.SetFocus
        SendKeys "{home}" & "{end}"
        Exit Sub
 End If
 If IsNumeric(txt_ContactNumber2) = False Then
        MsgBox "Invalid Contact number. Numbers only.", vbExclamation, "Invalid contact number"
        txt_ContactNumber2.SetFocus
        SendKeys "{home}" & "{end}"
        Exit Sub
 End If
'End If
If txt_ContactPerson = "" Then
    MsgBox "Cannot save if contact person is empty.", vbExclamation, "Contact person is missing"
    txt_ContactPerson.SetFocus
    Exit Sub
End If

If MsgBox("Confirm save new supplier record.", vbQuestion + vbYesNo) = vbYes Then
    With Data1.Recordset
        .AddNew
            !sup_name = txt_Supplier.Text
            !sup_StreetAddress = txt_StreetAddress.Text
            !sup_City = txt_City.Text
            !sup_Province = txt_Province.Text
            !sup_Zip = Trim(txt_Zip.Text)
            !sup_Contactperson = txt_ContactPerson.Text
            !sup_contactnumber = Trim(txt_ContactNumber.Text)
            !sup_remarks = txt_Remarks.Text
            !sup_number = lbl_SupplierNumber.Caption
            !Sup_ContactNumber2 = txt_ContactNumber2.Text
        .Update
    End With
    Data1.Refresh
    MsgBox "New supplier record saved.", vbInformation
End If
cmdCancel_Click
End Sub

Private Sub Form_Load()
Data1.DatabaseName = App.Path & "\CMJ.mdb"
    Data1.RecordSource = "select * from tblSupplier"
    Data1.Refresh
End Sub


