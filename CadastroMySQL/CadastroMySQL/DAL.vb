Imports System.Configuration
Imports CadastroMySQL.DTO
Imports MySql.Data.MySqlClient


Namespace DAL
    Public Class ProdutoDAL

        Public _connectionString As String
        Public _providerName As String

        Public Sub New()
            Try
                _connectionString = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ConnectionString
                _providerName = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ProviderName
            Catch ex As Exception
                Throw New Exception("Erro ao acessar a string de conexão.")
            End Try
        End Sub

        Public Function listarProdutos() As DataTable
            Dim sql As String = "SELECT * FROM estoque"
            Dim conn As MySqlConnection = New MySqlConnection(_connectionString)

            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter
                Dim dt As DataTable = New DataTable

                da.SelectCommand = cmd
                da.Fill(dt)

                Return dt

            Catch ex As Exception
                Throw ex
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

        End Function

        Public Function selectProdutoByID(ByVal id As Integer) As Produto
            Dim sql As String = "SelecionaProdutoPorID"
            Dim conn As MySqlConnection = New MySqlConnection(_connectionString)
            Dim produto As New DTO.Produto

            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New MySqlParameter("id", id))
                conn.Open()

                Dim dr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While dr.Read
                    produto.ID = dr("id")
                    produto.NOME = dr("nome")
                    produto.PRECO = dr("preco")
                End While
                Return produto
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub insertProduto(ByVal produto As Produto)
            Dim sql As String = "INSERT INTO estoque(nome, preco) values(@nome, @preco)"
            Dim conn As MySqlConnection = New MySqlConnection(_connectionString)

            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@nome", produto.NOME)
                cmd.Parameters.AddWithValue("@preco", produto.PRECO)
                conn.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                Throw ex
            Finally
                conn.Close()
            End Try
        End Sub
        Public Sub updateProduto(ByVal produto As Produto)
            Dim sql As String = "UPDATE estoque SET nome=@nome, preco=@preco WHERE id = @id"
            Dim conn As MySqlConnection = New MySqlConnection(_connectionString)

            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", produto.ID)
                cmd.Parameters.AddWithValue("@nome", produto.NOME)
                cmd.Parameters.AddWithValue("@preco", produto.PRECO)
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            Finally
                conn.Close()
            End Try
        End Sub
        Public Sub deleteProduto(ByVal produto As Produto)
            Dim sql As String = "DELETE FROM estoque WHERE id= @id"
            Dim conn As MySqlConnection = New MySqlConnection(_connectionString)

            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", produto.ID)
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
