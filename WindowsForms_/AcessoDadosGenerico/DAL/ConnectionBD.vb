Imports System.Configuration

Public Class ConnectionBD

    Shared _connectionString As String
    Shared _providerName As String


    Public Shared Sub getAccess(ByVal accessType As String)

        Try
            Select Case accessType
                Case "MySQL"
                    _connectionString = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ConnectionString
                    _providerName = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ProviderName
                Case "SQLServer"
                    _connectionString = ConfigurationManager.ConnectionStrings("SQLServerConnectionString").ConnectionString
                    _providerName = ConfigurationManager.ConnectionStrings("SQLServerConnectionString").ProviderName
            End Select
        Catch ex As Exception
            Throw New Exception("Erro ao acessar a string de conexão.")
        End Try
    End Sub

    Public Shared Function getConnectString() As String
        Return _connectionString
    End Function

    Public Shared Function getProviderName() As String
        Return _providerName
    End Function



End Class
