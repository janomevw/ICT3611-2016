Public Class Member

    Public Sub New()

    End Sub

    Public Sub New(name As String, surname As String, gender As String, joinDate As String, birthDate As String)
        Me.Name = name
        Me.Surname = surname
        Me.Gender = gender
        Me.joinDate = joinDate
        Me.birthDate = birthDate

    End Sub

    Public Property Name As String

    Public Property Surname As String

    Public Property Gender As String

    Public Property joinDate As String

    Public Property birthDate As String

    Public Function GetDisplayText(sep As String) As String
        Dim text As String = "Name: " & Name & " " & Surname & sep & Gender & sep & "Date Joined: " & joinDate & sep & "DOB: " & birthDate
        Return text
    End Function

End Class
