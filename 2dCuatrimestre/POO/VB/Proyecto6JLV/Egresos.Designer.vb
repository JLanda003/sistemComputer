<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Egresos
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
        BtnDecrementOne = New Button()
        Label2 = New Label()
        TxtNumber = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 0
        Label1.Text = "Egresos"
        ' 
        ' BtnDecrementOne
        ' 
        BtnDecrementOne.Location = New Point(418, 79)
        BtnDecrementOne.Name = "BtnDecrementOne"
        BtnDecrementOne.Size = New Size(149, 29)
        BtnDecrementOne.TabIndex = 1
        BtnDecrementOne.Text = "Decrementar en 1"
        BtnDecrementOne.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 20)
        Label2.TabIndex = 2
        Label2.Text = "Ingrese un valor"
        ' 
        ' TxtNumber
        ' 
        TxtNumber.Location = New Point(187, 81)
        TxtNumber.Name = "TxtNumber"
        TxtNumber.Size = New Size(211, 27)
        TxtNumber.TabIndex = 3
        ' 
        ' Egresos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtNumber)
        Controls.Add(Label2)
        Controls.Add(BtnDecrementOne)
        Controls.Add(Label1)
        Name = "Egresos"
        Text = "Egresos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDecrementOne As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumber As TextBox
End Class
