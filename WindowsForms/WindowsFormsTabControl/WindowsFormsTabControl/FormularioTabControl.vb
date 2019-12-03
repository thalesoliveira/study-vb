Public Class FormularioTabControl

    Private Sub FormularioTabControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)
        'TODO: This line of code loads data into the 'NorthwindDataSet._Region' table. You can move, or remove it, as needed.
        Me.RegionTableAdapter.Fill(Me.NorthwindDataSet._Region)
        'TODO: This line of code loads data into the 'NorthwindDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.NorthwindDataSet.Customers)

    End Sub

    Private Sub btnAddControl_Click(sender As Object, e As EventArgs) Handles btnAddControl.Click
        Dim button2 As New Button
        With button2
            .Name = "btnAdicionarControl"
            .Text = "Adionar Control"
            .BackColor = Color.Aqua
            .ForeColor = Color.Black
            .Width = 200
            .Height = 50
            .Location = New Point(50, 50)
            TabPage1.Controls.Add(button2)

        End With
    End Sub
End Class
