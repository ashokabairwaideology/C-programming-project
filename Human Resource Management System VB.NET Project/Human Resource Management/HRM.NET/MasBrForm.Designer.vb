<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MasBrForm
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
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents MSF As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _Button_0 As System.Windows.Forms.Button
	Public WithEvents _Button_1 As System.Windows.Forms.Button
	Public WithEvents _Button_2 As System.Windows.Forms.Button
	Public WithEvents _Button_3 As System.Windows.Forms.Button
	Public WithEvents _Button_4 As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Button As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasBrForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.MSF = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._Button_0 = New System.Windows.Forms.Button
        Me._Button_1 = New System.Windows.Forms.Button
        Me._Button_2 = New System.Windows.Forms.Button
        Me._Button_3 = New System.Windows.Forms.Button
        Me._Button_4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.Button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(120, 96)
        Me.Text2.MaxLength = 50
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(89, 23)
        Me.Text2.TabIndex = 2
        Me.Text2.Visible = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(120, 56)
        Me.Text1.MaxLength = 300
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(177, 23)
        Me.Text1.TabIndex = 1
        '
        'MSF
        '
        Me.MSF.Location = New System.Drawing.Point(456, 16)
        Me.MSF.Name = "MSF"
        Me.MSF.OcxState = CType(resources.GetObject("MSF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSF.Size = New System.Drawing.Size(177, 409)
        Me.MSF.TabIndex = 8
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame1.Controls.Add(Me._Button_0)
        Me.Frame1.Controls.Add(Me._Button_1)
        Me.Frame1.Controls.Add(Me._Button_2)
        Me.Frame1.Controls.Add(Me._Button_3)
        Me.Frame1.Controls.Add(Me._Button_4)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 376)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(345, 49)
        Me.Frame1.TabIndex = 7
        Me.Frame1.TabStop = False
        '
        '_Button_0
        '
        Me._Button_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me._Button_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._Button_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_1.Enabled = False
        Me._Button_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_1, CType(1, Short))
        Me._Button_1.Location = New System.Drawing.Point(72, 16)
        Me._Button_1.Name = "_Button_1"
        Me._Button_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_1.Size = New System.Drawing.Size(57, 25)
        Me._Button_1.TabIndex = 3
        Me._Button_1.Text = "&Save"
        Me._Button_1.UseVisualStyleBackColor = False
        '
        '_Button_2
        '
        Me._Button_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._Button_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_2.Enabled = False
        Me._Button_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_2, CType(2, Short))
        Me._Button_2.Location = New System.Drawing.Point(136, 16)
        Me._Button_2.Name = "_Button_2"
        Me._Button_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_2.Size = New System.Drawing.Size(70, 25)
        Me._Button_2.TabIndex = 4
        Me._Button_2.Text = "&Modify"
        Me._Button_2.UseVisualStyleBackColor = False
        '
        '_Button_3
        '
        Me._Button_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._Button_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_3.Enabled = False
        Me._Button_3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_3, CType(3, Short))
        Me._Button_3.Location = New System.Drawing.Point(212, 16)
        Me._Button_3.Name = "_Button_3"
        Me._Button_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_3.Size = New System.Drawing.Size(62, 25)
        Me._Button_3.TabIndex = 5
        Me._Button_3.Text = "&Delete"
        Me._Button_3.UseVisualStyleBackColor = False
        '
        '_Button_4
        '
        Me._Button_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._Button_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Button_4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Button_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button.SetIndex(Me._Button_4, CType(4, Short))
        Me._Button_4.Location = New System.Drawing.Point(280, 16)
        Me._Button_4.Name = "_Button_4"
        Me._Button_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Button_4.Size = New System.Drawing.Size(57, 25)
        Me._Button_4.TabIndex = 6
        Me._Button_4.Text = "&Close"
        Me._Button_4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Years"
        Me.Label1.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Branch Name"
        '
        'Button
        '
        '
        'MasBrForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(616, 438)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.MSF)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasBrForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Branch (Cource) Entry Form"
        CType(Me.MSF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.Button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class