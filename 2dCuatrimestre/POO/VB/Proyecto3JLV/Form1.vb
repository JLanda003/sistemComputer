Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Empieza el programa")
        Dim Name As String 'Inicio mi variable nombre de tipo cadena o string
        Dim Password As String = "pass123"
        Dim PassInput As String
        Name = InputBox("Escribe tu nombre")
        MessageBox.Show("El nombre del usuario es: " & Name, "Bienvenido")
        PassInput = InputBox("Ingrese la contraseña 'pass123'")
        If (PassInput = Password) Then
            MessageBox.Show("La contraseña es correcta: ")
        Else
            MessageBox.Show("La contraseña es incorrecta: ")
            Me.Close()
        End If
    End Sub
End Class