<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportChose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportChose))
        Me.LBReports = New System.Windows.Forms.ListBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpReports = New System.Windows.Forms.GroupBox()
        Me.GrpReports.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBReports
        '
        Me.LBReports.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LBReports.FormattingEnabled = True
        Me.LBReports.ItemHeight = 16
        Me.LBReports.Items.AddRange(New Object() {"דוח מלאי", "דוח רכבים שנמכרו", "דוח רכבים שנמקחו"})
        Me.LBReports.Location = New System.Drawing.Point(6, 31)
        Me.LBReports.Name = "LBReports"
        Me.LBReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBReports.Size = New System.Drawing.Size(192, 116)
        Me.LBReports.TabIndex = 0
        '
        'BtnShow
        '
        Me.BtnShow.BackColor = System.Drawing.Color.White
        Me.BtnShow.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnShow.Image = CType(resources.GetObject("BtnShow.Image"), System.Drawing.Image)
        Me.BtnShow.Location = New System.Drawing.Point(11, 170)
        Me.BtnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnShow.Size = New System.Drawing.Size(100, 55)
        Me.BtnShow.TabIndex = 9
        Me.BtnShow.Text = "הצג"
        Me.BtnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnShow.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(115, 170)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'GrpReports
        '
        Me.GrpReports.Controls.Add(Me.LBReports)
        Me.GrpReports.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GrpReports.Location = New System.Drawing.Point(11, 12)
        Me.GrpReports.Name = "GrpReports"
        Me.GrpReports.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpReports.Size = New System.Drawing.Size(204, 153)
        Me.GrpReports.TabIndex = 10
        Me.GrpReports.TabStop = False
        Me.GrpReports.Text = "בחירת סוג דוח"
        '
        'FrmReportChose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(226, 236)
        Me.Controls.Add(Me.GrpReports)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnShow)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportChose"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "דוחות"
        Me.GrpReports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBReports As System.Windows.Forms.ListBox
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents GrpReports As System.Windows.Forms.GroupBox
End Class
