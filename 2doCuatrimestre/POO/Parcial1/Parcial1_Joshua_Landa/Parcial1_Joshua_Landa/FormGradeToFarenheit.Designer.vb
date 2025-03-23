<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGradeToFarenheit
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
        btnReturn = New Button()
        txtInput = New TextBox()
        txtOutput = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnConvert = New Button()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(12, 96)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(127, 29)
        btnReturn.TabIndex = 0
        btnReturn.Text = "Regresar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(103, 12)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(171, 27)
        txtInput.TabIndex = 1
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(387, 12)
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(177, 27)
        txtOutput.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 3
        Label1.Text = "Celsius"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(312, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 4
        Label2.Text = "Farenheit"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(280, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(284, 20)
        Label3.TabIndex = 5
        Label3.Text = "Convertidor de Grados Celsius a Farenheit"
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(180, 96)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 6
        btnConvert.Text = "Convertir"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' FormGradeToFarenheit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(592, 145)
        Controls.Add(btnConvert)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtOutput)
        Controls.Add(txtInput)
        Controls.Add(btnReturn)
        Name = "FormGradeToFarenheit"
        Text = "FormGradeToFarenheit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConvert As Button
End Class
