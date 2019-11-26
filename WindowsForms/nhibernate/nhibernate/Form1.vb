Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports Iesi.Collections
Imports System.Configuration
Imports hibernateProject.domain

Imports System
Imports System.Reflection

Public Class Form1
    Private Sub btnGravarDados_Click(sender As Object, e As EventArgs) Handles btnGravarDados.Click
        Dim config As New NHibernate.Cfg.Configuration

        config.AddAssembly("nhibernate")
        config.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider")
        config.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver")
        config.SetProperty("connection.connection_string", "Data Source=localhost;Initial Catalog=ldp;Persist Security Info=True;User ID=usr_ldp;Password=Abcd1234!!!")
        config.SetProperty("dialect", "NHibernate.Dialect.MsSql2008Dialect")

        'criando uma sessao e iniciando uma transação
        Dim factory As ISessionFactory = config.BuildSessionFactory
        Dim session As ISession = factory.OpenSession
        Dim transaction As ITransaction = session.BeginTransaction

        Dim funcionario As New funcionario

        funcionario.Codigo = Int32.Parse(txtCodigo.Text)
        funcionario.Nome = txtNome.Text
        funcionario.Salario = Int32.Parse(txtSalario.Text)

        Try
            session.Save(funcionario)

            'fecha a transação e a sessão
            transaction.Commit()
            session.Close()

            MsgBox("Cadastro realizado com sucesso.")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Dim config As New NHibernate.Cfg.Configuration
        config.AddAssembly("nhibernate")
        config.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider")
        config.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver")
        config.SetProperty("connection.connection_string", "Data Source=localhost;Initial Catalog=ldp;Persist Security Info=True;User ID=usr_ldp;Password=Abcd1234!!!")
        config.SetProperty("dialect", "NHibernate.Dialect.MsSql2008Dialect")

        Dim factory As ISessionFactory = config.BuildSessionFactory
        Dim session As ISession = factory.OpenSession
        Dim transaction As ITransaction = session.BeginTransaction

        Dim f As funcionario = DirectCast(session.Load(GetType(funcionario), 1), funcionario)

        txtCodigo.Text = f.Codigo
        txtNome.Text = f.Nome
        txtSalario.Text = f.Salario

        session.Flush()

        transaction.Commit()
        session.Close()

    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Try
            Dim config As New NHibernate.Cfg.Configuration


            config.AddAssembly("nhibernate")
            config.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider")
            config.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver")
            config.SetProperty("connection.connection_string", "Data Source=localhost;Initial Catalog=ldp;Persist Security Info=True;User ID=usr_ldp;Password=Abcd1234!!!")
            config.SetProperty("dialect", "NHibernate.Dialect.MsSql2008Dialect")

            'Dim factory As ISessionFactory = config.BuildSessionFactory
            'Dim session As ISession = factory.OpenSession
            'Dim transaction As ITransaction = session.BeginTransaction

            'Dim listaFuncionarios As IList = session.CreateCriteria(GetType(Funcionario)).List()

            'For Each f As Funcionario In listaFuncionarios
            'lstFuncionarios.Items.Add(f.Codigo & " - " & f.Nome & " - " & f.Salario)
            'Next

            'Transaction.Commit()
            'session.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
