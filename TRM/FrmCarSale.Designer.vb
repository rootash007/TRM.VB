<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarSale))
        Me.LblSaleWay = New System.Windows.Forms.Label()
        Me.LblBuyerName = New System.Windows.Forms.Label()
        Me.LblMoney = New System.Windows.Forms.Label()
        Me.LblBuyerAdress = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblFilter = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkChangeNon = New System.Windows.Forms.CheckBox()
        Me.DtpSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.ChkChangeAdd = New System.Windows.Forms.CheckBox()
        Me.ChkChange = New System.Windows.Forms.CheckBox()
        Me.ChkNormal = New System.Windows.Forms.CheckBox()
        Me.GrpCarList = New System.Windows.Forms.GroupBox()
        Me.LblClear = New System.Windows.Forms.Label()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.DgvCarList = New System.Windows.Forms.DataGridView()
        Me.GrpMoney = New System.Windows.Forms.GroupBox()
        Me.TxtConfirm = New System.Windows.Forms.TextBox()
        Me.LblConfirm = New System.Windows.Forms.Label()
        Me.TxtReceipt = New System.Windows.Forms.TextBox()
        Me.LblReceipt = New System.Windows.Forms.Label()
        Me.TxtInvoice = New System.Windows.Forms.TextBox()
        Me.LblInvoice = New System.Windows.Forms.Label()
        Me.BtnSelectCustomer = New System.Windows.Forms.Button()
        Me.LblCarInfo = New System.Windows.Forms.Label()
        Me.TxtCarInfo = New System.Windows.Forms.TextBox()
        Me.TxtBuyerId = New System.Windows.Forms.TextBox()
        Me.TxtMoney = New System.Windows.Forms.TextBox()
        Me.TxtBuyerPhone = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtBuyerAdress = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtBuyerName = New System.Windows.Forms.TextBox()
        Me.LblBuyerId = New System.Windows.Forms.Label()
        Me.LblBuyerPhone = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GrpCarList.SuspendLayout()
        CType(Me.DgvCarList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpMoney.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSaleWay
        '
        Me.LblSaleWay.AutoSize = True
        Me.LblSaleWay.Location = New System.Drawing.Point(555, 47)
        Me.LblSaleWay.Name = "LblSaleWay"
        Me.LblSaleWay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblSaleWay.Size = New System.Drawing.Size(85, 13)
        Me.LblSaleWay.TabIndex = 0
        Me.LblSaleWay.Text = "* בחר סוג עסקה"
        '
        'LblBuyerName
        '
        Me.LblBuyerName.AutoSize = True
        Me.LblBuyerName.Location = New System.Drawing.Point(859, 83)
        Me.LblBuyerName.Name = "LblBuyerName"
        Me.LblBuyerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBuyerName.Size = New System.Drawing.Size(56, 13)
        Me.LblBuyerName.TabIndex = 1
        Me.LblBuyerName.Text = "שם הקונה"
        '
        'LblMoney
        '
        Me.LblMoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMoney.AutoSize = True
        Me.LblMoney.Location = New System.Drawing.Point(120, 107)
        Me.LblMoney.Name = "LblMoney"
        Me.LblMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMoney.Size = New System.Drawing.Size(66, 13)
        Me.LblMoney.TabIndex = 2
        Me.LblMoney.Text = "מחיר מכירה"
        '
        'LblBuyerAdress
        '
        Me.LblBuyerAdress.AutoSize = True
        Me.LblBuyerAdress.Location = New System.Drawing.Point(843, 135)
        Me.LblBuyerAdress.Name = "LblBuyerAdress"
        Me.LblBuyerAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBuyerAdress.Size = New System.Drawing.Size(72, 13)
        Me.LblBuyerAdress.TabIndex = 3
        Me.LblBuyerAdress.Text = "כתובת הקונה"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(561, 16)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDate.Size = New System.Drawing.Size(79, 13)
        Me.LblDate.TabIndex = 4
        Me.LblDate.Text = "* תאריך עסקה"
        '
        'LblFilter
        '
        Me.LblFilter.AutoSize = True
        Me.LblFilter.Location = New System.Drawing.Point(835, 16)
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(78, 13)
        Me.LblFilter.TabIndex = 6
        Me.LblFilter.Text = "סינון אוטומטי"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkChangeNon)
        Me.GroupBox1.Controls.Add(Me.DtpSaleDate)
        Me.GroupBox1.Controls.Add(Me.ChkChangeAdd)
        Me.GroupBox1.Controls.Add(Me.ChkChange)
        Me.GroupBox1.Controls.Add(Me.LblDate)
        Me.GroupBox1.Controls.Add(Me.ChkNormal)
        Me.GroupBox1.Controls.Add(Me.LblSaleWay)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(648, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "סוג עסקה"
        '
        'ChkChangeNon
        '
        Me.ChkChangeNon.AutoSize = True
        Me.ChkChangeNon.Location = New System.Drawing.Point(12, 46)
        Me.ChkChangeNon.Name = "ChkChangeNon"
        Me.ChkChangeNon.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkChangeNon.Size = New System.Drawing.Size(121, 17)
        Me.ChkChangeNon.TabIndex = 4
        Me.ChkChangeNon.Text = "עסקת מפתח-מפתח"
        Me.ChkChangeNon.UseVisualStyleBackColor = True
        '
        'DtpSaleDate
        '
        Me.DtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpSaleDate.Location = New System.Drawing.Point(451, 13)
        Me.DtpSaleDate.Name = "DtpSaleDate"
        Me.DtpSaleDate.Size = New System.Drawing.Size(103, 20)
        Me.DtpSaleDate.TabIndex = 0
        '
        'ChkChangeAdd
        '
        Me.ChkChangeAdd.AutoSize = True
        Me.ChkChangeAdd.Location = New System.Drawing.Point(139, 46)
        Me.ChkChangeAdd.Name = "ChkChangeAdd"
        Me.ChkChangeAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkChangeAdd.Size = New System.Drawing.Size(165, 17)
        Me.ChkChangeAdd.TabIndex = 3
        Me.ChkChangeAdd.Text = "עסקת החלפה בתוספת הפרש"
        Me.ChkChangeAdd.UseVisualStyleBackColor = True
        '
        'ChkChange
        '
        Me.ChkChange.AutoSize = True
        Me.ChkChange.Location = New System.Drawing.Point(310, 46)
        Me.ChkChange.Name = "ChkChange"
        Me.ChkChange.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkChange.Size = New System.Drawing.Size(92, 17)
        Me.ChkChange.TabIndex = 2
        Me.ChkChange.Text = "עסקת החלפה"
        Me.ChkChange.UseVisualStyleBackColor = True
        '
        'ChkNormal
        '
        Me.ChkNormal.AutoSize = True
        Me.ChkNormal.Location = New System.Drawing.Point(408, 46)
        Me.ChkNormal.Name = "ChkNormal"
        Me.ChkNormal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkNormal.Size = New System.Drawing.Size(120, 17)
        Me.ChkNormal.TabIndex = 1
        Me.ChkNormal.Text = "עסקת מכירה רגילה"
        Me.ChkNormal.UseVisualStyleBackColor = True
        '
        'GrpCarList
        '
        Me.GrpCarList.Controls.Add(Me.LblClear)
        Me.GrpCarList.Controls.Add(Me.TxtFilter)
        Me.GrpCarList.Controls.Add(Me.DgvCarList)
        Me.GrpCarList.Controls.Add(Me.LblFilter)
        Me.GrpCarList.Location = New System.Drawing.Point(12, 97)
        Me.GrpCarList.Name = "GrpCarList"
        Me.GrpCarList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpCarList.Size = New System.Drawing.Size(921, 264)
        Me.GrpCarList.TabIndex = 1
        Me.GrpCarList.TabStop = False
        Me.GrpCarList.Text = "רשימת רכבים במלאי"
        '
        'LblClear
        '
        Me.LblClear.AutoSize = True
        Me.LblClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblClear.Font = New System.Drawing.Font("David", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblClear.ForeColor = System.Drawing.Color.Blue
        Me.LblClear.Location = New System.Drawing.Point(696, 16)
        Me.LblClear.Name = "LblClear"
        Me.LblClear.Size = New System.Drawing.Size(27, 13)
        Me.LblClear.TabIndex = 26
        Me.LblClear.Text = "נקה"
        '
        'TxtFilter
        '
        Me.TxtFilter.Location = New System.Drawing.Point(729, 13)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(100, 20)
        Me.TxtFilter.TabIndex = 1
        Me.TxtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DgvCarList
        '
        Me.DgvCarList.AllowUserToAddRows = False
        Me.DgvCarList.AllowUserToDeleteRows = False
        Me.DgvCarList.AllowUserToResizeColumns = False
        Me.DgvCarList.AllowUserToResizeRows = False
        Me.DgvCarList.BackgroundColor = System.Drawing.Color.White
        Me.DgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCarList.Location = New System.Drawing.Point(6, 39)
        Me.DgvCarList.MultiSelect = False
        Me.DgvCarList.Name = "DgvCarList"
        Me.DgvCarList.ReadOnly = True
        Me.DgvCarList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DgvCarList.RowHeadersVisible = False
        Me.DgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCarList.Size = New System.Drawing.Size(907, 219)
        Me.DgvCarList.TabIndex = 0
        '
        'GrpMoney
        '
        Me.GrpMoney.Controls.Add(Me.TxtConfirm)
        Me.GrpMoney.Controls.Add(Me.LblConfirm)
        Me.GrpMoney.Controls.Add(Me.TxtReceipt)
        Me.GrpMoney.Controls.Add(Me.LblReceipt)
        Me.GrpMoney.Controls.Add(Me.TxtInvoice)
        Me.GrpMoney.Controls.Add(Me.LblInvoice)
        Me.GrpMoney.Controls.Add(Me.BtnSelectCustomer)
        Me.GrpMoney.Controls.Add(Me.LblCarInfo)
        Me.GrpMoney.Controls.Add(Me.TxtCarInfo)
        Me.GrpMoney.Controls.Add(Me.TxtBuyerId)
        Me.GrpMoney.Controls.Add(Me.TxtMoney)
        Me.GrpMoney.Controls.Add(Me.TxtBuyerPhone)
        Me.GrpMoney.Controls.Add(Me.BtnSave)
        Me.GrpMoney.Controls.Add(Me.TxtBuyerAdress)
        Me.GrpMoney.Controls.Add(Me.BtnCancel)
        Me.GrpMoney.Controls.Add(Me.TxtBuyerName)
        Me.GrpMoney.Controls.Add(Me.LblMoney)
        Me.GrpMoney.Controls.Add(Me.LblBuyerId)
        Me.GrpMoney.Controls.Add(Me.LblBuyerName)
        Me.GrpMoney.Controls.Add(Me.LblBuyerPhone)
        Me.GrpMoney.Controls.Add(Me.LblBuyerAdress)
        Me.GrpMoney.Location = New System.Drawing.Point(12, 367)
        Me.GrpMoney.Name = "GrpMoney"
        Me.GrpMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpMoney.Size = New System.Drawing.Size(921, 197)
        Me.GrpMoney.TabIndex = 2
        Me.GrpMoney.TabStop = False
        Me.GrpMoney.Text = "פרטי קונה ותנאי תשלום"
        '
        'TxtConfirm
        '
        Me.TxtConfirm.Location = New System.Drawing.Point(6, 26)
        Me.TxtConfirm.MaxLength = 20
        Me.TxtConfirm.Name = "TxtConfirm"
        Me.TxtConfirm.Size = New System.Drawing.Size(100, 20)
        Me.TxtConfirm.TabIndex = 5
        Me.TxtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblConfirm
        '
        Me.LblConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblConfirm.AutoSize = True
        Me.LblConfirm.Location = New System.Drawing.Point(118, 29)
        Me.LblConfirm.Name = "LblConfirm"
        Me.LblConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblConfirm.Size = New System.Drawing.Size(68, 13)
        Me.LblConfirm.TabIndex = 26
        Me.LblConfirm.Text = "מספר אישור"
        '
        'TxtReceipt
        '
        Me.TxtReceipt.Location = New System.Drawing.Point(69, 52)
        Me.TxtReceipt.MaxLength = 8
        Me.TxtReceipt.Name = "TxtReceipt"
        Me.TxtReceipt.Size = New System.Drawing.Size(37, 20)
        Me.TxtReceipt.TabIndex = 6
        Me.TxtReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblReceipt
        '
        Me.LblReceipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblReceipt.AutoSize = True
        Me.LblReceipt.Location = New System.Drawing.Point(121, 55)
        Me.LblReceipt.Name = "LblReceipt"
        Me.LblReceipt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblReceipt.Size = New System.Drawing.Size(65, 13)
        Me.LblReceipt.TabIndex = 24
        Me.LblReceipt.Text = "מספר קבלה"
        '
        'TxtInvoice
        '
        Me.TxtInvoice.Location = New System.Drawing.Point(69, 78)
        Me.TxtInvoice.MaxLength = 8
        Me.TxtInvoice.Name = "TxtInvoice"
        Me.TxtInvoice.Size = New System.Drawing.Size(37, 20)
        Me.TxtInvoice.TabIndex = 7
        Me.TxtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblInvoice
        '
        Me.LblInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblInvoice.AutoSize = True
        Me.LblInvoice.Location = New System.Drawing.Point(107, 81)
        Me.LblInvoice.Name = "LblInvoice"
        Me.LblInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblInvoice.Size = New System.Drawing.Size(79, 13)
        Me.LblInvoice.TabIndex = 22
        Me.LblInvoice.Text = "מספר חשבונית"
        '
        'BtnSelectCustomer
        '
        Me.BtnSelectCustomer.BackColor = System.Drawing.Color.White
        Me.BtnSelectCustomer.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSelectCustomer.Image = CType(resources.GetObject("BtnSelectCustomer.Image"), System.Drawing.Image)
        Me.BtnSelectCustomer.Location = New System.Drawing.Point(696, 19)
        Me.BtnSelectCustomer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSelectCustomer.Name = "BtnSelectCustomer"
        Me.BtnSelectCustomer.Size = New System.Drawing.Size(216, 55)
        Me.BtnSelectCustomer.TabIndex = 0
        Me.BtnSelectCustomer.Text = "בחירת לקוח מהרשימה"
        Me.BtnSelectCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSelectCustomer.UseVisualStyleBackColor = False
        '
        'LblCarInfo
        '
        Me.LblCarInfo.AutoSize = True
        Me.LblCarInfo.Location = New System.Drawing.Point(349, 49)
        Me.LblCarInfo.Name = "LblCarInfo"
        Me.LblCarInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCarInfo.Size = New System.Drawing.Size(46, 13)
        Me.LblCarInfo.TabIndex = 19
        Me.LblCarInfo.Text = "הערות :"
        '
        'TxtCarInfo
        '
        Me.TxtCarInfo.Location = New System.Drawing.Point(215, 69)
        Me.TxtCarInfo.Multiline = True
        Me.TxtCarInfo.Name = "TxtCarInfo"
        Me.TxtCarInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCarInfo.Size = New System.Drawing.Size(177, 55)
        Me.TxtCarInfo.TabIndex = 18
        '
        'TxtBuyerId
        '
        Me.TxtBuyerId.Location = New System.Drawing.Point(696, 106)
        Me.TxtBuyerId.MaxLength = 9
        Me.TxtBuyerId.Name = "TxtBuyerId"
        Me.TxtBuyerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBuyerId.Size = New System.Drawing.Size(122, 20)
        Me.TxtBuyerId.TabIndex = 2
        Me.TxtBuyerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMoney
        '
        Me.TxtMoney.Location = New System.Drawing.Point(6, 104)
        Me.TxtMoney.MaxLength = 7
        Me.TxtMoney.Name = "TxtMoney"
        Me.TxtMoney.Size = New System.Drawing.Size(100, 20)
        Me.TxtMoney.TabIndex = 8
        Me.TxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBuyerPhone
        '
        Me.TxtBuyerPhone.Location = New System.Drawing.Point(696, 158)
        Me.TxtBuyerPhone.MaxLength = 11
        Me.TxtBuyerPhone.Name = "TxtBuyerPhone"
        Me.TxtBuyerPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBuyerPhone.Size = New System.Drawing.Size(122, 20)
        Me.TxtBuyerPhone.TabIndex = 4
        Me.TxtBuyerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(110, 129)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(100, 55)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "שמירה"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtBuyerAdress
        '
        Me.TxtBuyerAdress.Location = New System.Drawing.Point(696, 132)
        Me.TxtBuyerAdress.Name = "TxtBuyerAdress"
        Me.TxtBuyerAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBuyerAdress.Size = New System.Drawing.Size(122, 20)
        Me.TxtBuyerAdress.TabIndex = 3
        Me.TxtBuyerAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(6, 129)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtBuyerName
        '
        Me.TxtBuyerName.Location = New System.Drawing.Point(696, 80)
        Me.TxtBuyerName.Name = "TxtBuyerName"
        Me.TxtBuyerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBuyerName.Size = New System.Drawing.Size(122, 20)
        Me.TxtBuyerName.TabIndex = 1
        Me.TxtBuyerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBuyerId
        '
        Me.LblBuyerId.AutoSize = True
        Me.LblBuyerId.Location = New System.Drawing.Point(859, 109)
        Me.LblBuyerId.Name = "LblBuyerId"
        Me.LblBuyerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBuyerId.Size = New System.Drawing.Size(56, 13)
        Me.LblBuyerId.TabIndex = 14
        Me.LblBuyerId.Text = "ת.ז הקונה"
        '
        'LblBuyerPhone
        '
        Me.LblBuyerPhone.AutoSize = True
        Me.LblBuyerPhone.Location = New System.Drawing.Point(847, 161)
        Me.LblBuyerPhone.Name = "LblBuyerPhone"
        Me.LblBuyerPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblBuyerPhone.Size = New System.Drawing.Size(68, 13)
        Me.LblBuyerPhone.TabIndex = 13
        Me.LblBuyerPhone.Text = "טלפון הקונה"
        '
        'FrmCarSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(943, 576)
        Me.Controls.Add(Me.GrpMoney)
        Me.Controls.Add(Me.GrpCarList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCarSale"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "מכירת רכב"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpCarList.ResumeLayout(False)
        Me.GrpCarList.PerformLayout()
        CType(Me.DgvCarList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpMoney.ResumeLayout(False)
        Me.GrpMoney.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblSaleWay As System.Windows.Forms.Label
    Friend WithEvents LblBuyerName As System.Windows.Forms.Label
    Friend WithEvents LblMoney As System.Windows.Forms.Label
    Friend WithEvents LblBuyerAdress As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblFilter As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpCarList As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCarList As System.Windows.Forms.DataGridView
    Friend WithEvents TxtFilter As System.Windows.Forms.TextBox
    Friend WithEvents ChkChangeAdd As System.Windows.Forms.CheckBox
    Friend WithEvents ChkChange As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNormal As System.Windows.Forms.CheckBox
    Friend WithEvents GrpMoney As System.Windows.Forms.GroupBox
    Friend WithEvents DtpSaleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtMoney As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblBuyerPhone As System.Windows.Forms.Label
    Friend WithEvents LblBuyerId As System.Windows.Forms.Label
    Friend WithEvents TxtBuyerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuyerAdress As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuyerPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuyerId As System.Windows.Forms.TextBox
    Friend WithEvents LblCarInfo As System.Windows.Forms.Label
    Friend WithEvents TxtCarInfo As System.Windows.Forms.TextBox
    Friend WithEvents BtnSelectCustomer As System.Windows.Forms.Button
    Friend WithEvents ChkChangeNon As System.Windows.Forms.CheckBox
    Friend WithEvents TxtReceipt As System.Windows.Forms.TextBox
    Friend WithEvents LblReceipt As System.Windows.Forms.Label
    Friend WithEvents TxtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents LblInvoice As System.Windows.Forms.Label
    Friend WithEvents LblClear As System.Windows.Forms.Label
    Friend WithEvents TxtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents LblConfirm As System.Windows.Forms.Label
End Class
