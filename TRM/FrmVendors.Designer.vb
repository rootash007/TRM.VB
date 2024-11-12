<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendors))
        Me.DgvVendorsOn = New System.Windows.Forms.DataGridView()
        Me.BtnUpdateVendor = New System.Windows.Forms.Button()
        Me.BtnDeleteVendor = New System.Windows.Forms.Button()
        Me.BtnAddNewVendor = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TabVendors = New System.Windows.Forms.TabControl()
        Me.TabVendorsOn = New System.Windows.Forms.TabPage()
        Me.TabVendorsOff = New System.Windows.Forms.TabPage()
        Me.DGVVendorsOff = New System.Windows.Forms.DataGridView()
        CType(Me.DgvVendorsOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVendors.SuspendLayout()
        Me.TabVendorsOn.SuspendLayout()
        Me.TabVendorsOff.SuspendLayout()
        CType(Me.DGVVendorsOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvVendorsOn
        '
        Me.DgvVendorsOn.AllowUserToAddRows = False
        Me.DgvVendorsOn.AllowUserToDeleteRows = False
        Me.DgvVendorsOn.AllowUserToResizeColumns = False
        Me.DgvVendorsOn.AllowUserToResizeRows = False
        Me.DgvVendorsOn.BackgroundColor = System.Drawing.Color.White
        Me.DgvVendorsOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVendorsOn.Location = New System.Drawing.Point(6, 6)
        Me.DgvVendorsOn.Name = "DgvVendorsOn"
        Me.DgvVendorsOn.ReadOnly = True
        Me.DgvVendorsOn.RowHeadersVisible = False
        Me.DgvVendorsOn.RowTemplate.Height = 28
        Me.DgvVendorsOn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVendorsOn.Size = New System.Drawing.Size(1029, 301)
        Me.DgvVendorsOn.TabIndex = 4
        '
        'BtnUpdateVendor
        '
        Me.BtnUpdateVendor.BackColor = System.Drawing.Color.White
        Me.BtnUpdateVendor.Image = CType(resources.GetObject("BtnUpdateVendor.Image"), System.Drawing.Image)
        Me.BtnUpdateVendor.Location = New System.Drawing.Point(133, 358)
        Me.BtnUpdateVendor.Name = "BtnUpdateVendor"
        Me.BtnUpdateVendor.Size = New System.Drawing.Size(115, 55)
        Me.BtnUpdateVendor.TabIndex = 3
        Me.BtnUpdateVendor.Text = "עדכון  "
        Me.BtnUpdateVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUpdateVendor.UseVisualStyleBackColor = False
        '
        'BtnDeleteVendor
        '
        Me.BtnDeleteVendor.BackColor = System.Drawing.Color.White
        Me.BtnDeleteVendor.Image = CType(resources.GetObject("BtnDeleteVendor.Image"), System.Drawing.Image)
        Me.BtnDeleteVendor.Location = New System.Drawing.Point(254, 358)
        Me.BtnDeleteVendor.Name = "BtnDeleteVendor"
        Me.BtnDeleteVendor.Size = New System.Drawing.Size(115, 55)
        Me.BtnDeleteVendor.TabIndex = 2
        Me.BtnDeleteVendor.Text = "מחיקה"
        Me.BtnDeleteVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDeleteVendor.UseVisualStyleBackColor = False
        '
        'BtnAddNewVendor
        '
        Me.BtnAddNewVendor.BackColor = System.Drawing.Color.White
        Me.BtnAddNewVendor.Image = CType(resources.GetObject("BtnAddNewVendor.Image"), System.Drawing.Image)
        Me.BtnAddNewVendor.Location = New System.Drawing.Point(12, 358)
        Me.BtnAddNewVendor.Name = "BtnAddNewVendor"
        Me.BtnAddNewVendor.Size = New System.Drawing.Size(115, 55)
        Me.BtnAddNewVendor.TabIndex = 1
        Me.BtnAddNewVendor.Text = "ספק חדש"
        Me.BtnAddNewVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddNewVendor.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(375, 358)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(115, 55)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TabVendors
        '
        Me.TabVendors.Controls.Add(Me.TabVendorsOn)
        Me.TabVendors.Controls.Add(Me.TabVendorsOff)
        Me.TabVendors.Location = New System.Drawing.Point(12, 12)
        Me.TabVendors.Name = "TabVendors"
        Me.TabVendors.RightToLeftLayout = True
        Me.TabVendors.SelectedIndex = 0
        Me.TabVendors.Size = New System.Drawing.Size(1049, 340)
        Me.TabVendors.TabIndex = 5
        '
        'TabVendorsOn
        '
        Me.TabVendorsOn.Controls.Add(Me.DgvVendorsOn)
        Me.TabVendorsOn.Location = New System.Drawing.Point(4, 23)
        Me.TabVendorsOn.Name = "TabVendorsOn"
        Me.TabVendorsOn.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVendorsOn.Size = New System.Drawing.Size(1041, 313)
        Me.TabVendorsOn.TabIndex = 0
        Me.TabVendorsOn.Text = "רשימת ספקים פעילים"
        Me.TabVendorsOn.UseVisualStyleBackColor = True
        '
        'TabVendorsOff
        '
        Me.TabVendorsOff.Controls.Add(Me.DGVVendorsOff)
        Me.TabVendorsOff.Location = New System.Drawing.Point(4, 23)
        Me.TabVendorsOff.Name = "TabVendorsOff"
        Me.TabVendorsOff.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVendorsOff.Size = New System.Drawing.Size(1041, 313)
        Me.TabVendorsOff.TabIndex = 1
        Me.TabVendorsOff.Text = "רשימת ספקים לא פעילים"
        Me.TabVendorsOff.UseVisualStyleBackColor = True
        '
        'DGVVendorsOff
        '
        Me.DGVVendorsOff.AllowUserToAddRows = False
        Me.DGVVendorsOff.AllowUserToDeleteRows = False
        Me.DGVVendorsOff.AllowUserToResizeColumns = False
        Me.DGVVendorsOff.AllowUserToResizeRows = False
        Me.DGVVendorsOff.BackgroundColor = System.Drawing.Color.White
        Me.DGVVendorsOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVendorsOff.Location = New System.Drawing.Point(6, 6)
        Me.DGVVendorsOff.Name = "DGVVendorsOff"
        Me.DGVVendorsOff.ReadOnly = True
        Me.DGVVendorsOff.RowHeadersVisible = False
        Me.DGVVendorsOff.RowTemplate.Height = 28
        Me.DGVVendorsOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVendorsOff.Size = New System.Drawing.Size(1029, 301)
        Me.DGVVendorsOff.TabIndex = 0
        '
        'FrmVendors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 429)
        Me.Controls.Add(Me.TabVendors)
        Me.Controls.Add(Me.BtnUpdateVendor)
        Me.Controls.Add(Me.BtnDeleteVendor)
        Me.Controls.Add(Me.BtnAddNewVendor)
        Me.Controls.Add(Me.BtnClose)
        Me.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVendors"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "רשימת ספקים"
        CType(Me.DgvVendorsOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVendors.ResumeLayout(False)
        Me.TabVendorsOn.ResumeLayout(False)
        Me.TabVendorsOff.ResumeLayout(False)
        CType(Me.DGVVendorsOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnAddNewVendor As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteVendor As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateVendor As System.Windows.Forms.Button
    Friend WithEvents DgvVendorsOn As System.Windows.Forms.DataGridView
    Friend WithEvents TabVendors As System.Windows.Forms.TabControl
    Friend WithEvents TabVendorsOn As System.Windows.Forms.TabPage
    Friend WithEvents TabVendorsOff As System.Windows.Forms.TabPage
    Friend WithEvents DGVVendorsOff As System.Windows.Forms.DataGridView
End Class
