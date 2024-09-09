<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class TrainingSelForm
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
        Me.MDIParent = RI_HRM.MDIForm1
        RI_HRM.MDIForm1.Show()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Text2 As System.Windows.Forms.TextBox
    Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents butSave As System.Windows.Forms.Button
	Public WithEvents ButClose As System.Windows.Forms.Button
	Public WithEvents MSF As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents MSF1 As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Fromdate As AxMSComCtl2.AxDTPicker
	Public WithEvents toDate As AxMSComCtl2.AxDTPicker
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainingSelForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.butSave = New System.Windows.Forms.Button
        Me.ButClose = New System.Windows.Forms.Button
        Me.MSF = New AxMSFlexGridLib.AxMSFlexGrid
        Me.MSF1 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Fromdate = New AxMSComCtl2.AxDTPicker
        Me.toDate = New AxMSComCtl2.AxDTPicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fromdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(520, 24)
        Me.Text2.MaxLength = 50
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(113, 23)
        Me.Text2.TabIndex = 13
        '
        'Combo1
        '
        Me.Combo1.BackColor = System.Drawing.SystemColors.Window
        Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo1.Location = New System.Drawing.Point(344, 24)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo1.Size = New System.Drawing.Size(153, 24)
        Me.Combo1.TabIndex = 6
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.butSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSave.Location = New System.Drawing.Point(344, 392)
        Me.butSave.Name = "butSave"
        Me.butSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.butSave.Size = New System.Drawing.Size(89, 25)
        Me.butSave.TabIndex = 5
        Me.butSave.Text = "&Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButClose.Location = New System.Drawing.Point(560, 392)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButClose.Size = New System.Drawing.Size(73, 25)
        Me.ButClose.TabIndex = 4
        Me.ButClose.Text = "&Close"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'MSF
        '
        Me.MSF.Location = New System.Drawing.Point(8, 104)
        Me.MSF.Name = "MSF"
        Me.MSF.OcxState = CType(resources.GetObject("MSF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSF.Size = New System.Drawing.Size(281, 281)
        Me.MSF.TabIndex = 0
        '
        'MSF1
        '
        Me.MSF1.Location = New System.Drawing.Point(344, 104)
        Me.MSF1.Name = "MSF1"
        Me.MSF1.OcxState = CType(resources.GetObject("MSF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSF1.Size = New System.Drawing.Size(289, 281)
        Me.MSF1.TabIndex = 3
        '
        'Fromdate
        '
        Me.Fromdate.Location = New System.Drawing.Point(344, 64)
        Me.Fromdate.Name = "Fromdate"
        Me.Fromdate.OcxState = CType(resources.GetObject("Fromdate.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fromdate.Size = New System.Drawing.Size(113, 25)
        Me.Fromdate.TabIndex = 8
        '
        'toDate
        '
        Me.toDate.Location = New System.Drawing.Point(520, 64)
        Me.toDate.Name = "toDate"
        Me.toDate.OcxState = CType(resources.GetObject("toDate.OcxState"), System.Windows.Forms.AxHost.State)
        Me.toDate.Size = New System.Drawing.Size(113, 25)
        Me.toDate.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(520, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Batch No"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(520, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "To Date"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(344, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "From Date"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(344, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Training Name"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(264, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "List of Employees"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(344, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(289, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Selected Employees for training"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrainingSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 438)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.MSF)
        Me.Controls.Add(Me.MSF1)
        Me.Controls.Add(Me.Fromdate)
        Me.Controls.Add(Me.toDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TrainingSelForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Employee Training Selection"
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fromdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
#End Region 
End Class