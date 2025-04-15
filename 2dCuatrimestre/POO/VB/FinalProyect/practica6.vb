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

        value200 = inputValue \ 200
        inputValue = inputValue Mod 200

        value100 = inputValue \ 100
        inputValue = inputValue Mod 100

        value50 = inputValue \ 50
        inputValue = inputValue Mod 50

        value20 = inputValue \ 20
        inputValue = inputValue Mod 20

        value10 = inputValue \ 10
        inputValue = inputValue Mod 10

        txtOp200.Text = value200
        txtOp100.Text = value100
        txtOp50.Text = value50
        txtOp20.Text = value20
        txtOp10.Text = value10

    End Sub
End Class