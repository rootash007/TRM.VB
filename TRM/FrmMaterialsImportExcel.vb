﻿Public Class FrmMaterialsImportExcel
    Dim IsSelectAll As Boolean = False



    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        FrmMain.TSMainProgBar.Value = 0
        Dim Jumper As Double = 100 / DgvMaterials.RowCount
        Dim isNameFound As Boolean = False
        Dim isLocBarcodeFound As Boolean = False


        For i = 0 To DgvMaterials.RowCount - 1
            FrmMain.TSMainProgBar.Increment(Jumper)
            If DgvMaterials.Rows(i).Cells(0).Value = True Then
                For d = 0 To MaterialsTab.Rows.Count - 1
                    If DgvMaterials.Rows(i).Cells(1).Value = MaterialsTab.Rows(d).Item(1) Then
                        isNameFound = True
                    End If
                    If DgvMaterials.Rows(i).Cells(2).Value = MaterialsTab.Rows(d).Item(3) Then
                        isLocBarcodeFound = True
                    End If
                Next
                If isNameFound = True And isLocBarcodeFound = False Then
                    MsgBox("המוצר " & DgvMaterials.Rows(i).Cells(1).Value & " נמצא במערכת , אין אפשרות לשכפל מוצר", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "התראה")
                ElseIf isLocBarcodeFound = True And isNameFound = False Then
                    MsgBox("הברקוד  " & DgvMaterials.Rows(i).Cells(2).Value & " נמצא במערכת , אין אפשרות לשכפל מוצר", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "התראה")
                ElseIf isNameFound = True And isLocBarcodeFound = True Then
                    MsgBox("name and loc barcode  " & DgvMaterials.Rows(i).Cells(2).Value & " נמצא במערכת , אין אפשרות לשכפל מוצר", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "התראה")

                Else
                    'MsgBox("added")
                    AddMaterial(DgvMaterials.Rows(i).Cells(1).Value, DgvMaterials.Rows(i).Cells(2).Value, DgvMaterials.Rows(i).Cells(3).Value, DgvMaterials.Rows(i).Cells(4).Value, DgvMaterials.Rows(i).Cells(5).Value, DgvMaterials.Rows(i).Cells(6).Value, DgvMaterials.Rows(i).Cells(7).Value)

                End If
                isNameFound = False
                isLocBarcodeFound = False

            End If
        Next
        FrmMain.TSMainProgBar.Value = 100
        MsgBox("adding material done as successfully")
        FrmMain.TSMainProgBar.Value = 0
        LoadMaterials()
        Me.Close()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DgvMaterials_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvMaterials.KeyDown, BtnClose.KeyDown, BtnAccept.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Space Then
            If DgvMaterials.CurrentRow.Cells(0).Value = True Then
                DgvMaterials.CurrentRow.Cells(0).Value = False
            Else
                DgvMaterials.CurrentRow.Cells(0).Value = True
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            BtnAccept_Click(Me, e)

        End If
    End Sub

    Private Sub LinkLblSelect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLblSelect.LinkClicked

    End Sub

    Private Sub LinkLblSelect_Click(sender As Object, e As EventArgs) Handles LinkLblSelect.Click
        If IsSelectAll = False Then
            For i = 0 To DgvMaterials.RowCount - 1
                DgvMaterials.Rows(i).Cells(0).Value = True
            Next
            IsSelectAll = True
            LinkLblSelect.Text = "בטל הכל"
        Else
            For i = 0 To DgvMaterials.RowCount - 1
                DgvMaterials.Rows(i).Cells(0).Value = False
            Next
            IsSelectAll = False
            LinkLblSelect.Text = "בחר הכל"

        End If
    End Sub
End Class