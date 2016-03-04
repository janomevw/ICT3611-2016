Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(TextBox1.Text) < 8 Then
            MsgBox(Prompt:="Please enter a valid 8-digit passcode", Buttons:=MsgBoxStyle.Information, Title:="Oops...")
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf TextBox1.Text = "53228197" Then
            Me.Hide()
            frmManagement.Show()
        Else
            MsgBox(Prompt:="The passcode entered is invalid", Buttons:=MsgBoxStyle.Critical, Title:="Incorrect Passcode")
            TextBox1.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) > 1 Then
            Button1.Show()
            Button3.Hide()
            If Len(TextBox1.Text) = 8 Then
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("The passcode to use is my student number:53228197", MsgBoxStyle.Information, "Passcode")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Hide()
        Button3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
