Public Class FrmMaterialAddEdit
    Dim Swicher As Boolean
    Private Sub FrmMaterialAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnits()
        NumYear.Value = Today.Year
        Me.CmbUnits.DataSource = MyTab
        Me.CmbUnits.DisplayMember = "unit_name"
        Me.CmbUnits.ValueMember = "id"
        If isAddMaterial = True Then
            CmbUnits.SelectedIndex = -1
            BtnMaterialAE.Text = "اضافة مادة"
            Me.Text = "اضافة مادة"
            IsActive.Visible = False
            'DGVMaterialTypes = New DataGridView
            MaterialTypesDGVDesign(DGVMaterialTypes)
            TabMaterialEA.TabPages.Remove(TabTypes)
            TabMaterialEA.TabPages.Remove(TabPrices)

            'DGVMaterialTypes.
        Else
            If FmMaterials.TabMaterials.SelectedIndex = 0 Then
                IsActive.Visible = True
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
                '///Material Types
                Dim que As String = "select * from material_types where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
                FillList(que)
                DGVMaterialTypes.DataSource = MyTab
                MaterialTypesDGVDesign(DGVMaterialTypes)
                '///Material Prices if have price permission
                If isAllowed(10) = True Or ActiveLvl = 0 Then
                    que = "select * from material_prices where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value & " order by price_year"
                    FillList(que)
                    DGVMaterialPrice.DataSource = MyTab
                    MaterialPricesDGVDesign(DGVMaterialPrice)
                Else
                    TabMaterialEA.TabPages.Remove(TabPrices)
                End If



            ElseIf FmMaterials.TabMaterials.SelectedIndex = 1 Then
                IsActive.Visible = True
                TxtMaterialName.Text = FmMaterials.DGVMaterialsOff.CurrentRow.Cells(1).Value
                Txtbarcode.Text = FmMaterials.DGVMaterialsOff.CurrentRow.Cells(2).Value
                TxtLocBarcode.Text = FmMaterials.DGVMaterialsOff.CurrentRow.Cells(3).Value
                NumQuantity.Value = FmMaterials.DGVMaterialsOff.CurrentRow.Cells(4).Value
                NumMinQuantity.Value = FmMaterials.DGVMaterialsOff.CurrentRow.Cells(5).Value
                CmbUnits.Text = FmMaterials.DGVMaterialsOff.CurrentRow.Cells(6).Value
                NumWeigth.Value = FmMaterials.DGVMaterialsOff.CurrentRow.Cells(7).Value
                If FmMaterials.DGVMaterialsOff.CurrentRow.Cells(8).Value = True Then
                    IsActive.Image = My.Resources.swon1
                    isActiveMaterial = True
                Else
                    IsActive.Image = My.Resources.swoff1
                    isActiveMaterial = False
                End If
                BtnMaterialAE.Text = "تعديل مادة"
                Me.Text = "تعديل مادة"
                Dim que As String = "select * from material_types where material_id = " & FmMaterials.DGVMaterialsOff.CurrentRow.Cells(0).Value
                FillList(que)
                DGVMaterialTypes.DataSource = MyTab
                MaterialTypesDGVDesign(DGVMaterialTypes)
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If FmMaterials.TabMaterials.SelectedIndex = 0 Then
            inUSEMaterial(FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value, 0)
        Else
            inUSEMaterial(FmMaterials.DGVMaterialsOff.CurrentRow.Cells(0).Value, 0)
        End If
        Me.Close()
    End Sub

    Private Sub TxtMaterialName_KeyDown(sender As Object, e As KeyEventArgs)

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
        Dim que As String = "select * from materials"
        FillList(que)

        If isAddMaterial = True Then
            For i = 0 To MyTab.Rows.Count - 1
                If TxtMaterialName.Text = MyTab.Rows(i).Item(1) Then
                    'MsgBox("material name found please choose another material name", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "name found")
                    MsgBox("اسم المادة موجود في النظام , الرجاء اختيار اسم اخر", vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "خطأ")

                    Return
                ElseIf TxtLocBarcode.Text = MyTab.Rows(i).Item(2) Then
                    MsgBox("رمز المادة موجود في النظام , الرجاء اختيار رمز اخر", vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "خطأ")
                    Return
                End If
            Next
            AddMaterial(TxtMaterialName.Text, TxtLocBarcode.Text, Txtbarcode.Text, NumQuantity.Value, NumMinQuantity.Value, CmbUnits.Text, NumWeigth.Value)
        Else
            If FmMaterials.TabMaterials.SelectedIndex = 0 Then
                For i = 0 To MyTab.Rows.Count - 1
                    If TxtMaterialName.Text = MyTab.Rows(i).Item(1) And FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value <> MyTab.Rows(i).Item(0) Then
                        MsgBox("اسم المادة موجود في النظام , الرجاء اختيار اسم اخر", vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "خطأ")
                        Return
                    ElseIf TxtLocBarcode.Text = MyTab.Rows(i).Item(2) And FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value <> MyTab.Rows(i).Item(0) Then
                        MsgBox("رمز المادة موجود في النظام , الرجاء اختيار رمز اخر", vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "خطأ")
                        Return
                    End If
                Next
                EditMaterial(TxtMaterialName.Text, TxtLocBarcode.Text, Txtbarcode.Text, NumQuantity.Value, NumMinQuantity.Value, CmbUnits.Text, NumWeigth.Value, isActiveMaterial, FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value)
            ElseIf FmMaterials.TabMaterials.SelectedIndex = 1 Then
                For i = 0 To MyTab.Rows.Count - 1
                    If TxtMaterialName.Text = MyTab.Rows(i).Item(1) And FmMaterials.DGVMaterialsOff.CurrentRow.Cells(0).Value <> MyTab.Rows(i).Item(0) Then
                        MsgBox("اسم المادة موجود في النظام , الرجاء اختيار اسم اخر", vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "خطأ")
                        Return
                    ElseIf TxtLocBarcode.Text = MyTab.Rows(i).Item(2) And FmMaterials.DGVMaterialsOff.CurrentRow.Cells(0).Value <> MyTab.Rows(i).Item(0) Then
                        MsgBox("رمز المادة موجود في النظام , الرجاء اختيار رمز اخر", vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "خطأ")
                        Return
                    End If
                Next
                EditMaterial(TxtMaterialName.Text, TxtLocBarcode.Text, Txtbarcode.Text, NumQuantity.Value, NumMinQuantity.Value, CmbUnits.Text, NumWeigth.Value, isActiveMaterial, FmMaterials.DGVMaterialsOff.CurrentRow.Cells(0).Value)

            End If

        End If
        LoadMaterials()
        Me.Close()
    End Sub

    Private Sub NumQuantity_Enter(sender As Object, e As EventArgs) Handles NumQuantity.Enter
        NumQuantity.Select(0, NumQuantity.Text.Length)
    End Sub

    Private Sub NumMinQuantity_Enter(sender As Object, e As EventArgs) Handles NumMinQuantity.Enter
        NumMinQuantity.Select(0, NumMinQuantity.Text.Length)

    End Sub

    Private Sub NumWeigth_Enter(sender As Object, e As EventArgs) Handles NumWeigth.Enter
        NumWeigth.Select(0, NumWeigth.Text.Length)
    End Sub

    Private Sub NumTypeQuantity_Enter(sender As Object, e As EventArgs) Handles NumTypeQuantity.Enter
        NumTypeQuantity.Select(0, NumTypeQuantity.Text.Length)
    End Sub

    Private Sub BtnAddType_Click(sender As Object, e As EventArgs) Handles BtnAddType.Click
        If TxtTypeName.Text <> "" Then
            'DGVMaterialTypes.Rows.Add()
            'DGVMaterialTypes.Rows(DGVMaterialTypes.Rows.Count - 1).Cells(2).Value = TxtTypeName.Text
            'DGVMaterialTypes.Rows(DGVMaterialTypes.Rows.Count - 1).Cells(3).Value = NumTypeQuantity.Value
            Dim isFound As Boolean = False
            If DGVMaterialTypes.RowCount > 0 Then
                For i = 0 To DGVMaterialTypes.RowCount - 1
                    If TxtTypeName.Text = DGVMaterialTypes.Rows(i).Cells(2).Value Then
                        isFound = True
                    End If
                Next
                If isFound = True Then
                    MsgBox("isfound")
                Else
                    'MsgBox("not found")
                    '//add material type
                    '// reload list
                    AddMaterialType(TxtTypeName.Text, NumTypeQuantity.Value, FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value)
                    Dim que As String = "select * from material_types where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
                    FillList(que)
                    DGVMaterialTypes.DataSource = MyTab
                    MaterialTypesDGVDesign(DGVMaterialTypes)
                End If
            Else
                '//add material type
                '//reload list
                AddMaterialType(TxtTypeName.Text, NumTypeQuantity.Value, FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value)
                Dim que As String = "select * from material_types where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
                FillList(que)
                DGVMaterialTypes.DataSource = MyTab
                MaterialTypesDGVDesign(DGVMaterialTypes)
            End If

            'Dim que As String = "select * from material_types where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
            'FillList(que)
            'DGVMaterialTypes.DataSource = MyTab
            'MaterialTypesDGVDesign(DGVMaterialTypes)
        Else
            MsgBox("لم يتم ادخال اسم لنوع المادة", vbOKOnly + vbCritical, "خطأ")
        End If
    End Sub

    Private Sub FrmMaterialAddEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If FmMaterials.TabMaterials.SelectedIndex = 0 Then
            inUSEMaterial(FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value, 0)
        Else
            inUSEMaterial(FmMaterials.DGVMaterialsOff.CurrentRow.Cells(0).Value, 0)
        End If
    End Sub

    Private Sub BtnAddPrice_Click(sender As Object, e As EventArgs) Handles BtnAddPrice.Click
        'MaterialPriceTab.Rows.Add()
        'MaterialPriceTab.Rows(MaterialPriceTab.Rows.Count - 1).Item(2) = "2024"
        'MaterialPriceTab.Rows(MaterialPriceTab.Rows.Count - 1).Item(3) = 1.25
        Try
            Dim isFound As Boolean = False
            For i = 0 To DGVMaterialPrice.RowCount - 1
                If DGVMaterialPrice.Rows(i).Cells(4).Value = NumYear.Value Then
                    isFound = True
                End If
            Next
            If isFound = False Then
                If NumPrice.Value = 0 Then
                    MsgBox("الرجاء ادخال السعر", vbOKOnly + vbInformation, "استعلام")
                    Return
                End If
                AddMaterialPrice(FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value, NumYear.Value, NumPrice.Value)
                Dim que As String = "select * from material_prices where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value & " order by price_year"
                FillList(que)
                DGVMaterialPrice.DataSource = MyTab
                DGVMaterialPrice.ClearSelection()
            Else
                MsgBox("لا يمكن التكرار لنفس السنه , الرجاء اختيار سنه اخرى", vbOKOnly + vbCritical, "خطأ")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVMaterialPrice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMaterialPrice.CellContentClick
        Try
            If DGVMaterialPrice.Columns(e.ColumnIndex).HeaderText = "حذف" Then
                Dim SaveMSG As DialogResult
                SaveMSG = MsgBox("هل تريد فعلا حذف سعر السنة " & DGVMaterialPrice.CurrentRow.Cells(3).Value & " ? ", vbMsgBoxRtlReading + vbYesNo + vbQuestion, "حذف")
                If SaveMSG = 6 Then
                    'MsgBox(DGVMaterialPrice.CurrentRow.Cells(2).Value)
                    DeleteMaterialPrice(DGVMaterialPrice.CurrentRow.Cells(2).Value)
                    Dim que As String = "select * from material_prices where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value & " order by price_year"
                    FillList(que)
                    DGVMaterialPrice.DataSource = MyTab
                    DGVMaterialPrice.ClearSelection()
                End If
            ElseIf DGVMaterialPrice.Columns(e.ColumnIndex).HeaderText = "تعديل" Then
                'MsgBox("test")
                'FrmMaterialPriceEdit.Show()
                Dim FmMaterialPriceEdit As New FrmMaterialPriceEdit
                'MsgBox(DGVMaterialPrice.CurrentRow.Cells(5).Value)
                'MsgBox(DGVMaterialPrice.CurrentRow.Cells(6).Value)
                'MsgBox(DGVMaterialPrice.CurrentRow.Cells(7).Value)

                FmMaterialPriceEdit.NumMainPrice.Value = DGVMaterialPrice.CurrentRow.Cells(5).Value
                FmMaterialPriceEdit.NumDiscount.Value = DGVMaterialPrice.CurrentRow.Cells(6).Value
                FmMaterialPriceEdit.NumPrice.Value = DGVMaterialPrice.CurrentRow.Cells(7).Value
                FmMaterialPriceEdit.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtMaterialName_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TxtMaterialName.KeyDown, TxtLocBarcode.KeyDown, Txtbarcode.KeyDown, TabMaterialEA.KeyDown, NumWeigth.KeyDown, NumQuantity.KeyDown, NumMinQuantity.KeyDown, CmbUnits.KeyDown, BtnMaterialAE.KeyDown, BtnClose.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnMaterialAE.PerformClick()
        End If
    End Sub
End Class