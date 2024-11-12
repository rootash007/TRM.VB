Imports System.Data.SqlClient

Public Class FrmCarBack

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCarId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCarId.KeyDown, MyBase.KeyDown, BtnCarBack.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnCarBack.PerformClick()
        End If
    End Sub


    Private Sub BtnCarBack_Click(sender As Object, e As EventArgs) Handles BtnCarBack.Click
        Dim ExitMsg As DialogResult
        ExitMsg = MsgBox("האם אתה בטוח שברצונך לשחזר רכב", vbYesNo + vbQuestion, "שחזור רכב")
        If ExitMsg = 6 Then
            Try
                cmd = New SqlCommand
                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = "update MainList set CarStatus=@CarStatus where carserial=@carserial"
                    .Connection = dbcon

                End With
                cmd.Parameters.AddWithValue("@CarStatus", True)
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