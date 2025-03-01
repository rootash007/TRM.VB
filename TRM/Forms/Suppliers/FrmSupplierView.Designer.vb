<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSupplierView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            'If disposing AndAlso components IsNot Nothing Then
            '    components.Dispose()
            'End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplierView))
        Me.GrpUser = New System.Windows.Forms.GroupBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusSwitch = New System.Windows.Forms.PictureBox()
        Me.LblVName = New System.Windows.Forms.Label()
        Me.LblVContact = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAdress = New System.Windows.Forms.TextBox()
        Me.LblVId = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPostalCode = New System.Windows.Forms.TextBox()
        Me.LblVAdress = New System.Windows.Forms.Label()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.LblVPhone = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.LblVFax = New System.Windows.Forms.Label()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.LblVEmail = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtInfo = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpCreatedAt = New System.Windows.Forms.DateTimePicker()
        Me.TxtBank = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCurrency = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSupplierFolder = New System.Windows.Forms.TextBox()
        Me.GrpUser.SuspendLayout()
        CType(Me.StatusSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpUser
        '
        Me.GrpUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpUser.Controls.Add(Me.LblStatus)
        Me.GrpUser.Controls.Add(Me.Label3)
        Me.GrpUser.Controls.Add(Me.StatusSwitch)
        Me.GrpUser.Controls.Add(Me.LblVName)
        Me.GrpUser.Controls.Add(Me.LblVContact)
        Me.GrpUser.Controls.Add(Me.Label5)
        Me.GrpUser.Controls.Add(Me.TxtAdress)
        Me.GrpUser.Controls.Add(Me.LblVId)
        Me.GrpUser.Controls.Add(Me.TxtEmail)
        Me.GrpUser.Controls.Add(Me.TxtPostalCode)
        Me.GrpUser.Controls.Add(Me.LblVAdress)
        Me.GrpUser.Controls.Add(Me.TxtFax)
        Me.GrpUser.Controls.Add(Me.TxtCity)
        Me.GrpUser.Controls.Add(Me.LblVPhone)
        Me.GrpUser.Controls.Add(Me.TxtPhone)
        Me.GrpUser.Controls.Add(Me.LblVFax)
        Me.GrpUser.Controls.Add(Me.TxtContact)
        Me.GrpUser.Controls.Add(Me.LblVEmail)
        Me.GrpUser.Controls.Add(Me.TxtID)
        Me.GrpUser.Controls.Add(Me.TxtName)
        Me.GrpUser.Location = New System.Drawing.Point(11, 12)
        Me.GrpUser.Name = "GrpUser"
        Me.GrpUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrpUser.Size = New System.Drawing.Size(331, 298)
        Me.GrpUser.TabIndex = 0
        Me.GrpUser.TabStop = False
        Me.GrpUser.Text = "تفاصيل المورد"
        '
        'LblStatus
        '
        Me.LblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(107, 28)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 13)
        Me.LblStatus.TabIndex = 42
        Me.LblStatus.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "المدينه"
        '
        'StatusSwitch
        '
        Me.StatusSwitch.Image = CType(resources.GetObject("StatusSwitch.Image"), System.Drawing.Image)
        Me.StatusSwitch.Location = New System.Drawing.Point(153, 19)
        Me.StatusSwitch.Name = "StatusSwitch"
        Me.StatusSwitch.Size = New System.Drawing.Size(88, 32)
        Me.StatusSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StatusSwitch.TabIndex = 41
        Me.StatusSwitch.TabStop = False
        '
        'LblVName
        '
        Me.LblVName.AutoSize = True
        Me.LblVName.Location = New System.Drawing.Point(272, 60)
        Me.LblVName.Name = "LblVName"
        Me.LblVName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVName.Size = New System.Drawing.Size(54, 13)
        Me.LblVName.TabIndex = 23
        Me.LblVName.Text = "اسم المورد"
        '
        'LblVContact
        '
        Me.LblVContact.AutoSize = True
        Me.LblVContact.Location = New System.Drawing.Point(259, 112)
        Me.LblVContact.Name = "LblVContact"
        Me.LblVContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVContact.Size = New System.Drawing.Size(67, 13)
        Me.LblVContact.TabIndex = 24
        Me.LblVContact.Text = "وجهة الاتصال"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "الرمز البريدي"
        '
        'TxtAdress
        '
        Me.TxtAdress.Location = New System.Drawing.Point(6, 213)
        Me.TxtAdress.Name = "TxtAdress"
        Me.TxtAdress.Size = New System.Drawing.Size(235, 20)
        Me.TxtAdress.TabIndex = 6
        '
        'LblVId
        '
        Me.LblVId.AutoSize = True
        Me.LblVId.Location = New System.Drawing.Point(264, 86)
        Me.LblVId.Name = "LblVId"
        Me.LblVId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVId.Size = New System.Drawing.Size(62, 13)
        Me.LblVId.TabIndex = 25
        Me.LblVId.Text = "معرف المورد"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(6, 187)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(235, 20)
        Me.TxtEmail.TabIndex = 5
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPostalCode
        '
        Me.TxtPostalCode.Location = New System.Drawing.Point(6, 265)
        Me.TxtPostalCode.Name = "TxtPostalCode"
        Me.TxtPostalCode.Size = New System.Drawing.Size(235, 20)
        Me.TxtPostalCode.TabIndex = 8
        '
        'LblVAdress
        '
        Me.LblVAdress.AutoSize = True
        Me.LblVAdress.Location = New System.Drawing.Point(287, 216)
        Me.LblVAdress.Name = "LblVAdress"
        Me.LblVAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVAdress.Size = New System.Drawing.Size(39, 13)
        Me.LblVAdress.TabIndex = 26
        Me.LblVAdress.Text = "العنوان"
        '
        'TxtFax
        '
        Me.TxtFax.Location = New System.Drawing.Point(6, 161)
        Me.TxtFax.MaxLength = 11
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(235, 20)
        Me.TxtFax.TabIndex = 4
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(6, 239)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(235, 20)
        Me.TxtCity.TabIndex = 7
        '
        'LblVPhone
        '
        Me.LblVPhone.AutoSize = True
        Me.LblVPhone.Location = New System.Drawing.Point(271, 138)
        Me.LblVPhone.Name = "LblVPhone"
        Me.LblVPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVPhone.Size = New System.Drawing.Size(55, 13)
        Me.LblVPhone.TabIndex = 27
        Me.LblVPhone.Text = "رقم الهاتف"
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(6, 135)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(235, 20)
        Me.TxtPhone.TabIndex = 3
        '
        'LblVFax
        '
        Me.LblVFax.AutoSize = True
        Me.LblVFax.Location = New System.Drawing.Point(269, 164)
        Me.LblVFax.Name = "LblVFax"
        Me.LblVFax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVFax.Size = New System.Drawing.Size(57, 13)
        Me.LblVFax.TabIndex = 28
        Me.LblVFax.Text = "رقم الفاكس"
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(6, 109)
        Me.TxtContact.MaxLength = 9
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(235, 20)
        Me.TxtContact.TabIndex = 2
        '
        'LblVEmail
        '
        Me.LblVEmail.AutoSize = True
        Me.LblVEmail.Location = New System.Drawing.Point(244, 190)
        Me.LblVEmail.Name = "LblVEmail"
        Me.LblVEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblVEmail.Size = New System.Drawing.Size(82, 13)
        Me.LblVEmail.TabIndex = 29
        Me.LblVEmail.Text = "البريد الالكتروني"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(6, 83)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(235, 20)
        Me.TxtID.TabIndex = 1
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(6, 57)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(235, 20)
        Me.TxtName.TabIndex = 0
        '
        'TxtInfo
        '
        Me.TxtInfo.Location = New System.Drawing.Point(6, 97)
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.Size = New System.Drawing.Size(235, 84)
        Me.TxtInfo.TabIndex = 3
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(466, 316)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 55)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "اضافة"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(574, 316)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "اغلاق"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSupplierFolder)
        Me.GroupBox1.Controls.Add(Me.DtpCreatedAt)
        Me.GroupBox1.Controls.Add(Me.TxtBank)
        Me.GroupBox1.Controls.Add(Me.TxtInfo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCurrency)
        Me.GroupBox1.Location = New System.Drawing.Point(348, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(326, 298)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DtpCreatedAt
        '
        Me.DtpCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpCreatedAt.Location = New System.Drawing.Point(6, 19)
        Me.DtpCreatedAt.Name = "DtpCreatedAt"
        Me.DtpCreatedAt.Size = New System.Drawing.Size(235, 20)
        Me.DtpCreatedAt.TabIndex = 0
        '
        'TxtBank
        '
        Me.TxtBank.Location = New System.Drawing.Point(6, 187)
        Me.TxtBank.Multiline = True
        Me.TxtBank.Name = "TxtBank"
        Me.TxtBank.Size = New System.Drawing.Size(235, 98)
        Me.TxtBank.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "العمله"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "تاريخ التسجيل"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "تفاصيل البنك"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "معلومات اضافيه"
        '
        'TxtCurrency
        '
        Me.TxtCurrency.Location = New System.Drawing.Point(6, 45)
        Me.TxtCurrency.MaxLength = 9
        Me.TxtCurrency.Name = "TxtCurrency"
        Me.TxtCurrency.Size = New System.Drawing.Size(235, 20)
        Me.TxtCurrency.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "رقم الملف"
        '
        'TxtSupplierFolder
        '
        Me.TxtSupplierFolder.Location = New System.Drawing.Point(6, 71)
        Me.TxtSupplierFolder.MaxLength = 9
        Me.TxtSupplierFolder.Name = "TxtSupplierFolder"
        Me.TxtSupplierFolder.Size = New System.Drawing.Size(235, 20)
        Me.TxtSupplierFolder.TabIndex = 2
        '
        'FrmSupplierView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 378)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpUser)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSupplierView"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تفاصيل المورد"
        Me.GrpUser.ResumeLayout(False)
        Me.GrpUser.PerformLayout()
        CType(Me.StatusSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpUser As GroupBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents StatusSwitch As PictureBox
    Friend WithEvents LblVName As Label
    Friend WithEvents TxtInfo As TextBox
    Friend WithEvents LblVContact As Label
    Friend WithEvents TxtAdress As TextBox
    Friend WithEvents LblVId As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblVAdress As Label
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents LblVPhone As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents LblVFax As Label
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents LblVEmail As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBank As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCurrency As TextBox
    Friend WithEvents TxtPostalCode As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents DtpCreatedAt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSupplierFolder As TextBox
End Class
