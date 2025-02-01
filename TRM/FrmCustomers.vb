Public Class FrmCustomers

    Public SelectedDGV As DataGridView

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadCustomers()
        TabCustomers.SelectedIndex = 0
    End Sub

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        FrmSupplierView.BtnAdd.Image = My.Resources.plus
        FrmSupplierView.BtnAdd.Text = "הוספה"
        FrmSupplierView.TxtName.Text = ""
        FrmSupplierView.TxtID.Text = ""
        FrmSupplierView.TxtContact.Text = ""
        FrmSupplierView.TxtPhone.Text = ""
        FrmSupplierView.TxtFax.Text = ""
        FrmSupplierView.TxtEmail.Text = ""
        FrmSupplierView.TxtAdress.Text = ""
        FrmSupplierView.TxtInfo.Text = ""
        FrmSupplierView.StatusSwitch.Visible = False
        FrmSupplierView.LblStatus.Visible = False

        FrmSupplierView.Text = "הוספת לקוח חדש"
        FrmSupplierView.ShowDialog()
    End Sub

    Private Sub LoadUpdateCustomer()
        If TabCustomers.SelectedIndex = 0 Then
            SelectedDGV = DgvCustomersOn
            FrmSupplierView.Text = "עדכון לקוח"
            FrmSupplierView.BtnAdd.Text = "עדכון"
        Else
            SelectedDGV = DGVCustomersOff
            FrmSupplierView.Text = "שחזור לקוח"
            FrmSupplierView.BtnAdd.Text = "שחזור"
        End If
        FrmSupplierView.StatusSwitch.Visible = True
        FrmSupplierView.LblStatus.Visible = True
        FrmSupplierView.TxtName.Text = SelectedDGV.CurrentRow.Cells(1).Value
        FrmSupplierView.TxtID.Text = SelectedDGV.CurrentRow.Cells(2).Value
        FrmSupplierView.TxtContact.Text = SelectedDGV.CurrentRow.Cells(3).Value
        FrmSupplierView.TxtPhone.Text = SelectedDGV.CurrentRow.Cells(4).Value
        FrmSupplierView.TxtFax.Text = SelectedDGV.CurrentRow.Cells(5).Value
        FrmSupplierView.TxtEmail.Text = SelectedDGV.CurrentRow.Cells(6).Value
        FrmSupplierView.TxtAdress.Text = SelectedDGV.CurrentRow.Cells(7).Value
        FrmSupplierView.TxtInfo.Text = SelectedDGV.CurrentRow.Cells(8).Value
        If SelectedDGV.CurrentRow.Cells(9).Value = True Then
            switcher = True
        Else
            switcher = False
        End If
        FrmSupplierView.BtnAdd.Image = My.Resources.save
        'FrmAddCustomers.Text = "עדכון לקוח"
        'FrmAddCustomers.BtnAdd.Text = "עדכון"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles BtnDeleteCustomer.Click
        If DgvCustomersOn.RowCount > 0 Then
            Dim ExitMsg As DialogResult
            ExitMsg = MsgBox("האם אתה בטוח שברצונך למחוק לקוח", vbYesNo + vbQuestion, "מחיקה")
            If ExitMsg = 6 Then
                CustomerDelete()
                ReloadCustomers()
                ReLoadMain()
            End If
        End If
    End Sub

    Private Sub BtnUpdatecustomer_Click(sender As Object, e As EventArgs) Handles BtnUpdateCustomer.Click
        If TabCustomers.SelectedIndex = 0 Then
            SelectedDGV = DgvCustomersOn
        Else
            SelectedDGV = DGVCustomersOff
        End If
        If SelectedDGV.RowCount > 0 Then
            LoadUpdateCustomer()
            FrmSupplierView.ShowDialog()
            'Else
            '    OkMsgAlert("שגיאה", "אין שורות לבחירה")
            '    'MsgBox("אין שורות לבחירה", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "שגיאה")
        End If
    End Sub

    Private Sub Tabcustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabCustomers.SelectedIndexChanged
        If TabCustomers.SelectedIndex = 0 Then
            BtnUpdateCustomer.Text = "עדכון "
            BtnDeleteCustomer.Enabled = True
        Else
            BtnUpdateCustomer.Text = "שחזור"
            BtnDeleteCustomer.Enabled = False
        End If
    End Sub

    Private Sub DGVCustomersOff_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVCustomersOff.CellMouseDoubleClick
        LoadUpdateCustomer()
        FrmSupplierView.ShowDialog()
    End Sub

    Private Sub BtnUpdateCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TabCustomers.KeyDown, BtnUpdateCustomer.KeyDown, BtnDeleteCustomer.KeyDown, BtnClose.KeyDown, BtnAddNewCustomer.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class