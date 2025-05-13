<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuMain = New System.Windows.Forms.MenuStrip()
        Me.TSMFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSILang = New System.Windows.Forms.ToolStripMenuItem()
        Me.עבריתToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.عربيToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSILogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIAudits = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSICostsList = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIActions = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIMaterials = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSISuppliers = New System.Windows.Forms.ToolStripMenuItem()
        Me.הפקתמסמכיםToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הסכםמכירהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הכסםקנייהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הסכםריקToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ספירתמלאיToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרותToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרתפרטיביתהעסקToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרתשדותחובהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הפעלתמצבמנהלToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMTables = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSTUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSTUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSTActions = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSTCurrency = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiBackUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiUpgrade = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiPermissions = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiWindowsUnLock = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiCompanyOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiUpgradeCheck = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSiCloseAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SSMain = New System.Windows.Forms.StatusStrip()
        Me.SSAdminStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSAdmin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSMainProgBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.TSSCurentVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBtnUsers = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnMaterial = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnActions = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnProducts = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnCost = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnBackUp = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnAlerts = New System.Windows.Forms.ToolStripButton()
        Me.ישאדToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMain.SuspendLayout()
        Me.SSMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMain
        '
        Me.MenuMain.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMFile, Me.TSMTickets, Me.הפקתמסמכיםToolStripMenuItem, Me.הגדרותToolStripMenuItem, Me.TSMTables, Me.TSMSystem, Me.TSMWindows})
        Me.MenuMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuMain.MdiWindowListItem = Me.TSMWindows
        Me.MenuMain.Name = "MenuMain"
        Me.MenuMain.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuMain.Size = New System.Drawing.Size(1349, 24)
        Me.MenuMain.TabIndex = 0
        Me.MenuMain.Text = "MenuStrip1"
        '
        'TSMFile
        '
        Me.TSMFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSILang, Me.TSILogOut, Me.TSIExit})
        Me.TSMFile.Name = "TSMFile"
        Me.TSMFile.Size = New System.Drawing.Size(36, 22)
        Me.TSMFile.Text = "ملف"
        '
        'TSILang
        '
        Me.TSILang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.עבריתToolStripMenuItem, Me.عربيToolStripMenuItem})
        Me.TSILang.Image = CType(resources.GetObject("TSILang.Image"), System.Drawing.Image)
        Me.TSILang.Name = "TSILang"
        Me.TSILang.Size = New System.Drawing.Size(146, 26)
        Me.TSILang.Text = "اللغه"
        '
        'עבריתToolStripMenuItem
        '
        Me.עבריתToolStripMenuItem.Image = CType(resources.GetObject("עבריתToolStripMenuItem.Image"), System.Drawing.Image)
        Me.עבריתToolStripMenuItem.Name = "עבריתToolStripMenuItem"
        Me.עבריתToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.עבריתToolStripMenuItem.Text = "עברית"
        '
        'عربيToolStripMenuItem
        '
        Me.عربيToolStripMenuItem.Image = CType(resources.GetObject("عربيToolStripMenuItem.Image"), System.Drawing.Image)
        Me.عربيToolStripMenuItem.Name = "عربيToolStripMenuItem"
        Me.عربيToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.عربيToolStripMenuItem.Text = "عربي"
        '
        'TSILogOut
        '
        Me.TSILogOut.Image = CType(resources.GetObject("TSILogOut.Image"), System.Drawing.Image)
        Me.TSILogOut.Name = "TSILogOut"
        Me.TSILogOut.Size = New System.Drawing.Size(146, 26)
        Me.TSILogOut.Text = "تبديل المستخدم"
        '
        'TSIExit
        '
        Me.TSIExit.Image = CType(resources.GetObject("TSIExit.Image"), System.Drawing.Image)
        Me.TSIExit.Name = "TSIExit"
        Me.TSIExit.Size = New System.Drawing.Size(146, 26)
        Me.TSIExit.Text = "خروج"
        '
        'TSMTickets
        '
        Me.TSMTickets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIUsers, Me.TSIAudits, Me.TSICostsList, Me.TSIActions, Me.TSIMaterials, Me.TSISuppliers})
        Me.TSMTickets.Name = "TSMTickets"
        Me.TSMTickets.Size = New System.Drawing.Size(57, 22)
        Me.TSMTickets.Text = "مستندات"
        '
        'TSIUsers
        '
        Me.TSIUsers.Name = "TSIUsers"
        Me.TSIUsers.Size = New System.Drawing.Size(142, 22)
        Me.TSIUsers.Text = "المستخدمين"
        '
        'TSIAudits
        '
        Me.TSIAudits.Name = "TSIAudits"
        Me.TSIAudits.Size = New System.Drawing.Size(142, 22)
        Me.TSIAudits.Text = "التحققات"
        '
        'TSICostsList
        '
        Me.TSICostsList.Name = "TSICostsList"
        Me.TSICostsList.Size = New System.Drawing.Size(142, 22)
        Me.TSICostsList.Text = "حساب التكاليف"
        '
        'TSIActions
        '
        Me.TSIActions.Name = "TSIActions"
        Me.TSIActions.Size = New System.Drawing.Size(142, 22)
        Me.TSIActions.Text = "العمليات"
        '
        'TSIMaterials
        '
        Me.TSIMaterials.Name = "TSIMaterials"
        Me.TSIMaterials.Size = New System.Drawing.Size(142, 22)
        Me.TSIMaterials.Text = "المواد"
        '
        'TSISuppliers
        '
        Me.TSISuppliers.Name = "TSISuppliers"
        Me.TSISuppliers.Size = New System.Drawing.Size(142, 22)
        Me.TSISuppliers.Text = "الموردين"
        '
        'הפקתמסמכיםToolStripMenuItem
        '
        Me.הפקתמסמכיםToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.הסכםמכירהToolStripMenuItem, Me.הכסםקנייהToolStripMenuItem, Me.הסכםריקToolStripMenuItem, Me.ספירתמלאיToolStripMenuItem})
        Me.הפקתמסמכיםToolStripMenuItem.Name = "הפקתמסמכיםToolStripMenuItem"
        Me.הפקתמסמכיםToolStripMenuItem.Size = New System.Drawing.Size(83, 22)
        Me.הפקתמסמכיםToolStripMenuItem.Text = "انتاج مستندات"
        Me.הפקתמסמכיםToolStripMenuItem.Visible = False
        '
        'הסכםמכירהToolStripMenuItem
        '
        Me.הסכםמכירהToolStripMenuItem.Name = "הסכםמכירהToolStripMenuItem"
        Me.הסכםמכירהToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.הסכםמכירהToolStripMenuItem.Text = "הסכם מכירה"
        '
        'הכסםקנייהToolStripMenuItem
        '
        Me.הכסםקנייהToolStripMenuItem.Name = "הכסםקנייהToolStripMenuItem"
        Me.הכסםקנייהToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.הכסםקנייהToolStripMenuItem.Text = "הכסם קנייה"
        '
        'הסכםריקToolStripMenuItem
        '
        Me.הסכםריקToolStripMenuItem.Name = "הסכםריקToolStripMenuItem"
        Me.הסכםריקToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.הסכםריקToolStripMenuItem.Text = "הסכם ריק"
        '
        'ספירתמלאיToolStripMenuItem
        '
        Me.ספירתמלאיToolStripMenuItem.Name = "ספירתמלאיToolStripMenuItem"
        Me.ספירתמלאיToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ספירתמלאיToolStripMenuItem.Text = "ספירת מלאי"
        '
        'הגדרותToolStripMenuItem
        '
        Me.הגדרותToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.הגדרתפרטיביתהעסקToolStripMenuItem, Me.הגדרתשדותחובהToolStripMenuItem, Me.הפעלתמצבמנהלToolStripMenuItem})
        Me.הגדרותToolStripMenuItem.Name = "הגדרותToolStripMenuItem"
        Me.הגדרותToolStripMenuItem.Size = New System.Drawing.Size(50, 22)
        Me.הגדרותToolStripMenuItem.Text = "خيارات"
        Me.הגדרותToolStripMenuItem.Visible = False
        '
        'הגדרתפרטיביתהעסקToolStripMenuItem
        '
        Me.הגדרתפרטיביתהעסקToolStripMenuItem.Name = "הגדרתפרטיביתהעסקToolStripMenuItem"
        Me.הגדרתפרטיביתהעסקToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.הגדרתפרטיביתהעסקToolStripMenuItem.Text = "הגדרת פרטי בית העסק"
        '
        'הגדרתשדותחובהToolStripMenuItem
        '
        Me.הגדרתשדותחובהToolStripMenuItem.Name = "הגדרתשדותחובהToolStripMenuItem"
        Me.הגדרתשדותחובהToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.הגדרתשדותחובהToolStripMenuItem.Text = "הגדרת שדות חובה"
        '
        'הפעלתמצבמנהלToolStripMenuItem
        '
        Me.הפעלתמצבמנהלToolStripMenuItem.Name = "הפעלתמצבמנהלToolStripMenuItem"
        Me.הפעלתמצבמנהלToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.הפעלתמצבמנהלToolStripMenuItem.Text = "הפעלת מצב מנהל"
        '
        'TSMTables
        '
        Me.TSMTables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSTUnits, Me.TSTUsers, Me.TSTActions, Me.TSTCurrency})
        Me.TSMTables.Name = "TSMTables"
        Me.TSMTables.Size = New System.Drawing.Size(47, 22)
        Me.TSMTables.Text = "جداول"
        '
        'TSTUnits
        '
        Me.TSTUnits.Name = "TSTUnits"
        Me.TSTUnits.Size = New System.Drawing.Size(134, 22)
        Me.TSTUnits.Text = "وحدات القياس"
        '
        'TSTUsers
        '
        Me.TSTUsers.Name = "TSTUsers"
        Me.TSTUsers.Size = New System.Drawing.Size(134, 22)
        Me.TSTUsers.Text = "مستخدمين"
        '
        'TSTActions
        '
        Me.TSTActions.Name = "TSTActions"
        Me.TSTActions.Size = New System.Drawing.Size(134, 22)
        Me.TSTActions.Text = "العمليات"
        '
        'TSTCurrency
        '
        Me.TSTCurrency.Name = "TSTCurrency"
        Me.TSTCurrency.Size = New System.Drawing.Size(134, 22)
        Me.TSTCurrency.Text = "العملات"
        '
        'TSMSystem
        '
        Me.TSMSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSiBackUp, Me.TSiUpgrade, Me.TSiPermissions, Me.TSiWindowsUnLock, Me.TSiCompanyOptions, Me.TSiAbout, Me.TSiUpgradeCheck, Me.ישאדToolStripMenuItem})
        Me.TSMSystem.Name = "TSMSystem"
        Me.TSMSystem.Size = New System.Drawing.Size(45, 22)
        Me.TSMSystem.Text = "النظام"
        '
        'TSiBackUp
        '
        Me.TSiBackUp.Name = "TSiBackUp"
        Me.TSiBackUp.Size = New System.Drawing.Size(222, 22)
        Me.TSiBackUp.Text = "النسخ الاحتياطي"
        '
        'TSiUpgrade
        '
        Me.TSiUpgrade.Name = "TSiUpgrade"
        Me.TSiUpgrade.Size = New System.Drawing.Size(222, 22)
        Me.TSiUpgrade.Text = "تحديث البرنامج"
        '
        'TSiPermissions
        '
        Me.TSiPermissions.Name = "TSiPermissions"
        Me.TSiPermissions.Size = New System.Drawing.Size(222, 22)
        Me.TSiPermissions.Text = "Permissions"
        '
        'TSiWindowsUnLock
        '
        Me.TSiWindowsUnLock.Name = "TSiWindowsUnLock"
        Me.TSiWindowsUnLock.Size = New System.Drawing.Size(222, 22)
        Me.TSiWindowsUnLock.Text = "تحرير نوافذ المواد القيد الاستخدام"
        '
        'TSiCompanyOptions
        '
        Me.TSiCompanyOptions.Name = "TSiCompanyOptions"
        Me.TSiCompanyOptions.Size = New System.Drawing.Size(222, 22)
        Me.TSiCompanyOptions.Text = "خيارات الشركة"
        '
        'TSiAbout
        '
        Me.TSiAbout.Name = "TSiAbout"
        Me.TSiAbout.Size = New System.Drawing.Size(222, 22)
        Me.TSiAbout.Text = "حول"
        '
        'TSiUpgradeCheck
        '
        Me.TSiUpgradeCheck.Name = "TSiUpgradeCheck"
        Me.TSiUpgradeCheck.Size = New System.Drawing.Size(222, 22)
        Me.TSiUpgradeCheck.Text = "فحص الاصدار الاخير"
        '
        'TSMWindows
        '
        Me.TSMWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSiCloseAll, Me.ToolStripSeparator1})
        Me.TSMWindows.Name = "TSMWindows"
        Me.TSMWindows.Size = New System.Drawing.Size(43, 22)
        Me.TSMWindows.Text = "نوافذ"
        '
        'TSiCloseAll
        '
        Me.TSiCloseAll.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSiCloseAll.Image = Global.TRM.My.Resources.Resources.Cancel48
        Me.TSiCloseAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSiCloseAll.Name = "TSiCloseAll"
        Me.TSiCloseAll.Size = New System.Drawing.Size(162, 26)
        Me.TSiCloseAll.Text = "اغلاق جميع النوافذ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'SSMain
        '
        Me.SSMain.BackColor = System.Drawing.Color.White
        Me.SSMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SSMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSAdminStatus, Me.SSAdmin, Me.TSMainProgBar, Me.TSSCurentVersion, Me.TSSLblVersion})
        Me.SSMain.Location = New System.Drawing.Point(0, 605)
        Me.SSMain.Name = "SSMain"
        Me.SSMain.Padding = New System.Windows.Forms.Padding(12, 0, 1, 0)
        Me.SSMain.Size = New System.Drawing.Size(1349, 24)
        Me.SSMain.TabIndex = 14
        Me.SSMain.Text = "StatusStrip1"
        '
        'SSAdminStatus
        '
        Me.SSAdminStatus.Font = New System.Drawing.Font("David", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.SSAdminStatus.Name = "SSAdminStatus"
        Me.SSAdminStatus.Size = New System.Drawing.Size(0, 19)
        '
        'SSAdmin
        '
        Me.SSAdmin.Font = New System.Drawing.Font("David", 9.0!)
        Me.SSAdmin.ForeColor = System.Drawing.Color.Black
        Me.SSAdmin.Name = "SSAdmin"
        Me.SSAdmin.Size = New System.Drawing.Size(58, 19)
        Me.SSAdmin.Text = "מצב מנהל :"
        '
        'TSMainProgBar
        '
        Me.TSMainProgBar.Name = "TSMainProgBar"
        Me.TSMainProgBar.Size = New System.Drawing.Size(100, 18)
        '
        'TSSCurentVersion
        '
        Me.TSSCurentVersion.Name = "TSSCurentVersion"
        Me.TSSCurentVersion.Size = New System.Drawing.Size(117, 19)
        Me.TSSCurentVersion.Text = "          النسخه الحاليه :  "
        '
        'TSSLblVersion
        '
        Me.TSSLblVersion.Name = "TSSLblVersion"
        Me.TSSLblVersion.Size = New System.Drawing.Size(88, 19)
        Me.TSSLblVersion.Text = "Current version"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBtnUsers, Me.TSBtnMaterial, Me.TSBtnActions, Me.TSBtnProducts, Me.TSBtnCost, Me.TSBtnBackUp, Me.TSBtnAlerts})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1349, 55)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBtnUsers
        '
        Me.TSBtnUsers.AccessibleName = ""
        Me.TSBtnUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnUsers.Image = CType(resources.GetObject("TSBtnUsers.Image"), System.Drawing.Image)
        Me.TSBtnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnUsers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnUsers.Name = "TSBtnUsers"
        Me.TSBtnUsers.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnUsers.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnUsers.Text = "المستخدمين"
        '
        'TSBtnMaterial
        '
        Me.TSBtnMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnMaterial.Image = CType(resources.GetObject("TSBtnMaterial.Image"), System.Drawing.Image)
        Me.TSBtnMaterial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnMaterial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnMaterial.Name = "TSBtnMaterial"
        Me.TSBtnMaterial.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnMaterial.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnMaterial.Tag = ""
        Me.TSBtnMaterial.Text = "المواد"
        '
        'TSBtnActions
        '
        Me.TSBtnActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnActions.Image = CType(resources.GetObject("TSBtnActions.Image"), System.Drawing.Image)
        Me.TSBtnActions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnActions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnActions.Name = "TSBtnActions"
        Me.TSBtnActions.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnActions.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnActions.Text = "العمليات"
        '
        'TSBtnProducts
        '
        Me.TSBtnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnProducts.Image = CType(resources.GetObject("TSBtnProducts.Image"), System.Drawing.Image)
        Me.TSBtnProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnProducts.Name = "TSBtnProducts"
        Me.TSBtnProducts.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnProducts.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnProducts.Text = "المنتجات"
        Me.TSBtnProducts.Visible = False
        '
        'TSBtnCost
        '
        Me.TSBtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnCost.Image = CType(resources.GetObject("TSBtnCost.Image"), System.Drawing.Image)
        Me.TSBtnCost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnCost.Name = "TSBtnCost"
        Me.TSBtnCost.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnCost.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnCost.Text = "حساب التكاليف"
        '
        'TSBtnBackUp
        '
        Me.TSBtnBackUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnBackUp.Image = CType(resources.GetObject("TSBtnBackUp.Image"), System.Drawing.Image)
        Me.TSBtnBackUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnBackUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnBackUp.Name = "TSBtnBackUp"
        Me.TSBtnBackUp.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnBackUp.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnBackUp.Text = "גיבוי/שחזור"
        '
        'TSBtnAlerts
        '
        Me.TSBtnAlerts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnAlerts.Image = CType(resources.GetObject("TSBtnAlerts.Image"), System.Drawing.Image)
        Me.TSBtnAlerts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnAlerts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnAlerts.Name = "TSBtnAlerts"
        Me.TSBtnAlerts.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnAlerts.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnAlerts.Text = "التنبيهات"
        Me.TSBtnAlerts.Visible = False
        '
        'ישאדToolStripMenuItem
        '
        Me.ישאדToolStripMenuItem.Name = "ישאדToolStripMenuItem"
        Me.ישאדToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ישאדToolStripMenuItem.Text = "'ישאד"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1349, 629)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuMain)
        Me.Controls.Add(Me.SSMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("David", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuMain
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الصفحة الرئيسية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuMain.ResumeLayout(False)
        Me.MenuMain.PerformLayout()
        Me.SSMain.ResumeLayout(False)
        Me.SSMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents TSMFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMTickets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSIExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הגדרותToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הגדרתפרטיביתהעסקToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הגדרתשדותחובהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMTables As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSTUnits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSiBackUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הפקתמסמכיםToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הסכםמכירהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הכסםקנייהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הסכםריקToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSiUpgrade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSMain As System.Windows.Forms.StatusStrip
    Friend WithEvents SSAdmin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SSAdminStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSILogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSTUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ספירתמלאיToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSIUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMWindows As ToolStripMenuItem
    Friend WithEvents TSiCloseAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBtnMaterial As ToolStripButton
    Friend WithEvents TSBtnUsers As ToolStripButton
    Friend WithEvents TSBtnBackUp As ToolStripButton
    Friend WithEvents TSBtnProducts As ToolStripButton
    Friend WithEvents TSMainProgBar As ToolStripProgressBar
    Friend WithEvents TSBtnActions As ToolStripButton
    Friend WithEvents TSTActions As ToolStripMenuItem
    Friend WithEvents הפעלתמצבמנהלToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSiPermissions As ToolStripMenuItem
    Friend WithEvents TSSLblVersion As ToolStripStatusLabel
    Friend WithEvents TSiWindowsUnLock As ToolStripMenuItem
    Friend WithEvents TSBtnAlerts As ToolStripButton
    Friend WithEvents TSIAudits As ToolStripMenuItem
    Friend WithEvents TSICostsList As ToolStripMenuItem
    Friend WithEvents TSBtnCost As ToolStripButton
    Friend WithEvents TSIActions As ToolStripMenuItem
    Friend WithEvents TSIMaterials As ToolStripMenuItem
    Friend WithEvents TSiCompanyOptions As ToolStripMenuItem
    Friend WithEvents TSISuppliers As ToolStripMenuItem
    Friend WithEvents TSSCurentVersion As ToolStripStatusLabel
    Friend WithEvents TSiUpgradeCheck As ToolStripMenuItem
    Friend WithEvents TSTCurrency As ToolStripMenuItem
    Friend WithEvents TSILang As ToolStripMenuItem
    Friend WithEvents עבריתToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents عربيToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ישאדToolStripMenuItem As ToolStripMenuItem
End Class
