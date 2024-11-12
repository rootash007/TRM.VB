Public Class FrmCarKMT

    Private Sub FrmCarKMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrpAdd.Enabled = False
        CmbKind.Enabled = False
        CmbModel.Enabled = False
        CmbType.Enabled = False
        TxtNewKind.Enabled = False
        TxtNewModel.Enabled = False
        TxtNewType.Enabled = False
        ChkKind.Checked = False
        ChkModel.Checked = False
        ChkType.Checked = False
        CmbKind.Text = ""
        CmbModel.Text = ""
        CmbType.Text = ""
        TxtNewKind.Text = ""
        TxtNewModel.Text = ""
        TxtNewType.Text = ""
        TxtNewKind.BackColor = Color.White
        TxtNewModel.BackColor = Color.White
        TxtNewType.BackColor = Color.White
    End Sub

    Private Sub ChkKind_Click(sender As Object, e As EventArgs) Handles ChkKind.Click
        ChkKind.Checked = True
        ChkModel.Checked = False
        ChkType.Checked = False
        GrpAdd.Enabled = True
        CmbKind.Enabled = True
        CmbModel.Enabled = False
        CmbType.Enabled = False
        TxtNewKind.Enabled = True
        TxtNewModel.Enabled = False
        TxtNewType.Enabled = False
        CmbKind.Text = ""
        CmbModel.Text = ""
        CmbType.Text = ""
        TxtNewKind.Text = ""
        TxtNewModel.Text = ""
        TxtNewType.Text = ""
        TxtNewKind.BackColor = Color.White
        TxtNewModel.BackColor = Color.White
        TxtNewType.BackColor = Color.White

    End Sub

    Private Sub ChkModel_Click(sender As Object, e As EventArgs) Handles ChkModel.Click
        ChkKind.Checked = False
        ChkModel.Checked = True
        ChkType.Checked = False
        GrpAdd.Enabled = True
        CmbKind.Enabled = True
        CmbModel.Enabled = True
        CmbType.Enabled = False
        TxtNewKind.Enabled = False
        TxtNewModel.Enabled = True
        TxtNewType.Enabled = False
        CmbKind.Text = ""
        CmbModel.Text = ""
        CmbType.Text = ""
        TxtNewKind.Text = ""
        TxtNewModel.Text = ""
        TxtNewType.Text = ""
        TxtNewKind.BackColor = Color.White
        TxtNewModel.BackColor = Color.White
        TxtNewType.BackColor = Color.White
    End Sub

    Private Sub ChkType_Click(sender As Object, e As EventArgs) Handles ChkType.Click
        ChkKind.Checked = False
        ChkModel.Checked = False
        ChkType.Checked = True
        GrpAdd.Enabled = True
        CmbKind.Enabled = True
        CmbModel.Enabled = True
        CmbType.Enabled = True
        TxtNewKind.Enabled = False
        TxtNewModel.Enabled = False
        TxtNewType.Enabled = True
        CmbKind.Text = ""
        CmbModel.Text = ""
        CmbType.Text = ""
        TxtNewKind.Text = ""
        TxtNewModel.Text = ""
        TxtNewType.Text = ""
        TxtNewKind.BackColor = Color.White
        TxtNewModel.BackColor = Color.White
        TxtNewType.BackColor = Color.White
    End Sub

    Private Sub CmbKind_Enter(sender As Object, e As EventArgs) Handles CmbKind.Enter
        LoadCarKind()
        Me.CmbKind.DataSource = MyTab
        Me.CmbKind.DisplayMember = "Carkind"
        Me.CmbKind.ValueMember = "carkindid"

    End Sub

    Private Sub CmbModel_Enter(sender As Object, e As EventArgs) Handles CmbModel.Enter
        LoadCarmodel(CmbKind.SelectedValue)
        Me.CmbModel.DataSource = MyTab
        Me.CmbModel.DisplayMember = "Carmodel"
        Me.CmbModel.ValueMember = "carmodelid"
    End Sub

    Private Sub CmbType_Enter(sender As Object, e As EventArgs) Handles CmbType.Enter
        LoadCartype(CmbModel.SelectedValue, CmbKind.SelectedValue)
        Me.CmbType.DataSource = MyTab
        Me.CmbType.DisplayMember = "cartype"
        Me.CmbType.ValueMember = "cartypeid"
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If ChkKind.Checked = True Or ChkModel.Checked = True Or ChkType.Checked = True Then

            If ChkKind.Checked = True Then
                If TxtNewKind.Text <> "" Then
                    Dim que As String
                    que = "select CarKind from CarKind where active = 1 "
                    FillList(que)
                    For i = 0 To MyTab.Rows.Count - 1
                        If TxtNewKind.Text = MyTab.Rows(i).Item(0).ToString Then
                            OkMsgAlert("שגיאה", "סוג רכב כבר קיים")
                            'MsgBox("סוג רכב כבר קיים", vbOKOnly + vbExclamation, "שגיאה")
                            TxtNewKind.SelectAll()
                            TxtNewKind.BackColor = Color.Pink
                            TxtNewKind.Focus()
                            Exit Sub
                        End If
                    Next
                    AddCarKind(TxtNewKind.Text, KindCount() + 1)
                    LoadCarKind()
                    TxtNewKind.Text = ""
                    OkMsgInfo("הוספת סוג רכב", "פעולה בוצעה בהצלחה")
                    TxtNewKind.Focus()
                    'MsgBox("פעולה בוצעה בהצלחה")
                Else
                    OkMsgAlert("שגיאה", "לא הוכנס סוג רכב")
                    'MsgBox("לא הוכנס סוג רכב")
                End If

            ElseIf ChkModel.Checked = True Then
                If CmbKind.Text <> "" Then
                    If TxtNewModel.Text <> "" Then
                        Dim que As String
                        que = "select CarModel from CarModel where carkindid =  " & CmbKind.SelectedValue & " and active = 1 "
                        FillList(que)
                        For i = 0 To MyTab.Rows.Count - 1
                            If TxtNewModel.Text = MyTab.Rows(i).Item(0).ToString Then
                                OkMsgAlert("שגיאה", "יצרן כבר קיים")
                                'MsgBox("יצרן כבר קיים", vbOKOnly + vbExclamation, "שגיאה")
                                TxtNewModel.SelectAll()
                                TxtNewModel.BackColor = Color.Pink
                                TxtNewModel.Focus()
                                Exit Sub
                            End If
                        Next
                        AddCarModel(TxtNewModel.Text, ModelCount() + 1, CmbKind.SelectedValue)
                        LoadCarmodel(CmbKind.SelectedValue)
                        TxtNewModel.Text = ""
                        OkMsgInfo("הוספת ייצרן רכב", "פעולה בוצעה בהצלחה")
                        TxtNewModel.Focus()
                        'MsgBox("פעולה בוצעה בהצלחה")
                    Else
                        OkMsgAlert("שגיאה", "לא הוכנס ייצרן רכב")
                        'MsgBox("לא הוכנס ייצרן רכב")
                    End If
                Else
                    OkMsgInfo("לא בחרת סוג רכב", "נא לבחור סוג רכב")
                    'MsgBox("נא לבחור סוג רכב")
                End If
            ElseIf ChkType.Checked = True Then
                If CmbKind.Text <> "" Then
                    If CmbModel.Text <> "" Then
                        If TxtNewType.Text <> "" Then
                            Dim que As String
                            que = "select cartype from cartype where carkindid =  " & CmbKind.SelectedValue & "  and carmodelid = " & CmbModel.SelectedValue & " and active = 1"
                            FillList(que)
                            For i = 0 To MyTab.Rows.Count - 1
                                If TxtNewType.Text = MyTab.Rows(i).Item(0).ToString Then
                                    OkMsgAlert("שגיאה", "דגם כבר קיים")
                                    'MsgBox("דגם כבר קיים", vbOKOnly + vbExclamation, "שגיאה")
                                    TxtNewType.SelectAll()
                                    TxtNewType.BackColor = Color.Pink
                                    TxtNewType.Focus()
                                    Exit Sub
                                End If
                            Next
                            AddCarType(TxtNewType.Text, TypeCount() + 1, CmbModel.SelectedValue, CmbKind.SelectedValue)
                            LoadCartype(CmbModel.SelectedValue, CmbKind.SelectedValue)
                            TxtNewType.Text = ""
                            OkMsgInfo("הוספת גדם רכב", "פעולה בוצעה בהצלחה")
                            TxtNewType.Focus()
                            'MsgBox("פעולה בוצעה בהצלחה")
                        Else
                            OkMsgAlert("שגיאה", "לא הוכנס דגם רכב")
                            'MsgBox("לא הוכנס דגם רכב")
                        End If
                    Else
                        OkMsgInfo("לא בחרת ייצרן רכב", "נא לבחור ייצרן רכב")
                        'MsgBox("נא לבחור ייצרן רכב")
                    End If
                Else
                    OkMsgInfo("לא בחרת סוג רכב", "נא לבחור סוג רכב")
                    'MsgBox("נא לבחור סוג רכב")
                End If
            End If
        Else
            OkMsgInfo("סוג פעולה", "נא לבחור סוג פעולה")
            'MsgBox("נא לבחור סוג פעולה")
        End If
        TxtNewKind.BackColor = Color.White
        TxtNewModel.BackColor = Color.White
        TxtNewType.BackColor = Color.White
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub CmbKind_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbKind.SelectionChangeCommitted
        CmbModel.Text = ""
        CmbType.Text = ""
        TxtNewModel.Text = ""
        TxtNewType.Text = ""
        TxtNewKind.BackColor = Color.White
        TxtNewModel.BackColor = Color.White
        TxtNewType.BackColor = Color.White
    End Sub

    Private Sub CmbModel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbModel.SelectedValueChanged
        CmbType.Text = ""
        TxtNewType.Text = ""
        TxtNewKind.BackColor = Color.White
        TxtNewModel.BackColor = Color.White
        TxtNewType.BackColor = Color.White
    End Sub

    Private Sub BtnAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNewType.KeyDown, TxtNewModel.KeyDown, TxtNewKind.KeyDown, CmbType.KeyDown, CmbModel.KeyDown, CmbKind.KeyDown, ChkType.KeyDown, ChkModel.KeyDown, ChkKind.KeyDown, BtnCancel.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            BtnAdd_Click(TxtNewKind.Text, e)
        End If
    End Sub

End Class