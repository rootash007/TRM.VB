Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmCostList
    Dim dt As New DataTable()
    Dim bindingSource As New BindingSource()

    Private Sub FrmCarSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        BtnCloseActions.Visible = False
        NumYear.Value = Now.Year - 1
        DTPStartDate.Value = "01/01/" & NumYear.Value
        DTPEndDate.Value = "31/12/" & NumYear.Value
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        YearReLoad(DTPStartDate.Value, DTPEndDate.Value)
        TxtMaterialCount.Text = DGVCostList.RowCount
        Dim MoneyPaid As Double = 0
        Dim MoneyCost As Double = 0
        Dim MoneyDefferance As Double = 0
        TxtPaid.Text = 0
        TxtCost.Text = 0
        For i = 0 To DGVCostList.RowCount - 1
            TxtPaid.Text += DGVCostList.Rows(i).Cells(3).Value
            TxtCost.Text += DGVCostList.Rows(i).Cells(5).Value
        Next
        TxtDeff.Text = TxtCost.Text - TxtPaid.Text
    End Sub
    Private Sub NumYear_ValueChanged(sender As Object, e As EventArgs) Handles NumYear.ValueChanged
        DTPStartDate.Value = "01/01/" & NumYear.Value
        DTPEndDate.Value = "31/12/" & NumYear.Value
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub DGVCostList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCostList.CellDoubleClick
        'Me.Dock = DockStyle.Fill
        BtnCloseActions.Visible = True
        Dim que As String = "select * from actions where material_name = '" & DGVCostList.CurrentRow.Cells(0).Value & "'"
        FillList(que)
        DGVActions.DataSource = MyTab
        For i = 0 To DGVActions.RowCount - 1
            If DGVActions.Rows(i).Cells(13).Value = 0 Then
                DGVActions.Rows(i).DefaultCellStyle.BackColor = Color.LightPink
            End If
        Next
        DGVActions.ClearSelection()
    End Sub

    Private Sub BtnCloseActions_Click(sender As Object, e As EventArgs) Handles BtnCloseActions.Click
        'Me.Dock = DockStyle.Left
        BtnCloseActions.Visible = False
        DGVActions.DataSource = Nothing
        DGVActions.Rows.Clear()
        DGVActions.Columns.Clear()
    End Sub

    Private Sub BtnExportToExcel_Click(sender As Object, e As EventArgs) Handles BtnExportToExcel.Click
        If DGVCostList.Rows.Count = 0 Then
            MsgBox("القائمة فارغة", vbOKOnly + vbCritical, "خطأ")
            Return
        End If
        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        Try
            worksheet = workbook.ActiveSheet
            worksheet.Name = "حساب التكاليف"
            worksheet.Cells(1, 1) = DGVCostList.Columns(0).HeaderText
            worksheet.Cells(1, 2) = DGVCostList.Columns(1).HeaderText
            worksheet.Cells(1, 3) = DGVCostList.Columns(2).HeaderText
            worksheet.Cells(1, 4) = DGVCostList.Columns(3).HeaderText
            worksheet.Cells(1, 5) = DGVCostList.Columns(4).HeaderText
            worksheet.Cells(1, 6) = DGVCostList.Columns(5).HeaderText
            worksheet.Cells(1, 7) = DGVCostList.Columns(6).HeaderText

            For i = 0 To DGVCostList.Rows.Count - 1
                For b = 0 To DGVCostList.Columns.Count - 1
                    worksheet.Cells(i + 2, b + 1) = DGVCostList.Rows(i).Cells(b).Value
                Next
            Next
            Dim SaveDialog As New SaveFileDialog()
            SaveDialog.Filter = "Excel Files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveDialog.FilterIndex = 2

            If SaveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(SaveDialog.FileName)
                MsgBox("تم حفظ الملف بنجاح", vbOKOnly + vbInformation, "استعلام")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try
    End Sub
End Class