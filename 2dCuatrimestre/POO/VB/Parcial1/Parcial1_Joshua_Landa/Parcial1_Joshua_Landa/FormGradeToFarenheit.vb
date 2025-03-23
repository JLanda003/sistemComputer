Public Class FormGradeToFarenheit
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        txtInput.Text = ""
        txtOutput.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        txtOutput.Text = (1.8 * txtInput.Text) + 32
    End Sub
End Class