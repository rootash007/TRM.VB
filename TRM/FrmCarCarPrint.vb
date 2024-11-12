Imports Microsoft.Reporting.WinForms

Public Class FrmCarCarPrint
   
    Private Sub FrmCarCarPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Retu As String
        Dim JobName As New ReportParameter("JobName", My.Settings.JobName)
        Dim JobPhone As New ReportParameter("JobPhone", My.Settings.JobPhone)
        Dim JobFax As New ReportParameter("JobFax", My.Settings.JobFax)
        Dim JobEmail As New ReportParameter("JobEmail", My.Settings.JobEmail)
        Dim JobId As New ReportParameter("JobId", My.Settings.JobId)
        Dim JobAdress As New ReportParameter("JobAdress", My.Settings.JobAdress)
        Dim CarSerial As New ReportParameter("CarSerial", FrmCarCard.TxtCarSerial.Text)
        Dim CarId As New ReportParameter("CarId", FrmCarCard.TxtCarId.Text)
        Dim CarKind As New ReportParameter("CarKind", FrmCarCard.TxtCarKind.Text)
        Dim CarModel As New ReportParameter("CarModel", FrmCarCard.TxtCarModel.Text)
        Dim CarType As New ReportParameter("CarType", FrmCarCard.TxtCarType.Text)
        Dim CarColor As New ReportParameter("CarColor", FrmCarCard.TxtCarColor.Text)
        Dim CarOil As New ReportParameter("CarOil", FrmCarCard.TxtCarOil.Text)
        Dim CarKM As New ReportParameter("CarKM", FrmCarCard.TxtCarKM.Text)
        Dim Shelda As New ReportParameter("Shelda", FrmCarCard.TxtShelda.Text)
        Dim CarYear As New ReportParameter("CarYear", FrmCarCard.TxtCarYear.Text)
        Dim DateTest As New ReportParameter("DateTest", FrmCarCard.TxtDateTest.Text)
        Dim KeyNum As New ReportParameter("KeyNum", FrmCarCard.TxtKeyNum.Text)
        Dim CarGear As New ReportParameter("CarGear", FrmCarCard.TxtCarGear.Text)
        Dim MainIs As New ReportParameter("MainIs", FrmCarCard.TxtMainIs.Text)
        Dim CarHand As New ReportParameter("CarHand", FrmCarCard.TxtCarHand.Text)
        Dim Engine As New ReportParameter("Engine", FrmCarCard.TxtEngine.Text)
        Dim CarBuyInfo As New ReportParameter("CarBuyInfo", FrmCarCard.TxtCarInfo.Text)
        If FrmCarCard.ChkSeats.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Dim seats As New ReportParameter("seats", Retu)
        If FrmCarCard.ChkWheels.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Dim wheels As New ReportParameter("wheels", Retu)
        If FrmCarCard.ChkRoof.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Dim SunRf As New ReportParameter("sunrf", Retu)
        If FrmCarCard.ChkVav.Checked = True Then
            Retu = "כן"
        Else
            Retu = "לא"
        End If
        Dim vaav As New ReportParameter("vaav", Retu)
        Dim CarCode As New ReportParameter("CarCode", FrmCarCard.TxtCarCode.Text)
        Dim PriceOut As New ReportParameter("PriceOut", FrmCarCard.TxtPriceOut.Text)
        RPTCarCardPrint.LocalReport.SetParameters(JobAdress)
        RPTCarCardPrint.LocalReport.SetParameters(JobName)
        RPTCarCardPrint.LocalReport.SetParameters(JobPhone)
        RPTCarCardPrint.LocalReport.SetParameters(JobFax)
        RPTCarCardPrint.LocalReport.SetParameters(JobEmail)
        RPTCarCardPrint.LocalReport.SetParameters(JobId)
        RPTCarCardPrint.LocalReport.SetParameters(CarSerial)
        RPTCarCardPrint.LocalReport.SetParameters(CarYear)
        RPTCarCardPrint.LocalReport.SetParameters(CarColor)
        RPTCarCardPrint.LocalReport.SetParameters(CarOil)
        RPTCarCardPrint.LocalReport.SetParameters(CarKM)
        RPTCarCardPrint.LocalReport.SetParameters(Shelda)
        RPTCarCardPrint.LocalReport.SetParameters(PriceOut)
        RPTCarCardPrint.LocalReport.SetParameters(DateTest)
        RPTCarCardPrint.LocalReport.SetParameters(CarKind)
        RPTCarCardPrint.LocalReport.SetParameters(CarModel)
        RPTCarCardPrint.LocalReport.SetParameters(CarType)
        RPTCarCardPrint.LocalReport.SetParameters(MainIs)
        RPTCarCardPrint.LocalReport.SetParameters(CarGear)
        RPTCarCardPrint.LocalReport.SetParameters(CarCode)
        RPTCarCardPrint.LocalReport.SetParameters(Engine)
        RPTCarCardPrint.LocalReport.SetParameters(CarHand)
        RPTCarCardPrint.LocalReport.SetParameters(KeyNum)
        RPTCarCardPrint.LocalReport.SetParameters(CarBuyInfo)
        RPTCarCardPrint.LocalReport.SetParameters(CarId)
        RPTCarCardPrint.LocalReport.SetParameters(seats)
        RPTCarCardPrint.LocalReport.SetParameters(wheels)
        RPTCarCardPrint.LocalReport.SetParameters(SunRf)
        RPTCarCardPrint.LocalReport.SetParameters(vaav)
        Me.RPTCarCardPrint.RefreshReport()
    End Sub
End Class