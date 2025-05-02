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
                .BtnDeleteMaterial.Text = "حذف مادة"
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
                .BtnDeleteMaterial.Text = "מחק חומר"
                .BtnImportFromExcel.Text = "ייבוא נתונים"
                .BtnExportToExcel.Text = "ייצוא נתונים"
                .BtnClose.Text = "סגור"
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
