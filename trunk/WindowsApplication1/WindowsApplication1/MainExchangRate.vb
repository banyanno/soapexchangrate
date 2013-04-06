Public Class MainExchangRate
    Dim SOAPSetting As SetingSOAPMessage
    Dim DashbordSend As UCDashbordRequest
    Dim DA_SCHEDULE As New DS_HelperTableAdapters.SCHEDULETableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Init UI Control
        InitUI()

    End Sub
    Private Sub InitUI()
        SOAPSetting = New SetingSOAPMessage
        DashbordSend = New UCDashbordRequest
    End Sub
    Private Sub MainExchangRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainApplicationForm = Me
        LoadCurrentTime.Start()
        LoadScheduleStatus()

    End Sub

    Private Delegate Sub DelShowLoadingPicture(ByVal visible As Boolean)
    Public Sub StatusLoading(ByVal v As Boolean)
        If Me.Created Then
            RibboStatusBar.Invoke(New DelShowLoadingPicture(AddressOf UpdateVisibleLoading), New Object() {v})
        End If
    End Sub
    Private Sub UpdateVisibleLoading(ByVal v As Boolean)
        LoadingBar.Visible = v
    End Sub

    Private Sub LoadScheduleStatus()
        Dim TblSchedule As DataTable = DA_SCHEDULE.GetData
        For Each drow As DataRow In TblSchedule.Rows
            'LblStartTime.Text = drow("SCHEDULE_ID")
            LblStartTime.Text = CDate(drow("START_TIME")).ToShortTimeString
            LblEndTime.Text = CDate(drow("END_TIME")).ToShortTimeString
            LblInterval.Text = drow("INTERVAL") & " (Minute)"
        Next
    End Sub
    Sub AddUserControl(ByVal PMainContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer, ByVal UI As UserControl, ByVal Info As String)
        Me.Cursor = Cursors.WaitCursor
        PMainContainer.Controls.Clear()
        PMainContainer.AutoScroll = True
        UI.Dock = DockStyle.Fill
        PMainContainer.Controls.Add(UI)
        Me.Cursor = Cursors.Default
        uiPanel1.Text = Info
    End Sub

    
    Private Sub MenuBarButton_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles MenuBarButton.ItemClick
        Select Case e.Item.Key
            Case "SOAPSetting"
                AddUserControl(Me.MainContainner, SOAPSetting, "SOAP Message Request Setting")
            Case "DashbordRequest"
                AddUserControl(Me.MainContainner, DashbordSend, "Send request")
        End Select
    End Sub

    Private Sub LoadCurrentTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadCurrentTime.Tick
        LblCurrentime.Text = TimeOfDay.ToLongTimeString
    End Sub
End Class