Public Class FrmAddCarKind
    Private Sub FrmAddCarKind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrpAddNew.Enabled = False
        LblCarKindSelect.Text = "בחירת סוג רכב"
        TxtNewModel.Enabled = False
        TxtNewType.Enabled = False

    End Sub

    Private Sub ChkAddKind_Click(sender As Object, e As EventArgs) Handles ChkAddKind.Click
        ChkAddKind.Checked = True
        ChkAddModel.Checked = False
        ChkAddType.Checked = False
        GrpAddNew.Enabled = True
        LblNewCarKind.Text = "רשימת סוגי רכב"
        TxtNewModel.Enabled = False
        TxtNewType.Enabled = False
        ' GrpCarList.Enabled = True
        ' GrpMoney.Visible = True
    End Sub

    Private Sub ChkAddModel_Click(sender As Object, e As EventArgs) Handles ChkAddModel.Click
        ChkAddKind.Checked = False
        ChkAddModel.Checked = True
        ChkAddType.Checked = False
        GrpAddNew.Enabled = True
        LblCarKindSelect.Text = "בחירת סוג רכב"
        TxtNewModel.Enabled = True
        TxtNewType.Enabled = True

        ' GrpCarList.Enabled = True
        ' GrpMoney.Visible = True
    End Sub

    Private Sub ChkAddType_Click(sender As Object, e As EventArgs) Handles ChkAddType.Click
        ChkAddKind.Checked = False
        ChkAddModel.Checked = False
        ChkAddType.Checked = True
        GrpAddNew.Enabled = True
        LblCarKindSelect.Text = "בחירת סוג רכב"
        TxtNewModel.Enabled = False
        TxtNewType.Enabled = True

        ' GrpCarList.Enabled = True
        ' GrpMoney.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub


End Class