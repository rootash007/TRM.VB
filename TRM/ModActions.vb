Imports System.Data.SqlClient
Imports System.Globalization

Module ModActions


    Public ActionStartDate As Date
    Public ActionEndDate As Date
    Public ActionsQuery As String
    Public isAddAction As Boolean



    Public Sub AddAction(material_name As String, material_loc_barcode As String, material_barcode As String, block_number As String, action_user As String, action_type As String, material_quantity As Double, action_date As DateTime, vendor_name As String, action_order As String, more_info As String, new_quantity As Double, action_isincrease As Boolean)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into actions (material_name,material_loc_barcode,material_barcode,block_number,action_user,action_type,material_quantity,action_date,vendor_name,action_order,more_info,action_isincrease)values(@material_name,@material_loc_barcode,@material_barcode,@block_number,@action_user,@action_type,@material_quantity,@action_date,@vendor_name,@action_order,@more_info,@action_isincrease)"

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




            .Columns(0).Width = 30
            .Columns(1).Width = 100
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 70
            .Columns(6).Width = 70
            .Columns(7).Width = 120
            .Columns(8).Width = 70
            .Columns(9).Width = 50
            .Columns(12).Width = 70
            .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(8).DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm")


            .Columns(12).DisplayIndex = 6
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

    Public Sub MakeQuery()
        'ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date"
        'If FmActions.CBOutActions.Checked = True And FmActions.CBInActions.Checked = True Then
        '    ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date"
        'ElseIf FmActions.CBOutActions.Checked = False And FmActions.CBInActions.Checked = True Then
        '    ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date and action_isincrease = 1"
        'ElseIf FmActions.CBOutActions.Checked = True And FmActions.CBInActions.Checked = False Then
        '    ActionsQuery = "select * from actions where action_date >= @start_date and action_date <= @end_date and action_isincrease = 0"
        'ElseIf FmActions.CBOutActions.Checked = False And FmActions.CBInActions.Checked = False Then
        '    MsgBox("at least one of these options should be on")

        'End If
        'ActionsQuery += " order by action_date"
        'ReloadActions()
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
            MsgBox("at least one of ont or in options should be on", vbOKOnly + vbCritical, "error")
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
            worksheet.Name = "דוח פעולות"
            'worksheet.Cells(row,column).value = "test"

            'For i = 0 To FrmCounts.DGVBadsKinds.RowCount - 1
            '    If FrmCounts.DGVBadsKinds.Rows(i).Cells(FrmCounts.DGVBadsKinds.Columns.Count - 1).Value.Contains("רץ") Then
            '        RazCount += 1
            '    Else
            '        SqurCount += 1
            '    End If
            'Next


            For i = 0 To FmActions.DgvActionsList.ColumnCount - 1
                worksheet.Cells(1, i + 1).value = FmActions.DgvActionsList.Columns(i).HeaderText
                For d = 0 To FmActions.DgvActionsList.RowCount - 1
                    worksheet.Cells(d + 2, i + 1).value = FmActions.DgvActionsList.Rows(d).Cells(i).Value
                    FrmMain.TSMainProgBar.Increment(1)
                Next
                'If i < 6 Then
                '    For d = 0 To FmActions.DgvActionsList.RowCount - 1
                '        worksheet.Cells(d + 2, i + 1).value = FmActions.DgvActionsList.Rows(d).Cells(i).Value
                '        FrmMain.TSMainProgBar.Increment(1)
                '    Next
                'ElseIf i = 6 Then
                '    For d = 0 To FmActions.DgvActionsList.RowCount - 1
                '        worksheet.Cells(d + 2, i + 1).value = FmActions.DgvActionsList.Rows(d).Cells(i + 6).Value
                '        FrmMain.TSMainProgBar.Increment(1)
                '    Next
                'ElseIf i > 6 Then
                '    For d = 0 To FmActions.DgvActionsList.RowCount - 1
                '        worksheet.Cells(d + 2, i + 2).value = FmActions.DgvActionsList.Rows(d).Cells(i).Value
                '        FrmMain.TSMainProgBar.Increment(1)
                '    Next
                'ElseIf 1 = 11 Then
                '    'For d = 0 To FmActions.DgvActionsList.RowCount - 1
                '    '    worksheet.Cells(d + 2, i - 6).value = FmActions.DgvActionsList.Rows(d).Cells(i).Value
                '    '    FrmMain.TSMainProgBar.Increment(1)
                '    'Next

                'End If
                'If i = 0 Then
                '    For d = 0 To FrmCounts.DGVBadsKinds.Columns.Count - 1
                '        worksheet.Cells(2, 7 + d).value = FrmCounts.DGVBadsKinds.Columns(d).HeaderText
                '        worksheet.Cells(5 + RazCount, 7 + d).value = FrmCounts.DGVBadsKinds.Columns(d).HeaderText
                '    Next
                'End If
                'If FrmCounts.DGVBadsKinds.Rows(i).Cells(FrmCounts.DGVBadsKinds.Columns.Count - 1).Value.Contains("רץ") Then
                '    For d = 0 To FrmCounts.DGVBadsKinds.Columns.Count - 1
                '        worksheet.Cells(3 + RazColumn, 7 + d).value = FrmCounts.DGVBadsKinds.Rows(i).Cells(d).Value

                '    Next
                '    RazColumn += 1
                'Else
                '    For d = 0 To FrmCounts.DGVBadsKinds.Columns.Count - 1
                '        worksheet.Cells(6 + RazCount + SqurColumn, 7 + d).value = FrmCounts.DGVBadsKinds.Rows(i).Cells(d).Value
                '    Next
                '    SqurColumn += 1
                'End If
            Next
            'FrmProgressBar.ProgBar.Increment(20)

            ''**Goods**
            'Dim FamilyChk As String
            'Dim FamilyCol As Integer
            'Dim PassSqr As Integer = 0
            'Dim Passratz As Integer = 0
            'RazCount = 0
            'SqurCount = 0
            'For i = 0 To FrmCounts.DgvGoods.RowCount - 1
            '    FamilyChk = FrmCounts.DgvGoods.Rows(i).Cells(0).Value
            '    For R = 0 To FamilyTab.Columns.Count - 1
            '        For T = 0 To FamilyTab.Rows.Count - 1
            '            If FamilyChk.Contains(FamilyTab.Rows(T).Item(R)) Then
            '                If R = 0 Or R = 2 Then
            '                    SqurCount += 1
            '                Else
            '                    RazCount += 1
            '                End If
            '            End If
            '        Next
            '    Next
            'Next

            'For i = 0 To FrmCounts.DgvGoods.RowCount - 1
            '    FamilyChk = FrmCounts.DgvGoods.Rows(i).Cells(0).Value
            '    For R = 0 To FamilyTab.Columns.Count - 1
            '        For T = 0 To FamilyTab.Rows.Count - 1
            '            If FamilyChk.Contains(FamilyTab.Rows(T).Item(R)) Then
            '                FamilyCol = R
            '            End If
            '        Next
            '    Next
            '    If FamilyCol = 0 Or FamilyCol = 2 Then
            '        PassSqr += 1
            '    Else
            '        Passratz += 1
            '    End If
            '    For D = 0 To FrmCounts.DgvGoods.Columns.Count - 1
            '        If i = 0 Then
            '            worksheet.Cells(10, 1 + D).value = FrmCounts.DgvGoods.Columns(D).HeaderText
            '            worksheet.Cells(12 + SqurCount, 1 + D).value = FrmCounts.DgvGoods.Columns(D).HeaderText
            '        End If
            '        If FamilyCol = 0 Or FamilyCol = 2 Then
            '            worksheet.Cells(10 + PassSqr, 1 + D).value = FrmCounts.DgvGoods.Rows(i).Cells(D).Value
            '        Else
            '            worksheet.Cells(12 + SqurCount + Passratz, 1 + D).value = FrmCounts.DgvGoods.Rows(i).Cells(D).Value
            '        End If
            '    Next
            'Next

            '**Timers\Pakas**
            'worksheet = workbook.Sheets.Add
            'worksheet.Name = "דוח D"
            'FrmProgressBar.ProgBar.Increment(20)

            'For i = 0 To FrmCounts.DGVCount.ColumnCount - 1
            '    worksheet.Cells(2, 2 + i).value = FrmCounts.DGVCount.Columns(i).HeaderText
            '    For b = 0 To FrmCounts.DGVCount.RowCount - 1
            '        worksheet.Cells(4 + b, 2 + i).value = FrmCounts.DGVCount.Rows(b).Cells(i).Value
            '    Next
            'Next

            'FrmProgressBar.ProgBar.Increment(10)
            'If FrmProgressBar.ProgBar.Value = 100 Then
            '    FrmProgressBar.Close()
            'End If


            '**Operators**
            'Dim AllZero As Boolean = True
            'Dim Empt As Integer = 0
            'Dim UperZero As Boolean = False
            'Dim locat As String

            'worksheet = workbook.Sheets.Add
            'worksheet.Name = "דוח מפעילים אריזה"
            'For i = 0 To OprTab.Rows.Count - 1
            '    If i = 0 Then
            '        'adding the columns names
            '        For b = 0 To OprTab.Columns.Count - 1
            '            worksheet.Cells(2 + i, 2 + b).value = OprTab.Rows(i).Item(b)
            '        Next
            '    Else
            '        If OprTab.Rows(i).Item(0).ToString.Contains("משמרות") Then
            '            If UperZero = False Then
            '                worksheet.Cells(2 + i - Empt, 2).value = OprTab.Rows(i).Item(0)
            '                For b = 1 To OprTab.Columns.Count - 1
            '                    If OprTab.Rows(i - 1).Item(b) <> 0 Then
            '                        locat = "=" & Chr(66 + b) & (1 + i + Empt) & "/ 8"
            '                        worksheet.Cells(2 + i - Empt, 2 + b).value = locat ''Asc(65)
            '                    Else
            '                        worksheet.Cells(2 + i - Empt, 2 + b).value = OprTab.Rows(i).Item(b)
            '                    End If
            '                Next
            '                Empt -= 1
            '                worksheet.Cells(2 + i - Empt, 2).value = OprTab.Rows(i + 1).Item(0)
            '                For b = 1 To OprTab.Columns.Count - 1
            '                    If OprTab.Rows(i - 1).Item(b) <> 0 Then
            '                        locat = "=" & Chr(66 + b) & (1 + i + Empt) & "/" & Chr(66 + b) & (3 + i + Empt)
            '                        worksheet.Cells(2 + i - Empt, 2 + b).value = locat ''Asc(65)

            '                    Else
            '                        worksheet.Cells(2 + i - Empt, 2 + b).value = "תפוקה"

            '                    End If
            '                Next
            '                UperZero = False
            '                Empt += 1

            '            End If
            '        ElseIf OprTab.Rows(i).Item(0).ToString.Contains("תפוקת") Then

            '        Else
            '            For b = 1 To OprTab.Columns.Count - 1
            '                If OprTab.Rows(i).Item(b) <> 0 Then
            '                    AllZero = False
            '                End If
            '            Next
            '            If AllZero = False Then
            '                For b = 0 To OprTab.Columns.Count - 1
            '                    worksheet.Cells(2 + i - Empt, 2 + b).value = OprTab.Rows(i).Item(b)
            '                Next
            '                AllZero = True
            '                UperZero = False
            '            Else
            '                Empt += 1
            '                UperZero = True
            '            End If
            '        End If
            '    End If

            'Next
            'If ShiftsChk = True Then

            'End If

            '***Shaerit**
            'worksheet = workbook.Sheets.Add
            'worksheet.Name = "דוח פקע''ות"

            'For i = 0 To FrmCounts.DGVPaka.ColumnCount - 1
            '    worksheet.Cells(2, 2 + i).value = FrmCounts.DGVPaka.Columns(i).Name

            '    For b = 0 To FrmCounts.DGVPaka.RowCount - 1

            '        worksheet.Cells(3 + b, 2 + i).value = FrmCounts.DGVPaka.Rows(b).Cells(i).Value
            '    Next
            '    FrmProgressBar.ProgBar.Increment(5)
            '    If FrmProgressBar.ProgBar.Value >= 100 Then
            '        FrmProgressBar.Close()
            '    End If
            'Next
            ''end adding 
            Dim SaveDialog As New SaveFileDialog()
            SaveDialog.Filter = "Excel Files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveDialog.FilterIndex = 2

            If SaveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(SaveDialog.FileName)
                MsgBox("יצירת קובץ הסתיימה בהצלחה", vbOKOnly + vbInformation, "נשמר בהצלחה")
                Dim ExcelFileName As String
                ExcelFileName = SaveDialog.FileName

                If ExcelFileName.Contains("xlsx") Then
                    ExcelFileName = SaveDialog.FileName
                Else
                    ExcelFileName = SaveDialog.FileName & ".xlsx"
                End If
                Dim ExitMsg As DialogResult
                workbook.Close()

                ExitMsg = MsgBox("האם לפתוח את הדוח הנוצר באקסיל", vbYesNo + vbQuestion, "הצגת דוח")
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

    Public Sub DeleteAction(id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "delete from actions where id=@id"
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
    Public Sub EditAction(material_name As String, material_loc_barcode As String, material_barcode As String, block_number As String, action_type As String, material_quantity As Double, action_date As DateTime, vendor_name As String, action_order As String, more_info As String, new_quantity As Double, action_isincrease As Boolean, id As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update actions set material_name=@material_name,material_loc_barcode=@material_loc_barcode,material_barcode=@material_barcode,block_number=@block_number,action_type=@action_type,material_quantity=@material_quantity,action_date=@action_date,vendor_name=@vendor_name,action_order=@action_order,more_info=@more_info,action_isincrease=@action_isincrease where id=@id"

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
