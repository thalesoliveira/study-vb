Public Class Form1
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwndDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwndDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.NorthwndDataSet.Customers)

    End Sub

    Private Sub CustomersDataGridView_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomersDataGridView.CellContentClick

        Dim rowSelectedView As Data.DataRowView
        Dim rowSelected As northwndDataSet.CustomersRow

        rowSelectedView = CType(CustomersBindingSource.Current, System.Data.DataRowView)
        rowSelected = CType(rowSelectedView.Row, northwndDataSet.CustomersRow)

        Dim pedidos As New Form2
        pedidos.carregaPedidos(rowSelected.CustomerID)

        pedidos.Show()
    End Sub
End Class
