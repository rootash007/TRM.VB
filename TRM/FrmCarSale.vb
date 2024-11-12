Public Class FrmCarSale

    Private Sub FrmCarSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomersWindow = "CarSale"
        Dim que As String
        que = "select * from MainList where carstatus = 1 and canceled = 0 order by carserial "
        FillList(que)
        Me.DgvCarList.DataSource = MyTab
        DesignMainDGV(Me.DgvCarList)
        DgvCarList.ClearSelection()
        ChkNormal.Checked = False
        ChkChange.Checked = False
        ChkChangeAdd.Checked = False
        ChkChangeNon.Checked = False
        GrpCarList.Enabled = False
        GrpMoney.Visible = False
        TxtMoney.Visible = True
        LblMoney.Visible = True
        LblInvoice.Visible = True
        LblReceipt.Visible = True
        TxtInvoice.Visible = True
        TxtReceipt.Visible = True
        LblConfirm.Visible = True
        TxtConfirm.Visible = True
        TxtBuyerAdress.Text = ""
        TxtBuyerId.Text = ""
        TxtBuyerName.Text = ""
        TxtBuyerPhone.Text = ""
        TxtFilter.Text = ""
        TxtMoney.Text = ""
        TxtReceipt.Text = ""
        TxtInvoice.Text = ""
        TxtConfirm.Text = ""
        If Me.DgvCarList.RowCount = 0 Then
            BtnSave.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub ChkNormal_Click(sender As Object, e As EventArgs) Handles ChkNormal.Click
        ChkNormal.Checked = True
        ChkChange.Checked = False
        ChkChangeAdd.Checked = False
        ChkChangeNon.Checked = False
        GrpCarList.Enabled = True
        DgvCarList.Select()
        GrpMoney.Visible = True
        TxtMoney.Visible = True
        LblMoney.Visible = True
        LblInvoice.Visible = True
        LblReceipt.Visible = True
        TxtInvoice.Visible = True
        TxtReceipt.Visible = True
        LblConfirm.Visible = True
        TxtConfirm.Visible = True
        TxtBuyerAdress.Text = ""
        TxtBuyerId.Text = ""
        TxtBuyerName.Text = ""
        TxtBuyerPhone.Text = ""
        TxtMoney.Text = ""
        TxtReceipt.Text = ""
        TxtInvoice.Text = ""
        TxtConfirm.Text = ""
        TxtCarInfo.Text = "אין"
        LblMoney.Text = "מחיר מכירה"
    End Sub

    Private Sub ChkChange_Click(sender As Object, e As EventArgs) Handles ChkChange.Click
        ChkNormal.Checked = False
        ChkChange.Checked = True
        ChkChangeAdd.Checked = False
        ChkChangeNon.Checked = False
        GrpCarList.Enabled = True
        DgvCarList.Select()
        GrpMoney.Visible = True
        TxtMoney.Visible = True
        LblMoney.Visible = True
        LblInvoice.Visible = True
        LblReceipt.Visible = True
        TxtInvoice.Visible = True
        TxtReceipt.Visible = True
        LblConfirm.Visible = True
        TxtConfirm.Visible = True
        TxtBuyerAdress.Text = ""
        TxtBuyerId.Text = ""
        TxtBuyerName.Text = ""
        TxtBuyerPhone.Text = ""
        TxtMoney.Text = ""
        TxtReceipt.Text = ""
        TxtConfirm.Text = ""
        TxtInvoice.Text = ""
        TxtCarInfo.Text = "אין"
        LblMoney.Text = "סכום הפרש"

    End Sub

    Private Sub ChkChangeAdd_Click(sender As Object, e As EventArgs) Handles ChkChangeAdd.Click
        ChkNormal.Checked = False
        ChkChange.Checked = False
        ChkChangeAdd.Checked = True
        ChkChangeNon.Checked = False
        GrpCarList.Enabled = True
        DgvCarList.Select()
        GrpMoney.Visible = True
        TxtMoney.Visible = True
        LblMoney.Visible = True
        LblInvoice.Visible = True
        LblReceipt.Visible = False
        TxtInvoice.Visible = True
        TxtReceipt.Visible = False
        LblConfirm.Visible = False
        TxtConfirm.Visible = False
        TxtBuyerAdress.Text = ""
        TxtBuyerId.Text = ""
        TxtBuyerName.Text = ""
        TxtBuyerPhone.Text = ""
        TxtMoney.Text = ""
        TxtReceipt.Text = ""
        TxtConfirm.Text = ""
        TxtInvoice.Text = ""
        TxtCarInfo.Text = "אין"
        LblMoney.Text = "סכום תוספת"

    End Sub

    Private Sub ChkChangeNon_Click(sender As Object, e As EventArgs) Handles ChkChangeNon.Click
        ChkNormal.Checked = False
        ChkChange.Checked = False
        ChkChangeAdd.Checked = False
        ChkChangeNon.Checked = True
        GrpCarList.Enabled = True
        DgvCarList.Select()
        GrpMoney.Visible = True
        TxtMoney.Visible = False
        LblMoney.Visible = False
        LblInvoice.Visible = True
        LblReceipt.Visible = False
        TxtInvoice.Visible = True
        TxtReceipt.Visible = False
        LblConfirm.Visible = False
        TxtConfirm.Visible = False
        TxtBuyerAdress.Text = ""
        TxtBuyerId.Text = ""
        TxtBuyerName.Text = ""
        TxtBuyerPhone.Text = ""
        TxtReceipt.Text = ""
        TxtInvoice.Text = ""
        TxtConfirm.Text = ""
        TxtMoney.Text = 0
        TxtCarInfo.Text = "עסקת החלפה על רכב מס " & My.Settings.LocalDataBase & " ביומן ללא תוספת מחיר או הפרש "
    End Sub

    Private Sub TxtFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFilter.KeyPress

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If DgvCarList.RowCount = 0 Then
            Exit Sub
        End If
        Dim Money As Integer
        Dim ExitMsg As DialogResult
        If TxtMoney.Text = "" Then
            MsgBox("נא להכנים מחיר", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "אין מחיר")
            Return
        End If
        ExitMsg = MsgBox("האם אתה בטוח שברצונך לבצע עסקת מכירה", vbYesNo + vbQuestion, "עסקת מכירה")
        If ExitMsg = vbNo Then
            Return
        End If
        AgreementStatus = "CarSale"
        LoadAgree()
        FrmAgreementPrint.ShowDialog()

        If TxtReceipt.Text = "" Then
            TxtReceipt.Text = "אין"
        End If
        If TxtInvoice.Text = "" Then
            TxtInvoice.Text = "אין"
        End If
        If TxtConfirm.Text = "" Then
            TxtConfirm.Text = "אין"
        End If

        Dim que As String
        Dim TradeSerial As Integer
        que = "select CarSerial from MainList order by CarSerial"
        FillList(que)
        For i = My.Settings.EmptyCarSerial - 1 To MyTab.Rows.Count - 1
            If TradeSerial = MyTab.Rows(i).Item(0).ToString Then
                TradeSerial += 1
            End If
        Next


        If ChkNormal.Checked = True Then
            Money = TxtMoney.Text
            SaleCar(DtpSaleDate.Value.ToString, Money, TxtCarInfo.Text, TxtBuyerName.Text, TxtBuyerAdress.Text, TxtBuyerId.Text, TxtBuyerPhone.Text, DgvCarList.CurrentRow.Cells(0).Value, TxtReceipt.Text, TxtInvoice.Text, TxtConfirm.Text, AgreementPath, 0, DgvCarList.CurrentRow.Cells(1).Value)
            Me.Close()

        ElseIf (ChkChange.Checked = True) Then
            If DgvCarList.CurrentRow.Cells(28).Value - TxtMoney.Text >= 0 Then
                Money = DgvCarList.CurrentRow.Cells(28).Value
            Else
                Money = TxtMoney.Text
            End If
            SaleCar(DtpSaleDate.Value.ToString, Money, TxtCarInfo.Text, TxtBuyerName.Text, TxtBuyerAdress.Text, TxtBuyerId.Text, TxtBuyerPhone.Text, DgvCarList.CurrentRow.Cells(0).Value, TxtReceipt.Text, TxtInvoice.Text, TxtConfirm.Text, AgreementPath, 1, TradeSerial)
            Me.Close()

            AddNewCarChange()
        ElseIf (ChkChangeAdd.Checked = True) Then
            Money = DgvCarList.CurrentRow.Cells(28).Value
            SaleCar(DtpSaleDate.Value.ToString, Money, TxtCarInfo.Text, TxtBuyerName.Text, TxtBuyerAdress.Text, TxtBuyerId.Text, TxtBuyerPhone.Text, DgvCarList.CurrentRow.Cells(0).Value, TxtReceipt.Text, TxtInvoice.Text, TxtConfirm.Text, AgreementPath, 1, TradeSerial)
            Me.Close()
            AddNewCarChange()
        ElseIf ChkChangeNon.Checked = True Then
            Money = DgvCarList.CurrentRow.Cells(28).Value
            SaleCar(DtpSaleDate.Value.ToString, Money, TxtCarInfo.Text, TxtBuyerName.Text, TxtBuyerAdress.Text, TxtBuyerId.Text, TxtBuyerPhone.Text, DgvCarList.CurrentRow.Cells(0).Value, TxtReceipt.Text, TxtInvoice.Text, TxtConfirm.Text, AgreementPath, 1, TradeSerial)
            Me.Close()
            AddNewCarChange()
        End If
        ReLoadMain()
        ReloadMainList()
    End Sub

    Private Sub TxtMoney_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMoney.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtBuyerPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuyerPhone.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtBuyerId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuyerId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtMoney_TextChanged(sender As Object, e As EventArgs) Handles TxtMoney.TextChanged
        If ChkChange.Checked = True Then
            TxtCarInfo.Text = "עסקת החלפה על רכב מס " & My.Settings.LocalDataBase & " ביומן + הפרש מחיר " & Me.TxtMoney.Text
        ElseIf ChkChangeAdd.Checked = True Then
            TxtCarInfo.Text = "עסקת החלפה על רכב מס " & My.Settings.LocalDataBase & " ביומן + תוספת מחיר " & Me.TxtMoney.Text
        End If
    End Sub

    Private Sub BtnSelectCustomer_Click(sender As Object, e As EventArgs) Handles BtnSelectCustomer.Click
        FrmCustomers.ShowDialog()
    End Sub

    Private Sub DgvCarList_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCarList.SelectionChanged
        TxtMoney.Text = ""
        TxtInvoice.Text = ""
        TxtReceipt.Text = ""
        TxtBuyerName.Text = ""
        TxtBuyerId.Text = ""
        TxtBuyerAdress.Text = ""
        TxtBuyerPhone.Text = ""
        TxtConfirm.Text = ""
        If ChkChangeNon.Checked = True Then
            TxtMoney.Text = 0
        End If
    End Sub

    Private Sub LblClear_Click(sender As Object, e As EventArgs) Handles LblClear.Click
        TxtFilter.Text = ""
    End Sub

    Private Sub ChkChangeNon_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtReceipt.KeyDown, TxtMoney.KeyDown, TxtInvoice.KeyDown, TxtFilter.KeyDown, TxtConfirm.KeyDown, TxtCarInfo.KeyDown, TxtBuyerPhone.KeyDown, TxtBuyerName.KeyDown, TxtBuyerId.KeyDown, TxtBuyerAdress.KeyDown, DtpSaleDate.KeyDown, DgvCarList.KeyDown, ChkNormal.KeyDown, ChkChangeNon.KeyDown, ChkChangeAdd.KeyDown, ChkChange.KeyDown, BtnSelectCustomer.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
        Dim dv As DataView
        Dim myT As DataTable = MyTab.Copy
        dv = myT.DefaultView
        dv.RowFilter = "CarSerial+CarId+CarKind+CarYear+CarModel+CarType+Mainis like '%" & TxtFilter.Text & "%'"
        DgvCarList.DataSource = myT
        If TxtFilter.Text = "" Then
            DgvCarList.DataSource = MyTab
        End If
    End Sub

    Private Sub GrpMoney_Enter(sender As Object, e As EventArgs) Handles GrpMoney.Enter

    End Sub
End Class