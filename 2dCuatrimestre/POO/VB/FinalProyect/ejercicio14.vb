Public Class ejercicio14
    'Creamos una variable publica
    Public count As Integer
    'Creamos una constante publica
    Const students = 8
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'A la variable le sumamos 
        count = count + 1
        'El valor obtenido de la variable se le sumara el valor constantes de alumnos
        lblCount.Text = count + students
    End Sub
End Class