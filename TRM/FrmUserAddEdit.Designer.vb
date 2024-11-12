<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserAddEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserAddEdit))
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.GrpDetails = New System.Windows.Forms.GroupBox()
        Me.StatusSwitch = New System.Windows.Forms.PictureBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblUserLvl = New System.Windows.Forms.Label()
        Me.NumUserLvl = New System.Windows.Forms.NumericUpDown()
        Me.LblPassWord = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassWord = New System.Windows.Forms.TextBox()
        Me.BtnUserAU = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpDetails.SuspendLayout()
        CType(Me.StatusSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUserLvl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Location = New System.Drawing.Point(140, 23)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUserName.Size = New System.Drawing.Size(105, 19)
        Me.LblUserName.TabIndex = 0
        Me.LblUserName.Text = "שם משתמש :"
        '
        'GrpDetails
        '
        Me.GrpDetails.Controls.Add(Me.StatusSwitch)
        Me.GrpDetails.Controls.Add(Me.TxtPhone)
        Me.GrpDetails.Controls.Add(Me.LblPhone)
        Me.GrpDetails.Controls.Add(Me.LblUserLvl)
        Me.GrpDetails.Controls.Add(Me.NumUserLvl)
        Me.GrpDetails.Controls.Add(Me.LblPassWord)
        Me.GrpDetails.Controls.Add(Me.TxtUserName)
        Me.GrpDetails.Controls.Add(Me.TxtPassWord)
        Me.GrpDetails.Controls.Add(Me.LblUserName)
        Me.GrpDetails.Location = New System.Drawing.Point(13, 13)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpDetails.Size = New System.Drawing.Size(237, 138)
        Me.GrpDetails.TabIndex = 1
        Me.GrpDetails.TabStop = False
        Me.GrpDetails.Text = "פרטי משתמש"
        '
        'StatusSwitch
        '
        Me.StatusSwitch.Image = CType(resources.GetObject("StatusSwitch.Image"), System.Drawing.Image)
        Me.StatusSwitch.Location = New System.Drawing.Point(13, 75)
        Me.StatusSwitch.Name = "StatusSwitch"
        Me.StatusSwitch.Size = New System.Drawing.Size(49, 21)
        Me.StatusSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StatusSwitch.TabIndex = 44
        Me.StatusSwitch.TabStop = False
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(13, 103)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(111, 26)
        Me.TxtPhone.TabIndex = 40
        Me.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Location = New System.Drawing.Point(147, 107)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblPhone.Size = New System.Drawing.Size(95, 19)
        Me.LblPhone.TabIndex = 39
        Me.LblPhone.Text = "טלפון עובד :"
        '
        'LblUserLvl
        '
        Me.LblUserLvl.AutoSize = True
        Me.LblUserLvl.Location = New System.Drawing.Point(141, 78)
        Me.LblUserLvl.Name = "LblUserLvl"
        Me.LblUserLvl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUserLvl.Size = New System.Drawing.Size(103, 19)
        Me.LblUserLvl.TabIndex = 32
        Me.LblUserLvl.Text = "רמת שליטה :"
        '
        'NumUserLvl
        '
        Me.NumUserLvl.Location = New System.Drawing.Point(69, 75)
        Me.NumUserLvl.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumUserLvl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumUserLvl.Name = "NumUserLvl"
        Me.NumUserLvl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumUserLvl.Size = New System.Drawing.Size(56, 26)
        Me.NumUserLvl.TabIndex = 34
        Me.NumUserLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumUserLvl.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'LblPassWord
        '
        Me.LblPassWord.AutoSize = True
        Me.LblPassWord.Location = New System.Drawing.Point(167, 51)
        Me.LblPassWord.Name = "LblPassWord"
        Me.LblPassWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblPassWord.Size = New System.Drawing.Size(70, 19)
        Me.LblPassWord.TabIndex = 31
        Me.LblPassWord.Text = "סיסמה :"
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(13, 20)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(111, 26)
        Me.TxtUserName.TabIndex = 3
        Me.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPassWord
        '
        Me.TxtPassWord.Location = New System.Drawing.Point(13, 48)
        Me.TxtPassWord.Name = "TxtPassWord"
        Me.TxtPassWord.Size = New System.Drawing.Size(111, 26)
        Me.TxtPassWord.TabIndex = 33
        Me.TxtPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnUserAU
        '
        Me.BtnUserAU.BackColor = System.Drawing.Color.White
        Me.BtnUserAU.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnUserAU.Image = CType(resources.GetObject("BtnUserAU.Image"), System.Drawing.Image)
        Me.BtnUserAU.Location = New System.Drawing.Point(12, 165)
        Me.BtnUserAU.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUserAU.Name = "BtnUserAU"
        Me.BtnUserAU.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUserAU.Size = New System.Drawing.Size(117, 58)
        Me.BtnUserAU.TabIndex = 30
        Me.BtnUserAU.Text = "הוספת משתמש"
        Me.BtnUserAU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUserAU.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(133, 165)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(117, 58)
        Me.BtnClose.TabIndex = 29
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmUserAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(264, 234)
        Me.Controls.Add(Me.BtnUserAU)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrpDetails)
        Me.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserAddEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת משתמש חדש"
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        CType(Me.StatusSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUserLvl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents GrpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents BtnUserAU As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents LblPassWord As System.Windows.Forms.Label
    Friend WithEvents LblUserLvl As System.Windows.Forms.Label
    Friend WithEvents TxtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents NumUserLvl As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents LblPhone As System.Windows.Forms.Label
    Friend WithEvents StatusSwitch As System.Windows.Forms.PictureBox
End Class
