Public Class ejercicio9
    Dim valor1 As Double
    Dim valor2 As Double
    Dim operacion As String

    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click,
        btn3.Click, btn4.Click, btn5.Click,
        btn6.Click, btn7.Click, btn8.Click,
        btn9.Click
        txtResultado.Text &= DirectCast(sender, Button).Text
    End Sub

    Private Sub btnOperacion_Click(sender As Object, e As EventArgs) Handles btnSuma.Click, btnResta.Click, btnResta.Click, btnDivision.Click
        valor1 = Convert.ToDouble(txtResultado.Text)
        operacion = DirectCast(sender, Button).Text
        txtResultado.Clear()
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        valor2 = Convert.ToDouble(txtResultado.Text)

        Select Case operacion
            Case "+"
                txtResultado.Text = (valor1 + valor2).ToString()
            Case "-"
                txtResultado.Text = (valor1 - valor2).ToString()
            Case "*"
                txtResultado.Text = (valor1 * valor2).ToString()
            Case "/"
                If valor2 <> 0 Then
                    txtResultado.Text = (valor1 / valor2).ToString()
                Else
                    txtResultado.Text = "Error"
                End If
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResultado.Clear()
        valor1 = 0
        valor2 = 0
        operacion = ""
    End Sub
End Class