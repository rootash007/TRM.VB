Public Class UserModel
    ' Properties
    Public Property Id As Integer
    Public Property UserName As String
    Public Property UserPass As String
    Public Property UserLvl As Integer
    Public Property UserPhone As String
    Public Property UserIsActive As Boolean



    ' Constructor
    'Public Sub New()
    '    ' Default constructor
    'End Sub

    ' Parameterized constructor
    Public Sub New(id As Integer, user_name As String, user_pass As String, user_lvl As Integer, user_phone As String, user_isactive As Boolean)
        Me.Id = id
        Me.UserName = user_name
        Me.UserPass = user_pass
        Me.UserLvl = user_lvl
        Me.UserPhone = user_phone
        Me.UserIsActive = user_isactive

    End Sub

    ' Method to display person details

    'Public Function GetFullName() As String
    '    Return $"{FirstName} {LastName}"
    'End Function

End Class
