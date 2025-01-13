Imports System.Data.SqlClient
Imports System.Globalization

Module Actions_Controller


    Public ActionStartDate As Date
    Public ActionEndDate As Date
    Public ActionsQuery As String
    Public isAddAction As Boolean
    Public ActionSender As String




    Public Sub AddAction(material_name As String, material_loc_barcode As String, material_barcode As String, block_number As String, action_user As String, action_type As String, material_quantity As Double, action_date As DateTime, vendor_name As String, action_order As String, more_info As String, new_quantity As Double, action_isincrease As Boolean, total_price As Double)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into actions (material_name,material_loc_barcode,material_barcode,block_number,action_user,action_type,material_quantity,action_date,vendor_name,action_order,more_info,action_isincrease,total_price)values(@material_name,@material_loc_barcode,@material_barcode,@block_number,@action_user,@action_type,@material_quantity,@action_date,@vendor_name,@action_order,@more_info,@action_isincrease,@total_price)"

                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_name", material_name)
            cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)
            cmd.Parameters.AddWithValue("@material_barcode", material_barcode)
            cmd.Parameters.AddWithValue("@block_number", block_number)
            cmd.Parameters.AddWithValue("@action_user", action_user)
            cmd.Parameters.AddWithValue("@action_type", action_type)
            cmd.Parameters.AddWithValue("@material_quantity", material_quantity)
            cmd.Parameters.AddWithValue("@action_date", action_date)
            cmd.Parameters.AddWithValue("@vendor_name", vendor_name)
            cmd.Parameters.AddWithValue("@action_order", action_order)
            cmd.Parameters.AddWithValue("@more_info", more_info)
            cmd.Parameters.AddWithValue("@new_quantity", new_quantity)
            cmd.Parameters.AddWithValue("@action_isincrease", action_isincrease)
            cmd.Parameters.AddWithValue("@total_price", total_price)


            dbcon.Open()
            cmd.ExecuteNonQuery()
            'dbcon.Close()

            'cmd = New SqlCommand
            With cmd
                '.CommandType = CommandType.Text
                .CommandText = "Update materials set material_quantity=@new_quantity where material_loc_barcode=@material_loc_barcode"

                '.Connection = dbcon
            End With
            'cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)

            'dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub DesignActionsDGV(dgv As DataGridView)
        With dgv
            .Columns(0).Visible = True
            .Columns(1).Visible = True
            .Columns(2).Visible = True
            .Columns(3).Visible = True
            .Columns(4).Visible = True
            .Columns(5).Visible = True
            .Columns(6).Visible = True
            .Columns(7).Visible = True
            .Columns(8).Visible = True
            .Columns(9).Visible = True
            .Columns(10).Visible = True
            .Columns(11).Visible = False
            .Columns(12).Visible = True
            If isAllowed(10) = True Or AdminMode = True Then
                .Columns(13).Visible = True
                .Columns(13).HeaderText = "سعر الكميه"
                .Columns(13).Width = 70

            Else
                .Columns(13).Visible = False
            End If




            .Columns(0).HeaderText = "التسلسل"
            .Columns(1).HeaderText = "اسم المادة"
            .Columns(2).HeaderText = "الرمز المحلي"
            .Columns(3).HeaderText = "باركود"
            .Columns(4).HeaderText = "رقم المشتاح"
            .Columns(5).HeaderText = "المستخدم"
            .Columns(6).HeaderText = "الكمية"
            .Columns(7).HeaderText = "التاريخ"
            .Columns(8).HeaderText = "المورد"
            .Columns(9).HeaderText = "رقم الانتاج"
            .Columns(10).HeaderText = "معلومات"
            .Columns(11).HeaderText = "action isincrease"
            .Columns(12).HeaderText = "نوع العملية"




            .Columns(0).Width = 50
            .Columns(1).Width = 100
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 70
            .Columns(6).Width = 70
            .Columns(7).Width = 100
            .Columns(8).Width = 70
            .Columns(9).Width = 50
            .Columns(12).Width = 70
            .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(8).DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm")


            .Columns(12).DisplayIndex = 6
            .Columns(13).DisplayIndex = 8

            .Columns(7).DefaultCellStyle.Format = ("dd/MM/yyyy")

            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'dgv.ClearSelection()
            '.rows(0).DefaultCellStyle.BackColor = 
            '.Columns(1).SortMode = 3


        End With
    End Sub

    Public Sub FillActionsList(Que As String)
        cmd = New SqlCommand
        ActionsTab = New DataTable
        Try
            ActionsTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Que
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@start_date", FmActions.DTPStartDate.Value)
            cmd.Parameters.AddWithValue("@end_date", FmActions.DTPEndDate.Value)
            cmd.Parameters.AddWithValue("@action_user", FmActions.CmbUserName.Text)
            cmd.Parameters.AddWithValue("@material_name", FmActions.CmbMaterial.Text)
            'cmd.Parameters.AddWithValue("@vendor_name", FmActions.TxtVendor.Text)


            'cmd.Parameters.AddWithValue("d2", FrmSoldReport.DtpTo.Value)
            dbcon.Open()
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(ActionsTab)
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub ActionsFormPrepair()
        With FmActions
            FmActions.DTPStartDate.Value = Today
            FmActions.DTPEndDate.Value = Today.AddHours(23).AddMinutes(59).AddSeconds(59)
            FmActions.CBInActions.Checked = True
            FmActions.CBOutActions.Checked = True

            Dim que As String = "select * from users where user_isactive = 1"
            FillList(que)
            FmActions.CmbUserName.DataSource = MyTab
            FmActions.CmbUserName.DisplayMember = "user_name"
            FmActions.CmbUserName.ValueMember = "id"
            FmActions.CmbUserName.SelectedIndex = -1

            que = "select * from materials where material_isactive = 1"
            FillList(que)
            FmActions.CmbMaterial.DataSource = MyTab
            FmActions.CmbMaterial.DisplayMember = "material_name"
            FmActions.CmbMaterial.ValueMember = "id"
            FmActions.CmbMaterial.SelectedIndex = -1
        End With
    End Sub

    Public Sub ReloadActions()
        ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date"
        If FmActions.CBOutActions.Checked = True And FmActions.CBInActions.Checked = True Then
            ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date"
        ElseIf FmActions.CBOutActions.Checked = False And FmActions.CBInActions.Checked = True Then
            ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date and action_isincrease = 1"
        ElseIf FmActions.CBOutActions.Checked = True And FmActions.CBInActions.Checked = False Then
            ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date and action_isincrease = 0"
        ElseIf FmActions.CBOutActions.Checked = False And FmActions.CBInActions.Checked = False Then
            MsgBox("لا يمكن الغاء الخيارين , يجب تفعيل واحده من الخيارات على الاقل", vbOKOnly + vbCritical, "خطأ")
            Return
        End If
        If FmActions.CmbUserName.Text <> "" Then
            ActionsQuery += " and action_user = @action_user"
        End If
        If FmActions.CmbMaterial.Text <> "" Then
            ActionsQuery += " and material_name = @material_name"
        End If
        If FmActions.TxtVendor.Text <> "" Then
            ActionsQuery += " and vendor_name like '%" & FmActions.TxtVendor.Text & "%'"
            'ActionsQuery += " and vendor_name like '% @vendor_name %'"
        End If
        ActionsQuery += " order by action_date"
        FillActionsList(ActionsQuery)
        FmActions.DgvActionsList.DataSource = ActionsTab
        DesignActionsDGV(FmActions.DgvActionsList)
    End Sub

    Public Sub ExportActionsToExcel()
        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        Dim columnsCount As Integer = FmActions.DgvActionsList.Columns.Count
        FrmMain.TSMainProgBar.Increment(10)
        Try
            worksheet = workbook.ActiveSheet
            worksheet.Name = "ملف العمليات"


            For i = 0 To FmActions.DgvActionsList.ColumnCount - 1
                worksheet.Cells(1, i + 1).value = FmActions.DgvActionsList.Columns(i).HeaderText
                For d = 0 To FmActions.DgvActionsList.RowCount - 1
                    worksheet.Cells(d + 2, i + 1).value = FmActions.DgvActionsList.Rows(d).Cells(i).Value
                    FrmMain.TSMainProgBar.Increment(1)
                Next

            Next


            Dim SaveDialog As New SaveFileDialog()
            SaveDialog.Filter = "Excel Files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveDialog.FilterIndex = 2

            If SaveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(SaveDialog.FileName)
                MsgBox("تم حفظ الملف بنجاح", vbOKOnly + vbInformation, "حفظ الملف")
                Dim ExcelFileName As String
                ExcelFileName = SaveDialog.FileName

                If ExcelFileName.Contains("xlsx") Then
                    ExcelFileName = SaveDialog.FileName
                Else
                    ExcelFileName = SaveDialog.FileName & ".xlsx"
                End If
                Dim ExitMsg As DialogResult
                workbook.Close()

                ExitMsg = MsgBox("هل تريد فتح الملف", vbYesNo + vbQuestion, "عرض الملف")
                If ExitMsg = 6 Then
                    Process.Start(ExcelFileName)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try
        FrmMain.TSMainProgBar.Value = 0

    End Sub

    Public Sub DeleteAction(id As Integer, material_loc_barcode As String, new_quantity As Double)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "delete from actions where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@new_quantity", new_quantity)
            cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)



            dbcon.Open()
            cmd.ExecuteNonQuery()
            'dbcon.Close()

            'cmd = New SqlCommand
            With cmd
                '.CommandType = CommandType.Text
                .CommandText = "Update materials set material_quantity=@new_quantity where material_loc_barcode=@material_loc_barcode"

                '.Connection = dbcon
            End With
            'cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)

            'dbcon.Open()
            cmd.ExecuteNonQuery()

            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub
    Public Sub EditAction(material_name As String, material_loc_barcode As String, material_barcode As String, block_number As String, action_type As String, material_quantity As Double, action_date As DateTime, vendor_name As String, action_order As String, more_info As String, new_quantity As Double, action_isincrease As Boolean, id As Integer, total_price As Double)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update actions set material_name=@material_name,material_loc_barcode=@material_loc_barcode,material_barcode=@material_barcode,block_number=@block_number,action_type=@action_type,material_quantity=@material_quantity,action_date=@action_date,vendor_name=@vendor_name,action_order=@action_order,more_info=@more_info,action_isincrease=@action_isincrease,total_price=@total_price where id=@id"

                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@material_name", material_name)
            cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)
            cmd.Parameters.AddWithValue("@material_barcode", material_barcode)
            cmd.Parameters.AddWithValue("@block_number", block_number)
            cmd.Parameters.AddWithValue("@action_type", action_type)
            cmd.Parameters.AddWithValue("@material_quantity", material_quantity)
            cmd.Parameters.AddWithValue("@action_date", action_date)
            cmd.Parameters.AddWithValue("@vendor_name", vendor_name)
            cmd.Parameters.AddWithValue("@action_order", action_order)
            cmd.Parameters.AddWithValue("@more_info", more_info)
            cmd.Parameters.AddWithValue("@new_quantity", new_quantity)
            cmd.Parameters.AddWithValue("@action_isincrease", action_isincrease)
            cmd.Parameters.AddWithValue("@total_price", total_price)
            cmd.Parameters.AddWithValue("@id", id)


            dbcon.Open()
            cmd.ExecuteNonQuery()
            'dbcon.Close()

            'cmd = New SqlCommand
            With cmd
                '.CommandType = CommandType.Text
                .CommandText = "Update materials set material_quantity=@new_quantity where material_loc_barcode=@material_loc_barcode"

                '.Connection = dbcon
            End With
            'cmd.Parameters.AddWithValue("@material_loc_barcode", material_loc_barcode)

            'dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub
    'Public Sub EditUser(user_name As String, user_pass As String, user_lvl As Integer, id As Integer, user_phone As String, user_isactive As Boolean)
    '    Try
    '        cmd = New SqlCommand
    '        With cmd
    '            .CommandType = CommandType.Text
    '            .CommandText = "update users set user_name=@user_name,user_pass=@user_pass,user_lvl=@user_lvl,user_phone=@user_phone,user_isactive=@user_isactive where id=@id"
    '            .Connection = dbcon
    '        End With
    '        cmd.Parameters.AddWithValue("@user_name", user_name)
    '        cmd.Parameters.AddWithValue("@user_pass", user_pass)
    '        cmd.Parameters.AddWithValue("@user_lvl", user_lvl)
    '        cmd.Parameters.AddWithValue("@user_phone", user_phone)
    '        cmd.Parameters.AddWithValue("@user_isactive", user_isactive)

    '        cmd.Parameters.AddWithValue("@id", id)
    '        dbcon.Open()
    '        cmd.ExecuteNonQuery()
    '        dbcon.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        dbcon.Close()
    '    End Try
    'End Sub



    'Public Sub ReActiveUser(id As Integer)
    '    Try
    '        cmd = New SqlCommand

    '        With cmd
    '            .CommandType = CommandType.Text
    '            .CommandText = "Update Users set user_isactive=@user_isactive where id=@id"
    '            .Connection = dbcon
    '        End With
    '        cmd.Parameters.AddWithValue("@user_isactive", 1)
    '        cmd.Parameters.AddWithValue("@id", id)

    '        dbcon.Open()
    '        cmd.ExecuteNonQuery()
    '        dbcon.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        dbcon.Close()
    '    End Try
    'End Sub

    'Public Sub LoadNewUser(Frm As Object)
    '    Frm.BtnUserAU.Image = My.Resources.adduser
    '    Frm.Text = "הוספת משתמש חדש"
    '    Frm.BtnUserAU.Text = "הוספת משתמש"
    '    Frm.NumUserLvl.Value = 2
    'End Sub

    'Public Sub LoadEditUser()
    '    If FmUsers.TabUsers.SelectedIndex = 0 Then
    '        With FmUserAddEdit
    '            .BtnUserAU.Image = My.Resources.save
    '            .Text = ""
    '            .BtnUserAU.Text = "עדכון משתמש"
    '            .TxtUserName.Text = FmUsers.DgvUsers.CurrentRow.Cells(1).Value
    '            .TxtPassWord.Text = FmUsers.DgvUsers.CurrentRow.Cells(2).Value
    '            .NumUserLvl.Value = FmUsers.DgvUsers.CurrentRow.Cells(3).Value
    '            .TxtPhone.Text = FmUsers.DgvUsers.CurrentRow.Cells(4).Value
    '        End With
    '        Switcher = True
    '        FmUserAddEdit.StatusSwitch.Image = My.Resources.swon1
    '    Else
    '        With FmUserAddEdit
    '            .BtnUserAU.Image = My.Resources.save
    '            .Text = ""
    '            .BtnUserAU.Text = "עדכון משתמש"
    '            .TxtUserName.Text = FrmUsers.DGVUsersOff.CurrentRow.Cells(1).Value
    '            .TxtPassWord.Text = FrmUsers.DGVUsersOff.CurrentRow.Cells(2).Value
    '            .NumUserLvl.Value = FrmUsers.DGVUsersOff.CurrentRow.Cells(3).Value
    '            .TxtPhone.Text = FrmUsers.DGVUsersOff.CurrentRow.Cells(4).Value
    '        End With
    '        Switcher = False
    '        FmUserAddEdit.StatusSwitch.Image = My.Resources.swoff1
    '    End If
    'End Sub

    'Public Sub LoadUsers()
    '    Dim queOn As String
    '    Dim queOff As String

    '    queOn = "select * from users where user_lvl > 0 and user_isactive=1"
    '    queOff = "select * from users where user_lvl > 0 and user_isactive=0"

    '    FillList(queOn)
    '    FmUsers.DgvUsers.DataSource = MyTab
    '    DesignUsersDGV(FmUsers.DgvUsers)

    '    FillList(queOff)
    '    FmUsers.DGVUsersOff.DataSource = MyTab
    '    DesignUsersDGV(FmUsers.DGVUsersOff)

    'End Sub

    'Public Sub DesignUsersDGV(DGV As DataGridView)
    '    With DGV
    '        .Columns(0).Visible = True
    '        .Columns(1).Visible = True
    '        .Columns(2).Visible = True
    '        .Columns(3).Visible = True
    '        .Columns(4).Visible = True
    '        .Columns(5).Visible = False
    '        '.Columns(6).Visible = False
    '        '.Columns(7).Visible = False
    '        '.Columns(8).Visible = False
    '        '.Columns(2).DefaultCellStyle.Format = "*"

    '        .Columns(0).HeaderText = "מס"
    '        .Columns(1).HeaderText = "שם משתמש"
    '        .Columns(2).HeaderText = "סיסמה"
    '        .Columns(3).HeaderText = "רמת שליטה"
    '        .Columns(4).HeaderText = "טלפון"


    '        .Columns(0).Width = 55
    '        .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '        '.Columns(1).Width = 140
    '        .Columns(2).Width = 140
    '        .Columns(3).Width = 55

    '    End With
    'End Sub




End Module
