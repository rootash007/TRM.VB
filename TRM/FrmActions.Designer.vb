<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmActions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActions))
        Me.GrpActionsList = New System.Windows.Forms.GroupBox()
        Me.DgvActionsList = New System.Windows.Forms.DataGridView()
        Me.LblStartDate = New System.Windows.Forms.Label()
        Me.DTPStartDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnExportToExcel = New System.Windows.Forms.Button()
        Me.BtnAddAction = New System.Windows.Forms.Button()
        Me.BtnEditAction = New System.Windows.Forms.Button()
        Me.BtnDeleteAction = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPEndDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtVendor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbUserName = New System.Windows.Forms.ComboBox()
        Me.CBOutActions = New System.Windows.Forms.CheckBox()
        Me.CBInActions = New System.Windows.Forms.CheckBox()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnImportProducts = New System.Windows.Forms.Button()
        Me.GrpActionsList.SuspendLayout()
        CType(Me.DgvActionsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpActionsList
        '
        Me.GrpActionsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpActionsList.Controls.Add(Me.DgvActionsList)
        Me.GrpActionsList.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GrpActionsList.Location = New System.Drawing.Point(13, 154)
        Me.GrpActionsList.Name = "GrpActionsList"
        Me.GrpActionsList.Size = New System.Drawing.Size(1095, 320)
        Me.GrpActionsList.TabIndex = 0
        Me.GrpActionsList.TabStop = False
        Me.GrpActionsList.Text = "قائمة العمليات"
        '
        'DgvActionsList
        '
        Me.DgvActionsList.AllowUserToAddRows = False
        Me.DgvActionsList.AllowUserToDeleteRows = False
        Me.DgvActionsList.AllowUserToResizeRows = False
        Me.DgvActionsList.BackgroundColor = System.Drawing.Color.White
        Me.DgvActionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvActionsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvActionsList.Location = New System.Drawing.Point(3, 20)
        Me.DgvActionsList.Margin = New System.Windows.Forms.Padding(5)
        Me.DgvActionsList.MultiSelect = False
        Me.DgvActionsList.Name = "DgvActionsList"
        Me.DgvActionsList.ReadOnly = True
        Me.DgvActionsList.RowHeadersVisible = False
        Me.DgvActionsList.RowHeadersWidth = 51
        Me.DgvActionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvActionsList.Size = New System.Drawing.Size(1089, 297)
        Me.DgvActionsList.TabIndex = 1
        '
        'LblStartDate
        '
        Me.LblStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblStartDate.AutoSize = True
        Me.LblStartDate.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblStartDate.Location = New System.Drawing.Point(1018, 21)
        Me.LblStartDate.Name = "LblStartDate"
        Me.LblStartDate.Size = New System.Drawing.Size(52, 17)
        Me.LblStartDate.TabIndex = 1
        Me.LblStartDate.Text = "من تاريخ"
        '
        'DTPStartDate
        '
        Me.DTPStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPStartDate.Location = New System.Drawing.Point(865, 18)
        Me.DTPStartDate.Name = "DTPStartDate"
        Me.DTPStartDate.Size = New System.Drawing.Size(147, 22)
        Me.DTPStartDate.TabIndex = 2
        '
        'BtnExportToExcel
        '
        Me.BtnExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExportToExcel.BackColor = System.Drawing.Color.White
        Me.BtnExportToExcel.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnExportToExcel.Image = CType(resources.GetObject("BtnExportToExcel.Image"), System.Drawing.Image)
        Me.BtnExportToExcel.Location = New System.Drawing.Point(196, 486)
        Me.BtnExportToExcel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnExportToExcel.Name = "BtnExportToExcel"
        Me.BtnExportToExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnExportToExcel.Size = New System.Drawing.Size(175, 55)
        Me.BtnExportToExcel.TabIndex = 42
        Me.BtnExportToExcel.Text = "نسخ لملف"
        Me.BtnExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnExportToExcel.UseVisualStyleBackColor = False
        '
        'BtnAddAction
        '
        Me.BtnAddAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddAction.BackColor = System.Drawing.Color.White
        Me.BtnAddAction.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddAction.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtnAddAction.Location = New System.Drawing.Point(13, 486)
        Me.BtnAddAction.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnAddAction.Name = "BtnAddAction"
        Me.BtnAddAction.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAddAction.Size = New System.Drawing.Size(175, 55)
        Me.BtnAddAction.TabIndex = 41
        Me.BtnAddAction.Text = "اضافة عملية"
        Me.BtnAddAction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddAction.UseVisualStyleBackColor = False
        '
        'BtnEditAction
        '
        Me.BtnEditAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditAction.BackColor = System.Drawing.Color.White
        Me.BtnEditAction.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEditAction.Image = CType(resources.GetObject("BtnEditAction.Image"), System.Drawing.Image)
        Me.BtnEditAction.Location = New System.Drawing.Point(567, 486)
        Me.BtnEditAction.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnEditAction.Name = "BtnEditAction"
        Me.BtnEditAction.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnEditAction.Size = New System.Drawing.Size(175, 55)
        Me.BtnEditAction.TabIndex = 40
        Me.BtnEditAction.Text = "تعديل عملية"
        Me.BtnEditAction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnEditAction.UseVisualStyleBackColor = False
        '
        'BtnDeleteAction
        '
        Me.BtnDeleteAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteAction.BackColor = System.Drawing.Color.White
        Me.BtnDeleteAction.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnDeleteAction.Image = Global.TRM.My.Resources.Resources.delete48
        Me.BtnDeleteAction.Location = New System.Drawing.Point(750, 486)
        Me.BtnDeleteAction.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnDeleteAction.Name = "BtnDeleteAction"
        Me.BtnDeleteAction.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeleteAction.Size = New System.Drawing.Size(175, 55)
        Me.BtnDeleteAction.TabIndex = 39
        Me.BtnDeleteAction.Text = "حذف عملية "
        Me.BtnDeleteAction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDeleteAction.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(379, 486)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(175, 55)
        Me.BtnClose.TabIndex = 38
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(783, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "حتى تاريخ"
        '
        'DTPEndDate
        '
        Me.DTPEndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEndDate.Location = New System.Drawing.Point(630, 18)
        Me.DTPEndDate.Name = "DTPEndDate"
        Me.DTPEndDate.Size = New System.Drawing.Size(147, 22)
        Me.DTPEndDate.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtVendor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbMaterial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CmbUserName)
        Me.GroupBox1.Controls.Add(Me.CBOutActions)
        Me.GroupBox1.Controls.Add(Me.CBInActions)
        Me.GroupBox1.Controls.Add(Me.BtnReload)
        Me.GroupBox1.Controls.Add(Me.LblStartDate)
        Me.GroupBox1.Controls.Add(Me.DTPEndDate)
        Me.GroupBox1.Controls.Add(Me.DTPStartDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1095, 136)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بحث"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "اسم المورد"
        '
        'TxtVendor
        '
        Me.TxtVendor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtVendor.Location = New System.Drawing.Point(280, 104)
        Me.TxtVendor.Name = "TxtVendor"
        Me.TxtVendor.Size = New System.Drawing.Size(100, 22)
        Me.TxtVendor.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(676, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "اسم المنتج"
        '
        'CmbMaterial
        '
        Me.CmbMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMaterial.FormattingEnabled = True
        Me.CmbMaterial.Location = New System.Drawing.Point(537, 104)
        Me.CmbMaterial.Name = "CmbMaterial"
        Me.CmbMaterial.Size = New System.Drawing.Size(121, 23)
        Me.CmbMaterial.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(947, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "عمليات حسب المستخدم"
        '
        'CmbUserName
        '
        Me.CmbUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUserName.FormattingEnabled = True
        Me.CmbUserName.Location = New System.Drawing.Point(820, 104)
        Me.CmbUserName.Name = "CmbUserName"
        Me.CmbUserName.Size = New System.Drawing.Size(121, 23)
        Me.CmbUserName.TabIndex = 49
        '
        'CBOutActions
        '
        Me.CBOutActions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBOutActions.AutoSize = True
        Me.CBOutActions.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CBOutActions.Location = New System.Drawing.Point(954, 80)
        Me.CBOutActions.Name = "CBOutActions"
        Me.CBOutActions.Size = New System.Drawing.Size(113, 21)
        Me.CBOutActions.TabIndex = 48
        Me.CBOutActions.Text = "عمليات الاستهلاك"
        Me.CBOutActions.UseVisualStyleBackColor = True
        '
        'CBInActions
        '
        Me.CBInActions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBInActions.AutoSize = True
        Me.CBInActions.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CBInActions.Location = New System.Drawing.Point(966, 51)
        Me.CBInActions.Name = "CBInActions"
        Me.CBInActions.Size = New System.Drawing.Size(101, 21)
        Me.CBInActions.TabIndex = 47
        Me.CBInActions.Text = "عمليات الادخال"
        Me.CBInActions.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.Color.White
        Me.BtnReload.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnReload.Image = Global.TRM.My.Resources.Resources.refresh
        Me.BtnReload.Location = New System.Drawing.Point(8, 17)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnReload.Size = New System.Drawing.Size(151, 62)
        Me.BtnReload.TabIndex = 46
        Me.BtnReload.Text = "سحب المعلومات"
        Me.BtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'BtnImportProducts
        '
        Me.BtnImportProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImportProducts.BackColor = System.Drawing.Color.White
        Me.BtnImportProducts.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnImportProducts.Image = CType(resources.GetObject("BtnImportProducts.Image"), System.Drawing.Image)
        Me.BtnImportProducts.Location = New System.Drawing.Point(933, 486)
        Me.BtnImportProducts.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnImportProducts.Name = "BtnImportProducts"
        Me.BtnImportProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnImportProducts.Size = New System.Drawing.Size(175, 55)
        Me.BtnImportProducts.TabIndex = 46
        Me.BtnImportProducts.Text = "Import products"
        Me.BtnImportProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnImportProducts.UseVisualStyleBackColor = False
        '
        'FrmActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1120, 552)
        Me.Controls.Add(Me.BtnImportProducts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExportToExcel)
        Me.Controls.Add(Me.BtnAddAction)
        Me.Controls.Add(Me.BtnEditAction)
        Me.Controls.Add(Me.BtnDeleteAction)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrpActionsList)
        Me.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmActions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "قائمة العمليات"
        Me.GrpActionsList.ResumeLayout(False)
        CType(Me.DgvActionsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActionsList As System.Windows.Forms.GroupBox
    Friend WithEvents LblStartDate As Label
    Friend WithEvents DTPStartDate As DateTimePicker
    Friend WithEvents BtnExportToExcel As Button
    Friend WithEvents BtnAddAction As Button
    Friend WithEvents BtnEditAction As Button
    Friend WithEvents BtnDeleteAction As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPEndDate As DateTimePicker
    Friend WithEvents DgvActionsList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnReload As Button
    Friend WithEvents CBOutActions As CheckBox
    Friend WithEvents CBInActions As CheckBox
    Friend WithEvents CmbUserName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbMaterial As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtVendor As TextBox
    Friend WithEvents BtnImportProducts As Button
End Class
