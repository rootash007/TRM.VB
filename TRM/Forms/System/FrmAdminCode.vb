Public Class FrmAdminCode

    Private Sub FrmAdminCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String = "select * from branches"
        FillList(que)
        AdminCode = MyTab.Rows(0).Item(2)
        TxtAdminCode.Text = ""
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        'If TxtAdminCode.Text = My.Settings.AdminCode Then
        If TxtAdminCode.Text = AdminCode Then
            isAdminCode = True
            Me.Close()
        Else
            MsgBox("كلمة المرور غير صحيحة", vbOKOnly + vbCritical, "خطأ")
            Return
        End If
    End Sub

    Private Sub FrmAdminCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAdminCode.KeyDown, MyBase.KeyDown, BtnClose.KeyDown, BtnAccept.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnAccept.PerformClick()
        End If
    End Sub
End Class