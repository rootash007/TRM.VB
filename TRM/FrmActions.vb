Public Class FrmActions

    'Dim IsIncrease As Boolean

    Public Sub FrmActions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AdminMode = True Then
            BtnEditAction.Visible = True
            BtnDeleteAction.Visible = True
        Else
            BtnEditAction.Visible = False
            BtnDeleteAction.Visible = False
        End If
        DTPStartDate.Value = Today
        DTPEndDate.Value = Today.AddHours(23).AddMinutes(59).AddSeconds(59)
        CBInActions.Checked = True
        CBOutActions.Checked = True

        Dim que As String = "select * from users where user_isactive = 1"
        FillList(que)
        CmbUserName.DataSource = MyTab
        CmbUserName.DisplayMember = "user_name"
        CmbUserName.ValueMember = "id"
        CmbUserName.SelectedIndex = -1

        que = "select * from materials where material_isactive = 1"
        FillList(que)

        CmbMaterial.DataSource = MyTab
        CmbMaterial.DisplayMember = "material_name"
        CmbMaterial.ValueMember = "id"
        CmbMaterial.SelectedIndex = -1

        ReloadActions()


    End Sub

    Private Sub BtnAddAction_Click(sender As Object, e As EventArgs) Handles BtnAddAction.Click
        isAddAction = True
        FmActionAdd = New FrmActionAdd
        FmActionAdd.ShowDialog()
    End Sub

    Public Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click

        ReloadActions()

    End Sub

    Private Sub DTPEndDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPEndDate.ValueChanged
        If DTPStartDate.Value > DTPEndDate.Value Then
            DTPEndDate.Value = DTPStartDate.Value.AddHours(23).AddMinutes(59).AddSeconds(59)
            MsgBox("end date smaller than start date", vbOKOnly + vbCritical, "error")
        End If
    End Sub

    Private Sub DTPStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPStartDate.ValueChanged
        If DTPStartDate.Value > DTPEndDate.Value Then
            DTPEndDate.Value = DTPStartDate.Value.AddHours(23).AddMinutes(59).AddSeconds(59)
        End If
    End Sub





    Private Sub BtnExportToExcel_Click(sender As Object, e As EventArgs) Handles BtnExportToExcel.Click
        If FmActions.DgvActionsList.RowCount = 0 Then
            MsgBox("the list is empty", vbOKOnly + vbCritical, "message")
            Return

            'Dim ExitMsg As DialogResult
            'ExitMsg = MsgBox("לא בחרת דוח משמרות , האם להמשיך ללא דוח משמרות", vbYesNo + vbQuestion, "דוח משמרות")
            'If ExitMsg = vbNo Then
            '    Exit Sub
            'End If

        End If
        ExportActionsToExcel()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DTPEndDate_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtVendor.KeyDown, DTPStartDate.KeyDown, DTPEndDate.KeyDown, DgvActionsList.KeyDown, CmbUserName.KeyDown, CmbMaterial.KeyDown, CBOutActions.KeyDown, CBInActions.KeyDown, BtnEditAction.KeyDown, BtnReload.KeyDown, BtnExportToExcel.KeyDown, BtnDeleteAction.KeyDown, BtnClose.KeyDown, BtnAddAction.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub BtnEditAction_Click(sender As Object, e As EventArgs) Handles BtnEditAction.Click
        isAddAction = False
        FmActionAdd = New FrmActionAdd
        FmActionAdd.ShowDialog()
    End Sub

    Private Sub BtnDeleteAction_Click(sender As Object, e As EventArgs) Handles BtnDeleteAction.Click
        If DgvActionsList.RowCount = 0 Then
            MsgBox("list is empty", vbOKOnly + vbInformation, "message")
        Else
            Dim DelMsg As DialogResult
            DelMsg = MsgBox("هل انت متأكد انك تريد حذف العملية", vbYesNo + vbQuestion, "حذف")
            If DelMsg = 6 Then
                DeleteAction(DgvActionsList.CurrentRow.Cells(0).Value)
                'FrmActions_Load(Me, e)
                ReloadActions()
            End If

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class