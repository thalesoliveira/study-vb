Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports DTO


Public Class AcessoDB

    Private Shared Function GetDbConnection() As OleDbConnection
        Try
            Dim conString As String = ConfigurationManager.ConnectionStrings("USRLDPString").ConnectionString
            Dim conn As OleDbConnection = New OleDbConnection(conString)
            conn.Open()
            Return conn

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overloads Shared Function GetDataTable(ByVal sql As String) As DataTable
        Using conn As OleDbConnection = GetDbConnection()
            Using da As New OleDbDataAdapter(sql, conn)
                Dim table As New DataTable
                da.Fill(table)
                Return table
            End Using
        End Using
    End Function

End Class
