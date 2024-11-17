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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUnits))
        Me.Grp = New System.Windows.Forms.GroupBox()
        Me.DGVUnits = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Grp.SuspendLayout()
        CType(Me.DGVUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grp
        '
        Me.Grp.Controls.Add(Me.DGVUnits)
        Me.Grp.Location = New System.Drawing.Point(12, 12)
        Me.Grp.Name = "Grp"
        Me.Grp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Grp.Size = New System.Drawing.Size(474, 395)
        Me.Grp.TabIndex = 53
        Me.Grp.TabStop = False
        '
        'DGVUnits
        '
        Me.DGVUnits.BackgroundColor = System.Drawing.Color.White
        Me.DGVUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUnits.Location = New System.Drawing.Point(228, 19)
        Me.DGVUnits.Name = "DGVUnits"
        Me.DGVUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVUnits.RowHeadersVisible = False
        Me.DGVUnits.Size = New System.Drawing.Size(240, 150)
        Me.DGVUnits.TabIndex = 66
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(493, 192)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(140, 55)
        Me.BtnAdd.TabIndex = 52
        Me.BtnAdd.Text = "הדפסה"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(493, 253)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(140, 55)
        Me.BtnCancel.TabIndex = 51
        Me.BtnCancel.Text = "סגירה"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 418)
        Me.Controls.Add(Me.Grp)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUnits"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Units"
        Me.Grp.ResumeLayout(False)
        CType(Me.DGVUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Public WithEvents Grp As System.Windows.Forms.GroupBox
    Friend WithEvents DGVUnits As DataGridView
End Class
