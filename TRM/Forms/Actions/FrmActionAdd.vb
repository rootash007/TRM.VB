Imports System.Reflection

Public Class FrmActionAdd
    Dim ActionTypeTab As DataTable
    Dim MaterialTab As DataTable
    Dim isIncrease As Boolean
    Dim OldActionType As Boolean
    Dim OldQuantity As Double
    Dim ActionID As Integer
    Private Sub FrmActionAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If FmActions.DgvActionsList.RowCount > 0 Then FmActions.SelectedRow = FmActions.DgvActionsList.CurrentRow.Index
            Dim que As String
            Dim Increase As Boolean = isAllowed(2)
            Dim Decrease As Boolean = isAllowed(3)
            If AdminMode = True Then
                DTPDate.Visible = True
                DTPDate.Value = Now
                GrpPrice.Visible = True
            Else
                DTPDate.Visible = False
                If isAllowed(10) = True And Increase = True Then
                    GrpPrice.Visible = True
                Else
                    GrpPrice.Visible = False
                End If
            End If


            If AdminMode = True Or (Increase = True And Decrease = True) Then
                que = "select * from action_types"
            ElseIf Increase = True And Decrease = False Then
                que = "select * from action_types where isincrease = 1"
            ElseIf Increase = False And Decrease = True Then
                que = "select * from action_types where isincrease = 0"
            ElseIf Increase = False And Decrease = False Then
                Me.Close()
            End If
            FillList(que)
            'ActionTypeTab = MyTab
            'Me.CmbActionType.DataSource = ActionTypeTab
            Me.CmbActionType.DataSource = MyTab

            Me.CmbActionType.DisplayMember = "action_type_name"
            Me.CmbActionType.ValueMember = "isincrease"
            que = "select * from materials where material_isactive = 1"
            FillList(que)
            MaterialTab = MyTab
            Me.CmbMaterialName.DataSource = MyTab
            Me.CmbMaterialName.DisplayMember = "material_name"
            Me.CmbMaterialName.ValueMember = "material_loc_barcode"
            CmbMaterialName.Text = ""

            Me.CmbLocBarcode.DataSource = MyTab
            Me.CmbLocBarcode.DisplayMember = "material_loc_barcode"
            Me.CmbLocBarcode.ValueMember = "material_name"
            If isAddAction = True Then
                Try
                    CmbActionType.SelectedIndex = -1
                    CmbMaterialName.SelectedIndex = 0
                    CmbLocBarcode.SelectedIndex = -1
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                If ActionSender = "FmActions" Then
                    ActionID = FmActions.DgvActionsList.CurrentRow.Cells(0).Value
                    CmbMaterialName.Text = FmActions.DgvActionsList.CurrentRow.Cells(1).Value
                    CmbLocBarcode.Text = FmActions.DgvActionsList.CurrentRow.Cells(2).Value
                    Txtbarcode.Text = FmActions.DgvActionsList.CurrentRow.Cells(3).Value
                    TxtBlockNumber.Text = FmActions.DgvActionsList.CurrentRow.Cells(4).Value
                    CmbActionType.Text = FmActions.DgvActionsList.CurrentRow.Cells(12).Value
                    NumQuantity.Value = FmActions.DgvActionsList.CurrentRow.Cells(6).Value
                    TxtVendor.Text = FmActions.DgvActionsList.CurrentRow.Cells(8).Value
                    TxtOrder.Text = FmActions.DgvActionsList.CurrentRow.Cells(9).Value
                    TxtMoreInfo.Text = FmActions.DgvActionsList.CurrentRow.Cells(10).Value
                    DTPDate.Value = FmActions.DgvActionsList.CurrentRow.Cells(7).Value
                    OldActionType = FmActions.DgvActionsList.CurrentRow.Cells(11).Value
                    OldQuantity = FmActions.DgvActionsList.CurrentRow.Cells(6).Value
                    'If FmActions.DgvActionsList.CurrentRow.Cells(13).Value Is Nothing OrElse FmActions.DgvActionsList.CurrentRow.Cells(13).Value.ToString.Trim = "" Then
                    '    MsgBox("is nothing")
                    'Else
                    '    MsgBox("else")
                    'End If
                    NumPrice.Value = FmActions.DgvActionsList.CurrentRow.Cells(13).Value
                ElseIf ActionSender = "FmCosts" Then
                        ActionID = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(0).Value
                    CmbMaterialName.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(1).Value
                    CmbLocBarcode.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(2).Value
                    Txtbarcode.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(3).Value
                    TxtBlockNumber.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(4).Value
                    CmbActionType.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(12).Value
                    NumQuantity.Value = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(6).Value
                    TxtVendor.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(8).Value
                    TxtOrder.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(9).Value
                    TxtMoreInfo.Text = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(10).Value
                    DTPDate.Value = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(7).Value
                    OldActionType = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(11).Value
                    OldQuantity = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(6).Value
                    NumPrice.Value = FmCostsList.DGV1.Rows(ActionRowIndex).Cells(13).Value
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbMaterialName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterialName.SelectedIndexChanged
        If CmbMaterialName.Text <> "" Then
            CmbLocBarcode.Text = CmbMaterialName.SelectedValue.ToString
        Else
            CmbLocBarcode.SelectedIndex = -1
        End If
        'MsgBox(CmbMaterialName.ValueMember)
    End Sub

    Private Sub CmbLocBarcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLocBarcode.SelectedIndexChanged
        If CmbLocBarcode.Text <> "" Then
            CmbMaterialName.Text = CmbLocBarcode.SelectedValue.ToString
        Else
            CmbMaterialName.SelectedIndex = -1
        End If
    End Sub

    Private Sub CmbActionType_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBlockNumber.KeyDown, Txtbarcode.KeyDown, TxtMoreInfo.KeyDown, TxtOrder.KeyDown, TxtVendor.KeyDown, NumQuantity.KeyDown, CmbMaterialName.KeyDown, CmbLocBarcode.KeyDown, CmbActionType.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnSave_Click(Me, e)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim NewQuantity As Double
            Dim que As String
            If CmbActionType.Text = "" Then
                MsgBox("الرجاء اختيار نوع العملية", vbOKOnly + vbInformation, "استعلام")
                Return
            End If

            If CmbActionType.SelectedValue = True Then
                If CmbMaterialName.Text = "" Then
                    MsgBox("الرجاء ادخال اسم المادة", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf CmbLocBarcode.Text = "" Then
                    MsgBox("الرجاء ادخال الرمز المحلي", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf NumQuantity.Value = 0 Then
                    MsgBox("الرجاء ادخال الكمية", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf NumPrice.Value = 0 Then
                    'Dim que As String

                    que = "SELECT * FROM material_prices WHERE material_id IN (SELECT id FROM materials where material_name = '" & CmbMaterialName.Text & "')"
                    FillList(que)
                    If MyTab.Rows.Count > 0 Then
                        'MsgBox(MyTab.Rows.Count)
                        'MsgBox(que)
                        MsgBox("الرجاء ادخال السعر", vbOKOnly + vbInformation, "استعلام")
                        Return
                    End If
                End If
                'Dim que As String

                que = "select * from materials where material_loc_barcode = @loc_barcode" ' & CmbLocBarcode.Text & ""
                FillQuantity(que, CmbLocBarcode.Text)



                If isAddAction = True Then
                    NewQuantity = MyTab.Rows(0).Item(4) + NumQuantity.Value
                Else
                    If OldActionType = True Then
                        'MsgBox("was in still in")
                        NewQuantity = MyTab.Rows(0).Item(4) - OldQuantity + NumQuantity.Value
                    Else
                        'MsgBox("was out changed to in")
                        NewQuantity = MyTab.Rows(0).Item(4) + OldQuantity + NumQuantity.Value
                    End If
                End If

                'NewQuantity = MyTab.Rows(0).Item(4) + NumQuantity.Value



            ElseIf CmbActionType.SelectedValue = False Then
                If CmbMaterialName.Text = "" Then
                    MsgBox("الرجاء ادخال اسم المادة", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf CmbLocBarcode.Text = "" Then
                    MsgBox("الرجاء ادخال الرمز المحلي", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf Txtbarcode.Text = "" Then
                    MsgBox("الرجاء ادخال الرمز", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf NumQuantity.Value = 0 Then
                    MsgBox("الرجاء ادخال الكمية", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf TxtBlockNumber.Text = "" Then
                    MsgBox("الرجاء ادخال رقم المشتاح", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf TxtVendor.Text = "" Then
                    MsgBox("الرجاء ادخال اسم المورد", vbOKOnly + vbInformation, "استعلام")
                    Return
                ElseIf TxtOrder.Text = "" Then
                    MsgBox("الرجاء ادخال رقم الطلبية", vbOKOnly + vbInformation, "استعلام")
                    Return
                End If
                'MsgBox(isIncrease)
                que = "select * from materials where material_loc_barcode = @loc_barcode" ' & CmbLocBarcode.Text & ""
                FillQuantity(que, CmbLocBarcode.Text)

                If isAddAction = True Then
                    NewQuantity = MyTab.Rows(0).Item(4) - NumQuantity.Value
                Else
                    If OldActionType = True Then
                        'MsgBox("was in changed to out")
                        NewQuantity = MyTab.Rows(0).Item(4) - OldQuantity - NumQuantity.Value
                    Else
                        'MsgBox("was out still out")
                        NewQuantity = MyTab.Rows(0).Item(4) + OldQuantity - NumQuantity.Value
                    End If
                End If

                'NewQuantity = MyTab.Rows(0).Item(4) - NumQuantity.Value


            End If
            If AdminMode = True Then
                If isAddAction = True Then
                    AddAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, ActiveUser, CmbActionType.Text, NumQuantity.Value, DTPDate.Value, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue, NumPrice.Value)
                Else
                    EditAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, CmbActionType.Text, NumQuantity.Value, DTPDate.Value, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue, ActionID, NumPrice.Value)
                    ' admin edit
                End If
            Else
                If isAddAction = True Then
                    AddAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, ActiveUser, CmbActionType.Text, NumQuantity.Value, Now, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue, NumPrice.Value)
                Else
                    EditAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, CmbActionType.Text, NumQuantity.Value, FmActions.DgvActionsList.CurrentRow.Cells(7).Value, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue, ActionID, NumPrice.Value)

                    ' edit
                End If
            End If
            'FmMaterials.FrmMaterials_Load(0, e)
            If ActionSender = "FmCosts" Then
                YearReLoad(FmCostsList.DTPStartDate.Value, FmCostsList.DTPEndDate.Value)
                FmCostsList.DGVCostList.CurrentCell = FmCostsList.DGVCostList.Rows(CostsSelectedRow).Cells(0)
                FmCostsList.BtnCloseActions.Visible = True
                FmCostsList.DGVActions.Rows.Clear()
                For i = 0 To FmCostsList.DGV1.RowCount - 1
                    If FmCostsList.DGV1.Rows(i).Cells(1).Value = FmCostsList.DGVCostList.CurrentRow.Cells(0).Value Then
                        FmCostsList.DGVActions.Rows.Add()
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(0).Value = FmCostsList.DGV1.Rows(i).Cells(1).Value
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(1).Value = FmCostsList.DGV1.Rows(i).Cells(2).Value
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(2).Value = FmCostsList.DGV1.Rows(i).Cells(5).Value
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(3).Value = FmCostsList.DGV1.Rows(i).Cells(6).Value
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(4).Value = FmCostsList.DGV1.Rows(i).Cells(7).Value
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(5).Value = FmCostsList.DGV1.Rows(i).Cells(9).Value
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(6).Value = FmCostsList.DGV1.Rows(i).Cells(13).Value
                        FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).Cells(7).Value = FmCostsList.DGV1.Rows(i).Cells(0).Value
                        If FmCostsList.DGV1.Rows(i).Cells(13).Value = 0 Then
                            FmCostsList.DGVActions.Rows(FmCostsList.DGVActions.RowCount - 1).DefaultCellStyle.BackColor = Color.LightPink
                        End If
                    End If
                Next
                FmCostsList.DGVActions.CurrentCell = FmCostsList.DGVActions.Rows(ActionSelectedRow).Cells(0)

                'FmCostsList.DGVActions.Columns(4).DefaultCellStyle.Format = "dd/MM/yyyy"
                'FmCostsList.DGVActions.ClearSelection()
            ElseIf ActionSender = "FmActions" Then
                FmActions.FrmActions_Load(0, e)
            End If
            If FmActions.DgvActionsList.RowCount > 0 Then FmActions.DgvActionsList.CurrentCell = FmActions.DgvActionsList.Rows(FmActions.SelectedRow).Cells(1)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub


    Private Sub NumQuantity_Enter(sender As Object, e As EventArgs) Handles NumQuantity.Enter
        NumQuantity.Select(0, NumQuantity.Text.Length)
    End Sub

    Private Sub CmbMaterialName_Leave(sender As Object, e As EventArgs) Handles CmbMaterialName.Leave
        If CmbMaterialName.Text <> "" Then
            Dim isFound As Boolean = False
            For i = 0 To MaterialTab.Rows.Count - 1
                If CmbMaterialName.Text = MaterialTab.Rows(i).Item(1) Then
                    isFound = True
                    CmbLocBarcode.Text = MaterialTab.Rows(i).Item(3)
                    GoTo Found
                    'Exit Sub
                End If
            Next
Found:
            If isFound = False Then
                MsgBox("اسم المادة غير موجود في قاعدة البيانات", vbOKOnly + vbCritical, "خطاء")
                CmbMaterialName.Text = ""
                CmbMaterialName.Focus()
                Return
            End If
        End If
    End Sub

    Private Sub CmbLocBarcode_Leave(sender As Object, e As EventArgs) Handles CmbLocBarcode.Leave
        If CmbLocBarcode.Text <> "" Then
            Dim isFound As Boolean = False
            For i = 0 To MaterialTab.Rows.Count - 1
                If CmbLocBarcode.Text = MaterialTab.Rows(i).Item(3) Then
                    isFound = True
                    CmbMaterialName.Text = MaterialTab.Rows(i).Item(1)
                    GoTo Found
                    'Exit Sub
                End If
            Next
Found:
            If isFound = False Then
                MsgBox("الرمز المحلي غير موجود في قاعدة البيانات", vbOKOnly + vbCritical, "خطاء")
                CmbLocBarcode.Text = ""
                CmbLocBarcode.Focus()
                Return
            End If
        End If
    End Sub


End Class