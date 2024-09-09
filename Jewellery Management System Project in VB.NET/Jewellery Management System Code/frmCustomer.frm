VERSION 5.00
Begin VB.Form frmCustomer 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Customer Information"
   ClientHeight    =   5310
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5775
   Icon            =   "frmCustomer.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5310
   ScaleWidth      =   5775
   StartUpPosition =   2  'CenterScreen
   Begin VB.Data Data1 
      Caption         =   "Customer"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   1560
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6960
      Visible         =   0   'False
      Width           =   2775
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add"
      Height          =   375
      Left            =   1440
      TabIndex        =   26
      Top             =   4800
      Width           =   975
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "Save"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2520
      TabIndex        =   25
      Top             =   4800
      Width           =   975
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3600
      TabIndex        =   24
      Top             =   4800
      Width           =   975
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Height          =   375
      Left            =   4680
      TabIndex        =   23
      Top             =   4800
      Width           =   975
   End
   Begin VB.Frame fra_ci 
      BackColor       =   &H00FEEADA&
      Enabled         =   0   'False
      Height          =   1485
      Index           =   1
      Left            =   120
      TabIndex        =   20
      Top             =   3120
      Width           =   5535
      Begin VB.TextBox txt_Remarks 
         Height          =   1095
         Left            =   960
         MultiLine       =   -1  'True
         TabIndex        =   22
         Top             =   240
         Width           =   4335
      End
      Begin VB.Label Label9 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Remarks"
         Height          =   195
         Left            =   240
         TabIndex        =   21
         Top             =   240
         Width           =   630
      End
   End
   Begin VB.Frame fra_ci 
      BackColor       =   &H00FEEADA&
      Enabled         =   0   'False
      Height          =   2490
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   5535
      Begin VB.ComboBox combo_Sex 
         Height          =   315
         Left            =   3360
         TabIndex        =   19
         Top             =   2040
         Width           =   1215
      End
      Begin VB.TextBox txt_Birthdate 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   18
         Top             =   2040
         Width           =   1095
      End
      Begin VB.TextBox txt_ContactNumber 
         Height          =   285
         Left            =   1560
         TabIndex        =   17
         Top             =   1680
         Width           =   2055
      End
      Begin VB.TextBox txt_Zip 
         Height          =   285
         Left            =   4680
         TabIndex        =   16
         Top             =   1320
         Width           =   615
      End
      Begin VB.TextBox txt_Province 
         Height          =   285
         Left            =   3240
         TabIndex        =   15
         Top             =   1320
         Width           =   1335
      End
      Begin VB.TextBox txt_City 
         Height          =   285
         Left            =   1560
         TabIndex        =   14
         Top             =   1320
         Width           =   1575
      End
      Begin VB.TextBox txt_StreetAddress 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   13
         Top             =   960
         Width           =   3735
      End
      Begin VB.TextBox txt_Lastname 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   12
         Top             =   600
         Width           =   3735
      End
      Begin VB.TextBox txt_MI 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   3720
         TabIndex        =   11
         Top             =   240
         Width           =   1575
      End
      Begin VB.TextBox txt_Firstname 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   10
         Top             =   240
         Width           =   2055
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "First Name, MI"
         Height          =   195
         Left            =   360
         TabIndex        =   7
         Top             =   240
         Width           =   1020
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Last Name"
         Height          =   195
         Left            =   640
         TabIndex        =   6
         Top             =   600
         Width           =   765
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Street Address"
         Height          =   195
         Left            =   370
         TabIndex        =   5
         Top             =   960
         Width           =   1035
      End
      Begin VB.Label Label4 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "City, Prov.,Zip"
         Height          =   195
         Left            =   420
         TabIndex        =   4
         Top             =   1320
         Width           =   990
      End
      Begin VB.Label Label5 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Contact Number"
         Height          =   195
         Left            =   250
         TabIndex        =   3
         Top             =   1680
         Width           =   1155
      End
      Begin VB.Label Label14 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Birthdate"
         Height          =   195
         Left            =   775
         TabIndex        =   2
         Top             =   2040
         Width           =   630
      End
      Begin VB.Label Label13 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Sex"
         Height          =   195
         Left            =   2760
         TabIndex        =   1
         Top             =   2040
         Width           =   270
      End
   End
   Begin VB.Label Label11 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Customer Number:"
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
      TabIndex        =   9
      Top             =   120
      Width           =   2190
   End
   Begin VB.Label lbl_CustomerNumber 
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
      TabIndex        =   8
      Top             =   120
      Width           =   825
   End
End
Attribute VB_Name = "frmCustomer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim ans

Private Sub cmdAdd_Click()
clear_all_fields
'frame
fra_ci(0).Enabled = True
fra_ci(1).Enabled = True
txt_Firstname.SetFocus
'controls
cmdAdd.Enabled = False
cmdSave.Enabled = True
cmdCancel.Enabled = True
Customer_Number
End Sub

Private Sub cmdCancel_Click()
'frame
fra_ci(0).Enabled = False
fra_ci(1).Enabled = False
'controls
cmdAdd.Enabled = True
cmdSave.Enabled = False
cmdCancel.Enabled = False
clear_all_fields
End Sub

Private Sub cmdClose_Click()
Unload Me
End Sub

Private Sub cmdSave_Click()
If txt_Firstname = "" Then
    MsgBox "Cannot save if Firstname is empty.", vbExclamation, "Firstname is missing"
    txt_Firstname.SetFocus
    Exit Sub
End If
If txt_MI = "" Then
    MsgBox "Cannot save if Middle Initial is empty.", vbExclamation, "Middle Initial is missing"
    txt_MI.SetFocus
    Exit Sub
End If
If txt_Lastname = "" Then
    MsgBox "Cannot save if Lastname is empty.", vbExclamation, "Lastname is missing"
    txt_Lastname.SetFocus
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
If txt_ContactNumber <> "" Then
    If IsNumeric(txt_ContactNumber) = False Then
        MsgBox "Invalid Contact number. Numbers only.", vbExclamation, "Invalid contact number"
        txt_ContactNumber.SetFocus
        SendKeys "{home}" & "{end}"
        Exit Sub
    End If
End If
If txt_Birthdate = "" Then
    MsgBox "Cannot save if Birthdate is empty.", vbExclamation, "Birthdate is missing"
    txt_Birthdate.SetFocus
    Exit Sub
End If
If combo_sex = "" Then
    MsgBox "Cannot save if Gender is empty.", vbExclamation, "Gender is missing"
    combo_sex.SetFocus
    Exit Sub
End If

If MsgBox("Confirm save new customer record.", vbQuestion + vbYesNo) = vbYes Then
    With Data1.Recordset
        .AddNew
            !Cust_Firstname = txt_Firstname.Text
            !Cust_MI = txt_MI.Text
            !Cust_Lastname = txt_Lastname.Text
            !Cust_StreetAddress = txt_StreetAddress.Text
            !Cust_City = txt_City.Text
            !Cust_Province = txt_Province.Text
            !Cust_Zip = Trim(txt_Zip.Text)
            !Cust_ContactNumber = Trim(txt_ContactNumber.Text)
            !Cust_birthdate = txt_Birthdate.Text
            !Cust_sex = combo_sex.Text
            !Cust_remarks = txt_Remarks.Text
            !Cust_Number = lbl_CustomerNumber.Caption
        .Update
    End With
    Data1.Refresh
    MsgBox "New customer record saved.", vbInformation
End If

'frame
fra_ci(0).Enabled = False
fra_ci(1).Enabled = False
'controls
cmdAdd.Enabled = True
cmdSave.Enabled = False
cmdCancel.Enabled = False
clear_all_fields
End Sub

Private Sub Form_Load()
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblCustomer order by Cust_Number"
Data1.Refresh
    
combo_sex.Clear
combo_sex.AddItem "Male"
combo_sex.AddItem "Female"
End Sub


''''''''''''''''''''''''''''''''''''''''''''''''''
'Dito lahat ng pre-defined procedures
''''''''''''''''''''''''''''''''''''''''''''''''''

Private Sub clear_all_fields()
txt_Firstname.Text = ""
txt_MI.Text = ""
txt_Lastname.Text = ""
txt_StreetAddress.Text = ""
txt_City.Text = ""
txt_Province.Text = ""
txt_Zip.Text = ""
txt_ContactNumber.Text = ""
txt_Birthdate.Text = ""
combo_sex.Text = ""
txt_Remarks.Text = ""
lbl_CustomerNumber.Caption = "XXXXX"
End Sub
Private Sub Customer_Number()
Dim container1
Dim CustCode
CustCode = "C-0"
CustCode = "C-" & Int(Mid(CustCode, 3)) + 1
Data1.RecordSource = "select * from tblCustomer where  Cust_Number = '" & CustCode & "'"
Data1.Refresh
While Data1.Recordset.RecordCount <> 0
        If Data1.Recordset.RecordCount <> 0 Then
            CustCode = "C-" & Int(Mid(CustCode, 3)) + 1
        End If
        Data1.RecordSource = "select * from tblCustomer where  Cust_Number= '" & CustCode & "'"
        Data1.Refresh
Wend
    lbl_CustomerNumber = CustCode
    Data1.DatabaseName = App.Path & "\CMJ.mdb"
    Data1.RecordSource = "select * from tblCustomer order by Cust_Number"
    Data1.Refresh
End Sub

