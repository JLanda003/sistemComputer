<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio26
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
        lbObjects = New ListBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        rBtn = New RadioButton()
        rBtnIva = New RadioButton()
        txtPrices = New TextBox()
        btnShow = New Button()
        GroupBox3 = New GroupBox()
        lblText = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbObjects
        ' 
        lbObjects.FormattingEnabled = True
        lbObjects.ItemHeight = 15
        lbObjects.Items.AddRange(New Object() {"Celular - $100 dls", "Computadora - $400 dls", "Televisión - $200 dls", "Tableta - $150 dls", "Impresora - $175 dls", "Extensiones - $75 dls"})
        lbObjects.Location = New Point(6, 22)
        lbObjects.Name = "lbObjects"
        lbObjects.Size = New Size(175, 94)
        lbObjects.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbObjects)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(187, 127)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Articulos"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rBtn)
        GroupBox2.Controls.Add(rBtnIva)
        GroupBox2.Location = New Point(12, 145)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(287, 77)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "IVA %"
        ' 
        ' rBtn
        ' 
        rBtn.AutoSize = True
        rBtn.Location = New Point(6, 47)
        rBtn.Name = "rBtn"
        rBtn.Size = New Size(280, 19)
        rBtn.TabIndex = 1
        rBtn.TabStop = True
        rBtn.Text = "Sin IVA: No se añade nada al precio del producto"
        rBtn.UseVisualStyleBackColor = True
        ' 
        ' rBtnIva
        ' 
        rBtnIva.AutoSize = True
        rBtnIva.Location = New Point(6, 22)
        rBtnIva.Name = "rBtnIva"
        rBtnIva.Size = New Size(250, 19)
        rBtnIva.TabIndex = 0
        rBtnIva.TabStop = True
        rBtnIva.Text = "Incluir IVA: 16% más al precio del producto"
        rBtnIva.UseVisualStyleBackColor = True
        ' 
        ' txtPrices
        ' 
        txtPrices.Enabled = False
        txtPrices.Location = New Point(6, 22)
        txtPrices.Name = "txtPrices"
        txtPrices.Size = New Size(82, 23)
        txtPrices.TabIndex = 3
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(205, 116)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(94, 23)
        btnShow.TabIndex = 5
        btnShow.Text = "Mostrar Precio"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lblText)
        GroupBox3.Controls.Add(txtPrices)
        GroupBox3.Location = New Point(205, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(94, 98)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Precio"
        ' 
        ' lblText
        ' 
        lblText.AutoSize = True
        lblText.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblText.Location = New Point(6, 61)
        lblText.Name = "lblText"
        lblText.Size = New Size(0, 15)
        lblText.TabIndex = 7
        ' 
        ' ejercicio26
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(313, 230)
        Controls.Add(GroupBox3)
        Controls.Add(btnShow)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ejercicio26"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 26"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbObjects As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rBtnIva As RadioButton
    Friend WithEvents rBtn As RadioButton
    Friend WithEvents txtPrices As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblText As Label
End Class
