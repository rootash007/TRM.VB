<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCarKind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddCarKind))
        Me.LblNewCarKind = New System.Windows.Forms.Label()
        Me.LblNewCarModel = New System.Windows.Forms.Label()
        Me.LblNewCarType = New System.Windows.Forms.Label()
        Me.LblCarKindSelect = New System.Windows.Forms.Label()
        Me.LblCarModelSelect = New System.Windows.Forms.Label()
        Me.LblCarTypeSelect = New System.Windows.Forms.Label()
        Me.GrpActionSelect = New System.Windows.Forms.GroupBox()
        Me.ChkAddKind = New System.Windows.Forms.CheckBox()
        Me.ChkAddModel = New System.Windows.Forms.CheckBox()
        Me.ChkAddType = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GrpAddNew = New System.Windows.Forms.GroupBox()
        Me.TxtNewKind = New System.Windows.Forms.TextBox()
        Me.TxtNewModel = New System.Windows.Forms.TextBox()
        Me.TxtNewType = New System.Windows.Forms.TextBox()
        Me.GrpActionSelect.SuspendLayout()
        Me.GrpAddNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNewCarKind
        '
        Me.LblNewCarKind.AutoSize = True
        Me.LblNewCarKind.Location = New System.Drawing.Point(158, 22)
        Me.LblNewCarKind.Name = "LblNewCarKind"
        Me.LblNewCarKind.Size = New System.Drawing.Size(87, 13)
        Me.LblNewCarKind.TabIndex = 0
        Me.LblNewCarKind.Text = "שם סוג רכב חדש"
        '
        'LblNewCarModel
        '
        Me.LblNewCarModel.AutoSize = True
        Me.LblNewCarModel.Location = New System.Drawing.Point(171, 49)
        Me.LblNewCarModel.Name = "LblNewCarModel"
        Me.LblNewCarModel.Size = New System.Drawing.Size(74, 13)
        Me.LblNewCarModel.TabIndex = 1
        Me.LblNewCarModel.Text = "שם ייצרן חדש"
        '
        'LblNewCarType
        '
        Me.LblNewCarType.AutoSize = True
        Me.LblNewCarType.Location = New System.Drawing.Point(156, 76)
        Me.LblNewCarType.Name = "LblNewCarType"
        Me.LblNewCarType.Size = New System.Drawing.Size(89, 13)
        Me.LblNewCarType.TabIndex = 2
        Me.LblNewCarType.Text = "שם גדם רכב חדש"
        '
        'LblCarKindSelect
        '
        Me.LblCarKindSelect.AutoSize = True
        Me.LblCarKindSelect.Location = New System.Drawing.Point(432, 22)
        Me.LblCarKindSelect.Name = "LblCarKindSelect"
        Me.LblCarKindSelect.Size = New System.Drawing.Size(78, 13)
        Me.LblCarKindSelect.TabIndex = 3
        Me.LblCarKindSelect.Text = "בחירת סוג רכב"
        '
        'LblCarModelSelect
        '
        Me.LblCarModelSelect.AutoSize = True
        Me.LblCarModelSelect.Location = New System.Drawing.Point(445, 49)
        Me.LblCarModelSelect.Name = "LblCarModelSelect"
        Me.LblCarModelSelect.Size = New System.Drawing.Size(65, 13)
        Me.LblCarModelSelect.TabIndex = 4
        Me.LblCarModelSelect.Text = "בחירת ייצרן"
        '
        'LblCarTypeSelect
        '
        Me.LblCarTypeSelect.AutoSize = True
        Me.LblCarTypeSelect.Location = New System.Drawing.Point(436, 76)
        Me.LblCarTypeSelect.Name = "LblCarTypeSelect"
        Me.LblCarTypeSelect.Size = New System.Drawing.Size(74, 13)
        Me.LblCarTypeSelect.TabIndex = 5
        Me.LblCarTypeSelect.Text = "רשימת דגמים"
        '
        'GrpActionSelect
        '
        Me.GrpActionSelect.Controls.Add(Me.ChkAddType)
        Me.GrpActionSelect.Controls.Add(Me.ChkAddModel)
        Me.GrpActionSelect.Controls.Add(Me.ChkAddKind)
        Me.GrpActionSelect.Location = New System.Drawing.Point(12, 12)
        Me.GrpActionSelect.Name = "GrpActionSelect"
        Me.GrpActionSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpActionSelect.Size = New System.Drawing.Size(516, 65)
        Me.GrpActionSelect.TabIndex = 6
        Me.GrpActionSelect.TabStop = False
        Me.GrpActionSelect.Text = "בחירת סוג פעולה"
        '
        'ChkAddKind
        '
        Me.ChkAddKind.AutoSize = True
        Me.ChkAddKind.Location = New System.Drawing.Point(368, 28)
        Me.ChkAddKind.Name = "ChkAddKind"
        Me.ChkAddKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAddKind.Size = New System.Drawing.Size(123, 17)
        Me.ChkAddKind.TabIndex = 0
        Me.ChkAddKind.Text = "הוספת סוג רכב חדש"
        Me.ChkAddKind.UseVisualStyleBackColor = True
        '
        'ChkAddModel
        '
        Me.ChkAddModel.AutoSize = True
        Me.ChkAddModel.Location = New System.Drawing.Point(206, 28)
        Me.ChkAddModel.Name = "ChkAddModel"
        Me.ChkAddModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAddModel.Size = New System.Drawing.Size(110, 17)
        Me.ChkAddModel.TabIndex = 1
        Me.ChkAddModel.Text = "הוספת ייצרן חדש"
        Me.ChkAddModel.UseVisualStyleBackColor = True
        '
        'ChkAddType
        '
        Me.ChkAddType.AutoSize = True
        Me.ChkAddType.Location = New System.Drawing.Point(29, 28)
        Me.ChkAddType.Name = "ChkAddType"
        Me.ChkAddType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAddType.Size = New System.Drawing.Size(125, 17)
        Me.ChkAddType.TabIndex = 2
        Me.ChkAddType.Text = "הוספת דגם רכב חדש"
        Me.ChkAddType.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(282, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(282, 46)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(282, 73)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 9
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(441, 195)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 39)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "ביטול"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(350, 195)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 39)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "הוספה"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GrpAddNew
        '
        Me.GrpAddNew.Controls.Add(Me.TxtNewType)
        Me.GrpAddNew.Controls.Add(Me.TxtNewModel)
        Me.GrpAddNew.Controls.Add(Me.TxtNewKind)
        Me.GrpAddNew.Controls.Add(Me.LblNewCarKind)
        Me.GrpAddNew.Controls.Add(Me.LblNewCarModel)
        Me.GrpAddNew.Controls.Add(Me.LblNewCarType)
        Me.GrpAddNew.Controls.Add(Me.ComboBox3)
        Me.GrpAddNew.Controls.Add(Me.LblCarKindSelect)
        Me.GrpAddNew.Controls.Add(Me.LblCarModelSelect)
        Me.GrpAddNew.Controls.Add(Me.ComboBox1)
        Me.GrpAddNew.Controls.Add(Me.ComboBox2)
        Me.GrpAddNew.Controls.Add(Me.LblCarTypeSelect)
        Me.GrpAddNew.Location = New System.Drawing.Point(12, 83)
        Me.GrpAddNew.Name = "GrpAddNew"
        Me.GrpAddNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpAddNew.Size = New System.Drawing.Size(516, 107)
        Me.GrpAddNew.TabIndex = 12
        Me.GrpAddNew.TabStop = False
        '
        'TxtNewKind
        '
        Me.TxtNewKind.Location = New System.Drawing.Point(29, 19)
        Me.TxtNewKind.Name = "TxtNewKind"
        Me.TxtNewKind.Size = New System.Drawing.Size(100, 20)
        Me.TxtNewKind.TabIndex = 10
        Me.TxtNewKind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNewModel
        '
        Me.TxtNewModel.Location = New System.Drawing.Point(29, 46)
        Me.TxtNewModel.Name = "TxtNewModel"
        Me.TxtNewModel.Size = New System.Drawing.Size(100, 20)
        Me.TxtNewModel.TabIndex = 11
        Me.TxtNewModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNewType
        '
        Me.TxtNewType.Location = New System.Drawing.Point(29, 73)
        Me.TxtNewType.Name = "TxtNewType"
        Me.TxtNewType.Size = New System.Drawing.Size(100, 20)
        Me.TxtNewType.TabIndex = 12
        Me.TxtNewType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmAddCarKind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(538, 248)
        Me.Controls.Add(Me.GrpAddNew)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GrpActionSelect)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddCarKind"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAddCarKind"
        Me.GrpActionSelect.ResumeLayout(False)
        Me.GrpActionSelect.PerformLayout()
        Me.GrpAddNew.ResumeLayout(False)
        Me.GrpAddNew.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblNewCarKind As System.Windows.Forms.Label
    Friend WithEvents LblNewCarModel As System.Windows.Forms.Label
    Friend WithEvents LblNewCarType As System.Windows.Forms.Label
    Friend WithEvents LblCarKindSelect As System.Windows.Forms.Label
    Friend WithEvents LblCarModelSelect As System.Windows.Forms.Label
    Friend WithEvents LblCarTypeSelect As System.Windows.Forms.Label
    Friend WithEvents GrpActionSelect As System.Windows.Forms.GroupBox
    Friend WithEvents ChkAddType As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAddModel As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAddKind As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GrpAddNew As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNewType As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewModel As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewKind As System.Windows.Forms.TextBox
End Class
