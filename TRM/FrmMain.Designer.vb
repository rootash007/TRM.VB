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
        Me.קובץToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.החלפתמשתמשToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.יציאהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.הפקתמסמכיםToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הסכםמכירהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הכסםקנייהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הסכםריקToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ספירתמלאיToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרותToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרתמספרביומןToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרתפרטיביתהעסקToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הגדרתשדותחובהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.הפעלתמצבמנהלToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.טבלאותToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSActions = New System.Windows.Forms.ToolStripMenuItem()
        Me.מערכתToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.גיבוישחזורToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.עדכוןתוכנהToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.אודותToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.חלונותToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMCloseAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SSMain = New System.Windows.Forms.StatusStrip()
        Me.SSAdminStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSAdmin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSMainProgBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBtnUsers = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnMaterial = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnBackUp = New System.Windows.Forms.ToolStripButton()
        Me.TSPActions = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnProducts = New System.Windows.Forms.ToolStripButton()
        Me.MenuMain.SuspendLayout()
        Me.SSMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMain
        '
        Me.MenuMain.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.קובץToolStripMenuItem, Me.TSMTickets, Me.הפקתמסמכיםToolStripMenuItem, Me.הגדרותToolStripMenuItem, Me.טבלאותToolStripMenuItem, Me.מערכתToolStripMenuItem, Me.חלונותToolStripMenuItem})
        Me.MenuMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuMain.MdiWindowListItem = Me.חלונותToolStripMenuItem
        Me.MenuMain.Name = "MenuMain"
        Me.MenuMain.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuMain.Size = New System.Drawing.Size(1349, 24)
        Me.MenuMain.TabIndex = 0
        Me.MenuMain.Text = "MenuStrip1"
        '
        'קובץToolStripMenuItem
        '
        Me.קובץToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.החלפתמשתמשToolStripMenuItem, Me.יציאהToolStripMenuItem})
        Me.קובץToolStripMenuItem.Name = "קובץToolStripMenuItem"
        Me.קובץToolStripMenuItem.Size = New System.Drawing.Size(36, 22)
        Me.קובץToolStripMenuItem.Text = "ملف"
        '
        'החלפתמשתמשToolStripMenuItem
        '
        Me.החלפתמשתמשToolStripMenuItem.Name = "החלפתמשתמשToolStripMenuItem"
        Me.החלפתמשתמשToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.החלפתמשתמשToolStripMenuItem.Text = "تبديل المستخدم"
        '
        'יציאהToolStripMenuItem
        '
        Me.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem"
        Me.יציאהToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.יציאהToolStripMenuItem.Text = "خروج"
        '
        'TSMTickets
        '
        Me.TSMTickets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMUsers})
        Me.TSMTickets.Name = "TSMTickets"
        Me.TSMTickets.Size = New System.Drawing.Size(57, 22)
        Me.TSMTickets.Text = "مستندات"
        '
        'TSMUsers
        '
        Me.TSMUsers.Name = "TSMUsers"
        Me.TSMUsers.Size = New System.Drawing.Size(126, 22)
        Me.TSMUsers.Text = "المستخدمين"
        '
        'הפקתמסמכיםToolStripMenuItem
        '
        Me.הפקתמסמכיםToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.הסכםמכירהToolStripMenuItem, Me.הכסםקנייהToolStripMenuItem, Me.הסכםריקToolStripMenuItem, Me.ספירתמלאיToolStripMenuItem})
        Me.הפקתמסמכיםToolStripMenuItem.Name = "הפקתמסמכיםToolStripMenuItem"
        Me.הפקתמסמכיםToolStripMenuItem.Size = New System.Drawing.Size(83, 22)
        Me.הפקתמסמכיםToolStripMenuItem.Text = "انتاج مستندات"
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
        Me.הגדרותToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.הגדרתמספרביומןToolStripMenuItem, Me.הגדרתפרטיביתהעסקToolStripMenuItem, Me.הגדרתשדותחובהToolStripMenuItem, Me.הפעלתמצבמנהלToolStripMenuItem})
        Me.הגדרותToolStripMenuItem.Name = "הגדרותToolStripMenuItem"
        Me.הגדרותToolStripMenuItem.Size = New System.Drawing.Size(50, 22)
        Me.הגדרותToolStripMenuItem.Text = "خيارات"
        '
        'הגדרתמספרביומןToolStripMenuItem
        '
        Me.הגדרתמספרביומןToolStripMenuItem.Name = "הגדרתמספרביומןToolStripMenuItem"
        Me.הגדרתמספרביומןToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.הגדרתמספרביומןToolStripMenuItem.Text = "הגדרת מספר ביומן"
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
        'טבלאותToolStripMenuItem
        '
        Me.טבלאותToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMUnits, Me.TSUsers, Me.TSActions})
        Me.טבלאותToolStripMenuItem.Name = "טבלאותToolStripMenuItem"
        Me.טבלאותToolStripMenuItem.Size = New System.Drawing.Size(47, 22)
        Me.טבלאותToolStripMenuItem.Text = "جداول"
        '
        'TSMUnits
        '
        Me.TSMUnits.Name = "TSMUnits"
        Me.TSMUnits.Size = New System.Drawing.Size(134, 22)
        Me.TSMUnits.Text = "وحدات القياس"
        '
        'TSUsers
        '
        Me.TSUsers.Name = "TSUsers"
        Me.TSUsers.Size = New System.Drawing.Size(134, 22)
        Me.TSUsers.Text = "مستخدمين"
        '
        'TSActions
        '
        Me.TSActions.Name = "TSActions"
        Me.TSActions.Size = New System.Drawing.Size(134, 22)
        Me.TSActions.Text = "العمليات"
        '
        'מערכתToolStripMenuItem
        '
        Me.מערכתToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.גיבוישחזורToolStripMenuItem1, Me.עדכוןתוכנהToolStripMenuItem, Me.אודותToolStripMenuItem1})
        Me.מערכתToolStripMenuItem.Name = "מערכתToolStripMenuItem"
        Me.מערכתToolStripMenuItem.Size = New System.Drawing.Size(45, 22)
        Me.מערכתToolStripMenuItem.Text = "النظام"
        '
        'גיבוישחזורToolStripMenuItem1
        '
        Me.גיבוישחזורToolStripMenuItem1.Name = "גיבוישחזורToolStripMenuItem1"
        Me.גיבוישחזורToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.גיבוישחזורToolStripMenuItem1.Text = "النسخ الاحتياطي"
        '
        'עדכוןתוכנהToolStripMenuItem
        '
        Me.עדכוןתוכנהToolStripMenuItem.Name = "עדכוןתוכנהToolStripMenuItem"
        Me.עדכוןתוכנהToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.עדכוןתוכנהToolStripMenuItem.Text = "تحديث البرنامج"
        '
        'אודותToolStripMenuItem1
        '
        Me.אודותToolStripMenuItem1.Name = "אודותToolStripMenuItem1"
        Me.אודותToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.אודותToolStripMenuItem1.Text = "حول"
        '
        'חלונותToolStripMenuItem
        '
        Me.חלונותToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMCloseAll, Me.ToolStripSeparator1})
        Me.חלונותToolStripMenuItem.Name = "חלונותToolStripMenuItem"
        Me.חלונותToolStripMenuItem.Size = New System.Drawing.Size(43, 22)
        Me.חלונותToolStripMenuItem.Text = "نوافذ"
        '
        'TSMCloseAll
        '
        Me.TSMCloseAll.Font = New System.Drawing.Font("David", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMCloseAll.Image = Global.TRM.My.Resources.Resources.Cancel48
        Me.TSMCloseAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TSMCloseAll.Name = "TSMCloseAll"
        Me.TSMCloseAll.Size = New System.Drawing.Size(130, 26)
        Me.TSMCloseAll.Text = "اغلاق جميع النوافذ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'SSMain
        '
        Me.SSMain.BackColor = System.Drawing.Color.White
        Me.SSMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SSMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSAdminStatus, Me.SSAdmin, Me.TSMainProgBar})
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
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBtnUsers, Me.TSBtnMaterial, Me.TSBtnBackUp, Me.TSPActions, Me.TSBtnProducts})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1349, 55)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBtnUsers
        '
        Me.TSBtnUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBtnUsers.Image = CType(resources.GetObject("TSBtnUsers.Image"), System.Drawing.Image)
        Me.TSBtnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBtnUsers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnUsers.Name = "TSBtnUsers"
        Me.TSBtnUsers.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSBtnUsers.Size = New System.Drawing.Size(67, 52)
        Me.TSBtnUsers.Text = "משתמשים"
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
        Me.TSBtnMaterial.Text = "מוצרים"
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
        'TSPActions
        '
        Me.TSPActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSPActions.Image = CType(resources.GetObject("TSPActions.Image"), System.Drawing.Image)
        Me.TSPActions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSPActions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSPActions.Name = "TSPActions"
        Me.TSPActions.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TSPActions.Size = New System.Drawing.Size(67, 52)
        Me.TSPActions.Text = "רשימת פעולות"
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
        Me.TSBtnProducts.Text = "ToolStripButton1"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
    Friend WithEvents קובץToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMTickets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents יציאהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הגדרותToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents מערכתToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הגדרתפרטיביתהעסקToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הגדרתמספרביומןToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הגדרתשדותחובהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents טבלאותToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMUnits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents גיבוישחזורToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents אודותToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הפקתמסמכיםToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הסכםמכירהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הכסםקנייהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents הסכםריקToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents עדכוןתוכנהToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSMain As System.Windows.Forms.StatusStrip
    Friend WithEvents SSAdmin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SSAdminStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents החלפתמשתמשToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ספירתמלאיToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents חלונותToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMCloseAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBtnMaterial As ToolStripButton
    Friend WithEvents TSBtnUsers As ToolStripButton
    Friend WithEvents TSBtnBackUp As ToolStripButton
    Friend WithEvents TSBtnProducts As ToolStripButton
    Friend WithEvents TSMainProgBar As ToolStripProgressBar
    Friend WithEvents TSPActions As ToolStripButton
    Friend WithEvents TSActions As ToolStripMenuItem
    Friend WithEvents הפעלתמצבמנהלToolStripMenuItem As ToolStripMenuItem
End Class
