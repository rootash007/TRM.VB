Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class FrmPrintSoldReport

    Private Sub FrmPrintSoldReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Params(9) As ReportParameter
        Params(0) = New ReportParameter("JobName", My.Settings.LocalServer)
        Params(1) = New ReportParameter("JobPhone", My.Settings.CurrentServer)
        Params(2) = New ReportParameter("JobFax", My.Settings.AdminUser)
        Params(3) = New ReportParameter("JobEmail", My.Settings.AdminPass)
        Params(4) = New ReportParameter("JobId", My.Settings.isShowWhatsNew)
        Params(5) = New ReportParameter("JobAdress", My.Settings.OnlineServer)
        Params(6) = New ReportParameter("Date1", FmSoldReport.DtpFrom.Value.ToShortDateString)
        Params(7) = New ReportParameter("Date2", FmSoldReport.DtpTo.Value.ToShortDateString)
        Params(8) = New ReportParameter("TotalCars", FmSoldReport.TxtCarsTotal.Text)
        Params(9) = New ReportParameter("SumTotal", FmSoldReport.TxtTotalProfits.Text)

        RptSoldReportViwer.LocalReport.SetParameters(Params)
        Me.RptSoldReportViwer.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim byteViewer As Byte() = RptSoldReportViwer.LocalReport.Render("PDF")
        Dim SFDAgreement As New SaveFileDialog()
        SFDAgreement.Filter = "*PDF files (*.pdf)|*.pdf"
        SFDAgreement.FilterIndex = 2
        SFDAgreement.RestoreDirectory = True
        Dim newFile As New FileStream("הסכמים\רכב מספר " & ActiveUser & ".pdf", FileMode.Create)
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()
        MsgBox("done")
        'AgreementPath = newFile.Name.ToString
    End Sub
End Class