Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic

Public Class DALGeneric

    Public Enum CommandsType
        ExecuteNonQuery
        ExecuteReader
        ExecuteScalar
        ExecuteDataTable
        ExecuteDataSet
    End Enum

    Public Shared Function createCommand(accessType As String, commandText As String, commandType As CommandType, listParameters As List(Of DbParameter)) As DbCommand

        ConnectionBD.getAccess(accessType)

        Try
            Dim objFactory = DbProviderFactories.GetFactory(ConnectionBD.getProviderName)
            Dim objConn = objFactory.CreateConnection

            objConn.ConnectionString = ConnectionBD.getConnectString

            Dim objCmd = objConn.CreateCommand

            objCmd.CommandText = commandText
            objCmd.CommandType = commandType

            If Not IsNothing(listParameters) Then
                For Each objParam In listParameters
                    objCmd.Parameters.Add(objParam)
                Next
            End If

            Return objCmd

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function createParameter(parameterName As String, parameterType As DbType, parameterValue As Object) As DbParameter
        Try
            Dim objFactory = DbProviderFactories.GetFactory(ConnectionBD.getProviderName)
            Dim objParam = objFactory.CreateParameter

            If Not IsNothing(objParam) Then
                objParam.ParameterName = parameterName
                objParam.DbType = parameterType
                objParam.Value = parameterValue

            End If

            Return objParam

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function executeCommand(accessType As String, commandText As String, commandType As CommandType, listParameters As List(Of DbParameter), commandsType As CommandsType) As Object

        Dim command = createCommand(accessType, commandText, commandType, listParameters)
        Dim result As Object = Nothing

        Try
            command.Connection.Open()

            Select Case commandsType
                Case CommandsType.ExecuteNonQuery
                    result = command.ExecuteNonQuery
                Case CommandsType.ExecuteReader
                    result = command.ExecuteReader
                Case CommandsType.ExecuteScalar
                    result = command.ExecuteScalar
                Case CommandsType.ExecuteDataTable
                    Dim table = New DataTable
                    Dim reader = command.ExecuteReader
                    table.Load(reader)
                    reader.Close()
                    result = table
                Case CommandsType.ExecuteDataSet
                    Dim oFactory = DbProviderFactories.GetFactory(ConnectionBD.getProviderName)
                    Dim da As DbDataAdapter = oFactory.CreateDataAdapter
                    command.CommandText = commandText
                    command.CommandType = commandType
                    da.SelectCommand = command
                    Dim ds As New DataSet
                    da.Fill(ds)
                    result = ds
            End Select
        Catch ex As Exception
            Throw ex
        Finally
            If Not commandType = CommandsType.ExecuteReader Then
                If command.Connection.State = ConnectionState.Open Then
                    command.Connection.Close()
                End If
                command.Connection.Dispose()
            End If
        End Try
        Return result
    End Function


End Class
