Module Language_Controller

    Public Sub FrmMainLang(Lang As String)
        If Lang = "AR" Then
            With FrmMain
                .TSSCurentVersion.Text = "          النسخه الحاليه :  "

                .Text = "الصفحة الرئيسيه" & " - TRM - " & ActiveUser
                .TSMFile.Text = "ملف"
                .TSILang.Text = "اللغه"
                .TSILogOut.Text = "تبديل المستخدم"
                .TSIExit.Text = "خروج"

                .TSMTickets.Text = "المستندات"
                .TSIUsers.Text = "المستخدمين"
                .TSIAudits.Text = "التحققات"
                .TSICostsList.Text = "حساب التكاليف"
                .TSIActions.Text = "العمليات"
                .TSIMaterials.Text = "المواد"
                .TSISuppliers.Text = "الموردين"

                .TSMTables.Text = "الجداول"
                .TSTUnits.Text = "وحدات القياس"
                .TSTUsers.Text = "مستخدمين"
                .TSTActions.Text = "العمليات"
                .TSTCurrency.Text = "العملات"

                .TSMSystem.Text = "النظام"
                .TSiBackUp.Text = "النسخ الاحتياطي"
                .TSiUpgrade.Text = "تحديث البرنامج"
                .TSiPermissions.Text = "الصلاحبات"
                .TSiWindowsUnLock.Text = "تحرير نوافذ المواد القيد الاستخدام"
                .TSiCompanyOptions.Text = "خيارات الشركة"
                .TSiAbout.Text = "حول"
                .TSiUpgradeCheck.Text = "فحص الاصدار الاخير"

                .TSMWindows.Text = "نوافذ"
                .TSiCloseAll.Text = "اغلاق جميع النوافذ"

                .TSBtnUsers.Text = "المستخدمين"
                .TSBtnMaterial.Text = "المواد"
                .TSBtnActions.Text = "العمليات"
                .TSBtnProducts.Text = "المنتجات"
                .TSBtnCost.Text = "حساب التكاليف"
                .TSBtnBackUp.Text = "النسخ الاحتياطي"
                .TSBtnAlerts.Text = "التنبيهات"

                If AdminMode = True Then
                    .SSAdminStatus.Text = "مفعل"
                    .SSAdminStatus.ForeColor = Color.Green
                Else
                    .SSAdminStatus.Text = "غير مفعل"
                    .SSAdminStatus.ForeColor = Color.Red
                End If
            End With
        ElseIf Lang = "HE" Then
            With FrmMain
                .TSSCurentVersion.Text = "          גרסה נוכחית :  "

                .Text = "דף ראשי" & " - TRM - " & ActiveUser
                .TSMFile.Text = "קובץ"
                .TSILang.Text = "שפה"
                .TSILogOut.Text = "החלפת משתמש"
                .TSIExit.Text = "יציאה"

                .TSMTickets.Text = "כרטסות"
                .TSIUsers.Text = "משתמשים"
                .TSIAudits.Text = "מבדקים"
                .TSICostsList.Text = "חישוב עליות"
                .TSIActions.Text = "פעולות"
                .TSIMaterials.Text = "חומרים"
                .TSISuppliers.Text = "ספקים"

                .TSMTables.Text = "טבלאות"
                .TSTUnits.Text = "יחידות"
                .TSTUsers.Text = "משתמשים"
                .TSTActions.Text = "פעולות"
                .TSTCurrency.Text = "מטבעות"

                .TSMSystem.Text = "מערכת"
                .TSiBackUp.Text = "שחזור/גיבוי"
                .TSiUpgrade.Text = "עדכון תוכנה"
                .TSiPermissions.Text = "הרשאות"
                .TSiWindowsUnLock.Text = "שחרור חלונות תפוסים"
                .TSiCompanyOptions.Text = "הגדרות חברה"
                .TSiAbout.Text = "אודות"
                .TSiUpgradeCheck.Text = "בדיקת גרסה אחרונה"

                .TSMWindows.Text = "חלונות"
                .TSiCloseAll.Text = "סגירת כל החלונות"

                .TSBtnUsers.Text = "משתמשים"
                .TSBtnMaterial.Text = "חומרים"
                .TSBtnActions.Text = "פעולות"
                .TSBtnProducts.Text = "מוצרים"
                .TSBtnCost.Text = "חישוב עלויות"
                .TSBtnBackUp.Text = "גיבוי/שחזור"
                .TSBtnAlerts.Text = "התראות"

                If AdminMode = True Then
                    .SSAdminStatus.Text = "פעיל"
                    .SSAdminStatus.ForeColor = Color.Green
                Else
                    .SSAdminStatus.Text = "לא פעיל"
                    .SSAdminStatus.ForeColor = Color.Red
                End If
            End With
        End If
    End Sub

    Public Sub FrmLoginLang(Lang As String)
        If Lang = "AR" Then
            With FrmLogin
                .Text = "الدخول"
                .LblUsername.Text = "اسم المستخدم"
                .LblPassWord.Text = "كلمة المرور"
                .BtnLogin.Text = "الدخول"
                .BtnClose.Text = "اغلاق"
            End With
        ElseIf Lang = "HE" Then
            With FrmLogin
                .Text = "התחברות"
                .LblUsername.Text = "שם משתמש"
                .LblPassWord.Text = "סיסמה"
                .BtnLogin.Text = "התחבר"
                .BtnClose.Text = "סגירה"
            End With
        End If
    End Sub

    Public Sub FrmMaterialsLang(Lang As String)
        If Lang = "AR" Then
            With FmMaterials
                .Text = "المواد"
                .GrpMaterials.Text = "قائمة المواد"
                .TabMaterialsOn.Text = "قائمة المواد المفعلة"
                .TabMaterialsOff.Text = "قائمة المواد الغير مفعلة"
                .TabMaterialsAlarm.Text = "قائمة التنبيهات"
                .LblSearch.Text = "بحث"
                .BtnAddMaterial.Text = "اضافة مادة"
                .BtnUpdateMaterial.Text = "تعديل مادة"
                If FmMaterials.TabMaterials.SelectedIndex = 0 Then
                    FmMaterials.BtnDeleteMaterial.Image = My.Resources.delete48
                    FmMaterials.BtnDeleteMaterial.Text = "حذف"
                Else
                    FmMaterials.BtnDeleteMaterial.Image = My.Resources.revert48
                    FmMaterials.BtnDeleteMaterial.Text = "استرجاع"
                End If
                .BtnImportFromExcel.Text = "استيراد المعلومات"
                .BtnExportToExcel.Text = "تصدير المعلومات"
                .BtnClose.Text = "اغلاق"
            End With
        ElseIf Lang = "HE" Then
            With FmMaterials
                .Text = "חומרים"
                .GrpMaterials.Text = "רשימת חומרים"
                .TabMaterialsOn.Text = "רשימת חומרים פעילים"
                .TabMaterialsOff.Text = "רשימת חומרים לא פעילים"
                .TabMaterialsAlarm.Text = "רשימת התראות"
                .LblSearch.Text = "חיפוש"
                .BtnAddMaterial.Text = "הוספת חומר"
                .BtnUpdateMaterial.Text = "עדכון חומר"
                If FmMaterials.TabMaterials.SelectedIndex = 0 Then
                    FmMaterials.BtnDeleteMaterial.Image = My.Resources.delete48
                    FmMaterials.BtnDeleteMaterial.Text = "מחיקה"
                Else
                    FmMaterials.BtnDeleteMaterial.Image = My.Resources.revert48
                    FmMaterials.BtnDeleteMaterial.Text = "שחזור"
                End If
                .BtnImportFromExcel.Text = "ייבוא נתונים"
                .BtnExportToExcel.Text = "ייצוא נתונים"
                .BtnClose.Text = "סגור"
            End With
        End If
    End Sub

    Public Sub FrmMaterialAddEditLang(Lang As String)
        If Lang = "AR" Then
            With FmMaterialAddEdit
                If isAddMaterial Then
                    .BtnMaterialAE.Text = "اضافة مادة"
                    .Text = "اضافة مادة"
                Else
                    .BtnMaterialAE.Text = "تعديل مادة"
                    .Text = "تعديل مادة"
                End If
                .TabMaterial.Text = "تفاصيل المادة"
                .TabTypes.Text = "انواع المادة"
                .TabPrices.Text = "الاسعار"
                .GrpDetails.Text = "تفاصيل المادة"
                .LblMaterialName.Text = "اسم المادة"
                .LblLocCode.Text = "الرمز المحلي"
                .LblBarcode.Text = "الرمز"
                .LblQuantity.Text = "الكمية"
                .LblMinQuantity.Text = "الكمية الدنيا"
                .LblUnit.Text = "وحدة القياس"
                .LblWeigth.Text = "الوزن"
                .LblBlockCapacity.Text = "سعة المشتاح"
                .LblBlockQuantity.Text = "عدد المشاتيح"
                '.BtnMaterialAE.Text = ""
                .BtnClose.Text = "اغلاق"
                .LblMaterialType.Text = "نوع المادة"
                .LblTypeQuantity.Text = "الكمية"
                .GrpTypes.Text = "انواع المنتج"
                .LblYear.Text = "السنة"
                .LblPrice.Text = "السعر"
                .GrpPrices.Text = "الاسعار"

            End With
        ElseIf Lang = "HE" Then
            With FmMaterialAddEdit
                If isAddMaterial Then
                    .BtnMaterialAE.Text = "הוספת חומר"
                    .Text = "הוספת חומר"
                Else
                    .BtnMaterialAE.Text = "עדכון חומר"
                    .Text = "עדכון חומר"
                End If
                .TabMaterial.Text = "פרטי חומר"
                .TabTypes.Text = "סוגי חומר"
                .TabPrices.Text = "מחירים"
                .GrpDetails.Text = "פרטי חומר"
                .LblMaterialName.Text = "שם חומר"
                .LblMaterialName.Left = 293
                .LblLocCode.Text = "קוד מקומי"
                .LblLocCode.Left = 290
                .LblBarcode.Text = "ברקוד"
                .LblBarcode.Left = 311
                .LblQuantity.Text = "כמות"
                .LblQuantity.Left = 320
                .LblMinQuantity.Text = "כמות מינימום"
                .LblMinQuantity.Left = 270
                .LblUnit.Text = "יחידה"
                .LblUnit.Left = 312
                .LblWeigth.Text = "משקל"
                .LblWeigth.Left = 310
                .LblBlockCapacity.Text = "קיבולת משטח"
                .LblBlockCapacity.Left = 265
                .LblBlockQuantity.Text = "כמות משטחים"
                .LblBlockQuantity.Left = 265

                '.BtnMaterialAE.Text = ""
                .BtnClose.Text = "סגור"
                .LblMaterialType.Text = "סוג חומר"
                .LblTypeQuantity.Text = "כמות"
                .LblTypeQuantity.Left = 322
                .GrpTypes.Text = "סוגי חומר"
                .LblYear.Text = "שנה"
                .LblPrice.Text = "מחיר"
                .GrpPrices.Text = "מחירים"
            End With
        End If
    End Sub

    Public Sub FrmCompanyLang(Lang As String)
        If Lang = "AR" Then
            With FrmCompany
                .Text = "خيارات الشركة"
                .TabValues.Text = "الاساسيات"
                .TabLocker.Text = "القفل"
                .ChkMaterialQuantity.Text = "تعديل كمية المواد"
                .LblTax.Text = "نسبة الضريبة"
                .LblAdminCode.Text = "كلمة مرور المسؤول"
                .BtnCancel.Text = "الغاء"
                .BtnSave.Text = "حفظ"

            End With
        ElseIf Lang = "HE" Then
            With FrmCompany
                .Text = "הגדרות חברה"
                .TabValues.Text = "בסיסי"
                .TabLocker.Text = "נעילות"
                .ChkMaterialQuantity.Text = "עדכון כמות חומר"
                .ChkMaterialQuantity.Left = 330
                .LblTax.Text = "אחוז מע''מ"
                .LblTax.Left = 390
                .LblAdminCode.Text = "קוד מנהל"
                .LblAdminCode.Left = 400
                .BtnCancel.Text = "ביטול"
                .BtnSave.Text = "שמירה"
            End With
        End If
    End Sub

    'Public Sub FrmLang(Lang As String)
    '    If Lang = "AR" Then
    '        With Frm()


    '        End With
    '    ElseIf Lang = "HE" Then
    '        With Frm()

    '        End With
    '    End If
    'End Sub

End Module
