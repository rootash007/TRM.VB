﻿Imports System.Data.SqlClient
Imports System.IO, System.Net, System.Web
Imports TRM.ModFunctions
'Public AdminMode As Boolean = False

Public Class FrmMain
    Dim switcher As Boolean = True
    Public isConnected As Boolean = False
    'Public ReConnect As Boolean = False    'החלפת משתמש
    'Public AdminMode As Boolean = False    'מצב מנהל
    'Public OfficeServer As String = My.Settings.CurrentServer
    'Public dbcon As New SqlConnection With {.ConnectionString = OfficeServer}





    Public Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'System.Threading.Thread.Sleep(3000)
        'ReConnect = False
        'MsgBox(ReConnect)


        'AdminMode = False
        'OfficeServer = My.Settings.CurrentServer


        'Me.Hide()

        '***********
        If ReConnect = False Then
            FrmLogin.ShowDialog()
        End If

        '*************
        'If isConnected = False Then
        '    FrmLogin.ShowDialog()
        'End If
        'isConnected = False

        'FrmLogin.ShowDialog()

        ReConnect = False
        For Each Frm As Form In Me.MdiChildren
            Frm.Close()
        Next
        'ReLoadMain()
        'LblJobName.Text = My.Settings.JobName
        'LblJobDetails.Text = "כתובת :" & My.Settings.JobAdress & "   טלפון :" & My.Settings.JobPhone & "   פקס :" & My.Settings.JobFax & "   אימייל:" & My.Settings.JobEmail & "   ח.פ / ע.מ :" & My.Settings.JobId
        'FirstEmptyCarSerial()
        'Me.Text = My.Settings.JobName
        Me.Text = ActiveUser

        If AdminMode = True Then
            SSAdminStatus.Text = "פעיל"
            SSAdminStatus.ForeColor = Color.Green
        Else
            SSAdminStatus.Text = "לא פעיל"
            SSAdminStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TSMUsers_Click(sender As Object, e As EventArgs) Handles TSMUsers.Click
        'FrmTerminate.ShowDialog()
        TSBtnUsers_Click(Me, e)
        'If Application.OpenForms.OfType(Of FrmUsers).Any = True Then
        '    FmUsers.Activate()
        'Else
        '    FmUsers = New FrmUsers
        '    FmUsers.MdiParent = Me
        '    FmUsers.Show()
        'End If
    End Sub
    '********************************************
    Private Sub BtnAddNewCar_Click(sender As Object, e As EventArgs)
        OpenNewCar()
    End Sub

    Private Sub יציאהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles יציאהToolStripMenuItem.Click
        Dim ExitMsg As DialogResult
        ExitMsg = MsgBox("هل انت متأكد من انك تريد الخروج", vbYesNo + vbQuestion, "خروج")
        If ExitMsg = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnVendors_Click(sender As Object, e As EventArgs)
        VendorsWindow = "VendorUpdate"
        FrmVendors.ShowDialog()
    End Sub

    Private Sub הגדרתמספרביומןToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הגדרתמספרביומןToolStripMenuItem.Click
        If AdminMode = True Then
            FrmCarSerialUpdate.ShowDialog()
        Else
            OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
        End If
    End Sub

    Private Sub BtnSale_Click(sender As Object, e As EventArgs)
        FmCarSale = New FrmCarSale
        FmCarSale.ShowDialog()
    End Sub

    Private Sub הגדרתשדותחובהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הגדרתשדותחובהToolStripMenuItem.Click
        If AdminMode = True Then
            FrmRequiredAddCar.ShowDialog()
        Else
            OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
        End If
    End Sub

    Private Sub רכביםToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSMUnits.Click
        Dim FmCarKMT As New FrmCarKMT
        FmCarKMT.ShowDialog()
    End Sub

    Private Sub גיבוישחזורToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles גיבוישחזורToolStripMenuItem1.Click
        FrmBackUp.ShowDialog()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs)
        CustomersWindow = "CustomerUpdate"
        FrmCustomers.ShowDialog()
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs)
        If AdminMode = True Then
            FrmReportChose.ShowDialog()
        Else
            OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
        End If
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

    Private Sub החלפתמשתמשToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles החלפתמשתמשToolStripMenuItem.Click
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
            OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
        End If
    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Dim ExitMsg As DialogResult
        ExitMsg = MsgBox("هل تريد الخروج فعلا", vbYesNo + vbQuestion, "خروج")
        If ExitMsg = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub LblSoldCount_Click(sender As Object, e As EventArgs)
        FmSoldReport = New FrmSoldReport
        FmSoldReport.ShowDialog()


        'FrmSoldReport.ShowDialog()
    End Sub

    Private Sub LblDeletedCount_Click(sender As Object, e As EventArgs)
        FrmDeletedReport.ShowDialog()
    End Sub

    Private Sub LblVendorsCount_Click(sender As Object, e As EventArgs)
        VendorsWindow = "VendorUpdate"
        'FmVendors = New FrmVendors
        'FmVendors.ShowDialog()
        FrmVendors.ShowDialog()
    End Sub

    Private Sub LblCustomersCount_Click(sender As Object, e As EventArgs)
        CustomersWindow = "CustomerUpdate"
        'FmCustomers = New FrmCustomers
        'FmCustomers.ShowDialog()
        FrmCustomers.ShowDialog()
    End Sub


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs)
        FmSearch = New FrmSearch
        FmSearch.ShowDialog()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)
        ReLoadMain()
        'MsgBox(KindCount())
    End Sub

    Private Sub עדכוןתוכנהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles עדכוןתוכנהToolStripMenuItem.Click

        Dim TradeInCarSerial As Integer
        Dim Id As Integer
        Dim que As String
        'que = "select carserial,Priceout from MainList where carserial = 389"
        que = "select carserial,CarStatus from MainList where carserial = 389"

        FillList(que)
        'MsgBox(MyTab.Rows(0).Item(0).ToString)
        'For i = 0 To MyTab.Rows.Count - 1
        '    Id = MyTab.Rows(i).Item(0).ToString
        '    TradeInCarSerial = MyTab.Rows(i).Item(0).ToString
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                '.CommandText = "update MainList set PriceOut=@PriceOut where carserial=@carserial"
                .CommandText = "update MainList set CarStatus=@CarStatus where carserial=@carserial"
                '.CommandText = "delete from MainList where carserial=@carserial"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@CarStatus", True)

            'cmd.Parameters.AddWithValue("@PriceOut", "38000")
            'cmd.Parameters.AddWithValue("@carsaleinfo", "שולם 23200 בצקים + 1500 מזומן")
            'cmd.Parameters.AddWithValue("@receiptnum", 274)

            cmd.Parameters.AddWithValue("@carserial", 389)
            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
        'Next

        MsgBox("Done")

    End Sub

    Private Sub אודותToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles אודותToolStripMenuItem1.Click
        'My.Settings.EmptyCarSerial = 1
        'My.Settings.Save()
        MsgBox(My.Settings.EmptyCarSerial)
    End Sub

    Private Sub BtnAbort_Click(sender As Object, e As EventArgs)
        MsgBox(ActiveUser)
    End Sub

    Private Sub TSMCloseAll_Click(sender As Object, e As EventArgs) Handles TSMCloseAll.Click
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

        If ActiveLvl < 2 Then
            If Application.OpenForms.OfType(Of FrmUsers).Any = True Then
                FmUsers.Activate()
            Else
                FmUsers = New FrmUsers
                FmUsers.MdiParent = Me
                FmUsers.Show()
            End If
        Else
            OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")

        End If
    End Sub

    Private Sub TSBtnBackUp_Click(sender As Object, e As EventArgs) Handles TSBtnBackUp.Click
        FrmBackUp.ShowDialog()
    End Sub



    Private Sub TSPActions_Click(sender As Object, e As EventArgs) Handles TSPActions.Click
        If Application.OpenForms.OfType(Of FrmActions).Any = True Then
            FmActions.Activate()
        Else
            FmActions = New FrmActions
            FmActions.MdiParent = Me
            FmActions.Show()
        End If
    End Sub

    Private Sub TSUsers_Click(sender As Object, e As EventArgs) Handles TSUsers.Click
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

    Private Sub TSActions_Click(sender As Object, e As EventArgs) Handles TSActions.Click
        Try
            If Application.OpenForms.OfType(Of FrmActionsTypes).Any = True Then
                FmActionsTypes.Activate()
            Else
                FmActionsTypes = New FrmActionsTypes
                FmActionsTypes.MdiParent = Me
                FmActionsTypes.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TSBtnProducts_Click(sender As Object, e As EventArgs) Handles TSBtnProducts.Click
        Dim FmProducts As New FrmProducts
        Try
            If Application.OpenForms.OfType(Of FrmProducts).Any = True Then
                FmProducts.Activate()
            Else
                'FmProducts = New FrmProducts
                FmProducts.MdiParent = Me
                FmProducts.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'FrmProducts.ShowDialog()
    End Sub

    Private Sub TSBtnCreateTables_Click(sender As Object, e As EventArgs) Handles TSBtnCreateTables.Click
        CreateTables()
    End Sub
End Class
