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
        MenuStrip1 = New MenuStrip()
        EJERCICIO13ToolStripMenuItem = New ToolStripMenuItem()
        EJERCICIO14ToolStripMenuItem = New ToolStripMenuItem()
        PRACTICA3ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EJERCICIO13ToolStripMenuItem, EJERCICIO14ToolStripMenuItem, PRACTICA3ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EJERCICIO13ToolStripMenuItem
        ' 
        EJERCICIO13ToolStripMenuItem.Name = "EJERCICIO13ToolStripMenuItem"
        EJERCICIO13ToolStripMenuItem.Size = New Size(110, 24)
        EJERCICIO13ToolStripMenuItem.Text = "EJERCICIO 13"
        ' 
        ' EJERCICIO14ToolStripMenuItem
        ' 
        EJERCICIO14ToolStripMenuItem.Name = "EJERCICIO14ToolStripMenuItem"
        EJERCICIO14ToolStripMenuItem.Size = New Size(110, 24)
        EJERCICIO14ToolStripMenuItem.Text = "EJERCICIO 14"
        ' 
        ' PRACTICA3ToolStripMenuItem
        ' 
        PRACTICA3ToolStripMenuItem.Name = "PRACTICA3ToolStripMenuItem"
        PRACTICA3ToolStripMenuItem.Size = New Size(102, 24)
        PRACTICA3ToolStripMenuItem.Text = "PRACTICA 3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EJERCICIO13ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO14ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRACTICA3ToolStripMenuItem As ToolStripMenuItem

End Class
