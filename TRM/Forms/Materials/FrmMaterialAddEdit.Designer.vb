<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMaterialAddEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaterialAddEdit))
        Me.LblWeigth = New System.Windows.Forms.Label()
        Me.LblMinQuantity = New System.Windows.Forms.Label()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.NumQuantity = New System.Windows.Forms.NumericUpDown()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.TxtMaterialName = New System.Windows.Forms.TextBox()
        Me.Txtbarcode = New System.Windows.Forms.TextBox()
        Me.GrpDetails = New System.Windows.Forms.GroupBox()
        Me.PBoxQuantityLocker = New System.Windows.Forms.PictureBox()
        Me.CmbUnits = New System.Windows.Forms.ComboBox()
        Me.NumWeigth = New System.Windows.Forms.NumericUpDown()
        Me.NumMinQuantity = New System.Windows.Forms.NumericUpDown()
        Me.LblLocCode = New System.Windows.Forms.Label()
        Me.IsActive = New System.Windows.Forms.PictureBox()
        Me.TxtLocBarcode = New System.Windows.Forms.TextBox()
        Me.LblUnit = New System.Windows.Forms.Label()
        Me.LblMaterialName = New System.Windows.Forms.Label()
        Me.TabMaterialEA = New System.Windows.Forms.TabControl()
        Me.TabMaterial = New System.Windows.Forms.TabPage()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMaterialAE = New System.Windows.Forms.Button()
        Me.TabTypes = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GrpTypes = New System.Windows.Forms.GroupBox()
        Me.DGVMaterialTypes = New System.Windows.Forms.DataGridView()
        Me.TxtTypeName = New System.Windows.Forms.TextBox()
        Me.NumTypeQuantity = New System.Windows.Forms.NumericUpDown()
        Me.LblMaterialType = New System.Windows.Forms.Label()
        Me.LblTypeQuantity = New System.Windows.Forms.Label()
        Me.BtnAddType = New System.Windows.Forms.Button()
        Me.TabPrices = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumYear = New System.Windows.Forms.NumericUpDown()
        Me.GrpPrices = New System.Windows.Forms.GroupBox()
        Me.DGVMaterialPrice = New System.Windows.Forms.DataGridView()
        Me.NumPrice = New System.Windows.Forms.NumericUpDown()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.BtnAddPrice = New System.Windows.Forms.Button()
        Me.NumBlockCapacity = New System.Windows.Forms.NumericUpDown()
        Me.LblBlockCapacity = New System.Windows.Forms.Label()
        Me.NumBlockQuantity = New System.Windows.Forms.NumericUpDown()
        Me.LblBlockQuantity = New System.Windows.Forms.Label()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetails.SuspendLayout()
        CType(Me.PBoxQuantityLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumWeigth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMinQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsActive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMaterialEA.SuspendLayout()
        Me.TabMaterial.SuspendLayout()
        Me.TabTypes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrpTypes.SuspendLayout()
        CType(Me.DGVMaterialTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTypeQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPrices.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPrices.SuspendLayout()
        CType(Me.DGVMaterialPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBlockCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBlockQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblWeigth
        '
        Me.LblWeigth.AutoSize = True
        Me.LblWeigth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeigth.Location = New System.Drawing.Point(310, 233)
        Me.LblWeigth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblWeigth.Name = "LblWeigth"
        Me.LblWeigth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblWeigth.Size = New System.Drawing.Size(37, 18)
        Me.LblWeigth.TabIndex = 39
        Me.LblWeigth.Text = "الوزن"
        Me.LblWeigth.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblMinQuantity
        '
        Me.LblMinQuantity.AutoSize = True
        Me.LblMinQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinQuantity.Location = New System.Drawing.Point(284, 165)
        Me.LblMinQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMinQuantity.Name = "LblMinQuantity"
        Me.LblMinQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMinQuantity.Size = New System.Drawing.Size(63, 18)
        Me.LblMinQuantity.TabIndex = 37
        Me.LblMinQuantity.Text = "الكمية الدنيا"
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(311, 131)
        Me.LblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblQuantity.Size = New System.Drawing.Size(36, 18)
        Me.LblQuantity.TabIndex = 35
        Me.LblQuantity.Text = "الكمية"
        '
        'NumQuantity
        '
        Me.NumQuantity.CausesValidation = False
        Me.NumQuantity.Location = New System.Drawing.Point(83, 129)
        Me.NumQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumQuantity.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumQuantity.Name = "NumQuantity"
        Me.NumQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumQuantity.Size = New System.Drawing.Size(179, 26)
        Me.NumQuantity.TabIndex = 3
        Me.NumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(311, 98)
        Me.LblBarcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBarcode.Size = New System.Drawing.Size(36, 18)
        Me.LblBarcode.TabIndex = 31
        Me.LblBarcode.Text = "الرمز"
        '
        'TxtMaterialName
        '
        Me.TxtMaterialName.Location = New System.Drawing.Point(83, 27)
        Me.TxtMaterialName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMaterialName.Name = "TxtMaterialName"
        Me.TxtMaterialName.Size = New System.Drawing.Size(179, 26)
        Me.TxtMaterialName.TabIndex = 0
        Me.TxtMaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtbarcode
        '
        Me.Txtbarcode.Location = New System.Drawing.Point(83, 95)
        Me.Txtbarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtbarcode.Name = "Txtbarcode"
        Me.Txtbarcode.Size = New System.Drawing.Size(179, 26)
        Me.Txtbarcode.TabIndex = 2
        Me.Txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.NumBlockQuantity)
        Me.GrpDetails.Controls.Add(Me.LblBlockQuantity)
        Me.GrpDetails.Controls.Add(Me.NumBlockCapacity)
        Me.GrpDetails.Controls.Add(Me.LblBlockCapacity)
        Me.GrpDetails.Controls.Add(Me.PBoxQuantityLocker)
        Me.GrpDetails.Controls.Add(Me.CmbUnits)
        Me.GrpDetails.Controls.Add(Me.NumWeigth)
        Me.GrpDetails.Controls.Add(Me.NumMinQuantity)
        Me.GrpDetails.Controls.Add(Me.LblLocCode)
        Me.GrpDetails.Controls.Add(Me.IsActive)
        Me.GrpDetails.Controls.Add(Me.TxtLocBarcode)
        Me.GrpDetails.Controls.Add(Me.LblUnit)
        Me.GrpDetails.Controls.Add(Me.LblWeigth)
        Me.GrpDetails.Controls.Add(Me.LblMinQuantity)
        Me.GrpDetails.Controls.Add(Me.LblQuantity)
        Me.GrpDetails.Controls.Add(Me.NumQuantity)
        Me.GrpDetails.Controls.Add(Me.LblBarcode)
        Me.GrpDetails.Controls.Add(Me.TxtMaterialName)
        Me.GrpDetails.Controls.Add(Me.Txtbarcode)
        Me.GrpDetails.Controls.Add(Me.LblMaterialName)
        Me.GrpDetails.Location = New System.Drawing.Point(7, 7)
        Me.GrpDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpDetails.Size = New System.Drawing.Size(363, 336)
        Me.GrpDetails.TabIndex = 0
        Me.GrpDetails.TabStop = False
        Me.GrpDetails.Text = "تفاصيل المادة"
        '
        'PBoxQuantityLocker
        '
        Me.PBoxQuantityLocker.InitialImage = Nothing
        Me.PBoxQuantityLocker.Location = New System.Drawing.Point(48, 127)
        Me.PBoxQuantityLocker.Name = "PBoxQuantityLocker"
        Me.PBoxQuantityLocker.Size = New System.Drawing.Size(30, 30)
        Me.PBoxQuantityLocker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBoxQuantityLocker.TabIndex = 47
        Me.PBoxQuantityLocker.TabStop = False
        '
        'CmbUnits
        '
        Me.CmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUnits.FormattingEnabled = True
        Me.CmbUnits.Location = New System.Drawing.Point(83, 197)
        Me.CmbUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbUnits.Name = "CmbUnits"
        Me.CmbUnits.Size = New System.Drawing.Size(179, 26)
        Me.CmbUnits.Sorted = True
        Me.CmbUnits.TabIndex = 5
        '
        'NumWeigth
        '
        Me.NumWeigth.DecimalPlaces = 2
        Me.NumWeigth.Location = New System.Drawing.Point(84, 231)
        Me.NumWeigth.Margin = New System.Windows.Forms.Padding(4)
        Me.NumWeigth.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumWeigth.Name = "NumWeigth"
        Me.NumWeigth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumWeigth.Size = New System.Drawing.Size(179, 26)
        Me.NumWeigth.TabIndex = 6
        Me.NumWeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumMinQuantity
        '
        Me.NumMinQuantity.Location = New System.Drawing.Point(83, 163)
        Me.NumMinQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumMinQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumMinQuantity.Name = "NumMinQuantity"
        Me.NumMinQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumMinQuantity.Size = New System.Drawing.Size(179, 26)
        Me.NumMinQuantity.TabIndex = 4
        Me.NumMinQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblLocCode
        '
        Me.LblLocCode.AutoSize = True
        Me.LblLocCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocCode.Location = New System.Drawing.Point(275, 64)
        Me.LblLocCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLocCode.Name = "LblLocCode"
        Me.LblLocCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblLocCode.Size = New System.Drawing.Size(72, 18)
        Me.LblLocCode.TabIndex = 45
        Me.LblLocCode.Text = "الرمز المحلي"
        '
        'IsActive
        '
        Me.IsActive.Image = CType(resources.GetObject("IsActive.Image"), System.Drawing.Image)
        Me.IsActive.Location = New System.Drawing.Point(7, 23)
        Me.IsActive.Margin = New System.Windows.Forms.Padding(4)
        Me.IsActive.Name = "IsActive"
        Me.IsActive.Size = New System.Drawing.Size(60, 30)
        Me.IsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IsActive.TabIndex = 44
        Me.IsActive.TabStop = False
        '
        'TxtLocBarcode
        '
        Me.TxtLocBarcode.Location = New System.Drawing.Point(83, 61)
        Me.TxtLocBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLocBarcode.Name = "TxtLocBarcode"
        Me.TxtLocBarcode.Size = New System.Drawing.Size(179, 26)
        Me.TxtLocBarcode.TabIndex = 1
        Me.TxtLocBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblUnit
        '
        Me.LblUnit.AutoSize = True
        Me.LblUnit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnit.Location = New System.Drawing.Point(279, 200)
        Me.LblUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUnit.Name = "LblUnit"
        Me.LblUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUnit.Size = New System.Drawing.Size(68, 18)
        Me.LblUnit.TabIndex = 41
        Me.LblUnit.Text = "وحدة القياس"
        Me.LblUnit.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblMaterialName
        '
        Me.LblMaterialName.AutoSize = True
        Me.LblMaterialName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialName.Location = New System.Drawing.Point(292, 30)
        Me.LblMaterialName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMaterialName.Name = "LblMaterialName"
        Me.LblMaterialName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMaterialName.Size = New System.Drawing.Size(55, 18)
        Me.LblMaterialName.TabIndex = 0
        Me.LblMaterialName.Text = "اسم المادة"
        '
        'TabMaterialEA
        '
        Me.TabMaterialEA.Controls.Add(Me.TabMaterial)
        Me.TabMaterialEA.Controls.Add(Me.TabTypes)
        Me.TabMaterialEA.Controls.Add(Me.TabPrices)
        Me.TabMaterialEA.Location = New System.Drawing.Point(12, 12)
        Me.TabMaterialEA.Name = "TabMaterialEA"
        Me.TabMaterialEA.RightToLeftLayout = True
        Me.TabMaterialEA.SelectedIndex = 0
        Me.TabMaterialEA.Size = New System.Drawing.Size(393, 441)
        Me.TabMaterialEA.TabIndex = 3
        '
        'TabMaterial
        '
        Me.TabMaterial.Controls.Add(Me.GrpDetails)
        Me.TabMaterial.Controls.Add(Me.BtnClose)
        Me.TabMaterial.Controls.Add(Me.BtnMaterialAE)
        Me.TabMaterial.Location = New System.Drawing.Point(4, 27)
        Me.TabMaterial.Name = "TabMaterial"
        Me.TabMaterial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMaterial.Size = New System.Drawing.Size(385, 410)
        Me.TabMaterial.TabIndex = 0
        Me.TabMaterial.Text = "تفاصيل المادة"
        Me.TabMaterial.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(7, 349)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(144, 56)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnMaterialAE
        '
        Me.BtnMaterialAE.BackColor = System.Drawing.Color.White
        Me.BtnMaterialAE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMaterialAE.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnMaterialAE.Location = New System.Drawing.Point(226, 349)
        Me.BtnMaterialAE.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMaterialAE.Name = "BtnMaterialAE"
        Me.BtnMaterialAE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnMaterialAE.Size = New System.Drawing.Size(144, 56)
        Me.BtnMaterialAE.TabIndex = 1
        Me.BtnMaterialAE.Text = "اضافة مادة"
        Me.BtnMaterialAE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnMaterialAE.UseVisualStyleBackColor = False
        '
        'TabTypes
        '
        Me.TabTypes.Controls.Add(Me.GroupBox2)
        Me.TabTypes.Location = New System.Drawing.Point(4, 27)
        Me.TabTypes.Name = "TabTypes"
        Me.TabTypes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTypes.Size = New System.Drawing.Size(385, 410)
        Me.TabTypes.TabIndex = 1
        Me.TabTypes.Text = "انواع المادة"
        Me.TabTypes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GrpTypes)
        Me.GroupBox2.Controls.Add(Me.TxtTypeName)
        Me.GroupBox2.Controls.Add(Me.NumTypeQuantity)
        Me.GroupBox2.Controls.Add(Me.LblMaterialType)
        Me.GroupBox2.Controls.Add(Me.LblTypeQuantity)
        Me.GroupBox2.Controls.Add(Me.BtnAddType)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 387)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GrpTypes
        '
        Me.GrpTypes.Controls.Add(Me.DGVMaterialTypes)
        Me.GrpTypes.Location = New System.Drawing.Point(6, 93)
        Me.GrpTypes.Name = "GrpTypes"
        Me.GrpTypes.Size = New System.Drawing.Size(361, 288)
        Me.GrpTypes.TabIndex = 65
        Me.GrpTypes.TabStop = False
        Me.GrpTypes.Text = "انواع المنتج"
        '
        'DGVMaterialTypes
        '
        Me.DGVMaterialTypes.AllowUserToAddRows = False
        Me.DGVMaterialTypes.AllowUserToDeleteRows = False
        Me.DGVMaterialTypes.AllowUserToResizeColumns = False
        Me.DGVMaterialTypes.AllowUserToResizeRows = False
        Me.DGVMaterialTypes.BackgroundColor = System.Drawing.Color.White
        Me.DGVMaterialTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaterialTypes.Location = New System.Drawing.Point(8, 23)
        Me.DGVMaterialTypes.Margin = New System.Windows.Forms.Padding(5, 9, 5, 9)
        Me.DGVMaterialTypes.MultiSelect = False
        Me.DGVMaterialTypes.Name = "DGVMaterialTypes"
        Me.DGVMaterialTypes.ReadOnly = True
        Me.DGVMaterialTypes.RowHeadersVisible = False
        Me.DGVMaterialTypes.RowHeadersWidth = 51
        Me.DGVMaterialTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMaterialTypes.Size = New System.Drawing.Size(345, 253)
        Me.DGVMaterialTypes.TabIndex = 1
        '
        'TxtTypeName
        '
        Me.TxtTypeName.Location = New System.Drawing.Point(105, 26)
        Me.TxtTypeName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTypeName.Name = "TxtTypeName"
        Me.TxtTypeName.Size = New System.Drawing.Size(179, 26)
        Me.TxtTypeName.TabIndex = 73
        Me.TxtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumTypeQuantity
        '
        Me.NumTypeQuantity.CausesValidation = False
        Me.NumTypeQuantity.DecimalPlaces = 2
        Me.NumTypeQuantity.Location = New System.Drawing.Point(105, 60)
        Me.NumTypeQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumTypeQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumTypeQuantity.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumTypeQuantity.Name = "NumTypeQuantity"
        Me.NumTypeQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumTypeQuantity.Size = New System.Drawing.Size(179, 26)
        Me.NumTypeQuantity.TabIndex = 64
        Me.NumTypeQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMaterialType
        '
        Me.LblMaterialType.AutoSize = True
        Me.LblMaterialType.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblMaterialType.Location = New System.Drawing.Point(302, 31)
        Me.LblMaterialType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblMaterialType.Name = "LblMaterialType"
        Me.LblMaterialType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMaterialType.Size = New System.Drawing.Size(54, 17)
        Me.LblMaterialType.TabIndex = 72
        Me.LblMaterialType.Text = "نوع المادة"
        '
        'LblTypeQuantity
        '
        Me.LblTypeQuantity.AutoSize = True
        Me.LblTypeQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeQuantity.Location = New System.Drawing.Point(320, 63)
        Me.LblTypeQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTypeQuantity.Name = "LblTypeQuantity"
        Me.LblTypeQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTypeQuantity.Size = New System.Drawing.Size(36, 18)
        Me.LblTypeQuantity.TabIndex = 66
        Me.LblTypeQuantity.Text = "الكمية"
        '
        'BtnAddType
        '
        Me.BtnAddType.BackColor = System.Drawing.Color.White
        Me.BtnAddType.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddType.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnAddType.Location = New System.Drawing.Point(26, 26)
        Me.BtnAddType.Name = "BtnAddType"
        Me.BtnAddType.Size = New System.Drawing.Size(61, 61)
        Me.BtnAddType.TabIndex = 74
        Me.BtnAddType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddType.UseVisualStyleBackColor = False
        '
        'TabPrices
        '
        Me.TabPrices.Controls.Add(Me.GroupBox3)
        Me.TabPrices.Location = New System.Drawing.Point(4, 27)
        Me.TabPrices.Name = "TabPrices"
        Me.TabPrices.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrices.Size = New System.Drawing.Size(385, 410)
        Me.TabPrices.TabIndex = 2
        Me.TabPrices.Text = "الاسعار"
        Me.TabPrices.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NumYear)
        Me.GroupBox3.Controls.Add(Me.GrpPrices)
        Me.GroupBox3.Controls.Add(Me.NumPrice)
        Me.GroupBox3.Controls.Add(Me.LblYear)
        Me.GroupBox3.Controls.Add(Me.LblPrice)
        Me.GroupBox3.Controls.Add(Me.BtnAddPrice)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 387)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'NumYear
        '
        Me.NumYear.CausesValidation = False
        Me.NumYear.Location = New System.Drawing.Point(105, 27)
        Me.NumYear.Margin = New System.Windows.Forms.Padding(4)
        Me.NumYear.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.NumYear.Minimum = New Decimal(New Integer() {2023, 0, 0, 0})
        Me.NumYear.Name = "NumYear"
        Me.NumYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumYear.Size = New System.Drawing.Size(179, 26)
        Me.NumYear.TabIndex = 75
        Me.NumYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumYear.Value = New Decimal(New Integer() {2023, 0, 0, 0})
        '
        'GrpPrices
        '
        Me.GrpPrices.Controls.Add(Me.DGVMaterialPrice)
        Me.GrpPrices.Location = New System.Drawing.Point(6, 93)
        Me.GrpPrices.Name = "GrpPrices"
        Me.GrpPrices.Size = New System.Drawing.Size(361, 288)
        Me.GrpPrices.TabIndex = 65
        Me.GrpPrices.TabStop = False
        Me.GrpPrices.Text = "الاسعار"
        '
        'DGVMaterialPrice
        '
        Me.DGVMaterialPrice.AllowUserToAddRows = False
        Me.DGVMaterialPrice.AllowUserToDeleteRows = False
        Me.DGVMaterialPrice.AllowUserToResizeColumns = False
        Me.DGVMaterialPrice.AllowUserToResizeRows = False
        Me.DGVMaterialPrice.BackgroundColor = System.Drawing.Color.White
        Me.DGVMaterialPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaterialPrice.Location = New System.Drawing.Point(8, 23)
        Me.DGVMaterialPrice.Margin = New System.Windows.Forms.Padding(5, 9, 5, 9)
        Me.DGVMaterialPrice.MultiSelect = False
        Me.DGVMaterialPrice.Name = "DGVMaterialPrice"
        Me.DGVMaterialPrice.ReadOnly = True
        Me.DGVMaterialPrice.RowHeadersVisible = False
        Me.DGVMaterialPrice.RowHeadersWidth = 51
        Me.DGVMaterialPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMaterialPrice.Size = New System.Drawing.Size(345, 253)
        Me.DGVMaterialPrice.TabIndex = 1
        '
        'NumPrice
        '
        Me.NumPrice.CausesValidation = False
        Me.NumPrice.DecimalPlaces = 2
        Me.NumPrice.Location = New System.Drawing.Point(105, 60)
        Me.NumPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.NumPrice.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumPrice.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumPrice.Name = "NumPrice"
        Me.NumPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumPrice.Size = New System.Drawing.Size(179, 26)
        Me.NumPrice.TabIndex = 64
        Me.NumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblYear
        '
        Me.LblYear.AutoSize = True
        Me.LblYear.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblYear.Location = New System.Drawing.Point(330, 31)
        Me.LblYear.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblYear.Size = New System.Drawing.Size(32, 17)
        Me.LblYear.TabIndex = 72
        Me.LblYear.Text = "السنة"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(325, 62)
        Me.LblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblPrice.Size = New System.Drawing.Size(37, 18)
        Me.LblPrice.TabIndex = 66
        Me.LblPrice.Text = "السعر"
        '
        'BtnAddPrice
        '
        Me.BtnAddPrice.BackColor = System.Drawing.Color.White
        Me.BtnAddPrice.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddPrice.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnAddPrice.Location = New System.Drawing.Point(26, 26)
        Me.BtnAddPrice.Name = "BtnAddPrice"
        Me.BtnAddPrice.Size = New System.Drawing.Size(61, 61)
        Me.BtnAddPrice.TabIndex = 74
        Me.BtnAddPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddPrice.UseVisualStyleBackColor = False
        '
        'NumBlockCapacity
        '
        Me.NumBlockCapacity.DecimalPlaces = 2
        Me.NumBlockCapacity.Location = New System.Drawing.Point(84, 265)
        Me.NumBlockCapacity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumBlockCapacity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumBlockCapacity.Name = "NumBlockCapacity"
        Me.NumBlockCapacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumBlockCapacity.Size = New System.Drawing.Size(179, 26)
        Me.NumBlockCapacity.TabIndex = 48
        Me.NumBlockCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBlockCapacity
        '
        Me.LblBlockCapacity.AutoSize = True
        Me.LblBlockCapacity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlockCapacity.Location = New System.Drawing.Point(276, 267)
        Me.LblBlockCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBlockCapacity.Name = "LblBlockCapacity"
        Me.LblBlockCapacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBlockCapacity.Size = New System.Drawing.Size(71, 18)
        Me.LblBlockCapacity.TabIndex = 49
        Me.LblBlockCapacity.Text = "سعة المشتاح"
        Me.LblBlockCapacity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NumBlockQuantity
        '
        Me.NumBlockQuantity.DecimalPlaces = 2
        Me.NumBlockQuantity.Location = New System.Drawing.Point(83, 299)
        Me.NumBlockQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumBlockQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumBlockQuantity.Name = "NumBlockQuantity"
        Me.NumBlockQuantity.ReadOnly = True
        Me.NumBlockQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumBlockQuantity.Size = New System.Drawing.Size(179, 26)
        Me.NumBlockQuantity.TabIndex = 50
        Me.NumBlockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBlockQuantity
        '
        Me.LblBlockQuantity.AutoSize = True
        Me.LblBlockQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlockQuantity.Location = New System.Drawing.Point(276, 301)
        Me.LblBlockQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBlockQuantity.Name = "LblBlockQuantity"
        Me.LblBlockQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBlockQuantity.Size = New System.Drawing.Size(71, 18)
        Me.LblBlockQuantity.TabIndex = 51
        Me.LblBlockQuantity.Text = "عدد المشاتيح"
        Me.LblBlockQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmMaterialAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(416, 459)
        Me.Controls.Add(Me.TabMaterialEA)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMaterialAddEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة / تعديل المادة"
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        CType(Me.PBoxQuantityLocker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumWeigth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMinQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsActive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMaterialEA.ResumeLayout(False)
        Me.TabMaterial.ResumeLayout(False)
        Me.TabTypes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrpTypes.ResumeLayout(False)
        CType(Me.DGVMaterialTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTypeQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPrices.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPrices.ResumeLayout(False)
        CType(Me.DGVMaterialPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBlockCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBlockQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnMaterialAE As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents IsActive As PictureBox
    Friend WithEvents LblWeigth As Label
    Friend WithEvents LblMinQuantity As Label
    Friend WithEvents LblQuantity As Label
    Friend WithEvents NumQuantity As NumericUpDown
    Friend WithEvents LblBarcode As Label
    Friend WithEvents TxtMaterialName As TextBox
    Friend WithEvents Txtbarcode As TextBox
    Friend WithEvents GrpDetails As GroupBox
    Friend WithEvents LblMaterialName As Label
    Friend WithEvents LblLocCode As Label
    Friend WithEvents TxtLocBarcode As TextBox
    Friend WithEvents NumMinQuantity As NumericUpDown
    Friend WithEvents CmbUnits As ComboBox
    Friend WithEvents NumWeigth As NumericUpDown
    Friend WithEvents LblUnit As Label
    Friend WithEvents TabMaterialEA As TabControl
    Friend WithEvents TabMaterial As TabPage
    Friend WithEvents TabTypes As TabPage
    Friend WithEvents LblMaterialType As Label
    Friend WithEvents NumTypeQuantity As NumericUpDown
    Friend WithEvents LblTypeQuantity As Label
    Friend WithEvents GrpTypes As GroupBox
    Friend WithEvents DGVMaterialTypes As DataGridView
    Friend WithEvents TxtTypeName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAddType As Button
    Friend WithEvents TabPrices As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GrpPrices As GroupBox
    Friend WithEvents DGVMaterialPrice As DataGridView
    Friend WithEvents BtnAddPrice As Button
    Friend WithEvents NumPrice As NumericUpDown
    Friend WithEvents LblYear As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents NumYear As NumericUpDown
    Friend WithEvents PBoxQuantityLocker As PictureBox
    Friend WithEvents NumBlockQuantity As NumericUpDown
    Friend WithEvents LblBlockQuantity As Label
    Friend WithEvents NumBlockCapacity As NumericUpDown
    Friend WithEvents LblBlockCapacity As Label
End Class
