Imports System.Data.SqlClient
Imports System.Configuration

Public Class FormularioTreeView

    Dim conn As SqlConnection
    Dim daCategorias As SqlDataAdapter
    Dim daProdutos As SqlDataAdapter
    Dim ds As DataSet
    Dim dvProdutos As DataView


    Private Sub btnAddNo_Click(sender As Object, e As EventArgs) Handles btnAddNo.Click

        '1 Forma de adicionar no raiz
        Dim node As TreeNode = New TreeNode
        If txtNoRaiz.Text <> "" Then
            node.Text = txtNoRaiz.Text
            TreeView2.Nodes.Add(node)
            txtNoRaiz.Text = ""
        End If

        '2 Forma de adicionar no raiz
        'Dim node As TreeNode = New TreeNode(txtNoRaiz.Text)
        'TreeView2.Nodes.Add(node)

        '3 Forma de adicionar no raiz com AddRange
        'Dim arr() As TreeNode = {New TreeNode("No1"), New TreeNode("No2"), New TreeNode("No3"), New TreeNode("No4")}
        'TreeView2.Nodes.AddRange(arr)

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        TreeView2.Nodes.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With TreeView2
            .BeginUpdate()
            .Nodes.Add("Centro-Oeste")
            .Nodes(0).Nodes.Add("Goias")
            .Nodes(0).Nodes.Add("Distrito-Federal")
            .Nodes.Add("Sudeste")
            .Nodes(1).Nodes.Add("São Paulo")
            .Nodes.Add("Sul")
            .Nodes(2).Nodes.Add("Santa Catarina")
            .Nodes.Add("Nordeste")
            .Nodes(3).Nodes.Add("Ceará")
            .Nodes.Add("Norte")
            .Nodes(4).Nodes.Add("Amazonas")
            .EndUpdate()
        End With
    End Sub

    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandir.Click
        TreeView2.ExpandAll()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        TreeView2.CollapseAll()
    End Sub

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
        MessageBox.Show("FullPath: " & TreeView2.SelectedNode.FullPath & " Nome: " & TreeView2.SelectedNode.Text)
    End Sub

    Private Sub btnNoFilho_Click(sender As Object, e As EventArgs) Handles btnNoFilho.Click
        Dim node As TreeNode
        If Not TreeView2.SelectedNode Is Nothing And txtNoFilho.Text <> "" Then
            node = New TreeNode(txtNoFilho.Text)
            TreeView2.SelectedNode.Nodes.Add(node)
            txtNoFilho.Text = ""
        End If
    End Sub

    Private Sub btnExibirCategoriasProdutos_Click(sender As Object, e As EventArgs) Handles btnExibirCategoriasProdutos.Click
        Dim connectionString = ConfigurationManager.ConnectionStrings("northwndConnectionString").ConnectionString
        conn = New SqlConnection(connectionString)
        daCategorias = New SqlDataAdapter("SELECT * FROM categories", conn)
        daProdutos = New SqlDataAdapter("SELECT * FROM products", conn)

        ds = New DataSet

        Try
            'utilizados em memória
            daCategorias.Fill(ds, "categorias")
            daProdutos.Fill(ds, "produtos")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        dvProdutos = ds.Tables("produtos").DefaultView
        TreeView3.Nodes.Add("Categorias")

        Dim dr As DataRow
        Dim no As TreeNode

        For Each dr In ds.Tables("categorias").Rows
            Dim nomeCategoria = dr("CategoryName")
            no = TreeView3.Nodes(0).Nodes.Add(nomeCategoria, nomeCategoria, 0, 1)

            'atribuir produtos para cada categoria
            dvProdutos.RowFilter = "CategoryId = " & dr("CategoryId")

            Dim i As Integer
            For i = 0 To dvProdutos.Count - 1
                Dim nomeProduto = dvProdutos.Item(i).Row("ProductName")
                no.Nodes.Add(nomeProduto, nomeProduto, 0, 1)
            Next
        Next

    End Sub
End Class
