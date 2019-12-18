Public Class Form1
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        For i = 0 To 500 Step 50
            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
                Exit For
            Else
                txtNumero.Text = i.ToString()
                BackgroundWorker1.ReportProgress(i)
                System.Threading.Thread.Sleep(1000)
            End If
        Next
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Operação Finalizada com sucesso!!")
        txtNumero.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BackgroundWorker1.CancelAsync()
        BackgroundWorker1.Dispose()
    End Sub
End Class
