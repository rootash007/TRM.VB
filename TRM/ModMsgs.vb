Module ModMsgs

    Public Sub OkMsgAlert(title As String, Msg As String)
        FrmOkMsg.LblTitle.Text = title
        FrmOkMsg.LblMsg.Text = Msg
        FrmOkMsg.PbSign.Image = My.Resources.Alert
        FrmOkMsg.ShowDialog()
    End Sub

    Public Sub OkMsgInfo(title As String, Msg As String)
        FrmOkMsg.LblTitle.Text = title
        FrmOkMsg.LblMsg.Text = Msg
        FrmOkMsg.PbSign.Image = My.Resources.Info
        FrmOkMsg.ShowDialog()
    End Sub
End Module
