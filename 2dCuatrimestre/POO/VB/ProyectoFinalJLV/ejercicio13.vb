Public Class ejercicio13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static count As Integer
        count = count + 1
        lblValue.Text = count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count As Integer
        count = count + 1
        lblValue.Text = count
    End Sub
End Class