Imports BLL
Public Class Form1

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dgvDados.DataSource = StateBLL.getAllStateDS().Tables(0)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
