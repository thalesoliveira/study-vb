<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipe
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
        Me.grdEquipe = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        CType(Me.grdEquipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdEquipe
        '
        Me.grdEquipe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grdEquipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEquipe.Location = New System.Drawing.Point(12, 132)
        Me.grdEquipe.Name = "grdEquipe"
        Me.grdEquipe.RowTemplate.Height = 24
        Me.grdEquipe.Size = New System.Drawing.Size(934, 286)
        Me.grdEquipe.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(123, 30)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(107, 22)
        Me.codigo.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(123, 63)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(566, 22)
        Me.txtNome.TabIndex = 2
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(123, 102)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(691, 22)
        Me.txtCidade.TabIndex = 3
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(13, 442)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(115, 35)
        Me.btnListar.TabIndex = 4
        Me.btnListar.Text = "LISTAR"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(158, 442)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(113, 35)
        Me.btnSelecionar.TabIndex = 5
        Me.btnSelecionar.Text = "SELECIONAR"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(300, 442)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(116, 35)
        Me.btnIncluir.TabIndex = 6
        Me.btnIncluir.Text = "INCLUIR"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(8, 30)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(82, 20)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Text = "CÓDIGO:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(8, 63)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(64, 20)
        Me.lblNome.TabIndex = 9
        Me.lblNome.Text = "NOME:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(8, 102)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(78, 20)
        Me.lblEndereco.TabIndex = 10
        Me.lblEndereco.Text = "CIDADE:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(598, 441)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(117, 36)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(448, 441)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(116, 36)
        Me.btnAtualizar.TabIndex = 12
        Me.btnAtualizar.Text = "ATUALIZAR"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'frmEquipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(958, 489)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.grdEquipe)
        Me.Name = "frmEquipe"
        Me.Text = "Cadastro de Equipe"
        CType(Me.grdEquipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdEquipe As DataGridView
    Friend WithEvents codigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents btnListar As Button
    Friend WithEvents btnSelecionar As Button
    Friend WithEvents btnIncluir As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAtualizar As Button
End Class
