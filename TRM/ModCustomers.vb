Imports System.Data.SqlClient

Module ModCustomers

    Public Sub FillCustomersList(Query As String)
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Query
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DesignCustomersDGV(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "מס"
            .Columns(0).Visible = True
            .Columns(0).Width = 50

            .Columns(1).HeaderText = "שם לקוח"
            .Columns(1).Visible = True
            .Columns(1).Width = 120

            .Columns(2).HeaderText = "איש קשר"
            .Columns(2).Visible = True
            .Columns(2).Width = 70

            .Columns(3).HeaderText = "ת.ז / ח.פ ספק"
            .Columns(3).Visible = True
            .Columns(3).Width = 100

            .Columns(4).HeaderText = "כתובת"
            .Columns(4).Visible = True
            .Columns(4).Width = 150

            .Columns(5).HeaderText = "טלפון"
            .Columns(5).Visible = True
            .Columns(5).Width = 80

            .Columns(6).HeaderText = "פקס"
            .Columns(6).Visible = True
            .Columns(6).Width = 80

            .Columns(7).HeaderText = "אימייל"
            .Columns(7).Visible = True
            .Columns(7).Width = 220

            .Columns(8).HeaderText = "הערות"
            .Columns(8).Visible = True
            .Columns(8).Width = 240

            .Columns(9).HeaderText = "פעיל"
            .Columns(9).Visible = False
        End With
    End Sub

    Public Sub ReloadCustomers()
        Dim VQueryOn As String
        Dim VQueryOff As String
        VQueryOn = "select * from customers where cStatus = 1"
        VQueryOff = "select * from customers where cStatus = 0"
        FillCustomersList(VQueryOn)
        FrmCustomers.DgvCustomersOn.DataSource = MyTab
        DesignCustomersDGV(FrmCustomers.DgvCustomersOn)

        FillCustomersList(VQueryOff)
        FrmCustomers.DGVCustomersOff.DataSource = MyTab
        DesignCustomersDGV(FrmCustomers.DGVCustomersOff)
    End Sub

    Public Sub AddNewCostomer(CName As String, CContact As String, CId As String, CAdress As String, CPhone As String, CFax As String, CEmail As String, CInfo As String)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into Customers(CName,CContact,CId,CAdress,CPhone,CFax,CEmail,CInfo) values (@CName,@CContact,@CId,@CAdress,@CPhone,@CFax,@CEmail,@CInfo)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("CName", CName)
            cmd.Parameters.AddWithValue("CContact", CContact)
            cmd.Parameters.AddWithValue("CId", CId)
            cmd.Parameters.AddWithValue("CAdress", CAdress)
            cmd.Parameters.AddWithValue("CPhone", CPhone)
            cmd.Parameters.AddWithValue("CFax", CFax)
            cmd.Parameters.AddWithValue("CEmail", CEmail)
            cmd.Parameters.AddWithValue("CInfo", CInfo)
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

    Public Sub UpdateCustomer(CName As String, CContact As String, CId As String, CAdress As String, CPhone As String, CFax As String, CEmail As String, CInfo As String, CStatus As Boolean, id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update customers set CName=@CName, Ccontact=@CContact , CId=@CId , CAdress=@CAdress ,CPhone=@CPhone , CFax=@CFax , CEmail=@CEmail , CInfo=@CInfo , CStatus=@CStatus where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("CName", CName)
            cmd.Parameters.AddWithValue("CContact", CContact)
            cmd.Parameters.AddWithValue("CId", CId)
            cmd.Parameters.AddWithValue("CAdress", CAdress)
            cmd.Parameters.AddWithValue("CPhone", CPhone)
            cmd.Parameters.AddWithValue("CFax", CFax)
            cmd.Parameters.AddWithValue("CEmail", CEmail)
            cmd.Parameters.AddWithValue("CInfo", CInfo)
            cmd.Parameters.AddWithValue("CStatus", CStatus)
            cmd.Parameters.AddWithValue("@id", id)

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

    Public Sub CustomerDelete()
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update Customers set CStatus=@CStatus where id=" & FrmCustomers.DgvCustomersOn.CurrentRow.Cells(0).Value
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("CStatus", False)
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

End Module

