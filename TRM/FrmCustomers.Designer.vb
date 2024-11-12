<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomers))
        Me.DgvCustomersOn = New System.Windows.Forms.DataGridView()
        Me.TabCustomers = New System.Windows.Forms.TabControl()
        Me.TabCustomersOn = New System.Windows.Forms.TabPage()
        Me.TabCustomersOff = New System.Windows.Forms.TabPage()
        Me.DGVCustomersOff = New System.Windows.Forms.DataGridView()
        Me.BtnUpdateCustomer = New System.Windows.Forms.Button()
        Me.BtnDeleteCustomer = New System.Windows.Forms.Button()
        Me.BtnAddNewCustomer = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.DgvCustomersOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCustomers.SuspendLayout()
        Me.TabCustomersOn.SuspendLayout()
        Me.TabCustomersOff.SuspendLayout()
        CType(Me.DGVCustomersOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCustomersOn
        '
        Me.DgvCustomersOn.AllowUserToAddRows = False
        Me.DgvCustomersOn.AllowUserToDeleteRows = False
        Me.DgvCustomersOn.AllowUserToResizeColumns = False
        Me.DgvCustomersOn.AllowUserToResizeRows = False
        Me.DgvCustomersOn.BackgroundColor = System.Drawing.Color.White
        Me.DgvCustomersOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCustomersOn.Location = New System.Drawing.Point(6, 6)
        Me.DgvCustomersOn.Name = "DgvCustomersOn"
        Me.DgvCustomersOn.ReadOnly = True
        Me.DgvCustomersOn.RowHeadersVisible = False
        Me.DgvCustomersOn.RowTemplate.Height = 28
        Me.DgvCustomersOn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCustomersOn.Size = New System.Drawing.Size(1029, 301)
        Me.DgvCustomersOn.TabIndex = 4
        '
        'TabCustomers
        '
        Me.TabCustomers.Controls.Add(Me.TabCustomersOn)
        Me.TabCustomers.Controls.Add(Me.TabCustomersOff)
        Me.TabCustomers.Location = New System.Drawing.Point(12, 12)
        Me.TabCustomers.Name = "TabCustomers"
        Me.TabCustomers.RightToLeftLayout = True
        Me.TabCustomers.SelectedIndex = 0
        Me.TabCustomers.Size = New System.Drawing.Size(1049, 340)
        Me.TabCustomers.TabIndex = 10
        '
        'TabCustomersOn
        '
        Me.TabCustomersOn.Controls.Add(Me.DgvCustomersOn)
        Me.TabCustomersOn.Location = New System.Drawing.Point(4, 23)
        Me.TabCustomersOn.Name = "TabCustomersOn"
        Me.TabCustomersOn.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCustomersOn.Size = New System.Drawing.Size(1041, 313)
        Me.TabCustomersOn.TabIndex = 0
        Me.TabCustomersOn.Text = "רשימת לקוחות פעילים"
        Me.TabCustomersOn.UseVisualStyleBackColor = True
        '
        'TabCustomersOff
        '
        Me.TabCustomersOff.Controls.Add(Me.DGVCustomersOff)
        Me.TabCustomersOff.Location = New System.Drawing.Point(4, 23)
        Me.TabCustomersOff.Name = "TabCustomersOff"
        Me.TabCustomersOff.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCustomersOff.Size = New System.Drawing.Size(1041, 313)
        Me.TabCustomersOff.TabIndex = 1
        Me.TabCustomersOff.Text = "רשימת לקוחות לא פעילים"
        Me.TabCustomersOff.UseVisualStyleBackColor = True
        '
        'DGVCustomersOff
        '
        Me.DGVCustomersOff.AllowUserToAddRows = False
        Me.DGVCustomersOff.AllowUserToDeleteRows = False
        Me.DGVCustomersOff.AllowUserToResizeColumns = False
        Me.DGVCustomersOff.AllowUserToResizeRows = False
        Me.DGVCustomersOff.BackgroundColor = System.Drawing.Color.White
        Me.DGVCustomersOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomersOff.Location = New System.Drawing.Point(6, 6)
        Me.DGVCustomersOff.Name = "DGVCustomersOff"
        Me.DGVCustomersOff.ReadOnly = True
        Me.DGVCustomersOff.RowHeadersVisible = False
        Me.DGVCustomersOff.RowTemplate.Height = 28
        Me.DGVCustomersOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCustomersOff.Size = New System.Drawing.Size(1029, 301)
        Me.DGVCustomersOff.TabIndex = 0
        '
        'BtnUpdateCustomer
        '
        Me.BtnUpdateCustomer.BackColor = System.Drawing.Color.White
        Me.BtnUpdateCustomer.Image = CType(resources.GetObject("BtnUpdateCustomer.Image"), System.Drawing.Image)
        Me.BtnUpdateCustomer.Location = New System.Drawing.Point(133, 358)
        Me.BtnUpdateCustomer.Name = "BtnUpdateCustomer"
        Me.BtnUpdateCustomer.Size = New System.Drawing.Size(115, 55)
        Me.BtnUpdateCustomer.TabIndex = 9
        Me.BtnUpdateCustomer.Text = "עדכון "
        Me.BtnUpdateCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUpdateCustomer.UseVisualStyleBackColor = False
        '
        'BtnDeleteCustomer
        '
        Me.BtnDeleteCustomer.BackColor = System.Drawing.Color.White
        Me.BtnDeleteCustomer.Image = CType(resources.GetObject("BtnDeleteCustomer.Image"), System.Drawing.Image)
        Me.BtnDeleteCustomer.Location = New System.Drawing.Point(254, 358)
        Me.BtnDeleteCustomer.Name = "BtnDeleteCustomer"
        Me.BtnDeleteCustomer.Size = New System.Drawing.Size(115, 55)
        Me.BtnDeleteCustomer.TabIndex = 8
        Me.BtnDeleteCustomer.Text = "מחיקה"
        Me.BtnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDeleteCustomer.UseVisualStyleBackColor = False
        '
        'BtnAddNewCustomer
        '
        Me.BtnAddNewCustomer.BackColor = System.Drawing.Color.White
        Me.BtnAddNewCustomer.Image = CType(resources.GetObject("BtnAddNewCustomer.Image"), System.Drawing.Image)
        Me.BtnAddNewCustomer.Location = New System.Drawing.Point(12, 358)
        Me.BtnAddNewCustomer.Name = "BtnAddNewCustomer"
        Me.BtnAddNewCustomer.Size = New System.Drawing.Size(115, 55)
        Me.BtnAddNewCustomer.TabIndex = 7
        Me.BtnAddNewCustomer.Text = "לקוח חדש"
        Me.BtnAddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddNewCustomer.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(375, 358)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(115, 55)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 434)
        Me.Controls.Add(Me.TabCustomers)
        Me.Controls.Add(Me.BtnUpdateCustomer)
        Me.Controls.Add(Me.BtnDeleteCustomer)
        Me.Controls.Add(Me.BtnAddNewCustomer)
        Me.Controls.Add(Me.BtnClose)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCustomers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "רשימת לקוחות"
        CType(Me.DgvCustomersOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCustomers.ResumeLayout(False)
        Me.TabCustomersOn.ResumeLayout(False)
        Me.TabCustomersOff.ResumeLayout(False)
        CType(Me.DGVCustomersOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvCustomersOn As System.Windows.Forms.DataGridView
    Friend WithEvents TabCustomers As System.Windows.Forms.TabControl
    Friend WithEvents TabCustomersOn As System.Windows.Forms.TabPage
    Friend WithEvents TabCustomersOff As System.Windows.Forms.TabPage
    Friend WithEvents DGVCustomersOff As System.Windows.Forms.DataGridView
    Friend WithEvents BtnUpdateCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnAddNewCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
