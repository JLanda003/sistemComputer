Public Class practica6
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Cuando se pulse el boton de salir cerrar la venta
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Permite limpiar todos los recuadros de texto
        txtInputValue.Text = 0
        txtOp10.Text = 0
        txtOp20.Text = 0
        txtOp50.Text = 0
        txtOp100.Text = 0
        txtOp200.Text = 0
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim inputValue, value10, value20, value50, value100, value200 As Integer

        inputValue = Val(txtInputValue.Text)

        If (inputValue >= 200) Then
            value200 = inputValue Mod 200
            If (value200 = 0) Then
                txtOp200.Text = value200
            End If
        End If

    End Sub
End Class