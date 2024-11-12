Public Class FrmCarCard

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCarCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblJobName.Text = My.Settings.LocalServer
        LblJobAdress.Text = My.Settings.OnlineServer
        LblJobPhone.Text = My.Settings.CurrentServer
        LblJobFax.Text = My.Settings.AdminUser
        LblJobEmail.Text = My.Settings.AdminPass
        LblJobId.Text = My.Settings.JobId
        'LoadCarCard()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmCarCardPrint.ShowDialog()
    End Sub

    Private Sub BtnBuyAgreement_Click(sender As Object, e As EventArgs) Handles BtnBuyAgreement.Click
        Try
            'If FrmMainList.DgvMain.CurrentRow.Cells(42).Value = "" Then
            '    OkMsgAlert("הסכם קנייה", "אין הסכם קניי")
            '    'MsgBox("אין הסכם קנייה", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "הסכם קנייה")
            'Else
            '    Process.Start(FrmMainList.DgvMain.CurrentRow.Cells(42).Value)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCarInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtShelda.KeyDown, TxtPriceOut.KeyDown, TxtMainIs.KeyDown, TxtKeyNum.KeyDown, TxtEngine.KeyDown, TxtDateTest.KeyDown, TxtCarYear.KeyDown, TxtCarType.KeyDown, TxtCarSerial.KeyDown, TxtCarOil.KeyDown, TxtCarModel.KeyDown, TxtCarKM.KeyDown, TxtCarKind.KeyDown, TxtCarInfo.KeyDown, TxtCarId.KeyDown, TxtCarHand.KeyDown, TxtCarGear.KeyDown, TxtCarColor.KeyDown, TxtCarCode.KeyDown, MyBase.KeyDown, ChkWheels.KeyDown, ChkVav.KeyDown, ChkSeats.KeyDown, ChkRoof.KeyDown, BtnCancel.KeyDown, BtnBuyAgreement.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class