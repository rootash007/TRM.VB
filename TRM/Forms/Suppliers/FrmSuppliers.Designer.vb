<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSuppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSuppliers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadAll = New System.Windows.Forms.RadioButton()
        Me.RadOff = New System.Windows.Forms.RadioButton()
        Me.RadOn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblClear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.DGVSuppliers = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.Color.White
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(12, 491)
        Me.BtnSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(126, 55)
        Me.BtnSelect.TabIndex = 3
        Me.BtnSelect.Text = "اختيار"
        Me.BtnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(276, 491)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(126, 55)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(144, 491)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(126, 55)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "اضافة مورد"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(598, 491)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(126, 55)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.Color.White
        Me.BtnReload.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnReload.Image = CType(resources.GetObject("BtnReload.Image"), System.Drawing.Image)
        Me.BtnReload.Location = New System.Drawing.Point(12, 11)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(189, 46)
        Me.BtnReload.TabIndex = 33
        Me.BtnReload.Text = "سحب المعلومات"
        Me.BtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(12, 62)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(189, 27)
        Me.TxtSearch.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadAll)
        Me.GroupBox1.Controls.Add(Me.RadOff)
        Me.GroupBox1.Controls.Add(Me.RadOn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 42)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Location = New System.Drawing.Point(8, 14)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(51, 24)
        Me.RadAll.TabIndex = 2
        Me.RadAll.Text = "الكل"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'RadOff
        '
        Me.RadOff.AutoSize = True
        Me.RadOff.Location = New System.Drawing.Point(58, 14)
        Me.RadOff.Name = "RadOff"
        Me.RadOff.Size = New System.Drawing.Size(82, 24)
        Me.RadOff.TabIndex = 1
        Me.RadOff.Text = "الغير مفعل"
        Me.RadOff.UseVisualStyleBackColor = True
        '
        'RadOn
        '
        Me.RadOn.AutoSize = True
        Me.RadOn.Location = New System.Drawing.Point(132, 14)
        Me.RadOn.Name = "RadOn"
        Me.RadOn.Size = New System.Drawing.Size(61, 24)
        Me.RadOn.TabIndex = 0
        Me.RadOn.TabStop = True
        Me.RadOn.Text = "المفعل"
        Me.RadOn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblClear)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtID)
        Me.GroupBox2.Controls.Add(Me.TxtContact)
        Me.GroupBox2.Controls.Add(Me.TxtSupplierName)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 118)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "معطيات سحب المعلومات"
        '
        'LblClear
        '
        Me.LblClear.AutoSize = True
        Me.LblClear.Font = New System.Drawing.Font("David", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblClear.ForeColor = System.Drawing.Color.Blue
        Me.LblClear.Location = New System.Drawing.Point(6, 83)
        Me.LblClear.Name = "LblClear"
        Me.LblClear.Size = New System.Drawing.Size(97, 20)
        Me.LblClear.TabIndex = 43
        Me.LblClear.Text = "تنظيف الخانات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "معرف المورد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "وجهة الاتصال"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(446, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "اسم المورد"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(225, 80)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(189, 27)
        Me.TxtID.TabIndex = 39
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(225, 51)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(189, 27)
        Me.TxtContact.TabIndex = 38
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(6, 22)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(408, 27)
        Me.TxtSupplierName.TabIndex = 37
        '
        'DGVSuppliers
        '
        Me.DGVSuppliers.AllowUserToAddRows = False
        Me.DGVSuppliers.AllowUserToDeleteRows = False
        Me.DGVSuppliers.AllowUserToResizeColumns = False
        Me.DGVSuppliers.AllowUserToResizeRows = False
        Me.DGVSuppliers.BackgroundColor = System.Drawing.Color.White
        Me.DGVSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSuppliers.GridColor = System.Drawing.Color.LightGray
        Me.DGVSuppliers.Location = New System.Drawing.Point(12, 136)
        Me.DGVSuppliers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGVSuppliers.Name = "DGVSuppliers"
        Me.DGVSuppliers.ReadOnly = True
        Me.DGVSuppliers.RowHeadersVisible = False
        Me.DGVSuppliers.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVSuppliers.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSuppliers.RowTemplate.Height = 28
        Me.DGVSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSuppliers.Size = New System.Drawing.Size(712, 347)
        Me.DGVSuppliers.TabIndex = 37
        '
        'FrmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(736, 559)
        Me.Controls.Add(Me.DGVSuppliers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnClose)
        Me.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSuppliers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "قائمة الموردين"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadAll As RadioButton
    Friend WithEvents RadOff As RadioButton
    Friend WithEvents RadOn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents TxtSupplierName As TextBox
    Friend WithEvents DGVSuppliers As DataGridView
    Friend WithEvents LblClear As Label
End Class
