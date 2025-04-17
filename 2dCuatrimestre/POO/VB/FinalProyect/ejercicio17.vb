Public Class ejercicio17
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fechaNacimiento As DateTime = dtpFechaNacimiento.Value

        ' Calcular la edad
        Dim edad As Integer = CalcularEdad(fechaNacimiento)

        ' Mostrar la edad en el Label
        lblEdad.Text = "Tu edad es: " & edad.ToString() & " años."
    End Sub

    Private Function CalcularEdad(fechaNacimiento As DateTime) As Integer
        Dim hoy As DateTime = DateTime.Now
        Dim edad As Integer = hoy.Year - fechaNacimiento.Year

        ' Ajustar la edad si el cumpleaños aún no ha ocurrido este año
        If (hoy.Month < fechaNacimiento.Month) Or (hoy.Month = fechaNacimiento.Month And hoy.Day < fechaNacimiento.Day) Then
            edad -= 1
        End If

        Return edad
    End Function
End Class