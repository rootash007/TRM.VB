Public Class FrmSoldCard

    Private Sub FrmSoldCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblJobAdress.Text = My.Settings.OnlineServer
        LblJobEmail.Text = My.Settings.AdminPass
        LblJobFax.Text = My.Settings.AdminUser
        LblJobId.Text = My.Settings.isShowWhatsNew
        LblJobName.Text = My.Settings.LocalServer
        LblJobPhone.Text = My.Settings.CurrentServer
        If SoldCardWinDow = "Search" Then
            LoadSoldCard2()
        Else
            LoadSoldCard()
        End If
        'LoadSoldCard2(FmSoldReport)
    End Sub

    Private Sub BtnBuyAgreement_Click(sender As Object, e As EventArgs) Handles BtnBuyAgreement.Click
        Try
            If FmSoldReport.DGVAlerts.CurrentRow.Cells(42).Value = "" Then
                MsgBox("אין הסכם קנייה", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "הסכם קנייה")
            Else
                Process.Start(FmSoldReport.DGVAlerts.CurrentRow.Cells(42).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSaleAgreement_Click(sender As Object, e As EventArgs) Handles BtnSaleAgreement.Click
        Try
            If FmSoldReport.DGVAlerts.CurrentRow.Cells(42).Value.ToString = "" Then
                MsgBox("אין הסכם מכירה", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "הסכם מכירה")
            Else
                Process.Start(FmSoldReport.DGVAlerts.CurrentRow.Cells(43).Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        FrmSoldCardPrint.ShowDialog()
    End Sub

    Private Sub BtnClose_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtShelda.KeyDown, TxtSalerPhone.KeyDown, TxtSalerName.KeyDown, TxtSalerId.KeyDown, TxtSalerAdress.KeyDown, TxtSaleDate.KeyDown, TxtReceiptNum.KeyDown, TxtPriceOut.KeyDown, TxtPriceIn.KeyDown, TxtMainIs.KeyDown, TxtKeyNum.KeyDown, TxtInvoiceNum.KeyDown, TxtEngine.KeyDown, TxtDateTest.KeyDown, TxtDateIn.KeyDown, TxtConfirmNum.KeyDown, TxtCarYear.KeyDown, TxtCarType.KeyDown, TxtCarSerial.KeyDown, TxtCarSaleInfo.KeyDown, TxtCarOil.KeyDown, TxtCarModel.KeyDown, TxtCarKM.KeyDown, TxtCarKind.KeyDown, TxtCarId.KeyDown, TxtCarHand.KeyDown, TxtCarGear.KeyDown, TxtCarColor.KeyDown, TxtCarCode.KeyDown, TxtCarBuyInfo.KeyDown, TxtBuyerPhone.KeyDown, TxtBuyerName.KeyDown, TxtBuyerId.KeyDown, TxtBuyerAdress.KeyDown, ChkWheels.KeyDown, ChkVav.KeyDown, ChkSeats.KeyDown, ChkRoof.KeyDown, BtnSaleAgreement.KeyDown, BtnPrint.KeyDown, BtnClose.KeyDown, BtnBuyAgreement.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class