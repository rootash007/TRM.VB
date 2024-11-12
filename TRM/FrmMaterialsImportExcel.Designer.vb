<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMaterialsImportExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaterialsImportExcel))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.DgvMaterials = New System.Windows.Forms.DataGridView()
        Me.LinkLblSelect = New System.Windows.Forms.LinkLabel()
        CType(Me.DgvMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(280, 335)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 55)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAccept
        '
        Me.BtnAccept.BackColor = System.Drawing.Color.White
        Me.BtnAccept.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAccept.Location = New System.Drawing.Point(175, 335)
        Me.BtnAccept.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(101, 55)
        Me.BtnAccept.TabIndex = 2
        Me.BtnAccept.Text = "הוסף לרשימת מוצרים"
        Me.BtnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAccept.UseVisualStyleBackColor = False
        '
        'DgvMaterials
        '
        Me.DgvMaterials.AllowUserToAddRows = False
        Me.DgvMaterials.AllowUserToDeleteRows = False
        Me.DgvMaterials.AllowUserToResizeColumns = False
        Me.DgvMaterials.AllowUserToResizeRows = False
        Me.DgvMaterials.BackgroundColor = System.Drawing.Color.White
        Me.DgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMaterials.Location = New System.Drawing.Point(14, 14)
        Me.DgvMaterials.Margin = New System.Windows.Forms.Padding(5)
        Me.DgvMaterials.MultiSelect = False
        Me.DgvMaterials.Name = "DgvMaterials"
        Me.DgvMaterials.ReadOnly = True
        Me.DgvMaterials.RowHeadersVisible = False
        Me.DgvMaterials.RowHeadersWidth = 51
        Me.DgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMaterials.Size = New System.Drawing.Size(768, 314)
        Me.DgvMaterials.TabIndex = 1
        '
        'LinkLblSelect
        '
        Me.LinkLblSelect.AutoSize = True
        Me.LinkLblSelect.Location = New System.Drawing.Point(12, 335)
        Me.LinkLblSelect.Name = "LinkLblSelect"
        Me.LinkLblSelect.Size = New System.Drawing.Size(61, 16)
        Me.LinkLblSelect.TabIndex = 4
        Me.LinkLblSelect.TabStop = True
        Me.LinkLblSelect.Text = "בחר הכל"
        '
        'FrmMaterialsImportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 402)
        Me.Controls.Add(Me.LinkLblSelect)
        Me.Controls.Add(Me.DgvMaterials)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAccept)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMaterialsImportExcel"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "רשימת מוצרים מאקסיל"
        CType(Me.DgvMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnAccept As System.Windows.Forms.Button
    Friend WithEvents DgvMaterials As DataGridView
    Friend WithEvents LinkLblSelect As LinkLabel
End Class
