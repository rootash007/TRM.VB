<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOkMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOkMsg))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PbSign = New System.Windows.Forms.PictureBox()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PbSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(14, 19)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblTitle.Size = New System.Drawing.Size(258, 24)
        Me.LblTitle.TabIndex = 12
        Me.LblTitle.Text = "סוג הודעה"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PbSign
        '
        Me.PbSign.BackColor = System.Drawing.Color.Transparent
        Me.PbSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbSign.Image = CType(resources.GetObject("PbSign.Image"), System.Drawing.Image)
        Me.PbSign.Location = New System.Drawing.Point(16, 97)
        Me.PbSign.Name = "PbSign"
        Me.PbSign.Size = New System.Drawing.Size(72, 72)
        Me.PbSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbSign.TabIndex = 11
        Me.PbSign.TabStop = False
        '
        'LblMsg
        '
        Me.LblMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMsg.BackColor = System.Drawing.Color.Transparent
        Me.LblMsg.Font = New System.Drawing.Font("David", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblMsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblMsg.Location = New System.Drawing.Point(112, 78)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblMsg.Size = New System.Drawing.Size(160, 72)
        Me.LblMsg.TabIndex = 10
        Me.LblMsg.Text = "הודעה"
        Me.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(160, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmOkMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(282, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PbSign)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOkMsg"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PbSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PbSign As System.Windows.Forms.PictureBox
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
