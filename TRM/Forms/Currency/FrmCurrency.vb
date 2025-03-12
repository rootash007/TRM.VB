Imports System.Globalization

Public Class FrmCurrency
    Dim DataLength As Integer
    Private Sub FrmCurrency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrency()
        BtnSave.Enabled = False
        DataLength = DGVCurrency.RowCount
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ' Ensure the DataGridView has a DataSource and it is a DataTable
        If DGVCurrency.DataSource Is Nothing OrElse Not TypeOf DGVCurrency.DataSource Is DataTable Then
            MessageBox.Show("The DataGridView is not bound to a DataTable.")
            Return
        End If
        ' Get the DataTable from the DataGridView's DataSource
        Dim dataTable As DataTable = CType(DGVCurrency.DataSource, DataTable)

        ' Create a new row with the same schema as the DataTable
        Dim newRow As DataRow = dataTable.NewRow()

        ' Populate the new row with data
        newRow("id") = DGVCurrency.RowCount + 1
        newRow("currency_name") = ""
        newRow("currency_short") = ""
        newRow("isactive") = True
        ' Add the new row to the DataTable
        dataTable.Rows.Add(newRow)
        BtnSave.Enabled = True

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If BtnSave.Enabled = True Then
            Dim ExitMsg As DialogResult
            ExitMsg = MsgBox("هل تريد الخروج بدون حفظ التغييرات", vbYesNo + vbExclamation, "تحذير")
            If ExitMsg = 6 Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim SaveMsg As DialogResult
        SaveMsg = MsgBox("هل تريد حفظ التغييرات", vbYesNo + vbExclamation, "حفظ")
        If SaveMsg = vbYes Then
            If DataLength > 0 Then
                'save
                For i = 0 To DataLength - 1
                    Dim UpdateParams As New Dictionary(Of String, Object) From {
                        {"currency_name", DGVCurrency.Rows(i).Cells(1).Value},
                        {"currency_short", DGVCurrency.Rows(i).Cells(2).Value},
                        {"isactive", DGVCurrency.Rows(i).Cells(3).Value}
                        }
                    Dim conditionField As String = "id"
                    Dim conditionValue As Object = DGVCurrency.Rows(i).Cells(0).Value
                    UpdateData("currency", UpdateParams, conditionField, conditionValue)
                Next
                'insert
                For i = DataLength To DGVCurrency.RowCount - 1
                    Dim InsertParams As New Dictionary(Of String, Object) From {
                       {"currency_name", DGVCurrency.Rows(i).Cells(1).Value},
                       {"currency_short", DGVCurrency.Rows(i).Cells(2).Value},
                       {"isactive", DGVCurrency.Rows(i).Cells(3).Value}
                       }
                    InsertData("currency", InsertParams)
                Next
            Else
                'insert
                For i = 0 To DGVCurrency.RowCount - 1
                    Dim InsertParams As New Dictionary(Of String, Object) From {
                       {"currency_name", DGVCurrency.Rows(i).Cells(1).Value},
                       {"currency_short", DGVCurrency.Rows(i).Cells(2).Value},
                       {"isactive", DGVCurrency.Rows(i).Cells(3).Value}
                       }
                    InsertData("currency", InsertParams)
                Next
            End If
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub DGVCurrency_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCurrency.CellValueChanged
        BtnSave.Enabled = True
    End Sub
End Class