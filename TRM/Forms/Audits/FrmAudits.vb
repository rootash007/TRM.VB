Public Class FrmAudits

    Public Sub FrmAudits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Dim que As String
        que = "select * from audits"
        FillList(que)
        DGVAudits.DataSource = MyTab
        AuditsDGVDesign(DGVAudits)
    End Sub

    Private Sub BtnCarRestore_Click(sender As Object, e As EventArgs) Handles BtnCarRestore.Click
        Dim ChkCarId As Boolean = False
        Dim Rw As Integer = 0
        Dim que As String

        If DGVAudits.RowCount > 0 Then
            que = "select * from mainlist where carstatus = 1 and canceled = 0 "
            FillList(que)
            For i = 0 To MyTab.Rows.Count - 1
                If (DGVAudits.CurrentRow.Cells(2).Value = MyTab.Rows(i).Item(2).ToString) Then
                    ChkCarId = True
                End If
            Next
            If ChkCarId = False Then
                CarDeleteRestore(DGVAudits.CurrentRow.Cells(0).Value, 0, "", Today.ToShortDateString)
                FrmAudits_Load(Me, e)
                ReConnect = True
                FrmMain.FrmMain_Load(FrmMain, e)
            Else
                OkMsgInfo("רכב קיים", "אין אפשרות לשחזור רכב , מספר זה קיים במערכת")
            End If

        Else
            OkMsgInfo("אין בחירה", "רשימת רכבים ריקה")
        End If
    End Sub

    Private Sub DGVDeleted_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVAudits.KeyDown, BtnClose.KeyDown, BtnCarRestore.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtmAddAudit_Click(sender As Object, e As EventArgs) Handles BtmAddAudit.Click
        Dim FmAuditAdd As New FrmAuditAdd
        FmAuditAdd.ShowDialog()
    End Sub
End Class