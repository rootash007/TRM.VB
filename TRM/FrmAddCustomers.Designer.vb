<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddCustomers))
        Me.TxtCInfo = New System.Windows.Forms.TextBox()
        Me.TxtCEmail = New System.Windows.Forms.TextBox()
        Me.TxtCFax = New System.Windows.Forms.TextBox()
        Me.TxtCPhone = New System.Windows.Forms.TextBox()
        Me.TxtCAdress = New System.Windows.Forms.TextBox()
        Me.TxtCId = New System.Windows.Forms.TextBox()
        Me.TxtCContact = New System.Windows.Forms.TextBox()
        Me.TxtCName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblVEmail = New System.Windows.Forms.Label()
        Me.LblVFax = New System.Windows.Forms.Label()
        Me.LblVPhone = New System.Windows.Forms.Label()
        Me.LblVAdress = New System.Windows.Forms.Label()
        Me.LblVId = New System.Windows.Forms.Label()
        Me.LblVContact = New System.Windows.Forms.Label()
        Me.LblVName = New System.Windows.Forms.Label()
        Me.GrpUser = New System.Windows.Forms.GroupBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.StatusSwitch = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpUser.SuspendLayout()
        CType(Me.StatusSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCInfo
        '
        Me.TxtCInfo.Location = New System.Drawing.Point(6, 239)
        Me.TxtCInfo.Name = "TxtCInfo"
        Me.TxtCInfo.Size = New System.Drawing.Size(244, 20)
        Me.TxtCInfo.TabIndex = 38
        '
        'TxtCEmail
        '
        Me.TxtCEmail.Location = New System.Drawing.Point(6, 213)
        Me.TxtCEmail.Name = "TxtCEmail"
        Me.TxtCEmail.Size = New System.Drawing.Size(244, 20)
        Me.TxtCEmail.TabIndex = 37
        '
        'TxtCFax
        '
        Me.TxtCFax.Location = New System.Drawing.Point(6, 187)
        Me.TxtCFax.MaxLength = 11
        Me.TxtCFax.Name = "TxtCFax"
        Me.TxtCFax.Size = New System.Drawing.Size(244, 20)
        Me.TxtCFax.TabIndex = 36
        '
        'TxtCPhone
        '
        Me.TxtCPhone.Location = New System.Drawing.Point(6, 161)
        Me.TxtCPhone.MaxLength = 11
        Me.TxtCPhone.Name = "TxtCPhone"
        Me.TxtCPhone.Size = New System.Drawing.Size(244, 20)
        Me.TxtCPhone.TabIndex = 35
        '
        'TxtCAdress
        '
        Me.TxtCAdress.Location = New System.Drawing.Point(6, 135)
        Me.TxtCAdress.Name = "TxtCAdress"
        Me.TxtCAdress.Size = New System.Drawing.Size(244, 20)
        Me.TxtCAdress.TabIndex = 34
        '
        'TxtCId
        '
        Me.TxtCId.Location = New System.Drawing.Point(6, 109)
        Me.TxtCId.MaxLength = 9
        Me.TxtCId.Name = "TxtCId"
        Me.TxtCId.Size = New System.Drawing.Size(244, 20)
        Me.TxtCId.TabIndex = 33
        '
        'TxtCContact
        '
        Me.TxtCContact.Location = New System.Drawing.Point(6, 83)
        Me.TxtCContact.Name = "TxtCContact"
        Me.TxtCContact.Size = New System.Drawing.Size(244, 20)
        Me.TxtCContact.TabIndex = 32
        '
        'TxtCName
        '
        Me.TxtCName.Location = New System.Drawing.Point(6, 57)
        Me.TxtCName.Name = "TxtCName"
        Me.TxtCName.Size = New System.Drawing.Size(244, 20)
        Me.TxtCName.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "הערות :"
        '
        'LblVEmail
        '
        Me.LblVEmail.AutoSize = True
        Me.LblVEmail.Location = New System.Drawing.Point(281, 216)
        Me.LblVEmail.Name = "LblVEmail"
        Me.LblVEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVEmail.Size = New System.Drawing.Size(49, 13)
        Me.LblVEmail.TabIndex = 29
        Me.LblVEmail.Text = "אימייל :"
        '
        'LblVFax
        '
        Me.LblVFax.AutoSize = True
        Me.LblVFax.Location = New System.Drawing.Point(293, 190)
        Me.LblVFax.Name = "LblVFax"
        Me.LblVFax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVFax.Size = New System.Drawing.Size(37, 13)
        Me.LblVFax.TabIndex = 28
        Me.LblVFax.Text = "פקס :"
        '
        'LblVPhone
        '
        Me.LblVPhone.AutoSize = True
        Me.LblVPhone.Location = New System.Drawing.Point(256, 164)
        Me.LblVPhone.Name = "LblVPhone"
        Me.LblVPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVPhone.Size = New System.Drawing.Size(74, 13)
        Me.LblVPhone.TabIndex = 27
        Me.LblVPhone.Text = "מספר טלפון :"
        '
        'LblVAdress
        '
        Me.LblVAdress.AutoSize = True
        Me.LblVAdress.Location = New System.Drawing.Point(283, 138)
        Me.LblVAdress.Name = "LblVAdress"
        Me.LblVAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVAdress.Size = New System.Drawing.Size(47, 13)
        Me.LblVAdress.TabIndex = 26
        Me.LblVAdress.Text = "כתובת :"
        '
        'LblVId
        '
        Me.LblVId.AutoSize = True
        Me.LblVId.Location = New System.Drawing.Point(273, 112)
        Me.LblVId.Name = "LblVId"
        Me.LblVId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVId.Size = New System.Drawing.Size(57, 13)
        Me.LblVId.TabIndex = 25
        Me.LblVId.Text = "ת.ז / ח.פ :"
        '
        'LblVContact
        '
        Me.LblVContact.AutoSize = True
        Me.LblVContact.Location = New System.Drawing.Point(270, 86)
        Me.LblVContact.Name = "LblVContact"
        Me.LblVContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVContact.Size = New System.Drawing.Size(60, 13)
        Me.LblVContact.TabIndex = 24
        Me.LblVContact.Text = "איש קשר :"
        '
        'LblVName
        '
        Me.LblVName.AutoSize = True
        Me.LblVName.Location = New System.Drawing.Point(271, 60)
        Me.LblVName.Name = "LblVName"
        Me.LblVName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVName.Size = New System.Drawing.Size(59, 13)
        Me.LblVName.TabIndex = 23
        Me.LblVName.Text = "שם לקוח :"
        '
        'GrpUser
        '
        Me.GrpUser.Controls.Add(Me.LblStatus)
        Me.GrpUser.Controls.Add(Me.StatusSwitch)
        Me.GrpUser.Controls.Add(Me.LblVName)
        Me.GrpUser.Controls.Add(Me.TxtCInfo)
        Me.GrpUser.Controls.Add(Me.LblVContact)
        Me.GrpUser.Controls.Add(Me.TxtCEmail)
        Me.GrpUser.Controls.Add(Me.LblVId)
        Me.GrpUser.Controls.Add(Me.TxtCFax)
        Me.GrpUser.Controls.Add(Me.LblVAdress)
        Me.GrpUser.Controls.Add(Me.TxtCPhone)
        Me.GrpUser.Controls.Add(Me.LblVPhone)
        Me.GrpUser.Controls.Add(Me.TxtCAdress)
        Me.GrpUser.Controls.Add(Me.LblVFax)
        Me.GrpUser.Controls.Add(Me.TxtCId)
        Me.GrpUser.Controls.Add(Me.LblVEmail)
        Me.GrpUser.Controls.Add(Me.TxtCContact)
        Me.GrpUser.Controls.Add(Me.Label1)
        Me.GrpUser.Controls.Add(Me.TxtCName)
        Me.GrpUser.Location = New System.Drawing.Point(12, 12)
        Me.GrpUser.Name = "GrpUser"
        Me.GrpUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpUser.Size = New System.Drawing.Size(337, 279)
        Me.GrpUser.TabIndex = 40
        Me.GrpUser.TabStop = False
        Me.GrpUser.Text = "פרטי לקוח"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(116, 28)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(40, 13)
        Me.LblStatus.TabIndex = 42
        Me.LblStatus.Text = "Status"
        '
        'StatusSwitch
        '
        Me.StatusSwitch.Image = CType(resources.GetObject("StatusSwitch.Image"), System.Drawing.Image)
        Me.StatusSwitch.Location = New System.Drawing.Point(162, 19)
        Me.StatusSwitch.Name = "StatusSwitch"
        Me.StatusSwitch.Size = New System.Drawing.Size(88, 32)
        Me.StatusSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StatusSwitch.TabIndex = 41
        Me.StatusSwitch.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(141, 297)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 55)
        Me.BtnAdd.TabIndex = 22
        Me.BtnAdd.Text = "הוספה"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(249, 297)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 21
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmAddCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(361, 364)
        Me.Controls.Add(Me.GrpUser)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddCustomers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת לקוח חדש"
        Me.GrpUser.ResumeLayout(False)
        Me.GrpUser.PerformLayout()
        CType(Me.StatusSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtCInfo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtCFax As System.Windows.Forms.TextBox
    Friend WithEvents TxtCPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtCAdress As System.Windows.Forms.TextBox
    Friend WithEvents TxtCId As System.Windows.Forms.TextBox
    Friend WithEvents TxtCContact As System.Windows.Forms.TextBox
    Friend WithEvents TxtCName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblVEmail As System.Windows.Forms.Label
    Friend WithEvents LblVFax As System.Windows.Forms.Label
    Friend WithEvents LblVPhone As System.Windows.Forms.Label
    Friend WithEvents LblVAdress As System.Windows.Forms.Label
    Friend WithEvents LblVId As System.Windows.Forms.Label
    Friend WithEvents LblVContact As System.Windows.Forms.Label
    Friend WithEvents LblVName As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents GrpUser As System.Windows.Forms.GroupBox
    Friend WithEvents StatusSwitch As System.Windows.Forms.PictureBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
End Class
