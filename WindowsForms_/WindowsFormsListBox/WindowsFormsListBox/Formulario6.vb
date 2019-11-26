Public Class Formulario6
    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim msg As String = ""

        If ListBox1.SelectedIndex <> -1 Then
            Dim item As Object
            For Each item In ListBox1.SelectedItems
                Dim s1 As String = CType(item, DataRowView)(ListBox1.ValueMember).ToString()
                Dim s2 As String = CType(item, DataRowView)(ListBox1.DisplayMember).ToString()
                msg += "Valor :  " + s1 + vbCrLf + "Exibir :  " + s2 + vbCrLf + vbCrLf
            Next
            MessageBox.Show(msg)
        Else
            MessageBox.Show("Nenhum valor selecionado.")
        End If
    End Sub

    Private Sub Formulario6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwndDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.NorthwndDataSet.Categories)

    End Sub
End Class