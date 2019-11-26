Public Class Form1

    Dim db As New EstoqueDataContext
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CategoryBindingSource.DataSource = db.Categories
    End Sub
End Class
