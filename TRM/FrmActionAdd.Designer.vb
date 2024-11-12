<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActionAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActionAdd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTPDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbLocBarcode = New System.Windows.Forms.ComboBox()
        Me.CmbMaterialName = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMoreInfo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtOrder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtVendor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBlockNumber = New System.Windows.Forms.TextBox()
        Me.CmbActionType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.NumQuantity = New System.Windows.Forms.NumericUpDown()
        Me.LblBarecode = New System.Windows.Forms.Label()
        Me.Txtbarcode = New System.Windows.Forms.TextBox()
        Me.LblMaterialName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTPDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CmbLocBarcode)
        Me.GroupBox1.Controls.Add(Me.CmbMaterialName)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtMoreInfo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtOrder)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtVendor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtBlockNumber)
        Me.GroupBox1.Controls.Add(Me.CmbActionType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblQuantity)
        Me.GroupBox1.Controls.Add(Me.NumQuantity)
        Me.GroupBox1.Controls.Add(Me.LblBarecode)
        Me.GroupBox1.Controls.Add(Me.Txtbarcode)
        Me.GroupBox1.Controls.Add(Me.LblMaterialName)
        Me.GroupBox1.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(413, 474)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافة عملية"
        '
        'DTPDate
        '
        Me.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDate.Location = New System.Drawing.Point(9, 24)
        Me.DTPDate.Name = "DTPDate"
        Me.DTPDate.Size = New System.Drawing.Size(132, 25)
        Me.DTPDate.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label6.Location = New System.Drawing.Point(328, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(74, 21)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "نوع العملية"
        '
        'CmbLocBarcode
        '
        Me.CmbLocBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbLocBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbLocBarcode.FormattingEnabled = True
        Me.CmbLocBarcode.ItemHeight = 17
        Me.CmbLocBarcode.Location = New System.Drawing.Point(159, 89)
        Me.CmbLocBarcode.Name = "CmbLocBarcode"
        Me.CmbLocBarcode.Size = New System.Drawing.Size(154, 25)
        Me.CmbLocBarcode.TabIndex = 2
        '
        'CmbMaterialName
        '
        Me.CmbMaterialName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMaterialName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMaterialName.FormattingEnabled = True
        Me.CmbMaterialName.ItemHeight = 17
        Me.CmbMaterialName.Location = New System.Drawing.Point(159, 54)
        Me.CmbMaterialName.Name = "CmbMaterialName"
        Me.CmbMaterialName.Size = New System.Drawing.Size(154, 25)
        Me.CmbMaterialName.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(149, 407)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(126, 59)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(15, 407)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(126, 59)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "الغاء"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(60, 21)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "معلومات"
        '
        'TxtMoreInfo
        '
        Me.TxtMoreInfo.Location = New System.Drawing.Point(15, 288)
        Me.TxtMoreInfo.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TxtMoreInfo.Multiline = True
        Me.TxtMoreInfo.Name = "TxtMoreInfo"
        Me.TxtMoreInfo.Size = New System.Drawing.Size(298, 113)
        Me.TxtMoreInfo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(331, 261)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "رقم الانتاج"
        '
        'TxtOrder
        '
        Me.TxtOrder.Location = New System.Drawing.Point(159, 257)
        Me.TxtOrder.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TxtOrder.Name = "TxtOrder"
        Me.TxtOrder.Size = New System.Drawing.Size(154, 25)
        Me.TxtOrder.TabIndex = 7
        Me.TxtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 228)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "اسم المورد"
        '
        'TxtVendor
        '
        Me.TxtVendor.Location = New System.Drawing.Point(159, 224)
        Me.TxtVendor.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TxtVendor.Name = "TxtVendor"
        Me.TxtVendor.Size = New System.Drawing.Size(154, 25)
        Me.TxtVendor.TabIndex = 6
        Me.TxtVendor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "رقم المشتاح"
        '
        'TxtBlockNumber
        '
        Me.TxtBlockNumber.Location = New System.Drawing.Point(159, 193)
        Me.TxtBlockNumber.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TxtBlockNumber.Name = "TxtBlockNumber"
        Me.TxtBlockNumber.Size = New System.Drawing.Size(154, 25)
        Me.TxtBlockNumber.TabIndex = 5
        Me.TxtBlockNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbActionType
        '
        Me.CmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbActionType.FormattingEnabled = True
        Me.CmbActionType.ItemHeight = 17
        Me.CmbActionType.Location = New System.Drawing.Point(159, 24)
        Me.CmbActionType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbActionType.Name = "CmbActionType"
        Me.CmbActionType.Size = New System.Drawing.Size(154, 25)
        Me.CmbActionType.Sorted = True
        Me.CmbActionType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "رقم المادة"
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(359, 164)
        Me.LblQuantity.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblQuantity.Size = New System.Drawing.Size(43, 21)
        Me.LblQuantity.TabIndex = 55
        Me.LblQuantity.Text = "الكمية"
        '
        'NumQuantity
        '
        Me.NumQuantity.DecimalPlaces = 2
        Me.NumQuantity.Location = New System.Drawing.Point(159, 161)
        Me.NumQuantity.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.NumQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumQuantity.Name = "NumQuantity"
        Me.NumQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumQuantity.Size = New System.Drawing.Size(154, 25)
        Me.NumQuantity.TabIndex = 4
        '
        'LblBarecode
        '
        Me.LblBarecode.AutoSize = True
        Me.LblBarecode.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblBarecode.Location = New System.Drawing.Point(354, 131)
        Me.LblBarecode.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblBarecode.Name = "LblBarecode"
        Me.LblBarecode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBarecode.Size = New System.Drawing.Size(48, 21)
        Me.LblBarecode.TabIndex = 54
        Me.LblBarecode.Text = "باركود"
        '
        'Txtbarcode
        '
        Me.Txtbarcode.Location = New System.Drawing.Point(159, 127)
        Me.Txtbarcode.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Txtbarcode.Name = "Txtbarcode"
        Me.Txtbarcode.Size = New System.Drawing.Size(154, 25)
        Me.Txtbarcode.TabIndex = 3
        Me.Txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMaterialName
        '
        Me.LblMaterialName.AutoSize = True
        Me.LblMaterialName.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblMaterialName.Location = New System.Drawing.Point(362, 58)
        Me.LblMaterialName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblMaterialName.Name = "LblMaterialName"
        Me.LblMaterialName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMaterialName.Size = New System.Drawing.Size(40, 21)
        Me.LblMaterialName.TabIndex = 46
        Me.LblMaterialName.Text = "المادة"
        '
        'FrmActionAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 495)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActionAdd"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة عملية"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBlockNumber As TextBox
    Friend WithEvents CmbActionType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblQuantity As Label
    Friend WithEvents NumQuantity As NumericUpDown
    Friend WithEvents LblBarecode As Label
    Friend WithEvents Txtbarcode As TextBox
    Friend WithEvents LblMaterialName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMoreInfo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtOrder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtVendor As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents CmbMaterialName As ComboBox
    Friend WithEvents CmbLocBarcode As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DTPDate As DateTimePicker
End Class
