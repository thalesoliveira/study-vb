Module Calculos
    Public Function Soma(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim resultado As Integer
        resultado = val1 + val2
        Return resultado
    End Function

    Public Function Subtracao(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Return val1 - val2
    End Function

    Public Function Multiplicacao(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Return val1 * val2
    End Function

    Public Function Divisao(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Return val1 / val2
    End Function

End Module
