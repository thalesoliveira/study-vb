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
        Me.components = New System.ComponentModel.Container()
        Me.btnCarregarCombo = New System.Windows.Forms.Button()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIndex = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.NorthwndDataSet = New WindowsFormsComboBox.northwndDataSet()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New WindowsFormsComboBox.northwndDataSetTableAdapters.CategoriesTableAdapter()
        CType(Me.NorthwndDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCarregarCombo
        '
        Me.btnCarregarCombo.Location = New System.Drawing.Point(30, 30)
        Me.btnCarregarCombo.Name = "btnCarregarCombo"
        Me.btnCarregarCombo.Size = New System.Drawing.Size(126, 36)
        Me.btnCarregarCombo.TabIndex = 0
        Me.btnCarregarCombo.Text = "Carregar Combo"
        Me.btnCarregarCombo.UseVisualStyleBackColor = True
        '
        'cboCategoria
        '
        Me.cboCategoria.DataSource = Me.CategoriesBindingSource
        Me.cboCategoria.DisplayMember = "CategoryName"
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(93, 115)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(280, 24)
        Me.cboCategoria.TabIndex = 1
        Me.cboCategoria.ValueMember = "CategoryID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DropDown"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SelectedIndex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SelectedItem"
        '
        'txtIndex
        '
        Me.txtIndex.Location = New System.Drawing.Point(116, 173)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Size = New System.Drawing.Size(162, 22)
        Me.txtIndex.TabIndex = 6
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(116, 207)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(162, 22)
        Me.txtItem.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SelectedValue"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(119, 240)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtValue.Size = New System.Drawing.Size(159, 22)
        Me.txtValue.TabIndex = 9
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
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 341)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtIndex)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.btnCarregarCombo)
        Me.Name = "Formulario1"
        Me.Text = "Formulario1"
        CType(Me.NorthwndDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCarregarCombo As Button
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIndex As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents NorthwndDataSet As northwndDataSet
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As northwndDataSetTableAdapters.CategoriesTableAdapter
End Class
