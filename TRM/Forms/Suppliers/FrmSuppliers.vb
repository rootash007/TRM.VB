Public Class FrmSuppliers

    Public SelectedDGV As DataGridView

    Private Sub FrmVendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadOn.Checked = True
        LoadSuppliers()
    End Sub

    Private Sub BtnAddNewVendor_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmSupplierView = Nothing
        FrmSupplierView.BtnAdd.Image = My.Resources.plus
        FrmSupplierView.BtnAdd.Text = "اضافة"
        FrmSupplierView.StatusSwitch.Visible = False
        FrmSupplierView.LblStatus.Visible = False
        FrmSupplierView.ShowDialog()
    End Sub

    Private Sub LoadUpdateVendor()
        'If TabVendors.SelectedIndex = 0 Then
        '    SelectedDGV = DgvVendorsOn
        'Else
        '    SelectedDGV = DGVVendorsOff
        'End If
        'FrmDataBaseSettings.StatusSwitch.Visible = True
        'FrmDataBaseSettings.LblStatus.Visible = True
        'FrmAddVendors.TxtVName.Text = SelectedDGV.CurrentRow.Cells(1).Value
        'FrmAddVendors.TxtVContact.Text = SelectedDGV.CurrentRow.Cells(2).Value
        'FrmAddVendors.TxtVId.Text = SelectedDGV.CurrentRow.Cells(3).Value
        'FrmAddVendors.TxtVAdress.Text = SelectedDGV.CurrentRow.Cells(4).Value
        'FrmAddVendors.TxtVPhone.Text = SelectedDGV.CurrentRow.Cells(5).Value
        'FrmAddVendors.TxtVFax.Text = SelectedDGV.CurrentRow.Cells(6).Value
        'FrmAddVendors.TxtVEmail.Text = SelectedDGV.CurrentRow.Cells(7).Value
        'FrmAddVendors.TxtVInfo.Text = SelectedDGV.CurrentRow.Cells(8).Value
        'If SelectedDGV.CurrentRow.Cells(9).Value = True Then
        '    switcher = True
        'Else
        '    switcher = False
        'End If
        'FrmAddVendors.BtnAdd.Image = My.Resources.save
        'FrmAddVendors.Text = "עדכון ספק"
        'FrmAddVendors.BtnAdd.Text = " עדכון "
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnDeleteVendor_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'If DgvSuppliersOn.RowCount > 0 Then
        '    Dim ExitMsg As DialogResult
        '    ExitMsg = MsgBox("האם אתה בטוח שברצונך למחוק ספק", vbYesNo + vbQuestion, "מחיקה")
        '    If ExitMsg = 6 Then
        '        VendorDelete()
        '        LoadSuppliers()
        '        ReLoadMain()
        '    End If
        'End If
    End Sub

    Private Sub BtnUpdateVendor_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        'If TabSuppliers.SelectedIndex = 0 Then
        '    SelectedDGV = DgvSuppliersOn
        'Else
        '    SelectedDGV = DGVSuppliersOff
        'End If
        'If SelectedDGV.RowCount > 0 Then
        '    LoadUpdateVendor()
        '    'FrmAddVendors.ShowDialog()
        '    'Else
        '    '    OkMsgAlert("שגיאה", "אין שורות לבחירה")
        '    'MsgBox("אין שורות לבחירה", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "שגיאה")
        'End If
    End Sub

    Private Sub DgvVendorsOn_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'If VendorsWindow = "AddCar" Then
        '    FmAddNewCar.TxtSalerName.Text = DgvSuppliersOn.CurrentRow.Cells(1).Value
        '    FmAddNewCar.TxtSalerId.Text = DgvSuppliersOn.CurrentRow.Cells(3).Value
        '    FmAddNewCar.TxtSalerAdress.Text = DgvSuppliersOn.CurrentRow.Cells(4).Value
        '    FmAddNewCar.TxtSalerPhone.Text = DgvSuppliersOn.CurrentRow.Cells(5).Value
        '    Me.Close()
        'ElseIf VendorsWindow = "VendorUpdate" Then
        '    LoadUpdateVendor()
        '    'FrmAddVendors.ShowDialog()
        'End If
    End Sub

    Private Sub DGVVendorsOff_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        LoadUpdateVendor()
        'FrmAddVendors.ShowDialog()
    End Sub

    Private Sub TabVendors_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, BtnSelect.KeyDown, BtnDelete.KeyDown, BtnClose.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub RadOn_Click(sender As Object, e As EventArgs) Handles RadOn.Click, RadOff.Click, RadAll.Click
        LoadSuppliers()
    End Sub
End Class