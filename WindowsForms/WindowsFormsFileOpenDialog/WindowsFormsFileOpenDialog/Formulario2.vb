Public Class Formulario2

    Dim ofd1 As New OpenFileDialog

    Private Sub Formulario2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializaOpenFileDialog()
    End Sub

    Private Sub inicializaOpenFileDialog()

        ofd1.Title = "Selecionando imagens"
        ofd1.InitialDirectory = ""
        ofd1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        ofd1.FilterIndex = 1
        ofd1.FileName = "Selecione uma imagem"
        ofd1.Multiselect = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        If (dr = Windows.Forms.DialogResult.OK) Then

            Dim arquivo As String
            For Each arquivo In ofd1.FileNames

                Try
                    Dim pb As New PictureBox
                    pb.SizeMode = PictureBoxSizeMode.StretchImage
                    Dim imagemCarregada As Image = Image.FromFile(arquivo)
                    pb.Height = imagemCarregada.Height
                    pb.Width = imagemCarregada.Width
                    pb.Image = imagemCarregada
                    FlowLayoutPanel1.Controls.Add(pb)

                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro : " & ex.Message)
                End Try
            Next
        Else
            MessageBox.Show("A operação foi cancelada")
        End If
    End Sub


End Class