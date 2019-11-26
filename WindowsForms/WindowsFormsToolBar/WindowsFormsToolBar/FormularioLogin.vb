Public Class FormularioLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsuario.Text = "admin" OrElse txtSenha.Text = "admin" Then
            Close()
            Return
        End If
    End Sub
End Class