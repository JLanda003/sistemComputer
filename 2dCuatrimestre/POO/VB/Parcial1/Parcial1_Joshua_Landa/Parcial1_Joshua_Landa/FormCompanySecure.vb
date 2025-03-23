Public Class FormCompanySecure
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (cbxPlanA.Checked = True) Then
            txtValueBase.Text = 50000
            txtValueTotal.Text = txtValueBase.Text

            txtValueTotal.Text = (Convert.ToDouble(txtValueBase.Text) * 0.1 + Convert.ToDouble(txtValueTotal.Text)).ToString()
        End If
        If (cbxPlanB.Checked = True) Then
            txtValueBase.Text = 25000
            txtValueTotal.Text = txtValueBase.Text

            txtValueTotal.Text = (Convert.ToDouble(txtValueBase.Text) * 0.1 + Convert.ToDouble(txtValueTotal.Text)).ToString()
        End If

        If (cbxAlchol.Checked = True) Then
            txtValueTotal.Text = (Convert.ToDouble(txtValueBase.Text) * 0.1 + Convert.ToDouble(txtValueTotal.Text)).ToString()
        End If
        If (cbxGlass.Checked = True) Then
            txtValueTotal.Text = (Convert.ToDouble(txtValueBase.Text) * 0.05 + Convert.ToDouble(txtValueTotal.Text)).ToString()
        End If
        If (cbxSick.Checked = True) Then
            txtValueTotal.Text = (Convert.ToDouble(txtValueBase.Text) * 0.05 + Convert.ToDouble(txtValueTotal.Text)).ToString()
        End If
        If (cbxMore40.Checked = True) Then
            txtValueTotal.Text = (Convert.ToDouble(txtValueBase.Text) * 0.4 + Convert.ToDouble(txtValueTotal.Text)).ToString()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cbxPlanA.Checked = False
        cbxPlanA.Enabled = True
        cbxPlanB.Checked = False
        cbxPlanB.Enabled = True
        cbxAlchol.Checked = False
        cbxGlass.Checked = False
        cbxSick.Checked = False
        cbxMore40.Checked = False
        txtValueBase.Text = ""
        txtValueTotal.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cbxPlanA_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPlanA.CheckedChanged
        If (cbxPlanA.Checked = True) Then
            cbxPlanB.Enabled = False
        Else
            cbxPlanB.Enabled = True
        End If
    End Sub

    Private Sub cbxPlanB_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPlanB.CheckedChanged
        If (cbxPlanB.Checked = True) Then
            cbxPlanA.Enabled = False
        Else
            cbxPlanA.Enabled = True
        End If
    End Sub
End Class