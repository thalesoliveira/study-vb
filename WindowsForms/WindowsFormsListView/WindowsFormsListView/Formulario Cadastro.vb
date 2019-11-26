Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim headerNome As ColumnHeader = ListView1.Columns.Add("Nome", 300, HorizontalAlignment.Left)
        Dim headerEmail As ColumnHeader = ListView1.Columns.Add("Email", 200, HorizontalAlignment.Left)

        With ListView1
            .GridLines = True
            .FullRowSelect = True
            .CheckBoxes = True
            .MultiSelect = True
            .HoverSelection = True
            .BackColor = Color.LightSalmon
        End With

        ListView1.Items.Add("VB.NET")
        ListView1.Items(0).SubItems.Add("www.microsoft.com")

        ListView1.Items.Add("Java")
        ListView1.Items(1).SubItems.Add("www.oracle.com")

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems(0).Selected Then
                txtNome.Text = ListView1.FocusedItem.SubItems(0).Text
                txtEmail.Text = ListView1.FocusedItem.SubItems(1).Text
            End If
        End If

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        If txtNome.Text <> "" And txtEmail.Text <> "" Then
            Dim itens As String() = {txtNome.Text, txtEmail.Text}
            Dim list As New ListViewItem(itens)
            ListView1.Items.Add(list)
            clearTextBoxes()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).Text = txtNome.Text
            ListView1.SelectedItems(0).SubItems(1).Text = txtEmail.Text
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If ListView1.SelectedItems.Count > 0 AndAlso MessageBox.Show("Confirma a exclusão do item?", "Confirma", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView1.SelectedItems(0).Remove()
            clearTextBoxes()
        End If
    End Sub

    Private Sub clearTextBoxes()
        txtNome.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        Dim item As ListViewItem = ListView1.FindItemWithText(txtNome.Text)

        If item IsNot Nothing Then
            ListView1.SelectedItems.Clear()
            item.Selected = True
            item.BackColor = Color.Yellow
        End If
    End Sub
End Class
