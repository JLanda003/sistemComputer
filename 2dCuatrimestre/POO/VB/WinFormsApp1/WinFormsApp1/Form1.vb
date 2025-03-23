Public Class Form1
    Private Sub btnSizePlus_Click(sender As Object, e As EventArgs) Handles btnSizePlusbtnSizePlus.Click
        Dim currentFont As Font = lblTest.Font
        Dim newSize As Single = currentFont.Size + 1

        lblTest.Font = New Font(currentFont.FontFamily, newSize, currentFont.Style)
    End Sub

    Private Sub btnSizeMinimum_Click(sender As Object, e As EventArgs) Handles btnSizeMinimum.Click
        Dim currentFont As Font = lblTest.Font
        Dim newSize As Single = Math.Max(1, currentFont.Size - 1)

        lblTest.Font = New Font(currentFont.FontFamily, newSize, currentFont.Style)
    End Sub

    Private Sub btnColorChange_Click(sender As Object, e As EventArgs) Handles btnColorChange.Click
        Dim colorChange As New ColorDialog()

        colorChange.Color = lblTest.ForeColor

        If (colorChange.ShowDialog() = DialogResult.OK) Then
            lblTest.ForeColor = colorChange.Color
        End If
    End Sub

    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click
        Dim currentFont As Font = lblTest.Font

        If lblTest.Font.Bold = False Then
            lblTest.Font = New Font(currentFont.FontFamily, FontStyle.Bold)
        Else
            lblTest.Font = New Font(currentFont.FontFamily, FontStyle.Regular)
        End If
    End Sub
End Class
