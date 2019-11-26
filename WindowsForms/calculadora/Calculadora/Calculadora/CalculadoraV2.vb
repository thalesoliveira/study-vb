Public Class CalculadoraV2

    Private operacao As Operacao

    Public Function Somar(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim operacao As New Soma

        operacao.Valor1 = val1
        operacao.Valor2 = val2
        Return operacao.Calcular
    End Function

    Public Function Subtrair(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim operacao As New Subtracao

        operacao.Valor1 = val1
        operacao.Valor2 = val2
        Return operacao.Calcular
    End Function

    Public Function Multiplicar(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim operacao As New Multiplicacao

        operacao.Valor1 = val1
        operacao.Valor2 = val2
        Return operacao.Calcular
    End Function

    Public Function Dividir(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim operacao As New Divisao

        operacao.Valor1 = val1
        operacao.Valor2 = val2
        Return operacao.Calcular
    End Function


End Class
