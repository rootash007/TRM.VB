Imports System.IO

Public Class FrmAgreementPrint

    Private Sub FrmAgreementPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RptAgreementPrint.LocalReport.SetParameters(Agparams)
        Me.RptAgreementPrint.RefreshReport()

        Dim byteViewer As Byte() = RptAgreementPrint.LocalReport.Render("PDF")
        Dim SFDAgreement As New SaveFileDialog()
        SFDAgreement.Filter = "*PDF files (*.pdf)|*.pdf"
        SFDAgreement.FilterIndex = 2
        SFDAgreement.RestoreDirectory = True
        If AgreementStatus = "CarSale" Then
            Dim newFile As New FileStream("הסכמים\הסכם מכירה - רכב מספר " & AgreeCarSerial & ".pdf", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            AgreementPath = newFile.Name.ToString
        ElseIf AgreementStatus = "CarBuy" Then
            Dim newFile As New FileStream("הסכמים\הסכם קנייה - רכב מספר " & AgreeCarSerial & ".pdf", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            AgreementPath = newFile.Name.ToString
        End If
    End Sub


End Class