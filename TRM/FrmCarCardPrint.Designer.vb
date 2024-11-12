<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarCardPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarCardPrint))
        Me.RPTCarCardPrint = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RPTCarCardPrint
        '
        Me.RPTCarCardPrint.AutoSize = True
        Me.RPTCarCardPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RPTCarCardPrint.LocalReport.ReportEmbeddedResource = "TRM.RptCarCard.rdlc"
        Me.RPTCarCardPrint.Location = New System.Drawing.Point(0, 0)
        Me.RPTCarCardPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.RPTCarCardPrint.Name = "RPTCarCardPrint"
        Me.RPTCarCardPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RPTCarCardPrint.Size = New System.Drawing.Size(536, 248)
        Me.RPTCarCardPrint.TabIndex = 0
        '
        'FrmCarCardPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 248)
        Me.Controls.Add(Me.RPTCarCardPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCarCardPrint"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FrmCarCarPrint"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RPTCarCardPrint As Microsoft.Reporting.WinForms.ReportViewer
End Class
