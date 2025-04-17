<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio30
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 30)
        Label1.TabIndex = 0
        Label1.Text = "ESCRIBE CUALQUIER NUMERO PARA CALCULAR" & vbCrLf & "LA TABLA DE MULTIPLICAR DESEADA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(12, 79)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(17, 15)
        lblResultado.TabIndex = 1
        lblResultado.Text = """"""
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(12, 53)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(100, 23)
        txtNumero.TabIndex = 2
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(118, 52)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(132, 23)
        btnCalcular.TabIndex = 3
        btnCalcular.Text = "CALCULAR TABLA"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' ejercicio30
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(296, 122)
        Controls.Add(btnCalcular)
        Controls.Add(txtNumero)
        Controls.Add(lblResultado)
        Controls.Add(Label1)
        Name = "ejercicio30"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 30"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents btnCalcular As Button
End Class
