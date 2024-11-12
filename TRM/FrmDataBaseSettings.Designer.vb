<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataBaseSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataBaseSettings))
        Me.LblVName = New System.Windows.Forms.Label()
        Me.TxtLocalServer = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpUser = New System.Windows.Forms.GroupBox()
        Me.GrpOnline = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtOnlineServer = New System.Windows.Forms.TextBox()
        Me.GrpLocal = New System.Windows.Forms.GroupBox()
        Me.RadServerDatabase = New System.Windows.Forms.RadioButton()
        Me.RadLocalDatabase = New System.Windows.Forms.RadioButton()
        Me.GrpUser.SuspendLayout()
        Me.GrpOnline.SuspendLayout()
        Me.GrpLocal.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblVName
        '
        Me.LblVName.AutoSize = True
        Me.LblVName.Location = New System.Drawing.Point(6, 22)
        Me.LblVName.Name = "LblVName"
        Me.LblVName.Size = New System.Drawing.Size(104, 16)
        Me.LblVName.TabIndex = 4
        Me.LblVName.Text = "LocalServer :"
        '
        'TxtLocalServer
        '
        Me.TxtLocalServer.Location = New System.Drawing.Point(96, 19)
        Me.TxtLocalServer.Name = "TxtLocalServer"
        Me.TxtLocalServer.Size = New System.Drawing.Size(805, 24)
        Me.TxtLocalServer.TabIndex = 12
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Image = Global.TRM.My.Resources.Resources.save
        Me.BtnAdd.Location = New System.Drawing.Point(720, 184)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 55)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "Save"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(828, 184)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(109, 55)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'GrpUser
        '
        Me.GrpUser.Controls.Add(Me.GrpOnline)
        Me.GrpUser.Controls.Add(Me.GrpLocal)
        Me.GrpUser.Controls.Add(Me.RadServerDatabase)
        Me.GrpUser.Controls.Add(Me.RadLocalDatabase)
        Me.GrpUser.Location = New System.Drawing.Point(7, 12)
        Me.GrpUser.Name = "GrpUser"
        Me.GrpUser.Size = New System.Drawing.Size(930, 166)
        Me.GrpUser.TabIndex = 43
        Me.GrpUser.TabStop = False
        Me.GrpUser.Text = "Database Settings"
        '
        'GrpOnline
        '
        Me.GrpOnline.Controls.Add(Me.Label1)
        Me.GrpOnline.Controls.Add(Me.TxtOnlineServer)
        Me.GrpOnline.Location = New System.Drawing.Point(9, 101)
        Me.GrpOnline.Name = "GrpOnline"
        Me.GrpOnline.Size = New System.Drawing.Size(909, 52)
        Me.GrpOnline.TabIndex = 19
        Me.GrpOnline.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OnlineServer :"
        '
        'TxtOnlineServer
        '
        Me.TxtOnlineServer.Location = New System.Drawing.Point(96, 19)
        Me.TxtOnlineServer.Name = "TxtOnlineServer"
        Me.TxtOnlineServer.Size = New System.Drawing.Size(805, 24)
        Me.TxtOnlineServer.TabIndex = 12
        '
        'GrpLocal
        '
        Me.GrpLocal.Controls.Add(Me.LblVName)
        Me.GrpLocal.Controls.Add(Me.TxtLocalServer)
        Me.GrpLocal.Location = New System.Drawing.Point(9, 43)
        Me.GrpLocal.Name = "GrpLocal"
        Me.GrpLocal.Size = New System.Drawing.Size(909, 52)
        Me.GrpLocal.TabIndex = 18
        Me.GrpLocal.TabStop = False
        '
        'RadServerDatabase
        '
        Me.RadServerDatabase.AutoSize = True
        Me.RadServerDatabase.Location = New System.Drawing.Point(9, 20)
        Me.RadServerDatabase.Name = "RadServerDatabase"
        Me.RadServerDatabase.Size = New System.Drawing.Size(126, 20)
        Me.RadServerDatabase.TabIndex = 17
        Me.RadServerDatabase.TabStop = True
        Me.RadServerDatabase.Text = "Online Server"
        Me.RadServerDatabase.UseVisualStyleBackColor = True
        '
        'RadLocalDatabase
        '
        Me.RadLocalDatabase.AutoSize = True
        Me.RadLocalDatabase.Location = New System.Drawing.Point(137, 20)
        Me.RadLocalDatabase.Name = "RadLocalDatabase"
        Me.RadLocalDatabase.Size = New System.Drawing.Size(114, 20)
        Me.RadLocalDatabase.TabIndex = 16
        Me.RadLocalDatabase.TabStop = True
        Me.RadLocalDatabase.Text = "LocalServer"
        Me.RadLocalDatabase.UseVisualStyleBackColor = True
        '
        'FrmDataBaseSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(949, 247)
        Me.Controls.Add(Me.GrpUser)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Font = New System.Drawing.Font("David", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDataBaseSettings"
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Settings"
        Me.GrpUser.ResumeLayout(False)
        Me.GrpUser.PerformLayout()
        Me.GrpOnline.ResumeLayout(False)
        Me.GrpOnline.PerformLayout()
        Me.GrpLocal.ResumeLayout(False)
        Me.GrpLocal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblVName As System.Windows.Forms.Label
    Friend WithEvents TxtLocalServer As System.Windows.Forms.TextBox
    Friend WithEvents GrpUser As System.Windows.Forms.GroupBox
    Friend WithEvents RadServerDatabase As RadioButton
    Friend WithEvents RadLocalDatabase As RadioButton
    Friend WithEvents GrpLocal As GroupBox
    Friend WithEvents GrpOnline As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtOnlineServer As TextBox
End Class
