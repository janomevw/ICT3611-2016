Public Class frmManagement

    Dim members As List(Of Member)

    Private Sub frmManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlEvents.Hide()
        pnlMembers.Hide()
        members = MembersDB.GetMembers
        Me.FillMemberListBox()
        ToolStripStatusLabel1.Text = " Copyright " & Chr(169)
    End Sub

    Private Sub FillMemberListBox()
        lstMembers.Items.Clear()
        For Each p As Member In members
            lstMembers.Items.Add(p.GetDisplayText(vbTab))
        Next
    End Sub

    Private Sub btnNewMember_Click(sender As Object, e As EventArgs) Handles btnNewMember.Click
        Dim newMemberForm As New frmNewMember
        newMemberForm.ShowDialog()
        If newMemberForm.Member IsNot Nothing Then
            members.Add(newMemberForm.Member)
            MembersDB.SaveMembers(members)
            Me.FillMemberListBox()
        End If
    End Sub

    Private Sub btnDeleteMember_Click(sender As Object, e As EventArgs) Handles btnDeleteMember.Click
        Dim i As Integer = lstMembers.SelectedIndex
        If i <> -1 Then
            Dim member As Member = members(i)
            Dim message As String = "Are you sure you want to delete " & member.Name & " " & member.Surname & " ?"
            Dim button As DialogResult = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo)
            If button = Windows.Forms.DialogResult.Yes Then
                members.Remove(member)
                MembersDB.SaveMembers(members)
                Me.FillMemberListBox()
            End If
        End If
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
        frmLogin.TextBox1.Text = ""
        frmLogin.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        If MsgBox("Are you sure you want to EXIT the Program?", MsgBoxStyle.OkCancel, "Please confirm") = MsgBoxResult.Ok Then
            Application.Exit()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnMembersMgnt_Click(sender As Object, e As EventArgs) Handles btnMembersMgnt.Click
        pnlMembers.Show()
        pnlEvents.Hide()
    End Sub

    Private Sub btnEventsMgnt_Click(sender As Object, e As EventArgs) Handles btnEventsMgnt.Click
        pnlEvents.Show()
        pnlMembers.Hide()
    End Sub
End Class