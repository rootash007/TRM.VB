<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportProductData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportProductData))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVProductMaterials = New System.Windows.Forms.DataGridView()
        Me.CmbProducts = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BtnCarBack = New System.Windows.Forms.Button()
        Me.TxtBlocks = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProductMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVProductMaterials)
        Me.GroupBox1.Controls.Add(Me.CmbProducts)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.BtnCarBack)
        Me.GroupBox1.Controls.Add(Me.TxtBlocks)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(563, 475)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ImportData"
        '
        'DGVProductMaterials
        '
        Me.DGVProductMaterials.BackgroundColor = System.Drawing.Color.White
        Me.DGVProductMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductMaterials.Location = New System.Drawing.Point(223, 95)
        Me.DGVProductMaterials.Name = "DGVProductMaterials"
        Me.DGVProductMaterials.RowHeadersWidth = 51
        Me.DGVProductMaterials.RowTemplate.Height = 24
        Me.DGVProductMaterials.Size = New System.Drawing.Size(240, 150)
        Me.DGVProductMaterials.TabIndex = 7
        '
        'CmbProducts
        '
        Me.CmbProducts.FormattingEnabled = True
        Me.CmbProducts.Location = New System.Drawing.Point(305, 22)
        Me.CmbProducts.Name = "CmbProducts"
        Me.CmbProducts.Size = New System.Drawing.Size(121, 24)
        Me.CmbProducts.TabIndex = 6
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(305, 67)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 5
        '
        'BtnCarBack
        '
        Me.BtnCarBack.BackColor = System.Drawing.Color.White
        Me.BtnCarBack.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCarBack.Image = CType(resources.GetObject("BtnCarBack.Image"), System.Drawing.Image)
        Me.BtnCarBack.Location = New System.Drawing.Point(223, 262)
        Me.BtnCarBack.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnCarBack.Name = "BtnCarBack"
        Me.BtnCarBack.Size = New System.Drawing.Size(131, 68)
        Me.BtnCarBack.TabIndex = 4
        Me.BtnCarBack.Text = "שחזור"
        Me.BtnCarBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCarBack.UseVisualStyleBackColor = False
        '
        'TxtBlocks
        '
        Me.TxtBlocks.Location = New System.Drawing.Point(71, 24)
        Me.TxtBlocks.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBlocks.Name = "TxtBlocks"
        Me.TxtBlocks.Size = New System.Drawing.Size(129, 22)
        Me.TxtBlocks.TabIndex = 0
        Me.TxtBlocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmImportProductData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 521)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportProductData"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Product Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVProductMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCarBack As System.Windows.Forms.Button
    Friend WithEvents TxtBlocks As System.Windows.Forms.TextBox
    Friend WithEvents CmbProducts As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DGVProductMaterials As DataGridView
End Class
