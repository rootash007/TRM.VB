Public Class FrmReportChose

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        'Select Case LBReports.SelectedIndex
        '    Case 0
        '        Me.Close()
        '        FrmMlaiYear.ShowDialog()
        '    Case 1
        '        FrmSoldReport.ShowDialog()
        '    Case 2
        '        FrmDeletedReport.ShowDialog()
        'End Select
    End Sub

    Private Sub LBReports_KeyDown(sender As Object, e As KeyEventArgs) Handles LBReports.KeyDown, BtnShow.KeyDown, BtnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class