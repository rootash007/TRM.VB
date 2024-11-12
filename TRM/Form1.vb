Imports Microsoft.Reporting.WinForms

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim que As String
        que = "select carserial,Carid from mainlist"
        FillList(que)
        DataGridView1.DataSource = MyTab


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rds = New ReportDataSource("DataSet1", MyTab)
        FrmPrintSoldReport.RptSoldReportViwer.LocalReport.DataSources.Clear()
        FrmPrintSoldReport.RptSoldReportViwer.LocalReport.DataSources.Add(rds)
        FrmPrintSoldReport.RptSoldReportViwer.LocalReport.ReportEmbeddedResource = "TRM.Report1.rdlc"

        FrmPrintSoldReport.ShowDialog()
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    MsgBox(CountMe)
    'End Sub

End Class