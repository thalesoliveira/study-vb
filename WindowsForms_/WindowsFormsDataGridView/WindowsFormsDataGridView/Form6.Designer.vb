<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCarregarDados = New System.Windows.Forms.Button()
        Me.txtContato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOrdenarContato = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1092, 423)
        Me.DataGridView1.TabIndex = 0
        '
        'btnCarregarDados
        '
        Me.btnCarregarDados.Location = New System.Drawing.Point(25, 12)
        Me.btnCarregarDados.Name = "btnCarregarDados"
        Me.btnCarregarDados.Size = New System.Drawing.Size(137, 35)
        Me.btnCarregarDados.TabIndex = 1
        Me.btnCarregarDados.Text = "Carregar Dados"
        Me.btnCarregarDados.UseVisualStyleBackColor = True
        '
        'txtContato
        '
        Me.txtContato.Location = New System.Drawing.Point(528, 19)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(589, 22)
        Me.txtContato.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Procurar Contato:"
        '
        'btnOrdenarContato
        '
        Me.btnOrdenarContato.Location = New System.Drawing.Point(185, 12)
        Me.btnOrdenarContato.Name = "btnOrdenarContato"
        Me.btnOrdenarContato.Size = New System.Drawing.Size(159, 35)
        Me.btnOrdenarContato.TabIndex = 4
        Me.btnOrdenarContato.Text = "Ordenar Por Contato"
        Me.btnOrdenarContato.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 497)
        Me.Controls.Add(Me.btnOrdenarContato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContato)
        Me.Controls.Add(Me.btnCarregarDados)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form6"
        Me.Text = "Formulário 6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCarregarDados As Button
    Friend WithEvents txtContato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOrdenarContato As Button
End Class
