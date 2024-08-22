
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim status As Boolean
    Dim UP As New OleDb.OleDbCommand
    Dim Con As New OleDb.OleDbConnection
    Dim Read As OleDb.OleDbDataReader


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnlogin = New System.Windows.Forms.Button
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnlogin)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login form"
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(184, 112)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(88, 32)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "cancel"
        '
        'btnlogin
        '
        Me.btnlogin.Image = CType(resources.GetObject("btnlogin.Image"), System.Drawing.Image)
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.Location = New System.Drawing.Point(80, 112)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 32)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Login"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(160, 72)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.TabIndex = 3
        Me.txtpass.Text = ""
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(160, 32)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.TabIndex = 2
        Me.txtuser.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 214)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Login Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try

            Dim tr As New ZieZoDB
            Con = tr.Main
            UP.Connection = Con
            UP.CommandType = CommandType.Text
            UP.CommandText = "Select * From TableUser Where username=? And password=?"
            'if empty field
            If txtuser.Text.Trim = "" Then
                MessageBox.Show("Please fill your User Name !", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtuser.Focus()
                Exit Sub
            End If
            'if empty field
            If txtpass.Text.Trim = "" Then
                MessageBox.Show("Please fill your Password !", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpass.Focus()
                Exit Sub
            End If
            'get values for username and password textbox
            'gv.UserName = txtUser.Text
            'gv.userID = "1"
            UP.Parameters.Add("username", Data.OleDb.OleDbType.Variant)
            UP.Parameters.Add("password", Data.OleDb.OleDbType.Variant)
            UP.Parameters("username").Value = txtuser.Text
            UP.Parameters("password").Value = txtpass.Text
            'Con.Open()

            Read = UP.ExecuteReader
            ar()
            Con.Close()
            Me.Hide()


        Catch EX As System.Exception

            'VarModuleName = Login.vb
            'VarProcedureName = btnok_Click_1

            MsgBox(EX.Message)

        End Try
    End Sub

    Private Sub ar()
        Try

            With Read
                If .Read Then
                    'MessageBox.Show("Access Granted !.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Dim CurrentForm As New MainMenu
                    'CurrentForm = New Initialization
                    CurrentForm.Show()
                Else
                    'clear all the textbox and display error message
                    txtuser.Clear()
                    txtpass.Clear()
                    MessageBox.Show("Invalid User Name or Password !", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                txtuser.Focus()
            End With

        Catch EX As System.Exception

            'VarModuleName = Login.vb
            'VarProcedureName = ar

            MsgBox(EX.Message)

        End Try

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Application.Exit()
    End Sub
End Class
