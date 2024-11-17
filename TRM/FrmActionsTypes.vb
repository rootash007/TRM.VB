Public Class FrmActionsTypes


    Private Sub FrmActionsTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String = "select * from action_types"
        FillList(que)
        DGVActionTypes.DataSource = MyTab
        With DGVActionTypes
            .Columns(0).Visible = True
            .Columns(1).HeaderText = "action name"
            .Columns(2).HeaderText = "increase action"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            '.Columns(1).Width = "action name"
        End With
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim ExitMsg As DialogResult
        ExitMsg = MsgBox("האם אתה בטוח שברצונך לשמור פרטים חדשים", vbYesNo + vbQuestion, "סוגי פעולות")
        If ExitMsg = 6 Then

            'My.Settings.LocalServer = TxtActionName.Text

            'My.Settings.Save()
            'FrmMain.Text = My.Settings.LocalServer
            'Me.Close()

        End If

    End Sub

    Private Sub TxtActionName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtActionName.KeyDown, MyBase.KeyDown, CmbActionType.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown, DGVActionTypes.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim ExitMsg As DialogResult

            ExitMsg = MsgBox("האם אתה בטוח שברצונך לצת ללא שמירה", vbYesNo + vbQuestion, "יציאה")
            If ExitMsg = 6 Then
                Me.Close()
            End If
        End If
    End Sub
End Class