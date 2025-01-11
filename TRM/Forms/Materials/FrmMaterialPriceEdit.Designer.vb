<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaterialPriceEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaterialPriceEdit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumPrice = New System.Windows.Forms.NumericUpDown()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.NumDiscount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumMainPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMainPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "التخفيض %"
        '
        'NumPrice
        '
        Me.NumPrice.DecimalPlaces = 2
        Me.NumPrice.Location = New System.Drawing.Point(14, 81)
        Me.NumPrice.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.NumPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumPrice.Name = "NumPrice"
        Me.NumPrice.ReadOnly = True
        Me.NumPrice.Size = New System.Drawing.Size(111, 26)
        Me.NumPrice.TabIndex = 1
        Me.NumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(14, 115)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(111, 45)
        Me.BtnSave.TabIndex = 55
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'NumDiscount
        '
        Me.NumDiscount.DecimalPlaces = 2
        Me.NumDiscount.Location = New System.Drawing.Point(14, 47)
        Me.NumDiscount.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.NumDiscount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumDiscount.Name = "NumDiscount"
        Me.NumDiscount.Size = New System.Drawing.Size(111, 26)
        Me.NumDiscount.TabIndex = 56
        Me.NumDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "النهائي"
        '
        'NumMainPrice
        '
        Me.NumMainPrice.DecimalPlaces = 2
        Me.NumMainPrice.Location = New System.Drawing.Point(14, 13)
        Me.NumMainPrice.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.NumMainPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumMainPrice.Name = "NumMainPrice"
        Me.NumMainPrice.Size = New System.Drawing.Size(111, 26)
        Me.NumMainPrice.TabIndex = 59
        Me.NumMainPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "السعر"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = Global.TRM.My.Resources.Resources.delete48
        Me.BtnCancel.Location = New System.Drawing.Point(135, 115)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(50, 45)
        Me.BtnCancel.TabIndex = 60
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmMaterialPriceEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(199, 169)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.NumMainPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumDiscount)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.NumPrice)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMaterialPriceEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMainPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NumPrice As NumericUpDown
    Friend WithEvents BtnSave As Button
    Friend WithEvents NumDiscount As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumMainPrice As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancel As Button
End Class
