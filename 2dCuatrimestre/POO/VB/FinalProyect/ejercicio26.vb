Public Class ejercicio26
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Creamos las variables para el valor del producto y el texto
        Dim value As Double, text As String = "Sin IVA"
        Select Case lbObjects.SelectedIndex()
            Case 0
                value = 100
            Case 1
                value = 400
            Case 2
                value = 200
            Case 3
                value = 150
            Case 4
                value = 175
            Case 6
                value = 75
        End Select

        If (rBtnIva.Checked) Then
            value = value + (value * 0.16)
            text = "Con IVA"
        End If

        txtPrices.Text = value
        lblText.Text = text
    End Sub
End Class