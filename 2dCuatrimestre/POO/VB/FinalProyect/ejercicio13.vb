Public Class ejercicio13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'Durante la vida del programa esta variable
        'se creara una vez y mantendra su valor anterior
        'pero solo sera en funcional para este fragmento de codigo
        Static count As Integer
        count = count + 1
        lblCount.Text = count
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        'Esta varible cada que se inicie el fragmento de codigo
        'se estara creando con un valor no definido
        Dim count As Integer
        count = count + 1
        lblCount.Text = count
    End Sub
End Class