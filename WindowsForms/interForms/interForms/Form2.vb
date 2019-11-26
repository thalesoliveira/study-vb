Public Class Form2
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwndDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwndDataSet.Orders' table. You can move, or remove it, as needed.
        'Me.OrdersTableAdapter.Fill(Me.NorthwndDataSet.Orders)
    End Sub


    Friend Sub carregaPedidos(ByVal customerId As String)
        Me.OrdersTableAdapter.FillByCustomerID(NorthwndDataSet.Orders, customerId)
    End Sub


End Class