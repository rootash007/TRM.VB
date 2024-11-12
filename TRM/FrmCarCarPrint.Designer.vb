<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarCarPrint
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
        Me.RPTCarCardPrint = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RPTCarCardPrint
        '
        Me.RPTCarCardPrint.AutoSize = True
        Me.RPTCarCardPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RPTCarCardPrint.LocalReport.ReportEmbeddedResource = "TRM.RptCarCard.rdlc"
        Me.RPTCarCardPrint.Location = New System.Drawing.Point(0, 0)
        Me.RPTCarCardPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RPTCarCardPrint.Name = "RPTCarCardPrint"
        Me.RPTCarCardPrint.Size = New System.Drawing.Size(913, 348)
        Me.RPTCarCardPrint.TabIndex = 0
        '
        'FrmCarCarPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 348)
        Me.Controls.Add(Me.RPTCarCardPrint)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmCarCarPrint"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FrmCarCarPrint"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RPTCarCardPrint As Microsoft.Reporting.WinForms.ReportViewer
End Class
