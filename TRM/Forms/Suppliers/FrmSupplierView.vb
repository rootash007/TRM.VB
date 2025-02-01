Public Class FrmSupplierView
    Private Sub FrmSupplierView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    End Sub
    Private Sub StatusSwitch_Click(sender As Object, e As EventArgs) Handles StatusSwitch.Click

    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress, TxtID.KeyPress, TxtFax.KeyPress, TextBox7.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtPhone_Leave(sender As Object, e As EventArgs) Handles TxtPhone.Leave

    End Sub

End Class