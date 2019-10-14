Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.CadastroDataSet.Clientes)
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CadastroDataSet)

    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CadastroDataSet)

    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        My.Forms.Form2.Show()
    End Sub
End Class
