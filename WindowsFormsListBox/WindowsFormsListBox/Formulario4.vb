Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Public Class Formulario4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("northwndConnectionString").ConnectionString
        Dim sql As String = "SELECT * FROM Employees"

        Dim dtb As New DataTable
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using dad As New SqlDataAdapter(sql, conn)
                dad.Fill(dtb)
            End Using
            conn.Close()
        End Using

        Dim linha As DataRow
        For Each linha In dtb.Rows
            ListBox1.Items.Add(linha("EmployeeID") & " : " & linha("FirstName"))
        Next
    End Sub
End Class