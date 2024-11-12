<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequiredAddCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRequiredAddCar))
        Me.ChkCarKind = New System.Windows.Forms.CheckBox()
        Me.ChkCarModel = New System.Windows.Forms.CheckBox()
        Me.ChkCarType = New System.Windows.Forms.CheckBox()
        Me.ChkCarColor = New System.Windows.Forms.CheckBox()
        Me.ChkCarOil = New System.Windows.Forms.CheckBox()
        Me.ChkCarKM = New System.Windows.Forms.CheckBox()
        Me.ChkShelda = New System.Windows.Forms.CheckBox()
        Me.ChkPriceOut = New System.Windows.Forms.CheckBox()
        Me.ChkCarGear = New System.Windows.Forms.CheckBox()
        Me.ChkEngine = New System.Windows.Forms.CheckBox()
        Me.ChkSalerId = New System.Windows.Forms.CheckBox()
        Me.ChkSalerAdress = New System.Windows.Forms.CheckBox()
        Me.ChkSalerName = New System.Windows.Forms.CheckBox()
        Me.ChkPriceIn = New System.Windows.Forms.CheckBox()
        Me.ChkCarCode = New System.Windows.Forms.CheckBox()
        Me.ChkMainIs = New System.Windows.Forms.CheckBox()
        Me.ChkSalerPhone = New System.Windows.Forms.CheckBox()
        Me.GrpRequired = New System.Windows.Forms.GroupBox()
        Me.LblRequired = New System.Windows.Forms.Label()
        Me.GrpRequired2 = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpRequired.SuspendLayout()
        Me.GrpRequired2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkCarKind
        '
        Me.ChkCarKind.AutoSize = True
        Me.ChkCarKind.Location = New System.Drawing.Point(40, 20)
        Me.ChkCarKind.Name = "ChkCarKind"
        Me.ChkCarKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarKind.Size = New System.Drawing.Size(67, 17)
        Me.ChkCarKind.TabIndex = 0
        Me.ChkCarKind.Text = "סוג רכב"
        Me.ChkCarKind.UseVisualStyleBackColor = True
        '
        'ChkCarModel
        '
        Me.ChkCarModel.AutoSize = True
        Me.ChkCarModel.Location = New System.Drawing.Point(34, 43)
        Me.ChkCarModel.Name = "ChkCarModel"
        Me.ChkCarModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarModel.Size = New System.Drawing.Size(73, 17)
        Me.ChkCarModel.TabIndex = 1
        Me.ChkCarModel.Text = "שם ייצרן"
        Me.ChkCarModel.UseVisualStyleBackColor = True
        '
        'ChkCarType
        '
        Me.ChkCarType.AutoSize = True
        Me.ChkCarType.Location = New System.Drawing.Point(44, 43)
        Me.ChkCarType.Name = "ChkCarType"
        Me.ChkCarType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarType.Size = New System.Drawing.Size(71, 17)
        Me.ChkCarType.TabIndex = 1
        Me.ChkCarType.Text = "דגם רכב"
        Me.ChkCarType.UseVisualStyleBackColor = True
        '
        'ChkCarColor
        '
        Me.ChkCarColor.AutoSize = True
        Me.ChkCarColor.Location = New System.Drawing.Point(61, 66)
        Me.ChkCarColor.Name = "ChkCarColor"
        Me.ChkCarColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarColor.Size = New System.Drawing.Size(46, 17)
        Me.ChkCarColor.TabIndex = 2
        Me.ChkCarColor.Text = "צבע"
        Me.ChkCarColor.UseVisualStyleBackColor = True
        '
        'ChkCarOil
        '
        Me.ChkCarOil.AutoSize = True
        Me.ChkCarOil.Location = New System.Drawing.Point(40, 89)
        Me.ChkCarOil.Name = "ChkCarOil"
        Me.ChkCarOil.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarOil.Size = New System.Drawing.Size(67, 17)
        Me.ChkCarOil.TabIndex = 3
        Me.ChkCarOil.Text = "סוג דלק"
        Me.ChkCarOil.UseVisualStyleBackColor = True
        '
        'ChkCarKM
        '
        Me.ChkCarKM.AutoSize = True
        Me.ChkCarKM.Location = New System.Drawing.Point(23, 112)
        Me.ChkCarKM.Name = "ChkCarKM"
        Me.ChkCarKM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarKM.Size = New System.Drawing.Size(84, 17)
        Me.ChkCarKM.TabIndex = 4
        Me.ChkCarKM.Text = "קילומטרים"
        Me.ChkCarKM.UseVisualStyleBackColor = True
        '
        'ChkShelda
        '
        Me.ChkShelda.AutoSize = True
        Me.ChkShelda.Location = New System.Drawing.Point(47, 135)
        Me.ChkShelda.Name = "ChkShelda"
        Me.ChkShelda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkShelda.Size = New System.Drawing.Size(60, 17)
        Me.ChkShelda.TabIndex = 5
        Me.ChkShelda.Text = "שילדה"
        Me.ChkShelda.UseVisualStyleBackColor = True
        '
        'ChkPriceOut
        '
        Me.ChkPriceOut.AutoSize = True
        Me.ChkPriceOut.Location = New System.Drawing.Point(24, 158)
        Me.ChkPriceOut.Name = "ChkPriceOut"
        Me.ChkPriceOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPriceOut.Size = New System.Drawing.Size(83, 17)
        Me.ChkPriceOut.TabIndex = 6
        Me.ChkPriceOut.Text = "מחיר דרוש"
        Me.ChkPriceOut.UseVisualStyleBackColor = True
        '
        'ChkCarGear
        '
        Me.ChkCarGear.AutoSize = True
        Me.ChkCarGear.Location = New System.Drawing.Point(9, 204)
        Me.ChkCarGear.Name = "ChkCarGear"
        Me.ChkCarGear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarGear.Size = New System.Drawing.Size(98, 17)
        Me.ChkCarGear.TabIndex = 8
        Me.ChkCarGear.Text = "תיבת הילוכים"
        Me.ChkCarGear.UseVisualStyleBackColor = True
        '
        'ChkEngine
        '
        Me.ChkEngine.AutoSize = True
        Me.ChkEngine.Location = New System.Drawing.Point(46, 20)
        Me.ChkEngine.Name = "ChkEngine"
        Me.ChkEngine.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkEngine.Size = New System.Drawing.Size(69, 17)
        Me.ChkEngine.TabIndex = 0
        Me.ChkEngine.Text = "נפח מנוע"
        Me.ChkEngine.UseVisualStyleBackColor = True
        '
        'ChkSalerId
        '
        Me.ChkSalerId.AutoSize = True
        Me.ChkSalerId.Location = New System.Drawing.Point(8, 181)
        Me.ChkSalerId.Name = "ChkSalerId"
        Me.ChkSalerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSalerId.Size = New System.Drawing.Size(107, 17)
        Me.ChkSalerId.TabIndex = 7
        Me.ChkSalerId.Text = "ת.ז / ח.פ המוכר"
        Me.ChkSalerId.UseVisualStyleBackColor = True
        '
        'ChkSalerAdress
        '
        Me.ChkSalerAdress.AutoSize = True
        Me.ChkSalerAdress.Location = New System.Drawing.Point(18, 135)
        Me.ChkSalerAdress.Name = "ChkSalerAdress"
        Me.ChkSalerAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSalerAdress.Size = New System.Drawing.Size(97, 17)
        Me.ChkSalerAdress.TabIndex = 5
        Me.ChkSalerAdress.Text = "כתובת המוכר"
        Me.ChkSalerAdress.UseVisualStyleBackColor = True
        '
        'ChkSalerName
        '
        Me.ChkSalerName.AutoSize = True
        Me.ChkSalerName.Location = New System.Drawing.Point(34, 112)
        Me.ChkSalerName.Name = "ChkSalerName"
        Me.ChkSalerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSalerName.Size = New System.Drawing.Size(81, 17)
        Me.ChkSalerName.TabIndex = 4
        Me.ChkSalerName.Text = "שם המוכר"
        Me.ChkSalerName.UseVisualStyleBackColor = True
        '
        'ChkPriceIn
        '
        Me.ChkPriceIn.AutoSize = True
        Me.ChkPriceIn.Location = New System.Drawing.Point(24, 89)
        Me.ChkPriceIn.Name = "ChkPriceIn"
        Me.ChkPriceIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPriceIn.Size = New System.Drawing.Size(91, 17)
        Me.ChkPriceIn.TabIndex = 3
        Me.ChkPriceIn.Text = "מחיר רכישה"
        Me.ChkPriceIn.UseVisualStyleBackColor = True
        '
        'ChkCarCode
        '
        Me.ChkCarCode.AutoSize = True
        Me.ChkCarCode.Location = New System.Drawing.Point(46, 66)
        Me.ChkCarCode.Name = "ChkCarCode"
        Me.ChkCarCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCarCode.Size = New System.Drawing.Size(69, 17)
        Me.ChkCarCode.TabIndex = 2
        Me.ChkCarCode.Text = "קוד רכב"
        Me.ChkCarCode.UseVisualStyleBackColor = True
        '
        'ChkMainIs
        '
        Me.ChkMainIs.AutoSize = True
        Me.ChkMainIs.Location = New System.Drawing.Point(24, 181)
        Me.ChkMainIs.Name = "ChkMainIs"
        Me.ChkMainIs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkMainIs.Size = New System.Drawing.Size(83, 17)
        Me.ChkMainIs.TabIndex = 7
        Me.ChkMainIs.Text = "רישום רכב"
        Me.ChkMainIs.UseVisualStyleBackColor = True
        '
        'ChkSalerPhone
        '
        Me.ChkSalerPhone.AutoSize = True
        Me.ChkSalerPhone.Location = New System.Drawing.Point(24, 158)
        Me.ChkSalerPhone.Name = "ChkSalerPhone"
        Me.ChkSalerPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSalerPhone.Size = New System.Drawing.Size(91, 17)
        Me.ChkSalerPhone.TabIndex = 6
        Me.ChkSalerPhone.Text = "טלפון המוכר"
        Me.ChkSalerPhone.UseVisualStyleBackColor = True
        '
        'GrpRequired
        '
        Me.GrpRequired.Controls.Add(Me.ChkMainIs)
        Me.GrpRequired.Controls.Add(Me.ChkCarGear)
        Me.GrpRequired.Controls.Add(Me.ChkPriceOut)
        Me.GrpRequired.Controls.Add(Me.ChkShelda)
        Me.GrpRequired.Controls.Add(Me.ChkCarKM)
        Me.GrpRequired.Controls.Add(Me.ChkCarKind)
        Me.GrpRequired.Controls.Add(Me.ChkCarOil)
        Me.GrpRequired.Controls.Add(Me.ChkCarModel)
        Me.GrpRequired.Controls.Add(Me.ChkCarColor)
        Me.GrpRequired.Location = New System.Drawing.Point(15, 31)
        Me.GrpRequired.Name = "GrpRequired"
        Me.GrpRequired.Size = New System.Drawing.Size(120, 230)
        Me.GrpRequired.TabIndex = 0
        Me.GrpRequired.TabStop = False
        '
        'LblRequired
        '
        Me.LblRequired.AutoSize = True
        Me.LblRequired.Location = New System.Drawing.Point(12, 15)
        Me.LblRequired.Name = "LblRequired"
        Me.LblRequired.Size = New System.Drawing.Size(181, 13)
        Me.LblRequired.TabIndex = 18
        Me.LblRequired.Text = "* בחירת שדות חובה בנתוני רכבים"
        '
        'GrpRequired2
        '
        Me.GrpRequired2.Controls.Add(Me.ChkCarCode)
        Me.GrpRequired2.Controls.Add(Me.ChkEngine)
        Me.GrpRequired2.Controls.Add(Me.ChkCarType)
        Me.GrpRequired2.Controls.Add(Me.ChkSalerPhone)
        Me.GrpRequired2.Controls.Add(Me.ChkPriceIn)
        Me.GrpRequired2.Controls.Add(Me.ChkSalerName)
        Me.GrpRequired2.Controls.Add(Me.ChkSalerId)
        Me.GrpRequired2.Controls.Add(Me.ChkSalerAdress)
        Me.GrpRequired2.Location = New System.Drawing.Point(143, 31)
        Me.GrpRequired2.Name = "GrpRequired2"
        Me.GrpRequired2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpRequired2.Size = New System.Drawing.Size(120, 230)
        Me.GrpRequired2.TabIndex = 1
        Me.GrpRequired2.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(163, 267)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 55)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(57, 267)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 55)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "שמירה"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'FrmRequiredAddCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(277, 332)
        Me.Controls.Add(Me.GrpRequired2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblRequired)
        Me.Controls.Add(Me.GrpRequired)
        Me.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRequiredAddCar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הגדרת שדות חובה לרכב"
        Me.GrpRequired.ResumeLayout(False)
        Me.GrpRequired.PerformLayout()
        Me.GrpRequired2.ResumeLayout(False)
        Me.GrpRequired2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkCarKind As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCarModel As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCarType As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCarColor As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCarOil As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCarKM As System.Windows.Forms.CheckBox
    Friend WithEvents ChkShelda As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPriceOut As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCarGear As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEngine As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSalerId As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSalerAdress As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSalerName As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPriceIn As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCarCode As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMainIs As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSalerPhone As System.Windows.Forms.CheckBox
    Friend WithEvents GrpRequired As System.Windows.Forms.GroupBox
    Friend WithEvents LblRequired As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpRequired2 As System.Windows.Forms.GroupBox
End Class
