<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ejercicio13
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn1 = New Button()
        btn2 = New Button()
        Label1 = New Label()
        lblCount = New Label()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(40, 25)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 23)
        btn1.TabIndex = 0
        btn1.Text = "Button1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(220, 25)
        btn2.Name = "btn2"
        btn2.Size = New Size(75, 23)
        btn2.TabIndex = 1
        btn2.Text = "Button2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Contador:"
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(190, 78)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(13, 15)
        lblCount.TabIndex = 3
        lblCount.Text = "0"
        ' 
        ' ejercicio13
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 132)
        Controls.Add(lblCount)
        Controls.Add(Label1)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Name = "ejercicio13"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio13"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCount As Label
End Class
