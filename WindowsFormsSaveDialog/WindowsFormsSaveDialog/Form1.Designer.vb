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
        Me.sfd1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sfd1
        '
        Me.sfd1.DefaultExt = "txt"
        Me.sfd1.Filter = "Arquivos Textos |*.txt"
        Me.sfd1.InitialDirectory = "d:\Downloads"
        Me.sfd1.Title = "Arquivos_2019"
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(12, 35)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(433, 275)
        Me.txtTexto.TabIndex = 0
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(13, 331)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(131, 33)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar (OpenFile)"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(166, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Salvar (FileOk)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(294, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Salvar(source)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 394)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "Form1"
        Me.Text = "SaveFileDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sfd1 As SaveFileDialog
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
