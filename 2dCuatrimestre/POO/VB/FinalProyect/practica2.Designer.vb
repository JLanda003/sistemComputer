<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practica2
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
        lblSaludo = New Label()
        txtNombre = New TextBox()
        btnSaludo = New Button()
        lblBienvenida = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(87, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 15)
        Label1.TabIndex = 0
        Label1.Text = "¿CUAL ES TU NOMBRE ESTIMAD@?"
        ' 
        ' lblSaludo
        ' 
        lblSaludo.AutoSize = True
        lblSaludo.Location = New Point(3, 47)
        lblSaludo.Name = "lblSaludo"
        lblSaludo.Size = New Size(17, 15)
        lblSaludo.TabIndex = 1
        lblSaludo.Text = """"""
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(74, 18)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(219, 23)
        txtNombre.TabIndex = 2
        ' 
        ' btnSaludo
        ' 
        btnSaludo.Location = New Point(146, 84)
        btnSaludo.Name = "btnSaludo"
        btnSaludo.Size = New Size(75, 23)
        btnSaludo.TabIndex = 3
        btnSaludo.Text = "ENVIAR"
        btnSaludo.UseVisualStyleBackColor = True
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.AutoSize = True
        lblBienvenida.Location = New Point(3, 62)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(0, 15)
        lblBienvenida.TabIndex = 4
        ' 
        ' practica2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(366, 119)
        Controls.Add(lblBienvenida)
        Controls.Add(btnSaludo)
        Controls.Add(txtNombre)
        Controls.Add(lblSaludo)
        Controls.Add(Label1)
        Name = "practica2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Practica 2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblSaludo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnSaludo As Button
    Friend WithEvents lblBienvenida As Label
End Class
