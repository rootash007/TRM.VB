Public Class FrmUserAddEdit

    Private Sub BtnUserAU_Click(sender As Object, e As EventArgs) Handles BtnUserAU.Click
        If TxtUserName.Text = "" Or TxtPassWord.Text = "" Or TxtPhone.Text = "" Then
            MsgBox("", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "")
            Return
        End If
        If isAddUser = True Then
            AddUser(TxtUserName.Text, TxtPassWord.Text, NumUserLvl.Value, TxtPhone.Text)
        Else
            'EditUser(TxtUserName.Text, TxtPassWord.Text, NumUserLvl.Value, FmUsers.DgvUsers.CurrentRow.Cells(0).Value, TxtPhone.Text, Switcher)

            If FmUsers.TabUsers.SelectedIndex = 0 Then
                EditUser(TxtUserName.Text, TxtPassWord.Text, NumUserLvl.Value, FmUsers.DgvUsers.CurrentRow.Cells(0).Value, TxtPhone.Text, Switcher)
            Else
                EditUser(TxtUserName.Text, TxtPassWord.Text, NumUserLvl.Value, FmUsers.DGVUsersOff.CurrentRow.Cells(0).Value, TxtPhone.Text, Switcher)

            End If
        End If
        Me.Close()
        LoadUsers()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUserName.KeyDown, TxtPassWord.KeyDown, NumUserLvl.KeyDown, BtnUserAU.KeyDown, BtnClose.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub StatusSwitch_Click(sender As Object, e As EventArgs) Handles StatusSwitch.Click
        If Switcher = True Then
            StatusSwitch.Image = My.Resources.swoff1
            Switcher = False
            'LblStatus.Text = "לא פעיל"
        Else
            StatusSwitch.Image = My.Resources.swon1
            Switcher = True
            'LblStatus.Text = "פעיל"
        End If
    End Sub

    Private Sub FrmUserAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isAddUser = True Then
            FmUserAddEdit.BtnUserAU.Image = My.Resources.adduser
            FmUserAddEdit.Text = "הוספת משתמש חדש"
            FmUserAddEdit.BtnUserAU.Text = "הוספת משתמש"
            FmUserAddEdit.StatusSwitch.Visible = False
        Else
            'FmUserAddEdit.BtnUserAU.Image = My.Resources.Info
            'FmUserAddEdit.Text = "עדכון משתמש"
            'FmUserAddEdit.BtnUserAU.Text = "עדכן משתמש"
            FmUserAddEdit.StatusSwitch.Visible = True
        End If
    End Sub
End Class