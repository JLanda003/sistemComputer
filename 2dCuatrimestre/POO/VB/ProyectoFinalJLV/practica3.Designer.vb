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
        btnConvert = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtOMinutes = New TextBox()
        txtOSeconds = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(113, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 20)
        Label1.TabIndex = 0
        Label1.Text = "NUMERO DE HORAS"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(266, 67)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(161, 27)
        txtInput.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(454, 67)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convertir"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(113, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 3
        Label2.Text = "MINUTOS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(376, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 4
        Label3.Text = "SEGUNDOS"
        ' 
        ' txtOMinutes
        ' 
        txtOMinutes.Location = New Point(192, 189)
        txtOMinutes.Name = "txtOMinutes"
        txtOMinutes.Size = New Size(151, 27)
        txtOMinutes.TabIndex = 5
        ' 
        ' txtOSeconds
        ' 
        txtOSeconds.Location = New Point(468, 189)
        txtOSeconds.Name = "txtOSeconds"
        txtOSeconds.Size = New Size(151, 27)
        txtOSeconds.TabIndex = 6
        ' 
        ' practica3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtOSeconds)
        Controls.Add(txtOMinutes)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnConvert)
        Controls.Add(txtInput)
        Controls.Add(Label1)
        Name = "practica3"
        Text = "practica3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOMinutes As TextBox
    Friend WithEvents txtOSeconds As TextBox
End Class
