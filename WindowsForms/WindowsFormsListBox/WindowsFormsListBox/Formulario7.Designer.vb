﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario7
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
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Brasil", "Argentina ", "Bolívia ", "Colômbia ", "Guiana ", "Venezuela ", "Chile", "Equador", "Paraguai", "Peru ", "Suriname", "Uruguai"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 158)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(476, 212)
        Me.ListBox1.TabIndex = 0
        '
        'txtProcurar
        '
        Me.txtProcurar.Location = New System.Drawing.Point(12, 12)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(476, 22)
        Me.txtProcurar.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Procurar - FindString"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(237, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Procurar - FindStringExact"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Formulario7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 382)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtProcurar)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Formulario7"
        Me.Text = "Formulario7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtProcurar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
