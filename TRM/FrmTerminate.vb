Imports System.Data.SqlClient

Public Class FrmTerminate

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCarId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub FrmTerminate_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCarId.KeyDown, MyBase.KeyDown, BtnTerminate.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnTerminate.PerformClick()
        End If
    End Sub

    Private Sub BtnTerminate_Click(sender As Object, e As EventArgs) Handles BtnTerminate.Click
        Dim ExitMsg As DialogResult
        ExitMsg = MsgBox("האם אתה בטוח שברצונך למחוק רכב", vbYesNo + vbQuestion, "מחיקת רכב")
        If ExitMsg = 6 Then
            Try
                cmd = New SqlCommand
                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = "delete from MainList where carserial=@carserial"
                    .Connection = dbcon
                End With
                cmd.Parameters.AddWithValue("@carserial", TxtCarId.Text)
                dbcon.Open()
                cmd.ExecuteNonQuery()
                dbcon.Close()
                cmd = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dbcon.Close()
            End Try
            MsgBox("Done")
            ReloadMainList()
            Me.Close()
        End If
    End Sub
End Class