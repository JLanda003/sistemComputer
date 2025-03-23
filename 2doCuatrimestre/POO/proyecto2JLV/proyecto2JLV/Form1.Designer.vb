<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtValue1 = New TextBox()
        txtValue2 = New TextBox()
        txtResult = New TextBox()
        btnAdd = New Button()
        btnSubstract = New Button()
        btnElev = New Button()
        btnDiv1 = New Button()
        btnDiv2 = New Button()
        btnMod = New Button()
        btnBinToDec = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Value1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(292, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 1
        Label2.Text = "value2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(484, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Result"
        ' 
        ' txtValue1
        ' 
        txtValue1.Location = New Point(140, 54)
        txtValue1.Name = "txtValue1"
        txtValue1.Size = New Size(125, 27)
        txtValue1.TabIndex = 3
        ' 
        ' txtValue2
        ' 
        txtValue2.Location = New Point(350, 54)
        txtValue2.Name = "txtValue2"
        txtValue2.Size = New Size(125, 27)
        txtValue2.TabIndex = 4
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(539, 54)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(125, 27)
        txtResult.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(40, 179)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 6
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSubstract
        ' 
        btnSubstract.Location = New Point(140, 179)
        btnSubstract.Name = "btnSubstract"
        btnSubstract.Size = New Size(94, 29)
        btnSubstract.TabIndex = 7
        btnSubstract.Text = "-"
        btnSubstract.UseVisualStyleBackColor = True
        ' 
        ' btnElev
        ' 
        btnElev.Location = New Point(240, 179)
        btnElev.Name = "btnElev"
        btnElev.Size = New Size(94, 29)
        btnElev.TabIndex = 8
        btnElev.Text = "^"
        btnElev.UseVisualStyleBackColor = True
        ' 
        ' btnDiv1
        ' 
        btnDiv1.Location = New Point(340, 179)
        btnDiv1.Name = "btnDiv1"
        btnDiv1.Size = New Size(94, 29)
        btnDiv1.TabIndex = 9
        btnDiv1.Text = " /"
        btnDiv1.UseVisualStyleBackColor = True
        ' 
        ' btnDiv2
        ' 
        btnDiv2.Location = New Point(440, 179)
        btnDiv2.Name = "btnDiv2"
        btnDiv2.Size = New Size(94, 29)
        btnDiv2.TabIndex = 10
        btnDiv2.Text = "\"
        btnDiv2.UseVisualStyleBackColor = True
        ' 
        ' btnMod
        ' 
        btnMod.Location = New Point(540, 179)
        btnMod.Name = "btnMod"
        btnMod.Size = New Size(94, 29)
        btnMod.TabIndex = 11
        btnMod.Text = "MOD"
        btnMod.UseVisualStyleBackColor = True
        ' 
        ' btnBinToDec
        ' 
        btnBinToDec.Location = New Point(640, 179)
        btnBinToDec.Name = "btnBinToDec"
        btnBinToDec.Size = New Size(133, 62)
        btnBinToDec.TabIndex = 12
        btnBinToDec.Text = "Ir Formulario BinToDec"
        btnBinToDec.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 253)
        Controls.Add(btnBinToDec)
        Controls.Add(btnMod)
        Controls.Add(btnDiv2)
        Controls.Add(btnDiv1)
        Controls.Add(btnElev)
        Controls.Add(btnSubstract)
        Controls.Add(btnAdd)
        Controls.Add(txtResult)
        Controls.Add(txtValue2)
        Controls.Add(txtValue1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubstract As Button
    Friend WithEvents btnElev As Button
    Friend WithEvents btnDiv1 As Button
    Friend WithEvents btnDiv2 As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnBinToDec As Button

End Class
