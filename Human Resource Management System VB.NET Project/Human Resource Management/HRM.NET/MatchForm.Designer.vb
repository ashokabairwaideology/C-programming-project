<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MatchForm
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
	Public WithEvents butSave As System.Windows.Forms.Button
	Public WithEvents ButClose As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents MSF As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents MSF1 As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents L5 As System.Windows.Forms.Label
	Public WithEvents L4 As System.Windows.Forms.Label
	Public WithEvents L3 As System.Windows.Forms.Label
	Public WithEvents L2 As System.Windows.Forms.Label
	Public WithEvents L1 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MatchForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.butSave = New System.Windows.Forms.Button
        Me.ButClose = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.MSF = New AxMSFlexGridLib.AxMSFlexGrid
        Me.MSF1 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.L5 = New System.Windows.Forms.Label
        Me.L4 = New System.Windows.Forms.Label
        Me.L3 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.L1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.butSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSave.Location = New System.Drawing.Point(328, 368)
        Me.butSave.Name = "butSave"
        Me.butSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.butSave.Size = New System.Drawing.Size(121, 25)
        Me.butSave.TabIndex = 13
        Me.butSave.Text = "&Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButClose.Location = New System.Drawing.Point(536, 368)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButClose.Size = New System.Drawing.Size(105, 25)
        Me.ButClose.TabIndex = 12
        Me.ButClose.Text = "&Close"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(8, 160)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(129, 25)
        Me.Command2.TabIndex = 10
        Me.Command2.Text = "&Refresh"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(320, 160)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(129, 25)
        Me.Command1.TabIndex = 6
        Me.Command1.Text = "&Search"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'MSF
        '
        Me.MSF.Location = New System.Drawing.Point(8, 24)
        Me.MSF.Name = "MSF"
        Me.MSF.OcxState = CType(resources.GetObject("MSF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSF.Size = New System.Drawing.Size(441, 129)
        Me.MSF.TabIndex = 0
        '
        'MSF1
        '
        Me.MSF1.Location = New System.Drawing.Point(16, 216)
        Me.MSF1.Name = "MSF1"
        Me.MSF1.OcxState = CType(resources.GetObject("MSF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSF1.Size = New System.Drawing.Size(433, 145)
        Me.MSF1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(472, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Job No : "
        '
        'L5
        '
        Me.L5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L5.Cursor = System.Windows.Forms.Cursors.Default
        Me.L5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.L5.Location = New System.Drawing.Point(472, 128)
        Me.L5.Name = "L5"
        Me.L5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L5.Size = New System.Drawing.Size(169, 17)
        Me.L5.TabIndex = 11
        '
        'L4
        '
        Me.L4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L4.Cursor = System.Windows.Forms.Cursors.Default
        Me.L4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.L4.Location = New System.Drawing.Point(472, 104)
        Me.L4.Name = "L4"
        Me.L4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L4.Size = New System.Drawing.Size(169, 17)
        Me.L4.TabIndex = 9
        '
        'L3
        '
        Me.L3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L3.Cursor = System.Windows.Forms.Cursors.Default
        Me.L3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.L3.Location = New System.Drawing.Point(472, 80)
        Me.L3.Name = "L3"
        Me.L3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L3.Size = New System.Drawing.Size(169, 17)
        Me.L3.TabIndex = 8
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L2.Cursor = System.Windows.Forms.Cursors.Default
        Me.L2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.L2.Location = New System.Drawing.Point(472, 56)
        Me.L2.Name = "L2"
        Me.L2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L2.Size = New System.Drawing.Size(169, 17)
        Me.L2.TabIndex = 7
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L1.Cursor = System.Windows.Forms.Cursors.Default
        Me.L1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.L1.Location = New System.Drawing.Point(552, 32)
        Me.L1.Name = "L1"
        Me.L1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L1.Size = New System.Drawing.Size(89, 17)
        Me.L1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Job Openings"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(472, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Job Details"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(177, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Search Result"
        '
        'MatchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 438)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.MSF)
        Me.Controls.Add(Me.MSF1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.L5)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MatchForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Resume Matching"
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class