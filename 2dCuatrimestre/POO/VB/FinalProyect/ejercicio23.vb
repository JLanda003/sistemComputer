Public Class ejercicio23
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim dia As Integer
        Dim mes As Integer
        Dim año As Integer

        If Integer.TryParse(txtDia.Text, dia) AndAlso Integer.TryParse(txtMes.Text, mes) AndAlso Integer.TryParse(txtAño.Text, año) Then
            If dia < 1 Or dia > 31 Or mes < 1 Or mes > 12 Then
                lblResultado.Text = "Error: Día o mes inválido."
            Else
                Try
                    Dim fecha As New DateTime(año, mes, dia)
                    lblResultado.Text = "Fecha ingresada: " & fecha.ToString("dd/MM/yyyy")
                Catch ex As Exception
                    lblResultado.Text = "Error: Fecha no válida."
                End Try
            End If
        Else
            lblResultado.Text = "Error: Ingrese números válidos."
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resultado As DialogResult = MessageBox.Show(
            "¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question
        )

        If resultado = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class