Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim stream As Stream = Nothing
        If sfd1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            stream = sfd1.OpenFile()

            Using sw As StreamWriter = New StreamWriter(stream)
                sw.Write(txtTexto.Text)
            End Using
            stream.Close()
        Else
            MessageBox.Show("Cancel")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sfd1.ShowDialog()
    End Sub

    Private Sub sfd1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd1.FileOk
        Dim txtArquivoName As String = sfd1.FileName

        Try
            File.WriteAllText(txtArquivoName, txtTexto.Text)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sfd2 As New SaveFileDialog

        With sfd2
            .Title = "Selecionar Arquivos"
            .Filter = "Arquivos Texto|*.txt"
            .FileName = "Ano_" + DateTime.Now.ToString("ddMMyyyHHmmss")
            .DefaultExt = "txt"
            .InitialDirectory = "d:\Downloads"
            .RestoreDirectory = True
        End With

        Dim result As DialogResult = sfd2.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then

            My.Computer.FileSystem.WriteAllText(sfd2.FileName, txtTexto.Text, True)
        Else
            MessageBox.Show("Cancel")
        End If


    End Sub
End Class
