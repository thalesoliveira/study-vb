Namespace domain
    Public Class Funcionario

        Private _codigo As Int32
        Private _nome As String
        Private _salario As Decimal

        Public Sub New()

        End Sub

        Public Overridable Property Codigo() As Int32
            Get
                Return _codigo
            End Get
            Set(value As Int32)
                _codigo = value
            End Set
        End Property

        Public Overridable Property Nome() As String
            Get
                Return _nome
            End Get
            Set(value As String)
                _nome = value
            End Set
        End Property

        Public Overridable Property Salario() As Decimal
            Get
                Return _salario
            End Get
            Set(value As Decimal)
                _salario = value
            End Set
        End Property

    End Class


End Namespace

