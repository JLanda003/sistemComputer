Public Class Form1
    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        Me.Hide()
        FormGradeToFarenheit.Show()
    End Sub

    Private Sub btnYears_Click(sender As Object, e As EventArgs) Handles btnYears.Click
        Me.Hide()
        FormYears.Show()
    End Sub

    Private Sub btnCompanySecure_Click(sender As Object, e As EventArgs) Handles btnCompanySecure.Click
        Me.Hide()
        FormCompanySecure.Show()
    End Sub
End Class
