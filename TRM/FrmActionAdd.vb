Public Class FrmActionAdd
    Dim ActionTypeTab As DataTable
    Dim isIncrease As Boolean
    Dim OldActionType As Boolean
    Dim OldQuantity As Double
    Private Sub FrmActionAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FmActions.SelectedRow = FmActions.DgvActionsList.CurrentRow.Index
        Dim que As String
        If AdminMode = True Then
            DTPDate.Visible = True
            DTPDate.Value = Now
        Else
            DTPDate.Visible = False
        End If
        If ActiveLvl < 3 Then
            que = "select * from action_types"
        ElseIf ActiveLvl = 3 Then
            que = "select * from action_types where isincrease = 0"
        Else
            que = "select * from action_types where isincrease = 1"
        End If
        FillList(que)
        ActionTypeTab = MyTab
        Me.CmbActionType.DataSource = ActionTypeTab
        Me.CmbActionType.DisplayMember = "action_type_name"
        Me.CmbActionType.ValueMember = "isincrease"
        que = "select * from materials where material_isactive = 1"
        FillList(que)
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

        End If


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
            If CmbActionType.Text = "" Then
                MsgBox("choose action type please", vbOKOnly + vbInformation, "alert")
                Return
            End If

            If CmbActionType.SelectedValue = True Then
                If CmbMaterialName.Text = "" Then
                    MsgBox("name is requierd", vbOKOnly + vbCritical, "message")
                    Return
                ElseIf CmbLocBarcode.Text = "" Then
                    MsgBox("local barcode is requierd", vbOKOnly + vbInformation, "message")
                    Return
                ElseIf NumQuantity.Value = 0 Then
                    MsgBox("quantity cannot be 0 ", vbOKOnly + vbInformation, "message")
                    Return
                End If
                Dim que As String = "select * from materials where material_loc_barcode = @loc_barcode" ' & CmbLocBarcode.Text & ""
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
                    MsgBox("name is requierd", vbOKOnly + vbCritical, "message")
                    Return
                ElseIf CmbLocBarcode.Text = "" Then
                    MsgBox("local barcode is requierd", vbOKOnly + vbInformation, "message")
                    Return
                ElseIf Txtbarcode.Text = "" Then
                    MsgBox("barcode is requierd ", vbOKOnly + vbInformation, "message")
                    Return
                ElseIf NumQuantity.Value = 0 Then
                    MsgBox("quantity cannot be 0 ", vbOKOnly + vbInformation, "message")
                    Return
                ElseIf TxtBlockNumber.Text = "" Then
                    MsgBox("block number is requierd ", vbOKOnly + vbInformation, "message")
                    Return
                ElseIf TxtVendor.Text = "" Then
                    MsgBox("vendor is requierd ", vbOKOnly + vbInformation, "message")
                    Return
                ElseIf TxtOrder.Text = "" Then
                    MsgBox("order number is requierd ", vbOKOnly + vbInformation, "message")
                    Return
                End If
                'MsgBox(isIncrease)
                Dim que As String = "select * from materials where material_loc_barcode = @loc_barcode" ' & CmbLocBarcode.Text & ""
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
                    AddAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, ActiveUser, CmbActionType.Text, NumQuantity.Value, DTPDate.Value, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue)
                Else
                    EditAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, CmbActionType.Text, NumQuantity.Value, DTPDate.Value, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue, FmActions.DgvActionsList.CurrentRow.Cells(0).Value)
                    ' admin edit
                End If
            Else
                If isAddAction = True Then
                    AddAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, ActiveUser, CmbActionType.Text, NumQuantity.Value, Now, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue)
                Else
                    EditAction(CmbMaterialName.Text, CmbLocBarcode.Text, Txtbarcode.Text, TxtBlockNumber.Text, CmbActionType.Text, NumQuantity.Value, FmActions.DgvActionsList.CurrentRow.Cells(7).Value, TxtVendor.Text, TxtOrder.Text, TxtMoreInfo.Text, NewQuantity, CmbActionType.SelectedValue, FmActions.DgvActionsList.CurrentRow.Cells(0).Value)

                    ' edit
                End If
            End If
            FmActions.FrmActions_Load(0, e)
            FmMaterials.FrmMaterials_Load(0, e)
            If FmActions.DgvActionsList.RowCount > 0 Then FmActions.DgvActionsList.CurrentCell = FmActions.DgvActionsList.Rows(FmActions.SelectedRow).Cells(1)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub LblQuantity_Click(sender As Object, e As EventArgs) Handles LblQuantity.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class