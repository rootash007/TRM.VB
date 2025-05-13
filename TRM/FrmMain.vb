Imports System.Data.SqlClient
Imports System.IO, System.Net, System.Web
Imports TRM.ModFunctions

Public Class FrmMain
    Dim switcher As Boolean = True
    Public isConnected As Boolean = False
    Dim FreshLogin As Boolean = True

    Public Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        AppLanguage = My.Settings.Language
        FrmMainLang(AppLanguage)

        'System.Threading.Thread.Sleep(3000)


        '***********

        If ReConnect = False Then
            FrmLogin.ShowDialog()
        Else
            ReConnect = False
            For Each Frm As Form In Me.MdiChildren
                Frm.Close()
            Next

            'My.Settings.AdminCode = "Admin123456"
            'My.Settings.Save()
            'WhatsNew()

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
                Dim CurrentVersion As String = My.Settings.CurrentVersion
                With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                    TSSLblVersion.Text = .Major & "." & .Minor & "." & .Build & "." & .Revision
                End With
                If CurrentVersion <> TSSLblVersion.Text Then
                    My.Settings.isShowWhatsNew = True
                    My.Settings.CurrentVersion = TSSLblVersion.Text
                    My.Settings.EditDataBase = True
                    'WhatsNew()
                    My.Settings.Save()
                End If
                If FreshLogin = True Then
                    If My.Settings.isShowWhatsNew = True Then
                        FrmWhatsNew.ShowDialog()
                    End If
                    FreshLogin = False
                End If
            End If
            If AlertsCount() > 0 Then
                TSBtnAlerts.Visible = True
                If AdminMode = True Then
                    FrmAlerts.ShowDialog()
                Else
                    If isAllowed(9) = True Then
                        FrmAlerts.ShowDialog()
                    End If
                End If
            Else
                TSBtnAlerts.Visible = False
            End If



            'If AdminMode = True Then
            '    SSAdminStatus.Text = "פעיל"
            '    SSAdminStatus.ForeColor = Color.Green
            'Else
            '    SSAdminStatus.Text = "לא פעיל"
            '    SSAdminStatus.ForeColor = Color.Red
            'End If

        End If

        'Dim que As String = "select * from branches"
        'FillList(que)
        'AdminCode = MyTab.Rows(0).Item(2)
        ''WhatsNew()


    End Sub

    Private Sub TSMUsers_Click(sender As Object, e As EventArgs) Handles TSIUsers.Click
        TSBtnUsers.PerformClick()
    End Sub

    Private Sub יציאהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSIExit.Click
        Dim ExitMsg As DialogResult
        If AppLanguage = "AR" Then
            ExitMsg = MsgBox("هل انت متأكد من انك تريد الخروج", vbYesNo + vbQuestion, "خروج")
        ElseIf AppLanguage = "HE" Then
            ExitMsg = MsgBox("האם אתה בטוח שברצונך לצאת", vbYesNo + vbQuestion, "יציאה")
        End If
        If ExitMsg = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub הגדרתשדותחובהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הגדרתשדותחובהToolStripMenuItem.Click
        If AdminMode = True Then
            FrmRequiredAddCar.ShowDialog()
        Else
            If AppLanguage = "AR" Then
                OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
            ElseIf AppLanguage = "HE" Then
                OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
            End If
        End If
    End Sub

    Private Sub רכביםToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSTUnits.Click
        If ActiveLvl < 2 Then
            Dim FmUnits As New FrmUnits
            If Application.OpenForms.OfType(Of FrmUnits).Any = True Then
                FmUnits.Activate()
            Else
                FmUnits = New FrmUnits
                FmUnits.MdiParent = Me
                FmUnits.Show()
            End If
        Else
            If AppLanguage = "AR" Then
                OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
            ElseIf AppLanguage = "HE" Then
                OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
            End If
        End If

    End Sub

    Private Sub גיבוישחזורToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TSiBackUp.Click
        FrmBackUp.ShowDialog()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs)
        CustomersWindow = "CustomerUpdate"
        FrmCustomers.ShowDialog()
    End Sub

    Private Sub הסכםמכירהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הסכםמכירהToolStripMenuItem.Click
        AgreementStatus = "SaleNon"
        LoadAgree()
        FrmAgreementPrint.ShowDialog()
    End Sub

    Private Sub הכסםקנייהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הכסםקנייהToolStripMenuItem.Click
        AgreementStatus = "BuyNon"
        FrmAgreementPrint.ShowDialog()
    End Sub

    Private Sub הסכםריקToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הסכםריקToolStripMenuItem.Click
        AgreementStatus = "Nothing"
        FrmAgreementPrint.ShowDialog()
    End Sub

    Private Sub החלפתמשתמשToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSILogOut.Click
        ReConnect = True
        FrmLogin.ShowDialog()
    End Sub

    Private Sub הפעלתמצבמנהלToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הפעלתמצבמנהלToolStripMenuItem.Click
        AdminMode = True
    End Sub

    Private Sub BtdDelete_Click(sender As Object, e As EventArgs)
        If AdminMode = True Then
            FrmCarDelete.ShowDialog()
        Else
            If AppLanguage = "AR" Then
                OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
            ElseIf AppLanguage = "HE" Then
                OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
            End If
        End If
    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Dim ExitMsg As DialogResult
        If AppLanguage = "AR" Then
            ExitMsg = MsgBox("هل انت متأكد من انك تريد الخروج", vbYesNo + vbQuestion, "خروج")
        ElseIf AppLanguage = "HE" Then
            ExitMsg = MsgBox("האם אתה בטוח שברצונך לצאת", vbYesNo + vbQuestion, "יציאה")
        End If
        If ExitMsg = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub עדכוןתוכנהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSiUpgrade.Click
        'ChkForUpdates()
        If AdminMode = True Then
            WhatsNew()
        Else
            MsgBox("ONLY Admin can make this option")
        End If
    End Sub

    Private Sub אודותToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TSiAbout.Click
        'My.Settings.EmptyCarSerial = 1
        'My.Settings.Save()
        MsgBox(My.Settings.EmptyCarSerial)
    End Sub

    Private Sub BtnAbort_Click(sender As Object, e As EventArgs)
        MsgBox(ActiveUser)
    End Sub

    Private Sub TSMCloseAll_Click(sender As Object, e As EventArgs) Handles TSiCloseAll.Click
        For Each Frm As Form In Me.MdiChildren
            Frm.Close()
        Next
    End Sub

    Private Sub TSBtnMaterial_Click(sender As Object, e As EventArgs) Handles TSBtnMaterial.Click
        If Application.OpenForms.OfType(Of FrmMaterials).Any = True Then
            FmMaterials.Activate()
        Else
            FmMaterials = New FrmMaterials
            FmMaterials.MdiParent = Me
            FmMaterials.Show()
        End If
    End Sub

    Private Sub TSBtnUsers_Click(sender As Object, e As EventArgs) Handles TSBtnUsers.Click
        If ActiveLvl = 0 Then
            If Application.OpenForms.OfType(Of FrmUsers).Any = True Then
                FmUsers.Activate()
            Else
                FmUsers = New FrmUsers
                FmUsers.MdiParent = Me
                FmUsers.Show()
            End If
        Else
            If isAllowed(1) = True Then

                If Application.OpenForms.OfType(Of FrmUsers).Any = True Then
                    FmUsers.Activate()
                Else
                    FmUsers = New FrmUsers
                    FmUsers.MdiParent = Me
                    FmUsers.Show()
                End If
            Else
                If AppLanguage = "AR" Then
                    OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                ElseIf AppLanguage = "HE" Then
                    OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                End If
            End If
        End If
        'ChkPermission()

    End Sub

    Private Sub TSBtnBackUp_Click(sender As Object, e As EventArgs) Handles TSBtnBackUp.Click
        FrmBackUp.ShowDialog()
    End Sub



    Private Sub TSPActions_Click(sender As Object, e As EventArgs) Handles TSBtnActions.Click
        If Application.OpenForms.OfType(Of FrmActions).Any = True Then
            FmActions.Activate()
        Else
            FmActions = New FrmActions
            FmActions.MdiParent = Me
            ActionsFormPrepair()
            FmActions.Show()
        End If
    End Sub

    Private Sub TSUsers_Click(sender As Object, e As EventArgs) Handles TSTUsers.Click
        Try
            If Application.OpenForms.OfType(Of FrmUsers).Any = True Then
                FmUsers.Activate()
            Else
                FmUsers = New FrmUsers
                FmUsers.MdiParent = Me
                FmUsers.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TSActions_Click(sender As Object, e As EventArgs) Handles TSTActions.Click
        Try
            If AdminMode = True Then
                If Application.OpenForms.OfType(Of FrmActionsTypes).Any = True Then
                    FmActionsTypes.Activate()
                Else
                    FmActionsTypes = New FrmActionsTypes
                    FmActionsTypes.MdiParent = Me
                    FmActionsTypes.Show()
                End If
            Else
                If isAllowed(8) = True Then
                    If Application.OpenForms.OfType(Of FrmActionsTypes).Any = True Then
                        FmActionsTypes.Activate()
                    Else
                        FmActionsTypes = New FrmActionsTypes
                        FmActionsTypes.MdiParent = Me
                        FmActionsTypes.Show()
                    End If
                Else
                    If AppLanguage = "AR" Then
                        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                    ElseIf AppLanguage = "HE" Then
                        OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TSBtnProducts_Click(sender As Object, e As EventArgs) Handles TSBtnProducts.Click
        Try
            If AdminMode = True Then
                If Application.OpenForms.OfType(Of FrmProducts).Any = True Then
                    FmProducts.Activate()
                Else
                    'FmProducts = New FrmProducts
                    FmProducts = New FrmProducts
                    FmProducts.MdiParent = Me
                    FmProducts.Show()
                End If
            Else
                If isAllowed(7) = True Then
                    If Application.OpenForms.OfType(Of FrmProducts).Any = True Then
                        FmProducts.Activate()
                    Else
                        FmProducts = New FrmProducts
                        FmProducts.MdiParent = Me
                        FmProducts.Show()
                    End If
                Else
                    If AppLanguage = "AR" Then
                        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                    ElseIf AppLanguage = "HE" Then
                        OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'FrmProducts.ShowDialog()
    End Sub

    Private Sub TSBtnCreateTables_Click(sender As Object, e As EventArgs)
        If ActiveLvl = 0 Then
            CreateTables()
            'WhatsNew()
        Else
            If AppLanguage = "AR" Then
                OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
            ElseIf AppLanguage = "HE" Then
                OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
            End If
        End If
    End Sub

    Private Sub הפקתמסמכיםToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הפקתמסמכיםToolStripMenuItem.Click
        If ActiveLvl > 0 Then
            If AppLanguage = "AR" Then
                OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
            ElseIf AppLanguage = "HE" Then
                OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
            End If
            Return
        End If
    End Sub

    Private Sub PermisionsTSM_Click(sender As Object, e As EventArgs) Handles TSiPermissions.Click
        If AdminMode = True Then
            FrmPermissions.ShowDialog()
        Else
            If isAllowed(6) = True Then
                FrmPermissions.ShowDialog()
            Else
                If AppLanguage = "AR" Then
                    OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                ElseIf AppLanguage = "HE" Then
                    OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                End If
            End If
        End If
    End Sub

    Private Sub تحريركلالنوافذالقيدالاستخدامToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSiWindowsUnLock.Click
        'inUSEFree()
        Dim UpdateParams As New Dictionary(Of String, Object) From {
                      {"material_inuse", 0}
                      }
        Dim conditionField As String = "material_inuse"
        Dim conditionValue As Object = 1 ''//FmMaterials.DgvMaterials.CurrentRow.Cells(0).Value
        UpdateData("materials", UpdateParams, conditionField, conditionValue)
    End Sub

    Private Sub TSMAudits_Click(sender As Object, e As EventArgs) Handles TSIAudits.Click
        Try
            If AdminMode = True Then
                If Application.OpenForms.OfType(Of FrmAudits).Any = True Then
                    FmAudits.Activate()
                Else
                    FmAudits = New FrmAudits
                    FmAudits.MdiParent = Me
                    FmAudits.Show()
                End If
            Else
                If isAllowed(9) = True Then
                    If Application.OpenForms.OfType(Of FrmAudits).Any = True Then
                        FmAudits.Activate()
                    Else
                        FmAudits = New FrmAudits
                        FmAudits.MdiParent = Me
                        FmAudits.Show()
                    End If
                Else
                    If AppLanguage = "AR" Then
                        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                    ElseIf AppLanguage = "HE" Then
                        OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If AdminMode = True Then
        '    FrmAudits.ShowDialog()
        'Else
        '    If isAllowed(9) = True Then
        '        FrmAudits.ShowDialog()
        '    Else
        '        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
        '    End If
        'End If
    End Sub

    Private Sub TSMCostList_Click(sender As Object, e As EventArgs) Handles TSICostsList.Click
        TSBtnCost.PerformClick()
    End Sub

    Private Sub TSBtnCost_Click(sender As Object, e As EventArgs) Handles TSBtnCost.Click
        Try
            If AdminMode = True Then
                If Application.OpenForms.OfType(Of FrmCostsList).Any = True Then
                    FmCostsList.Activate()
                Else
                    FmCostsList = New FrmCostsList
                    FmCostsList.MdiParent = Me
                    FmCostsList.Show()
                End If
            Else
                If isAllowed(10) = True Then
                    If Application.OpenForms.OfType(Of FrmCostsList).Any = True Then
                        FmCostsList.Activate()
                    Else
                        FmCostsList = New FrmCostsList
                        FmCostsList.MdiParent = Me
                        FmCostsList.Show()
                    End If
                Else
                    If AppLanguage = "AR" Then
                        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                    ElseIf AppLanguage = "HE" Then
                        OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TSMMaterials_Click(sender As Object, e As EventArgs) Handles TSIMaterials.Click
        TSBtnMaterial.PerformClick()
    End Sub

    Private Sub TSMActions_Click(sender As Object, e As EventArgs) Handles TSIActions.Click
        TSBtnActions.PerformClick()
    End Sub

    Private Sub TSMCompanyOptions_Click(sender As Object, e As EventArgs) Handles TSiCompanyOptions.Click

        'FrmAdminCode.ShowDialog()
        'If isAdminCode = True Then
        '    isAdminCode = False
        '    FrmCompany.ShowDialog()
        'End If
        If ActiveLvl = 0 Then
            FrmCompany.ShowDialog()
        Else
            FrmAdminCode.ShowDialog()
            If isAdminCode = True Then
                isAdminCode = False
                FrmCompany.ShowDialog()
            End If
        End If

    End Sub

    Private Sub TSMSuppliers_Click(sender As Object, e As EventArgs) Handles TSISuppliers.Click
        'ChkFormPermission("FrmSuppliers")

        'If AdminMode = True OrElse isAllowed(10) Then
        '    ChkFormPermission("FrmSuppliers")
        'Else
        '    OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية")
        'End If

        Try
            If AdminMode = True Then
                If Application.OpenForms.OfType(Of FrmSuppliers).Any = True Then
                    FmSuppliers.Activate()
                Else
                    FmSuppliers = New FrmSuppliers
                    FmSuppliers.MdiParent = Me
                    FmSuppliers.Show()
                End If
            Else
                If isAllowed(11) = True Then
                    If Application.OpenForms.OfType(Of FrmSuppliers).Any = True Then
                        FmSuppliers.Activate()
                    Else
                        FmSuppliers = New FrmSuppliers
                        FmSuppliers.MdiParent = Me
                        FmSuppliers.Show()
                    End If
                Else
                    If AppLanguage = "AR" Then
                        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                    ElseIf AppLanguage = "HE" Then
                        OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub فحصالاصدارالاخيرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSiUpgradeCheck.Click
        Try
            'Dim Request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.ctrlmanager.com/TRM/RM.application")
            'Dim Response As System.Net.HttpWebResponse = Request.GetResponse()
            'Dim StreamR As System.IO.StreamReader = New System.IO.StreamReader(Response.GetResponseStream())
            'Dim NewVersion As String = StreamR.ReadToEnd()
            'Dim CurVersion As String = My.Settings.CurrentVersion
            'If NewVersion > CurVersion Then
            Dim FmNewUpdate As New FrmNewUpdate
            'With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
            'FmNewUpdate.LblCurrentVersion.Text = My.Settings.CurrentVersion
            'End With

            'FmNewUpdate.LblNewVersion.Text = NewVersion
            FmNewUpdate.ShowDialog()
            'Else
            '    'MsgBox("There is no update available", vbOKOnly + vbInformation, "No Update")
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TSMCurrency_Click(sender As Object, e As EventArgs) Handles TSTCurrency.Click
        Try
            If AdminMode = True Then
                If Application.OpenForms.OfType(Of FrmCurrency).Any = True Then
                    FrmCurrency.Activate()
                Else
                    FrmCurrency = Nothing
                    FrmCurrency.MdiParent = Me
                    FrmCurrency.Show()
                End If
            Else
                If isAllowed(12) = True Then
                    If Application.OpenForms.OfType(Of FrmCurrency).Any = True Then
                        FrmCurrency.Activate()
                    Else
                        FrmCurrency = Nothing
                        FrmCurrency.MdiParent = Me
                        FrmCurrency.Show()
                    End If
                Else
                    If AppLanguage = "AR" Then
                        OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
                    ElseIf AppLanguage = "HE" Then
                        OkMsgAlert("אין הרשאה", "אין לך הרשאה לפעולה זו ")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub עבריתToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles עבריתToolStripMenuItem.Click
        Dim LangMsg As DialogResult
        If AppLanguage = "AR" Then
            LangMsg = MsgBox("يجب اغلاق جميع النوافذ لتغيير اللغه , هل تريد الاستمرار", vbYesNo + vbQuestion, "اللغه")
            If LangMsg = 6 Then
                My.Settings.Language = "HE"
                My.Settings.Save()
                ReConnect = True
                ''//need to close all forms before change the language
                'TSMCloseAll_Click(e, e)
                FrmMain_Load(e, e)
            End If
        End If
    End Sub

    Private Sub عربيToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عربيToolStripMenuItem.Click
        Dim LangMsg As DialogResult
        If AppLanguage = "HE" Then
            LangMsg = MsgBox("צריך לסגור כל החלונות כדי לשנות שפה , האם להמשיך", vbYesNo + vbQuestion, "שפה")
            If LangMsg = 6 Then
                My.Settings.Language = "AR"
                My.Settings.Save()
                ReConnect = True
                ''//need to close all forms before change the language
                'TSMCloseAll_Click(e, e)
                'For Each Frm As Form In Me.MdiChildren
                '    Frm.Activate()
                'Next
                FrmMain_Load(e, e)
            End If
        End If
    End Sub

    Private Sub ישאדToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ישאדToolStripMenuItem.Click
        FrmWhatsNew.ShowDialog()
    End Sub
End Class
