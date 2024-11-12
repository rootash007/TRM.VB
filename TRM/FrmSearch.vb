Public Class FrmSearch

    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadStatusOn.Select()
        'TCWindow = "Search"
        SoldCardWinDow = "Search"
        NumFromYear.Value = Today.Year - 20
        NumToYear.Value = Today.Year
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Dim que As String
        que = "select * from MainList where CarYear >= " & NumFromYear.Value & " and CarYear <=  " & NumToYear.Value & " and Canceled = 0 "

        If RadStatusOn.Checked = True Then
            que = que & " and CarStatus = 1 "
        ElseIf RadStatusOff.Checked = True Then
            que = que & " and CarStatus = 0 "
        End If

        If TxtCarSerial.Text <> "" Then
            que = que & " and CarSerial = " & TxtCarSerial.Text & " "
        End If

        If TxtCarId.Text <> "" Then
            que = que & " and CarId like '%" & TxtCarId.Text & "%'"
            'que = que & " and CarId = '" & TxtCarId.Text & "' "
        End If

        If CmbCarKind.Text <> "" Then
            que = que & " and CarKind = CarKind "

        End If

        If CmbCarModel.Text <> "" Then
            que = que & " and CarModel = '" & CmbCarModel.Text & "' "
        End If

        If CmbCarType.Text <> "" Then
            que = que & " and CarType = '" & CmbCarType.Text & "' "
        End If

        If CmbCarOil.Text <> "" Then
            que = que & " and CarOil = '" & CmbCarOil.Text & "' "
        End If

        If CmbMainIs.Text <> "" Then
            que = que & " and MainIs = '" & CmbMainIs.Text & "' "
        End If

        If TxtBuyerName.Text <> "" Then
            'que = que & " and BuyerName like '%" & TxtBuyerName.Text & "%' "
            que = que & " and BuyerName = BuyerName  "

        End If

        If TxtSalerName.Text <> "" Then
            Dim SalerName As String = TxtSalerName.Text
            que = que & " and SalerName = SalerName "
            'MsgBox(Len(TxtSalerName.Text))
            'que = que & " and SalerName like '%" & TxtSalerName.Text & "%' "

        End If

        Try
            FillList(que)
            DgvResults.DataSource = MyTab
            DesignSoldDGV(Me.DgvResults)
            ' DesignMainDGV(Me.DgvResults)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtCarSerial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCarSerial.KeyPress, TxtCarId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtCarId_Leave(sender As Object, e As EventArgs) Handles TxtCarId.Leave
        If TxtCarId.TextLength = 7 Then
            Dim Carid As String
            Carid = TxtCarId.Text.Insert(2, "-")
            Carid = Carid.Insert(6, "-")
            TxtCarId.Text = Carid
        ElseIf TxtCarId.TextLength = 8 Then
            Dim Carid As String
            Carid = TxtCarId.Text.Insert(3, "-")
            Carid = Carid.Insert(6, "-")
            TxtCarId.Text = Carid
        ElseIf TxtCarId.TextLength = 0 Then

            'Else
            '    OkMsgAlert("שגיאה", "מספר רכב לא תקין")
        End If
    End Sub

    Private Sub TxtCarId_Enter(sender As Object, e As EventArgs) Handles TxtCarId.Enter
        If TxtCarId.Text <> "" Then
            If TxtCarId.TextLength = 9 Then
                Dim CarId As String
                CarId = TxtCarId.Text.Remove(2, 1)
                CarId = CarId.Remove(5, 1)
                TxtCarId.Text = CarId
            ElseIf TxtCarId.TextLength = 10 Then
                Dim Carid As String
                Carid = TxtCarId.Text.Remove(3, 1)
                Carid = Carid.Remove(5, 1)
                TxtCarId.Text = Carid
            End If
        End If
    End Sub

    Private Sub CmbCarKind_Enter(sender As Object, e As EventArgs) Handles CmbCarKind.Enter
        LoadCarKind()
        Me.CmbCarKind.DataSource = MyTab
        Me.CmbCarKind.DisplayMember = "Carkind"
        Me.CmbCarKind.ValueMember = "carkindid"
    End Sub

    Private Sub CmbCarModel_Enter(sender As Object, e As EventArgs) Handles CmbCarModel.Enter
        LoadCarmodel(CmbCarKind.SelectedValue)
        Me.CmbCarModel.DataSource = MyTab
        Me.CmbCarModel.DisplayMember = "Carmodel"
        Me.CmbCarModel.ValueMember = "carmodelid"
    End Sub

    Private Sub CmbCarType_Enter(sender As Object, e As EventArgs) Handles CmbCarType.Enter
        LoadCartype(CmbCarModel.SelectedValue, CmbCarKind.SelectedValue)
        Me.CmbCarType.DataSource = MyTab
        Me.CmbCarType.DisplayMember = "cartype"
        Me.CmbCarType.ValueMember = "cartypeid"
    End Sub

    Private Sub CmbCarKind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCarKind.SelectedIndexChanged
        CmbCarModel.Text = ""
        CmbCarType.Text = ""
    End Sub

    Private Sub CmbCarModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCarModel.SelectedIndexChanged
        CmbCarType.Text = ""
    End Sub

    Private Sub LblClear_Click(sender As Object, e As EventArgs) Handles LblClear.Click
        TxtCarSerial.Text = ""
        TxtCarId.Text = ""
        NumFromYear.Value = Today.Year - 20
        NumToYear.Value = Today.Year
        CmbCarKind.ResetText()
        CmbCarModel.ResetText()
        CmbCarType.ResetText()
        CmbCarOil.ResetText()
        CmbMainIs.ResetText()
        TxtBuyerName.Text = ""
        TxtSalerName.Text = ""

    End Sub

    Private Sub DgvResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvResults.CellDoubleClick
        'FrmSoldCard.ShowDialog()
        FmSoldCard = New FrmSoldCard
        FmSoldcard.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnTC_Click(sender As Object, e As EventArgs) Handles BtnTC.Click
        If DgvResults.RowCount > 0 Then
            If AdminMode = True Then
                TCWindow = "Search"
                FmTransactionCancel = New FrmMaterialsImportExcel
                FmTransactionCancel.ShowDialog()

                '    'FrmTransactionCancel.ShowDialog()
            Else
                OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו")
                'MsgBox("אין לך הרשאה לפעולה זו", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "אין הרשאה")
            End If
        Else
            OkMsgInfo("אין בחירה", "רשימת רכבים ריקה")
        End If
    End Sub
End Class