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
        Me.TabMaterials = New System.Windows.Forms.TabControl()
        Me.TabMaterialsOn = New System.Windows.Forms.TabPage()
        Me.DGVProducts = New System.Windows.Forms.DataGridView()
        Me.TabMaterialsOff = New System.Windows.Forms.TabPage()
        Me.DGVMaterialsOff = New System.Windows.Forms.DataGridView()
        Me.BtnExcelLoad = New System.Windows.Forms.Button()
        Me.BtnAddMaterial = New System.Windows.Forms.Button()
        Me.BtnUpdateMaterial = New System.Windows.Forms.Button()
        Me.BtnDeleteMaterial = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpProducts.SuspendLayout()
        Me.TabMaterials.SuspendLayout()
        Me.TabMaterialsOn.SuspendLayout()
        CType(Me.DGVProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMaterialsOff.SuspendLayout()
        CType(Me.DGVMaterialsOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpProducts
        '
        Me.GrpProducts.Controls.Add(Me.TabMaterials)
        Me.GrpProducts.Location = New System.Drawing.Point(13, 9)
        Me.GrpProducts.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.GrpProducts.Name = "GrpProducts"
        Me.GrpProducts.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.GrpProducts.Size = New System.Drawing.Size(654, 395)
        Me.GrpProducts.TabIndex = 42
        Me.GrpProducts.TabStop = False
        Me.GrpProducts.Text = "قائمة المواد"
        '
        'TabMaterials
        '
        Me.TabMaterials.Controls.Add(Me.TabMaterialsOn)
        Me.TabMaterials.Controls.Add(Me.TabMaterialsOff)
        Me.TabMaterials.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMaterials.Location = New System.Drawing.Point(9, 33)
        Me.TabMaterials.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabMaterials.Name = "TabMaterials"
        Me.TabMaterials.RightToLeftLayout = True
        Me.TabMaterials.SelectedIndex = 0
        Me.TabMaterials.Size = New System.Drawing.Size(626, 352)
        Me.TabMaterials.TabIndex = 1
        '
        'TabMaterialsOn
        '
        Me.TabMaterialsOn.Controls.Add(Me.DGVProducts)
        Me.TabMaterialsOn.Location = New System.Drawing.Point(4, 29)
        Me.TabMaterialsOn.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabMaterialsOn.Name = "TabMaterialsOn"
        Me.TabMaterialsOn.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabMaterialsOn.Size = New System.Drawing.Size(618, 319)
        Me.TabMaterialsOn.TabIndex = 0
        Me.TabMaterialsOn.Text = "قائمة المواد المفعلة"
        Me.TabMaterialsOn.UseVisualStyleBackColor = True
        '
        'DGVProducts
        '
        Me.DGVProducts.AllowUserToAddRows = False
        Me.DGVProducts.AllowUserToDeleteRows = False
        Me.DGVProducts.AllowUserToResizeColumns = False
        Me.DGVProducts.AllowUserToResizeRows = False
        Me.DGVProducts.BackgroundColor = System.Drawing.Color.White
        Me.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProducts.Location = New System.Drawing.Point(8, 7)
        Me.DGVProducts.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DGVProducts.MultiSelect = False
        Me.DGVProducts.Name = "DGVProducts"
        Me.DGVProducts.ReadOnly = True
        Me.DGVProducts.RowHeadersVisible = False
        Me.DGVProducts.RowHeadersWidth = 51
        Me.DGVProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProducts.Size = New System.Drawing.Size(600, 300)
        Me.DGVProducts.TabIndex = 0
        '
        'TabMaterialsOff
        '
        Me.TabMaterialsOff.Controls.Add(Me.DGVMaterialsOff)
        Me.TabMaterialsOff.Location = New System.Drawing.Point(4, 29)
        Me.TabMaterialsOff.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabMaterialsOff.Name = "TabMaterialsOff"
        Me.TabMaterialsOff.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.TabMaterialsOff.Size = New System.Drawing.Size(618, 319)
        Me.TabMaterialsOff.TabIndex = 1
        Me.TabMaterialsOff.Text = "قائمة المواد الغير مفعلة"
        Me.TabMaterialsOff.UseVisualStyleBackColor = True
        '
        'DGVMaterialsOff
        '
        Me.DGVMaterialsOff.AllowUserToAddRows = False
        Me.DGVMaterialsOff.AllowUserToDeleteRows = False
        Me.DGVMaterialsOff.AllowUserToResizeColumns = False
        Me.DGVMaterialsOff.AllowUserToResizeRows = False
        Me.DGVMaterialsOff.BackgroundColor = System.Drawing.Color.White
        Me.DGVMaterialsOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaterialsOff.Location = New System.Drawing.Point(8, 7)
        Me.DGVMaterialsOff.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.DGVMaterialsOff.MultiSelect = False
        Me.DGVMaterialsOff.Name = "DGVMaterialsOff"
        Me.DGVMaterialsOff.RowHeadersVisible = False
        Me.DGVMaterialsOff.RowHeadersWidth = 51
        Me.DGVMaterialsOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMaterialsOff.Size = New System.Drawing.Size(600, 300)
        Me.DGVMaterialsOff.TabIndex = 1
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
        'BtnAddMaterial
        '
        Me.BtnAddMaterial.BackColor = System.Drawing.Color.White
        Me.BtnAddMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddMaterial.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnAddMaterial.Location = New System.Drawing.Point(13, 414)
        Me.BtnAddMaterial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAddMaterial.Name = "BtnAddMaterial"
        Me.BtnAddMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAddMaterial.Size = New System.Drawing.Size(123, 63)
        Me.BtnAddMaterial.TabIndex = 41
        Me.BtnAddMaterial.Text = "اضافة مادة"
        Me.BtnAddMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddMaterial.UseVisualStyleBackColor = False
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
        Me.BtnUpdateMaterial.Text = "تعديل مادة"
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
        Me.BtnDeleteMaterial.Text = "حذف مادة"
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
        Me.Controls.Add(Me.BtnAddMaterial)
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
        Me.Text = "מחיקת רכב"
        Me.GrpProducts.ResumeLayout(False)
        Me.TabMaterials.ResumeLayout(False)
        Me.TabMaterialsOn.ResumeLayout(False)
        CType(Me.DGVProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMaterialsOff.ResumeLayout(False)
        CType(Me.DGVMaterialsOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpProducts As GroupBox
    Friend WithEvents TabMaterials As TabControl
    Friend WithEvents TabMaterialsOn As TabPage
    Friend WithEvents DGVProducts As DataGridView
    Friend WithEvents TabMaterialsOff As TabPage
    Friend WithEvents DGVMaterialsOff As DataGridView
    Friend WithEvents BtnExcelLoad As Button
    Friend WithEvents BtnAddMaterial As Button
    Friend WithEvents BtnUpdateMaterial As Button
    Friend WithEvents BtnDeleteMaterial As Button
    Friend WithEvents BtnClose As Button
End Class
