<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch))
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.RadOnOff = New System.Windows.Forms.RadioButton()
        Me.RadStatusOff = New System.Windows.Forms.RadioButton()
        Me.RadStatusOn = New System.Windows.Forms.RadioButton()
        Me.GrpResults = New System.Windows.Forms.GroupBox()
        Me.DgvResults = New System.Windows.Forms.DataGridView()
        Me.GrpBtns = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnTC = New System.Windows.Forms.Button()
        Me.BtnTUpdate = New System.Windows.Forms.Button()
        Me.BtnSale = New System.Windows.Forms.Button()
        Me.GrpFilter = New System.Windows.Forms.GroupBox()
        Me.LblClear = New System.Windows.Forms.Label()
        Me.TxtSalerName = New System.Windows.Forms.TextBox()
        Me.TxtBuyerName = New System.Windows.Forms.TextBox()
        Me.NumToYear = New System.Windows.Forms.NumericUpDown()
        Me.NumFromYear = New System.Windows.Forms.NumericUpDown()
        Me.CmbMainIs = New System.Windows.Forms.ComboBox()
        Me.CmbCarOil = New System.Windows.Forms.ComboBox()
        Me.CmbCarType = New System.Windows.Forms.ComboBox()
        Me.CmbCarModel = New System.Windows.Forms.ComboBox()
        Me.CmbCarKind = New System.Windows.Forms.ComboBox()
        Me.LblBuyerName = New System.Windows.Forms.Label()
        Me.LblSalerName = New System.Windows.Forms.Label()
        Me.LblMainIs = New System.Windows.Forms.Label()
        Me.LblCarOil = New System.Windows.Forms.Label()
        Me.LblCarYear = New System.Windows.Forms.Label()
        Me.LblCarType = New System.Windows.Forms.Label()
        Me.LblCarKind = New System.Windows.Forms.Label()
        Me.LblCarModel = New System.Windows.Forms.Label()
        Me.TxtCarId = New System.Windows.Forms.TextBox()
        Me.LblCarId = New System.Windows.Forms.Label()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.TxtCarSerial = New System.Windows.Forms.TextBox()
        Me.LblCarSerial = New System.Windows.Forms.Label()
        Me.GrpSearch.SuspendLayout()
        Me.GrpResults.SuspendLayout()
        CType(Me.DgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBtns.SuspendLayout()
        Me.GrpFilter.SuspendLayout()
        CType(Me.NumToYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumFromYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.RadOnOff)
        Me.GrpSearch.Controls.Add(Me.RadStatusOff)
        Me.GrpSearch.Controls.Add(Me.RadStatusOn)
        Me.GrpSearch.Location = New System.Drawing.Point(8, 12)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(121, 100)
        Me.GrpSearch.TabIndex = 1
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "בחירת רשימת חיפוש"
        '
        'RadOnOff
        '
        Me.RadOnOff.AutoSize = True
        Me.RadOnOff.Location = New System.Drawing.Point(57, 65)
        Me.RadOnOff.Name = "RadOnOff"
        Me.RadOnOff.Size = New System.Drawing.Size(56, 17)
        Me.RadOnOff.TabIndex = 3
        Me.RadOnOff.TabStop = True
        Me.RadOnOff.Text = "גם וגם"
        Me.RadOnOff.UseVisualStyleBackColor = True
        '
        'RadStatusOff
        '
        Me.RadStatusOff.AutoSize = True
        Me.RadStatusOff.Location = New System.Drawing.Point(5, 42)
        Me.RadStatusOff.Name = "RadStatusOff"
        Me.RadStatusOff.Size = New System.Drawing.Size(108, 17)
        Me.RadStatusOff.TabIndex = 2
        Me.RadStatusOff.TabStop = True
        Me.RadStatusOff.Text = "רשימת לא זמנים"
        Me.RadStatusOff.UseVisualStyleBackColor = True
        '
        'RadStatusOn
        '
        Me.RadStatusOn.AutoSize = True
        Me.RadStatusOn.Location = New System.Drawing.Point(22, 19)
        Me.RadStatusOn.Name = "RadStatusOn"
        Me.RadStatusOn.Size = New System.Drawing.Size(91, 17)
        Me.RadStatusOn.TabIndex = 1
        Me.RadStatusOn.TabStop = True
        Me.RadStatusOn.Text = "רשימת זמנים"
        Me.RadStatusOn.UseVisualStyleBackColor = True
        '
        'GrpResults
        '
        Me.GrpResults.Controls.Add(Me.DgvResults)
        Me.GrpResults.Location = New System.Drawing.Point(8, 118)
        Me.GrpResults.Name = "GrpResults"
        Me.GrpResults.Size = New System.Drawing.Size(982, 240)
        Me.GrpResults.TabIndex = 2
        Me.GrpResults.TabStop = False
        Me.GrpResults.Text = "תוצאות חיפוש"
        '
        'DgvResults
        '
        Me.DgvResults.AllowUserToAddRows = False
        Me.DgvResults.AllowUserToDeleteRows = False
        Me.DgvResults.AllowUserToResizeColumns = False
        Me.DgvResults.AllowUserToResizeRows = False
        Me.DgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResults.Location = New System.Drawing.Point(8, 19)
        Me.DgvResults.MultiSelect = False
        Me.DgvResults.Name = "DgvResults"
        Me.DgvResults.ReadOnly = True
        Me.DgvResults.RowHeadersVisible = False
        Me.DgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvResults.Size = New System.Drawing.Size(966, 215)
        Me.DgvResults.TabIndex = 0
        '
        'GrpBtns
        '
        Me.GrpBtns.Controls.Add(Me.BtnClose)
        Me.GrpBtns.Controls.Add(Me.BtnPrint)
        Me.GrpBtns.Controls.Add(Me.BtnTC)
        Me.GrpBtns.Controls.Add(Me.BtnTUpdate)
        Me.GrpBtns.Controls.Add(Me.BtnSale)
        Me.GrpBtns.Location = New System.Drawing.Point(8, 364)
        Me.GrpBtns.Name = "GrpBtns"
        Me.GrpBtns.Size = New System.Drawing.Size(982, 85)
        Me.GrpBtns.TabIndex = 3
        Me.GrpBtns.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(8, 18)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(113, 55)
        Me.BtnClose.TabIndex = 30
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(125, 18)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(113, 55)
        Me.BtnPrint.TabIndex = 29
        Me.BtnPrint.Text = "הדפסה"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnTC
        '
        Me.BtnTC.BackColor = System.Drawing.Color.White
        Me.BtnTC.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnTC.Image = CType(resources.GetObject("BtnTC.Image"), System.Drawing.Image)
        Me.BtnTC.Location = New System.Drawing.Point(242, 18)
        Me.BtnTC.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTC.Name = "BtnTC"
        Me.BtnTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnTC.Size = New System.Drawing.Size(113, 55)
        Me.BtnTC.TabIndex = 28
        Me.BtnTC.Text = "ביטול עסקה"
        Me.BtnTC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnTC.UseVisualStyleBackColor = False
        '
        'BtnTUpdate
        '
        Me.BtnTUpdate.BackColor = System.Drawing.Color.White
        Me.BtnTUpdate.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnTUpdate.Image = CType(resources.GetObject("BtnTUpdate.Image"), System.Drawing.Image)
        Me.BtnTUpdate.Location = New System.Drawing.Point(359, 18)
        Me.BtnTUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTUpdate.Name = "BtnTUpdate"
        Me.BtnTUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnTUpdate.Size = New System.Drawing.Size(113, 55)
        Me.BtnTUpdate.TabIndex = 27
        Me.BtnTUpdate.Text = "תיקון עסקה"
        Me.BtnTUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnTUpdate.UseVisualStyleBackColor = False
        '
        'BtnSale
        '
        Me.BtnSale.BackColor = System.Drawing.Color.White
        Me.BtnSale.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSale.Image = CType(resources.GetObject("BtnSale.Image"), System.Drawing.Image)
        Me.BtnSale.Location = New System.Drawing.Point(476, 18)
        Me.BtnSale.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSale.Name = "BtnSale"
        Me.BtnSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSale.Size = New System.Drawing.Size(113, 55)
        Me.BtnSale.TabIndex = 26
        Me.BtnSale.Text = "מכירת רכב"
        Me.BtnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSale.UseVisualStyleBackColor = False
        '
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.LblClear)
        Me.GrpFilter.Controls.Add(Me.TxtSalerName)
        Me.GrpFilter.Controls.Add(Me.TxtBuyerName)
        Me.GrpFilter.Controls.Add(Me.NumToYear)
        Me.GrpFilter.Controls.Add(Me.NumFromYear)
        Me.GrpFilter.Controls.Add(Me.CmbMainIs)
        Me.GrpFilter.Controls.Add(Me.CmbCarOil)
        Me.GrpFilter.Controls.Add(Me.CmbCarType)
        Me.GrpFilter.Controls.Add(Me.CmbCarModel)
        Me.GrpFilter.Controls.Add(Me.CmbCarKind)
        Me.GrpFilter.Controls.Add(Me.LblBuyerName)
        Me.GrpFilter.Controls.Add(Me.LblSalerName)
        Me.GrpFilter.Controls.Add(Me.LblMainIs)
        Me.GrpFilter.Controls.Add(Me.LblCarOil)
        Me.GrpFilter.Controls.Add(Me.LblCarYear)
        Me.GrpFilter.Controls.Add(Me.LblCarType)
        Me.GrpFilter.Controls.Add(Me.LblCarKind)
        Me.GrpFilter.Controls.Add(Me.LblCarModel)
        Me.GrpFilter.Controls.Add(Me.TxtCarId)
        Me.GrpFilter.Controls.Add(Me.LblCarId)
        Me.GrpFilter.Controls.Add(Me.BtnReload)
        Me.GrpFilter.Controls.Add(Me.TxtCarSerial)
        Me.GrpFilter.Controls.Add(Me.LblCarSerial)
        Me.GrpFilter.Location = New System.Drawing.Point(138, 12)
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.Size = New System.Drawing.Size(852, 100)
        Me.GrpFilter.TabIndex = 4
        Me.GrpFilter.TabStop = False
        Me.GrpFilter.Text = "סינון"
        '
        'LblClear
        '
        Me.LblClear.AutoSize = True
        Me.LblClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblClear.Font = New System.Drawing.Font("David", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblClear.ForeColor = System.Drawing.Color.Blue
        Me.LblClear.Location = New System.Drawing.Point(130, 71)
        Me.LblClear.Name = "LblClear"
        Me.LblClear.Size = New System.Drawing.Size(31, 16)
        Me.LblClear.TabIndex = 61
        Me.LblClear.Text = "נקה"
        '
        'TxtSalerName
        '
        Me.TxtSalerName.Location = New System.Drawing.Point(130, 44)
        Me.TxtSalerName.Name = "TxtSalerName"
        Me.TxtSalerName.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalerName.TabIndex = 60
        '
        'TxtBuyerName
        '
        Me.TxtBuyerName.Location = New System.Drawing.Point(130, 18)
        Me.TxtBuyerName.Name = "TxtBuyerName"
        Me.TxtBuyerName.Size = New System.Drawing.Size(100, 20)
        Me.TxtBuyerName.TabIndex = 59
        '
        'NumToYear
        '
        Me.NumToYear.Location = New System.Drawing.Point(674, 70)
        Me.NumToYear.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NumToYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.NumToYear.Name = "NumToYear"
        Me.NumToYear.Size = New System.Drawing.Size(45, 20)
        Me.NumToYear.TabIndex = 58
        Me.NumToYear.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'NumFromYear
        '
        Me.NumFromYear.Location = New System.Drawing.Point(729, 70)
        Me.NumFromYear.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NumFromYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.NumFromYear.Name = "NumFromYear"
        Me.NumFromYear.Size = New System.Drawing.Size(45, 20)
        Me.NumFromYear.TabIndex = 57
        Me.NumFromYear.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'CmbMainIs
        '
        Me.CmbMainIs.FormattingEnabled = True
        Me.CmbMainIs.Items.AddRange(New Object() {"פרטי", "ליסינג", "השכרה", "יבוא אישי", "ממשלתי", "מונית"})
        Me.CmbMainIs.Location = New System.Drawing.Point(315, 44)
        Me.CmbMainIs.Name = "CmbMainIs"
        Me.CmbMainIs.Size = New System.Drawing.Size(100, 21)
        Me.CmbMainIs.TabIndex = 55
        '
        'CmbCarOil
        '
        Me.CmbCarOil.FormattingEnabled = True
        Me.CmbCarOil.Items.AddRange(New Object() {"בנזין", "דיזל", "היברידי", "חשמל"})
        Me.CmbCarOil.Location = New System.Drawing.Point(315, 18)
        Me.CmbCarOil.Name = "CmbCarOil"
        Me.CmbCarOil.Size = New System.Drawing.Size(100, 21)
        Me.CmbCarOil.TabIndex = 54
        '
        'CmbCarType
        '
        Me.CmbCarType.FormattingEnabled = True
        Me.CmbCarType.Location = New System.Drawing.Point(503, 69)
        Me.CmbCarType.Name = "CmbCarType"
        Me.CmbCarType.Size = New System.Drawing.Size(100, 21)
        Me.CmbCarType.TabIndex = 53
        '
        'CmbCarModel
        '
        Me.CmbCarModel.FormattingEnabled = True
        Me.CmbCarModel.Location = New System.Drawing.Point(503, 44)
        Me.CmbCarModel.Name = "CmbCarModel"
        Me.CmbCarModel.Size = New System.Drawing.Size(100, 21)
        Me.CmbCarModel.TabIndex = 52
        '
        'CmbCarKind
        '
        Me.CmbCarKind.FormattingEnabled = True
        Me.CmbCarKind.Location = New System.Drawing.Point(503, 18)
        Me.CmbCarKind.Name = "CmbCarKind"
        Me.CmbCarKind.Size = New System.Drawing.Size(100, 21)
        Me.CmbCarKind.TabIndex = 51
        '
        'LblBuyerName
        '
        Me.LblBuyerName.AutoSize = True
        Me.LblBuyerName.Location = New System.Drawing.Point(236, 21)
        Me.LblBuyerName.Name = "LblBuyerName"
        Me.LblBuyerName.Size = New System.Drawing.Size(56, 13)
        Me.LblBuyerName.TabIndex = 48
        Me.LblBuyerName.Text = "שם הקונה"
        '
        'LblSalerName
        '
        Me.LblSalerName.AutoSize = True
        Me.LblSalerName.Location = New System.Drawing.Point(235, 47)
        Me.LblSalerName.Name = "LblSalerName"
        Me.LblSalerName.Size = New System.Drawing.Size(57, 13)
        Me.LblSalerName.TabIndex = 46
        Me.LblSalerName.Text = "שם המוכר"
        '
        'LblMainIs
        '
        Me.LblMainIs.AutoSize = True
        Me.LblMainIs.Location = New System.Drawing.Point(423, 47)
        Me.LblMainIs.Name = "LblMainIs"
        Me.LblMainIs.Size = New System.Drawing.Size(58, 13)
        Me.LblMainIs.TabIndex = 44
        Me.LblMainIs.Text = "רישום רכב"
        '
        'LblCarOil
        '
        Me.LblCarOil.AutoSize = True
        Me.LblCarOil.Location = New System.Drawing.Point(435, 21)
        Me.LblCarOil.Name = "LblCarOil"
        Me.LblCarOil.Size = New System.Drawing.Size(46, 13)
        Me.LblCarOil.TabIndex = 42
        Me.LblCarOil.Text = "סוג דלק"
        '
        'LblCarYear
        '
        Me.LblCarYear.AutoSize = True
        Me.LblCarYear.Location = New System.Drawing.Point(790, 73)
        Me.LblCarYear.Name = "LblCarYear"
        Me.LblCarYear.Size = New System.Drawing.Size(54, 13)
        Me.LblCarYear.TabIndex = 36
        Me.LblCarYear.Text = "שנת ייצור"
        '
        'LblCarType
        '
        Me.LblCarType.AutoSize = True
        Me.LblCarType.Location = New System.Drawing.Point(609, 73)
        Me.LblCarType.Name = "LblCarType"
        Me.LblCarType.Size = New System.Drawing.Size(46, 13)
        Me.LblCarType.TabIndex = 40
        Me.LblCarType.Text = "דגם רכב"
        '
        'LblCarKind
        '
        Me.LblCarKind.AutoSize = True
        Me.LblCarKind.Location = New System.Drawing.Point(611, 21)
        Me.LblCarKind.Name = "LblCarKind"
        Me.LblCarKind.Size = New System.Drawing.Size(44, 13)
        Me.LblCarKind.TabIndex = 38
        Me.LblCarKind.Text = "סוג רכב"
        '
        'LblCarModel
        '
        Me.LblCarModel.AutoSize = True
        Me.LblCarModel.Location = New System.Drawing.Point(609, 47)
        Me.LblCarModel.Name = "LblCarModel"
        Me.LblCarModel.Size = New System.Drawing.Size(46, 13)
        Me.LblCarModel.TabIndex = 34
        Me.LblCarModel.Text = "שם יצרן"
        '
        'TxtCarId
        '
        Me.TxtCarId.Location = New System.Drawing.Point(674, 44)
        Me.TxtCarId.MaxLength = 8
        Me.TxtCarId.Name = "TxtCarId"
        Me.TxtCarId.Size = New System.Drawing.Size(100, 20)
        Me.TxtCarId.TabIndex = 33
        '
        'LblCarId
        '
        Me.LblCarId.AutoSize = True
        Me.LblCarId.Location = New System.Drawing.Point(788, 47)
        Me.LblCarId.Name = "LblCarId"
        Me.LblCarId.Size = New System.Drawing.Size(56, 13)
        Me.LblCarId.TabIndex = 32
        Me.LblCarId.Text = "מספר רכב"
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.Color.White
        Me.BtnReload.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnReload.Image = CType(resources.GetObject("BtnReload.Image"), System.Drawing.Image)
        Me.BtnReload.Location = New System.Drawing.Point(8, 18)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(97, 72)
        Me.BtnReload.TabIndex = 31
        Me.BtnReload.Text = "שליפה"
        Me.BtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'TxtCarSerial
        '
        Me.TxtCarSerial.Location = New System.Drawing.Point(674, 18)
        Me.TxtCarSerial.MaxLength = 7
        Me.TxtCarSerial.Name = "TxtCarSerial"
        Me.TxtCarSerial.Size = New System.Drawing.Size(100, 20)
        Me.TxtCarSerial.TabIndex = 1
        '
        'LblCarSerial
        '
        Me.LblCarSerial.AutoSize = True
        Me.LblCarSerial.Location = New System.Drawing.Point(780, 21)
        Me.LblCarSerial.Name = "LblCarSerial"
        Me.LblCarSerial.Size = New System.Drawing.Size(64, 13)
        Me.LblCarSerial.TabIndex = 0
        Me.LblCarSerial.Text = "מספר ביומן"
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(996, 476)
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.GrpBtns)
        Me.Controls.Add(Me.GrpResults)
        Me.Controls.Add(Me.GrpSearch)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSearch"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSearch"
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.GrpResults.ResumeLayout(False)
        CType(Me.DgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBtns.ResumeLayout(False)
        Me.GrpFilter.ResumeLayout(False)
        Me.GrpFilter.PerformLayout()
        CType(Me.NumToYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumFromYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents RadStatusOff As System.Windows.Forms.RadioButton
    Friend WithEvents RadStatusOn As System.Windows.Forms.RadioButton
    Friend WithEvents GrpResults As System.Windows.Forms.GroupBox
    Friend WithEvents DgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents GrpBtns As System.Windows.Forms.GroupBox
    Friend WithEvents GrpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCarSerial As System.Windows.Forms.TextBox
    Friend WithEvents LblCarSerial As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnTC As System.Windows.Forms.Button
    Friend WithEvents BtnTUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSale As System.Windows.Forms.Button
    Friend WithEvents BtnReload As System.Windows.Forms.Button
    Friend WithEvents LblCarModel As System.Windows.Forms.Label
    Friend WithEvents TxtCarId As System.Windows.Forms.TextBox
    Friend WithEvents LblCarId As System.Windows.Forms.Label
    Friend WithEvents LblMainIs As System.Windows.Forms.Label
    Friend WithEvents LblCarOil As System.Windows.Forms.Label
    Friend WithEvents LblCarType As System.Windows.Forms.Label
    Friend WithEvents LblCarKind As System.Windows.Forms.Label
    Friend WithEvents LblCarYear As System.Windows.Forms.Label
    Friend WithEvents LblBuyerName As System.Windows.Forms.Label
    Friend WithEvents LblSalerName As System.Windows.Forms.Label
    Friend WithEvents RadOnOff As System.Windows.Forms.RadioButton
    Friend WithEvents CmbMainIs As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCarOil As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCarType As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCarModel As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCarKind As System.Windows.Forms.ComboBox
    Friend WithEvents NumToYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumFromYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxtSalerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuyerName As System.Windows.Forms.TextBox
    Friend WithEvents LblClear As System.Windows.Forms.Label
End Class
