<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarDelete))
        Me.LblCarDetails = New System.Windows.Forms.Label()
        Me.LblModel = New System.Windows.Forms.Label()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.LblMoney = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblDeleteInfo = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtDeleteInfo = New System.Windows.Forms.TextBox()
        Me.DtpDeleteDate = New System.Windows.Forms.DateTimePicker()
        Me.LblDeleteDate = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCarDetails
        '
        Me.LblCarDetails.AutoSize = True
        Me.LblCarDetails.Location = New System.Drawing.Point(12, 52)
        Me.LblCarDetails.Name = "LblCarDetails"
        Me.LblCarDetails.Size = New System.Drawing.Size(60, 13)
        Me.LblCarDetails.TabIndex = 0
        Me.LblCarDetails.Text = "פרטי רכב :"
        '
        'LblModel
        '
        Me.LblModel.AutoSize = True
        Me.LblModel.Location = New System.Drawing.Point(93, 52)
        Me.LblModel.Name = "LblModel"
        Me.LblModel.Size = New System.Drawing.Size(31, 13)
        Me.LblModel.TabIndex = 1
        Me.LblModel.Text = "ייצרן"
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Location = New System.Drawing.Point(167, 52)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(25, 13)
        Me.LblType.TabIndex = 2
        Me.LblType.Text = "דגם"
        '
        'LblYear
        '
        Me.LblYear.AutoSize = True
        Me.LblYear.Location = New System.Drawing.Point(244, 52)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(54, 13)
        Me.LblYear.TabIndex = 3
        Me.LblYear.Text = "שנת ייצור"
        '
        'LblMoney
        '
        Me.LblMoney.AutoSize = True
        Me.LblMoney.Location = New System.Drawing.Point(12, 85)
        Me.LblMoney.Name = "LblMoney"
        Me.LblMoney.Size = New System.Drawing.Size(70, 13)
        Me.LblMoney.TabIndex = 4
        Me.LblMoney.Text = "מחיר קנייה :"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(93, 85)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(62, 13)
        Me.LblPrice.TabIndex = 5
        Me.LblPrice.Text = "מחיר קנייה"
        '
        'LblDeleteInfo
        '
        Me.LblDeleteInfo.AutoSize = True
        Me.LblDeleteInfo.Location = New System.Drawing.Point(12, 118)
        Me.LblDeleteInfo.Name = "LblDeleteInfo"
        Me.LblDeleteInfo.Size = New System.Drawing.Size(78, 13)
        Me.LblDeleteInfo.TabIndex = 6
        Me.LblDeleteInfo.Text = "סיבת מחיקה :"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(268, 146)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 55)
        Me.BtnClose.TabIndex = 12
        Me.BtnClose.Text = "ביטול"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.White
        Me.BtnDelete.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(163, 146)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(101, 55)
        Me.BtnDelete.TabIndex = 11
        Me.BtnDelete.Text = "מחיקה"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(374, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'TxtDeleteInfo
        '
        Me.TxtDeleteInfo.Location = New System.Drawing.Point(96, 115)
        Me.TxtDeleteInfo.Name = "TxtDeleteInfo"
        Me.TxtDeleteInfo.Size = New System.Drawing.Size(271, 20)
        Me.TxtDeleteInfo.TabIndex = 14
        '
        'DtpDeleteDate
        '
        Me.DtpDeleteDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDeleteDate.Location = New System.Drawing.Point(102, 13)
        Me.DtpDeleteDate.Name = "DtpDeleteDate"
        Me.DtpDeleteDate.Size = New System.Drawing.Size(98, 20)
        Me.DtpDeleteDate.TabIndex = 15
        '
        'LblDeleteDate
        '
        Me.LblDeleteDate.AutoSize = True
        Me.LblDeleteDate.Location = New System.Drawing.Point(12, 19)
        Me.LblDeleteDate.Name = "LblDeleteDate"
        Me.LblDeleteDate.Size = New System.Drawing.Size(84, 13)
        Me.LblDeleteDate.TabIndex = 16
        Me.LblDeleteDate.Text = "תאריך מחיקה :"
        '
        'FrmCarDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 217)
        Me.Controls.Add(Me.LblDeleteDate)
        Me.Controls.Add(Me.DtpDeleteDate)
        Me.Controls.Add(Me.TxtDeleteInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LblDeleteInfo)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.LblMoney)
        Me.Controls.Add(Me.LblYear)
        Me.Controls.Add(Me.LblType)
        Me.Controls.Add(Me.LblModel)
        Me.Controls.Add(Me.LblCarDetails)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCarDelete"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCarDetails As System.Windows.Forms.Label
    Friend WithEvents LblModel As System.Windows.Forms.Label
    Friend WithEvents LblType As System.Windows.Forms.Label
    Friend WithEvents LblYear As System.Windows.Forms.Label
    Friend WithEvents LblMoney As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents LblDeleteInfo As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtDeleteInfo As System.Windows.Forms.TextBox
    Friend WithEvents DtpDeleteDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDeleteDate As System.Windows.Forms.Label
End Class
