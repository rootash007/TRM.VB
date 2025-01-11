Public Class FrmProductAE
    Dim isAddMaterial As Boolean = False

    Private Sub FrmProductAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            isAddMaterial = False
            CmbMaterialName.Enabled = False
            CmbMaterialBarcode.Enabled = False
            NumQuantity.Enabled = False
            TxtUnit.Enabled = False
            BtnAddToDGV.Enabled = False
            BtnAdd.Image = My.Resources.plus
            Dim que As String = "select * from materials where material_isactive = 1"
            FillList(que)
            MaterialsTab = MyTab
            CmbMaterialName.DataSource = MaterialsTab
            CmbMaterialName.DisplayMember = "material_name"
            CmbMaterialName.ValueMember = "material_loc_barcode"

            CmbMaterialBarcode.DataSource = MyTab
            CmbMaterialBarcode.DisplayMember = "material_loc_barcode"
            CmbMaterialBarcode.ValueMember = "id"
            CmbMaterialName.SelectedIndex = -1
            CmbMaterialBarcode.SelectedIndex = -1
            ProductMaterialsDGVDesign(DGVProductMaterials)

            If isAddProduct = False Then
                If FmProducts.TabProducts.SelectedIndex = 0 Then
                    que = "select * from product_materials where product_id = " & FmProducts.DGVProductsOn.CurrentRow.Cells(0).Value
                    TxtProductName.Text = FmProducts.DGVProductsOn.CurrentRow.Cells(1).Value
                    TxtProdiuctBarcode.Text = FmProducts.DGVProductsOn.CurrentRow.Cells(2).Value
                    NumCans.Value = FmProducts.DGVProductsOn.CurrentRow.Cells(3).Value
                    NumBoxes.Value = FmProducts.DGVProductsOn.CurrentRow.Cells(4).Value
                Else
                    que = "select * from product_materials where product_id = " & FmProducts.DGVProductsOff.CurrentRow.Cells(0).Value
                    TxtProductName.Text = FmProducts.DGVProductsOff.CurrentRow.Cells(1).Value
                    TxtProdiuctBarcode.Text = FmProducts.DGVProductsOff.CurrentRow.Cells(2).Value
                    NumCans.Value = FmProducts.DGVProductsOff.CurrentRow.Cells(3).Value
                    NumBoxes.Value = FmProducts.DGVProductsOff.CurrentRow.Cells(4).Value
                End If
                FillList(que)
                For i = 0 To MyTab.Rows.Count - 1
                    DGVProductMaterials.Rows.Add()
                    For d = 0 To MyTab.Columns.Count - 1
                        DGVProductMaterials.Rows(i).Cells(d).Value = MyTab.Rows(i).Item(d)
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmbMaterialName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterialName.SelectedIndexChanged
        If CmbMaterialName.Text <> "" Then
            CmbMaterialBarcode.Text = CmbMaterialName.SelectedValue.ToString
            Dim que As String = "select * from materials where material_isactive = 1"
            FillList(que)
            For i = 0 To MyTab.Rows.Count - 1
                If CmbMaterialBarcode.Text = MyTab.Rows(i).Item(3) Then
                    TxtUnit.Text = MyTab.Rows(i).Item(6)
                End If
            Next
        Else
            CmbMaterialBarcode.SelectedIndex = -1
            TxtUnit.Text = ""
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
            BtnAddToDGV.Enabled = False
            BtnAdd.Image = My.Resources.plus
        Else
            isAddMaterial = True
            CmbMaterialName.Enabled = True
            CmbMaterialBarcode.Enabled = True
            NumQuantity.Enabled = True
            TxtUnit.Enabled = True
            BtnAddToDGV.Enabled = True
            BtnAdd.Image = My.Resources.Cancel48
        End If
    End Sub

    Private Sub BtnCancel_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUnit.KeyDown, TxtProductName.KeyDown, TxtProdiuctBarcode.KeyDown, NumTotalCans.KeyDown, NumQuantity.KeyDown, NumCans.KeyDown, NumBoxes.KeyDown, MyBase.KeyDown, DGVProductMaterials.KeyDown, CmbMaterialName.KeyDown, CmbMaterialBarcode.KeyDown, BtnSave.KeyDown, BtnAddToDGV.KeyDown, BtnCancel.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnAddToDGV_Click(sender As Object, e As EventArgs) Handles BtnAddToDGV.Click
        If CmbMaterialName.Text = "" Then
            MsgBox("material name cannot be empty")
            Return
        End If
        If CmbMaterialBarcode.Text = "" Then
            MsgBox("material barcode name cannot be empty")
            Return
        End If
        If NumQuantity.Value = 0 Then
            MsgBox("quantity name cannot be empty")
            Return
        End If
        If DGVProductMaterials.RowCount = 0 Then
            DGVProductMaterials.Rows.Add()
            If isAddProduct = True Then
                DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(1).Value = 0
            Else
                If FmProducts.TabProducts.SelectedIndex = 0 Then
                    DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(1).Value = FmProducts.DGVProductsOn.CurrentRow.Cells(0).Value
                Else
                    DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(1).Value = FmProducts.DGVProductsOff.CurrentRow.Cells(0).Value
                End If
            End If
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(2).Value = CmbMaterialBarcode.SelectedValue
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(3).Value = CmbMaterialName.Text
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(4).Value = CmbMaterialBarcode.Text
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(5).Value = NumQuantity.Value
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(6).Value = TxtUnit.Text

            CmbMaterialName.SelectedIndex = -1
            CmbMaterialBarcode.SelectedIndex = -1
            NumQuantity.Value = 0
            TxtUnit.Text = ""
            BtnAdd_Click(Me, e)
        Else
            For i = 0 To DGVProductMaterials.RowCount - 1
                If CmbMaterialBarcode.Text = DGVProductMaterials.Rows(i).Cells(4).Value Then
                    MsgBox("already added , cannot add twice")
                    Return
                End If
            Next
            DGVProductMaterials.Rows.Add()
            If isAddProduct = True Then
                DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(1).Value = 0
            Else
                If FmProducts.TabProducts.SelectedIndex = 0 Then
                    DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(1).Value = FmProducts.DGVProductsOn.CurrentRow.Cells(0).Value
                Else
                    DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(1).Value = FmProducts.DGVProductsOff.CurrentRow.Cells(0).Value
                End If
            End If
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(2).Value = CmbMaterialBarcode.SelectedValue
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(3).Value = CmbMaterialName.Text
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(4).Value = CmbMaterialBarcode.Text
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(5).Value = NumQuantity.Value
            DGVProductMaterials.Rows(DGVProductMaterials.RowCount - 1).Cells(6).Value = TxtUnit.Text

            CmbMaterialName.SelectedIndex = -1
            CmbMaterialBarcode.SelectedIndex = -1
            NumQuantity.Value = 0
            TxtUnit.Text = ""
            BtnAdd_Click(Me, e)
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If isAddProduct = True Then
            '**add product
            If DGVProductMaterials.Rows.Count > 0 Then

                '**add product materials
            End If

        Else
            '**edit product
            If DGVProductMaterials.Rows.Count > 0 Then

                '***check edit or add product materials

            End If


        End If
    End Sub
End Class