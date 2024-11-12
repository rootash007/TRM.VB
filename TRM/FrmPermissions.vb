Public Class FrmPermissions

    Private Sub FrmMlaiList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Que As String = "select * from permissions"
        FillList(Que)
        DGVPermissions.DataSource = MyTab
        With DGVPermissions
            .Columns(0).Visible = False
            '.Columns(1).Visible = True
            '.Columns(2).Visible = True
            '.Columns(3).Visible = True
            '.Columns(4).Visible = True
            '.Columns(5).Visible = False
            '.Columns(6).Visible = False
            '.Columns(7).Visible = False
            '.Columns(8).Visible = False
            '.Columns(2).DefaultCellStyle.Format = "*"

            '.Columns(0).HeaderText = "שם הרשאה"
            .Columns(1).HeaderText = "שם הרשאה"
            .Columns(2).HeaderText = "רמה 1"
            .Columns(3).HeaderText = "רמה 2"
            .Columns(4).HeaderText = "רמה 3"
            .Columns(5).HeaderText = "רמה 4"
            .Columns(6).HeaderText = "רמה 5"
            .Columns(7).HeaderText = "רמה 6"
            .Columns(8).HeaderText = "רמה 7"
            .Columns(9).HeaderText = "רמה 8"
            .Columns(10).HeaderText = "רמה 9"



            .Columns(0).Width = 55
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).Width = 140
            .Columns(2).Width = 50
            .Columns(3).Width = 50
            .Columns(4).Width = 50
            .Columns(5).Width = 50
            .Columns(6).Width = 50
            .Columns(7).Width = 50
            .Columns(8).Width = 50
            .Columns(9).Width = 50
            .Columns(10).Width = 50


        End With
        'Dim MlaiYear As Date
        'Dim BuyDate As Date
        'Dim MYear As Integer
        'Dim MMonth As Integer = 11
        'Dim MDay As Integer = 30
        'MYear = FrmMlaiYear.DtpMlaiYear.Value.Year

        'MlaiYear = MlaiYear.AddYears(MYear - 1)
        'MlaiYear = MlaiYear.AddMonths(12)
        'MlaiYear = MlaiYear.AddDays(30)
        'MlaiYear = MlaiYear.AddHours(23)
        'MlaiYear = MlaiYear.AddMinutes(59)
        'MlaiYear = MlaiYear.AddSeconds(59)


        'MsgBox(FrmMlaiYear.DtpMlaiYear.Value)
        'FrmMlaiYear.DtpMlaiYear.Value = FrmMlaiYear.DtpMlaiYear.Value.AddMonths(5)
        'MsgBox(MlaiYear.ToString)

        'MsgBox(MlaiYear)
        'MlaiYear.Month = FrmMlaiYear.DtpMlaiYear.Value
        'MlaiYear.Day = FrmMlaiYear.DtpMlaiYear.Value

        'FillMlaiList(MlaiYear.ToString)
        'FillMlaiList(FrmMlaiYear.DtpMlaiYear.Value.ToShortDateString)
        'DGVMlaiList.DataSource = MlaiTab
    End Sub

End Class