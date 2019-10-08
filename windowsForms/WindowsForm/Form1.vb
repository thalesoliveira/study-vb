Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtValor2.TextChanged

    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Dim soma As Integer = lblValor1.Text + lblValor2.Text
        txtResultado.Text = soma
    End Sub
End Class
