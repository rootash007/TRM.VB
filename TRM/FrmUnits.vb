Public Class FrmUnits

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub



    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmCarCardPrint.ShowDialog()
        '    Process.Start(FrmMainList.DgvMain.CurrentRow.Cells(42).Value)

    End Sub





    Private Sub FrmUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String = "select * from units"
        FillList(que)
        DGVUnits.DataSource = MyTab
        With DGVUnits
            .Columns(0).Visible = True
            .Columns(0).Width = 50
            .Columns(1).HeaderText = "unit name"
            '.Columns(2).HeaderText = "action type"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            '.Columns(1).Width = "action name"


        End With
    End Sub
End Class