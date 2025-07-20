Public Class Ingresos
    Public number As Integer
    Public errCount As Integer
    Private Sub BtnAddOne_Click(sender As Object, e As EventArgs) Handles BtnAddOne.Click
        number = Val(TxTnumber.Text)
        number = number + 1
        TxTnumber.Text = number
    End Sub
    Private Sub Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errCount = 0
        Dim user As String = "root"
        Dim password As String = "root"

        Dim userInput = InputBox("Ingrese su usuario: ")
        Dim passwordInput = ""

        If user = userInput Then
            passwordInput = InputBox("Ingrese su contraseña: ")
            While (passwordInput <> password)
                MessageBox.Show("Error en usuario o contraseña")
                errCount = errCount + 1
                If errCount > 3 Then
                    TxTnumber.Enabled = False
                    BtnAddOne.Enabled = False
                    Return
                End If
                passwordInput = InputBox("Ingrese su contraseña: ")
            End While
        Else
            MessageBox.Show("Error en usuario o contraseña")
            Me.Close()
        End If
    End Sub
End Class