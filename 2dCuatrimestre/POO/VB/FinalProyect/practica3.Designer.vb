<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practica3
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
        txtInput = New TextBox()
        txtMinutes = New TextBox()
        txtSeconds = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btnConvert = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 0
        Label1.Text = "Numero de horas"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(124, 12)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(100, 23)
        txtInput.TabIndex = 1
        ' 
        ' txtMinutes
        ' 
        txtMinutes.Enabled = False
        txtMinutes.Location = New Point(124, 51)
        txtMinutes.Name = "txtMinutes"
        txtMinutes.Size = New Size(100, 23)
        txtMinutes.TabIndex = 2
        ' 
        ' txtSeconds
        ' 
        txtSeconds.Enabled = False
        txtSeconds.Location = New Point(124, 89)
        txtSeconds.Name = "txtSeconds"
        txtSeconds.Size = New Size(100, 23)
        txtSeconds.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 4
        Label2.Text = "Minutos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 5
        Label3.Text = "Segundos"
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(230, 12)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 6
        btnConvert.Text = "Convertir"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(230, 89)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 7
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' practica3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(350, 141)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtSeconds)
        Controls.Add(txtMinutes)
        Controls.Add(txtInput)
        Controls.Add(Label1)
        Name = "practica3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Practica 3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents txtSeconds As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
End Class
