<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario3
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
        Me.btnPreencher = New System.Windows.Forms.Button()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.txtSelecao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(32, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(211, 180)
        Me.ListBox1.TabIndex = 0
        '
        'btnPreencher
        '
        Me.btnPreencher.Location = New System.Drawing.Point(280, 32)
        Me.btnPreencher.Name = "btnPreencher"
        Me.btnPreencher.Size = New System.Drawing.Size(110, 34)
        Me.btnPreencher.TabIndex = 1
        Me.btnPreencher.Text = "Preencher"
        Me.btnPreencher.UseVisualStyleBackColor = True
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(280, 82)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(110, 35)
        Me.btnExibir.TabIndex = 2
        Me.btnExibir.Text = "Exibir Seleção"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'txtSelecao
        '
        Me.txtSelecao.Enabled = False
        Me.txtSelecao.Location = New System.Drawing.Point(280, 142)
        Me.txtSelecao.Name = "txtSelecao"
        Me.txtSelecao.Size = New System.Drawing.Size(136, 22)
        Me.txtSelecao.TabIndex = 3
        '
        'Formulario3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 252)
        Me.Controls.Add(Me.txtSelecao)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.btnPreencher)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Formulario3"
        Me.Text = "Lista de Employers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnPreencher As Button
    Friend WithEvents btnExibir As Button
    Friend WithEvents txtSelecao As TextBox
End Class
