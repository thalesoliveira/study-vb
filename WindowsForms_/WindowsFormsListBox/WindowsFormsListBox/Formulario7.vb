Public Class Formulario7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LocalizaTexto(txtProcurar.Text, 1)
    End Sub
    Private Sub LocalizaTexto(ByVal _texto As String, ByVal tipoPesquisa As Integer)
        Dim indice As Integer
        If _texto <> String.Empty Then

            If tipoPesquisa = 1 Then
                indice = ListBox1.FindString(_texto)
            Else
                indice = ListBox1.FindStringExact(_texto)
            End If

            If indice <> -1 Then
                ListBox1.SetSelected(indice, True)
            Else
                MessageBox.Show("Texto não localizado")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LocalizaTexto(txtProcurar.Text, 0)

    End Sub
End Class