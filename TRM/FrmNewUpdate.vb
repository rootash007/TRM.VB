Imports System.Net.WebRequestMethods
Imports System.Security.Policy

Public Class FrmNewUpdate
    Dim AppPath As String = My.Application.Info.DirectoryPath
    Dim wClient As New System.Net.WebClient
    Dim SetupFile As String = AppPath + "\setup.exe"
    Private Sub FrmNewUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LblPath.Text = AppPath
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'wClient.DownloadFileAsync(New Uri("https://www.ctrlmanager.com/Version.txt"), "d:\setup1.txt")
        Try
            'If System.IO.File.Exists(SetupFile) Then
            '    System.IO.File.Delete(SetupFile)
            '    MsgBox("deleted")
            'End If
            'wClient.DownloadDataAsync(New Url("https://www.ctrlmanager.com/TRM/", ""))

            'My.Computer.Network.DownloadFile("https://www.ctrlmanager.com/TRM/setup.exe", AppPath + "\setup.exe", False, 3000)
            'My.Computer.Network.DownloadFile("https://www.ctrlmanager.com/TRM/RMSetup.msi", AppPath + "\RMSetup.msi", False, 3000)
            'My.Computer.Network.DownloadFile("https://www.ctrlmanager.com/TRM/setup.exe", AppPath + "\setup.exe", False, 3000)
            'My.Computer.Network.DownloadFile()

            'MsgBox("downloaded")
            Process.Start("https://www.ctrlmanager.com/TRM/publish.htm")
            'Process.Start(AppPath + "\setup.exe")
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class