<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeletedReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeletedReport))
        Me.GrpDeletedList = New System.Windows.Forms.GroupBox()
        Me.DGVDeleted = New System.Windows.Forms.DataGridView()
        Me.BtnCarRestore = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpDeletedList.SuspendLayout()
        CType(Me.DGVDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpDeletedList
        '
        Me.GrpDeletedList.Controls.Add(Me.DGVDeleted)
        Me.GrpDeletedList.Location = New System.Drawing.Point(14, 12)
        Me.GrpDeletedList.Name = "GrpDeletedList"
        Me.GrpDeletedList.Size = New System.Drawing.Size(890, 266)
        Me.GrpDeletedList.TabIndex = 0
        Me.GrpDeletedList.TabStop = False
        Me.GrpDeletedList.Text = "רשימת נמחקים"
        '
        'DGVDeleted
        '
        Me.DGVDeleted.AllowUserToAddRows = False
        Me.DGVDeleted.AllowUserToDeleteRows = False
        Me.DGVDeleted.AllowUserToResizeColumns = False
        Me.DGVDeleted.AllowUserToResizeRows = False
        Me.DGVDeleted.BackgroundColor = System.Drawing.Color.White
        Me.DGVDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDeleted.Location = New System.Drawing.Point(6, 19)
        Me.DGVDeleted.MultiSelect = False
        Me.DGVDeleted.Name = "DGVDeleted"
        Me.DGVDeleted.ReadOnly = True
        Me.DGVDeleted.RowHeadersVisible = False
        Me.DGVDeleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDeleted.Size = New System.Drawing.Size(875, 232)
        Me.DGVDeleted.TabIndex = 0
        '
        'BtnCarRestore
        '
        Me.BtnCarRestore.BackColor = System.Drawing.Color.White
        Me.BtnCarRestore.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCarRestore.Image = CType(resources.GetObject("BtnCarRestore.Image"), System.Drawing.Image)
        Me.BtnCarRestore.Location = New System.Drawing.Point(636, 283)
        Me.BtnCarRestore.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCarRestore.Name = "BtnCarRestore"
        Me.BtnCarRestore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCarRestore.Size = New System.Drawing.Size(132, 55)
        Me.BtnCarRestore.TabIndex = 26
        Me.BtnCarRestore.Text = "שחזור רכב"
        Me.BtnCarRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCarRestore.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(772, 283)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(132, 55)
        Me.BtnClose.TabIndex = 25
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmDeletedReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 344)
        Me.Controls.Add(Me.BtnCarRestore)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrpDeletedList)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDeletedReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "דוח נמחקים"
        Me.GrpDeletedList.ResumeLayout(False)
        CType(Me.DGVDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpDeletedList As System.Windows.Forms.GroupBox
    Friend WithEvents DGVDeleted As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCarRestore As System.Windows.Forms.Button
End Class
