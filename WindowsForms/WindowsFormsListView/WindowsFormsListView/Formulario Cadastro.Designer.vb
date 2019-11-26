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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 151)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(488, 212)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(64, 24)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(288, 22)
        Me.txtNome.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(64, 62)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(285, 22)
        Me.txtEmail.TabIndex = 4
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(12, 101)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(104, 31)
        Me.btnIncluir.TabIndex = 5
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(137, 101)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(104, 31)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(272, 101)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(104, 31)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(401, 101)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(104, 31)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 387)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Formulario ListView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSair As Button
End Class
