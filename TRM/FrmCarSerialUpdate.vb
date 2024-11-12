Public Class FrmCarSerialUpdate

    Private Sub FrmCarSerialUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim que As String
        'que = "select CarSerial from MainList order by CarSerial"
        'FillList(que)
        FirstEmptyCarSerial()
        TxtOldCarSerial.Text = My.Settings.LocalDataBase
        'For i = My.Settings.EmptyCarSerial - 1 To MyTab.Rows.Count - 1
        '    If My.Settings.EmptyCarSerial = MyTab.Rows(i).Item(0).ToString Then
        '        My.Settings.EmptyCarSerial += 1
        '    End If
        'Next
        'My.Settings.Save()
        TxtNewCarSerial.Text = My.Settings.EmptyCarSerial
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtNewCarSerial.Text <> "" Then
            Dim que As String
            Dim ChkSerial As Boolean = False
            que = "select CarSerial from MainList "
            FillList(que)
            For i = 0 To MyTab.Rows.Count - 1
                If TxtNewCarSerial.Text = MyTab.Rows(i).Item(0).ToString Then
                    ChkSerial = True
                End If
            Next
            If ChkSerial = True Then
                MsgBox("מספר ביומן קיים במערכת", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "מספר קיים")
                TxtNewCarSerial.Focus()
                Return
            Else
                Dim ExitMsg As DialogResult
                ExitMsg = MsgBox("האם אתה בטוח שברצונך לעדכן מספר ביומן", vbYesNo + vbQuestion, "עדכון מספר ביומן")
                If ExitMsg = 6 Then
                    My.Settings.LocalDataBase = TxtNewCarSerial.Text
                    My.Settings.Save()
                    Me.Close()
                    TxtNewCarSerial.Text = ""
                    TxtNewCarSerial.BackColor = Color.White
                End If
            End If
        Else
            MsgBox("נא להקליד מספר ביומן חדש", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "אין ערך חדש")
            TxtNewCarSerial.BackColor = Color.Pink
            TxtNewCarSerial.Select()
        End If
    End Sub

    Private Sub TxtNewCarSerial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNewCarSerial.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtNewCarSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNewCarSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave_Click(TxtNewCarSerial, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnSave_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtOldCarSerial.KeyDown, BtnSave.KeyDown, BtnCancel.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        TxtNewCarSerial.Text = ""
        TxtNewCarSerial.BackColor = Color.White
    End Sub

End Class