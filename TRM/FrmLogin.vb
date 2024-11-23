
Imports System.Data.SqlClient

Public Class FrmLogin


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminMode = False
        TxtUsername.Text = ""
        TxtPassWord.Text = ""
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            'dbcon = New SqlConnection With {.ConnectionString = My.Settings.CurrentServer}
            Dim que As String
            Dim ChkSerial As Boolean = False
            TxtUsername.Focus()
            'que = "select  * from users where UserNam = '" & TxtUsername.Text & "' and PassWrd = '" & TxtPassWord.Text & "' "
            dbcon = New SqlConnection With {.ConnectionString = My.Settings.CurrentServer}

            que = "select  * from users where user_name = '" & TxtUsername.Text & "' and user_pass = '" & TxtPassWord.Text & "' "


            UserChk(que)
            If UserTab.Rows.Count <= 0 Then
                OkMsgAlert("اسم المستخدم او كلمة المرور", "اسم المستخدم او كلمة المرور خاطئة")
                'MsgBox("שם משתמש או סיסמה שגוי", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "שם משתמש או סיסמה")
            Else
                If UserTab.Rows(0).Item(3) <= 1 Then
                    AdminMode = True
                End If
                ActiveUserSerial = UserTab.Rows(0).Item(0)
                ActiveUser = UserTab.Rows(0).Item(1).ToString
                ActiveLvl = UserTab.Rows(0).Item(3)
                'OfficeServer = My.Settings.CurrentServer


                'MsgBox(My.Settings.CurrentServer)
                'FrmMain.Show()

                Me.Close()
                ReConnect = True
                'isConnected = True
                FrmMain.FrmMain_Load(FrmMain, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If ReConnect = True Then
            Me.Close()
        Else
            FrmMain.Close()
            Me.Close()
        End If
    End Sub

    Private Sub TxtPassWord_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassWord.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            OkMsgAlert("رسالة الامان", "الرجاء ادخال اسم المستخدم و كلمة المرور")
            'MsgBox("נא להקיש שם משתמש וסיסמה", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "הודעת אבטחה")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Enter Then
            BtnLogin_Click(TxtPassWord.Text, e)
        End If
    End Sub

    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            OkMsgAlert("رسالة الامان", "الرجاء ادخال اسم المستخدم و كلمة المرور")
            'MsgBox("נא להקיש שם משתמש וסיסמה", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "הודעת אבטחה")
            e.Handled = True
        End If
    End Sub

    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsername.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            OkMsgAlert("رسالة الامان", "الرجاء ادخال اسم المستخدم و كلمة المرور")
            'MsgBox("נא להקיש שם משתמש וסיסמה", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "הודעת אבטחה")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Enter Then
            TxtPassWord.Focus()
        End If
    End Sub

    Private Sub BtnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnLogin.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            OkMsgAlert("رسالة الامان", "الرجاء ادخال اسم المستخدم و كلمة المرور")
            'MsgBox("נא להקיש שם משתמש וסיסמה", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "הודעת אבטחה")
            e.Handled = True
        End If
    End Sub

    Private Sub BtnClose_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnClose.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            OkMsgAlert("رسالة الامان", "الرجاء ادخال اسم المستخدم و كلمة المرور")
            'MsgBox("נא להקיש שם משתמש וסיסמה", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "הודעת אבטחה")
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TxtUsername.Text = My.Settings.AdminUser And TxtPassWord.Text = My.Settings.AdminPass Then
            FrmDataBaseSettings.ShowDialog()
        End If
    End Sub
End Class