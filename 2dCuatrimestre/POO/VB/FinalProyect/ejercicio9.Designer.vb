<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio9
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
        txtResultado = New TextBox()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnClear = New Button()
        btn0 = New Button()
        btnIgual = New Button()
        btnSuma = New Button()
        btnResta = New Button()
        btnMultiplicacion = New Button()
        btnDivision = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 39)
        Label1.TabIndex = 0
        Label1.Text = "INSERTE CUALQUIER NUMERO" & vbCrLf & "PARA HACER LA OPERACION" & vbCrLf & "DESEADA"
        ' 
        ' txtResultado
        ' 
        txtResultado.Enabled = False
        txtResultado.Location = New Point(38, 12)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(153, 23)
        txtResultado.TabIndex = 1
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(6, 22)
        btn1.Name = "btn1"
        btn1.Size = New Size(30, 30)
        btn1.TabIndex = 2
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(42, 22)
        btn2.Name = "btn2"
        btn2.Size = New Size(30, 30)
        btn2.TabIndex = 3
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(78, 22)
        btn3.Name = "btn3"
        btn3.Size = New Size(30, 30)
        btn3.TabIndex = 4
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(6, 58)
        btn4.Name = "btn4"
        btn4.Size = New Size(30, 30)
        btn4.TabIndex = 5
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(42, 58)
        btn5.Name = "btn5"
        btn5.Size = New Size(30, 30)
        btn5.TabIndex = 6
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(78, 58)
        btn6.Name = "btn6"
        btn6.Size = New Size(30, 30)
        btn6.TabIndex = 7
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(6, 94)
        btn7.Name = "btn7"
        btn7.Size = New Size(30, 30)
        btn7.TabIndex = 8
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(42, 94)
        btn8.Name = "btn8"
        btn8.Size = New Size(30, 30)
        btn8.TabIndex = 9
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(78, 94)
        btn9.Name = "btn9"
        btn9.Size = New Size(30, 30)
        btn9.TabIndex = 10
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(44, 182)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(30, 30)
        btnClear.TabIndex = 11
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(80, 182)
        btn0.Name = "btn0"
        btn0.Size = New Size(30, 30)
        btn0.TabIndex = 12
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnIgual
        ' 
        btnIgual.Location = New Point(116, 182)
        btnIgual.Name = "btnIgual"
        btnIgual.Size = New Size(30, 30)
        btnIgual.TabIndex = 13
        btnIgual.Text = "="
        btnIgual.UseVisualStyleBackColor = True
        ' 
        ' btnSuma
        ' 
        btnSuma.Location = New Point(161, 50)
        btnSuma.Name = "btnSuma"
        btnSuma.Size = New Size(30, 30)
        btnSuma.TabIndex = 14
        btnSuma.Text = "+"
        btnSuma.UseVisualStyleBackColor = True
        ' 
        ' btnResta
        ' 
        btnResta.Location = New Point(161, 80)
        btnResta.Name = "btnResta"
        btnResta.Size = New Size(30, 30)
        btnResta.TabIndex = 15
        btnResta.Text = "-"
        btnResta.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplicacion
        ' 
        btnMultiplicacion.Location = New Point(161, 110)
        btnMultiplicacion.Name = "btnMultiplicacion"
        btnMultiplicacion.Size = New Size(30, 30)
        btnMultiplicacion.TabIndex = 16
        btnMultiplicacion.Text = "*"
        btnMultiplicacion.UseVisualStyleBackColor = True
        ' 
        ' btnDivision
        ' 
        btnDivision.Location = New Point(161, 140)
        btnDivision.Name = "btnDivision"
        btnDivision.Size = New Size(30, 30)
        btnDivision.TabIndex = 17
        btnDivision.Text = "/"
        btnDivision.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn1)
        GroupBox1.Controls.Add(btn2)
        GroupBox1.Controls.Add(btn3)
        GroupBox1.Controls.Add(btn4)
        GroupBox1.Controls.Add(btn5)
        GroupBox1.Controls.Add(btn6)
        GroupBox1.Controls.Add(btn7)
        GroupBox1.Controls.Add(btn8)
        GroupBox1.Controls.Add(btn9)
        GroupBox1.Location = New Point(38, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(117, 135)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(28, 218)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(174, 67)
        GroupBox2.TabIndex = 19
        GroupBox2.TabStop = False
        GroupBox2.Text = "Nota"
        ' 
        ' ejercicio9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(229, 301)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnDivision)
        Controls.Add(btnMultiplicacion)
        Controls.Add(btnResta)
        Controls.Add(btnSuma)
        Controls.Add(btnIgual)
        Controls.Add(txtResultado)
        Controls.Add(btn0)
        Controls.Add(btnClear)
        Name = "ejercicio9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 9"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
