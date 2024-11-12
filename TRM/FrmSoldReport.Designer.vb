<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoldReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoldReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.DGVSoldReport = New System.Windows.Forms.DataGridView()
        Me.GrpResults = New System.Windows.Forms.GroupBox()
        Me.LblNoResults = New System.Windows.Forms.Label()
        Me.GrpCount = New System.Windows.Forms.GroupBox()
        Me.TxtTotalProfits = New System.Windows.Forms.TextBox()
        Me.TxtTotalOut = New System.Windows.Forms.TextBox()
        Me.TxtTotalIn = New System.Windows.Forms.TextBox()
        Me.TxtCarsTotal = New System.Windows.Forms.TextBox()
        Me.LblTotalProfits = New System.Windows.Forms.Label()
        Me.LblTotalOut = New System.Windows.Forms.Label()
        Me.LblTotalIn = New System.Windows.Forms.Label()
        Me.LblCarsTotal = New System.Windows.Forms.Label()
        Me.GrpBtns = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAbort = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVSoldReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpResults.SuspendLayout()
        Me.GrpCount.SuspendLayout()
        Me.GrpBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DtpFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnReload)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(972, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "תנאי דוח"
        '
        'DtpTo
        '
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTo.Location = New System.Drawing.Point(727, 47)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(96, 20)
        Me.DtpTo.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(847, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "עד תאריך :"
        '
        'DtpFrom
        '
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFrom.Location = New System.Drawing.Point(727, 12)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(96, 20)
        Me.DtpFrom.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(854, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "מתאריך :"
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.Color.White
        Me.BtnReload.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnReload.Image = CType(resources.GetObject("BtnReload.Image"), System.Drawing.Image)
        Me.BtnReload.Location = New System.Drawing.Point(609, 12)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(97, 55)
        Me.BtnReload.TabIndex = 11
        Me.BtnReload.Text = "שליפה"
        Me.BtnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'DGVSoldReport
        '
        Me.DGVSoldReport.AllowUserToAddRows = False
        Me.DGVSoldReport.AllowUserToDeleteRows = False
        Me.DGVSoldReport.AllowUserToOrderColumns = True
        Me.DGVSoldReport.AllowUserToResizeRows = False
        Me.DGVSoldReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSoldReport.Location = New System.Drawing.Point(6, 19)
        Me.DGVSoldReport.MultiSelect = False
        Me.DGVSoldReport.Name = "DGVSoldReport"
        Me.DGVSoldReport.ReadOnly = True
        Me.DGVSoldReport.RowHeadersVisible = False
        Me.DGVSoldReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSoldReport.Size = New System.Drawing.Size(960, 223)
        Me.DGVSoldReport.TabIndex = 1
        '
        'GrpResults
        '
        Me.GrpResults.Controls.Add(Me.LblNoResults)
        Me.GrpResults.Controls.Add(Me.DGVSoldReport)
        Me.GrpResults.Location = New System.Drawing.Point(12, 98)
        Me.GrpResults.Name = "GrpResults"
        Me.GrpResults.Size = New System.Drawing.Size(972, 248)
        Me.GrpResults.TabIndex = 2
        Me.GrpResults.TabStop = False
        Me.GrpResults.Text = "תוצאות"
        '
        'LblNoResults
        '
        Me.LblNoResults.AutoSize = True
        Me.LblNoResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNoResults.Font = New System.Drawing.Font("David", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblNoResults.ForeColor = System.Drawing.Color.Maroon
        Me.LblNoResults.Location = New System.Drawing.Point(337, 98)
        Me.LblNoResults.Name = "LblNoResults"
        Me.LblNoResults.Size = New System.Drawing.Size(299, 65)
        Me.LblNoResults.TabIndex = 4
        Me.LblNoResults.Text = "אין תוצאות"
        '
        'GrpCount
        '
        Me.GrpCount.Controls.Add(Me.TxtTotalProfits)
        Me.GrpCount.Controls.Add(Me.TxtTotalOut)
        Me.GrpCount.Controls.Add(Me.TxtTotalIn)
        Me.GrpCount.Controls.Add(Me.TxtCarsTotal)
        Me.GrpCount.Controls.Add(Me.LblTotalProfits)
        Me.GrpCount.Controls.Add(Me.LblTotalOut)
        Me.GrpCount.Controls.Add(Me.LblTotalIn)
        Me.GrpCount.Controls.Add(Me.LblCarsTotal)
        Me.GrpCount.Location = New System.Drawing.Point(787, 352)
        Me.GrpCount.Name = "GrpCount"
        Me.GrpCount.Size = New System.Drawing.Size(197, 197)
        Me.GrpCount.TabIndex = 3
        Me.GrpCount.TabStop = False
        Me.GrpCount.Text = "חישוב תוצאות"
        '
        'TxtTotalProfits
        '
        Me.TxtTotalProfits.Location = New System.Drawing.Point(6, 171)
        Me.TxtTotalProfits.Name = "TxtTotalProfits"
        Me.TxtTotalProfits.ReadOnly = True
        Me.TxtTotalProfits.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalProfits.TabIndex = 28
        '
        'TxtTotalOut
        '
        Me.TxtTotalOut.Location = New System.Drawing.Point(6, 145)
        Me.TxtTotalOut.Name = "TxtTotalOut"
        Me.TxtTotalOut.ReadOnly = True
        Me.TxtTotalOut.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalOut.TabIndex = 27
        '
        'TxtTotalIn
        '
        Me.TxtTotalIn.Location = New System.Drawing.Point(6, 119)
        Me.TxtTotalIn.Name = "TxtTotalIn"
        Me.TxtTotalIn.ReadOnly = True
        Me.TxtTotalIn.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalIn.TabIndex = 23
        '
        'TxtCarsTotal
        '
        Me.TxtCarsTotal.Location = New System.Drawing.Point(6, 93)
        Me.TxtCarsTotal.Name = "TxtCarsTotal"
        Me.TxtCarsTotal.ReadOnly = True
        Me.TxtCarsTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtCarsTotal.TabIndex = 24
        '
        'LblTotalProfits
        '
        Me.LblTotalProfits.AutoSize = True
        Me.LblTotalProfits.Location = New System.Drawing.Point(112, 174)
        Me.LblTotalProfits.Name = "LblTotalProfits"
        Me.LblTotalProfits.Size = New System.Drawing.Size(78, 13)
        Me.LblTotalProfits.TabIndex = 26
        Me.LblTotalProfits.Text = "סה""כ רווחים :"
        '
        'LblTotalOut
        '
        Me.LblTotalOut.AutoSize = True
        Me.LblTotalOut.Location = New System.Drawing.Point(109, 148)
        Me.LblTotalOut.Name = "LblTotalOut"
        Me.LblTotalOut.Size = New System.Drawing.Size(81, 13)
        Me.LblTotalOut.TabIndex = 25
        Me.LblTotalOut.Text = "סה""כ מכירות :"
        '
        'LblTotalIn
        '
        Me.LblTotalIn.AutoSize = True
        Me.LblTotalIn.Location = New System.Drawing.Point(113, 122)
        Me.LblTotalIn.Name = "LblTotalIn"
        Me.LblTotalIn.Size = New System.Drawing.Size(77, 13)
        Me.LblTotalIn.TabIndex = 23
        Me.LblTotalIn.Text = "סה""כ עלויות :"
        '
        'LblCarsTotal
        '
        Me.LblCarsTotal.AutoSize = True
        Me.LblCarsTotal.Location = New System.Drawing.Point(115, 96)
        Me.LblCarsTotal.Name = "LblCarsTotal"
        Me.LblCarsTotal.Size = New System.Drawing.Size(75, 13)
        Me.LblCarsTotal.TabIndex = 24
        Me.LblCarsTotal.Text = "סה""כ רכבים :"
        '
        'GrpBtns
        '
        Me.GrpBtns.Controls.Add(Me.BtnClose)
        Me.GrpBtns.Controls.Add(Me.BtnPrint)
        Me.GrpBtns.Controls.Add(Me.BtnSave)
        Me.GrpBtns.Location = New System.Drawing.Point(657, 352)
        Me.GrpBtns.Name = "GrpBtns"
        Me.GrpBtns.Size = New System.Drawing.Size(124, 197)
        Me.GrpBtns.TabIndex = 23
        Me.GrpBtns.TabStop = False
        Me.GrpBtns.Text = "פעולות"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(5, 136)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnClose.Size = New System.Drawing.Size(113, 55)
        Me.BtnClose.TabIndex = 24
        Me.BtnClose.Text = "סגירה"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(5, 18)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPrint.Size = New System.Drawing.Size(113, 55)
        Me.BtnPrint.TabIndex = 23
        Me.BtnPrint.Text = "הדפסת דוח"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(5, 77)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(113, 55)
        Me.BtnSave.TabIndex = 22
        Me.BtnSave.Text = "שמירת דוח"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnAbort
        '
        Me.BtnAbort.BackColor = System.Drawing.Color.White
        Me.BtnAbort.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAbort.Image = CType(resources.GetObject("BtnAbort.Image"), System.Drawing.Image)
        Me.BtnAbort.Location = New System.Drawing.Point(534, 370)
        Me.BtnAbort.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAbort.Name = "BtnAbort"
        Me.BtnAbort.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAbort.Size = New System.Drawing.Size(113, 55)
        Me.BtnAbort.TabIndex = 25
        Me.BtnAbort.Text = "ביטול עסקה"
        Me.BtnAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAbort.UseVisualStyleBackColor = False
        '
        'FrmSoldReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(996, 555)
        Me.Controls.Add(Me.BtnAbort)
        Me.Controls.Add(Me.GrpBtns)
        Me.Controls.Add(Me.GrpCount)
        Me.Controls.Add(Me.GrpResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("David", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSoldReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "דוח מכירות"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVSoldReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpResults.ResumeLayout(False)
        Me.GrpResults.PerformLayout()
        Me.GrpCount.ResumeLayout(False)
        Me.GrpCount.PerformLayout()
        Me.GrpBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpResults As System.Windows.Forms.GroupBox
    Friend WithEvents LblNoResults As System.Windows.Forms.Label
    Friend WithEvents GrpCount As System.Windows.Forms.GroupBox
    Friend WithEvents BtnReload As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents DtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalProfits As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalOut As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalIn As System.Windows.Forms.TextBox
    Friend WithEvents TxtCarsTotal As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalProfits As System.Windows.Forms.Label
    Friend WithEvents LblTotalOut As System.Windows.Forms.Label
    Friend WithEvents LblTotalIn As System.Windows.Forms.Label
    Friend WithEvents LblCarsTotal As System.Windows.Forms.Label
    Friend WithEvents GrpBtns As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnAbort As System.Windows.Forms.Button
    Friend WithEvents DGVSoldReport As System.Windows.Forms.DataGridView
End Class
