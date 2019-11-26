Imports bll
Imports System.Data
Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class Form2

    Private paginaAtual As Integer = 1
    Private RelatorioTitulo As String
    Private listaDeContatos As New DataSet()


    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Dim nome As String = txtNome.Text
        Dim email As String = txtEmail.Text
        Dim sexo As String = Nothing

        If rbMasc.Checked = True Then
            sexo = "M"
        Else
            sexo = "F"
        End If

        Try
            ContatoBLL.incluirContato(nome, email, sexo)
            loadContatos()
        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        Dim codigo As Integer = Int32.Parse(txtCodigo.Text)
        Dim nome As String = txtNome.Text
        Dim email As String = txtEmail.Text
        Dim sexo As String = Nothing

        If rbMasc.Checked = True Then
            sexo = "M"
        Else
            sexo = "F"
        End If

        Try
            ContatoBLL.atualizarContato(codigo, nome, email, sexo)
            loadContatos()
        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim codigo As Integer = Int32.Parse(txtCodigo.Text)
        Try
            ContatoBLL.excluirContato(codigo)
            loadContatos()
        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadContatos()
    End Sub

    Private Sub loadContatos()
        Try
            dgrContatos.DataSource = ContatoBLL.listarContatos().Tables(0)
        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message)
        End Try

    End Sub

    Private Sub dgrContatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrContatos.CellClick
        If Not e.RowIndex = -1 Then
            txtCodigo.Text = dgrContatos.Rows(e.RowIndex).Cells(0).Value
            txtNome.Text = dgrContatos.Rows(e.RowIndex).Cells(1).Value
            txtEmail.Text = dgrContatos.Rows(e.RowIndex).Cells(2).Value

            If dgrContatos.Rows(e.RowIndex).Cells(3).Value = "M" Then
                rbMasc.Checked = True
                RbFem.Checked = False
            Else
                rbMasc.Checked = False
                RbFem.Checked = True
            End If

        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        RelatorioTitulo = "Relatório de Contatos - "

        'define os objetos printdocument e os eventos associados
        Dim printing As Printing.PrintDocument = New Printing.PrintDocument()

        ' Definindo 3 eventos para tratar a impressao
        AddHandler printing.PrintPage, New Printing.PrintPageEventHandler(AddressOf Me.printingContatos_PrintPage)
        AddHandler printing.BeginPrint, New Printing.PrintEventHandler(AddressOf Me.Begin_Print)
        AddHandler printing.EndPrint, New Printing.PrintEventHandler(AddressOf Me.End_Print)

        ' define o objeto para visualiza a impressao
        Dim objPrintPreview As New PrintPreviewDialog

        Try
            'define o form com maximizado e com zoom
            With objPrintPreview
                .Document = printing
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Relacao de contatos"
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub printingContatos_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        'Variaveis das linhas
        Dim LinhasPorPagina As Single = 0
        Dim PosicaoDaLinha As Single = 0
        Dim LinhaAtual As Integer = 0

        'Variaveis das margens ( e.MarginBounds obtém a área retangular que representa a parte da página dentro das margens.)
        Dim MargemEsquerda As Single = e.MarginBounds.Left
        Dim MargemSuperior As Single = e.MarginBounds.Top + 100
        Dim MargemDireita As Single = e.MarginBounds.Right
        Dim MargemInferior As Single = e.MarginBounds.Bottom

        'classe Pen define um objeto usado para definir linhas e curvas
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)


        Dim codigo As Integer
        Dim nome As String
        Dim email As String
        Dim sexo As String


        'Variaveis das fontes usadas (A classe Font define um formato específico para texto, incluindo face da fonte,
        'tamanho e atributos de estilo. 
        Dim FonteNegrito As Font
        Dim FonteTitulo As Font
        Dim FonteSubTitulo As Font
        Dim FonteRodape As Font
        Dim FonteNormal As Font

        'define efeitos em fontes usados
        FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
        FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
        FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
        FonteRodape = New Font("Arial", 8)
        FonteNormal = New Font("Arial", 9)

        'define valores para linha atual e para linha da impressao
        LinhaAtual = 0

        'Cabecalho -------------------
        'DrawLine - Desenha uma linha que conecta os dois pontos especificados pelos pares coordenados.
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)

        'nome da empresa---------------
        e.Graphics.DrawString(My.Settings.Empresa, FonteTitulo, Brushes.Blue, MargemEsquerda + 250, 80, New StringFormat())

        'Imprimir imagem (logotipo) --------------------
        'e.Graphics.DrawImage(Image.FromFile("C:\dados\" & "maco10.gif"), 100, 68)

        'imprime o titulo do relatório
        e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today, FonteSubTitulo, Brushes.Black, MargemEsquerda + 250, 120, New StringFormat())

        'campos a serem impressos: Codigo, Nome, Cidade e Telefone
        e.Graphics.DrawString("Código", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat())
        e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 170, New StringFormat())
        e.Graphics.DrawString("Email", FonteNegrito, Brushes.Black, MargemEsquerda + 340, 170, New StringFormat())
        e.Graphics.DrawString("Sexo", FonteNegrito, Brushes.Black, MargemEsquerda + 500, 170, New StringFormat())

        'imprime linha
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)

        'define o número de linhas por pagina
        LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

        'Aqui sao lidos os dados a tabela e a impressão é feita

        For Each dr In listaDeContatos.Tables(0).Rows

                'obtem os valores do datareader
                codigo = dr(0).ToString()
                nome = dr(1).ToString()
                email = dr(2).ToString()
                sexo = dr(3).ToString()

            'inicia a impressao - define a posição da linha e a posição de impressao
            PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(nome.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 100, PosicaoDaLinha, New StringFormat())
                e.Graphics.DrawString(email.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 340, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(sexo.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 500, PosicaoDaLinha, New StringFormat())

            'incrementa linha
            LinhaAtual += 1

        Next dr

            'imprime o Rodape
            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
        e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())

        LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
        LinhaAtual += 1
        e.Graphics.DrawString("Página : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())

        'Incrementa o n£mero da pagina
        paginaAtual += 1

        ''verifica se continua imprimindo
        'If (LinhaAtual > LinhasPorPagina) Then
        '    e.HasMorePages = True
        'Else
        '    e.HasMorePages = False
        'End If  

    End Sub

    Private Sub Begin_Print(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        paginaAtual = 1
        listaDeContatos = ContatoBLL.retornarContatos()
    End Sub


    Private Sub End_Print(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)
        paginaAtual = 1
    End Sub
End Class