<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWhatsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWhatsNew))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkEditDataBase = New System.Windows.Forms.CheckBox()
        Me.ChkShowAgain = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LBWhatsNew = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBWhatsNew)
        Me.GroupBox1.Controls.Add(Me.ChkEditDataBase)
        Me.GroupBox1.Controls.Add(Me.ChkShowAgain)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(342, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ChkEditDataBase
        '
        Me.ChkEditDataBase.AutoSize = True
        Me.ChkEditDataBase.Location = New System.Drawing.Point(211, 144)
        Me.ChkEditDataBase.Name = "ChkEditDataBase"
        Me.ChkEditDataBase.Size = New System.Drawing.Size(120, 17)
        Me.ChkEditDataBase.TabIndex = 11
        Me.ChkEditDataBase.Text = "تعديل قاعدة البيانات"
        Me.ChkEditDataBase.UseVisualStyleBackColor = True
        Me.ChkEditDataBase.Visible = False
        '
        'ChkShowAgain
        '
        Me.ChkShowAgain.AutoSize = True
        Me.ChkShowAgain.Location = New System.Drawing.Point(168, 167)
        Me.ChkShowAgain.Name = "ChkShowAgain"
        Me.ChkShowAgain.Size = New System.Drawing.Size(163, 17)
        Me.ChkShowAgain.TabIndex = 1
        Me.ChkShowAgain.Text = "لا تظهر هذه الرسالة مرة اخرى "
        Me.ChkShowAgain.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(12, 209)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(342, 55)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'LBWhatsNew
        '
        Me.LBWhatsNew.FormattingEnabled = True
        Me.LBWhatsNew.Location = New System.Drawing.Point(6, 16)
        Me.LBWhatsNew.Name = "LBWhatsNew"
        Me.LBWhatsNew.Size = New System.Drawing.Size(330, 121)
        Me.LBWhatsNew.TabIndex = 12
        '
        'FrmWhatsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(366, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWhatsNew"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ماذا جديد !"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkShowAgain As CheckBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents ChkEditDataBase As CheckBox
    Friend WithEvents LBWhatsNew As ListBox
End Class
