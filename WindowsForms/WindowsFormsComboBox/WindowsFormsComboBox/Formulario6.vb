Imports System.Data.SqlClient
Imports System.Configuration
Public Class Formulario6
    Private Sub Formulario6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ConnectionStrings As String = ConfigurationManager.ConnectionStrings("northwndConnectionString").ConnectionString
            Dim conn As New SqlConnection(ConnectionStrings)
            conn.Open()
            Dim sql As String = "SELECT CategoryID, CategoryName FROM Categories"
            Dim cmd As New SqlCommand(sql, conn)
            Dim da As New SqlDataAdapter(sql, conn)
            Dim ds As New DataSet()
            conn.Close()
            da.Fill(ds)
            cboCategoria.DataSource = ds.Tables(0)
            cboCategoria.DisplayMember = "CategoryName"
            cboCategoria.ValueMember = "CategoryID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class