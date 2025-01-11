Imports System.Data.SqlClient
Imports System.IO

Public Class FrmDataBaseSettings

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try

            My.Settings.LocalServer = TxtLocalServer.Text
            My.Settings.OnlineServer = TxtOnlineServer.Text
            If RadLocalDatabase.Checked = True Then
                My.Settings.CurrentServer = TxtLocalServer.Text
                My.Settings.LocalDataBase = True
            Else
                My.Settings.CurrentServer = TxtOnlineServer.Text
                My.Settings.LocalDataBase = False
            End If

            My.Settings.Save()
            dbcon = New SqlConnection With {.ConnectionString = My.Settings.CurrentServer}

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    'Private Sub TxtVId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtServerUserName.KeyPress
    '    If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub TxtVPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVPhone.KeyPress
    '    If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub TxtVFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVFax.KeyPress
    '    If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub ChkStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtVPhone.KeyDown, TxtLocal.KeyDown, TxtVInfo.KeyDown, TxtServerUserName.KeyDown, TxtVFax.KeyDown, TxtVEmail.KeyDown, TxtServerIP.KeyDown, TxtServerPassword.KeyDown, BtnCancel.KeyDown, BtnAdd.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    'End Sub


    Private Sub FrmDataBaseSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtLocalServer.Text = My.Settings.LocalServer
        TxtOnlineServer.Text = My.Settings.OnlineServer
        If My.Settings.LocalDataBase = True Then
            RadLocalDatabase.Checked = True
            GrpLocal.Enabled = True
            GrpOnline.Enabled = False
        Else
            RadServerDatabase.Checked = True
            GrpLocal.Enabled = False
            GrpOnline.Enabled = True
        End If
    End Sub

    Private Sub RadServerDatabase_CheckedChanged(sender As Object, e As EventArgs) Handles RadServerDatabase.CheckedChanged, RadLocalDatabase.CheckedChanged
        If RadLocalDatabase.Checked = True Then
            GrpLocal.Enabled = True
            GrpOnline.Enabled = False
        Else
            RadServerDatabase.Checked = True
            GrpLocal.Enabled = False
            GrpOnline.Enabled = True
        End If
    End Sub
End Class