<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsers))
        Me.GrpUsers = New System.Windows.Forms.GroupBox()
        Me.TabUsers = New System.Windows.Forms.TabControl()
        Me.TabUsersOn = New System.Windows.Forms.TabPage()
        Me.DgvUsers = New System.Windows.Forms.DataGridView()
        Me.TabUsersOff = New System.Windows.Forms.TabPage()
        Me.DGVUsersOff = New System.Windows.Forms.DataGridView()
        Me.BtnAddUser = New System.Windows.Forms.Button()
        Me.BtnUpdateUser = New System.Windows.Forms.Button()
        Me.BtnDeleteUser = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpUsers.SuspendLayout()
        Me.TabUsers.SuspendLayout()
        Me.TabUsersOn.SuspendLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabUsersOff.SuspendLayout()
        CType(Me.DGVUsersOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpUsers
        '
        Me.GrpUsers.Controls.Add(Me.TabUsers)
        Me.GrpUsers.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GrpUsers.Location = New System.Drawing.Point(16, 13)
        Me.GrpUsers.Name = "GrpUsers"
        Me.GrpUsers.Size = New System.Drawing.Size(480, 245)
        Me.GrpUsers.TabIndex = 31
        Me.GrpUsers.TabStop = False
        Me.GrpUsers.Text = "רשימת משתמשים"
        '
        'TabUsers
        '
        Me.TabUsers.Controls.Add(Me.TabUsersOn)
        Me.TabUsers.Controls.Add(Me.TabUsersOff)
        Me.TabUsers.Location = New System.Drawing.Point(7, 20)
        Me.TabUsers.Name = "TabUsers"
        Me.TabUsers.RightToLeftLayout = True
        Me.TabUsers.SelectedIndex = 0
        Me.TabUsers.Size = New System.Drawing.Size(467, 219)
        Me.TabUsers.TabIndex = 1
        '
        'TabUsersOn
        '
        Me.TabUsersOn.Controls.Add(Me.DgvUsers)
        Me.TabUsersOn.Location = New System.Drawing.Point(4, 25)
        Me.TabUsersOn.Name = "TabUsersOn"
        Me.TabUsersOn.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUsersOn.Size = New System.Drawing.Size(459, 190)
        Me.TabUsersOn.TabIndex = 0
        Me.TabUsersOn.Text = "רשימת משתמשים פעילים"
        Me.TabUsersOn.UseVisualStyleBackColor = True
        '
        'DgvUsers
        '
        Me.DgvUsers.AllowUserToAddRows = False
        Me.DgvUsers.AllowUserToDeleteRows = False
        Me.DgvUsers.AllowUserToResizeColumns = False
        Me.DgvUsers.AllowUserToResizeRows = False
        Me.DgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsers.Location = New System.Drawing.Point(7, 6)
        Me.DgvUsers.MultiSelect = False
        Me.DgvUsers.Name = "DgvUsers"
        Me.DgvUsers.ReadOnly = True
        Me.DgvUsers.RowHeadersVisible = False
        Me.DgvUsers.RowHeadersWidth = 51
        Me.DgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsers.Size = New System.Drawing.Size(444, 177)
        Me.DgvUsers.TabIndex = 0
        '
        'TabUsersOff
        '
        Me.TabUsersOff.Controls.Add(Me.DGVUsersOff)
        Me.TabUsersOff.Location = New System.Drawing.Point(4, 25)
        Me.TabUsersOff.Name = "TabUsersOff"
        Me.TabUsersOff.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUsersOff.Size = New System.Drawing.Size(459, 190)
        Me.TabUsersOff.TabIndex = 1
        Me.TabUsersOff.Text = "רשימת משתמשים לא פעילים"
        Me.TabUsersOff.UseVisualStyleBackColor = True
        '
        'DGVUsersOff
        '
        Me.DGVUsersOff.AllowUserToAddRows = False
        Me.DGVUsersOff.AllowUserToDeleteRows = False
        Me.DGVUsersOff.AllowUserToResizeColumns = False
        Me.DGVUsersOff.AllowUserToResizeRows = False
        Me.DGVUsersOff.BackgroundColor = System.Drawing.Color.White
        Me.DGVUsersOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsersOff.Location = New System.Drawing.Point(7, 6)
        Me.DGVUsersOff.MultiSelect = False
        Me.DGVUsersOff.Name = "DGVUsersOff"
        Me.DGVUsersOff.ReadOnly = True
        Me.DGVUsersOff.RowHeadersVisible = False
        Me.DGVUsersOff.RowHeadersWidth = 51
        Me.DGVUsersOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUsersOff.Size = New System.Drawing.Size(444, 177)
        Me.DGVUsersOff.TabIndex = 1
        '
        'BtnAddUser
        '
        Me.BtnAddUser.BackColor = System.Drawing.Color.White
        Me.BtnAddUser.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddUser.Image = CType(resources.GetObject("BtnAddUser.Image"), System.Drawing.Image)
        Me.BtnAddUser.Location = New System.Drawing.Point(16, 264)
        Me.BtnAddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddUser.Name = "BtnAddUser"
        Me.BtnAddUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAddUser.Size = New System.Drawing.Size(117, 58)
        Me.BtnAddUser.TabIndex = 30
        Me.BtnAddUser.Text = "הוספת משתמש"
        Me.BtnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAddUser.UseVisualStyleBackColor = False
        '
        'BtnUpdateUser
        '
        Me.BtnUpdateUser.BackColor = System.Drawing.Color.White
        Me.BtnUpdateUser.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnUpdateUser.Image = CType(resources.GetObject("BtnUpdateUser.Image"), System.Drawing.Image)
        Me.BtnUpdateUser.Location = New System.Drawing.Point(137, 264)
        Me.BtnUpdateUser.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateUser.Name = "BtnUpdateUser"
        Me.BtnUpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUpdateUser.Size = New System.Drawing.Size(117, 58)
        Me.BtnUpdateUser.TabIndex = 29
        Me.BtnUpdateUser.Text = "עדכון משתמש"
        Me.BtnUpdateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUpdateUser.UseVisualStyleBackColor = False
        '
        'BtnDeleteUser
        '
        Me.BtnDeleteUser.BackColor = System.Drawing.Color.White
        Me.BtnDeleteUser.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnDeleteUser.Image = CType(resources.GetObject("BtnDeleteUser.Image"), System.Drawing.Image)
        Me.BtnDeleteUser.Location = New System.Drawing.Point(258, 264)
        Me.BtnDeleteUser.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDeleteUser.Name = "BtnDeleteUser"
        Me.BtnDeleteUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeleteUser.Size = New System.Drawing.Size(117, 58)
        Me.BtnDeleteUser.TabIndex = 28
        Me.BtnDeleteUser.Text = "מחיקת משתמש"
        Me.BtnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnDeleteUser.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(379, 264)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(117, 58)
        Me.BtnClose.TabIndex = 27
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 334)
        Me.Controls.Add(Me.GrpUsers)
        Me.Controls.Add(Me.BtnAddUser)
        Me.Controls.Add(Me.BtnUpdateUser)
        Me.Controls.Add(Me.BtnDeleteUser)
        Me.Controls.Add(Me.BtnClose)
        Me.Font = New System.Drawing.Font("David", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUsers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "משתמשים"
        Me.GrpUsers.ResumeLayout(False)
        Me.TabUsers.ResumeLayout(False)
        Me.TabUsersOn.ResumeLayout(False)
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabUsersOff.ResumeLayout(False)
        CType(Me.DGVUsersOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateUser As System.Windows.Forms.Button
    Friend WithEvents BtnAddUser As System.Windows.Forms.Button
    Friend WithEvents GrpUsers As System.Windows.Forms.GroupBox
    Friend WithEvents DgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents TabUsers As System.Windows.Forms.TabControl
    Friend WithEvents TabUsersOn As System.Windows.Forms.TabPage
    Friend WithEvents TabUsersOff As System.Windows.Forms.TabPage
    Friend WithEvents DGVUsersOff As System.Windows.Forms.DataGridView
End Class
