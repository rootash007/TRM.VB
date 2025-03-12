Imports System.Data.SqlClient

Module Currency_Controller

    Public Sub DesignCurrencyDGV(dgv As DataGridView)
        'With dgv
        '    .Columns(0).HeaderText = "تسلسل"
        '    .Columns(0).Visible = True
        '    .Columns(0).Width = 40

        '    .Columns(1).HeaderText = "اسم العمله"
        '    .Columns(1).Visible = True
        '    .Columns(1).Width = 120
        '    .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        '    .Columns(2).HeaderText = "رمز العمله"
        '    .Columns(2).Visible = True

        '    .Columns(3).HeaderText = "مفعل"
        '    .Columns(3).Visible = True
        'End With
        'Ensure the DataGridView has columns
        If dgv.Columns.Count = 0 Then
            Throw New ArgumentException("The DataGridView must have columns.")
        End If

        With dgv
            ' Ensure there are enough columns to avoid IndexOutOfRangeException
            If .Columns.Count > 0 Then
                .Columns(0).HeaderText = "تسلسل"
                .Columns(0).Visible = True
                .Columns(0).Width = 40
                .Columns(0).ReadOnly = True ' Make the first column read-only
            End If

            If .Columns.Count > 1 Then
                .Columns(1).HeaderText = "اسم العمله"
                .Columns(1).Visible = True
                .Columns(1).Width = 120
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

            If .Columns.Count > 2 Then
                .Columns(2).HeaderText = "رمز العمله"
                .Columns(2).Visible = True
                .Columns(2).Width = 80 ' Set a fixed width for the currency symbol column
            End If

            If .Columns.Count > 3 Then
                'Set column(3) as a CheckBox column
                If Not TypeOf .Columns(3) Is DataGridViewCheckBoxColumn Then
                    ' Create a new CheckBox column
                    Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
                    checkBoxColumn.HeaderText = .Columns(3).HeaderText
                    checkBoxColumn.Name = .Columns(3).Name
                    checkBoxColumn.DataPropertyName = .Columns(3).DataPropertyName
                    checkBoxColumn.Visible = True
                    checkBoxColumn.Width = 60

                    ' Replace the existing column with the new CheckBox column
                    .Columns.RemoveAt(3)
                    .Columns.Insert(3, checkBoxColumn)
                End If

                'Customize the CheckBox column
                .Columns(3).HeaderText = "مفعل"
                .Columns(3).Visible = True
                .Columns(3).Width = 60
            End If

            ' Optional: Improve the appearance of the DataGridView
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            '.AllowUserToResizeColumns = True
            '.AllowUserToResizeRows = False
            '.RowHeadersVisible = False ' Hide row headers
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Select entire rows
            '.DefaultCellStyle.Font = New Font("Tahoma", 10) ' Set default font
            '.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold) ' Set header font
        End With
    End Sub

    Public Sub LoadCurrency()
        Try
            Dim Query As String
            Query = "select * from currency"
            FillList(Query)
            FrmCurrency.DGVCurrency.DataSource = MyTab
            DesignCurrencyDGV(FrmCurrency.DGVCurrency)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertData(tableName As String, parameters As Dictionary(Of String, Object))
        ' Validate inputs
        If parameters Is Nothing OrElse parameters.Count = 0 Then
            MsgBox("No parameters provided.")
            Return
        End If
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                Dim columns As String = String.Join(", ", parameters.Keys)
                Dim values As String = String.Join(", ", parameters.Keys.Select(Function(k) "@" & k))
                .CommandText = $"INSERT INTO {tableName} ({columns}) VALUES ({values})"
                .Connection = dbcon
            End With
            ' Add parameters to the command
            For Each kvp As KeyValuePair(Of String, Object) In parameters
                If kvp.Value Is Nothing Then
                    cmd.Parameters.AddWithValue("@" & kvp.Key, DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
                End If
            Next
            ' Execute the command
            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub


    Public Sub UpdateData(tableName As String, parameters As Dictionary(Of String, Object), conditionField As String, conditionValue As Object)
        ' Validate inputs
        If parameters Is Nothing OrElse parameters.Count = 0 Then
            MsgBox("No parameters provided.")
            Return
        End If
        If String.IsNullOrEmpty(conditionField) Then
            MsgBox("Condition field cannot be empty.")
            Return
        End If

        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                ' Dynamically build the SQL query
                Dim setClause As String = String.Join(", ", parameters.Keys.Select(Function(k) $"{k} = @{k}"))
                .CommandText = $"UPDATE {tableName} SET {setClause} WHERE {conditionField} = @conditionValue"
                .Connection = dbcon
            End With

            ' Add parameters to the command
            For Each kvp As KeyValuePair(Of String, Object) In parameters
                If kvp.Value Is Nothing Then
                    cmd.Parameters.AddWithValue("@" & kvp.Key, DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
                End If
            Next

            ' Add the condition parameter
            cmd.Parameters.AddWithValue("@conditionValue", conditionValue)

            ' Execute the command
            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            ' Log the exception
            'My.Application.Log.WriteException(ex)
            'MsgBox("An error occurred while updating the audit. Please check the logs.")
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

End Module
