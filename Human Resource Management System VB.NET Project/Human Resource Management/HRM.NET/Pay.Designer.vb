<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pay
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    Private components As System.ComponentModel.IContainer

    
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker

        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.payID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empidno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empfname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.emplname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.emppos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empstate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.wHours = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.netPay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.payDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
       
        Me.PayBindingSource.DataMember = "Pay"
       
        Me.TextBox9.Location = New System.Drawing.Point(84, 219)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 66
       
        Me.TextBox8.Location = New System.Drawing.Point(84, 198)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 65
        
        Me.TextBox7.Location = New System.Drawing.Point(84, 172)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 64
       
        Me.TextBox6.Location = New System.Drawing.Point(84, 146)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 63
       
        Me.TextBox5.Location = New System.Drawing.Point(84, 122)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 62
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(84, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 61
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(84, 67)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Pay Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Net Pay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Hours"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Emp State"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Emp Pos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Emp LName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Emp FName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "EmpIdNo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "PayId"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(298, 285)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 22)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(230, 285)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 22)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(159, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 22)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Modify"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 22)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(84, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 22)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 44
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 43
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(84, 246)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker1.TabIndex = 69
        '
        'PayTableAdapter
        '
        'Me.PayTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.payID, Me.empidno, Me.empfname, Me.emplname, Me.emppos, Me.empstate, Me.wHours, Me.Amount, Me.netPay, Me.payDate})
        Me.DataGridView1.Location = New System.Drawing.Point(230, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(517, 258)
        Me.DataGridView1.TabIndex = 70
        '
        'payID
        '
        Me.payID.HeaderText = "payID"
        Me.payID.Name = "payID"
        '
        'empidno
        '
        Me.empidno.HeaderText = "empidno"
        Me.empidno.Name = "empidno"
        Me.empidno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empidno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'empfname
        '
        Me.empfname.HeaderText = "empfname"
        Me.empfname.Name = "empfname"
        Me.empfname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empfname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'emplname
        '
        Me.emplname.HeaderText = "emplname"
        Me.emplname.Name = "emplname"
        Me.emplname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.emplname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'emppos
        '
        Me.emppos.HeaderText = "emppos"
        Me.emppos.Name = "emppos"
        Me.emppos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.emppos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'empstate
        '
        Me.empstate.HeaderText = "empstate"
        Me.empstate.Name = "empstate"
        Me.empstate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empstate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'wHours
        '
        Me.wHours.HeaderText = "wHours"
        Me.wHours.Name = "wHours"
        Me.wHours.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.wHours.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'netPay
        '
        Me.netPay.HeaderText = "netPay"
        Me.netPay.Name = "netPay"
        Me.netPay.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.netPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'payDate
        '
        Me.payDate.HeaderText = "payDate"
        Me.payDate.Name = "payDate"
        Me.payDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.payDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 327)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Pay"
        Me.Text = "Pay"
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.HRMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

    Friend WithEvents PayBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents payID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empidno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empfname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emplname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emppos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empstate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents netPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents payDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
