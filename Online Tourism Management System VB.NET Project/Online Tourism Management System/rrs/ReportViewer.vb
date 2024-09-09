Public Class ReportViewer
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReportViewer))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.AccessibleDescription = resources.GetString("CrystalReportViewer1.AccessibleDescription")
        Me.CrystalReportViewer1.AccessibleName = resources.GetString("CrystalReportViewer1.AccessibleName")
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType(resources.GetObject("CrystalReportViewer1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.AutoScroll = CType(resources.GetObject("CrystalReportViewer1.AutoScroll"), Boolean)
        Me.CrystalReportViewer1.AutoScrollMargin = CType(resources.GetObject("CrystalReportViewer1.AutoScrollMargin"), System.Drawing.Size)
        Me.CrystalReportViewer1.AutoScrollMinSize = CType(resources.GetObject("CrystalReportViewer1.AutoScrollMinSize"), System.Drawing.Size)
        Me.CrystalReportViewer1.BackgroundImage = CType(resources.GetObject("CrystalReportViewer1.BackgroundImage"), System.Drawing.Image)
        Me.CrystalReportViewer1.DisplayBackgroundEdge = CType(resources.GetObject("CrystalReportViewer1.DisplayBackgroundEdge"), Boolean)
        Me.CrystalReportViewer1.DisplayGroupTree = CType(resources.GetObject("CrystalReportViewer1.DisplayGroupTree"), Boolean)
        Me.CrystalReportViewer1.DisplayToolbar = CType(resources.GetObject("CrystalReportViewer1.DisplayToolbar"), Boolean)
        Me.CrystalReportViewer1.Dock = CType(resources.GetObject("CrystalReportViewer1.Dock"), System.Windows.Forms.DockStyle)
        Me.CrystalReportViewer1.Enabled = CType(resources.GetObject("CrystalReportViewer1.Enabled"), Boolean)
        Me.CrystalReportViewer1.EnableDrillDown = CType(resources.GetObject("CrystalReportViewer1.EnableDrillDown"), Boolean)
        Me.CrystalReportViewer1.Font = CType(resources.GetObject("CrystalReportViewer1.Font"), System.Drawing.Font)
        Me.CrystalReportViewer1.ImeMode = CType(resources.GetObject("CrystalReportViewer1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CrystalReportViewer1.Location = CType(resources.GetObject("CrystalReportViewer1.Location"), System.Drawing.Point)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.RightToLeft = CType(resources.GetObject("CrystalReportViewer1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CrystalReportViewer1.ShowCloseButton = CType(resources.GetObject("CrystalReportViewer1.ShowCloseButton"), Boolean)
        Me.CrystalReportViewer1.ShowExportButton = CType(resources.GetObject("CrystalReportViewer1.ShowExportButton"), Boolean)
        Me.CrystalReportViewer1.ShowGotoPageButton = CType(resources.GetObject("CrystalReportViewer1.ShowGotoPageButton"), Boolean)
        Me.CrystalReportViewer1.ShowGroupTreeButton = CType(resources.GetObject("CrystalReportViewer1.ShowGroupTreeButton"), Boolean)
        Me.CrystalReportViewer1.ShowPageNavigateButtons = CType(resources.GetObject("CrystalReportViewer1.ShowPageNavigateButtons"), Boolean)
        Me.CrystalReportViewer1.ShowPrintButton = CType(resources.GetObject("CrystalReportViewer1.ShowPrintButton"), Boolean)
        Me.CrystalReportViewer1.ShowRefreshButton = CType(resources.GetObject("CrystalReportViewer1.ShowRefreshButton"), Boolean)
        Me.CrystalReportViewer1.ShowTextSearchButton = CType(resources.GetObject("CrystalReportViewer1.ShowTextSearchButton"), Boolean)
        Me.CrystalReportViewer1.ShowZoomButton = CType(resources.GetObject("CrystalReportViewer1.ShowZoomButton"), Boolean)
        Me.CrystalReportViewer1.Size = CType(resources.GetObject("CrystalReportViewer1.Size"), System.Drawing.Size)
        Me.CrystalReportViewer1.TabIndex = CType(resources.GetObject("CrystalReportViewer1.TabIndex"), Integer)
        Me.CrystalReportViewer1.Visible = CType(resources.GetObject("CrystalReportViewer1.Visible"), Boolean)
        '
        'ReportViewer
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "ReportViewer"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    Public Sub delproc()

    End Sub
    Public Sub saveproc()

    End Sub
    Public Sub editproc()

    End Sub
    Public Sub newproc()

    End Sub
    Public Sub clearproc()

    End Sub

    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
