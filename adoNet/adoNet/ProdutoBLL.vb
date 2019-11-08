Imports adoNet.DAO
Imports adoNet.DTO

Namespace BLL
    Public Class ProdutoBLL

        Dim produtoDAO As DAO.ProdutoDAO

        Public Function listarProdutos() As DataTable
            produtoDAO = New DAO.ProdutoDAO()
            Return produtoDAO.listarProdutos()
        End Function

        Public Sub incluirProduto(ByVal produto As Produto)
            produtoDAO = New DAO.ProdutoDAO()
            produtoDAO.incluirProduto(produto)
        End Sub

        Public Sub alterarProduto(ByVal produto As Produto)
            produtoDAO = New DAO.ProdutoDAO()
            produtoDAO.alterarProduto(produto)
        End Sub

        Public Sub excluirProdutos(ByVal produto As Produto)
            produtoDAO = New DAO.ProdutoDAO()
            produtoDAO.excluirProduto(produto)
        End Sub


    End Class

End Namespace
