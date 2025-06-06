﻿Public Class FrmActions

    'Dim IsIncrease As Boolean
    Public SelectedRow As Integer = 0

    Public Sub FrmActions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        If DgvActionsList.RowCount > 0 Then DgvActionsList.CurrentCell = DgvActionsList.Rows(SelectedRow).Cells(1)

        If AdminMode = True Then
            BtnEditAction.Visible = True
            BtnDeleteAction.Visible = True
        Else
            If isAllowed(4) = True Then
                BtnEditAction.Visible = True
            Else
                BtnEditAction.Visible = False
            End If
            If isAllowed(5) = True Then
                BtnDeleteAction.Visible = True
            Else
                BtnDeleteAction.Visible = False
            End If

        End If

        'DTPStartDate.Value = Today
        'DTPEndDate.Value = Today.AddHours(23).AddMinutes(59).AddSeconds(59)
        'CBInActions.Checked = True
        'CBOutActions.Checked = True

        'Dim que As String = "select * from users where user_isactive = 1"
        'FillList(que)
        'CmbUserName.DataSource = MyTab
        'CmbUserName.DisplayMember = "user_name"
        'CmbUserName.ValueMember = "id"
        'CmbUserName.SelectedIndex = -1

        'que = "select * from materials where material_isactive = 1"
        'FillList(que)

        'CmbMaterial.DataSource = MyTab
        'CmbMaterial.DisplayMember = "material_name"
        'CmbMaterial.ValueMember = "id"
        'CmbMaterial.SelectedIndex = -1

        ReloadActions()


    End Sub

    Private Sub BtnAddAction_Click(sender As Object, e As EventArgs) Handles BtnAddAction.Click
        Dim Increase As Boolean = isAllowed(2)
        Dim Decrease As Boolean = isAllowed(3)
        If AdminMode = True Then
            isAddAction = True
            FmActionAdd = New FrmActionAdd
            FmActionAdd.ShowDialog()
        Else
            If Increase = True Or Decrease = True Then
                isAddAction = True
                FmActionAdd = New FrmActionAdd
                FmActionAdd.ShowDialog()
            Else
                OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
            End If
        End If

        'isAddAction = True
        'FmActionAdd = New FrmActionAdd
        'FmActionAdd.ShowDialog()
        'SelectedRow = DgvActionsList.CurrentRow.Index
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




    Private Sub BtnEditAction_Click(sender As Object, e As EventArgs) Handles BtnEditAction.Click
        'Dim Increase As Boolean = isAlowed(4)
        'Dim Decrease As Boolean = isAlowed(3)
        'If AdminMode = True Then
        '    If DgvActionsList.RowCount = 0 Then
        '        MsgBox("list is empty", vbOKOnly + vbInformation, "message")
        '    Else
        '        isAddAction = False
        '        FmActionAdd = New FrmActionAdd
        '        FmActionAdd.ShowDialog()
        '    End If
        'Else
        '    If isAlowed(4) = True Then
        '        If DgvActionsList.RowCount = 0 Then
        '            MsgBox("list is empty", vbOKOnly + vbInformation, "message")
        '        Else
        '            isAddAction = False
        '            FmActionAdd = New FrmActionAdd
        '            FmActionAdd.ShowDialog()
        '        End If
        '    Else
        '        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
        '    End If
        'End If

        If DgvActionsList.RowCount = 0 Then
            'MsgBox("القائمة فارغة", vbOKOnly + vbInformation, "رساله")
        Else
            isAddAction = False
            ActionSender = "FmActions"
            FmActionAdd = New FrmActionAdd
            FmActionAdd.ShowDialog()
        End If
    End Sub

    Private Sub BtnDeleteAction_Click(sender As Object, e As EventArgs) Handles BtnDeleteAction.Click
        If DgvActionsList.RowCount = 0 Then
            MsgBox("list is empty", vbOKOnly + vbInformation, "message")
        Else
            Dim DelMsg As DialogResult
            DelMsg = MsgBox("هل انت متأكد انك تريد حذف العملية", vbYesNo + vbQuestion, "حذف")
            If DelMsg = 6 Then
                Dim NewQuantity As Double
                Dim que As String = "select * from materials where material_loc_barcode = @loc_barcode" ' & CmbLocBarcode.Text & ""
                FillQuantity(que, DgvActionsList.CurrentRow.Cells(2).Value)
                If DgvActionsList.CurrentRow.Cells(11).Value = True Then
                    NewQuantity = MyTab.Rows(0).Item(4) - DgvActionsList.CurrentRow.Cells(6).Value

                Else
                    NewQuantity = MyTab.Rows(0).Item(4) + DgvActionsList.CurrentRow.Cells(6).Value

                End If
                'NewQuantity = MyTab.Rows(0).Item(4) ' - DgvActionsList.CurrentRow.Cells(6).Value

                'MsgBox(NewQuantity)
                'MsgBox(DgvActionsList.CurrentRow.Cells(6).Value)
                DeleteAction(DgvActionsList.CurrentRow.Cells(0).Value, DgvActionsList.CurrentRow.Cells(2).Value, NewQuantity)
                FmActions.FrmActions_Load(0, e)
                FmMaterials.FrmMaterials_Load(0, e)
                'ReloadActions()
            End If

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnImportProducts_Click(sender As Object, e As EventArgs) Handles BtnImportProducts.Click
        FrmImportProductData.ShowDialog()

    End Sub

    Private Sub FrmActions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, DgvActionsList.KeyDown, BtnImportProducts.KeyDown, BtnExportToExcel.KeyDown, BtnEditAction.KeyDown, BtnDeleteAction.KeyDown, BtnClose.KeyDown, BtnAddAction.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DTPStartDate_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtVendor.KeyDown, DTPStartDate.KeyDown, DTPEndDate.KeyDown, CmbUserName.KeyDown, CmbMaterial.KeyDown, CBOutActions.KeyDown, CBInActions.KeyDown, BtnReload.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnReload.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    'Private Sub FrmActions_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
    '    'MsgBox(SelectedRow)
    '    If DgvActionsList.RowCount > 0 Then DgvActionsList.CurrentCell = DgvActionsList.Rows(SelectedRow).Cells(1)
    'End Sub
End Class