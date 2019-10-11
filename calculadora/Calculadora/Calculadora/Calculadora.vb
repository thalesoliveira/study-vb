Public Class Calculadora
    'Dim calc As Calculos

    Dim calc As CalculadoraV2

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const COPYRIGHT As String = "Calculadora"
        lblAviso.Text = COPYRIGHT
    End Sub

    Private Sub btnResultSoma_Click(sender As Object, e As EventArgs) Handles btnResultSoma.Click
        Dim val1 As Integer = 0
        Dim val2 As Integer = 0

        Try
            val1 = CInt(valSoma1.Text)
            val2 = CInt(valSoma2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        calc = New CalculadoraV2
        resultSoma.Text = calc.Somar(val1, val2)
    End Sub

    Private Sub btnResultSub_Click(sender As Object, e As EventArgs) Handles btnResultSub.Click
        Dim val1 As Integer = 0
        Dim val2 As Integer = 0

        Try
            val1 = CInt(valSub1.Text)
            val2 = CInt(valSub2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        calc = New CalculadoraV2
        resultSub.Text = calc.Subtrair(val1, val2)
    End Sub

    Private Sub btnResultMulti_Click(sender As Object, e As EventArgs) Handles btnResultMulti.Click
        Dim val1 As Integer = 0
        Dim val2 As Integer = 0

        Try
            val1 = CInt(valMult1.Text)
            val2 = CInt(valMult2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        calc = New CalculadoraV2
        resultMulti.Text = calc.Multiplicar(val1, val2)
    End Sub

    Private Sub btnResultDiv_Click(sender As Object, e As EventArgs) Handles btnResultDiv.Click
        Dim val1 As Single = 0
        Dim val2 As Single = 0

        Try
            val1 = CSng(valDiv1.Text)
            val2 = CSng(valDiv2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

        calc = New CalculadoraV2
        resultDiv.Text = calc.Dividir(val1, val2)
    End Sub

    Private Sub valSoma1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valSoma1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub valSub1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valSub1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub valMult1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valMult1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub valDiv1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valDiv1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub valSoma2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valSoma2.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub valSub2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valSub2.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub valMult2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valMult2.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub valDiv2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valDiv2.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
