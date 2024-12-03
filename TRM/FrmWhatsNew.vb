Imports System.Data.SqlClient

Public Class FrmWhatsNew
    Private Sub FrmWhatsNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lbl1.Text = "انواع العمليات"
        If My.Settings.EditDataBase = False Then
            ChkEditDataBase.Visible = False
        Else
            ChkEditDataBase.Visible = True
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ChkEditDataBase.Checked = True Then
            Dim Que As String
            Dim isFound As Boolean = False
            Que = "select * from permissions"
            FillList(Que)
            For i = 0 To MyTab.Rows.Count - 1
                If MyTab.Rows(i).Item(1) = "Action Types" Then
                    isFound = True
                End If
            Next
            If isFound = False Then
                Que = "INSERT INTO permissions (permission_name) values ('Action Types')"
                cmd = New SqlCommand
                MyTab = New DataTable
                Try
                    MyTab.Clear()
                    With cmd
                        .CommandType = CommandType.Text
                        .CommandText = Que
                        .Connection = dbcon
                    End With
                    dbaddapter = New SqlDataAdapter(cmd)
                    dbaddapter.Fill(MyTab)
                    cmd = Nothing
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            My.Settings.EditDataBase = False
            My.Settings.Save()
        End If


        If ChkShowAgain.Checked = True Then
            If My.Settings.EditDataBase = False Then
                My.Settings.isShowWhatsNew = False
                My.Settings.Save()
            Else
                MsgBox("يجب تعديل قاعدة البيانات بشكل الزامي", vbOKOnly + vbInformation, "استعلام")
                Return
            End If
        End If
        Me.Close()
    End Sub
End Class