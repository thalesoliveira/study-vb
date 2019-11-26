Imports System.IO
Public Class Formulario3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arquivo As StreamReader = Nothing

        Dim ofd1 As New OpenFileDialog

        ofd1.Title = "Selecionando arquivos"
        'ofd1.InitialDirectory = "C:\Dados\"
        ofd1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.* "
        ofd1.FilterIndex = 1
        ofd1.FileName = "Selecione uma arquivo"
        ofd1.Multiselect = False

        If ofd1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                arquivo = New StreamReader(ofd1.FileName)
                If (arquivo IsNot Nothing) Then
                    txtArquivoView.Text = ""
                    Using arquivo
                        Dim linha As String
                        linha = arquivo.ReadToEnd
                        txtArquivoView.Text += linha + vbCrLf
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("ocoreu um erro : " & ex.Message)
            End Try
        Else
            MessageBox.Show("a operação foi cancelada")
        End If

    End Sub
End Class