Public Class FrmSuppliers

    Public SelectedDGV As DataGridView
    Private Sub FrmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadOn.Checked = True
        LoadSuppliers()
    End Sub
    Private Sub BtnAddNewSupplier_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmSupplierView = Nothing
        FrmSupplierView.BtnAdd.Image = My.Resources.plus
        FrmSupplierView.BtnAdd.Text = "اضافة"
        FrmSupplierView.StatusSwitch.Visible = False
        FrmSupplierView.LblStatus.Visible = False
        FrmSupplierView.ShowDialog()
    End Sub
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If DGVSuppliers.RowCount > 0 Then
            FrmSupplierView = Nothing
            FrmSupplierView.BtnAdd.Text = "حفظ"
            FrmSupplierView.StatusSwitch.Visible = True
            FrmSupplierView.LblStatus.Visible = True
            If DGVSuppliers.CurrentRow.Cells(13).Value = True Then
                FrmSupplierView.StatusSwitch.Image = My.Resources.swon1
                FrmSupplierView.LblStatus.Text = "مفعل"
            Else
                FrmSupplierView.StatusSwitch.Image = My.Resources.swoff1
                FrmSupplierView.LblStatus.Text = "غير مفعل"
            End If
            FrmSupplierView.TxtName.Text = DGVSuppliers.CurrentRow.Cells(1).Value.ToString
            FrmSupplierView.TxtID.Text = DGVSuppliers.CurrentRow.Cells(2).Value.ToString
            FrmSupplierView.TxtContact.Text = DGVSuppliers.CurrentRow.Cells(3).Value.ToString
            FrmSupplierView.TxtPhone.Text = DGVSuppliers.CurrentRow.Cells(4).Value.ToString
            FrmSupplierView.TxtFax.Text = DGVSuppliers.CurrentRow.Cells(5).Value.ToString
            FrmSupplierView.TxtEmail.Text = DGVSuppliers.CurrentRow.Cells(6).Value.ToString
            FrmSupplierView.TxtAdress.Text = DGVSuppliers.CurrentRow.Cells(7).Value.ToString
            FrmSupplierView.TxtCity.Text = DGVSuppliers.CurrentRow.Cells(8).Value.ToString
            FrmSupplierView.TxtPostalCode.Text = DGVSuppliers.CurrentRow.Cells(9).Value.ToString
            FrmSupplierView.TxtBank.Text = DGVSuppliers.CurrentRow.Cells(10).Value.ToString
            FrmSupplierView.TxtCurrency.Text = DGVSuppliers.CurrentRow.Cells(11).Value.ToString
            FrmSupplierView.TxtInfo.Text = DGVSuppliers.CurrentRow.Cells(12).Value.ToString
            FrmSupplierView.DtpCreatedAt.Text = DGVSuppliers.CurrentRow.Cells(14).Value.ToString
            FrmSupplierView.ShowDialog()
        End If
    End Sub
    Private Sub BtnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DGVSuppliers.RowCount > 0 Then
            Dim StatusChangeMsg As DialogResult

            If FmSuppliers.DGVSuppliers.CurrentRow.Cells(13).Value = True Then
                StatusChangeMsg = MsgBox("هل تريد فعلا حذف المورد", vbYesNo + vbQuestion, "حذف")
            Else
                StatusChangeMsg = MsgBox("هل تريد فعلا استرجاع المورد", vbYesNo + vbQuestion, "استرجاع")
            End If
            If StatusChangeMsg = 6 Then
                SupplierStatusChange()
                LoadSuppliers()
            End If
        End If
    End Sub
    Private Sub DGVSuppliers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSuppliers.CellDoubleClick
        BtnSelect.PerformClick()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub TabVendors_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, BtnSelect.KeyDown, BtnDelete.KeyDown, BtnClose.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Rad_Click(sender As Object, e As EventArgs) Handles RadOn.Click, RadOff.Click, RadAll.Click
        LoadSuppliers()
    End Sub
    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Try
            Dim dv As DataView
            Dim Supplier_Copy As DataTable = SupplierTab.Copy
            Dim isUsed As Boolean = False
            If Not (String.IsNullOrWhiteSpace(TxtSupplierName.Text)) Then
                dv = Supplier_Copy.DefaultView
                dv.RowFilter = "supplier_name like '%" & TxtSupplierName.Text & "%'"
                DGVSuppliers.DataSource = Supplier_Copy
                isUsed = True
            End If
            If Not (String.IsNullOrWhiteSpace(TxtID.Text)) Then
                dv = Supplier_Copy.DefaultView
                dv.RowFilter = "supplier_id like '%" & TxtID.Text & "%'"
                DGVSuppliers.DataSource = Supplier_Copy
                isUsed = True

            End If
            If Not (String.IsNullOrWhiteSpace(TxtContact.Text)) Then
                dv = Supplier_Copy.DefaultView
                dv.RowFilter = "supplier_contact like '%" & TxtContact.Text & "%'"
                DGVSuppliers.DataSource = Supplier_Copy
                isUsed = True

            End If
            If isUsed = False Then
                DGVSuppliers.DataSource = SupplierTab
            End If
            If RadAll.Checked = True Then
                If DGVSuppliers.RowCount > 0 Then
                    For i = 0 To DGVSuppliers.RowCount - 1
                        If DGVSuppliers.Rows(i).Cells(13).Value = True Then
                            DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.White
                        Else
                            DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            If Not (String.IsNullOrWhiteSpace(TxtSearch.Text)) Then
                Dim dv As DataView
                Dim Supplier_Copy As DataTable = SupplierTab.Copy
                dv = Supplier_Copy.DefaultView
                dv.RowFilter = "supplier_name+supplier_phone+supplier_email+supplier_city like '%" & TxtSearch.Text & "%'"
                DGVSuppliers.DataSource = Supplier_Copy
            Else
                DGVSuppliers.DataSource = SupplierTab
            End If
            If RadAll.Checked = True Then
                If DGVSuppliers.RowCount > 0 Then
                    For i = 0 To DGVSuppliers.RowCount - 1
                        If DGVSuppliers.Rows(i).Cells(13).Value = True Then
                            DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.White
                        Else
                            DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LblClear_Click(sender As Object, e As EventArgs) Handles LblClear.Click
        TxtSearch.Text = Nothing
        TxtSupplierName.Text = Nothing
        TxtID.Text = Nothing
        TxtContact.Text = Nothing
        DGVSuppliers.DataSource = SupplierTab
        If RadAll.Checked = True Then
            If DGVSuppliers.RowCount > 0 Then
                For i = 0 To DGVSuppliers.RowCount - 1
                    If DGVSuppliers.Rows(i).Cells(13).Value = True Then
                        DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.White
                    Else
                        DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                    End If
                Next
            End If
        End If
    End Sub
End Class