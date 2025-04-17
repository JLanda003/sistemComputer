<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio18
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
        lblEdad = New Label()
        lblMayorEdad = New Label()
        dtpFechaNacimiento = New DateTimePicker()
        btnCalcular = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 15)
        Label1.TabIndex = 0
        Label1.Text = "INTRODUCE TU FECHA DE NACIMIENTO"
        ' 
        ' lblEdad
        ' 
        lblEdad.AutoSize = True
        lblEdad.Location = New Point(12, 63)
        lblEdad.Name = "lblEdad"
        lblEdad.Size = New Size(17, 15)
        lblEdad.TabIndex = 1
        lblEdad.Text = """"""
        ' 
        ' lblMayorEdad
        ' 
        lblMayorEdad.AutoSize = True
        lblMayorEdad.Location = New Point(259, 64)
        lblMayorEdad.Name = "lblMayorEdad"
        lblMayorEdad.Size = New Size(17, 15)
        lblMayorEdad.TabIndex = 2
        lblMayorEdad.Text = """"""
        ' 
        ' dtpFechaNacimiento
        ' 
        dtpFechaNacimiento.Location = New Point(12, 27)
        dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        dtpFechaNacimiento.Size = New Size(200, 23)
        dtpFechaNacimiento.TabIndex = 3
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(218, 27)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(213, 23)
        btnCalcular.TabIndex = 4
        btnCalcular.Text = "¿ERES LEGAL O AUN ESTAS POLLO?"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' ejercicio18
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 105)
        Controls.Add(btnCalcular)
        Controls.Add(dtpFechaNacimiento)
        Controls.Add(lblMayorEdad)
        Controls.Add(lblEdad)
        Controls.Add(Label1)
        Name = "ejercicio18"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 18"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblMayorEdad As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents btnCalcular As Button
End Class
