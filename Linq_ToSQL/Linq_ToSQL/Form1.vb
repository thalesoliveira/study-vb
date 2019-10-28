Imports System.Data.Linq

Public Class Form1

    Dim dc As New EstoqueDataContext

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gdvProdutos.DataSource = exibirProdutos()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

    End Sub

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        gdvProdutos.DataSource = exibirProdutos()
    End Sub

    Private Function exibirProdutos() As Table(Of Produto)
        Dim produto As Table(Of Produto) = dc.GetTable(Of Produto)()
        Return produto
    End Function

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        If (txt_nome.Text.Equals("") Or txt_preco.Text = String.Empty) Then
            MsgBox("Informe o nome/preço !")
            Return
        Else
            incluirnovoproduto()
        End If
    End Sub

    Private Sub incluirnovoproduto()
        Dim produto As Table(Of Produto) = dc.GetTable(Of Produto)()

        Dim novo As Produto = New Produto With {.nome = txt_nome.Text, .preco = txt_preco.Text}
        produto.InsertOnSubmit(novo)
        dc.SubmitChanges()
        MsgBox("Inclusão de NOVO produto  efetuada com sucesso!")
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        alterarProduto(Int32.Parse(id.Text))
    End Sub

    Private Sub alterarProduto(ByVal id As Integer)

        Dim produto As Table(Of Produto) = dc.GetTable(Of Produto)()
        Dim prd = produto.SingleOrDefault(Function(p) p.Id = id)

        If Not prd Is Nothing Then
            prd.nome = txt_nome.Text
            prd.preco = txt_preco.Text

            dc.SubmitChanges()
        Else
            MsgBox("Produto não localizado")
        End If

    End Sub
End Class