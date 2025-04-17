Public Class practica8
    Private Sub txtCalculate_Click(sender As Object, e As EventArgs) Handles txtCalculate.Click
        Dim value As Double

        value = Double.Parse(txtInput.Text)

        If (value > 50) Then
            value = value - (value * 0.2)
        ElseIf (value >= 30) Then
            value = value - (value * 0.1)
        End If

        txtOutput.Text = value
    End Sub
End Class