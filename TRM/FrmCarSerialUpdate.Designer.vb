<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarSerialUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarSerialUpdate))
        Me.LblOldCarSerial = New System.Windows.Forms.Label()
        Me.TxtOldCarSerial = New System.Windows.Forms.TextBox()
        Me.TxtNewCarSerial = New System.Windows.Forms.TextBox()
        Me.LblNewCarSerial = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblOldCarSerial
        '
        Me.LblOldCarSerial.AutoSize = True
        Me.LblOldCarSerial.Location = New System.Drawing.Point(6, 9)
        Me.LblOldCarSerial.Name = "LblOldCarSerial"
        Me.LblOldCarSerial.Size = New System.Drawing.Size(104, 13)
        Me.LblOldCarSerial.TabIndex = 0
        Me.LblOldCarSerial.Text = "מספר ביומן נוכחי :"
        '
        'TxtOldCarSerial
        '
        Me.TxtOldCarSerial.Location = New System.Drawing.Point(142, 6)
        Me.TxtOldCarSerial.Name = "TxtOldCarSerial"
        Me.TxtOldCarSerial.ReadOnly = True
        Me.TxtOldCarSerial.Size = New System.Drawing.Size(113, 21)
        Me.TxtOldCarSerial.TabIndex = 4
        Me.TxtOldCarSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNewCarSerial
        '
        Me.TxtNewCarSerial.Location = New System.Drawing.Point(142, 40)
        Me.TxtNewCarSerial.MaxLength = 10
        Me.TxtNewCarSerial.Name = "TxtNewCarSerial"
        Me.TxtNewCarSerial.Size = New System.Drawing.Size(113, 21)
        Me.TxtNewCarSerial.TabIndex = 0
        Me.TxtNewCarSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblNewCarSerial
        '
        Me.LblNewCarSerial.AutoSize = True
        Me.LblNewCarSerial.Location = New System.Drawing.Point(6, 43)
        Me.LblNewCarSerial.Name = "LblNewCarSerial"
        Me.LblNewCarSerial.Size = New System.Drawing.Size(101, 13)
        Me.LblNewCarSerial.TabIndex = 4
        Me.LblNewCarSerial.Text = "מספר ביומן חדש :"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(49, 73)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 55)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "שמירה"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(155, 73)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmCarSerialUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(267, 143)
        Me.Controls.Add(Me.TxtNewCarSerial)
        Me.Controls.Add(Me.LblNewCarSerial)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtOldCarSerial)
        Me.Controls.Add(Me.LblOldCarSerial)
        Me.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCarSerialUpdate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הגדרת מספר ביומן"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblOldCarSerial As System.Windows.Forms.Label
    Friend WithEvents TxtOldCarSerial As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtNewCarSerial As System.Windows.Forms.TextBox
    Friend WithEvents LblNewCarSerial As System.Windows.Forms.Label
End Class
