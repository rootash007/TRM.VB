Imports System.Data.SqlClient
Imports System.Security.AccessControl

Module Suppliers_Controller
    Public SupplierTab As DataTable

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

            .Columns(16).HeaderText = "Supplier Folder"
            .Columns(16).Visible = False
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
            SupplierTab = MyTab
            FmSuppliers.DGVSuppliers.DataSource = SupplierTab
            DesignSuppliersDGV(FmSuppliers.DGVSuppliers)
            FmSuppliers.Text = "قائمة الموردين" & " ( " & MyTab.Rows.Count & " ) "

            '////// add function to color the deleted suppliers
            If FmSuppliers.RadAll.Checked = True Then
                If FmSuppliers.DGVSuppliers.RowCount > 0 Then
                    For i = 0 To FmSuppliers.DGVSuppliers.RowCount - 1
                        If FmSuppliers.DGVSuppliers.Rows(i).Cells(13).Value = True Then
                            FmSuppliers.DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.White
                        Else
                            FmSuppliers.DGVSuppliers.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AddSubpplier(supplier_name As String, supplier_id As String, supplier_contact As String, supplier_phone As String, supplier_fax As String, supplier_email As String, supplier_adress As String, supplier_city As String, postal_code As String, supplier_bank_details As String, currency As String, supplier_notes As String, supplier_folder As String)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into suppliers(supplier_name,supplier_id,supplier_contact,supplier_phone,supplier_fax,supplier_email,supplier_adress,supplier_city,postal_code,supplier_bank_details,currency,supplier_notes,supplier_folder) values (@supplier_name,@supplier_id,@supplier_contact,@supplier_phone,@supplier_fax,@supplier_email,@supplier_adress,@supplier_city,@postal_code,@supplier_bank_details,@currency,@supplier_notes,@supplier_folder)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("supplier_name", supplier_name)
            cmd.Parameters.AddWithValue("supplier_id", supplier_id)
            cmd.Parameters.AddWithValue("supplier_contact", supplier_contact)
            cmd.Parameters.AddWithValue("supplier_phone", supplier_phone)
            cmd.Parameters.AddWithValue("supplier_fax", supplier_fax)
            cmd.Parameters.AddWithValue("supplier_email", supplier_email)
            cmd.Parameters.AddWithValue("supplier_adress", supplier_adress)
            cmd.Parameters.AddWithValue("supplier_city", supplier_city)
            cmd.Parameters.AddWithValue("postal_code", postal_code)
            cmd.Parameters.AddWithValue("supplier_bank_details", supplier_bank_details)
            cmd.Parameters.AddWithValue("currency", currency)
            cmd.Parameters.AddWithValue("supplier_notes", supplier_notes)
            cmd.Parameters.AddWithValue("supplier_folder", supplier_folder)

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

    Public Sub UpdateSupplier(supplier_name As String, supplier_id As String, supplier_contact As String, supplier_phone As String, supplier_fax As String, supplier_email As String, supplier_adress As String, supplier_city As String, postal_code As String, supplier_bank_details As String, currency As String, supplier_notes As String, isactive As Boolean, supplier_folder As String, id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update suppliers set supplier_name=@supplier_name,supplier_id=@supplier_id,supplier_contact=@supplier_contact,supplier_phone=@supplier_phone,supplier_fax=@supplier_fax,supplier_email=@supplier_email,supplier_adress=@supplier_adress,supplier_city=@supplier_city,postal_code=@postal_code,supplier_bank_details=@supplier_bank_details,currency=@currency,supplier_notes=@supplier_notes,isactive=@isactive,supplier_folder=@supplier_folder where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("supplier_name", supplier_name)
            cmd.Parameters.AddWithValue("supplier_id", supplier_id)
            cmd.Parameters.AddWithValue("supplier_contact", supplier_contact)
            cmd.Parameters.AddWithValue("supplier_phone", supplier_phone)
            cmd.Parameters.AddWithValue("supplier_fax", supplier_fax)
            cmd.Parameters.AddWithValue("supplier_email", supplier_email)
            cmd.Parameters.AddWithValue("supplier_adress", supplier_adress)
            cmd.Parameters.AddWithValue("supplier_city", supplier_city)
            cmd.Parameters.AddWithValue("postal_code", postal_code)
            cmd.Parameters.AddWithValue("supplier_bank_details", supplier_bank_details)
            cmd.Parameters.AddWithValue("currency", currency)
            cmd.Parameters.AddWithValue("supplier_notes", supplier_notes)
            cmd.Parameters.AddWithValue("isactive", isactive)
            cmd.Parameters.AddWithValue("supplier_folder", supplier_folder)
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

    Public Sub SupplierStatusChange()
        Try
            Dim isActive As Boolean
            If FmSuppliers.DGVSuppliers.CurrentRow.Cells(13).Value = True Then
                isActive = False
            Else
                isActive = True
            End If
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update suppliers set isactive=@isactive where id=" & FmSuppliers.DGVSuppliers.CurrentRow.Cells(0).Value
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("isactive", isActive)
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
