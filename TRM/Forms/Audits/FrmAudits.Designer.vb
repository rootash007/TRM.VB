<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAudits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAudits))
        Me.GrpDeletedList = New System.Windows.Forms.GroupBox()
        Me.DGVAudits = New System.Windows.Forms.DataGridView()
        Me.BtmAddAudit = New System.Windows.Forms.Button()
        Me.BtnCarRestore = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpDeletedList.SuspendLayout()
        CType(Me.DGVAudits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpDeletedList
        '
        Me.GrpDeletedList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpDeletedList.Controls.Add(Me.DGVAudits)
        Me.GrpDeletedList.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GrpDeletedList.Location = New System.Drawing.Point(14, 12)
        Me.GrpDeletedList.Name = "GrpDeletedList"
        Me.GrpDeletedList.Size = New System.Drawing.Size(890, 266)
        Me.GrpDeletedList.TabIndex = 0
        Me.GrpDeletedList.TabStop = False
        '
        'DGVAudits
        '
        Me.DGVAudits.AllowUserToAddRows = False
        Me.DGVAudits.AllowUserToDeleteRows = False
        Me.DGVAudits.AllowUserToResizeColumns = False
        Me.DGVAudits.AllowUserToResizeRows = False
        Me.DGVAudits.BackgroundColor = System.Drawing.Color.White
        Me.DGVAudits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAudits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAudits.Location = New System.Drawing.Point(3, 19)
        Me.DGVAudits.MultiSelect = False
        Me.DGVAudits.Name = "DGVAudits"
        Me.DGVAudits.ReadOnly = True
        Me.DGVAudits.RowHeadersVisible = False
        Me.DGVAudits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAudits.Size = New System.Drawing.Size(884, 244)
        Me.DGVAudits.TabIndex = 0
        '
        'BtmAddAudit
        '
        Me.BtmAddAudit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtmAddAudit.BackColor = System.Drawing.Color.White
        Me.BtmAddAudit.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtmAddAudit.Image = Global.TRM.My.Resources.Resources.plus
        Me.BtmAddAudit.Location = New System.Drawing.Point(14, 283)
        Me.BtmAddAudit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtmAddAudit.Name = "BtmAddAudit"
        Me.BtmAddAudit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtmAddAudit.Size = New System.Drawing.Size(132, 55)
        Me.BtmAddAudit.TabIndex = 27
        Me.BtmAddAudit.Text = "اضافة تحقق"
        Me.BtmAddAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtmAddAudit.UseVisualStyleBackColor = False
        '
        'BtnCarRestore
        '
        Me.BtnCarRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(772, 283)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(132, 55)
        Me.BtnClose.TabIndex = 25
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmAudits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 344)
        Me.Controls.Add(Me.BtmAddAudit)
        Me.Controls.Add(Me.BtnCarRestore)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrpDeletedList)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAudits"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "التحققات"
        Me.GrpDeletedList.ResumeLayout(False)
        CType(Me.DGVAudits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpDeletedList As System.Windows.Forms.GroupBox
    Friend WithEvents DGVAudits As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCarRestore As Button
    Friend WithEvents BtmAddAudit As Button
End Class
