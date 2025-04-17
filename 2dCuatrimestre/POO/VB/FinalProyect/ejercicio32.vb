Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class ejercicio32
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero As Integer

        If Integer.TryParse(txtNumero.Text, numero) Then

            Dim cifras As String = numero.ToString()
            Dim cantidadCifras As Integer = cifras.Length
            Dim sumaImpares As Integer = 0
            Dim sumaPares As Integer = 0
            Dim sumaTotal As Integer = 0
            Dim cifraMayor As Integer = Integer.MinValue
            Dim cifraMenor As Integer = Integer.MaxValue
            Dim divisores As New List(Of Integer)()

            For Each cifraChar As Char In cifras
                Dim cifra As Integer = Integer.Parse(cifraChar.ToString())
                sumaTotal += cifra

                If cifra Mod 2 = 0 Then
                    sumaPares += cifra
                Else
                    sumaImpares += cifra
                End If

                If cifra > cifraMayor Then
                    cifraMayor = cifra
                End If

                If cifra < cifraMenor Then
                    cifraMenor = cifra
                End If
            Next

            For i As Integer = 1 To Math.Abs(numero)
                If numero Mod i = 0 Then
                    divisores.Add(i)
                End If
            Next

            lblResultado.Text = $"Cantidad de cifras: {cantidadCifras}" & Environment.NewLine &
                            $"Suma de cifras impares: {sumaImpares}" & Environment.NewLine &
                            $"Suma de cifras pares: {sumaPares}" & Environment.NewLine &
                            $"Suma total de cifras: {sumaTotal}" & Environment.NewLine &
                            $"Cifra mayor: {cifraMayor}" & Environment.NewLine &
                            $"Cifra menor: {cifraMenor}" & Environment.NewLine &
                            $"Divisores: {String.Join(", ", divisores)}"
        Else
            lblResultado.Text = "Error: Ingrese un número entero válido."
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class