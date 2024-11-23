Public Class FrmUnits

    Private Sub FrmUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim que As String = "select * from units"
        FillList(que)
        DGVUnits.DataSource = MyTab
        With DGVUnits
            .Columns(0).Visible = True
            .Columns(0).Width = 50
            .Columns(0).ReadOnly = True
            .Columns(0).HeaderText = "الرقم"
            .Columns(1).HeaderText = "اسم الوحدة"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'FrmCarCardPrint.ShowDialog()
        '    Process.Start(FrmMainList.DgvMain.CurrentRow.Cells(42).Value)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        For i = 0 To DGVUnits.RowCount - 2
            If DGVUnits.Rows(i).Cells(1).Value Is Nothing OrElse DGVUnits.Rows(i).Cells(1).Value.ToString.Trim = "" Then
                MsgBox("unit name cannot be empty", vbOKOnly + vbCritical, "error")
                Return
            End If
        Next
        Dim SaveMSG As DialogResult
        SaveMSG = MsgBox("هل تريد حفظ التغييرات", vbYesNo + vbQuestion, "حفظ التغييرات")
        If SaveMSG = 6 Then
            SaveUnits(Me.DGVUnits)
            Me.Close()
        End If
    End Sub
End Class