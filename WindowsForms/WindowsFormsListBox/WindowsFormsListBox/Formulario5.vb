Public Class Formulario5

    Dim _items As New List(Of String)()

    Private Sub Formulario5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preencherLista()
    End Sub

    Private Sub preencherLista()

        _items.Add("Janeiro")
        _items.Add("Fevereiro")
        _items.Add("Março")
        _items.Add("Abril")
        _items.Add("Maio")
        _items.Add("Junho")

        ListBox1.DataSource = Nothing
        ListBox1.DataSource = _items
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        _items.Add(DateTime.Now.Second.ToString)
        ListBox1.DataSource = Nothing
        ListBox1.DataSource = _items
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim selectedIndex As Integer = ListBox1.SelectedIndex

        Try
            _items.RemoveAt(selectedIndex)
        Catch
        End Try

        ListBox1.DataSource = Nothing
        ListBox1.DataSource = _items
    End Sub
End Class