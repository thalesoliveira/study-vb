Public Class FormularioPrincipal
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Preenchimento da lista com items, exibir multi-seleção e usar o evento click
        My.Forms.Formulario1.ShowDialog()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'Preenchimento de lista via código, trabalhando com SelectedIndexChanged
        My.Forms.Formulario2.ShowDialog()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'Trabalhando com DisplayMember e ValueMember
        My.Forms.Formulario3.ShowDialog()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        'Trabalhando com DataReader
        My.Forms.Formulario4.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        'Trabalhando com DataSource e RemoveAt
        My.Forms.Formulario5.ShowDialog()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        'Trabalhando com BindingSource/DataSource
        My.Forms.Formulario6.ShowDialog()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        'Trabalhando com FindString e FindStringExact
        My.Forms.Formulario7.ShowDialog()
    End Sub
End Class
