Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Imports System.Text
Imports System.Reflection
Imports System.Security.Cryptography.X509Certificates


Module ModMaterials

    Public isAddMaterial As Boolean
    Public isActiveMaterial As Boolean
    Public Excel As String
    Public Dts As DataSet
    Public Conn As OleDbConnection
    Public Dta As OleDbDataAdapter
    Public SheetName As String = ""
    Public OpenFileDialog As New OpenFileDialog
    Public MaterialsOnTab = New DataTable
    Public MaterialPriceTab = New DataTable
    Public FmMaterialAddEdit As New FrmMaterialAddEdit
    'Dim FmMaterialAddEdit = New FrmMaterialAddEdit




    Public Sub LoadUnits()
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from units"
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub FillMaterialsList(Que As String)
        cmd = New SqlCommand
        MaterialsTab = New DataTable
        Try
            MaterialsTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Que
                .Connection = dbcon
            End With

            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MaterialsTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadMaterials()
        Dim queOn As String
        Dim queOff As String
        Dim queAlarm As String
        Dim queMaterials As String



        queOn = "select * from materials where material_isactive=1"
        queOff = "select * from materials where material_isactive=0"
        queAlarm = "select * from materials where material_quantity < material_min_quantity and material_isactive=1"
        queMaterials = "select * from materials"


        FillList(queOn)
        FmMaterials.DgvMaterials.DataSource = MyTab
        MaterialsOnTab = MyTab
        DesignMaterialsDGV(FmMaterials.DgvMaterials)
        If FmMaterials.DgvMaterials.RowCount > 0 Then
            For i = 0 To FmMaterials.DgvMaterials.RowCount - 1
                If FmMaterials.DgvMaterials.Rows(i).Cells(4).Value < 0 Then
                    FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                ElseIf FmMaterials.DgvMaterials.Rows(i).Cells(4).Value = 0 Then
                    FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                Else
                    FmMaterials.DgvMaterials.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next
        End If


        FillList(queOff)
        FmMaterials.DGVMaterialsOff.DataSource = MyTab
        DesignMaterialsDGV(FmMaterials.DGVMaterialsOff)

        FillList(queAlarm)
        FmMaterials.DGVAlarm.DataSource = MyTab
        If MyTab.Rows.Count > 0 Then
            FmMaterials.TabMaterialsAlarm.Text = "قائمة التنبيهات ( " & MyTab.Rows.Count & " )"
            'FmMaterials.TabMaterialsAlarm.ForeColor = Color.Red
        Else
            'FmMaterials.TabMaterialsAlarm.Visible = False
            FmMaterials.TabMaterialsAlarm.Text = "قائمة التنبيهات ( فارغ )"
        End If
        DesignMaterialsDGV(FmMaterials.DGVAlarm)

        'FmMaterials.TabMaterialsAlarm.Visible = False
        FillMaterialsList(queMaterials)
        'FmMaterials.DGVMaterialsOff.ClearSelection()
        'FmMaterials.DgvMaterials.ClearSelection()
        'FmMaterials.DGVAlarm.ClearSelection()


    End Sub

    Public Sub MaterialsDataImport(DGV As DataGridView)

        Try
            OpenFileDialog.InitialDirectory = My.Settings.FileDir
            'OpenFileDialog.Filter = "all files (*.*)|*.*|excel files (*.xlsx)|*.xlsx|xls files (*.xls)|*.xls|"
            If OpenFileDialog.ShowDialog(FrmMaterials) = System.Windows.Forms.DialogResult.OK Then


                Dts = New DataSet
                For Each f As String In OpenFileDialog.FileNames
                    Excel = f
                    'SheetName = "[DataSheet$]"
                    Conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=Excel 12.0;")
                    'Dta = New OleDbDataAdapter("select * from [Sheet1$]", Conn)


                    '////******
                    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                    Dim xlApp As New Microsoft.Office.Interop.Excel.Application
                    xlApp.Workbooks.Open(Excel, 0, True)
                    '' For the first sheet in an excel spreadsheet
                    xlWorkSheet = CType(xlApp.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                    SheetName = xlWorkSheet.Name
                    Dta = New OleDbDataAdapter("select * from [" & SheetName & "$]", Conn)

                    '//**********



                    Dta.Fill(Dts, "[sheet1$]")
                    DGV.DataSource = Dts
                    DGV.DataMember = "[sheet1$]"
                    Conn.Close()
                Next

                My.Settings.FileDir = Path.GetDirectoryName(OpenFileDialog.FileName)
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Conn.Close()
        End Try
    End Sub

    Public Sub DesignMaterialsDGV(DGV As DataGridView)
        With DGV
            .Columns(0).Visible = False
            .Columns(1).Visible = True
            .Columns(2).Visible = True
            .Columns(3).Visible = True
            .Columns(4).Visible = True
            .Columns(5).Visible = True
            .Columns(6).Visible = True
            .Columns(7).Visible = True
            .Columns(8).Visible = False
            .Columns(9).Visible = False


            '.Columns(0).HeaderText = "מס"
            .Columns(1).HeaderText = "اسم المادة"
            .Columns(2).HeaderText = "الرمز"
            .Columns(3).HeaderText = "الرمز المحلي"
            .Columns(4).HeaderText = "الكمية"
            .Columns(5).HeaderText = "الكمية الدنيا"
            .Columns(6).HeaderText = "وحدة القياس"
            .Columns(7).HeaderText = "الوزن"
            .Columns(8).HeaderText = "مفعل"
            .Columns(9).HeaderText = "بالاستخدام"



            '.Columns(0).Width = 55
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).Width = 140
            .Columns(2).Width = 120
            .Columns(3).Width = 120
            .Columns(4).Width = 80
            .Columns(5).Width = 80
            .Columns(6).Width = 80
            .Columns(7).Width = 70
            .DefaultCellStyle.Font = New Font(10, 12)
            .ColumnHeadersDefaultCellStyle.Font = New Font(10, 12)
            '.ColumnHeadersDefaultCellStyle. = New Font(10, 12)

            '.Columns(8).Width = 55
            .ClearSelection()


        End With
    End Sub
    Public Sub AddMaterial(material_name As String, material_loc_barcode As String, material_barcode As String, material_quantity As Double, material_min_quantity As Double, material_unit As String, material_weigth As Double)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into materials (material_name,material_loc_barcode,material_barcode,material_quantity,material_min_quantity,material_unit,material_weigth)values(@material_name,@material_loc_barcode,@material_barcode,@material_quantity,@material_min_quantity,@material_unit,@material_weigth)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_name", material_name)
            cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)
            cmd.Parameters.AddWithValue("@material_barcode", material_barcode)
            cmd.Parameters.AddWithValue("@material_quantity", material_quantity)
            cmd.Parameters.AddWithValue("@material_min_quantity", material_min_quantity)
            cmd.Parameters.AddWithValue("@material_unit", material_unit)
            cmd.Parameters.AddWithValue("@material_weigth", material_weigth)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub
    Public Sub DeleteMaterial(id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Update Materials set material_isactive=@material_isactive where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_isactive", 0)
            cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub ReActiveMaterial(id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Update Materials set material_isactive=@material_isactive where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_isactive", 1)
            cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub EditMaterial(material_name As String, material_loc_barcode As String, material_barcode As String, material_quantity As Double, material_min_quantity As Double, material_unit As String, material_weigth As Double, material_isactive As Boolean, id As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update materials set material_name=@material_name,material_barcode=@material_barcode,material_loc_barcode=@material_loc_barcode,material_quantity=@material_quantity,material_min_quantity=@material_min_quantity,material_unit=@material_unit,material_weigth=@material_weigth,material_isactive=@material_isactive,material_inuse=@material_inuse where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_name", material_name)
            cmd.Parameters.AddWithValue("@material_barcode", material_barcode)
            cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)
            cmd.Parameters.AddWithValue("@material_quantity", material_quantity)
            cmd.Parameters.AddWithValue("@material_min_quantity", material_min_quantity)
            cmd.Parameters.AddWithValue("@material_unit", material_unit)
            cmd.Parameters.AddWithValue("@material_weigth", material_weigth)
            cmd.Parameters.AddWithValue("@material_isactive", material_isactive)
            cmd.Parameters.AddWithValue("@material_inuse", 0)


            cmd.Parameters.AddWithValue("@id", id)
            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub inUSEMaterial(id As Integer, IsInUSE As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Update Materials set material_inuse=@material_inuse where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_inuse", IsInUSE)
            cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub inUSEFree()
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Update Materials set material_inuse=@material_inuse where material_inuse = 1"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_inuse", 0)
            'cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            MsgBox("تم تحرير جميع نوافذ المواد", vbOKOnly + vbInformation, "استعلام")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub
    Public Sub AddMaterialPrice(material_id As Integer, price_year As Integer, material_main_price As Double)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into material_prices (material_id,price_year,material_main_price,material_price)values(@material_id,@price_year,@material_main_price,@material_price)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_id", material_id)
            cmd.Parameters.AddWithValue("@price_year", price_year)
            cmd.Parameters.AddWithValue("@material_main_price", material_main_price)
            cmd.Parameters.AddWithValue("@material_price", material_main_price)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub EditMaterialPrice(id As Integer, material_price As Double, material_main_price As Double, price_discount As Double)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update material_prices set material_main_price=@material_main_price,material_price=@material_price,price_discount=@price_discount where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_main_price", material_main_price)
            cmd.Parameters.AddWithValue("@material_price", material_price)
            cmd.Parameters.AddWithValue("@price_discount", price_discount)
            cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub DeleteMaterialPrice(id As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Delete from material_prices where id = @id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub AddMaterialType(type_name As String, type_quantity As Double, material_id As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into material_types (type_name,type_quantity,material_id)values(@type_name,@type_quantity,@material_id)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@type_name", type_name)
            cmd.Parameters.AddWithValue("@type_quantity", type_quantity)
            cmd.Parameters.AddWithValue("@material_id", material_id)


            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub
End Module
