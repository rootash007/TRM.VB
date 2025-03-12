Imports System.Data.SqlClient

Module Audits_Controller
    Public AuditIsFound As Boolean = False

    Public Sub AddAudit(audit_name As String, audit_start_date As Date, audit_end_date As Date, alerta_days As Integer, audit_alert_date As Date, audit_alert_on As Boolean, more_info As String)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into audits (audit_name,audit_start_date,audit_end_date,alerta_days,audit_alert_date,audit_alert_on,more_info)values(@audit_name,@audit_start_date,@audit_end_date,@alerta_days,@audit_alert_date,@audit_alert_on,@more_info)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@audit_name", audit_name)
            cmd.Parameters.AddWithValue("@audit_start_date", audit_start_date)
            cmd.Parameters.AddWithValue("@audit_end_date", audit_end_date)
            cmd.Parameters.AddWithValue("@alerta_days", alerta_days)
            cmd.Parameters.AddWithValue("@audit_alert_date", audit_alert_date)
            cmd.Parameters.AddWithValue("@audit_alert_on", audit_alert_on)
            cmd.Parameters.AddWithValue("@more_info", more_info)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub OpenNewAudit(audit_name As String)
        Try
            cmd = New SqlCommand
            MyTab = New DataTable
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select  * from audits where audit_name = '" & audit_name & "' "
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
            If MyTab.Rows.Count > 0 Then
                MsgBox("audit name found")
                AuditIsFound = True
                Return
            Else
                cmd = New SqlCommand

                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = "insert into audits (audit_name,audit_start_date,audit_end_date,alert_days,audit_alert_date,audit_alert_on,more_info)values(@audit_name,@audit_start_date,@audit_end_date,@alert_days,@audit_alert_date,@audit_alert_on,@more_info)"
                    .Connection = dbcon
                End With
                cmd.Parameters.AddWithValue("@audit_name", audit_name)
                cmd.Parameters.AddWithValue("@audit_start_date", Today)
                cmd.Parameters.AddWithValue("@audit_end_date", Today)
                cmd.Parameters.AddWithValue("@alert_days", 5)
                cmd.Parameters.AddWithValue("@audit_alert_date", Today)
                cmd.Parameters.AddWithValue("@audit_alert_on", 1)
                cmd.Parameters.AddWithValue("@more_info", "more_info")

                dbcon.Open()
                cmd.ExecuteNonQuery()
                dbcon.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    'Public Sub AddAuditDynamic(parameters As Dictionary(Of String, Object))
    '    ' Validate inputs
    '    If parameters Is Nothing OrElse parameters.Count = 0 Then
    '        MsgBox("No parameters provided.")
    '        Return
    '    End If

    '    Try
    '        Using dbcon As New SqlConnection("YourConnectionString")
    '            Using cmd As New SqlCommand()
    '                cmd.Connection = dbcon

    '                ' Dynamically build the SQL query
    '                Dim columns As String = String.Join(", ", parameters.Keys)
    '                Dim values As String = String.Join(", ", parameters.Keys.Select(Function(k) "@" & k))
    '                cmd.CommandText = $"INSERT INTO audits ({columns}) VALUES ({values})"

    '                ' Add parameters to the command
    '                For Each kvp As KeyValuePair(Of String, Object) In parameters
    '                    If kvp.Value Is Nothing Then
    '                        cmd.Parameters.AddWithValue("@" & kvp.Key, DBNull.Value)
    '                    Else
    '                        cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
    '                    End If
    '                Next

    '                ' Execute the command
    '                dbcon.Open()
    '                cmd.ExecuteNonQuery()
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        ' Log the exception
    '        My.Application.Log.WriteException(ex)
    '        MsgBox("An error occurred while adding the audit. Please check the logs.")
    '    End Try
    'End Sub

End Module
