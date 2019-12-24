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
        Me.fsw1 = New System.IO.FileSystemWatcher()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textProcurar = New System.Windows.Forms.TextBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbRenomeados = New System.Windows.Forms.ListBox()
        Me.lbNovos = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbRemovidos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbAlterados = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.fsw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fsw1
        '
        Me.fsw1.EnableRaisingEvents = True
        Me.fsw1.IncludeSubdirectories = True
        Me.fsw1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caminho Path à Monitorar"
        '
        'textProcurar
        '
        Me.textProcurar.Location = New System.Drawing.Point(16, 45)
        Me.textProcurar.Multiline = True
        Me.textProcurar.Name = "textProcurar"
        Me.textProcurar.Size = New System.Drawing.Size(572, 34)
        Me.textProcurar.TabIndex = 1
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(604, 45)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(90, 34)
        Me.btnProcurar.TabIndex = 2
        Me.btnProcurar.Text = "Procurar..."
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Renomeados"
        '
        'lbRenomeados
        '
        Me.lbRenomeados.FormattingEnabled = True
        Me.lbRenomeados.ItemHeight = 16
        Me.lbRenomeados.Location = New System.Drawing.Point(19, 131)
        Me.lbRenomeados.Name = "lbRenomeados"
        Me.lbRenomeados.Size = New System.Drawing.Size(675, 68)
        Me.lbRenomeados.TabIndex = 4
        '
        'lbNovos
        '
        Me.lbNovos.FormattingEnabled = True
        Me.lbNovos.ItemHeight = 16
        Me.lbNovos.Location = New System.Drawing.Point(16, 249)
        Me.lbNovos.Name = "lbNovos"
        Me.lbNovos.Size = New System.Drawing.Size(678, 68)
        Me.lbNovos.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Novos"
        '
        'lbRemovidos
        '
        Me.lbRemovidos.FormattingEnabled = True
        Me.lbRemovidos.ItemHeight = 16
        Me.lbRemovidos.Location = New System.Drawing.Point(16, 366)
        Me.lbRemovidos.Name = "lbRemovidos"
        Me.lbRemovidos.Size = New System.Drawing.Size(678, 68)
        Me.lbRemovidos.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Removidos"
        '
        'lbAlterados
        '
        Me.lbAlterados.FormattingEnabled = True
        Me.lbAlterados.ItemHeight = 16
        Me.lbAlterados.Location = New System.Drawing.Point(16, 492)
        Me.lbAlterados.Name = "lbAlterados"
        Me.lbAlterados.Size = New System.Drawing.Size(678, 68)
        Me.lbAlterados.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Alterados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 620)
        Me.Controls.Add(Me.lbAlterados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbRemovidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbNovos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbRenomeados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProcurar)
        Me.Controls.Add(Me.textProcurar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "File System Watcher"
        CType(Me.fsw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fsw1 As IO.FileSystemWatcher
    Friend WithEvents btnProcurar As Button
    Friend WithEvents textProcurar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fbd1 As FolderBrowserDialog
    Friend WithEvents lbAlterados As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbRemovidos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbNovos As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbRenomeados As ListBox
    Friend WithEvents Label2 As Label
End Class
