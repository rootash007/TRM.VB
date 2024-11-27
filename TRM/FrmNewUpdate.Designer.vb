<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewUpdate))
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCurrentVersion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNewVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.White
        Me.BtnUpdate.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnUpdate.Image = CType(resources.GetObject("BtnUpdate.Image"), System.Drawing.Image)
        Me.BtnUpdate.Location = New System.Drawing.Point(25, 84)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUpdate.Size = New System.Drawing.Size(193, 55)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update Now!"
        Me.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Current Version"
        '
        'LblCurrentVersion
        '
        Me.LblCurrentVersion.AutoSize = True
        Me.LblCurrentVersion.Location = New System.Drawing.Point(36, 20)
        Me.LblCurrentVersion.Name = "LblCurrentVersion"
        Me.LblCurrentVersion.Size = New System.Drawing.Size(55, 16)
        Me.LblCurrentVersion.TabIndex = 11
        Me.LblCurrentVersion.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "New Version"
        '
        'LblNewVersion
        '
        Me.LblNewVersion.AutoSize = True
        Me.LblNewVersion.Location = New System.Drawing.Point(36, 46)
        Me.LblNewVersion.Name = "LblNewVersion"
        Me.LblNewVersion.Size = New System.Drawing.Size(55, 16)
        Me.LblNewVersion.TabIndex = 13
        Me.LblNewVersion.Text = "Label4"
        '
        'FrmNewUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(251, 189)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblNewVersion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblCurrentVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewUpdate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update new version"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCurrentVersion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNewVersion As Label
End Class
