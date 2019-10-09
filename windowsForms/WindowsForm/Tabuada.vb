Public Class Tabuada
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTabuada.Click
        Dim numeros As String = String.Empty

        If txtNumero.Text = "" Then
            MsgBox("Informe um número", MsgBoxStyle.Exclamation, "Alerta")

        Else
            For i As Integer = 1 To 10
                numeros = numeros & i & " X " & txtNumero.Text & " = " & (i * txtNumero.Text) & vbNewLine
            Next

            MsgBox(numeros, MsgBoxStyle.Information, "Tabuada")

        End If

    End Sub

    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click

        Dim cidades() As String = {"Brasilia", "Sao Paulo", "Belo Horizonte", "Florianopolis"}

        For Each cidade In cidades
            txtCidades.Text += cidade & vbNewLine
        Next

    End Sub
End Class