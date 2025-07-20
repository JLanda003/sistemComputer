Public Class Egresos
    Public number As Integer
    Public errCount As Integer
    Private Sub BtnDecrementOne_Click(sender As Object, e As EventArgs) Handles BtnDecrementOne.Click
        number = Val(TxtNumber.Text)
        number = number - 1
        TxtNumber.Text = number - 1
    End Sub

    Private Sub Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errCount = 0
        Dim user As String = "root"
        Dim password As String = "root"

        Dim userInput As String = InputBox("Ingrese su usuario: ")
        Dim passwordInput As String = ""


        If user = userInput Then
            passwordInput = InputBox("Ingrese su contraseña: ")
            While (passwordInput <> password)
                MessageBox.Show("Error en usuario o contraseña")
                errCount = errCount + 1
                If errCount > 3 Then
                    TxtNumber.Enabled = False
                    BtnDecrementOne.Enabled = False
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