<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.gdvProduto = New System.Windows.Forms.DataGridView()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        CType(Me.gdvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gdvProduto
        '
        Me.gdvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvProduto.Location = New System.Drawing.Point(28, 258)
        Me.gdvProduto.Name = "gdvProduto"
        Me.gdvProduto.RowTemplate.Height = 24
        Me.gdvProduto.Size = New System.Drawing.Size(572, 150)
        Me.gdvProduto.TabIndex = 0
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(28, 197)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(122, 37)
        Me.btnExibir.TabIndex = 1
        Me.btnExibir.Text = "EXIBIR"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(177, 197)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(126, 37)
        Me.btnIncluir.TabIndex = 2
        Me.btnIncluir.Text = "INCLUIR"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(323, 197)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(123, 37)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(469, 197)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(131, 37)
        Me.btnExcluir.TabIndex = 4
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(39, 32)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 17)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "CÓDIGO:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(39, 77)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(152, 17)
        Me.lblNome.TabIndex = 6
        Me.lblNome.Text = "NOME DO PRODUTO:"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Location = New System.Drawing.Point(39, 122)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(60, 17)
        Me.lblPreco.TabIndex = 7
        Me.lblPreco.Text = "PRECO:"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(125, 32)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(107, 22)
        Me.codigo.TabIndex = 8
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(203, 77)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(397, 22)
        Me.txtNome.TabIndex = 9
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(105, 122)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(156, 22)
        Me.txtPreco.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 451)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.gdvProduto)
        Me.Name = "Form2"
        Me.Text = "Formulário de Cadastro"
        CType(Me.gdvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gdvProduto As DataGridView
    Friend WithEvents btnExibir As Button
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblPreco As Label
    Friend WithEvents codigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtPreco As TextBox
End Class
