﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompany))
        Me.LblTax = New System.Windows.Forms.Label()
        Me.NumTax = New System.Windows.Forms.NumericUpDown()
        Me.TxtAdminCode = New System.Windows.Forms.TextBox()
        Me.LblAdminCode = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CompanyTab = New System.Windows.Forms.TabControl()
        Me.TabValues = New System.Windows.Forms.TabPage()
        Me.TabLocker = New System.Windows.Forms.TabPage()
        Me.ChkMaterialQuantity = New System.Windows.Forms.CheckBox()
        CType(Me.NumTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompanyTab.SuspendLayout()
        Me.TabValues.SuspendLayout()
        Me.TabLocker.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTax
        '
        Me.LblTax.AutoSize = True
        Me.LblTax.Location = New System.Drawing.Point(400, 12)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(61, 16)
        Me.LblTax.TabIndex = 0
        Me.LblTax.Text = "نسبة الضريبة"
        '
        'NumTax
        '
        Me.NumTax.Location = New System.Drawing.Point(266, 10)
        Me.NumTax.Name = "NumTax"
        Me.NumTax.Size = New System.Drawing.Size(99, 23)
        Me.NumTax.TabIndex = 1
        Me.NumTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAdminCode
        '
        Me.TxtAdminCode.Location = New System.Drawing.Point(266, 36)
        Me.TxtAdminCode.Name = "TxtAdminCode"
        Me.TxtAdminCode.Size = New System.Drawing.Size(99, 23)
        Me.TxtAdminCode.TabIndex = 2
        '
        'LblAdminCode
        '
        Me.LblAdminCode.AutoSize = True
        Me.LblAdminCode.Location = New System.Drawing.Point(374, 39)
        Me.LblAdminCode.Name = "LblAdminCode"
        Me.LblAdminCode.Size = New System.Drawing.Size(87, 16)
        Me.LblAdminCode.TabIndex = 3
        Me.LblAdminCode.Text = "كلمة مرور المسؤول"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(374, 317)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(105, 56)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(9, 317)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 56)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "الغاء"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'CompanyTab
        '
        Me.CompanyTab.Controls.Add(Me.TabValues)
        Me.CompanyTab.Controls.Add(Me.TabLocker)
        Me.CompanyTab.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyTab.Location = New System.Drawing.Point(9, 10)
        Me.CompanyTab.Margin = New System.Windows.Forms.Padding(2)
        Me.CompanyTab.Name = "CompanyTab"
        Me.CompanyTab.RightToLeftLayout = True
        Me.CompanyTab.SelectedIndex = 0
        Me.CompanyTab.Size = New System.Drawing.Size(474, 301)
        Me.CompanyTab.TabIndex = 14
        '
        'TabValues
        '
        Me.TabValues.Controls.Add(Me.LblTax)
        Me.TabValues.Controls.Add(Me.NumTax)
        Me.TabValues.Controls.Add(Me.LblAdminCode)
        Me.TabValues.Controls.Add(Me.TxtAdminCode)
        Me.TabValues.Location = New System.Drawing.Point(4, 26)
        Me.TabValues.Margin = New System.Windows.Forms.Padding(2)
        Me.TabValues.Name = "TabValues"
        Me.TabValues.Padding = New System.Windows.Forms.Padding(2)
        Me.TabValues.Size = New System.Drawing.Size(466, 271)
        Me.TabValues.TabIndex = 0
        Me.TabValues.Text = "الاساسيات"
        Me.TabValues.UseVisualStyleBackColor = True
        '
        'TabLocker
        '
        Me.TabLocker.Controls.Add(Me.ChkMaterialQuantity)
        Me.TabLocker.Location = New System.Drawing.Point(4, 26)
        Me.TabLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.TabLocker.Name = "TabLocker"
        Me.TabLocker.Padding = New System.Windows.Forms.Padding(2)
        Me.TabLocker.Size = New System.Drawing.Size(466, 271)
        Me.TabLocker.TabIndex = 1
        Me.TabLocker.Text = "القفل"
        Me.TabLocker.UseVisualStyleBackColor = True
        '
        'ChkMaterialQuantity
        '
        Me.ChkMaterialQuantity.AutoSize = True
        Me.ChkMaterialQuantity.Location = New System.Drawing.Point(365, 7)
        Me.ChkMaterialQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkMaterialQuantity.Name = "ChkMaterialQuantity"
        Me.ChkMaterialQuantity.Size = New System.Drawing.Size(94, 20)
        Me.ChkMaterialQuantity.TabIndex = 0
        Me.ChkMaterialQuantity.Text = "تعديل كمية المواد"
        Me.ChkMaterialQuantity.UseVisualStyleBackColor = True
        '
        'FrmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 384)
        Me.Controls.Add(Me.CompanyTab)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCompany"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "خيارات الشركة"
        CType(Me.NumTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompanyTab.ResumeLayout(False)
        Me.TabValues.ResumeLayout(False)
        Me.TabValues.PerformLayout()
        Me.TabLocker.ResumeLayout(False)
        Me.TabLocker.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTax As Label
    Friend WithEvents NumTax As NumericUpDown
    Friend WithEvents TxtAdminCode As TextBox
    Friend WithEvents LblAdminCode As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents CompanyTab As TabControl
    Friend WithEvents TabValues As TabPage
    Friend WithEvents TabLocker As TabPage
    Friend WithEvents ChkMaterialQuantity As CheckBox
End Class
