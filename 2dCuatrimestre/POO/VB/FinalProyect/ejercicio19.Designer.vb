<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio19
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
        btnCalculate = New Button()
        lblOutput = New Label()
        txtInputYearsOld = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnCalculate)
        GroupBox1.Controls.Add(lblOutput)
        GroupBox1.Controls.Add(txtInputYearsOld)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(225, 144)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Edad"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(121, 115)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Calcular"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblOutput
        ' 
        lblOutput.AutoSize = True
        lblOutput.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOutput.Location = New Point(6, 66)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(0, 25)
        lblOutput.TabIndex = 1
        ' 
        ' txtInputYearsOld
        ' 
        txtInputYearsOld.Location = New Point(98, 22)
        txtInputYearsOld.Name = "txtInputYearsOld"
        txtInputYearsOld.Size = New Size(121, 23)
        txtInputYearsOld.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 3
        Label1.Text = "Ingrese su edad:"
        ' 
        ' ejercicio19
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(249, 165)
        Controls.Add(GroupBox1)
        Name = "ejercicio19"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 19"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtInputYearsOld As TextBox
    Friend WithEvents Label1 As Label
End Class
