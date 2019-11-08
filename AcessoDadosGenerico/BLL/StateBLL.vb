Imports System.Data
Imports System.Collections.Generic
Imports DAL


Public Class StateBLL

    Public Shared Function getAllStateDS() As DataSet
        Dim ds = New DataSet
        Dim sql As String = "SELECT * FROM t_state"

        ds = DALGeneric.executeCommand("SQLServer", sql, CommandType.Text, Nothing, DALGeneric.CommandsType.ExecuteDataSet)
        Return ds
    End Function

    Public Shared Function getAllStateDT() As List(Of String)
        Dim sql = "SELECT * FROM t_state"
        Dim dt = New DataTable
        dt = DALGeneric.executeCommand("SQLServer", sql, CommandType.Text, Nothing, DALGeneric.CommandsType.ExecuteDataTable)
        Dim result As List(Of String) = New List(Of String)

        For Each item As DataRow In dt.Rows
            result.Add(item("state_name").ToString)
        Next

        Return result
    End Function


End Class
