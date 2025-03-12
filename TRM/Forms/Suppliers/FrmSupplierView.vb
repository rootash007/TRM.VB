Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmSupplierView
    Dim isActive As Boolean
    Dim LoadedName As String
    Dim LoadedId As String
    Private Sub FrmSupplierView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadedName = TxtName.Text.ToString
        LoadedId = TxtID.Text.ToString
        If LblStatus.Visible = True Then
            isActive = FmSuppliers.DGVSuppliers.CurrentRow.Cells(13).Value
        End If
        Dim que As String = "select * from currency where isactive = 1"
        FillList(que)
        Dim emptyRow As DataRow = MyTab.NewRow()
        emptyRow("currency_short") = "" ' Empty value
        MyTab.Rows.InsertAt(emptyRow, 0) ' Insert at the first position
        Me.CmbCurrency.DataSource = MyTab
        Me.CmbCurrency.DisplayMember = "currency_short"
        Me.CmbCurrency.ValueMember = "id"
        CmbCurrency.SelectedIndex = 0

        'CmbCurrency.Text = ""
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrWhiteSpace(TxtName.Text) Then
            MsgBox("الرجاء ادخال الاسم", vbOKOnly + vbInformation, "استعلام")
            Return
        ElseIf String.IsNullOrWhiteSpace(TxtID.Text) Then
            MsgBox("الرجاء ادخال رمز المورد", vbOKOnly + vbInformation, "استعلام")
            Return
        End If
        If LblStatus.Visible = True Then
            '//save
            If LoadedName <> TxtName.Text Then
                If IsRecordExists("suppliers", "supplier_name", TxtName.Text.ToString) Then
                    MsgBox("الاسم استخدم سابقا , الرجاء استخدام اسم اخر", vbOKOnly + vbInformation, "استعلام")
                    TxtName.Focus()
                    Return
                End If
            ElseIf LoadedId <> TxtID.Text Then
                If IsRecordExists("suppliers", "supplier_id", TxtID.Text.ToString) Then
                    MsgBox("الرمز استخدم سابقا , الرجاء استخدام اسم اخر", vbOKOnly + vbInformation, "استعلام")
                    TxtID.Focus()
                    Return
                End If
            End If
            Dim SaveMsg As DialogResult
            SaveMsg = MsgBox("هل تريد حفظ التغييرات", vbYesNo + vbQuestion, "حفظ")
            If SaveMsg = 6 Then
                ' Define the parameters to update
                Dim SupplierUpdateParams As New Dictionary(Of String, Object) From {
                    {"supplier_name", TxtName.Text},
                    {"supplier_id", TxtID.Text},
                    {"supplier_contact", TxtContact.Text},
                    {"supplier_phone", TxtPhone.Text},
                    {"supplier_fax", TxtFax.Text},
                    {"supplier_email", TxtEmail.Text},
                    {"supplier_adress", TxtAdress.Text},
                    {"supplier_city", TxtCity.Text},
                    {"postal_code", TxtPostalCode.Text},
                    {"supplier_bank_details", TxtBank.Text},
                    {"currency", TxtCurrency.Text},
                    {"supplier_notes", TxtInfo.Text},
                    {"supplier_folder", TxtSupplierFolder.Text}
                }

                ' Specify the condition (e.g., update the record where supplier_id = 1)
                Dim conditionField As String = "id"
                Dim conditionValue As Object = FmSuppliers.DGVSuppliers.CurrentRow.Cells(0).Value

                ' Call the update function
                UpdateSupplierDynamic(SupplierUpdateParams, conditionField, conditionValue)

                'UpdateSupplier(TxtName.Text, TxtID.Text, TxtContact.Text, TxtPhone.Text, TxtFax.Text, TxtEmail.Text, TxtAdress.Text, TxtCity.Text, TxtPostalCode.Text, TxtBank.Text, TxtCurrency.Text, TxtInfo.Text, isActive, TxtSupplierFolder.Text, FmSuppliers.DGVSuppliers.CurrentRow.Cells(0).Value)
            End If
        Else
            '//add
            ' checking if the name or id exists if it has been changed
            If IsRecordExists("suppliers", "supplier_name", TxtName.Text.ToString) Then
                MsgBox("name exists")
                TxtName.Focus()
                Return
            ElseIf IsRecordExists("suppliers", "supplier_id", TxtID.Text.ToString) Then
                MsgBox("id exists")
                TxtID.Focus()
                Return
            End If
            Dim SupplierParams As New Dictionary(Of String, Object) From {
            {"supplier_name", TxtName.Text},
            {"supplier_id", TxtID.Text},
            {"supplier_contact", TxtContact.Text},
            {"supplier_phone", TxtPhone.Text},
            {"supplier_fax", TxtFax.Text},
            {"supplier_email", TxtEmail.Text},
            {"supplier_adress", TxtAdress.Text},
            {"supplier_city", TxtCity.Text},
            {"postal_code", TxtPostalCode.Text},
            {"supplier_bank_details", TxtBank.Text},
            {"currency", TxtCurrency.Text},
            {"supplier_notes", TxtInfo.Text},
            {"supplier_folder", TxtSupplierFolder.Text}
            }
            ' Add a new audit
            AddSupplierDynamic(SupplierParams)
            'AddSupplier(TxtName.Text, TxtID.Text, TxtContact.Text, TxtPhone.Text, TxtFax.Text, TxtEmail.Text, TxtAdress.Text, TxtCity.Text, TxtPostalCode.Text, TxtBank.Text, TxtCurrency.Text, TxtInfo.Text, TxtSupplierFolder.Text)
        End If
        LoadSuppliers()
        Me.Close()
    End Sub
    Private Sub StatusSwitch_Click(sender As Object, e As EventArgs) Handles StatusSwitch.Click
        If isActive = False Then
            isActive = True
            StatusSwitch.Image = My.Resources.swon1
            LblStatus.Text = "مفعل"
        Else
            isActive = False
            StatusSwitch.Image = My.Resources.swoff1
            LblStatus.Text = "غير مفعل"
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress, TxtID.KeyPress, TxtFax.KeyPress, TxtPostalCode.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub TxtPhone_Leave(sender As Object, e As EventArgs) Handles TxtPhone.Leave

    End Sub

    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSupplierFolder.KeyDown, TxtPostalCode.KeyDown, TxtPhone.KeyDown, TxtName.KeyDown, TxtID.KeyDown, TxtFax.KeyDown, TxtEmail.KeyDown, TxtCurrency.KeyDown, TxtContact.KeyDown, TxtCity.KeyDown, TxtAdress.KeyDown, DtpCreatedAt.KeyDown, BtnCancel.KeyDown, BtnAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAdd.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class