Public Class Form1
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        lblTitle.Visible = False
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblTitle.Visible = True
    End Sub

    Private Sub btnInvert_Click(sender As Object, e As EventArgs) Handles btnInvert.Click
        If lblTitle.Visible = True Then
            lblTitle.Visible = False
        Else
            lblTitle.Visible = True
        End If
    End Sub

    Private Sub btnBoldOff_Click(sender As Object, e As EventArgs) Handles btnBoldOff.Click
        If lblTitle.Font.Bold = True Then
            lblTitle.Font = New Font(lblTitle.Font, lblTitle.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub btnColorBlack_Click(sender As Object, e As EventArgs) Handles btnColorBlack.Click
        lblTitle.ForeColor = Color.Black
    End Sub

    Private Sub btnColorBlue_Click(sender As Object, e As EventArgs) Handles btnColorBlue.Click
        lblTitle.ForeColor = Color.Blue
    End Sub

    Private Sub btnItalicOn_Click(sender As Object, e As EventArgs) Handles btnItalicOn.Click
        lblTitle.Font = New Font(lblTitle.Font, lblTitle.Font.Style Or FontStyle.Italic)
    End Sub

    Private Sub btnItalicOff_Click(sender As Object, e As EventArgs) Handles btnItalicOff.Click
        lblTitle.Font = New Font(lblTitle.Font, lblTitle.Font.Style And Not FontStyle.Italic)
    End Sub

    Private Sub btnUnderlineOn_Click(sender As Object, e As EventArgs) Handles btnUnderlineOn.Click
        lblTitle.Font = New Font(lblTitle.Font, lblTitle.Font.Style Or FontStyle.Underline)
    End Sub

    Private Sub btnUnderlineOff_Click(sender As Object, e As EventArgs) Handles btnUnderlineOff.Click
        lblTitle.Font = New Font(lblTitle.Font, lblTitle.Font.Style And Not FontStyle.Underline)
    End Sub

    Private Sub btnColorBrown_Click(sender As Object, e As EventArgs) Handles btnColorBrown.Click
        lblTitle.ForeColor = Color.Brown
    End Sub

    Private Sub btnColorAquamarine_Click(sender As Object, e As EventArgs) Handles btnColorAquamarine.Click
        lblTitle.ForeColor = Color.Aquamarine
    End Sub

    Private Sub btnBoldOn_Click(sender As Object, e As EventArgs) Handles btnBoldOn.Click
        lblTitle.Font = New Font(lblTitle.Font, lblTitle.Font.Style Or FontStyle.Bold)
    End Sub
End Class
