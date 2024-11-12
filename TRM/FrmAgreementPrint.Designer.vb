<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgreementPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgreementPrint))
        Me.RptAgreementPrint = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SFDAgreement = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'RptAgreementPrint
        '
        Me.RptAgreementPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptAgreementPrint.LocalReport.ReportEmbeddedResource = "TRM.RptAgreement.rdlc"
        Me.RptAgreementPrint.Location = New System.Drawing.Point(0, 0)
        Me.RptAgreementPrint.Name = "RptAgreementPrint"
        Me.RptAgreementPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RptAgreementPrint.Size = New System.Drawing.Size(824, 377)
        Me.RptAgreementPrint.TabIndex = 0
        '
        'FrmAgreementPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(824, 377)
        Me.Controls.Add(Me.RptAgreementPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgreementPrint"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "הדפסת הסכם"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptAgreementPrint As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SFDAgreement As System.Windows.Forms.SaveFileDialog
End Class
