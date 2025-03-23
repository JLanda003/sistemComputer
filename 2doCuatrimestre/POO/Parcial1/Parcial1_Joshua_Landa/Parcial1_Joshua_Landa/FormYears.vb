Public Class FormYears
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        txtInput.Text = ""
        txtOutput.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        If (Convert.ToInt32(txtInput.Text) >= 18) Then
            txtOutput.Text = "Es mayor de edad"
        Else
            txtOutput.Text = "Es menor de edad"
        End If
    End Sub
End Class