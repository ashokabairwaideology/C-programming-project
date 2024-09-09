VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmEmployee 
   BackColor       =   &H00FEEADA&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Employee's Information"
   ClientHeight    =   6165
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7830
   Icon            =   "frmEmployee.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6165
   ScaleWidth      =   7830
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmd_ClearPicture 
      Caption         =   "Clear Picture"
      Enabled         =   0   'False
      Height          =   375
      Left            =   5640
      TabIndex        =   33
      Top             =   3000
      Width           =   1935
   End
   Begin VB.CommandButton cmd_LoadPicture 
      Caption         =   "Load Picture"
      Enabled         =   0   'False
      Height          =   375
      Left            =   5640
      TabIndex        =   32
      Top             =   2520
      Width           =   1935
   End
   Begin MSComDlg.CommonDialog CommDlg_Path 
      Left            =   7200
      Top             =   5640
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00FEEADA&
      Height          =   1935
      Left            =   5640
      TabIndex        =   31
      Top             =   480
      Width           =   1935
      Begin VB.Image Img_Emp 
         Height          =   1575
         Left            =   120
         Stretch         =   -1  'True
         Top             =   240
         Width           =   1695
      End
   End
   Begin VB.Data Data1 
      Caption         =   "Employee"
      Connect         =   "Access"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   ""
      Top             =   6600
      Visible         =   0   'False
      Width           =   3375
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Height          =   375
      Left            =   4560
      TabIndex        =   28
      Top             =   5640
      Width           =   975
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3480
      TabIndex        =   27
      Top             =   5640
      Width           =   975
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "Save"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2400
      TabIndex        =   26
      Top             =   5640
      Width           =   975
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add"
      Height          =   375
      Left            =   1320
      TabIndex        =   25
      Top             =   5640
      Width           =   975
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FEEADA&
      Enabled         =   0   'False
      Height          =   1455
      Left            =   120
      TabIndex        =   22
      Top             =   3960
      Width           =   5415
      Begin VB.TextBox txt_Remark 
         Height          =   1095
         Left            =   1080
         TabIndex        =   23
         Top             =   240
         Width           =   4215
      End
      Begin VB.Label Label9 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Remarks"
         Height          =   195
         Index           =   1
         Left            =   240
         TabIndex        =   24
         Top             =   240
         Width           =   630
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FEEADA&
      Enabled         =   0   'False
      Height          =   3375
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   5415
      Begin VB.ComboBox combo_sex 
         Height          =   315
         Left            =   1560
         TabIndex        =   21
         Top             =   2880
         Width           =   1095
      End
      Begin VB.TextBox txt_birthplace 
         Height          =   285
         Left            =   3600
         TabIndex        =   20
         Top             =   2520
         Width           =   1695
      End
      Begin VB.TextBox txt_birthday 
         Height          =   285
         Left            =   1560
         TabIndex        =   19
         Top             =   2520
         Width           =   1095
      End
      Begin VB.TextBox txt_ContactNumber 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   18
         Top             =   2160
         Width           =   2055
      End
      Begin VB.TextBox txt_Zip 
         Height          =   285
         Left            =   4680
         TabIndex        =   17
         Top             =   1800
         Width           =   615
      End
      Begin VB.TextBox txt_Province 
         Height          =   285
         Left            =   3240
         TabIndex        =   16
         Top             =   1800
         Width           =   1335
      End
      Begin VB.TextBox txt_City 
         Height          =   285
         Left            =   1560
         TabIndex        =   15
         Top             =   1800
         Width           =   1575
      End
      Begin VB.TextBox txt_StreetAddress 
         Height          =   285
         Left            =   1560
         TabIndex        =   14
         Top             =   1440
         Width           =   3735
      End
      Begin VB.TextBox txt_Lastname 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   13
         Top             =   1080
         Width           =   3735
      End
      Begin VB.TextBox txt_MI 
         Height          =   285
         Left            =   4200
         TabIndex        =   12
         Top             =   720
         Width           =   1095
      End
      Begin VB.TextBox txt_FirstName 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   11
         Top             =   720
         Width           =   2535
      End
      Begin VB.TextBox txt_NickName 
         BackColor       =   &H00CCE7FB&
         Height          =   285
         Left            =   1560
         TabIndex        =   10
         Top             =   360
         Width           =   2055
      End
      Begin VB.Label Label5 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Contact Number"
         Height          =   195
         Left            =   240
         TabIndex        =   9
         Top             =   2160
         Width           =   1155
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "City, Prov., Zip"
         Height          =   195
         Left            =   360
         TabIndex        =   8
         Top             =   1800
         Width           =   1035
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Street Address"
         Height          =   195
         Left            =   360
         TabIndex        =   7
         Top             =   1440
         Width           =   1035
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Last Name"
         Height          =   195
         Left            =   630
         TabIndex        =   6
         Top             =   1080
         Width           =   765
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "First Name, M.I."
         Height          =   195
         Left            =   285
         TabIndex        =   5
         Top             =   720
         Width           =   1110
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Nick Name"
         Height          =   195
         Left            =   600
         TabIndex        =   4
         Top             =   360
         Width           =   795
      End
      Begin VB.Label Label7 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Birthday"
         Height          =   195
         Left            =   825
         TabIndex        =   3
         Top             =   2520
         Width           =   570
      End
      Begin VB.Label Label8 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "BirthPlace"
         Height          =   195
         Left            =   2715
         TabIndex        =   2
         Top             =   2520
         Width           =   720
      End
      Begin VB.Label Label10 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Sex"
         Height          =   195
         Left            =   1095
         TabIndex        =   1
         Top             =   2880
         Width           =   270
      End
   End
   Begin VB.Label lbl_EmployeeNumber 
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
      TabIndex        =   30
      Top             =   120
      Width           =   825
   End
   Begin VB.Label Label11 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Employee Number:"
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
      TabIndex        =   29
      Top             =   120
      Width           =   2205
   End
End
Attribute VB_Name = "frmEmployee"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim ans

Private Sub cmd_ClearPicture_Click()
CommDlg_Path.FileName = ""
Img_Emp.Picture = LoadPicture()
End Sub

Private Sub cmd_LoadPicture_Click()
With CommDlg_Path
    .DialogTitle = "Search Employee picture"
    .Filter = "Bitmap (*.bmp)|*.bmp|Jpeg (*.jpg)|*.jpg|Gif (*.gif)|*.gif|All Files (*.*)|*.*"
    .Flags = cdlOFNHideReadOnly + cdlOFNOverwritePrompt + cdlOFNPathMustExist
    .ShowOpen
    .FilterIndex = 1
    .CancelError = True
Img_Emp.Picture = LoadPicture(.FileName)
End With

End Sub

Private Sub cmdAdd_Click()
Frame1.Enabled = True
Frame2.Enabled = True
txt_NickName.SetFocus
'controls
cmdAdd.Enabled = False
cmdSave.Enabled = True
cmdCancel.Enabled = True
cmd_LoadPicture.Enabled = True
cmd_ClearPicture.Enabled = True
Employee_Number

End Sub

Private Sub cmdCancel_Click()
'controls
Frame1.Enabled = False
Frame2.Enabled = False
'controls
cmdAdd.Enabled = True
cmdSave.Enabled = False
cmdCancel.Enabled = False
cmd_LoadPicture.Enabled = False
cmd_ClearPicture.Enabled = False
clear_all_fields
End Sub

Private Sub cmdClose_Click()
Unload Me
End Sub

Private Sub cmdSave_Click()
If txt_NickName = "" Then
    MsgBox "Cannot save if Nickname is empty.", vbExclamation, "Nickname is missing"
    txt_NickName.SetFocus
    Exit Sub
End If

If txt_Firstname = "" Then
    MsgBox "Cannot save if Firstname is empty,", vbExclamation, "Firstname is missing"
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
    MsgBox "Cannot save if City is empty.", vbExclamation, "City is missing"
    txt_City.SetFocus
    Exit Sub
End If
If txt_Province = "" Then
    MsgBox "Cannot save if Province is empty.", vbExclamation, "Province is missing"
    txt_Province.SetFocus
    Exit Sub
End If
If txt_Zip = "" Then
    MsgBox "Cannot save if Zip Code is empty.", vbExclamation, "Zip Code is missing"
    txt_Zip.SetFocus
    Exit Sub
End If
If txt_birthday = "" Then
    MsgBox "Cannot save if Birthday is empty.", vbExclamation, "Birth date is missing"
    txt_birthday.SetFocus
    Exit Sub
End If
If IsDate(txt_birthday.Text) = False Then
    MsgBox "Invalid birthdate. Try again.", vbExclamation, "Error birth date"
    txt_birthday.SetFocus
    SendKeys "{home}" & "{end}"
End If
'check if contact number is a valid numbers
If txt_ContactNumber.Text <> "" Then
    If IsNumeric(txt_ContactNumber.Text) = False Then
        MsgBox "Invalid contact number. Try again.", vbExclamation, "Error contact number"
        txt_ContactNumber.SetFocus
        SendKeys "{home}" & "{end}"
        Exit Sub
    End If
End If
If txt_birthplace.Text = "" Then
    MsgBox "Cannot save if Birthplace is empty.", vbExclamation, "Birth place is missing"
    txt_birthplace.SetFocus
    Exit Sub
End If

If combo_sex.Text = "" Then
    MsgBox "Cannot save if Gender is empty.", vbExclamation, "Gender is missing"
    combo_sex.SetFocus
    Exit Sub
End If

If MsgBox("Confirm add new Employee Record.", vbQuestion + vbYesNo) = vbYes Then
    
    With Data1.Recordset
        .AddNew
            !Emp_Nick_Name = UCase(txt_NickName.Text)
            !Emp_FirstName = txt_Firstname.Text
            !Emp_MI = txt_MI.Text
            !Emp_LastName = txt_Lastname.Text
            !Emp_StreetAddress = txt_StreetAddress.Text
            !Emp_City = txt_City.Text
            !Emp_Province = txt_Province.Text
            !Emp_Zip = Trim(txt_Zip.Text)
            !Emp_ContactNumber = Trim(txt_ContactNumber.Text)
            !emp_birthday = txt_birthday.Text
            !emp_birthplace = txt_birthplace.Text
            !emp_sex = combo_sex.Text
            !emp_remark = txt_Remark.Text
            !Emp_Number = lbl_EmployeeNumber.Caption
            !emp_pic = CommDlg_Path.FileName
        .Update
    End With
    Data1.Refresh
    MsgBox "Employee information save.", vbInformation
    
End If
clear_all_fields
'controls
cmdAdd.Enabled = True
cmdSave.Enabled = False
cmdCancel.Enabled = True
cmd_LoadPicture.Enabled = False
cmd_ClearPicture.Enabled = False

End Sub
Private Sub clear_all_fields()
    txt_NickName.Text = ""
    txt_Firstname.Text = ""
    txt_MI.Text = ""
    txt_Lastname.Text = ""
    txt_StreetAddress.Text = ""
    txt_City.Text = ""
    txt_Province.Text = ""
    txt_Zip.Text = ""
    txt_ContactNumber.Text = ""
    txt_birthday.Text = ""
    txt_birthplace.Text = ""
    combo_sex.Text = ""
    txt_Remark.Text = ""
    lbl_EmployeeNumber.Caption = "XXXXX"
    cmd_ClearPicture_Click
End Sub
Private Sub Form_Load()
Data1.DatabaseName = App.Path & "\CMJ.mdb"
Data1.RecordSource = "select * from tblEmployee"
Data1.Refresh
combo_sex.Clear
combo_sex.AddItem "Male"
combo_sex.AddItem "Female"
End Sub
Private Sub Employee_Number()
Dim container1
Dim EmpCode
EmpCode = "CMJ-Emp-0000"
EmpCode = "CMJ-Emp-" & Int(Mid(EmpCode, 9)) + 1
Data1.RecordSource = "select * from tblEmployee where  Emp_Number = '" & EmpCode & "'"
Data1.Refresh
While Data1.Recordset.RecordCount <> 0
        If Data1.Recordset.RecordCount <> 0 Then
            EmpCode = "CMJ-Emp-" & Int(Mid(EmpCode, 9)) + 1
        End If
        Data1.RecordSource = "select * from tblEmployee where  Emp_Number= '" & EmpCode & "'"
        Data1.Refresh
Wend
    lbl_EmployeeNumber = EmpCode
    Data1.DatabaseName = App.Path & "\CMJ.mdb"
    Data1.RecordSource = "select * from tblEmployee order by Emp_Number"
    Data1.Refresh
End Sub

