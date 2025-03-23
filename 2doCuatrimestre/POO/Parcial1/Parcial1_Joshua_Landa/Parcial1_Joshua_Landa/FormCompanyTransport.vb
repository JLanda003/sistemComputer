Public Class FormCompanyTransport
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        If (txtInput.Text < 48) Then
            txtFalt.Text = (48 - txtInput.Text).ToString
        End If
        If (txtInput.Text > 48) Then
            txtExt.Text = ((txtInput.Text - 48) * (50 * 0.25)).ToString
        End If

        txtTotal.Text = Convert.ToUInt32(txtInput.Text) * 50 + Convert.ToUInt32(txtExt.Text)

    End Sub
End Class