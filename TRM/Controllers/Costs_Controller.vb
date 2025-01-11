Imports System.Data.SqlClient

Module Costs_Controller

    Public Sub YearReLoad(StartDate As Date, EndDate As Date)
        FmCostList.DGVCostList.Rows.Clear()
        Dim TotalQuantity As Integer = 0
        Dim TotalPaid As Double = 0

        Dim que As String
        Costs2Dates(StartDate, EndDate)
        FmCostList.DGV1.DataSource = MyTab
        FmCostList.DGV1.Sort(FmCostList.DGV1.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        For i = 0 To FmCostList.DGV1.Rows.Count - 1
            If FmCostList.DGVCostList.Rows.Count = 0 Then
                que = "SELECT * FROM material_prices WHERE material_id IN (SELECT id FROM materials where material_name = '" & FmCostList.DGV1.Rows(i).Cells(1).Value & "')"
                FillList(que)
                If MyTab.Rows.Count > 0 Then
                    For d = 0 To MyTab.Rows.Count - 1
                        If MyTab.Rows(d).Item(2) = StartDate.Year Then
                            FmCostList.DGVCostList.Rows.Add()
                            FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(0).Value = FmCostList.DGV1.Rows(i).Cells(1).Value
                            FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(1).Value = FmCostList.DGV1.Rows(i).Cells(2).Value
                            FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(2).Value = FmCostList.DGV1.Rows(i).Cells(6).Value
                            FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(3).Value = FmCostList.DGV1.Rows(i).Cells(13).Value
                            FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(4).Value = MyTab.Rows(d).Item(5)
                            If FmCostList.DGV1.Rows(i).Cells(13).Value = 0 Then
                                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightYellow
                            End If
                        End If
                    Next
                End If
            ElseIf FmCostList.DGV1.Rows.Count - 1 = i Then
                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(5).Value = FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(4).Value * FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(2).Value
                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(6).Value = FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(3).Value - FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(5).Value
                'FmCostList.DGVCostList.Columns(6).DefaultCellStyle.Format = "0.00"


                'MsgBox("end")
            Else
                If FmCostList.DGV1.Rows(i).Cells(1).Value = FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(0).Value Then
                    FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(2).Value += FmCostList.DGV1.Rows(i).Cells(6).Value
                    If FmCostList.DGV1.Rows(i).Cells(13).Value = 0 Then
                        FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightYellow
                    Else
                        FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(3).Value += FmCostList.DGV1.Rows(i).Cells(13).Value
                    End If
                Else
                    FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(5).Value = FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(4).Value * FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(2).Value
                    FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(6).Value = FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(3).Value - FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(5).Value
                    que = "SELECT * FROM material_prices WHERE material_id IN (SELECT id FROM materials where material_name = '" & FmCostList.DGV1.Rows(i).Cells(1).Value & "')"
                    FillList(que)
                    If MyTab.Rows.Count > 0 Then
                        For d = 0 To MyTab.Rows.Count - 1
                            If MyTab.Rows(d).Item(2) = StartDate.Year Then
                                FmCostList.DGVCostList.Rows.Add()
                                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(0).Value = FmCostList.DGV1.Rows(i).Cells(1).Value
                                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(1).Value = FmCostList.DGV1.Rows(i).Cells(2).Value
                                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(2).Value = FmCostList.DGV1.Rows(i).Cells(6).Value
                                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(3).Value = FmCostList.DGV1.Rows(i).Cells(13).Value
                                FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).Cells(4).Value = MyTab.Rows(d).Item(5)
                                If FmCostList.DGV1.Rows(i).Cells(13).Value = 0 Then
                                    FmCostList.DGVCostList.Rows(FmCostList.DGVCostList.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightYellow
                                End If
                            End If
                        Next
                    End If
                End If
            End If

        Next
        FmCostList.DGVCostList.ClearSelection()
    End Sub

    Public Sub Costs2Dates(StartDate As Date, EndDate As Date)
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from actions where action_date >= @start_date and action_date <= @end_date and action_isincrease = 1 order by action_date"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("start_date", StartDate)
            cmd.Parameters.AddWithValue("end_date", EndDate)

            dbcon.Open()

            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

End Module
