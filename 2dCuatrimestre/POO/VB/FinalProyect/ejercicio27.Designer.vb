<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio27
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
        lbDice = New ListBox()
        GroupBox1 = New GroupBox()
        btnRoll = New Button()
        txtRollNum = New TextBox()
        btnClose = New Button()
        lbl = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbDice
        ' 
        lbDice.FormattingEnabled = True
        lbDice.ItemHeight = 15
        lbDice.Location = New Point(6, 22)
        lbDice.Name = "lbDice"
        lbDice.SelectionMode = SelectionMode.None
        lbDice.Size = New Size(143, 109)
        lbDice.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbDice)
        GroupBox1.Location = New Point(10, 70)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(158, 141)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dado"
        ' 
        ' btnRoll
        ' 
        btnRoll.Location = New Point(10, 40)
        btnRoll.Name = "btnRoll"
        btnRoll.Size = New Size(127, 23)
        btnRoll.TabIndex = 2
        btnRoll.Text = "Tirar"
        btnRoll.UseVisualStyleBackColor = True
        ' 
        ' txtRollNum
        ' 
        txtRollNum.Location = New Point(60, 10)
        txtRollNum.Name = "txtRollNum"
        txtRollNum.Size = New Size(110, 23)
        txtRollNum.TabIndex = 3
        txtRollNum.Text = "0"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(145, 39)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(25, 25)
        btnClose.TabIndex = 6
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(10, 13)
        lbl.Name = "lbl"
        lbl.Size = New Size(44, 15)
        lbl.TabIndex = 7
        lbl.Text = "Tiradas"
        ' 
        ' ejercicio27
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(179, 221)
        ControlBox = False
        Controls.Add(lbl)
        Controls.Add(btnClose)
        Controls.Add(txtRollNum)
        Controls.Add(btnRoll)
        Controls.Add(GroupBox1)
        Name = "ejercicio27"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ejercicio 27"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbDice As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents txtRollNum As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lbl As Label
End Class
