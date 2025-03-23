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
        btnGrades = New Button()
        btnYears = New Button()
        btnCompanySecure = New Button()
        btnTransporte = New Button()
        SuspendLayout()
        ' 
        ' btnGrades
        ' 
        btnGrades.Location = New Point(34, 39)
        btnGrades.Name = "btnGrades"
        btnGrades.Size = New Size(133, 29)
        btnGrades.TabIndex = 0
        btnGrades.Text = "Formulario 1"
        btnGrades.UseVisualStyleBackColor = True
        ' 
        ' btnYears
        ' 
        btnYears.Location = New Point(205, 39)
        btnYears.Name = "btnYears"
        btnYears.Size = New Size(127, 29)
        btnYears.TabIndex = 1
        btnYears.Text = "Formulario 2"
        btnYears.UseVisualStyleBackColor = True
        ' 
        ' btnCompanySecure
        ' 
        btnCompanySecure.Location = New Point(34, 95)
        btnCompanySecure.Name = "btnCompanySecure"
        btnCompanySecure.Size = New Size(133, 29)
        btnCompanySecure.TabIndex = 2
        btnCompanySecure.Text = "Formulario 3"
        btnCompanySecure.UseVisualStyleBackColor = True
        ' 
        ' btnTransporte
        ' 
        btnTransporte.Location = New Point(205, 95)
        btnTransporte.Name = "btnTransporte"
        btnTransporte.Size = New Size(127, 29)
        btnTransporte.TabIndex = 3
        btnTransporte.Text = "Formulario 4"
        btnTransporte.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(371, 168)
        Controls.Add(btnTransporte)
        Controls.Add(btnCompanySecure)
        Controls.Add(btnYears)
        Controls.Add(btnGrades)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGrades As Button
    Friend WithEvents btnYears As Button
    Friend WithEvents btnCompanySecure As Button
    Friend WithEvents btnTransporte As Button

End Class
