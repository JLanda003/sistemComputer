Public Class ejercicio18
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fechaNacimiento As DateTime = dtpFechaNacimiento.Value

        Dim edad As Integer = CalcularEdad(fechaNacimiento)

        lblEdad.Text = "Tu edad es: " & edad.ToString() & " años."

        If edad >= 18 Then
            lblMayorEdad.Text = "Eres mayor de edad."
        Else
            lblMayorEdad.Text = "Eres menor de edad."
        End If
    End Sub

    Private Function CalcularEdad(fechaNacimiento As DateTime) As Integer
        Dim hoy As DateTime = DateTime.Now
        Dim edad As Integer = hoy.Year - fechaNacimiento.Year

        If (hoy.Month < fechaNacimiento.Month) Or (hoy.Month = fechaNacimiento.Month And hoy.Day < fechaNacimiento.Day) Then
            edad -= 1
        End If

        Return edad
    End Function
End Class