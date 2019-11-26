<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario2
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
        Me.components = New System.ComponentModel.Container()
        Me.cboEstacao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.NorthwndDataSet = New WindowsFormsComboBox.northwndDataSet()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New WindowsFormsComboBox.northwndDataSetTableAdapters.CategoriesTableAdapter()
        CType(Me.NorthwndDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEstacao
        '
        Me.cboEstacao.ForeColor = System.Drawing.Color.YellowGreen
        Me.cboEstacao.FormattingEnabled = True
        Me.cboEstacao.Location = New System.Drawing.Point(537, 23)
        Me.cboEstacao.Name = "cboEstacao"
        Me.cboEstacao.Size = New System.Drawing.Size(256, 24)
        Me.cboEstacao.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Informe Item:"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(121, 25)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(224, 22)
        Me.txtItem.TabIndex = 2
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(378, 23)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(136, 23)
        Me.btnAdicionar.TabIndex = 3
        Me.btnAdicionar.Text = "Adicionar Item"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(434, 72)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(163, 31)
        Me.btnOrdenar.TabIndex = 4
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(234, 71)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(163, 33)
        Me.btnRemover.TabIndex = 5
        Me.btnRemover.Text = "Remover Item"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(28, 71)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(163, 33)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'NorthwndDataSet
        '
        Me.NorthwndDataSet.DataSetName = "northwndDataSet"
        Me.NorthwndDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.NorthwndDataSet
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'Formulario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 174)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEstacao)
        Me.Name = "Formulario2"
        Me.Text = "Formulario2"
        CType(Me.NorthwndDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboEstacao As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents NorthwndDataSet As northwndDataSet
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As northwndDataSetTableAdapters.CategoriesTableAdapter
End Class
