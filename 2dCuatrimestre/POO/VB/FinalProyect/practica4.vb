Public Class practica4
    Private Sub btnCalSquare_Click(sender As Object, e As EventArgs) Handles btnCalSquare.Click
        'Creamos las variables
        Dim value, result As Double

        'Convertimos el valor del TextBox a numerico con punto decimal
        value = Double.Parse(txtInputSquare.Text)

        'Realizamos la operacion del area de un Cuadrado
        'Area de un Cuadrado es LADO * LADO
        result = value * value

        'Coloreamos el texto del Label de resultado
        'para identificar la operacion realizada
        lblResult.ForeColor = Color.SteelBlue
        'Mostramos el resultado en el TextBox de resultado
        txtResult.Text = result
    End Sub

    Private Sub btnCalRectangle_Click(sender As Object, e As EventArgs) Handles btnCalRectangle.Click
        'Creamos las variables
        Dim value1, value2, result As Double

        'Convertimos los valores de los TextBox a numerico con punto decimal
        value1 = Double.Parse(txtInputRectangle1.Text)
        value2 = Double.Parse(txtInputRectangle2.Text)

        'Realizamos la operacion del area de un Rectangulo
        'Area de un Rectangulo es BASE * ALTURA
        result = value1 * value2

        'Coloreamos el texto del Label de resultado
        'para identificar la operacion realizada
        lblResult.ForeColor = Color.Maroon
        'Mostramos el resultado en el TextBox de resultado
        txtResult.Text = result
    End Sub

    Private Sub btnCalTriangle_Click(sender As Object, e As EventArgs) Handles btnCalTriangle.Click
        'Creamos las variables
        Dim value1, value2, result As Double

        value1 = Double.Parse(txtInputTriangle1.Text)
        value2 = Double.Parse(txtInputTriangle2.Text)

        'Realizamos la operacion del area de un Triangulo
        'Area de un Triangulo es (BASE * ALTURA) / 2
        result = (value1 * value2) / 2

        'Coloreamos el texto del Label de resultado
        'para identificar la operacion realizada
        lblResult.ForeColor = Color.DarkGreen
        'Mostramos el resultado en el TextBox de resultado
        txtResult.Text = result

    End Sub

    'Boton para limpiar la informacion del TextBox de resultados y del apartado de Calculo de Cuadrado
    Private Sub btnClearSquare_Click(sender As Object, e As EventArgs) Handles btnClearSquare.Click
        'Retornamos el color a negro del Label
        lblResult.ForeColor = Color.Black
        'Retornamos al valor inicial de los TextBox
        txtInputSquare.Text = "0"
        txtResult.Text = ""
    End Sub

    'Boton para limpiar la informacion del TextBox de resultados y del apartado de Calculo de Rectangulo
    Private Sub btnClearRectangle_Click(sender As Object, e As EventArgs) Handles btnClearRectangle.Click
        'Retornamos el color a negro del Label
        lblResult.ForeColor = Color.Black
        'Retornamos al valor inicial de los TextBox
        txtInputRectangle1.Text = "0"
        txtInputRectangle2.Text = "0"
        txtResult.Text = ""
    End Sub

    'Boton para limpiar la informacion del TextBox de resultados y del apartado de Calculo de Triangulo
    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        'Retornamos el color a negro del Label
        lblResult.ForeColor = Color.Black
        'Retornamos al valor inicial de los TextBox
        txtInputTriangle1.Text = "0"
        txtInputTriangle2.Text = "0"
        txtResult.Text = ""
    End Sub
End Class