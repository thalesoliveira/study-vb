Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data


Public Class Formulario3
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selected As String
        If ListBox1.SelectedIndex <> -1 Then
            selected = ListBox1.SelectedItem.ToString()
            txtSelecao.Text = selected
        End If
    End Sub


    Private Sub btnPreencher_Click(sender As Object, e As EventArgs) Handles btnPreencher.Click

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("northwndConnectionString").ConnectionString
        Dim sql As String = "SELECT * FROM Employees"

        Dim conn As SqlConnection = New SqlConnection(connectionString)
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader

        conn.Open()

        dr = cmd.ExecuteReader()

        While dr.Read
            ListBox1.Items.Add(dr.Item("FirstName"))
        End While
        conn.Close()
    End Sub
End Class