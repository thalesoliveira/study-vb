Public Class Calculadora
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSoma2.TextChanged, txtDiv2.TextChanged, txtMult2.TextChanged, txtSub2.TextChanged

    End Sub

    Private Sub btnIgualSoma_Click(sender As Object, e As EventArgs) Handles btnIgualSoma.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0

        Try
            valor1 = CInt(txtSoma1.Text)
            valor2 = CInt(txtSoma2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        txtResultadoSoma.Text = regras.Soma(valor1, valor2)
    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const COPYRIGHT As String = "Calculadora"
        lblaviso.Text = COPYRIGHT
    End Sub

    Private Sub txtSoma1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoma1.KeyPress, txtDiv1.KeyPress, txtMult1.KeyPress, txtSub1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSoma2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoma2.KeyPress, txtDiv2.KeyPress, txtMult2.KeyPress, txtSub2.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnIgualSubtracao_Click(sender As Object, e As EventArgs) Handles btnIgualSubtracao.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0

        Try
            valor1 = CInt(txtSub1.Text)
            valor2 = CInt(txtSub2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        txtResultadoSubtracao.Text = regras.Subtracao(valor1, valor2)
    End Sub

    Private Sub btnIgualMultiplicacao_Click(sender As Object, e As EventArgs) Handles btnIgualMultiplicacao.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0

        Try
            valor1 = CInt(txtMult1.Text)
            valor2 = CInt(txtMult2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        txtResultadoMultiplicacao.Text = regras.Multiplicacao(valor1, valor2)
    End Sub

    Private Sub btnIgualDivisao_Click(sender As Object, e As EventArgs) Handles btnIgualDivisao.Click
        Dim valor1 As Single = 0
        Dim valor2 As Single = 0

        Try
            valor1 = CSng(txtDiv1.Text)
            valor2 = CSng(txtDiv2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        txtResultadoDivisao.Text = regras.Divisao(valor1, valor2)
    End Sub
End Class
