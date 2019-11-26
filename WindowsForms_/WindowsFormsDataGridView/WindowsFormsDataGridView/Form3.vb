
Imports WindowsFormsDataGridView.northwndDataSetTableAdapters
Public Class Form3
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim customersTableAdapter As New CustomersTableAdapter
        Dim bindingSource As New BindingSource

        bindingSource.DataSource = customersTableAdapter.GetData
        DataGridView1.DataSource = bindingSource

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
            MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        End If

    End Sub

    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwndDataSet)

    End Sub
End Class