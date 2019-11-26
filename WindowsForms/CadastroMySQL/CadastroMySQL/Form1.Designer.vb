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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.grbEstoque = New System.Windows.Forms.GroupBox()
        Me.grvEstoque = New System.Windows.Forms.DataGridView()
        Me.bntIncluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.grbEstoque.SuspendLayout()
        CType(Me.grvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(13, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 17)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "CÓDIGO:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(13, 76)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 17)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "NOME:"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Location = New System.Drawing.Point(13, 126)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(60, 17)
        Me.lblPreco.TabIndex = 2
        Me.lblPreco.Text = "PRECO:"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(86, 27)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 22)
        Me.codigo.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(84, 76)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(378, 22)
        Me.txtNome.TabIndex = 4
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(86, 126)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(100, 22)
        Me.txtPreco.TabIndex = 5
        '
        'grbEstoque
        '
        Me.grbEstoque.Controls.Add(Me.grvEstoque)
        Me.grbEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEstoque.ForeColor = System.Drawing.Color.DarkRed
        Me.grbEstoque.Location = New System.Drawing.Point(12, 267)
        Me.grbEstoque.Name = "grbEstoque"
        Me.grbEstoque.Size = New System.Drawing.Size(446, 185)
        Me.grbEstoque.TabIndex = 6
        Me.grbEstoque.TabStop = False
        Me.grbEstoque.Text = "ESTOQUE"
        '
        'grvEstoque
        '
        Me.grvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvEstoque.Location = New System.Drawing.Point(7, 22)
        Me.grvEstoque.Name = "grvEstoque"
        Me.grvEstoque.RowTemplate.Height = 24
        Me.grvEstoque.Size = New System.Drawing.Size(439, 150)
        Me.grvEstoque.TabIndex = 0
        '
        'bntIncluir
        '
        Me.bntIncluir.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.bntIncluir.Location = New System.Drawing.Point(19, 192)
        Me.bntIncluir.Name = "bntIncluir"
        Me.bntIncluir.Size = New System.Drawing.Size(91, 36)
        Me.bntIncluir.TabIndex = 7
        Me.bntIncluir.Text = "INCLUIR"
        Me.bntIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(134, 192)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(90, 36)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(247, 190)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(94, 38)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(360, 190)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(98, 38)
        Me.btnExibir.TabIndex = 10
        Me.btnExibir.Text = "EXIBIR"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(192, 27)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(107, 23)
        Me.btnPesquisar.TabIndex = 11
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 473)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.bntIncluir)
        Me.Controls.Add(Me.grbEstoque)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "CADASTRO"
        Me.grbEstoque.ResumeLayout(False)
        CType(Me.grvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblPreco As Label
    Friend WithEvents codigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents grbEstoque As GroupBox
    Friend WithEvents grvEstoque As DataGridView
    Friend WithEvents bntIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnExibir As Button
    Friend WithEvents btnPesquisar As Button
End Class
