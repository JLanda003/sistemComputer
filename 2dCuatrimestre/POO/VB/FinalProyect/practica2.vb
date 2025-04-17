Public Class practica2
    Private Sub btnSaludo_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click
        Dim nombre As String = txtNombre.Text
        lblBienvenida.Text = ""
        If String.IsNullOrWhiteSpace(nombre) Then
            lblSaludo.Text = "Por favor, ingresa tu nombre."
        Else
            lblSaludo.Text = "¡Hola, " & nombre & "!"
            lblBienvenida.Text = "Nos da mucho gusto qué estes aquí, Bienvenido/a."
        End If
    End Sub
End Class