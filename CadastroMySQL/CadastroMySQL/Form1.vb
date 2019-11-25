Imports CadastroMySQL.BLL


Public Class Form1

    Dim produtoBLL As BLL.ProdutoBLL
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Try
            produtoBLL = New BLL.ProdutoBLL
            grvEstoque.DataSource = produtoBLL.selecionaProdutos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function exibirMsgSucesso()
        Return MsgBox("OPERAÇÃO REALIZADA COM SUCESSO!")
    End Function

    Private Function validarNome()
        Return MsgBox("INFORME O NOME DO PRODUTO")
    End Function

    Private Sub bntIncluir_Click(sender As Object, e As EventArgs) Handles bntIncluir.Click
        Try
            If txtNome.Text = String.Empty Then
                validarNome()
                Return
            End If

            Dim nome As String = txtNome.Text
            Dim preco As String = txtPreco.Text

            Dim produto As New DTO.Produto
            produto.NOME = nome
            produto.PRECO = preco

            produtoBLL = New BLL.ProdutoBLL
            produtoBLL.inserirProduto(produto)
            exibirMsgSucesso()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            If txtNome.Text = String.Empty Then
                validarNome()
                Return
            End If

            Dim id As Integer = Convert.ToInt32(codigo.Text)
            Dim nome As String = txtNome.Text
            Dim preco As String = txtPreco.Text

            Dim produto As New DTO.Produto
            produto.ID = id
            produto.NOME = nome
            produto.PRECO = preco

            produtoBLL = New BLL.ProdutoBLL
            produtoBLL.atualizarProduto(produto)
            exibirMsgSucesso()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If codigo.Text = String.Empty Then
                validarNome()
                Return
            End If

            Dim id As Integer = Convert.ToInt32(codigo.Text)

            Dim produto As New DTO.Produto
            produto.ID = id

            produtoBLL = New BLL.ProdutoBLL
            produtoBLL.excluirProduto(produto)
            exibirMsgSucesso()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        produtoBLL = New BLL.ProdutoBLL
        If codigo.Text = String.Empty Then
            validarNome()
            Return
        End If

        Dim id As Integer = Convert.ToInt32(codigo.Text)

        Dim produto As New DTO.Produto
        produto = produtoBLL.selecionaProdutoPorID(id)
        codigo.Text = produto.ID
        txtNome.Text = produto.NOME
        txtPreco.Text = produto.PRECO
    End Sub
End Class
