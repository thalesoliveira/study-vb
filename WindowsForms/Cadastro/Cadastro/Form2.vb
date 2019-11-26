Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter1.Fill(Me.CadastroDataSet1.Clientes)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.BindingSource1.EndEdit()
        Me.ClientesTableAdapter1.Update(Me.CadastroDataSet1)
    End Sub
End Class