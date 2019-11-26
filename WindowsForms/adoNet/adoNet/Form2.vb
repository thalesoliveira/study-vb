Imports adoNet.BLL
Imports adoNet.DTO

Public Class Form2

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        exibirProdutos()
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Dim produtoBLL As New BLL.ProdutoBLL
        Dim produto As New Produto

        produto.Nome = txtNome.Text
        produto.Preco = txtPreco.Text

        produtoBLL.incluirProduto(produto)
        exibirProdutos()

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim produtoBLL As New BLL.ProdutoBLL
        Dim produto As New Produto

        produto.Codigo = Int32.Parse(codigo.Text)
        produto.Nome = txtNome.Text
        produto.Preco = txtPreco.Text

        produtoBLL.alterarProduto(produto)
        exibirProdutos()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim produtoBLL As New BLL.ProdutoBLL
        Dim produto As New Produto
        produto.Codigo = Int32.Parse(codigo.Text)
        produtoBLL.excluirProdutos(produto)
        exibirProdutos()
    End Sub

    Private Sub exibirProdutos()
        Dim produtoBLL As New BLL.ProdutoBLL
        gdvProduto.DataSource = produtoBLL.listarProdutos()
    End Sub

    Private Sub gdvProduto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdvProduto.CellClick
        Dim i As Integer
        i = gdvProduto.CurrentRow.Index

        codigo.Text = gdvProduto.Item(0, i).Value
        txtNome.Text = gdvProduto.Item(1, i).Value
        txtPreco.Text = gdvProduto.Item(2, i).Value

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exibirProdutos()
    End Sub
End Class