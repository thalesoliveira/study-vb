Public Class Form2

    Friend codigoProduto As Integer
    Friend nomeProduto As String
    Friend precoProduto As Double


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VendasDs.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.VendasDs.Products)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, txtNome.TextChanged
        Me.ProductsTableAdapter.FillByNomeProduto(Me.VendasDs.Products, txtNome.Text & "%")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, DataGridView1.DoubleClick
        codigoProduto = Me.VendasDs.Products(ProductsBindingSource.Position).ProductID
        nomeProduto = Me.VendasDs.Products(ProductsBindingSource.Position).ProductName
        precoProduto = Me.VendasDs.Products(ProductsBindingSource.Position).UnitPrice

        Me.Close()

    End Sub
End Class