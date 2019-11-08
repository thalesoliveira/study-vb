Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class frmManterEstoque
    Dim connectionString As String = ""
    Dim conn As SqlConnection

    Private Sub frmManterEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'https://www.codeproject.com/Questions/221388/ConfigurationManager-Not-declared
        connectionString = ConfigurationManager.ConnectionStrings("EstoqueConnectionString").ConnectionString
        exibirProdutos()

    End Sub

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        exibirProdutos()
    End Sub

    Private Sub exibirProdutos()
        conn = New SqlConnection(connectionString)
        Dim sql As String = "SELECT * FROM Produtos"

        Try
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim da As SqlDataAdapter = New SqlDataAdapter
            Dim ds As DataSet = New DataSet

            da.SelectCommand = cmd
            da.Fill(ds)
            gdvProdutos.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        conn = New SqlConnection(connectionString)
        Dim sql As String = "INSERT INTO produtos (nome, preco) VALUES (@nome, @preco)"

        Try
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text)
            conn.Open()
            cmd.ExecuteNonQuery()

            MsgBox("Operação realizada com sucesso!")
            exibirProdutos()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        conn = New SqlConnection(connectionString)
        Dim sql As String = "UPDATE produtos SET nome=@nome, preco=@preco WHERE id = @id"

        Try
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", Int32.Parse(codigo.Text))
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Operação realizada com sucesso!")
            exibirProdutos()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        conn = New SqlConnection(connectionString)
        Dim sql As String = "DELETE produtos WHERE id = @id"

        Try
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", Int32.Parse(codigo.Text))
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Operação realizada com sucesso!")
            exibirProdutos()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub gdvProdutos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdvProdutos.CellClick
        Dim i As Integer
        i = gdvProdutos.CurrentRow.Index

        codigo.Text = gdvProdutos.Item(0, i).Value
        txtNome.Text = gdvProdutos.Item(1, i).Value
        txtPreco.Text = gdvProdutos.Item(2, i).Value

    End Sub
End Class
