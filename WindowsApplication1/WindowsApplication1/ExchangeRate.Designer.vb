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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExchangeRate))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.country = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.We_By = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.We_Sell = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ClientInfo = New System.Windows.Forms.TabPage
        Me.ChCertificate = New System.Windows.Forms.CheckBox
        Me.SslKeyBrowse = New System.Windows.Forms.Button
        Me.SslKey = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.BtnXMLSoapFormat = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtEncryped = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtToken = New System.Windows.Forms.TextBox
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
        Me.txtXMLFormate = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtSOAPURL = New System.Windows.Forms.TextBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtSOAPRespond = New System.Windows.Forms.TextBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtSoapAction = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ClientInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.country, Me.Unit, Me.We_By, Me.We_Sell, Me.rate})
        Me.DataGridView1.Location = New System.Drawing.Point(480, 63)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Size = New System.Drawing.Size(236, 102)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'country
        '
        Me.country.DataPropertyName = "country"
        Me.country.HeaderText = "Country"
        Me.country.Name = "country"
        '
        'Unit
        '
        Me.Unit.DataPropertyName = "Unit"
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        '
        'We_By
        '
        Me.We_By.DataPropertyName = "We_By"
        Me.We_By.HeaderText = "We By"
        Me.We_By.Name = "We_By"
        '
        'We_Sell
        '
        Me.We_Sell.DataPropertyName = "We_Sell"
        Me.We_Sell.HeaderText = "We Sell"
        Me.We_Sell.Name = "We_Sell"
        '
        'rate
        '
        Me.rate.DataPropertyName = "rate"
        Me.rate.HeaderText = "Rate"
        Me.rate.Name = "rate"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1184, 345)
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
        Me.TabControl1.Size = New System.Drawing.Size(1178, 326)
        Me.TabControl1.TabIndex = 8
        '
        'ClientInfo
        '
        Me.ClientInfo.Controls.Add(Me.ChCertificate)
        Me.ClientInfo.Controls.Add(Me.SslKeyBrowse)
        Me.ClientInfo.Controls.Add(Me.SslKey)
        Me.ClientInfo.Controls.Add(Me.Label10)
        Me.ClientInfo.Controls.Add(Me.BtnXMLSoapFormat)
        Me.ClientInfo.Controls.Add(Me.GroupBox2)
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
        Me.ClientInfo.Size = New System.Drawing.Size(1170, 300)
        Me.ClientInfo.TabIndex = 0
        Me.ClientInfo.Tag = "Client Info"
        Me.ClientInfo.Text = "Client Info"
        Me.ClientInfo.UseVisualStyleBackColor = True
        '
        'ChCertificate
        '
        Me.ChCertificate.AutoSize = True
        Me.ChCertificate.Location = New System.Drawing.Point(652, 8)
        Me.ChCertificate.Name = "ChCertificate"
        Me.ChCertificate.Size = New System.Drawing.Size(239, 30)
        Me.ChCertificate.TabIndex = 57
        Me.ChCertificate.Text = "X.509 file asociated with a priv key that must " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exist under LOCAL_MACHINE/Person" & _
            "al"
        Me.ChCertificate.UseVisualStyleBackColor = True
        '
        'SslKeyBrowse
        '
        Me.SslKeyBrowse.Location = New System.Drawing.Point(1005, 48)
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
        Me.SslKey.Location = New System.Drawing.Point(748, 46)
        Me.SslKey.Name = "SslKey"
        Me.SslKey.Size = New System.Drawing.Size(251, 26)
        Me.SslKey.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(649, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Client Cert for SSL:"
        '
        'BtnXMLSoapFormat
        '
        Me.BtnXMLSoapFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnXMLSoapFormat.ForeColor = System.Drawing.Color.Red
        Me.BtnXMLSoapFormat.Location = New System.Drawing.Point(470, 99)
        Me.BtnXMLSoapFormat.Name = "BtnXMLSoapFormat"
        Me.BtnXMLSoapFormat.Size = New System.Drawing.Size(156, 26)
        Me.BtnXMLSoapFormat.TabIndex = 8
        Me.BtnXMLSoapFormat.Text = "Generat XML Soap Format"
        Me.BtnXMLSoapFormat.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.SplitContainer2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1153, 168)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Key Token"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox5)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer2.Size = New System.Drawing.Size(1147, 149)
        Me.SplitContainer2.SplitterDistance = 543
        Me.SplitContainer2.TabIndex = 17
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtEncryped)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(543, 149)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Plain / Encrypted Text"
        '
        'TxtEncryped
        '
        Me.TxtEncryped.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtEncryped.Location = New System.Drawing.Point(3, 16)
        Me.TxtEncryped.Multiline = True
        Me.TxtEncryped.Name = "TxtEncryped"
        Me.TxtEncryped.Size = New System.Drawing.Size(537, 130)
        Me.TxtEncryped.TabIndex = 0
        Me.TxtEncryped.Text = resources.GetString("TxtEncryped.Text")
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtToken)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(600, 149)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Result of Encrypted"
        '
        'txtToken
        '
        Me.txtToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToken.Location = New System.Drawing.Point(3, 16)
        Me.txtToken.Multiline = True
        Me.txtToken.Name = "txtToken"
        Me.txtToken.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtToken.Size = New System.Drawing.Size(594, 130)
        Me.txtToken.TabIndex = 16
        '
        'TxtForeignAmount
        '
        Me.TxtForeignAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtForeignAmount.Location = New System.Drawing.Point(396, 69)
        Me.TxtForeignAmount.Name = "TxtForeignAmount"
        Me.TxtForeignAmount.Size = New System.Drawing.Size(230, 23)
        Me.TxtForeignAmount.TabIndex = 13
        '
        'TxtSpreadType
        '
        Me.TxtSpreadType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSpreadType.Location = New System.Drawing.Point(396, 37)
        Me.TxtSpreadType.Name = "TxtSpreadType"
        Me.TxtSpreadType.Size = New System.Drawing.Size(230, 23)
        Me.TxtSpreadType.TabIndex = 12
        '
        'TxtCurrencyCode
        '
        Me.TxtCurrencyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrencyCode.Location = New System.Drawing.Point(396, 6)
        Me.TxtCurrencyCode.Name = "TxtCurrencyCode"
        Me.TxtCurrencyCode.Size = New System.Drawing.Size(230, 23)
        Me.TxtCurrencyCode.TabIndex = 11
        '
        'TxtUserID
        '
        Me.TxtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserID.Location = New System.Drawing.Point(108, 99)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(189, 23)
        Me.TxtUserID.TabIndex = 10
        '
        'TxtTransactionType
        '
        Me.TxtTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTransactionType.Location = New System.Drawing.Point(108, 67)
        Me.TxtTransactionType.Name = "TxtTransactionType"
        Me.TxtTransactionType.Size = New System.Drawing.Size(189, 23)
        Me.TxtTransactionType.TabIndex = 9
        '
        'TxtBranchID
        '
        Me.TxtBranchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBranchID.Location = New System.Drawing.Point(108, 36)
        Me.TxtBranchID.Name = "TxtBranchID"
        Me.TxtBranchID.Size = New System.Drawing.Size(189, 23)
        Me.TxtBranchID.TabIndex = 8
        '
        'TxtClientID
        '
        Me.TxtClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientID.Location = New System.Drawing.Point(108, 6)
        Me.TxtClientID.Name = "TxtClientID"
        Me.TxtClientID.Size = New System.Drawing.Size(189, 23)
        Me.TxtClientID.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Foreign Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Spread Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transaction Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Currency Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtXMLFormate)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 170)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SOAP Request to send to container"
        '
        'txtXMLFormate
        '
        Me.txtXMLFormate.BackColor = System.Drawing.SystemColors.Window
        Me.txtXMLFormate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtXMLFormate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXMLFormate.ForeColor = System.Drawing.Color.Blue
        Me.txtXMLFormate.Location = New System.Drawing.Point(3, 16)
        Me.txtXMLFormate.Multiline = True
        Me.txtXMLFormate.Name = "txtXMLFormate"
        Me.txtXMLFormate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXMLFormate.Size = New System.Drawing.Size(549, 151)
        Me.txtXMLFormate.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(903, 560)
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
        Me.Button2.Location = New System.Drawing.Point(1091, 560)
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
        Me.Label8.Location = New System.Drawing.Point(9, 533)
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
        Me.TxtSOAPURL.Location = New System.Drawing.Point(115, 527)
        Me.TxtSOAPURL.Name = "TxtSOAPURL"
        Me.TxtSOAPURL.Size = New System.Drawing.Size(782, 26)
        Me.TxtSOAPURL.TabIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 351)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1184, 170)
        Me.SplitContainer1.SplitterDistance = 555
        Me.SplitContainer1.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtSOAPRespond)
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(625, 170)
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
        Me.TxtSOAPRespond.Size = New System.Drawing.Size(619, 151)
        Me.TxtSOAPRespond.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView2.Location = New System.Drawing.Point(480, 63)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Size = New System.Drawing.Size(236, 102)
        Me.DataGridView2.TabIndex = 1
        Me.DataGridView2.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "country"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Unit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "We_By"
        Me.DataGridViewTextBoxColumn4.HeaderText = "We By"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "We_Sell"
        Me.DataGridViewTextBoxColumn5.HeaderText = "We Sell"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "rate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(36, 569)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "SOAP Action:"
        '
        'TxtSoapAction
        '
        Me.TxtSoapAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSoapAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSoapAction.ForeColor = System.Drawing.Color.Blue
        Me.TxtSoapAction.Location = New System.Drawing.Point(114, 561)
        Me.TxtSoapAction.Name = "TxtSoapAction"
        Me.TxtSoapAction.Size = New System.Drawing.Size(783, 26)
        Me.TxtSoapAction.TabIndex = 8
        '
        'ExchangeRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 590)
        Me.Controls.Add(Me.TxtSoapAction)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TxtSOAPURL)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ExchangeRate"
        Me.Text = "Exchange Rate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ClientInfo.ResumeLayout(False)
        Me.ClientInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents country As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents We_By As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents We_Sell As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents txtToken As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtXMLFormate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSOAPURL As System.Windows.Forms.TextBox
    Friend WithEvents BtnXMLSoapFormat As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSOAPRespond As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents SslKeyBrowse As System.Windows.Forms.Button
    Public WithEvents SslKey As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSoapAction As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChCertificate As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtEncryped As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
End Class
