Public Class Formulario5
    Private Sub Formulario5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwndDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.NorthwndDataSet.Categories)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        procurarNaCombo()
    End Sub
    Private Sub procurarNaCombo()
        Dim resultado As Integer = -1

        If txtProcura.Text <> String.Empty Then

            resultado = cboCategoria.FindStringExact(txtProcura.Text)
            ' FindStringExact retorna -1 se nada for encontrado
            If resultado <> -1 Then
                cboCategoria.SelectedIndex = resultado
                MessageBox.Show(" O texto " & txtProcura.Text & " foi encontrada na posição " & resultado)
            Else
                MessageBox.Show("O Texto não foi localizada na combo")
            End If


        End If


    End Sub

    Private Sub cboCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategoria.KeyPress
        cboCategoria.DroppedDown = True
    End Sub
End Class