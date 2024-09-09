<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class SkillForm
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
	Public WithEvents Text1 As System.Windows.Forms.ComboBox
	Public WithEvents Text2 As System.Windows.Forms.ComboBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents MSF As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _Button_0 As System.Windows.Forms.Button
	Public WithEvents _Button_1 As System.Windows.Forms.Button
	Public WithEvents _Button_2 As System.Windows.Forms.Button
	Public WithEvents _Button_3 As System.Windows.Forms.Button
	Public WithEvents _Button_4 As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents MSF1 As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents LblNo As System.Windows.Forms.Label
	Public WithEvents LblName As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Button As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkillForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text1 = New System.Windows.Forms.ComboBox
        Me.Text2 = New System.Windows.Forms.ComboBox
        Me.Command1 = New System.Windows.Forms.Button
        Me.MSF = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._Button_0 = New System.Windows.Forms.Button
        Me._Button_1 = New System.Windows.Forms.Button
        Me._Button_2 = New System.Windows.Forms.Button
        Me._Button_3 = New System.Windows.Forms.Button
        Me._Button_4 = New System.Windows.Forms.Button
        Me.MSF1 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblNo = New System.Windows.Forms.Label
        Me.LblName = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.MSF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(8, 152)
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(113, 24)
        Me.Text1.TabIndex = 16
        '
        'Text2
        '
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Text2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(136, 152)
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(193, 24)
        Me.Text2.TabIndex = 15
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(408, 160)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(33, 25)
        Me.Command1.TabIndex = 12
        Me.Command1.Text = "Add"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'MSF
        '
        Me.MSF.Location = New System.Drawing.Point(456, 16)
        Me.MSF.Name = "MSF"
        Me.MSF.OcxState = CType(resources.GetObject("MSF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSF.Size = New System.Drawing.Size(177, 409)
        Me.MSF.TabIndex = 6
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me._Button_0)
        Me.Frame1.Controls.Add(Me._Button_1)
        Me.Frame1.Controls.Add(Me._Button_2)
        Me.Frame1.Controls.Add(Me._Button_3)
        Me.Frame1.Controls.Add(Me._Button_4)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 376)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(345, 49)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        '
        '_Button_0
        '
        Me._Button_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Button_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_0.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_0, CType(0, Short))
        Me._Button_0.Location = New System.Drawing.Point(8, 16)
        Me._Button_0.Name = "_Button_0"
        Me._Button_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_0.Size = New System.Drawing.Size(57, 25)
        Me._Button_0.TabIndex = 0
        Me._Button_0.Text = "&New"
        Me._Button_0.UseVisualStyleBackColor = False
        '
        '_Button_1
        '
        Me._Button_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Button_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_1.Enabled = False
        Me._Button_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_1, CType(1, Short))
        Me._Button_1.Location = New System.Drawing.Point(72, 16)
        Me._Button_1.Name = "_Button_1"
        Me._Button_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_1.Size = New System.Drawing.Size(57, 25)
        Me._Button_1.TabIndex = 1
        Me._Button_1.Text = "&Save"
        Me._Button_1.UseVisualStyleBackColor = False
        '
        '_Button_2
        '
        Me._Button_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Button_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_2.Enabled = False
        Me._Button_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_2, CType(2, Short))
        Me._Button_2.Location = New System.Drawing.Point(136, 16)
        Me._Button_2.Name = "_Button_2"
        Me._Button_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_2.Size = New System.Drawing.Size(57, 25)
        Me._Button_2.TabIndex = 2
        Me._Button_2.Text = "&Modify"
        Me._Button_2.UseVisualStyleBackColor = False
        '
        '_Button_3
        '
        Me._Button_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Button_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_3.Enabled = False
        Me._Button_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_3, CType(3, Short))
        Me._Button_3.Location = New System.Drawing.Point(200, 16)
        Me._Button_3.Name = "_Button_3"
        Me._Button_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_3.Size = New System.Drawing.Size(57, 25)
        Me._Button_3.TabIndex = 3
        Me._Button_3.Text = "&Delete"
        Me._Button_3.UseVisualStyleBackColor = False
        '
        '_Button_4
        '
        Me._Button_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Button_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_4, CType(4, Short))
        Me._Button_4.Location = New System.Drawing.Point(280, 16)
        Me._Button_4.Name = "_Button_4"
        Me._Button_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_4.Size = New System.Drawing.Size(57, 25)
        Me._Button_4.TabIndex = 4
        Me._Button_4.Text = "&Close"
        Me._Button_4.UseVisualStyleBackColor = False
        '
        'MSF1
        '
        Me.MSF1.Location = New System.Drawing.Point(8, 192)
        Me.MSF1.Name = "MSF1"
        Me.MSF1.OcxState = CType(resources.GetObject("MSF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSF1.Size = New System.Drawing.Size(433, 145)
        Me.MSF1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Skill"
        '
        'LblNo
        '
        Me.LblNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNo.Location = New System.Drawing.Point(72, 32)
        Me.LblNo.Name = "LblNo"
        Me.LblNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblNo.Size = New System.Drawing.Size(65, 17)
        Me.LblNo.TabIndex = 13
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblName.Location = New System.Drawing.Point(232, 32)
        Me.LblName.Name = "LblName"
        Me.LblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblName.Size = New System.Drawing.Size(169, 17)
        Me.LblName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(168, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "App No. "
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(136, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Discription"
        '
        'Button
        '
        '
        'SkillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 438)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.MSF)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MSF1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblNo)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SkillForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Skills Details"
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.MSF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class