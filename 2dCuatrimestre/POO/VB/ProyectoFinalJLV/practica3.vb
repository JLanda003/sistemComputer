Public Class practica3
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputValue, outputMinutes, outputSeconds As Integer

        inputValue = Integer.Parse(txtInput.Text)

        outputMinutes = inputValue * 60
        outputSeconds = outputMinutes * 60

        txtOMinutes.Text = outputMinutes
        txtOSeconds.Text = outputSeconds
    End Sub
End Class