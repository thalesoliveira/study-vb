Public Class Form1
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        Dim watch = Stopwatch.StartNew
        Log("Start")

        For i As Integer = 0 To 500000000

        Next

        watch.Stop()
        Log("Stop")

        Dim tarefa1 As TimeSpan = watch.Elapsed
        Dim tempoTarefa1 As String = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(tarefa1.TotalHours), tarefa1.Minutes, tarefa1.Seconds, tarefa1.Milliseconds)

        Label1.Text = tempoTarefa1 + " s"
        ListBox1.Items.Add(tempoTarefa1)



        watch.Start()
        Log("Start")

        For i As Integer = 0 To 900000000

        Next

        watch.Stop()
        Log("Stop")

        Dim tarefa2 As TimeSpan = watch.Elapsed
        Dim tempoTarefa2 As String = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(tarefa2.TotalHours), tarefa2.Minutes, tarefa2.Seconds, tarefa2.Milliseconds)

        Label2.Text = tempoTarefa2 + " s"
        ListBox1.Items.Add(tempoTarefa2)


    End Sub

    Private Sub Log(msg As String)
        ListBox1.Items.Add(msg)
    End Sub
End Class
