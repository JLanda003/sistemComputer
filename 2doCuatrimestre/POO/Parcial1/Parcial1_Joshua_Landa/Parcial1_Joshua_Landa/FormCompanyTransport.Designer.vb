<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompanyTransport
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
        txtTotWork = New TextBox()
        txtFalt = New TextBox()
        txtExt = New TextBox()
        txtTotal = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtInput = New TextBox()
        btnReturn = New Button()
        btnCal = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 20)
        Label1.TabIndex = 0
        Label1.Text = "Total Horas trabajadas a pagar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 1
        Label2.Text = "Horas faltantes"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 2
        Label3.Text = "Total de extras"
        ' 
        ' txtTotWork
        ' 
        txtTotWork.Location = New Point(250, 85)
        txtTotWork.Name = "txtTotWork"
        txtTotWork.Size = New Size(125, 27)
        txtTotWork.TabIndex = 3
        ' 
        ' txtFalt
        ' 
        txtFalt.Location = New Point(250, 127)
        txtFalt.Name = "txtFalt"
        txtFalt.Size = New Size(125, 27)
        txtFalt.TabIndex = 4
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(250, 169)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(125, 27)
        txtExt.TabIndex = 5
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(250, 226)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(125, 27)
        txtTotal.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 7
        Label4.Text = "Total a pagar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 20)
        Label5.TabIndex = 8
        Label5.Text = "Horas trabajadas"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(250, 31)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 9
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(30, 293)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(94, 29)
        btnReturn.TabIndex = 10
        btnReturn.Text = "Regresar"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnCal
        ' 
        btnCal.Location = New Point(175, 293)
        btnCal.Name = "btnCal"
        btnCal.Size = New Size(94, 29)
        btnCal.TabIndex = 11
        btnCal.Text = "Calcular"
        btnCal.UseVisualStyleBackColor = True
        ' 
        ' FormCompanyTransport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(424, 348)
        Controls.Add(btnCal)
        Controls.Add(btnReturn)
        Controls.Add(txtInput)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtTotal)
        Controls.Add(txtExt)
        Controls.Add(txtFalt)
        Controls.Add(txtTotWork)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormCompanyTransport"
        Text = "FormCompanyTransport"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotWork As TextBox
    Friend WithEvents txtFalt As TextBox
    Friend WithEvents txtExt As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCal As Button
End Class
