Public Class Formulario1
    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwndDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.NorthwndDataSet.Categories)

    End Sub

    Private Sub btnCarregarCombo_Click(sender As Object, e As EventArgs) Handles btnCarregarCombo.Click
        Dim cbo1 As New ComboBox()
        cbo1.Location = New Point(300, 50)
        cbo1.Size = New Size(200, 20)
        cbo1.DropDownWidth = 150
        Controls.Add(cbo1)
        cbo1.Items.Add("Item 1")
        cbo1.Items.Add("Item 2")
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        txtIndex.Text = cboCategoria.SelectedIndex
        txtItem.Text = cboCategoria.SelectedItem.ToString()
        txtValue.Text = cboCategoria.SelectedValue
    End Sub
End Class