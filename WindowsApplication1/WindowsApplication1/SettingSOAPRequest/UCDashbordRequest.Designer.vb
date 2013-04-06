<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDashbordRequest
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridSOAPRequstSetting_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCDashbordRequest))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridSOAPRequstSetting = New Janus.Windows.GridEX.GridEX
        Me.TxtResult = New System.Windows.Forms.TextBox
        Me.TimerSending = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnFindCertificate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridSOAPRequstSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtResult)
        Me.SplitContainer1.Size = New System.Drawing.Size(1149, 579)
        Me.SplitContainer1.SplitterDistance = 330
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GridSOAPRequstSetting)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1143, 284)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SOAP Request Setting"
        '
        'GridSOAPRequstSetting
        '
        Me.GridSOAPRequstSetting.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridSOAPRequstSetting_DesignTimeLayout.LayoutString = resources.GetString("GridSOAPRequstSetting_DesignTimeLayout.LayoutString")
        Me.GridSOAPRequstSetting.DesignTimeLayout = GridSOAPRequstSetting_DesignTimeLayout
        Me.GridSOAPRequstSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSOAPRequstSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSOAPRequstSetting.GroupByBoxVisible = False
        Me.GridSOAPRequstSetting.HeaderFormatStyle.FontSize = 12.0!
        Me.GridSOAPRequstSetting.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridSOAPRequstSetting.Location = New System.Drawing.Point(3, 16)
        Me.GridSOAPRequstSetting.Name = "GridSOAPRequstSetting"
        Me.GridSOAPRequstSetting.RecordNavigator = True
        Me.GridSOAPRequstSetting.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridSOAPRequstSetting.Size = New System.Drawing.Size(1137, 265)
        Me.GridSOAPRequstSetting.TabIndex = 1
        '
        'TxtResult
        '
        Me.TxtResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtResult.Location = New System.Drawing.Point(0, 0)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtResult.Size = New System.Drawing.Size(1149, 245)
        Me.TxtResult.TabIndex = 0
        '
        'TimerSending
        '
        Me.TimerSending.Interval = 30000
        '
        'BackgroundWorker1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFindCertificate, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1149, 32)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnFindCertificate
        '
        Me.BtnFindCertificate.Image = CType(resources.GetObject("BtnFindCertificate.Image"), System.Drawing.Image)
        Me.BtnFindCertificate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFindCertificate.Name = "BtnFindCertificate"
        Me.BtnFindCertificate.Size = New System.Drawing.Size(86, 29)
        Me.BtnFindCertificate.Text = "Certificate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 29)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'UCDashbordRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCDashbordRequest"
        Me.Size = New System.Drawing.Size(1149, 579)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridSOAPRequstSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TimerSending As System.Windows.Forms.Timer
    Friend WithEvents GridSOAPRequstSetting As Janus.Windows.GridEX.GridEX
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtResult As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnFindCertificate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton

End Class
