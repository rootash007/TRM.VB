Public Class FrmCarDelete

    Private Sub FrmCarDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LblModel.Text = FrmMainList.DgvMain.CurrentRow.Cells(5).Value
        'LblType.Text = FrmMainList.DgvMain.CurrentRow.Cells(6).Value
        'LblYear.Text = FrmMainList.DgvMain.CurrentRow.Cells(7).Value
        'LblPrice.Text = FrmMainList.DgvMain.CurrentRow.Cells(28).Value
        'TxtDeleteInfo.Text = "אין"
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'CarDeleteRestore(FrmMainList.DgvMain.CurrentRow.Cells(0).Value, 1, TxtDeleteInfo.Text, DtpDeleteDate.Value.ToShortDateString)
        ReloadMainList()
        ReLoadMain()
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDeleteInfo.KeyDown, BtnDelete.KeyDown, BtnClose.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class