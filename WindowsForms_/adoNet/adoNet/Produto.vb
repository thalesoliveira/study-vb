Namespace DTO
    Public Class Produto

        Dim _codigo As Long
        Dim _nome As String
        Dim _preco As Decimal

        Property Codigo() As Long
            Get
                Return _codigo
            End Get
            Set(ByVal value As Long)
                _codigo = value
            End Set
        End Property


        Property Nome() As String
            Get
                Return _nome
            End Get
            Set(ByVal value As String)
                _nome = value
            End Set
        End Property

        Property Preco() As Decimal
            Get
                Return _preco
            End Get
            Set(ByVal value As Decimal)
                _preco = value
            End Set
        End Property

    End Class

End Namespace
