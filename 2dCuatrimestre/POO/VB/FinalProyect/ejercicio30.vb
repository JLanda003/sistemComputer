Public Class ejercicio30
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero As Integer

        If Integer.TryParse(txtNumero.Text, numero) Then
            lblResultado.Text = "Tabla de multiplicar de " & numero.ToString() & ":" & Environment.NewLine

            For i As Integer = 1 To 10
                lblResultado.Text &= numero.ToString() & " x " & i.ToString() & " = " & (numero * i).ToString() & Environment.NewLine
            Next
        Else
            lblResultado.Text = "Error: Ingrese un número entero válido."
        End If
    End Sub
End Class