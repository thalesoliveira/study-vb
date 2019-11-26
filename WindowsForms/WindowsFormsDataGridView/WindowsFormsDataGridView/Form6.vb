Imports System.Data.SqlClient
Imports System.Configuration

Public Class Form6

    Private Sub btnCarregarDados_Click(sender As Object, e As EventArgs) Handles btnCarregarDados.Click
        Dim sql As String = "SELECT * FROM customers"
        carregarDados(sql)
        FormataGrid()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContato.TextChanged
        Dim sql As String = "SELECT * FROM customers WHERE contactName LIKE '%" & txtContato.Text & "%'"
        carregarDados(sql)
    End Sub

    Private Sub carregarDados(ByVal sql As String)

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("northwndConnectionString").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connectionString)
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)

        Dim ds As DataSet = New DataSet()
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)

        Try
            conn.Open()
            da.Fill(ds, "clientes")
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FormataGrid()
        With DataGridView1
            .AutoGenerateColumns = False
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome da Empresa"
            .Columns(2).HeaderText = "Nome do Contato"
            .Columns(3).HeaderText = "Titulo"
            .Columns(4).HeaderText = "Endereço"
            .Columns(5).HeaderText = "Cidade"
            .Columns(6).HeaderText = "Região"
            .Columns(7).HeaderText = "Código Postal"
            .Columns(8).HeaderText = "País"
            .Columns(9).HeaderText = "Telefone"
            .Columns(10).HeaderText = "Fax"

            .Columns(0).Width = 60
            .Columns(1).Width = 170
            .Columns(2).Width = 170
            .Columns(3).Width = 120
            .Columns(4).Width = 170
            .Columns(5).Width = 100
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 120
            .Columns(9).Width = 120
            .Columns(10).Width = 120
            .Columns("CustomerId").Visible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            'alinhamento
            .Columns("Phone").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns("Fax").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        End With
    End Sub

    Private Sub btnOrdenarContato_Click(sender As Object, e As EventArgs) Handles btnOrdenarContato.Click
        DataGridView1.Sort(DataGridView1.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
End Class