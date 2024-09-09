VERSION 5.00
Begin VB.Form Form9 
   BackColor       =   &H00FF8080&
   Caption         =   "Indian Gas Service"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   ControlBox      =   0   'False
   LinkTopic       =   "Form9"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.TextBox doc 
      Enabled         =   0   'False
      Height          =   375
      Left            =   4200
      TabIndex        =   22
      Top             =   5760
      Width           =   1695
   End
   Begin VB.TextBox add 
      Enabled         =   0   'False
      Height          =   375
      Left            =   4200
      TabIndex        =   21
      Top             =   5280
      Width           =   3735
   End
   Begin VB.TextBox name1 
      Enabled         =   0   'False
      Height          =   375
      Left            =   4200
      TabIndex        =   20
      Top             =   4800
      Width           =   2295
   End
   Begin VB.CommandButton cmdnext 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Next"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8280
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   2520
      Width           =   1575
   End
   Begin VB.TextBox mec 
      Height          =   375
      Left            =   4200
      TabIndex        =   7
      Top             =   7080
      Width           =   3375
   End
   Begin VB.TextBox rep 
      Height          =   375
      Left            =   4200
      TabIndex        =   6
      Top             =   6600
      Width           =   2055
   End
   Begin VB.CheckBox rrt 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Replacing Rubber Tube"
      Enabled         =   0   'False
      Height          =   375
      Left            =   840
      TabIndex        =   0
      Top             =   2280
      Width           =   2775
   End
   Begin VB.CheckBox lbf 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Low Burning Flame"
      Enabled         =   0   'False
      Height          =   255
      Left            =   840
      TabIndex        =   1
      Top             =   2880
      Width           =   2655
   End
   Begin VB.CheckBox cl 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Cylinder  Leakage"
      Enabled         =   0   'False
      Height          =   375
      Left            =   4200
      TabIndex        =   3
      Top             =   2280
      Width           =   2415
   End
   Begin VB.CheckBox wq 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Water Quantity In Cylinder"
      Enabled         =   0   'False
      Height          =   375
      Left            =   4200
      TabIndex        =   4
      Top             =   2760
      Width           =   3255
   End
   Begin VB.CheckBox lq 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Low Quantity of LPG"
      Enabled         =   0   'False
      Height          =   255
      Left            =   840
      TabIndex        =   2
      Top             =   3360
      Width           =   2175
   End
   Begin VB.TextBox cno 
      Enabled         =   0   'False
      Height          =   375
      Left            =   4200
      TabIndex        =   5
      Top             =   4320
      Width           =   1695
   End
   Begin VB.CommandButton cmdsubmit 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Submit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8280
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   3000
      Width           =   1575
   End
   Begin VB.CommandButton cmdcancel 
      BackColor       =   &H00C0E0FF&
      Caption         =   "&Back"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8280
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   3480
      Width           =   1575
   End
   Begin VB.Label Label12 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Mechanic Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   375
      Left            =   720
      TabIndex        =   18
      Top             =   7080
      Width           =   2415
   End
   Begin VB.Label Label11 
      BackColor       =   &H00E0E0E0&
      Caption         =   "Replace/Repair/Checked on  "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   375
      Left            =   720
      TabIndex        =   17
      Top             =   6600
      Width           =   3255
   End
   Begin VB.Shape Shape4 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   1335
      Left            =   600
      Top             =   6360
      Width           =   10815
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H8000000B&
      BackStyle       =   0  'Transparent
      Caption         =   "INDIAN GAS SERVICES"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Left            =   3360
      TabIndex        =   15
      Top             =   720
      Width           =   4410
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00008000&
      Caption         =   "Complaint Attempt"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   375
      Left            =   3000
      TabIndex        =   14
      Top             =   1560
      Width           =   4695
   End
   Begin VB.Label Label3 
      BackColor       =   &H0080C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "Connection No."
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Left            =   840
      TabIndex        =   13
      Top             =   4200
      Width           =   1815
   End
   Begin VB.Label Label4 
      BackColor       =   &H0080C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   " Name"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Left            =   840
      TabIndex        =   12
      Top             =   4680
      Width           =   1815
   End
   Begin VB.Label Label5 
      BackColor       =   &H0080C0FF&
      BackStyle       =   0  'Transparent
      Caption         =   "Address"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   495
      Left            =   840
      TabIndex        =   11
      Top             =   5160
      Width           =   1815
   End
   Begin VB.Label Label9 
      AutoSize        =   -1  'True
      BackColor       =   &H00E0E0E0&
      Caption         =   "Date of Complaint"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   285
      Left            =   840
      TabIndex        =   9
      Top             =   5640
      Width           =   1830
   End
   Begin VB.Shape Shape2 
      FillColor       =   &H00008000&
      FillStyle       =   0  'Solid
      Height          =   735
      Left            =   600
      Top             =   1440
      Width           =   10815
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "INDIAN GAS SERVICES"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FFFF&
      Height          =   495
      Left            =   3360
      TabIndex        =   16
      Top             =   720
      Width           =   4410
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   3375
      Left            =   600
      Top             =   600
      Width           =   10815
   End
   Begin VB.Shape Shape3 
      FillColor       =   &H00E0E0E0&
      FillStyle       =   0  'Solid
      Height          =   2175
      Left            =   600
      Top             =   4080
      Width           =   10815
   End
End
Attribute VB_Name = "Form9"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim con As Connection
Dim rst As Recordset
Dim cmd As Command

Private Sub Cmdcancel_Click()
Load Form8
Form8.Show
Unload Me
End Sub

Private Sub cmdnext_Click()
rrt.Value = 0
lbf.Value = 0
 wq.Value = 0
 lq.Value = 0
  cl.Value = 0
If rst.EOF = True And rst.BOF = True Then
    MsgBox "No records.................."
    Exit Sub
Else

    If rst.EOF = True And rst.BOF <> True Then
    rst.MoveFirst
    name1.Text = rst!c_name
    add.Text = rst!address
    cno.Text = rst!consumer_no
    doc.Text = rst!date_comp_rec
    rep.Text = Date
        If rst!rep_rubber_tube = "True" Then
            rrt.Value = 1
        Else
            rrt.Value = 0
        End If

        If rst!low_burning = "True" Then
             lbf.Value = 1
        Else
            lbf.Value = 0
        End If

        If rst!water_quantity = "True" Then
              wq.Value = 1
        Else
            wq.Value = 0
        End If

        If rst!low_lpg = "True" Then
             lq.Value = 1
        Else
            lq.Value = 0
        End If

        If rst!c_leakage = "True" Then
            cl.Value = 1
        Else
            cl.Value = 0
        End If

    Else
        name1.Text = rst!c_name
        add.Text = rst!address
        cno.Text = rst!consumer_no
        doc.Text = rst!date_comp_rec
        rep.Text = Date
        If rst!rep_rubber_tube = "True" Then
            rrt.Value = 1
         End If

        If rst!low_burning = "True" Then
             lbf.Value = 1
        End If

        If rst!water_quantity = "True" Then
             wq.Value = 1
        End If

        If rst!low_lpg = "True" Then
              lq.Value = 1
        End If

        If rst!c_leakage = "True" Then
              cl.Value = 1
        End If
    End If
rst.MoveNext
'rst.Requery

End If

End Sub

Private Sub Cmdsubmit_Click()
If mec.Text = "" Then
MsgBox "Enter mechanic name"
Exit Sub
End If
Set cmd = New Command

cmd.ActiveConnection = con

cmd.CommandText = "update complaint set checked_on='" & rep.Text & "',mecanic='" & Trim(mec.Text) & "' where complaint.consumer_no=" & CInt(cno.Text) & " "
cmd.CommandType = adCmdText
cmd.Execute
cno.Text = ""
name1.Text = ""
add.Text = ""
doc.Text = ""
rep.Text = ""
mec.Text = ""
rrt.Value = 0
lbf.Value = 0
cl.Value = 0
wq.Value = 0
lq.Value = 0
End Sub

Private Sub Form_Load()
Set con = New Connection
Set rst = New Recordset
With con
.ConnectionString = "Data source=gasdata;Initial Catalog=e:\gas\consumer"
.Provider = "MSDASQL"
.Open
End With

Set rst = New Recordset

rst.Open "select cd.c_name,cd.address,cd.consumer_no,cm.date_comp_rec,cm.rep_rubber_tube,cm.low_burning,cm.water_quantity,cm.low_lpg,cm.c_leakage from consumer_details cd,complaint cm " & _
" Where cd.consumer_no=cm.consumer_no and cm.mecanic IS NULL", con


name1.Text = rst!c_name
add.Text = rst!address
cno.Text = rst!consumer_no
doc.Text = rst!date_comp_rec
rep.Text = Date
If rst!rep_rubber_tube = "True" Then
    rrt.Value = 1
End If

If rst!low_burning = "True" Then
    lbf.Value = 1
End If

If rst!water_quantity = "True" Then
    wq.Value = 1
End If

If rst!low_lpg = "True" Then
    lq.Value = 1
End If

If rst!c_leakage = "True" Then
    cl.Value = 1
End If


End Sub

