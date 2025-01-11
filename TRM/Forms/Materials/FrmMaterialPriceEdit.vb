Public Class FrmMaterialPriceEdit
    'Dim MainPrice As Double '= FmMaterialAddEdit.DGVMaterialPrice.CurrentRow.Cells(5).Value
    'Dim MainDiscount As Double ' = NumDiscount.Value

    Private Sub FrmMaterialPriceEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'NumPrice.Value = FmMaterialAddEdit.DGVMaterialPrice.CurrentRow.Cells(5).Value
        'NumDiscount.Value = FmMaterialAddEdit.DGVMaterialPrice.CurrentRow.Cells(6).Value
    End Sub

    Private Sub NumDiscount_ValueChanged(sender As Object, e As EventArgs) Handles NumDiscount.ValueChanged
        'MainPrice = NumMainPrice.Value
        'MainDiscount = NumDiscount.Value
        NumPrice.Value = NumMainPrice.Value - (NumMainPrice.Value * NumDiscount.Value / 100)
    End Sub

    Private Sub NumMainPrice_ValueChanged(sender As Object, e As EventArgs) Handles NumMainPrice.ValueChanged
        NumPrice.Value = NumMainPrice.Value - (NumMainPrice.Value * NumDiscount.Value / 100)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        EditMaterialPrice(FmMaterialAddEdit.DGVMaterialPrice.CurrentRow.Cells(2).Value, NumPrice.Value, NumMainPrice.Value, NumDiscount.Value)
        Me.Close()
        Dim que As String = "select * from material_prices where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value & " order by price_year"
        FillList(que)
        FmMaterialAddEdit.DGVMaterialPrice.DataSource = MyTab
        FmMaterialAddEdit.DGVMaterialPrice.ClearSelection()
    End Sub
End Class