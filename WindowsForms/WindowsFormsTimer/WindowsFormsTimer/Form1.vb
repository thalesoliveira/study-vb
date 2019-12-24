Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl1.Text = DateTime.Now.ToLongTimeString()
        ProgressBar1.Value += 5
        lbl2.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
        End If

    End Sub


    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Timer1.Interval = 1000
        'Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        'Timer1.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub btnResetar_Click(sender As Object, e As EventArgs) Handles btnResetar.Click
        Timer1.Stop()
    End Sub
End Class
