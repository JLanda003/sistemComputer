<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormYears
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
        Label1 = New Label()
        Label2 = New Label()
        txtInput = New TextBox()
        txtOutput = New TextBox()
        btnValue = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(12, 133)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(126, 29)
        btnReturn.TabIndex = 0
        btnReturn.Text = "Regresar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 1
        Label1.Text = "Edad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(322, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 20)
        Label2.TabIndex = 2
        Label2.Text = "¿Es mayor de edad?"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(90, 37)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(197, 27)
        txtInput.TabIndex = 3
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(470, 37)
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(147, 27)
        txtOutput.TabIndex = 4
        ' 
        ' btnValue
        ' 
        btnValue.Location = New Point(153, 133)
        btnValue.Name = "btnValue"
        btnValue.Size = New Size(118, 29)
        btnValue.TabIndex = 5
        btnValue.Text = "Valuar"
        btnValue.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(307, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(211, 20)
        Label3.TabIndex = 6
        Label3.Text = "Valuación de mayoria de edad"
        ' 
        ' FormYears
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(636, 178)
        Controls.Add(Label3)
        Controls.Add(btnValue)
        Controls.Add(txtOutput)
        Controls.Add(txtInput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReturn)
        Name = "FormYears"
        Text = "FormYears"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnValue As Button
    Friend WithEvents Label3 As Label
End Class
