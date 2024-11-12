Public Class FrmMaterials
    Public Sub FrmMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMaterials()
        'For i = 0 To FmMaterials.DgvMaterials.RowCount - 1
        '    If FmMaterials.DgvMaterials.Rows(i).Cells(4).Value < 0 Then
        '        FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.Pink
        '        MsgBox(FmMaterials.DgvMaterials.Rows(i).Cells(4).Value)
        '    Else
        '        FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.Pink
        '    End If
        'Next

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAddMaterial_Click(sender As Object, e As EventArgs) Handles BtnAddMaterial.Click
        isAddMaterial = True
        Dim FmMaterialAddEdit = New FrmMaterialAddEdit
        FmMaterialAddEdit.ShowDialog()
    End Sub

    Private Sub BtnExcelLoad_Click(sender As Object, e As EventArgs) Handles BtnExcelLoad.Click

        Dim FmMaterialsImportExcel = New FrmMaterialsImportExcel
        MaterialsDataImport(FmMaterialsImportExcel.DgvMaterials)
        Dim AddCol As New DataGridViewCheckBoxColumn
        AddCol.Name = "select"
        FmMaterialsImportExcel.DgvMaterials.Columns.Add(AddCol)
        Dim ColNum As Integer = FmMaterialsImportExcel.DgvMaterials.ColumnCount - 1
        FmMaterialsImportExcel.DgvMaterials.Columns(ColNum).Width = 50
        FmMaterialsImportExcel.DgvMaterials.Columns(ColNum).DisplayIndex = 0
        FmMaterialsImportExcel.ShowDialog()
    End Sub

    Private Sub BtnDeleteMaterial_Click(sender As Object, e As EventArgs) Handles BtnDeleteMaterial.Click
        If FmMaterials.TabMaterials.SelectedIndex = 0 Then
            If DgvMaterials.RowCount = 0 Then
                MsgBox("القائمة فارغة", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "رسالة")
                Return
            Else

                '***deactive Material
                Dim DelMsg As DialogResult
                DelMsg = MsgBox("هل تريد حذف المادة فعلا", vbYesNo + vbQuestion, "حذف")
                If DelMsg = 6 Then
                    DeleteMaterial(DgvMaterials.CurrentRow.Cells(0).Value)
                    Me.FrmMaterials_Load(Me, e)
                End If

            End If
        Else
            If DGVMaterialsOff.RowCount = 0 Then
                MsgBox("القائمة فارغة", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "رسالة")
                Return
            Else
                '****active material
                Dim DelMsg As DialogResult
                DelMsg = MsgBox("هل تريد استرجاع المادة فعلا", vbYesNo + vbQuestion, "استرجاع")
                If DelMsg = 6 Then
                    ReActiveMaterial(DGVMaterialsOff.CurrentRow.Cells(0).Value)
                    Me.FrmMaterials_Load(Me, e)
                End If
            End If
        End If
    End Sub

    Private Sub DgvMaterials_KeyDown(sender As Object, e As KeyEventArgs) Handles TabMaterials.KeyDown, DgvMaterials.KeyDown, BtnUpdateMaterial.KeyDown, BtnExcelLoad.KeyDown, BtnDeleteMaterial.KeyDown, BtnClose.KeyDown, BtnAddMaterial.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TabMaterials_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabMaterials.SelectedIndexChanged
        If FmMaterials.TabMaterials.SelectedIndex = 0 Then
            FmMaterials.BtnDeleteMaterial.Image = My.Resources.delete48
            FmMaterials.BtnDeleteMaterial.Text = "حذف"

        Else
            FmMaterials.BtnDeleteMaterial.Image = My.Resources.revert48
            FmMaterials.BtnDeleteMaterial.Text = "استرجاع"

        End If
    End Sub

    Private Sub BtnUpdateMaterial_Click(sender As Object, e As EventArgs) Handles BtnUpdateMaterial.Click
        isAddMaterial = False
        Dim FmMaterialAddEdit = New FrmMaterialAddEdit
        FmMaterialAddEdit.ShowDialog()
    End Sub

    Private Sub DgvMaterials_DoubleClick(sender As Object, e As EventArgs) Handles DgvMaterials.DoubleClick
        'DgvMaterials.CurrentRow.DefaultCellStyle.BackColor = Color.Pink
        isAddMaterial = False
        Dim FmMaterialAddEdit = New FrmMaterialAddEdit
        FmMaterialAddEdit.ShowDialog()
    End Sub

    Private Sub FrmMaterials_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadMaterials()
    End Sub
End Class