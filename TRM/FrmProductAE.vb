Public Class FrmProductAE
    Dim isAddMaterial As Boolean = False

    Private Sub FrmProductAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BtnAdd.Image = My.Resources.Cancel48
        isAddMaterial = False
        CmbMaterialName.Enabled = False
        CmbMaterialBarcode.Enabled = False
        NumQuantity.Enabled = False
        TxtUnit.Enabled = False
        BtnSave.Enabled = False
        BtnAdd.Image = My.Resources.plus

        Dim que As String = "select * from materials where material_isactive = 1"
        FillList(que)
        CmbMaterialName.DataSource = MyTab
        CmbMaterialName.DisplayMember = "material_name"
        CmbMaterialName.ValueMember = "material_loc_barcode"
        CmbMaterialName.SelectedIndex = 0

        CmbMaterialBarcode.DataSource = MyTab
        CmbMaterialBarcode.DisplayMember = "material_loc_barcode"
        CmbMaterialBarcode.ValueMember = "material_name"
        CmbMaterialBarcode.SelectedIndex = -1

    End Sub

    Private Sub CmbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterialName.SelectedIndexChanged
        If CmbMaterialName.Text <> "" Then
            CmbMaterialBarcode.Text = CmbMaterialName.SelectedValue.ToString
        Else
            CmbMaterialBarcode.SelectedIndex = -1
        End If
    End Sub

    Private Sub CmbProductBarcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterialBarcode.SelectedIndexChanged
        If CmbMaterialBarcode.Text <> "" Then
            CmbMaterialName.Text = CmbMaterialBarcode.SelectedValue.ToString
        Else
            CmbMaterialName.SelectedIndex = -1
        End If
    End Sub

    Private Sub NumCans_ValueChanged(sender As Object, e As EventArgs) Handles NumCans.ValueChanged, NumBoxes.ValueChanged
        NumTotalCans.Value = NumCans.Value * NumBoxes.Value
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If isAddMaterial = True Then
            isAddMaterial = False
            CmbMaterialName.Enabled = False
            CmbMaterialBarcode.Enabled = False
            NumQuantity.Enabled = False
            TxtUnit.Enabled = False
            BtnSave.Enabled = False
            BtnAdd.Image = My.Resources.plus
        Else
            isAddMaterial = True
            CmbMaterialName.Enabled = True
            CmbMaterialBarcode.Enabled = True
            NumQuantity.Enabled = True
            TxtUnit.Enabled = True
            BtnSave.Enabled = True
            BtnAdd.Image = My.Resources.Cancel48
        End If
    End Sub

    Private Sub BtnCancel_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUnit.KeyDown, TextBox2.KeyDown, TextBox1.KeyDown, NumTotalCans.KeyDown, NumQuantity.KeyDown, NumCans.KeyDown, NumBoxes.KeyDown, MyBase.KeyDown, DGVProductMaterials.KeyDown, CmbMaterialName.KeyDown, CmbMaterialBarcode.KeyDown, BtnSave11.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class