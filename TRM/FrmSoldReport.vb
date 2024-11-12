Imports Microsoft.Reporting.WinForms

Public Class FrmSoldReport
    Dim DayIs As Integer
    Dim MonthIs As Integer
    Dim YearIs As Integer

    Private Sub FrmSoldReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TCWindow = "SoldReport"
        TxtCarsTotal.Text = ""
        TxtTotalIn.Text = ""
        TxtTotalOut.Text = ""
        TxtTotalProfits.Text = ""

        DayIs = DtpFrom.Value.Day - 1
        MonthIs = DtpFrom.Value.Month
        YearIs = DtpFrom.Value.Year
        DtpFrom.Value = DtpFrom.Value.AddDays(-DayIs)
        If (MonthIs = 1) Or (MonthIs = 3) Or (MonthIs = 5) Or (MonthIs = 7) Or (MonthIs = 8) Or (MonthIs = 10) Or (MonthIs = 12) Then
            DtpTo.Value = DtpFrom.Value.AddDays(30)
        ElseIf (MonthIs = 4) Or (MonthIs = 6) Or (MonthIs = 9) Or (MonthIs = 11) Then
            DtpTo.Value = DtpFrom.Value.AddDays(29)
        ElseIf MonthIs = 2 Then
            If YearIs Mod 4 = 0 Then
                DtpTo.Value = DtpFrom.Value.AddDays(28)
            Else
                DtpTo.Value = DtpFrom.Value.AddDays(27)
            End If
        End If
        Dim d1 As Date
        Dim d2 As Date
        d1 = Me.DtpFrom.Value.AddDays(-1)
        d2 = Me.DtpTo.Value
        Fill2Dates(d1, d2)
        Me.DGVSoldReport.DataSource = SoldTab
        DesignSoldDGV(Me.DGVSoldReport)
        LblNoResults.Visible = True
        If DGVSoldReport.Rows.Count > 0 Then
            SoldTab.Clear()
        End If
    End Sub

    Private Sub DtpFrom_Leave(sender As Object, e As EventArgs) Handles DtpFrom.Leave
        DayIs = DtpFrom.Value.Day
        MonthIs = DtpFrom.Value.Month
        YearIs = DtpFrom.Value.Year
        If DayIs = 1 Then
            DtpTo.Value = DtpFrom.Value.AddMonths(1)
            DtpTo.Value = DtpTo.Value.AddDays(-1)
        ElseIf DayIs > 1 Then
            If ((MonthIs = 4) Or (MonthIs = 6) Or (MonthIs = 9) Or (MonthIs = 11)) Then

                If DayIs = 30 Then
                    DtpTo.Value = DtpFrom.Value.AddMonths(1)
                    DtpTo.Value = DtpTo.Value.AddDays(1)
                Else
                    DtpTo.Value = DtpFrom.Value.AddMonths(1)
                End If

            ElseIf (MonthIs = 1) Or (MonthIs = 3) Or (MonthIs = 5) Or (MonthIs = 7) Or (MonthIs = 8) Or (MonthIs = 10) Or (MonthIs = 12) Then
                DtpTo.Value = DtpFrom.Value.AddMonths(1)
            ElseIf MonthIs = 2 Then

                If DayIs < 28 Then
                    DtpTo.Value = DtpFrom.Value.AddMonths(1)
                ElseIf DayIs = 29 Then
                    DtpTo.Value = DtpFrom.Value.AddMonths(1)
                    DtpTo.Value = DtpTo.Value.AddDays(2)
                ElseIf DayIs = 28 Then
                    If YearIs Mod 4 = 0 Then
                        DtpTo.Value = DtpFrom.Value.AddMonths(1)
                    Else
                        DtpTo.Value = DtpFrom.Value.AddMonths(1)
                        DtpTo.Value = DtpTo.Value.AddDays(3)
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Dim DateFrom As Date
        Dim DateTo As Date
        Dim TotalIn As Integer = 0
        Dim TotalOut As Integer = 0
        Dim TotalProfits As Integer = 0
        DateFrom = DtpFrom.Value.AddDays(-1).ToString

        DateTo = DtpTo.Value.ToString
        Fill2Dates(DateFrom, DateTo)
        Me.DGVSoldReport.DataSource = SoldTab
        DesignSoldDGV(Me.DGVSoldReport)
        If DGVSoldReport.RowCount > 0 Then
            LblNoResults.Visible = False
        Else
            LblNoResults.Visible = True
        End If
        TxtCarsTotal.Text = DGVSoldReport.RowCount
        For i = 0 To DGVSoldReport.RowCount - 1
            TotalIn += DGVSoldReport.Rows(i).Cells(28).Value
            TotalOut += DGVSoldReport.Rows(i).Cells(15).Value
        Next
        TxtTotalIn.Text = TotalIn
        TxtTotalOut.Text = TotalOut
        TxtTotalProfits.Text = TotalOut - TotalIn
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim rds = New ReportDataSource("DataSet1", SoldTab)
        FrmPrintSoldReport.RptSoldReportViwer.LocalReport.DataSources.Clear()
        FrmPrintSoldReport.RptSoldReportViwer.LocalReport.DataSources.Add(rds)
        FrmPrintSoldReport.RptSoldReportViwer.LocalReport.ReportEmbeddedResource = "TRM.RptSoldReport.rdlc"
        FrmPrintSoldReport.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DGVSoldReport_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSoldReport.CellDoubleClick
        FrmSoldCard.ShowDialog()
    End Sub

    Private Sub BtnClose_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTotalProfits.KeyDown, TxtTotalOut.KeyDown, TxtTotalIn.KeyDown, TxtCarsTotal.KeyDown, DtpTo.KeyDown, DtpFrom.KeyDown, DGVSoldReport.KeyDown, BtnSave.KeyDown, BtnReload.KeyDown, BtnPrint.KeyDown, BtnClose.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnAbort_Click(sender As Object, e As EventArgs) Handles BtnAbort.Click
        If DGVSoldReport.RowCount > 0 Then
            If AdminMode = True Then
                TCWindow = "SoldReport"
                FmTransactionCancel = New FrmMaterialsImportExcel
                FmTransactionCancel.ShowDialog()

                '    'FrmTransactionCancel.ShowDialog()
            Else
                OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו")
                'MsgBox("אין לך הרשאה לפעולה זו", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "אין הרשאה")
            End If
        Else
            OkMsgInfo("אין בחירה", "רשימת רכבים ריקה")
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Dim byteViewer As Byte() = FrmPrintSoldReport.RptSoldReportViwer.LocalReport.Render("PDF")
        'Dim SFDAgreement As New SaveFileDialog()
        'SFDAgreement.Filter = "*PDF files (*.pdf)|*.pdf"
        'SFDAgreement.FilterIndex = 2
        'SFDAgreement.RestoreDirectory = True
        'Dim newFile As New FileStream("הסכמים\הסכם מכירה - רכב מספר " & ActiveUser & ".pdf", FileMode.Create)
        'newFile.Write(byteViewer, 0, byteViewer.Length)
        'newFile.Close()
        'MsgBox("done")
        'AgreementPath = newFile.Name.ToString
    End Sub
End Class