Public Class frmNewMember

    Public Member As Member

    Private Sub frmNewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As Integer = DateTime.Today.Year
        Dim strtYear As Integer = year - 75
        ComboYear.Items.Add("Year")
        Do While year > strtYear
            ComboYear.Items.Add(year)
            year -= 1
        Loop
        ComboYear.SelectedIndex = 0
        'Month
        ComboMonth.Items.Add("Month")
        Dim m As Integer = 1
        Dim q As Integer = 12
        Do While m < q
            ComboMonth.Items.Add(m)
            m += 1
        Loop
        ComboMonth.SelectedIndex = 0
        'Day
        ComboDay.Items.Add("Day")
        Dim i As Integer = 1
        Dim k As Integer = 31
        Do While i < k
            ComboDay.Items.Add(i)
            i += 1
        Loop
        ComboDay.SelectedIndex = 0
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim year As String = ComboYear.Text
        Dim month As String = ComboMonth.Text
        Dim day As String = ComboDay.Text
        Dim birthDate As String = year
        birthDate &= month
        birthDate &= day
        Dim joinDate As String = DatePickJoin.Value.ToShortDateString
        If RadioMale.Checked = True Then
            TxtGender.Text = "Male"
        End If
        If RadioFemale.Checked = True Then
            TxtGender.Text = "Female"
        End If
        Dim rand As Integer = CInt(Int((999 * Rnd()) + 1))

        '**************************

        Dim joinYear = joinDate.Substring(2, joinDate.Length - 2)
        Dim MemberNr As String = joinYear + "" + birthDate + Convert.ToString(rand) + ""

        '**************************
        Member = New Member(TxtName.Text, TxtSurname.Text, TxtGender.Text, joinDate, birthDate)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class