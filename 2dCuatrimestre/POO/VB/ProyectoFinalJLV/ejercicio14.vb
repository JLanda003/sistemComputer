Public Class ejercicio14
    Public count As Integer
    Const students = 4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        count = count + 1
        lblValue.Text = count + students
    End Sub
End Class