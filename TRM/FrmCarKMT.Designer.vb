<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarKMT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarKMT))
        Me.GrpActionSelect = New System.Windows.Forms.GroupBox()
        Me.ChkType = New System.Windows.Forms.CheckBox()
        Me.ChkModel = New System.Windows.Forms.CheckBox()
        Me.ChkKind = New System.Windows.Forms.CheckBox()
        Me.GrpAdd = New System.Windows.Forms.GroupBox()
        Me.LblNewType = New System.Windows.Forms.Label()
        Me.TxtNewType = New System.Windows.Forms.TextBox()
        Me.LblNewModel = New System.Windows.Forms.Label()
        Me.TxtNewModel = New System.Windows.Forms.TextBox()
        Me.CmbModel = New System.Windows.Forms.ComboBox()
        Me.LblTypeList = New System.Windows.Forms.Label()
        Me.LblModelList = New System.Windows.Forms.Label()
        Me.LblNewKind = New System.Windows.Forms.Label()
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.TxtNewKind = New System.Windows.Forms.TextBox()
        Me.CmbKind = New System.Windows.Forms.ComboBox()
        Me.LblKindlist = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GrpActionSelect.SuspendLayout()
        Me.GrpAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpActionSelect
        '
        Me.GrpActionSelect.Controls.Add(Me.ChkType)
        Me.GrpActionSelect.Controls.Add(Me.ChkModel)
        Me.GrpActionSelect.Controls.Add(Me.ChkKind)
        Me.GrpActionSelect.Location = New System.Drawing.Point(12, 12)
        Me.GrpActionSelect.Name = "GrpActionSelect"
        Me.GrpActionSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpActionSelect.Size = New System.Drawing.Size(469, 48)
        Me.GrpActionSelect.TabIndex = 0
        Me.GrpActionSelect.TabStop = False
        Me.GrpActionSelect.Text = "בחירת סוג פעולה"
        '
        'ChkType
        '
        Me.ChkType.AutoSize = True
        Me.ChkType.Location = New System.Drawing.Point(64, 19)
        Me.ChkType.Name = "ChkType"
        Me.ChkType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkType.Size = New System.Drawing.Size(125, 17)
        Me.ChkType.TabIndex = 2
        Me.ChkType.Text = "הוספת גדם רכב חדש"
        Me.ChkType.UseVisualStyleBackColor = True
        '
        'ChkModel
        '
        Me.ChkModel.AutoSize = True
        Me.ChkModel.Location = New System.Drawing.Point(195, 19)
        Me.ChkModel.Name = "ChkModel"
        Me.ChkModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkModel.Size = New System.Drawing.Size(110, 17)
        Me.ChkModel.TabIndex = 1
        Me.ChkModel.Text = "הוספת ייצרן חדש"
        Me.ChkModel.UseVisualStyleBackColor = True
        '
        'ChkKind
        '
        Me.ChkKind.AutoSize = True
        Me.ChkKind.Location = New System.Drawing.Point(311, 19)
        Me.ChkKind.Name = "ChkKind"
        Me.ChkKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkKind.Size = New System.Drawing.Size(123, 17)
        Me.ChkKind.TabIndex = 0
        Me.ChkKind.Text = "הוספת סוג רכב חדש"
        Me.ChkKind.UseVisualStyleBackColor = True
        '
        'GrpAdd
        '
        Me.GrpAdd.Controls.Add(Me.LblNewType)
        Me.GrpAdd.Controls.Add(Me.TxtNewType)
        Me.GrpAdd.Controls.Add(Me.LblNewModel)
        Me.GrpAdd.Controls.Add(Me.TxtNewModel)
        Me.GrpAdd.Controls.Add(Me.CmbModel)
        Me.GrpAdd.Controls.Add(Me.LblTypeList)
        Me.GrpAdd.Controls.Add(Me.LblModelList)
        Me.GrpAdd.Controls.Add(Me.LblNewKind)
        Me.GrpAdd.Controls.Add(Me.CmbType)
        Me.GrpAdd.Controls.Add(Me.TxtNewKind)
        Me.GrpAdd.Controls.Add(Me.CmbKind)
        Me.GrpAdd.Controls.Add(Me.LblKindlist)
        Me.GrpAdd.Location = New System.Drawing.Point(12, 66)
        Me.GrpAdd.Name = "GrpAdd"
        Me.GrpAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpAdd.Size = New System.Drawing.Size(469, 111)
        Me.GrpAdd.TabIndex = 1
        Me.GrpAdd.TabStop = False
        '
        'LblNewType
        '
        Me.LblNewType.AutoSize = True
        Me.LblNewType.Location = New System.Drawing.Point(116, 81)
        Me.LblNewType.Name = "LblNewType"
        Me.LblNewType.Size = New System.Drawing.Size(89, 13)
        Me.LblNewType.TabIndex = 11
        Me.LblNewType.Text = "שם דגם רכב חדש"
        '
        'TxtNewType
        '
        Me.TxtNewType.Location = New System.Drawing.Point(6, 78)
        Me.TxtNewType.Name = "TxtNewType"
        Me.TxtNewType.Size = New System.Drawing.Size(100, 20)
        Me.TxtNewType.TabIndex = 5
        Me.TxtNewType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblNewModel
        '
        Me.LblNewModel.AutoSize = True
        Me.LblNewModel.Location = New System.Drawing.Point(110, 54)
        Me.LblNewModel.Name = "LblNewModel"
        Me.LblNewModel.Size = New System.Drawing.Size(95, 13)
        Me.LblNewModel.TabIndex = 9
        Me.LblNewModel.Text = "שם ייצרן רכב חדש"
        '
        'TxtNewModel
        '
        Me.TxtNewModel.Location = New System.Drawing.Point(6, 51)
        Me.TxtNewModel.Name = "TxtNewModel"
        Me.TxtNewModel.Size = New System.Drawing.Size(100, 20)
        Me.TxtNewModel.TabIndex = 3
        Me.TxtNewModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbModel
        '
        Me.CmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbModel.FormattingEnabled = True
        Me.CmbModel.Location = New System.Drawing.Point(235, 51)
        Me.CmbModel.Name = "CmbModel"
        Me.CmbModel.Size = New System.Drawing.Size(121, 21)
        Me.CmbModel.TabIndex = 2
        '
        'LblTypeList
        '
        Me.LblTypeList.AutoSize = True
        Me.LblTypeList.Location = New System.Drawing.Point(362, 81)
        Me.LblTypeList.Name = "LblTypeList"
        Me.LblTypeList.Size = New System.Drawing.Size(99, 13)
        Me.LblTypeList.TabIndex = 6
        Me.LblTypeList.Text = "רשימת דגמי רכבים"
        '
        'LblModelList
        '
        Me.LblModelList.AutoSize = True
        Me.LblModelList.Location = New System.Drawing.Point(358, 54)
        Me.LblModelList.Name = "LblModelList"
        Me.LblModelList.Size = New System.Drawing.Size(105, 13)
        Me.LblModelList.TabIndex = 5
        Me.LblModelList.Text = "רשימת ייצרני רכבים"
        '
        'LblNewKind
        '
        Me.LblNewKind.AutoSize = True
        Me.LblNewKind.Location = New System.Drawing.Point(118, 25)
        Me.LblNewKind.Name = "LblNewKind"
        Me.LblNewKind.Size = New System.Drawing.Size(87, 13)
        Me.LblNewKind.TabIndex = 4
        Me.LblNewKind.Text = "שם סוג רכב חדש"
        '
        'CmbType
        '
        Me.CmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Location = New System.Drawing.Point(235, 78)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(121, 21)
        Me.CmbType.TabIndex = 4
        '
        'TxtNewKind
        '
        Me.TxtNewKind.Location = New System.Drawing.Point(6, 22)
        Me.TxtNewKind.Name = "TxtNewKind"
        Me.TxtNewKind.Size = New System.Drawing.Size(100, 20)
        Me.TxtNewKind.TabIndex = 1
        Me.TxtNewKind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbKind
        '
        Me.CmbKind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbKind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbKind.FormattingEnabled = True
        Me.CmbKind.Location = New System.Drawing.Point(235, 22)
        Me.CmbKind.Name = "CmbKind"
        Me.CmbKind.Size = New System.Drawing.Size(121, 21)
        Me.CmbKind.TabIndex = 0
        '
        'LblKindlist
        '
        Me.LblKindlist.AutoSize = True
        Me.LblKindlist.Location = New System.Drawing.Point(366, 25)
        Me.LblKindlist.Name = "LblKindlist"
        Me.LblKindlist.Size = New System.Drawing.Size(97, 13)
        Me.LblKindlist.TabIndex = 0
        Me.LblKindlist.Text = "רשימת סוגי רכבים"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(381, 182)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "סגירה"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(277, 182)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 55)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "הוספה"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'FrmCarKMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 247)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GrpAdd)
        Me.Controls.Add(Me.GrpActionSelect)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCarKMT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת סוג/ייצרן/דגם רכב"
        Me.GrpActionSelect.ResumeLayout(False)
        Me.GrpActionSelect.PerformLayout()
        Me.GrpAdd.ResumeLayout(False)
        Me.GrpAdd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActionSelect As System.Windows.Forms.GroupBox
    Friend WithEvents ChkKind As System.Windows.Forms.CheckBox
    Friend WithEvents GrpAdd As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNewKind As System.Windows.Forms.TextBox
    Friend WithEvents CmbKind As System.Windows.Forms.ComboBox
    Friend WithEvents LblKindlist As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents ChkType As System.Windows.Forms.CheckBox
    Friend WithEvents ChkModel As System.Windows.Forms.CheckBox
    Friend WithEvents LblNewType As System.Windows.Forms.Label
    Friend WithEvents TxtNewType As System.Windows.Forms.TextBox
    Friend WithEvents LblNewModel As System.Windows.Forms.Label
    Friend WithEvents TxtNewModel As System.Windows.Forms.TextBox
    Friend WithEvents CmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents LblTypeList As System.Windows.Forms.Label
    Friend WithEvents LblModelList As System.Windows.Forms.Label
    Friend WithEvents LblNewKind As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
End Class
