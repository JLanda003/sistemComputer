Public Class practica3
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Creamos las variables a utilizar
        Dim convert, minutes, seconds As Integer

        'Transformamo el valor del TextBox ya que este ingresa como texto
        convert = Integer.Parse(txtInput.Text)
        'Calculamos los minutos
        minutes = convert * 60
        'Calculamos los segundos
        seconds = minutes * 60

        'Mostramos en el TextBox de minutos el resultado
        txtMinutes.Text = minutes
        'Mostramos en el TextBox de segundos el resultado
        txtSeconds.Text = seconds
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Boton para cerrar la ventana
        Me.Close()
    End Sub
End Class