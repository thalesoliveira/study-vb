Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic
Imports DAL
Imports System.Data.SqlClient

Public Class ContatoBLL
    Public Shared Function listarContatos() As DataSet
        Try
            Dim ds = New DataSet
            Dim cmd = "spListarContatos"
            ds = DALGeneric.executeCommand("MySQL", cmd, CommandType.StoredProcedure, Nothing, DALGeneric.CommandsType.ExecuteDataSet)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Sub incluirContato(ByVal _nome As String, ByVal _email As String, ByVal _sexo As String)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DALGeneric.createParameter("_nome", DbType.String, _nome))
        listaParametros.Add(DALGeneric.createParameter("_email", DbType.String, _email))
        listaParametros.Add(DALGeneric.createParameter("_sexo", DbType.String, _sexo))

        Try

            Dim cmd = "spIncluirContato"
            DALGeneric.executeCommand("MySQL", cmd, CommandType.StoredProcedure, listaParametros, DALGeneric.CommandsType.ExecuteNonQuery)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub atualizarContato(ByVal _codigo As Integer, ByVal _nome As String, ByVal _email As String, ByVal _sexo As String)

        Dim listaParametros As New List(Of DbParameter)

        listaParametros.Add(DALGeneric.createParameter("_id", DbType.Int32, _codigo))
        listaParametros.Add(DALGeneric.createParameter("_nome", DbType.String, _nome))
        listaParametros.Add(DALGeneric.createParameter("_email", DbType.String, _email))
        listaParametros.Add(DALGeneric.createParameter("_sexo", DbType.String, _sexo))

        Try

            Dim cmd = "spAtualizarContato"
            DALGeneric.executeCommand("MySQL", cmd, CommandType.StoredProcedure, listaParametros, DALGeneric.CommandsType.ExecuteNonQuery)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub excluirContato(ByVal _codigo As Integer)

        Dim listaParametros As New List(Of DbParameter)
        listaParametros.Add(DALGeneric.createParameter("_id", DbType.Int32, _codigo))

        Try

            Dim cmd = "spRemoverContato"
            DALGeneric.executeCommand("MySQL", cmd, CommandType.StoredProcedure, listaParametros, DALGeneric.CommandsType.ExecuteNonQuery)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function retornarContatos() As DataSet
        Try
            Dim ds As New DataSet()
            Dim cmd = "spListarContatos"
            ds = DALGeneric.executeCommand("MySQL", cmd, CommandType.StoredProcedure, Nothing, DALGeneric.CommandsType.ExecuteDataSet)

            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
