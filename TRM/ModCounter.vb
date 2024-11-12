Imports System.Data.SqlClient

Module ModCounter

    Public Function CountMe() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from mainlist where carstatus = 1 and canceled = 0"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function TestCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With CountCMD
                .CommandType = CommandType.Text
                .CommandText = "select * from MainList where datetest <= '" & Today.ToShortDateString & "' and carstatus = 1 and canceled = 0 "
                .Connection = dbcon
            End With
            'CountCMD.Parameters.AddWithValue("@d1", d1)
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            CountCMD = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function DeletedCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from mainlist where canceled = 1"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function VendorsCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from Vendors where vstatus = 1"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function CustomersCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from Customers where CStatus = 1"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function SoldCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from mainlist where carstatus = 0 and canceled = 0"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function KindCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from carkind where active = 1"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function ModelCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from carmodel where active = 1"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    Public Function TypeCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from cartype where active = 1"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

End Module
