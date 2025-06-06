﻿Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.Reporting.WinForms

Module ModFunctions
    'ofiice server
    'Dim OfficeServer As String = "Data Source=DELTA-DFXZ455;Initial Catalog=TRM;Integrated Security=True"

    'local server
    'Public OfficeServer As String = "Data Source=.\SQLEXPRESS;Initial Catalog=StorageCtrl;Integrated Security=True"
    Public OfficeServer As String '= My.Settings.CurrentServer
    Public dbcon As New SqlConnection 'With {.ConnectionString = OfficeServer}


    'online server
    'Dim OfficeServer As String = "server=192.168.2.140; database=StorageCtrl; user id=storage_login; password=Wm8kg7paK6jzAb2ZYnT5qE"
    'Dim OfficeServer As String = "mysql:host=localhost; database=u651653991_anymlai; user id=u651653991_TRManymlai; password=TRManymlai0524373033@@"


    'Public dbcon As New SqlConnection With {.ConnectionString = "Data Source=DELTA-DFXZ455;Initial Catalog=TRM;Integrated Security=True"}




    'Public dbcon As New SqlConnection With {.ConnectionString = My.Settings.CurrentServer}
    'Public dbconOnline As New SqlConnection With {.ConnectionString = My.Settings.OnlineServer}



    '***********************
    Public UserTab As DataTable
    Public MaterialsTab As DataTable
    Public ActionsTab As DataTable
    Public PermissionsTab As DataTable
    Public ActiveUser As String                            'המשתמש הפעיל בכניסה לתוכנה
    Public ActiveLvl As Integer                            'רמת המשתמש הפעיל
    Public ActiveUserSerial As Integer
    Public OldQuantity As Double
    Public ReConnect As Boolean = False    'החלפת משתמש
    Public isAddProduct As Boolean = False
    Public AdminMode As Boolean = False    'מצב מנהל
    Public isAdminCode As Boolean = False
    Public AppLanguage As String
    Public AdminCode As String

    'Public isConnected As Boolean

#Region "Variables for Forms Copies"

    Public FmaAddUserUpdate As New FrmUserAddEdit
    Public FmUsers As New FrmUsers
    Public FmMaterials As New FrmMaterials
    Public FmActionsTypes As New FrmActionsTypes
    Public FmActionAdd As New FrmActionAdd
    Public FmProducts As New FrmProducts
    Public FmAudits As New FrmAudits
    Public FmCostsList As New FrmCostsList
    Public FmSuppliers As New FrmSuppliers






#End Region

    '******************
    Public Agparams(22) As ReportParameter
    Public dbaddapter As SqlDataAdapter
    Public cmd As SqlCommand
    Public MyTab As DataTable
    Public MlaiTab As DataTable
    Public SoldTab As DataTable
    Public VendorsWindow As String                         'לזהות חלון ספקים באיזה מצב פתוח
    Public CustomersWindow As String                       'לזהות חלון לקוחות באיזה מצב פתוח
    Public AgreementStatus As String = "nothing"           'מצב הסכם מכירה/קנייה/ריק...
    Public AgreementPath As String = ""                    'מסלול שמירת ההסכם
    Public Switcher As Boolean                             'כפתור פעיל אן לא פעיל ללקוח או ספק
    Public TCWindow As String                              'לזהות חלון ביטול עסקה באיזה מצב פתוח
    Public ChangeWindow As Boolean = False                 'לזיהוי עסקת החלפה
    Public SoldCardWinDow As String                        'זיהוי לכרטסת רכב
    Public AgreeCarSerial As String

#Region "Variables for Forms Copies"

    Public FmAddNewCar As New FrmAddNewCar
    Public FmCarSale As New FrmCostsList
    Public FmSearch As New FrmSearch
    Public FmSoldcard As New FrmSoldCard
    Public FmVendors As New FrmSuppliers
    Public FmCustomers As New FrmCustomers
    Public FmSoldReport As New FrmAlerts
    Public FmTransactionCancel As New FrmMaterialsImportExcel
    Public FmUserAddEdit As New FrmUserAddEdit
    Public FmActions As New FrmActions

#End Region
    Public Sub UserChk(Que As String)
        cmd = New SqlCommand
        UserTab = New DataTable
        Try
            UserTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Que
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(UserTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function AlertsCount() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from Audits where audit_alert_on = 1"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function
    Public Sub ChkUserChanges(Que As String) '//check if the user lvl still same
        cmd = New SqlCommand
        UserTab = New DataTable
        Try
            UserTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select  * from users where id = '" & ActiveUserSerial & "' "
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(UserTab)
            ActiveLvl = UserTab.Rows(0).Item(3)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub FillList(Que As String)
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
    End Sub

    Public Sub FillQuantity(Que As String, loc_barcode As String)
        'Dim loc_barcode As String = FmActionAdd.CmbLocBarcode.Text
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Que
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@loc_barcode", loc_barcode)
            'MsgBox(CarKind)


            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Fill2Dates(StartDate As Date, EndDate As Date)
        cmd = New SqlCommand
        SoldTab = New DataTable
        Try
            SoldTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from MainList where saledate >= @d1 and saledate <= @d2 and carstatus = 0  and canceled = 0 order by saledate"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("d1", StartDate)
            cmd.Parameters.AddWithValue("d2", EndDate)
            'cmd.Parameters.AddWithValue("d1", FrmSoldReport.DtpFrom.Value.AddDays(-1))
            'cmd.Parameters.AddWithValue("d2", FrmSoldReport.DtpTo.Value)
            dbcon.Open()

            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(SoldTab)
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub FillMlaiList(d1 As Date)
        cmd = New SqlCommand
        MlaiTab = New DataTable
        Try
            MlaiTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from MainList where datein <= @d1 and saledate > @d1 and canceled = 0 order by saledate"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("d1", d1)
            'cmd.Parameters.AddWithValue("d2", d2)
            'cmd.Parameters.AddWithValue("d1", FrmSoldReport.DtpFrom.Value.AddDays(-1))
            'cmd.Parameters.AddWithValue("d2", FrmSoldReport.DtpTo.Value)
            dbcon.Open()
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MlaiTab)
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub FillTestList()
        Dim d1 As Date
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from MainList where datetest <= @d1 and carstatus = 1 and canceled = 0 "
                .Connection = dbcon
            End With
            d1 = Today.AddDays(10)
            cmd.Parameters.AddWithValue("@d1", d1)
            dbcon.Open()
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub DesignSoldDGV(dgv As DataGridView)
        With dgv
            .Columns(0).Visible = False
            .Columns(1).Visible = True
            .Columns(2).Visible = True
            .Columns(3).Visible = False
            .Columns(4).Visible = True
            .Columns(5).Visible = True
            .Columns(6).Visible = True
            .Columns(7).Visible = True
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = True
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = True
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            .Columns(23).Visible = False
            .Columns(24).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(27).Visible = False
            .Columns(28).Visible = True
            .Columns(29).Visible = True
            .Columns(30).Visible = False
            .Columns(31).Visible = False
            .Columns(32).Visible = False
            .Columns(33).Visible = False
            .Columns(34).Visible = False
            .Columns(35).Visible = False
            .Columns(36).Visible = False
            .Columns(37).Visible = False
            .Columns(38).Visible = False
            .Columns(39).Visible = True
            .Columns(40).Visible = True
            .Columns(41).Visible = False
            .Columns(42).Visible = False
            .Columns(43).Visible = False
            .Columns(44).Visible = False


            .Columns(0).HeaderText = "מס"
            .Columns(1).HeaderText = "מספר ביומן"
            .Columns(2).HeaderText = "מספר רישוי"
            .Columns(3).HeaderText = "מצב"
            .Columns(4).HeaderText = "סוג רכב"
            .Columns(5).HeaderText = "שם יצרן"
            .Columns(6).HeaderText = "דגם רכב"
            .Columns(7).HeaderText = "שנת ייצור"
            .Columns(8).HeaderText = "צבע"
            .Columns(9).HeaderText = "יד"
            .Columns(10).HeaderText = "רישום רכב"
            .Columns(11).HeaderText = "סוג דלק"
            .Columns(12).HeaderText = "ת.הילוכים"
            .Columns(13).HeaderText = "נפח מנוע"
            .Columns(14).HeaderText = "קילומטרים"
            .Columns(15).HeaderText = "מחיר מכירה"
            .Columns(16).HeaderText = "שילדה"
            .Columns(17).HeaderText = "קוד רכב"
            .Columns(18).HeaderText = "מפתחות"
            .Columns(19).HeaderText = "תאריך קליטה"
            .Columns(20).HeaderText = "תאריך טסט"
            .Columns(21).HeaderText = "שם המוכר"
            .Columns(22).HeaderText = "ת.ז המוכר"
            .Columns(23).HeaderText = "הערות"
            .Columns(24).HeaderText = "גג נפתח"
            .Columns(25).HeaderText = "וו גרירה"
            .Columns(26).HeaderText = "ח. מגניזיום"
            .Columns(27).HeaderText = "ר. עור"
            .Columns(28).HeaderText = "מחיר רכישה"
            .Columns(29).HeaderText = "תאריך מכירה"
            .Columns(30).HeaderText = "מבוטל"
            .Columns(31).HeaderText = "שם הקונה"
            .Columns(32).HeaderText = "כתובת הקונה"
            .Columns(33).HeaderText = "ת.ז הקונה"
            .Columns(34).HeaderText = "טלפון הקונה"
            .Columns(35).HeaderText = "כתובת המוכר"
            .Columns(36).HeaderText = "טלפון המוכר"
            .Columns(37).HeaderText = "הערות מכירה"
            .Columns(38).HeaderText = "נסיעת מבחן"
            .Columns(39).HeaderText = "חשבונית"
            .Columns(40).HeaderText = "קבלה"
            .Columns(41).HeaderText = "מספר אישור"
            .Columns(42).HeaderText = "הסכם קנייה"
            .Columns(43).HeaderText = "הסכם מכירה"
            .Columns(44).HeaderText = "הוחלף על"




            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'dgv.ClearSelection()
            '.rows(0).DefaultCellStyle.BackColor = 

        End With
    End Sub

    Public Sub ReloadMainList()
        Dim que As String
        que = "select * from MainList where carstatus = 1 and canceled = 0 order by carserial "
        FillList(que)
        'FrmMainList.DgvMain.DataSource = MyTab
        'DesignMainDGV(FrmMainList.DgvMain)
    End Sub

    Public Sub AddNewCar(CarSerial As Integer, CarId As String, CarKind As String, carmodel As String, cartype As String, caryear As Integer, carcolor As String, carhand As Integer, mainis As String, caroil As String, cargear As String, engine As String, carkm As String, priceout As Integer, shelda As String, carcode As String, keynum As Integer, datein As Date, datetest As Date, salername As String, salerid As String, carbuyinfo As String, roof As Boolean, vav As Boolean, wheels As Boolean, seats As Boolean, pricein As Integer, saleradress As String, salerphone As String, BuyAgreement As String)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into MainList(CarSerial,CarId,CarKind,carmodel,cartype,caryear,carcolor,carhand,mainis,caroil,cargear,engine,carkm,priceout,shelda,carcode,keynum,datein,datetest,salername,salerid,carbuyinfo,roof,vav,wheels,seats,pricein,saleradress,salerphone,TradeIn,BuyAgreement) values (@CarSerial,@CarId,@CarKind,@carmodel,@cartype,@caryear,@carcolor,@carhand,@mainis,@caroil,@cargear,@engine,@carkm,@priceout,@shelda,@carcode,@keynum,@datein,@datetest,@salername,@salerid,@carbuyinfo,@roof,@vav,@wheels,@seats,@pricein,@saleradress,@salerphone,@TradeIn,@BuyAgreement)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@carserial", CarSerial)
            cmd.Parameters.AddWithValue("@carid", CarId)
            cmd.Parameters.AddWithValue("@Carkind", CarKind)
            cmd.Parameters.AddWithValue("@carmodel", carmodel)
            cmd.Parameters.AddWithValue("@cartype", cartype)
            cmd.Parameters.AddWithValue("@CarYear", caryear)
            cmd.Parameters.AddWithValue("@carcolor", carcolor)
            cmd.Parameters.AddWithValue("@carhand", carhand)
            cmd.Parameters.AddWithValue("@mainis", mainis)
            cmd.Parameters.AddWithValue("@caroil", caroil)
            cmd.Parameters.AddWithValue("@cargear", cargear)
            cmd.Parameters.AddWithValue("@engine", engine)
            cmd.Parameters.AddWithValue("@carkm", carkm)
            cmd.Parameters.AddWithValue("@priceout", priceout)
            cmd.Parameters.AddWithValue("@shelda", shelda)
            cmd.Parameters.AddWithValue("@carcode", carcode)
            cmd.Parameters.AddWithValue("@keynum", keynum)
            cmd.Parameters.AddWithValue("@datein", datein)
            cmd.Parameters.AddWithValue("@datetest", datetest)
            cmd.Parameters.AddWithValue("@salername", salername)
            cmd.Parameters.AddWithValue("@salerid", salerid)
            cmd.Parameters.AddWithValue("@carbuyinfo", carbuyinfo)
            cmd.Parameters.AddWithValue("@roof", roof)
            cmd.Parameters.AddWithValue("@vav", vav)
            cmd.Parameters.AddWithValue("@wheels", wheels)
            cmd.Parameters.AddWithValue("@seats", seats)
            cmd.Parameters.AddWithValue("@pricein", pricein)
            cmd.Parameters.AddWithValue("@saleradress", saleradress)
            cmd.Parameters.AddWithValue("@salerphone", salerphone)
            cmd.Parameters.AddWithValue("@TradeIn", 0)
            cmd.Parameters.AddWithValue("@BuyAgreement", BuyAgreement)
            cmd.Parameters.AddWithValue("@TradeInCarSerial", CarSerial)
            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub LoadCarDetails(dgv As DataGridView, Frm As Object)
        With Frm
            .TxtCarSerial.Text = dgv.CurrentRow.Cells(1).Value
            .TxtCarId.Text = dgv.CurrentRow.Cells(2).Value
            .CmbCarKind.Text = dgv.CurrentRow.Cells(4).Value
            .CmbCarModel.Text = dgv.CurrentRow.Cells(5).Value
            .CmbCarType.Text = dgv.CurrentRow.Cells(6).Value
            .NumCarYear.Value = dgv.CurrentRow.Cells(7).Value
            .TxtCarColor.Text = dgv.CurrentRow.Cells(8).Value
            .NumCarHand.Value = dgv.CurrentRow.Cells(9).Value
            .CmbMainIs.Text = dgv.CurrentRow.Cells(10).Value
            .CmbCarOil.Text = dgv.CurrentRow.Cells(11).Value
            .CmbCarGear.Text = dgv.CurrentRow.Cells(12).Value
            .TxtEngine.Text = dgv.CurrentRow.Cells(13).Value
            .TxtCarKM.Text = dgv.CurrentRow.Cells(14).Value
            .TxtPriceOut.Text = dgv.CurrentRow.Cells(15).Value
            .TxtShelda.Text = dgv.CurrentRow.Cells(16).Value
            .TxtCarCode.Text = dgv.CurrentRow.Cells(17).Value
            .NumKeyNum.Value = dgv.CurrentRow.Cells(18).Value
            .DtpDatein.Text = dgv.CurrentRow.Cells(19).Value
            .DtpDateTest.Text = dgv.CurrentRow.Cells(20).Value
            .TxtSalerName.Text = dgv.CurrentRow.Cells(21).Value
            .TxtSalerId.Text = dgv.CurrentRow.Cells(22).Value
            .TxtCarInfo.Text = dgv.CurrentRow.Cells(23).Value
            .ChkRoof.Checked = dgv.CurrentRow.Cells(24).Value
            .ChkVav.Checked = dgv.CurrentRow.Cells(25).Value
            .ChkWheels.Checked = dgv.CurrentRow.Cells(26).Value
            .ChkSeats.Checked = dgv.CurrentRow.Cells(27).Value
            .TxtPriceIn.Text = dgv.CurrentRow.Cells(28).Value
            .TxtSalerAdress.Text = dgv.CurrentRow.Cells(35).Value
            .TxtSalerPhone.Text = dgv.CurrentRow.Cells(36).Value
        End With
    End Sub

    Public Sub UpdateCar(CarId As String, CarKind As String, carmodel As String, cartype As String, caryear As Integer, carcolor As String, carhand As Integer, mainis As String, caroil As String, cargear As String, engine As String, carkm As String, priceout As Integer, shelda As String, carcode As String, keynum As Integer, datein As Date, datetest As Date, salername As String, salerid As String, carbuyinfo As String, roof As Boolean, vav As Boolean, wheels As Boolean, seats As Boolean, pricein As Integer, saleradress As String, salerphone As String, id As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update MainList set CarId=@carid, CarKind=@carkind, carmodel=@carmodel, cartype=@cartype, caryear=@caryear, carcolor=@carcolor, carhand=@carhand, mainis=@mainis, caroil=@caroil, cargear=@cargear, engine=@engine, carkm=@carkm, priceout=@priceout, shelda=@shelda, carcode=@carcode, keynum=@keynum, datein=@datein, datetest=@datetest, salername=@salername, salerid=@salerid, carbuyinfo=@carbuyinfo, roof=@roof, vav=@vav, wheels=@wheels, seats=@seats, pricein=@pricein, saleradress=@saleradress, salerphone=@salerphone where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@CarId", CarId)
            cmd.Parameters.AddWithValue("@CarKind", CarKind)
            cmd.Parameters.AddWithValue("@carmodel", carmodel)
            cmd.Parameters.AddWithValue("@cartype", cartype)
            cmd.Parameters.AddWithValue("@caryear", caryear)
            cmd.Parameters.AddWithValue("@carcolor", carcolor)
            cmd.Parameters.AddWithValue("@carhand", carhand)
            cmd.Parameters.AddWithValue("@mainis", mainis)
            cmd.Parameters.AddWithValue("@caroil", caroil)
            cmd.Parameters.AddWithValue("@cargear", cargear)
            cmd.Parameters.AddWithValue("@engine", engine)
            cmd.Parameters.AddWithValue("@carkm", carkm)
            cmd.Parameters.AddWithValue("@priceout", priceout)
            cmd.Parameters.AddWithValue("@shelda", shelda)
            cmd.Parameters.AddWithValue("@carcode", carcode)
            cmd.Parameters.AddWithValue("@keynum", keynum)
            cmd.Parameters.AddWithValue("@datein", datein)
            cmd.Parameters.AddWithValue("@datetest", datetest)
            cmd.Parameters.AddWithValue("@salername", salername)
            cmd.Parameters.AddWithValue("@salerid", salerid)
            cmd.Parameters.AddWithValue("@carbuyinfo", carbuyinfo)
            cmd.Parameters.AddWithValue("@roof", roof)
            cmd.Parameters.AddWithValue("@vav", vav)
            cmd.Parameters.AddWithValue("@wheels", wheels)
            cmd.Parameters.AddWithValue("@seats", seats)
            cmd.Parameters.AddWithValue("@pricein", pricein)
            cmd.Parameters.AddWithValue("@saleradress", saleradress)
            cmd.Parameters.AddWithValue("@salerphone", salerphone)
            cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub SaleCar(saledate As Date, priceout As Integer, carsaleinfo As String, buyername As String, buyeradress As String, buyerid As String, buyerphone As String, id As Integer, ReceiptNum As String, InvoiceNum As String, ConfirmNum As String, SaleAgreement As String, TradeIn As Boolean, TradeInCarSerial As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update MainList set carstatus=@carstatus,saledate=@saledate,priceout=@priceout,carsaleinfo=@carsaleinfo, buyername=@buyername, buyeradress=@buyeradress, buyerid=@buyerid, buyerphone=@buyerphone,ReceiptNum=@ReceiptNum,InvoiceNum=@InvoiceNum,ConfirmNum=@ConfirmNum,SaleAgreement=@SaleAgreement,TradeIn=@TradeIn,TradeInCarSerial=@TradeInCarSerial where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@carstatus", 0)
            cmd.Parameters.AddWithValue("@saledate", saledate)
            cmd.Parameters.AddWithValue("@priceout", priceout)
            cmd.Parameters.AddWithValue("@carsaleinfo", carsaleinfo)
            cmd.Parameters.AddWithValue("@buyername", buyername)
            cmd.Parameters.AddWithValue("@buyeradress", buyeradress)
            cmd.Parameters.AddWithValue("@buyerid", buyerid)
            cmd.Parameters.AddWithValue("@buyerphone", buyerphone)
            cmd.Parameters.AddWithValue("@ReceiptNum", ReceiptNum)
            cmd.Parameters.AddWithValue("@InvoiceNum", InvoiceNum)
            cmd.Parameters.AddWithValue("@ConfirmNum", ConfirmNum)
            cmd.Parameters.AddWithValue("@SaleAgreement", SaleAgreement)
            cmd.Parameters.AddWithValue("@TradeIn", TradeIn)
            cmd.Parameters.AddWithValue("@TradeInCarSerial", TradeInCarSerial)
            cmd.Parameters.AddWithValue("@id", id)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub CarDeleteRestore(id As Integer, canceled As Integer, CarSaleInfo As String, SaleDate As Date)
        Try
            cmd = New SqlCommand

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update MainList set canceled=@canceled,CarSaleInfo=@carsaleinfo,SaleDate=@SaleDate where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@CarSaleInfo", CarSaleInfo)
            cmd.Parameters.AddWithValue("@canceled", canceled)
            cmd.Parameters.AddWithValue("@SaleDate", SaleDate)

            cmd.Parameters.AddWithValue("@id", id)


            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub NumbersOnly(e As KeyPressEventArgs)
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub LoadRequired(Frm As Object)
        If Frm.TxtCarId.Text = "" Then
            Frm.TxtCarId.BackColor = Color.LightPink
        Else
            Frm.TxtCarId.BackColor = Color.White
        End If
        If My.Settings.EditDataBase = True Then
            Frm.CmbCarKind.BackColor = Color.LightPink
        Else
            Frm.CmbCarKind.BackColor = Color.White
        End If
        If My.Settings.CarType = True Then
            Frm.CmbCarType.BackColor = Color.LightPink
        Else
            Frm.CmbCarType.BackColor = Color.White
        End If
        If My.Settings.AdminCode = True Then
            Frm.TxtCarColor.BackColor = Color.LightPink
        Else
            Frm.TxtCarColor.BackColor = Color.White
        End If
        If My.Settings.Tax = True Then
            Frm.CmbCarOil.BackColor = Color.LightPink
        Else
            Frm.CmbCarOil.BackColor = Color.White
        End If
        If My.Settings.MaterialQuantityLock = True Then
            Frm.TxtCarKM.BackColor = Color.LightPink
        Else
            Frm.TxtCarKM.BackColor = Color.White
        End If
        If My.Settings.Language = True Then
            Frm.TxtShelda.BackColor = Color.LightPink
        Else
            Frm.TxtShelda.BackColor = Color.White
        End If
        If My.Settings.PriceOut = True Then
            Frm.TxtPriceOut.BackColor = Color.LightPink
        Else
            Frm.TxtPriceOut.BackColor = Color.White
        End If
        If My.Settings.CurrentVersion = True Then
            Frm.CmbCarModel.BackColor = Color.LightPink
        Else
            Frm.CmbCarModel.BackColor = Color.White
        End If
        If My.Settings.MainIs = True Then
            Frm.CmbMainIs.BackColor = Color.LightPink
        Else
            Frm.CmbMainIs.BackColor = Color.White
        End If
        If My.Settings.CarGear = True Then
            Frm.CmbCarGear.BackColor = Color.LightPink
        Else
            Frm.CmbCarGear.BackColor = Color.White
        End If
        If My.Settings.Engine = True Then
            Frm.TxtEngine.BackColor = Color.LightPink
        Else
            Frm.TxtEngine.BackColor = Color.White
        End If
        If My.Settings.CarCode = True Then
            Frm.TxtCarCode.BackColor = Color.LightPink
        Else
            Frm.TxtCarCode.BackColor = Color.White
        End If
        If My.Settings.PriceIn = True Then
            Frm.TxtPriceIn.BackColor = Color.LightPink
        Else
            Frm.TxtPriceIn.BackColor = Color.White
        End If
        If My.Settings.SalerName = True Then
            Frm.TxtSalerName.BackColor = Color.LightPink
        Else
            Frm.TxtSalerName.BackColor = Color.White
        End If
        If My.Settings.SalerAdress = True Then
            Frm.TxtSalerAdress.BackColor = Color.LightPink
        Else
            Frm.TxtSalerAdress.BackColor = Color.White
        End If
        If My.Settings.SalerPhone = True Then
            Frm.TxtSalerPhone.BackColor = Color.LightPink
        Else
            Frm.TxtSalerPhone.BackColor = Color.White
        End If
        If My.Settings.SalerId = True Then
            Frm.TxtSalerId.BackColor = Color.LightPink
        Else
            Frm.TxtSalerId.BackColor = Color.White
        End If
    End Sub

    Public Sub WhiteAll()
        FrmAddNewCar.TxtCarId.BackColor = Color.White
        FrmAddNewCar.CmbCarKind.BackColor = Color.White
        FrmAddNewCar.CmbCarType.BackColor = Color.White
        FrmAddNewCar.TxtCarColor.BackColor = Color.White
        FrmAddNewCar.CmbCarOil.BackColor = Color.White
        FrmAddNewCar.TxtCarKM.BackColor = Color.White
        FrmAddNewCar.TxtShelda.BackColor = Color.White
        FrmAddNewCar.TxtPriceOut.BackColor = Color.White
        FrmAddNewCar.CmbCarModel.BackColor = Color.White
        FrmAddNewCar.CmbMainIs.BackColor = Color.White
        FrmAddNewCar.CmbCarGear.BackColor = Color.White
        FrmAddNewCar.TxtEngine.BackColor = Color.White
        FrmAddNewCar.TxtCarCode.BackColor = Color.White
        FrmAddNewCar.TxtPriceIn.BackColor = Color.White
        FrmAddNewCar.TxtSalerName.BackColor = Color.White
        FrmAddNewCar.TxtSalerAdress.BackColor = Color.White
        FrmAddNewCar.TxtSalerPhone.BackColor = Color.White
        FrmAddNewCar.TxtSalerId.BackColor = Color.White
    End Sub

    Public Sub AddCarModel(carmodel As String, carmodelid As Integer, carkindid As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into carmodel (Carmodel,carmodelid ,carkindid) values (@Carmodel,@carmodelid,@carkindid)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@carmodel", carmodel)
            cmd.Parameters.AddWithValue("@carmodelid", carmodelid)
            cmd.Parameters.AddWithValue("@carkindid", carkindid)
            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub AddCarType(cartype As String, cartypeid As Integer, carmodelid As Integer, carkindid As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into cartype (Cartype,cartypeid,carmodelid,carkindid) values (@Cartype,@cartypeid,@carmodelid,@carkindid)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@cartype", cartype)
            cmd.Parameters.AddWithValue("@cartypeid", cartypeid)
            cmd.Parameters.AddWithValue("@carmodelid", carmodelid)
            cmd.Parameters.AddWithValue("@carkindid", carkindid)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub AddCarKind(carkind As String, carkindid As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "insert into carkind (Carkind,carkindid) values (@Carkind,@carkindid)"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@carkind", carkind)
            cmd.Parameters.AddWithValue("@carkindid", carkindid)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub LoadCarKind()
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from CarKind where active = 1"
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadCarmodel(carkindid As Integer)
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from Carmodel where carkindid = @carkindid and active = 1 order by carmodel"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@carkindid", carkindid)
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub LoadCartype(carmodelid As Integer, carkindid As Integer)
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select * from Cartype where carkindid = @carkindid and carmodelid = @carmodelid and active = 1 order by cartype"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@carkindid", carkindid)
            cmd.Parameters.AddWithValue("@carmodelid", carmodelid)
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub LoadSoldCard()

        With FrmSoldCard
            .TxtCarSerial.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(1).Value
            .TxtCarId.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(2).Value
            .TxtCarKind.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(4).Value
            .TxtCarModel.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(5).Value
            .TxtCarType.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(6).Value
            .TxtCarYear.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(7).Value
            .TxtCarColor.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(8).Value
            .TxtCarHand.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(9).Value
            .TxtMainIs.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(10).Value
            .TxtCarOil.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(11).Value
            .TxtCarGear.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(12).Value
            .TxtEngine.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(13).Value
            .TxtCarKM.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(14).Value
            .TxtPriceOut.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(15).Value
            .TxtShelda.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(16).Value
            .TxtCarCode.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(17).Value
            .TxtKeyNum.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(18).Value
            .TxtDateIn.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(19).Value
            .TxtDateTest.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(20).Value
            .TxtSalerName.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(21).Value
            .TxtSalerId.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(22).Value
            .TxtCarBuyInfo.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(23).Value
            .ChkRoof.Checked = FmSoldReport.DGVAlerts.CurrentRow.Cells(24).Value
            .ChkVav.Checked = FmSoldReport.DGVAlerts.CurrentRow.Cells(25).Value
            .ChkWheels.Checked = FmSoldReport.DGVAlerts.CurrentRow.Cells(26).Value
            .ChkSeats.Checked = FmSoldReport.DGVAlerts.CurrentRow.Cells(27).Value
            .TxtPriceIn.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(28).Value
            .TxtSaleDate.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(29).Value
            .TxtBuyerName.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(31).Value
            .TxtBuyerAdress.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(32).Value
            .TxtBuyerId.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(33).Value
            .TxtBuyerPhone.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(34).Value
            .TxtSalerAdress.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(35).Value
            .TxtSalerPhone.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(36).Value
            .TxtCarSaleInfo.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(37).Value
            .TxtReceiptNum.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(40).Value
            .TxtInvoiceNum.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(39).Value
            .TxtConfirmNum.Text = FmSoldReport.DGVAlerts.CurrentRow.Cells(41).Value

        End With
    End Sub



    Public Sub LoadFromSold(id As Integer)
        Dim que As String
        que = "select * from MainList where id ='" & id & "' "
        FillList(que)
        FmAddNewCar.TxtCarId.Text = MyTab.Rows(0).Item(2)
        FmAddNewCar.CmbCarKind.Text = MyTab.Rows(0).Item(4)
        FmAddNewCar.CmbCarModel.Text = MyTab.Rows(0).Item(5)
        FmAddNewCar.CmbCarType.Text = MyTab.Rows(0).Item(6)
        FmAddNewCar.NumCarYear.Value = MyTab.Rows(0).Item(7)
        FmAddNewCar.CmbMainIs.Text = MyTab.Rows(0).Item(10)
        FmAddNewCar.TxtCarColor.Text = MyTab.Rows(0).Item(8)
        FmAddNewCar.CmbCarGear.Text = MyTab.Rows(0).Item(12)
        FmAddNewCar.CmbCarOil.Text = MyTab.Rows(0).Item(11)
        FmAddNewCar.TxtEngine.Text = MyTab.Rows(0).Item(13)
        FmAddNewCar.TxtCarCode.Text = MyTab.Rows(0).Item(17)
        FmAddNewCar.TxtShelda.Text = MyTab.Rows(0).Item(16)
        FmAddNewCar.NumKeyNum.Value = MyTab.Rows(0).Item(18)
        FmAddNewCar.DtpDateTest.Value = MyTab.Rows(0).Item(20)
        FmAddNewCar.ChkVav.Checked = MyTab.Rows(0).Item(25)
        FmAddNewCar.ChkRoof.Checked = MyTab.Rows(0).Item(24)
        FmAddNewCar.ChkWheels.Checked = MyTab.Rows(0).Item(26)
        FmAddNewCar.ChkSeats.Checked = MyTab.Rows(0).Item(27)
    End Sub

    Public Sub BackUp(BackUpPath As String)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "backup database StorageCtrl to disk= '" & BackUpPath & ".bak'"
                '.CommandText = "backup database TRM to disk= c:\test.bak "

                .Connection = dbcon
            End With
            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Function RestoreDB(RestoreFile As String) As Boolean
        Dim connSQLServer2 As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        Try
            Dim RestoreCmd As New SqlCommand
            RestoreCmd = New SqlCommand("ALTER DATABASE StorageCtrl SET OFFLINE WITH ROLLBACK IMMEDIATE; restore database StorageCtrl from disk= '" + RestoreFile + "' with replace;ALTER DATABASE StorageCtrl SET onLINE", connSQLServer2)
            connSQLServer2.Open()
            RestoreCmd.ExecuteNonQuery()
            connSQLServer2.Close()
            RestoreCmd = Nothing
            Return True
        Catch ex As Exception
            Return False
        Finally
            connSQLServer2.Close()
        End Try
    End Function

    Public Sub LoadAgree()
        Dim AgreeDateTime As Date = Now.ToString
        Dim SalerName As String = ""
        Dim SalerId As String = ""
        Dim SalerAdress As String = ""
        Dim SalerPhone As String = ""
        Dim BuyerName As String = ""
        Dim BuyerId As String = ""
        Dim BuyerAdress As String = ""
        Dim BuyerPhone As String = ""
        Dim CarMT As String = ""
        Dim MainIs As String = ""
        Dim CarId As String = ""
        Dim CarYear As String = ""
        Dim CarKM As String = ""
        Dim CarSerial As String = ""
        Dim Price As String = ""
        Dim SaleInfo As String = ""

        If AgreementStatus = "SaleNon" Then
            'AgreeDateTime = FrmCarSale.DtpSaleDate.Value
            SalerName = My.Settings.LocalServer
            SalerId = My.Settings.isShowWhatsNew
            SalerAdress = My.Settings.OnlineServer
            SalerPhone = My.Settings.CurrentServer
            BuyerName = ""
            BuyerId = ""
            BuyerAdress = ""
            BuyerPhone = ""
            CarMT = ""
            MainIs = ""
            CarId = ""
            CarYear = ""
            CarKM = ""
            AgreeCarSerial = ""
            Price = ""
            SaleInfo = ""
        End If

        If AgreementStatus = "BuyNon" Then
            AgreeDateTime = FmCarSale.DTPStartDate.Value
            SalerName = ""
            SalerId = ""
            SalerAdress = ""
            SalerPhone = ""
            BuyerName = My.Settings.LocalServer
            BuyerId = My.Settings.isShowWhatsNew
            BuyerAdress = My.Settings.OnlineServer
            BuyerPhone = My.Settings.CurrentServer
            CarMT = ""
            MainIs = ""
            CarId = ""
            CarYear = ""
            CarKM = ""
            AgreeCarSerial = ""
            Price = ""
            SaleInfo = ""
        End If

        Agparams(0) = New ReportParameter("JobName", My.Settings.LocalServer)
        Agparams(1) = New ReportParameter("JobPhone", My.Settings.CurrentServer)
        Agparams(2) = New ReportParameter("JobFax", My.Settings.AdminUser)
        Agparams(3) = New ReportParameter("JobEmail", My.Settings.AdminPass)
        Agparams(4) = New ReportParameter("JobId", My.Settings.isShowWhatsNew)
        Agparams(5) = New ReportParameter("JobAdress", My.Settings.OnlineServer)
        Agparams(6) = New ReportParameter("AgreeDateTime", AgreeDateTime)
        Agparams(7) = New ReportParameter("SalerName", SalerName)
        Agparams(8) = New ReportParameter("SalerId", SalerId)
        Agparams(9) = New ReportParameter("SalerAdress", SalerAdress)
        Agparams(10) = New ReportParameter("SalerPhone", SalerPhone)
        Agparams(11) = New ReportParameter("BuyerName", BuyerName)
        Agparams(12) = New ReportParameter("BuyerId", BuyerId)
        Agparams(13) = New ReportParameter("BuyerAdress", BuyerAdress)
        Agparams(14) = New ReportParameter("BuyerPhone", BuyerPhone)
        Agparams(15) = New ReportParameter("CarMT", CarMT)
        Agparams(16) = New ReportParameter("MainIs", MainIs)
        Agparams(17) = New ReportParameter("CarId", CarId)
        Agparams(18) = New ReportParameter("CarYear", CarYear)
        Agparams(19) = New ReportParameter("CarKM", CarKM)
        Agparams(20) = New ReportParameter("CarSerial", AgreeCarSerial)
        Agparams(21) = New ReportParameter("Price", Price)
        Agparams(22) = New ReportParameter("SaleInfo", SaleInfo)
    End Sub

    Public Sub TC(CarStatus As Boolean, PriceOut As Integer, SaleDate As Date, BuyerName As String, BuyerAdress As String, BuyerId As String, BuyerPhone As String, CarSaleInfo As String, InvoiceNum As String, ReceiptNum As String, ConfirmNum As String, SaleAgreement As String, id As Integer)
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update MainList set CarStatus=@CarStatus,PriceOut=@PriceOut,SaleDate=@SaleDate,BuyerName=@BuyerName,BuyerAdress=@BuyerAdress,BuyerId=@BuyerId,BuyerPhone=@BuyerPhone,CarSaleInfo=@CarSaleInfo,InvoiceNum=@InvoiceNum,ReceiptNum=@ReceiptNum,ConfirmNum=@ConfirmNum,SaleAgreement=@SaleAgreement where id=@id"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@CarStatus", CarStatus)
            cmd.Parameters.AddWithValue("@PriceOut", PriceOut)
            cmd.Parameters.AddWithValue("@SaleDate", SaleDate)
            cmd.Parameters.AddWithValue("@BuyerName", BuyerName)
            cmd.Parameters.AddWithValue("@BuyerAdress", BuyerAdress)
            cmd.Parameters.AddWithValue("@BuyerId", BuyerId)
            cmd.Parameters.AddWithValue("@BuyerPhone", BuyerPhone)
            cmd.Parameters.AddWithValue("@CarSaleInfo", CarSaleInfo)
            cmd.Parameters.AddWithValue("@InvoiceNum", InvoiceNum)
            cmd.Parameters.AddWithValue("@ReceiptNum", ReceiptNum)
            cmd.Parameters.AddWithValue("@ConfirmNum", ConfirmNum)
            cmd.Parameters.AddWithValue("@SaleAgreement", SaleAgreement)
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

    Public Sub LoadSoldCard2()

        With FmSoldcard
            .TxtCarSerial.Text = FmSearch.DgvResults.CurrentRow.Cells(1).Value
            .TxtCarId.Text = FmSearch.DgvResults.CurrentRow.Cells(2).Value
            .TxtCarKind.Text = FmSearch.DgvResults.CurrentRow.Cells(4).Value
            .TxtCarModel.Text = FmSearch.DgvResults.CurrentRow.Cells(5).Value
            .TxtCarType.Text = FmSearch.DgvResults.CurrentRow.Cells(6).Value
            .TxtCarYear.Text = FmSearch.DgvResults.CurrentRow.Cells(7).Value
            .TxtCarColor.Text = FmSearch.DgvResults.CurrentRow.Cells(8).Value
            .TxtCarHand.Text = FmSearch.DgvResults.CurrentRow.Cells(9).Value
            .TxtMainIs.Text = FmSearch.DgvResults.CurrentRow.Cells(10).Value
            .TxtCarOil.Text = FmSearch.DgvResults.CurrentRow.Cells(11).Value
            .TxtCarGear.Text = FmSearch.DgvResults.CurrentRow.Cells(12).Value
            .TxtEngine.Text = FmSearch.DgvResults.CurrentRow.Cells(13).Value
            .TxtCarKM.Text = FmSearch.DgvResults.CurrentRow.Cells(14).Value
            .TxtPriceOut.Text = FmSearch.DgvResults.CurrentRow.Cells(15).Value
            .TxtShelda.Text = FmSearch.DgvResults.CurrentRow.Cells(16).Value
            .TxtCarCode.Text = FmSearch.DgvResults.CurrentRow.Cells(17).Value
            .TxtKeyNum.Text = FmSearch.DgvResults.CurrentRow.Cells(18).Value
            .TxtDateIn.Text = FmSearch.DgvResults.CurrentRow.Cells(19).Value
            .TxtDateTest.Text = FmSearch.DgvResults.CurrentRow.Cells(20).Value
            .TxtSalerName.Text = FmSearch.DgvResults.CurrentRow.Cells(21).Value
            .TxtSalerId.Text = FmSearch.DgvResults.CurrentRow.Cells(22).Value
            .TxtCarBuyInfo.Text = FmSearch.DgvResults.CurrentRow.Cells(23).Value
            .ChkRoof.Checked = FmSearch.DgvResults.CurrentRow.Cells(24).Value
            .ChkVav.Checked = FmSearch.DgvResults.CurrentRow.Cells(25).Value
            .ChkWheels.Checked = FmSearch.DgvResults.CurrentRow.Cells(26).Value
            .ChkSeats.Checked = FmSearch.DgvResults.CurrentRow.Cells(27).Value
            .TxtPriceIn.Text = FmSearch.DgvResults.CurrentRow.Cells(28).Value
            .TxtSaleDate.Text = FmSearch.DgvResults.CurrentRow.Cells(29).Value
            .TxtBuyerName.Text = FmSearch.DgvResults.CurrentRow.Cells(31).Value
            .TxtBuyerAdress.Text = FmSearch.DgvResults.CurrentRow.Cells(32).Value
            .TxtBuyerId.Text = FmSearch.DgvResults.CurrentRow.Cells(33).Value
            .TxtBuyerPhone.Text = FmSearch.DgvResults.CurrentRow.Cells(34).Value
            .TxtSalerAdress.Text = FmSearch.DgvResults.CurrentRow.Cells(35).Value
            .TxtSalerPhone.Text = FmSearch.DgvResults.CurrentRow.Cells(36).Value
            .TxtCarSaleInfo.Text = FmSearch.DgvResults.CurrentRow.Cells(37).Value
            .TxtReceiptNum.Text = FmSearch.DgvResults.CurrentRow.Cells(40).Value
            .TxtInvoiceNum.Text = FmSearch.DgvResults.CurrentRow.Cells(39).Value
            .TxtConfirmNum.Text = FmSearch.DgvResults.CurrentRow.Cells(41).Value

        End With
    End Sub



    Public Function isAllowed(PermissionID As Integer) As Boolean
        Dim Que As String
        Que = "select * from users where id = " & ActiveUserSerial
        FillList(Que)
        ActiveLvl = MyTab.Rows(0).Item(3)
        Que = "select * from permissions where id = " & PermissionID
        FillList(Que)
        Select Case ActiveLvl
            Case 1
                If MyTab.Rows(0).Item(2) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 2
                If MyTab.Rows(0).Item(3) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 3
                If MyTab.Rows(0).Item(4) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 4
                If MyTab.Rows(0).Item(5) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 5
                If MyTab.Rows(0).Item(6) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 6
                If MyTab.Rows(0).Item(7) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 7
                If MyTab.Rows(0).Item(8) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 8
                If MyTab.Rows(0).Item(9) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
            Case 9
                If MyTab.Rows(0).Item(10) = True Then
                    isAllowed = True
                Else
                    isAllowed = False
                End If
        End Select
    End Function

    Public Sub SavePermissions(DGV As DataGridView)
        Try
            For i = 0 To DGV.RowCount - 1
                cmd = New SqlCommand

                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = "update permissions set permission_name=@permission_name,lvl1=@lvl1,lvl2=@lvl2,lvl3=@lvl3,lvl4=@lvl4,lvl5=@lvl5,lvl6=@lvl6,lvl7=@lvl7,lvl8=@lvl8,lvl9=@lvl9 where id=@id"
                    .Connection = dbcon
                End With
                cmd.Parameters.AddWithValue("@permission_name", DGV.Rows(i).Cells(1).Value)
                cmd.Parameters.AddWithValue("@lvl1", DGV.Rows(i).Cells(2).Value)
                cmd.Parameters.AddWithValue("@lvl2", DGV.Rows(i).Cells(3).Value)
                cmd.Parameters.AddWithValue("@lvl3", DGV.Rows(i).Cells(4).Value)
                cmd.Parameters.AddWithValue("@lvl4", DGV.Rows(i).Cells(5).Value)
                cmd.Parameters.AddWithValue("@lvl5", DGV.Rows(i).Cells(6).Value)
                cmd.Parameters.AddWithValue("@lvl6", DGV.Rows(i).Cells(7).Value)
                cmd.Parameters.AddWithValue("@lvl7", DGV.Rows(i).Cells(8).Value)
                cmd.Parameters.AddWithValue("@lvl8", DGV.Rows(i).Cells(9).Value)
                cmd.Parameters.AddWithValue("@lvl9", DGV.Rows(i).Cells(10).Value)


                cmd.Parameters.AddWithValue("@id", DGV.Rows(i).Cells(0).Value)


                dbcon.Open()
                cmd.ExecuteNonQuery()
                dbcon.Close()
                cmd = Nothing
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub SaveUnits(DGV As DataGridView)
        Try
            For i = 0 To DGV.RowCount - 2
                cmd = New SqlCommand
                'MsgBox(DGV.Rows(i).Cells(0).Value)

                If DGV.Rows(i).Cells(0).Value Is Nothing OrElse DGV.Rows(i).Cells(0).Value.ToString.Trim = "" Then
                    'MsgBox("enmpt")
                    With cmd
                        .CommandType = CommandType.Text
                        .CommandText = "insert into units (unit_name)values(@unit_name)"
                        .Connection = dbcon
                    End With
                    cmd.Parameters.AddWithValue("@unit_name", DGV.Rows(i).Cells(1).Value)

                    dbcon.Open()
                    cmd.ExecuteNonQuery()
                    dbcon.Close()
                Else
                    'MsgBox(DGV.Rows(i).Cells(1).Value)

                    With cmd
                        .CommandType = CommandType.Text
                        .CommandText = "update units set unit_name=@unit_name where id=@id"
                        .Connection = dbcon
                    End With
                    cmd.Parameters.AddWithValue("@unit_name", DGV.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@id", DGV.Rows(i).Cells(0).Value)

                    dbcon.Open()
                    cmd.ExecuteNonQuery()
                    dbcon.Close()
                    cmd = Nothing
                End If
            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub SaveActionTypes(DGV As DataGridView)
        Try
            For i = 0 To DGV.RowCount - 2
                cmd = New SqlCommand
                'MsgBox(DGV.Rows(i).Cells(0).Value)

                If DGV.Rows(i).Cells(0).Value Is Nothing OrElse DGV.Rows(i).Cells(0).Value.ToString.Trim = "" Then
                    'MsgBox("enmpt")
                    With cmd
                        .CommandType = CommandType.Text
                        .CommandText = "insert into action_typers (action_type_name,isincrease)values(@action_type_name,@isincrease)"
                        .Connection = dbcon
                    End With
                    cmd.Parameters.AddWithValue("@action_type_name", DGV.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@isincrease", DGV.Rows(i).Cells(2).Value)

                    dbcon.Open()
                    cmd.ExecuteNonQuery()
                    dbcon.Close()
                Else
                    'MsgBox(DGV.Rows(i).Cells(1).Value)

                    With cmd
                        .CommandType = CommandType.Text
                        .CommandText = "update action_types set action_type_name=@action_type_name,isincrease=@isincrease where id=@id"
                        .Connection = dbcon
                    End With
                    cmd.Parameters.AddWithValue("@action_type_name", DGV.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@isincrease", DGV.Rows(i).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@id", DGV.Rows(i).Cells(0).Value)

                    dbcon.Open()
                    cmd.ExecuteNonQuery()
                    dbcon.Close()
                    cmd = Nothing
                End If
            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Sub ChkForUpdates()
        Try
            Dim Request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.ctrlmanager.com/TRM/Version.txt")
            Dim Response As System.Net.HttpWebResponse = Request.GetResponse()
            Dim StreamR As System.IO.StreamReader = New System.IO.StreamReader(Response.GetResponseStream())
            Dim NewVersion As String = StreamR.ReadToEnd()
            Dim CurVersion As String = Application.ProductVersion
            If NewVersion > CurVersion Then
                Dim FmNewUpdate As New FrmNewUpdate
                FmNewUpdate.LblCurrentVersion.Text = CurVersion
                FmNewUpdate.LblNewVersion.Text = NewVersion
                FmNewUpdate.ShowDialog()
            Else
                MsgBox("There is no update available", vbOKOnly + vbInformation, "No Update")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ChkFormPermission(formName As String)
        Try
            ' Check if the form is already open
            Dim openForm As Form = Application.OpenForms.OfType(Of Form)().FirstOrDefault(Function(f) f.Name = formName)

            If openForm IsNot Nothing Then
                ' If the form is already open, activate it
                openForm.Activate()
            Else
                ' If the form is not open, create a new instance dynamically
                Dim formType As Type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(Function(t) t.Name = formName)

                If formType IsNot Nothing AndAlso GetType(Form).IsAssignableFrom(formType) Then
                    Dim newForm As Form = CType(Activator.CreateInstance(formType), Form)
                    newForm.MdiParent = FrmMain ' Set the MDI parent (if applicable)
                    newForm.Show()
                Else
                    Throw New Exception($"Form '{formName}' not found or is not a valid form.")
                End If
            End If
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try


        'Try
        '    If AdminMode = True Then
        '        If Application.OpenForms.OfType(Of FrmCostsList).Any = True Then
        '            FmCostsList.Activate()
        '        Else
        '            FmCostsList = New FrmCostsList
        '            FmCostsList.MdiParent = FrmMain
        '            FmCostsList.Show()
        '        End If
        '    Else
        '        If isAllowed(10) = True Then
        '            If Application.OpenForms.OfType(Of FrmCostsList).Any = True Then
        '                FmCostsList.Activate()
        '            Else
        '                FmCostsList = New FrmCostsList
        '                FmCostsList.MdiParent = FrmMain
        '                FmCostsList.Show()
        '            End If
        '        Else
        '            OkMsgAlert("لا توجد صلاحية", "ليس لديك اذن لهذه العملية ")
        '        End If
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub


End Module
