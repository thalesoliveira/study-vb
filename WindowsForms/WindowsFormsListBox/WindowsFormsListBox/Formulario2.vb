Public Class Formulario2
    Private Sub btnContarItens_Click(sender As Object, e As EventArgs) Handles btnContarItens.Click
        txtContador.Text = ListBox1.Items.Count
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txtSelecionado.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub btnPreencher_Click(sender As Object, e As EventArgs) Handles btnPreencher.Click
        ListBox1.Items.Add("Segunda-feira")
        ListBox1.Items.Add("Terça-feira")
        ListBox1.Items.Add("Quarta-feira")
        ListBox1.Items.Add("Quinta-feira")
        ListBox1.Items.Add("Sexta-feira")
        ListBox1.Items.Add("Sábado")
        ListBox1.Items.Add("Domingo")

    End Sub
End Class