Module ModDGVDesigns

    Public Sub ProductsDGVDesign(DGV As DataGridView)
        With DGV
            .Columns(0).Visible = False
            .Columns(1).Visible = True
            .Columns(2).Visible = True
            .Columns(3).Visible = True
            .Columns(4).Visible = True
            .Columns(5).Visible = True

            '.Columns(0).HeaderText = "מס"
            .Columns(1).HeaderText = "اسم المادة"
            .Columns(2).HeaderText = "الرمز"
            .Columns(3).HeaderText = "عدد العلب"
            .Columns(4).HeaderText = "عدد الصناديق"
            .Columns(5).HeaderText = "المجموع بالمشتاح"

            '.Columns(0).Width = 55
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).Width = 140
            .Columns(2).Width = 120
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 80

            .DefaultCellStyle.Font = New Font(10, 12)
            .ClearSelection()


        End With
    End Sub

    Public Sub MaterialTypesDGVDesign(DGV As DataGridView)
        With DGV
            If isAddMaterial = True Then
                .ColumnCount = 4
                .Columns(0).Name = "id"
                .Columns(0).Visible = False
                .Columns(0).Width = 60

                .Columns(1).Name = "material id"
                .Columns(1).Width = 100
                .Columns(1).Visible = False

                .Columns(2).Name = "نوع المادة"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Visible = True

                .Columns(3).Name = "الكمية"
                .Columns(3).Width = 80
                .Columns(3).Visible = True
            Else
                .Columns(0).Visible = False

                .Columns(1).Visible = False

                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Visible = True
                .Columns(2).HeaderText = "نوع المادة"

                .Columns(3).Width = 80
                .Columns(3).Visible = True
                .Columns(3).HeaderText = "الكمية"
            End If
            .ClearSelection()
        End With
    End Sub

    Public Sub MaterialPricesDGVDesign(DGV As DataGridView)
        Dim AddCol As New DataGridViewImageColumn
        Dim EditCol As New DataGridViewImageColumn

        AddCol.Name = "حذف"
        AddCol.Image = My.Resources.delete48
        AddCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        AddCol.Width = 40

        EditCol.Name = "تعديل"
        EditCol.Image = My.Resources.edit2
        EditCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        EditCol.Width = 41

        With DGV
            If isAddMaterial = True Then
                .ColumnCount = 6
                .Columns(0).HeaderText = "id"
                .Columns(0).Visible = False
                .Columns(0).Width = 60

                .Columns(1).HeaderText = "material id"
                .Columns(1).Width = 100
                .Columns(1).Visible = False

                .Columns(2).HeaderText = "السنه"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Visible = True

                .Columns(3).HeaderText = "السعر"
                .Columns(3).Width = 70
                .Columns(3).Visible = True
                '.Columns(3).DefaultCellStyle.Format = "0.00"


                .Columns(4).HeaderText = "تخفيض%"
                .Columns(4).Width = 80
                .Columns(4).Visible = True

                .Columns(5).HeaderText = "النهائي"
                .Columns(5).Width = 70
                .Columns(5).Visible = True
                '.Columns(5).DefaultCellStyle.Format = "0.00"
                '.Columns(4).DefaultCellStyle.Format = "00.00 %"


                .Columns.Add(EditCol)

                .Columns.Add(AddCol)


            Else
                .Columns(0).Visible = False
                .Columns(0).HeaderText = "id"

                .Columns(1).Visible = False
                .Columns(1).HeaderText = "material id"
                .Columns(1).Width = 100

                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Visible = True
                .Columns(2).HeaderText = "السنه"

                .Columns(3).HeaderText = "السعر"
                .Columns(3).Width = 60
                .Columns(3).Visible = True
                .Columns(3).DefaultCellStyle.Format = "0.00"


                .Columns(4).HeaderText = "تخفيض%"
                .Columns(4).Width = 85
                .Columns(4).Visible = True

                .Columns(5).HeaderText = "السعر"
                .Columns(5).Width = 60
                .Columns(5).Visible = True
                .Columns(5).DefaultCellStyle.Format = "0.00"
                '.Columns(4).DefaultCellStyle.Format = "# %"

                .Columns.Add(EditCol)

                .Columns.Add(AddCol)

            End If
            .ClearSelection()
        End With
    End Sub

    Public Sub ProductMaterialsDGVDesign(DGV As DataGridView)
        With DGV
            .ColumnCount = 7
            .Columns(0).Name = "الرقم"
            .Columns(0).Visible = False
            .Columns(0).Width = 60

            .Columns(1).Name = "الرقم"
            .Columns(1).Visible = False
            .Columns(1).Width = 60

            .Columns(2).Name = "الرقم"
            .Columns(2).Visible = False
            .Columns(2).Width = 60

            .Columns(3).Name = "اسم المادة"
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).Visible = True

            .Columns(4).Name = "رمز المادة"
            .Columns(4).Width = 140
            .Columns(4).Visible = True

            .Columns(5).Name = "الكمية"
            .Columns(5).Width = 80
            .Columns(5).Visible = True

            .Columns(6).Name = "الوحدة"
            .Columns(6).Width = 70
            .Columns(6).Visible = True

            .ClearSelection()
        End With
    End Sub

    Public Sub AuditsDGVDesign(dgv As DataGridView)
        With dgv
            .Columns(0).Visible = False
            .Columns(1).Visible = True
            .Columns(2).Visible = True
            .Columns(3).Visible = True
            .Columns(4).Visible = True
            .Columns(5).Visible = True
            .Columns(6).Visible = True
            .Columns(7).Visible = True


            .Columns(0).HeaderText = "מס"
            .Columns(1).HeaderText = "اسم التحقق"
            .Columns(2).HeaderText = "تاريخ التحقق"
            .Columns(3).HeaderText = "تاريخ الانتهاء"
            .Columns(4).HeaderText = "ايام التنبيه"
            .Columns(5).HeaderText = "تاريخ التنبيه"
            .Columns(6).HeaderText = "التنبيه"
            .Columns(7).HeaderText = "ملاحظات"


            '.Columns(0).Width = 30
            '.Columns(1).SortMode = 3
            .Columns(1).Width = 80
            .Columns(2).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill


            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'dgv.ClearSelection()
            '.rows(0).DefaultCellStyle.BackColor = 

        End With
    End Sub


End Module
