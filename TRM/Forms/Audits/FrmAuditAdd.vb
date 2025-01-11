Public Class FrmAuditAdd
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmAuditAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAuditName.KeyDown, MyBase.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnSave_Click(Me, e)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        AuditIsFound = False
        OpenNewAudit(TxtAuditName.Text)
        If AuditIsFound = False Then
            Dim FmAuditView As New FrmAuditView
            If Application.OpenForms.OfType(Of FrmAuditView).Any = True Then
                FmAuditView.Activate()
            Else
                Me.Close()
                FmAudits.FrmAudits_Load(Me, e)
                FmAuditView = New FrmAuditView
                FmAuditView.MdiParent = FrmMain
                FmAuditView.TxtAuditName.Text = TxtAuditName.Text
                FmAuditView.Show()

            End If
        Else
            TxtAuditName.Focus()
        End If
    End Sub
End Class