Public Class FrmRequiredAddCar

    Private Sub FrmRequiredAddCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkCarKind.Checked = My.Settings.EditDataBase
        ChkCarType.Checked = My.Settings.CarType
        ChkCarColor.Checked = My.Settings.AdminCode
        ChkCarOil.Checked = My.Settings.Tax
        ChkCarKM.Checked = My.Settings.CarKM
        ChkShelda.Checked = My.Settings.Shelda
        ChkPriceOut.Checked = My.Settings.PriceOut
        ChkCarModel.Checked = My.Settings.CurrentVersion
        ChkMainIs.Checked = My.Settings.MainIs
        ChkCarGear.Checked = My.Settings.CarGear
        ChkEngine.Checked = My.Settings.Engine
        ChkCarCode.Checked = My.Settings.CarCode
        ChkPriceIn.Checked = My.Settings.PriceIn
        ChkSalerName.Checked = My.Settings.SalerName
        ChkSalerAdress.Checked = My.Settings.SalerAdress
        ChkSalerPhone.Checked = My.Settings.SalerPhone
        ChkSalerId.Checked = My.Settings.SalerId
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim ExitMsg As DialogResult
        ExitMsg = MsgBox("האם אתה בטוח שברצונך לשמור", vbYesNo + vbQuestion, "שמירה")
        If ExitMsg = 6 Then
            My.Settings.EditDataBase = ChkCarKind.Checked
            My.Settings.CarType = ChkCarType.Checked
            My.Settings.AdminCode = ChkCarColor.Checked
            My.Settings.Tax = ChkCarOil.Checked
            My.Settings.CarKM = ChkCarKM.Checked
            My.Settings.Shelda = ChkShelda.Checked
            My.Settings.PriceOut = ChkPriceOut.Checked
            My.Settings.CurrentVersion = ChkCarModel.Checked
            My.Settings.MainIs = ChkMainIs.Checked
            My.Settings.CarGear = ChkCarGear.Checked
            My.Settings.Engine = ChkEngine.Checked
            My.Settings.CarCode = ChkCarCode.Checked
            My.Settings.PriceIn = ChkPriceIn.Checked
            My.Settings.SalerName = ChkSalerName.Checked
            My.Settings.SalerAdress = ChkSalerAdress.Checked
            My.Settings.SalerPhone = ChkSalerPhone.Checked
            My.Settings.SalerId = ChkSalerId.Checked
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub ChkCarKind_KeyDown(sender As Object, e As KeyEventArgs) Handles ChkShelda.KeyDown, ChkSalerPhone.KeyDown, ChkSalerName.KeyDown, ChkSalerId.KeyDown, ChkSalerAdress.KeyDown, ChkPriceOut.KeyDown, ChkPriceIn.KeyDown, ChkMainIs.KeyDown, ChkEngine.KeyDown, ChkCarType.KeyDown, ChkCarOil.KeyDown, ChkCarModel.KeyDown, ChkCarKM.KeyDown, ChkCarKind.KeyDown, ChkCarGear.KeyDown, ChkCarColor.KeyDown, ChkCarCode.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class