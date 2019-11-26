<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSelecionado = New System.Windows.Forms.TextBox()
        Me.btnPreencher = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnContarItens = New System.Windows.Forms.Button()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(29, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(241, 196)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECIONADO:"
        '
        'txtSelecionado
        '
        Me.txtSelecionado.Location = New System.Drawing.Point(145, 280)
        Me.txtSelecionado.Name = "txtSelecionado"
        Me.txtSelecionado.Size = New System.Drawing.Size(224, 22)
        Me.txtSelecionado.TabIndex = 2
        '
        'btnPreencher
        '
        Me.btnPreencher.Location = New System.Drawing.Point(295, 56)
        Me.btnPreencher.Name = "btnPreencher"
        Me.btnPreencher.Size = New System.Drawing.Size(110, 33)
        Me.btnPreencher.TabIndex = 3
        Me.btnPreencher.Text = "Preencher"
        Me.btnPreencher.UseVisualStyleBackColor = True
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(295, 113)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(110, 34)
        Me.btnOrdenar.TabIndex = 4
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(295, 166)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(110, 34)
        Me.btnLimpar.TabIndex = 5
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnContarItens
        '
        Me.btnContarItens.Location = New System.Drawing.Point(32, 324)
        Me.btnContarItens.Name = "btnContarItens"
        Me.btnContarItens.Size = New System.Drawing.Size(107, 34)
        Me.btnContarItens.TabIndex = 6
        Me.btnContarItens.Text = "Contar Itens"
        Me.btnContarItens.UseVisualStyleBackColor = True
        '
        'txtContador
        '
        Me.txtContador.Location = New System.Drawing.Point(145, 330)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(93, 22)
        Me.txtContador.TabIndex = 8
        '
        'Formulario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 389)
        Me.Controls.Add(Me.txtContador)
        Me.Controls.Add(Me.btnContarItens)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnPreencher)
        Me.Controls.Add(Me.txtSelecionado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Formulario2"
        Me.Text = "Lista de Atividades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSelecionado As TextBox
    Friend WithEvents btnPreencher As Button
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnContarItens As Button
    Friend WithEvents txtContador As TextBox
End Class
