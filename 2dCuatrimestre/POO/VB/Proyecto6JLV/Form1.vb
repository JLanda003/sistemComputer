Public Class Form1
    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        Ingresos.Show()
        Egresos.Close()
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click
        Egresos.Show()
        Ingresos.Close()
    End Sub
End Class
