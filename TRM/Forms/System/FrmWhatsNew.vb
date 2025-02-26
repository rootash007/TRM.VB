Imports System.Data.SqlClient

Public Class FrmWhatsNew
    Dim isFound As Boolean = False
    Dim Que As String


    Private Sub FrmWhatsNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lbl1.Text = "انواع العمليات"
        Me.Text = "ماذا جديد في نسخة " & My.Settings.CurrentVersion
        If My.Settings.EditDataBase = False Then
            ChkEditDataBase.Visible = False
        Else
            ChkEditDataBase.Visible = True
        End If
        '********** IF database needs update ********
        'If PermissionCounter() = 10 Then
        '    My.Settings.EditDataBase = False
        '    ChkEditDataBase.Visible = False
        '    My.Settings.Save()
        'Else
        '    My.Settings.EditDataBase = True
        '    ChkEditDataBase.Visible = True
        '    My.Settings.Save()
        'End If

        'Que = "select * from permissions"
        'FillList(Que)
        'For i = 0 To MyTab.Rows.Count - 1
        '    If MyTab.Rows(i).Item(1) = "Audits" Then
        '        isFound = True
        '    End If
        'Next
        'If isFound = True Then
        '    My.Settings.EditDataBase = False
        '    ChkEditDataBase.Visible = False
        '    My.Settings.Save()
        'Else
        '    My.Settings.EditDataBase = True
        '    ChkEditDataBase.Visible = True
        '    My.Settings.Save()
        'End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ChkEditDataBase.Checked = True Then
            'CreateTables()
            'Que = "select * from permissions"
            'FillList(Que)
            'For i = 0 To MyTab.Rows.Count - 1
            '    If MyTab.Rows(i).Item(1) = "Audits" Then
            '        isFound = True
            '    End If
            'Next
            'If isFound = False Then
            '    Que = "INSERT INTO permissions (permission_name) values ('Audits')"
            '    cmd = New SqlCommand
            '    MyTab = New DataTable
            '    Try
            '        MyTab.Clear()
            '        With cmd
            '            .CommandType = CommandType.Text
            '            .CommandText = Que
            '            .Connection = dbcon
            '        End With
            '        dbaddapter = New SqlDataAdapter(cmd)
            '        dbaddapter.Fill(MyTab)
            '        cmd = Nothing
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End If
            WhatsNew()
            My.Settings.EditDataBase = False
            My.Settings.Save()
        End If


        If ChkShowAgain.Checked = True Then
            If My.Settings.EditDataBase = False Then
                'WhatsNew()
                My.Settings.isShowWhatsNew = False
                My.Settings.Save()
            Else
                MsgBox("يجب تعديل قاعدة البيانات بشكل الزامي", vbOKOnly + vbInformation, "استعلام")
                Return
            End If
        End If
        If My.Settings.EditDataBase = True Then
            MsgBox("يجب تعديل قاعدة البيانات بشكل الزامي", vbOKOnly + vbInformation, "استعلام")
            Return
        End If
        Me.Close()
    End Sub
End Class