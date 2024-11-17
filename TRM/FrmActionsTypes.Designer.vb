<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmActionsTypes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActionsTypes))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.TxtActionName = New System.Windows.Forms.TextBox()
        Me.LblJobId = New System.Windows.Forms.Label()
        Me.CmbActionType = New System.Windows.Forms.ComboBox()
        Me.DGVActionTypes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGVActionTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(116, 250)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(100, 55)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "שמירה"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(6, 250)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(217, 194)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl1.Size = New System.Drawing.Size(58, 13)
        Me.Lbl1.TabIndex = 2
        Me.Lbl1.Text = "שם פעולה"
        '
        'TxtActionName
        '
        Me.TxtActionName.Location = New System.Drawing.Point(6, 191)
        Me.TxtActionName.Name = "TxtActionName"
        Me.TxtActionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtActionName.Size = New System.Drawing.Size(182, 21)
        Me.TxtActionName.TabIndex = 0
        '
        'LblJobId
        '
        Me.LblJobId.AutoSize = True
        Me.LblJobId.Location = New System.Drawing.Point(217, 227)
        Me.LblJobId.Name = "LblJobId"
        Me.LblJobId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblJobId.Size = New System.Drawing.Size(57, 13)
        Me.LblJobId.TabIndex = 4
        Me.LblJobId.Text = "סוג פעולה"
        '
        'CmbActionType
        '
        Me.CmbActionType.FormattingEnabled = True
        Me.CmbActionType.Items.AddRange(New Object() {"Increase", "Decrease"})
        Me.CmbActionType.Location = New System.Drawing.Point(6, 223)
        Me.CmbActionType.Name = "CmbActionType"
        Me.CmbActionType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbActionType.Size = New System.Drawing.Size(182, 21)
        Me.CmbActionType.TabIndex = 8
        '
        'DGVActionTypes
        '
        Me.DGVActionTypes.AllowUserToAddRows = False
        Me.DGVActionTypes.AllowUserToDeleteRows = False
        Me.DGVActionTypes.AllowUserToResizeColumns = False
        Me.DGVActionTypes.AllowUserToResizeRows = False
        Me.DGVActionTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVActionTypes.BackgroundColor = System.Drawing.Color.White
        Me.DGVActionTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVActionTypes.Location = New System.Drawing.Point(6, 20)
        Me.DGVActionTypes.Name = "DGVActionTypes"
        Me.DGVActionTypes.RowHeadersVisible = False
        Me.DGVActionTypes.RowHeadersWidth = 51
        Me.DGVActionTypes.RowTemplate.Height = 24
        Me.DGVActionTypes.Size = New System.Drawing.Size(269, 165)
        Me.DGVActionTypes.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVActionTypes)
        Me.GroupBox1.Controls.Add(Me.CmbActionType)
        Me.GroupBox1.Controls.Add(Me.Lbl1)
        Me.GroupBox1.Controls.Add(Me.LblJobId)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.TxtActionName)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(283, 314)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'FrmActionsTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(306, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActionsTypes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action Types"
        CType(Me.DGVActionTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents TxtActionName As System.Windows.Forms.TextBox
    Friend WithEvents LblJobId As System.Windows.Forms.Label
    Friend WithEvents CmbActionType As ComboBox
    Friend WithEvents DGVActionTypes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
End Class
