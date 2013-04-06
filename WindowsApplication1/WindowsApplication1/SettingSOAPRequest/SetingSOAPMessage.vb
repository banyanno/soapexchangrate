Public Class SetingSOAPMessage

    Dim DA_SCHEDULE As New DS_HelperTableAdapters.SCHEDULETableAdapter
    Dim DA_RATE_SETTING As New DS_HelperTableAdapters.REQUEST_SETTINGTableAdapter

    Private Sub SetingSOAPMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TimeStart.Text = "8:55:90 PM"
        LoadSchedule()
        LoadSetting()
    End Sub
    Private Sub LoadSchedule()
        Dim TblSchedule As DataTable = DA_SCHEDULE.GetData
        For Each drow As DataRow In TblSchedule.Rows
            LblScheduleID.Text = drow("SCHEDULE_ID")
            TimeStart.Value = drow("START_TIME")
            TimeStop.Value = drow("END_TIME")
            TxtInterval.Text = drow("INTERVAL")
        Next
    End Sub
    Private Sub LoadSetting()
        GridSOAPRequstSetting.DataSource = DA_RATE_SETTING.GetData
    End Sub

    Private Sub BtnSaveSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveSchedule.Click
        If LblScheduleID.Text = "0" Then
            DA_SCHEDULE.InsertNewSchedule(TimeStart.Value, TimeStop.Value, TxtInterval.Text)
            LoadSchedule()
        Else
            DA_SCHEDULE.UpdateSchedule(TimeStart.Value, TimeStop.Value, TxtInterval.Text, LblScheduleID.Text)
            LoadSchedule()
        End If
    End Sub

   
    

    Private Sub BtnAddRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddRequest.Click
        If LblSaveOption.Text = "0" Then
            If DA_RATE_SETTING.InsertNewSetting(TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text, TxtTransactionType.Text, TxtCurrencyLabel.Text, TxtCurrencyCode.Text, TxtSpreadType.Text, TxtForeignAmount.Text, "", "", "", "", "", "", TxtForeignAmountSell.Text, TxtLocalAmount.Text, TxtDenomination.Text, SslKey.Text, TxtIMG.Text) = 1 Then
                LoadSetting()
            Else

            End If
        Else

        End If
    End Sub

    Private Sub BtnSubRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubRequest.Click
        If GridSOAPRequstSetting.SelectedItems.Count = 0 Then Exit Sub
        DA_RATE_SETTING.DeleteReuestSeting(GridSOAPRequstSetting.GetRow.Cells("REQUEST_ID").Value)
        LoadSetting()
    End Sub

    Private Sub SslKeyBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SslKeyBrowse.Click
        Dim Dlg As New OpenFileDialog
        Dim Res As DialogResult
        Dlg.DefaultExt = ".cer"
        Res = Dlg.ShowDialog()
        If Res = DialogResult.OK And Dlg.FileName.Length > 0 Then
            SslKey.Text = Dlg.FileName
        End If
    End Sub
End Class
