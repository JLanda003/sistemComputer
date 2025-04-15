<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practica6
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        txtInputValue = New TextBox()
        GroupBox2 = New GroupBox()
        txtOp200 = New TextBox()
        txtOp100 = New TextBox()
        txtOp50 = New TextBox()
        txtOp20 = New TextBox()
        txtOp10 = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cantidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 1
        Label2.Text = "S/. 10"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 2
        Label3.Text = "S/. 20"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 3
        Label4.Text = "S/. 50"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 4
        Label5.Text = "S/. 100"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 5
        Label6.Text = "S/. 200"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtInputValue)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(215, 65)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Retiro"
        ' 
        ' txtInputValue
        ' 
        txtInputValue.Location = New Point(81, 22)
        txtInputValue.Name = "txtInputValue"
        txtInputValue.Size = New Size(100, 23)
        txtInputValue.TabIndex = 1
        txtInputValue.Text = "0"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtOp200)
        GroupBox2.Controls.Add(txtOp100)
        GroupBox2.Controls.Add(txtOp50)
        GroupBox2.Controls.Add(txtOp20)
        GroupBox2.Controls.Add(txtOp10)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(12, 83)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(215, 190)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Montos de billetes"
        ' 
        ' txtOp200
        ' 
        txtOp200.Enabled = False
        txtOp200.Location = New Point(81, 144)
        txtOp200.Name = "txtOp200"
        txtOp200.Size = New Size(100, 23)
        txtOp200.TabIndex = 10
        txtOp200.Text = "0"
        ' 
        ' txtOp100
        ' 
        txtOp100.Enabled = False
        txtOp100.Location = New Point(81, 115)
        txtOp100.Name = "txtOp100"
        txtOp100.Size = New Size(100, 23)
        txtOp100.TabIndex = 9
        txtOp100.Text = "0"
        ' 
        ' txtOp50
        ' 
        txtOp50.Enabled = False
        txtOp50.Location = New Point(81, 86)
        txtOp50.Name = "txtOp50"
        txtOp50.Size = New Size(100, 23)
        txtOp50.TabIndex = 8
        txtOp50.Text = "0"
        ' 
        ' txtOp20
        ' 
        txtOp20.Enabled = False
        txtOp20.Location = New Point(81, 57)
        txtOp20.Name = "txtOp20"
        txtOp20.Size = New Size(100, 23)
        txtOp20.TabIndex = 7
        txtOp20.Text = "0"
        ' 
        ' txtOp10
        ' 
        txtOp10.Enabled = False
        txtOp10.Location = New Point(81, 28)
        txtOp10.Name = "txtOp10"
        txtOp10.Size = New Size(100, 23)
        txtOp10.TabIndex = 6
        txtOp10.Text = "0"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(12, 279)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Aceptar"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(93, 279)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 9
        btnClear.Text = "Limpiar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(174, 279)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(53, 23)
        btnExit.TabIndex = 10
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' practica6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(239, 318)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "practica6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Practica 6"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtInputValue As TextBox
    Friend WithEvents txtOp200 As TextBox
    Friend WithEvents txtOp100 As TextBox
    Friend WithEvents txtOp50 As TextBox
    Friend WithEvents txtOp20 As TextBox
    Friend WithEvents txtOp10 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
