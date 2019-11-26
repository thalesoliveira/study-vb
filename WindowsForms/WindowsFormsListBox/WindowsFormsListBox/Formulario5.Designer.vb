<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario5
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(37, 232)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 37)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(175, 232)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(114, 37)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "Remover"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(37, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(252, 180)
        Me.ListBox1.TabIndex = 2
        '
        'Formulario5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 281)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Formulario5"
        Me.Text = "Lista de Meses"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents ListBox1 As ListBox
End Class
