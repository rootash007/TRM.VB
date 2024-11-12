<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddNewCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddNewCar))
        Me.LblCarSerial = New System.Windows.Forms.Label()
        Me.TxtCarSerial = New System.Windows.Forms.TextBox()
        Me.LblCarId = New System.Windows.Forms.Label()
        Me.LblCarKind = New System.Windows.Forms.Label()
        Me.TxtCarId = New System.Windows.Forms.TextBox()
        Me.LblSalerName = New System.Windows.Forms.Label()
        Me.TxtCarColor = New System.Windows.Forms.TextBox()
        Me.LblSalerId = New System.Windows.Forms.Label()
        Me.LblCarModel = New System.Windows.Forms.Label()
        Me.LblCarGear = New System.Windows.Forms.Label()
        Me.LblCarType = New System.Windows.Forms.Label()
        Me.LblEngine = New System.Windows.Forms.Label()
        Me.LblCarYear = New System.Windows.Forms.Label()
        Me.TxtEngine = New System.Windows.Forms.TextBox()
        Me.LblCarKM = New System.Windows.Forms.Label()
        Me.LblCarColor = New System.Windows.Forms.Label()
        Me.TxtCarCode = New System.Windows.Forms.TextBox()
        Me.LblPriceOut = New System.Windows.Forms.Label()
        Me.TxtCarKM = New System.Windows.Forms.TextBox()
        Me.LblCarHand = New System.Windows.Forms.Label()
        Me.TxtPriceOut = New System.Windows.Forms.TextBox()
        Me.LblShelda = New System.Windows.Forms.Label()
        Me.TxtShelda = New System.Windows.Forms.TextBox()
        Me.LblMainIs = New System.Windows.Forms.Label()
        Me.LblCarCode = New System.Windows.Forms.Label()
        Me.LblCarOil = New System.Windows.Forms.Label()
        Me.TxtSalerName = New System.Windows.Forms.TextBox()
        Me.LblKeyNum = New System.Windows.Forms.Label()
        Me.GrpCarDetails = New System.Windows.Forms.GroupBox()
        Me.LblCarKTM = New System.Windows.Forms.Label()
        Me.LblShowPrice = New System.Windows.Forms.Label()
        Me.DtpDateTest = New System.Windows.Forms.DateTimePicker()
        Me.DtpDatein = New System.Windows.Forms.DateTimePicker()
        Me.NumKeyNum = New System.Windows.Forms.NumericUpDown()
        Me.CmbCarOil = New System.Windows.Forms.ComboBox()
        Me.CmbCarGear = New System.Windows.Forms.ComboBox()
        Me.CmbMainIs = New System.Windows.Forms.ComboBox()
        Me.NumCarHand = New System.Windows.Forms.NumericUpDown()
        Me.NumCarYear = New System.Windows.Forms.NumericUpDown()
        Me.CmbCarType = New System.Windows.Forms.ComboBox()
        Me.CmbCarModel = New System.Windows.Forms.ComboBox()
        Me.CmbCarKind = New System.Windows.Forms.ComboBox()
        Me.TxtPriceIn = New System.Windows.Forms.TextBox()
        Me.LblDateTest = New System.Windows.Forms.Label()
        Me.LblDateIn = New System.Windows.Forms.Label()
        Me.LblPriceIn = New System.Windows.Forms.Label()
        Me.GrpAdditional = New System.Windows.Forms.GroupBox()
        Me.ChkRoof = New System.Windows.Forms.CheckBox()
        Me.ChkWheels = New System.Windows.Forms.CheckBox()
        Me.ChkSeats = New System.Windows.Forms.CheckBox()
        Me.ChkVav = New System.Windows.Forms.CheckBox()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.TxtSalerId = New System.Windows.Forms.TextBox()
        Me.GrpSaler = New System.Windows.Forms.GroupBox()
        Me.LblSalerPhone = New System.Windows.Forms.Label()
        Me.LblSalerAdress = New System.Windows.Forms.Label()
        Me.BtnSelectVendor = New System.Windows.Forms.Button()
        Me.TxtSalerPhone = New System.Windows.Forms.TextBox()
        Me.TxtSalerAdress = New System.Windows.Forms.TextBox()
        Me.GrpFiles = New System.Windows.Forms.GroupBox()
        Me.BtnBuyAgreement = New System.Windows.Forms.Button()
        Me.TxtCarInfo = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpCarDetails.SuspendLayout()
        CType(Me.NumKeyNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCarHand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCarYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpAdditional.SuspendLayout()
        Me.GrpSaler.SuspendLayout()
        Me.GrpFiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCarSerial
        '
        Me.LblCarSerial.AutoSize = True
        Me.LblCarSerial.Location = New System.Drawing.Point(406, 29)
        Me.LblCarSerial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarSerial.Name = "LblCarSerial"
        Me.LblCarSerial.Size = New System.Drawing.Size(66, 13)
        Me.LblCarSerial.TabIndex = 4
        Me.LblCarSerial.Text = "מספר ביומן"
        Me.LblCarSerial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtCarSerial
        '
        Me.TxtCarSerial.Location = New System.Drawing.Point(297, 26)
        Me.TxtCarSerial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCarSerial.MaxLength = 10
        Me.TxtCarSerial.Name = "TxtCarSerial"
        Me.TxtCarSerial.Size = New System.Drawing.Size(86, 21)
        Me.TxtCarSerial.TabIndex = 20
        Me.TxtCarSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCarId
        '
        Me.LblCarId.AutoSize = True
        Me.LblCarId.Location = New System.Drawing.Point(152, 62)
        Me.LblCarId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarId.Name = "LblCarId"
        Me.LblCarId.Size = New System.Drawing.Size(60, 13)
        Me.LblCarId.TabIndex = 10
        Me.LblCarId.Text = "מספר רכב"
        '
        'LblCarKind
        '
        Me.LblCarKind.AutoSize = True
        Me.LblCarKind.Location = New System.Drawing.Point(424, 95)
        Me.LblCarKind.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarKind.Name = "LblCarKind"
        Me.LblCarKind.Size = New System.Drawing.Size(48, 13)
        Me.LblCarKind.TabIndex = 12
        Me.LblCarKind.Text = "סוג רכב"
        Me.LblCarKind.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtCarId
        '
        Me.TxtCarId.Location = New System.Drawing.Point(10, 59)
        Me.TxtCarId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCarId.MaxLength = 8
        Me.TxtCarId.Name = "TxtCarId"
        Me.TxtCarId.Size = New System.Drawing.Size(119, 21)
        Me.TxtCarId.TabIndex = 1
        Me.TxtCarId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblSalerName
        '
        Me.LblSalerName.AutoSize = True
        Me.LblSalerName.Location = New System.Drawing.Point(185, 95)
        Me.LblSalerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSalerName.Name = "LblSalerName"
        Me.LblSalerName.Size = New System.Drawing.Size(62, 13)
        Me.LblSalerName.TabIndex = 16
        Me.LblSalerName.Text = "שם המוכר"
        '
        'TxtCarColor
        '
        Me.TxtCarColor.Location = New System.Drawing.Point(265, 191)
        Me.TxtCarColor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCarColor.Name = "TxtCarColor"
        Me.TxtCarColor.Size = New System.Drawing.Size(119, 21)
        Me.TxtCarColor.TabIndex = 7
        Me.TxtCarColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblSalerId
        '
        Me.LblSalerId.AutoSize = True
        Me.LblSalerId.Location = New System.Drawing.Point(159, 132)
        Me.LblSalerId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSalerId.Name = "LblSalerId"
        Me.LblSalerId.Size = New System.Drawing.Size(88, 13)
        Me.LblSalerId.TabIndex = 18
        Me.LblSalerId.Text = "ת.ז / ח.פ המוכר"
        '
        'LblCarModel
        '
        Me.LblCarModel.AutoSize = True
        Me.LblCarModel.Location = New System.Drawing.Point(418, 132)
        Me.LblCarModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarModel.Name = "LblCarModel"
        Me.LblCarModel.Size = New System.Drawing.Size(54, 13)
        Me.LblCarModel.TabIndex = 20
        Me.LblCarModel.Text = "שם ייצרן"
        '
        'LblCarGear
        '
        Me.LblCarGear.AutoSize = True
        Me.LblCarGear.Location = New System.Drawing.Point(152, 194)
        Me.LblCarGear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarGear.Name = "LblCarGear"
        Me.LblCarGear.Size = New System.Drawing.Size(60, 13)
        Me.LblCarGear.TabIndex = 22
        Me.LblCarGear.Text = "ת.הילוכים"
        '
        'LblCarType
        '
        Me.LblCarType.AutoSize = True
        Me.LblCarType.Location = New System.Drawing.Point(160, 128)
        Me.LblCarType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarType.Name = "LblCarType"
        Me.LblCarType.Size = New System.Drawing.Size(52, 13)
        Me.LblCarType.TabIndex = 24
        Me.LblCarType.Text = "דגם רכב"
        Me.LblCarType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblEngine
        '
        Me.LblEngine.AutoSize = True
        Me.LblEngine.Location = New System.Drawing.Point(162, 227)
        Me.LblEngine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEngine.Name = "LblEngine"
        Me.LblEngine.Size = New System.Drawing.Size(50, 13)
        Me.LblEngine.TabIndex = 26
        Me.LblEngine.Text = "נפח מנוע"
        '
        'LblCarYear
        '
        Me.LblCarYear.AutoSize = True
        Me.LblCarYear.Location = New System.Drawing.Point(415, 161)
        Me.LblCarYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarYear.Name = "LblCarYear"
        Me.LblCarYear.Size = New System.Drawing.Size(57, 13)
        Me.LblCarYear.TabIndex = 28
        Me.LblCarYear.Text = "שנת ייצור"
        Me.LblCarYear.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtEngine
        '
        Me.TxtEngine.Location = New System.Drawing.Point(10, 224)
        Me.TxtEngine.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtEngine.MaxLength = 10
        Me.TxtEngine.Name = "TxtEngine"
        Me.TxtEngine.Size = New System.Drawing.Size(119, 21)
        Me.TxtEngine.TabIndex = 10
        Me.TxtEngine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCarKM
        '
        Me.LblCarKM.AutoSize = True
        Me.LblCarKM.Location = New System.Drawing.Point(407, 260)
        Me.LblCarKM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarKM.Name = "LblCarKM"
        Me.LblCarKM.Size = New System.Drawing.Size(65, 13)
        Me.LblCarKM.TabIndex = 30
        Me.LblCarKM.Text = "קילומטרים"
        Me.LblCarKM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblCarColor
        '
        Me.LblCarColor.AutoSize = True
        Me.LblCarColor.Location = New System.Drawing.Point(445, 194)
        Me.LblCarColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarColor.Name = "LblCarColor"
        Me.LblCarColor.Size = New System.Drawing.Size(27, 13)
        Me.LblCarColor.TabIndex = 32
        Me.LblCarColor.Text = "צבע"
        Me.LblCarColor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtCarCode
        '
        Me.TxtCarCode.Location = New System.Drawing.Point(10, 257)
        Me.TxtCarCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCarCode.MaxLength = 10
        Me.TxtCarCode.Name = "TxtCarCode"
        Me.TxtCarCode.Size = New System.Drawing.Size(119, 21)
        Me.TxtCarCode.TabIndex = 12
        Me.TxtCarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPriceOut
        '
        Me.LblPriceOut.AutoSize = True
        Me.LblPriceOut.Location = New System.Drawing.Point(408, 326)
        Me.LblPriceOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPriceOut.Name = "LblPriceOut"
        Me.LblPriceOut.Size = New System.Drawing.Size(64, 13)
        Me.LblPriceOut.TabIndex = 34
        Me.LblPriceOut.Text = "מחיר דרוש"
        Me.LblPriceOut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtCarKM
        '
        Me.TxtCarKM.Location = New System.Drawing.Point(265, 257)
        Me.TxtCarKM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCarKM.MaxLength = 7
        Me.TxtCarKM.Name = "TxtCarKM"
        Me.TxtCarKM.Size = New System.Drawing.Size(119, 21)
        Me.TxtCarKM.TabIndex = 11
        Me.TxtCarKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCarHand
        '
        Me.LblCarHand.AutoSize = True
        Me.LblCarHand.Location = New System.Drawing.Point(194, 293)
        Me.LblCarHand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarHand.Name = "LblCarHand"
        Me.LblCarHand.Size = New System.Drawing.Size(18, 13)
        Me.LblCarHand.TabIndex = 36
        Me.LblCarHand.Text = "יד"
        '
        'TxtPriceOut
        '
        Me.TxtPriceOut.Location = New System.Drawing.Point(265, 323)
        Me.TxtPriceOut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtPriceOut.MaxLength = 7
        Me.TxtPriceOut.Name = "TxtPriceOut"
        Me.TxtPriceOut.Size = New System.Drawing.Size(119, 21)
        Me.TxtPriceOut.TabIndex = 15
        Me.TxtPriceOut.Text = "0"
        Me.TxtPriceOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblShelda
        '
        Me.LblShelda.AutoSize = True
        Me.LblShelda.Location = New System.Drawing.Point(431, 293)
        Me.LblShelda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShelda.Name = "LblShelda"
        Me.LblShelda.Size = New System.Drawing.Size(41, 13)
        Me.LblShelda.TabIndex = 38
        Me.LblShelda.Text = "שילדה"
        Me.LblShelda.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtShelda
        '
        Me.TxtShelda.Location = New System.Drawing.Point(265, 290)
        Me.TxtShelda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtShelda.MaxLength = 30
        Me.TxtShelda.Name = "TxtShelda"
        Me.TxtShelda.Size = New System.Drawing.Size(119, 21)
        Me.TxtShelda.TabIndex = 13
        Me.TxtShelda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMainIs
        '
        Me.LblMainIs.AutoSize = True
        Me.LblMainIs.Location = New System.Drawing.Point(148, 161)
        Me.LblMainIs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMainIs.Name = "LblMainIs"
        Me.LblMainIs.Size = New System.Drawing.Size(64, 13)
        Me.LblMainIs.TabIndex = 40
        Me.LblMainIs.Text = "רישום רכב"
        '
        'LblCarCode
        '
        Me.LblCarCode.AutoSize = True
        Me.LblCarCode.Location = New System.Drawing.Point(162, 260)
        Me.LblCarCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarCode.Name = "LblCarCode"
        Me.LblCarCode.Size = New System.Drawing.Size(50, 13)
        Me.LblCarCode.TabIndex = 42
        Me.LblCarCode.Text = "קוד רכב"
        '
        'LblCarOil
        '
        Me.LblCarOil.AutoSize = True
        Me.LblCarOil.Location = New System.Drawing.Point(424, 227)
        Me.LblCarOil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarOil.Name = "LblCarOil"
        Me.LblCarOil.Size = New System.Drawing.Size(48, 13)
        Me.LblCarOil.TabIndex = 44
        Me.LblCarOil.Text = "סוג דלק"
        Me.LblCarOil.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtSalerName
        '
        Me.TxtSalerName.Location = New System.Drawing.Point(7, 92)
        Me.TxtSalerName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSalerName.Name = "TxtSalerName"
        Me.TxtSalerName.Size = New System.Drawing.Size(143, 21)
        Me.TxtSalerName.TabIndex = 1
        Me.TxtSalerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblKeyNum
        '
        Me.LblKeyNum.AutoSize = True
        Me.LblKeyNum.Location = New System.Drawing.Point(163, 326)
        Me.LblKeyNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKeyNum.Name = "LblKeyNum"
        Me.LblKeyNum.Size = New System.Drawing.Size(49, 13)
        Me.LblKeyNum.TabIndex = 46
        Me.LblKeyNum.Text = "מפתחות"
        '
        'GrpCarDetails
        '
        Me.GrpCarDetails.Controls.Add(Me.LblCarKTM)
        Me.GrpCarDetails.Controls.Add(Me.LblShowPrice)
        Me.GrpCarDetails.Controls.Add(Me.DtpDateTest)
        Me.GrpCarDetails.Controls.Add(Me.DtpDatein)
        Me.GrpCarDetails.Controls.Add(Me.NumKeyNum)
        Me.GrpCarDetails.Controls.Add(Me.CmbCarOil)
        Me.GrpCarDetails.Controls.Add(Me.CmbCarGear)
        Me.GrpCarDetails.Controls.Add(Me.CmbMainIs)
        Me.GrpCarDetails.Controls.Add(Me.NumCarHand)
        Me.GrpCarDetails.Controls.Add(Me.NumCarYear)
        Me.GrpCarDetails.Controls.Add(Me.CmbCarType)
        Me.GrpCarDetails.Controls.Add(Me.CmbCarModel)
        Me.GrpCarDetails.Controls.Add(Me.CmbCarKind)
        Me.GrpCarDetails.Controls.Add(Me.TxtPriceIn)
        Me.GrpCarDetails.Controls.Add(Me.LblDateTest)
        Me.GrpCarDetails.Controls.Add(Me.LblDateIn)
        Me.GrpCarDetails.Controls.Add(Me.LblPriceIn)
        Me.GrpCarDetails.Controls.Add(Me.GrpAdditional)
        Me.GrpCarDetails.Controls.Add(Me.LblCarSerial)
        Me.GrpCarDetails.Controls.Add(Me.TxtCarSerial)
        Me.GrpCarDetails.Controls.Add(Me.LblCarOil)
        Me.GrpCarDetails.Controls.Add(Me.LblCarGear)
        Me.GrpCarDetails.Controls.Add(Me.LblCarModel)
        Me.GrpCarDetails.Controls.Add(Me.LblShelda)
        Me.GrpCarDetails.Controls.Add(Me.LblCarKind)
        Me.GrpCarDetails.Controls.Add(Me.LblKeyNum)
        Me.GrpCarDetails.Controls.Add(Me.LblCarHand)
        Me.GrpCarDetails.Controls.Add(Me.TxtEngine)
        Me.GrpCarDetails.Controls.Add(Me.LblCarColor)
        Me.GrpCarDetails.Controls.Add(Me.LblCarYear)
        Me.GrpCarDetails.Controls.Add(Me.TxtCarKM)
        Me.GrpCarDetails.Controls.Add(Me.LblPriceOut)
        Me.GrpCarDetails.Controls.Add(Me.LblCarType)
        Me.GrpCarDetails.Controls.Add(Me.LblCarId)
        Me.GrpCarDetails.Controls.Add(Me.TxtShelda)
        Me.GrpCarDetails.Controls.Add(Me.TxtCarId)
        Me.GrpCarDetails.Controls.Add(Me.LblCarKM)
        Me.GrpCarDetails.Controls.Add(Me.LblMainIs)
        Me.GrpCarDetails.Controls.Add(Me.TxtCarCode)
        Me.GrpCarDetails.Controls.Add(Me.LblCarCode)
        Me.GrpCarDetails.Controls.Add(Me.TxtCarColor)
        Me.GrpCarDetails.Controls.Add(Me.TxtPriceOut)
        Me.GrpCarDetails.Controls.Add(Me.LblEngine)
        Me.GrpCarDetails.Location = New System.Drawing.Point(12, 12)
        Me.GrpCarDetails.Name = "GrpCarDetails"
        Me.GrpCarDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpCarDetails.Size = New System.Drawing.Size(479, 472)
        Me.GrpCarDetails.TabIndex = 0
        Me.GrpCarDetails.TabStop = False
        Me.GrpCarDetails.Text = "נתוני הרכב"
        '
        'LblCarKTM
        '
        Me.LblCarKTM.AutoSize = True
        Me.LblCarKTM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCarKTM.Font = New System.Drawing.Font("David", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblCarKTM.ForeColor = System.Drawing.Color.Blue
        Me.LblCarKTM.Location = New System.Drawing.Point(10, 95)
        Me.LblCarKTM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarKTM.Name = "LblCarKTM"
        Me.LblCarKTM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCarKTM.Size = New System.Drawing.Size(146, 13)
        Me.LblCarKTM.TabIndex = 60
        Me.LblCarKTM.Text = "הוספת סוג/יצרן/דגם חדש"
        Me.LblCarKTM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblShowPrice
        '
        Me.LblShowPrice.AutoSize = True
        Me.LblShowPrice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblShowPrice.Font = New System.Drawing.Font("David", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LblShowPrice.ForeColor = System.Drawing.Color.Blue
        Me.LblShowPrice.Location = New System.Drawing.Point(140, 372)
        Me.LblShowPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShowPrice.Name = "LblShowPrice"
        Me.LblShowPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblShowPrice.Size = New System.Drawing.Size(58, 13)
        Me.LblShowPrice.TabIndex = 59
        Me.LblShowPrice.Text = "הצג מחיר"
        Me.LblShowPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DtpDateTest
        '
        Me.DtpDateTest.CustomFormat = "dd/MM/yyyy"
        Me.DtpDateTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDateTest.Location = New System.Drawing.Point(265, 356)
        Me.DtpDateTest.Name = "DtpDateTest"
        Me.DtpDateTest.Size = New System.Drawing.Size(119, 21)
        Me.DtpDateTest.TabIndex = 17
        '
        'DtpDatein
        '
        Me.DtpDatein.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDatein.Location = New System.Drawing.Point(265, 59)
        Me.DtpDatein.Name = "DtpDatein"
        Me.DtpDatein.Size = New System.Drawing.Size(119, 21)
        Me.DtpDatein.TabIndex = 0
        '
        'NumKeyNum
        '
        Me.NumKeyNum.Location = New System.Drawing.Point(10, 323)
        Me.NumKeyNum.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumKeyNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumKeyNum.Name = "NumKeyNum"
        Me.NumKeyNum.Size = New System.Drawing.Size(119, 21)
        Me.NumKeyNum.TabIndex = 16
        Me.NumKeyNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumKeyNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CmbCarOil
        '
        Me.CmbCarOil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCarOil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCarOil.FormattingEnabled = True
        Me.CmbCarOil.Items.AddRange(New Object() {"בנזין", "דיזל", "היברידי", "חשמל"})
        Me.CmbCarOil.Location = New System.Drawing.Point(265, 223)
        Me.CmbCarOil.Name = "CmbCarOil"
        Me.CmbCarOil.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCarOil.Size = New System.Drawing.Size(119, 21)
        Me.CmbCarOil.TabIndex = 9
        '
        'CmbCarGear
        '
        Me.CmbCarGear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCarGear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCarGear.FormattingEnabled = True
        Me.CmbCarGear.Items.AddRange(New Object() {"אוטומט", "ידני", "רובוטי"})
        Me.CmbCarGear.Location = New System.Drawing.Point(10, 191)
        Me.CmbCarGear.Name = "CmbCarGear"
        Me.CmbCarGear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCarGear.Size = New System.Drawing.Size(119, 21)
        Me.CmbCarGear.TabIndex = 8
        '
        'CmbMainIs
        '
        Me.CmbMainIs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbMainIs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMainIs.FormattingEnabled = True
        Me.CmbMainIs.Items.AddRange(New Object() {"פרטי", "ליסינג", "השכרה", "יבוא אישי", "ממשלתי", "חברה", "מונית"})
        Me.CmbMainIs.Location = New System.Drawing.Point(10, 158)
        Me.CmbMainIs.Name = "CmbMainIs"
        Me.CmbMainIs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbMainIs.Size = New System.Drawing.Size(119, 21)
        Me.CmbMainIs.TabIndex = 6
        '
        'NumCarHand
        '
        Me.NumCarHand.Location = New System.Drawing.Point(10, 290)
        Me.NumCarHand.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumCarHand.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumCarHand.Name = "NumCarHand"
        Me.NumCarHand.Size = New System.Drawing.Size(119, 21)
        Me.NumCarHand.TabIndex = 14
        Me.NumCarHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumCarHand.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumCarYear
        '
        Me.NumCarYear.Location = New System.Drawing.Point(264, 159)
        Me.NumCarYear.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NumCarYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.NumCarYear.Name = "NumCarYear"
        Me.NumCarYear.Size = New System.Drawing.Size(119, 21)
        Me.NumCarYear.TabIndex = 5
        Me.NumCarYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumCarYear.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'CmbCarType
        '
        Me.CmbCarType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCarType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCarType.FormattingEnabled = True
        Me.CmbCarType.Location = New System.Drawing.Point(10, 125)
        Me.CmbCarType.Name = "CmbCarType"
        Me.CmbCarType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCarType.Size = New System.Drawing.Size(119, 21)
        Me.CmbCarType.TabIndex = 4
        '
        'CmbCarModel
        '
        Me.CmbCarModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCarModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCarModel.FormattingEnabled = True
        Me.CmbCarModel.Location = New System.Drawing.Point(264, 125)
        Me.CmbCarModel.Name = "CmbCarModel"
        Me.CmbCarModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCarModel.Size = New System.Drawing.Size(119, 21)
        Me.CmbCarModel.TabIndex = 3
        '
        'CmbCarKind
        '
        Me.CmbCarKind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCarKind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCarKind.BackColor = System.Drawing.Color.White
        Me.CmbCarKind.FormattingEnabled = True
        Me.CmbCarKind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbCarKind.Location = New System.Drawing.Point(264, 92)
        Me.CmbCarKind.Name = "CmbCarKind"
        Me.CmbCarKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbCarKind.Size = New System.Drawing.Size(119, 21)
        Me.CmbCarKind.TabIndex = 2
        '
        'TxtPriceIn
        '
        Me.TxtPriceIn.Location = New System.Drawing.Point(10, 356)
        Me.TxtPriceIn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtPriceIn.MaxLength = 7
        Me.TxtPriceIn.Name = "TxtPriceIn"
        Me.TxtPriceIn.Size = New System.Drawing.Size(119, 21)
        Me.TxtPriceIn.TabIndex = 18
        Me.TxtPriceIn.Text = "0"
        Me.TxtPriceIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDateTest
        '
        Me.LblDateTest.AutoSize = True
        Me.LblDateTest.Location = New System.Drawing.Point(404, 359)
        Me.LblDateTest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDateTest.Name = "LblDateTest"
        Me.LblDateTest.Size = New System.Drawing.Size(68, 13)
        Me.LblDateTest.TabIndex = 49
        Me.LblDateTest.Text = "תאריך טסט"
        Me.LblDateTest.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDateIn
        '
        Me.LblDateIn.AutoSize = True
        Me.LblDateIn.Location = New System.Drawing.Point(394, 62)
        Me.LblDateIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDateIn.Name = "LblDateIn"
        Me.LblDateIn.Size = New System.Drawing.Size(78, 13)
        Me.LblDateIn.TabIndex = 48
        Me.LblDateIn.Text = "תאריך קליטה"
        Me.LblDateIn.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblPriceIn
        '
        Me.LblPriceIn.AutoSize = True
        Me.LblPriceIn.Location = New System.Drawing.Point(140, 359)
        Me.LblPriceIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPriceIn.Name = "LblPriceIn"
        Me.LblPriceIn.Size = New System.Drawing.Size(72, 13)
        Me.LblPriceIn.TabIndex = 55
        Me.LblPriceIn.Text = "מחיר רכישה"
        '
        'GrpAdditional
        '
        Me.GrpAdditional.Controls.Add(Me.ChkRoof)
        Me.GrpAdditional.Controls.Add(Me.ChkWheels)
        Me.GrpAdditional.Controls.Add(Me.ChkSeats)
        Me.GrpAdditional.Controls.Add(Me.ChkVav)
        Me.GrpAdditional.Location = New System.Drawing.Point(10, 384)
        Me.GrpAdditional.Name = "GrpAdditional"
        Me.GrpAdditional.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpAdditional.Size = New System.Drawing.Size(462, 74)
        Me.GrpAdditional.TabIndex = 19
        Me.GrpAdditional.TabStop = False
        Me.GrpAdditional.Text = "תוספות"
        '
        'ChkRoof
        '
        Me.ChkRoof.AutoSize = True
        Me.ChkRoof.Location = New System.Drawing.Point(137, 20)
        Me.ChkRoof.Name = "ChkRoof"
        Me.ChkRoof.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkRoof.Size = New System.Drawing.Size(65, 17)
        Me.ChkRoof.TabIndex = 2
        Me.ChkRoof.Text = "גג נפתח"
        Me.ChkRoof.UseVisualStyleBackColor = True
        '
        'ChkWheels
        '
        Me.ChkWheels.AutoSize = True
        Me.ChkWheels.Location = New System.Drawing.Point(347, 50)
        Me.ChkWheels.Name = "ChkWheels"
        Me.ChkWheels.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkWheels.Size = New System.Drawing.Size(108, 17)
        Me.ChkWheels.TabIndex = 1
        Me.ChkWheels.Text = "חישורי מגניזיום"
        Me.ChkWheels.UseVisualStyleBackColor = True
        '
        'ChkSeats
        '
        Me.ChkSeats.AutoSize = True
        Me.ChkSeats.Location = New System.Drawing.Point(124, 50)
        Me.ChkSeats.Name = "ChkSeats"
        Me.ChkSeats.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSeats.Size = New System.Drawing.Size(78, 17)
        Me.ChkSeats.TabIndex = 3
        Me.ChkSeats.Text = "ריפודי עור"
        Me.ChkSeats.UseVisualStyleBackColor = True
        '
        'ChkVav
        '
        Me.ChkVav.AutoSize = True
        Me.ChkVav.Location = New System.Drawing.Point(387, 20)
        Me.ChkVav.Name = "ChkVav"
        Me.ChkVav.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkVav.Size = New System.Drawing.Size(68, 17)
        Me.ChkVav.TabIndex = 0
        Me.ChkVav.Text = "וו גרירה"
        Me.ChkVav.UseVisualStyleBackColor = True
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Location = New System.Drawing.Point(206, 112)
        Me.LblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblInfo.Size = New System.Drawing.Size(48, 13)
        Me.LblInfo.TabIndex = 50
        Me.LblInfo.Text = "הערות :"
        '
        'TxtSalerId
        '
        Me.TxtSalerId.Location = New System.Drawing.Point(7, 125)
        Me.TxtSalerId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSalerId.MaxLength = 9
        Me.TxtSalerId.Name = "TxtSalerId"
        Me.TxtSalerId.Size = New System.Drawing.Size(143, 21)
        Me.TxtSalerId.TabIndex = 2
        Me.TxtSalerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrpSaler
        '
        Me.GrpSaler.Controls.Add(Me.LblSalerPhone)
        Me.GrpSaler.Controls.Add(Me.LblSalerAdress)
        Me.GrpSaler.Controls.Add(Me.BtnSelectVendor)
        Me.GrpSaler.Controls.Add(Me.TxtSalerPhone)
        Me.GrpSaler.Controls.Add(Me.TxtSalerAdress)
        Me.GrpSaler.Controls.Add(Me.TxtSalerName)
        Me.GrpSaler.Controls.Add(Me.LblSalerName)
        Me.GrpSaler.Controls.Add(Me.LblSalerId)
        Me.GrpSaler.Controls.Add(Me.TxtSalerId)
        Me.GrpSaler.Location = New System.Drawing.Point(499, 12)
        Me.GrpSaler.Name = "GrpSaler"
        Me.GrpSaler.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpSaler.Size = New System.Drawing.Size(259, 225)
        Me.GrpSaler.TabIndex = 1
        Me.GrpSaler.TabStop = False
        Me.GrpSaler.Text = "פרטי המוכר"
        '
        'LblSalerPhone
        '
        Me.LblSalerPhone.AutoSize = True
        Me.LblSalerPhone.Location = New System.Drawing.Point(175, 194)
        Me.LblSalerPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSalerPhone.Name = "LblSalerPhone"
        Me.LblSalerPhone.Size = New System.Drawing.Size(72, 13)
        Me.LblSalerPhone.TabIndex = 64
        Me.LblSalerPhone.Text = "טלפון המוכר"
        '
        'LblSalerAdress
        '
        Me.LblSalerAdress.AutoSize = True
        Me.LblSalerAdress.Location = New System.Drawing.Point(169, 161)
        Me.LblSalerAdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSalerAdress.Name = "LblSalerAdress"
        Me.LblSalerAdress.Size = New System.Drawing.Size(78, 13)
        Me.LblSalerAdress.TabIndex = 63
        Me.LblSalerAdress.Text = "כתובת המוכר"
        '
        'BtnSelectVendor
        '
        Me.BtnSelectVendor.BackColor = System.Drawing.Color.White
        Me.BtnSelectVendor.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSelectVendor.Image = CType(resources.GetObject("BtnSelectVendor.Image"), System.Drawing.Image)
        Me.BtnSelectVendor.Location = New System.Drawing.Point(7, 20)
        Me.BtnSelectVendor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnSelectVendor.Name = "BtnSelectVendor"
        Me.BtnSelectVendor.Size = New System.Drawing.Size(240, 55)
        Me.BtnSelectVendor.TabIndex = 0
        Me.BtnSelectVendor.Text = "בחירת ספק מהרשימה"
        Me.BtnSelectVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSelectVendor.UseVisualStyleBackColor = False
        '
        'TxtSalerPhone
        '
        Me.TxtSalerPhone.Location = New System.Drawing.Point(7, 191)
        Me.TxtSalerPhone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSalerPhone.MaxLength = 11
        Me.TxtSalerPhone.Name = "TxtSalerPhone"
        Me.TxtSalerPhone.Size = New System.Drawing.Size(143, 21)
        Me.TxtSalerPhone.TabIndex = 4
        Me.TxtSalerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSalerAdress
        '
        Me.TxtSalerAdress.Location = New System.Drawing.Point(7, 158)
        Me.TxtSalerAdress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtSalerAdress.Name = "TxtSalerAdress"
        Me.TxtSalerAdress.Size = New System.Drawing.Size(143, 21)
        Me.TxtSalerAdress.TabIndex = 3
        Me.TxtSalerAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrpFiles
        '
        Me.GrpFiles.Controls.Add(Me.BtnBuyAgreement)
        Me.GrpFiles.Controls.Add(Me.TxtCarInfo)
        Me.GrpFiles.Controls.Add(Me.LblInfo)
        Me.GrpFiles.Location = New System.Drawing.Point(497, 243)
        Me.GrpFiles.Name = "GrpFiles"
        Me.GrpFiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GrpFiles.Size = New System.Drawing.Size(261, 171)
        Me.GrpFiles.TabIndex = 2
        Me.GrpFiles.TabStop = False
        Me.GrpFiles.Text = "מסמכים"
        '
        'BtnBuyAgreement
        '
        Me.BtnBuyAgreement.BackColor = System.Drawing.Color.White
        Me.BtnBuyAgreement.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnBuyAgreement.Image = CType(resources.GetObject("BtnBuyAgreement.Image"), System.Drawing.Image)
        Me.BtnBuyAgreement.Location = New System.Drawing.Point(134, 20)
        Me.BtnBuyAgreement.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBuyAgreement.Name = "BtnBuyAgreement"
        Me.BtnBuyAgreement.Size = New System.Drawing.Size(120, 55)
        Me.BtnBuyAgreement.TabIndex = 65
        Me.BtnBuyAgreement.Text = "הסכם קנייה"
        Me.BtnBuyAgreement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuyAgreement.UseVisualStyleBackColor = False
        '
        'TxtCarInfo
        '
        Me.TxtCarInfo.Location = New System.Drawing.Point(7, 128)
        Me.TxtCarInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCarInfo.Multiline = True
        Me.TxtCarInfo.Name = "TxtCarInfo"
        Me.TxtCarInfo.Size = New System.Drawing.Size(247, 37)
        Me.TxtCarInfo.TabIndex = 0
        Me.TxtCarInfo.Text = "אין"
        Me.TxtCarInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(554, 429)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(98, 55)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "הוספה"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(660, 429)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(98, 55)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "ביטול"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FrmAddNewCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 496)
        Me.Controls.Add(Me.GrpFiles)
        Me.Controls.Add(Me.GrpSaler)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GrpCarDetails)
        Me.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddNewCar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת רכב חדש"
        Me.GrpCarDetails.ResumeLayout(False)
        Me.GrpCarDetails.PerformLayout()
        CType(Me.NumKeyNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCarHand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCarYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpAdditional.ResumeLayout(False)
        Me.GrpAdditional.PerformLayout()
        Me.GrpSaler.ResumeLayout(False)
        Me.GrpSaler.PerformLayout()
        Me.GrpFiles.ResumeLayout(False)
        Me.GrpFiles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblCarSerial As System.Windows.Forms.Label
    Friend WithEvents LblCarId As System.Windows.Forms.Label
    Friend WithEvents LblCarKind As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblSalerName As System.Windows.Forms.Label
    Friend WithEvents LblSalerId As System.Windows.Forms.Label
    Friend WithEvents LblCarModel As System.Windows.Forms.Label
    Friend WithEvents LblCarGear As System.Windows.Forms.Label
    Friend WithEvents LblCarType As System.Windows.Forms.Label
    Friend WithEvents LblEngine As System.Windows.Forms.Label
    Friend WithEvents LblCarYear As System.Windows.Forms.Label
    Friend WithEvents LblCarKM As System.Windows.Forms.Label
    Friend WithEvents LblCarColor As System.Windows.Forms.Label
    Friend WithEvents LblPriceOut As System.Windows.Forms.Label
    Friend WithEvents LblCarHand As System.Windows.Forms.Label
    Friend WithEvents LblShelda As System.Windows.Forms.Label
    Friend WithEvents LblMainIs As System.Windows.Forms.Label
    Friend WithEvents LblCarCode As System.Windows.Forms.Label
    Friend WithEvents LblCarOil As System.Windows.Forms.Label
    Friend WithEvents LblKeyNum As System.Windows.Forms.Label
    Friend WithEvents LblDateIn As System.Windows.Forms.Label
    Friend WithEvents LblDateTest As System.Windows.Forms.Label
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents LblPriceIn As System.Windows.Forms.Label
    Friend WithEvents BtnSelectVendor As System.Windows.Forms.Button
    Friend WithEvents LblSalerPhone As System.Windows.Forms.Label
    Friend WithEvents LblSalerAdress As System.Windows.Forms.Label
    Friend WithEvents GrpFiles As System.Windows.Forms.GroupBox
    Friend WithEvents LblShowPrice As System.Windows.Forms.Label
    Friend WithEvents BtnBuyAgreement As System.Windows.Forms.Button
    Public WithEvents TxtCarId As System.Windows.Forms.TextBox
    Public WithEvents TxtCarSerial As System.Windows.Forms.TextBox
    Public WithEvents TxtCarColor As System.Windows.Forms.TextBox
    Public WithEvents TxtEngine As System.Windows.Forms.TextBox
    Public WithEvents TxtCarCode As System.Windows.Forms.TextBox
    Public WithEvents TxtCarKM As System.Windows.Forms.TextBox
    Public WithEvents TxtPriceOut As System.Windows.Forms.TextBox
    Public WithEvents TxtShelda As System.Windows.Forms.TextBox
    Public WithEvents TxtSalerName As System.Windows.Forms.TextBox
    Public WithEvents GrpCarDetails As System.Windows.Forms.GroupBox
    Public WithEvents GrpAdditional As System.Windows.Forms.GroupBox
    Public WithEvents ChkRoof As System.Windows.Forms.CheckBox
    Public WithEvents ChkWheels As System.Windows.Forms.CheckBox
    Public WithEvents ChkSeats As System.Windows.Forms.CheckBox
    Public WithEvents ChkVav As System.Windows.Forms.CheckBox
    Public WithEvents TxtPriceIn As System.Windows.Forms.TextBox
    Public WithEvents TxtSalerId As System.Windows.Forms.TextBox
    Public WithEvents GrpSaler As System.Windows.Forms.GroupBox
    Public WithEvents TxtSalerPhone As System.Windows.Forms.TextBox
    Public WithEvents TxtSalerAdress As System.Windows.Forms.TextBox
    Public WithEvents DtpDateTest As System.Windows.Forms.DateTimePicker
    Public WithEvents DtpDatein As System.Windows.Forms.DateTimePicker
    Public WithEvents NumKeyNum As System.Windows.Forms.NumericUpDown
    Public WithEvents CmbCarOil As System.Windows.Forms.ComboBox
    Public WithEvents CmbCarGear As System.Windows.Forms.ComboBox
    Public WithEvents CmbMainIs As System.Windows.Forms.ComboBox
    Public WithEvents NumCarHand As System.Windows.Forms.NumericUpDown
    Public WithEvents NumCarYear As System.Windows.Forms.NumericUpDown
    Public WithEvents CmbCarType As System.Windows.Forms.ComboBox
    Public WithEvents CmbCarModel As System.Windows.Forms.ComboBox
    Public WithEvents CmbCarKind As System.Windows.Forms.ComboBox
    Public WithEvents TxtCarInfo As System.Windows.Forms.TextBox
    Friend WithEvents LblCarKTM As System.Windows.Forms.Label
End Class
