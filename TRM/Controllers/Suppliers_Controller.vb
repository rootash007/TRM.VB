Imports System.Data.SqlClient

Module Suppliers_Controller

    Public Sub DesignSuppliersDGV(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "تسلسل"
            .Columns(0).Visible = True
            .Columns(0).Width = 40

            .Columns(1).HeaderText = "اسم المورد"
            .Columns(1).Visible = True
            .Columns(1).Width = 120
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(2).HeaderText = "Supplier ID"
            .Columns(2).Visible = False

            .Columns(3).HeaderText = "Contact"
            .Columns(3).Visible = False

            .Columns(4).HeaderText = "رقم الهاتف"
            .Columns(4).Visible = True
            .Columns(4).Width = 100

            .Columns(5).HeaderText = "Fax"
            .Columns(5).Visible = False

            .Columns(6).HeaderText = "الايميل"
            .Columns(6).Visible = True
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(6).Width = 200

            .Columns(7).HeaderText = "Adress"
            .Columns(7).Visible = False

            .Columns(8).HeaderText = "المدينه"
            .Columns(8).Visible = True
            .Columns(8).Width = 110
            .Columns(8).DisplayIndex = 2

            .Columns(9).HeaderText = "Postal Code"
            .Columns(9).Visible = False

            .Columns(10).HeaderText = "Bank"
            .Columns(10).Visible = False

            .Columns(11).HeaderText = "Currency"
            .Columns(11).Visible = False

            .Columns(12).HeaderText = "Notes"
            .Columns(12).Visible = False

            .Columns(13).HeaderText = "Active"
            .Columns(13).Visible = False

            .Columns(14).HeaderText = "CreatedAt"
            .Columns(14).Visible = False

            .Columns(15).HeaderText = "UpdatedAt"
            .Columns(15).Visible = False
        End With
    End Sub

    Public Sub LoadSuppliers()
        Try
            Dim Query As String
            If FmSuppliers.RadOn.Checked = True Then
                Query = "select * from suppliers where isactive = 1"
                FmSuppliers.BtnDelete.Image = My.Resources.deleteuser
                FmSuppliers.BtnDelete.Text = "حذف"
            ElseIf FmSuppliers.RadOff.Checked = True Then
                Query = "select * from suppliers where isactive = 0"
                FmSuppliers.BtnDelete.Image = My.Resources.revert48
                FmSuppliers.BtnDelete.Text = "استرجاع"
            ElseIf FmSuppliers.RadAll.Checked = True Then
                Query = "select * from suppliers"
                FmSuppliers.BtnDelete.Image = Nothing
                FmSuppliers.BtnDelete.Text = "حذف / استرجاع"
            End If
            FillList(Query)
            FmSuppliers.DGVSuppliers.DataSource = MyTab
            DesignSuppliersDGV(FmSuppliers.DGVSuppliers)
            FmSuppliers.Text = "قائمة الموردين" & " ( " & MyTab.Rows.Count & " ) "

            '////// add function to color the deleted suppliers

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AddSubpplier(VName As String, VContact As String, VId As String, VAdress As String, VPhone As String, VFax As String, VEmail As String, VInfo As String)
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
        'Try
        '    cmd = New SqlCommand
        '    With cmd
        '        .CommandType = CommandType.Text
        '        .CommandText = "update vendors set VStatus=@VStatus where id=" & FrmVendors.DgvVendorsOn.CurrentRow.Cells(0).Value
        '        .Connection = dbcon
        '    End With
        '    cmd.Parameters.AddWithValue("VStatus", False)
        '    dbcon.Open()
        '    cmd.ExecuteNonQuery()
        '    dbcon.Close()
        '    cmd = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    dbcon.Close()
        'End Try
    End Sub

End Module
