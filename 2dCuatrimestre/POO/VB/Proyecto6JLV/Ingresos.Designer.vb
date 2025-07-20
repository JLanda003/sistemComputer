<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresos
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
        TxTnumber = New TextBox()
        Label2 = New Label()
        BtnAddOne = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "Ingresos"
        ' 
        ' TxTnumber
        ' 
        TxTnumber.Location = New Point(164, 69)
        TxTnumber.Name = "TxTnumber"
        TxTnumber.Size = New Size(207, 27)
        TxTnumber.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 20)
        Label2.TabIndex = 2
        Label2.Text = "Ingrese un número"
        ' 
        ' BtnAddOne
        ' 
        BtnAddOne.Location = New Point(397, 69)
        BtnAddOne.Name = "BtnAddOne"
        BtnAddOne.Size = New Size(140, 29)
        BtnAddOne.TabIndex = 3
        BtnAddOne.Text = "Incrementar en 1"
        BtnAddOne.UseVisualStyleBackColor = True
        ' 
        ' Ingresos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnAddOne)
        Controls.Add(Label2)
        Controls.Add(TxTnumber)
        Controls.Add(Label1)
        Name = "Ingresos"
        Text = "Ingresos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxTnumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAddOne As Button
End Class
