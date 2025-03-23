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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblLogin = New Label()
        lblFirtsTime = New Label()
        lblEmail = New Label()
        lblPassword = New Label()
        btnExit = New Button()
        btnLogin = New Button()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        lblRegisterLink = New LinkLabel()
        lblForgotPasswordLink = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblLogin
        ' 
        lblLogin.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblLogin.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogin.Location = New Point(12, 9)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(262, 30)
        lblLogin.TabIndex = 0
        lblLogin.Text = "Label1"
        lblLogin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFirtsTime
        ' 
        lblFirtsTime.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblFirtsTime.AutoSize = True
        lblFirtsTime.Location = New Point(46, 44)
        lblFirtsTime.Name = "lblFirtsTime"
        lblFirtsTime.Size = New Size(41, 15)
        lblFirtsTime.TabIndex = 1
        lblFirtsTime.Text = "Label2"
        ' 
        ' lblEmail
        ' 
        lblEmail.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(34, 79)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 15)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Label3"
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(34, 132)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(41, 15)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Label1"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(215, 268)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(59, 24)
        btnExit.TabIndex = 6
        btnExit.Text = "Button1"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnLogin.Location = New Point(100, 195)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(79, 23)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Button1"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.Location = New Point(34, 97)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(221, 23)
        txtEmail.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.Location = New Point(34, 150)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(221, 23)
        txtPassword.TabIndex = 9
        ' 
        ' lblRegisterLink
        ' 
        lblRegisterLink.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblRegisterLink.AutoSize = True
        lblRegisterLink.LinkColor = Color.Silver
        lblRegisterLink.Location = New Point(173, 44)
        lblRegisterLink.Name = "lblRegisterLink"
        lblRegisterLink.Size = New Size(63, 15)
        lblRegisterLink.TabIndex = 10
        lblRegisterLink.TabStop = True
        lblRegisterLink.Text = "LinkLabel1"
        lblRegisterLink.VisitedLinkColor = Color.Silver
        ' 
        ' lblForgotPasswordLink
        ' 
        lblForgotPasswordLink.AutoSize = True
        lblForgotPasswordLink.LinkColor = Color.Silver
        lblForgotPasswordLink.Location = New Point(34, 236)
        lblForgotPasswordLink.Name = "lblForgotPasswordLink"
        lblForgotPasswordLink.Size = New Size(63, 15)
        lblForgotPasswordLink.TabIndex = 11
        lblForgotPasswordLink.TabStop = True
        lblForgotPasswordLink.Text = "LinkLabel1"
        lblForgotPasswordLink.VisitedLinkColor = Color.Silver
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 301)
        ControlBox = False
        Controls.Add(lblForgotPasswordLink)
        Controls.Add(lblRegisterLink)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(btnLogin)
        Controls.Add(btnExit)
        Controls.Add(lblPassword)
        Controls.Add(lblEmail)
        Controls.Add(lblFirtsTime)
        Controls.Add(lblLogin)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Opacity = 0.85R
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogIn"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents lblFirtsTime As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblRegisterLink As LinkLabel
    Friend WithEvents lblForgotPasswordLink As LinkLabel

End Class
