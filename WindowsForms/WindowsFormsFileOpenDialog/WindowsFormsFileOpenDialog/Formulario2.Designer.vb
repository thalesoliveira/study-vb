<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(415, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(153, 21)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(241, 22)
        Me.txtFileName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Selecione um Arquivo:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 77)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(474, 342)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'Formulario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 463)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFileName)
        Me.Name = "Formulario2"
        Me.Text = "Formulario2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
