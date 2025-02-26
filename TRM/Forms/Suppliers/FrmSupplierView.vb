Public Class FrmSupplierView
    Dim isActive As Boolean = FmSuppliers.DGVSuppliers.CurrentRow.Cells(13).Value
    Private Sub FrmSupplierView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    End Sub
    Private Sub StatusSwitch_Click(sender As Object, e As EventArgs) Handles StatusSwitch.Click
        If isActive = False Then
            isActive = True
            StatusSwitch.Image = My.Resources.swon1
            LblStatus.Text = "مفعل"
        Else
            isActive = False
            StatusSwitch.Image = My.Resources.swoff1
            LblStatus.Text = "غير مفعل"
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress, TxtID.KeyPress, TxtFax.KeyPress, TxtPostalCode.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtPhone_Leave(sender As Object, e As EventArgs) Handles TxtPhone.Leave

    End Sub

End Class