Public Class FrmConvert
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value As Int32 = 0
        Dim valueBin As Int32 = Convert.ToInt32(txtValueBin.Text)
        Dim valueDec As Int32 = 0

        While (valueBin > 0)
            Dim digit As Int32 = valueBin Mod 10
            valueBin = valueBin \ 10
            valueDec = valueDec + digit * (2 ^ value)
            value = value + 1
        End While

        txtValueDec.Text = valueDec
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Form1.Show()
        txtValueBin.Text = ""
        txtValueDec.Text = ""
    End Sub
End Class