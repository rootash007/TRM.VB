Imports Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Module Controller_FrmMain

    Public Sub ChkPermission()
        'Dim count As Integer
        'Dim comments As New DataSet
        'comments = GetComments(classid)

        'With CommentsView
        '    .View = View.Details
        '    .Columns.Add("User")
        '    .Columns.Add("Comment")
        'End With

        'count = CountRecords() - 1
        'For i As Integer = 0 To count
        '    CommentsView.Items.Add(comments.Tables(0).Rows(i).Item(2))
        '    CommentsView.Items.Add(comments.Tables(0).Rows(i).Item(3))

        'Next

        'Try
        '    Dim que As String = "select * from users"
        '    FillList(que)

        '    Dim LVI As ListViewItem
        '    ' no need for a count temp var
        '    For i As Integer = 0 To 5
        '        LVI = New ListViewItem
        '        ' whatever you want to show in columns 0
        '        LVI.Text = "test" & i

        '        ' add subitem text
        '        ' this is adding strings from a dataset, but could be any string
        '        LVI.SubItems.Add(MyTab.Rows(i).Item(2))    ' maybe .ToString?
        '        LVI.SubItems.Add(MyTab.Rows(i).Item(3))

        '        ' add completed LVI to the LV
        '        CommentsView.Items.Add(LVI)
        '    Next


        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try



    End Sub

End Module
