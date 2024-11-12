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
        CType(Me.IsActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetails.SuspendLayout()
        CType(Me.NumWeigth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMinQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMaterialAE
        '
        Me.BtnMaterialAE.BackColor = System.Drawing.Color.White
        Me.BtnMaterialAE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnMaterialAE.Image = CType(resources.GetObject("BtnMaterialAE.Image"), System.Drawing.Image)
        Me.BtnMaterialAE.Location = New System.Drawing.Point(106, 307)
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
        Me.BtnClose.Location = New System.Drawing.Point(255, 307)
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
        Me.LblWeigth.Size = New System.Drawing.Size(48, 23)
        Me.LblWeigth.TabIndex = 39
        Me.LblWeigth.Text = "الوزن"
        '
        'LblMinQuantity
        '
        Me.LblMinQuantity.AutoSize = True
        Me.LblMinQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinQuantity.Location = New System.Drawing.Point(274, 177)
        Me.LblMinQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMinQuantity.Name = "LblMinQuantity"
        Me.LblMinQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMinQuantity.Size = New System.Drawing.Size(83, 23)
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
        Me.LblQuantity.Size = New System.Drawing.Size(47, 23)
        Me.LblQuantity.TabIndex = 35
        Me.LblQuantity.Text = "الكمية"
        '
        'NumQuantity
        '
        Me.NumQuantity.Location = New System.Drawing.Point(84, 141)
        Me.NumQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.NumQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumQuantity.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.NumQuantity.Name = "NumQuantity"
        Me.NumQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumQuantity.Size = New System.Drawing.Size(179, 30)
        Me.NumQuantity.TabIndex = 3
        Me.NumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBarecode
        '
        Me.LblBarecode.AutoSize = True
        Me.LblBarecode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarecode.Location = New System.Drawing.Point(311, 110)
        Me.LblBarecode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBarecode.Name = "LblBarecode"
        Me.LblBarecode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBarecode.Size = New System.Drawing.Size(46, 23)
        Me.LblBarecode.TabIndex = 31
        Me.LblBarecode.Text = "الرمز"
        '
        'TxtMaterialName
        '
        Me.TxtMaterialName.Location = New System.Drawing.Point(84, 39)
        Me.TxtMaterialName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMaterialName.Name = "TxtMaterialName"
        Me.TxtMaterialName.Size = New System.Drawing.Size(179, 30)
        Me.TxtMaterialName.TabIndex = 0
        Me.TxtMaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtbarcode
        '
        Me.Txtbarcode.Location = New System.Drawing.Point(84, 107)
        Me.Txtbarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtbarcode.Name = "Txtbarcode"
        Me.Txtbarcode.Size = New System.Drawing.Size(179, 30)
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
        Me.GrpDetails.Location = New System.Drawing.Point(36, 16)
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
        Me.CmbUnits.Size = New System.Drawing.Size(179, 31)
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
        Me.NumWeigth.Size = New System.Drawing.Size(179, 30)
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
        Me.NumMinQuantity.Size = New System.Drawing.Size(179, 30)
        Me.NumMinQuantity.TabIndex = 4
        Me.NumMinQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "الرمز المحلي"
        '
        'TxtLocBarcode
        '
        Me.TxtLocBarcode.Location = New System.Drawing.Point(84, 73)
        Me.TxtLocBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLocBarcode.Name = "TxtLocBarcode"
        Me.TxtLocBarcode.Size = New System.Drawing.Size(179, 30)
        Me.TxtLocBarcode.TabIndex = 1
        Me.TxtLocBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblUnit
        '
        Me.LblUnit.AutoSize = True
        Me.LblUnit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnit.Location = New System.Drawing.Point(269, 212)
        Me.LblUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUnit.Name = "LblUnit"
        Me.LblUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUnit.Size = New System.Drawing.Size(88, 23)
        Me.LblUnit.TabIndex = 41
        Me.LblUnit.Text = "وحدة القياس"
        '
        'LblMaterialName
        '
        Me.LblMaterialName.AutoSize = True
        Me.LblMaterialName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterialName.Location = New System.Drawing.Point(285, 42)
        Me.LblMaterialName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMaterialName.Name = "LblMaterialName"
        Me.LblMaterialName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMaterialName.Size = New System.Drawing.Size(72, 23)
        Me.LblMaterialName.TabIndex = 0
        Me.LblMaterialName.Text = "اسم المادة"
        '
        'FrmMaterialAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(438, 419)
        Me.Controls.Add(Me.BtnMaterialAE)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrpDetails)
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
End Class
