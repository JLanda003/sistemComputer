Imports System.IO
Imports System.Text.Json
Imports CRUDJLanda.LangModule
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lang As String = "es"
        Dim lgLogin As Lang.Login = LangLogin(lang)

        If lgLogin IsNot Nothing Then
            lblLogin.Text = lgLogin.lblLogin
            lblFirtsTime.Text = lgLogin.lblFirtsTime
            lblRegisterLink.Text = lgLogin.lblRegisterLink
            lblEmail.Text = lgLogin.lblEmail
            txtEmail.PlaceholderText = lgLogin.txtEmailPlaceholder
            lblPassword.Text = lgLogin.lblPassword
            txtPassword.PlaceholderText = lgLogin.txtPasswordPlaceholder
            lblForgotPasswordLink.Text = lgLogin.lblForgotPasswordLink
            btnLogin.Text = lgLogin.btnLogin
            btnExit.Text = lgLogin.btnExit
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub
End Class
