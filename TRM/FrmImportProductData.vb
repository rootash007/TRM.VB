Imports System.Data.SqlClient

Public Class FrmImportProductData
    Private Sub FrmImportProductData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String = "select * from products"
        FillList(que)
        CmbProducts.DataSource = MyTab
        CmbProducts.DisplayMember = "product_name"
        CmbProducts.ValueMember = "id"
        CmbProducts.SelectedIndex = -1
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBlocks.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBlocks.KeyDown, MyBase.KeyDown, BtnCarBack.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnCarBack.PerformClick()
        End If
    End Sub


    Private Sub BtnCarBack_Click(sender As Object, e As EventArgs) Handles BtnCarBack.Click
        'Dim que As String = "IF  NOT EXISTS (SELECT * FROM sys.objects 
        '                    WHERE object_id = OBJECT_ID(N'ProMat') AND type in (N'U'))
        '                    BEGIN
        '                    CREATE TABLE ProMat(
        '                    id int
        '                    ) 
        '                    END
        '                    ELSE
        '                    SELECT * from products
        '                    "
        Dim que As String = "select * from promat"
        FillList(que)
        DGVProductMaterials.DataSource = MyTab
        'Dim ExitMsg As DialogResult
        'ExitMsg = MsgBox("האם אתה בטוח שברצונך לשחזר רכב", vbYesNo + vbQuestion, "שחזור רכב")
        'If ExitMsg = 6 Then
        '    Try
        '        cmd = New SqlCommand
        '        With cmd
        '            .CommandType = CommandType.Text
        '            .CommandText = "update MainList set CarStatus=@CarStatus where carserial=@carserial"
        '            .Connection = dbcon

        '        End With
        '        cmd.Parameters.AddWithValue("@CarStatus", True)
        '        cmd.Parameters.AddWithValue("@carserial", TxtBlocks.Text)
        '        dbcon.Open()
        '        cmd.ExecuteNonQuery()
        '        dbcon.Close()
        '        cmd = Nothing
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    Finally
        '        dbcon.Close()
        '    End Try
        '    MsgBox("Done")
        '    ReloadMainList()
        '    Me.Close()
        'End If
    End Sub

    Private Sub CmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProducts.SelectedIndexChanged


    End Sub
End Class