Public Class Formulario1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            txtFileName.Text = OpenFileDialog1.FileName
            If OpenFileDialog1.FileName <> "" Then
                pickImage.Image = System.Drawing.Bitmap.FromFile(txtFileName.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("O arquivo não pode ser aberto. Erro " & ex.Message)
        End Try
    End Sub
End Class