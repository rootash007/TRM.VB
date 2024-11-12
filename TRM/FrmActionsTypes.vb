Public Class FrmActionsTypes

    Private Sub FrmJobInfoUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String = "select * from action_types"
        FillList(que)
        DGVActionTypes.DataSource = MyTab
        With DGVActionTypes
            .Columns(0).Visible = True
            .Columns(1).HeaderText = "action name"
            .Columns(2).HeaderText = "action type"
            .Columns(1).Width = DataGridViewAutoSizeColumnsMode.Fill
            '.Columns(1).Width = "action name"


        End With

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim ExitMsg As DialogResult
        ExitMsg = MsgBox("האם אתה בטוח שברצונך לשמור פרטים חדשים", vbYesNo + vbQuestion, "עדכון פרטי בית העסק")
        If ExitMsg = 6 Then

            My.Settings.LocalServer = TxtActionName.Text

            My.Settings.Save()
            FrmMain.Text = My.Settings.LocalServer
            Me.Close()
        End If

    End Sub

End Class