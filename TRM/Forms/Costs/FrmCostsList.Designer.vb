<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCostsList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCostsList))
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.DTPEndDate = New System.Windows.Forms.DateTimePicker()
        Me.NumYear = New System.Windows.Forms.NumericUpDown()
        Me.DTPStartDate = New System.Windows.Forms.DateTimePicker()
        Me.GrpList = New System.Windows.Forms.GroupBox()
        Me.DGVCostList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpMoney = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPaid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDeff = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMaterialCount = New System.Windows.Forms.TextBox()
        Me.BtnExportToExcel = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVActions = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCloseActions = New System.Windows.Forms.Button()
        CType(Me.NumYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpList.SuspendLayout()
        CType(Me.DGVCostList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpMoney.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVActions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.Color.White
        Me.BtnReload.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnReload.Image = CType(resources.GetObject("BtnReload.Image"), System.Drawing.Image)
        Me.BtnReload.Location = New System.Drawing.Point(111, 9)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(129, 55)
        Me.BtnReload.TabIndex = 32
        Me.BtnReload.Text = "שליפה"
        Me.BtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'DTPEndDate
        '
        Me.DTPEndDate.CustomFormat = ""
        Me.DTPEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEndDate.Location = New System.Drawing.Point(8, 59)
        Me.DTPEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPEndDate.Name = "DTPEndDate"
        Me.DTPEndDate.Size = New System.Drawing.Size(90, 23)
        Me.DTPEndDate.TabIndex = 5
        Me.DTPEndDate.Visible = False
        '
        'NumYear
        '
        Me.NumYear.Location = New System.Drawing.Point(16, 35)
        Me.NumYear.Margin = New System.Windows.Forms.Padding(4)
        Me.NumYear.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.NumYear.Minimum = New Decimal(New Integer() {2023, 0, 0, 0})
        Me.NumYear.Name = "NumYear"
        Me.NumYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumYear.Size = New System.Drawing.Size(88, 23)
        Me.NumYear.TabIndex = 3
        Me.NumYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumYear.Value = New Decimal(New Integer() {2023, 0, 0, 0})
        '
        'DTPStartDate
        '
        Me.DTPStartDate.CustomFormat = "yyyy"
        Me.DTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPStartDate.Location = New System.Drawing.Point(8, 37)
        Me.DTPStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPStartDate.Name = "DTPStartDate"
        Me.DTPStartDate.Size = New System.Drawing.Size(90, 23)
        Me.DTPStartDate.TabIndex = 0
        Me.DTPStartDate.Visible = False
        '
        'GrpList
        '
        Me.GrpList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpList.Controls.Add(Me.DGVCostList)
        Me.GrpList.Location = New System.Drawing.Point(13, 66)
        Me.GrpList.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpList.Name = "GrpList"
        Me.GrpList.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpList.Size = New System.Drawing.Size(783, 366)
        Me.GrpList.TabIndex = 1
        Me.GrpList.TabStop = False
        '
        'DGVCostList
        '
        Me.DGVCostList.AllowUserToAddRows = False
        Me.DGVCostList.AllowUserToDeleteRows = False
        Me.DGVCostList.AllowUserToResizeColumns = False
        Me.DGVCostList.AllowUserToResizeRows = False
        Me.DGVCostList.BackgroundColor = System.Drawing.Color.White
        Me.DGVCostList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCostList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column9, Me.Column7, Me.Column8})
        Me.DGVCostList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCostList.Location = New System.Drawing.Point(4, 20)
        Me.DGVCostList.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVCostList.MultiSelect = False
        Me.DGVCostList.Name = "DGVCostList"
        Me.DGVCostList.ReadOnly = True
        Me.DGVCostList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVCostList.RowHeadersVisible = False
        Me.DGVCostList.RowHeadersWidth = 51
        Me.DGVCostList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCostList.Size = New System.Drawing.Size(775, 342)
        Me.DGVCostList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "اسم الماده"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "الرمز"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "الكمية"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "السعر المدفوع"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column9
        '
        Me.Column9.HeaderText = "سعر الوحدة"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "السعر المستحق"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 120
        '
        'Column8
        '
        Me.Column8.HeaderText = "فرق السعر"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 120
        '
        'GrpMoney
        '
        Me.GrpMoney.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpMoney.Controls.Add(Me.Label5)
        Me.GrpMoney.Controls.Add(Me.TxtPaid)
        Me.GrpMoney.Controls.Add(Me.Label4)
        Me.GrpMoney.Controls.Add(Me.TxtCost)
        Me.GrpMoney.Controls.Add(Me.Label3)
        Me.GrpMoney.Controls.Add(Me.TxtDeff)
        Me.GrpMoney.Controls.Add(Me.Label2)
        Me.GrpMoney.Controls.Add(Me.TxtMaterialCount)
        Me.GrpMoney.Controls.Add(Me.BtnExportToExcel)
        Me.GrpMoney.Controls.Add(Me.DGV1)
        Me.GrpMoney.Controls.Add(Me.DTPEndDate)
        Me.GrpMoney.Controls.Add(Me.BtnCancel)
        Me.GrpMoney.Controls.Add(Me.DTPStartDate)
        Me.GrpMoney.Location = New System.Drawing.Point(13, 433)
        Me.GrpMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpMoney.Name = "GrpMoney"
        Me.GrpMoney.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpMoney.Size = New System.Drawing.Size(1058, 146)
        Me.GrpMoney.TabIndex = 2
        Me.GrpMoney.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(965, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "المبلغ الكلي المدفوع"
        '
        'TxtPaid
        '
        Me.TxtPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPaid.Enabled = False
        Me.TxtPaid.Location = New System.Drawing.Point(859, 46)
        Me.TxtPaid.Name = "TxtPaid"
        Me.TxtPaid.Size = New System.Drawing.Size(100, 23)
        Me.TxtPaid.TabIndex = 45
        Me.TxtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(960, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "المبلغ الكلي المستحق"
        '
        'TxtCost
        '
        Me.TxtCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCost.Enabled = False
        Me.TxtCost.Location = New System.Drawing.Point(859, 75)
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(100, 23)
        Me.TxtCost.TabIndex = 43
        Me.TxtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1003, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "فرق المبلغ"
        '
        'TxtDeff
        '
        Me.TxtDeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDeff.Enabled = False
        Me.TxtDeff.Location = New System.Drawing.Point(859, 104)
        Me.TxtDeff.Name = "TxtDeff"
        Me.TxtDeff.Size = New System.Drawing.Size(100, 23)
        Me.TxtDeff.TabIndex = 41
        Me.TxtDeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1003, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "عدد المواد"
        '
        'TxtMaterialCount
        '
        Me.TxtMaterialCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMaterialCount.Enabled = False
        Me.TxtMaterialCount.Location = New System.Drawing.Point(859, 17)
        Me.TxtMaterialCount.Name = "TxtMaterialCount"
        Me.TxtMaterialCount.Size = New System.Drawing.Size(100, 23)
        Me.TxtMaterialCount.TabIndex = 39
        Me.TxtMaterialCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExportToExcel
        '
        Me.BtnExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExportToExcel.BackColor = System.Drawing.Color.White
        Me.BtnExportToExcel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnExportToExcel.Image = CType(resources.GetObject("BtnExportToExcel.Image"), System.Drawing.Image)
        Me.BtnExportToExcel.Location = New System.Drawing.Point(144, 84)
        Me.BtnExportToExcel.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BtnExportToExcel.Name = "BtnExportToExcel"
        Me.BtnExportToExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnExportToExcel.Size = New System.Drawing.Size(156, 55)
        Me.BtnExportToExcel.TabIndex = 38
        Me.BtnExportToExcel.Text = "تصدير الى اكسيل"
        Me.BtnExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnExportToExcel.UseVisualStyleBackColor = False
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(8, 14)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.Size = New System.Drawing.Size(90, 23)
        Me.DGV1.TabIndex = 27
        Me.DGV1.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(7, 84)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(129, 55)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "اغلاق"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "السنة"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGVActions)
        Me.GroupBox1.Location = New System.Drawing.Point(800, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(276, 366)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'DGVActions
        '
        Me.DGVActions.AllowUserToAddRows = False
        Me.DGVActions.AllowUserToDeleteRows = False
        Me.DGVActions.AllowUserToResizeColumns = False
        Me.DGVActions.AllowUserToResizeRows = False
        Me.DGVActions.BackgroundColor = System.Drawing.Color.White
        Me.DGVActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVActions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        Me.DGVActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVActions.Location = New System.Drawing.Point(4, 20)
        Me.DGVActions.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVActions.MultiSelect = False
        Me.DGVActions.Name = "DGVActions"
        Me.DGVActions.ReadOnly = True
        Me.DGVActions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVActions.RowHeadersVisible = False
        Me.DGVActions.RowHeadersWidth = 51
        Me.DGVActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVActions.Size = New System.Drawing.Size(268, 342)
        Me.DGVActions.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "اسم المادة"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "الرمز"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "المستخدم"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "الكمية"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "التاريخ"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "الطلبية"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "السعر"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "التسلسل"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        '
        'BtnCloseActions
        '
        Me.BtnCloseActions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCloseActions.BackColor = System.Drawing.Color.White
        Me.BtnCloseActions.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCloseActions.Image = CType(resources.GetObject("BtnCloseActions.Image"), System.Drawing.Image)
        Me.BtnCloseActions.Location = New System.Drawing.Point(943, 9)
        Me.BtnCloseActions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCloseActions.Name = "BtnCloseActions"
        Me.BtnCloseActions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCloseActions.Size = New System.Drawing.Size(129, 55)
        Me.BtnCloseActions.TabIndex = 28
        Me.BtnCloseActions.Text = "اغلاق العمليات"
        Me.BtnCloseActions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCloseActions.UseVisualStyleBackColor = False
        '
        'FrmCostsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1084, 592)
        Me.Controls.Add(Me.BtnCloseActions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpMoney)
        Me.Controls.Add(Me.GrpList)
        Me.Controls.Add(Me.NumYear)
        Me.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCostsList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "מכירת רכב"
        CType(Me.NumYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpList.ResumeLayout(False)
        CType(Me.DGVCostList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpMoney.ResumeLayout(False)
        Me.GrpMoney.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVActions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpList As System.Windows.Forms.GroupBox
    Friend WithEvents DGVCostList As System.Windows.Forms.DataGridView
    Friend WithEvents GrpMoney As System.Windows.Forms.GroupBox
    Friend WithEvents DTPStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents NumYear As NumericUpDown
    Friend WithEvents BtnReload As Button
    Friend WithEvents DTPEndDate As DateTimePicker
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVActions As DataGridView
    Friend WithEvents BtnCloseActions As Button
    Friend WithEvents BtnExportToExcel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDeff As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMaterialCount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPaid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCost As TextBox
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
End Class
