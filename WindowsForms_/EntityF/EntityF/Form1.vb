Imports EF_DAL

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using contexto = New northwndEntities
            Dim consulta = contexto.Customers.ToList
            CustomerBindingSource.DataSource = consulta
        End Using
    End Sub
End Class
