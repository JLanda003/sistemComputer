<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practica8
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
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        txtInput = New TextBox()
        txtOutput = New TextBox()
        Label4 = New Label()
        txtCalculate = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(14, 82)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(280, 67)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Descuentos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(235, 15)
        Label2.TabIndex = 1
        Label2.Text = "*Se aplica 20% en consumo mayor a S/. 50"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 15)
        Label1.TabIndex = 0
        Label1.Text = "*Se aplica 10% en consumos de S/. 30 hasta S/. 50"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 1
        Label3.Text = "Consumo:"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(96, 12)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(198, 23)
        txtInput.TabIndex = 2
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(113, 53)
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(100, 23)
        txtOutput.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 15)
        Label4.TabIndex = 4
        Label4.Text = "Importe a pagar:"
        ' 
        ' txtCalculate
        ' 
        txtCalculate.Location = New Point(219, 53)
        txtCalculate.Name = "txtCalculate"
        txtCalculate.Size = New Size(75, 23)
        txtCalculate.TabIndex = 5
        txtCalculate.Text = "Calcular"
        txtCalculate.UseVisualStyleBackColor = True
        ' 
        ' practica8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(308, 158)
        Controls.Add(txtCalculate)
        Controls.Add(Label4)
        Controls.Add(txtOutput)
        Controls.Add(txtInput)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Name = "practica8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Practica 8"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCalculate As Button
End Class
