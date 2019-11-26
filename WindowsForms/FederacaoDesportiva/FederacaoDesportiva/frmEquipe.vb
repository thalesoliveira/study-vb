Imports System.Data.SqlClient

Public Class frmEquipe
    Private Sub frmEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listarEquipes()
    End Sub

    Private Sub listarEquipes()

        Dim conexao As SqlConnection = New SqlConnection(My.Settings.federacaoDesportivaConnectionString)
        conexao.Open()

        Try
            Dim command As SqlCommand = New SqlCommand("spListarEquipe", conexao)

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim equipes As DataTable = New DataTable

            adapter.Fill(equipes)

            grdEquipe.DataSource = equipes

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexao.Close()
        End Try


    End Sub

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        If codigo.Text = "" Then
            MessageBox.Show("Informe um valor!",
            "Important Note",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
        Else
            selecionarEquipe()
        End If

    End Sub

    Private Sub selecionarEquipe()

        Dim conexao As SqlConnection = New SqlConnection(My.Settings.federacaoDesportivaConnectionString)
        conexao.Open()

        Try
            Dim command As SqlCommand = New SqlCommand("spPesquisaEquipe", conexao)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@id", CType(codigo.Text, Integer))

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim equipe As DataTable = New DataTable

            adapter.Fill(equipe)

            grdEquipe.DataSource = equipe

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexao.Close()
        End Try

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        If Not txtNome.Text = "" Then
            incluirEquipe()
        Else
            MessageBox.Show("Informe um Nome!",
           "Important Note",
           MessageBoxButtons.OK,
           MessageBoxIcon.Exclamation,
           MessageBoxDefaultButton.Button1)
        End If

    End Sub
    Private Sub incluirEquipe()

        Dim conexao As SqlConnection = New SqlConnection(My.Settings.federacaoDesportivaConnectionString)
        conexao.Open()

        Try
            Dim command As SqlCommand = New SqlCommand("spIncluirEquipe", conexao)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@nome", txtNome.Text)
            command.Parameters.AddWithValue("@cidade", txtCidade.Text)

            command.ExecuteNonQuery()

            listarEquipes()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexao.Close()
        End Try

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim conexao As SqlConnection = New SqlConnection(My.Settings.federacaoDesportivaConnectionString)
        conexao.Open()

        Try
            Dim command As SqlCommand = New SqlCommand("spAtualizarEquipe", conexao)
            command.CommandType = CommandType.StoredProcedure

            Dim txtName As New SqlParameter("@nome", SqlDbType.VarChar, 50)
            txtName.Value = txtNome.Text
            command.Parameters.Add(txtName)

            command.Parameters.AddWithValue("@cidade", txtCidade.Text)
            command.Parameters.Add("@id", SqlDbType.Int).Value = codigo.Text

            command.ExecuteNonQuery()

            listarEquipes()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Excluir Equipe", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim conexao As SqlConnection = New SqlConnection(My.Settings.federacaoDesportivaConnectionString)
            conexao.Open()

            Try
                Dim command As SqlCommand = New SqlCommand("spExcluirEquipe", conexao)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add("@id", SqlDbType.Int).Value = codigo.Text

                command.ExecuteNonQuery()

                listarEquipes()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conexao.Close()
            End Try
        End If

    End Sub
End Class

