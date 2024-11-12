Imports System.Data.SqlClient

Public Class FrmProducts

    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String = "select * from products"
        FillList(que)
        DGVProducts.DataSource = MyTab
        ProductsDGVDesign(DGVProducts)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        NumbersOnly(e)
    End Sub

    Private Sub FrmTerminate_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            'BtnTerminate.PerformClick()
        End If
    End Sub

    Private Sub BtnTerminate_Click(sender As Object, e As EventArgs)
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
                'cmd.Parameters.AddWithValue("@carserial", TxtCarId.Text)
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