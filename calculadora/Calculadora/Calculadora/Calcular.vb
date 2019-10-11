Public Class Soma
    Inherits Operacao

    Public Overrides Function Calcular() As Integer
        Return MyBase.Valor1 + MyBase.Valor2
    End Function

End Class


Public Class Subtracao
    Inherits Operacao
    Public Overrides Function Calcular() As Integer
        Return MyBase.Valor1 - MyBase.Valor2
    End Function

End Class

Public Class Multiplicacao
    Inherits Operacao
    Public Overrides Function Calcular() As Integer
        Return MyBase.Valor1 * MyBase.Valor2
    End Function

End Class

Public Class Divisao
    Inherits Operacao
    Public Overrides Function Calcular() As Integer
        Return MyBase.Valor1 / MyBase.Valor2
    End Function
End Class



