Public Class FrmSupplierView
    Dim isActive As Boolean
    Private Sub FrmSupplierView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LblStatus.Visible = True Then
            isActive = FmSuppliers.DGVSuppliers.CurrentRow.Cells(13).Value
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If LblStatus.Visible = True Then
            '//save
            Dim SaveMsg As DialogResult
            SaveMsg = MsgBox("هل تريد حفظ التغييرات", vbYesNo + vbQuestion, "حفظ")
            If SaveMsg = 6 Then
                UpdateSupplier(TxtName.Text, TxtID.Text, TxtContact.Text, TxtPhone.Text, TxtFax.Text, TxtEmail.Text, TxtAdress.Text, TxtCity.Text, TxtPostalCode.Text, TxtBank.Text, TxtCurrency.Text, TxtInfo.Text, isActive, TxtSupplierFolder.Text, FmSuppliers.DGVSuppliers.CurrentRow.Cells(0).Value)
            End If
        Else
            '//add
            AddSubpplier(TxtName.Text, TxtID.Text, TxtContact.Text, TxtPhone.Text, TxtFax.Text, TxtEmail.Text, TxtAdress.Text, TxtCity.Text, TxtPostalCode.Text, TxtBank.Text, TxtCurrency.Text, TxtInfo.Text, TxtSupplierFolder.Text)
        End If
        LoadSuppliers()
        Me.Close()
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

    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSupplierFolder.KeyDown, TxtPostalCode.KeyDown, TxtPhone.KeyDown, TxtName.KeyDown, TxtID.KeyDown, TxtFax.KeyDown, TxtEmail.KeyDown, TxtCurrency.KeyDown, TxtContact.KeyDown, TxtCity.KeyDown, TxtAdress.KeyDown, DtpCreatedAt.KeyDown, BtnCancel.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAdd.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class