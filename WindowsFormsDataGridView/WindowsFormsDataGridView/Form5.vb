Imports System.Data.OleDb
Public Class Form5

    Dim conn As OleDbConnection
    Dim paginacaoAdapter As OleDbDataAdapter
    Dim paginacaoDS As DataSet
    Dim valorDeslocamento As Integer = 0
    Dim totalRegistro As Integer
    Dim range As Integer = 10


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database\northwind.mdb"
        Dim sql As String = "SELECT * FROM Products"
        Try
            Dim cmd As OleDbCommand = New OleDbCommand
            cmd.CommandText = "SELECT count(*) FROM Products"
            conn = New OleDbConnection(connectionString)
            conn.Open()

            cmd.Connection = conn
            totalRegistro = cmd.ExecuteScalar()

            paginacaoAdapter = New OleDbDataAdapter(sql, conn)
            paginacaoDS = New DataSet
            totalRegistro = nud1.Value
            paginacaoAdapter.Fill(paginacaoDS, valorDeslocamento, range, "produtos")
            DataGridView1.DataSource = paginacaoDS
            DataGridView1.DataMember = "produtos"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Try
            valorDeslocamento = valorDeslocamento - range
            If valorDeslocamento <= 0 Then
                valorDeslocamento = 0
            End If
            paginacaoDS.Clear()
            paginacaoAdapter.Fill(paginacaoDS, valorDeslocamento, range, "produtos")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        Try
            valorDeslocamento = valorDeslocamento + range
            If valorDeslocamento >= totalRegistro And totalRegistro > 0 Then
                valorDeslocamento = totalRegistro - range
            End If
            paginacaoDS.Clear()
            paginacaoAdapter.Fill(paginacaoDS, valorDeslocamento, range, "produtos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class