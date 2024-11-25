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

End Module
