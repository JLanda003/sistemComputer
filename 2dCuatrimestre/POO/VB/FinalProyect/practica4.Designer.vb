<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practica4
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
        txtInputSquare = New TextBox()
        GroupBox1 = New GroupBox()
        btnClearSquare = New Button()
        btnCalSquare = New Button()
        lblResult = New Label()
        txtResult = New TextBox()
        GroupBox2 = New GroupBox()
        btnClearRectangle = New Button()
        btnCalRectangle = New Button()
        txtInputRectangle2 = New TextBox()
        txtInputRectangle1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox3 = New GroupBox()
        btnTriangle = New Button()
        btnCalTriangle = New Button()
        txtInputTriangle2 = New TextBox()
        txtInputTriangle1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 0
        Label1.Text = "Lado:"
        ' 
        ' txtInputSquare
        ' 
        txtInputSquare.Location = New Point(93, 31)
        txtInputSquare.Name = "txtInputSquare"
        txtInputSquare.Size = New Size(116, 23)
        txtInputSquare.TabIndex = 1
        txtInputSquare.Text = "0"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnClearSquare)
        GroupBox1.Controls.Add(btnCalSquare)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtInputSquare)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(299, 95)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Area del cuadrado"
        ' 
        ' btnClearSquare
        ' 
        btnClearSquare.Location = New Point(215, 60)
        btnClearSquare.Name = "btnClearSquare"
        btnClearSquare.Size = New Size(66, 23)
        btnClearSquare.TabIndex = 3
        btnClearSquare.Text = "Limpiar"
        btnClearSquare.UseVisualStyleBackColor = True
        ' 
        ' btnCalSquare
        ' 
        btnCalSquare.BackColor = Color.SteelBlue
        btnCalSquare.ForeColor = SystemColors.Control
        btnCalSquare.Location = New Point(215, 31)
        btnCalSquare.Name = "btnCalSquare"
        btnCalSquare.Size = New Size(66, 23)
        btnCalSquare.TabIndex = 2
        btnCalSquare.Text = "Calcular"
        btnCalSquare.UseVisualStyleBackColor = False
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(14, 396)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(82, 21)
        lblResult.TabIndex = 3
        lblResult.Text = "Resultado:"
        ' 
        ' txtResult
        ' 
        txtResult.Enabled = False
        txtResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtResult.Location = New Point(105, 394)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(206, 29)
        txtResult.TabIndex = 4
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnClearRectangle)
        GroupBox2.Controls.Add(btnCalRectangle)
        GroupBox2.Controls.Add(txtInputRectangle2)
        GroupBox2.Controls.Add(txtInputRectangle1)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(12, 113)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(299, 137)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Area de un rectangulo"
        ' 
        ' btnClearRectangle
        ' 
        btnClearRectangle.Location = New Point(215, 84)
        btnClearRectangle.Name = "btnClearRectangle"
        btnClearRectangle.Size = New Size(66, 23)
        btnClearRectangle.TabIndex = 4
        btnClearRectangle.Text = "Limpiar"
        btnClearRectangle.UseVisualStyleBackColor = True
        ' 
        ' btnCalRectangle
        ' 
        btnCalRectangle.BackColor = Color.Maroon
        btnCalRectangle.ForeColor = SystemColors.Control
        btnCalRectangle.Location = New Point(215, 39)
        btnCalRectangle.Name = "btnCalRectangle"
        btnCalRectangle.Size = New Size(66, 23)
        btnCalRectangle.TabIndex = 6
        btnCalRectangle.Text = "Calcular"
        btnCalRectangle.UseVisualStyleBackColor = False
        ' 
        ' txtInputRectangle2
        ' 
        txtInputRectangle2.Location = New Point(93, 84)
        txtInputRectangle2.Name = "txtInputRectangle2"
        txtInputRectangle2.Size = New Size(116, 23)
        txtInputRectangle2.TabIndex = 3
        txtInputRectangle2.Text = "0"
        ' 
        ' txtInputRectangle1
        ' 
        txtInputRectangle1.Location = New Point(93, 39)
        txtInputRectangle1.Name = "txtInputRectangle1"
        txtInputRectangle1.Size = New Size(116, 23)
        txtInputRectangle1.TabIndex = 2
        txtInputRectangle1.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 1
        Label4.Text = "Altura:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 0
        Label3.Text = "Base:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnTriangle)
        GroupBox3.Controls.Add(btnCalTriangle)
        GroupBox3.Controls.Add(txtInputTriangle2)
        GroupBox3.Controls.Add(txtInputTriangle1)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Location = New Point(14, 256)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(297, 119)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Area de un rectangulo"
        ' 
        ' btnTriangle
        ' 
        btnTriangle.Location = New Point(213, 77)
        btnTriangle.Name = "btnTriangle"
        btnTriangle.Size = New Size(66, 23)
        btnTriangle.TabIndex = 7
        btnTriangle.Text = "Limpiar"
        btnTriangle.UseVisualStyleBackColor = True
        ' 
        ' btnCalTriangle
        ' 
        btnCalTriangle.BackColor = Color.DarkGreen
        btnCalTriangle.ForeColor = SystemColors.Control
        btnCalTriangle.Location = New Point(213, 34)
        btnCalTriangle.Name = "btnCalTriangle"
        btnCalTriangle.Size = New Size(66, 23)
        btnCalTriangle.TabIndex = 6
        btnCalTriangle.Text = "Calcular"
        btnCalTriangle.UseVisualStyleBackColor = False
        ' 
        ' txtInputTriangle2
        ' 
        txtInputTriangle2.Location = New Point(91, 77)
        txtInputTriangle2.Name = "txtInputTriangle2"
        txtInputTriangle2.Size = New Size(116, 23)
        txtInputTriangle2.TabIndex = 4
        txtInputTriangle2.Text = "0"
        ' 
        ' txtInputTriangle1
        ' 
        txtInputTriangle1.Location = New Point(91, 34)
        txtInputTriangle1.Name = "txtInputTriangle1"
        txtInputTriangle1.Size = New Size(116, 23)
        txtInputTriangle1.TabIndex = 3
        txtInputTriangle1.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(36, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 1
        Label7.Text = "Altura:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(44, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 0
        Label6.Text = "Base:"
        ' 
        ' practica4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 438)
        Controls.Add(txtResult)
        Controls.Add(GroupBox3)
        Controls.Add(lblResult)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "practica4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Practica 4"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInputSquare As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalSquare As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalRectangle As Button
    Friend WithEvents txtInputRectangle2 As TextBox
    Friend WithEvents txtInputRectangle1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalTriangle As Button
    Friend WithEvents txtInputTriangle2 As TextBox
    Friend WithEvents txtInputTriangle1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClearSquare As Button
    Friend WithEvents btnClearRectangle As Button
    Friend WithEvents btnTriangle As Button
End Class
