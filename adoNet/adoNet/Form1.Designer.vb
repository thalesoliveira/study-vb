<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManterEstoque
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(45, 45)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 17)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(45, 73)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 17)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "NOME:"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Location = New System.Drawing.Point(45, 104)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(60, 17)
        Me.lblPreco.TabIndex = 2
        Me.lblPreco.Text = "PREÇO:"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(126, 45)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(135, 22)
        Me.codigo.TabIndex = 3
        Me.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(126, 73)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(438, 22)
        Me.txtNome.TabIndex = 4
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(126, 101)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(220, 22)
        Me.txtPreco.TabIndex = 5
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(48, 166)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(97, 33)
        Me.btnExibir.TabIndex = 6
        Me.btnExibir.Text = "EXIBIR"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(169, 166)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(103, 33)
        Me.btnNovo.TabIndex = 7
        Me.btnNovo.Text = "NOVO"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(295, 166)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(101, 33)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(417, 166)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(104, 33)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(48, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(516, 240)
        Me.DataGridView1.TabIndex = 10
        '
        'frmManterEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 513)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmManterEstoque"
        Me.Text = "Manter Estoque"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblPreco As Label
    Friend WithEvents codigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents btnExibir As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnAlterar As Button
    Protected WithEvents btnExcluir As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
