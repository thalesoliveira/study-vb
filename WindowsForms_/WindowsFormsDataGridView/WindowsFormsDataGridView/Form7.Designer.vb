<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.btnXML = New System.Windows.Forms.Button()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.btnObjetos = New System.Windows.Forms.Button()
        Me.btnObjetosTipados = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(753, 277)
        Me.DataGridView1.TabIndex = 0
        '
        'btnXML
        '
        Me.btnXML.Location = New System.Drawing.Point(13, 327)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(108, 30)
        Me.btnXML.TabIndex = 1
        Me.btnXML.Text = "Load XML"
        Me.btnXML.UseVisualStyleBackColor = True
        '
        'btnTxt
        '
        Me.btnTxt.Location = New System.Drawing.Point(143, 327)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(114, 30)
        Me.btnTxt.TabIndex = 2
        Me.btnTxt.Text = "Load TXT"
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'btnObjetos
        '
        Me.btnObjetos.Location = New System.Drawing.Point(275, 327)
        Me.btnObjetos.Name = "btnObjetos"
        Me.btnObjetos.Size = New System.Drawing.Size(106, 30)
        Me.btnObjetos.TabIndex = 3
        Me.btnObjetos.Text = "Coleções"
        Me.btnObjetos.UseVisualStyleBackColor = True
        '
        'btnObjetosTipados
        '
        Me.btnObjetosTipados.Location = New System.Drawing.Point(402, 327)
        Me.btnObjetosTipados.Name = "btnObjetosTipados"
        Me.btnObjetosTipados.Size = New System.Drawing.Size(98, 30)
        Me.btnObjetosTipados.TabIndex = 4
        Me.btnObjetosTipados.Text = "Coleções 2"
        Me.btnObjetosTipados.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 375)
        Me.Controls.Add(Me.btnObjetosTipados)
        Me.Controls.Add(Me.btnObjetos)
        Me.Controls.Add(Me.btnTxt)
        Me.Controls.Add(Me.btnXML)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.Text = "Formulário 7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnXML As Button
    Friend WithEvents btnTxt As Button
    Friend WithEvents btnObjetos As Button
    Friend WithEvents btnObjetosTipados As Button
End Class
