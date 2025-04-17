<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio32
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblResultado = New Label()
        txtNumero = New TextBox()
        btnCalcular = New Button()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 30)
        Label1.TabIndex = 0
        Label1.Text = "INGRESA CUALQUIER NUMERO" & vbCrLf & "PARA SACAR SU DERIVACION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(12, 68)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(17, 15)
        lblResultado.TabIndex = 1
        lblResultado.Text = """"""
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(12, 42)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(100, 23)
        txtNumero.TabIndex = 2
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(118, 42)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(75, 23)
        btnCalcular.TabIndex = 3
        btnCalcular.Text = "CALCULAR"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(199, 42)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 4
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' ejercicio32
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(286, 95)
        Controls.Add(btnSalir)
        Controls.Add(btnCalcular)
        Controls.Add(txtNumero)
        Controls.Add(lblResultado)
        Controls.Add(Label1)
        Name = "ejercicio32"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 32"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
End Class
