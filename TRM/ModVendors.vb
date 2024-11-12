Imports System.Data.SqlClient

Module ModVendors

    Public Sub FillVendorsList(Query As String)
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

    Public Sub DesignVendorsDGV(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "מס"
            .Columns(0).Visible = True
            .Columns(0).Width = 50

            .Columns(1).HeaderText = "שם ספק"
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

    Public Sub ReloadVendors()
        Dim VQueryOn As String
        Dim VQueryOff As String
        VQueryOn = "select * from vendors where VStatus = 1"
        VQueryOff = "select * from vendors where VStatus = 0"
        FillVendorsList(VQueryOn)
        FrmVendors.DgvVendorsOn.DataSource = MyTab
        DesignVendorsDGV(FrmVendors.DgvVendorsOn)

        FillVendorsList(VQueryOff)
        FrmVendors.DGVVendorsOff.DataSource = MyTab
        DesignVendorsDGV(FrmVendors.DGVVendorsOff)
    End Sub

    Public Sub AddNewvendor(VName As String, VContact As String, VId As String, VAdress As String, VPhone As String, VFax As String, VEmail As String, VInfo As String)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into Vendors(VName,VContact,VId,VAdress,VPhone,VFax,VEmail,VInfo) values (@VName,@VContact,@VId,@VAdress,@VPhone,@VFax,@VEmail,@VInfo)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("VName", VName)
            cmd.Parameters.AddWithValue("VContact", VContact)
            cmd.Parameters.AddWithValue("VId", VId)
            cmd.Parameters.AddWithValue("VAdress", VAdress)
            cmd.Parameters.AddWithValue("VPhone", VPhone)
            cmd.Parameters.AddWithValue("VFax", VFax)
            cmd.Parameters.AddWithValue("VEmail", VEmail)
            cmd.Parameters.AddWithValue("VInfo", VInfo)

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

    Public Sub UpdateVendor(VName As String, VContact As String, VId As String, VAdress As String, VPhone As String, VFax As String, VEmail As String, VInfo As String, VStatus As Boolean, id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update vendors set VName=@VName, Vcontact=@VContact , VId=@VId , VAdress=@VAdress ,VPhone=@VPhone , VFax=@VFax , VEmail=@VEmail , VInfo=@VInfo , VStatus=@VStatus where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("VName", VName)
            cmd.Parameters.AddWithValue("VContact", VContact)
            cmd.Parameters.AddWithValue("VId", VId)
            cmd.Parameters.AddWithValue("VAdress", VAdress)
            cmd.Parameters.AddWithValue("VPhone", VPhone)
            cmd.Parameters.AddWithValue("VFax", VFax)
            cmd.Parameters.AddWithValue("VEmail", VEmail)
            cmd.Parameters.AddWithValue("VInfo", VInfo)
            cmd.Parameters.AddWithValue("VStatus", VStatus)
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

    Public Sub VendorDelete()
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update vendors set VStatus=@VStatus where id=" & FrmVendors.DgvVendorsOn.CurrentRow.Cells(0).Value
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("VStatus", False)
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
