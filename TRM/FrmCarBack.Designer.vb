<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarBack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarBack))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCarBack = New System.Windows.Forms.Button()
        Me.TxtCarId = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCarBack)
        Me.GroupBox1.Controls.Add(Me.TxtCarId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(143, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "מספר רכב לשחזור"
        '
        'BtnCarBack
        '
        Me.BtnCarBack.BackColor = System.Drawing.Color.White
        Me.BtnCarBack.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCarBack.Image = CType(resources.GetObject("BtnCarBack.Image"), System.Drawing.Image)
        Me.BtnCarBack.Location = New System.Drawing.Point(22, 41)
        Me.BtnCarBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCarBack.Name = "BtnCarBack"
        Me.BtnCarBack.Size = New System.Drawing.Size(98, 55)
        Me.BtnCarBack.TabIndex = 4
        Me.BtnCarBack.Text = "שחזור"
        Me.BtnCarBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCarBack.UseVisualStyleBackColor = False
        '
        'TxtCarId
        '
        Me.TxtCarId.Location = New System.Drawing.Point(22, 15)
        Me.TxtCarId.Name = "TxtCarId"
        Me.TxtCarId.Size = New System.Drawing.Size(98, 20)
        Me.TxtCarId.TabIndex = 0
        Me.TxtCarId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmCarBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(167, 130)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCarBack"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "שחזור רכב מעסקה"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCarBack As System.Windows.Forms.Button
    Friend WithEvents TxtCarId As System.Windows.Forms.TextBox
End Class
