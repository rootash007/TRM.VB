Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmCostList
    Dim dt As New DataTable()
    Dim bindingSource As New BindingSource()

    Private Sub FrmCarSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Left
        BtnCloseActions.Visible = False
        NumYear.Value = Now.Year - 1
        DTPStartDate.Value = "01/01/" & NumYear.Value
        DTPEndDate.Value = "31/12/" & NumYear.Value
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        YearReLoad(DTPStartDate.Value, DTPEndDate.Value)
    End Sub
    Private Sub NumYear_ValueChanged(sender As Object, e As EventArgs) Handles NumYear.ValueChanged
        DTPStartDate.Value = "01/01/" & NumYear.Value
        DTPEndDate.Value = "31/12/" & NumYear.Value
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub DGVCostList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCostList.CellDoubleClick
        Me.Dock = DockStyle.Fill
        BtnCloseActions.Visible = True
        Dim que As String = "select * from actions where material_name = '" & DGVCostList.CurrentRow.Cells(0).Value & "'"
        FillList(que)
        DGVActions.DataSource = MyTab
        For i = 0 To DGVActions.RowCount - 1
            If DGVActions.Rows(i).Cells(13).Value = 0 Then
                DGVActions.Rows(i).DefaultCellStyle.BackColor = Color.LightPink
            End If
        Next
        DGVActions.ClearSelection()
    End Sub

    Private Sub BtnCloseActions_Click(sender As Object, e As EventArgs) Handles BtnCloseActions.Click
        Me.Dock = DockStyle.Left
        BtnCloseActions.Visible = False
    End Sub
End Class