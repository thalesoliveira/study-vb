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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.dgrContatos = New System.Windows.Forms.DataGridView()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.rbMasc = New System.Windows.Forms.RadioButton()
        Me.RbFem = New System.Windows.Forms.RadioButton()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgrContatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(13, 48)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 17)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "CÓDIGO:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(13, 78)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 17)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "NOME:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(80, 48)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigo.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(80, 78)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(523, 22)
        Me.txtNome.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 112)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 17)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "EMAIL:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(12, 148)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(50, 17)
        Me.lblSexo.TabIndex = 5
        Me.lblSexo.Text = "SEXO:"
        '
        'dgrContatos
        '
        Me.dgrContatos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgrContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrContatos.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgrContatos.Location = New System.Drawing.Point(16, 196)
        Me.dgrContatos.Name = "dgrContatos"
        Me.dgrContatos.RowTemplate.Height = 24
        Me.dgrContatos.Size = New System.Drawing.Size(587, 211)
        Me.dgrContatos.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(80, 112)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(409, 22)
        Me.txtEmail.TabIndex = 7
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(15, 431)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(101, 36)
        Me.btnIncluir.TabIndex = 9
        Me.btnIncluir.Text = "INCLUIR"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(141, 431)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(106, 35)
        Me.btnAlterar.TabIndex = 10
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(275, 431)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(99, 36)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(520, 431)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(96, 35)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "SAIR"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'rbMasc
        '
        Me.rbMasc.AutoSize = True
        Me.rbMasc.Checked = True
        Me.rbMasc.Location = New System.Drawing.Point(80, 148)
        Me.rbMasc.Name = "rbMasc"
        Me.rbMasc.Size = New System.Drawing.Size(92, 21)
        Me.rbMasc.TabIndex = 13
        Me.rbMasc.TabStop = True
        Me.rbMasc.Text = "Masculino"
        Me.rbMasc.UseVisualStyleBackColor = True
        '
        'RbFem
        '
        Me.RbFem.AutoSize = True
        Me.RbFem.Location = New System.Drawing.Point(189, 148)
        Me.RbFem.Name = "RbFem"
        Me.RbFem.Size = New System.Drawing.Size(86, 21)
        Me.RbFem.TabIndex = 14
        Me.RbFem.Text = "Feminino"
        Me.RbFem.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(189, 47)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 15
        Me.btnPesquisar.Text = "..."
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(395, 431)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(101, 36)
        Me.btnImprimir.TabIndex = 16
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(628, 479)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.RbFem)
        Me.Controls.Add(Me.rbMasc)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.dgrContatos)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Form2"
        Me.Text = "CONTATOS"
        CType(Me.dgrContatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents dgrContatos As DataGridView
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents rbMasc As RadioButton
    Friend WithEvents RbFem As RadioButton
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnImprimir As Button
End Class
