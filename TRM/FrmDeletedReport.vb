Public Class FrmDeletedReport

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmDeletedReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String
        que = "select * from mainlist where carstatus = 1 and canceled = 1 "
        FillList(que)
        DGVDeleted.DataSource = MyTab
        DesignMainDGV(DGVDeleted)
    End Sub

    Private Sub BtnCarRestore_Click(sender As Object, e As EventArgs) Handles BtnCarRestore.Click
        Dim ChkCarId As Boolean = False
        Dim Rw As Integer = 0
        Dim que As String

        If DGVDeleted.RowCount > 0 Then
            que = "select * from mainlist where carstatus = 1 and canceled = 0 "
            FillList(que)
            For i = 0 To MyTab.Rows.Count - 1
                If (DGVDeleted.CurrentRow.Cells(2).Value = MyTab.Rows(i).Item(2).ToString) Then
                    ChkCarId = True
                End If
            Next
            If ChkCarId = False Then
                CarDeleteRestore(DGVDeleted.CurrentRow.Cells(0).Value, 0, "", Today.ToShortDateString)
                FrmDeletedReport_Load(Me, e)
                ReConnect = True
                FrmMain.FrmMain_Load(FrmMain, e)
            Else
                OkMsgInfo("רכב קיים", "אין אפשרות לשחזור רכב , מספר זה קיים במערכת")
            End If

        Else
            OkMsgInfo("אין בחירה", "רשימת רכבים ריקה")
        End If
    End Sub

    Private Sub DGVDeleted_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVDeleted.KeyDown, BtnClose.KeyDown, BtnCarRestore.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class