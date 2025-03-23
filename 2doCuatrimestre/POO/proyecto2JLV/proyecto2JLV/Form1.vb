Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtResult.Text = Convert.ToInt32(txtValue1.Text) + Convert.ToInt32(txtValue2.Text)
    End Sub

    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        txtResult.Text = txtValue1.Text - txtValue2.Text
    End Sub

    Private Sub btnElev_Click(sender As Object, e As EventArgs) Handles btnElev.Click
        txtResult.Text = txtValue1.Text ^ txtValue2.Text
    End Sub

    Private Sub btnDiv1_Click(sender As Object, e As EventArgs) Handles btnDiv1.Click
        txtResult.Text = txtValue1.Text / txtValue2.Text
    End Sub

    Private Sub btnDiv2_Click(sender As Object, e As EventArgs) Handles btnDiv2.Click
        txtResult.Text = txtValue1.Text \ txtValue2.Text
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        txtResult.Text = txtValue1.Text Mod txtValue2.Text
    End Sub

    Private Sub btnBinToDec_Click(sender As Object, e As EventArgs) Handles btnBinToDec.Click
        Me.Hide()
        FrmConvert.Show()
        txtResult.Text = ""
        txtValue1.Text = ""
        txtValue2.Text = ""
    End Sub
End Class
