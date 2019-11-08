Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Form2.ShowDialog()

        id.Text = My.Forms.Form2.codigoProduto
        txtDescricao.Text = My.Forms.Form2.nomeProduto
        preco.Text = My.Forms.Form2.precoProduto

    End Sub


End Class
