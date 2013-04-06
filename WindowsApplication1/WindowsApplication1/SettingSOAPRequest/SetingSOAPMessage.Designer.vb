<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetingSOAPMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetingSOAPMessage))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ClientInfo = New System.Windows.Forms.TabPage
        Me.Label18 = New System.Windows.Forms.Label
        Me.SslKey = New System.Windows.Forms.TextBox
        Me.SslKeyBrowse = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtUSD = New System.Windows.Forms.TextBox
        Me.TxtIMG = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtForeignAmountSell = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtDenomination = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtLocalAmount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblScheduleID = New System.Windows.Forms.Label
        Me.BtnSaveSchedule = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtInterval = New System.Windows.Forms.TextBox
        Me.TimeStop = New System.Windows.Forms.DateTimePicker
        Me.TimeStart = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnSubRequest = New System.Windows.Forms.Button
        Me.TxtTransactionType = New System.Windows.Forms.TextBox
        Me.BtnAddRequest = New System.Windows.Forms.Button
        Me.TxtForeignAmount = New System.Windows.Forms.TextBox
        Me.TxtSpreadType = New System.Windows.Forms.TextBox
        Me.TxtCurrencyLabel = New System.Windows.Forms.TextBox
        Me.TxtCurrencyCode = New System.Windows.Forms.TextBox
        Me.TxtUserID = New System.Windows.Forms.TextBox
        Me.TxtBranchID = New System.Windows.Forms.TextBox
        Me.TxtClientID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridSOAPRequstSetting = New Janus.Windows.GridEX.GridEX
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorValidateTion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ClientInfo.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridSOAPRequstSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidateTion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1332, 294)
        Me.GroupBox1.TabIndex = 1
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
        Me.TabControl1.Size = New System.Drawing.Size(1326, 275)
        Me.TabControl1.TabIndex = 0
        '
        'ClientInfo
        '
        Me.ClientInfo.Controls.Add(Me.Label18)
        Me.ClientInfo.Controls.Add(Me.SslKey)
        Me.ClientInfo.Controls.Add(Me.SslKeyBrowse)
        Me.ClientInfo.Controls.Add(Me.LblSaveOption)
        Me.ClientInfo.Controls.Add(Me.Label15)
        Me.ClientInfo.Controls.Add(Me.TxtUSD)
        Me.ClientInfo.Controls.Add(Me.TxtIMG)
        Me.ClientInfo.Controls.Add(Me.Label13)
        Me.ClientInfo.Controls.Add(Me.GroupBox6)
        Me.ClientInfo.Controls.Add(Me.GroupBox5)
        Me.ClientInfo.Controls.Add(Me.BtnSubRequest)
        Me.ClientInfo.Controls.Add(Me.TxtTransactionType)
        Me.ClientInfo.Controls.Add(Me.BtnAddRequest)
        Me.ClientInfo.Controls.Add(Me.TxtForeignAmount)
        Me.ClientInfo.Controls.Add(Me.TxtSpreadType)
        Me.ClientInfo.Controls.Add(Me.TxtCurrencyLabel)
        Me.ClientInfo.Controls.Add(Me.TxtCurrencyCode)
        Me.ClientInfo.Controls.Add(Me.TxtUserID)
        Me.ClientInfo.Controls.Add(Me.TxtBranchID)
        Me.ClientInfo.Controls.Add(Me.TxtClientID)
        Me.ClientInfo.Controls.Add(Me.Label1)
        Me.ClientInfo.Controls.Add(Me.Label7)
        Me.ClientInfo.Controls.Add(Me.Label2)
        Me.ClientInfo.Controls.Add(Me.Label14)
        Me.ClientInfo.Controls.Add(Me.Label6)
        Me.ClientInfo.Controls.Add(Me.Label5)
        Me.ClientInfo.Controls.Add(Me.Label4)
        Me.ClientInfo.Location = New System.Drawing.Point(4, 22)
        Me.ClientInfo.Name = "ClientInfo"
        Me.ClientInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.ClientInfo.Size = New System.Drawing.Size(1318, 249)
        Me.ClientInfo.TabIndex = 0
        Me.ClientInfo.Tag = "Client Info"
        Me.ClientInfo.Text = "Client In formation With Buy Quat"
        Me.ClientInfo.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(590, 211)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Client Cert for SSL:"
        '
        'SslKey
        '
        Me.SslKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SslKey.Location = New System.Drawing.Point(689, 203)
        Me.SslKey.Name = "SslKey"
        Me.SslKey.Size = New System.Drawing.Size(275, 26)
        Me.SslKey.TabIndex = 17
        '
        'SslKeyBrowse
        '
        Me.SslKeyBrowse.Location = New System.Drawing.Point(979, 205)
        Me.SslKeyBrowse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SslKeyBrowse.Name = "SslKeyBrowse"
        Me.SslKeyBrowse.Size = New System.Drawing.Size(29, 24)
        Me.SslKeyBrowse.TabIndex = 18
        Me.SslKeyBrowse.Text = "..."
        Me.SslKeyBrowse.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(597, 183)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 14
        Me.LblSaveOption.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Transaction Type:"
        '
        'TxtUSD
        '
        Me.TxtUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUSD.Location = New System.Drawing.Point(542, 10)
        Me.TxtUSD.Name = "TxtUSD"
        Me.TxtUSD.Size = New System.Drawing.Size(33, 23)
        Me.TxtUSD.TabIndex = 5
        Me.TxtUSD.Text = "1"
        Me.TxtUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIMG
        '
        Me.TxtIMG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIMG.Location = New System.Drawing.Point(453, 130)
        Me.TxtIMG.Name = "TxtIMG"
        Me.TxtIMG.Size = New System.Drawing.Size(122, 23)
        Me.TxtIMG.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(417, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "IMG:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtForeignAmountSell)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.TxtDenomination)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TxtLocalAmount)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 155)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(569, 79)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sell Quat Information"
        '
        'TxtForeignAmountSell
        '
        Me.TxtForeignAmountSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtForeignAmountSell.Location = New System.Drawing.Point(386, 18)
        Me.TxtForeignAmountSell.Name = "TxtForeignAmountSell"
        Me.TxtForeignAmountSell.Size = New System.Drawing.Size(174, 23)
        Me.TxtForeignAmountSell.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(295, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Foreign Amount:"
        '
        'TxtDenomination
        '
        Me.TxtDenomination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDenomination.Location = New System.Drawing.Point(104, 46)
        Me.TxtDenomination.Name = "TxtDenomination"
        Me.TxtDenomination.Size = New System.Drawing.Size(187, 23)
        Me.TxtDenomination.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Denomination Mix:"
        '
        'TxtLocalAmount
        '
        Me.TxtLocalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocalAmount.Location = New System.Drawing.Point(104, 18)
        Me.TxtLocalAmount.Name = "TxtLocalAmount"
        Me.TxtLocalAmount.Size = New System.Drawing.Size(187, 23)
        Me.TxtLocalAmount.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Local Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, -13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transaction Type:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(591, 44)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(417, 130)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Schedule Setting"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblScheduleID)
        Me.GroupBox2.Controls.Add(Me.BtnSaveSchedule)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TxtInterval)
        Me.GroupBox2.Controls.Add(Me.TimeStop)
        Me.GroupBox2.Controls.Add(Me.TimeStart)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monday To Friday"
        '
        'LblScheduleID
        '
        Me.LblScheduleID.AutoSize = True
        Me.LblScheduleID.Location = New System.Drawing.Point(15, 82)
        Me.LblScheduleID.Name = "LblScheduleID"
        Me.LblScheduleID.Size = New System.Drawing.Size(13, 13)
        Me.LblScheduleID.TabIndex = 7
        Me.LblScheduleID.Text = "0"
        Me.LblScheduleID.Visible = False
        '
        'BtnSaveSchedule
        '
        Me.BtnSaveSchedule.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveSchedule.Location = New System.Drawing.Point(273, 54)
        Me.BtnSaveSchedule.Name = "BtnSaveSchedule"
        Me.BtnSaveSchedule.Size = New System.Drawing.Size(107, 27)
        Me.BtnSaveSchedule.TabIndex = 2
        Me.BtnSaveSchedule.Text = "Set &Schedule"
        Me.BtnSaveSchedule.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(219, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "minutes"
        '
        'TxtInterval
        '
        Me.TxtInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInterval.Location = New System.Drawing.Point(79, 56)
        Me.TxtInterval.Name = "TxtInterval"
        Me.TxtInterval.Size = New System.Drawing.Size(134, 26)
        Me.TxtInterval.TabIndex = 5
        Me.TxtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeStop
        '
        Me.TimeStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeStop.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeStop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TimeStop.Location = New System.Drawing.Point(257, 19)
        Me.TimeStop.Name = "TimeStop"
        Me.TimeStop.ShowUpDown = True
        Me.TimeStop.Size = New System.Drawing.Size(123, 26)
        Me.TimeStop.TabIndex = 4
        Me.TimeStop.Value = New Date(2013, 4, 4, 23, 0, 0, 0)
        '
        'TimeStart
        '
        Me.TimeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeStart.Location = New System.Drawing.Point(79, 21)
        Me.TimeStart.Name = "TimeStart"
        Me.TimeStart.ShowUpDown = True
        Me.TimeStart.Size = New System.Drawing.Size(134, 26)
        Me.TimeStart.TabIndex = 3
        Me.TimeStart.Value = New Date(2013, 4, 4, 8, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Interval:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(219, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "To:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Start From:"
        '
        'BtnSubRequest
        '
        Me.BtnSubRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubRequest.Location = New System.Drawing.Point(654, 10)
        Me.BtnSubRequest.Name = "BtnSubRequest"
        Me.BtnSubRequest.Size = New System.Drawing.Size(62, 28)
        Me.BtnSubRequest.TabIndex = 11
        Me.BtnSubRequest.Text = "-"
        Me.BtnSubRequest.UseVisualStyleBackColor = True
        '
        'TxtTransactionType
        '
        Me.TxtTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTransactionType.Location = New System.Drawing.Point(102, 103)
        Me.TxtTransactionType.Name = "TxtTransactionType"
        Me.TxtTransactionType.Size = New System.Drawing.Size(161, 23)
        Me.TxtTransactionType.TabIndex = 3
        '
        'BtnAddRequest
        '
        Me.BtnAddRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddRequest.Location = New System.Drawing.Point(586, 11)
        Me.BtnAddRequest.Name = "BtnAddRequest"
        Me.BtnAddRequest.Size = New System.Drawing.Size(62, 27)
        Me.BtnAddRequest.TabIndex = 10
        Me.BtnAddRequest.Text = "+"
        Me.BtnAddRequest.UseVisualStyleBackColor = True
        '
        'TxtForeignAmount
        '
        Me.TxtForeignAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtForeignAmount.Location = New System.Drawing.Point(379, 103)
        Me.TxtForeignAmount.Name = "TxtForeignAmount"
        Me.TxtForeignAmount.Size = New System.Drawing.Size(196, 23)
        Me.TxtForeignAmount.TabIndex = 8
        '
        'TxtSpreadType
        '
        Me.TxtSpreadType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSpreadType.Location = New System.Drawing.Point(379, 72)
        Me.TxtSpreadType.Name = "TxtSpreadType"
        Me.TxtSpreadType.Size = New System.Drawing.Size(196, 23)
        Me.TxtSpreadType.TabIndex = 7
        '
        'TxtCurrencyLabel
        '
        Me.TxtCurrencyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrencyLabel.Location = New System.Drawing.Point(379, 10)
        Me.TxtCurrencyLabel.Name = "TxtCurrencyLabel"
        Me.TxtCurrencyLabel.Size = New System.Drawing.Size(142, 23)
        Me.TxtCurrencyLabel.TabIndex = 4
        '
        'TxtCurrencyCode
        '
        Me.TxtCurrencyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrencyCode.Location = New System.Drawing.Point(379, 43)
        Me.TxtCurrencyCode.Name = "TxtCurrencyCode"
        Me.TxtCurrencyCode.Size = New System.Drawing.Size(196, 23)
        Me.TxtCurrencyCode.TabIndex = 6
        '
        'TxtUserID
        '
        Me.TxtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserID.Location = New System.Drawing.Point(64, 72)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(201, 23)
        Me.TxtUserID.TabIndex = 2
        '
        'TxtBranchID
        '
        Me.TxtBranchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBranchID.Location = New System.Drawing.Point(64, 43)
        Me.TxtBranchID.Name = "TxtBranchID"
        Me.TxtBranchID.Size = New System.Drawing.Size(199, 23)
        Me.TxtBranchID.TabIndex = 1
        '
        'TxtClientID
        '
        Me.TxtClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClientID.Location = New System.Drawing.Point(64, 10)
        Me.TxtClientID.Name = "TxtClientID"
        Me.TxtClientID.Size = New System.Drawing.Size(199, 23)
        Me.TxtClientID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(287, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Foreign Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(288, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Currency Label:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Spread Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Currency Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GridSOAPRequstSetting)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1322, 290)
        Me.GroupBox3.TabIndex = 4
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
        Me.GridSOAPRequstSetting.Size = New System.Drawing.Size(1316, 271)
        Me.GridSOAPRequstSetting.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'ErrorValidateTion
        '
        Me.ErrorValidateTion.ContainerControl = Me
        '
        'SetingSOAPMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SetingSOAPMessage"
        Me.Size = New System.Drawing.Size(1332, 593)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ClientInfo.ResumeLayout(False)
        Me.ClientInfo.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridSOAPRequstSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidateTion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ClientInfo As System.Windows.Forms.TabPage
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtUSD As System.Windows.Forms.TextBox
    Friend WithEvents TxtIMG As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtForeignAmountSell As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtDenomination As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtLocalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSubRequest As System.Windows.Forms.Button
    Friend WithEvents TxtTransactionType As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddRequest As System.Windows.Forms.Button
    Friend WithEvents TxtForeignAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtSpreadType As System.Windows.Forms.TextBox
    Friend WithEvents TxtCurrencyLabel As System.Windows.Forms.TextBox
    Friend WithEvents TxtCurrencyCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserID As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranchID As System.Windows.Forms.TextBox
    Friend WithEvents TxtClientID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSaveSchedule As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TimeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtInterval As System.Windows.Forms.TextBox
    Friend WithEvents TimeStop As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GridSOAPRequstSetting As Janus.Windows.GridEX.GridEX
    Friend WithEvents ErrorValidateTion As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblScheduleID As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents SslKey As System.Windows.Forms.TextBox
    Public WithEvents SslKeyBrowse As System.Windows.Forms.Button

End Class
