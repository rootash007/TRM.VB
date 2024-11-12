Public Class FrmAddCostomers

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        Me.ChkStatus.Visible = False
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtCName.Text <> "" Then
            If BtnAdd.Text = "הוספה" Then
                AddNewCostomer(TxtCName.Text, TxtCContact.Text, TxtCId.Text, TxtCAdress.Text, TxtCPhone.Text, TxtCFax.Text, TxtCEmail.Text, TxtCInfo.Text)
                ReloadCustomers()
                Me.ChkStatus.Visible = False
                Me.Close()
            Else
                UpdateCustomer(TxtCName.Text, TxtCContact.Text, TxtCId.Text, TxtCAdress.Text, TxtCPhone.Text, TxtCFax.Text, TxtCEmail.Text, TxtCInfo.Text, ChkStatus.Checked, FrmCustomers.SelectedDGV.CurrentRow.Cells(0).Value)
                ReloadCustomers()
                Me.ChkStatus.Visible = False
                Me.Close()
            End If
        Else
            MsgBox("שם לקוח חובה")
        End If
    End Sub

    Private Sub TxtVId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtVPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCPhone.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtVFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCFax.KeyPress
        NumbersOnly(e)
    End Sub

End Class