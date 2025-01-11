Public Class FrmBackUp

    Private Sub FrmBackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblBackUpDate.Text = My.Settings.LastBackUpDate
    End Sub

    Private Sub BtnBackUp_Click(sender As Object, e As EventArgs) Handles BtnBackUp.Click
        Try
            Dim FDB As New FolderBrowserDialog
            Dim BackUpFile As String
            FDB.SelectedPath = My.Settings.BackUpPath
            If FDB.ShowDialog() = vbOK Then
                BackUpFile = FDB.SelectedPath + "\" + Format(Now, "dd.MM.yyyy HH_mm")
                BackUp(BackUpFile)
                LblBackUpDate.Text = Format(Now, "dd/MM/yyyy HH:mm")
                My.Settings.BackUpPath = FDB.SelectedPath
                My.Settings.LastBackUpDate = LblBackUpDate.Text
                My.Settings.Save()
                OkMsgInfo("גיבוי נתונים", "הגיבוי בוצע בהצלחה")
                'MsgBox("הגיבוי בוצע בהצלחה")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestore.Click
        If AdminMode = True Then
            Try
                Dim OFD As New OpenFileDialog
                OFD.InitialDirectory = My.Settings.BackUpPath
                If OFD.ShowDialog() = vbOK Then
                    If RestoreDB(OFD.FileName) = True Then
                        OkMsgInfo("שחזור נתונים", "השחזור בוצע בהצלחה")
                        'MsgBox("השחזור בוצע בהצלחה", , "")
                        Application.Restart()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו")
            'MsgBox("אין לך הרשאה לפעולה זו", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "אין הרשאה")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnCancel_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnRestore.KeyDown, BtnCancel.KeyDown, BtnBackUp.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class