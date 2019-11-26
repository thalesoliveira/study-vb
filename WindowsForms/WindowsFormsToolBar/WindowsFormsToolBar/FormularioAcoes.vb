Public Class FormularioAcoes

    Private selecionado As formularioMenu.Mensagem
    Public Sub New(selected As formularioMenu.Mensagem)

        ' This call is required by the designer.
        InitializeComponent()

        selecionado = selected
        ListView1.View = View.LargeIcon
        Dim item = ListView1.Items.Add("Pedidos", 0)
        item.ToolTipText = "Pedidos"
        item.Group = ListView1.Groups(0)
        item = ListView1.Items.Add("Compras", 3)
        item.ToolTipText = "Compras"
        item.Group = ListView1.Groups(0)
        item = ListView1.Items.Add("Orçamento", 4)
        item.Group = ListView1.Groups(0)
        item = ListView1.Items.Add("Remessas", 5)
        item.Group = ListView1.Groups(0)

        item = ListView1.Items.Add("Lista Itens", 1)
        item.Group = ListView1.Groups(2)
        item = ListView1.Items.Add("Detalhes", 1)
        item.Group = ListView1.Groups(2)

        item = ListView1.Items.Add("Distribuição", 2)
        item.Group = ListView1.Groups(1)

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        selecionado(ListView1.SelectedItems(0).Text)
    End Sub

    Private Sub FormularioAcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class