Namespace DTO
    Public Class Produto

        Dim _id As Long
        Dim _nome As String
        Dim _preco As Decimal

        Property ID() As Long
            Get
                Return _id
            End Get
            Set(ByVal value As Long)
                _id = value
            End Set
        End Property

        Property NOME() As String
            Get
                Return _nome
            End Get
            Set(ByVal value As String)
                _nome = value
            End Set
        End Property

        Property PRECO() As Decimal
            Get
                Return _preco
            End Get
            Set(ByVal value As Decimal)
                _preco = value
            End Set
        End Property



    End Class
End Namespace
