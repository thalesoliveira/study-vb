Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class frmManterEstoque
    Dim connectionString As String = ""
    Private Sub frmManterEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'https://www.codeproject.com/Questions/221388/ConfigurationManager-Not-declared
        connectionString = ConfigurationManager.ConnectionStrings("EstoqueConnectionString").ConnectionString

        exibirProdutos()

    End Sub

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        exibirProdutos()
    End Sub

    Private Sub exibirProdutos()
        exibirProdutos()
    End Sub

End Class
