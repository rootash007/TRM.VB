Public Class FrmAddNewCar

    Private Sub FrmAddNewCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String
        Dim ChkSerial As Boolean = False
        BtnAdd.Enabled = True
        VendorsWindow = "AddCar"
        que = "select CarSerial,CarId,CarStatus,Id,Canceled from MainList order by CarSerial"
        FillList(que)
        'For i = 0 To MyTab.Rows.Count - 1
        '    If TxtCarSerial.Text = MyTab.Rows(i).Item(0).ToString Then
        '        ChkSerial = True
        '    End If
        'Next
        'MsgBox(MyTab.Rows.Count)
        TxtCarSerial.Text = My.Settings.LocalDataBase
        TxtCarSerial.Text = MyTab.Rows.Count + 1
        For i = TxtCarSerial.Text - 1 To MyTab.Rows.Count - 1
            If TxtCarSerial.Text = MyTab.Rows(i).Item(0).ToString Then
                TxtCarSerial.Text += 1
                'MsgBox(TxtCarSerial.Text)
            End If
            'MsgBox(TxtCarSerial.Text)

        Next

        My.Settings.LocalDataBase = TxtCarSerial.Text
        My.Settings.Save()
        If BtnAdd.Text = "הוספה" Then
            DtpDateTest.Value = DtpDateTest.Value.AddMonths(1)
            'If ChkSerial = True Then
            '    Dim SerialtMsg As DialogResult
            '    SerialtMsg = MsgBox("מספר ביומן קיים , האם להחליף מס ביומן", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "שגיאה")
            '    If SerialtMsg = vbYes Then
            '        'Me.Close()
            '        FrmCarSerialUpdate.ShowDialog()
            '        '   FmAddNewCar.FrmAddNewCar_Load(Me, e)
            '    End If
            '    BtnAdd.Enabled = False
            'End If
        Else
            'TxtCarSerial.Text = FrmMainList.DgvMain.CurrentRow.Cells(1).Value

        End If
        DtpDatein.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If (TxtCarId.Text = "") Or (My.Settings.EditDataBase = True And CmbCarKind.Text = "") Or (My.Settings.CarType = True And CmbCarType.Text = "") Or (My.Settings.CarColor = True And TxtCarColor.Text = "") Or (My.Settings.CarOil = True And CmbCarOil.Text = "") Or (My.Settings.CarKM = True And TxtCarKM.Text = "") Or (My.Settings.Shelda = True And TxtShelda.Text = "") Or (My.Settings.PriceOut = True And TxtPriceOut.Text = "") Or (My.Settings.CurrentVersion = True And CmbCarModel.Text = "") Or (My.Settings.MainIs = True And CmbMainIs.Text = "") Or (My.Settings.CarGear = True And CmbCarGear.Text = "") Or (My.Settings.Engine = True And TxtEngine.Text = "") Or (My.Settings.CarCode = True And TxtCarCode.Text = "") Or (My.Settings.PriceIn = True And TxtPriceIn.Text = "") Or (My.Settings.SalerName = True And TxtSalerName.Text = "") Or (My.Settings.SalerAdress = True And TxtSalerAdress.Text = "") Or (My.Settings.SalerPhone = True And TxtSalerPhone.Text = "") Or (My.Settings.SalerId = True And TxtSalerId.Text = "") Then
            OkMsgAlert("שדות חובה", "נא להשלים את כל השדות חובה")
            'MsgBox("נא להשלים את כל השדות חובה", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "שדות חובה")
            LoadRequired(Me)
            Return
        End If
        If TxtPriceOut.Text = "" Then
            TxtPriceOut.Text = 0
        End If
        If TxtPriceIn.Text = "" Then
            TxtPriceIn.Text = 0
        End If
        If BtnAdd.Text = "הוספה" Then

            AgreementStatus = "CarBuy"
            LoadAgree()
            FrmAgreementPrint.ShowDialog()
            AddNewCar(TxtCarSerial.Text, TxtCarId.Text, CmbCarKind.Text, CmbCarModel.Text, CmbCarType.Text, NumCarYear.Value, TxtCarColor.Text, NumCarHand.Value, CmbMainIs.Text, CmbCarOil.Text, CmbCarGear.Text, TxtEngine.Text, TxtCarKM.Text, TxtPriceOut.Text, TxtShelda.Text, TxtCarCode.Text, NumKeyNum.Value, DtpDatein.Value.ToShortDateString, DtpDateTest.Value.ToShortDateString, TxtSalerName.Text, TxtSalerId.Text, TxtCarInfo.Text, ChkRoof.Checked, ChkVav.Checked, ChkWheels.Checked, ChkSeats.Checked, TxtPriceIn.Text, TxtSalerAdress.Text, TxtSalerPhone.Text, AgreementPath)
            ReloadMainList()
            If TxtCarSerial.Text = My.Settings.LocalDataBase Then
                My.Settings.LocalDataBase = My.Settings.LocalDataBase + 1
                My.Settings.Save()
            End If
            Me.Close()
        ElseIf BtnAdd.Text = "עדכן" Then
            Dim ExitMsg As DialogResult
            ExitMsg = MsgBox("האם אתה בטוח שברצונך לעדכן רכב", vbYesNo + vbQuestion, "עדכון רכב")
            If ExitMsg = 6 Then
                'UpdateCar(TxtCarId.Text, CmbCarKind.Text, CmbCarModel.Text, CmbCarType.Text, NumCarYear.Value, TxtCarColor.Text, NumCarHand.Value, CmbMainIs.Text, CmbCarOil.Text, CmbCarGear.Text, TxtEngine.Text, TxtCarKM.Text, TxtPriceOut.Text, TxtShelda.Text, TxtCarCode.Text, NumKeyNum.Value, DtpDatein.Value.ToShortDateString, DtpDateTest.Value.ToShortDateString, TxtSalerName.Text, TxtSalerId.Text, TxtCarInfo.Text, ChkRoof.Checked, ChkVav.Checked, ChkWheels.Checked, ChkSeats.Checked, TxtPriceIn.Text, TxtSalerAdress.Text, TxtSalerPhone.Text, FrmMainList.DgvMain.CurrentRow.Cells(0).Value)
                ReloadMainList()
                Me.Close()
            End If
        End If
        ReLoadMain()
    End Sub

    Private Sub BtnSelectVendor_Click(sender As Object, e As EventArgs) Handles BtnSelectVendor.Click
        FrmVendors.ShowDialog()
        'TxtSalerName.Text = venname
        'TxtSalerId.Text = venid
    End Sub

    Private Sub TxtCarId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCarId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtCarId_Leave(sender As Object, e As EventArgs) Handles TxtCarId.Leave
        Dim ChkCarId As Boolean = False
        Dim GetId As Integer
        Dim ChkSD As Boolean = False '**Sold or Deleted**
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

        Else
            OkMsgAlert("שגיאה", "מספר רכב לא תקין")
            'MsgBox("מספר רכב לא תקין", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "שגיאה")
            TxtCarId.Focus()
            Return
        End If
        For i = 0 To MyTab.Rows.Count - 1
            If TxtCarId.Text = MyTab.Rows(i).Item(1).ToString Then
                ChkCarId = True
                If (MyTab.Rows(i).Item(2) = False) Or (MyTab.Rows(i).Item(4) = True) Then
                    ChkSD = True
                    GetId = MyTab.Rows(i).Item(3)
                End If
            End If
        Next
        If ChkCarId = True Then
            If ChkSD = True Then
                Dim ReloadMsg As DialogResult
                ReloadMsg = MsgBox("מספר רכב זה נמצא בעבר , האם לשכפל נתונים", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "רכב קיים")
                If ReloadMsg = vbYes Then
                    LoadFromSold(GetId)
                End If
            Else
                OkMsgAlert("רכב קיים", "מספר רכב קיים במערכת")
                'MsgBox("מספר רכב קיים במערכת", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "רכב קיים")
                TxtCarId.Focus()
            End If
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

    Private Sub TxtEngine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEngine.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtCarKM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCarKM.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtPriceOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPriceOut.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtPriceIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPriceIn.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtSalerId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalerId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtSalerPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalerPhone.KeyPress
        NumbersOnly(e)
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

    Private Sub LblShowPrice_Click(sender As Object, e As EventArgs) Handles LblShowPrice.Click
        If AdminMode = True Then
            If LblShowPrice.Text = "הצג מחיר" Then
                TxtPriceIn.Visible = True
                LblShowPrice.Text = "הסתר מחיר"
            ElseIf LblShowPrice.Text = "הסתר מחיר" Then
                TxtPriceIn.Visible = False
                LblShowPrice.Text = "הצג מחיר"
            End If
        Else
            OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו")
            'MsgBox("אין לך הרשאה לפעולה זו", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "אין הרשאה")
        End If
    End Sub

    Private Sub BtnBuyAgreement_Click(sender As Object, e As EventArgs) Handles BtnBuyAgreement.Click
        Try
            'If FrmMainList.DgvMain.CurrentRow.Cells(42).Value = "" Then
            '    OkMsgAlert("הסכם קנייה", "אין הסכם קנייה")
            '    'MsgBox("אין הסכם קנייה", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "הסכם קנייה")
            'Else
            '    Process.Start(FrmMainList.DgvMain.CurrentRow.Cells(42).Value)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DtpDateTest_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtShelda.KeyDown, TxtSalerPhone.KeyDown, TxtSalerName.KeyDown, TxtSalerId.KeyDown, TxtSalerAdress.KeyDown, TxtPriceOut.KeyDown, TxtPriceIn.KeyDown, TxtEngine.KeyDown, TxtCarSerial.KeyDown, TxtCarKM.KeyDown, TxtCarInfo.KeyDown, TxtCarId.KeyDown, TxtCarColor.KeyDown, TxtCarCode.KeyDown, NumKeyNum.KeyDown, NumCarYear.KeyDown, NumCarHand.KeyDown, MyBase.KeyDown, DtpDateTest.KeyDown, DtpDatein.KeyDown, CmbMainIs.KeyDown, CmbCarType.KeyDown, CmbCarOil.KeyDown, CmbCarModel.KeyDown, CmbCarKind.KeyDown, CmbCarGear.KeyDown, ChkWheels.KeyDown, ChkVav.KeyDown, ChkSeats.KeyDown, ChkRoof.KeyDown, BtnSelectVendor.KeyDown, BtnCancel.KeyDown, BtnBuyAgreement.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            If BtnCancel.Enabled = True Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LblCarKTM_Click(sender As Object, e As EventArgs) Handles LblCarKTM.Click
        Dim FmCarKMT As New FrmCarKMT
        FmCarKMT.ShowDialog()
    End Sub

    Private Sub TxtCarSerial_Leave(sender As Object, e As EventArgs) Handles TxtCarSerial.Leave
        Dim ChkCarSerial As Boolean = False
        For i = 0 To MyTab.Rows.Count - 1
            If TxtCarSerial.Text = MyTab.Rows(i).Item(0).ToString Then
                ChkCarSerial = True
            End If
        Next
        If ChkCarSerial = True Then
            OkMsgAlert("מספר ביומן קיים", "מספר ביומן בשימוש")
            'Dim SerialtMsg As DialogResult
            'SerialtMsg = MsgBox("מספר ביומן קיים , האם להחליף מס ביומן", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "שגיאה")

            'If SerialtMsg = vbYes Then
            '    'Me.Close()
            '    FrmCarSerialUpdate.ShowDialog()
            '    FmAddNewCar.TxtCarSerial.Text = FrmCarSerialUpdate.TxtNewCarSerial.Text
            'End If
            'BtnAdd.Enabled = False


        End If
        'Else
        'OkMsgAlert("רכב קיים", "מספר רכב קיים במערכת")
        ''MsgBox("מספר רכב קיים במערכת", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "רכב קיים")
        'TxtCarId.Focus()
        'End If
        'End If
    End Sub
End Class