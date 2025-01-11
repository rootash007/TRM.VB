<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMaterials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaterials))
        Me.GrpMaterials = New System.Windows.Forms.GroupBox()
        Me.TabMaterials = New System.Windows.Forms.TabControl()
        Me.TabMaterialsOn = New System.Windows.Forms.TabPage()
        Me.DgvMaterials = New System.Windows.Forms.DataGridView()
        Me.TabMaterialsOff = New System.Windows.Forms.TabPage()
        Me.DGVMaterialsOff = New System.Windows.Forms.DataGridView()
        Me.TabMaterialsAlarm = New System.Windows.Forms.TabPage()
        Me.DGVAlarm = New System.Windows.Forms.DataGridView()
        Me.BtnExcelLoad = New System.Windows.Forms.Button()
        Me.BtnAddMaterial = New System.Windows.Forms.Button()
        Me.BtnUpdateMaterial = New System.Windows.Forms.Button()
        Me.BtnDeleteMaterial = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpButtons = New System.Windows.Forms.GroupBox()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrpMaterials.SuspendLayout()
        Me.TabMaterials.SuspendLayout()
        Me.TabMaterialsOn.SuspendLayout()
        CType(Me.DgvMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMaterialsOff.SuspendLayout()
        CType(Me.DGVMaterialsOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMaterialsAlarm.SuspendLayout()
        CType(Me.DGVAlarm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpButtons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpMaterials
        '
        Me.GrpMaterials.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpMaterials.Controls.Add(Me.TabMaterials)
        Me.GrpMaterials.Location = New System.Drawing.Point(14, 19)
        Me.GrpMaterials.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.GrpMaterials.Name = "GrpMaterials"
        Me.GrpMaterials.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.GrpMaterials.Size = New System.Drawing.Size(1157, 506)
        Me.GrpMaterials.TabIndex = 36
        Me.GrpMaterials.TabStop = False
        Me.GrpMaterials.Text = "قائمة المواد"
        '
        'TabMaterials
        '
        Me.TabMaterials.Controls.Add(Me.TabMaterialsOn)
        Me.TabMaterials.Controls.Add(Me.TabMaterialsOff)
        Me.TabMaterials.Controls.Add(Me.TabMaterialsAlarm)
        Me.TabMaterials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMaterials.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMaterials.Location = New System.Drawing.Point(5, 26)
        Me.TabMaterials.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabMaterials.Name = "TabMaterials"
        Me.TabMaterials.RightToLeftLayout = True
        Me.TabMaterials.SelectedIndex = 0
        Me.TabMaterials.Size = New System.Drawing.Size(1147, 473)
        Me.TabMaterials.TabIndex = 1
        '
        'TabMaterialsOn
        '
        Me.TabMaterialsOn.Controls.Add(Me.PictureBox1)
        Me.TabMaterialsOn.Controls.Add(Me.Label1)
        Me.TabMaterialsOn.Controls.Add(Me.TxtFilter)
        Me.TabMaterialsOn.Controls.Add(Me.DgvMaterials)
        Me.TabMaterialsOn.Location = New System.Drawing.Point(4, 29)
        Me.TabMaterialsOn.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabMaterialsOn.Name = "TabMaterialsOn"
        Me.TabMaterialsOn.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabMaterialsOn.Size = New System.Drawing.Size(1139, 440)
        Me.TabMaterialsOn.TabIndex = 0
        Me.TabMaterialsOn.Text = "قائمة المواد المفعلة"
        Me.TabMaterialsOn.UseVisualStyleBackColor = True
        '
        'DgvMaterials
        '
        Me.DgvMaterials.AllowUserToAddRows = False
        Me.DgvMaterials.AllowUserToDeleteRows = False
        Me.DgvMaterials.AllowUserToResizeColumns = False
        Me.DgvMaterials.AllowUserToResizeRows = False
        Me.DgvMaterials.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvMaterials.BackgroundColor = System.Drawing.Color.White
        Me.DgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMaterials.Location = New System.Drawing.Point(5, 43)
        Me.DgvMaterials.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.DgvMaterials.MultiSelect = False
        Me.DgvMaterials.Name = "DgvMaterials"
        Me.DgvMaterials.ReadOnly = True
        Me.DgvMaterials.RowHeadersVisible = False
        Me.DgvMaterials.RowHeadersWidth = 51
        Me.DgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMaterials.Size = New System.Drawing.Size(1129, 390)
        Me.DgvMaterials.TabIndex = 0
        '
        'TabMaterialsOff
        '
        Me.TabMaterialsOff.Controls.Add(Me.DGVMaterialsOff)
        Me.TabMaterialsOff.Location = New System.Drawing.Point(4, 29)
        Me.TabMaterialsOff.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabMaterialsOff.Name = "TabMaterialsOff"
        Me.TabMaterialsOff.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabMaterialsOff.Size = New System.Drawing.Size(1139, 446)
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
        Me.DGVMaterialsOff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVMaterialsOff.Location = New System.Drawing.Point(5, 7)
        Me.DGVMaterialsOff.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.DGVMaterialsOff.MultiSelect = False
        Me.DGVMaterialsOff.Name = "DGVMaterialsOff"
        Me.DGVMaterialsOff.ReadOnly = True
        Me.DGVMaterialsOff.RowHeadersVisible = False
        Me.DGVMaterialsOff.RowHeadersWidth = 51
        Me.DGVMaterialsOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMaterialsOff.Size = New System.Drawing.Size(1129, 432)
        Me.DGVMaterialsOff.TabIndex = 1
        '
        'TabMaterialsAlarm
        '
        Me.TabMaterialsAlarm.BackColor = System.Drawing.Color.White
        Me.TabMaterialsAlarm.Controls.Add(Me.DGVAlarm)
        Me.TabMaterialsAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.TabMaterialsAlarm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabMaterialsAlarm.Location = New System.Drawing.Point(4, 29)
        Me.TabMaterialsAlarm.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabMaterialsAlarm.Name = "TabMaterialsAlarm"
        Me.TabMaterialsAlarm.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabMaterialsAlarm.Size = New System.Drawing.Size(1139, 446)
        Me.TabMaterialsAlarm.TabIndex = 2
        Me.TabMaterialsAlarm.Tag = ""
        Me.TabMaterialsAlarm.Text = "قائمة التنبيهات"
        '
        'DGVAlarm
        '
        Me.DGVAlarm.AllowUserToAddRows = False
        Me.DGVAlarm.AllowUserToDeleteRows = False
        Me.DGVAlarm.AllowUserToResizeColumns = False
        Me.DGVAlarm.AllowUserToResizeRows = False
        Me.DGVAlarm.BackgroundColor = System.Drawing.Color.White
        Me.DGVAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAlarm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAlarm.Location = New System.Drawing.Point(5, 7)
        Me.DGVAlarm.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.DGVAlarm.MultiSelect = False
        Me.DGVAlarm.Name = "DGVAlarm"
        Me.DGVAlarm.ReadOnly = True
        Me.DGVAlarm.RowHeadersVisible = False
        Me.DGVAlarm.RowHeadersWidth = 51
        Me.DGVAlarm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAlarm.Size = New System.Drawing.Size(1129, 432)
        Me.DGVAlarm.TabIndex = 2
        '
        'BtnExcelLoad
        '
        Me.BtnExcelLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcelLoad.BackColor = System.Drawing.Color.White
        Me.BtnExcelLoad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnExcelLoad.Image = CType(resources.GetObject("BtnExcelLoad.Image"), System.Drawing.Image)
        Me.BtnExcelLoad.Location = New System.Drawing.Point(497, 25)
        Me.BtnExcelLoad.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnExcelLoad.Name = "BtnExcelLoad"
        Me.BtnExcelLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnExcelLoad.Size = New System.Drawing.Size(155, 59)
        Me.BtnExcelLoad.TabIndex = 37
        Me.BtnExcelLoad.Text = "استخراج المعلومات"
        Me.BtnExcelLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnExcelLoad.UseVisualStyleBackColor = False
        '
        'BtnAddMaterial
        '
        Me.BtnAddMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddMaterial.BackColor = System.Drawing.Color.White
        Me.BtnAddMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddMaterial.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnAddMaterial.Location = New System.Drawing.Point(992, 25)
        Me.BtnAddMaterial.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnAddMaterial.Name = "BtnAddMaterial"
        Me.BtnAddMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAddMaterial.Size = New System.Drawing.Size(155, 59)
        Me.BtnAddMaterial.TabIndex = 35
        Me.BtnAddMaterial.Text = "اضافة مادة"
        Me.BtnAddMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddMaterial.UseVisualStyleBackColor = False
        '
        'BtnUpdateMaterial
        '
        Me.BtnUpdateMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUpdateMaterial.BackColor = System.Drawing.Color.White
        Me.BtnUpdateMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnUpdateMaterial.Image = CType(resources.GetObject("BtnUpdateMaterial.Image"), System.Drawing.Image)
        Me.BtnUpdateMaterial.Location = New System.Drawing.Point(827, 25)
        Me.BtnUpdateMaterial.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnUpdateMaterial.Name = "BtnUpdateMaterial"
        Me.BtnUpdateMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUpdateMaterial.Size = New System.Drawing.Size(155, 59)
        Me.BtnUpdateMaterial.TabIndex = 34
        Me.BtnUpdateMaterial.Text = "تعديل مادة"
        Me.BtnUpdateMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUpdateMaterial.UseVisualStyleBackColor = False
        '
        'BtnDeleteMaterial
        '
        Me.BtnDeleteMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteMaterial.BackColor = System.Drawing.Color.White
        Me.BtnDeleteMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnDeleteMaterial.Image = Global.TRM.My.Resources.Resources.delete48
        Me.BtnDeleteMaterial.Location = New System.Drawing.Point(662, 25)
        Me.BtnDeleteMaterial.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnDeleteMaterial.Name = "BtnDeleteMaterial"
        Me.BtnDeleteMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeleteMaterial.Size = New System.Drawing.Size(155, 59)
        Me.BtnDeleteMaterial.TabIndex = 33
        Me.BtnDeleteMaterial.Text = "حذف مادة"
        Me.BtnDeleteMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDeleteMaterial.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(8, 25)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(155, 59)
        Me.BtnClose.TabIndex = 32
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'GrpButtons
        '
        Me.GrpButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpButtons.Controls.Add(Me.BtnClose)
        Me.GrpButtons.Controls.Add(Me.BtnExcelLoad)
        Me.GrpButtons.Controls.Add(Me.BtnAddMaterial)
        Me.GrpButtons.Controls.Add(Me.BtnDeleteMaterial)
        Me.GrpButtons.Controls.Add(Me.BtnUpdateMaterial)
        Me.GrpButtons.Location = New System.Drawing.Point(14, 525)
        Me.GrpButtons.Name = "GrpButtons"
        Me.GrpButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpButtons.Size = New System.Drawing.Size(1157, 97)
        Me.GrpButtons.TabIndex = 38
        Me.GrpButtons.TabStop = False
        '
        'TxtFilter
        '
        Me.TxtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFilter.Location = New System.Drawing.Point(935, 10)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(158, 26)
        Me.TxtFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1099, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "بحث"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.TRM.My.Resources.Resources.Cancel48
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(903, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FrmMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1186, 631)
        Me.Controls.Add(Me.GrpButtons)
        Me.Controls.Add(Me.GrpMaterials)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.MaximizeBox = False
        Me.Name = "FrmMaterials"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "المواد"
        Me.GrpMaterials.ResumeLayout(False)
        Me.TabMaterials.ResumeLayout(False)
        Me.TabMaterialsOn.ResumeLayout(False)
        Me.TabMaterialsOn.PerformLayout()
        CType(Me.DgvMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMaterialsOff.ResumeLayout(False)
        CType(Me.DGVMaterialsOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMaterialsAlarm.ResumeLayout(False)
        CType(Me.DGVAlarm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpButtons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpMaterials As GroupBox
    Friend WithEvents TabMaterials As TabControl
    Friend WithEvents TabMaterialsOn As TabPage
    Friend WithEvents DgvMaterials As DataGridView
    Friend WithEvents TabMaterialsOff As TabPage
    Friend WithEvents DGVMaterialsOff As DataGridView
    Friend WithEvents BtnAddMaterial As Button
    Friend WithEvents BtnUpdateMaterial As Button
    Friend WithEvents BtnDeleteMaterial As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TabMaterialsAlarm As TabPage
    Friend WithEvents BtnExcelLoad As Button
    Friend WithEvents GrpButtons As GroupBox
    Friend WithEvents DGVAlarm As DataGridView
    Friend WithEvents TxtFilter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
