<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCostomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddCostomers))
        Me.ChkStatus = New System.Windows.Forms.CheckBox()
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChkStatus
        '
        Me.ChkStatus.AutoSize = True
        Me.ChkStatus.Location = New System.Drawing.Point(122, 4)
        Me.ChkStatus.Name = "ChkStatus"
        Me.ChkStatus.Size = New System.Drawing.Size(48, 17)
        Me.ChkStatus.TabIndex = 39
        Me.ChkStatus.Text = "פעיל"
        Me.ChkStatus.UseVisualStyleBackColor = True
        Me.ChkStatus.Visible = False
        '
        'TxtCInfo
        '
        Me.TxtCInfo.Location = New System.Drawing.Point(122, 278)
        Me.TxtCInfo.Name = "TxtCInfo"
        Me.TxtCInfo.Size = New System.Drawing.Size(268, 20)
        Me.TxtCInfo.TabIndex = 38
        '
        'TxtCEmail
        '
        Me.TxtCEmail.Location = New System.Drawing.Point(122, 243)
        Me.TxtCEmail.Name = "TxtCEmail"
        Me.TxtCEmail.Size = New System.Drawing.Size(268, 20)
        Me.TxtCEmail.TabIndex = 37
        '
        'TxtCFax
        '
        Me.TxtCFax.Location = New System.Drawing.Point(122, 208)
        Me.TxtCFax.Name = "TxtCFax"
        Me.TxtCFax.Size = New System.Drawing.Size(268, 20)
        Me.TxtCFax.TabIndex = 36
        '
        'TxtCPhone
        '
        Me.TxtCPhone.Location = New System.Drawing.Point(122, 173)
        Me.TxtCPhone.Name = "TxtCPhone"
        Me.TxtCPhone.Size = New System.Drawing.Size(268, 20)
        Me.TxtCPhone.TabIndex = 35
        '
        'TxtCAdress
        '
        Me.TxtCAdress.Location = New System.Drawing.Point(122, 138)
        Me.TxtCAdress.Name = "TxtCAdress"
        Me.TxtCAdress.Size = New System.Drawing.Size(268, 20)
        Me.TxtCAdress.TabIndex = 34
        '
        'TxtCId
        '
        Me.TxtCId.Location = New System.Drawing.Point(122, 103)
        Me.TxtCId.Name = "TxtCId"
        Me.TxtCId.Size = New System.Drawing.Size(268, 20)
        Me.TxtCId.TabIndex = 33
        '
        'TxtCContact
        '
        Me.TxtCContact.Location = New System.Drawing.Point(122, 68)
        Me.TxtCContact.Name = "TxtCContact"
        Me.TxtCContact.Size = New System.Drawing.Size(268, 20)
        Me.TxtCContact.TabIndex = 32
        '
        'TxtCName
        '
        Me.TxtCName.Location = New System.Drawing.Point(122, 33)
        Me.TxtCName.Name = "TxtCName"
        Me.TxtCName.Size = New System.Drawing.Size(268, 20)
        Me.TxtCName.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "הערות :"
        '
        'LblVEmail
        '
        Me.LblVEmail.AutoSize = True
        Me.LblVEmail.Location = New System.Drawing.Point(11, 246)
        Me.LblVEmail.Name = "LblVEmail"
        Me.LblVEmail.Size = New System.Drawing.Size(49, 13)
        Me.LblVEmail.TabIndex = 29
        Me.LblVEmail.Text = "אימייל :"
        '
        'LblVFax
        '
        Me.LblVFax.AutoSize = True
        Me.LblVFax.Location = New System.Drawing.Point(11, 211)
        Me.LblVFax.Name = "LblVFax"
        Me.LblVFax.Size = New System.Drawing.Size(37, 13)
        Me.LblVFax.TabIndex = 28
        Me.LblVFax.Text = "פקס :"
        '
        'LblVPhone
        '
        Me.LblVPhone.AutoSize = True
        Me.LblVPhone.Location = New System.Drawing.Point(11, 176)
        Me.LblVPhone.Name = "LblVPhone"
        Me.LblVPhone.Size = New System.Drawing.Size(74, 13)
        Me.LblVPhone.TabIndex = 27
        Me.LblVPhone.Text = "מספר טלפון :"
        '
        'LblVAdress
        '
        Me.LblVAdress.AutoSize = True
        Me.LblVAdress.Location = New System.Drawing.Point(11, 141)
        Me.LblVAdress.Name = "LblVAdress"
        Me.LblVAdress.Size = New System.Drawing.Size(47, 13)
        Me.LblVAdress.TabIndex = 26
        Me.LblVAdress.Text = "כתובת :"
        '
        'LblVId
        '
        Me.LblVId.AutoSize = True
        Me.LblVId.Location = New System.Drawing.Point(11, 106)
        Me.LblVId.Name = "LblVId"
        Me.LblVId.Size = New System.Drawing.Size(57, 13)
        Me.LblVId.TabIndex = 25
        Me.LblVId.Text = "ת.ז / ח.פ :"
        '
        'LblVContact
        '
        Me.LblVContact.AutoSize = True
        Me.LblVContact.Location = New System.Drawing.Point(11, 71)
        Me.LblVContact.Name = "LblVContact"
        Me.LblVContact.Size = New System.Drawing.Size(60, 13)
        Me.LblVContact.TabIndex = 24
        Me.LblVContact.Text = "איש קשר :"
        '
        'LblVName
        '
        Me.LblVName.AutoSize = True
        Me.LblVName.Location = New System.Drawing.Point(11, 36)
        Me.LblVName.Name = "LblVName"
        Me.LblVName.Size = New System.Drawing.Size(59, 13)
        Me.LblVName.TabIndex = 23
        Me.LblVName.Text = "שם לקוח :"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(182, 311)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 40)
        Me.BtnAdd.TabIndex = 22
        Me.BtnAdd.Text = "הוספה"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(290, 311)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.TabIndex = 21
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmAddCostomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 360)
        Me.Controls.Add(Me.ChkStatus)
        Me.Controls.Add(Me.TxtCInfo)
        Me.Controls.Add(Me.TxtCEmail)
        Me.Controls.Add(Me.TxtCFax)
        Me.Controls.Add(Me.TxtCPhone)
        Me.Controls.Add(Me.TxtCAdress)
        Me.Controls.Add(Me.TxtCId)
        Me.Controls.Add(Me.TxtCContact)
        Me.Controls.Add(Me.TxtCName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblVEmail)
        Me.Controls.Add(Me.LblVFax)
        Me.Controls.Add(Me.LblVPhone)
        Me.Controls.Add(Me.LblVAdress)
        Me.Controls.Add(Me.LblVId)
        Me.Controls.Add(Me.LblVContact)
        Me.Controls.Add(Me.LblVName)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddCostomers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת לקוח חדש"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkStatus As System.Windows.Forms.CheckBox
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
End Class
