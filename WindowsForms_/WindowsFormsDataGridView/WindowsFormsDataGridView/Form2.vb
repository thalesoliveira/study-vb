Imports WindowsFormsDataGridView.northwndDataSetTableAdapters

Public Class Form2
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim customersTableAdapter As New CustomersTableAdapter
        DataGridView1.DataSource = customersTableAdapter.GetData
    End Sub
End Class