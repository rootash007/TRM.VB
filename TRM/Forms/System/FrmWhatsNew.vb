Imports System.Data.SqlClient

Public Class FrmWhatsNew
    Dim isFound As Boolean = False
    Dim Que As String


    Private Sub FrmWhatsNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AppLanguage = "AR" Then
            Me.Text = "ماذا جديد في نسخة " & My.Settings.CurrentVersion


            LBWhatsNew.Items.Add("* فحص بعض الأخطاء")
            LBWhatsNew.Items.Add("* تعديل بعص التصاميم")
            LBWhatsNew.Items.Add("اضافة خيارات للفرع")
            'LBWhatsNew.Items.Add("")
            'LBWhatsNew.Items.Add("")
            'LBWhatsNew.Items.Add("")



            ChkEditDataBase.Text = "تعديل قاعدة البيانات"
            ChkShowAgain.Text = "لا تظهر هذه الرسالة مرة اخرى "
        ElseIf AppLanguage = "HE" Then
            Me.Text = "מה חדש בגרסה החדשה " & My.Settings.CurrentVersion


            LBWhatsNew.Items.Add("* בדיקת עיצובים")
            LBWhatsNew.Items.Add("* בדיקת תקלות")
            LBWhatsNew.Items.Add("הוספת הגדרה לסניף")
            'LBWhatsNew.Items.Add("")
            'LBWhatsNew.Items.Add("")
            'LBWhatsNew.Items.Add("")



            ChkEditDataBase.Text = "עדכון מסד נתונים"
            ChkShowAgain.Text = "אל תציג הודעה זו שוב"
            ChkShowAgain.Left = 187
        End If
        If My.Settings.EditDataBase = False Then
            ChkEditDataBase.Visible = False
        Else
            ChkEditDataBase.Visible = True
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ChkEditDataBase.Checked = True Then
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
                If AppLanguage = "AR" Then
                    MsgBox("يجب تعديل قاعدة البيانات بشكل الزامي", vbOKOnly + vbInformation, "استعلام")
                ElseIf AppLanguage = "HE" Then
                    MsgBox("חובה לעדכן מסד נתונים", vbOKOnly + vbInformation, "הודעה")
                End If
                Return
            End If
        End If
        If My.Settings.EditDataBase = True Then
            If AppLanguage = "AR" Then
                MsgBox("يجب تعديل قاعدة البيانات بشكل الزامي", vbOKOnly + vbInformation, "استعلام")
            ElseIf AppLanguage = "HE" Then
                MsgBox("חובה לעדכן מסד נתונים", vbOKOnly + vbInformation, "הודעה")
            End If
            Return
        End If
        Me.Close()
    End Sub
End Class