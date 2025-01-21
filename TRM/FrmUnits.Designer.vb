<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnits
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUnits))
        Me.Grp = New System.Windows.Forms.GroupBox()
        Me.DGVUnits = New System.Windows.Forms.DataGridView()
        Me.CMSUnits = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.حذفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Grp.SuspendLayout()
        CType(Me.DGVUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp
        '
        Me.Grp.Controls.Add(Me.DGVUnits)
        Me.Grp.Location = New System.Drawing.Point(15, 5)
        Me.Grp.Margin = New System.Windows.Forms.Padding(4)
        Me.Grp.Name = "Grp"
        Me.Grp.Padding = New System.Windows.Forms.Padding(4)
        Me.Grp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Grp.Size = New System.Drawing.Size(330, 223)
        Me.Grp.TabIndex = 53
        Me.Grp.TabStop = False
        '
        'DGVUnits
        '
        Me.DGVUnits.AllowUserToResizeColumns = False
        Me.DGVUnits.AllowUserToResizeRows = False
        Me.DGVUnits.BackgroundColor = System.Drawing.Color.White
        Me.DGVUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUnits.ContextMenuStrip = Me.CMSUnits
        Me.DGVUnits.Location = New System.Drawing.Point(8, 27)
        Me.DGVUnits.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVUnits.Name = "DGVUnits"
        Me.DGVUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVUnits.RowHeadersVisible = False
        Me.DGVUnits.RowHeadersWidth = 51
        Me.DGVUnits.Size = New System.Drawing.Size(309, 185)
        Me.DGVUnits.TabIndex = 66
        '
        'CMSUnits
        '
        Me.CMSUnits.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حذفToolStripMenuItem})
        Me.CMSUnits.Name = "CMSUnits"
        Me.CMSUnits.Size = New System.Drawing.Size(100, 26)
        '
        'حذفToolStripMenuItem
        '
        Me.حذفToolStripMenuItem.Image = Global.TRM.My.Resources.Resources.delete48
        Me.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem"
        Me.حذفToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.حذفToolStripMenuItem.Text = "حذف"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(15, 236)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(158, 56)
        Me.BtnSave.TabIndex = 54
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(183, 236)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(162, 56)
        Me.BtnClose.TabIndex = 55
        Me.BtnClose.Text = "الغاء"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 305)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Grp)
        Me.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUnits"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "وحدات القياس"
        Me.Grp.ResumeLayout(False)
        CType(Me.DGVUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSUnits.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Grp As System.Windows.Forms.GroupBox
    Friend WithEvents DGVUnits As DataGridView
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents CMSUnits As ContextMenuStrip
    Friend WithEvents حذفToolStripMenuItem As ToolStripMenuItem
End Class
