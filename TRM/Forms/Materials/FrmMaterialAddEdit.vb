Imports System.Data.SqlClient

Public Class FrmMaterialAddEdit
    Dim Swicher As Boolean
    Dim isLocked As Boolean = True
    Dim CurrentName As String
    Dim CurrentLocBarcode As String
    Private Sub FrmMaterialAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnits()
        FrmMaterialAddEditLang(AppLanguage)

        NumYear.Value = Today.Year
        Me.CmbUnits.DataSource = MyTab
        Me.CmbUnits.DisplayMember = "unit_name"
        Me.CmbUnits.ValueMember = "id"
        If isAddMaterial = True Then
            CmbUnits.SelectedIndex = -1
            IsActive.Visible = False
            MaterialTypesDGVDesign(DGVMaterialTypes)
            TabMaterialEA.TabPages.Remove(TabTypes)
            TabMaterialEA.TabPages.Remove(TabPrices)
        Else
            IsActive.Visible = True
            TxtMaterialName.Text = SelectedMaterialTab.Rows(0).Item(1)
            CurrentName = SelectedMaterialTab.Rows(0).Item(1).ToString.ToLower
            Txtbarcode.Text = SelectedMaterialTab.Rows(0).Item(2)
            TxtLocBarcode.Text = SelectedMaterialTab.Rows(0).Item(3)
            CurrentLocBarcode = SelectedMaterialTab.Rows(0).Item(3).ToString.ToLower
            NumQuantity.Value = SelectedMaterialTab.Rows(0).Item(4)
            NumMinQuantity.Value = SelectedMaterialTab.Rows(0).Item(5)
            CmbUnits.Text = SelectedMaterialTab.Rows(0).Item(6)
            NumWeigth.Value = SelectedMaterialTab.Rows(0).Item(7)
            If SelectedMaterialTab.Rows(0).Item(8) = True Then
                IsActive.Image = My.Resources.swon1
                isActiveMaterial = True
            Else
                IsActive.Image = My.Resources.swoff1
                isActiveMaterial = False
            End If
            NumBlockCapacity.Value = SelectedMaterialTab.Rows(0).Item(10)
            If SelectedMaterialTab.Rows(0).Item(4) > 0 And SelectedMaterialTab.Rows(0).Item(10) > 0 Then
                NumBlockQuantity.Value = SelectedMaterialTab.Rows(0).Item(4) / SelectedMaterialTab.Rows(0).Item(10)
            Else
                NumBlockQuantity.Value = 0
            End If

            PBoxQuantityLocker.Image = My.Resources.locked48

            If My.Settings.MaterialQuantityLock = True Then
                NumQuantity.Enabled = False
                PBoxQuantityLocker.Visible = True
            Else
                NumQuantity.Enabled = True
                PBoxQuantityLocker.Visible = False
            End If

            Dim que As String = "select * from material_types where material_id = " & SelectedMaterialID
            FillList(que)
            DGVMaterialTypes.DataSource = MyTab
            MaterialTypesDGVDesign(DGVMaterialTypes)
            '///Material Prices if have price permission
            If isAllowed(10) = True Or ActiveLvl = 0 Then
                que = "select * from material_prices where material_id = " & SelectedMaterialID & " order by price_year"
                FillList(que)
                DGVMaterialPrice.DataSource = MyTab
                MaterialPricesDGVDesign(DGVMaterialPrice)
            Else
                TabMaterialEA.TabPages.Remove(TabPrices)
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim UpdateParams As New Dictionary(Of String, Object) From {
                      {"material_inuse", 0}
                      }
        Dim conditionField As String = "id"
        Dim conditionValue As Object = SelectedMaterialID ''//FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
        UpdateData("materials", UpdateParams, conditionField, conditionValue)
        Me.Close()
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

    '********************

    Private Sub BtnMaterialAE_Click(sender As Object, e As EventArgs) Handles BtnMaterialAE.Click
        ' Validate inputs
        If Not ValidateInputs() Then Return

        If isAddMaterial Then
            HandleAddMaterial()
        Else
            HandleUpdateMaterial()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(TxtMaterialName.Text) Then
            ShowMessage("الرجاء ادخال اسم المادة", "נא להכניס שם חומר", "استعلام", "הודעה")
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtLocBarcode.Text) Then
            ShowMessage("الرجاء ادخال رمز المادة المحلي", "נא להכניס קוד חומר מקומי", "استعلام", "הודעה")
            Return False
        End If

        Return True
    End Function

    Private Sub HandleAddMaterial()
        ' Check if material name exists
        If MaterialExists("material_name", TxtMaterialName.Text) Then
            ShowMessage("اسم المادة موجود في النظام , الرجاء اختيار اسم اخر",
                   "שם חומר קיים , נא לבחור שם חומר אחר", "خطأ", "תקלה")
            Return
        End If

        ' Check if barcode exists
        If MaterialExists("material_loc_barcode", TxtLocBarcode.Text) Then
            ShowMessage("رمز المادة موجود في النظام , الرجاء اختيار رمز اخر",
                   "קוד חומר מקומי קיים , נא לבחור קוד חומר אחר", "خطأ", "תקלה")
            Return
        End If

        ' Insert new material
        InsertMaterial()
        Me.Close()
        LoadMaterials()
    End Sub

    Private Sub HandleUpdateMaterial()
        Dim nameChanged = Not String.Equals(CurrentName, TxtMaterialName.Text, StringComparison.OrdinalIgnoreCase)
        Dim barcodeChanged = Not String.Equals(CurrentLocBarcode, TxtLocBarcode.Text, StringComparison.OrdinalIgnoreCase)

        ' Check for conflicts
        If nameChanged AndAlso MaterialExists("material_name", TxtMaterialName.Text, SelectedMaterialID) Then
            ShowMessage("اسم المادة موجود في النظام , الرجاء اختيار اسم اخر",
                   "שם חומר קיים , נא לבחור שם חומר אחר", "خطأ", "תקלה")
            Return
        End If

        If barcodeChanged AndAlso MaterialExists("material_loc_barcode", TxtLocBarcode.Text, SelectedMaterialID) Then
            ShowMessage("رمز المادة موجود في النظام , الرجاء اختيار رمز اخر",
                   "קוד חומר מקומי קיים , נא לבחור קוד חומר אחר", "خطأ", "תקלה")
            Return
        End If

        ' Update material
        UpdateMaterial()
        Me.Close()
        LoadMaterials()
    End Sub

    Private Function MaterialExists(fieldName As String, fieldValue As String, Optional excludeId As Integer = -1) As Boolean

        Dim query As String = $"SELECT COUNT(1) FROM materials WHERE {fieldName} = @value"

        If excludeId > 0 Then
            query += " AND id <> @excludeId"
        End If

        Dim cmd As New SqlCommand
        Dim Counter As Integer = 0
        With cmd
            .CommandType = CommandType.Text
            .CommandText = query
            .Connection = dbcon
        End With
        cmd.Parameters.AddWithValue("@value", fieldValue)

        If excludeId > 0 Then
            cmd.Parameters.AddWithValue("@excludeId", excludeId)
        End If

        Try
            dbcon.Open()
            Counter = cmd.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
        If Counter > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub InsertMaterial()
        Dim insertParams As New Dictionary(Of String, Object) From {
        {"material_name", TxtMaterialName.Text},
        {"material_loc_barcode", TxtLocBarcode.Text},
        {"material_barcode", Txtbarcode.Text},
        {"material_quantity", NumQuantity.Value},
        {"material_min_quantity", NumMinQuantity.Value},
        {"material_unit", CmbUnits.Text},
        {"material_weigth", NumWeigth.Value},
        {"block_capacity", NumBlockCapacity.Value},
        {"block_quantity", NumBlockQuantity.Value}
    }

        InsertData("materials", insertParams)
        'ShowMessage("تم اضافة المادة بنجاح", "חומר נוסף בהצלחה", "نجاح", "הצלחה")
    End Sub

    Private Sub UpdateMaterial()
        Dim updateParams As New Dictionary(Of String, Object) From {
        {"material_name", TxtMaterialName.Text},
        {"material_loc_barcode", TxtLocBarcode.Text},
        {"material_barcode", Txtbarcode.Text},
        {"material_quantity", NumQuantity.Value},
        {"material_min_quantity", NumMinQuantity.Value},
        {"material_unit", CmbUnits.Text},
        {"material_weigth", NumWeigth.Value},
        {"material_isactive", isActiveMaterial},
        {"material_inuse", 0},
        {"block_capacity", NumBlockCapacity.Value},
        {"block_quantity", NumBlockQuantity.Value}
    }

        UpdateData("materials", updateParams, "id", SelectedMaterialID)
        'ShowMessage("تم تحديث المادة بنجاح", "חומר עודכן בהצלחה", "نجاح", "הצלחה")
    End Sub

    Private Sub ShowMessage(arabicText As String, hebrewText As String, arabicTitle As String, hebrewTitle As String)
        If AppLanguage = "AR" Then
            MsgBox(arabicText, vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Information, arabicTitle)
        ElseIf AppLanguage = "HE" Then
            MsgBox(hebrewText, vbMsgBoxRtlReading + MsgBoxStyle.OkOnly + MsgBoxStyle.Information, hebrewTitle)
        End If
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
                    If AppLanguage = "AR" Then
                        MsgBox("نوع الماده متوفر موجود", vbOKOnly + vbCritical, "خطأ")
                    ElseIf AppLanguage = "HE" Then
                        MsgBox("סוג חומר קיים", vbOKOnly + vbCritical, "תקלה")
                    End If
                Else
                    'MsgBox("not found")
                    '//add material type
                    '// reload list
                    Dim InsertParams As New Dictionary(Of String, Object) From {
                       {"type_name", TxtTypeName.Text},
                       {"type_quantity", NumTypeQuantity.Value},
                       {"material_id", SelectedMaterialID}
                       }
                    InsertData("material_types", InsertParams)

                    'AddMaterialType(TxtTypeName.Text, NumTypeQuantity.Value, FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value)
                    Dim que As String = "select * from material_types where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
                    FillList(que)
                    DGVMaterialTypes.DataSource = MyTab
                    MaterialTypesDGVDesign(DGVMaterialTypes)
                End If
            Else
                '//add material type
                '//reload list
                Dim InsertParams As New Dictionary(Of String, Object) From {
                       {"type_name", TxtTypeName.Text},
                       {"type_quantity", NumTypeQuantity.Value},
                       {"material_id", SelectedMaterialID}
                       }
                InsertData("material_types", InsertParams)

                'AddMaterialType(TxtTypeName.Text, NumTypeQuantity.Value, FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value)
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
            If AppLanguage = "AR" Then
                MsgBox("لم يتم ادخال اسم لنوع المادة", vbOKOnly + vbCritical, "خطأ")
            ElseIf AppLanguage = "HE" Then
                MsgBox("לא נבחר שם סוג חומר", vbOKOnly + vbCritical, "תקלה")
            End If
        End If
    End Sub

    Private Sub FrmMaterialAddEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim UpdateParams As New Dictionary(Of String, Object) From {
                      {"material_inuse", 0}
                      }
        Dim conditionField As String = "id"
        Dim conditionValue As Object = SelectedMaterialID ''//FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
        UpdateData("materials", UpdateParams, conditionField, conditionValue)

        'If FmMaterials.TabMaterials.SelectedIndex = 0 Then
        '    inUSEMaterial(FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value, 0)
        'Else
        '    inUSEMaterial(FmMaterials.DGVMaterialsOff.CurrentRow.Cells(0).Value, 0)
        'End If
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
                    If AppLanguage = "AR" Then
                        MsgBox("الرجاء ادخال السعر", vbOKOnly + vbInformation, "استعلام")
                    ElseIf AppLanguage = "HE" Then
                        MsgBox("נא להכניס מחיר", vbOKOnly + vbInformation, "הודעה")
                    End If
                    Return
                End If
                Dim InsertParams As New Dictionary(Of String, Object) From {
                       {"material_id", SelectedMaterialID},
                       {"price_year", NumYear.Value},
                       {"material_main_price", NumPrice.Value}
                       }
                InsertData("material_prices", InsertParams)

                'AddMaterialPrice(FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value, NumYear.Value, NumPrice.Value)
                Dim que As String = "select * from material_prices where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value & " order by price_year"
                FillList(que)
                DGVMaterialPrice.DataSource = MyTab
                DGVMaterialPrice.ClearSelection()
            Else
                If AppLanguage = "AR" Then
                    MsgBox("لا يمكن التكرار لنفس السنه , الرجاء اختيار سنه اخرى", vbOKOnly + vbCritical, "خطأ")
                ElseIf AppLanguage = "HE" Then
                    MsgBox("לא ניתן להכניס כפל מחיר לאותה שנה , נא לבחור שנה אחרת", vbOKOnly + vbCritical, "תקלה")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVMaterialPrice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMaterialPrice.CellContentClick
        Try
            If DGVMaterialPrice.Columns(e.ColumnIndex).HeaderText = "حذف" Or DGVMaterialPrice.Columns(e.ColumnIndex).HeaderText = "מחק" Then
                Dim SaveMSG As DialogResult
                If AppLanguage = "AR" Then
                    SaveMSG = MsgBox("هل تريد فعلا حذف سعر السنة " & DGVMaterialPrice.CurrentRow.Cells(3).Value & " ? ", vbMsgBoxRtlReading + vbYesNo + vbQuestion, "حذف")
                ElseIf AppLanguage = "HE" Then
                    SaveMSG = MsgBox("האם אתה בטוח שברצונך למחוק מחיר שנה " & DGVMaterialPrice.CurrentRow.Cells(3).Value & " ? ", vbMsgBoxRtlReading + vbYesNo + vbQuestion, "מחיקה")
                End If
                If SaveMSG = 6 Then
                    'MsgBox(DGVMaterialPrice.CurrentRow.Cells(2).Value)
                    DeleteMaterialPrice(DGVMaterialPrice.CurrentRow.Cells(2).Value)
                    Dim que As String = "select * from material_prices where material_id = " & FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value & " order by price_year"
                    FillList(que)
                    DGVMaterialPrice.DataSource = MyTab
                    DGVMaterialPrice.ClearSelection()
                End If
            ElseIf DGVMaterialPrice.Columns(e.ColumnIndex).HeaderText = "تعديل" Or DGVMaterialPrice.Columns(e.ColumnIndex).HeaderText = "עדכון" Then

                Dim FmMaterialPriceEdit As New FrmMaterialPriceEdit

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

    Private Sub PBoxQuantityLocker_Click(sender As Object, e As EventArgs) Handles PBoxQuantityLocker.Click
        If isLocked = True Then
            'FrmAdminCode = New FrmAdminCode
            FrmAdminCode.ShowDialog()
            If isAdminCode = True Then
                isAdminCode = False
                isLocked = False
                PBoxQuantityLocker.Image = My.Resources.unlocked48
                NumQuantity.Enabled = True
            End If
        Else
            isLocked = True
            PBoxQuantityLocker.Image = My.Resources.locked48
            NumQuantity.Enabled = False

        End If
    End Sub

    Private Sub NumBlockCapacity_ValueChanged(sender As Object, e As EventArgs) Handles NumBlockCapacity.ValueChanged
        If NumQuantity.Value > 0 And NumBlockCapacity.Value > 0 Then
            NumBlockQuantity.Value = NumQuantity.Value / NumBlockCapacity.Value
        End If
    End Sub

    Private Sub NumQuantity_ValueChanged(sender As Object, e As EventArgs) Handles NumQuantity.ValueChanged
        'NumBlockQuantity.Value = NumQuantity.Value / NumBlockCapacity.Value
    End Sub

    Private Sub NumQuantity_Leave(sender As Object, e As EventArgs) Handles NumQuantity.Leave
        If NumQuantity.Value > 0 And NumBlockCapacity.Value > 0 Then
            NumBlockQuantity.Value = NumQuantity.Value / NumBlockCapacity.Value
        End If
    End Sub
End Class