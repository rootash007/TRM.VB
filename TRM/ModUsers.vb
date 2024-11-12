Imports System.Data.SqlClient

Module ModUsers
    Public isAddUser As Boolean

    Public Sub AddUser(user_name As String, user_pass As String, user_lvl As Integer, user_phone As String)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into users (user_name,user_pass,user_lvl,user_phone)values(@user_name,@user_pass,@user_lvl,@user_phone)"
                .Connection = dbcon

            End With
            cmd.Parameters.AddWithValue("@user_name", user_name)
            cmd.Parameters.AddWithValue("@user_pass", user_pass)
            cmd.Parameters.AddWithValue("@user_lvl", user_lvl)
            cmd.Parameters.AddWithValue("@user_phone", user_phone)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub EditUser(user_name As String, user_pass As String, user_lvl As Integer, id As Integer, user_phone As String, user_isactive As Boolean)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update users set user_name=@user_name,user_pass=@user_pass,user_lvl=@user_lvl,user_phone=@user_phone,user_isactive=@user_isactive where id=@id"
                .Connection = dbcon

            End With
            cmd.Parameters.AddWithValue("@user_name", user_name)
            cmd.Parameters.AddWithValue("@user_pass", user_pass)
            cmd.Parameters.AddWithValue("@user_lvl", user_lvl)
            cmd.Parameters.AddWithValue("@user_phone", user_phone)
            cmd.Parameters.AddWithValue("@user_isactive", user_isactive)

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

    Public Sub DeleteUser(id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Update Users set user_isactive=@user_isactive where id=@id"
                .Connection = dbcon

            End With
            cmd.Parameters.AddWithValue("@user_isactive", 0)
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

    Public Sub ReActiveUser(id As Integer)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "Update Users set user_isactive=@user_isactive where id=@id"
                .Connection = dbcon

            End With
            cmd.Parameters.AddWithValue("@user_isactive", 1)
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

    Public Sub LoadNewUser(Frm As Object)
        Frm.BtnUserAU.Image = My.Resources.adduser
        Frm.Text = "הוספת משתמש חדש"
        Frm.BtnUserAU.Text = "הוספת משתמש"
        Frm.NumUserLvl.Value = 2
    End Sub

    Public Sub LoadEditUser()
        If FmUsers.TabUsers.SelectedIndex = 0 Then
            With FmUserAddEdit
                .BtnUserAU.Image = My.Resources.save
                .Text = ""
                .BtnUserAU.Text = "עדכון משתמש"
                .TxtUserName.Text = FmUsers.DgvUsers.CurrentRow.Cells(1).Value
                .TxtPassWord.Text = FmUsers.DgvUsers.CurrentRow.Cells(2).Value
                .NumUserLvl.Value = FmUsers.DgvUsers.CurrentRow.Cells(3).Value
                .TxtPhone.Text = FmUsers.DgvUsers.CurrentRow.Cells(4).Value
            End With
            Switcher = True
            FmUserAddEdit.StatusSwitch.Image = My.Resources.swon1
        Else
            With FmUserAddEdit
                .BtnUserAU.Image = My.Resources.save
                .Text = ""
                .BtnUserAU.Text = "עדכון משתמש"
                .TxtUserName.Text = FrmUsers.DGVUsersOff.CurrentRow.Cells(1).Value
                .TxtPassWord.Text = FrmUsers.DGVUsersOff.CurrentRow.Cells(2).Value
                .NumUserLvl.Value = FrmUsers.DGVUsersOff.CurrentRow.Cells(3).Value
                .TxtPhone.Text = FrmUsers.DGVUsersOff.CurrentRow.Cells(4).Value
            End With
            Switcher = False
            FmUserAddEdit.StatusSwitch.Image = My.Resources.swoff1
        End If
    End Sub

    Public Sub LoadUsers()
        Dim queOn As String
        Dim queOff As String

        queOn = "select * from users where user_lvl > 0 and user_isactive=1"
        queOff = "select * from users where user_lvl > 0 and user_isactive=0"

        FillList(queOn)
        FmUsers.DgvUsers.DataSource = MyTab
        DesignUsersDGV(FmUsers.DgvUsers)

        FillList(queOff)
        FmUsers.DGVUsersOff.DataSource = MyTab
        DesignUsersDGV(FmUsers.DGVUsersOff)

    End Sub

    Public Sub DesignUsersDGV(DGV As DataGridView)
        With DGV
            .Columns(0).Visible = True
            .Columns(1).Visible = True
            .Columns(2).Visible = True
            .Columns(3).Visible = True
            .Columns(4).Visible = True
            .Columns(5).Visible = False
            '.Columns(6).Visible = False
            '.Columns(7).Visible = False
            '.Columns(8).Visible = False
            '.Columns(2).DefaultCellStyle.Format = "*"

            .Columns(0).HeaderText = "מס"
            .Columns(1).HeaderText = "שם משתמש"
            .Columns(2).HeaderText = "סיסמה"
            .Columns(3).HeaderText = "רמת שליטה"
            .Columns(4).HeaderText = "טלפון"


            .Columns(0).Width = 55
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).Width = 140
            .Columns(2).Width = 140
            .Columns(3).Width = 55

        End With
    End Sub

End Module
