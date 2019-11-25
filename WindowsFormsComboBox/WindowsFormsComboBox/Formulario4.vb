Public Class Formulario4
    Private Sub Formulario4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim meses() As String = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho"}

        cboMes.DataSource = meses

        Dim dias As New ArrayList()
        With dias
            .Add("Segunda")
            .Add("Terça")
            .Add("Quarta")
            .Add("Quinta")
            .Add("Sexta")
            .Add("Sabado")
            .Add("Domingo")
        End With
        cboSemana.DataSource = dias

        Dim dataTable As New DataTable
        dataTable.Columns.Add("Id", GetType(Integer))
        dataTable.Columns.Add("Nome", GetType(String))

        dataTable.Rows.Add(1, "Verão")
        dataTable.Rows.Add(2, "Inverno")
        dataTable.Rows.Add(3, "Outono")
        dataTable.Rows.Add(4, "Primavera")

        cboEstacao.DataSource = dataTable
        cboEstacao.DisplayMember = "Nome"
        cboEstacao.ValueMember = "Id"


    End Sub
End Class