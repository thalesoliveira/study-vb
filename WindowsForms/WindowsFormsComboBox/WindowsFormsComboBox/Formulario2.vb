Public Class Formulario2
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim contador As Integer = cboEstacao.Items.Count
        If txtItem.Text <> String.Empty Then
            cboEstacao.Items.Insert(contador, txtItem.Text)
        Else
            cboEstacao.Items.Insert(contador, "Item " + contador.ToString)
        End If
        txtItem.Text = ""
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        cboEstacao.Items.Clear()
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        cboEstacao.Items.Remove(cboEstacao.SelectedItem)
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        cboEstacao.Sorted = True
    End Sub

    Private Sub Formulario2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEstacao.Items.Add("Verão")
        cboEstacao.Items.Add("Inverno")
        cboEstacao.Items.Add("Outono")
        cboEstacao.Items.Add("Primavera")
    End Sub
End Class