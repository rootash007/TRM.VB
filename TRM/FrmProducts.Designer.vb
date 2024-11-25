<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducts))
        Me.GrpProducts = New System.Windows.Forms.GroupBox()
        Me.TabProducts = New System.Windows.Forms.TabControl()
        Me.TabProductsOn = New System.Windows.Forms.TabPage()
        Me.DGVProductsOn = New System.Windows.Forms.DataGridView()
        Me.TabProductsOff = New System.Windows.Forms.TabPage()
        Me.DGVProductsOff = New System.Windows.Forms.DataGridView()
        Me.BtnExcelLoad = New System.Windows.Forms.Button()
        Me.BtnAddProduct = New System.Windows.Forms.Button()
        Me.BtnUpdateMaterial = New System.Windows.Forms.Button()
        Me.BtnDeleteMaterial = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpProducts.SuspendLayout()
        Me.TabProducts.SuspendLayout()
        Me.TabProductsOn.SuspendLayout()
        CType(Me.DGVProductsOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProductsOff.SuspendLayout()
        CType(Me.DGVProductsOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpProducts
        '
        Me.GrpProducts.Controls.Add(Me.TabProducts)
        Me.GrpProducts.Location = New System.Drawing.Point(13, 9)
        Me.GrpProducts.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.GrpProducts.Name = "GrpProducts"
        Me.GrpProducts.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.GrpProducts.Size = New System.Drawing.Size(654, 395)
        Me.GrpProducts.TabIndex = 42
        Me.GrpProducts.TabStop = False
        Me.GrpProducts.Text = "قائمة المنتجات"
        '
        'TabProducts
        '
        Me.TabProducts.Controls.Add(Me.TabProductsOn)
        Me.TabProducts.Controls.Add(Me.TabProductsOff)
        Me.TabProducts.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabProducts.Location = New System.Drawing.Point(9, 33)
        Me.TabProducts.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabProducts.Name = "TabProducts"
        Me.TabProducts.RightToLeftLayout = True
        Me.TabProducts.SelectedIndex = 0
        Me.TabProducts.Size = New System.Drawing.Size(626, 352)
        Me.TabProducts.TabIndex = 1
        '
        'TabProductsOn
        '
        Me.TabProductsOn.Controls.Add(Me.DGVProductsOn)
        Me.TabProductsOn.Location = New System.Drawing.Point(4, 29)
        Me.TabProductsOn.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabProductsOn.Name = "TabProductsOn"
        Me.TabProductsOn.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabProductsOn.Size = New System.Drawing.Size(618, 319)
        Me.TabProductsOn.TabIndex = 0
        Me.TabProductsOn.Text = "قائمة المنتجات المفعلة"
        Me.TabProductsOn.UseVisualStyleBackColor = True
        '
        'DGVProductsOn
        '
        Me.DGVProductsOn.AllowUserToAddRows = False
        Me.DGVProductsOn.AllowUserToDeleteRows = False
        Me.DGVProductsOn.AllowUserToResizeColumns = False
        Me.DGVProductsOn.AllowUserToResizeRows = False
        Me.DGVProductsOn.BackgroundColor = System.Drawing.Color.White
        Me.DGVProductsOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductsOn.Location = New System.Drawing.Point(8, 7)
        Me.DGVProductsOn.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DGVProductsOn.MultiSelect = False
        Me.DGVProductsOn.Name = "DGVProductsOn"
        Me.DGVProductsOn.ReadOnly = True
        Me.DGVProductsOn.RowHeadersVisible = False
        Me.DGVProductsOn.RowHeadersWidth = 51
        Me.DGVProductsOn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProductsOn.Size = New System.Drawing.Size(600, 300)
        Me.DGVProductsOn.TabIndex = 0
        '
        'TabProductsOff
        '
        Me.TabProductsOff.Controls.Add(Me.DGVProductsOff)
        Me.TabProductsOff.Location = New System.Drawing.Point(4, 29)
        Me.TabProductsOff.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabProductsOff.Name = "TabProductsOff"
        Me.TabProductsOff.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabProductsOff.Size = New System.Drawing.Size(618, 319)
        Me.TabProductsOff.TabIndex = 1
        Me.TabProductsOff.Text = "قائمة المنتجات الغير مفعلة"
        Me.TabProductsOff.UseVisualStyleBackColor = True
        '
        'DGVProductsOff
        '
        Me.DGVProductsOff.AllowUserToAddRows = False
        Me.DGVProductsOff.AllowUserToDeleteRows = False
        Me.DGVProductsOff.AllowUserToResizeColumns = False
        Me.DGVProductsOff.AllowUserToResizeRows = False
        Me.DGVProductsOff.BackgroundColor = System.Drawing.Color.White
        Me.DGVProductsOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductsOff.Location = New System.Drawing.Point(8, 7)
        Me.DGVProductsOff.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DGVProductsOff.MultiSelect = False
        Me.DGVProductsOff.Name = "DGVProductsOff"
        Me.DGVProductsOff.RowHeadersVisible = False
        Me.DGVProductsOff.RowHeadersWidth = 51
        Me.DGVProductsOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProductsOff.Size = New System.Drawing.Size(600, 300)
        Me.DGVProductsOff.TabIndex = 1
        '
        'BtnExcelLoad
        '
        Me.BtnExcelLoad.BackColor = System.Drawing.Color.White
        Me.BtnExcelLoad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnExcelLoad.Image = CType(resources.GetObject("BtnExcelLoad.Image"), System.Drawing.Image)
        Me.BtnExcelLoad.Location = New System.Drawing.Point(406, 414)
        Me.BtnExcelLoad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnExcelLoad.Name = "BtnExcelLoad"
        Me.BtnExcelLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnExcelLoad.Size = New System.Drawing.Size(123, 63)
        Me.BtnExcelLoad.TabIndex = 43
        Me.BtnExcelLoad.Text = "استخراج المعلومات"
        Me.BtnExcelLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnExcelLoad.UseVisualStyleBackColor = False
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.BackColor = System.Drawing.Color.White
        Me.BtnAddProduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddProduct.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnAddProduct.Location = New System.Drawing.Point(13, 414)
        Me.BtnAddProduct.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAddProduct.Size = New System.Drawing.Size(123, 63)
        Me.BtnAddProduct.TabIndex = 41
        Me.BtnAddProduct.Text = "اضافة منتج"
        Me.BtnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddProduct.UseVisualStyleBackColor = False
        '
        'BtnUpdateMaterial
        '
        Me.BtnUpdateMaterial.BackColor = System.Drawing.Color.White
        Me.BtnUpdateMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnUpdateMaterial.Image = CType(resources.GetObject("BtnUpdateMaterial.Image"), System.Drawing.Image)
        Me.BtnUpdateMaterial.Location = New System.Drawing.Point(144, 414)
        Me.BtnUpdateMaterial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnUpdateMaterial.Name = "BtnUpdateMaterial"
        Me.BtnUpdateMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUpdateMaterial.Size = New System.Drawing.Size(123, 63)
        Me.BtnUpdateMaterial.TabIndex = 40
        Me.BtnUpdateMaterial.Text = "تعديل منتج"
        Me.BtnUpdateMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUpdateMaterial.UseVisualStyleBackColor = False
        '
        'BtnDeleteMaterial
        '
        Me.BtnDeleteMaterial.BackColor = System.Drawing.Color.White
        Me.BtnDeleteMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnDeleteMaterial.Image = Global.TRM.My.Resources.Resources.delete48
        Me.BtnDeleteMaterial.Location = New System.Drawing.Point(275, 414)
        Me.BtnDeleteMaterial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnDeleteMaterial.Name = "BtnDeleteMaterial"
        Me.BtnDeleteMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeleteMaterial.Size = New System.Drawing.Size(123, 63)
        Me.BtnDeleteMaterial.TabIndex = 39
        Me.BtnDeleteMaterial.Text = "حذف منتج"
        Me.BtnDeleteMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDeleteMaterial.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(535, 414)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(123, 63)
        Me.BtnClose.TabIndex = 38
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 491)
        Me.Controls.Add(Me.GrpProducts)
        Me.Controls.Add(Me.BtnExcelLoad)
        Me.Controls.Add(Me.BtnAddProduct)
        Me.Controls.Add(Me.BtnUpdateMaterial)
        Me.Controls.Add(Me.BtnDeleteMaterial)
        Me.Controls.Add(Me.BtnClose)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProducts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "قائمة المنتجات"
        Me.GrpProducts.ResumeLayout(False)
        Me.TabProducts.ResumeLayout(False)
        Me.TabProductsOn.ResumeLayout(False)
        CType(Me.DGVProductsOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProductsOff.ResumeLayout(False)
        CType(Me.DGVProductsOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpProducts As GroupBox
    Friend WithEvents TabProducts As TabControl
    Friend WithEvents TabProductsOn As TabPage
    Friend WithEvents DGVProductsOn As DataGridView
    Friend WithEvents TabProductsOff As TabPage
    Friend WithEvents DGVProductsOff As DataGridView
    Friend WithEvents BtnExcelLoad As Button
    Friend WithEvents BtnAddProduct As Button
    Friend WithEvents BtnUpdateMaterial As Button
    Friend WithEvents BtnDeleteMaterial As Button
    Friend WithEvents BtnClose As Button
End Class
