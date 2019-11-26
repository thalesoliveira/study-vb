Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Imports adoNet.DTO

Namespace DAO
    Public Class ProdutoDAO

        Private Shared connectionString As String

        Shared Sub New()
            connectionString = ConfigurationManager.ConnectionStrings("EstoqueConnectionString").ConnectionString
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function listarProdutos() As DataTable
            Dim conn = New SqlConnection(connectionString)
            Dim sql As String = "SELECT * FROM Produtos"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim da As SqlDataAdapter = New SqlDataAdapter

            Dim dt As DataTable = New DataTable

            Try
                da.SelectCommand = cmd
                da.Fill(dt)
            Catch ex As Exception
                Throw ex
            Finally
                conn.Close()
            End Try

            Return dt

        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub incluirProduto(ByVal Produto As Produto)

            Dim conn = New SqlConnection(connectionString)
            Dim sql As String = "INSERT INTO produtos (nome, preco) VALUES (@nome, @preco)"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            Try
                cmd.Parameters.AddWithValue("@nome", Produto.Nome)
                cmd.Parameters.AddWithValue("@preco", Produto.Preco)
                conn.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                Throw ex
            Finally
                conn.Close()
            End Try

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Produto"></param>
        Public Sub alterarProduto(ByVal Produto As Produto)

            Dim conn = New SqlConnection(connectionString)
            Dim sql As String = "UPDATE produtos SET nome=@nome, preco=@preco WHERE id = @id"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            Try
                cmd.Parameters.AddWithValue("@id", Int32.Parse(Produto.Codigo))
                cmd.Parameters.AddWithValue("@nome", Produto.Nome)
                cmd.Parameters.AddWithValue("@preco", Produto.Preco)
                conn.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                Throw ex
            Finally
                conn.Close()
            End Try

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Produto"></param>
        Public Sub excluirProduto(ByVal Produto As Produto)

            Dim conn = New SqlConnection(connectionString)
            Dim sql As String = "DELETE produtos WHERE id = @id"
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            Try
                cmd.Parameters.AddWithValue("@id", Int32.Parse(Produto.Codigo))
                conn.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                Throw ex
            Finally
                conn.Close()
            End Try

        End Sub

    End Class

End Namespace
