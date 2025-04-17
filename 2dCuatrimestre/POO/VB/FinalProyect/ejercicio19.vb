Public Class ejercicio19
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim yearsOld As Integer

        yearsOld = Integer.Parse(txtInputYearsOld.Text)

        If (yearsOld < 18) Then lblOutput.Text = "Es menor de edad"
    End Sub
End Class