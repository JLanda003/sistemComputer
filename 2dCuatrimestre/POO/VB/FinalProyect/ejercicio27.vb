Public Class ejercicio27
    Private Sub ejercicio27_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializamos el ramdom para que siempre sea diferente
        Randomize()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'Limpiamos los Items de la lista
        lbDice.Items.Clear()
        'Creamos el ciclo que se inica en 1 y finalizara
        'en el valor obtenido del TextBox de tiros
        For count = 1 To Integer.Parse(txtRollNum.Text)
            lbDice.Items.Add("Tiro: " & count & " Val: " & Int((6 * Rnd()) + 1))
        Next count
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Boton de cierre de la ventana
        Me.Close()
    End Sub
End Class