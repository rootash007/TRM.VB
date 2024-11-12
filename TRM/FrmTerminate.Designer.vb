<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTerminate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTerminate))
        Me.TxtCarId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnTerminate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCarId
        '
        Me.TxtCarId.Location = New System.Drawing.Point(7, 15)
        Me.TxtCarId.Name = "TxtCarId"
        Me.TxtCarId.Size = New System.Drawing.Size(98, 20)
        Me.TxtCarId.TabIndex = 0
        Me.TxtCarId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTerminate)
        Me.GroupBox1.Controls.Add(Me.TxtCarId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(118, 107)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "מספר רכב למחיקה"
        '
        'BtnTerminate
        '
        Me.BtnTerminate.BackColor = System.Drawing.Color.White
        Me.BtnTerminate.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnTerminate.Image = CType(resources.GetObject("BtnTerminate.Image"), System.Drawing.Image)
        Me.BtnTerminate.Location = New System.Drawing.Point(7, 41)
        Me.BtnTerminate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnTerminate.Name = "BtnTerminate"
        Me.BtnTerminate.Size = New System.Drawing.Size(98, 55)
        Me.BtnTerminate.TabIndex = 4
        Me.BtnTerminate.Text = "הסרה"
        Me.BtnTerminate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnTerminate.UseVisualStyleBackColor = False
        '
        'FrmTerminate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(144, 129)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTerminate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "מחיקת רכב"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtCarId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTerminate As System.Windows.Forms.Button
End Class
