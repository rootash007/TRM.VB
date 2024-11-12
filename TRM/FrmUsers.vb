Imports System.Diagnostics.Eventing.Reader

Public Class FrmUsers

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        isAddUser = True
        FmUserAddEdit = New FrmUserAddEdit

        FmUserAddEdit.ShowDialog()
    End Sub

    Private Sub BtnEditUser_Click(sender As Object, e As EventArgs) Handles BtnUpdateUser.Click
        If FmUsers.TabUsers.SelectedIndex = 0 Then
            If DgvUsers.RowCount = 0 Then
                MsgBox("אין שורות לעדכון", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "הודעה")
                Return
            Else
                With FmUserAddEdit
                    .BtnUserAU.Image = My.Resources.save
                    .Text = "עדכון משתמש"
                    .BtnUserAU.Text = "שמירת שינויים"
                    .TxtUserName.Text = FmUsers.DgvUsers.CurrentRow.Cells(1).Value
                    .TxtPassWord.Text = FmUsers.DgvUsers.CurrentRow.Cells(2).Value
                    .NumUserLvl.Value = FmUsers.DgvUsers.CurrentRow.Cells(3).Value
                    .TxtPhone.Text = FmUsers.DgvUsers.CurrentRow.Cells(4).Value
                End With
                Switcher = True
                FmUserAddEdit.StatusSwitch.Image = My.Resources.swon1
            End If
        Else
            If DGVUsersOff.RowCount = 0 Then
                MsgBox("אין שורות לעדכון", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "הודעה")
                Return
            Else
                With FmUserAddEdit
                    .BtnUserAU.Image = My.Resources.save
                    .Text = "עדכון משתמש"
                    .BtnUserAU.Text = "שמירת שינויים"
                    .TxtUserName.Text = FmUsers.DGVUsersOff.CurrentRow.Cells(1).Value
                    .TxtPassWord.Text = FmUsers.DGVUsersOff.CurrentRow.Cells(2).Value
                    .NumUserLvl.Value = FmUsers.DGVUsersOff.CurrentRow.Cells(3).Value
                    .TxtPhone.Text = FmUsers.DGVUsersOff.CurrentRow.Cells(4).Value
                End With
                Switcher = False
                FmUserAddEdit.StatusSwitch.Image = My.Resources.swoff1
            End If
        End If

        isAddUser = False

        FmUserAddEdit.ShowDialog()
    End Sub

    Private Sub BtnDeleteUser_Click(sender As Object, e As EventArgs) Handles BtnDeleteUser.Click
        If FmUsers.TabUsers.SelectedIndex = 0 Then
            If DgvUsers.RowCount = 0 Then
                MsgBox("אין שורות למחיקה", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "הודעה")
                Return
            Else

                '***deactive user
                If DgvUsers.CurrentRow.Cells(0).Value = ActiveUserSerial Then
                    MsgBox("לא ניתן למחוק את שם המשתמש שלך", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "שגיאה")
                    Return
                Else
                    Dim DelMsg As DialogResult
                    DelMsg = MsgBox("האם אתה בטוח שברצונך למחוק משתמש", vbYesNo + vbQuestion, "מחיקה")
                    If DelMsg = 6 Then
                        DeleteUser(DgvUsers.CurrentRow.Cells(0).Value)
                        Me.FrmUsers_Load(Me, e)
                    End If
                End If
            End If
        Else
            If DGVUsersOff.RowCount = 0 Then
                MsgBox("אין שורות לשחזור", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "הודעה")
                Return
            Else
                '****active user
                Dim DelMsg As DialogResult
                DelMsg = MsgBox("האם אתה בטוח שברצונך לשחזר משתמש", vbYesNo + vbQuestion, "מחיקה")
                If DelMsg = 6 Then
                    ReActiveUser(DGVUsersOff.CurrentRow.Cells(0).Value)
                    Me.FrmUsers_Load(Me, e)
                End If
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnDeleteUser_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvUsers.KeyDown, BtnUpdateUser.KeyDown, BtnDeleteUser.KeyDown, BtnClose.KeyDown, BtnAddUser.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TabUsersOff_Click(sender As Object, e As EventArgs) Handles TabUsersOff.Click

    End Sub

    Private Sub TabUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabUsers.SelectedIndexChanged
        If FmUsers.TabUsers.SelectedIndex = 0 Then
            FmUsers.BtnDeleteUser.Image = My.Resources.deleteuser
            FmUsers.BtnDeleteUser.Text = "מחיקת משתמש"

        Else
            FmUsers.BtnDeleteUser.Image = My.Resources.revert48
            FmUsers.BtnDeleteUser.Text = "שחזור משתמש"

        End If
    End Sub

    Private Sub DgvUsers_DoubleClick(sender As Object, e As EventArgs) Handles DgvUsers.DoubleClick
        If DgvUsers.RowCount = 0 Then
            Return
        Else
            BtnEditUser_Click(DgvUsers.CurrentRow.Cells(0), e)
        End If
    End Sub

    Private Sub DGVUsersOff_DoubleClick(sender As Object, e As EventArgs) Handles DGVUsersOff.DoubleClick
        If DGVUsersOff.RowCount = 0 Then
            Return
        Else
            BtnEditUser_Click(DGVUsersOff.CurrentRow.Cells(0), e)
        End If
    End Sub
End Class