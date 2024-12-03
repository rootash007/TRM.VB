Imports Microsoft.Reporting.WinForms

Public Class FrmSoldCardPrint

    Private Sub FrmSoldCardPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Retu As String
        Dim Params(43) As ReportParameter
        Params(0) = New ReportParameter("JobName", My.Settings.LocalServer)
        Params(1) = New ReportParameter("JobPhone", My.Settings.CurrentServer)
        Params(2) = New ReportParameter("JobFax", My.Settings.AdminUser)
        Params(3) = New ReportParameter("JobEmail", My.Settings.AdminPass)
        Params(4) = New ReportParameter("JobId", My.Settings.isShowWhatsNew)
        Params(5) = New ReportParameter("JobAdress", My.Settings.OnlineServer)
        Params(6) = New ReportParameter("CarSerial", FrmSoldCard.TxtCarSerial.Text)
        Params(7) = New ReportParameter("CarId", FrmSoldCard.TxtCarId.Text)
        Params(8) = New ReportParameter("DateIn", FrmSoldCard.TxtDateIn.Text)
        Params(9) = New ReportParameter("CarKind", FrmSoldCard.TxtCarKind.Text)
        Params(10) = New ReportParameter("CarModel", FrmSoldCard.TxtCarModel.Text)
        Params(11) = New ReportParameter("CarType", FrmSoldCard.TxtCarType.Text)
        Params(12) = New ReportParameter("CarYear", FrmSoldCard.TxtCarYear.Text)
        Params(13) = New ReportParameter("CarColor", FrmSoldCard.TxtCarColor.Text)
        Params(14) = New ReportParameter("CarGear", FrmSoldCard.TxtCarGear.Text)
        Params(15) = New ReportParameter("CarOil", FrmSoldCard.TxtCarOil.Text)
        Params(16) = New ReportParameter("Engine", FrmSoldCard.TxtEngine.Text)
        Params(17) = New ReportParameter("CarKM", FrmSoldCard.TxtCarKM.Text)
        Params(18) = New ReportParameter("CarCode", FrmSoldCard.TxtCarCode.Text)
        Params(19) = New ReportParameter("Shelda", FrmSoldCard.TxtShelda.Text)
        Params(20) = New ReportParameter("MainIs", FrmSoldCard.TxtMainIs.Text)
        Params(21) = New ReportParameter("DateTest", FrmSoldCard.TxtDateTest.Text)
        Params(22) = New ReportParameter("PriceIn", FrmSoldCard.TxtPriceIn.Text)
        Params(23) = New ReportParameter("KeyNum", FrmSoldCard.TxtKeyNum.Text)
        Params(24) = New ReportParameter("CarHand", FrmSoldCard.TxtCarHand.Text)
        Params(25) = New ReportParameter("CarBuyInfo", FrmSoldCard.TxtCarBuyInfo.Text)
        If FrmSoldCard.ChkSeats.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Params(26) = New ReportParameter("Seats", Retu)
        If FrmSoldCard.ChkWheels.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Params(27) = New ReportParameter("Wheels", Retu)
        If FrmSoldCard.ChkRoof.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Params(28) = New ReportParameter("SunRF", Retu)
        If FrmSoldCard.ChkVav.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Params(29) = New ReportParameter("Vaav", Retu)

        Params(30) = New ReportParameter("SalerName", FrmSoldCard.TxtSalerName.Text)
        Params(31) = New ReportParameter("SalerId", FrmSoldCard.TxtSalerId.Text)
        Params(32) = New ReportParameter("SalerAdress", FrmSoldCard.TxtSalerAdress.Text)
        Params(33) = New ReportParameter("SalerPhone", FrmSoldCard.TxtSalerPhone.Text)
        Params(34) = New ReportParameter("BuyerName", FrmSoldCard.TxtBuyerName.Text)
        Params(35) = New ReportParameter("BuyerId", FrmSoldCard.TxtBuyerId.Text)
        Params(36) = New ReportParameter("BuyerAdress", FrmSoldCard.TxtBuyerAdress.Text)
        Params(37) = New ReportParameter("BuyerPhone", FrmSoldCard.TxtBuyerPhone.Text)

        Params(38) = New ReportParameter("SaleDate", FrmSoldCard.TxtSaleDate.Text)
        Params(39) = New ReportParameter("Confirm", FrmSoldCard.TxtConfirmNum.Text)
        Params(40) = New ReportParameter("Receipt", FrmSoldCard.TxtReceiptNum.Text)
        Params(41) = New ReportParameter("Invoice", FrmSoldCard.TxtInvoiceNum.Text)
        Params(42) = New ReportParameter("PriceOut", FrmSoldCard.TxtPriceOut.Text)
        Params(43) = New ReportParameter("CarSaleInfo", FrmSoldCard.TxtCarSaleInfo.Text)

        RptSoldCarPrint.LocalReport.SetParameters(Params)
        Me.RptSoldCarPrint.RefreshReport()

        'Dim byteViewer As Byte() = RptAgreementPrint.LocalReport.Render("PDF")
        'Dim SFDAgreement As New SaveFileDialog()
        'SFDAgreement.Filter = "*PDF files (*.pdf)|*.pdf"
        'SFDAgreement.FilterIndex = 2
        'SFDAgreement.RestoreDirectory = True
        'If AgreementStatus = "CarSale" Then
        '    Dim newFile As New FileStream("הסכמים\הסכם מכירה - רכב מספר " & CarSerial & ".pdf", FileMode.Create)
        '    newFile.Write(byteViewer, 0, byteViewer.Length)
        '    newFile.Close()
        '    AgreementPath = newFile.Name.ToString
        'ElseIf AgreementStatus = "CarBuy" Then
        '    Dim newFile As New FileStream("הסכמים\הסכם קנייה - רכב מספר " & CarSerial & ".pdf", FileMode.Create)
        '    newFile.Write(byteViewer, 0, byteViewer.Length)
        '    newFile.Close()
        '    AgreementPath = newFile.Name.ToString
        'End If

    End Sub
End Class