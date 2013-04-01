<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExchangeRate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExchangeRate))
        Me.GridClientEnvelopeRequest = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ClientInfo = New System.Windows.Forms.TabPage
        Me.BtnSubRequest = New System.Windows.Forms.Button
        Me.BtnAddRequest = New System.Windows.Forms.Button
        Me.ChCertificate = New System.Windows.Forms.CheckBox
        Me.SslKeyBrowse = New System.Windows.Forms.Button
        Me.SslKey = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtPlandTextGetBuyQuot = New System.Windows.Forms.TextBox
        Me.TxtForeignAmount = New System.Windows.Forms.TextBox
        Me.TxtSpreadType = New System.Windows.Forms.TextBox
        Me.TxtCurrencyCode = New System.Windows.Forms.TextBox
        Me.TxtUserID = New System.Windows.Forms.TextBox
        Me.TxtTransactionType = New System.Windows.Forms.TextBox
        Me.TxtBranchID = New System.Windows.Forms.TextBox
        Me.TxtClientID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtSOAPURL = New System.Windows.Forms.TextBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtSOAPRespond = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtLocalAmount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtDenomination = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.BrandID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrencyCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ForiegnAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LocationAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DenominationMix = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XmlGetBuyQuote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.xmlEnvelopgetSellQuate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TxtPlanTextOfGetSell = New System.Windows.Forms.TextBox
        CType(Me.GridClientEnvelopeRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ClientInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridClientEnvelopeRequest
        '
        Me.GridClientEnvelopeRequest.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridClientEnvelopeRequest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridClientEnvelopeRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientEnvelopeRequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandID, Me.UserID, Me.CurrencyCode, Me.ForiegnAmount, Me.LocationAmount, Me.DenominationMix, Me.XmlGetBuyQuote, Me.xmlEnvelopgetSellQuate})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridClientEnvelopeRequest.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridClientEnvelopeRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridClientEnvelopeRequest.Location = New System.Drawing.Point(3, 16)
        Me.GridClientEnvelopeRequest.Name = "GridClientEnvelopeRequest"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridClientEnvelopeRequest.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridClientEnvelopeRequest.Size = New System.Drawing.Size(1389, 119)
        Me.GridClientEnvelopeRequest.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1395, 316)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Request Quote"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ClientInfo)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1389, 297)
        Me.TabControl1.TabIndex = 8
        '
        'ClientInfo
        '
        Me.ClientInfo.Controls.Add(Me.GroupBox6)
        Me.ClientInfo.Controls.Add(Me.GroupBox5)
        Me.ClientInfo.Controls.Add(Me.BtnSubRequest)
        Me.ClientInfo.Controls.Add(Me.BtnAddRequest)
        Me.ClientInfo.Controls.Add(Me.TxtForeignAmount)
        Me.ClientInfo.Controls.Add(Me.TxtSpreadType)
        Me.ClientInfo.Controls.Add(Me.TxtCurrencyCode)
        Me.ClientInfo.Controls.Add(Me.TxtUserID)
        Me.ClientInfo.Controls.Add(Me.TxtTransactionType)
        Me.ClientInfo.Controls.Add(Me.TxtBranchID)
        Me.ClientInfo.Controls.Add(Me.TxtClientID)
        Me.ClientInfo.Controls.Add(Me.Label1)
        Me.ClientInfo.Controls.Add(Me.Label7)
        Me.ClientInfo.Controls.Add(Me.Label2)
        Me.ClientInfo.Controls.Add(Me.Label6)
        Me.ClientInfo.Controls.Add(Me.Label3)
        Me.ClientInfo.Controls.Add(Me.Label5)
        Me.ClientInfo.Controls.Add(Me.Label4)
        Me.ClientInfo.Location = New System.Drawing.Point(4, 22)
        Me.ClientInfo.Name = "ClientInfo"
        Me.ClientInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.ClientInfo.Size = New System.Drawing.Size(1381, 271)
        Me.ClientInfo.TabIndex = 0
        Me.ClientInfo.Tag = "Client Info"
        Me.ClientInfo.Text = "Client In formation With Buy Quat"
        Me.ClientInfo.UseVisualStyleBackColor = True
        '
        'BtnSubRequest
        '
        Me.BtnSubRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubRequest.Location = New System.Drawing.Point(567, 234)
        Me.BtnSubRequest.Name = "BtnSubRequest"
        Me.BtnSubRequest.Size = New System.Drawing.Size(62, 31)
        Me.BtnSubRequest.TabIndex = 59
        Me.BtnSubRequest.Text = "-"
        Me.BtnSubRequest.UseVisualStyleBackColor = True
        '
        'BtnAddRequest
        '
        Me.BtnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddRequest.Location = New System.Drawing.Point(499, 235)
        Me.BtnAddRequest.Name = "BtnAddRequest"
        Me.BtnAddRequest.Size = New System.Drawing.Size(62, 30)
        Me.BtnAddRequest.TabIndex = 58
        Me.BtnAddRequest.Text = "+"
        Me.BtnAddRequest.UseVisualStyleBackColor = True
        '
        'ChCertificate
        '
        Me.ChCertificate.AutoSize = True
        Me.ChCertificate.Location = New System.Drawing.Point(15, 19)
        Me.ChCertificate.Name = "ChCertificate"
        Me.ChCertificate.Size = New System.Drawing.Size(239, 30)
        Me.ChCertificate.TabIndex = 57
        Me.ChCertificate.Text = "X.509 file asociated with a priv key that must " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exist under LOCAL_MACHINE/Person" & _
            "al"
        Me.ChCertificate.UseVisualStyleBackColor = True
        '
        'SslKeyBrowse
        '
        Me.SslKeyBrowse.Location = New System.Drawing.Point(311, 59)
        Me.SslKeyBrowse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SslKeyBrowse.Name = "SslKeyBrowse"
        Me.SslKeyBrowse.Size = New System.Drawing.Size(29, 24)
        Me.SslKeyBrowse.TabIndex = 56
        Me.SslKeyBrowse.Text = "..."
        Me.SslKeyBrowse.UseVisualStyleBackColor = True
        '
        'SslKey
        '
        Me.SslKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SslKey.Location = New System.Drawing.Point(111, 57)
        Me.SslKey.Name = "SslKey"
        Me.SslKey.Size = New System.Drawing.Size(195, 26)
        Me.SslKey.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Client Cert for SSL:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtPlandTextGetBuyQuot)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 142)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Key Token GetBuyQuote"
        '
        'TxtPlandTextGetBuyQuot
        '
        Me.TxtPlandTextGetBuyQuot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPlandTextGetBuyQuot.Location = New System.Drawing.Point(3, 16)
        Me.TxtPlandTextGetBuyQuot.Multiline = True
        Me.TxtPlandTextGetBuyQuot.Name = "TxtPlandTextGetBuyQuot"
        Me.TxtPlandTextGetBuyQuot.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtPlandTextGetBuyQuot.Size = New System.Drawing.Size(357, 123)
        Me.TxtPlandTextGetBuyQuot.TabIndex = 0
        '
        'TxtForeignAmount
        '
        Me.TxtForeignAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtForeignAmount.Location = New System.Drawing.Point(396, 95)
        Me.TxtForeignAmount.Name = "TxtForeignAmount"
        Me.TxtForeignAmount.Size = New System.Drawing.Size(230, 23)
        Me.TxtForeignAmount.TabIndex = 13
        '
        'TxtSpreadType
        '
        Me.TxtSpreadType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSpreadType.Location = New System.Drawing.Point(396, 63)
        Me.TxtSpreadType.Name = "TxtSpreadType"
        Me.TxtSpreadType.Size = New System.Drawing.Size(230, 23)
        Me.TxtSpreadType.TabIndex = 12
        '
        'TxtCurrencyCode
        '
        Me.TxtCurrencyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrencyCode.Location = New System.Drawing.Point(396, 32)
        Me.TxtCurrencyCode.Name = "TxtCurrencyCode"
        Me.TxtCurrencyCode.Size = New System.Drawing.Size(230, 23)
        Me.TxtCurrencyCode.TabIndex = 11
        '
        'TxtUserID
        '
        Me.TxtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserID.Location = New System.Drawing.Point(108, 125)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(189, 23)
        Me.TxtUserID.TabIndex = 10
        '
        'TxtTransactionType
        '
        Me.TxtTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTransactionType.Location = New System.Drawing.Point(108, 93)
        Me.TxtTransactionType.Name = "TxtTransactionType"
        Me.TxtTransactionType.Size = New System.Drawing.Size(189, 23)
        Me.TxtTransactionType.TabIndex = 9
        '
        'TxtBranchID
        '
        Me.TxtBranchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBranchID.Location = New System.Drawing.Point(108, 62)
        Me.TxtBranchID.Name = "TxtBranchID"
        Me.TxtBranchID.Size = New System.Drawing.Size(189, 23)
        Me.TxtBranchID.TabIndex = 8
        '
        'TxtClientID
        '
        Me.TxtClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientID.Location = New System.Drawing.Point(108, 32)
        Me.TxtClientID.Name = "TxtClientID"
        Me.TxtClientID.Size = New System.Drawing.Size(189, 23)
        Me.TxtClientID.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Foreign Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Spread Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transaction Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Currency Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridClientEnvelopeRequest)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1395, 138)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SOAP Request to send to container"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(1114, 560)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Send Request Quote"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1334712555_Gnome-System-Log-Out-48.ico")
        Me.ImageList1.Images.SetKeyName(1, "arrow_down.ico")
        Me.ImageList1.Images.SetKeyName(2, "1319703220_system-software-update.png")
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(1302, 560)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(9, 568)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "SOAP Access Link:"
        '
        'TxtSOAPURL
        '
        Me.TxtSOAPURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSOAPURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSOAPURL.ForeColor = System.Drawing.Color.Blue
        Me.TxtSOAPURL.Location = New System.Drawing.Point(115, 560)
        Me.TxtSOAPURL.Name = "TxtSOAPURL"
        Me.TxtSOAPURL.Size = New System.Drawing.Size(993, 26)
        Me.TxtSOAPURL.TabIndex = 7
        Me.TxtSOAPURL.Text = "https://api.globalforeigncurrency.com:443/demo-api/services/QuoteGenerator"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 322)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1395, 230)
        Me.SplitContainer1.SplitterDistance = 138
        Me.SplitContainer1.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtSOAPRespond)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1395, 88)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SOAP Response"
        '
        'TxtSOAPRespond
        '
        Me.TxtSOAPRespond.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSOAPRespond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSOAPRespond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSOAPRespond.ForeColor = System.Drawing.Color.Blue
        Me.TxtSOAPRespond.Location = New System.Drawing.Point(3, 16)
        Me.TxtSOAPRespond.Multiline = True
        Me.TxtSOAPRespond.Name = "TxtSOAPRespond"
        Me.TxtSOAPRespond.ReadOnly = True
        Me.TxtSOAPRespond.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtSOAPRespond.Size = New System.Drawing.Size(1389, 69)
        Me.TxtSOAPRespond.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.ChCertificate)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.SslKey)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.SslKeyBrowse)
        Me.GroupBox5.Location = New System.Drawing.Point(642, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(733, 241)
        Me.GroupBox5.TabIndex = 60
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Security Information"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtDenomination)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TxtLocalAmount)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 163)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(622, 68)
        Me.GroupBox6.TabIndex = 61
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sell Quat Information"
        '
        'TxtLocalAmount
        '
        Me.TxtLocalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocalAmount.Location = New System.Drawing.Point(104, 25)
        Me.TxtLocalAmount.Name = "TxtLocalAmount"
        Me.TxtLocalAmount.Size = New System.Drawing.Size(230, 23)
        Me.TxtLocalAmount.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Local Amount:"
        '
        'TxtDenomination
        '
        Me.TxtDenomination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDenomination.Location = New System.Drawing.Point(450, 25)
        Me.TxtDenomination.Name = "TxtDenomination"
        Me.TxtDenomination.Size = New System.Drawing.Size(158, 23)
        Me.TxtDenomination.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(350, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Denomination Mix:"
        '
        'BrandID
        '
        Me.BrandID.DataPropertyName = "BrandID"
        Me.BrandID.HeaderText = "Brand ID"
        Me.BrandID.Name = "BrandID"
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "User ID"
        Me.UserID.Name = "UserID"
        '
        'CurrencyCode
        '
        Me.CurrencyCode.DataPropertyName = "CurrencyCode"
        Me.CurrencyCode.HeaderText = "Currency Code"
        Me.CurrencyCode.Name = "CurrencyCode"
        Me.CurrencyCode.Width = 130
        '
        'ForiegnAmount
        '
        Me.ForiegnAmount.DataPropertyName = "ForeigAmount"
        Me.ForiegnAmount.HeaderText = "Foriegn Amount"
        Me.ForiegnAmount.Name = "ForiegnAmount"
        Me.ForiegnAmount.Width = 130
        '
        'LocationAmount
        '
        Me.LocationAmount.DataPropertyName = "LocalAmount"
        Me.LocationAmount.HeaderText = "Location Amount"
        Me.LocationAmount.Name = "LocationAmount"
        Me.LocationAmount.Width = 150
        '
        'DenominationMix
        '
        Me.DenominationMix.DataPropertyName = "Denomination"
        Me.DenominationMix.HeaderText = "Denomination Mix"
        Me.DenominationMix.Name = "DenominationMix"
        Me.DenominationMix.Width = 150
        '
        'XmlGetBuyQuote
        '
        Me.XmlGetBuyQuote.DataPropertyName = "XMLGetBuyQuate"
        Me.XmlGetBuyQuote.HeaderText = " Get Buy Quote"
        Me.XmlGetBuyQuote.Name = "XmlGetBuyQuote"
        Me.XmlGetBuyQuote.Width = 150
        '
        'xmlEnvelopgetSellQuate
        '
        Me.xmlEnvelopgetSellQuate.DataPropertyName = "XMLGetSellQuate"
        Me.xmlEnvelopgetSellQuate.HeaderText = " Get Sell Quate"
        Me.xmlEnvelopgetSellQuate.Name = "xmlEnvelopgetSellQuate"
        Me.xmlEnvelopgetSellQuate.Width = 150
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.TxtPlanTextOfGetSell)
        Me.GroupBox7.Location = New System.Drawing.Point(381, 93)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(346, 142)
        Me.GroupBox7.TabIndex = 58
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Key Token GetSellQuote"
        '
        'TxtPlanTextOfGetSell
        '
        Me.TxtPlanTextOfGetSell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPlanTextOfGetSell.Location = New System.Drawing.Point(3, 16)
        Me.TxtPlanTextOfGetSell.Multiline = True
        Me.TxtPlanTextOfGetSell.Name = "TxtPlanTextOfGetSell"
        Me.TxtPlanTextOfGetSell.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtPlanTextOfGetSell.Size = New System.Drawing.Size(340, 123)
        Me.TxtPlanTextOfGetSell.TabIndex = 0
        '
        'ExchangeRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 590)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TxtSOAPURL)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ExchangeRate"
        Me.Text = "Exchange Rate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridClientEnvelopeRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ClientInfo.ResumeLayout(False)
        Me.ClientInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridClientEnvelopeRequest As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ClientInfo As System.Windows.Forms.TabPage
    Friend WithEvents TxtForeignAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtSpreadType As System.Windows.Forms.TextBox
    Friend WithEvents TxtCurrencyCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserID As System.Windows.Forms.TextBox
    Friend WithEvents TxtTransactionType As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranchID As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSOAPURL As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSOAPRespond As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents SslKeyBrowse As System.Windows.Forms.Button
    Public WithEvents SslKey As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChCertificate As System.Windows.Forms.CheckBox
    Friend WithEvents TxtPlandTextGetBuyQuot As System.Windows.Forms.TextBox
    Friend WithEvents BtnSubRequest As System.Windows.Forms.Button
    Friend WithEvents BtnAddRequest As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDenomination As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtLocalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BrandID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForiegnAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DenominationMix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmlGetBuyQuote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xmlEnvelopgetSellQuate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPlanTextOfGetSell As System.Windows.Forms.TextBox
End Class
