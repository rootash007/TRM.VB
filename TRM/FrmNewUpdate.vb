'Imports System.Net.WebRequestMethods
Imports System.Security.Policy

Imports System.Net.Http
Imports System.Reflection
Imports System.Threading.Tasks
Imports System.Xml.Linq

Public Class FrmNewUpdate
    'Dim AppPath As String = My.Application.Info.DirectoryPath
    'Dim wClient As New System.Net.WebClient
    'Dim SetupFile As String = AppPath + "\setup.exe"
    Private Async Sub FrmNewUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LblPath.Text = AppPath
        BtnUpdate.Visible = False

        Try
            Dim currentVersion As Version = Assembly.GetExecutingAssembly().GetName().Version
            'With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
            '    LblCurrentVersion.Text = .Major & "." & .Minor & "." & .Build & "." & .Revision
            'End With
            LblCurrentVersion.Text = My.Settings.CurrentVersion
            Dim latestVersion As Version = Await GetLatestVersionAsync()
            'LblCurrentVersion.Text = currentVersion.ToString
            LblNewVersion.Text = latestVersion.ToString

            If latestVersion IsNot Nothing Then
                If latestVersion > currentVersion Then
                    BtnUpdate.Visible = True
                Else
                    MsgBox("You are using the latest version.")
                End If
            Else
                MsgBox("Failed to check for updates.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Process.Start("https://www.ctrlmanager.com/TRM/publish.htm")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Async Function CheckForUpdatesAsync() As Task
        ' Get the current version of the application
        Dim currentVersion As Version = Assembly.GetExecutingAssembly().GetName().Version

        ' Get the latest version from the server
        Dim latestVersion As Version = Await GetLatestVersionAsync()

        If latestVersion IsNot Nothing Then
            ' Compare versions
            If latestVersion > currentVersion Then
                Console.WriteLine("A new version is available! Do you want to update? (Y/N)")
                Dim response As String = Console.ReadLine()

                If response.ToUpper() = "Y" Then
                    ' Perform the update (e.g., download and install the new version)
                    PerformUpdate()
                Else
                    Console.WriteLine("Update skipped. You can check for updates manually later.")
                End If
            Else
                Console.WriteLine("You are using the latest version.")
            End If
        Else
            Console.WriteLine("Failed to check for updates.")
        End If
    End Function

    Async Function GetLatestVersionAsync() As Task(Of Version)
        ' URL to the .application file on the host
        Dim applicationUrl As String = "https://www.ctrlmanager.com/TRM/RM.application"

        Try
            ' Use HttpClient to fetch the .application file
            Using client As New HttpClient()
                Dim applicationXml As String = Await client.GetStringAsync(applicationUrl)

                ' Parse the XML to extract the version
                Dim xmlDoc As XDocument = XDocument.Parse(applicationXml)
                Dim ns As XNamespace = "urn:schemas-microsoft-com:asm.v1"
                Dim assemblyIdentity As XElement = xmlDoc.Descendants(ns + "assemblyIdentity").FirstOrDefault()

                If assemblyIdentity IsNot Nothing Then
                    Dim versionString As String = assemblyIdentity.Attribute("version").Value
                    Return New Version(versionString)
                Else
                    Console.WriteLine("Failed to parse the deployment manifest.")
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error fetching latest version: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Sub PerformUpdate()
        ' Simulate the update process
        ' Replace this with your actual update logic (e.g., download and install the new version)
        Console.WriteLine("Downloading and installing the new version...")
        ' Add your update logic here
        Console.WriteLine("Update completed successfully.")
    End Sub
End Class