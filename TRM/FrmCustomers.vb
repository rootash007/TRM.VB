Public Class FrmCustomers

    Public SelectedDGV As DataGridView

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadCustomers()
        TabCustomers.SelectedIndex = 0
    End Sub

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        FrmAddCustomers.BtnAdd.Image = My.Resources.plus
        FrmAddCustomers.BtnAdd.Text = "הוספה"
        FrmAddCustomers.TxtCName.Text = ""
        FrmAddCustomers.TxtCContact.Text = ""
        FrmAddCustomers.TxtCId.Text = ""
        FrmAddCustomers.TxtCAdress.Text = ""
        FrmAddCustomers.TxtCPhone.Text = ""
        FrmAddCustomers.TxtCFax.Text = ""
        FrmAddCustomers.TxtCEmail.Text = ""
        FrmAddCustomers.TxtCInfo.Text = ""
        FrmAddCustomers.StatusSwitch.Visible = False
        FrmAddCustomers.LblStatus.Visible = False

        FrmAddCustomers.Text = "הוספת לקוח חדש"
        FrmAddCustomers.ShowDialog()
    End Sub

    Private Sub LoadUpdateCustomer()
        If TabCustomers.SelectedIndex = 0 Then
            SelectedDGV = DgvCustomersOn
            FrmAddCustomers.Text = "עדכון לקוח"
            FrmAddCustomers.BtnAdd.Text = "עדכון"
        Else
            SelectedDGV = DGVCustomersOff
            FrmAddCustomers.Text = "שחזור לקוח"
            FrmAddCustomers.BtnAdd.Text = "שחזור"
        End If
        FrmAddCustomers.StatusSwitch.Visible = True
        FrmAddCustomers.LblStatus.Visible = True
        FrmAddCustomers.TxtCName.Text = SelectedDGV.CurrentRow.Cells(1).Value
        FrmAddCustomers.TxtCContact.Text = SelectedDGV.CurrentRow.Cells(2).Value
        FrmAddCustomers.TxtCId.Text = SelectedDGV.CurrentRow.Cells(3).Value
        FrmAddCustomers.TxtCAdress.Text = SelectedDGV.CurrentRow.Cells(4).Value
        FrmAddCustomers.TxtCPhone.Text = SelectedDGV.CurrentRow.Cells(5).Value
        FrmAddCustomers.TxtCFax.Text = SelectedDGV.CurrentRow.Cells(6).Value
        FrmAddCustomers.TxtCEmail.Text = SelectedDGV.CurrentRow.Cells(7).Value
        FrmAddCustomers.TxtCInfo.Text = SelectedDGV.CurrentRow.Cells(8).Value
        If SelectedDGV.CurrentRow.Cells(9).Value = True Then
            switcher = True
        Else
            switcher = False
        End If
        FrmAddCustomers.BtnAdd.Image = My.Resources.save
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
            FrmAddCustomers.ShowDialog()
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
        FrmAddCustomers.ShowDialog()
    End Sub

    Private Sub BtnUpdateCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TabCustomers.KeyDown, BtnUpdateCustomer.KeyDown, BtnDeleteCustomer.KeyDown, BtnClose.KeyDown, BtnAddNewCustomer.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class