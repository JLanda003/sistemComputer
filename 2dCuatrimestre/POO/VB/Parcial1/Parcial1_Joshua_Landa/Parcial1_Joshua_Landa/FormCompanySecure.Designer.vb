<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompanySecure
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
        Button5 = New Button()
        Button6 = New Button()
        cbxAlchol = New CheckBox()
        cbxGlass = New CheckBox()
        cbxSick = New CheckBox()
        cbxMore40 = New CheckBox()
        cbxPlanA = New CheckBox()
        cbxPlanB = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        txtValueBase = New TextBox()
        txtValueTotal = New TextBox()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(16, 409)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(124, 29)
        btnReturn.TabIndex = 0
        btnReturn.Text = "Regresar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(16, 409)
        Button5.Name = "Button5"
        Button5.Size = New Size(124, 29)
        Button5.TabIndex = 0
        Button5.Text = "Regresar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(192, 409)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 1
        Button6.Text = "Calcular"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' cbxAlchol
        ' 
        cbxAlchol.AutoSize = True
        cbxAlchol.Location = New Point(38, 97)
        cbxAlchol.Name = "cbxAlchol"
        cbxAlchol.Size = New Size(105, 24)
        cbxAlchol.TabIndex = 8
        cbxAlchol.Text = "Alchol 10%"
        cbxAlchol.UseVisualStyleBackColor = True
        ' 
        ' cbxGlass
        ' 
        cbxGlass.AutoSize = True
        cbxGlass.Location = New Point(38, 151)
        cbxGlass.Name = "cbxGlass"
        cbxGlass.Size = New Size(97, 24)
        cbxGlass.TabIndex = 9
        cbxGlass.Text = "Lentes 5%"
        cbxGlass.UseVisualStyleBackColor = True
        ' 
        ' cbxSick
        ' 
        cbxSick.AutoSize = True
        cbxSick.Location = New Point(38, 206)
        cbxSick.Name = "cbxSick"
        cbxSick.Size = New Size(136, 24)
        cbxSick.TabIndex = 10
        cbxSick.Text = "Enfermedad 5%"
        cbxSick.UseVisualStyleBackColor = True
        ' 
        ' cbxMore40
        ' 
        cbxMore40.AutoSize = True
        cbxMore40.Location = New Point(38, 262)
        cbxMore40.Name = "cbxMore40"
        cbxMore40.Size = New Size(166, 24)
        cbxMore40.TabIndex = 11
        cbxMore40.Text = "Más de 40 años 20%"
        cbxMore40.UseVisualStyleBackColor = True
        ' 
        ' cbxPlanA
        ' 
        cbxPlanA.AutoSize = True
        cbxPlanA.Location = New Point(38, 30)
        cbxPlanA.Name = "cbxPlanA"
        cbxPlanA.Size = New Size(120, 24)
        cbxPlanA.TabIndex = 12
        cbxPlanA.Text = "Plan A 50,000"
        cbxPlanA.UseVisualStyleBackColor = True
        ' 
        ' cbxPlanB
        ' 
        cbxPlanB.AutoSize = True
        cbxPlanB.Location = New Point(192, 30)
        cbxPlanB.Name = "cbxPlanB"
        cbxPlanB.Size = New Size(119, 24)
        cbxPlanB.TabIndex = 13
        cbxPlanB.Text = "Plan B 25,000"
        cbxPlanB.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(369, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 14
        Label1.Text = "Valor Base"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(402, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 15
        Label2.Text = "Total:"
        ' 
        ' txtValueBase
        ' 
        txtValueBase.Location = New Point(468, 131)
        txtValueBase.Name = "txtValueBase"
        txtValueBase.Size = New Size(184, 27)
        txtValueBase.TabIndex = 16
        ' 
        ' txtValueTotal
        ' 
        txtValueTotal.Location = New Point(468, 191)
        txtValueTotal.Name = "txtValueTotal"
        txtValueTotal.Size = New Size(184, 27)
        txtValueTotal.TabIndex = 17
        ' 
        ' FormCompanySecure
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtValueTotal)
        Controls.Add(txtValueBase)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbxPlanB)
        Controls.Add(cbxPlanA)
        Controls.Add(cbxMore40)
        Controls.Add(cbxSick)
        Controls.Add(cbxGlass)
        Controls.Add(cbxAlchol)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(btnReturn)
        Name = "FormCompanySecure"
        Text = "FormCompanySecure"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cbxAlchol As CheckBox
    Friend WithEvents cbxGlass As CheckBox
    Friend WithEvents cbxSick As CheckBox
    Friend WithEvents cbxMore40 As CheckBox
    Friend WithEvents cbxPlanA As CheckBox
    Friend WithEvents cbxPlanB As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValueBase As TextBox
    Friend WithEvents txtValueTotal As TextBox
End Class
