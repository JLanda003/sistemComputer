<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio14
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
        btn1 = New Button()
        Label1 = New Label()
        lblCount = New Label()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(60, 40)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 23)
        btn1.TabIndex = 0
        btn1.Text = "Button1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(210, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 1
        Label1.Text = "Contador:"
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(295, 40)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(13, 15)
        lblCount.TabIndex = 2
        lblCount.Text = "0"
        ' 
        ' ejercicio14
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(345, 100)
        Controls.Add(lblCount)
        Controls.Add(Label1)
        Controls.Add(btn1)
        Name = "ejercicio14"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 14"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCount As Label
End Class
