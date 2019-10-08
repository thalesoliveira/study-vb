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
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.lblValor1 = New System.Windows.Forms.Label()
        Me.lblSoma = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblValor2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(12, 60)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(96, 22)
        Me.txtValor1.TabIndex = 0
        '
        'lblValor1
        '
        Me.lblValor1.AutoSize = True
        Me.lblValor1.Location = New System.Drawing.Point(12, 40)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(53, 17)
        Me.lblValor1.TabIndex = 1
        Me.lblValor1.Text = "Valor 1"
        '
        'lblSoma
        '
        Me.lblSoma.AutoSize = True
        Me.lblSoma.Location = New System.Drawing.Point(129, 63)
        Me.lblSoma.Name = "lblSoma"
        Me.lblSoma.Size = New System.Drawing.Size(16, 17)
        Me.lblSoma.TabIndex = 2
        Me.lblSoma.Text = "+"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(169, 60)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 22)
        Me.txtValor2.TabIndex = 3
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(300, 57)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(75, 23)
        Me.btnIgual.TabIndex = 4
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(415, 57)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 22)
        Me.txtResultado.TabIndex = 5
        '
        'lblValor2
        '
        Me.lblValor2.AutoSize = True
        Me.lblValor2.Location = New System.Drawing.Point(166, 40)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(53, 17)
        Me.lblValor2.TabIndex = 6
        Me.lblValor2.Text = "Valor 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 212)
        Me.Controls.Add(Me.lblValor2)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.lblSoma)
        Me.Controls.Add(Me.lblValor1)
        Me.Controls.Add(Me.txtValor1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents lblValor1 As Label
    Friend WithEvents lblSoma As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents btnIgual As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblValor2 As Label
End Class
