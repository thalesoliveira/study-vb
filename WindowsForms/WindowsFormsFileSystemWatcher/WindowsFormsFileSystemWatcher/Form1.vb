Public Class Form1
    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        Try
            fbd1.ShowDialog()
            textProcurar.Text = fbd1.SelectedPath
            fsw1.Path = fbd1.SelectedPath
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub fsw1_Renamed(sender As Object, e As IO.RenamedEventArgs) Handles fsw1.Renamed
        Try
            lbRenomeados.Items.Add(e.FullPath.ToString & " - " & DateTime.Now)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub fsw1_Created(sender As Object, e As IO.FileSystemEventArgs) Handles fsw1.Created
        Try
            lbNovos.Items.Add(e.FullPath.ToString & " - " & DateTime.Now)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub fsw1_Deleted(sender As Object, e As IO.FileSystemEventArgs) Handles fsw1.Deleted
        Try
            lbRemovidos.Items.Add(e.FullPath.ToString & " - " & DateTime.Now)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub fsw1_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles fsw1.Changed
        Try
            lbAlterados.Items.Add(e.FullPath.ToString & " - " & DateTime.Now)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
