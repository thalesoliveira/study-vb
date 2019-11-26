
Public Class Login
    Inherits MetroFramework.Forms.MetroForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        If txtUsuario.Text = "usuario" And txtSenha.Text = "1234" Then
            My.Forms.Login.Hide()
            My.Forms.Calculadora.Show()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Usuário/Senha inválidos!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub Cancel_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
