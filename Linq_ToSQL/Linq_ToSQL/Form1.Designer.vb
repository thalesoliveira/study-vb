<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gdvProdutos = New System.Windows.Forms.DataGridView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gdvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(6, 33)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(25, 17)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(6, 78)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 17)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "NOME:"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Location = New System.Drawing.Point(6, 123)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(60, 17)
        Me.lblPreco.TabIndex = 2
        Me.lblPreco.Text = "PREÇO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpar)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.txt_preco)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.lblPreco)
        Me.GroupBox1.Controls.Add(Me.lblNome)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 198)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produto"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(316, 25)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(112, 38)
        Me.btnLimpar.TabIndex = 7
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(186, 25)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(124, 38)
        Me.btnPesquisar.TabIndex = 6
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(72, 123)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(223, 22)
        Me.txt_preco.TabIndex = 5
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(72, 75)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(402, 22)
        Me.txt_nome.TabIndex = 4
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(72, 33)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(72, 22)
        Me.id.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gdvProdutos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 355)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRODUTOS"
        '
        'gdvProdutos
        '
        Me.gdvProdutos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gdvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvProdutos.Location = New System.Drawing.Point(13, 36)
        Me.gdvProdutos.Name = "gdvProdutos"
        Me.gdvProdutos.RowTemplate.Height = 24
        Me.gdvProdutos.Size = New System.Drawing.Size(527, 313)
        Me.gdvProdutos.TabIndex = 0
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(44, 240)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(116, 35)
        Me.btnNovo.TabIndex = 5
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(166, 240)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(119, 35)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(291, 240)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(113, 35)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(410, 240)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(118, 35)
        Me.btnExibir.TabIndex = 8
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 690)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Linq To SQL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gdvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblPreco As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gdvProdutos As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnExibir As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnLimpar As Button

End Class
