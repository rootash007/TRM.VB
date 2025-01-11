Public Class FrmActionsTypes


    Private Sub FrmActionsTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CmbActionType.Items.Add("عملية ادخال")
        'CmbActionType.Items.Add("عملية اخراج")

        Dim que As String = "select * from action_types"
        FillList(que)
        DGVActionTypes.DataSource = MyTab
        With DGVActionTypes
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "اسم العملية"
            .Columns(2).HeaderText = "عملية ادخال"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            '.Columns(1).Width = "action name"
        End With
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Dim ExitMsg As DialogResult
        'ExitMsg = MsgBox("האם אתה בטוח שברצונך לשמור פרטים חדשים", vbYesNo + vbQuestion, "סוגי פעולות")
        'If ExitMsg = 6 Then

        '    'My.Settings.LocalServer = TxtActionName.Text

        '    'My.Settings.Save()
        '    'FrmMain.Text = My.Settings.LocalServer
        '    'Me.Close()

        'End If
        For i = 0 To DGVActionTypes.RowCount - 2
            If DGVActionTypes.Rows(i).Cells(1).Value Is Nothing OrElse DGVActionTypes.Rows(i).Cells(1).Value.ToString.Trim = "" Then
                MsgBox("اسم نوع عملية فارغ", vbOKOnly + vbCritical, "خطاء")
                Return
            End If
        Next
        Dim SaveMSG As DialogResult
        SaveMSG = MsgBox("هل تريد حفظ التغييرات", vbYesNo + vbQuestion, "حفظ التغييرات")
        If SaveMSG = 6 Then
            SaveActionTypes(Me.DGVActionTypes)
            Me.Close()
        End If

    End Sub

    Private Sub TxtActionName_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown, DGVActionTypes.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim ExitMsg As DialogResult

            ExitMsg = MsgBox("האם אתה בטוח שברצונך לצת ללא שמירה", vbYesNo + vbQuestion, "יציאה")
            If ExitMsg = 6 Then
                Me.Close()
            End If
        End If
    End Sub
End Class