<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario1
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
        Me.listBoxEstados = New System.Windows.Forms.ListBox()
        Me.btnExibirMulti = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.TextBoxSelectedIndex = New System.Windows.Forms.TextBox()
        Me.TextBoxSelectedItem = New System.Windows.Forms.TextBox()
        Me.TextBoxItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxItemAdd = New System.Windows.Forms.TextBox()
        Me.btnAdicionarItem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listBoxEstados
        '
        Me.listBoxEstados.FormattingEnabled = True
        Me.listBoxEstados.ItemHeight = 16
        Me.listBoxEstados.Items.AddRange(New Object() {"Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA) ", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)"})
        Me.listBoxEstados.Location = New System.Drawing.Point(23, 26)
        Me.listBoxEstados.Name = "listBoxEstados"
        Me.listBoxEstados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.listBoxEstados.Size = New System.Drawing.Size(224, 244)
        Me.listBoxEstados.TabIndex = 0
        '
        'btnExibirMulti
        '
        Me.btnExibirMulti.Location = New System.Drawing.Point(254, 26)
        Me.btnExibirMulti.Name = "btnExibirMulti"
        Me.btnExibirMulti.Size = New System.Drawing.Size(139, 45)
        Me.btnExibirMulti.TabIndex = 1
        Me.btnExibirMulti.Text = "Exibir Multi-Seleção"
        Me.btnExibirMulti.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(254, 90)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(139, 40)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.Text = "Limpar Itens"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(254, 149)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(139, 41)
        Me.btnRemover.TabIndex = 3
        Me.btnRemover.Text = "Remover Item"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(254, 215)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(139, 42)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'TextBoxSelectedIndex
        '
        Me.TextBoxSelectedIndex.Location = New System.Drawing.Point(123, 306)
        Me.TextBoxSelectedIndex.Name = "TextBoxSelectedIndex"
        Me.TextBoxSelectedIndex.Size = New System.Drawing.Size(124, 22)
        Me.TextBoxSelectedIndex.TabIndex = 5
        '
        'TextBoxSelectedItem
        '
        Me.TextBoxSelectedItem.Location = New System.Drawing.Point(123, 347)
        Me.TextBoxSelectedItem.Name = "TextBoxSelectedItem"
        Me.TextBoxSelectedItem.Size = New System.Drawing.Size(124, 22)
        Me.TextBoxSelectedItem.TabIndex = 6
        '
        'TextBoxItem
        '
        Me.TextBoxItem.Location = New System.Drawing.Point(67, 385)
        Me.TextBoxItem.Name = "TextBoxItem"
        Me.TextBoxItem.Size = New System.Drawing.Size(180, 22)
        Me.TextBoxItem.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SelectedIndex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SelectedItem:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Item:"
        '
        'TextBoxItemAdd
        '
        Me.TextBoxItemAdd.Location = New System.Drawing.Point(67, 438)
        Me.TextBoxItemAdd.Name = "TextBoxItemAdd"
        Me.TextBoxItemAdd.Size = New System.Drawing.Size(180, 22)
        Me.TextBoxItemAdd.TabIndex = 11
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.Location = New System.Drawing.Point(254, 432)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.Size = New System.Drawing.Size(139, 34)
        Me.btnAdicionarItem.TabIndex = 12
        Me.btnAdicionarItem.Text = "Adicionar Item"
        Me.btnAdicionarItem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Item:"
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 504)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAdicionarItem)
        Me.Controls.Add(Me.TextBoxItemAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxItem)
        Me.Controls.Add(Me.TextBoxSelectedItem)
        Me.Controls.Add(Me.TextBoxSelectedIndex)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnExibirMulti)
        Me.Controls.Add(Me.listBoxEstados)
        Me.Name = "Formulario1"
        Me.Text = "Lista com Items"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listBoxEstados As ListBox
    Friend WithEvents btnExibirMulti As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents TextBoxSelectedIndex As TextBox
    Friend WithEvents TextBoxSelectedItem As TextBox
    Friend WithEvents TextBoxItem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxItemAdd As TextBox
    Friend WithEvents btnAdicionarItem As Button
    Friend WithEvents Label4 As Label
End Class
