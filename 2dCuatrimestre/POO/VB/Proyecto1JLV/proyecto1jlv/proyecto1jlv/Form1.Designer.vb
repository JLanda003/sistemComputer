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
        components = New ComponentModel.Container()
        lblTitle = New Label()
        btnHide = New Button()
        btnShow = New Button()
        btnInvert = New Button()
        btnBoldOff = New Button()
        BindingSource1 = New BindingSource(components)
        btnBoldOn = New Button()
        btnColorBlack = New Button()
        btnColorBlue = New Button()
        btnColorBrown = New Button()
        btnColorAquamarine = New Button()
        btnItalicOn = New Button()
        btnItalicOff = New Button()
        btnUnderlineOn = New Button()
        btnUnderlineOff = New Button()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15F)
        lblTitle.Location = New Point(145, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(484, 35)
        lblTitle.TabIndex = 0
        lblTitle.Text = "UNIVERSIDAD AZTLAN CAMPUS CANCÚN"
        ' 
        ' btnHide
        ' 
        btnHide.Location = New Point(265, 63)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(104, 41)
        btnHide.TabIndex = 1
        btnHide.Text = "Ocultar"
        btnHide.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(410, 62)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(113, 42)
        btnShow.TabIndex = 2
        btnShow.Text = "Mostrar"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnInvert
        ' 
        btnInvert.Location = New Point(344, 131)
        btnInvert.Name = "btnInvert"
        btnInvert.Size = New Size(94, 29)
        btnInvert.TabIndex = 3
        btnInvert.Text = "INVERSO"
        btnInvert.UseVisualStyleBackColor = True
        ' 
        ' btnBoldOff
        ' 
        btnBoldOff.Location = New Point(63, 281)
        btnBoldOff.Name = "btnBoldOff"
        btnBoldOff.Size = New Size(94, 61)
        btnBoldOff.TabIndex = 4
        btnBoldOff.Text = "Negritas:" & vbCrLf & "Off"
        btnBoldOff.UseVisualStyleBackColor = True
        ' 
        ' btnBoldOn
        ' 
        btnBoldOn.Location = New Point(200, 281)
        btnBoldOn.Name = "btnBoldOn"
        btnBoldOn.Size = New Size(94, 51)
        btnBoldOn.TabIndex = 5
        btnBoldOn.Text = "Negritas:" & vbCrLf & "On"
        btnBoldOn.UseVisualStyleBackColor = True
        ' 
        ' btnColorBlack
        ' 
        btnColorBlack.Location = New Point(337, 281)
        btnColorBlack.Name = "btnColorBlack"
        btnColorBlack.Size = New Size(94, 51)
        btnColorBlack.TabIndex = 6
        btnColorBlack.Text = "Color:" & vbCrLf & "Negro"
        btnColorBlack.UseVisualStyleBackColor = True
        ' 
        ' btnColorBlue
        ' 
        btnColorBlue.Location = New Point(474, 281)
        btnColorBlue.Name = "btnColorBlue"
        btnColorBlue.Size = New Size(94, 51)
        btnColorBlue.TabIndex = 7
        btnColorBlue.Text = "Color:" & vbCrLf & "Azul"
        btnColorBlue.UseVisualStyleBackColor = True
        ' 
        ' btnColorBrown
        ' 
        btnColorBrown.Location = New Point(611, 281)
        btnColorBrown.Name = "btnColorBrown"
        btnColorBrown.Size = New Size(94, 29)
        btnColorBrown.TabIndex = 8
        btnColorBrown.Text = "Color: Cafe"
        btnColorBrown.UseVisualStyleBackColor = True
        ' 
        ' btnColorAquamarine
        ' 
        btnColorAquamarine.Location = New Point(63, 348)
        btnColorAquamarine.Name = "btnColorAquamarine"
        btnColorAquamarine.Size = New Size(94, 52)
        btnColorAquamarine.TabIndex = 9
        btnColorAquamarine.Text = "Color: Aquamarina"
        btnColorAquamarine.UseVisualStyleBackColor = True
        ' 
        ' btnItalicOn
        ' 
        btnItalicOn.Location = New Point(200, 348)
        btnItalicOn.Name = "btnItalicOn"
        btnItalicOn.Size = New Size(94, 29)
        btnItalicOn.TabIndex = 10
        btnItalicOn.Text = "Italic: On"
        btnItalicOn.UseVisualStyleBackColor = True
        ' 
        ' btnItalicOff
        ' 
        btnItalicOff.Location = New Point(344, 348)
        btnItalicOff.Name = "btnItalicOff"
        btnItalicOff.Size = New Size(94, 29)
        btnItalicOff.TabIndex = 11
        btnItalicOff.Text = "Italic: Off"
        btnItalicOff.UseVisualStyleBackColor = True
        ' 
        ' btnUnderlineOn
        ' 
        btnUnderlineOn.Location = New Point(474, 348)
        btnUnderlineOn.Name = "btnUnderlineOn"
        btnUnderlineOn.Size = New Size(103, 52)
        btnUnderlineOn.TabIndex = 12
        btnUnderlineOn.Text = "Underline:" & vbCrLf & "On"
        btnUnderlineOn.UseVisualStyleBackColor = True
        ' 
        ' btnUnderlineOff
        ' 
        btnUnderlineOff.Location = New Point(611, 348)
        btnUnderlineOff.Name = "btnUnderlineOff"
        btnUnderlineOff.Size = New Size(106, 52)
        btnUnderlineOff.TabIndex = 13
        btnUnderlineOff.Text = "Underline: Off"
        btnUnderlineOff.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnUnderlineOff)
        Controls.Add(btnUnderlineOn)
        Controls.Add(btnItalicOff)
        Controls.Add(btnItalicOn)
        Controls.Add(btnColorAquamarine)
        Controls.Add(btnColorBrown)
        Controls.Add(btnColorBlue)
        Controls.Add(btnColorBlack)
        Controls.Add(btnBoldOn)
        Controls.Add(btnBoldOff)
        Controls.Add(btnInvert)
        Controls.Add(btnShow)
        Controls.Add(btnHide)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Form1"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnInvert As Button
    Friend WithEvents btnBoldOff As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnBoldOn As Button
    Friend WithEvents btnColorBlack As Button
    Friend WithEvents btnColorBlue As Button
    Friend WithEvents btnColorBrown As Button
    Friend WithEvents btnColorAquamarine As Button
    Friend WithEvents btnItalicOn As Button
    Friend WithEvents btnItalicOff As Button
    Friend WithEvents btnUnderlineOn As Button
    Friend WithEvents btnUnderlineOff As Button

End Class
