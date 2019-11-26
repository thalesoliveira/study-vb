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
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.btnGravarDados = New System.Windows.Forms.Button()
        Me.btnCarregar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.lstFuncionarios = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(27, 35)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 17)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "CÓDIGO:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(27, 81)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 17)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "NOME:"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(27, 129)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(71, 17)
        Me.lblSalario.TabIndex = 2
        Me.lblSalario.Text = "SALÁRIO:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(100, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigo.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(100, 81)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(403, 22)
        Me.txtNome.TabIndex = 4
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(104, 129)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(104, 22)
        Me.txtSalario.TabIndex = 5
        '
        'btnGravarDados
        '
        Me.btnGravarDados.Location = New System.Drawing.Point(30, 188)
        Me.btnGravarDados.Name = "btnGravarDados"
        Me.btnGravarDados.Size = New System.Drawing.Size(142, 36)
        Me.btnGravarDados.TabIndex = 6
        Me.btnGravarDados.Text = "Incluir Dados"
        Me.btnGravarDados.UseVisualStyleBackColor = True
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(217, 33)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(75, 23)
        Me.btnCarregar.TabIndex = 7
        Me.btnCarregar.Text = "Procurar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(198, 188)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(126, 36)
        Me.btnListar.TabIndex = 8
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'lstFuncionarios
        '
        Me.lstFuncionarios.FormattingEnabled = True
        Me.lstFuncionarios.ItemHeight = 16
        Me.lstFuncionarios.Location = New System.Drawing.Point(30, 280)
        Me.lstFuncionarios.Name = "lstFuncionarios"
        Me.lstFuncionarios.Size = New System.Drawing.Size(505, 228)
        Me.lstFuncionarios.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 533)
        Me.Controls.Add(Me.lstFuncionarios)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.btnGravarDados)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblSalario)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Form1"
        Me.Text = "CADASTRO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSalario As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents btnGravarDados As Button
    Friend WithEvents btnCarregar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents lstFuncionarios As ListBox
End Class
