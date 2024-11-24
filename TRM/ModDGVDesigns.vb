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

End Module
