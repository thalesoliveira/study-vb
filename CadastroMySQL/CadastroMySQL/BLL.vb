Imports CadastroMySQL.DTO
Imports CadastroMySQL.DAL

Namespace BLL
    Public Class ProdutoBLL
        Dim produtoDAL = New DAL.ProdutoDAL

        Public Function selecionaProdutos() As DataTable
            Try
                produtoDAL = New ProdutoDAL
                Return produtoDAL.listarProdutos()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub inserirProduto(ByVal produto As Produto)
            Try
                produtoDAL = New ProdutoDAL
                produtoDAL.insertProduto(produto)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function selecionaProdutoPorID(ByVal id As Integer) As DTO.Produto
            Try
                produtoDAL = New ProdutoDAL
                Return produtoDAL.selectProdutoByID(id)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub atualizarProduto(ByVal produto As Produto)
            Try
                produtoDAL = New ProdutoDAL
                produtoDAL.updateProduto(produto)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub excluirProduto(ByVal produto As Produto)
            Try
                produtoDAL = New ProdutoDAL
                produtoDAL.deleteProduto(produto)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


    End Class

End Namespace
