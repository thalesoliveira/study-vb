Public Class Formulario1
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        listBoxEstados.Items.Clear()
        limparDados()

    End Sub

    Private Sub listBoxEstados_Click(sender As Object, e As EventArgs) Handles listBoxEstados.Click
        Dim index = listBoxEstados.SelectedIndex
        Dim item = listBoxEstados.SelectedItem
        Dim estado = listBoxEstados.Items.Item(listBoxEstados.SelectedIndex)

        TextBoxSelectedIndex.Text = index
        TextBoxSelectedItem.Text = item
        TextBoxItem.Text = estado

    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        listBoxEstados.Items.Remove(listBoxEstados.SelectedItem)
        limparDados()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) Handles btnAdicionarItem.Click
        listBoxEstados.Items.Add(TextBoxItemAdd.Text)
        listBoxEstados.SelectedIndex = listBoxEstados.SelectedIndex + 1
        limparDados()
        TextBoxItemAdd.Text = ""
    End Sub

    Private Sub btnExibirMulti_Click(sender As Object, e As EventArgs) Handles btnExibirMulti.Click
        Dim msg As String = ""
        If listBoxEstados.SelectedIndex <> -1 Then
            Dim item As Object
            'percorre os itens selecionados no listbox
            For Each item In listBoxEstados.SelectedItems
                msg &= item.ToString + vbCrLf + vbCrLf
            Next
            MessageBox.Show(msg)
        Else
            MessageBox.Show("Nenhum Estado Selecionado")
        End If
    End Sub

    Private Sub limparDados()
        TextBoxSelectedIndex.Text = ""
        TextBoxSelectedItem.Text = ""
        TextBoxItem.Text = ""
    End Sub
End Class