<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.AxMSFlexGrid1 = New AxMSFlexGridLib.AxMSFlexGrid
        CType(Me.AxMSFlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxMSFlexGrid1
        '
        Me.AxMSFlexGrid1.Location = New System.Drawing.Point(65, 104)
        Me.AxMSFlexGrid1.Name = "AxMSFlexGrid1"
        Me.AxMSFlexGrid1.OcxState = CType(resources.GetObject("AxMSFlexGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMSFlexGrid1.Size = New System.Drawing.Size(344, 166)
        Me.AxMSFlexGrid1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 430)
        Me.Controls.Add(Me.AxMSFlexGrid1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.AxMSFlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxMSFlexGrid1 As AxMSFlexGridLib.AxMSFlexGrid
End Class
