<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConvert
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        txtValueBin = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtValueDec = New TextBox()
        Button1 = New Button()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(75, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(377, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' txtValueBin
        ' 
        txtValueBin.Location = New Point(146, 33)
        txtValueBin.Name = "txtValueBin"
        txtValueBin.Size = New Size(198, 27)
        txtValueBin.TabIndex = 2
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtValueDec
        ' 
        txtValueDec.Location = New Point(446, 33)
        txtValueDec.Name = "txtValueDec"
        txtValueDec.Size = New Size(198, 27)
        txtValueDec.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(87, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 63)
        Button1.TabIndex = 5
        Button1.Text = "Convertir Binario a decimal"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(298, 119)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(155, 57)
        btnReturn.TabIndex = 6
        btnReturn.Text = "Regresar a formulario 1"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' FrmConvert
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReturn)
        Controls.Add(Button1)
        Controls.Add(txtValueDec)
        Controls.Add(txtValueBin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmConvert"
        Text = "Binario to Decimal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValueBin As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtValueDec As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReturn As Button
End Class
