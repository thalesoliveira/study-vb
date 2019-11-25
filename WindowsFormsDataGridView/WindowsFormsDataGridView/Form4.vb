Public Class Form4
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwndDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwndDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.NorthwndDataSet.Order_Details)
        'TODO: This line of code loads data into the 'NorthwndDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.NorthwndDataSet.Orders)

    End Sub
End Class