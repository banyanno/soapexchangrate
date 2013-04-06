<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainExchangRate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim MenuBarButton_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim MenuBarButton_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim MenuBarButton_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainExchangRate))
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.MenuBarButton = New Janus.Windows.ButtonBar.ButtonBar
        Me.uiPanel1 = New Janus.Windows.UI.Dock.UIPanel
        Me.MainContainner = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RibboStatusBar = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.LabelCommand1 = New Janus.Windows.Ribbon.LabelCommand
        Me.LblStartTime = New Janus.Windows.Ribbon.LabelCommand
        Me.LabelCommand3 = New Janus.Windows.Ribbon.LabelCommand
        Me.LblEndTime = New Janus.Windows.Ribbon.LabelCommand
        Me.LabelCommand5 = New Janus.Windows.Ribbon.LabelCommand
        Me.LblInterval = New Janus.Windows.Ribbon.LabelCommand
        Me.LabelCommand7 = New Janus.Windows.Ribbon.LabelCommand
        Me.LblCurrentime = New Janus.Windows.Ribbon.LabelCommand
        Me.LoadingBar = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.LoadCurrentTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        CType(Me.MenuBarButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.ContainerControl = Me
        Me.uiPanel0.Id = New System.Guid("b62ea2b8-f7a7-4a82-b8f6-95919a065a34")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        Me.uiPanel1.Id = New System.Guid("8f73d231-38eb-44e9-9368-c93080bd5339")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel1)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("b62ea2b8-f7a7-4a82-b8f6-95919a065a34"), Janus.Windows.UI.Dock.PanelDockStyle.Left, New System.Drawing.Size(197, 482), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("8f73d231-38eb-44e9-9368-c93080bd5339"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, New System.Drawing.Size(903, 482), True)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("b62ea2b8-f7a7-4a82-b8f6-95919a065a34"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("8f73d231-38eb-44e9-9368-c93080bd5339"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(3, 3)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(197, 482)
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.Text = "Panel 0"
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.MenuBarButton)
        Me.uiPanel0Container.Location = New System.Drawing.Point(1, 23)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(191, 458)
        Me.uiPanel0Container.TabIndex = 0
        '
        'MenuBarButton
        '
        Me.MenuBarButton.Dock = System.Windows.Forms.DockStyle.Fill
        MenuBarButton_Item_0_0.Cursor = System.Windows.Forms.Cursors.Hand
        MenuBarButton_Item_0_0.Key = "DashbordRequest"
        MenuBarButton_Item_0_0.Text = "Dashboard Result Reques"
        MenuBarButton_Item_0_1.Cursor = System.Windows.Forms.Cursors.Hand
        MenuBarButton_Item_0_1.Key = "SOAPSetting"
        MenuBarButton_Item_0_1.Text = "Exchange Rate Request Setting"
        MenuBarButton_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {MenuBarButton_Item_0_0, MenuBarButton_Item_0_1})
        MenuBarButton_Group_0.Key = "Group1"
        MenuBarButton_Group_0.Text = "New Group"
        Me.MenuBarButton.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {MenuBarButton_Group_0})
        Me.MenuBarButton.Location = New System.Drawing.Point(0, 0)
        Me.MenuBarButton.Name = "MenuBarButton"
        Me.MenuBarButton.Size = New System.Drawing.Size(191, 458)
        Me.MenuBarButton.TabIndex = 0
        Me.MenuBarButton.Text = "ButtonBar1"
        '
        'uiPanel1
        '
        Me.uiPanel1.InnerContainer = Me.MainContainner
        Me.uiPanel1.Location = New System.Drawing.Point(200, 3)
        Me.uiPanel1.Name = "uiPanel1"
        Me.uiPanel1.Size = New System.Drawing.Size(903, 482)
        Me.uiPanel1.TabIndex = 4
        Me.uiPanel1.Text = "Panel 1"
        '
        'MainContainner
        '
        Me.MainContainner.Location = New System.Drawing.Point(1, 23)
        Me.MainContainner.Name = "MainContainner"
        Me.MainContainner.Size = New System.Drawing.Size(901, 458)
        Me.MainContainner.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MessageExchange.My.Resources.Resources.loading_bar1
        Me.PictureBox1.Location = New System.Drawing.Point(938, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RibboStatusBar
        '
        Me.RibboStatusBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibboStatusBar.ImageSize = New System.Drawing.Size(16, 16)
        Me.RibboStatusBar.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.LabelCommand1, Me.LblStartTime, Me.LabelCommand3, Me.LblEndTime, Me.LabelCommand5, Me.LblInterval})
        Me.RibboStatusBar.Location = New System.Drawing.Point(0, 488)
        Me.RibboStatusBar.Name = "RibboStatusBar"
        Me.RibboStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom
        Me.RibboStatusBar.Office2007CustomColor = System.Drawing.Color.Empty
        Me.RibboStatusBar.RightPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.LabelCommand7, Me.LblCurrentime, Me.LoadingBar})
        Me.RibboStatusBar.ShowToolTips = False
        Me.RibboStatusBar.Size = New System.Drawing.Size(1106, 32)
        '
        '
        '
        Me.RibboStatusBar.SuperTipComponent.AutoPopDelay = 2000
        Me.RibboStatusBar.SuperTipComponent.ImageList = Nothing
        Me.RibboStatusBar.TabIndex = 0
        Me.RibboStatusBar.Text = "RibbonStatusBar1"
        Me.RibboStatusBar.UseCompatibleTextRendering = False
        '
        'LabelCommand1
        '
        Me.LabelCommand1.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.LabelCommand1.Key = "LabelCommand1"
        Me.LabelCommand1.Name = "LabelCommand1"
        Me.LabelCommand1.Text = "Start From:"
        '
        'LblStartTime
        '
        Me.LblStartTime.ForegroundStyle.ForeColor = System.Drawing.Color.Red
        Me.LblStartTime.Key = "LabelCommand2"
        Me.LblStartTime.Name = "LblStartTime"
        Me.LblStartTime.Text = "StartTime"
        '
        'LabelCommand3
        '
        Me.LabelCommand3.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.LabelCommand3.Key = "LabelCommand3"
        Me.LabelCommand3.Name = "LabelCommand3"
        Me.LabelCommand3.Text = "To:"
        '
        'LblEndTime
        '
        Me.LblEndTime.ForegroundStyle.ForeColor = System.Drawing.Color.Red
        Me.LblEndTime.Key = "LabelCommand4"
        Me.LblEndTime.Name = "LblEndTime"
        Me.LblEndTime.Text = "EndTime"
        '
        'LabelCommand5
        '
        Me.LabelCommand5.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.LabelCommand5.Key = "LabelCommand5"
        Me.LabelCommand5.Name = "LabelCommand5"
        Me.LabelCommand5.Text = "Interval:"
        '
        'LblInterval
        '
        Me.LblInterval.ForegroundStyle.ForeColor = System.Drawing.Color.Red
        Me.LblInterval.Key = "LabelCommand6"
        Me.LblInterval.Name = "LblInterval"
        Me.LblInterval.Text = "Interval"
        '
        'LabelCommand7
        '
        Me.LabelCommand7.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.LabelCommand7.Key = "LabelCommand7"
        Me.LabelCommand7.Name = "LabelCommand7"
        Me.LabelCommand7.Text = "Current Local Time:"
        '
        'LblCurrentime
        '
        Me.LblCurrentime.ForegroundStyle.ForeColor = System.Drawing.Color.Red
        Me.LblCurrentime.Key = "LabelCommand8"
        Me.LblCurrentime.Name = "LblCurrentime"
        Me.LblCurrentime.Text = "...."
        '
        'LoadingBar
        '
        Me.LoadingBar.Control = Me.PictureBox1
        Me.LoadingBar.ControlWidth = 150
        Me.LoadingBar.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.LoadingBar.Key = "SendingBar"
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Text = "Sending:"
        Me.LoadingBar.Visible = False
        '
        'LoadCurrentTime
        '
        Me.LoadCurrentTime.Interval = 1
        '
        'MainExchangRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 520)
        Me.Controls.Add(Me.uiPanel1)
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.RibboStatusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainExchangRate"
        Me.Text = "MainExchangRate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        CType(Me.MenuBarButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents uiPanel1 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents MainContainner As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents MenuBarButton As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents RibboStatusBar As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents LabelCommand1 As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LblStartTime As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LabelCommand3 As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LblEndTime As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LabelCommand5 As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LblInterval As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LabelCommand7 As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LblCurrentime As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LoadCurrentTime As System.Windows.Forms.Timer
    Friend WithEvents LoadingBar As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
