<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario4
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
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cboSemana = New System.Windows.Forms.ComboBox()
        Me.cboEstacao = New System.Windows.Forms.ComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.lblEstacao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboMes
        '
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(149, 59)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(206, 24)
        Me.cboMes.TabIndex = 0
        '
        'cboSemana
        '
        Me.cboSemana.FormattingEnabled = True
        Me.cboSemana.Location = New System.Drawing.Point(149, 112)
        Me.cboSemana.Name = "cboSemana"
        Me.cboSemana.Size = New System.Drawing.Size(206, 24)
        Me.cboSemana.TabIndex = 1
        '
        'cboEstacao
        '
        Me.cboEstacao.FormattingEnabled = True
        Me.cboEstacao.Location = New System.Drawing.Point(149, 173)
        Me.cboEstacao.Name = "cboEstacao"
        Me.cboEstacao.Size = New System.Drawing.Size(206, 24)
        Me.cboEstacao.TabIndex = 2
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(24, 62)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(38, 17)
        Me.lblMes.TabIndex = 3
        Me.lblMes.Text = "Mês:"
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Location = New System.Drawing.Point(24, 112)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(109, 17)
        Me.lblSemana.TabIndex = 4
        Me.lblSemana.Text = "Dia da Semana:"
        '
        'lblEstacao
        '
        Me.lblEstacao.AutoSize = True
        Me.lblEstacao.Location = New System.Drawing.Point(24, 173)
        Me.lblEstacao.Name = "lblEstacao"
        Me.lblEstacao.Size = New System.Drawing.Size(119, 17)
        Me.lblEstacao.TabIndex = 5
        Me.lblEstacao.Text = "Estações do Ano:"
        '
        'Formulario4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 239)
        Me.Controls.Add(Me.lblEstacao)
        Me.Controls.Add(Me.lblSemana)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.cboEstacao)
        Me.Controls.Add(Me.cboSemana)
        Me.Controls.Add(Me.cboMes)
        Me.Name = "Formulario4"
        Me.Text = "Formulario4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboMes As ComboBox
    Friend WithEvents cboSemana As ComboBox
    Friend WithEvents cboEstacao As ComboBox
    Friend WithEvents lblMes As Label
    Friend WithEvents lblSemana As Label
    Friend WithEvents lblEstacao As Label
End Class
