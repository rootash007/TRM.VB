<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductAE))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpDetails = New System.Windows.Forms.GroupBox()
        Me.NumCans = New System.Windows.Forms.NumericUpDown()
        Me.TxtProductName = New System.Windows.Forms.TextBox()
        Me.TxtProdiuctBarcode = New System.Windows.Forms.TextBox()
        Me.NumTotalCans = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumBoxes = New System.Windows.Forms.NumericUpDown()
        Me.IsActive = New System.Windows.Forms.PictureBox()
        Me.LblBoxes = New System.Windows.Forms.Label()
        Me.LblTotalCans = New System.Windows.Forms.Label()
        Me.LblCans = New System.Windows.Forms.Label()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVProductMaterials = New System.Windows.Forms.DataGridView()
        Me.CmbMaterialName = New System.Windows.Forms.ComboBox()
        Me.CmbMaterialBarcode = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtUnit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddToDGV = New System.Windows.Forms.Button()
        Me.LblMaterialName = New System.Windows.Forms.Label()
        Me.NumQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpDetails.SuspendLayout()
        CType(Me.NumCans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTotalCans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBoxes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsActive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProductMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(525, 340)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 55)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "שמירה"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(525, 401)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.NumCans)
        Me.GrpDetails.Controls.Add(Me.TxtProductName)
        Me.GrpDetails.Controls.Add(Me.TxtProdiuctBarcode)
        Me.GrpDetails.Controls.Add(Me.NumTotalCans)
        Me.GrpDetails.Controls.Add(Me.Label1)
        Me.GrpDetails.Controls.Add(Me.NumBoxes)
        Me.GrpDetails.Controls.Add(Me.IsActive)
        Me.GrpDetails.Controls.Add(Me.LblBoxes)
        Me.GrpDetails.Controls.Add(Me.LblTotalCans)
        Me.GrpDetails.Controls.Add(Me.LblCans)
        Me.GrpDetails.Controls.Add(Me.LblProductName)
        Me.GrpDetails.Location = New System.Drawing.Point(13, 13)
        Me.GrpDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpDetails.Size = New System.Drawing.Size(299, 201)
        Me.GrpDetails.TabIndex = 3
        Me.GrpDetails.TabStop = False
        Me.GrpDetails.Text = "تفاصيل المادة"
        '
        'NumCans
        '
        Me.NumCans.CausesValidation = False
        Me.NumCans.Location = New System.Drawing.Point(9, 108)
        Me.NumCans.Margin = New System.Windows.Forms.Padding(4)
        Me.NumCans.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumCans.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumCans.Name = "NumCans"
        Me.NumCans.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumCans.Size = New System.Drawing.Size(179, 21)
        Me.NumCans.TabIndex = 48
        Me.NumCans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtProductName
        '
        Me.TxtProductName.Location = New System.Drawing.Point(8, 44)
        Me.TxtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(179, 21)
        Me.TxtProductName.TabIndex = 47
        Me.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtProdiuctBarcode
        '
        Me.TxtProdiuctBarcode.Location = New System.Drawing.Point(8, 76)
        Me.TxtProdiuctBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProdiuctBarcode.Name = "TxtProdiuctBarcode"
        Me.TxtProdiuctBarcode.Size = New System.Drawing.Size(179, 21)
        Me.TxtProdiuctBarcode.TabIndex = 46
        Me.TxtProdiuctBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumTotalCans
        '
        Me.NumTotalCans.Location = New System.Drawing.Point(8, 172)
        Me.NumTotalCans.Margin = New System.Windows.Forms.Padding(4)
        Me.NumTotalCans.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumTotalCans.Name = "NumTotalCans"
        Me.NumTotalCans.ReadOnly = True
        Me.NumTotalCans.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumTotalCans.Size = New System.Drawing.Size(179, 21)
        Me.NumTotalCans.TabIndex = 4
        Me.NumTotalCans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(36, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "الرمز"
        '
        'NumBoxes
        '
        Me.NumBoxes.CausesValidation = False
        Me.NumBoxes.Location = New System.Drawing.Point(9, 140)
        Me.NumBoxes.Margin = New System.Windows.Forms.Padding(4)
        Me.NumBoxes.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumBoxes.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumBoxes.Name = "NumBoxes"
        Me.NumBoxes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumBoxes.Size = New System.Drawing.Size(179, 21)
        Me.NumBoxes.TabIndex = 3
        Me.NumBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IsActive
        '
        Me.IsActive.Image = CType(resources.GetObject("IsActive.Image"), System.Drawing.Image)
        Me.IsActive.Location = New System.Drawing.Point(8, 14)
        Me.IsActive.Margin = New System.Windows.Forms.Padding(4)
        Me.IsActive.Name = "IsActive"
        Me.IsActive.Size = New System.Drawing.Size(60, 25)
        Me.IsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IsActive.TabIndex = 44
        Me.IsActive.TabStop = False
        '
        'LblBoxes
        '
        Me.LblBoxes.AutoSize = True
        Me.LblBoxes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBoxes.Location = New System.Drawing.Point(216, 144)
        Me.LblBoxes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBoxes.Name = "LblBoxes"
        Me.LblBoxes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBoxes.Size = New System.Drawing.Size(76, 18)
        Me.LblBoxes.TabIndex = 35
        Me.LblBoxes.Text = "عدد الصناديق"
        '
        'LblTotalCans
        '
        Me.LblTotalCans.AutoSize = True
        Me.LblTotalCans.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalCans.Location = New System.Drawing.Point(195, 175)
        Me.LblTotalCans.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTotalCans.Name = "LblTotalCans"
        Me.LblTotalCans.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTotalCans.Size = New System.Drawing.Size(97, 18)
        Me.LblTotalCans.TabIndex = 37
        Me.LblTotalCans.Text = "المجموع بالمشتاح"
        '
        'LblCans
        '
        Me.LblCans.AutoSize = True
        Me.LblCans.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCans.Location = New System.Drawing.Point(236, 111)
        Me.LblCans.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCans.Name = "LblCans"
        Me.LblCans.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCans.Size = New System.Drawing.Size(56, 18)
        Me.LblCans.TabIndex = 31
        Me.LblCans.Text = "عدد العلب"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductName.Location = New System.Drawing.Point(235, 47)
        Me.LblProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblProductName.Size = New System.Drawing.Size(57, 18)
        Me.LblProductName.TabIndex = 0
        Me.LblProductName.Text = "اسم المنتج"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVProductMaterials)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 235)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المواد اللازمة للمنتج"
        '
        'DGVProductMaterials
        '
        Me.DGVProductMaterials.AllowUserToAddRows = False
        Me.DGVProductMaterials.AllowUserToDeleteRows = False
        Me.DGVProductMaterials.AllowUserToResizeColumns = False
        Me.DGVProductMaterials.AllowUserToResizeRows = False
        Me.DGVProductMaterials.BackgroundColor = System.Drawing.Color.White
        Me.DGVProductMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductMaterials.Location = New System.Drawing.Point(12, 19)
        Me.DGVProductMaterials.Margin = New System.Windows.Forms.Padding(5, 9, 5, 9)
        Me.DGVProductMaterials.MultiSelect = False
        Me.DGVProductMaterials.Name = "DGVProductMaterials"
        Me.DGVProductMaterials.ReadOnly = True
        Me.DGVProductMaterials.RowHeadersVisible = False
        Me.DGVProductMaterials.RowHeadersWidth = 51
        Me.DGVProductMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProductMaterials.Size = New System.Drawing.Size(483, 206)
        Me.DGVProductMaterials.TabIndex = 1
        '
        'CmbMaterialName
        '
        Me.CmbMaterialName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMaterialName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMaterialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMaterialName.FormattingEnabled = True
        Me.CmbMaterialName.Location = New System.Drawing.Point(12, 21)
        Me.CmbMaterialName.Name = "CmbMaterialName"
        Me.CmbMaterialName.Size = New System.Drawing.Size(179, 21)
        Me.CmbMaterialName.TabIndex = 46
        '
        'CmbMaterialBarcode
        '
        Me.CmbMaterialBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMaterialBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMaterialBarcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMaterialBarcode.FormattingEnabled = True
        Me.CmbMaterialBarcode.Location = New System.Drawing.Point(12, 53)
        Me.CmbMaterialBarcode.Name = "CmbMaterialBarcode"
        Me.CmbMaterialBarcode.Size = New System.Drawing.Size(179, 21)
        Me.CmbMaterialBarcode.TabIndex = 47
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.TxtUnit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BtnAddToDGV)
        Me.GroupBox2.Controls.Add(Me.CmbMaterialBarcode)
        Me.GroupBox2.Controls.Add(Me.LblMaterialName)
        Me.GroupBox2.Controls.Add(Me.CmbMaterialName)
        Me.GroupBox2.Controls.Add(Me.NumQuantity)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(299, 201)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "تفاصيل المادة"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAdd.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnAdd.Location = New System.Drawing.Point(220, 138)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(56, 56)
        Me.BtnAdd.TabIndex = 63
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TxtUnit
        '
        Me.TxtUnit.Location = New System.Drawing.Point(12, 110)
        Me.TxtUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.ReadOnly = True
        Me.TxtUnit.Size = New System.Drawing.Size(179, 21)
        Me.TxtUnit.TabIndex = 49
        Me.TxtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "رقم المادة"
        '
        'BtnAddToDGV
        '
        Me.BtnAddToDGV.BackColor = System.Drawing.Color.White
        Me.BtnAddToDGV.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddToDGV.Image = Global.TRM.My.Resources.Resources.save
        Me.BtnAddToDGV.Location = New System.Drawing.Point(12, 138)
        Me.BtnAddToDGV.Name = "BtnAddToDGV"
        Me.BtnAddToDGV.Size = New System.Drawing.Size(179, 56)
        Me.BtnAddToDGV.TabIndex = 50
        Me.BtnAddToDGV.Text = "اضافة مادة مطلوبة للمنتج"
        Me.BtnAddToDGV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddToDGV.UseVisualStyleBackColor = False
        '
        'LblMaterialName
        '
        Me.LblMaterialName.AutoSize = True
        Me.LblMaterialName.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblMaterialName.Location = New System.Drawing.Point(256, 25)
        Me.LblMaterialName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblMaterialName.Name = "LblMaterialName"
        Me.LblMaterialName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMaterialName.Size = New System.Drawing.Size(32, 17)
        Me.LblMaterialName.TabIndex = 61
        Me.LblMaterialName.Text = "المادة"
        '
        'NumQuantity
        '
        Me.NumQuantity.CausesValidation = False
        Me.NumQuantity.DecimalPlaces = 2
        Me.NumQuantity.Location = New System.Drawing.Point(12, 81)
        Me.NumQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumQuantity.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumQuantity.Name = "NumQuantity"
        Me.NumQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumQuantity.Size = New System.Drawing.Size(179, 21)
        Me.NumQuantity.TabIndex = 3
        Me.NumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "الكمية المطلوبة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "وحدة القياس"
        '
        'FrmProductAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 464)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpDetails)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProductAE"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة منتج"
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        CType(Me.NumCans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTotalCans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBoxes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsActive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVProductMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpDetails As GroupBox
    Friend WithEvents NumTotalCans As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents IsActive As PictureBox
    Friend WithEvents LblTotalCans As Label
    Friend WithEvents LblBoxes As Label
    Friend WithEvents NumBoxes As NumericUpDown
    Friend WithEvents LblCans As Label
    Friend WithEvents LblProductName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVProductMaterials As DataGridView
    Friend WithEvents CmbMaterialName As ComboBox
    Friend WithEvents CmbMaterialBarcode As ComboBox
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents TxtProdiuctBarcode As TextBox
    Friend WithEvents NumCans As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumQuantity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblMaterialName As Label
    Friend WithEvents BtnAddToDGV As Button
    Friend WithEvents TxtUnit As TextBox
    Friend WithEvents BtnAdd As Button
End Class
