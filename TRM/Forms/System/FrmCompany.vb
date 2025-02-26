Public Class FrmCompany
    Private Sub FrmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumTax.Value = (My.Settings.Tax * 100) - 100
        TxtAdminCode.Text = My.Settings.AdminCode
        ChkMaterialQuantity.Checked = My.Settings.MaterialQuantityLock
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim SaveMsg As DialogResult = MsgBox("save?", vbYesNoCancel + vbQuestion, "")
        If SaveMsg = vbYes Then
            My.Settings.Tax = (NumTax.Value + 100) / 100
            My.Settings.AdminCode = TxtAdminCode.Text
            My.Settings.MaterialQuantityLock = ChkMaterialQuantity.Checked

            My.Settings.Save()
            Me.Close()
        ElseIf SaveMsg = vbNo Then
            Me.Close()
        Else
            Return
        End If
    End Sub


    Private Sub FrmCompany_KeyDown_1(sender As Object, e As KeyEventArgs) Handles TxtAdminCode.KeyDown, NumTax.KeyDown, MyBase.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class