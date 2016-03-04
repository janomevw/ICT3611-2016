Imports System.IO

Public Class MembersDB
    ' Use file in project directory
    Private Const Dir As String = "..\..\"

    Private Const Path As String = Dir & "Members.txt"

    Public Shared Function GetMembers() As List(Of Member)

        If Not Directory.Exists(Dir) Then
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(
            New FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim members As New List(Of Member)

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns As String() = row.Split(CChar("|"))
            Dim member As New Member
            'member.MemberNr = columns(0)
            member.Name = columns(1)
            member.Surname = columns(2)
            members.Add(member)
        Loop

        textIn.Close()

        Return members

    End Function

    Public Shared Sub SaveMembers(members As List(Of Member))

        Dim textOut As New StreamWriter(
            New FileStream(path, FileMode.Create, FileAccess.Write))

        For Each member As Member In members
            'textOut.Write(member.MemberNr & "|")
            textOut.Write(member.Name & "|")
            textOut.Write(member.Surname & "|")
        Next

        textOut.Close()
    End Sub

End Class
