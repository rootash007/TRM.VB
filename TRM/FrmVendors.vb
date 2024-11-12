Public Class FrmVendors

    Public SelectedDGV As DataGridView

    Private Sub FrmVendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadVendors()
        TabVendors.SelectedIndex = 0
    End Sub

    Private Sub BtnAddNewVendor_Click(sender As Object, e As EventArgs) Handles BtnAddNewVendor.Click
        'FrmAddVendors.BtnAdd.Image = My.Resources.plus
        'FrmAddVendors.BtnAdd.Text = "הוספה"
        'FrmAddVendors.TxtVName.Text = ""
        'FrmAddVendors.TxtVContact.Text = ""
        'FrmAddVendors.TxtVId.Text = ""
        'FrmAddVendors.TxtVAdress.Text = ""
        'FrmAddVendors.TxtVPhone.Text = ""
        'FrmAddVendors.TxtVFax.Text = ""
        'FrmAddVendors.TxtVEmail.Text = ""
        'FrmAddVendors.TxtVInfo.Text = ""
        'FrmDataBaseSettings.StatusSwitch.Visible = False
        'FrmDataBaseSettings.LblStatus.Visible = False

        'FrmAddVendors.Text = "הוספת ספק חדש"
        'FrmAddVendors.ShowDialog()
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

    Private Sub BtnDeleteVendor_Click(sender As Object, e As EventArgs) Handles BtnDeleteVendor.Click
        If DgvVendorsOn.RowCount > 0 Then
            Dim ExitMsg As DialogResult
            ExitMsg = MsgBox("האם אתה בטוח שברצונך למחוק ספק", vbYesNo + vbQuestion, "מחיקה")
            If ExitMsg = 6 Then
                VendorDelete()
                ReloadVendors()
                ReLoadMain()
            End If
        End If
    End Sub

    Private Sub BtnUpdateVendor_Click(sender As Object, e As EventArgs) Handles BtnUpdateVendor.Click
        If TabVendors.SelectedIndex = 0 Then
            SelectedDGV = DgvVendorsOn
        Else
            SelectedDGV = DGVVendorsOff
        End If
        If SelectedDGV.RowCount > 0 Then
            LoadUpdateVendor()
            'FrmAddVendors.ShowDialog()
            'Else
            '    OkMsgAlert("שגיאה", "אין שורות לבחירה")
            'MsgBox("אין שורות לבחירה", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "שגיאה")
        End If
    End Sub

    Private Sub TabVendors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabVendors.SelectedIndexChanged
        If TabVendors.SelectedIndex = 0 Then
            BtnUpdateVendor.Text = "עדכון"
            BtnDeleteVendor.Enabled = True
        Else
            BtnUpdateVendor.Text = "שחזור"
            BtnDeleteVendor.Enabled = False
        End If
    End Sub

    Private Sub DgvVendorsOn_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVendorsOn.CellDoubleClick
        If VendorsWindow = "AddCar" Then
            FmAddNewCar.TxtSalerName.Text = DgvVendorsOn.CurrentRow.Cells(1).Value
            FmAddNewCar.TxtSalerId.Text = DgvVendorsOn.CurrentRow.Cells(3).Value
            FmAddNewCar.TxtSalerAdress.Text = DgvVendorsOn.CurrentRow.Cells(4).Value
            FmAddNewCar.TxtSalerPhone.Text = DgvVendorsOn.CurrentRow.Cells(5).Value
            Me.Close()
        ElseIf VendorsWindow = "VendorUpdate" Then
            LoadUpdateVendor()
            'FrmAddVendors.ShowDialog()
        End If
    End Sub

    Private Sub DGVVendorsOff_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVVendorsOff.CellMouseDoubleClick
        LoadUpdateVendor()
        'FrmAddVendors.ShowDialog()
    End Sub

    Private Sub TabVendors_KeyDown(sender As Object, e As KeyEventArgs) Handles TabVendors.KeyDown, MyBase.KeyDown, BtnUpdateVendor.KeyDown, BtnDeleteVendor.KeyDown, BtnClose.KeyDown, BtnAddNewVendor.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class