<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio23
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
        lblResultado = New Label()
        txtDia = New TextBox()
        txtMes = New TextBox()
        txtAño = New TextBox()
        btnMostrar = New Button()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 0
        Label1.Text = "DIA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 1
        Label2.Text = "MES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 2
        Label3.Text = "AÑO"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(47, 129)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(17, 15)
        lblResultado.TabIndex = 3
        lblResultado.Text = """"""
        ' 
        ' txtDia
        ' 
        txtDia.Location = New Point(94, 12)
        txtDia.Name = "txtDia"
        txtDia.Size = New Size(100, 23)
        txtDia.TabIndex = 4
        ' 
        ' txtMes
        ' 
        txtMes.Location = New Point(94, 43)
        txtMes.Name = "txtMes"
        txtMes.Size = New Size(100, 23)
        txtMes.TabIndex = 5
        ' 
        ' txtAño
        ' 
        txtAño.Location = New Point(94, 74)
        txtAño.Name = "txtAño"
        txtAño.Size = New Size(100, 23)
        txtAño.TabIndex = 6
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Location = New Point(202, 27)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(125, 23)
        btnMostrar.TabIndex = 7
        btnMostrar.Text = "MOSTRAR FECHA"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(227, 74)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 8
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' ejercicio23
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 164)
        Controls.Add(btnSalir)
        Controls.Add(btnMostrar)
        Controls.Add(txtAño)
        Controls.Add(txtMes)
        Controls.Add(txtDia)
        Controls.Add(lblResultado)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ejercicio23"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 23"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtDia As TextBox
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnSalir As Button
End Class
