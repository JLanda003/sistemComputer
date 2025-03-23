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
        lblTest = New Label()
        btnSizePlusbtnSizePlus = New Button()
        btnSizeMinimum = New Button()
        ColorDialog1 = New ColorDialog()
        btnColorChange = New Button()
        btnBold = New Button()
        SuspendLayout()
        ' 
        ' lblTest
        ' 
        lblTest.AutoSize = True
        lblTest.Location = New Point(12, 15)
        lblTest.Name = "lblTest"
        lblTest.Size = New Size(109, 15)
        lblTest.TabIndex = 1
        lblTest.Text = "TEXTO DE PRUEBAS"
        ' 
        ' btnSizePlusbtnSizePlus
        ' 
        btnSizePlusbtnSizePlus.Location = New Point(12, 110)
        btnSizePlusbtnSizePlus.Name = "btnSizePlusbtnSizePlus"
        btnSizePlusbtnSizePlus.Size = New Size(75, 23)
        btnSizePlusbtnSizePlus.TabIndex = 2
        btnSizePlusbtnSizePlus.Text = "SIZE +"
        btnSizePlusbtnSizePlus.UseVisualStyleBackColor = True
        ' 
        ' btnSizeMinimum
        ' 
        btnSizeMinimum.Location = New Point(93, 110)
        btnSizeMinimum.Name = "btnSizeMinimum"
        btnSizeMinimum.Size = New Size(75, 23)
        btnSizeMinimum.TabIndex = 3
        btnSizeMinimum.Text = "SIZE -"
        btnSizeMinimum.UseVisualStyleBackColor = True
        ' 
        ' btnColorChange
        ' 
        btnColorChange.Location = New Point(174, 110)
        btnColorChange.Name = "btnColorChange"
        btnColorChange.Size = New Size(89, 23)
        btnColorChange.TabIndex = 4
        btnColorChange.Text = "Color Change"
        btnColorChange.UseVisualStyleBackColor = True
        ' 
        ' btnBold
        ' 
        btnBold.Location = New Point(269, 111)
        btnBold.Name = "btnBold"
        btnBold.Size = New Size(75, 23)
        btnBold.TabIndex = 5
        btnBold.Text = "Bold"
        btnBold.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(356, 146)
        Controls.Add(btnBold)
        Controls.Add(btnColorChange)
        Controls.Add(btnSizeMinimum)
        Controls.Add(btnSizePlusbtnSizePlus)
        Controls.Add(lblTest)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SelectCalculated As ComboBox
    Friend WithEvents lblTest As Label
    Friend WithEvents btnSizePlusbtnSizePlus As Button
    Friend WithEvents btnSizeMinimum As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnColorChange As Button
    Friend WithEvents btnBold As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ValueOne As TextBox
    Friend WithEvents ValueTwo As TextBox
    Friend WithEvents ValueCalculated As TextBox

End Class
