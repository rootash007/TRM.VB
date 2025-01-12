Public Class FrmMaterials
    Dim ActiveId As Integer = 0

    Public Sub FrmMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMaterials()
        Me.Dock = DockStyle.Fill

        'Me.AutoSize = True
        'Dim ss As String = Me.AutoSizeMode.
        'Me.SizeFromClientSize = 100
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
        'Dim FmMaterialAddEdit = New FrmMaterialAddEdit
        FmMaterialAddEdit = New FrmMaterialAddEdit
        FmMaterialAddEdit.ShowDialog()
    End Sub

    Private Sub BtnExcelLoad_Click(sender As Object, e As EventArgs) Handles BtnImportFromExcel.Click

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

    Private Sub DgvMaterials_KeyDown(sender As Object, e As KeyEventArgs) Handles TabMaterials.KeyDown, DgvMaterials.KeyDown, BtnUpdateMaterial.KeyDown, BtnImportFromExcel.KeyDown, BtnDeleteMaterial.KeyDown, BtnClose.KeyDown, BtnAddMaterial.KeyDown
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
        Dim que As String
        If TabMaterials.SelectedIndex = 0 Then
            que = "select * from materials where id =" & DgvMaterials.CurrentRow.Cells(0).Value
            FillList(que)
            If MyTab.Rows(0).Item(9) = 0 Then
                inUSEMaterial(DgvMaterials.CurrentRow.Cells(0).Value, 1)
                isAddMaterial = False
                FmMaterialAddEdit = New FrmMaterialAddEdit
                FmMaterialAddEdit.ShowDialog()
            Else
                MsgBox("المادة قيد الاستخدام من قبل مستخدم اخر", vbOKOnly + vbInformation, "قيد الاستخدام")
            End If
        ElseIf TabMaterials.SelectedIndex = 1 Then
            que = "select * from materials where id =" & DGVMaterialsOff.CurrentRow.Cells(0).Value
            FillList(que)
            If MyTab.Rows(0).Item(9) = 0 Then
                inUSEMaterial(DGVMaterialsOff.CurrentRow.Cells(0).Value, 1)
                isAddMaterial = False
                FmMaterialAddEdit = New FrmMaterialAddEdit
                FmMaterialAddEdit.ShowDialog()
            Else
                MsgBox("المادة قيد الاستخدام من قبل مستخدم اخر", vbOKOnly + vbInformation, "قيد الاستخدام")
            End If
        End If

        'isAddMaterial = False
        'FmMaterialAddEdit.ShowDialog()



        'If Application.OpenForms.OfType(Of FrmMaterialAddEdit).Any = True Then
        '    FmMaterialAddEdit.Activate()
        '    'FmMaterialAddEdit = New FrmMaterialAddEdit

        '    'FmMaterialAddEdit.MdiParent = FrmMain
        '    'FmMaterialAddEdit.Show()
        'Else
        '    FmMaterialAddEdit = New FrmMaterialAddEdit
        '    FmMaterialAddEdit.MdiParent = FrmMain
        '    FmMaterialAddEdit.Show()
        'End If
    End Sub

    Private Sub DgvMaterials_DoubleClick(sender As Object, e As EventArgs) Handles DgvMaterials.DoubleClick
        'DgvMaterials.CurrentRow.DefaultCellStyle.BackColor = Color.Pink
        'isAddMaterial = False
        'Dim FmMaterialAddEdit = New FrmMaterialAddEdit
        'FmMaterialAddEdit.ShowDialog()
        BtnUpdateMaterial_Click(Me, e)
    End Sub

    Private Sub FrmMaterials_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadMaterials()
    End Sub

    Private Sub FrmMaterials_MaximumSizeChanged(sender As Object, e As EventArgs) Handles MyBase.MaximumSizeChanged
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
        Try
            If Not (String.IsNullOrWhiteSpace(TxtFilter.Text)) Then
                Dim dv As DataView
                Dim MaterialTab_Copy As DataTable = MaterialsOnTab.Copy
                dv = MaterialTab_Copy.DefaultView
                dv.RowFilter = "material_name+material_barcode+material_loc_barcode+material_quantity+material_unit like '%" & TxtFilter.Text & "%'"
                DgvMaterials.DataSource = MaterialTab_Copy
            Else
                DgvMaterials.DataSource = MaterialsOnTab
                If FmMaterials.DgvMaterials.RowCount > 0 Then
                    For i = 0 To FmMaterials.DgvMaterials.RowCount - 1
                        If FmMaterials.DgvMaterials.Rows(i).Cells(4).Value < 0 Then
                            FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                        ElseIf FmMaterials.DgvMaterials.Rows(i).Cells(4).Value = 0 Then
                            FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                        Else
                            FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.White
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TxtFilter.Text = ""
        DgvMaterials.DataSource = MaterialsOnTab
        If FmMaterials.DgvMaterials.RowCount > 0 Then
            For i = 0 To FmMaterials.DgvMaterials.RowCount - 1
                If FmMaterials.DgvMaterials.Rows(i).Cells(4).Value < 0 Then
                    FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                ElseIf FmMaterials.DgvMaterials.Rows(i).Cells(4).Value = 0 Then
                    FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                Else
                    FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next
        End If
    End Sub

    Private Sub BtmExportToExcel_Click(sender As Object, e As EventArgs) Handles BtmExportToExcel.Click
        If DgvMaterials.Rows.Count = 0 Then
            MsgBox("القائمة فارغة", vbOKOnly + vbCritical, "خطأ")
            Return
        End If
        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        Try
            worksheet = workbook.ActiveSheet
            worksheet.Name = "المواد"

            '.Columns(1).HeaderText = "اسم المادة"
            '.Columns(2).HeaderText = "الرمز"
            '.Columns(3).HeaderText = "الرمز المحلي"
            '.Columns(4).HeaderText = "الكمية"
            '.Columns(5).HeaderText = "الكمية الدنيا"
            '.Columns(6).HeaderText = "وحدة القياس"
            '.Columns(7).HeaderText = "الوزن"


            worksheet.Cells(1, 1) = DgvMaterials.Columns(1).HeaderText
            worksheet.Cells(1, 2) = DgvMaterials.Columns(3).HeaderText
            worksheet.Cells(1, 3) = DgvMaterials.Columns(2).HeaderText
            worksheet.Cells(1, 4) = DgvMaterials.Columns(4).HeaderText
            worksheet.Cells(1, 5) = DgvMaterials.Columns(5).HeaderText
            worksheet.Cells(1, 6) = DgvMaterials.Columns(6).HeaderText
            worksheet.Cells(1, 7) = DgvMaterials.Columns(7).HeaderText


            For i = 0 To DgvMaterials.Rows.Count - 1
                For b = 1 To 7
                    If b = 2 Then
                        worksheet.Cells(i + 2, b + 1) = DgvMaterials.Rows(i).Cells(b).Value
                    ElseIf b = 3 Then
                        worksheet.Cells(i + 2, b - 1) = DgvMaterials.Rows(i).Cells(b).Value
                    Else
                        worksheet.Cells(i + 2, b) = DgvMaterials.Rows(i).Cells(b).Value
                    End If
                    'worksheet.Cells(i + 2, b + 1) = DgvMaterials.Rows(i).Cells(b).Value
                Next
            Next
            Dim SaveDialog As New SaveFileDialog()
            SaveDialog.Filter = "Excel Files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveDialog.FilterIndex = 2

            If SaveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(SaveDialog.FileName)
                MsgBox("تم حفظ الملف بنجاح", vbOKOnly + vbInformation, "استعلام")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try
    End Sub
End Class