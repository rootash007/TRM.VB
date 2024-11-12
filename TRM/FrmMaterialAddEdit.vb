Public Class FrmMaterialAddEdit
    Dim Swicher As Boolean
    Private Sub FrmMaterialAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnits()
        Me.CmbUnits.DataSource = MyTab
        Me.CmbUnits.DisplayMember = "unit_name"
        Me.CmbUnits.ValueMember = "id"
        If isAddMaterial = True Then
            CmbUnits.SelectedIndex = -1
            BtnMaterialAE.Text = "اضافة مادة"
            Me.Text = "اضافة مادة"
        Else
            TxtMaterialName.Text = FmMaterials.DgvMaterials.CurrentRow.Cells(1).Value
            Txtbarcode.Text = FmMaterials.DgvMaterials.CurrentRow.Cells(2).Value
            TxtLocBarcode.Text = FmMaterials.DgvMaterials.CurrentRow.Cells(3).Value
            NumQuantity.Value = FmMaterials.DgvMaterials.CurrentRow.Cells(4).Value
            NumMinQuantity.Value = FmMaterials.DgvMaterials.CurrentRow.Cells(5).Value
            CmbUnits.Text = FmMaterials.DgvMaterials.CurrentRow.Cells(6).Value
            NumWeigth.Value = FmMaterials.DgvMaterials.CurrentRow.Cells(7).Value
            If FmMaterials.DgvMaterials.CurrentRow.Cells(8).Value = True Then
                IsActive.Image = My.Resources.swon1
                isActiveMaterial = True
            Else
                IsActive.Image = My.Resources.swoff1
                isActiveMaterial = False
            End If
            BtnMaterialAE.Text = "تعديل مادة"
            Me.Text = "تعديل مادة"

        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtMaterialName_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtbarcode.KeyDown, TxtMaterialName.KeyDown, TxtLocBarcode.KeyDown, NumWeigth.KeyDown, NumQuantity.KeyDown, NumMinQuantity.KeyDown, CmbUnits.KeyDown, BtnMaterialAE.KeyDown, BtnClose.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub IsActive_Click(sender As Object, e As EventArgs) Handles IsActive.Click
        If isActiveMaterial = True Then
            IsActive.Image = My.Resources.swoff1
            isActiveMaterial = False

        Else
            IsActive.Image = My.Resources.swon1
            isActiveMaterial = True
        End If
    End Sub

    Private Sub BtnMaterialAE_Click(sender As Object, e As EventArgs) Handles BtnMaterialAE.Click
        If TxtMaterialName.Text = "" Then
            MsgBox("الرجاء ادخال اسم المادة", vbOKOnly + vbInformation, "استعلام")
            Return
        ElseIf TxtLocBarcode.Text = "" Then
            MsgBox("الرجاء ادخال رمز المادة المحلي", vbOKOnly + vbInformation, "استعلام")
            Return
        End If
        If isAddMaterial = True Then
            AddMaterial(TxtMaterialName.Text, TxtLocBarcode.Text, Txtbarcode.Text, NumQuantity.Value, NumMinQuantity.Value, CmbUnits.Text, NumWeigth.Value)
        Else
            EditMaterial(TxtMaterialName.Text, TxtLocBarcode.Text, Txtbarcode.Text, NumQuantity.Value, NumMinQuantity.Value, CmbUnits.Text, NumWeigth.Value, isActiveMaterial, FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value)
        End If
        LoadMaterials()
        Me.Close()
    End Sub
End Class