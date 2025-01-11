<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCostList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCostList))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVActions = New System.Windows.Forms.DataGridView()
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
        Me.DTPEndDate.Location = New System.Drawing.Point(304, 84)
        Me.DTPEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPEndDate.Name = "DTPEndDate"
        Me.DTPEndDate.Size = New System.Drawing.Size(89, 23)
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
        Me.DTPStartDate.Location = New System.Drawing.Point(305, 53)
        Me.DTPStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPStartDate.Name = "DTPStartDate"
        Me.DTPStartDate.Size = New System.Drawing.Size(88, 23)
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
        Me.DGVCostList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCostList.Size = New System.Drawing.Size(775, 342)
        Me.DGVCostList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "اسم الماده"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "الرمز"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "الكمية"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "السعر المدفوع"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column9
        '
        Me.Column9.HeaderText = "سعر الوحدة"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "السعر المستحق"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 120
        '
        'Column8
        '
        Me.Column8.HeaderText = "فرق السعر"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 120
        '
        'GrpMoney
        '
        Me.GrpMoney.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpMoney.Controls.Add(Me.DGV1)
        Me.GrpMoney.Controls.Add(Me.DTPEndDate)
        Me.GrpMoney.Controls.Add(Me.BtnCancel)
        Me.GrpMoney.Controls.Add(Me.DTPStartDate)
        Me.GrpMoney.Location = New System.Drawing.Point(13, 433)
        Me.GrpMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpMoney.Name = "GrpMoney"
        Me.GrpMoney.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpMoney.Size = New System.Drawing.Size(782, 146)
        Me.GrpMoney.TabIndex = 2
        Me.GrpMoney.TabStop = False
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
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(305, 23)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(88, 23)
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
        Me.GroupBox1.Size = New System.Drawing.Size(0, 366)
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
        Me.DGVActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVActions.Location = New System.Drawing.Point(4, 20)
        Me.DGVActions.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVActions.MultiSelect = False
        Me.DGVActions.Name = "DGVActions"
        Me.DGVActions.ReadOnly = True
        Me.DGVActions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVActions.RowHeadersVisible = False
        Me.DGVActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVActions.Size = New System.Drawing.Size(0, 342)
        Me.DGVActions.TabIndex = 0
        '
        'BtnCloseActions
        '
        Me.BtnCloseActions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCloseActions.BackColor = System.Drawing.Color.White
        Me.BtnCloseActions.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCloseActions.Image = CType(resources.GetObject("BtnCloseActions.Image"), System.Drawing.Image)
        Me.BtnCloseActions.Location = New System.Drawing.Point(667, 9)
        Me.BtnCloseActions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCloseActions.Name = "BtnCloseActions"
        Me.BtnCloseActions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCloseActions.Size = New System.Drawing.Size(129, 55)
        Me.BtnCloseActions.TabIndex = 28
        Me.BtnCloseActions.Text = "اغلاق العمليات"
        Me.BtnCloseActions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCloseActions.UseVisualStyleBackColor = False
        '
        'FrmCostList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 592)
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
        Me.Name = "FrmCostList"
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
End Class
