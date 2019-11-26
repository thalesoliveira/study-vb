Imports System.Diagnostics.Process
Public Class formularioMenu


    Public Delegate Sub Mensagem(msg As String)

    Private Sub formularioMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showMenu()
        showApresentacao()
        showLogin()
    End Sub

    Private Sub showMenu()
        Dim formAcoes As New FormularioAcoes(New Mensagem(AddressOf Me.showSelecionado))
        formAcoes.MdiParent = Me
        formAcoes.Show()
        formAcoes.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub showApresentacao()
        My.Forms.FormularioApresentacao.ShowDialog()
    End Sub

    Private Sub showLogin()
        My.Forms.FormularioLogin.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim txtHora As Integer = Convert.ToInt32(DateTime.Now.Hour.ToString("00"))
        Dim txtTime As String = txtHora.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " AM"
        If txtHora > 12 Then
            txtHora = txtHora - 12
            txtTime = txtHora.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " PM"
        End If
        ToolStripStatusLabel4.Text = DateTime.Now.Date.ToLongDateString()
        ToolStripStatusLabel6.Text = txtTime
        Label1.Text = txtTime
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Start("calc.exe")
    End Sub

    Private Sub NavegadorInternetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavegadorInternetToolStripMenuItem.Click
        Start("http://www.google.com/")
    End Sub

    Private Sub GerenciadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciadorToolStripMenuItem.Click
        Start("taskmgr.exe")
    End Sub

    Private Sub ServiçosDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçosDoSistemaToolStripMenuItem.Click
        Start("services.msc")
    End Sub

    Private Sub LinhaDeComandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinhaDeComandoToolStripMenuItem.Click
        Start("cmd.exe", "C:")
    End Sub

    Private Sub showSelecionado(msg As String)
        If msg.Contains("Pedido") Then
            My.Forms.FormularioPedidos.ShowDialog()
        Else
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        My.Forms.AboutSobre.ShowDialog()
    End Sub
End Class
