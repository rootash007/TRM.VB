Public Class FrmAddCustomers

    Private Sub FrmAddCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If switcher = True Then
            StatusSwitch.Image = My.Resources.swon1
            LblStatus.Text = "פעיל"
        Else
            StatusSwitch.Image = My.Resources.swoff1
            LblStatus.Text = "לא פעיל"
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        'Me.ChkStatus.Visible = False
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtCName.Text <> "" Then
            If BtnAdd.Text = "הוספה" Then
                AddNewCostomer(TxtCName.Text, TxtCContact.Text, TxtCId.Text, TxtCAdress.Text, TxtCPhone.Text, TxtCFax.Text, TxtCEmail.Text, TxtCInfo.Text)
                'ReloadCustomers()
                'Me.Close()
            ElseIf BtnAdd.Text = "שחזור" Then
                UpdateCustomer(TxtCName.Text, TxtCContact.Text, TxtCId.Text, TxtCAdress.Text, TxtCPhone.Text, TxtCFax.Text, TxtCEmail.Text, TxtCInfo.Text, True, FrmCustomers.SelectedDGV.CurrentRow.Cells(0).Value)
                'ReloadCustomers()
                'Me.Close()
            Else
                UpdateCustomer(TxtCName.Text, TxtCContact.Text, TxtCId.Text, TxtCAdress.Text, TxtCPhone.Text, TxtCFax.Text, TxtCEmail.Text, TxtCInfo.Text, switcher, FrmCustomers.SelectedDGV.CurrentRow.Cells(0).Value)
                'ReloadCustomers()
                'Me.Close()
            End If
            ReloadCustomers()
            ReLoadMain()
            Me.Close()
        Else
            OkMsgAlert("שדה חובה", "שם לקוח חובה")
            ' MsgBox("שם לקוח חובה")
        End If
    End Sub

    Private Sub TxtVId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCId.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtVPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCPhone.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtVFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCFax.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub ChkStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCPhone.KeyDown, TxtCName.KeyDown, TxtCInfo.KeyDown, TxtCId.KeyDown, TxtCFax.KeyDown, TxtCEmail.KeyDown, TxtCContact.KeyDown, TxtCAdress.KeyDown, BtnCancel.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub PicSwitch_Click(sender As Object, e As EventArgs) Handles StatusSwitch.Click
        If switcher = True Then
            StatusSwitch.Image = My.Resources.swoff1
            switcher = False
            LblStatus.Text = "לא פעיל"
        Else
            StatusSwitch.Image = My.Resources.swon1
            switcher = True
            LblStatus.Text = "פעיל"
        End If
    End Sub

End Class