<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBackUp))
        Me.BtnBackUp = New System.Windows.Forms.Button()
        Me.BtnRestore = New System.Windows.Forms.Button()
        Me.LblBackUpDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnBackUp
        '
        Me.BtnBackUp.BackColor = System.Drawing.Color.White
        Me.BtnBackUp.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnBackUp.Image = CType(resources.GetObject("BtnBackUp.Image"), System.Drawing.Image)
        Me.BtnBackUp.Location = New System.Drawing.Point(65, 56)
        Me.BtnBackUp.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBackUp.Name = "BtnBackUp"
        Me.BtnBackUp.Size = New System.Drawing.Size(115, 55)
        Me.BtnBackUp.TabIndex = 0
        Me.BtnBackUp.Text = "גיבוי נתונים"
        Me.BtnBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnBackUp.UseVisualStyleBackColor = False
        '
        'BtnRestore
        '
        Me.BtnRestore.BackColor = System.Drawing.Color.White
        Me.BtnRestore.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnRestore.Image = CType(resources.GetObject("BtnRestore.Image"), System.Drawing.Image)
        Me.BtnRestore.Location = New System.Drawing.Point(65, 115)
        Me.BtnRestore.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.Size = New System.Drawing.Size(115, 55)
        Me.BtnRestore.TabIndex = 1
        Me.BtnRestore.Text = "שחזור מגיבוי"
        Me.BtnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnRestore.UseVisualStyleBackColor = False
        '
        'LblBackUpDate
        '
        Me.LblBackUpDate.AutoSize = True
        Me.LblBackUpDate.Location = New System.Drawing.Point(85, 29)
        Me.LblBackUpDate.Name = "LblBackUpDate"
        Me.LblBackUpDate.Size = New System.Drawing.Size(74, 13)
        Me.LblBackUpDate.TabIndex = 10
        Me.LblBackUpDate.Text = "LastBackUp"
        Me.LblBackUpDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "גיבוי אחרון בוצע בתאריך :"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(65, 174)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(115, 55)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmBackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(238, 240)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblBackUpDate)
        Me.Controls.Add(Me.BtnBackUp)
        Me.Controls.Add(Me.BtnRestore)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBackUp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "גיבוי / שחזור"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBackUp As System.Windows.Forms.Button
    Friend WithEvents BtnRestore As System.Windows.Forms.Button
    Friend WithEvents LblBackUpDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
