<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaterialAddEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaterialAddEdit))
        Me.BtnMaterialAE = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.IsActive = New System.Windows.Forms.PictureBox()
        Me.LblWeigth = New System.Windows.Forms.Label()
        Me.LblMinQuantity = New System.Windows.Forms.Label()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.NumQuantity = New System.Windows.Forms.NumericUpDown()
        Me.LblBarecode = New System.Windows.Forms.Label()
        Me.TxtMaterialName = New System.Windows.Forms.TextBox()
        Me.Txtbarcode = New System.Windows.Forms.TextBox()
        Me.GrpDetails = New System.Windows.Forms.GroupBox()
        Me.CmbUnits = New System.Windows.Forms.ComboBox()
        Me.NumWeigth = New System.Windows.Forms.NumericUpDown()
        Me.NumMinQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtLocBarcode = New System.Windows.Forms.TextBox()
        Me.LblUnit = New System.Windows.Forms.Label()
        Me.LblMaterialName = New System.Windows.Forms.Label()
        Me.TabMaterialEA = New System.Windows.Forms.TabControl()
        Me.TabMaterial = New System.Windows.Forms.TabPage()
        Me.TabTypes = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVMaterialTypes = New System.Windows.Forms.DataGridView()
        Me.TxtTypeName = New System.Windows.Forms.TextBox()
        Me.BtnAddType = New System.Windows.Forms.Button()
        Me.NumTypeQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPricies = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGVMaterialPrice = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumYear = New System.Windows.Forms.NumericUpDown()
        CType(Me.IsActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetails.SuspendLayout()
        CType(Me.NumWeigth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMinQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMaterialEA.SuspendLayout()
        Me.TabMaterial.SuspendLayout()
        Me.TabTypes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVMaterialTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTypeQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPricies.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGVMaterialPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMaterialAE
        '
        Me.BtnMaterialAE.BackColor = System.Drawing.Color.White
        Me.BtnMaterialAE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMaterialAE.Image = CType(resources.GetObject("BtnMaterialAE.Image"), System.Drawing.Image)
        Me.BtnMaterialAE.Location = New System.Drawing.Point(226, 298)
        Me.BtnMaterialAE.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMaterialAE.Name = "BtnMaterialAE"
        Me.BtnMaterialAE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnMaterialAE.Size = New System.Drawing.Size(144, 80)
        Me.BtnMaterialAE.TabIndex = 1
        Me.BtnMaterialAE.Text = "اضافة مادة"
        Me.BtnMaterialAE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnMaterialAE.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(7, 298)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(144, 80)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'IsActive
        '
        Me.IsActive.Image = CType(resources.GetObject("IsActive.Image"), System.Drawing.Image)
        Me.IsActive.Location = New System.Drawing.Point(8, 35)
        Me.IsActive.Margin = New System.Windows.Forms.Padding(4)
        Me.IsActive.Name = "IsActive"
        Me.IsActive.Size = New System.Drawing.Size(60, 30)
        Me.IsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IsActive.TabIndex = 44
        Me.IsActive.TabStop = False
        '
        'LblWeigth
        '
        Me.LblWeigth.AutoSize = True
        Me.LblWeigth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeigth.Location = New System.Drawing.Point(309, 245)
        Me.LblWeigth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblWeigth.Name = "LblWeigth"
        Me.LblWeigth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblWeigth.Size = New System.Drawing.Size(37, 18)
        Me.LblWeigth.TabIndex = 39
        Me.LblWeigth.Text = "الوزن"
        '
        'LblMinQuantity
        '
        Me.LblMinQuantity.AutoSize = True
        Me.LblMinQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinQuantity.Location = New System.Drawing.Point(283, 177)
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
        Me.LblQuantity.Location = New System.Drawing.Point(310, 143)
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
        Me.NumQuantity.Location = New System.Drawing.Point(84, 141)
        Me.NumQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumQuantity.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumQuantity.Name = "NumQuantity"
        Me.NumQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumQuantity.Size = New System.Drawing.Size(179, 26)
        Me.NumQuantity.TabIndex = 3
        Me.NumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBarecode
        '
        Me.LblBarecode.AutoSize = True
        Me.LblBarecode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarecode.Location = New System.Drawing.Point(310, 110)
        Me.LblBarecode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBarecode.Name = "LblBarecode"
        Me.LblBarecode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBarecode.Size = New System.Drawing.Size(36, 18)
        Me.LblBarecode.TabIndex = 31
        Me.LblBarecode.Text = "الرمز"
        '
        'TxtMaterialName
        '
        Me.TxtMaterialName.Location = New System.Drawing.Point(84, 39)
        Me.TxtMaterialName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMaterialName.Name = "TxtMaterialName"
        Me.TxtMaterialName.Size = New System.Drawing.Size(179, 26)
        Me.TxtMaterialName.TabIndex = 0
        Me.TxtMaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtbarcode
        '
        Me.Txtbarcode.Location = New System.Drawing.Point(84, 107)
        Me.Txtbarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtbarcode.Name = "Txtbarcode"
        Me.Txtbarcode.Size = New System.Drawing.Size(179, 26)
        Me.Txtbarcode.TabIndex = 2
        Me.Txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.CmbUnits)
        Me.GrpDetails.Controls.Add(Me.NumWeigth)
        Me.GrpDetails.Controls.Add(Me.NumMinQuantity)
        Me.GrpDetails.Controls.Add(Me.Label1)
        Me.GrpDetails.Controls.Add(Me.IsActive)
        Me.GrpDetails.Controls.Add(Me.TxtLocBarcode)
        Me.GrpDetails.Controls.Add(Me.LblUnit)
        Me.GrpDetails.Controls.Add(Me.LblWeigth)
        Me.GrpDetails.Controls.Add(Me.LblMinQuantity)
        Me.GrpDetails.Controls.Add(Me.LblQuantity)
        Me.GrpDetails.Controls.Add(Me.NumQuantity)
        Me.GrpDetails.Controls.Add(Me.LblBarecode)
        Me.GrpDetails.Controls.Add(Me.TxtMaterialName)
        Me.GrpDetails.Controls.Add(Me.Txtbarcode)
        Me.GrpDetails.Controls.Add(Me.LblMaterialName)
        Me.GrpDetails.Location = New System.Drawing.Point(7, 7)
        Me.GrpDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpDetails.Size = New System.Drawing.Size(363, 285)
        Me.GrpDetails.TabIndex = 0
        Me.GrpDetails.TabStop = False
        Me.GrpDetails.Text = "تفاصيل المادة"
        '
        'CmbUnits
        '
        Me.CmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUnits.FormattingEnabled = True
        Me.CmbUnits.Location = New System.Drawing.Point(84, 209)
        Me.CmbUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbUnits.Name = "CmbUnits"
        Me.CmbUnits.Size = New System.Drawing.Size(179, 26)
        Me.CmbUnits.Sorted = True
        Me.CmbUnits.TabIndex = 5
        '
        'NumWeigth
        '
        Me.NumWeigth.DecimalPlaces = 2
        Me.NumWeigth.Location = New System.Drawing.Point(85, 243)
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
        Me.NumMinQuantity.Location = New System.Drawing.Point(84, 175)
        Me.NumMinQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumMinQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumMinQuantity.Name = "NumMinQuantity"
        Me.NumMinQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumMinQuantity.Size = New System.Drawing.Size(179, 26)
        Me.NumMinQuantity.TabIndex = 4
        Me.NumMinQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "الرمز المحلي"
        '
        'TxtLocBarcode
        '
        Me.TxtLocBarcode.Location = New System.Drawing.Point(84, 73)
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
        Me.LblUnit.Location = New System.Drawing.Point(278, 212)
        Me.LblUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUnit.Name = "LblUnit"
        Me.LblUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUnit.Size = New System.Drawing.Size(68, 18)
        Me.LblUnit.TabIndex = 41
        Me.LblUnit.Text = "وحدة القياس"
        '
        'LblMaterialName
        '
        Me.LblMaterialName.AutoSize = True
        Me.LblMaterialName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialName.Location = New System.Drawing.Point(291, 42)
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
        Me.TabMaterialEA.Controls.Add(Me.TabPricies)
        Me.TabMaterialEA.Location = New System.Drawing.Point(12, 12)
        Me.TabMaterialEA.Name = "TabMaterialEA"
        Me.TabMaterialEA.RightToLeftLayout = True
        Me.TabMaterialEA.SelectedIndex = 0
        Me.TabMaterialEA.Size = New System.Drawing.Size(393, 420)
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
        Me.TabMaterial.Size = New System.Drawing.Size(385, 389)
        Me.TabMaterial.TabIndex = 0
        Me.TabMaterial.Text = "تفاصيل المادة"
        Me.TabMaterial.UseVisualStyleBackColor = True
        '
        'TabTypes
        '
        Me.TabTypes.Controls.Add(Me.GroupBox2)
        Me.TabTypes.Location = New System.Drawing.Point(4, 27)
        Me.TabTypes.Name = "TabTypes"
        Me.TabTypes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTypes.Size = New System.Drawing.Size(385, 389)
        Me.TabTypes.TabIndex = 1
        Me.TabTypes.Text = "انواع المادة"
        Me.TabTypes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.TxtTypeName)
        Me.GroupBox2.Controls.Add(Me.BtnAddType)
        Me.GroupBox2.Controls.Add(Me.NumTypeQuantity)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 358)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVMaterialTypes)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 259)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "انواع المنتج"
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
        Me.DGVMaterialTypes.Size = New System.Drawing.Size(345, 224)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "نوع المادة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "الكمية"
        '
        'TabPricies
        '
        Me.TabPricies.Controls.Add(Me.GroupBox3)
        Me.TabPricies.Location = New System.Drawing.Point(4, 27)
        Me.TabPricies.Name = "TabPricies"
        Me.TabPricies.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPricies.Size = New System.Drawing.Size(385, 389)
        Me.TabPricies.TabIndex = 2
        Me.TabPricies.Text = "الاسعار"
        Me.TabPricies.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NumYear)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 358)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGVMaterialPrice)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(361, 259)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "انواع المنتج"
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
        Me.DGVMaterialPrice.Size = New System.Drawing.Size(345, 224)
        Me.DGVMaterialPrice.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button1.Image = Global.TRM.My.Resources.Resources.plus
        Me.Button1.Location = New System.Drawing.Point(26, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 61)
        Me.Button1.TabIndex = 74
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.CausesValidation = False
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Location = New System.Drawing.Point(105, 60)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumericUpDown1.Size = New System.Drawing.Size(179, 26)
        Me.NumericUpDown1.TabIndex = 64
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "السنة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(36, 18)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "الكمية"
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
        'FrmMaterialAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(416, 442)
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
        CType(Me.IsActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        CType(Me.NumWeigth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMinQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMaterialEA.ResumeLayout(False)
        Me.TabMaterial.ResumeLayout(False)
        Me.TabTypes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVMaterialTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTypeQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPricies.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGVMaterialPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnMaterialAE As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents IsActive As PictureBox
    Friend WithEvents LblWeigth As Label
    Friend WithEvents LblMinQuantity As Label
    Friend WithEvents LblQuantity As Label
    Friend WithEvents NumQuantity As NumericUpDown
    Friend WithEvents LblBarecode As Label
    Friend WithEvents TxtMaterialName As TextBox
    Friend WithEvents Txtbarcode As TextBox
    Friend WithEvents GrpDetails As GroupBox
    Friend WithEvents LblMaterialName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLocBarcode As TextBox
    Friend WithEvents NumMinQuantity As NumericUpDown
    Friend WithEvents CmbUnits As ComboBox
    Friend WithEvents NumWeigth As NumericUpDown
    Friend WithEvents LblUnit As Label
    Friend WithEvents TabMaterialEA As TabControl
    Friend WithEvents TabMaterial As TabPage
    Friend WithEvents TabTypes As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents NumTypeQuantity As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVMaterialTypes As DataGridView
    Friend WithEvents TxtTypeName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAddType As Button
    Friend WithEvents TabPricies As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGVMaterialPrice As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumYear As NumericUpDown
End Class
